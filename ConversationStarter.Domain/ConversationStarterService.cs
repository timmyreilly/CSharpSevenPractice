using System;
using System.Collections.Generic;

namespace ConversationStarter.Domain
{
    public class ConversationStarterService : IConversationService
    {
        public int Id { get; set; }

        private IEnumerable<ConversationStarter> convos = {
            new ConversationStarter(),
            new ConversationStarter(), 
            new ConversationStarter() 
        }; 
        public ConversationStarter GetConversation()
        { 
            return convos[0]; 
        }

    }
}
