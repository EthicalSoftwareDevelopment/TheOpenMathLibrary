package generalmathematics

import (
	"math"
)

// WaveTheory provides various wave theory functions.
type WaveTheory struct{}

// Wavelength returns the wavelength given wave speed and frequency.
func (WaveTheory) Wavelength(waveSpeed, frequency float64) float64 {
	return waveSpeed / frequency
}

// WaveVector returns the wave vector given wave speed and frequency.
func (WaveTheory) WaveVector(waveSpeed, frequency float64) float64 {
	return 2 * math.Pi * frequency / waveSpeed
}

// Frequency returns the frequency given wave speed and wavelength.
func (WaveTheory) Frequency(waveSpeed, wavelength float64) float64 {
	return waveSpeed / wavelength
}

// AngularFrequency returns the angular frequency given frequency.
func (WaveTheory) AngularFrequency(frequency float64) float64 {
	return 2 * math.Pi * frequency
}

// OscillatoryVelocity returns the oscillatory velocity.
func (WaveTheory) OscillatoryVelocity(amplitude, angularFrequency, time, phase float64) float64 {
	return amplitude * math.Sin(angularFrequency*time+phase)
}

// OscillatoryAcceleration returns the oscillatory acceleration.
func (WaveTheory) OscillatoryAcceleration(amplitude, angularFrequency, time, phase float64) float64 {
	return amplitude * angularFrequency * math.Cos(angularFrequency*time+phase)
}

// PhaseVelocity returns the phase velocity given wave speed and wave vector.
func (WaveTheory) PhaseVelocity(waveSpeed, waveVector float64) float64 {
	return waveSpeed / waveVector
}

// GroupVelocity returns the group velocity given wave speed and wave vector.
func (WaveTheory) GroupVelocity(waveSpeed, waveVector float64) float64 {
	return waveSpeed / waveVector
}

// TimeDelay returns the time delay given time and phase.
func (WaveTheory) TimeDelay(time, phase float64) float64 {
	return time - phase
}

// PhaseDifference returns the phase difference given two phases.
func (WaveTheory) PhaseDifference(phase1, phase2 float64) float64 {
	return phase1 - phase2
}

// Phase returns the phase given wave vector, position, time, and initial phase.
func (WaveTheory) Phase(waveVector, position, time, phase float64) float64 {
	return waveVector*position - 2*math.Pi*time + phase
}
