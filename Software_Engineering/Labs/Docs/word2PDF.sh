#!/bin/zsh

# Set the directory to the current directory
docx_directory=$(pwd)

# Check if Pandoc is installed
if ! command -v pandoc &> /dev/null; then
    echo "Pandoc is not installed. Please install Pandoc to proceed."
    exit 1
fi

# Convert each .docx file to PDF
for docx_file in "$docx_directory"/*.docx; do
    # Get the filename without the extension
    filename=$(basename -- "$docx_file")
    filename_no_extension="${filename%.*}"

    # Convert the .docx file to PDF
    pandoc --pdf-engine=xelatex "$docx_file" -o "$docx_directory"/"$filename_no_extension".pdf

    # Check if conversion was successful
    if [ $? -eq 0 ]; then
        echo "Converted $filename to PDF successfully."
    else
        echo "Error converting $filename to PDF."
    fi
done

echo "All .docx files in $docx_directory converted to PDF."
