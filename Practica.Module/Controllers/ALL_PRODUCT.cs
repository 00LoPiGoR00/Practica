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
    public partial class ALL_PRODUCT : ViewController
    {
        public ALL_PRODUCT()
        {
            InitializeComponent();
            SimpleAction countProductsAction = new SimpleAction(
                this, "Подсчет продуктов", PredefinedCategory.View)
            {
                Caption = "Подсчет продуктов"
            };
            countProductsAction.Execute += CountProductsAction_Execute;
            Actions.Add(countProductsAction);
        }
        private void CountProductsAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace();
            int productCount = objectSpace.GetObjects<Product>().Count();
            string message = $"Общее количество позиций продуктов: {productCount}";
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
