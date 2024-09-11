package actuarialcalculators

import (
	"errors"
	"math"
)

// ArithmeticLibrary provides various number theory functions.
type ArithmeticLibrary struct{}

// Mobius calculates the Mobius function for a given number.
func (ArithmeticLibrary) Mobius(number int) int {
	if number == 1 {
		return 1
	}

	primeFactorCount := 0

	for i := 2; i <= number; i++ {
		if number%i == 0 {
			number /= i
			primeFactorCount++

			if number%i == 0 {
				return 0
			}
		}
	}
	if primeFactorCount%2 == 0 {
		return 1
	}
	return -1
}

// Sigma calculates the sum of the divisors of a given number.
func (ArithmeticLibrary) Sigma(number int) (int, error) {
	if number < 1 {
		return 0, errors.New("number must be a positive integer")
	}

	sum := 0
	for i := 1; i <= number; i++ {
		if number%i == 0 {
			sum += i
		}
	}

	return sum, nil
}

// Totient calculates the Euler's Totient function for a given number.
func (ArithmeticLibrary) Totient(number int) (int, error) {
	if number < 1 {
		return 0, errors.New("number must be a positive integer")
	}

	result := number
	for i := 2; i*i <= number; i++ {
		if number%i == 0 {
			for number%i == 0 {
				number /= i
			}
			result -= result / i
		}
	}

	if number > 1 {
		result -= result / number
	}

	return result, nil
}

// PrimeCounting counts the number of prime numbers less than or equal to a given number.
func (ArithmeticLibrary) PrimeCounting(number int) int {
	if number < 2 {
		return 0
	}

	isPrime := make([]bool, number+1)
	for i := 2; i <= number; i++ {
		isPrime[i] = true
	}

	for i := 2; i*i <= number; i++ {
		if isPrime[i] {
			for j := i * i; j <= number; j += i {
				isPrime[j] = false
			}
		}
	}

	primeCount := 0
	for i := 2; i <= number; i++ {
		if isPrime[i] {
			primeCount++
		}
	}

	return primeCount
}

// Partition calculates the number of partitions of a given number.
func (ArithmeticLibrary) Partition(number int) (int, error) {
	if number < 0 {
		return 0, errors.New("number must be a non-negative integer")
	}

	partitions := make([]int, number+1)
	partitions[0] = 1

	for i := 1; i <= number; i++ {
		for j := i; j <= number; j++ {
			partitions[j] += partitions[j-i]
		}
	}

	return partitions[number], nil
}

// Omega calculates the number of prime factors of a given number.
func (ArithmeticLibrary) Omega(number int) int {
	if number < 2 {
		return 0
	}

	totalPrimeFactors := 0
	for i := 2; i*i <= number; i++ {
		for number%i == 0 {
			totalPrimeFactors++
			number /= i
		}
	}

	if number > 1 {
		totalPrimeFactors++
	}

	return totalPrimeFactors
}

// ChebyshevTheta calculates the Chebyshev theta function for a given number.
func (ArithmeticLibrary) ChebyshevTheta(number int) float64 {
	if number < 2 {
		return 0
	}

	sum := 0.0
	for i := 2; i <= number; i++ {
		if isPrime(i) {
			sum += math.Log(float64(i))
		}
	}

	return sum
}

// ChebyshevPsi calculates the Chebyshev psi function for a given number.
func (ArithmeticLibrary) ChebyshevPsi(number int) float64 {
	if number < 2 {
		return 0
	}

	sum := 0.0
	for i := 2; i <= number; i++ {
		if isPrime(i) {
			power := i
			for power <= number {
				sum += math.Log(float64(i))
				power *= i
			}
		}
	}

	return sum
}

// Liouville calculates the Liouville function for a given number.
func (ArithmeticLibrary) Liouville(number int) (int, error) {
	if number < 1 {
		return 0, errors.New("number must be a positive integer")
	}

	omega := ArithmeticLibrary{}.Omega(number)
	if omega%2 == 0 {
		return 1, nil
	}
	return -1, nil
}

func isPrime(number int) bool {
	if number < 2 {
		return false
	}

	for i := 2; i*i <= number; i++ {
		if number%i == 0 {
			return false
		}
	}

	return true
}
