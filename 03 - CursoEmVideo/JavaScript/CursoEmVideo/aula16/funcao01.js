let num = 9
let iOp = imparPar(num)

function imparPar(num)
{
    if (num%2==0)
    {
        return 'par'
    } else {
        return 'impar'
    }
}
console.log (`O numero ${num} é ${iOp}`)