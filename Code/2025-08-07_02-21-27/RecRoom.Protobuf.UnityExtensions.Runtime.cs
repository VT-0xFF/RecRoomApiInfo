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
	public static class FUYNZCXDFKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91F5570", Offset = "0x91F4170", VA = "0x1891F5570")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91F54C0", Offset = "0x91F40C0", VA = "0x1891F54C0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91F54F0", Offset = "0x91F40F0", VA = "0x1891F54F0")]
		public static Color? PDCTBRDULDD(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class FFPXHYRFCLZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91F52B0", Offset = "0x91F3EB0", VA = "0x1891F52B0")]
		public static Quaternion XHLTTZEQESW(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x91F51C0", Offset = "0x91F3DC0", VA = "0x1891F51C0")]
		public static XZPPXPVCLKL PITXINDZASW(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91F5120", Offset = "0x91F3D20", VA = "0x1891F5120")]
		public static Quaternion KBBDEGWAUGR(XZPPXPVCLKL a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ELXDTKQPGEU
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x91F50A0", Offset = "0x91F3CA0", VA = "0x1891F50A0")]
		public static FEHJIBRGXCN Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x91F4F90", Offset = "0x91F3B90", VA = "0x1891F4F90")]
		public static Quaternion Deserialize(this FEHJIBRGXCN self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91F5000", Offset = "0x91F3C00", VA = "0x1891F5000")]
		public static Quaternion? PDCTBRDULDD(this FEHJIBRGXCN a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class KSAWHPEEVKT
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x91F5880", Offset = "0x91F4480", VA = "0x1891F5880")]
		public static WJNOEBIUWWU Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x91F5820", Offset = "0x91F4420", VA = "0x1891F5820")]
		public static Vector2 Deserialize(this WJNOEBIUWWU self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HEFCOFVRWIW
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x91F56F0", Offset = "0x91F42F0", VA = "0x1891F56F0")]
		public static XZPPXPVCLKL Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x91F5760", Offset = "0x91F4360", VA = "0x1891F5760")]
		public static XZPPXPVCLKL ZAICZCIUMPS([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x91F55F0", Offset = "0x91F41F0", VA = "0x1891F55F0")]
		public static Vector3 Deserialize(this XZPPXPVCLKL self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x91F5660", Offset = "0x91F4260", VA = "0x1891F5660")]
		public static Vector3? PDCTBRDULDD(this XZPPXPVCLKL a)
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
