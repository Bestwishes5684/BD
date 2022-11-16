using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Schema;
using UserStrory.Models;


namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        private readonly Student student;
       

        public Form2()
        {
            InitializeComponent();
            FillGender();
            formobfill();
            this.Text = "Добавления студента";
            student = new Student
            {
                Datarod  = DateTime.Now.AddYears(-16),
                Gender = Gender.Male,
               FormOB = FormOB.fulltime
            };
            gender.SelectedItem = student.Gender;
            age.Value = student.Datarod;
            formoB.SelectedItem = student.FormOB;
        }
        public Form2(Student source): this()
        {
            this.Text = "Редактирование студента";
            Name.Text = source.FullName;
           formoB.SelectedItem = source.FormOB;
            gender.SelectedItem = source.Gender;
            age.Value = source.Datarod;
            Matem.Value = source.Math;
            Russk.Value = source.Russ;
            informat.Value = source.inf;
           
           
        }
        public Student Student => student;

        public void FillGender()
        {
            foreach (Gender item in Enum.GetValues(typeof(Gender)))
            {
                gender.Items.Add(item);
            }
        }

        public void formobfill()
        {
            foreach (FormOB item in Enum.GetValues(typeof(FormOB)))
            {
                formoB.Items.Add(item);
            }
        }
     
      

        public new void Validate()
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(student.FullName);
        }

  

       

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void gender_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Gender gender)
                    {
                        var text = gender == Gender.Male
                            ? "Mужской"
                            : "Женский";

                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }

        private void formoB_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            var OB = sender as ComboBox;
            if (OB != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(OB.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (OB.Items[e.Index] is FormOB FormOB)
                    {

                        string text = "";
                        switch (FormOB)
                        {
                            case (FormOB.fulltime):
                                text = "Очное";
                                break;
                            case (FormOB.correspondence):
                                text = "заочная";
                                break;
                            case (FormOB.both):
                                text = "Очно-заочно";
                                break;
                        }

                        e.Graphics.DrawString(
                            text,
                            OB.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                            OB.Items[e.Index].ToString(),
                            OB.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }

        private void gender_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (formoB.SelectedIndex >= 0)
            {
                student.Gender = (Gender)gender.SelectedItem;
            }
        }

        private void formoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formoB.SelectedIndex >= 0)
            {
                student.FormOB = (FormOB)formoB.SelectedItem;
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            student.FullName = Name.Text.Trim();
            Validate();
        }

        private void age_ValueChanged(object sender, EventArgs e)
        {
            student.Datarod = age.Value;
        }

        private void Matem_ValueChanged(object sender, EventArgs e)
        {
            student.Math = Matem.Value;
        }

        private void Russk_ValueChanged(object sender, EventArgs e)
        {
            student.Russ = Russk.Value;
        }

        private void informat_ValueChanged(object sender, EventArgs e)
        {
            student.inf = informat.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
   
    }
    

