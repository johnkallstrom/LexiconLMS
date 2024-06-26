﻿using Microsoft.AspNetCore.Components;

namespace LexiconLMS.Components.Shared
{
    public partial class Navbar
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public ILocalStorageService LocalStorage { get; set; } = default!;

        private async Task Logout()
        {
            await LocalStorage.RemoveItemAsync("token");
            NavigationManager.NavigateTo("/logout", forceLoad: true);
        }
    }
}
