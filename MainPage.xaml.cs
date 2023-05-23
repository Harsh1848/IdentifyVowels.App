using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;

namespace IdentifyVowels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckVowel_Clicked(object sender, EventArgs e)
        {
            string input = InputEntry.Text.ToLower();

            if (input.Length != 1)
            {
                ResultLabel.Text = "Invalid input. Please enter a single letter.";
                return;
            }

            char letter = input[0];

            if (IsVowel(letter))
            {
                ResultLabel.Text = "Vowel";
            }
            else
            {
                ResultLabel.Text = "Not a vowel";
            }
        }

        private bool IsVowel(char letter)
        {
            switch (char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}
