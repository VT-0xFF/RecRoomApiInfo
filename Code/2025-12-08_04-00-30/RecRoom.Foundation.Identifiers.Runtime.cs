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
		public Type ATNWYJMHLZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x825EAF0", Offset = "0x825D2F0", VA = "0x18825EAF0")]
			get
			{
				return default(Type);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EHRTJXMBPLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x825EEE0", Offset = "0x825D6E0", VA = "0x18825EEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ZPBFQIFTFQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x825EBB0", Offset = "0x825D3B0", VA = "0x18825EBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool YICDHBIZAVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x825E590", Offset = "0x825CD90", VA = "0x18825E590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EDOMJNFSZRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x825EA10", Offset = "0x825D210", VA = "0x18825EA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PlayerId NOSRWQMWFIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x825EB00", Offset = "0x825D300", VA = "0x18825EB00")]
			get
			{
				return default(PlayerId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ushort NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x825F250", Offset = "0x825DA50", VA = "0x18825F250")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ushort VBGIWZKGWUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2FBF8C0", Offset = "0x2FBE0C0", VA = "0x182FBF8C0")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9890", Offset = "0x2FB8090", VA = "0x182FB9890")]
		private NetworkCreatorId(ushort value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x825EC20", Offset = "0x825D420", VA = "0x18825EC20")]
		public static NetworkCreatorId Player(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x825E830", Offset = "0x825D030", VA = "0x18825E830")]
		public static NetworkCreatorId Creation(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x825EF40", Offset = "0x825D740", VA = "0x18825EF40")]
		public static NetworkCreatorId Scene(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x825EA70", Offset = "0x825D270", VA = "0x18825EA70")]
		public static NetworkCreatorId LENKOXCHWKL(int a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x825E960", Offset = "0x825D160", VA = "0x18825E960")]
		public static NetworkCreatorId From(PlayerId playerId)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x825E9B0", Offset = "0x825D1B0", VA = "0x18825E9B0")]
		public static NetworkCreatorId From(Type type, int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x825EC00", Offset = "0x825D400", VA = "0x18825EC00")]
		private static NetworkCreatorId PTGISUVIANX(Type a, int b)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x33098D0", Offset = "0x33080D0", VA = "0x1833098D0")]
		public static NetworkCreatorId TYRLFYNFIXG(ushort a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x825EFC0", Offset = "0x825D7C0", VA = "0x18825EFC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x825E5F0", Offset = "0x825CDF0", VA = "0x18825E5F0")]
		public string CKFLWUKGNDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x825F010", Offset = "0x825D810", VA = "0x18825F010")]
		public string WZPTZHQWKDS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7314C50", Offset = "0x7313450", VA = "0x187314C50", Slot = "4")]
		public bool Equals(NetworkCreatorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x825E8B0", Offset = "0x825D0B0", VA = "0x18825E8B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF8C0", Offset = "0x2FBE0C0", VA = "0x182FBF8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x825E950", Offset = "0x825D150", VA = "0x18825E950")]
		public static bool FYOQTCVQVIR(NetworkCreatorId a, NetworkCreatorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x825F260", Offset = "0x825DA60", VA = "0x18825F260")]
		public ObjectNetworkId ZLYWKWZJGTT(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x825ECA0", Offset = "0x825D4A0", VA = "0x18825ECA0")]
		public static bool QXQJQWOKHWE(ReadOnlySpan<char> a, [Out] NetworkCreatorId b)
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
		public static ObjectNetworkId XDYJXWOSOES
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NetworkCreatorId ZMISRPYJHRO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x825F320", Offset = "0x825DB20", VA = "0x18825F320")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ushort NVALYNTJASJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x825F5C0", Offset = "0x825DDC0", VA = "0x18825F5C0")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x825FCE0", Offset = "0x825E4E0", VA = "0x18825FCE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public uint VBGIWZKGWUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC9D050", Offset = "0xC9B850", VA = "0x180C9D050")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x532D0C0", Offset = "0x532B8C0", VA = "0x18532D0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool EHRTJXMBPLD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x825F940", Offset = "0x825E140", VA = "0x18825F940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZPBFQIFTFQK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x825F500", Offset = "0x825DD00", VA = "0x18825F500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A872B0", Offset = "0x1A85AB0", VA = "0x181A872B0")]
		public static ObjectNetworkId TYRLFYNFIXG(uint a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1A872B0", Offset = "0x1A85AB0", VA = "0x181A872B0")]
		public static ObjectNetworkId TYRLFYNFIXG(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x825F410", Offset = "0x825DC10", VA = "0x18825F410")]
		public static ObjectNetworkId From(NetworkCreatorId creatorId, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x825F5D0", Offset = "0x825DDD0", VA = "0x18825F5D0")]
		public static ObjectNetworkId Player(int playerIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x825FA00", Offset = "0x825E200", VA = "0x18825FA00")]
		public static ObjectNetworkId Scene(int sceneIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
		private ObjectNetworkId(uint rawValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		[BurstDiscard]
		private static void ZIDRMYTMEBU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x825F470", Offset = "0x825DC70", VA = "0x18825F470")]
		public void HMUPOGLQWOR([Out] NetworkCreatorId a, [Out] int b)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x20790A0", Offset = "0x20778A0", VA = "0x1820790A0")]
		public static bool FYOQTCVQVIR(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x825F4F0", Offset = "0x825DCF0", VA = "0x18825F4F0")]
		public static bool IDTAQAUODHM(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2079080", Offset = "0x2077880", VA = "0x182079080", Slot = "5")]
		public bool Equals(ObjectNetworkId id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x825F380", Offset = "0x825DB80", VA = "0x18825F380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1302FC0", Offset = "0x13017C0", VA = "0x181302FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x825FB00", Offset = "0x825E300", VA = "0x18825FB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x825FBF0", Offset = "0x825E3F0", VA = "0x18825FBF0")]
		public string WZPTZHQWKDS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x825F370", Offset = "0x825DB70", VA = "0x18825F370", Slot = "4")]
		public int CompareTo(ObjectNetworkId other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x825FBE0", Offset = "0x825E3E0", VA = "0x18825FBE0")]
		public static bool UGDBJXHICDR(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x825F670", Offset = "0x825DE70", VA = "0x18825F670")]
		public static bool QXQJQWOKHWE(ReadOnlySpan<char> a, [Out] ObjectNetworkId b)
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
		[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
		public PlayerId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2079080", Offset = "0x2077880", VA = "0x182079080", Slot = "4")]
		public bool Equals(PlayerId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x825FE70", Offset = "0x825E670", VA = "0x18825FE70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xC9D050", Offset = "0xC9B850", VA = "0x180C9D050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A872B0", Offset = "0x1A85AB0", VA = "0x181A872B0")]
		public static implicit operator PlayerId(int id)
		{
			return default(PlayerId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x20790A0", Offset = "0x20778A0", VA = "0x1820790A0")]
		public static bool FYOQTCVQVIR(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x825F4F0", Offset = "0x825DCF0", VA = "0x18825F4F0")]
		public static bool IDTAQAUODHM(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2080200", Offset = "0x207EA00", VA = "0x182080200", Slot = "3")]
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
		public static bool TPNNPEHLGEY
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8260150", Offset = "0x825E950", VA = "0x188260150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ViewId XDYJXWOSOES
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8260420", Offset = "0x825EC20", VA = "0x188260420")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly int TVQXWBDRZRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xC9D050", Offset = "0xC9B850", VA = "0x180C9D050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public readonly int FWJINSZHBUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8260680", Offset = "0x825EE80", VA = "0x188260680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public readonly int KYVEIWVMRBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8260090", Offset = "0x825E890", VA = "0x188260090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int PQWFSCBOFIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8260360", Offset = "0x825EB60", VA = "0x188260360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool QGQNYZJHQZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x82605C0", Offset = "0x825EDC0", VA = "0x1882605C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool EHRTJXMBPLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82604D0", Offset = "0x825ECD0", VA = "0x1882604D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool KEHKXGNMDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x82604C0", Offset = "0x825ECC0", VA = "0x1882604C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool IQDPFVEZMZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8260440", Offset = "0x825EC40", VA = "0x188260440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x82603E0", Offset = "0x825EBE0", VA = "0x1882603E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82602B0", Offset = "0x825EAB0", VA = "0x1882602B0")]
		private static int OPBYCDMJJUS(int a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82602B0", Offset = "0x825EAB0", VA = "0x1882602B0")]
		public static ViewId From(int actor, int subId, bool destroyOnLeave)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A872B0", Offset = "0x1A85AB0", VA = "0x181A872B0")]
		public static ViewId From(int viewId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1A872B0", Offset = "0x1A85AB0", VA = "0x181A872B0")]
		public static ViewId From(ObjectNetworkId networkId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8260450", Offset = "0x825EC50", VA = "0x188260450")]
		private static void OQALKEYYDLO()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x20790A0", Offset = "0x20778A0", VA = "0x1820790A0")]
		public static bool FYOQTCVQVIR(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x825F4F0", Offset = "0x825DCF0", VA = "0x18825F4F0")]
		public static bool IDTAQAUODHM(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x20790A0", Offset = "0x20778A0", VA = "0x1820790A0")]
		public static bool FYOQTCVQVIR(ViewId a, int b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82602A0", Offset = "0x825EAA0", VA = "0x1882602A0")]
		public static bool FYOQTCVQVIR(int a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2079080", Offset = "0x2077880", VA = "0x182079080", Slot = "4")]
		public bool Equals(ViewId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8260210", Offset = "0x825EA10", VA = "0x188260210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8260610", Offset = "0x825EE10", VA = "0x188260610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8260200", Offset = "0x825EA00", VA = "0x188260200")]
		public readonly ObjectNetworkId EPPMZOBGKGE()
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC9D050", Offset = "0xC9B850", VA = "0x180C9D050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class FDZQIAYWARD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1A872B0", Offset = "0x1A85AB0", VA = "0x181A872B0")]
		public static ViewId OCHTKKHWQBY(this ObjectNetworkId a)
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
	public static class WJVXGPYALBB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal readonly struct Ownership
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int accessToken;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public bool SLDJRBBOCJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x825FE10", Offset = "0x825E610", VA = "0x18825FE10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public RoomVersionType BFJYMHQJKIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x825FCF0", Offset = "0x825E4F0", VA = "0x18825FCF0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
			public Ownership(int accessToken)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static int PNTRHNBFECC;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RoomVersionType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8260750", Offset = "0x825EF50", VA = "0x188260750")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x82608A0", Offset = "0x825F0A0", VA = "0x1882608A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static byte NHSMWIJJDZH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x82606C0", Offset = "0x825EEC0", VA = "0x1882606C0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static bool TQDIGYPDIMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x82607A0", Offset = "0x825EFA0", VA = "0x1882607A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static bool TPNNPEHLGEY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8260820", Offset = "0x825F020", VA = "0x188260820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8260940", Offset = "0x825F140", VA = "0x188260940")]
		static WJVXGPYALBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82608F0", Offset = "0x825F0F0", VA = "0x1882608F0")]
		internal static Ownership LCHQJSVARHD()
		{
			return default(Ownership);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8260940", Offset = "0x825F140", VA = "0x188260940")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E1D4C0", Offset = "0x1E1BCC0", VA = "0x181E1D4C0")]
		public UgcVersionInfo(RoomVersionType roomVersion, int ugcSubVersion, int persistenceVersion, int omVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x825FF00", Offset = "0x825E700", VA = "0x18825FF00")]
		public static UgcVersionInfo XOIRBDEFJTP(byte a, int b, int c)
		{
			return default(UgcVersionInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x825FFD0", Offset = "0x825E7D0", VA = "0x18825FFD0")]
		public static UgcVersionInfo XOIRBDEFJTP(RoomVersionType a, int b, int c)
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
