﻿using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }
    }
}
