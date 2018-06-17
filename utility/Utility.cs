using System;
using System.Collections.Generic;

namespace utility
{
    public enum TerritoryTypeEnum
    {
        Country = 1, State = 2, CountyOrProvince = 3, Community = 4, Place = 5
    }

    public class utility
    {
        public static string GetCacheCode(int index, string CountryCode, string Code, string Name)
        {
            if (index <= 1 || index >= 6 || string.IsNullOrWhiteSpace(CountryCode) || string.IsNullOrWhiteSpace(Code) || string.IsNullOrWhiteSpace(Name))
                return null;
            switch ((TerritoryTypeEnum)index)
            {
                case TerritoryTypeEnum.State:
                    return string.Format("{0}2", CountryCode);
                case TerritoryTypeEnum.CountyOrProvince:
                    return string.Format("{0}3:{1}_{2}", CountryCode, Code, Name);
                case TerritoryTypeEnum.Community:
                    return string.Format("{0}4:{1}_{2}", CountryCode, Code, Name);
                case TerritoryTypeEnum.Place:
                    return string.Format("{0}5:{1}_{2}", CountryCode, Code, Name);
                default:
                    throw new Exception(nameof(GetCacheCode));
            }
        }

        public Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt",  "text/plain"},
                {".pdf",  "application/pdf"},
                {".doc",  "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls",  "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png",  "image/png"},
                {".jpg",  "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif",  "image/gif"},
                {".csv",  "text/csv"},
                { ".zip", "application/x-rar-compressed"},
                { ".json", "application/x-rar-compressed"}
            };
        }
    }
}
