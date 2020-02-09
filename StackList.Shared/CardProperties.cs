using System;

namespace StackList.Shared
{
    public class CardProperties
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsLiked { get; set; } = false;
    }
}
