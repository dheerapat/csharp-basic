int theVal = 50;

if (theVal == 50) {
    Console.WriteLine("theVal is 50");
} else if (theVal >= 51 && theVal <= 60){
    Console.WriteLine("theVal is between 51 - 60");
} else {
    Console.WriteLine("theVal something else");
}

// two case if-else
if (theVal <= 50) {
    Console.WriteLine("theVal small");
} else {
    Console.WriteLine("theVal large");
}

// ternary operator
Console.WriteLine(theVal <= 50 ? "theVal small" : "theVal large");