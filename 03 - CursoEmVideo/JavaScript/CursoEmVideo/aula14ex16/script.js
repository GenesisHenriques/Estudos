function contar(){
    let txtinicio = document.getElementById('inicio')
    let inicio = Number(txtinicio.value)
    let txtfim = document.getElementById('fim')
    let fim = Number(txtfim.value)
    let txtpasso = document.getElementById('passo')
    let passo = Number(txtpasso.value)
    let res = document.querySelector('div#res')
    res.innerHTML =""

    if (passo == 0){
        window.alert('Passo inválido, considerando passo = 1')
        passo = 1
    }

    if (inicio < fim){
        for (var i = inicio; inicio <= fim; inicio+=passo)
        {
            if (inicio == 0 || fim == 0 ) {
                res.innerHTML = 'Impossível contar!...'
                break
            }
            res.innerHTML += `\u{1F449} ${inicio}  `
        }
    } else {
        for (var i = inicio; inicio >= fim; inicio-=passo)
        {
            if (inicio == 0 || fim == 0 ) {
                res.innerHTML = 'Impossível contar!...'
                break
            }
            res.innerHTML += `👉 ${inicio}  `
        }
    }
    res.innerHTML += `\u{1F3C1}`
}

