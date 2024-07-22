using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica.Module.Controllers
{
    public partial class CardUser : ViewController
    {
        public CardUser()
        {
            InitializeComponent();
            SimpleAction countCustomerCardsAction = new SimpleAction(
            this, "Подсчет количества карт у человека", PredefinedCategory.View)
            {
                Caption = "Подсчет количества карт у человека",
                ImageName = "Action_Count"
            };
            countCustomerCardsAction.Execute += CountCustomerCardsAction_Execute;
            Actions.Add(countCustomerCardsAction);
        }
        private void CountCustomerCardsAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Customer selectedCustomer = View.CurrentObject as Customer;
            if (selectedCustomer != null)
            {
                int cardCount = selectedCustomer.CardAv.Count;
                string message = $"Количество карт равно {cardCount} .";
                MessageOptions options = new MessageOptions
                {
                    Duration = 2000,
                    Message = message,
                    Type = InformationType.Info
                };
                Application.ShowViewStrategy.ShowMessage(options);
            }
        }
    }
}
