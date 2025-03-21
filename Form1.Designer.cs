namespace GreedyPigSim
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
            this.button1 = new System.Windows.Forms.Button();
            this.simtype = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nMin = new System.Windows.Forms.NumericUpDown();
            this.nMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataPoints = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pickFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generate_Click);
            // 
            // simtype
            // 
            this.simtype.AutoSize = true;
            this.simtype.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.simtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.simtype.Location = new System.Drawing.Point(8, 6);
            this.simtype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.simtype.Name = "simtype";
            this.simtype.Size = new System.Drawing.Size(146, 15);
            this.simtype.TabIndex = 1;
            this.simtype.Text = "Simulation Type (Select One)";
            this.simtype.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Go until n",
            "Go for n rounds"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 21);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(141, 38);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.selection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulation Parameters";
            // 
            // nMin
            // 
            this.nMin.Location = new System.Drawing.Point(67, 81);
            this.nMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nMin.Name = "nMin";
            this.nMin.Size = new System.Drawing.Size(80, 20);
            this.nMin.TabIndex = 4;
            this.nMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nMin.ValueChanged += new System.EventHandler(this.nMin_ValueChanged);
            // 
            // nMax
            // 
            this.nMax.Location = new System.Drawing.Point(67, 102);
            this.nMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nMax.Name = "nMax";
            this.nMax.Size = new System.Drawing.Size(80, 20);
            this.nMax.TabIndex = 5;
            this.nMax.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nMax.ValueChanged += new System.EventHandler(this.nMax_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nMin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "nMax";
            // 
            // dataPoints
            // 
            this.dataPoints.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dataPoints.Location = new System.Drawing.Point(67, 123);
            this.dataPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataPoints.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.dataPoints.Name = "dataPoints";
            this.dataPoints.Size = new System.Drawing.Size(80, 20);
            this.dataPoints.TabIndex = 8;
            this.dataPoints.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dataPoints.ValueChanged += new System.EventHandler(this.dataPoints_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Points";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // target
            // 
            this.target.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.target.Location = new System.Drawing.Point(67, 144);
            this.target.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.target.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(80, 20);
            this.target.TabIndex = 10;
            this.target.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.target.ValueChanged += new System.EventHandler(this.target_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pickFolder
            // 
            this.pickFolder.HelpRequest += new System.EventHandler(this.pickFolder_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 214);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.target);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nMax);
            this.Controls.Add(this.nMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.simtype);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Marcus\' Data Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label simtype;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nMin;
        private System.Windows.Forms.NumericUpDown nMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dataPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown target;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog pickFolder;
    }
}

