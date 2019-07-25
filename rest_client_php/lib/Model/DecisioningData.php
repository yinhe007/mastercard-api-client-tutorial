<?php
/**
 * DecisioningData
 *
 * PHP version 5
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.
 *
 * The version of the OpenAPI document: 1.2.7
 * 
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 4.0.2
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Model;

use \ArrayAccess;
use \OpenAPI\Client\ObjectSerializer;

/**
 * DecisioningData Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class DecisioningData implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'DecisioningData';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'recommendation' => 'string',
        'recommendation_algorithm_version' => 'string',
        'device_score' => 'string',
        'account_score' => 'string',
        'recommendation_reasons' => 'string[]',
        'device_current_location' => 'string',
        'device_ip_address' => 'string',
        'mobile_number_suffix' => 'string',
        'account_id_hash' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPIFormats = [
        'recommendation' => null,
        'recommendation_algorithm_version' => null,
        'device_score' => null,
        'account_score' => null,
        'recommendation_reasons' => null,
        'device_current_location' => null,
        'device_ip_address' => null,
        'mobile_number_suffix' => null,
        'account_id_hash' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'recommendation' => 'recommendation',
        'recommendation_algorithm_version' => 'recommendationAlgorithmVersion',
        'device_score' => 'deviceScore',
        'account_score' => 'accountScore',
        'recommendation_reasons' => 'recommendationReasons',
        'device_current_location' => 'deviceCurrentLocation',
        'device_ip_address' => 'deviceIpAddress',
        'mobile_number_suffix' => 'mobileNumberSuffix',
        'account_id_hash' => 'accountIdHash'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'recommendation' => 'setRecommendation',
        'recommendation_algorithm_version' => 'setRecommendationAlgorithmVersion',
        'device_score' => 'setDeviceScore',
        'account_score' => 'setAccountScore',
        'recommendation_reasons' => 'setRecommendationReasons',
        'device_current_location' => 'setDeviceCurrentLocation',
        'device_ip_address' => 'setDeviceIpAddress',
        'mobile_number_suffix' => 'setMobileNumberSuffix',
        'account_id_hash' => 'setAccountIdHash'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'recommendation' => 'getRecommendation',
        'recommendation_algorithm_version' => 'getRecommendationAlgorithmVersion',
        'device_score' => 'getDeviceScore',
        'account_score' => 'getAccountScore',
        'recommendation_reasons' => 'getRecommendationReasons',
        'device_current_location' => 'getDeviceCurrentLocation',
        'device_ip_address' => 'getDeviceIpAddress',
        'mobile_number_suffix' => 'getMobileNumberSuffix',
        'account_id_hash' => 'getAccountIdHash'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }

    

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['recommendation'] = isset($data['recommendation']) ? $data['recommendation'] : null;
        $this->container['recommendation_algorithm_version'] = isset($data['recommendation_algorithm_version']) ? $data['recommendation_algorithm_version'] : null;
        $this->container['device_score'] = isset($data['device_score']) ? $data['device_score'] : null;
        $this->container['account_score'] = isset($data['account_score']) ? $data['account_score'] : null;
        $this->container['recommendation_reasons'] = isset($data['recommendation_reasons']) ? $data['recommendation_reasons'] : null;
        $this->container['device_current_location'] = isset($data['device_current_location']) ? $data['device_current_location'] : null;
        $this->container['device_ip_address'] = isset($data['device_ip_address']) ? $data['device_ip_address'] : null;
        $this->container['mobile_number_suffix'] = isset($data['mobile_number_suffix']) ? $data['mobile_number_suffix'] : null;
        $this->container['account_id_hash'] = isset($data['account_id_hash']) ? $data['account_id_hash'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets recommendation
     *
     * @return string|null
     */
    public function getRecommendation()
    {
        return $this->container['recommendation'];
    }

    /**
     * Sets recommendation
     *
     * @param string|null $recommendation __(OPTIONAL)__ <br> Digitization decision recommended by the Token Requestor. Must be either APPROVED (Recommend a decision of Approved), DECLINED (Recommend a decision of Decline). <br>   __Max Length:64__
     *
     * @return $this
     */
    public function setRecommendation($recommendation)
    {
        $this->container['recommendation'] = $recommendation;

        return $this;
    }

    /**
     * Gets recommendation_algorithm_version
     *
     * @return string|null
     */
    public function getRecommendationAlgorithmVersion()
    {
        return $this->container['recommendation_algorithm_version'];
    }

    /**
     * Sets recommendation_algorithm_version
     *
     * @param string|null $recommendation_algorithm_version __(OPTIONAL)__ <br> Version of the algorithm used by the Token Requestor to determine its recommendation. Must be a value of \"01\". Other values may be supported in the future.<br>     __Max Length:16__
     *
     * @return $this
     */
    public function setRecommendationAlgorithmVersion($recommendation_algorithm_version)
    {
        $this->container['recommendation_algorithm_version'] = $recommendation_algorithm_version;

        return $this;
    }

    /**
     * Gets device_score
     *
     * @return string|null
     */
    public function getDeviceScore()
    {
        return $this->container['device_score'];
    }

    /**
     * Sets device_score
     *
     * @param string|null $device_score __(OPTIONAL)__ <br> Score assigned by the Token Requestor for the target device being provisioned. Must be a value from 1 to 5.
     *
     * @return $this
     */
    public function setDeviceScore($device_score)
    {
        $this->container['device_score'] = $device_score;

        return $this;
    }

    /**
     * Gets account_score
     *
     * @return string|null
     */
    public function getAccountScore()
    {
        return $this->container['account_score'];
    }

    /**
     * Sets account_score
     *
     * @param string|null $account_score __(OPTIONAL)__ <br> Score assigned by the Token Requestor for the consumer account or relationship. Must be a value from 1 to 5.
     *
     * @return $this
     */
    public function setAccountScore($account_score)
    {
        $this->container['account_score'] = $account_score;

        return $this;
    }

    /**
     * Gets recommendation_reasons
     *
     * @return string[]|null
     */
    public function getRecommendationReasons()
    {
        return $this->container['recommendation_reasons'];
    }

    /**
     * Sets recommendation_reasons
     *
     * @param string[]|null $recommendation_reasons __(OPTIONAL)__ <br> Code indicating the reasons the Token Requestor is suggesting the digitization decision.  See table here - https://developer.mastercard.com/page/mdes-digitization-recommendation-reason-codes
     *
     * @return $this
     */
    public function setRecommendationReasons($recommendation_reasons)
    {
        $this->container['recommendation_reasons'] = $recommendation_reasons;

        return $this;
    }

    /**
     * Gets device_current_location
     *
     * @return string|null
     */
    public function getDeviceCurrentLocation()
    {
        return $this->container['device_current_location'];
    }

    /**
     * Sets device_current_location
     *
     * @param string|null $device_current_location __(OPTIONAL)__ <br> Latitude and longitude in the format \"(sign) latitude, (sign) longitude\" with a precision of 2 decimal places.  Ex - \"38.63, -90.25\"  Latitude is between -90 and 90.  Longitude between -180 and 180. Relates to the target device being provisioned. If there is no target device, then this should be the current consumer location, if available. <br>    __Max Length:14__
     *
     * @return $this
     */
    public function setDeviceCurrentLocation($device_current_location)
    {
        $this->container['device_current_location'] = $device_current_location;

        return $this;
    }

    /**
     * Gets device_ip_address
     *
     * @return string|null
     */
    public function getDeviceIpAddress()
    {
        return $this->container['device_ip_address'];
    }

    /**
     * Sets device_ip_address
     *
     * @param string|null $device_ip_address __(OPTIONAL)__ <br> The IP address of the device through which the device reaches the internet. This may be a temporary or permanent IP address assigned to a home router, or the IP address of a gateway through which the device connects to a network. IPv4 address format of 4 octets separated by \".\" Ex - 127.0.0.1 Relates to the target device being provisioned. If there is no target device, then this should be the current consumer IP address, if available.<br>     __Max Length:15__
     *
     * @return $this
     */
    public function setDeviceIpAddress($device_ip_address)
    {
        $this->container['device_ip_address'] = $device_ip_address;

        return $this;
    }

    /**
     * Gets mobile_number_suffix
     *
     * @return string|null
     */
    public function getMobileNumberSuffix()
    {
        return $this->container['mobile_number_suffix'];
    }

    /**
     * Sets mobile_number_suffix
     *
     * @param string|null $mobile_number_suffix __(OPTIONAL)__<br> The last few digits (typically four) of the consumer's mobile phone number as available on file or on the consumer's current device, which may or may not be the mobile number of the target device being provisioned.<br>     __Max Length:32__
     *
     * @return $this
     */
    public function setMobileNumberSuffix($mobile_number_suffix)
    {
        $this->container['mobile_number_suffix'] = $mobile_number_suffix;

        return $this;
    }

    /**
     * Gets account_id_hash
     *
     * @return string|null
     */
    public function getAccountIdHash()
    {
        return $this->container['account_id_hash'];
    }

    /**
     * Sets account_id_hash
     *
     * @param string|null $account_id_hash __(OPTIONAL)__ <br> SHA-256 hash of the Cardholder�s account ID with the Token Requestor. Typically expected to be an email address.<br>  __Max Length:64__ Alpha-Numeric and Hex-encoded data (case-insensitive).
     *
     * @return $this
     */
    public function setAccountIdHash($account_id_hash)
    {
        $this->container['account_id_hash'] = $account_id_hash;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }
}


