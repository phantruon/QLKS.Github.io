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

    public partial class DATPHONG : XPObject
    {
        string fMADP;
        public string MADP
        {
            get { return fMADP; }
            set { SetPropertyValue<string>(nameof(MADP), ref fMADP, value); }
        }
        NHANVIEN fMANV;
        [Association(@"DATPHONGReferencesNHANVIEN")]
        public NHANVIEN MANV
        {
            get { return fMANV; }
            set { SetPropertyValue<NHANVIEN>(nameof(MANV), ref fMANV, value); }
        }
        PHONG fMAP;
        [Association(@"DATPHONGReferencesPHONG")]
        public PHONG MAP
        {
            get { return fMAP; }
            set { SetPropertyValue<PHONG>(nameof(MAP), ref fMAP, value); }
        }
        string fMAKH;
        [DevExpress.Xpo.DisplayName(@"KHÁCH HÀNG")]
        public string MAKH
        {
            get { return fMAKH; }
            set { SetPropertyValue<string>(nameof(MAKH), ref fMAKH, value); }
        }
        string fNGAYDEN;
        public string NGAYDEN
        {
            get { return fNGAYDEN; }
            set { SetPropertyValue<string>(nameof(NGAYDEN), ref fNGAYDEN, value); }
        }
        string fNGAYDI;
        public string NGAYDI
        {
            get { return fNGAYDI; }
            set { SetPropertyValue<string>(nameof(NGAYDI), ref fNGAYDI, value); }
        }
        [Association(@"HOADONReferencesDATPHONG"), Aggregated]
        public XPCollection<HOADON> HOADONs { get { return GetCollection<HOADON>(nameof(HOADONs)); } }
    }

}