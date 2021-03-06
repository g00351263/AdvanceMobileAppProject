﻿using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace App5
{
    public partial class ContactListPage : ContentPage
    {
        public ContactListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e) // after saved display on page//
        {
            await Navigation.PushAsync(new ContactItemPage
            {
                BindingContext = new Contact()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
            //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ContactItemPage // getting the list selected displayed on screen //
                {
                    BindingContext = e.SelectedItem as Contact
                });
            }
        }
    }
}
