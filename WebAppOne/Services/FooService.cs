using System.Collections.Generic;

namespace WebAppOne.Services
{
    public class FooService
    {
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "Bob",
                "Cosmo",
                "Tim"
            };
        }
    }
}