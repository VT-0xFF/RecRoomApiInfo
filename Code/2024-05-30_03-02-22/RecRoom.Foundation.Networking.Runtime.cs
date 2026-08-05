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
	public struct ViewId : IEquatable<ViewId>
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
			[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6403AA0", Offset = "0x6402CA0", VA = "0x186403AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6403AC0", Offset = "0x6402CC0", VA = "0x186403AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6403AF0", Offset = "0x6402CF0", VA = "0x186403AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6403980", Offset = "0x6402B80", VA = "0x186403980")]
		private static int KAFNNPPCCHD(int ANKGELANBDP, int HHIGMDGEDLO, bool NACJNLCPAKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64036E0", Offset = "0x64028E0", VA = "0x1864036E0")]
		public static ViewId EOEPFJDEGGL(int ANKGELANBDP, int HHIGMDGEDLO, bool NACJNLCPAKL)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
		public static ViewId EOEPFJDEGGL(int CAFJCEGOHKN)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6403A10", Offset = "0x6402C10", VA = "0x186403A10")]
		public static bool LOAKJDDAMKI(ViewId ABPADDODFDF, ViewId DLCDCNECDEP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6403930", Offset = "0x6402B30", VA = "0x186403930")]
		public static bool IICOCCMJGPI(ViewId ABPADDODFDF, ViewId DLCDCNECDEP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64039C0", Offset = "0x6402BC0", VA = "0x1864039C0")]
		public static bool LOAKJDDAMKI(int ABPADDODFDF, ViewId DLCDCNECDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6403770", Offset = "0x6402970", VA = "0x186403770", Slot = "4")]
		public bool Equals(ViewId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6403800", Offset = "0x6402A00", VA = "0x186403800", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64038E0", Offset = "0x6402AE0", VA = "0x1864038E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BPNOMNFDEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int CPKEAOHMGGE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int AMIHEJIJGJG;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int HNGLKOJKNFD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64033F0", Offset = "0x64025F0", VA = "0x1864033F0")]
	public static void MDFPIDIKIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6403310", Offset = "0x6402510", VA = "0x186403310")]
	public static void GNAMJCMDNPF(int[] LHPAJBKJNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6403440", Offset = "0x6402640", VA = "0x186403440")]
	public static int OOOIMIHNFDL(int FPNIACGLHJH, Func<int, bool> NCODHKHHIEF, bool NACJNLCPAKL = true)
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
