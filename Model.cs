using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    public class Project
    {
        private string projectId;
        private string projectName;
        private string projectDescription;

        public string ProjectId
        {
            get { return projectId; }
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string ProjectDescription
        {
            get { return projectDescription; }
            set { projectDescription = value; }
        }

        public Project(string projectId, string projectName, string projectDescription)
        {
            this.projectId = projectId;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
        }

        public override string ToString()
        {
            return projectName;
        }
    }

    public class User
    {
        private string userId;
        private string username;
        private string password;
        private string phoneNumber;

        public string UserId
        {
            get { return userId; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        

        public User(string username, string password, string phoneNumber)
        {
            this.username = username;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
     

        public override string ToString()
        {
            return username;
        }

    }

    public class Requirement
    {
        private string projectID;
        private string requirementID;
        private string requirementName;
        private string requirementDescription;
        private string requirementStatus;
        private string requirementVersion;

        public string ProjectID
        {
            get { return projectID; }
        }

        public string RequirementID
        {
            get { return requirementID; }
            set { requirementID = value; }
        }

        public string RequirementName
        {
            get { return requirementName; }
            set { requirementName = value; }
        }

        public string RequirementDescription
        {
            get { return requirementDescription; }
            set { requirementDescription = value; }
        }

        public string RequirementStatus
        {
            get { return requirementStatus; }
            set { requirementStatus = value; }
        }

        public string RequirementVersion
        {
            get { return requirementVersion; }
            set { requirementVersion = value; }
        }

        public Requirement(string projectID, string requirementID, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion)
        {
            this.projectID = projectID;
            this.requirementID = requirementID;
            this.requirementName = requirementName;
            this.requirementDescription = requirementDescription;
            this.requirementStatus = requirementStatus;
            this.requirementVersion = requirementVersion;
        }

        public override string ToString()
        {
            return requirementName;
        }
    }

    public class Dependency
    {
        private string dependencyId;
        private string dependentRequirementID;
        private string requirementName;
        private string dependentRequirementName;
        private string dependencyDescriptionID;

        public string DependencyId
        {
            get { return dependencyId; }
        }

        public string DependentRequirementID
        {
            get { return dependentRequirementID; }
            set { dependentRequirementID = value; }
        }

        public string RequirementName
        {
            get { return requirementName; }
            set { requirementName = value; }
        }

        public string DependentRequirementName
        {
            get { return dependentRequirementName; }
            set { dependentRequirementName = value; }
        }

        public string DependencyDescriptionID
        {
            get { return dependencyDescriptionID; }
            set { dependencyDescriptionID = value; }
        }

        public Dependency(string requirementName, string dependentRequirementName)
        {
            
            this.requirementName = requirementName;
            this.dependentRequirementName = dependentRequirementName;
            
        }

        /*
        public override string ToString()
        {
            return dependentRequirementName;
        }
        */
    }

    public class UserRole
    {
        private string userId;
        private string role;

        public string UserId
        {
            get { return userId; }
        }


        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public UserRole(string userId, string role)
        {
            this.userId = userId;
            this.role = role;
        }

        public override string ToString()
        {
            return role;
        }
    }

    public class Comment
    {
        private string commentId;
        private string userId;
        private string commentContent;
        private List<string> projectIds; 
        private List<string> requirementIds;

        //private DateTime commentCreatedAt;

        public string CommentId
        {
            get { return commentId; }
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string CommentContent
        {
            get { return commentContent; }
            set { commentContent = value; }
        }

        /*
        public DateTime CommentCreatedAt
        {
            get { return commentCreatedAt; }
            set { commentCreatedAt = value; }
        }
        */

        public List<string> ProjectIds
        {
            get { return projectIds; }
            set { projectIds = value; }
        }

        public List<string> RequirementIds
        {
            get { return requirementIds; }
            set { requirementIds = value; }
        }

        public Comment()
        {
            projectIds = new List<string>();
            requirementIds = new List<string>();
        }

        public Comment(string commentId, string userId, string commentContent, List<string> projectIds, List<string> requirementIds)
        {
            this.commentId = commentId;
            this.userId = userId;
            this.commentContent = commentContent;
            this.projectIds = projectIds;
            this.requirementIds = requirementIds;
        }

        public override string ToString()
        {
            return commentContent;
        }
    }







}
