
namespace ConversationStarter.Domain
{
    public class ConversationStarterText 
    {
        public string Value { get; }

        internal ConversationStarterText(string text) => Value = text; 

        public static ConversationStarterText FromString(string text) => 
            new ConversationStarterText(text); 

    }
}