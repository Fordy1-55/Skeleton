using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductId { get; set; }
        public double ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductKeyWord { get; set; }
        public string ProductColour { get; set; }
        public string ProductImage { get; set; }
    }
}