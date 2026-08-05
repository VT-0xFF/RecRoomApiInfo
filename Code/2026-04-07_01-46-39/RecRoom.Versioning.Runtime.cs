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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xA577CD0", Offset = "0xA576CD0", VA = "0x18A577CD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class GKAUFRUWWQX
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface UYPXTMTCQYP : IILUJLRIDPN<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool TMKAGMRAUOV(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int GUGPSPDUXPA(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			RGEMMZCMHHA SPMSMYZNOCU(TransformData a, RGEMMZCMHHA b);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			float? KPDFEIYIGFJ(int a);

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			int GWYFJHJPKDE(int a);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			float GIAFFZMXGJR(int a);

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void XQSZDSBLBPF(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			ZRBMARSLXCF GZCYHIVCUVR();
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public abstract class EMEDYSEXMVG : UYPXTMTCQYP, IILUJLRIDPN<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "12")]
			public DEPRECATED_RoomPersistenceVersion ZUSWJYFBNKN()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA573120", Offset = "0xA572120", VA = "0x18A573120", Slot = "13")]
			public DEPRECATED_RoomPersistenceVersion CJYDMRKFWKX()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1AE5FD0", Offset = "0x1AE4FD0", VA = "0x181AE5FD0", Slot = "14")]
			public DEPRECATED_RoomPersistenceVersion Increment(DEPRECATED_RoomPersistenceVersion version)
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2F0DEE0", Offset = "0x2F0CEE0", VA = "0x182F0DEE0", Slot = "15")]
			public bool OFJYEGSNTSE(DEPRECATED_RoomPersistenceVersion a, DEPRECATED_RoomPersistenceVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA573260", Offset = "0xA572260", VA = "0x18A573260", Slot = "16")]
			public string ToString(DEPRECATED_RoomPersistenceVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "17")]
			public abstract bool TMKAGMRAUOV(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "18")]
			public abstract int GUGPSPDUXPA(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA573140", Offset = "0xA572140", VA = "0x18A573140", Slot = "6")]
			public RGEMMZCMHHA SPMSMYZNOCU(TransformData a, RGEMMZCMHHA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "19")]
			public abstract float? KPDFEIYIGFJ(int a);

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "20")]
			public abstract int GWYFJHJPKDE(int a);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "21")]
			public abstract float GIAFFZMXGJR(int a);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			public abstract void XQSZDSBLBPF(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			public abstract ZRBMARSLXCF GZCYHIVCUVR();

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			protected EMEDYSEXMVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class YCQCPNFXHPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class ZDMVDUVEHLH
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly string YMDTPYEUOGB;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static readonly string MSRBPAGMOFS;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private static readonly string UPTAWDDXDGX;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private static readonly string RNTGSTCTCFT;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private static readonly string SPLCAHDXKMF;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static readonly string GYRUXDYEUFY;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly string[] ACXYSONPGNN;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private static readonly string[] FUKOXVAPRCF;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA57BA80", Offset = "0xA57AA80", VA = "0x18A57BA80")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA57AC50", Offset = "0xA579C50", VA = "0x18A57AC50")]
			private static void HGWRXDXASQT(PersistedRoomData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA57BD60", Offset = "0xA57AD60", VA = "0x18A57BD60")]
			private static void UMJECYCWDKG(PersistedRoomData a, Func<JOAFFMPAQWM, NPSALNPWJFR> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA57AA30", Offset = "0xA579A30", VA = "0x18A57AA30")]
			private static JOAFFMPAQWM GFUEBSFCGND(PersistedRoomData a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA57B9E0", Offset = "0xA57A9E0", VA = "0x18A57B9E0")]
			private static void RZYSWTGOMGL(PersistedRoomData a, string b, Func<JOAFFMPAQWM, NPSALNPWJFR> c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA57BC20", Offset = "0xA57AC20", VA = "0x18A57BC20")]
			private static void TBWZJCQGTJW(PersistedRoomData a, string b, Func<JOAFFMPAQWM, VGLOFUAYFPS> c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA57B940", Offset = "0xA57A940", VA = "0x18A57B940")]
			private static void JQPXTWVOUAP(PersistedRoomData a, string b, Func<JOAFFMPAQWM, NPSALNPWJFR> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA57B8A0", Offset = "0xA57A8A0", VA = "0x18A57B8A0")]
			private static void JQPXTWVOUAP(PersistedRoomData a, string b, Func<JOAFFMPAQWM, VGLOFUAYFPS> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA57BCC0", Offset = "0xA57ACC0", VA = "0x18A57BCC0")]
			private static void TLRLIJDKCNS(PersistedRoomData a, string b, Func<JOAFFMPAQWM, NPSALNPWJFR> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class ZDHOGOBGXZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA57A650", Offset = "0xA579650", VA = "0x18A57A650")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class ZDCHJHHJOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA57A480", Offset = "0xA579480", VA = "0x18A57A480")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class ZEHWSVWTTER
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA57CD10", Offset = "0xA57BD10", VA = "0x18A57CD10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class ZECPVPCWJTI
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Guid YZITXHLOKEC;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private static readonly ByteString YLQKMCRYHGM;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA57C8F0", Offset = "0xA57B8F0", VA = "0x18A57C8F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class ZDXIYIIZAHZ
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private static readonly Guid XVLJSTIWOBO;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA57C590", Offset = "0xA57B590", VA = "0x18A57C590")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class ZDSCBBPBQWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA57C3D0", Offset = "0xA57B3D0", VA = "0x18A57C3D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class ZBWRZSRZJYN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA57A2C0", Offset = "0xA5792C0", VA = "0x18A57A2C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class ZBRLCLYCANE
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private static readonly Guid AEVROGGXMNG;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private static readonly Guid TRBFSPEVJWQ;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static readonly Guid WDLJAOBJLRW;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA579A40", Offset = "0xA578A40", VA = "0x18A579A40")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class ACFEMDCVCOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA571FF0", Offset = "0xA570FF0", VA = "0x18A571FF0")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class GEEACNDGXDQ
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly Guid KJKSDWHSFLQ;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static readonly Guid STYTAAEOSPY;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly Dictionary<int, Guid> LMXUVFTHFOS;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA574CA0", Offset = "0xA573CA0", VA = "0x18A574CA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class GEJGZTXEGOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA575660", Offset = "0xA574660", VA = "0x18A575660")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class GDYTFGJJNSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA574900", Offset = "0xA573900", VA = "0x18A574900")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class GDIYNMBRLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class GDOFKSVOUVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA5746B0", Offset = "0xA5736B0", VA = "0x18A5746B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class GCYKSYNWSNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class GDDRQFHUBYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA5744C0", Offset = "0xA5734C0", VA = "0x18A5744C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class GCNWYLABZQW
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly Guid WHCCDHGBNXU;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA5734E0", Offset = "0xA5724E0", VA = "0x18A5734E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class GCTDVRTZJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA573960", Offset = "0xA572960", VA = "0x18A573960")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA574410", Offset = "0xA573410", VA = "0x18A574410")]
			private static quaternion XWXNEWTLFPF(RGEMMZCMHHA a)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA573800", Offset = "0xA572800", VA = "0x18A573800")]
			private static RGEMMZCMHHA FFFLIFMTNVY(UYPXTMTCQYP a, float3 b, quaternion c, int d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA573EC0", Offset = "0xA572EC0", VA = "0x18A573EC0")]
			private static RGEMMZCMHHA VSNUOZXFUJE(UYPXTMTCQYP a, float3 b, quaternion c, int d, bool e)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class MYISKWYPWWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA577060", Offset = "0xA576060", VA = "0x18A577060")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class MYDLNQESNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA576E90", Offset = "0xA575E90", VA = "0x18A576E90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class MYNZIDSNGIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA577290", Offset = "0xA576290", VA = "0x18A577290")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class MZDTZYAFIQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA5776D0", Offset = "0xA5766D0", VA = "0x18A5776D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class MYYNCRGHZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA577480", Offset = "0xA576480", VA = "0x18A577480")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class MZOHULOABMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class MZJAXEUCSBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA577880", Offset = "0xA576880", VA = "0x18A577880")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class MZYVOZBUUJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA577B10", Offset = "0xA576B10", VA = "0x18A577B10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class ACPSGQQPVLK
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static readonly Guid BDWEENATJXK;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static readonly Guid YNBUHKZKSOT;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static readonly Guid KZPGYXRDOEW;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static readonly Guid WHCCDHGBNXU;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static readonly Guid MFHYHDLQNEL;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly Guid OASCQKZCQBD;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static readonly Guid TDAGXOPACYQ;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA572960", Offset = "0xA571960", VA = "0x18A572960")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA572670", Offset = "0xA571670", VA = "0x18A572670")]
			private static TWKOSUNKOYS QNJEVZVHFVV(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA5725D0", Offset = "0xA5715D0", VA = "0x18A5725D0")]
			private static TWKOSUNKOYS FGSJKCAKYHL(Guid a, bool b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA572C00", Offset = "0xA571C00", VA = "0x18A572C00")]
			private static TWKOSUNKOYS XVNKUXRYGXW(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class ACUZDXKNEWT
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static readonly Guid GVIEOZDQUTY;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA572E30", Offset = "0xA571E30", VA = "0x18A572E30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class AAJUKUFSVQP
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly Guid ZXXCRNEVFWU;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static readonly Guid WDLJAOBJLRW;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly Guid TTKSRECKCNT;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA55EC70", Offset = "0xA55DC70", VA = "0x18A55EC70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<UYPXTMTCQYP, PersistedRoomData, DEPRECATED_RoomPersistenceVersion> FIVUHTPVGUW;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA575940", Offset = "0xA574940", VA = "0x18A575940")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, PersistedRoomData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class GTGHYRDYGIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA576600", Offset = "0xA575600", VA = "0x18A576600")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(GKAUFRUWWQX.UYPXTMTCQYP a, SpawnableTemplateData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class VOUHRIHXBOE
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface UYPXTMTCQYP : IILUJLRIDPN<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public sealed class EMEDYSEXMVG : UYPXTMTCQYP, IILUJLRIDPN<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static EMEDYSEXMVG CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			public PersistedRoomVersion ZUSWJYFBNKN()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA573130", Offset = "0xA572130", VA = "0x18A573130", Slot = "5")]
			public PersistedRoomVersion CJYDMRKFWKX()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1AE5FD0", Offset = "0x1AE4FD0", VA = "0x181AE5FD0", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2F0DEE0", Offset = "0x2F0CEE0", VA = "0x182F0DEE0", Slot = "7")]
			public bool OFJYEGSNTSE(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA573210", Offset = "0xA572210", VA = "0x18A573210", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public EMEDYSEXMVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class ABZXOWIXTDJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static Dictionary<Guid, string[]> MINFYSSUYVD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA55F4F0", Offset = "0xA55E4F0", VA = "0x18A55F4F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class TRWSKZSTUTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA577D50", Offset = "0xA576D50", VA = "0x18A577D50")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TSRUAAUJGNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA578010", Offset = "0xA577010", VA = "0x18A578010")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class MWHDVUODGYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA576AA0", Offset = "0xA575AA0", VA = "0x18A576AA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class MWMKTBIAQKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA576C60", Offset = "0xA575C60", VA = "0x18A576C60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class FWQHJKBNMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA573320", Offset = "0xA572320", VA = "0x18A573320")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class YWOXCMBCZBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA5796F0", Offset = "0xA5786F0", VA = "0x18A5796F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class ZEHWSVWTTER
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA5933E0", Offset = "0xA5923E0", VA = "0x18A5933E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class ZDSCBBPBQWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA593210", Offset = "0xA592210", VA = "0x18A593210")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class GDYTFGJJNSH
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private static readonly Dictionary<Guid, int> JAFLEWRCRLO;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA57D710", Offset = "0xA57C710", VA = "0x18A57D710")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA57DE70", Offset = "0xA57CE70", VA = "0x18A57DE70")]
			private static Dictionary<Guid, FZCUOOHXFZF> UPMFFODJXXD(FZCUOOHXFZF a, Dictionary<Guid, FZCUOOHXFZF> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class GCTDVRTZJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA57D330", Offset = "0xA57C330", VA = "0x18A57D330")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class ACKLJJWSMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA57CFB0", Offset = "0xA57BFB0", VA = "0x18A57CFB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class SZBYWHHSASY
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA581EC0", Offset = "0xA580EC0", VA = "0x18A581EC0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA581EB0", Offset = "0xA580EB0", VA = "0x18A581EB0")]
			private static void JWGEOFBVTZD(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class SZMMQUVMTPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA5821A0", Offset = "0xA5811A0", VA = "0x18A5821A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class SYRLBTTXHWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA581AC0", Offset = "0xA580AC0", VA = "0x18A581AC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class TASCAJKWYFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA5823A0", Offset = "0xA5813A0", VA = "0x18A5823A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class TAXIXQEUHRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA582710", Offset = "0xA581710", VA = "0x18A582710")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class ACUZDXKNEWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA57D170", Offset = "0xA57C170", VA = "0x18A57D170")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class ZZIQAMBZXOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3C50", Offset = "0xA5A2C50", VA = "0x18A5A3C50")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ZYYCFYOFERX
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3A00", Offset = "0xA5A2A00", VA = "0x18A5A3A00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class ZYNOLLAKLVF
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
			private static class XYOTRXQYRVS
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid GZWTSSIQXIR
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0xA582EC0", Offset = "0xA581EC0", VA = "0x18A582EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid VHKBNMNYTFF
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0xA584690", Offset = "0xA583690", VA = "0x18A584690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid ANYNWJUISIG
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0xA593110", Offset = "0xA592110", VA = "0x18A593110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid IWAAQQJMEIG
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0xA58A990", Offset = "0xA589990", VA = "0x18A58A990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid QALVBMNQIIK
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0xA589390", Offset = "0xA588390", VA = "0x18A589390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid TPROCCNHKOW
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0xA587210", Offset = "0xA586210", VA = "0x18A587210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid AUSKKTFDDFP
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0xA58F190", Offset = "0xA58E190", VA = "0x18A58F190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid NHLFKGNGWKU
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0xA591010", Offset = "0xA590010", VA = "0x18A591010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid RLCXRVFZYTZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0xA583490", Offset = "0xA582490", VA = "0x18A583490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid KBIDHGWWUUK
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0xA589A90", Offset = "0xA588A90", VA = "0x18A589A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid RERCXMBXGTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0xA58C690", Offset = "0xA58B690", VA = "0x18A58C690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid LJHMCKTDVPF
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0xA58CE90", Offset = "0xA58BE90", VA = "0x18A58CE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid TPLJDWBCMFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0xA590A90", Offset = "0xA58FA90", VA = "0x18A590A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid GEIPISDREIC
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0xA58FA90", Offset = "0xA58EA90", VA = "0x18A58FA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid MMNVQBVNZEK
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xA585A90", Offset = "0xA584A90", VA = "0x18A585A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid CFVARGDMZRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0xA591890", Offset = "0xA590890", VA = "0x18A591890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid KVCEDAPYBQW
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0xA585290", Offset = "0xA584290", VA = "0x18A585290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid XTYOCPUEJYG
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0xA583090", Offset = "0xA582090", VA = "0x18A583090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid WJKFACFIYXN
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0xA585410", Offset = "0xA584410", VA = "0x18A585410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid ZFPRWZGAONJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0xA590490", Offset = "0xA58F490", VA = "0x18A590490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid RROMZRSXGDV
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0xA589D90", Offset = "0xA588D90", VA = "0x18A589D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid PQNBBZTOJWT
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0xA58ED90", Offset = "0xA58DD90", VA = "0x18A58ED90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid PNPYVYHOSPN
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0xA586C10", Offset = "0xA585C10", VA = "0x18A586C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid FRWOOJUDRPX
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0xA583410", Offset = "0xA582410", VA = "0x18A583410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid GDYLIHWUBAU
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0xA58E090", Offset = "0xA58D090", VA = "0x18A58E090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid RDDAVEUYLAN
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0xA589510", Offset = "0xA588510", VA = "0x18A589510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid DKPKTFNNQUT
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0xA58FD10", Offset = "0xA58ED10", VA = "0x18A58FD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid ICSJYDKSSDP
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0xA58F990", Offset = "0xA58E990", VA = "0x18A58F990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid VIZBGQEJTCT
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0xA583010", Offset = "0xA582010", VA = "0x18A583010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid EHQXSAZQAWE
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0xA590510", Offset = "0xA58F510", VA = "0x18A590510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid ZMSXVLSIWGC
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0xA584B90", Offset = "0xA583B90", VA = "0x18A584B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid NRBGHYPHLHB
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0xA583610", Offset = "0xA582610", VA = "0x18A583610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid LWEFUVATYYT
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0xA58FD90", Offset = "0xA58ED90", VA = "0x18A58FD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid GRGISMDCWEW
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0xA58D790", Offset = "0xA58C790", VA = "0x18A58D790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid YRRQKRTSHIW
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0xA58A910", Offset = "0xA589910", VA = "0x18A58A910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid RSPEVFPMELB
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0xA584110", Offset = "0xA583110", VA = "0x18A584110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid YQBBGBOHATD
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0xA583D90", Offset = "0xA582D90", VA = "0x18A583D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid IXLWRLCIXUM
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0xA592C10", Offset = "0xA591C10", VA = "0x18A592C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid KWFMLQOHPUU
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0xA588610", Offset = "0xA587610", VA = "0x18A588610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid ENRQCTQIGLL
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0xA589F10", Offset = "0xA588F10", VA = "0x18A589F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid CRXUMCGYXWY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0xA588810", Offset = "0xA587810", VA = "0x18A588810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid OLUXEFPPLEB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0xA592690", Offset = "0xA591690", VA = "0x18A592690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid UKSYPLRRCFF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0xA585690", Offset = "0xA584690", VA = "0x18A585690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid SHEKGIAHHKZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0xA589090", Offset = "0xA588090", VA = "0x18A589090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid ENIQOWBHBTJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0xA590290", Offset = "0xA58F290", VA = "0x18A590290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid SDSWLDPCHOC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0xA58E210", Offset = "0xA58D210", VA = "0x18A58E210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid NRPPKPKDTHR
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0xA591A10", Offset = "0xA590A10", VA = "0x18A591A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid WVQWJREYIHE
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0xA590F10", Offset = "0xA58FF10", VA = "0x18A590F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid LRVOHMMZVTH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0xA58E890", Offset = "0xA58D890", VA = "0x18A58E890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid ZMQFLNKEZNJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0xA58EF90", Offset = "0xA58DF90", VA = "0x18A58EF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid WIUNPUNJARY
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0xA58F310", Offset = "0xA58E310", VA = "0x18A58F310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid QPUMVYVJTQC
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xA58DC90", Offset = "0xA58CC90", VA = "0x18A58DC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid KLMKYWYNDSQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xA58D410", Offset = "0xA58C410", VA = "0x18A58D410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid RZHKSNECTQW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xA58BE10", Offset = "0xA58AE10", VA = "0x18A58BE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid QYOQTFZCRXN
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xA591990", Offset = "0xA590990", VA = "0x18A591990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid KOQGEZZOMDJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xA588E90", Offset = "0xA587E90", VA = "0x18A588E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid AHHVJVAQGPU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0xA591910", Offset = "0xA590910", VA = "0x18A591910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid LQEIOWYFTIH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xA587310", Offset = "0xA586310", VA = "0x18A587310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid KBORDBSCUHV
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0xA589D10", Offset = "0xA588D10", VA = "0x18A589D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid ZRYSKNGRCUM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xA589310", Offset = "0xA588310", VA = "0x18A589310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid CLVWKRSQBEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xA583910", Offset = "0xA582910", VA = "0x18A583910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid LCYEMEUBUZW
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xA58C210", Offset = "0xA58B210", VA = "0x18A58C210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid BWARZNGWAUA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xA590110", Offset = "0xA58F110", VA = "0x18A590110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid GRLOCKJMGQG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xA587990", Offset = "0xA586990", VA = "0x18A587990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid LQLXMWQVFWO
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0xA590C90", Offset = "0xA58FC90", VA = "0x18A590C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid KTPICEOCIFG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xA58CD10", Offset = "0xA58BD10", VA = "0x18A58CD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid BEBRTEXGTUG
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0xA58FB90", Offset = "0xA58EB90", VA = "0x18A58FB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid NJQRHXBLCRG
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0xA58CB90", Offset = "0xA58BB90", VA = "0x18A58CB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid NJTBYKQAUKH
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0xA591D90", Offset = "0xA590D90", VA = "0x18A591D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid VONFIWCKTZE
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xA58C310", Offset = "0xA58B310", VA = "0x18A58C310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid WQQWRTRXVOY
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xA584290", Offset = "0xA583290", VA = "0x18A584290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid RLKRNVQHNVP
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0xA583B10", Offset = "0xA582B10", VA = "0x18A583B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid ZUADKDONRIL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0xA583110", Offset = "0xA582110", VA = "0x18A583110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid MIDRZOKAEAC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xA584010", Offset = "0xA583010", VA = "0x18A584010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid MMPANAIXHVV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0xA591A90", Offset = "0xA590A90", VA = "0x18A591A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid SABDKJHSXWS
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0xA58B490", Offset = "0xA58A490", VA = "0x18A58B490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid TFPXZKDALLC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0xA58AE10", Offset = "0xA589E10", VA = "0x18A58AE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid MUQSSRPSLHT
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0xA590310", Offset = "0xA58F310", VA = "0x18A590310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid ETVMDHTJQDN
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0xA588710", Offset = "0xA587710", VA = "0x18A588710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid FGSFZFEZZRL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0xA58EA10", Offset = "0xA58DA10", VA = "0x18A58EA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid MYFDCHIMFCO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0xA58E790", Offset = "0xA58D790", VA = "0x18A58E790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid FFWZMVRSMFT
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0xA58E910", Offset = "0xA58D910", VA = "0x18A58E910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid LKOSOAAXEDW
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0xA592810", Offset = "0xA591810", VA = "0x18A592810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid LOCLHFCWGSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0xA592A90", Offset = "0xA591A90", VA = "0x18A592A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid GCLTEFMKNPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0xA58FE10", Offset = "0xA58EE10", VA = "0x18A58FE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid XFJDLOUPFSR
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0xA584890", Offset = "0xA583890", VA = "0x18A584890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid GWLEUZIAKIR
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0xA586690", Offset = "0xA585690", VA = "0x18A586690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid UHUMMAOHJCY
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0xA587410", Offset = "0xA586410", VA = "0x18A587410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid RWCPMNTFDYD
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0xA590390", Offset = "0xA58F390", VA = "0x18A590390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid KGNTQXDCHEU
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0xA58BC10", Offset = "0xA58AC10", VA = "0x18A58BC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid RCVKUVVLAGA
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0xA58E710", Offset = "0xA58D710", VA = "0x18A58E710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid KTGDCWKHTJB
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0xA58B110", Offset = "0xA58A110", VA = "0x18A58B110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid LRIIAQBYPJF
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0xA58E590", Offset = "0xA58D590", VA = "0x18A58E590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid MSWGQAMLIBO
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0xA586C90", Offset = "0xA585C90", VA = "0x18A586C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid KGSECYJGUKO
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0xA58B990", Offset = "0xA58A990", VA = "0x18A58B990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid KVXPAXRCRKY
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0xA591710", Offset = "0xA590710", VA = "0x18A591710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid XJWSXRCAHWR
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0xA592710", Offset = "0xA591710", VA = "0x18A592710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid GRCQDCTFWVK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0xA58DE90", Offset = "0xA58CE90", VA = "0x18A58DE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid ATOUGLGHYYV
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0xA592190", Offset = "0xA591190", VA = "0x18A592190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid ATEGLXSNGCD
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0xA592110", Offset = "0xA591110", VA = "0x18A592110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid IKFFDGMSTYG
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0xA58E010", Offset = "0xA58D010", VA = "0x18A58E010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid IKPSXUANMUY
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0xA58DF90", Offset = "0xA58CF90", VA = "0x18A58DF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid ILAGSHOIFRQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0xA58DF10", Offset = "0xA58CF10", VA = "0x18A58DF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid ZDJMCODLJZA
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0xA58C790", Offset = "0xA58B790", VA = "0x18A58C790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid WTOJHBOERJG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0xA58F890", Offset = "0xA58E890", VA = "0x18A58F890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid RMWXCIGHVHM
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0xA592310", Offset = "0xA591310", VA = "0x18A592310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid BCAAYFGBIVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0xA58BF10", Offset = "0xA58AF10", VA = "0x18A58BF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid LFEYHXHALIQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0xA587290", Offset = "0xA586290", VA = "0x18A587290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid GAJNBCPSJJS
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0xA58B890", Offset = "0xA58A890", VA = "0x18A58B890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid GABBNWIZIBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0xA589610", Offset = "0xA588610", VA = "0x18A589610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid RHRCBJNXSUU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xA588410", Offset = "0xA587410", VA = "0x18A588410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid QYHITPIBIBP
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0xA587390", Offset = "0xA586390", VA = "0x18A587390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid QQILSIPIOYX
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0xA584410", Offset = "0xA583410", VA = "0x18A584410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid YPQTEPBZDDH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0xA592D90", Offset = "0xA591D90", VA = "0x18A592D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid JETVCLACTWY
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0xA585A10", Offset = "0xA584A10", VA = "0x18A585A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid XBJQNKHLFID
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0xA585790", Offset = "0xA584790", VA = "0x18A585790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid ZYDTRHSSEFG
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0xA582D40", Offset = "0xA581D40", VA = "0x18A582D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid GHZCGJQURVX
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0xA586E90", Offset = "0xA585E90", VA = "0x18A586E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid AZGTQWKIPMP
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0xA586910", Offset = "0xA585910", VA = "0x18A586910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid PCIKEBLMXQI
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0xA583A90", Offset = "0xA582A90", VA = "0x18A583A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid KZZPLEXKODZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0xA589410", Offset = "0xA588410", VA = "0x18A589410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid TDCRXURBAGX
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0xA58D290", Offset = "0xA58C290", VA = "0x18A58D290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid TAXDYWBMMDR
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0xA58A410", Offset = "0xA589410", VA = "0x18A58A410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid WPAYEMFGOJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0xA58D310", Offset = "0xA58C310", VA = "0x18A58D310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid NMSVRWIWGIG
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0xA586390", Offset = "0xA585390", VA = "0x18A586390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid AQQDAENWXEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0xA584810", Offset = "0xA583810", VA = "0x18A584810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid VTYXTDECGFJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0xA592210", Offset = "0xA591210", VA = "0x18A592210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid LXIYCSVPMTC
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0xA589B90", Offset = "0xA588B90", VA = "0x18A589B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid BGMKJUNGTUU
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0xA58DB90", Offset = "0xA58CB90", VA = "0x18A58DB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid IYINSDDCIWI
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0xA58AE90", Offset = "0xA589E90", VA = "0x18A58AE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid ZNEKICPAHYE
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0xA588C90", Offset = "0xA587C90", VA = "0x18A588C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid QWTSGEJDSVD
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0xA58DB10", Offset = "0xA58CB10", VA = "0x18A58DB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid KIOBPSRDBVQ
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0xA587190", Offset = "0xA586190", VA = "0x18A587190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid LPVGDZPSSNX
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0xA58F290", Offset = "0xA58E290", VA = "0x18A58F290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid JETXOVVDDFP
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0xA58EB10", Offset = "0xA58DB10", VA = "0x18A58EB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid XRDAQPBZTXV
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xA589E10", Offset = "0xA588E10", VA = "0x18A589E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid QNFTZGZSUHO
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0xA58B290", Offset = "0xA58A290", VA = "0x18A58B290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid JJNRZJQIAFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0xA588090", Offset = "0xA587090", VA = "0x18A588090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid XWVHCGVPDRM
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0xA58D010", Offset = "0xA58C010", VA = "0x18A58D010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid ABABVEDHOJV
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0xA584C10", Offset = "0xA583C10", VA = "0x18A584C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid NEKRZHTVFDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0xA58D690", Offset = "0xA58C690", VA = "0x18A58D690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid IBCDDBLBZUS
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0xA591310", Offset = "0xA590310", VA = "0x18A591310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid IUDLIXQXWZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0xA591B90", Offset = "0xA590B90", VA = "0x18A591B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid XSXRGIVFOOP
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0xA58F410", Offset = "0xA58E410", VA = "0x18A58F410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid WHWRRKIISCO
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0xA582BC0", Offset = "0xA581BC0", VA = "0x18A582BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid ZXRZLNATOUP
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0xA586990", Offset = "0xA585990", VA = "0x18A586990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid GSRDZQZDICY
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0xA591690", Offset = "0xA590690", VA = "0x18A591690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid CLECBRYKXUL
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0xA590210", Offset = "0xA58F210", VA = "0x18A590210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid PTGFHNXLRUW
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0xA58BB10", Offset = "0xA58AB10", VA = "0x18A58BB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid CQJYNJSNPMQ
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0xA588690", Offset = "0xA587690", VA = "0x18A588690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid FPPLJBWTAJY
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0xA588C10", Offset = "0xA587C10", VA = "0x18A588C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid QVSEGTQPWUI
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0xA587110", Offset = "0xA586110", VA = "0x18A587110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid ZAFABXNNSSI
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0xA589910", Offset = "0xA588910", VA = "0x18A589910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid CWLGPTVSUCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0xA58A890", Offset = "0xA589890", VA = "0x18A58A890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid SQUHELSQYMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0xA58C890", Offset = "0xA58B890", VA = "0x18A58C890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid EGRNRQIPNWK
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0xA58B610", Offset = "0xA58A610", VA = "0x18A58B610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid URKUQXWXHMH
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0xA58C910", Offset = "0xA58B910", VA = "0x18A58C910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid UORPCGMLAQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0xA592510", Offset = "0xA591510", VA = "0x18A592510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid OCOVUQVOFRS
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0xA582DC0", Offset = "0xA581DC0", VA = "0x18A582DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid MZXHOMLVPTY
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0xA586590", Offset = "0xA585590", VA = "0x18A586590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid PLPARWSGGFT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xA58C090", Offset = "0xA58B090", VA = "0x18A58C090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid IUXPSHWNNIT
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xA58D190", Offset = "0xA58C190", VA = "0x18A58D190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid XKASHYTBEAB
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xA58B910", Offset = "0xA58A910", VA = "0x18A58B910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid AOKNIVRLLRA
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xA58FF90", Offset = "0xA58EF90", VA = "0x18A58FF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid SYBVOIILZEU
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0xA58C490", Offset = "0xA58B490", VA = "0x18A58C490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid VEZKCAVSVNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xA58F810", Offset = "0xA58E810", VA = "0x18A58F810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid VDUNPTKLZPH
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0xA589F90", Offset = "0xA588F90", VA = "0x18A589F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid VSAPRGDVBHX
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xA586190", Offset = "0xA585190", VA = "0x18A586190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid PVIUGGNFPGN
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0xA583F90", Offset = "0xA582F90", VA = "0x18A583F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid RRXWRJZSKON
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0xA585490", Offset = "0xA584490", VA = "0x18A585490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid VPOLFTGLYLG
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0xA58C010", Offset = "0xA58B010", VA = "0x18A58C010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid DLAZUVPKRDY
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0xA58FF10", Offset = "0xA58EF10", VA = "0x18A58FF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid JYQLHXIWUJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0xA586F90", Offset = "0xA585F90", VA = "0x18A586F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid QAZTCZLQNUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0xA58A810", Offset = "0xA589810", VA = "0x18A58A810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid IBZEWOQGCEP
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0xA586410", Offset = "0xA585410", VA = "0x18A586410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid DYUCCMYWLMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0xA588B10", Offset = "0xA587B10", VA = "0x18A588B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid VPPBKQTXOTS
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0xA58A690", Offset = "0xA589690", VA = "0x18A58A690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid YTNGMIQDHDB
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0xA58F390", Offset = "0xA58E390", VA = "0x18A58F390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid PJLMCVSZOCE
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0xA586790", Offset = "0xA585790", VA = "0x18A586790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid DRMXJHJSRTK
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0xA58C710", Offset = "0xA58B710", VA = "0x18A58C710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid HDZGNXURSNE
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0xA58A390", Offset = "0xA589390", VA = "0x18A58A390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid XZASNFDLPQR
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0xA58E410", Offset = "0xA58D410", VA = "0x18A58E410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid PQPRXHEFJEJ
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0xA588490", Offset = "0xA587490", VA = "0x18A588490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid YQBIRIQQLCT
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0xA591E90", Offset = "0xA590E90", VA = "0x18A591E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid SFJAPEYTZYT
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0xA589110", Offset = "0xA588110", VA = "0x18A589110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid SSDUEVXDUMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0xA590D90", Offset = "0xA58FD90", VA = "0x18A590D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid NDMUTLWRPFE
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0xA584510", Offset = "0xA583510", VA = "0x18A584510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid LVPOCEIKMHL
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0xA583F10", Offset = "0xA582F10", VA = "0x18A583F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid NEMFWEYWBEZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0xA590790", Offset = "0xA58F790", VA = "0x18A590790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid ZUJCIAEZZZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0xA586290", Offset = "0xA585290", VA = "0x18A586290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid QAQPYYHGIYH
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0xA583E10", Offset = "0xA582E10", VA = "0x18A583E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid JBJWDUENMOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0xA588210", Offset = "0xA587210", VA = "0x18A588210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid RJLYBSEJUBF
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0xA592410", Offset = "0xA591410", VA = "0x18A592410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid GVQTMTKSWKP
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0xA58CA10", Offset = "0xA58BA10", VA = "0x18A58CA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid GSPIAWQSMMA
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0xA58E810", Offset = "0xA58D810", VA = "0x18A58E810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid DVARNUVUYDE
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0xA587A10", Offset = "0xA586A10", VA = "0x18A587A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid KMLTKZKUFXF
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0xA58EF10", Offset = "0xA58DF10", VA = "0x18A58EF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid ZVXRJABONWD
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0xA58A590", Offset = "0xA589590", VA = "0x18A58A590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid NFHSHJHKAGC
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0xA58BA90", Offset = "0xA58AA90", VA = "0x18A58BA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid VTMHYYMQXFQ
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0xA583710", Offset = "0xA582710", VA = "0x18A583710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid GVMEMNULLOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xA591F90", Offset = "0xA590F90", VA = "0x18A591F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid DRUNLVAJFVD
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0xA58D890", Offset = "0xA58C890", VA = "0x18A58D890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid QOQRDGEHTTS
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xA583810", Offset = "0xA582810", VA = "0x18A583810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid IMVWPMIGRQC
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0xA58BD10", Offset = "0xA58AD10", VA = "0x18A58BD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid COOHQFQWVAY
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0xA582C40", Offset = "0xA581C40", VA = "0x18A582C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid QAHIQWZWSGV
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0xA58DA90", Offset = "0xA58CA90", VA = "0x18A58DA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid VMWWWPTGWJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0xA58C510", Offset = "0xA58B510", VA = "0x18A58C510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid PEUFNMNMLFO
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0xA58D810", Offset = "0xA58C810", VA = "0x18A58D810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid LHKJZQSSZHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0xA588B90", Offset = "0xA587B90", VA = "0x18A588B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid LOSZVKDLUHU
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0xA58D110", Offset = "0xA58C110", VA = "0x18A58D110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid QJHUINWYNPO
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0xA583D10", Offset = "0xA582D10", VA = "0x18A583D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid MOPELRCQXEI
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0xA584190", Offset = "0xA583190", VA = "0x18A584190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid PVLZLZCRCNW
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0xA586890", Offset = "0xA585890", VA = "0x18A586890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid IEUJQYHTWPU
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0xA58E190", Offset = "0xA58D190", VA = "0x18A58E190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid KOTMJPRGJNF
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0xA590E10", Offset = "0xA58FE10", VA = "0x18A590E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid SAPCITOHSNO
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0xA58EE10", Offset = "0xA58DE10", VA = "0x18A58EE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid EBXKGRDRUYC
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0xA588A10", Offset = "0xA587A10", VA = "0x18A588A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid QZZEBTDKHBM
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0xA591490", Offset = "0xA590490", VA = "0x18A591490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid LHDYYXKHFFG
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0xA58E110", Offset = "0xA58D110", VA = "0x18A58E110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid VWQKXGILFAP
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0xA587710", Offset = "0xA586710", VA = "0x18A587710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid IFCZXTIQTKD
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0xA589890", Offset = "0xA588890", VA = "0x18A589890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid TLDMFNJPHZX
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0xA58EE90", Offset = "0xA58DE90", VA = "0x18A58EE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid ZYIKVRQUTLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0xA58AA10", Offset = "0xA589A10", VA = "0x18A58AA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid DAMDFZUTAYQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0xA587D10", Offset = "0xA586D10", VA = "0x18A587D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid AEFFEKQAZJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0xA588110", Offset = "0xA587110", VA = "0x18A588110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid AJOOPAIFEBQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0xA584210", Offset = "0xA583210", VA = "0x18A584210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid FQHYEJQLZYN
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0xA58F790", Offset = "0xA58E790", VA = "0x18A58F790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid ZGEJFTJMESQ
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0xA587A90", Offset = "0xA586A90", VA = "0x18A587A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid PXNUJHCLJSP
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0xA58AC10", Offset = "0xA589C10", VA = "0x18A58AC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid IKKNZOFHWKI
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0xA586490", Offset = "0xA585490", VA = "0x18A586490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid TSHFYFSCKFY
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0xA588590", Offset = "0xA587590", VA = "0x18A588590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid DAEIMLBLHTJ
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0xA593190", Offset = "0xA592190", VA = "0x18A593190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid MGDNOZGSCJR
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0xA592290", Offset = "0xA591290", VA = "0x18A592290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid QFMSBKWQRDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0xA588890", Offset = "0xA587890", VA = "0x18A588890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid ZKXPRBFDRAC
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0xA585E10", Offset = "0xA584E10", VA = "0x18A585E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid ROIAGAKULDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0xA583690", Offset = "0xA582690", VA = "0x18A583690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid MTSTBFPLGFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0xA587D90", Offset = "0xA586D90", VA = "0x18A587D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid BXBWRXWQAVK
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0xA585D10", Offset = "0xA584D10", VA = "0x18A585D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid ESRINNXBBWX
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0xA588290", Offset = "0xA587290", VA = "0x18A588290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid XSVAOXELIFL
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0xA590C10", Offset = "0xA58FC10", VA = "0x18A590C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid CDPYZAJBQEJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0xA58E990", Offset = "0xA58D990", VA = "0x18A58E990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid MUEQWJLCETO
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0xA58F090", Offset = "0xA58E090", VA = "0x18A58F090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid HRPNKZWIDJU
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0xA586A90", Offset = "0xA585A90", VA = "0x18A586A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid LWOMIGAJMHO
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0xA592590", Offset = "0xA591590", VA = "0x18A592590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid BNJTQSVGIVP
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0xA584910", Offset = "0xA583910", VA = "0x18A584910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid YUSQDYFVJRV
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0xA585510", Offset = "0xA584510", VA = "0x18A585510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid MNHVXNQYBCK
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0xA591D10", Offset = "0xA590D10", VA = "0x18A591D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid UHUILHFUMFM
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0xA589210", Offset = "0xA588210", VA = "0x18A589210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid PCQPOYCABHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0xA585190", Offset = "0xA584190", VA = "0x18A585190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid EVUSSLCLXHI
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0xA591810", Offset = "0xA590810", VA = "0x18A591810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid CCAEQBVLCQD
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0xA585B90", Offset = "0xA584B90", VA = "0x18A585B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid FAOMLFIFEPC
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0xA583E90", Offset = "0xA582E90", VA = "0x18A583E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid ZSQACROOEQI
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0xA584A90", Offset = "0xA583A90", VA = "0x18A584A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid VCSDEVODJUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0xA591110", Offset = "0xA590110", VA = "0x18A591110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid SOIKTUZPBKN
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0xA58AF90", Offset = "0xA589F90", VA = "0x18A58AF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid AXMHXKJPINO
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0xA591410", Offset = "0xA590410", VA = "0x18A591410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid WWQFOCLHTTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0xA58CA90", Offset = "0xA58BA90", VA = "0x18A58CA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid AONMNGQBMYS
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0xA588F90", Offset = "0xA587F90", VA = "0x18A588F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid RDKQKHYHCCZ
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0xA590B90", Offset = "0xA58FB90", VA = "0x18A590B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid GVTWFAPVDMK
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0xA58A490", Offset = "0xA589490", VA = "0x18A58A490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid VRGEWJWAKJX
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0xA586D10", Offset = "0xA585D10", VA = "0x18A586D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid YBQWVHJFNFE
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0xA58AD90", Offset = "0xA589D90", VA = "0x18A58AD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid LIVGCVECMUT
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0xA58B090", Offset = "0xA58A090", VA = "0x18A58B090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid AUDLKHGGBEU
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0xA58E690", Offset = "0xA58D690", VA = "0x18A58E690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid RHAYXCFAMJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xA582CC0", Offset = "0xA581CC0", VA = "0x18A582CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid DFVRGLZTBTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0xA583C90", Offset = "0xA582C90", VA = "0x18A583C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid PEBWQPJEEYG
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xA589190", Offset = "0xA588190", VA = "0x18A589190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid DSFWXYDCDAJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0xA58FE90", Offset = "0xA58EE90", VA = "0x18A58FE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid EXQZBLLEVDM
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0xA58EA90", Offset = "0xA58DA90", VA = "0x18A58EA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid ENDSHPVUYHL
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0xA588190", Offset = "0xA587190", VA = "0x18A588190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid VNTPVJHLTXG
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0xA58E490", Offset = "0xA58D490", VA = "0x18A58E490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid JMEFTJIQQSL
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0xA583310", Offset = "0xA582310", VA = "0x18A583310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid BLJXKSZCJYZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0xA585010", Offset = "0xA584010", VA = "0x18A585010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid UEOGYDVANFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0xA586010", Offset = "0xA585010", VA = "0x18A586010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid GPMUIXNDRKX
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0xA582B40", Offset = "0xA581B40", VA = "0x18A582B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid USFGLZYWGGJ
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0xA590A10", Offset = "0xA58FA10", VA = "0x18A590A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid RZUYNOPTAQC
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0xA58B310", Offset = "0xA58A310", VA = "0x18A58B310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid URPLUFREDYI
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xA590990", Offset = "0xA58F990", VA = "0x18A590990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid URUSRMLBNJR
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0xA590910", Offset = "0xA58F910", VA = "0x18A590910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid DPLMRIEVDYP
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xA589590", Offset = "0xA588590", VA = "0x18A589590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid ZDFVGYWQWZI
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0xA58A790", Offset = "0xA589790", VA = "0x18A58A790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid ZDAOJSCTNNZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0xA58A610", Offset = "0xA589610", VA = "0x18A58A610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid KYMEJIQBJMD
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0xA58B210", Offset = "0xA58A210", VA = "0x18A58B210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid CGXKDAEVIID
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0xA58CF10", Offset = "0xA58BF10", VA = "0x18A58CF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid KOXZTDSAHRS
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xA591590", Offset = "0xA590590", VA = "0x18A591590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid YYKXKAJPORV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0xA58C590", Offset = "0xA58B590", VA = "0x18A58C590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid MIHEVGJKPIL
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xA585590", Offset = "0xA584590", VA = "0x18A585590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid LPGLBJAOUQA
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0xA586810", Offset = "0xA585810", VA = "0x18A586810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid VJPYVBPEDGK
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0xA58AC90", Offset = "0xA589C90", VA = "0x18A58AC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid ZFDTPPMSFXW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0xA585910", Offset = "0xA584910", VA = "0x18A585910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid GFVXOSCVOJN
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0xA587590", Offset = "0xA586590", VA = "0x18A587590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid THQTOQABDJA
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0xA589E90", Offset = "0xA588E90", VA = "0x18A589E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid HFHVYLPJTPK
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0xA584E10", Offset = "0xA583E10", VA = "0x18A584E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid CYMWJQVEKXQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0xA592090", Offset = "0xA591090", VA = "0x18A592090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid GAMHMINJRDN
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0xA58BF90", Offset = "0xA58AF90", VA = "0x18A58BF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid HMKBMEIPEZG
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0xA582AC0", Offset = "0xA581AC0", VA = "0x18A582AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid FMHEXYFGXWX
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0xA58DE10", Offset = "0xA58CE10", VA = "0x18A58DE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid LYBBDNUZZUT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0xA58CC10", Offset = "0xA58BC10", VA = "0x18A58CC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid DICEQKHCDTB
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0xA588390", Offset = "0xA587390", VA = "0x18A588390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid LURKZOMAWHU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0xA586F10", Offset = "0xA585F10", VA = "0x18A586F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid MJBSQJTKPIV
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0xA589710", Offset = "0xA588710", VA = "0x18A589710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid GHSSJJXILHI
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0xA58CC90", Offset = "0xA58BC90", VA = "0x18A58CC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid KMAXKOEYJQT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0xA592490", Offset = "0xA591490", VA = "0x18A592490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid VBYVYGTVKFA
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0xA584B10", Offset = "0xA583B10", VA = "0x18A584B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid ODELSWHQVKU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xA58F210", Offset = "0xA58E210", VA = "0x18A58F210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid LFXXEEOEIJK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0xA592910", Offset = "0xA591910", VA = "0x18A592910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid AEXWSWRLMYD
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xA588010", Offset = "0xA587010", VA = "0x18A588010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid KPLCWOKJPUJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0xA588910", Offset = "0xA587910", VA = "0x18A588910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid KMZXVZQOHCI
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xA586A10", Offset = "0xA585A10", VA = "0x18A586A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid EUVRKTPLHWC
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0xA58FB10", Offset = "0xA58EB10", VA = "0x18A58FB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid KGORWMHHZLT
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xA58D490", Offset = "0xA58C490", VA = "0x18A58D490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid FSMWBFXRTYM
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0xA58EB90", Offset = "0xA58DB90", VA = "0x18A58EB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid PIWWDNZVYZK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0xA58A210", Offset = "0xA589210", VA = "0x18A58A210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid SIFDCSKNNJO
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0xA588D90", Offset = "0xA587D90", VA = "0x18A588D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid UUKZIIXWBJI
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0xA587F10", Offset = "0xA586F10", VA = "0x18A587F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid HBCMSQSJEAB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xA58E290", Offset = "0xA58D290", VA = "0x18A58E290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid GTWPDXSNAFU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0xA58BE90", Offset = "0xA58AE90", VA = "0x18A58BE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid FHYGQHEAAGO
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xA591090", Offset = "0xA590090", VA = "0x18A591090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid MWKQQUINWFA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0xA58B010", Offset = "0xA58A010", VA = "0x18A58B010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid RDWKENXSSAY
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0xA587610", Offset = "0xA586610", VA = "0x18A587610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid QYIPSMNDLSQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0xA58C110", Offset = "0xA58B110", VA = "0x18A58C110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid EPCKQPHRYIE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0xA584F90", Offset = "0xA583F90", VA = "0x18A584F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid KQWOKFXUPFW
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0xA587910", Offset = "0xA586910", VA = "0x18A587910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid IRPFTULNLXB
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0xA585F90", Offset = "0xA584F90", VA = "0x18A585F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid FLFFTTVXUFQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0xA58DC10", Offset = "0xA58CC10", VA = "0x18A58DC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid KRNRKHGUIEL
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0xA591E10", Offset = "0xA590E10", VA = "0x18A591E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid SBHYYUMNWPP
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0xA585D90", Offset = "0xA584D90", VA = "0x18A585D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid ENEMCUOIKLN
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0xA589A10", Offset = "0xA588A10", VA = "0x18A589A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid JOVTWNBDSJM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0xA583A10", Offset = "0xA582A10", VA = "0x18A583A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid HKZRIBDOZMZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0xA587090", Offset = "0xA586090", VA = "0x18A587090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid QGRGZYPLIPQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0xA586E10", Offset = "0xA585E10", VA = "0x18A586E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid ENIGRSFOATT
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xA592610", Offset = "0xA591610", VA = "0x18A592610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid JIQWMAEESWI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0xA583B90", Offset = "0xA582B90", VA = "0x18A583B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid YROSRJPKLBX
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xA591B10", Offset = "0xA590B10", VA = "0x18A591B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid ZDNBUHOWKYI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0xA58C390", Offset = "0xA58B390", VA = "0x18A58C390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid ZUKCXQTNBLV
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0xA593010", Offset = "0xA592010", VA = "0x18A593010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid DJMLZYYOFEW
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0xA590690", Offset = "0xA58F690", VA = "0x18A590690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid IGHMEYCHPOO
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0xA592F90", Offset = "0xA591F90", VA = "0x18A592F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid JODPAHKHVAU
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0xA58B590", Offset = "0xA58A590", VA = "0x18A58B590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid OKJFZCTHEYX
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0xA58DD90", Offset = "0xA58CD90", VA = "0x18A58DD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid DQBGOPOHAUZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0xA586110", Offset = "0xA585110", VA = "0x18A586110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid BQKDPUDNEBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0xA584E90", Offset = "0xA583E90", VA = "0x18A584E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid NOYNWHLCVOE
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0xA58B410", Offset = "0xA58A410", VA = "0x18A58B410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid ZNMMILRIBNY
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0xA584590", Offset = "0xA583590", VA = "0x18A584590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid VIPKZOELWYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0xA584A10", Offset = "0xA583A10", VA = "0x18A584A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid LAOYJWWEULE
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0xA593090", Offset = "0xA592090", VA = "0x18A593090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid PIMLGZPXFCP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0xA58E310", Offset = "0xA58D310", VA = "0x18A58E310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid RFXOHADAVMK
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0xA587C10", Offset = "0xA586C10", VA = "0x18A587C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid RUVNVIEYTQU
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0xA585310", Offset = "0xA584310", VA = "0x18A585310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid HWQOPRDSOYW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0xA58CB10", Offset = "0xA58BB10", VA = "0x18A58CB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid KQTAUFGCFKT
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0xA583C10", Offset = "0xA582C10", VA = "0x18A583C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid QYYMDHPURBP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0xA588310", Offset = "0xA587310", VA = "0x18A588310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid URPSPIKETNQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0xA587690", Offset = "0xA586690", VA = "0x18A587690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid WELOPBOPUDS
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0xA591F10", Offset = "0xA590F10", VA = "0x18A591F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid PIGRXEZGDBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0xA58AB90", Offset = "0xA589B90", VA = "0x18A58AB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid OKUAEBGXSHR
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0xA588E10", Offset = "0xA587E10", VA = "0x18A588E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid WXSHGRUSSXB
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0xA583190", Offset = "0xA582190", VA = "0x18A583190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid DTNRLTMVTVU
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0xA58D210", Offset = "0xA58C210", VA = "0x18A58D210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid NCAMXCLHRHQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0xA589990", Offset = "0xA588990", VA = "0x18A589990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid NADNWDZDQVD
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0xA583890", Offset = "0xA582890", VA = "0x18A583890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid XAUZMZDVFTL
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0xA58F510", Offset = "0xA58E510", VA = "0x18A58F510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid LFDJCXHAEZQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0xA587810", Offset = "0xA586810", VA = "0x18A587810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid NFJPHDLSTNZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0xA586610", Offset = "0xA585610", VA = "0x18A586610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid GYHRRIGBKVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0xA584C90", Offset = "0xA583C90", VA = "0x18A584C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid WPVTWQOCSGQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0xA591510", Offset = "0xA590510", VA = "0x18A591510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid PJIMJZHURJX
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0xA584F10", Offset = "0xA583F10", VA = "0x18A584F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid RMLZOVVHYAJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0xA585110", Offset = "0xA584110", VA = "0x18A585110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid TORKUYEUYBF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0xA58D510", Offset = "0xA58C510", VA = "0x18A58D510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid EYGENMAQLTV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0xA585210", Offset = "0xA584210", VA = "0x18A585210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid EITEUWCZOAB
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0xA58F710", Offset = "0xA58E710", VA = "0x18A58F710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid NRPFQOOJZOI
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0xA584D90", Offset = "0xA583D90", VA = "0x18A584D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid UGMHMOFCJEO
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0xA586210", Offset = "0xA585210", VA = "0x18A586210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid QOTTNDLNYDV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0xA58E510", Offset = "0xA58D510", VA = "0x18A58E510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid BYDKOMCRTTG
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0xA584610", Offset = "0xA583610", VA = "0x18A584610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid EUHFIPNKKZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0xA58D590", Offset = "0xA58C590", VA = "0x18A58D590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid NBBTPXLOTWV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0xA586B90", Offset = "0xA585B90", VA = "0x18A586B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid WXOVDRSVLMS
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0xA585090", Offset = "0xA584090", VA = "0x18A585090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid JJCVEMHYDDQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0xA591190", Offset = "0xA590190", VA = "0x18A591190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid QJJXMDJYUMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0xA589C10", Offset = "0xA588C10", VA = "0x18A589C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid JXIAGOUGIBZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0xA591290", Offset = "0xA590290", VA = "0x18A591290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid VMKBGKLKTBU
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0xA582F90", Offset = "0xA581F90", VA = "0x18A582F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid IJXZNYPQXFK
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0xA583990", Offset = "0xA582990", VA = "0x18A583990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid EURXWBAEVNX
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0xA589790", Offset = "0xA588790", VA = "0x18A589790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid EEKGAARFACE
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0xA592890", Offset = "0xA591890", VA = "0x18A592890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid VDRWHFKBRXT
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0xA588510", Offset = "0xA587510", VA = "0x18A588510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid DCZORJPOJWP
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0xA58A190", Offset = "0xA589190", VA = "0x18A58A190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid OTDSPRBPSJH
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0xA585610", Offset = "0xA584610", VA = "0x18A585610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid BZANJYTCZSW
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0xA587490", Offset = "0xA586490", VA = "0x18A587490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid EGUYJWNLZCM
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0xA585890", Offset = "0xA584890", VA = "0x18A585890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid NJWWJTLDINY
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0xA58CF90", Offset = "0xA58BF90", VA = "0x18A58CF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid PCMDGYOCPBG
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0xA58DD10", Offset = "0xA58CD10", VA = "0x18A58DD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid CVKDJFZEGEK
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0xA587790", Offset = "0xA586790", VA = "0x18A587790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid UTXNQARWPWK
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0xA58E610", Offset = "0xA58D610", VA = "0x18A58E610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid VPQXPUUJZYW
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0xA58F110", Offset = "0xA58E110", VA = "0x18A58F110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid SLZHAMICWQW
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0xA58A510", Offset = "0xA589510", VA = "0x18A58A510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid KFWEVJUQOCP
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0xA588A90", Offset = "0xA587A90", VA = "0x18A588A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid PERQJIOWLSP
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0xA588990", Offset = "0xA587990", VA = "0x18A588990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid FRCLGNKMGEM
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0xA591790", Offset = "0xA590790", VA = "0x18A591790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid RHSKVWXIROU
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0xA587B10", Offset = "0xA586B10", VA = "0x18A587B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid VERWNWXWHSQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0xA590010", Offset = "0xA58F010", VA = "0x18A590010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid JBAXOTHXSZP
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0xA58FC10", Offset = "0xA58EC10", VA = "0x18A58FC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid YPIPBQHIWBI
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0xA584990", Offset = "0xA583990", VA = "0x18A584990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid CZXEPUKGCUJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0xA584790", Offset = "0xA583790", VA = "0x18A584790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid ETLLKBUUPTP
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0xA58D390", Offset = "0xA58C390", VA = "0x18A58D390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid FORMNUMCZCJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0xA58A290", Offset = "0xA589290", VA = "0x18A58A290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid UHAMCURQHNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0xA591610", Offset = "0xA590610", VA = "0x18A591610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid XBNYQKUVOSV
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0xA58C990", Offset = "0xA58B990", VA = "0x18A58C990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid KWCTNYTRGYK
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0xA591C90", Offset = "0xA590C90", VA = "0x18A591C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid QFKAMVTMOGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0xA586D90", Offset = "0xA585D90", VA = "0x18A586D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid CGIKZEHHHPW
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0xA589C90", Offset = "0xA588C90", VA = "0x18A589C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid AWMYHACJDMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0xA592010", Offset = "0xA591010", VA = "0x18A592010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid YEXHOUHUXVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0xA58B810", Offset = "0xA58A810", VA = "0x18A58B810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid OKXEDRPWTSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0xA590710", Offset = "0xA58F710", VA = "0x18A590710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid RSBXQDPCCDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0xA589290", Offset = "0xA588290", VA = "0x18A589290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid XSFZUDFPZSP
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0xA591C10", Offset = "0xA590C10", VA = "0x18A591C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid WARTSOZSXAU
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0xA592E90", Offset = "0xA591E90", VA = "0x18A592E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid UMXYHWJFJDJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0xA58BB90", Offset = "0xA58AB90", VA = "0x18A58BB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid EJQYQMEFDAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0xA587E90", Offset = "0xA586E90", VA = "0x18A587E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid UWNYTYSGHZW
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0xA58A310", Offset = "0xA589310", VA = "0x18A58A310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid TDLOTZRULIL
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0xA592F10", Offset = "0xA591F10", VA = "0x18A592F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid ACHICQEMAHZ
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0xA585810", Offset = "0xA584810", VA = "0x18A585810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid FQKZUBKROEI
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0xA584710", Offset = "0xA583710", VA = "0x18A584710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid HWWJKJVMKMY
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0xA58C290", Offset = "0xA58B290", VA = "0x18A58C290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid EWYEXRAGTTS
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0xA588790", Offset = "0xA587790", VA = "0x18A588790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid JGXCCYUDYVR
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0xA592B10", Offset = "0xA591B10", VA = "0x18A592B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid JHMWUTBWBDS
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0xA592C90", Offset = "0xA591C90", VA = "0x18A592C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid ZUPWDAFHPFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0xA592390", Offset = "0xA591390", VA = "0x18A592390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid WSRFXUDOFIH
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0xA58C810", Offset = "0xA58B810", VA = "0x18A58C810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid YZTRZXUTAAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0xA58F490", Offset = "0xA58E490", VA = "0x18A58F490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid OFOLIJXTHUY
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0xA585F10", Offset = "0xA584F10", VA = "0x18A585F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid CMJKHZUIYGR
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0xA58D610", Offset = "0xA58C610", VA = "0x18A58D610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid ADSZBFHAZLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0xA584390", Offset = "0xA583390", VA = "0x18A584390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid WOEKIDOJTHM
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0xA585390", Offset = "0xA584390", VA = "0x18A585390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid LSBSWDBGZQZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0xA58FA10", Offset = "0xA58EA10", VA = "0x18A58FA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid LDSYABNKTAF
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0xA591390", Offset = "0xA590390", VA = "0x18A591390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid FRKKJERGJGR
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0xA586510", Offset = "0xA585510", VA = "0x18A586510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid CIAEHDNMJSB
				{
					[Cpp2IlInjected.Token(Token = "0x600023C")]
					[Cpp2IlInjected.Address(RVA = "0xA588F10", Offset = "0xA587F10", VA = "0x18A588F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid FQMPPTYOZZW
				{
					[Cpp2IlInjected.Token(Token = "0x600023D")]
					[Cpp2IlInjected.Address(RVA = "0xA583390", Offset = "0xA582390", VA = "0x18A583390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid FLHKOXWGOOZ
				{
					[Cpp2IlInjected.Token(Token = "0x600023E")]
					[Cpp2IlInjected.Address(RVA = "0xA590D10", Offset = "0xA58FD10", VA = "0x18A590D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid KOYUCALVTDS
				{
					[Cpp2IlInjected.Token(Token = "0x600023F")]
					[Cpp2IlInjected.Address(RVA = "0xA585B10", Offset = "0xA584B10", VA = "0x18A585B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid BFTCGNJJPOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000240")]
					[Cpp2IlInjected.Address(RVA = "0xA585E90", Offset = "0xA584E90", VA = "0x18A585E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid JFUKUBDCOBS
				{
					[Cpp2IlInjected.Token(Token = "0x6000241")]
					[Cpp2IlInjected.Address(RVA = "0xA590590", Offset = "0xA58F590", VA = "0x18A590590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid HXHGWYORUWI
				{
					[Cpp2IlInjected.Token(Token = "0x6000242")]
					[Cpp2IlInjected.Address(RVA = "0xA584D10", Offset = "0xA583D10", VA = "0x18A584D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid QPGWBWLCIXC
				{
					[Cpp2IlInjected.Token(Token = "0x6000243")]
					[Cpp2IlInjected.Address(RVA = "0xA58B790", Offset = "0xA58A790", VA = "0x18A58B790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid BNOPUCYJWPM
				{
					[Cpp2IlInjected.Token(Token = "0x6000244")]
					[Cpp2IlInjected.Address(RVA = "0xA592E10", Offset = "0xA591E10", VA = "0x18A592E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid REUXGFZNHRP
				{
					[Cpp2IlInjected.Token(Token = "0x6000245")]
					[Cpp2IlInjected.Address(RVA = "0xA585990", Offset = "0xA584990", VA = "0x18A585990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid BDAIQZPDDNX
				{
					[Cpp2IlInjected.Token(Token = "0x6000246")]
					[Cpp2IlInjected.Address(RVA = "0xA590610", Offset = "0xA58F610", VA = "0x18A590610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid BJFLKABMYBC
				{
					[Cpp2IlInjected.Token(Token = "0x6000247")]
					[Cpp2IlInjected.Address(RVA = "0xA589690", Offset = "0xA588690", VA = "0x18A589690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid ASMRQIKGBPT
				{
					[Cpp2IlInjected.Token(Token = "0x6000248")]
					[Cpp2IlInjected.Address(RVA = "0xA58CD90", Offset = "0xA58BD90", VA = "0x18A58CD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid ALYUEZGNCLA
				{
					[Cpp2IlInjected.Token(Token = "0x6000249")]
					[Cpp2IlInjected.Address(RVA = "0xA589B10", Offset = "0xA588B10", VA = "0x18A589B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid MIJAFNFNCDZ
				{
					[Cpp2IlInjected.Token(Token = "0x600024A")]
					[Cpp2IlInjected.Address(RVA = "0xA58B690", Offset = "0xA58A690", VA = "0x18A58B690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid GHOKMNGNDKF
				{
					[Cpp2IlInjected.Token(Token = "0x600024B")]
					[Cpp2IlInjected.Address(RVA = "0xA590E90", Offset = "0xA58FE90", VA = "0x18A590E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid PDTYFXCPBBA
				{
					[Cpp2IlInjected.Token(Token = "0x600024C")]
					[Cpp2IlInjected.Address(RVA = "0xA58F010", Offset = "0xA58E010", VA = "0x18A58F010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid IIRYBGBZGHK
				{
					[Cpp2IlInjected.Token(Token = "0x600024D")]
					[Cpp2IlInjected.Address(RVA = "0xA583210", Offset = "0xA582210", VA = "0x18A583210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid MIRQAUJUPNT
				{
					[Cpp2IlInjected.Token(Token = "0x600024E")]
					[Cpp2IlInjected.Address(RVA = "0xA587E10", Offset = "0xA586E10", VA = "0x18A587E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid IYJFSXRFRQM
				{
					[Cpp2IlInjected.Token(Token = "0x600024F")]
					[Cpp2IlInjected.Address(RVA = "0xA590190", Offset = "0xA58F190", VA = "0x18A590190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid RZDQNRVILUB
				{
					[Cpp2IlInjected.Token(Token = "0x6000250")]
					[Cpp2IlInjected.Address(RVA = "0xA587B90", Offset = "0xA586B90", VA = "0x18A587B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid ZXAEIBYQJZS
				{
					[Cpp2IlInjected.Token(Token = "0x6000251")]
					[Cpp2IlInjected.Address(RVA = "0xA592A10", Offset = "0xA591A10", VA = "0x18A592A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid BGXTRRYIMTF
				{
					[Cpp2IlInjected.Token(Token = "0x6000252")]
					[Cpp2IlInjected.Address(RVA = "0xA58AD10", Offset = "0xA589D10", VA = "0x18A58AD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid RWZSKDZGEDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000253")]
					[Cpp2IlInjected.Address(RVA = "0xA58C190", Offset = "0xA58B190", VA = "0x18A58C190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid AEOJPRTZUEQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000254")]
					[Cpp2IlInjected.Address(RVA = "0xA587010", Offset = "0xA586010", VA = "0x18A587010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid JYYZAIACRZU
				{
					[Cpp2IlInjected.Token(Token = "0x6000255")]
					[Cpp2IlInjected.Address(RVA = "0xA58A010", Offset = "0xA589010", VA = "0x18A58A010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid HBUDSBNCGIE
				{
					[Cpp2IlInjected.Token(Token = "0x6000256")]
					[Cpp2IlInjected.Address(RVA = "0xA58F910", Offset = "0xA58E910", VA = "0x18A58F910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid DTBSYZLEZUF
				{
					[Cpp2IlInjected.Token(Token = "0x6000257")]
					[Cpp2IlInjected.Address(RVA = "0xA58B190", Offset = "0xA58A190", VA = "0x18A58B190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid QRBQFXTMYOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000258")]
					[Cpp2IlInjected.Address(RVA = "0xA587F90", Offset = "0xA586F90", VA = "0x18A587F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid RCMKVKMHZEK
				{
					[Cpp2IlInjected.Token(Token = "0x6000259")]
					[Cpp2IlInjected.Address(RVA = "0xA58AB10", Offset = "0xA589B10", VA = "0x18A58AB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid NCOUKWWICWG
				{
					[Cpp2IlInjected.Token(Token = "0x600025A")]
					[Cpp2IlInjected.Address(RVA = "0xA590890", Offset = "0xA58F890", VA = "0x18A590890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid BGXBSHBEJUV
				{
					[Cpp2IlInjected.Token(Token = "0x600025B")]
					[Cpp2IlInjected.Address(RVA = "0xA587C90", Offset = "0xA586C90", VA = "0x18A587C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid BZKGUUWOFPK
				{
					[Cpp2IlInjected.Token(Token = "0x600025C")]
					[Cpp2IlInjected.Address(RVA = "0xA587890", Offset = "0xA586890", VA = "0x18A587890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid YKNISJEYKEO
				{
					[Cpp2IlInjected.Token(Token = "0x600025D")]
					[Cpp2IlInjected.Address(RVA = "0xA58BD90", Offset = "0xA58AD90", VA = "0x18A58BD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid OOEJVSOLKTO
				{
					[Cpp2IlInjected.Token(Token = "0x600025E")]
					[Cpp2IlInjected.Address(RVA = "0xA58C610", Offset = "0xA58B610", VA = "0x18A58C610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid ILABUAFLFAQ
				{
					[Cpp2IlInjected.Token(Token = "0x600025F")]
					[Cpp2IlInjected.Address(RVA = "0xA58ED10", Offset = "0xA58DD10", VA = "0x18A58ED10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid KSZXXXOOQTG
				{
					[Cpp2IlInjected.Token(Token = "0x6000260")]
					[Cpp2IlInjected.Address(RVA = "0xA58E390", Offset = "0xA58D390", VA = "0x18A58E390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid WXBAYKULLHW
				{
					[Cpp2IlInjected.Token(Token = "0x6000261")]
					[Cpp2IlInjected.Address(RVA = "0xA58EC10", Offset = "0xA58DC10", VA = "0x18A58EC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid LRXTKQVAQLN
				{
					[Cpp2IlInjected.Token(Token = "0x6000262")]
					[Cpp2IlInjected.Address(RVA = "0xA58F690", Offset = "0xA58E690", VA = "0x18A58F690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid HMCPLWJJLIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000263")]
					[Cpp2IlInjected.Address(RVA = "0xA58BA10", Offset = "0xA58AA10", VA = "0x18A58BA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid VPXOABAINSF
				{
					[Cpp2IlInjected.Token(Token = "0x6000264")]
					[Cpp2IlInjected.Address(RVA = "0xA590F90", Offset = "0xA58FF90", VA = "0x18A590F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid MUHDANHORSL
				{
					[Cpp2IlInjected.Token(Token = "0x6000265")]
					[Cpp2IlInjected.Address(RVA = "0xA58B390", Offset = "0xA58A390", VA = "0x18A58B390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid SHZFCIGXSSD
				{
					[Cpp2IlInjected.Token(Token = "0x6000266")]
					[Cpp2IlInjected.Address(RVA = "0xA586310", Offset = "0xA585310", VA = "0x18A586310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid MRNDXPDAZLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000267")]
					[Cpp2IlInjected.Address(RVA = "0xA591210", Offset = "0xA590210", VA = "0x18A591210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid GUUQASKLYOO
				{
					[Cpp2IlInjected.Token(Token = "0x6000268")]
					[Cpp2IlInjected.Address(RVA = "0xA585C10", Offset = "0xA584C10", VA = "0x18A585C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid HGCFQRAVQOV
				{
					[Cpp2IlInjected.Token(Token = "0x6000269")]
					[Cpp2IlInjected.Address(RVA = "0xA589490", Offset = "0xA588490", VA = "0x18A589490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid CSGIXYAAHMW
				{
					[Cpp2IlInjected.Token(Token = "0x600026A")]
					[Cpp2IlInjected.Address(RVA = "0xA583590", Offset = "0xA582590", VA = "0x18A583590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid ROBMQOPTTZF
				{
					[Cpp2IlInjected.Token(Token = "0x600026B")]
					[Cpp2IlInjected.Address(RVA = "0xA590810", Offset = "0xA58F810", VA = "0x18A590810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid XCRELKCGKHP
				{
					[Cpp2IlInjected.Token(Token = "0x600026C")]
					[Cpp2IlInjected.Address(RVA = "0xA58DA10", Offset = "0xA58CA10", VA = "0x18A58DA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid XNURSWENVYX
				{
					[Cpp2IlInjected.Token(Token = "0x600026D")]
					[Cpp2IlInjected.Address(RVA = "0xA584490", Offset = "0xA583490", VA = "0x18A584490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid TXVQIUVTIGY
				{
					[Cpp2IlInjected.Token(Token = "0x600026E")]
					[Cpp2IlInjected.Address(RVA = "0xA58FC90", Offset = "0xA58EC90", VA = "0x18A58FC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid KTYNAOVEBFX
				{
					[Cpp2IlInjected.Token(Token = "0x600026F")]
					[Cpp2IlInjected.Address(RVA = "0xA585710", Offset = "0xA584710", VA = "0x18A585710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid LDZHJLSQUAE
				{
					[Cpp2IlInjected.Token(Token = "0x6000270")]
					[Cpp2IlInjected.Address(RVA = "0xA58C410", Offset = "0xA58B410", VA = "0x18A58C410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid LCAECJPWDVR
				{
					[Cpp2IlInjected.Token(Token = "0x6000271")]
					[Cpp2IlInjected.Address(RVA = "0xA592D10", Offset = "0xA591D10", VA = "0x18A592D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid DZOGXFQONYL
				{
					[Cpp2IlInjected.Token(Token = "0x6000272")]
					[Cpp2IlInjected.Address(RVA = "0xA58D910", Offset = "0xA58C910", VA = "0x18A58D910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid PNBDAJSQQDR
				{
					[Cpp2IlInjected.Token(Token = "0x6000273")]
					[Cpp2IlInjected.Address(RVA = "0xA58D710", Offset = "0xA58C710", VA = "0x18A58D710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid TEYTCBQLVUG
				{
					[Cpp2IlInjected.Token(Token = "0x6000274")]
					[Cpp2IlInjected.Address(RVA = "0xA58D990", Offset = "0xA58C990", VA = "0x18A58D990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid ACTYVRGGHYZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000275")]
					[Cpp2IlInjected.Address(RVA = "0xA585C90", Offset = "0xA584C90", VA = "0x18A585C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid WPNFCWGWRFY
				{
					[Cpp2IlInjected.Token(Token = "0x6000276")]
					[Cpp2IlInjected.Address(RVA = "0xA58EC90", Offset = "0xA58DC90", VA = "0x18A58EC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid RFVGSCUTNCB
				{
					[Cpp2IlInjected.Token(Token = "0x6000277")]
					[Cpp2IlInjected.Address(RVA = "0xA583290", Offset = "0xA582290", VA = "0x18A583290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid MYSFNLINNLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000278")]
					[Cpp2IlInjected.Address(RVA = "0xA58D090", Offset = "0xA58C090", VA = "0x18A58D090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid CIFPGHLZVYT
				{
					[Cpp2IlInjected.Token(Token = "0x6000279")]
					[Cpp2IlInjected.Address(RVA = "0xA584090", Offset = "0xA583090", VA = "0x18A584090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid ZBPSTZVEVRZ
				{
					[Cpp2IlInjected.Token(Token = "0x600027A")]
					[Cpp2IlInjected.Address(RVA = "0xA589810", Offset = "0xA588810", VA = "0x18A589810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid YPACJDJCRRD
				{
					[Cpp2IlInjected.Token(Token = "0x600027B")]
					[Cpp2IlInjected.Address(RVA = "0xA592990", Offset = "0xA591990", VA = "0x18A592990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid SHFDSFHHOVR
				{
					[Cpp2IlInjected.Token(Token = "0x600027C")]
					[Cpp2IlInjected.Address(RVA = "0xA587510", Offset = "0xA586510", VA = "0x18A587510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid IJGDHKFWGUG
				{
					[Cpp2IlInjected.Token(Token = "0x600027D")]
					[Cpp2IlInjected.Address(RVA = "0xA583510", Offset = "0xA582510", VA = "0x18A583510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid NGCXYSZTHPT
				{
					[Cpp2IlInjected.Token(Token = "0x600027E")]
					[Cpp2IlInjected.Address(RVA = "0xA592790", Offset = "0xA591790", VA = "0x18A592790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid NDGIKVGGNDW
				{
					[Cpp2IlInjected.Token(Token = "0x600027F")]
					[Cpp2IlInjected.Address(RVA = "0xA582F10", Offset = "0xA581F10", VA = "0x18A582F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid FOEIUVSGMHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000280")]
					[Cpp2IlInjected.Address(RVA = "0xA584310", Offset = "0xA583310", VA = "0x18A584310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid QVDQRSANSFJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000281")]
					[Cpp2IlInjected.Address(RVA = "0xA586090", Offset = "0xA585090", VA = "0x18A586090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid BIATIIYYDLM
				{
					[Cpp2IlInjected.Token(Token = "0x6000282")]
					[Cpp2IlInjected.Address(RVA = "0xA582A40", Offset = "0xA581A40", VA = "0x18A582A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid OKNTUCMKDWW
				{
					[Cpp2IlInjected.Token(Token = "0x6000283")]
					[Cpp2IlInjected.Address(RVA = "0xA58B510", Offset = "0xA58A510", VA = "0x18A58B510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid CFIHWOLEFSN
				{
					[Cpp2IlInjected.Token(Token = "0x6000284")]
					[Cpp2IlInjected.Address(RVA = "0xA582E40", Offset = "0xA581E40", VA = "0x18A582E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid FCRLFNCJQXD
				{
					[Cpp2IlInjected.Token(Token = "0x6000285")]
					[Cpp2IlInjected.Address(RVA = "0xA58AF10", Offset = "0xA589F10", VA = "0x18A58AF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid HCCNTUXEGPA
				{
					[Cpp2IlInjected.Token(Token = "0x6000286")]
					[Cpp2IlInjected.Address(RVA = "0xA58AA90", Offset = "0xA589A90", VA = "0x18A58AA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid FSNMVHOYQXB
				{
					[Cpp2IlInjected.Token(Token = "0x6000287")]
					[Cpp2IlInjected.Address(RVA = "0xA590090", Offset = "0xA58F090", VA = "0x18A590090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid CBQWKESDYHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000288")]
					[Cpp2IlInjected.Address(RVA = "0xA588D10", Offset = "0xA587D10", VA = "0x18A588D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid QYQERZHREMJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000289")]
					[Cpp2IlInjected.Address(RVA = "0xA590410", Offset = "0xA58F410", VA = "0x18A590410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid XZUGZTQSBBW
				{
					[Cpp2IlInjected.Token(Token = "0x600028A")]
					[Cpp2IlInjected.Address(RVA = "0xA586B10", Offset = "0xA585B10", VA = "0x18A586B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid LHUFEYLHGMS
				{
					[Cpp2IlInjected.Token(Token = "0x600028B")]
					[Cpp2IlInjected.Address(RVA = "0xA590B10", Offset = "0xA58FB10", VA = "0x18A590B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid REBHRISJZGV
				{
					[Cpp2IlInjected.Token(Token = "0x600028C")]
					[Cpp2IlInjected.Address(RVA = "0xA58F590", Offset = "0xA58E590", VA = "0x18A58F590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid AGBMMSYRPVR
				{
					[Cpp2IlInjected.Token(Token = "0x600028D")]
					[Cpp2IlInjected.Address(RVA = "0xA586710", Offset = "0xA585710", VA = "0x18A586710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid VIGNKBZFIKY
				{
					[Cpp2IlInjected.Token(Token = "0x600028E")]
					[Cpp2IlInjected.Address(RVA = "0xA58B710", Offset = "0xA58A710", VA = "0x18A58B710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid MTMZVRLEAPO
				{
					[Cpp2IlInjected.Token(Token = "0x600028F")]
					[Cpp2IlInjected.Address(RVA = "0xA58A090", Offset = "0xA589090", VA = "0x18A58A090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid MUCUNLSWCXP
				{
					[Cpp2IlInjected.Token(Token = "0x6000290")]
					[Cpp2IlInjected.Address(RVA = "0xA58A110", Offset = "0xA589110", VA = "0x18A58A110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid RJVZXRWDQTQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000291")]
					[Cpp2IlInjected.Address(RVA = "0xA58BC90", Offset = "0xA58AC90", VA = "0x18A58BC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid HLREYGFBEMX
				{
					[Cpp2IlInjected.Token(Token = "0x6000292")]
					[Cpp2IlInjected.Address(RVA = "0xA583790", Offset = "0xA582790", VA = "0x18A583790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid ZCQNVFPBSYZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000293")]
					[Cpp2IlInjected.Address(RVA = "0xA589010", Offset = "0xA588010", VA = "0x18A589010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid WIRMHJFXMRL
				{
					[Cpp2IlInjected.Token(Token = "0x6000294")]
					[Cpp2IlInjected.Address(RVA = "0xA58CE10", Offset = "0xA58BE10", VA = "0x18A58CE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid AUYROJUGQTU
				{
					[Cpp2IlInjected.Token(Token = "0x6000295")]
					[Cpp2IlInjected.Address(RVA = "0xA58F610", Offset = "0xA58E610", VA = "0x18A58F610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid MEIROKZCCCZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000296")]
					[Cpp2IlInjected.Address(RVA = "0xA58A710", Offset = "0xA589710", VA = "0x18A58A710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid QGUUNBRQJSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000297")]
					[Cpp2IlInjected.Address(RVA = "0xA592B90", Offset = "0xA591B90", VA = "0x18A592B90")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA593AE0", Offset = "0xA592AE0", VA = "0x18A593AE0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA593EC0", Offset = "0xA592EC0", VA = "0x18A593EC0")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> UGYNOEHKSPW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class ZYIHOEGNCJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA593700", Offset = "0xA592700", VA = "0x18A593700")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class HAFBWLDZWSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xA57F870", Offset = "0xA57E870", VA = "0x18A57F870")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class OAQZXWSFCZH
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA57FA30", Offset = "0xA57EA30", VA = "0x18A57FA30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class QFCBPZALOJY
		{
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private static readonly Dictionary<Guid, float> ZJKPYDHXSJU;

			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private static readonly Dictionary<Guid, float> YJOERAASACX;

			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private static readonly Dictionary<Guid, bool> EKXENQFCDZC;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA57FC60", Offset = "0xA57EC60", VA = "0x18A57FC60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class QFHINFUIXVH
		{
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			private static readonly Dictionary<Guid, float> QYVOMJAFMXN;

			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private static readonly Dictionary<Guid, float> WOZYGHJMQKS;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A7FF0", Offset = "0xA5A6FF0", VA = "0x18A5A7FF0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class AAJUKUFSVQP
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3E20", Offset = "0xA5A2E20", VA = "0x18A5A3E20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class XENRFCTDZMF
		{
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			private static readonly Dictionary<Guid, int> XKOUAXRQTUR;

			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private static readonly Dictionary<Guid, bool> AYYHPAQJKBP;

			[Cpp2IlInjected.Token(Token = "0x400024D")]
			private static readonly Dictionary<Guid, bool> HHDGLROPRIG;

			[Cpp2IlInjected.Token(Token = "0x400024E")]
			private static readonly Dictionary<Guid, int> IFYSLECMLBE;

			[Cpp2IlInjected.Token(Token = "0x400024F")]
			private static readonly Dictionary<Guid, bool> QYESCLESBUJ;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9DA0", Offset = "0xA5A8DA0", VA = "0x18A5A9DA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class XEDDKPFJGPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9BE0", Offset = "0xA5A8BE0", VA = "0x18A5A9BE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static Versioner<UYPXTMTCQYP, PersistedRoomData, PersistedRoomVersion> FIVUHTPVGUW;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Dictionary<Guid, int> WLUBWDHZCUJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Guid TJHKZLIGONB;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Guid SZTBUKXKHMV;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly float SGZUXHRUJBP;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA578A70", Offset = "0xA577A70", VA = "0x18A578A70")]
		public static PersistedRoomData ZBDCUYOJRTM(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA578240", Offset = "0xA577240", VA = "0x18A578240")]
		public static Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA578370", Offset = "0xA577370", VA = "0x18A578370")]
		public static Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA578650", Offset = "0xA577650", VA = "0x18A578650")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, PersistedRoomData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA578990", Offset = "0xA577990", VA = "0x18A578990")]
		public static Guid XKIYKKLCFJI(FZCUOOHXFZF a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class CRVJJMIUVPY
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public interface UYPXTMTCQYP : IILUJLRIDPN<SZARDBYZIVI, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public sealed class EMEDYSEXMVG : UYPXTMTCQYP, IILUJLRIDPN<SZARDBYZIVI, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public static EMEDYSEXMVG CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			public PlayerSaveVersion ZUSWJYFBNKN()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xD608B0", Offset = "0xD5F8B0", VA = "0x180D608B0", Slot = "5")]
			public PlayerSaveVersion CJYDMRKFWKX()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1AE5FD0", Offset = "0x1AE4FD0", VA = "0x181AE5FD0", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x2F0DEE0", Offset = "0x2F0CEE0", VA = "0x182F0DEE0", Slot = "7")]
			public bool OFJYEGSNTSE(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA5A69B0", Offset = "0xA5A59B0", VA = "0x18A5A69B0", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public EMEDYSEXMVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static Versioner<UYPXTMTCQYP, SZARDBYZIVI, PlayerSaveVersion> FIVUHTPVGUW;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A66A0", Offset = "0xA5A56A0", VA = "0x18A5A66A0")]
		public static SZARDBYZIVI? XFULNIVCIDK([Optional] ZJQHGLFBKLO? a, [Optional] PLRJAEEQHSU? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5CD0", Offset = "0xA5A4CD0", VA = "0x18A5A5CD0")]
		public static Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, byte[]? bytes)
		{
			return default(Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5850", Offset = "0xA5A4850", VA = "0x18A5A5850")]
		public static Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6570", Offset = "0xA5A5570", VA = "0x18A5A6570")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, SZARDBYZIVI b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4C50", Offset = "0xA5A3C50", VA = "0x18A5A4C50")]
		public static void ABZXOWIXTDJ(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4F50", Offset = "0xA5A3F50", VA = "0x18A5A4F50")]
		public static void ACFEMDCVCOS(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5190", Offset = "0xA5A4190", VA = "0x18A5A5190")]
		public static void ACKLJJWSMAB(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5630", Offset = "0xA5A4630", VA = "0x18A5A5630")]
		public static void ACPSGQQPVLK(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5760", Offset = "0xA5A4760", VA = "0x18A5A5760")]
		public static void ACUZDXKNEWT(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5E30", Offset = "0xA5A4E30", VA = "0x18A5A5E30")]
		private static PLRJAEEQHSU GIHHDVOHORY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5F10", Offset = "0xA5A4F10", VA = "0x18A5A5F10")]
		private static PLRJAEEQHSU GIMOBCIEYDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5E00", Offset = "0xA5A4E00", VA = "0x18A5A5E00")]
		[CompilerGenerated]
		internal static bool FBXNBZBADER(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6140", Offset = "0xA5A5140", VA = "0x18A5A6140")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV ILMSFJSPRWH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6540", Offset = "0xA5A5540", VA = "0x18A5A6540")]
		[CompilerGenerated]
		internal static float TLSIJEHSZYL(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A61B0", Offset = "0xA5A51B0", VA = "0x18A5A61B0")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV JLWNKXHPLEH(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6510", Offset = "0xA5A5510", VA = "0x18A5A6510")]
		[CompilerGenerated]
		internal static int SFSOJWXGKAW(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6380", Offset = "0xA5A5380", VA = "0x18A5A6380")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV PVJKIWRJKAK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6220", Offset = "0xA5A5220", VA = "0x18A5A6220")]
		[CompilerGenerated]
		internal static CircuitsQuat MDFQVIZWYDB(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A63F0", Offset = "0xA5A53F0", VA = "0x18A5A63F0")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV QTAIBVZITPT(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A62F0", Offset = "0xA5A52F0", VA = "0x18A5A62F0")]
		[CompilerGenerated]
		internal static string OFBBCSVURYI(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6310", Offset = "0xA5A5310", VA = "0x18A5A6310")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV PBVHOCXETZA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6060", Offset = "0xA5A5060", VA = "0x18A5A6060")]
		[CompilerGenerated]
		internal static CircuitsVec3 HWZMVLDCDNG(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A57D0", Offset = "0xA5A47D0", VA = "0x18A5A57D0")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV ACVRBRAHVUW(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5FF0", Offset = "0xA5A4FF0", VA = "0x18A5A5FF0")]
		[CompilerGenerated]
		internal static int HKQKNOPHPDZ(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6470", Offset = "0xA5A5470", VA = "0x18A5A6470")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV SEPXTORSPCJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x37E8770", Offset = "0x37E7770", VA = "0x1837E8770")]
		[CompilerGenerated]
		internal static void KWHOGGOPLYJ<a>(RepeatedField<LBOVUYNTIDO> a, Func<ByteString, a> deserialize, Func<a, RAIQVFTYDPV> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class UVEVGBGJZEU
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A99B0", Offset = "0xA5A89B0", VA = "0x18A5A99B0")]
		public static ILAYAIZJRWU CZDOOTFVIKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9570", Offset = "0xA5A8570", VA = "0x18A5A9570")]
		public static Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, byte[] b)
		{
			return default(Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9660", Offset = "0xA5A8660", VA = "0x18A5A9660")]
		public static Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9A00", Offset = "0xA5A8A00", VA = "0x18A5A9A00")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(VOUHRIHXBOE.UYPXTMTCQYP a, ILAYAIZJRWU b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class BELUWEDSEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4960", Offset = "0xA5A3960", VA = "0x18A5A4960")]
		public static SpawnableTemplateData LUXOCMUUZRD([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4300", Offset = "0xA5A3300", VA = "0x18A5A4300")]
		public static Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, FYWJENCPTIG.UYPXTMTCQYP b, byte[] c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3FE0", Offset = "0xA5A2FE0", VA = "0x18A5A3FE0")]
		public static Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, FYWJENCPTIG.UYPXTMTCQYP b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A49E0", Offset = "0xA5A39E0", VA = "0x18A5A49E0")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(VOUHRIHXBOE.UYPXTMTCQYP a, FYWJENCPTIG.UYPXTMTCQYP b, SpawnableTemplateData c)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4400", Offset = "0xA5A3400", VA = "0x18A5A4400")]
		private static Result<None, SIEDSHFPKXL> GMWSADLMCTP(VOUHRIHXBOE.UYPXTMTCQYP a, SpawnableTemplateData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5A47C0", Offset = "0xA5A37C0", VA = "0x18A5A47C0")]
		private static Result<None, SIEDSHFPKXL> LHLBCRTDCBN(FYWJENCPTIG.UYPXTMTCQYP a, SpawnableTemplateData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class FYWJENCPTIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public interface UYPXTMTCQYP : IILUJLRIDPN<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class EMEDYSEXMVG : UYPXTMTCQYP, IILUJLRIDPN<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public static EMEDYSEXMVG CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			public SuperRoomVersion ZUSWJYFBNKN()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "5")]
			public SuperRoomVersion CJYDMRKFWKX()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1AE5FD0", Offset = "0x1AE4FD0", VA = "0x181AE5FD0", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2F0DEE0", Offset = "0x2F0CEE0", VA = "0x182F0DEE0", Slot = "7")]
			public bool OFJYEGSNTSE(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA5A6A00", Offset = "0xA5A5A00", VA = "0x18A5A6A00", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public EMEDYSEXMVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static Versioner<UYPXTMTCQYP, SuperRoomData, SuperRoomVersion> FIVUHTPVGUW;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7BC0", Offset = "0xA5A6BC0", VA = "0x18A5A7BC0")]
		public static SuperRoomData XKNEEPQUURS([Optional] GKWXQZMULWK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7430", Offset = "0xA5A6430", VA = "0x18A5A7430")]
		public static Result<ParseResult<SuperRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7160", Offset = "0xA5A6160", VA = "0x18A5A7160")]
		public static Result<ParseResult<SuperRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7770", Offset = "0xA5A6770", VA = "0x18A5A7770")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, SuperRoomData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6BE0", Offset = "0xA5A5BE0", VA = "0x18A5A6BE0")]
		private static void ABZXOWIXTDJ(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6DA0", Offset = "0xA5A5DA0", VA = "0x18A5A6DA0")]
		private static void ACFEMDCVCOS(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6EA0", Offset = "0xA5A5EA0", VA = "0x18A5A6EA0")]
		private static void ACKLJJWSMAB(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6F30", Offset = "0xA5A5F30", VA = "0x18A5A6F30")]
		private static void ACPSGQQPVLK(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A78A0", Offset = "0xA5A68A0", VA = "0x18A5A78A0")]
		public static DataTableData VJLBQPRSRCP(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7560", Offset = "0xA5A6560", VA = "0x18A5A7560")]
		public static ProgressionManagerData EVYAJDUKZSM(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6FB0", Offset = "0xA5A5FB0", VA = "0x18A5A6FB0")]
		[CompilerGenerated]
		internal static void CHTUHHUASTI(RepeatedField<BCYHOPYJTBM> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class MGACCALMPTY : XOYYRQTETOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7E90", Offset = "0xA5A6E90", VA = "0x18A5A7E90", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA4D0", Offset = "0x2BA94D0", VA = "0x182BAA4D0")]
		public MGACCALMPTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface IILUJLRIDPN<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b ZUSWJYFBNKN();

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b CJYDMRKFWKX();

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OFJYEGSNTSE(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class ESSHDKAKNUS : XOYYRQTETOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private string ALWMAUPMXBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private string FZFUTCQMSXL;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6B90", Offset = "0xA5A5B90", VA = "0x18A5A6B90")]
		public ESSHDKAKNUS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6B30", Offset = "0xA5A5B30", VA = "0x18A5A6B30", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x75261E0", Offset = "0x75251E0", VA = "0x1875261E0")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class YVMUBCZZVOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x411DE10", Offset = "0x411CE10", VA = "0x18411DE10")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class VBMGKBVWECR : XOYYRQTETOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private string ALWMAUPMXBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private string FZFUTCQMSXL;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6B90", Offset = "0xA5A5B90", VA = "0x18A5A6B90")]
		public VBMGKBVWECR(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9B80", Offset = "0xA5A8B80", VA = "0x18A5A9B80", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9AD0", Offset = "0xA5A8AD0", VA = "0x18A5A9AD0")]
		public static Guid? HRPBDIJBGEZ(RWNYJETRKPC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : IILUJLRIDPN<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x85880A0", Offset = "0x85870A0", VA = "0x1885880A0")]
		public Result<TVersion, SIEDSHFPKXL> TNMUDZMDIQF(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8587F10", Offset = "0x8586F10", VA = "0x188587F10")]
		public static VersionerFactory<TDeps, TData, TVersion> FACRFPUWRCL()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public VersioningPhaseVoidDelegate<TDeps, TData> JOFSTHWLZER;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x6474D50", Offset = "0x6473D50", VA = "0x186474D50")]
			internal Result<None, SIEDSHFPKXL> CFNXWMVKFDD(TDeps a, TData b)
			{
				return default(Result<None, SIEDSHFPKXL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public VersioningPhaseVoidDelegate<TData> JOFSTHWLZER;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7738470", Offset = "0x7737470", VA = "0x187738470")]
			internal Result<None, SIEDSHFPKXL> CFNXWMVKFDD(TDeps a, TData b)
			{
				return default(Result<None, SIEDSHFPKXL>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8587820", Offset = "0x8586820", VA = "0x188587820")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8587960", Offset = "0x8586960", VA = "0x188587960")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8587AE0", Offset = "0x8586AE0", VA = "0x188587AE0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class ORCWFQQFFBX
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x39B5680", Offset = "0x39B4680", VA = "0x1839B5680")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : IILUJLRIDPN<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class PFULQERVCDQ : XOYYRQTETOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly Exception OURENDOYISX;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B3CA40", Offset = "0x1B3BA40", VA = "0x181B3CA40")]
		public PFULQERVCDQ(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7FC0", Offset = "0xA5A6FC0", VA = "0x18A5A7FC0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7EC0", Offset = "0xA5A6EC0", VA = "0x18A5A7EC0", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class XOYYRQTETOJ : SIEDSHFPKXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA4D0", Offset = "0x2BA94D0", VA = "0x182BAA4D0")]
		protected XOYYRQTETOJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate Result<None, SIEDSHFPKXL> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
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
