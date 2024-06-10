<div class="modal fade" id="new-text-file-dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Create New Text File</h4>
                <button type="button" class="close" data-dismiss="modal">&times;</button>
            </div>
            <div class="modal-body">
                <div class="form-group">
                    <label for="file-name">File Name</label>
                    <input type="text" placeholder="File name" class="form-control" id="file-name" />
                </div>
                <div class="form-group">
                    <label for="file-content">Content</label>
                    <textarea rows="10" id="file-content" class="form-control" placeholder="Content"></textarea>
                </div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancel</button>
                <button type="button" class="btn btn-success" id="createFileBtn">Create</button>
            </div>
        </div>
    </div>
</div>