using System;

namespace ConversationStarter.Domain
{
    public class ConversationStarter
    {
        public Guid Id { get; set; }
        private string Text; 

        public ConversationStarter(Guid id)
        {
            if(id == null) 
            {
                throw new ArgumentNullException(nameof(id), "ConversationStarter id cannot be empty"); 
            }

            Id = id;    
        }

        string GetConversationStarter() 
        {
            return Text; 
        }
    }
}
