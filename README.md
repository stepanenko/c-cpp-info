
# C Languages

[C](https://github.com/stepanenko/c-cpp-info/tree/master/C) &bull; [C++](https://github.com/stepanenko/c-cpp-info/tree/master/C++) &bull; [C#](https://github.com/stepanenko/c-cpp-info/tree/master/C%23#README.md)

### Key Differences Between C, C++, and C#:

| Feature | C | C++ | C# |
|---|---|---|---|
| Programming Paradigm | Procedural | Procedural + OOP | Component-Oriented + OOP |
| Platform Dependency | Platform-independent (compiled per target) | Platform-independent (compiled per target) | Cross-platform (via .NET Core/.NET 5+) |
| Memory Management | Manual | Manual (or smart pointers) | Automatic (Garbage Collector) |
| Compilation | Machine code | Machine code | Intermediate Language (CLR), then JIT to machine code |
| Pointers | Fully supported | Fully supported | Limited to `unsafe` blocks |
| Ease of Use | Complex | Moderately complex | Simplified for developers |
| Use Case | System programming, embedded | Performance-critical apps (games, engines) | Modern apps (web, mobile, desktop, cloud) |

**Notes:**

- **Platform Dependency** — C# used to be Windows-only when it ran on the .NET Framework, but since **.NET Core (2016)** and especially **.NET 5+ (2020 onward, C# runs natively on Windows, Linux, and macOS. Calling it "primarily Windows" is outdated by about a decade at this point.

- **Compilation** — C# doesn't stop at Intermediate Language (IL) — the CLR then JIT-compiles that IL into native machine code at runtime, which is why C# performance can get close to C++ in many workloads.

- **Memory Management** — C++ supports smart pointers (`unique_ptr`, `shared_ptr`) as a middle ground between fully manual C-style memory management and full garbage collection.


### Run C/C++/C#... code online: 
- https://www.programiz.com/c-programming/online-compiler/

### Basic tutorials:
- https://www.programiz.com/c-programming

### Program examples: 
- https://www.programiz.com/c-programming/examples
