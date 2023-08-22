int x = 100;
int y = 10;
int result;

// try {
//     result = x / y;
//     Console.WriteLine("the result is: {0}", result);
// } catch {
//     Console.WriteLine("Whoops");
// }

try {
    if (x > 1000) {
        throw new ArgumentOutOfRangeException("x", "x is too large");
    }
    result = x / y;
    Console.WriteLine("the result is: {0}", result);
} catch (DivideByZeroException e) {
    Console.WriteLine("Whoops");
    Console.WriteLine(e.Message);
} catch (ArgumentOutOfRangeException e) {
    Console.WriteLine("you are gone too far");
    Console.WriteLine(e.Message);
} finally {
    Console.WriteLine("always run");
    // useful for resource release
}