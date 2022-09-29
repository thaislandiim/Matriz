numero = [[None, None], [None, None]]

numero[0][0] = int(input("Insira um valor: "))

for l in range(0, 2):
  for c in range(0, 2):
    numero[l][c] = numero[0][0]
    print(f"{numero[l][c]}")