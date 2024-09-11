package actuarialcalculators

import (
	"math"
)

// TranscendentalLibrary provides various transcendental functions.
type TranscendentalLibrary struct{}

// Exponential returns x raised to the power of 'power'.
func (TranscendentalLibrary) Exponential(x, power float64) float64 {
	return math.Pow(x, power)
}

// HyperbolicSine returns the hyperbolic sine of x.
func (TranscendentalLibrary) HyperbolicSine(x float64) float64 {
	return math.Sinh(x)
}

// Logarithm returns the natural logarithm of x.
func (TranscendentalLibrary) Logarithm(x float64) float64 {
	return math.Log(x)
}

// CommonLogarithm10 returns the base-10 logarithm of x.
func (TranscendentalLibrary) CommonLogarithm10(x float64) float64 {
	return math.Log10(x)
}

// BinaryLogarithm2 returns the base-2 logarithm of x.
func (TranscendentalLibrary) BinaryLogarithm2(x float64) float64 {
	return math.Log2(x)
}
