namespace AgendaContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_inserir = new System.Windows.Forms.ToolStripButton();
            this.tsb_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl_inserir = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.mtb_cel = new System.Windows.Forms.MaskedTextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.mtb_tel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_deletar = new System.Windows.Forms.Panel();
            this.tb_cod_excluir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.pnl_editar = new System.Windows.Forms.Panel();
            this.tb_cod_editar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_desc_editar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtb_cel_editar = new System.Windows.Forms.MaskedTextBox();
            this.tb_nome_editar = new System.Windows.Forms.TextBox();
            this.mtb_tel_editar = new System.Windows.Forms.MaskedTextBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_normal = new System.Windows.Forms.Button();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_maximizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnl_inserir.SuspendLayout();
            this.pnl_deletar.SuspendLayout();
            this.pnl_editar.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_inserir,
            this.tsb_editar,
            this.toolStripSeparator1,
            this.tsb_excluir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(575, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_inserir
            // 
            this.tsb_inserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_inserir.Image = ((System.Drawing.Image)(resources.GetObject("tsb_inserir.Image")));
            this.tsb_inserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_inserir.Name = "tsb_inserir";
            this.tsb_inserir.Size = new System.Drawing.Size(23, 22);
            this.tsb_inserir.Text = "Inserir";
            this.tsb_inserir.Click += new System.EventHandler(this.tsb_inserir_Click);
            // 
            // tsb_editar
            // 
            this.tsb_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_editar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_editar.Image")));
            this.tsb_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_editar.Name = "tsb_editar";
            this.tsb_editar.Size = new System.Drawing.Size(23, 22);
            this.tsb_editar.Text = "Editar";
            this.tsb_editar.Click += new System.EventHandler(this.tsb_editar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_excluir
            // 
            this.tsb_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_excluir.Image = ((System.Drawing.Image)(resources.GetObject("tsb_excluir.Image")));
            this.tsb_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_excluir.Name = "tsb_excluir";
            this.tsb_excluir.Size = new System.Drawing.Size(23, 22);
            this.tsb_excluir.Text = "Excluir";
            this.tsb_excluir.Click += new System.EventHandler(this.tsb_excluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pnl_inserir
            // 
            this.pnl_inserir.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_inserir.Controls.Add(this.label4);
            this.pnl_inserir.Controls.Add(this.label3);
            this.pnl_inserir.Controls.Add(this.tb_desc);
            this.pnl_inserir.Controls.Add(this.label2);
            this.pnl_inserir.Controls.Add(this.bt_inserir);
            this.pnl_inserir.Controls.Add(this.mtb_cel);
            this.pnl_inserir.Controls.Add(this.tb_nome);
            this.pnl_inserir.Controls.Add(this.mtb_tel);
            this.pnl_inserir.Controls.Add(this.label1);
            this.pnl_inserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_inserir.Location = new System.Drawing.Point(9, 34);
            this.pnl_inserir.Name = "pnl_inserir";
            this.pnl_inserir.Size = new System.Drawing.Size(443, 256);
            this.pnl_inserir.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(141, 27);
            this.tb_desc.MaxLength = 250;
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(256, 131);
            this.tb_desc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // bt_inserir
            // 
            this.bt_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_inserir.Image = global::AgendaContato.Properties.Resources.save;
            this.bt_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_inserir.Location = new System.Drawing.Point(15, 197);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_inserir.Size = new System.Drawing.Size(77, 33);
            this.bt_inserir.TabIndex = 1;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // mtb_cel
            // 
            this.mtb_cel.Location = new System.Drawing.Point(15, 137);
            this.mtb_cel.Mask = "(99) 0000-0000";
            this.mtb_cel.Name = "mtb_cel";
            this.mtb_cel.Size = new System.Drawing.Size(100, 20);
            this.mtb_cel.TabIndex = 4;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(15, 27);
            this.tb_nome.MaxLength = 50;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // mtb_tel
            // 
            this.mtb_tel.Location = new System.Drawing.Point(15, 76);
            this.mtb_tel.Mask = "(99) 0000-0000";
            this.mtb_tel.Name = "mtb_tel";
            this.mtb_tel.Size = new System.Drawing.Size(100, 20);
            this.mtb_tel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // pnl_deletar
            // 
            this.pnl_deletar.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_deletar.Controls.Add(this.tb_cod_excluir);
            this.pnl_deletar.Controls.Add(this.label10);
            this.pnl_deletar.Controls.Add(this.bt_excluir);
            this.pnl_deletar.Location = new System.Drawing.Point(528, 3);
            this.pnl_deletar.Name = "pnl_deletar";
            this.pnl_deletar.Size = new System.Drawing.Size(153, 126);
            this.pnl_deletar.TabIndex = 2;
            this.pnl_deletar.Visible = false;
            // 
            // tb_cod_excluir
            // 
            this.tb_cod_excluir.Location = new System.Drawing.Point(16, 31);
            this.tb_cod_excluir.MaxLength = 5;
            this.tb_cod_excluir.Name = "tb_cod_excluir";
            this.tb_cod_excluir.Size = new System.Drawing.Size(100, 20);
            this.tb_cod_excluir.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Código";
            // 
            // bt_excluir
            // 
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_excluir.Image = global::AgendaContato.Properties.Resources.save;
            this.bt_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_excluir.Location = new System.Drawing.Point(16, 69);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_excluir.Size = new System.Drawing.Size(77, 33);
            this.bt_excluir.TabIndex = 21;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // pnl_editar
            // 
            this.pnl_editar.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_editar.Controls.Add(this.tb_cod_editar);
            this.pnl_editar.Controls.Add(this.label9);
            this.pnl_editar.Controls.Add(this.label5);
            this.pnl_editar.Controls.Add(this.label6);
            this.pnl_editar.Controls.Add(this.tb_desc_editar);
            this.pnl_editar.Controls.Add(this.label7);
            this.pnl_editar.Controls.Add(this.mtb_cel_editar);
            this.pnl_editar.Controls.Add(this.tb_nome_editar);
            this.pnl_editar.Controls.Add(this.mtb_tel_editar);
            this.pnl_editar.Controls.Add(this.bt_editar);
            this.pnl_editar.Controls.Add(this.label8);
            this.pnl_editar.Location = new System.Drawing.Point(528, 149);
            this.pnl_editar.Name = "pnl_editar";
            this.pnl_editar.Size = new System.Drawing.Size(424, 306);
            this.pnl_editar.TabIndex = 1;
            this.pnl_editar.Visible = false;
            // 
            // tb_cod_editar
            // 
            this.tb_cod_editar.Location = new System.Drawing.Point(17, 31);
            this.tb_cod_editar.MaxLength = 5;
            this.tb_cod_editar.Name = "tb_cod_editar";
            this.tb_cod_editar.Size = new System.Drawing.Size(100, 20);
            this.tb_cod_editar.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefone";
            // 
            // tb_desc_editar
            // 
            this.tb_desc_editar.Location = new System.Drawing.Point(143, 31);
            this.tb_desc_editar.MaxLength = 250;
            this.tb_desc_editar.Multiline = true;
            this.tb_desc_editar.Name = "tb_desc_editar";
            this.tb_desc_editar.Size = new System.Drawing.Size(251, 171);
            this.tb_desc_editar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição";
            // 
            // mtb_cel_editar
            // 
            this.mtb_cel_editar.Location = new System.Drawing.Point(17, 182);
            this.mtb_cel_editar.Mask = "(99) 0000-0000";
            this.mtb_cel_editar.Name = "mtb_cel_editar";
            this.mtb_cel_editar.Size = new System.Drawing.Size(100, 20);
            this.mtb_cel_editar.TabIndex = 13;
            // 
            // tb_nome_editar
            // 
            this.tb_nome_editar.Location = new System.Drawing.Point(17, 82);
            this.tb_nome_editar.MaxLength = 50;
            this.tb_nome_editar.Name = "tb_nome_editar";
            this.tb_nome_editar.Size = new System.Drawing.Size(100, 20);
            this.tb_nome_editar.TabIndex = 12;
            // 
            // mtb_tel_editar
            // 
            this.mtb_tel_editar.Location = new System.Drawing.Point(17, 131);
            this.mtb_tel_editar.Mask = "(99) 0000-0000";
            this.mtb_tel_editar.Name = "mtb_tel_editar";
            this.mtb_tel_editar.Size = new System.Drawing.Size(100, 20);
            this.mtb_tel_editar.TabIndex = 11;
            // 
            // bt_editar
            // 
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar.Image = global::AgendaContato.Properties.Resources.save;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_editar.Location = new System.Drawing.Point(17, 249);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_editar.Size = new System.Drawing.Size(77, 33);
            this.bt_editar.TabIndex = 10;
            this.bt_editar.Text = "Editar";
            this.bt_editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome";
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.pnl_deletar);
            this.pnl_body.Controls.Add(this.pnl_editar);
            this.pnl_body.Controls.Add(this.pnl_inserir);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 49);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(575, 340);
            this.pnl_body.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_body);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 389);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(575, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Contato";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem3.Text = "Editar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem4.Text = "Contato";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem5.Text = "Excluir";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem6.Text = "Contato";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(147, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(274, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "DL AGENDA - DLweb Informática - 2012";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::AgendaContato.Properties.Resources.cllipboard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bt_normal
            // 
            this.bt_normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_normal.BackColor = System.Drawing.Color.Transparent;
            this.bt_normal.FlatAppearance.BorderSize = 0;
            this.bt_normal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.bt_normal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_normal.Font = new System.Drawing.Font("Adobe Myungjo Std M", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_normal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_normal.Location = new System.Drawing.Point(507, 0);
            this.bt_normal.Margin = new System.Windows.Forms.Padding(0);
            this.bt_normal.Name = "bt_normal";
            this.bt_normal.Size = new System.Drawing.Size(33, 24);
            this.bt_normal.TabIndex = 7;
            this.bt_normal.Text = "■";
            this.bt_normal.UseVisualStyleBackColor = false;
            this.bt_normal.Click += new System.EventHandler(this.bt_normal_Click);
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatAppearance.BorderSize = 0;
            this.bt_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.bt_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimizar.Location = new System.Drawing.Point(474, 0);
            this.bt_minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(33, 24);
            this.bt_minimizar.TabIndex = 6;
            this.bt_minimizar.Text = "_";
            this.bt_minimizar.UseVisualStyleBackColor = false;
            this.bt_minimizar.Click += new System.EventHandler(this.bt_minimizar_Click);
            // 
            // bt_maximizar
            // 
            this.bt_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximizar.FlatAppearance.BorderSize = 0;
            this.bt_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.bt_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximizar.Font = new System.Drawing.Font("Adobe Myungjo Std M", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_maximizar.Location = new System.Drawing.Point(507, 0);
            this.bt_maximizar.Margin = new System.Windows.Forms.Padding(0);
            this.bt_maximizar.Name = "bt_maximizar";
            this.bt_maximizar.Size = new System.Drawing.Size(33, 24);
            this.bt_maximizar.TabIndex = 5;
            this.bt_maximizar.Text = "□";
            this.bt_maximizar.UseVisualStyleBackColor = true;
            this.bt_maximizar.Click += new System.EventHandler(this.bt_maximizar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_fechar.FlatAppearance.BorderSize = 0;
            this.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bt_fechar.Location = new System.Drawing.Point(542, 0);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(33, 24);
            this.bt_fechar.TabIndex = 4;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_normal);
            this.Controls.Add(this.bt_minimizar);
            this.Controls.Add(this.bt_maximizar);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_inserir.ResumeLayout(false);
            this.pnl_inserir.PerformLayout();
            this.pnl_deletar.ResumeLayout(false);
            this.pnl_deletar.PerformLayout();
            this.pnl_editar.ResumeLayout(false);
            this.pnl_editar.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_inserir;
        private System.Windows.Forms.ToolStripButton tsb_editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnl_inserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_cel;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_tel;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_deletar;
        private System.Windows.Forms.TextBox tb_cod_excluir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Panel pnl_editar;
        private System.Windows.Forms.TextBox tb_cod_editar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_desc_editar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtb_cel_editar;
        private System.Windows.Forms.TextBox tb_nome_editar;
        private System.Windows.Forms.MaskedTextBox mtb_tel_editar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_maximizar;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Button bt_normal;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}

