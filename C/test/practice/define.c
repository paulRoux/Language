/*************************************************************************
	> File Name: define.c
	> Author: 
	> Mail: 
	> Created Time: 2017年09月16日 星期六 14时52分45秒
 ************************************************************************/

#include<stdio.h>
#include <stdlib.h>

int main(void)
{
    printf("%s\n", __DATE__);
    printf("%s\n", __FILE__);
    printf("%d\n", __LINE__);
    printf("%d\n", __STDC__);
    printf("%d\n", __STDC_HOSTED__);
    printf("%s\n", __TIME__);
    printf("%s\n", __func__);
    return 0;
}
