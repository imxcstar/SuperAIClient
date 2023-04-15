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

async function setupScrollListener(element, dotnetHelper) {
    element.addEventListener('scroll', () => {
        const { scrollTop, scrollHeight, clientHeight } = element;
        const shouldAutoScroll = scrollTop + clientHeight + 80 >= scrollHeight;
        dotnetHelper.invokeMethodAsync('SetShouldAutoScroll', shouldAutoScroll);
    });
}

async function scrollToBottom(element) {
    element.scrollTop = element.scrollHeight;
}

async function scrollToBottomAndWaitElement(element, awitElementId, minHeight) {
    const waitElement = document.getElementById(awitElementId);

    if (waitElement && waitElement.offsetHeight >= minHeight) {
        element.scrollTop = element.scrollHeight;
    } else {
        waitForElement(awitElementId, minHeight, (waitElement) => {
            element.scrollTop = element.scrollHeight;
        });
    }
}

export {
    scrollToElementBottom, setupScrollListener, scrollToBottom, scrollToBottomAndWaitElement
}
