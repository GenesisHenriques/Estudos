function trocar(){
    let n1 = document.getElementById('n1').value;
    let n2 = document.getElementById('n2').value;
    let res = document.getElementById('res');

    let apoio = 0;

    apoio = n1;
    n1 = n2;
    n2 = apoio;

    res.innerHTML = `${n1}, ${n2}.`;
}