// Services/UserSessionService.cs
using EventEase.Models;

namespace EventEase.Services
{
    public class UserSessionService
    {
        private User? currentUser;

        public void SetUser(User user)
        {
            currentUser = user;
        }

        public User? GetUser()
        {
            return currentUser;
        }

        public bool IsUserLoggedIn => currentUser != null;
    }
}
