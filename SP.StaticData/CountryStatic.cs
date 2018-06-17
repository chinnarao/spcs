using System;
using System.Collections.Generic;
using System.Text;

namespace SP.StaticData
{
    public static class CountryStatic
    {
        public static Dictionary<string, string> CountryCodesAndNamesDictionary = new Dictionary<string, string>
        {
            {"AD", "AD_Andorra"},{"AR", "AR_Argentina"},{"AS", "AS_AmericanSamoa"},{"AT", "AT_Austria"},{"AU", "AU_Australia"},{"AX", "AX_landIslands"},{"BD", "BD_Bangladesh"},{"BE", "BE_Belgium"},{"BG", "BG_Bulgaria"},{"BR", "BR_Brazil"},{"BY", "BY_Belarus"},{"CA", "CA_Canada"},{"CH", "CH_Switzerland"},{"CO", "CO_Colombia"},{"CR", "CR_CostaRica"},{"CZ", "CZ_Czechia"},{"DE", "DE_Germany"},{"DK", "DK_Denmark"},{"DO", "DO_DominicanRepublic"},{"DZ", "DZ_Algeria"},{"ES", "ES_Spain"},{"FI", "FI_Finland"},{"FO", "FO_FaroeIslands"},{"FR", "FR_France"},{"GB", "GB_UnitedKingdom"},{"GF", "GF_FrenchGuiana"},{"GG", "GG_Guernsey"},{"GL", "GL_Greenland"},{"GP", "GP_Guadeloupe"},{"GT", "GT_Guatemala"},{"GU", "GU_Guam"},{"HR", "HR_Croatia"},{"HU", "HU_Hungary"},{"IE", "IE_Ireland"},{"IM", "IM_IsleofMan"},{"IN", "IN_India"},{"IS", "IS_Iceland"},{"IT", "IT_Italy"},{"JE", "JE_Jersey"},{"JP", "JP_Japan"},{"LI", "LI_Liechtenstein"},{"LK", "LK_SriLanka"},{"LT", "LT_Lithuania"},{"LU", "LU_Luxembourg"},{"MC", "MC_Monaco"},{"MD", "MD_Moldova"},{"MH", "MH_MarshallIslands"},{"MK", "MK_Macedonia"},{"MP", "MP_NorthernMarianaIslands"},{"MQ", "MQ_Martinique"},{"MT", "MT_Malta"},{"MX", "MX_Mexico"},{"MY", "MY_Malaysia"},{"NC", "NC_NewCaledonia"},{"NL", "NL_Netherlands"},{"NO", "NO_Norway"},{"NZ", "NZ_NewZealand"},{"PH", "PH_Philippines"},{"PK", "PK_Pakistan"},{"PL", "PL_Poland"},{"PM", "PM_St.Pierre&Miquelon"},{"PR", "PR_PuertoRico"},{"PT", "PT_Portugal"},{"RE", "RE_R�union"},{"RO", "RO_Romania"},{"RU", "RU_Russia"},{"SE", "SE_Sweden"},{"SI", "SI_Slovenia"},{"SJ", "SJ_Svalbard&JanMayen"},{"SK", "SK_Slovakia"},{"SM", "SM_SanMarino"},{"TH", "TH_Thailand"},{"TR", "TR_Turkey"},{"US", "US_UnitedStates"},{"VA", "VA_VaticanCity"},{"VI", "VI_U.S.VirginIslands"},{"WF", "WF_Wallis&Futuna"},{"YT", "YT_Mayotte"},{"ZA", "ZA_SouthAfrica"}
        };

        public static string GetCountryCodeAndName(string TerritoryCode)
        {
            string result;
            if (CountryCodesAndNamesDictionary.TryGetValue(TerritoryCode, out result))
                return result;
            return null;
        }

        public static Dictionary<string, string> CountryNamesDictionary = new Dictionary<string, string>
        {
            {"AD", "Andorra"},{"AR", "Argentina"},{"AS", "AmericanSamoa"},{"AT", "Austria"},{"AU", "Australia"},{"AX", "�landIslands"},{"BD", "Bangladesh"},{"BE", "Belgium"},{"BG", "Bulgaria"},{"BR", "Brazil"},{"BY", "Belarus"},{"CA", "Canada"},{"CH", "Switzerland"},{"CO", "Colombia"},{"CR", "CostaRica"},{"CZ", "Czechia"},{"DE", "Germany"},{"DK", "Denmark"},{"DO", "DominicanRepublic"},{"DZ", "Algeria"},{"ES", "Spain"},{"FI", "Finland"},{"FO", "FaroeIslands"},{"FR", "France"},{"GB", "UnitedKingdom"},{"GF", "FrenchGuiana"},{"GG", "Guernsey"},{"GL", "Greenland"},{"GP", "Guadeloupe"},{"GT", "Guatemala"},{"GU", "Guam"},{"HR", "Croatia"},{"HU", "Hungary"},{"IE", "Ireland"},{"IM", "IsleofMan"},{"IN", "India"},{"IS", "Iceland"},{"IT", "Italy"},{"JE", "Jersey"},{"JP", "Japan"},{"LI", "Liechtenstein"},{"LK", "SriLanka"},{"LT", "Lithuania"},{"LU", "Luxembourg"},{"MC", "Monaco"},{"MD", "Moldova"},{"MH", "MarshallIslands"},{"MK", "Macedonia"},{"MP", "NorthernMarianaIslands"},{"MQ", "Martinique"},{"MT", "Malta"},{"MX", "Mexico"},{"MY", "Malaysia"},{"NC", "NewCaledonia"},{"NL", "Netherlands"},{"NO", "Norway"},{"NZ", "NewZealand"},{"PH", "Philippines"},{"PK", "Pakistan"},{"PL", "Poland"},{"PM", "St.Pierre&Miquelon"},{"PR", "PuertoRico"},{"PT", "Portugal"},{"RE", "R�union"},{"RO", "Romania"},{"RU", "Russia"},{"SE", "Sweden"},{"SI", "Slovenia"},{"SJ", "Svalbard&JanMayen"},{"SK", "Slovakia"},{"SM", "SanMarino"},{"TH", "Thailand"},{"TR", "Turkey"},{"US", "UnitedStates"},{"VA", "VaticanCity"},{"VI", "U.S.VirginIslands"},{"WF", "Wallis&Futuna"},{"YT", "Mayotte"},{"ZA", "SouthAfrica"}
        };

        public static string GetCountryName(string TerritoryCode)
        {
            string result;
            if (CountryNamesDictionary.TryGetValue(TerritoryCode, out result))
                return result;
            return null;
        }
    }
}
