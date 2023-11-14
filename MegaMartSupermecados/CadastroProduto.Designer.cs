namespace MegaMartSupermecados
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.tb_venda = new System.Windows.Forms.TextBox();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.tx_lucro = new System.Windows.Forms.TextBox();
            this.tx_descricao = new System.Windows.Forms.TextBox();
            this.tx_precoAquisicao = new System.Windows.Forms.TextBox();
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_realizarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_venda
            // 
            this.tb_venda.Enabled = false;
            this.tb_venda.Location = new System.Drawing.Point(136, 182);
            this.tb_venda.Name = "tb_venda";
            this.tb_venda.Size = new System.Drawing.Size(110, 20);
            this.tb_venda.TabIndex = 33;
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluir.Location = new System.Drawing.Point(599, 253);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 29);
            this.bt_excluir.TabIndex = 32;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_novo.Location = new System.Drawing.Point(437, 254);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 29);
            this.bt_novo.TabIndex = 31;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // tx_lucro
            // 
            this.tx_lucro.Location = new System.Drawing.Point(136, 156);
            this.tx_lucro.Name = "tx_lucro";
            this.tx_lucro.Size = new System.Drawing.Size(110, 20);
            this.tx_lucro.TabIndex = 30;
            // 
            // tx_descricao
            // 
            this.tx_descricao.Location = new System.Drawing.Point(136, 73);
            this.tx_descricao.Name = "tx_descricao";
            this.tx_descricao.Size = new System.Drawing.Size(110, 20);
            this.tx_descricao.TabIndex = 29;
            // 
            // tx_precoAquisicao
            // 
            this.tx_precoAquisicao.Location = new System.Drawing.Point(136, 130);
            this.tx_precoAquisicao.Name = "tx_precoAquisicao";
            this.tx_precoAquisicao.Size = new System.Drawing.Size(110, 20);
            this.tx_precoAquisicao.TabIndex = 28;
            // 
            // tx_codigo
            // 
            this.tx_codigo.Location = new System.Drawing.Point(136, 99);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(110, 20);
            this.tx_codigo.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 162);
            this.dataGridView1.TabIndex = 26;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cadastrar.Location = new System.Drawing.Point(518, 253);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(75, 29);
            this.bt_cadastrar.TabIndex = 25;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Lucro % :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor de Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Preço de Aquisição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro de Produto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(96, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 274);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // bt_realizarVenda
            // 
            this.bt_realizarVenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_realizarVenda.Location = new System.Drawing.Point(343, 254);
            this.bt_realizarVenda.Name = "bt_realizarVenda";
            this.bt_realizarVenda.Size = new System.Drawing.Size(88, 29);
            this.bt_realizarVenda.TabIndex = 35;
            this.bt_realizarVenda.Text = "Realizar venda";
            this.bt_realizarVenda.UseVisualStyleBackColor = false;
            this.bt_realizarVenda.Click += new System.EventHandler(this.bt_realizarVenda_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.bt_realizarVenda);
            this.Controls.Add(this.tb_venda);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.tx_lucro);
            this.Controls.Add(this.tx_descricao);
            this.Controls.Add(this.tx_precoAquisicao);
            this.Controls.Add(this.tx_codigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_venda;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.TextBox tx_lucro;
        private System.Windows.Forms.TextBox tx_descricao;
        private System.Windows.Forms.TextBox tx_precoAquisicao;
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_realizarVenda;
    }
}