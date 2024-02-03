using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Management_System
{
    public interface IDatabaseOperations
    {
        void InsertUser(string username, string password, string phoneNum);
        string GetUserPassword(string username);
        List<string> LoadProjects();
        void InsertProject(string projectName, string projectDescriptionr);
        void EditProject(string projectName, string projectDescriptionr);
        void DeleteProject(string projectName);
        void InsertRequirement(string projectName, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion);
        string GetRequirementID(string requirementName);
        void UpdateRequirement(string projectName, string requirementID, string requirementName, string requirementDescription, string requirementStatus);
        void DeleteRequirement(string requirementId, string requirementName);
        string GetProjectID(string projectName);
        void Logout();
        List<string> LoadRequirements(string projectName);
        List<MySqlDatabaseOperations.Dependency> LoadDependencies(string requirementName);
        void InsertDependency(string requirementName, string dependencyDescription);
        void UpdateDependency(int dependencyID, string dependencyDescription);
        void DeleteDependency(int dependencyId);
    }

}
