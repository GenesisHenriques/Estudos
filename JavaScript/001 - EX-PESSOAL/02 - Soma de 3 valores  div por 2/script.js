function enviar(){
    let n1 = document.querySelector('input#n1').value;
    let n2 = document.querySelector('input#n2').value;
    let n3 = document.querySelector('input#n3').value;
    let res = document.querySelector('div#res');

    let resultado = (parseInt(n1) + parseInt(n2) + parseInt(n3)) / 2;

    res.innerHTML += `a soma foi ${parseInt(n1) + parseInt(n2) + parseInt(n3)}, que dividido por 2 fica: ${resultado}!`
}