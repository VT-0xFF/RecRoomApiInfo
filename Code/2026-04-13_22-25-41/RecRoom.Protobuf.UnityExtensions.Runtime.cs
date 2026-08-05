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
		[Cpp2IlInjected.Address(RVA = "0xA01D350", Offset = "0xA01BD50", VA = "0x18A01D350")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA01D2A0", Offset = "0xA01BCA0", VA = "0x18A01D2A0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA01D2D0", Offset = "0xA01BCD0", VA = "0x18A01D2D0")]
		public static Color? OTVQASNCDGG(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class KTPRVNVHDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA01D770", Offset = "0xA01C170", VA = "0x18A01D770")]
		public static Quaternion GXESKQXJCSF(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA01D980", Offset = "0xA01C380", VA = "0x18A01D980")]
		public static HFDMGMXBATW VMLYXYWOXFV(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA01D6D0", Offset = "0xA01C0D0", VA = "0x18A01D6D0")]
		public static Quaternion GJDMRFQCRKI(HFDMGMXBATW a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OTHBTHVQXMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA01DB80", Offset = "0xA01C580", VA = "0x18A01DB80")]
		public static BWKOHKJADTG Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA01DA70", Offset = "0xA01C470", VA = "0x18A01DA70")]
		public static Quaternion Deserialize(this BWKOHKJADTG self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA01DAE0", Offset = "0xA01C4E0", VA = "0x18A01DAE0")]
		public static Quaternion? OTVQASNCDGG(this BWKOHKJADTG a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class IGSZQLRKLDY
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA01D660", Offset = "0xA01C060", VA = "0x18A01D660")]
		public static BLNFPPMQGFV Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA01D600", Offset = "0xA01C000", VA = "0x18A01D600")]
		public static Vector2 Deserialize(this BLNFPPMQGFV self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HXIPVLYCCWD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA01D590", Offset = "0xA01BF90", VA = "0x18A01D590")]
		public static HFDMGMXBATW Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA01D440", Offset = "0xA01BE40", VA = "0x18A01D440")]
		public static HFDMGMXBATW KLSODAJNEMT([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA01D3D0", Offset = "0xA01BDD0", VA = "0x18A01D3D0")]
		public static Vector3 Deserialize(this HFDMGMXBATW self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA01D500", Offset = "0xA01BF00", VA = "0x18A01D500")]
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
