using System.Collections.Generic;
using Management_System;
class Service
{
    private IDatabaseOperations dbOperations;

    public Service(IDatabaseOperations dbOperations)
    {
        this.dbOperations = dbOperations;
    }
    /// <summary>
    /// Manage the project including create, edit and delete
    /// </summary>
    /// <param name="projectName"></param>
    /// <param name="projectDescription"></param>
    /// <param name="operation"></param>
    /// <exception cref="System.Exception"></exception>
    public void ManageProject(string projectName, string projectDescription, string operation)
    {
        switch (operation)
        {
            case "Create":
                //check if the project name is already in use
                List<string> projects = dbOperations.LoadProjects();
                if (projects.Contains(projectName))
                {
                    throw new System.Exception("Project name already in use");
                }
                else
                {
                    dbOperations.ManageProject(projectName, projectDescription, true);
                }
                break;
            case "Edit":
                dbOperations.ManageProject(projectName, projectDescription, false);
                break;
            case "Delete":
                dbOperations.ManageProject(projectName, null, false, true);
                break;
            default:
                throw new System.Exception("Invalid operation");
        }
    }
    /// <summary>
    /// Manage the requirement including create, edit and delete
    /// </summary>
    /// <param name="projectID"></param>
    /// <param name="requirementID"></param>
    /// <param name="requirementName"></param>
    /// <param name="requirementDescription"></param>
    /// <param name="requirementStatus"></param>
    /// <param name="requirementVersion"></param>
    /// <param name="operation"></param>
    /// <exception cref="System.Exception"></exception>
    public void ManageRequirement(string projectID, string requirementID, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion, string operation)
    {
        switch (operation)
        {
            case "Create":
                dbOperations.ManageRequirement(projectID, null, requirementName, requirementDescription, requirementStatus, requirementVersion, true);
                break;
            case "Edit":
                dbOperations.ManageRequirement(null, requirementID, null, null, requirementStatus, null, false);
                break;
            case "Delete":
                dbOperations.ManageRequirement(null, requirementID, null, null, null, null, false, true);
                break;
            default:
                throw new System.Exception("Invalid operation");
        }
    }
    /// <summary>
    /// Manage the dependency including create and delete
    /// </summary>
    /// <param name="requirementName"></param>
    /// <param name="dependentRequirementName"></param>
    /// <param name="dependencyDescription"></param>
    /// <param name="operation"></param>
    /// <exception cref="System.Exception"></exception>
    public void ManageDependency(string requirementName, string dependentRequirementName, string dependencyDescription, string operation)
    {
        switch (operation)
        {
            case "Create":
                dbOperations.ManageDependency(requirementName, dependentRequirementName, dependencyDescription, true);
                break;
            case "Delete":
                dbOperations.ManageDependency(requirementName, dependentRequirementName, null, false, true);
                break;
            default:
                throw new System.Exception("Invalid operation");
        }
    }
}
