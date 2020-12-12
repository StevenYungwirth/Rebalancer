namespace Rebalancer
{
    partial class FormHousehold
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
            this.components = new System.ComponentModel.Container();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.lblLV = new System.Windows.Forms.Label();
            this.lblLB = new System.Windows.Forms.Label();
            this.lblLG = new System.Windows.Forms.Label();
            this.lblMV = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.lblMG = new System.Windows.Forms.Label();
            this.lblSV = new System.Windows.Forms.Label();
            this.lblSB = new System.Windows.Forms.Label();
            this.lblSG = new System.Windows.Forms.Label();
            this.lblIntl = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.gbxSectorCurrent = new System.Windows.Forms.GroupBox();
            this.lblCurrentSectorOther = new System.Windows.Forms.Label();
            this.lblCurrentSpecialty = new System.Windows.Forms.Label();
            this.lblCurrentIntl = new System.Windows.Forms.Label();
            this.lblCurrentSG = new System.Windows.Forms.Label();
            this.lblCurrentSB = new System.Windows.Forms.Label();
            this.lblCurrentSV = new System.Windows.Forms.Label();
            this.lblCurrentMG = new System.Windows.Forms.Label();
            this.lblCurrentMB = new System.Windows.Forms.Label();
            this.lblCurrentMV = new System.Windows.Forms.Label();
            this.lblCurrentLG = new System.Windows.Forms.Label();
            this.lblCurrentLB = new System.Windows.Forms.Label();
            this.lblCurrentLV = new System.Windows.Forms.Label();
            this.gbxSectorTarget = new System.Windows.Forms.GroupBox();
            this.lblSectorTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudSectorOther = new System.Windows.Forms.NumericUpDown();
            this.lblTargetSectorOther = new System.Windows.Forms.Label();
            this.lblTargetLV = new System.Windows.Forms.Label();
            this.nudSpecialty = new System.Windows.Forms.NumericUpDown();
            this.lblTargetSpecialty = new System.Windows.Forms.Label();
            this.lblTargetLB = new System.Windows.Forms.Label();
            this.nudIntl = new System.Windows.Forms.NumericUpDown();
            this.lblTargetIntl = new System.Windows.Forms.Label();
            this.lblTargetLG = new System.Windows.Forms.Label();
            this.nudSG = new System.Windows.Forms.NumericUpDown();
            this.lblTargetSG = new System.Windows.Forms.Label();
            this.lblTargetMV = new System.Windows.Forms.Label();
            this.nudSB = new System.Windows.Forms.NumericUpDown();
            this.lblTargetSB = new System.Windows.Forms.Label();
            this.lblTargetMB = new System.Windows.Forms.Label();
            this.nudSV = new System.Windows.Forms.NumericUpDown();
            this.lblTargetSV = new System.Windows.Forms.Label();
            this.lblTargetMG = new System.Windows.Forms.Label();
            this.nudMG = new System.Windows.Forms.NumericUpDown();
            this.nudLV = new System.Windows.Forms.NumericUpDown();
            this.nudLB = new System.Windows.Forms.NumericUpDown();
            this.nudMB = new System.Windows.Forms.NumericUpDown();
            this.nudLG = new System.Windows.Forms.NumericUpDown();
            this.nudMV = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOtherSector = new System.Windows.Forms.Label();
            this.lblAllocationLabel = new System.Windows.Forms.Label();
            this.gbxSectorAction = new System.Windows.Forms.GroupBox();
            this.lblActionSectorOther = new System.Windows.Forms.Label();
            this.lblActionLV = new System.Windows.Forms.Label();
            this.lblActionSpecialty = new System.Windows.Forms.Label();
            this.lblActionLB = new System.Windows.Forms.Label();
            this.lblActionIntl = new System.Windows.Forms.Label();
            this.lblActionLG = new System.Windows.Forms.Label();
            this.lblActionSG = new System.Windows.Forms.Label();
            this.lblActionMV = new System.Windows.Forms.Label();
            this.lblActionSB = new System.Windows.Forms.Label();
            this.lblActionMB = new System.Windows.Forms.Label();
            this.lblActionSV = new System.Windows.Forms.Label();
            this.lblActionMG = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblFixed = new System.Windows.Forms.Label();
            this.lblEquity = new System.Windows.Forms.Label();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.gbxTotalCurrent = new System.Windows.Forms.GroupBox();
            this.lblCurrentTotalOther = new System.Windows.Forms.Label();
            this.lblCurrentCash = new System.Windows.Forms.Label();
            this.lblCurrentFixed = new System.Windows.Forms.Label();
            this.lblCurrentEquity = new System.Windows.Forms.Label();
            this.gbxTotalTarget = new System.Windows.Forms.GroupBox();
            this.lblTargetTotalOther = new System.Windows.Forms.Label();
            this.lblTargetCash = new System.Windows.Forms.Label();
            this.lblTargetFixed = new System.Windows.Forms.Label();
            this.lblTargetEquity = new System.Windows.Forms.Label();
            this.gbxTotalAction = new System.Windows.Forms.GroupBox();
            this.lblActionTotalOther = new System.Windows.Forms.Label();
            this.lblActionCash = new System.Windows.Forms.Label();
            this.lblActionFixed = new System.Windows.Forms.Label();
            this.lblActionEquity = new System.Windows.Forms.Label();
            this.lvwSecurities = new System.Windows.Forms.ListView();
            this.lvwAccounts = new System.Windows.Forms.ListView();
            this.lvwAssetClasses = new System.Windows.Forms.ListView();
            this.lblHouseholdValue = new System.Windows.Forms.Label();
            this.lblHouseholdValueLabel = new System.Windows.Forms.Label();
            this.btnAdjustFee = new System.Windows.Forms.Button();
            this.ttpDefaults = new System.Windows.Forms.ToolTip(this.components);
            this.lblMoneyInOut = new System.Windows.Forms.Label();
            this.txtMoneyInOut = new System.Windows.Forms.TextBox();
            this.lblAdjustedHouseholdValue = new System.Windows.Forms.Label();
            this.lblEquityTarget = new System.Windows.Forms.Label();
            this.nudEquityTarget = new System.Windows.Forms.NumericUpDown();
            this.lblAdjustedHouseholdValueLabel = new System.Windows.Forms.Label();
            this.lblFeeRate = new System.Windows.Forms.Label();
            this.lblFeeAmount = new System.Windows.Forms.Label();
            this.lblFeeRateLabel = new System.Windows.Forms.Label();
            this.lblFeeAmountLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRecs = new System.Windows.Forms.Button();
            this.btnSelectNew = new System.Windows.Forms.Button();
            this.gbxSectorCurrent.SuspendLayout();
            this.gbxSectorTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSectorOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMV)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxSectorAction.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxTotalCurrent.SuspendLayout();
            this.gbxTotalTarget.SuspendLayout();
            this.gbxTotalAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquityTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllocation
            // 
            this.lblAllocation.AutoSize = true;
            this.lblAllocation.Location = new System.Drawing.Point(376, 36);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(53, 13);
            this.lblAllocation.TabIndex = 8;
            this.lblAllocation.Text = "Allocation";
            // 
            // lblLV
            // 
            this.lblLV.AutoSize = true;
            this.lblLV.Location = new System.Drawing.Point(18, 19);
            this.lblLV.Name = "lblLV";
            this.lblLV.Size = new System.Drawing.Size(64, 13);
            this.lblLV.TabIndex = 12;
            this.lblLV.Text = "Large Value";
            // 
            // lblLB
            // 
            this.lblLB.AutoSize = true;
            this.lblLB.Location = new System.Drawing.Point(18, 42);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(64, 13);
            this.lblLB.TabIndex = 13;
            this.lblLB.Text = "Large Blend";
            // 
            // lblLG
            // 
            this.lblLG.AutoSize = true;
            this.lblLG.Location = new System.Drawing.Point(18, 65);
            this.lblLG.Name = "lblLG";
            this.lblLG.Size = new System.Drawing.Size(71, 13);
            this.lblLG.TabIndex = 14;
            this.lblLG.Text = "Large Growth";
            // 
            // lblMV
            // 
            this.lblMV.AutoSize = true;
            this.lblMV.Location = new System.Drawing.Point(18, 88);
            this.lblMV.Name = "lblMV";
            this.lblMV.Size = new System.Drawing.Size(54, 13);
            this.lblMV.TabIndex = 15;
            this.lblMV.Text = "Mid Value";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(18, 111);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(54, 13);
            this.lblMB.TabIndex = 16;
            this.lblMB.Text = "Mid Blend";
            // 
            // lblMG
            // 
            this.lblMG.AutoSize = true;
            this.lblMG.Location = new System.Drawing.Point(18, 134);
            this.lblMG.Name = "lblMG";
            this.lblMG.Size = new System.Drawing.Size(61, 13);
            this.lblMG.TabIndex = 17;
            this.lblMG.Text = "Mid Growth";
            // 
            // lblSV
            // 
            this.lblSV.AutoSize = true;
            this.lblSV.Location = new System.Drawing.Point(18, 157);
            this.lblSV.Name = "lblSV";
            this.lblSV.Size = new System.Drawing.Size(62, 13);
            this.lblSV.TabIndex = 18;
            this.lblSV.Text = "Small Value";
            // 
            // lblSB
            // 
            this.lblSB.AutoSize = true;
            this.lblSB.Location = new System.Drawing.Point(18, 180);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(62, 13);
            this.lblSB.TabIndex = 19;
            this.lblSB.Text = "Small Blend";
            // 
            // lblSG
            // 
            this.lblSG.AutoSize = true;
            this.lblSG.Location = new System.Drawing.Point(18, 203);
            this.lblSG.Name = "lblSG";
            this.lblSG.Size = new System.Drawing.Size(69, 13);
            this.lblSG.TabIndex = 20;
            this.lblSG.Text = "Small Growth";
            // 
            // lblIntl
            // 
            this.lblIntl.AutoSize = true;
            this.lblIntl.Location = new System.Drawing.Point(18, 226);
            this.lblIntl.Name = "lblIntl";
            this.lblIntl.Size = new System.Drawing.Size(65, 13);
            this.lblIntl.TabIndex = 21;
            this.lblIntl.Text = "International";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(18, 249);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(50, 13);
            this.lblSpec.TabIndex = 22;
            this.lblSpec.Text = "Specialty";
            // 
            // gbxSectorCurrent
            // 
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentSectorOther);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentSpecialty);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentIntl);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentSG);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentSB);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentSV);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentMG);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentMB);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentMV);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentLG);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentLB);
            this.gbxSectorCurrent.Controls.Add(this.lblCurrentLV);
            this.gbxSectorCurrent.Location = new System.Drawing.Point(635, 265);
            this.gbxSectorCurrent.Name = "gbxSectorCurrent";
            this.gbxSectorCurrent.Size = new System.Drawing.Size(99, 301);
            this.gbxSectorCurrent.TabIndex = 23;
            this.gbxSectorCurrent.TabStop = false;
            this.gbxSectorCurrent.Text = "Current";
            // 
            // lblCurrentSectorOther
            // 
            this.lblCurrentSectorOther.Location = new System.Drawing.Point(8, 270);
            this.lblCurrentSectorOther.Name = "lblCurrentSectorOther";
            this.lblCurrentSectorOther.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentSectorOther.TabIndex = 11;
            this.lblCurrentSectorOther.Text = "$0.00";
            this.lblCurrentSectorOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentSpecialty
            // 
            this.lblCurrentSpecialty.Location = new System.Drawing.Point(8, 249);
            this.lblCurrentSpecialty.Name = "lblCurrentSpecialty";
            this.lblCurrentSpecialty.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentSpecialty.TabIndex = 10;
            this.lblCurrentSpecialty.Text = "$0.00";
            this.lblCurrentSpecialty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentIntl
            // 
            this.lblCurrentIntl.Location = new System.Drawing.Point(8, 226);
            this.lblCurrentIntl.Name = "lblCurrentIntl";
            this.lblCurrentIntl.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentIntl.TabIndex = 9;
            this.lblCurrentIntl.Text = "$0.00";
            this.lblCurrentIntl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentSG
            // 
            this.lblCurrentSG.Location = new System.Drawing.Point(8, 203);
            this.lblCurrentSG.Name = "lblCurrentSG";
            this.lblCurrentSG.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentSG.TabIndex = 8;
            this.lblCurrentSG.Text = "$0.00";
            this.lblCurrentSG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentSB
            // 
            this.lblCurrentSB.Location = new System.Drawing.Point(8, 180);
            this.lblCurrentSB.Name = "lblCurrentSB";
            this.lblCurrentSB.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentSB.TabIndex = 7;
            this.lblCurrentSB.Text = "$0.00";
            this.lblCurrentSB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentSV
            // 
            this.lblCurrentSV.Location = new System.Drawing.Point(8, 157);
            this.lblCurrentSV.Name = "lblCurrentSV";
            this.lblCurrentSV.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentSV.TabIndex = 6;
            this.lblCurrentSV.Text = "$0.00";
            this.lblCurrentSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentMG
            // 
            this.lblCurrentMG.Location = new System.Drawing.Point(8, 134);
            this.lblCurrentMG.Name = "lblCurrentMG";
            this.lblCurrentMG.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentMG.TabIndex = 5;
            this.lblCurrentMG.Text = "$0.00";
            this.lblCurrentMG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentMB
            // 
            this.lblCurrentMB.Location = new System.Drawing.Point(8, 111);
            this.lblCurrentMB.Name = "lblCurrentMB";
            this.lblCurrentMB.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentMB.TabIndex = 4;
            this.lblCurrentMB.Text = "$0.00";
            this.lblCurrentMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentMV
            // 
            this.lblCurrentMV.Location = new System.Drawing.Point(8, 88);
            this.lblCurrentMV.Name = "lblCurrentMV";
            this.lblCurrentMV.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentMV.TabIndex = 3;
            this.lblCurrentMV.Text = "$0.00";
            this.lblCurrentMV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentLG
            // 
            this.lblCurrentLG.Location = new System.Drawing.Point(8, 65);
            this.lblCurrentLG.Name = "lblCurrentLG";
            this.lblCurrentLG.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentLG.TabIndex = 2;
            this.lblCurrentLG.Text = "$0.00";
            this.lblCurrentLG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentLB
            // 
            this.lblCurrentLB.Location = new System.Drawing.Point(8, 42);
            this.lblCurrentLB.Name = "lblCurrentLB";
            this.lblCurrentLB.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentLB.TabIndex = 1;
            this.lblCurrentLB.Text = "$0.00";
            this.lblCurrentLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentLV
            // 
            this.lblCurrentLV.Location = new System.Drawing.Point(8, 19);
            this.lblCurrentLV.Name = "lblCurrentLV";
            this.lblCurrentLV.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentLV.TabIndex = 0;
            this.lblCurrentLV.Text = "$0.00";
            this.lblCurrentLV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxSectorTarget
            // 
            this.gbxSectorTarget.Controls.Add(this.lblSectorTotal);
            this.gbxSectorTarget.Controls.Add(this.lblTotal);
            this.gbxSectorTarget.Controls.Add(this.nudSectorOther);
            this.gbxSectorTarget.Controls.Add(this.lblTargetSectorOther);
            this.gbxSectorTarget.Controls.Add(this.lblTargetLV);
            this.gbxSectorTarget.Controls.Add(this.nudSpecialty);
            this.gbxSectorTarget.Controls.Add(this.lblTargetSpecialty);
            this.gbxSectorTarget.Controls.Add(this.lblTargetLB);
            this.gbxSectorTarget.Controls.Add(this.nudIntl);
            this.gbxSectorTarget.Controls.Add(this.lblTargetIntl);
            this.gbxSectorTarget.Controls.Add(this.lblTargetLG);
            this.gbxSectorTarget.Controls.Add(this.nudSG);
            this.gbxSectorTarget.Controls.Add(this.lblTargetSG);
            this.gbxSectorTarget.Controls.Add(this.lblTargetMV);
            this.gbxSectorTarget.Controls.Add(this.nudSB);
            this.gbxSectorTarget.Controls.Add(this.lblTargetSB);
            this.gbxSectorTarget.Controls.Add(this.lblTargetMB);
            this.gbxSectorTarget.Controls.Add(this.nudSV);
            this.gbxSectorTarget.Controls.Add(this.lblTargetSV);
            this.gbxSectorTarget.Controls.Add(this.lblTargetMG);
            this.gbxSectorTarget.Controls.Add(this.nudMG);
            this.gbxSectorTarget.Controls.Add(this.nudLV);
            this.gbxSectorTarget.Controls.Add(this.nudLB);
            this.gbxSectorTarget.Controls.Add(this.nudMB);
            this.gbxSectorTarget.Controls.Add(this.nudLG);
            this.gbxSectorTarget.Controls.Add(this.nudMV);
            this.gbxSectorTarget.Location = new System.Drawing.Point(740, 264);
            this.gbxSectorTarget.Name = "gbxSectorTarget";
            this.gbxSectorTarget.Size = new System.Drawing.Size(165, 326);
            this.gbxSectorTarget.TabIndex = 24;
            this.gbxSectorTarget.TabStop = false;
            this.gbxSectorTarget.Text = "Target";
            // 
            // lblSectorTotal
            // 
            this.lblSectorTotal.AutoSize = true;
            this.lblSectorTotal.Location = new System.Drawing.Point(99, 302);
            this.lblSectorTotal.Name = "lblSectorTotal";
            this.lblSectorTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSectorTotal.TabIndex = 36;
            this.lblSectorTotal.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(58, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total:";
            // 
            // nudSectorOther
            // 
            this.nudSectorOther.Location = new System.Drawing.Point(102, 270);
            this.nudSectorOther.Name = "nudSectorOther";
            this.nudSectorOther.Size = new System.Drawing.Size(50, 20);
            this.nudSectorOther.TabIndex = 35;
            this.nudSectorOther.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // lblTargetSectorOther
            // 
            this.lblTargetSectorOther.Location = new System.Drawing.Point(13, 272);
            this.lblTargetSectorOther.Name = "lblTargetSectorOther";
            this.lblTargetSectorOther.Size = new System.Drawing.Size(83, 13);
            this.lblTargetSectorOther.TabIndex = 23;
            this.lblTargetSectorOther.Text = "$0.00";
            this.lblTargetSectorOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetLV
            // 
            this.lblTargetLV.Location = new System.Drawing.Point(13, 21);
            this.lblTargetLV.Name = "lblTargetLV";
            this.lblTargetLV.Size = new System.Drawing.Size(83, 13);
            this.lblTargetLV.TabIndex = 12;
            this.lblTargetLV.Text = "$0.00";
            this.lblTargetLV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSpecialty
            // 
            this.nudSpecialty.Location = new System.Drawing.Point(102, 249);
            this.nudSpecialty.Name = "nudSpecialty";
            this.nudSpecialty.Size = new System.Drawing.Size(50, 20);
            this.nudSpecialty.TabIndex = 34;
            this.nudSpecialty.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // lblTargetSpecialty
            // 
            this.lblTargetSpecialty.Location = new System.Drawing.Point(13, 251);
            this.lblTargetSpecialty.Name = "lblTargetSpecialty";
            this.lblTargetSpecialty.Size = new System.Drawing.Size(83, 13);
            this.lblTargetSpecialty.TabIndex = 22;
            this.lblTargetSpecialty.Text = "$0.00";
            this.lblTargetSpecialty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetLB
            // 
            this.lblTargetLB.Location = new System.Drawing.Point(13, 44);
            this.lblTargetLB.Name = "lblTargetLB";
            this.lblTargetLB.Size = new System.Drawing.Size(83, 13);
            this.lblTargetLB.TabIndex = 13;
            this.lblTargetLB.Text = "$0.00";
            this.lblTargetLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudIntl
            // 
            this.nudIntl.Location = new System.Drawing.Point(102, 226);
            this.nudIntl.Name = "nudIntl";
            this.nudIntl.Size = new System.Drawing.Size(50, 20);
            this.nudIntl.TabIndex = 33;
            this.nudIntl.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // lblTargetIntl
            // 
            this.lblTargetIntl.Location = new System.Drawing.Point(13, 228);
            this.lblTargetIntl.Name = "lblTargetIntl";
            this.lblTargetIntl.Size = new System.Drawing.Size(83, 13);
            this.lblTargetIntl.TabIndex = 21;
            this.lblTargetIntl.Text = "$0.00";
            this.lblTargetIntl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetLG
            // 
            this.lblTargetLG.Location = new System.Drawing.Point(13, 67);
            this.lblTargetLG.Name = "lblTargetLG";
            this.lblTargetLG.Size = new System.Drawing.Size(83, 13);
            this.lblTargetLG.TabIndex = 14;
            this.lblTargetLG.Text = "$0.00";
            this.lblTargetLG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSG
            // 
            this.nudSG.Location = new System.Drawing.Point(102, 203);
            this.nudSG.Name = "nudSG";
            this.nudSG.Size = new System.Drawing.Size(50, 20);
            this.nudSG.TabIndex = 32;
            this.nudSG.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // lblTargetSG
            // 
            this.lblTargetSG.Location = new System.Drawing.Point(13, 205);
            this.lblTargetSG.Name = "lblTargetSG";
            this.lblTargetSG.Size = new System.Drawing.Size(83, 13);
            this.lblTargetSG.TabIndex = 20;
            this.lblTargetSG.Text = "$0.00";
            this.lblTargetSG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetMV
            // 
            this.lblTargetMV.Location = new System.Drawing.Point(13, 90);
            this.lblTargetMV.Name = "lblTargetMV";
            this.lblTargetMV.Size = new System.Drawing.Size(83, 13);
            this.lblTargetMV.TabIndex = 15;
            this.lblTargetMV.Text = "$0.00";
            this.lblTargetMV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSB
            // 
            this.nudSB.Location = new System.Drawing.Point(102, 180);
            this.nudSB.Name = "nudSB";
            this.nudSB.Size = new System.Drawing.Size(50, 20);
            this.nudSB.TabIndex = 31;
            this.nudSB.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // lblTargetSB
            // 
            this.lblTargetSB.Location = new System.Drawing.Point(13, 182);
            this.lblTargetSB.Name = "lblTargetSB";
            this.lblTargetSB.Size = new System.Drawing.Size(83, 13);
            this.lblTargetSB.TabIndex = 19;
            this.lblTargetSB.Text = "$0.00";
            this.lblTargetSB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetMB
            // 
            this.lblTargetMB.Location = new System.Drawing.Point(13, 113);
            this.lblTargetMB.Name = "lblTargetMB";
            this.lblTargetMB.Size = new System.Drawing.Size(83, 13);
            this.lblTargetMB.TabIndex = 16;
            this.lblTargetMB.Text = "$0.00";
            this.lblTargetMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSV
            // 
            this.nudSV.Location = new System.Drawing.Point(102, 158);
            this.nudSV.Name = "nudSV";
            this.nudSV.Size = new System.Drawing.Size(50, 20);
            this.nudSV.TabIndex = 30;
            this.nudSV.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // lblTargetSV
            // 
            this.lblTargetSV.Location = new System.Drawing.Point(13, 159);
            this.lblTargetSV.Name = "lblTargetSV";
            this.lblTargetSV.Size = new System.Drawing.Size(83, 13);
            this.lblTargetSV.TabIndex = 18;
            this.lblTargetSV.Text = "$0.00";
            this.lblTargetSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetMG
            // 
            this.lblTargetMG.Location = new System.Drawing.Point(13, 136);
            this.lblTargetMG.Name = "lblTargetMG";
            this.lblTargetMG.Size = new System.Drawing.Size(83, 13);
            this.lblTargetMG.TabIndex = 17;
            this.lblTargetMG.Text = "$0.00";
            this.lblTargetMG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMG
            // 
            this.nudMG.Location = new System.Drawing.Point(102, 135);
            this.nudMG.Name = "nudMG";
            this.nudMG.Size = new System.Drawing.Size(50, 20);
            this.nudMG.TabIndex = 29;
            this.nudMG.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // nudLV
            // 
            this.nudLV.Location = new System.Drawing.Point(102, 18);
            this.nudLV.Name = "nudLV";
            this.nudLV.Size = new System.Drawing.Size(50, 20);
            this.nudLV.TabIndex = 24;
            this.nudLV.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // nudLB
            // 
            this.nudLB.Location = new System.Drawing.Point(102, 43);
            this.nudLB.Name = "nudLB";
            this.nudLB.Size = new System.Drawing.Size(50, 20);
            this.nudLB.TabIndex = 25;
            this.nudLB.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // nudMB
            // 
            this.nudMB.Location = new System.Drawing.Point(102, 112);
            this.nudMB.Name = "nudMB";
            this.nudMB.Size = new System.Drawing.Size(50, 20);
            this.nudMB.TabIndex = 28;
            this.nudMB.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // nudLG
            // 
            this.nudLG.Location = new System.Drawing.Point(102, 66);
            this.nudLG.Name = "nudLG";
            this.nudLG.Size = new System.Drawing.Size(50, 20);
            this.nudLG.TabIndex = 26;
            this.nudLG.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // nudMV
            // 
            this.nudMV.Location = new System.Drawing.Point(102, 89);
            this.nudMV.Name = "nudMV";
            this.nudMV.Size = new System.Drawing.Size(50, 20);
            this.nudMV.TabIndex = 27;
            this.nudMV.ValueChanged += new System.EventHandler(this.Spinner_Change);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOtherSector);
            this.panel1.Controls.Add(this.lblLV);
            this.panel1.Controls.Add(this.lblLB);
            this.panel1.Controls.Add(this.lblLG);
            this.panel1.Controls.Add(this.lblSpec);
            this.panel1.Controls.Add(this.lblMV);
            this.panel1.Controls.Add(this.lblIntl);
            this.panel1.Controls.Add(this.lblMB);
            this.panel1.Controls.Add(this.lblSG);
            this.panel1.Controls.Add(this.lblMG);
            this.panel1.Controls.Add(this.lblSB);
            this.panel1.Controls.Add(this.lblSV);
            this.panel1.Location = new System.Drawing.Point(537, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 301);
            this.panel1.TabIndex = 25;
            // 
            // lblOtherSector
            // 
            this.lblOtherSector.AutoSize = true;
            this.lblOtherSector.Location = new System.Drawing.Point(19, 270);
            this.lblOtherSector.Name = "lblOtherSector";
            this.lblOtherSector.Size = new System.Drawing.Size(33, 13);
            this.lblOtherSector.TabIndex = 23;
            this.lblOtherSector.Text = "Other";
            // 
            // lblAllocationLabel
            // 
            this.lblAllocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAllocationLabel.Location = new System.Drawing.Point(435, 30);
            this.lblAllocationLabel.Name = "lblAllocationLabel";
            this.lblAllocationLabel.Size = new System.Drawing.Size(118, 25);
            this.lblAllocationLabel.TabIndex = 26;
            this.lblAllocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxSectorAction
            // 
            this.gbxSectorAction.Controls.Add(this.lblActionSectorOther);
            this.gbxSectorAction.Controls.Add(this.lblActionLV);
            this.gbxSectorAction.Controls.Add(this.lblActionSpecialty);
            this.gbxSectorAction.Controls.Add(this.lblActionLB);
            this.gbxSectorAction.Controls.Add(this.lblActionIntl);
            this.gbxSectorAction.Controls.Add(this.lblActionLG);
            this.gbxSectorAction.Controls.Add(this.lblActionSG);
            this.gbxSectorAction.Controls.Add(this.lblActionMV);
            this.gbxSectorAction.Controls.Add(this.lblActionSB);
            this.gbxSectorAction.Controls.Add(this.lblActionMB);
            this.gbxSectorAction.Controls.Add(this.lblActionSV);
            this.gbxSectorAction.Controls.Add(this.lblActionMG);
            this.gbxSectorAction.Location = new System.Drawing.Point(911, 266);
            this.gbxSectorAction.Name = "gbxSectorAction";
            this.gbxSectorAction.Size = new System.Drawing.Size(117, 300);
            this.gbxSectorAction.TabIndex = 28;
            this.gbxSectorAction.TabStop = false;
            this.gbxSectorAction.Text = "Action";
            // 
            // lblActionSectorOther
            // 
            this.lblActionSectorOther.Location = new System.Drawing.Point(17, 269);
            this.lblActionSectorOther.Name = "lblActionSectorOther";
            this.lblActionSectorOther.Size = new System.Drawing.Size(83, 13);
            this.lblActionSectorOther.TabIndex = 35;
            this.lblActionSectorOther.Text = "$0.00";
            this.lblActionSectorOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionLV
            // 
            this.lblActionLV.Location = new System.Drawing.Point(17, 18);
            this.lblActionLV.Name = "lblActionLV";
            this.lblActionLV.Size = new System.Drawing.Size(83, 13);
            this.lblActionLV.TabIndex = 24;
            this.lblActionLV.Text = "$0.00";
            this.lblActionLV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionSpecialty
            // 
            this.lblActionSpecialty.Location = new System.Drawing.Point(17, 248);
            this.lblActionSpecialty.Name = "lblActionSpecialty";
            this.lblActionSpecialty.Size = new System.Drawing.Size(83, 13);
            this.lblActionSpecialty.TabIndex = 34;
            this.lblActionSpecialty.Text = "$0.00";
            this.lblActionSpecialty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionLB
            // 
            this.lblActionLB.Location = new System.Drawing.Point(17, 41);
            this.lblActionLB.Name = "lblActionLB";
            this.lblActionLB.Size = new System.Drawing.Size(83, 13);
            this.lblActionLB.TabIndex = 25;
            this.lblActionLB.Text = "$0.00";
            this.lblActionLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionIntl
            // 
            this.lblActionIntl.Location = new System.Drawing.Point(17, 225);
            this.lblActionIntl.Name = "lblActionIntl";
            this.lblActionIntl.Size = new System.Drawing.Size(83, 13);
            this.lblActionIntl.TabIndex = 33;
            this.lblActionIntl.Text = "$0.00";
            this.lblActionIntl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionLG
            // 
            this.lblActionLG.Location = new System.Drawing.Point(17, 64);
            this.lblActionLG.Name = "lblActionLG";
            this.lblActionLG.Size = new System.Drawing.Size(83, 13);
            this.lblActionLG.TabIndex = 26;
            this.lblActionLG.Text = "$0.00";
            this.lblActionLG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionSG
            // 
            this.lblActionSG.Location = new System.Drawing.Point(17, 202);
            this.lblActionSG.Name = "lblActionSG";
            this.lblActionSG.Size = new System.Drawing.Size(83, 13);
            this.lblActionSG.TabIndex = 32;
            this.lblActionSG.Text = "$0.00";
            this.lblActionSG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionMV
            // 
            this.lblActionMV.Location = new System.Drawing.Point(17, 87);
            this.lblActionMV.Name = "lblActionMV";
            this.lblActionMV.Size = new System.Drawing.Size(83, 13);
            this.lblActionMV.TabIndex = 27;
            this.lblActionMV.Text = "$0.00";
            this.lblActionMV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionSB
            // 
            this.lblActionSB.Location = new System.Drawing.Point(17, 179);
            this.lblActionSB.Name = "lblActionSB";
            this.lblActionSB.Size = new System.Drawing.Size(83, 13);
            this.lblActionSB.TabIndex = 31;
            this.lblActionSB.Text = "$0.00";
            this.lblActionSB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionMB
            // 
            this.lblActionMB.Location = new System.Drawing.Point(17, 110);
            this.lblActionMB.Name = "lblActionMB";
            this.lblActionMB.Size = new System.Drawing.Size(83, 13);
            this.lblActionMB.TabIndex = 28;
            this.lblActionMB.Text = "$0.00";
            this.lblActionMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionSV
            // 
            this.lblActionSV.Location = new System.Drawing.Point(17, 156);
            this.lblActionSV.Name = "lblActionSV";
            this.lblActionSV.Size = new System.Drawing.Size(83, 13);
            this.lblActionSV.TabIndex = 30;
            this.lblActionSV.Text = "$0.00";
            this.lblActionSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionMG
            // 
            this.lblActionMG.Location = new System.Drawing.Point(17, 133);
            this.lblActionMG.Name = "lblActionMG";
            this.lblActionMG.Size = new System.Drawing.Size(83, 13);
            this.lblActionMG.TabIndex = 29;
            this.lblActionMG.Text = "$0.00";
            this.lblActionMG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOther);
            this.panel2.Controls.Add(this.lblCash);
            this.panel2.Controls.Add(this.lblFixed);
            this.panel2.Controls.Add(this.lblEquity);
            this.panel2.Location = new System.Drawing.Point(535, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 108);
            this.panel2.TabIndex = 29;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(19, 83);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(33, 13);
            this.lblOther.TabIndex = 3;
            this.lblOther.Text = "Other";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(19, 61);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(31, 13);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "Cash";
            // 
            // lblFixed
            // 
            this.lblFixed.AutoSize = true;
            this.lblFixed.Location = new System.Drawing.Point(19, 39);
            this.lblFixed.Name = "lblFixed";
            this.lblFixed.Size = new System.Drawing.Size(70, 13);
            this.lblFixed.TabIndex = 1;
            this.lblFixed.Text = "Fixed Income";
            // 
            // lblEquity
            // 
            this.lblEquity.AutoSize = true;
            this.lblEquity.Location = new System.Drawing.Point(19, 17);
            this.lblEquity.Name = "lblEquity";
            this.lblEquity.Size = new System.Drawing.Size(36, 13);
            this.lblEquity.TabIndex = 0;
            this.lblEquity.Text = "Equity";
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.Enabled = false;
            this.btnResetDefaults.Location = new System.Drawing.Point(396, 604);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(109, 35);
            this.btnResetDefaults.TabIndex = 30;
            this.btnResetDefaults.Text = "Reset Settings";
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefault_Click);
            // 
            // gbxTotalCurrent
            // 
            this.gbxTotalCurrent.Controls.Add(this.lblCurrentTotalOther);
            this.gbxTotalCurrent.Controls.Add(this.lblCurrentCash);
            this.gbxTotalCurrent.Controls.Add(this.lblCurrentFixed);
            this.gbxTotalCurrent.Controls.Add(this.lblCurrentEquity);
            this.gbxTotalCurrent.Location = new System.Drawing.Point(635, 150);
            this.gbxTotalCurrent.Name = "gbxTotalCurrent";
            this.gbxTotalCurrent.Size = new System.Drawing.Size(99, 108);
            this.gbxTotalCurrent.TabIndex = 31;
            this.gbxTotalCurrent.TabStop = false;
            this.gbxTotalCurrent.Text = "Current";
            // 
            // lblCurrentTotalOther
            // 
            this.lblCurrentTotalOther.Location = new System.Drawing.Point(8, 83);
            this.lblCurrentTotalOther.Name = "lblCurrentTotalOther";
            this.lblCurrentTotalOther.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentTotalOther.TabIndex = 3;
            this.lblCurrentTotalOther.Text = "$0.00";
            this.lblCurrentTotalOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentCash
            // 
            this.lblCurrentCash.Location = new System.Drawing.Point(8, 61);
            this.lblCurrentCash.Name = "lblCurrentCash";
            this.lblCurrentCash.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentCash.TabIndex = 2;
            this.lblCurrentCash.Text = "$0.00";
            this.lblCurrentCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentFixed
            // 
            this.lblCurrentFixed.Location = new System.Drawing.Point(8, 39);
            this.lblCurrentFixed.Name = "lblCurrentFixed";
            this.lblCurrentFixed.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentFixed.TabIndex = 1;
            this.lblCurrentFixed.Text = "$0.00";
            this.lblCurrentFixed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentEquity
            // 
            this.lblCurrentEquity.Location = new System.Drawing.Point(8, 17);
            this.lblCurrentEquity.Name = "lblCurrentEquity";
            this.lblCurrentEquity.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentEquity.TabIndex = 0;
            this.lblCurrentEquity.Text = "$0.00";
            this.lblCurrentEquity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxTotalTarget
            // 
            this.gbxTotalTarget.Controls.Add(this.lblTargetTotalOther);
            this.gbxTotalTarget.Controls.Add(this.lblTargetCash);
            this.gbxTotalTarget.Controls.Add(this.lblTargetFixed);
            this.gbxTotalTarget.Controls.Add(this.lblTargetEquity);
            this.gbxTotalTarget.Location = new System.Drawing.Point(740, 150);
            this.gbxTotalTarget.Name = "gbxTotalTarget";
            this.gbxTotalTarget.Size = new System.Drawing.Size(165, 106);
            this.gbxTotalTarget.TabIndex = 32;
            this.gbxTotalTarget.TabStop = false;
            this.gbxTotalTarget.Text = "Target";
            // 
            // lblTargetTotalOther
            // 
            this.lblTargetTotalOther.Location = new System.Drawing.Point(13, 83);
            this.lblTargetTotalOther.Name = "lblTargetTotalOther";
            this.lblTargetTotalOther.Size = new System.Drawing.Size(83, 13);
            this.lblTargetTotalOther.TabIndex = 7;
            this.lblTargetTotalOther.Text = "$0.00";
            this.lblTargetTotalOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetCash
            // 
            this.lblTargetCash.Location = new System.Drawing.Point(13, 61);
            this.lblTargetCash.Name = "lblTargetCash";
            this.lblTargetCash.Size = new System.Drawing.Size(83, 13);
            this.lblTargetCash.TabIndex = 6;
            this.lblTargetCash.Text = "$0.00";
            this.lblTargetCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetFixed
            // 
            this.lblTargetFixed.Location = new System.Drawing.Point(13, 39);
            this.lblTargetFixed.Name = "lblTargetFixed";
            this.lblTargetFixed.Size = new System.Drawing.Size(83, 13);
            this.lblTargetFixed.TabIndex = 5;
            this.lblTargetFixed.Text = "$0.00";
            this.lblTargetFixed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTargetEquity
            // 
            this.lblTargetEquity.Location = new System.Drawing.Point(13, 17);
            this.lblTargetEquity.Name = "lblTargetEquity";
            this.lblTargetEquity.Size = new System.Drawing.Size(83, 13);
            this.lblTargetEquity.TabIndex = 4;
            this.lblTargetEquity.Text = "$0.00";
            this.lblTargetEquity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxTotalAction
            // 
            this.gbxTotalAction.Controls.Add(this.lblActionTotalOther);
            this.gbxTotalAction.Controls.Add(this.lblActionCash);
            this.gbxTotalAction.Controls.Add(this.lblActionFixed);
            this.gbxTotalAction.Controls.Add(this.lblActionEquity);
            this.gbxTotalAction.Location = new System.Drawing.Point(911, 150);
            this.gbxTotalAction.Name = "gbxTotalAction";
            this.gbxTotalAction.Size = new System.Drawing.Size(117, 106);
            this.gbxTotalAction.TabIndex = 33;
            this.gbxTotalAction.TabStop = false;
            this.gbxTotalAction.Text = "Action";
            // 
            // lblActionTotalOther
            // 
            this.lblActionTotalOther.Location = new System.Drawing.Point(17, 83);
            this.lblActionTotalOther.Name = "lblActionTotalOther";
            this.lblActionTotalOther.Size = new System.Drawing.Size(83, 13);
            this.lblActionTotalOther.TabIndex = 11;
            this.lblActionTotalOther.Text = "$0.00";
            this.lblActionTotalOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionCash
            // 
            this.lblActionCash.Location = new System.Drawing.Point(17, 61);
            this.lblActionCash.Name = "lblActionCash";
            this.lblActionCash.Size = new System.Drawing.Size(83, 13);
            this.lblActionCash.TabIndex = 10;
            this.lblActionCash.Text = "$0.00";
            this.lblActionCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionFixed
            // 
            this.lblActionFixed.Location = new System.Drawing.Point(17, 39);
            this.lblActionFixed.Name = "lblActionFixed";
            this.lblActionFixed.Size = new System.Drawing.Size(83, 13);
            this.lblActionFixed.TabIndex = 9;
            this.lblActionFixed.Text = "$0.00";
            this.lblActionFixed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActionEquity
            // 
            this.lblActionEquity.Location = new System.Drawing.Point(17, 17);
            this.lblActionEquity.Name = "lblActionEquity";
            this.lblActionEquity.Size = new System.Drawing.Size(83, 13);
            this.lblActionEquity.TabIndex = 8;
            this.lblActionEquity.Text = "$0.00";
            this.lblActionEquity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwSecurities
            // 
            this.lvwSecurities.FullRowSelect = true;
            this.lvwSecurities.HideSelection = false;
            this.lvwSecurities.Location = new System.Drawing.Point(17, 308);
            this.lvwSecurities.Name = "lvwSecurities";
            this.lvwSecurities.Size = new System.Drawing.Size(514, 258);
            this.lvwSecurities.TabIndex = 34;
            this.lvwSecurities.UseCompatibleStateImageBehavior = false;
            this.lvwSecurities.View = System.Windows.Forms.View.Details;
            this.lvwSecurities.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwSecurities_ColumnClick);
            // 
            // lvwAccounts
            // 
            this.lvwAccounts.HideSelection = false;
            this.lvwAccounts.Location = new System.Drawing.Point(17, 150);
            this.lvwAccounts.MultiSelect = false;
            this.lvwAccounts.Name = "lvwAccounts";
            this.lvwAccounts.Size = new System.Drawing.Size(198, 151);
            this.lvwAccounts.TabIndex = 35;
            this.lvwAccounts.UseCompatibleStateImageBehavior = false;
            this.lvwAccounts.SelectedIndexChanged += new System.EventHandler(this.lvwAccounts_SelectedIndexChanged);
            // 
            // lvwAssetClasses
            // 
            this.lvwAssetClasses.HideSelection = false;
            this.lvwAssetClasses.Location = new System.Drawing.Point(220, 149);
            this.lvwAssetClasses.MultiSelect = false;
            this.lvwAssetClasses.Name = "lvwAssetClasses";
            this.lvwAssetClasses.Size = new System.Drawing.Size(308, 152);
            this.lvwAssetClasses.TabIndex = 36;
            this.lvwAssetClasses.UseCompatibleStateImageBehavior = false;
            this.lvwAssetClasses.SelectedIndexChanged += new System.EventHandler(this.lvwAssetClasses_SelectedIndexChanged);
            // 
            // lblHouseholdValue
            // 
            this.lblHouseholdValue.AutoSize = true;
            this.lblHouseholdValue.Location = new System.Drawing.Point(28, 36);
            this.lblHouseholdValue.Name = "lblHouseholdValue";
            this.lblHouseholdValue.Size = new System.Drawing.Size(115, 13);
            this.lblHouseholdValue.TabIndex = 37;
            this.lblHouseholdValue.Text = "Total Household Value";
            // 
            // lblHouseholdValueLabel
            // 
            this.lblHouseholdValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHouseholdValueLabel.Location = new System.Drawing.Point(159, 30);
            this.lblHouseholdValueLabel.Name = "lblHouseholdValueLabel";
            this.lblHouseholdValueLabel.Size = new System.Drawing.Size(118, 25);
            this.lblHouseholdValueLabel.TabIndex = 38;
            this.lblHouseholdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdjustFee
            // 
            this.btnAdjustFee.Enabled = false;
            this.btnAdjustFee.Location = new System.Drawing.Point(648, 104);
            this.btnAdjustFee.Name = "btnAdjustFee";
            this.btnAdjustFee.Size = new System.Drawing.Size(109, 35);
            this.btnAdjustFee.TabIndex = 39;
            this.btnAdjustFee.Text = "Adjust Fee";
            this.btnAdjustFee.UseVisualStyleBackColor = true;
            this.btnAdjustFee.Click += new System.EventHandler(this.btnAdjustFee_Click);
            // 
            // ttpDefaults
            // 
            this.ttpDefaults.AutoPopDelay = 32000;
            this.ttpDefaults.InitialDelay = 100;
            this.ttpDefaults.ReshowDelay = 100;
            // 
            // lblMoneyInOut
            // 
            this.lblMoneyInOut.AutoSize = true;
            this.lblMoneyInOut.Location = new System.Drawing.Point(73, 72);
            this.lblMoneyInOut.Name = "lblMoneyInOut";
            this.lblMoneyInOut.Size = new System.Drawing.Size(73, 13);
            this.lblMoneyInOut.TabIndex = 40;
            this.lblMoneyInOut.Text = "Money In/Out";
            // 
            // txtMoneyInOut
            // 
            this.txtMoneyInOut.Location = new System.Drawing.Point(159, 69);
            this.txtMoneyInOut.Name = "txtMoneyInOut";
            this.txtMoneyInOut.Size = new System.Drawing.Size(118, 20);
            this.txtMoneyInOut.TabIndex = 41;
            // 
            // lblAdjustedHouseholdValue
            // 
            this.lblAdjustedHouseholdValue.AutoSize = true;
            this.lblAdjustedHouseholdValue.Location = new System.Drawing.Point(14, 109);
            this.lblAdjustedHouseholdValue.Name = "lblAdjustedHouseholdValue";
            this.lblAdjustedHouseholdValue.Size = new System.Drawing.Size(132, 13);
            this.lblAdjustedHouseholdValue.TabIndex = 42;
            this.lblAdjustedHouseholdValue.Text = "Adjusted Household Value";
            // 
            // lblEquityTarget
            // 
            this.lblEquityTarget.AutoSize = true;
            this.lblEquityTarget.Location = new System.Drawing.Point(359, 73);
            this.lblEquityTarget.Name = "lblEquityTarget";
            this.lblEquityTarget.Size = new System.Drawing.Size(70, 13);
            this.lblEquityTarget.TabIndex = 43;
            this.lblEquityTarget.Text = "Equity Target";
            // 
            // nudEquityTarget
            // 
            this.nudEquityTarget.Location = new System.Drawing.Point(435, 70);
            this.nudEquityTarget.Name = "nudEquityTarget";
            this.nudEquityTarget.Size = new System.Drawing.Size(61, 20);
            this.nudEquityTarget.TabIndex = 44;
            // 
            // lblAdjustedHouseholdValueLabel
            // 
            this.lblAdjustedHouseholdValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdjustedHouseholdValueLabel.Location = new System.Drawing.Point(159, 103);
            this.lblAdjustedHouseholdValueLabel.Name = "lblAdjustedHouseholdValueLabel";
            this.lblAdjustedHouseholdValueLabel.Size = new System.Drawing.Size(118, 25);
            this.lblAdjustedHouseholdValueLabel.TabIndex = 45;
            this.lblAdjustedHouseholdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFeeRate
            // 
            this.lblFeeRate.AutoSize = true;
            this.lblFeeRate.Location = new System.Drawing.Point(633, 37);
            this.lblFeeRate.Name = "lblFeeRate";
            this.lblFeeRate.Size = new System.Drawing.Size(57, 13);
            this.lblFeeRate.TabIndex = 46;
            this.lblFeeRate.Text = "Fee (Rate)";
            // 
            // lblFeeAmount
            // 
            this.lblFeeAmount.AutoSize = true;
            this.lblFeeAmount.Location = new System.Drawing.Point(620, 73);
            this.lblFeeAmount.Name = "lblFeeAmount";
            this.lblFeeAmount.Size = new System.Drawing.Size(70, 13);
            this.lblFeeAmount.TabIndex = 47;
            this.lblFeeAmount.Text = "Fee (Amount)";
            // 
            // lblFeeRateLabel
            // 
            this.lblFeeRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFeeRateLabel.Location = new System.Drawing.Point(696, 30);
            this.lblFeeRateLabel.Name = "lblFeeRateLabel";
            this.lblFeeRateLabel.Size = new System.Drawing.Size(75, 25);
            this.lblFeeRateLabel.TabIndex = 48;
            this.lblFeeRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFeeAmountLabel
            // 
            this.lblFeeAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFeeAmountLabel.Location = new System.Drawing.Point(696, 65);
            this.lblFeeAmountLabel.Name = "lblFeeAmountLabel";
            this.lblFeeAmountLabel.Size = new System.Drawing.Size(75, 25);
            this.lblFeeAmountLabel.TabIndex = 49;
            this.lblFeeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(682, 604);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRecs
            // 
            this.btnRecs.Enabled = false;
            this.btnRecs.Location = new System.Drawing.Point(253, 604);
            this.btnRecs.Name = "btnRecs";
            this.btnRecs.Size = new System.Drawing.Size(109, 35);
            this.btnRecs.TabIndex = 51;
            this.btnRecs.Text = "Generate Recommendations";
            this.btnRecs.UseVisualStyleBackColor = true;
            this.btnRecs.Click += new System.EventHandler(this.btnRecs_Click);
            // 
            // btnSelectNew
            // 
            this.btnSelectNew.Location = new System.Drawing.Point(539, 604);
            this.btnSelectNew.Name = "btnSelectNew";
            this.btnSelectNew.Size = new System.Drawing.Size(109, 35);
            this.btnSelectNew.TabIndex = 52;
            this.btnSelectNew.Text = "Select New Household";
            this.btnSelectNew.UseVisualStyleBackColor = true;
            // 
            // FormHousehold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.btnSelectNew);
            this.Controls.Add(this.btnRecs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFeeAmountLabel);
            this.Controls.Add(this.lblFeeRateLabel);
            this.Controls.Add(this.lblFeeAmount);
            this.Controls.Add(this.lblFeeRate);
            this.Controls.Add(this.lblAdjustedHouseholdValueLabel);
            this.Controls.Add(this.nudEquityTarget);
            this.Controls.Add(this.lblEquityTarget);
            this.Controls.Add(this.lblAdjustedHouseholdValue);
            this.Controls.Add(this.txtMoneyInOut);
            this.Controls.Add(this.lblMoneyInOut);
            this.Controls.Add(this.btnAdjustFee);
            this.Controls.Add(this.lblHouseholdValueLabel);
            this.Controls.Add(this.lblHouseholdValue);
            this.Controls.Add(this.lvwAssetClasses);
            this.Controls.Add(this.lvwAccounts);
            this.Controls.Add(this.lvwSecurities);
            this.Controls.Add(this.gbxTotalAction);
            this.Controls.Add(this.gbxTotalTarget);
            this.Controls.Add(this.gbxTotalCurrent);
            this.Controls.Add(this.btnResetDefaults);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxSectorAction);
            this.Controls.Add(this.lblAllocationLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxSectorTarget);
            this.Controls.Add(this.gbxSectorCurrent);
            this.Controls.Add(this.lblAllocation);
            this.MaximizeBox = false;
            this.Name = "FormHousehold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rebalancer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSectorCurrent.ResumeLayout(false);
            this.gbxSectorTarget.ResumeLayout(false);
            this.gbxSectorTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSectorOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxSectorAction.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxTotalCurrent.ResumeLayout(false);
            this.gbxTotalTarget.ResumeLayout(false);
            this.gbxTotalAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEquityTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.Label lblLV;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Label lblLG;
        private System.Windows.Forms.Label lblMV;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblMG;
        private System.Windows.Forms.Label lblSV;
        private System.Windows.Forms.Label lblSB;
        private System.Windows.Forms.Label lblSG;
        private System.Windows.Forms.Label lblIntl;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.GroupBox gbxSectorCurrent;
        private System.Windows.Forms.GroupBox gbxSectorTarget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAllocationLabel;
        private System.Windows.Forms.GroupBox gbxSectorAction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblFixed;
        private System.Windows.Forms.Label lblEquity;
        private System.Windows.Forms.Label lblOtherSector;
        private System.Windows.Forms.Button btnResetDefaults;
        private System.Windows.Forms.Label lblCurrentSectorOther;
        private System.Windows.Forms.Label lblCurrentSpecialty;
        private System.Windows.Forms.Label lblCurrentIntl;
        private System.Windows.Forms.Label lblCurrentSG;
        private System.Windows.Forms.Label lblCurrentSB;
        private System.Windows.Forms.Label lblCurrentSV;
        private System.Windows.Forms.Label lblCurrentMG;
        private System.Windows.Forms.Label lblCurrentMB;
        private System.Windows.Forms.Label lblCurrentMV;
        private System.Windows.Forms.Label lblCurrentLG;
        private System.Windows.Forms.Label lblCurrentLB;
        private System.Windows.Forms.Label lblCurrentLV;
        private System.Windows.Forms.GroupBox gbxTotalCurrent;
        private System.Windows.Forms.Label lblCurrentTotalOther;
        private System.Windows.Forms.Label lblCurrentCash;
        private System.Windows.Forms.Label lblCurrentFixed;
        private System.Windows.Forms.Label lblCurrentEquity;
        private System.Windows.Forms.GroupBox gbxTotalTarget;
        private System.Windows.Forms.Label lblTargetTotalOther;
        private System.Windows.Forms.Label lblTargetCash;
        private System.Windows.Forms.Label lblTargetFixed;
        private System.Windows.Forms.Label lblTargetEquity;
        private System.Windows.Forms.GroupBox gbxTotalAction;
        private System.Windows.Forms.Label lblActionTotalOther;
        private System.Windows.Forms.Label lblActionCash;
        private System.Windows.Forms.Label lblActionFixed;
        private System.Windows.Forms.Label lblActionEquity;
        private System.Windows.Forms.Label lblTargetSectorOther;
        private System.Windows.Forms.Label lblTargetLV;
        private System.Windows.Forms.Label lblTargetSpecialty;
        private System.Windows.Forms.Label lblTargetLB;
        private System.Windows.Forms.Label lblTargetIntl;
        private System.Windows.Forms.Label lblTargetLG;
        private System.Windows.Forms.Label lblTargetSG;
        private System.Windows.Forms.Label lblTargetMV;
        private System.Windows.Forms.Label lblTargetSB;
        private System.Windows.Forms.Label lblTargetMB;
        private System.Windows.Forms.Label lblTargetSV;
        private System.Windows.Forms.Label lblTargetMG;
        private System.Windows.Forms.Label lblActionSectorOther;
        private System.Windows.Forms.Label lblActionLV;
        private System.Windows.Forms.Label lblActionSpecialty;
        private System.Windows.Forms.Label lblActionLB;
        private System.Windows.Forms.Label lblActionIntl;
        private System.Windows.Forms.Label lblActionLG;
        private System.Windows.Forms.Label lblActionSG;
        private System.Windows.Forms.Label lblActionMV;
        private System.Windows.Forms.Label lblActionSB;
        private System.Windows.Forms.Label lblActionMB;
        private System.Windows.Forms.Label lblActionSV;
        private System.Windows.Forms.Label lblActionMG;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudSectorOther;
        private System.Windows.Forms.NumericUpDown nudSpecialty;
        private System.Windows.Forms.NumericUpDown nudIntl;
        private System.Windows.Forms.NumericUpDown nudSG;
        private System.Windows.Forms.NumericUpDown nudSB;
        private System.Windows.Forms.NumericUpDown nudSV;
        private System.Windows.Forms.NumericUpDown nudMG;
        private System.Windows.Forms.NumericUpDown nudLV;
        private System.Windows.Forms.NumericUpDown nudLB;
        private System.Windows.Forms.NumericUpDown nudMB;
        private System.Windows.Forms.NumericUpDown nudLG;
        private System.Windows.Forms.NumericUpDown nudMV;
        private System.Windows.Forms.Label lblSectorTotal;
        private System.Windows.Forms.ListView lvwSecurities;
        private System.Windows.Forms.ListView lvwAccounts;
        private System.Windows.Forms.ListView lvwAssetClasses;
        private System.Windows.Forms.Label lblHouseholdValue;
        private System.Windows.Forms.Label lblHouseholdValueLabel;
        private System.Windows.Forms.Button btnAdjustFee;
        private System.Windows.Forms.ToolTip ttpDefaults;
        private System.Windows.Forms.Label lblMoneyInOut;
        private System.Windows.Forms.TextBox txtMoneyInOut;
        private System.Windows.Forms.Label lblAdjustedHouseholdValue;
        private System.Windows.Forms.Label lblEquityTarget;
        private System.Windows.Forms.NumericUpDown nudEquityTarget;
        private System.Windows.Forms.Label lblAdjustedHouseholdValueLabel;
        private System.Windows.Forms.Label lblFeeRate;
        private System.Windows.Forms.Label lblFeeAmount;
        private System.Windows.Forms.Label lblFeeRateLabel;
        private System.Windows.Forms.Label lblFeeAmountLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecs;
        public System.Windows.Forms.Button btnSelectNew;
    }
}

