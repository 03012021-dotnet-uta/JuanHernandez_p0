var endCount = 1000;

var sweetCount = 0;
var saltyCount = 0;
var sweetNSaltyCount = 0;

var sweet = "Sweet";
var salty = "Salty";
var sweetNSalty = "Sweet'N'Salty";


var arry1 = []; //will hold num 1-1000
var arry2 = []; //will hold our new array with the S
var arry3 = []; //holds our output

for (var i = 0; i <= endCount; i++) { //populating array
    arry1[i] = i + 1;
}

for (var i = 0; i < 1000; i++) { //populates array2
    if (arry1[i] % 3 == 0 && arry1[i] % 5 == 0) {
        arry2[i] = sweetNSalty;
        sweetNSaltyCount += 1; //counts sweet n salty
    } else if (arry1[i] % 3 == 0) {
        arry2[i] = sweet;
        sweetCount += 1; //counts sweet
    } else if (arry1[i] % 5 == 0) {
        arry2[i] = salty;
        saltyCount += 1; //counts salty
    } else {
        arry2[i] = `${arry1[i]}`;
    }
}

while (arry2.length > 0) { //divides our array into 100 arrays
    arry3 = arry2.splice(0, 10)
    console.log(arry3)
}

//Shows the amount of times each word was counted
console.log(`\n${sweet} Count: ` + sweetCount);
console.log(`${salty} Count: ` + saltyCount);
console.log(`${sweetNSalty} Count: ` + sweetNSaltyCount);