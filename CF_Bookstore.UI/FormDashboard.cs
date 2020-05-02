using CF_Bookstore.DataAccess.Context;
using CF_Bookstore.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CF_Bookstore.UI
{
    public partial class FormDashboard : Form
    {
        
        
        public FormDashboard()
        {
            InitializeComponent();
        }
        #region Form_Operations
        // context instances 
        ProjeContext pc = new ProjeContext();
        Book book = new Book();
        Author author = new Author();
        BookAuthor bookAuthor = new BookAuthor();
        /*--------------------------------------*/
        //FormDashboard Load  
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            gbxBook.Enabled = false;
            gbxBookOpr.Enabled = false;
            gbxAuthor.Enabled = false;
            gbxFindByName.Enabled = false;
            gbxFindByTitle.Enabled = false;
            gbxAuthorOpr.Enabled = false;
            gbxBookAuthor.Enabled = false;
        }
        //datagridview -->
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtBookTitle.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtTotalPages.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            nudRating.Value = Convert.ToDecimal(dataGridView.CurrentRow.Cells[3].Value.ToString());
            txtISBN.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();

        }
        //clear gboxes 
        void ResetAll(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
                if (ctrl is ListBox)

                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.ClearSelected();
                }
                if (ctrl is NumericUpDown)

                {
                    NumericUpDown numericUpDown = (NumericUpDown)ctrl;
                    numericUpDown.Value = 0;
                }
            }

        }
        //exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Book_Operations
        //Add Book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            book.BookId = Convert.ToInt32(txtBookId.Text);
            book.Title = txtBookTitle.Text;
            book.ISBN = Convert.ToInt32(txtISBN.Text);
            book.Rating = nudRating.Value;
            book.TotalPages = Convert.ToInt32(txtTotalPages.Text);
            pc.Books.Add(book);
            pc.SaveChanges();
            ResetAll(gbxBook);
            dataGridView.DataSource = pc.Books.ToList();
        }
        //Update Book
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this row?", "Update Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(txtBookId.Text);
                var update = pc.Books.Where(x => x.BookId == id).FirstOrDefault();
                update.Title = txtBookTitle.Text;
                update.TotalPages = Convert.ToInt32(txtTotalPages.Text);
                update.Rating = nudRating.Value;
                update.ISBN = Convert.ToInt32(txtISBN.Text);
                pc.SaveChanges();

            }
            else
            {
                MessageBox.Show("Row Not Updated", "Update Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ResetAll(gbxBook);
            dataGridView.DataSource = pc.Books.ToList();
        }
        //Delete Book
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            var delete = pc.Books.Where(x => x.BookId == id).FirstOrDefault();

            if (MessageBox.Show("Do you want to delete this row?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                pc.Books.Remove(delete);
                pc.SaveChanges();

            }
            else
            {
                MessageBox.Show("Row Not Removed", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetAll(gbxBook);
            dataGridView.DataSource = pc.Books.ToList();

        }
        //Get All Book
        private void btnGetAllBook_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = pc.Books.ToList();
            ResetAll(gbxBook);
        }
        #endregion


        #region Enable_Buttons
        private void btnBookEnable_Click(object sender, EventArgs e)
        {
            btnBookEnable.BackColor = Color.LightGreen;
            btnAuthorEnable.BackColor = Color.LightPink;
            btnBAEnable.BackColor = Color.LightPink;
            lblBookOpShow.Visible = false;
            lblBookShow.Visible = false;
            dataGridView.DataSource = null;
            gbxBook.Enabled = true;
            gbxBookOpr.Enabled = true;
            gbxAuthor.Enabled = false;
            gbxFindByName.Enabled = false;
            gbxFindByTitle.Enabled = true;
            gbxAuthorOpr.Enabled = false;
            gbxBookAuthor.Enabled = false;
            ResetAll(gbxBook);
            ResetAll(gbxAuthor);
            ResetAll(gbxBookAuthor);
            ResetAll(gbxFindByName);
            ResetAll(gbxFindByTitle);

        }

        private void btnAuthorEnable_Click(object sender, EventArgs e)
        {
            btnBookEnable.BackColor = Color.LightPink;
            btnAuthorEnable.BackColor = Color.LightGreen;
            btnBAEnable.BackColor = Color.LightPink;
            lblBookOpShow.Visible = true;
            lblBookShow.Visible = true;
            dataGridView.DataSource = null;
            gbxBook.Enabled = false;
            gbxBookOpr.Enabled = false;
            gbxAuthor.Enabled = true;
            gbxFindByName.Enabled = true;
            gbxFindByTitle.Enabled = false;
            gbxAuthorOpr.Enabled = true;
            gbxBookAuthor.Enabled = false;
            ResetAll(gbxBook);
            ResetAll(gbxAuthor);
            ResetAll(gbxBookAuthor);
            ResetAll(gbxFindByName);
            ResetAll(gbxFindByTitle);
        }

        private void btnBAEnable_Click(object sender, EventArgs e)
        {
            btnBookEnable.BackColor = Color.LightPink;
            btnAuthorEnable.BackColor = Color.LightPink;
            btnBAEnable.BackColor = Color.LightGreen; 
            dataGridView.DataSource = null;
            gbxBook.Enabled = false;
            gbxBookOpr.Enabled = false;
            gbxAuthor.Enabled = false;
            gbxFindByName.Enabled = false;
            gbxFindByTitle.Enabled = false;
            gbxAuthorOpr.Enabled = false;
            gbxBookAuthor.Enabled = true;
            ResetAll(gbxBook);
            ResetAll(gbxAuthor);
            ResetAll(gbxBookAuthor);
            ResetAll(gbxFindByName);
            ResetAll(gbxFindByTitle);
        }
        #endregion

    }
}
