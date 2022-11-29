using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen_02
{
    public partial class creer_un_examen : Form
    {
        public creer_un_examen()
        {
            InitializeComponent();
        }
        public static string ex  = "";  //variables static pour passer l id_examen au form print
        
        #region connexion 
        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=EXAMEN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        #endregion

        #region unused methods
        private void dateD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateF_TextChanged(object sender, EventArgs e)
        {

        }
        private void enregistrer_Click(object sender, EventArgs e)
        {

        }
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
        #endregion
        #region buttons manipulation 

        private void ajout_btn_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Examen(nom, id , duree , dateD , dateF) values('" + name_input.Text + "','" + id_input.Text + "','" + duree.Text + "','" + dateD.Text + "','" + dateF.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
            affichage();

            #region read only buttons
            mdf_btn.Enabled = false;
            supp_btn.Enabled = false;
            button1.Enabled = false;
            affiQ_btn.Enabled = false;
            ajout_btn.Enabled = false;
            #endregion
        }

        private void mdf_btn_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update Examen set nom ='" + name_input.Text + "' where id='" + id_input.Text + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Examen set duree ='" + duree.Text + "' where id='" + id_input.Text + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Examen set dateD ='" + dateD.Text + "' where id='" + id_input.Text + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Examen set dateF ='" + dateF.Text + "' where id='" + id_input.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close(); 
            affichage(); 
        }

        private void supp_btn_Click(object sender, EventArgs e)
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
                cmd.CommandText = "delete from ouverte where id_E='" + id_input.Text + "' ";
                cmd.CommandText = "delete from QCM where id_E='" + id_input.Text + "' ";
                cmd.CommandText = "delete from dichotomique where id_E='" + id_input.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from Examen where id='" + id_input.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                affichage(); 

            }
            //vider les input 
            id_input.Text = "";
            name_input.Text = "";
            duree.Text = "";
            dateD.Text = "";
            dateF.Text = ""; 
            affichage();


        }

        private void ajoutQ_btn_Click(object sender, EventArgs e)
        {
            //navigate to the other form 

            creer_une_question creer_une_question = new creer_une_question();
            creer_une_question.Show();
            this.Visible = false;

            

        }

        private void affiQ_btn_Click(object sender, EventArgs e)
        {
            ex = id_input.Text; 
            
            string id = id_input.Text;  
            if(id == "")
            {
                
                    string message = "selectionner l'id de l'examen";
                    MessageBox.Show(message);
                

            }
            else
            {    
                //navigate to the other form
                print print = new print();
                print.Show();
                this.Visible = false;
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //button enregistrer enregistre l'examen et ouvre la porte a creer un nouveau examen 
            id_input.Text = "";
            name_input.Text = "";
            duree.Text = "";
            dateD.Text = "";
            dateF.Text = "";
        }
        #endregion
       

        private void listeQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //pour afficher toutes les colonnes de la bases de donnes dans les text.input
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.listeQ.Rows[e.RowIndex];

                name_input.Text = row.Cells["nom"].Value.ToString();
                id_input.Text = row.Cells["id"].Value.ToString();
                duree.Text = row.Cells["duree"].Value.ToString();
                dateD.Text = row.Cells["dateD"].Value.ToString();
                dateF.Text = row.Cells["dateF"].Value.ToString();
               



            }
        }

        private void creer_un_examen_Load(object sender, EventArgs e)
        {

            affichage(); 
        }

     

        #region functions 
        public void affichage() {

            cnx.Open();
            cmd.CommandText = "select * from Examen";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            listeQ.DataSource = dt;
            cnx.Close();
          
            #endregion

        }

       
    }

}