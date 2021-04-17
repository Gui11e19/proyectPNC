
namespace Sistema.Presentacion
{
    partial class FrmPersona
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
            this.components = new System.ComponentModel.Container();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.lblEdad);
            this.tabPage1.Controls.Add(this.lblTelefono);
            this.tabPage1.Controls.Add(this.lblApellidos);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.txtEdad);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.txtApellidos);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(650, 159);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(376, 116);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 24);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(376, 55);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(7, 116);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(88, 24);
            this.lblApellidos.TabIndex = 7;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(467, 116);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(298, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(467, 58);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(298, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(113, 121);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(236, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(647, 520);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListado.Location = new System.Drawing.Point(9, 199);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(756, 293);
            this.dgvListado.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(782, 582);
            this.tabGeneral.TabIndex = 0;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 612);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmPersona";
            this.Text = "Tarea 01 N-capas";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}