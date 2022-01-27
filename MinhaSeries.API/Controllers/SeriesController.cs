using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaSeries.Application.Commands.CreateComment;
using MinhaSeries.Application.Commands.CreateSerie;
using MinhaSeries.Application.Commands.DeleteSerie;
using MinhaSeries.Application.Commands.UpdateSerie;
using MinhaSeries.Application.Queries.GetAllSeriesQuery;
using MinhaSeries.Application.Queries.GetSeriesByIdQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSeries.API.Controllers
{
    [Route("api/series")]
    public class SeriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SeriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
            var getAllSeriesQuery = new GetAllSeriesQuery();

            var series = await _mediator.Send(getAllSeriesQuery);

            return Ok(series);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetSerieByIdQuery(id);

            var serie = await _mediator.Send(query);

            if (serie == null) return NotFound();

            return Ok(serie);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSerieCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> put(int id, [FromBody] UpdateSerieCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteSerieCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public async Task<IActionResult> post(int id, [FromBody] CreateCommentCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
