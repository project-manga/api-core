namespace ApiCore.Controllers
{
    using ApiCoreApp.GoodManga;
    using Microsoft.AspNetCore.Mvc;
    using System;

    [Produces("application/json")]
    [Route("api/good-manga")]
    public class GoodMangaController : Controller
    {
        private readonly IGoodMangaService mGoodMangaService;

        public GoodMangaController(IGoodMangaService goodMangaService)
        {
            mGoodMangaService = goodMangaService ?? throw new ArgumentNullException(paramName: nameof(goodMangaService));
        }


    }
}