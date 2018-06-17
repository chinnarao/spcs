using SP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SP.DAL.Contexts
{
    public class SPDbContext : IdentityDbContext<SPUser>
    {
        public SPDbContext(DbContextOptions<SPDbContext> options) : base(options)
        {
        }
        #region World
        public DbSet<AD_Andorra> AD_Andorra { get; set; }
        public DbSet<AR_Argentina> AR_Argentina { get; set; }
        public DbSet<AS_AmericanSamoa> AS_AmericanSamoa { get; set; }
        public DbSet<AT_Austria> AT_Austria { get; set; }
        public DbSet<AU_Australia> AU_Australia { get; set; }
        public DbSet<AX_AlandIslands> AX_AlandIslands { get; set; }
        public DbSet<BD_Bangladesh> BD_Bangladesh { get; set; }
        public DbSet<BE_Belgium> BE_Belgium { get; set; }
        public DbSet<BG_Bulgaria> BG_Bulgaria { get; set; }
        public DbSet<BR_Brazil> BR_Brazil { get; set; }
        public DbSet<BY_Belarus> BY_Belarus { get; set; }
        public DbSet<CA_Canada> CA_Canada { get; set; }
        public DbSet<CH_Switzerland> CH_Switzerland { get; set; }
        public DbSet<CO_Colombia> CO_Colombia { get; set; }
        public DbSet<CR_CostaRica> CR_CostaRica { get; set; }
        public DbSet<CZ_Czechia> CZ_Czechia { get; set; }
        public DbSet<DE_Germany> DE_Germany { get; set; }
        public DbSet<DK_Denmark> DK_Denmark { get; set; }
        public DbSet<DO_DominicanRepublic> DO_DominicanRepublic { get; set; }
        public DbSet<DZ_Algeria> DZ_Algeria { get; set; }
        public DbSet<ES_Spain> ES_Spain { get; set; }
        public DbSet<FI_Finland> FI_Finland { get; set; }
        public DbSet<FO_FaroeIslands> FO_FaroeIslands { get; set; }
        public DbSet<FR_France> FR_France { get; set; }
        public DbSet<GB_UnitedKingdom> GB_UnitedKingdom { get; set; }
        public DbSet<GF_FrenchGuiana> GF_FrenchGuiana { get; set; }
        public DbSet<GG_Guernsey> GG_Guernsey { get; set; }
        public DbSet<GL_Greenland> GL_Greenland { get; set; }
        public DbSet<GP_Guadeloupe> GP_Guadeloupe { get; set; }
        public DbSet<GT_Guatemala> GT_Guatemala { get; set; }
        public DbSet<GU_Guam> GU_Guam { get; set; }
        public DbSet<HR_Croatia> HR_Croatia { get; set; }
        public DbSet<HU_Hungary> HU_Hungary { get; set; }
        public DbSet<IE_Ireland> IE_Ireland { get; set; }
        public DbSet<IM_IsleofMan> IM_IsleofMan { get; set; }
        public DbSet<IN_India> IN_India { get; set; }
        public DbSet<IS_Iceland> IS_Iceland { get; set; }
        public DbSet<IT_Italy> IT_Italy { get; set; }
        public DbSet<JE_Jersey> JE_Jersey { get; set; }
        public DbSet<JP_Japan> JP_Japan { get; set; }
        public DbSet<LI_Liechtenstein> LI_Liechtenstein { get; set; }
        public DbSet<LK_SriLanka> LK_SriLanka { get; set; }
        public DbSet<LT_Lithuania> LT_Lithuania { get; set; }
        public DbSet<LU_Luxembourg> LU_Luxembourg { get; set; }
        public DbSet<MC_Monaco> MC_Monaco { get; set; }
        public DbSet<MD_Moldova> MD_Moldova { get; set; }
        public DbSet<MH_MarshallIslands> MH_MarshallIslands { get; set; }
        public DbSet<MK_Macedonia> MK_Macedonia { get; set; }
        public DbSet<MP_NorthernMarianaIslands> MP_NorthernMarianaIslands { get; set; }
        public DbSet<MQ_Martinique> MQ_Martinique { get; set; }
        public DbSet<MT_Malta> MT_Malta { get; set; }
        public DbSet<MX_Mexico> MX_Mexico { get; set; }
        public DbSet<MY_Malaysia> MY_Malaysia { get; set; }
        public DbSet<NC_NewCaledonia> NC_NewCaledonia { get; set; }
        public DbSet<NL_Netherlands> NL_Netherlands { get; set; }
        public DbSet<NO_Norway> NO_Norway { get; set; }
        public DbSet<NZ_NewZealand> NZ_NewZealand { get; set; }
        public DbSet<PH_Philippines> PH_Philippines { get; set; }
        public DbSet<PK_Pakistan> PK_Pakistan { get; set; }
        public DbSet<PL_Poland> PL_Poland { get; set; }
        public DbSet<PM_St_PierreAndMiquelon> PM_St_PierreAndMiquelon { get; set; }
        public DbSet<PR_PuertoRico> PR_PuertoRico { get; set; }
        public DbSet<PT_Portugal> PT_Portugal { get; set; }
        public DbSet<RE_Reunion> RE_Reunion { get; set; }
        public DbSet<RO_Romania> RO_Romania { get; set; }
        public DbSet<RU_Russia> RU_Russia { get; set; }
        public DbSet<SE_Sweden> SE_Sweden { get; set; }
        public DbSet<SI_Slovenia> SI_Slovenia { get; set; }
        public DbSet<SJ_SvalbardAndJanMayen> SJ_SvalbardAndJanMayen { get; set; }
        public DbSet<SK_Slovakia> SK_Slovakia { get; set; }
        public DbSet<SM_SanMarino> SM_SanMarino { get; set; }
        public DbSet<TH_Thailand> TH_Thailand { get; set; }
        public DbSet<TR_Turkey> TR_Turkey { get; set; }
        public DbSet<US_UnitedStates> US_UnitedStates { get; set; }
        public DbSet<VA_VaticanCity> VA_VaticanCity { get; set; }
        public DbSet<VI_US_VirginIslands> VI_US_VirginIslands { get; set; }
        public DbSet<WF_WallisAndFutuna> WF_WallisAndFutuna { get; set; }
        public DbSet<YT_Mayotte> YT_Mayotte { get; set; }
        public DbSet<ZA_SouthAfrica> ZA_SouthAfrica { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}