using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.CustomControlItem
{
    public class ComboBoxItem
    {
        public string Text { set; get; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
