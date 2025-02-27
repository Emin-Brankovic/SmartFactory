﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartFactoryWebApi.Dtos;
using SmartFactoryWebApi.Models;
using SmartFactoryWebApi.Services;

namespace SmartFactoryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendingController(IDataMinerConnection dataMinerConnection) : ControllerBase
    {
        [HttpGet("GetDeviceTrending/{deviceId}")]
        public async Task<ActionResult<List<SensorDataDto>>> GetDeviceTrending(int deviceId, CancellationToken cancellationToken)
        {
            var result = await dataMinerConnection.GetDeviceTrending(deviceId, cancellationToken);

            if (result.Count <= 0) return BadRequest("No trending");

            return result;
        }

        [HttpGet("GetDeviceTrendingAverage/{deviceId}")]
        public async Task<ActionResult<List<SensorRecordAverage>?>> GetDeviceTrendingAverage(int deviceId, CancellationToken cancellationToken)
        {
            var result = await dataMinerConnection.GetDeviceTrendingAverage(deviceId, cancellationToken);

            if (result.Count <= 0) return BadRequest("No trending");

            return result;
        }
    }
}
