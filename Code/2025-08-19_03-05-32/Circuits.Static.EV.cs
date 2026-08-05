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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B13650", Offset = "0x2B12450", VA = "0x182B13650")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.EV.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class GNIFZIJPKTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B135D0", Offset = "0x2B123D0", VA = "0x182B135D0")]
		public static Id32<LJLJBSUERVT> EXZEEMZZNKV(this int a)
		{
			return default(Id32<LJLJBSUERVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B13610", Offset = "0x2B12410", VA = "0x182B13610")]
		public static Id32<OKZGLREOVOG> QKKVHRSJOVO(this int a)
		{
			return default(Id32<OKZGLREOVOG>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DebuggerDisplay("Class: {ClassString}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
	public readonly struct Variant : IEquatable<Variant>, GCLDOOWCVKA<Variant>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly object? _class;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Union32 _struct;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private string SAEROUXFQDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B139F0", Offset = "0x2B127F0", VA = "0x182B139F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PCTRUZWKOSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xECEFC0", Offset = "0xECDDC0", VA = "0x180ECEFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int OPSRCVEURKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xF7C730", Offset = "0xF7B530", VA = "0x180F7C730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float RDNSVDVVOFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2B13D70", Offset = "0x2B12B70", VA = "0x182B13D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? OGHXJWECMYS
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2B13E00", Offset = "0x2B12C00", VA = "0x182B13E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ReadOnlyArray<byte>? OVSVNULYFIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2B13930", Offset = "0x2B12730", VA = "0x182B13930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B13EB0", Offset = "0x2B12CB0", VA = "0x182B13EB0")]
		private Variant(object? @class, Union32 @struct)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B13AC0", Offset = "0x2B128C0", VA = "0x182B13AC0")]
		private static Variant SNIKMEDHGTE(Union32 a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B13A50", Offset = "0x2B12850", VA = "0x182B13A50")]
		public static Variant RIJGCMUMADB(bool a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B13AF0", Offset = "0x2B128F0", VA = "0x182B13AF0")]
		public static Variant TKRRUBKRUQP(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B13D80", Offset = "0x2B12B80", VA = "0x182B13D80")]
		public static Variant VMNRLUBZJIO(float a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B13900", Offset = "0x2B12700", VA = "0x182B13900")]
		public static Variant JVVTESJDXCW(string a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B13900", Offset = "0x2B12700", VA = "0x182B13900")]
		public static Variant RFBARDWMMTA(byte[] a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B13E30", Offset = "0x2B12C30", VA = "0x182B13E30")]
		public static Variant XNGDFYJKNWD(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B13DD0", Offset = "0x2B12BD0", VA = "0x182B13DD0")]
		public static Variant WNSBESUUNMO()
		{
			return default(Variant);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B136D0", Offset = "0x2B124D0", VA = "0x182B136D0")]
		public static bool GFBRUTYEXQF([In] Variant lhs, [In] Variant rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B13820", Offset = "0x2B12620", VA = "0x182B13820", Slot = "4")]
		public bool Equals(Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B136D0", Offset = "0x2B124D0", VA = "0x182B136D0")]
		public bool BURZPLIABAB([In] Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B13740", Offset = "0x2B12540", VA = "0x182B13740", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B13890", Offset = "0x2B12690", VA = "0x182B13890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B13B40", Offset = "0x2B12940", VA = "0x182B13B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B136D0", Offset = "0x2B124D0", VA = "0x182B136D0", Slot = "5")]
		private bool EXXVSEOYAPC([In] Variant other)
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
