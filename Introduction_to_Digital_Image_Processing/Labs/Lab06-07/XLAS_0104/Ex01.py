import cv2 as cv
import numpy as np

cap = cv.VideoCapture(0)
backgroundobject = cv.createBackgroundSubtractorMOG2(history=2, detectShadows=True)

while True:
    ret, frame = cap.read()
    if not ret:
        break

    fgmask = backgroundobject.apply(frame)

    real_part = cv.bitwise_and(frame, frame, mask=fgmask)

    fgmask_3 = cv.cvtColor(fgmask, cv.COLOR_GRAY2BGR)

    stacked = np.hstack((fgmask_3, frame, real_part))
    cv.imshow("Motion Detection", cv.resize(stacked, None, fx=0.65, fy=0.65))

    k = cv.waitKey(30) & 0xFF
    if k == 27:
        break

cap.release()
cv.destroyAllWindows()
