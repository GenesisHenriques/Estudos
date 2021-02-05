function contar(){
    var txtinicio = document.getElementById('inicio')
    var inicio = Number(txtinicio.value)
    var txtfim = document.getElementById('fim')
    var fim = Number(txtfim.value)
    var txtpasso = document.getElementById('passo')
    var passo = Number(txtpasso.value)
    var res = document.querySelector('div#res')
    res.innerHTML =""

    for (var i = inicio; inicio <= fim; inicio+=passo)
    {
        res.innerHTML += `👉 ${inicio}  `
    }
    res.innerHTML += `❗`
}

