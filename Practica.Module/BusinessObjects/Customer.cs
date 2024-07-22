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
public class Customer : XPCustomObject
{
    public Customer(Session session) : base(session) { }
    [Key(AutoGenerate = false)]
    public int CustomerId { get; set; }
    [RuleRequiredField(DefaultContexts.Save)]
    public string Name { get; set; }

    [Association("Customer-CardAv")]
    public XPCollection<Card> CardAv => GetCollection<Card>(nameof(CardAv));

    [Association("Customer-Purchases")]
    public XPCollection<Purchase> Purchases => GetCollection<Purchase>(nameof(Purchases));
}