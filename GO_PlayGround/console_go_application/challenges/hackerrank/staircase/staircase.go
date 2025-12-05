package staircase

import (
	"fmt"
	"strings"
)

func staircase(n int) {
	for i := 0; i < n; i++ {
		var spaces int = n - i - 1
		var chars int = i + 1
		fmt.Println(strings.Repeat(" ", spaces) + strings.Repeat("#", chars))
	}
}

func Implement() {
	var n int = 6
	staircase(n)
	fmt.Println("END OF staircase")
}
