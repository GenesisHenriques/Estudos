function adicionar(){
    let num = document.querySelector('input#num').value;
    let res = document.getElementById('res');

    if (num == 0){
        res.innerHTML = 'Digite um valor válido'
    } else{
        let total = parseInt(num) + 20;
        res.innerHTML = `A soma de ${num} + 20 é: ${total}`
    }
}