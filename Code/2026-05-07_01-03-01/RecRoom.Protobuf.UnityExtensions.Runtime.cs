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
	public static class CJYWLONKILQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA003D50", Offset = "0xA002750", VA = "0x18A003D50")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA003CA0", Offset = "0xA0026A0", VA = "0x18A003CA0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA003CD0", Offset = "0xA0026D0", VA = "0x18A003CD0")]
		public static Color? MNGNTURRRDY(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class INCGBHGTGPW
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA003EC0", Offset = "0xA0028C0", VA = "0x18A003EC0")]
		public static Quaternion WLGPUQBIBER(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA003DD0", Offset = "0xA0027D0", VA = "0x18A003DD0")]
		public static KLGEYPXWVRK MDEONWSTTNZ(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0040D0", Offset = "0xA002AD0", VA = "0x18A0040D0")]
		public static Quaternion ZWMAJIHHWVS(KLGEYPXWVRK a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class UTXPCEWQVYL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA004580", Offset = "0xA002F80", VA = "0x18A004580")]
		public static MGIFITAWVOE Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA004470", Offset = "0xA002E70", VA = "0x18A004470")]
		public static Quaternion Deserialize(this MGIFITAWVOE self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0044E0", Offset = "0xA002EE0", VA = "0x18A0044E0")]
		public static Quaternion? MNGNTURRRDY(this MGIFITAWVOE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ISBJYJMSMSS
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0041D0", Offset = "0xA002BD0", VA = "0x18A0041D0")]
		public static ITDCCXOMFKT Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA004170", Offset = "0xA002B70", VA = "0x18A004170")]
		public static Vector2 Deserialize(this ITDCCXOMFKT self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TEKQSNBCRUP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA004400", Offset = "0xA002E00", VA = "0x18A004400")]
		public static KLGEYPXWVRK Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0042B0", Offset = "0xA002CB0", VA = "0x18A0042B0")]
		public static KLGEYPXWVRK HMTYIBLGAQH([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA004240", Offset = "0xA002C40", VA = "0x18A004240")]
		public static Vector3 Deserialize(this KLGEYPXWVRK self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA004370", Offset = "0xA002D70", VA = "0x18A004370")]
		public static Vector3? MNGNTURRRDY(this KLGEYPXWVRK a)
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
