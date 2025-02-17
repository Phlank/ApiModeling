﻿using System.Collections.Generic;

namespace Phlank.Responder
{
    /// <summary>
    /// Model without data for deserializing responses generated by the <see cref="IResponder"/>.
    /// </summary>
    public class Response : ISuccessResponse, IProblemResponse
    {
        public bool IsSuccessful => Problem == null;

        public IDictionary<string, object> Extensions { get; set; } = new Dictionary<string, object>();

        public Problem Problem { get; set; }
    }

    /// <summary>
    /// Model with data for deserializing responses generated by the <see cref="IResponder"/>.
    /// </summary>
    /// <typeparam name="T">The type of the data.</typeparam>
    public class Response<T> : Response, ISuccessResponse<T>
    {
        public T Data { get; set; }
    }
}
