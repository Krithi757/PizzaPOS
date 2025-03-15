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
            radioButton1 = new RadioButton();
            label2 = new Label();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(208, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 30);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Small";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(208, 193);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 30);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Medium";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(208, 238);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 30);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Large";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(208, 286);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(137, 30);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Extra Large";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(200, 446);
            button1.Name = "button1";
            button1.Size = new Size(209, 41);
            button1.TabIndex = 9;
            button1.Text = "Add to your order";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(487, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 373);
            dataGridView1.TabIndex = 10;
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
            // textBox1
            // 
            textBox1.Location = new Point(200, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 31);
            textBox1.TabIndex = 11;
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
            // button3
            // 
            button3.Location = new Point(200, 536);
            button3.Name = "button3";
            button3.Size = new Size(209, 41);
            button3.TabIndex = 15;
            button3.Text = "Set your prices";
            button3.UseVisualStyleBackColor = true;
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(label2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Billing";
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private RadioButton radioButton1;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
    }
}