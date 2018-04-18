package main

import (
	"fmt"
)

type A struct {
	B
	Name string
}

type B struct {
	Name string
}

type human struct {
	sex int
}

type person struct {
	human
	name string
	age  int
}

func main() {
	a := &person{
		name: "joe",
		age:  19,
		human: human{
			sex: 1,
		},
	}

	a.name = "ok"
	fmt.Println(a)

	b := A{
		Name: "A",
		B: B{
			Name: "B",
		},
	}
	fmt.Println(b.Name, b.B.Name)
}
