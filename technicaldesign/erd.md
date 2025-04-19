##  Entity Relationship Design

Your system includes three entities:

- `User`
- `Order`
- `InventoryItem`

These support user authentication, admin functionality, vinyl inventory management, and order checkout flow.

---

### 1.  Entity Relationship Diagram (Crow’s Foot Notation – Mermaid)

```mermaid
erDiagram
    User ||--o{ Order : places
    Order ||--|{ InventoryItem : contains

    User {
        int UserId PK "identity"
        string Username "nvarchar(50)"
        string PasswordHash "nvarchar(255)"
        string Email "nvarchar(100)"
        bool IsAdmin
    }

    Order {
        int OrderId PK "identity"
        int UserId FK
        string ShippingAddress "nvarchar(255)"
        string Phone "nvarchar(15)"
        string CreditCardLast4 "char(4)"
        string ShippingSpeed "nvarchar(15)"
        decimal Subtotal "decimal(10,2)"
        decimal Tax "decimal(10,2)"
        decimal ShippingCost "decimal(10,2)"
        decimal Total "decimal(10,2)"
        datetime OrderDate
    }

    InventoryItem {
        int ItemId PK "identity"
        int OrderId FK nullable
        string Name "nvarchar(100)"
        string Description "nvarchar(255)"
        decimal Price "decimal(10,2)"
        string ImageUrl "nvarchar(255)"
        bool IsSold
    }
