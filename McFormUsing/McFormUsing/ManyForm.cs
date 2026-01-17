using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace McFormUsing
{
    public partial class ManyForm : Form
    {
        public ManyForm()
        {
            InitializeComponent();
        }

        private void FileNameListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ///MessageBox.Show(FileNameListBox.SelectedIndex.ToString());
            ///MessageBox.Show(FileNameListBox.SelectedItem.ToString());
            if (FileNameListBox.SelectedItem != null)
            {
                PictureArea.Image = Image.FromFile(FileNameListBox.SelectedItem.ToString());
            }
        }

        private void LoadButton_Click(object sender, System.EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    FileNameListBox.Items.Add(filePath);
                }
            }
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            string message = "Точно хотите удалить этот объект?";
            string caption = "Удаление объекта";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                FileNameListBox.Items.RemoveAt(FileNameListBox.SelectedIndex);
            }
        }
    }
}
