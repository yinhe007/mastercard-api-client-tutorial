<?php
/**
 * EncryptedPayloadTransact
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
 * EncryptedPayloadTransact Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class EncryptedPayloadTransact implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'encryptedPayloadTransact';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'public_key_fingerprint' => 'string',
        'encrypted_key' => 'string',
        'oaep_hashing_algorithm' => 'string',
        'iv' => 'string',
        'encrypted_data' => '\OpenAPI\Client\Model\TransactEncryptedData'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPIFormats = [
        'public_key_fingerprint' => null,
        'encrypted_key' => null,
        'oaep_hashing_algorithm' => null,
        'iv' => null,
        'encrypted_data' => null
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
        'public_key_fingerprint' => 'publicKeyFingerprint',
        'encrypted_key' => 'encryptedKey',
        'oaep_hashing_algorithm' => 'oaepHashingAlgorithm',
        'iv' => 'iv',
        'encrypted_data' => 'encryptedData'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'public_key_fingerprint' => 'setPublicKeyFingerprint',
        'encrypted_key' => 'setEncryptedKey',
        'oaep_hashing_algorithm' => 'setOaepHashingAlgorithm',
        'iv' => 'setIv',
        'encrypted_data' => 'setEncryptedData'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'public_key_fingerprint' => 'getPublicKeyFingerprint',
        'encrypted_key' => 'getEncryptedKey',
        'oaep_hashing_algorithm' => 'getOaepHashingAlgorithm',
        'iv' => 'getIv',
        'encrypted_data' => 'getEncryptedData'
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
        $this->container['public_key_fingerprint'] = isset($data['public_key_fingerprint']) ? $data['public_key_fingerprint'] : null;
        $this->container['encrypted_key'] = isset($data['encrypted_key']) ? $data['encrypted_key'] : null;
        $this->container['oaep_hashing_algorithm'] = isset($data['oaep_hashing_algorithm']) ? $data['oaep_hashing_algorithm'] : null;
        $this->container['iv'] = isset($data['iv']) ? $data['iv'] : null;
        $this->container['encrypted_data'] = isset($data['encrypted_data']) ? $data['encrypted_data'] : null;
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
     * Gets public_key_fingerprint
     *
     * @return string|null
     */
    public function getPublicKeyFingerprint()
    {
        return $this->container['public_key_fingerprint'];
    }

    /**
     * Sets public_key_fingerprint
     *
     * @param string|null $public_key_fingerprint The fingerprint of the public key used to encrypt the ephemeral AES key.<br> __Max Length: 64__
     *
     * @return $this
     */
    public function setPublicKeyFingerprint($public_key_fingerprint)
    {
        $this->container['public_key_fingerprint'] = $public_key_fingerprint;

        return $this;
    }

    /**
     * Gets encrypted_key
     *
     * @return string|null
     */
    public function getEncryptedKey()
    {
        return $this->container['encrypted_key'];
    }

    /**
     * Sets encrypted_key
     *
     * @param string|null $encrypted_key One-time use AES key encrypted by the MasterCard public key (as identified by publicKeyFingerprint) using the OAEP or PKCS#1 v1.5 scheme (depending on the value of oaepHashingAlgorithm. <br> __Max Length: 512__
     *
     * @return $this
     */
    public function setEncryptedKey($encrypted_key)
    {
        $this->container['encrypted_key'] = $encrypted_key;

        return $this;
    }

    /**
     * Gets oaep_hashing_algorithm
     *
     * @return string|null
     */
    public function getOaepHashingAlgorithm()
    {
        return $this->container['oaep_hashing_algorithm'];
    }

    /**
     * Sets oaep_hashing_algorithm
     *
     * @param string|null $oaep_hashing_algorithm Hashing algorithm used with the OAEP scheme. Must be either SHA256 or SHA512.
     *
     * @return $this
     */
    public function setOaepHashingAlgorithm($oaep_hashing_algorithm)
    {
        $this->container['oaep_hashing_algorithm'] = $oaep_hashing_algorithm;

        return $this;
    }

    /**
     * Gets iv
     *
     * @return string|null
     */
    public function getIv()
    {
        return $this->container['iv'];
    }

    /**
     * Sets iv
     *
     * @param string|null $iv The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed.  <br>__Length: 32__
     *
     * @return $this
     */
    public function setIv($iv)
    {
        $this->container['iv'] = $iv;

        return $this;
    }

    /**
     * Gets encrypted_data
     *
     * @return \OpenAPI\Client\Model\TransactEncryptedData|null
     */
    public function getEncryptedData()
    {
        return $this->container['encrypted_data'];
    }

    /**
     * Sets encrypted_data
     *
     * @param \OpenAPI\Client\Model\TransactEncryptedData|null $encrypted_data encrypted_data
     *
     * @return $this
     */
    public function setEncryptedData($encrypted_data)
    {
        $this->container['encrypted_data'] = $encrypted_data;

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


