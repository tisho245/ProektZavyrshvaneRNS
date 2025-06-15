using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Win32;
using GastroSoft.Model;

namespace GastroSoft.Models
{
    
    public class User
    {
		private string username;
        [Key]
        public string Username
		{
			get 
			{
				return username; 
			}
			set 
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("?? ??? ?????? ????????????? ???.");
				
				else if (value.Length<3)
                    throw new ArgumentException("??????????????? ??? ?????? ?? ? ???? 3 ???????.");

				username = value;
			}
		}
        
		private string email;

        [Index(IsUnique = true)]
		[MaxLength(50)]
        public string Email
		{
			get 
			{
				return email; 
			}
			set 
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("?? ??? ?????? ?????.");

				else if (!value.Contains("@")|| !value.Contains("."))
                    throw new ArgumentException("?????????? ????? ? ?????????.");

                email = value; 
			}
		}

		private string password;

        public string Password
		{
			get 
			{
				return password; 
			}
			set 
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("?? ??? ?????? ??????.");

				else if (value.Length < 6)
					throw new ArgumentException("???????? ?????? ?? ? ???? 6 ???????.");

				else if (!IsAlphaNumeric(value))
					throw new ArgumentException("???????? ?????? ?? ??????? ???? ???? ????? ? ?????.");
                   
                password = value; 
			}
		}

		private string firstName;

		public string FirstName
		{
			get 
			{
				return firstName; 
			}
			set 
			{
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("?? ??? ?????? ????? ???.");

                else if (value.Length < 3)
                    throw new ArgumentException("??????? ??? ?????? ?? ? ???? 3 ???????.");

                firstName = value; 
			}
		}

		private string lastName;

		public string LastName
		{
			get 
			{
				return lastName; 
			}
			set 
			{
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("?? ??? ?????? ??????? ???.");

                else if (value.Length < 3)
                    throw new ArgumentException("????????? ??? ?????? ?? ? ???? 3 ???????.");

                lastName = value; 
			}
		}

		private RoleTypes role;

		public RoleTypes Role
		{
			get { return role; }
			set { role = value; }
		}

        public enum RoleTypes
        {
            Admin = 0,
            Seller = 1,
            Buyer = 2
        }
        bool IsAlphaNumeric(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return input.Any(char.IsLetter) && input.Any(char.IsDigit);
        }
    }
}
