
# C Notes

Inspired by: **[CS50 2019 Lectures](https://www.youtube.com/watch?v=e9Eds2Rc_x8&pbjreload=101)**

Progress: **53:15 of CS50 2019 - Lecture 1 - C**

### Steps to compile and run on MacOS:

- From terminal run `clang <filename.c> -o <filename of executable>` (name.c - source code)

- Example: `clang hello.c -o hello` will create a file named 'hello' that contains machine code

- Example 2: `clang hello.c` the 'a.out' (assembly output) will be created

- Another way: `gcc -o hello hello.c` where -o stands for 'output'

- Simplest way: `make hello` will run `cc hello.c -o hello` automatically

- Then you can run `./hello` or `./a.out`
