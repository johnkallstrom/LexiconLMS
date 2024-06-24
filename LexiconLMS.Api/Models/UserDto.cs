﻿namespace LexiconLMS.Api.Models
{
    public record UserDto
    {
        public int Id { get; init; }
        public required string Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
    }
}
