﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shuffle.Core.Models;
using Shuffle.Core.Services;

namespace Shuffle.Api.Controllers
{
    [Route("api/team-records")]
    [ApiController]
    public class TeamRecordsController : ControllerBase
    {
        private readonly ITeamRecordService _teamRecordService;

        public TeamRecordsController(ITeamRecordService teamRecordService)
        {
            _teamRecordService = teamRecordService;
        }

        // GET api/values
        [HttpGet]
<<<<<<< HEAD
        public IEnumerable<TeamRecord> Get(int? rulesetId)
        {
            return _teamRecordService.GetTeamRecords(rulesetId);
=======
        public IEnumerable<TeamRecord> Get(int? id)
        {
            return _teamRecordService.GetTeamRecords(id);
>>>>>>> 9b209244f3eb151307a73a1bdef72e2ef39ed9e5
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TeamRecord Get(int id)
        {
            return _teamRecordService.GetTeamRecord(id);
        }

        // POST api/values
        [HttpPost]
        public TeamRecord Post([FromBody] TeamRecord teamRecord)
        {
            return _teamRecordService.CreateTeamRecord(teamRecord);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}