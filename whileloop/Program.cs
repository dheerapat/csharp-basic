string inputStr = "";

Console.WriteLine("enter a string");

// while (inputStr != "exit") {
//     inputStr = Console.ReadLine();
//     Console.WriteLine("receive: {0}", inputStr);
// }

do {
    inputStr = Console.ReadLine();
    Console.WriteLine("receive: {0}", inputStr);
} while(inputStr != "exit");

// do-while will guarantee to run at least once before condotion is checked