using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        var filter = emps.Where(e => emps.Any(sub => sub.Mgr!=null && sub.Mgr.Empno == e.Empno));
        //rosnaco po nazwisko, malejaco po pensji
        var sortedEmps = filter.OrderBy(e => e.Ename).ThenByDescending(e => e.Salary);
        return sortedEmps;
    }
}