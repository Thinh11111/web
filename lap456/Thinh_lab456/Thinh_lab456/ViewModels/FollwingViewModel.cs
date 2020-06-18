using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thinh_lab456.Models;

namespace Thinh_lab456.ViewModels
{
    public class FollwingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}