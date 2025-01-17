﻿using DevExpress.Data.Filtering;
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

[DefaultClassOptions]
public class Card : XPCustomObject
{
    public Card(Session session) : base(session) { }
    [Key(AutoGenerate = false)]
    public int CustomerId { get; set; }
    public bool CarD { get; set; }
    [Association("Customer-CardAv")]
    [RuleRequiredField(DefaultContexts.Save)]
    public Customer Customer { get; set; }
}