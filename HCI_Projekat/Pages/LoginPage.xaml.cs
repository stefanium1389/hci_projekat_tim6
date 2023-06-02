﻿using HCI_Projekat.Model;
using HCI_Projekat.Service;
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

namespace HCI_Projekat.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void GoToRegister(object sender, RoutedEventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            NavigationService.Navigate(registrationPage);
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            string email = Email.Text;
            string password = Password.Password;
            User u = UserService.Login(email, password);
            if (u != null)
            {
                new MessageBoxCustom("Uspešno ste se ulogovali!", MessageType.Success, MessageButtons.Ok).ShowDialog();
            } else
            {
                new MessageBoxCustom("Prijava nije uspela!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
            }
            //OutputTextBlock.Text = "Email: " + email + "\nPassword: " + password;
        }


    }
}
