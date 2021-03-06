﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models;
using UITMBER.Models.Dto;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.Client.Drivers
{
    class DriverService : IDriversService
    {
        private IRequestService _requestService => DependencyService.Get<IRequestService>();

        public async Task<List<DriverDto>> GetNerbyDriveres(LatLong latlong)
        {
            var url = $"{Settings.SERVER_ENDPOINT}/Driver/GetNerbyDriveres?latitude={latlong.Lat}&longitude={latlong.Long}";
            var data = await _requestService.GetAsync<List<DriverDto>>(url);

            return data;
        }

        public async Task<DriverDto> GetProfile(int driverId)
        {
            var url = $"{Settings.SERVER_ENDPOINT}/Driver/GetProfile?id={driverId}";
            var data = await _requestService.GetAsync<DriverDto>(url);

            return data;
        }
    }
}
