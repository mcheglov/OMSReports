using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMSReports
{
    public partial class Report : Form
    {
        toSQLDataContext db = new toSQLDataContext();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oMSDataSet1.RegistryBase". При необходимости она может быть перемещена или удалена.
            var admin = (from a in db.RegistryBase
                         select a.administrator).Distinct();
            adminCB.DataSource = admin;
        }

        private void adminCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminCB.SelectedIndex !=-1)
            {
                var reestr = (from r in db.RegistryBase
                              where r.administrator == adminCB.SelectedValue.ToString()
                              select r.dat_reestr).Distinct();
                reestrCB.DataSource = reestr;
                var month = (from m in db.RegistryBase
                             where m.administrator == adminCB.SelectedValue.ToString()
                             select m.add_dat.Substring(3,7)).Distinct();
                monthCB.DataSource = month;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clients = (from r in db.RegistryBase
                          where r.administrator == adminCB.SelectedValue.ToString()
                          where r.dat_reestr == reestrCB.SelectedValue.ToString()
                          select r.hist_nom).Distinct();
            clientsLB.Text = clients.Count().ToString();
            var tests = (from r in db.RegistryBase
                           where r.administrator == adminCB.SelectedValue.ToString()
                           where r.dat_reestr == reestrCB.SelectedValue.ToString()
                           select r.hist_nom);
            testsLB.Text = tests.Count().ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (monthCB.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Дата", typeof(string)));
                dt.Columns.Add(new DataColumn("Пациентов", typeof(int)));
                dt.Columns.Add(new DataColumn("Тестов", typeof(int)));
                var dayofmonth = (from dom in db.RegistryBase
                                  where dom.administrator == adminCB.SelectedValue.ToString()
                                  where dom.add_dat.Contains(monthCB.SelectedValue.ToString())
                                  select dom.add_dat.Substring(0, 10)).Distinct();
                for (int i = 0; i < dayofmonth.Count(); i++)
                {
                    var record = from r in db.RegistryBase
                                 where r.administrator == adminCB.SelectedValue.ToString()
                                 where r.add_dat.Contains(dayofmonth.ToList().ElementAt(i).ToString())
                                 select r;
                    DataRow dr = dt.NewRow();
                    dr["Дата"] = record.ToList().ElementAt(0).add_dat.ToString().Substring(0, 10);
                    dr["Пациентов"] = record.Select(X => X.hist_nom).Distinct().Count();
                    dr["Тестов"] = record.Count();
                    dt.Rows.Add(dr);
                }
                monthDGV.DataSource = dt;
                int clients=0;
                int tests =0;
                for (int i=0;i<dt.Rows.Count; i++)
                {
                    clients = clients + Convert.ToInt16(dt.Rows[i][1].ToString());
                    tests = tests + Convert.ToInt16(dt.Rows[i][2].ToString());
                }
                monthclientsLB.Text = clients.ToString();
                monthtestsLB.Text = tests.ToString();
            }
        }

        private void dayCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tests = (from t in db.RegistryBase
                        where t.administrator == adminCB.SelectedValue.ToString()
                        where t.add_dat.Contains(dayMTB.Text)
                        select new { t.hist_nom, t.name_1,}).Distinct();
            daysDGV.DataSource = tests;
            daysDGV.Columns[0].HeaderText = "История болезни";
            daysDGV.Columns[1].HeaderText = "Фамилия";
        }
    }
}
