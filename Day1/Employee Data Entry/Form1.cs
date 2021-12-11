using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Data_Entry
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"server=DESKTOP-47SS10M\SQLEXPRESS;Database=db2021;Integrated Security=true ");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDepartmentNumber.Clear();
            txtId.Clear();
            txtName.Clear();
            txtSalary.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee_Data_entry values(@emp_id,@emp_name,@salary,@dept_number)";
                //responsible to fire query in DB
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@emp_id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@emp_name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                cmd.Parameters.AddWithValue("@dept_number", Convert.ToInt32(txtDepartmentNumber.Text));
                //open a connection with db
                con.Open();
                //actually fire query in  db
                int result = cmd.ExecuteNonQuery();//insert /update ,delete
                if (result == 1)
                {
                    MessageBox.Show("record inserted successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Employee_data_entry where Emp_id = " + txtId.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                txtId.Clear();
                txtName.Clear();
                txtSalary.Clear();
                txtDepartmentNumber.Clear();

            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select MAX(emp_Id) from Employee_data_entry";
                //responsible to fire query in DB
                cmd = new SqlCommand(qry, con);

                //open a connection with db
                con.Open();
                object obj = cmd.ExecuteScalar();  //when u use select with aggregate function
                if (obj == DBNull.Value)                //null
                {
                    txtId.Text = "101";
                }
                else
                {
                    int emp_id = Convert.ToInt32(obj);
                    emp_id++;
                    txtId.Text = emp_id.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *  from employee_data_entry";
                //responsible to fire query in DB

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(qry, con);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "employee_data_entry");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
