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
  let coords = [];
  for (let i = 0; i < n; i++) {
    coords.push(checkBoard(target[i]));
  }


};

alphabetBoardPath('hello');