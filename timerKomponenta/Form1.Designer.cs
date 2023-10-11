namespace timerKomponenta
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
            this.components = new System.ComponentModel.Container();
            this.vrijemeLbl = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // vrijemeLbl
            // 
            this.vrijemeLbl.AutoSize = true;
            this.vrijemeLbl.Location = new System.Drawing.Point(47, 35);
            this.vrijemeLbl.Name = "vrijemeLbl";
            this.vrijemeLbl.Size = new System.Drawing.Size(89, 13);
            this.vrijemeLbl.TabIndex = 0;
            this.vrijemeLbl.Text = "Trenutno vrijeme:";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Location = new System.Drawing.Point(76, 76);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(35, 13);
            this.timerLbl.TabIndex = 1;
            this.timerLbl.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 111);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.vrijemeLbl);
            this.Name = "Form1";
            this.Text = "Upotreba timer komponente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vrijemeLbl;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

