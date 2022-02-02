﻿using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.API.Models;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Common;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionsController : BaseController
    {
        public readonly IProjectionRepository _projectionRepository;

        public ProjectionsController(IProjectionRepository projectionRepository)
        {
            _projectionRepository = projectionRepository;
        }

        [HttpGet()]
        public List<ProjectionResponse> GetProjections()
        {
            var projections = _projectionRepository.GetAllProjections();

            var result = new List<ProjectionResponse>();

            foreach (var projection in projections)
            {
                result.Add(new ProjectionResponse
                {
                    Id = projection.Id,
                    ProjectionDate = DateTime.Now,
                    CinemaName = projection.CinemaName,
                    MovieId = projection.MovieId
                });
            }

            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectionResponse> GetProjectionById(int id)
        {
            var projection = _projectionRepository.GetProjectionById(id);

            if (projection == null)
            {
                ErrorResponseModel errorResponse = new ErrorResponseModel()
                {
                    ErrorMessage = Messages.PROJECTION_DOES_NOT_EXIST,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
                return NotFound(errorResponse);
            }

            var result = new ProjectionResponse()
            {
                Id = id,
                ProjectionDate = DateTime.Now,
                CinemaName = projection.CinemaName,
                MovieId = projection.MovieId
            };

            return result;
        }

        [HttpGet("movie/{movieId}")]
        public ActionResult<List<ProjectionResponse>> GetProjectionsByMovieId(int movieId)
        {
            var projections = _projectionRepository.GetProjectionsByMovieId(movieId);

            if (projections == null)
            {
                ErrorResponseModel errorModel = new ErrorResponseModel()
                {
                    ErrorMessage = Messages.MOVIE_DOES_NOT_EXIST,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };

                return NotFound(errorModel);
            }

            if (!projections.Any())
            {
                ErrorResponseModel errorModel = new ErrorResponseModel()
                {
                    ErrorMessage = Messages.PROJECTIONS_DO_NOT_EXIST,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };

                return NotFound(errorModel);
            }

            var result = new List<ProjectionResponse>();

            foreach (var projection in projections)
            {
                result.Add(new ProjectionResponse
                {
                    Id = projection.Id,
                    ProjectionDate = DateTime.Now,
                    CinemaName = projection.CinemaName,
                    MovieId = projection.MovieId
                });
            }

            return result;
        }
    }
}