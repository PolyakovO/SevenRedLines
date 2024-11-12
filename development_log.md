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

1. Create 7 objects
    1. First, let's create a simple initial test Generate_ShouldCreateSeven to check that there are 7 lines. Red.
    2. Let's make the test build. Still Red.
    3. Let's make the test pass. Green!
    4. We’re refactoring the code; it’s improved, but now there’s duplication with var redLinesCount = 7;. We’ll resolve this, starting with the test.
    5. We’ll perform Red -> Green -> Refactoring again, adding redLinesCount as an argument to the Generate method.