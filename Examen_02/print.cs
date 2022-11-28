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
using System.Xml.Linq;

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
            creer_un_examen creer_un_examen = new creer_un_examen();
            
            cnx.Open();
            cmd.CommandText = "select id_Q , id_E , note , question , type  from QCM where  QCM.id_E  ='" + creer_un_examen.ex + "' ";
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

        private void ajouter_Click(object sender, EventArgs e)
        {
            creer_une_question creer_une_question = new creer_une_question();
            creer_une_question.Show();
            this.Visible = false;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            creer_un_examen creer_un_examen = new creer_un_examen();
            creer_un_examen.Show();
            this.Visible = false;
          
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            string box_msg = "confirmer la suppression";

            string box_title = "confiramtion";



            if (MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from QCM where id_Q='" + id.Text + "' ";
                cmd.ExecuteNonQuery();
               
                cnx.Close();
                affichage();

            }
            note.Text = "";
            enonce.Text = "";
            id_e.Text = "";
            type.Text = "";
            id.Text = ""; 



            affichage();


        }
        int flag = 0;
        private void modifier_Click(object sender, EventArgs e)
        {

           
            if (flag == 0)
            {
                enonce.Enabled = false;
                type.Enabled = false;
                id.Enabled = false;
                flag = 1; 
            }
           
            else
            {

                cnx.Open();
                cmd.Connection = cnx;

                cmd.CommandText = "update QCM set note ='" + note.Text + "' where id_Q='" + id.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update QCM set id_E ='" + id_e.Text + "' where id_Q='" + id.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update QCM set question ='" + enonce.Text + "' where id_Q='" + id.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                flag = 0; 
            }
                affichage();
               
           
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            note.Text = "";
            enonce.Text = "";
            id_e.Text = "";
            type.Text = "";
            id.Text = "";
        }
    }
    }

