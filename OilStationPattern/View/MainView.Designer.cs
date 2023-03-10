namespace OilStationPattern
{
    partial class MainView
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
            this.oilComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.quantumBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.quantityBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.quantityTxtb = new System.Windows.Forms.TextBox();
            this.quantumTxtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalamountLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilComboBox
            // 
            this.oilComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oilComboBox.FormattingEnabled = true;
            this.oilComboBox.Location = new System.Drawing.Point(143, 29);
            this.oilComboBox.Name = "oilComboBox";
            this.oilComboBox.Size = new System.Drawing.Size(121, 25);
            this.oilComboBox.TabIndex = 0;
            this.oilComboBox.SelectedIndexChanged += new System.EventHandler(this.oilComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "OIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRICE";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.quantumBtn);
            this.guna2GroupBox1.Controls.Add(this.quantityBtn);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Location = new System.Drawing.Point(529, 23);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(95, 80);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // quantumBtn
            // 
            this.quantumBtn.AutoSize = true;
            this.quantumBtn.BackColor = System.Drawing.Color.Transparent;
            this.quantumBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantumBtn.CheckedState.BorderThickness = 0;
            this.quantumBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantumBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.quantumBtn.CheckedState.InnerOffset = -4;
            this.quantumBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantumBtn.ForeColor = System.Drawing.Color.Snow;
            this.quantumBtn.Location = new System.Drawing.Point(3, 31);
            this.quantumBtn.Name = "quantumBtn";
            this.quantumBtn.Size = new System.Drawing.Size(100, 25);
            this.quantumBtn.TabIndex = 4;
            this.quantumBtn.Text = "Quantum";
            this.quantumBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quantumBtn.UncheckedState.BorderThickness = 2;
            this.quantumBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.quantumBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.quantumBtn.UseVisualStyleBackColor = false;
            this.quantumBtn.CheckedChanged += new System.EventHandler(this.quantumBtn_CheckedChanged);
            // 
            // quantityBtn
            // 
            this.quantityBtn.AutoSize = true;
            this.quantityBtn.BackColor = System.Drawing.Color.Transparent;
            this.quantityBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityBtn.CheckedState.BorderThickness = 0;
            this.quantityBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.quantityBtn.CheckedState.InnerOffset = -4;
            this.quantityBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantityBtn.ForeColor = System.Drawing.Color.Snow;
            this.quantityBtn.Location = new System.Drawing.Point(3, 0);
            this.quantityBtn.Name = "quantityBtn";
            this.quantityBtn.Size = new System.Drawing.Size(95, 25);
            this.quantityBtn.TabIndex = 4;
            this.quantityBtn.Text = "Quantity";
            this.quantityBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quantityBtn.UncheckedState.BorderThickness = 2;
            this.quantityBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.quantityBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.quantityBtn.UseVisualStyleBackColor = false;
            this.quantityBtn.CheckedChanged += new System.EventHandler(this.quantityBtn_CheckedChanged);
            // 
            // quantityTxtb
            // 
            this.quantityTxtb.Enabled = false;
            this.quantityTxtb.Location = new System.Drawing.Point(635, 26);
            this.quantityTxtb.Name = "quantityTxtb";
            this.quantityTxtb.Size = new System.Drawing.Size(91, 20);
            this.quantityTxtb.TabIndex = 4;
            this.quantityTxtb.TextChanged += new System.EventHandler(this.quantityTxtb_TextChanged);
            // 
            // quantumTxtb
            // 
            this.quantumTxtb.Enabled = false;
            this.quantumTxtb.Location = new System.Drawing.Point(635, 59);
            this.quantumTxtb.Name = "quantumTxtb";
            this.quantumTxtb.Size = new System.Drawing.Size(91, 20);
            this.quantumTxtb.TabIndex = 4;
            this.quantumTxtb.TextChanged += new System.EventHandler(this.quantumTxtb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(135, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Amount :";
            // 
            // totalamountLbl
            // 
            this.totalamountLbl.AutoSize = true;
            this.totalamountLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalamountLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalamountLbl.Location = new System.Drawing.Point(449, 337);
            this.totalamountLbl.Name = "totalamountLbl";
            this.totalamountLbl.Size = new System.Drawing.Size(0, 45);
            this.totalamountLbl.TabIndex = 6;
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.SystemColors.Window;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLbl.Location = new System.Drawing.Point(143, 72);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(121, 21);
            this.priceLbl.TabIndex = 7;
            this.priceLbl.TextChanged += new System.EventHandler(this.priceLbl_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(612, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "AZN";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OilStationPattern.Properties.Resources.gas_station1;
            this.ClientSize = new System.Drawing.Size(834, 386);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.totalamountLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantumTxtb);
            this.Controls.Add(this.quantityTxtb);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oilComboBox);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox oilComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton quantumBtn;
        private Guna.UI2.WinForms.Guna2RadioButton quantityBtn;
        private System.Windows.Forms.TextBox quantityTxtb;
        private System.Windows.Forms.TextBox quantumTxtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalamountLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label label4;
    }
}

