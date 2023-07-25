﻿using System.ComponentModel.DataAnnotations;

namespace School.API.Data.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTimeOffset CreatedDate { get; set; }

    [Required]
    public string? CreatedBy { get; set; }

    [Required]
    public DateTimeOffset ModifiedDate { get; set; }

    [Required]
    public string? ModifiedBy { get; set; }
}