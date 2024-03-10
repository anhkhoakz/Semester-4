import cv2 as cv
import numpy as np

"""
Extracting the faces from the input image using a circular mask.
Output is 3 of face images extracted from the input image.
Hint: Using circular masks as in the instructions above.
"""

img = cv.imread("img1.png")

mask = np.zeros(img.shape[:2], dtype="uint8")

cv.circle(mask, (145, 200), 100, 255, -1)
cv.circle(mask, (425, 170), 100, 255, -1)
cv.circle(mask, (675, 250), 100, 255, -1)
# cv.imshow("Mask", mask)

masked = cv.bitwise_and(img, img, mask=mask)


cv.imshow("Hello", masked)
cv.waitKey(0)
