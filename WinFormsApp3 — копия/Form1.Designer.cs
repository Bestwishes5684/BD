namespace WinFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.all = new System.Windows.Forms.ToolStripLabel();
            this.credited = new System.Windows.Forms.ToolStripLabel();
            this.human = new System.Windows.Forms.ToolStripLabel();
            this.all1 = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridstudent = new System.Windows.Forms.DataGridView();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datarod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Russian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oprogram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.delite = new System.Windows.Forms.ToolStripButton();
            this.change = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.all,
            this.credited,
            this.human,
            this.all1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // all
            // 
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(0, 22);
            // 
            // credited
            // 
            this.credited.Name = "credited";
            this.credited.Size = new System.Drawing.Size(242, 22);
            this.credited.Text = "Студенты, набравшие больше 150 баллов:";
            // 
            // human
            // 
            this.human.Name = "human";
            this.human.Size = new System.Drawing.Size(56, 22);
            this.human.Text = "М: 0 Ж: 0";
            // 
            // all1
            // 
            this.all1.Name = "all1";
            this.all1.Size = new System.Drawing.Size(105, 22);
            this.all1.Text = "Всего учащихся 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridstudent
            // 
            this.dataGridstudent.AllowUserToAddRows = false;
            this.dataGridstudent.AllowUserToDeleteRows = false;
            this.dataGridstudent.AutoGenerateColumns = false;
            this.dataGridstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio,
            this.Datarod,
            this.Pol,
            this.FORM,
            this.MATH,
            this.Russian,
            this.Inform,
            this.total_total});
            this.dataGridstudent.DataSource = this.studentBindingSource;
            this.dataGridstudent.Location = new System.Drawing.Point(0, 52);
            this.dataGridstudent.Name = "dataGridstudent";
            this.dataGridstudent.RowTemplate.Height = 25;
            this.dataGridstudent.Size = new System.Drawing.Size(826, 370);
            this.dataGridstudent.TabIndex = 3;
            this.dataGridstudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridstudent_CellFormatting_1);
            this.dataGridstudent.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Fio
            // 
            this.Fio.DataPropertyName = "FullName";
            this.Fio.HeaderText = "ФИО";
            this.Fio.Name = "Fio";
            // 
            // Datarod
            // 
            this.Datarod.DataPropertyName = "Datarod";
            this.Datarod.HeaderText = "Дата Рождения ";
            this.Datarod.Name = "Datarod";
            // 
            // Pol
            // 
            this.Pol.DataPropertyName = "Gender";
            this.Pol.HeaderText = "Пол";
            this.Pol.Name = "Pol";
            // 
            // FORM
            // 
            this.FORM.DataPropertyName = "FormOB";
            this.FORM.HeaderText = "Форма обучения ";
            this.FORM.Name = "FORM";
            // 
            // MATH
            // 
            this.MATH.DataPropertyName = "Math";
            this.MATH.HeaderText = "ЕГЭ по Математике";
            this.MATH.Name = "MATH";
            // 
            // Russian
            // 
            this.Russian.DataPropertyName = "Russ";
            this.Russian.HeaderText = "Егэ по русскому";
            this.Russian.Name = "Russian";
            // 
            // Inform
            // 
            this.Inform.DataPropertyName = "inf";
            this.Inform.HeaderText = "Егэ по информатике";
            this.Inform.Name = "Inform";
            // 
            // total_total
            // 
            this.total_total.DataPropertyName = "total";
            this.total_total.HeaderText = "всего баллов";
            this.total_total.Name = "total_total";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WinFormsApp3.Student);
            // 
            // oprogram
            // 
            this.oprogram.Name = "oprogram";
            this.oprogram.Size = new System.Drawing.Size(97, 20);
            this.oprogram.Text = "О программе ";
            this.oprogram.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oprogram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delite,
            this.change});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(826, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // add
            // 
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(129, 22);
            this.add.Text = "Добавить студента";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delite
            // 
            this.delite.Enabled = false;
            this.delite.Image = ((System.Drawing.Image)(resources.GetObject("delite.Image")));
            this.delite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delite.Name = "delite";
            this.delite.Size = new System.Drawing.Size(120, 22);
            this.delite.Text = "удалить студента";
            this.delite.Click += new System.EventHandler(this.delite_Click);
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Image = ((System.Drawing.Image)(resources.GetObject("change.Image")));
            this.change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(129, 22);
            this.change.Text = "изменить студента";
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridstudent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Приёмная комиссия ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel all;
        private ToolStripLabel credited;
        private ToolStripLabel human;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridstudent;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn Fio;
        private DataGridViewTextBoxColumn Datarod;
        private DataGridViewTextBoxColumn Pol;
        private DataGridViewTextBoxColumn FORM;
        private DataGridViewTextBoxColumn MATH;
        private DataGridViewTextBoxColumn Russian;
        private DataGridViewTextBoxColumn Inform;
        private DataGridViewTextBoxColumn total_total;
        private ToolStripMenuItem oprogram;
        private ToolStripMenuItem DeliteToolStripMenuItem;
        private ToolStripMenuItem ChangeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip2;
        private ToolStripButton add;
        private ToolStripButton delite;
        private ToolStripButton change;
        private ToolStripLabel all1;
    }
}