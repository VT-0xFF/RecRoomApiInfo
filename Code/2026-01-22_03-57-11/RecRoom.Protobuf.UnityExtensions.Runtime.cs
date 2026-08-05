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
	public static class ECEXDRSLTBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AAB9C0", Offset = "0x8AAA1C0", VA = "0x188AAB9C0")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AAB990", Offset = "0x8AAA190", VA = "0x188AAB990")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AABA40", Offset = "0x8AAA240", VA = "0x188AABA40")]
		public static Color? UHHDKGKYSOX(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class PTBOTLKQLRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AABC50", Offset = "0x8AAA450", VA = "0x188AABC50")]
		public static Quaternion RRQTOQFPVRW(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AABF00", Offset = "0x8AAA700", VA = "0x188AABF00")]
		public static TZNANXPLTZD SMNXYNFDZXW(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AABE60", Offset = "0x8AAA660", VA = "0x188AABE60")]
		public static Quaternion RXUHCVPZSPV(TZNANXPLTZD a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PJQERVZGRES
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AABB30", Offset = "0x8AAA330", VA = "0x188AABB30")]
		public static VFBKTTDNZIX Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AABAC0", Offset = "0x8AAA2C0", VA = "0x188AABAC0")]
		public static Quaternion Deserialize(this VFBKTTDNZIX self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AABBB0", Offset = "0x8AAA3B0", VA = "0x188AABBB0")]
		public static Quaternion? UHHDKGKYSOX(this VFBKTTDNZIX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class XMGVXCDFSJT
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC050", Offset = "0x8AAA850", VA = "0x188AAC050")]
		public static SALXGGKYXAC Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AABFF0", Offset = "0x8AAA7F0", VA = "0x188AABFF0")]
		public static Vector2 Deserialize(this SALXGGKYXAC self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class YVPTZOZEEYI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC1F0", Offset = "0x8AAA9F0", VA = "0x188AAC1F0")]
		public static TZNANXPLTZD Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC130", Offset = "0x8AAA930", VA = "0x188AAC130")]
		public static TZNANXPLTZD NOOVQSKJEXA([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC0C0", Offset = "0x8AAA8C0", VA = "0x188AAC0C0")]
		public static Vector3 Deserialize(this TZNANXPLTZD self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC260", Offset = "0x8AAAA60", VA = "0x188AAC260")]
		public static Vector3? UHHDKGKYSOX(this TZNANXPLTZD a)
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
