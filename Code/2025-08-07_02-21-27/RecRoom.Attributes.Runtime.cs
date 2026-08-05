using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Attributes;
using UnityEngine;
using UnityEngine.Scripting;

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
		[Cpp2IlInjected.Address(RVA = "0x88013D0", Offset = "0x87FFFD0", VA = "0x1888013D0")]
		public ValidatorConditionalFieldAttribute(string targetName, string validatorCallbackName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Method)]
	[MeansImplicitUse]
	public class DebugConsoleCommandAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Command
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KeyCode[] HotKeyCodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8801310", Offset = "0x87FFF10", VA = "0x188801310")]
		public DebugConsoleCommandAttribute(string command, string description, params KeyCode[] hotKeyCodes)
		{
		}
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true)]
	public class ArrayElementNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string fieldName;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8800F90", Offset = "0x87FFB90", VA = "0x188800F90")]
		public ArrayElementNameAttribute(string fieldName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum AutofillType
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Self,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Parent,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Children,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		SelfAndParent,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		SelfAndChildren,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		NestedParent
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AutofillAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8800FD0", Offset = "0x87FFBD0", VA = "0x188800FD0")]
		public AutofillAttribute(AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AutofillInterfaceAttribute : AutofillAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Type InterfaceType;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8801020", Offset = "0x87FFC20", VA = "0x188801020")]
		public AutofillInterfaceAttribute(Type interfaceType, AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AutofillOptionalAttribute : AutofillAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8800FD0", Offset = "0x87FFBD0", VA = "0x188800FD0")]
		public AutofillOptionalAttribute(AutofillType type = AutofillType.Self, bool acceptFirstOfMultiple = false, bool alwaysShowTarget = false, bool skipIfSet = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class CommentAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum CommentType
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Error
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CommentType type;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8801090", Offset = "0x87FFC90", VA = "0x188801090")]
		public CommentAttribute(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C08F50", Offset = "0x7C07B50", VA = "0x187C08F50")]
		public CommentAttribute(string text, CommentType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConditionalFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly string targetName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly bool hasExpectedValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly object[] expectedValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool inherit;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88011B0", Offset = "0x87FFDB0", VA = "0x1888011B0")]
		public ConditionalFieldAttribute(string targetName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88010D0", Offset = "0x87FFCD0", VA = "0x1888010D0")]
		public ConditionalFieldAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88012B0", Offset = "0x87FFEB0", VA = "0x1888012B0")]
		public ConditionalFieldAttribute(string targetName, params object[] expectedValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ConditionalFieldExceptAttribute : ConditionalFieldAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88010D0", Offset = "0x87FFCD0", VA = "0x1888010D0")]
		public ConditionalFieldExceptAttribute(string targetName, object expectedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88012B0", Offset = "0x87FFEB0", VA = "0x1888012B0")]
		public ConditionalFieldExceptAttribute(string targetName, params object[] expectedValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IntBackedEnumFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly bool HideIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly string GetTypeProperty;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8801380", Offset = "0x87FFF80", VA = "0x188801380")]
		public IntBackedEnumFieldAttribute(string getTypeProperty, bool hideIfNull)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QualityLevelNameAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x26CD7A0", Offset = "0x26CC3A0", VA = "0x1826CD7A0")]
		public QualityLevelNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Obfuscation(Exclude = true)]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x26CD7A0", Offset = "0x26CC3A0", VA = "0x1826CD7A0")]
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
