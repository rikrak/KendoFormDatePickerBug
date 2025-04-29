using System;

namespace KendoFormDatePicker.Models
{
    public class IndexViewModel
    {
        public DateTime DateOfBirthLocal { get; set; } = new DateTime(1950, 04, 15, 0, 0, 0, DateTimeKind.Local);
        public DateTime DateOfBirthUtc { get; set; } = new DateTime(1950, 04, 15, 0, 0, 0, DateTimeKind.Utc);
    }
}