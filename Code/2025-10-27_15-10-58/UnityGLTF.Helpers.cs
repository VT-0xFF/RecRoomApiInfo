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
		private static readonly byte[] BNELVFISODO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA437590", Offset = "0xA436590", VA = "0x18A437590")]
		public BinaryWriterWithLessAllocations(Stream binStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA436AB0", Offset = "0xA435AB0", VA = "0x18A436AB0")]
		public void UHEUJRAAHAM(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA4373F0", Offset = "0xA4363F0", VA = "0x18A4373F0", Slot = "27")]
		public override void Write(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA437010", Offset = "0xA436010", VA = "0x18A437010")]
		public void UHEUJRAAHAM(Vector4[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA4367A0", Offset = "0xA4357A0", VA = "0x18A4367A0")]
		public void UHEUJRAAHAM(Vector3[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA436C30", Offset = "0xA435C30", VA = "0x18A436C30")]
		public void UHEUJRAAHAM(Quaternion[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class ZOAWNVZMKLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool UFOVZNJBTKB;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA437650", Offset = "0xA436650", VA = "0x18A437650")]
		public ZOAWNVZMKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA4375F0", Offset = "0xA4365F0", VA = "0x18A4375F0")]
		public void JLBUPWKQEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEE2350", Offset = "0xEE1350", VA = "0x180EE2350")]
		private void HCSPGBHFWCX()
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
