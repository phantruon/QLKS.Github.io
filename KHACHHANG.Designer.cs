﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QUẢN_LÝ_KHÁCH_SẠN.Module.BusinessObjects.ORMDataModel1
{

    public partial class KHACHHANG : XPObject
    {
        string fMAKH;
        public string MAKH
        {
            get { return fMAKH; }
            set { SetPropertyValue<string>(nameof(MAKH), ref fMAKH, value); }
        }
        string fHOTEN;
        public string HOTEN
        {
            get { return fHOTEN; }
            set { SetPropertyValue<string>(nameof(HOTEN), ref fHOTEN, value); }
        }
        [Association(@"PHIEUTHUEReferencesKHACHHANG"), Aggregated]
        public XPCollection<PHIEUTHUE> PHIEUTHUEs { get { return GetCollection<PHIEUTHUE>(nameof(PHIEUTHUEs)); } }
    }

}
