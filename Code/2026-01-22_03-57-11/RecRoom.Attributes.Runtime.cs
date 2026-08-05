using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ValidatorConditionalFieldAttribute : ConditionalFieldAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly string validatorCallbackName;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8117BF0", Offset = "0x81163F0", VA = "0x188117BF0")]
		public ValidatorConditionalFieldAttribute(string targetName, string validatorCallbackName)
		{
		}
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true)]
	public class ArrayElementNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly string fieldName;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8117820", Offset = "0x8116020", VA = "0x188117820")]
		public ArrayElementNameAttribute(string fieldName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum AutofillType
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Self,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Parent,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		SelfAndParent,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		SelfAndChildren,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		NestedParent
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AutofillAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8117860", Offset = "0x8116060", VA = "0x188117860")]
		public AutofillAttribute(AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AutofillInterfaceAttribute : AutofillAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Type InterfaceType;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81178B0", Offset = "0x81160B0", VA = "0x1881178B0")]
		public AutofillInterfaceAttribute(Type interfaceType, AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AutofillOptionalAttribute : AutofillAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8117860", Offset = "0x8116060", VA = "0x188117860")]
		public AutofillOptionalAttribute(AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class CommentAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum CommentType
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Error
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly CommentType type;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8117920", Offset = "0x8116120", VA = "0x188117920")]
		public CommentAttribute(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7550F50", Offset = "0x754F750", VA = "0x187550F50")]
		public CommentAttribute(string text, CommentType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ConditionalFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly string targetName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool hasExpectedValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly object[] expectedValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public bool inherit;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8117A40", Offset = "0x8116240", VA = "0x188117A40")]
		public ConditionalFieldAttribute(string targetName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8117960", Offset = "0x8116160", VA = "0x188117960")]
		public ConditionalFieldAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8117B40", Offset = "0x8116340", VA = "0x188117B40")]
		public ConditionalFieldAttribute(string targetName, params object[] expectedValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConditionalFieldExceptAttribute : ConditionalFieldAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8117960", Offset = "0x8116160", VA = "0x188117960")]
		public ConditionalFieldExceptAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8117B40", Offset = "0x8116340", VA = "0x188117B40")]
		public ConditionalFieldExceptAttribute(string targetName, params object[] expectedValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class IntBackedEnumFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly bool HideIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly string GetTypeProperty;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8117BA0", Offset = "0x81163A0", VA = "0x188117BA0")]
		public IntBackedEnumFieldAttribute(string getTypeProperty, bool hideIfNull)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QualityLevelNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC690", Offset = "0x1FAAE90", VA = "0x181FAC690")]
		public QualityLevelNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Obfuscation(Exclude = true)]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC690", Offset = "0x1FAAE90", VA = "0x181FAC690")]
		public ReadOnlyFieldAttribute()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
