for file in .; do
    pandoc "$file" -o "${file%.pptx}.pdf"
done
