using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.model
{
    class Bugs
    {
        private int bugId;
        private string userName;
        private string projectName;
        private string issue;
        private string filename;
        private string lineNo;
        private string createdDate;
        private string status;
        private string fixDate;
        private string fixby;

        public int BugId
        {
            get
            {
                return bugId;
            }
            set
            {
                bugId = value;
            }
        }
        public string Username
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string ProjectName
        {
            get
            {
                return projectName;
            }
            set
            {
                projectName = value;
            }
        }

        public string FileName
        {
            get
            {
                return filename;
            }
            set
            {
                filename = value;
            }
        }
        public string Issue
        {
            get
            {
                return issue;
            }
            set
            {
                issue = value;
            }
        }

        public string LineNo
        {
            get
            {
                return lineNo;
            }
            set
            {
                lineNo = value;
            }
        }
        public string CreatedDate
        {
            get
            {
                return createdDate;
            }
            set
            {
                createdDate = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string FixDate
        {
            get
            {
                return fixDate;
            }
            set
            {
                fixDate = value;
            }
        }
        public string FixBy
        {
            get
            {
                return fixby;
            }
            set
            {
                fixby = value;
            }
        }

    }

}

