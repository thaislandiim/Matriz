const numero = [];

const input = Number(prompt("Insira um número: "));
numero.push([ input ])


for(let linha=0; linha<2; linha++){
  for(let coluna=0; coluna<2; coluna++){    
    if(numero[linha]) {
        numero[linha].push(numero[0][0])
      } else {
        numero.push([ numero[0][0] ])
      } 
  }
}

  for(let l = 0; l < 2; l++){
    for(let c = 0; c < 2; c++){ 
      console.log(numero[l][c]);
    }
  }