let products = [];

async function fetchProducts() {
    let response = await fetch("./Ex05.json");
    products = await response.json();

    displayProducts(products);
}

fetchProducts();

function displayProducts(products) {
    let product_table = document.getElementById("productTable");
    let tbody = product_table.querySelector("tbody");
    tbody.innerHTML = "";

    products.forEach((product) => {
        let tr = document.createElement("tr");
        tr.innerHTML = `
            <td>
                <img src="${product.image}" alt="${product.name}" loading="lazy">
            </td>
            <td>${product.name}</td>
            <td>${product.price}</td>
            <td>${product.description}</td>
        `;
        tbody.appendChild(tr);
    });
}

function searchProducts() {
    let searchBox = document.getElementById("searchBox");
    let keyword = searchBox.value.toLowerCase();

    let productTable = document.getElementById("productTable");
    let productRows = productTable.querySelectorAll("tr");

    console.log(productRows);

    productRows.forEach((product) => {
        let productName = product
            .getElementsByTagName("td")[1]
            ?.textContent.toLowerCase();

        let productPrice = product
            .getElementsByTagName("td")[2]
            ?.textContent.toLowerCase();

        let productDescription = product
            .getElementsByTagName("td")[3]
            ?.textContent.toLowerCase();

        if (
            productName?.includes(keyword) ||
            productPrice?.includes(keyword) ||
            productDescription?.includes(keyword)
        ) {
            product.style.display = "";
        } else {
            product.style.display = "none";
        }
    });

    noMatchMessage(productRows);
}

function noMatchMessage(productRows) {
    let noMatchMessage = document.getElementById("noMatchMessage");

    if (
        productTable.querySelectorAll("tbody tr[style='display: none;']")
            .length ===
        productRows.length - 1
    ) {
        noMatchMessage.textContent = "No matching products found.";
    } else {
        noMatchMessage.textContent = "";
    }
}
