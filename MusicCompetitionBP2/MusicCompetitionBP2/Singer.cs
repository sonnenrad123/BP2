//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicCompetitionBP2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Singer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Singer()
        {
            this.ADDRESS_SIN = new ADDRESS();
        }
    
        public long JMBG_SIN { get; set; }
        public string FIRSTNAME_SIN { get; set; }
        public string LASTNAME_SIN { get; set; }
        public System.DateTime BIRTHDATE_SIN { get; set; }
        public string EMAIL_SIN { get; set; }
        public string PHONE_NO_SIN { get; set; }
    
        public ADDRESS ADDRESS_SIN { get; set; }
    }
}