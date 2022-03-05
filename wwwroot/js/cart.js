let cart = [];

const addBtn = document.querySelectorAll(".add-to-cart");
const cartIcon = document.querySelectorAll(".cartIcon");
const cartRemove = document.querySelectorAll(".remove-cart");

const checkCartItem = (id) => {
    let flag = 0;
    for (let indexItem in cart) {
        if (cart[indexItem].id === id) {
            flag = indexItem;
        }   
    }
    return flag;
}

addBtn.forEach((item, index) => {
    item.addEventListener("click", () => {
        let productImage = item.childNodes[1].value;
        let productId = item.childNodes[3].value;
        let productName = item.childNodes[5].value;
        let productPrice = item.childNodes[7].value;
        let quantiy = 1;

        let flag = true;

        let newProduct = {
            "id": productId,
            "image": productImage,
            "name": productName,
            "price": productPrice,
            "quantity": quantiy
        }

        if (cart.length === 0) {
            cart.push(newProduct);
        }
        else {
            let indexOfItem = checkCartItem(newProduct.id);
            if (indexOfItem !== 0) {
                cart[indexOfItem].quantity++;
            }
            else {
                cart.push(newProduct);
            }
        }
        localStorage.setItem("cart", JSON.stringify(cart));

        if (flag == true) {
            document.querySelectorAll(".header-action-num").forEach((item, index) => {
                let cartSize = JSON.parse(localStorage.getItem("cart")).length;
                if (cartSize != 0) {
                    if (cartSize < 10) {
                        item.innerHTML = "0" + cartSize;
                    }
                    else {
                        item.innerHTML = cartSize;
                    }
                }
                else {
                    item.innerHTML = "";
                    item.style.backgroundColor = "transparent";
                }
            })
        }
    })
})

cartIcon.forEach((item, index) => {
    item.addEventListener("click", () => {
        let cartFromLocal = JSON.parse(localStorage.getItem("cart"));
        let cartInsert = document.getElementById("cartListMain");
        cartInsert.innerHTML = "";

        let subTotal = 0;
        let cartEcoTax = 0;
        let cartVAT = 0;
        let cartTotal = 0;

        for (let cartItem of cartFromLocal) {
            cartInsert.insertAdjacentHTML("afterbegin", 
            `<li>
                <a href="single-product.html" class="image"><img src="${cartItem.image}" alt="Cart product Image"></a>
                <div class="content">
                    <a href="single-product.html" class="title">${cartItem.name}</a>
                    <span class="quantity-price">${cartItem.quantity} x <span class="amount">$${cartItem.price}</span></span>
                    <button id="cartRemove" class="remove remove-cart">×
                        <input type="hidden" value="${cartItem.id}"/>
                    </button>
                </div>
            </li>`
            )

            subTotal += cartItem.price * cartItem.quantity;
            cartEcoTax = subTotal * 0.02;
            cartVAT = subTotal * 0.08;
            cartTotal = subTotal + cartEcoTax + cartVAT;
        }

        document.getElementById("cartSubTotal").innerHTML = subTotal + " VND";
        document.getElementById("cartEcoTax").innerHTML = cartEcoTax + " VND";
        document.getElementById("cartVAT").innerHTML = cartVAT + " VND";
        document.getElementById("cartTotal").innerHTML = cartTotal + " VND";
        
    })
})

// cartRemove.forEach((item, index) => {
//     item.addEventListener("click", (e) => {
//         if(e.target && e.target.id== 'brnPrepend'){
//             console.log("a")
//        }
//     })
// })

document.addEventListener('click',function(e){
    let itemRemoveId = '0';
    if(e.target && e.target.id== 'cartRemove'){
        let subTotal = 0;
        let cartEcoTax = 0;
        let cartVAT = 0;
        let cartTotal = 0;
        
        itemRemoveId = e.target.querySelector('input').value;

        let cartFromLocal = JSON.parse(localStorage.getItem("cart"));

        let newCart = cartFromLocal.filter(item => item.id != parseInt(itemRemoveId));
        console.log(newCart);

        localStorage.setItem("cart", JSON.stringify(newCart));

        e.target.parentElement.parentElement.remove();

        document.querySelectorAll(".header-action-num").forEach((item, index) => {
            let cartSize = JSON.parse(localStorage.getItem("cart")).length;
            if (cartSize != 0) {
                if (cartSize < 10) {
                    item.innerHTML = "0" + cartSize;
                }
                else {
                    item.innerHTML = cartSize;
                }
            }
            else {
                item.innerHTML = "";
                item.style.backgroundColor = "transparent";
            }
        })

        let newCartLocal = JSON.parse(localStorage.getItem("cart"));

        for (let cartItem of newCartLocal) {
            subTotal += cartItem.price * cartItem.quantity;
            cartEcoTax = subTotal * 0.02;
            cartVAT = subTotal * 0.08;
            cartTotal = subTotal + cartEcoTax + cartVAT;
            
        }

        document.getElementById("cartSubTotal").innerHTML = subTotal + " VND";
        document.getElementById("cartEcoTax").innerHTML = cartEcoTax + " VND";
        document.getElementById("cartVAT").innerHTML = cartVAT + " VND";
        document.getElementById("cartTotal").innerHTML = cartTotal + " VND";
    } 
     
});

window.onload = () => {
    document.querySelectorAll(".header-action-num").forEach((item, index) => {
        let cartSize = JSON.parse(localStorage.getItem("cart")).length;
        if (cartSize != 0) {
            if (cartSize < 10) {
                item.innerHTML = "0" + cartSize;
            }
            else {
                item.innerHTML = cartSize;
            }
        }
        else {
            item.innerHTML = "";
            item.style.backgroundColor = "transparent";
        }
    })
}





