﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TinTuc
    {
        public int MaTin { get; set; }
        public string HinhBia { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        [Display(Name = "Ngày đăng")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày đăng là bắt buộc")]
        public Nullable<System.DateTime> NgayDang { get; set; }
    }
}
