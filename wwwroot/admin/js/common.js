'use strict';

/**
 * @see HeaderSearch
 * @see ModuleSearch
 * @see Sidebar
 * @see SidebarPanel
 * @see SwitcherGroup
 * @see CheckboxToggle
 * @see Tag
 * @see ChartProgressCircle
 * @see Charts
 * @see Echart
 * @see Checkboxes
 * @see ImageUpload
 * @see ProfileUpload
 * @see CalendarInline
 * @see CalendarFull
 * @see Inbox
 * @see Chat
 * @see Todo
 * @see Timeline
 * @see Pagination
 * @see InputSelects
 * @see InputTags
 * @see Modal
 * @see DropdownSelect
 * @see AddProduct
 * @see OrderTabs
 * @see ScrollTo
 */

const isTouchDevices = ('ontouchstart' in window) || (window.DocumentTouch && document instanceof window.DocumentTouch);
const body = document.querySelector('body');

const delay = time => {
    return new Promise(resolve => setTimeout(resolve, time));
};

const triggerEvent = (typeEvent, elem, bubbles = true) => {
    let event;

    if (typeEvent === 'click') {
        event = new MouseEvent('click', {
            bubbles,
            cancelable: true,
            view: window
        });
    }

    const canceled = !elem.dispatchEvent(event);
};

const themeStyle = (a, b, cssVariable = true) => {
    const theme = document.querySelector('html').getAttribute('data-theme');

    const getStyle = color => {
        return getComputedStyle(document.documentElement).getPropertyValue(color);
    };

    if (typeof b !== 'undefined' && b !== '') {
        if (theme === 'light') {
            return cssVariable ? getStyle(a) : a;
        }

        if (theme === 'dark') {
            return cssVariable ? getStyle(b) : b;
        }
    }

    if ((typeof b === 'undefined' || b === '') && !cssVariable) {
        return a;
    }

    return getStyle(a);
};

const imgLoaded = imagesLoaded(document.querySelector('body'));
const timeline = new Timeline();

$(function () {
    if (isTouchDevices) document.querySelector('html').classList.add('is-touch');

    imgLoaded.on('always', () => {
        setTimeout(() => {
            body.classList.add('load');
            chart();
            timeline.init();
        }, 300);
    });

    window.addEventListener('resize', () => {
        timeline.resize();
    });

    document.querySelectorAll('[data-simplebar]').forEach(el => {
        const simpleBar = new SimpleBar(el);

        simpleBar.recalculate();
    });

    document.querySelectorAll('.js-dropdown-select').forEach(el => {
        const element = el;

        new DropdownSelect(element);
    });

    document.querySelectorAll('.items-more__button').forEach(el => {
        const button = el;

        if (button) {
            button.addEventListener('click', () => button.focus());
        }
    });

    new HeaderSearch();
    new ModuleSearch();
    new Sidebar();
    new SidebarPanel();
    new SwitcherGroup();
    new CheckboxToggle();
    new Tag();
    tooltip();
    form();
    formEditor();
    map();
    new Checkboxes();
    new ImageUpload();
    new ProfileUpload();
    new CalendarInline('#calendarOne');
    new CalendarFull();
    new Inbox();
    new Chat();
    new Todo();
    new Pagination();
    new InputSelects('.js-input-select');
    new InputTags('.js-input-tags');
    new Modal();
    new AddProduct();
    new OrderTabs();
    new ScrollTo();
    scrolls();
}());

$("document").ready(function () {
    $("input[type=file]").on("change", function () {
        var $files = $(this).get(0).files;
        if ($files.length) {
        if ($files[0].size > $(this).data("max-size") * 1024) {
            console.log("Vui lòng chọn file có dung lượng nhỏ hơn!");
            return false;
        }

        console.log("Đang upload hình ảnh lên imgur...");
        var apiUrl = "https://api.imgur.com/3/image";
        var apiKey = "dcd0ee22791c49d";
        var settings = {
            async: false,
            crossDomain: true,
            processData: false,
            contentType: false,
            type: "POST",
            url: apiUrl,
            headers: {
            Authorization: "Client-ID " + apiKey,
            Accept: "application/json",
            },
            mimeType: "multipart/form-data",
        };
        var formData = new FormData();
        formData.append("image", $files[0]);
        settings.data = formData;
        $.ajax(settings).done(function (response) {
            console.log(response);
            var obj = JSON.parse(response);
            document.getElementById("category__preview-image").href = obj.data.link;
            document.getElementById("category__preview-input").value = obj.data.link;
            document.getElementById("category__preview-image").style.display = "block";

            if ($('#editCategory').hasClass('is-active')) {
                document.getElementById("categoryImage").value = obj.data.link;
                document.getElementById("categoryEditImage").href = obj.data.link;
            }
            obj.data.link;
        });
        }
    });
});


$(function(){
    $(".category-edit").click(function(){
       $('#categoryId').val($(this).data('cate-id'));
       $('#categoryName').val($(this).data('cate-name'));
       $('#categoryImage').val($(this).data('cate-image'));
       $('#categoryEditImage').attr("href", $(this).data('cate-image'));
       $('#editCateForm').attr("action", "category/edit/" + $(this).data('cate-id'));
    });
  });


  $(function(){
    $(".category-delete").click(function(){
       $('#deleteCateForm').attr("action", "category/delete/11");
    });
  });  
