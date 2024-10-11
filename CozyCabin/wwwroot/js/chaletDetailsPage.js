document.addEventListener('DOMContentLoaded', () => {
    let currentIndex = 0;
    const slides = document.querySelectorAll('.carousel-item');
    const thumbnails = document.querySelectorAll('.thumbnail');
    const thumbnailWrapper = document.querySelector('.thumbnails-wrapper');

    function showSlide(index) {
        if (index >= slides.length) {
            currentIndex = 0;
        } else if (index < 0) {
            currentIndex = slides.length - 1;
        } else {
            currentIndex = index;
        }

        slides.forEach((slide, i) => {
            slide.classList.remove('active');
            if (i === currentIndex) {
                slide.classList.add('active');
            }
        });

        updateThumbnailScroll();
    }

    function nextSlide() {
        showSlide(currentIndex + 1);
    }

    function prevSlide() {
        showSlide(currentIndex - 1);
    }

    function changeMainImage(index) {
        showSlide(index);
    }

    function scrollThumbnails(direction) {
        const scrollAmount = 80; // Adjust this value as needed
        thumbnailWrapper.scrollBy({
            top: 0,
            left: direction * scrollAmount,
            behavior: 'smooth'
        });
    }

    function updateThumbnailScroll() {
        const thumbnail = thumbnails[currentIndex];
        const thumbnailOffset = thumbnail.offsetLeft + thumbnail.offsetWidth / 2;
        const wrapperCenter = thumbnailWrapper.offsetWidth / 2;

        thumbnailWrapper.scrollLeft = thumbnailOffset - wrapperCenter;

        // Update selected thumbnail style
        thumbnails.forEach((thumb) => thumb.classList.remove('selected'));
        thumbnail.classList.add('selected');
    }

    // Initialize the first slide
    showSlide(currentIndex);

    // Attach event listeners to the thumbnail images
    thumbnails.forEach((thumbnail, index) => {
        thumbnail.addEventListener('click', () => {
            changeMainImage(index);
        });
    });

    // Attach event listeners to the carousel buttons
    document.querySelector('.carousel-button.prev').addEventListener('click', prevSlide);
    document.querySelector('.carousel-button.next').addEventListener('click', nextSlide);
    document.querySelector('.thumb-nav.prev').addEventListener('click', () => scrollThumbnails(-1));
    document.querySelector('.thumb-nav.next').addEventListener('click', () => scrollThumbnails(1));



});
