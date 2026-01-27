using System.Collections.Generic;
using System.Windows.Forms;

namespace DerivedClassUsWinForm
{
    public partial class MainForm: Form
    {
        private List<HomoSapiens> peoples_ = new List<HomoSapiens>();
        public MainForm()
        {
            InitializeComponent();
            peoples_.Add(new HomoSapiens("Селизей Тунтунтуныч", 5));
            peoples_.Add(new HomoSapiens("Степания Ничегоделатьнехотелкина", 50));
            peoples_.Add(new Student("АК/121-ку"));
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            foreach(HomoSapiens people in peoples_)
            {
                StudentListBox.AppendText(peoples_.ToString());
            }
        }

    }
}
