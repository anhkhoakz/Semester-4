import cv2 as cv

img = cv.imread("img3.png", cv.IMREAD_GRAYSCALE)

# cv.imshow("Img3", img)
# cv.waitKey(0)

_, firstImg = cv.threshold(img, 179, 255, cv.THRESH_BINARY)


_, secondImg = cv.threshold(img, 179, 255, cv.THRESH_BINARY_INV)

cv.imshow("Img3", firstImg)
cv.waitKey(0)
cv.imshow("Img3", secondImg)
cv.waitKey(0)

cv.destroyAllWindows()
