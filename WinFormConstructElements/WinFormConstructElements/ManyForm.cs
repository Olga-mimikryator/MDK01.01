using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormConstructElements
{
    public partial class ManyForm: Form
    {
        public ManyForm()
        {
            InitializeComponent();
            Student st1 = new Student("Анастасия Ничегонехочуделкина", 16, "ТК/155-ку", 4.45, "");
            Student st2 = new Student("Екатерина Ленилкина", 17, "ТК/141-ку", 3.8, "");
            Student st3= new Student("Евгений Гадалкин", 16, "ТК/162-ку", 3.7, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\bro.jpg");
            Student st4 = new Student("Борис Губодуев", 18, "ТК/136-ку", 4.0, "");

            List <Student> Students = new List<Student>();
            Students.Add(st1);
            Students.Add(st2);
            Students.Add(st3);
            Students.Add(st4);
            StudentList.DataSource = Students;
            StudentList.DisplayMember = "Name";
        }

        private void StudentList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Student student = StudentList.SelectedItem as Student;
            nameLabel.Text = "Студент: " +student.Name;
            ageLabel.Text = "Возраст: " +student.Age.ToString();
            numberLabel.Text = "Номер билета: " +student.Number.ToString();
            argBallLabel.Text = "Средний балл: " +student.ArgBall.ToString();
            if (student.Photo != null)
            {
                StudentPhoto.Image = Image.FromFile(student.Photo.ToString());
            }
        }
    }
}
