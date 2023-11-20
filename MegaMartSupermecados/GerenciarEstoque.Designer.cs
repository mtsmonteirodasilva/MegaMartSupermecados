namespace MegaMartSupermecados
{
    partial class GerenciarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarEstoque));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.tx_quantidadeEstoque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(130, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 252);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.Location = new System.Drawing.Point(688, 411);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(100, 27);
            this.bt_atualizar.TabIndex = 2;
            this.bt_atualizar.Text = "Atualizar Estoque";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(-2, 237);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.Size = new System.Drawing.Size(803, 168);
            this.dataGridViewEstoque.TabIndex = 3;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(607, 413);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionar.TabIndex = 5;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(526, 413);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(75, 23);
            this.bt_remover.TabIndex = 6;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // tx_quantidadeEstoque
            // 
            this.tx_quantidadeEstoque.Location = new System.Drawing.Point(130, 411);
            this.tx_quantidadeEstoque.Name = "tx_quantidadeEstoque";
            this.tx_quantidadeEstoque.Size = new System.Drawing.Size(100, 20);
            this.tx_quantidadeEstoque.TabIndex = 4;
            // 
            // GerenciarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.tx_quantidadeEstoque);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GerenciarEstoque";
            this.Text = "GerenciarEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.TextBox tx_quantidadeEstoque;
    }
}