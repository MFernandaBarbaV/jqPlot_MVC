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
    
    public partial class CodeDataLog
    {
        public long CodeDataLogID { get; set; }
        public int CypherKeyID { get; set; }
        public long Folio { get; set; }
        public short FieldTypeID { get; set; }
        public int Bytes { get; set; }
        public string Value { get; set; }
    
        public virtual DataType DataType { get; set; }
    }
}