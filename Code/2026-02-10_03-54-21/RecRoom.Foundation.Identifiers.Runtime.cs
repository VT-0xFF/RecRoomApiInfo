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
		public Type XQKODTBENGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x844C7A0", Offset = "0x844B9A0", VA = "0x18844C7A0")]
			get
			{
				return default(Type);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GJSHBEEUYUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x844C020", Offset = "0x844B220", VA = "0x18844C020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DODZZJKHKPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x844C2C0", Offset = "0x844B4C0", VA = "0x18844C2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IFSAXHDOAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x844BA80", Offset = "0x844AC80", VA = "0x18844BA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NBWNPFYDVCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x844C5E0", Offset = "0x844B7E0", VA = "0x18844C5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PlayerId JETLGNSYWAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x844BAE0", Offset = "0x844ACE0", VA = "0x18844BAE0")]
			get
			{
				return default(PlayerId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ushort DKBPPVDRAMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x844C640", Offset = "0x844B840", VA = "0x18844C640")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ushort JTSALELDMTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x300BEF0", Offset = "0x300B0F0", VA = "0x18300BEF0")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x30058E0", Offset = "0x3004AE0", VA = "0x1830058E0")]
		private NetworkCreatorId(ushort value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x844C550", Offset = "0x844B750", VA = "0x18844C550")]
		public static NetworkCreatorId Player(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844BB90", Offset = "0x844AD90", VA = "0x18844BB90")]
		public static NetworkCreatorId Creation(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x844C6B0", Offset = "0x844B8B0", VA = "0x18844C6B0")]
		public static NetworkCreatorId Scene(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x844BD60", Offset = "0x844AF60", VA = "0x18844BD60")]
		public static NetworkCreatorId GHWYTGNXXCC(int a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x844BCB0", Offset = "0x844AEB0", VA = "0x18844BCB0")]
		public static NetworkCreatorId From(PlayerId playerId)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x844BD00", Offset = "0x844AF00", VA = "0x18844BD00")]
		public static NetworkCreatorId From(Type type, int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x844C780", Offset = "0x844B980", VA = "0x18844C780")]
		private static NetworkCreatorId VKZFOAJKQRG(Type a, int b)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x33719F0", Offset = "0x3370BF0", VA = "0x1833719F0")]
		public static NetworkCreatorId NHFORWJBGBZ(ushort a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x844C730", Offset = "0x844B930", VA = "0x18844C730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x844C080", Offset = "0x844B280", VA = "0x18844C080")]
		public string LYIPEQGQUQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x844C310", Offset = "0x844B510", VA = "0x18844C310")]
		public string OZNAIVZSDYR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74DB620", Offset = "0x74DA820", VA = "0x1874DB620", Slot = "4")]
		public bool Equals(NetworkCreatorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x844BC10", Offset = "0x844AE10", VA = "0x18844BC10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x300BEF0", Offset = "0x300B0F0", VA = "0x18300BEF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x844C5D0", Offset = "0x844B7D0", VA = "0x18844C5D0")]
		public static bool QEDRWBLLCYQ(NetworkCreatorId a, NetworkCreatorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x844C650", Offset = "0x844B850", VA = "0x18844C650")]
		public ObjectNetworkId SWRKKTCZNNS(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x844BDE0", Offset = "0x844AFE0", VA = "0x18844BDE0")]
		public static bool GISBXSBZRGJ(ReadOnlySpan<char> a, [Out] NetworkCreatorId b)
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
		public static ObjectNetworkId VABACYANPSH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NetworkCreatorId GTJOKOYRNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x844D170", Offset = "0x844C370", VA = "0x18844D170")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ushort MTNHZYZGQAS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x844D000", Offset = "0x844C200", VA = "0x18844D000")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int DKBPPVDRAMY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x844CEF0", Offset = "0x844C0F0", VA = "0x18844CEF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public uint JTSALELDMTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x53EA700", Offset = "0x53E9900", VA = "0x1853EA700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GJSHBEEUYUU
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x844CBE0", Offset = "0x844BDE0", VA = "0x18844CBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DODZZJKHKPT
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x844CCA0", Offset = "0x844BEA0", VA = "0x18844CCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DC20", Offset = "0x1A8CE20", VA = "0x181A8DC20")]
		public static ObjectNetworkId NHFORWJBGBZ(uint a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DC20", Offset = "0x1A8CE20", VA = "0x181A8DC20")]
		public static ObjectNetworkId NHFORWJBGBZ(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x844C8B0", Offset = "0x844BAB0", VA = "0x18844C8B0")]
		public static ObjectNetworkId From(NetworkCreatorId creatorId, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x844CE50", Offset = "0x844C050", VA = "0x18844CE50")]
		public static ObjectNetworkId Player(int playerIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x844CF00", Offset = "0x844C100", VA = "0x18844CF00")]
		public static ObjectNetworkId Scene(int sceneIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
		private ObjectNetworkId(uint rawValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		[BurstDiscard]
		private static void OFSDEGHQMAT(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x844D0F0", Offset = "0x844C2F0", VA = "0x18844D0F0")]
		public void WKVVACUCCMA([Out] NetworkCreatorId a, [Out] int b)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2106F40", Offset = "0x2106140", VA = "0x182106F40")]
		public static bool QEDRWBLLCYQ(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7864DE0", Offset = "0x7863FE0", VA = "0x187864DE0")]
		public static bool EPOGIYJSRBR(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2106F20", Offset = "0x2106120", VA = "0x182106F20", Slot = "5")]
		public bool Equals(ObjectNetworkId id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x844C830", Offset = "0x844BA30", VA = "0x18844C830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x13ACD60", Offset = "0x13ABF60", VA = "0x1813ACD60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x844D010", Offset = "0x844C210", VA = "0x18844D010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x844CD60", Offset = "0x844BF60", VA = "0x18844CD60")]
		public string OZNAIVZSDYR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x844C820", Offset = "0x844BA20", VA = "0x18844C820", Slot = "4")]
		public int CompareTo(ObjectNetworkId other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x844C810", Offset = "0x844BA10", VA = "0x18844C810")]
		public static bool AGEGYUJAAEC(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x844C910", Offset = "0x844BB10", VA = "0x18844C910")]
		public static bool GISBXSBZRGJ(ReadOnlySpan<char> a, [Out] ObjectNetworkId b)
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
		[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
		public PlayerId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2106F20", Offset = "0x2106120", VA = "0x182106F20", Slot = "4")]
		public bool Equals(PlayerId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x844D340", Offset = "0x844C540", VA = "0x18844D340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DC20", Offset = "0x1A8CE20", VA = "0x181A8DC20")]
		public static implicit operator PlayerId(int id)
		{
			return default(PlayerId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2106F40", Offset = "0x2106140", VA = "0x182106F40")]
		public static bool QEDRWBLLCYQ(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7864DE0", Offset = "0x7863FE0", VA = "0x187864DE0")]
		public static bool EPOGIYJSRBR(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x21175F0", Offset = "0x21167F0", VA = "0x1821175F0", Slot = "3")]
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
		public static bool GLFCQTDQNSD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x844D6A0", Offset = "0x844C8A0", VA = "0x18844D6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ViewId VABACYANPSH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x844D9D0", Offset = "0x844CBD0", VA = "0x18844D9D0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly int EHWXSRPQTJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public readonly int LJOWMEPFRVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x844D990", Offset = "0x844CB90", VA = "0x18844D990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public readonly int NDBTCLMJJGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x844DA00", Offset = "0x844CC00", VA = "0x18844DA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int VKDDVDWLLDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x844D620", Offset = "0x844C820", VA = "0x18844D620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OVRMXTCAWNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x844D7D0", Offset = "0x844C9D0", VA = "0x18844D7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool GJSHBEEUYUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x844D830", Offset = "0x844CA30", VA = "0x18844D830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool ZBSBOJICOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x844D600", Offset = "0x844C800", VA = "0x18844D600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool QQVLNIHXCXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x844D610", Offset = "0x844C810", VA = "0x18844D610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x844DB30", Offset = "0x844CD30", VA = "0x18844DB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x844D550", Offset = "0x844C750", VA = "0x18844D550")]
		private static int BXIJGWJWWXP(int a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x844D550", Offset = "0x844C750", VA = "0x18844D550")]
		public static ViewId From(int actor, int subId, bool destroyOnLeave)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DC20", Offset = "0x1A8CE20", VA = "0x181A8DC20")]
		public static ViewId From(int viewId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DC20", Offset = "0x1A8CE20", VA = "0x181A8DC20")]
		public static ViewId From(ObjectNetworkId networkId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x844D920", Offset = "0x844CB20", VA = "0x18844D920")]
		private static void MWFUSCWJDXL()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2106F40", Offset = "0x2106140", VA = "0x182106F40")]
		public static bool QEDRWBLLCYQ(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7864DE0", Offset = "0x7863FE0", VA = "0x187864DE0")]
		public static bool EPOGIYJSRBR(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2106F40", Offset = "0x2106140", VA = "0x182106F40")]
		public static bool QEDRWBLLCYQ(ViewId a, int b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x844D9F0", Offset = "0x844CBF0", VA = "0x18844D9F0")]
		public static bool QEDRWBLLCYQ(int a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2106F20", Offset = "0x2106120", VA = "0x182106F20", Slot = "4")]
		public bool Equals(ViewId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x844D750", Offset = "0x844C950", VA = "0x18844D750", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x844DAC0", Offset = "0x844CCC0", VA = "0x18844DAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x844D820", Offset = "0x844CA20", VA = "0x18844D820")]
		public readonly ObjectNetworkId IZYFUWSOBBX()
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HYCISNLRLNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1A8DC20", Offset = "0x1A8CE20", VA = "0x181A8DC20")]
		public static ViewId PACNAQMZLZH(this ObjectNetworkId a)
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
	public static class XMEYMMSUQQY
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal readonly struct Ownership
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int accessToken;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public bool ZBZTRPWMGAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x844D1C0", Offset = "0x844C3C0", VA = "0x18844D1C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public RoomVersionType OZSVPNIKROE
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x844D220", Offset = "0x844C420", VA = "0x18844D220")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
			public Ownership(int accessToken)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static int RANDJUCNMPV;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RoomVersionType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x844DD60", Offset = "0x844CF60", VA = "0x18844DD60")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x844DE40", Offset = "0x844D040", VA = "0x18844DE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static byte VTVWVKSYALI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x844DDB0", Offset = "0x844CFB0", VA = "0x18844DDB0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static bool GLKJNZXNXDM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x844DB70", Offset = "0x844CD70", VA = "0x18844DB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static bool GLFCQTDQNSD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x844DBF0", Offset = "0x844CDF0", VA = "0x18844DBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x844DCC0", Offset = "0x844CEC0", VA = "0x18844DCC0")]
		static XMEYMMSUQQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x844DC70", Offset = "0x844CE70", VA = "0x18844DC70")]
		internal static Ownership PDZUVWGTHKY()
		{
			return default(Ownership);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x844DCC0", Offset = "0x844CEC0", VA = "0x18844DCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EAD5C0", Offset = "0x1EAC7C0", VA = "0x181EAD5C0")]
		public UgcVersionInfo(RoomVersionType roomVersion, int ugcSubVersion, int persistenceVersion, int omVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x844D480", Offset = "0x844C680", VA = "0x18844D480")]
		public static UgcVersionInfo KTMDAQFYKGM(byte a, int b, int c)
		{
			return default(UgcVersionInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x844D3C0", Offset = "0x844C5C0", VA = "0x18844D3C0")]
		public static UgcVersionInfo KTMDAQFYKGM(RoomVersionType a, int b, int c)
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
