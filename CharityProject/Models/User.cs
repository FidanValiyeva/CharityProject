﻿using Microsoft.AspNetCore.Identity;

namespace CharityProject.Models
{
    public class User:IdentityUser
    {
        public string FullName { get; set; }
    }
}
