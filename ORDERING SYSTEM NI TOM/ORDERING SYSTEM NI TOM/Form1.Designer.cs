namespace ORDERING_SYSTEM_NI_TOM
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
            panel1 = new Panel();
            label15 = new Label();
            bconfirm = new Button();
            bvoid = new Button();
            label14 = new Label();
            lbtotal = new Label();
            lbt = new Label();
            label11 = new Label();
            txtamount = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cb2 = new ComboBox();
            cb1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(bconfirm);
            panel1.Controls.Add(bvoid);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lbtotal);
            panel1.Controls.Add(lbt);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtamount);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cb2);
            panel1.Controls.Add(cb1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 806);
            panel1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(216, 10);
            label15.Name = "label15";
            label15.Size = new Size(86, 32);
            label15.TabIndex = 19;
            label15.Text = "MENU";
            // 
            // bconfirm
            // 
            bconfirm.BackColor = Color.Green;
            bconfirm.FlatAppearance.BorderSize = 0;
            bconfirm.FlatStyle = FlatStyle.Flat;
            bconfirm.ForeColor = Color.White;
            bconfirm.Location = new Point(268, 668);
            bconfirm.Name = "bconfirm";
            bconfirm.Size = new Size(211, 31);
            bconfirm.TabIndex = 18;
            bconfirm.Text = "CONFIRM";
            bconfirm.UseVisualStyleBackColor = false;
            bconfirm.Click += bconfirm_Click;
            // 
            // bvoid
            // 
            bvoid.BackColor = Color.Red;
            bvoid.FlatAppearance.BorderSize = 0;
            bvoid.FlatStyle = FlatStyle.Flat;
            bvoid.ForeColor = Color.White;
            bvoid.Location = new Point(12, 668);
            bvoid.Name = "bvoid";
            bvoid.Size = new Size(211, 31);
            bvoid.TabIndex = 17;
            bvoid.Text = "VOID";
            bvoid.UseVisualStyleBackColor = false;
            bvoid.Click += bvoid_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 590);
            label14.Name = "label14";
            label14.Size = new Size(76, 21);
            label14.TabIndex = 16;
            label14.Text = "CHANGE";
            // 
            // lbtotal
            // 
            lbtotal.AutoSize = true;
            lbtotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtotal.Location = new Point(457, 411);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(23, 17);
            lbtotal.TabIndex = 15;
            lbtotal.Text = "---";
            // 
            // lbt
            // 
            lbt.AutoSize = true;
            lbt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbt.Location = new Point(457, 475);
            lbt.Name = "lbt";
            lbt.Size = new Size(23, 17);
            lbt.TabIndex = 14;
            lbt.Text = "---";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(457, 596);
            label11.Name = "label11";
            label11.Size = new Size(23, 17);
            label11.TabIndex = 13;
            label11.Text = "---";
            // 
            // txtamount
            // 
            txtamount.Location = new Point(12, 552);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(211, 23);
            txtamount.TabIndex = 12;
            txtamount.TextChanged += txtamount_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 517);
            label10.Name = "label10";
            label10.Size = new Size(127, 32);
            label10.TabIndex = 11;
            label10.Text = "PAYMENT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 405);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 10;
            label9.Text = "TOTAL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 469);
            label8.Name = "label8";
            label8.Size = new Size(39, 21);
            label8.TabIndex = 9;
            label8.Text = "TAX";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(194, 354);
            label7.Name = "label7";
            label7.Size = new Size(108, 32);
            label7.TabIndex = 8;
            label7.Text = "RECEIPT";
            // 
            // cb2
            // 
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "ROYAL", "COCA-COLA", "SPRITE", "SPRITE", "COBRA", "MOUNTAIN DEW" });
            cb2.Location = new Point(12, 233);
            cb2.Name = "cb2";
            cb2.Size = new Size(271, 23);
            cb2.TabIndex = 7;
            cb2.SelectedIndexChanged += cb2_SelectedIndexChanged;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "NISSIN RAMEN CREAMY SEAFOOD", "SAMYANG CARBONARA HOT CHICKEN RAMEN", "LUCKY ME PANCIT CANTON CHILI-MANSI", "LUCKY ME PANCIT CANTON KALAMANSI", "NISSIN YAKISOBA SPICY CHICKEN" });
            cb1.Location = new Point(12, 100);
            cb1.Name = "cb1";
            cb1.Size = new Size(271, 23);
            cb1.TabIndex = 6;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(457, 233);
            label6.Name = "label6";
            label6.Size = new Size(23, 17);
            label6.TabIndex = 5;
            label6.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(456, 106);
            label5.Name = "label5";
            label5.Size = new Size(23, 17);
            label5.TabIndex = 4;
            label5.Text = "---";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(408, 198);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 3;
            label4.Text = "PRICE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(399, 77);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 2;
            label3.Text = "PRICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(271, 32);
            label2.TabIndex = 1;
            label2.Text = "CARBONATED DRINKS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 0;
            label1.Text = "DISHES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(532, 830);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BASIC ORDERING SYSTEM";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cb2;
        private ComboBox cb1;
        private Label label6;
        private Label label5;
        private Label label14;
        private Label lbtotal;
        private Label lbt;
        private Label label11;
        private TextBox txtamount;
        private Button bconfirm;
        private Button bvoid;
        private Label label15;
    }
}
