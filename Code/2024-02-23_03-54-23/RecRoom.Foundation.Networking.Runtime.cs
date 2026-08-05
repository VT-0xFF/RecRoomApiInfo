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
			[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5FCD440", Offset = "0x5FCBE40", VA = "0x185FCD440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5FCD460", Offset = "0x5FCBE60", VA = "0x185FCD460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5FCD490", Offset = "0x5FCBE90", VA = "0x185FCD490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD330", Offset = "0x5FCBD30", VA = "0x185FCD330")]
		private static int KGJBCAOIKMP(int EDCGGAMNCJP, int NDFPBNOLAIB, bool PAHNCNIPAHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD370", Offset = "0x5FCBD70", VA = "0x185FCD370")]
		public static ViewId OGHELNAPKFG(int EDCGGAMNCJP, int NDFPBNOLAIB, bool PAHNCNIPAHA)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC0AF30", Offset = "0xC09930", VA = "0x180C0AF30")]
		public static ViewId OGHELNAPKFG(int IPCLAAKALGF)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD290", Offset = "0x5FCBC90", VA = "0x185FCD290")]
		public static bool FFFIMEBHMPG(ViewId JIKBDKDLPCA, ViewId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD170", Offset = "0x5FCBB70", VA = "0x185FCD170")]
		public static bool DKCGANGKMBM(ViewId JIKBDKDLPCA, ViewId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD2E0", Offset = "0x5FCBCE0", VA = "0x185FCD2E0")]
		public static bool FFFIMEBHMPG(int JIKBDKDLPCA, ViewId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD1C0", Offset = "0x5FCBBC0", VA = "0x185FCD1C0", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FCCDA0", Offset = "0x5FCB7A0", VA = "0x185FCCDA0")]
	public static void AHKAMDMKNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCDF0", Offset = "0x5FCB7F0", VA = "0x185FCCDF0")]
	public static void ILODKMHAFAJ(int[] FGBLNAGHNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCED0", Offset = "0x5FCB8D0", VA = "0x185FCCED0")]
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
