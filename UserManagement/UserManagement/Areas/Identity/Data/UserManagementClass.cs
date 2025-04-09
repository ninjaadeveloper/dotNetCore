using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserManagement.Areas.Identity.Data;

// Add profile data for application users by adding properties to the UserManagementClass class
public class UserManagementClass : IdentityUser
{
    public string? fname { get; set; }
    public string? lname { get; set; }
}

