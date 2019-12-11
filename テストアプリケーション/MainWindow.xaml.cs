
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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


namespace テストアプリケーション
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private int counter = 0;
        private TextBox[] myText = new TextBox[10];

        GreetinfgClass greeting;
        public MainWindow()
        {
           
            InitializeComponent();
            greeting = new GreetinfgClass
            {
                greet = "要求"
            };
            this.DataContext = greeting;
        }

     

        
        private void button_Click(object sender, RoutedEventArgs e)
        {
          
                if (counter >= 10)
                {
                    MessageBox.Show("満杯");
                    return;
                }
                else
                {
                    Addbutton.Margin = new Thickness(314, 278+70*counter, 0, 0);
                    myText[counter] = new TextBox();
                    myText[counter].Name = "a";
                    myText[counter].Width = 214;
                    myText[counter].Height = 47;
                    myText[counter].HorizontalAlignment = 0;
                    myText[counter].VerticalAlignment = 0;
                    myText[counter].Margin = new Thickness(265, 150+70*counter, 0, 0);
                    myText[counter].Text = "仕様";
                    grid.Children.Add(myText[counter]);
                    counter++;
                }

            
              

                 
                
           
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void greetingText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Savebutton_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
