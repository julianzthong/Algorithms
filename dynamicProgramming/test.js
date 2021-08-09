function possibilities (word) {
  const sureSignals = {
    '.-': ['A'],
    '-..': ['D'],
    '.': ['E'],
    '--.': ['G'],
    '..': ['I'],
    '-.-': ['K'],
    '--': ['M'],
    '-.': ['N'],
    '---': ['O'],
    '.-.': ['R'],
    '...': ['S'],
    '-': ['T'],
    '..-': ['U'],
    '..-': ['W']
   }
  const ambiguousSignals = {
    '?': ['E', 'T'],
    '??': ['A', 'I', 'M', 'N',],
    '?.': ['I', 'N'],
    '.?': ['I', 'A'],
    '?-': ['A', 'M'],
    '-?': ['M', 'N'],
    '???': ['D', 'G', 'K', 'O', 'R', 'S', 'U', 'W'],
    '.??': ['R', 'S', 'U', 'W'],
    '?.?': ['D', 'K', 'S', 'U'],
    '??.': ['D', 'G', 'R', 'S'],
    '..?': ['S', 'U'],
    '?..': ['D', 'S'],
    '-??': ['D', 'G', 'K', 'O'],
    '?-?': ['R', 'W', 'G', 'O'],
    '??-': ['K', 'O', 'U', 'W'],
    '--?': ['G', 'O'],
    '?--': ['O', 'W']
  }
  function findSignal (signal) {
    signal.includes('?')
    ? return ambiguousSignals[signal]
    : return sureSignals[signal]
  }
  // Need to figure out a way to parse through the word if it has more than 1 signal.
  // Going to split each set of signals with a ',' in the test cases.
  word.includes(',')
    ? let result = []; // multiple signals
    let arrayOfSignals = word.split(', ');
    for (let signal of arrayOfSignals) {
      result.push(findSignal(signal))
    }
    : return findSignal(word) // single signal

}

console.log(possibilities(".-, -., -.."))