function waitForElement(elementId, minHeight, callback) {
    const observer = new MutationObserver((mutationsList, observer) => {
        for (const mutation of mutationsList) {
            if (mutation.type === 'childList') {
                const element = document.getElementById(elementId);
                if (element && element.offsetHeight >= minHeight) {
                    callback(element);
                    observer.disconnect();
                    break;
                }
            }
        }
    });

    observer.observe(document.body, { childList: true, subtree: true });
}

async function scrollToElementBottom(elementId, minHeight) {
    const element = document.getElementById(elementId);

    if (element && element.offsetHeight >= minHeight) {
        element.scrollIntoView({ behavior: 'smooth', block: 'end' });
    } else {
        waitForElement(elementId, minHeight, (element) => {
            element.scrollIntoView({ behavior: 'smooth', block: 'end' });
        });
    }
}

export {
    scrollToElementBottom
}
