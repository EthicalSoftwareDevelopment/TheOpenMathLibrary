package engineering

func LinearUndampedUnforcedOscillator(angularFrequency float64) float64 {
	var linearUndampedUnforcedOscillator float64 = 0
	linearUndampedUnforcedOscillator = angularFrequency
	return linearUndampedUnforcedOscillator
}

func LinearUnforcedDHO(angularFrequency float64, dampingCoefficient float64) float64 {
	var linearUnforcedDHO float64 = 0
	linearUnforcedDHO = angularFrequency * Math.Sqrt(1-(dampingCoefficient*dampingCoefficient))
	return linearUnforcedDHO
}

func LowAmplitudeAngularSHO(angularFrequency float64, amplitude float64) float64 {
	var lowAmplitudeAngularSHO float64 = 0
	lowAmplitudeAngularSHO = angularFrequency * amplitude
	return lowAmplitudeAngularSHO
}

func LowAmplitudeSimplePendulum(angularFrequency float64, amplitude float64) float64 {
	var lowAmplitudeSimplePendulum float64 = 0
	lowAmplitudeSimplePendulum = angularFrequency * amplitude
	return lowAmplitudeSimplePendulum
}
