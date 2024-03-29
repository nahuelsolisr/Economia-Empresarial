﻿namespace SistemaEE.Formularios
{
    partial class Usuarios
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            dgvUsuarios = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            pnl_detalle = new Panel();
            txt_tipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txt_contraseña = new MaterialSkin.Controls.MaterialTextBox();
            btn_editar = new MaterialSkin.Controls.MaterialButton();
            btn_eliminar = new MaterialSkin.Controls.MaterialButton();
            btn_agregar = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            txt_filtrar = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btn_limpiar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            pnl_detalle.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = Color.SteelBlue;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox6.IconColor = Color.SteelBlue;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 48;
            iconPictureBox6.Location = new Point(5, 27);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(48, 50);
            iconPictureBox6.TabIndex = 170;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = Color.SteelBlue;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox3.IconColor = Color.SteelBlue;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 50;
            iconPictureBox3.Location = new Point(5, 107);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(53, 50);
            iconPictureBox3.TabIndex = 168;
            iconPictureBox3.TabStop = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column0, btn_seleccionar, Column1, Column2, Column3 });
            dgvUsuarios.Location = new Point(373, 128);
            dgvUsuarios.Margin = new Padding(4);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(666, 423);
            dgvUsuarios.TabIndex = 159;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Column0
            // 
            Column0.HeaderText = "Id";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Visible = false;
            Column0.Width = 34;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 25;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 95;
            // 
            // Column2
            // 
            Column2.HeaderText = "Contraseña";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 117;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tipo";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = Color.SteelBlue;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox5.IconColor = Color.SteelBlue;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 50;
            iconPictureBox5.Location = new Point(5, 188);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(53, 50);
            iconPictureBox5.TabIndex = 169;
            iconPictureBox5.TabStop = false;
            // 
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(txt_tipoUsuario);
            pnl_detalle.Controls.Add(txt_nombre);
            pnl_detalle.Controls.Add(iconPictureBox5);
            pnl_detalle.Controls.Add(iconPictureBox6);
            pnl_detalle.Controls.Add(iconPictureBox3);
            pnl_detalle.Controls.Add(materialLabel5);
            pnl_detalle.Controls.Add(materialLabel4);
            pnl_detalle.Controls.Add(materialLabel3);
            pnl_detalle.Controls.Add(txt_contraseña);
            pnl_detalle.Location = new Point(12, 128);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(353, 423);
            pnl_detalle.TabIndex = 177;
            // 
            // txt_tipoUsuario
            // 
            txt_tipoUsuario.AutoResize = false;
            txt_tipoUsuario.BackColor = Color.FromArgb(255, 255, 255);
            txt_tipoUsuario.Depth = 0;
            txt_tipoUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            txt_tipoUsuario.DropDownHeight = 174;
            txt_tipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_tipoUsuario.DropDownWidth = 121;
            txt_tipoUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txt_tipoUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txt_tipoUsuario.FormattingEnabled = true;
            txt_tipoUsuario.IntegralHeight = false;
            txt_tipoUsuario.ItemHeight = 43;
            txt_tipoUsuario.Items.AddRange(new object[] { "Administrador", "Empleado" });
            txt_tipoUsuario.Location = new Point(58, 189);
            txt_tipoUsuario.MaxDropDownItems = 4;
            txt_tipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txt_tipoUsuario.Name = "txt_tipoUsuario";
            txt_tipoUsuario.Size = new Size(292, 49);
            txt_tipoUsuario.StartIndex = 0;
            txt_tipoUsuario.TabIndex = 171;
            // 
            // txt_nombre
            // 
            txt_nombre.AnimateReadOnly = false;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Depth = 0;
            txt_nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombre.LeadingIcon = null;
            txt_nombre.Location = new Point(59, 27);
            txt_nombre.MaxLength = 10;
            txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombre.Multiline = false;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(291, 50);
            txt_nombre.TabIndex = 145;
            txt_nombre.Text = "";
            txt_nombre.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(59, 166);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(133, 19);
            materialLabel5.TabIndex = 161;
            materialLabel5.Text = "TIPO DE USUARIO:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 85);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(107, 19);
            materialLabel4.TabIndex = 160;
            materialLabel4.Text = "CONTRASEÑA:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(59, 5);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(70, 19);
            materialLabel3.TabIndex = 159;
            materialLabel3.Text = "NOMBRE:";
            // 
            // txt_contraseña
            // 
            txt_contraseña.AnimateReadOnly = false;
            txt_contraseña.BorderStyle = BorderStyle.None;
            txt_contraseña.Depth = 0;
            txt_contraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_contraseña.LeadingIcon = null;
            txt_contraseña.Location = new Point(58, 107);
            txt_contraseña.MaxLength = 5;
            txt_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            txt_contraseña.Multiline = false;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Password = true;
            txt_contraseña.Size = new Size(292, 50);
            txt_contraseña.TabIndex = 149;
            txt_contraseña.Text = "";
            txt_contraseña.TrailingIcon = null;
            // 
            // btn_editar
            // 
            btn_editar.AutoSize = false;
            btn_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_editar.Depth = 0;
            btn_editar.HighEmphasis = true;
            btn_editar.Icon = (Image)resources.GetObject("btn_editar.Icon");
            btn_editar.Location = new Point(133, 575);
            btn_editar.Margin = new Padding(4, 6, 4, 6);
            btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_editar.Name = "btn_editar";
            btn_editar.NoAccentTextColor = Color.Empty;
            btn_editar.Size = new Size(113, 36);
            btn_editar.TabIndex = 158;
            btn_editar.Text = "Editar";
            btn_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_editar.UseAccentColor = false;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.AutoSize = false;
            btn_eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_eliminar.Depth = 0;
            btn_eliminar.HighEmphasis = true;
            btn_eliminar.Icon = (Image)resources.GetObject("btn_eliminar.Icon");
            btn_eliminar.Location = new Point(252, 575);
            btn_eliminar.Margin = new Padding(4, 6, 4, 6);
            btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.NoAccentTextColor = Color.Empty;
            btn_eliminar.Size = new Size(113, 36);
            btn_eliminar.TabIndex = 154;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_eliminar.UseAccentColor = false;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.AutoSize = false;
            btn_agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregar.Depth = 0;
            btn_agregar.HighEmphasis = true;
            btn_agregar.Icon = (Image)resources.GetObject("btn_agregar.Icon");
            btn_agregar.Location = new Point(12, 575);
            btn_agregar.Margin = new Padding(4, 6, 4, 6);
            btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregar.Name = "btn_agregar";
            btn_agregar.NoAccentTextColor = Color.Empty;
            btn_agregar.Size = new Size(113, 36);
            btn_agregar.TabIndex = 152;
            btn_agregar.Text = "Agregar";
            btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregar.UseAccentColor = false;
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_filtrar);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(10, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 54);
            panel1.TabIndex = 178;
            // 
            // txt_filtrar
            // 
            txt_filtrar.AnimateReadOnly = false;
            txt_filtrar.BorderStyle = BorderStyle.None;
            txt_filtrar.Depth = 0;
            txt_filtrar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_filtrar.LeadingIcon = null;
            txt_filtrar.Location = new Point(651, 4);
            txt_filtrar.MaxLength = 50;
            txt_filtrar.MouseState = MaterialSkin.MouseState.OUT;
            txt_filtrar.Multiline = false;
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(316, 50);
            txt_filtrar.TabIndex = 152;
            txt_filtrar.Text = "";
            txt_filtrar.TrailingIcon = null;
            txt_filtrar.TextChanged += txt_filtrar_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 5);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(170, 19);
            materialLabel1.TabIndex = 150;
            materialLabel1.Text = "DETALLE DEL USUARIO";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(375, 5);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(147, 19);
            materialLabel2.TabIndex = 151;
            materialLabel2.Text = "LISTA DE USUARIOS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(973, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(53, 48);
            iconPictureBox1.TabIndex = 141;
            iconPictureBox1.TabStop = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.AutoSize = false;
            btn_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_limpiar.Depth = 0;
            btn_limpiar.HighEmphasis = true;
            btn_limpiar.Icon = (Image)resources.GetObject("btn_limpiar.Icon");
            btn_limpiar.Location = new Point(373, 575);
            btn_limpiar.Margin = new Padding(4, 6, 4, 6);
            btn_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.NoAccentTextColor = Color.Empty;
            btn_limpiar.Size = new Size(113, 36);
            btn_limpiar.TabIndex = 182;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_limpiar.UseAccentColor = false;
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 620);
            Controls.Add(btn_limpiar);
            Controls.Add(panel1);
            Controls.Add(btn_editar);
            Controls.Add(pnl_detalle);
            Controls.Add(dgvUsuarios);
            Controls.Add(btn_agregar);
            Controls.Add(btn_eliminar);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Usuarios :.";
            FormClosed += Usuarios_FormClosed;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private DataGridView dgvUsuarios;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel pnl_detalle;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialButton btn_editar;
        private MaterialSkin.Controls.MaterialButton btn_eliminar;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_contraseña;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txt_filtrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialComboBox txt_tipoUsuario;
        private MaterialSkin.Controls.MaterialButton btn_limpiar;
    }
}