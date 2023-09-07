using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities.Users
{
    /// <summary>
    /// Defines the <see cref="UserEntity" />.
    /// </summary>
    public class UserEntity
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserID { get; set; }


        /// <summary>
        /// Gets or Sets name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets  User NRC
        /// </summary>
        public String UserNRC { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// Gets or sets User Email
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets User gender
        /// </summary>
        public char UserGender { get; set; }

        /// <summary>
        /// Gets or sets Address
        /// </summary>
        public string UserAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntity"/> class.
        /// </summary>
        public UserEntity()
        {
            InitializedObjectValue();
        }

        /// <summary>
        /// The InitializedObjectValue.
        /// </summary>
        internal void InitializedObjectValue()
        {
            this.UserID = 0;
            this.UserName = String.Empty;
            this.UserNRC = String.Empty;
            this.UserPhone = String.Empty;
            this.UserEmail = String.Empty;
            this.UserAddress = String.Empty;
        }
    }
}
