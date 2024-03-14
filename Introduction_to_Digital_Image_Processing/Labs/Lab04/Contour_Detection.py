import cv2 as cv

img = cv.imread("./4_sudoku.png", 0)
ret, thresh = cv.threshold(img, 150, 255, cv.THRESH_BINARY)

contours, hierarchy = cv.findContours(thresh, cv.RETR_TREE, cv.CHAIN_APPROX_SIMPLE)

imageCopy = img.copy()
cv.drawContours(imageCopy, contours, -1, (0, 255, 0), 2, cv.LINE_AA)

cv.imshow("Image", img)
cv.waitKey(0)
cv.imshow("thresh", thresh)
cv.waitKey(0)
cv.imshow("Image", imageCopy)
cv.waitKey(0)
cv.destroyAllWindows()
