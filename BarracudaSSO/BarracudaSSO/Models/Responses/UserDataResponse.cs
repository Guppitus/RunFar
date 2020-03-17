using System;

namespace BarracudaSSO.Models.Responses
{
    public class UserDataResponse
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Email { get; set; }
    }
}
