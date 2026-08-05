using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Audio;
using RecRoom.NoEngine.Common;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B4F940", Offset = "0x9B4E340", VA = "0x189B4F940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ObjectConfigs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class JKJXRDMPPQL : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HSXXEZIOVPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JKJXRDMPPQL TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public HSXXEZIOVPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9B468B0", Offset = "0x9B452B0", VA = "0x189B468B0")]
			internal bool HJKFOPGHYKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9B45E00", Offset = "0x9B44800", VA = "0x189B45E00")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IReadOnlyList<Channel> MDJYMVDPOCK;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IReadOnlyList<Channel> SOTZTZUKLHX;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly IReadOnlyList<RolloffCurve> MWLMIMWQAQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MultiValueConfigProperty<float> FCIITUYJGZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MultiValueConfigProperty<float> WITZVTVIVRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MultiValueConfigProperty<Channel> ZJZETFRGIGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly bool ZBQTXYOFCEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string PCQJTEGGADV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MultiValueConfigProperty<bool> ZXRLBQCQZZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MultiValueConfigProperty<float> HDRBOJKHWFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MultiValueConfigProperty<RolloffCurve> DCUZCZWWGSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MultiValueConfigProperty<bool> BEDPKXGURNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly string OQHOYIMVSHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MultiValueConfigProperty<bool> SLSTHDBTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly string EWYKZUNGUZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MultiValueConfigProperty<bool> QQVIBHRNHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly CNUHDIQJNBT? AWVKRPQIWFX;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B48450", Offset = "0x9B46E50", VA = "0x189B48450")]
		private static string GBIFTSMGYSN(Channel a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B48500", Offset = "0x9B46F00", VA = "0x189B48500")]
		private static string IVUHMADVHVL(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B48810", Offset = "0x9B47210", VA = "0x189B48810")]
		public JKJXRDMPPQL(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<Channel> c, bool d, string useSpatialAudioLabel, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<RolloffCurve> g, MultiValueConfigProperty<bool> h, string isLoopingLabel, MultiValueConfigProperty<bool> i, string interruptCurrentSoundLabel, MultiValueConfigProperty<bool> j, CNUHDIQJNBT? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B48570", Offset = "0x9B46F70", VA = "0x189B48570", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class GOEYFGORZJA : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DMJSJVVHHBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GOEYFGORZJA TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Func<bool> XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Func<bool> XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DMJSJVVHHBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B422A0", Offset = "0x9B40CA0", VA = "0x189B422A0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B42300", Offset = "0x9B40D00", VA = "0x189B42300")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9B42970", Offset = "0x9B41370", VA = "0x189B42970")]
			internal bool EMDWKHEZZNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9B429F0", Offset = "0x9B413F0", VA = "0x189B429F0")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly IReadOnlyDictionary<Channel, string> STGYPUDEICD;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly IReadOnlyDictionary<Channel, string> YTFJOFYUEUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool VVEUZRQMGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly QYMRNNDKUIM KMIYXRSSMVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MultiValueConfigProperty<bool> RFZPTMWGDRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MultiValueConfigProperty<Channel> ZJZETFRGIGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly MultiValueConfigProperty<float> BNHSPBGIAMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MultiValueConfigProperty<float> TWSAXFZJDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MultiValueConfigProperty<bool> OKHDJNDOGYL;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B45800", Offset = "0x9B44200", VA = "0x189B45800")]
		public GOEYFGORZJA(bool a, QYMRNNDKUIM recordableObjectOptions, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<Channel> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B45450", Offset = "0x9B43E50", VA = "0x189B45450", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class TTSCTSJLDVU : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public TTSCTSJLDVU TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Func<bool> XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Func<bool> XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> XZSOTIOAZII;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9B50810", Offset = "0x9B4F210", VA = "0x189B50810")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9B51520", Offset = "0x9B4FF20", VA = "0x189B51520")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9B516D0", Offset = "0x9B500D0", VA = "0x189B516D0")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9B51780", Offset = "0x9B50180", VA = "0x189B51780")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9B51800", Offset = "0x9B50200", VA = "0x189B51800")]
			internal bool EMOKEUSUSKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9B51820", Offset = "0x9B50220", VA = "0x189B51820")]
			internal bool EMTRCBMSBVJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Option<string> MSSQRHEDAUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MultiValueConfigProperty<bool> OEIJEFBMDWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly IReadOnlyDictionary<int, string>? FFKRPWAXBUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MultiValueConfigProperty<int> IATNKVQCGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Option<string> ZIEQIXIJXIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly MultiValueConfigProperty<bool> TPKZMNYYQHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Option<string> XQHZZSZGWTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MultiValueConfigProperty<int> FCIITUYJGZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Option<string> IYMZIEQLJDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly MultiValueConfigProperty<bool> GGCSVGBENJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Func<Option<bool>> ZONBLBIXAPN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B56DC0", Offset = "0x9B557C0", VA = "0x189B56DC0")]
		public TTSCTSJLDVU(Option<string> is3dAudioLabel, MultiValueConfigProperty<bool> a, Option<string[]> sfxOptions, MultiValueConfigProperty<int> b, Option<string> isInterruptibleLabel, MultiValueConfigProperty<bool> c, Option<string> volumeLabel, MultiValueConfigProperty<int> d, Option<string> playForAllLabel, MultiValueConfigProperty<bool> e, Func<Option<bool>> hasControlPanel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B56C80", Offset = "0x9B55680", VA = "0x189B56C80", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class PJCLAHELWFZ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class XPQTJHQZHON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public PJCLAHELWFZ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XPQTJHQZHON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CCD0", Offset = "0x9B5B6D0", VA = "0x189B5CCD0")]
			internal bool FLTXKSMALOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CA80", Offset = "0x9B5B480", VA = "0x189B5CA80")]
			internal bool CTLBIAPVFWA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CB80", Offset = "0x9B5B580", VA = "0x189B5CB80")]
			internal void EMOKEUSUSKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CBE0", Offset = "0x9B5B5E0", VA = "0x189B5CBE0")]
			internal bool EMTRCBMSBVJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CC50", Offset = "0x9B5B650", VA = "0x189B5CC50")]
			internal bool EMYXZIGPLGS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CAD0", Offset = "0x9B5B4D0", VA = "0x189B5CAD0")]
			internal bool EMDWKHEZZNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CB60", Offset = "0x9B5B560", VA = "0x189B5CB60")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly IReadOnlyList<PreferredHandedness> QFZOLWFHJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly AccountRoleType LKYURKURAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HKSCCEYWDRV? WBTHIJRKDXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly MultiValueConfigProperty<bool> IKBOGRBIJPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Option<bool> FLXPXRCWIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Option<bool> DQXMGLSCYDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly MultiValueConfigProperty<PreferredHandedness> PFBRKNEGPSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MultiValueConfigProperty<bool> CPMXEALBGWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly MultiValueConfigProperty<bool> ZWJEJWHXHTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly MultiValueConfigProperty<bool> WZWALWKAXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly MultiValueConfigProperty<bool> RJMHKGZAIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly MultiValueConfigProperty<bool> RJFVMSRVWGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MultiValueConfigProperty<bool> BNICWDPRVYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly bool ACCTAHTCNDT;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B518B0", Offset = "0x9B502B0", VA = "0x189B518B0")]
		private static string CJKUSACJSIE(PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B524D0", Offset = "0x9B50ED0", VA = "0x189B524D0")]
		public PJCLAHELWFZ(AccountRoleType a, HKSCCEYWDRV? interactionFilterOptions, MultiValueConfigProperty<bool> b, Option<bool> c, Option<bool> d, MultiValueConfigProperty<PreferredHandedness> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, bool l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B518C0", Offset = "0x9B502C0", VA = "0x189B518C0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class CEMIVFWAPNC : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public CEMIVFWAPNC TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<bool> YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Action XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Func<bool> XZSOTIOAZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9B434C0", Offset = "0x9B41EC0", VA = "0x189B434C0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9B43F20", Offset = "0x9B42920", VA = "0x189B43F20")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9B44460", Offset = "0x9B42E60", VA = "0x189B44460")]
			internal void EMJDHNYXIYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B445C0", Offset = "0x9B42FC0", VA = "0x189B445C0")]
			internal void EMOKEUSUSKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B44760", Offset = "0x9B43160", VA = "0x189B44760")]
			internal bool EMYXZIGPLGS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B44730", Offset = "0x9B43130", VA = "0x189B44730")]
			internal bool EMTRCBMSBVJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9B443F0", Offset = "0x9B42DF0", VA = "0x189B443F0")]
			internal void EMDWKHEZZNI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly bool ZYUICIOBDRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool HBQWUTYUILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly PJCLAHELWFZ IXKSCPHRYQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly WGYIDMSIFZL? WRBRTRBCGZS;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E3A0", Offset = "0x9B3CDA0", VA = "0x189B3E3A0")]
		public CEMIVFWAPNC(int a, bool b, bool c, PJCLAHELWFZ d, WGYIDMSIFZL? creatorRestrictedRolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E260", Offset = "0x9B3CC60", VA = "0x189B3E260", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class YLYGPYWKCUB : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public YLYGPYWKCUB TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A310", Offset = "0x9B58D10", VA = "0x189B5A310")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly PJCLAHELWFZ IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public YLYGPYWKCUB(PJCLAHELWFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B5D960", Offset = "0x9B5C360", VA = "0x189B5D960", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class JEBPYNTIAGP : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public JEBPYNTIAGP TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B402D0", Offset = "0x9B3ECD0", VA = "0x189B402D0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B41480", Offset = "0x9B3FE80", VA = "0x189B41480")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly HKSCCEYWDRV? VGXPMFLKWYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MultiValueConfigProperty<bool> PYUQETWYXRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Option<bool> ZONBLBIXAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly MultiValueConfigProperty<bool> PWFXKLWVYYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly MultiValueConfigProperty<bool> OIOENXVQONW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly EKFHWSGRGZW? IPFMSNVIAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly CNUHDIQJNBT? CURQUDGFBAH;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B47160", Offset = "0x9B45B60", VA = "0x189B47160")]
		public JEBPYNTIAGP(HKSCCEYWDRV? interactionFilterConfig, MultiValueConfigProperty<bool> a, Option<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, CNUHDIQJNBT? syncedComponent, EKFHWSGRGZW? playerEditableText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B47020", Offset = "0x9B45A20", VA = "0x189B47020", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class FZQYOTOLHXV : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public FZQYOTOLHXV TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B55E80", Offset = "0x9B54880", VA = "0x189B55E80")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B56560", Offset = "0x9B54F60", VA = "0x189B56560")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly HKSCCEYWDRV? VGXPMFLKWYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly MultiValueConfigProperty<bool> XWEGBUYTMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly MultiValueConfigProperty<bool> PYUQETWYXRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly MultiValueConfigProperty<bool> QSBEMTEPAVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Option<bool> ZONBLBIXAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly MultiValueConfigProperty<bool> PWFXKLWVYYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly MultiValueConfigProperty<bool> OIOENXVQONW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly CNUHDIQJNBT? CURQUDGFBAH;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B45200", Offset = "0x9B43C00", VA = "0x189B45200")]
		public FZQYOTOLHXV(HKSCCEYWDRV? interactionFilterConfig, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, Option<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, CNUHDIQJNBT? syncedComponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B450C0", Offset = "0x9B43AC0", VA = "0x189B450C0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ZQNFMMWRUNY : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public ZQNFMMWRUNY TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9B47240", Offset = "0x9B45C40", VA = "0x189B47240")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MultiValueConfigProperty<bool> ZPVTEUPYIJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MultiValueConfigProperty<float> MCYNKXHCGXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NVMCMQCOOAE? OEFDLHJXJVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly CNUHDIQJNBT? NGEISKLJRGP;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5E9E0", Offset = "0x9B5D3E0", VA = "0x189B5E9E0")]
		public ZQNFMMWRUNY(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, NVMCMQCOOAE? sandboxColorableOptions, CNUHDIQJNBT? syncedComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B5E8A0", Offset = "0x9B5D2A0", VA = "0x189B5E8A0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class EXEADICTVDA : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public EXEADICTVDA TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B47D80", Offset = "0x9B46780", VA = "0x189B47D80")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly IReadOnlyList<CircuitsTransformBehavior> DUTQFQUNFQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly MultiValueConfigProperty<CircuitsTransformBehavior> ZWBUXABHTRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly EXXZURWSQKV? XPRUWDIMYIZ;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B44790", Offset = "0x9B43190", VA = "0x189B44790")]
		private static string UNNUTDXDLTX(CircuitsTransformBehavior a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E200", Offset = "0x9B3CC00", VA = "0x189B3E200")]
		public EXEADICTVDA(MultiValueConfigProperty<CircuitsTransformBehavior> a, EXXZURWSQKV? objectBoardConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B447E0", Offset = "0x9B431E0", VA = "0x189B447E0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class CFUCFACRVQX : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public CFUCFACRVQX TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F1F0", Offset = "0x9B3DBF0", VA = "0x189B3F1F0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string TNMECJUWNVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly MultiValueConfigProperty<string> MHFAHFDVUCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly MultiValueConfigProperty<bool> OOQJNPOJDTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MultiValueConfigProperty<bool> MCVDSJFTVDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MultiValueConfigProperty<bool> RNDFPRWJXNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly HKSCCEYWDRV? SXBPOUZRMKS;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E550", Offset = "0x9B3CF50", VA = "0x189B3E550")]
		public CFUCFACRVQX(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, HKSCCEYWDRV? portalInteractionFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E410", Offset = "0x9B3CE10", VA = "0x189B3E410", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class ZPNGUDKWCGC : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public ZPNGUDKWCGC TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FF50", Offset = "0x9B4E950", VA = "0x189B4FF50")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string TNMECJUWNVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly MultiValueConfigProperty<string> MHFAHFDVUCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly MultiValueConfigProperty<bool> OOQJNPOJDTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly MultiValueConfigProperty<float> LBJYDCQGACS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly MultiValueConfigProperty<bool> JXRENKIRGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly MultiValueConfigProperty<bool> SUHDTWOCQWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MultiValueConfigProperty<bool> MCVDSJFTVDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly MultiValueConfigProperty<bool> TSFMFQKVYSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly MultiValueConfigProperty<float> YGFSUUJJYKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly HKSCCEYWDRV? WBTHIJRKDXM;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5E710", Offset = "0x9B5D110", VA = "0x189B5E710")]
		public ZPNGUDKWCGC(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<float> g, HKSCCEYWDRV? interactionFilterOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5E5D0", Offset = "0x9B5CFD0", VA = "0x189B5E5D0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class JRJZAACNFEB : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public JRJZAACNFEB TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Func<bool> XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Func<bool> XZXVQPHYITR;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B406B0", Offset = "0x9B3F0B0", VA = "0x189B406B0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B41CD0", Offset = "0x9B406D0", VA = "0x189B41CD0")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B41D40", Offset = "0x9B40740", VA = "0x189B41D40")]
			internal bool EMOKEUSUSKA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Dictionary<LocomotionFilterModes, string> CRGDNHGLGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly MultiValueConfigProperty<bool> GTLYADXVKUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MultiValueConfigProperty<bool> NVTVUSWEFZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MultiValueConfigProperty<bool> RBEEAUBGBGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MultiValueConfigProperty<bool> NEILYCIQDNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MultiValueConfigProperty<string> KFCOYBNTROY;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9B48E40", Offset = "0x9B47840", VA = "0x189B48E40")]
		public JRJZAACNFEB(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> roleFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9B48C00", Offset = "0x9B47600", VA = "0x189B48C00", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class ARAGDGWUVHX : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public ARAGDGWUVHX TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9B558D0", Offset = "0x9B542D0", VA = "0x189B558D0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9B56470", Offset = "0x9B54E70", VA = "0x189B56470")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MultiValueConfigProperty<bool> ZPVTEUPYIJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly MultiValueConfigProperty<bool> GSJGWZFCSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly HKSCCEYWDRV? PKUIFODHBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly MultiValueConfigProperty<bool> NDKIWECFRUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly MultiValueConfigProperty<bool> QQEKDJPZJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly MultiValueConfigProperty<bool> RBEEAUBGBGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CNUHDIQJNBT DITKBRPLVPU;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9B3DE70", Offset = "0x9B3C870", VA = "0x189B3DE70")]
		public ARAGDGWUVHX(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, HKSCCEYWDRV? playerInteractionFilter, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, CNUHDIQJNBT syncComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B3DD20", Offset = "0x9B3C720", VA = "0x189B3DD20", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class KHPYJNICFXZ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public KHPYJNICFXZ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Func<bool> XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public Func<bool> XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<bool> XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9B551B0", Offset = "0x9B53BB0", VA = "0x189B551B0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B56450", Offset = "0x9B54E50", VA = "0x189B56450")]
			internal bool EMOKEUSUSKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9B56450", Offset = "0x9B54E50", VA = "0x189B56450")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9B565B0", Offset = "0x9B54FB0", VA = "0x189B565B0")]
			internal bool EMDWKHEZZNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9B56610", Offset = "0x9B55010", VA = "0x189B56610")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly Dictionary<TriggerVolumeV1Mode, string> RJTHFILREUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MultiValueConfigProperty<TriggerVolumeV1Mode> HSCIJKTSPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly bool PFSHQPEHVTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly MultiValueConfigProperty<bool> UUTQBQXZWTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly MultiValueConfigProperty<bool> OIOENXVQONW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly MultiValueConfigProperty<string> WISIFJKZPFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly MultiValueConfigProperty<string> WLMNHDQPKAY;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9B49150", Offset = "0x9B47B50", VA = "0x189B49150")]
		public KHPYJNICFXZ(MultiValueConfigProperty<int> a, bool b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> filterTag, MultiValueConfigProperty<string> filterRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B48F20", Offset = "0x9B47920", VA = "0x189B48F20", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class IQIYDEGJXIR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public IQIYDEGJXIR TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9B59350", Offset = "0x9B57D50", VA = "0x189B59350")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9B59920", Offset = "0x9B58320", VA = "0x189B59920")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly MultiValueConfigProperty<bool> OIOENXVQONW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly QXEYZOOFTMZ XLHSRTWGURM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly MultiValueConfigProperty<string> CBGTWPSYTWR;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B46F90", Offset = "0x9B45990", VA = "0x189B46F90")]
		public IQIYDEGJXIR(MultiValueConfigProperty<bool> a, QXEYZOOFTMZ objectTagsConfig, MultiValueConfigProperty<string> filterByRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B46E50", Offset = "0x9B45850", VA = "0x189B46E50", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class ZLCWEAFTXCA : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class DMJSJVVHHBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public ZLCWEAFTXCA TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DMJSJVVHHBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B41DB0", Offset = "0x9B407B0", VA = "0x189B41DB0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly MultiValueConfigProperty<bool> OIOENXVQONW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly MultiValueConfigProperty<bool> QCXLRUKLHSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> HIIWBAJUFVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ConfigProperty<IReadOnlyList<string>> PLCDFXFDRFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly ConfigProperty<IReadOnlyList<string>>? ZBLSNXQAYZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly MultiValueConfigProperty<bool> GTJVDRXPTIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> PTDISTKKCWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly ConfigProperty<IReadOnlyList<string>> NUCRVWABFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ConfigProperty<IReadOnlyList<string>>? SEPUMSHDHUE;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B5E440", Offset = "0x9B5CE40", VA = "0x189B5E440")]
		public ZLCWEAFTXCA(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<InteractionFilterMode> d, ConfigProperty<IReadOnlyList<string>> persistentPlayerTags, ConfigProperty<IReadOnlyList<string>>? runtimePlayerTags, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<InteractionFilterMode> f, ConfigProperty<IReadOnlyList<string>> persistentObjectTags, ConfigProperty<IReadOnlyList<string>>? runtimeObjectTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9B5E300", Offset = "0x9B5CD00", VA = "0x189B5E300", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ConfigProperty<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly Func<T> Get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Action<T> Set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Func<bool>? IsModified;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
		public ConfigProperty(Func<T> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class XKFQORGEVJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class LQPRZMCNGRT<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Func<a, b> QRUJHCGPMKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ConfigProperty<a> WPJIKKBEHRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Func<b, a> UVGIVOCTCLI;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LQPRZMCNGRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F10", Offset = "0x68D5910", VA = "0x1868D6F10")]
			internal b RZQGVPKYUKF()
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x68D6690", Offset = "0x68D5090", VA = "0x1868D6690")]
			internal void RKPQTXMEWES(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4129DA0", Offset = "0x41287A0", VA = "0x184129DA0")]
		public static ConfigProperty<U> To<U, T>(this ConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(ConfigProperty<U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class KPLHMSJZOJY : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KNTZTHNOLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public KPLHMSJZOJY TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> XZSOTIOAZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Action XZXVQPHYITR;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNTZTHNOLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9B4B130", Offset = "0x9B49B30", VA = "0x189B4B130")]
			internal bool WUXQVGKWEMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9B4A6D0", Offset = "0x9B490D0", VA = "0x189B4A6D0")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9B4AE20", Offset = "0x9B49820", VA = "0x189B4AE20")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9B4B0C0", Offset = "0x9B49AC0", VA = "0x189B4B0C0")]
			internal bool EMTRCBMSBVJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9B4AFB0", Offset = "0x9B499B0", VA = "0x189B4AFB0")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9B4B060", Offset = "0x9B49A60", VA = "0x189B4B060")]
			internal void EMOKEUSUSKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly (int, string)[] QAHIRLWIPTT;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly Dictionary<int, string> THVRSLLPAHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly int YJVWQEKZPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly HKSCCEYWDRV? VXKAOPTSAHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ConfigProperty<int> BJSBJKHWLYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Action<UOJDHDCBUAJ.MultiTogglePickerData> JROMEFGXNTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly MultiValueConfigProperty<bool> EHPJFEYFWAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly MultiValueConfigProperty<bool> ATZDZIENNOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly WGYIDMSIFZL? CXYXGVZYHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly Func<Option<bool>> LYHBRGSEQZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly MultiValueConfigProperty<bool> ZPSPEJQDDUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MultiValueConfigProperty<bool> NXAMSIQQYYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Func<bool> SCTNZVXCYLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly RoomKeyConfig WVTXHXBFPBM;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B7D0", Offset = "0x9B4A1D0", VA = "0x189B4B7D0")]
		public KPLHMSJZOJY(int a, HKSCCEYWDRV? additionalCostumeConfigOptions, ConfigProperty<int> b, Action<UOJDHDCBUAJ.MultiTogglePickerData> onOutfitFilterClick, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, WGYIDMSIFZL? playerRolesToAddData, Func<Option<bool>> hasPlayerEquipped, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, Func<bool> isLegacyRoom, RoomKeyConfig roomKeyConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B150", Offset = "0x9B49B50", VA = "0x189B4B150", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class UGBMRWAMDFR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly MultiValueConfigProperty<int> UQREQXVRXZY;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public UGBMRWAMDFR(MultiValueConfigProperty<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B57990", Offset = "0x9B56390", VA = "0x189B57990", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class QGEZPSAHVWE : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class LGQWISPHLPS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public QGEZPSAHVWE TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public ConfigProperty<int[]> XREYHNPBSCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public Func<bool> YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public Func<bool> BWYOFEPTMMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public Func<bool> BXDVCLJQVXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<bool> WXHZXFKWKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Func<bool> BWOAKRBYTPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Func<bool> BWTHHXVWDAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public Func<bool> WXCSZYQZARG;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LGQWISPHLPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C120", Offset = "0x9B4AB20", VA = "0x189B4C120")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E220", Offset = "0x9B4CC20", VA = "0x189B4E220")]
			internal bool EMYXZIGPLGS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C8D0", Offset = "0x9B4B2D0", VA = "0x189B4C8D0")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9B4CE90", Offset = "0x9B4B890", VA = "0x189B4CE90")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B4D3D0", Offset = "0x9B4BDD0", VA = "0x189B4D3D0")]
			internal void EMJDHNYXIYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C0B0", Offset = "0x9B4AAB0", VA = "0x189B4C0B0")]
			internal bool DAKQFOUQLSR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C040", Offset = "0x9B4AA40", VA = "0x189B4C040")]
			internal bool DAFJIIATCHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E290", Offset = "0x9B4CC90", VA = "0x189B4E290")]
			internal bool JZLSAEZODYG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9B4BF80", Offset = "0x9B4A980", VA = "0x189B4BF80")]
			internal bool CZFAWAFGHCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9B4BEC0", Offset = "0x9B4A8C0", VA = "0x189B4BEC0")]
			internal bool CYZTYTLIXRG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9B4DCF0", Offset = "0x9B4C6F0", VA = "0x189B4DCF0")]
			internal void EMOKEUSUSKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E350", Offset = "0x9B4CD50", VA = "0x189B4E350")]
			internal bool JZQYXLTLNJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E080", Offset = "0x9B4CA80", VA = "0x189B4E080")]
			internal void EMTRCBMSBVJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class LGWDFZJEVBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public bool XBMWSYCTSSM;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LGWDFZJEVBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			internal bool ENJLTVUKEDK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class LHBKDGDCEMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public int GYZTNLMRBIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public LGQWISPHLPS UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LHBKDGDCEMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E790", Offset = "0x9B4D190", VA = "0x189B4E790")]
			internal bool ENOSRCOHNOT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E490", Offset = "0x9B4CE90", VA = "0x189B4E490")]
			internal void CYUNBMRLOFX(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E440", Offset = "0x9B4CE40", VA = "0x189B4E440")]
			internal bool CYJZGZDQVJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E3E0", Offset = "0x9B4CDE0", VA = "0x189B4E3E0")]
			internal string CYESJSJTLXW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class LHGRAMWZNXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public bool QTSBIOUGSBZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public LHBKDGDCEMK UZSSRCFRLAK;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LHGRAMWZNXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E800", Offset = "0x9B4D200", VA = "0x189B4E800")]
			internal bool CYPGEFXOEUO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly IReadOnlyList<VoiceOption> SLOQBZLECZP;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly IReadOnlyList<VoiceOption> MQUSESLIAQO;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly IReadOnlyList<RolloffCurve> MWLMIMWQAQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly MultiValueConfigProperty<string> SRFMJCTWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly int FDXTBFYIBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly MultiValueConfigProperty<float> FZKITCCWWAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly MultiValueConfigProperty<VoiceOption> PWHTUROCEXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly MultiValueConfigProperty<string> QBIZPYDENFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly MultiValueConfigProperty<bool> PLVMXDQUBOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly MultiValueConfigProperty<bool> XWKRYXZHIQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly string BQWLXHPUXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly MultiValueConfigProperty<bool>? IRWMQMHTXJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly MultiValueConfigProperty<bool>[] LKZKRSDYKWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly IReadOnlyList<string> MMOJRJSCYZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly IReadOnlyList<string> KUGTXDEXDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly IReadOnlyList<bool> AMPDPBYJFIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly ConfigProperty<int[]>? IFQHUTHRFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Func<IEnumerable<int>> GURCHVPSLXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Func<int, bool> VUAMXMLXQPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly Func<int, string?> TPJBDGVMNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly Func<int, string?> XENSKTVEYQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string PCQJTEGGADV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly MultiValueConfigProperty<bool> ZXRLBQCQZZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly MultiValueConfigProperty<float> HDRBOJKHWFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly MultiValueConfigProperty<RolloffCurve> DCUZCZWWGSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly MultiValueConfigProperty<bool> BEDPKXGURNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly MultiValueConfigProperty<bool>? XIAOFJPJNRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly MultiValueConfigProperty<bool> ZZSMYJSTZPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly MultiValueConfigProperty<bool> EUCSIQNYSFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly MultiValueConfigProperty<bool>? UGYLVQGCIWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly MultiValueConfigProperty<float>? QVFQWZAOXXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly bool XSNBSMMPJOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly MultiValueConfigProperty<int> WFHJJQTNVOU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool GAPWOEDTAQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9B52C60", Offset = "0x9B51660", VA = "0x189B52C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool IQMDMHBNFUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9B52D20", Offset = "0x9B51720", VA = "0x189B52D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B52CB0", Offset = "0x9B516B0", VA = "0x189B52CB0")]
		private static string IVUHMADVHVL(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9B53800", Offset = "0x9B52200", VA = "0x189B53800")]
		public QGEZPSAHVWE(MultiValueConfigProperty<string> instructions, int a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<VoiceOption> c, MultiValueConfigProperty<bool>? d, MultiValueConfigProperty<string> useContext, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, string aiSettingsInfoText, MultiValueConfigProperty<bool>? g, MultiValueConfigProperty<bool>[] functionEnablements, IReadOnlyList<string> functionEnablementNames, IReadOnlyList<string> functionEnablementDescriptions, IReadOnlyList<bool> functionEnablementVisibilities, ConfigProperty<int[]>? circuitsFunctionEnablements, Func<IEnumerable<int>> getAllCircuitsFunctionIds, Func<int, bool> getCircuitsFunctionExists, Func<int, string?> getCircuitsFunctionName, Func<int, string?> getCircuitsFunctionInvalidReason, string useSpatialAudioLabel, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<RolloffCurve> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool>? n, MultiValueConfigProperty<float>? o, bool p, MultiValueConfigProperty<int> q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B52DE0", Offset = "0x9B517E0", VA = "0x189B52DE0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class MGGYSHLFSGI : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public MGGYSHLFSGI TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A1C0", Offset = "0x9B58BC0", VA = "0x189B5A1C0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly MultiValueConfigProperty<bool> LJGSOYBKTLP;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public MGGYSHLFSGI(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EAB0", Offset = "0x9B4D4B0", VA = "0x189B4EAB0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class GNBSSDXUCTJ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public GNBSSDXUCTJ TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A5E0", Offset = "0x9B58FE0", VA = "0x189B5A5E0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly MultiValueConfigProperty<bool> AQDRWQETKGF;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public GNBSSDXUCTJ(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B45310", Offset = "0x9B43D10", VA = "0x189B45310", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class RJZAMMEEOAT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly string OAVJQRMKHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly MultiValueConfigProperty<bool> AVGWSHRJFDK;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B54B30", Offset = "0x9B53530", VA = "0x189B54B30")]
		public RJZAMMEEOAT(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B54A10", Offset = "0x9B53410", VA = "0x189B54A10", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ACPOGSBXNSC : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public ACPOGSBXNSC TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B49440", Offset = "0x9B47E40", VA = "0x189B49440")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly MultiValueConfigProperty<bool> IBMYEPFNKVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly MultiValueConfigProperty<bool> YXJHFUTJUCZ;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D940", Offset = "0x9B3C340", VA = "0x189B3D940")]
		public ACPOGSBXNSC(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D800", Offset = "0x9B3C200", VA = "0x189B3D800", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class KRWVAIEYRKB : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public KRWVAIEYRKB TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public Func<bool> XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9B43B30", Offset = "0x9B42530", VA = "0x189B43B30")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9B44000", Offset = "0x9B42A00", VA = "0x189B44000")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9B443D0", Offset = "0x9B42DD0", VA = "0x189B443D0")]
			internal bool EMDWKHEZZNI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly HKSCCEYWDRV WBTHIJRKDXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly Func<bool> LFFRWKSMCBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly Action GQZWXUCHKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly bool IFQGAPZISHR;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BA80", Offset = "0x9B4A480", VA = "0x189B4BA80")]
		public KRWVAIEYRKB(int a, HKSCCEYWDRV b, Action c, Func<bool> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B940", Offset = "0x9B4A340", VA = "0x189B4B940", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class XLYMFJBOSJP : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class PAZKHGEBKDW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public readonly MultiValueConfigProperty<float> BZTUEHWYWWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public readonly MultiValueConfigProperty<float> OQEAJFJHISQ;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D940", Offset = "0x9B3C340", VA = "0x189B3D940")]
			public PAZKHGEBKDW(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public sealed class LFFELNGYDRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public readonly MultiValueConfigProperty<float> JAJXLUVOZNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public readonly MultiValueConfigProperty<float> CNRQDFVVZKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public readonly MultiValueConfigProperty<bool> UDRFFMWYJLA;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9B4BE30", Offset = "0x9B4A830", VA = "0x189B4BE30")]
			public LFFELNGYDRW(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class GGBMHCJGDFV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public readonly MultiValueConfigProperty<float> RYYPHHYVYVM;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
			public GGBMHCJGDFV(MultiValueConfigProperty<float> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public XLYMFJBOSJP TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9B4FCF0", Offset = "0x9B4E6F0", VA = "0x189B4FCF0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x9B50C90", Offset = "0x9B4F690", VA = "0x189B50C90")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9B51540", Offset = "0x9B4FF40", VA = "0x189B51540")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x9B517A0", Offset = "0x9B501A0", VA = "0x189B517A0")]
			internal void EMJDHNYXIYR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly MultiValueConfigProperty<int> HZIKRKGWVMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly MultiValueConfigProperty<int> XDTQBVKMSBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly PAZKHGEBKDW QSXAPPWYCZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly LFFELNGYDRW JTKKNYPEWFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly GGBMHCJGDFV KXVHKMGDKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MultiValueConfigProperty<bool> PSZKFWCMDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly QKNPTJSAIIL JWLVTCKTZSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly QKNPTJSAIIL TOIABRRSPWP;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B5C780", Offset = "0x9B5B180", VA = "0x189B5C780")]
		public XLYMFJBOSJP(MultiValueConfigProperty<float> vehicleMass, MultiValueConfigProperty<int> boostFuelCapacity, PAZKHGEBKDW a, LFFELNGYDRW b, GGBMHCJGDFV c, MultiValueConfigProperty<bool> canFrontWheelsSteer, QKNPTJSAIIL d, QKNPTJSAIIL e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B5C480", Offset = "0x9B5AE80", VA = "0x189B5C480", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class QKNPTJSAIIL : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MultiValueConfigProperty<bool> IJEOWZJBJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly MultiValueConfigProperty<bool> PUYFXRFYIZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly MultiValueConfigProperty<float> FXGLLBUGLXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly MultiValueConfigProperty<float> CQIMTPHYFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly MultiValueConfigProperty<float> LOHXEUOOEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private readonly MultiValueConfigProperty<float> WTVADXAAKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private readonly MultiValueConfigProperty<float> LKYIFVQVDZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly MultiValueConfigProperty<float> KZDFGZJJYJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly MultiValueConfigProperty<float> ZFLWDXWLJWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly MultiValueConfigProperty<float> BRLEZRDWONW;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B546B0", Offset = "0x9B530B0", VA = "0x189B546B0")]
		public QKNPTJSAIIL(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B53C30", Offset = "0x9B52630", VA = "0x189B53C30", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class OWOVZRTVHSR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public OWOVZRTVHSR TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9B47530", Offset = "0x9B45F30", VA = "0x189B47530")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly MultiValueConfigProperty<float> RGYEVCMPUVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly MultiValueConfigProperty<float> HCIMZTKAYHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly MultiValueConfigProperty<float> ZUAAVOWABQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly MultiValueConfigProperty<float> UDMASZRRRPF;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B4FB00", Offset = "0x9B4E500", VA = "0x189B4FB00")]
		public OWOVZRTVHSR(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F9C0", Offset = "0x9B4E3C0", VA = "0x189B4F9C0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class FQQCJNHZSGQ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly MultiValueConfigProperty<bool> PSBDPJGMGIU;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public FQQCJNHZSGQ(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B449B0", Offset = "0x9B433B0", VA = "0x189B449B0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class QCNNCPEDJWR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public QCNNCPEDJWR TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B592F0", Offset = "0x9B57CF0", VA = "0x189B592F0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B597A0", Offset = "0x9B581A0", VA = "0x189B597A0")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly QYMRNNDKUIM KMIYXRSSMVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly FQQCJNHZSGQ LJQGHZOZRFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly MultiValueConfigProperty<bool> JCDPMGQWNEK;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B52BE0", Offset = "0x9B515E0", VA = "0x189B52BE0")]
		public QCNNCPEDJWR(QYMRNNDKUIM a, FQQCJNHZSGQ b, MultiValueConfigProperty<bool> hideProjector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B52A10", Offset = "0x9B51410", VA = "0x189B52A10", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class WDOCRUMMWXW : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public WDOCRUMMWXW TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B49950", Offset = "0x9B48350", VA = "0x189B49950")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9B49A70", Offset = "0x9B48470", VA = "0x189B49A70")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly MultiValueConfigProperty<bool> XEVXUQLCMKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Option<bool> WTQIETYFKNX;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B58B90", Offset = "0x9B57590", VA = "0x189B58B90")]
		public WDOCRUMMWXW(Option<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B58A60", Offset = "0x9B57460", VA = "0x189B58A60", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class NVAUWBVUYIO : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public NVAUWBVUYIO TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9B59130", Offset = "0x9B57B30", VA = "0x189B59130")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly IReadOnlyDictionary<PhysicsMode, string> RIIQQWCTOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly MultiValueConfigProperty<PhysicsMode> VCTFHTSFJSA;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F710", Offset = "0x9B4E110", VA = "0x189B4F710")]
		public NVAUWBVUYIO(int a, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F4B0", Offset = "0x9B4DEB0", VA = "0x189B4F4B0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class PDEOOBFVSUM : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public PDEOOBFVSUM TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A430", Offset = "0x9B58E30", VA = "0x189B5A430")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly MultiValueConfigProperty<bool> WQBLEMQSGMT;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public PDEOOBFVSUM(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B4FBB0", Offset = "0x9B4E5B0", VA = "0x189B4FBB0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class QYMRNNDKUIM : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly string ZRSVTZZSBRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly Action FLMBUZXRUMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public readonly Func<Option<bool>> MTOCHCDYJDN;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xE09060", Offset = "0xE07A60", VA = "0x180E09060")]
		public QYMRNNDKUIM(string a, Action b, Func<Option<bool>> hasRecordableData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9B548C0", Offset = "0x9B532C0", VA = "0x189B548C0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B54860", Offset = "0x9B53260", VA = "0x189B54860")]
		[CompilerGenerated]
		private bool NJAHPZVLIAT()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class RoomKeyConfig : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public RoomKeyConfig TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9B496C0", Offset = "0x9B480C0", VA = "0x189B496C0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9B49BC0", Offset = "0x9B485C0", VA = "0x189B49BC0")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly EAFECDIWWMU KFHZTBFYIWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly Func<InventionPermission> XXWQNXMAIWV;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		public RoomKeyConfig(EAFECDIWWMU roomKeyOptions, Func<InventionPermission> getLowestInventionPermission)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B56820", Offset = "0x9B55220", VA = "0x189B56820", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class EAFECDIWWMU : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public EAFECDIWWMU TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F680", Offset = "0x9B3E080", VA = "0x189B3F680")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9B41880", Offset = "0x9B40280", VA = "0x189B41880")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public readonly bool UXNBQXUWTBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly string SQGNTXXGKYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Func<bool> HGWTQARVIXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly Func<bool> LPHTPDXUHVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly Action? VFYBICYBYLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly MultiValueConfigProperty<Guid> AYRMFHDKOHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly Action<UOJDHDCBUAJ.RoomKeyPickerData> AFUDBVLHXMB;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9B42CC0", Offset = "0x9B416C0", VA = "0x189B42CC0")]
		public EAFECDIWWMU(Option<bool> isTrialInvention, Func<bool> a, Func<bool> b, Action? onCreateKeyClick, MultiValueConfigProperty<Guid> equipLockKeyId, Action<UOJDHDCBUAJ.RoomKeyPickerData> c, [Optional] string? lockLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9B42BB0", Offset = "0x9B415B0", VA = "0x189B42BB0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class WGYIDMSIFZL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public readonly IReadOnlyList<(Guid, string)> QINWPUYOQGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public readonly ConfigProperty<IReadOnlyCollection<Guid>> CLXNOASTQRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public readonly Action<UOJDHDCBUAJ.MultiTogglePickerData> XGWPNXOZDSB;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9B58FA0", Offset = "0x9B579A0", VA = "0x189B58FA0")]
		public WGYIDMSIFZL(IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<UOJDHDCBUAJ.MultiTogglePickerData> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class YTRIQOHKBAD : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public YTRIQOHKBAD TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9B42DC0", Offset = "0x9B417C0", VA = "0x189B42DC0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly MultiValueConfigProperty<int> ZRMONEZBKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly MultiValueConfigProperty<int> PMVTFZYDBYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly MultiValueConfigProperty<int> PMQMITEFSNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly MultiValueConfigProperty<int> PMLFLMKIJBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly MultiValueConfigProperty<string> LCPLETBNLCA;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DBE0", Offset = "0x9B5C5E0", VA = "0x189B5DBE0")]
		public YTRIQOHKBAD(MultiValueConfigProperty<int> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<int> d, MultiValueConfigProperty<string> stateName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DAA0", Offset = "0x9B5C4A0", VA = "0x189B5DAA0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class PLWFLUJODJI : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public PLWFLUJODJI TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B40F20", Offset = "0x9B3F920", VA = "0x189B40F20")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly MultiValueConfigProperty<float> LKSBQFJBJZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly MultiValueConfigProperty<bool> PZDXPHOYHDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly MultiValueConfigProperty<TexturedQuadMaterialType> QSFYDFSFXFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly CNUHDIQJNBT? ZHYWLJUTCAG;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly IReadOnlyList<TexturedQuadMaterialType> MMFTLQBXBLF;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9B52960", Offset = "0x9B51360", VA = "0x189B52960")]
		public PLWFLUJODJI(MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<TexturedQuadMaterialType> c, CNUHDIQJNBT? syncComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9B52680", Offset = "0x9B51080", VA = "0x189B52680", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class ABAOGRIIIPD : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public ABAOGRIIIPD TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A070", Offset = "0x9B58A70", VA = "0x189B5A070")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly MultiValueConfigProperty<bool> XMOITMQTIYP;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public ABAOGRIIIPD(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D680", Offset = "0x9B3C080", VA = "0x189B3D680", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class YAFTAPHQGWH : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class KNTZTHNOLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public YAFTAPHQGWH TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNTZTHNOLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9B49C10", Offset = "0x9B48610", VA = "0x189B49C10")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static readonly IReadOnlyDictionary<TrailWidthCurveTypes, string> TBWJDPVMGUY;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly IReadOnlyDictionary<TrailGradientTypes, string> VYZRDBOMDGY;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private static readonly IReadOnlyDictionary<TrailMaterialTypes, string> GZIWQJJKTUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly MultiValueConfigProperty<bool> CEXVUXXJUWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly MultiValueConfigProperty<bool> CMNITBTGAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly MultiValueConfigProperty<float> UJHWKIEEUJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly MultiValueConfigProperty<float> UCUMZUZMVGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly MultiValueConfigProperty<float> XOSNCTDPVMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly MultiValueConfigProperty<float> TLEGZEROOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly MultiValueConfigProperty<TrailWidthCurveTypes> AFTJAHKGUBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly MultiValueConfigProperty<TrailGradientTypes> OIYXLBGQSCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly MultiValueConfigProperty<TrailMaterialTypes> VCAPZCRWJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly NVMCMQCOOAE? CSJGYHSQUHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CNUHDIQJNBT GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5D7A0", Offset = "0x9B5C1A0", VA = "0x189B5D7A0")]
		public YAFTAPHQGWH(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<TrailWidthCurveTypes> g, MultiValueConfigProperty<TrailGradientTypes> h, MultiValueConfigProperty<TrailMaterialTypes> i, NVMCMQCOOAE? colorableOptions, CNUHDIQJNBT syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5D220", Offset = "0x9B5BC20", VA = "0x189B5D220", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class HTUKWFYTSRG : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class XKNHXSJBZBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public HTUKWFYTSRG TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public (Color32 x, Color32 y, Color32 z) LQBRJQEJIEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Func<bool> XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Func<bool> XZSOTIOAZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Action YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Action YADCNWBVSFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XKNHXSJBZBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A870", Offset = "0x9B59270", VA = "0x189B5A870")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9B5AAB0", Offset = "0x9B594B0", VA = "0x189B5AAB0")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9B5BDD0", Offset = "0x9B5A7D0", VA = "0x189B5BDD0")]
			internal bool EMOKEUSUSKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x9B5B360", Offset = "0x9B59D60", VA = "0x189B5B360")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x9B5BE10", Offset = "0x9B5A810", VA = "0x189B5BE10")]
			internal bool EMTRCBMSBVJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9B5BC60", Offset = "0x9B5A660", VA = "0x189B5BC60")]
			internal void EMJDHNYXIYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9B5BE50", Offset = "0x9B5A850", VA = "0x189B5BE50")]
			internal void EMYXZIGPLGS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C2F0", Offset = "0x9B5ACF0", VA = "0x189B5C2F0")]
			internal void ENEEWPAMUSB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly Func<bool>? XYEOHCCTTGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly Func<bool> ERSHYJCGGSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly Func<bool> JWGITPBMGXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly MultiValueConfigProperty<float> ZBCADERNCEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private readonly MultiValueConfigProperty<float> ZAWTFXXPSTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private readonly MultiValueConfigProperty<float> ZBMNXSFHVBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private readonly MultiValueConfigProperty<float> XSYSCUETSAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly MultiValueConfigProperty<float> XTDZAAYRBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly MultiValueConfigProperty<float> XSOEIGQYZDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly Func<bool> WVFEBETQILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly Func<bool> PHNUEBRRCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly MultiValueConfigProperty<float> BGHBROUTNSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly MultiValueConfigProperty<float> BGMIOVOQXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly MultiValueConfigProperty<float> BGRPMCIOGPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly MultiValueConfigProperty<float> XBPHBVKPEVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly MultiValueConfigProperty<float> XBKAEOQRVKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly MultiValueConfigProperty<float> XBETHHWULYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Func<bool> GNCXMPORBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Func<bool> UURRTMPJJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly MultiValueConfigProperty<float> MMFIMQFTSRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly MultiValueConfigProperty<float> MMKPJWZRCDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly MultiValueConfigProperty<float> MMPWHDTOLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly MultiValueConfigProperty<float> RKNEPKBDFVS;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B46AD0", Offset = "0x9B454D0", VA = "0x189B46AD0")]
		public HTUKWFYTSRG(Func<bool> supportsTranslation, Func<bool> isWorldPositionVisible, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, Func<bool> supportsRotation, Func<bool> isWorldRotationVisible, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j, MultiValueConfigProperty<float> k, MultiValueConfigProperty<float> l, Func<bool> supportsScaling, Func<bool> supportsDeformation, MultiValueConfigProperty<float> m, MultiValueConfigProperty<float> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, [Optional] Func<bool>? isFoldoutVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B46920", Offset = "0x9B45320", VA = "0x189B46920", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class TATDOCILSHV : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public TATDOCILSHV TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9B47A80", Offset = "0x9B46480", VA = "0x189B47A80")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static readonly IReadOnlyDictionary<GrabberAttachmentMode, string> XMMOVJOAPKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly MultiValueConfigProperty<GrabberAttachmentMode> ONYEMOFEFSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private readonly MultiValueConfigProperty<bool> XFUXFSPLZWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private readonly CNUHDIQJNBT GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9B56BF0", Offset = "0x9B555F0", VA = "0x189B56BF0")]
		public TATDOCILSHV(MultiValueConfigProperty<GrabberAttachmentMode> a, MultiValueConfigProperty<bool> b, CNUHDIQJNBT syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B569A0", Offset = "0x9B553A0", VA = "0x189B569A0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class LXDGAZAZEZX : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly IEnumerable<IDXZRZUGEFR> MKXAOGPOHJL;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public LXDGAZAZEZX(IEnumerable<IDXZRZUGEFR> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E860", Offset = "0x9B4D260", VA = "0x189B4E860", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class CMCTLNUJTGK : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public CMCTLNUJTGK TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9B43C40", Offset = "0x9B42640", VA = "0x189B43C40")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9B44110", Offset = "0x9B42B10", VA = "0x189B44110")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9B44270", Offset = "0x9B42C70", VA = "0x189B44270")]
			internal void EMDWKHEZZNI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public readonly Option<bool> ZRIDDVNVRBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private readonly MultiValueConfigProperty<float> WODUHUPYCJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private readonly MultiValueConfigProperty<bool> ZOOMDYOJFEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private readonly MultiValueConfigProperty<bool> SSFOZRESREQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly MultiValueConfigProperty<bool> TKYDBVXLHIL;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E850", Offset = "0x9B3D250", VA = "0x189B3E850")]
		public CMCTLNUJTGK(Option<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E630", Offset = "0x9B3D030", VA = "0x189B3E630", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class YUSVGCCCEXH : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public YUSVGCCCEXH TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9B3FD70", Offset = "0x9B3E770", VA = "0x189B3FD70")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static readonly Dictionary<int, string> EPNHVVWAVRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly MultiValueConfigProperty<int> TWJEJPQSVNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private readonly MultiValueConfigProperty<float> JKDVYKQRATM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private readonly MultiValueConfigProperty<bool> MDFDWTGYJCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly MultiValueConfigProperty<bool> NBXEBXGRUON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly MultiValueConfigProperty<bool> MKWEOIVMVYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly MultiValueConfigProperty<int> JWSOZRGVUMC;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DEF0", Offset = "0x9B5C8F0", VA = "0x189B5DEF0")]
		public YUSVGCCCEXH(MultiValueConfigProperty<int> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DCC0", Offset = "0x9B5C6C0", VA = "0x189B5DCC0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class LCYWJRZNXUQ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public LCYWJRZNXUQ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9B54B90", Offset = "0x9B53590", VA = "0x189B54B90")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9B564E0", Offset = "0x9B54EE0", VA = "0x189B564E0")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly Dictionary<int, string> EPNHVVWAVRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly Action? RFABQRHZOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly int ZEWMIHNULIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly MultiValueConfigProperty<int> TWJEJPQSVNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly MultiValueConfigProperty<float> WNPRRDMRVVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private readonly MultiValueConfigProperty<bool> SLSTHDBTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly MultiValueConfigProperty<bool> MKWEOIVMVYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly MultiValueConfigProperty<int> JWSOZRGVUMC;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BD30", Offset = "0x9B4A730", VA = "0x189B4BD30")]
		public LCYWJRZNXUQ(Action? openAnimationControls, int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BB00", Offset = "0x9B4A500", VA = "0x189B4BB00", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class RUCENNGUWJL : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public RUCENNGUWJL TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9B59690", Offset = "0x9B58090", VA = "0x189B59690")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x9B59980", Offset = "0x9B58380", VA = "0x189B59980")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly CMCTLNUJTGK XJTEBEURGBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly MultiValueConfigProperty<float> JLXNZRAUXLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private readonly Option<UnityEngine.Vector2> ZWFJIYTLQSR;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9B567A0", Offset = "0x9B551A0", VA = "0x189B567A0")]
		public RUCENNGUWJL(CMCTLNUJTGK acceleratedMovementOptions, MultiValueConfigProperty<float> a, Option<UnityEngine.Vector2> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9B56660", Offset = "0x9B55060", VA = "0x189B56660", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class HPSDKOWPGPT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public HPSDKOWPGPT TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F870", Offset = "0x9B3E270", VA = "0x189B3F870")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x9B414D0", Offset = "0x9B3FED0", VA = "0x189B414D0")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9B418F0", Offset = "0x9B402F0", VA = "0x189B418F0")]
			internal void EMDWKHEZZNI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private readonly CMCTLNUJTGK XJTEBEURGBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly MultiValueConfigProperty<float> JLXNZRAUXLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private readonly MultiValueConfigProperty<float> ZIPQDZXTAZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private readonly MultiValueConfigProperty<float> BWZYFQOHOMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private readonly MultiValueConfigProperty<float> YDACGUKEIDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private readonly Option<UnityEngine.Vector2> ZWFJIYTLQSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private readonly Option<float> CWTCHWUXPLO;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9B45C20", Offset = "0x9B44620", VA = "0x189B45C20")]
		public HPSDKOWPGPT(CMCTLNUJTGK acceleratedMovementOptions, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, Option<UnityEngine.Vector2> c, MultiValueConfigProperty<float> d, Option<float> e, MultiValueConfigProperty<float> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9B45AE0", Offset = "0x9B444E0", VA = "0x189B45AE0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class DNVTOBIEIJD : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public DNVTOBIEIJD TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A580", Offset = "0x9B58F80", VA = "0x189B5A580")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private readonly CMCTLNUJTGK XJTEBEURGBY;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public DNVTOBIEIJD(CMCTLNUJTGK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9B42A70", Offset = "0x9B41470", VA = "0x189B42A70", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class MTISZMVKDJT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public MTISZMVKDJT TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9B43620", Offset = "0x9B42020", VA = "0x189B43620")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly Option<float> XPJCIIBJVZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private readonly MultiValueConfigProperty<float> DXNQAETMYBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private readonly MultiValueConfigProperty<float> GTQCGWBVNGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private readonly MultiValueConfigProperty<float> BPRUTKEEWRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private readonly CMCTLNUJTGK XJTEBEURGBY;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9B4ED50", Offset = "0x9B4D750", VA = "0x189B4ED50")]
		public MTISZMVKDJT(Option<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, CMCTLNUJTGK acceleratedMovementOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EBF0", Offset = "0x9B4D5F0", VA = "0x189B4EBF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class FSMFGFKOHNU : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class ACWIPAVUBWN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public FSMFGFKOHNU TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACWIPAVUBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D9B0", Offset = "0x9B3C3B0", VA = "0x189B3D9B0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly Dictionary<GlassPaneShapeType, string> ULCIUHGYQSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private readonly MultiValueConfigProperty<float> SKZPYYKXDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly Func<bool> NNRYRCFTLRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly MultiValueConfigProperty<GlassPaneShapeType> RZRZTMBSBMX;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9B44D20", Offset = "0x9B43720", VA = "0x189B44D20")]
		public FSMFGFKOHNU(MultiValueConfigProperty<float> a, Func<bool> isAllConfigurableShapes, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9B44AF0", Offset = "0x9B434F0", VA = "0x189B44AF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class AZIAJDWXVWW : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public AZIAJDWXVWW TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A3D0", Offset = "0x9B58DD0", VA = "0x189B5A3D0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private readonly HKSCCEYWDRV IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public AZIAJDWXVWW(HKSCCEYWDRV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9B3DF80", Offset = "0x9B3C980", VA = "0x189B3DF80", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class HSUPIDFGGOL
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public static readonly IReadOnlyDictionary<InteractionFilterMode, string> WHWICTLQISU;
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class WFTBWTKYZSF : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public WFTBWTKYZSF TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9B48370", Offset = "0x9B46D70", VA = "0x189B48370")]
			internal bool GKWMJREFLQG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9B48030", Offset = "0x9B46A30", VA = "0x189B48030")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9B48170", Offset = "0x9B46B70", VA = "0x189B48170")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9B482B0", Offset = "0x9B46CB0", VA = "0x189B482B0")]
			internal void EMJDHNYXIYR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private readonly MultiValueConfigProperty<bool> ZGOBNNMFICR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> HXADKKRYTBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private readonly WGYIDMSIFZL? QGSPWRXYYLZ;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9B58F10", Offset = "0x9B57910", VA = "0x189B58F10")]
		public WFTBWTKYZSF(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<InteractionFilterMode> c, WGYIDMSIFZL? rolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B58BE0", Offset = "0x9B575E0", VA = "0x189B58BE0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class WMYSDSBPPRQ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public WMYSDSBPPRQ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9B483E0", Offset = "0x9B46DE0", VA = "0x189B483E0")]
			internal bool GKWMJREFLQG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9B47FD0", Offset = "0x9B469D0", VA = "0x189B47FD0")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private readonly string OAVJQRMKHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private readonly MultiValueConfigProperty<bool> ZGOBNNMFICR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> HXADKKRYTBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private readonly QXEYZOOFTMZ? GQAUIJCTAYL;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B59F70", Offset = "0x9B58970", VA = "0x189B59F70")]
		public WMYSDSBPPRQ(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<InteractionFilterMode> b, QXEYZOOFTMZ tagsOptions, string primaryLabel = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9B59BE0", Offset = "0x9B585E0", VA = "0x189B59BE0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class NTURJFBPDEP : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public NTURJFBPDEP TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9B590D0", Offset = "0x9B57AD0", VA = "0x189B590D0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private readonly string OAVJQRMKHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> HXADKKRYTBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private readonly QXEYZOOFTMZ? GQAUIJCTAYL;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F430", Offset = "0x9B4DE30", VA = "0x189B4F430")]
		public NTURJFBPDEP(MultiValueConfigProperty<InteractionFilterMode> filterMode, QXEYZOOFTMZ a, string b = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F1D0", Offset = "0x9B4DBD0", VA = "0x189B4F1D0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface UOJDHDCBUAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public enum ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			Standard,
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			Alphanumeric
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public readonly struct ColorPickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB20", Offset = "0xF5D520", VA = "0x180F5EB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Action<int> ColorSetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool AllowCustomColors
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public bool AllowDefaultColor
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x128F670", Offset = "0x128E070", VA = "0x18128F670")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x13FB2D0", Offset = "0x13F9CD0", VA = "0x1813FB2D0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public readonly struct MaterialPickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public Func<int> MaterialGetter
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB20", Offset = "0xF5D520", VA = "0x180F5EB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public Action<int> MaterialSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool AllowDefaultMaterial
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xD159F0", Offset = "0xD143F0", VA = "0x180D159F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0xD15880", Offset = "0xD14280", VA = "0x180D15880")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool ForceTransparentQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x1623EE0", Offset = "0x16228E0", VA = "0x181623EE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1623ED0", Offset = "0x16228D0", VA = "0x181623ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool CameraLit
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x1BE8DB0", Offset = "0x1BE77B0", VA = "0x181BE8DB0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x1E2A910", Offset = "0x1E29310", VA = "0x181E2A910")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		public readonly struct RoomRolePickerData
		{
			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public Func<Guid> RoleGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Action<Guid> RoleSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB20", Offset = "0xF5D520", VA = "0x180F5EB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public readonly struct RoomKeyPickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public Func<Guid> KeyGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB20", Offset = "0xF5D520", VA = "0x180F5EB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public Action<Guid> KeySetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public readonly struct MultiTogglePickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public Func<IReadOnlyCollection<int>> GetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB20", Offset = "0xF5D520", VA = "0x180F5EB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public Action<IReadOnlyCollection<int>> SetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Func<IReadOnlyList<string>> GetValueNames
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class HBKYGTEBNBS<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public IReadOnlyDictionary<a, string> AKQLLCBYVQW;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public HBKYGTEBNBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6510450", Offset = "0x650EE50", VA = "0x186510450")]
			internal string OHMKYFNRRHD(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class MZJIXMNXOSX<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			public Func<a, string> WBDRZNEUCIF;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MZJIXMNXOSX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F45170", Offset = "0x6F43B70", VA = "0x186F45170")]
			internal string OHMKYFNRRHD(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class CKPODCZNFMK<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public IReadOnlyList<(a, string)> AKQLLCBYVQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Dictionary<a, int> RBAMISLCJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Func<a, int> YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Func<int, a> YADCNWBVSFA;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CKPODCZNFMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x50A16F0", Offset = "0x50A00F0", VA = "0x1850A16F0")]
			internal IReadOnlyList<string> BGJXLZUYLVO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x50A1BC0", Offset = "0x50A05C0", VA = "0x1850A1BC0")]
			internal IReadOnlyCollection<int> BGPEJGOVVGX(IReadOnlyCollection<a> values)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x50A1140", Offset = "0x509FB40", VA = "0x1850A1140")]
			internal int BFOVWYTJACE(a a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x50A1510", Offset = "0x509FF10", VA = "0x1850A1510")]
			internal IReadOnlyCollection<a> BFZJRMHDSYW(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x50A1440", Offset = "0x509FE40", VA = "0x1850A1440")]
			internal a BFUCUFNGJNN(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class XYEKQIUPMDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public IReadOnlyList<(int, string)> AKQLLCBYVQW;

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XYEKQIUPMDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CE10", Offset = "0x9B5B810", VA = "0x189B5CE10")]
			internal IReadOnlyList<string> BVORDWYOBHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CF40", Offset = "0x9B5B940", VA = "0x189B5CF40")]
			internal IReadOnlyCollection<int> BVTYBDSLKSV(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9B5D130", Offset = "0x9B5BB30", VA = "0x189B5D130")]
			internal int BVZEYKMIUEE(IReadOnlyCollection<int> a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class XYJRNPOMVOR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public int BSLJFOZKPBT;

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XYJRNPOMVOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9B5D210", Offset = "0x9B5BC10", VA = "0x189B5D210")]
			internal bool BWJSSYADNAW(IndexValuePair<(int, string)> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class XXTWVVGUTGQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public int BSLJFOZKPBT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public XYEKQIUPMDI UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XXTWVVGUTGQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CD20", Offset = "0x9B5B720", VA = "0x189B5CD20")]
			internal void BWUGNLNYFXO(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class CRLCKBCPMKT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public IReadOnlyList<(Guid, string)> AKQLLCBYVQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public Dictionary<Guid, int> RBAMISLCJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public Func<Guid, int> YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public Func<int, Guid> YADCNWBVSFA;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CRLCKBCPMKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9B3EB10", Offset = "0x9B3D510", VA = "0x189B3EB10")]
			internal IReadOnlyList<string> MNABZUPEWHO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B3EC40", Offset = "0x9B3D640", VA = "0x189B3EC40")]
			internal IReadOnlyCollection<int> MNFIXBJCFSX(IReadOnlyCollection<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B3E910", Offset = "0x9B3D310", VA = "0x189B3E910")]
			internal int MMFAKTNPKOE(Guid a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x9B3EA40", Offset = "0x9B3D440", VA = "0x189B3EA40")]
			internal IReadOnlyCollection<Guid> MMPOFHBKDKW(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9B3E970", Offset = "0x9B3D370", VA = "0x189B3E970")]
			internal Guid MMKHIAHMTZN(int a)
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9B57B30", Offset = "0x9B56530", VA = "0x189B57B30", Slot = "0")]
		UOJDHDCBUAJ EUXURFPUHVQ(bool a, Action b, [Optional] Action? falseAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9B57A80", Offset = "0x9B56480", VA = "0x189B57A80", Slot = "1")]
		UOJDHDCBUAJ Add(HKSCCEYWDRV? provider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UOJDHDCBUAJ NGQMMNBJCAP();

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UOJDHDCBUAJ FNGLIROEOAO(string a, int b, Action c, [Optional] Func<bool>? isVisibleGetter, bool d = true, InventionPermission e = InventionPermission.EditAndSave, string f = "");

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UOJDHDCBUAJ? MWRDIFTMISJ(string primaryLabel, MultiValueConfigProperty<string> property, int a = 1000, [Optional] string? b, [Optional] Func<bool>? c, ContentType d = ContentType.Standard, [Optional] string? e);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		UOJDHDCBUAJ OUTANPTEGTI(string a, MultiValueConfigProperty<string> property, int b = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] string? infoText);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		UOJDHDCBUAJ FRSFGAWOPEW(string a, MultiValueConfigProperty<int> property, [Optional] int? b, [Optional] int? c, [Optional] string? unitLabel, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		UOJDHDCBUAJ? UJZFMFSPOHO(string primaryLabel, float a, float b, MultiValueConfigProperty<float> property, int c = 2, [Optional] string? d, [Optional] string? e, [Optional] Func<bool>? f, [Optional] string? g);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		UOJDHDCBUAJ? XEQJFONZVYH(string primaryLabel, MultiValueConfigProperty<float> property, [Optional] Func<bool>? a, [Optional] Func<bool>? b, [Optional] Color? c, [Optional] float? d, [Optional] float? e, bool f = false, [Optional] string? g, [Optional] string? h);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B58340", Offset = "0x9B56D40", VA = "0x189B58340", Slot = "9")]
		UOJDHDCBUAJ ZXULVSBEWZM(string primaryLabel, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, [Optional] (Color x, Color y, Color z)? bgColors, [Optional] Func<bool>? isVisibleGetter, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		UOJDHDCBUAJ? PLOYOVXVVZB(string primaryLabel, Func<bool> isActiveGetter, Action<bool> isActiveSetter, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e, [Optional] Func<bool>? f, [Optional] Func<string>? warningTextGetter, [Optional] Func<string>? warningTitleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "11")]
		UOJDHDCBUAJ? SINRDPCABHT(string primaryLabel, MultiValueConfigProperty<bool> property, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x40A21F0", Offset = "0x40A0BF0", VA = "0x1840A21F0", Slot = "12")]
		UOJDHDCBUAJ WRSPUCOUFJS<a>(string a, MultiValueConfigProperty<a> property, IReadOnlyDictionary<a, string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool c = true, bool d = false) where a : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x40A2530", Offset = "0x40A0F30", VA = "0x1840A2530", Slot = "13")]
		UOJDHDCBUAJ WRSPUCOUFJS<b>(string a, MultiValueConfigProperty<b> property, IReadOnlyList<b> b, Func<b, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false) where b : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "14")]
		UOJDHDCBUAJ WRSPUCOUFJS(string a, MultiValueConfigProperty<object> property, IReadOnlyList<object> b, Func<object, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "15")]
		UOJDHDCBUAJ? WDTXZEPFBGT(Action panelAction, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "16")]
		UOJDHDCBUAJ MTLUKLIFENJ(string a, ConfigProperty<IReadOnlyList<string>> persistentProperty, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeProperty, [Optional] string? secondaryLabel, [Optional] Func<string, bool>? tagValidator, int b = 1000, [Optional] Func<bool>? isModifiedGetter);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "17")]
		UOJDHDCBUAJ? KVZCQSHOSUJ(string primaryLabel, Action? a, [Optional] Func<bool>? b, [Optional] Func<bool>? c);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "18")]
		UOJDHDCBUAJ SOWCIMWJJIM(string a, string b, Action c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "19")]
		UOJDHDCBUAJ HZRDOZUUEOW(string a, ConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "20")]
		UOJDHDCBUAJ HZRDOZUUEOW(string a, MultiValueConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		UOJDHDCBUAJ NPNEHZRHXQG(string a, ConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		UOJDHDCBUAJ NPNEHZRHXQG(string a, MultiValueConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		UOJDHDCBUAJ XYHINVERBPO(string a, ConfigProperty<Guid> property, Action<RoomRolePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		UOJDHDCBUAJ LFNCUWWELDR(string a, MultiValueConfigProperty<Guid> property, Action<RoomKeyPickerData> b, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		UOJDHDCBUAJ TCIWBEJJBCQ(string a, Func<IReadOnlyList<string>> b, ConfigProperty<IReadOnlyCollection<int>> property, Action<MultiTogglePickerData> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x40A1830", Offset = "0x40A0230", VA = "0x1840A1830", Slot = "26")]
		UOJDHDCBUAJ TCIWBEJJBCQ<T>(string a, IReadOnlyList<(T, string)> items, ConfigProperty<IReadOnlyCollection<T>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9B57B80", Offset = "0x9B56580", VA = "0x189B57B80", Slot = "27")]
		UOJDHDCBUAJ FFHFXQRTASW(string a, IReadOnlyList<(int, string)> items, ConfigProperty<int> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9B57F50", Offset = "0x9B56950", VA = "0x189B57F50", Slot = "28")]
		UOJDHDCBUAJ XYHINVERBPO(string a, IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "29")]
		UOJDHDCBUAJ OITRTVXQHNZ(string a, [Optional] Func<bool>? isVisibleGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public interface HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UVMIXBFUUQC(UOJDHDCBUAJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class NGTGQTHVSPG : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public NGTGQTHVSPG TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9B3FB90", Offset = "0x9B3E590", VA = "0x189B3FB90")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly MultiValueConfigProperty<float> CNINVPWZTAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly System.Numerics.Vector2 ZJAGBXLRYCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private readonly MultiValueConfigProperty<float> VOBHZXSROJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly System.Numerics.Vector2 ZYUDCELANRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly DATFYFYKNNI ZRVRBGIIZYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly NVMCMQCOOAE? UVXTZZGONIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CNUHDIQJNBT AWVKRPQIWFX;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F110", Offset = "0x9B4DB10", VA = "0x189B4F110")]
		public NGTGQTHVSPG(MultiValueConfigProperty<float> a, System.Numerics.Vector2 b, MultiValueConfigProperty<float> c, System.Numerics.Vector2 d, DATFYFYKNNI sandboxDynamicLightOptions, NVMCMQCOOAE? sandboxColorableConfig, CNUHDIQJNBT syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EFD0", Offset = "0x9B4D9D0", VA = "0x189B4EFD0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class VTEVHDGDNJK : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public VTEVHDGDNJK TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A010", Offset = "0x9B58A10", VA = "0x189B5A010")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly DATFYFYKNNI IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public VTEVHDGDNJK(DATFYFYKNNI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B58920", Offset = "0x9B57320", VA = "0x189B58920", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class DATFYFYKNNI : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private readonly MultiValueConfigProperty<bool> NNKRIVIISZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private readonly MultiValueConfigProperty<float> DBAYEGEIXZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly System.Numerics.Vector2 RUYRUDSRAFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private readonly MultiValueConfigProperty<float> XDEOAQJDJRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private readonly System.Numerics.Vector2 PQHXTGXBHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private readonly MultiValueConfigProperty<float> HNKJRDGCNTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private readonly System.Numerics.Vector2 JXVWWYBRRUB;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B3F110", Offset = "0x9B3DB10", VA = "0x189B3F110")]
		public DATFYFYKNNI(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<float> d, System.Numerics.Vector2 e, MultiValueConfigProperty<float> f, System.Numerics.Vector2 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B3ED50", Offset = "0x9B3D750", VA = "0x189B3ED50", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B3F100", Offset = "0x9B3DB00", VA = "0x189B3F100")]
		[CompilerGenerated]
		private bool VLDWVZECOHR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B3F0E0", Offset = "0x9B3DAE0", VA = "0x189B3F0E0")]
		[CompilerGenerated]
		private bool VKYPYSKFEWI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class VGIPIHMERPD : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public VGIPIHMERPD TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x9B59020", Offset = "0x9B57A20", VA = "0x189B59020")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private readonly DATFYFYKNNI FGJURBBECSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly NVMCMQCOOAE? CSJGYHSQUHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private readonly CNUHDIQJNBT GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xE09060", Offset = "0xE07A60", VA = "0x180E09060")]
		public VGIPIHMERPD(DATFYFYKNNI a, NVMCMQCOOAE? colorableOptions, CNUHDIQJNBT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B587E0", Offset = "0x9B571E0", VA = "0x189B587E0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class WOAFKPEORSB : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public WOAFKPEORSB TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A370", Offset = "0x9B58D70", VA = "0x189B5A370")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private readonly MWRJRMXVWUZ IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public WOAFKPEORSB(MWRJRMXVWUZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B5A730", Offset = "0x9B59130", VA = "0x189B5A730", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class MWRJRMXVWUZ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private readonly MultiValueConfigProperty<float> CNINVPWZTAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private readonly System.Numerics.Vector2 ZJAGBXLRYCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private readonly DATFYFYKNNI FGJURBBECSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private readonly NVMCMQCOOAE? CSJGYHSQUHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private readonly CNUHDIQJNBT? GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EF30", Offset = "0x9B4D930", VA = "0x189B4EF30")]
		public MWRJRMXVWUZ(MultiValueConfigProperty<float> angle, System.Numerics.Vector2 a, DATFYFYKNNI dynamicLightOptions, NVMCMQCOOAE? b, CNUHDIQJNBT? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EE00", Offset = "0x9B4D800", VA = "0x189B4EE00", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class FTLDXWVUZGK : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public FTLDXWVUZGK TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x9B498D0", Offset = "0x9B482D0", VA = "0x189B498D0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private readonly MWRJRMXVWUZ FGJURBBECSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly RJZAMMEEOAT BZKCFSMBCLC;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		public FTLDXWVUZGK(MWRJRMXVWUZ a, RJZAMMEEOAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9B44F80", Offset = "0x9B43980", VA = "0x189B44F80", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class BFDYWPJXMRJ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public BFDYWPJXMRJ TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9B49720", Offset = "0x9B48120", VA = "0x189B49720")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private MultiValueConfigProperty<float> FFSXXSOLATE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private Dictionary<float, string> FPFIBZXCGEK;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E200", Offset = "0x9B3CC00", VA = "0x189B3E200")]
		public BFDYWPJXMRJ(MultiValueConfigProperty<float> a, Dictionary<float, string> labelMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E0C0", Offset = "0x9B3CAC0", VA = "0x189B3E0C0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class ZCWUQBYDYVF : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public sealed class CYVFPVABKYF
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public string EDJPGUEQTOV
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public bool[] ACALTDCALMP
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int FLRHUYFPRCS
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xD67210", Offset = "0xD65C10", VA = "0x180D67210")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float AGXUPTWIXSF
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xD67C20", Offset = "0xD66620", VA = "0x180D67C20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0xD67220", Offset = "0xD65C20", VA = "0x180D67220")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int JQHSIUZOJPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0xD1BA20", Offset = "0xD1A420", VA = "0x180D1BA20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CYVFPVABKYF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public sealed class DAOPUGWTAIE
		{
			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public string EDJPGUEQTOV
			{
				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public ConfigProperty<int> SBTEGNBQFBT
			{
				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x12ECCD0", Offset = "0x12EB6D0", VA = "0x1812ECCD0")]
				[CompilerGenerated]
				get
				{
					return default(ConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x68BFE70", Offset = "0x68BE870", VA = "0x1868BFE70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public MultiValueConfigProperty<int> AZKQKUETGWM
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2E4CEA0", Offset = "0x2E4B8A0", VA = "0x182E4CEA0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x9B3ED30", Offset = "0x9B3D730", VA = "0x189B3ED30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public MultiValueConfigProperty<float> MNYYIPRVPAA
			{
				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2E4D3A0", Offset = "0x2E4BDA0", VA = "0x182E4D3A0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x9B3ED10", Offset = "0x9B3D710", VA = "0x189B3ED10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public MultiValueConfigProperty<float> CSEWHEQPEOC
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x6F1B350", Offset = "0x6F19D50", VA = "0x186F1B350")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x6F1B440", Offset = "0x6F19E40", VA = "0x186F1B440")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DAOPUGWTAIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public ZCWUQBYDYVF TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int TQUQGLKBVCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9B41B60", Offset = "0x9B40560", VA = "0x189B41B60")]
			internal void EMJDHNYXIYR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class DKMXUJVEIZF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			public int SCOEDYFFAIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public DKHQXDBGZNW UZNLTVLUBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public Func<CYVFPVABKYF, bool> XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public Func<int, int> YADCNWBVSFA;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKMXUJVEIZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9B643C0", Offset = "0x9B62DC0", VA = "0x189B643C0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9B64D40", Offset = "0x9B63740", VA = "0x189B64D40")]
			internal bool EMOKEUSUSKA(CYVFPVABKYF a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9B64D80", Offset = "0x9B63780", VA = "0x189B64D80")]
			internal int ENEEWPAMUSB(int a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class DKSERQPBSKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public int TUGDLWKIZNS;

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKSERQPBSKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9B64F30", Offset = "0x9B63930", VA = "0x189B64F30")]
			internal bool ENJLTVUKEDK(CYVFPVABKYF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> MLCYDQFAXCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private readonly IReadOnlyList<DAOPUGWTAIE> TDZITYQMMJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private readonly IReadOnlyList<CYVFPVABKYF> STIJUFFRGFQ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x88DAA80", Offset = "0x88D9480", VA = "0x1888DAA80")]
		public ZCWUQBYDYVF(int a, Action<UOJDHDCBUAJ.ColorPickerData> b, IReadOnlyList<DAOPUGWTAIE> c, IReadOnlyList<CYVFPVABKYF> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DFF0", Offset = "0x9B5C9F0", VA = "0x189B5DFF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class PHSNJMFTKZU : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class UAMNTENCRHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public PHSNJMFTKZU TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public UAMNTENCRHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x9B72E40", Offset = "0x9B71840", VA = "0x189B72E40")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x9B73600", Offset = "0x9B72000", VA = "0x189B73600")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private readonly ConfigProperty<int> MNJUFNZIYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> MLCYDQFAXCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private readonly MultiValueConfigProperty<float> DBAYEGEIXZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private readonly MultiValueConfigProperty<float> QQPABGBRZGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private readonly MultiValueConfigProperty<float> CGGUTZHPFYN;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F5F0", Offset = "0x9B6DFF0", VA = "0x189B6F5F0")]
		public PHSNJMFTKZU(int a, ConfigProperty<int> b, Action<UOJDHDCBUAJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F4B0", Offset = "0x9B6DEB0", VA = "0x189B6F4B0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class ABJFDHWEQUE : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class BXAAERVMRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public ABJFDHWEQUE TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Action YANQIJPQLBS;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BXAAERVMRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9B60220", Offset = "0x9B5EC20", VA = "0x189B60220")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x9B60EC0", Offset = "0x9B5F8C0", VA = "0x189B60EC0")]
			internal void ENOSRCOHNOT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly System.Numerics.Vector2 BEFOCMYKXXI;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly System.Numerics.Vector2 DIQOVFSSCFU;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static System.Numerics.Vector2 QRMJBITSIJH;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static System.Numerics.Vector2 HSGNDMMYNXR;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static System.Numerics.Vector2 ZHNQZMVJHAK;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static System.Numerics.Vector2 DUYLXMFOONI;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static System.Numerics.Vector2 DXBEGUWUZAQ;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static System.Numerics.Vector2 VTILYOXCDWQ;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static System.Numerics.Vector2 KTZVNXLIFXI;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static System.Numerics.Vector2 QSRLSGBBMYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private readonly ConfigProperty<int> MNJUFNZIYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> MLCYDQFAXCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private readonly MultiValueConfigProperty<float> KWQEAIAOMWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private readonly MultiValueConfigProperty<float> BHWWECGXTJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private readonly MultiValueConfigProperty<float> CQJJHBUQEVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private readonly MultiValueConfigProperty<float> RYVIMZXAAZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private readonly MultiValueConfigProperty<float> DEHHWCOSAAM;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5EF40", Offset = "0x9B5D940", VA = "0x189B5EF40")]
		public ABJFDHWEQUE(int a, ConfigProperty<int> b, Action<UOJDHDCBUAJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5EA80", Offset = "0x9B5D480", VA = "0x189B5EA80", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5EBC0", Offset = "0x9B5D5C0", VA = "0x189B5EBC0")]
		private static float VBFYLUNCXAM(float a, System.Numerics.Vector2 b, System.Numerics.Vector2 c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public sealed class NOBXQMCHDMP : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public NOBXQMCHDMP TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x9B66460", Offset = "0x9B64E60", VA = "0x189B66460")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x9B667B0", Offset = "0x9B651B0", VA = "0x189B667B0")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private readonly ConfigProperty<int> MNJUFNZIYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> MLCYDQFAXCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private readonly MultiValueConfigProperty<float> CSBGMZBPUZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private readonly MultiValueConfigProperty<float> GOPMOVUJDRF;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B160", Offset = "0x9B69B60", VA = "0x189B6B160")]
		public NOBXQMCHDMP(int a, ConfigProperty<int> b, Action<UOJDHDCBUAJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B020", Offset = "0x9B69A20", VA = "0x189B6B020", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public sealed class KLOWUABVCSK : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public KLOWUABVCSK TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x9B628E0", Offset = "0x9B612E0", VA = "0x189B628E0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x9B63F60", Offset = "0x9B62960", VA = "0x189B63F60")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private readonly MultiValueConfigProperty<int> JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private readonly MultiValueConfigProperty<float> KEEMRCAKURV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private readonly MultiValueConfigProperty<float> MRSLOKYIOVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private readonly MultiValueConfigProperty<bool> PLGZUAIMHEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private readonly ConfigProperty<Guid> YYZQCFVMOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly Action<UOJDHDCBUAJ.RoomRolePickerData> FLQAIWOPOCA;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9B69E90", Offset = "0x9B68890", VA = "0x189B69E90")]
		public KLOWUABVCSK(int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, ConfigProperty<Guid> f, Action<UOJDHDCBUAJ.RoomRolePickerData> onExclusiveToRoleClick)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9B69D50", Offset = "0x9B68750", VA = "0x189B69D50", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class FYEELLETRFL : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public FYEELLETRFL TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x9B6C330", Offset = "0x9B6AD30", VA = "0x189B6C330")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D250", Offset = "0x9B6BC50", VA = "0x189B6D250")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private readonly ConfigProperty<int> ORXXVYHBEIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private readonly ConfigProperty<int> JUQTHIEQWVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private readonly ConfigProperty<int> TILGXZZUJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private readonly ConfigProperty<int> WKRLZHIOXRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private readonly ConfigProperty<int> TUPXZAZLGSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> MLCYDQFAXCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private readonly MultiValueConfigProperty<float> ZKIJVXBPSLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private readonly MultiValueConfigProperty<float> AJESZWTPHSM;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9B66F80", Offset = "0x9B65980", VA = "0x189B66F80")]
		public FYEELLETRFL(int a, ConfigProperty<int> b, ConfigProperty<int> c, ConfigProperty<int> d, ConfigProperty<int> e, ConfigProperty<int> f, Action<UOJDHDCBUAJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9B66E40", Offset = "0x9B65840", VA = "0x189B66E40", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class MDTEAAGSYGN : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class KKFQZTQGXRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public MDTEAAGSYGN TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KKFQZTQGXRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9B68C40", Offset = "0x9B67640", VA = "0x189B68C40")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x9B69C20", Offset = "0x9B68620", VA = "0x189B69C20")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private readonly ConfigProperty<int> MNJUFNZIYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> MLCYDQFAXCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private readonly MultiValueConfigProperty<float> JKJDDXVTGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private readonly MultiValueConfigProperty<float> BCLUFFKRFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private readonly MultiValueConfigProperty<float> LEGQPTJJEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private readonly MultiValueConfigProperty<float> FESVNRANOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private readonly MultiValueConfigProperty<float> IGSOKLSBZAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private readonly MultiValueConfigProperty<float> CZIFFXNRFTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private readonly MultiValueConfigProperty<bool> TOQKYQTTZDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly MultiValueConfigProperty<bool> MLOLFQZEUHQ;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9B6AE70", Offset = "0x9B69870", VA = "0x189B6AE70")]
		public MDTEAAGSYGN(int a, ConfigProperty<int> b, Action<UOJDHDCBUAJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9B6AD30", Offset = "0x9B69730", VA = "0x189B6AD30", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public readonly struct MultiValueConfigProperty<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class WZMNMFSNCIX<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public IEnumerable<b> BSKHXHZJZJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public Func<b, T> EDXSJHREPQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public Action<b, T> JPJGRXXSHJL;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WZMNMFSNCIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x874BFD0", Offset = "0x874A9D0", VA = "0x18874BFD0")]
			internal Option<T> ATDAPSQIRZK()
			{
				return default(Option<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x874C7F0", Offset = "0x874B1F0", VA = "0x18874C7F0")]
			internal void ATIHMZKGBKT(T a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class PIMCIAIGQJC<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public T TUGDLWKIZNS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public WZMNMFSNCIX<b> UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PIMCIAIGQJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x73E3FB0", Offset = "0x73E29B0", VA = "0x1873E3FB0")]
			internal void ATNOKGEDKWC(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class BGYUSPZXLWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public MultiValueConfigProperty<T> WPJIKKBEHRZ;

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BGYUSPZXLWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x4F321C0", Offset = "0x4F30BC0", VA = "0x184F321C0")]
			internal Option<object> GNRVWKBILWV()
			{
				return default(Option<object>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x4F31EC0", Offset = "0x4F308C0", VA = "0x184F31EC0")]
			internal void GNMOZDHLCLM(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class LRCDTOFPHMM<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public Func<b, T> EDXSJHREPQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public T MBTZTDRJKQM;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LRCDTOFPHMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x68ED3A0", Offset = "0x68EBDA0", VA = "0x1868ED3A0")]
			internal bool TMURINGPADT(b a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public readonly Func<Option<T>> Get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public readonly Action<T> Set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public readonly Func<bool>? IsModified;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x39FF190", Offset = "0x39FDB90", VA = "0x1839FF190")]
		public static MultiValueConfigProperty<T> Create<U>(IEnumerable<U> objects, Func<U, T> getter, Action<U, T> setter, Func<bool>? isModified) where U : notnull
		{
			return default(MultiValueConfigProperty<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7144CE0", Offset = "0x71436E0", VA = "0x187144CE0")]
		public static implicit operator MultiValueConfigProperty<object>(MultiValueConfigProperty<T> prop)
		{
			return default(MultiValueConfigProperty<object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x39FF760", Offset = "0x39FE160", VA = "0x1839FF760")]
		private static Option<T> JMAPGRFFAPD<U>(IEnumerable<U> a, Func<U, T> b) where U : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
		internal MultiValueConfigProperty(Func<Option<T>> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class CBSUSGBTUUR
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[CompilerGenerated]
		private sealed class WZRUJMMKLUG<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public IEnumerable<a> BSKHXHZJZJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public Func<a, bool> UWMTJYAJLLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public Func<a, bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WZRUJMMKLUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x874D790", Offset = "0x874C190", VA = "0x18874D790")]
			internal bool DMZJYHDQJSE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x874D840", Offset = "0x874C240", VA = "0x18874D840")]
			internal bool DNEQVNXNTDN(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class LQPRZMCNGRT<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public MultiValueConfigProperty<a> WPJIKKBEHRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public Func<a, b> QRUJHCGPMKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public Func<b, a> UVGIVOCTCLI;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LQPRZMCNGRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x68D6B30", Offset = "0x68D5530", VA = "0x1868D6B30")]
			internal Option<b> RZQGVPKYUKF()
			{
				return default(Option<b>);
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x68D69F0", Offset = "0x68D53F0", VA = "0x1868D69F0")]
			internal void RKPQTXMEWES(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class MWVGGDREEOF<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public ConfigProperty<a> WPJIKKBEHRZ;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MWVGGDREEOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x6F43520", Offset = "0x6F41F20", VA = "0x186F43520")]
			internal Option<a> RZRIQBWCRCE()
			{
				return default(Option<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB50", Offset = "0x12D9550", VA = "0x1812DAB50")]
			internal void ORDFGRQELCT(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x381B830", Offset = "0x381A230", VA = "0x18381B830")]
		public static MultiValueConfigProperty<U> OUSWCXYXNMK<U, T>(this IEnumerable<T> a, Func<T, U> b, Action<T, U> c, [Optional] Func<T, bool>? isModified) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x381C160", Offset = "0x381AB60", VA = "0x18381C160")]
		public static MultiValueConfigProperty<U> To<U, T>(this MultiValueConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x381B430", Offset = "0x3819E30", VA = "0x18381B430")]
		public static MultiValueConfigProperty<a?> OUSWCXYXNMK<a>(this ConfigProperty<a> prop)
		{
			return default(MultiValueConfigProperty<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class PJKOFVPILXQ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public PJKOFVPILXQ TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9B67F60", Offset = "0x9B66960", VA = "0x189B67F60")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly IReadOnlyList<NavMeshGenerationMode> LXWATHNPGKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private readonly MultiValueConfigProperty<NavMeshGenerationMode> HALMZCMXUMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F6C0", Offset = "0x9B6E0C0", VA = "0x189B6F6C0")]
		private static string CWZOVWTLHIP(NavMeshGenerationMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F940", Offset = "0x9B6E340", VA = "0x189B6F940")]
		public PJKOFVPILXQ(MultiValueConfigProperty<NavMeshGenerationMode> a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F750", Offset = "0x9B6E150", VA = "0x189B6F750", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class KWOVGZKKAUZ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public KWOVGZKKAUZ TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9B75120", Offset = "0x9B73B20", VA = "0x189B75120")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private readonly EXXZURWSQKV IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public KWOVGZKKAUZ(EXXZURWSQKV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9B6AAB0", Offset = "0x9B694B0", VA = "0x189B6AAB0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class EXXZURWSQKV : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private readonly Action BZROHUMRNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private readonly Func<bool> NUDOQRPHUVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private readonly Action FNFBDTLHCVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private readonly Action LQCZHMFPNLM;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x111E6D0", Offset = "0x111D0D0", VA = "0x18111E6D0")]
		public EXXZURWSQKV(Action a, Func<bool> b, Action c, Action d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9B66AD0", Offset = "0x9B654D0", VA = "0x189B66AD0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9B66AA0", Offset = "0x9B654A0", VA = "0x189B66AA0")]
		[CompilerGenerated]
		private bool QVGJJIJVVSQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9B66AA0", Offset = "0x9B654A0", VA = "0x189B66AA0")]
		[CompilerGenerated]
		private bool QVLQGPDTFDZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class SLCMWCRVRKY : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public SLCMWCRVRKY TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9B71170", Offset = "0x9B6FB70", VA = "0x189B71170")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B716D0", Offset = "0x9B700D0", VA = "0x189B716D0")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private readonly IReadOnlyDictionary<int, string> QSAOUDXVLBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private readonly MultiValueConfigProperty<int> KUSUQPFUFUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private readonly MultiValueConfigProperty<bool> MMRHDCSSCQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private readonly MultiValueConfigProperty<bool> QAGZTOSNUUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private readonly MultiValueConfigProperty<float> QUGLTLWORJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private readonly MultiValueConfigProperty<float> HQUMUOJZDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly NVMCMQCOOAE? UVXTZZGONIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private readonly CNUHDIQJNBT? AWVKRPQIWFX;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9B71AB0", Offset = "0x9B704B0", VA = "0x189B71AB0")]
		public SLCMWCRVRKY(IReadOnlyDictionary<int, string>? effectsDict, MultiValueConfigProperty<int> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, NVMCMQCOOAE? sandboxColorableConfig, CNUHDIQJNBT? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B71970", Offset = "0x9B70370", VA = "0x189B71970", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class OALVIYTLQPQ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public OALVIYTLQPQ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B68170", Offset = "0x9B66B70", VA = "0x189B68170")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class JIXDBIORISE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public string SJJHFSSKOZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ConfigProperty<string> PWLTSFXFCJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public JJCJYPIOSDN UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JIXDBIORISE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9B67C50", Offset = "0x9B66650", VA = "0x189B67C50")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x9B67DE0", Offset = "0x9B667E0", VA = "0x189B67DE0")]
			internal void EMDWKHEZZNI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly bool SXKMGLJWICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly IReadOnlyList<ConfigProperty<string>> TXKYMNUHUWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly int CAPWWTAWGXJ;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B770", Offset = "0x9B6A170", VA = "0x189B6B770")]
		public OALVIYTLQPQ(int a, bool b, IReadOnlyList<ConfigProperty<string>> messages, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B620", Offset = "0x9B6A020", VA = "0x189B6B620", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class JYOIBCKOTKO : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public JYOIBCKOTKO TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B69F90", Offset = "0x9B68990", VA = "0x189B69F90")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly EKFHWSGRGZW IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10B3BE0", Offset = "0x10B25E0", VA = "0x1810B3BE0")]
		public JYOIBCKOTKO(int a, EKFHWSGRGZW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B68AF0", Offset = "0x9B674F0", VA = "0x189B68AF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class EKFHWSGRGZW : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public EKFHWSGRGZW TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x9B68500", Offset = "0x9B66F00", VA = "0x189B68500")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B68980", Offset = "0x9B67380", VA = "0x189B68980")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private readonly bool SXKMGLJWICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private readonly string OAVJQRMKHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private readonly ConfigProperty<string> PWLTSFXFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly int IKJAYKLGGEU;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B65BB0", Offset = "0x9B645B0", VA = "0x189B65BB0")]
		public EKFHWSGRGZW(bool a, string b, ConfigProperty<string> message, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B65A60", Offset = "0x9B64460", VA = "0x189B65A60", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class AKCRMVUJIXY : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public AKCRMVUJIXY TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public Action XZSOTIOAZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public Func<bool> YAIJLCVTBQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public Action<bool> YADCNWBVSFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public Func<bool> BVILBCMOOZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Action BVNRYJGLYKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public Action YASXFQJNUNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public Action<bool> BVSYVQAJHWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public Action BVYFSWUGRHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public Action YANQIJPQLBS;

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F470", Offset = "0x9B6DE70", VA = "0x189B6F470")]
			internal bool VXDZEAYGCUM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B6EA40", Offset = "0x9B6D440", VA = "0x189B6EA40")]
			internal bool ETCJYFQFFGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F370", Offset = "0x9B6DD70", VA = "0x189B6F370")]
			internal void PXWHBTPSHEM(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F3A0", Offset = "0x9B6DDA0", VA = "0x189B6F3A0")]
			internal bool RMWKSUFPNQI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DE80", Offset = "0x9B6C880", VA = "0x189B6DE80")]
			internal void EMOKEUSUSKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9B6E610", Offset = "0x9B6D010", VA = "0x189B6E610")]
			internal void EMTRCBMSBVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x9B6EA40", Offset = "0x9B6D440", VA = "0x189B6EA40")]
			internal bool EMYXZIGPLGS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x9B6EA80", Offset = "0x9B6D480", VA = "0x189B6EA80")]
			internal void ENEEWPAMUSB(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9B6EB40", Offset = "0x9B6D540", VA = "0x189B6EB40")]
			internal void ENJLTVUKEDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x9B6C2F0", Offset = "0x9B6ACF0", VA = "0x189B6C2F0")]
			internal bool CYUNBMRLOFX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9B6C100", Offset = "0x9B6AB00", VA = "0x189B6C100")]
			internal void CYPGEFXOEUO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F030", Offset = "0x9B6DA30", VA = "0x189B6F030")]
			internal void ENOSRCOHNOT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9B6C030", Offset = "0x9B6AA30", VA = "0x189B6C030")]
			internal void CYJZGZDQVJF(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x9B6BB90", Offset = "0x9B6A590", VA = "0x189B6BB90")]
			internal void CYESJSJTLXW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class UAMNTENCRHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public AKCRMVUJIXY TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public PhysicsModelEnumFlags FBCBXKDPKKM;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public UAMNTENCRHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9B73730", Offset = "0x9B72130", VA = "0x189B73730")]
			internal bool FQSCQEHGSNY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9B73770", Offset = "0x9B72170", VA = "0x189B73770")]
			internal void FQXJNLBEBZH(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly IReadOnlyList<CollisionMode> QNRCMAQDKJI;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly IReadOnlyList<CollisionLayerEnum> GTOMFIBUKFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private readonly bool PUUHOKKQSNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private readonly ConfigProperty<CollisionMode> NBNOFEKNFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly ConfigProperty<CollisionLayerEnum> BPRXMZHCXDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly ConfigProperty<float> NEGZAGREJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly Func<PhysicsModelEnumFlags, bool> FYDMVKXYXFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly Action<PhysicsModelEnumFlags, bool> UBHMMJTSGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly ConfigProperty<float>? AIIPJYBGZLI;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B5FCC0", Offset = "0x9B5E6C0", VA = "0x189B5FCC0")]
		private static string QQHYHYCHYCJ(CollisionMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9B5FBD0", Offset = "0x9B5E5D0", VA = "0x189B5FBD0")]
		private static string IBBFKGSAHSP(CollisionLayerEnum a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B60140", Offset = "0x9B5EB40", VA = "0x189B60140")]
		public AKCRMVUJIXY(bool a, ConfigProperty<CollisionMode> b, ConfigProperty<CollisionLayerEnum> c, ConfigProperty<float> d, Func<PhysicsModelEnumFlags, bool> hasFlag, Action<PhysicsModelEnumFlags, bool> setFlag, [Optional] ConfigProperty<float>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B5FD50", Offset = "0x9B5E750", VA = "0x189B5FD50", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9B5FE90", Offset = "0x9B5E890", VA = "0x189B5FE90")]
		private MultiValueConfigProperty<bool> YFRFPDVUBGA(PhysicsModelEnumFlags a)
		{
			return default(MultiValueConfigProperty<bool>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class AFUJTMSWLJJ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public AFUJTMSWLJJ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B65FB0", Offset = "0x9B649B0", VA = "0x189B65FB0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9B668E0", Offset = "0x9B652E0", VA = "0x189B668E0")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private static readonly IReadOnlyList<GrabbableMode> CISIZZPDQKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private readonly MultiValueConfigProperty<bool> IKBOGRBIJPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private readonly MultiValueConfigProperty<GrabbableMode> JXUQZNTMWNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private readonly MultiValueConfigProperty<bool> BNICWDPRVYH;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B5F990", Offset = "0x9B5E390", VA = "0x189B5F990")]
		private static string GSHCVCRPVQB(GrabbableMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BE30", Offset = "0x9B4A830", VA = "0x189B4BE30")]
		public AFUJTMSWLJJ(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<GrabbableMode> b, MultiValueConfigProperty<bool> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B5FA00", Offset = "0x9B5E400", VA = "0x189B5FA00", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class PWMMWXZNORT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public PWMMWXZNORT TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Func<bool> XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x9B62E90", Offset = "0x9B61890", VA = "0x189B62E90")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9B63D90", Offset = "0x9B62790", VA = "0x189B63D90")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x9B64380", Offset = "0x9B62D80", VA = "0x189B64380")]
			internal bool EMJDHNYXIYR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x9B64170", Offset = "0x9B62B70", VA = "0x189B64170")]
			internal void EMDWKHEZZNI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private readonly Option<bool> AUFJMKBKBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private readonly MultiValueConfigProperty<string> AJEKOIXQXIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Func<int> NRWCKKGDVIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private readonly MultiValueConfigProperty<bool> RJMHKGZAIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly MultiValueConfigProperty<bool> EAOSNHPHTMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly HTUKWFYTSRG? UFSNUJAWEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly QXEYZOOFTMZ? RUDSBQMKMOZ;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x9B70590", Offset = "0x9B6EF90", VA = "0x189B70590")]
		public PWMMWXZNORT(Option<bool> a, MultiValueConfigProperty<string> name, Func<int> currentSelectionCount, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, HTUKWFYTSRG? transformConfig, QXEYZOOFTMZ? tagsConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B70450", Offset = "0x9B6EE50", VA = "0x189B70450", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class ZCCQEBUJAZX : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class KNTZTHNOLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public ZCCQEBUJAZX TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Func<int> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNTZTHNOLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A2C0", Offset = "0x9B68CC0", VA = "0x189B6A2C0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x9B6AA80", Offset = "0x9B69480", VA = "0x189B6AA80")]
			internal int ELYPNALCQBZ()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private readonly MultiValueConfigProperty<int> MNJUFNZIYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> LVVUKDZVCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private readonly MultiValueConfigProperty<int> JVGECNPMNMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private readonly Action<UOJDHDCBUAJ.MaterialPickerData> OIBSHWNPBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private readonly MultiValueConfigProperty<float> LNTCRDHWLZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private readonly MultiValueConfigProperty<float> MPKTTFLDWOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private readonly MultiValueConfigProperty<float> MPFMVYRGNCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private readonly MultiValueConfigProperty<float> MPVHNSYYPKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly MultiValueConfigProperty<bool> SMZOFKWPBVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private readonly Func<bool> ULICACQHAHC;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B75F30", Offset = "0x9B74930", VA = "0x189B75F30")]
		public ZCCQEBUJAZX(MultiValueConfigProperty<int> a, Action<UOJDHDCBUAJ.ColorPickerData> colorButtonOnClick, MultiValueConfigProperty<int> b, Action<UOJDHDCBUAJ.MaterialPickerData> materialButtonOnClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, Func<bool> isSinglePrimitiveShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B75DF0", Offset = "0x9B747F0", VA = "0x189B75DF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class XTSGHXPWGBZ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public XTSGHXPWGBZ TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9B68690", Offset = "0x9B67090", VA = "0x189B68690")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private readonly Dictionary<int, string> KPSFQCZMYEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private readonly MultiValueConfigProperty<bool> RVDIXSZKNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private readonly MultiValueConfigProperty<bool> CKLQEUKGKYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private readonly MultiValueConfigProperty<int> CXUWSFMPEYW;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B75D40", Offset = "0x9B74740", VA = "0x189B75D40")]
		public XTSGHXPWGBZ(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<int> c, Dictionary<int, string> tubeRingOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B75C00", Offset = "0x9B74600", VA = "0x189B75C00", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class TMKQFFGZZSC : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public TMKQFFGZZSC TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B69FF0", Offset = "0x9B689F0", VA = "0x189B69FF0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private readonly NVMCMQCOOAE IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10B3BE0", Offset = "0x10B25E0", VA = "0x1810B3BE0")]
		public TMKQFFGZZSC(int a, NVMCMQCOOAE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B71C30", Offset = "0x9B70630", VA = "0x189B71C30", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class NVMCMQCOOAE : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class PKPAGNSVYSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public NVMCMQCOOAE TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PKPAGNSVYSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F990", Offset = "0x9B6E390", VA = "0x189B6F990")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B702E0", Offset = "0x9B6ECE0", VA = "0x189B702E0")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private readonly RecolorModes LCYEVYMIJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly ConfigProperty<int> YFDDFYXMIDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly Action<UOJDHDCBUAJ.ColorPickerData> LVVUKDZVCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly ConfigProperty<int> FIDTVWEZMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly Action<UOJDHDCBUAJ.MaterialPickerData> OIBSHWNPBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly ConfigProperty<float> ELACHKJBFTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private readonly bool HQXSPFJQBPL;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B550", Offset = "0x9B69F50", VA = "0x189B6B550")]
		public NVMCMQCOOAE(RecolorModes a, ConfigProperty<int> b, Action<UOJDHDCBUAJ.ColorPickerData> colorButtonOnClick, ConfigProperty<int> c, Action<UOJDHDCBUAJ.MaterialPickerData> materialButtonOnClick, ConfigProperty<float> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B350", Offset = "0x9B69D50", VA = "0x189B6B350", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class NQERXJGVFJG : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public NQERXJGVFJG TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9B74DD0", Offset = "0x9B737D0", VA = "0x189B74DD0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private readonly CNUHDIQJNBT? CURQUDGFBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private readonly EKFHWSGRGZW? CBPGLMARHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private readonly NVMCMQCOOAE? BUWIYYVMPMA;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF4AE90", Offset = "0xF49890", VA = "0x180F4AE90")]
		public NQERXJGVFJG(EKFHWSGRGZW? a, NVMCMQCOOAE? b, CNUHDIQJNBT? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B210", Offset = "0x9B69C10", VA = "0x189B6B210", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class EUANCIYGQCN : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public EUANCIYGQCN TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A050", Offset = "0x9B68A50", VA = "0x189B6A050")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private readonly int JWSOZRGVUMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private readonly CNUHDIQJNBT IXKSCPHRYQI;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10B3BE0", Offset = "0x10B25E0", VA = "0x1810B3BE0")]
		public EUANCIYGQCN(int a, CNUHDIQJNBT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9B66950", Offset = "0x9B65350", VA = "0x189B66950", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class CNUHDIQJNBT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly string OAVJQRMKHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private readonly MultiValueConfigProperty<bool> GWVXRURPDPW;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B54B30", Offset = "0x9B53530", VA = "0x189B54B30")]
		public CNUHDIQJNBT(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B626A0", Offset = "0x9B610A0", VA = "0x189B626A0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class QXEYZOOFTMZ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public QXEYZOOFTMZ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Func<string, bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9B63B40", Offset = "0x9B62540", VA = "0x189B63B40")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9B64120", Offset = "0x9B62B20", VA = "0x189B64120")]
			internal bool ELYPNALCQBZ(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private readonly ConfigProperty<IReadOnlyList<string>> ECZHPNPRIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private readonly ConfigProperty<IReadOnlyList<string>>? PPYZXGZUROP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private readonly Func<bool> MVVPHSFGEUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly Func<bool>? UDAKRZMBDCW;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
		private static bool AJGITVEXILO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B70780", Offset = "0x9B6F180", VA = "0x189B70780")]
		public QXEYZOOFTMZ(int a, ConfigProperty<IReadOnlyList<string>> persistentTags, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeTags, [Optional] Func<bool>? b, [Optional] Func<bool>? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B70670", Offset = "0x9B6F070", VA = "0x189B70670", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class URGMRROJMZD : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class CDZEDXAQFAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public URGMRROJMZD TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CDZEDXAQFAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x9B61C30", Offset = "0x9B60630", VA = "0x189B61C30")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9B62610", Offset = "0x9B61010", VA = "0x189B62610")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x9B62640", Offset = "0x9B61040", VA = "0x189B62640")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x9B62670", Offset = "0x9B61070", VA = "0x189B62670")]
			internal void EMJDHNYXIYR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class CAKVKJDIRQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public URGMRROJMZD TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CAKVKJDIRQL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9B61660", Offset = "0x9B60060", VA = "0x189B61660")]
			internal void QUTIGJMMYUL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x9B61130", Offset = "0x9B5FB30", VA = "0x189B61130")]
			internal void QUOBJCSPPJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9B61BC0", Offset = "0x9B605C0", VA = "0x189B61BC0")]
			internal bool QVDWAXAHRRD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly IReadOnlyList<GunHandleData.HDTPLDNTADR.GunHandleScreensPose> WAFEZQBCCYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private readonly MultiValueConfigProperty<GunHandleData.HDTPLDNTADR.GunHandleScreensPose> TEZUKLERXJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly MultiValueConfigProperty<int> CXKZNCKIGWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly MultiValueConfigProperty<bool> YFLBPTUGPAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly MultiValueConfigProperty<float> XVOEHJTUYIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly MultiValueConfigProperty<bool> JMWLGHZJASD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly MultiValueConfigProperty<float> ETMVOGCVGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly MultiValueConfigProperty<bool> PVHANEITMOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly MultiValueConfigProperty<bool> AYZAXJADVQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly MultiValueConfigProperty<float> KYXAEWCOJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private readonly MultiValueConfigProperty<bool> YDQYVKNYYJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private readonly MultiValueConfigProperty<bool> VJDPCKDKNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private readonly MultiValueConfigProperty<bool> YYHTHNTFTAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly MultiValueConfigProperty<bool> MCFQGLPVYEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly MultiValueConfigProperty<bool> FUOWXAOFZKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MultiValueConfigProperty<float> JHNHPCTKPZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly MultiValueConfigProperty<float> DXUZPQAOQWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private readonly MultiValueConfigProperty<float> HCPAYHFJKVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly MultiValueConfigProperty<float> DOVSQKVSNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly MultiValueConfigProperty<float> KCDGQDRKGYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private readonly MultiValueConfigProperty<float> PHMGDHZXRLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly MultiValueConfigProperty<bool> AGDBJKPETFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly MultiValueConfigProperty<bool> WHUJYRFTDVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly MultiValueConfigProperty<bool> SMFEHAPOVVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly MultiValueConfigProperty<string> EXBBGSEYHXZ;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B746E0", Offset = "0x9B730E0", VA = "0x189B746E0")]
		private static string ZNRZAUNJFBV(GunHandleData.HDTPLDNTADR.GunHandleScreensPose a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9B74870", Offset = "0x9B73270", VA = "0x189B74870")]
		public URGMRROJMZD(MultiValueConfigProperty<GunHandleData.HDTPLDNTADR.GunHandleScreensPose> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, MultiValueConfigProperty<float> q, MultiValueConfigProperty<float> r, MultiValueConfigProperty<float> s, MultiValueConfigProperty<float> t, MultiValueConfigProperty<bool> u, MultiValueConfigProperty<bool> v, MultiValueConfigProperty<bool> w, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B740F0", Offset = "0x9B72AF0", VA = "0x189B740F0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B73D40", Offset = "0x9B72740", VA = "0x189B73D40")]
		private void UGSGEFOUBZD(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9B74230", Offset = "0x9B72C30", VA = "0x189B74230")]
		private void YVGVZIHWDYL(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9B738F0", Offset = "0x9B722F0", VA = "0x189B738F0")]
		private void EIQNCSGOOON(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9B73C60", Offset = "0x9B72660", VA = "0x189B73C60")]
		[CompilerGenerated]
		private bool QECKWKKKOUO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9B73CD0", Offset = "0x9B726D0", VA = "0x189B73CD0")]
		[CompilerGenerated]
		private bool QEHRTREHYFX()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class DCIUZFFTPLT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly string AJVAVQNHFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly MultiValueConfigProperty<string> EXBBGSEYHXZ;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9B54B30", Offset = "0x9B53530", VA = "0x189B54B30")]
		public DCIUZFFTPLT(string a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9B627C0", Offset = "0x9B611C0", VA = "0x189B627C0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class DWBKWVWDBZT : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public DWBKWVWDBZT TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Func<bool> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x9B63290", Offset = "0x9B61C90", VA = "0x189B63290")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x9B640B0", Offset = "0x9B62AB0", VA = "0x189B640B0")]
			internal bool ELYPNALCQBZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly IReadOnlyDictionary<SwingHandleData.HDTPLDNTADR.SwingHandleAnimation, string> BVJFSHZESUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly MultiValueConfigProperty<SwingHandleData.HDTPLDNTADR.SwingHandleAnimation> TGVFXOOOKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly MultiValueConfigProperty<bool> ZZCMCGEYIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly MultiValueConfigProperty<bool> KKPHSHLHTPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly MultiValueConfigProperty<float> AAIQIDAPREA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly MultiValueConfigProperty<bool> AGDBJKPETFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly MultiValueConfigProperty<string> EXBBGSEYHXZ;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DEF0", Offset = "0x9B5C8F0", VA = "0x189B5DEF0")]
		public DWBKWVWDBZT(MultiValueConfigProperty<SwingHandleData.HDTPLDNTADR.SwingHandleAnimation> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9B656A0", Offset = "0x9B640A0", VA = "0x189B656A0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class HNBTHDZLBMD : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public HNBTHDZLBMD TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9B638D0", Offset = "0x9B622D0", VA = "0x189B638D0")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x9B63D60", Offset = "0x9B62760", VA = "0x189B63D60")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9B641D0", Offset = "0x9B62BD0", VA = "0x189B641D0")]
			internal void EMDWKHEZZNI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.HDTPLDNTADR.ThrowHandleIdlePose, string> CCCQEMPPURU;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.HDTPLDNTADR.ThrowHandleThrowPose, string> RJAKJSRAFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private readonly MultiValueConfigProperty<ThrowHandleData.HDTPLDNTADR.ThrowHandleIdlePose> VIISKEGHLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private readonly MultiValueConfigProperty<ThrowHandleData.HDTPLDNTADR.ThrowHandleThrowPose> UYIWLVVBMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private readonly MultiValueConfigProperty<float> FDCPWLHGSPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private readonly MultiValueConfigProperty<float> LVGHFZHANAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private readonly MultiValueConfigProperty<string> EXBBGSEYHXZ;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9B5DBE0", Offset = "0x9B5C5E0", VA = "0x189B5DBE0")]
		public HNBTHDZLBMD(MultiValueConfigProperty<ThrowHandleData.HDTPLDNTADR.ThrowHandleIdlePose> a, MultiValueConfigProperty<ThrowHandleData.HDTPLDNTADR.ThrowHandleThrowPose> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9B67560", Offset = "0x9B65F60", VA = "0x189B67560", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9B67280", Offset = "0x9B65C80", VA = "0x189B67280")]
		private void ISUQOMMMOCJ(UOJDHDCBUAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9B670D0", Offset = "0x9B65AD0", VA = "0x189B670D0")]
		private void FWMALOPXOFA(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class FANIERQEXYH : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public FANIERQEXYH TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A0B0", Offset = "0x9B68AB0", VA = "0x189B6A0B0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private readonly MultiValueConfigProperty<bool> LNAJMUQDEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private readonly MultiValueConfigProperty<string> EXBBGSEYHXZ;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D940", Offset = "0x9B3C340", VA = "0x189B3D940")]
		public FANIERQEXYH(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9B66D00", Offset = "0x9B65700", VA = "0x189B66D00", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class BYDIOJOBQTY : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public BYDIOJOBQTY TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9B74E80", Offset = "0x9B73880", VA = "0x189B74E80")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly MultiValueConfigProperty<string> EXBBGSEYHXZ;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public BYDIOJOBQTY(MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9B60FF0", Offset = "0x9B5F9F0", VA = "0x189B60FF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class RJJATYEPHPR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class ACWIPAVUBWN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public RJJATYEPHPR TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACWIPAVUBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9B5F060", Offset = "0x9B5DA60", VA = "0x189B5F060")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private readonly MultiValueConfigProperty<bool> ZPVTEUPYIJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private readonly MultiValueConfigProperty<float> LMAGUDZTIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private readonly System.Numerics.Vector2 IIHCBOWQYYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private readonly MultiValueConfigProperty<bool> XNRQHJHPPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private readonly NVMCMQCOOAE? CSJGYHSQUHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private readonly CNUHDIQJNBT? GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9B710B0", Offset = "0x9B6FAB0", VA = "0x189B710B0")]
		public RJJATYEPHPR(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<bool> d, NVMCMQCOOAE? colorableOptions, CNUHDIQJNBT? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9B70F70", Offset = "0x9B6F970", VA = "0x189B70F70", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class UKBLGEUZTGS : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public UKBLGEUZTGS TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9B74F70", Offset = "0x9B73970", VA = "0x189B74F70")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly QXEYZOOFTMZ URNOLRXAOZO;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public UKBLGEUZTGS(QXEYZOOFTMZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9B737B0", Offset = "0x9B721B0", VA = "0x189B737B0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class VVNYSMIQNOR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public VVNYSMIQNOR TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x9B74FD0", Offset = "0x9B739D0", VA = "0x189B74FD0")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly MultiValueConfigProperty<bool> KPTBPSFDTBM;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D7C0", Offset = "0x9B3C1C0", VA = "0x189B3D7C0")]
		public VVNYSMIQNOR(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9B74C90", Offset = "0x9B73690", VA = "0x189B74C90", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class RWULCKPCTMW : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class ACWIPAVUBWN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public RWULCKPCTMW TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACWIPAVUBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9B5F8F0", Offset = "0x9B5E2F0", VA = "0x189B5F8F0")]
			internal bool NJHHIJWBYSL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x9B5F580", Offset = "0x9B5DF80", VA = "0x189B5F580")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private readonly MultiValueConfigProperty<bool> YJJNEOPMMUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private readonly Func<bool> WNNGCNEXNCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private readonly MultiValueConfigProperty<bool> CAKNHRBHUWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private readonly MultiValueConfigProperty<float> LNKOSZTGVAV;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9B718C0", Offset = "0x9B702C0", VA = "0x189B718C0")]
		public RWULCKPCTMW(MultiValueConfigProperty<bool> a, Func<bool> canSeeShouldRespawn, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9B71780", Offset = "0x9B70180", VA = "0x189B71780", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class IDXZRZUGEFR : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class PKPAGNSVYSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public IDXZRZUGEFR TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PKPAGNSVYSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FC40", Offset = "0x9B6E640", VA = "0x189B6FC40")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9B70300", Offset = "0x9B6ED00", VA = "0x189B70300")]
			internal void ELYPNALCQBZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly Dictionary<SeatData.HDTPLDNTADR.PostureType, string> LFJWXKWZAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private readonly string TNMECJUWNVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private readonly Option<bool> NBLBAVQXXZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private readonly MultiValueConfigProperty<SeatData.HDTPLDNTADR.PostureType> HARQCLNDCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private readonly MultiValueConfigProperty<bool> ZZMLGKGKHLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private readonly MultiValueConfigProperty<bool> RPJRMWGRDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private readonly MultiValueConfigProperty<bool> SFESEZLZTYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private readonly MultiValueConfigProperty<bool> CYEMEVUPEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly MultiValueConfigProperty<bool> FZEZMSDHFSC;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9B67B20", Offset = "0x9B66520", VA = "0x189B67B20")]
		public IDXZRZUGEFR(string configName, Option<bool> a, MultiValueConfigProperty<SeatData.HDTPLDNTADR.PostureType> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9B678F0", Offset = "0x9B662F0", VA = "0x189B678F0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class OLCFQCHXISU : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class DMJSJVVHHBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public OLCFQCHXISU TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DMJSJVVHHBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9B64F50", Offset = "0x9B63950", VA = "0x189B64F50")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private static readonly IReadOnlyDictionary<int, string> TPXMXPQFZOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private readonly MultiValueConfigProperty<int> AQXYLSANGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private readonly IReadOnlyDictionary<int, string> HVQBLOFHNZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private readonly MultiValueConfigProperty<float> XSKHTKCWUFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private readonly MultiValueConfigProperty<int> YZWQMLPYUEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private readonly MultiValueConfigProperty<string> IUUWLPOCQLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly MultiValueConfigProperty<bool> DLCPYRHWWCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly MultiValueConfigProperty<string> PYBYIRKGSEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private readonly MultiValueConfigProperty<bool> QPDLNNTYYBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private readonly MultiValueConfigProperty<bool> LPMYFZUZCUK;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6BA20", Offset = "0x9B6A420", VA = "0x189B6BA20")]
		public OLCFQCHXISU(MultiValueConfigProperty<int> a, IReadOnlyDictionary<int, string> teamItems, MultiValueConfigProperty<float> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<string> primaryHandRespawnTag, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> secondaryHandRespawnTag, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B7D0", Offset = "0x9B6A1D0", VA = "0x189B6B7D0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public sealed class XJIJJWWFYRA : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public XJIJJWWFYRA TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public Action XZSOTIOAZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Action XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9B6C930", Offset = "0x9B6B330", VA = "0x189B6C930")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D870", Offset = "0x9B6C270", VA = "0x189B6D870")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DAC0", Offset = "0x9B6C4C0", VA = "0x189B6DAC0")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DCA0", Offset = "0x9B6C6A0", VA = "0x189B6DCA0")]
			internal void EMJDHNYXIYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DD60", Offset = "0x9B6C760", VA = "0x189B6DD60")]
			internal void EMOKEUSUSKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9B6E4E0", Offset = "0x9B6CEE0", VA = "0x189B6E4E0")]
			internal void EMTRCBMSBVJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly MultiValueConfigProperty<bool> HRHTTJHGAQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private readonly MultiValueConfigProperty<float> XSKHTKCWUFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private readonly MultiValueConfigProperty<float> SQCFSQRSCGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private readonly QXEYZOOFTMZ WYGOWRNTNZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private readonly QXEYZOOFTMZ GFNPNNOAVGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private readonly IReadOnlyList<(Guid, string)>? ANIRSIIQDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> PVVVSHUJHMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> JJNGDONTLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private readonly Action<UOJDHDCBUAJ.MultiTogglePickerData> KBWFABVZXHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private readonly CNUHDIQJNBT? GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9B752C0", Offset = "0x9B73CC0", VA = "0x189B752C0")]
		public XJIJJWWFYRA(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, IReadOnlyList<(Guid, string)>? roleItems, ConfigProperty<string[]> roleGuidsToSpawn, ConfigProperty<string[]> roleGuidsToAvoid, Action<UOJDHDCBUAJ.MultiTogglePickerData> onRolePickerClick, CNUHDIQJNBT? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9B75180", Offset = "0x9B73B80", VA = "0x189B75180", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public sealed class QYQACTSYPNJ : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class PHARMZVOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public QYQACTSYPNJ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Action XZIAYVAGGLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Action XYXNEHMLNOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public Action XZXVQPHYITR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public Action XZNHWBUDPWZ;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PHARMZVOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9B6CD80", Offset = "0x9B6B780", VA = "0x189B6CD80")]
			internal void ELTIPTRFGQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D750", Offset = "0x9B6C150", VA = "0x189B6D750")]
			internal void ELYPNALCQBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DC40", Offset = "0x9B6C640", VA = "0x189B6DC40")]
			internal void EMJDHNYXIYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DB20", Offset = "0x9B6C520", VA = "0x189B6DB20")]
			internal void EMDWKHEZZNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DD00", Offset = "0x9B6C700", VA = "0x189B6DD00")]
			internal void EMOKEUSUSKA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private readonly int MMZCCPOLWMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly MultiValueConfigProperty<bool> JVLXNDEFGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private readonly MultiValueConfigProperty<float> XSKHTKCWUFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private readonly MultiValueConfigProperty<float> SQCFSQRSCGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private readonly QXEYZOOFTMZ WYGOWRNTNZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private readonly QXEYZOOFTMZ GFNPNNOAVGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private readonly CNUHDIQJNBT? GYKFENQKQBA;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x9B709B0", Offset = "0x9B6F3B0", VA = "0x189B709B0")]
		public QYQACTSYPNJ(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, CNUHDIQJNBT? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x9B70870", Offset = "0x9B6F270", VA = "0x189B70870", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class LYECWPIXEHI : HKSCCEYWDRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public UOJDHDCBUAJ BQJAQMVTDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public LYECWPIXEHI TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9B65C30", Offset = "0x9B64630", VA = "0x189B65C30")]
			internal void ELTIPTRFGQQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private readonly MultiValueConfigProperty<string> XCEEYSYAXBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly MultiValueConfigProperty<float> FGKMNJNTXBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly MultiValueConfigProperty<bool> QROQTNEIEZC;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BE30", Offset = "0x9B4A830", VA = "0x189B4BE30")]
		public LYECWPIXEHI(MultiValueConfigProperty<string> WelcomeMatName, MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9B6ABF0", Offset = "0x9B695F0", VA = "0x189B6ABF0", Slot = "4")]
		public void UVMIXBFUUQC(UOJDHDCBUAJ a)
		{
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
