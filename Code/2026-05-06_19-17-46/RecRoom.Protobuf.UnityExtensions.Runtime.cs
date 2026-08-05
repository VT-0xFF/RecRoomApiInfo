using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Protobuf.Core;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Protobuf.UnityExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class YFIQLAVLMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA02B750", Offset = "0xA02A150", VA = "0x18A02B750")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA02B720", Offset = "0xA02A120", VA = "0x18A02B720")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA02B7D0", Offset = "0xA02A1D0", VA = "0x18A02B7D0")]
		public static Color? YWGHKEBNLAI(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class BPNLLNYGZKS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA02B080", Offset = "0xA029A80", VA = "0x18A02B080")]
		public static Quaternion YBHILJBRTHB(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA02AEF0", Offset = "0xA0298F0", VA = "0x18A02AEF0")]
		public static BPPVSWJBWSW IBQCSKVAJRL(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA02AFE0", Offset = "0xA0299E0", VA = "0x18A02AFE0")]
		public static Quaternion MKBCKUALJTM(BPPVSWJBWSW a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LWBUEHIHHQJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA02B300", Offset = "0xA029D00", VA = "0x18A02B300")]
		public static COPSBDPGAHI Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA02B290", Offset = "0xA029C90", VA = "0x18A02B290")]
		public static Quaternion Deserialize(this COPSBDPGAHI self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA02B380", Offset = "0xA029D80", VA = "0x18A02B380")]
		public static Quaternion? YWGHKEBNLAI(this COPSBDPGAHI a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class XNBULIWECYU
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA02B6B0", Offset = "0xA02A0B0", VA = "0x18A02B6B0")]
		public static FMYINUEYWSR Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA02B650", Offset = "0xA02A050", VA = "0x18A02B650")]
		public static Vector2 Deserialize(this FMYINUEYWSR self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WUPFQQZYPSB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA02B550", Offset = "0xA029F50", VA = "0x18A02B550")]
		public static BPPVSWJBWSW Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA02B490", Offset = "0xA029E90", VA = "0x18A02B490")]
		public static BPPVSWJBWSW NXJGRXYZKXL([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA02B420", Offset = "0xA029E20", VA = "0x18A02B420")]
		public static Vector3 Deserialize(this BPPVSWJBWSW self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA02B5C0", Offset = "0xA029FC0", VA = "0x18A02B5C0")]
		public static Vector3? YWGHKEBNLAI(this BPPVSWJBWSW a)
		{
			return null;
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
