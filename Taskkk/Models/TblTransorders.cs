using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblTransorders
    {
        public int OrdRecno { get; set; }
        public int? OrdActtype { get; set; }
        public string OrdActtypeinfo { get; set; }
        public string OrdBegpoint { get; set; }
        public string OrdEndpoint { get; set; }
        public int? OrdEbegpoint { get; set; }
        public int? OrdEendpoint { get; set; }

        //TblClcards
        public int? OrdClcrecno { get; set; }
        public int? OrdFirm { get; set; }
        public string OrdFicheno { get; set; }
        public DateTime? OrdFichedate { get; set; }
        public string OrdFclient { get; set; }
        public string OrdPodcode { get; set; }
        public string OrdPodcodeSys { get; set; }
        public string OrdKarvancode { get; set; }
        public string OrdNts { get; set; }
        public string OrdTelegram { get; set; }
        public int? OrdFpoint { get; set; }
        public string OrdFpointcode { get; set; }
        public string OrdTclient { get; set; }
        public int? OrdTpoint { get; set; }
        public string OrdTpointcode { get; set; }
        public int? OrdLoadstcard1 { get; set; }
        public string OrdLoadstcardcode1 { get; set; }
        public int? OrdLoadstcard2 { get; set; }
        public string OrdLoadstcardcode2 { get; set; }
        public string OrdLoaddesc { get; set; }
        public double? OrdLoadamount { get; set; }
        public string OrdLoadnote { get; set; }
        public int? OrdVgntrntype { get; set; }
        public int? OrdVagonowner { get; set; }
        public int? OrdVagonownerstn { get; set; }
        public int? OrdVagontype { get; set; }
        public double? OrdVagontonnaj { get; set; }
        public double? OrdVgalltonnaj { get; set; }
        public int? OrdVagoncount { get; set; }
        public int? OrdVgallcount { get; set; }
        public int? OrdContaintype { get; set; }
        public string OrdVagonnote { get; set; }
        public string OrdNote { get; set; }
        public int? OrdStatus { get; set; }
        public DateTime? OrdStatusdate { get; set; }
        public string OrdSignnote { get; set; }
        public int? OrdSignsend { get; set; }
        public DateTime? OrdSenddate { get; set; }
        public double? OrdDistance { get; set; }
        public int? OrdExpeditor { get; set; }
        public int? OrdExpclient { get; set; }
        public double? OrdContainamount3 { get; set; }
        public double? OrdContainamount5 { get; set; }
        public double? OrdContainamount10 { get; set; }
        public double? OrdContainamount20 { get; set; }
        public double? OrdContainamount30 { get; set; }
        public double? OrdContainamount40 { get; set; }
        public double? OrdContainamount45 { get; set; }
        public double? OrdEcontainamount3 { get; set; }
        public double? OrdEcontainamount5 { get; set; }
        public double? OrdEcontainamount10 { get; set; }
        public double? OrdEcontainamount20 { get; set; }
        public double? OrdEcontainamount30 { get; set; }
        public double? OrdEcontainamount40 { get; set; }
        public double? OrdEcontainamount45 { get; set; }
        public double? OrdContainamountextra { get; set; }
        public double? OrdEcontainamountextra { get; set; }
        public int? OrdClcPtype { get; set; }
        public bool? OrdIsqt { get; set; }
        public int? OrdExpTemplet { get; set; }
        public int? OrdUId { get; set; }
        public int? OrdUpdUId { get; set; }
        public DateTime? OrdCreatedate { get; set; }
        public int? OrdFirmcode { get; set; }
        public double? OrdCvagontonnaj { get; set; }
        public int? OrdPlatowner { get; set; }
        public int? OrdPlattype { get; set; }
        public int? OrdPlatcount { get; set; }
        public int? OrdCId { get; set; }
        public double? OrdPtotal { get; set; }
        public double? OrdStotal { get; set; }
        public double? OrdProfit { get; set; }
        public int? OrdRead { get; set; }
        public int? OrdKaspar { get; set; }
        public int? OrdOId { get; set; }
        public int? OrdBId { get; set; }
        public int? OrdPricearea { get; set; }
        public int? OrdCtrlId { get; set; }
        public int? OrdCtrlUId { get; set; }
        public DateTime? OrdCtrlDate { get; set; }
        public string OrdCtrlNote { get; set; }
        public string OrdRejectNote { get; set; }
        public int? OrdStartid { get; set; }
        public int? OrdEndid { get; set; }
        public string OrdClname { get; set; }
        public int? OrdPointOrd { get; set; }
        public int? OrdInvtype { get; set; }
        public short? OrdPricetype { get; set; }
        public DateTime? OrdRdate { get; set; }
        public double? OrdPntAmount { get; set; }
        public int? OrdRday { get; set; }
        public int? OrdFreeday { get; set; }
        public double? OrdAlldiss { get; set; }
        public string OrdCode { get; set; }

        //TblSpecodes
        public int? OrdType { get; set; }

        public virtual TblClcards OrdClcrecnoNavigation { get; set; }
        public virtual TblFirms OrdFirmNavigation { get; set; }
        public virtual TblSpecodes OrdTypeNavigation { get; set; }
    }
}
