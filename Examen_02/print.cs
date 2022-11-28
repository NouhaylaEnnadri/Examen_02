using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_02
{
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }
        #region connexion 
        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=EXAMEN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                id.Text = row.Cells["id_Q"].Value.ToString();
                enonce.Text = row.Cells["question"].Value.ToString();
                note.Text = row.Cells["note"].Value.ToString();
                id_e.Text = row.Cells["id_E"].Value.ToString();
                type.Text = row.Cells["type"].Value.ToString();



            }
            
        }
        public void affichage()
        {

            cnx.Open();
            cmd.CommandText = "select * from QCM";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            cnx.Close();


        }

        private void print_Load(object sender, EventArgs e)
        {
            affichage();
        }
    }
}
