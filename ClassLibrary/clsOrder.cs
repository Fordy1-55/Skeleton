using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public double OrderPrice { get; set; }
        public bool OverseasDelivery { get; set; }
        public DateTime DateOrdered { get; set; }
        public string ReturnAddress { get; set; }
        public string DeliveryInstructions { get; set; }
    }
}