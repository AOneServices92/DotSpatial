using System.Collections.Generic;
using NUnit.Framework;

namespace DotSpatial.Projections.Tests.Projected.NationalGrids
{
    /// <summary>
    /// This class contains all the tests for the Africa category of Projected coordinate systems
    /// </summary>
    [TestFixture]
    public class Libya
    {
        [Test]
        [TestCaseSource(nameof(GetProjections))]
        public void ProjectedTests(ProjectionInfoDesc pInfo)
        {
            Tester.TestProjection(pInfo.ProjectionInfo);
            Assert.AreEqual(false, pInfo.ProjectionInfo.IsLatLon);
        }

        private static IEnumerable<ProjectionInfoDesc> GetProjections()
        {
            return ProjectionInfoDesc.GetForCoordinateSystemCategory(KnownCoordinateSystems.Projected.NationalGrids.Libya);
        }
    }
}