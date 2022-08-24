let lista = document.getElementById('lista');
let res = document.getElementById('res')

let numeros = [];

function adicionar() {
    res.innerHTML = ""
    let num = document.getElementById('num').value;

    numeros.push(parseInt(num))

    let item = document.createElement('option');
    item.text = `Numero ${num}`;
    lista.appendChild(item);
}

function somar(){
    let total = 0;

    for (let i = 0; i < numeros.length; i++){
        total += numeros[i];
    }

    res.innerHTML = `${total}`
}