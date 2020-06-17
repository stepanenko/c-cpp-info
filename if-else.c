
#include <stdio.h>

int main() {
  int a, b;
  printf("Enter the first value, A = ");
  scanf("%d", &a);
  printf("Enter the second value, B = ");
  scanf("%d", &b);
  if (a > b) {
    printf("A is greater than B\n");
  } else if (a == b) {
    printf("A equals B\n");
  } else printf("A is less than B\n");
}
