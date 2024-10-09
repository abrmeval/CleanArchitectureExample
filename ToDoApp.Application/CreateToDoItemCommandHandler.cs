using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ToDoApp.Domain;

namespace ToDoApp.Application
{
    public class CreateToDoItemCommandHandler
     : IRequestHandler<CreateToDoItemCommand, int>
    {
        private IToDoRepository _toDoRepository; 
        
        public CreateToDoItemCommandHandler(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public Task<int> Handle(
            CreateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var item = new ToDoItem
            {
                Description = request.Description
            };

            return _toDoRepository.CreateAsync(item);
        }
    }
}
