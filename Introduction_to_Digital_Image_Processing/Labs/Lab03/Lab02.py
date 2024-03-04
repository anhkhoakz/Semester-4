import cv2 as cv
import numpy as np

def rectangle_mask():
    # creating a mask of that has the same dimensions of the image
    # where each pixel is valued at 0
    mask = np.zeros(image.shape[:2], dtype="uint8")

    # creating a rectangle on the mask
    # where the pixels are valued at 255
    cv2.rectangle(mask, (0, 90), (290, 450), 255, -1)
    cv2.imshow("Mask", mask)

    # performing a bitwise_and with the image and the mask
    masked = cv2.bitwise_and(image, image, mask=mask)
    cv2.imshow("Mask applied to Image", masked)
    cv2.waitKey(0)
    
def circle_mask():
    # creating a mask of that has the same dimensions of the image
    # where each pixel is valued at 0
    mask = np.zeros(image.shape[:2], dtype="uint8")

    # creating a rectangle on the mask
    # where the pixels are valued at 255
    cv2.circle(mask, (145, 200), 100, 255, -1)
    cv2.imshow("Mask", mask)

    # performing a bitwise_and with the image and the mask
    masked = cv2.bitwise_and(image, image, mask=mask)
    cv2.imshow("Mask applied to Image", masked)
    cv2.waitKey(0)
    
rectangle_mask()
circle_mask()