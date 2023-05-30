using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaHotel2
{
    public partial class MainForm : Form
    {
        private RoomForm _roomForm = new RoomForm();
        public MainForm()
        {
            InitializeComponent();
        }
        private void loadForm(object Form)
        {
            _roomForm.TopLevel = false;
            _roomForm.Dock = DockStyle.Fill;
            this.panelRooms.Controls.Add(_roomForm);
            this.panelRooms.Tag = _roomForm;
            _roomForm.Show();
        }
        private void hideForm(object Form)
        {
            _roomForm.Hide();
        }
        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            loadForm(new RoomForm());
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            hideForm(new RoomForm());
        }
    }
}
