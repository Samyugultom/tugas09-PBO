using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;


namespace pbo_tm
{
    public partial class _Default : Page
    {

protected void btnInsertion_Click(object sender, EventArgs e)
    {
        try
        {
            /* Insertion After Validations*/
            using (NpgsqlConnection connection = new NpgsqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ToString();
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Insert into kos (id_ruangan,nama_ruangan,nama_penyewa,fasilitas_ruangan) values(@ID,@nameR,@nameP,@Fasilitas)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtkosID.Text)));
                cmd.Parameters.Add(new NpgsqlParameter("@nameR", txtkosnameR.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@nameP", txtkosnameP.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@Fasilitas", txtkosfasilitas.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                txtkosfasilitas.Text = "";
                txtkosnameR.Text = "";
                txtkosID.Text = "";
                txtkosnameP.Text = "";
                lblmsg.Text = "Data Has been Saved";
            }
        }
        catch (Exception ex) {
                lblmsg.Text = "Data not be saved";
            }
    }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from kos";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex) { }
        }

        protected void btnUpdation_Click(object sender, EventArgs e)
        {
            try /* Updation After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update kos set namaruangan=@nameR,nama_penyewa=@nameP,fasilitas_ruangan=@Fasilitas where id_ruangan=@ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtkosID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@nameR", txtkosnameR.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@nameP", txtkosnameP.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Fasilitas", txtkosfasilitas.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtkosfasilitas.Text = "";
                    txtkosnameR.Text = "";
                    txtkosID.Text = "";
                    txtkosnameP.Text = "";
                    lblmsg.Text = "Data Has been Updated";
                }
            }
            catch (Exception ex) { }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try /* Deletion After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Delete from kos where id_ruangan=@ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtRuanganID.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtkosID.Text = "";
                    lblmessage.Text = "Data Has been Deleted";
                }
            }
            catch (Exception ex) { }
        }

    }
}