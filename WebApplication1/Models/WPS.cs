//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WPS
    {
        public int WPSID { get; set; }
        public string WPSFilePath { get; set; }
        public string WPSFolio { get; set; }
        public System.DateTime WPSExpiration { get; set; }
        public int StatusID { get; set; }
        public int IdProjectWP { get; set; }
        public string ProjectName { get; set; }
        public string KeySerialNumber { get; set; }
        public string KeyStatus { get; set; }
        public long KeyInitialCounter { get; set; }
        public long KeyCurrentCounter { get; set; }
        public long KeyMaxFolios { get; set; }
        public System.DateTime KeyExpirationDate { get; set; }
        public int RequestFolios { get; set; }
        public Nullable<System.DateTime> RequestExpiration { get; set; }
        public int RequestTypeID { get; set; }
        public bool IsAuthorized { get; set; }
        public string OwnerUser { get; set; }
        public System.DateTime CreationDate { get; set; }
    }
}
