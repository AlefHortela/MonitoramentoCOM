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
            this.lblLeftConnect = new System.Windows.Forms.Label();
            this.lblRightConnect = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBaudRateUART = new System.Windows.Forms.TextBox();
            this.txtBaudRateUSB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.btnStopLeft = new System.Windows.Forms.Button();
            this.btnStartLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.btnStopRight = new System.Windows.Forms.Button();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnStartRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDataUSB = new System.Windows.Forms.CheckBox();
            this.chkDataUART = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtBaudRateUART, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBaudRateUSB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.51417F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.47559F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1223, 544);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtBaudRateUART
            // 
            this.txtBaudRateUART.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaudRateUART.Location = new System.Drawing.Point(614, 396);
            this.txtBaudRateUART.Multiline = true;
            this.txtBaudRateUART.Name = "txtBaudRateUART";
            this.txtBaudRateUART.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBaudRateUART.Size = new System.Drawing.Size(606, 145);
            this.txtBaudRateUART.TabIndex = 12;
            // 
            // txtBaudRateUSB
            // 
            this.txtBaudRateUSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaudRateUSB.Location = new System.Drawing.Point(3, 396);
            this.txtBaudRateUSB.Multiline = true;
            this.txtBaudRateUSB.Name = "txtBaudRateUSB";
            this.txtBaudRateUSB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBaudRateUSB.Size = new System.Drawing.Size(605, 145);
            this.txtBaudRateUSB.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDataUSB);
            this.panel1.Controls.Add(this.chkLeft);
            this.panel1.Controls.Add(this.btnStopLeft);
            this.panel1.Controls.Add(this.btnStartLeft);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 63);
            this.panel1.TabIndex = 9;
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(215, 35);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(88, 17);
            this.chkLeft.TabIndex = 11;
            this.chkLeft.Text = "AutoConnect";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // btnStopLeft
            // 
            this.btnStopLeft.Location = new System.Drawing.Point(310, 5);
            this.btnStopLeft.Name = "btnStopLeft";
            this.btnStopLeft.Size = new System.Drawing.Size(75, 23);
            this.btnStopLeft.TabIndex = 10;
            this.btnStopLeft.Text = "Stop";
            this.btnStopLeft.UseVisualStyleBackColor = true;
            this.btnStopLeft.Click += new System.EventHandler(this.btnStopLeft_Click);
            // 
            // btnStartLeft
            // 
            this.btnStartLeft.Location = new System.Drawing.Point(215, 5);
            this.btnStartLeft.Name = "btnStartLeft";
            this.btnStartLeft.Size = new System.Drawing.Size(75, 23);
            this.btnStartLeft.TabIndex = 9;
            this.btnStartLeft.Text = "Start";
            this.btnStartLeft.UseVisualStyleBackColor = true;
            this.btnStartLeft.Click += new System.EventHandler(this.btnStartLeft_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "COM 5 ";
            // 
            // lblLeft
            // 
            this.lblLeft.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLeft.Location = new System.Drawing.Point(1, 10);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(56, 13);
            this.lblLeft.TabIndex = 7;
            this.lblLeft.Text = "COM USB";
            // 
            // txtRight
            // 
            this.txtRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRight.Location = new System.Drawing.Point(614, 72);
            this.txtRight.Multiline = true;
            this.txtRight.Name = "txtRight";
            this.txtRight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRight.Size = new System.Drawing.Size(606, 318);
            this.txtRight.TabIndex = 5;
            // 
            // txtLeft
            // 
            this.txtLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeft.Location = new System.Drawing.Point(3, 72);
            this.txtLeft.Multiline = true;
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLeft.Size = new System.Drawing.Size(605, 318);
            this.txtLeft.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkDataUART);
            this.panel2.Controls.Add(this.chkRight);
            this.panel2.Controls.Add(this.btnStopRight);
            this.panel2.Controls.Add(this.lblRight);
            this.panel2.Controls.Add(this.btnStartRight);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(614, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 63);
            this.panel2.TabIndex = 10;
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(215, 35);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(88, 17);
            this.chkRight.TabIndex = 12;
            this.chkRight.Text = "AutoConnect";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // btnStopRight
            // 
            this.btnStopRight.Location = new System.Drawing.Point(310, 7);
            this.btnStopRight.Name = "btnStopRight";
            this.btnStopRight.Size = new System.Drawing.Size(75, 23);
            this.btnStopRight.TabIndex = 12;
            this.btnStopRight.Text = "Stop";
            this.btnStopRight.UseVisualStyleBackColor = true;
            this.btnStopRight.Click += new System.EventHandler(this.btnStopRight_Click);
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(1, 10);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(64, 13);
            this.lblRight.TabIndex = 4;
            this.lblRight.Text = "COM UART";
            // 
            // btnStartRight
            // 
            this.btnStartRight.Location = new System.Drawing.Point(215, 5);
            this.btnStartRight.Name = "btnStartRight";
            this.btnStartRight.Size = new System.Drawing.Size(75, 23);
            this.btnStartRight.TabIndex = 11;
            this.btnStartRight.Text = "Start";
            this.btnStartRight.UseVisualStyleBackColor = true;
            this.btnStartRight.Click += new System.EventHandler(this.btnStartRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM 3";
            // 
            // chkDataUSB
            // 
            this.chkDataUSB.AutoSize = true;
            this.chkDataUSB.Location = new System.Drawing.Point(310, 35);
            this.chkDataUSB.Name = "chkDataUSB";
            this.chkDataUSB.Size = new System.Drawing.Size(85, 17);
            this.chkDataUSB.TabIndex = 12;
            this.chkDataUSB.Text = "Plotar dados";
            this.chkDataUSB.UseVisualStyleBackColor = true;
            // 
            // chkDataUART
            // 
            this.chkDataUART.AutoSize = true;
            this.chkDataUART.Location = new System.Drawing.Point(310, 35);
            this.chkDataUART.Name = "chkDataUART";
            this.chkDataUART.Size = new System.Drawing.Size(85, 17);
            this.chkDataUART.TabIndex = 13;
            this.chkDataUART.Text = "Plotar dados";
            this.chkDataUART.UseVisualStyleBackColor = true;
            // 
            // TestConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblRightConnect);
            this.Controls.Add(this.lblLeftConnect);
            this.MinimizeBox = false;
            this.Name = "TestConnect";
            this.Text = "TestConnect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TestConnect_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLeftConnect;
        private System.Windows.Forms.Label lblRightConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBaudRateUART;
        private System.Windows.Forms.TextBox txtBaudRateUSB;
        private System.Windows.Forms.Button btnStopLeft;
        private System.Windows.Forms.Button btnStartLeft;
        private System.Windows.Forms.Button btnStopRight;
        private System.Windows.Forms.Button btnStartRight;
        private System.Windows.Forms.CheckBox chkLeft;
        private System.Windows.Forms.CheckBox chkRight;
        private System.Windows.Forms.CheckBox chkDataUSB;
        private System.Windows.Forms.CheckBox chkDataUART;
    }
}

