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
	public static class BZYYWBVWTMS
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BE28C0", Offset = "0x8BE1AC0", VA = "0x188BE28C0")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2810", Offset = "0x8BE1A10", VA = "0x188BE2810")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2840", Offset = "0x8BE1A40", VA = "0x188BE2840")]
		public static Color? GMPMWUXKZDI(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ANTUIGYQBMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2600", Offset = "0x8BE1800", VA = "0x188BE2600")]
		public static Quaternion WURMIRRXTQB(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2510", Offset = "0x8BE1710", VA = "0x188BE2510")]
		public static NZLJNVCYMDC MUQAJKOLRRR(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2470", Offset = "0x8BE1670", VA = "0x188BE2470")]
		public static Quaternion GCGSMCJAWQE(NZLJNVCYMDC a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SUAQEHLUNWX
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2D50", Offset = "0x8BE1F50", VA = "0x188BE2D50")]
		public static CCIQJZXTHEQ Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2C40", Offset = "0x8BE1E40", VA = "0x188BE2C40")]
		public static Quaternion Deserialize(this CCIQJZXTHEQ self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2CB0", Offset = "0x8BE1EB0", VA = "0x188BE2CB0")]
		public static Quaternion? GMPMWUXKZDI(this CCIQJZXTHEQ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JKXZDJCALQC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE29A0", Offset = "0x8BE1BA0", VA = "0x188BE29A0")]
		public static GJPDJRFBUJB Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2940", Offset = "0x8BE1B40", VA = "0x188BE2940")]
		public static Vector2 Deserialize(this GJPDJRFBUJB self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class JPRDOXMGDIX
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2B10", Offset = "0x8BE1D10", VA = "0x188BE2B10")]
		public static NZLJNVCYMDC Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2B80", Offset = "0x8BE1D80", VA = "0x188BE2B80")]
		public static NZLJNVCYMDC TPJDNWSNEYX([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2A10", Offset = "0x8BE1C10", VA = "0x188BE2A10")]
		public static Vector3 Deserialize(this NZLJNVCYMDC self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2A80", Offset = "0x8BE1C80", VA = "0x188BE2A80")]
		public static Vector3? GMPMWUXKZDI(this NZLJNVCYMDC a)
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
