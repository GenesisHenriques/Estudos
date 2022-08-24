function calcular(){
    let M = document.querySelector('input#M').value;
    let R = document.querySelector('input#R').value;
    let res = document.getElementById('res');
    let X = parseInt(M) + 3 + parseInt(R)
    res.innerHTML = `${M} + 3 + ${R} = ${X}`
    
}   