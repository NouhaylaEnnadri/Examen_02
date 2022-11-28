namespace Examen_02
{
    partial class creer_une_question
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
            this.label1 = new System.Windows.Forms.Label();
            this.qcm = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.i = new System.Windows.Forms.Label();
            this.id_e = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_rep2 = new System.Windows.Forms.CheckBox();
            this.id_rep_3 = new System.Windows.Forms.CheckBox();
            this.id_rep_1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proposition3 = new System.Windows.Forms.TextBox();
            this.proposition1 = new System.Windows.Forms.TextBox();
            this.proposition2 = new System.Windows.Forms.TextBox();
            this.id_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.question_input = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creation d\'une question\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // qcm
            // 
            this.qcm.AutoSize = true;
            this.qcm.Location = new System.Drawing.Point(39, 67);
            this.qcm.Name = "qcm";
            this.qcm.Size = new System.Drawing.Size(79, 29);
            this.qcm.TabIndex = 1;
            this.qcm.Text = "QCM";
            this.qcm.UseVisualStyleBackColor = true;
            this.qcm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.i);
            this.panel1.Controls.Add(this.id_e);
            this.panel1.Controls.Add(this.note);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.id_rep2);
            this.panel1.Controls.Add(this.id_rep_3);
            this.panel1.Controls.Add(this.id_rep_1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.proposition3);
            this.panel1.Controls.Add(this.proposition1);
            this.panel1.Controls.Add(this.proposition2);
            this.panel1.Controls.Add(this.id_input);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.question_input);
            this.panel1.Location = new System.Drawing.Point(27, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 315);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Location = new System.Drawing.Point(175, 249);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(46, 25);
            this.i.TabIndex = 17;
            this.i.Text = "ID_E";
            // 
            // id_e
            // 
            this.id_e.Location = new System.Drawing.Point(175, 277);
            this.id_e.Name = "id_e";
            this.id_e.Size = new System.Drawing.Size(37, 31);
            this.id_e.TabIndex = 16;
            this.id_e.TextChanged += new System.EventHandler(this.id_e_TextChanged);
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(12, 277);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(89, 31);
            this.note.TabIndex = 15;
            this.note.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Note";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // id_rep2
            // 
            this.id_rep2.AutoSize = true;
            this.id_rep2.Location = new System.Drawing.Point(12, 162);
            this.id_rep2.Name = "id_rep2";
            this.id_rep2.Size = new System.Drawing.Size(48, 29);
            this.id_rep2.TabIndex = 13;
            this.id_rep2.Text = "2";
            this.id_rep2.UseVisualStyleBackColor = true;
            this.id_rep2.CheckedChanged += new System.EventHandler(this.id_rep2_CheckedChanged);
            // 
            // id_rep_3
            // 
            this.id_rep_3.AutoSize = true;
            this.id_rep_3.Location = new System.Drawing.Point(12, 200);
            this.id_rep_3.Name = "id_rep_3";
            this.id_rep_3.Size = new System.Drawing.Size(48, 29);
            this.id_rep_3.TabIndex = 12;
            this.id_rep_3.Text = "3";
            this.id_rep_3.UseVisualStyleBackColor = true;
            this.id_rep_3.CheckedChanged += new System.EventHandler(this.id_rep_3_CheckedChanged);
            // 
            // id_rep_1
            // 
            this.id_rep_1.AutoSize = true;
            this.id_rep_1.Location = new System.Drawing.Point(12, 122);
            this.id_rep_1.Name = "id_rep_1";
            this.id_rep_1.Size = new System.Drawing.Size(48, 29);
            this.id_rep_1.TabIndex = 11;
            this.id_rep_1.Text = "1";
            this.id_rep_1.UseVisualStyleBackColor = true;
            this.id_rep_1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proposition";
            // 
            // proposition3
            // 
            this.proposition3.Location = new System.Drawing.Point(77, 194);
            this.proposition3.Name = "proposition3";
            this.proposition3.Size = new System.Drawing.Size(154, 31);
            this.proposition3.TabIndex = 9;
            this.proposition3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // proposition1
            // 
            this.proposition1.Location = new System.Drawing.Point(77, 120);
            this.proposition1.Name = "proposition1";
            this.proposition1.Size = new System.Drawing.Size(154, 31);
            this.proposition1.TabIndex = 8;
            this.proposition1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // proposition2
            // 
            this.proposition2.Location = new System.Drawing.Point(77, 157);
            this.proposition2.Name = "proposition2";
            this.proposition2.Size = new System.Drawing.Size(154, 31);
            this.proposition2.TabIndex = 7;
            this.proposition2.TextChanged += new System.EventHandler(this.proposition2_TextChanged);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(186, 43);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(37, 31);
            this.id_input.TabIndex = 6;
            this.id_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            // 
            // question_input
            // 
            this.question_input.Location = new System.Drawing.Point(12, 43);
            this.question_input.Name = "question_input";
            this.question_input.Size = new System.Drawing.Size(154, 31);
            this.question_input.TabIndex = 2;
            this.question_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Location = new System.Drawing.Point(302, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 315);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(122, 237);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(89, 31);
            this.textBox7.TabIndex = 15;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Note";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(28, 162);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 29);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "faux";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(28, 120);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(67, 29);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "Vrai";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(186, 43);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(37, 31);
            this.textBox11.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Question";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 43);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(154, 31);
            this.textBox12.TabIndex = 2;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(302, 67);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(151, 29);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "Dichotomique";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Location = new System.Drawing.Point(581, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 315);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 147);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(154, 31);
            this.textBox13.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Reponse";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(122, 237);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(89, 31);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Note";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(186, 43);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(37, 31);
            this.textBox9.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Question";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 43);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(154, 31);
            this.textBox10.TabIndex = 2;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(581, 67);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(119, 29);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Q_ouverte\r\n";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(434, 434);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(112, 34);
            this.annuler.TabIndex = 8;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // creer_une_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 480);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.qcm);
            this.Controls.Add(this.label1);
            this.Name = "creer_une_question";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox6;
        private Label label6;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Panel panel2;
        private TextBox textBox7;
        private Label label7;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
        private TextBox textBox11;
        private Label label9;
        private Label label11;
        private TextBox textBox12;
        private CheckBox checkBox8;
        private Panel panel3;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label10;
        private Label label12;
        private TextBox textBox10;
        private CheckBox checkBox10;
        private Button button1;
        private CheckBox qcm;
        private TextBox note;
        private CheckBox id_rep2;
        private CheckBox id_rep_3;
        private CheckBox id_rep_1;
        private TextBox proposition3;
        private TextBox proposition1;
        private TextBox proposition2;
        private TextBox id_input;
        private TextBox question_input;
        private Label i;
        private TextBox id_e;
        private Button annuler;
    }
}