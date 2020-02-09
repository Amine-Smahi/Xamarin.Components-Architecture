using StackList.Components;
using StackList.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackList.Components
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class CardListView : ContentView
    {
        public List<CardProperties> VirtualList { get; set; }
        public int ScrolledToBottom { get; set; } = 0;
        public List<CardProperties> OriginList { get; set; }

        public CardListView()
        {
            InitializeComponent();
            RefreshPage.IsRefreshing = false;
            OriginList = new List<CardProperties>();
            VirtualList = new List<CardProperties>();
            OriginList.AddRange(FakeDB.InfoList);
            VirtualList.AddRange(OriginList);    
            FillRepeater();
        }

        private void FillRepeater()
        {
            int numbertimes = VirtualList.Count / 10;
            if (numbertimes > 0)
            {
                try
                {
                    StackLayout stackLayout = new StackLayout();
                    for (int j = 0; j < 10; j++)
                    {
                        stackLayout.Children.Add(new Card(new CardProperties()
                        {
                            Id = VirtualList[j].Id,
                            Title = VirtualList[j].Title,
                            Description = VirtualList[j].Description,
                            ImagePath = VirtualList[j].ImagePath,
                            IsLiked = VirtualList[j].IsLiked
                        }));
                    }
                    VirtualList.RemoveRange(0, 10);
                    repeater.Children.Add(stackLayout);
                    ScrolledToBottom = 0;
                }
                catch (Exception){}
            }
        }

        private void RefreshPage_Refreshing(object sender, EventArgs e)
        {
            repeater.Children.Clear();
            VirtualList = new List<CardProperties>();
            VirtualList.AddRange(OriginList);
            FillRepeater();
            RefreshPage.IsRefreshing = false;
        }

        private async void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (!(sender is ScrollView scrollView))
                return;

            await GoToTopListVisibility.FadeTo(1, 200, Easing.Linear);

            var scrollingSpace = scrollView.ContentSize.Height - scrollView.Height - 25;

            if (scrollingSpace > e.ScrollY)
            {
                return;
            }

             ScrolledToBottom += 1;

            if (ScrolledToBottom == 1)
            {
                Loading loading = new Loading();
                repeater.Children.Add(loading);
                await Task.Delay(1000);
                FillRepeater();
                repeater.Children.Remove(loading);
            }
        }

        private async void GoTopList_Clicked(object sender, EventArgs e)
        {
            await Scroll.ScrollToAsync(0, 0, true);
            await GoToTopListVisibility.FadeTo(0, 800, Easing.Linear);
        }
    }
}
