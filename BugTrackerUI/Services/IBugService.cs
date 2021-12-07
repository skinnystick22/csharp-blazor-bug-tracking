using System.Collections.Generic;

namespace BugTrackerUI
{
    public interface IBugService
    {
        List<Bug> GetBugs();

        void AddBug(Bug newBug);
    }
}