# Case Study: Todo App with Parallel Subtasks

## Overview

You're asked to build a **simple** C# Console Application that demonstrates:

1. Creating **main tasks** (todos).
2. Creating **subtasks** in **parallel** for each task.
3. Using a **dummy API call** (i.e., a mock function) to simulate an external request with a **random delay** (1–5 seconds).

### Core Requirements

1. **Todo Structure**

   - Each todo can have **n-level** deep subtasks. For the challenge, an example structure is:
     ```
     Task1
     ├─ Task11
     │ ├─ Task111
     │ ├─ Task112
     │ └─ Task113
     ├─ Task12
     │ ├─ Task121
     │ ├─ Task122
     │ └─ Task123
     ```

2. **Parallel Creation of Subtasks**

   - When you create a subtask (e.g., `Task11`), **in parallel** you should kick off creation of the sub-subtasks (`Task111`, `Task112`, `Task113`) without blocking the sequence of creating `Task12`.

3. **Simulating API Calls**

   - Use a function that randomly delays (1–5 seconds) to mimic a remote API request. For instance, `DummyApiService.CreateTodoAsync(...)` waits randomly, then returns a success.

4. **Logging / Console Output**
   - Print or log messages whenever you start or finish creating a task/subtask. This shows the parallelism and order of operations.

### Expected Flow

1. **Create `Task1`**.
2. **Create `Task11`** under `Task1`, then in parallel create `Task111`, `Task112`, `Task113`.
3. While those are being created, proceed to **create `Task12`**, then create `Task121`, `Task122`, `Task123` in parallel.

---

## Suggested Project Structure

Below is one possible file layout:

```
├─ Program.cs
├─ Models
│ └─ TodoItem.cs
├─ Services
│ └─ DummyApiService.cs
└─ README.md (this file)
```

### `Models/TodoItem.cs`

- A class for representing your todo items, containing a `Name` and a list of `SubTasks`.

### `Services/DummyApiService.cs`

- A static service that simulates an API call with a random delay between 1–5 seconds.
- Logs when a task starts creation and when it finishes.

### `Program.cs`

- The **entry point**.
- Builds out the nested todo structure.
- Contains logic to _initiate_ creation of each todo and subtask in parallel—so that sub-subtasks run without blocking the creation of subsequent tasks.

---

## What We’re Looking For

1. **Correctness**

   - Tasks are **started** in the correct order, sub-subtasks can run in parallel without blocking higher-level tasks.

2. **Parallelism / Concurrency**

   - Shows ability to use `async/await`, `Task.WhenAll`, or other concurrency features in C#.

3. **Code Clarity**

   - Clean, readable code.

4. **(Optional) Testing**
   - Simple console logs suffice, but you may add unit tests or more robust logging if desired.

## Extensions and Ideas

- **Graceful Error Handling**: Decide what to do if a subtask’s creation fails.
- **Order of Creation**: Explore ways to verify or log creation timestamps to prove concurrency.
- **Logging**: Replace console logs with a logging framework (e.g., Serilog, NLog) for more robust outputs.

**Happy coding and good luck!**
