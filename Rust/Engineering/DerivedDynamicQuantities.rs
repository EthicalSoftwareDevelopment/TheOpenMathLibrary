pub struct DerivedDynamicQuantities;

impl DerivedDynamicQuantities {
    pub fn momentum(mass: f64, velocity: f64) -> f64 {
        mass * velocity
    }

    pub fn force(mass: f64, acceleration: f64) -> f64 {
        mass * acceleration
    }

    pub fn impulse(force: f64, time: f64) -> f64 {
        force * time
    }

    pub fn angular_momentum(mass: f64, velocity: f64, radius: f64) -> f64 {
        mass * velocity * radius
    }

    pub fn torque(force: f64, radius: f64) -> f64 {
        force * radius
    }

    pub fn angular_impulse(torque: f64, time: f64) -> f64 {
        torque * time
    }
}