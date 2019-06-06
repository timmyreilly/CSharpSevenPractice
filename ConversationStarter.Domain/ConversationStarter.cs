using System;

namespace ConversationStarter.Domain
{
    public class ConversationStarter
    {
        public Guid Id { get; set; }
        private ConversationStarterText Text;

        public ConversationStarter(Guid id, ConversationStarterText text)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id), "ConversationStarter id cannot be empty");
            }

            if (text == null)
            {
                throw new ArgumentNullException(nameof(id), "ConversationStarter id cannot be empty");
            }

            Text = text; 
            Id = id;
        }

        ConversationStarterText GetConversationStarter()
        {
            return Text;
        }
    }
}
