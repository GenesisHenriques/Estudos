let nomes = []; let idades = [];
let lista = document.getElementById('lista');
function adicionar(){
    let nome = document.getElementById('nome').value;
    let idade = document.getElementById('idade').value;
    let res = document.getElementById('res');

    nomes.push(nome); idades.push(idade);

    res.innerHTML = `Adiconado ${nome} de ${idade}`;
}

function mostrar(){
    for(let i = 0; i < nomes.length; i++){
        let item = document.createElement('option');
        item.text = `${nomes[i]} tem ${idades[i]} anos.`
        lista.appendChild(item);
    }
}