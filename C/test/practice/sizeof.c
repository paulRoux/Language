/*************************************************************************
	> File Name: a.c
	> Author: 
	> Mail: 
	> Created Time: 2017年09月24日 星期日 16时56分08秒
 ************************************************************************/

#include<stdio.h>
#include <string.h>

int main(void)
{
    char *p = "hello";
    char a[10] = {'h', 'e', 'l', 'l', '0'};
    char b[10] = {"hello"};
    char c[10] = {'h', 'e', 'l', '\0', 'l', '0'};
    printf("%d %d\n", strlen("hell\0o"), sizeof("hell\0o"));
    printf("%d %d\n", strlen(a), sizeof(a));
    printf("%d %d\n", strlen(b), sizeof(b));
    printf("%d %d\n", strlen(c), sizeof(c));
    return 0;
}
