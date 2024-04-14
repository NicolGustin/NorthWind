using NorthWind.Entities.NorthWind.Entities.Interfaces;
using NorthWind.Entities.NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
    internal class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
                action.CreatedDateTime, action.User, action.Description);
        }

        public void Write(UserAction action)
        {
            throw new NotImplementedException();
        }
    }
}
