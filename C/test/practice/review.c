/*************************************************************************
	> File Name: review.c
	> Author: 
	> Mail: 
	> Created Time: 2017年10月14日 星期六 09时45分00秒
 ************************************************************************/

#include<stdio.h>

int mian(void)
{
    int arry[10] = {0};
    arry[0];   // *(arry+0)
    ++arry;
    (arry+1);
    *(arry+1);
    ++(&arry[0]);
    
    ++(&*(arry+0));
    (&*(arry+0));
    ++(*(arry+0));

    ++(&*(arry+1));

    *(++(&arry[0]));
    ++(&(arry[0]));

    return 0;
}
