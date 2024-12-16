# Advanced C# Assignments

The document is a summary of advanced C# assignments that cover various programming concepts, including generics, data manipulation, and events. Below is a concise description

## Assignments Summary
1. [Assignment 1: Assignment Day 1](#AssignmentDay-1)
- Generic Range<T> Class: Develop a class to handle value ranges, supporting operations like checking containment and calculating range length.
- Reverse an ArrayList: Reverse elements in an ArrayList in-place without using the Reverse method.
- Filter Even Numbers: Extract even integers from a list and return them in a new list.
  
2. [Assignment 2: Assignment Day 2](#AssignmentDay-2)
- First Non-Repeated Character: Identify the first non-repeating character in a string and return its index using a dictionary.
- Parameterize ProcessBooks: Extend a book-processing function to use delegates (Func, user-defined, anonymous methods, and lambdas).
  
3. [Assignment 3: Assignment Day 3](#AssignmentDay-3)
- Company Layoff Logic with Events: Create a system where employees are laid off based on age or vacation stock. Use events to trigger layoff actions and update the department staff.

4. [Assignment 4: Assignment Day 4](#AssignmentDay-4)
- Book Processing Delegates: Explore various delegate types (user-defined, built-in, anonymous, and lambda) to parameterize book processing operations.

---

**Assignment C# Advanced Session One**

1.  create a generic Range\<T\> class that represents a range of values
    from a minimum value to a maximum value. The range should support
    basic operations such as checking if a value is within the range and
    determining the length of the range.

> Requirements:

-  Create a generic class named Range\<T\> where T represents the type
    > of values.

-  Implement a constructor that takes the minimum and maximum values to
    > define the range.

-  Implement a method IsInRange(T value) that returns true if the
    > given  value is within the range, otherwise false.

-  Implement a method Length() that returns the length of the range
    > (the difference between the maximum and minimum values).

-  Note: You can assume that the type T used in the Range\<T\> class
    > implements the IComparable\<T\> interface to allow for
    > comparisons.

2.  You are given an **ArrayList** containing a sequence of
    elements. try to reverse the order of elements in the **ArrayList**
    in-place(in the same arrayList) without using the built-in **Reverse**.
    Implement a function that takes the **ArrayList** as input and modifies
    it to have the reversed order of elements.

3. You are given a list of integers. Your task is to find and return a
   new list containing only the even numbers from the given list.

   ---

   **Assignment 2 C# Advanced**

1)Given a string, find the first non-repeated character in it and return
its index. If there is no such character, return -1. Hint you can use
dictionary

1.  **Considering the Code Below, Write Down the Body of all Listed
    Methods and Properties and Constructor:**

> ![A computer screen shot of text Description automatically
> generated](media/image1.png){width="6.0in"
> height="3.798611111111111in"}

![A screen shot of a computer Description automatically
generated](media/image2.png){width="4.172916666666667in"
height="2.801388888888889in"}

}

}

> **2.You need to parameterize ProcessBooks function to accept
> BookFunctions Methods using following cases: **

a.  Create User Defined Delegate with the same signature of methods
    existed in Bookfunctions class.

<!-- -->

a.  Use the Proper build in delegate. 

<!-- -->

a.  Anonymous Method (GetISBN).

<!-- -->

a.  Lambda Expression (GetPublicationDate).

![A computer code with text Description automatically
generated](media/image3.png){width="5.5in" height="2.204861111111111in"}
