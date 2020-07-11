# AttributePassThroughAttribute Class
 

Specifies an attribute should be marked at the same place of built proxy class.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">System.Attribute</a><br />&nbsp;&nbsp;&nbsp;&nbsp;SecretNest.RemoteAgency.Attributes.AttributePassThroughAttribute<br />
**Namespace:**&nbsp;<a href="N_SecretNest_RemoteAgency_Attributes">SecretNest.RemoteAgency.Attributes</a><br />**Assembly:**&nbsp;SecretNest.RemoteAgency.Base (in SecretNest.RemoteAgency.Base.dll) Version: 2.0.0

## Syntax

**C#**<br />
``` C#
public class AttributePassThroughAttribute : Attribute
```

**VB**<br />
``` VB
Public Class AttributePassThroughAttribute
	Inherits Attribute
```

**C++**<br />
``` C++
public ref class AttributePassThroughAttribute : public Attribute
```

**F#**<br />
``` F#
type AttributePassThroughAttribute =  
    class
        inherit Attribute
    end
```

The AttributePassThroughAttribute type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute__ctor">AttributePassThroughAttribute</a></td><td>
Initializes an instance of AttributePassThroughAttribute.</td></tr></table>&nbsp;
<a href="#attributepassthroughattribute-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_Attribute">Attribute</a></td><td>
Gets the type of the attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameters">AttributeConstructorParameters</a></td><td>
Gets the parameters used in constructor. The length can not exceed the length of <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameterTypes">AttributeConstructorParameterTypes</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameterTypes">AttributeConstructorParameterTypes</a></td><td>
Gets the types to identify the constructor of attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeId">AttributeId</a></td><td>
Gets the id of the instance of the attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.attribute.typeid#System_Attribute_TypeId" target="_blank">TypeId</a></td><td>
When implemented in a derived class, gets a unique identifier for this <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.)</td></tr></table>&nbsp;
<a href="#attributepassthroughattribute-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.attribute.equals#System_Attribute_Equals_System_Object_" target="_blank">Equals</a></td><td>
Returns a value that indicates whether this instance is equal to a specified object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.finalize#System_Object_Finalize" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.attribute.gethashcode#System_Attribute_GetHashCode" target="_blank">GetHashCode</a></td><td>
Returns the hash code for this instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.attribute.isdefaultattribute#System_Attribute_IsDefaultAttribute" target="_blank">IsDefaultAttribute</a></td><td>
When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.attribute.match#System_Attribute_Match_System_Object_" target="_blank">Match</a></td><td>
When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.memberwiseclone#System_Object_MemberwiseClone" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#attributepassthroughattribute-class">Back to Top</a>

## Remarks

Use this attribute to mark an attribute at the same place in the created class.

When using the parameterless constructor of target attribute, <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeId">AttributeId</a>, <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameterTypes">AttributeConstructorParameterTypes</a> and <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameters">AttributeConstructorParameters</a> are not required.

When using a constructor with all parameters specified in orders, sets types of parameters of constructor to <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameterTypes">AttributeConstructorParameterTypes</a> and values to <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameters">AttributeConstructorParameters</a>. When the length of <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameters">AttributeConstructorParameters</a> is smaller than the length of <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameterTypes">AttributeConstructorParameterTypes</a>, the missing parameters will not be passed into the constructor. <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeId">AttributeId</a> is not required.

When named parameter is required for constructing, sets types of full form parameters of constructor to <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameterTypes">AttributeConstructorParameterTypes</a> and leading values to <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeConstructorParameters">AttributeConstructorParameters</a>. Marks the rest one by one using <a href="T_SecretNest_RemoteAgency_Attributes_AttributePassThroughIndexBasedParameterAttribute">AttributePassThroughIndexBasedParameterAttribute</a>. The <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughIndexBasedParameterAttribute_AttributeId">AttributeId</a> should have the same value as <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeId">AttributeId</a>.

When properties need to be set while initializing, marks the properties one by one using <a href="T_SecretNest_RemoteAgency_Attributes_AttributePassThroughPropertyAttribute">AttributePassThroughPropertyAttribute</a>. The <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughPropertyAttribute_AttributeId">AttributeId</a> should have the same value as <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeId">AttributeId</a>.

When fields need to be set while initializing, marks the fields one by one using <a href="T_SecretNest_RemoteAgency_Attributes_AttributePassThroughFieldAttribute">AttributePassThroughFieldAttribute</a>. The <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughFieldAttribute_AttributeId">AttributeId</a> should have the same value as <a href="P_SecretNest_RemoteAgency_Attributes_AttributePassThroughAttribute_AttributeId">AttributeId</a>.


## See Also


#### Reference
<a href="N_SecretNest_RemoteAgency_Attributes">SecretNest.RemoteAgency.Attributes Namespace</a><br />