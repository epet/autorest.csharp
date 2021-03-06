// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AzureSpecials.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for CustomNamedRequestIdParamGrouping operation.
    /// </summary>
    public partial class HeaderCustomNamedRequestIdParamGroupingParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HeaderCustomNamedRequestIdParamGroupingParametersInner class.
        /// </summary>
        public HeaderCustomNamedRequestIdParamGroupingParametersInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HeaderCustomNamedRequestIdParamGroupingParametersInner class.
        /// </summary>
        /// <param name="fooClientRequestId">The fooRequestId</param>
        public HeaderCustomNamedRequestIdParamGroupingParametersInner(string fooClientRequestId)
        {
            FooClientRequestId = fooClientRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fooRequestId
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string FooClientRequestId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FooClientRequestId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FooClientRequestId");
            }
        }
    }
}
