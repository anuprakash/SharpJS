﻿using System;

namespace System.Xml.Serialization
{
	
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlIgnoreAttribute : Attribute
	{
	}
}
