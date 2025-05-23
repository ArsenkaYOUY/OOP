﻿using GraphicalEditor.Model.Commands;
using GraphicalEditor.Services;

namespace GraphicalEditor.Controllers
{
    public class UndoRedoController
    {
        private readonly UndoRedoService _service;
        private readonly MyCanvas _canvas;

        public UndoRedoController(UndoRedoService service, MyCanvas canvas)
        {
            _service = service;
            _canvas = canvas;
        }

        public void RegisterCommand(ICommand command)
        {
            _service.Execute(command);
            _canvas.InvalidateVisual();
        }

        public void Undo()
        {
            _service.Undo();
            _canvas.InvalidateVisual();
        }

        public void Redo()
        {
            _service.Redo();
            _canvas.InvalidateVisual();
        }
        public void Reset()
        {
            _service.Reset();
            _canvas.InvalidateVisual();
        }
    }
}