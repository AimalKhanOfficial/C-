using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    [Serializable]
    public class ViewModelLogin
    {
        [Required(ErrorMessage = "Username required")]
        [DisplayName("Username")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public String Password { get; set; }

        public string Gender { get; set; }
    }
}