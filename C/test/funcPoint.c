#include <stdio.h>

typedef int(FUNC)(int);

int test(int i)
{
    return i * i;

}

void f()
{
    printf("Call f()......\n");

}

int main()
{
        FUNC *pt = test;
        void(*pf)() = &f;

        pf();
        (*pf)();
        printf("Call : %d\n", pt(2));
        return 0;
}
