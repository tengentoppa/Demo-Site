﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Account { get; set; }

        [Required]
        [StringLength(100)]
        public string Autho { get; set; }

        [ForeignKey("PermissionId")]
        public ICollection<Permission> Permissions { get; set; }
        public int PermissionId { get; set; }

        [ForeignKey("UserInfoId")]
        public UserInfo UserInfo { get; set; }
        public int UserInfoId { get; set; }

    }
}
