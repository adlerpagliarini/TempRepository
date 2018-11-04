﻿using System.Collections.Generic;

namespace Domain.Entities
{
    public class User : IIdentityEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ToDoList> ToDoList { get; private set; }

        public User()
        {
            this.ToDoList = new HashSet<ToDoList>();
        }
    }
}