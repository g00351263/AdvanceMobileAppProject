using System;
using Xamarin.Forms;

namespace App5
{
    public partial class TodoItemPage : ContentPage
    {
        public TodoItemPage()
        {
            InitializeComponent();
        }

        // save funtion//
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext; // binding the todoitem
            await App.Database.SaveItemAsync(todoItem); //saving in database
            await Navigation.PopAsync(); // going back to list page
        }

        //delete function
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        // cancel the saving function
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}
