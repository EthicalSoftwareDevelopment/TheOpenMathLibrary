pub struct GeneralEnergyDefinitions;

impl GeneralEnergyDefinitions {
    pub fn mechanical_work(force: f64, displacement: f64, angle: f64) -> f64 {
        force * displacement * angle.cos()
    }

    pub fn work_done_on_mechanical_system(force: f64, displacement: f64, angle: f64) -> f64 {
        force * displacement * angle.cos()
    }

    pub fn potential_energy(mass: f64, height: f64, gravity: f64) -> f64 {
        mass * height * gravity
    }

    pub fn mechanical_energy(kinetic_energy: f64, potential_energy: f64) -> f64 {
        kinetic_energy + potential_energy
    }

    pub fn mechanical_power(force: f64, velocity: f64) -> f64 {
        force * velocity
    }
}