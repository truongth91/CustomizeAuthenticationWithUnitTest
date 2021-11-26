using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CustomizeAuthentication.Helpers;
using Microsoft.AspNetCore.Identity;

namespace CustomizeAuthentication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CAUser class
    public class CAUser : IdentityUser
    {
        [Column(TypeName = "nvarchar(20)")]
        public EnumHelpers.TypeOfUser TypeOfUser { get; set; }
    }
}
