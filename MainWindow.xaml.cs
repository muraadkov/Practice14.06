using Newtonsoft.Json;
using Practice14._06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using unirest_net.http;

namespace Practice24._06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Task<HttpResponse<string>> response = Unirest.get("https://omgvamp-hearthstone-v1.p.rapidapi.com/info")
       .header("X-RapidAPI-Host", "omgvamp-hearthstone-v1.p.rapidapi.com")
 .header("X-RapidAPI-Key", "4c0c5f5e40mshcd1489f0401fd6fp1faea0jsnb48714c0f5f8")
 .asJsonAsync<string>();
            //var gr = response.ToString();
            var _allCharacters = JsonConvert.DeserializeObject<Characters>(response.Result.Body);
            foreach(var sets in _allCharacters.sets)
            {
                setsBox.Items.Add(sets);
            }
            foreach(var classes in _allCharacters.classes)
            {
                classesBox.Items.Add(classes);
            }
            foreach(var standard in _allCharacters.factions)
            {
                standardBox.Items.Add(standard);
            }
            foreach (var wild in _allCharacters.wild)
            {
                wildBox.Items.Add(wild);
            }
            foreach (var types in _allCharacters.types)
            {
                typesBox.Items.Add(types);
            }
        }

        private void continue_Click(object sender, RoutedEventArgs e)
        {
            Task<HttpResponse<string>> response = Unirest.get("https://omgvamp-hearthstone-v1.p.rapidapi.com/info")
       .header("X-RapidAPI-Host", "omgvamp-hearthstone-v1.p.rapidapi.com")
 .header("X-RapidAPI-Key", "4c0c5f5e40mshcd1489f0401fd6fp1faea0jsnb48714c0f5f8")
 .asJsonAsync<string>();
            //var gr = response.ToString();
            var _allCharacters = JsonConvert.DeserializeObject<Characters>(response.Result.Body);
            sets.Visibility = Visibility.Collapsed;
            standard.Visibility = Visibility.Collapsed;
            wild.Visibility = Visibility.Collapsed;
            classes.Visibility = Visibility.Collapsed;
            types.Visibility = Visibility.Collapsed;
            factions.Visibility = Visibility.Visible;
            qualities.Visibility = Visibility.Visible;
            races.Visibility = Visibility.Visible;
            locales.Visibility = Visibility.Visible;
            foreach (var factions in _allCharacters.factions)
            {
                factionsBox.Items.Add(factions);
            }
            foreach (var qualities in _allCharacters.qualities)
            {
                qualitiesBox.Items.Add(qualities);
            }
            foreach (var races in _allCharacters.races)
            {
                racesBox.Items.Add(races);
            }
            foreach (var locales in _allCharacters.locales)
            {
                localesBox.Items.Add(locales);
            }
        }
    }
}
