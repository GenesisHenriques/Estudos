function enviar(){
    let n = document.querySelector('input#num').value;
    let res = document.querySelector('div#res');

    let quadrado = n ** 2;

    res.innerHTML = `${n} elevado ao quadrado é: ${quadrado}`
}