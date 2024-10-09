using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ToDoApp.Domain;

namespace ToDoApp.Application
{
    public class ToDoItemQueryHandler
     : IRequestHandler<ToDoItemQuery, List<ToDoItem>>
    {
        private IToDoRepository _toDoRepository;

        public ToDoItemQueryHandler(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        public Task<List<ToDoItem>> Handle(
            ToDoItemQuery request, CancellationToken cancellationToken)
        {
            return _toDoRepository.GetAllAsync();
        }
    }
}
