//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFBHPL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class gameweek
    {
        public gameweek()
        {
            this.league = new HashSet<league>();
            this.match = new HashSet<match>();
            this.selectedsquadchecked = new HashSet<selectedsquadchecked>();
        }
    
        public int idGameWeek { get; set; }
        public string gameweekName { get; set; }
        public int idSeason1 { get; set; }
    
        public virtual season season { get; set; }
        public virtual ICollection<league> league { get; set; }
        public virtual ICollection<match> match { get; set; }
        public virtual ICollection<selectedsquadchecked> selectedsquadchecked { get; set; }
    }
}
