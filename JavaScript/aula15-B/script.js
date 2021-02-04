function enviar (){
    var nome = document.querySelector('input#nome').Value;
    var resUm = document.querySelector('div#resUm')
    var res = document.querySelector('div#res')
    resUm.innerHTML = `Obrigado, ${nome}.`
    res.innerHTML = `Obrigado, ${nome}`
}

