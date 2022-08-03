//IIFE and Closure
const empID = (function () {
    let count = 0;
    return function () {    
        ++count;
        return `emp${count}`;
    }
})();

console.log("New Employee IDs are listed here:");
console.log("Alex: " + empID());
console.log("Dexter: " + empID());
console.log("Annie: " + empID());

//Callbacks
console.log("\n");
function fullName(firstName, lastName, foo) {
    console.log("My name is " + firstName + " " + lastName);
    foo(firstName);
}

var greeting = function (ln) {
    console.log("Welcome " + ln);
}

fullName("Alex", "Wilson", greeting);
console.log("\n");
fullName("Dexter", "Johnson", greeting);
console.log("\n");
fullName("Annie", "Butler", greeting);
