// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The SQL Database Management API includes operations for getting SQL
    /// Database server quotas.
    /// </summary>
    internal partial class QuotaOperations : IServiceOperations<SqlManagementClient>, Microsoft.WindowsAzure.Management.Sql.IQuotaOperations
    {
        /// <summary>
        /// Initializes a new instance of the QuotaOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal QuotaOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Returns the list of quotas for the server.
        /// </summary>
        /// <param name='serverName'>
        /// Required. The name of the database server to be queried.
        /// </param>
        /// <param name='quotaName'>
        /// Required. The name of the quota to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Quota Get operation.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Sql.Models.QuotaGetResponse> GetAsync(string serverName, string quotaName, CancellationToken cancellationToken)
        {
            // Validate
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (quotaName == null)
            {
                throw new ArgumentNullException("quotaName");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("quotaName", quotaName);
                Tracing.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/sqlservers/servers/" + serverName.Trim() + "/serverquotas/" + quotaName.Trim();
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    QuotaGetResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new QuotaGetResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement serviceResourceElement = responseDoc.Element(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                    if (serviceResourceElement != null)
                    {
                        XElement serviceResourceElement2 = serviceResourceElement.Element(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                        if (serviceResourceElement2 != null)
                        {
                            Quota serviceResourceInstance = new Quota();
                            result.Quota = serviceResourceInstance;
                            
                            XElement nameElement = serviceResourceElement2.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement != null)
                            {
                                string nameInstance = nameElement.Value;
                                serviceResourceInstance.Name = nameInstance;
                            }
                            
                            XElement typeElement = serviceResourceElement2.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                            if (typeElement != null)
                            {
                                string typeInstance = typeElement.Value;
                                serviceResourceInstance.Type = typeInstance;
                            }
                            
                            XElement stateElement = serviceResourceElement2.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                            if (stateElement != null)
                            {
                                string stateInstance = stateElement.Value;
                                serviceResourceInstance.State = stateInstance;
                            }
                            
                            XElement valueElement = serviceResourceElement2.Element(XName.Get("Value", "http://schemas.microsoft.com/windowsazure"));
                            if (valueElement != null)
                            {
                                string valueInstance = valueElement.Value;
                                serviceResourceInstance.Value = valueInstance;
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns the list of quotas for the server.
        /// </summary>
        /// <param name='serverName'>
        /// Required. The name of the database server to be queried.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Quota List operation.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Sql.Models.QuotaListResponse> ListAsync(string serverName, CancellationToken cancellationToken)
        {
            // Validate
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverName", serverName);
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/sqlservers/servers/" + serverName.Trim() + "/serverquotas";
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    QuotaListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new QuotaListResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement serviceResourcesSequenceElement = responseDoc.Element(XName.Get("ServiceResources", "http://schemas.microsoft.com/windowsazure"));
                    if (serviceResourcesSequenceElement != null)
                    {
                        foreach (XElement serviceResourcesElement in serviceResourcesSequenceElement.Elements(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure")))
                        {
                            Quota serviceResourceInstance = new Quota();
                            result.Quotas.Add(serviceResourceInstance);
                            
                            XElement nameElement = serviceResourcesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement != null)
                            {
                                string nameInstance = nameElement.Value;
                                serviceResourceInstance.Name = nameInstance;
                            }
                            
                            XElement typeElement = serviceResourcesElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                            if (typeElement != null)
                            {
                                string typeInstance = typeElement.Value;
                                serviceResourceInstance.Type = typeInstance;
                            }
                            
                            XElement stateElement = serviceResourcesElement.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                            if (stateElement != null)
                            {
                                string stateInstance = stateElement.Value;
                                serviceResourceInstance.State = stateInstance;
                            }
                            
                            XElement valueElement = serviceResourcesElement.Element(XName.Get("Value", "http://schemas.microsoft.com/windowsazure"));
                            if (valueElement != null)
                            {
                                string valueInstance = valueElement.Value;
                                serviceResourceInstance.Value = valueInstance;
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}