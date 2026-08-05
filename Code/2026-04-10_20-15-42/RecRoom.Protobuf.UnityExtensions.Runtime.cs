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
	public static class CMVTPOHHNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0060", Offset = "0xA1BF060", VA = "0x18A1C0060")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1BFFB0", Offset = "0xA1BEFB0", VA = "0x18A1BFFB0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1BFFE0", Offset = "0xA1BEFE0", VA = "0x18A1BFFE0")]
		public static Color? OTVQASNCDGG(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class KTPRVNVHDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0480", Offset = "0xA1BF480", VA = "0x18A1C0480")]
		public static Quaternion GXESKQXJCSF(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0690", Offset = "0xA1BF690", VA = "0x18A1C0690")]
		public static HFDMGMXBATW VMLYXYWOXFV(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1C03E0", Offset = "0xA1BF3E0", VA = "0x18A1C03E0")]
		public static Quaternion GJDMRFQCRKI(HFDMGMXBATW a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OTHBTHVQXMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0890", Offset = "0xA1BF890", VA = "0x18A1C0890")]
		public static BWKOHKJADTG Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0780", Offset = "0xA1BF780", VA = "0x18A1C0780")]
		public static Quaternion Deserialize(this BWKOHKJADTG self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1C07F0", Offset = "0xA1BF7F0", VA = "0x18A1C07F0")]
		public static Quaternion? OTVQASNCDGG(this BWKOHKJADTG a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class IGSZQLRKLDY
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0370", Offset = "0xA1BF370", VA = "0x18A1C0370")]
		public static BLNFPPMQGFV Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0310", Offset = "0xA1BF310", VA = "0x18A1C0310")]
		public static Vector2 Deserialize(this BLNFPPMQGFV self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HXIPVLYCCWD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C02A0", Offset = "0xA1BF2A0", VA = "0x18A1C02A0")]
		public static HFDMGMXBATW Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0150", Offset = "0xA1BF150", VA = "0x18A1C0150")]
		public static HFDMGMXBATW KLSODAJNEMT([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C00E0", Offset = "0xA1BF0E0", VA = "0x18A1C00E0")]
		public static Vector3 Deserialize(this HFDMGMXBATW self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0210", Offset = "0xA1BF210", VA = "0x18A1C0210")]
		public static Vector3? OTVQASNCDGG(this HFDMGMXBATW a)
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
