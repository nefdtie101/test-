function printDivToPdf(divId, fileName) {
    var element = document.getElementById(divId);

    // Send the HTML content to the server for PDF conversion
    DotNet.invokeMethodAsync('YourProjectNamespace', 'ConvertHtmlToPdf', element.innerHTML, fileName);
}