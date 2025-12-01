document.addEventListener('DOMContentLoaded', () => {
    const observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('in-view');
            }
        });
    }, { threshold: 0.2 });

    document.querySelectorAll('.panel, .tile, .feature, .pricing-card, .contact-card').forEach(el => observer.observe(el));

    const glow = document.querySelector('.glow');
    if (glow) {
        document.addEventListener('pointermove', (e) => {
            const x = (e.clientX / window.innerWidth) * 100;
            const y = (e.clientY / window.innerHeight) * 100;
            glow.style.background = `radial-gradient(circle at ${x}% ${y}%, rgba(130, 162, 255, 0.25), transparent 55%),` +
                `radial-gradient(circle at ${100 - x}% ${y / 2}%, rgba(240, 156, 255, 0.3), transparent 60%)`;
        });
    }

    document.querySelectorAll('.tile').forEach(tile => {
        tile.addEventListener('mousemove', (e) => {
            const { left, top, width, height } = tile.getBoundingClientRect();
            const x = (e.clientX - left - width / 2) / width * 8;
            const y = (e.clientY - top - height / 2) / height * 8;
            tile.style.transform = `rotateY(${x}deg) rotateX(${-y}deg) translateY(-6px)`;
        });
        tile.addEventListener('mouseleave', () => {
            tile.style.transform = '';
        });
    });

    const topbar = document.querySelector('.topbar');
    let lastScroll = 0;
    window.addEventListener('scroll', () => {
        const current = window.scrollY;
        if (topbar) {
            topbar.style.opacity = current > lastScroll ? 0.9 : 1;
        }
        lastScroll = current;
    });
});
