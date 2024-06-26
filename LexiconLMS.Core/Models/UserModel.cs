﻿namespace LexiconLMS.Core.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }

        public IEnumerable<string> Roles { get; set; } = [];
    }
}