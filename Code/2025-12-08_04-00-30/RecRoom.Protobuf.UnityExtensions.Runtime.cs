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
	public static class HSIOZKGKTBT
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89EB9F0", Offset = "0x89EA1F0", VA = "0x1889EB9F0")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89EB9C0", Offset = "0x89EA1C0", VA = "0x1889EB9C0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89EBA70", Offset = "0x89EA270", VA = "0x1889EBA70")]
		public static Color? UEGWFXAKCQL(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class VGODVLAIYDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89EBF80", Offset = "0x89EA780", VA = "0x1889EBF80")]
		public static Quaternion CRSDOMQVVEQ(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89EC230", Offset = "0x89EAA30", VA = "0x1889EC230")]
		public static LLBLKLIGICF ULBTOWOHSRW(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89EC190", Offset = "0x89EA990", VA = "0x1889EC190")]
		public static Quaternion HLQUWVQAEVB(LLBLKLIGICF a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PEFYLBACFDU
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89EBD90", Offset = "0x89EA590", VA = "0x1889EBD90")]
		public static ZRJTQSEIUIL Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89EBD20", Offset = "0x89EA520", VA = "0x1889EBD20")]
		public static Quaternion Deserialize(this ZRJTQSEIUIL self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89EBE10", Offset = "0x89EA610", VA = "0x1889EBE10")]
		public static Quaternion? UEGWFXAKCQL(this ZRJTQSEIUIL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QFBRBMGVQSJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89EBF10", Offset = "0x89EA710", VA = "0x1889EBF10")]
		public static MCFUSGFOFAS Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89EBEB0", Offset = "0x89EA6B0", VA = "0x1889EBEB0")]
		public static Vector2 Deserialize(this MCFUSGFOFAS self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class IOPZGYNNRTW
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89EBC20", Offset = "0x89EA420", VA = "0x1889EBC20")]
		public static LLBLKLIGICF Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89EBB60", Offset = "0x89EA360", VA = "0x1889EBB60")]
		public static LLBLKLIGICF FJFBKKYGXHE([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89EBAF0", Offset = "0x89EA2F0", VA = "0x1889EBAF0")]
		public static Vector3 Deserialize(this LLBLKLIGICF self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89EBC90", Offset = "0x89EA490", VA = "0x1889EBC90")]
		public static Vector3? UEGWFXAKCQL(this LLBLKLIGICF a)
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
