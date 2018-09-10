namespace NetFxWcfService
{
    using System;
    using NetFxCommonLib;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AuthService : IAuthService
    {
        public AuthResult AttemptUserAuth(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
               return new AuthResult {IsAuthed = false, ErrorMessage = "No username provided"};
             
            }

            if (userName.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                return new AuthResult {IsAuthed = true, UserTicket = Guid.NewGuid().ToString(), ErrorMessage = string.Empty};
            }

            return new AuthResult {IsAuthed = false, ErrorMessage = "UserName does not start with 'a'"};
        }
    }
}