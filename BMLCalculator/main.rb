def calculate_bmi(weight_kg, height_m)
    return (weight_kg / (height_m ** 2)).round(2)
  end
  
  weight_kg = 70  
  height_m = 1.75
  
  bmi = calculate_bmi(weight_kg, height_m)
  puts "O teu imc e: #{bmi}"
  