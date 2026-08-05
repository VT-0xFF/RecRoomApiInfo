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
	public static class WVBYGZZHLQT
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8EE39D0", Offset = "0x8EE29D0", VA = "0x188EE39D0")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3920", Offset = "0x8EE2920", VA = "0x188EE3920")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3950", Offset = "0x8EE2950", VA = "0x188EE3950")]
		public static Color? LZMKTLWPYQB(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IYPRCQZVRBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3550", Offset = "0x8EE2550", VA = "0x188EE3550")]
		public static Quaternion RGIIEXRLFLM(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3760", Offset = "0x8EE2760", VA = "0x188EE3760")]
		public static TWVDJPVVLPV XTYAJCKQNOW(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EE34B0", Offset = "0x8EE24B0", VA = "0x188EE34B0")]
		public static Quaternion KUOQAUZTEBX(TWVDJPVVLPV a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CZJVAHWVYUA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3200", Offset = "0x8EE2200", VA = "0x188EE3200")]
		public static PPABZCBWRSB Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EE30F0", Offset = "0x8EE20F0", VA = "0x188EE30F0")]
		public static Quaternion Deserialize(this PPABZCBWRSB self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3160", Offset = "0x8EE2160", VA = "0x188EE3160")]
		public static Quaternion? LZMKTLWPYQB(this PPABZCBWRSB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LAVOYTJZMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE38B0", Offset = "0x8EE28B0", VA = "0x188EE38B0")]
		public static SGTBQBJNXCE Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3850", Offset = "0x8EE2850", VA = "0x188EE3850")]
		public static Vector2 Deserialize(this SGTBQBJNXCE self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class FWPXZTVHWTU
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3440", Offset = "0x8EE2440", VA = "0x188EE3440")]
		public static TWVDJPVVLPV Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3280", Offset = "0x8EE2280", VA = "0x188EE3280")]
		public static TWVDJPVVLPV DHXTUAUUEVC([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3340", Offset = "0x8EE2340", VA = "0x188EE3340")]
		public static Vector3 Deserialize(this TWVDJPVVLPV self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE33B0", Offset = "0x8EE23B0", VA = "0x188EE33B0")]
		public static Vector3? LZMKTLWPYQB(this TWVDJPVVLPV a)
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
