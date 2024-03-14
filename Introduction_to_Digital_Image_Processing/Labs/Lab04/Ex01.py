import cv2 as cv
import numpy as np

"""

Using thresholding techniques to convert the grayscale image into a binary image. Choose the most good-looking one.
Hint: Try with simple or adaptive or Otsu's thresholding method.

"""


img = cv.imread("./4_sudoku.png", 0)


def showImg(img=img, title="Image"):
    cv.imshow(title, img)
    cv.waitKey(0)
    cv.destroyAllWindows()


img = cv.medianBlur(img, 5)
# showImg()

ret, thresh1 = cv.threshold(img, 127, 255, cv.THRESH_BINARY)
thresh2 = cv.adaptiveThreshold(
    img, 255, cv.ADAPTIVE_THRESH_MEAN_C, cv.THRESH_BINARY, 11, 2
)
thresh3 = cv.adaptiveThreshold(
    img, 255, cv.ADAPTIVE_THRESH_GAUSSIAN_C, cv.THRESH_BINARY, 11, 2
)
ret, thresh4 = cv.threshold(img, 0, 255, cv.THRESH_BINARY + cv.THRESH_OTSU)

# showImg(thresh1, "Thresh1")
showImg(thresh2, "Thresh2")
# showImg(thresh3, "Thresh3")
# showImg(thresh4, "Thresh4")


cv.waitKey(0)
cv.destroyAllWindows()
