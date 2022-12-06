// Simple, given a string of words, return the length of the shortest word(s).

// String will never be empty and you do not need to account for different data types.

function findShort(s){
  
  var wordArray = s.split(" ").map(word => word.length).sort((a,b)=> a-b);
    
  return wordArray[0];
    
  }