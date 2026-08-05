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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA335810", Offset = "0xA334C10", VA = "0x18A335810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HJBLJFFMFID
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface TVWXLXTXIIP : XQBBWHWJDSP<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool WUDQYLQFYGF(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int KXYSFNTRGBA(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			BPPVSWJBWSW NLZEWPZFVDW(TransformData a, BPPVSWJBWSW b);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			float? YRUVWPUQFNV(int a);

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			int VERGWVYYSZY(int a);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			float TSZAQKJKBPJ(int a);

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void QXUKQGMUMUH(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			OFZZDEODIOB EBKVXUMWCLF();
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public abstract class TLGMPNEBIBW : TVWXLXTXIIP, XQBBWHWJDSP<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "12")]
			public DEPRECATED_RoomPersistenceVersion FPWGPTAFBFH()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA34A070", Offset = "0xA349470", VA = "0x18A34A070", Slot = "13")]
			public DEPRECATED_RoomPersistenceVersion CHWBOBYGKCX()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1AE4550", Offset = "0x1AE3950", VA = "0x181AE4550", Slot = "14")]
			public DEPRECATED_RoomPersistenceVersion Increment(DEPRECATED_RoomPersistenceVersion version)
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E6B0", Offset = "0x2F0DAB0", VA = "0x182F0E6B0", Slot = "15")]
			public bool WLQARKELXXK(DEPRECATED_RoomPersistenceVersion a, DEPRECATED_RoomPersistenceVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA34A160", Offset = "0xA349560", VA = "0x18A34A160", Slot = "16")]
			public string ToString(DEPRECATED_RoomPersistenceVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "17")]
			public abstract bool WUDQYLQFYGF(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "18")]
			public abstract int KXYSFNTRGBA(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA34A090", Offset = "0xA349490", VA = "0x18A34A090", Slot = "6")]
			public BPPVSWJBWSW NLZEWPZFVDW(TransformData a, BPPVSWJBWSW b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "19")]
			public abstract float? YRUVWPUQFNV(int a);

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "20")]
			public abstract int VERGWVYYSZY(int a);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "21")]
			public abstract float TSZAQKJKBPJ(int a);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			public abstract void QXUKQGMUMUH(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			public abstract OFZZDEODIOB EBKVXUMWCLF();

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			protected TLGMPNEBIBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class QVGBIONPSNI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class XYZTREZOBRL
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly string MAVAOMNZGFL;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static readonly string IDTYGZYLXGU;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private static readonly string GICPVBZPDLN;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private static readonly string FOYTYEGPWGR;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private static readonly string LBVGUHOXXBX;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static readonly string NNIPBUGZHUW;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly string[] CNXRIKBZBIL;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private static readonly string[] CGTNRQFXMKB;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA34B0D0", Offset = "0xA34A4D0", VA = "0x18A34B0D0")]
			public static void Run(TVWXLXTXIIP deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA34B540", Offset = "0xA34A940", VA = "0x18A34B540")]
			private static void WUYQAAFPQED(PersistedRoomData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA34B310", Offset = "0xA34A710", VA = "0x18A34B310")]
			private static void TBFQPBINQPQ(PersistedRoomData a, Func<ZUPHRVQDGUY, NLYPSGQYUDR> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA34C110", Offset = "0xA34B510", VA = "0x18A34C110")]
			private static ZUPHRVQDGUY YHAWGKJRDBH(PersistedRoomData a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA34C330", Offset = "0xA34B730", VA = "0x18A34C330")]
			private static void ZWUGGQEHJTF(PersistedRoomData a, string b, Func<ZUPHRVQDGUY, NLYPSGQYUDR> c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA34B270", Offset = "0xA34A670", VA = "0x18A34B270")]
			private static void SMILHMXSMSA(PersistedRoomData a, string b, Func<ZUPHRVQDGUY, YHVZJYSLWNC> c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA34AF90", Offset = "0xA34A390", VA = "0x18A34AF90")]
			private static void GEZKEVBMBKP(PersistedRoomData a, string b, Func<ZUPHRVQDGUY, NLYPSGQYUDR> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA34AEF0", Offset = "0xA34A2F0", VA = "0x18A34AEF0")]
			private static void GEZKEVBMBKP(PersistedRoomData a, string b, Func<ZUPHRVQDGUY, YHVZJYSLWNC> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA34B030", Offset = "0xA34A430", VA = "0x18A34B030")]
			private static void RCPXVZJVWIU(PersistedRoomData a, string b, Func<ZUPHRVQDGUY, NLYPSGQYUDR> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class XYUMTYFQSGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA34AB10", Offset = "0xA349F10", VA = "0x18A34AB10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class XYPFWRLTIUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA34A940", Offset = "0xA349D40", VA = "0x18A34A940")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class XZUVGGBDNKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA34D0F0", Offset = "0xA34C4F0", VA = "0x18A34D0F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class XZPOIZHGDZM
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Guid IEKQFGAGIGO;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private static readonly ByteString ZPCMUUPVPAI;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA34CCE0", Offset = "0xA34C0E0", VA = "0x18A34CCE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class XZKHLSNIUOD
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private static readonly Guid JLEGRWUFORO;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA34C980", Offset = "0xA34BD80", VA = "0x18A34C980")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class XZFAOLTLLCU
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA34C7C0", Offset = "0xA34BBC0", VA = "0x18A34C7C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class YAPWVHCSZEF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA34DC00", Offset = "0xA34D000", VA = "0x18A34DC00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class YAKPYAIVPSW
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private static readonly Guid BXCMUGJNTPO;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private static readonly Guid WXZURDPNRDG;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static readonly Guid RTRILHYARYI;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA34D390", Offset = "0xA34C790", VA = "0x18A34D390")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class QJUXDDLVLDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA3486D0", Offset = "0xA347AD0", VA = "0x18A3486D0")]
			public static void Run(TVWXLXTXIIP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class DZTACPIQFNM
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly Guid VFLADWQUWXM;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static readonly Guid XQREENWQJVY;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly Dictionary<int, Guid> WBATKCVWXRM;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA330760", Offset = "0xA32FB60", VA = "0x18A330760")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class DZYGZWCNOYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA331110", Offset = "0xA330510", VA = "0x18A331110")]
			public static void Run(TVWXLXTXIIP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class DZNTFIOSWCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA3303C0", Offset = "0xA32F7C0", VA = "0x18A3303C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class DYXYNOHATUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class DZDFKVAYDFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA330170", Offset = "0xA32F570", VA = "0x18A330170")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class DYNKTATGAXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class DYSRQHNDKIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA32FF80", Offset = "0xA32F380", VA = "0x18A32FF80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class EBJDGRLVDAG
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly Guid IOXQNIIUILQ;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA3313F0", Offset = "0xA3307F0", VA = "0x18A3313F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class EBOKDYFSMLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA331C60", Offset = "0xA331060", VA = "0x18A331C60")]
			public static void Run(TVWXLXTXIIP deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA3321B0", Offset = "0xA3315B0", VA = "0x18A3321B0")]
			private static quaternion VVBMEEALMWL(BPPVSWJBWSW a)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA332260", Offset = "0xA331660", VA = "0x18A332260")]
			private static BPPVSWJBWSW YTSGSNHRQSS(TVWXLXTXIIP a, float3 b, quaternion c, int d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA331710", Offset = "0xA330B10", VA = "0x18A331710")]
			private static BPPVSWJBWSW ICOIRUEWSFU(TVWXLXTXIIP a, float3 b, quaternion c, int d, bool e)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class LAKFBHQSVFV
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA334D50", Offset = "0xA334150", VA = "0x18A334D50")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class LAEYEAWVLUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA334B80", Offset = "0xA333F80", VA = "0x18A334B80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class LAPLYOKQERE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA334F80", Offset = "0xA334380", VA = "0x18A334F80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class LBFGQISIGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA3353C0", Offset = "0xA3347C0", VA = "0x18A3353C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class LAZZTBYKXNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA335170", Offset = "0xA334570", VA = "0x18A335170")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class LBPUKWGCZVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class LBKNNPMFQKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA335580", Offset = "0xA334980", VA = "0x18A335580")]
			public static void Run(TVWXLXTXIIP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class KYUBXFNNXTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA3349B0", Offset = "0xA333DB0", VA = "0x18A3349B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class QKFKXQZQDZW
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static readonly Guid OJSATZXLMZC;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static readonly Guid FZWXMHWUBHF;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static readonly Guid XISUGWIMDSG;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static readonly Guid IOXQNIIUILQ;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static readonly Guid RDQKOXMDAHR;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly Guid OJOTZLDREJD;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static readonly Guid ZKCYDECFOPK;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA349040", Offset = "0xA348440", VA = "0x18A349040")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA348D70", Offset = "0xA348170", VA = "0x18A348D70")]
			private static RMLXMXCDWBY KKZKBEDPJUX(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA348CD0", Offset = "0xA3480D0", VA = "0x18A348CD0")]
			private static RMLXMXCDWBY IBNALTPUGWV(Guid a, bool b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA3492F0", Offset = "0xA3486F0", VA = "0x18A3492F0")]
			private static RMLXMXCDWBY TIHCPWDKFSE(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class QKKRUXTNNLF
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static readonly Guid LNOLFSBQEEW;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA349510", Offset = "0xA348910", VA = "0x18A349510")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class QLFTJYVCZEP
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly Guid ODIFGHECYSQ;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static readonly Guid RTRILHYARYI;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly Guid WBPICYPIXCF;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA349800", Offset = "0xA348C00", VA = "0x18A349800")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<TVWXLXTXIIP, PersistedRoomData, DEPRECATED_RoomPersistenceVersion> ODUEJTQHMXY;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA3323C0", Offset = "0xA3317C0", VA = "0x18A3323C0")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(TVWXLXTXIIP a, PersistedRoomData b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class UGIXKHFBSUM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA34A2E0", Offset = "0xA3496E0", VA = "0x18A34A2E0")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(HJBLJFFMFID.TVWXLXTXIIP a, SpawnableTemplateData b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class KRTSVWYVBMA
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface TVWXLXTXIIP : XQBBWHWJDSP<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public sealed class TLGMPNEBIBW : TVWXLXTXIIP, XQBBWHWJDSP<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static TLGMPNEBIBW LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			public PersistedRoomVersion FPWGPTAFBFH()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA34A080", Offset = "0xA349480", VA = "0x18A34A080", Slot = "5")]
			public PersistedRoomVersion CHWBOBYGKCX()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1AE4550", Offset = "0x1AE3950", VA = "0x181AE4550", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E6B0", Offset = "0x2F0DAB0", VA = "0x182F0E6B0", Slot = "7")]
			public bool WLQARKELXXK(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA34A1B0", Offset = "0xA3495B0", VA = "0x18A34A1B0", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public TLGMPNEBIBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class QJPQFWRYBRV
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static Dictionary<Guid, string[]> XFOOJEUWTKN;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA335BE0", Offset = "0xA334FE0", VA = "0x18A335BE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class IIDLFUHQVCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA333080", Offset = "0xA332480", VA = "0x18A333080")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class IIYMUVJGGWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA333340", Offset = "0xA332740", VA = "0x18A333340")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class BGBKAGQGRJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA32FB90", Offset = "0xA32EF90", VA = "0x18A32FB90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class BGGQXNKEAUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA32FD50", Offset = "0xA32F150", VA = "0x18A32FD50")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class VGIMBECRIRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA34A780", Offset = "0xA349B80", VA = "0x18A34A780")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class OGHBUGCGVHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA335890", Offset = "0xA334C90", VA = "0x18A335890")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class XZUVGGBDNKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA364210", Offset = "0xA363610", VA = "0x18A364210")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class XZFAOLTLLCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA364030", Offset = "0xA363430", VA = "0x18A364030")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class DZNTFIOSWCD
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private static readonly Dictionary<Guid, int> JEBUNTOXARG;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA34E010", Offset = "0xA34D410", VA = "0x18A34E010")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA34DDC0", Offset = "0xA34D1C0", VA = "0x18A34DDC0")]
			private static Dictionary<Guid, NOJIAPKTUHF> ENFADCPJWLX(NOJIAPKTUHF a, Dictionary<Guid, NOJIAPKTUHF> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class EBOKDYFSMLP
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA34FF50", Offset = "0xA34F350", VA = "0x18A34FF50")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class QKAEAKFSUON
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA360EE0", Offset = "0xA3602E0", VA = "0x18A360EE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class SBBJZZYVKYE
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA361D00", Offset = "0xA361100", VA = "0x18A361D00")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA361CF0", Offset = "0xA3610F0", VA = "0x18A361CF0")]
			private static void FBCZXGBWFKB(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class SBLXUNMQDUW
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA361FE0", Offset = "0xA3613E0", VA = "0x18A361FE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class SAQWFMLASBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA361900", Offset = "0xA360D00", VA = "0x18A361900")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class RZLGVXVQNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA361280", Offset = "0xA360680", VA = "0x18A361280")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class RZQNTEPNWWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA3615E0", Offset = "0xA3609E0", VA = "0x18A3615E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class QKKRUXTNNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA3610B0", Offset = "0xA3604B0", VA = "0x18A3610B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class ZBIBEETDHTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA374AE0", Offset = "0xA373EE0", VA = "0x18A374AE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ZAXNJRFIOXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA374890", Offset = "0xA373C90", VA = "0x18A374890")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class ZAMZPDRNWAL
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
			private static class PXULYRZBTXW
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid MUSFEJCSOVL
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0xA3512A0", Offset = "0xA3506A0", VA = "0x18A3512A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid PKIWVZIMYLN
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0xA351BE0", Offset = "0xA350FE0", VA = "0x18A351BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid DILAWPFIXMS
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0xA3571E0", Offset = "0xA3565E0", VA = "0x18A3571E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid PIOOQQYCESK
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0xA360860", Offset = "0xA35FC60", VA = "0x18A360860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid GQNCOXZTVSC
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0xA352B60", Offset = "0xA351F60", VA = "0x18A352B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid KECOARILJLQ
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0xA35F9E0", Offset = "0xA35EDE0", VA = "0x18A35F9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid DBZZJEJHZMJ
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0xA3597E0", Offset = "0xA358BE0", VA = "0x18A3597E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid INHZOUXUGIA
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0xA35D560", Offset = "0xA35C960", VA = "0x18A35D560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid WHERARCUZHN
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0xA354EE0", Offset = "0xA3542E0", VA = "0x18A354EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid GAZBXDCVQVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0xA351760", Offset = "0xA350B60", VA = "0x18A351760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid FHCJOETLLMT
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0xA3584E0", Offset = "0xA3578E0", VA = "0x18A3584E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid AUGDUXMEKUP
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0xA35F160", Offset = "0xA35E560", VA = "0x18A35F160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid NEFNIVLITKK
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0xA352460", Offset = "0xA351860", VA = "0x18A352460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid RBZJXLUYIZY
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0xA35DBE0", Offset = "0xA35CFE0", VA = "0x18A35DBE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid NXDEAUGSXKG
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xA35B6E0", Offset = "0xA35AAE0", VA = "0x18A35B6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid GTSBIEBQUCF
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0xA3547E0", Offset = "0xA353BE0", VA = "0x18A3547E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid PRMQWEKZZVE
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0xA355D60", Offset = "0xA355160", VA = "0x18A355D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid TKGEGLRIANA
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0xA35D960", Offset = "0xA35CD60", VA = "0x18A35D960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid JEAABYGZHOL
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0xA356D60", Offset = "0xA356160", VA = "0x18A356D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid HISCFRXKTGT
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0xA3609E0", Offset = "0xA35FDE0", VA = "0x18A3609E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid XQAAUFIHAAD
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0xA35F460", Offset = "0xA35E860", VA = "0x18A35F460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid MHOMHRPKHIP
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0xA35FDE0", Offset = "0xA35F1E0", VA = "0x18A35FDE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid MJTLPMLKWKX
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0xA35C3E0", Offset = "0xA35B7E0", VA = "0x18A35C3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid GAHZIRBRHNL
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0xA35FCE0", Offset = "0xA35F0E0", VA = "0x18A35FCE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid RITBBYNOYBG
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0xA355EE0", Offset = "0xA3552E0", VA = "0x18A355EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid BBRMCIKFZDH
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0xA355860", Offset = "0xA354C60", VA = "0x18A355860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid YDOIHFECAZB
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0xA3566E0", Offset = "0xA355AE0", VA = "0x18A3566E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid HJMQWRGHBPL
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0xA359660", Offset = "0xA358A60", VA = "0x18A359660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid PPKFRZLRCWH
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0xA359E60", Offset = "0xA359260", VA = "0x18A359E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid EAXJCWIRDLG
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0xA3517E0", Offset = "0xA350BE0", VA = "0x18A3517E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid PEIVXBDVAWK
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0xA3601E0", Offset = "0xA35F5E0", VA = "0x18A3601E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid WVCHKHQDEVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0xA3545E0", Offset = "0xA3539E0", VA = "0x18A3545E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid SENFSHOBPLR
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0xA35AA60", Offset = "0xA359E60", VA = "0x18A35AA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid WLEZRXAIJQK
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0xA35B4E0", Offset = "0xA35A8E0", VA = "0x18A35B4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid CPZUUQOLTQW
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0xA35A3E0", Offset = "0xA3597E0", VA = "0x18A35A3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid QMZBDZGTCDZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0xA356AE0", Offset = "0xA355EE0", VA = "0x18A356AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid XAONPNIGCXT
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0xA35BCE0", Offset = "0xA35B0E0", VA = "0x18A35BCE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid UDADSKBUHGA
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0xA35F960", Offset = "0xA35ED60", VA = "0x18A35F960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid NOSSPSKWOQA
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0xA3507A0", Offset = "0xA34FBA0", VA = "0x18A3507A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid HXQWBDSREEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0xA3593E0", Offset = "0xA3587E0", VA = "0x18A3593E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid WRUSKNGARZK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0xA3590E0", Offset = "0xA3584E0", VA = "0x18A3590E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid TQUAWYEKPJP
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0xA35F360", Offset = "0xA35E760", VA = "0x18A35F360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid WVNGCGUVUTJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0xA353DE0", Offset = "0xA3531E0", VA = "0x18A353DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid HCKKGLMDCVH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0xA357AE0", Offset = "0xA356EE0", VA = "0x18A357AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid XEGSDHTZZZV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0xA35C560", Offset = "0xA35B960", VA = "0x18A35C560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid EDYOSGFJMRQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0xA357C60", Offset = "0xA357060", VA = "0x18A357C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid FRLCVAQJZLZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0xA35E460", Offset = "0xA35D860", VA = "0x18A35E460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid UYUSCWRHIFY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0xA35CC60", Offset = "0xA35C060", VA = "0x18A35CC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid RRPEGRLRIOV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0xA353D60", Offset = "0xA353160", VA = "0x18A353D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid URATWAYFCBN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0xA35CAE0", Offset = "0xA35BEE0", VA = "0x18A35CAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid ZLESKZHWWIK
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0xA35B960", Offset = "0xA35AD60", VA = "0x18A35B960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid WNKGMMHSEQO
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xA3565E0", Offset = "0xA3559E0", VA = "0x18A3565E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid CLWEWSOFLBS
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xA360C60", Offset = "0xA360060", VA = "0x18A360C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid HZFHQWVBTBM
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xA356560", Offset = "0xA355960", VA = "0x18A356560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid MYYUGGLOYKL
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xA350AA0", Offset = "0xA34FEA0", VA = "0x18A350AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid IYNECXXHLKH
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xA352D60", Offset = "0xA352160", VA = "0x18A352D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid JMPVYRAQVFU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0xA351860", Offset = "0xA350C60", VA = "0x18A351860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid NAIXFJGYHDJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xA3529E0", Offset = "0xA351DE0", VA = "0x18A3529E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid KBEBWHCUDFV
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0xA35E560", Offset = "0xA35D960", VA = "0x18A35E560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid BWLOYVHTYRK
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xA356E60", Offset = "0xA356260", VA = "0x18A356E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid TUCJCZEXHAJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xA351EE0", Offset = "0xA3512E0", VA = "0x18A351EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid HGRSBDQMJEE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xA360060", Offset = "0xA35F460", VA = "0x18A360060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid OBLPYHHVCUY
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xA355F60", Offset = "0xA355360", VA = "0x18A355F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid JFRZBKKPHIS
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xA356A60", Offset = "0xA355E60", VA = "0x18A356A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid UIUVWQEJFRI
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0xA35E060", Offset = "0xA35D460", VA = "0x18A35E060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid QVJSKPBAKMA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xA3519E0", Offset = "0xA350DE0", VA = "0x18A3519E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid IHDCPADZUBA
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0xA350DA0", Offset = "0xA3501A0", VA = "0x18A350DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid NHTRXYYXWMA
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0xA35B2E0", Offset = "0xA35A6E0", VA = "0x18A35B2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid WKZCBCBANSL
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0xA3518E0", Offset = "0xA350CE0", VA = "0x18A3518E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid FGPUAEEGKBQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xA3515E0", Offset = "0xA3509E0", VA = "0x18A3515E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid FSNLDXADMZW
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xA359BE0", Offset = "0xA358FE0", VA = "0x18A359BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid RMZTOVVVLTD
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0xA356460", Offset = "0xA355860", VA = "0x18A356460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid UNDSOVPTJYD
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0xA360AE0", Offset = "0xA35FEE0", VA = "0x18A360AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid GZUQLYUOGEK
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xA35F060", Offset = "0xA35E460", VA = "0x18A35F060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid AGVHYRYQDTZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0xA35AEE0", Offset = "0xA35A2E0", VA = "0x18A35AEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid VNRKGBMLZZM
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0xA350720", Offset = "0xA34FB20", VA = "0x18A350720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid EFZLXXPGFDS
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0xA360D60", Offset = "0xA360160", VA = "0x18A360D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid UHUYKYPKSWZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0xA351020", Offset = "0xA350420", VA = "0x18A351020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid OWECWOCQNVF
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0xA35F760", Offset = "0xA35EB60", VA = "0x18A35F760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid FKSVUXJPVXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0xA35ED60", Offset = "0xA35E160", VA = "0x18A35ED60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid UFBVMSFUDOW
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0xA35D9E0", Offset = "0xA35CDE0", VA = "0x18A35D9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid DAXZLOAXONL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0xA3598E0", Offset = "0xA358CE0", VA = "0x18A3598E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid WAIKPHAXZHC
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0xA3549E0", Offset = "0xA353DE0", VA = "0x18A3549E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid UPZBYMUFRVS
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0xA354AE0", Offset = "0xA353EE0", VA = "0x18A354AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid VUCMBSKYAIU
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0xA35F2E0", Offset = "0xA35E6E0", VA = "0x18A35F2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid QGRWYWAWMXD
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0xA353AE0", Offset = "0xA352EE0", VA = "0x18A353AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid EUADILHZNZL
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0xA354C60", Offset = "0xA354060", VA = "0x18A354C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid EFUNSFAYFHG
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0xA35F860", Offset = "0xA35EC60", VA = "0x18A35F860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid IYJXOETKRBB
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0xA35EF60", Offset = "0xA35E360", VA = "0x18A35EF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid KKIRYFTWEFO
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0xA3523E0", Offset = "0xA3517E0", VA = "0x18A3523E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid LFCOMDXYLPK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0xA3580E0", Offset = "0xA3574E0", VA = "0x18A3580E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid MHEGBFOEZWH
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0xA352960", Offset = "0xA351D60", VA = "0x18A352960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid HHONQWTOAXN
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0xA357F60", Offset = "0xA357360", VA = "0x18A357F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid ZEBGFEQPPDW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0xA35B1E0", Offset = "0xA35A5E0", VA = "0x18A35B1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid TTTBIYKWTEW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0xA35EA60", Offset = "0xA35DE60", VA = "0x18A35EA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid SPMZSXZRFKI
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0xA35EE60", Offset = "0xA35E260", VA = "0x18A35EE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid MDINWNMCNEV
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0xA356260", Offset = "0xA355660", VA = "0x18A356260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid UQYVNJLWYVS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0xA35CDE0", Offset = "0xA35C1E0", VA = "0x18A35CDE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid PMWLNRLFWWJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0xA3607E0", Offset = "0xA35FBE0", VA = "0x18A3607E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid PMLXTDXLDZR
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0xA3606E0", Offset = "0xA35FAE0", VA = "0x18A3606E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid IDURREIRVDA
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0xA359AE0", Offset = "0xA358EE0", VA = "0x18A359AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid IAYZDNQCTAE
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0xA359DE0", Offset = "0xA3591E0", VA = "0x18A359DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid IBJMYBDXLWW
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0xA359D60", Offset = "0xA359160", VA = "0x18A359D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid ZCCWXPGNQKS
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0xA35FE60", Offset = "0xA35F260", VA = "0x18A35FE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid NLJZEDYSRLK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0xA35ECE0", Offset = "0xA35E0E0", VA = "0x18A35ECE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid RCCICERYKZE
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0xA35ACE0", Offset = "0xA35A0E0", VA = "0x18A35ACE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid UONSRBHYMLH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0xA3531E0", Offset = "0xA3525E0", VA = "0x18A3531E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid QLXMAOBVPVO
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0xA3562E0", Offset = "0xA3556E0", VA = "0x18A3562E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid QLBNRTFASIA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0xA358460", Offset = "0xA357860", VA = "0x18A358460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid MTMCUYLVVQH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0xA358060", Offset = "0xA357460", VA = "0x18A358060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid NBKBPYTWIIU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xA357DE0", Offset = "0xA3571E0", VA = "0x18A357DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid NKLKSZOAEEB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0xA3556E0", Offset = "0xA354AE0", VA = "0x18A3556E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid WMQLUFAQYHB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0xA35DAE0", Offset = "0xA35CEE0", VA = "0x18A35DAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid FTPYLGTSUWV
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0xA355660", Offset = "0xA354A60", VA = "0x18A355660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid CYAHPWGJIYA
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0xA35FC60", Offset = "0xA35F060", VA = "0x18A35FC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid UUCMKYVAVIT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0xA360460", Offset = "0xA35F860", VA = "0x18A360460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid LWJJCWNENJS
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0xA3534E0", Offset = "0xA3528E0", VA = "0x18A3534E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid QDBPOPYOGJT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0xA354E60", Offset = "0xA354260", VA = "0x18A354E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid FYLCGSASJZN
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0xA35D060", Offset = "0xA35C460", VA = "0x18A35D060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid IBGAHFXTIMM
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0xA3535E0", Offset = "0xA3529E0", VA = "0x18A3535E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid LSFMXSYTWDZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0xA35A0E0", Offset = "0xA3594E0", VA = "0x18A35A0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid RNRTIELLJJN
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0xA3542E0", Offset = "0xA3536E0", VA = "0x18A3542E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid ISRYVMILUWT
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0xA35BFE0", Offset = "0xA35B3E0", VA = "0x18A35BFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid PABQCTEODPB
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0xA354260", Offset = "0xA353660", VA = "0x18A354260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid RHOBLNTNEHI
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0xA3513E0", Offset = "0xA3507E0", VA = "0x18A3513E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid DCNDXSTFMAK
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0xA35C9E0", Offset = "0xA35BDE0", VA = "0x18A35C9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid PPTPYTAUGLF
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0xA352E60", Offset = "0xA352260", VA = "0x18A352E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid PBAREZJAIIA
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0xA358EE0", Offset = "0xA3582E0", VA = "0x18A358EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid TUTUVEDEGDK
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0xA355C60", Offset = "0xA355060", VA = "0x18A355C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid KWFMGKYMLOE
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0xA35C0E0", Offset = "0xA35B4E0", VA = "0x18A35C0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid ROLOYPMNCYI
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0xA35A060", Offset = "0xA359460", VA = "0x18A35A060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid CFAYBIYFLUB
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0xA357EE0", Offset = "0xA3572E0", VA = "0x18A357EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid JYOVJXGPWNE
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0xA352660", Offset = "0xA351A60", VA = "0x18A352660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid XKAJZKRWHKJ
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0xA351960", Offset = "0xA350D60", VA = "0x18A351960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid STRAMZMTCTP
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0xA356CE0", Offset = "0xA3560E0", VA = "0x18A356CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid VRVSXCHWYCT
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xA3573E0", Offset = "0xA3567E0", VA = "0x18A3573E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid NSCTXTOEDXK
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0xA359060", Offset = "0xA358460", VA = "0x18A359060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid UPYZLETWAKZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0xA3559E0", Offset = "0xA354DE0", VA = "0x18A3559E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid WPGEQPSJKQS
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0xA359160", Offset = "0xA358560", VA = "0x18A359160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid IQLTWZRPRTN
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0xA3602E0", Offset = "0xA35F6E0", VA = "0x18A3602E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid PRKVTUHEXIY
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0xA35C2E0", Offset = "0xA35B6E0", VA = "0x18A35C2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid AGMAOKVCFMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0xA35EAE0", Offset = "0xA35DEE0", VA = "0x18A35EAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid WRQKZYDQFXQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0xA3539E0", Offset = "0xA352DE0", VA = "0x18A3539E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid JXKYHBOZIVZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0xA355E60", Offset = "0xA355260", VA = "0x18A355E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid YURAKVFJEXU
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0xA35AE60", Offset = "0xA35A260", VA = "0x18A35AE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid NHWGVEXRDOP
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0xA3516E0", Offset = "0xA350AE0", VA = "0x18A3516E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid DPEPCCOFXYY
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0xA35C8E0", Offset = "0xA35BCE0", VA = "0x18A35C8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid MDQSSXTTLWH
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0xA351C60", Offset = "0xA351060", VA = "0x18A351C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid XVWYHECSAEK
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0xA356F60", Offset = "0xA356360", VA = "0x18A356F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid XTSZFTIAMFS
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0xA353760", Offset = "0xA352B60", VA = "0x18A353760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid DLTNHYSVUMS
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0xA352BE0", Offset = "0xA351FE0", VA = "0x18A352BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid DSBEOTJBODK
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0xA353860", Offset = "0xA352C60", VA = "0x18A353860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid WFJWLMCQIFS
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0xA35C660", Offset = "0xA35BA60", VA = "0x18A35C660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid PIVBEKRFVIX
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0xA352F60", Offset = "0xA352360", VA = "0x18A352F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid IUKTNGKXOHA
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0xA360BE0", Offset = "0xA35FFE0", VA = "0x18A360BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid JIDTGBFHFFM
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0xA3560E0", Offset = "0xA3554E0", VA = "0x18A3560E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid RHTQPLSVPSD
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0xA3569E0", Offset = "0xA355DE0", VA = "0x18A3569E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid HHOLDVQLPSG
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0xA350BA0", Offset = "0xA34FFA0", VA = "0x18A350BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid XTAHXCZTIRW
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0xA352560", Offset = "0xA351960", VA = "0x18A352560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid TFBVEBWXVAW
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0xA358660", Offset = "0xA357A60", VA = "0x18A358660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid DPGHKDLIIVT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xA35F0E0", Offset = "0xA35E4E0", VA = "0x18A35F0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid VGXDQOKRCNF
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xA357E60", Offset = "0xA357260", VA = "0x18A357E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid HFPMBQJLMFX
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xA350F20", Offset = "0xA350320", VA = "0x18A350F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid SNTCMUKRZRA
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xA354460", Offset = "0xA353860", VA = "0x18A354460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid PHPZJFUXOWE
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0xA358260", Offset = "0xA357660", VA = "0x18A358260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid UGTDDUKTTML
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xA354160", Offset = "0xA353560", VA = "0x18A354160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid KEHGHNUHUMR
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0xA354560", Offset = "0xA353960", VA = "0x18A354560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid PCIIPERBCOF
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xA358E60", Offset = "0xA358260", VA = "0x18A358E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid IWNFXQRYOXX
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0xA35C6E0", Offset = "0xA35BAE0", VA = "0x18A35C6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid UQYMIVRFFMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0xA35D1E0", Offset = "0xA35C5E0", VA = "0x18A35D1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid MOHSUNFNQPG
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0xA351AE0", Offset = "0xA350EE0", VA = "0x18A351AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid WWUOUSRTWPM
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0xA355760", Offset = "0xA354B60", VA = "0x18A355760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid ATZTQNHYUCJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0xA35E760", Offset = "0xA35DB60", VA = "0x18A35E760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid UBJIKZLISTT
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0xA3511A0", Offset = "0xA3505A0", VA = "0x18A3511A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid HECYCVFYKZF
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0xA35FA60", Offset = "0xA35EE60", VA = "0x18A35FA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid UPVJTFOUAMS
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0xA35BB60", Offset = "0xA35AF60", VA = "0x18A35BB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid IQMMNTLQXPG
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0xA353160", Offset = "0xA352560", VA = "0x18A353160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid PDQBQCQCIMD
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0xA3570E0", Offset = "0xA3564E0", VA = "0x18A3570E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid QCCEHREARZS
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0xA3581E0", Offset = "0xA3575E0", VA = "0x18A3581E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid IARSAGGHDHK
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0xA3543E0", Offset = "0xA3537E0", VA = "0x18A3543E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid WVNCGIRZALY
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0xA358DE0", Offset = "0xA3581E0", VA = "0x18A358DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid PZFZDUBQCIF
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0xA354D60", Offset = "0xA354160", VA = "0x18A354D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid FNIJQKULUPX
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0xA359CE0", Offset = "0xA3590E0", VA = "0x18A359CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid XXWGYBFHPFV
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0xA35A2E0", Offset = "0xA3596E0", VA = "0x18A35A2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid PVOANHVSLCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0xA3587E0", Offset = "0xA357BE0", VA = "0x18A3587E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid NROCQZPTVDM
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0xA3567E0", Offset = "0xA355BE0", VA = "0x18A3567E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid NYAVFYUKPEO
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0xA356860", Offset = "0xA355C60", VA = "0x18A356860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid YXIRFQEOEYJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0xA350CA0", Offset = "0xA3500A0", VA = "0x18A350CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid VFIIQIBCZIJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0xA357260", Offset = "0xA356660", VA = "0x18A357260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid VQXZKOXOURQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0xA353CE0", Offset = "0xA3530E0", VA = "0x18A353CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid DIZEPFHERKH
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0xA350A20", Offset = "0xA34FE20", VA = "0x18A350A20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid RTRVAFSNVIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0xA3589E0", Offset = "0xA357DE0", VA = "0x18A3589E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid WFFOLIVSIWT
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0xA352060", Offset = "0xA351460", VA = "0x18A352060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid PSFPNQUGAQT
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0xA355160", Offset = "0xA354560", VA = "0x18A355160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid TQGKAZEBDXG
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0xA3586E0", Offset = "0xA357AE0", VA = "0x18A3586E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid YRZOKYMYBCS
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0xA353FE0", Offset = "0xA3533E0", VA = "0x18A353FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid TUMRGFERMFN
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0xA356B60", Offset = "0xA355F60", VA = "0x18A356B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid FCCSOKNXQYD
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0xA3583E0", Offset = "0xA3577E0", VA = "0x18A3583E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid GTCZBXZUHHU
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0xA35FEE0", Offset = "0xA35F2E0", VA = "0x18A35FEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid HNDWUDRQQAG
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0xA350C20", Offset = "0xA350020", VA = "0x18A350C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid KYTTSRJRRDE
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xA357360", Offset = "0xA356760", VA = "0x18A357360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid OMKFFAEMCYB
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0xA359460", Offset = "0xA358860", VA = "0x18A359460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid TLDAVZGUKOY
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xA35DCE0", Offset = "0xA35D0E0", VA = "0x18A35DCE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid MEJVAEYDRWG
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0xA357FE0", Offset = "0xA3573E0", VA = "0x18A357FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid ACMPPYARVPC
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0xA35C1E0", Offset = "0xA35B5E0", VA = "0x18A35C1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid LDKZHFCHVJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0xA358FE0", Offset = "0xA3583E0", VA = "0x18A358FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid QRKWSRYLFEP
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0xA35C260", Offset = "0xA35B660", VA = "0x18A35C260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid WLLJZWMVGRK
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0xA35EB60", Offset = "0xA35DF60", VA = "0x18A35EB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid NAZFVXWKBAS
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0xA35F260", Offset = "0xA35E660", VA = "0x18A35F260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid YTYWPTSNBFM
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0xA3550E0", Offset = "0xA3544E0", VA = "0x18A3550E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid BCZDMPWDDSY
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0xA35CE60", Offset = "0xA35C260", VA = "0x18A35CE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid JOKQAEZDBMA
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0xA35B160", Offset = "0xA35A560", VA = "0x18A35B160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid WLBZIPSGUQQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0xA35E0E0", Offset = "0xA35D4E0", VA = "0x18A35E0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid MPDFYUQKGBQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0xA35BEE0", Offset = "0xA35B2E0", VA = "0x18A35BEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid BMWWDFOUHNF
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0xA35EC60", Offset = "0xA35E060", VA = "0x18A35EC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid VIWQDNFYKTS
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0xA35E6E0", Offset = "0xA35DAE0", VA = "0x18A35E6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid UCUIERFQSFI
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0xA359360", Offset = "0xA358760", VA = "0x18A359360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid MZMIKLBPPNE
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0xA351F60", Offset = "0xA351360", VA = "0x18A351F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid WMAURSLQKDG
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0xA35B9E0", Offset = "0xA35ADE0", VA = "0x18A35B9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid SVOYTZCONRV
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0xA35A9E0", Offset = "0xA359DE0", VA = "0x18A35A9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid XPFHNVFTRHZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0xA359860", Offset = "0xA358C60", VA = "0x18A359860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid XIWHXZLSYBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0xA35A5E0", Offset = "0xA3599E0", VA = "0x18A35A5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid XZPDPVRQXJB
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0xA356FE0", Offset = "0xA3563E0", VA = "0x18A356FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid CGJPTXEHOGE
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0xA35AFE0", Offset = "0xA35A3E0", VA = "0x18A35AFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid SMOKZLVWXJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0xA356C60", Offset = "0xA356060", VA = "0x18A356C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid TNBFFIWGOOG
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0xA35A760", Offset = "0xA359B60", VA = "0x18A35A760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid DEUHCLUUKAJ
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0xA35DB60", Offset = "0xA35CF60", VA = "0x18A35DB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid ARHSVJYOQBS
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0xA356EE0", Offset = "0xA3562E0", VA = "0x18A356EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid OBUTSXHDLTF
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0xA35B8E0", Offset = "0xA35ACE0", VA = "0x18A35B8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid SBTELFXPUVK
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0xA354060", Offset = "0xA353460", VA = "0x18A354060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid GPEVFIVHEBI
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0xA357A60", Offset = "0xA356E60", VA = "0x18A357A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid PSFZFFGVAPF
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0xA357860", Offset = "0xA356C60", VA = "0x18A357860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid YADHYZBCMRB
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0xA353BE0", Offset = "0xA352FE0", VA = "0x18A353BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid DOJMHHJIWWY
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0xA3538E0", Offset = "0xA352CE0", VA = "0x18A3538E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid CEZVQAJKNAS
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0xA35A460", Offset = "0xA359860", VA = "0x18A35A460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid BMQJZFVJMKY
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0xA357660", Offset = "0xA356A60", VA = "0x18A357660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid WJUJMDIMXUJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0xA3596E0", Offset = "0xA358AE0", VA = "0x18A3596E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid VOOXPYSBIAM
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0xA360660", Offset = "0xA35FA60", VA = "0x18A360660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid TUIUTNDOEVF
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0xA353060", Offset = "0xA352460", VA = "0x18A353060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid QKOTRXISNKF
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0xA359A60", Offset = "0xA358E60", VA = "0x18A359A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid ZFNPAELVKMJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0xA360160", Offset = "0xA35F560", VA = "0x18A360160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid AASHIJWNPLC
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0xA35E8E0", Offset = "0xA35DCE0", VA = "0x18A35E8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid XVGPVLWAUWG
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0xA35D3E0", Offset = "0xA35C7E0", VA = "0x18A35D3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid UPDRQSIMRJW
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0xA353A60", Offset = "0xA352E60", VA = "0x18A353A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid PYISQBDMYTL
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0xA35F3E0", Offset = "0xA35E7E0", VA = "0x18A35F3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid NPXJRZZCEID
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0xA3555E0", Offset = "0xA3549E0", VA = "0x18A3555E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid ETILSZSCOFA
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0xA350D20", Offset = "0xA350120", VA = "0x18A350D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid RXSXPEHBVNY
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0xA35FAE0", Offset = "0xA35EEE0", VA = "0x18A35FAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid LWPZIYAJDCO
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0xA359560", Offset = "0xA358960", VA = "0x18A359560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid KKAFVLMNUFA
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0xA358160", Offset = "0xA357560", VA = "0x18A358160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid QTQXKQSGTVN
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0xA354760", Offset = "0xA353B60", VA = "0x18A354760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid IALOEDSFPVC
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0xA352AE0", Offset = "0xA351EE0", VA = "0x18A352AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid UPLCHFPYOYI
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0xA35BE60", Offset = "0xA35B260", VA = "0x18A35BE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid GELFQWANFYL
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0xA35E7E0", Offset = "0xA35DBE0", VA = "0x18A35E7E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid HNUVTOTQFYR
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0xA3526E0", Offset = "0xA351AE0", VA = "0x18A3526E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid SSLYHBYKRYM
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0xA352860", Offset = "0xA351C60", VA = "0x18A352860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid LNUMFVITFBL
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0xA35E1E0", Offset = "0xA35D5E0", VA = "0x18A35E1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid AWGGNIKVNNU
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0xA355060", Offset = "0xA354460", VA = "0x18A355060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid IFAZFNVAJOF
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0xA35E2E0", Offset = "0xA35D6E0", VA = "0x18A35E2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid YNHRSLHJPOO
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0xA358C60", Offset = "0xA358060", VA = "0x18A358C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid YGBDKXFGQYB
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0xA35B5E0", Offset = "0xA35A9E0", VA = "0x18A35B5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid UAJUFCCKXBE
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0xA353260", Offset = "0xA352660", VA = "0x18A353260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid QMZVOQOGIYT
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0xA353460", Offset = "0xA352860", VA = "0x18A353460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid SCPGRVGCKUY
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0xA3552E0", Offset = "0xA3546E0", VA = "0x18A3552E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid XNRLGLSCNCF
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xA350FA0", Offset = "0xA3503A0", VA = "0x18A350FA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid YWTWYBWIGRZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0xA35B760", Offset = "0xA35AB60", VA = "0x18A35B760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid OSHHDGATPLM
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xA351B60", Offset = "0xA350F60", VA = "0x18A351B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid FAABMIXRZWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0xA352FE0", Offset = "0xA3523E0", VA = "0x18A352FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid TZHNPSNBDVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0xA352EE0", Offset = "0xA3522E0", VA = "0x18A352EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid OIUTRAPWLPX
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0xA35D260", Offset = "0xA35C660", VA = "0x18A35D260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid HUBICTTKKLC
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0xA357B60", Offset = "0xA356F60", VA = "0x18A357B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid LZJVLNKYGPJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0xA354CE0", Offset = "0xA3540E0", VA = "0x18A354CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid AILOAUEXYCZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0xA358AE0", Offset = "0xA357EE0", VA = "0x18A358AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid LMFLKTTMPNT
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0xA358860", Offset = "0xA357C60", VA = "0x18A358860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid HWPDAZNYXQT
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0xA356960", Offset = "0xA355D60", VA = "0x18A356960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid QAMCMUMQZZH
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0xA352260", Offset = "0xA351660", VA = "0x18A352260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid QHKQACGPLLQ
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0xA355DE0", Offset = "0xA3551E0", VA = "0x18A355DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid PZWHVAEYXRG
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xA3521E0", Offset = "0xA3515E0", VA = "0x18A3521E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid QABOSGYWHCP
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0xA352160", Offset = "0xA351560", VA = "0x18A352160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid TRNBOTSHSBR
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xA3537E0", Offset = "0xA352BE0", VA = "0x18A3537E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid SLMKQETAQLU
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0xA35B360", Offset = "0xA35A760", VA = "0x18A35B360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid SLHDSXZDHAL
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0xA35B260", Offset = "0xA35A660", VA = "0x18A35B260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid JLKLJQEEOAX
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0xA3588E0", Offset = "0xA357CE0", VA = "0x18A3588E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid GMRTQMXBMFJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0xA35B660", Offset = "0xA35AA60", VA = "0x18A35B660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid GUEPJXHJYXC
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xA35EDE0", Offset = "0xA35E1E0", VA = "0x18A35EDE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid IAJTVYPPFKX
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0xA35D6E0", Offset = "0xA35CAE0", VA = "0x18A35D6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid IPUNOLAUAGD
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xA35B3E0", Offset = "0xA35A7E0", VA = "0x18A35B3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid RAWAYQFRIMI
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0xA3575E0", Offset = "0xA3569E0", VA = "0x18A3575E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid GNYJFZCFWES
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0xA35F4E0", Offset = "0xA35E8E0", VA = "0x18A35F4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid SYKKHQYCVWY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0xA35D760", Offset = "0xA35CB60", VA = "0x18A35D760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid LGCZRNVOZKX
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0xA358560", Offset = "0xA357960", VA = "0x18A358560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid OSRFGSXJTUK
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0xA35C760", Offset = "0xA35BB60", VA = "0x18A35C760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid XTMJDCMDJOU
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0xA35A260", Offset = "0xA359660", VA = "0x18A35A260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid JQCIXXKJSQW
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0xA357D60", Offset = "0xA357160", VA = "0x18A357D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid HAYWCUUJUCD
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0xA351E60", Offset = "0xA351260", VA = "0x18A351E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid BGKJRJXNAPC
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0xA350B20", Offset = "0xA34FF20", VA = "0x18A350B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid XXDWRVFTFBR
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0xA354DE0", Offset = "0xA3541E0", VA = "0x18A354DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid YLAZMGDRAHR
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0xA351360", Offset = "0xA350760", VA = "0x18A351360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid KBVFLMBAKFJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0xA35F5E0", Offset = "0xA35E9E0", VA = "0x18A35F5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid CONNHRLYXFM
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0xA352CE0", Offset = "0xA3520E0", VA = "0x18A352CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid OCCJDYMZTFT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0xA35C460", Offset = "0xA35B860", VA = "0x18A35C460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid LCTIZJYOZJE
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0xA35A960", Offset = "0xA359D60", VA = "0x18A35A960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid TRRVKWPEYDB
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0xA35B560", Offset = "0xA35A960", VA = "0x18A35B560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid CCZYQXGGCTU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0xA35ADE0", Offset = "0xA35A1E0", VA = "0x18A35ADE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid ZCQCWOVPRAI
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xA357560", Offset = "0xA356960", VA = "0x18A357560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid XANAHNUVDDK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0xA35EFE0", Offset = "0xA35E3E0", VA = "0x18A35EFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid UOQDAJFTKFR
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xA3579E0", Offset = "0xA356DE0", VA = "0x18A3579E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid LXJEPKWDVPL
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0xA35CF60", Offset = "0xA35C360", VA = "0x18A35CF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid GUYTJFZIVJC
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xA35CFE0", Offset = "0xA35C3E0", VA = "0x18A35CFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid ITLACCIZVRE
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0xA35D5E0", Offset = "0xA35C9E0", VA = "0x18A35D5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid VCTZHYMOLVX
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xA35AB60", Offset = "0xA359F60", VA = "0x18A35AB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid LRYWULSWXXW
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0xA3594E0", Offset = "0xA3588E0", VA = "0x18A3594E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid BKWYMQDCRPK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0xA351460", Offset = "0xA350860", VA = "0x18A351460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid QERJFMDJIYE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0xA35B7E0", Offset = "0xA35ABE0", VA = "0x18A35B7E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid SRPINHLXMDI
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0xA352C60", Offset = "0xA352060", VA = "0x18A352C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid SQROKTWVDCJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xA35AC60", Offset = "0xA35A060", VA = "0x18A35AC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid YKAXIQYXLTU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0xA3551E0", Offset = "0xA3545E0", VA = "0x18A3551E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid RLUNFAGAGES
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xA3568E0", Offset = "0xA355CE0", VA = "0x18A3568E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid PCNMHZDQPTA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0xA35A360", Offset = "0xA359760", VA = "0x18A35A360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid CSRZBRUXBWA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0xA35DD60", Offset = "0xA35D160", VA = "0x18A35DD60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid GIROSOKCUJW
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0xA3582E0", Offset = "0xA3576E0", VA = "0x18A3582E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid HMWZOVPKIAU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0xA353F60", Offset = "0xA353360", VA = "0x18A353F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid NUPUIKYIDKM
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0xA3577E0", Offset = "0xA356BE0", VA = "0x18A3577E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid TGQLTIORYHF
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0xA354960", Offset = "0xA353D60", VA = "0x18A354960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid YUCPPQUYPIW
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0xA3540E0", Offset = "0xA3534E0", VA = "0x18A3540E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid KSEFHADKOLF
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0xA3553E0", Offset = "0xA3547E0", VA = "0x18A3553E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid BTZDCAUNIIF
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0xA357CE0", Offset = "0xA3570E0", VA = "0x18A357CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid ASHZIXZWZYH
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0xA35A560", Offset = "0xA359960", VA = "0x18A35A560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid GGTMQVJLKNM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0xA35F560", Offset = "0xA35E960", VA = "0x18A35F560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid OKJUWJNYTOV
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0xA357760", Offset = "0xA356B60", VA = "0x18A357760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid TDHRZFZGPLM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0xA35DF60", Offset = "0xA35D360", VA = "0x18A35DF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid SFKCWVHSBSR
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xA35E4E0", Offset = "0xA35D8E0", VA = "0x18A35E4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid MJGENXGVQSI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0xA35BDE0", Offset = "0xA35B1E0", VA = "0x18A35BDE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid RHKISQZSQHP
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xA35CCE0", Offset = "0xA35C0E0", VA = "0x18A35CCE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid PZNGTBHUDMU
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0xA35AAE0", Offset = "0xA359EE0", VA = "0x18A35AAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid QBLQRNIVAPZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0xA35FF60", Offset = "0xA35F360", VA = "0x18A35FF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid QZTYGEXQYFI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0xA35C960", Offset = "0xA35BD60", VA = "0x18A35C960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid MSSCQPMABEK
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0xA35CBE0", Offset = "0xA35BFE0", VA = "0x18A35CBE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid VZJBXFVWJNS
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0xA353EE0", Offset = "0xA3532E0", VA = "0x18A353EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid DEELVRJZKFF
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0xA353960", Offset = "0xA352D60", VA = "0x18A353960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid OJGNOOPYJNL
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0xA359FE0", Offset = "0xA3593E0", VA = "0x18A359FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid MCWIWOMPUPF
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0xA359F60", Offset = "0xA359360", VA = "0x18A359F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid JHCHHRBAIHG
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0xA353C60", Offset = "0xA353060", VA = "0x18A353C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid TLIWTRVSMRM
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0xA3563E0", Offset = "0xA3557E0", VA = "0x18A3563E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid NOXDYCRHKMJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0xA35F8E0", Offset = "0xA35ECE0", VA = "0x18A35F8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid JXISHGZMXMW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0xA358B60", Offset = "0xA357F60", VA = "0x18A358B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid CGDDFYPJZCX
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0xA35D8E0", Offset = "0xA35CCE0", VA = "0x18A35D8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid FMZZKUBGKHQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0xA357BE0", Offset = "0xA356FE0", VA = "0x18A357BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid VNJQIVPGHBC
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0xA357060", Offset = "0xA356460", VA = "0x18A357060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid MXJNMJFCUVE
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0xA355260", Offset = "0xA354660", VA = "0x18A355260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid FSRCKISMAGH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0xA358CE0", Offset = "0xA3580E0", VA = "0x18A358CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid SOXFTGBUIOZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0xA3564E0", Offset = "0xA3558E0", VA = "0x18A3564E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid FUSMQMSJMAO
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0xA360E60", Offset = "0xA360260", VA = "0x18A360E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid VLOIYMYASVW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0xA35C360", Offset = "0xA35B760", VA = "0x18A35C360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid CIYUESLDOHR
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0xA3536E0", Offset = "0xA352AE0", VA = "0x18A3536E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid UIIXGFUCZBB
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0xA35A860", Offset = "0xA359C60", VA = "0x18A35A860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid IPGMBXSQLYL
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0xA350EA0", Offset = "0xA3502A0", VA = "0x18A350EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid LURORXYOXPA
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0xA358D60", Offset = "0xA358160", VA = "0x18A358D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid XTLXNOVFPNU
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0xA355BE0", Offset = "0xA354FE0", VA = "0x18A355BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid DNRIQPSTUMF
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0xA35F7E0", Offset = "0xA35EBE0", VA = "0x18A35F7E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid TDXVVZAXHER
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0xA35BF60", Offset = "0xA35B360", VA = "0x18A35BF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid PCMTHDZPMVI
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0xA358A60", Offset = "0xA357E60", VA = "0x18A358A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid MEEYANTSUPJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0xA3530E0", Offset = "0xA3524E0", VA = "0x18A3530E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid QCRFIPORKQT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0xA3554E0", Offset = "0xA3548E0", VA = "0x18A3554E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid FQXJBSRLOFK
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0xA35ABE0", Offset = "0xA359FE0", VA = "0x18A35ABE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid NMZHLTTKFMB
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0xA360260", Offset = "0xA35F660", VA = "0x18A360260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid XFXSJYHEQPD
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0xA354B60", Offset = "0xA353F60", VA = "0x18A354B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid IBSJDZRCBNR
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0xA35FD60", Offset = "0xA35F160", VA = "0x18A35FD60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid VBLXYAIJCDZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0xA354A60", Offset = "0xA353E60", VA = "0x18A354A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid LAANDTBTNFL
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0xA35AF60", Offset = "0xA35A360", VA = "0x18A35AF60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid AGDMETWCPOA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0xA3595E0", Offset = "0xA3589E0", VA = "0x18A3595E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid YTDGTVRRQBA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0xA3591E0", Offset = "0xA3585E0", VA = "0x18A3591E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid YPGNJCJHAXV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0xA351A60", Offset = "0xA350E60", VA = "0x18A351A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid GSQAJRNGREU
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0xA35A7E0", Offset = "0xA359BE0", VA = "0x18A35A7E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid SHZZAKELGWQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0xA3576E0", Offset = "0xA356AE0", VA = "0x18A3576E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid SNSGUZMZGCR
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0xA3605E0", Offset = "0xA35F9E0", VA = "0x18A3605E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid JQZTNKAXDOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0xA3522E0", Offset = "0xA3516E0", VA = "0x18A3522E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid UFAVZYPDGDE
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0xA351FE0", Offset = "0xA3513E0", VA = "0x18A351FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid DUAZPUCBXLQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0xA354660", Offset = "0xA353A60", VA = "0x18A354660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid LMIZHKTFKPF
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0xA35E9E0", Offset = "0xA35DDE0", VA = "0x18A35E9E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid EVBDFTCGAOG
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0xA353560", Offset = "0xA352960", VA = "0x18A353560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid XQDHUIXCNKY
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0xA359260", Offset = "0xA358660", VA = "0x18A359260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid AWQXVJYFPQB
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0xA355B60", Offset = "0xA354F60", VA = "0x18A355B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid JYFIGYQNEZW
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0xA35D360", Offset = "0xA35C760", VA = "0x18A35D360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid BGBQKBZUZUB
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0xA360DE0", Offset = "0xA3601E0", VA = "0x18A360DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid ISICVSCKZDF
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0xA3578E0", Offset = "0xA356CE0", VA = "0x18A3578E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid FDLHBYOWBAV
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0xA358960", Offset = "0xA357D60", VA = "0x18A358960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid KKCHIBHTXQC
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0xA35B060", Offset = "0xA35A460", VA = "0x18A35B060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid IZBGONTSZNO
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0xA3509A0", Offset = "0xA34FDA0", VA = "0x18A3509A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid KMMPKECKYJA
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0xA35E660", Offset = "0xA35DA60", VA = "0x18A35E660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid AGTZFQNSCMU
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0xA3558E0", Offset = "0xA354CE0", VA = "0x18A3558E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid UXIWJHRYCWO
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0xA35C7E0", Offset = "0xA35BBE0", VA = "0x18A35C7E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid ZDRYXRVFJTQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0xA354BE0", Offset = "0xA353FE0", VA = "0x18A354BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid DJWUVZERYDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0xA35DA60", Offset = "0xA35CE60", VA = "0x18A35DA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid NYWOIHZUQTI
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0xA358760", Offset = "0xA357B60", VA = "0x18A358760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid VBCTHJDRTIP
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0xA359760", Offset = "0xA358B60", VA = "0x18A359760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid YPOGZTAUVWX
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0xA35D2E0", Offset = "0xA35C6E0", VA = "0x18A35D2E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid LKFMLEPMUEM
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0xA353360", Offset = "0xA352760", VA = "0x18A353360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid PDSRYZZQPZW
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0xA35DDE0", Offset = "0xA35D1E0", VA = "0x18A35DDE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid JTXGWWGGSDS
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0xA35D0E0", Offset = "0xA35C4E0", VA = "0x18A35D0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid PFVIGHCRQKF
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0xA359960", Offset = "0xA358D60", VA = "0x18A359960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid HXRUETSPLUG
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0xA35BAE0", Offset = "0xA35AEE0", VA = "0x18A35BAE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid MGUSYWJXWMZ
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0xA35F1E0", Offset = "0xA35E5E0", VA = "0x18A35F1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid GMPBWPCGMBX
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0xA35E360", Offset = "0xA35D760", VA = "0x18A35E360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid KPPLCCNGHZD
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0xA356160", Offset = "0xA355560", VA = "0x18A356160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid UKCFIYVXLTN
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0xA35D160", Offset = "0xA35C560", VA = "0x18A35D160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid VFFWKEFPXGB
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0xA350920", Offset = "0xA34FD20", VA = "0x18A350920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid FRHPEHKLLMG
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0xA350E20", Offset = "0xA350220", VA = "0x18A350E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid XZNVWTNUPHQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0xA352360", Offset = "0xA351760", VA = "0x18A352360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid QXVQVFTPBMU
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0xA35E260", Offset = "0xA35D660", VA = "0x18A35E260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid AXHQLNUVWSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0xA3600E0", Offset = "0xA35F4E0", VA = "0x18A3600E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid XNAPOKUUWNM
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0xA356BE0", Offset = "0xA355FE0", VA = "0x18A356BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid YUMJVNJAJON
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0xA35CEE0", Offset = "0xA35C2E0", VA = "0x18A35CEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid EHJTTSDMNJS
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0xA35DEE0", Offset = "0xA35D2E0", VA = "0x18A35DEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid IIUADZFLBCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0xA3604E0", Offset = "0xA35F8E0", VA = "0x18A3604E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid MYPDUJCNSSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0xA3585E0", Offset = "0xA3579E0", VA = "0x18A3585E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid RKCCXSYLVGD
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0xA354F60", Offset = "0xA354360", VA = "0x18A354F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid NKSQVJFVIGY
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0xA35E160", Offset = "0xA35D560", VA = "0x18A35E160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid FUAIQWMYPVW
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0xA35AD60", Offset = "0xA35A160", VA = "0x18A35AD60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid GVJPKAQOBYL
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0xA355460", Offset = "0xA354860", VA = "0x18A355460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid LAHOXOQCQHR
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0xA35BC60", Offset = "0xA35B060", VA = "0x18A35BC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid OVRHNGDEDXG
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0xA35E3E0", Offset = "0xA35D7E0", VA = "0x18A35E3E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid ZZFTOFDNYEA
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0xA355960", Offset = "0xA354D60", VA = "0x18A355960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid TIWBOBDQSKY
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0xA3527E0", Offset = "0xA351BE0", VA = "0x18A3527E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid WBUYBEYVRBN
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0xA351220", Offset = "0xA350620", VA = "0x18A351220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid WCKSSZGNTJO
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0xA3512E0", Offset = "0xA3506E0", VA = "0x18A3512E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid WZQFNYJJODQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0xA35E860", Offset = "0xA35DC60", VA = "0x18A35E860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid GIWHUXVJHZV
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0xA35FB60", Offset = "0xA35EF60", VA = "0x18A35FB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid ZACKLLKGNTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0xA35A660", Offset = "0xA359A60", VA = "0x18A35A660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid QNICRLNEINK
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0xA35B460", Offset = "0xA35A860", VA = "0x18A35B460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid MWCWTCIRGRL
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0xA35A8E0", Offset = "0xA359CE0", VA = "0x18A35A8E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid DRDQSIZZUTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0xA35CA60", Offset = "0xA35BE60", VA = "0x18A35CA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid CPQZTNMZGXY
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0xA359EE0", Offset = "0xA3592E0", VA = "0x18A359EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid ZHKVUKCFXQR
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0xA352760", Offset = "0xA351B60", VA = "0x18A352760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid EAIGXPQUCIR
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0xA3557E0", Offset = "0xA354BE0", VA = "0x18A3557E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid YLDVTMHXVSJ
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0xA35C160", Offset = "0xA35B560", VA = "0x18A35C160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid GTWKUOBRLDP
				{
					[Cpp2IlInjected.Token(Token = "0x600023C")]
					[Cpp2IlInjected.Address(RVA = "0xA35D860", Offset = "0xA35CC60", VA = "0x18A35D860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid EKYGDRTJDHC
				{
					[Cpp2IlInjected.Token(Token = "0x600023D")]
					[Cpp2IlInjected.Address(RVA = "0xA357160", Offset = "0xA356560", VA = "0x18A357160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid EMQQYLEPBQJ
				{
					[Cpp2IlInjected.Token(Token = "0x600023E")]
					[Cpp2IlInjected.Address(RVA = "0xA3525E0", Offset = "0xA3519E0", VA = "0x18A3525E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid EDESZOFDBDC
				{
					[Cpp2IlInjected.Token(Token = "0x600023F")]
					[Cpp2IlInjected.Address(RVA = "0xA3510A0", Offset = "0xA3504A0", VA = "0x18A3510A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid QUDCOZLGYSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000240")]
					[Cpp2IlInjected.Address(RVA = "0xA3524E0", Offset = "0xA3518E0", VA = "0x18A3524E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid IOIQFYFIDLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000241")]
					[Cpp2IlInjected.Address(RVA = "0xA360560", Offset = "0xA35F960", VA = "0x18A360560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid MKOXSTEFXEY
				{
					[Cpp2IlInjected.Token(Token = "0x6000242")]
					[Cpp2IlInjected.Address(RVA = "0xA351660", Offset = "0xA350A60", VA = "0x18A351660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid WACYVLRTVVC
				{
					[Cpp2IlInjected.Token(Token = "0x6000243")]
					[Cpp2IlInjected.Address(RVA = "0xA35A4E0", Offset = "0xA3598E0", VA = "0x18A35A4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid QNBEDUNQPUW
				{
					[Cpp2IlInjected.Token(Token = "0x6000244")]
					[Cpp2IlInjected.Address(RVA = "0xA356DE0", Offset = "0xA3561E0", VA = "0x18A356DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid VIIXFAUOYSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000245")]
					[Cpp2IlInjected.Address(RVA = "0xA351D60", Offset = "0xA351160", VA = "0x18A351D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid BZPEEGEKXHT
				{
					[Cpp2IlInjected.Token(Token = "0x6000246")]
					[Cpp2IlInjected.Address(RVA = "0xA35DE60", Offset = "0xA35D260", VA = "0x18A35DE60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid IIWVXBNMHLK
				{
					[Cpp2IlInjected.Token(Token = "0x6000247")]
					[Cpp2IlInjected.Address(RVA = "0xA35E5E0", Offset = "0xA35D9E0", VA = "0x18A35E5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid UHRVIHZKOIN
				{
					[Cpp2IlInjected.Token(Token = "0x6000248")]
					[Cpp2IlInjected.Address(RVA = "0xA35A160", Offset = "0xA359560", VA = "0x18A35A160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid DZIEHSOHHDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000249")]
					[Cpp2IlInjected.Address(RVA = "0xA358F60", Offset = "0xA358360", VA = "0x18A358F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid YTPLKPSPTYL
				{
					[Cpp2IlInjected.Token(Token = "0x600024A")]
					[Cpp2IlInjected.Address(RVA = "0xA351DE0", Offset = "0xA3511E0", VA = "0x18A351DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid YULDOGXVSQF
				{
					[Cpp2IlInjected.Token(Token = "0x600024B")]
					[Cpp2IlInjected.Address(RVA = "0xA3514E0", Offset = "0xA3508E0", VA = "0x18A3514E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid CVPHBDNAVBA
				{
					[Cpp2IlInjected.Token(Token = "0x600024C")]
					[Cpp2IlInjected.Address(RVA = "0xA356760", Offset = "0xA355B60", VA = "0x18A356760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid RKZCXWFNKNW
				{
					[Cpp2IlInjected.Token(Token = "0x600024D")]
					[Cpp2IlInjected.Address(RVA = "0xA35D660", Offset = "0xA35CA60", VA = "0x18A35D660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid DVECYUMSBKB
				{
					[Cpp2IlInjected.Token(Token = "0x600024E")]
					[Cpp2IlInjected.Address(RVA = "0xA360760", Offset = "0xA35FB60", VA = "0x18A360760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid RVAFQLXPWGU
				{
					[Cpp2IlInjected.Token(Token = "0x600024F")]
					[Cpp2IlInjected.Address(RVA = "0xA355560", Offset = "0xA354960", VA = "0x18A355560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid GOUNKQMRNEJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000250")]
					[Cpp2IlInjected.Address(RVA = "0xA3592E0", Offset = "0xA3586E0", VA = "0x18A3592E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid TEUFLXPPZRS
				{
					[Cpp2IlInjected.Token(Token = "0x6000251")]
					[Cpp2IlInjected.Address(RVA = "0xA35E960", Offset = "0xA35DD60", VA = "0x18A35E960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid QFRHRWTKKFB
				{
					[Cpp2IlInjected.Token(Token = "0x6000252")]
					[Cpp2IlInjected.Address(RVA = "0xA3532E0", Offset = "0xA3526E0", VA = "0x18A3532E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid NTFGVGTYWAU
				{
					[Cpp2IlInjected.Token(Token = "0x6000253")]
					[Cpp2IlInjected.Address(RVA = "0xA35C860", Offset = "0xA35BC60", VA = "0x18A35C860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid YJIWGQXVKYY
				{
					[Cpp2IlInjected.Token(Token = "0x6000254")]
					[Cpp2IlInjected.Address(RVA = "0xA35DC60", Offset = "0xA35D060", VA = "0x18A35DC60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid DCJZKHBMOZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000255")]
					[Cpp2IlInjected.Address(RVA = "0xA35C4E0", Offset = "0xA35B8E0", VA = "0x18A35C4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid UYUSNKWKQCA
				{
					[Cpp2IlInjected.Token(Token = "0x6000256")]
					[Cpp2IlInjected.Address(RVA = "0xA3548E0", Offset = "0xA353CE0", VA = "0x18A3548E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid PERUQHURMLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000257")]
					[Cpp2IlInjected.Address(RVA = "0xA358BE0", Offset = "0xA357FE0", VA = "0x18A358BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid MSLCUPUWSBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000258")]
					[Cpp2IlInjected.Address(RVA = "0xA3599E0", Offset = "0xA358DE0", VA = "0x18A3599E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid WLCDAYEHAJU
				{
					[Cpp2IlInjected.Token(Token = "0x6000259")]
					[Cpp2IlInjected.Address(RVA = "0xA35D4E0", Offset = "0xA35C8E0", VA = "0x18A35D4E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid AXSNRGOSRGC
				{
					[Cpp2IlInjected.Token(Token = "0x600025A")]
					[Cpp2IlInjected.Address(RVA = "0xA3520E0", Offset = "0xA3514E0", VA = "0x18A3520E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid PWLHFWHDZRD
				{
					[Cpp2IlInjected.Token(Token = "0x600025B")]
					[Cpp2IlInjected.Address(RVA = "0xA35A1E0", Offset = "0xA3595E0", VA = "0x18A35A1E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid LXQSXVEZTUQ
				{
					[Cpp2IlInjected.Token(Token = "0x600025C")]
					[Cpp2IlInjected.Address(RVA = "0xA3603E0", Offset = "0xA35F7E0", VA = "0x18A3603E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid LJRUPMBBNCG
				{
					[Cpp2IlInjected.Token(Token = "0x600025D")]
					[Cpp2IlInjected.Address(RVA = "0xA35FBE0", Offset = "0xA35EFE0", VA = "0x18A35FBE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid BQBEFJYXNGM
				{
					[Cpp2IlInjected.Token(Token = "0x600025E")]
					[Cpp2IlInjected.Address(RVA = "0xA35D460", Offset = "0xA35C860", VA = "0x18A35D460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid TEHSPSKBDJG
				{
					[Cpp2IlInjected.Token(Token = "0x600025F")]
					[Cpp2IlInjected.Address(RVA = "0xA35A6E0", Offset = "0xA359AE0", VA = "0x18A35A6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid GXSPJWFXFZW
				{
					[Cpp2IlInjected.Token(Token = "0x6000260")]
					[Cpp2IlInjected.Address(RVA = "0xA360A60", Offset = "0xA35FE60", VA = "0x18A360A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid LZZZKYIOTQM
				{
					[Cpp2IlInjected.Token(Token = "0x6000261")]
					[Cpp2IlInjected.Address(RVA = "0xA3508A0", Offset = "0xA34FCA0", VA = "0x18A3508A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid STRUZKNKJWT
				{
					[Cpp2IlInjected.Token(Token = "0x6000262")]
					[Cpp2IlInjected.Address(RVA = "0xA35FFE0", Offset = "0xA35F3E0", VA = "0x18A35FFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid UWHLGMSKDEO
				{
					[Cpp2IlInjected.Token(Token = "0x6000263")]
					[Cpp2IlInjected.Address(RVA = "0xA35EEE0", Offset = "0xA35E2E0", VA = "0x18A35EEE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid PMPVSVFLZSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000264")]
					[Cpp2IlInjected.Address(RVA = "0xA360CE0", Offset = "0xA3600E0", VA = "0x18A360CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid YHAPFATIOEL
				{
					[Cpp2IlInjected.Token(Token = "0x6000265")]
					[Cpp2IlInjected.Address(RVA = "0xA3608E0", Offset = "0xA35FCE0", VA = "0x18A3608E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid JWRTAFUNEOL
				{
					[Cpp2IlInjected.Token(Token = "0x6000266")]
					[Cpp2IlInjected.Address(RVA = "0xA356660", Offset = "0xA355A60", VA = "0x18A356660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid HIKUXFHSUHX
				{
					[Cpp2IlInjected.Token(Token = "0x6000267")]
					[Cpp2IlInjected.Address(RVA = "0xA359B60", Offset = "0xA358F60", VA = "0x18A359B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid VLYRXGTJTMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000268")]
					[Cpp2IlInjected.Address(RVA = "0xA35DFE0", Offset = "0xA35D3E0", VA = "0x18A35DFE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid VVKGDJDWZTP
				{
					[Cpp2IlInjected.Token(Token = "0x6000269")]
					[Cpp2IlInjected.Address(RVA = "0xA35BD60", Offset = "0xA35B160", VA = "0x18A35BD60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid OQZAWVTVABQ
				{
					[Cpp2IlInjected.Token(Token = "0x600026A")]
					[Cpp2IlInjected.Address(RVA = "0xA355FE0", Offset = "0xA3553E0", VA = "0x18A355FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid AKYHUSHHMBZ
				{
					[Cpp2IlInjected.Token(Token = "0x600026B")]
					[Cpp2IlInjected.Address(RVA = "0xA356360", Offset = "0xA355760", VA = "0x18A356360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid PTDFOIXCKMV
				{
					[Cpp2IlInjected.Token(Token = "0x600026C")]
					[Cpp2IlInjected.Address(RVA = "0xA35CD60", Offset = "0xA35C160", VA = "0x18A35CD60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid YCFDAYZJJUH
				{
					[Cpp2IlInjected.Token(Token = "0x600026D")]
					[Cpp2IlInjected.Address(RVA = "0xA35B0E0", Offset = "0xA35A4E0", VA = "0x18A35B0E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid EOWZRVDRFIY
				{
					[Cpp2IlInjected.Token(Token = "0x600026E")]
					[Cpp2IlInjected.Address(RVA = "0xA35CB60", Offset = "0xA35BF60", VA = "0x18A35CB60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid QLTXWYFVLBH
				{
					[Cpp2IlInjected.Token(Token = "0x600026F")]
					[Cpp2IlInjected.Address(RVA = "0xA356060", Offset = "0xA355460", VA = "0x18A356060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid WGIDNRSEXOE
				{
					[Cpp2IlInjected.Token(Token = "0x6000270")]
					[Cpp2IlInjected.Address(RVA = "0xA360360", Offset = "0xA35F760", VA = "0x18A360360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid ZBHAQIFPWQH
				{
					[Cpp2IlInjected.Token(Token = "0x6000271")]
					[Cpp2IlInjected.Address(RVA = "0xA357960", Offset = "0xA356D60", VA = "0x18A357960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid JFMCNDOCEVF
				{
					[Cpp2IlInjected.Token(Token = "0x6000272")]
					[Cpp2IlInjected.Address(RVA = "0xA358360", Offset = "0xA357760", VA = "0x18A358360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid AHYQCDKMFDF
				{
					[Cpp2IlInjected.Token(Token = "0x6000273")]
					[Cpp2IlInjected.Address(RVA = "0xA353660", Offset = "0xA352A60", VA = "0x18A353660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid GHUENINTYEC
				{
					[Cpp2IlInjected.Token(Token = "0x6000274")]
					[Cpp2IlInjected.Address(RVA = "0xA35B860", Offset = "0xA35AC60", VA = "0x18A35B860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid VWSKBUSKABT
				{
					[Cpp2IlInjected.Token(Token = "0x6000275")]
					[Cpp2IlInjected.Address(RVA = "0xA354860", Offset = "0xA353C60", VA = "0x18A354860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid ISDTEJLJHZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000276")]
					[Cpp2IlInjected.Address(RVA = "0xA35C060", Offset = "0xA35B460", VA = "0x18A35C060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid DLHHFBZSVAV
				{
					[Cpp2IlInjected.Token(Token = "0x6000277")]
					[Cpp2IlInjected.Address(RVA = "0xA35BBE0", Offset = "0xA35AFE0", VA = "0x18A35BBE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid VNNEVDTPNZB
				{
					[Cpp2IlInjected.Token(Token = "0x6000278")]
					[Cpp2IlInjected.Address(RVA = "0xA350820", Offset = "0xA34FC20", VA = "0x18A350820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid XJFVUPWAVRJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000279")]
					[Cpp2IlInjected.Address(RVA = "0xA354FE0", Offset = "0xA3543E0", VA = "0x18A354FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid ZKKQDSPAIBV
				{
					[Cpp2IlInjected.Token(Token = "0x600027A")]
					[Cpp2IlInjected.Address(RVA = "0xA35EBE0", Offset = "0xA35DFE0", VA = "0x18A35EBE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid UEZCNKGUFAV
				{
					[Cpp2IlInjected.Token(Token = "0x600027B")]
					[Cpp2IlInjected.Address(RVA = "0xA3572E0", Offset = "0xA3566E0", VA = "0x18A3572E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid PGEMIFFEGBJ
				{
					[Cpp2IlInjected.Token(Token = "0x600027C")]
					[Cpp2IlInjected.Address(RVA = "0xA359C60", Offset = "0xA359060", VA = "0x18A359C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid PSTQEMGHFJI
				{
					[Cpp2IlInjected.Token(Token = "0x600027D")]
					[Cpp2IlInjected.Address(RVA = "0xA355CE0", Offset = "0xA3550E0", VA = "0x18A355CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid WVETTUMQJOF
				{
					[Cpp2IlInjected.Token(Token = "0x600027E")]
					[Cpp2IlInjected.Address(RVA = "0xA351120", Offset = "0xA350520", VA = "0x18A351120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid CPCXTABMHOI
				{
					[Cpp2IlInjected.Token(Token = "0x600027F")]
					[Cpp2IlInjected.Address(RVA = "0xA353E60", Offset = "0xA353260", VA = "0x18A353E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid NCMMYGYZBFE
				{
					[Cpp2IlInjected.Token(Token = "0x6000280")]
					[Cpp2IlInjected.Address(RVA = "0xA35BA60", Offset = "0xA35AE60", VA = "0x18A35BA60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid VDGTCKCAWCX
				{
					[Cpp2IlInjected.Token(Token = "0x6000281")]
					[Cpp2IlInjected.Address(RVA = "0xA3533E0", Offset = "0xA3527E0", VA = "0x18A3533E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid TKFWWLFWNSW
				{
					[Cpp2IlInjected.Token(Token = "0x6000282")]
					[Cpp2IlInjected.Address(RVA = "0xA3546E0", Offset = "0xA353AE0", VA = "0x18A3546E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid YKOPBXKMPCW
				{
					[Cpp2IlInjected.Token(Token = "0x6000283")]
					[Cpp2IlInjected.Address(RVA = "0xA355360", Offset = "0xA354760", VA = "0x18A355360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid HWIPNTSBZBX
				{
					[Cpp2IlInjected.Token(Token = "0x6000284")]
					[Cpp2IlInjected.Address(RVA = "0xA351560", Offset = "0xA350960", VA = "0x18A351560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid TYWOXIJKVVD
				{
					[Cpp2IlInjected.Token(Token = "0x6000285")]
					[Cpp2IlInjected.Address(RVA = "0xA353B60", Offset = "0xA352F60", VA = "0x18A353B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid ATYGUIYAWJE
				{
					[Cpp2IlInjected.Token(Token = "0x6000286")]
					[Cpp2IlInjected.Address(RVA = "0xA3528E0", Offset = "0xA351CE0", VA = "0x18A3528E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid DFWHSIXKCLZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000287")]
					[Cpp2IlInjected.Address(RVA = "0xA352A60", Offset = "0xA351E60", VA = "0x18A352A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid UFYDJJVLLEP
				{
					[Cpp2IlInjected.Token(Token = "0x6000288")]
					[Cpp2IlInjected.Address(RVA = "0xA35F660", Offset = "0xA35EA60", VA = "0x18A35F660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid KQMMTYCGFYN
				{
					[Cpp2IlInjected.Token(Token = "0x6000289")]
					[Cpp2IlInjected.Address(RVA = "0xA352DE0", Offset = "0xA3521E0", VA = "0x18A352DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid SVVTZSXYFOM
				{
					[Cpp2IlInjected.Token(Token = "0x600028A")]
					[Cpp2IlInjected.Address(RVA = "0xA35C5E0", Offset = "0xA35B9E0", VA = "0x18A35C5E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid XERMJIHDPXI
				{
					[Cpp2IlInjected.Token(Token = "0x600028B")]
					[Cpp2IlInjected.Address(RVA = "0xA355AE0", Offset = "0xA354EE0", VA = "0x18A355AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid NNQQROVIHKF
				{
					[Cpp2IlInjected.Token(Token = "0x600028C")]
					[Cpp2IlInjected.Address(RVA = "0xA3544E0", Offset = "0xA3538E0", VA = "0x18A3544E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid ANTRQWASITR
				{
					[Cpp2IlInjected.Token(Token = "0x600028D")]
					[Cpp2IlInjected.Address(RVA = "0xA360960", Offset = "0xA35FD60", VA = "0x18A360960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid VRYENXTPDWM
				{
					[Cpp2IlInjected.Token(Token = "0x600028E")]
					[Cpp2IlInjected.Address(RVA = "0xA354360", Offset = "0xA353760", VA = "0x18A354360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid QXIJWRYDTPS
				{
					[Cpp2IlInjected.Token(Token = "0x600028F")]
					[Cpp2IlInjected.Address(RVA = "0xA357460", Offset = "0xA356860", VA = "0x18A357460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid QXYEOMFVVXT
				{
					[Cpp2IlInjected.Token(Token = "0x6000290")]
					[Cpp2IlInjected.Address(RVA = "0xA3574E0", Offset = "0xA3568E0", VA = "0x18A3574E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid ORJGLDUGAYO
				{
					[Cpp2IlInjected.Token(Token = "0x6000291")]
					[Cpp2IlInjected.Address(RVA = "0xA35F6E0", Offset = "0xA35EAE0", VA = "0x18A35F6E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid LVGVVJCIIMH
				{
					[Cpp2IlInjected.Token(Token = "0x6000292")]
					[Cpp2IlInjected.Address(RVA = "0xA3541E0", Offset = "0xA3535E0", VA = "0x18A3541E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid KYLNYSGSZBT
				{
					[Cpp2IlInjected.Token(Token = "0x6000293")]
					[Cpp2IlInjected.Address(RVA = "0xA3561E0", Offset = "0xA3555E0", VA = "0x18A3561E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid AXCMKEGKBRH
				{
					[Cpp2IlInjected.Token(Token = "0x6000294")]
					[Cpp2IlInjected.Address(RVA = "0xA360B60", Offset = "0xA35FF60", VA = "0x18A360B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid VYPXIOGTSOO
				{
					[Cpp2IlInjected.Token(Token = "0x6000295")]
					[Cpp2IlInjected.Address(RVA = "0xA355A60", Offset = "0xA354E60", VA = "0x18A355A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid GUGIEGDKXRH
				{
					[Cpp2IlInjected.Token(Token = "0x6000296")]
					[Cpp2IlInjected.Address(RVA = "0xA351CE0", Offset = "0xA3510E0", VA = "0x18A351CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid DMXMBVISWAM
				{
					[Cpp2IlInjected.Token(Token = "0x6000297")]
					[Cpp2IlInjected.Address(RVA = "0xA35D7E0", Offset = "0xA35CBE0", VA = "0x18A35D7E0")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA3744B0", Offset = "0xA3738B0", VA = "0x18A3744B0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA364980", Offset = "0xA363D80", VA = "0x18A364980")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> AQPBFJQDBGU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class ZAHSRWXQMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA364540", Offset = "0xA363940", VA = "0x18A364540")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class FVSAJVIJQYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xA350330", Offset = "0xA34F730", VA = "0x18A350330")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class LWFZXYXOLJD
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA3504F0", Offset = "0xA34F8F0", VA = "0x18A3504F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class SYNIATIVYOG
		{
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private static readonly Dictionary<Guid, float> NQZJROWXPWG;

			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private static readonly Dictionary<Guid, float> CHRCZDIQMOH;

			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private static readonly Dictionary<Guid, bool> SXJMUVLIXEM;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA3621F0", Offset = "0xA3615F0", VA = "0x18A3621F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class SYSOYACTHZP
		{
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			private static readonly Dictionary<Guid, float> ELNWSGCXQVZ;

			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private static readonly Dictionary<Guid, float> NMBLDQMBHEC;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA376E40", Offset = "0xA376240", VA = "0x18A376E40")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class QLFTJYVCZEP
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA374F20", Offset = "0xA374320", VA = "0x18A374F20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class ZXYXPXBOJQN
		{
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			private static readonly Dictionary<Guid, int> ATPMOXQBOEF;

			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private static readonly Dictionary<Guid, bool> UOPKTVBNTSZ;

			[Cpp2IlInjected.Token(Token = "0x400024D")]
			private static readonly Dictionary<Guid, bool> KYHKRBEJMCO;

			[Cpp2IlInjected.Token(Token = "0x400024E")]
			private static readonly Dictionary<Guid, int> ZHXSAKMTZTY;

			[Cpp2IlInjected.Token(Token = "0x400024F")]
			private static readonly Dictionary<Guid, bool> HYKSDWQPSHX;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xA37AC30", Offset = "0xA37A030", VA = "0x18A37AC30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class ZXOJVJNTQTV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA37AA70", Offset = "0xA379E70", VA = "0x18A37AA70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static Versioner<TVWXLXTXIIP, PersistedRoomData, PersistedRoomVersion> ODUEJTQHMXY;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Dictionary<Guid, int> MUZFLLOCSTT;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Guid RZHXOHLCINR;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Guid CYZWJZCEUPL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly float UDMRIJZREYN;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA333A00", Offset = "0xA332E00", VA = "0x18A333A00")]
		public static PersistedRoomData NMQWIQIHKWC(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3338D0", Offset = "0xA332CD0", VA = "0x18A3338D0")]
		public static Result<ParseResult<PersistedRoomData>, OKJLNQTBITD> NFLVTITSIIU(TVWXLXTXIIP a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3335F0", Offset = "0xA3329F0", VA = "0x18A3335F0")]
		public static Result<ParseResult<PersistedRoomData>, OKJLNQTBITD> NFLVTITSIIU(TVWXLXTXIIP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA333B20", Offset = "0xA332F20", VA = "0x18A333B20")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(TVWXLXTXIIP a, PersistedRoomData b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA333510", Offset = "0xA332910", VA = "0x18A333510")]
		public static Guid DCDUBRBKFWO(NOJIAPKTUHF a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class RLTUXUEUFTI
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public interface TVWXLXTXIIP : XQBBWHWJDSP<KWFNBZIYXRE, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public sealed class TLGMPNEBIBW : TVWXLXTXIIP, XQBBWHWJDSP<KWFNBZIYXRE, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public static TLGMPNEBIBW LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			public PlayerSaveVersion FPWGPTAFBFH()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xD5FC60", Offset = "0xD5F060", VA = "0x180D5FC60", Slot = "5")]
			public PlayerSaveVersion CHWBOBYGKCX()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1AE4550", Offset = "0x1AE3950", VA = "0x181AE4550", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E6B0", Offset = "0x2F0DAB0", VA = "0x182F0E6B0", Slot = "7")]
			public bool WLQARKELXXK(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA378330", Offset = "0xA377730", VA = "0x18A378330", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public TLGMPNEBIBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static Versioner<TVWXLXTXIIP, KWFNBZIYXRE, PlayerSaveVersion> ODUEJTQHMXY;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA375110", Offset = "0xA374510", VA = "0x18A375110")]
		public static KWFNBZIYXRE? BVYIVXIANOA([Optional] GULGPXNWFWU? a, [Optional] TERHGMWHYMM? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA375870", Offset = "0xA374C70", VA = "0x18A375870")]
		public static Result<ParseResult<KWFNBZIYXRE>, OKJLNQTBITD> NFLVTITSIIU(TVWXLXTXIIP a, byte[]? bytes)
		{
			return default(Result<ParseResult<KWFNBZIYXRE>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3753F0", Offset = "0xA3747F0", VA = "0x18A3753F0")]
		public static Result<ParseResult<KWFNBZIYXRE>, OKJLNQTBITD> NFLVTITSIIU(TVWXLXTXIIP deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<KWFNBZIYXRE>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA376520", Offset = "0xA375920", VA = "0x18A376520")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(TVWXLXTXIIP a, KWFNBZIYXRE b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3759A0", Offset = "0xA374DA0", VA = "0x18A3759A0")]
		public static void QJPQFWRYBRV(KWFNBZIYXRE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA375CA0", Offset = "0xA3750A0", VA = "0x18A375CA0")]
		public static void QJUXDDLVLDE(KWFNBZIYXRE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA375EE0", Offset = "0xA3752E0", VA = "0x18A375EE0")]
		public static void QKAEAKFSUON(KWFNBZIYXRE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA376380", Offset = "0xA375780", VA = "0x18A376380")]
		public static void QKFKXQZQDZW(KWFNBZIYXRE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3764B0", Offset = "0xA3758B0", VA = "0x18A3764B0")]
		public static void QKKRUXTNNLF(KWFNBZIYXRE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3769F0", Offset = "0xA375DF0", VA = "0x18A3769F0")]
		private static TERHGMWHYMM XSAWOGXRVPY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA376AD0", Offset = "0xA375ED0", VA = "0x18A376AD0")]
		private static TERHGMWHYMM XSGDLNRPFBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA376650", Offset = "0xA375A50", VA = "0x18A376650")]
		[CompilerGenerated]
		internal static bool QXLXNPGXWBD(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA376980", Offset = "0xA375D80", VA = "0x18A376980")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL WMQQQKZQBCP(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3750E0", Offset = "0xA3744E0", VA = "0x18A3750E0")]
		[CompilerGenerated]
		internal static float BLJPSVXFDRZ(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA375280", Offset = "0xA374680", VA = "0x18A375280")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL GKBSFZPKCLV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA376790", Offset = "0xA375B90", VA = "0x18A376790")]
		[CompilerGenerated]
		internal static int URZOHKSUJFQ(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA376680", Offset = "0xA375A80", VA = "0x18A376680")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL SGTEXMZZQUC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA3767C0", Offset = "0xA375BC0", VA = "0x18A3767C0")]
		[CompilerGenerated]
		internal static CircuitsQuat VICCMEYVVTN(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA376890", Offset = "0xA375C90", VA = "0x18A376890")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL VPGWROWMHDT(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3753D0", Offset = "0xA3747D0", VA = "0x18A3753D0")]
		[CompilerGenerated]
		internal static string MEVUYOAWAOI(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA376BB0", Offset = "0xA375FB0", VA = "0x18A376BB0")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL XUEGZPBZHVI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3752F0", Offset = "0xA3746F0", VA = "0x18A3752F0")]
		[CompilerGenerated]
		internal static CircuitsVec3 JYQUYBDVLVW(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA375200", Offset = "0xA374600", VA = "0x18A375200")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL FOWJNVQHPKK(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA376910", Offset = "0xA375D10", VA = "0x18A376910")]
		[CompilerGenerated]
		internal static int WAKOGHSTAQL(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA3766F0", Offset = "0xA375AF0", VA = "0x18A3766F0")]
		[CompilerGenerated]
		internal static AXWRZTCJDYL UAPEWVCNNIF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E09A70", Offset = "0x3E08E70", VA = "0x183E09A70")]
		[CompilerGenerated]
		internal static void APLTZIEXXUZ<a>(RepeatedField<VFVCDWYFOHW> a, Func<ByteString, a> deserialize, Func<a, AXWRZTCJDYL> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class UYGCBSWKSPS
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA378980", Offset = "0xA377D80", VA = "0x18A378980")]
		public static MSNHLFQHXDC QFVZLEHFMOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA378890", Offset = "0xA377C90", VA = "0x18A378890")]
		public static Result<ParseResult<MSNHLFQHXDC>, OKJLNQTBITD> NFLVTITSIIU(KRTSVWYVBMA.TVWXLXTXIIP a, byte[] b)
		{
			return default(Result<ParseResult<MSNHLFQHXDC>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA378540", Offset = "0xA377940", VA = "0x18A378540")]
		public static Result<ParseResult<MSNHLFQHXDC>, OKJLNQTBITD> NFLVTITSIIU(KRTSVWYVBMA.TVWXLXTXIIP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<MSNHLFQHXDC>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3789D0", Offset = "0xA377DD0", VA = "0x18A3789D0")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(KRTSVWYVBMA.TVWXLXTXIIP a, MSNHLFQHXDC b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class XXRCRSICMZJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA378F70", Offset = "0xA378370", VA = "0x18A378F70")]
		public static SpawnableTemplateData NMMKUYJYWKN([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA378E70", Offset = "0xA378270", VA = "0x18A378E70")]
		public static Result<ParseResult<SpawnableTemplateData>, OKJLNQTBITD> NFLVTITSIIU(KRTSVWYVBMA.TVWXLXTXIIP a, ZAKMQMYUKFI.TVWXLXTXIIP b, byte[] c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA378B50", Offset = "0xA377F50", VA = "0x18A378B50")]
		public static Result<ParseResult<SpawnableTemplateData>, OKJLNQTBITD> NFLVTITSIIU(KRTSVWYVBMA.TVWXLXTXIIP a, ZAKMQMYUKFI.TVWXLXTXIIP b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3793B0", Offset = "0xA3787B0", VA = "0x18A3793B0")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(KRTSVWYVBMA.TVWXLXTXIIP a, ZAKMQMYUKFI.TVWXLXTXIIP b, SpawnableTemplateData c)
		{
			return default(Result<None, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA378FF0", Offset = "0xA3783F0", VA = "0x18A378FF0")]
		private static Result<None, OKJLNQTBITD> PLQWHXGFBQB(KRTSVWYVBMA.TVWXLXTXIIP a, SpawnableTemplateData b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA379620", Offset = "0xA378A20", VA = "0x18A379620")]
		private static Result<None, OKJLNQTBITD> TTPZXFMYRNJ(ZAKMQMYUKFI.TVWXLXTXIIP a, SpawnableTemplateData b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class ZAKMQMYUKFI
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public interface TVWXLXTXIIP : XQBBWHWJDSP<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class TLGMPNEBIBW : TVWXLXTXIIP, XQBBWHWJDSP<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public static TLGMPNEBIBW LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			public SuperRoomVersion FPWGPTAFBFH()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "5")]
			public SuperRoomVersion CHWBOBYGKCX()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1AE4550", Offset = "0x1AE3950", VA = "0x181AE4550", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E6B0", Offset = "0x2F0DAB0", VA = "0x182F0E6B0", Slot = "7")]
			public bool WLQARKELXXK(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA3782E0", Offset = "0xA3776E0", VA = "0x18A3782E0", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public TLGMPNEBIBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static Versioner<TVWXLXTXIIP, SuperRoomData, SuperRoomVersion> ODUEJTQHMXY;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA37A7A0", Offset = "0xA379BA0", VA = "0x18A37A7A0")]
		public static SuperRoomData SXUDJBDQGUU([Optional] MGHTQQONCWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA379EA0", Offset = "0xA3792A0", VA = "0x18A379EA0")]
		public static Result<ParseResult<SuperRoomData>, OKJLNQTBITD> NFLVTITSIIU(TVWXLXTXIIP a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA379FD0", Offset = "0xA3793D0", VA = "0x18A379FD0")]
		public static Result<ParseResult<SuperRoomData>, OKJLNQTBITD> NFLVTITSIIU(TVWXLXTXIIP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA37A670", Offset = "0xA379A70", VA = "0x18A37A670")]
		public static Result<None, OKJLNQTBITD> QVCOCVJUYJL(TVWXLXTXIIP a, SuperRoomData b)
		{
			return default(Result<None, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA37A2A0", Offset = "0xA3796A0", VA = "0x18A37A2A0")]
		private static void QJPQFWRYBRV(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA37A460", Offset = "0xA379860", VA = "0x18A37A460")]
		private static void QJUXDDLVLDE(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA37A560", Offset = "0xA379960", VA = "0x18A37A560")]
		private static void QKAEAKFSUON(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA37A5F0", Offset = "0xA3799F0", VA = "0x18A37A5F0")]
		private static void QKFKXQZQDZW(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA379B90", Offset = "0xA378F90", VA = "0x18A379B90")]
		public static DataTableData ICZASQBSDBJ(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3797C0", Offset = "0xA378BC0", VA = "0x18A3797C0")]
		public static ProgressionManagerData FITDOLUQKCQ(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3799D0", Offset = "0xA378DD0", VA = "0x18A3799D0")]
		[CompilerGenerated]
		internal static void GYLJNWTWKGC(RepeatedField<HBQDVLPKBTA> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class NUCHHRTXVWS : BNBYGMHSYJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA374EF0", Offset = "0xA3742F0", VA = "0x18A374EF0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA90", Offset = "0x2BAAE90", VA = "0x182BABA90")]
		public NUCHHRTXVWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface XQBBWHWJDSP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b FPWGPTAFBFH();

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b CHWBOBYGKCX();

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WLQARKELXXK(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class ABELQUNLZLM : BNBYGMHSYJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private string QDCROJGEOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private string LSKZEHWADYF;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA374D10", Offset = "0xA374110", VA = "0x18A374D10")]
		public ABELQUNLZLM(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA374CB0", Offset = "0xA3740B0", VA = "0x18A374CB0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x74460D0", Offset = "0x74454D0", VA = "0x1874460D0")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class UIURZYVZOTK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x4062440", Offset = "0x4061840", VA = "0x184062440")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class MPQBQDDYBGN : BNBYGMHSYJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private string QDCROJGEOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private string LSKZEHWADYF;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA374D10", Offset = "0xA374110", VA = "0x18A374D10")]
		public MPQBQDDYBGN(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA374E90", Offset = "0xA374290", VA = "0x18A374E90", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA378AA0", Offset = "0xA377EA0", VA = "0x18A378AA0")]
		public static Guid? RKAHSSHEHVL(TEAIRTFLUOM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : XQBBWHWJDSP<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x838F030", Offset = "0x838E430", VA = "0x18838F030")]
		public Result<TVersion, OKJLNQTBITD> QVCOCVJUYJL(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x838EEB0", Offset = "0x838E2B0", VA = "0x18838EEB0")]
		public static VersionerFactory<TDeps, TData, TVersion> GYMJYDCNRDR()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class JZPSQTWWHKR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public VersioningPhaseVoidDelegate<TDeps, TData> LWCHCHNSLVP;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public JZPSQTWWHKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x664C1F0", Offset = "0x664B5F0", VA = "0x18664C1F0")]
			internal Result<None, OKJLNQTBITD> NOQKNFELWPH(TDeps a, TData b)
			{
				return default(Result<None, OKJLNQTBITD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class ZMZGDOYHPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public VersioningPhaseVoidDelegate<TData> LWCHCHNSLVP;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ZMZGDOYHPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x508AF30", Offset = "0x508A330", VA = "0x18508AF30")]
			internal Result<None, OKJLNQTBITD> NOQKNFELWPH(TDeps a, TData b)
			{
				return default(Result<None, OKJLNQTBITD>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x838E810", Offset = "0x838DC10", VA = "0x18838E810")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x838E940", Offset = "0x838DD40", VA = "0x18838E940")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x838EAB0", Offset = "0x838DEB0", VA = "0x18838EAB0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class VXMACUMUVYB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x37CB740", Offset = "0x37CAB40", VA = "0x1837CB740")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : XQBBWHWJDSP<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class HTFIKUYUMCC : BNBYGMHSYJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly Exception OOGRBBKXJXR;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B45FC0", Offset = "0x1B453C0", VA = "0x181B45FC0")]
		public HTFIKUYUMCC(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA374E60", Offset = "0xA374260", VA = "0x18A374E60", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA374D60", Offset = "0xA374160", VA = "0x18A374D60", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class BNBYGMHSYJP : OKJLNQTBITD
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA90", Offset = "0x2BAAE90", VA = "0x182BABA90")]
		protected BNBYGMHSYJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate Result<None, OKJLNQTBITD> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
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
