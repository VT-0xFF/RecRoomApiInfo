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
		[Cpp2IlInjected.Address(RVA = "0xA577D30", Offset = "0xA576D30", VA = "0x18A577D30")]
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
			[Cpp2IlInjected.Address(RVA = "0xA573180", Offset = "0xA572180", VA = "0x18A573180", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5732C0", Offset = "0xA5722C0", VA = "0x18A5732C0", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5731A0", Offset = "0xA5721A0", VA = "0x18A5731A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57BAE0", Offset = "0xA57AAE0", VA = "0x18A57BAE0")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA57ACB0", Offset = "0xA579CB0", VA = "0x18A57ACB0")]
			private static void HGWRXDXASQT(PersistedRoomData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA57BDC0", Offset = "0xA57ADC0", VA = "0x18A57BDC0")]
			private static void UMJECYCWDKG(PersistedRoomData a, Func<JOAFFMPAQWM, NPSALNPWJFR> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA57AA90", Offset = "0xA579A90", VA = "0x18A57AA90")]
			private static JOAFFMPAQWM GFUEBSFCGND(PersistedRoomData a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA57BA40", Offset = "0xA57AA40", VA = "0x18A57BA40")]
			private static void RZYSWTGOMGL(PersistedRoomData a, string b, Func<JOAFFMPAQWM, NPSALNPWJFR> c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA57BC80", Offset = "0xA57AC80", VA = "0x18A57BC80")]
			private static void TBWZJCQGTJW(PersistedRoomData a, string b, Func<JOAFFMPAQWM, VGLOFUAYFPS> c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA57B9A0", Offset = "0xA57A9A0", VA = "0x18A57B9A0")]
			private static void JQPXTWVOUAP(PersistedRoomData a, string b, Func<JOAFFMPAQWM, NPSALNPWJFR> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA57B900", Offset = "0xA57A900", VA = "0x18A57B900")]
			private static void JQPXTWVOUAP(PersistedRoomData a, string b, Func<JOAFFMPAQWM, VGLOFUAYFPS> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA57BD20", Offset = "0xA57AD20", VA = "0x18A57BD20")]
			private static void TLRLIJDKCNS(PersistedRoomData a, string b, Func<JOAFFMPAQWM, NPSALNPWJFR> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class ZDHOGOBGXZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA57A6B0", Offset = "0xA5796B0", VA = "0x18A57A6B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class ZDCHJHHJOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA57A4E0", Offset = "0xA5794E0", VA = "0x18A57A4E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class ZEHWSVWTTER
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA57CD70", Offset = "0xA57BD70", VA = "0x18A57CD70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57C950", Offset = "0xA57B950", VA = "0x18A57C950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57C5F0", Offset = "0xA57B5F0", VA = "0x18A57C5F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class ZDSCBBPBQWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA57C430", Offset = "0xA57B430", VA = "0x18A57C430")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class ZBWRZSRZJYN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA57A320", Offset = "0xA579320", VA = "0x18A57A320")]
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
			[Cpp2IlInjected.Address(RVA = "0xA579AA0", Offset = "0xA578AA0", VA = "0x18A579AA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class ACFEMDCVCOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA572050", Offset = "0xA571050", VA = "0x18A572050")]
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
			[Cpp2IlInjected.Address(RVA = "0xA574D00", Offset = "0xA573D00", VA = "0x18A574D00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class GEJGZTXEGOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA5756C0", Offset = "0xA5746C0", VA = "0x18A5756C0")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class GDYTFGJJNSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA574960", Offset = "0xA573960", VA = "0x18A574960")]
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
			[Cpp2IlInjected.Address(RVA = "0xA574710", Offset = "0xA573710", VA = "0x18A574710")]
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
			[Cpp2IlInjected.Address(RVA = "0xA574520", Offset = "0xA573520", VA = "0x18A574520")]
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
			[Cpp2IlInjected.Address(RVA = "0xA573540", Offset = "0xA572540", VA = "0x18A573540")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class GCTDVRTZJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA5739C0", Offset = "0xA5729C0", VA = "0x18A5739C0")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA574470", Offset = "0xA573470", VA = "0x18A574470")]
			private static quaternion XWXNEWTLFPF(RGEMMZCMHHA a)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA573860", Offset = "0xA572860", VA = "0x18A573860")]
			private static RGEMMZCMHHA FFFLIFMTNVY(UYPXTMTCQYP a, float3 b, quaternion c, int d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA573F20", Offset = "0xA572F20", VA = "0x18A573F20")]
			private static RGEMMZCMHHA VSNUOZXFUJE(UYPXTMTCQYP a, float3 b, quaternion c, int d, bool e)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class MYISKWYPWWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA5770C0", Offset = "0xA5760C0", VA = "0x18A5770C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class MYDLNQESNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA576EF0", Offset = "0xA575EF0", VA = "0x18A576EF0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class MYNZIDSNGIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5772F0", Offset = "0xA5762F0", VA = "0x18A5772F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class MZDTZYAFIQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA577730", Offset = "0xA576730", VA = "0x18A577730")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class MYYNCRGHZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA5774E0", Offset = "0xA5764E0", VA = "0x18A5774E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5778E0", Offset = "0xA5768E0", VA = "0x18A5778E0")]
			public static void Run(UYPXTMTCQYP deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class MZYVOZBUUJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA577B70", Offset = "0xA576B70", VA = "0x18A577B70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5729C0", Offset = "0xA5719C0", VA = "0x18A5729C0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA5726D0", Offset = "0xA5716D0", VA = "0x18A5726D0")]
			private static TWKOSUNKOYS QNJEVZVHFVV(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA572630", Offset = "0xA571630", VA = "0x18A572630")]
			private static TWKOSUNKOYS FGSJKCAKYHL(Guid a, bool b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA572C60", Offset = "0xA571C60", VA = "0x18A572C60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA572E90", Offset = "0xA571E90", VA = "0x18A572E90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55ECD0", Offset = "0xA55DCD0", VA = "0x18A55ECD0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<UYPXTMTCQYP, PersistedRoomData, DEPRECATED_RoomPersistenceVersion> FIVUHTPVGUW;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5759A0", Offset = "0xA5749A0", VA = "0x18A5759A0")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, PersistedRoomData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class GTGHYRDYGIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA576660", Offset = "0xA575660", VA = "0x18A576660")]
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
			[Cpp2IlInjected.Address(RVA = "0xA573190", Offset = "0xA572190", VA = "0x18A573190", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA573270", Offset = "0xA572270", VA = "0x18A573270", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55F550", Offset = "0xA55E550", VA = "0x18A55F550")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class TRWSKZSTUTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA577DB0", Offset = "0xA576DB0", VA = "0x18A577DB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TSRUAAUJGNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA578070", Offset = "0xA577070", VA = "0x18A578070")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class MWHDVUODGYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA576B00", Offset = "0xA575B00", VA = "0x18A576B00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class MWMKTBIAQKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA576CC0", Offset = "0xA575CC0", VA = "0x18A576CC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class FWQHJKBNMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA573380", Offset = "0xA572380", VA = "0x18A573380")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class YWOXCMBCZBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA579750", Offset = "0xA578750", VA = "0x18A579750")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class ZEHWSVWTTER
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA593440", Offset = "0xA592440", VA = "0x18A593440")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class ZDSCBBPBQWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA593270", Offset = "0xA592270", VA = "0x18A593270")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57D770", Offset = "0xA57C770", VA = "0x18A57D770")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA57DED0", Offset = "0xA57CED0", VA = "0x18A57DED0")]
			private static Dictionary<Guid, FZCUOOHXFZF> UPMFFODJXXD(FZCUOOHXFZF a, Dictionary<Guid, FZCUOOHXFZF> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class GCTDVRTZJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA57D390", Offset = "0xA57C390", VA = "0x18A57D390")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class ACKLJJWSMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA57D010", Offset = "0xA57C010", VA = "0x18A57D010")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class SZBYWHHSASY
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA581F20", Offset = "0xA580F20", VA = "0x18A581F20")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA581F10", Offset = "0xA580F10", VA = "0x18A581F10")]
			private static void JWGEOFBVTZD(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class SZMMQUVMTPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA582200", Offset = "0xA581200", VA = "0x18A582200")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class SYRLBTTXHWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA581B20", Offset = "0xA580B20", VA = "0x18A581B20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class TASCAJKWYFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA582400", Offset = "0xA581400", VA = "0x18A582400")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class TAXIXQEUHRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA582770", Offset = "0xA581770", VA = "0x18A582770")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class ACUZDXKNEWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA57D1D0", Offset = "0xA57C1D0", VA = "0x18A57D1D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class ZZIQAMBZXOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3CB0", Offset = "0xA5A2CB0", VA = "0x18A5A3CB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ZYYCFYOFERX
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3A60", Offset = "0xA5A2A60", VA = "0x18A5A3A60")]
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
					[Cpp2IlInjected.Address(RVA = "0xA582F20", Offset = "0xA581F20", VA = "0x18A582F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid VHKBNMNYTFF
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0xA5846F0", Offset = "0xA5836F0", VA = "0x18A5846F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid ANYNWJUISIG
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0xA593170", Offset = "0xA592170", VA = "0x18A593170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid IWAAQQJMEIG
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0xA58A9F0", Offset = "0xA5899F0", VA = "0x18A58A9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid QALVBMNQIIK
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0xA5893F0", Offset = "0xA5883F0", VA = "0x18A5893F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid TPROCCNHKOW
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0xA587270", Offset = "0xA586270", VA = "0x18A587270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid AUSKKTFDDFP
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0xA58F1F0", Offset = "0xA58E1F0", VA = "0x18A58F1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid NHLFKGNGWKU
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0xA591070", Offset = "0xA590070", VA = "0x18A591070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid RLCXRVFZYTZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0xA5834F0", Offset = "0xA5824F0", VA = "0x18A5834F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid KBIDHGWWUUK
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0xA589AF0", Offset = "0xA588AF0", VA = "0x18A589AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid RERCXMBXGTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0xA58C6F0", Offset = "0xA58B6F0", VA = "0x18A58C6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid LJHMCKTDVPF
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0xA58CEF0", Offset = "0xA58BEF0", VA = "0x18A58CEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid TPLJDWBCMFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0xA590AF0", Offset = "0xA58FAF0", VA = "0x18A590AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid GEIPISDREIC
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0xA58FAF0", Offset = "0xA58EAF0", VA = "0x18A58FAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid MMNVQBVNZEK
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xA585AF0", Offset = "0xA584AF0", VA = "0x18A585AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid CFVARGDMZRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0xA5918F0", Offset = "0xA5908F0", VA = "0x18A5918F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid KVCEDAPYBQW
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0xA5852F0", Offset = "0xA5842F0", VA = "0x18A5852F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid XTYOCPUEJYG
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0xA5830F0", Offset = "0xA5820F0", VA = "0x18A5830F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid WJKFACFIYXN
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0xA585470", Offset = "0xA584470", VA = "0x18A585470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid ZFPRWZGAONJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0xA5904F0", Offset = "0xA58F4F0", VA = "0x18A5904F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid RROMZRSXGDV
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0xA589DF0", Offset = "0xA588DF0", VA = "0x18A589DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid PQNBBZTOJWT
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0xA58EDF0", Offset = "0xA58DDF0", VA = "0x18A58EDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid PNPYVYHOSPN
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0xA586C70", Offset = "0xA585C70", VA = "0x18A586C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid FRWOOJUDRPX
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0xA583470", Offset = "0xA582470", VA = "0x18A583470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid GDYLIHWUBAU
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0xA58E0F0", Offset = "0xA58D0F0", VA = "0x18A58E0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid RDDAVEUYLAN
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0xA589570", Offset = "0xA588570", VA = "0x18A589570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid DKPKTFNNQUT
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0xA58FD70", Offset = "0xA58ED70", VA = "0x18A58FD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid ICSJYDKSSDP
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0xA58F9F0", Offset = "0xA58E9F0", VA = "0x18A58F9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid VIZBGQEJTCT
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0xA583070", Offset = "0xA582070", VA = "0x18A583070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid EHQXSAZQAWE
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0xA590570", Offset = "0xA58F570", VA = "0x18A590570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid ZMSXVLSIWGC
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0xA584BF0", Offset = "0xA583BF0", VA = "0x18A584BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid NRBGHYPHLHB
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0xA583670", Offset = "0xA582670", VA = "0x18A583670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid LWEFUVATYYT
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0xA58FDF0", Offset = "0xA58EDF0", VA = "0x18A58FDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid GRGISMDCWEW
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0xA58D7F0", Offset = "0xA58C7F0", VA = "0x18A58D7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid YRRQKRTSHIW
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0xA58A970", Offset = "0xA589970", VA = "0x18A58A970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid RSPEVFPMELB
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0xA584170", Offset = "0xA583170", VA = "0x18A584170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid YQBBGBOHATD
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0xA583DF0", Offset = "0xA582DF0", VA = "0x18A583DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid IXLWRLCIXUM
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0xA592C70", Offset = "0xA591C70", VA = "0x18A592C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid KWFMLQOHPUU
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0xA588670", Offset = "0xA587670", VA = "0x18A588670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid ENRQCTQIGLL
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0xA589F70", Offset = "0xA588F70", VA = "0x18A589F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid CRXUMCGYXWY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0xA588870", Offset = "0xA587870", VA = "0x18A588870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid OLUXEFPPLEB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0xA5926F0", Offset = "0xA5916F0", VA = "0x18A5926F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid UKSYPLRRCFF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0xA5856F0", Offset = "0xA5846F0", VA = "0x18A5856F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid SHEKGIAHHKZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0xA5890F0", Offset = "0xA5880F0", VA = "0x18A5890F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid ENIQOWBHBTJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0xA5902F0", Offset = "0xA58F2F0", VA = "0x18A5902F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid SDSWLDPCHOC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0xA58E270", Offset = "0xA58D270", VA = "0x18A58E270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid NRPPKPKDTHR
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0xA591A70", Offset = "0xA590A70", VA = "0x18A591A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid WVQWJREYIHE
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0xA590F70", Offset = "0xA58FF70", VA = "0x18A590F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid LRVOHMMZVTH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0xA58E8F0", Offset = "0xA58D8F0", VA = "0x18A58E8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid ZMQFLNKEZNJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0xA58EFF0", Offset = "0xA58DFF0", VA = "0x18A58EFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid WIUNPUNJARY
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0xA58F370", Offset = "0xA58E370", VA = "0x18A58F370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid QPUMVYVJTQC
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xA58DCF0", Offset = "0xA58CCF0", VA = "0x18A58DCF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid KLMKYWYNDSQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xA58D470", Offset = "0xA58C470", VA = "0x18A58D470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid RZHKSNECTQW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xA58BE70", Offset = "0xA58AE70", VA = "0x18A58BE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid QYOQTFZCRXN
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xA5919F0", Offset = "0xA5909F0", VA = "0x18A5919F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid KOQGEZZOMDJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xA588EF0", Offset = "0xA587EF0", VA = "0x18A588EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid AHHVJVAQGPU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0xA591970", Offset = "0xA590970", VA = "0x18A591970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid LQEIOWYFTIH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xA587370", Offset = "0xA586370", VA = "0x18A587370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid KBORDBSCUHV
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0xA589D70", Offset = "0xA588D70", VA = "0x18A589D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid ZRYSKNGRCUM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xA589370", Offset = "0xA588370", VA = "0x18A589370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid CLVWKRSQBEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xA583970", Offset = "0xA582970", VA = "0x18A583970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid LCYEMEUBUZW
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xA58C270", Offset = "0xA58B270", VA = "0x18A58C270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid BWARZNGWAUA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xA590170", Offset = "0xA58F170", VA = "0x18A590170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid GRLOCKJMGQG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xA5879F0", Offset = "0xA5869F0", VA = "0x18A5879F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid LQLXMWQVFWO
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0xA590CF0", Offset = "0xA58FCF0", VA = "0x18A590CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid KTPICEOCIFG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xA58CD70", Offset = "0xA58BD70", VA = "0x18A58CD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid BEBRTEXGTUG
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0xA58FBF0", Offset = "0xA58EBF0", VA = "0x18A58FBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid NJQRHXBLCRG
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0xA58CBF0", Offset = "0xA58BBF0", VA = "0x18A58CBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid NJTBYKQAUKH
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0xA591DF0", Offset = "0xA590DF0", VA = "0x18A591DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid VONFIWCKTZE
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xA58C370", Offset = "0xA58B370", VA = "0x18A58C370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid WQQWRTRXVOY
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xA5842F0", Offset = "0xA5832F0", VA = "0x18A5842F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid RLKRNVQHNVP
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0xA583B70", Offset = "0xA582B70", VA = "0x18A583B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid ZUADKDONRIL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0xA583170", Offset = "0xA582170", VA = "0x18A583170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid MIDRZOKAEAC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xA584070", Offset = "0xA583070", VA = "0x18A584070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid MMPANAIXHVV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0xA591AF0", Offset = "0xA590AF0", VA = "0x18A591AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid SABDKJHSXWS
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0xA58B4F0", Offset = "0xA58A4F0", VA = "0x18A58B4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid TFPXZKDALLC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0xA58AE70", Offset = "0xA589E70", VA = "0x18A58AE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid MUQSSRPSLHT
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0xA590370", Offset = "0xA58F370", VA = "0x18A590370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid ETVMDHTJQDN
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0xA588770", Offset = "0xA587770", VA = "0x18A588770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid FGSFZFEZZRL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0xA58EA70", Offset = "0xA58DA70", VA = "0x18A58EA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid MYFDCHIMFCO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0xA58E7F0", Offset = "0xA58D7F0", VA = "0x18A58E7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid FFWZMVRSMFT
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0xA58E970", Offset = "0xA58D970", VA = "0x18A58E970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid LKOSOAAXEDW
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0xA592870", Offset = "0xA591870", VA = "0x18A592870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid LOCLHFCWGSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0xA592AF0", Offset = "0xA591AF0", VA = "0x18A592AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid GCLTEFMKNPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0xA58FE70", Offset = "0xA58EE70", VA = "0x18A58FE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid XFJDLOUPFSR
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0xA5848F0", Offset = "0xA5838F0", VA = "0x18A5848F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid GWLEUZIAKIR
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0xA5866F0", Offset = "0xA5856F0", VA = "0x18A5866F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid UHUMMAOHJCY
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0xA587470", Offset = "0xA586470", VA = "0x18A587470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid RWCPMNTFDYD
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0xA5903F0", Offset = "0xA58F3F0", VA = "0x18A5903F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid KGNTQXDCHEU
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0xA58BC70", Offset = "0xA58AC70", VA = "0x18A58BC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid RCVKUVVLAGA
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0xA58E770", Offset = "0xA58D770", VA = "0x18A58E770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid KTGDCWKHTJB
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0xA58B170", Offset = "0xA58A170", VA = "0x18A58B170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid LRIIAQBYPJF
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0xA58E5F0", Offset = "0xA58D5F0", VA = "0x18A58E5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid MSWGQAMLIBO
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0xA586CF0", Offset = "0xA585CF0", VA = "0x18A586CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid KGSECYJGUKO
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0xA58B9F0", Offset = "0xA58A9F0", VA = "0x18A58B9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid KVXPAXRCRKY
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0xA591770", Offset = "0xA590770", VA = "0x18A591770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid XJWSXRCAHWR
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0xA592770", Offset = "0xA591770", VA = "0x18A592770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid GRCQDCTFWVK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0xA58DEF0", Offset = "0xA58CEF0", VA = "0x18A58DEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid ATOUGLGHYYV
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0xA5921F0", Offset = "0xA5911F0", VA = "0x18A5921F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid ATEGLXSNGCD
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0xA592170", Offset = "0xA591170", VA = "0x18A592170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid IKFFDGMSTYG
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0xA58E070", Offset = "0xA58D070", VA = "0x18A58E070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid IKPSXUANMUY
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0xA58DFF0", Offset = "0xA58CFF0", VA = "0x18A58DFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid ILAGSHOIFRQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0xA58DF70", Offset = "0xA58CF70", VA = "0x18A58DF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid ZDJMCODLJZA
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0xA58C7F0", Offset = "0xA58B7F0", VA = "0x18A58C7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid WTOJHBOERJG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0xA58F8F0", Offset = "0xA58E8F0", VA = "0x18A58F8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid RMWXCIGHVHM
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0xA592370", Offset = "0xA591370", VA = "0x18A592370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid BCAAYFGBIVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0xA58BF70", Offset = "0xA58AF70", VA = "0x18A58BF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid LFEYHXHALIQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0xA5872F0", Offset = "0xA5862F0", VA = "0x18A5872F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid GAJNBCPSJJS
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0xA58B8F0", Offset = "0xA58A8F0", VA = "0x18A58B8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid GABBNWIZIBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0xA589670", Offset = "0xA588670", VA = "0x18A589670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid RHRCBJNXSUU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xA588470", Offset = "0xA587470", VA = "0x18A588470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid QYHITPIBIBP
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0xA5873F0", Offset = "0xA5863F0", VA = "0x18A5873F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid QQILSIPIOYX
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0xA584470", Offset = "0xA583470", VA = "0x18A584470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid YPQTEPBZDDH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0xA592DF0", Offset = "0xA591DF0", VA = "0x18A592DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid JETVCLACTWY
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0xA585A70", Offset = "0xA584A70", VA = "0x18A585A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid XBJQNKHLFID
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0xA5857F0", Offset = "0xA5847F0", VA = "0x18A5857F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid ZYDTRHSSEFG
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0xA582DA0", Offset = "0xA581DA0", VA = "0x18A582DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid GHZCGJQURVX
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0xA586EF0", Offset = "0xA585EF0", VA = "0x18A586EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid AZGTQWKIPMP
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0xA586970", Offset = "0xA585970", VA = "0x18A586970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid PCIKEBLMXQI
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0xA583AF0", Offset = "0xA582AF0", VA = "0x18A583AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid KZZPLEXKODZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0xA589470", Offset = "0xA588470", VA = "0x18A589470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid TDCRXURBAGX
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0xA58D2F0", Offset = "0xA58C2F0", VA = "0x18A58D2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid TAXDYWBMMDR
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0xA58A470", Offset = "0xA589470", VA = "0x18A58A470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid WPAYEMFGOJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0xA58D370", Offset = "0xA58C370", VA = "0x18A58D370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid NMSVRWIWGIG
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0xA5863F0", Offset = "0xA5853F0", VA = "0x18A5863F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid AQQDAENWXEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0xA584870", Offset = "0xA583870", VA = "0x18A584870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid VTYXTDECGFJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0xA592270", Offset = "0xA591270", VA = "0x18A592270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid LXIYCSVPMTC
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0xA589BF0", Offset = "0xA588BF0", VA = "0x18A589BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid BGMKJUNGTUU
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0xA58DBF0", Offset = "0xA58CBF0", VA = "0x18A58DBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid IYINSDDCIWI
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0xA58AEF0", Offset = "0xA589EF0", VA = "0x18A58AEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid ZNEKICPAHYE
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0xA588CF0", Offset = "0xA587CF0", VA = "0x18A588CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid QWTSGEJDSVD
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0xA58DB70", Offset = "0xA58CB70", VA = "0x18A58DB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid KIOBPSRDBVQ
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0xA5871F0", Offset = "0xA5861F0", VA = "0x18A5871F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid LPVGDZPSSNX
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0xA58F2F0", Offset = "0xA58E2F0", VA = "0x18A58F2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid JETXOVVDDFP
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0xA58EB70", Offset = "0xA58DB70", VA = "0x18A58EB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid XRDAQPBZTXV
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xA589E70", Offset = "0xA588E70", VA = "0x18A589E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid QNFTZGZSUHO
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0xA58B2F0", Offset = "0xA58A2F0", VA = "0x18A58B2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid JJNRZJQIAFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0xA5880F0", Offset = "0xA5870F0", VA = "0x18A5880F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid XWVHCGVPDRM
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0xA58D070", Offset = "0xA58C070", VA = "0x18A58D070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid ABABVEDHOJV
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0xA584C70", Offset = "0xA583C70", VA = "0x18A584C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid NEKRZHTVFDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0xA58D6F0", Offset = "0xA58C6F0", VA = "0x18A58D6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid IBCDDBLBZUS
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0xA591370", Offset = "0xA590370", VA = "0x18A591370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid IUDLIXQXWZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0xA591BF0", Offset = "0xA590BF0", VA = "0x18A591BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid XSXRGIVFOOP
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0xA58F470", Offset = "0xA58E470", VA = "0x18A58F470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid WHWRRKIISCO
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0xA582C20", Offset = "0xA581C20", VA = "0x18A582C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid ZXRZLNATOUP
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0xA5869F0", Offset = "0xA5859F0", VA = "0x18A5869F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid GSRDZQZDICY
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0xA5916F0", Offset = "0xA5906F0", VA = "0x18A5916F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid CLECBRYKXUL
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0xA590270", Offset = "0xA58F270", VA = "0x18A590270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid PTGFHNXLRUW
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0xA58BB70", Offset = "0xA58AB70", VA = "0x18A58BB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid CQJYNJSNPMQ
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0xA5886F0", Offset = "0xA5876F0", VA = "0x18A5886F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid FPPLJBWTAJY
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0xA588C70", Offset = "0xA587C70", VA = "0x18A588C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid QVSEGTQPWUI
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0xA587170", Offset = "0xA586170", VA = "0x18A587170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid ZAFABXNNSSI
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0xA589970", Offset = "0xA588970", VA = "0x18A589970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid CWLGPTVSUCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0xA58A8F0", Offset = "0xA5898F0", VA = "0x18A58A8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid SQUHELSQYMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0xA58C8F0", Offset = "0xA58B8F0", VA = "0x18A58C8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid EGRNRQIPNWK
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0xA58B670", Offset = "0xA58A670", VA = "0x18A58B670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid URKUQXWXHMH
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0xA58C970", Offset = "0xA58B970", VA = "0x18A58C970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid UORPCGMLAQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0xA592570", Offset = "0xA591570", VA = "0x18A592570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid OCOVUQVOFRS
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0xA582E20", Offset = "0xA581E20", VA = "0x18A582E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid MZXHOMLVPTY
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0xA5865F0", Offset = "0xA5855F0", VA = "0x18A5865F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid PLPARWSGGFT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xA58C0F0", Offset = "0xA58B0F0", VA = "0x18A58C0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid IUXPSHWNNIT
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xA58D1F0", Offset = "0xA58C1F0", VA = "0x18A58D1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid XKASHYTBEAB
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xA58B970", Offset = "0xA58A970", VA = "0x18A58B970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid AOKNIVRLLRA
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xA58FFF0", Offset = "0xA58EFF0", VA = "0x18A58FFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid SYBVOIILZEU
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0xA58C4F0", Offset = "0xA58B4F0", VA = "0x18A58C4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid VEZKCAVSVNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xA58F870", Offset = "0xA58E870", VA = "0x18A58F870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid VDUNPTKLZPH
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0xA589FF0", Offset = "0xA588FF0", VA = "0x18A589FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid VSAPRGDVBHX
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xA5861F0", Offset = "0xA5851F0", VA = "0x18A5861F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid PVIUGGNFPGN
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0xA583FF0", Offset = "0xA582FF0", VA = "0x18A583FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid RRXWRJZSKON
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0xA5854F0", Offset = "0xA5844F0", VA = "0x18A5854F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid VPOLFTGLYLG
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0xA58C070", Offset = "0xA58B070", VA = "0x18A58C070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid DLAZUVPKRDY
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0xA58FF70", Offset = "0xA58EF70", VA = "0x18A58FF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid JYQLHXIWUJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0xA586FF0", Offset = "0xA585FF0", VA = "0x18A586FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid QAZTCZLQNUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0xA58A870", Offset = "0xA589870", VA = "0x18A58A870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid IBZEWOQGCEP
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0xA586470", Offset = "0xA585470", VA = "0x18A586470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid DYUCCMYWLMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0xA588B70", Offset = "0xA587B70", VA = "0x18A588B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid VPPBKQTXOTS
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0xA58A6F0", Offset = "0xA5896F0", VA = "0x18A58A6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid YTNGMIQDHDB
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0xA58F3F0", Offset = "0xA58E3F0", VA = "0x18A58F3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid PJLMCVSZOCE
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0xA5867F0", Offset = "0xA5857F0", VA = "0x18A5867F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid DRMXJHJSRTK
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0xA58C770", Offset = "0xA58B770", VA = "0x18A58C770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid HDZGNXURSNE
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0xA58A3F0", Offset = "0xA5893F0", VA = "0x18A58A3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid XZASNFDLPQR
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0xA58E470", Offset = "0xA58D470", VA = "0x18A58E470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid PQPRXHEFJEJ
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0xA5884F0", Offset = "0xA5874F0", VA = "0x18A5884F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid YQBIRIQQLCT
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0xA591EF0", Offset = "0xA590EF0", VA = "0x18A591EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid SFJAPEYTZYT
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0xA589170", Offset = "0xA588170", VA = "0x18A589170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid SSDUEVXDUMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0xA590DF0", Offset = "0xA58FDF0", VA = "0x18A590DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid NDMUTLWRPFE
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0xA584570", Offset = "0xA583570", VA = "0x18A584570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid LVPOCEIKMHL
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0xA583F70", Offset = "0xA582F70", VA = "0x18A583F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid NEMFWEYWBEZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0xA5907F0", Offset = "0xA58F7F0", VA = "0x18A5907F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid ZUJCIAEZZZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0xA5862F0", Offset = "0xA5852F0", VA = "0x18A5862F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid QAQPYYHGIYH
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0xA583E70", Offset = "0xA582E70", VA = "0x18A583E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid JBJWDUENMOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0xA588270", Offset = "0xA587270", VA = "0x18A588270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid RJLYBSEJUBF
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0xA592470", Offset = "0xA591470", VA = "0x18A592470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid GVQTMTKSWKP
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0xA58CA70", Offset = "0xA58BA70", VA = "0x18A58CA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid GSPIAWQSMMA
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0xA58E870", Offset = "0xA58D870", VA = "0x18A58E870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid DVARNUVUYDE
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0xA587A70", Offset = "0xA586A70", VA = "0x18A587A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid KMLTKZKUFXF
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0xA58EF70", Offset = "0xA58DF70", VA = "0x18A58EF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid ZVXRJABONWD
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0xA58A5F0", Offset = "0xA5895F0", VA = "0x18A58A5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid NFHSHJHKAGC
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0xA58BAF0", Offset = "0xA58AAF0", VA = "0x18A58BAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid VTMHYYMQXFQ
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0xA583770", Offset = "0xA582770", VA = "0x18A583770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid GVMEMNULLOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xA591FF0", Offset = "0xA590FF0", VA = "0x18A591FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid DRUNLVAJFVD
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0xA58D8F0", Offset = "0xA58C8F0", VA = "0x18A58D8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid QOQRDGEHTTS
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xA583870", Offset = "0xA582870", VA = "0x18A583870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid IMVWPMIGRQC
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0xA58BD70", Offset = "0xA58AD70", VA = "0x18A58BD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid COOHQFQWVAY
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0xA582CA0", Offset = "0xA581CA0", VA = "0x18A582CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid QAHIQWZWSGV
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0xA58DAF0", Offset = "0xA58CAF0", VA = "0x18A58DAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid VMWWWPTGWJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0xA58C570", Offset = "0xA58B570", VA = "0x18A58C570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid PEUFNMNMLFO
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0xA58D870", Offset = "0xA58C870", VA = "0x18A58D870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid LHKJZQSSZHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0xA588BF0", Offset = "0xA587BF0", VA = "0x18A588BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid LOSZVKDLUHU
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0xA58D170", Offset = "0xA58C170", VA = "0x18A58D170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid QJHUINWYNPO
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0xA583D70", Offset = "0xA582D70", VA = "0x18A583D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid MOPELRCQXEI
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0xA5841F0", Offset = "0xA5831F0", VA = "0x18A5841F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid PVLZLZCRCNW
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0xA5868F0", Offset = "0xA5858F0", VA = "0x18A5868F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid IEUJQYHTWPU
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0xA58E1F0", Offset = "0xA58D1F0", VA = "0x18A58E1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid KOTMJPRGJNF
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0xA590E70", Offset = "0xA58FE70", VA = "0x18A590E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid SAPCITOHSNO
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0xA58EE70", Offset = "0xA58DE70", VA = "0x18A58EE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid EBXKGRDRUYC
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0xA588A70", Offset = "0xA587A70", VA = "0x18A588A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid QZZEBTDKHBM
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0xA5914F0", Offset = "0xA5904F0", VA = "0x18A5914F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid LHDYYXKHFFG
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0xA58E170", Offset = "0xA58D170", VA = "0x18A58E170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid VWQKXGILFAP
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0xA587770", Offset = "0xA586770", VA = "0x18A587770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid IFCZXTIQTKD
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0xA5898F0", Offset = "0xA5888F0", VA = "0x18A5898F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid TLDMFNJPHZX
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0xA58EEF0", Offset = "0xA58DEF0", VA = "0x18A58EEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid ZYIKVRQUTLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0xA58AA70", Offset = "0xA589A70", VA = "0x18A58AA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid DAMDFZUTAYQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0xA587D70", Offset = "0xA586D70", VA = "0x18A587D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid AEFFEKQAZJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0xA588170", Offset = "0xA587170", VA = "0x18A588170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid AJOOPAIFEBQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0xA584270", Offset = "0xA583270", VA = "0x18A584270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid FQHYEJQLZYN
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0xA58F7F0", Offset = "0xA58E7F0", VA = "0x18A58F7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid ZGEJFTJMESQ
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0xA587AF0", Offset = "0xA586AF0", VA = "0x18A587AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid PXNUJHCLJSP
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0xA58AC70", Offset = "0xA589C70", VA = "0x18A58AC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid IKKNZOFHWKI
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0xA5864F0", Offset = "0xA5854F0", VA = "0x18A5864F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid TSHFYFSCKFY
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0xA5885F0", Offset = "0xA5875F0", VA = "0x18A5885F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid DAEIMLBLHTJ
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0xA5931F0", Offset = "0xA5921F0", VA = "0x18A5931F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid MGDNOZGSCJR
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0xA5922F0", Offset = "0xA5912F0", VA = "0x18A5922F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid QFMSBKWQRDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0xA5888F0", Offset = "0xA5878F0", VA = "0x18A5888F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid ZKXPRBFDRAC
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0xA585E70", Offset = "0xA584E70", VA = "0x18A585E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid ROIAGAKULDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0xA5836F0", Offset = "0xA5826F0", VA = "0x18A5836F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid MTSTBFPLGFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0xA587DF0", Offset = "0xA586DF0", VA = "0x18A587DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid BXBWRXWQAVK
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0xA585D70", Offset = "0xA584D70", VA = "0x18A585D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid ESRINNXBBWX
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0xA5882F0", Offset = "0xA5872F0", VA = "0x18A5882F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid XSVAOXELIFL
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0xA590C70", Offset = "0xA58FC70", VA = "0x18A590C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid CDPYZAJBQEJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0xA58E9F0", Offset = "0xA58D9F0", VA = "0x18A58E9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid MUEQWJLCETO
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0xA58F0F0", Offset = "0xA58E0F0", VA = "0x18A58F0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid HRPNKZWIDJU
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0xA586AF0", Offset = "0xA585AF0", VA = "0x18A586AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid LWOMIGAJMHO
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0xA5925F0", Offset = "0xA5915F0", VA = "0x18A5925F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid BNJTQSVGIVP
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0xA584970", Offset = "0xA583970", VA = "0x18A584970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid YUSQDYFVJRV
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0xA585570", Offset = "0xA584570", VA = "0x18A585570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid MNHVXNQYBCK
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0xA591D70", Offset = "0xA590D70", VA = "0x18A591D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid UHUILHFUMFM
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0xA589270", Offset = "0xA588270", VA = "0x18A589270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid PCQPOYCABHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0xA5851F0", Offset = "0xA5841F0", VA = "0x18A5851F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid EVUSSLCLXHI
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0xA591870", Offset = "0xA590870", VA = "0x18A591870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid CCAEQBVLCQD
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0xA585BF0", Offset = "0xA584BF0", VA = "0x18A585BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid FAOMLFIFEPC
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0xA583EF0", Offset = "0xA582EF0", VA = "0x18A583EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid ZSQACROOEQI
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0xA584AF0", Offset = "0xA583AF0", VA = "0x18A584AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid VCSDEVODJUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0xA591170", Offset = "0xA590170", VA = "0x18A591170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid SOIKTUZPBKN
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0xA58AFF0", Offset = "0xA589FF0", VA = "0x18A58AFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid AXMHXKJPINO
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0xA591470", Offset = "0xA590470", VA = "0x18A591470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid WWQFOCLHTTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0xA58CAF0", Offset = "0xA58BAF0", VA = "0x18A58CAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid AONMNGQBMYS
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0xA588FF0", Offset = "0xA587FF0", VA = "0x18A588FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid RDKQKHYHCCZ
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0xA590BF0", Offset = "0xA58FBF0", VA = "0x18A590BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid GVTWFAPVDMK
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0xA58A4F0", Offset = "0xA5894F0", VA = "0x18A58A4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid VRGEWJWAKJX
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0xA586D70", Offset = "0xA585D70", VA = "0x18A586D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid YBQWVHJFNFE
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0xA58ADF0", Offset = "0xA589DF0", VA = "0x18A58ADF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid LIVGCVECMUT
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0xA58B0F0", Offset = "0xA58A0F0", VA = "0x18A58B0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid AUDLKHGGBEU
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0xA58E6F0", Offset = "0xA58D6F0", VA = "0x18A58E6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid RHAYXCFAMJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xA582D20", Offset = "0xA581D20", VA = "0x18A582D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid DFVRGLZTBTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0xA583CF0", Offset = "0xA582CF0", VA = "0x18A583CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid PEBWQPJEEYG
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xA5891F0", Offset = "0xA5881F0", VA = "0x18A5891F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid DSFWXYDCDAJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0xA58FEF0", Offset = "0xA58EEF0", VA = "0x18A58FEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid EXQZBLLEVDM
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0xA58EAF0", Offset = "0xA58DAF0", VA = "0x18A58EAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid ENDSHPVUYHL
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0xA5881F0", Offset = "0xA5871F0", VA = "0x18A5881F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid VNTPVJHLTXG
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0xA58E4F0", Offset = "0xA58D4F0", VA = "0x18A58E4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid JMEFTJIQQSL
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0xA583370", Offset = "0xA582370", VA = "0x18A583370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid BLJXKSZCJYZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0xA585070", Offset = "0xA584070", VA = "0x18A585070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid UEOGYDVANFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0xA586070", Offset = "0xA585070", VA = "0x18A586070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid GPMUIXNDRKX
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0xA582BA0", Offset = "0xA581BA0", VA = "0x18A582BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid USFGLZYWGGJ
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0xA590A70", Offset = "0xA58FA70", VA = "0x18A590A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid RZUYNOPTAQC
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0xA58B370", Offset = "0xA58A370", VA = "0x18A58B370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid URPLUFREDYI
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xA5909F0", Offset = "0xA58F9F0", VA = "0x18A5909F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid URUSRMLBNJR
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0xA590970", Offset = "0xA58F970", VA = "0x18A590970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid DPLMRIEVDYP
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xA5895F0", Offset = "0xA5885F0", VA = "0x18A5895F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid ZDFVGYWQWZI
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0xA58A7F0", Offset = "0xA5897F0", VA = "0x18A58A7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid ZDAOJSCTNNZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0xA58A670", Offset = "0xA589670", VA = "0x18A58A670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid KYMEJIQBJMD
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0xA58B270", Offset = "0xA58A270", VA = "0x18A58B270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid CGXKDAEVIID
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0xA58CF70", Offset = "0xA58BF70", VA = "0x18A58CF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid KOXZTDSAHRS
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xA5915F0", Offset = "0xA5905F0", VA = "0x18A5915F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid YYKXKAJPORV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0xA58C5F0", Offset = "0xA58B5F0", VA = "0x18A58C5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid MIHEVGJKPIL
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xA5855F0", Offset = "0xA5845F0", VA = "0x18A5855F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid LPGLBJAOUQA
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0xA586870", Offset = "0xA585870", VA = "0x18A586870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid VJPYVBPEDGK
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0xA58ACF0", Offset = "0xA589CF0", VA = "0x18A58ACF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid ZFDTPPMSFXW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0xA585970", Offset = "0xA584970", VA = "0x18A585970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid GFVXOSCVOJN
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0xA5875F0", Offset = "0xA5865F0", VA = "0x18A5875F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid THQTOQABDJA
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0xA589EF0", Offset = "0xA588EF0", VA = "0x18A589EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid HFHVYLPJTPK
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0xA584E70", Offset = "0xA583E70", VA = "0x18A584E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid CYMWJQVEKXQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0xA5920F0", Offset = "0xA5910F0", VA = "0x18A5920F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid GAMHMINJRDN
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0xA58BFF0", Offset = "0xA58AFF0", VA = "0x18A58BFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid HMKBMEIPEZG
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0xA582B20", Offset = "0xA581B20", VA = "0x18A582B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid FMHEXYFGXWX
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0xA58DE70", Offset = "0xA58CE70", VA = "0x18A58DE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid LYBBDNUZZUT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0xA58CC70", Offset = "0xA58BC70", VA = "0x18A58CC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid DICEQKHCDTB
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0xA5883F0", Offset = "0xA5873F0", VA = "0x18A5883F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid LURKZOMAWHU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0xA586F70", Offset = "0xA585F70", VA = "0x18A586F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid MJBSQJTKPIV
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0xA589770", Offset = "0xA588770", VA = "0x18A589770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid GHSSJJXILHI
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0xA58CCF0", Offset = "0xA58BCF0", VA = "0x18A58CCF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid KMAXKOEYJQT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0xA5924F0", Offset = "0xA5914F0", VA = "0x18A5924F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid VBYVYGTVKFA
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0xA584B70", Offset = "0xA583B70", VA = "0x18A584B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid ODELSWHQVKU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xA58F270", Offset = "0xA58E270", VA = "0x18A58F270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid LFXXEEOEIJK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0xA592970", Offset = "0xA591970", VA = "0x18A592970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid AEXWSWRLMYD
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xA588070", Offset = "0xA587070", VA = "0x18A588070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid KPLCWOKJPUJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0xA588970", Offset = "0xA587970", VA = "0x18A588970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid KMZXVZQOHCI
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xA586A70", Offset = "0xA585A70", VA = "0x18A586A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid EUVRKTPLHWC
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0xA58FB70", Offset = "0xA58EB70", VA = "0x18A58FB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid KGORWMHHZLT
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xA58D4F0", Offset = "0xA58C4F0", VA = "0x18A58D4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid FSMWBFXRTYM
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0xA58EBF0", Offset = "0xA58DBF0", VA = "0x18A58EBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid PIWWDNZVYZK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0xA58A270", Offset = "0xA589270", VA = "0x18A58A270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid SIFDCSKNNJO
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0xA588DF0", Offset = "0xA587DF0", VA = "0x18A588DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid UUKZIIXWBJI
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0xA587F70", Offset = "0xA586F70", VA = "0x18A587F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid HBCMSQSJEAB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xA58E2F0", Offset = "0xA58D2F0", VA = "0x18A58E2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid GTWPDXSNAFU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0xA58BEF0", Offset = "0xA58AEF0", VA = "0x18A58BEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid FHYGQHEAAGO
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xA5910F0", Offset = "0xA5900F0", VA = "0x18A5910F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid MWKQQUINWFA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0xA58B070", Offset = "0xA58A070", VA = "0x18A58B070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid RDWKENXSSAY
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0xA587670", Offset = "0xA586670", VA = "0x18A587670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid QYIPSMNDLSQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0xA58C170", Offset = "0xA58B170", VA = "0x18A58C170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid EPCKQPHRYIE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0xA584FF0", Offset = "0xA583FF0", VA = "0x18A584FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid KQWOKFXUPFW
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0xA587970", Offset = "0xA586970", VA = "0x18A587970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid IRPFTULNLXB
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0xA585FF0", Offset = "0xA584FF0", VA = "0x18A585FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid FLFFTTVXUFQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0xA58DC70", Offset = "0xA58CC70", VA = "0x18A58DC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid KRNRKHGUIEL
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0xA591E70", Offset = "0xA590E70", VA = "0x18A591E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid SBHYYUMNWPP
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0xA585DF0", Offset = "0xA584DF0", VA = "0x18A585DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid ENEMCUOIKLN
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0xA589A70", Offset = "0xA588A70", VA = "0x18A589A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid JOVTWNBDSJM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0xA583A70", Offset = "0xA582A70", VA = "0x18A583A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid HKZRIBDOZMZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0xA5870F0", Offset = "0xA5860F0", VA = "0x18A5870F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid QGRGZYPLIPQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0xA586E70", Offset = "0xA585E70", VA = "0x18A586E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid ENIGRSFOATT
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xA592670", Offset = "0xA591670", VA = "0x18A592670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid JIQWMAEESWI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0xA583BF0", Offset = "0xA582BF0", VA = "0x18A583BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid YROSRJPKLBX
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xA591B70", Offset = "0xA590B70", VA = "0x18A591B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid ZDNBUHOWKYI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0xA58C3F0", Offset = "0xA58B3F0", VA = "0x18A58C3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid ZUKCXQTNBLV
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0xA593070", Offset = "0xA592070", VA = "0x18A593070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid DJMLZYYOFEW
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0xA5906F0", Offset = "0xA58F6F0", VA = "0x18A5906F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid IGHMEYCHPOO
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0xA592FF0", Offset = "0xA591FF0", VA = "0x18A592FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid JODPAHKHVAU
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0xA58B5F0", Offset = "0xA58A5F0", VA = "0x18A58B5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid OKJFZCTHEYX
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0xA58DDF0", Offset = "0xA58CDF0", VA = "0x18A58DDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid DQBGOPOHAUZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0xA586170", Offset = "0xA585170", VA = "0x18A586170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid BQKDPUDNEBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0xA584EF0", Offset = "0xA583EF0", VA = "0x18A584EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid NOYNWHLCVOE
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0xA58B470", Offset = "0xA58A470", VA = "0x18A58B470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid ZNMMILRIBNY
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0xA5845F0", Offset = "0xA5835F0", VA = "0x18A5845F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid VIPKZOELWYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0xA584A70", Offset = "0xA583A70", VA = "0x18A584A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid LAOYJWWEULE
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0xA5930F0", Offset = "0xA5920F0", VA = "0x18A5930F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid PIMLGZPXFCP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0xA58E370", Offset = "0xA58D370", VA = "0x18A58E370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid RFXOHADAVMK
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0xA587C70", Offset = "0xA586C70", VA = "0x18A587C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid RUVNVIEYTQU
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0xA585370", Offset = "0xA584370", VA = "0x18A585370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid HWQOPRDSOYW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0xA58CB70", Offset = "0xA58BB70", VA = "0x18A58CB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid KQTAUFGCFKT
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0xA583C70", Offset = "0xA582C70", VA = "0x18A583C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid QYYMDHPURBP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0xA588370", Offset = "0xA587370", VA = "0x18A588370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid URPSPIKETNQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0xA5876F0", Offset = "0xA5866F0", VA = "0x18A5876F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid WELOPBOPUDS
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0xA591F70", Offset = "0xA590F70", VA = "0x18A591F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid PIGRXEZGDBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0xA58ABF0", Offset = "0xA589BF0", VA = "0x18A58ABF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid OKUAEBGXSHR
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0xA588E70", Offset = "0xA587E70", VA = "0x18A588E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid WXSHGRUSSXB
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0xA5831F0", Offset = "0xA5821F0", VA = "0x18A5831F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid DTNRLTMVTVU
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0xA58D270", Offset = "0xA58C270", VA = "0x18A58D270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid NCAMXCLHRHQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0xA5899F0", Offset = "0xA5889F0", VA = "0x18A5899F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid NADNWDZDQVD
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0xA5838F0", Offset = "0xA5828F0", VA = "0x18A5838F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid XAUZMZDVFTL
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0xA58F570", Offset = "0xA58E570", VA = "0x18A58F570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid LFDJCXHAEZQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0xA587870", Offset = "0xA586870", VA = "0x18A587870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid NFJPHDLSTNZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0xA586670", Offset = "0xA585670", VA = "0x18A586670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid GYHRRIGBKVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0xA584CF0", Offset = "0xA583CF0", VA = "0x18A584CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid WPVTWQOCSGQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0xA591570", Offset = "0xA590570", VA = "0x18A591570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid PJIMJZHURJX
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0xA584F70", Offset = "0xA583F70", VA = "0x18A584F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid RMLZOVVHYAJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0xA585170", Offset = "0xA584170", VA = "0x18A585170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid TORKUYEUYBF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0xA58D570", Offset = "0xA58C570", VA = "0x18A58D570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid EYGENMAQLTV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0xA585270", Offset = "0xA584270", VA = "0x18A585270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid EITEUWCZOAB
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0xA58F770", Offset = "0xA58E770", VA = "0x18A58F770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid NRPFQOOJZOI
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0xA584DF0", Offset = "0xA583DF0", VA = "0x18A584DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid UGMHMOFCJEO
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0xA586270", Offset = "0xA585270", VA = "0x18A586270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid QOTTNDLNYDV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0xA58E570", Offset = "0xA58D570", VA = "0x18A58E570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid BYDKOMCRTTG
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0xA584670", Offset = "0xA583670", VA = "0x18A584670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid EUHFIPNKKZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0xA58D5F0", Offset = "0xA58C5F0", VA = "0x18A58D5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid NBBTPXLOTWV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0xA586BF0", Offset = "0xA585BF0", VA = "0x18A586BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid WXOVDRSVLMS
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0xA5850F0", Offset = "0xA5840F0", VA = "0x18A5850F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid JJCVEMHYDDQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0xA5911F0", Offset = "0xA5901F0", VA = "0x18A5911F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid QJJXMDJYUMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0xA589C70", Offset = "0xA588C70", VA = "0x18A589C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid JXIAGOUGIBZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0xA5912F0", Offset = "0xA5902F0", VA = "0x18A5912F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid VMKBGKLKTBU
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0xA582FF0", Offset = "0xA581FF0", VA = "0x18A582FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid IJXZNYPQXFK
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0xA5839F0", Offset = "0xA5829F0", VA = "0x18A5839F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid EURXWBAEVNX
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0xA5897F0", Offset = "0xA5887F0", VA = "0x18A5897F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid EEKGAARFACE
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0xA5928F0", Offset = "0xA5918F0", VA = "0x18A5928F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid VDRWHFKBRXT
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0xA588570", Offset = "0xA587570", VA = "0x18A588570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid DCZORJPOJWP
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0xA58A1F0", Offset = "0xA5891F0", VA = "0x18A58A1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid OTDSPRBPSJH
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0xA585670", Offset = "0xA584670", VA = "0x18A585670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid BZANJYTCZSW
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0xA5874F0", Offset = "0xA5864F0", VA = "0x18A5874F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid EGUYJWNLZCM
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0xA5858F0", Offset = "0xA5848F0", VA = "0x18A5858F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid NJWWJTLDINY
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0xA58CFF0", Offset = "0xA58BFF0", VA = "0x18A58CFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid PCMDGYOCPBG
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0xA58DD70", Offset = "0xA58CD70", VA = "0x18A58DD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid CVKDJFZEGEK
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0xA5877F0", Offset = "0xA5867F0", VA = "0x18A5877F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid UTXNQARWPWK
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0xA58E670", Offset = "0xA58D670", VA = "0x18A58E670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid VPQXPUUJZYW
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0xA58F170", Offset = "0xA58E170", VA = "0x18A58F170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid SLZHAMICWQW
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0xA58A570", Offset = "0xA589570", VA = "0x18A58A570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid KFWEVJUQOCP
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0xA588AF0", Offset = "0xA587AF0", VA = "0x18A588AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid PERQJIOWLSP
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0xA5889F0", Offset = "0xA5879F0", VA = "0x18A5889F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid FRCLGNKMGEM
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0xA5917F0", Offset = "0xA5907F0", VA = "0x18A5917F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid RHSKVWXIROU
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0xA587B70", Offset = "0xA586B70", VA = "0x18A587B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid VERWNWXWHSQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0xA590070", Offset = "0xA58F070", VA = "0x18A590070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid JBAXOTHXSZP
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0xA58FC70", Offset = "0xA58EC70", VA = "0x18A58FC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid YPIPBQHIWBI
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0xA5849F0", Offset = "0xA5839F0", VA = "0x18A5849F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid CZXEPUKGCUJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0xA5847F0", Offset = "0xA5837F0", VA = "0x18A5847F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid ETLLKBUUPTP
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0xA58D3F0", Offset = "0xA58C3F0", VA = "0x18A58D3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid FORMNUMCZCJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0xA58A2F0", Offset = "0xA5892F0", VA = "0x18A58A2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid UHAMCURQHNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0xA591670", Offset = "0xA590670", VA = "0x18A591670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid XBNYQKUVOSV
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0xA58C9F0", Offset = "0xA58B9F0", VA = "0x18A58C9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid KWCTNYTRGYK
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0xA591CF0", Offset = "0xA590CF0", VA = "0x18A591CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid QFKAMVTMOGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0xA586DF0", Offset = "0xA585DF0", VA = "0x18A586DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid CGIKZEHHHPW
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0xA589CF0", Offset = "0xA588CF0", VA = "0x18A589CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid AWMYHACJDMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0xA592070", Offset = "0xA591070", VA = "0x18A592070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid YEXHOUHUXVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0xA58B870", Offset = "0xA58A870", VA = "0x18A58B870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid OKXEDRPWTSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0xA590770", Offset = "0xA58F770", VA = "0x18A590770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid RSBXQDPCCDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0xA5892F0", Offset = "0xA5882F0", VA = "0x18A5892F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid XSFZUDFPZSP
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0xA591C70", Offset = "0xA590C70", VA = "0x18A591C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid WARTSOZSXAU
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0xA592EF0", Offset = "0xA591EF0", VA = "0x18A592EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid UMXYHWJFJDJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0xA58BBF0", Offset = "0xA58ABF0", VA = "0x18A58BBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid EJQYQMEFDAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0xA587EF0", Offset = "0xA586EF0", VA = "0x18A587EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid UWNYTYSGHZW
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0xA58A370", Offset = "0xA589370", VA = "0x18A58A370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid TDLOTZRULIL
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0xA592F70", Offset = "0xA591F70", VA = "0x18A592F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid ACHICQEMAHZ
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0xA585870", Offset = "0xA584870", VA = "0x18A585870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid FQKZUBKROEI
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0xA584770", Offset = "0xA583770", VA = "0x18A584770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid HWWJKJVMKMY
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0xA58C2F0", Offset = "0xA58B2F0", VA = "0x18A58C2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid EWYEXRAGTTS
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0xA5887F0", Offset = "0xA5877F0", VA = "0x18A5887F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid JGXCCYUDYVR
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0xA592B70", Offset = "0xA591B70", VA = "0x18A592B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid JHMWUTBWBDS
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0xA592CF0", Offset = "0xA591CF0", VA = "0x18A592CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid ZUPWDAFHPFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0xA5923F0", Offset = "0xA5913F0", VA = "0x18A5923F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid WSRFXUDOFIH
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0xA58C870", Offset = "0xA58B870", VA = "0x18A58C870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid YZTRZXUTAAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0xA58F4F0", Offset = "0xA58E4F0", VA = "0x18A58F4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid OFOLIJXTHUY
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0xA585F70", Offset = "0xA584F70", VA = "0x18A585F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid CMJKHZUIYGR
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0xA58D670", Offset = "0xA58C670", VA = "0x18A58D670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid ADSZBFHAZLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0xA5843F0", Offset = "0xA5833F0", VA = "0x18A5843F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid WOEKIDOJTHM
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0xA5853F0", Offset = "0xA5843F0", VA = "0x18A5853F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid LSBSWDBGZQZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0xA58FA70", Offset = "0xA58EA70", VA = "0x18A58FA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid LDSYABNKTAF
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0xA5913F0", Offset = "0xA5903F0", VA = "0x18A5913F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid FRKKJERGJGR
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0xA586570", Offset = "0xA585570", VA = "0x18A586570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid CIAEHDNMJSB
				{
					[Cpp2IlInjected.Token(Token = "0x600023C")]
					[Cpp2IlInjected.Address(RVA = "0xA588F70", Offset = "0xA587F70", VA = "0x18A588F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid FQMPPTYOZZW
				{
					[Cpp2IlInjected.Token(Token = "0x600023D")]
					[Cpp2IlInjected.Address(RVA = "0xA5833F0", Offset = "0xA5823F0", VA = "0x18A5833F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid FLHKOXWGOOZ
				{
					[Cpp2IlInjected.Token(Token = "0x600023E")]
					[Cpp2IlInjected.Address(RVA = "0xA590D70", Offset = "0xA58FD70", VA = "0x18A590D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid KOYUCALVTDS
				{
					[Cpp2IlInjected.Token(Token = "0x600023F")]
					[Cpp2IlInjected.Address(RVA = "0xA585B70", Offset = "0xA584B70", VA = "0x18A585B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid BFTCGNJJPOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000240")]
					[Cpp2IlInjected.Address(RVA = "0xA585EF0", Offset = "0xA584EF0", VA = "0x18A585EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid JFUKUBDCOBS
				{
					[Cpp2IlInjected.Token(Token = "0x6000241")]
					[Cpp2IlInjected.Address(RVA = "0xA5905F0", Offset = "0xA58F5F0", VA = "0x18A5905F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid HXHGWYORUWI
				{
					[Cpp2IlInjected.Token(Token = "0x6000242")]
					[Cpp2IlInjected.Address(RVA = "0xA584D70", Offset = "0xA583D70", VA = "0x18A584D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid QPGWBWLCIXC
				{
					[Cpp2IlInjected.Token(Token = "0x6000243")]
					[Cpp2IlInjected.Address(RVA = "0xA58B7F0", Offset = "0xA58A7F0", VA = "0x18A58B7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid BNOPUCYJWPM
				{
					[Cpp2IlInjected.Token(Token = "0x6000244")]
					[Cpp2IlInjected.Address(RVA = "0xA592E70", Offset = "0xA591E70", VA = "0x18A592E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid REUXGFZNHRP
				{
					[Cpp2IlInjected.Token(Token = "0x6000245")]
					[Cpp2IlInjected.Address(RVA = "0xA5859F0", Offset = "0xA5849F0", VA = "0x18A5859F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid BDAIQZPDDNX
				{
					[Cpp2IlInjected.Token(Token = "0x6000246")]
					[Cpp2IlInjected.Address(RVA = "0xA590670", Offset = "0xA58F670", VA = "0x18A590670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid BJFLKABMYBC
				{
					[Cpp2IlInjected.Token(Token = "0x6000247")]
					[Cpp2IlInjected.Address(RVA = "0xA5896F0", Offset = "0xA5886F0", VA = "0x18A5896F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid ASMRQIKGBPT
				{
					[Cpp2IlInjected.Token(Token = "0x6000248")]
					[Cpp2IlInjected.Address(RVA = "0xA58CDF0", Offset = "0xA58BDF0", VA = "0x18A58CDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid ALYUEZGNCLA
				{
					[Cpp2IlInjected.Token(Token = "0x6000249")]
					[Cpp2IlInjected.Address(RVA = "0xA589B70", Offset = "0xA588B70", VA = "0x18A589B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid MIJAFNFNCDZ
				{
					[Cpp2IlInjected.Token(Token = "0x600024A")]
					[Cpp2IlInjected.Address(RVA = "0xA58B6F0", Offset = "0xA58A6F0", VA = "0x18A58B6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid GHOKMNGNDKF
				{
					[Cpp2IlInjected.Token(Token = "0x600024B")]
					[Cpp2IlInjected.Address(RVA = "0xA590EF0", Offset = "0xA58FEF0", VA = "0x18A590EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid PDTYFXCPBBA
				{
					[Cpp2IlInjected.Token(Token = "0x600024C")]
					[Cpp2IlInjected.Address(RVA = "0xA58F070", Offset = "0xA58E070", VA = "0x18A58F070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid IIRYBGBZGHK
				{
					[Cpp2IlInjected.Token(Token = "0x600024D")]
					[Cpp2IlInjected.Address(RVA = "0xA583270", Offset = "0xA582270", VA = "0x18A583270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid MIRQAUJUPNT
				{
					[Cpp2IlInjected.Token(Token = "0x600024E")]
					[Cpp2IlInjected.Address(RVA = "0xA587E70", Offset = "0xA586E70", VA = "0x18A587E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid IYJFSXRFRQM
				{
					[Cpp2IlInjected.Token(Token = "0x600024F")]
					[Cpp2IlInjected.Address(RVA = "0xA5901F0", Offset = "0xA58F1F0", VA = "0x18A5901F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid RZDQNRVILUB
				{
					[Cpp2IlInjected.Token(Token = "0x6000250")]
					[Cpp2IlInjected.Address(RVA = "0xA587BF0", Offset = "0xA586BF0", VA = "0x18A587BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid ZXAEIBYQJZS
				{
					[Cpp2IlInjected.Token(Token = "0x6000251")]
					[Cpp2IlInjected.Address(RVA = "0xA592A70", Offset = "0xA591A70", VA = "0x18A592A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid BGXTRRYIMTF
				{
					[Cpp2IlInjected.Token(Token = "0x6000252")]
					[Cpp2IlInjected.Address(RVA = "0xA58AD70", Offset = "0xA589D70", VA = "0x18A58AD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid RWZSKDZGEDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000253")]
					[Cpp2IlInjected.Address(RVA = "0xA58C1F0", Offset = "0xA58B1F0", VA = "0x18A58C1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid AEOJPRTZUEQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000254")]
					[Cpp2IlInjected.Address(RVA = "0xA587070", Offset = "0xA586070", VA = "0x18A587070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid JYYZAIACRZU
				{
					[Cpp2IlInjected.Token(Token = "0x6000255")]
					[Cpp2IlInjected.Address(RVA = "0xA58A070", Offset = "0xA589070", VA = "0x18A58A070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid HBUDSBNCGIE
				{
					[Cpp2IlInjected.Token(Token = "0x6000256")]
					[Cpp2IlInjected.Address(RVA = "0xA58F970", Offset = "0xA58E970", VA = "0x18A58F970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid DTBSYZLEZUF
				{
					[Cpp2IlInjected.Token(Token = "0x6000257")]
					[Cpp2IlInjected.Address(RVA = "0xA58B1F0", Offset = "0xA58A1F0", VA = "0x18A58B1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid QRBQFXTMYOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000258")]
					[Cpp2IlInjected.Address(RVA = "0xA587FF0", Offset = "0xA586FF0", VA = "0x18A587FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid RCMKVKMHZEK
				{
					[Cpp2IlInjected.Token(Token = "0x6000259")]
					[Cpp2IlInjected.Address(RVA = "0xA58AB70", Offset = "0xA589B70", VA = "0x18A58AB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid NCOUKWWICWG
				{
					[Cpp2IlInjected.Token(Token = "0x600025A")]
					[Cpp2IlInjected.Address(RVA = "0xA5908F0", Offset = "0xA58F8F0", VA = "0x18A5908F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid BGXBSHBEJUV
				{
					[Cpp2IlInjected.Token(Token = "0x600025B")]
					[Cpp2IlInjected.Address(RVA = "0xA587CF0", Offset = "0xA586CF0", VA = "0x18A587CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid BZKGUUWOFPK
				{
					[Cpp2IlInjected.Token(Token = "0x600025C")]
					[Cpp2IlInjected.Address(RVA = "0xA5878F0", Offset = "0xA5868F0", VA = "0x18A5878F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid YKNISJEYKEO
				{
					[Cpp2IlInjected.Token(Token = "0x600025D")]
					[Cpp2IlInjected.Address(RVA = "0xA58BDF0", Offset = "0xA58ADF0", VA = "0x18A58BDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid OOEJVSOLKTO
				{
					[Cpp2IlInjected.Token(Token = "0x600025E")]
					[Cpp2IlInjected.Address(RVA = "0xA58C670", Offset = "0xA58B670", VA = "0x18A58C670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid ILABUAFLFAQ
				{
					[Cpp2IlInjected.Token(Token = "0x600025F")]
					[Cpp2IlInjected.Address(RVA = "0xA58ED70", Offset = "0xA58DD70", VA = "0x18A58ED70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid KSZXXXOOQTG
				{
					[Cpp2IlInjected.Token(Token = "0x6000260")]
					[Cpp2IlInjected.Address(RVA = "0xA58E3F0", Offset = "0xA58D3F0", VA = "0x18A58E3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid WXBAYKULLHW
				{
					[Cpp2IlInjected.Token(Token = "0x6000261")]
					[Cpp2IlInjected.Address(RVA = "0xA58EC70", Offset = "0xA58DC70", VA = "0x18A58EC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid LRXTKQVAQLN
				{
					[Cpp2IlInjected.Token(Token = "0x6000262")]
					[Cpp2IlInjected.Address(RVA = "0xA58F6F0", Offset = "0xA58E6F0", VA = "0x18A58F6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid HMCPLWJJLIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000263")]
					[Cpp2IlInjected.Address(RVA = "0xA58BA70", Offset = "0xA58AA70", VA = "0x18A58BA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid VPXOABAINSF
				{
					[Cpp2IlInjected.Token(Token = "0x6000264")]
					[Cpp2IlInjected.Address(RVA = "0xA590FF0", Offset = "0xA58FFF0", VA = "0x18A590FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid MUHDANHORSL
				{
					[Cpp2IlInjected.Token(Token = "0x6000265")]
					[Cpp2IlInjected.Address(RVA = "0xA58B3F0", Offset = "0xA58A3F0", VA = "0x18A58B3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid SHZFCIGXSSD
				{
					[Cpp2IlInjected.Token(Token = "0x6000266")]
					[Cpp2IlInjected.Address(RVA = "0xA586370", Offset = "0xA585370", VA = "0x18A586370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid MRNDXPDAZLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000267")]
					[Cpp2IlInjected.Address(RVA = "0xA591270", Offset = "0xA590270", VA = "0x18A591270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid GUUQASKLYOO
				{
					[Cpp2IlInjected.Token(Token = "0x6000268")]
					[Cpp2IlInjected.Address(RVA = "0xA585C70", Offset = "0xA584C70", VA = "0x18A585C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid HGCFQRAVQOV
				{
					[Cpp2IlInjected.Token(Token = "0x6000269")]
					[Cpp2IlInjected.Address(RVA = "0xA5894F0", Offset = "0xA5884F0", VA = "0x18A5894F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid CSGIXYAAHMW
				{
					[Cpp2IlInjected.Token(Token = "0x600026A")]
					[Cpp2IlInjected.Address(RVA = "0xA5835F0", Offset = "0xA5825F0", VA = "0x18A5835F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid ROBMQOPTTZF
				{
					[Cpp2IlInjected.Token(Token = "0x600026B")]
					[Cpp2IlInjected.Address(RVA = "0xA590870", Offset = "0xA58F870", VA = "0x18A590870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid XCRELKCGKHP
				{
					[Cpp2IlInjected.Token(Token = "0x600026C")]
					[Cpp2IlInjected.Address(RVA = "0xA58DA70", Offset = "0xA58CA70", VA = "0x18A58DA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid XNURSWENVYX
				{
					[Cpp2IlInjected.Token(Token = "0x600026D")]
					[Cpp2IlInjected.Address(RVA = "0xA5844F0", Offset = "0xA5834F0", VA = "0x18A5844F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid TXVQIUVTIGY
				{
					[Cpp2IlInjected.Token(Token = "0x600026E")]
					[Cpp2IlInjected.Address(RVA = "0xA58FCF0", Offset = "0xA58ECF0", VA = "0x18A58FCF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid KTYNAOVEBFX
				{
					[Cpp2IlInjected.Token(Token = "0x600026F")]
					[Cpp2IlInjected.Address(RVA = "0xA585770", Offset = "0xA584770", VA = "0x18A585770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid LDZHJLSQUAE
				{
					[Cpp2IlInjected.Token(Token = "0x6000270")]
					[Cpp2IlInjected.Address(RVA = "0xA58C470", Offset = "0xA58B470", VA = "0x18A58C470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid LCAECJPWDVR
				{
					[Cpp2IlInjected.Token(Token = "0x6000271")]
					[Cpp2IlInjected.Address(RVA = "0xA592D70", Offset = "0xA591D70", VA = "0x18A592D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid DZOGXFQONYL
				{
					[Cpp2IlInjected.Token(Token = "0x6000272")]
					[Cpp2IlInjected.Address(RVA = "0xA58D970", Offset = "0xA58C970", VA = "0x18A58D970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid PNBDAJSQQDR
				{
					[Cpp2IlInjected.Token(Token = "0x6000273")]
					[Cpp2IlInjected.Address(RVA = "0xA58D770", Offset = "0xA58C770", VA = "0x18A58D770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid TEYTCBQLVUG
				{
					[Cpp2IlInjected.Token(Token = "0x6000274")]
					[Cpp2IlInjected.Address(RVA = "0xA58D9F0", Offset = "0xA58C9F0", VA = "0x18A58D9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid ACTYVRGGHYZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000275")]
					[Cpp2IlInjected.Address(RVA = "0xA585CF0", Offset = "0xA584CF0", VA = "0x18A585CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid WPNFCWGWRFY
				{
					[Cpp2IlInjected.Token(Token = "0x6000276")]
					[Cpp2IlInjected.Address(RVA = "0xA58ECF0", Offset = "0xA58DCF0", VA = "0x18A58ECF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid RFVGSCUTNCB
				{
					[Cpp2IlInjected.Token(Token = "0x6000277")]
					[Cpp2IlInjected.Address(RVA = "0xA5832F0", Offset = "0xA5822F0", VA = "0x18A5832F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid MYSFNLINNLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000278")]
					[Cpp2IlInjected.Address(RVA = "0xA58D0F0", Offset = "0xA58C0F0", VA = "0x18A58D0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid CIFPGHLZVYT
				{
					[Cpp2IlInjected.Token(Token = "0x6000279")]
					[Cpp2IlInjected.Address(RVA = "0xA5840F0", Offset = "0xA5830F0", VA = "0x18A5840F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid ZBPSTZVEVRZ
				{
					[Cpp2IlInjected.Token(Token = "0x600027A")]
					[Cpp2IlInjected.Address(RVA = "0xA589870", Offset = "0xA588870", VA = "0x18A589870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid YPACJDJCRRD
				{
					[Cpp2IlInjected.Token(Token = "0x600027B")]
					[Cpp2IlInjected.Address(RVA = "0xA5929F0", Offset = "0xA5919F0", VA = "0x18A5929F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid SHFDSFHHOVR
				{
					[Cpp2IlInjected.Token(Token = "0x600027C")]
					[Cpp2IlInjected.Address(RVA = "0xA587570", Offset = "0xA586570", VA = "0x18A587570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid IJGDHKFWGUG
				{
					[Cpp2IlInjected.Token(Token = "0x600027D")]
					[Cpp2IlInjected.Address(RVA = "0xA583570", Offset = "0xA582570", VA = "0x18A583570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid NGCXYSZTHPT
				{
					[Cpp2IlInjected.Token(Token = "0x600027E")]
					[Cpp2IlInjected.Address(RVA = "0xA5927F0", Offset = "0xA5917F0", VA = "0x18A5927F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid NDGIKVGGNDW
				{
					[Cpp2IlInjected.Token(Token = "0x600027F")]
					[Cpp2IlInjected.Address(RVA = "0xA582F70", Offset = "0xA581F70", VA = "0x18A582F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid FOEIUVSGMHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000280")]
					[Cpp2IlInjected.Address(RVA = "0xA584370", Offset = "0xA583370", VA = "0x18A584370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid QVDQRSANSFJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000281")]
					[Cpp2IlInjected.Address(RVA = "0xA5860F0", Offset = "0xA5850F0", VA = "0x18A5860F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid BIATIIYYDLM
				{
					[Cpp2IlInjected.Token(Token = "0x6000282")]
					[Cpp2IlInjected.Address(RVA = "0xA582AA0", Offset = "0xA581AA0", VA = "0x18A582AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid OKNTUCMKDWW
				{
					[Cpp2IlInjected.Token(Token = "0x6000283")]
					[Cpp2IlInjected.Address(RVA = "0xA58B570", Offset = "0xA58A570", VA = "0x18A58B570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid CFIHWOLEFSN
				{
					[Cpp2IlInjected.Token(Token = "0x6000284")]
					[Cpp2IlInjected.Address(RVA = "0xA582EA0", Offset = "0xA581EA0", VA = "0x18A582EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid FCRLFNCJQXD
				{
					[Cpp2IlInjected.Token(Token = "0x6000285")]
					[Cpp2IlInjected.Address(RVA = "0xA58AF70", Offset = "0xA589F70", VA = "0x18A58AF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid HCCNTUXEGPA
				{
					[Cpp2IlInjected.Token(Token = "0x6000286")]
					[Cpp2IlInjected.Address(RVA = "0xA58AAF0", Offset = "0xA589AF0", VA = "0x18A58AAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid FSNMVHOYQXB
				{
					[Cpp2IlInjected.Token(Token = "0x6000287")]
					[Cpp2IlInjected.Address(RVA = "0xA5900F0", Offset = "0xA58F0F0", VA = "0x18A5900F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid CBQWKESDYHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000288")]
					[Cpp2IlInjected.Address(RVA = "0xA588D70", Offset = "0xA587D70", VA = "0x18A588D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid QYQERZHREMJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000289")]
					[Cpp2IlInjected.Address(RVA = "0xA590470", Offset = "0xA58F470", VA = "0x18A590470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid XZUGZTQSBBW
				{
					[Cpp2IlInjected.Token(Token = "0x600028A")]
					[Cpp2IlInjected.Address(RVA = "0xA586B70", Offset = "0xA585B70", VA = "0x18A586B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid LHUFEYLHGMS
				{
					[Cpp2IlInjected.Token(Token = "0x600028B")]
					[Cpp2IlInjected.Address(RVA = "0xA590B70", Offset = "0xA58FB70", VA = "0x18A590B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid REBHRISJZGV
				{
					[Cpp2IlInjected.Token(Token = "0x600028C")]
					[Cpp2IlInjected.Address(RVA = "0xA58F5F0", Offset = "0xA58E5F0", VA = "0x18A58F5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid AGBMMSYRPVR
				{
					[Cpp2IlInjected.Token(Token = "0x600028D")]
					[Cpp2IlInjected.Address(RVA = "0xA586770", Offset = "0xA585770", VA = "0x18A586770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid VIGNKBZFIKY
				{
					[Cpp2IlInjected.Token(Token = "0x600028E")]
					[Cpp2IlInjected.Address(RVA = "0xA58B770", Offset = "0xA58A770", VA = "0x18A58B770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid MTMZVRLEAPO
				{
					[Cpp2IlInjected.Token(Token = "0x600028F")]
					[Cpp2IlInjected.Address(RVA = "0xA58A0F0", Offset = "0xA5890F0", VA = "0x18A58A0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid MUCUNLSWCXP
				{
					[Cpp2IlInjected.Token(Token = "0x6000290")]
					[Cpp2IlInjected.Address(RVA = "0xA58A170", Offset = "0xA589170", VA = "0x18A58A170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid RJVZXRWDQTQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000291")]
					[Cpp2IlInjected.Address(RVA = "0xA58BCF0", Offset = "0xA58ACF0", VA = "0x18A58BCF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid HLREYGFBEMX
				{
					[Cpp2IlInjected.Token(Token = "0x6000292")]
					[Cpp2IlInjected.Address(RVA = "0xA5837F0", Offset = "0xA5827F0", VA = "0x18A5837F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid ZCQNVFPBSYZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000293")]
					[Cpp2IlInjected.Address(RVA = "0xA589070", Offset = "0xA588070", VA = "0x18A589070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid WIRMHJFXMRL
				{
					[Cpp2IlInjected.Token(Token = "0x6000294")]
					[Cpp2IlInjected.Address(RVA = "0xA58CE70", Offset = "0xA58BE70", VA = "0x18A58CE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid AUYROJUGQTU
				{
					[Cpp2IlInjected.Token(Token = "0x6000295")]
					[Cpp2IlInjected.Address(RVA = "0xA58F670", Offset = "0xA58E670", VA = "0x18A58F670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid MEIROKZCCCZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000296")]
					[Cpp2IlInjected.Address(RVA = "0xA58A770", Offset = "0xA589770", VA = "0x18A58A770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid QGUUNBRQJSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000297")]
					[Cpp2IlInjected.Address(RVA = "0xA592BF0", Offset = "0xA591BF0", VA = "0x18A592BF0")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA593B40", Offset = "0xA592B40", VA = "0x18A593B40")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA593F20", Offset = "0xA592F20", VA = "0x18A593F20")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> UGYNOEHKSPW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class ZYIHOEGNCJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA593760", Offset = "0xA592760", VA = "0x18A593760")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class HAFBWLDZWSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xA57F8D0", Offset = "0xA57E8D0", VA = "0x18A57F8D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class OAQZXWSFCZH
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA57FA90", Offset = "0xA57EA90", VA = "0x18A57FA90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57FCC0", Offset = "0xA57ECC0", VA = "0x18A57FCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A8050", Offset = "0xA5A7050", VA = "0x18A5A8050")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class AAJUKUFSVQP
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3E80", Offset = "0xA5A2E80", VA = "0x18A5A3E80")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A9E00", Offset = "0xA5A8E00", VA = "0x18A5A9E00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class XEDDKPFJGPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9C40", Offset = "0xA5A8C40", VA = "0x18A5A9C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA578AD0", Offset = "0xA577AD0", VA = "0x18A578AD0")]
		public static PersistedRoomData ZBDCUYOJRTM(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5782A0", Offset = "0xA5772A0", VA = "0x18A5782A0")]
		public static Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA5783D0", Offset = "0xA5773D0", VA = "0x18A5783D0")]
		public static Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5786B0", Offset = "0xA5776B0", VA = "0x18A5786B0")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, PersistedRoomData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5789F0", Offset = "0xA5779F0", VA = "0x18A5789F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A6A10", Offset = "0xA5A5A10", VA = "0x18A5A6A10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A6700", Offset = "0xA5A5700", VA = "0x18A5A6700")]
		public static SZARDBYZIVI? XFULNIVCIDK([Optional] ZJQHGLFBKLO? a, [Optional] PLRJAEEQHSU? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5D30", Offset = "0xA5A4D30", VA = "0x18A5A5D30")]
		public static Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, byte[]? bytes)
		{
			return default(Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A58B0", Offset = "0xA5A48B0", VA = "0x18A5A58B0")]
		public static Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<SZARDBYZIVI>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A65D0", Offset = "0xA5A55D0", VA = "0x18A5A65D0")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, SZARDBYZIVI b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4CB0", Offset = "0xA5A3CB0", VA = "0x18A5A4CB0")]
		public static void ABZXOWIXTDJ(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4FB0", Offset = "0xA5A3FB0", VA = "0x18A5A4FB0")]
		public static void ACFEMDCVCOS(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A51F0", Offset = "0xA5A41F0", VA = "0x18A5A51F0")]
		public static void ACKLJJWSMAB(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5690", Offset = "0xA5A4690", VA = "0x18A5A5690")]
		public static void ACPSGQQPVLK(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A57C0", Offset = "0xA5A47C0", VA = "0x18A5A57C0")]
		public static void ACUZDXKNEWT(SZARDBYZIVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5E90", Offset = "0xA5A4E90", VA = "0x18A5A5E90")]
		private static PLRJAEEQHSU GIHHDVOHORY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5F70", Offset = "0xA5A4F70", VA = "0x18A5A5F70")]
		private static PLRJAEEQHSU GIMOBCIEYDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5E60", Offset = "0xA5A4E60", VA = "0x18A5A5E60")]
		[CompilerGenerated]
		internal static bool FBXNBZBADER(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A61A0", Offset = "0xA5A51A0", VA = "0x18A5A61A0")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV ILMSFJSPRWH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A65A0", Offset = "0xA5A55A0", VA = "0x18A5A65A0")]
		[CompilerGenerated]
		internal static float TLSIJEHSZYL(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6210", Offset = "0xA5A5210", VA = "0x18A5A6210")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV JLWNKXHPLEH(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6570", Offset = "0xA5A5570", VA = "0x18A5A6570")]
		[CompilerGenerated]
		internal static int SFSOJWXGKAW(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A63E0", Offset = "0xA5A53E0", VA = "0x18A5A63E0")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV PVJKIWRJKAK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6280", Offset = "0xA5A5280", VA = "0x18A5A6280")]
		[CompilerGenerated]
		internal static CircuitsQuat MDFQVIZWYDB(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6450", Offset = "0xA5A5450", VA = "0x18A5A6450")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV QTAIBVZITPT(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6350", Offset = "0xA5A5350", VA = "0x18A5A6350")]
		[CompilerGenerated]
		internal static string OFBBCSVURYI(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6370", Offset = "0xA5A5370", VA = "0x18A5A6370")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV PBVHOCXETZA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A60C0", Offset = "0xA5A50C0", VA = "0x18A5A60C0")]
		[CompilerGenerated]
		internal static CircuitsVec3 HWZMVLDCDNG(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5830", Offset = "0xA5A4830", VA = "0x18A5A5830")]
		[CompilerGenerated]
		internal static RAIQVFTYDPV ACVRBRAHVUW(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6050", Offset = "0xA5A5050", VA = "0x18A5A6050")]
		[CompilerGenerated]
		internal static int HKQKNOPHPDZ(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A64D0", Offset = "0xA5A54D0", VA = "0x18A5A64D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A9A10", Offset = "0xA5A8A10", VA = "0x18A5A9A10")]
		public static ILAYAIZJRWU CZDOOTFVIKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A95D0", Offset = "0xA5A85D0", VA = "0x18A5A95D0")]
		public static Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, byte[] b)
		{
			return default(Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A96C0", Offset = "0xA5A86C0", VA = "0x18A5A96C0")]
		public static Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<ILAYAIZJRWU>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9A60", Offset = "0xA5A8A60", VA = "0x18A5A9A60")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(VOUHRIHXBOE.UYPXTMTCQYP a, ILAYAIZJRWU b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class BELUWEDSEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A49C0", Offset = "0xA5A39C0", VA = "0x18A5A49C0")]
		public static SpawnableTemplateData LUXOCMUUZRD([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4360", Offset = "0xA5A3360", VA = "0x18A5A4360")]
		public static Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, FYWJENCPTIG.UYPXTMTCQYP b, byte[] c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4040", Offset = "0xA5A3040", VA = "0x18A5A4040")]
		public static Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL> CYXEYPDWPAA(VOUHRIHXBOE.UYPXTMTCQYP a, FYWJENCPTIG.UYPXTMTCQYP b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4A40", Offset = "0xA5A3A40", VA = "0x18A5A4A40")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(VOUHRIHXBOE.UYPXTMTCQYP a, FYWJENCPTIG.UYPXTMTCQYP b, SpawnableTemplateData c)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4460", Offset = "0xA5A3460", VA = "0x18A5A4460")]
		private static Result<None, SIEDSHFPKXL> GMWSADLMCTP(VOUHRIHXBOE.UYPXTMTCQYP a, SpawnableTemplateData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4820", Offset = "0xA5A3820", VA = "0x18A5A4820")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A6A60", Offset = "0xA5A5A60", VA = "0x18A5A6A60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A7C20", Offset = "0xA5A6C20", VA = "0x18A5A7C20")]
		public static SuperRoomData XKNEEPQUURS([Optional] GKWXQZMULWK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7490", Offset = "0xA5A6490", VA = "0x18A5A7490")]
		public static Result<ParseResult<SuperRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A71C0", Offset = "0xA5A61C0", VA = "0x18A5A71C0")]
		public static Result<ParseResult<SuperRoomData>, SIEDSHFPKXL> CYXEYPDWPAA(UYPXTMTCQYP a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A77D0", Offset = "0xA5A67D0", VA = "0x18A5A77D0")]
		public static Result<None, SIEDSHFPKXL> TNMUDZMDIQF(UYPXTMTCQYP a, SuperRoomData b)
		{
			return default(Result<None, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6C40", Offset = "0xA5A5C40", VA = "0x18A5A6C40")]
		private static void ABZXOWIXTDJ(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6E00", Offset = "0xA5A5E00", VA = "0x18A5A6E00")]
		private static void ACFEMDCVCOS(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6F00", Offset = "0xA5A5F00", VA = "0x18A5A6F00")]
		private static void ACKLJJWSMAB(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6F90", Offset = "0xA5A5F90", VA = "0x18A5A6F90")]
		private static void ACPSGQQPVLK(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7900", Offset = "0xA5A6900", VA = "0x18A5A7900")]
		public static DataTableData VJLBQPRSRCP(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5A75C0", Offset = "0xA5A65C0", VA = "0x18A5A75C0")]
		public static ProgressionManagerData EVYAJDUKZSM(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7010", Offset = "0xA5A6010", VA = "0x18A5A7010")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A7EF0", Offset = "0xA5A6EF0", VA = "0x18A5A7EF0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A6BF0", Offset = "0xA5A5BF0", VA = "0x18A5A6BF0")]
		public ESSHDKAKNUS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6B90", Offset = "0xA5A5B90", VA = "0x18A5A6B90", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x7526240", Offset = "0x7525240", VA = "0x187526240")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A6BF0", Offset = "0xA5A5BF0", VA = "0x18A5A6BF0")]
		public VBMGKBVWECR(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9BE0", Offset = "0xA5A8BE0", VA = "0x18A5A9BE0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9B30", Offset = "0xA5A8B30", VA = "0x18A5A9B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8588100", Offset = "0x8587100", VA = "0x188588100")]
		public Result<TVersion, SIEDSHFPKXL> TNMUDZMDIQF(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8587F70", Offset = "0x8586F70", VA = "0x188587F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x77384D0", Offset = "0x77374D0", VA = "0x1877384D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8587880", Offset = "0x8586880", VA = "0x188587880")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x85879C0", Offset = "0x85869C0", VA = "0x1885879C0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8587B40", Offset = "0x8586B40", VA = "0x188587B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A8020", Offset = "0xA5A7020", VA = "0x18A5A8020", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7F20", Offset = "0xA5A6F20", VA = "0x18A5A7F20", Slot = "8")]
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
