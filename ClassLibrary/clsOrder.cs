using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public double OrderPrice { get; set; }
    }
}