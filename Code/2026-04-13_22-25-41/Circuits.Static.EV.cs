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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA8A90", Offset = "0x2BA7490", VA = "0x182BA8A90")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.EV.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LHPJXAITWTZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A50", Offset = "0x2BA7450", VA = "0x182BA8A50")]
		public static Id32<THUAKEIUEGQ> YIQTMOAMANE(this int a)
		{
			return default(Id32<THUAKEIUEGQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A10", Offset = "0x2BA7410", VA = "0x182BA8A10")]
		public static Id32<LOGOYWSDYON> DPGLWWTFPJL(this int a)
		{
			return default(Id32<LOGOYWSDYON>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DebuggerDisplay("Class: {ClassString}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
	public readonly struct Variant : IEquatable<Variant>, OBLVMRVNUCX<Variant>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly object? _class;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Union32 _struct;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private string ZUEKOHGWVOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8F10", Offset = "0x2BA7910", VA = "0x182BA8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NWSYSWVBDWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEC80A0", Offset = "0xEC6AA0", VA = "0x180EC80A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int CKHAUXWMAXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xF519C0", Offset = "0xF503C0", VA = "0x180F519C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float RFXMTCZMZSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2BA91D0", Offset = "0x2BA7BD0", VA = "0x182BA91D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? CQJCGAOGVAF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8E90", Offset = "0x2BA7890", VA = "0x182BA8E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ReadOnlyArray<byte>? REOQFNKXPEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA91E0", Offset = "0x2BA7BE0", VA = "0x182BA91E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA92F0", Offset = "0x2BA7CF0", VA = "0x182BA92F0")]
		private Variant(object? @class, Union32 @struct)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA91A0", Offset = "0x2BA7BA0", VA = "0x182BA91A0")]
		private static Variant UDDZVOSJBXH(Union32 a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B10", Offset = "0x2BA7510", VA = "0x182BA8B10")]
		public static Variant AURWMVCTEQI(bool a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA92A0", Offset = "0x2BA7CA0", VA = "0x182BA92A0")]
		public static Variant WVIXCKVSHSO(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8EC0", Offset = "0x2BA78C0", VA = "0x182BA8EC0")]
		public static Variant PNXUQEYZFST(float a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8BB0", Offset = "0x2BA75B0", VA = "0x182BA8BB0")]
		public static Variant HQKDKSPPNUV(string a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8BB0", Offset = "0x2BA75B0", VA = "0x182BA8BB0")]
		public static Variant CYINDOFGKID(byte[] a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D30", Offset = "0x2BA7730", VA = "0x182BA8D30")]
		public static Variant GZWGNGILABG(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B80", Offset = "0x2BA7580", VA = "0x182BA8B80")]
		public static Variant BEDQDAWGOOL()
		{
			return default(Variant);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E20", Offset = "0x2BA7820", VA = "0x182BA8E20")]
		public static bool IQJYWSDTJLC([In] Variant lhs, [In] Variant rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8CC0", Offset = "0x2BA76C0", VA = "0x182BA8CC0", Slot = "4")]
		public bool Equals(Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E20", Offset = "0x2BA7820", VA = "0x182BA8E20")]
		public bool VPMCMGYWJAO([In] Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8BE0", Offset = "0x2BA75E0", VA = "0x182BA8BE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8DB0", Offset = "0x2BA77B0", VA = "0x182BA8DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8F70", Offset = "0x2BA7970", VA = "0x182BA8F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E20", Offset = "0x2BA7820", VA = "0x182BA8E20", Slot = "5")]
		private bool LYCPHZGUSRV([In] Variant other)
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
