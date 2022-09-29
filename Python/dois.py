numero = [[None, None], [None, None], [None, None], [None, None], [None, None]]

for l in range(0, 5):
  for c in range(0, 2):
    numero[l][c] = int(input("Insira um número: "))
    
print(f"O 1° número é: {numero[0][0]} e o último número é: {numero[4][1]}")