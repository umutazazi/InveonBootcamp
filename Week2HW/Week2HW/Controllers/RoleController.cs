using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Week2HW.Models.Repositories;

namespace Week2HW.Controllers
{
    public class RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : Controller
    {
        //Rol CRUD işlemleri
        public async Task<IActionResult> Create(string roleName)
        {
            if (roleName == null)
                return BadRequest("Role cannot be empty.");

            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (roleExist)
                return BadRequest("Role already exists.");

            var result = await roleManager.CreateAsync(new AppRole { Name = roleName });
            if (result.Succeeded)
                return Ok("Role created successfully.");

            return BadRequest(result.Errors);
        }

        public IActionResult Read()
        {
            var roles = roleManager.Roles.ToList();
            return Ok(roles);
        }

        public async Task<IActionResult> Update(string id, string newRoleName)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound("Role not found.");

            role.Name = newRoleName;
            var result = await roleManager.UpdateAsync(role);

            if (result.Succeeded)
                return Ok("Role updated successfully.");

            return BadRequest(result.Errors);
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound("Role not found.");

            var result = await roleManager.DeleteAsync(role);
            if (result.Succeeded)
                return Ok("Role deleted successfully.");

            return BadRequest(result.Errors);
        }

        //Kullanıcıya rol atama
        public async Task<IActionResult> AssignRoleToUser(string userName, string roleName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user == null)
                return NotFound("User not found.");

            var roleExists = await roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
                return NotFound("Role does not exist.");

            var result = await userManager.AddToRoleAsync(user, roleName);
            if (result.Succeeded)
                return Ok("Role assigned successfully.");

            return BadRequest(result.Errors);
        }
        //Kullanıcıdan rol silme
        public async Task<IActionResult> RemoveRoleFromUser(string userName, string roleName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user == null)
                return NotFound("User not found.");

            var result = await userManager.RemoveFromRoleAsync(user, roleName);
            if (result.Succeeded)
                return Ok("Role removed successfully.");

            return BadRequest(result.Errors);
        }
    }
}
