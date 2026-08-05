using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.EV.Protobuf;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;
using RecRoom.Protobuf.Core;
using RecRoom.Versioning.Framework;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA406F00", Offset = "0xA405B00", VA = "0x18A406F00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class MPPGKLNQAWF
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface ODRSNXNZSZX : RUTHEOBVTPD<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool PSNKCDERXDZ(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int YXJSPDIGCGY(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			HFDMGMXBATW EKZNWJQOXZY(TransformData a, HFDMGMXBATW b);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			float? GMTVVLZFMSF(int a);

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			int AKYDXAPICVW(int a);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			float XKTFTNXODGJ(int a);

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void NLWNAWBWINH(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			VCTAQBGDELJ DKJPEPHDOMF();
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public abstract class BLFMBBVUXNY : ODRSNXNZSZX, RUTHEOBVTPD<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "12")]
			public DEPRECATED_RoomPersistenceVersion ACVLFZSZWVF()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4023C0", Offset = "0xA400FC0", VA = "0x18A4023C0", Slot = "13")]
			public DEPRECATED_RoomPersistenceVersion GEBZVVUQQHD()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1ADE980", Offset = "0x1ADD580", VA = "0x181ADE980", Slot = "14")]
			public DEPRECATED_RoomPersistenceVersion Increment(DEPRECATED_RoomPersistenceVersion version)
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D810", Offset = "0x2F0C410", VA = "0x182F0D810", Slot = "15")]
			public bool MOPWVVXHTLU(DEPRECATED_RoomPersistenceVersion a, DEPRECATED_RoomPersistenceVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA4023D0", Offset = "0xA400FD0", VA = "0x18A4023D0", Slot = "16")]
			public string ToString(DEPRECATED_RoomPersistenceVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "17")]
			public abstract bool PSNKCDERXDZ(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "18")]
			public abstract int YXJSPDIGCGY(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA4022E0", Offset = "0xA400EE0", VA = "0x18A4022E0", Slot = "6")]
			public HFDMGMXBATW EKZNWJQOXZY(TransformData a, HFDMGMXBATW b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "19")]
			public abstract float? GMTVVLZFMSF(int a);

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "20")]
			public abstract int AKYDXAPICVW(int a);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "21")]
			public abstract float XKTFTNXODGJ(int a);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			public abstract void NLWNAWBWINH(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			public abstract VCTAQBGDELJ DKJPEPHDOMF();

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			protected BLFMBBVUXNY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class YKARXEIJBNC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class NSDBVUSJHQX
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly string SBVREFXTZYP;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static readonly string GTOXHPFSDFE;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private static readonly string FWRDKVNTCLT;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private static readonly string PJCFFPAXPTB;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private static readonly string THMPZWCYKJN;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static readonly string KCGSMTIWFOU;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly string[] LCZFLNYXPZT;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private static readonly string[] CPXEEPSYFJV;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA405810", Offset = "0xA404410", VA = "0x18A405810")]
			public static void Run(ODRSNXNZSZX deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA404BC0", Offset = "0xA4037C0", VA = "0x18A404BC0")]
			private static void PVQJXUMHTFL(PersistedRoomData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA4048F0", Offset = "0xA4034F0", VA = "0x18A4048F0")]
			private static void LGCFTYAVEOM(PersistedRoomData a, Func<VVNGLURJUNA, SPLWKDKGHFP> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA405AF0", Offset = "0xA4046F0", VA = "0x18A405AF0")]
			private static VVNGLURJUNA ZZWNKTALXXN(PersistedRoomData a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA404B20", Offset = "0xA403720", VA = "0x18A404B20")]
			private static void LLJJARJZAUN(PersistedRoomData a, string b, Func<VVNGLURJUNA, SPLWKDKGHFP> c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA405A50", Offset = "0xA404650", VA = "0x18A405A50")]
			private static void ZWDCXFTXPVI(PersistedRoomData a, string b, Func<VVNGLURJUNA, ZHVGEOAPHAK> c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA4047B0", Offset = "0xA4033B0", VA = "0x18A4047B0")]
			private static void DZPSRSOLNXH(PersistedRoomData a, string b, Func<VVNGLURJUNA, SPLWKDKGHFP> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA404850", Offset = "0xA403450", VA = "0x18A404850")]
			private static void DZPSRSOLNXH(PersistedRoomData a, string b, Func<VVNGLURJUNA, ZHVGEOAPHAK> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA4059B0", Offset = "0xA4045B0", VA = "0x18A4059B0")]
			private static void TPPRUAJKJUC(PersistedRoomData a, string b, Func<VVNGLURJUNA, SPLWKDKGHFP> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class NRXUYNYLYFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4043D0", Offset = "0xA402FD0", VA = "0x18A4043D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class NSNPQIGEANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA406150", Offset = "0xA404D50", VA = "0x18A406150")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class NSYDKVTYTKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA406740", Offset = "0xA405340", VA = "0x18A406740")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class NSSWNPABJYY
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Guid YUWVRSBFVMQ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private static readonly ByteString UYCVZPUXYNM;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA406320", Offset = "0xA404F20", VA = "0x18A406320")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class NTIRFJHTMGZ
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private static readonly Guid FFIFYLGTLYS;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA406BA0", Offset = "0xA4057A0", VA = "0x18A406BA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class NTDKICNWCVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA4069E0", Offset = "0xA4055E0", VA = "0x18A4069E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class NQMYRSPEKED
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA404210", Offset = "0xA402E10", VA = "0x18A404210")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class NQHRULVHASU
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private static readonly Guid RAQTZZMJHLM;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private static readonly Guid NQGAWGSCLQS;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static readonly Guid RMCZSTBARVU;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA403990", Offset = "0xA402590", VA = "0x18A403990")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class UUKMWJKJNUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA40AAC0", Offset = "0xA4096C0", VA = "0x18A40AAC0")]
			public static void Run(ODRSNXNZSZX deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class TQBLMZTBYKE
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly Guid LBRWJZKXGNO;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static readonly Guid LKAGCQXDGQY;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly Dictionary<int, Guid> YSILWJDHULO;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA407140", Offset = "0xA405D40", VA = "0x18A407140")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class TQGSKGMZHVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA407B00", Offset = "0xA406700", VA = "0x18A407B00")]
			public static void Run(ODRSNXNZSZX deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class TQRGEUAUASF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA407DE0", Offset = "0xA4069E0", VA = "0x18A407DE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class TQWNCAURKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class TRBTZHOOTOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA408180", Offset = "0xA406D80", VA = "0x18A408180")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class TRHAWOIMDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class TRMHTVCJMLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA4083D0", Offset = "0xA406FD0", VA = "0x18A4083D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class TRRORBWGVWY
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly Guid APTXIXOTJMU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA4085C0", Offset = "0xA4071C0", VA = "0x18A4085C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class TRWVOIQEFIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA409040", Offset = "0xA407C40", VA = "0x18A409040")]
			public static void Run(ODRSNXNZSZX deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA4088E0", Offset = "0xA4074E0", VA = "0x18A4088E0")]
			private static quaternion DIIDAHDNOPX(HFDMGMXBATW a)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA408990", Offset = "0xA407590", VA = "0x18A408990")]
			private static HFDMGMXBATW JZBLSEPNUXK(ODRSNXNZSZX a, float3 b, quaternion c, int d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA408AF0", Offset = "0xA4076F0", VA = "0x18A408AF0")]
			private static HFDMGMXBATW OYCAMUVNLJS(ODRSNXNZSZX a, float3 b, quaternion c, int d, bool e)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class AQSQLSBEOCN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA4013E0", Offset = "0xA3FFFE0", VA = "0x18A4013E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class AQNJOLHHERE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA401210", Offset = "0xA3FFE10", VA = "0x18A401210")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class AQCVTXTMLUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA401020", Offset = "0xA3FFC20", VA = "0x18A401020")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class ARNSATCTZVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA401AF0", Offset = "0xA4006F0", VA = "0x18A401AF0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class ARILDMIWQKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4018A0", Offset = "0xA4004A0", VA = "0x18A4018A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class ARDEGFOZGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class AQXXIYVBXNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA401610", Offset = "0xA400210", VA = "0x18A401610")]
			public static void Run(ODRSNXNZSZX deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class ASITPUEJLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA401CA0", Offset = "0xA4008A0", VA = "0x18A401CA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class UVQCFXZTSKO
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static readonly Guid UWYCOXUYGPI;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static readonly Guid ZCMXHZQGYNT;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static readonly Guid LXVPBSDUSSI;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static readonly Guid APTXIXOTJMU;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static readonly Guid VVTOVFELFKV;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly Guid MLGJFMRNNFN;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static readonly Guid LOHKOHGSLHQ;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA41DF20", Offset = "0xA41CB20", VA = "0x18A41DF20")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA41DC30", Offset = "0xA41C830", VA = "0x18A41DC30")]
			private static XQRIRTTDIOM RUSZXYLOSSN(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA41E1C0", Offset = "0xA41CDC0", VA = "0x18A41E1C0")]
			private static XQRIRTTDIOM ZFGGZDSVNLR(Guid a, bool b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA41DBA0", Offset = "0xA41C7A0", VA = "0x18A41DBA0")]
			private static XQRIRTTDIOM KKYXWMZUTIW(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class UVVJDETRBVX
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static readonly Guid LNJOWQXHBAY;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA41E400", Offset = "0xA41D000", VA = "0x18A41E400")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class UWQKSFVGNPH
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly Guid EJYHJALQXSW;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static readonly Guid RMCZSTBARVU;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly Guid ZVEPMWBWLJN;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA41E6F0", Offset = "0xA41D2F0", VA = "0x18A41E6F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<ODRSNXNZSZX, PersistedRoomData, DEPRECATED_RoomPersistenceVersion> JJNDANUWJHK;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA402CD0", Offset = "0xA4018D0", VA = "0x18A402CD0")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(ODRSNXNZSZX a, PersistedRoomData b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class GGNVRNZEUZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA4024E0", Offset = "0xA4010E0", VA = "0x18A4024E0")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(MPPGKLNQAWF.ODRSNXNZSZX a, SpawnableTemplateData b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class UGLZPJDMMOS
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface ODRSNXNZSZX : RUTHEOBVTPD<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public sealed class BLFMBBVUXNY : ODRSNXNZSZX, RUTHEOBVTPD<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static BLFMBBVUXNY UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			public PersistedRoomVersion ACVLFZSZWVF()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA4023B0", Offset = "0xA400FB0", VA = "0x18A4023B0", Slot = "5")]
			public PersistedRoomVersion GEBZVVUQQHD()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1ADE980", Offset = "0x1ADD580", VA = "0x181ADE980", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D810", Offset = "0x2F0C410", VA = "0x182F0D810", Slot = "7")]
			public bool MOPWVVXHTLU(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA402420", Offset = "0xA401020", VA = "0x18A402420", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BLFMBBVUXNY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class UVAHODSBQCN
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static Dictionary<Guid, string[]> QAWBAFGGMBB;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA40B0A0", Offset = "0xA409CA0", VA = "0x18A40B0A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class BIUENODDALS
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA401E60", Offset = "0xA400A60", VA = "0x18A401E60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class BJPGCPESMFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA402120", Offset = "0xA400D20", VA = "0x18A402120")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class VJWIDMRDDNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA41EF70", Offset = "0xA41DB70", VA = "0x18A41EF70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class VKBPATLAMZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA41F130", Offset = "0xA41DD30", VA = "0x18A41F130")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class PEAPPDUJIUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA406F80", Offset = "0xA405B80", VA = "0x18A406F80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class IJQQJNFCZPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA402980", Offset = "0xA401580", VA = "0x18A402980")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class NSYDKVTYTKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA432B40", Offset = "0xA431740", VA = "0x18A432B40")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class NTDKICNWCVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA432E60", Offset = "0xA431A60", VA = "0x18A432E60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class TQRGEUAUASF
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private static readonly Dictionary<Guid, int> NJVFZJADZDM;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA4439F0", Offset = "0xA4425F0", VA = "0x18A4439F0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA4437B0", Offset = "0xA4423B0", VA = "0x18A4437B0")]
			private static Dictionary<Guid, NEAYWMKOJYN> IWIUVZJOUBF(NEAYWMKOJYN a, Dictionary<Guid, NEAYWMKOJYN> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class TRWVOIQEFIH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA445910", Offset = "0xA444510", VA = "0x18A445910")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class UUPTTQEGXFV
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA445EB0", Offset = "0xA444AB0", VA = "0x18A445EB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class INQEBPDXMUW
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA42FF70", Offset = "0xA42EB70", VA = "0x18A42FF70")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA42FF60", Offset = "0xA42EB60", VA = "0x18A42FF60")]
			private static void MGDKUZTCQQP(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class INFQHBQCTYE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA42FD60", Offset = "0xA42E960", VA = "0x18A42FD60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class IOARWCRSFRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA430250", Offset = "0xA42EE50", VA = "0x18A430250")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class IPGHFRHCKHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA430640", Offset = "0xA42F240", VA = "0x18A430640")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class IPLOCYAZTSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA4309B0", Offset = "0xA42F5B0", VA = "0x18A4309B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class UVVJDETRBVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA446070", Offset = "0xA444C70", VA = "0x18A446070")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class OOTYHNAUJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA4435E0", Offset = "0xA4421E0", VA = "0x18A4435E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ONOIXYLKEXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA433030", Offset = "0xA431C30", VA = "0x18A433030")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class ONYWSLZEXUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private enum LegacyStableSpawnableToolType
			{
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				INVALID = -1,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PAINTBALL_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PAINTBALL_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				PAINTBALL_SNIPER_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				PAINTBALL_ASSAULT_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				PAINTBALL_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				PAINTBALL_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				PADDLEBALL_PADDLE,
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				PAINTBALL_GRENADE_LAUNCHER,
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				MAKER_PEN_CHARADES,
				[Cpp2IlInjected.Token(Token = "0x4000040")]
				SOCCER_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				ROTJ_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				ROTJ_RAILGUN,
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				ROTJ_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000044")]
				ROTJ_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x4000045")]
				ROTJ_SMG,
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				GT_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				GT_BOW,
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				GT_SWORD,
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				CANDLE,
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				BELL,
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				WELCOME_MAT,
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				GT_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				BASKETBALL,
				[Cpp2IlInjected.Token(Token = "0x400004E")]
				DODGEBALL,
				[Cpp2IlInjected.Token(Token = "0x400004F")]
				DISCGOLF_DISC,
				[Cpp2IlInjected.Token(Token = "0x4000050")]
				SOLOCUP,
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				WATERBOTTLE,
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				DART,
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				DIE,
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				DEPRECATED_FLAG_RED,
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				DEPRECATED_FLAG_BLUE,
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				DEPRECATED_FLAG_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				DEPRECATED_FLAG_GREEN,
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				STICKY_NOTE,
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				STICKY_POSTER,
				[Cpp2IlInjected.Token(Token = "0x400005A")]
				DRAWABLE_CLIPBOARD,
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				MARKER_BLACK,
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				MARKER_RED,
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				MARKER_BLUE,
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				MARKER_GREEN,
				[Cpp2IlInjected.Token(Token = "0x400005F")]
				MARKER_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x4000060")]
				MARKER_ORANGE,
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				MARKER_PINK,
				[Cpp2IlInjected.Token(Token = "0x4000062")]
				MARKER_PURPLE,
				[Cpp2IlInjected.Token(Token = "0x4000063")]
				MARKER_SKYBLUE,
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				MARKER_BROWN,
				[Cpp2IlInjected.Token(Token = "0x4000065")]
				ERASER,
				[Cpp2IlInjected.Token(Token = "0x4000066")]
				MARKER_ERASER,
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				CHAIR,
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				MICROPHONE,
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				SANDBOX_TOOL_GOAL_SMALL,
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				SANDBOX_TOOL_GOAL_MEDIUM,
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				SANDBOX_TOOL_GOAL_LARGE,
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				SANDBOX_PLAYER_GOAL,
				[Cpp2IlInjected.Token(Token = "0x400006D")]
				CONFETTI_GUN,
				[Cpp2IlInjected.Token(Token = "0x400006E")]
				PING_PONG_PADDLE,
				[Cpp2IlInjected.Token(Token = "0x400006F")]
				PING_PONG_BALL,
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				CC_WAND,
				[Cpp2IlInjected.Token(Token = "0x4000071")]
				CC_HUNTER_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000072")]
				RADIO,
				[Cpp2IlInjected.Token(Token = "0x4000073")]
				BUCKET,
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				ARENA_EMP,
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				PROPBOX_SQUARE,
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				PROPBOX_RECTANGLE,
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				FLATTREESMALL,
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				FLATTREEMEDIUM,
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				FLATTREELARGE,
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				MARSHMALLOWSTICK,
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				HORIZONTALWALL,
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				VERTICALWALL,
				[Cpp2IlInjected.Token(Token = "0x400007D")]
				BACKSTOPSHORT,
				[Cpp2IlInjected.Token(Token = "0x400007E")]
				WINEBARREL,
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				CONCRETEBLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				STONEPILLAR,
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				LOGBENCH,
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				SITTINGLOG,
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				CONE,
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				CAMPFIRE,
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				STOOL,
				[Cpp2IlInjected.Token(Token = "0x4000086")]
				GLOWSTICK_BLUE,
				[Cpp2IlInjected.Token(Token = "0x4000087")]
				GLOWSTICK_RED,
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				GLOWSTICK_PURPLE,
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				GLOWSTICK_ORANGE,
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				COUCH,
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				COUCHCHAIR,
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				ARENA_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				ARENA_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				ARENA_SMG,
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				ARENA_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000090")]
				ARENA_RAILGUN,
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				ARENA_ROCKET_LAUNCHER,
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				RC_CAR_SET,
				[Cpp2IlInjected.Token(Token = "0x4000093")]
				RC_CAR,
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				RC_REMOTE_CONTROL,
				[Cpp2IlInjected.Token(Token = "0x4000095")]
				CC_MEAT_SWORD,
				[Cpp2IlInjected.Token(Token = "0x4000096")]
				CC_FIRE_POTION,
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				D20,
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				D12,
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				D10,
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				D8,
				[Cpp2IlInjected.Token(Token = "0x400009B")]
				D6,
				[Cpp2IlInjected.Token(Token = "0x400009C")]
				D4,
				[Cpp2IlInjected.Token(Token = "0x400009D")]
				DICE_SET,
				[Cpp2IlInjected.Token(Token = "0x400009E")]
				POKERCHAIR,
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				PLANT_FIG,
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				PLANT_DRACAENA,
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				PLANT_SNAKE,
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				TABLE_MEETING,
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				TABLE_COFFEE_LARGE,
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				HAM,
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				TABLE_PINGPONG,
				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				SPEAKER,
				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				MICROPHONE_STAND,
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				TABLE_TALL,
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				TABLE_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				BOOKSHELF_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				BOOKSHELF_TALL,
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				LOCKERS,
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				BOOK_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				BOOK_GREEN,
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				MOCKTAIL_SHAKER,
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				MOCKTAIL_STEMLESS,
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				MOCKTAIL_MARTINI,
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				MOCKTAIL_MILKSHAKE,
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				MOCKTAIL_GOBLET,
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				MOCKTAIL_MARGARITA,
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				MOCKTAIL_TALL,
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				MINIFRIDGE,
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				DEPRECATED_ROOM_DOOR,
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				SNOWBALL,
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				SNOWBALL_PILE,
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				POLAROID,
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				PIRATE_CUTLASS,
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				PIRATE_RUM_JUG,
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				PIRATE_BEER_BOTTLE,
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				COMBINATOR_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				COMPARER_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				VARIABLE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				TIMER_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				DELAY_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				MESSAGE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				BOOLEAN_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				IMPULSE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				DISCGOLF_GOAL,
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				PLAYER_CREATED_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				GAME_STATE_OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				GAME_STATE_INPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				SCORE_INPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				SET_SCORE_OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				PIRATE_FLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				PIRATE_COCONUT_BOMB,
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				MOVEABLE_WHITEBOARD,
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				RANDOM_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				PLAYER_HIT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				PIRATE_SMALL_LOOT_PILE,
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				SFX_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				DEPRECATED_HOLOTAR_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				PIRATE_PUSH_BROOM,
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				PIRATE_BAR_STOOL,
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				PIRATE_PLUSH_FISH,
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				PIRATE_FRYING_PAN,
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				PIRATE_OAR,
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				PIRATE_PLATE,
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				PIRATE_MUG,
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				PIRATE_LOST_LOOT,
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				WHITEBOARD_MARKERS,
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				PIRATE_HOOK_HAND,
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				PLAYER_RESPAWN_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				SANDBOX_FLOOR,
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				SANDBOX_WALL,
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				PLAYER_RESPAWN_POINT,
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				SANDBOX_CEILING,
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				SANDBOX_WALL_WINDOW,
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				AMBIENCE_RADIO,
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				INDICATOR_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				SANDBOX_AUDIO_SAMPLER,
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				SELECTOR_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				DEPRECATED_SANDBOX_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				ROTATOR_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				TRIGGER_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				ROYALE_ISLAND_MAP,
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				GAME_GET_SCORE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				GAME_SET_SCORE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				GET_PLAYER_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				SET_PLAYER_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				PLAYER_TEAM_MAPPING_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				PLAYER_EVENT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				GAME_SET_STATE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				ROYALE_HEALTH_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				ROYALE_SHIELD_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				ROYALE_HEALTH_AND_SHIELD_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				CIRCUIT_STAGE_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				ROYALE_AMMUNITION_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				ROYALE_AMMUNITION_AUTOMATIC,
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				ROYALE_AMMUNITION_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				ROYALE_AMMUNITION_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				ROYALE_AMMUNITION_EXPLOSIVE,
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				SMOOTH_LOOK_AT,
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				PISTON_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				MICROPHONE_CONFERENCE,
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				WAVE_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				PLAYER_ROLE_MAP_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				CLAMP_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				OBJECT_RESPAWNER,
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				OBJECT_PLAYER_MAP_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				ARENA_BEAM_GUN,
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				COFFEE_POT,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				COFFEE_MUG,
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				CAFE_PLATE,
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				QUEST_POT,
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				QUEST_POT_LARGE,
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				SCIFI_POT,
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				OBJECT_SET_TAGS_NODE,
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				SANDBOX_GAMING_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				SANDBOX_MEEPLE,
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				PAINTBRUSH,
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				SANDBOX_GAMING_TABLE_SMALL,
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				SOCCER_BALL,
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				DRACULA_BONE,
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				PARTICLE_EMITTER,
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				COSTUME_DUMMY,
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				DRACULA_BLUNDERBUSS,
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				DRACULA_MINIBOSS_BONE,
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				DRACULA_SHOVEL,
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				DRACULA_PITCHFORK,
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				DRACULA_RAKE,
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				DRACULA_WHIP,
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				DRACULA_WALL_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				DRACULA_PUMPKIN_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				DRACULA_LOOT_SMALL,
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				SHAPE_CONTAINER,
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				DRACULA_CHESTCOINS_SMALL,
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				DRACULA_CHESTCOINS_MEDIUM,
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				DRACULA_CHESTCOINS_LARGE,
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				DRACULA_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				DRACULA_HUNTER_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				DRACULA_MINIBOSSCOINS_BAT,
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				DRACULA_MINIBOSSCOINS_BONETHROWER,
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				DRACULA_MINIBOSSCOINS_MUSKET,
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				DRACULA_MINIBOSSCOINS_WOLF,
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				DRACULA_MINIBOSSCOINS_BONEMELEE,
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				DRACULA_STANDING_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400012A")]
				DRACULA_SMALL_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400012B")]
				DRACULA_FLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x400012C")]
				DRACULA_BOSS_PLUSHY,
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				DRACULA_HOOKSHOT,
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				BOWLING_BALL,
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				BOWLING_PIN,
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				ROYALE_BACKPACK,
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				HANDHELD_STREAMER_CAMERA,
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				STACKABLE_BLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				RECROYALE_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				GAME_CONFIGURATION,
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				BOWLING_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				DISC_GOLF_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				DODGEBALL_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				LASER_TAG_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				PADDLEBALL_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				SOCCER_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				CIRCUIT_GROUP,
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				STATE_MACHINE,
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				STATE_MACHINE_STATE,
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				STANDEE_FEMALE_01,
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				STANDEE_MALE_01,
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				STANDEE_FEMALE_02,
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				STANDEE_FEMALE_03,
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				STANDEE_PIRATE_PHOTO,
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				STANDEE_PIRATE_01,
				[Cpp2IlInjected.Token(Token = "0x400014F")]
				STANDEE_PIRATE_02,
				[Cpp2IlInjected.Token(Token = "0x4000150")]
				STANDEE_PIRATE_DRUMMER,
				[Cpp2IlInjected.Token(Token = "0x4000151")]
				STANDEE_PIRATE_FIDDLE,
				[Cpp2IlInjected.Token(Token = "0x4000152")]
				STANDEE_PIRATE_SQUEEZEBOX,
				[Cpp2IlInjected.Token(Token = "0x4000153")]
				STANDEE_BEAR_01,
				[Cpp2IlInjected.Token(Token = "0x4000154")]
				SCOREBOARD_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x4000155")]
				CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000156")]
				SANDBOX_CIRCUIT_BEACON,
				[Cpp2IlInjected.Token(Token = "0x4000157")]
				MAKER_PEN_TROPHY_GOLD,
				[Cpp2IlInjected.Token(Token = "0x4000158")]
				MAKER_PEN_TROPHY_SILVER,
				[Cpp2IlInjected.Token(Token = "0x4000159")]
				MAKER_PEN_TROPHY_BRONZE,
				[Cpp2IlInjected.Token(Token = "0x400015A")]
				PLAYER_REVIVED_NODE,
				[Cpp2IlInjected.Token(Token = "0x400015B")]
				CONTEST_CATEGORY_TROPHY,
				[Cpp2IlInjected.Token(Token = "0x400015C")]
				SCOREBOARD_SETUP_NODE,
				[Cpp2IlInjected.Token(Token = "0x400015D")]
				DYNAMIC_SPOTLIGHT,
				[Cpp2IlInjected.Token(Token = "0x400015E")]
				DYNAMINC_POINT_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x400015F")]
				MARKER_RECOLORABLE,
				[Cpp2IlInjected.Token(Token = "0x4000160")]
				HOLO_HELPER,
				[Cpp2IlInjected.Token(Token = "0x4000161")]
				STUNTRUNNER_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000162")]
				STUNTRUNNER_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000163")]
				ANIMATIONGIZMO,
				[Cpp2IlInjected.Token(Token = "0x4000164")]
				TILEABLE_ROPE_NET,
				[Cpp2IlInjected.Token(Token = "0x4000165")]
				LIGHT_STRIP_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000166")]
				CHECKPOINT_SANDBOX,
				[Cpp2IlInjected.Token(Token = "0x4000167")]
				BOUNCE_PAD,
				[Cpp2IlInjected.Token(Token = "0x4000168")]
				LIGHT_CHEVRONS,
				[Cpp2IlInjected.Token(Token = "0x4000169")]
				LIGHT_MARQUEE,
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				SCAFFOLDING_SHINY,
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				SCAFFOLDING_BLOCK,
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				CRASHPAD_EXTRA_THICK,
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				CRASHPAD_THICK,
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				CRASHPAD_THIN,
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				CRASHPAD_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				SPEAKER_CONCERT,
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				STAGELIGHT_CAN,
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				SET_LEADERBOARD_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				GET_LEADERBOARD_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				LEADERBOARD_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				PLAYER_BOOSTER,
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				ART_CANVAS,
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				SPRINGBOARD_STUNTRUNNER,
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				IMPULSE_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				STUNTRUNNER_JUMBOTRON,
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				STUNTRUNNER_BASEROOM_FLOOR,
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				STUNTRUNNER_BASEROOM_CEILING,
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				STUNTRUNNER_BASEROOM_WALL_SHORT,
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				STUNTRUNNER_BASEROOM_WALL_LONG,
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				ART_CANVAS_SQUARE,
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				STUNTRUNNER_PICKUP,
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				STUNTRUNNER_CHECKPOINT_INVENTION,
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				STUNTRUNNER_COMMENTATOR_BOOTH,
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				STUNTRUNNER_ENDING_GATE,
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				STUNTRUNNER_STARTING_GATE,
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				STUNTRUNNER_COMMENTATOR_CAMERA,
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				STUNTRUNNER_BOOM_MICROPHONE,
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				GAME_ROLE_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				JACKOLANTERN,
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				CLAPPERBOARD_VIDEO_TROPHY,
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				SANDBOX_TOGGLE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				SANDBOX_TEXT,
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				POOL_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				POOL_CUE,
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				POOL_CUE_RACK,
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				POOL_TRIANGLE,
				[Cpp2IlInjected.Token(Token = "0x400018F")]
				PAINT_THROWER,
				[Cpp2IlInjected.Token(Token = "0x4000190")]
				PROXIMITY_MINE,
				[Cpp2IlInjected.Token(Token = "0x4000191")]
				INVISIBLE_COLLISION,
				[Cpp2IlInjected.Token(Token = "0x4000192")]
				FLAG,
				[Cpp2IlInjected.Token(Token = "0x4000193")]
				FLAG_GOAL,
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				FOG_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				SKYDOME_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				BLOOM_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				COLORGRADING_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000198")]
				SUN_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				BACKGROUNDOBJECTS_NODE,
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				TABLE_UMBRELLA,
				[Cpp2IlInjected.Token(Token = "0x400019B")]
				ROUND_PICNIC_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400019C")]
				BOOTH_SEAT,
				[Cpp2IlInjected.Token(Token = "0x400019D")]
				TRASH_BAG,
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				CONCRETE_BARRIER,
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				GAS_PUMP,
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				DRIVEIN_SPEAKER,
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				CAR_TIRE,
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				CONCRETE_TUBE,
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				TELEPHONE_POLE,
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				MESH_FENCE,
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				TARGET,
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				CLASSIC_CAR,
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				TRUCK,
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				GUARD_RAIL,
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				LAWN_CHAIR,
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				FILM_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				TRACTOR_TIRE,
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				STEAM_VENT,
				[Cpp2IlInjected.Token(Token = "0x40001AD")]
				AC_UNIT,
				[Cpp2IlInjected.Token(Token = "0x40001AE")]
				METAL_BARREL,
				[Cpp2IlInjected.Token(Token = "0x40001AF")]
				DINER_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				DINER_SIGN_LARGE,
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				DRIVEIN_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				FRANKIES_FUEL_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				DUMPSTER,
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				BOOTH_TABLE,
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				FENCE_PLANK,
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				FENCE_FRAME,
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				PICNIC_TABLE,
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				TRASH_CAN,
				[Cpp2IlInjected.Token(Token = "0x40001B9")]
				CARDBOARD_BOX,
				[Cpp2IlInjected.Token(Token = "0x40001BA")]
				FLAG_AND_GOAL,
				[Cpp2IlInjected.Token(Token = "0x40001BB")]
				DESKTOP_SHARING_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x40001BC")]
				DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
				[Cpp2IlInjected.Token(Token = "0x40001BD")]
				SANDBOX_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40001BE")]
				ROOM_DOOR,
				[Cpp2IlInjected.Token(Token = "0x40001BF")]
				HOLOTAR_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40001C0")]
				ROCK_PLATEAU,
				[Cpp2IlInjected.Token(Token = "0x40001C1")]
				ROCK_STUMP,
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				ROCK_TALL,
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				ROCK_WALL,
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				ROCK_WEDGE,
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				WOODEN_SPOOL,
				[Cpp2IlInjected.Token(Token = "0x40001C6")]
				WOODSTACK,
				[Cpp2IlInjected.Token(Token = "0x40001C7")]
				WOOD_PALLET,
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				IBEAM_5M,
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				IBEAM_10M,
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				IBEAM_BRACKET,
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				HAY_BALE,
				[Cpp2IlInjected.Token(Token = "0x40001CC")]
				LOG_PILE,
				[Cpp2IlInjected.Token(Token = "0x40001CD")]
				TRASH_BIN,
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				TREE_STUMP,
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				WATER_JUG,
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				PIPE_BRACKET,
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				PIPE_CURVED,
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				PIPE_STRAIGHT,
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				PIPE_STRAIGHT_LONG,
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				CONTROL_PANEL_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				CONTROL_PANEL_TALL,
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				ELECTRICAL_UNIT,
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				PINE_TREE_DEAD,
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				SPORTS_CAR,
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				PVP_WHIP,
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				CURTAIN_TIED,
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				CURTAIN_WAVY,
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				NAPKIN_HOLDER,
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				BREAKER_BOX,
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				ROCK_01,
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				ROCK_04,
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				ROCK_CLIFF,
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				ROCK_CONE,
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				TENNIS_BALL,
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				DESKTOP_AUDIO_SHARING,
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				GOBLINBASICFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				AIPATHPOINT,
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				GOBLINBASICGROUNDMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				DRACULABONETHROWER,
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				SPAWNERCIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				NAVMESH_BAKE_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				SCFIFGROUNDEXPLOSIVE,
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				GOBLINKNIGHTSPIN,
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				GOBLINBASICGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				GOBLINBASICMELEEPIKE,
				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				GOBLINELITEGROUNDMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				GOBLINELITEFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				SCIFIBASICFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F1")]
				SCIFIBASICGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				SCIFIKNIGHTASSASSIN,
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				SCIFIELITEFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F4")]
				SCIFIELITEGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F5")]
				GOBLINVOLLEY,
				[Cpp2IlInjected.Token(Token = "0x40001F6")]
				PIRATEBASICMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001F7")]
				PIRATEEXPLOSIVETHROWING,
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				PIRATEBOTTLETHROWING,
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				PIRATEFLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				PIRATEGIBBET,
				[Cpp2IlInjected.Token(Token = "0x40001FB")]
				DRACULAMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001FC")]
				DRACULAMUSKET,
				[Cpp2IlInjected.Token(Token = "0x40001FD")]
				DRACULABATRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001FE")]
				DRACULABATLUNGING,
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				GOBLINKNIGHTCHARGE,
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				LINK_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000201")]
				RANGEFINDER_GADGET,
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				COSTUME_DUMMY_PLUS,
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				CREATOR_FEEDBACK_BUTTONS,
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				CREATOR_FREEGIFT_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000205")]
				BEAN_BAG,
				[Cpp2IlInjected.Token(Token = "0x4000206")]
				CAFE_TABLE_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000207")]
				CAFE_TABLE_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000208")]
				CAFE_CHAIR_ROUND,
				[Cpp2IlInjected.Token(Token = "0x4000209")]
				COFFEE_TABLE_CURVY,
				[Cpp2IlInjected.Token(Token = "0x400020A")]
				STOOL_WOODEN,
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				BULLETIN_BOARD,
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				CURTAIN_NO_TASSELS,
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				COUCH_WOOD,
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				STOOL_BOWLING_ALLEY,
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				JUKEBOX,
				[Cpp2IlInjected.Token(Token = "0x4000210")]
				LIGHT_PENDANT,
				[Cpp2IlInjected.Token(Token = "0x4000211")]
				ROOT_BEER_BOTTLE,
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				INKSPACE_STAGE,
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				INK_SPACE_ROOM_HULL,
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				AI_MOVE_ORDER,
				[Cpp2IlInjected.Token(Token = "0x4000215")]
				UGC_AREA,
				[Cpp2IlInjected.Token(Token = "0x4000216")]
				SPAWNERCIRCUIT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000217")]
				MODERATOR_PLAQUE_GOLD,
				[Cpp2IlInjected.Token(Token = "0x4000218")]
				MODERATOR_PLAQUE_SILVER,
				[Cpp2IlInjected.Token(Token = "0x4000219")]
				MODERATOR_PLAQUE_BRONZE,
				[Cpp2IlInjected.Token(Token = "0x400021A")]
				SANDBOX_TOGGLE_BUTTON_CV2,
				[Cpp2IlInjected.Token(Token = "0x400021B")]
				TRIGGER_VOLUME_CV2,
				[Cpp2IlInjected.Token(Token = "0x400021C")]
				SANDBOX_BUTTON_CV2,
				[Cpp2IlInjected.Token(Token = "0x400021D")]
				SHOWCASE_POSTER,
				[Cpp2IlInjected.Token(Token = "0x400021E")]
				DRACULA_LUNGING_WOLF,
				[Cpp2IlInjected.Token(Token = "0x400021F")]
				PISTON_GIZMO_V2,
				[Cpp2IlInjected.Token(Token = "0x4000220")]
				ROTATOR_GIZMO_V2,
				[Cpp2IlInjected.Token(Token = "0x4000221")]
				SFX_NODE_V2,
				[Cpp2IlInjected.Token(Token = "0x4000222")]
				SANDBOX_TEXT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000223")]
				LOG_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x4000224")]
				PARTICLE_EMITTER_V2,
				[Cpp2IlInjected.Token(Token = "0x4000225")]
				DYNAMIC_SPOTLIGHT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000226")]
				DYNAMIC_POINTLIGHT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000227")]
				DICE_SET_V2,
				[Cpp2IlInjected.Token(Token = "0x4000228")]
				D4_V2,
				[Cpp2IlInjected.Token(Token = "0x4000229")]
				D6_V2,
				[Cpp2IlInjected.Token(Token = "0x400022A")]
				D8_V2,
				[Cpp2IlInjected.Token(Token = "0x400022B")]
				D12_V2,
				[Cpp2IlInjected.Token(Token = "0x400022C")]
				D20_V2,
				[Cpp2IlInjected.Token(Token = "0x400022D")]
				D10_V2,
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				VECTOR_GADGET,
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				AUDIO_EFFECT_ZONE,
				[Cpp2IlInjected.Token(Token = "0x4000230")]
				SANDBOX_GLASS,
				[Cpp2IlInjected.Token(Token = "0x4000231")]
				GREEN_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				SANDBOX_MIRROR,
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				STREAMING_CAMERA_POINT,
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				ROOM_CURRENCY_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				SANDBOX_SEAT,
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				PUNCHING_BAG,
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				VENDING_MACHINE,
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				ICEBREAKERS,
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				MAGIC_DOOR,
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				FULLBODYCOSTUMEDUMMY,
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				SANDBOX_COC_POSTER,
				[Cpp2IlInjected.Token(Token = "0x400023C")]
				FRIENDOTRON,
				[Cpp2IlInjected.Token(Token = "0x400023D")]
				POP_UP_SHOP_1,
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				POP_UP_SHOP_2,
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				ROOM_CONSUMABLE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				RALLY_BUGGY,
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				RECRALLY_PICKUP,
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				TRIGGER_HANDLE,
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				COSTUME_TROPHY_GOLD,
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				COSTUME_TROPHY_SILVER,
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				COSTUME_TROPHY_BRONZE
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private static class CUIVHNDBTYS
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid DBRSDTZYSUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0xA42ED10", Offset = "0xA42D910", VA = "0x18A42ED10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid NETXXFBNVFT
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0xA428D10", Offset = "0xA427910", VA = "0x18A428D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid BFGYOTRGUDC
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0xA426D10", Offset = "0xA425910", VA = "0x18A426D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid ZECGDSLNWMM
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0xA42F3E0", Offset = "0xA42DFE0", VA = "0x18A42F3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid PHQXFEXACUY
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0xA42B190", Offset = "0xA429D90", VA = "0x18A42B190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid JRLNVISGIOU
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0xA424490", Offset = "0xA423090", VA = "0x18A424490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid MJAIQUAHODZ
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0xA42DE10", Offset = "0xA42CA10", VA = "0x18A42DE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid OEKYQVIXWHY
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0xA42AB10", Offset = "0xA429710", VA = "0x18A42AB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid UULJIECJSCV
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0xA423C10", Offset = "0xA422810", VA = "0x18A423C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid LMIDZEXWJVG
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0xA42F8E0", Offset = "0xA42E4E0", VA = "0x18A42F8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid VPYSNDQQTGZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0xA42A110", Offset = "0xA428D10", VA = "0x18A42A110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid GRFPOKRLGOR
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0xA425590", Offset = "0xA424190", VA = "0x18A425590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid BSCSUYBAOAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0xA41FC10", Offset = "0xA41E810", VA = "0x18A41FC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid YJYKFZMEVLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0xA42B110", Offset = "0xA429D10", VA = "0x18A42B110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid FAIWLJCMSZS
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xA42D490", Offset = "0xA42C090", VA = "0x18A42D490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid XGGTVYPZHDJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0xA426A90", Offset = "0xA425690", VA = "0x18A426A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid WXTLPOXXXZK
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0xA42A990", Offset = "0xA429590", VA = "0x18A42A990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid ZWAFFOBXWMI
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0xA421110", Offset = "0xA41FD10", VA = "0x18A421110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid NEEBFAIHUOJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0xA42E310", Offset = "0xA42CF10", VA = "0x18A42E310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid WOLQHJXJWZD
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0xA429D90", Offset = "0xA428990", VA = "0x18A429D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid LGVNOBDEVSB
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0xA423290", Offset = "0xA421E90", VA = "0x18A423290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid LTLPHOCHSOV
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0xA426410", Offset = "0xA425010", VA = "0x18A426410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid VKPLOJWGLER
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0xA426190", Offset = "0xA424D90", VA = "0x18A426190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid LILVKWVMQNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0xA421D10", Offset = "0xA420910", VA = "0x18A421D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid HIEUFEVCSES
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0xA429E90", Offset = "0xA428A90", VA = "0x18A429E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid AFBLRPNEMWD
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0xA42E290", Offset = "0xA42CE90", VA = "0x18A42E290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid CXMGUHREBUN
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0xA422510", Offset = "0xA421110", VA = "0x18A422510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid RHOKIFQAJRV
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0xA422A10", Offset = "0xA421610", VA = "0x18A422A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid ZGVOXOHCOYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0xA421090", Offset = "0xA41FC90", VA = "0x18A421090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid CXKGHJKBZFA
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0xA422B90", Offset = "0xA421790", VA = "0x18A422B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid HGROJBUEGWU
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0xA42E610", Offset = "0xA42D210", VA = "0x18A42E610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid HQVQVQZWYAZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0xA42F1E0", Offset = "0xA42DDE0", VA = "0x18A42F1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid BXFDVTCVNMR
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0xA425610", Offset = "0xA424210", VA = "0x18A425610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid ERLRGSAHWHS
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0xA426D90", Offset = "0xA425990", VA = "0x18A426D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid NOEAFAHNOGM
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0xA42F0E0", Offset = "0xA42DCE0", VA = "0x18A42F0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid JPHNMMAOSQZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0xA41F790", Offset = "0xA41E390", VA = "0x18A41F790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid CBYREGVYGKH
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0xA42A610", Offset = "0xA429210", VA = "0x18A42A610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid ZPIYRDCJZCG
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0xA42E890", Offset = "0xA42D490", VA = "0x18A42E890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid UIOCKASVUSK
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0xA42BA90", Offset = "0xA42A690", VA = "0x18A42BA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid XHCTVJFPVBV
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0xA42CD10", Offset = "0xA42B910", VA = "0x18A42CD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid ORSWGPWIVAC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0xA42E110", Offset = "0xA42CD10", VA = "0x18A42E110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid TVFUCRSUSLV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0xA429390", Offset = "0xA427F90", VA = "0x18A429390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid FAPPDMSZQRD
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0xA426E10", Offset = "0xA425A10", VA = "0x18A426E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid SKSYUMBMCWT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0xA427110", Offset = "0xA425D10", VA = "0x18A427110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid ZWUCAFXVBQZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0xA425B10", Offset = "0xA424710", VA = "0x18A425B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid TEGGBMHMKWM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0xA42C690", Offset = "0xA42B290", VA = "0x18A42C690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid CFUTQPEJRUN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0xA421490", Offset = "0xA420090", VA = "0x18A421490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid LYZPMNLPSYA
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0xA42D690", Offset = "0xA42C290", VA = "0x18A42D690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid YMLCHEPHXJV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0xA424510", Offset = "0xA423110", VA = "0x18A424510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid RDZDOMMKTHL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0xA42B090", Offset = "0xA429C90", VA = "0x18A42B090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid LPPVXGKRITS
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0xA429810", Offset = "0xA428410", VA = "0x18A429810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid FSLXIGOGUVC
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xA423510", Offset = "0xA422110", VA = "0x18A423510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid DINEVELJQAG
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xA42A210", Offset = "0xA428E10", VA = "0x18A42A210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid HTKPOWRICYE
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xA429010", Offset = "0xA427C10", VA = "0x18A429010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid CKQAXYDMXFT
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xA428A90", Offset = "0xA427690", VA = "0x18A428A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid LRGVQVMAMXX
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xA42AE10", Offset = "0xA429A10", VA = "0x18A42AE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid QULLCCWDCYQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0xA429090", Offset = "0xA427C90", VA = "0x18A429090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid MCGZDRIHUDH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xA42EC10", Offset = "0xA42D810", VA = "0x18A42EC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid ADYAPRFLXXD
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0xA420190", Offset = "0xA41ED90", VA = "0x18A420190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid EFJCHJJSOYO
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xA428590", Offset = "0xA427190", VA = "0x18A428590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid PJSGNSADAFJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xA423490", Offset = "0xA422090", VA = "0x18A423490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid VEIPDXWVLZA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xA426A10", Offset = "0xA425610", VA = "0x18A426A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid CHQCCJSHWQC
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xA428B90", Offset = "0xA427790", VA = "0x18A428B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid BZNCRCCWKGY
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xA41F590", Offset = "0xA41E190", VA = "0x18A41F590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid ADOADPCGACE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0xA425B90", Offset = "0xA424790", VA = "0x18A425B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid IZXLQOVAHMO
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xA423390", Offset = "0xA421F90", VA = "0x18A423390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid GUYWWZFDUTG
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0xA42D410", Offset = "0xA42C010", VA = "0x18A42D410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid QEZBKSQGGSS
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0xA42C910", Offset = "0xA42B510", VA = "0x18A42C910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid TNTVRMYHCIR
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0xA42A510", Offset = "0xA429110", VA = "0x18A42A510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid IQOYSZZNJMA
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xA426E90", Offset = "0xA425A90", VA = "0x18A426E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid TIEUMAFPNSS
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xA42AB90", Offset = "0xA429790", VA = "0x18A42AB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid UVKUVRJCIQD
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0xA42DD90", Offset = "0xA42C990", VA = "0x18A42DD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid SEVRLKDHRRH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0xA42DB90", Offset = "0xA42C790", VA = "0x18A42DB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid OQSKYBUUVUI
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xA421010", Offset = "0xA41FC10", VA = "0x18A421010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid UZKGHISCNHX
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0xA425090", Offset = "0xA423C90", VA = "0x18A425090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid TFQSYYPCQZO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0xA42ED60", Offset = "0xA42D960", VA = "0x18A42ED60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid MPROWJZNLAO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0xA424B90", Offset = "0xA423790", VA = "0x18A424B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid INGWYQAEHCD
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0xA42C490", Offset = "0xA42B090", VA = "0x18A42C490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid XLWPIDTFRCR
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0xA42BD90", Offset = "0xA42A990", VA = "0x18A42BD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid CLYJVAESCFB
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0xA420C90", Offset = "0xA41F890", VA = "0x18A420C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid XWKOKRCWQKE
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0xA42B810", Offset = "0xA42A410", VA = "0x18A42B810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid TXPGRIZTDOD
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0xA425790", Offset = "0xA424390", VA = "0x18A425790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid XRMJHMQFTWG
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0xA426B10", Offset = "0xA425710", VA = "0x18A426B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid OATFSFJORJA
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0xA424790", Offset = "0xA423390", VA = "0x18A424790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid PZZSCIUVUTY
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0xA426990", Offset = "0xA425590", VA = "0x18A426990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid YASKZYRLDDN
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0xA421190", Offset = "0xA41FD90", VA = "0x18A421190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid YOLCKJDTEGT
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0xA42CD90", Offset = "0xA42B990", VA = "0x18A42CD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid OORDYKCRWLQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0xA427810", Offset = "0xA426410", VA = "0x18A427810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid ZDCDNAAHNAF
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0xA424310", Offset = "0xA422F10", VA = "0x18A424310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid HMCHKUENJMW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0xA424910", Offset = "0xA423510", VA = "0x18A424910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid KCUQQISUMPM
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0xA426390", Offset = "0xA424F90", VA = "0x18A426390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid YSYGMFCVPBL
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0xA420590", Offset = "0xA41F190", VA = "0x18A420590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid RSLODVSLKDD
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0xA42A190", Offset = "0xA428D90", VA = "0x18A42A190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid XDKCZQELJXM
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0xA423A90", Offset = "0xA422690", VA = "0x18A423A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid WHNYWDNEVHS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0xA422710", Offset = "0xA421310", VA = "0x18A422710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid KFHPASUKNYK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0xA42F160", Offset = "0xA42DD60", VA = "0x18A42F160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid WQNMPKOMTRZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0xA421B90", Offset = "0xA420790", VA = "0x18A421B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid ZHYZLJGRAPQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0xA42A910", Offset = "0xA429510", VA = "0x18A42A910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid TGVFFLJUDWX
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0xA42E990", Offset = "0xA42D590", VA = "0x18A42E990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid THFSZYXOWTP
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0xA42EA10", Offset = "0xA42D610", VA = "0x18A42EA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid CGZGLJBGHXK
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0xA429590", Offset = "0xA428190", VA = "0x18A429590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid CIEVUXQQMNM
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0xA429410", Offset = "0xA428010", VA = "0x18A429410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid CHUIAKCVTQU
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0xA429490", Offset = "0xA428090", VA = "0x18A429490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid NONNABUDMJK
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0xA425910", Offset = "0xA424510", VA = "0x18A425910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid HVWCDZBQQRA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0xA423010", Offset = "0xA421C10", VA = "0x18A423010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid WVAJGRBQORK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0xA42EF60", Offset = "0xA42DB60", VA = "0x18A42EF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid RRSCTKEDVCD
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0xA423110", Offset = "0xA421D10", VA = "0x18A423110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid KZBDZKNCMXY
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0xA422110", Offset = "0xA420D10", VA = "0x18A422110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid YSYENOLDXCG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0xA425810", Offset = "0xA424410", VA = "0x18A425810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid NQRNSEJFLSB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0xA42F760", Offset = "0xA42E360", VA = "0x18A42F760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid VIFHPJYIOZA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xA426310", Offset = "0xA424F10", VA = "0x18A426310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid IBDPQIBBSLJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0xA42C090", Offset = "0xA42AC90", VA = "0x18A42C090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid NLIAZSIPIIB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0xA424290", Offset = "0xA422E90", VA = "0x18A424290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid QOFMAGRPFZN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0xA429890", Offset = "0xA428490", VA = "0x18A429890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid COAVPYUAXBE
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0xA42F660", Offset = "0xA42E260", VA = "0x18A42F660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid NSYNLDWIDJT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0xA426490", Offset = "0xA425090", VA = "0x18A426490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid QPKRDJTIKSC
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0xA42A790", Offset = "0xA429390", VA = "0x18A42A790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid ASLZGSQGSXF
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0xA423590", Offset = "0xA422190", VA = "0x18A423590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid WLNKJFVVNMZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0xA425990", Offset = "0xA424590", VA = "0x18A425990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid UWLVKPCOQIW
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0xA42D210", Offset = "0xA42BE10", VA = "0x18A42D210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid FKZYBUBTULD
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0xA427510", Offset = "0xA426110", VA = "0x18A427510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid ZYPNRXDNDZP
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0xA42EDE0", Offset = "0xA42D9E0", VA = "0x18A42EDE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid JFINRSHZZSZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0xA429D10", Offset = "0xA428910", VA = "0x18A429D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid PRNZSYXVRWN
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0xA42C890", Offset = "0xA42B490", VA = "0x18A42C890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid WPHLAUCMNQA
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0xA42C790", Offset = "0xA42B390", VA = "0x18A42C790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid TMATNEODZTK
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0xA420990", Offset = "0xA41F590", VA = "0x18A420990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid NXXOAJECCUZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0xA421B10", Offset = "0xA420710", VA = "0x18A421B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid VDAFSDXAAHI
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0xA41FC90", Offset = "0xA41E890", VA = "0x18A41FC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid NSSWICECIWG
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0xA427390", Offset = "0xA425F90", VA = "0x18A427390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid MQVHHPCNKZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0xA422690", Offset = "0xA421290", VA = "0x18A422690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid CDDABQLXZNQ
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0xA428D90", Offset = "0xA427990", VA = "0x18A428D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid CNGMMCYZUIL
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0xA428310", Offset = "0xA426F10", VA = "0x18A428310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid JPCZVYTPGTO
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0xA420710", Offset = "0xA41F310", VA = "0x18A420710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid NTKNQGOQPHF
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0xA41F990", Offset = "0xA41E590", VA = "0x18A41F990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid EOBUMKUOXFZ
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0xA425A90", Offset = "0xA424690", VA = "0x18A425A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid MOEVGJLMNWF
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xA424990", Offset = "0xA423590", VA = "0x18A424990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid DDJBZEXDRYG
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0xA42C410", Offset = "0xA42B010", VA = "0x18A42C410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid XWSFHOVDFED
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0xA428390", Offset = "0xA426F90", VA = "0x18A428390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid GRIQRPRSSGQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0xA42BC90", Offset = "0xA42A890", VA = "0x18A42BC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid DQSYLVNGNWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0xA424D10", Offset = "0xA423910", VA = "0x18A424D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid NGMXDMWGJLU
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0xA425E90", Offset = "0xA424A90", VA = "0x18A425E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid ECHYWGFWPAA
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0xA42D090", Offset = "0xA42BC90", VA = "0x18A42D090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid QFDAPMAENFO
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0xA42C210", Offset = "0xA42AE10", VA = "0x18A42C210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid TTEOAYBYSQJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0xA425110", Offset = "0xA423D10", VA = "0x18A425110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid DBMYICDBODC
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0xA42AD10", Offset = "0xA429910", VA = "0x18A42AD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid ODCTQJQTLSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0xA421C90", Offset = "0xA420890", VA = "0x18A421C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid QZALYKYUJVU
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0xA426590", Offset = "0xA425190", VA = "0x18A426590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid EFVZPFKGGYB
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0xA426910", Offset = "0xA425510", VA = "0x18A426910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid LNZUQUGVKGM
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0xA41FA10", Offset = "0xA41E610", VA = "0x18A41FA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid SOVCKMKPCWO
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0xA42D910", Offset = "0xA42C510", VA = "0x18A42D910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid KAXIASFZJYA
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0xA42C390", Offset = "0xA42AF90", VA = "0x18A42C390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid SKJADXGDOEO
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0xA42D310", Offset = "0xA42BF10", VA = "0x18A42D310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid NCEECZWXEWC
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0xA422890", Offset = "0xA421490", VA = "0x18A422890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid CVOVMXFVSWN
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0xA428C90", Offset = "0xA427890", VA = "0x18A428C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid TZERVFVJEMU
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0xA425490", Offset = "0xA424090", VA = "0x18A425490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid TFDKSFFQDRW
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0xA42FBE0", Offset = "0xA42E7E0", VA = "0x18A42FBE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid HQIGCBYUNBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0xA421710", Offset = "0xA420310", VA = "0x18A421710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid UOKMIQOKDAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0xA427C90", Offset = "0xA426890", VA = "0x18A427C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid MHNRARKNTLU
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0xA428410", Offset = "0xA427010", VA = "0x18A428410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid CIMHJJHNXGQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0xA427A90", Offset = "0xA426690", VA = "0x18A427A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid SDHMMFUWPBZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xA427B90", Offset = "0xA426790", VA = "0x18A427B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid PEBGUNCOMUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xA426210", Offset = "0xA424E10", VA = "0x18A426210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid NRLYSACTADB
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xA42B510", Offset = "0xA42A110", VA = "0x18A42B510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid CQJVWLTTUTC
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xA42BF10", Offset = "0xA42AB10", VA = "0x18A42BF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid LCHQFUXBAXU
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0xA422090", Offset = "0xA420C90", VA = "0x18A422090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid KIORKKMYKDP
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xA42D010", Offset = "0xA42BC10", VA = "0x18A42D010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid DYAVHTJTIWD
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0xA425D90", Offset = "0xA424990", VA = "0x18A425D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid VWXNRDSVYYP
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xA42EE60", Offset = "0xA42DA60", VA = "0x18A42EE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid OYYRJGRMVLB
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0xA42B010", Offset = "0xA429C10", VA = "0x18A42B010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid SQTRHSZCDEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0xA426810", Offset = "0xA425410", VA = "0x18A426810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid TCJSKMBROLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0xA427190", Offset = "0xA425D90", VA = "0x18A427190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid QVYRBUIRDPK
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0xA423E10", Offset = "0xA422A10", VA = "0x18A423E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid MEOHVXTKYOH
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0xA41FE90", Offset = "0xA41EA90", VA = "0x18A41FE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid FLYOXMHMPUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0xA41FD10", Offset = "0xA41E910", VA = "0x18A41FD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid IIKYLWAFNLH
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0xA424190", Offset = "0xA422D90", VA = "0x18A424190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid VTDJQFASKGY
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0xA421810", Offset = "0xA420410", VA = "0x18A421810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid NCOJFZSPVRY
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0xA425E10", Offset = "0xA424A10", VA = "0x18A425E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid HGSLXTXQQOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0xA420690", Offset = "0xA41F290", VA = "0x18A420690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid PRMXCSAIVFU
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0xA42B590", Offset = "0xA42A190", VA = "0x18A42B590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid NFXKZLMDSRM
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0xA42A710", Offset = "0xA429310", VA = "0x18A42A710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid UJBUQBKSTNW
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0xA428110", Offset = "0xA426D10", VA = "0x18A428110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid FQQXWJRJYNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0xA426510", Offset = "0xA425110", VA = "0x18A426510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid YKRJPGILHUX
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0xA423F10", Offset = "0xA422B10", VA = "0x18A423F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid WBUHRJWMSRD
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0xA42E710", Offset = "0xA42D310", VA = "0x18A42E710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid MGHANFRCWLD
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0xA424690", Offset = "0xA423290", VA = "0x18A424690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid VEFUXGFUYJW
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0xA428B10", Offset = "0xA427710", VA = "0x18A428B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid VZCPTPFLZFW
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0xA42D110", Offset = "0xA42BD10", VA = "0x18A42D110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid OADIKAOLERJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0xA422010", Offset = "0xA420C10", VA = "0x18A422010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid BVIKRUFTGFN
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0xA42B490", Offset = "0xA42A090", VA = "0x18A42B490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid VVKQARLOAUA
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0xA42AE90", Offset = "0xA429A90", VA = "0x18A42AE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid UGVCGLEIEDH
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0xA427290", Offset = "0xA425E90", VA = "0x18A427290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid UKWACXSIFZO
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0xA424410", Offset = "0xA423010", VA = "0x18A424410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid XVNIOTIILIV
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0xA42B410", Offset = "0xA42A010", VA = "0x18A42B410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid GBZYRQDMORP
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0xA42AF90", Offset = "0xA429B90", VA = "0x18A42AF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid JTDKTBWJLZI
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0xA41F810", Offset = "0xA41E410", VA = "0x18A41F810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid PCXKVKXYRQA
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0xA429610", Offset = "0xA428210", VA = "0x18A429610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid VXEBDQLTWWF
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0xA42DF90", Offset = "0xA42CB90", VA = "0x18A42DF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid IODVDZBCEDH
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0xA41FF90", Offset = "0xA41EB90", VA = "0x18A41FF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid JKZUXSZHPJW
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0xA426710", Offset = "0xA425310", VA = "0x18A426710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid RMYNABIKHBK
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0xA427890", Offset = "0xA426490", VA = "0x18A427890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid XGQVZZRRKOI
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xA428C10", Offset = "0xA427810", VA = "0x18A428C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid WLXULKCHMZB
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0xA421290", Offset = "0xA41FE90", VA = "0x18A421290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid QITOKJQUWRE
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xA420F90", Offset = "0xA41FB90", VA = "0x18A420F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid SCPJVNJGVRK
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0xA42CB10", Offset = "0xA42B710", VA = "0x18A42CB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid BKOLYXMSGJM
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0xA424C90", Offset = "0xA423890", VA = "0x18A424C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid WRLYPZSVYNR
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0xA42B990", Offset = "0xA42A590", VA = "0x18A42B990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid SGXKOVTCJIR
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0xA42F6E0", Offset = "0xA42E2E0", VA = "0x18A42F6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid HXISSSZQSIS
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0xA42DC10", Offset = "0xA42C810", VA = "0x18A42DC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid DDCHCFJNKQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0xA420310", Offset = "0xA41EF10", VA = "0x18A420310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid BEMHCXKZKXO
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0xA426110", Offset = "0xA424D10", VA = "0x18A426110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid EABFWOPMBYK
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0xA422F90", Offset = "0xA421B90", VA = "0x18A422F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid WOAVEHWDGCK
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0xA422490", Offset = "0xA421090", VA = "0x18A422490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid HIORWBLJINU
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0xA42E010", Offset = "0xA42CC10", VA = "0x18A42E010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid FUDQDSZLQWA
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0xA428290", Offset = "0xA426E90", VA = "0x18A428290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid CGBWMEECZNP
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0xA423B90", Offset = "0xA422790", VA = "0x18A423B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid HMEOMGGLUWO
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0xA41FA90", Offset = "0xA41E690", VA = "0x18A41FA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid RMVEAZGDDME
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0xA42E090", Offset = "0xA42CC90", VA = "0x18A42E090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid BAYECQFRSCI
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0xA42D190", Offset = "0xA42BD90", VA = "0x18A42D190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid IFDAHMVQUXQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0xA427A10", Offset = "0xA426610", VA = "0x18A427A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid NGPJOHKGUBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0xA426090", Offset = "0xA424C90", VA = "0x18A426090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid DWGMOUNTFBP
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0xA42BB90", Offset = "0xA42A790", VA = "0x18A42BB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid UYTVQPKNUFF
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0xA428A10", Offset = "0xA427610", VA = "0x18A428A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid JSLJSGFOAOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0xA42AC10", Offset = "0xA429810", VA = "0x18A42AC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid DMKLVKNRXJE
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0xA423910", Offset = "0xA422510", VA = "0x18A423910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid XNSZOSUSLYA
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0xA424C10", Offset = "0xA423810", VA = "0x18A424C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid SPDIHNFPKFS
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0xA428F10", Offset = "0xA427B10", VA = "0x18A428F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid JJDRLYLKDEL
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0xA425310", Offset = "0xA423F10", VA = "0x18A425310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid TRPXTDMLLQG
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0xA424B10", Offset = "0xA423710", VA = "0x18A424B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid CEEEPVNLESF
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0xA422D10", Offset = "0xA421910", VA = "0x18A422D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid OXUYZDNHLJE
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0xA427010", Offset = "0xA425C10", VA = "0x18A427010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid XHZKCESCAIQ
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0xA41FE10", Offset = "0xA41EA10", VA = "0x18A41FE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid SVZMIGYOZGB
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0xA41F610", Offset = "0xA41E210", VA = "0x18A41F610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid HUWMCPHNNUZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0xA42BE90", Offset = "0xA42AA90", VA = "0x18A42BE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid VWKNXNGFOEK
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0xA427D10", Offset = "0xA426910", VA = "0x18A427D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid XPQMQJMUXRW
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0xA42E910", Offset = "0xA42D510", VA = "0x18A42E910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid GJKBYJAHLCW
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0xA42D890", Offset = "0xA42C490", VA = "0x18A42D890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid WZNOKFNRNTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0xA42EB10", Offset = "0xA42D710", VA = "0x18A42EB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid GFBMTYRRFJU
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0xA42C710", Offset = "0xA42B310", VA = "0x18A42C710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid WNTWWIJCHDD
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0xA420C10", Offset = "0xA41F810", VA = "0x18A420C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid SXFGLRMHXLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0xA42AF10", Offset = "0xA429B10", VA = "0x18A42AF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid XJTYZDVVKNF
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0xA42F860", Offset = "0xA42E460", VA = "0x18A42F860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid BRNPCZASFKW
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0xA42DA10", Offset = "0xA42C610", VA = "0x18A42DA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid AWVCITSGSHK
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0xA42A490", Offset = "0xA429090", VA = "0x18A42A490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid KRWKGEONSTA
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0xA423610", Offset = "0xA422210", VA = "0x18A423610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid PCVPSJLLTEP
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0xA425410", Offset = "0xA424010", VA = "0x18A425410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid XKKOZFBZIOF
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0xA423E90", Offset = "0xA422A90", VA = "0x18A423E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid DNZNUQDFZVG
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0xA428190", Offset = "0xA426D90", VA = "0x18A428190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid MMTVSWBSIWM
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0xA426290", Offset = "0xA424E90", VA = "0x18A426290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid FRBAULZYZOM
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0xA42CF90", Offset = "0xA42BB90", VA = "0x18A42CF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid SMQAQVJKRXS
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0xA424E90", Offset = "0xA423A90", VA = "0x18A424E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid HYDIHMOUGUJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0xA423210", Offset = "0xA421E10", VA = "0x18A423210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid FCGUYAFBFGK
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0xA42D510", Offset = "0xA42C110", VA = "0x18A42D510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid YESMDOADYMK
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0xA423690", Offset = "0xA422290", VA = "0x18A423690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid KCBVXBFJTVP
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0xA42CC90", Offset = "0xA42B890", VA = "0x18A42CC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid ERTCIZATTQT
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0xA427610", Offset = "0xA426210", VA = "0x18A427610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid LFLTLJDVHXA
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0xA427990", Offset = "0xA426590", VA = "0x18A427990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid UMKQDTQDIVV
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0xA423890", Offset = "0xA422490", VA = "0x18A423890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid LTNQBTAOQJK
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0xA421590", Offset = "0xA420190", VA = "0x18A421590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid RQCRCIIAXEX
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0xA421990", Offset = "0xA420590", VA = "0x18A421990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid XEUZSLXKQPG
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0xA425710", Offset = "0xA424310", VA = "0x18A425710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid RSZNKBRKGOL
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0xA42B390", Offset = "0xA429F90", VA = "0x18A42B390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid TZXIUGBSWMM
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0xA420490", Offset = "0xA41F090", VA = "0x18A420490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid SRXLJRGNQCZ
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0xA429510", Offset = "0xA428110", VA = "0x18A429510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid IAGEHSGYJCW
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0xA42EA90", Offset = "0xA42D690", VA = "0x18A42EA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid RNUYNKZHZDJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xA421890", Offset = "0xA420490", VA = "0x18A421890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid DZHORODJLSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0xA42E690", Offset = "0xA42D290", VA = "0x18A42E690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid OHSLQVFZZTO
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xA42F460", Offset = "0xA42E060", VA = "0x18A42F460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid XLAQLTLPXJJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0xA42DA90", Offset = "0xA42C690", VA = "0x18A42DA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid MADEIHLWBLG
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0xA42D710", Offset = "0xA42C310", VA = "0x18A42D710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid MIXVFPUNQOD
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0xA42C110", Offset = "0xA42AD10", VA = "0x18A42C110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid LXKTHNKTATQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0xA422C10", Offset = "0xA421810", VA = "0x18A422C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid STDBATKUQNT
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0xA41F910", Offset = "0xA41E510", VA = "0x18A41F910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid MDKUUVLZLWX
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0xA428E10", Offset = "0xA427A10", VA = "0x18A428E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid VFBXKXINOIX
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0xA427710", Offset = "0xA426310", VA = "0x18A427710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid TYHLAMUWZKV
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0xA425C90", Offset = "0xA424890", VA = "0x18A425C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid NQCHGXWMMVN
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0xA428790", Offset = "0xA427390", VA = "0x18A428790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid SGGXZPJCRGQ
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0xA425510", Offset = "0xA424110", VA = "0x18A425510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid NQHOEEQJWGW
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xA428890", Offset = "0xA427490", VA = "0x18A428890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid NQMVBLKHFSF
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0xA428810", Offset = "0xA427410", VA = "0x18A428810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid EYDHXUBTCPL
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xA426C10", Offset = "0xA425810", VA = "0x18A426C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid XFPMFYIJETW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0xA420890", Offset = "0xA41F490", VA = "0x18A420890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid XGFGXSQBHBX
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0xA420910", Offset = "0xA41F510", VA = "0x18A420910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid TBATCDEGFZP
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0xA425290", Offset = "0xA423E90", VA = "0x18A425290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid LYWQHXTJZJD
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0xA42FB60", Offset = "0xA42E760", VA = "0x18A42FB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid LUYGFBVABAW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xA42F360", Offset = "0xA42DF60", VA = "0x18A42F360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid HSNXNELGUJD
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0xA42C590", Offset = "0xA42B190", VA = "0x18A42C590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid QMRCHOGNMYR
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xA423D10", Offset = "0xA422910", VA = "0x18A423D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid JDZWSYAPKKW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0xA422290", Offset = "0xA420E90", VA = "0x18A422290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid ZLFFBLGIPOA
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0xA41FF10", Offset = "0xA41EB10", VA = "0x18A41FF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid BRHJXXDERVY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0xA41FB90", Offset = "0xA41E790", VA = "0x18A41FB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid ACMOCWYKWKN
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0xA42C290", Offset = "0xA42AE90", VA = "0x18A42C290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid RMXOUAPGDVS
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0xA423090", Offset = "0xA421C90", VA = "0x18A423090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid GNZVOPFGLZM
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0xA428510", Offset = "0xA427110", VA = "0x18A428510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid FCDHNUVOTWU
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0xA42CE90", Offset = "0xA42BA90", VA = "0x18A42CE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid AAFQVOMREOZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0xA42E410", Offset = "0xA42D010", VA = "0x18A42E410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid VOJXULLISIW
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0xA42A390", Offset = "0xA428F90", VA = "0x18A42A390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid USSEYQEMRJL
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0xA42B610", Offset = "0xA42A210", VA = "0x18A42B610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid NIVINTWBYWF
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0xA41F890", Offset = "0xA41E490", VA = "0x18A41F890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid KXBEDEPKJMN
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0xA429B90", Offset = "0xA428790", VA = "0x18A429B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid ULOTFAMYEYQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0xA42FCE0", Offset = "0xA42E8E0", VA = "0x18A42FCE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid RRZAVVPGZZN
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0xA427F90", Offset = "0xA426B90", VA = "0x18A427F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid HSSMDFNVIOY
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0xA423B10", Offset = "0xA422710", VA = "0x18A423B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid HRQOXBMWYWB
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0xA42E390", Offset = "0xA42CF90", VA = "0x18A42E390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid VGPLXIBOHEM
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0xA421410", Offset = "0xA420010", VA = "0x18A421410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid GPOWVUFPAZU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xA420790", Offset = "0xA41F390", VA = "0x18A420790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid UFAVEXDCDNM
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0xA424710", Offset = "0xA423310", VA = "0x18A424710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid EMXBUPVDTAR
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xA429C90", Offset = "0xA428890", VA = "0x18A429C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid JTQVVYRPDJR
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0xA429F10", Offset = "0xA428B10", VA = "0x18A429F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid JUZIFDOLGGK
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xA428490", Offset = "0xA427090", VA = "0x18A428490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid TKRSSSSOWFW
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0xA421C10", Offset = "0xA420810", VA = "0x18A421C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid PPYFTEYAEYP
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xA429E10", Offset = "0xA428A10", VA = "0x18A429E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid JTPQVKPBPPA
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0xA422390", Offset = "0xA420F90", VA = "0x18A422390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid WXBUSUDFYIG
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0xA429710", Offset = "0xA428310", VA = "0x18A429710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid BHQEAESYDJU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0xA425010", Offset = "0xA423C10", VA = "0x18A425010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid IYKVJIYRGXS
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0xA42E590", Offset = "0xA42D190", VA = "0x18A42E590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid VXIPLDYXDSD
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xA41FB10", Offset = "0xA41E710", VA = "0x18A41FB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid UHPJQMLNPUE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0xA427690", Offset = "0xA426290", VA = "0x18A427690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid DRKZNXPHCWI
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xA41FD90", Offset = "0xA41E990", VA = "0x18A41FD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid MQAPDHKWLMA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0xA42BA10", Offset = "0xA42A610", VA = "0x18A42BA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid BOAJSYOCPAC
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0xA423790", Offset = "0xA422390", VA = "0x18A423790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid UQALSOJAZRE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0xA427410", Offset = "0xA426010", VA = "0x18A427410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid QXKQMIXESTU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0xA425D10", Offset = "0xA424910", VA = "0x18A425D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid WIDYGPGWVOG
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0xA420510", Offset = "0xA41F110", VA = "0x18A420510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid VYXOUYZAOXP
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0xA420810", Offset = "0xA41F410", VA = "0x18A420810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid JKTPQLBYEBW
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0xA424610", Offset = "0xA423210", VA = "0x18A424610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid CSTZMPTYJHL
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0xA425F90", Offset = "0xA424B90", VA = "0x18A425F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid URGYJZPLTHJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0xA427D90", Offset = "0xA426990", VA = "0x18A427D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid HUBTIRCJLSV
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0xA426C90", Offset = "0xA425890", VA = "0x18A426C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid AQDAWVSEVKI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0xA42CB90", Offset = "0xA42B790", VA = "0x18A42CB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid HNXHIYYPXCT
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0xA429210", Offset = "0xA427E10", VA = "0x18A429210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid FLDVFFGOQMY
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0xA428010", Offset = "0xA426C10", VA = "0x18A428010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid FWLSICLUFID
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xA42AA90", Offset = "0xA429690", VA = "0x18A42AA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid STZLQQPUYUK
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0xA422310", Offset = "0xA420F10", VA = "0x18A422310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid YBBOUBPPNJR
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xA42CA10", Offset = "0xA42B610", VA = "0x18A42CA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid HXUQXCFZWTA
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0xA427490", Offset = "0xA426090", VA = "0x18A427490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid TWEKNJZAXIR
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0xA420A10", Offset = "0xA41F610", VA = "0x18A420A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid YGGBKYJRABO
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0xA422990", Offset = "0xA421590", VA = "0x18A422990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid AIEPBLRDXUA
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0xA429790", Offset = "0xA428390", VA = "0x18A429790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid ARZJPZBNGWW
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0xA429990", Offset = "0xA428590", VA = "0x18A429990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid ZGUNCIFLNRX
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0xA42C310", Offset = "0xA42AF10", VA = "0x18A42C310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid OOHKYEFWQVF
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0xA420F10", Offset = "0xA41FB10", VA = "0x18A420F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid LPPJUZEWYVD
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0xA428610", Offset = "0xA427210", VA = "0x18A428610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid FYXFIMYKFLM
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0xA422210", Offset = "0xA420E10", VA = "0x18A422210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid YVBVJXNDKUE
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0xA42EB90", Offset = "0xA42D790", VA = "0x18A42EB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid HBGGFDEIMEX
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0xA420E10", Offset = "0xA41FA10", VA = "0x18A420E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid AYQENTWQJAM
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0xA422910", Offset = "0xA421510", VA = "0x18A422910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid VHUJZLRNKFH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0xA424890", Offset = "0xA423490", VA = "0x18A424890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid TORGGLOOKQU
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0xA42D990", Offset = "0xA42C590", VA = "0x18A42D990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid IFYKHCXHTYO
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0xA421F90", Offset = "0xA420B90", VA = "0x18A421F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid YYTWEJWSGBW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0xA42B290", Offset = "0xA429E90", VA = "0x18A42B290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid UXAYXHOEHZP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0xA421310", Offset = "0xA41FF10", VA = "0x18A421310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid AENQWOPICLR
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0xA425190", Offset = "0xA423D90", VA = "0x18A425190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid OOJOWCNVTAU
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0xA429A10", Offset = "0xA428610", VA = "0x18A429A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid VDMAQVJHLIW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0xA42D390", Offset = "0xA42BF90", VA = "0x18A42D390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid DLWSXUCROOB
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0xA42F560", Offset = "0xA42E160", VA = "0x18A42F560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid DNMBYETZLOF
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0xA42DB10", Offset = "0xA42C710", VA = "0x18A42DB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid OABVKRTZQOF
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0xA423A10", Offset = "0xA422610", VA = "0x18A423A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid AKTTSAEBBUM
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0xA428E90", Offset = "0xA427A90", VA = "0x18A428E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid WBOHDNQLYCE
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0xA42FAE0", Offset = "0xA42E6E0", VA = "0x18A42FAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid SMVSMOIRADJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0xA42A690", Offset = "0xA429290", VA = "0x18A42A690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid FTYOSODDPPF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0xA42B210", Offset = "0xA429E10", VA = "0x18A42B210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid AWBPZIMDVWQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0xA422F10", Offset = "0xA421B10", VA = "0x18A422F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid YMRRMDDJNEN
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0xA42D790", Offset = "0xA42C390", VA = "0x18A42D790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid NCZAWNXQXRP
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0xA422B10", Offset = "0xA421710", VA = "0x18A422B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid ZAJYKZRDZVQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0xA423410", Offset = "0xA422010", VA = "0x18A423410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid GJUVTZVMEZF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0xA42A310", Offset = "0xA428F10", VA = "0x18A42A310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid PGDJNRGKOFN
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0xA42E210", Offset = "0xA42CE10", VA = "0x18A42E210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid IREANHMLLHP
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0xA422410", Offset = "0xA421010", VA = "0x18A422410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid EEQLFCIOWWV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0xA429F90", Offset = "0xA428B90", VA = "0x18A429F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid MYZQZTFXWQT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0xA42E790", Offset = "0xA42D390", VA = "0x18A42E790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid RTZFEVAJHKS
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0xA428690", Offset = "0xA427290", VA = "0x18A428690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid JLNBZPSVAYA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0xA420110", Offset = "0xA41ED10", VA = "0x18A420110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid XWTBXJCXSZT
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0xA429A90", Offset = "0xA428690", VA = "0x18A429A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid OJDZNACIBJU
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0xA42F2E0", Offset = "0xA42DEE0", VA = "0x18A42F2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid KRKYBXCBONM
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0xA427E90", Offset = "0xA426A90", VA = "0x18A427E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid WIBELTIBVAD
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0xA42E190", Offset = "0xA42CD90", VA = "0x18A42E190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid GXMZCHXQJFK
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0xA423710", Offset = "0xA422310", VA = "0x18A423710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid WFFBEEWLVAA
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0xA42CE10", Offset = "0xA42BA10", VA = "0x18A42CE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid FFYCAOAEAII
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0xA427790", Offset = "0xA426390", VA = "0x18A427790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid SANGSVQSMSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0xA420090", Offset = "0xA41EC90", VA = "0x18A420090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid SRIWIWAPKRW
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0xA421A90", Offset = "0xA420690", VA = "0x18A421A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid ETMWLAKIHTA
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0xA420A90", Offset = "0xA41F690", VA = "0x18A420A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid TTZWXTFHPDV
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0xA429C10", Offset = "0xA428810", VA = "0x18A429C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid KQPOGYVRWWK
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0xA427B10", Offset = "0xA426710", VA = "0x18A427B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid WATPZOHJPDB
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0xA422C90", Offset = "0xA421890", VA = "0x18A422C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid ZLDTHDVOCOJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0xA42B790", Offset = "0xA42A390", VA = "0x18A42B790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid ELRUROGALKT
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0xA42C190", Offset = "0xA42AD90", VA = "0x18A42C190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid UJHWNMCVHDK
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0xA426F90", Offset = "0xA425B90", VA = "0x18A426F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid LDCALZZXTBQ
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0xA428210", Offset = "0xA426E10", VA = "0x18A428210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid HCISPJTFUEQ
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0xA425210", Offset = "0xA423E10", VA = "0x18A425210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid CCBTXQBDAZE
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0xA429690", Offset = "0xA428290", VA = "0x18A429690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid HRVUIHUDTXK
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0xA424590", Offset = "0xA423190", VA = "0x18A424590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid PSAZUAVPNDS
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0xA423F90", Offset = "0xA422B90", VA = "0x18A423F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid TBLSEPQEZLW
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0xA42AD90", Offset = "0xA429990", VA = "0x18A42AD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid VHAHMQQESGY
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0xA423310", Offset = "0xA421F10", VA = "0x18A423310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid BEZTXTEUFGF
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0xA42D590", Offset = "0xA42C190", VA = "0x18A42D590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid ICCDUFVNTTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0xA42CA90", Offset = "0xA42B690", VA = "0x18A42CA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid MPAFOFKIAUC
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0xA427310", Offset = "0xA425F10", VA = "0x18A427310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid RCKZMBRNKMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0xA42AA10", Offset = "0xA429610", VA = "0x18A42AA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid RELJOWDKVQG
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0xA42C010", Offset = "0xA42AC10", VA = "0x18A42C010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid ZLXCVECZWHZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0xA42A590", Offset = "0xA429190", VA = "0x18A42A590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid FLSGPXLMNOI
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0xA424110", Offset = "0xA422D10", VA = "0x18A424110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid HYGDLVMCCTN
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0xA42DD10", Offset = "0xA42C910", VA = "0x18A42DD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid ZWGOZNBLDOH
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0xA426B90", Offset = "0xA425790", VA = "0x18A426B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid SXXEOKYECXJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0xA41F690", Offset = "0xA41E290", VA = "0x18A41F690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid TWMLMQFRWSV
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0xA422790", Offset = "0xA421390", VA = "0x18A422790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid EZJKRGNSSEH
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0xA421E10", Offset = "0xA420A10", VA = "0x18A421E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid UQLZAGAIRDK
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0xA42B910", Offset = "0xA42A510", VA = "0x18A42B910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid PTNZBSYNUJW
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0xA42E810", Offset = "0xA42D410", VA = "0x18A42E810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid HEUHTIAILSS
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0xA421790", Offset = "0xA420390", VA = "0x18A421790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid AZGQIPSBUFV
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0xA426F10", Offset = "0xA425B10", VA = "0x18A426F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid AZOXFHQFTWE
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0xA420390", Offset = "0xA41EF90", VA = "0x18A420390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid WVSVDRYULWL
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0xA425A10", Offset = "0xA424610", VA = "0x18A425A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid GIXRIXLHXMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0xA42C610", Offset = "0xA42B210", VA = "0x18A42C610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid IKVNOOJNHGR
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0xA42A890", Offset = "0xA429490", VA = "0x18A42A890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid BQIUSNFTMZA
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0xA428F90", Offset = "0xA427B90", VA = "0x18A428F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid TFGXWAWJJWV
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0xA424090", Offset = "0xA422C90", VA = "0x18A424090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid DUVWJNHSVWO
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0xA42BE10", Offset = "0xA42AA10", VA = "0x18A42BE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid IZJCPIDWHSS
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0xA424E10", Offset = "0xA423A10", VA = "0x18A424E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid CFBKFPXIWZT
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0xA428710", Offset = "0xA427310", VA = "0x18A428710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid EVMKQWFOHHX
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0xA429910", Offset = "0xA428510", VA = "0x18A429910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid IPDLDZHWQHU
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0xA42AC90", Offset = "0xA429890", VA = "0x18A42AC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid CDCOCROTFAK
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0xA424A10", Offset = "0xA423610", VA = "0x18A424A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid ACXAALPAUJU
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0xA42BD10", Offset = "0xA42A910", VA = "0x18A42BD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid TKEHJCOIDRP
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0xA422610", Offset = "0xA421210", VA = "0x18A422610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid TJDYWUSVIMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0xA422590", Offset = "0xA421190", VA = "0x18A422590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid NMKMHAGFGMA
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0xA423190", Offset = "0xA421D90", VA = "0x18A423190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid UVLIQMGMFQN
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0xA425C10", Offset = "0xA424810", VA = "0x18A425C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid KTUMDJPMXLD
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0xA421A10", Offset = "0xA420610", VA = "0x18A421A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid ZSOWJAVMERQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0xA425890", Offset = "0xA424490", VA = "0x18A425890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid KPKGFZDPTGX
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0xA420210", Offset = "0xA41EE10", VA = "0x18A420210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid DVEERKJOGON
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0xA426610", Offset = "0xA425210", VA = "0x18A426610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid IRFSFPWSMXW
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0xA42FC60", Offset = "0xA42E860", VA = "0x18A42FC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid PRDGONENDHZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0xA424D90", Offset = "0xA423990", VA = "0x18A424D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid QZAHPLHZLPF
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0xA429290", Offset = "0xA427E90", VA = "0x18A429290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid LAPEPYKMNZV
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0xA424F10", Offset = "0xA423B10", VA = "0x18A424F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid KGPMJFCIDZR
				{
					[Cpp2IlInjected.Token(Token = "0x600023C")]
					[Cpp2IlInjected.Address(RVA = "0xA42F7E0", Offset = "0xA42E3E0", VA = "0x18A42F7E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid ZEMEQIUWSNI
				{
					[Cpp2IlInjected.Token(Token = "0x600023D")]
					[Cpp2IlInjected.Address(RVA = "0xA421910", Offset = "0xA420510", VA = "0x18A421910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid FYZPQSCGWGP
				{
					[Cpp2IlInjected.Token(Token = "0x600023E")]
					[Cpp2IlInjected.Address(RVA = "0xA427590", Offset = "0xA426190", VA = "0x18A427590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid XUJWJSPNFOW
				{
					[Cpp2IlInjected.Token(Token = "0x600023F")]
					[Cpp2IlInjected.Address(RVA = "0xA42CF10", Offset = "0xA42BB10", VA = "0x18A42CF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid LADOCSZUPIH
				{
					[Cpp2IlInjected.Token(Token = "0x6000240")]
					[Cpp2IlInjected.Address(RVA = "0xA424F90", Offset = "0xA423B90", VA = "0x18A424F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid USXHYXXIRDI
				{
					[Cpp2IlInjected.Token(Token = "0x6000241")]
					[Cpp2IlInjected.Address(RVA = "0xA426690", Offset = "0xA425290", VA = "0x18A426690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid BRIROVIUCAW
				{
					[Cpp2IlInjected.Token(Token = "0x6000242")]
					[Cpp2IlInjected.Address(RVA = "0xA424A90", Offset = "0xA423690", VA = "0x18A424A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid LXMVMNHCRBY
				{
					[Cpp2IlInjected.Token(Token = "0x6000243")]
					[Cpp2IlInjected.Address(RVA = "0xA42DF10", Offset = "0xA42CB10", VA = "0x18A42DF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid VRUNDPOPBSM
				{
					[Cpp2IlInjected.Token(Token = "0x6000244")]
					[Cpp2IlInjected.Address(RVA = "0xA42C810", Offset = "0xA42B410", VA = "0x18A42C810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid VSAMUVYBDSL
				{
					[Cpp2IlInjected.Token(Token = "0x6000245")]
					[Cpp2IlInjected.Address(RVA = "0xA42F060", Offset = "0xA42DC60", VA = "0x18A42F060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid INFBKRQUBVR
				{
					[Cpp2IlInjected.Token(Token = "0x6000246")]
					[Cpp2IlInjected.Address(RVA = "0xA42BC10", Offset = "0xA42A810", VA = "0x18A42BC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid MCZTVFIIZWG
				{
					[Cpp2IlInjected.Token(Token = "0x6000247")]
					[Cpp2IlInjected.Address(RVA = "0xA427E10", Offset = "0xA426A10", VA = "0x18A427E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid COOMVRRNEBF
				{
					[Cpp2IlInjected.Token(Token = "0x6000248")]
					[Cpp2IlInjected.Address(RVA = "0xA420B90", Offset = "0xA41F790", VA = "0x18A420B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid DFSEYAVJXHW
				{
					[Cpp2IlInjected.Token(Token = "0x6000249")]
					[Cpp2IlInjected.Address(RVA = "0xA423810", Offset = "0xA422410", VA = "0x18A423810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid SVFBOTVZPBT
				{
					[Cpp2IlInjected.Token(Token = "0x600024A")]
					[Cpp2IlInjected.Address(RVA = "0xA42BB10", Offset = "0xA42A710", VA = "0x18A42BB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid NOUZYLXUURR
				{
					[Cpp2IlInjected.Token(Token = "0x600024B")]
					[Cpp2IlInjected.Address(RVA = "0xA42A290", Offset = "0xA428E90", VA = "0x18A42A290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid RAIMWMLTQMI
				{
					[Cpp2IlInjected.Token(Token = "0x600024C")]
					[Cpp2IlInjected.Address(RVA = "0xA427090", Offset = "0xA425C90", VA = "0x18A427090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid TEGGTYDXCXM
				{
					[Cpp2IlInjected.Token(Token = "0x600024D")]
					[Cpp2IlInjected.Address(RVA = "0xA421210", Offset = "0xA41FE10", VA = "0x18A421210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid GVJBSQSVPJJ
				{
					[Cpp2IlInjected.Token(Token = "0x600024E")]
					[Cpp2IlInjected.Address(RVA = "0xA42B890", Offset = "0xA42A490", VA = "0x18A42B890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid AYCSWYTMDEW
				{
					[Cpp2IlInjected.Token(Token = "0x600024F")]
					[Cpp2IlInjected.Address(RVA = "0xA42F5E0", Offset = "0xA42E1E0", VA = "0x18A42F5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid SJHVVOSJJED
				{
					[Cpp2IlInjected.Token(Token = "0x6000250")]
					[Cpp2IlInjected.Address(RVA = "0xA424810", Offset = "0xA423410", VA = "0x18A424810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid NTQMLUZZXPQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000251")]
					[Cpp2IlInjected.Address(RVA = "0xA42F4E0", Offset = "0xA42E0E0", VA = "0x18A42F4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid YBGSOOUGUSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000252")]
					[Cpp2IlInjected.Address(RVA = "0xA420D90", Offset = "0xA41F990", VA = "0x18A420D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid NAOQNCKPIVY
				{
					[Cpp2IlInjected.Token(Token = "0x6000253")]
					[Cpp2IlInjected.Address(RVA = "0xA421E90", Offset = "0xA420A90", VA = "0x18A421E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid BSVRYHIHWRA
				{
					[Cpp2IlInjected.Token(Token = "0x6000254")]
					[Cpp2IlInjected.Address(RVA = "0xA422E10", Offset = "0xA421A10", VA = "0x18A422E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid STCCOJSGCME
				{
					[Cpp2IlInjected.Token(Token = "0x6000255")]
					[Cpp2IlInjected.Address(RVA = "0xA42D810", Offset = "0xA42C410", VA = "0x18A42D810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid FUUWOSVIPSG
				{
					[Cpp2IlInjected.Token(Token = "0x6000256")]
					[Cpp2IlInjected.Address(RVA = "0xA42E510", Offset = "0xA42D110", VA = "0x18A42E510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid QDLSUBFXKLJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000257")]
					[Cpp2IlInjected.Address(RVA = "0xA427F10", Offset = "0xA426B10", VA = "0x18A427F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid ZNPUUPENTGH
				{
					[Cpp2IlInjected.Token(Token = "0x6000258")]
					[Cpp2IlInjected.Address(RVA = "0xA42F9E0", Offset = "0xA42E5E0", VA = "0x18A42F9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid LMPDKBIQVVS
				{
					[Cpp2IlInjected.Token(Token = "0x6000259")]
					[Cpp2IlInjected.Address(RVA = "0xA425F10", Offset = "0xA424B10", VA = "0x18A425F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid MFUABUGCRRC
				{
					[Cpp2IlInjected.Token(Token = "0x600025A")]
					[Cpp2IlInjected.Address(RVA = "0xA42A010", Offset = "0xA428C10", VA = "0x18A42A010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid DSOTCLUSOEL
				{
					[Cpp2IlInjected.Token(Token = "0x600025B")]
					[Cpp2IlInjected.Address(RVA = "0xA421F10", Offset = "0xA420B10", VA = "0x18A421F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid LHPINZZKWEG
				{
					[Cpp2IlInjected.Token(Token = "0x600025C")]
					[Cpp2IlInjected.Address(RVA = "0xA42A810", Offset = "0xA429410", VA = "0x18A42A810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid ZGLVPEMQSVG
				{
					[Cpp2IlInjected.Token(Token = "0x600025D")]
					[Cpp2IlInjected.Address(RVA = "0xA423C90", Offset = "0xA422890", VA = "0x18A423C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid TEKFPOTXFPE
				{
					[Cpp2IlInjected.Token(Token = "0x600025E")]
					[Cpp2IlInjected.Address(RVA = "0xA424390", Offset = "0xA422F90", VA = "0x18A424390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid LXRIYBUUIZI
				{
					[Cpp2IlInjected.Token(Token = "0x600025F")]
					[Cpp2IlInjected.Address(RVA = "0xA429310", Offset = "0xA427F10", VA = "0x18A429310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid HLCGOCAOGQK
				{
					[Cpp2IlInjected.Token(Token = "0x6000260")]
					[Cpp2IlInjected.Address(RVA = "0xA420410", Offset = "0xA41F010", VA = "0x18A420410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid XPLBSJWNXRA
				{
					[Cpp2IlInjected.Token(Token = "0x6000261")]
					[Cpp2IlInjected.Address(RVA = "0xA425390", Offset = "0xA423F90", VA = "0x18A425390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid DXMYVIHPRUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000262")]
					[Cpp2IlInjected.Address(RVA = "0xA42D610", Offset = "0xA42C210", VA = "0x18A42D610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid VFGBLWBBLBK
				{
					[Cpp2IlInjected.Token(Token = "0x6000263")]
					[Cpp2IlInjected.Address(RVA = "0xA421390", Offset = "0xA41FF90", VA = "0x18A421390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid CHQWAXLYLNV
				{
					[Cpp2IlInjected.Token(Token = "0x6000264")]
					[Cpp2IlInjected.Address(RVA = "0xA427910", Offset = "0xA426510", VA = "0x18A427910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid GIHVGKKHWVX
				{
					[Cpp2IlInjected.Token(Token = "0x6000265")]
					[Cpp2IlInjected.Address(RVA = "0xA424010", Offset = "0xA422C10", VA = "0x18A424010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid GLGZRPMVFHP
				{
					[Cpp2IlInjected.Token(Token = "0x6000266")]
					[Cpp2IlInjected.Address(RVA = "0xA425690", Offset = "0xA424290", VA = "0x18A425690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid SCCVBPHVWZF
				{
					[Cpp2IlInjected.Token(Token = "0x6000267")]
					[Cpp2IlInjected.Address(RVA = "0xA42C510", Offset = "0xA42B110", VA = "0x18A42C510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid FXKPJWBUGXC
				{
					[Cpp2IlInjected.Token(Token = "0x6000268")]
					[Cpp2IlInjected.Address(RVA = "0xA421D90", Offset = "0xA420990", VA = "0x18A421D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid TYQRWECGEPR
				{
					[Cpp2IlInjected.Token(Token = "0x6000269")]
					[Cpp2IlInjected.Address(RVA = "0xA427C10", Offset = "0xA426810", VA = "0x18A427C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid HUEAHIACCCQ
				{
					[Cpp2IlInjected.Token(Token = "0x600026A")]
					[Cpp2IlInjected.Address(RVA = "0xA42EEE0", Offset = "0xA42DAE0", VA = "0x18A42EEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid RKBVAWZNNCN
				{
					[Cpp2IlInjected.Token(Token = "0x600026B")]
					[Cpp2IlInjected.Address(RVA = "0xA42F960", Offset = "0xA42E560", VA = "0x18A42F960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid EVMFURKXBUH
				{
					[Cpp2IlInjected.Token(Token = "0x600026C")]
					[Cpp2IlInjected.Address(RVA = "0xA426790", Offset = "0xA425390", VA = "0x18A426790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid LIQRHMTDHGB
				{
					[Cpp2IlInjected.Token(Token = "0x600026D")]
					[Cpp2IlInjected.Address(RVA = "0xA423D90", Offset = "0xA422990", VA = "0x18A423D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid XMVMIEIWBYC
				{
					[Cpp2IlInjected.Token(Token = "0x600026E")]
					[Cpp2IlInjected.Address(RVA = "0xA42B690", Offset = "0xA42A290", VA = "0x18A42B690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid LFTKFZVBLOP
				{
					[Cpp2IlInjected.Token(Token = "0x600026F")]
					[Cpp2IlInjected.Address(RVA = "0xA41F710", Offset = "0xA41E310", VA = "0x18A41F710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid PJZPVNQCNLI
				{
					[Cpp2IlInjected.Token(Token = "0x6000270")]
					[Cpp2IlInjected.Address(RVA = "0xA428090", Offset = "0xA426C90", VA = "0x18A428090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid IHKOWITNIWB
				{
					[Cpp2IlInjected.Token(Token = "0x6000271")]
					[Cpp2IlInjected.Address(RVA = "0xA42DE90", Offset = "0xA42CA90", VA = "0x18A42DE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid EDAQOJHTEOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000272")]
					[Cpp2IlInjected.Address(RVA = "0xA422190", Offset = "0xA420D90", VA = "0x18A422190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid SVYMXTAURLL
				{
					[Cpp2IlInjected.Token(Token = "0x6000273")]
					[Cpp2IlInjected.Address(RVA = "0xA426010", Offset = "0xA424C10", VA = "0x18A426010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid WMCAHHMEMYY
				{
					[Cpp2IlInjected.Token(Token = "0x6000274")]
					[Cpp2IlInjected.Address(RVA = "0xA420B10", Offset = "0xA41F710", VA = "0x18A420B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid NTMAVXPPIDV
				{
					[Cpp2IlInjected.Token(Token = "0x6000275")]
					[Cpp2IlInjected.Address(RVA = "0xA42CC10", Offset = "0xA42B810", VA = "0x18A42CC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid ROUAHNEQLFC
				{
					[Cpp2IlInjected.Token(Token = "0x6000276")]
					[Cpp2IlInjected.Address(RVA = "0xA427210", Offset = "0xA425E10", VA = "0x18A427210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid WZZQXGYVXDF
				{
					[Cpp2IlInjected.Token(Token = "0x6000277")]
					[Cpp2IlInjected.Address(RVA = "0xA42A410", Offset = "0xA429010", VA = "0x18A42A410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid PMUJJASOMSF
				{
					[Cpp2IlInjected.Token(Token = "0x6000278")]
					[Cpp2IlInjected.Address(RVA = "0xA421610", Offset = "0xA420210", VA = "0x18A421610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid TZRAZISBSAN
				{
					[Cpp2IlInjected.Token(Token = "0x6000279")]
					[Cpp2IlInjected.Address(RVA = "0xA42BF90", Offset = "0xA42AB90", VA = "0x18A42BF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid GWOPBNRHUMB
				{
					[Cpp2IlInjected.Token(Token = "0x600027A")]
					[Cpp2IlInjected.Address(RVA = "0xA420E90", Offset = "0xA41FA90", VA = "0x18A420E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid WDSVAHQHUOT
				{
					[Cpp2IlInjected.Token(Token = "0x600027B")]
					[Cpp2IlInjected.Address(RVA = "0xA420D10", Offset = "0xA41F910", VA = "0x18A420D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid YASCTCJBBEZ
				{
					[Cpp2IlInjected.Token(Token = "0x600027C")]
					[Cpp2IlInjected.Address(RVA = "0xA42E490", Offset = "0xA42D090", VA = "0x18A42E490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid DXOCSCOEFEE
				{
					[Cpp2IlInjected.Token(Token = "0x600027D")]
					[Cpp2IlInjected.Address(RVA = "0xA421510", Offset = "0xA420110", VA = "0x18A421510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid WULRJJJNJXF
				{
					[Cpp2IlInjected.Token(Token = "0x600027E")]
					[Cpp2IlInjected.Address(RVA = "0xA42B310", Offset = "0xA429F10", VA = "0x18A42B310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid GGDCZDSNFDU
				{
					[Cpp2IlInjected.Token(Token = "0x600027F")]
					[Cpp2IlInjected.Address(RVA = "0xA421690", Offset = "0xA420290", VA = "0x18A421690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid UGOCMZOXHZW
				{
					[Cpp2IlInjected.Token(Token = "0x6000280")]
					[Cpp2IlInjected.Address(RVA = "0xA42F260", Offset = "0xA42DE60", VA = "0x18A42F260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid OKYGZSQTHZP
				{
					[Cpp2IlInjected.Token(Token = "0x6000281")]
					[Cpp2IlInjected.Address(RVA = "0xA42D290", Offset = "0xA42BE90", VA = "0x18A42D290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid VZJGGFLFJCM
				{
					[Cpp2IlInjected.Token(Token = "0x6000282")]
					[Cpp2IlInjected.Address(RVA = "0xA42FA60", Offset = "0xA42E660", VA = "0x18A42FA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid VEKLVYFVLCY
				{
					[Cpp2IlInjected.Token(Token = "0x6000283")]
					[Cpp2IlInjected.Address(RVA = "0xA42A090", Offset = "0xA428C90", VA = "0x18A42A090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid SLFESUJZNHR
				{
					[Cpp2IlInjected.Token(Token = "0x6000284")]
					[Cpp2IlInjected.Address(RVA = "0xA429B10", Offset = "0xA428710", VA = "0x18A429B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid JAENZQGEHZV
				{
					[Cpp2IlInjected.Token(Token = "0x6000285")]
					[Cpp2IlInjected.Address(RVA = "0xA422E90", Offset = "0xA421A90", VA = "0x18A422E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid XRMRHSNDXQI
				{
					[Cpp2IlInjected.Token(Token = "0x6000286")]
					[Cpp2IlInjected.Address(RVA = "0xA429110", Offset = "0xA427D10", VA = "0x18A429110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid YSYMAFJQFEV
				{
					[Cpp2IlInjected.Token(Token = "0x6000287")]
					[Cpp2IlInjected.Address(RVA = "0xA429190", Offset = "0xA427D90", VA = "0x18A429190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid NSIGPNQGHGR
				{
					[Cpp2IlInjected.Token(Token = "0x6000288")]
					[Cpp2IlInjected.Address(RVA = "0xA426890", Offset = "0xA425490", VA = "0x18A426890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid YFQATHQOPLB
				{
					[Cpp2IlInjected.Token(Token = "0x6000289")]
					[Cpp2IlInjected.Address(RVA = "0xA424210", Offset = "0xA422E10", VA = "0x18A424210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid EEPEIFNGHOS
				{
					[Cpp2IlInjected.Token(Token = "0x600028A")]
					[Cpp2IlInjected.Address(RVA = "0xA42B710", Offset = "0xA42A310", VA = "0x18A42B710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid XZAWWVXBDCU
				{
					[Cpp2IlInjected.Token(Token = "0x600028B")]
					[Cpp2IlInjected.Address(RVA = "0xA420290", Offset = "0xA41EE90", VA = "0x18A420290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid SXZBJRFUVGP
				{
					[Cpp2IlInjected.Token(Token = "0x600028C")]
					[Cpp2IlInjected.Address(RVA = "0xA422D90", Offset = "0xA421990", VA = "0x18A422D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid TEHVBFEUZFD
				{
					[Cpp2IlInjected.Token(Token = "0x600028D")]
					[Cpp2IlInjected.Address(RVA = "0xA42EC90", Offset = "0xA42D890", VA = "0x18A42EC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid ZOLHPODXXLM
				{
					[Cpp2IlInjected.Token(Token = "0x600028E")]
					[Cpp2IlInjected.Address(RVA = "0xA420610", Offset = "0xA41F210", VA = "0x18A420610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid FNQRCVAOKVI
				{
					[Cpp2IlInjected.Token(Token = "0x600028F")]
					[Cpp2IlInjected.Address(RVA = "0xA428990", Offset = "0xA427590", VA = "0x18A428990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid FNLKFOGRBJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000290")]
					[Cpp2IlInjected.Address(RVA = "0xA428910", Offset = "0xA427510", VA = "0x18A428910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid EOSUCPOJUQE
				{
					[Cpp2IlInjected.Token(Token = "0x6000291")]
					[Cpp2IlInjected.Address(RVA = "0xA422A90", Offset = "0xA421690", VA = "0x18A422A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid UGGKPGQMENX
				{
					[Cpp2IlInjected.Token(Token = "0x6000292")]
					[Cpp2IlInjected.Address(RVA = "0xA42EFE0", Offset = "0xA42DBE0", VA = "0x18A42EFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid PMWRKTWUUAX
				{
					[Cpp2IlInjected.Token(Token = "0x6000293")]
					[Cpp2IlInjected.Address(RVA = "0xA422810", Offset = "0xA421410", VA = "0x18A422810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid LHQCGFQGOOD
				{
					[Cpp2IlInjected.Token(Token = "0x6000294")]
					[Cpp2IlInjected.Address(RVA = "0xA42DC90", Offset = "0xA42C890", VA = "0x18A42DC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid NLRONFMYTHK
				{
					[Cpp2IlInjected.Token(Token = "0x6000295")]
					[Cpp2IlInjected.Address(RVA = "0xA423990", Offset = "0xA422590", VA = "0x18A423990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid FYFJNXCCWLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000296")]
					[Cpp2IlInjected.Address(RVA = "0xA42C990", Offset = "0xA42B590", VA = "0x18A42C990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid RPJZGVQTLYO
				{
					[Cpp2IlInjected.Token(Token = "0x6000297")]
					[Cpp2IlInjected.Address(RVA = "0xA420010", Offset = "0xA41EC10", VA = "0x18A420010")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA443200", Offset = "0xA441E00", VA = "0x18A443200")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA4336C0", Offset = "0xA4322C0", VA = "0x18A4336C0")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> LYYMJEYKFYK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class ONTPVFFHOIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA433280", Offset = "0xA431E80", VA = "0x18A433280")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class UTKBMHIDZRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xA445CF0", Offset = "0xA4448F0", VA = "0x18A445CF0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class BSFWJQTEILN
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA41F360", Offset = "0xA41DF60", VA = "0x18A41F360")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class JPDJZNVXHDW
		{
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private static readonly Dictionary<Guid, float> VSLYSUSLJZC;

			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private static readonly Dictionary<Guid, float> UQUVFUGMQFP;

			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private static readonly Dictionary<Guid, bool> PKZPNKWITNQ;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA430CE0", Offset = "0xA42F8E0", VA = "0x18A430CE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class JPIQWUPUQPF
		{
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			private static readonly Dictionary<Guid, float> AKSDFAUBCGN;

			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private static readonly Dictionary<Guid, float> YIODKPNZWKI;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA4465C0", Offset = "0xA4451C0", VA = "0x18A4465C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class UWQKSFVGNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA44BB80", Offset = "0xA44A780", VA = "0x18A44BB80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class QKNRRMGQLNF
		{
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			private static readonly Dictionary<Guid, int> OVHIYZBWFWT;

			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private static readonly Dictionary<Guid, bool> QTRXVVFUPJJ;

			[Cpp2IlInjected.Token(Token = "0x400024D")]
			private static readonly Dictionary<Guid, bool> MMTEXBKLWPG;

			[Cpp2IlInjected.Token(Token = "0x400024E")]
			private static readonly Dictionary<Guid, int> EWREZJUHHMY;

			[Cpp2IlInjected.Token(Token = "0x400024F")]
			private static readonly Dictionary<Guid, bool> NGWXXVDIJPN;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xA448020", Offset = "0xA446C20", VA = "0x18A448020")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class QKYFLZULEJX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA44AC70", Offset = "0xA449870", VA = "0x18A44AC70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static Versioner<ODRSNXNZSZX, PersistedRoomData, PersistedRoomVersion> JJNDANUWJHK;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Dictionary<Guid, int> RDWKEISVUWD;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Guid EOWJGZLSJSB;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Guid IXLOEIOQLRJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly float TUDVLAGLXCD;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA409610", Offset = "0xA408210", VA = "0x18A409610")]
		public static PersistedRoomData EFBOKNIETKQ(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA409AF0", Offset = "0xA4086F0", VA = "0x18A409AF0")]
		public static Result<ParseResult<PersistedRoomData>, ARGBUOZFZQD> RLNHJIOIZPI(ODRSNXNZSZX a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA409810", Offset = "0xA408410", VA = "0x18A409810")]
		public static Result<ParseResult<PersistedRoomData>, ARGBUOZFZQD> RLNHJIOIZPI(ODRSNXNZSZX a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA409C20", Offset = "0xA408820", VA = "0x18A409C20")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(ODRSNXNZSZX a, PersistedRoomData b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA409730", Offset = "0xA408330", VA = "0x18A409730")]
		public static Guid RGADZQVNRXK(NEAYWMKOJYN a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class XJGTVTFFDCU
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public interface ODRSNXNZSZX : RUTHEOBVTPD<WTDQFLYTVGY, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public sealed class BLFMBBVUXNY : ODRSNXNZSZX, RUTHEOBVTPD<WTDQFLYTVGY, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public static BLFMBBVUXNY UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			public PlayerSaveVersion ACVLFZSZWVF()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xD5A490", Offset = "0xD59090", VA = "0x180D5A490", Slot = "5")]
			public PlayerSaveVersion GEBZVVUQQHD()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1ADE980", Offset = "0x1ADD580", VA = "0x181ADE980", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D810", Offset = "0x2F0C410", VA = "0x182F0D810", Slot = "7")]
			public bool MOPWVVXHTLU(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA4463E0", Offset = "0xA444FE0", VA = "0x18A4463E0", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BLFMBBVUXNY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static Versioner<ODRSNXNZSZX, WTDQFLYTVGY, PlayerSaveVersion> JJNDANUWJHK;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA44D440", Offset = "0xA44C040", VA = "0x18A44D440")]
		public static WTDQFLYTVGY? KKBNQNRFWVQ([Optional] JACVVTKMTIS? a, [Optional] FPGHXDMSUDY? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA44DA80", Offset = "0xA44C680", VA = "0x18A44DA80")]
		public static Result<ParseResult<WTDQFLYTVGY>, ARGBUOZFZQD> RLNHJIOIZPI(ODRSNXNZSZX a, byte[]? bytes)
		{
			return default(Result<ParseResult<WTDQFLYTVGY>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA44D600", Offset = "0xA44C200", VA = "0x18A44D600")]
		public static Result<ParseResult<WTDQFLYTVGY>, ARGBUOZFZQD> RLNHJIOIZPI(ODRSNXNZSZX deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<WTDQFLYTVGY>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA44EAB0", Offset = "0xA44D6B0", VA = "0x18A44EAB0")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(ODRSNXNZSZX a, WTDQFLYTVGY b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA44E310", Offset = "0xA44CF10", VA = "0x18A44E310")]
		public static void UVAHODSBQCN(WTDQFLYTVGY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA44DC30", Offset = "0xA44C830", VA = "0x18A44DC30")]
		public static void UUKMWJKJNUM(WTDQFLYTVGY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA44DE70", Offset = "0xA44CA70", VA = "0x18A44DE70")]
		public static void UUPTTQEGXFV(WTDQFLYTVGY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA44E610", Offset = "0xA44D210", VA = "0x18A44E610")]
		public static void UVQCFXZTSKO(WTDQFLYTVGY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA44E740", Offset = "0xA44D340", VA = "0x18A44E740")]
		public static void UVVJDETRBVX(WTDQFLYTVGY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA44D280", Offset = "0xA44BE80", VA = "0x18A44D280")]
		private static FPGHXDMSUDY HXEOLYLYOKY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA44D360", Offset = "0xA44BF60", VA = "0x18A44D360")]
		private static FPGHXDMSUDY HXJVJFFVXWH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA44D110", Offset = "0xA44BD10", VA = "0x18A44D110")]
		[CompilerGenerated]
		internal static bool ENMPHIZYDQL(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA44D0A0", Offset = "0xA44BCA0", VA = "0x18A44D0A0")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF CKHLPUTXCKV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA44D5D0", Offset = "0xA44C1D0", VA = "0x18A44D5D0")]
		[CompilerGenerated]
		internal static float OFWJZQEDIKJ(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA44D140", Offset = "0xA44BD40", VA = "0x18A44D140")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF GIWORDSFTAF(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA44E820", Offset = "0xA44D420", VA = "0x18A44E820")]
		[CompilerGenerated]
		internal static int VQHDPUWCJRG(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA44E7B0", Offset = "0xA44D3B0", VA = "0x18A44E7B0")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF VIUUAIHSNOY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA44D1B0", Offset = "0xA44BDB0", VA = "0x18A44D1B0")]
		[CompilerGenerated]
		internal static CircuitsQuat HLKNLCBHTTH(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA44DBB0", Offset = "0xA44C7B0", VA = "0x18A44DBB0")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF TODFXOCFXQT(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA44D530", Offset = "0xA44C130", VA = "0x18A44D530")]
		[CompilerGenerated]
		internal static string NRARDZQVSOG(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA44E9A0", Offset = "0xA44D5A0", VA = "0x18A44E9A0")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF WWMNYCAUPTK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA44E8C0", Offset = "0xA44D4C0", VA = "0x18A44E8C0")]
		[CompilerGenerated]
		internal static CircuitsVec3 WALLSZNWLMS(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA44D550", Offset = "0xA44C150", VA = "0x18A44D550")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF ODZLFKOVEBK(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA44E850", Offset = "0xA44D450", VA = "0x18A44E850")]
		[CompilerGenerated]
		internal static int VZPHWYSGJDD(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA44EA10", Offset = "0xA44D610", VA = "0x18A44EA10")]
		[CompilerGenerated]
		internal static JNFXEWUIKCF YTROFGZIMZZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x4124810", Offset = "0x4123410", VA = "0x184124810")]
		[CompilerGenerated]
		internal static void PPYVFKZWEGX<a>(RepeatedField<EEZEBYQKXXM> a, Func<ByteString, a> deserialize, Func<a, JNFXEWUIKCF> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class KISLCONYPJU
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA447A60", Offset = "0xA446660", VA = "0x18A447A60")]
		public static RJICLNCWEES FXMWKIDCMSY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA447AB0", Offset = "0xA4466B0", VA = "0x18A447AB0")]
		public static Result<ParseResult<RJICLNCWEES>, ARGBUOZFZQD> RLNHJIOIZPI(UGLZPJDMMOS.ODRSNXNZSZX a, byte[] b)
		{
			return default(Result<ParseResult<RJICLNCWEES>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA447BA0", Offset = "0xA4467A0", VA = "0x18A447BA0")]
		public static Result<ParseResult<RJICLNCWEES>, ARGBUOZFZQD> RLNHJIOIZPI(UGLZPJDMMOS.ODRSNXNZSZX a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<RJICLNCWEES>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA447EF0", Offset = "0xA446AF0", VA = "0x18A447EF0")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(UGLZPJDMMOS.ODRSNXNZSZX a, RJICLNCWEES b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class QYCCEOHXKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA44AE30", Offset = "0xA449A30", VA = "0x18A44AE30")]
		public static SpawnableTemplateData AWPJWYHDCPV([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA44B270", Offset = "0xA449E70", VA = "0x18A44B270")]
		public static Result<ParseResult<SpawnableTemplateData>, ARGBUOZFZQD> RLNHJIOIZPI(UGLZPJDMMOS.ODRSNXNZSZX a, WUHUXRTVADK.ODRSNXNZSZX b, byte[] c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA44B370", Offset = "0xA449F70", VA = "0x18A44B370")]
		public static Result<ParseResult<SpawnableTemplateData>, ARGBUOZFZQD> RLNHJIOIZPI(UGLZPJDMMOS.ODRSNXNZSZX a, WUHUXRTVADK.ODRSNXNZSZX b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA44B830", Offset = "0xA44A430", VA = "0x18A44B830")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(UGLZPJDMMOS.ODRSNXNZSZX a, WUHUXRTVADK.ODRSNXNZSZX b, SpawnableTemplateData c)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA44AEB0", Offset = "0xA449AB0", VA = "0x18A44AEB0")]
		private static Result<None, ARGBUOZFZQD> GMWJXJSLWCP(UGLZPJDMMOS.ODRSNXNZSZX a, SpawnableTemplateData b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA44B690", Offset = "0xA44A290", VA = "0x18A44B690")]
		private static Result<None, ARGBUOZFZQD> YYTKTTZKJWR(WUHUXRTVADK.ODRSNXNZSZX a, SpawnableTemplateData b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class WUHUXRTVADK
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public interface ODRSNXNZSZX : RUTHEOBVTPD<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class BLFMBBVUXNY : ODRSNXNZSZX, RUTHEOBVTPD<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public static BLFMBBVUXNY UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			public SuperRoomVersion ACVLFZSZWVF()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "5")]
			public SuperRoomVersion GEBZVVUQQHD()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1ADE980", Offset = "0x1ADD580", VA = "0x181ADE980", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2F0D810", Offset = "0x2F0C410", VA = "0x182F0D810", Slot = "7")]
			public bool MOPWVVXHTLU(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA446390", Offset = "0xA444F90", VA = "0x18A446390", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BLFMBBVUXNY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static Versioner<ODRSNXNZSZX, SuperRoomData, SuperRoomVersion> JJNDANUWJHK;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA44C5B0", Offset = "0xA44B1B0", VA = "0x18A44C5B0")]
		public static SuperRoomData SHQFCXALZRE([Optional] PEQSNSQIFAU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA44C1B0", Offset = "0xA44ADB0", VA = "0x18A44C1B0")]
		public static Result<ParseResult<SuperRoomData>, ARGBUOZFZQD> RLNHJIOIZPI(ODRSNXNZSZX a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA44C2E0", Offset = "0xA44AEE0", VA = "0x18A44C2E0")]
		public static Result<ParseResult<SuperRoomData>, ARGBUOZFZQD> RLNHJIOIZPI(ODRSNXNZSZX a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA44CDA0", Offset = "0xA44B9A0", VA = "0x18A44CDA0")]
		public static Result<None, ARGBUOZFZQD> ZPKDQIXIKEP(ODRSNXNZSZX a, SuperRoomData b)
		{
			return default(Result<None, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA44CB60", Offset = "0xA44B760", VA = "0x18A44CB60")]
		private static void UVAHODSBQCN(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA44C9D0", Offset = "0xA44B5D0", VA = "0x18A44C9D0")]
		private static void UUKMWJKJNUM(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA44CAD0", Offset = "0xA44B6D0", VA = "0x18A44CAD0")]
		private static void UUPTTQEGXFV(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA44CD20", Offset = "0xA44B920", VA = "0x18A44CD20")]
		private static void UVQCFXZTSKO(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA44C6B0", Offset = "0xA44B2B0", VA = "0x18A44C6B0")]
		public static DataTableData UROXVQIEDCR(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA44BFA0", Offset = "0xA44ABA0", VA = "0x18A44BFA0")]
		public static ProgressionManagerData PIXIBSFOIFE(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA44BDF0", Offset = "0xA44A9F0", VA = "0x18A44BDF0")]
		[CompilerGenerated]
		internal static void OJTSTICKMTS(RepeatedField<WAAZVTVDGZS> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class AAGTTBSWTEQ : YQNKYWZXWXV
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA446230", Offset = "0xA444E30", VA = "0x18A446230", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E40", Offset = "0x2BA7A40", VA = "0x182BA8E40")]
		public AAGTTBSWTEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface RUTHEOBVTPD<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b ACVLFZSZWVF();

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b GEBZVVUQQHD();

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MOPWVVXHTLU(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class IXJNYNRQGWE : YQNKYWZXWXV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private string IGHXXOACESD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private string YJKSCOEAAAT;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA446570", Offset = "0xA445170", VA = "0x18A446570")]
		public IXJNYNRQGWE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA446510", Offset = "0xA445110", VA = "0x18A446510", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct ParseResult<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public readonly bool IsNew;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x73C0E70", Offset = "0x73BFA70", VA = "0x1873C0E70")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class ZMIMVWARKNU
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x4134E60", Offset = "0x4133A60", VA = "0x184134E60")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class NNRKLQUAUHV : YQNKYWZXWXV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private string IGHXXOACESD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private string YJKSCOEAAAT;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA446570", Offset = "0xA445170", VA = "0x18A446570")]
		public NNRKLQUAUHV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA447FC0", Offset = "0xA446BC0", VA = "0x18A447FC0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA44BD40", Offset = "0xA44A940", VA = "0x18A44BD40")]
		public static Guid? EHBQETORHDR(YMQXVRQNJLQ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : RUTHEOBVTPD<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8439F30", Offset = "0x8438B30", VA = "0x188439F30")]
		public Result<TVersion, ARGBUOZFZQD> ZPKDQIXIKEP(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8439DB0", Offset = "0x84389B0", VA = "0x188439DB0")]
		public static VersionerFactory<TDeps, TData, TVersion> SIUHUEYRRON()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public VersioningPhaseVoidDelegate<TDeps, TData> JIADZIOEATJ;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x763BCE0", Offset = "0x763A8E0", VA = "0x18763BCE0")]
			internal Result<None, ARGBUOZFZQD> HPEFNQRRZLJ(TDeps a, TData b)
			{
				return default(Result<None, ARGBUOZFZQD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public VersioningPhaseVoidDelegate<TData> JIADZIOEATJ;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x5126160", Offset = "0x5124D60", VA = "0x185126160")]
			internal Result<None, ARGBUOZFZQD> HPEFNQRRZLJ(TDeps a, TData b)
			{
				return default(Result<None, ARGBUOZFZQD>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8439710", Offset = "0x8438310", VA = "0x188439710")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8439840", Offset = "0x8438440", VA = "0x188439840")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84399B0", Offset = "0x84385B0", VA = "0x1884399B0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class WRMVPABXFXF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x3367AF0", Offset = "0x33666F0", VA = "0x183367AF0")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : RUTHEOBVTPD<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class ABPCDVLEOWQ : YQNKYWZXWXV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly Exception JUPKQSIWDNX;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B36560", Offset = "0x1B35160", VA = "0x181B36560")]
		public ABPCDVLEOWQ(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA446360", Offset = "0xA444F60", VA = "0x18A446360", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA446260", Offset = "0xA444E60", VA = "0x18A446260", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class YQNKYWZXWXV : ARGBUOZFZQD
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E40", Offset = "0x2BA7A40", VA = "0x182BA8E40")]
		protected YQNKYWZXWXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate Result<None, ARGBUOZFZQD> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void VersioningPhaseVoidDelegate<TData>(TData data);
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate void VersioningPhaseVoidDelegate<TDeps, TData>(TDeps deps, TData data);
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
