using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VitallyVeg.Models;

namespace VitallyVeg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
{
    private readonly VitallyVegContext _db;

    public RecipesController(VitallyVegContext db, JsonFileRecipeService recipeService)
    {
        RecipeService = recipeService;
        _db = db;
    }
    public JsonFileRecipeService RecipeService { get; }

    [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return RecipeService.GetRecipes();
        }
}