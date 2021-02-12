function enviar(){
    let n1 = document.getElementById('n1').value;
    let n2 = document.getElementById('n2').value;
    let n3 = document.getElementById('n3').value;
    let n4 = document.getElementById('n4').value;
    let res = document.querySelector('div#res')

    let soma = parseInt(n1) + parseInt(n2) + parseInt(n3) + parseInt(n4);

    if (soma < 0){
        soma = soma * -1;
    }
    res.innerHTML = `O valor absoluto dos numeros digitados é: ${soma}!`
}