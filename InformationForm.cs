using KursovaHotel.Business;
using KursovaHotel.Data.Models;
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
            ShowAllClientsAndReservations();
        }
        public void ShowAllClientsAndReservations()
        {
            var allClients = HotelBusiness.GetAllClientsOrderedByReservations();
            foreach (var client in allClients)
            {
                Label reservationStatus = new Label();
                var menu = client.Reservation!.Menus!.FirstOrDefault();
                var menuVariety = new MenuVariety();
                if (menu != null)
                {
                    menuVariety = HotelBusiness
                       .GetMenuVarietyById(menu!.MenuVarietyId);
                }
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
                    $"Телефон: {client.PhoneNumber} Стая: {client.Room?.RoomNumber} " +
                    $"Резервация №{client.ReservationId}");

                listBoxReservations.Items.Add(
                    $"Резервация №{client.Reservation?.Id}. " +
                    $"Меню: {menuVariety.Name}" +
                    $" Престой: {client.Reservation?.Duration} нощувки Цена: {client.Reservation?.Price}лв " +
                    $"{reservationStatus.Text}");
            }
        }

        private void btnDisableRes_Click(object sender, EventArgs e)
        {
            var allRes = HotelBusiness.GetAllReservations();
            HotelBusiness.UpdateReservationsStatus(allRes.FirstOrDefault(r => r.Id == numResIndex.Value)!);
            HotelBusiness.UpdateRoomsStatus();
            listBoxClients.Items.Clear();
            listBoxReservations.Items.Clear();
            ShowAllClientsAndReservations();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HotelBusiness.UpdateRoomsStatus();
            listBoxClients.Items.Clear();
            listBoxReservations.Items.Clear();
            ShowAllClientsAndReservations();
        }
    }
}
