using System.Data;

namespace SIMTHE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "select * from sim order by SIM.NGAYKH";
            DataSet ds = kn.LayDuLieu(query);
            banghienthi.DataSource = ds.Tables[0];
        }
    }
}
