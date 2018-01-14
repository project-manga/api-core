using ApiCoreApp;
using NUnit.Framework;

namespace ApiCoreAppTest.UT
{
    [TestFixture]
    public class GoodMangaServiceTest
    {
        private GoodMangaService sut;

        [SetUp]
        public void SetUp()
        {
            sut = new GoodMangaService();
        }

        [TearDown]
        public void TearDown()
        {
            sut = null;
        }
        
        [Test]
        public void Should_write_download_specification_entry_returning_its_id()
        {
            var expected = 1L;

            var dto = new GoodMangaDownloadSpecificationEntryDto
            {
                Sid = "test-manga-sid",
                StartingChapter = 3,
                EndingChapter = 4,
                ChaptersPartStep = 1,
                StartingPage = 1,
                EndingPage = null
            };

            var actual = sut.AddDownload(dto);

            Assert.AreEqual(expected, actual, "Download entry id does not match");
        }
    }
}
