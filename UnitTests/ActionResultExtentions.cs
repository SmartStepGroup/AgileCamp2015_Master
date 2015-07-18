using System.Web.Mvc;

namespace UnitTests
{
    public static class ActionResultExtentions
    {
        public static T Model<T>(this ActionResult view)
        {
            return (T) (((ViewResultBase) (view)).Model);
        }
    }
}