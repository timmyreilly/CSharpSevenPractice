using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversationStarter.Domain
{
    public class ConversationStarterService : IConversationService
    {
        public int Id { get; set; }

        private IEnumerable<ConversationStarter> _convos = 
        new[]
        {
            new ConversationStarter(new Guid(), new ConversationStarterText("What is your favorite color?")),
            new ConversationStarter(new Guid(), new ConversationStarterText("What is your favorite type of ice cream?")), 
            new ConversationStarter(new Guid(), new ConversationStarterText("What is your oldest memory?")) 
        }; 
        public ConversationStarter GetConversation()
        { 
            ConversationStarter starter = _convos.First(); 
            return starter; 
        }

    }
}
