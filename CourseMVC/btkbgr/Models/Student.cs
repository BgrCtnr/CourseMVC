using Microsoft.AspNetCore.Routing.Matching;

namespace btkbgr.Models
{
    
    public class Student
    {
        
        public String? Email { get; set; } = String.Empty;   
        public String? İsim { get; set; } = String.Empty;   
        public String? Soyisim { get; set; } = String.Empty;   
        public int? Yaş { get; set; }    
        public String? Kursİsmi { get; set; } = String.Empty;
        public DateTime Zaman { get; set; }


       public Student()
       {
        Zaman = DateTime.Now;
       }

    }





}