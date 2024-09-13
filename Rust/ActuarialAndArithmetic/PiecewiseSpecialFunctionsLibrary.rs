pub struct PiecewiseSpecialFunctionsLibrary;

impl PiecewiseSpecialFunctionsLibrary {
    pub fn indicator_function(x: f64) -> f64 {
        if x == 0.0 {
            1.0
        } else {
            0.0
        }
    }

    pub fn step_function(x: f64) -> f64 {
        if x < 0.0 {
            0.0
        } else if x == 0.0 {
            0.5
        } else {
            1.0
        }
    }

    pub fn heaviside_step_function(x: f64) -> f64 {
        if x < 0.0 {
            0.0
        } else {
            1.0
        }
    }

    pub fn rectangular_function(x: f64) -> f64 {
        if x < -0.5 || x > 0.5 {
            0.0
        } else if x == -0.5 || x == 0.5 {
            0.5
        } else {
            1.0
        }
    }

    pub fn sawtooth_function(x: f64) -> f64 {
        x - x.floor()
    }

    pub fn triangle_wave_function(x: f64) -> f64 {
        2.0 * (Self::sawtooth_function(x) - 0.5).abs()
    }

    pub fn square_wave_function(x: f64) -> f64 {
        Self::indicator_function(Self::sawtooth_function(x) - 0.5)
    }

    pub fn sinc_function(x: f64) -> f64 {
        if x == 0.0 {
            1.0
        } else {
            x.sin() / x
        }
    }

    pub fn dirichlet_kernel(x: f64, n: i32) -> f64 {
        ((n as f64 + 0.5) * x).sin() / (n as f64 * (0.5 * x).sin())
    }
}