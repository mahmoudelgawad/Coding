package diagonaldifference

import (
	"fmt"
)

func diagonaldifference(arr [3][3]int) int {
	var totalL int = 0
	var totalR int = 0
	var r int = 0
	for row := 0; row < len(arr); row++ {
		r = len(arr) - 1 - row
		totalL += arr[row][row]
		totalR += arr[row][r]
	}
	var diff int = totalL - totalR
	if diff < 0 {
		return diff * -1
	} else {
		return diff
	}

}

func Implement() {
	var x [3][3]int = [3][3]int{
		{1, 2, 3},
		{4, 5, 6},
		{9, 8, 9},
	}
	res := diagonaldifference(x)
	fmt.Println(res)
	fmt.Println("END OF diagonaldifference")
}
