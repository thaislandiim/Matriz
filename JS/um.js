const numero = [];

  for(let l = 0; l < 3; l++){
    const input = prompt("Insira um número: ")
    //confere a linha se já tem um array
    if (numero[l]) {
      numero[l].push(input)
      //se nao tem um array ele cria para add um numero no final
      //push: tem a função de add um numero no final
    } else {
      numero.push([ input ])
    }
  }

  for(let l = 0; l < 3; l++){
    for(let c = 0; c < 3; c++){ 
      console.log(numero[l][c]);
    }
  }