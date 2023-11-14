namespace MegaMartSupermecados
{
    partial class RealizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarVenda));
            this.dataGridViewCarrinho = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_vender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarrinho
            // 
            this.dataGridViewCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrinho.Location = new System.Drawing.Point(0, 278);
            this.dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            this.dataGridViewCarrinho.Size = new System.Drawing.Size(782, 175);
            this.dataGridViewCarrinho.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(126, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 274);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // bt_vender
            // 
            this.bt_vender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_vender.Location = new System.Drawing.Point(689, 243);
            this.bt_vender.Name = "bt_vender";
            this.bt_vender.Size = new System.Drawing.Size(75, 29);
            this.bt_vender.TabIndex = 38;
            this.bt_vender.Text = "Vender";
            this.bt_vender.UseVisualStyleBackColor = false;
            this.bt_vender.Click += new System.EventHandler(this.bt_vender_Click);
            // 
            // RealizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.bt_vender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewCarrinho);
            this.Name = "RealizarVenda";
            this.Text = "RealizarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCarrinho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_vender;
    }
}