package engineering

// Kinematics contains methods for calculating various kinematic properties.
type Kinematics struct{}

// Velocity calculates the velocity given a displacement and time.
func Velocity(displacement, time float64) float64 {
	return displacement / time
}

// Acceleration calculates the acceleration given a velocity and time.
func Acceleration(velocity, time float64) float64 {
	return velocity / time
}

// Jerk calculates the jerk given an acceleration and time.
func Jerk(acceleration, time float64) float64 {
	return acceleration / time
}

// Jounce calculates the jounce given a jerk and time.
func Jounce(jerk, time float64) float64 {
	return jerk / time
}

// AngularAcceleration calculates the angular acceleration given an angular velocity and time.
func AngularAcceleration(angularVelocity, time float64) float64 {
	return angularVelocity / time
}

// AngularJerk calculates the angular jerk given an angular acceleration and time.
func AngularJerk(angularAcceleration, time float64) float64 {
	return angularAcceleration / time
}
