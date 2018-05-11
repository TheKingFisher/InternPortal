﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class AspNetUserDto
    {
        public string Id { get; set; } // Id (Primary key) (length: 128)
        public string Email { get; set; } // Email (length: 256)
        public bool EmailConfirmed { get; set; } // EmailConfirmed
        public string PasswordHash { get; set; } // PasswordHash
        public string SecurityStamp { get; set; } // SecurityStamp
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool PhoneNumberConfirmed { get; set; } // PhoneNumberConfirmed
        public bool TwoFactorEnabled { get; set; } // TwoFactorEnabled
        public System.DateTime? LockoutEndDateUtc { get; set; } // LockoutEndDateUtc
        public bool LockoutEnabled { get; set; } // LockoutEnabled
        public int AccessFailedCount { get; set; } // AccessFailedCount
        public string UserName { get; set; } // UserName (length: 256)

        public List<MessageDto> Messages_UserIdFrom { get; set; } // Message.FK_dbo.Messages_dbo.User_UserIdFrom
  
        public List<MessageDto> Messages_UserIdTo { get; set; } // Message.FK_dbo.Messages_dbo.User_UserIdTo

        public List<UserDto> Users { get; set; } // User.FK_dbo.User_dbo.AspNetUsers_Id
    }
}