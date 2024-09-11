package engineering

// MechanicalOscillations contains methods for calculating mechanical energy oscillations.
type MechanicalOscillations struct{}

// SHMEnergy calculates the energy of a simple harmonic motion (SHM) system given mass, amplitude, and angular frequency.
func SHMEnergy(mass, amplitude, angularFrequency float64) float64 {
	return 0.5 * mass * amplitude * amplitude * angularFrequency * angularFrequency
}

// DHMEnergy calculates the energy of a damped harmonic motion (DHM) system given mass, amplitude, and angular frequency.
func DHMEnergy(mass, amplitude, angularFrequency float64) float64 {
	return 0.5 * mass * amplitude * amplitude * angularFrequency * angularFrequency
}
