using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UserStrory.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp3
{
    public partial class Form1 : Form

    {
        int age = 0;
        private readonly Student student;
        private readonly List<Student> Students;
    
        public DbContextOptions<ApplicationContext> options;
        public Form1()
        {
            InitializeComponent();

            dataGridstudent.AutoGenerateColumns = false;
            Students = new List<Student>();
            

       
            options = DataBaseHelper.Option();
            dataGridstudent.DataSource = ReadDB(options);
           



        }

     
        private void delite_Click(object sender, EventArgs e)
        {
            var id = (Student)dataGridstudent.Rows[dataGridstudent.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {id.FullName}",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveDB(options, id);
                dataGridstudent.DataSource = ReadDB(options);
                CalculateScrol();
            } 
        }
        private void CalculateScrol()
        {
            all1.Text = $"Всего учащихся {Students.Count.ToString()}";
            var male = Students.Where(x => x.Gender == Gender.Male).Count();
            var female = Students.Count(x => x.Gender == Gender.Female);
            human.Text = $"M: {male} Ж: {female}";


            

            var Kol = 0;
            foreach (var student in Students)
            {
                if ((student.Math + student.Russ + student.inf) > 150)
                {
                    Kol++;
                }
            }
            credited.Text = $"Студенты, набравшие больше 150 баллов: " + Kol;
        }

        private void change_Click(object sender, EventArgs e)
        {
            var id = (Student)dataGridstudent.Rows[dataGridstudent.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new Form2(id);

            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.FullName = infoForm.Student.FullName;
                id.Gender = infoForm.Student.Gender;
                id.Datarod = infoForm.Student.Datarod;
                id.inf = infoForm.Student.inf;
                id.Russ = infoForm.Student.Russ;
                id.Math = infoForm.Student.Math;
                id.FormOB = infoForm.Student.FormOB;
                UpdateDB(options, id);
                CalculateScrol();
                dataGridstudent.DataSource = ReadDB(options);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
            delite.Enabled= dataGridstudent.SelectedRows.Count > 0;
            change.Enabled = dataGridstudent.SelectedRows.Count >0;
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            var stdInfoForm = new Form2();
            if (stdInfoForm.ShowDialog(this) == DialogResult.OK)
            {
             
                CreateDB(options, stdInfoForm.Student);
                CalculateScrol();
                dataGridstudent.DataSource = ReadDB(options);
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Задумин Р.А " +"\n"+
                "группа: Ип-20-3" +"\n"+
                "Команда: 2");
        }

        private void dataGridstudent_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var student = (Student)dataGridstudent.Rows[e.RowIndex].DataBoundItem;
            if (dataGridstudent.Columns[e.ColumnIndex].Name == "total_total")
            {

                e.Value = Math.Round(student.Math + student.Russ + student.inf);
            }

            if (dataGridstudent.Columns[e.ColumnIndex].Name == "Pol")
            {
                var gender = (Gender)e.Value;
                switch (gender)
                {
                    case Gender.Male:
                        e.Value = "Мужской";
                        break;
                    case Gender.Female:
                        e.Value = "Женский";
                        break;
                }
            }


            if (dataGridstudent.Columns[e.ColumnIndex].Name == "Datarod")
            {
                var data = (Student)dataGridstudent.Rows[e.RowIndex].DataBoundItem;
                int i = (bool)(DateTime.Now.Day > data.Datarod.Day && DateTime.Now.Month >= data.Datarod.Month) ? -1 : 0;
                age += DateTime.Now.Year - data.Datarod.Year + i;
                e.Value = age;
                age = 0;
            }
            if (dataGridstudent.Columns[e.ColumnIndex].Name == "FORM")
            {
                var forma = (FormOB)e.Value;
                switch (forma)
                {
                    case (FormOB.fulltime):
                        e.Value = "Очное";
                        break;
                    case (FormOB.correspondence):
                        e.Value = "Заочное";
                        break;
                    case (FormOB.both):
                        e.Value = "Очно-заочно";
                        break;
                }
            }
        }

        private static void CreateDB(DbContextOptions<ApplicationContext> options, Student studenti)
        {
            using (var db = new ApplicationContext(options))
            {
                Student s = new Student();
                studenti.Id = s.Id;
                db.StudentDB.Add(studenti);
                db.SaveChanges();
            }
        }

        private static void RemoveDB(DbContextOptions<ApplicationContext> options,Student studenti)
        {
            using (var db = new ApplicationContext(options))
            {
                var Students = db.StudentDB.FirstOrDefault(x => x.Id == studenti.Id);
                if (Students != null)
                {
                    db.StudentDB.Remove(Students);
                    db.SaveChanges();
                }

            }
        }


        private static void UpdateDB(DbContextOptions<ApplicationContext> options,Student studenti)
        {
            using (var db = new ApplicationContext(options))
            {
                var studentsi = db.StudentDB.FirstOrDefault(x => x.Id == studenti.Id);
                if (studentsi != null)
                {
                    studentsi.FullName = studenti.FullName;
                    studentsi.Id = studenti.Id;
                    studentsi.Datarod = studenti.Datarod;
                    studentsi.FormOB = studenti.FormOB;
                    studentsi.Russ = studenti.Russ;
                    studentsi.Math = studenti.Math;
                    studentsi.inf = studenti.inf;
                    studentsi.total = studenti.total;
                    studentsi.Gender = studenti.Gender;
                    db.SaveChanges();
                }
            }
        }

        private static List<Student> ReadDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.StudentDB
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }
        }
    }
    }