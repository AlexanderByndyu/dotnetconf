namespace Domain
{
    using System;
    using JetBrains.Annotations;

    public class Customer
    {
        public Customer([NotNull] string name, [NotNull] string password)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password");

            Name = name;
            Password = password;
        }

        public string Name { get; private set; }
        public string Password { get; private set; }
    }
}