using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Circuits.Shared.RecRoom.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x286F670", Offset = "0x286EA70", VA = "0x18286F670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class NYZDNAPJXBA : IEquatable<NYZDNAPJXBA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly string OQGVUCEGDTZ;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		private NYZDNAPJXBA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x286F580", Offset = "0x286E980", VA = "0x18286F580")]
		public static NYZDNAPJXBA New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x286F620", Offset = "0x286EA20", VA = "0x18286F620")]
		public static void RAAJNFUDBVX(Stream a, NYZDNAPJXBA? self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x286F4C0", Offset = "0x286E8C0", VA = "0x18286F4C0")]
		public static NYZDNAPJXBA HKVZDKPMHSN(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x286F550", Offset = "0x286E950", VA = "0x18286F550")]
		public static int LQWMDWNDTPR(NYZDNAPJXBA? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x286F3C0", Offset = "0x286E7C0", VA = "0x18286F3C0")]
		public static bool ZWISVWGZSLY(NYZDNAPJXBA? a, NYZDNAPJXBA? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x286F3C0", Offset = "0x286E7C0", VA = "0x18286F3C0", Slot = "4")]
		public bool Equals(NYZDNAPJXBA? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x286F410", Offset = "0x286E810", VA = "0x18286F410", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x286F490", Offset = "0x286E890", VA = "0x18286F490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MZXRHZUIXYB : JRPOHQWEFGI, IEquatable<MZXRHZUIXYB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public long CUNNQGQYAAA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string VZQUNVRQOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string WDCEUHBVUQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x286F360", Offset = "0x286E760", VA = "0x18286F360")]
		public MZXRHZUIXYB(long a, string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x286F140", Offset = "0x286E540", VA = "0x18286F140", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x286F120", Offset = "0x286E520", VA = "0x18286F120", Slot = "7")]
		public bool Equals(MZXRHZUIXYB? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x286F1E0", Offset = "0x286E5E0", VA = "0x18286F1E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x286F300", Offset = "0x286E700", VA = "0x18286F300")]
		public static void RAAJNFUDBVX(MZXRHZUIXYB? self, Stream a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x286F200", Offset = "0x286E600", VA = "0x18286F200")]
		public static MZXRHZUIXYB HKVZDKPMHSN(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x286F2C0", Offset = "0x286E6C0", VA = "0x18286F2C0")]
		public static int LQWMDWNDTPR(MZXRHZUIXYB? a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class YGVWFLMXIVC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x286FEA0", Offset = "0x286F2A0", VA = "0x18286FEA0")]
		public static VMBBIWUWZDL CQVTSUWTJSM(this MZXRHZUIXYB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x286FF20", Offset = "0x286F320", VA = "0x18286FF20")]
		public static MZXRHZUIXYB FLGKTDORRZX(this VMBBIWUWZDL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ZIQMQVNXFOC : GLEGJDPPHQF, IEquatable<ZIQMQVNXFOC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UELMVRYEXJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public ZIQMQVNXFOC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28701F0", Offset = "0x286F5F0", VA = "0x1828701F0")]
		public static bool ZWISVWGZSLY(ZIQMQVNXFOC a, ZIQMQVNXFOC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2870070", Offset = "0x286F470", VA = "0x182870070", Slot = "5")]
		public bool Equals(ZIQMQVNXFOC? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x286FFC0", Offset = "0x286F3C0", VA = "0x18286FFC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x286F490", Offset = "0x286E890", VA = "0x18286F490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28701A0", Offset = "0x286F5A0", VA = "0x1828701A0")]
		public static void RAAJNFUDBVX(ZIQMQVNXFOC? self, Stream a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28700B0", Offset = "0x286F4B0", VA = "0x1828700B0")]
		public static ZIQMQVNXFOC HKVZDKPMHSN(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2870140", Offset = "0x286F540", VA = "0x182870140")]
		public static int LQWMDWNDTPR(ZIQMQVNXFOC? a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HSXSWGJEUTU : GSNJULYUHGX, IEquatable<HSXSWGJEUTU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CircuitsDestinationTargetType SMDUBCBGORA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(CircuitsDestinationTargetType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AJNPPLXELFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1021B40", Offset = "0x1020F40", VA = "0x181021B40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RoomDoorData.NQYZCTZVWIX.RoomDoorInviteMode WSFWEXSNJUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(RoomDoorData.NQYZCTZVWIX.RoomDoorInviteMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string PDWUIGYBAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string QMLZQWATGRK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EIJMPMXYXOT
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string WDCEUHBVUQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x286E9A0", Offset = "0x286DDA0", VA = "0x18286E9A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool VRIAGRCUTET
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x286EBC0", Offset = "0x286DFC0", VA = "0x18286EBC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x286EBE0", Offset = "0x286DFE0", VA = "0x18286EBE0")]
		public HSXSWGJEUTU(string? a, string? b, string? c, RoomDoorData.NQYZCTZVWIX.RoomDoorInviteMode d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x286E930", Offset = "0x286DD30", VA = "0x18286E930")]
		private static CircuitsDestinationTargetType REQUAGPHYVE(string a, string b, string c)
		{
			return default(CircuitsDestinationTargetType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x286E4E0", Offset = "0x286D8E0", VA = "0x18286E4E0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x286E450", Offset = "0x286D850", VA = "0x18286E450", Slot = "12")]
		public bool Equals(HSXSWGJEUTU? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x286E5E0", Offset = "0x286D9E0", VA = "0x18286E5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x286EA00", Offset = "0x286DE00", VA = "0x18286EA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x286E8B0", Offset = "0x286DCB0", VA = "0x18286E8B0")]
		[Obsolete("You shouldn't even be able to call serialize on a `null` destination.")]
		public static void RAAJNFUDBVX(HSXSWGJEUTU? self, Stream a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x286E6C0", Offset = "0x286DAC0", VA = "0x18286E6C0")]
		public static HSXSWGJEUTU HKVZDKPMHSN(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x286E860", Offset = "0x286DC60", VA = "0x18286E860")]
		public static int LQWMDWNDTPR(HSXSWGJEUTU? a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class HTAXGWOPTPW : JTBLQFEYHKH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string PDWUIGYBAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string EWKZQJNJZIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public List<string> EDUCRDDFIBY
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int EAZSVDVXZFN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int BCWTDGPDLPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int DTGPPPKBPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int CKFWYOAMRMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public QPONHYVFMCT TRMSSBKGIAV
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x286ECF0", Offset = "0x286E0F0", VA = "0x18286ECF0")]
		public HTAXGWOPTPW(string a, string b, List<string> c, int d, int e, int f, int g, QPONHYVFMCT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OZVEIMHKXGL : NMZZCSXJRVE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly Guid OQGVUCEGDTZ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string AMXDXJEJKJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string AFNUWWSYBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int OFMIDLUKTQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HQPTWLZOWZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xBEE6C0", Offset = "0xBEDAC0", VA = "0x180BEE6C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GNDYSPNBWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCDA260", Offset = "0xCD9660", VA = "0x180CDA260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool QPTYROBMKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCDAF00", Offset = "0xCDA300", VA = "0x180CDAF00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float VKLXUEILQFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAF53C0", Offset = "0xAF47C0", VA = "0x180AF53C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ObjectiveMarkerDestroyingHandler KOVUGKPVFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x286F6F0", Offset = "0x286EAF0", VA = "0x18286F6F0", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x286F960", Offset = "0x286ED60", VA = "0x18286F960", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x286FB60", Offset = "0x286EF60", VA = "0x18286FB60")]
		public OZVEIMHKXGL(string a, Guid b, int c, string d, bool e, bool f, bool g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x286F7B0", Offset = "0x286EBB0", VA = "0x18286F7B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x286F870", Offset = "0x286EC70", VA = "0x18286F870")]
		public bool JAEJTQXNKSP(OZVEIMHKXGL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x286F850", Offset = "0x286EC50", VA = "0x18286F850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x286FB00", Offset = "0x286EF00", VA = "0x18286FB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x286F790", Offset = "0x286EB90", VA = "0x18286F790")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x286F8C0", Offset = "0x286ECC0", VA = "0x18286F8C0")]
		public AUAZINBAJUX NWAASZLYTDW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x286FA00", Offset = "0x286EE00", VA = "0x18286FA00")]
		public static OZVEIMHKXGL TCURYDTPRRR(AUAZINBAJUX a, Guid b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GULPQOGRVCS : QPONHYVFMCT, IEquatable<GULPQOGRVCS>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int QOEILSPIXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string AKYYEPUDPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string GOXFLOIGKQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string YBOBSERVCYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int CCXDWDORLIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x286E370", Offset = "0x286D770", VA = "0x18286E370")]
		public GULPQOGRVCS(int a, string? b, string? c, string? d, string? e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x286DF70", Offset = "0x286D370", VA = "0x18286DF70", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x286E020", Offset = "0x286D420", VA = "0x18286E020", Slot = "10")]
		public bool Equals(GULPQOGRVCS? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x286E040", Offset = "0x286D440", VA = "0x18286E040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x286E2F0", Offset = "0x286D6F0", VA = "0x18286E2F0")]
		public static void RAAJNFUDBVX(GULPQOGRVCS a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x286E140", Offset = "0x286D540", VA = "0x18286E140")]
		public static GULPQOGRVCS HKVZDKPMHSN(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x286E2A0", Offset = "0x286D6A0", VA = "0x18286E2A0")]
		public static int LQWMDWNDTPR(GULPQOGRVCS a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class XWQWLIUUCZP : CKVLKEGAWNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly Guid DPJFNRQVAVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly List<string> CWYTMXSJHLV;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid OQGVUCEGDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x286FC70", Offset = "0x286F070", VA = "0x18286FC70", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<string> ZIYQWODPZEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x286FDE0", Offset = "0x286F1E0", VA = "0x18286FDE0")]
		public XWQWLIUUCZP(Guid a, string b, List<string> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
		public void OYFWCEJLJHD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x286FD90", Offset = "0x286F190", VA = "0x18286FD90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x286FBF0", Offset = "0x286EFF0", VA = "0x18286FBF0")]
		public ACJGZJCPPFD ALKIULYDGVO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x286FC80", Offset = "0x286F080", VA = "0x18286FC80")]
		public static XWQWLIUUCZP SEERSJAYBJH(ACJGZJCPPFD a, string b, Guid c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class LTHTWLHTLAM : FRUNADSXITN, IEquatable<LTHTWLHTLAM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int KQDYUUZIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int XBOXUVQJKVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x286F0E0", Offset = "0x286E4E0", VA = "0x18286F0E0")]
		public LTHTWLHTLAM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x286ED90", Offset = "0x286E190", VA = "0x18286ED90")]
		public static LTHTWLHTLAM Default()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x286EF70", Offset = "0x286E370", VA = "0x18286EF70")]
		public static LTHTWLHTLAM JZUWSCOOCJP(ConstantStorefrontItemData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x286F070", Offset = "0x286E470", VA = "0x18286F070")]
		public ConstantStorefrontItemData XNOYQXKZKOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x286EFF0", Offset = "0x286E3F0", VA = "0x18286EFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x286EED0", Offset = "0x286E2D0", VA = "0x18286EED0", Slot = "6")]
		public bool Equals(LTHTWLHTLAM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x286EDE0", Offset = "0x286E1E0", VA = "0x18286EDE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x286EF00", Offset = "0x286E300", VA = "0x18286EF00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
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
