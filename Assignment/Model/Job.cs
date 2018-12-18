using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

    class Job
    {
        /// <summary>
        /// Primary Key Unique Identifier for the job.
        /// </summary>
        [Key]
        private int m_jobID;

        /// <summary>
        /// Primary Key Unique Identifier for the job.
        /// </summary>
        public int JobID
        {
            get { return m_jobID; }
            set { m_jobID = value; }
        }

        /// <summary>
        /// Unique Identifier for the client who created the job.
        /// </summary>
        [ForeignKey("ClientID")]
        private int m_clientID;

        /// <summary>
        /// Unique Identifier for the client who created the job.
        /// </summary>
        public int ClientID
        {
            get { return m_clientID; }
            set { m_clientID = value; }
        }

        /// <summary>
        /// Description for the job requested.
        /// </summary>
        [MinLength(0), MaxLength(255)]
        private string m_faultDescription;

        /// <summary>
        /// Description for the job requested.
        /// </summary>
        public string FaultDescription
        {
            get { return m_faultDescription; }
            set { m_faultDescription = value; }
        }

        [MinLength(0), MaxLength(155)]
        private string m_attachment;

        /// <summary>
        /// Any URL string attachments for media.
        /// </summary>
        public string Attachment
        {
            get { return m_attachment; }
            set { m_attachment = value; }
        }

        /// <summary>
        /// The severity of the job.
        /// </summary>
        private int m_urgency;

        /// <summary>
        /// The severity of the job.
        /// </summary>
        public int Urgency
        {
            get { return m_urgency; }
            set { m_urgency = value; }
        }

        /// <summary>
        /// Whether the job is currently open or not.
        /// </summary>
        private bool m_open;

        /// <summary>
        /// Whether the job is currently open or not.
        /// </summary>
        public bool Open
        {
            get { return m_open; }
            set { m_open = value; }
        }

    }
}
