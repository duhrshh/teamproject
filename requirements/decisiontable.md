# Decision Table

| Conditions                     |     |     |     |
| ------------------------------ | --- | --- | --- |
| Is Admin                       | T   | F   |     |
| Cart Empty                     |     | T   | F   |
| **Actions**                    |     |     |     |
| Promote                        | T   | F   |     |
| Add to Cart                    |     | T   | F   |
| Checkout                       |     | F   | T   |
| Show/Remove Cart               |     | T   | T   |
| Inventory & Receipt Management | T   | F   |     |

---
#### Logic Overview:
- A user or admin must be logged in to perform any actions listed in the table.
- **Login is a prerequisite** for:
	- Promoting users (admin only)
	- Adding to cart
	- Viewing or removing from the cart
	- Performing checkout
	- Accessing admin inventory functions
- If a user is **not logged in**, all actions in the table are considered **not allowed**, even if other conditions are true.
- The table assumes the user is already authenticated; if not, their row would be functionally equivalent to a "denied access" scenario across all actions.
