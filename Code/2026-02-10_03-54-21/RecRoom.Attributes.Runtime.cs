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
		[Cpp2IlInjected.Address(RVA = "0x8249CA0", Offset = "0x8248EA0", VA = "0x188249CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82498E0", Offset = "0x8248AE0", VA = "0x1882498E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8249920", Offset = "0x8248B20", VA = "0x188249920")]
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
		[Cpp2IlInjected.Address(RVA = "0x8249970", Offset = "0x8248B70", VA = "0x188249970")]
		public AutofillInterfaceAttribute(Type interfaceType, AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AutofillOptionalAttribute : AutofillAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8249920", Offset = "0x8248B20", VA = "0x188249920")]
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
		[Cpp2IlInjected.Address(RVA = "0x82499E0", Offset = "0x8248BE0", VA = "0x1882499E0")]
		public CommentAttribute(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76682C0", Offset = "0x76674C0", VA = "0x1876682C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8249B00", Offset = "0x8248D00", VA = "0x188249B00")]
		public ConditionalFieldAttribute(string targetName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8249A20", Offset = "0x8248C20", VA = "0x188249A20")]
		public ConditionalFieldAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8249BF0", Offset = "0x8248DF0", VA = "0x188249BF0")]
		public ConditionalFieldAttribute(string targetName, params object[] expectedValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConditionalFieldExceptAttribute : ConditionalFieldAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8249A20", Offset = "0x8248C20", VA = "0x188249A20")]
		public ConditionalFieldExceptAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8249BF0", Offset = "0x8248DF0", VA = "0x188249BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8249C50", Offset = "0x8248E50", VA = "0x188249C50")]
		public IntBackedEnumFieldAttribute(string getTypeProperty, bool hideIfNull)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QualityLevelNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0BF0", Offset = "0x1FEFDF0", VA = "0x181FF0BF0")]
		public QualityLevelNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Obfuscation(Exclude = true)]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0BF0", Offset = "0x1FEFDF0", VA = "0x181FF0BF0")]
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
