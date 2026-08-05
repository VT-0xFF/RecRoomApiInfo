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
	public static class XJMNMKQRDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D900", Offset = "0x8C4C900", VA = "0x188C4D900")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D8D0", Offset = "0x8C4C8D0", VA = "0x188C4D8D0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D850", Offset = "0x8C4C850", VA = "0x188C4D850")]
		public static Color? BBRDPTJHNQL(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class PAVXWXWIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D410", Offset = "0x8C4C410", VA = "0x188C4D410")]
		public static Quaternion KLARQDCOBGY(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D320", Offset = "0x8C4C320", VA = "0x188C4D320")]
		public static AFFBNCEINSN BKXHFCQDMLG(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D620", Offset = "0x8C4C620", VA = "0x188C4D620")]
		public static Quaternion UHEIZRLSBAT(AFFBNCEINSN a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SZIFYTKDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D7D0", Offset = "0x8C4C7D0", VA = "0x188C4D7D0")]
		public static PZSATUBTZNB Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D760", Offset = "0x8C4C760", VA = "0x188C4D760")]
		public static Quaternion Deserialize(this PZSATUBTZNB self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D6C0", Offset = "0x8C4C6C0", VA = "0x188C4D6C0")]
		public static Quaternion? BBRDPTJHNQL(this PZSATUBTZNB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class YXXZMBXYHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D9E0", Offset = "0x8C4C9E0", VA = "0x188C4D9E0")]
		public static VIUPRSKYAOG Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D980", Offset = "0x8C4C980", VA = "0x188C4D980")]
		public static Vector2 Deserialize(this VIUPRSKYAOG self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MSNTEZOHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D2B0", Offset = "0x8C4C2B0", VA = "0x188C4D2B0")]
		public static AFFBNCEINSN Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D1F0", Offset = "0x8C4C1F0", VA = "0x188C4D1F0")]
		public static AFFBNCEINSN GOIHXGHWDGC([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D180", Offset = "0x8C4C180", VA = "0x188C4D180")]
		public static Vector3 Deserialize(this AFFBNCEINSN self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D0F0", Offset = "0x8C4C0F0", VA = "0x188C4D0F0")]
		public static Vector3? BBRDPTJHNQL(this AFFBNCEINSN a)
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
