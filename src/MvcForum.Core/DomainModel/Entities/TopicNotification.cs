﻿using System;
using MVCForum.Utilities;

namespace MVCForum.Domain.DomainModel
{
    using MvcForum.Core.DomainModel.Entities;

    public partial class TopicNotification : Entity
    {
        public TopicNotification()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual MembershipUser User { get; set; }
    }
}
