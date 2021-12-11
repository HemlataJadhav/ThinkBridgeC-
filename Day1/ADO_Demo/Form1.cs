using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Demo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"server=DESKTOP-47SS10M\SQLEXPRESS;Database=db2021;Integrated Security=true");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select MAX(Id) from Product";
                //responsible to fire query in DB
                cmd = new SqlCommand(qry, con);

                //open a connection with db
                con.Open();
                object obj = cmd.ExecuteScalar();  //when u use select with aggregate function
                if (obj == DBNull.Value)                //null
                {
                    txtProductName.Text = "101";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtProductId.Text = id.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Product values(@id,@name,@price)";
                //responsible to fire query in DB
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductId.Text));
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);

                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                //open a connection with db
                con.Open();
                //actually fire query in  db
                int result = cmd.ExecuteNonQuery();//insert /update ,delete
                if (result == 1)
                {
                    MessageBox.Show("record saved successfully");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Product set Name=@name,price=@price where Id=@id";
                //responsible to fire query in DB
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductId.Text));
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);

                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                //open a connection with db
                con.Open();
                //actually fire query in  db
                int result = cmd.ExecuteNonQuery();//insert /update ,delete
                if (result == 1)
                {
                    MessageBox.Show("record saved successfully");
                }

            }

            catch (Exception)
            {
                MessageBox.Show(" Not Updated");
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("delete from Product where id = " + txtProductId.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                txtProductId.Clear();
                txtProductName.Clear();
                txtPrice.Clear();

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

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where Id=@id ";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductId.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)   //to check record is present or not
                {
                    if (reader.Read())
                    {
                        txtProductName.Text = reader["Name"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
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

        private void btnViewAllDetails_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *  from product";
                //responsible to fire query in DB

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(qry, con);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "product");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;



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
    }
}
