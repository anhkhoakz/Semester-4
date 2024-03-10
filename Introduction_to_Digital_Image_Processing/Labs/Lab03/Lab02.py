import cv2 as cv
import numpy as np


def rectangle_mask(image):
    # creating a mask of that has the same dimensions of the image
    # where each pixel is valued at 0
    mask = np.zeros(image.shape[:2], dtype="uint8")

    # creating a rectangle on the mask
    # where the pixels are valued at 255
    cv.rectangle(mask, (0, 90), (290, 450), 255, -1)
    cv.imshow("Mask", mask)

    # performing a bitwise_and with the image and the mask
    masked = cv.bitwise_and(image, image, mask=mask)
    cv.imshow("Mask applied to Image", masked)
    cv.waitKey(0)
    cv.destroyAllWindows()


def circle_mask(image):
    # creating a mask of that has the same dimensions of the image
    # where each pixel is valued at 0
    mask = np.zeros(image.shape[:2], dtype="uint8")

    # creating a rectangle on the mask
    # where the pixels are valued at 255
    cv.circle(mask, (145, 200), 100, 255, -1)
    cv.imshow("Mask", mask)

    # performing a bitwise_and with the image and the mask
    masked = cv.bitwise_and(image, image, mask=mask)
    cv.imshow("Mask applied to Image", masked)
    cv.waitKey(0)
    cv.destroyAllWindows()


image = cv.imread("img1.png")

rectangle_mask(image)
circle_mask(image)
