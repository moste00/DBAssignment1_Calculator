using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();

            set_operations_counter(0);
        }

        private void set_operations_counter(int v)
        {
            operations_counter.ReadOnly = false;
            operations_counter.Text = v.ToString();
            operations_counter.ReadOnly = true;
        }

        private int get_operations_counter()
        {
            return Int32.Parse(operations_counter.Text);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (op.Text != "" && FirstValue.Text != "" && SecondValue.Text != "")
            {
                History.Rows.Add(System.DateTime.Now, FirstValue.Value, op.Text, SecondValue.Value, performOp() );

                set_operations_counter(get_operations_counter() + 1);
            }
        }

        private Decimal performOp()
        {
            switch (op.Text)
            {
                case "+": return FirstValue.Value + SecondValue.Value ;
                case "-": return FirstValue.Value - SecondValue.Value ;

                //This should never happen
                default: return "THIS SHOULD HAVE NEVER HAPPENED LOL".GetHashCode();
            }

        }

        private void HistoryToggle_Click(object sender, EventArgs e)
        {
            History.Visible = !History.Visible;
        }

        private void HistoryClr_Click(object sender, EventArgs e)
        {
            History.Rows.Clear();
            set_operations_counter(0);
        }
    }

 
        

}
