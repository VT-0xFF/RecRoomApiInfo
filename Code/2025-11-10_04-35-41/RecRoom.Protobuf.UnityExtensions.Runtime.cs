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
	public static class CKZFVJRIPJS
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D480", Offset = "0x8A3C880", VA = "0x188A3D480")]
		public static ColorData Serialize([In] this Color self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D450", Offset = "0x8A3C850", VA = "0x188A3D450")]
		public static Color Deserialize(this ColorData self)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D3D0", Offset = "0x8A3C7D0", VA = "0x188A3D3D0")]
		public static Color? CIKQACMRCZK(this ColorData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class UVZMLWHXMPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D800", Offset = "0x8A3CC00", VA = "0x188A3D800")]
		public static Quaternion EQGPJFJEGJR(TransformData a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DAB0", Offset = "0x8A3CEB0", VA = "0x188A3DAB0")]
		public static PQZTEIXSHPA MAFAPDSLPBD(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DA10", Offset = "0x8A3CE10", VA = "0x188A3DA10")]
		public static Quaternion HNNUCZKPCEG(PQZTEIXSHPA a)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class VPNLSMHTHXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DCB0", Offset = "0x8A3D0B0", VA = "0x188A3DCB0")]
		public static MGUVICTOGHY Serialize([In] this Quaternion self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DC40", Offset = "0x8A3D040", VA = "0x188A3DC40")]
		public static Quaternion Deserialize(this MGUVICTOGHY self)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DBA0", Offset = "0x8A3CFA0", VA = "0x188A3DBA0")]
		public static Quaternion? CIKQACMRCZK(this MGUVICTOGHY a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OGMUVFPYPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D790", Offset = "0x8A3CB90", VA = "0x188A3D790")]
		public static ZWARGTSRWDX Serialize([In] this Vector2 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D730", Offset = "0x8A3CB30", VA = "0x188A3D730")]
		public static Vector2 Deserialize(this ZWARGTSRWDX self)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class NGCJWZMILJT
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D6C0", Offset = "0x8A3CAC0", VA = "0x188A3D6C0")]
		public static PQZTEIXSHPA Serialize([In] this Vector3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D600", Offset = "0x8A3CA00", VA = "0x188A3D600")]
		public static PQZTEIXSHPA HAEQWLTITHX([In] this Vector3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D590", Offset = "0x8A3C990", VA = "0x188A3D590")]
		public static Vector3 Deserialize(this PQZTEIXSHPA self)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D500", Offset = "0x8A3C900", VA = "0x188A3D500")]
		public static Vector3? CIKQACMRCZK(this PQZTEIXSHPA a)
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
