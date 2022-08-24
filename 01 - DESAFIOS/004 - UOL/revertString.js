function revertString(string) {
  const arrayString = string.split('')
  const newArrayString = []

  for (var index = arrayString.length - 1; index >= 0; index--) {
    newArrayString.push(arrayString[index])
  }
  return newArrayString.join("")
}

console.log(revertString('genesis'))