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
  [Route("api/[controller]")]
  [ApiController]
  public class RecipesController : ControllerBase
  {
    private readonly VitallyVegContext _db;

    public RecipesController(VitallyVegContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Recipe>>> Get(string name, string category, string cuisine, string[] ingredients, string time, int yield, string instructions)
    {
      var query = _db.Recipes.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }    

      if (cuisine != null)
      {
        query = query.Where(entry => entry.Cuisine == cuisine);
      }    
     
     foreach ( ingredient in ingredients)
     {
      if (ingredients != null)
      {
        query = query.Where(entry => entry.Ingredients = ingredients);
      }     
    }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Recipe>> GetRecipe(int id)
    {
        var recipe = await _db.Recipes.FindAsync(id);

        if (recipe == null)
        {
            return NotFound();
        }

        return recipe;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Recipe recipe)
    {
      if (id != recipe.RecipeId)
      {
        return BadRequest();
      }

      _db.Entry(recipe).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RecipeExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Recipe>> Post(Recipe recipe)
    {
      _db.Recipes.Add(recipe);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetRecipe), new { id = recipe.RecipeId }, recipe);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRecipe(int id)
    {
      var recipe = await _db.Recipes.FindAsync(id);
      if (recipe == null)
      {
        return NotFound();
      }

      _db.Recipes.Remove(recipe);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool RecipeExists(int id)
    {
      return _db.Recipes.Any(e => e.RecipeId == id);
    }
  }
}