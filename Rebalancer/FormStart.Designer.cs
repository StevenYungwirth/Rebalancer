namespace Rebalancer
{
    partial class FormStart
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
            this.CBHouseholdList = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoAUM = new System.Windows.Forms.RadioButton();
            this.rdoFee = new System.Windows.Forms.RadioButton();
            this.rdoAUA = new System.Windows.Forms.RadioButton();
            this.rdoAllType = new System.Windows.Forms.RadioButton();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.gbxFrequency = new System.Windows.Forms.GroupBox();
            this.rdoAllFrequency = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoAnnual = new System.Windows.Forms.RadioButton();
            this.rdoSemiAnnual = new System.Windows.Forms.RadioButton();
            this.rdoQuarterly = new System.Windows.Forms.RadioButton();
            this.gbxAnnual = new System.Windows.Forms.GroupBox();
            this.June = new System.Windows.Forms.RadioButton();
            this.rdoMonth5 = new System.Windows.Forms.RadioButton();
            this.rdoMonth4 = new System.Windows.Forms.RadioButton();
            this.rdoMonth3 = new System.Windows.Forms.RadioButton();
            this.rdoMonth2 = new System.Windows.Forms.RadioButton();
            this.rdoMonth1 = new System.Windows.Forms.RadioButton();
            this.rdoMonth12 = new System.Windows.Forms.RadioButton();
            this.rdoMonth11 = new System.Windows.Forms.RadioButton();
            this.rdoMonth10 = new System.Windows.Forms.RadioButton();
            this.rdoMonth9 = new System.Windows.Forms.RadioButton();
            this.rdoMonth8 = new System.Windows.Forms.RadioButton();
            this.rdoMonth7 = new System.Windows.Forms.RadioButton();
            this.rdoSA1 = new System.Windows.Forms.RadioButton();
            this.rdoSA2 = new System.Windows.Forms.RadioButton();
            this.rdoSA3 = new System.Windows.Forms.RadioButton();
            this.rdoSA6 = new System.Windows.Forms.RadioButton();
            this.rdoSA5 = new System.Windows.Forms.RadioButton();
            this.rdoSA4 = new System.Windows.Forms.RadioButton();
            this.rdoQuarterly3 = new System.Windows.Forms.RadioButton();
            this.rdoQuarterly2 = new System.Windows.Forms.RadioButton();
            this.rdoQuarterly1 = new System.Windows.Forms.RadioButton();
            this.gbxQuarterly = new System.Windows.Forms.GroupBox();
            this.gbxSemiAnnual = new System.Windows.Forms.GroupBox();
            this.gbxType.SuspendLayout();
            this.gbxFrequency.SuspendLayout();
            this.gbxAnnual.SuspendLayout();
            this.gbxQuarterly.SuspendLayout();
            this.gbxSemiAnnual.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBHouseholdList
            // 
            this.CBHouseholdList.FormattingEnabled = true;
            this.CBHouseholdList.Location = new System.Drawing.Point(100, 44);
            this.CBHouseholdList.Name = "CBHouseholdList";
            this.CBHouseholdList.Size = new System.Drawing.Size(200, 21);
            this.CBHouseholdList.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(326, 34);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 39);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Household";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(442, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoAUM
            // 
            this.rdoAUM.AutoSize = true;
            this.rdoAUM.Location = new System.Drawing.Point(20, 21);
            this.rdoAUM.Name = "rdoAUM";
            this.rdoAUM.Size = new System.Drawing.Size(49, 17);
            this.rdoAUM.TabIndex = 0;
            this.rdoAUM.TabStop = true;
            this.rdoAUM.Text = "AUM";
            this.rdoAUM.UseVisualStyleBackColor = true;
            // 
            // rdoFee
            // 
            this.rdoFee.AutoSize = true;
            this.rdoFee.Location = new System.Drawing.Point(20, 51);
            this.rdoFee.Name = "rdoFee";
            this.rdoFee.Size = new System.Drawing.Size(43, 17);
            this.rdoFee.TabIndex = 1;
            this.rdoFee.TabStop = true;
            this.rdoFee.Text = "Fee";
            this.rdoFee.UseVisualStyleBackColor = true;
            // 
            // rdoAUA
            // 
            this.rdoAUA.AutoSize = true;
            this.rdoAUA.Location = new System.Drawing.Point(20, 81);
            this.rdoAUA.Name = "rdoAUA";
            this.rdoAUA.Size = new System.Drawing.Size(47, 17);
            this.rdoAUA.TabIndex = 2;
            this.rdoAUA.TabStop = true;
            this.rdoAUA.Text = "AUA";
            this.rdoAUA.UseVisualStyleBackColor = true;
            // 
            // rdoAllType
            // 
            this.rdoAllType.AutoSize = true;
            this.rdoAllType.Location = new System.Drawing.Point(20, 111);
            this.rdoAllType.Name = "rdoAllType";
            this.rdoAllType.Size = new System.Drawing.Size(36, 17);
            this.rdoAllType.TabIndex = 3;
            this.rdoAllType.TabStop = true;
            this.rdoAllType.Text = "All";
            this.rdoAllType.UseVisualStyleBackColor = true;
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rdoAllType);
            this.gbxType.Controls.Add(this.rdoAUA);
            this.gbxType.Controls.Add(this.rdoAUM);
            this.gbxType.Controls.Add(this.rdoFee);
            this.gbxType.Location = new System.Drawing.Point(50, 116);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(88, 149);
            this.gbxType.TabIndex = 4;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Client Type";
            // 
            // gbxFrequency
            // 
            this.gbxFrequency.Controls.Add(this.rdoAllFrequency);
            this.gbxFrequency.Controls.Add(this.rdoOther);
            this.gbxFrequency.Controls.Add(this.rdoAnnual);
            this.gbxFrequency.Controls.Add(this.rdoSemiAnnual);
            this.gbxFrequency.Controls.Add(this.rdoQuarterly);
            this.gbxFrequency.Location = new System.Drawing.Point(160, 116);
            this.gbxFrequency.Name = "gbxFrequency";
            this.gbxFrequency.Size = new System.Drawing.Size(129, 176);
            this.gbxFrequency.TabIndex = 5;
            this.gbxFrequency.TabStop = false;
            this.gbxFrequency.Text = "Update Frequency";
            // 
            // rdoAllFrequency
            // 
            this.rdoAllFrequency.AutoSize = true;
            this.rdoAllFrequency.Location = new System.Drawing.Point(22, 140);
            this.rdoAllFrequency.Name = "rdoAllFrequency";
            this.rdoAllFrequency.Size = new System.Drawing.Size(36, 17);
            this.rdoAllFrequency.TabIndex = 4;
            this.rdoAllFrequency.TabStop = true;
            this.rdoAllFrequency.Text = "All";
            this.rdoAllFrequency.UseVisualStyleBackColor = true;
            this.rdoAllFrequency.CheckedChanged += new System.EventHandler(this.Show_Annual);
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(23, 110);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(82, 17);
            this.rdoOther.TabIndex = 3;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other/None";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.Show_None);
            // 
            // rdoAnnual
            // 
            this.rdoAnnual.AutoSize = true;
            this.rdoAnnual.Location = new System.Drawing.Point(24, 80);
            this.rdoAnnual.Name = "rdoAnnual";
            this.rdoAnnual.Size = new System.Drawing.Size(58, 17);
            this.rdoAnnual.TabIndex = 2;
            this.rdoAnnual.TabStop = true;
            this.rdoAnnual.Text = "Annual";
            this.rdoAnnual.UseVisualStyleBackColor = true;
            this.rdoAnnual.CheckedChanged += new System.EventHandler(this.Show_Annual);
            // 
            // rdoSemiAnnual
            // 
            this.rdoSemiAnnual.AutoSize = true;
            this.rdoSemiAnnual.Location = new System.Drawing.Point(23, 50);
            this.rdoSemiAnnual.Name = "rdoSemiAnnual";
            this.rdoSemiAnnual.Size = new System.Drawing.Size(84, 17);
            this.rdoSemiAnnual.TabIndex = 1;
            this.rdoSemiAnnual.TabStop = true;
            this.rdoSemiAnnual.Text = "Semi-Annual";
            this.rdoSemiAnnual.UseVisualStyleBackColor = true;
            this.rdoSemiAnnual.CheckedChanged += new System.EventHandler(this.Show_SemiAnnual);
            // 
            // rdoQuarterly
            // 
            this.rdoQuarterly.AutoSize = true;
            this.rdoQuarterly.Location = new System.Drawing.Point(23, 20);
            this.rdoQuarterly.Name = "rdoQuarterly";
            this.rdoQuarterly.Size = new System.Drawing.Size(67, 17);
            this.rdoQuarterly.TabIndex = 0;
            this.rdoQuarterly.TabStop = true;
            this.rdoQuarterly.Text = "Quarterly";
            this.rdoQuarterly.UseVisualStyleBackColor = true;
            this.rdoQuarterly.CheckedChanged += new System.EventHandler(this.Show_Quarterly);
            // 
            // gbxAnnual
            // 
            this.gbxAnnual.Controls.Add(this.June);
            this.gbxAnnual.Controls.Add(this.rdoMonth5);
            this.gbxAnnual.Controls.Add(this.rdoMonth4);
            this.gbxAnnual.Controls.Add(this.rdoMonth3);
            this.gbxAnnual.Controls.Add(this.rdoMonth2);
            this.gbxAnnual.Controls.Add(this.rdoMonth1);
            this.gbxAnnual.Controls.Add(this.rdoMonth12);
            this.gbxAnnual.Controls.Add(this.rdoMonth11);
            this.gbxAnnual.Controls.Add(this.rdoMonth10);
            this.gbxAnnual.Controls.Add(this.rdoMonth9);
            this.gbxAnnual.Controls.Add(this.rdoMonth8);
            this.gbxAnnual.Controls.Add(this.rdoMonth7);
            this.gbxAnnual.Location = new System.Drawing.Point(306, 118);
            this.gbxAnnual.Name = "gbxAnnual";
            this.gbxAnnual.Size = new System.Drawing.Size(273, 147);
            this.gbxAnnual.TabIndex = 6;
            this.gbxAnnual.TabStop = false;
            this.gbxAnnual.Text = "Rotation";
            this.gbxAnnual.Visible = false;
            // 
            // June
            // 
            this.June.AutoSize = true;
            this.June.Location = new System.Drawing.Point(106, 49);
            this.June.Name = "June";
            this.June.Size = new System.Drawing.Size(48, 17);
            this.June.TabIndex = 20;
            this.June.TabStop = true;
            this.June.Text = "June";
            this.June.UseVisualStyleBackColor = true;
            // 
            // rdoMonth5
            // 
            this.rdoMonth5.AutoSize = true;
            this.rdoMonth5.Location = new System.Drawing.Point(106, 18);
            this.rdoMonth5.Name = "rdoMonth5";
            this.rdoMonth5.Size = new System.Drawing.Size(45, 17);
            this.rdoMonth5.TabIndex = 19;
            this.rdoMonth5.TabStop = true;
            this.rdoMonth5.Text = "May";
            this.rdoMonth5.UseVisualStyleBackColor = true;
            // 
            // rdoMonth4
            // 
            this.rdoMonth4.AutoSize = true;
            this.rdoMonth4.Location = new System.Drawing.Point(18, 109);
            this.rdoMonth4.Name = "rdoMonth4";
            this.rdoMonth4.Size = new System.Drawing.Size(45, 17);
            this.rdoMonth4.TabIndex = 18;
            this.rdoMonth4.TabStop = true;
            this.rdoMonth4.Text = "April";
            this.rdoMonth4.UseVisualStyleBackColor = true;
            // 
            // rdoMonth3
            // 
            this.rdoMonth3.AutoSize = true;
            this.rdoMonth3.Location = new System.Drawing.Point(18, 79);
            this.rdoMonth3.Name = "rdoMonth3";
            this.rdoMonth3.Size = new System.Drawing.Size(55, 17);
            this.rdoMonth3.TabIndex = 17;
            this.rdoMonth3.TabStop = true;
            this.rdoMonth3.Text = "March";
            this.rdoMonth3.UseVisualStyleBackColor = true;
            // 
            // rdoMonth2
            // 
            this.rdoMonth2.AutoSize = true;
            this.rdoMonth2.Location = new System.Drawing.Point(18, 49);
            this.rdoMonth2.Name = "rdoMonth2";
            this.rdoMonth2.Size = new System.Drawing.Size(66, 17);
            this.rdoMonth2.TabIndex = 16;
            this.rdoMonth2.TabStop = true;
            this.rdoMonth2.Text = "February";
            this.rdoMonth2.UseVisualStyleBackColor = true;
            // 
            // rdoMonth1
            // 
            this.rdoMonth1.AutoSize = true;
            this.rdoMonth1.Location = new System.Drawing.Point(18, 19);
            this.rdoMonth1.Name = "rdoMonth1";
            this.rdoMonth1.Size = new System.Drawing.Size(62, 17);
            this.rdoMonth1.TabIndex = 15;
            this.rdoMonth1.TabStop = true;
            this.rdoMonth1.Text = "January";
            this.rdoMonth1.UseVisualStyleBackColor = true;
            // 
            // rdoMonth12
            // 
            this.rdoMonth12.AutoSize = true;
            this.rdoMonth12.Location = new System.Drawing.Point(177, 109);
            this.rdoMonth12.Name = "rdoMonth12";
            this.rdoMonth12.Size = new System.Drawing.Size(74, 17);
            this.rdoMonth12.TabIndex = 11;
            this.rdoMonth12.TabStop = true;
            this.rdoMonth12.Text = "December";
            this.rdoMonth12.UseVisualStyleBackColor = true;
            // 
            // rdoMonth11
            // 
            this.rdoMonth11.AutoSize = true;
            this.rdoMonth11.Location = new System.Drawing.Point(177, 79);
            this.rdoMonth11.Name = "rdoMonth11";
            this.rdoMonth11.Size = new System.Drawing.Size(74, 17);
            this.rdoMonth11.TabIndex = 10;
            this.rdoMonth11.TabStop = true;
            this.rdoMonth11.Text = "November";
            this.rdoMonth11.UseVisualStyleBackColor = true;
            // 
            // rdoMonth10
            // 
            this.rdoMonth10.AutoSize = true;
            this.rdoMonth10.Location = new System.Drawing.Point(177, 49);
            this.rdoMonth10.Name = "rdoMonth10";
            this.rdoMonth10.Size = new System.Drawing.Size(63, 17);
            this.rdoMonth10.TabIndex = 9;
            this.rdoMonth10.TabStop = true;
            this.rdoMonth10.Text = "October";
            this.rdoMonth10.UseVisualStyleBackColor = true;
            // 
            // rdoMonth9
            // 
            this.rdoMonth9.AutoSize = true;
            this.rdoMonth9.Location = new System.Drawing.Point(177, 19);
            this.rdoMonth9.Name = "rdoMonth9";
            this.rdoMonth9.Size = new System.Drawing.Size(76, 17);
            this.rdoMonth9.TabIndex = 8;
            this.rdoMonth9.TabStop = true;
            this.rdoMonth9.Text = "September";
            this.rdoMonth9.UseVisualStyleBackColor = true;
            // 
            // rdoMonth8
            // 
            this.rdoMonth8.AutoSize = true;
            this.rdoMonth8.Location = new System.Drawing.Point(106, 109);
            this.rdoMonth8.Name = "rdoMonth8";
            this.rdoMonth8.Size = new System.Drawing.Size(58, 17);
            this.rdoMonth8.TabIndex = 7;
            this.rdoMonth8.TabStop = true;
            this.rdoMonth8.Text = "August";
            this.rdoMonth8.UseVisualStyleBackColor = true;
            // 
            // rdoMonth7
            // 
            this.rdoMonth7.AutoSize = true;
            this.rdoMonth7.Location = new System.Drawing.Point(106, 79);
            this.rdoMonth7.Name = "rdoMonth7";
            this.rdoMonth7.Size = new System.Drawing.Size(43, 17);
            this.rdoMonth7.TabIndex = 6;
            this.rdoMonth7.TabStop = true;
            this.rdoMonth7.Text = "July";
            this.rdoMonth7.UseVisualStyleBackColor = true;
            // 
            // rdoSA1
            // 
            this.rdoSA1.AutoSize = true;
            this.rdoSA1.Location = new System.Drawing.Point(18, 19);
            this.rdoSA1.Name = "rdoSA1";
            this.rdoSA1.Size = new System.Drawing.Size(60, 17);
            this.rdoSA1.TabIndex = 14;
            this.rdoSA1.TabStop = true;
            this.rdoSA1.Text = "Jan/Jul";
            this.rdoSA1.UseVisualStyleBackColor = true;
            // 
            // rdoSA2
            // 
            this.rdoSA2.AutoSize = true;
            this.rdoSA2.Location = new System.Drawing.Point(17, 49);
            this.rdoSA2.Name = "rdoSA2";
            this.rdoSA2.Size = new System.Drawing.Size(67, 17);
            this.rdoSA2.TabIndex = 13;
            this.rdoSA2.TabStop = true;
            this.rdoSA2.Text = "Feb/Aug";
            this.rdoSA2.UseVisualStyleBackColor = true;
            // 
            // rdoSA3
            // 
            this.rdoSA3.AutoSize = true;
            this.rdoSA3.Location = new System.Drawing.Point(17, 79);
            this.rdoSA3.Name = "rdoSA3";
            this.rdoSA3.Size = new System.Drawing.Size(67, 17);
            this.rdoSA3.TabIndex = 12;
            this.rdoSA3.TabStop = true;
            this.rdoSA3.Text = "Mar/Sep";
            this.rdoSA3.UseVisualStyleBackColor = true;
            // 
            // rdoSA6
            // 
            this.rdoSA6.AutoSize = true;
            this.rdoSA6.Location = new System.Drawing.Point(104, 79);
            this.rdoSA6.Name = "rdoSA6";
            this.rdoSA6.Size = new System.Drawing.Size(67, 17);
            this.rdoSA6.TabIndex = 5;
            this.rdoSA6.TabStop = true;
            this.rdoSA6.Text = "Jun/Dec";
            this.rdoSA6.UseVisualStyleBackColor = true;
            // 
            // rdoSA5
            // 
            this.rdoSA5.AutoSize = true;
            this.rdoSA5.Location = new System.Drawing.Point(104, 49);
            this.rdoSA5.Name = "rdoSA5";
            this.rdoSA5.Size = new System.Drawing.Size(70, 17);
            this.rdoSA5.TabIndex = 4;
            this.rdoSA5.TabStop = true;
            this.rdoSA5.Text = "May/Nov";
            this.rdoSA5.UseVisualStyleBackColor = true;
            // 
            // rdoSA4
            // 
            this.rdoSA4.AutoSize = true;
            this.rdoSA4.Location = new System.Drawing.Point(104, 19);
            this.rdoSA4.Name = "rdoSA4";
            this.rdoSA4.Size = new System.Drawing.Size(63, 17);
            this.rdoSA4.TabIndex = 3;
            this.rdoSA4.TabStop = true;
            this.rdoSA4.Text = "Apr/Oct";
            this.rdoSA4.UseVisualStyleBackColor = true;
            // 
            // rdoQuarterly3
            // 
            this.rdoQuarterly3.AutoSize = true;
            this.rdoQuarterly3.Location = new System.Drawing.Point(18, 79);
            this.rdoQuarterly3.Name = "rdoQuarterly3";
            this.rdoQuarterly3.Size = new System.Drawing.Size(114, 17);
            this.rdoQuarterly3.TabIndex = 2;
            this.rdoQuarterly3.TabStop = true;
            this.rdoQuarterly3.Text = "Mar/Jun/Sep/Dec";
            this.rdoQuarterly3.UseVisualStyleBackColor = true;
            // 
            // rdoQuarterly2
            // 
            this.rdoQuarterly2.AutoSize = true;
            this.rdoQuarterly2.Location = new System.Drawing.Point(18, 49);
            this.rdoQuarterly2.Name = "rdoQuarterly2";
            this.rdoQuarterly2.Size = new System.Drawing.Size(117, 17);
            this.rdoQuarterly2.TabIndex = 1;
            this.rdoQuarterly2.TabStop = true;
            this.rdoQuarterly2.Text = "Feb/May/Aug/Nov";
            this.rdoQuarterly2.UseVisualStyleBackColor = true;
            // 
            // rdoQuarterly1
            // 
            this.rdoQuarterly1.AutoSize = true;
            this.rdoQuarterly1.Location = new System.Drawing.Point(18, 19);
            this.rdoQuarterly1.Name = "rdoQuarterly1";
            this.rdoQuarterly1.Size = new System.Drawing.Size(103, 17);
            this.rdoQuarterly1.TabIndex = 0;
            this.rdoQuarterly1.TabStop = true;
            this.rdoQuarterly1.Text = "Jan/Apr/Jul/Oct";
            this.rdoQuarterly1.UseVisualStyleBackColor = true;
            // 
            // gbxQuarterly
            // 
            this.gbxQuarterly.Controls.Add(this.rdoQuarterly1);
            this.gbxQuarterly.Controls.Add(this.rdoQuarterly2);
            this.gbxQuarterly.Controls.Add(this.rdoQuarterly3);
            this.gbxQuarterly.Location = new System.Drawing.Point(306, 118);
            this.gbxQuarterly.Name = "gbxQuarterly";
            this.gbxQuarterly.Size = new System.Drawing.Size(149, 115);
            this.gbxQuarterly.TabIndex = 7;
            this.gbxQuarterly.TabStop = false;
            this.gbxQuarterly.Text = "Rotation";
            // 
            // gbxSemiAnnual
            // 
            this.gbxSemiAnnual.Controls.Add(this.rdoSA3);
            this.gbxSemiAnnual.Controls.Add(this.rdoSA4);
            this.gbxSemiAnnual.Controls.Add(this.rdoSA5);
            this.gbxSemiAnnual.Controls.Add(this.rdoSA6);
            this.gbxSemiAnnual.Controls.Add(this.rdoSA2);
            this.gbxSemiAnnual.Controls.Add(this.rdoSA1);
            this.gbxSemiAnnual.Location = new System.Drawing.Point(306, 118);
            this.gbxSemiAnnual.Name = "gbxSemiAnnual";
            this.gbxSemiAnnual.Size = new System.Drawing.Size(194, 115);
            this.gbxSemiAnnual.TabIndex = 8;
            this.gbxSemiAnnual.TabStop = false;
            this.gbxSemiAnnual.Text = "Rotation";
            this.gbxSemiAnnual.Visible = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 327);
            this.Controls.Add(this.gbxQuarterly);
            this.Controls.Add(this.gbxSemiAnnual);
            this.Controls.Add(this.gbxAnnual);
            this.Controls.Add(this.gbxFrequency);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.CBHouseholdList);
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.Text = "Select Household";
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.gbxFrequency.ResumeLayout(false);
            this.gbxFrequency.PerformLayout();
            this.gbxAnnual.ResumeLayout(false);
            this.gbxAnnual.PerformLayout();
            this.gbxQuarterly.ResumeLayout(false);
            this.gbxQuarterly.PerformLayout();
            this.gbxSemiAnnual.ResumeLayout(false);
            this.gbxSemiAnnual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBHouseholdList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoAUM;
        private System.Windows.Forms.RadioButton rdoFee;
        private System.Windows.Forms.RadioButton rdoAUA;
        private System.Windows.Forms.RadioButton rdoAllType;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.GroupBox gbxFrequency;
        private System.Windows.Forms.RadioButton rdoAllFrequency;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoAnnual;
        private System.Windows.Forms.RadioButton rdoSemiAnnual;
        private System.Windows.Forms.RadioButton rdoQuarterly;
        private System.Windows.Forms.GroupBox gbxAnnual;
        private System.Windows.Forms.RadioButton rdoMonth12;
        private System.Windows.Forms.RadioButton rdoMonth11;
        private System.Windows.Forms.RadioButton rdoMonth10;
        private System.Windows.Forms.RadioButton rdoMonth9;
        private System.Windows.Forms.RadioButton rdoMonth8;
        private System.Windows.Forms.RadioButton rdoMonth7;
        private System.Windows.Forms.RadioButton rdoSA6;
        private System.Windows.Forms.RadioButton rdoSA5;
        private System.Windows.Forms.RadioButton rdoSA4;
        private System.Windows.Forms.RadioButton rdoQuarterly3;
        private System.Windows.Forms.RadioButton rdoQuarterly2;
        private System.Windows.Forms.RadioButton rdoQuarterly1;
        private System.Windows.Forms.RadioButton June;
        private System.Windows.Forms.RadioButton rdoMonth5;
        private System.Windows.Forms.RadioButton rdoMonth4;
        private System.Windows.Forms.RadioButton rdoMonth3;
        private System.Windows.Forms.RadioButton rdoMonth2;
        private System.Windows.Forms.RadioButton rdoMonth1;
        private System.Windows.Forms.RadioButton rdoSA1;
        private System.Windows.Forms.RadioButton rdoSA2;
        private System.Windows.Forms.RadioButton rdoSA3;
        private System.Windows.Forms.GroupBox gbxQuarterly;
        private System.Windows.Forms.GroupBox gbxSemiAnnual;
    }
}