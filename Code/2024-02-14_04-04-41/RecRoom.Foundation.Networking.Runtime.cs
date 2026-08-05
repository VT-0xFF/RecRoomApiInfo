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
		public const int MAX_VIEW_IDS = 100000;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const int MAX_PLAYER_IDS = 10000;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public const int MAX_VIEW_SUB_IDS = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public const int DONT_DESTROY_ON_LEAVE_FLAG = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public const int RUNTIME_INSTANTIATE_VIEW_ID_OFFSET = 90000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public const int COMPILE_TIME_MAIN_ROOT_ID_OFFSET = 89000;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly ViewId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int id;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly int RawId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5F53BF0", Offset = "0x5F52FF0", VA = "0x185F53BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5F53C10", Offset = "0x5F53010", VA = "0x185F53C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5F53C40", Offset = "0x5F53040", VA = "0x185F53C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F53AE0", Offset = "0x5F52EE0", VA = "0x185F53AE0")]
		private static int KGJBCAOIKMP(int EDCGGAMNCJP, int NDFPBNOLAIB, bool PAHNCNIPAHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F53B20", Offset = "0x5F52F20", VA = "0x185F53B20")]
		public static ViewId OGHELNAPKFG(int EDCGGAMNCJP, int NDFPBNOLAIB, bool PAHNCNIPAHA)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBFD7D0", Offset = "0xBFCBD0", VA = "0x180BFD7D0")]
		public static ViewId OGHELNAPKFG(int IPCLAAKALGF)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F53A40", Offset = "0x5F52E40", VA = "0x185F53A40")]
		public static bool FFFIMEBHMPG(ViewId JIKBDKDLPCA, ViewId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F53920", Offset = "0x5F52D20", VA = "0x185F53920")]
		public static bool DKCGANGKMBM(ViewId JIKBDKDLPCA, ViewId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F53A90", Offset = "0x5F52E90", VA = "0x185F53A90")]
		public static bool FFFIMEBHMPG(int JIKBDKDLPCA, ViewId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F53970", Offset = "0x5F52D70", VA = "0x185F53970", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FPJNKOMFGFI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int DDOAFHNAACJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int AOGLLLMLIDP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int DJNPLNABMHK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F53550", Offset = "0x5F52950", VA = "0x185F53550")]
	public static void AHKAMDMKNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F535A0", Offset = "0x5F529A0", VA = "0x185F535A0")]
	public static void ILODKMHAFAJ(int[] FGBLNAGHNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5F53680", Offset = "0x5F52A80", VA = "0x185F53680")]
	public static int NBDPBIENNNB(int CEBLPNFDPJD, Func<int, bool> GCBJJNIKCJC, bool PAHNCNIPAHA = true)
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
