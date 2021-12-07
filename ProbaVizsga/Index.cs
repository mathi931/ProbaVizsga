using ProbaVizsga.Methods;
using ProbaVizsga.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaVizsga
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            cmbSwitch.DataSource = Enum.GetValues(typeof(ESwitch));
            cmbGas.DataSource = Enum.GetValues(typeof(EGas));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch ((ESwitch)cmbSwitch.SelectedIndex)
            {
                case ESwitch.Choose:
                    break;
                    //create a new Bus
                case ESwitch.Bus:
                    Bus bus = new Bus(cbExtra.Checked, new IDGenerator().GenerateID(ESwitch.Bus),(int)numRegistered.Value, (EGas)cmbGas.SelectedItem);
                    MessageBox.Show(bus.ToString());
                    break;
                    //create a new Auto
                case ESwitch.Auto:
                    Car car = new Car(cbExtra.Checked, new IDGenerator().GenerateID(ESwitch.Auto), (int)numRegistered.Value, (EGas)cmbGas.SelectedItem);
                    MessageBox.Show(car.ToString());
                    break;
                default:
                    break;
            }
        }

        private void cmbSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ESwitch)cmbSwitch.SelectedIndex)
            {
                case ESwitch.Choose:
                    btnAdd.Enabled = false;
                    cbExtra.Visible = false;
                    break;
                case ESwitch.Bus:
                    btnAdd.Enabled = true;
                    cbExtra.Visible = true;
                    cbExtra.Text = "Double Long";
                    break;
                case ESwitch.Auto:
                    btnAdd.Enabled = true;
                    cbExtra.Visible = true;
                    cbExtra.Text = "Sport Line";
                    break;
            }

        }
    }
}
