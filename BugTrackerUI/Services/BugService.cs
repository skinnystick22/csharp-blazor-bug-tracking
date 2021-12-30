using System.Collections.Generic;

namespace BugTrackerUI.Services;

public class BugService : IBugService
{
    private readonly List<Bug> _bugs = new();

    public void AddBug(Bug newBug)
    {
        newBug.Id = _bugs.Count + 1;
        _bugs.Add(newBug);
    }

    public IEnumerable<Bug> GetBugs()
    {
        return _bugs;
    }
}