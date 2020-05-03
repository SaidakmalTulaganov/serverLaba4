using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using serverLaba4;

namespace clientLaba4
{
    public partial class frmAdd : Form
    {
        Tovar tovar = null;
        public frmAdd()
        {
            InitializeComponent();
        }
        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void spnPlace_ValueChanged(object sender, EventArgs e)
        {

        }
        private void scrClock_Scroll(object sender, ScrollEventArgs e)
        {
            lblClockInfo.Text = scrClock.Value.ToString();
        }
        private void scrPrice_Scroll(object sender, ScrollEventArgs e)
        {
            lblPriceInfo.Text = scrPrice.Value.ToString();
        }
        private void cmbBonus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            //код проверки на правильность ввода
            if (rdbYesParam.Checked)
            {
                tovar = new Tovar(cmbFloor.SelectedItem.ToString(), Convert.ToInt32(spnPlace.Value), scrClock.Value, scrPrice.Value, cmbBonus.SelectedItem.ToString());
            }
            else
            {
                tovar = new Tovar();
                tovar.setFloor(cmbFloor.SelectedItem.ToString());
                tovar.setPlace(Convert.ToInt32(spnPlace.Value));
                tovar.setClock(scrClock.Value);
                tovar.setPrice(scrPrice.Value);
                tovar.setBonus(cmbBonus.SelectedItem.ToString());
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
            cmbFloor.SelectedIndex = 0;
            cmbBonus.SelectedIndex = 0;
        }
        public Tovar getTovar
        {
            get
            {
                return tovar;
            }
        }
    }
}
