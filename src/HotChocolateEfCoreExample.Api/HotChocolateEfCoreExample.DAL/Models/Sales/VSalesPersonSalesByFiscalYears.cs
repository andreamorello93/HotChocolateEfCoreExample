﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotChocolateEfCoreExample.DAL.Models
{
    /// <summary>
    /// Uses PIVOT to return aggregated sales information for each sales representative.
    /// </summary>
    [Keyless]
    public partial class VSalesPersonSalesByFiscalYears
    {
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }
        [StringLength(152)]
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string JobTitle { get; set; }
        [Required]
        [StringLength(50)]
        public string SalesTerritory { get; set; }
        [Column("2002", TypeName = "money")]
        public decimal? _2002 { get; set; }
        [Column("2003", TypeName = "money")]
        public decimal? _2003 { get; set; }
        [Column("2004", TypeName = "money")]
        public decimal? _2004 { get; set; }
    }
}