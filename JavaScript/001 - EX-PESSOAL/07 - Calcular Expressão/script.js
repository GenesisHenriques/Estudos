function enviar(){
    let A = document.getElementById('A').value;
    let B = document.getElementById('B').value;
    let C = document.getElementById('C').value;
    let res = document.getElementById('res')

    if (A <= 0)
    {
        window.alert ("O valor de A é negativo, convertendo para positivo")
        A = parseInt(A) * -1;
    } if (B <= 0) {
        window.alert ("O valor de B é negativo, convertendo para positivo")
        B = parseInt(B) * -1;
    } if (C <= 0) {
        window.alert ("O valor de C é negativo, convertendo para positivo")
        C = parseInt(C) * -1;
    }

    let R = (parseInt(A) + parseInt(B)) * 2;
    let S = (parseInt(B) + parseInt(A)) * parseInt(A);

    let D = (R + S) / 4;

    res.innerHTML = `Resposta...${D}`
}