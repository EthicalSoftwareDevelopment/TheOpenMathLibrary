package engineering

// LinearMassDensity calculates the linear mass density.
func LinearMassDensity(mass, length float64) float64 {
	return mass / length
}

// SurfaceMassDensity calculates the surface mass density.
func SurfaceMassDensity(mass, area float64) float64 {
	return mass / area
}

// VolumetricMassDensity calculates the volumetric mass density.
func VolumetricMassDensity(mass, volume float64) float64 {
	return mass / volume
}

// MomentOfMass calculates the moment of mass.
func MomentOfMass(mass, radius float64) float64 {
	return mass * radius * radius
}

// CenterOfMass calculates the center of mass for two masses.
func CenterOfMass(mass1, mass2, radius1, radius2 float64) float64 {
	return (mass1*radius1 + mass2*radius2) / (mass1 + mass2)
}

// ReducedMass calculates the reduced mass for a two-body system.
func ReducedMass(mass1, mass2 float64) float64 {
	return (mass1 * mass2) / (mass1 + mass2)
}

// MomentOfInertia calculates the moment of inertia.
func MomentOfInertia(mass, radius float64) float64 {
	return mass * radius * radius
}
