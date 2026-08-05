using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D78240", Offset = "0x4D76E40", VA = "0x184D78240")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D78340", Offset = "0x4D76F40", VA = "0x184D78340")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
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

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
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
