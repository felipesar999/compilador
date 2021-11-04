namespace Compilador
{
    partial class frm_main
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
            this.SubTitle = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLexico = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnSemantico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSintactico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.txtSintactico = new System.Windows.Forms.RichTextBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATRON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtConsola = new System.Windows.Forms.RichTextBox();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // SubTitle
            // 
            this.SubTitle.AutoSize = true;
            this.SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SubTitle.ForeColor = System.Drawing.Color.Black;
            this.SubTitle.Location = new System.Drawing.Point(107, 7);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(0, 24);
            this.SubTitle.TabIndex = 6;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gray;
            this.TopPanel.Controls.Add(this.btnSalir);
            this.TopPanel.Controls.Add(this.btnLexico);
            this.TopPanel.Controls.Add(this.btnManual);
            this.TopPanel.Controls.Add(this.btnSemantico);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.btnSintactico);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(952, 68);
            this.TopPanel.TabIndex = 52;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(855, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 38);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLexico
            // 
            this.btnLexico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLexico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLexico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLexico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLexico.FlatAppearance.BorderSize = 0;
            this.btnLexico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLexico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLexico.ForeColor = System.Drawing.Color.White;
            this.btnLexico.Location = new System.Drawing.Point(229, 16);
            this.btnLexico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(128, 38);
            this.btnLexico.TabIndex = 10;
            this.btnLexico.Text = "Léxico";
            this.btnLexico.UseVisualStyleBackColor = false;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.DarkGray;
            this.btnManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManual.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(676, 16);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(128, 38);
            this.btnManual.TabIndex = 46;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnSemantico
            // 
            this.btnSemantico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSemantico.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSemantico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSemantico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSemantico.FlatAppearance.BorderSize = 0;
            this.btnSemantico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemantico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSemantico.ForeColor = System.Drawing.Color.White;
            this.btnSemantico.Location = new System.Drawing.Point(497, 16);
            this.btnSemantico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSemantico.Name = "btnSemantico";
            this.btnSemantico.Size = new System.Drawing.Size(128, 38);
            this.btnSemantico.TabIndex = 11;
            this.btnSemantico.Text = "Semántico";
            this.btnSemantico.UseVisualStyleBackColor = false;
            this.btnSemantico.Click += new System.EventHandler(this.btnSemantico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compilador";
            // 
            // btnSintactico
            // 
            this.btnSintactico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSintactico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSintactico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSintactico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSintactico.FlatAppearance.BorderSize = 0;
            this.btnSintactico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintactico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSintactico.ForeColor = System.Drawing.Color.White;
            this.btnSintactico.Location = new System.Drawing.Point(363, 16);
            this.btnSintactico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(128, 38);
            this.btnSintactico.TabIndex = 12;
            this.btnSintactico.Text = "Sintáctico";
            this.btnSintactico.UseVisualStyleBackColor = false;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consola";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEjemplo);
            this.panel1.Controls.Add(this.txtSintactico);
            this.panel1.Controls.Add(this.dgvTokens);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Controls.Add(this.SubTitle);
            this.panel1.Controls.Add(this.btnAnalizar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtConsola);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 477);
            this.panel1.TabIndex = 53;
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.BackColor = System.Drawing.Color.DimGray;
            this.btnEjemplo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjemplo.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnEjemplo.FlatAppearance.BorderSize = 0;
            this.btnEjemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEjemplo.ForeColor = System.Drawing.Color.White;
            this.btnEjemplo.Location = new System.Drawing.Point(18, 247);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(109, 38);
            this.btnEjemplo.TabIndex = 52;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = false;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // txtSintactico
            // 
            this.txtSintactico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtSintactico.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintactico.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtSintactico.Location = new System.Drawing.Point(523, 35);
            this.txtSintactico.Name = "txtSintactico";
            this.txtSintactico.ReadOnly = true;
            this.txtSintactico.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSintactico.Size = new System.Drawing.Size(415, 206);
            this.txtSintactico.TabIndex = 51;
            this.txtSintactico.Text = "...";
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToDeleteRows = false;
            this.dgvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTokens.BackgroundColor = System.Drawing.Color.White;
            this.dgvTokens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTokens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOKEN,
            this.PATRON});
            this.dgvTokens.Location = new System.Drawing.Point(523, 259);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTokens.Size = new System.Drawing.Size(415, 188);
            this.dgvTokens.TabIndex = 4;
            // 
            // TOKEN
            // 
            this.TOKEN.HeaderText = "TOKEN";
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.ReadOnly = true;
            // 
            // PATRON
            // 
            this.PATRON.HeaderText = "VALOR";
            this.PATRON.Name = "PATRON";
            this.PATRON.ReadOnly = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtOutput.Location = new System.Drawing.Point(10, 294);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(479, 153);
            this.txtOutput.TabIndex = 48;
            this.txtOutput.Text = "<CA> Listo...";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalizar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnalizar.ForeColor = System.Drawing.Color.White;
            this.btnAnalizar.Location = new System.Drawing.Point(360, 247);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(109, 38);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(182, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 38);
            this.btnLimpiar.TabIndex = 45;
            this.btnLimpiar.Text = "Limpiar \r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtConsola
            // 
            this.txtConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.txtConsola.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsola.ForeColor = System.Drawing.Color.White;
            this.txtConsola.Location = new System.Drawing.Point(10, 35);
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtConsola.Size = new System.Drawing.Size(479, 206);
            this.txtConsola.TabIndex = 46;
            this.txtConsola.Text = "<C:> presione LIMPIAR para empezar a  escribir tu codigo....";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 530);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnSintactico;
        private System.Windows.Forms.Button btnSemantico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.RichTextBox txtSintactico;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATRON;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox txtConsola;
    }
}