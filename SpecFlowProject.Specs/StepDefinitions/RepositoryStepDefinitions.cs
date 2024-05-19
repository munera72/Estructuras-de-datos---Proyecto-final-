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
        private string name;
        private Pdf pdf;

        [Given(@"the id is (.*)")]
        public void GivenTheIdIs(int p0)
        {
            id = p0;
        }

        [Given(@"the PDF name is ""(.*)""")]
        public void GivenThePdfNameIs(string p0)
        {
            name = p0;
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

        [When(@"the PDF is searched by name")]
        public void WhenThePdfIsSearchedByName()
        {
            pdf = repository.Find(name);
        }

        [When(@"the pdf is searched")]
        public void WhenThePdfIsSearched()
        {
            pdf = repository.Find(id);
        }

        [Then(@"the name from the PDF obtained should be ""(.*)""")]
        public void ThenTheNameFromThePDFObtainedShouldBe(string p0)
        {
            if (pdf != null)
            {
                pdf.Name.Should().Be(p0);
            }
            else
            {
                // Si el objeto Pdf es null, arrojar una excepción o manejarlo de otra manera según sea necesario
                throw new Exception("El PDF no fue encontrado.");
            }
        }


        [Then(@"the result of the search should be null")]
        public void ThenTheResultOfTheSearchShouldBeNull()
        {
            pdf.Should().Be(null);
        }

    }
}
