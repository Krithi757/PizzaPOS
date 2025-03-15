namespace PizzaPOS
{
    partial class Settimgs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            PriceTb = new TextBox();
            SubmitBtn = new Button();
            BackLbl = new Label();
            label5 = new Label();
            PizzaCb = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 2;
            label1.Text = "Pizza Ordering System";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.OrangeRed;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(94, 450);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 144);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "Select the pizza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 252);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "Enter the price";
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(206, 291);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(247, 27);
            PriceTb.TabIndex = 6;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(206, 354);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(134, 41);
            SubmitBtn.TabIndex = 8;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Location = new Point(355, 421);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(40, 20);
            BackLbl.TabIndex = 9;
            BackLbl.Text = "Back";
            BackLbl.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(759, 36);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 10;
            label5.Text = "X";
            // 
            // PizzaCb
            // 
            PizzaCb.FormattingEnabled = true;
            PizzaCb.Items.AddRange(new object[] { "Extra Large", "Large", "Medium", "Small" });
            PizzaCb.Location = new Point(206, 191);
            PizzaCb.Name = "PizzaCb";
            PizzaCb.Size = new Size(237, 28);
            PizzaCb.TabIndex = 11;
            // 
            // Settimgs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PizzaCb);
            Controls.Add(label5);
            Controls.Add(BackLbl);
            Controls.Add(SubmitBtn);
            Controls.Add(label3);
            Controls.Add(PriceTb);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "Settimgs";
            Text = "Settimgs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private TextBox PriceTb;
        private Button SubmitBtn;
        private Label BackLbl;
        private Label label5;
        private ComboBox PizzaCb;
    }
}