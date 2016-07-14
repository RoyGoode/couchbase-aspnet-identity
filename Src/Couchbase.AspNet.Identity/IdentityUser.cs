using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;

namespace Couchbase.AspNet.Identity
{
    /// <summary>
    /// Represents a user on the system and properties associated with that user.
    /// </summary>
    public class IdentityUser : IUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityUser"/> class.
        /// </summary>
        public IdentityUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityUser"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        public IdentityUser(string username)
        {
            UserName = username;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the user; this is a key in couchbase.
        /// </summary>
        /// <value>
        /// The identifier used to uniquely identify the user.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the email for the user.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user's email has been confirmed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the user's email has been confirmed; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("emailConfirmed")]
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the password hash for the user.
        /// </summary>
        /// <value>
        /// The password hash.
        /// </value>
        [JsonProperty("passwordHash")]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the phone number for the user.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="PhoneNumber"/> was confirmed.
        /// </summary>
        /// <value>
        /// <c>true</c> if the  <see cref="PhoneNumber"/>confirmed; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("phoneNumberConfirmed")]
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// DateTime in UTC when lockout ends, any time in the past is considered not locked out.
        /// </summary>
        [JsonProperty("lockoutEndDateUtc")]
        public DateTime? LockoutEndDateUtc { get; set; }

        /// <summary>
        /// Is lockout enabled for this user
        /// </summary>
        [JsonProperty("lockoutEnabled")]
        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Used to record failures for the purposes of lockout
        /// </summary>
        [JsonProperty("accessFailedCount")]
        public int AccessFailedCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether two factor authentication is enabled for a user.
        /// </summary>
        /// <value>
        ///   <c>true</c> if two factor authentication is enabled; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("twoFactorEnabled")]
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the user login infos.
        /// </summary>
        /// <value>
        /// The user login infos.
        /// </value>
        [JsonProperty("userLoginIds")]
        public IList<string> UserLoginIds { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the security stamp.
        /// </summary>
        /// <value>
        /// The security stamp.
        /// </value>
        [JsonProperty("securityStamp")]
        public string SecurityStamp { get; set; }

        /// <summary>
        /// Gets or sets the roles the user belongs to.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        [JsonProperty("roles")]
        public ICollection<IdentityRole> Roles { get; set; } = new List<IdentityRole>();

        /// <summary>
        /// Gets or sets the claims for the user.
        /// </summary>
        /// <value>
        /// The claims.
        /// </value>
        [JsonProperty("claims")]
        public ICollection<Claim> Claims { get; set; } = new List<Claim>();

        [JsonProperty("type")]
        public string Type { get; set; } = "user";
    }
}