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

namespace Tourism
{
    public partial class StepFour : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        //string connectionString = ("Data Source = DBSRV\\DEMO; Database = 007caGneydingDE; Integrated Security = true;");
        //string sql = "SELECT * FROM [Бронирование]";
        // 'Общая стоимость бронирования ($)', 'Дата заезда', 'Наименование отеля'
        public StepFour()
        {
            InitializeComponent();
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.AllowUserToAddRows = false;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    adapter = new SqlDataAdapter(sql, connection);

            //    ds = new DataSet();
            //    adapter.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0];
            //    dataGridView1.Columns["№ Брони"].ReadOnly = true;
            //}
        }
    }
}
