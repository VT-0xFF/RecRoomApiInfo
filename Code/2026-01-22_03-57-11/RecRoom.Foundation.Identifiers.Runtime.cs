using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public readonly struct NetworkCreatorId : IEquatable<NetworkCreatorId>
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum Type
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			Player,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			Creation,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Scene,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Transient
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly NetworkCreatorId BlackHole;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly NetworkCreatorId Streaming;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly NetworkCreatorId UnityScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly ushort value;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type RIQESJLSHGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x831A060", Offset = "0x8318860", VA = "0x18831A060")]
			get
			{
				return default(Type);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DRXQCFVLBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x831A500", Offset = "0x8318D00", VA = "0x18831A500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GEBPYPICSTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8319F90", Offset = "0x8318790", VA = "0x188319F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool YKZIPARIVMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x831A480", Offset = "0x8318C80", VA = "0x18831A480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool QCXZQYCNEAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x831AC60", Offset = "0x8319460", VA = "0x18831AC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PlayerId VCFCDWQADOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x831A560", Offset = "0x8318D60", VA = "0x18831A560")]
			get
			{
				return default(PlayerId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ushort TTXNZPFFZFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x831A610", Offset = "0x8318E10", VA = "0x18831A610")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ushort QHKQMTDZANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2FEBB00", Offset = "0x2FEA300", VA = "0x182FEBB00")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2FE55F0", Offset = "0x2FE3DF0", VA = "0x182FE55F0")]
		private NetworkCreatorId(ushort value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x831A620", Offset = "0x8318E20", VA = "0x18831A620")]
		public static NetworkCreatorId Player(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8319FE0", Offset = "0x83187E0", VA = "0x188319FE0")]
		public static NetworkCreatorId Creation(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x831A8F0", Offset = "0x83190F0", VA = "0x18831A8F0")]
		public static NetworkCreatorId Scene(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x831A110", Offset = "0x8318910", VA = "0x18831A110")]
		public static NetworkCreatorId FHXOWDARQJF(int a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x831A190", Offset = "0x8318990", VA = "0x18831A190")]
		public static NetworkCreatorId From(PlayerId playerId)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x831A1E0", Offset = "0x83189E0", VA = "0x18831A1E0")]
		public static NetworkCreatorId From(Type type, int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x831A4E0", Offset = "0x8318CE0", VA = "0x18831A4E0")]
		private static NetworkCreatorId KKRLZLFSALT(Type a, int b)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x33455E0", Offset = "0x3343DE0", VA = "0x1833455E0")]
		public static NetworkCreatorId YIOQIPHTVNO(ushort a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x831A970", Offset = "0x8319170", VA = "0x18831A970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x831A6B0", Offset = "0x8318EB0", VA = "0x18831A6B0")]
		public string STKYZUMHVKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x831A240", Offset = "0x8318A40", VA = "0x18831A240")]
		public string IDVFBIBYJZS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x73C4200", Offset = "0x73C2A00", VA = "0x1873C4200", Slot = "4")]
		public bool Equals(NetworkCreatorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x831A070", Offset = "0x8318870", VA = "0x18831A070", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBB00", Offset = "0x2FEA300", VA = "0x182FEBB00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x831A6A0", Offset = "0x8318EA0", VA = "0x18831A6A0")]
		public static bool SSVDESVOTBX(NetworkCreatorId a, NetworkCreatorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x831AC00", Offset = "0x8319400", VA = "0x18831AC00")]
		public ObjectNetworkId WXSMIGFCZXP(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x831A9C0", Offset = "0x83191C0", VA = "0x18831A9C0")]
		public static bool UFFJVOTLPZW(ReadOnlySpan<char> a, [Out] NetworkCreatorId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct ObjectNetworkId : IComparable<ObjectNetworkId>, IEquatable<ObjectNetworkId>
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const int IndexBits = 20;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const int IndexMask = 1048575;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public const int MaxIndex = 1048575;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const int MinIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly uint value;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static ObjectNetworkId YFNNNZJJVGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NetworkCreatorId KGRUHMWEWEU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x831AF70", Offset = "0x8319770", VA = "0x18831AF70")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ushort PZEMKBZJPIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x831B6D0", Offset = "0x8319ED0", VA = "0x18831B6D0")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int TTXNZPFFZFD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x831B170", Offset = "0x8319970", VA = "0x18831B170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public uint QHKQMTDZANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x534EF20", Offset = "0x534D720", VA = "0x18534EF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DRXQCFVLBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x831B0B0", Offset = "0x83198B0", VA = "0x18831B0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GEBPYPICSTI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x831AD20", Offset = "0x8319520", VA = "0x18831AD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2E50", Offset = "0x1AA1650", VA = "0x181AA2E50")]
		public static ObjectNetworkId YIOQIPHTVNO(uint a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2E50", Offset = "0x1AA1650", VA = "0x181AA2E50")]
		public static ObjectNetworkId YIOQIPHTVNO(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x831AF10", Offset = "0x8319710", VA = "0x18831AF10")]
		public static ObjectNetworkId From(NetworkCreatorId creatorId, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x831B180", Offset = "0x8319980", VA = "0x18831B180")]
		public static ObjectNetworkId Player(int playerIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x831B220", Offset = "0x8319A20", VA = "0x18831B220")]
		public static ObjectNetworkId Scene(int sceneIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
		private ObjectNetworkId(uint rawValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		[BurstDiscard]
		private static void OVNHVZLIRPM(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x831ADE0", Offset = "0x83195E0", VA = "0x18831ADE0")]
		public void BYKHRBFUYXH([Out] NetworkCreatorId a, [Out] int b)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x20BC940", Offset = "0x20BB140", VA = "0x1820BC940")]
		public static bool SSVDESVOTBX(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x774E510", Offset = "0x774CD10", VA = "0x18774E510")]
		public static bool XUHFAYKFXBY(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x20BC920", Offset = "0x20BB120", VA = "0x1820BC920", Slot = "5")]
		public bool Equals(ObjectNetworkId id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x831AE80", Offset = "0x8319680", VA = "0x18831AE80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1360550", Offset = "0x135ED50", VA = "0x181360550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x831B320", Offset = "0x8319B20", VA = "0x18831B320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x831AFC0", Offset = "0x83197C0", VA = "0x18831AFC0")]
		public string IDVFBIBYJZS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x831AE70", Offset = "0x8319670", VA = "0x18831AE70", Slot = "4")]
		public int CompareTo(ObjectNetworkId other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x831AE60", Offset = "0x8319660", VA = "0x18831AE60")]
		public static bool CITKWABRQUP(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x831B400", Offset = "0x8319C00", VA = "0x18831B400")]
		public static bool UFFJVOTLPZW(ReadOnlySpan<char> a, [Out] ObjectNetworkId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PlayerId : IEquatable<PlayerId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly int Id;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
		public PlayerId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x20BC920", Offset = "0x20BB120", VA = "0x1820BC920", Slot = "4")]
		public bool Equals(PlayerId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x831B860", Offset = "0x831A060", VA = "0x18831B860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2E50", Offset = "0x1AA1650", VA = "0x181AA2E50")]
		public static implicit operator PlayerId(int id)
		{
			return default(PlayerId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x20BC940", Offset = "0x20BB140", VA = "0x1820BC940")]
		public static bool SSVDESVOTBX(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x774E510", Offset = "0x774CD10", VA = "0x18774E510")]
		public static bool XUHFAYKFXBY(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x20C9E80", Offset = "0x20C8680", VA = "0x1820C9E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct ViewId : IEquatable<ViewId>
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public const int MAX_VIEW_IDS = 100000;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int MAX_PLAYER_IDS = 10000;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int MAX_VIEW_SUB_IDS = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int DONT_DESTROY_ON_LEAVE_FLAG = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public const int RUNTIME_INSTANTIATE_VIEW_ID_OFFSET = 90000;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public const int COMPILE_TIME_MAIN_ROOT_ID_OFFSET = 89000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private int id;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool JYSPWTIGESE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x831BF60", Offset = "0x831A760", VA = "0x18831BF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ViewId YFNNNZJJVGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x831C080", Offset = "0x831A880", VA = "0x18831C080")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly int BAAUPMTAFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public readonly int PBPOITYSXQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x831BC90", Offset = "0x831A490", VA = "0x18831BC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public readonly int XUKWTZFUNUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x831BB10", Offset = "0x831A310", VA = "0x18831BB10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int DJLIDUJISPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x831BED0", Offset = "0x831A6D0", VA = "0x18831BED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool SQICCLWFQFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x831BE10", Offset = "0x831A610", VA = "0x18831BE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool DRXQCFVLBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x831BCD0", Offset = "0x831A4D0", VA = "0x18831BCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool HEGXRXOYVZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x831BE00", Offset = "0x831A600", VA = "0x18831BE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool DJWZBMRPIUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x831C0A0", Offset = "0x831A8A0", VA = "0x18831C0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x831BDC0", Offset = "0x831A5C0", VA = "0x18831BDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x831BBD0", Offset = "0x831A3D0", VA = "0x18831BBD0")]
		private static int JNJDWCGPYSS(int a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x831BBD0", Offset = "0x831A3D0", VA = "0x18831BBD0")]
		public static ViewId From(int actor, int subId, bool destroyOnLeave)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2E50", Offset = "0x1AA1650", VA = "0x181AA2E50")]
		public static ViewId From(int viewId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2E50", Offset = "0x1AA1650", VA = "0x181AA2E50")]
		public static ViewId From(ObjectNetworkId networkId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x831BE60", Offset = "0x831A660", VA = "0x18831BE60")]
		private static void RZWIVOSPSBG()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x20BC940", Offset = "0x20BB140", VA = "0x1820BC940")]
		public static bool SSVDESVOTBX(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x774E510", Offset = "0x774CD10", VA = "0x18774E510")]
		public static bool XUHFAYKFXBY(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x20BC940", Offset = "0x20BB140", VA = "0x1820BC940")]
		public static bool SSVDESVOTBX(ViewId a, int b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x831BF50", Offset = "0x831A750", VA = "0x18831BF50")]
		public static bool SSVDESVOTBX(int a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x20BC920", Offset = "0x20BB120", VA = "0x1820BC920", Slot = "4")]
		public bool Equals(ViewId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x831BA80", Offset = "0x831A280", VA = "0x18831BA80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x831C010", Offset = "0x831A810", VA = "0x18831C010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x831BC80", Offset = "0x831A480", VA = "0x18831BC80")]
		public readonly ObjectNetworkId ICAYTFJSLZK()
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class DIZTCWJCLSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2E50", Offset = "0x1AA1650", VA = "0x181AA2E50")]
		public static ViewId AOMFQQESEDM(this ObjectNetworkId a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum RoomVersionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		RoomV1,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		RoomV2
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GRISNGMRULJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal readonly struct Ownership
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int accessToken;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public bool BYMJZGOHVQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x831B6E0", Offset = "0x8319EE0", VA = "0x18831B6E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public RoomVersionType QWAVKIDXYXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x831B740", Offset = "0x8319F40", VA = "0x18831B740")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
			public Ownership(int accessToken)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static int HGFONTATCEO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RoomVersionType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8319C70", Offset = "0x8318470", VA = "0x188319C70")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8319D50", Offset = "0x8318550", VA = "0x188319D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static byte SWFRHUXVGOR
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8319CC0", Offset = "0x83184C0", VA = "0x188319CC0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static bool JZIKONPYHAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8319E40", Offset = "0x8318640", VA = "0x188319E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static bool JYSPWTIGESE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8319EC0", Offset = "0x83186C0", VA = "0x188319EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8319DA0", Offset = "0x83185A0", VA = "0x188319DA0")]
		static GRISNGMRULJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8319F40", Offset = "0x8318740", VA = "0x188319F40")]
		internal static Ownership XAVZVOJWZHL()
		{
			return default(Ownership);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8319DA0", Offset = "0x83185A0", VA = "0x188319DA0")]
		internal static void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct UgcVersionInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly RoomVersionType RoomVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly int UgcSubVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly int PersistenceVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly int OmVersion;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E63910", Offset = "0x1E62110", VA = "0x181E63910")]
		public UgcVersionInfo(RoomVersionType roomVersion, int ugcSubVersion, int persistenceVersion, int omVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x831B9B0", Offset = "0x831A1B0", VA = "0x18831B9B0")]
		public static UgcVersionInfo FPBRAOQVLGB(byte a, int b, int c)
		{
			return default(UgcVersionInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x831B8F0", Offset = "0x831A0F0", VA = "0x18831B8F0")]
		public static UgcVersionInfo FPBRAOQVLGB(RoomVersionType a, int b, int c)
		{
			return default(UgcVersionInfo);
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
