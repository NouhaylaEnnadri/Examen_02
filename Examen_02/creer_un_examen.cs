using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_02
{
    public partial class creer_un_examen : Form
    {
        public creer_un_examen()
        {
            InitializeComponent();
        }


        #region connexion 
        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=EXAMEN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        #endregion
        private void name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void duree_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateF_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ajout_btn_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Examen(nom, id , duree , dateD , dateF) values('" + name_input.Text + "','" + id_input.Text + "','" + duree.Text + "','" + dateD.Text + "','" + dateF.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
            //affichage 
            cmd.CommandText = "select * from Examen";

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            listeQ.DataSource = dt;
            cnx.Close();
        }

        private void mdf_btn_Click(object sender, EventArgs e)
        {

        }

        private void supp_btn_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Examen where id='" + txtId_dossier.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void ajoutQ_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void affiQ_btn_Click(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {

        }

        private void listeQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {

                DataGridViewRow row = this.listeQ.Rows[e.RowIndex];


            }
        }

        private void creer_un_examen_Load(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.CommandText = "select * from Examen";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            listeQ.DataSource = dt;
            cnx.Close();

        }

        private void dateD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateF_TextChanged(object sender, EventArgs e)
        {

        }

    }

}