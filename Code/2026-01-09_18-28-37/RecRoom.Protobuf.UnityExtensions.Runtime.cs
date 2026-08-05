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
	public static class RWZUOKAVMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89BBB30", Offset = "0x89BAF30", VA = "0x1889BBB30")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89BBA80", Offset = "0x89BAE80", VA = "0x1889BBA80")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89BBAB0", Offset = "0x89BAEB0", VA = "0x1889BBAB0")]
		public static Color? PYMDCSWBMEY(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JGPHYQWOWKS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89BB610", Offset = "0x89BAA10", VA = "0x1889BB610")]
		public static Quaternion IXIITIOBWOL(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89BB8C0", Offset = "0x89BACC0", VA = "0x1889BB8C0")]
		public static TXIRBLJMFHE SZALUTKNINT(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89BB820", Offset = "0x89BAC20", VA = "0x1889BB820")]
		public static Quaternion RWMTKMQJSPM(TXIRBLJMFHE a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class UCVRJWZGGAZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89BBCC0", Offset = "0x89BB0C0", VA = "0x1889BBCC0")]
		public static SHYPGXZLCKW Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89BBBB0", Offset = "0x89BAFB0", VA = "0x1889BBBB0")]
		public static Quaternion Deserialize(this SHYPGXZLCKW self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89BBC20", Offset = "0x89BB020", VA = "0x1889BBC20")]
		public static Quaternion? PYMDCSWBMEY(this SHYPGXZLCKW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JNIZSPTKBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89BBA10", Offset = "0x89BAE10", VA = "0x1889BBA10")]
		public static CSNSVTDIGMB Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89BB9B0", Offset = "0x89BADB0", VA = "0x1889BB9B0")]
		public static Vector2 Deserialize(this CSNSVTDIGMB self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class XBYWXHHSHTT
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89BBE40", Offset = "0x89BB240", VA = "0x1889BBE40")]
		public static TXIRBLJMFHE Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89BBEB0", Offset = "0x89BB2B0", VA = "0x1889BBEB0")]
		public static TXIRBLJMFHE VDJNANZDOOB([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89BBD40", Offset = "0x89BB140", VA = "0x1889BBD40")]
		public static Vector3 Deserialize(this TXIRBLJMFHE self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89BBDB0", Offset = "0x89BB1B0", VA = "0x1889BBDB0")]
		public static Vector3? PYMDCSWBMEY(this TXIRBLJMFHE a)
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
