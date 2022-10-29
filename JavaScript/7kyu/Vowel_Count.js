// Return the number (count) of vowels in the given string.

// We will consider a, e, i, o, u as vowels for this Kata (but not y).

// The input string will only consist of lower case letters and/or spaces.

function getCount(str) {
  var vowelsCount = 0;
  
  let letterArray = str.split('');
  
  
  letterArray.forEach((letter) => {
    switch(letter){
              case 'a':
        ++vowelsCount;
      break;
      case 'e':
        ++vowelsCount;
      break;  
      case 'i':
        ++vowelsCount;
      break;
      case 'o':
        ++vowelsCount;
      break;
      case 'u':
        ++vowelsCount;
      break;
    }

  })
  return vowelsCount;
}