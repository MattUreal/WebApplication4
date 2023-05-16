using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace WebApplication4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? Sex { get; set; }
        public string? Batch { get; set; }
        public int ApprovalFlag { get; set; }
        

    }
}
