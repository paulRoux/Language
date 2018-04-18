package main

import (
	"fmt"
)

func main() {
LABEL1:
	for {
		for i := 0; i < 10; i++ {
			if i > 3 {
				break LABEL1
			}
		}
	}

LABEL2:
	for i := 0; i < 10; i++ {
		for {
			if i > 3 {
				continue LABEL1 //外层是有限循环
			}
		}
	}
	fmt.Println("OK")
}
