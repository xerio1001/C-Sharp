using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of the current person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of the current person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the e-mail address of the current person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of the current person.
        /// </summary>
        public string PhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }   
        }

    }
}
