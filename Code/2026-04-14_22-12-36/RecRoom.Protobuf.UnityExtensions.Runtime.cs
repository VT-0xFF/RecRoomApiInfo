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
		[Cpp2IlInjected.Address(RVA = "0xA01EE00", Offset = "0xA01DA00", VA = "0x18A01EE00")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA01ED50", Offset = "0xA01D950", VA = "0x18A01ED50")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA01ED80", Offset = "0xA01D980", VA = "0x18A01ED80")]
		public static Color? OTVQASNCDGG(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class KTPRVNVHDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA01F220", Offset = "0xA01DE20", VA = "0x18A01F220")]
		public static Quaternion GXESKQXJCSF(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA01F430", Offset = "0xA01E030", VA = "0x18A01F430")]
		public static HFDMGMXBATW VMLYXYWOXFV(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA01F180", Offset = "0xA01DD80", VA = "0x18A01F180")]
		public static Quaternion GJDMRFQCRKI(HFDMGMXBATW a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OTHBTHVQXMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA01F630", Offset = "0xA01E230", VA = "0x18A01F630")]
		public static BWKOHKJADTG Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA01F520", Offset = "0xA01E120", VA = "0x18A01F520")]
		public static Quaternion Deserialize(this BWKOHKJADTG self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA01F590", Offset = "0xA01E190", VA = "0x18A01F590")]
		public static Quaternion? OTVQASNCDGG(this BWKOHKJADTG a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class IGSZQLRKLDY
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA01F110", Offset = "0xA01DD10", VA = "0x18A01F110")]
		public static BLNFPPMQGFV Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA01F0B0", Offset = "0xA01DCB0", VA = "0x18A01F0B0")]
		public static Vector2 Deserialize(this BLNFPPMQGFV self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HXIPVLYCCWD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA01F040", Offset = "0xA01DC40", VA = "0x18A01F040")]
		public static HFDMGMXBATW Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA01EEF0", Offset = "0xA01DAF0", VA = "0x18A01EEF0")]
		public static HFDMGMXBATW KLSODAJNEMT([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA01EE80", Offset = "0xA01DA80", VA = "0x18A01EE80")]
		public static Vector3 Deserialize(this HFDMGMXBATW self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA01EFB0", Offset = "0xA01DBB0", VA = "0x18A01EFB0")]
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
