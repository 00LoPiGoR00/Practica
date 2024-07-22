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
public class Purchase : XPCustomObject
{
    public Purchase(Session session) : base(session) { }
    [Key(AutoGenerate = false)]
    public int PurchaseId { get; set; }
    public DateTime PurchaseDate { get; set; }
    [Association("Customer-Purchases")]
    [RuleRequiredField(DefaultContexts.Save)]
    public Customer Customer { get; set; }
    [Association("Seller-Purchases")]
    [RuleRequiredField(DefaultContexts.Save)]
    public Seller Seller { get; set; }
    [Association("Product-Purchases")]
    [RuleRequiredField(DefaultContexts.Save)]
    public Product Product { get; set; }
}