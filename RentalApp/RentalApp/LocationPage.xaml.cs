﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LocationPage : ContentPage
	{
		public LocationPage ()
		{
			InitializeComponent ();
		}

		async void OnAddLocationClicked(object sender, EventArgs e)
		{
			//await Navigation.PushAsync(new ProfilePage());
		}
		async void OnReturnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ProfilePage());
		}

		async void OnHomeClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new HomePage());
		}
	}
}