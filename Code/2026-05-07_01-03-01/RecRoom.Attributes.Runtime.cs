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
		[Cpp2IlInjected.Address(RVA = "0x9641B50", Offset = "0x9640550", VA = "0x189641B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9641790", Offset = "0x9640190", VA = "0x189641790")]
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
		[Cpp2IlInjected.Address(RVA = "0x96417D0", Offset = "0x96401D0", VA = "0x1896417D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9641820", Offset = "0x9640220", VA = "0x189641820")]
		public AutofillInterfaceAttribute(Type interfaceType, AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AutofillOptionalAttribute : AutofillAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96417D0", Offset = "0x96401D0", VA = "0x1896417D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9641890", Offset = "0x9640290", VA = "0x189641890")]
		public CommentAttribute(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FCB0", Offset = "0x8A1E6B0", VA = "0x188A1FCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x96419B0", Offset = "0x96403B0", VA = "0x1896419B0")]
		public ConditionalFieldAttribute(string targetName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96418D0", Offset = "0x96402D0", VA = "0x1896418D0")]
		public ConditionalFieldAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9641AA0", Offset = "0x96404A0", VA = "0x189641AA0")]
		public ConditionalFieldAttribute(string targetName, params object[] expectedValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConditionalFieldExceptAttribute : ConditionalFieldAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96418D0", Offset = "0x96402D0", VA = "0x1896418D0")]
		public ConditionalFieldExceptAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9641AA0", Offset = "0x96404A0", VA = "0x189641AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9641B00", Offset = "0x9640500", VA = "0x189641B00")]
		public IntBackedEnumFieldAttribute(string getTypeProperty, bool hideIfNull)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QualityLevelNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2260230", Offset = "0x225EC30", VA = "0x182260230")]
		public QualityLevelNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Obfuscation(Exclude = true)]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2260230", Offset = "0x225EC30", VA = "0x182260230")]
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
