
let topo = document.getElementById('topo');
let base = document.getElementById('base');

let nomes = [];
let idades = [];
let menor = 0;

function adicionar(){
    let nome = document.getElementById('nome').value;
    let idade = document.getElementById('idade').value;
    
    if (idade > 20){
        nomes.push(nome);
        idades.push(idade);
    }  else {
        menor++;
    } 
}
function finalizar(){
    let lista = document.getElementById('lista');
    topo.innerHTML = 'Maiores que vinte anos'

    for (let a = 0; a < idade.length; a++){
        let item = document.createElement('option');
        item.text = `${nomes[a]} de ${idades[a]} anos.`;
        lista.appendChild(item);
    }
    base.innerHTML = `${menor} pessoas tem menos que vinte anos`
}

    //let item = document.createElement('option');
    //item.text = `Numero ${num}`;
   //lista.appendChild(item);