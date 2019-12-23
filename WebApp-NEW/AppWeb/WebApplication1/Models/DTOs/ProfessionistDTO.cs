using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DTOs
{
    public class ProfessionistDTO
    {
        public int ProfId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Profession { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postalcode { get; set; }
        public int DestinationId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string MinAvailability { get; set; }
        public string MaxAvailability { get; set; }

        public ProfessionistDTO(Professionist pro)
        {
            ProfId = pro.ProfId;
            Lastname = pro.Lastname;
            Firstname = pro.Firstname;
            Profession = pro.Profession;
            Birthdate = pro.Birthdate;
            Address = pro.Address;
            City = pro.City;
            Region = pro.Region;
            Postalcode = pro.Postalcode;
            DestinationId = pro.DestinationId;
            Phone = pro.Phone;
            Mail = pro.Mail;
            MinAvailability = pro.MinAvailability;
            MaxAvailability = pro.MaxAvailability;
        }

        public ProfessionistDTO()
        {
        }
    }
}
