package main

import (
	"fmt"
)

func calculateBMI(weightKg float64, heightM float64) float64 {
	return weightKg / (heightM * heightM)
}

func main() {
	weightKg := 70.0 
	heightM := 1.75 

	bmi := calculateBMI(weightKg, heightM)
	fmt.Printf("O teu IMC e de: %.2f\n", bmi)
}
