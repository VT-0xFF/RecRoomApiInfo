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
			[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6195410", Offset = "0x6194410", VA = "0x186195410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6195430", Offset = "0x6194430", VA = "0x186195430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6195460", Offset = "0x6194460", VA = "0x186195460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6195390", Offset = "0x6194390", VA = "0x186195390")]
		private static int OLGDCCAMIKM(int GMCBHGNMGAJ, int NPPLAIJDPLJ, bool OHKPPCNJJPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6195060", Offset = "0x6194060", VA = "0x186195060")]
		public static ViewId AAHLBGJBNOI(int GMCBHGNMGAJ, int NPPLAIJDPLJ, bool OHKPPCNJJPE)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD8A8A0", Offset = "0xD898A0", VA = "0x180D8A8A0")]
		public static ViewId AAHLBGJBNOI(int KBBEAOIHJGM)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6195340", Offset = "0x6194340", VA = "0x186195340")]
		public static bool INAKJEGDKIC(ViewId FKOPFOECIGH, ViewId DGKDEKELGHC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61952A0", Offset = "0x61942A0", VA = "0x1861952A0")]
		public static bool HNKADOHNPFO(ViewId FKOPFOECIGH, ViewId DGKDEKELGHC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61952F0", Offset = "0x61942F0", VA = "0x1861952F0")]
		public static bool INAKJEGDKIC(int FKOPFOECIGH, ViewId DGKDEKELGHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61950F0", Offset = "0x61940F0", VA = "0x1861950F0", Slot = "4")]
		public bool Equals(ViewId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6195180", Offset = "0x6194180", VA = "0x186195180", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6195250", Offset = "0x6194250", VA = "0x186195250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NAIEHMOHIIC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int MPJKEMJCEJK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int AMECCOHABLM;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int BFPNCPONPJI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6195010", Offset = "0x6194010", VA = "0x186195010")]
	public static void PAIMAMEEAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6194F30", Offset = "0x6193F30", VA = "0x186194F30")]
	public static void KCFALHHJGIF(int[] PNPBKIAOEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6194C90", Offset = "0x6193C90", VA = "0x186194C90")]
	public static int HPLCCIGJDPJ(int GPMMDFLBEID, Func<int, bool> IPJBGCEEGEC, bool OHKPPCNJJPE = true)
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
