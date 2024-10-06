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
    partial class Notas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.asignatura = new System.Windows.Forms.TextBox();
            this.poe = new System.Windows.Forms.TextBox();
            this.pf = new System.Windows.Forms.TextBox();
            this.va = new System.Windows.Forms.TextBox();
            this.ap = new System.Windows.Forms.TextBox();
            this.pef = new System.Windows.Forms.TextBox();
            this.condicion = new System.Windows.Forms.TextBox();
            this.notaLiteral = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.notaFinal = new System.Windows.Forms.TextBox();
            this.gridnotas = new System.Windows.Forms.DataGridView();
            this.mat_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asi_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P2DataSet = new ProyectosDiversos.P2DataSet();
            this.calificacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.TextBox();
            this.conexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridnotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(51, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(51, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asignatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "POE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(51, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "PF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(51, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "VA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "AP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(51, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "PEF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(51, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Condicion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(51, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nota Literal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_21_PM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(83, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__11_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(151, 361);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__2_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(222, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 43);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__9_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(297, 361);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 43);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__4_;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(370, 361);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 43);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ProyectosDiversos.Properties.Resources.borrar;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(444, 361);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 43);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ProyectosDiversos.Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__13_;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(569, 361);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 43);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // matricula
            // 
            this.matricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.matricula.Location = new System.Drawing.Point(160, 21);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(138, 29);
            this.matricula.TabIndex = 18;
            this.matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matricula_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nombre.Location = new System.Drawing.Point(160, 46);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(138, 29);
            this.nombre.TabIndex = 19;
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.apellido.Location = new System.Drawing.Point(160, 71);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(138, 29);
            this.apellido.TabIndex = 20;
            // 
            // asignatura
            // 
            this.asignatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.asignatura.Location = new System.Drawing.Point(160, 96);
            this.asignatura.Name = "asignatura";
            this.asignatura.Size = new System.Drawing.Size(138, 29);
            this.asignatura.TabIndex = 21;
            // 
            // poe
            // 
            this.poe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.poe.Location = new System.Drawing.Point(160, 121);
            this.poe.Name = "poe";
            this.poe.Size = new System.Drawing.Size(138, 29);
            this.poe.TabIndex = 22;
            // 
            // pf
            // 
            this.pf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.pf.Location = new System.Drawing.Point(160, 146);
            this.pf.Name = "pf";
            this.pf.Size = new System.Drawing.Size(138, 29);
            this.pf.TabIndex = 23;
            // 
            // va
            // 
            this.va.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.va.Location = new System.Drawing.Point(160, 172);
            this.va.Name = "va";
            this.va.Size = new System.Drawing.Size(138, 29);
            this.va.TabIndex = 24;
            // 
            // ap
            // 
            this.ap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ap.Location = new System.Drawing.Point(160, 197);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(138, 29);
            this.ap.TabIndex = 25;
            // 
            // pef
            // 
            this.pef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.pef.Location = new System.Drawing.Point(160, 222);
            this.pef.Name = "pef";
            this.pef.Size = new System.Drawing.Size(138, 29);
            this.pef.TabIndex = 26;
            // 
            // condicion
            // 
            this.condicion.Enabled = false;
            this.condicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.condicion.Location = new System.Drawing.Point(160, 308);
            this.condicion.Name = "condicion";
            this.condicion.Size = new System.Drawing.Size(138, 33);
            this.condicion.TabIndex = 27;
            // 
            // notaLiteral
            // 
            this.notaLiteral.Enabled = false;
            this.notaLiteral.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.notaLiteral.Location = new System.Drawing.Point(160, 282);
            this.notaLiteral.Name = "notaLiteral";
            this.notaLiteral.Size = new System.Drawing.Size(138, 33);
            this.notaLiteral.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(51, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nota Final";
            // 
            // notaFinal
            // 
            this.notaFinal.Enabled = false;
            this.notaFinal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.notaFinal.Location = new System.Drawing.Point(160, 257);
            this.notaFinal.Name = "notaFinal";
            this.notaFinal.Size = new System.Drawing.Size(138, 33);
            this.notaFinal.TabIndex = 30;
            // 
            // gridnotas
            // 
            this.gridnotas.AutoGenerateColumns = false;
            this.gridnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mat_est,
            this.nom_est,
            this.ape_est,
            this.asi_est,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.L,
            this.nf,
            this.con,
            this.matestDataGridViewTextBoxColumn,
            this.nomestDataGridViewTextBoxColumn,
            this.apeestDataGridViewTextBoxColumn,
            this.asiestDataGridViewTextBoxColumn,
            this.poeDataGridViewTextBoxColumn,
            this.pfDataGridViewTextBoxColumn,
            this.apDataGridViewTextBoxColumn,
            this.vaDataGridViewTextBoxColumn,
            this.pefDataGridViewTextBoxColumn,
            this.nfDataGridViewTextBoxColumn,
            this.lDataGridViewTextBoxColumn,
            this.conDataGridViewTextBoxColumn});
            this.gridnotas.DataSource = this.calificacionBindingSource;
            this.gridnotas.Location = new System.Drawing.Point(330, 46);
            this.gridnotas.Name = "gridnotas";
            this.gridnotas.Size = new System.Drawing.Size(587, 290);
            this.gridnotas.TabIndex = 31;
            // 
            // mat_est
            // 
            this.mat_est.DataPropertyName = "mat_est";
            this.mat_est.HeaderText = "Matricula";
            this.mat_est.Name = "mat_est";
            // 
            // nom_est
            // 
            this.nom_est.DataPropertyName = "nom_est";
            this.nom_est.HeaderText = "Nombre";
            this.nom_est.Name = "nom_est";
            // 
            // ape_est
            // 
            this.ape_est.DataPropertyName = "ape_est";
            this.ape_est.HeaderText = "Apellido";
            this.ape_est.Name = "ape_est";
            // 
            // asi_est
            // 
            this.asi_est.DataPropertyName = "asi_est";
            this.asi_est.HeaderText = "Asignatura";
            this.asi_est.Name = "asi_est";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "poe";
            this.dataGridViewTextBoxColumn1.HeaderText = "POE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pf";
            this.dataGridViewTextBoxColumn2.HeaderText = "PF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "va";
            this.dataGridViewTextBoxColumn4.HeaderText = "VA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ap";
            this.dataGridViewTextBoxColumn3.HeaderText = "AP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pef";
            this.dataGridViewTextBoxColumn5.HeaderText = "PEF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // L
            // 
            this.L.DataPropertyName = "L";
            this.L.HeaderText = "Nota Literal";
            this.L.Name = "L";
            // 
            // nf
            // 
            this.nf.DataPropertyName = "nf";
            this.nf.HeaderText = "Nota Final";
            this.nf.Name = "nf";
            // 
            // con
            // 
            this.con.DataPropertyName = "con";
            this.con.HeaderText = "Condicion";
            this.con.Name = "con";
            // 
            // calificacionBindingSource
            // 
            this.calificacionBindingSource.DataMember = "Calificacion";
            this.calificacionBindingSource.DataSource = this.P2DataSet;
            // 
            // p2DataSet
            // 
            this.P2DataSet.DataSetName = "P2DataSet";
            this.P2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calificacionBindingSource1
            // 
            this.calificacionBindingSource1.DataMember = "Calificacion";
            this.calificacionBindingSource1.DataSource = this.P2DataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(330, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Buscar";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(386, 28);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(451, 20);
            this.buscar.TabIndex = 33;
            this.buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_KeyPress);
            // 
            // calificacionTableAdapter
            // 

            // 
            // conexionBindingSource
            // 
            this.conexionBindingSource.DataSource = typeof(ProyectosDiversos.Conexion);
            // 
            // matestDataGridViewTextBoxColumn
            // 
            this.matestDataGridViewTextBoxColumn.DataPropertyName = "mat_est";
            this.matestDataGridViewTextBoxColumn.HeaderText = "mat_est";
            this.matestDataGridViewTextBoxColumn.Name = "matestDataGridViewTextBoxColumn";
            // 
            // nomestDataGridViewTextBoxColumn
            // 
            this.nomestDataGridViewTextBoxColumn.DataPropertyName = "nom_est";
            this.nomestDataGridViewTextBoxColumn.HeaderText = "nom_est";
            this.nomestDataGridViewTextBoxColumn.Name = "nomestDataGridViewTextBoxColumn";
            // 
            // apeestDataGridViewTextBoxColumn
            // 
            this.apeestDataGridViewTextBoxColumn.DataPropertyName = "ape_est";
            this.apeestDataGridViewTextBoxColumn.HeaderText = "ape_est";
            this.apeestDataGridViewTextBoxColumn.Name = "apeestDataGridViewTextBoxColumn";
            // 
            // asiestDataGridViewTextBoxColumn
            // 
            this.asiestDataGridViewTextBoxColumn.DataPropertyName = "asi_est";
            this.asiestDataGridViewTextBoxColumn.HeaderText = "asi_est";
            this.asiestDataGridViewTextBoxColumn.Name = "asiestDataGridViewTextBoxColumn";
            // 
            // poeDataGridViewTextBoxColumn
            // 
            this.poeDataGridViewTextBoxColumn.DataPropertyName = "poe";
            this.poeDataGridViewTextBoxColumn.HeaderText = "poe";
            this.poeDataGridViewTextBoxColumn.Name = "poeDataGridViewTextBoxColumn";
            // 
            // pfDataGridViewTextBoxColumn
            // 
            this.pfDataGridViewTextBoxColumn.DataPropertyName = "pf";
            this.pfDataGridViewTextBoxColumn.HeaderText = "pf";
            this.pfDataGridViewTextBoxColumn.Name = "pfDataGridViewTextBoxColumn";
            // 
            // apDataGridViewTextBoxColumn
            // 
            this.apDataGridViewTextBoxColumn.DataPropertyName = "ap";
            this.apDataGridViewTextBoxColumn.HeaderText = "ap";
            this.apDataGridViewTextBoxColumn.Name = "apDataGridViewTextBoxColumn";
            // 
            // vaDataGridViewTextBoxColumn
            // 
            this.vaDataGridViewTextBoxColumn.DataPropertyName = "va";
            this.vaDataGridViewTextBoxColumn.HeaderText = "va";
            this.vaDataGridViewTextBoxColumn.Name = "vaDataGridViewTextBoxColumn";
            // 
            // pefDataGridViewTextBoxColumn
            // 
            this.pefDataGridViewTextBoxColumn.DataPropertyName = "pef";
            this.pefDataGridViewTextBoxColumn.HeaderText = "pef";
            this.pefDataGridViewTextBoxColumn.Name = "pefDataGridViewTextBoxColumn";
            // 
            // nfDataGridViewTextBoxColumn
            // 
            this.nfDataGridViewTextBoxColumn.DataPropertyName = "nf";
            this.nfDataGridViewTextBoxColumn.HeaderText = "nf";
            this.nfDataGridViewTextBoxColumn.Name = "nfDataGridViewTextBoxColumn";
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            // 
            // conDataGridViewTextBoxColumn
            // 
            this.conDataGridViewTextBoxColumn.DataPropertyName = "con";
            this.conDataGridViewTextBoxColumn.HeaderText = "con";
            this.conDataGridViewTextBoxColumn.Name = "conDataGridViewTextBoxColumn";
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 429);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gridnotas);
            this.Controls.Add(this.notaFinal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.notaLiteral);
            this.Controls.Add(this.condicion);
            this.Controls.Add(this.pef);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.va);
            this.Controls.Add(this.pf);
            this.Controls.Add(this.poe);
            this.Controls.Add(this.asignatura);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridnotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private TextBox matricula;
        private TextBox nombre;
        private TextBox apellido;
        private TextBox asignatura;
        private TextBox poe;
        private TextBox pf;
        private TextBox va;
        private TextBox ap;
        private TextBox pef;
        private TextBox condicion;
        private TextBox notaLiteral;
        private Label label12;
        private TextBox notaFinal;
        private DataGridView gridnotas;
        private BindingSource conexionBindingSource;
        private Label label13;
        private TextBox buscar;
        private P2DataSet P2DataSet;
        private BindingSource calificacionBindingSource;
        private DataGridViewTextBoxColumn nomestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apeestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asiestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn poeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pefDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conDataGridViewTextBoxColumn;
        private BindingSource calificacionBindingSource1;
        private DataGridViewTextBoxColumn mat_est;
        private DataGridViewTextBoxColumn nom_est;
        private DataGridViewTextBoxColumn ape_est;
        private DataGridViewTextBoxColumn asi_est;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn L;
        private DataGridViewTextBoxColumn nf;
        private DataGridViewTextBoxColumn con;
        private DataGridViewTextBoxColumn matestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
    }
}