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
		[Cpp2IlInjected.Address(RVA = "0xA17CA20", Offset = "0xA17BA20", VA = "0x18A17CA20")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA17C970", Offset = "0xA17B970", VA = "0x18A17C970")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA17C9A0", Offset = "0xA17B9A0", VA = "0x18A17C9A0")]
		public static Color? GHTAOJYZCNS(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IOWIHIOVADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA17CC30", Offset = "0xA17BC30", VA = "0x18A17CC30")]
		public static Quaternion QZXGBOEGGWP(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA17CB40", Offset = "0xA17BB40", VA = "0x18A17CB40")]
		public static RGEMMZCMHHA KFWRVGOPXJD(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA17CAA0", Offset = "0xA17BAA0", VA = "0x18A17CAA0")]
		public static Quaternion BDGPWXLUMUW(RGEMMZCMHHA a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class VCZXDXTPIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA17D020", Offset = "0xA17C020", VA = "0x18A17D020")]
		public static BCGXTWLAAWK Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA17CF10", Offset = "0xA17BF10", VA = "0x18A17CF10")]
		public static Quaternion Deserialize(this BCGXTWLAAWK self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA17CF80", Offset = "0xA17BF80", VA = "0x18A17CF80")]
		public static Quaternion? GHTAOJYZCNS(this BCGXTWLAAWK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ONXFBAMYXXS
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA17CEA0", Offset = "0xA17BEA0", VA = "0x18A17CEA0")]
		public static WCOYIIVWULH Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA17CE40", Offset = "0xA17BE40", VA = "0x18A17CE40")]
		public static Vector2 Deserialize(this WCOYIIVWULH self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ATHLICWQDRT
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA17C900", Offset = "0xA17B900", VA = "0x18A17C900")]
		public static RGEMMZCMHHA Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA17C840", Offset = "0xA17B840", VA = "0x18A17C840")]
		public static RGEMMZCMHHA RZESMDLYESF([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA17C740", Offset = "0xA17B740", VA = "0x18A17C740")]
		public static Vector3 Deserialize(this RGEMMZCMHHA self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA17C7B0", Offset = "0xA17B7B0", VA = "0x18A17C7B0")]
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
