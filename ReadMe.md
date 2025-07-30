# DesignPatterns Solution Overview

This solution contains multiple projects, each illustrating a different software design pattern. Below is a summary of each project and the pattern it implements.

## Projects & Patterns

### 1. Discounts
**Pattern:** Strategy  
**Description:**  
Implements various discount strategies (e.g., BOGO, percentage, coupon) for shopping cart items. The [`ShoppingCart`](Discounts/ShoppingCart.cs) class uses the Strategy pattern to apply different discount algorithms dynamically via the `IDiscount` interface.

### 2. DocumentGenerator
**Pattern:** Factory Method  
**Description:**  
Generates documents in different formats (PDF, Word, Excel) using a factory method. The [`DocumentFactory`](DocumentGenerator/DocumentFactory.cs) creates instances of document generators (`PDFDocumentGenerator`, `WordDocumentGenerator`, `ExcelDocumentGenerator`) based on the requested type.

### 3. DocumentMemento
**Pattern:** Memento  
**Description:**  
Allows saving and restoring the state of a document (content, font name, font size). The [`Document`](DocumentMemento/Document.cs) class creates and restores states using [`DocumentState`](DocumentMemento/DocumentState.cs), while [`DocumentHistory`](DocumentMemento/DocumentHistory.cs) manages the history of states.

### 4. Editor
**Pattern:** Memento  
**Description:**  
Similar to DocumentMemento, but focused on editor content. [`EditorOriginator`](Editor/EditorOriginator.cs) creates and restores content states using [`EditorStateMemento`](Editor/EditorStateMemento.cs), with [`History`](Editor/History.cs) managing undo/redo functionality.

### 5. RTSNotifications
**Pattern:** Observer  
**Description:**  
Implements real-time notifications for orders via SMS, Email, and Push. Observers are added to an order and notified of changes, demonstrating the Observer pattern.

### 6. UserPermissions
**Pattern:** Decorator  
**Description:**  
Dynamically adds roles and permissions to users. The base `IUser` interface is extended by decorators like [`AdminRole`](UserPermissions/UserDecorators/AdminRole.cs) and [`EditorRole`](UserPermissions/UserDecorators/EditorRole.cs), allowing flexible permission management.

---

## Running Tests

Each project has a corresponding test project (e.g., `DiscountTests`, `DocumentGeneratorTests`) to verify the implementation of the pattern.

---

## How to Build

Open the solution in Visual Studio or use the following command:

```sh
dotnet build DesignPatterns.sln
```

---

## How to Run

Navigate to the desired project folder and run:

```sh
dotnet run --project <ProjectName>/<ProjectName>.csproj
```

Replace `<ProjectName>` with the folder name (e.g., `Discounts`, `DocumentGenerator`).