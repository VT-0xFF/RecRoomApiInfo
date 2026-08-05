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
			[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6342DE0", Offset = "0x63417E0", VA = "0x186342DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6342E00", Offset = "0x6341800", VA = "0x186342E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6342E30", Offset = "0x6341830", VA = "0x186342E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6342C30", Offset = "0x6341630", VA = "0x186342C30")]
		private static int HIOCMKCEBMB(int GJKPHDBFOPE, int IPMLFELBCPL, bool JELPICCPLAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6342C70", Offset = "0x6341670", VA = "0x186342C70")]
		public static ViewId LNFAGJAFBAP(int GJKPHDBFOPE, int IPMLFELBCPL, bool JELPICCPLAL)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
		public static ViewId LNFAGJAFBAP(int POBCENNBLEB)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6342D50", Offset = "0x6341750", VA = "0x186342D50")]
		public static bool PIEEFOPMNNK(ViewId OLKIFIEFDII, ViewId AEIEBLGGCGK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6342A30", Offset = "0x6341430", VA = "0x186342A30")]
		public static bool EGKBPOJOPJH(ViewId OLKIFIEFDII, ViewId AEIEBLGGCGK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6342D00", Offset = "0x6341700", VA = "0x186342D00")]
		public static bool PIEEFOPMNNK(int OLKIFIEFDII, ViewId AEIEBLGGCGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6342A80", Offset = "0x6341480", VA = "0x186342A80", Slot = "4")]
		public bool Equals(ViewId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6342B10", Offset = "0x6341510", VA = "0x186342B10", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6342BE0", Offset = "0x63415E0", VA = "0x186342BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HGPFBJMODLC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int CGLPHGDNBNA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int IIAEDGPBBNI;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int NAMCCCMKCOO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6342660", Offset = "0x6341060", VA = "0x186342660")]
	public static void JNMECGKHMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63426B0", Offset = "0x63410B0", VA = "0x1863426B0")]
	public static void JOLPDDFHOJK(int[] OKDMDFNKNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6342790", Offset = "0x6341190", VA = "0x186342790")]
	public static int PHBIIABKPNN(int DIECIPCIMLC, Func<int, bool> LFOIMINGCKI, bool JELPICCPLAL = true)
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
