using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.model
{
    class projectModel
    {
        private int projectId;
        private string projectName;
        private string createdDate;
        private string endDate;
        private string username;


        public int ProjectId
        {
            get
            {
                return projectId;
            }
            set
            {
                projectId = value;
            }
        }

        public String ProjectName
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
        public String CreatedDate
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
        public String EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }

        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }


    }
}
