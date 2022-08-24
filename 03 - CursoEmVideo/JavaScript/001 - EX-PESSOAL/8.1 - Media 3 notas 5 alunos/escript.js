let lista = document.querySelector('select#lista');
let res = document.getElementById('res');
let alunos  = [];
let nota1 = [];
let nota2 = [];
let nota3 = [];
let medias = []; 
let media;

function enviar(){
    res.innerHTML = `    `
    let nome = document.querySelector('input#nome').value;
    let n1 = document.getElementById('n1').value;
    let n2 = document.getElementById('n2').value;
    let n3 = document.getElementById('n3').value;

    if (nome == "" || n1 == 0 || n2 == 0 || n3 == 0){
        window.alert(`Complete todos os dados`)
    } else {
        alunos.push(nome)
        nota1.push(Number(n1)) 
        nota2.push(Number(n2))
        nota3.push(Number(n3))

        media = (parseInt(n1) + parseInt(n2) + parseInt(n3)) / 3

        let item = document.createElement('option');
        item.text = `${nome}: ${n1}----${n2}----${n3}`
        lista.appendChild(item)

        res.innerHTML = `Media de ${nome}: ${media}`
        medias.push(Number(media));
    }
}
function finalizar(){
    res.innerHTML = ``
    for (let i = 0; i < alunos.length; i ++){
        res.innerHTML += `${alunos[i]} media ${medias[i]}///`;
    }
}
 


