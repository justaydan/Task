using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblClcards
    {
        public TblClcards()
        {
            TblTransorders = new HashSet<TblTransorders>();
        }

        public int ClcRecno { get; set; }
        public int? ClcType { get; set; }
        public int? ClcExpref { get; set; }
        public string ClcExpcode { get; set; }
        public string ClcExpcodeold { get; set; }
        public int? ClcUserid { get; set; }
        public int? ClcCtype { get; set; }
        public string ClcAllname { get; set; }
        public string ClcAllnameEng { get; set; }
        public string ClcPerson { get; set; }
        public int? ClcSextype { get; set; }
        public string ClcPincode { get; set; }
        public string ClcVoen { get; set; }
        public string ClcEmail { get; set; }
        public string ClcPhone { get; set; }
        public string ClcMobil { get; set; }
        public int? ClcStatus { get; set; }
        public string ClcNote { get; set; }
        public DateTime? ClcRegdate { get; set; }
        public int? ClcFirm { get; set; }
        public double? ClcPrcimport { get; set; }
        public double? ClcPrcexport { get; set; }
        public double? ClcPrctranzit { get; set; }
        public double? ClcPrccoridor { get; set; }
        public double? ClcPrcinternal { get; set; }
        public double? ClcPrcimportE { get; set; }
        public double? ClcPrcexportE { get; set; }
        public double? ClcPrctranzitE { get; set; }
        public double? ClcPrccoridorE { get; set; }
        public double? ClcPrcinternalE { get; set; }
        public double? ClcPrcustom { get; set; }
        public double? ClcPrcliman { get; set; }
        public int? ClcPtype { get; set; }
        public double? ClcPPrcimport { get; set; }
        public double? ClcPPrcexport { get; set; }
        public double? ClcPPrctranzit { get; set; }
        public double? ClcPPrccoridor { get; set; }
        public double? ClcPPrcinternal { get; set; }
        public double? ClcPPrcustom { get; set; }
        public double? ClcPPrcliman { get; set; }
        public double? ClcLimit { get; set; }
        public double? ClcBlock { get; set; }
        public string ClcCode1cMmc { get; set; }
        public int? ClcInvlang { get; set; }
        public string ClcNote1 { get; set; }
        public int? ClcBId { get; set; }
        public int? ClcUId { get; set; }
        public DateTime? ClcCrtdate { get; set; }
        public int? ClcOnlybrach { get; set; }
        public int? ClcOId { get; set; }
        public short? ClcPricetype { get; set; }

        public virtual ICollection<TblTransorders> TblTransorders { get; set; }
    }
}
