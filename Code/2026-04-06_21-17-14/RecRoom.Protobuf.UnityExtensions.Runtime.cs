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
	public static class EOTEABFLHVS
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA17CA80", Offset = "0xA17BA80", VA = "0x18A17CA80")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA17C9D0", Offset = "0xA17B9D0", VA = "0x18A17C9D0")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA17CA00", Offset = "0xA17BA00", VA = "0x18A17CA00")]
		public static Color? GHTAOJYZCNS(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IOWIHIOVADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA17CC90", Offset = "0xA17BC90", VA = "0x18A17CC90")]
		public static Quaternion QZXGBOEGGWP(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA17CBA0", Offset = "0xA17BBA0", VA = "0x18A17CBA0")]
		public static RGEMMZCMHHA KFWRVGOPXJD(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA17CB00", Offset = "0xA17BB00", VA = "0x18A17CB00")]
		public static Quaternion BDGPWXLUMUW(RGEMMZCMHHA a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class VCZXDXTPIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA17D080", Offset = "0xA17C080", VA = "0x18A17D080")]
		public static BCGXTWLAAWK Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA17CF70", Offset = "0xA17BF70", VA = "0x18A17CF70")]
		public static Quaternion Deserialize(this BCGXTWLAAWK self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA17CFE0", Offset = "0xA17BFE0", VA = "0x18A17CFE0")]
		public static Quaternion? GHTAOJYZCNS(this BCGXTWLAAWK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ONXFBAMYXXS
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA17CF00", Offset = "0xA17BF00", VA = "0x18A17CF00")]
		public static WCOYIIVWULH Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA17CEA0", Offset = "0xA17BEA0", VA = "0x18A17CEA0")]
		public static Vector2 Deserialize(this WCOYIIVWULH self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ATHLICWQDRT
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA17C960", Offset = "0xA17B960", VA = "0x18A17C960")]
		public static RGEMMZCMHHA Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA17C8A0", Offset = "0xA17B8A0", VA = "0x18A17C8A0")]
		public static RGEMMZCMHHA RZESMDLYESF([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA17C7A0", Offset = "0xA17B7A0", VA = "0x18A17C7A0")]
		public static Vector3 Deserialize(this RGEMMZCMHHA self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA17C810", Offset = "0xA17B810", VA = "0x18A17C810")]
		public static Vector3? GHTAOJYZCNS(this RGEMMZCMHHA a)
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
