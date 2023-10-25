#include <stdio.h>

int main()
{
    int mileage;
    int months;

    scanf("%d %d", &mileage, &months);

    if (mileage > 10000 || months > 12) {
        printf("Change Oil");
    } else {
        printf("OK");
    }
    
    return 0;
}

// The oil needs to change if the mileage after the last change is over 10.000,
// or if the last oil change has been over 12 months ago.

// Task:
// Take the mileage and months values from input and output "Change Oil", in case the conditions above are satisfied.
// In case its not the time for an oil change, output "OK".
