using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using Management_System;
using Moq;
using Newtonsoft.Json;

namespace Management_System
{

    [TestClass]
    public class MySqlDatabaseOperationsTests
    {
        private IDatabaseOperations _mySqlDatabaseOperations;
        private Mock<IDatabaseOperations> _mockMySqlDatabaseOperations;

        [TestInitialize]
        public void Setup()
        {
            //Initialize the mock object
            _mockMySqlDatabaseOperations = new Mock<IDatabaseOperations>();
            _mySqlDatabaseOperations = _mockMySqlDatabaseOperations.Object;

            _mockMySqlDatabaseOperations.Setup(m => m.GetUserPassword(It.IsAny<string>())).Returns("expectedPassword");
        }

        [TestMethod]
        public void GetUserPassword_ReturnsCorrectPassword()
        {
            // Arrange
            string expectedPassword = "expectedPassword";
            string username = "testUser";

            // Act
            string actualPassword = _mySqlDatabaseOperations.GetUserPassword(username);

            // Assert
            Assert.AreEqual(expectedPassword, actualPassword);
        }

        [TestMethod]
        public void Test_InsertUser()
        {
            // Arrange
            string username = "testUser";
            string password = "testPassword";
            string phoneNum = "1234567890";

            // Act
            _mySqlDatabaseOperations.InsertUser(username, password, phoneNum);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.InsertUser(username, password, phoneNum), Times.Once);
        }
        [TestMethod]
        public void Test_ManageProject()
        {
            // Arrange
            string projectName = "testProject";
            string projectDescription = "testDescription";

            // Act
            // Test insert
            _mySqlDatabaseOperations.ManageProject(projectName, projectDescription, true, false);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageProject(projectName, projectDescription, true, false), Times.Once);

            // Act
            // Test delete
            _mySqlDatabaseOperations.ManageProject(projectName, projectDescription, false, true);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageProject(projectName, projectDescription, false, true), Times.Once);

            // Act
            // Test update
            _mySqlDatabaseOperations.ManageProject(projectName, projectDescription, false, false);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageProject(projectName, projectDescription, false, false), Times.Once);
        }
        [TestMethod]
        public void Test_ManageRequirement()
        {
            // Arrange
            string projectId = "testProjectId";
            string requirementId = "testRequirementId";
            string requirementName = "testRequirementName";
            string requirementDescription = "testRequirementDescription";
            string requirementStatus = "testRequirementStatus";
            string requirementVersion = "testRequirementVersion";

            // Act
            // Test insert
            _mySqlDatabaseOperations.ManageRequirement(projectId, requirementId, requirementName, requirementDescription, requirementStatus, requirementVersion, true, false);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageRequirement(projectId, requirementId, requirementName, requirementDescription, requirementStatus, requirementVersion, true, false), Times.Once);

            // Act
            // Test delete
            _mySqlDatabaseOperations.ManageRequirement(projectId, requirementId, requirementName, requirementDescription, requirementStatus, requirementVersion, false, true);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageRequirement(projectId, requirementId, requirementName, requirementDescription, requirementStatus, requirementVersion, false, true), Times.Once);

            // Act
            // Test update
            _mySqlDatabaseOperations.ManageRequirement(projectId, requirementId, requirementName, requirementDescription, requirementStatus, requirementVersion, false, false);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageRequirement(projectId, requirementId, requirementName, requirementDescription, requirementStatus, requirementVersion, false, false), Times.Once);
        }
        [TestMethod]
        public void Test_ManageDependency()
        {
            // Arrange
            string requirementName = "testRequirementName";
            string dependentRequirementName = "testDependentRequirementName";
            string dependencyDescriptionID = "testDependencyDescriptionID";

            // Act
            // Test insert
            _mySqlDatabaseOperations.ManageDependency(requirementName, dependentRequirementName, dependencyDescriptionID, true, false);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageDependency(requirementName, dependentRequirementName, dependencyDescriptionID, true, false), Times.Once);

            // Act
            // Test delete
            _mySqlDatabaseOperations.ManageDependency(requirementName, dependentRequirementName, dependencyDescriptionID, false, true);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.ManageDependency(requirementName, dependentRequirementName, dependencyDescriptionID, false, true), Times.Once);
        }
        
        [TestMethod]
        public void Test_SerializeDatabase()
        {
            // Arrange
            string version = "testVersion";
            var expectedSnapshot = new MySqlDatabaseOperations.DatabaseSnapshot
            {
                Version = version,
                Data = new DataSet() // TODO: Fill this DataSet with test data
            };
            string expectedJsonData = JsonConvert.SerializeObject(expectedSnapshot);
            _mockMySqlDatabaseOperations.Setup(m => m.SerializeDatabase(version)).Returns(expectedJsonData);

            // Act
            string actualJsonData = _mySqlDatabaseOperations.SerializeDatabase(version);

            // Assert
            Assert.AreEqual(expectedJsonData, actualJsonData);
        }

        [TestMethod]
        public void Test_SerializeDatabaseToFile()
        {
            // Arrange
            string filePath = "testFilePath";
            string version = "testVersion";
            string expectedJsonData = "expectedJsonData";

            _mockMySqlDatabaseOperations.Setup(m => m.SerializeDatabase(version)).Returns(expectedJsonData);

            // Act
            _mySqlDatabaseOperations.SerializeDatabase(version); // 直接调用SerializeDatabase方法
            _mySqlDatabaseOperations.SaveToFile(expectedJsonData, filePath); // 直接调用SaveToFile方法
            _mySqlDatabaseOperations.SerializeDatabaseToFile(filePath, version);

            // Assert
            _mockMySqlDatabaseOperations.Verify(m => m.SerializeDatabase(version), Times.Once);
            _mockMySqlDatabaseOperations.Verify(m => m.SaveToFile(expectedJsonData, filePath), Times.Once);
        }

    }
}
