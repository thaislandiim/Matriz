linhas = 3
colunas = 2
numero =  [[None for _ in range(colunas)] for _ in range(linhas)]

for l in range(0, linhas):
  for c in range(0, colunas):
    if l == 0 and c == 0:
      numero[l][c] = int(input("Insira um número: "))
    else:
      if c == 0:
        numero[l][c] = numero[l -1][colunas - 1] * 2
      else:
        numero[l][c] = numero[l][c - 1] * 2

print(numero)