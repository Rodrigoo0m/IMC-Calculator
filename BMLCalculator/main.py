def calculate_bmi(weight_kg, height_m):
    return round(weight_kg / (height_m ** 2), 2)

weight_kg = 70  
height_m = 1.75  

bmi = calculate_bmi(weight_kg, height_m)
print("O teu IMC e de:", bmi)
