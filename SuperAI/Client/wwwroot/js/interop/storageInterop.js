function setItem(key, value) {
    localStorage.setItem(key, value);
}

function getItem(key) {
    return localStorage.getItem(key);
}

function removeItem(key) {
    localStorage.removeItem(key);
}

function clear() {
    localStorage.clear();
}

export {
    setItem,
    getItem,
    removeItem,
    clear
}