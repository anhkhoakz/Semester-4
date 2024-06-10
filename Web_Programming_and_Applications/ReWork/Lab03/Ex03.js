function updateText(message) {
    let alertMessage = document.getElementsByClassName("alert-success")[0];

    alertMessage.innerHTML =
        message ||
        "This text will be changed immediately when typing new text.";
}

function updateColor(color) {
    let alertMessage = document.getElementsByClassName("alert-success")[0];
    alertMessage.style.color = color;
}

function changeTextStyle() {
    let alertMessage = document.getElementsByClassName("alert-success")[0];
    let isBold = document.getElementById("bold").checked;
    let isItalic = document.getElementById("italic").checked;
    let isUnderline = document.getElementById("underline").checked;

    alertMessage.style.fontWeight = isBold ? "bold" : "normal";
    alertMessage.style.fontStyle = isItalic ? "italic" : "normal";
    alertMessage.style.textDecoration = isUnderline ? "underline" : "none";
}

function restoreDefault() {
    document.getElementById("message").value = "";
    document.getElementById("color").selectedIndex = 0;
    document.getElementById("bold").checked = false;
    document.getElementById("italic").checked = false;
    document.getElementById("underline").checked = false;
    updateText("");
    updateColor("black");
    changeTextStyle();
}
