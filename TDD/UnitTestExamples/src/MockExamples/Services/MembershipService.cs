namespace MockExamples.SomeServices
{
    using System;
    using System.Linq;
    using Interfaces;
    using JetBrains.Annotations;

    public class MembershipService
    {
        private readonly IDatabaseContext databaseContext;

        public MembershipService(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [CanBeNull]
        public User FindContextUser(int userId)
        {
            User foundUser = databaseContext.Query<User>().SingleOrDefault(x => x.Id == userId);

            if (foundUser == null)
                throw new ArgumentException("Невалидный userId");

            return foundUser;
        }
    }
}