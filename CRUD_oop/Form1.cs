using CRUD_oop.myclass;
using MySql.Data.MySqlClient;

namespace CRUD_oop
{
    public partial class Form1 : Form
    {

        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATE();
            READ();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.Read_data();
            dataGridView1.DataSource = crud.dt;
        }

        //Create
        public void CREATE()
        {
            crud.name = c_name.Text;
            crud.number = c_mobile.Text;
            crud.address = c_address.Text;

            crud.Create_data();
        }

        // Update 
        public void UPDATE()
        {
            crud.name = u_name.Text;
            crud.number = u_mobile.Text;
            crud.address = u_address.Text;
            crud.id = lb_ID.Text;

            crud.Update_data();
        }

        // Delete
        public void DELETE()
        {
            crud.id = lb_ID.Text;
            crud.Delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lb_ID.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    u_mobile.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    u_address.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't click the header!");
            }
        }

        // Get Data

    }
}