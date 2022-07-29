﻿using Aqola.Domain.Services;

namespace Aqola.Application.Services.Commands
{
    internal class ListGuestByAgeCommand : BaseHotelCommand, ICommand
    {
        public ListGuestByAgeCommand(IHotelService hotelService) : base(hotelService)
        {

        }

        public string Execute(params object?[] options)
        {
            throw new NotImplementedException();
        }

        public bool IsHandle(string command)
        {
            return command.StartsWith("list_guest_by_age");
        }
    }
}