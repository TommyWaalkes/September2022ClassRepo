using System;
using System.Collections.Generic;
using HomemadeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomemadeAPI.Models
{
    public partial class Pet
    {
        public Pet()
        {
            PetOwners = new HashSet<PetOwner>();
        }

        public int Id { get; set; }
        public string? Species { get; set; }

        public virtual ICollection<PetOwner> PetOwners { get; set; }
    }


public static class PetEndpoints
{
	public static void MapPetEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Pet", async (petsContext db) =>
        {
            return await db.Pets.ToListAsync();
        })
        .WithName("GetAllPets")
        .Produces<List<Pet>>(StatusCodes.Status200OK);

        routes.MapGet("/api/Pet/{id}", async (int Id, petsContext db) =>
        {
            return await db.Pets.FindAsync(Id)
                is Pet model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetPetById")
        .Produces<Pet>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/Pet/{id}", async (int Id, Pet pet, petsContext db) =>
        {
            var foundModel = await db.Pets.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })   
        .WithName("UpdatePet")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Pet/", async (Pet pet, petsContext db) =>
        {
            db.Pets.Add(pet);
            await db.SaveChangesAsync();
            return Results.Created($"/Pets/{pet.Id}", pet);
        })
        .WithName("CreatePet")
        .Produces<Pet>(StatusCodes.Status201Created);


        routes.MapDelete("/api/Pet/{id}", async (int Id, petsContext db) =>
        {
            if (await db.Pets.FindAsync(Id) is Pet pet)
            {
                db.Pets.Remove(pet);
                await db.SaveChangesAsync();
                return Results.Ok(pet);
            }

            return Results.NotFound();
        })
        .WithName("DeletePet")
        .Produces<Pet>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}}
