using System;
using Task6;
namespace MyListTest;


public class Tests
{
    /*[SetUp]
    public void Setup()
    {
    }*/

    [Test]
    public void MyListSetupTests()
    {
        MyList<int> intList = new MyList<int>();
        Assert.AreEqual(0, intList.Count);
        Assert.IsTrue(intList.isEmpty);

        intList = new MyList<int>(16);
        Assert.AreEqual(0, intList.Count);
        Assert.IsTrue(intList.isEmpty);
    }

    [Test]
    public void MyListAddTests()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(13);
        Assert.AreEqual(1, intList.Count);
        Assert.IsFalse(intList.isEmpty);
        
        intList.Add(35);
        Assert.AreEqual(2, intList.Count);
        Assert.IsFalse(intList.isEmpty);
        
        intList.Add(29);
        Assert.AreEqual(3, intList.Count);
        
        
        intList.Add(16);
        Assert.AreEqual(4, intList.Count);
        
        
        intList.Add(48);
        Assert.AreEqual(5, intList.Count);
        
        
        intList.Add(90);
        Assert.AreEqual(6, intList.Count);
        
        Assert.AreEqual(13, intList.GetAt(0));
        Assert.AreEqual(35, intList.GetAt(1));
        Assert.AreEqual(29, intList.GetAt(2));
        Assert.AreEqual(16, intList.GetAt(3));
        Assert.AreEqual(48, intList.GetAt(4));
        Assert.AreEqual(90, intList.GetAt(5));
    }

    [Test]
    public void MyListRemoveAtTests()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(13);
        intList.RemoveAt(0);
        
        Assert.AreEqual(0, intList.Count);
        Assert.IsTrue(intList.isEmpty);
        
        intList.Add(85);
        intList.Add(43);
        intList.Add(8643);
        intList.Add(90);
        intList.Add(1000);
        intList.Add(1200);
        Assert.AreEqual(6, intList.Count);
        
        intList.RemoveAt(5);
        Assert.AreEqual(5, intList.Count);
        intList.RemoveAt(0);
        Assert.AreEqual(4, intList.Count);
        intList.RemoveAt(2);
        Assert.AreEqual(3, intList.Count);
        
        Assert.AreEqual(43, intList.GetAt(0));
        Assert.AreEqual(8643, intList.GetAt(1));
        Assert.AreEqual(1000, intList.GetAt(2));
    }
    
    [Test]
    public void MyListRemoveTests()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(100);
        intList.Remove(100);
        
        Assert.AreEqual(0, intList.Count);
        Assert.IsTrue(intList.isEmpty);
        
        intList.Add(33);
        intList.Add(26);
        intList.Add(4123);
        intList.Add(11);
        intList.Add(300);
        intList.Add(2023);
        Assert.AreEqual(6, intList.Count);
        
        intList.Remove(11);
        Assert.AreEqual(5, intList.Count);
        intList.Remove(4123);
        Assert.AreEqual(4, intList.Count);
        intList.Remove(33);
        Assert.AreEqual(3, intList.Count);
        
        Assert.AreEqual(26, intList.GetAt(0));
        Assert.AreEqual(300, intList.GetAt(1));
        Assert.AreEqual(2023, intList.GetAt(2));
    }

    [Test]
    public void MyListClearTest()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(13);
        intList.Add(65);
        intList.Add(73);
        intList.Add(5678);
        intList.Add(987);
        intList.Clear();
        Assert.AreEqual(0, intList.Count);
        Assert.IsTrue(intList.isEmpty);
    }
    
    [Test]
    public void MyListContainsTest()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(13);
        intList.Add(65);
        intList.Add(73);
        intList.Add(5678);
        Assert.IsTrue(intList.Contains(73));
        Assert.IsTrue(intList.Contains(65));
        Assert.IsTrue(intList.Contains(13));
        Assert.IsTrue(intList.Contains(5678));
        Assert.IsFalse(intList.Contains(1001));
    }
    
    [Test]
    public void MyListIndexOfTest()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(54);
        intList.Add(66);
        intList.Add(2314);
        intList.Add(11);
        intList.Add(333);
        intList.Add(100);
        Assert.AreEqual(3, intList.IndexOf(2314));
        Assert.AreEqual(5, intList.IndexOf(100));
        Assert.AreEqual(0, intList.IndexOf(54));
        
    }

    [Test]
    public void ThrowExceptionIfRemoveAtInvalidIndex()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(13);
        intList.Add(35);
        intList.Add(29);
        intList.RemoveAt(3);
    }
    
    [Test]
    public void ThrowExceptionIfGetAtInvalidIndex()
    {
        MyList<int> intList = new MyList<int>(2);
        intList.Add(13);
        intList.Add(35);
        intList.Add(29);
        intList.GetAt(3);
    }
    
}