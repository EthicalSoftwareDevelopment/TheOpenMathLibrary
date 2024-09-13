pub struct AngularFrequencies;

impl AngularFrequencies {
    pub fn linear_undamped_unforced_oscillator(angular_frequency: f64) -> f64 {
        angular_frequency
    }

    pub fn linear_unforced_dho(angular_frequency: f64, damping_coefficient: f64) -> f64 {
        angular_frequency * (1.0 - damping_coefficient.powi(2)).sqrt()
    }

    pub fn low_amplitude_angular_sho(angular_frequency: f64, amplitude: f64) -> f64 {
        angular_frequency * amplitude
    }

    pub fn low_amplitude_simple_pendulum(angular_frequency: f64, amplitude: f64) -> f64 {
        angular_frequency * amplitude
    }
}