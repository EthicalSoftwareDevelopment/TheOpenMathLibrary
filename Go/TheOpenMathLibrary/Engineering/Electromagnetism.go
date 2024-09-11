package engineering

// ElectroMagnetism contains methods for calculating various properties of electromagnetism.
type ElectroMagnetism struct{}

// ElectricFieldPotentialGradient calculates the potential gradient given an electric field and potential.
func ElectricFieldPotentialGradient(electricField, potential float64) float64 {
	return electricField / potential
}

// ElectricFluxDensity calculates the electric flux density given an electric field and permittivity.
func ElectricFluxDensity(electricField, permittivity float64) float64 {
	return electricField / permittivity
}

// AbsolutePermittivity calculates the absolute permittivity given an electric flux density and electric field.
func AbsolutePermittivity(electricFluxDensity, electricField float64) float64 {
	return electricFluxDensity / electricField
}

// ElectricDipoleMoment calculates the electric dipole moment given a charge and distance.
func ElectricDipoleMoment(charge, distance float64) float64 {
	return charge * distance
}

// ElectricPolarization calculates the electric polarization given an electric dipole moment and volume.
func ElectricPolarization(electricDipoleMoment, volume float64) float64 {
	return electricDipoleMoment / volume
}

// ElectricDisplacementField calculates the electric displacement field given an electric polarization and permittivity.
func ElectricDisplacementField(electricPolarization, permittivity float64) float64 {
	return electricPolarization / permittivity
}

// ElectricDisplacementFlux calculates the electric displacement flux given an electric displacement field and area.
func ElectricDisplacementFlux(electricDisplacementField, area float64) float64 {
	return electricDisplacementField * area
}

// AbsoluteElectricPotential calculates the absolute electric potential given an electric field and distance.
func AbsoluteElectricPotential(electricField, distance float64) float64 {
	return electricField * distance
}
