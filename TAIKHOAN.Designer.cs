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

    public partial class TAIKHOAN : XPObject
    {
        string fMATK;
        public string MATK
        {
            get { return fMATK; }
            set { SetPropertyValue<string>(nameof(MATK), ref fMATK, value); }
        }
        string fTENDANGNHAP;
        public string TENDANGNHAP
        {
            get { return fTENDANGNHAP; }
            set { SetPropertyValue<string>(nameof(TENDANGNHAP), ref fTENDANGNHAP, value); }
        }
        string fPASS;
        public string PASS
        {
            get { return fPASS; }
            set { SetPropertyValue<string>(nameof(PASS), ref fPASS, value); }
        }
        [Association(@"NHANVIENReferencesTAIKHOAN"), Aggregated]
        public XPCollection<NHANVIEN> NHANVIENs { get { return GetCollection<NHANVIEN>(nameof(NHANVIENs)); } }
    }

}
