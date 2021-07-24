/**
 * @param {string} target
 * @return {string}
 */

 var alphabetBoardPath = function(target) {
  let path = '';
  const checkBoard = (letter) => {
      let board = [['a', 'b', 'c', 'd', 'e'],
          ['f', 'g', 'h', 'i', 'j'],
          ['k', 'l', 'm', 'n', 'o'],
          ['p', 'q', 'r', 's', 't'],
          ['u', 'v', 'w', 'x', 'y'],
          ['z']];
      for (let i = 0; i < board.length; i++) {
          if (board[i].indexOf(letter) !== -1) {
              return [i, board[i].indexOf(letter)]
          }
      }
  }
  let n = target.length;
  let coords = [[0,0]];
  for (let i = 0; i < n; i++) {
    coords.push(checkBoard(target[i]));
  }

  const findPath = (coord1, coord2) => {
    let diff = [(coord1[0] - coord2[0]), (coord1[1] - coord2[1])];
    let y = diff[0];
    let x = diff[1];
    if (coord2[0] === 5) {
      if (y === 0 && x === 0) { // LOTS OF EDGE CASES SMH
        path += '!';
        return;
      }
      if (y > 0) {
        for (let i = 0; i < y; i++) {
          path += 'U';
        }
      } else if (y < 0) {
        for (let i = -1; i > y; i--) {
          path += 'D';
        }
      }
      if (x > 0) {
        for (let i = 0; i < x; i++) {
          path += 'L';
        }
      } else if (x < 0) {
        for (let i = 0; i > x; i--) {
          path += 'R';
        }
      }
      path += 'D!';
      return;
    }

    if (y > 0) {
      for (let i = 0; i < y; i++) {
        path += 'U';
      }
    } else if (y < 0) {
      for (let i = 0; i > y; i--) {
        path += 'D';
      }
    }
    if (x > 0) {
      for (let i = 0; i < x; i++) {
        path += 'L';
      }
    } else if (x < 0) {
      for (let i = 0; i > x; i--) {
        path += 'R';
      }
    }
    path += '!';
  }

  for (let i = 0; i < (coords.length - 1); i++) {
    findPath(coords[i], coords[(i+1)]);
  }

  return path;
};


