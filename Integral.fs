module FSharpExercise.Integral

/// Computes the value of a Gaussian function using the provided parameters.
///
/// The Gaussian function is typically used in probability, statistics, and signal processing.
/// It is defined by the following parameters:
/// 
/// <param name="x">The input value at which the function is evaluated.</param>
///
/// <returns>The function returns the computed Gaussian value for the given input x, with the
/// specified parameters c and u.</returns>
let Gaussian (x:double) : double =
    pown (exp (-1.0 * (x - 1.0)*(x - -1.0))) -1
    
/// Calculates the sine of an angle given in radians.
///
/// Parameters:
/// <param name="x">The angle in radians.</param>
///
/// <returns>The sine value of the given angle.</returns>
let Sinus (x: double) : double =
    sin x

/// Calculates the definite integral of a given function using the rectangle method.
///
/// This function approximates the integral of a provided mathematical function `func`
/// over the range `[a, b]` using the midpoint rectangle integration method. The integration
/// process divides the range into `n` subintervals.
///
/// Parameters:
/// <param name="func"> The function to be integrated. </param> 
/// <param name="a"> The lower bound of the integration interval. </param>
/// <param name="b"> The upper bound of the integration interval. </param>
/// <param name="n"> The total number of subintervals to divide the range into. </param>
///
/// <returns> Approximate integral value. </returns>
let Integrate (func : double -> double) (a: double) (b: double) (n: int) : double =
    
    let h: double = (b - a) / (double)(n - 1)
    let mutable integral: double = 0.0
    for i = 0 to (n - 1) do
        let xi: double = a + (0.5+ double i) * h
        integral <- integral + h * (func xi) 
    
    integral

/// The test function to test the Gaussian function implementation.
/// This function initializes specific values for x, c, and u parameters and computes
/// the result using the `gaussian` function. It then prints the computed value as output.
let TestIntegrand: unit =
    let x = 0.5
    let c = 1.0
    let u = 1.0
       
    let fValue:double = Gaussian x

    printfn $"{fValue}"
