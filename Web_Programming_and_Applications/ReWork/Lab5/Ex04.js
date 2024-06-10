let products = [];

async function loadProducts() {
    let response = await fetch("Ex04.json");
    products = await response.json();

    displayProducts(products);
}

loadProducts();

function displayProducts(products) {
    let product_table = document.getElementById("product-table");
    let tbody = product_table.querySelector("tbody");
    tbody.innerHTML = "";

    products.forEach((product) => {
        let tr = document.createElement("tr");
        tr.innerHTML = `
            <td>${product.id}</td>
            <td>${product.name}</td>
            <td>${product.price}</td>
            <td>${product.description}</td>
            <td><button onclick="addToCart(${product.id})">Add to cart</button></td>
        `;
        tbody.appendChild(tr);
    });
}

async function addToCart(productID) {
    let product = products.find((product) => product.id === productID);

    let cart_table = document.getElementById("cart-table");
    let tbody = cart_table.querySelector("tbody");

    let rows = Array.from(tbody.rows);
    let existingProduct = rows.find(
        (row) => row.cells[0].textContent === product.id.toString()
    );

    if (existingProduct) {
        let quantity = parseInt(existingProduct.cells[3].textContent) + 1;
        let quantityCell = existingProduct.cells[3];
        let totalPriceCell = existingProduct.cells[4];

        quantityCell.textContent = quantity;
        totalPriceCell.textContent = quantity * product.price;
    } else {
        let tr = document.createElement("tr");
        tr.innerHTML = `
            <td>${product.id}</td>
            <td>${product.name}</td>
            <td>${product.price}</td>
            <td>1</td>
            <td>${product.price}</td>
            <td>
                <button>+</button>
                <button>-</button>
                <button onclick="removeFromCart(${product.id})">Remove</button>
            </td>
        `;
        tbody.appendChild(tr);
    }

    displayTotalInfo();
}

function removeFromCart(productID) {
    let cart_table = document.getElementById("cart-table");
    let tbody = cart_table.querySelector("tbody");

    let rows = Array.from(tbody.rows);
    let product = rows.find(
        (row) => row.cells[0].textContent === productID.toString()
    );

    if (product) {
        tbody.removeChild(product);
    }

    displayTotalInfo();
}

function displayTotalInfo() {
    let quantityIndex = 3;
    let priceIndex = 4;

    let totalQuantity = calculateTotal(quantityIndex);
    let totalPrice = calculateTotal(priceIndex);

    let totalQuantityCell = document.getElementById("total-quantity");
    let totalPriceCell = document.getElementById("total-price");

    totalQuantityCell.textContent = totalQuantity;
    totalPriceCell.textContent = totalPrice;
}

function calculateTotal(columnIndex) {
    let cart_table = document.getElementById("cart-table");
    let tbody = cart_table.querySelector("tbody");

    let rows = tbody.rows;
    let total = 0;

    for (let i = 0; i < rows.length; i++) {
        let cell = rows[i].cells[columnIndex];
        total += parseFloat(cell.textContent);
    }

    return total;
}
