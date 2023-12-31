/*
 * Yodlee Core APIs
 *
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: developer@yodlee.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Yodlee.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountTokenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Account Token
        /// </summary>
        /// <remarks>
        /// The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentProcessorTokenResponse</returns>
        PaymentProcessorTokenResponse GeneratePaymentProcessorToken(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0);

        /// <summary>
        /// Create Account Token
        /// </summary>
        /// <remarks>
        /// The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentProcessorTokenResponse</returns>
        ApiResponse<PaymentProcessorTokenResponse> GeneratePaymentProcessorTokenWithHttpInfo(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0);
        /// <summary>
        /// Delete Account Token
        /// </summary>
        /// <remarks>
        /// The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void RevokePaymentProcessorToken(string processorToken, int operationIndex = 0);

        /// <summary>
        /// Delete Account Token
        /// </summary>
        /// <remarks>
        /// The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RevokePaymentProcessorTokenWithHttpInfo(string processorToken, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountTokenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create Account Token
        /// </summary>
        /// <remarks>
        /// The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaymentProcessorTokenResponse</returns>
        System.Threading.Tasks.Task<PaymentProcessorTokenResponse> GeneratePaymentProcessorTokenAsync(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create Account Token
        /// </summary>
        /// <remarks>
        /// The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaymentProcessorTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentProcessorTokenResponse>> GeneratePaymentProcessorTokenWithHttpInfoAsync(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete Account Token
        /// </summary>
        /// <remarks>
        /// The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RevokePaymentProcessorTokenAsync(string processorToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete Account Token
        /// </summary>
        /// <remarks>
        /// The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </remarks>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RevokePaymentProcessorTokenWithHttpInfoAsync(string processorToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountTokenApi : IAccountTokenApiSync, IAccountTokenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountTokenApi : IAccountTokenApi
    {
        private Yodlee.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountTokenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountTokenApi(string basePath)
        {
            this.Configuration = Yodlee.ApiClient.Client.Configuration.MergeConfigurations(
                Yodlee.ApiClient.Client.GlobalConfiguration.Instance,
                new Yodlee.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Yodlee.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Yodlee.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Yodlee.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountTokenApi(Yodlee.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Yodlee.ApiClient.Client.Configuration.MergeConfigurations(
                Yodlee.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Yodlee.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Yodlee.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Yodlee.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTokenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountTokenApi(Yodlee.ApiClient.Client.ISynchronousClient client, Yodlee.ApiClient.Client.IAsynchronousClient asyncClient, Yodlee.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Yodlee.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Yodlee.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Yodlee.ApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Yodlee.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Yodlee.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create Account Token The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentProcessorTokenResponse</returns>
        public PaymentProcessorTokenResponse GeneratePaymentProcessorToken(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0)
        {
            Yodlee.ApiClient.Client.ApiResponse<PaymentProcessorTokenResponse> localVarResponse = GeneratePaymentProcessorTokenWithHttpInfo(tokenRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Account Token The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentProcessorTokenResponse</returns>
        public Yodlee.ApiClient.Client.ApiResponse<PaymentProcessorTokenResponse> GeneratePaymentProcessorTokenWithHttpInfo(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0)
        {
            // verify the required parameter 'tokenRequest' is set
            if (tokenRequest == null)
            {
                throw new Yodlee.ApiClient.Client.ApiException(400, "Missing required parameter 'tokenRequest' when calling AccountTokenApi->GeneratePaymentProcessorToken");
            }

            Yodlee.ApiClient.Client.RequestOptions localVarRequestOptions = new Yodlee.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json;charset=UTF-8"
            };

            var localVarContentType = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = tokenRequest;

            localVarRequestOptions.Operation = "AccountTokenApi.GeneratePaymentProcessorToken";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<PaymentProcessorTokenResponse>("/paymentProcessor/token", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GeneratePaymentProcessorToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Account Token The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaymentProcessorTokenResponse</returns>
        public async System.Threading.Tasks.Task<PaymentProcessorTokenResponse> GeneratePaymentProcessorTokenAsync(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Yodlee.ApiClient.Client.ApiResponse<PaymentProcessorTokenResponse> localVarResponse = await GeneratePaymentProcessorTokenWithHttpInfoAsync(tokenRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Account Token The create account token service allows you to create a secure &lt;code&gt;processorToken&lt;/code&gt; for a user&#39;s verified financial account. This &lt;code&gt;processorToken&lt;/code&gt; can then be shared with one of our payment processor partners.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenRequest">account information</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaymentProcessorTokenResponse)</returns>
        public async System.Threading.Tasks.Task<Yodlee.ApiClient.Client.ApiResponse<PaymentProcessorTokenResponse>> GeneratePaymentProcessorTokenWithHttpInfoAsync(PaymentProcessorTokenRequest tokenRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tokenRequest' is set
            if (tokenRequest == null)
            {
                throw new Yodlee.ApiClient.Client.ApiException(400, "Missing required parameter 'tokenRequest' when calling AccountTokenApi->GeneratePaymentProcessorToken");
            }


            Yodlee.ApiClient.Client.RequestOptions localVarRequestOptions = new Yodlee.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json;charset=UTF-8"
            };

            var localVarContentType = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = tokenRequest;

            localVarRequestOptions.Operation = "AccountTokenApi.GeneratePaymentProcessorToken";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<PaymentProcessorTokenResponse>("/paymentProcessor/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GeneratePaymentProcessorToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Account Token The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void RevokePaymentProcessorToken(string processorToken, int operationIndex = 0)
        {
            RevokePaymentProcessorTokenWithHttpInfo(processorToken);
        }

        /// <summary>
        /// Delete Account Token The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Yodlee.ApiClient.Client.ApiResponse<Object> RevokePaymentProcessorTokenWithHttpInfo(string processorToken, int operationIndex = 0)
        {
            // verify the required parameter 'processorToken' is set
            if (processorToken == null)
            {
                throw new Yodlee.ApiClient.Client.ApiException(400, "Missing required parameter 'processorToken' when calling AccountTokenApi->RevokePaymentProcessorToken");
            }

            Yodlee.ApiClient.Client.RequestOptions localVarRequestOptions = new Yodlee.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json;charset=UTF-8"
            };

            var localVarContentType = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("processorToken", Yodlee.ApiClient.Client.ClientUtils.ParameterToString(processorToken)); // header parameter

            localVarRequestOptions.Operation = "AccountTokenApi.RevokePaymentProcessorToken";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/paymentProcessor/token", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RevokePaymentProcessorToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Account Token The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RevokePaymentProcessorTokenAsync(string processorToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RevokePaymentProcessorTokenWithHttpInfoAsync(processorToken, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete Account Token The delete account token service allows you to revoke a previously generated &lt;code&gt;processorToken&lt;/code&gt;. It is recommended to use this service when you want to disallow further access to the user&#39;s financial account, for instance when a user removes their account from your application.
        /// </summary>
        /// <exception cref="Yodlee.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processorToken">The token that you want to delete.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Yodlee.ApiClient.Client.ApiResponse<Object>> RevokePaymentProcessorTokenWithHttpInfoAsync(string processorToken, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'processorToken' is set
            if (processorToken == null)
            {
                throw new Yodlee.ApiClient.Client.ApiException(400, "Missing required parameter 'processorToken' when calling AccountTokenApi->RevokePaymentProcessorToken");
            }


            Yodlee.ApiClient.Client.RequestOptions localVarRequestOptions = new Yodlee.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json;charset=UTF-8"
            };

            var localVarContentType = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Yodlee.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("processorToken", Yodlee.ApiClient.Client.ClientUtils.ParameterToString(processorToken)); // header parameter

            localVarRequestOptions.Operation = "AccountTokenApi.RevokePaymentProcessorToken";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/paymentProcessor/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RevokePaymentProcessorToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
