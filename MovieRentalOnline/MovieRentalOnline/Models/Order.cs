using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Order
    {
        public Order() { }
        public int OrderId { get; set; } //klucz glowny
        public int ClientId { get; set; }    // polaczone z jednym klientem
        public int AdditionalInformation { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public virtual ICollection<Rent> Rents { get; set; } //polaczone z wieloma wypozyczeniami
        public virtual Client Client { get; set; }  // polaczone z jednym klientem
    }

    public enum OrderStatus
    {
        Sent,
        Delivered,
        CourierSent,
        Returned,
        Canceled
    }
}