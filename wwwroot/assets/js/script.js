// 최신 브라우저는 CSS scroll-behavior로 자동 처리되므로,
// 이 코드는 구형 브라우저 호환용입니다.

document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});
