using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SP.DAL.Models
{
    public class GeoNameTxt
    {
        [Key]
        public int GeoNameTxtID { get; set; }
        [Required]
        [Column(TypeName = "varchar(2)")]
        public string countrycode { get; set; }  //2
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string postalcode { get; set; }  // 20
        [Required]
        [Column(TypeName = "varchar(180)")]
        public string placename { get; set; }  //180
        [Column(TypeName = "varchar(100)")]
        public string statename { get; set; }  // 100
        [Column(TypeName = "varchar(20)")]
        public string statecode { get; set; }  // 20
        [Column(TypeName = "varchar(100)")]
        public string countyorprovincename { get; set; }   //100
        [Column(TypeName = "varchar(20)")]
        public string countyorprovincecode { get; set; }  //20
        [Column(TypeName = "varchar(100)")]
        public string communityname { get; set; }  //100
        [Column(TypeName = "varchar(20)")]
        public string communitycode { get; set; } //20
        [Required]
        [Column(TypeName = "decimal(9,6)")]
        public decimal latitude { get; set; }   // decimal (9,6)
        [Required]
        [Column(TypeName = "decimal(9,6)")]
        public decimal longitude { get; set; }  //decimal (9,6)
        [Required]
        public int accuracy { get; set; }   // 1
    }

    public class AD_Andorra : GeoNameTxt { }
    public class AR_Argentina : GeoNameTxt { }
    public class AS_AmericanSamoa : GeoNameTxt { }
    public class AT_Austria : GeoNameTxt { }
    public class AU_Australia : GeoNameTxt { }
    public class AX_AlandIslands : GeoNameTxt { }
    public class BD_Bangladesh : GeoNameTxt { }
    public class BE_Belgium : GeoNameTxt { }
    public class BG_Bulgaria : GeoNameTxt { }
    public class BR_Brazil : GeoNameTxt { }
    public class BY_Belarus : GeoNameTxt { }
    public class CA_Canada : GeoNameTxt { }
    public class CH_Switzerland : GeoNameTxt { }
    public class CO_Colombia : GeoNameTxt { }
    public class CR_CostaRica : GeoNameTxt { }
    public class CZ_Czechia : GeoNameTxt { }
    public class DE_Germany : GeoNameTxt { }
    public class DK_Denmark : GeoNameTxt { }
    public class DO_DominicanRepublic : GeoNameTxt { }
    public class DZ_Algeria : GeoNameTxt { }
    public class ES_Spain : GeoNameTxt { }
    public class FI_Finland : GeoNameTxt { }
    public class FO_FaroeIslands : GeoNameTxt { }
    public class FR_France : GeoNameTxt { }
    public class GB_UnitedKingdom : GeoNameTxt { }
    public class GF_FrenchGuiana : GeoNameTxt { }
    public class GG_Guernsey : GeoNameTxt { }
    public class GL_Greenland : GeoNameTxt { }
    public class GP_Guadeloupe : GeoNameTxt { }
    public class GT_Guatemala : GeoNameTxt { }
    public class GU_Guam : GeoNameTxt { }
    public class HR_Croatia : GeoNameTxt { }
    public class HU_Hungary : GeoNameTxt { }
    public class IE_Ireland : GeoNameTxt { }
    public class IM_IsleofMan : GeoNameTxt { }
    public class IN_India : GeoNameTxt { }
    public class IS_Iceland : GeoNameTxt { }
    public class IT_Italy : GeoNameTxt { }
    public class JE_Jersey : GeoNameTxt { }
    public class JP_Japan : GeoNameTxt { }
    public class LI_Liechtenstein : GeoNameTxt { }
    public class LK_SriLanka : GeoNameTxt { }
    public class LT_Lithuania : GeoNameTxt { }
    public class LU_Luxembourg : GeoNameTxt { }
    public class MC_Monaco : GeoNameTxt { }
    public class MD_Moldova : GeoNameTxt { }
    public class MH_MarshallIslands : GeoNameTxt { }
    public class MK_Macedonia : GeoNameTxt { }
    public class MP_NorthernMarianaIslands : GeoNameTxt { }
    public class MQ_Martinique : GeoNameTxt { }
    public class MT_Malta : GeoNameTxt { }
    public class MX_Mexico : GeoNameTxt { }
    public class MY_Malaysia : GeoNameTxt { }
    public class NC_NewCaledonia : GeoNameTxt { }
    public class NL_Netherlands : GeoNameTxt { }
    public class NO_Norway : GeoNameTxt { }
    public class NZ_NewZealand : GeoNameTxt { }
    public class PH_Philippines : GeoNameTxt { }
    public class PK_Pakistan : GeoNameTxt { }
    public class PL_Poland : GeoNameTxt { }
    public class PM_St_PierreAndMiquelon : GeoNameTxt { }
    public class PR_PuertoRico : GeoNameTxt { }
    public class PT_Portugal : GeoNameTxt { }
    public class RE_Reunion : GeoNameTxt { }
    public class RO_Romania : GeoNameTxt { }
    public class RU_Russia : GeoNameTxt { }
    public class SE_Sweden : GeoNameTxt { }
    public class SI_Slovenia : GeoNameTxt { }
    public class SJ_SvalbardAndJanMayen : GeoNameTxt { }
    public class SK_Slovakia : GeoNameTxt { }
    public class SM_SanMarino : GeoNameTxt { }
    public class TH_Thailand : GeoNameTxt { }
    public class TR_Turkey : GeoNameTxt { }
    public class US_UnitedStates : GeoNameTxt { }
    public class VA_VaticanCity : GeoNameTxt { }
    public class VI_US_VirginIslands : GeoNameTxt { }
    public class WF_WallisAndFutuna : GeoNameTxt { }
    public class YT_Mayotte : GeoNameTxt { }
    public class ZA_SouthAfrica : GeoNameTxt { }
}
