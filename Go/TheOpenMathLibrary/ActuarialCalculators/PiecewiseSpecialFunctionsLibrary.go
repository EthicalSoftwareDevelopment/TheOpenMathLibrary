package actuarialcalculators

import (
	"math"
)

// PiecewiseSpecialFunctionsLibrary provides various piecewise special functions.
type PiecewiseSpecialFunctionsLibrary struct{}

// IndicatorFunction returns 1 if x is 0, otherwise returns 0.
func (PiecewiseSpecialFunctionsLibrary) IndicatorFunction(x float64) float64 {
	if x == 0 {
		return 1
	}
	return 0
}

// StepFunction returns 0 if x < 0, 0.5 if x == 0, and 1 if x > 0.
func (PiecewiseSpecialFunctionsLibrary) StepFunction(x float64) float64 {
	if x < 0 {
		return 0
	} else if x == 0 {
		return 0.5
	}
	return 1
}

// HeavisideStepFunction returns 0 if x < 0, otherwise returns 1.
func (PiecewiseSpecialFunctionsLibrary) HeavisideStepFunction(x float64) float64 {
	if x < 0 {
		return 0
	}
	return 1
}

// RectangularFunction returns 0 if x < -0.5 or x > 0.5, 0.5 if x == -0.5 or x == 0.5, otherwise returns 1.
func (PiecewiseSpecialFunctionsLibrary) RectangularFunction(x float64) float64 {
	if x < -0.5 || x > 0.5 {
		return 0
	} else if x == -0.5 || x == 0.5 {
		return 0.5
	}
	return 1
}

// SawtoothFunction returns the sawtooth wave value of x.
func (PiecewiseSpecialFunctionsLibrary) SawtoothFunction(x float64) float64 {
	return x - math.Floor(x)
}

// TriangleWaveFunction returns the triangle wave value of x.
func (PiecewiseSpecialFunctionsLibrary) TriangleWaveFunction(x float64) float64 {
	return 2 * math.Abs(PiecewiseSpecialFunctionsLibrary{}.SawtoothFunction(x)-0.5)
}

// SquareWaveFunction returns the square wave value of x.
func (PiecewiseSpecialFunctionsLibrary) SquareWaveFunction(x float64) float64 {
	return PiecewiseSpecialFunctionsLibrary{}.IndicatorFunction(PiecewiseSpecialFunctionsLibrary{}.SawtoothFunction(x) - 0.5)
}

// SincFunction returns the sinc function value of x.
func (PiecewiseSpecialFunctionsLibrary) SincFunction(x float64) float64 {
	if x == 0 {
		return 1
	}
	return math.Sin(x) / x
}

// DirichletKernel returns the Dirichlet kernel value of x and N.
func (PiecewiseSpecialFunctionsLibrary) DirichletKernel(x float64, N int) float64 {
	return math.Sin((float64(N)+0.5)*x) / (float64(N) * math.Sin(0.5*x))
}
