﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin_3_Opgaver.Models;
using Xamarin.Forms;

namespace Xamarin_3_Opgaver.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {

        public Command TestCommand { get; private set; }

        public ItemDetailViewModel()
        {
            TestCommand = new Command(
                execute: () => MessagingCenter.Send(this, "TestButtonClicked")
                );
        }

        private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
