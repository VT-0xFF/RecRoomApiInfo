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
		private static readonly byte[] BZEXKDNXHAV;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB860310", Offset = "0xB85F310", VA = "0x18B860310")]
		public BinaryWriterWithLessAllocations(Stream binStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB85F830", Offset = "0xB85E830", VA = "0x18B85F830")]
		public void NTXNIJJJHYF(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB860170", Offset = "0xB85F170", VA = "0x18B860170", Slot = "27")]
		public override void Write(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB85F9B0", Offset = "0xB85E9B0", VA = "0x18B85F9B0")]
		public void NTXNIJJJHYF(Vector4[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB85F520", Offset = "0xB85E520", VA = "0x18B85F520")]
		public void NTXNIJJJHYF(Vector3[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB85FD90", Offset = "0xB85ED90", VA = "0x18B85FD90")]
		public void NTXNIJJJHYF(Quaternion[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class EVBAMNZHFYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool KMGMBOLKKMM;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB8603D0", Offset = "0xB85F3D0", VA = "0x18B8603D0")]
		public EVBAMNZHFYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB860370", Offset = "0xB85F370", VA = "0x18B860370")]
		public void ZGQZTJPWRBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE0C350", Offset = "0xE0B350", VA = "0x180E0C350")]
		private void WZHSYJNJGKC()
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
