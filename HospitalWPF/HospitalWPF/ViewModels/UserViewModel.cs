﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWPF.ViewModels
{
    public class UserViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long PassportSeries { get; set; }
        public long PassportNumber { get; set; }
        public string Address { get; set; }
        public string WorkPlace { get; set; }
        public long? InsurancePolicyNumber { get; set; }
        public DateTime InsurancePolicyEndDate { get; set; }
    }
}
