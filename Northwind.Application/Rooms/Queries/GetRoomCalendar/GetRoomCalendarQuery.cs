﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Northwind.Application.Rooms.Queries.GetRoomCalendar
{
    public class GetRoomCalendarQuery : IRequest<RoomCalendarViewModel>
    {
    }
}
