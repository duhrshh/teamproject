```mermaid
 erDiagram
     User ||--o{ Order : places
     Order ||--|{ InventoryItem : contains
 
     User {
         int UserId PK
         string Username
         string PasswordHash
         string Email
         bool IsAdmin
     }
 
     Order {
         int OrderId PK
         int UserId FK
         string ShippingAddress
         string Phone
         string CreditCardLast4
         string ShippingSpeed
         decimal Subtotal
         decimal Tax
         decimal ShippingCost
         decimal Total
         DateTime OrderDate
     }
 
     InventoryItem {
         int ItemId PK
         int OrderId FK
         string Name
         string Description
         decimal Price
         string ImageUrl
         bool IsSold
     }
}
