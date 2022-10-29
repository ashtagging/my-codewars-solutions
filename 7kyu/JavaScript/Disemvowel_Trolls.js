// Trolls are attacking your comment section!

// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

// Your task is to write a function that takes a string and return a new string with all vowels removed.

// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

// Note: for this kata y isn't considered a vowel.


//Can use REGEX for a better soloution

function disemvowel(str) {
    let stringArray = str.split('')
    let testArray = stringArray.filter(letter => 
    letter !=='a' && letter !=='e' && letter !=='i'&& letter !=='o' && letter !=='u' 
    && letter !=='A' && letter !=='E' && letter !=='I' && letter !=='O' && letter !=='U')
    let result =  testArray.join("")
    return result
  }