public class Solution {
  public bool IsPalindrome(int num) {
    if (num < 0) return false;
    string snum = num.ToString();
    int count = snum.Length - 1;
    int half = count / 2;
    for (int i = 0; i < count; i++) {
      if (snum.Substring(i, i+1) == snum.Substring(count-i,count)) return true;
    }

  return false;
  }
}