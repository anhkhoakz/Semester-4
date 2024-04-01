import cv2 as cv
import matplotlib.pyplot as plt
import numpy as np


img = cv.imread("img.jpg")
grayImg = cv.cvtColor(img, cv.COLOR_BGR2GRAY)


def Ex01():
    hist = cv.calcHist([grayImg], [0], None, [256], [0, 256])

    plt.plot(hist, color="black")
    plt.xlabel("Pixel Value")
    plt.ylabel("Frequency")
    plt.title("Gray Image Histogram")
    plt.show()


def Ex02():
    eqImg = cv.equalizeHist(grayImg)
    hist = cv.calcHist([eqImg], [0], None, [256], [0, 256])
    plt.plot(hist, color="black")
    plt.xlabel("Pixel Value")
    plt.ylabel("Frequency")
    plt.title("Equalized Image Histogram")
    plt.show()


def Ex03():
    noiseImg = np.zeros(grayImg.shape[:2], np.uint8)

    cv.randu(noiseImg, 0, 256)

    noisyImg = cv.add(grayImg, np.array(0.2 * noiseImg, dtype=np.uint8))

    # cv.imshow("Noise Image", noiseImg)
    # cv.waitKey(0)
    cv.imshow(" Noisy Image", noisyImg)
    cv.waitKey(0)
    cv.destroyAllWindows()


def Ex04():
    # Averaging Filter
    averaging_filter = cv.blur(grayImg, (5, 5))
    cv.imshow("Averaging Filter", averaging_filter)
    cv.waitKey(0)

    # Box Filter
    box_filter = cv.boxFilter(grayImg, -1, (5, 5))
    cv.imshow("Box Filter", box_filter)
    cv.waitKey(0)

    # Gaussian Blur
    gaussian_blur = cv.GaussianBlur(grayImg, (5, 5), 0)
    cv.imshow("Gaussian Blur", gaussian_blur)
    cv.waitKey(0)

    # Median Blur
    median_blur = cv.medianBlur(grayImg, 5)
    cv.imshow("Median Blur", median_blur)
    cv.waitKey(0)

    # Bilateral Filter
    bilateral_filter = cv.bilateralFilter(grayImg, 9, 75, 75)
    cv.imshow("Bilateral Filter", bilateral_filter)
    cv.waitKey(0)

    cv.destroyAllWindows()


def Ex05():
    # Sharpening using addWeighted
    sharpened_img = cv.addWeighted(grayImg, 1.5, grayImg, -0.5, 0)
    cv.imshow("Sharpened Image (addWeighted)", sharpened_img)
    cv.waitKey(0)

    # Sharpening using filter2D
    kernel = np.array([[-1, -1, -1], [-1, 9, -1], [-1, -1, -1]])
    sharpened_img = cv.filter2D(grayImg, -1, kernel)
    cv.imshow("Sharpened Image (filter2D)", sharpened_img)
    cv.waitKey(0)

    cv.destroyAllWindows()


def Ex06():
    cap = cv.VideoCapture("video.mp4")

    frameIds = cap.get(cv.CAP_PROP_FRAME_COUNT) * np.random.uniform(size=25)

    frames = []
    for fid in frameIds:
        cap.set(cv.CAP_PROP_POS_FRAMES, fid)
        _, frame = cap.read()
        frames.append(frame)

    medianFrame = np.median(frames, axis=0).astype(dtype=np.uint8)

    cv.imshow("frame", medianFrame)
    cv.waitKey(0)
    cv.destroyAllWindows()


def Ex07():
    fgbg = cv.createBackgroundSubtractorMOG2()
    fgmask = fgbg.apply(grayImg)
    cv.imshow("Foreground Mask", fgmask)
    cv.waitKey(0)
    cv.destroyAllWindows()


# Ex01()
# Ex02()
# Ex03()
# Ex04()
# Ex05()
# Ex06()
# Ex07()
