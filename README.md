# SPCart
by ������ �ҵ���ش
673450037-2,
Computer and Infomation Science, KKU

```
 private void Checkout_Click(object sender, EventArgs e)
        {
        
            if (chbCoffee.Checked) { }
            // ��ҹ���tb  Coffee
            string strCoffeePrice = tbCoffeePrice.Text;
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            // ��ҹ���tb Greentea
            string strGreenTeaPrice = tbGreenTeaPrice.Text;
            string strGreenTeaQuantity = tbGreenTeaQuantity.Text;

            // ��ҹ��� Cash
            string strCash = tbCash.Text;

            int iCoffeePrice = 0;
            int iCoffeeQuantity = 0;
            int iGreenTeaPrice = 0;
            int iGreenTeaQuantity = 0;
            int iTotal = 0;
            int iCash = 0;
            int iChange = 0;

            try
            {
                // ��Ǩ������� checkboxCoffee �����
                if (chbCoffee.Checked)
                {
                    // �ŧ��Ҩҡ string ໹ int
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }

                // ��Ǩ�ͺ checkboxGreen Tea
                if (chbGreenTea.Checked)
                {
                    iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                    iGreenTeaQuantity = int.Parse(strGreenTeaQuantity);
                }

                //��ҹ��� Cash
                iCash = int.Parse(strCash);

            }

            catch (Exception ex)
            {
                // �ŧ��ҼԴ��Ҵ  ��໹0
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
                iGreenTeaPrice = 0;
                iGreenTeaQuantity = 0;
                iCash = 0;
            }

            //�ӹǹ �ʹ����
            iTotal = (iCoffeePrice * iCoffeeQuantity) + (iGreenTeaPrice * iGreenTeaQuantity);

            //�ӹǹ�Թ�͹
            iChange = iCash - iTotal;

            //�ʴ��ʹ���  �Թ�͹ � TextBox
            tbTotal.Text = iTotal.ToString();
            tbChange.Text = iChange.ToString();

            // ᨡᨧầ���������­ thankyouChatgpt
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = iChange / denominations[i]; //�ӹǹ���  ����­
                iChange %= denominations[i];           //�Թ��������
                denominationTextBoxes[i].Text = count.ToString();
            }
        }
     ```