using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guibotomat
{
    public class Connection
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=RobotsSQLite.db3");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataTable dt;
        SQLiteDataReader reader;

        public void refreshDataGrid(DataGridView dataGridView)
        {
            conn.Open();

            adapter = new SQLiteDataAdapter("select * from robots", conn);

            dt = new DataTable();

            adapter.Fill(dt);

            dataGridView.DataSource = dt;

            conn.Close();

            var height = 0;
            foreach (DataGridViewRow dr in dataGridView.Rows)
            {
                height += dr.Height;
            }
            dataGridView.Height = height;

        }

        public void delete(string id_selected)
        {

            conn.Open();
            cmd = new SQLiteCommand("delete from robots where id="+id_selected+"", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void update(string robotid, string name, string type)
        {
            conn.Open();
            cmd = new SQLiteCommand("update robots set name='"+name+"', type='"+type+"' where id="+robotid+"", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void updatePoints(string name, int tasks, int points)
        {
            conn.Open();
            cmd = new SQLiteCommand("update robots set points=" + points + ", tasks=" + tasks + " where name='" + name + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void insert(Robot robot)
        {
            conn.Open();
            cmd = new SQLiteCommand("insert into robots (name, type, tasks, points) values('" + robot.name +
                    "', '" + robot.type + "', 0, 0)", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void scoreboards(DataGridView _dgv)
        {
            conn.Open();
            cmd = new SQLiteCommand("select name, points from robots order by points desc", conn);

            adapter = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            _dgv.DataSource = dt;

            conn.Close();


            var height = 0;
            foreach (DataGridViewRow dr in _dgv.Rows)
            {
                height += dr.Height;
            }
            _dgv.Height = height;
        }
    }
}
