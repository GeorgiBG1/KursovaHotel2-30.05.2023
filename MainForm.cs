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
        }
        private void loadReservationForm()
        {
            _reservationForm.TopLevel = false;
            _reservationForm.Dock = DockStyle.Fill;
            this.splitContainer.Panel1.Controls.Add(_reservationForm);
            this.splitContainer.Panel1.Tag = _reservationForm;
            _reservationForm.Show();
        }
        private void loadForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(form);
            this.splitContainer.Panel2.Tag = form;
            form.Show();
        }
        private void hideForm(Form form)
        {
            form.Hide();
        }
        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            loadForm(_roomForm);
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            hideForm(new RoomForm());
        }
    }
}
