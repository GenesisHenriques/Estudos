function somar(){
    let n1 = document.getElementById('numUm').value;
    let n2 = document.getElementById('numDois').value;
    let n3 = document.getElementById('numTres').value;
    let res = document.getElementById('res');

    let soma = parseInt(n1) + parseInt(n1) + parseInt(n1);

    res.innerHTML = `A soma de ${n1} + ${n2} + ${n3} é: ${soma}!`
}

            


            