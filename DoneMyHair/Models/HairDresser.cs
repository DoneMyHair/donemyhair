﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoneMyHair.Models
{
    public class HairDresser
    {       
            public string ID { get; set; }
            public string HairdresserName { get; set; }
            public string HairdresserSurname { get; set; }
            public int HairdresserPhoneNumber { get; set; }
            public string HairdresserEmail { get; set; }
            public string HairdresserDescription { get; set; }
    }
}