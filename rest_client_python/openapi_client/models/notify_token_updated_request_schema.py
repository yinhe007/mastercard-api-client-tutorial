# coding: utf-8

"""
    MDES for Merchants

    The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.    # noqa: E501

    The version of the OpenAPI document: 1.2.7
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class NotifyTokenUpdatedRequestSchema(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'response_host': 'str',
        'request_id': 'str',
        'encrypted_payload': 'EncryptedPayload'
    }

    attribute_map = {
        'response_host': 'responseHost',
        'request_id': 'requestId',
        'encrypted_payload': 'encryptedPayload'
    }

    def __init__(self, response_host=None, request_id=None, encrypted_payload=None):  # noqa: E501
        """NotifyTokenUpdatedRequestSchema - a model defined in OpenAPI"""  # noqa: E501

        self._response_host = None
        self._request_id = None
        self._encrypted_payload = None
        self.discriminator = None

        self.response_host = response_host
        self.request_id = request_id
        self.encrypted_payload = encrypted_payload

    @property
    def response_host(self):
        """Gets the response_host of this NotifyTokenUpdatedRequestSchema.  # noqa: E501

        The host that originated the request. Future calls in the same conversation should be routed to this host.   # noqa: E501

        :return: The response_host of this NotifyTokenUpdatedRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._response_host

    @response_host.setter
    def response_host(self, response_host):
        """Sets the response_host of this NotifyTokenUpdatedRequestSchema.

        The host that originated the request. Future calls in the same conversation should be routed to this host.   # noqa: E501

        :param response_host: The response_host of this NotifyTokenUpdatedRequestSchema.  # noqa: E501
        :type: str
        """
        if response_host is None:
            raise ValueError("Invalid value for `response_host`, must not be `None`")  # noqa: E501

        self._response_host = response_host

    @property
    def request_id(self):
        """Gets the request_id of this NotifyTokenUpdatedRequestSchema.  # noqa: E501

        Unique identifier for the request.   # noqa: E501

        :return: The request_id of this NotifyTokenUpdatedRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._request_id

    @request_id.setter
    def request_id(self, request_id):
        """Sets the request_id of this NotifyTokenUpdatedRequestSchema.

        Unique identifier for the request.   # noqa: E501

        :param request_id: The request_id of this NotifyTokenUpdatedRequestSchema.  # noqa: E501
        :type: str
        """
        if request_id is None:
            raise ValueError("Invalid value for `request_id`, must not be `None`")  # noqa: E501

        self._request_id = request_id

    @property
    def encrypted_payload(self):
        """Gets the encrypted_payload of this NotifyTokenUpdatedRequestSchema.  # noqa: E501


        :return: The encrypted_payload of this NotifyTokenUpdatedRequestSchema.  # noqa: E501
        :rtype: EncryptedPayload
        """
        return self._encrypted_payload

    @encrypted_payload.setter
    def encrypted_payload(self, encrypted_payload):
        """Sets the encrypted_payload of this NotifyTokenUpdatedRequestSchema.


        :param encrypted_payload: The encrypted_payload of this NotifyTokenUpdatedRequestSchema.  # noqa: E501
        :type: EncryptedPayload
        """
        if encrypted_payload is None:
            raise ValueError("Invalid value for `encrypted_payload`, must not be `None`")  # noqa: E501

        self._encrypted_payload = encrypted_payload

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, NotifyTokenUpdatedRequestSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other