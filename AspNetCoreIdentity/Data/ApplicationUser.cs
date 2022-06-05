using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PayrollNumber { get; set; }
        public string? Region { get; set; }
        public string? Branch { get; set; }
        public DateTime DateAndTimeReported { get; set; }
    }
}
