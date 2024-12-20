﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrackMyStudent.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TrackMyStudentUser class
public class TrackMyStudentUser : IdentityUser
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string CellNumber { get; set; }
}

