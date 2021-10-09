using Microsoft.Win32;
using System;

namespace Kaomoji___Japanese_Emoticons
{
    class SettingsUtility
    {
        public int CategoryIndex;
        public int CategoryTypeIndex;
        public int AlwaysOnTop;
        public string Favorites;
        public int DarkMode;

        private readonly string key = "HKEY_CURRENT_USER\\Software\\NexusPrograms\\KaomojiAppV2";
        private readonly string VCategoryIndex = "VCI";
        private readonly string VCategoryTypeIndex = "VCTI";
        private readonly string VAlwaysOnTop = "VAOT";
        private readonly string VFavorites = "VF";
        private readonly string VDarkMode = "VDM";

        public SettingsUtility()
        {
            var CategoryIndexLocal = Registry.GetValue(key, VCategoryIndex, null);
            var CategoryTypeIndexLocal = Registry.GetValue(key, VCategoryTypeIndex, null);
            var AlwaysOnTopLocal = Registry.GetValue(key, VAlwaysOnTop, null);
            var FavoritesLocal = Registry.GetValue(key, VFavorites, null);
            var DarkModeLocal = Registry.GetValue(key, VDarkMode, null);

            if (CategoryIndexLocal != null ||
                CategoryTypeIndexLocal != null ||
                AlwaysOnTopLocal != null ||
                FavoritesLocal != null ||
                DarkModeLocal != null)
            {
                CategoryIndex = Convert.ToInt32(Registry.GetValue(key, VCategoryIndex, null));
                CategoryTypeIndex = Convert.ToInt32(Registry.GetValue(key, VCategoryTypeIndex, null));
                AlwaysOnTop = Convert.ToInt32(Registry.GetValue(key, VAlwaysOnTop, null));
                Favorites = Registry.GetValue(key, VFavorites, null).ToString();
                DarkMode = Convert.ToInt32(Registry.GetValue(key, VDarkMode, null));
            }
            else
            {
                Registry.SetValue(key, VCategoryIndex, 0);
                Registry.SetValue(key, VCategoryTypeIndex, 0);
                Registry.SetValue(key, VAlwaysOnTop, 0);
                Registry.SetValue(key, VFavorites, "");
                Registry.SetValue(key, VDarkMode, 0);

                CategoryIndex = 0;
                CategoryTypeIndex = 0;
                AlwaysOnTop = 0;
                Favorites = "";
                DarkMode = 0;
            }
        }
        public string[] FavStrSplit()
        {
            return Favorites.Split('5');
        }

        public void VCategoryIndexWriter(int i)
        {
            Registry.SetValue(key, VCategoryIndex, i);
        }
        public void VCategoryTypeIndexWriter(int i)
        {
            Registry.SetValue(key, VCategoryTypeIndex, i);
        }
        public void VAlwaysOnTopWriter(int i)
        {
            Registry.SetValue(key, VAlwaysOnTop, i);

        }
        public void VFavoritesWriter()
        {
            Registry.SetValue(key, VFavorites, Favorites);
        }
        public void VDarkModeWriter(int i)
        {
            Registry.SetValue(key, VDarkMode, i);

        }
    }
}