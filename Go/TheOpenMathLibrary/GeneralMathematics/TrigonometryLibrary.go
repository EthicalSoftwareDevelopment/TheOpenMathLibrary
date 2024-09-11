package generalmathematics

import (
	"math"
)

// TrigonometryLibrary provides various trigonometric functions.
type TrigonometryLibrary struct{}

// Sine returns the sine of x.
func (TrigonometryLibrary) Sine(x float64) float64 {
	return math.Sin(x)
}

// Cosine returns the cosine of x.
func (TrigonometryLibrary) Cosine(x float64) float64 {
	return math.Cos(x)
}

// Tangent returns the tangent of x.
func (TrigonometryLibrary) Tangent(x float64) float64 {
	return math.Tan(x)
}

// Cotangent returns the cotangent of x.
func (TrigonometryLibrary) Cotangent(x float64) float64 {
	return 1 / math.Tan(x)
}

// Secant returns the secant of x.
func (TrigonometryLibrary) Secant(x float64) float64 {
	return 1 / math.Cos(x)
}

// Cosecant returns the cosecant of x.
func (TrigonometryLibrary) Cosecant(x float64) float64 {
	return 1 / math.Sin(x)
}

// Exsecant returns the exsecant of x.
func (TrigonometryLibrary) Exsecant(x float64) float64 {
	return 1/math.Cos(x) - 1
}

// Excosecant returns the excosecant of x.
func (TrigonometryLibrary) Excosecant(x float64) float64 {
	return 1/math.Sin(x) - 1
}

// Versine returns the versine of x.
func (TrigonometryLibrary) Versine(x float64) float64 {
	return 1 - math.Cos(x)
}

// Coversine returns the coversine of x.
func (TrigonometryLibrary) Coversine(x float64) float64 {
	return 1 - math.Sin(x)
}

// Vercosine returns the vercosine of x.
func (TrigonometryLibrary) Vercosine(x float64) float64 {
	return 1 - math.Cos(x)
}

// Covercosine returns the covercosine of x.
func (TrigonometryLibrary) Covercosine(x float64) float64 {
	return 1 - math.Sin(x)
}

// Haversine returns the haversine of x.
func (TrigonometryLibrary) Haversine(x float64) float64 {
	return 0.5 * (1 - math.Cos(x))
}

// Hacoversine returns the hacoversine of x.
func (TrigonometryLibrary) Hacoversine(x float64) float64 {
	return 0.5 * (1 - math.Sin(x))
}

// Havercosine returns the havercosine of x.
func (TrigonometryLibrary) Havercosine(x float64) float64 {
	return 0.5 * (1 - math.Cos(x))
}

// Hacovercosine returns the hacovercosine of x.
func (TrigonometryLibrary) Hacovercosine(x float64) float64 {
	return 0.5 * (1 - math.Sin(x))
}
