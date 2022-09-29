const numero = [];

for(let l=0; l<5; l++){
  for(let c=0; c<2; c++){
      const input = prompt("Insira um número: ")
    if (numero[l]) {
      numero[l].push(input)
    } 
    else {
    numero.push([ input ])
    }
  }
} 
  console.log("O primeiro número é: " + numero[0][0] + " e o último número é: " + numero[4][1]);