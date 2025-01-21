namespace Shoppingcart21
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
            // เพิ่มสินค้าเข้าไปใน Dictionary
            items.Add("Coffee", new Item { Name = "Coffee", Price = 75, Quantity = 0, IsChecked = false });
            items.Add("GreenTea", new Item { Name = "Green Tea", Price = 70, Quantity = 0, IsChecked = false });
            items.Add("Noodle", new Item { Name = "Noodle", Price = 60, Quantity = 0, IsChecked = false });
            items.Add("Pizza", new Item { Name = "Pizza", Price = 199, Quantity = 0, IsChecked = false });
        }

        private void btcheck_out_Click(object sender, EventArgs e)
        {
            try
            {
                // อ่านค่าและอัปเดตสินค้าใน Dictionary
                UpdateItem("Coffee", tbCoffeeQuantity.Text, cbCoffee.Checked);
                UpdateItem("GreenTea", tbGreenTeaQuantity.Text, cbGreenTea.Checked);
                UpdateItem("Noodle", tbNoodleQuantity.Text, cbNoodle.Checked);
                UpdateItem("Pizza", tbPizzaQuantity.Text, cbPizza.Checked);

                // อ่านค่าเงินสดและส่วนลด
                double iCash = string.IsNullOrWhiteSpace(tbCash.Text) ? 0 : double.Parse(tbCash.Text);
                double discountAll = string.IsNullOrWhiteSpace(tbDiscountAll.Text) ? 0 : double.Parse(tbDiscountAll.Text) / 100;
                double discountDrinks = string.IsNullOrWhiteSpace(tbDiscountDrinks.Text) ? 0 : double.Parse(tbDiscountDrinks.Text) / 100;
                double discountFood = string.IsNullOrWhiteSpace(tbDiscountFood.Text) ? 0 : double.Parse(tbDiscountFood.Text) / 100;

                // คำนวณยอดรวมแยกตามประเภท
                double drinksTotal = GetTotal(new[] { "Coffee", "GreenTea" });
                double foodTotal = GetTotal(new[] { "Noodle", "Pizza" });
                double iTotal = drinksTotal + foodTotal;

                // คำนวณส่วนลด
                double discountAmount = 0;
                if (cbAll.Checked && discountAll > 0)
                {
                    discountAmount = iTotal * discountAll; // ลดทั้งหมด
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
                    iTotal = drinksTotal + foodTotal; // รวมยอดใหม่หลังลดราคา
                }

                // คำนวณเงินทอน
                double iChange = iCash - iTotal;

                // แสดงผลลัพธ์
                tbDiscountAmount.Text = discountAmount.ToString("F2");
                tbTotal.Text = iTotal.ToString("F2");
                tbChange.Text = iChange.ToString("F2");

                // แจกแจงเงินทอน
                DisplayChange(iChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการคำนวณ: " + ex.Message);
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
            foreach (var item in items.Values)
            {
                item.Quantity = 0;
                item.IsChecked = false;
            }

            tbCoffeeQuantity.Text = tbGreenTeaQuantity.Text = tbNoodleQuantity.Text = tbPizzaQuantity.Text = "";
            tbCash.Text = tbDiscountAll.Text = tbDiscountDrinks.Text = tbDiscountFood.Text = "0";
            tbDiscountAmount.Text = tbTotal.Text = tbChange.Text = "0.00";
            tb1000.Text = tb500.Text = tb100.Text = tb50.Text = tb20.Text = tb10.Text = tb5.Text = tb1.Text = "";

            cbCoffee.Checked = cbGreenTea.Checked = cbNoodle.Checked = cbPizza.Checked = false;
            cbAll.Checked = cbBeverage.Checked = cbFood.Checked = false;
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsChecked { get; set; }
    }
}
