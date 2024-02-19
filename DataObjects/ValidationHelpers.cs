﻿/// <summary>
/// Michael Springer
/// Created: 2024/02/06
/// 
/// Utility class consisting of validation helper methods
/// </summary>
///
/// <remarks>
/// Updater Name
/// Updated: yyyy/mm/dd
/// </remarks>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataObjects
{
    public static class ValidationHelpers
    {
        
        public static bool IsValidEmail(this string email)
        {
            int emailLength = 255;
            bool result = false;

            string pattern = @"\A[\w!#$%&'*+/=?`{|}~^-]+(?:\.[\w!#$%&'*+/=?`{|}~^-]+)*@(?:[A-Z0-9-]+\.)+[A-Z]{2,6}\Z";
            Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

            result = (email.Length < emailLength && (rg.Match(email).Success));
            return result;
        }

        public static bool IsValidPassword(this string password)
        {
            bool result = false;
            // Uibakery.io/regex-lbrary/password-regex-chsharp -- requires 8 chars, 1 upper, 1 lower, 1 number, 1 special
            string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex rg = new Regex(pattern);
            result = (password.Length < 255 && (rg.Match(password).Success));
            // TODO Temp Validation for easy access:
            result = password.Length > 5;
            return result;
        }
        public static bool IsValidGivenName(this string name)
        {
            int nameLength = 50;
            bool result = false;
            // stackoverflow.com/a/2385967 one or more letters or valid characters
            string pattern = @"^[A-z ,.'-]+$";
            Regex rg = new Regex(pattern);
            result = (name.Length <= nameLength && (rg.Match(name).Success));
            return result;
        }

        public static bool IsValidFamilyName(this string name)
        {
            int nameLength = 50;
            bool result = false;
            // stackoverflow.com/a/2385967 one or more letters or valid characters
            string pattern = @"^[A-z ,.'-]+$";
            Regex rg = new Regex(pattern);
            result = (name.Length <= nameLength && (rg.Match(name).Success));
            return result;
        }

        public static bool IsValidMiddleName(this string name)
        {
            int nameLength = 100;
            bool result = false;
            // stackoverflow.com/a/2385967 one or more letters or valid characters
            string pattern = @"^[a-z ,.'-]+$";
            Regex rg = new Regex(pattern);
            result = (name.Length <= nameLength && (rg.Match(name).Success));
            return result;
        }
        public static bool IsValidCompoundName(this string name)
        {
            int nameLength = 100;
            bool result = false;
            // stackoverflow.com/a/2385967 one or more letters or valid characters
            string pattern = @"^[a-z ,.'-]+$";
            Regex rg = new Regex(pattern);
            result = (name.Length <= nameLength && (rg.Match(name).Success));
            return result;
        }

        public static bool isValidPhone(this string phone)
        {
            bool result = false;
            // stackoverflow.com/a/16699507 comprehensive phone combinations and unformatted numbers
            string pattern = @"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
            Regex rg = new Regex(pattern);
            result = (rg.Match(phone).Success);
            return result;
        }
        /// <summary>
        /// Michael Springer
        /// Created: 2024/02/06
        /// 
        /// DOB Validator
        /// Accepts a required age argument and checks for validity
        /// </summary>
        ///
        /// <remarks>
        /// <param name="date">
        /// <param name="requiredAge"
        /// 
        public static bool IsValidDOB(this DateTime date, int requiredAge)
        {
            bool result = false;
            int yeardDifference = ((DateTime.Now - date).Days / 365);
            result = (date != null && yeardDifference >= requiredAge);
            return result;   
        }
        public static bool IsValidDate(this DateTime date)
        {
            return date != null;
        }

        public static bool isNotEmptyOrNull(this string value)
        {
            bool result = false;
            result = (value != null && value.Length > 0);
            return result;
        }

    }
}
