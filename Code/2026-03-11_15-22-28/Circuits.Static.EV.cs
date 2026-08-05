using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x294C350", Offset = "0x294B350", VA = "0x18294C350")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.EV.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HMDSZQHVIAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x294C2D0", Offset = "0x294B2D0", VA = "0x18294C2D0")]
		public static Id32<KRDUNWCYLJD> FGMHAVIWAJL(this int a)
		{
			return default(Id32<KRDUNWCYLJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x294C310", Offset = "0x294B310", VA = "0x18294C310")]
		public static Id32<DSRIXMVNJVY> SZYXOJJMSPS(this int a)
		{
			return default(Id32<DSRIXMVNJVY>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DebuggerDisplay("Class: {ClassString}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
	public readonly struct Variant : IEquatable<Variant>, MMKZQVOZTVS<Variant>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly object? _class;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Union32 _struct;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private string HKGMZSIRXUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x294C890", Offset = "0x294B890", VA = "0x18294C890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EOJNMPPLBFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC41C40", Offset = "0xC40C40", VA = "0x180C41C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int TDHSMGPCKYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCED200", Offset = "0xCEC200", VA = "0x180CED200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float UREVRHHCVWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x294C440", Offset = "0x294B440", VA = "0x18294C440")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? PSZZNHKQDYG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x294C860", Offset = "0x294B860", VA = "0x18294C860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ReadOnlyArray<byte>? AHLRTDIYUYC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x294C770", Offset = "0x294B770", VA = "0x18294C770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x294CBA0", Offset = "0x294BBA0", VA = "0x18294CBA0")]
		private Variant(object? @class, Union32 @struct)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x294CB20", Offset = "0x294BB20", VA = "0x18294CB20")]
		private static Variant URGWTPDDRYW(Union32 a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x294C3D0", Offset = "0x294B3D0", VA = "0x18294C3D0")]
		public static Variant CYRDWWDYRET(bool a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x294CB50", Offset = "0x294BB50", VA = "0x18294CB50")]
		public static Variant XHRVSPVNGEP(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x294C680", Offset = "0x294B680", VA = "0x18294C680")]
		public static Variant ISSAQRPBNTA(float a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x294C6D0", Offset = "0x294B6D0", VA = "0x18294C6D0")]
		public static Variant JCTSJWHUUZE(string a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x294C6D0", Offset = "0x294B6D0", VA = "0x18294C6D0")]
		public static Variant YQMKAETFZVA(byte[] a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x294C600", Offset = "0x294B600", VA = "0x18294C600")]
		public static Variant HOFNWUMNOAT(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x294C830", Offset = "0x294B830", VA = "0x18294C830")]
		public static Variant LXRISGTBSMC()
		{
			return default(Variant);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x294C700", Offset = "0x294B700", VA = "0x18294C700")]
		public static bool JNIBMGTXNLH([In] Variant lhs, [In] Variant rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x294C520", Offset = "0x294B520", VA = "0x18294C520", Slot = "4")]
		public bool Equals(Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x294C700", Offset = "0x294B700", VA = "0x18294C700")]
		public bool YOXYRJFNIZD([In] Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x294C450", Offset = "0x294B450", VA = "0x18294C450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x294C590", Offset = "0x294B590", VA = "0x18294C590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x294C8F0", Offset = "0x294B8F0", VA = "0x18294C8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x294C700", Offset = "0x294B700", VA = "0x18294C700", Slot = "5")]
		private bool KWJVTWUWWEY([In] Variant other)
		{
			return default(bool);
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
