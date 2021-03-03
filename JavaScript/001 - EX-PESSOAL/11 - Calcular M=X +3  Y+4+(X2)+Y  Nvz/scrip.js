function calcular(){
    let X = document.getElementById("X").value;
    let Y = document.getElementById("Y").value;
    let res = document.getElementById('res')

    let M = parseInt(X) + 3 * parseInt(Y) + 4 + (parseInt(X) / 2) + parseInt(Y)

    res.innerHTML = `Resposta...${M}`
}