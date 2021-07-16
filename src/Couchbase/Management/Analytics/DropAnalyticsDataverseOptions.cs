using System;
using System.Threading;
using Couchbase.Analytics;

namespace Couchbase.Management.Analytics
{
    public class DropAnalyticsDataverseOptions
    {
        internal bool IgnoreIfNotExistsValue { get; set; }

        public DropAnalyticsDataverseOptions IgnoreIfNotExists(bool ignoreIfNotExists)
        {
            IgnoreIfNotExistsValue = ignoreIfNotExists;
            return this;
        }

        internal CancellationToken TokenValue { get; set; }

        public DropAnalyticsDataverseOptions CancellationToken(CancellationToken token)
        {
            TokenValue = token;
            return this;
        }

        internal TimeSpan TimeoutValue { get; set; }

        public DropAnalyticsDataverseOptions Timeout(TimeSpan timeout)
        {
            TimeoutValue = timeout;
            return this;
        }

        internal AnalyticsOptions CreateAnalyticsOptions()
        {
            return new AnalyticsOptions()
                .CancellationToken(TokenValue)
                .Timeout(TimeoutValue);
        }
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
