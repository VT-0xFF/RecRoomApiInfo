using System;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal class BinaryWriterWithLessAllocations : BinaryWriter
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly byte[] ZWRYTMZYRZA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F326C0", Offset = "0x9F30EC0", VA = "0x189F326C0")]
		public BinaryWriterWithLessAllocations(Stream binStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F31990", Offset = "0x9F30190", VA = "0x189F31990")]
		public void DKMXHPDZVPU(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F32530", Offset = "0x9F30D30", VA = "0x189F32530", Slot = "27")]
		public override void Write(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F31B00", Offset = "0x9F30300", VA = "0x189F31B00")]
		public void DKMXHPDZVPU(Vector4[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9F32240", Offset = "0x9F30A40", VA = "0x189F32240")]
		public void DKMXHPDZVPU(Vector3[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F31EA0", Offset = "0x9F306A0", VA = "0x189F31EA0")]
		public void DKMXHPDZVPU(Quaternion[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class UGTMLBJAJRF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool UCMTLAQFKFZ;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F32780", Offset = "0x9F30F80", VA = "0x189F32780")]
		public UGTMLBJAJRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F32720", Offset = "0x9F30F20", VA = "0x189F32720")]
		public void XYQBCIWOTTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB3A100", Offset = "0xB38900", VA = "0x180B3A100")]
		private void CZVGKTPZPFL()
		{
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
