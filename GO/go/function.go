package main

import (
	"fmt"
)

func main() {
	f := closure(10)
	fmt.Println(f(1))
	fmt.Println(f(2))

	fmt.Println("a")
	defer fmt.Println("b")
	defer fmt.Println("c")

	for i := 0; i < 3; i++ {
		defer fmt.Println(i)
	} //三次 2 1 0

	for i := 0; i < 3; i++ {
		defer func() {
			fmt.Println(i)
		}() //三次3 在main函数return时执行的defer语句，这时i已经为3了
	}

	A()
	B()
	C()
}

func closure(x int) func(int) int {
	return func(y int) int {
		return x + y
	}
}

func A() {
	fmt.Println("Func A")
}

func B() {
	panic("Panic in B")
}

/*
func B() {
	defer func() {
		if err := recover(); err != nil {
			fmt.Println("Recover in B")
		}
	}()
	panic("Panic in B")
}
*/

func C() {
	fmt.Println("Func C")
}

/*
func A() (a, b, c int) {
	a, b, c = 1, 2, 3
	//a, b, c := 1, 2, 3
	return
}
*/

/*
func A(a int, b int, c int) (int, int, int) {
	a, b, c = 1, 2, 3
	return
}
*/

/*
func A(a ... int) {
	fmt.Println(a)
}
*/
