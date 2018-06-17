namespace common.enums
{
    public enum TerritoriesEnum
    {
        AD, AR, AS, AT, AU, AX, BD, BE, BG, BR, BY, CA, CH, CO, CR, CZ, DE, DK, DO, DZ, ES, FI, FO, FR, GB, GF, GG, GL, GP, GT, GU, HR, HU, IE, IM, IN, IS, IT, JE, JP, LI, LK, LT, LU, MC, MD, MH, MK, MP, MQ, MT, MX, MY, NC, NL, NO, NZ, PH, PK, PL, PM, PR, PT, RE, RO, RU, SE, SI, SJ, SK, SM, TH, TR, US, VA, VI, WF, YT, ZA
    }
    public enum TerritoryTypeEnum
    {
        Country = 1, State = 2, CountyOrProvince = 3, Community = 4, Place = 5
    }
    public enum LogLevel
    {
        Debug = 1, Verbose = 2, Information = 3, Warning = 4, Error = 5, Critical = 6, None = int.MaxValue
    }
}
