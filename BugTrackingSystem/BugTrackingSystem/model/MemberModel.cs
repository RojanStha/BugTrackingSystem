using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.model
{
    class MemberModel
    {
        /// <summary>
        /// declaring required variables with private access modifier
        /// </summary>
        private int memberId;
        private string memberName;
        private string email;
        private string role;
        private string address;
        
        private string password;
        private string dob;


        /// <summary>
        /// all getter and setter for Members
        /// </summary>
        public int MemberId
        {
            get
            {
                return memberId;
            }
            set
            {
                memberId = value;
            }
        }

        /// <summary>
        /// ///////////////////
        /// </summary>
        public string MemberName
        {
            get
            {
                return memberName;
            }
            set
            {
                memberName = value;
            }
        }
        /// <summary>
        /// /////////
        /// </summary>

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        /// <summary>
        /// //////////
        /// </summary>

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        /// <summary>
        /// ///////////
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        /// <summary>
        /// /////////
        /// </summary>
      
       
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        /// <summary>
        /// //////////S
        /// </summary>

        public string Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }



    }
}
