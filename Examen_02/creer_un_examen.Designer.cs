namespace Examen_02
{
    partial class creer_un_examen
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
            this.label1 = new System.Windows.Forms.Label();
            this.listeQ = new System.Windows.Forms.DataGridView();
            this.ajout_btn = new System.Windows.Forms.Button();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_input = new System.Windows.Forms.TextBox();
            this.duree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ajoutQ_btn = new System.Windows.Forms.Button();
            this.supp_btn = new System.Windows.Forms.Button();
            this.mdf_btn = new System.Windows.Forms.Button();
            this.affiQ_btn = new System.Windows.Forms.Button();
            this.dateF = new System.Windows.Forms.TextBox();
            this.dateD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listeQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "creer un question";
            // 
            // listeQ
            // 
            this.listeQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeQ.Location = new System.Drawing.Point(408, 55);
            this.listeQ.Name = "listeQ";
            this.listeQ.RowHeadersWidth = 62;
            this.listeQ.Size = new System.Drawing.Size(597, 151);
            this.listeQ.TabIndex = 2;
            this.listeQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeQ_CellContentClick);
            // 
            // ajout_btn
            // 
            this.ajout_btn.Location = new System.Drawing.Point(508, 239);
            this.ajout_btn.Name = "ajout_btn";
            this.ajout_btn.Size = new System.Drawing.Size(112, 34);
            this.ajout_btn.TabIndex = 3;
            this.ajout_btn.Text = "Ajouter";
            this.ajout_btn.UseVisualStyleBackColor = true;
            this.ajout_btn.Click += new System.EventHandler(this.ajout_btn_Click);
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(12, 114);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(150, 31);
            this.name_input.TabIndex = 4;
            this.name_input.TextChanged += new System.EventHandler(this.name_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "liste des questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "duree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "name";
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(221, 114);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(150, 31);
            this.id_input.TabIndex = 9;
            this.id_input.TextChanged += new System.EventHandler(this.id_input_TextChanged);
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(12, 201);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(150, 31);
            this.duree.TabIndex = 10;
            this.duree.TextChanged += new System.EventHandler(this.duree_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "dateF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "dateD";
            // 
            // ajoutQ_btn
            // 
            this.ajoutQ_btn.Location = new System.Drawing.Point(508, 321);
            this.ajoutQ_btn.Name = "ajoutQ_btn";
            this.ajoutQ_btn.Size = new System.Drawing.Size(165, 34);
            this.ajoutQ_btn.TabIndex = 14;
            this.ajoutQ_btn.Text = "ajouter question";
            this.ajoutQ_btn.UseVisualStyleBackColor = true;
            this.ajoutQ_btn.Click += new System.EventHandler(this.ajoutQ_btn_Click);
            // 
            // supp_btn
            // 
            this.supp_btn.Location = new System.Drawing.Point(786, 239);
            this.supp_btn.Name = "supp_btn";
            this.supp_btn.Size = new System.Drawing.Size(112, 34);
            this.supp_btn.TabIndex = 15;
            this.supp_btn.Text = "supprimer";
            this.supp_btn.UseVisualStyleBackColor = true;
            this.supp_btn.Click += new System.EventHandler(this.supp_btn_Click);
            // 
            // mdf_btn
            // 
            this.mdf_btn.Location = new System.Drawing.Point(644, 239);
            this.mdf_btn.Name = "mdf_btn";
            this.mdf_btn.Size = new System.Drawing.Size(112, 34);
            this.mdf_btn.TabIndex = 16;
            this.mdf_btn.Text = "modifier";
            this.mdf_btn.UseVisualStyleBackColor = true;
            this.mdf_btn.Click += new System.EventHandler(this.mdf_btn_Click);
            // 
            // affiQ_btn
            // 
            this.affiQ_btn.Location = new System.Drawing.Point(733, 321);
            this.affiQ_btn.Name = "affiQ_btn";
            this.affiQ_btn.Size = new System.Drawing.Size(165, 34);
            this.affiQ_btn.TabIndex = 18;
            this.affiQ_btn.Text = "afficher question";
            this.affiQ_btn.UseVisualStyleBackColor = true;
            this.affiQ_btn.Click += new System.EventHandler(this.affiQ_btn_Click);
            // 
            // dateF
            // 
            this.dateF.Location = new System.Drawing.Point(237, 304);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(150, 31);
            this.dateF.TabIndex = 19;
            this.dateF.TextChanged += new System.EventHandler(this.dateF_TextChanged);
            // 
            // dateD
            // 
            this.dateD.Location = new System.Drawing.Point(12, 304);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(150, 31);
            this.dateD.TabIndex = 20;
            this.dateD.TextChanged += new System.EventHandler(this.dateD_TextChanged);
            // 
            // creer_un_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.dateD);
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.affiQ_btn);
            this.Controls.Add(this.mdf_btn);
            this.Controls.Add(this.supp_btn);
            this.Controls.Add(this.ajoutQ_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.ajout_btn);
            this.Controls.Add(this.listeQ);
            this.Controls.Add(this.label1);
            this.Name = "creer_un_examen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.creer_un_examen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView listeQ;
        private Button ajout_btn;
        private TextBox name_input;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox id_input;
        private TextBox duree;
        private Label label6;
        private Label label7;
        private Button ajoutQ_btn;
        private Button supp_btn;
        private Button mdf_btn;
        private Button affiQ_btn;
        private TextBox dateF;
        private TextBox dateD;
    }
}