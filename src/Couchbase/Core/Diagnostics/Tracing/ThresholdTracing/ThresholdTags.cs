namespace Couchbase.Core.Diagnostics.Tracing.ThresholdTracing
{
    /// <summary>
    /// The following properties must be collected for each trace (if available) and then logged as specified under JSON Output Format.
    /// </summary>
    public static class ThresholdTags
    {
        /// <summary>
        /// The duration of the outer request span
        /// </summary>
        /// <remarks>In Microseconds as a <see cref="uint"/></remarks>
        public static string TotalDuration = "total_duration";

        /// <summary>
        /// The duration of the encode span, if present
        /// </summary>
        /// <remarks>In Microseconds as a <see cref="uint"/></remarks>
        public static string EncodeDuration = "request_encoding_duration";

        /// <summary>
        /// The duration of the last dispatch span if present
        /// </summary>
        /// <remarks>In Microseconds as a <see cref="uint"/></remarks>
        public static string DispatchDuration = "dispatch_to_server_duration";
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
