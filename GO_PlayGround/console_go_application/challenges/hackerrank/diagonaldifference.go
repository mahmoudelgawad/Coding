package diagonaldifference

func Diagonaldifference(arr [3][3]int) int {
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
