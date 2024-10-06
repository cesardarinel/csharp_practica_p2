using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosDiversos
{
    partial class Nomina
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
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suendoNeto = new System.Windows.Forms.TextBox();
            this.totalDescuento = new System.Windows.Forms.TextBox();
            this.isr = new System.Windows.Forms.TextBox();
            this.ars = new System.Windows.Forms.TextBox();
            this.afp = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gridnomina = new System.Windows.Forms.DataGridView();
            this.codempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suebasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afpempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isrempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdeempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suenetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2DataSet = new ProyectosDiversos.P2DataSet();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.label1231 = new System.Windows.Forms.Label();
            this.conexionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridnomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__13_;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(579, 290);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 43);
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ProyectosDiversos.Properties.Resources.borrar;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(421, 290);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 43);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__4_;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(347, 290);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 43);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__9_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(273, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 43);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__2_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(199, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 43);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__11_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(128, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_21_PM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(60, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // suendoNeto
            // 
            this.suendoNeto.Enabled = false;
            this.suendoNeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.suendoNeto.Location = new System.Drawing.Point(181, 236);
            this.suendoNeto.Name = "suendoNeto";
            this.suendoNeto.Size = new System.Drawing.Size(138, 29);
            this.suendoNeto.TabIndex = 55;
            // 
            // totalDescuento
            // 
            this.totalDescuento.Enabled = false;
            this.totalDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalDescuento.Location = new System.Drawing.Point(181, 211);
            this.totalDescuento.Name = "totalDescuento";
            this.totalDescuento.Size = new System.Drawing.Size(138, 29);
            this.totalDescuento.TabIndex = 54;
            // 
            // isr
            // 
            this.isr.Enabled = false;
            this.isr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.isr.Location = new System.Drawing.Point(181, 177);
            this.isr.Name = "isr";
            this.isr.Size = new System.Drawing.Size(138, 29);
            this.isr.TabIndex = 53;
            // 
            // ars
            // 
            this.ars.Enabled = false;
            this.ars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ars.Location = new System.Drawing.Point(181, 152);
            this.ars.Name = "ars";
            this.ars.Size = new System.Drawing.Size(138, 29);
            this.ars.TabIndex = 52;
            // 
            // afp
            // 
            this.afp.Enabled = false;
            this.afp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.afp.Location = new System.Drawing.Point(181, 127);
            this.afp.Name = "afp";
            this.afp.Size = new System.Drawing.Size(138, 29);
            this.afp.TabIndex = 51;
            // 
            // sueldo
            // 
            this.sueldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sueldo.Location = new System.Drawing.Point(181, 101);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(138, 29);
            this.sueldo.TabIndex = 50;
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.apellido.Location = new System.Drawing.Point(181, 76);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(138, 29);
            this.apellido.TabIndex = 49;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nombre.Location = new System.Drawing.Point(181, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(138, 29);
            this.nombre.TabIndex = 48;
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.codigo.Location = new System.Drawing.Point(181, 26);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(138, 29);
            this.codigo.TabIndex = 47;
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(72, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 21);
            this.label15.TabIndex = 44;
            this.label15.Text = "S. Neto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(72, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "T. DESC.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(72, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 21);
            this.label17.TabIndex = 42;
            this.label17.Text = "IRS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(72, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 21);
            this.label18.TabIndex = 41;
            this.label18.Text = "ARS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(72, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 21);
            this.label19.TabIndex = 40;
            this.label19.Text = "AFP";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(72, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 21);
            this.label20.TabIndex = 39;
            this.label20.Text = "Sueldo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(72, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 21);
            this.label21.TabIndex = 38;
            this.label21.Text = "Nombre";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(72, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 21);
            this.label22.TabIndex = 37;
            this.label22.Text = "Apellidos";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(72, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 21);
            this.label23.TabIndex = 36;
            this.label23.Text = "Codigo";
            // 
            // gridnomina
            // 
            this.gridnomina.AutoGenerateColumns = false;
            this.gridnomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codempDataGridViewTextBoxColumn,
            this.nomempDataGridViewTextBoxColumn,
            this.apeempDataGridViewTextBoxColumn,
            this.suebasDataGridViewTextBoxColumn,
            this.afpempDataGridViewTextBoxColumn,
            this.arsempDataGridViewTextBoxColumn,
            this.isrempDataGridViewTextBoxColumn,
            this.tdeempDataGridViewTextBoxColumn,
            this.suenetDataGridViewTextBoxColumn});
            this.gridnomina.DataSource = this.nominaBindingSource;
            this.gridnomina.Location = new System.Drawing.Point(347, 51);
            this.gridnomina.Name = "gridnomina";
            this.gridnomina.Size = new System.Drawing.Size(493, 210);
            this.gridnomina.TabIndex = 56;
            // 
            // codempDataGridViewTextBoxColumn
            // 
            this.codempDataGridViewTextBoxColumn.DataPropertyName = "cod_emp";
            this.codempDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codempDataGridViewTextBoxColumn.Name = "codempDataGridViewTextBoxColumn";
            // 
            // nomempDataGridViewTextBoxColumn
            // 
            this.nomempDataGridViewTextBoxColumn.DataPropertyName = "nom_emp";
            this.nomempDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomempDataGridViewTextBoxColumn.Name = "nomempDataGridViewTextBoxColumn";
            // 
            // apeempDataGridViewTextBoxColumn
            // 
            this.apeempDataGridViewTextBoxColumn.DataPropertyName = "ape_emp";
            this.apeempDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apeempDataGridViewTextBoxColumn.Name = "apeempDataGridViewTextBoxColumn";
            // 
            // suebasDataGridViewTextBoxColumn
            // 
            this.suebasDataGridViewTextBoxColumn.DataPropertyName = "sue_bas";
            this.suebasDataGridViewTextBoxColumn.HeaderText = "Sueldo";
            this.suebasDataGridViewTextBoxColumn.Name = "suebasDataGridViewTextBoxColumn";
            // 
            // afpempDataGridViewTextBoxColumn
            // 
            this.afpempDataGridViewTextBoxColumn.DataPropertyName = "afp_emp";
            this.afpempDataGridViewTextBoxColumn.HeaderText = "AFP";
            this.afpempDataGridViewTextBoxColumn.Name = "afpempDataGridViewTextBoxColumn";
            // 
            // arsempDataGridViewTextBoxColumn
            // 
            this.arsempDataGridViewTextBoxColumn.DataPropertyName = "ars_emp";
            this.arsempDataGridViewTextBoxColumn.HeaderText = "ARS";
            this.arsempDataGridViewTextBoxColumn.Name = "arsempDataGridViewTextBoxColumn";
            // 
            // isrempDataGridViewTextBoxColumn
            // 
            this.isrempDataGridViewTextBoxColumn.DataPropertyName = "isr_emp";
            this.isrempDataGridViewTextBoxColumn.HeaderText = "ISR";
            this.isrempDataGridViewTextBoxColumn.Name = "isrempDataGridViewTextBoxColumn";
            // 
            // tdeempDataGridViewTextBoxColumn
            // 
            this.tdeempDataGridViewTextBoxColumn.DataPropertyName = "tde_emp";
            this.tdeempDataGridViewTextBoxColumn.HeaderText = "T. DESC.";
            this.tdeempDataGridViewTextBoxColumn.Name = "tdeempDataGridViewTextBoxColumn";
            // 
            // suenetDataGridViewTextBoxColumn
            // 
            this.suenetDataGridViewTextBoxColumn.DataPropertyName = "sue_net";
            this.suenetDataGridViewTextBoxColumn.HeaderText = "S. NETO";
            this.suenetDataGridViewTextBoxColumn.Name = "suenetDataGridViewTextBoxColumn";
            // 
            // nominaBindingSource
            // 
            this.nominaBindingSource.DataMember = "nomina";
            this.nominaBindingSource.DataSource = this.p2DataSet;
            // 
            // p2DataSet
            // 
            this.p2DataSet.DataSetName = "p2DataSet";
            this.p2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busqueda
            // 
            this.busqueda.Location = new System.Drawing.Point(409, 30);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(348, 20);
            this.busqueda.TabIndex = 57;
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1231
            // 
            this.label1231.AutoSize = true;
            this.label1231.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1231.Location = new System.Drawing.Point(347, 33);
            this.label1231.Name = "label1231";
            this.label1231.Size = new System.Drawing.Size(60, 21);
            this.label1231.TabIndex = 58;
            this.label1231.Text = "Buscar";
            // 
            // conexionBindingSource1
            // 
            this.conexionBindingSource1.DataSource = typeof(ProyectosDiversos.Conexion);
            // 
            // conexionBindingSource
            // 
            this.conexionBindingSource.DataSource = typeof(ProyectosDiversos.Conexion);
            // 
            // conexionBindingSource2
            // 
            this.conexionBindingSource2.DataSource = typeof(ProyectosDiversos.Conexion);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 361);
            this.Controls.Add(this.label1231);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.gridnomina);
            this.Controls.Add(this.suendoNeto);
            this.Controls.Add(this.totalDescuento);
            this.Controls.Add(this.isr);
            this.Controls.Add(this.ars);
            this.Controls.Add(this.afp);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridnomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox suendoNeto;
        private TextBox totalDescuento;
        private TextBox isr;
        private TextBox ars;
        private TextBox afp;
        private TextBox sueldo;
        private TextBox apellido;
        private TextBox nombre;
        private TextBox codigo;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private BindingSource conexionBindingSource1;
        private BindingSource conexionBindingSource;
        private BindingSource conexionBindingSource2;
        private DataGridView gridnomina;
        private TextBox busqueda;
        private Label label1231;
        private P2DataSet p2DataSet;
        private BindingSource nominaBindingSource;
        private DataGridViewTextBoxColumn codempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apeempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suebasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn afpempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arsempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isrempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tdeempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suenetDataGridViewTextBoxColumn;
    }
}