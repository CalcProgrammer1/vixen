namespace VixenModules.Output.KeyboardVisualizer
{
    partial class SetupDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialog));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnPortSetup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSettingsLbl = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(441, 538);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 54);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(278, 538);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(149, 54);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            this.btnOkay.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.btnOkay.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // btnPortSetup
            // 
            this.btnPortSetup.Location = new System.Drawing.Point(238, 84);
            this.btnPortSetup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPortSetup.Name = "btnPortSetup";
            this.btnPortSetup.Size = new System.Drawing.Size(312, 54);
            this.btnPortSetup.TabIndex = 0;
            this.btnPortSetup.Text = "Setup/Change Serial Port";
            this.btnPortSetup.UseVisualStyleBackColor = true;
            this.btnPortSetup.Click += new System.EventHandler(this.btnPortSetup_Click);
            this.btnPortSetup.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.btnPortSetup.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblSettings);
            this.groupBox1.Controls.Add(this.lblSettingsLbl);
            this.groupBox1.Controls.Add(this.btnPortSetup);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(562, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxes_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 278);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 35);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 220);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 35);
            this.textBox1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 228);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 34);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Use UDP";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(129, 46);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(369, 30);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "COM1: 115200, Space, 8, OnePointFive";
            // 
            // lblSettingsLbl
            // 
            this.lblSettingsLbl.AutoSize = true;
            this.lblSettingsLbl.Location = new System.Drawing.Point(14, 46);
            this.lblSettingsLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSettingsLbl.Name = "lblSettingsLbl";
            this.lblSettingsLbl.Size = new System.Drawing.Size(102, 30);
            this.lblSettingsLbl.TabIndex = 4;
            this.lblSettingsLbl.Text = "Currently:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 157);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(149, 34);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Xmas Mode";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // SetupDialog
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(622, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(633, 646);
            this.Name = "SetupDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generic Serial Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnPortSetup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSettingsLbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}