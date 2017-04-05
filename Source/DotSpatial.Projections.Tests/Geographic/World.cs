using System.Collections.Generic;
using NUnit.Framework;

namespace DotSpatial.Projections.Tests.Geographic
{
    /// <summary>
    /// This class contains all the tests for the World category of Geographic coordinate systems
    /// </summary>
    [TestFixture]
    public class World
    {
        [Test]
        [TestCaseSource(nameof(GetProjections))]
        public void WorldGeographicTests(ProjectionInfoDesc pInfo)
        {
            Tester.TestProjection(pInfo.ProjectionInfo);
            Assert.AreEqual(true, pInfo.ProjectionInfo.IsLatLon);
        }

        private static IEnumerable<ProjectionInfoDesc> GetProjections()
        {
            return ProjectionInfoDesc.GetForCoordinateSystemCategory(KnownCoordinateSystems.Geographic.World);
        }
    }
}
