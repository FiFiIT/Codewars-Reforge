from operator import indexOf


def done_or_not(board):
    for i in range(0, 9):
        row = sum(board[i])
        col = sum(b[i] for b in board)

        col_start = 3 * (i % 3)
        row_start = 3 * (i // 3)
        block = sum(sum([b[col_start:col_start+3]
                         for b in board[row_start:row_start+3]], []))

        if row != 45 or col != 45 or block != 45:
            return 'Try again!'

    return 'Finished!'


result = done_or_not([[1, 3, 2, 5, 7, 9, 4, 6, 8], [4, 9, 8, 2, 6, 1, 3, 7, 5], [7, 5, 6, 3, 8, 4, 2, 1, 9], [6, 4, 3, 1, 5, 8, 7, 9, 2], [
                     5, 2, 1, 7, 9, 3, 8, 4, 6], [9, 8, 7, 4, 2, 6, 5, 3, 1], [2, 1, 4, 9, 3, 5, 6, 8, 7], [3, 6, 5, 8, 1, 7, 9, 2, 4], [8, 7, 9, 6, 4, 2, 1, 3, 5]])
print(result)
