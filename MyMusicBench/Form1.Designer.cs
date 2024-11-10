namespace MyMusicBench
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            Title = new Label();
            lbl_show = new Label();
            btn_getAllSongs = new Button();
            btn_addSongs = new Button();
            dgv_SongsList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            songBindingSource1 = new BindingSource(components);
            songBindingSource = new BindingSource(components);
            txt_songName = new TextBox();
            txt_songAuthor = new TextBox();
            panel1 = new Panel();
            txt_songToDelete = new TextBox();
            dgv_songsToDelete = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btn_searchSongByName = new Button();
            btn_deleteSong = new Button();
            btn_editSong = new Button();
            txt_newSongName = new TextBox();
            txt_newSongAuthor = new TextBox();
            btn_acceptEditSong = new Button();
            label1 = new Label();
            btn_closeForm = new Button();
            label2 = new Label();
            label3 = new Label();
            btn_orderSongsByAuthor = new Button();
            btn_orderSongsByName = new Button();
            panel2 = new Panel();
            btn_orderSongsByAuthorAToZ = new Button();
            btn_orderSongsByAuthorZToA = new Button();
            btn_orderSongsByNameAToZ = new Button();
            btn_orderSongsByNameZtoA = new Button();
            label4 = new Label();
            btn_selectSongsFromAuthor = new Button();
            label5 = new Label();
            panelBarraTitulo = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_SongsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_songsToDelete).BeginInit();
            panelBarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Title.ForeColor = Color.White;
            Title.Location = new Point(12, 13);
            Title.Name = "Title";
            Title.Size = new Size(97, 15);
            Title.TabIndex = 0;
            Title.Text = "My Music Bench";
            // 
            // lbl_show
            // 
            lbl_show.BackColor = Color.White;
            lbl_show.ForeColor = Color.Red;
            lbl_show.Location = new Point(251, 560);
            lbl_show.Name = "lbl_show";
            lbl_show.Size = new Size(320, 21);
            lbl_show.TabIndex = 1;
            // 
            // btn_getAllSongs
            // 
            btn_getAllSongs.BackColor = Color.White;
            btn_getAllSongs.FlatStyle = FlatStyle.Flat;
            btn_getAllSongs.Location = new Point(531, 347);
            btn_getAllSongs.Name = "btn_getAllSongs";
            btn_getAllSongs.Size = new Size(152, 23);
            btn_getAllSongs.TabIndex = 2;
            btn_getAllSongs.Text = "Ver todas las canciones";
            btn_getAllSongs.UseVisualStyleBackColor = false;
            btn_getAllSongs.Click += btn_getAllSongs_Click;
            // 
            // btn_addSongs
            // 
            btn_addSongs.BackColor = Color.White;
            btn_addSongs.FlatStyle = FlatStyle.Flat;
            btn_addSongs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_addSongs.Location = new Point(220, 134);
            btn_addSongs.Name = "btn_addSongs";
            btn_addSongs.Size = new Size(87, 23);
            btn_addSongs.TabIndex = 3;
            btn_addSongs.Text = "Agregar Cancion";
            btn_addSongs.UseVisualStyleBackColor = false;
            btn_addSongs.Click += btn_addSongs_Click;
            // 
            // dgv_SongsList
            // 
            dgv_SongsList.AllowUserToAddRows = false;
            dgv_SongsList.AllowUserToDeleteRows = false;
            dgv_SongsList.AutoGenerateColumns = false;
            dgv_SongsList.BackgroundColor = Color.White;
            dgv_SongsList.BorderStyle = BorderStyle.None;
            dgv_SongsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SongsList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgv_SongsList.DataSource = songBindingSource1;
            dgv_SongsList.Location = new Point(490, 105);
            dgv_SongsList.Name = "dgv_SongsList";
            dgv_SongsList.ReadOnly = true;
            dgv_SongsList.Size = new Size(242, 230);
            dgv_SongsList.TabIndex = 4;
            dgv_SongsList.CellClick += dgv_SongsList_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "SongName";
            dataGridViewTextBoxColumn2.HeaderText = "SongName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SongAuthor";
            dataGridViewTextBoxColumn3.HeaderText = "SongAuthor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // songBindingSource1
            // 
            songBindingSource1.DataSource = typeof(Models.Song);
            // 
            // txt_songName
            // 
            txt_songName.Font = new Font("Segoe UI", 9F);
            txt_songName.Location = new Point(64, 105);
            txt_songName.Name = "txt_songName";
            txt_songName.PlaceholderText = "Nombre de la cancion";
            txt_songName.Size = new Size(132, 23);
            txt_songName.TabIndex = 5;
            // 
            // txt_songAuthor
            // 
            txt_songAuthor.Location = new Point(64, 134);
            txt_songAuthor.Name = "txt_songAuthor";
            txt_songAuthor.PlaceholderText = "Autor de la cancion";
            txt_songAuthor.Size = new Size(132, 23);
            txt_songAuthor.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(412, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 800);
            panel1.TabIndex = 7;
            // 
            // txt_songToDelete
            // 
            txt_songToDelete.Location = new Point(64, 267);
            txt_songToDelete.Name = "txt_songToDelete";
            txt_songToDelete.PlaceholderText = "Nombre de la cancion";
            txt_songToDelete.Size = new Size(152, 23);
            txt_songToDelete.TabIndex = 8;
            txt_songToDelete.TextAlign = HorizontalAlignment.Center;
            // 
            // dgv_songsToDelete
            // 
            dgv_songsToDelete.AllowUserToAddRows = false;
            dgv_songsToDelete.AllowUserToDeleteRows = false;
            dgv_songsToDelete.AutoGenerateColumns = false;
            dgv_songsToDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_songsToDelete.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgv_songsToDelete.DataSource = songBindingSource1;
            dgv_songsToDelete.Location = new Point(64, 296);
            dgv_songsToDelete.Name = "dgv_songsToDelete";
            dgv_songsToDelete.ReadOnly = true;
            dgv_songsToDelete.Size = new Size(243, 82);
            dgv_songsToDelete.TabIndex = 9;
            dgv_songsToDelete.Visible = false;
            dgv_songsToDelete.CellClick += dgv_songsToDelete_CellClick;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            dataGridViewTextBoxColumn4.HeaderText = "Id";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "SongName";
            dataGridViewTextBoxColumn5.HeaderText = "SongName";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "SongAuthor";
            dataGridViewTextBoxColumn6.HeaderText = "SongAuthor";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btn_searchSongByName
            // 
            btn_searchSongByName.Location = new Point(251, 267);
            btn_searchSongByName.Name = "btn_searchSongByName";
            btn_searchSongByName.Size = new Size(56, 23);
            btn_searchSongByName.TabIndex = 10;
            btn_searchSongByName.Text = "Buscar";
            btn_searchSongByName.UseVisualStyleBackColor = true;
            btn_searchSongByName.Click += btn_searchSongByName_Click;
            // 
            // btn_deleteSong
            // 
            btn_deleteSong.BackColor = Color.White;
            btn_deleteSong.FlatStyle = FlatStyle.Flat;
            btn_deleteSong.Location = new Point(64, 384);
            btn_deleteSong.Name = "btn_deleteSong";
            btn_deleteSong.Size = new Size(120, 23);
            btn_deleteSong.TabIndex = 11;
            btn_deleteSong.Text = "Eliminar cancion";
            btn_deleteSong.UseVisualStyleBackColor = false;
            btn_deleteSong.Visible = false;
            btn_deleteSong.Click += btn_deleteSong_Click;
            // 
            // btn_editSong
            // 
            btn_editSong.BackColor = Color.White;
            btn_editSong.FlatStyle = FlatStyle.Flat;
            btn_editSong.Location = new Point(64, 413);
            btn_editSong.Name = "btn_editSong";
            btn_editSong.Size = new Size(120, 23);
            btn_editSong.TabIndex = 12;
            btn_editSong.Text = "Editar cancion";
            btn_editSong.UseVisualStyleBackColor = false;
            btn_editSong.Visible = false;
            btn_editSong.Click += btn_editSong_Click;
            // 
            // txt_newSongName
            // 
            txt_newSongName.Font = new Font("Segoe UI", 9F);
            txt_newSongName.Location = new Point(64, 453);
            txt_newSongName.Name = "txt_newSongName";
            txt_newSongName.PlaceholderText = "Nuevo nombre de cancion";
            txt_newSongName.Size = new Size(152, 23);
            txt_newSongName.TabIndex = 13;
            txt_newSongName.Visible = false;
            // 
            // txt_newSongAuthor
            // 
            txt_newSongAuthor.Location = new Point(64, 482);
            txt_newSongAuthor.Name = "txt_newSongAuthor";
            txt_newSongAuthor.PlaceholderText = "Nuevo autor de cancion";
            txt_newSongAuthor.Size = new Size(152, 23);
            txt_newSongAuthor.TabIndex = 14;
            txt_newSongAuthor.Visible = false;
            // 
            // btn_acceptEditSong
            // 
            btn_acceptEditSong.Location = new Point(251, 482);
            btn_acceptEditSong.Name = "btn_acceptEditSong";
            btn_acceptEditSong.Size = new Size(56, 23);
            btn_acceptEditSong.TabIndex = 15;
            btn_acceptEditSong.Text = "Editar";
            btn_acceptEditSong.UseVisualStyleBackColor = true;
            btn_acceptEditSong.Visible = false;
            btn_acceptEditSong.Click += btn_acceptEditSong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 67);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 16;
            label1.Text = "Agregar cancion";
            // 
            // btn_closeForm
            // 
            btn_closeForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_closeForm.BackColor = Color.White;
            btn_closeForm.FlatStyle = FlatStyle.Flat;
            btn_closeForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_closeForm.Location = new Point(763, 9);
            btn_closeForm.Name = "btn_closeForm";
            btn_closeForm.Size = new Size(25, 25);
            btn_closeForm.TabIndex = 17;
            btn_closeForm.Text = "x";
            btn_closeForm.UseVisualStyleBackColor = false;
            btn_closeForm.Click += btn_closeForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 239);
            label2.Name = "label2";
            label2.Size = new Size(315, 15);
            label2.TabIndex = 16;
            label2.Text = "Busca una cancion y seleccionala para editarla o eliminarla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 214);
            label3.Name = "label3";
            label3.Size = new Size(234, 25);
            label3.TabIndex = 16;
            label3.Text = "Editar o eliminar cancion";
            // 
            // btn_orderSongsByAuthor
            // 
            btn_orderSongsByAuthor.BackColor = Color.White;
            btn_orderSongsByAuthor.FlatStyle = FlatStyle.Flat;
            btn_orderSongsByAuthor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btn_orderSongsByAuthor.Location = new Point(419, 382);
            btn_orderSongsByAuthor.Name = "btn_orderSongsByAuthor";
            btn_orderSongsByAuthor.Size = new Size(152, 43);
            btn_orderSongsByAuthor.TabIndex = 18;
            btn_orderSongsByAuthor.Text = "Ordenar canciones por nombre de autor";
            btn_orderSongsByAuthor.UseVisualStyleBackColor = false;
            btn_orderSongsByAuthor.Visible = false;
            btn_orderSongsByAuthor.Click += btn_orderSongsByAuthor_Click;
            // 
            // btn_orderSongsByName
            // 
            btn_orderSongsByName.BackColor = Color.White;
            btn_orderSongsByName.FlatStyle = FlatStyle.Flat;
            btn_orderSongsByName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_orderSongsByName.Location = new Point(419, 431);
            btn_orderSongsByName.Name = "btn_orderSongsByName";
            btn_orderSongsByName.Size = new Size(152, 41);
            btn_orderSongsByName.TabIndex = 19;
            btn_orderSongsByName.Text = "Ordenar canciones por nombre";
            btn_orderSongsByName.UseVisualStyleBackColor = false;
            btn_orderSongsByName.Visible = false;
            btn_orderSongsByName.Click += btn_orderSongsByName_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 1);
            panel2.TabIndex = 20;
            // 
            // btn_orderSongsByAuthorAToZ
            // 
            btn_orderSongsByAuthorAToZ.BackColor = Color.White;
            btn_orderSongsByAuthorAToZ.FlatStyle = FlatStyle.Flat;
            btn_orderSongsByAuthorAToZ.Location = new Point(595, 391);
            btn_orderSongsByAuthorAToZ.Name = "btn_orderSongsByAuthorAToZ";
            btn_orderSongsByAuthorAToZ.Size = new Size(75, 23);
            btn_orderSongsByAuthorAToZ.TabIndex = 21;
            btn_orderSongsByAuthorAToZ.Text = "A to Z";
            btn_orderSongsByAuthorAToZ.UseVisualStyleBackColor = false;
            btn_orderSongsByAuthorAToZ.Visible = false;
            btn_orderSongsByAuthorAToZ.Click += btn_orderSongsByAuthorAToZ_Click;
            // 
            // btn_orderSongsByAuthorZToA
            // 
            btn_orderSongsByAuthorZToA.BackColor = Color.White;
            btn_orderSongsByAuthorZToA.FlatStyle = FlatStyle.Flat;
            btn_orderSongsByAuthorZToA.Location = new Point(676, 391);
            btn_orderSongsByAuthorZToA.Name = "btn_orderSongsByAuthorZToA";
            btn_orderSongsByAuthorZToA.Size = new Size(75, 23);
            btn_orderSongsByAuthorZToA.TabIndex = 22;
            btn_orderSongsByAuthorZToA.Text = "Z to A";
            btn_orderSongsByAuthorZToA.UseVisualStyleBackColor = false;
            btn_orderSongsByAuthorZToA.Visible = false;
            btn_orderSongsByAuthorZToA.Click += btn_orderSongsByAuthorZToA_Click;
            // 
            // btn_orderSongsByNameAToZ
            // 
            btn_orderSongsByNameAToZ.BackColor = Color.White;
            btn_orderSongsByNameAToZ.FlatStyle = FlatStyle.Flat;
            btn_orderSongsByNameAToZ.Location = new Point(595, 442);
            btn_orderSongsByNameAToZ.Name = "btn_orderSongsByNameAToZ";
            btn_orderSongsByNameAToZ.Size = new Size(75, 23);
            btn_orderSongsByNameAToZ.TabIndex = 23;
            btn_orderSongsByNameAToZ.Text = "A to Z";
            btn_orderSongsByNameAToZ.UseVisualStyleBackColor = false;
            btn_orderSongsByNameAToZ.Visible = false;
            btn_orderSongsByNameAToZ.Click += btn_orderSongsByNameAToZ_Click;
            // 
            // btn_orderSongsByNameZtoA
            // 
            btn_orderSongsByNameZtoA.BackColor = Color.White;
            btn_orderSongsByNameZtoA.FlatStyle = FlatStyle.Flat;
            btn_orderSongsByNameZtoA.Location = new Point(676, 442);
            btn_orderSongsByNameZtoA.Name = "btn_orderSongsByNameZtoA";
            btn_orderSongsByNameZtoA.Size = new Size(75, 23);
            btn_orderSongsByNameZtoA.TabIndex = 24;
            btn_orderSongsByNameZtoA.Text = "Z to A";
            btn_orderSongsByNameZtoA.UseVisualStyleBackColor = false;
            btn_orderSongsByNameZtoA.Visible = false;
            btn_orderSongsByNameZtoA.Click += btn_orderSongsByNameZtoA_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(490, 67);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 16;
            label4.Text = "Lista de canciones";
            // 
            // btn_selectSongsFromAuthor
            // 
            btn_selectSongsFromAuthor.BackColor = Color.White;
            btn_selectSongsFromAuthor.FlatStyle = FlatStyle.Flat;
            btn_selectSongsFromAuthor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_selectSongsFromAuthor.Location = new Point(419, 482);
            btn_selectSongsFromAuthor.Name = "btn_selectSongsFromAuthor";
            btn_selectSongsFromAuthor.Size = new Size(152, 41);
            btn_selectSongsFromAuthor.TabIndex = 25;
            btn_selectSongsFromAuthor.Text = "Mostrar canciones del autor";
            btn_selectSongsFromAuthor.UseVisualStyleBackColor = false;
            btn_selectSongsFromAuthor.Visible = false;
            btn_selectSongsFromAuthor.Click += btn_selectSongsFromAuthor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(251, 541);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 16;
            label5.Text = "Error Output";
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.Controls.Add(Title);
            panelBarraTitulo.Controls.Add(btn_closeForm);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(800, 43);
            panelBarraTitulo.TabIndex = 26;
            panelBarraTitulo.MouseDown += panelBarraTitulo_MouseDown;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            panelBarraTitulo.MouseUp += panelBarraTitulo_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 600);
            Controls.Add(lbl_show);
            Controls.Add(panel2);
            Controls.Add(btn_selectSongsFromAuthor);
            Controls.Add(btn_orderSongsByNameZtoA);
            Controls.Add(btn_orderSongsByNameAToZ);
            Controls.Add(btn_orderSongsByAuthorZToA);
            Controls.Add(btn_orderSongsByAuthorAToZ);
            Controls.Add(btn_orderSongsByName);
            Controls.Add(btn_orderSongsByAuthor);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btn_acceptEditSong);
            Controls.Add(txt_newSongAuthor);
            Controls.Add(txt_newSongName);
            Controls.Add(btn_editSong);
            Controls.Add(btn_deleteSong);
            Controls.Add(btn_searchSongByName);
            Controls.Add(dgv_songsToDelete);
            Controls.Add(txt_songToDelete);
            Controls.Add(txt_songAuthor);
            Controls.Add(txt_songName);
            Controls.Add(dgv_SongsList);
            Controls.Add(btn_addSongs);
            Controls.Add(btn_getAllSongs);
            Controls.Add(panelBarraTitulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "My Music Bench";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_SongsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_songsToDelete).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lbl_show;
        private Button btn_getAllSongs;
        private Button btn_addSongs;
        private DataGridView dgv_SongsList;
        private BindingSource songBindingSource;
        private TextBox txt_songName;
        private TextBox txt_songAuthor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn songAuthorDataGridViewTextBoxColumn;
        private Panel panel1;
        private TextBox txt_songToDelete;
        private DataGridView dgv_songsToDelete;
        private Button btn_searchSongByName;
        private Button btn_deleteSong;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn songAuthorDataGridViewTextBoxColumn1;
        private Button btn_editSong;
        private TextBox txt_newSongName;
        private TextBox txt_newSongAuthor;
        private Button btn_acceptEditSong;
        private Label label1;
        private Button btn_closeForm;
        private Label label2;
        private Label label3;
        private Button btn_orderSongsByAuthor;
        private Button btn_orderSongsByName;
        private Panel panel2;
        private Button btn_orderSongsByAuthorAToZ;
        private Button btn_orderSongsByAuthorZToA;
        private Button btn_orderSongsByNameAToZ;
        private Button btn_orderSongsByNameZtoA;
        private Label label4;
        private Button btn_selectSongsFromAuthor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource songBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label5;
        private Panel panelBarraTitulo;
    }
}
