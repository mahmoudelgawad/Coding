package main

import (
	//# 'console_go_application' not folder , but package name
	//#>go mod init console_go_application
	diagonaldifference "console_go_application/challenges/hackerrank"
	"fmt"
)

func main() {

	var x [3][3]int = [3][3]int{
		{1, 2, 3},
		{4, 5, 6},
		{9, 8, 9},
	}
	res := diagonaldifference.Diagonaldifference(x)
	fmt.Println(res)

	fmt.Println("Hello Mahmoud! END OF main.go")
}
