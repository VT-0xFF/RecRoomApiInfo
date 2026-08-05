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
		[Cpp2IlInjected.Address(RVA = "0xA15BD80", Offset = "0xA15A780", VA = "0x18A15BD80")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA15BCD0", Offset = "0xA15A6D0", VA = "0x18A15BCD0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA15BD00", Offset = "0xA15A700", VA = "0x18A15BD00")]
		public static Color? MNGNTURRRDY(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class INCGBHGTGPW
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA15BEF0", Offset = "0xA15A8F0", VA = "0x18A15BEF0")]
		public static Quaternion WLGPUQBIBER(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA15BE00", Offset = "0xA15A800", VA = "0x18A15BE00")]
		public static KLGEYPXWVRK MDEONWSTTNZ(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA15C100", Offset = "0xA15AB00", VA = "0x18A15C100")]
		public static Quaternion ZWMAJIHHWVS(KLGEYPXWVRK a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class UTXPCEWQVYL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA15C5B0", Offset = "0xA15AFB0", VA = "0x18A15C5B0")]
		public static MGIFITAWVOE Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA15C4A0", Offset = "0xA15AEA0", VA = "0x18A15C4A0")]
		public static Quaternion Deserialize(this MGIFITAWVOE self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA15C510", Offset = "0xA15AF10", VA = "0x18A15C510")]
		public static Quaternion? MNGNTURRRDY(this MGIFITAWVOE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ISBJYJMSMSS
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA15C200", Offset = "0xA15AC00", VA = "0x18A15C200")]
		public static ITDCCXOMFKT Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA15C1A0", Offset = "0xA15ABA0", VA = "0x18A15C1A0")]
		public static Vector2 Deserialize(this ITDCCXOMFKT self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TEKQSNBCRUP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA15C430", Offset = "0xA15AE30", VA = "0x18A15C430")]
		public static KLGEYPXWVRK Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA15C2E0", Offset = "0xA15ACE0", VA = "0x18A15C2E0")]
		public static KLGEYPXWVRK HMTYIBLGAQH([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA15C270", Offset = "0xA15AC70", VA = "0x18A15C270")]
		public static Vector3 Deserialize(this KLGEYPXWVRK self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA15C3A0", Offset = "0xA15ADA0", VA = "0x18A15C3A0")]
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
