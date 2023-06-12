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
            ShowAllClientsWithActiveReservation();
        }
        public void ShowAllClientsWithActiveReservation()
        {
            var allClients = HotelBusiness.GetAllClientsOrderedByActiveReservations();
            foreach (var client in allClients)
            {
                Label reservationStatus = new Label();
                if (client.Reservation!.IsActive)
                {
                    reservationStatus.Text = "Статус: \u2713";
                }
                else
                {
                    reservationStatus.Text = "Статус: X";
                }
                listBoxClients.Items.Add($"{client.FirstName} " +
                    $"{client.MiddleName} {client.SurName} " +
                    $"ЕГН: {client.EGN} Email: {client.Email} " +
                    $"Телефон: {client.PhoneNumber} Стая: {client.Room?.RoomNumber}");

                var selectedClient = listBoxClients.SelectedItem;
                listBoxReservations.Items.Add(
                    $"Номер на резервацията: {client.Reservation?.Id}. " +
                    $"Престой: {client.Reservation?.Duration} нощувки Цена: {client.Reservation?.Price}лв " +
                    $"{reservationStatus.Text}");
            }
        }
    }
}
