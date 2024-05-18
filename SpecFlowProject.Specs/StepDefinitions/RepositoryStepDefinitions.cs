using Proyecto_final___PDFs_Creator___Editor.model;
using Proyecto_final___PDFs_Creator___Editor.repository;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Specs.StepDefinitions
{
    [Binding]
    public class RepositoryStepDefinitions
    {
        private readonly PdfRepository repository = new PdfRepository();

        private int id;
        private Pdf pdf;

        [Given(@"the id is (.*)")]
        public void GivenTheIdIs(int p0)
        {
            id = p0;
        }

        [Then(@"the id from the pdf obtained should be (.*)")]
        public void ThenTheIdFromThePdfObtainedShouldBe(int p0)
        {
            pdf.Id.Should().Be(id);
        }

        [When(@"the pdf with that id is deleted")]
        public void WhenThePdfWithThatIdIsDeleted()
        {
            repository.Delete(id);
        }

        [When(@"the pdf is searched")]
        public void WhenThePdfIsSearched()
        {
            pdf = repository.Find(id);
        }


        [Then(@"the result of the search should be null")]
        public void ThenTheResultOfTheSearchShouldBeNull()
        {
            pdf.Should().Be(null);
        }

    }
}
