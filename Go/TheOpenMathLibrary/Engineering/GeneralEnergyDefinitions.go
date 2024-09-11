package engineering

import (
	"math"
)

// GeneralEnergyDefinitions contains methods for calculating various energy-related properties.
type GeneralEnergyDefinitions struct{}

// MechanicalWork calculates the mechanical work given a force, displacement, and angle.
func MechanicalWork(force, displacement, angle float64) float64 {
	return force * displacement * math.Cos(angle)
}

// WorkDoneOnMechanicalSystem calculates the work done on a mechanical system given a force, displacement, and angle.
func WorkDoneOnMechanicalSystem(force, displacement, angle float64) float64 {
	return force * displacement * math.Cos(angle)
}

// PotentialEnergy calculates the potential energy given a mass, height, and gravity.
func PotentialEnergy(mass, height, gravity float64) float64 {
	return mass * height * gravity
}

// MechanicalEnergy calculates the mechanical energy given kinetic and potential energy.
func MechanicalEnergy(kineticEnergy, potentialEnergy float64) float64 {
	return kineticEnergy + potentialEnergy
}

// MechanicalPower calculates the mechanical power given a force and velocity.
func MechanicalPower(force, velocity float64) float64 {
	return force * velocity
}
