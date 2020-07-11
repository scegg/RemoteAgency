﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretNest.RemoteAgency.Inspecting
{
    class EntityBuildingExtended : EntityBuilding
    {
        public Dictionary<string, List<RemoteAgencyAttributePassThrough>> GenericParameterPassThroughAttributes { get; }

        public EntityBuildingExtended(string entityClassName, IReadOnlyList<EntityProperty> properties,
            IReadOnlyList<Attribute> interfaceLevelAttributes, IReadOnlyList<Attribute> assetLevelAttributes,
            IReadOnlyList<Attribute> delegateLevelAttributes, Type[] genericParameters,
            Dictionary<string, List<RemoteAgencyAttributePassThrough>> genericParameterPassThroughAttributes) : base(
            entityClassName, properties, interfaceLevelAttributes, assetLevelAttributes, delegateLevelAttributes,
            genericParameters)
        {
            GenericParameterPassThroughAttributes = genericParameterPassThroughAttributes;
        }
    }
}