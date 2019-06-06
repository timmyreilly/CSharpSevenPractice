using System;

namespace ConversationStarter.Domain
{
    public class ConversationStarter
    {
        public int Id { get; set; }
        private string Text; 



        string GetConversationStarter() 
        {
            return Text; 
        }
    }
}
