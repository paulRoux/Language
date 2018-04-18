package main

import (
	"fmt"
)

type USB interface {
	Name() string
	Connecter //嵌入接口
}

type Connecter interface {
	Connect()
}

type PhoneConnect struct {
	name string
}

func (pc PhoneConnect) Name() string {
	return pc.name
}

func (pc PhoneConnect) Connect() {
	fmt.Println("connect:", pc.name)
}

func main() {
	var a USB
	a = PhoneConnect{"PhoneConnect"}
	a.Connect()
	Disconnect(a)

	pc := PhoneConnect{"PhoneConnect"}
	var b Connecter
	b = Connecter(pc)
	b.Connect
}

/*
func Disconnect(usb USB) {
	if pc, ok := usb.(PhoneConnect); ok {
		fmt.Println("Disconnect:", pc.name)
		return
	}
	fmt.Println("Uknown device")
}
*/

func Disconnect(usb interface{}) {
	switch v := usb.(type) {
	case PhoneConnect:
		fmt.Println("Disconnect:", v.name)
	default:
		fmt.Println("Unknown device")
	}
}
