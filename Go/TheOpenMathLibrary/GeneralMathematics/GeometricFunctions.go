package generalmathematics

// GeometryFunctions provides various geometric functions.
type GeometryFunctions struct{}

// TriangleArea calculates the area of a triangle given its base length and height.
func (GeometryFunctions) TriangleArea(baseLength, height float64) float64 {
	return 0.5 * baseLength * height
}

// CylinderVolume calculates the volume of a cylinder given its radius and height.
func (GeometryFunctions) CylinderVolume(radius, height float64) float64 {
	return 3.14159 * radius * radius * height
}

// SphereVolume calculates the volume of a sphere given its radius.
func (GeometryFunctions) SphereVolume(radius float64) float64 {
	return (4.0 / 3.0) * 3.14159 * radius * radius * radius
}

// RectangularPrismVolume calculates the volume of a rectangular prism given its length, width, and height.
func (GeometryFunctions) RectangularPrismVolume(length, width, height float64) float64 {
	return length * width * height
}
