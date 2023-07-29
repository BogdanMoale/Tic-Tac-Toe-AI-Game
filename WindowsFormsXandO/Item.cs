using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI2
{
    public class Item
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public Item (string text, int value )
        {
            Text = text;
            Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
