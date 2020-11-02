# TestAgileE
This project is an API to make some task as:

## Path Client
 * List of Users
    * GET - /api/Client
  * Add New User
    * POST - /api/Client/agregar and send a data with the following structure
    
    ```javascript
    {
        "id": 1,
        "name": "Daniel",
        "lastName": "Robles"
    }

## Path Transaction
 * List of Transactions
    * GET - /api/Transaction
  * Add New Transaction
    * POST - /api/Transaction/addT and send a data with the following structure
    
    ```javascript
    {
        "idTransaction": 0,
        "type": "Credit",   //Credit or Debit
        "idUser": 0,
        "amount": 1000.0,
        "transactionDate": "2020-11-02T00:00:00-06:00"
    }
```
