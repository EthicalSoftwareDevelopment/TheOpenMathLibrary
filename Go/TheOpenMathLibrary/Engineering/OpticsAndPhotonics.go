package engineering

import (
	"math"
)

// OpticsAndPhotonics contains functions for calculating various properties of light and electromagnetic radiation.
type OpticsAndPhotonics struct{}

// Magnification calculates the magnification given image distance and object distance.
func Magnification(imageDistance, objectDistance float64) float64 {
	return imageDistance / objectDistance
}

// ImageHeight calculates the image height given magnification and object height.
func ImageHeight(magnification, objectHeight float64) float64 {
	return magnification * objectHeight
}

// ImageDistance calculates the image distance given focal length and object distance.
func ImageDistance(focalLength, objectDistance float64) float64 {
	return (focalLength * objectDistance) / (objectDistance - focalLength)
}

// PoyntingVector calculates the Poynting vector given electric field and magnetic field.
func PoyntingVector(electricField, magneticField float64) float64 {
	return electricField * magneticField
}

// PoyntingFlux calculates the Poynting flux given electric field and magnetic field.
func PoyntingFlux(electricField, magneticField float64) float64 {
	return electricField * magneticField
}

// RMSElectricField calculates the RMS electric field given electric field.
func RMSElectricField(electricField float64) float64 {
	return electricField / math.Sqrt(2)
}

// RadiationMomentum calculates the radiation momentum given intensity and speed of light.
func RadiationMomentum(intensity, speedOfLight float64) float64 {
	return intensity / speedOfLight
}

// RadiantIntensity calculates the radiant intensity given power and solid angle.
func RadiantIntensity(power, solidAngle float64) float64 {
	return power / solidAngle
}

// Radiosity calculates the radiosity given emissivity, Stefan-Boltzmann constant, and temperature.
func Radiosity(emissivity, stefanBoltzmannConstant, temperature float64) float64 {
	return emissivity * stefanBoltzmannConstant * math.Pow(temperature, 4)
}

// SpectralRadiance calculates the spectral radiance given radiance and wavelength.
func SpectralRadiance(radiance, wavelength float64) float64 {
	return radiance / wavelength
}

// SpectralIrradiance calculates the spectral irradiance given irradiance and wavelength.
func SpectralIrradiance(irradiance, wavelength float64) float64 {
	return irradiance / wavelength
}

// EnergyDensity calculates the energy density in an EM wave given electric field and magnetic field.
func EnergyDensity(electricField, magneticField float64) float64 {
	return 0.5 * (electricField*electricField + magneticField*magneticField)
}

// KineticMomentum calculates the kinetic momentum of light given speed of light and mass.
func KineticMomentum(speedOfLight, mass float64) float64 {
	return speedOfLight * mass
}

// DopplerEffect calculates the Doppler effect for light given frequency, speed of light, and observer speed.
func DopplerEffect(frequency, speedOfLight, observerSpeed float64) float64 {
	return frequency * (speedOfLight + observerSpeed) / speedOfLight
}

// CherenkovRadiation calculates the Cherenkov radiation given speed of light and refractive index.
func CherenkovRadiation(speedOfLight, refractiveIndex float64) float64 {
	return speedOfLight / refractiveIndex
}

// EMWaveComponent calculates the EM wave components given electric field and magnetic field.
func EMWaveComponent(electricField, magneticField float64) float64 {
	return math.Sqrt(electricField*electricField + magneticField*magneticField)
}

// CriticalAngle calculates the critical angle given two refractive indices.
func CriticalAngle(refractiveIndex1, refractiveIndex2 float64) float64 {
	return math.Asin(refractiveIndex2 / refractiveIndex1)
}

// ThinLensEquation calculates the thin lens equation given focal length, object distance, and image distance.
func ThinLensEquation(focalLength, objectDistance, imageDistance float64) float64 {
	return 1/focalLength - 1/objectDistance + 1/imageDistance
}

// ImageDistancePlaneMirror calculates the image distance in a plane mirror given object distance.
func ImageDistancePlaneMirror(objectDistance float64) float64 {
	return -objectDistance
}

// SphericalMirrorEquation calculates the spherical mirror equation given focal length, object distance, and image distance.
func SphericalMirrorEquation(focalLength, objectDistance, imageDistance float64) float64 {
	return 1/focalLength - 1/objectDistance + 1/imageDistance
}
