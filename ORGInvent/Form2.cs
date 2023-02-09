using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ORGInvent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            using (var db = new Data.MyDbContext())
            {
                foreach (var pc in db.Equipments)
                {
                    var generalInfo = db.GeneralInformation.Where(g => g.Id == pc.GeneralInformationId).FirstOrDefault();
                    var worker = pc.Workers;
                    pcData.Rows.Add
                        (
                            pc.Id, 
                            pc.Type, 
                            generalInfo.Name, 
                            generalInfo.Model, 
                            generalInfo.InventoryNumber, 
                            generalInfo.Manufacturer, 
                            generalInfo.IpAddress, 
                            worker?.FullName, 
                            worker?.Department, 
                            worker?.Cabinet
                        );
                }

            }
        }

        public void Form_closed_event(object sender, EventArgs e) => Application.Exit();

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i <= 123; i++) {
                pcData.Rows.Add(i, 124, 23);
            }
        }

        private async void pcData_CellContentClick(object sender, EventArgs e)
        {
            //textBox1.Text = pcData.CurrentRow.Cells["name"].FormattedValue.ToString();
            return;
        }
    }
}
