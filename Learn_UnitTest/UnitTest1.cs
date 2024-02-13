namespace Learn_UnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        bool result = IsStringLong("abcddddd");
        //AreEqualメソッド：二つのオブジェクトを比較して同じであるかを判定する。
        Assert.AreEqual(false, result);
    }

    public static bool IsStringLong(string input)
    {
        if (input.Length > 5)
            return true;
        return false;
    }
}
