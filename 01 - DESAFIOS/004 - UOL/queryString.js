const URL = "https://www.uol.com.br?company=uol&page=home"
const param = "company"

function queryString(URL, param) {
  const arrayParams = URL.split("?")[1].split("&")
  const objParams = {}

  for (let param in arrayParams) {
    arrayParam = arrayParams[param].split("=")
    objParams[arrayParam[0]] = arrayParam[1]
  }
  if (objParams['aaaa'] === undefined) return none
  return objParams['aaaaa']
}

console.log(queryString(URL, param))