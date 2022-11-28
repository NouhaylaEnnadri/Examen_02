namespace Examen_02
{
    partial class print
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.annuler = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enonce = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id_e = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(745, 184);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(69, 466);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(112, 34);
            this.annuler.TabIndex = 3;
            this.annuler.Text = "enregistrer";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(69, 417);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 34);
            this.modifier.TabIndex = 4;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(69, 363);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 34);
            this.supprimer.TabIndex = 5;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "liste question";
            // 
            // enonce
            // 
            this.enonce.Location = new System.Drawing.Point(380, 370);
            this.enonce.Name = "enonce";
            this.enonce.Size = new System.Drawing.Size(163, 31);
            this.enonce.TabIndex = 0;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(379, 407);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(164, 31);
            this.note.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enonce";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "note";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(380, 331);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(163, 31);
            this.id.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(69, 313);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 34);
            this.ajouter.TabIndex = 19;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID_E";
            // 
            // id_e
            // 
            this.id_e.Location = new System.Drawing.Point(379, 453);
            this.id_e.Name = "id_e";
            this.id_e.Size = new System.Drawing.Size(164, 31);
            this.id_e.TabIndex = 21;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(604, 373);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(164, 31);
            this.type.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "type";
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(2, 2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(70, 34);
            this.retour.TabIndex = 24;
            this.retour.Text = "return";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.type);
            this.Controls.Add(this.id_e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.note);
            this.Controls.Add(this.enonce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.dataGridView2);
            this.Name = "print";
            this.Text = "print";
            this.Load += new System.EventHandler(this.print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox enonce;
        private TextBox note;
        private Label label3;
        private Label label4;
        private TextBox id;
        private Label label2;
        private Button button1;
        private Label label5;
        private TextBox id_e;
        private TextBox type;
        private Label label6;
        private Button button5;
        private Button retour;
        private Button annuler;
        private Button modifier;
        private Button supprimer;
        private Button ajouter;
    }
}