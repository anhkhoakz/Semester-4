import cv2

path = r"imgs/fruits.png"
image = cv2.imread(path)

windowName = "Image"
centerCoordinates = (120, 100)
radius = 20
color = (0, 0, 255)
# thickness = 5
thickness = -1
image = cv2.circle(image, centerCoordinates, radius, color, thickness)

cv2.imshow(windowName, image)
cv2.waitKey(0)
cv2.destroyAllWindows()
