﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindAPIProject.Model
{
    public partial class CustomerCustomerDemo
    {
        [Column("CustomerID")]
        [StringLength(5)]
        public string CustomerId { get; set; }
        [Column("CustomerTypeID")]
        [StringLength(10)]
        public string CustomerTypeId { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("CustomerCustomerDemo")]
        public Customers Customer { get; set; }
        [ForeignKey("CustomerTypeId")]
        [InverseProperty("CustomerCustomerDemo")]
        public CustomerDemographics CustomerType { get; set; }
    }
}
