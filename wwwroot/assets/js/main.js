document.querySelectorAll('[data-include]').forEach(el => {
    fetch(`../components/${el.dataset.include}.html`)
        .then(r => r.text())
        .then(html => el.innerHTML = html);
});
