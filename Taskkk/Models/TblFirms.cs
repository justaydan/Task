using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblFirms
    {
        public TblFirms()
        {
            TblTransorders = new HashSet<TblTransorders>();
        }

        public int FrmRecno { get; set; }
        public int? FrmType { get; set; }
        public string FrmCode { get; set; }
        public string FrmName { get; set; }
        public int? FrmOrder { get; set; }
        public int? FrmStatus { get; set; }
        public string FrmNote { get; set; }
        public string FrmAdress { get; set; }
        public string FrmTelefon { get; set; }
        public string FrmVoen { get; set; }

        public virtual ICollection<TblTransorders> TblTransorders { get; set; }
    }
}
