# Development Log

This task is challenging and a bit unclear, but there’s no need to be discouraged! We can solve each problem step-by-step. Let’s start with the first requirement:

## 1. Draw 7 red lines

Since this project is focused on learning TDD, it’s enough to generate the lines as objects, leaving the actual drawing to any compatible system. Here’s how we’ll break this down:

1. Create 7 objects
2. Create 1 red line
    1. Determine what a "line" is in this context
    2. Define what "red" means
    3. Finally, create 7 red lines
---

This sets us up to proceed methodically, addressing one part of the task at a time.

---

### 1.1. Create 7 objects

1. First, let's create a simple initial test Generate_ShouldCreateSeven to check that there are 7 lines. Red.
2. Let's make the test build. Still Red.
3. Let's make the test pass. Green!
4. We’re refactoring the code; it’s improved, but now there’s duplication with var redLinesCount = 7;. We’ll resolve this, starting with the test.
 5. We’ll perform Red -> Green -> Refactoring again, adding redLinesCount as an argument to the Generate method.

Step 1.1 is completed, we can generate not only 7, but also 10, and even 4294967295 objects, this is not required by the task, but it makes the code cleaner and may be useful in the future

----
### 1.2. What is a line?
    Let’s clarify what a line is and how to make it red. To display a line in HTML, we can use this code:

```html
    <svg height="20" width="200">
        <line x1="0" y1="10" x2="200" y2="10" style="stroke:red;stroke-width:2" />
    </svg>
```
Clearly, the simplest way to define a line is by specifying two points, though we could, in theory, create infinite lines.
For now, we’ll keep it simple and stick with this approach.

Starting with a test again!

1. Test for the RedLine constructor
2. Change  code to make the test green.  
 * A simple line-drawing project  has been added. It will help us understand how our lines can be rendered. The details of working on this part of the project will not be documented in this log, and all related commits will be marked with gui.
3. We haven’t created a proper line yet since all coordinates are currently set to 0. Let’s add a check to ensure a line cannot have a length of 0 (i.e., it cannot be just a point). Moving forward, we’ll simplify things by committing all changes in a single commit. However, we’ll still follow the process: writing tests first, or while writing them (e.g., adding missing properties), we’ll adjust the code.



-----
