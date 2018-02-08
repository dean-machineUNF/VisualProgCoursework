namespace Project1
{
    partial class Form1
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
            this.btnWeightCost = new System.Windows.Forms.Button();
            this.USDollarsWeightOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearWeight = new System.Windows.Forms.Button();
            this.CanadaDollarsWeightOutput = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearMiles = new System.Windows.Forms.Button();
            this.milesInput = new System.Windows.Forms.TextBox();
            this.USDollarsMilesOutput = new System.Windows.Forms.TextBox();
            this.CanadaDollarsMilesOutput = new System.Windows.Forms.TextBox();
            this.btnMilesCost = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWeightCost
            // 
            this.btnWeightCost.Location = new System.Drawing.Point(23, 103);
            this.btnWeightCost.Name = "btnWeightCost";
            this.btnWeightCost.Size = new System.Drawing.Size(141, 73);
            this.btnWeightCost.TabIndex = 0;
            this.btnWeightCost.Text = "Calculate Cost By Weight";
            this.btnWeightCost.UseVisualStyleBackColor = true;
            this.btnWeightCost.Click += new System.EventHandler(this.btnWeightCost_Click);
            // 
            // USDollarsWeightOutput
            // 
            this.USDollarsWeightOutput.Location = new System.Drawing.Point(375, 103);
            this.USDollarsWeightOutput.Name = "USDollarsWeightOutput";
            this.USDollarsWeightOutput.Size = new System.Drawing.Size(144, 26);
            this.USDollarsWeightOutput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost in US Dollars";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(56, 203);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearWeight);
            this.splitContainer1.Panel1.Controls.Add(this.CanadaDollarsWeightOutput);
            this.splitContainer1.Panel1.Controls.Add(this.weightInput);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnWeightCost);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.USDollarsWeightOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearMiles);
            this.splitContainer1.Panel2.Controls.Add(this.milesInput);
            this.splitContainer1.Panel2.Controls.Add(this.USDollarsMilesOutput);
            this.splitContainer1.Panel2.Controls.Add(this.CanadaDollarsMilesOutput);
            this.splitContainer1.Panel2.Controls.Add(this.btnMilesCost);
            this.splitContainer1.Size = new System.Drawing.Size(545, 467);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost in Canada Dollars";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClearWeight
            // 
            this.btnClearWeight.Location = new System.Drawing.Point(172, 118);
            this.btnClearWeight.Name = "btnClearWeight";
            this.btnClearWeight.Size = new System.Drawing.Size(100, 43);
            this.btnClearWeight.TabIndex = 6;
            this.btnClearWeight.Text = "Clear";
            this.btnClearWeight.UseVisualStyleBackColor = true;
            this.btnClearWeight.Click += new System.EventHandler(this.btnClearWeight_Click);
            // 
            // CanadaDollarsWeightOutput
            // 
            this.CanadaDollarsWeightOutput.Location = new System.Drawing.Point(374, 173);
            this.CanadaDollarsWeightOutput.Name = "CanadaDollarsWeightOutput";
            this.CanadaDollarsWeightOutput.Size = new System.Drawing.Size(145, 26);
            this.CanadaDollarsWeightOutput.TabIndex = 2;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(23, 74);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(141, 26);
            this.weightInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "(Pounds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Miles)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClearMiles
            // 
            this.btnClearMiles.Location = new System.Drawing.Point(172, 114);
            this.btnClearMiles.Name = "btnClearMiles";
            this.btnClearMiles.Size = new System.Drawing.Size(86, 40);
            this.btnClearMiles.TabIndex = 4;
            this.btnClearMiles.Text = "Clear";
            this.btnClearMiles.UseVisualStyleBackColor = true;
            this.btnClearMiles.Click += new System.EventHandler(this.btnClearMiles_Click);
            // 
            // milesInput
            // 
            this.milesInput.Location = new System.Drawing.Point(23, 66);
            this.milesInput.Name = "milesInput";
            this.milesInput.Size = new System.Drawing.Size(141, 26);
            this.milesInput.TabIndex = 3;
            // 
            // USDollarsMilesOutput
            // 
            this.USDollarsMilesOutput.Location = new System.Drawing.Point(376, 66);
            this.USDollarsMilesOutput.Name = "USDollarsMilesOutput";
            this.USDollarsMilesOutput.Size = new System.Drawing.Size(125, 26);
            this.USDollarsMilesOutput.TabIndex = 2;
            // 
            // CanadaDollarsMilesOutput
            // 
            this.CanadaDollarsMilesOutput.Location = new System.Drawing.Point(375, 130);
            this.CanadaDollarsMilesOutput.Name = "CanadaDollarsMilesOutput";
            this.CanadaDollarsMilesOutput.Size = new System.Drawing.Size(126, 26);
            this.CanadaDollarsMilesOutput.TabIndex = 1;
            // 
            // btnMilesCost
            // 
            this.btnMilesCost.Location = new System.Drawing.Point(23, 98);
            this.btnMilesCost.Name = "btnMilesCost";
            this.btnMilesCost.Size = new System.Drawing.Size(141, 72);
            this.btnMilesCost.TabIndex = 0;
            this.btnMilesCost.Text = "Calculate Cost By Miles";
            this.btnMilesCost.UseVisualStyleBackColor = true;
            this.btnMilesCost.Click += new System.EventHandler(this.btnMilesCost_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cost in US Dollars";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cost in Canada Dollars";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cost by Distance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cost by Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 947);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeightCost;
        private System.Windows.Forms.TextBox USDollarsWeightOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CanadaDollarsWeightOutput;
        private System.Windows.Forms.TextBox milesInput;
        private System.Windows.Forms.TextBox USDollarsMilesOutput;
        private System.Windows.Forms.TextBox CanadaDollarsMilesOutput;
        private System.Windows.Forms.Button btnMilesCost;
        private System.Windows.Forms.Button btnClearWeight;
        private System.Windows.Forms.Button btnClearMiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

