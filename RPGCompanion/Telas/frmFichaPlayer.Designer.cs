
namespace RPGCompanion
{
    partial class frmFichaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichaPlayer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblModCarisma = new System.Windows.Forms.Label();
            this.lblModSabedoria = new System.Windows.Forms.Label();
            this.lblModIntelecto = new System.Windows.Forms.Label();
            this.lblModConstituicao = new System.Windows.Forms.Label();
            this.lblModDestreza = new System.Windows.Forms.Label();
            this.lblModForca = new System.Windows.Forms.Label();
            this.lblCaracteristica = new System.Windows.Forms.Label();
            this.lblSabedoria = new System.Windows.Forms.Label();
            this.lblIntelecto = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.lblConstituicao = new System.Windows.Forms.Label();
            this.lblForca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOuro = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblAlcunha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabHabilidades = new System.Windows.Forms.TabPage();
            this.dgvHabilidades = new System.Windows.Forms.DataGridView();
            this.tabItens = new System.Windows.Forms.TabPage();
            this.tabHistoria = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.habilidadeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dificuldadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHabilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeral);
            this.tabControl.Controls.Add(this.tabHabilidades);
            this.tabControl.Controls.Add(this.tabItens);
            this.tabControl.Controls.Add(this.tabHistoria);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(662, 660);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.Color.Chocolate;
            this.tabGeral.Controls.Add(this.pictureBox2);
            this.tabGeral.Controls.Add(this.pictureBox1);
            this.tabGeral.Controls.Add(this.groupBox2);
            this.tabGeral.Controls.Add(this.groupBox1);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(654, 634);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Geral";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(349, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Controls.Add(this.lblModCarisma);
            this.groupBox2.Controls.Add(this.lblModSabedoria);
            this.groupBox2.Controls.Add(this.lblModIntelecto);
            this.groupBox2.Controls.Add(this.lblModConstituicao);
            this.groupBox2.Controls.Add(this.lblModDestreza);
            this.groupBox2.Controls.Add(this.lblModForca);
            this.groupBox2.Controls.Add(this.lblCaracteristica);
            this.groupBox2.Controls.Add(this.lblSabedoria);
            this.groupBox2.Controls.Add(this.lblIntelecto);
            this.groupBox2.Controls.Add(this.lblDestreza);
            this.groupBox2.Controls.Add(this.lblConstituicao);
            this.groupBox2.Controls.Add(this.lblForca);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(8, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atributos / modificadores";
            // 
            // lblModCarisma
            // 
            this.lblModCarisma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModCarisma.AutoSize = true;
            this.lblModCarisma.Location = new System.Drawing.Point(233, 262);
            this.lblModCarisma.Name = "lblModCarisma";
            this.lblModCarisma.Size = new System.Drawing.Size(41, 20);
            this.lblModCarisma.TabIndex = 17;
            this.lblModCarisma.Text = "(+5)";
            // 
            // lblModSabedoria
            // 
            this.lblModSabedoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModSabedoria.AutoSize = true;
            this.lblModSabedoria.Location = new System.Drawing.Point(233, 217);
            this.lblModSabedoria.Name = "lblModSabedoria";
            this.lblModSabedoria.Size = new System.Drawing.Size(41, 20);
            this.lblModSabedoria.TabIndex = 16;
            this.lblModSabedoria.Text = "(+5)";
            // 
            // lblModIntelecto
            // 
            this.lblModIntelecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModIntelecto.AutoSize = true;
            this.lblModIntelecto.Location = new System.Drawing.Point(233, 172);
            this.lblModIntelecto.Name = "lblModIntelecto";
            this.lblModIntelecto.Size = new System.Drawing.Size(41, 20);
            this.lblModIntelecto.TabIndex = 15;
            this.lblModIntelecto.Text = "(+5)";
            // 
            // lblModConstituicao
            // 
            this.lblModConstituicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModConstituicao.AutoSize = true;
            this.lblModConstituicao.Location = new System.Drawing.Point(233, 127);
            this.lblModConstituicao.Name = "lblModConstituicao";
            this.lblModConstituicao.Size = new System.Drawing.Size(41, 20);
            this.lblModConstituicao.TabIndex = 14;
            this.lblModConstituicao.Text = "(+5)";
            // 
            // lblModDestreza
            // 
            this.lblModDestreza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModDestreza.AutoSize = true;
            this.lblModDestreza.Location = new System.Drawing.Point(233, 82);
            this.lblModDestreza.Name = "lblModDestreza";
            this.lblModDestreza.Size = new System.Drawing.Size(41, 20);
            this.lblModDestreza.TabIndex = 13;
            this.lblModDestreza.Text = "(+5)";
            // 
            // lblModForca
            // 
            this.lblModForca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModForca.AutoSize = true;
            this.lblModForca.Location = new System.Drawing.Point(233, 37);
            this.lblModForca.Name = "lblModForca";
            this.lblModForca.Size = new System.Drawing.Size(41, 20);
            this.lblModForca.TabIndex = 12;
            this.lblModForca.Text = "(+5)";
            // 
            // lblCaracteristica
            // 
            this.lblCaracteristica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaracteristica.AutoSize = true;
            this.lblCaracteristica.Location = new System.Drawing.Point(198, 262);
            this.lblCaracteristica.Name = "lblCaracteristica";
            this.lblCaracteristica.Size = new System.Drawing.Size(29, 20);
            this.lblCaracteristica.TabIndex = 11;
            this.lblCaracteristica.Text = "99";
            // 
            // lblSabedoria
            // 
            this.lblSabedoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSabedoria.AutoSize = true;
            this.lblSabedoria.Location = new System.Drawing.Point(198, 217);
            this.lblSabedoria.Name = "lblSabedoria";
            this.lblSabedoria.Size = new System.Drawing.Size(29, 20);
            this.lblSabedoria.TabIndex = 10;
            this.lblSabedoria.Text = "99";
            // 
            // lblIntelecto
            // 
            this.lblIntelecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntelecto.AutoSize = true;
            this.lblIntelecto.Location = new System.Drawing.Point(198, 172);
            this.lblIntelecto.Name = "lblIntelecto";
            this.lblIntelecto.Size = new System.Drawing.Size(29, 20);
            this.lblIntelecto.TabIndex = 9;
            this.lblIntelecto.Text = "99";
            // 
            // lblDestreza
            // 
            this.lblDestreza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(198, 82);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(29, 20);
            this.lblDestreza.TabIndex = 8;
            this.lblDestreza.Text = "99";
            // 
            // lblConstituicao
            // 
            this.lblConstituicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConstituicao.AutoSize = true;
            this.lblConstituicao.Location = new System.Drawing.Point(198, 127);
            this.lblConstituicao.Name = "lblConstituicao";
            this.lblConstituicao.Size = new System.Drawing.Size(29, 20);
            this.lblConstituicao.TabIndex = 7;
            this.lblConstituicao.Text = "99";
            // 
            // lblForca
            // 
            this.lblForca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForca.AutoSize = true;
            this.lblForca.Location = new System.Drawing.Point(198, 37);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(29, 20);
            this.lblForca.TabIndex = 6;
            this.lblForca.Text = "99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carisma (CAR)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sabedoria (SAB)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intelecto (INT)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Constituição (CON)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destreza (DES)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Força (FOR)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.lblOuro);
            this.groupBox1.Controls.Add(this.lblClasse);
            this.groupBox1.Controls.Add(this.lblVida);
            this.groupBox1.Controls.Add(this.lblAlcunha);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(326, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // lblOuro
            // 
            this.lblOuro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOuro.AutoSize = true;
            this.lblOuro.Location = new System.Drawing.Point(6, 135);
            this.lblOuro.Name = "lblOuro";
            this.lblOuro.Size = new System.Drawing.Size(78, 20);
            this.lblOuro.TabIndex = 4;
            this.lblOuro.Text = "Ouro: 50";
            // 
            // lblClasse
            // 
            this.lblClasse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(6, 83);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(75, 20);
            this.lblClasse.TabIndex = 3;
            this.lblClasse.Text = "Duelista";
            // 
            // lblVida
            // 
            this.lblVida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(6, 109);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(120, 20);
            this.lblVida.TabIndex = 2;
            this.lblVida.Text = "Vida: 100/100";
            // 
            // lblAlcunha
            // 
            this.lblAlcunha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlcunha.AutoSize = true;
            this.lblAlcunha.Location = new System.Drawing.Point(6, 57);
            this.lblAlcunha.Name = "lblAlcunha";
            this.lblAlcunha.Size = new System.Drawing.Size(171, 20);
            this.lblAlcunha.TabIndex = 1;
            this.lblAlcunha.Text = "Guterinha Balaclava";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(150, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Gustavo Matheus";
            // 
            // tabHabilidades
            // 
            this.tabHabilidades.BackColor = System.Drawing.Color.SaddleBrown;
            this.tabHabilidades.Controls.Add(this.dgvHabilidades);
            this.tabHabilidades.Location = new System.Drawing.Point(4, 22);
            this.tabHabilidades.Name = "tabHabilidades";
            this.tabHabilidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabHabilidades.Size = new System.Drawing.Size(654, 634);
            this.tabHabilidades.TabIndex = 3;
            this.tabHabilidades.Text = "Habilidades";
            // 
            // dgvHabilidades
            // 
            this.dgvHabilidades.AutoGenerateColumns = false;
            this.dgvHabilidades.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvHabilidades.CausesValidation = false;
            this.dgvHabilidades.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabilidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dificuldadeDataGridViewTextBoxColumn});
            this.dgvHabilidades.DataSource = this.habilidadeModelBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabilidades.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHabilidades.Enabled = false;
            this.dgvHabilidades.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvHabilidades.Location = new System.Drawing.Point(8, 6);
            this.dgvHabilidades.MultiSelect = false;
            this.dgvHabilidades.Name = "dgvHabilidades";
            this.dgvHabilidades.ReadOnly = true;
            this.dgvHabilidades.RowHeadersVisible = false;
            this.dgvHabilidades.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabilidades.RowTemplate.Height = 50;
            this.dgvHabilidades.RowTemplate.ReadOnly = true;
            this.dgvHabilidades.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabilidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHabilidades.Size = new System.Drawing.Size(638, 241);
            this.dgvHabilidades.TabIndex = 0;
            this.dgvHabilidades.VirtualMode = true;
            // 
            // tabItens
            // 
            this.tabItens.Location = new System.Drawing.Point(4, 22);
            this.tabItens.Name = "tabItens";
            this.tabItens.Padding = new System.Windows.Forms.Padding(3);
            this.tabItens.Size = new System.Drawing.Size(654, 634);
            this.tabItens.TabIndex = 1;
            this.tabItens.Text = "Itens";
            this.tabItens.UseVisualStyleBackColor = true;
            // 
            // tabHistoria
            // 
            this.tabHistoria.Location = new System.Drawing.Point(4, 22);
            this.tabHistoria.Name = "tabHistoria";
            this.tabHistoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoria.Size = new System.Drawing.Size(654, 634);
            this.tabHistoria.TabIndex = 2;
            this.tabHistoria.Text = "História";
            this.tabHistoria.UseVisualStyleBackColor = true;
            // 
            // habilidadeModelBindingSource
            // 
            this.habilidadeModelBindingSource.DataSource = typeof(RPGCompanion.Classes.HabilidadeModel);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomeDataGridViewTextBoxColumn.FillWeight = 25F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dificuldadeDataGridViewTextBoxColumn
            // 
            this.dificuldadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dificuldadeDataGridViewTextBoxColumn.DataPropertyName = "Dificuldade";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dificuldadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dificuldadeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dificuldadeDataGridViewTextBoxColumn.HeaderText = "Dificuldade";
            this.dificuldadeDataGridViewTextBoxColumn.Name = "dificuldadeDataGridViewTextBoxColumn";
            this.dificuldadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dificuldadeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmFichaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(662, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "frmFichaPlayer";
            this.Text = "Ficha do Jogador";
            this.tabControl.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHabilidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilidadeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TabPage tabItens;
        private System.Windows.Forms.TabPage tabHistoria;
        private System.Windows.Forms.TabPage tabHabilidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlcunha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblOuro;
        private System.Windows.Forms.Label lblCaracteristica;
        private System.Windows.Forms.Label lblSabedoria;
        private System.Windows.Forms.Label lblIntelecto;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Label lblConstituicao;
        private System.Windows.Forms.Label lblForca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblModCarisma;
        private System.Windows.Forms.Label lblModSabedoria;
        private System.Windows.Forms.Label lblModIntelecto;
        private System.Windows.Forms.Label lblModConstituicao;
        private System.Windows.Forms.Label lblModDestreza;
        private System.Windows.Forms.Label lblModForca;
        private System.Windows.Forms.DataGridView dgvHabilidades;
        private System.Windows.Forms.BindingSource habilidadeModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dificuldadeDataGridViewTextBoxColumn;
    }
}

