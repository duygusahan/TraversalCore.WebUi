using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;

namespace TraversalCore.WebUi.ViewComponents.DestinationComponents
{
    public class _CommentsComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentsComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetDestinationById(id);

            return View(value);
        }
    }
}
