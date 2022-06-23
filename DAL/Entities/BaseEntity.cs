﻿using System;

namespace DAL.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}
