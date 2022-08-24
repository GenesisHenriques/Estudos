function transformIntArray(numString) {
  const newArray = []
  for (var index = 0; index < numString.length; index += 1) {
    newArray.push(parseInt(numString[index]))
  }
  return newArray
}

function validateDigits(num, maxDigit) {
  for (let index = 0; index < num.length; index++) {
    if (num[index] > maxDigit) return true
  }
}

function getNumberSum21(smallestNumber, maxDigit) {
  const arrayNumbersSeparate  = smallestNumber.toString().split("")
  const intArray = transformIntArray(arrayNumbersSeparate)

  if (validateDigits(intArray, maxDigit)) {
    return false
  }

  const summedNumbers = (accumulator, curr) => accumulator + curr;

  if (intArray.reduce(summedNumbers) == 21) {
    return true
  } else {
    return false
  }
}

function getNumbersEqualTo21(maxDigit) {
  const result = []
  higherNumber = maxDigit.toString().repeat(4);
  let smallestNumber = 1299

  for (smallestNumber; smallestNumber <= higherNumber; smallestNumber++) {
    if (getNumberSum21(smallestNumber, maxDigit)) {
      result.push(smallestNumber)
    }
  }

  return result
}

function main() {
  maxDigit = 5;
  if (maxDigit < 6) return console.log(null)
  const numbersEqualTo21 = getNumbersEqualTo21(maxDigit);
  for (let index = 0; index < numbersEqualTo21.length; index += 1) {
    console.log(numbersEqualTo21[index])
  }
}

main();