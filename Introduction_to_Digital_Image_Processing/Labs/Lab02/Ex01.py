import cv2 as cv
import numpy as np
# import matplotlib.pyplot as plt


def showImg():
    cv.imshow("Image", img)
    cv.waitKey(0)
    cv.destroyAllWindows()


def showYellowBaloon():
    cv.imwrite("yellowBaloon.png", yellowBaloon)
    cv.imshow("Yellow Balloon", yellowBaloon)
    cv.waitKey(0)
    cv.destroyAllWindows()


img = cv.imread("IMG.png")

# EX01
b, g, r = cv.split(img)

print(b)
print(g)
print(r)

# Display blue channel
cv.imshow("Blue Channel", b)
cv.waitKey(0)

# Display green channel
cv.imshow("Green Channel", g)
cv.waitKey(0)

# Display red channel
cv.imshow("Red Channel", r)
cv.waitKey(0)

cv.destroyAllWindows()

# EX02
# Yellow baloon
startPoint = (30, 15)
endPoint = (135, 140)
color = (255, 0, 0)
thickness = 2
img = cv.rectangle(img, startPoint, endPoint, color, thickness)

# Blue baloon
startPoint = (150, 65)
endPoint = (230, 190)
color = (255, 0, 0)
thickness = 2
img = cv.rectangle(img, startPoint, endPoint, color, thickness)

# Red baloon
startPoint = (250, 20)
endPoint = (355, 145)
color = (255, 0, 0)
thickness = 2
img = cv.rectangle(img, startPoint, endPoint, color, thickness)

# Green baloon
startPoint = (375, 65)
endPoint = (475, 185)
color = (255, 0, 0)
thickness = 2
img = cv.rectangle(img, startPoint, endPoint, color, thickness)

# Orange baloon
startPoint = (490, 20)
endPoint = (590, 145)
color = (255, 0, 0)
thickness = 2
img = cv.rectangle(img, startPoint, endPoint, color, thickness)

showImg()


# EX03
def putTextToImg(img, baloonName, org):
    img = cv.putText(
        img,
        baloonName,
        org,
        cv.FONT_HERSHEY_SIMPLEX,
        0.5,
        (255, 0, 0),
        1,
        cv.LINE_AA,
    )


putTextToImg(img, "Yello Balloon", (30, 12))
putTextToImg(img, "Blue Balloon", (150, 62))
putTextToImg(img, "Red Balloon", (250, 17))
putTextToImg(img, "Green Balloon", (375, 62))
putTextToImg(img, "Orange Balloon", (490, 17))
showImg()


# EX04: Extract the yellow balloon by creating a new image of only one balloon
yellowBaloon = img[15:140, 30:135]
showYellowBaloon()


# EX05: Extract the yellow balloon automatically by using HSV color space to extract only pixels of yellow color.
hsvYellow = cv.cvtColor(img, cv.COLOR_BGR2HSV)
lower = np.array([20, 100, 100])
upper = np.array([30, 255, 255])

mask = cv.inRange(hsvYellow, lower, upper)
yellowBaloon = cv.bitwise_and(img, img, mask=mask)

showYellowBaloon()


# EX06: Re-paint the yellow balloon by replacing the pixels of yellow by green.
yellowBaloon[np.where(mask == 255)] = [0, 255, 0]
showYellowBaloon()


# EX07: Rotate the first balloon an angle of 20 degree
# rows, cols, _ = yellowBaloon.shape
# M = cv.getRotationMatrix2D((cols / 2, rows / 2), 20, 1)
# yellowBaloon = cv.warpAffine(yellowBaloon, M, (cols, rows))
# showYellowBaloon()

yellowBaloon_rgb = cv.cvtColor(yellowBaloon, cv.COLOR_BGR2RGB)
centerYellowBallon = (yellowBaloon_rgb.shape[1] // 2, yellowBaloon_rgb.shape[0] // 2)
angle = 20
scale = 1

rotationMatrix = cv.getRotationMatrix2D(centerYellowBallon, angle, scale)
rotatedYellowBaloon = cv.warpAffine(
    yellowBaloon_rgb,
    rotationMatrix,
    (yellowBaloon_rgb.shape[1], yellowBaloon_rgb.shape[0]),
)


cv.imshow("Rotated", rotatedYellowBaloon)
cv.waitKey(0)
cv.destroyAllWindows()