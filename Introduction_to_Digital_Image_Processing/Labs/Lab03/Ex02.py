import cv2 as cv

src1 = cv.imread("./img1.png")
src2 = cv.imread("./img2.png")
src2 = cv.resize(src2, src1.shape[1::-1])

dst = cv.addWeighted(src1, 0.5, src2, 0.5, 0)
cv.imshow("Blended Img", dst)
cv.waitKey(0)
cv.destroyAllWindows()
cv.imwrite("Ex02_ouput.png", dst)
