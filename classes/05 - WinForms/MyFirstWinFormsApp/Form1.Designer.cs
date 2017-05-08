namespace MyFirstWinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liczbaATextBox = new System.Windows.Forms.TextBox();
            this.liczbaBTextBox = new System.Windows.Forms.TextBox();
            this.wynikLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczbę a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj liczbę b";
            // 
            // liczbaATextBox
            // 
            this.liczbaATextBox.Location = new System.Drawing.Point(103, 19);
            this.liczbaATextBox.Name = "liczbaATextBox";
            this.liczbaATextBox.Size = new System.Drawing.Size(100, 20);
            this.liczbaATextBox.TabIndex = 2;
            this.liczbaATextBox.Text = "1";
            this.liczbaATextBox.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // liczbaBTextBox
            // 
            this.liczbaBTextBox.Location = new System.Drawing.Point(103, 50);
            this.liczbaBTextBox.Name = "liczbaBTextBox";
            this.liczbaBTextBox.Size = new System.Drawing.Size(100, 20);
            this.liczbaBTextBox.TabIndex = 3;
            this.liczbaBTextBox.Text = "1";
            this.liczbaBTextBox.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // wynikLabel
            // 
            this.wynikLabel.AutoSize = true;
            this.wynikLabel.Location = new System.Drawing.Point(55, 126);
            this.wynikLabel.Name = "wynikLabel";
            this.wynikLabel.Size = new System.Drawing.Size(42, 13);
            this.wynikLabel.TabIndex = 7;
            this.wynikLabel.Text = "xxxxxxx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 170);
            this.Controls.Add(this.wynikLabel);
            this.Controls.Add(this.liczbaBTextBox);
            this.Controls.Add(this.liczbaATextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My first app! :)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox liczbaATextBox;
        private System.Windows.Forms.TextBox liczbaBTextBox;
        private System.Windows.Forms.Label wynikLabel;
    }
}

