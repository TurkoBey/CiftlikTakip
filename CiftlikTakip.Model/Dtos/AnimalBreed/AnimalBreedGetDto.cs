﻿using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.AnimalBreed
{
    public class AnimalBreedGetDto : IDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? GroupName { get; set; }
        public string? Description { get; set; }
    }
}
