namespace SPCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            Checkout = new Button();
            Clear = new Button();
            lbTotai = new Label();
            lbCash = new Label();
            lbChange = new Label();
            lb1000 = new Label();
            lb500 = new Label();
            lb100 = new Label();
            lb50 = new Label();
            lb20 = new Label();
            lb10 = new Label();
            lb5 = new Label();
            lb1 = new Label();
            tbCoffeePrice = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            tb10 = new TextBox();
            tbTotal = new TextBox();
            tb1 = new TextBox();
            tb20 = new TextBox();
            tbCash = new TextBox();
            tb5 = new TextBox();
            tb50 = new TextBox();
            tb100 = new TextBox();
            tb500 = new TextBox();
            tb1000 = new TextBox();
            tbChange = new TextBox();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(48, 61);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(75, 24);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(48, 101);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(93, 24);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "GreenTea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            Checkout.Location = new Point(446, 63);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(94, 224);
            Checkout.TabIndex = 2;
            Checkout.Text = "Check out";
            Checkout.UseVisualStyleBackColor = true;
            Checkout.Click += Checkout_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(446, 293);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 167);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // lbTotai
            // 
            lbTotai.AutoSize = true;
            lbTotai.Location = new Point(109, 176);
            lbTotai.Name = "lbTotai";
            lbTotai.Size = new Size(42, 20);
            lbTotai.TabIndex = 4;
            lbTotai.Text = "Total";
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(268, 176);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(40, 20);
            lbCash.TabIndex = 5;
            lbCash.Text = "Cash";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(574, 67);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(59, 20);
            lbChange.TabIndex = 6;
            lbChange.Text = "Change";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(574, 118);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(41, 20);
            lb1000.TabIndex = 7;
            lb1000.Text = "1000";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(574, 160);
            lb500.Name = "lb500";
            lb500.Size = new Size(33, 20);
            lb500.TabIndex = 8;
            lb500.Text = "500";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(574, 203);
            lb100.Name = "lb100";
            lb100.Size = new Size(33, 20);
            lb100.TabIndex = 9;
            lb100.Text = "100";
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(574, 250);
            lb50.Name = "lb50";
            lb50.Size = new Size(25, 20);
            lb50.TabIndex = 10;
            lb50.Text = "50";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(574, 301);
            lb20.Name = "lb20";
            lb20.Size = new Size(25, 20);
            lb20.TabIndex = 11;
            lb20.Text = "20";
            lb20.Click += lb10_Click;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(574, 347);
            lb10.Name = "lb10";
            lb10.Size = new Size(25, 20);
            lb10.TabIndex = 12;
            lb10.Text = "10";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(574, 390);
            lb5.Name = "lb5";
            lb5.Size = new Size(17, 20);
            lb5.TabIndex = 13;
            lb5.Text = "5";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(574, 436);
            lb1.Name = "lb1";
            lb1.Size = new Size(17, 20);
            lb1.TabIndex = 14;
            lb1.Text = "1";
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(167, 58);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 15;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(298, 59);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 16;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(167, 98);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 17;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(298, 98);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(125, 27);
            tbGreenTeaQuantity.TabIndex = 18;
            // 
            // tb10
            // 
            tb10.Location = new Point(650, 344);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 19;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(76, 203);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 19;
            // 
            // tb1
            // 
            tb1.Location = new Point(650, 433);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 20;
            // 
            // tb20
            // 
            tb20.Location = new Point(650, 294);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 21;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(230, 203);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 22;
            // 
            // tb5
            // 
            tb5.Location = new Point(650, 390);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 23;
            // 
            // tb50
            // 
            tb50.Location = new Point(650, 243);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 24;
            // 
            // tb100
            // 
            tb100.Location = new Point(650, 203);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 25;
            // 
            // tb500
            // 
            tb500.Location = new Point(650, 160);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 26;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(650, 115);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 27;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(650, 67);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 612);
            Controls.Add(tbChange);
            Controls.Add(tb1000);
            Controls.Add(tb500);
            Controls.Add(tb100);
            Controls.Add(tb50);
            Controls.Add(tb5);
            Controls.Add(tbCash);
            Controls.Add(tb20);
            Controls.Add(tb1);
            Controls.Add(tbTotal);
            Controls.Add(tb10);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbCoffeePrice);
            Controls.Add(lb1);
            Controls.Add(lb5);
            Controls.Add(lb10);
            Controls.Add(lb20);
            Controls.Add(lb50);
            Controls.Add(lb100);
            Controls.Add(lb500);
            Controls.Add(lb1000);
            Controls.Add(lbChange);
            Controls.Add(lbCash);
            Controls.Add(lbTotai);
            Controls.Add(Clear);
            Controls.Add(Checkout);
            Controls.Add(chbGreenTea);
            Controls.Add(chbCoffee);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private Button Checkout;
        private Button Clear;
        private Label lbTotai;
        private Label lbCash;
        private Label lbChange;
        private Label lb1000;
        private Label lb500;
        private Label lb100;
        private Label lb50;
        private Label lb20;
        private Label lb10;
        private Label lb5;
        private Label lb1;
        private TextBox tbCoffeePrice;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaPrice;
        private TextBox tbGreenTeaQuantity;
        private TextBox tb10;
        private TextBox tbTotal;
        private TextBox tb1;
        private TextBox tb20;
        private TextBox tbCash;
        private TextBox tb5;
        private TextBox tb50;
        private TextBox tb100;
        private TextBox tb500;
        private TextBox tb1000;
        private TextBox tbChange;
    }
}
