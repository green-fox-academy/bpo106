﻿using System;

namespace BusListManager.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public int? FormerNumber { get; set; }
        public string LicensePlate { get; set; }
        public string FormerLicensePlate { get; set; }
        public string Type { get; set; }
        public string Depot { get; set; }
        public string DateOfGet { get; set; }
        public string DateOfWithdrawal { get; set; }
        public int Kilometer { get; set; }
        public bool IsInOperation { get; set; }
        public string Comments { get; set; }
    }
}