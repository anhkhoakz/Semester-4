import cv2 as cv

src = cv.imread("./img3.png", cv.IMREAD_GRAYSCALE)


cv.imshow("Img3", src)
cv.waitKey(0)

th, dest = cv.threshold(src, 0, 255, cv.THRESH_BINARY)
cv.imshow("Img3", dest)
cv.waitKey(0)

th, dest = cv.threshold(src, 0, 128, cv.THRESH_BINARY)
cv.imshow("Img3", dest)
cv.waitKey(0)

th, dest = cv.threshold(src, 127, 255, cv.THRESH_BINARY)
cv.imshow("Img3", dest)
cv.waitKey(0)

th, dest = cv.threshold(src, 127, 255, cv.THRESH_BINARY_INV)
cv.imshow("Img3", dest)
cv.waitKey(0)

cv.destroyAllWindows()
