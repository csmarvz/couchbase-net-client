using System.Collections.Generic;
using System.Net;

namespace Couchbase.Core.Exceptions.Search
{
    /// <remarks>Uncommitted</remarks>
    public class SearchErrorContext : IErrorContext
    {
        public string IndexName{ get; internal set; }

        public string Query { get; internal set; }

        public string Parameters { get; internal set; }

        public HttpStatusCode HttpStatus { get; internal set; }

        public string ClientContextId { get; internal set; }

        public string Statement { get; internal set; }

        public string Message { get; internal set; }

        public string Errors { get; internal set; }
    }
}


/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2021 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/
