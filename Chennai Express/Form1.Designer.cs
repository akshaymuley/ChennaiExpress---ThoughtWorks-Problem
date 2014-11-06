namespace Chennai_Express
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
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.cbxSourceStations = new System.Windows.Forms.ComboBox();
            this.cbxDestinationStaions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.Location = new System.Drawing.Point(94, 134);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(95, 23);
            this.btnPrintTicket.TabIndex = 4;
            this.btnPrintTicket.Text = "Print Ticket";
            this.btnPrintTicket.UseVisualStyleBackColor = true;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicketClickHandler);
            // 
            // cbxSourceStations
            // 
            this.cbxSourceStations.FormattingEnabled = true;
            this.cbxSourceStations.Location = new System.Drawing.Point(94, 38);
            this.cbxSourceStations.Name = "cbxSourceStations";
            this.cbxSourceStations.Size = new System.Drawing.Size(121, 21);
            this.cbxSourceStations.TabIndex = 5;
            // 
            // cbxDestinationStaions
            // 
            this.cbxDestinationStaions.FormattingEnabled = true;
            this.cbxDestinationStaions.Location = new System.Drawing.Point(94, 92);
            this.cbxDestinationStaions.Name = "cbxDestinationStaions";
            this.cbxDestinationStaions.Size = new System.Drawing.Size(121, 21);
            this.cbxDestinationStaions.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbxDestinationStaions);
            this.Controls.Add(this.cbxSourceStations);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1LoadEventHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.ComboBox cbxSourceStations;
        private System.Windows.Forms.ComboBox cbxDestinationStaions;

    }
}

