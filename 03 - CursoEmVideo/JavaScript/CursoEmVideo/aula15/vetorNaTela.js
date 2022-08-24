let valores = [0,1,7,4,2,9]

/*
for (var i = 0; i < valores.length; i++){
    console.log(`A posição ${i} tem o valore ${valores[i]}`)
}
console.log('')
console.log('Agora em ordem crescente')
console.log('')
valores.sort()
for (var i = 0; i < valores.length; i++){
    console.log(`A posição ${i} tem o valore ${valores[i]}`)
}
*/
for (let i in valores)
{
    console.log(`A posição ${i} tem o valore ${valores[i]}`)
}