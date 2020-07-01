using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;


namespace aula
{
	
	public partial class Like : Form
	{
		public Like()
		{	
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			MySqlConnectionStringBuilder str = new MySqlConnectionStringBuilder();
			str.Server = "remotemysql.com";
			str.UserID = "269CpcWeCz";
			str.Password = "cfW77mMFx4";
			str.Database = "269CpcWeCz";
			
			MySqlConnection con = new MySqlConnection();
			con.ConnectionString = str.ConnectionString;
            con.Open();
			MySqlCommand com = new MySqlCommand();
			com.Connection = con;
			com.CommandText = "SELECT * FROM estados WHERE uf=@uf";
			com.Parameters.AddWithValue("@uf", TXTbuscar.Text);
			MySqlDataReader dr = com.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(dr);
			dataGridView1.DataSource = dt;			
						
			con.Close();
		}

        
    }
}
