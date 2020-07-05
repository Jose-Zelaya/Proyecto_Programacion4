namespace Administrador
{
    partial class ListarPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarPeliculas));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tSalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCinecatrachoDataSet = new Administrador.DBCinecatrachoDataSet();
            this.t_SalaTableAdapter = new Administrador.DBCinecatrachoDataSetTableAdapters.t_SalaTableAdapter();
            this.tCompañiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCinecatrachoDataSet2 = new Administrador.DBCinecatrachoDataSet2();
            this.dBCinecatrachoDataSet1 = new Administrador.DBCinecatrachoDataSet1();
            this.tCompañiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CompañiaTableAdapter = new Administrador.DBCinecatrachoDataSet1TableAdapters.t_CompañiaTableAdapter();
            this.t_CompañiaTableAdapter1 = new Administrador.DBCinecatrachoDataSet2TableAdapters.t_CompañiaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCinecatrachoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompañiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCinecatrachoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCinecatrachoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompañiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(856, 41);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(334, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listar Peliculas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(739, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tSalaBindingSource
            // 
            this.tSalaBindingSource.DataMember = "t_Sala";
            this.tSalaBindingSource.DataSource = this.dBCinecatrachoDataSet;
            // 
            // dBCinecatrachoDataSet
            // 
            this.dBCinecatrachoDataSet.DataSetName = "DBCinecatrachoDataSet";
            this.dBCinecatrachoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_SalaTableAdapter
            // 
            this.t_SalaTableAdapter.ClearBeforeFill = true;
            // 
            // tCompañiaBindingSource1
            // 
            this.tCompañiaBindingSource1.DataMember = "t_Compañia";
            this.tCompañiaBindingSource1.DataSource = this.dBCinecatrachoDataSet2;
            // 
            // dBCinecatrachoDataSet2
            // 
            this.dBCinecatrachoDataSet2.DataSetName = "DBCinecatrachoDataSet2";
            this.dBCinecatrachoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCinecatrachoDataSet1
            // 
            this.dBCinecatrachoDataSet1.DataSetName = "DBCinecatrachoDataSet1";
            this.dBCinecatrachoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCompañiaBindingSource
            // 
            this.tCompañiaBindingSource.DataMember = "t_Compañia";
            this.tCompañiaBindingSource.DataSource = this.dBCinecatrachoDataSet1;
            // 
            // t_CompañiaTableAdapter
            // 
            this.t_CompañiaTableAdapter.ClearBeforeFill = true;
            // 
            // t_CompañiaTableAdapter1
            // 
            this.t_CompañiaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 234);
            this.dataGridView1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(76, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Listar Peliculas";
            // 
            // ListarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(856, 437);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListarPeliculas";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarPeliculas";
            this.Load += new System.EventHandler(this.AdminPeli_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListarPeliculas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCinecatrachoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompañiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCinecatrachoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCinecatrachoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompañiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DBCinecatrachoDataSet dBCinecatrachoDataSet;
        private System.Windows.Forms.BindingSource tSalaBindingSource;
        private DBCinecatrachoDataSetTableAdapters.t_SalaTableAdapter t_SalaTableAdapter;
        private DBCinecatrachoDataSet1 dBCinecatrachoDataSet1;
        private System.Windows.Forms.BindingSource tCompañiaBindingSource;
        private DBCinecatrachoDataSet1TableAdapters.t_CompañiaTableAdapter t_CompañiaTableAdapter;
        private DBCinecatrachoDataSet2 dBCinecatrachoDataSet2;
        private System.Windows.Forms.BindingSource tCompañiaBindingSource1;
        private DBCinecatrachoDataSet2TableAdapters.t_CompañiaTableAdapter t_CompañiaTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
    }
}