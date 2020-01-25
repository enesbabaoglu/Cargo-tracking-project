namespace KargoTakip
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.dataGridViewsonuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(462, 90);
            this.txttc.MaxLength = 11;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(233, 20);
            this.txttc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC KİMLİK NO :";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(529, 130);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(73, 35);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dataGridViewsonuc
            // 
            this.dataGridViewsonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsonuc.Location = new System.Drawing.Point(96, 214);
            this.dataGridViewsonuc.Name = "dataGridViewsonuc";
            this.dataGridViewsonuc.Size = new System.Drawing.Size(897, 254);
            this.dataGridViewsonuc.TabIndex = 3;
            this.dataGridViewsonuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsonuc_CellClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1064, 543);
            this.Controls.Add(this.dataGridViewsonuc);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "KARGO TAKİP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.DataGridView dataGridViewsonuc;
    }
}