pub struct ClassicalMechanics;

impl ClassicalMechanics {
    pub fn linear_mass_density(mass: f64, length: f64) -> f64 {
        mass / length
    }

    pub fn surface_mass_density(mass: f64, area: f64) -> f64 {
        mass / area
    }

    pub fn volumetric_mass_density(mass: f64, volume: f64) -> f64 {
        mass / volume
    }

    pub fn moment_of_mass(mass: f64, radius: f64) -> f64 {
        mass * radius * radius
    }

    pub fn center_of_mass(mass1: f64, mass2: f64, radius1: f64, radius2: f64) -> f64 {
        (mass1 * radius1 + mass2 * radius2) / (mass1 + mass2)
    }

    pub fn reduced_mass(mass1: f64, mass2: f64) -> f64 {
        (mass1 * mass2) / (mass1 + mass2)
    }

    pub fn moment_of_inertia(mass: f64, radius: f64) -> f64 {
        mass * radius * radius
    }
}