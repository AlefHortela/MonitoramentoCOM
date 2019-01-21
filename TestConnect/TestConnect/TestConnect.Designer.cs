namespace TestConnect
{
    partial class TestConnect
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLeftConnect = new System.Windows.Forms.Label();
            this.lblRightConnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(50, 52);
            this.txtLeft.Multiline = true;
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLeft.Size = new System.Drawing.Size(518, 653);
            this.txtLeft.TabIndex = 0;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(615, 52);
            this.txtRight.Multiline = true;
            this.txtRight.Name = "txtRight";
            this.txtRight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRight.Size = new System.Drawing.Size(542, 653);
            this.txtRight.TabIndex = 1;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(47, 24);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(56, 13);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "COM USB";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(612, 24);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(64, 13);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "COM UART";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM 5 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "COM 3";
            // 
            // lblLeftConnect
            // 
            this.lblLeftConnect.AutoSize = true;
            this.lblLeftConnect.Location = new System.Drawing.Point(205, 24);
            this.lblLeftConnect.Name = "lblLeftConnect";
            this.lblLeftConnect.Size = new System.Drawing.Size(0, 13);
            this.lblLeftConnect.TabIndex = 6;
            // 
            // lblRightConnect
            // 
            this.lblRightConnect.AutoSize = true;
            this.lblRightConnect.Location = new System.Drawing.Point(974, 24);
            this.lblRightConnect.Name = "lblRightConnect";
            this.lblRightConnect.Size = new System.Drawing.Size(0, 13);
            this.lblRightConnect.TabIndex = 7;
            // 
            // TestConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 717);
            this.Controls.Add(this.lblRightConnect);
            this.Controls.Add(this.lblLeftConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestConnect";
            this.Text = "TestConnect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TestConnect_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeftConnect;
        private System.Windows.Forms.Label lblRightConnect;
    }
}

