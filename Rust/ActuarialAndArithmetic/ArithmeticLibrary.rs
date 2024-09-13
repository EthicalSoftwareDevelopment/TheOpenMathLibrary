use std::f64;

pub struct ArithmeticLibrary;

impl ArithmeticLibrary {
    pub fn mobius(mut number: i32) -> i32 {
        if number == 1 {
            return 1;
        }

        let mut prime_factor_count = 0;

        for i in 2..=number {
            if number % i == 0 {
                number /= i;
                prime_factor_count += 1;

                if number % i == 0 {
                    return 0;
                }
            }
        }
        if prime_factor_count % 2 == 0 { 1 } else { -1 }
    }

    pub fn sigma(number: i32) -> Result<i32, &'static str> {
        if number < 1 {
            return Err("Number must be a positive integer.");
        }

        let mut sum = 0;

        for i in 1..=number {
            if number % i == 0 {
                sum += i;
            }
        }

        Ok(sum)
    }

    pub fn totient(mut number: i32) -> Result<i32, &'static str> {
        if number < 1 {
            return Err("Number must be a positive integer.");
        }

        let mut result = number;

        for i in 2..=((number as f64).sqrt() as i32) {
            if number % i == 0 {
                while number % i == 0 {
                    number /= i;
                }
                result -= result / i;
            }
        }

        if number > 1 {
            result -= result / number;
        }

        Ok(result)
    }

    pub fn prime_counting(number: usize) -> usize {
        if number < 2 {
            return 0;
        }

        let mut is_prime = vec![true; number + 1];
        for i in 2..=number {
            is_prime[i] = true;
        }

        for i in 2..=((number as f64).sqrt() as usize) {
            if is_prime[i] {
                for j in (i * i..=number).step_by(i) {
                    is_prime[j] = false;
                }
            }
        }

        let mut prime_count = 0;
        for i in 2..=number {
            if is_prime[i] {
                prime_count += 1;
            }
        }

        prime_count
    }

    pub fn partition(number: usize) -> Result<usize, &'static str> {
        if number < 0 {
            return Err("Number must be a non-negative integer.");
        }

        let mut partitions = vec![0; number + 1];
        partitions[0] = 1;

        for i in 1..=number {
            for j in i..=number {
                partitions[j] += partitions[j - i];
            }
        }

        Ok(partitions[number])
    }

    pub fn omega(mut number: i32) -> i32 {
        if number < 2 {
            return 0;
        }

        let mut total_prime_factors = 0;

        for i in 2..=((number as f64).sqrt() as i32) {
            while number % i == 0 {
                total_prime_factors += 1;
                number /= i;
            }
        }

        if number > 1 {
            total_prime_factors += 1;
        }

        total_prime_factors
    }

    pub fn chebyshev_theta(number: i32) -> f64 {
        if number < 2 {
            return 0.0;
        }

        let mut sum = 0.0;
        for i in 2..=number {
            if Self::is_prime(i) {
                sum += (i as f64).ln();
            }
        }

        sum
    }

    fn is_prime(number: i32) -> bool {
        if number < 2 {
            return false;
        }

        for i in 2..=((number as f64).sqrt() as i32) {
            if number % i == 0 {
                return false;
            }
        }

        true
    }

    pub fn chebyshev_psi(number: i32) -> f64 {
        if number < 2 {
            return 0.0;
        }

        let mut sum = 0.0;
        for i in 2..=number {
            if Self::is_prime(i) {
                let mut power = i;
                while power <= number {
                    sum += (i as f64).ln();
                    power *= i;
                }
            }
        }

        sum
    }

    pub fn liouville(number: i32) -> Result<i32, &'static str> {
        if number < 1 {
            return Err("Number must be a positive integer.");
        }

        let omega = Self::omega(number);
        if omega % 2 == 0 { Ok(1) } else { Ok(-1) }
    }

    fn is_prime(number: i32) -> bool {
        if number < 2 {
            return false;
        }

        for i in 2..=((number as f64).sqrt() as i32) {
            if number % i == 0 {
                return false;
            }
        }

        true
    }

    fn omega(mut number: i32) -> i32 {
        if number < 2 {
            return 0;
        }

        let mut total_prime_factors = 0;

        for i in 2..=((number as f64).sqrt() as i32) {
            while number % i == 0 {
                total_prime_factors += 1;
                number /= i;
            }
        }

        if number > 1 {
            total_prime_factors += 1;
        }

        total_prime_factors
    }

}