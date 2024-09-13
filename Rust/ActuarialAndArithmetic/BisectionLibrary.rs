pub struct BisectionLibrary;

impl BisectionLibrary {
    pub fn bisection<F>(mut value_a: f64, mut value_b: f64, tolerance: f64, max_iterations: usize, math_function: F) -> Result<f64, &'static str>
    where
        F: Fn(f64) -> f64,
    {
        let mut function_a = math_function(value_a);
        let mut function_b = math_function(value_b);
        if function_a * function_b > 0.0 {
            return Err("function(a) and function(b) must have opposite signs");
        }
        let mut c = 0.0;
        for _ in 0..max_iterations {
            c = (value_a + value_b) / 2.0;
            let function_c = math_function(c);
            if function_c.abs() < tolerance {
                break;
            }
            if function_a * function_c < 0.0 {
                value_b = c;
                function_b = function_c;
            } else {
                value_a = c;
                function_a = function_c;
            }
        }
        Ok(c)
    }

    pub fn newton_raphson<F, G>(mut x: f64, tolerance: f64, max_iterations: usize, math_function: F, math_function_derivative: G) -> f64
    where
        F: Fn(f64) -> f64,
        G: Fn(f64) -> f64,
    {
        for _ in 0..max_iterations {
            let function_x = math_function(x);
            let derivative_x = math_function_derivative(x);
            let x1 = x - function_x / derivative_x;
            if (x1 - x).abs() < tolerance {
                break;
            }
            x = x1;
        }
        x
    }

    pub fn binomial<F>(mut value_a: f64, mut value_b: f64, tolerance: f64, max_iterations: usize, math_function: F) -> Result<f64, &'static str>
    where
        F: Fn(f64) -> f64,
    {
        let mut function_a = math_function(value_a);
        let mut function_b = math_function(value_b);
        if function_a * function_b > 0.0 {
            return Err("function(a) and function(b) must have opposite signs");
        }
        let mut c = 0.0;
        for _ in 0..max_iterations {
            c = (value_a + value_b) / 2.0;
            let function_c = math_function(c);
            if function_c.abs() < tolerance {
                break;
            }
            if function_a * function_c < 0.0 {
                value_b = c;
                function_b = function_c;
            } else {
                value_a = c;
                function_a = function_c;
            }
        }
        Ok(c)
    }
}