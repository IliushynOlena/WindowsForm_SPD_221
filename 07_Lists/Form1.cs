namespace _07_Lists
{
    public partial class Form1 : Form
    {
        List<Order> orders = null;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            orderCBox.Items.Clear();    
            orders = new List<Order>();
            orders.Add(new Order(random.Next(1000)));    
            orders.Add(new Order(random.Next(1000)));    
            orders.Add(new Order(random.Next(1000)));    
            orders.Add(new Order(random.Next(1000)));
            //orderCBox.Items.AddRange(orders.ToArray());
            //orderCBox.DataSource = orders;
            UpdateOrdersComboBox();
        }
        void UpdateOrdersComboBox()
        {
            orderCBox.DataSource = null;
            orderCBox.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (orderCBox.SelectedIndex == -1)
            { MessageBox.Show("Select item in list"); return; }

            Order select = orderCBox.SelectedItem as Order;
            MessageBox.Show(select.Date.ToString(), "Order details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (orderCBox.SelectedIndex == -1) return;

            orders.RemoveAt(orderCBox.SelectedIndex);
            UpdateOrdersComboBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            UpdateOrdersComboBox();
        }
    }
}