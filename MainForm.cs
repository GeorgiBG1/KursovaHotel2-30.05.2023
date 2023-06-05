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
        private ReservationForm _reservationForm = new ReservationForm();
        private RoomForm _roomForm = new RoomForm();
        public MainForm()
        {
            InitializeComponent();
            loadReservationForm();
            loadRoomForm();
        }
        private void loadReservationForm()
        {
            _reservationForm.TopLevel = false;
            _reservationForm.Dock = DockStyle.Fill;
            this.splitContainer.Panel1.Controls.Add(_reservationForm);
            this.splitContainer.Panel1.Tag = _reservationForm;
            _reservationForm.Show();
        }
        private void loadRoomForm()
        {
            _roomForm.TopLevel = false;
            _roomForm.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(_roomForm);
            this.splitContainer.Panel2.Tag = _roomForm;
            _roomForm.Show();
        }

        private void btnRoomForm_Click(object sender, EventArgs e)
        {
            //this.splitContainer.Panel2.Size
        }
    }
}
