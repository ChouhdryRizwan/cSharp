# Add Authorization

*) Note: Add roles manually in database. 

## Step 1
Add role dropdown in register page (UI).
```
 <div class="form-floating mb-3">
     <select asp-for="Input.Role" class="form-control" >
         <option value="">Select Role</option>
         <option value="user">User</option>
         <option value="admin">Admin</option>
     </select>
     <span asp-validation-for="Input.Role" class="text-danger"></span>
 </div>
```
## Step 2

Add fields in Register File.

```
1) private readonly RoleManager<IdentityRole> _roleManager;

2) RoleManager<IdentityRole> roleManager

3) _roleManager = roleManager;
```

*) In InputModel:

```
 [Display(Name = "Role")]
 [Required(ErrorMessage = "Role is required")]
 [StringLength(100, ErrorMessage = "Role must be Required")]
 public string Role { get; set; }
```

*) In OnPostAsync

``` 
 if (!await _roleManager.RoleExistsAsync(Input.Role))
 {
     await _roleManager.CreateAsync(new IdentityRole(Input.Role));
 }
 await _userManager.AddToRoleAsync(user, Input.Role)
 ```

## Step 3

*) In Program.cs file:
```
.AddRoles<IdentityRole>()

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AuthContext>();
``` 

## Step 4

*) In Controller:
```
[Authorize(Roles = "admin")]
[Authorize(Roles = "user")]
 [Authorize(Roles = "admin,user")]
```

## Step 5

*) In Views:

```
@if (User.IsInRole("user"))
{
	<h1>For User</h1>
}
@if (User.IsInRole("admin"))
{
	<h1>For Admin</h1>
}
```