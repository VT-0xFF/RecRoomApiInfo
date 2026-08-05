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
		private static readonly byte[] ROQZMBMEMFZ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA24FFB0", Offset = "0xA24EDB0", VA = "0x18A24FFB0")]
		public BinaryWriterWithLessAllocations(Stream binStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA24F1C0", Offset = "0xA24DFC0", VA = "0x18A24F1C0")]
		public void DOQRKGDHTJZ(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA24FE10", Offset = "0xA24EC10", VA = "0x18A24FE10", Slot = "27")]
		public override void Write(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA24F340", Offset = "0xA24E140", VA = "0x18A24F340")]
		public void DOQRKGDHTJZ(Vector4[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA24FB00", Offset = "0xA24E900", VA = "0x18A24FB00")]
		public void DOQRKGDHTJZ(Vector3[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA24F720", Offset = "0xA24E520", VA = "0x18A24F720")]
		public void DOQRKGDHTJZ(Quaternion[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class LNQHWACHMRM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool DRLTLTVYILI;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA250070", Offset = "0xA24EE70", VA = "0x18A250070")]
		public LNQHWACHMRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA250010", Offset = "0xA24EE10", VA = "0x18A250010")]
		public void FUMCGNWNOUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBD7B90", Offset = "0xBD6990", VA = "0x180BD7B90")]
		private void VTNWMPDBUXG()
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
