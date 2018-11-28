using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace PocketMoney.Application.Infrastructure {
    public class RequestPerformanceBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> {

        private readonly Stopwatch _timer;
        private readonly ILogger<TRequest> _logger;

        public RequestPerformanceBehavior (ILogger<TRequest> logger) {
            _timer = new Stopwatch ();

            _logger = logger;
        }

        public Task<TResponse> Handle (TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next) {
            _timer.Start ();

            var response = next ();

            _timer.Stop ();

            if (_timer.ElapsedMilliseconds > 500) {
                var name = typeof (TRequest).Name;

                // TODO: Add User Details

                _logger.LogWarning ("PocketMoney Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@Request}", name, _timer.ElapsedMilliseconds, request);
            }

            return response;
        }
    }
}