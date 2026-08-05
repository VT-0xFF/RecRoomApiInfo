using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public sealed class TransformEntity : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int prefabType;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public TransformEntity()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1252FA0", Offset = "0x12517A0", VA = "0x181252FA0")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x12530A0", Offset = "0x12518A0", VA = "0x1812530A0")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
