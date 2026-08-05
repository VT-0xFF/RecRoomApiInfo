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
		[Cpp2IlInjected.Address(RVA = "0x8AEE0F0", Offset = "0x8AECAF0", VA = "0x188AEE0F0")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE0C0", Offset = "0x8AECAC0", VA = "0x188AEE0C0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE170", Offset = "0x8AECB70", VA = "0x188AEE170")]
		public static Color? UEGWFXAKCQL(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class VGODVLAIYDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE680", Offset = "0x8AED080", VA = "0x188AEE680")]
		public static Quaternion CRSDOMQVVEQ(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE930", Offset = "0x8AED330", VA = "0x188AEE930")]
		public static LLBLKLIGICF ULBTOWOHSRW(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE890", Offset = "0x8AED290", VA = "0x188AEE890")]
		public static Quaternion HLQUWVQAEVB(LLBLKLIGICF a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PEFYLBACFDU
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE490", Offset = "0x8AECE90", VA = "0x188AEE490")]
		public static ZRJTQSEIUIL Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE420", Offset = "0x8AECE20", VA = "0x188AEE420")]
		public static Quaternion Deserialize(this ZRJTQSEIUIL self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE510", Offset = "0x8AECF10", VA = "0x188AEE510")]
		public static Quaternion? UEGWFXAKCQL(this ZRJTQSEIUIL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QFBRBMGVQSJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE610", Offset = "0x8AED010", VA = "0x188AEE610")]
		public static MCFUSGFOFAS Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE5B0", Offset = "0x8AECFB0", VA = "0x188AEE5B0")]
		public static Vector2 Deserialize(this MCFUSGFOFAS self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class IOPZGYNNRTW
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE320", Offset = "0x8AECD20", VA = "0x188AEE320")]
		public static LLBLKLIGICF Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE260", Offset = "0x8AECC60", VA = "0x188AEE260")]
		public static LLBLKLIGICF FJFBKKYGXHE([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE1F0", Offset = "0x8AECBF0", VA = "0x188AEE1F0")]
		public static Vector3 Deserialize(this LLBLKLIGICF self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE390", Offset = "0x8AECD90", VA = "0x188AEE390")]
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
