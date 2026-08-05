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
			[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x61F4410", Offset = "0x61F3610", VA = "0x1861F4410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x61F4430", Offset = "0x61F3630", VA = "0x1861F4430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x61F4460", Offset = "0x61F3660", VA = "0x1861F4460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61F4390", Offset = "0x61F3590", VA = "0x1861F4390")]
		private static int NLMGBBFFMAB(int JOGPNPCPHGL, int HPCMALBOGEL, bool IEIAHKGMIHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61F4260", Offset = "0x61F3460", VA = "0x1861F4260")]
		public static ViewId GOFIODGEAFC(int JOGPNPCPHGL, int HPCMALBOGEL, bool IEIAHKGMIHA)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
		public static ViewId GOFIODGEAFC(int FGIDKAOFKHP)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61F4060", Offset = "0x61F3260", VA = "0x1861F4060")]
		public static bool AIPCENMEJFE(ViewId EBKLEGBLPGD, ViewId JCPNHMOLDGI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61F4340", Offset = "0x61F3540", VA = "0x1861F4340")]
		public static bool KEIKIALHENC(ViewId EBKLEGBLPGD, ViewId JCPNHMOLDGI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61F40B0", Offset = "0x61F32B0", VA = "0x1861F40B0")]
		public static bool AIPCENMEJFE(int EBKLEGBLPGD, ViewId JCPNHMOLDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61F4100", Offset = "0x61F3300", VA = "0x1861F4100", Slot = "4")]
		public bool Equals(ViewId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61F4190", Offset = "0x61F3390", VA = "0x1861F4190", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61F42F0", Offset = "0x61F34F0", VA = "0x1861F42F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PGMEMBEONAP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int LADLGEFKGHO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int KGPNLICBONP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int OKPILNNEDKP;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x61F3D80", Offset = "0x61F2F80", VA = "0x1861F3D80")]
	public static void MCFMGJCIFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61F3CA0", Offset = "0x61F2EA0", VA = "0x1861F3CA0")]
	public static void HIBDKOOFOCB(int[] KFOHBHKPMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61F3DD0", Offset = "0x61F2FD0", VA = "0x1861F3DD0")]
	public static int MPOABFJFGFO(int NOBPKELKNDD, Func<int, bool> KMNNLBDKDFE, bool IEIAHKGMIHA = true)
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
