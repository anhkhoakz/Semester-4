import cv2
import numpy as np


img = cv2.imread("./imgs/sudoku-original.jpg")


def edge_etection():
    cv2.imshow("Original", img)
    cv2.waitKey(0)

    img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    img_blur = cv2.GaussianBlur(img_gray, (3, 3), 0)

    # sobelx = cv2.Sobel(src=img_blur, ddepth=cv2.CV_64F, dx=1, dy=0, ksize=5)
    # sobely = cv2.Sobel(src=img_blur, ddepth=cv2.CV_64F, dx=0, dy=1, ksize=5)
    # sobelxy = cv2.Sobel(src=img_blur, ddepth=cv2.CV_64F, dx=1, dy=1, ksize=5)
    # cv2.imshow("Sobel X", sobelx)
    # cv2.waitKey(0)
    # cv2.imshow("Sobel Y", sobely)
    # cv2.waitKey(0)
    # cv2.imshow("Sobel X Y using Sobel() function", sobelxy)
    # cv2.waitKey(0)

    edges = cv2.Canny(image=img_blur, threshold1=100, threshold2=200)
    cv2.imshow("Canny Edge Detection", edges)
    cv2.waitKey(0)

    cv2.destroyAllWindows()


def hough_line_transform():
    img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    dst = cv2.Canny(img_gray, 50, 200, None, 3)

    cdst = cv2.cvtColor(dst, cv2.COLOR_GRAY2BGR)
    cdstP = np.copy(cdst)

    lines = cv2.HoughLines(dst, 1, np.pi / 180, 150, None, 0, 0)

    if lines is not None:
        for i in range(0, len(lines)):
            rho = lines[i][0][0]
            theta = lines[i][0][1]
            a = np.cos(theta)
            b = np.sin(theta)
            x0 = a * rho
            y0 = b * rho
            pt1 = (int(x0 + 1000 * (-b)), int(y0 + 1000 * (a)))
            pt2 = (int(x0 - 1000 * (-b)), int(y0 - 1000 * (a)))
            cv2.line(cdst, pt1, pt2, (0, 0, 255), 3, cv2.LINE_AA)

    linesP = cv2.HoughLinesP(dst, 1, np.pi / 180, 50, None, 50, 10)

    if linesP is not None:
        for i in range(0, len(linesP)):
            line = linesP[i][0]
            cv2.line(
                cdstP,
                (line[0], line[1]),
                (line[2], line[3]),
                (0, 0, 255),
                3,
                cv2.LINE_AA,
            )

    cv2.imshow("Source", img)
    cv2.waitKey(0)

    cv2.imshow("Detected Lines (in red) - Standard Hough Line Transform", cdst)
    cv2.waitKey(0)

    cv2.imshow("Detected Lines (in red) - Probabilistic Line Transform", cdstP)
    cv2.waitKey(0)

    cv2.destroyAllWindows()


def hough_circle_transform():
    src = cv2.imread("./imgs/hough_circles_demo_01.png")
    cv2.imshow("Source", src)
    cv2.waitKey(0)

    gray = cv2.cvtColor(src, cv2.COLOR_BGR2GRAY)

    gray = cv2.medianBlur(gray, 5)

    rows = gray.shape[0]
    circles = cv2.HoughCircles(
        gray,
        cv2.HOUGH_GRADIENT,
        1,
        rows / 8,
        param1=100,
        param2=30,
        minRadius=1,
        maxRadius=30,
    )

    if circles is not None:
        circles = np.uint16(np.around(circles))
        for i in circles[0, :]:
            center = (i[0], i[1])
            cv2.circle(src, center, 1, (0, 100, 100), 3)
            radius = i[2]
            cv2.circle(src, center, radius, (255, 0, 255), 3)

    cv2.imshow("detected circles", src)
    cv2.waitKey(0)


edge_etection()
hough_line_transform()
hough_circle_transform()
