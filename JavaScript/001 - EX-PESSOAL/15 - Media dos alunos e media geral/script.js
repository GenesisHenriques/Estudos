let medias = 0; let cont = 0;
let res = document.querySelector('div#res');
let lista = document.querySelector('select#lista');

function calcular(){
    let media = 0;
    let nome = document.getElementById('nome').value;
    let n1 = document.querySelector("input#n1").value;
    let n2 = document.querySelector("input#n2").value;
    let n3 = document.querySelector("input#n3").value;

    media = (parseInt(n1) + parseInt(n2) + parseInt(n3)) / 3;
    medias += media;
    cont++;

    let item = document.createElement('option');
    item.text = `${nome} - media ${media}`;
    lista.appendChild(item);
}

function finalizar(){
    res.innerHTML = `Media total...${medias / cont}`;
}