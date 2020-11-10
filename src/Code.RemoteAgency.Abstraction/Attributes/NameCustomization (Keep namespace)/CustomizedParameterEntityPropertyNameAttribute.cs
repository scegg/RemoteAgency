﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecretNest.RemoteAgency.Attributes
{
    /// <summary>
    /// Specifies property name for the parameter in entity class.
    /// </summary>
    /// <remarks><para>When this attribute is not present, or <see cref="EntityPropertyName"/> is set to <see langword="null"/> or empty string, the property name is chosen automatically.</para>
    /// <para><see cref="CustomizedEventParameterEntityPropertyNameAttribute"/> can be marked on event, with higher priority than <see cref="CustomizedParameterEntityPropertyNameAttribute"/> with the same parameter.</para></remarks>
    /// <conceptualLink target="14c3caef-7392-4f68-b7eb-d0bb014a2e4c#CustomizedName" />
    /// <conceptualLink target="beb637a2-3887-49ff-93f3-1f71b095aa7e" />
    [AttributeUsage(AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
#pragma warning disable CA1813 // Avoid unsealed attributes
    public class CustomizedParameterEntityPropertyNameAttribute : Attribute
#pragma warning restore CA1813 // Avoid unsealed attributes
    {
        /// <summary>
        /// Gets the property name in entity class.
        /// </summary>
        /// <remarks>When the value is <see langword="null"/> or empty string, name is chosen automatically.</remarks>
        public string EntityPropertyName { get; }

        /// <summary>
        /// Initializes an instance of the CustomizedParameterEntityPropertyNameAttribute.
        /// </summary>
        /// <param name="entityPropertyName">Property name in entity class. When the value is <see langword="null"/> or empty string, name is chosen automatically.</param>
        public CustomizedParameterEntityPropertyNameAttribute(string entityPropertyName)
        {
            EntityPropertyName = entityPropertyName;
        }
    }
}
