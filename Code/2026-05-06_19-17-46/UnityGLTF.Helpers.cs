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
		private static readonly byte[] JDMBOOKTKEZ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB709CD0", Offset = "0xB7086D0", VA = "0x18B709CD0")]
		public BinaryWriterWithLessAllocations(Stream binStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB7099B0", Offset = "0xB7083B0", VA = "0x18B7099B0")]
		public void SISZBYWUTCR(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB709B30", Offset = "0xB708530", VA = "0x18B709B30", Slot = "27")]
		public override void Write(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB708EE0", Offset = "0xB7078E0", VA = "0x18B708EE0")]
		public void SISZBYWUTCR(Vector4[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB7092C0", Offset = "0xB707CC0", VA = "0x18B7092C0")]
		public void SISZBYWUTCR(Vector3[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB7095D0", Offset = "0xB707FD0", VA = "0x18B7095D0")]
		public void SISZBYWUTCR(Quaternion[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MZTQPBYWDFS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool CMEXCEDHTEI;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB709D90", Offset = "0xB708790", VA = "0x18B709D90")]
		public MZTQPBYWDFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB709D30", Offset = "0xB708730", VA = "0x18B709D30")]
		public void SOVVEDEWYGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDE7C20", Offset = "0xDE6620", VA = "0x180DE7C20")]
		private void CKJGTGSJXFI()
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
