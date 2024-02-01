import numpy as np
import cv2

Img = np.zeros((512, 512, 3), dtype="uint8")

start_point = (100, 100)

stop_point = (450, 450)

color = (255, 255, 255)

thickness = 9

image = cv2.line(Img, start_point, stop_point, color, thickness)

cv2.imshow("Drawing Line", image)
cv2.waitKey(0)
cv2.destroyAllWindows()
