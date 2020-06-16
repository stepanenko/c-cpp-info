
#include <stdio.h>

void askName() {
  printf("What is your name? ");
}

void sayHello(char str[]) {
  printf("Hello, %s\n", str);
}

int main() {
  char name[50];
  askName();
  scanf("%s", name);
  sayHello(name);
}
