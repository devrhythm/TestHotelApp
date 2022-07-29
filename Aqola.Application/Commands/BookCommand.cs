﻿using Aqola.Domain.Services;

namespace Aqola.Application.Services.Commands
{
    internal class BookCommand :BaseHotelCommand, ICommand
    {
        public BookCommand(IHotelService hotelService) : base(hotelService)
        {

        }
        public string Execute(params object?[] options)
        {
            throw new NotImplementedException();
        }

        public bool IsHandle(string command)
        {
            return command.StartsWith("book");
        }
    }
}