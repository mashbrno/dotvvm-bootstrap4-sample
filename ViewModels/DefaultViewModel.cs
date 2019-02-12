using System;
using DotVVM.Framework.Controls.Bootstrap4;

namespace DotVVM4.ViewModels
{
    public class DefaultViewModel : BaseViewModel
    {
        public DefaultViewModel()
        {
            Title = "Default page";
        }
        public string AlertText { get; set; }

        public void ShowAlert()
        {
            AlertText = "This is alert test.";
        }
    }
}