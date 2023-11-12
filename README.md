# MultipleOfEleven
## Método Authentication

```http
POST /api/Authentication/login
```
Payload
```json
{
  "username": "admin",
  "password": "admin"
}
```
Response
```json
{
  "token": "iyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYmYiOjE2OTk4MjAzODUsImV4cCI6MTY5OTgyMzk4NSwiaWF0IjoxNjk5ODIwMzg1fQ.rseRQerus0wcS77ztrxfM3KLd6d7O7yADQFhbHznkVc"
}
```
Este token deve ser passado no cabeçalho das outras chamadas, caso contrário, resultará em um erro de autorização. 
Exemplo de utilização no Cabeçalho:
```http
Authorization: Bearer iyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyNuYmYiOjE2OTk4MjAzODUsImV4cCI6MTY5OTgyMzk4NSwiaWF0IjoxNjk5ODIwMzg1fQ.rseRQerus0wcS77ztrxfM3KLd6d7O7yADQFhbHznkVc
```

## Método Multiple
```http
POST /api/Multiple
```
Payload
```json
{
  "numbers": [
    "112233",
    "30800",
    "2937",
    "323455693",
    "5038297",
    "112234"
  ]
}
```

Response
```json
{
  "result": [
    {
      "number": "112233",
      "isMultiple": true
    },
    {
      "number": "30800",
      "isMultiple": true
    },
    {
      "number": "2937",
      "isMultiple": true
    },
    {
      "number": "323455693",
      "isMultiple": true
    },
    {
      "number": "5038297",
      "isMultiple": true
    },
    {
      "number": "112234",
      "isMultiple": false
    }
  ]
}
```
Esse método deve validar cada numero passado no array de string e retornar se é multiplo de 11 ou não
