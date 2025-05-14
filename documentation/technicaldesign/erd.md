##  Entity Relationship Design

Your system includes three entities:

- `User`
- `Order`
- `InventoryItem`

These support user authentication, admin functionality, vinyl inventory management, and order checkout flow.

---

### [Entity Relationship Diagram (Crow’s Foot Notation – Mermaid)](/technicaldesign/diagram.md)

- An image of the ERD Diagram can be found [here](picture.png).

##  Table of Field Descriptions (SQL-Oriented)

### User Table

| Field Name    | Data Type       | Required | Key Type      | Description |
|---------------|------------------|----------|---------------|-------------|
| UserId        | int              | Yes      | Primary Key   | Auto-incremented unique ID for each user |
| Username      | nvarchar(50)     | Yes      |               | Unique login name for each user |
| PasswordHash  | nvarchar(255)    | Yes      |               | Securely hashed password |
| Email         | nvarchar(100)    | Yes      |               | Used for account verification and receipts |
| IsAdmin       | bit              | Yes      |               | True if user is an admin, otherwise false |

---

### Order Table

| Field Name        | Data Type         | Required | Key Type      | Description |
|-------------------|-------------------|----------|---------------|-------------|
| OrderId           | int               | Yes      | Primary Key   | Auto-incremented order ID |
| UserId            | int               | Yes      | Foreign Key   | References `User(UserId)` |
| ShippingAddress   | nvarchar(255)     | Yes      |               | Full shipping destination |
| Phone             | nvarchar(15)      | Yes      |               | Contact number in E.164 or US format |
| CreditCardLast4   | char(4)           | Yes      |               | Last 4 digits of payment card |
| ShippingSpeed     | nvarchar(15)      | Yes      |               | Options: “Overnight”, “3-Day”, “Ground” |
| Subtotal          | decimal(10,2)     | Yes      |               | Total price before tax/shipping |
| Tax               | decimal(10,2)     | Yes      |               | 6% of subtotal |
| ShippingCost      | decimal(10,2)     | Yes      |               | Based on shipping option |
| Total             | decimal(10,2)     | Yes      |               | Final charge amount (Subtotal + Tax + Shipping) |
| OrderDate         | datetime          | Yes      |               | Time the order was placed |

---

### InventoryItem Table

| Field Name     | Data Type         | Required | Key Type     | Description |
|----------------|-------------------|----------|--------------|-------------|
| ItemId         | int               | Yes      | Primary Key  | Auto-incremented ID |
| OrderId        | int (nullable)    | No       | Foreign Key  | References `Order(OrderId)` if sold |
| Name           | nvarchar(100)     | Yes      |              | Name of the vinyl record |
| Description    | nvarchar(255)     | Yes      |              | Brief overview of the item |
| Price          | decimal(10,2)     | Yes      |              | One-off price (USD) |
| ImageUrl       | nvarchar(255)     | Yes      |              | Path or link to the album image |
| IsSold         | bit               | Yes      |              | True if the item has been purchased |

---

## Example Data

### User Table

| UserId | Username    | PasswordHash | Email               | IsAdmin |
| ------ | ----------- | ------------ | ------------------- | ------- |
| 1      | admin       | adminTest321 | admin@classics.com  | True    |
| 2      | jdoe        | doejohn1738  | jdoe@email.com      | False   |
| 3      | cratehunter | Yeehaww!     | vinyl@cratehunt.com | False   |

---

### Order Table

| OrderId | UserId | ShippingAddress | Phone        | CreditCardLast4 | ShippingSpeed | Subtotal | Tax  | ShippingCost | Total  | OrderDate           |
| ------- | ------ | --------------- | ------------ | --------------- | ------------- | -------- | ---- | ------------ | ------ | ------------------- |
| 1       | 2      | 123 Main St, NY | +15551234567 | 5678            | Overnight     | 75.00    | 4.50 | 29.00        | 108.50 | 2024-04-18 14:23:00 |
| 2       | 3      | 9 Grove Ave, IL | +15559876543 | 1234            | Ground        | 25.00    | 1.50 | 0.00         | 26.50  | 2024-04-19 10:02:00 |

---

### InventoryItem Table

| ItemId | OrderId | Name                  | Description            | Price | ImageUrl              | IsSold |
| ------ | ------- | --------------------- | ---------------------- | ----- | --------------------- | ------ |
| 1      | 1       | Dark Side of the Moon | 1973 Original Pressing | 75.00 | /images/darkside.jpg  | True   |
| 2      | NULL    | Thriller              | MJ’s bestselling album | 25.00 | /images/thriller.jpg  | False  |
| 3      | NULL    | Nevermind             | Nirvana 1991 Classic   | 30.00 | /images/nevermind.jpg | False  |

---

## Seed Data

These records will exist **when the application is first launched**.

### User Table

| Username | PasswordHash (sample) | Email              | IsAdmin |
| -------- | --------------------- | ------------------ | ------- |
| admin    | adminTest321          | admin@classics.com | True    |

---

### InventoryItem Table

| Name        | Description          | Price | ImageUrl               | IsSold |
| ----------- | -------------------- | ----- | ---------------------- | ------ |
| Abbey Road  | The Beatles – 1969   | 50.00 | /images/abbeyroad.jpg  | False  |
| Rumours     | Fleetwood Mac – 1977 | 35.00 | /images/rumours.jpg    | False  |
| Purple Rain | Prince – 1984        | 40.00 | /images/purplerain.jpg | False  |

---

### Order Table

> No pre-seeded orders. Orders are generated dynamically when users complete checkout.
