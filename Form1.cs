using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Windows.Forms;

namespace the_note_taking_app
{
    public partial class Form1 : Form
    {
        // the datatable: is the type of the variable the datatable from the System.Data,
        // table: this is the name of the variable we are declaring you can name it any thing
        //now the new Datatable(Table) create an instance of the datatable class
        // new is an operator that allocates memory for the new object
        // Datatable(table) calls the constructor of the datatable class.
        // A constructor is a special method that gets called when an object is instantiated.
        //teble is a parameter passed to the constructor
        DataTable table = new DataTable("table");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Note", typeof(string));
            dataGridView1.DataSource = table;



        }

        private void bttnew_Click(object sender, EventArgs e)
        {
            // the clear is a textbox command that removes all text from the datatable
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttsave_Click(object sender, EventArgs e)
        {

            table.Rows.Add(txtTitle.Text, txtMessage.Text);



        }

        private void bttread_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            // retrieves the index of the currently selected row in the Datagridview control
            // datagridview1.currentcell give you the currently active cell
            // int index = dataGridView1.CurrentCell.RowIndex;

            //This line retrieves the index of the currently selected row in a DataGridView control.
            //dataGridView1.CurrentCell gives you the currently active cell.
            //RowIndex returns the zero-based index of the row containing the active cell.
            //The index variable now holds this row index.
            //if (index > -1)

            //This checks if the index is greater than - 1.
            // Since row indices are zero - based, a valid row index will always be 0 or greater.
            //This condition ensures that there's a selected row and prevents errors that would occur if no row is selected (since RowIndex would be -1).
            //txtTitle.Text = table.Rows[index].ItemArray[0].ToString();

            //This line sets the text of the txtTitle TextBox to the value in the first
            //column(index 0) of the selected row in the DataTable.
            //table.Rows[index] accesses the row at the specified index.    
            //ItemArray[0] retrieves the value of the first column in that row.
            //ToString() converts this value to a string, which is necessary if the value is not already a string.

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }

        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();

        }
    }
}
