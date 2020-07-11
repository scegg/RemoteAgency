# CustomizedPropertyGetEntityNameAttribute Class
 

Specifies the name of the entity class generated for holding the request and response of getting this property.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">System.Attribute</a><br />&nbsp;&nbsp;&nbsp;&nbsp;SecretNest.RemoteAgency.Attributes.CustomizedPropertyGetEntityNameAttribute<br />
**Namespace:**&nbsp;<a href="N_SecretNest_RemoteAgency_Attributes">SecretNest.RemoteAgency.Attributes</a><br />**Assembly:**&nbsp;SecretNest.RemoteAgency.Base (in SecretNest.RemoteAgency.Base.dll) Version: 2.0.0

## Syntax

**C#**<br />
``` C#
public class CustomizedPropertyGetEntityNameAttribute : Attribute
```

**VB**<br />
``` VB
Public Class CustomizedPropertyGetEntityNameAttribute
	Inherits Attribute
```

**C++**<br />
``` C++
public ref class CustomizedPropertyGetEntityNameAttribute : public Attribute
```

**F#**<br />
``` F#
type CustomizedPropertyGetEntityNameAttribute =  
    class
        inherit Attribute
    end
```

The CustomizedPropertyGetEntityNameAttribute type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_SecretNest_RemoteAgency_Attributes_CustomizedPropertyGetEntityNameAttribute__ctor">CustomizedPropertyGetEntityNameAttribute</a></td><td>
Initializes an instance of the CustomizedPropertyGetEntityNameAttribute.</td></tr></table>&nbsp;
<a href="#customizedpropertygetentitynameattribute-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_SecretNest_RemoteAgency_Attributes_CustomizedPropertyGetEntityNameAttribute_RequestEntityName">RequestEntityName</a></td><td>
Gets the name entity class generated for holding the request of getting this property.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_SecretNest_RemoteAgency_Attributes_CustomizedPropertyGetEntityNameAttribute_ResponseEntityName">ResponseEntityName</a></td><td>
Gets the name entity class generated for holding the response of getting this property.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.attribute.typeid#System_Attribute_TypeId" target="_blank">TypeId</a></td><td>
When implemented in a derived class, gets a unique identifier for this <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.attribute" target="_blank">Attribute</a>.)</td></tr></table>&nbsp;
<a href="#customizedpropertygetentitynameattribute-class">Back to Top</a>

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
<a href="#customizedpropertygetentitynameattribute-class">Back to Top</a>

## Remarks
When this attribute is not present, or name is set to a null reference (`Nothing` in Visual Basic) or empty string, the entity name is chosen automatically.

## See Also


#### Reference
<a href="N_SecretNest_RemoteAgency_Attributes">SecretNest.RemoteAgency.Attributes Namespace</a><br />