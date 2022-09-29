numero = [[None, None, None], [None, None, None], [None, None, None]]

for l in range(0,3):
  for c in range(0, 3):
    numero[l][c] = int(input("Insira um valor: "))

for l in range(1):
  for c in range(1):
    print(numero)