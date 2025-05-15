using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.IConverter
{
    public class NumericValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            double result;
            bool isValid = Double.TryParse(sender.Text, out result);
            sender.BackgroundColor = isValid ? Microsoft.Maui.Graphics.Colors.Transparent : Microsoft.Maui.Graphics.Colors.Red;
        }
    }
}
