/**
 * @param {number} x
 * @return {boolean}
 */

// Basic Iterative Strategy
// var isPalindrome = function(x) {
//   var stringNum = x.toString();
//   var length = stringNum.length;
//   if (length == 1) return true;

//   var half;
//   if (length % 2 == 0)
//   {
//     half = length / 2;
//   } else {
//     half = (length - 1) / 2;
//   }

//   for (var i = 0; i < half; i++) {
//     if (stringNum[i] != stringNum[length-1-i]) return false;
//   }
//   return true
// };

// Recursive Strategy
var isPalindrome = function(x) {
  var s = x.toString();
  if (s.length === 1) return true;
  var start = s[0]
  var end = s[s.length - 1];
  if (start !== end) {
    return false;
  }
  if (s.length === 2) {
    return true
  };
  var substr = s.substring(1, s.length - 1);
  return isPalindrome(substr);
}