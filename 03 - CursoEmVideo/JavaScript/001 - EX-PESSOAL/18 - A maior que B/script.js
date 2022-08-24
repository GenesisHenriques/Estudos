function comparar(){
    let numA = parseInt(document.querySelector('input#numA').value);
    let numB = parseInt(document.querySelector('input#numB').value);
    let res = document.querySelector('div#res');

    if (numA > numB){
        res.innerHTML = `${numA} é maior que ${numB}`
    } else if (numA < numB) {
        res.innerHTML = `${numA} é menor que ${numB}`
    } else {
        res.innerHTML = `Numeros iguais ou inexistentes`
    }
}
