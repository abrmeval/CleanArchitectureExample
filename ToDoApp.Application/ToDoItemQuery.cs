﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.Application
{
    public class ToDoItemQuery
     : IRequest<List<ToDoItem>>
    {
    }
}