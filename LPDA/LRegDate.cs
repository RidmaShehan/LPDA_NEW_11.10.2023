using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LPDA
{
    //====================== R_S develop.... ======================
    public class LRegDate
    /*
     */
    {

        private string Surname;
        private string FirstName;
        private string SecondName;
        private string IDNumber;
        private DateTime DateOfBirth;
        private string Gender = "Male";
        private string Email;
        private string PhoneNumber;
        private string UserName;
        private string Password;
        private string ZipCode;
        private string TempPassword;
        private String CurrentUser;    // This variable holds 1 as an identifier of the current logged in user.
        // Because it is easy to identify the current log user and access his database data field is very easy. ( FOR THER DEVELOPER ACCESS )

        //====================== This is data setters.... ======================
        public void setCrrentuser(String CurrentUser) 
        { 
            this.CurrentUser = CurrentUser;
        }
        public void setSurname(String Surname) 
        {
            this.Surname = Surname;
        } 
        public void setFirstName(String FirstName)
        {
            this.FirstName = FirstName;
        }
        public void setSecondName(String SecondName) 
        {
            this.SecondName = SecondName;
        }
        public void setIDNumber(String IDNumber)
        {
            this.IDNumber = IDNumber;   
        }
        public void setDateOfBirth(DateTime DateOfBirth) 
        {
            this.DateOfBirth = DateOfBirth;
        }
        public void setGender(String Gender) 
        {
            this.Gender = Gender; 
        }
        public void setEmail(String Email) 
        {
            this.Email = Email;
        }
        public void setPhoneNumber(String PhoneNumber) 
        {
            this.PhoneNumber = PhoneNumber;
        }
        public void setUserName(String UserName) 
        {
            this.UserName = UserName;
        }
        public void setPassword(String Password) 
        {
            this.Password = Password;
        }
        public void setZipCode(String ZipCode) 
        { 
            this.ZipCode = ZipCode;
        }
        public void setTempPassword(string TempPassword) 
        {  
            this.TempPassword = TempPassword;
        }

    //====================== This is data getters.... ======================

        public String getCurrentUser() 
        {
            return this.CurrentUser;
        }
        public String getSurname() 
        {
            return this.Surname;
        }
        public String getFirstName() 
        {
            return this.FirstName;
        }
        public String getSecondName() 
        {
            return this.SecondName;
        }
        public String getIDNumber() 
        {
            return this.IDNumber;
        }
        public DateTime getDateOfBirth() 
        {
            return this.DateOfBirth;
        }
        public String getGender() 
        {
            return this.Gender;
        }

        public String getEmail()
        {
            return this.Email;
        }
        public String getPhoneNumber() 
        {
            return this.PhoneNumber; 
        }
        public String getUserName() 
        { 
            return this.UserName;
        }
        public String getPassword() 
        {
            return this.Password;
        }
        public String getZipCode() 
        { 
            return this.ZipCode;
        }

    //====================== THIS IS METHODS FOR PUBLIC ======================

        public bool FormIsEmpty(String text) 
        {
            /*  

            *  This method is checked if parameterised variable is empty then rethurn "true" and
               if parameterised variable is not empty return "false".

            *  THIS METHOD CAN BE USE CHECK SOME VARIABLE IS EMPTY OR NOT EMPTY.
            
            */

            if (text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IdNumberIsCorrect(string id) 
        {
            /*
             
             * This method is checked if parameterised variable is empty then rethurn "true" and
               if parameterised variable is not empty return "false".

             *This method is cheacked if STRING type ----ID NUMBER------  is CORRECT or INCORRECT.
             
             */

            if (id.Length == 12 && id.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                if (id.Length == 10 && id.Contains('v'))
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (!char.IsDigit(id[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool EmailIsCorrect(String mail) 
        {

            /*  

            *  This method is checked if parameterised variable is empty then rethurn "true" and
               if parameterised variable is not empty return "false".

            *  THIS METHOD CAN BE USE CHECK EMAIL IS CORRECT OR INCORRECT.
            
            */

            if (mail.Contains("@"))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool ZipCodeIsCorrect(String Zip)
        {
            /*  

             *  This method is checked if parameterised variable is empty then rethurn "true" and
                if parameterised variable is not empty return "false".

             *  THIS METHOD CAN BE USE CHECK ZIP CODE IS CORRECT OR INCORRECT.
           
            */

            if (Zip.Length == 5 && Zip.All(char.IsDigit))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public bool PhoneNumberIsCorrect(String phone)
        {
            /*  

            *  This method is checked if parameterised variable is empty then rethurn "true" and
               if parameterised variable is not empty return "false".

            *  THIS METHOD CAN BE USE CHECK PHONE NUMBER IS CORRECT OR INCORRECT .
            
            */
            if (phone.Length == 10 && phone.All(char.IsDigit) && phone[0] == '0') 
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool PasswordIsCorrect(String password)
        {
            /*  

            *  This method is checked if parameterised variable is empty then rethurn "true" and
               if parameterised variable is not empty return "false".

            *  THIS METHOD CAN BE USE CHECK PASSWORD IS CORRECT OR INCORRECT .
            
            */
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            if (Password.Length >= 8 && Regex.IsMatch(Password, pattern))
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
    }
}
