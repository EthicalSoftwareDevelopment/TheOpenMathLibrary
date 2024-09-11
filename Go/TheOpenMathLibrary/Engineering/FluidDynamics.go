package engineering

// FluidDynamics contains methods for calculating various properties of fluid dynamics.
type FluidDynamics struct{}

// FlowVelocity calculates the flow velocity given a flow rate and pipe diameter.
func FlowVelocity(flowRate, pipeDiameter float64) float64 {
	return (4 * flowRate) / (3.14159 * pipeDiameter * pipeDiameter)
}

// VelocityPseudovector calculates the velocity pseudovector given a velocity and radius.
func VelocityPseudovector(velocity, radius float64) float64 {
	return velocity * radius
}

// VolumeFlux calculates the volume flux given a flow rate and radius.
func VolumeFlux(flowRate, radius float64) float64 {
	return flowRate / (3.14159 * radius * radius)
}

// MassCurrentPerVolume calculates the mass current per volume given a mass current and volume.
func MassCurrentPerVolume(massCurrent, volume float64) float64 {
	return massCurrent / volume
}

// MassFlowRate calculates the mass flow rate given a density and volume flux.
func MassFlowRate(density, volumeFlux float64) float64 {
	return density * volumeFlux
}

// MassCurrentDensity calculates the mass current density given a density and velocity.
func MassCurrentDensity(density, velocity float64) float64 {
	return density * velocity
}

// MomentumCurrentDensity calculates the momentum current density given a density and velocity.
func MomentumCurrentDensity(density, velocity float64) float64 {
	return density * velocity * velocity
}

// PressureGradient calculates the pressure gradient given a pressure and distance.
func PressureGradient(pressure, distance float64) float64 {
	return pressure / distance
}

// BuoyancyForce calculates the buoyancy force given a density, volume, and gravity.
func BuoyancyForce(density, volume, gravity float64) float64 {
	return density * volume * gravity
}

// BernoullisEquation calculates Bernoulli's equation given a pressure, density, velocity, height, and gravity.
func BernoullisEquation(pressure, density, velocity, height, gravity float64) float64 {
	return pressure + (density * velocity * velocity) + (density * gravity * height)
}

// EulersEquations calculates Euler's equations given a pressure, density, velocity, height, and gravity.
func EulersEquations(pressure, density, velocity, height, gravity float64) float64 {
	return pressure + (density * velocity * velocity) + (density * gravity * height)
}

// ConvectiveAcceleration calculates the convective acceleration given a velocity and acceleration.
func ConvectiveAcceleration(velocity, acceleration float64) float64 {
	return velocity * acceleration
}

// NavierStokesEquations calculates the Navier-Stokes equations given a pressure, density, velocity, height, and gravity.
func NavierStokesEquations(pressure, density, velocity, height, gravity float64) float64 {
	return pressure + (density * velocity * velocity) + (density * gravity * height)
}
