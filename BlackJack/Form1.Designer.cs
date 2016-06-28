namespace BlackJack
{
    partial class JackBlack
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
            this.button2 = new System.Windows.Forms.Button();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDealerHand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Location = new System.Drawing.Point(269, 344);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(10, 13);
            this.lblPlayerCards.TabIndex = 2;
            this.lblPlayerCards.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDealerHand
            // 
            this.lblDealerHand.AutoSize = true;
            this.lblDealerHand.Location = new System.Drawing.Point(272, 56);
            this.lblDealerHand.Name = "lblDealerHand";
            this.lblDealerHand.Size = new System.Drawing.Size(10, 13);
            this.lblDealerHand.TabIndex = 4;
            this.lblDealerHand.Text = "-";
            // 
            // JackBlack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 472);
            this.Controls.Add(this.lblDealerHand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.button2);
            this.Name = "JackBlack";
            this.Text = "JackBlack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDealerHand;
    }
}

