using System.Text;

namespace _02_BaseControls_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsSelectedMeal()
        {
            return (checkBox1.Checked || checkBox2.Checked|| checkBox3.Checked);
        }
        private void ClearTextBox()
        {
            //textBox1.Text = "";
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }
        private void clickBtn_Click(object sender, EventArgs e)
        {

            if(!IsSelectedMeal())
            {
                MessageBox.Show("Select meal ");
                return;//break
            }

            StringBuilder res = new StringBuilder("============ Order ================\n");
            res.Append("Meals : ");
            if (checkBox1.Checked)
                res.Append("Breakfast ");
            if (checkBox2.Checked)
                res.Append("Lunch ");
            if (checkBox3.Checked)
                res.Append("Dinner ");

            res.Append("\nDelivery : ");
            if (radioButton1.Checked)
                res.Append(radioButton1.Text);
            if (radioButton2.Checked)
                res.Append(radioButton2.Text);
            if (radioButton3.Checked)
                res.Append(radioButton3.Text);

            res.Append("\nPayment type : ");
            if (radioButton4.Checked)
                res.Append(radioButton4.Text);
            if (radioButton5.Checked)
                res.Append(radioButton5.Text);
            if (radioButton6.Checked)
                res.Append(radioButton6.Text);

            res.AppendLine("\nLogin : " + textBox1.Text);
            res.AppendLine("Password : " + textBox2.Text);
            res.AppendLine("Phone  : " + maskedTextBox1.Text);

            res.AppendLine("Date  : " + dateTimePicker1.Value);
            res.AppendLine("From  : " + monthCalendar1.SelectionStart);
            res.AppendLine("To  : " + monthCalendar1.SelectionEnd);
            res.AppendLine("Count  : " + numericUpDown1.Value);

            MessageBox.Show(res.ToString());
            ClearTextBox();
        }


    }
}