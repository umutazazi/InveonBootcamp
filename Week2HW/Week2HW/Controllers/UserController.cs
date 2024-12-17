using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Week2HW.Models.Repositories;

namespace Week2HW.Controllers
{
    public class UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager) : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Read()
        {
            var users = userManager.Users.ToList();
            return Ok(users);

        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] AppUser user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null.");
            }
            await userManager.CreateAsync(user);
            return Ok("User added successfully.");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AppUser user)
        {

            var userToUpdate = await userManager.FindByIdAsync(id.ToString());
            userToUpdate.UserName = user.UserName;
            userToUpdate.Email = user.Email;


            var result = await userManager.UpdateAsync(userToUpdate);

            if (!result.Succeeded)
            {
                return BadRequest("User could not be updated.");

            }
            return Ok("User updated successfully.");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            var result = await userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest("User could not be deleted.");
            }
            return Ok("User deleted successfully.");
        }


        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Email veya Şifre yanlış");

            }
            var checkPassword = await userManager.CheckPasswordAsync(user, password);
            if (!checkPassword)
            {
                ModelState.AddModelError(string.Empty, "Email veya Şifre yanlış");

            }

            await signInManager.SignInAsync(user, new AuthenticationProperties() { IsPersistent = true });
            return Ok("Giriş başarılı");
        }







        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Ok("Çıkış yapıldı.");
        }

        public async Task<IActionResult> Register([FromBody] AppUser user)
        {
            var result = await userManager.CreateAsync(user, user.PasswordHash);
            if (!result.Succeeded)
            {
                return BadRequest("Kullanıcı oluşturulamadı.");
            }
            return Ok("Kullanıcı oluşturuldu.");
        }




    }
}

