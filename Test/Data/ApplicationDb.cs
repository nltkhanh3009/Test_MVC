using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb( DbContextOptions <ApplicationDb> options) :base(options)
        {
                
        }
    }
}
