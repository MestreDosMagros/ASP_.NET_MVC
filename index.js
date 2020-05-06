document.write("usando arquivo separado");

const botao = document.getElementById("click");
const botao2 = document.getElementById("click2");

let listener = function(evt){
    console.log('abc')
} 

let listener2 = function(evt){
    botao.removeEventListener('click', listener);
}

botao.addEventListener("click", listener);
botao2.addEventListener("click", listener2);


