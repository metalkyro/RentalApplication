﻿using RentalsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LessorAgreementPage : ContentPage
    {
        public LessorAgreementPage()
        {
            InitializeComponent();
        }

        async void OnAgreeClicked(object sender, EventArgs e)
        {
            bool success = RASQLManager.sqlManagerInstance.ChangeAcceptedLA(true);
            if (success)
            {
                await Navigation.PushAsync(new LessorHubPage());
            }
            else await Navigation.PushAsync(new ErrorPage(3));

           
        }

        async void OnDisagreeClicked(object sender, EventArgs e)
        {
            bool success = RASQLManager.sqlManagerInstance.ChangeAcceptedLA(false);
            if (success)
            {
                await Navigation.PushAsync(new LessorHubPage());
            }
            else await Navigation.PushAsync(new ErrorPage(3));
        }
    }
}