# 📚 Library Management System (ASP.NET Core MVC)

Welcome to the **Library Management System** project! This ASP.NET Core MVC application is designed to manage a library's books and authors in a comprehensive and user-friendly way. The project follows object-oriented programming (OOP) principles, ensuring a clean separation of concerns and maintainable code.

---

## 🚀 Project Overview

This project enables users to perform CRUD operations for both books and authors. It includes:
- **Book Management:** Create, read, update, and delete books.
- **Author Management:** Create, read, update, and delete authors.
- **User Interface:** Responsive views with consistent layout and partial views for shared content (e.g., footer).
- **Routing & Configuration:** Clean URL routing and configuration in `Program.cs` with static files support.

---

## 🛠️ Key Features

## 📌 Models

### **Book Model**
| Property       | Type     | Description                      |
|---------------|---------|----------------------------------|
| `Id`          | `int`   | Unique identifier               |
| `Title`       | `string`| Book title                      |
| `AuthorId`    | `int`   | Reference to an author          |
| `Genre`       | `string`| Book genre                      |
| `PublishDate` | `DateTime` | Publishing date             |
| `ISBN`        | `string`| ISBN number                     |
| `CopiesAvailable` | `int` | Available copies              |

### **Author Model**
| Property      | Type     | Description                     |
|--------------|---------|---------------------------------|
| `Id`         | `int`   | Unique identifier              |
| `FirstName`  | `string`| Author's first name           |
| `LastName`   | `string`| Author's last name            |
| `DateOfBirth`| `DateTime` | Date of birth               |


- **ViewModels:**  
  - Separate ViewModels were created for listing or displaying book and author details.

- **Controllers:**  
  - **BookController:** Handles all book-related operations with the following actions:
    - `List`: Displays a list of books.
    - `Details`: Shows details of a specific book.
    - `Add`: Provides a form to add a new book.
    - `Update`: Provides a form to update an existing book.
    - `Delete`: Confirms and deletes a book.
  - **AuthorController:** Manages author-related operations with similar actions as the BookController.

## 🎨 Views

| View         | Purpose |
|-------------|---------|
| **Home/Index**  | Homepage with navigation |
| **Home/About**  | Project information page |
| **Book/List**   | Displays all books |
| **Book/Details** | Shows book details |
| **Book/Add** | Form to add a new book |
| **Book/Update**   | Form to update a book |
| **Author/List** | Displays all authors |
| **Author/Add** | Form to add a new author |
| **Author/Update** | Form to update an author |
| **Shared/_Footer** | Partial view for the footer |
| **Shared/_Layout** | Common layout |
---



- **Configuration:**  
  - MVC services and routing are configured in `Program.cs`.
  - Static files are served from the `wwwroot` folder.
  - Default routing is set to direct users to the home page.

---

## 💻 Project Structure
 ```bash
LibraryManagementSystem/
├── Controllers/
│   ├── BookController.cs
│   └── AuthorController.cs
├── Models/
│   ├── Book.cs
│   ├── Author.cs
│   └── ViewModels/
│       ├── BookAddViewModel.cs
│       ├── BookListViewModel.cs
│       ├── BookUpdateViewModel.cs
│       ├── AuthorAddViewModel.cs
│       ├── AuthorListViewModel.cs
│       └── AuthorUpdateViewModel.cs
├── Views/
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _Footer.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── About.cshtml
│   ├── Book/
│   │   ├── List.cshtml
│   │   ├── Details.cshtml
│   │   ├── Add.cshtml
│   │   ├── Update.cshtml
│   │ 
│   └── Author/
│       ├── List.cshtml
│       ├── Details.cshtml
│       ├── Add.cshtml
│       └── Update.cshtml
├── wwwroot/
│   └── css, js, lib, … (statik dosyalar)
└── Program.cs
```
## 📸 Screenshots
  ## 🏠 Home Page
  ![home](https://github.com/user-attachments/assets/87bc1579-c273-481e-8a0c-0cf0956986ca)
  ## 📖 Book Management
  ![booklist](https://github.com/user-attachments/assets/92071a19-00a1-41ea-8ce8-2bf421f5f683)
  ## ✍️ Author Management
  ![authorlist](https://github.com/user-attachments/assets/4023f68b-b6be-401d-b1eb-9fb30be5be31)
  ## ℹ️ About Page
  ![about](https://github.com/user-attachments/assets/bd802557-a004-40f6-952b-f8424660cdf5)





## 🤝 Contribution
- Contributions are welcome! If you find any issues or have suggestions for improvements:
- Please fork the repository.
- Create a new branch for your feature or bug fix.
- Submit a pull request with a clear description of your changes.

## 📜 License
- This project is licensed under the MIT License.

## 🙏 Acknowledgements
- Special thanks to all contributors and the open-source community for their support and resources.
- Developed with by Efşan Nart ❤️
