using MyMusicBench.Connection;
using MyMusicBench.DataAccess;
using MyMusicBench.DataAccess.ModelsRepo.SongsRepo;
using MyMusicBench.Models;
using System.Windows.Forms;

namespace MyMusicBench
{
    public partial class Form1 : Form
    {
        // Instancias
        private readonly MyMusicBenchContext _context;
        private readonly SongsRepository songsRepo;
        // Variables globales
        private string valorCelda = string.Empty;
        private int valorPrimerColumna = 0;

        public Form1(MyMusicBenchContext context)
        {
            _context = context;
            songsRepo = new SongsRepository(context);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_getAllSongs_Click(object sender, EventArgs e)
        {
            try
            {
                Task<List<Song>> taskSongs = songsRepo.GetAll();
                List<Song> songList = await taskSongs;
                string songsToString = string.Empty;
                dgv_SongsList.DataSource = songList;

                btn_orderSongsByAuthor.Visible = true;
                btn_orderSongsByName.Visible = true;
                btn_selectSongsFromAuthor.Visible = true;

            }
            catch
            {
                lbl_show.Text = "No hay canciones";
            }
        }

        private async void btn_addSongs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_songName.Text) || string.IsNullOrWhiteSpace(txt_songAuthor.Text))
            {
                lbl_show.Text = "Rellena todos los campos";
            }
            else
            {
                await songsRepo.AddSong(txt_songName.Text, txt_songAuthor.Text);
                MessageBox.Show("Cancion agregada a la lista correctamente!");
                txt_songName.Clear();
                txt_songAuthor.Clear();
                dgv_SongsList.Refresh();
            }
        }



        private async void btn_searchSongByName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_songToDelete.Text))
            {
                Task<List<Song>> taskSongsList = songsRepo.GetSongByName(txt_songToDelete.Text);
                List<Song> songsList = await taskSongsList;
                dgv_songsToDelete.Visible = true;
                dgv_songsToDelete.DataSource = songsList;
                txt_songToDelete.Clear();
            }
            else lbl_show.Text = "Rellena los campos";
        }

        private void dgv_songsToDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorCelda = dgv_songsToDelete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                valorPrimerColumna = Convert.ToInt32(dgv_songsToDelete.Rows[e.RowIndex].Cells[0].Value);
                btn_deleteSong.Visible = true;
                btn_editSong.Visible = true;
            }
            catch
            {
                lbl_show.Text = "Selecciona una cancion correcta";
            }

        }

        private async void btn_deleteSong_Click(object sender, EventArgs e)
        {
            await songsRepo.RemoveSong(valorPrimerColumna);
            MessageBox.Show($"Cancion: '{valorCelda}' eliminada correctamente");

            dgv_songsToDelete.Visible = false;
            btn_deleteSong.Visible = false;
            btn_editSong.Visible = false;
            txt_newSongName.Visible = false;
            txt_newSongAuthor.Visible = false;
            btn_acceptEditSong.Visible = false;

            dgv_songsToDelete.Refresh();
            dgv_songsToDelete.DataSource = null;
            dgv_SongsList.DataSource = null;
        }

        private void btn_editSong_Click(object sender, EventArgs e)
        {
            txt_newSongName.Visible = true;
            txt_newSongAuthor.Visible = true;
            btn_acceptEditSong.Visible = true;

        }

        private async void btn_acceptEditSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_newSongName.Text) || string.IsNullOrWhiteSpace(txt_newSongAuthor.Text))
            {
                lbl_show.Text = "Completa todos los campos";
            }
            else
            {
                await songsRepo.EditSong(valorPrimerColumna, txt_newSongName.Text, txt_newSongAuthor.Text);
                MessageBox.Show("Cancion editada correctamente!");

                dgv_songsToDelete.Visible = false;
                btn_deleteSong.Visible = false;
                btn_editSong.Visible = false;
                txt_newSongName.Visible = false;
                txt_newSongAuthor.Visible = false;
                btn_acceptEditSong.Visible = false;

                dgv_songsToDelete.Refresh();
                dgv_songsToDelete.DataSource = null;
                dgv_SongsList.DataSource = null;
            }
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_orderSongsByAuthorAToZ_Click(object sender, EventArgs e)
        {
            var songsOrderedByAuthorAToZ = await songsRepo.GetAllSongsOrderByAuthorAToZ();
            dgv_SongsList.DataSource = songsOrderedByAuthorAToZ;
        }

        private async void btn_orderSongsByAuthorZToA_Click(object sender, EventArgs e)
        {
            var songsOrderedByAuthorZToA = await songsRepo.GetAllSongsOrderByAuthorZToA();
            dgv_SongsList.DataSource = songsOrderedByAuthorZToA;
        }

        private async void btn_orderSongsByNameAToZ_Click(object sender, EventArgs e)
        {
            var songsOrderedByNameAToZ = await songsRepo.GetAllSongsOrderByNameAToZ();
            dgv_SongsList.DataSource = songsOrderedByNameAToZ;
        }

        private async void btn_orderSongsByNameZtoA_Click(object sender, EventArgs e)
        {
            var songsOrderedByNameZToA = await songsRepo.GetAllSongsOrderByNameZToA();
            dgv_SongsList.DataSource = songsOrderedByNameZToA;
        }

        private void dgv_SongsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Recoge el valor de la tercera columna (índice 2) en la fila seleccionada
                valorCelda = dgv_SongsList.Rows[e.RowIndex].Cells[2].Value.ToString();

                //recoge el valor de la celda seleccionada
                //valorCelda = dgv_SongsList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 

            }
            catch
            {
                lbl_show.Text = "Selecciona una cancion correcta";
            }
        }

        private async void btn_selectSongsFromAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                var canciones = await songsRepo.GetAllSongsFromAuthor(valorCelda);
                if (canciones.Count > 0)
                {
                    dgv_SongsList.DataSource = canciones;
                }
                else lbl_show.Text = "Selecciona un autor correcto";
            }
            catch
            {
                lbl_show.Text = "Selecciona un autor correcto";
            }
        }

        private void btn_orderSongsByAuthor_Click(object sender, EventArgs e)
        {
            if (
                btn_orderSongsByAuthorZToA.Visible == true ||
                btn_orderSongsByAuthorAToZ.Visible == true
                )
            {
                btn_orderSongsByAuthorZToA.Visible = false;
                btn_orderSongsByAuthorAToZ.Visible = false;
            }
            else
            {
                btn_orderSongsByAuthorZToA.Visible = true;
                btn_orderSongsByAuthorAToZ.Visible = true;
            }
        }

        private void btn_orderSongsByName_Click(object sender, EventArgs e)
        {
            if (
                btn_orderSongsByNameZtoA.Visible == true ||
                btn_orderSongsByNameAToZ.Visible == true
                )
            {
                btn_orderSongsByNameZtoA.Visible = false;
                btn_orderSongsByNameAToZ.Visible = false;
            }
            else
            {
                btn_orderSongsByNameZtoA.Visible = true;
                btn_orderSongsByNameAToZ.Visible = true;
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
