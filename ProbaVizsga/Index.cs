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

        List<Vehicle> vehicles = new List<Vehicle>();

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
                    vehicles.Add(bus);
                    refreshList();
                    break;

                    //create a new Auto
                case ESwitch.Auto:
                    Car car = new Car(cbExtra.Checked, new IDGenerator().GenerateID(ESwitch.Auto), (int)numRegistered.Value, (EGas)cmbGas.SelectedItem);
                    vehicles.Add(car);
                    refreshList();
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

        private void Index_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to import files ?", "Import", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        vehicles = new DataAccess().ImportVehicles(openFileDialog.FileName);
                        refreshList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error during Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("are you sure to exit ?", "exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        new DataAccess().ExportVehicles(saveFileDialog.FileName, vehicles);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error during Export!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void refreshList()
        {
            lsbVehicles.DataSource = null;
            lsbVehicles.DataSource = vehicles;
        }
    }
}
