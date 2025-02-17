﻿using Phlank.Responder.Extensions;
using System;
using System.Collections.Generic;
using System.Net;

namespace Phlank.Responder
{
    internal static class BaseProblems
    {
        static BaseProblems() { }

        private static IEnumerable<Problem> GetDefaultErrors()
        {
            return new List<Problem>()
            {
                new Problem(
                    HttpStatusCode.BadRequest,
                    HttpStatusCode.BadRequest.ToString(),
                    "The request could not be understood by the server.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1")),
                new Problem(
                    HttpStatusCode.Unauthorized,
                    HttpStatusCode.Unauthorized.ToString(),
                    "The request lacks valid authentication credentials for this resource.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7235#section-3.1")),
                new Problem(
                    HttpStatusCode.PaymentRequired,
                    HttpStatusCode.PaymentRequired.ToString(),
                    "Reserved for future use.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.2")),
                new Problem(
                    HttpStatusCode.Forbidden,
                    HttpStatusCode.Forbidden.ToString(),
                    "The server has refused to fulfill the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.3")),
                new Problem(
                    HttpStatusCode.NotFound,
                    HttpStatusCode.NotFound.ToString(),
                    "The server cannot locate the target resource or is unwilling to disclose that it exists.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4")),
                new Problem(
                    HttpStatusCode.MethodNotAllowed,
                    HttpStatusCode.MethodNotAllowed.ToString(),
                    "The method referenced in the request is known by the server, but it is not supported by the target resource.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.5")),
                new Problem(
                    HttpStatusCode.NotAcceptable,
                    HttpStatusCode.NotAcceptable.ToString(),
                    "The target resource does not currently have a representation that would be acceptable to the client according to the proactive negotiation fields received.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.6")),
                new Problem(
                    HttpStatusCode.ProxyAuthenticationRequired,
                    HttpStatusCode.ProxyAuthenticationRequired.ToString(),
                    "The client must authenticate itself in order to use a proxy.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7235#section-3.2")),
                new Problem(
                    HttpStatusCode.RequestTimeout,
                    HttpStatusCode.RequestTimeout.ToString(),
                    "The server did not receive a complete request message within the time that it was prepared to wait.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.7")),
                new Problem(
                    HttpStatusCode.Conflict,
                    HttpStatusCode.Conflict.ToString(),
                    "The request could not be completed due to a conflict with the current state of the target resource.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8")),
                new Problem(
                    HttpStatusCode.Gone,
                    HttpStatusCode.Gone.ToString(),
                    "Access to the target resource is no longer available at this server; this is likely permanent.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.9")),
                new Problem(
                    HttpStatusCode.LengthRequired,
                    HttpStatusCode.LengthRequired.ToString(),
                    "The server refuses to accept the request without a defined Content-Length.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.10")),
                new Problem(
                    HttpStatusCode.PreconditionFailed,
                    HttpStatusCode.PreconditionFailed.ToString(),
                    "One or more conditions given in the request header fields evaluated to false when tested on the server.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7232#section-4.2")),
                new Problem(
                    HttpStatusCode.RequestEntityTooLarge,
                    HttpStatusCode.RequestEntityTooLarge.ToString(),
                    "The server is refusing to process a request because the request payload is larger than the server is willing or able to process.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.11")),
                new Problem(
                    HttpStatusCode.RequestUriTooLong,
                    HttpStatusCode.RequestUriTooLong.ToString(),
                    "The server is refusing to service the request because the request-target is longer than the server is willing to interpret.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.12")),
                new Problem(
                    HttpStatusCode.UnsupportedMediaType,
                    HttpStatusCode.UnsupportedMediaType.ToString(),
                    "The server is refusing to service the request because the payload is in a format not supported by this method on the target resource.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.13")),
                new Problem(
                    HttpStatusCode.RequestedRangeNotSatisfiable,
                    HttpStatusCode.RequestedRangeNotSatisfiable.ToString(),
                    "None of the ranges in the request's Range header field overlap the current extent of the selected resource, or the set of ranges requested has been rejected due to invalid ranges or an excessive request of small or overlapping ranges.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7233#section-4.4")),
                new Problem(
                    HttpStatusCode.ExpectationFailed,
                    HttpStatusCode.ExpectationFailed.ToString(),
                    "The expectation given in the request's Expect header field coult not be met by the server.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.14")),
                new Problem(
                    HttpStatusCode.MisdirectedRequest,
                    HttpStatusCode.MisdirectedRequest.ToString(),
                    "The server is unable or unwilling to produce an authoritative response for the target URI.",
                    new Uri("https://datatracker.ietf.org/doc/html/draft-ietf-httpbis-semantics-19#section-15.5.20")),
                new Problem(
                    HttpStatusCode.UnprocessableEntity,
                    HttpStatusCode.UnprocessableEntity.ToString(),
                    "The server understands the content type of the request content, and the syntax of the content is correct, but was unable to process the contained instructions.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc4918#section-11.2")),
                new Problem(
                    HttpStatusCode.Locked,
                    HttpStatusCode.Locked.ToString(),
                    "The source or destination resource of a method is locked.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc4918#section-11.3")),
                new Problem(
                    HttpStatusCode.FailedDependency,
                    HttpStatusCode.FailedDependency.ToString(),
                    "The method could not be performed on the resource because the requested action depended on another action and that action failed.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc4918#section-11.4")),
                new Problem(
                    HttpStatusCode.UpgradeRequired,
                    HttpStatusCode.UpgradeRequired.ToString(),
                    "The server refuses to perform the request using the current protocol, but may be willing to do so after the client upgrades to a different protocol.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.15")),
                new Problem(
                    HttpStatusCode.PreconditionRequired,
                    HttpStatusCode.PreconditionRequired.ToString(),
                    "The server requires the request to be conditional.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc6585.html#section-3")),
                new Problem(
                    HttpStatusCode.TooManyRequests,
                    HttpStatusCode.TooManyRequests.ToString(),
                    "The user has sent too many requests in a given amount of time.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc6585.html#section-4")),
                new Problem(
                    HttpStatusCode.RequestHeaderFieldsTooLarge,
                    HttpStatusCode.RequestHeaderFieldsTooLarge.ToString(),
                    "The server is unwilling to process the request because its header fields are too large.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc6585.html#section-5")),
                new Problem(
                    HttpStatusCode.UnavailableForLegalReasons,
                    HttpStatusCode.UnavailableForLegalReasons.ToString(),
                    "The server is denying access to the resource as a consequence of a legal demand.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7725.html#section-3")),
                new Problem(
                    HttpStatusCode.InternalServerError,
                    HttpStatusCode.InternalServerError.ToString(),
                    "The server encountered an unexpected condition that prevented it from fulfilling the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1")),
                new Problem(
                    HttpStatusCode.NotImplemented,
                    HttpStatusCode.NotImplemented.ToString(),
                    "The server does not support the functionality required to fulfill the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.2")),
                new Problem(
                    HttpStatusCode.BadGateway,
                    HttpStatusCode.BadGateway.ToString(),
                    "The server, while acting as a gateway or proxy, received an invalid response from an inbound server it accessed while attempting to fulfill the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.3")),
                new Problem(
                    HttpStatusCode.ServiceUnavailable,
                    HttpStatusCode.ServiceUnavailable.ToString(),
                    "The server is currently unable to handle the request due to a temporary overload or scheduled maintenance, which will likely be alleviated after some delay.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.4")),
                new Problem(
                    HttpStatusCode.GatewayTimeout,
                    HttpStatusCode.GatewayTimeout.ToString(),
                    "The server, while acting as a gateway or proxy, did not receive a timely response from an upstream server it needed to access in order to complete the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.5")),
                new Problem(
                    HttpStatusCode.HttpVersionNotSupported,
                    HttpStatusCode.HttpVersionNotSupported.ToString(),
                    "The server does not support, or refuses to support, the major version of HTTP that was used in the request message.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.6")),
                new Problem(
                    HttpStatusCode.VariantAlsoNegotiates,
                    HttpStatusCode.VariantAlsoNegotiates.ToString(),
                    "The server has an internal configuration error: the chosen variant resource is configured to engage in transparent content negotiation itself, and is therefore not a proper end point in the negotiation process.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc2295.html#section-8.1")),
                new Problem(
                    HttpStatusCode.InsufficientStorage,
                    HttpStatusCode.InsufficientStorage.ToString(),
                    "The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc4918.html#section-11.5")),
                new Problem(
                    HttpStatusCode.LoopDetected,
                    HttpStatusCode.LoopDetected.ToString(),
                    "The server terminated an operation because it encountered an infinite loop while processing a request with \"Depth: infinity\".",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc5842#section-7.2")),
                new Problem(
                    HttpStatusCode.NotExtended,
                    HttpStatusCode.NotExtended.ToString(),
                    "The policy for accessing the resource has not been met in the request.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc2774#section-7")),
                new Problem(
                    HttpStatusCode.NetworkAuthenticationRequired,
                    HttpStatusCode.NetworkAuthenticationRequired.ToString(),
                    "The client needs to authenticate to gain network access.",
                    new Uri("https://datatracker.ietf.org/doc/html/rfc6585#section-6"))
            };
        }

        private static IDictionary<HttpStatusCode, Problem> StatusCodeToBaseProblemDictionary;

        public static void Setup(List<Problem> supplementalErrors = null)
        {
            StatusCodeToBaseProblemDictionary = new Dictionary<HttpStatusCode, Problem>();

            var defaultErrors = GetDefaultErrors();

            foreach (var error in defaultErrors)
            {
                StatusCodeToBaseProblemDictionary[error.Status] = error;
            }
            if (supplementalErrors != null)
            {
                foreach (var error in supplementalErrors)
                {
                    StatusCodeToBaseProblemDictionary[error.Status] = error;
                }
            }
        }

        public static Problem FromStatusCode(HttpStatusCode statusCode)
        {
            if (!statusCode.IsError()) throw new ArgumentOutOfRangeException(nameof(statusCode));
            if (StatusCodeToBaseProblemDictionary == null) Setup();
            if (!StatusCodeToBaseProblemDictionary.ContainsKey(statusCode)) return null;

            return StatusCodeToBaseProblemDictionary[statusCode];
        }
    }
}
