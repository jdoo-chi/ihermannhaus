// �ֽ� �������� CSS scroll-behavior�� �ڵ� ó���ǹǷ�,
// �� �ڵ�� ���� ������ ȣȯ���Դϴ�.

document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});
