//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kiralamalar
    {
        public int Id { get; set; }
        public int Arac_Id { get; set; }
        public int Kullanici_Id { get; set; }
        public System.DateTime Tarih { get; set; }
        public bool IptalMi { get; set; }
        public bool AktifMi { get; set; }
    
        public virtual Araba Araba { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
