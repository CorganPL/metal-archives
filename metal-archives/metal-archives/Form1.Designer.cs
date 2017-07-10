namespace metal_archives
{
    partial class metalarchives
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.favBandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._metal_archivesDataSet1 = new metal_archives._metal_archivesDataSet1();
            this._metal_archivesDataSet = new metal_archives._metal_archivesDataSet();
            this.metalarchivesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favBandsTableAdapter = new metal_archives._metal_archivesDataSet1TableAdapters.FavBandsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.newGenreTb = new System.Windows.Forms.TextBox();
            this.idToLoad = new System.Windows.Forms.NumericUpDown();
            this.idToDelete = new System.Windows.Forms.NumericUpDown();
            this.idToUpdate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favBandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._metal_archivesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._metal_archivesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalarchivesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idToLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idToDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idToUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(120, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(540, 20);
            this.urlBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(216, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 25);
            this.nameLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gatunek:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(218, 70);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(0, 13);
            this.genreLabel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pochodzenie:";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(218, 83);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(0, 13);
            this.originLabel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rok założenia:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(218, 96);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(0, 13);
            this.yearLabel.TabIndex = 8;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(666, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(60, 20);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(234, 118);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(258, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Dodaj do ulubionych";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.okBtn_click);
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(512, 38);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(292, 133);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 12;
            this.logoBox.TabStop = false;
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(512, 177);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(292, 165);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 13;
            this.photoBox.TabStop = false;
            // 
            // favBandsBindingSource
            // 
            this.favBandsBindingSource.DataMember = "FavBands";
            this.favBandsBindingSource.DataSource = this._metal_archivesDataSet1;
            // 
            // _metal_archivesDataSet1
            // 
            this._metal_archivesDataSet1.DataSetName = "_metal_archivesDataSet1";
            this._metal_archivesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _metal_archivesDataSet
            // 
            this._metal_archivesDataSet.DataSetName = "_metal_archivesDataSet";
            this._metal_archivesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metalarchivesDataSetBindingSource
            // 
            this.metalarchivesDataSetBindingSource.DataSource = this._metal_archivesDataSet;
            this.metalarchivesDataSetBindingSource.Position = 0;
            // 
            // favBandsTableAdapter
            // 
            this.favBandsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.favBandsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 169);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 130;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 40;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(52, 148);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(108, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Usuń z ulubionych";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.delete_Btn);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(52, 119);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(108, 23);
            this.loadBtn.TabIndex = 17;
            this.loadBtn.Text = "Wczytaj";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.show_Btn);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(234, 142);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 23);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Popraw gatunek dla";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.update_Btn);
            // 
            // newGenreTb
            // 
            this.newGenreTb.Location = new System.Drawing.Point(407, 142);
            this.newGenreTb.Name = "newGenreTb";
            this.newGenreTb.Size = new System.Drawing.Size(85, 20);
            this.newGenreTb.TabIndex = 21;
            // 
            // idToLoad
            // 
            this.idToLoad.Location = new System.Drawing.Point(6, 121);
            this.idToLoad.Name = "idToLoad";
            this.idToLoad.Size = new System.Drawing.Size(40, 20);
            this.idToLoad.TabIndex = 22;
            // 
            // idToDelete
            // 
            this.idToDelete.Location = new System.Drawing.Point(6, 150);
            this.idToDelete.Name = "idToDelete";
            this.idToDelete.Size = new System.Drawing.Size(40, 20);
            this.idToDelete.TabIndex = 23;
            // 
            // idToUpdate
            // 
            this.idToUpdate.Location = new System.Drawing.Point(355, 143);
            this.idToUpdate.Name = "idToUpdate";
            this.idToUpdate.Size = new System.Drawing.Size(46, 20);
            this.idToUpdate.TabIndex = 24;
            // 
            // metalarchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 358);
            this.Controls.Add(this.idToUpdate);
            this.Controls.Add(this.idToDelete);
            this.Controls.Add(this.idToLoad);
            this.Controls.Add(this.newGenreTb);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Name = "metalarchives";
            this.Text = "Metal-Archives";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favBandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._metal_archivesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._metal_archivesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalarchivesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idToLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idToDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idToUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.BindingSource metalarchivesDataSetBindingSource;
        private _metal_archivesDataSet _metal_archivesDataSet;
        private _metal_archivesDataSet1 _metal_archivesDataSet1;
        private System.Windows.Forms.BindingSource favBandsBindingSource;
        private _metal_archivesDataSet1TableAdapters.FavBandsTableAdapter favBandsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox newGenreTb;
        private System.Windows.Forms.NumericUpDown idToLoad;
        private System.Windows.Forms.NumericUpDown idToDelete;
        private System.Windows.Forms.NumericUpDown idToUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}

