using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Taskkk.Models
{
    public partial class OrdersTestContext : DbContext
    {
        public OrdersTestContext()
        {
        }

        public OrdersTestContext(DbContextOptions<OrdersTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblClcards> TblClcards { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblDistance> TblDistance { get; set; }
        public virtual DbSet<TblFact> TblFact { get; set; }
        public virtual DbSet<TblFirms> TblFirms { get; set; }
        public virtual DbSet<TblPoints> TblPoints { get; set; }
        public virtual DbSet<TblRtctype> TblRtctype { get; set; }
        public virtual DbSet<TblSpecodes> TblSpecodes { get; set; }
        public virtual DbSet<TblStatus> TblStatus { get; set; }
        public virtual DbSet<TblStcards> TblStcards { get; set; }
        public virtual DbSet<TblStjcards> TblStjcards { get; set; }
        public virtual DbSet<TblTransorders> TblTransorders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Acer;Database=OrdersTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblClcards>(entity =>
            {
                entity.HasKey(e => e.ClcRecno);

                entity.ToTable("TBL_CLCARDS");

                entity.Property(e => e.ClcRecno).HasColumnName("CLC_RECNO");

                entity.Property(e => e.ClcAllname)
                    .HasColumnName("CLC_ALLNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ClcAllnameEng)
                    .HasColumnName("CLC_ALLNAME_ENG")
                    .HasMaxLength(100);

                entity.Property(e => e.ClcBId).HasColumnName("CLC_B_ID");

                entity.Property(e => e.ClcBlock).HasColumnName("CLC_BLOCK");

                entity.Property(e => e.ClcCode1cMmc)
                    .HasColumnName("CLC_CODE1C_MMC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClcCrtdate)
                    .HasColumnName("CLC_CRTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClcCtype).HasColumnName("CLC_CTYPE");

                entity.Property(e => e.ClcEmail)
                    .HasColumnName("CLC_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClcExpcode)
                    .IsRequired()
                    .HasColumnName("CLC_EXPCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ClcExpcodeold)
                    .HasColumnName("CLC_EXPCODEOLD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ClcExpref).HasColumnName("CLC_EXPREF");

                entity.Property(e => e.ClcFirm).HasColumnName("CLC_FIRM");

                entity.Property(e => e.ClcInvlang).HasColumnName("CLC_INVLANG");

                entity.Property(e => e.ClcLimit).HasColumnName("CLC_LIMIT");

                entity.Property(e => e.ClcMobil)
                    .HasColumnName("CLC_MOBIL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClcNote)
                    .HasColumnName("CLC_NOTE")
                    .HasMaxLength(300);

                entity.Property(e => e.ClcNote1)
                    .HasColumnName("CLC_NOTE1")
                    .HasMaxLength(300);

                entity.Property(e => e.ClcOId).HasColumnName("CLC_O_ID");

                entity.Property(e => e.ClcOnlybrach).HasColumnName("CLC_ONLYBRACH");

                entity.Property(e => e.ClcPPrccoridor).HasColumnName("CLC_P_PRCCORIDOR");

                entity.Property(e => e.ClcPPrcexport).HasColumnName("CLC_P_PRCEXPORT");

                entity.Property(e => e.ClcPPrcimport).HasColumnName("CLC_P_PRCIMPORT");

                entity.Property(e => e.ClcPPrcinternal).HasColumnName("CLC_P_PRCINTERNAL");

                entity.Property(e => e.ClcPPrcliman).HasColumnName("CLC_P_PRCLIMAN");

                entity.Property(e => e.ClcPPrctranzit).HasColumnName("CLC_P_PRCTRANZIT");

                entity.Property(e => e.ClcPPrcustom).HasColumnName("CLC_P_PRCUSTOM");

                entity.Property(e => e.ClcPerson)
                    .HasColumnName("CLC_PERSON")
                    .HasMaxLength(50);

                entity.Property(e => e.ClcPhone)
                    .HasColumnName("CLC_PHONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClcPincode)
                    .HasColumnName("CLC_PINCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClcPrccoridor).HasColumnName("CLC_PRCCORIDOR");

                entity.Property(e => e.ClcPrccoridorE).HasColumnName("CLC_PRCCORIDOR_E");

                entity.Property(e => e.ClcPrcexport).HasColumnName("CLC_PRCEXPORT");

                entity.Property(e => e.ClcPrcexportE).HasColumnName("CLC_PRCEXPORT_E");

                entity.Property(e => e.ClcPrcimport).HasColumnName("CLC_PRCIMPORT");

                entity.Property(e => e.ClcPrcimportE).HasColumnName("CLC_PRCIMPORT_E");

                entity.Property(e => e.ClcPrcinternal).HasColumnName("CLC_PRCINTERNAL");

                entity.Property(e => e.ClcPrcinternalE).HasColumnName("CLC_PRCINTERNAL_E");

                entity.Property(e => e.ClcPrcliman).HasColumnName("CLC_PRCLIMAN");

                entity.Property(e => e.ClcPrctranzit).HasColumnName("CLC_PRCTRANZIT");

                entity.Property(e => e.ClcPrctranzitE).HasColumnName("CLC_PRCTRANZIT_E");

                entity.Property(e => e.ClcPrcustom).HasColumnName("CLC_PRCUSTOM");

                entity.Property(e => e.ClcPricetype).HasColumnName("CLC_PRICETYPE");

                entity.Property(e => e.ClcPtype).HasColumnName("CLC_PTYPE");

                entity.Property(e => e.ClcRegdate)
                    .HasColumnName("CLC_REGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClcSextype).HasColumnName("CLC_SEXTYPE");

                entity.Property(e => e.ClcStatus).HasColumnName("CLC_STATUS");

                entity.Property(e => e.ClcType).HasColumnName("CLC_TYPE");

                entity.Property(e => e.ClcUId).HasColumnName("CLC_U_ID");

                entity.Property(e => e.ClcUserid).HasColumnName("CLC_USERID");

                entity.Property(e => e.ClcVoen)
                    .HasColumnName("CLC_VOEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("TBL_COUNTRY");

                entity.Property(e => e.CId)
                    .HasColumnName("C_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CCode)
                    .IsRequired()
                    .HasColumnName("C_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CName1)
                    .IsRequired()
                    .HasColumnName("C_NAME1")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDistance>(entity =>
            {
                entity.HasKey(e => e.DsId);

                entity.ToTable("TBL_DISTANCE");

                entity.Property(e => e.DsId).HasColumnName("DS_ID");

                entity.Property(e => e.DsCode)
                    .IsRequired()
                    .HasColumnName("DS_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsPntId).HasColumnName("DS_PNT_ID");

                entity.Property(e => e._547508).HasColumnName("547508");

                entity.Property(e => e._547603).HasColumnName("547603");

                entity.Property(e => e._547709).HasColumnName("547709");

                entity.Property(e => e._548803).HasColumnName("548803");

                entity.Property(e => e._549204).HasColumnName("549204");

                entity.Property(e => e._550108).HasColumnName("550108");

                entity.Property(e => e._553002).HasColumnName("553002");

                entity.Property(e => e._554503).HasColumnName("554503");

                entity.Property(e => e._558701).HasColumnName("558701");
            });

            modelBuilder.Entity<TblFact>(entity =>
            {
                entity.HasKey(e => e.FctId);

                entity.ToTable("TBL_FACT");

                entity.Property(e => e.FctId).HasColumnName("FCT_ID");

                entity.Property(e => e.FctAdycode)
                    .HasColumnName("FCT_ADYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FctBegpoint)
                    .HasColumnName("FCT_BEGPOINT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FctCId).HasColumnName("FCT_C_ID");

                entity.Property(e => e.FctCempty).HasColumnName("FCT_CEMPTY");

                entity.Property(e => e.FctClcRecno).HasColumnName("FCT_CLC_RECNO");

                entity.Property(e => e.FctClientcode)
                    .HasColumnName("FCT_CLIENTCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.FctContainerno)
                    .HasColumnName("FCT_CONTAINERNO")
                    .HasMaxLength(20);

                entity.Property(e => e.FctCtype).HasColumnName("FCT_CTYPE");

                entity.Property(e => e.FctDate)
                    .HasColumnName("FCT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FctEndpoint)
                    .HasColumnName("FCT_ENDPOINT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FctEtsngId).HasColumnName("FCT_ETSNG_ID");

                entity.Property(e => e.FctExpTemplet).HasColumnName("FCT_EXP_TEMPLET");

                entity.Property(e => e.FctExpcode)
                    .HasColumnName("FCT_EXPCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FctExpcodeOld)
                    .HasColumnName("FCT_EXPCODE_OLD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FctFId).HasColumnName("FCT_F_ID");

                entity.Property(e => e.FctFclient)
                    .HasColumnName("FCT_FCLIENT")
                    .HasMaxLength(500);

                entity.Property(e => e.FctFirm).HasColumnName("FCT_FIRM");

                entity.Property(e => e.FctFpoint)
                    .HasColumnName("FCT_FPOINT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FctItemdesc)
                    .HasColumnName("FCT_ITEMDESC")
                    .HasMaxLength(50);

                entity.Property(e => e.FctLoaddate)
                    .HasColumnName("FCT_LOADDATE")
                    .HasColumnType("date");

                entity.Property(e => e.FctMonth).HasColumnName("FCT_MONTH");

                entity.Property(e => e.FctNote)
                    .HasColumnName("FCT_NOTE")
                    .HasMaxLength(200);

                entity.Property(e => e.FctNote2)
                    .HasColumnName("FCT_NOTE2")
                    .HasMaxLength(50);

                entity.Property(e => e.FctOrdid).HasColumnName("FCT_ORDID");

                entity.Property(e => e.FctOverhead)
                    .HasColumnName("FCT_OVERHEAD")
                    .HasMaxLength(20);

                entity.Property(e => e.FctOwner).HasColumnName("FCT_OWNER");

                entity.Property(e => e.FctQnqId).HasColumnName("FCT_QNQ_ID");

                entity.Property(e => e.FctRtdcode).HasColumnName("FCT_RTDCODE");

                entity.Property(e => e.FctSpecode).HasColumnName("FCT_SPECODE");

                entity.Property(e => e.FctStatusId).HasColumnName("FCT_STATUS_ID");

                entity.Property(e => e.FctStname2).HasColumnName("FCT_STNAME2");

                entity.Property(e => e.FctSubcode)
                    .HasColumnName("FCT_SUBCODE")
                    .HasMaxLength(20);

                entity.Property(e => e.FctTclient)
                    .HasColumnName("FCT_TCLIENT")
                    .HasMaxLength(500);

                entity.Property(e => e.FctTempid).HasColumnName("FCT_TEMPID");

                entity.Property(e => e.FctTpoint)
                    .HasColumnName("FCT_TPOINT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FctTrainno)
                    .HasColumnName("FCT_TRAINNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FctType).HasColumnName("FCT_TYPE");

                entity.Property(e => e.FctUId).HasColumnName("FCT_U_ID");

                entity.Property(e => e.FctWagonno)
                    .HasColumnName("FCT_WAGONNO")
                    .HasMaxLength(15);

                entity.Property(e => e.FctWeight)
                    .HasColumnName("FCT_WEIGHT")
                    .HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FctWtype).HasColumnName("FCT_WTYPE");

                entity.Property(e => e.FctYear).HasColumnName("FCT_YEAR");

                entity.HasOne(d => d.FctBegpointNavigation)
                    .WithMany(p => p.TblFactFctBegpointNavigation)
                    .HasForeignKey(d => d.FctBegpoint)
                    .HasConstraintName("FK_TBL_FACT_TBL_POINTS_BEG");

                entity.HasOne(d => d.FctC)
                    .WithMany(p => p.TblFact)
                    .HasForeignKey(d => d.FctCId)
                    .HasConstraintName("FK_TBL_FACT_TBL_COUNTRY");

                entity.HasOne(d => d.FctEndpointNavigation)
                    .WithMany(p => p.TblFactFctEndpointNavigation)
                    .HasForeignKey(d => d.FctEndpoint)
                    .HasConstraintName("FK_TBL_FACT_TBL_POINTS_END");

                entity.HasOne(d => d.FctStatus)
                    .WithMany(p => p.TblFact)
                    .HasForeignKey(d => d.FctStatusId)
                    .HasConstraintName("FK_TBL_FACT_TBL_STATUS");

                entity.HasOne(d => d.FctTypeNavigation)
                    .WithMany(p => p.TblFact)
                    .HasForeignKey(d => d.FctType)
                    .HasConstraintName("FK_TBL_FACT_TBL_SPECODES");
            });

            modelBuilder.Entity<TblFirms>(entity =>
            {
                entity.HasKey(e => e.FrmRecno);

                entity.ToTable("TBL_FIRMS");

                entity.Property(e => e.FrmRecno).HasColumnName("FRM_RECNO");

                entity.Property(e => e.FrmAdress)
                    .HasColumnName("FRM_ADRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.FrmCode)
                    .HasColumnName("FRM_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrmName)
                    .HasColumnName("FRM_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.FrmNote)
                    .HasColumnName("FRM_NOTE")
                    .HasMaxLength(500);

                entity.Property(e => e.FrmOrder).HasColumnName("FRM_ORDER");

                entity.Property(e => e.FrmStatus).HasColumnName("FRM_STATUS");

                entity.Property(e => e.FrmTelefon)
                    .HasColumnName("FRM_TELEFON")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FrmType).HasColumnName("FRM_TYPE");

                entity.Property(e => e.FrmVoen)
                    .HasColumnName("FRM_VOEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPoints>(entity =>
            {
                entity.HasKey(e => e.PntCode);

                entity.ToTable("TBL_POINTS");

                entity.Property(e => e.PntCode)
                    .HasColumnName("PNT_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PntAtype)
                    .HasColumnName("PNT_ATYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PntCountcode).HasColumnName("PNT_COUNTCODE");

                entity.Property(e => e.PntGroup)
                    .HasColumnName("PNT_GROUP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PntName)
                    .IsRequired()
                    .HasColumnName("PNT_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.PntName1)
                    .IsRequired()
                    .HasColumnName("PNT_NAME1")
                    .HasMaxLength(200);

                entity.Property(e => e.PntName2)
                    .IsRequired()
                    .HasColumnName("PNT_NAME2")
                    .HasMaxLength(200);

                entity.Property(e => e.PntName3)
                    .HasColumnName("PNT_NAME3")
                    .HasMaxLength(200);

                entity.Property(e => e.PntRecno).HasColumnName("PNT_RECNO");

                entity.Property(e => e.PntStatus)
                    .IsRequired()
                    .HasColumnName("PNT_STATUS")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PntType)
                    .HasColumnName("PNT_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.PntCountcodeNavigation)
                    .WithMany(p => p.TblPoints)
                    .HasForeignKey(d => d.PntCountcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_POINTS_TBL_COUNTRY");
            });

            modelBuilder.Entity<TblRtctype>(entity =>
            {
                entity.HasKey(e => e.RtId);

                entity.ToTable("TBL_RTCTYPE");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.Property(e => e.RtAddempr).HasColumnName("RT_ADDEMPR");

                entity.Property(e => e.RtAddqty).HasColumnName("RT_ADDQTY");

                entity.Property(e => e.RtArrcount).HasColumnName("RT_ARRCOUNT");

                entity.Property(e => e.RtAxescount).HasColumnName("RT_AXESCOUNT");

                entity.Property(e => e.RtCalctype)
                    .HasColumnName("RT_CALCTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.RtDlina).HasColumnName("RT_DLINA");

                entity.Property(e => e.RtEprice)
                    .HasColumnName("RT_EPRICE")
                    .HasMaxLength(50);

                entity.Property(e => e.RtGr)
                    .HasColumnName("RT_GR")
                    .HasMaxLength(20);

                entity.Property(e => e.RtGrId).HasColumnName("RT_GR_ID");

                entity.Property(e => e.RtLength).HasColumnName("RT_LENGTH");

                entity.Property(e => e.RtName)
                    .HasColumnName("RT_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.RtName1)
                    .HasColumnName("RT_NAME1")
                    .HasMaxLength(60);

                entity.Property(e => e.RtName2)
                    .HasColumnName("RT_NAME2")
                    .HasMaxLength(60);

                entity.Property(e => e.RtName3)
                    .HasColumnName("RT_NAME3")
                    .HasMaxLength(60);

                entity.Property(e => e.RtNtsId).HasColumnName("RT_NTS_ID");

                entity.Property(e => e.RtOrderby).HasColumnName("RT_ORDERBY");

                entity.Property(e => e.RtPref)
                    .HasColumnName("RT_PREF")
                    .HasMaxLength(50);

                entity.Property(e => e.RtPricefIe)
                    .HasColumnName("RT_PRICEF_IE")
                    .HasMaxLength(50);

                entity.Property(e => e.RtPricefIePr)
                    .HasColumnName("RT_PRICEF_IE_PR")
                    .HasMaxLength(50);

                entity.Property(e => e.RtPricefT)
                    .HasColumnName("RT_PRICEF_T")
                    .HasMaxLength(50);

                entity.Property(e => e.RtPricefTPr)
                    .HasColumnName("RT_PRICEF_T_PR")
                    .HasMaxLength(50);

                entity.Property(e => e.RtRealton).HasColumnName("RT_REALTON");

                entity.Property(e => e.RtStatus).HasColumnName("RT_STATUS");

                entity.Property(e => e.RtType).HasColumnName("RT_TYPE");

                entity.Property(e => e.RtWagontype).HasColumnName("RT_WAGONTYPE");
            });

            modelBuilder.Entity<TblSpecodes>(entity =>
            {
                entity.HasKey(e => e.ScId);

                entity.ToTable("TBL_SPECODES");

                entity.Property(e => e.ScId).HasColumnName("SC_ID");

                entity.Property(e => e.ScCode)
                    .HasColumnName("SC_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.ScDefault).HasColumnName("SC_DEFAULT");

                entity.Property(e => e.ScNtsid).HasColumnName("SC_NTSID");

                entity.Property(e => e.ScOrder).HasColumnName("SC_ORDER");

                entity.Property(e => e.ScParent).HasColumnName("SC_PARENT");

                entity.Property(e => e.ScRefid).HasColumnName("SC_REFID");

                entity.Property(e => e.ScStatus).HasColumnName("SC_STATUS");

                entity.Property(e => e.ScType)
                    .HasColumnName("SC_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ScValue1)
                    .HasColumnName("SC_VALUE1")
                    .HasMaxLength(50);

                entity.Property(e => e.ScValue2)
                    .HasColumnName("SC_VALUE2")
                    .HasMaxLength(50);

                entity.Property(e => e.ScValue3)
                    .HasColumnName("SC_VALUE3")
                    .HasMaxLength(50);

                entity.Property(e => e.ScValue4)
                    .HasColumnName("SC_VALUE4")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblStatus>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("TBL_STATUS");

                entity.Property(e => e.StId).HasColumnName("ST_ID");

                entity.Property(e => e.StDefinition)
                    .IsRequired()
                    .HasColumnName("ST_DEFINITION")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblStcards>(entity =>
            {
                entity.HasKey(e => e.StcId)
                    .HasName("PK_TBL_STCARDSdfgd");

                entity.ToTable("TBL_STCARDS");

                entity.Property(e => e.StcId)
                    .HasColumnName("STC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StcCode)
                    .HasColumnName("STC_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StcGrname)
                    .HasColumnName("STC_GRNAME")
                    .HasMaxLength(250);

                entity.Property(e => e.StcGrtype).HasColumnName("STC_GRTYPE");

                entity.Property(e => e.StcName)
                    .HasColumnName("STC_NAME")
                    .HasMaxLength(700);

                entity.Property(e => e.StcName1)
                    .HasColumnName("STC_NAME1")
                    .HasMaxLength(2000);

                entity.Property(e => e.StcName2)
                    .HasColumnName("STC_NAME2")
                    .HasMaxLength(2000);

                entity.Property(e => e.StcName3)
                    .HasColumnName("STC_NAME3")
                    .HasMaxLength(2000);

                entity.Property(e => e.StcName4)
                    .HasColumnName("STC_NAME4")
                    .HasMaxLength(2000);

                entity.Property(e => e.StcNote)
                    .HasColumnName("STC_NOTE")
                    .HasMaxLength(50);

                entity.Property(e => e.StcOther).HasColumnName("STC_OTHER");

                entity.Property(e => e.StcStatus).HasColumnName("STC_STATUS");

                entity.Property(e => e.StcStgrecno).HasColumnName("STC_STGRECNO");

                entity.Property(e => e.StcSttype).HasColumnName("STC_STTYPE");
            });

            modelBuilder.Entity<TblStjcards>(entity =>
            {
                entity.HasKey(e => e.StcjId)
                    .HasName("PK_TBL_STJCARDSkkk");

                entity.ToTable("TBL_STJCARDS");

                entity.Property(e => e.StcjId)
                    .HasColumnName("STCJ_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StcjEtsCode)
                    .HasColumnName("STCJ_ETS_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.StcjEtsId).HasColumnName("STCJ_ETS_ID");

                entity.Property(e => e.StcjGngCode)
                    .HasColumnName("STCJ_GNG_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.StcjGngId).HasColumnName("STCJ_GNG_ID");

                entity.Property(e => e.StcjStatus)
                    .HasColumnName("STCJ_STATUS")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblTransorders>(entity =>
            {
                entity.HasKey(e => e.OrdRecno);

                entity.ToTable("TBL_TRANSORDERS");

                entity.Property(e => e.OrdRecno).HasColumnName("ORD_RECNO");

                entity.Property(e => e.OrdActtype).HasColumnName("ORD_ACTTYPE");

                entity.Property(e => e.OrdActtypeinfo)
                    .HasColumnName("ORD_ACTTYPEINFO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrdAlldiss).HasColumnName("ORD_ALLDISS");

                entity.Property(e => e.OrdBId).HasColumnName("ORD_B_ID");

                entity.Property(e => e.OrdBegpoint)
                    .HasColumnName("ORD_BEGPOINT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrdCId).HasColumnName("ORD_C_ID");

                entity.Property(e => e.OrdClcPtype).HasColumnName("ORD_CLC_PTYPE");

                entity.Property(e => e.OrdClcrecno).HasColumnName("ORD_CLCRECNO");

                entity.Property(e => e.OrdClname)
                    .HasColumnName("ORD_CLNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.OrdCode)
                    .HasColumnName("ORD_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdContainamount10).HasColumnName("ORD_CONTAINAMOUNT10");

                entity.Property(e => e.OrdContainamount20).HasColumnName("ORD_CONTAINAMOUNT20");

                entity.Property(e => e.OrdContainamount3).HasColumnName("ORD_CONTAINAMOUNT3");

                entity.Property(e => e.OrdContainamount30).HasColumnName("ORD_CONTAINAMOUNT30");

                entity.Property(e => e.OrdContainamount40).HasColumnName("ORD_CONTAINAMOUNT40");

                entity.Property(e => e.OrdContainamount45).HasColumnName("ORD_CONTAINAMOUNT45");

                entity.Property(e => e.OrdContainamount5).HasColumnName("ORD_CONTAINAMOUNT5");

                entity.Property(e => e.OrdContainamountextra).HasColumnName("ORD_CONTAINAMOUNTEXTRA");

                entity.Property(e => e.OrdContaintype).HasColumnName("ORD_CONTAINTYPE");

                entity.Property(e => e.OrdCreatedate)
                    .HasColumnName("ORD_CREATEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdCtrlDate)
                    .HasColumnName("ORD_CTRL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdCtrlId).HasColumnName("ORD_CTRL_ID");

                entity.Property(e => e.OrdCtrlNote)
                    .HasColumnName("ORD_CTRL_NOTE")
                    .HasMaxLength(200);

                entity.Property(e => e.OrdCtrlUId).HasColumnName("ORD_CTRL_U_ID");

                entity.Property(e => e.OrdCvagontonnaj).HasColumnName("ORD_CVAGONTONNAJ");

                entity.Property(e => e.OrdDistance).HasColumnName("ORD_DISTANCE");

                entity.Property(e => e.OrdEbegpoint).HasColumnName("ORD_EBEGPOINT");

                entity.Property(e => e.OrdEcontainamount10).HasColumnName("ORD_ECONTAINAMOUNT10");

                entity.Property(e => e.OrdEcontainamount20).HasColumnName("ORD_ECONTAINAMOUNT20");

                entity.Property(e => e.OrdEcontainamount3).HasColumnName("ORD_ECONTAINAMOUNT3");

                entity.Property(e => e.OrdEcontainamount30).HasColumnName("ORD_ECONTAINAMOUNT30");

                entity.Property(e => e.OrdEcontainamount40).HasColumnName("ORD_ECONTAINAMOUNT40");

                entity.Property(e => e.OrdEcontainamount45).HasColumnName("ORD_ECONTAINAMOUNT45");

                entity.Property(e => e.OrdEcontainamount5).HasColumnName("ORD_ECONTAINAMOUNT5");

                entity.Property(e => e.OrdEcontainamountextra).HasColumnName("ORD_ECONTAINAMOUNTEXTRA");

                entity.Property(e => e.OrdEendpoint).HasColumnName("ORD_EENDPOINT");

                entity.Property(e => e.OrdEndid).HasColumnName("ORD_ENDID");

                entity.Property(e => e.OrdEndpoint)
                    .HasColumnName("ORD_ENDPOINT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrdExpTemplet).HasColumnName("ORD_EXP_TEMPLET");

                entity.Property(e => e.OrdExpclient).HasColumnName("ORD_EXPCLIENT");

                entity.Property(e => e.OrdExpeditor).HasColumnName("ORD_EXPEDITOR");

                entity.Property(e => e.OrdFclient)
                    .HasColumnName("ORD_FCLIENT")
                    .HasMaxLength(250);

                entity.Property(e => e.OrdFichedate)
                    .HasColumnName("ORD_FICHEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdFicheno)
                    .HasColumnName("ORD_FICHENO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrdFirm).HasColumnName("ORD_FIRM");

                entity.Property(e => e.OrdFirmcode).HasColumnName("ORD_FIRMCODE");

                entity.Property(e => e.OrdFpoint).HasColumnName("ORD_FPOINT");

                entity.Property(e => e.OrdFpointcode)
                    .HasColumnName("ORD_FPOINTCODE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.OrdFreeday).HasColumnName("ORD_FREEDAY");

                entity.Property(e => e.OrdInvtype).HasColumnName("ORD_INVTYPE");

                entity.Property(e => e.OrdIsqt).HasColumnName("ORD_ISQT");

                entity.Property(e => e.OrdKarvancode)
                    .HasColumnName("ORD_KARVANCODE")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrdKaspar).HasColumnName("ORD_KASPAR");

                entity.Property(e => e.OrdLoadamount).HasColumnName("ORD_LOADAMOUNT");

                entity.Property(e => e.OrdLoaddesc)
                    .HasColumnName("ORD_LOADDESC")
                    .HasMaxLength(100);

                entity.Property(e => e.OrdLoadnote).HasColumnName("ORD_LOADNOTE");

                entity.Property(e => e.OrdLoadstcard1).HasColumnName("ORD_LOADSTCARD1");

                entity.Property(e => e.OrdLoadstcard2).HasColumnName("ORD_LOADSTCARD2");

                entity.Property(e => e.OrdLoadstcardcode1)
                    .HasColumnName("ORD_LOADSTCARDCODE1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdLoadstcardcode2)
                    .HasColumnName("ORD_LOADSTCARDCODE2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdNote)
                    .HasColumnName("ORD_NOTE")
                    .HasMaxLength(500);

                entity.Property(e => e.OrdNts)
                    .HasColumnName("ORD_NTS")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrdOId).HasColumnName("ORD_O_ID");

                entity.Property(e => e.OrdPlatcount).HasColumnName("ORD_PLATCOUNT");

                entity.Property(e => e.OrdPlatowner).HasColumnName("ORD_PLATOWNER");

                entity.Property(e => e.OrdPlattype).HasColumnName("ORD_PLATTYPE");

                entity.Property(e => e.OrdPntAmount).HasColumnName("ORD_PNT_AMOUNT");

                entity.Property(e => e.OrdPodcode)
                    .HasColumnName("ORD_PODCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrdPodcodeSys)
                    .HasColumnName("ORD_PODCODE_SYS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrdPointOrd).HasColumnName("ORD_POINT_ORD");

                entity.Property(e => e.OrdPricearea).HasColumnName("ORD_PRICEAREA");

                entity.Property(e => e.OrdPricetype).HasColumnName("ORD_PRICETYPE");

                entity.Property(e => e.OrdProfit).HasColumnName("ORD_PROFIT");

                entity.Property(e => e.OrdPtotal).HasColumnName("ORD_PTOTAL");

                entity.Property(e => e.OrdRdate)
                    .HasColumnName("ORD_RDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdRday).HasColumnName("ORD_RDAY");

                entity.Property(e => e.OrdRead).HasColumnName("ORD_READ");

                entity.Property(e => e.OrdRejectNote)
                    .HasColumnName("ORD_REJECT_NOTE")
                    .HasMaxLength(200);

                entity.Property(e => e.OrdSenddate)
                    .HasColumnName("ORD_SENDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdSignnote)
                    .HasColumnName("ORD_SIGNNOTE")
                    .HasMaxLength(50);

                entity.Property(e => e.OrdSignsend).HasColumnName("ORD_SIGNSEND");

                entity.Property(e => e.OrdStartid).HasColumnName("ORD_STARTID");

                entity.Property(e => e.OrdStatus).HasColumnName("ORD_STATUS");

                entity.Property(e => e.OrdStatusdate)
                    .HasColumnName("ORD_STATUSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdStotal).HasColumnName("ORD_STOTAL");

                entity.Property(e => e.OrdTclient)
                    .HasColumnName("ORD_TCLIENT")
                    .HasMaxLength(250);

                entity.Property(e => e.OrdTelegram)
                    .HasColumnName("ORD_TELEGRAM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrdTpoint).HasColumnName("ORD_TPOINT");

                entity.Property(e => e.OrdTpointcode)
                    .HasColumnName("ORD_TPOINTCODE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.OrdType).HasColumnName("ORD_TYPE");

                entity.Property(e => e.OrdUId).HasColumnName("ORD_U_ID");

                entity.Property(e => e.OrdUpdUId).HasColumnName("ORD_UPD_U_ID");

                entity.Property(e => e.OrdVagoncount).HasColumnName("ORD_VAGONCOUNT");

                entity.Property(e => e.OrdVagonnote).HasColumnName("ORD_VAGONNOTE");

                entity.Property(e => e.OrdVagonowner).HasColumnName("ORD_VAGONOWNER");

                entity.Property(e => e.OrdVagonownerstn).HasColumnName("ORD_VAGONOWNERSTN");

                entity.Property(e => e.OrdVagontonnaj).HasColumnName("ORD_VAGONTONNAJ");

                entity.Property(e => e.OrdVagontype).HasColumnName("ORD_VAGONTYPE");

                entity.Property(e => e.OrdVgallcount).HasColumnName("ORD_VGALLCOUNT");

                entity.Property(e => e.OrdVgalltonnaj).HasColumnName("ORD_VGALLTONNAJ");

                entity.Property(e => e.OrdVgntrntype).HasColumnName("ORD_VGNTRNTYPE");

                entity.HasOne(d => d.OrdClcrecnoNavigation)
                    .WithMany(p => p.TblTransorders)
                    .HasForeignKey(d => d.OrdClcrecno)
                    .HasConstraintName("FK_TBL_TRANSORDERS_TBL_CLCARDS");


                entity.HasOne(d => d.OrdFirmNavigation)
                    .WithMany(p => p.TblTransorders)
                    .HasForeignKey(d => d.OrdFirm)
                    .HasConstraintName("FK_TBL_TRANSORDERS_TBL_FIRMS");


                entity.HasOne(d => d.OrdTypeNavigation)
                    .WithMany(p => p.TblTransorders)
                    .HasForeignKey(d => d.OrdType)
                    .HasConstraintName("FK_TBL_TRANSORDERS_TBL_SPECODES");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
