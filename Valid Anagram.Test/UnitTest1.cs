namespace Valid_Anagram.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("","",true)]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("aacc", "ccac",false)]
        public void Test1(string s, string t, bool expected)
        {
            Solution sol = new Solution();
            bool res = sol.IsAnagram(s, t);
            Assert.Equal(expected, res);
        }
    }
}