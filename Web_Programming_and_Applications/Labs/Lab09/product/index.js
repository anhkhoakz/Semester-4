function loadProducts() {
    let xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            let response = JSON.parse(this.responseText);
            displayProduct(response);
        }
    };
    xmlhttp.open("GET", "http://localhost/functions/get_products.php", true);
    xmlhttp.send();
}

loadProducts();

function displayProduct(products) {
    let product_body = document.getElementById("product-body");
    product_body.innerHTML = "";

    products.forEach(function (product) {
        let id = product.id;
        let name = product.name;
        let price = product.price;
        let description = product.description;

        let tr = document.createElement("tr");
        tr.innerHTML = `
            <td>${id}</td>
            <td>${name}</td>
            <td>${price}</td>
            <td>${description}</td>
            <td>
                <button class="btn btn-sm btn-danger" onclick="deleteProduct(${id})">
                    <i class="fas fa-trash"></i>
                </button>
                
                <button type="button" class="btn btn-sm btn-primary" data-bs-toggle="modal" data-bs-target="#edit-product-modal" onclick="editProduct(${id})" >
                    <i class="fas fa-pen"></i>
                </button>
            </td>
        `;

        product_body.appendChild(tr);
    });
}

function deleteProduct(id) {
    let data = {
        id: id,
    };

    let xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4) {
            if (this.status == 200) {
                loadProducts();
            } else {
                console.error("Error deleting product: " + this.status);
            }
        }
    };
    xmlhttp.open(
        "DELETE",
        "http://localhost/functions/delete_product.php",
        true
    );
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xmlhttp.send(JSON.stringify(data));
}

function editProduct(id) {
    let xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            let product = JSON.parse(this.responseText);
            displayEditProductForm(product);
        }
    };
    xmlhttp.open(
        "GET",
        "http://localhost/functions/get_product.php?id=" + id,
        true
    );
    xmlhttp.send();
}

function displayEditProductForm(product) {
    let id = product.id;
    let name = product.name;
    let price = product.price;
    let description = product.description;

    let product_id = document.getElementById("product-id");
    let product_name = document.getElementById("product-name");
    let product_price = document.getElementById("product-price");
    let product_description = document.getElementById("product-description");
    let product_name_title = document.getElementById("edit-product-title");

    product_id.value = id;
    product_name.value = name;
    product_price.value = price;
    product_description.value = description;
    product_name_title.innerHTML = name;
}

function updateProduct() {
    let product_id = document.getElementById("product-id").value;
    let product_name = document.getElementById("product-name").value;
    let product_price = document.getElementById("product-price").value;
    let product_description = document.getElementById(
        "product-description"
    ).value;

    let data = {
        id: product_id,
        name: product_name,
        price: product_price,
        description: product_description,
    };

    let xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4) {
            if (this.status == 200) {
                $("#edit-product-modal").modal("hide");
                loadProducts();
            } else {
                console.error("Error updating product: " + this.status);
            }
        }
    };
    xmlhttp.open("PUT", "http://localhost/functions/update_product.php", true);
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xmlhttp.send(JSON.stringify(data));
}

function addProduct() {
    let product_name = document.getElementById("product-name-add").value;
    let product_price = document.getElementById("product-price-add").value;
    let product_description = document.getElementById(
        "product-description-add"
    ).value;

    let data = {
        name: product_name,
        price: product_price,
        description: product_description,
    };

    let xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4) {
            if (this.status == 200) {
                $("#add-product-modal").modal("hide");
                loadProducts();
            } else {
                console.error("Error adding product: " + this.status);
            }
        }
    };
    xmlhttp.open("POST", "http://localhost/functions/add_product.php", true);
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xmlhttp.send(JSON.stringify(data));
}
