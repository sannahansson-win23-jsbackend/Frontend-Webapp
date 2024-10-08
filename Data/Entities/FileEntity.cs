﻿
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class FileEntity
{
    [Key]
    public string FileName { get; set; } = null!;
    public string? ContentType { get; set; } = null!; 
    public string? ContainerName { get; set; } = null!;
}
