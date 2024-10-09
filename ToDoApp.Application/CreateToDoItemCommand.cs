using MediatR;
using System;

namespace ToDoApp.Application
{
    public class CreateToDoItemCommand : IRequest<int>
    {
        public string Description { get; set; }
    }
}
