using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using serverLaba4;
using System.Collections.Generic;
using System;

namespace clientLaba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void doVivod(List<serverLaba4.Tovar> lstTovar)
        {
            lvList.Items.Clear();
            int i = 1;
            foreach (serverLaba4.Tovar tovar in lstTovar)
            {
                ListViewItem newItem = new ListViewItem(i.ToString());
                lvList.Items.Add(newItem);
                //newItem.SubItems.Add(i.ToString());
                newItem.SubItems.Add(tovar.getFloor());
                newItem.SubItems.Add(tovar.getPlace().ToString());
                newItem.SubItems.Add(tovar.getClock().ToString());
                newItem.SubItems.Add((tovar.getPrice() * tovar.getClock()).ToString());
                newItem.SubItems.Add(tovar.getBonus());
                i++;
            }
        }
        TovarOperation tovarOperation = null;
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAdd f = new frmAdd();
            f.ShowDialog();
            if (f.getTovar != null)
            {
                try
                {
                    doVivod(tovarOperation.addNewTovar(f.getTovar));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (txt.Text != "") btnDecide_Click(sender, e);
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                TcpClientChannel chan = new TcpClientChannel();
                ChannelServices.RegisterChannel(chan, false);
                tovarOperation = (TovarOperation)Activator.GetObject(
                typeof(TovarOperation), "tcp://localhost:9000/TalkIsGood");
                doVivod(tovarOperation.getListOfTovar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDecide_Click(object sender, System.EventArgs e)
        {
            try
            {
                txt.Text = tovarOperation.getSumOfTovar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDel_Click(object sender, System.EventArgs e)
        {
            if (lvList.SelectedIndices.Count < 1)
            {
                MessageBox.Show(this, "Выберите элемент для удаления!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    tovarOperation.delTovar(lvList.SelectedIndices[0]);
                    doVivod(tovarOperation.getListOfTovar());
                    if (txt.Text != "") btnDecide_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                doVivod(tovarOperation.getListOfTovar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
