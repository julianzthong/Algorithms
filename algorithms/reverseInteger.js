/**
 * @param {number} x
 * @return {number}
 */
 var reverse = function(x) {
  if (Math.abs(x) < 10) {
      return x
  } else if (x < 0) {
      let result = '';
      x = Math.abs(x);
      let string = JSON.stringify(x);
      for (let i = (string.length-1); i >= 0; i--) {
          result += string[i];
      }
      result = Number(result)
      result = result * -1;
      if  (result < -2147483648) {
      return 0
      }
      return result;
  } else if ( x > 0 ) {
      let result = '';
      let string = JSON.stringify(x);
      for (let i = (string.length-1); i >= 0; i--) {
          result += string[i];
      }
      result = Number(result);
      if  (result > 2147483648) {
      return 0
      }
      return result;
  }

};

/*
A little tricky because you have to take the 32-bit integer size into consideration.
*/