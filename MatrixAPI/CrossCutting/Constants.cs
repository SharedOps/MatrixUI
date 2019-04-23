using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixAPI.CrossCutting
{
    public class Constants
    {
        public const string InsertNavigationSp  = "sp_Insert_Navigation";
        public const string GetNavigationItemsSp = "sp_Get_Navigation";
        public const string InsertOfficeLocationSp = "sp_Insert_OfficeLocation";
        public const string GetOfficeLocationsSp = "sp_Get_OfficeLocations";


        public const string ParamNavId          = "@p_Id";
        public const string ParamNavTitle       = "@p_Title";
        public const string ParamNavLink        = "@p_Link";
        public const string ParamNavChildLink   = "@p_ChildLinks";
        public const string ParamNavCreatedDate = "@p_CreatedDate";

        public const string ParamId = "@p_Id";
        public const string ParamCity = "@p_City";
        public const string ParamCountry = "@p_Country";
        public const string ParamAddress = "@p_Address";
        public const string ParamCreatedDate = "@p_CreatedDate";




    }
}
