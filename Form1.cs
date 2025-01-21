namespace SPCart
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Item> items = new Dictionary<string, Item>();

        public Form1()
        {
            InitializeComponent();
            InitializeItems();
        }

        private void InitializeItems()
        {
            // �����Թ�������� Dictionary
            items.Add("Coffee", new Item { Name = "Coffee", Price = 75, Quantity = 0, IsChecked = false });
            items.Add("GreenTea", new Item { Name = "Green Tea", Price = 70, Quantity = 0, IsChecked = false });
            items.Add("Noodle", new Item { Name = "Noodle", Price = 60, Quantity = 0, IsChecked = false });
            items.Add("Pizza", new Item { Name = "Pizza", Price = 199, Quantity = 0, IsChecked = false });

            // ��˹������������ TextBox ����Ѻ�Ҥ��Թ���
            tbCoffeePrice.Text = items["Coffee"].Price.ToString("F2");
            tbGreenTeaPrice.Text = items["GreenTea"].Price.ToString("F2");
            tbNoodlePrice.Text = items["Noodle"].Price.ToString("F2");
            tbPizzaPrice.Text = items["Pizza"].Price.ToString("F2");

            // ��ͧ�ѹ�����䢤��㹪�ͧ�Ҥ�
            tbCoffeePrice.ReadOnly = true;
            tbGreenTeaPrice.ReadOnly = true;
            tbNoodlePrice.ReadOnly = true;
            tbPizzaPrice.ReadOnly = true;
        }


        private void btcheck_out_Click_1(object sender, EventArgs e)
        {
            try
            {
                // ��ҹ�������ѻവ�Թ���� Dictionary
                UpdateItem("Coffee", tbCoffeeQuantity.Text, cbCoffee.Checked);
                UpdateItem("GreenTea", tbGreenTeaQuantity.Text, cbGreenTea.Checked);
                UpdateItem("Noodle", tbNoodleQuantity.Text, cbNoodle.Checked);
                UpdateItem("Pizza", tbPizzaQuantity.Text, cbPizza.Checked);

                // ��ҹ����Թʴ�����ǹŴ
                double iCash = string.IsNullOrWhiteSpace(tbCash.Text) ? 0 : double.Parse(tbCash.Text);
                double discountAll = string.IsNullOrWhiteSpace(tbDiscountAll.Text) ? 0 : double.Parse(tbDiscountAll.Text) / 100;
                double discountDrinks = string.IsNullOrWhiteSpace(tbDiscountDrinks.Text) ? 0 : double.Parse(tbDiscountDrinks.Text) / 100;
                double discountFood = string.IsNullOrWhiteSpace(tbDiscountFood.Text) ? 0 : double.Parse(tbDiscountFood.Text) / 100;

                // �ӹǳ�ʹ����¡���������
                double drinksTotal = GetTotal(new[] { "Coffee", "GreenTea" });
                double foodTotal = GetTotal(new[] { "Noodle", "Pizza" });
                double iTotal = drinksTotal + foodTotal;

                // �ӹǳ��ǹŴ
                double discountAmount = 0;
                if (cbAll.Checked && discountAll > 0)
                {
                    discountAmount = iTotal * discountAll; // ��ǹŴ����Ѻ�ʹ���������
                    iTotal -= discountAmount;
                }
                else
                {
                    if (cbBeverage.Checked && discountDrinks > 0)
                    {
                        double drinksDiscount = drinksTotal * discountDrinks;
                        discountAmount += drinksDiscount;
                        drinksTotal -= drinksDiscount;
                    }
                    if (cbFood.Checked && discountFood > 0)
                    {
                        double foodDiscount = foodTotal * discountFood;
                        discountAmount += foodDiscount;
                        foodTotal -= foodDiscount;
                    }
                    iTotal = drinksTotal + foodTotal; // ����ʹ������ѧŴ�Ҥ�
                }

                // �ӹǳ�Թ�͹
                double iChange = iCash - iTotal;

                // �ʴ����Ѿ��
                tbDiscountAmount.Text = discountAmount.ToString("F2");
                tbTotal.Text = iTotal.ToString("F2");
                tbChange.Text = iChange.ToString("F2");

                // ᨡᨧ�Թ�͹
                DisplayChange(iChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Դ��ͼԴ��Ҵ㹡�äӹǳ: " + ex.Message);
            }
        }

        private void UpdateItem(string itemName, string quantityText, bool isChecked)
        {
            if (items.ContainsKey(itemName))
            {
                var item = items[itemName];
                item.Quantity = string.IsNullOrWhiteSpace(quantityText) ? 0 : int.Parse(quantityText);
                item.IsChecked = isChecked;
            }
        }

        private double GetTotal(string[] itemNames)
        {
            double total = 0;
            foreach (var itemName in itemNames)
            {
                if (items.ContainsKey(itemName) && items[itemName].IsChecked)
                {
                    var item = items[itemName];
                    total += item.Price * item.Quantity;
                }
            }
            return total;
        }

        private void DisplayChange(double iChange)
        {
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = (int)(iChange / denominations[i]);
                iChange %= denominations[i];
                denominationTextBoxes[i].Text = count.ToString();
            }
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            // ������������Թ���
            foreach (var item in items.Values)
            {
                item.Price = 0;
                item.Quantity = 0;
                item.IsChecked = false;
            }

            // ����������� TextBox


            tbTotal.Text = tbCash.Text = tbChange.Text = "";
            tbDiscountAll.Text = tbDiscountDrinks.Text = tbDiscountFood.Text = "0";
            tbDiscountAmount.Text = "0.00";

            tb1000.Text = tb500.Text = tb100.Text = "";
            tb50.Text = tb20.Text = tb10.Text = tb5.Text = tb1.Text = "";

            cbCoffee.Checked = cbGreenTea.Checked = false;
            cbNoodle.Checked = cbPizza.Checked = false;
            cbAll.Checked = cbBeverage.Checked = cbFood.Checked = false;
        }

    }
}
