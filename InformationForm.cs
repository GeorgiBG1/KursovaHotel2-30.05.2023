using KursovaHotel.Business;
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
    public partial class InformationForm : Form
    {
        private HotelBusiness HotelBusiness = new HotelBusiness();
        public InformationForm()
        {
            InitializeComponent();
            
        }
        public void ShowAllClients()
        {
            var allClients = HotelBusiness.GetAllClientsOrderedByActiveReservations();
            foreach (var client in allClients)
            {
                listBoxReservations.Items.Add($"{client.FirstName}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllClients();
        }
    }
}
