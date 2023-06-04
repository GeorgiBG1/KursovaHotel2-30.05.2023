﻿using KursovaHotel.Business;
using KursovaHotel.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaHotel2
{
    public partial class ReservationForm : Form
    {
        private HotelBusiness HotelBusiness = new HotelBusiness();
        private DateTime BookedOnDate;
        private DateTime ExpiredOnDate;
        private bool IsEnabledbtnExpiredOn = false;
        private bool IsAllowedAddClient = true;
        private int clientIndex = 0;
        private Client Client = new Client();
        private Room ClientRoom = new Room();
        private int roomId;
        private Reservation Reservation = new Reservation();
        public List<Client> Clients = new List<Client>();

        public ReservationForm()
        {
            InitializeComponent();
            ShowAllRooms();
            HotelBusiness.UpdateReservationStatus();
        }
        private void radioBtnGroupRes_CheckedChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnBack.Visible = true;
            btnNext.Enabled = true;
            btnNext.Visible = true;
        }

        private void radioBtnOneRes_CheckedChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            btnBack.Visible = false;
            btnNext.Enabled = false;
            btnNext.Visible = false;
        }

        private void btnBookedOn_Click(object sender, EventArgs e)
        {
            IsEnabledbtnExpiredOn = false;
            monthCalendar.Enabled = true;
            monthCalendar.Visible = true;
        }

        private void btnExpiredOn_Click(object sender, EventArgs e)
        {
            IsEnabledbtnExpiredOn = true;
            monthCalendar.Enabled = true;
            monthCalendar.Visible = true;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!IsEnabledbtnExpiredOn)
            {
                BookedOnDate = monthCalendar.SelectionRange.Start.Date;
                if (BookedOnDate < ExpiredOnDate)
                {
                    lblDateStart.Text = BookedOnDate.ToShortDateString();
                    lblDateStart.Visible = true;
                    Reservation.BookedOn = BookedOnDate;
                }
            }
            else
            {
                ExpiredOnDate = monthCalendar.SelectionRange.Start.Date;
                if (ExpiredOnDate.Day > Reservation.BookedOn.Day
                    || ExpiredOnDate.Month > Reservation.BookedOn.Month)
                {
                    lblDateEnd.Text = ExpiredOnDate.ToShortDateString();
                    lblDateEnd.Visible = true;
                    Reservation.ExpiredOn = ExpiredOnDate;
                }
                btnBookedOn.Enabled = true;
            }
            TimeSpan duration = Reservation.ExpiredOn.Date - Reservation.BookedOn.Date;
            int durationInDays = duration.Days;
            if (durationInDays > 0 && Reservation.BookedOn.Year > 1)
            { lblDuration.Text = $"Продължителност на престоя: {durationInDays} нощувки"; }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            RemoveCalendar();
        }
        private void RemoveCalendar()
        {
            monthCalendar.Visible = false;
            monthCalendar.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (clientIndex > 0)
            {
                clientIndex--;
                SelectClient();
                IsAllowedAddClient = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clientIndex++;
            var nextClient = Clients.ElementAtOrDefault(clientIndex);
            if (nextClient != null)
            {
                UpdateCurrentClient(clientIndex - 1);
                SelectClient();
            }
            else if (!IsAllowedAddClient)
            {
                UpdateCurrentClient(clientIndex - 1);
                PartialResetRegistrationForm();
                IsAllowedAddClient = true;
            }
            else
            {
                AddNewClient(roomId);
                PartialResetRegistrationForm();
            }
            radioBtnOneRes.Enabled = false;
        }
        private void UpdateCurrentClient(int index)
        {
            if (Clients.Any())
            {
                if (txtBoxFirstName.Text != Clients[index].FirstName
                    || txtBoxMiddleName.Text != Clients[index].MiddleName
                    || txtBoxLastName.Text != Clients[index].SurName
                    || txtBoxEGN.Text != Clients[index].EGN
                    || txtBoxPhoneNumber.Text != Clients[index].PhoneNumber
                    || txtBoxEmail.Text != Clients[index].Email
                    || numUpDownAge.Value != Clients[index].Age)
                {
                    Clients[index].FirstName = txtBoxFirstName.Text;
                    Clients[index].MiddleName = txtBoxMiddleName.Text;
                    Clients[index].SurName = txtBoxLastName.Text;
                    Clients[index].EGN = txtBoxEGN.Text;
                    Clients[index].PhoneNumber = txtBoxPhoneNumber.Text;
                    Clients[index].Email = txtBoxEmail.Text;
                    Clients[index].Age = (int)numUpDownAge.Value;
                }
            }
        }
        private void SelectClient()
        {
            if (Clients.Any())
            {
                txtBoxFirstName.Text = Clients[clientIndex].FirstName;
                txtBoxMiddleName.Text = Clients[clientIndex].MiddleName;
                txtBoxLastName.Text = Clients[clientIndex].SurName;
                txtBoxEGN.Text = Clients[clientIndex].EGN;
                txtBoxPhoneNumber.Text = Clients[clientIndex].PhoneNumber;
                txtBoxEmail.Text = Clients[clientIndex].Email;
                numUpDownAge.Value = Clients[clientIndex].Age;
            }

        }
        private void AddNewClient(int roomId)
        {
            Client = new Client();
            Client.FirstName = txtBoxFirstName.Text;
            Client.MiddleName = txtBoxMiddleName.Text;
            Client.SurName = txtBoxLastName.Text;
            Client.EGN = txtBoxEGN.Text;
            Client.PhoneNumber = txtBoxPhoneNumber.Text;
            Client.Email = txtBoxEmail.Text;
            Client.Age = (int)numUpDownAge.Value;
            Client.RoomId = roomId;
            ClientRoom = HotelBusiness.GetAllRooms().FirstOrDefault(r => r.Id == roomId)!;
            ClientRoom.IsBooked = true;
            if (!HotelBusiness.GetAllClients().Any(c => c.RoomId == roomId))
            {
                Clients.Add(Client);
                Reservation.IsActive = true;
            }
        }
        private void PartialResetRegistrationForm()
        {
            radioBtnOneRes.Enabled = true;
            txtBoxFirstName.Text = "";
            txtBoxMiddleName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEGN.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxEmail.Text = "";
            numUpDownAge.Value = 0;
        }
        private void ResetRegistrationForm()
        {
            PartialResetRegistrationForm();
            lblDateStart.Text = "";
            lblDateEnd.Text = "";
            lblDuration.Text = "Продължителност на престоя:";
            btnBookedOn.Enabled = false;
            monthCalendar.Enabled = false;
            monthCalendar.Visible = false;
            btnNext.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Visible = false;
            btnBack.Visible = false;
            radioBtnGroupRes.Checked = false;
            radioBtnOneRes.Checked = true;
        }
        private void btnSaveRes_Click(object sender, EventArgs e)
        {
            if (radioBtnOneRes.Checked)
            {
                AddNewClient(roomId);
                ResetRegistrationForm();
                HotelBusiness.AddClientsWithTheirReservation(Clients, Reservation);
                BookedOnDate = new DateTime();
                ExpiredOnDate = new DateTime();
                Reservation = new Reservation();
                Clients = new List<Client>();
                roomId = 0;
                ShowAllRooms();
            }
            else if (radioBtnGroupRes.Checked)
            {
                AddNewClient(roomId);
                ResetRegistrationForm();
                HotelBusiness.AddClientsWithTheirReservation(Clients, Reservation);
                BookedOnDate = new DateTime();
                ExpiredOnDate = new DateTime();
                Reservation = new Reservation();
                Clients = new List<Client>();
                roomId = 0;
                clientIndex = 0;
                ShowAllRooms();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            HotelBusiness.DeleteAll();
            HotelBusiness = new HotelBusiness();
            ShowAllRooms();
        }
        private void ShowAllRooms(int roomNumber = 0)
        {
            var allRooms = HotelBusiness.GetAllRooms();
            Dictionary<int, Button> rooms = new Dictionary<int, Button>();
            rooms.Add(10, btnRoom10);
            rooms.Add(11, btnRoom11);
            rooms.Add(12, btnRoom12);
            rooms.Add(13, btnRoom13);
            rooms.Add(14, btnRoom14);
            rooms.Add(15, btnRoom15);
            rooms.Add(20, btnRoom20);
            rooms.Add(21, btnRoom21);
            rooms.Add(22, btnRoom22);
            rooms.Add(23, btnRoom23);
            rooms.Add(24, btnRoom24);
            rooms.Add(25, btnRoom25);
            rooms.Add(30, btnRoom30);
            rooms.Add(31, btnRoom31);
            rooms.Add(32, btnRoom32);
            rooms.Add(33, btnRoom33);
            rooms.Add(34, btnRoom34);
            rooms.Add(35, btnRoom35);

            foreach (var room in allRooms)
            {
                if (!room.IsBooked && room.Id != ClientRoom.Id)
                {
                    rooms[room.RoomNumber].BackColor = Color.LightGreen;
                }
                else
                {
                    rooms[room.RoomNumber].BackColor = Color.IndianRed;
                }
            }
            if (roomNumber != 0)
            {
                var selectedRoom = rooms.FirstOrDefault(r => r.Key == roomNumber);
                selectedRoom.Value.BackColor = Color.IndianRed;
            }
        }
        private void SelectRoom(Button room)
        {
            room.BackColor = Color.IndianRed;
        }
        private void btnRoom10_Click(object sender, EventArgs e)
        {
            roomId = 1;
            SelectRoom(btnRoom10);
            ShowAllRooms(10);
        }

        private void btnRoom11_Click(object sender, EventArgs e)
        {
            roomId = 2;
            SelectRoom(btnRoom11);
            ShowAllRooms(11);
        }

        private void btnRoom12_Click(object sender, EventArgs e)
        {
            roomId = 3;
            SelectRoom(btnRoom12);
            ShowAllRooms(12);
        }

        private void btnRoom13_Click(object sender, EventArgs e)
        {
            roomId = 4;
            SelectRoom(btnRoom13);
            ShowAllRooms(13);
        }

        private void btnRoom14_Click(object sender, EventArgs e)
        {
            roomId = 5;
            SelectRoom(btnRoom14);
            ShowAllRooms(14);
        }

        private void btnRoom15_Click(object sender, EventArgs e)
        {
            roomId = 6;
            SelectRoom(btnRoom15);
            ShowAllRooms(15);
        }

        private void btnRoom20_Click(object sender, EventArgs e)
        {
            roomId = 7;
            SelectRoom(btnRoom20);
            ShowAllRooms(20);
        }

        private void btnRoom21_Click(object sender, EventArgs e)
        {
            roomId = 8;
            SelectRoom(btnRoom22);
            ShowAllRooms(21);
        }

        private void btnRoom22_Click(object sender, EventArgs e)
        {
            roomId = 9;
            SelectRoom(btnRoom22);
            ShowAllRooms(22);
        }

        private void btnRoom23_Click(object sender, EventArgs e)
        {
            roomId = 10;
            SelectRoom(btnRoom23);
            ShowAllRooms(23);
        }

        private void btnRoom24_Click(object sender, EventArgs e)
        {
            roomId = 11;
            SelectRoom(btnRoom24);
            ShowAllRooms(24);
        }

        private void btnRoom25_Click(object sender, EventArgs e)
        {
            roomId = 12;
            SelectRoom(btnRoom25);
            ShowAllRooms(25);
        }

        private void btnRoom30_Click(object sender, EventArgs e)
        {
            roomId = 13;
            SelectRoom(btnRoom30);
            ShowAllRooms(30);
        }

        private void btnRoom31_Click(object sender, EventArgs e)
        {
            roomId = 14;
            SelectRoom(btnRoom31);
            ShowAllRooms(31);
        }

        private void btnRoom32_Click(object sender, EventArgs e)
        {
            roomId = 15;
            SelectRoom(btnRoom32);
            ShowAllRooms(32);
        }

        private void btnRoom33_Click(object sender, EventArgs e)
        {
            roomId = 16;
            SelectRoom(btnRoom33);
            ShowAllRooms(33);
        }

        private void btnRoom34_Click(object sender, EventArgs e)
        {
            roomId = 17;
            SelectRoom(btnRoom34);
            ShowAllRooms(34);
        }

        private void btnRoom35_Click(object sender, EventArgs e)
        {
            roomId = 18;
            SelectRoom(btnRoom35);
            ShowAllRooms(35);
        }

        private void tabPageWithMenus_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
