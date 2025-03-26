# Requirements

- **Version 1**
    
    - **T8E-1: User Account Management**
        
        - **T8S-1**: _Register a new user_
            
            - _Priority_: Must Have
            - _Effort_: 1 day
            - _Type_: Functional
            - The user must be able to self-register by creating an account with a unique username and a password that is at least 6 characters long. Admins cannot self-register.
                
        - **T8S-2**: _Log in as a registered user_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.5 day
                
            - _Type_: Functional
                
            - The user must be able to log in using their registered credentials. Login must validate credentials and direct the user to the main inventory screen upon success.
                
        - **T8S-3**: _Promote a user to admin_
            
            - _Priority_: Must Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - An existing admin must be able to promote a registered user to the admin role. This may be done via manual process or a simple UI depending on implementation feasibility for version 1.
                
    - **T8E-2: Inventory Browsing & Shopping Cart**
        
        - **T8S-4**: _Display inventory sorted by price_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.5 day
                
            - _Type_: Functional
                
            - After logging in, the user must be shown a list of all available inventory sorted from highest to lowest price. Sold items must not be shown in the list.
                
        - **T8S-5**: _Display inventory item details_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.5 day
                
            - _Type_: Functional
                
            - Each inventory item must be displayed with a name, price (formatted with $ sign, commas, and two decimal places), one picture, a short description, and an “Add to Cart” button.
                
        - **T8S-6**: _Add item to shopping cart_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.5 day
                
            - _Type_: Functional
                
            - The user must be able to add any number of available items to their shopping cart.
                
        - **T8S-7**: _View and manage shopping cart_
            
            - _Priority_: Must Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - The user must be able to view items in their cart, remove individual items, and be automatically redirected to the main page if the cart becomes empty.
                
    - **T8E-3: Checkout and Payment Processing**
        
        - **T8S-8**: _Prevent empty cart checkout_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.25 day
                
            - _Type_: Functional
                
            - The system must prevent users from starting the checkout process if their shopping cart is empty.
                
        - **T8S-9**: _Enter payment and shipping information_
            
            - _Priority_: Must Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - The user must provide shipping address, phone number, credit card number, expiration month/year, and CVV. The user must also select one of the following shipping speeds: Overnight ($29), 3-Day ($19), or Ground (Free). All fields are required.
                
        - **T8S-10**: _Confirm order summary_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.5 day
                
            - _Type_: Functional
                
            - The system must display a summary of the user’s order, including each item's name and price, the subtotal, tax (6% of subtotal), shipping cost, and grand total.
                
        - **T8S-11**: _Complete the order and show receipt_
            
            - _Priority_: Must Have
                
            - _Effort_: 1.5 days
                
            - _Type_: Functional
                
            - Upon confirmation, the order is completed, the purchased items are removed from inventory, the cart is cleared, and a receipt is displayed with the same data as the confirm page plus the last four digits of the credit card and shipping address.
                
        - **T8S-12**: _Simulate email receipt display_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.25 day
                
            - _Type_: Functional
                
            - The same receipt shown after order completion must be displayed as a simulated email in the browser (actual email sending is not required).
                
    - **T8E-4: Admin Functions**
        
        - **T8S-13**: _View sales report_
            
            - _Priority_: Must Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - Admins must be able to view a report of all purchases and the associated buyers.
                
        - **T8S-14**: _Add inventory to the system_
            
            - _Priority_: Must Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - Admins must be able to add new items to the inventory. This can be through direct database entry, as long as all required fields are enforced and explained to the admin.
                
    - **T8E-5: System Behavior and Constraints**
        
        - **T8S-15**: _Store price in base-10 decimal format_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.25 day
                
            - _Type_: Non-Functional
                
            - The system must store all prices using a base-10 decimal or currency-compatible data type, not a floating point, to prevent rounding issues.
                
        - **T8S-16**: _Format price display properly_
            
            - _Priority_: Must Have
                
            - _Effort_: 0.25 day
                
            - _Type_: Functional
                
            - All price values must be displayed with a $ sign, include commas for thousands, and show two decimal places (e.g., $1,234.56).
                
        - **T8S-17**: _Create high-fidelity UI mockups_
            
            - _Priority_: Must Have
                
            - _Effort_: 2 days
                
            - _Type_: Non-Functional
                
            - A high-fidelity prototype of all screens and application flows must be created before coding begins. These mockups must represent the final layout, navigation, and user experience clearly for stakeholder approval.

---

- **Version 2**
    
    - **T8E-6: Search and Usability Enhancements**
        
        - **T8S-18**: _Search inventory by name or description_
            
            - _Priority_: Needs to Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - The user can enter a query and see results where the item name or description contains the keyword(s).
                
    - **T8E-7: Enhanced Admin Features**
        
        - **T8S-19**: _Export sales report to CSV_
            
            - _Priority_: Needs to Have
                
            - _Effort_: 0.5 day
                
            - _Type_: Functional
                
            - Admins must be able to export the full sales report to CSV for external analysis.
                
        - **T8S-20**: _View receipt from sales report_
            
            - _Priority_: Wants to Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - Admins can click on a sold item in the sales report and view the associated receipt.
                
        - **T8S-21**: _Add inventory using a UI_
            
            - _Priority_: Needs to Have
                
            - _Effort_: 1.5 days
                
            - _Type_: Functional
                
            - Admins can add inventory using a web form with validation for all required fields.
                
    - **T8E-8: User Experience Improvements**
        
        - **T8S-22**: _Validate credit card expiration_
            
            - _Priority_: Wants to Have
                
            - _Effort_: 0.25 day
                
            - _Type_: Functional
                
            - The system will prevent checkout if the provided expiration date is in the past.
                
        - **T8S-23**: _Display order history to user_
            
            - _Priority_: Wants to Have
                
            - _Effort_: 1.5 days
                
            - _Type_: Functional
                
            - Users can view their previous orders through an "Orders" section linked to their account.
                
        - **T8S-24**: _Add receipt details (order number, tracking, arrival estimate)_
            
            - _Priority_: Wants to Have
                
            - _Effort_: 1 day
                
            - _Type_: Functional
                
            - The receipt will show a unique order number, a tracking number, and an estimated arrival date based on selected shipping speed.
---
*To be added as project continues...*
