using System;
using System.Data.SqlClient;

namespace Examen_02
{
    public partial class creer_une_question : Form
    {
        public creer_une_question()
        {
            InitializeComponent();
        }

        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=EXAMEN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            #region dichititlique
            dichocheck.Enabled = false;
            checkBox10.Enabled = false; 
            panel2.Enabled = false;
            panel3.Enabled = false; 
            #endregion
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            creer_un_examen creer_un_examen = new creer_un_examen();
            creer_un_examen.Show();
            this.Visible = false;

            ////
            /// 
           


                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into QCM(id_Q ,  id_E , note , question , type ) values('" + id_input.Text + "','" + id_e.Text + "','" + note.Text + "','" + question_input.Text + "','" + "qcm" + "') ";
                cmd.ExecuteNonQuery();
                cnx.Close();

            
           

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void id_rep2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void id_rep_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void proposition2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void id_e_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            creer_un_examen creer_un_examen = new creer_un_examen();
            creer_un_examen.Show();
            this.Visible = false;
        }
    }
}