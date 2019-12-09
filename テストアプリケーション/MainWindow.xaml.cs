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
        public int check = 0;
        GreetinfgClass greeting;
        public MainWindow()
        {
           
            InitializeComponent();
            greeting = new GreetinfgClass
            {
                greet = "こんにちは"
            };
            this.DataContext = greeting;
        }

     

        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (check == 1)
            {

                TextBox myText = new TextBox();
                myText.Name = "a";
                myText.Width = 214;
                myText.Height = 47;
                myText.Margin = new Thickness(265, 150, 0, 0);
                myText.Text = "成功";
                grid.Children.Add(myText);

            }
              

            else
            {

                greetingText.Text = "おはよう";
            }     
                
           
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            check = 1;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void greetingText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
