using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation.Networking.DataTypes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct ViewId
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly ViewId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int id;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly int RawId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x60807D0", Offset = "0x607FBD0", VA = "0x1860807D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x60807F0", Offset = "0x607FBF0", VA = "0x1860807F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
		public static ViewId DHIBDNKNHDD(int CNPCLHIFPGE)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
		public static int JPANIEAALPM(ViewId CNPCLHIFPGE)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6080740", Offset = "0x607FB40", VA = "0x186080740")]
		public static ViewId JPANIEAALPM(int CNPCLHIFPGE)
		{
			return default(ViewId);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JPNKFCCGIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int JBBHDBLNECB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static int DNBNMEOLPGO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static int AGNMDAKCPKD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6080610", Offset = "0x607FA10", VA = "0x186080610")]
	public static void OBMDLDIFJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6080660", Offset = "0x607FA60", VA = "0x186080660")]
	public static void OBONFLLIEMI(int[] CGAHNJPCALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6080370", Offset = "0x607F770", VA = "0x186080370")]
	public static int GMHOIJKGOEN(int EKDBKGAIINK, Func<int, bool> OMKMHBLHBKO, bool LMPJODHHHPG = true)
	{
		return default(int);
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
