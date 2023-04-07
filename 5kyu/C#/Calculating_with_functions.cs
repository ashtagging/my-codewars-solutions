// This time we want to write calculations using functions and get the results. Let's have a look at some examples:

// seven(times(five())); // must return 35
// four(plus(nine())); // must return 13
// eight(minus(three())); // must return 5
// six(dividedBy(two())); // must return 3
// Requirements:

// There must be a function for each number from 0 ("zero") to 9 ("nine")
// There must be a function for each of the following mathematical operations: plus, minus, times, dividedBy
// Each calculation consist of exactly one operation and two numbers
// The most outer function represents the left operand, the most inner function represents the right operand
// Division should be integer division. For example, this should return 2, not 2.666666...:
// eight(dividedBy(three()));

function zero(s) {return s ? Math.floor(eval("0" + s)) : 0;}
function one(s) {return s ? Math.floor(eval("1" + s)) : 1;}
function two(s) {return s ? Math.floor(eval("2" + s)) : 2;}
function three(s) {return s ? Math.floor(eval("3" + s)) : 3;}
function four(s) {return s ? Math.floor(eval("4" + s)) : 4;}
function five(s) {return s ? Math.floor(eval("5" + s)) : 5;}
function six(s) {return s ? Math.floor(eval("6" + s)) : 6;}
function seven(s) {return s ? Math.floor(eval("7" + s)) : 7;}
function eight(s) {return s ? Math.floor(eval("8" + s)) : 8;}
function nine(s) {return s ? Math.floor(eval("9" + s)) : 9;}

function plus(s) {return "+" + s;}
function minus(s) {return "-" + s;}
function times(s) {return "*" + s;}
function dividedBy(s) {return "/" + s;}