import cv2

imagePath = "imgs/fruits.png"
image = cv2.imread(imagePath)

m, n, _ = image.shape

avgI = 0

for r in range(m):
    for c in range(n):
        avgI += image[r, c].mean()

avgI /= m + n

print(avgI)

# cv2.imshow('Image', image)
# cv2.waitKey(0)
# cv2.destroyAllWindows()
