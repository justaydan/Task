using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblFact
    {
        public int FctId { get; set; }
        public DateTime? FctDate { get; set; }
        public int? FctMonth { get; set; }
        public int? FctYear { get; set; }
        public string FctOverhead { get; set; }
        public string FctWagonno { get; set; }
        public decimal? FctWeight { get; set; }
        public string FctNote { get; set; }
        public string FctSubcode { get; set; }
        public int? FctType { get; set; }
        public string FctNote2 { get; set; }
        public string FctFpoint { get; set; }
        public string FctTpoint { get; set; }
        public int? FctStname2 { get; set; }
        public int? FctFirm { get; set; }
        public string FctClientcode { get; set; }
        public int? FctOrdid { get; set; }
        public string FctEndpoint { get; set; }
        public string FctBegpoint { get; set; }
        public string FctContainerno { get; set; }
        public int? FctStatusId { get; set; }
        public string FctFclient { get; set; }
        public string FctTclient { get; set; }
        public int? FctOwner { get; set; }
        public int? FctWtype { get; set; }
        public int? FctCtype { get; set; }
        public int? FctCempty { get; set; }
        public string FctItemdesc { get; set; }
        public DateTime? FctLoaddate { get; set; }
        public int? FctEtsngId { get; set; }
        public int? FctUId { get; set; }
        public int? FctClcRecno { get; set; }
        public int? FctExpTemplet { get; set; }
        public string FctTrainno { get; set; }
        public int? FctTempid { get; set; }
        public int? FctCId { get; set; }
        public string FctAdycode { get; set; }
        public int? FctFId { get; set; }
        public string FctExpcode { get; set; }
        public string FctExpcodeOld { get; set; }
        public int? FctSpecode { get; set; }
        public int? FctQnqId { get; set; }
        public int? FctRtdcode { get; set; }

        public virtual TblPoints FctBegpointNavigation { get; set; }
        public virtual TblCountry FctC { get; set; }
        public virtual TblPoints FctEndpointNavigation { get; set; }
        public virtual TblStatus FctStatus { get; set; }
        public virtual TblSpecodes FctTypeNavigation { get; set; }
    }
}
