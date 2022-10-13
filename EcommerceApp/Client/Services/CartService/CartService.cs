using Blazored.LocalStorage;

namespace EcommerceApp.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService localStorage;
        private readonly HttpClient http;
        public CartService(ILocalStorageService localStorage, HttpClient http)
        {
            this.localStorage = localStorage;
            this.http = http;
        }

        public event Action OnChange;

        public async Task AddToCart(CartItem cartItem)
        {
            var cart = await localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                cart = new List<CartItem>();
            }
            cart.Add(cartItem);
            await localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            return cart;
        }

        public async Task<List<CartProductResponse>> GetCartProducts()
        {
            var cartItems = await localStorage.GetItemAsync<List<CartItem>>("cart");
            var response = await http.PostAsJsonAsync("api/cart/products", cartItems);
            var cartProducts =
                await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
            return cartProducts.Data;
            
        }
    }
}
