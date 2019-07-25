/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * The version of the OpenAPI document: 1.2.7
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Mastercard.Developer.DigitalEnablement.Client.Client.OpenAPIDateConverter;

namespace Mastercard.Developer.DigitalEnablement.Client.Model
{
    /// <summary>
    /// NotifyTokenUpdatedRequestSchema
    /// </summary>
    [DataContract]
    public partial class NotifyTokenUpdatedRequestSchema :  IEquatable<NotifyTokenUpdatedRequestSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyTokenUpdatedRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotifyTokenUpdatedRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyTokenUpdatedRequestSchema" /> class.
        /// </summary>
        /// <param name="responseHost">The host that originated the request. Future calls in the same conversation should be routed to this host.  (required).</param>
        /// <param name="requestId">Unique identifier for the request.  (required).</param>
        /// <param name="encryptedPayload">encryptedPayload (required).</param>
        public NotifyTokenUpdatedRequestSchema(string responseHost = default(string), string requestId = default(string), EncryptedPayload encryptedPayload = default(EncryptedPayload))
        {
            // to ensure "responseHost" is required (not null)
            if (responseHost == null)
            {
                throw new InvalidDataException("responseHost is a required property for NotifyTokenUpdatedRequestSchema and cannot be null");
            }
            else
            {
                this.ResponseHost = responseHost;
            }
            
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for NotifyTokenUpdatedRequestSchema and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            
            // to ensure "encryptedPayload" is required (not null)
            if (encryptedPayload == null)
            {
                throw new InvalidDataException("encryptedPayload is a required property for NotifyTokenUpdatedRequestSchema and cannot be null");
            }
            else
            {
                this.EncryptedPayload = encryptedPayload;
            }
            
        }
        
        /// <summary>
        /// The host that originated the request. Future calls in the same conversation should be routed to this host. 
        /// </summary>
        /// <value>The host that originated the request. Future calls in the same conversation should be routed to this host. </value>
        [DataMember(Name="responseHost", EmitDefaultValue=false)]
        public string ResponseHost { get; set; }

        /// <summary>
        /// Unique identifier for the request. 
        /// </summary>
        /// <value>Unique identifier for the request. </value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedPayload
        /// </summary>
        [DataMember(Name="encryptedPayload", EmitDefaultValue=false)]
        public EncryptedPayload EncryptedPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifyTokenUpdatedRequestSchema {\n");
            sb.Append("  ResponseHost: ").Append(ResponseHost).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  EncryptedPayload: ").Append(EncryptedPayload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotifyTokenUpdatedRequestSchema);
        }

        /// <summary>
        /// Returns true if NotifyTokenUpdatedRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyTokenUpdatedRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyTokenUpdatedRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseHost == input.ResponseHost ||
                    (this.ResponseHost != null &&
                    this.ResponseHost.Equals(input.ResponseHost))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.EncryptedPayload == input.EncryptedPayload ||
                    (this.EncryptedPayload != null &&
                    this.EncryptedPayload.Equals(input.EncryptedPayload))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResponseHost != null)
                    hashCode = hashCode * 59 + this.ResponseHost.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.EncryptedPayload != null)
                    hashCode = hashCode * 59 + this.EncryptedPayload.GetHashCode();
                return hashCode;
            }
        }
    }

}
