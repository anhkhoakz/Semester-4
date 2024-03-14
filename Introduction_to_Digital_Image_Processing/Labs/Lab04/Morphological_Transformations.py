import cv2
import numpy as np

img = cv2.imread("j.png", 0)
kernel = np.ones((5, 5), np.uint8)


def showImg(img=img, title="Image"):
    cv2.imshow("Image", img)
    cv2.waitKey(0)
    cv2.destroyAllWindows()


def Erosion():
    erosion = cv2.erode(img, kernel, iterations=1)

    showImg()
    showImg(erosion)


def Dilation():
    dilation = cv2.dilate(img, kernel, iterations=1)

    showImg()
    showImg(dilation)


def Opening():
    img = cv2.imread("./j2.png")
    opening = cv2.morphologyEx(img, cv2.MORPH_OPEN, kernel)

    showImg(img)
    showImg(opening)


def Closing():
    img = cv2.imread("./j3.png")
    closing = cv2.morphologyEx(img, cv2.MORPH_CLOSE, kernel)

    showImg(img)
    showImg(closing)


def Morphological_Gradient():
    gradient = cv2.morphologyEx(img, cv2.MORPH_GRADIENT, kernel)

    showImg()
    showImg(gradient)


# def Top_Hat():
#     tophat = cv2.morphologyEx(img, cv2.MORPH_TOPHAT, kernel)
#
#     showImg()
#     showImg(tophat)
#
#
# def Black_Hat():
#     pass


# Erosion()
# Dilation()
# Opening()
# Closing()
# Morphological_Gradient()
# Top_Hat()
