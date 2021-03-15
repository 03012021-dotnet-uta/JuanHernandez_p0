var starCount = 1;
var endCount = 1000;
var sweetCount = 0;
var saltyCount = 0;
var sweetNSaltyCount = 0;

// For loop that counts to 1000
for (; starCount <= endCount; starCount++) {
    if (starCount % 3 == 0 && starCount % 5 == 0) // For numbers which are multiples of three and five, print “sweet’nSalty” to the console (instead of the number).  
    {
        if (starCount % 10 == 0) {
            console.log("Sweet'N'Salty "); // After every 10 numbers start a new line of numbers
        }
        console.log("Sweet'N'Salty ");
        sweetNSaltyCount += 1; //counts sweet'n'salty
    } else if (starCount % 3 == 0) // When the number is multiple of three, print “sweet” instead of the number on the console.  
    {
        console.log("Sweet ");
        sweetCount += 1; //counts sweet
    } else if (starCount % 5 == 0) // If the number is a multiple of five, print “salty” (instead of the number) to the console.  
    {
        console.log("Salty ");
        saltyCount += 1; //counts salty

        if (starCount % 10 == 0) {
            console.log(); // After every 10 numbers start a new line of numbers
        }
    } else {
        console.log(starCount + " ");
    }
}

//Shows the amount of times each word was counted
console.log("\n\nSweet Count: " + sweetCount);
console.log("Salty Count: " + saltyCount);
console.log("Sweet'N'Salty Count: " + sweetNSaltyCount);