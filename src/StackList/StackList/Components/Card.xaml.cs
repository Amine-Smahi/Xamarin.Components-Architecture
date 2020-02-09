using StackList.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackList.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Card : ContentView
    {
        private CardProperties CardProperties { get; set; }
        public Card(CardProperties cardProperties)
        {
            InitializeComponent();
            CardProperties = cardProperties;
            FillCardDetails();
        }

        private void FillCardDetails()
        {
            CardImage.Source = CardProperties.ImagePath;
            Title.Text = CardProperties.Title;
            Description.Text = CardProperties.Description;
            if (CardProperties.IsLiked)
            {
                like.BackgroundColor = Color.Black;
            }
            else
            {
                like.BackgroundColor = Color.Gray;
            }
        }

        private void Like_Clicked(object sender, EventArgs e)
        {
            var c = FakeDB.InfoList;
            if (CardProperties.IsLiked)
            {
                CardProperties.IsLiked = false;
                FakeDB.InfoList[CardProperties.Id].IsLiked = false;
                like.BackgroundColor = Color.Gray;
            }
            else
            {
                CardProperties.IsLiked = true; 
                FakeDB.InfoList.Where(x => x.Id == CardProperties.Id).FirstOrDefault().IsLiked = true;
                like.BackgroundColor = Color.Black;
            }     
        }
    }

}