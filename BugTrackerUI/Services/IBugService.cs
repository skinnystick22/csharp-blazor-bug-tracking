using System.Collections.Generic;

namespace BugTrackerUI.Services;

public interface IBugService
{
    IEnumerable<Bug> GetBugs();

    void AddBug(Bug newBug);
}