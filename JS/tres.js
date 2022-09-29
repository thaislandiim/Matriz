let numero = []

for(let linha = 0; linha < 2; linha++){
  for(let coluna = 0; coluna < 3; coluna++){ 
    if(linha == 0 && coluna == 0){
      numero[linha, coluna] = Number(prompt("Insira um número: "))
    } else {
      if(coluna == 0) {
        numero[linha, coluna] = numero[linha - 1, 2] * 2
      } else {
        numero[linha, coluna] = numero[linha, coluna - 1] * 2
      }
    }
    console.log(linha)
    console.log(coluna)
    console.log(numero[linha, coluna]);
    //console.log(numero[linha, coluna - 1]) 
  }
}

for(let linha = 0; linha < 2; linha++){
  for(let coluna = 0; coluna < 3; coluna++){ 
   console.log(numero[linha, coluna])
  }
}