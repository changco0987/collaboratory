using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collaboratory.Model;


namespace Collaboratory
{
    public partial class EditUploadPage : Form
    {
        public EditUploadPage()
        {
            InitializeComponent();

            //The default/passed value
            titleTb.Text = SelectedUpdateData.title;
            noteTb.Text = SelectedUpdateData.note;
            letterCountLb.Text = noteTb.Text.Count() + "/" + noteTb.MaxLength;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //To clear all data from static model
            SelectedUpdateData selectedUpdateData = new SelectedUpdateData();
            selectedUpdateData.reset();
        }

        private void noteTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (noteTb.Text.Count() <= 280)
            {

                letterCountLb.Text = noteTb.Text.Count() + "/" + noteTb.MaxLength;
            }
            else
            {
                letterCountLb.ForeColor = Color.Red;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this post?\nThis can't be undone.", "Post Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tb_updates conn = new tb_updates();
                Updatedata updatedata = new Updatedata();

                updatedata.id = SelectedUpdateData.id;
                conn.DeletePost(updatedata);

                MessageBox.Show("Delete successfully!");
                this.Close();
            }
            else 
            {
                return;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            tb_updates conn = new tb_updates();
            Updatedata updatedata = new Updatedata();

            updatedata = updatedata.statModelToModel(updatedata);//To transfer all data from static model to non-static model
            updatedata.title = titleTb.Text;
            updatedata.note = noteTb.Text;

            conn.UpdatePost(updatedata);

            this.Close();
        }
    }
}
