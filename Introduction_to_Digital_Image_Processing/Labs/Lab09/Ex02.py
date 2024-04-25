import cv2
import numpy as np

image = cv2.imread("./imgs/sudoku-original.jpg", 0)

blurred = cv2.GaussianBlur(image, (5, 5), 0)

thresholded = cv2.adaptiveThreshold(
    blurred, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY_INV, 11, 2
)

kernel = np.ones((3, 3), np.uint8)
opened = cv2.morphologyEx(thresholded, cv2.MORPH_OPEN, kernel)
closed = cv2.morphologyEx(opened, cv2.MORPH_CLOSE, kernel)

lines = cv2.HoughLinesP(
    closed, 1, np.pi / 180, threshold=100, minLineLength=100, maxLineGap=10
)

for line in lines:
    x1, y1, x2, y2 = line[0]
    cv2.line(image, (x1, y1), (x2, y2), (0, 255, 0), 2)

cv2.imshow("Original", image)
cv2.waitKey(0)
cv2.imshow("Detected Grid", closed)
cv2.waitKey(0)
cv2.destroyAllWindows()
