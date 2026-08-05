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
		[Cpp2IlInjected.Address(RVA = "0x9F50B10", Offset = "0x9F4FF10", VA = "0x189F50B10")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F50AE0", Offset = "0x9F4FEE0", VA = "0x189F50AE0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F50B90", Offset = "0x9F4FF90", VA = "0x189F50B90")]
		public static Color? YWGHKEBNLAI(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class BPNLLNYGZKS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F50440", Offset = "0x9F4F840", VA = "0x189F50440")]
		public static Quaternion YBHILJBRTHB(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9F502B0", Offset = "0x9F4F6B0", VA = "0x189F502B0")]
		public static BPPVSWJBWSW IBQCSKVAJRL(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F503A0", Offset = "0x9F4F7A0", VA = "0x189F503A0")]
		public static Quaternion MKBCKUALJTM(BPPVSWJBWSW a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LWBUEHIHHQJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F506C0", Offset = "0x9F4FAC0", VA = "0x189F506C0")]
		public static COPSBDPGAHI Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F50650", Offset = "0x9F4FA50", VA = "0x189F50650")]
		public static Quaternion Deserialize(this COPSBDPGAHI self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F50740", Offset = "0x9F4FB40", VA = "0x189F50740")]
		public static Quaternion? YWGHKEBNLAI(this COPSBDPGAHI a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class XNBULIWECYU
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F50A70", Offset = "0x9F4FE70", VA = "0x189F50A70")]
		public static FMYINUEYWSR Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F50A10", Offset = "0x9F4FE10", VA = "0x189F50A10")]
		public static Vector2 Deserialize(this FMYINUEYWSR self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WUPFQQZYPSB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F50910", Offset = "0x9F4FD10", VA = "0x189F50910")]
		public static BPPVSWJBWSW Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F50850", Offset = "0x9F4FC50", VA = "0x189F50850")]
		public static BPPVSWJBWSW NXJGRXYZKXL([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F507E0", Offset = "0x9F4FBE0", VA = "0x189F507E0")]
		public static Vector3 Deserialize(this BPPVSWJBWSW self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F50980", Offset = "0x9F4FD80", VA = "0x189F50980")]
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
