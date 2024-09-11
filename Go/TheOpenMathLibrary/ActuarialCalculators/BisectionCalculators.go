package actuarialcalculators

import (
	"errors"
	"math"
)

// BisectionLibrary contains methods for executing the Bisection Method.
type BisectionLibrary struct{}

// Bisection determines the root of a function (i.e., where a function reaches zero).
// valueA: The starting point of the interval.
// valueB: The ending point of the interval.
// tolerance: The acceptable error margin for the root.
// maxIterations: The maximum number of iterations to perform.
// mathFunction: The function for which the root is being sought.
func Bisection(valueA, valueB, tolerance float64, maxIterations int, mathFunction func(float64) float64) (float64, error) {
	functionA := mathFunction(valueA)
	functionB := mathFunction(valueB)
	if functionA*functionB > 0 {
		return 0, errors.New("function(a) and function(b) must have opposite signs")
	}
	var c float64
	for i := 0; i < maxIterations; i++ {
		c = (valueA + valueB) / 2
		functionC := mathFunction(c)
		if math.Abs(functionC) < tolerance {
			break
		}
		if functionA*functionC < 0 {
			valueB = c
			functionB = functionC
		} else {
			valueA = c
			functionA = functionC
		}
	}
	return c, nil
}

// NewtonRaphson finds the root of a function using the Newton-Raphson method.
// x0: Initial guess.
// tolerance: The acceptable error margin for the root.
// maxIterations: The maximum number of iterations to perform.
// mathFunction: The function for which the root is being sought.
// mathFunctionDerivative: The derivative of the function.
func NewtonRaphson(x0, tolerance float64, maxIterations int, mathFunction, mathFunctionDerivative func(float64) float64) float64 {
	x := x0
	for i := 0; i < maxIterations; i++ {
		functionX := mathFunction(x)
		derivativeX := mathFunctionDerivative(x)
		x1 := x - functionX/derivativeX
		if math.Abs(x1-x) < tolerance {
			break
		}
		x = x1
	}
	return x
}

// Binomial determines the root of a function using a binomial method.
// valueA: The starting point of the interval.
// valueB: The ending point of the interval.
// tolerance: The acceptable error margin for the root.
// maxIterations: The maximum number of iterations to perform.
// mathFunction: The function for which the root is being sought.
func Binomial(valueA, valueB, tolerance float64, maxIterations int, mathFunction func(float64) float64) (float64, error) {
	functionA := mathFunction(valueA)
	functionB := mathFunction(valueB)
	if functionA*functionB > 0 {
		return 0, errors.New("function(a) and function(b) must have opposite signs")
	}
	var c float64
	for i := 0; i < maxIterations; i++ {
		c = (valueA + valueB) / 2
		functionC := mathFunction(c)
		if math.Abs(functionC) < tolerance {
			break
		}
		if functionA*functionC < 0 {
			valueB = c
			functionB = functionC
		} else {
			valueA = c
			functionA = functionC
		}
	}
	return c, nil
}
