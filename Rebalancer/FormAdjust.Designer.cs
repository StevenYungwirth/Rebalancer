namespace Rebalancer
{
    partial class FormAdjust
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
            this.txtRateAnnual = new System.Windows.Forms.TextBox();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoRateAnnual = new System.Windows.Forms.RadioButton();
            this.rdoAmount = new System.Windows.Forms.RadioButton();
            this.rdoRateUpdate = new System.Windows.Forms.RadioButton();
            this.txtRateUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRateAnnual
            // 
            this.txtRateAnnual.Location = new System.Drawing.Point(145, 31);
            this.txtRateAnnual.Name = "txtRateAnnual";
            this.txtRateAnnual.Size = new System.Drawing.Size(100, 20);
            this.txtRateAnnual.TabIndex = 4;
            this.txtRateAnnual.TextChanged += new System.EventHandler(this.txtFeeRate_TextChanged);
            this.txtRateAnnual.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Enabled = false;
            this.txtFeeAmount.Location = new System.Drawing.Point(145, 102);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtFeeAmount.TabIndex = 6;
            this.txtFeeAmount.TextChanged += new System.EventHandler(this.txtFeeAmount_TextChanged);
            this.txtFeeAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(26, 142);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(153, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdoRateAnnual
            // 
            this.rdoRateAnnual.AutoSize = true;
            this.rdoRateAnnual.Checked = true;
            this.rdoRateAnnual.Location = new System.Drawing.Point(28, 32);
            this.rdoRateAnnual.Name = "rdoRateAnnual";
            this.rdoRateAnnual.Size = new System.Drawing.Size(90, 17);
            this.rdoRateAnnual.TabIndex = 1;
            this.rdoRateAnnual.TabStop = true;
            this.rdoRateAnnual.Text = "Rate (Annual)";
            this.rdoRateAnnual.UseVisualStyleBackColor = true;
            this.rdoRateAnnual.CheckedChanged += new System.EventHandler(this.rdoRate_CheckedChanged);
            // 
            // rdoAmount
            // 
            this.rdoAmount.AutoSize = true;
            this.rdoAmount.Location = new System.Drawing.Point(28, 102);
            this.rdoAmount.Name = "rdoAmount";
            this.rdoAmount.Size = new System.Drawing.Size(61, 17);
            this.rdoAmount.TabIndex = 3;
            this.rdoAmount.Text = "Amount";
            this.rdoAmount.UseVisualStyleBackColor = true;
            this.rdoAmount.CheckedChanged += new System.EventHandler(this.rdoAmount_CheckedChanged);
            // 
            // rdoRateUpdate
            // 
            this.rdoRateUpdate.AutoSize = true;
            this.rdoRateUpdate.Location = new System.Drawing.Point(28, 67);
            this.rdoRateUpdate.Name = "rdoRateUpdate";
            this.rdoRateUpdate.Size = new System.Drawing.Size(111, 17);
            this.rdoRateUpdate.TabIndex = 2;
            this.rdoRateUpdate.TabStop = true;
            this.rdoRateUpdate.Text = "Rate (Per Update)";
            this.rdoRateUpdate.UseVisualStyleBackColor = true;
            this.rdoRateUpdate.CheckedChanged += new System.EventHandler(this.rdoRateUpdate_CheckedChanged);
            // 
            // txtRateUpdate
            // 
            this.txtRateUpdate.Enabled = false;
            this.txtRateUpdate.Location = new System.Drawing.Point(145, 66);
            this.txtRateUpdate.Name = "txtRateUpdate";
            this.txtRateUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtRateUpdate.TabIndex = 5;
            this.txtRateUpdate.TextChanged += new System.EventHandler(this.txtRateUpdate_TextChanged);
            this.txtRateUpdate.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // FormAdjust
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(255, 197);
            this.Controls.Add(this.txtRateUpdate);
            this.Controls.Add(this.rdoRateUpdate);
            this.Controls.Add(this.rdoAmount);
            this.Controls.Add(this.rdoRateAnnual);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFeeAmount);
            this.Controls.Add(this.txtRateAnnual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdjust";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adjust Fee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtRateAnnual;
        public System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.RadioButton rdoRateAnnual;
        private System.Windows.Forms.RadioButton rdoAmount;
        private System.Windows.Forms.RadioButton rdoRateUpdate;
        private System.Windows.Forms.TextBox txtRateUpdate;
    }
}