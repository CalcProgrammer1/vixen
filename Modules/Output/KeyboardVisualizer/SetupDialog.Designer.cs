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
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSettingsLbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(162, 269);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(87, 27);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            this.btnOkay.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.btnOkay.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // btnPortSetup
            // 
            this.btnPortSetup.Location = new System.Drawing.Point(139, 42);
            this.btnPortSetup.Name = "btnPortSetup";
            this.btnPortSetup.Size = new System.Drawing.Size(182, 27);
            this.btnPortSetup.TabIndex = 0;
            this.btnPortSetup.Text = "Setup/Change Serial Port";
            this.btnPortSetup.UseVisualStyleBackColor = true;
            this.btnPortSetup.Click += new System.EventHandler(this.btnPortSetup_Click);
            this.btnPortSetup.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.btnPortSetup.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblSettings);
            this.groupBox1.Controls.Add(this.lblSettingsLbl);
            this.groupBox1.Controls.Add(this.btnPortSetup);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxes_Paint);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(75, 23);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(209, 15);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "COM1: 115200, Space, 8, OnePointFive";
            // 
            // lblSettingsLbl
            // 
            this.lblSettingsLbl.AutoSize = true;
            this.lblSettingsLbl.Location = new System.Drawing.Point(8, 23);
            this.lblSettingsLbl.Name = "lblSettingsLbl";
            this.lblSettingsLbl.Size = new System.Drawing.Size(59, 15);
            this.lblSettingsLbl.TabIndex = 4;
            this.lblSettingsLbl.Text = "Currently:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Use UDP";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // SetupDialog
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(363, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 355);
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
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSettingsLbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}