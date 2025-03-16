namespace PizzaPOS
{
    partial class Billing
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            SmallBtn = new RadioButton();
            label2 = new Label();
            MediumBtn = new RadioButton();
            LargeBtn = new RadioButton();
            ExtraLargeBtn = new RadioButton();
            OrderBtn = new Button();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            QtyTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SettingsBtn = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.OrangeRed;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(131, 602);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 23);
            label1.Name = "label1";
            label1.Size = new Size(213, 26);
            label1.TabIndex = 1;
            label1.Text = "Pizza Ordering System";
            // 
            // SmallBtn
            // 
            SmallBtn.AutoSize = true;
            SmallBtn.Location = new Point(208, 145);
            SmallBtn.Name = "SmallBtn";
            SmallBtn.Size = new Size(83, 30);
            SmallBtn.TabIndex = 4;
            SmallBtn.TabStop = true;
            SmallBtn.Text = "Small";
            SmallBtn.UseVisualStyleBackColor = true;
            SmallBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 103);
            label2.Name = "label2";
            label2.Size = new Size(201, 26);
            label2.TabIndex = 5;
            label2.Text = "Please Select A Pizza";
            // 
            // MediumBtn
            // 
            MediumBtn.AutoSize = true;
            MediumBtn.Location = new Point(208, 193);
            MediumBtn.Name = "MediumBtn";
            MediumBtn.Size = new Size(104, 30);
            MediumBtn.TabIndex = 6;
            MediumBtn.TabStop = true;
            MediumBtn.Text = "Medium";
            MediumBtn.UseVisualStyleBackColor = true;
            // 
            // LargeBtn
            // 
            LargeBtn.AutoSize = true;
            LargeBtn.Location = new Point(208, 238);
            LargeBtn.Name = "LargeBtn";
            LargeBtn.Size = new Size(83, 30);
            LargeBtn.TabIndex = 7;
            LargeBtn.TabStop = true;
            LargeBtn.Text = "Large";
            LargeBtn.UseVisualStyleBackColor = true;
            // 
            // ExtraLargeBtn
            // 
            ExtraLargeBtn.AutoSize = true;
            ExtraLargeBtn.Location = new Point(208, 286);
            ExtraLargeBtn.Name = "ExtraLargeBtn";
            ExtraLargeBtn.Size = new Size(137, 30);
            ExtraLargeBtn.TabIndex = 8;
            ExtraLargeBtn.TabStop = true;
            ExtraLargeBtn.Text = "Extra Large";
            ExtraLargeBtn.UseVisualStyleBackColor = true;
            // 
            // OrderBtn
            // 
            OrderBtn.Location = new Point(200, 446);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(209, 41);
            OrderBtn.TabIndex = 9;
            OrderBtn.Text = "Add to your order";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // BillDGV
            // 
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Location = new Point(487, 114);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersWidth = 51;
            BillDGV.Size = new Size(500, 373);
            BillDGV.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 2;
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 70;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(200, 383);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(91, 31);
            QtyTb.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 354);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 12;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(964, 23);
            label4.Name = "label4";
            label4.Size = new Size(23, 26);
            label4.TabIndex = 13;
            label4.Text = "X";
            // 
            // button2
            // 
            button2.Location = new Point(651, 536);
            button2.Name = "button2";
            button2.Size = new Size(209, 41);
            button2.TabIndex = 14;
            button2.Text = "Print order";
            button2.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Location = new Point(200, 536);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(209, 41);
            SettingsBtn.TabIndex = 15;
            SettingsBtn.Text = "Set your prices";
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(699, 507);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 16;
            label5.Text = "TotalLabel";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 599);
            Controls.Add(label5);
            Controls.Add(SettingsBtn);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(QtyTb);
            Controls.Add(BillDGV);
            Controls.Add(OrderBtn);
            Controls.Add(ExtraLargeBtn);
            Controls.Add(LargeBtn);
            Controls.Add(MediumBtn);
            Controls.Add(label2);
            Controls.Add(SmallBtn);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Billing";
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private RadioButton SmallBtn;
        private Label label2;
        private RadioButton MediumBtn;
        private RadioButton LargeBtn;
        private RadioButton ExtraLargeBtn;
        private Button OrderBtn;
        private DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox QtyTb;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button SettingsBtn;
        private Label label5;
    }
}