namespace Hanoi_Stack
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
            this.BtnSolve = new System.Windows.Forms.Button();
            this.PBDraw = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUDDisks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDBreakTime = new System.Windows.Forms.NumericUpDown();
            this.NUDDishHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PBDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBreakTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDishHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSolve
            // 
            this.BtnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolve.Location = new System.Drawing.Point(563, 40);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(98, 30);
            this.BtnSolve.TabIndex = 0;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBDraw
            // 
            this.PBDraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PBDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBDraw.Location = new System.Drawing.Point(12, 12);
            this.PBDraw.Name = "PBDraw";
            this.PBDraw.Size = new System.Drawing.Size(732, 311);
            this.PBDraw.TabIndex = 1;
            this.PBDraw.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.NUDDishHeight);
            this.groupBox1.Controls.Add(this.NUDBreakTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NUDDisks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSolve);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // NUDDisks
            // 
            this.NUDDisks.Location = new System.Drawing.Point(177, 33);
            this.NUDDisks.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDDisks.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDDisks.Name = "NUDDisks";
            this.NUDDisks.Size = new System.Drawing.Size(105, 26);
            this.NUDDisks.TabIndex = 2;
            this.NUDDisks.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Disks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Break Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disk Height :";
            // 
            // NUDBreakTime
            // 
            this.NUDBreakTime.Location = new System.Drawing.Point(403, 20);
            this.NUDBreakTime.Name = "NUDBreakTime";
            this.NUDBreakTime.Size = new System.Drawing.Size(105, 26);
            this.NUDBreakTime.TabIndex = 5;
            this.NUDBreakTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDBreakTime.ValueChanged += new System.EventHandler(this.NUDBreakTime_ValueChanged);
            // 
            // NUDDishHeight
            // 
            this.NUDDishHeight.Location = new System.Drawing.Point(403, 48);
            this.NUDDishHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDDishHeight.Name = "NUDDishHeight";
            this.NUDDishHeight.Size = new System.Drawing.Size(105, 26);
            this.NUDDishHeight.TabIndex = 6;
            this.NUDDishHeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUDDishHeight.ValueChanged += new System.EventHandler(this.NUDDishHeight_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(756, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PBDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(772, 447);
            this.MinimumSize = new System.Drawing.Size(772, 447);
            this.Name = "Form1";
            this.Opacity = 0.95;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBreakTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDishHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.PictureBox PBDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUDDisks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDDishHeight;
        private System.Windows.Forms.NumericUpDown NUDBreakTime;
    }
}

