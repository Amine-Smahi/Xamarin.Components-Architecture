using System;
using System.Collections.Generic;
using System.Text;

namespace StackList.Shared
{
    public static class FakeDB
    {
        public static List<CardProperties> InfoList = new List<CardProperties>();

        public static void SeedData()
        {
            for (int i = 0; i < 50; i++)
            {
                InfoList.Add(new CardProperties()
                {
                        Id = i,
                        Title =  $"Some Title {i}",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
                        ImagePath = "https://mk0exponeav2vrysryl9.kinstacdn.com/wp-content/uploads/2016/08/exponea-customer-data-management-cloud-css-architecture.jpg"
                });
            }  
        }
    }
}
