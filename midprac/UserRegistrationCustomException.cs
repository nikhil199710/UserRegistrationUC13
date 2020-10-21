using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    public class UserRegistrationCustomException : Exception
    {
        /// <summary>
        /// Enum method of exception type to declare constants for exception.
        /// </summary>
        public enum ExceptionType
        {
            invalid_name, invalid_email, invalid_phone, invalid_password, EMPTY_MESSAGE
        }
        private readonly ExceptionType type;
        /// <summary>
        /// Constructor class for custom exception and passing message to base class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}