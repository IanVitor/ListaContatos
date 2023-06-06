namespace AgendaWF
{
    partial class F_Agenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbNome = new TextBox();
            label3 = new Label();
            txbEmail = new TextBox();
            btInserir = new Button();
            btAlterar = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // txbId
            // 
            txbId.BackColor = Color.FromArgb(51, 51, 61);
            txbId.BorderStyle = BorderStyle.FixedSingle;
            txbId.ForeColor = Color.WhiteSmoke;
            txbId.Location = new Point(80, 12);
            txbId.Name = "txbId";
            txbId.Size = new Size(150, 31);
            txbId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "ID\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.BackColor = Color.FromArgb(51, 51, 61);
            txbNome.BorderStyle = BorderStyle.FixedSingle;
            txbNome.ForeColor = Color.WhiteSmoke;
            txbNome.Location = new Point(80, 60);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(294, 31);
            txbNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(391, 63);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 5;
            label3.Text = "E-mail";
            // 
            // txbEmail
            // 
            txbEmail.BackColor = Color.FromArgb(51, 51, 61);
            txbEmail.BorderStyle = BorderStyle.FixedSingle;
            txbEmail.ForeColor = Color.WhiteSmoke;
            txbEmail.Location = new Point(458, 60);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(382, 31);
            txbEmail.TabIndex = 4;
            // 
            // btInserir
            // 
            btInserir.BackColor = Color.FromArgb(81, 176, 80);
            btInserir.FlatStyle = FlatStyle.Popup;
            btInserir.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btInserir.ForeColor = Color.WhiteSmoke;
            btInserir.Location = new Point(365, 106);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(112, 44);
            btInserir.TabIndex = 6;
            btInserir.Text = "INSERIR";
            btInserir.UseVisualStyleBackColor = false;
            btInserir.Click += btInserir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = Color.FromArgb(81, 176, 80);
            btAlterar.FlatStyle = FlatStyle.Popup;
            btAlterar.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.ForeColor = Color.WhiteSmoke;
            btAlterar.Location = new Point(483, 106);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(112, 44);
            btAlterar.TabIndex = 7;
            btAlterar.Text = "ALTERAR";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(81, 176, 80);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(601, 106);
            button2.Name = "button2";
            button2.Size = new Size(112, 44);
            button2.TabIndex = 8;
            button2.Text = "EXCLUIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(81, 176, 80);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(719, 106);
            button3.Name = "button3";
            button3.Size = new Size(112, 44);
            button3.TabIndex = 9;
            button3.Text = "LOCALIZAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgvDados
            // 
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDados.BackgroundColor = Color.FromArgb(51, 51, 61);
            dgvDados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.GridColor = SystemColors.ActiveCaptionText;
            dgvDados.Location = new Point(12, 165);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDados.RowTemplate.Height = 33;
            dgvDados.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvDados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvDados.ShowEditingIcon = false;
            dgvDados.Size = new Size(828, 332);
            dgvDados.TabIndex = 11;
            // 
            // F_Agenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(850, 509);
            Controls.Add(dgvDados);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(label3);
            Controls.Add(txbEmail);
            Controls.Add(label2);
            Controls.Add(txbNome);
            Controls.Add(label1);
            Controls.Add(txbId);
            ForeColor = SystemColors.Desktop;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Agenda";
            Text = "Agenda - CRUD";
            Load += F_Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbId;
        private Label label1;
        private Label label2;
        private TextBox txbNome;
        private Label label3;
        private TextBox txbEmail;
        private Button btInserir;
        private Button btAlterar;
        private Button button2;
        private Button button3;
        private DataGridView dgvDados;
    }
}