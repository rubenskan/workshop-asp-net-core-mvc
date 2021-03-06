﻿using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SeleStatus SeleStatus { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SeleStatus saleStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SeleStatus = saleStatus;
            Seller = seller;
        }
    }
}
