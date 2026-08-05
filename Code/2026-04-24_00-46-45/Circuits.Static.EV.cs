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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDFD90", Offset = "0x2BDE790", VA = "0x182BDFD90")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.EV.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FZJVEQAFKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFD10", Offset = "0x2BDE710", VA = "0x182BDFD10")]
		public static Id32<TQQQOXOZIAW> CWMNPOUEPUM(this int a)
		{
			return default(Id32<TQQQOXOZIAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFD50", Offset = "0x2BDE750", VA = "0x182BDFD50")]
		public static Id32<MMHQXLWOJFR> EZVFTPYESKL(this int a)
		{
			return default(Id32<MMHQXLWOJFR>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DebuggerDisplay("Class: {ClassString}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
	public readonly struct Variant : IEquatable<Variant>, SCCEHWEFPHH<Variant>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly object? _class;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Union32 _struct;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private string SHFEUFRSEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BE0590", Offset = "0x2BDEF90", VA = "0x182BE0590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool SAITVCQRJZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEF9570", Offset = "0xEF7F70", VA = "0x180EF9570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int CSMNYKTNLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xF8BE60", Offset = "0xF8A860", VA = "0x180F8BE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float QMXSPHXKJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2BE02D0", Offset = "0x2BDECD0", VA = "0x182BE02D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? JGOBEWTVAFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2BE01B0", Offset = "0x2BDEBB0", VA = "0x182BE01B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ReadOnlyArray<byte>? LFSCFHASJTT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BDFF30", Offset = "0x2BDE930", VA = "0x182BDFF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE05F0", Offset = "0x2BDEFF0", VA = "0x182BE05F0")]
		private Variant(object? @class, Union32 @struct)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE02E0", Offset = "0x2BDECE0", VA = "0x182BE02E0")]
		private static Variant RBEWYMFWPJJ(Union32 a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE01E0", Offset = "0x2BDEBE0", VA = "0x182BE01E0")]
		public static Variant KGTJVCWUESC(bool a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0310", Offset = "0x2BDED10", VA = "0x182BE0310")]
		public static Variant SVBHBDGYGXW(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0280", Offset = "0x2BDEC80", VA = "0x182BE0280")]
		public static Variant NQCBGDIVXUZ(float a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE10", Offset = "0x2BDE810", VA = "0x182BDFE10")]
		public static Variant AEXCNVQJPGD(string a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE10", Offset = "0x2BDE810", VA = "0x182BDFE10")]
		public static Variant ILUBIADFBBT(byte[] a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE40", Offset = "0x2BDE840", VA = "0x182BDFE40")]
		public static Variant CKCHDCTYOZY(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0250", Offset = "0x2BDEC50", VA = "0x182BE0250")]
		public static Variant LXBBOSUKQBL()
		{
			return default(Variant);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFEC0", Offset = "0x2BDE8C0", VA = "0x182BDFEC0")]
		public static bool SHHUBVCQRYC([In] Variant lhs, [In] Variant rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BE00D0", Offset = "0x2BDEAD0", VA = "0x182BE00D0", Slot = "4")]
		public bool Equals(Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFEC0", Offset = "0x2BDE8C0", VA = "0x182BDFEC0")]
		public bool XNDJLZYNOLK([In] Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFFF0", Offset = "0x2BDE9F0", VA = "0x182BDFFF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0140", Offset = "0x2BDEB40", VA = "0x182BE0140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0360", Offset = "0x2BDED60", VA = "0x182BE0360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFEC0", Offset = "0x2BDE8C0", VA = "0x182BDFEC0", Slot = "5")]
		private bool CNLSCAACZZL([In] Variant other)
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
