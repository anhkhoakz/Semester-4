document.addEventListener("DOMContentLoaded", function () {
    let rawMessage = document.getElementById("message");
    let rawColor = document.getElementById("color");
    let rawBold = document.getElementById("bold");
    let rawItalic = document.getElementById("italic");
    let rawUnderline = document.getElementById("underline");
    let restoreButton = document.querySelector("button.btn-success");
    let rawText = document.getElementById("display-text");

    function updateDisplayText() {
        let text = rawMessage.value;
        let color = rawColor.value.toLowerCase();
        let style = "";
        let isBold = rawBold.checked;
        let isItalic = rawItalic.checked;
        let isUnderline = rawUnderline.checked;

        if (isBold) style += "bold";
        if (isItalic) style += "italic ";
        if (isUnderline) style += "underline ";

        rawText.textContent =
            text ||
            "This text will be changed immediately when typing new text.";
        rawText.style.color = color || "black";
        rawText.style.fontWeight = isBold ? "bold" : "normal";
        rawText.style.fontStyle = isItalic ? "italic" : "normal";
        rawText.style.textDecoration = isUnderline ? "underline" : "none";
    }

    rawMessage.addEventListener("input", updateDisplayText);
    rawColor.addEventListener("change", updateDisplayText);
    rawBold.addEventListener("change", updateDisplayText);
    rawItalic.addEventListener("change", updateDisplayText);
    rawUnderline.addEventListener("change", updateDisplayText);

    restoreButton.addEventListener("click", function () {
        rawMessage.value = "";
        rawColor.value = "Black";
        isBold = false;
        isItalic = false;
        isUnderline = false;
        displayText = document.getElementById("display-text");
        displayText.textContent =
            "This text will be changed immediately when typing new text.";
        updateDisplayText();
    });

    updateDisplayText();
});
