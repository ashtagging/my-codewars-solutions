// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

// Example
// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
// The returned format must be correct in order to complete this challenge.

// Don't forget the space after the closing parentheses!

function createPhoneNumber(numbers){
  
  return "(" + String(numbers[0]) +String(numbers[1]) + String(numbers[2]) + ") " 
          + String(numbers[3]) + String(numbers[4]) + String(numbers[5]) + "-"
          + String(numbers[6]) + String(numbers[7]) + String(numbers[8]) + String(numbers[9])
}