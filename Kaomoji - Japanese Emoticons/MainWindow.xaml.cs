using Kaomoji___Japanese_Emoticons.Data;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wpf_Japanese_Kaomoji;
using Clipboard = System.Windows.Clipboard;
using MessageBox = System.Windows.MessageBox;

namespace Kaomoji___Japanese_Emoticons
{
    public partial class MainWindow : Window
    {
        private readonly SettingsUtility Loader;
        public MainWindow()
        {
            Loader = new SettingsUtility();
            InitializeComponent();
            AddCategories();
            TopMost();
        }

        //On Window loaded Functions
        private void AddCategories()
        {
            foreach (string item in Emojis.categories)
            {
                _CategoriesCB.Items.Add(item);
            }
            _CategoriesCB.SelectedIndex = Loader.CategoryIndex;
        }

        //Window Functions
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CategoriesCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeTypeCB(_CategoriesCB.SelectedIndex);
            Loader.VCategoryIndexWriter(_CategoriesCB.SelectedIndex);
            Loader.VCategoryTypeIndexWriter(0);
            AddToFavBtn.Visibility = Visibility.Visible;
            RemoveToFavBtn.Visibility = Visibility.Hidden;
        }
        private void CategoriesTypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeEmojiList();
            Loader.VCategoryIndexWriter(_CategoriesCB.SelectedIndex);
            Loader.VCategoryTypeIndexWriter(_CategoriesTypeCB.SelectedIndex);
            AddToFavBtn.Visibility = Visibility.Visible;
            RemoveToFavBtn.Visibility = Visibility.Hidden;
        }
        private void EmojiLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Clipboard.SetText(_EmojiLB.SelectedItem.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void EmojisAdd(string[] emojiArray)
        {
            _EmojiLB.Items.Clear();
            foreach (string emoji in emojiArray)
            {
                _EmojiLB.Items.Add(emoji);
            }
        }
        private void TypeAdd(string[] TypeArray)
        {
            _CategoriesTypeCB.Items.Clear();
            foreach (string item in TypeArray)
            {
                _CategoriesTypeCB.Items.Add(item);
            }
            _CategoriesTypeCB.SelectedIndex = Loader.CategoryTypeIndex;
        }
        private void ChangeEmojiList()
        {
            int index = _CategoriesCB.SelectedIndex;
            int indexType = _CategoriesTypeCB.SelectedIndex;
            switch (index)
            {
                case 0:
                    switch (indexType)
                    {
                        case 0:
                            EmojisAdd(Emojis.positiveEmotionsJoy);
                            break;
                        case 1:
                            EmojisAdd(Emojis.positiveEmotionsLove);
                            break;
                        case 2:
                            EmojisAdd(Emojis.positiveEmotionsEmbarrassment);
                            break;
                        case 3:
                            EmojisAdd(Emojis.positiveEmotionsSympathy);
                            break;
                        case 4:
                            _EmojiLB.Items.Clear();
                            foreach (string emoji in Emojis.positiveEmotionsJoy)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.positiveEmotionsLove)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.positiveEmotionsEmbarrassment)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.positiveEmotionsSympathy)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            break;
                    }
                    break;
                case 1:
                    switch (indexType)
                    {
                        case 0:
                            EmojisAdd(Emojis.negativeEmotionsDissatisfaction);
                            break;
                        case 1:
                            EmojisAdd(Emojis.negativeEmotionsAnger);
                            break;
                        case 2:
                            EmojisAdd(Emojis.negativeEmotionsSadness);
                            break;
                        case 3:
                            EmojisAdd(Emojis.negativeEmotionsPain);
                            break;
                        case 4:
                            EmojisAdd(Emojis.negativeEmotionsFear);
                            break;
                        case 5:
                            _EmojiLB.Items.Clear();
                            foreach (string emoji in Emojis.negativeEmotionsDissatisfaction)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.negativeEmotionsAnger)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.negativeEmotionsSadness)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.negativeEmotionsPain)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            foreach (string emoji in Emojis.negativeEmotionsFear)
                            {
                                _EmojiLB.Items.Add(emoji);
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (indexType)
                    {
                        case 0:
                            EmojisAdd(Emojis.neutralEmotionsIndifference);
                            break;
                        case 1:
                            EmojisAdd(Emojis.neutralEmotionsConfusion);
                            break;
                        case 2:
                            EmojisAdd(Emojis.neutralEmotionsDoubt);
                            break;
                        case 3:
                            EmojisAdd(Emojis.neutralEmotionsSurprise);
                            break;
                        case 4:
                            _EmojiLB.Items.Clear();
                            foreach (string item in Emojis.neutralEmotionsIndifference)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.neutralEmotionsConfusion)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.neutralEmotionsDoubt)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.neutralEmotionsSurprise)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (indexType)
                    {
                        case 0:
                            EmojisAdd(Emojis.variousActionsGreeting);
                            break;
                        case 1:
                            EmojisAdd(Emojis.variousActionsHugging);
                            break;
                        case 2:
                            EmojisAdd(Emojis.variousActionsWinking);
                            break;
                        case 3:
                            EmojisAdd(Emojis.variousActionsApologizing);
                            break;
                        case 4:
                            EmojisAdd(Emojis.variousActionsNosebleeding);
                            break;
                        case 5:
                            EmojisAdd(Emojis.variousActionsHiding);
                            break;
                        case 6:
                            EmojisAdd(Emojis.variousActionsWriting);
                            break;
                        case 7:
                            EmojisAdd(Emojis.variousActionsRunning);
                            break;
                        case 8:
                            EmojisAdd(Emojis.variousActionsSleeping);
                            break;
                        case 9:
                            _EmojiLB.Items.Clear();
                            foreach (string item in Emojis.variousActionsGreeting)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsHugging)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsWinking)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsApologizing)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsNosebleeding)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsHiding)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsWriting)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsRunning)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.variousActionsSleeping)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (indexType)
                    {
                        case 0:
                            EmojisAdd(Emojis.animalsCat);
                            break;
                        case 1:
                            EmojisAdd(Emojis.animalsBear);
                            break;
                        case 2:
                            EmojisAdd(Emojis.animalsDog);
                            break;
                        case 3:
                            EmojisAdd(Emojis.animalsRabbit);
                            break;
                        case 4:
                            EmojisAdd(Emojis.animalsPig);
                            break;
                        case 5:
                            EmojisAdd(Emojis.animalsBird);
                            break;
                        case 6:
                            EmojisAdd(Emojis.animalsFish);
                            break;
                        case 7:
                            EmojisAdd(Emojis.animalsSpider);
                            break;
                        case 8:
                            _EmojiLB.Items.Clear();
                            foreach (string item in Emojis.animalsCat)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsBear)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsDog)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsRabbit)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsPig)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsBird)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsFish)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.animalsSpider)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            break;
                    }
                    break;
                case 5:
                    switch (indexType)
                    {
                        case 0:
                            EmojisAdd(Emojis.otherTypesFriends);
                            break;
                        case 1:
                            EmojisAdd(Emojis.otherTypesEnemies);
                            break;
                        case 2:
                            EmojisAdd(Emojis.otherTypesWeapons);
                            break;
                        case 3:
                            EmojisAdd(Emojis.otherTypesMagic);
                            break;
                        case 4:
                            EmojisAdd(Emojis.otherTypesFood);
                            break;
                        case 5:
                            EmojisAdd(Emojis.otherTypesMusic);
                            break;
                        case 6:
                            EmojisAdd(Emojis.otherTypesGames);
                            break;
                        case 7:
                            EmojisAdd(Emojis.otherTypesFaces);
                            break;
                        case 8:
                            EmojisAdd(Emojis.otherTypesSpecial);
                            break;
                        case 9:
                            _EmojiLB.Items.Clear();
                            foreach (string item in Emojis.otherTypesFriends)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesEnemies)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesWeapons)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesMagic)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesFood)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesMusic)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesGames)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesFaces)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            foreach (string item in Emojis.otherTypesSpecial)
                            {
                                _EmojiLB.Items.Add(item);
                            }
                            break;
                    }
                    break;
            }
        }
        private void ChangeTypeCB(int index)
        {
            switch (index)
            {
                case 0:
                    TypeAdd(Emojis.positiveEmotionsList);
                    break;
                case 1:
                    TypeAdd(Emojis.negativeEmotionsList);
                    break;
                case 2:
                    TypeAdd(Emojis.neutralEmotionsList);
                    break;
                case 3:
                    TypeAdd(Emojis.variousActionsList);
                    break;
                case 4:
                    TypeAdd(Emojis.animalsList);
                    break;
                case 5:
                    TypeAdd(Emojis.otherTypesList);
                    break;
            }
        }

        //Menu Items Functions
        private void MenuItemInfo_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItemAbout_Click(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show("this program is created by Nexus\n" +
            "Dm me if there is any bugs or the features you wish to add\n\n" +
            "Use this program at your own risk!", "About", MessageBoxButton.OK);
        }
        private void MenuItemHelp_Click(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show("In the first column of combo box is a categories of the emoji\n" +
            "is second colunm of combo box is a type of categories of the emoji\n" +
            "Click the emoji that you want in the emoji list, it will automatticaly copy!\n" +
            "\"Help\" Button is to show this window\n" +
            "\"About\" Button is to show the details of this program\n" +
            "\"Favorites\" Button is to show all of you favorite emojis\n" +
            "\"+\" Button is to add the selected emoji to the favorites list\n" +
            "\"-\" Button you will see this button if you click the \"Favorites\" Button, \n" +
            "\"-\" this button is also remove the selected item in your favorite list", "Help", MessageBoxButton.OK);
        }
        private void MenuItemSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            Close();
        }
        //Nothing
        private void MenuItemThemes_Click(object sender, RoutedEventArgs e)
        {

        }

        //Favorite Functions
        private void FavBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowFavorites();
        }
        private void ShowFavorites()
        {
            _EmojiLB.Items.Clear();
            foreach (string emoji in Loader.FavStrSplit())
            {
                _EmojiLB.Items.Add(emoji);
            }
            AddToFavBtn.Visibility = Visibility.Hidden;
            RemoveToFavBtn.Visibility = Visibility.Visible;
            _EmojiLB.Items.Remove("");
            _EmojiLB.Items.Remove(" ");
            _EmojiLB.Items.Remove(null);
        }
        private void AddToFavBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string emoji = _EmojiLB.SelectedItem.ToString();
                if (!Loader.Favorites.Contains(emoji))
                {
                    Loader.Favorites += '5' + emoji;
                    Loader.VFavoritesWriter();
                }
            }
            catch (NullReferenceException) { }
        }
        private void RemoveToFavBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string temp = "5" + _EmojiLB.SelectedItem.ToString();
                Loader.Favorites = Loader.Favorites.Replace(temp, "");
                Loader.VFavoritesWriter();
                ShowFavorites();
            }
            catch (Exception)
            {

            }
        }

        //Always On Top Functions
        private void AlwaysOnTop_Checked(object sender, RoutedEventArgs e)
        {
            LoaderData(0, true);
        }
        private void AlwaysOnTop_Unchecked(object sender, RoutedEventArgs e)
        {
            LoaderData(1, false);
        }
        private void LoaderData(int i, bool b)
        {
            _Window.Topmost = b;
            Loader.AlwaysOnTop = i;
            Loader.VAlwaysOnTopWriter(i);
        }
        private void TopMost()
        {
            switch (Loader.AlwaysOnTop)
            {
                case 0:
                    _AlwaysOnTop.IsChecked = true;
                    _Window.Topmost = true;
                    break;
                case 1:
                    _AlwaysOnTop.IsChecked = false;
                    _Window.Topmost = false;
                    break;
            }
        }
    }
}
