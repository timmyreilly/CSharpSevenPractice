using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppOne.Models;

namespace WebAppOne.Services
{
    public interface IAnnouncementsService
    {
        Task<IEnumerable<Announcement>> GetAnnouncementAsync();
    }

    public class AnnouncementServiceDefault {
        // have a couple things. 
        private IAnnouncementsService _bob;

        public AnnouncementServiceDefault(IAnnouncementsService bitOrBob) 
        {
            _bob =  bitOrBob; 
        } 




    }

    public class AnnouncementService : IAnnouncementsService // this is... "is, a" relationship? The Announcement service is-a Announcement. 
    {
        public async Task<IEnumerable<Announcement>> GetAnnouncementAsync()
        {
            List<Announcement> announcements = new List<Announcement>()
            {
                new Announcement() {
                    Title = "Announcement 1", Content= "my information"
                },
                new Announcement() {
                    Title = "What's is up.", Content = "DOMAIN MODELING IS DOPE"
                }

            }; 
            return announcements; 
        }
    }
}