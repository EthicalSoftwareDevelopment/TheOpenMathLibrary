package generalmathematics

import (
	"math"
)

// AlgebraicLibrary provides various algebraic functions.
type AlgebraicLibrary struct{}

// Linear returns the linear value of x.
func (AlgebraicLibrary) Linear(x float64) float64 {
	return x
}

// Cubic returns the cubic value of x.
func (AlgebraicLibrary) Cubic(x float64) float64 {
	return x * x * x
}

// Quartic returns the quartic value of x.
func (AlgebraicLibrary) Quartic(x float64) float64 {
	return x * x * x * x
}

// Quintic returns the quintic value of x.
func (AlgebraicLibrary) Quintic(x float64) float64 {
	return x * x * x * x * x
}

// SquareRoot returns the square root of x.
func (AlgebraicLibrary) SquareRoot(x float64) float64 {
	return math.Sqrt(x)
}

// CubeRoot returns the cube root of x.
func (AlgebraicLibrary) CubeRoot(x float64) float64 {
	return math.Cbrt(x)
}
