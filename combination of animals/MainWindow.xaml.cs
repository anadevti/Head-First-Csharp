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

namespace combination_of_animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setUpGame();
        }

        void setUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "\ud83d\udc35", "\ud83d\udc35",
                "\ud83e\udd81", "\ud83e\udd81",
                "\ud83d\udc37", "\ud83d\udc37",
                "\ud83d\udc31", "\ud83d\udc31",
                "\ud83d\udc2e", "\ud83d\udc2e",
                "\ud83d\udc38", "\ud83d\udc38",
                "\ud83e\udd82", "\ud83e\udd82",
                "\ud83d\udc1e", "\ud83d\udc1e"
            };
            Random rand = new Random();

            foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
            {
                int index = rand.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
            }
        }
    }
}