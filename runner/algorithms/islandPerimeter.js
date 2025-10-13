/**
 * @param {number[][]} grid
 * @return {number}
 */
var islandPerimeter = function(grid) {
  let rows = grid.length;
  let cols = grid[0].length;
  let perimeter = 0;
  let checkLeft = function(grid, r, c) {
    if (grid[r][c-1] == 0 || grid[r][c-1] == undefined) {
      return 1;
    }
    return 0
  }
  let checkRight = function(grid, r, c) {
    if (grid[r][c+1] == 0 || grid[r][c+1] == undefined) {
      return 1;
    }
    return 0;
  }
  let checkUp = function(grid, r, c) {
    if (grid[r-1] === undefined || grid[r-1][c] == 0 || grid[r-1][c] == undefined) {
      return 1;
    }
    return 0;
  }
  let checkDown = function(grid, r, c) {
    if (grid[r+1] === undefined || grid[r+1][c] == 0 || grid[r+1][c] == undefined) {
      return 1;
    }
    return 0;
  }

  for (let r = 0; r < rows; r++) {
    for (let c = 0; c < cols; c++) {
      if (grid[r][c] === 0) {
        continue;
      } else {
        perimeter += checkLeft(grid, r, c);
        perimeter += checkRight(grid, r, c);
        perimeter += checkUp(grid, r, c);
        perimeter += checkDown(grid, r, c);
      }
    }
  }

  return perimeter;
};

grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
console.log(islandPerimeter(grid));
// [0,1,0,0]
// [1,1,1,0]
// [0,1,0,0]
// [1,1,0,0]