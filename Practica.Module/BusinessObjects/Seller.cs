using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Practica.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Seller : XPCustomObject
    {
        public Seller(Session session) : base(session) { }
        [Key(AutoGenerate = false)]
        public int SellerId { get; set; }
        [RuleRequiredField(DefaultContexts.Save)]
        public string Name { get; set; }
        [Association("Seller-Purchases")]
        public XPCollection<Purchase> Purchases => GetCollection<Purchase>(nameof(Purchases));
    }
}