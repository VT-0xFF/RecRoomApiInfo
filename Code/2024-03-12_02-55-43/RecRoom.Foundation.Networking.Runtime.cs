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
			[Cpp2IlInjected.Address(RVA = "0x912370", Offset = "0x911570", VA = "0x180912370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x61571A0", Offset = "0x61563A0", VA = "0x1861571A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x61571C0", Offset = "0x61563C0", VA = "0x1861571C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x61571F0", Offset = "0x61563F0", VA = "0x1861571F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6156FC0", Offset = "0x61561C0", VA = "0x186156FC0")]
		private static int DJCBEMPGKMK(int MLJCHMKBNNM, int AIKKDMPMOJM, bool EKPNGBJDGLM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61570D0", Offset = "0x61562D0", VA = "0x1861570D0")]
		public static ViewId FONJMPBBNDI(int MLJCHMKBNNM, int AIKKDMPMOJM, bool EKPNGBJDGLM)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD867E0", Offset = "0xD859E0", VA = "0x180D867E0")]
		public static ViewId FONJMPBBNDI(int DAFOAGFNGEK)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6156F20", Offset = "0x6156120", VA = "0x186156F20")]
		public static bool CDBCKLPENDN(ViewId GNBALBEAIKA, ViewId ODFCMCFCPMH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6156F70", Offset = "0x6156170", VA = "0x186156F70")]
		public static bool DFHJMIKFMMI(ViewId GNBALBEAIKA, ViewId ODFCMCFCPMH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6156ED0", Offset = "0x61560D0", VA = "0x186156ED0")]
		public static bool CDBCKLPENDN(int GNBALBEAIKA, ViewId ODFCMCFCPMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6157000", Offset = "0x6156200", VA = "0x186157000", Slot = "0")]
		public override bool Equals(object MFLACBLODGN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AAMJCDKBFKO
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int NKKNFALGOBJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int CBEJDAPNABL;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int EGLFNEKBJKC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6156E80", Offset = "0x6156080", VA = "0x186156E80")]
	public static void LMBCJLFNEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6156DA0", Offset = "0x6155FA0", VA = "0x186156DA0")]
	public static void JHDELOKNPCE(int[] LHBNILBLMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6156B00", Offset = "0x6155D00", VA = "0x186156B00")]
	public static int ADNMDDNLHJN(int ELJPLNEKLLE, Func<int, bool> JCMIPMPJBNI, bool EKPNGBJDGLM = true)
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
