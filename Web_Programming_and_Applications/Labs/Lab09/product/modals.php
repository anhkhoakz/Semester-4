<!-- Edit product modal -->
<div class="modal fade" id="edit-product-modal" tabindex="-1" aria-labelledby="edit-product-modal" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h1 class="modal-title fs-5" id="edit-product-title">Product</h1>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                <form id="edit-product-form">
                    <div class="form-group">
                        <label for="product-id" class="col-form-label">ID:</label>
                        <input type="text" class="form-control" id="product-id" readonly>
                    </div>
                    <div class="form-group">
                        <label for="product-name" class="col-form-label">Name:</label>
                        <input type="text" class="form-control" id="product-name">
                    </div>
                    <div class="form-group">
                        <label for="product-price" class="col-form-label">Price:</label>
                        <input type="text" class="form-control" id="product-price">
                    </div>
                    <div class="form-group">
                        <label for="product-description" class="col-form-label">Description:</label>
                        <textarea class="form-control" id="product-description"></textarea>
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                <button type="button" class="btn btn-primary" id="save-product-btn" onclick="updateProduct()">Save information</button>
            </div>
        </div>
    </div>
</div>

<!-- Add product modal -->
<div class="modal fade" id="add-product-modal" tabindex="-1" aria-labelledby="add-product-modal" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h1 class="modal-title fs-5" id="add-product-title">New Product</h1>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                <form id="add-product-form">
                    <div class="form-group">
                        <label for="product-name-add" class="col-form-label">Name:</label>
                        <input type="text" class="form-control" id="product-name-add">
                    </div>
                    <div class="form-group">
                        <label for="product-price-add" class="col-form-label">Price:</label>
                        <input type="text" class="form-control" id="product-price-add">
                    </div>
                    <div class="form-group">
                        <label for="product-description-add" class="col-form-label">Description:</label>
                        <textarea class="form-control" id="product-description-add"></textarea>
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                <button type="button" class="btn btn-primary" id="save-product-btn" onclick="addProduct()">Save information</button>
            </div>
        </div>
    </div>
</div>