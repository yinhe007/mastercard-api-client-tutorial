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
    /// ProductConfig
    /// </summary>
    [DataContract]
    public partial class ProductConfig :  IEquatable<ProductConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfig" /> class.
        /// </summary>
        /// <param name="brandLogoAssetId">The MasterCard or Maestro brand logo associated with this card. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object &lt;br&gt;    __Max Length: 64__&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="issuerLogoAssetId">The logo of the issuing bank. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object &lt;br&gt;     __Max Length:64__&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="isCoBranded">Whether the product is co-branded. Must be either true (this is a co-branded product) or false (this is not a co-branded product). Always returned in Product Configuration object &lt;br&gt;    __Max Length:5__&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="coBrandName">Textual name of the co-brand partner. Required if CoBranded is true, not present otherwise.  &lt;br&gt;   __Max Length:128__&lt;br&gt; __Required: Conditional � required if isCoBranded &#x3D; \&quot;true\&quot;. Not present otherwise__ .</param>
        /// <param name="coBrandLogoAssetId">The co-brand logo (if any) for this product. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. &lt;br&gt;   __Max Length:64__&lt;br&gt; __Required: No__ .</param>
        /// <param name="cardBackgroundCombinedAssetId">The card image used to represent the digital card in the wallet. This �combined� option contains the MasterCard, bank and any co- brand logos.  Provided as an Asset ID � use the Get Asset API to retrieve the actual asset.     __Max Length:64__&lt;br&gt; __Required: Conditional � either CardBackgroundCombined or CardBackground will be provided__ .</param>
        /// <param name="cardBackgroundAssetId">The card image used to represent the digital card in the wallet. This �non-combined� option does not contain the MasterCard, bank, or co-brand logos. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. &lt;br&gt;     __Max Length:64__&lt;br&gt; __Required: Conditional � either CardBackgroundCombined or CardBackground will be provided__ .</param>
        /// <param name="iconAssetId">The icon representing the primary brand(s) associated with this product. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object&lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="foregroundColor">Foreground color, used to overlay text on top of the card image. Always returned in Product Configuration object&lt;br&gt;    __Max Length:6__ Hexadecimal RGB color format (case-insensitive).&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="issuerName">Name of the issuing bank. Always returned in Product Configuration object &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="shortDescription">A short description for this product. Always returned in Product Configuration object  &lt;br&gt;   __Max Length:128__&lt;br&gt; __Required: Yes__ .</param>
        /// <param name="longDescription">A long description for this product.  &lt;br&gt;   __Max Length:256__&lt;br&gt; __Required: No__ .</param>
        /// <param name="customerServiceUrl">Customer service website of the issuing bank. &lt;br&gt;    __Max Length:128__&lt;br&gt; __Required: No__ .</param>
        /// <param name="customerServiceEmail">Customer service email address of the issuing bank. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ .</param>
        /// <param name="customerServicePhoneNumber">Customer service phone number of the issuing bank. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ .</param>
        /// <param name="issuerMobileApp">Contains one or more mobile app details that may be used to deep link from the Mobile Payment App to the issuer mobile app. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ .</param>
        /// <param name="onlineBankingLoginUrl">Logon URL for the issuing bank�s online banking website.&lt;br&gt;     __Max Length:128__ .</param>
        /// <param name="termsAndConditionsUrl">URL linking to the issuing bank�s terms and conditions for this product.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ .</param>
        /// <param name="privacyPolicyUrl">URL linking to the issuing bank�s privacy policy for this product.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ .</param>
        /// <param name="issuerProductConfigCode">Freeform identifier for this product configuration as assigned by the issuer.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ .</param>
        public ProductConfig(string brandLogoAssetId = default(string), string issuerLogoAssetId = default(string), string isCoBranded = default(string), string coBrandName = default(string), string coBrandLogoAssetId = default(string), string cardBackgroundCombinedAssetId = default(string), string cardBackgroundAssetId = default(string), string iconAssetId = default(string), string foregroundColor = default(string), string issuerName = default(string), string shortDescription = default(string), string longDescription = default(string), string customerServiceUrl = default(string), string customerServiceEmail = default(string), string customerServicePhoneNumber = default(string), Object issuerMobileApp = default(Object), string onlineBankingLoginUrl = default(string), string termsAndConditionsUrl = default(string), string privacyPolicyUrl = default(string), string issuerProductConfigCode = default(string))
        {
            this.BrandLogoAssetId = brandLogoAssetId;
            this.IssuerLogoAssetId = issuerLogoAssetId;
            this.IsCoBranded = isCoBranded;
            this.CoBrandName = coBrandName;
            this.CoBrandLogoAssetId = coBrandLogoAssetId;
            this.CardBackgroundCombinedAssetId = cardBackgroundCombinedAssetId;
            this.CardBackgroundAssetId = cardBackgroundAssetId;
            this.IconAssetId = iconAssetId;
            this.ForegroundColor = foregroundColor;
            this.IssuerName = issuerName;
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
            this.CustomerServiceUrl = customerServiceUrl;
            this.CustomerServiceEmail = customerServiceEmail;
            this.CustomerServicePhoneNumber = customerServicePhoneNumber;
            this.IssuerMobileApp = issuerMobileApp;
            this.OnlineBankingLoginUrl = onlineBankingLoginUrl;
            this.TermsAndConditionsUrl = termsAndConditionsUrl;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.IssuerProductConfigCode = issuerProductConfigCode;
        }
        
        /// <summary>
        /// The MasterCard or Maestro brand logo associated with this card. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object &lt;br&gt;    __Max Length: 64__&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>The MasterCard or Maestro brand logo associated with this card. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object &lt;br&gt;    __Max Length: 64__&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="brandLogoAssetId", EmitDefaultValue=false)]
        public string BrandLogoAssetId { get; set; }

        /// <summary>
        /// The logo of the issuing bank. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object &lt;br&gt;     __Max Length:64__&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>The logo of the issuing bank. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object &lt;br&gt;     __Max Length:64__&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="issuerLogoAssetId", EmitDefaultValue=false)]
        public string IssuerLogoAssetId { get; set; }

        /// <summary>
        /// Whether the product is co-branded. Must be either true (this is a co-branded product) or false (this is not a co-branded product). Always returned in Product Configuration object &lt;br&gt;    __Max Length:5__&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>Whether the product is co-branded. Must be either true (this is a co-branded product) or false (this is not a co-branded product). Always returned in Product Configuration object &lt;br&gt;    __Max Length:5__&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="isCoBranded", EmitDefaultValue=false)]
        public string IsCoBranded { get; set; }

        /// <summary>
        /// Textual name of the co-brand partner. Required if CoBranded is true, not present otherwise.  &lt;br&gt;   __Max Length:128__&lt;br&gt; __Required: Conditional � required if isCoBranded &#x3D; \&quot;true\&quot;. Not present otherwise__ 
        /// </summary>
        /// <value>Textual name of the co-brand partner. Required if CoBranded is true, not present otherwise.  &lt;br&gt;   __Max Length:128__&lt;br&gt; __Required: Conditional � required if isCoBranded &#x3D; \&quot;true\&quot;. Not present otherwise__ </value>
        [DataMember(Name="coBrandName", EmitDefaultValue=false)]
        public string CoBrandName { get; set; }

        /// <summary>
        /// The co-brand logo (if any) for this product. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. &lt;br&gt;   __Max Length:64__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>The co-brand logo (if any) for this product. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. &lt;br&gt;   __Max Length:64__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="coBrandLogoAssetId", EmitDefaultValue=false)]
        public string CoBrandLogoAssetId { get; set; }

        /// <summary>
        /// The card image used to represent the digital card in the wallet. This �combined� option contains the MasterCard, bank and any co- brand logos.  Provided as an Asset ID � use the Get Asset API to retrieve the actual asset.     __Max Length:64__&lt;br&gt; __Required: Conditional � either CardBackgroundCombined or CardBackground will be provided__ 
        /// </summary>
        /// <value>The card image used to represent the digital card in the wallet. This �combined� option contains the MasterCard, bank and any co- brand logos.  Provided as an Asset ID � use the Get Asset API to retrieve the actual asset.     __Max Length:64__&lt;br&gt; __Required: Conditional � either CardBackgroundCombined or CardBackground will be provided__ </value>
        [DataMember(Name="cardBackgroundCombinedAssetId", EmitDefaultValue=false)]
        public string CardBackgroundCombinedAssetId { get; set; }

        /// <summary>
        /// The card image used to represent the digital card in the wallet. This �non-combined� option does not contain the MasterCard, bank, or co-brand logos. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. &lt;br&gt;     __Max Length:64__&lt;br&gt; __Required: Conditional � either CardBackgroundCombined or CardBackground will be provided__ 
        /// </summary>
        /// <value>The card image used to represent the digital card in the wallet. This �non-combined� option does not contain the MasterCard, bank, or co-brand logos. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. &lt;br&gt;     __Max Length:64__&lt;br&gt; __Required: Conditional � either CardBackgroundCombined or CardBackground will be provided__ </value>
        [DataMember(Name="cardBackgroundAssetId", EmitDefaultValue=false)]
        public string CardBackgroundAssetId { get; set; }

        /// <summary>
        /// The icon representing the primary brand(s) associated with this product. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object&lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>The icon representing the primary brand(s) associated with this product. Provided as an Asset ID � use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object&lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="iconAssetId", EmitDefaultValue=false)]
        public string IconAssetId { get; set; }

        /// <summary>
        /// Foreground color, used to overlay text on top of the card image. Always returned in Product Configuration object&lt;br&gt;    __Max Length:6__ Hexadecimal RGB color format (case-insensitive).&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>Foreground color, used to overlay text on top of the card image. Always returned in Product Configuration object&lt;br&gt;    __Max Length:6__ Hexadecimal RGB color format (case-insensitive).&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="foregroundColor", EmitDefaultValue=false)]
        public string ForegroundColor { get; set; }

        /// <summary>
        /// Name of the issuing bank. Always returned in Product Configuration object &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>Name of the issuing bank. Always returned in Product Configuration object &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="issuerName", EmitDefaultValue=false)]
        public string IssuerName { get; set; }

        /// <summary>
        /// A short description for this product. Always returned in Product Configuration object  &lt;br&gt;   __Max Length:128__&lt;br&gt; __Required: Yes__ 
        /// </summary>
        /// <value>A short description for this product. Always returned in Product Configuration object  &lt;br&gt;   __Max Length:128__&lt;br&gt; __Required: Yes__ </value>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A long description for this product.  &lt;br&gt;   __Max Length:256__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>A long description for this product.  &lt;br&gt;   __Max Length:256__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="longDescription", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Customer service website of the issuing bank. &lt;br&gt;    __Max Length:128__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>Customer service website of the issuing bank. &lt;br&gt;    __Max Length:128__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="customerServiceUrl", EmitDefaultValue=false)]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// Customer service email address of the issuing bank. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>Customer service email address of the issuing bank. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="customerServiceEmail", EmitDefaultValue=false)]
        public string CustomerServiceEmail { get; set; }

        /// <summary>
        /// Customer service phone number of the issuing bank. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>Customer service phone number of the issuing bank. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="customerServicePhoneNumber", EmitDefaultValue=false)]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Contains one or more mobile app details that may be used to deep link from the Mobile Payment App to the issuer mobile app. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>Contains one or more mobile app details that may be used to deep link from the Mobile Payment App to the issuer mobile app. &lt;br&gt;    __Max Length:64__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="issuerMobileApp", EmitDefaultValue=false)]
        public Object IssuerMobileApp { get; set; }

        /// <summary>
        /// Logon URL for the issuing bank�s online banking website.&lt;br&gt;     __Max Length:128__ 
        /// </summary>
        /// <value>Logon URL for the issuing bank�s online banking website.&lt;br&gt;     __Max Length:128__ </value>
        [DataMember(Name="onlineBankingLoginUrl", EmitDefaultValue=false)]
        public string OnlineBankingLoginUrl { get; set; }

        /// <summary>
        /// URL linking to the issuing bank�s terms and conditions for this product.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>URL linking to the issuing bank�s terms and conditions for this product.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="termsAndConditionsUrl", EmitDefaultValue=false)]
        public string TermsAndConditionsUrl { get; set; }

        /// <summary>
        /// URL linking to the issuing bank�s privacy policy for this product.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>URL linking to the issuing bank�s privacy policy for this product.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="privacyPolicyUrl", EmitDefaultValue=false)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Freeform identifier for this product configuration as assigned by the issuer.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ 
        /// </summary>
        /// <value>Freeform identifier for this product configuration as assigned by the issuer.&lt;br&gt;     __Max Length:128__&lt;br&gt; __Required: No__ </value>
        [DataMember(Name="issuerProductConfigCode", EmitDefaultValue=false)]
        public string IssuerProductConfigCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductConfig {\n");
            sb.Append("  BrandLogoAssetId: ").Append(BrandLogoAssetId).Append("\n");
            sb.Append("  IssuerLogoAssetId: ").Append(IssuerLogoAssetId).Append("\n");
            sb.Append("  IsCoBranded: ").Append(IsCoBranded).Append("\n");
            sb.Append("  CoBrandName: ").Append(CoBrandName).Append("\n");
            sb.Append("  CoBrandLogoAssetId: ").Append(CoBrandLogoAssetId).Append("\n");
            sb.Append("  CardBackgroundCombinedAssetId: ").Append(CardBackgroundCombinedAssetId).Append("\n");
            sb.Append("  CardBackgroundAssetId: ").Append(CardBackgroundAssetId).Append("\n");
            sb.Append("  IconAssetId: ").Append(IconAssetId).Append("\n");
            sb.Append("  ForegroundColor: ").Append(ForegroundColor).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  CustomerServiceUrl: ").Append(CustomerServiceUrl).Append("\n");
            sb.Append("  CustomerServiceEmail: ").Append(CustomerServiceEmail).Append("\n");
            sb.Append("  CustomerServicePhoneNumber: ").Append(CustomerServicePhoneNumber).Append("\n");
            sb.Append("  IssuerMobileApp: ").Append(IssuerMobileApp).Append("\n");
            sb.Append("  OnlineBankingLoginUrl: ").Append(OnlineBankingLoginUrl).Append("\n");
            sb.Append("  TermsAndConditionsUrl: ").Append(TermsAndConditionsUrl).Append("\n");
            sb.Append("  PrivacyPolicyUrl: ").Append(PrivacyPolicyUrl).Append("\n");
            sb.Append("  IssuerProductConfigCode: ").Append(IssuerProductConfigCode).Append("\n");
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
            return this.Equals(input as ProductConfig);
        }

        /// <summary>
        /// Returns true if ProductConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrandLogoAssetId == input.BrandLogoAssetId ||
                    (this.BrandLogoAssetId != null &&
                    this.BrandLogoAssetId.Equals(input.BrandLogoAssetId))
                ) && 
                (
                    this.IssuerLogoAssetId == input.IssuerLogoAssetId ||
                    (this.IssuerLogoAssetId != null &&
                    this.IssuerLogoAssetId.Equals(input.IssuerLogoAssetId))
                ) && 
                (
                    this.IsCoBranded == input.IsCoBranded ||
                    (this.IsCoBranded != null &&
                    this.IsCoBranded.Equals(input.IsCoBranded))
                ) && 
                (
                    this.CoBrandName == input.CoBrandName ||
                    (this.CoBrandName != null &&
                    this.CoBrandName.Equals(input.CoBrandName))
                ) && 
                (
                    this.CoBrandLogoAssetId == input.CoBrandLogoAssetId ||
                    (this.CoBrandLogoAssetId != null &&
                    this.CoBrandLogoAssetId.Equals(input.CoBrandLogoAssetId))
                ) && 
                (
                    this.CardBackgroundCombinedAssetId == input.CardBackgroundCombinedAssetId ||
                    (this.CardBackgroundCombinedAssetId != null &&
                    this.CardBackgroundCombinedAssetId.Equals(input.CardBackgroundCombinedAssetId))
                ) && 
                (
                    this.CardBackgroundAssetId == input.CardBackgroundAssetId ||
                    (this.CardBackgroundAssetId != null &&
                    this.CardBackgroundAssetId.Equals(input.CardBackgroundAssetId))
                ) && 
                (
                    this.IconAssetId == input.IconAssetId ||
                    (this.IconAssetId != null &&
                    this.IconAssetId.Equals(input.IconAssetId))
                ) && 
                (
                    this.ForegroundColor == input.ForegroundColor ||
                    (this.ForegroundColor != null &&
                    this.ForegroundColor.Equals(input.ForegroundColor))
                ) && 
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
                ) && 
                (
                    this.CustomerServiceUrl == input.CustomerServiceUrl ||
                    (this.CustomerServiceUrl != null &&
                    this.CustomerServiceUrl.Equals(input.CustomerServiceUrl))
                ) && 
                (
                    this.CustomerServiceEmail == input.CustomerServiceEmail ||
                    (this.CustomerServiceEmail != null &&
                    this.CustomerServiceEmail.Equals(input.CustomerServiceEmail))
                ) && 
                (
                    this.CustomerServicePhoneNumber == input.CustomerServicePhoneNumber ||
                    (this.CustomerServicePhoneNumber != null &&
                    this.CustomerServicePhoneNumber.Equals(input.CustomerServicePhoneNumber))
                ) && 
                (
                    this.IssuerMobileApp == input.IssuerMobileApp ||
                    (this.IssuerMobileApp != null &&
                    this.IssuerMobileApp.Equals(input.IssuerMobileApp))
                ) && 
                (
                    this.OnlineBankingLoginUrl == input.OnlineBankingLoginUrl ||
                    (this.OnlineBankingLoginUrl != null &&
                    this.OnlineBankingLoginUrl.Equals(input.OnlineBankingLoginUrl))
                ) && 
                (
                    this.TermsAndConditionsUrl == input.TermsAndConditionsUrl ||
                    (this.TermsAndConditionsUrl != null &&
                    this.TermsAndConditionsUrl.Equals(input.TermsAndConditionsUrl))
                ) && 
                (
                    this.PrivacyPolicyUrl == input.PrivacyPolicyUrl ||
                    (this.PrivacyPolicyUrl != null &&
                    this.PrivacyPolicyUrl.Equals(input.PrivacyPolicyUrl))
                ) && 
                (
                    this.IssuerProductConfigCode == input.IssuerProductConfigCode ||
                    (this.IssuerProductConfigCode != null &&
                    this.IssuerProductConfigCode.Equals(input.IssuerProductConfigCode))
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
                if (this.BrandLogoAssetId != null)
                    hashCode = hashCode * 59 + this.BrandLogoAssetId.GetHashCode();
                if (this.IssuerLogoAssetId != null)
                    hashCode = hashCode * 59 + this.IssuerLogoAssetId.GetHashCode();
                if (this.IsCoBranded != null)
                    hashCode = hashCode * 59 + this.IsCoBranded.GetHashCode();
                if (this.CoBrandName != null)
                    hashCode = hashCode * 59 + this.CoBrandName.GetHashCode();
                if (this.CoBrandLogoAssetId != null)
                    hashCode = hashCode * 59 + this.CoBrandLogoAssetId.GetHashCode();
                if (this.CardBackgroundCombinedAssetId != null)
                    hashCode = hashCode * 59 + this.CardBackgroundCombinedAssetId.GetHashCode();
                if (this.CardBackgroundAssetId != null)
                    hashCode = hashCode * 59 + this.CardBackgroundAssetId.GetHashCode();
                if (this.IconAssetId != null)
                    hashCode = hashCode * 59 + this.IconAssetId.GetHashCode();
                if (this.ForegroundColor != null)
                    hashCode = hashCode * 59 + this.ForegroundColor.GetHashCode();
                if (this.IssuerName != null)
                    hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.CustomerServiceUrl != null)
                    hashCode = hashCode * 59 + this.CustomerServiceUrl.GetHashCode();
                if (this.CustomerServiceEmail != null)
                    hashCode = hashCode * 59 + this.CustomerServiceEmail.GetHashCode();
                if (this.CustomerServicePhoneNumber != null)
                    hashCode = hashCode * 59 + this.CustomerServicePhoneNumber.GetHashCode();
                if (this.IssuerMobileApp != null)
                    hashCode = hashCode * 59 + this.IssuerMobileApp.GetHashCode();
                if (this.OnlineBankingLoginUrl != null)
                    hashCode = hashCode * 59 + this.OnlineBankingLoginUrl.GetHashCode();
                if (this.TermsAndConditionsUrl != null)
                    hashCode = hashCode * 59 + this.TermsAndConditionsUrl.GetHashCode();
                if (this.PrivacyPolicyUrl != null)
                    hashCode = hashCode * 59 + this.PrivacyPolicyUrl.GetHashCode();
                if (this.IssuerProductConfigCode != null)
                    hashCode = hashCode * 59 + this.IssuerProductConfigCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
