using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblFact = new HashSet<TblFact>();
            TblPoints = new HashSet<TblPoints>();
        }

        public int CId { get; set; }
        public string CName1 { get; set; }
        public string CCode { get; set; }

        public virtual ICollection<TblFact> TblFact { get; set; }
        public virtual ICollection<TblPoints> TblPoints { get; set; }
    }
}
