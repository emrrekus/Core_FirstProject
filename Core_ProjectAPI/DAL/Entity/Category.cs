﻿using System.ComponentModel.DataAnnotations;

namespace Core_ProjectAPI.DAL.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


    }
}
