namespace TowerOfHanoi.WindowSimulation
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
            this.numberOfKrazki = new System.Windows.Forms.NumericUpDown();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfKrazki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberOfKrazki
            // 
            this.numberOfKrazki.Location = new System.Drawing.Point(75, 12);
            this.numberOfKrazki.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfKrazki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfKrazki.Name = "numberOfKrazki";
            this.numberOfKrazki.Size = new System.Drawing.Size(120, 20);
            this.numberOfKrazki.TabIndex = 2;
            this.numberOfKrazki.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // interval
            // 
            this.interval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.interval.Location = new System.Drawing.Point(292, 12);
            this.interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.interval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(120, 20);
            this.interval.TabIndex = 3;
            this.interval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Krążki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Interwał";
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(36, 70);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(655, 188);
            this.canvas.TabIndex = 6;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 297);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.numberOfKrazki);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfKrazki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numberOfKrazki;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel canvas;
    }
}

