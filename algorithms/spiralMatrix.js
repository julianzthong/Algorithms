function spiralCopy(inputMatrix) {
  const row = inputMatrix.length;
  const col = inputMatrix[0].length;

  let rs = 0;
  let cs = 0;
  let re = col - 1;
  let ce = row - 1;

  const total = row * col;
  let ans = [];
  if (row === 1) {
    leftToRight(0, 0, col - 1);
    return ans;
  }
  if (col === 1) {
    topToBottom(0, 0, row - 1);
    return ans;
  }
  let i = 0;

  function leftToRight(k, start, end) {
    console.log(row, col, start, end);
    for (let i = start; i <= end; i++) {
      ans.push(inputMatrix[k][i]);
    }
  }
  function topToBottom(k, start, end) {
    let c = col - 1 - k;
    for (let i = start; i <= end; i++) {
      ans.push(inputMatrix[i][c]);
    }
  }

  function rightToLeft(k, start, end) {
    let r = row - 1 - k;
    for (let i = start; i >= end; i--) {
      ans.push(inputMatrix[r][i]);
    }
  }
  function bottomToTop(k, start, end) {
    for (let i = start; i > end; i--) {
      ans.push(inputMatrix[i][k]);
    }
  }

  while (ans.length < total) {
    leftToRight(i, rs, re - 1);
    rs++;
    topToBottom(i, cs, ce - 1);
    ce--;
    rightToLeft(i, re, rs);
    re--;
    bottomToTop(i, ce + 1, cs);
    cs++;
    i++;
  }
  return ans;
}
/*
inputMatrix = [[1]]
console.log(spiralCopy(inputMatrix))*/
/*inputMatrix  = [ [1,  2,  3,  4,  5],
                 [6,  7,  8,  9,  10],
                 [11, 12, 13, 14, 15],
                 [16, 17, 18, 19, 20] ]

//[1, 2, 3, 4, 5, 10, 15, 20, 19, 18, 17, 16, 11, 6, 7, 8, 9, 14, 13, 12] */
