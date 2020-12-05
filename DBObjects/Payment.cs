﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RentalsApp.DBObjects
{
    public class Payment
    {
        public Invoice invoicePayedFor;
        public string paymentType;
        public DateTime paymentTime;
    }
}