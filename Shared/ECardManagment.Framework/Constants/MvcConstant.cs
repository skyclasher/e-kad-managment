// Copyright (c) 2018
//
// File Name		: MvcConstant.cs
// Created By		: asyaf
// Created Date		: 2019-1-13
namespace ECardManagment.Framework.Constants
{
    public partial class Constant
    {
        public class ViewPath
        {
            public const string RsvpListing = "~/Views/Dashboards/Rsvp/_List.cshtml"; 
            public const string Dashboard = "~/Views/Dashboards/Dashboard2.cshtml"; 
        }

        public class Controller
        {
            public const string Account = "Account";
            public const string Dashboard = "Dashboards";
        }

        public class Action
        { 
            public const string Login = "Login";
            public const string GetPagedRsvp = "GetPagedRsvp";
        }

    }
}
