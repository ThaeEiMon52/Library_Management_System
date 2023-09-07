namespace LMS.Entities.Staff
{
    using System;

    /// <summary>
    /// Defines the <see cref="StaffEntity"/>
    /// </summary>
    public class StaffEntity
    {
        /// <summary>
        /// Gets or sets the staff id.
        /// </summary>
        public int staff_id { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the photo.
        /// </summary>
        public byte[] photo { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        public char gender { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public int role { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="StaffEntity"/> class.
        /// </summary>

        public StaffEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.staff_id = 0;
            this.name = String.Empty;
            this.photo = null;
            this.password = String.Empty;
            this.phone = String.Empty;
            this.email = String.Empty;
            this.address = String.Empty;

            this.role = 0;
        }


    }
}