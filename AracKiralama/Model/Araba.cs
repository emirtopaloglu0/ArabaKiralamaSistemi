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
    
    public partial class Araba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Araba()
        {
            this.Kiralamalar = new HashSet<Kiralamalar>();
        }
    
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Kategori { get; set; }
        public string Yakit_Turu { get; set; }
        public string Vites_Turu { get; set; }
        public string Plaka { get; set; }
        public int Kilometre { get; set; }
        public bool BostaMi { get; set; }
        public bool SilindiMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kiralamalar> Kiralamalar { get; set; }
    }
}
