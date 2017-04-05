using System.Collections.Generic;
using NUnit.Framework;

namespace DotSpatial.Projections.Tests.Projected.Utm
{
    /// <summary>
    /// This class contains all the tests for the Utm.Oceans category of Projected coordinate systems.
    /// </summary>
    [TestFixture]
    public class Oceans
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
            return ProjectionInfoDesc.GetForCoordinateSystemCategory(KnownCoordinateSystems.Projected.Utm.Oceans);
        }
    }
}