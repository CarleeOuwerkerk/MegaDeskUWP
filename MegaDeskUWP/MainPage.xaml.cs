using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MegaDeskUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void newQuoteButton_Click(object sender, RoutedEventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            //addQuoteForm.Show();
            //this.Hide();
        }

        private void viewQuotesButton_Click(object sender, RoutedEventArgs e)
        {
            ViewQuotes viewQuotesForm = new ViewQuotes();
            //viewQuotesForm.Show();
            //this.Hide();
        }

        private void searchQuotesButton_Click(object sender, RoutedEventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            //searchQuotesForm.Show();
            //this.Hide();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
