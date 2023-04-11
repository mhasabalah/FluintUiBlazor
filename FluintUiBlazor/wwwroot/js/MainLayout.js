function isDevice() {
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}

function switchHighlightStyle(dark) {
    if (dark) {
        document
            .querySelector(`link[title="dark"]`)
            .removeAttribute("disabled");
        document
            .querySelector(`link[title="light"]`)
            .setAttribute("disabled", "disabled");
    }
    else {
        document
            .querySelector(`link[title="light"]`)
            .removeAttribute("disabled");
        document
            .querySelector(`link[title="dark"]`)
            .setAttribute("disabled", "disabled");
    }
}

function isDarkMode() {
    let matched = window.matchMedia("(prefers-color-scheme: dark)").matches;

    if (matched)
        return true;
    else
        return false;
}

function switchDirection(dir) {
    document.dir = dir;
}