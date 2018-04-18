package main

import (
	"fmt"
	"strconv"
)

func main() {
	var a int = 65
	b := string(a)       //打印出来是A
	b := strconv.Itoa(a) //打印出来为字符串65
	a := strconv.Atoi(b) //转换回去
	fmt.Println(b)
}
