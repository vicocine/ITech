//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITech.Models
{
    using System;
    
    public partial class sp_ListOrderByShop_Result
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public string ShopID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string Address { get; set; }
        public string Receiver { get; set; }
        public string AddressType { get; set; }
        public Nullable<int> Status { get; set; }
        public string DeliveryNote { get; set; }
        public string OrderNote { get; set; }
        public string Phone { get; set; }
        public string ScheduleCurrent { get; set; }
        public Nullable<double> FeeShip { get; set; }
        public string OrderCode { get; set; }
        public string CancelNote { get; set; }
        public Nullable<long> r { get; set; }
    }
}
