using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGOSYYBXCW
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
	public SVGOSYYBXCW()
	{
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Method)]
	public class OMConsoleCommand : Attribute
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface AZHZIOQIDFN
	{
	}
}
namespace RecRoom.ObjectModel.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DontRemoveDuringBulkRemoveComponents : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2E734D0", Offset = "0x2E724D0", VA = "0x182E734D0")]
		public DontRemoveDuringBulkRemoveComponents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct StableTypeHashAttribute : IEquatable<StableTypeHashAttribute>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly ulong Value;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BA5CB0", Offset = "0x9BA4CB0", VA = "0x189BA5CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x187CF10", Offset = "0x187BF10", VA = "0x18187CF10", Slot = "4")]
		public bool Equals(StableTypeHashAttribute other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BA5C20", Offset = "0x9BA4C20", VA = "0x189BA5C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x239F270", Offset = "0x239E270", VA = "0x18239F270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class DebugAlwaysUpdateSystemAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public DebugAlwaysUpdateSystemAttribute()
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
