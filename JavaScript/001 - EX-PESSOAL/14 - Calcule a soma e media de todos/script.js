let res = document.querySelector('div#res');
let lista = document.querySelector('select#lista');
let numeros = [];
let media;
let total = 0;

function adicionar(){
    let num = document.querySelector('input#num').value;
    numeros.push(parseInt(num))

    let item = document.createElement('option');
    item.text = `Numero ${num}`
    lista.appendChild(item);
}

function calcular(){
    for(let i = 0; i < numeros.length; i++){
        total = total + numeros[i];
    }
    media = total / numeros.length;

    res.innerHTML = `Total ${total}  Media ${media}`
}

