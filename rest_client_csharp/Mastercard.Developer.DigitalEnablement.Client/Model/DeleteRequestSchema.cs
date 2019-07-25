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
    /// DeleteRequestSchema
    /// </summary>
    [DataContract]
    public partial class DeleteRequestSchema :  IEquatable<DeleteRequestSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestSchema" /> class.
        /// </summary>
        /// <param name="responseHost">The host that originated the request. Future calls in the same conversation may be routed to this host. .</param>
        /// <param name="requestId">Unique identifier for the request.  (required).</param>
        /// <param name="paymentAppInstanceId">Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server based tokens but required otherwise.     __Max Length:48__ .</param>
        /// <param name="tokenUniqueReferences">The specific Token to be deleted. Array of more or more valid references as assigned by MDES   (required).</param>
        /// <param name="causedBy">Who or what caused the Token to be deleted. Must be either the &#39;CARDHOLDER&#39; (operation requested by the Cardholder) or &#39;TOKEN_REQUESTOR&#39; (operation requested by the token requestor).    __Max Length:64__  (required).</param>
        /// <param name="reason">Free form reason why the Tokens are being suspended.     __Max Length:256__ .</param>
        /// <param name="reasonCode">The reason for the action to be deleted. Must be one of &#39;SUSPECTED_FRAUD&#39; (suspected fraudulent token transactions), &#39;OTHER&#39; (Other - default used if value not provided).     __Max Length:64__  (required).</param>
        public DeleteRequestSchema(string responseHost = default(string), string requestId = default(string), string paymentAppInstanceId = default(string), List<string> tokenUniqueReferences = default(List<string>), string causedBy = default(string), string reason = default(string), string reasonCode = default(string))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for DeleteRequestSchema and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            
            // to ensure "tokenUniqueReferences" is required (not null)
            if (tokenUniqueReferences == null)
            {
                throw new InvalidDataException("tokenUniqueReferences is a required property for DeleteRequestSchema and cannot be null");
            }
            else
            {
                this.TokenUniqueReferences = tokenUniqueReferences;
            }
            
            // to ensure "causedBy" is required (not null)
            if (causedBy == null)
            {
                throw new InvalidDataException("causedBy is a required property for DeleteRequestSchema and cannot be null");
            }
            else
            {
                this.CausedBy = causedBy;
            }
            
            // to ensure "reasonCode" is required (not null)
            if (reasonCode == null)
            {
                throw new InvalidDataException("reasonCode is a required property for DeleteRequestSchema and cannot be null");
            }
            else
            {
                this.ReasonCode = reasonCode;
            }
            
            this.ResponseHost = responseHost;
            this.PaymentAppInstanceId = paymentAppInstanceId;
            this.Reason = reason;
        }
        
        /// <summary>
        /// The host that originated the request. Future calls in the same conversation may be routed to this host. 
        /// </summary>
        /// <value>The host that originated the request. Future calls in the same conversation may be routed to this host. </value>
        [DataMember(Name="responseHost", EmitDefaultValue=false)]
        public string ResponseHost { get; set; }

        /// <summary>
        /// Unique identifier for the request. 
        /// </summary>
        /// <value>Unique identifier for the request. </value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server based tokens but required otherwise.     __Max Length:48__ 
        /// </summary>
        /// <value>Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server based tokens but required otherwise.     __Max Length:48__ </value>
        [DataMember(Name="paymentAppInstanceId", EmitDefaultValue=false)]
        public string PaymentAppInstanceId { get; set; }

        /// <summary>
        /// The specific Token to be deleted. Array of more or more valid references as assigned by MDES  
        /// </summary>
        /// <value>The specific Token to be deleted. Array of more or more valid references as assigned by MDES  </value>
        [DataMember(Name="tokenUniqueReferences", EmitDefaultValue=false)]
        public List<string> TokenUniqueReferences { get; set; }

        /// <summary>
        /// Who or what caused the Token to be deleted. Must be either the &#39;CARDHOLDER&#39; (operation requested by the Cardholder) or &#39;TOKEN_REQUESTOR&#39; (operation requested by the token requestor).    __Max Length:64__ 
        /// </summary>
        /// <value>Who or what caused the Token to be deleted. Must be either the &#39;CARDHOLDER&#39; (operation requested by the Cardholder) or &#39;TOKEN_REQUESTOR&#39; (operation requested by the token requestor).    __Max Length:64__ </value>
        [DataMember(Name="causedBy", EmitDefaultValue=false)]
        public string CausedBy { get; set; }

        /// <summary>
        /// Free form reason why the Tokens are being suspended.     __Max Length:256__ 
        /// </summary>
        /// <value>Free form reason why the Tokens are being suspended.     __Max Length:256__ </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The reason for the action to be deleted. Must be one of &#39;SUSPECTED_FRAUD&#39; (suspected fraudulent token transactions), &#39;OTHER&#39; (Other - default used if value not provided).     __Max Length:64__ 
        /// </summary>
        /// <value>The reason for the action to be deleted. Must be one of &#39;SUSPECTED_FRAUD&#39; (suspected fraudulent token transactions), &#39;OTHER&#39; (Other - default used if value not provided).     __Max Length:64__ </value>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRequestSchema {\n");
            sb.Append("  ResponseHost: ").Append(ResponseHost).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  PaymentAppInstanceId: ").Append(PaymentAppInstanceId).Append("\n");
            sb.Append("  TokenUniqueReferences: ").Append(TokenUniqueReferences).Append("\n");
            sb.Append("  CausedBy: ").Append(CausedBy).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
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
            return this.Equals(input as DeleteRequestSchema);
        }

        /// <summary>
        /// Returns true if DeleteRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRequestSchema input)
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
                    this.PaymentAppInstanceId == input.PaymentAppInstanceId ||
                    (this.PaymentAppInstanceId != null &&
                    this.PaymentAppInstanceId.Equals(input.PaymentAppInstanceId))
                ) && 
                (
                    this.TokenUniqueReferences == input.TokenUniqueReferences ||
                    this.TokenUniqueReferences != null &&
                    input.TokenUniqueReferences != null &&
                    this.TokenUniqueReferences.SequenceEqual(input.TokenUniqueReferences)
                ) && 
                (
                    this.CausedBy == input.CausedBy ||
                    (this.CausedBy != null &&
                    this.CausedBy.Equals(input.CausedBy))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
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
                if (this.PaymentAppInstanceId != null)
                    hashCode = hashCode * 59 + this.PaymentAppInstanceId.GetHashCode();
                if (this.TokenUniqueReferences != null)
                    hashCode = hashCode * 59 + this.TokenUniqueReferences.GetHashCode();
                if (this.CausedBy != null)
                    hashCode = hashCode * 59 + this.CausedBy.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
