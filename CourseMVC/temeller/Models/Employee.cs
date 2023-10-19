using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace temeller.Models
{
    
    public class Employee
    {
        
        public int Id { get; set; }
        public int Age { get; set; } 
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String FullName => $"{FirstName} {LastName.ToUpper()}";


    }


}