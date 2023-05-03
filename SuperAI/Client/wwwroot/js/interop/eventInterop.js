function handleCompositionStart(element, dotNetHelper) {
    element.addEventListener("compositionstart", function () {
        dotNetHelper.invokeMethodAsync("CompositionStarted");
    });
}

function handleCompositionEnd(element, dotNetHelper) {
    element.addEventListener("compositionend", function () {
        dotNetHelper.invokeMethodAsync("CompositionEnded");
    });
}

export {
    handleCompositionStart, handleCompositionEnd
}