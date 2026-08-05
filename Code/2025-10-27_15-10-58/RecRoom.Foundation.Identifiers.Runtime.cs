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
		public Type GQJEAHGNKZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x873A2B0", Offset = "0x87392B0", VA = "0x18873A2B0")]
			get
			{
				return default(Type);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NCRAWENJUOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8739C80", Offset = "0x8738C80", VA = "0x188739C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool OARFSRRKLVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x873A480", Offset = "0x8739480", VA = "0x18873A480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ELGOMDJOBPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x873A720", Offset = "0x8739720", VA = "0x18873A720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CMRHRGRASZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x873A250", Offset = "0x8739250", VA = "0x18873A250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KFZSONKEWRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x873A9C0", Offset = "0x87399C0", VA = "0x18873A9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PlayerId RPKHGJAMSGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x873A2F0", Offset = "0x87392F0", VA = "0x18873A2F0")]
			get
			{
				return default(PlayerId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ushort EYRVWTAEZEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x873A3A0", Offset = "0x87393A0", VA = "0x18873A3A0")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ushort IQOVGLKJYYK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3287E90", Offset = "0x3286E90", VA = "0x183287E90")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x327D090", Offset = "0x327C090", VA = "0x18327D090")]
		private NetworkCreatorId(ushort value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x873A1D0", Offset = "0x87391D0", VA = "0x18873A1D0")]
		public static NetworkCreatorId Player(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8739CE0", Offset = "0x8738CE0", VA = "0x188739CE0")]
		public static NetworkCreatorId Creation(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x873A3B0", Offset = "0x87393B0", VA = "0x18873A3B0")]
		public static NetworkCreatorId Scene(int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x873A150", Offset = "0x8739150", VA = "0x18873A150")]
		public static NetworkCreatorId MLFAZXBGTOR(int a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8739E00", Offset = "0x8738E00", VA = "0x188739E00")]
		public static NetworkCreatorId From(PlayerId playerId)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8739E50", Offset = "0x8738E50", VA = "0x188739E50")]
		public static NetworkCreatorId From(Type type, int index)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x873A2D0", Offset = "0x87392D0", VA = "0x18873A2D0")]
		private static NetworkCreatorId STZWLCJTTYL(Type a, int b)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x35EB600", Offset = "0x35EA600", VA = "0x1835EB600")]
		public static NetworkCreatorId AUCBJZTONJM(ushort a)
		{
			return default(NetworkCreatorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x873A430", Offset = "0x8739430", VA = "0x18873A430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x873A780", Offset = "0x8739780", VA = "0x18873A780")]
		public string ZFFPOBUSWFQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8739F10", Offset = "0x8738F10", VA = "0x188739F10")]
		public string MADVFOLUGMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7759EC0", Offset = "0x7758EC0", VA = "0x187759EC0", Slot = "4")]
		public bool Equals(NetworkCreatorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8739D60", Offset = "0x8738D60", VA = "0x188739D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3287E90", Offset = "0x3286E90", VA = "0x183287E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x873A2C0", Offset = "0x87392C0", VA = "0x18873A2C0")]
		public static bool RZMMTPOVALZ(NetworkCreatorId a, NetworkCreatorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8739EB0", Offset = "0x8738EB0", VA = "0x188739EB0")]
		public ObjectNetworkId KSYEXIFFTEP(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x873A4D0", Offset = "0x87394D0", VA = "0x18873A4D0")]
		public static bool YWGPCXPLADI(ReadOnlySpan<char> a, [Out] NetworkCreatorId b)
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

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static ObjectNetworkId XMYJAHCPVKU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkCreatorId QWQMRLYTLKW
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x873ACB0", Offset = "0x8739CB0", VA = "0x18873ACB0")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ushort YPSXVIALSPN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x873AC40", Offset = "0x8739C40", VA = "0x18873AC40")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EYRVWTAEZEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x873AEB0", Offset = "0x8739EB0", VA = "0x18873AEB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public uint IQOVGLKJYYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5616D90", Offset = "0x5615D90", VA = "0x185616D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NCRAWENJUOL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x873AAE0", Offset = "0x8739AE0", VA = "0x18873AAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OARFSRRKLVO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x873B0A0", Offset = "0x873A0A0", VA = "0x18873B0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static ObjectNetworkId AUCBJZTONJM(uint a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static ObjectNetworkId AUCBJZTONJM(int a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x873AC50", Offset = "0x8739C50", VA = "0x18873AC50")]
		public static ObjectNetworkId From(NetworkCreatorId creatorId, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x873AE10", Offset = "0x8739E10", VA = "0x18873AE10")]
		public static ObjectNetworkId Player(int playerIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x873AEC0", Offset = "0x8739EC0", VA = "0x18873AEC0")]
		public static ObjectNetworkId Scene(int sceneIndex, int index)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
		private ObjectNetworkId(uint rawValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		[BurstDiscard]
		private static void SQKMCLJVJLG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x873B430", Offset = "0x873A430", VA = "0x18873B430")]
		public void ZFXAJJHVNLN([Out] NetworkCreatorId a, [Out] int b)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x25CB820", Offset = "0x25CA820", VA = "0x1825CB820")]
		public static bool RZMMTPOVALZ(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x873AD10", Offset = "0x8739D10", VA = "0x18873AD10")]
		public static bool JSVUWZZXHQQ(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x25CB800", Offset = "0x25CA800", VA = "0x1825CB800", Slot = "5")]
		public bool Equals(ObjectNetworkId id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x873ABB0", Offset = "0x8739BB0", VA = "0x18873ABB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x16AB700", Offset = "0x16AA700", VA = "0x1816AB700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x873AFC0", Offset = "0x8739FC0", VA = "0x18873AFC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x873AD20", Offset = "0x8739D20", VA = "0x18873AD20")]
		public string MADVFOLUGMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x873ABA0", Offset = "0x8739BA0", VA = "0x18873ABA0", Slot = "4")]
		public int CompareTo(ObjectNetworkId other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x873AD00", Offset = "0x8739D00", VA = "0x18873AD00")]
		public static bool IGSSAAEDEWJ(ObjectNetworkId a, ObjectNetworkId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x873B160", Offset = "0x873A160", VA = "0x18873B160")]
		public static bool YWGPCXPLADI(ReadOnlySpan<char> a, [Out] ObjectNetworkId b)
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
		public PlayerId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x25CB800", Offset = "0x25CA800", VA = "0x1825CB800", Slot = "4")]
		public bool Equals(PlayerId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x873B630", Offset = "0x873A630", VA = "0x18873B630", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static implicit operator PlayerId(int id)
		{
			return default(PlayerId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25CB820", Offset = "0x25CA820", VA = "0x1825CB820")]
		public static bool RZMMTPOVALZ(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x873AD10", Offset = "0x8739D10", VA = "0x18873AD10")]
		public static bool JSVUWZZXHQQ(PlayerId a, PlayerId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x25DA170", Offset = "0x25D9170", VA = "0x1825DA170", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static bool ECZTFDGQPOG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x873B9D0", Offset = "0x873A9D0", VA = "0x18873B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ViewId XMYJAHCPVKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x873BCF0", Offset = "0x873ACF0", VA = "0x18873BCF0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public readonly int EVNEYXYVXDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public readonly int JBLOIEULXKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x873BE00", Offset = "0x873AE00", VA = "0x18873BE00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public readonly int HTVZQXIQMKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x873BB40", Offset = "0x873AB40", VA = "0x18873BB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int HWLOCRYKOHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x873BC00", Offset = "0x873AC00", VA = "0x18873BC00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool YTCOAHASSTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x873BD20", Offset = "0x873AD20", VA = "0x18873BD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NCRAWENJUOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x873B850", Offset = "0x873A850", VA = "0x18873B850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool YCDFGJDYTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x873BD70", Offset = "0x873AD70", VA = "0x18873BD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IDGQOXAMLDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x873BD10", Offset = "0x873AD10", VA = "0x18873BD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x873BEC0", Offset = "0x873AEC0", VA = "0x18873BEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x873BA90", Offset = "0x873AA90", VA = "0x18873BA90")]
		private static int GLEKVBMRPCE(int a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x873BA90", Offset = "0x873AA90", VA = "0x18873BA90")]
		public static ViewId From(int actor, int subId, bool destroyOnLeave)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static ViewId From(int viewId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static ViewId From(ObjectNetworkId networkId)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x873BD80", Offset = "0x873AD80", VA = "0x18873BD80")]
		private static void RKZTBERJJUS()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x25CB820", Offset = "0x25CA820", VA = "0x1825CB820")]
		public static bool RZMMTPOVALZ(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x873AD10", Offset = "0x8739D10", VA = "0x18873AD10")]
		public static bool JSVUWZZXHQQ(ViewId a, ViewId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x25CB820", Offset = "0x25CA820", VA = "0x1825CB820")]
		public static bool RZMMTPOVALZ(ViewId a, int b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x873BDF0", Offset = "0x873ADF0", VA = "0x18873BDF0")]
		public static bool RZMMTPOVALZ(int a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x25CB800", Offset = "0x25CA800", VA = "0x1825CB800", Slot = "4")]
		public bool Equals(ViewId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x873B940", Offset = "0x873A940", VA = "0x18873B940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x873BE40", Offset = "0x873AE40", VA = "0x18873BE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x873BC80", Offset = "0x873AC80", VA = "0x18873BC80")]
		public string MADVFOLUGMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x873BEB0", Offset = "0x873AEB0", VA = "0x18873BEB0")]
		public readonly ObjectNetworkId UYEDEPEVOSO()
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class SBTYFNUVDXN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static ViewId ZWTLRBOMWCY(this ObjectNetworkId a)
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
	public static class WZZXENZSNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal readonly struct Ownership
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int accessToken;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public bool HSTRIVAOWYA
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x873B5D0", Offset = "0x873A5D0", VA = "0x18873B5D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public RoomVersionType OVCFCLRZRCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x873B4B0", Offset = "0x873A4B0", VA = "0x18873B4B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			public Ownership(int accessToken)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static int QERFOSSZRVW;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomVersionType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x873BF00", Offset = "0x873AF00", VA = "0x18873BF00")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x873C1E0", Offset = "0x873B1E0", VA = "0x18873C1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static byte HKHSOLZNKWX
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x873C0B0", Offset = "0x873B0B0", VA = "0x18873C0B0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static bool ECUMHWMTGCX
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x873C030", Offset = "0x873B030", VA = "0x18873C030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static bool ECZTFDGQPOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x873BFB0", Offset = "0x873AFB0", VA = "0x18873BFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x873C140", Offset = "0x873B140", VA = "0x18873C140")]
		static WZZXENZSNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x873BF50", Offset = "0x873AF50", VA = "0x18873BF50")]
		internal static Ownership DRUCQHGXQPZ()
		{
			return default(Ownership);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x873C140", Offset = "0x873B140", VA = "0x18873C140")]
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

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x23ACF00", Offset = "0x23ABF00", VA = "0x1823ACF00")]
		public UgcVersionInfo(RoomVersionType roomVersion, int ugcSubVersion, int persistenceVersion, int omVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x873B6C0", Offset = "0x873A6C0", VA = "0x18873B6C0")]
		public static UgcVersionInfo PXOSSNOOKYT(byte a, int b, int c)
		{
			return default(UgcVersionInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x873B790", Offset = "0x873A790", VA = "0x18873B790")]
		public static UgcVersionInfo PXOSSNOOKYT(RoomVersionType a, int b, int c)
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
