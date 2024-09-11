package engineering

// Momentum calculates the momentum of an object.
func Momentum(mass, velocity float64) float64 {
	return mass * velocity
}

// Force calculates the force acting on an object.
func Force(mass, acceleration float64) float64 {
	return mass * acceleration
}

// Impulse calculates the impulse given a force and time.
func Impulse(force, time float64) float64 {
	return force * time
}

// AngularMomentum calculates the angular momentum of an object.
func AngularMomentum(mass, velocity, radius float64) float64 {
	return mass * velocity * radius
}

// Torque calculates the torque given a force and radius.
func Torque(force, radius float64) float64 {
	return force * radius
}

// AngularImpulse calculates the angular impulse given a torque and time.
func AngularImpulse(torque, time float64) float64 {
	return torque * time
}
