# Team 8 - The Classics



Welcome to our team repository, created for our class project for SWE 3313. All possible documentation will be added here as the project is developed and will ultimately lead to a finished product ready for use.

As for the project itself, the ***Classics*** team is creating an online storefront to sell vintage vinyls of various musical genres with the use of C# and ASP.NET Core Blazor. Walk with us as we learn about the intricacies of developing and managing solutions for our clients.

---

## Team Selection

The project started with compiling a group of aspiring engineers that shared the same passion for music:

- [Darsh Patel](/resumes/darsh.md)
- [Chris Pham](/resumes/chris.md)
- [Josiah Regis](/resumes/josiah.md)

---

## Project Plan

Once we gathered, certain discussions were started in order to create an effective plan that would result in a proper product.

#### Team Assignments

- In order to maximize efficiency throughout the project, we assigned certain roles to each contributor:
  - [Project Manager](/projectplan/projectmanager.md) (Darsh)
  - [Front-End Developer](/projectplan/frontend.md) (Chris)
  - [Back-End Developer](/projectplan/backend.md) (Josiah)

#### Technology Selection

- In order to familiarize ourselves with industry-standard tools, we chose to code the project using C# through an ASP.NET Blazor server. To store our data, we utilized an SQLite database. Microsoft Teams was also used to ensure effective communication throughout the length of the project.
- Click [here](/projectplan/technologyselection.md) for a detailed explanation of what technologies and tools we are using and why.

#### Gantt Chart

- Click [here](/projectplan/ganttchart.png) to view our Project Plan in Gantt Chart form via. YouTrack.

#### Presentation
- Click [here](https://www.loom.com/share/61d8d45837cb4d569c5de5bd90054811) to view our Project Plan presentation in Loom.

---

## Requirements

After a lengthy conversation with our customer, we were able to capture their required functionalities, features, and processes necessary for the project to be deemed successful. The requirements that were elicited from the aforementioned conversation are detailed [here](/requirements/requirementswritten.md).

In summary, ... (WIP)
#### Use Case Diagram
- Click [here]() for a detailed Use-Case Diagram for our project.

#### Decision Table
- Click [here]() for a detailed view of our Decision Table for all processes in Version 1.

#### Presentation
- Click [here]() to view our Requirements presentation in Loom.
## List of Must-Have Features: (TEMP)
- Self-Register - users must be able to create their own account
- Login - all users must be able to login properly and [login] must work
- Admin User Type - can login and run sales reports - admins cannot self register and must be manually assigned.
- Unique usernames and 6-character (minimum password) must be standard for **ALL** users.
- Only current admins can assign someone who is pre-registered as admin.
- "main" screen: All users can see a list of **available** inventory sorted from highest price to lowest price - sold items (Quantity < 1) will not be displayed (DESCENDING ORDER SORT BY PRICE)
- Inventory will have a short name, picture, price, and brief description.
- Shopping Cart: a button in inventory where item can be added to shopping cart; can hold more than one items for all users.
- Search the inventory by typing a search box --> can query through the inventory via words match on item name or description.
- Item Attributes: (FOR DB Design)
	- Name: String
	- Picture: IMG/JPEG file
	- Price: Decimal/Currency ($)
	- Description: Long String
- Items must be displayed with a $ sign in front and commas and decimal points accordingly --> format the Decimal values like so before outputting (convert to strings and format like above before showing)
	- Ensure price is stored in a decimal/currency format which is base 10 and NOT floating point.
- Checkout button to start payment process...
- Payment Process:
	1. User cannot click Checkout if shopping cart is empty --> check before letting Checkout screen be seen.
	2. Checkout screen where all items in shopping cart are shown (can also be it's own process that can be accessed regardless of checkout button); from this view, items can be removed from the shopping cart. If everything in the cart is removed, then the user is taken back to "main" screen (since there is nothing in the shopping cart - I'm guessing it must check if something is in the shopping cart when "Checkout" is clicked as well as whenever any item is removed)
	3. From Shopping Cart/Checkout screen, a button called "Pay Now" can start actual payment process, or click another button to return to shopping.
	4. Payment/Pay now screen: user **must** enter shipping address, credit card number, phone number, and shipping speed. ALL fields are required.
		- For credit card field, expiration month and year, as well as CVV security code is required.
	5. Shipping speed options (3 choices - sorted descending order from fastest to slowest):
		1. Overnight $29
		2. 3-day: $19
		3. Ground: $0, free
	6. Once ALL fields are completed, a button called confirm order can be clicked to take you to said page...
	7. Confirm page: show a list of all items that are being bought (name and price only this time), the subtotal, tax (6% of the subtotal or subtotal * 0.06), shipping speed cost, and grand total (add subtotal + (subtotal * 0.06) + shipping_speed_cost). A button called "Complete Order" will be there that will do the following.
	8. Complete Order action: take items that are bought out of inventory/change quantity of said items in inventory to 0 (since they are all 1 of each), and will take the user to the receipt page.
	9. Receipt page: will look similar to the Confirm Order page, but will also include last four digits of the user's credit card number and their shipping address.
	10. Receipts will also automatically be emailed to the user; the view that is shown in receipt screen will be the **SAME EXACT** one emailed to the end user (*SendGrid* account can be made if we decide to send actual emails)
	11. OK button in the receipt screen to exit the screen. Once order is confirmed, the cart should be empty and therefore shopping card or payment screen cannot be accessed.
	12. Once user returns to main page, the items that were just bought must be removed from the inventory hence they cannot see it by then in either the list or via search (query in inventory table). In addition, all bought items must be visible in the sales report.

- As for Administrator users:
	1. Administrators can run a sales report that shows everything purchased and who purchased it.
	2. The aforementioned sales report can be exported into CSV file (comma-separated values).
	3. Administrators can add items to the inventory, and for initial release, it can be manual addition to the database rather than using UI to add the information --> A screen that shows the inventory database where values can be added manually (all enforced restrictions in the datatypes within database must be maintained or else they cannot be added).

- High-fidelity mockup (or prototype that is extremely close to what final product will look like) for the screens and application flow before the actual coding can begin. 
## List of Good-To-Have Features: (TEMP - CAN BE AFTER Version 1 hence is outside the scope of the project)
- A user interface to do all of the following..
- Items can have more than one picture
- Administrators will be able to click on a sold item and it will show the receipt related to the respective item (can be done by finding the uniqueID for item in the orders tab)
- Administrators can add values using a UI of some sorts rather than manually entering all fields into the database directly. Will check following to make sure database rules are followed and then will automatically added them to the database:
	- Checks if the name and description follows proper formatting.
	- Checks if Price value is a proper decimal that is non-floating point.
	- Takes a picture in (which can be dragged into the website or selected from the computer), and converts it into a predetermined file (either PNG or JPEG), changes the ending to maintain the same datatype as the rest of the items, and then adds it to the inventory.
- ***(SELF MADE)*** For payment screen, check to make sure credit card field is not expired: 
	- Check if the expiration date is past the current date.
- ***(SELF MADE)*** Receipt page will also include their unique (ID within receipt/orders table) order number, as well as a tracking number and estimated arrival date (according to the shipping speed selected, can be estimated by adding that many days to the date of order). 
- ***(SELF MADE)*** From the main view, a box called ORDERS can be available for users which will show all orders associated with the user. (via searching orders table using the userID to find unique orderID for each order)
-  ***(SELF MADE)*** For administrators, instead of the sales report showing all sales to date, it can show it according to certain parameters that can be selected/controlled, such as a certain day, the sales of a specific user, etc --> can be done by some SQL queries in Orders table.
