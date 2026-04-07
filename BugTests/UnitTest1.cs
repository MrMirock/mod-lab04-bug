using BugPro;
namespace BugTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_Open_Close_Throws()
    {
        var bug = new Bug(Bug.State.Open);
        Assert.Throws<InvalidOperationException>(() => bug.Close());
    }
    [TestMethod]
    public void Test_Open_Defer_Throws()
    {
        var bug = new Bug(Bug.State.Open);
        Assert.Throws<InvalidOperationException>(() => bug.Defer());
    }
    [TestMethod]
    public void Test_Closed_Close_Throws()
    {
        var bug = new Bug(Bug.State.Closed);
        Assert.Throws<InvalidOperationException>(() => bug.Close());
    }
    [TestMethod]
    public void Test_Closed_Defer_Throws()
    {
        var bug = new Bug(Bug.State.Closed);
        Assert.Throws<InvalidOperationException>(() => bug.Defer());
    }
    [TestMethod]
    public void Test_Defered_Close_Throws()
    {
        var bug = new Bug(Bug.State.Defered);
        Assert.Throws<InvalidOperationException>(() => bug.Close());
    }
    [TestMethod]
    public void Test_Defered_Defer_Throws()
    {
        var bug = new Bug(Bug.State.Defered);
        Assert.Throws<InvalidOperationException>(() => bug.Defer());
    }
    [TestMethod]
    public void Test_OpenAssignClose_ThenClose_Throws()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Close();
        Assert.Throws<InvalidOperationException>(() => bug.Close());
    }
    [TestMethod]
    public void Test_OpenAssignDefer_ThenDefer_Throws()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        Assert.Throws<InvalidOperationException>(() => bug.Defer());
    }
    [TestMethod]
    public void Test_OpenAssignClose_ThenDefer_Throws()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Close();
        Assert.Throws<InvalidOperationException>(() => bug.Defer());
    }
    [TestMethod]
    public void Test_OpenAssignDefer_ThenClose_Throws()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        bug.Defer();
        Assert.Throws<InvalidOperationException>(() => bug.Close());
    }
}