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
    
    public partial class footballteam
    {
        public footballteam()
        {
            this.footballplayer = new HashSet<footballplayer>();
            this.match = new HashSet<match>();
            this.match1 = new HashSet<match>();
        }
    
        public int idFootballTeam { get; set; }
        public string teamName { get; set; }
        public byte[] teamAmblem { get; set; }
        public byte[] teamShirt { get; set; }
    
        public virtual ICollection<footballplayer> footballplayer { get; set; }
        public virtual ICollection<match> match { get; set; }
        public virtual ICollection<match> match1 { get; set; }
    }
}
