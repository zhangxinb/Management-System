using System.Collections.Generic;

namespace Management_System
{
    public interface IDatabaseOperations
    {
        void InsertUser(string username, string password, string phoneNum);
        string GetUserPassword(string username);
        List<string> LoadProjects();
        List<string> ListAllUsersExceptSadmin();
        void InsertProject(string projectName, string projectDescriptionr);
        void EditProject(string projectName, string projectDescriptionr);
        void DeleteProject(string projectName);
        void InsertRequirement(string projectName, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion);
        string GetRequirementID(string requirementName);
        void UpdateRequirement(string projectName, string requirementID, string requirementName, string requirementStatus);
        void DeleteRequirement(string requirementId, string requirementName);
        string GetProjectID(string projectName);
        void Logout();
        List<string> LoadRequirements(string projectName);
        List<string> ListAllRequirements();
        List<string> LoadDependencies(string requirementName);
        int GetDependencyID(string requirementID, string denpendentRequirementID);
        void InsertDependency(string requirementName, string dependencyDescription);
        // void UpdateDependency(int dependencyID, string dependencyDescription);
        void DeleteDependency(int dependencyId);
        string GetUserId(string username);
        void LoadUserRoles(string userId, Dictionary<string, string> userRoles);
        bool IsSuperAdmin(string userId);
        void SetProjectAdmin(string userId, string projectId);
        void LinkUserToProject(string userId, string projectId);
        bool IsAdminOfAnyProjects(string userId);
        string AdminOfProject(string projectId);
        bool IsAdminOfThisProject(string userId, string projectId);
        List<string> GetUserAdminProjects(string userId);
        string GetUserName(string userId);
        List<string> ListUsersBelongToProject(string projectId);
        List<string> ListUsersDontBeloneToProject(string projectId);
        bool UpdateUserRoles(string userId, string projectId, string role, bool isAdd);
        void InsertComment(int userId, string commentContent, List<int> requirementIds);
        List<string> ListAllRequirementsYouCanSee(string userId);
        List<string> ListAllCommentsYouCanSee(string userId);
    }

}
