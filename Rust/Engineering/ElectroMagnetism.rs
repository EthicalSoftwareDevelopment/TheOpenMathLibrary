pub struct ElectroMagnetism;

impl ElectroMagnetism {
    pub fn electric_field_potential_gradient(electric_field: f64, potential: f64) -> f64 {
        electric_field / potential
    }

    pub fn electric_flux_density(electric_field: f64, permittivity: f64) -> f64 {
        electric_field / permittivity
    }

    pub fn absolute_permittivity(electric_flux_density: f64, electric_field: f64) -> f64 {
        electric_flux_density / electric_field
    }

    pub fn electric_dipole_moment(charge: f64, distance: f64) -> f64 {
        charge * distance
    }

    pub fn electric_polarization(electric_dipole_moment: f64, volume: f64) -> f64 {
        electric_dipole_moment / volume
    }

    pub fn electric_displacement_field(electric_polarization: f64, permittivity: f64) -> f64 {
        electric_polarization / permittivity
    }

    pub fn electric_displacement_flux(electric_displacement_field: f64, area: f64) -> f64 {
        electric_displacement_field * area
    }

    pub fn absolute_electric_potential(electric_field: f64, distance: f64) -> f64 {
        electric_field * distance
    }
}