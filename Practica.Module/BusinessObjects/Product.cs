using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Practica.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

[DefaultClassOptions]
public class Product : XPCustomObject
{
    public Product(Session session) : base(session) { }

    [Key(AutoGenerate = false)]
    public int ProductId { get; set; }
    [RuleRequiredField(DefaultContexts.Save)]
    public string Name { get; set; }
    public decimal Price { get; set; }

    [Association("Product-Purchases")]
    public XPCollection<Purchase> Purchases => GetCollection<Purchase>(nameof(Purchases));
}