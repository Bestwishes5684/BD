namespace WinFormsApp3
{
    partial class Form2
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formoB = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Matem = new System.Windows.Forms.NumericUpDown();
            this.Russk = new System.Windows.Forms.NumericUpDown();
            this.informat = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Matem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Russk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(191, 196);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(121, 23);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Баллы ЕГЭ по математике";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Баллы ЕГЭ по русскому";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Баллы ЕГЭ по информатике";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Форма обучения";
            // 
            // formoB
            // 
            this.formoB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.formoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formoB.FormattingEnabled = true;
            this.formoB.Location = new System.Drawing.Point(191, 281);
            this.formoB.Name = "formoB";
            this.formoB.Size = new System.Drawing.Size(121, 24);
            this.formoB.TabIndex = 13;
            this.formoB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.formoB_DrawItem_1);
            this.formoB.SelectedIndexChanged += new System.EventHandler(this.formoB_SelectedIndexChanged);
            // 
            // gender
            // 
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.IntegralHeight = false;
            this.gender.Location = new System.Drawing.Point(191, 225);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 24);
            this.gender.TabIndex = 14;
            this.gender.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.gender_DrawItem_1);
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дата рождения";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(191, 251);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(200, 23);
            this.age.TabIndex = 16;
            this.age.ValueChanged += new System.EventHandler(this.age_ValueChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(191, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Matem
            // 
            this.Matem.Location = new System.Drawing.Point(191, 318);
            this.Matem.Name = "Matem";
            this.Matem.Size = new System.Drawing.Size(120, 23);
            this.Matem.TabIndex = 19;
            this.Matem.ValueChanged += new System.EventHandler(this.Matem_ValueChanged);
            // 
            // Russk
            // 
            this.Russk.Location = new System.Drawing.Point(191, 347);
            this.Russk.Name = "Russk";
            this.Russk.Size = new System.Drawing.Size(120, 23);
            this.Russk.TabIndex = 20;
            this.Russk.ValueChanged += new System.EventHandler(this.Russk_ValueChanged);
            // 
            // informat
            // 
            this.informat.Location = new System.Drawing.Point(191, 376);
            this.informat.Name = "informat";
            this.informat.Size = new System.Drawing.Size(120, 23);
            this.informat.TabIndex = 21;
            this.informat.ValueChanged += new System.EventHandler(this.informat_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp3.Properties.Resources.книга_чтения_ма_ьчика_на_бе_изне_83438320;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.informat);
            this.Controls.Add(this.Russk);
            this.Controls.Add(this.Matem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.formoB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
       
            this.Text = "Добавить студента ";
            ((System.ComponentModel.ISupportInitialize)(this.Matem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Russk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private ComboBox formoB;
        private ComboBox gender;
        private Label label8;
        private DateTimePicker age;
        private Button button1;
        private Button btnClose;
        private NumericUpDown Matem;
        private NumericUpDown Russk;
        private NumericUpDown informat;
        private PictureBox pictureBox1;
    }
}