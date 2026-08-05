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
		public Type FSREBLLROWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x853F010", Offset = "0x853DE10", VA = "0x18853F010")]
			get
			{
				return default(Type);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool UFZIIDMVYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x853FA60", Offset = "0x853E860", VA = "0x18853FA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GWINWRLBNYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x853F5F0", Offset = "0x853E3F0", VA = "0x18853F5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ZPZZHFMLYYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x853F020", Offset = "0x853DE20", VA = "0x18853F020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GVGLHLOMPDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x853F9E0", Offset = "0x853E7E0", VA = "0x18853F9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PlayerId FRPACOAERPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x853FAC0", Offset = "0x853E8C0", VA = "0x18853FAC0")]
			get
			{
				return default(PlayerId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ushort BFTLLAUIUZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x853EE30", Offset = "0x853DC30", VA = "0x18853EE30")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ushort TZRJPQOZDBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x304CA60", Offset = "0x304B860", VA = "0x18304CA60")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3046700", Offset = "0x3045500", VA = "0x183046700")]
		private NetworkCreatorId(ushort value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x853F320", Offset = "0x853E120", VA = "0x18853F320")]
		public static NetworkCreatorId Player(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x853EE40", Offset = "0x853DC40", VA = "0x18853EE40")]
		public static NetworkCreatorId Creation(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x853F890", Offset = "0x853E690", VA = "0x18853F890")]
		public static NetworkCreatorId Scene(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x853F960", Offset = "0x853E760", VA = "0x18853F960")]
		public static NetworkCreatorId UGNMQRMLERE(int a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x853EF60", Offset = "0x853DD60", VA = "0x18853EF60")]
		public static NetworkCreatorId From(PlayerId playerId)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x853EFB0", Offset = "0x853DDB0", VA = "0x18853EFB0")]
		public static NetworkCreatorId From(Type type, int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x853FA40", Offset = "0x853E840", VA = "0x18853FA40")]
		private static NetworkCreatorId VLMXZSDOIDG(Type a, int b)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x33AB7A0", Offset = "0x33AA5A0", VA = "0x1833AB7A0")]
		public static NetworkCreatorId OEHMNYDYBUT(ushort a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x853F910", Offset = "0x853E710", VA = "0x18853F910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x853F080", Offset = "0x853DE80", VA = "0x18853F080")]
		public string KCFPATZCUKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x853F3B0", Offset = "0x853E1B0", VA = "0x18853F3B0")]
		public string QSHDUOCUSSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75B4740", Offset = "0x75B3540", VA = "0x1875B4740", Slot = "4")]
		public bool Equals(NetworkCreatorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x853EEC0", Offset = "0x853DCC0", VA = "0x18853EEC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x304CA60", Offset = "0x304B860", VA = "0x18304CA60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x853F3A0", Offset = "0x853E1A0", VA = "0x18853F3A0")]
		public static bool QIDDWXQJPGU(NetworkCreatorId a, NetworkCreatorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x853F2C0", Offset = "0x853E0C0", VA = "0x18853F2C0")]
		public ObjectNetworkId MXRTIIWOOCY(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x853F640", Offset = "0x853E440", VA = "0x18853F640")]
		public static bool RQHAAYIFBOV(ReadOnlySpan<char> a, [Out] NetworkCreatorId b)
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
		public static ObjectNetworkId YUAEVMMBLMX
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NetworkCreatorId YTGEDXWLITP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x853FFB0", Offset = "0x853EDB0", VA = "0x18853FFB0")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ushort CMXNSVHKJXE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8540570", Offset = "0x853F370", VA = "0x188540570")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int BFTLLAUIUZK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x853FBD0", Offset = "0x853E9D0", VA = "0x18853FBD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public uint TZRJPQOZDBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x54925A0", Offset = "0x54913A0", VA = "0x1854925A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool UFZIIDMVYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85404B0", Offset = "0x853F2B0", VA = "0x1885404B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GWINWRLBNYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x853FEF0", Offset = "0x853ECF0", VA = "0x18853FEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A97A20", Offset = "0x1A96820", VA = "0x181A97A20")]
		public static ObjectNetworkId OEHMNYDYBUT(uint a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1A97A20", Offset = "0x1A96820", VA = "0x181A97A20")]
		public static ObjectNetworkId OEHMNYDYBUT(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x853FC70", Offset = "0x853EA70", VA = "0x18853FC70")]
		public static ObjectNetworkId From(NetworkCreatorId creatorId, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x853FCE0", Offset = "0x853EAE0", VA = "0x18853FCE0")]
		public static ObjectNetworkId Player(int playerIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85402D0", Offset = "0x853F0D0", VA = "0x1885402D0")]
		public static ObjectNetworkId Scene(int sceneIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
		private ObjectNetworkId(uint rawValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		[BurstDiscard]
		private static void MOLHIQDDAQP(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x853FE70", Offset = "0x853EC70", VA = "0x18853FE70")]
		public void RBUETEQJKHW([Out] NetworkCreatorId a, [Out] int b)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2150770", Offset = "0x214F570", VA = "0x182150770")]
		public static bool QIDDWXQJPGU(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x79418F0", Offset = "0x79406F0", VA = "0x1879418F0")]
		public static bool OLTCZZLLQGX(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2150750", Offset = "0x214F550", VA = "0x182150750", Slot = "5")]
		public bool Equals(ObjectNetworkId id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x853FBF0", Offset = "0x853E9F0", VA = "0x18853FBF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x13EB530", Offset = "0x13EA330", VA = "0x1813EB530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85403D0", Offset = "0x853F1D0", VA = "0x1885403D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x853FD80", Offset = "0x853EB80", VA = "0x18853FD80")]
		public string QSHDUOCUSSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x853FBE0", Offset = "0x853E9E0", VA = "0x18853FBE0", Slot = "4")]
		public int CompareTo(ObjectNetworkId other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x853FCD0", Offset = "0x853EAD0", VA = "0x18853FCD0")]
		public static bool OOMDBQNZSHI(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8540000", Offset = "0x853EE00", VA = "0x188540000")]
		public static bool RQHAAYIFBOV(ReadOnlySpan<char> a, [Out] ObjectNetworkId b)
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
		[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
		public PlayerId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2150750", Offset = "0x214F550", VA = "0x182150750", Slot = "4")]
		public bool Equals(PlayerId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8540700", Offset = "0x853F500", VA = "0x188540700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A97A20", Offset = "0x1A96820", VA = "0x181A97A20")]
		public static implicit operator PlayerId(int id)
		{
			return default(PlayerId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2150770", Offset = "0x214F570", VA = "0x182150770")]
		public static bool QIDDWXQJPGU(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79418F0", Offset = "0x79406F0", VA = "0x1879418F0")]
		public static bool OLTCZZLLQGX(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x215AD00", Offset = "0x2159B00", VA = "0x18215AD00", Slot = "3")]
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
		public static bool SYUMHKZGTMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8540E50", Offset = "0x853FC50", VA = "0x188540E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ViewId YUAEVMMBLMX
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x85410B0", Offset = "0x853FEB0", VA = "0x1885410B0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly int FWLEJAVOAYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public readonly int XOMDSZBMZVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8540F90", Offset = "0x853FD90", VA = "0x188540F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public readonly int GMAIZQDIIWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8540D00", Offset = "0x853FB00", VA = "0x188540D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int YDIKTQZEULZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8540F10", Offset = "0x853FD10", VA = "0x188540F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RJYPVPFFGPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8541050", Offset = "0x853FE50", VA = "0x188541050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UFZIIDMVYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8541180", Offset = "0x853FF80", VA = "0x188541180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool DBRGKTFDEZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8541270", Offset = "0x8540070", VA = "0x188541270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool XNPFJVBLJRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85410A0", Offset = "0x853FEA0", VA = "0x1885410A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85410D0", Offset = "0x853FED0", VA = "0x1885410D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8540C50", Offset = "0x853FA50", VA = "0x188540C50")]
		private static int AWEIVINKWTT(int a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8540C50", Offset = "0x853FA50", VA = "0x188540C50")]
		public static ViewId From(int actor, int subId, bool destroyOnLeave)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A97A20", Offset = "0x1A96820", VA = "0x181A97A20")]
		public static ViewId From(int viewId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1A97A20", Offset = "0x1A96820", VA = "0x181A97A20")]
		public static ViewId From(ObjectNetworkId networkId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8540FD0", Offset = "0x853FDD0", VA = "0x188540FD0")]
		private static void NIOMTNQDTCZ()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2150770", Offset = "0x214F570", VA = "0x182150770")]
		public static bool QIDDWXQJPGU(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79418F0", Offset = "0x79406F0", VA = "0x1879418F0")]
		public static bool OLTCZZLLQGX(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2150770", Offset = "0x214F570", VA = "0x182150770")]
		public static bool QIDDWXQJPGU(ViewId a, int b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8541040", Offset = "0x853FE40", VA = "0x188541040")]
		public static bool QIDDWXQJPGU(int a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2150750", Offset = "0x214F550", VA = "0x182150750", Slot = "4")]
		public bool Equals(ViewId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8540DC0", Offset = "0x853FBC0", VA = "0x188540DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8541110", Offset = "0x853FF10", VA = "0x188541110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8540E40", Offset = "0x853FC40", VA = "0x188540E40")]
		public readonly ObjectNetworkId HEKKDGIOOPD()
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PJLNYXYJTLU
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1A97A20", Offset = "0x1A96820", VA = "0x181A97A20")]
		public static ViewId IPRQQRFUAQB(this ObjectNetworkId a)
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
	public static class UFFFAZMTWLO
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal readonly struct Ownership
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int accessToken;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public bool VBAZCWWHFOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x85406A0", Offset = "0x853F4A0", VA = "0x1885406A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public RoomVersionType ULTKTFGCAFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x8540580", Offset = "0x853F380", VA = "0x188540580")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
			public Ownership(int accessToken)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static int SNZBAWTFSAP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RoomVersionType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85408E0", Offset = "0x853F6E0", VA = "0x1885408E0")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8540780", Offset = "0x853F580", VA = "0x188540780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static byte QGKUFZWHNLI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8540A30", Offset = "0x853F830", VA = "0x188540A30")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static bool SYZTERTECXM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85407E0", Offset = "0x853F5E0", VA = "0x1885407E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static bool SYUMHKZGTMD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8540860", Offset = "0x853F660", VA = "0x188540860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8540930", Offset = "0x853F730", VA = "0x188540930")]
		static UFFFAZMTWLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85409D0", Offset = "0x853F7D0", VA = "0x1885409D0")]
		internal static Ownership SHLDMRFGWQM()
		{
			return default(Ownership);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8540930", Offset = "0x853F730", VA = "0x188540930")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EF4F30", Offset = "0x1EF3D30", VA = "0x181EF4F30")]
		public UgcVersionInfo(RoomVersionType roomVersion, int ugcSubVersion, int persistenceVersion, int omVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8540AC0", Offset = "0x853F8C0", VA = "0x188540AC0")]
		public static UgcVersionInfo GRZIDZKMIJS(byte a, int b, int c)
		{
			return default(UgcVersionInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8540B90", Offset = "0x853F990", VA = "0x188540B90")]
		public static UgcVersionInfo GRZIDZKMIJS(RoomVersionType a, int b, int c)
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
