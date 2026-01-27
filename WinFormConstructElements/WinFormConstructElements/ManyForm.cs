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
            Student st1 = new Student("Анастасия Ничегонехочунеделкина", 16, "ТК/155-ку", 4.45, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\NOO.jpg");
            Student st2 = new Student("Екатерина Ленилкина", 17, "ТК/141-ку", 3.8, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\yap.jpg");
            Student st3 = new Student("Евгений Гадалкин", 16, "ТК/162-ку", 3.7, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\bro.jpg");
            Student st4 = new Student("Борис Губодуев", 18, "ТК/136-ку", 4.0, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\nerd.jpg");
            Student st5 = new Student("Кид Ничегонепонималкин", 7, "ТК/187-ку", 2.5, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\littlebro.jpg");
            Student st6 = new Student("Светлана Сколледжаприходитьспатьложилкина", 19, "ТК/135-ку", 4.8, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\впадлу.jpg");
            Student st7 = new Student("Мадс Миккельсен", 60, "ТК/99-ку", 5.0, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\ганибаллектор.jpg");
            Student st8 = new Student("Внезапный Серега Бурунов", 1, "ТК/999-ку", 4.25, "D:\\П-30\\сафонова реп\\WinFormConstructElements\\бурунов.jpg");
            
            List<Student> Students = new List<Student>();
            Students.Add(st1);
            Students.Add(st2);
            Students.Add(st3);
            Students.Add(st4);
            Students.Add(st5);
            Students.Add(st6);
            Students.Add(st7);
            Students.Add(st8);
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

        private void ManyForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
