
namespace MyCardGame
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
            this.btnDeal = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel21 = new System.Windows.Forms.Panel();
            this.Panel22 = new System.Windows.Forms.Panel();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(78, 332);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(250, 190);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(521, 165);
            this.Panel1.TabIndex = 1;
            // 
            // Panel21
            // 
            this.Panel21.Location = new System.Drawing.Point(250, 12);
            this.Panel21.Name = "Panel21";
            this.Panel21.Size = new System.Drawing.Size(238, 155);
            this.Panel21.TabIndex = 2;
            // 
            // Panel22
            // 
            this.Panel22.Location = new System.Drawing.Point(545, 12);
            this.Panel22.Name = "Panel22";
            this.Panel22.Size = new System.Drawing.Size(226, 155);
            this.Panel22.TabIndex = 3;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(78, 287);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(78, 239);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.Panel22);
            this.Controls.Add(this.Panel21);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnDeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel21;
        private System.Windows.Forms.Panel Panel22;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
    }
}

