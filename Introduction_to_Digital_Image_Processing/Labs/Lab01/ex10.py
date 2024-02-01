import cv2

path = r"imgs/fruits.png"
image = cv2.imread(path)

windowName = "Image"
# startPoint = (0, 0)
startPoint = (200, 0)
endPoint = (100, 50)
color = (0, 255, 0)
thickness = 9

# image = cv2.arrowedLine(image, startPoint, endPoint, color, thickness)
image = cv2.arrowedLine(image, startPoint, endPoint, color, thickness, tipLength=0.5)

cv2.imshow(windowName, image)
cv2.waitKey(0)
cv2.destroyAllWindows()
