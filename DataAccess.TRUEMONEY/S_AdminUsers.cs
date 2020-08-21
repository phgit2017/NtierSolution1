﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Database.TRUEMONEY
{
    public class S_AdminUsers
    {
        [Key]
        public long AdminUserId { get; set; }

        public string LoginId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int? RoleId { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public bool? IsBlocked { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? AccessRightId { get; set; }
        public string OldPassword { get; set; }
    }
}
