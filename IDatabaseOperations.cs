using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        string GetProjectID(string projectName);
    }

}
