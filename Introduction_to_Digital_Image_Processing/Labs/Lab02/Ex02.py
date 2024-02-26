import cv2 as cv
import numpy as np

def increase_brightness(img, value=30):
    hsv = cv.cvtColor(img, cv.COLOR_BGR2HSV)
    h, s, v = cv.split(hsv)

    lim = 255 - value
    v[v > lim] = 255
    v[v <= lim] += value

    final_hsv = cv.merge((h, s, v))
    img = cv.cvtColor(final_hsv, cv.COLOR_HSV2BGR)
    return img

def showImg(image, content='Default'):
    cv.imshow(content, image)
    cv.waitKey(0)
    cv.destroyAllWindows()

img = cv.imread('Koba_Planet_of_Apes.jpeg')
showImg(img)

IncreasedImage = increase_brightness(img, 100)
showImg(IncreasedImage)

grayScaleImg = cv.imread('Koba_Planet_of_Apes.jpeg', cv.IMREAD_GRAYSCALE)
equalizedImg= cv.equalizeHist(grayScaleImg)
# result= np.hstack()
showImg(equalizedImg)

clahe = cv.createCLAHE(clipLimit=2.0, tileGridSize=(8,8))
cl1 = clahe.apply(grayScaleImg)
showImg(cl1)