function enviar(){
    let n1 = document.getElementById('n1').value;
    let n2 = document.getElementById('n2').value;
    let n3 = document.getElementById('n3').value;
    let res = document.querySelector('div#res');

    let media = (parseInt(n1) + parseInt(n2) + parseInt(n3)) / 3; 

    res.innerHTML = `A media do aluno foi ${media}`
}
