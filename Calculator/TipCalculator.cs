// Main File 
// Code Written by Me... Akash Pal

using System;

using System.Windows.Forms;

namespace Calculator
{
    public partial class TipCalculator : Form
    {
        public TipCalculator()
        {
            InitializeComponent();
        }
        
        // Function to check for exceptions
        void CheckException(double txt1, double txt2, double txt3)
        {
            if (txt1 < 0 || txt1 == null)
            {
                throw new MyException("Bill Value should be Greater than 1");   // Throw exception with passing arguments
            }
            if (txt2 < 0)
            {
                throw new MyException("Tip percent cannot be Negative");
            }
            if (txt3 < 1 )
            {
                throw new MyException("Number of People cannot be less than 1");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox4.AutoSize = true;
            this.textBox5.AutoSize = true;

            
            
            try
            {
                double txt1 = Convert.ToDouble(textBox1.Text);
                double txt2 = Convert.ToDouble(textBox2.Text);
                int txt3 = Convert.ToInt32(textBox3.Text);
                CheckException(txt1, txt2, txt3);
                double Tip_per_person = (txt1 * txt2 / 100) / txt3;
                double total_per_person = txt1 / txt3 + Tip_per_person;
                textBox4.Text = $"$ {Tip_per_person.ToString("###,###.00")}";
                textBox5.Text = $"$ {total_per_person.ToString("###,###.00")}";
            }
            catch (MyException MExcp)   // Checkinh my Own Exceptions 
            {
                MessageBox.Show(MExcp.Message); 
            }
            catch(Exception E) // Checking system defined Exceptions
            {
                MessageBox.Show("Enter all Fields\n"+E.Message+"\nCheck All Inputs Again");
            }
        }

    }
}

//User Defined Exception
public class MyException : Exception
{
    public MyException(string message) : base(message)
    {

    }
}
