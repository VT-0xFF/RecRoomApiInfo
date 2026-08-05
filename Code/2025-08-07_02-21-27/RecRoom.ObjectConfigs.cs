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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BA60D0", Offset = "0x8BA4CD0", VA = "0x188BA60D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ObjectConfigs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class CSBUEEJMRLA : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class OMRVDWPWADA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public CSBUEEJMRLA VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OMRVDWPWADA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8BA6D10", Offset = "0x8BA5910", VA = "0x188BA6D10")]
			internal bool TPBDBXTVOZF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8BA6280", Offset = "0x8BA4E80", VA = "0x188BA6280")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IReadOnlyList<Channel> AFTAEPGFWIV;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IReadOnlyList<Channel> ZEPVTHLCNHW;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly IReadOnlyList<RolloffCurve> EEVDARNMDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MultiValueConfigProperty<float> GCRHUIPJYWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MultiValueConfigProperty<float> DBSRQSNWGSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MultiValueConfigProperty<Channel> FPPZTQRGDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly bool HLJEXGIZIBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string IWAIGYCMOTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MultiValueConfigProperty<bool> PWIOTCYZJWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MultiValueConfigProperty<float> WRCQILIFJNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MultiValueConfigProperty<RolloffCurve> VRZUMZXDSSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MultiValueConfigProperty<bool> QBTDIFFMINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly string BVEQVHKPATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MultiValueConfigProperty<bool> JTQFLJBYYPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly string DKGLWEIZQNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MultiValueConfigProperty<bool> DENIVTUDWSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly WLRFULYAZEC? EDPYBPLBPTO;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B982C0", Offset = "0x8B96EC0", VA = "0x188B982C0")]
		private static string KGXRSTECOEA(Channel a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B98370", Offset = "0x8B96F70", VA = "0x188B98370")]
		private static string TOTOFECNPSC(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B98540", Offset = "0x8B97140", VA = "0x188B98540")]
		public CSBUEEJMRLA(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<Channel> c, bool d, string useSpatialAudioLabel, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<RolloffCurve> g, MultiValueConfigProperty<bool> h, string isLoopingLabel, MultiValueConfigProperty<bool> i, string interruptCurrentSoundLabel, MultiValueConfigProperty<bool> j, WLRFULYAZEC? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B981A0", Offset = "0x8B96DA0", VA = "0x188B981A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class VSFODRAHQZP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public VSFODRAHQZP VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Func<bool> VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Func<bool> VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8B95740", Offset = "0x8B94340", VA = "0x188B95740")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8B950D0", Offset = "0x8B93CD0", VA = "0x188B950D0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B95050", Offset = "0x8B93C50", VA = "0x188B95050")]
			internal bool OQGKNMARWMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B94FD0", Offset = "0x8B93BD0", VA = "0x188B94FD0")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly IReadOnlyDictionary<Channel, string> XDSADFDIVRA;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly IReadOnlyDictionary<Channel, string> VWDGIZJLMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool FZOFTGAOYIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly CEEMQSVBGSF QQZTYKUMYBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MultiValueConfigProperty<bool> XZAOIVGHASQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MultiValueConfigProperty<Channel> FPPZTQRGDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly MultiValueConfigProperty<float> WCWOUXLXGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MultiValueConfigProperty<float> DZPYFFSFQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MultiValueConfigProperty<bool> LILHHJYKNBO;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0380", Offset = "0x8BAEF80", VA = "0x188BB0380")]
		public VSFODRAHQZP(bool a, CEEMQSVBGSF recordableObjectOptions, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<Channel> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFFF0", Offset = "0x8BAEBF0", VA = "0x188BAFFF0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class KBRYZPVSWFJ : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public KBRYZPVSWFJ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Func<bool> VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Func<bool> VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> VOPWFDUNFXV;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BA9F20", Offset = "0x8BA8B20", VA = "0x188BA9F20")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8C00", Offset = "0x8BA7800", VA = "0x188BA8C00")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BA89D0", Offset = "0x8BA75D0", VA = "0x188BA89D0")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8950", Offset = "0x8BA7550", VA = "0x188BA8950")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA430", Offset = "0x8BA9030", VA = "0x188BAA430")]
			internal bool ORLZXAQCBCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA3A0", Offset = "0x8BA8FA0", VA = "0x188BAA3A0")]
			internal bool ORGSZTWERQW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Option<string> MSEOSQRZIQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MultiValueConfigProperty<bool> KMJPYCOHMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly IReadOnlyDictionary<int, string>? NUNSTNBGGJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MultiValueConfigProperty<int> STXVMDVFVVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Option<string> RTWHXXSIQMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly MultiValueConfigProperty<bool> AQDBFIYBRMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Option<string> ERWNUHZBVBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MultiValueConfigProperty<int> GCRHUIPJYWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Option<string> QSHAYMHKGZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly MultiValueConfigProperty<bool> EIHKNIZNJYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Func<Option<bool>> BPIZDZBUXYG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0310", Offset = "0x8B9EF10", VA = "0x188BA0310")]
		public KBRYZPVSWFJ(Option<string> is3dAudioLabel, MultiValueConfigProperty<bool> a, Option<string[]> sfxOptions, MultiValueConfigProperty<int> b, Option<string> isInterruptibleLabel, MultiValueConfigProperty<bool> c, Option<string> volumeLabel, MultiValueConfigProperty<int> d, Option<string> playForAllLabel, MultiValueConfigProperty<bool> e, Func<Option<bool>> hasControlPanel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA01F0", Offset = "0x8B9EDF0", VA = "0x188BA01F0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class GNORMXARZCA : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public GNORMXARZCA VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0FF0", Offset = "0x8BAFBF0", VA = "0x188BB0FF0")]
			internal bool WUZDRLLKCSJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0DA0", Offset = "0x8BAF9A0", VA = "0x188BB0DA0")]
			internal bool GHVEUXXPZVL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0F90", Offset = "0x8BAFB90", VA = "0x188BB0F90")]
			internal void ORLZXAQCBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0F20", Offset = "0x8BAFB20", VA = "0x188BB0F20")]
			internal bool ORGSZTWERQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0EA0", Offset = "0x8BAFAA0", VA = "0x188BB0EA0")]
			internal bool ORBMCNCHIFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0E10", Offset = "0x8BAFA10", VA = "0x188BB0E10")]
			internal bool OQGKNMARWMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0DF0", Offset = "0x8BAF9F0", VA = "0x188BB0DF0")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly IReadOnlyList<PreferredHandedness> EDJZAWERBXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly AccountRoleType YAPINFWUDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly JJQSBRMSMRE? MDGXSBVJJNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly MultiValueConfigProperty<bool> IPCVEEBWRYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Option<bool> URZYZSPZTQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Option<bool> FYFXKAYAVXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly MultiValueConfigProperty<PreferredHandedness> HLYLETMXTDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MultiValueConfigProperty<bool> YCOEEVJAXSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly MultiValueConfigProperty<bool> LFLBIPLKCTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly MultiValueConfigProperty<bool> WNRRLIGHMTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly MultiValueConfigProperty<bool> JOVZUPAOEIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly MultiValueConfigProperty<bool> KGAWXLSBSWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MultiValueConfigProperty<bool> SJVJOHXTNHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly bool IGUKXBIAIMK;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BB10", Offset = "0x8B9A710", VA = "0x188B9BB10")]
		private static string ANDUWIPIRBD(PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C6E0", Offset = "0x8B9B2E0", VA = "0x188B9C6E0")]
		public GNORMXARZCA(AccountRoleType a, JJQSBRMSMRE? interactionFilterOptions, MultiValueConfigProperty<bool> b, Option<bool> c, Option<bool> d, MultiValueConfigProperty<PreferredHandedness> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, bool l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BB20", Offset = "0x8B9A720", VA = "0x188B9BB20", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class NWIBVMMOJUB : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public NWIBVMMOJUB VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<bool> VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Action VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Func<bool> VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B93E60", Offset = "0x8B92A60", VA = "0x188B93E60")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8B93710", Offset = "0x8B92310", VA = "0x188B93710")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B933B0", Offset = "0x8B91FB0", VA = "0x188B933B0")]
			internal void OQBDQFGUNAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8B94AC0", Offset = "0x8B936C0", VA = "0x188B94AC0")]
			internal void ORLZXAQCBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8B94A60", Offset = "0x8B93660", VA = "0x188B94A60")]
			internal bool ORBMCNCHIFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8B94A90", Offset = "0x8B93690", VA = "0x188B94A90")]
			internal bool ORGSZTWERQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8B93510", Offset = "0x8B92110", VA = "0x188B93510")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly bool XSPQMXLQMTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool KVKLYSSUTYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly GNORMXARZCA ZDFBEGIBXWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly LIBLREGRKYW? QBZHUOWMSXZ;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6060", Offset = "0x8BA4C60", VA = "0x188BA6060")]
		public NWIBVMMOJUB(int a, bool b, bool c, GNORMXARZCA d, LIBLREGRKYW? creatorRestrictedRolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5F30", Offset = "0x8BA4B30", VA = "0x188BA5F30", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class OMIJDWUZBOI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public OMIJDWUZBOI VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4590", Offset = "0x8BA3190", VA = "0x188BA4590")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly GNORMXARZCA ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public OMIJDWUZBOI(GNORMXARZCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6150", Offset = "0x8BA4D50", VA = "0x188BA6150", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class QXOKZXKXVUC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public QXOKZXKXVUC VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BAD5C0", Offset = "0x8BAC1C0", VA = "0x188BAD5C0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC9E0", Offset = "0x8BAB5E0", VA = "0x188BAC9E0")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly JJQSBRMSMRE? VGAMNEDEFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MultiValueConfigProperty<bool> XCJPEFKTGUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Option<bool> BPIZDZBUXYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly MultiValueConfigProperty<bool> YWNZQCQQWPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly MultiValueConfigProperty<bool> JZMXPIFXTZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly WNRHTJNDDXX? BCNIYTXPZEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly WLRFULYAZEC? HRODDGRQMFU;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA570", Offset = "0x8BA9170", VA = "0x188BAA570")]
		public QXOKZXKXVUC(JJQSBRMSMRE? interactionFilterConfig, MultiValueConfigProperty<bool> a, Option<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, WLRFULYAZEC? syncedComponent, WNRHTJNDDXX? playerEditableText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA450", Offset = "0x8BA9050", VA = "0x188BAA450", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class IUXVDVUITMC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IUXVDVUITMC VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1E40", Offset = "0x8BB0A40", VA = "0x188BB1E40")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1170", Offset = "0x8BAFD70", VA = "0x188BB1170")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly JJQSBRMSMRE? VGAMNEDEFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly MultiValueConfigProperty<bool> NXAEQRGOVRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly MultiValueConfigProperty<bool> XCJPEFKTGUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly MultiValueConfigProperty<bool> HVXGOIGGKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Option<bool> BPIZDZBUXYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly MultiValueConfigProperty<bool> YWNZQCQQWPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly MultiValueConfigProperty<bool> JZMXPIFXTZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly WLRFULYAZEC? HRODDGRQMFU;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DF50", Offset = "0x8B9CB50", VA = "0x188B9DF50")]
		public IUXVDVUITMC(JJQSBRMSMRE? interactionFilterConfig, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, Option<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, WLRFULYAZEC? syncedComponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DE30", Offset = "0x8B9CA30", VA = "0x188B9DE30", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class OQXUYJQTWXX : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public OQXUYJQTWXX VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7950", Offset = "0x8BA6550", VA = "0x188BA7950")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MultiValueConfigProperty<bool> HJPBRMRXHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MultiValueConfigProperty<float> LYDBMLHWPRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly VQUHSHZISWR? UCRHVTPQUEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly WLRFULYAZEC? DVJKVYHBYCM;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6EB0", Offset = "0x8BA5AB0", VA = "0x188BA6EB0")]
		public OQXUYJQTWXX(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, VQUHSHZISWR? sandboxColorableOptions, WLRFULYAZEC? syncedComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6D80", Offset = "0x8BA5980", VA = "0x188BA6D80", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class SQYDKOWMYYL : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public SQYDKOWMYYL VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7700", Offset = "0x8BA6300", VA = "0x188BA7700")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly IReadOnlyList<CircuitsTransformBehavior> ZFYAPCBEHYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly MultiValueConfigProperty<CircuitsTransformBehavior> GOWEOQVNECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly CZIRKWBNGQK? LJQAXANADYO;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB590", Offset = "0x8BAA190", VA = "0x188BAB590")]
		private static string HEZQPIYFCBA(CircuitsTransformBehavior a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB670", Offset = "0x8BAA270", VA = "0x188BAB670")]
		public SQYDKOWMYYL(MultiValueConfigProperty<CircuitsTransformBehavior> a, CZIRKWBNGQK? objectBoardConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB460", Offset = "0x8BAA060", VA = "0x188BAB460", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class SMFACJORDKO : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public SMFACJORDKO VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE210", Offset = "0x8BACE10", VA = "0x188BAE210")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string BILRVYSTMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly MultiValueConfigProperty<string> RJHMBACYDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly MultiValueConfigProperty<bool> FPFZHOJRFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MultiValueConfigProperty<bool> QIDWRLIOJWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MultiValueConfigProperty<bool> ETYCCPIZTPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly JJQSBRMSMRE? LPRTYTMMXYX;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD80", Offset = "0x8BA9980", VA = "0x188BAAD80")]
		public SMFACJORDKO(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, JJQSBRMSMRE? portalInteractionFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAC50", Offset = "0x8BA9850", VA = "0x188BAAC50", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class FSEHFQQAHMP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public FSEHFQQAHMP VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8BA9670", Offset = "0x8BA8270", VA = "0x188BA9670")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string BILRVYSTMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly MultiValueConfigProperty<string> RJHMBACYDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly MultiValueConfigProperty<bool> FPFZHOJRFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly MultiValueConfigProperty<float> DYTSGXJQWLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly MultiValueConfigProperty<bool> WZXYHGUOIZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly MultiValueConfigProperty<bool> XPQIRDJPDDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MultiValueConfigProperty<bool> QIDWRLIOJWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly MultiValueConfigProperty<bool> QDQIZGYECZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly MultiValueConfigProperty<float> EHARUDPVTYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly JJQSBRMSMRE? MDGXSBVJJNX;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B340", Offset = "0x8B99F40", VA = "0x188B9B340")]
		public FSEHFQQAHMP(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<float> g, JJQSBRMSMRE? interactionFilterOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B210", Offset = "0x8B99E10", VA = "0x188B9B210", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class TYPRZAAKOBU : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public TYPRZAAKOBU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Func<bool> VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Func<bool> VOKPHXAPWMM;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BACAA0", Offset = "0x8BAB6A0", VA = "0x188BACAA0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC350", Offset = "0x8BAAF50", VA = "0x188BAC350")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE8A0", Offset = "0x8BAD4A0", VA = "0x188BAE8A0")]
			internal bool ORLZXAQCBCF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Dictionary<LocomotionFilterModes, string> NJOJRIGEWOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly MultiValueConfigProperty<bool> IXAFORDMLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MultiValueConfigProperty<bool> QSQQFCKMHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MultiValueConfigProperty<bool> UAEGYZABILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MultiValueConfigProperty<bool> KKSBFQEEMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MultiValueConfigProperty<string> QPZTPQBDPNF;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEB50", Offset = "0x8BAD750", VA = "0x188BAEB50")]
		public TYPRZAAKOBU(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> roleFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE930", Offset = "0x8BAD530", VA = "0x188BAE930", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class GVGGOYEQCHI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public GVGGOYEQCHI VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1890", Offset = "0x8BB0490", VA = "0x188BB1890")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB11C0", Offset = "0x8BAFDC0", VA = "0x188BB11C0")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MultiValueConfigProperty<bool> HJPBRMRXHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly MultiValueConfigProperty<bool> OHQWZUZGURZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly JJQSBRMSMRE? GUSIVJVCFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly MultiValueConfigProperty<bool> TWUGMQVAULE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly MultiValueConfigProperty<bool> HZTBTFAPCDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly MultiValueConfigProperty<bool> UAEGYZABILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly WLRFULYAZEC MTGGHNMDKFP;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C9C0", Offset = "0x8B9B5C0", VA = "0x188B9C9C0")]
		public GVGGOYEQCHI(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, JJQSBRMSMRE? playerInteractionFilter, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, WLRFULYAZEC syncComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C890", Offset = "0x8B9B490", VA = "0x188B9C890", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class SNVOXMHRDMC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public SNVOXMHRDMC VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Func<bool> VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public Func<bool> VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<bool> VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1250", Offset = "0x8BAFE50", VA = "0x188BB1250")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1230", Offset = "0x8BAFE30", VA = "0x188BB1230")]
			internal bool ORLZXAQCBCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1230", Offset = "0x8BAFE30", VA = "0x188BB1230")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1090", Offset = "0x8BAFC90", VA = "0x188BB1090")]
			internal bool OQGKNMARWMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1040", Offset = "0x8BAFC40", VA = "0x188BB1040")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly Dictionary<TriggerVolumeV1Mode, string> JBUOVKFIBTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MultiValueConfigProperty<TriggerVolumeV1Mode> NULPSMUIDXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly bool MSRKJCLSSIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly MultiValueConfigProperty<bool> WUCEMEPOPYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly MultiValueConfigProperty<bool> JZMXPIFXTZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly MultiValueConfigProperty<string> IEVOPWYGQDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly MultiValueConfigProperty<string> DRRXQGSMTKD;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB080", Offset = "0x8BA9C80", VA = "0x188BAB080")]
		public SNVOXMHRDMC(MultiValueConfigProperty<int> a, bool b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> filterTag, MultiValueConfigProperty<string> filterRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE60", Offset = "0x8BA9A60", VA = "0x188BAAE60", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SFBTGJXDZAI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public SFBTGJXDZAI VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8B99200", Offset = "0x8B97E00", VA = "0x188B99200")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8B98AB0", Offset = "0x8B976B0", VA = "0x188B98AB0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly MultiValueConfigProperty<bool> JZMXPIFXTZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly EJFJMAXGDWI IMYWBWOPBLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly MultiValueConfigProperty<string> CQSAJYWRVNE;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAABC0", Offset = "0x8BA97C0", VA = "0x188BAABC0")]
		public SFBTGJXDZAI(MultiValueConfigProperty<bool> a, EJFJMAXGDWI objectTagsConfig, MultiValueConfigProperty<string> filterByRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAA90", Offset = "0x8BA9690", VA = "0x188BAAA90", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class IQCRKTXPLNP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public IQCRKTXPLNP VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8B957A0", Offset = "0x8B943A0", VA = "0x188B957A0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly MultiValueConfigProperty<bool> JZMXPIFXTZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly MultiValueConfigProperty<bool> VUIVLQOSMJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> YZVIROUZHXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ConfigProperty<IReadOnlyList<string>> NUNAFAOVUBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly ConfigProperty<IReadOnlyList<string>>? UIPJSKAITBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly MultiValueConfigProperty<bool> YRNIGFUFQBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> CEYFXIAWPOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly ConfigProperty<IReadOnlyList<string>> SOYPFKWZFJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ConfigProperty<IReadOnlyList<string>>? SRPYIIVGGXL;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DCA0", Offset = "0x8B9C8A0", VA = "0x188B9DCA0")]
		public IQCRKTXPLNP(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<InteractionFilterMode> d, ConfigProperty<IReadOnlyList<string>> persistentPlayerTags, ConfigProperty<IReadOnlyList<string>>? runtimePlayerTags, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<InteractionFilterMode> f, ConfigProperty<IReadOnlyList<string>> persistentObjectTags, ConfigProperty<IReadOnlyList<string>>? runtimeObjectTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DB70", Offset = "0x8B9C770", VA = "0x188B9DB70", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
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
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		public ConfigProperty(Func<T> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class TNRUTUGOYOY
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class LKGVCQQJQVQ<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Func<a, b> APFETMDYVGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ConfigProperty<a> NDZCEVNPDQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Func<b, a> GXKHTVFQMKV;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LKGVCQQJQVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5986E70", Offset = "0x5985A70", VA = "0x185986E70")]
			internal b VVTBKIISRBO()
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5986450", Offset = "0x5985050", VA = "0x185986450")]
			internal void UHYIHGSPLIP(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4038F20", Offset = "0x4037B20", VA = "0x184038F20")]
		public static ConfigProperty<U> To<U, T>(this ConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(ConfigProperty<U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class ECTFNTZOJGD : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public ECTFNTZOJGD VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Action VOKPHXAPWMM;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8BA09A0", Offset = "0x8B9F5A0", VA = "0x188BA09A0")]
			internal bool DWJMYNUVTEQ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8BA0C70", Offset = "0x8B9F870", VA = "0x188BA0C70")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8BA0AE0", Offset = "0x8B9F6E0", VA = "0x188BA0AE0")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1E90", Offset = "0x8BA0A90", VA = "0x188BA1E90")]
			internal bool ORGSZTWERQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8BA09C0", Offset = "0x8B9F5C0", VA = "0x188BA09C0")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1F00", Offset = "0x8BA0B00", VA = "0x188BA1F00")]
			internal void ORLZXAQCBCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly (int, string)[] PTZYANWUVUA;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly Dictionary<int, string> SBBIZCHYLMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly int PGCFGHJYUYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly JJQSBRMSMRE? WABNENEHWLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ConfigProperty<int> ZRWETABEWYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Action<JIXYMCFDVBA.MultiTogglePickerData> IIBYGFAILYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly MultiValueConfigProperty<bool> HEYKXHAOLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly MultiValueConfigProperty<bool> PDFAYDWBMFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly LIBLREGRKYW? ACCLXOJYRDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly Func<Option<bool>> MQQZMNRDTFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly MultiValueConfigProperty<bool> BYQFVQLSJRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MultiValueConfigProperty<bool> BKAKJHZXDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Func<bool> ECPWOPKEILX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly RoomKeyConfig IKQGESNXYKX;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AD70", Offset = "0x8B99970", VA = "0x188B9AD70")]
		public ECTFNTZOJGD(int a, JJQSBRMSMRE? additionalCostumeConfigOptions, ConfigProperty<int> b, Action<JIXYMCFDVBA.MultiTogglePickerData> onOutfitFilterClick, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, LIBLREGRKYW? playerRolesToAddData, Func<Option<bool>> hasPlayerEquipped, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, Func<bool> isLegacyRoom, RoomKeyConfig roomKeyConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A700", Offset = "0x8B99300", VA = "0x188B9A700", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class JNMIIXQRVEY : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly MultiValueConfigProperty<int> TJXQSMZZEXB;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public JNMIIXQRVEY(MultiValueConfigProperty<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F890", Offset = "0x8B9E490", VA = "0x188B9F890", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class BCKRYLEXTVN : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class LCAFIZDCZRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public BCKRYLEXTVN VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public Func<bool> VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Func<bool> VMERMAPSWRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public Func<bool> BUNEJPNTJYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<bool> BUHXMITWANM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<bool> VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<bool> VPAJZRIHYUN;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCAFIZDCZRS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3340", Offset = "0x8BA1F40", VA = "0x188BA3340")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3BD0", Offset = "0x8BA27D0", VA = "0x188BA3BD0")]
			internal bool ORLZXAQCBCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8BA2DF0", Offset = "0x8BA19F0", VA = "0x188BA2DF0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8BA2240", Offset = "0x8BA0E40", VA = "0x188BA2240")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1F60", Offset = "0x8BA0B60", VA = "0x188BA1F60")]
			internal bool OOVOGQRKIKS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3D70", Offset = "0x8BA2970", VA = "0x188BA3D70")]
			internal bool XXHZUWGQSPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3DE0", Offset = "0x8BA29E0", VA = "0x188BA3DE0")]
			internal bool XXNGSDAOCAV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3920", Offset = "0x8BA2520", VA = "0x188BA3920")]
			internal bool ORBMCNCHIFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3860", Offset = "0x8BA2460", VA = "0x188BA3860")]
			internal bool OQWFFGIJYUE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1FD0", Offset = "0x8BA0BD0", VA = "0x188BA1FD0")]
			internal void OQBDQFGUNAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class LCFMGFXAJDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public bool LLKQBUSWWYZ;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCFMGFXAJDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030")]
			internal bool ORGSZTWERQW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly IReadOnlyList<VoiceOption> EUQGYJLQCAZ;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly IReadOnlyList<RolloffCurve> EEVDARNMDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly MultiValueConfigProperty<bool> ACHPDRJOPGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly MultiValueConfigProperty<string> ZEHOFLZZGOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly int IXKBIISTVUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly MultiValueConfigProperty<float> XRYKCFFXKPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly MultiValueConfigProperty<VoiceOption> FCLBRAGHGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly MultiValueConfigProperty<string> CGMIXUMCAPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly MultiValueConfigProperty<bool> DYCQEVRDFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly MultiValueConfigProperty<bool> MZYKCXYPPTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly MultiValueConfigProperty<bool> UENMUNQUVIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly MultiValueConfigProperty<bool>[] WBRQLHFVUZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly IReadOnlyList<string> CWEBNSOKKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly IReadOnlyList<string> ZWXHRPQQLQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly IReadOnlyList<bool> LHWCMFHQVDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly string IWAIGYCMOTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly MultiValueConfigProperty<bool> PWIOTCYZJWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly MultiValueConfigProperty<float> WRCQILIFJNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly MultiValueConfigProperty<RolloffCurve> VRZUMZXDSSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly MultiValueConfigProperty<bool> QBTDIFFMINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly MultiValueConfigProperty<bool> MKXSGTOMKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly MultiValueConfigProperty<bool> ISUWICRIAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly MultiValueConfigProperty<bool> ZYSSSCRDPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly bool BVZOOCLAAXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly MultiValueConfigProperty<int> AKZCUJQTZKN;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B927A0", Offset = "0x8B913A0", VA = "0x188B927A0")]
		private static string TOTOFECNPSC(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8B92C50", Offset = "0x8B91850", VA = "0x188B92C50")]
		public BCKRYLEXTVN(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<string> instructions, int b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<VoiceOption> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> useContext, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<bool>[] functionEnablements, IReadOnlyList<string> functionEnablementNames, IReadOnlyList<string> functionEnablementDescriptions, IReadOnlyList<bool> functionEnablementVisibilities, string useSpatialAudioLabel, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<float> j, MultiValueConfigProperty<RolloffCurve> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool> n, bool o, MultiValueConfigProperty<int> p)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B924D0", Offset = "0x8B910D0", VA = "0x188B924D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class AXMNABXUZYR : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public AXMNABXUZYR VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA45F0", Offset = "0x8BA31F0", VA = "0x188BA45F0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly MultiValueConfigProperty<bool> QYKTSHOTNSQ;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public AXMNABXUZYR(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B923A0", Offset = "0x8B90FA0", VA = "0x188B923A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class QJYGZPCNLRM : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public QJYGZPCNLRM VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4020", Offset = "0x8BA2C20", VA = "0x188BA4020")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly MultiValueConfigProperty<bool> NUNGNKZKOMO;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public QJYGZPCNLRM(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8820", Offset = "0x8BA7420", VA = "0x188BA8820", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class JZAXSCERBEA : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly string BSDOXQGACCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly MultiValueConfigProperty<bool> XJOEHTQTSNP;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FF10", Offset = "0x8B9EB10", VA = "0x188B9FF10")]
		public JZAXSCERBEA(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FDE0", Offset = "0x8B9E9E0", VA = "0x188B9FDE0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class MONRFXHCHJU : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public MONRFXHCHJU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public Func<bool> VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8B93A70", Offset = "0x8B92670", VA = "0x188B93A70")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8B937F0", Offset = "0x8B923F0", VA = "0x188B937F0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8B936F0", Offset = "0x8B922F0", VA = "0x188B936F0")]
			internal bool OQGKNMARWMD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly JJQSBRMSMRE MDGXSBVJJNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Func<bool> GPYQRXXMPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly Action ZQRYZQSOVHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly bool VKELIETXCYQ;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4F60", Offset = "0x8BA3B60", VA = "0x188BA4F60")]
		public MONRFXHCHJU(int a, JJQSBRMSMRE b, Action c, Func<bool> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4E30", Offset = "0x8BA3A30", VA = "0x188BA4E30", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NCVBGZRIGPO : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class DECXHZBLPAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public readonly MultiValueConfigProperty<float> VBXTTOVIIVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public readonly MultiValueConfigProperty<float> KSIQARUQMMH;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B996E0", Offset = "0x8B982E0", VA = "0x188B996E0")]
			public DECXHZBLPAP(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public sealed class DTDNEKJGIZD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly MultiValueConfigProperty<float> WOEVEHQTEZT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly MultiValueConfigProperty<float> AIIIMQPPVEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly MultiValueConfigProperty<bool> VWVCKXYUXQP;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8B99C70", Offset = "0x8B98870", VA = "0x188B99C70")]
			public DTDNEKJGIZD(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class QAKFWYCGYZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly MultiValueConfigProperty<float> PKJGYNOKQGB;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
			public QAKFWYCGYZS(MultiValueConfigProperty<float> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public NCVBGZRIGPO VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BA9480", Offset = "0x8BA8080", VA = "0x188BA9480")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8C20", Offset = "0x8BA7820", VA = "0x188BA8C20")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8A80", Offset = "0x8BA7680", VA = "0x188BA8A80")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8970", Offset = "0x8BA7570", VA = "0x188BA8970")]
			internal void OQBDQFGUNAU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly MultiValueConfigProperty<int> RLJOTOXGVDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly MultiValueConfigProperty<int> EOVWZCZBARS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly DECXHZBLPAP CTAKEIDECSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly DTDNEKJGIZD IKGMAPGAKJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly QAKFWYCGYZS HDNSHCMQJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly MultiValueConfigProperty<bool> CFSIAQOGJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly NCYSXEPJORK MPTSTFWZBXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly NCYSXEPJORK FWONIKFSIPW;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA52A0", Offset = "0x8BA3EA0", VA = "0x188BA52A0")]
		public NCVBGZRIGPO(MultiValueConfigProperty<float> vehicleMass, MultiValueConfigProperty<int> boostFuelCapacity, DECXHZBLPAP a, DTDNEKJGIZD b, QAKFWYCGYZS c, MultiValueConfigProperty<bool> canFrontWheelsSteer, NCYSXEPJORK d, NCYSXEPJORK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4FE0", Offset = "0x8BA3BE0", VA = "0x188BA4FE0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class NCYSXEPJORK : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly MultiValueConfigProperty<bool> NDUYMENPUTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly MultiValueConfigProperty<bool> AEMJIUKYVMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly MultiValueConfigProperty<float> ZUDRAUJJVJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly MultiValueConfigProperty<float> GZUUEKFFQRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly MultiValueConfigProperty<float> CXYZVFWPILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly MultiValueConfigProperty<float> GJDEPPRHFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MultiValueConfigProperty<float> MKNWHMUFRBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly MultiValueConfigProperty<float> YWVNGLTMRZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly MultiValueConfigProperty<float> BYDEYHJVOUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly MultiValueConfigProperty<float> MQPWKIJPZIT;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5D80", Offset = "0x8BA4980", VA = "0x188BA5D80")]
		public NCYSXEPJORK(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA55A0", Offset = "0x8BA41A0", VA = "0x188BA55A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class JGCMTNETZEC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public JGCMTNETZEC VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7F50", Offset = "0x8BA6B50", VA = "0x188BA7F50")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly MultiValueConfigProperty<float> OTRJDHVAWIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly MultiValueConfigProperty<float> PROTXZJDCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly MultiValueConfigProperty<float> SJCNQPWFKJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly MultiValueConfigProperty<float> CKKSBNEXSPY;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA90", Offset = "0x8B9D690", VA = "0x188B9EA90")]
		public JGCMTNETZEC(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E960", Offset = "0x8B9D560", VA = "0x188B9E960", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class FPDRBUIUFPZ : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly MultiValueConfigProperty<bool> YVPSJKMHPRP;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public FPDRBUIUFPZ(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B0D0", Offset = "0x8B99CD0", VA = "0x188B9B0D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class IPUOPGBCFVM : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public IPUOPGBCFVM VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B98E20", Offset = "0x8B97A20", VA = "0x188B98E20")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8B98930", Offset = "0x8B97530", VA = "0x188B98930")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly CEEMQSVBGSF QQZTYKUMYBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly FPDRBUIUFPZ XNUVCGQAQRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly MultiValueConfigProperty<bool> ACIUUVNJZUX;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DAF0", Offset = "0x8B9C6F0", VA = "0x188B9DAF0")]
		public IPUOPGBCFVM(CEEMQSVBGSF a, FPDRBUIUFPZ b, MultiValueConfigProperty<bool> hideProjector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D940", Offset = "0x8B9C540", VA = "0x188B9D940", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class JRYRBKNBHJJ : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public JRYRBKNBHJJ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8720", Offset = "0x8BA7320", VA = "0x188BA8720")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8BA84A0", Offset = "0x8BA70A0", VA = "0x188BA84A0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly MultiValueConfigProperty<bool> LYWMCJPXYZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly Option<bool> GUYUGBVASOW;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FD90", Offset = "0x8B9E990", VA = "0x188B9FD90")]
		public JRYRBKNBHJJ(Option<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FC60", Offset = "0x8B9E860", VA = "0x188B9FC60", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class UCEDAXPFPKT : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public UCEDAXPFPKT VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B99520", Offset = "0x8B98120", VA = "0x188B99520")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly IReadOnlyDictionary<PhysicsMode, string> LOCLOTDHAYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly MultiValueConfigProperty<PhysicsMode> YFDSPNFAXXX;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFDC0", Offset = "0x8BAE9C0", VA = "0x188BAFDC0")]
		public UCEDAXPFPKT(int a, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFB80", Offset = "0x8BAE780", VA = "0x188BAFB80", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class OTJAZFDDOJL : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public OTJAZFDDOJL VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4170", Offset = "0x8BA2D70", VA = "0x188BA4170")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly MultiValueConfigProperty<bool> TVUOXSZQAXU;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public OTJAZFDDOJL(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6F50", Offset = "0x8BA5B50", VA = "0x188BA6F50", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class CEEMQSVBGSF : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly string IKIIKSGZTKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly Action ZLHUJVNPVZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public readonly Func<Option<bool>> CHULDDZPPDE;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public CEEMQSVBGSF(string a, Action b, Func<Option<bool>> hasRecordableData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B94C30", Offset = "0x8B93830", VA = "0x188B94C30", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B94D80", Offset = "0x8B93980", VA = "0x188B94D80")]
		[CompilerGenerated]
		private bool TFVJTUKYDNU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class RoomKeyConfig : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public RoomKeyConfig VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA8640", Offset = "0x8BA7240", VA = "0x188BA8640")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BA85F0", Offset = "0x8BA71F0", VA = "0x188BA85F0")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly XHDLPCQWELZ QGVBRXJDNJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly Func<InventionPermission> VPUORQRWHAC;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public RoomKeyConfig(XHDLPCQWELZ roomKeyOptions, Func<InventionPermission> getLowestInventionPermission)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA920", Offset = "0x8BA9520", VA = "0x188BAA920", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class XHDLPCQWELZ : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public XHDLPCQWELZ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE6A0", Offset = "0x8BAD2A0", VA = "0x188BAE6A0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BACA30", Offset = "0x8BAB630", VA = "0x188BACA30")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public readonly bool DSDRMCLQPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly string ITGAZQYNRPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly Func<bool> HXWIEAXYDIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly Func<bool> BKJROCCEUAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly Action? SIVXYOHVOTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private readonly MultiValueConfigProperty<Guid> ISODCZDVQOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private readonly Action<JIXYMCFDVBA.RoomKeyPickerData> TWNESDZXBSU;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0CA0", Offset = "0x8BAF8A0", VA = "0x188BB0CA0")]
		public XHDLPCQWELZ(Option<bool> isTrialInvention, Func<bool> a, Func<bool> b, Action? onCreateKeyClick, MultiValueConfigProperty<Guid> equipLockKeyId, Action<JIXYMCFDVBA.RoomKeyPickerData> c, [Optional] string? lockLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0B90", Offset = "0x8BAF790", VA = "0x188BB0B90", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class LIBLREGRKYW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public readonly IReadOnlyList<(Guid, string)> GQMBGUXUOPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public readonly ConfigProperty<IReadOnlyCollection<Guid>> NGRPTMWFSVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public readonly Action<JIXYMCFDVBA.MultiTogglePickerData> KBLSKQKKMUQ;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3FA0", Offset = "0x8BA2BA0", VA = "0x188BA3FA0")]
		public LIBLREGRKYW(IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<JIXYMCFDVBA.MultiTogglePickerData> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class PVUFSJXWIWC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public PVUFSJXWIWC VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8B93FC0", Offset = "0x8B92BC0", VA = "0x188B93FC0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly MultiValueConfigProperty<int> XBKNYIFZOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly MultiValueConfigProperty<int> CGFQZQWGUUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly MultiValueConfigProperty<int> CFPWHWOOSMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly MultiValueConfigProperty<int> CFVDFDIMBXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly MultiValueConfigProperty<string> TKQPISDHOYV;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA71A0", Offset = "0x8BA5DA0", VA = "0x188BA71A0")]
		public PVUFSJXWIWC(MultiValueConfigProperty<int> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<int> d, MultiValueConfigProperty<string> stateName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7080", Offset = "0x8BA5C80", VA = "0x188BA7080", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class ATZJGCJAZVP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public ATZJGCJAZVP VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8B98EE0", Offset = "0x8B97AE0", VA = "0x188B98EE0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly MultiValueConfigProperty<float> ATRUCFPDRHG;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public ATZJGCJAZVP(MultiValueConfigProperty<float> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B92230", Offset = "0x8B90E30", VA = "0x188B92230", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class BQUCEDXEPVW : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public BQUCEDXEPVW VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8BA42C0", Offset = "0x8BA2EC0", VA = "0x188BA42C0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly MultiValueConfigProperty<bool> ZIFXATWYRQE;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public BQUCEDXEPVW(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B93290", Offset = "0x8B91E90", VA = "0x188B93290", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class JBDSORMJCPC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public JBDSORMJCPC VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8BA13D0", Offset = "0x8B9FFD0", VA = "0x188BA13D0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly IReadOnlyDictionary<TrailWidthCurveTypes, string> QMUTCJXJTOV;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly IReadOnlyDictionary<TrailGradientTypes, string> ORRONJQVBWD;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly IReadOnlyDictionary<TrailMaterialTypes, string> RSDVYMEBIPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly MultiValueConfigProperty<bool> MWXHYCRWOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly MultiValueConfigProperty<bool> HCMYDKZLJNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly MultiValueConfigProperty<float> LUZYGONAIIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly MultiValueConfigProperty<float> GNBVKEMCBSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly MultiValueConfigProperty<float> LEFHPRLRDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly MultiValueConfigProperty<float> QOXTLJSFZEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly MultiValueConfigProperty<TrailWidthCurveTypes> MMXBJRDWEFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private readonly MultiValueConfigProperty<TrailGradientTypes> FBAWMQEAERF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly MultiValueConfigProperty<TrailMaterialTypes> QKYJCQKQVCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private readonly VQUHSHZISWR? MENVSXWBAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly WLRFULYAZEC OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E7A0", Offset = "0x8B9D3A0", VA = "0x188B9E7A0")]
		public JBDSORMJCPC(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<TrailWidthCurveTypes> g, MultiValueConfigProperty<TrailGradientTypes> h, MultiValueConfigProperty<TrailMaterialTypes> i, VQUHSHZISWR? colorableOptions, WLRFULYAZEC syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E230", Offset = "0x8B9CE30", VA = "0x188B9E230", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class DOLZHYYIZPP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class CLOJKKCVFXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public DOLZHYYIZPP VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public (Color32 x, Color32 y, Color32 z) OUSVKCCAGYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public Func<bool> VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public Func<bool> VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public Action VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public Action VPAJZRIHYUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CLOJKKCVFXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8B96FA0", Offset = "0x8B95BA0", VA = "0x188B96FA0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8B966F0", Offset = "0x8B952F0", VA = "0x188B966F0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8B97860", Offset = "0x8B96460", VA = "0x188B97860")]
			internal bool ORLZXAQCBCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8B95E00", Offset = "0x8B94A00", VA = "0x188B95E00")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8B97820", Offset = "0x8B96420", VA = "0x188B97820")]
			internal bool ORGSZTWERQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8B95C90", Offset = "0x8B94890", VA = "0x188B95C90")]
			internal void OQBDQFGUNAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8B97380", Offset = "0x8B95F80", VA = "0x188B97380")]
			internal void ORBMCNCHIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8B971E0", Offset = "0x8B95DE0", VA = "0x188B971E0")]
			internal void OQWFFGIJYUE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly Func<bool>? LDMOXPJGMWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly Func<bool> GHYVHNEZXMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly Func<bool> JHJPHGHCOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly MultiValueConfigProperty<float> DKAJEXTYQAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly MultiValueConfigProperty<float> DKFQCENVZLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly MultiValueConfigProperty<float> DKKWZLHTIXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private readonly MultiValueConfigProperty<float> KRDKKBSDPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly MultiValueConfigProperty<float> KQYDMUYGGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly MultiValueConfigProperty<float> KQSWPOEIWUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly Func<bool> GVDKOURDYUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private readonly Func<bool> KCQAUEKIHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private readonly MultiValueConfigProperty<float> AEVBOHSLGZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly MultiValueConfigProperty<float> AEPURAYNXNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly MultiValueConfigProperty<float> AFFPIVGFZVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly MultiValueConfigProperty<float> QBVKKGIEAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly MultiValueConfigProperty<float> QCARHNCBKAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly MultiValueConfigProperty<float> QBKWPSUJHSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly Func<bool> PUMQPMNOJZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly Func<bool> MQYAQDYKTDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly MultiValueConfigProperty<float> HWAGAKVBBPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly MultiValueConfigProperty<float> HVUZDEBDSEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly MultiValueConfigProperty<float> HWKTUYIVUMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly MultiValueConfigProperty<float> VPXZKWVFZCL;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B998F0", Offset = "0x8B984F0", VA = "0x188B998F0")]
		public DOLZHYYIZPP(Func<bool> supportsTranslation, Func<bool> isWorldPositionVisible, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, Func<bool> supportsRotation, Func<bool> isWorldRotationVisible, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j, MultiValueConfigProperty<float> k, MultiValueConfigProperty<float> l, Func<bool> supportsScaling, Func<bool> supportsDeformation, MultiValueConfigProperty<float> m, MultiValueConfigProperty<float> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, [Optional] Func<bool>? isFoldoutVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8B99750", Offset = "0x8B98350", VA = "0x188B99750", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class GIOSQORELPI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public GIOSQORELPI VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7C40", Offset = "0x8BA6840", VA = "0x188BA7C40")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static readonly IReadOnlyDictionary<GrabberAttachmentMode, string> VVPKCYMBPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly MultiValueConfigProperty<GrabberAttachmentMode> PSXWHFVRQON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly MultiValueConfigProperty<bool> JATISYMOUAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly WLRFULYAZEC OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B710", Offset = "0x8B9A310", VA = "0x188B9B710")]
		public GIOSQORELPI(MultiValueConfigProperty<GrabberAttachmentMode> a, MultiValueConfigProperty<bool> b, WLRFULYAZEC syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B4D0", Offset = "0x8B9A0D0", VA = "0x188B9B4D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class KATTCPDOLJE : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly IEnumerable<VKVUVWBSMVI> NDCAHZERKWA;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public KATTCPDOLJE(IEnumerable<VKVUVWBSMVI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FF70", Offset = "0x8B9EB70", VA = "0x188B9FF70", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class BIIVKRGTUCL : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public BIIVKRGTUCL VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8B93B80", Offset = "0x8B92780", VA = "0x188B93B80")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8B93900", Offset = "0x8B92500", VA = "0x188B93900")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8B93580", Offset = "0x8B92180", VA = "0x188B93580")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public readonly Option<bool> NMBACVXYAGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly MultiValueConfigProperty<float> GHCQCSEPXDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly MultiValueConfigProperty<bool> BKOKTZRWDRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly MultiValueConfigProperty<bool> ZKGQAOSCRQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly MultiValueConfigProperty<bool> YLEHUDZNUCE;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8B931D0", Offset = "0x8B91DD0", VA = "0x188B931D0")]
		public BIIVKRGTUCL(Option<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8B92FB0", Offset = "0x8B91BB0", VA = "0x188B92FB0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class KRDQGDVMKLI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public KRDQGDVMKLI VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAD9B0", Offset = "0x8BAC5B0", VA = "0x188BAD9B0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly Dictionary<int, string> KKSPNEPIWKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly MultiValueConfigProperty<int> OARQVGUCYBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private readonly MultiValueConfigProperty<float> DPVZBIKRDLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private readonly MultiValueConfigProperty<bool> REFDNOBGARD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private readonly MultiValueConfigProperty<bool> QPXECXMHGLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private readonly MultiValueConfigProperty<bool> ZMGHNVDDREJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private readonly MultiValueConfigProperty<int> JVEFKRSFJKJ;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8BA08A0", Offset = "0x8B9F4A0", VA = "0x188BA08A0")]
		public KRDQGDVMKLI(MultiValueConfigProperty<int> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0680", Offset = "0x8B9F280", VA = "0x188BA0680", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class WHHSLUFXGJR : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public WHHSLUFXGJR VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8BB2400", Offset = "0x8BB1000", VA = "0x188BB2400")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8BB10F0", Offset = "0x8BAFCF0", VA = "0x188BB10F0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static readonly Dictionary<int, string> KKSPNEPIWKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly Action? BMZYRDTMDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private readonly int LUPOWOAELGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private readonly MultiValueConfigProperty<int> OARQVGUCYBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private readonly MultiValueConfigProperty<float> DCVWHWSGJYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private readonly MultiValueConfigProperty<bool> JTQFLJBYYPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly MultiValueConfigProperty<bool> ZMGHNVDDREJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private readonly MultiValueConfigProperty<int> JVEFKRSFJKJ;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0880", Offset = "0x8BAF480", VA = "0x188BB0880")]
		public WHHSLUFXGJR(Action? openAnimationControls, int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0660", Offset = "0x8BAF260", VA = "0x188BB0660", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class RLOTSJGQUBO : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public RLOTSJGQUBO VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8B990F0", Offset = "0x8B97CF0", VA = "0x188B990F0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8B98B10", Offset = "0x8B97710", VA = "0x188B98B10")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly BIIVKRGTUCL OELCOBQGUYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private readonly MultiValueConfigProperty<float> NFHBMSYYQYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly Option<UnityEngine.Vector2> FCMYWFXZFYM;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA8A0", Offset = "0x8BA94A0", VA = "0x188BAA8A0")]
		public RLOTSJGQUBO(BIIVKRGTUCL acceleratedMovementOptions, MultiValueConfigProperty<float> a, Option<UnityEngine.Vector2> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA780", Offset = "0x8BA9380", VA = "0x188BAA780", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class XEXCUELZQNO : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public XEXCUELZQNO VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8BAD290", Offset = "0x8BABE90", VA = "0x188BAD290")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC630", Offset = "0x8BAB230", VA = "0x188BAC630")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC3C0", Offset = "0x8BAAFC0", VA = "0x188BAC3C0")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private readonly BIIVKRGTUCL OELCOBQGUYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly MultiValueConfigProperty<float> NFHBMSYYQYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly MultiValueConfigProperty<float> MSCOANEVGVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly MultiValueConfigProperty<float> XDOEMTDKOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private readonly MultiValueConfigProperty<float> QZPMIFRRTMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private readonly Option<UnityEngine.Vector2> FCMYWFXZFYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private readonly Option<float> KJUQALHMZJZ;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0AA0", Offset = "0x8BAF6A0", VA = "0x188BB0AA0")]
		public XEXCUELZQNO(BIIVKRGTUCL acceleratedMovementOptions, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, Option<UnityEngine.Vector2> c, MultiValueConfigProperty<float> d, Option<float> e, MultiValueConfigProperty<float> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0980", Offset = "0x8BAF580", VA = "0x188BB0980", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class ZCRZRRANCIG : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public ZCRZRRANCIG VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8BA44D0", Offset = "0x8BA30D0", VA = "0x188BA44D0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private readonly BIIVKRGTUCL OELCOBQGUYJ;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ZCRZRRANCIG(BIIVKRGTUCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2D50", Offset = "0x8BB1950", VA = "0x188BB2D50", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class CETSGMRIYVE : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public CETSGMRIYVE VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8B94540", Offset = "0x8B93140", VA = "0x188B94540")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private readonly Option<float> XBYYZEYDXHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private readonly MultiValueConfigProperty<float> LOTERXSXKPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private readonly MultiValueConfigProperty<float> NWDPZYHFWZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly MultiValueConfigProperty<float> CHDCIUNJBJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly BIIVKRGTUCL OELCOBQGUYJ;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B94F20", Offset = "0x8B93B20", VA = "0x188B94F20")]
		public CETSGMRIYVE(Option<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, BIIVKRGTUCL acceleratedMovementOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8B94DE0", Offset = "0x8B939E0", VA = "0x188B94DE0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class HPBOIJTAZRR : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public HPBOIJTAZRR VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x8B9B7A0", Offset = "0x8B9A3A0", VA = "0x188B9B7A0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private static readonly Dictionary<GlassPaneShapeType, string> MRLVOSBFDRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private readonly MultiValueConfigProperty<float> YRIJGFHYOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private readonly Func<bool> CMKASHTAZFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly MultiValueConfigProperty<GlassPaneShapeType> BSWFOPYGRRY;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D020", Offset = "0x8B9BC20", VA = "0x188B9D020")]
		public HPBOIJTAZRR(MultiValueConfigProperty<float> a, Func<bool> isAllConfigurableShapes, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8B9CE00", Offset = "0x8B9BA00", VA = "0x188B9CE00", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class RKYWCWUSVML : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public RKYWCWUSVML VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4410", Offset = "0x8BA3010", VA = "0x188BA4410")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private readonly JJQSBRMSMRE ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public RKYWCWUSVML(JJQSBRMSMRE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA650", Offset = "0x8BA9250", VA = "0x188BAA650", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class SPFXOBTWUSM
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public static readonly IReadOnlyDictionary<InteractionFilterMode, string> LKCFYGOLEWF;
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public sealed class YRKXYVISDVY : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public YRKXYVISDVY VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8BA72F0", Offset = "0x8BA5EF0", VA = "0x188BA72F0")]
			internal bool GBDXPEDZVFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7560", Offset = "0x8BA6160", VA = "0x188BA7560")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7420", Offset = "0x8BA6020", VA = "0x188BA7420")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7360", Offset = "0x8BA5F60", VA = "0x188BA7360")]
			internal void OQBDQFGUNAU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private readonly MultiValueConfigProperty<bool> ETANKQZCHMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> OGJTCBEXROY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly LIBLREGRKYW? OENNPGBOEBE;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2CC0", Offset = "0x8BB18C0", VA = "0x188BB2CC0")]
		public YRKXYVISDVY(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<InteractionFilterMode> c, LIBLREGRKYW? rolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8BB29A0", Offset = "0x8BB15A0", VA = "0x188BB29A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class DWZHXDEAZBT : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public DWZHXDEAZBT VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8BA7280", Offset = "0x8BA5E80", VA = "0x188BA7280")]
			internal bool GBDXPEDZVFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x8BA76A0", Offset = "0x8BA62A0", VA = "0x188BA76A0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private readonly string BSDOXQGACCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private readonly MultiValueConfigProperty<bool> ETANKQZCHMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> OGJTCBEXROY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private readonly EJFJMAXGDWI? FRAQVLPEBJQ;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A660", Offset = "0x8B99260", VA = "0x188B9A660")]
		public DWZHXDEAZBT(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<InteractionFilterMode> b, EJFJMAXGDWI tagsOptions, string primaryLabel = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A2D0", Offset = "0x8B98ED0", VA = "0x188B9A2D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class HWEIVAODFCM : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public HWEIVAODFCM VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8B98E80", Offset = "0x8B97A80", VA = "0x188B98E80")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private readonly string BSDOXQGACCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> OGJTCBEXROY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private readonly EJFJMAXGDWI? FRAQVLPEBJQ;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D880", Offset = "0x8B9C480", VA = "0x188B9D880")]
		public HWEIVAODFCM(MultiValueConfigProperty<InteractionFilterMode> filterMode, EJFJMAXGDWI a, string b = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D680", Offset = "0x8B9C280", VA = "0x188B9D680", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public interface JIXYMCFDVBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public enum ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Standard,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Alphanumeric
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public readonly struct ColorPickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0xFA9B70", Offset = "0xFA8770", VA = "0x180FA9B70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Action<int> ColorSetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool AllowCustomColors
			{
				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0xB1A400", Offset = "0xB19000", VA = "0x180B1A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool AllowDefaultColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x131B9B0", Offset = "0x131A5B0", VA = "0x18131B9B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x1492410", Offset = "0x1491010", VA = "0x181492410")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public readonly struct MaterialPickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public Func<int> MaterialGetter
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0xFA9B70", Offset = "0xFA8770", VA = "0x180FA9B70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Action<int> MaterialSetter
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool AllowDefaultMaterial
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xB13A80", Offset = "0xB12680", VA = "0x180B13A80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public bool ForceTransparentQueue
			{
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x1697C10", Offset = "0x1696810", VA = "0x181697C10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x1697C00", Offset = "0x1696800", VA = "0x181697C00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool CameraLit
			{
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x1A87820", Offset = "0x1A86420", VA = "0x181A87820")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x1A87680", Offset = "0x1A86280", VA = "0x181A87680")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public readonly struct RoomRolePickerData
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public Func<Guid> RoleGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Action<Guid> RoleSetter
			{
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xFA9B70", Offset = "0xFA8770", VA = "0x180FA9B70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public readonly struct RoomKeyPickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Func<Guid> KeyGetter
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xFA9B70", Offset = "0xFA8770", VA = "0x180FA9B70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public Action<Guid> KeySetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public readonly struct MultiTogglePickerData
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public Func<IReadOnlyCollection<int>> GetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0xFA9B70", Offset = "0xFA8770", VA = "0x180FA9B70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public Action<IReadOnlyCollection<int>> SetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public Func<IReadOnlyList<string>> GetValueNames
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class JMQFNFSZQVK<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public IReadOnlyDictionary<a, string> RRNCIQVDYDJ;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public JMQFNFSZQVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5679DB0", Offset = "0x56789B0", VA = "0x185679DB0")]
			internal string NWVIHJFFSBG(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class MLUWZADUFUZ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public Func<a, string> JFLUCRDGRNY;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public MLUWZADUFUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5EB9600", Offset = "0x5EB8200", VA = "0x185EB9600")]
			internal string NWVIHJFFSBG(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class XCBPZDSYVCO<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public IReadOnlyList<(a, string)> RRNCIQVDYDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public Dictionary<a, int> QAATSQFQXCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public Func<a, int> VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			public Func<int, a> VPAJZRIHYUN;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XCBPZDSYVCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4410CD0", Offset = "0x440F8D0", VA = "0x184410CD0")]
			internal IReadOnlyList<string> KIJRBTOTURB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4410C00", Offset = "0x440F800", VA = "0x184410C00")]
			internal IReadOnlyCollection<int> KIEKEMUWLFS(IReadOnlyCollection<a> values)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4411300", Offset = "0x440FF00", VA = "0x184411300")]
			internal int KJESQUQJGKL(a a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x4411520", Offset = "0x4410120", VA = "0x184411520")]
			internal IReadOnlyCollection<a> KJPGLIEDZHD(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4411230", Offset = "0x440FE30", VA = "0x184411230")]
			internal a KIZLTNWLWZC(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class LCAFIZDCZRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			public IReadOnlyList<(int, string)> RRNCIQVDYDJ;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCAFIZDCZRS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3C40", Offset = "0x8BA2840", VA = "0x188BA3C40")]
			internal IReadOnlyList<string> ORQZODXEOUF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BA39E0", Offset = "0x8BA25E0", VA = "0x188BA39E0")]
			internal IReadOnlyCollection<int> ORLSQXDHFIW(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8BA2D10", Offset = "0x8BA1910", VA = "0x188BA2D10")]
			internal int OQLKEPHUKED(IReadOnlyCollection<int> a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class LCFMGFXAJDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			public int UPVGGEVLAIE;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCFMGFXAJDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3EA0", Offset = "0x8BA2AA0", VA = "0x188BA3EA0")]
			internal bool OQVXZCVPDAV(IndexValuePair<(int, string)> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class LCKTDMQXSOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			public int UPVGGEVLAIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			public LCAFIZDCZRS JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCKTDMQXSOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3EB0", Offset = "0x8BA2AB0", VA = "0x188BA3EB0")]
			internal void OSWOXSMOTKH(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class HPUDPQOSLZV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			public IReadOnlyList<(Guid, string)> RRNCIQVDYDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public Dictionary<Guid, int> QAATSQFQXCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public Func<Guid, int> VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public Func<int, Guid> VPAJZRIHYUN;

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HPUDPQOSLZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x8B9D550", Offset = "0x8B9C150", VA = "0x188B9D550")]
			internal IReadOnlyList<string> NGQVJZHGILH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B9D480", Offset = "0x8B9C080", VA = "0x188B9D480")]
			internal IReadOnlyCollection<int> NGLOMSNIYZY(IReadOnlyCollection<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B9D420", Offset = "0x8B9C020", VA = "0x188B9D420")]
			internal int NFVTUYFQWRX(Guid a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8B9D280", Offset = "0x8B9BE80", VA = "0x188B9D280")]
			internal IReadOnlyCollection<Guid> NFLGAKRWDVF(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8B9D350", Offset = "0x8B9BF50", VA = "0x188B9D350")]
			internal Guid NFQMXRLTNGO(int a)
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EFE0", Offset = "0x8B9DBE0", VA = "0x188B9EFE0", Slot = "0")]
		JIXYMCFDVBA JZOCXFQRDRV(bool a, Action b, [Optional] Action? falseAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EB40", Offset = "0x8B9D740", VA = "0x188B9EB40", Slot = "1")]
		JIXYMCFDVBA Add(JJQSBRMSMRE? provider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JIXYMCFDVBA FTJIXTVSINQ();

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "3")]
		JIXYMCFDVBA NTOGMFNSNKN(string a, int b, Action c, [Optional] Func<bool>? isVisibleGetter, bool d = true, InventionPermission e = InventionPermission.EditAndSave);

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "4")]
		JIXYMCFDVBA? YCQZKWCCBAQ(string primaryLabel, MultiValueConfigProperty<string> property, int a = 1000, [Optional] string? b, [Optional] Func<bool>? c, ContentType d = ContentType.Standard, [Optional] string? e);

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "5")]
		JIXYMCFDVBA CJOOHSMJUMR(string a, MultiValueConfigProperty<string> property, int b = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] string? infoText);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "6")]
		JIXYMCFDVBA CJBHYIPUKHV(string a, MultiValueConfigProperty<int> property, [Optional] int? b, [Optional] int? c, [Optional] string? unitLabel, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		JIXYMCFDVBA? HYJVQFBIGOH(string primaryLabel, float a, float b, MultiValueConfigProperty<float> property, int c = 2, [Optional] string? d, [Optional] string? e, [Optional] Func<bool>? f, [Optional] string? g);

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		JIXYMCFDVBA? ZOFZFPCQXAO(string primaryLabel, MultiValueConfigProperty<float> property, [Optional] Func<bool>? a, [Optional] Func<bool>? b, [Optional] Color? c, [Optional] float? d, [Optional] float? e, bool f = false, [Optional] string? g, [Optional] string? h);

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F400", Offset = "0x8B9E000", VA = "0x188B9F400", Slot = "9")]
		JIXYMCFDVBA ZNPAFWSZDIR(string primaryLabel, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, [Optional] (Color x, Color y, Color z)? bgColors, [Optional] Func<bool>? isVisibleGetter, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		JIXYMCFDVBA? CWZTKQHQCDK(string primaryLabel, MultiValueConfigProperty<bool> property, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e);

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C44750", Offset = "0x3C43350", VA = "0x183C44750", Slot = "11")]
		JIXYMCFDVBA GXGVKQKZLAN<a>(string a, MultiValueConfigProperty<a> property, IReadOnlyDictionary<a, string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool c = true, bool d = false) where a : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C44A90", Offset = "0x3C43690", VA = "0x183C44A90", Slot = "12")]
		JIXYMCFDVBA GXGVKQKZLAN<b>(string a, MultiValueConfigProperty<b> property, IReadOnlyList<b> b, Func<b, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false) where b : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "13")]
		JIXYMCFDVBA GXGVKQKZLAN(string a, MultiValueConfigProperty<object> property, IReadOnlyList<object> b, Func<object, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "14")]
		JIXYMCFDVBA? IMPRBOJUUGA(Action panelAction, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "15")]
		JIXYMCFDVBA EZSYYECUSYU(string a, ConfigProperty<IReadOnlyList<string>> persistentProperty, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeProperty, [Optional] string? secondaryLabel, [Optional] Func<string, bool>? tagValidator, int b = 1000, [Optional] Func<bool>? isModifiedGetter);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "16")]
		JIXYMCFDVBA? EYUECXFZIBO(string primaryLabel, Action? a, [Optional] Func<bool>? b, [Optional] Func<bool>? c);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "17")]
		JIXYMCFDVBA ODODELBFJSN(string a, string b, Action c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "18")]
		JIXYMCFDVBA JSRNGNQVMOF(string a, ConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "19")]
		JIXYMCFDVBA JSRNGNQVMOF(string a, MultiValueConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "20")]
		JIXYMCFDVBA GGPBXJAZYEH(string a, ConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "21")]
		JIXYMCFDVBA GGPBXJAZYEH(string a, MultiValueConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "22")]
		JIXYMCFDVBA IUAMFIDCJNT(string a, ConfigProperty<Guid> property, Action<RoomRolePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		JIXYMCFDVBA HRWDNXVMWFS(string a, MultiValueConfigProperty<Guid> property, Action<RoomKeyPickerData> b, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		JIXYMCFDVBA FCJKJGXIUFB(string a, Func<IReadOnlyList<string>> b, ConfigProperty<IReadOnlyCollection<int>> property, Action<MultiTogglePickerData> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C43D90", Offset = "0x3C42990", VA = "0x183C43D90", Slot = "25")]
		JIXYMCFDVBA FCJKJGXIUFB<T>(string a, IReadOnlyList<(T, string)> items, ConfigProperty<IReadOnlyCollection<T>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F030", Offset = "0x8B9DC30", VA = "0x188B9F030", Slot = "26")]
		JIXYMCFDVBA VMJUIVFQQAZ(string a, IReadOnlyList<(int, string)> items, ConfigProperty<int> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EBF0", Offset = "0x8B9D7F0", VA = "0x188B9EBF0", Slot = "27")]
		JIXYMCFDVBA IUAMFIDCJNT(string a, IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		JIXYMCFDVBA YYBZPJIGQGY(string a, [Optional] Func<bool>? isVisibleGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public interface JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BLCUAMXKNAL(JIXYMCFDVBA a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class FIEVKMQDTYX : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public FIEVKMQDTYX VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE030", Offset = "0x8BACC30", VA = "0x188BAE030")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private readonly MultiValueConfigProperty<float> KSRJTRXJQPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private readonly System.Numerics.Vector2 EZGZVGZQRYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private readonly MultiValueConfigProperty<float> HYHYISZPVJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private readonly System.Numerics.Vector2 GVFUYXCYVVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private readonly MMYCFOIHXUB EGSEDFQSMUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private readonly VQUHSHZISWR? JVQEJLFQAQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private readonly WLRFULYAZEC EDPYBPLBPTO;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B010", Offset = "0x8B99C10", VA = "0x188B9B010")]
		public FIEVKMQDTYX(MultiValueConfigProperty<float> a, System.Numerics.Vector2 b, MultiValueConfigProperty<float> c, System.Numerics.Vector2 d, MMYCFOIHXUB sandboxDynamicLightOptions, VQUHSHZISWR? sandboxColorableConfig, WLRFULYAZEC syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AEE0", Offset = "0x8B99AE0", VA = "0x188B9AEE0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class MBDHWAGASMN : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public MBDHWAGASMN VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4470", Offset = "0x8BA3070", VA = "0x188BA4470")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly MMYCFOIHXUB ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public MBDHWAGASMN(MMYCFOIHXUB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4740", Offset = "0x8BA3340", VA = "0x188BA4740", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class MMYCFOIHXUB : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private readonly MultiValueConfigProperty<bool> OEBPBERIXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private readonly MultiValueConfigProperty<float> QSGWHVQKLTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private readonly System.Numerics.Vector2 HGYHDYNCCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private readonly MultiValueConfigProperty<float> EWQRPURMFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private readonly System.Numerics.Vector2 GHBBTAKKKCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private readonly MultiValueConfigProperty<float> LLWCHFCVXWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private readonly System.Numerics.Vector2 ECRXXHLLTWG;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4D50", Offset = "0x8BA3950", VA = "0x188BA4D50")]
		public MMYCFOIHXUB(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<float> d, System.Numerics.Vector2 e, MultiValueConfigProperty<float> f, System.Numerics.Vector2 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA49A0", Offset = "0x8BA35A0", VA = "0x188BA49A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4D20", Offset = "0x8BA3920", VA = "0x188BA4D20")]
		[CompilerGenerated]
		private bool KPBKFESWJOW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4D30", Offset = "0x8BA3930", VA = "0x188BA4D30")]
		[CompilerGenerated]
		private bool KPGRCLMTTAF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class MEMPKRQPMGU : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			public MEMPKRQPMGU VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8B98D70", Offset = "0x8B97970", VA = "0x188B98D70")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private readonly MMYCFOIHXUB PMYYTUMMFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private readonly VQUHSHZISWR? MENVSXWBAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private readonly WLRFULYAZEC OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public MEMPKRQPMGU(MMYCFOIHXUB a, VQUHSHZISWR? colorableOptions, WLRFULYAZEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4870", Offset = "0x8BA3470", VA = "0x188BA4870", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HFEJWCEEDYS : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public HFEJWCEEDYS VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4530", Offset = "0x8BA3130", VA = "0x188BA4530")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly IUYSLHQCMBG ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public HFEJWCEEDYS(IUYSLHQCMBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B9CCD0", Offset = "0x8B9B8D0", VA = "0x188B9CCD0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class IUYSLHQCMBG : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly MultiValueConfigProperty<float> KSRJTRXJQPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly System.Numerics.Vector2 EZGZVGZQRYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly MMYCFOIHXUB PMYYTUMMFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private readonly VQUHSHZISWR? MENVSXWBAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private readonly WLRFULYAZEC? OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E190", Offset = "0x8B9CD90", VA = "0x188B9E190")]
		public IUYSLHQCMBG(MultiValueConfigProperty<float> angle, System.Numerics.Vector2 a, MMYCFOIHXUB dynamicLightOptions, VQUHSHZISWR? b, WLRFULYAZEC? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E060", Offset = "0x8B9CC60", VA = "0x188B9E060", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class ZEHQRQUODBP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public ZEHQRQUODBP VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BA86A0", Offset = "0x8BA72A0", VA = "0x188BA86A0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly IUYSLHQCMBG PMYYTUMMFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private readonly JZAXSCERBEA UDHZVNYPSWZ;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public ZEHQRQUODBP(IUYSLHQCMBG a, JZAXSCERBEA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2E70", Offset = "0x8BB1A70", VA = "0x188BB2E70", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class JRHGMINKFNO : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public sealed class BQVKGHERCSO
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public string QMZMPPIFWAW
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public bool[] RJFOCVBXZWO
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001F7")]
				[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int FIHDNTKDJKR
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public float PYSVOKZCIXA
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0xB6A410", Offset = "0xB69010", VA = "0x180B6A410")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0xB6A0E0", Offset = "0xB68CE0", VA = "0x180B6A0E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int AXUVQJAOTPO
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0xB1FE50", Offset = "0xB1EA50", VA = "0x180B1FE50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BQVKGHERCSO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public sealed class HZLKMKPAULX
		{
			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public string QMZMPPIFWAW
			{
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public ConfigProperty<int> JJFMUAEDKSU
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0xF191F0", Offset = "0xF17DF0", VA = "0x180F191F0")]
				[CompilerGenerated]
				get
				{
					return default(ConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x6931700", Offset = "0x6930300", VA = "0x186931700")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public MultiValueConfigProperty<int> NWWJWJBCTSH
			{
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x3063E90", Offset = "0x3062A90", VA = "0x183063E90")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000204")]
				[Cpp2IlInjected.Address(RVA = "0x8B9D920", Offset = "0x8B9C520", VA = "0x188B9D920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public MultiValueConfigProperty<float> VKXVPHMWDKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000205")]
				[Cpp2IlInjected.Address(RVA = "0x3064660", Offset = "0x3063260", VA = "0x183064660")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000206")]
				[Cpp2IlInjected.Address(RVA = "0x8B9D900", Offset = "0x8B9C500", VA = "0x188B9D900")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public MultiValueConfigProperty<float> AZHHPJOUDEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000207")]
				[Cpp2IlInjected.Address(RVA = "0x5E91E00", Offset = "0x5E90A00", VA = "0x185E91E00")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000208")]
				[Cpp2IlInjected.Address(RVA = "0x5E91EE0", Offset = "0x5E90AE0", VA = "0x185E91EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HZLKMKPAULX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			public JRHGMINKFNO VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public int ICNMYOLGFQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC1D0", Offset = "0x8BAADD0", VA = "0x188BAC1D0")]
			internal void OQBDQFGUNAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class TMAKNHIIIIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			public int DMPVJOPMYMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027E")]
			public TMFRKOCFRTN JZUGHOQQQFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public Func<BQVKGHERCSO, bool> VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public Func<int, int> VPAJZRIHYUN;

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMAKNHIIIIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB6D0", Offset = "0x8BAA2D0", VA = "0x188BAB6D0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x8BAC190", Offset = "0x8BAAD90", VA = "0x188BAC190")]
			internal bool ORLZXAQCBCF(BQVKGHERCSO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x8BABFE0", Offset = "0x8BAABE0", VA = "0x188BABFE0")]
			internal int OQWFFGIJYUE(int a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class TMQFFBQAKQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			public int HXLWPBHUDSJ;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMQFFBQAKQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE910", Offset = "0x8BAD510", VA = "0x188BAE910")]
			internal bool OPAVDXLHRWB(BQVKGHERCSO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> EGKHWRYQRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private readonly IReadOnlyList<HZLKMKPAULX> KBNPOBNHGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private readonly IReadOnlyList<BQVKGHERCSO> GQVIIZAXCLF;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7931910", Offset = "0x7930510", VA = "0x187931910")]
		public JRHGMINKFNO(int a, Action<JIXYMCFDVBA.ColorPickerData> b, IReadOnlyList<HZLKMKPAULX> c, IReadOnlyList<BQVKGHERCSO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F980", Offset = "0x8B9E580", VA = "0x188B9F980", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class GXQFUBOFYTP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public GXQFUBOFYTP VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8B979E0", Offset = "0x8B965E0", VA = "0x188B979E0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x8B978A0", Offset = "0x8B964A0", VA = "0x188B978A0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private readonly ConfigProperty<int> ZHCXYTATFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> EGKHWRYQRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private readonly MultiValueConfigProperty<float> QSGWHVQKLTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private readonly MultiValueConfigProperty<float> MILQLLREBIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private readonly MultiValueConfigProperty<float> KORIHEEPHIE;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8B9CC00", Offset = "0x8B9B800", VA = "0x188B9CC00")]
		public GXQFUBOFYTP(int a, ConfigProperty<int> b, Action<JIXYMCFDVBA.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8B9CAD0", Offset = "0x8B9B6D0", VA = "0x188B9CAD0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class DTSHJOTBHEN : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class VOMCTXEGQPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public DTSHJOTBHEN VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public Action VMERMAPSWRR;

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VOMCTXEGQPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x8BC4310", Offset = "0x8BC2F10", VA = "0x188BC4310")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8BC41D0", Offset = "0x8BC2DD0", VA = "0x188BC41D0")]
			internal void OOVOGQRKIKS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static readonly System.Numerics.Vector2 FNKOYEPFAOT;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly System.Numerics.Vector2 QLZZEBCATCB;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private static System.Numerics.Vector2 XGYENJYBHJA;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private static System.Numerics.Vector2 FHAGSSMIYTU;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private static System.Numerics.Vector2 WZEJGGFGXGL;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private static System.Numerics.Vector2 ULXQCVLMHYR;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private static System.Numerics.Vector2 YACJOAOTQOP;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private static System.Numerics.Vector2 EQMYUHTKTLT;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static System.Numerics.Vector2 HAJVFZZFKDH;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private static System.Numerics.Vector2 ZYCXXZSACQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly ConfigProperty<int> ZHCXYTATFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> EGKHWRYQRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private readonly MultiValueConfigProperty<float> ZFUELKUSZZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private readonly MultiValueConfigProperty<float> IIODQSIJIYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private readonly MultiValueConfigProperty<float> IKKBBEIOIGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private readonly MultiValueConfigProperty<float> ENPJPUENTWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private readonly MultiValueConfigProperty<float> GZEUBIBSITV;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A1B0", Offset = "0x8B98DB0", VA = "0x188B9A1B0")]
		public DTSHJOTBHEN(int a, ConfigProperty<int> b, Action<JIXYMCFDVBA.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8B99D00", Offset = "0x8B98900", VA = "0x188B99D00", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8B99E30", Offset = "0x8B98A30", VA = "0x188B99E30")]
		private static float FDTRPIIGCIZ(float a, System.Numerics.Vector2 b, System.Numerics.Vector2 c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class DRIPUGVYHXW : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public DRIPUGVYHXW VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3560", Offset = "0x8BB2160", VA = "0x188BB3560")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB33B0", Offset = "0x8BB1FB0", VA = "0x188BB33B0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private readonly ConfigProperty<int> ZHCXYTATFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> EGKHWRYQRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private readonly MultiValueConfigProperty<float> BZHCCEWWBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private readonly MultiValueConfigProperty<float> ABYFAMFGAEU;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5020", Offset = "0x8BB3C20", VA = "0x188BB5020")]
		public DRIPUGVYHXW(int a, ConfigProperty<int> b, Action<JIXYMCFDVBA.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4EF0", Offset = "0x8BB3AF0", VA = "0x188BB4EF0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public sealed class WXHPYSDREFZ : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public WXHPYSDREFZ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2310", Offset = "0x8BC0F10", VA = "0x188BC2310")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1D70", Offset = "0x8BC0970", VA = "0x188BC1D70")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private readonly MultiValueConfigProperty<int> JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private readonly MultiValueConfigProperty<float> YLWYUHPBYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private readonly MultiValueConfigProperty<float> KAJBJOTHZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private readonly MultiValueConfigProperty<bool> YZFTGYNXDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private readonly ConfigProperty<Guid> XNNXVSXDVWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private readonly Action<JIXYMCFDVBA.RoomRolePickerData> UFIAIDIACQP;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6240", Offset = "0x8BC4E40", VA = "0x188BC6240")]
		public WXHPYSDREFZ(int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, ConfigProperty<Guid> f, Action<JIXYMCFDVBA.RoomRolePickerData> onExclusiveToRoleClick)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6110", Offset = "0x8BC4D10", VA = "0x188BC6110", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public sealed class OHEEECJOXEA : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public OHEEECJOXEA VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE580", Offset = "0x8BBD180", VA = "0x188BBE580")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD5F0", Offset = "0x8BBC1F0", VA = "0x188BBD5F0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private readonly ConfigProperty<int> IUTYFGLVMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private readonly ConfigProperty<int> QAZWFCPDEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private readonly ConfigProperty<int> ILDQSYGIFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private readonly ConfigProperty<int> DNPOYUCJFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private readonly ConfigProperty<int> BOKNHHUWLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> EGKHWRYQRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private readonly MultiValueConfigProperty<float> QVCXBYYYANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private readonly MultiValueConfigProperty<float> PHVCFIYQYMR;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB930", Offset = "0x8BBA530", VA = "0x188BBB930")]
		public OHEEECJOXEA(int a, ConfigProperty<int> b, ConfigProperty<int> c, ConfigProperty<int> d, ConfigProperty<int> e, ConfigProperty<int> f, Action<JIXYMCFDVBA.ColorPickerData> onColorClick, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB800", Offset = "0x8BBA400", VA = "0x188BBB800", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class BUQKZDRUDSW : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class LOJPDCGXZIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public BUQKZDRUDSW VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LOJPDCGXZIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB98F0", Offset = "0x8BB84F0", VA = "0x188BB98F0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB97B0", Offset = "0x8BB83B0", VA = "0x188BB97B0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private readonly ConfigProperty<int> ZHCXYTATFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> EGKHWRYQRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private readonly MultiValueConfigProperty<float> CSMXSMRSKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private readonly MultiValueConfigProperty<float> UTMCBLOAOTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private readonly MultiValueConfigProperty<float> HCHUNDDLWND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly MultiValueConfigProperty<float> NOXLFJMPTKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private readonly MultiValueConfigProperty<float> CMDUKZRWSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private readonly MultiValueConfigProperty<float> QWAIZMXFUZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private readonly MultiValueConfigProperty<bool> VWHXABHFYVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private readonly MultiValueConfigProperty<bool> WXBIOLCZGLN;

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3200", Offset = "0x8BB1E00", VA = "0x188BB3200")]
		public BUQKZDRUDSW(int a, ConfigProperty<int> b, Action<JIXYMCFDVBA.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB30D0", Offset = "0x8BB1CD0", VA = "0x188BB30D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public readonly struct MultiValueConfigProperty<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		[CompilerGenerated]
		private sealed class EMFFBINPTWU<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public IEnumerable<b> UNHNVNEJAZJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			public Func<b, T> FJHMSQUAYLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public Action<b, T> OFDDJYHDKXQ;

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EMFFBINPTWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x4CD4050", Offset = "0x4CD2C50", VA = "0x184CD4050")]
			internal Option<T> UDRIVQSHOPJ()
			{
				return default(Option<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x4CD35F0", Offset = "0x4CD21F0", VA = "0x184CD35F0")]
			internal void UDMBYJYKFEA(T a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private sealed class UEIRPVFPQAX<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public T HXLWPBHUDSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public EMFFBINPTWU<b> JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UEIRPVFPQAX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x680A780", Offset = "0x6809380", VA = "0x18680A780")]
			internal void UEBWQEGCHMB(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public MultiValueConfigProperty<T> NDZCEVNPDQU;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x541C800", Offset = "0x541B400", VA = "0x18541C800")]
			internal Option<object> OXVFSOJWIEY()
			{
				return default(Option<object>);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x541CDB0", Offset = "0x541B9B0", VA = "0x18541CDB0")]
			internal void OYAMPVDTRQH(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class UBTMVMUZZEH<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public Func<b, T> FJHMSQUAYLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public T KUYYZKETGNP;

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UBTMVMUZZEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x67DC570", Offset = "0x67DB170", VA = "0x1867DC570")]
			internal bool RISBMWZKSNE(b a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public readonly Func<Option<T>> Get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public readonly Action<T> Set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public readonly Func<bool>? IsModified;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x41B1230", Offset = "0x41AFE30", VA = "0x1841B1230")]
		public static MultiValueConfigProperty<T> Create<U>(IEnumerable<U> objects, Func<U, T> getter, Action<U, T> setter, Func<bool>? isModified) where U : notnull
		{
			return default(MultiValueConfigProperty<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5F43120", Offset = "0x5F41D20", VA = "0x185F43120")]
		public static implicit operator MultiValueConfigProperty<object>(MultiValueConfigProperty<T> prop)
		{
			return default(MultiValueConfigProperty<object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x41B1F10", Offset = "0x41B0B10", VA = "0x1841B1F10")]
		private static Option<T> IXUCUJHVIEC<U>(IEnumerable<U> a, Func<U, T> b) where U : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		internal MultiValueConfigProperty(Func<Option<T>> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public static class EDVQSXABBWW
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class EMUZTCVHWEV<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public IEnumerable<a> UNHNVNEJAZJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public Func<a, bool> FNCTGGOINYO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public Func<a, bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EMUZTCVHWEV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x4CD4B90", Offset = "0x4CD3790", VA = "0x184CD4B90")]
			internal bool BTCWMILWEET()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x4CD4AA0", Offset = "0x4CD36A0", VA = "0x184CD4AA0")]
			internal bool BSXPPBRYUTK(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class LKGVCQQJQVQ<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public MultiValueConfigProperty<a> NDZCEVNPDQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public Func<a, b> APFETMDYVGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public Func<b, a> GXKHTVFQMKV;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LKGVCQQJQVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x5986910", Offset = "0x5985510", VA = "0x185986910")]
			internal Option<b> VVTBKIISRBO()
			{
				return default(Option<b>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x59863B0", Offset = "0x5984FB0", VA = "0x1859863B0")]
			internal void UHYIHGSPLIP(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class WTFRSPBGSXA<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public ConfigProperty<a> NDZCEVNPDQU;

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WTFRSPBGSXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x6D79030", Offset = "0x6D77C30", VA = "0x186D79030")]
			internal Option<a> AIUROOHZTBH()
			{
				return default(Option<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x1353410", Offset = "0x1352010", VA = "0x181353410")]
			internal void SGHCKHTEJDE(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7690", Offset = "0x3AD6290", VA = "0x183AD7690")]
		public static MultiValueConfigProperty<U> RFNOAMCRFBL<U, T>(this IEnumerable<T> a, Func<T, U> b, Action<T, U> c, [Optional] Func<T, bool>? isModified) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7FC0", Offset = "0x3AD6BC0", VA = "0x183AD7FC0")]
		public static MultiValueConfigProperty<U> To<U, T>(this MultiValueConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7290", Offset = "0x3AD5E90", VA = "0x183AD7290")]
		internal static MultiValueConfigProperty<a?> RFNOAMCRFBL<a>(this ConfigProperty<a> prop)
		{
			return default(MultiValueConfigProperty<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class RIDCTCDXRCR : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public RIDCTCDXRCR VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBBA80", Offset = "0x8BBA680", VA = "0x188BBBA80")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private static readonly IReadOnlyList<NavMeshGenerationMode> ZPEIBKOPMTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private readonly MultiValueConfigProperty<NavMeshGenerationMode> ELVIIFVHUXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC04D0", Offset = "0x8BBF0D0", VA = "0x188BC04D0")]
		private static string BKECAILHNLE(NavMeshGenerationMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0730", Offset = "0x8BBF330", VA = "0x188BC0730")]
		public RIDCTCDXRCR(MultiValueConfigProperty<NavMeshGenerationMode> a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0560", Offset = "0x8BBF160", VA = "0x188BC0560", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class SPQYLFDRZVG : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public SPQYLFDRZVG VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8BB95A0", Offset = "0x8BB81A0", VA = "0x188BB95A0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private readonly CZIRKWBNGQK ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public SPQYLFDRZVG(CZIRKWBNGQK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8BC19F0", Offset = "0x8BC05F0", VA = "0x188BC19F0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class CZIRKWBNGQK : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private readonly Action WPTVYXRDWWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private readonly Func<bool> RIEKMEXCOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private readonly Action MEUVZVOFOWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private readonly Action IUZENLWXGXH;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x11F0770", Offset = "0x11EF370", VA = "0x1811F0770")]
		public CZIRKWBNGQK(Action a, Func<bool> b, Action c, Action d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4C90", Offset = "0x8BB3890", VA = "0x188BB4C90", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4EC0", Offset = "0x8BB3AC0", VA = "0x188BB4EC0")]
		[CompilerGenerated]
		private bool HLEKQQKQZHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4EC0", Offset = "0x8BB3AC0", VA = "0x188BB4EC0")]
		[CompilerGenerated]
		private bool HKZDTJQTPVU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class GGKHNKJMWWV : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public GGKHNKJMWWV VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x8BC6AA0", Offset = "0x8BC56A0", VA = "0x188BC6AA0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x8BC69F0", Offset = "0x8BC55F0", VA = "0x188BC69F0")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private readonly IReadOnlyDictionary<int, string> JJVLFCCOBGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly MultiValueConfigProperty<int> CVCTQUSTDUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly MultiValueConfigProperty<bool> GJKDPIONCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly MultiValueConfigProperty<bool> OFUXXTBCMMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly MultiValueConfigProperty<float> WPYIWNVPSBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly MultiValueConfigProperty<float> HJDIREMYCTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private readonly VQUHSHZISWR? JVQEJLFQAQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly WLRFULYAZEC? EDPYBPLBPTO;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5900", Offset = "0x8BB4500", VA = "0x188BB5900")]
		public GGKHNKJMWWV(IReadOnlyDictionary<int, string>? effectsDict, MultiValueConfigProperty<int> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, VQUHSHZISWR? sandboxColorableConfig, WLRFULYAZEC? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8BB57D0", Offset = "0x8BB43D0", VA = "0x188BB57D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class HJJUVLWVSZN : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public HJJUVLWVSZN VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x8BBBF80", Offset = "0x8BBAB80", VA = "0x188BBBF80")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class PYNDJKDWNOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public string FTNKEWSDCTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public ConfigProperty<string> IBBTTYTYKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public PYHWMDJZEDC JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYNDJKDWNOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC4A0", Offset = "0x8BBB0A0", VA = "0x188BBC4A0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC320", Offset = "0x8BBAF20", VA = "0x188BBC320")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private readonly bool AFBBOWNBFTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private readonly IReadOnlyList<ConfigProperty<string>> PKWPAWDTGVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private readonly int HLZOGVMCFQY;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7150", Offset = "0x8BB5D50", VA = "0x188BB7150")]
		public HJJUVLWVSZN(int a, bool b, IReadOnlyList<ConfigProperty<string>> messages, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7020", Offset = "0x8BB5C20", VA = "0x188BB7020", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class JRBCJDBLHTH : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public JRBCJDBLHTH VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC6F0", Offset = "0x8BBB2F0", VA = "0x188BBC6F0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private readonly WNRHTJNDDXX ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1155AA0", Offset = "0x11546A0", VA = "0x181155AA0")]
		public JRBCJDBLHTH(int a, WNRHTJNDDXX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7690", Offset = "0x8BB6290", VA = "0x188BB7690", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class WNRHTJNDDXX : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public WNRHTJNDDXX VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x8BC7010", Offset = "0x8BC5C10", VA = "0x188BC7010")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x8BC6880", Offset = "0x8BC5480", VA = "0x188BC6880")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x8BC66F0", Offset = "0x8BC52F0", VA = "0x188BC66F0")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private readonly bool AFBBOWNBFTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private readonly string BSDOXQGACCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private readonly ConfigProperty<string> IBBTTYTYKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private readonly int LHVDUZXDAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private readonly bool COIKDIAMGIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private readonly string UOZRQWAHEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private readonly ConfigProperty<bool> CETSULUYGYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private readonly Func<bool> ZNEATCETTXT;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6050", Offset = "0x8BC4C50", VA = "0x188BC6050")]
		public WNRHTJNDDXX(bool a, string b, ConfigProperty<string> message, int c, bool d, ConfigProperty<bool> isLocalized, Func<bool> e, string f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5EB0", Offset = "0x8BC4AB0", VA = "0x188BC5EB0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class MAVSLOADHAH : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public MAVSLOADHAH VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public Action VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public Func<bool> VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public Action<bool> VPAJZRIHYUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public Func<bool> BUNEJPNTJYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public Action BUHXMITWANM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public Action VLZKOTVVNGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public Action<bool> BUCQPBZYRCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public Action BTXJRVGBHQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public Action VMERMAPSWRR;

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF990", Offset = "0x8BBE590", VA = "0x188BBF990")]
			internal bool TNIPSEHMLUV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEC40", Offset = "0x8BBD840", VA = "0x188BBEC40")]
			internal bool QTZVHXHAPTA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF960", Offset = "0x8BBE560", VA = "0x188BBF960")]
			internal void PVTWDZWLZYP(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC960", Offset = "0x8BBB560", VA = "0x188BBC960")]
			internal bool HQXQHJSZZEV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF230", Offset = "0x8BBDE30", VA = "0x188BBF230")]
			internal void ORLZXAQCBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEC80", Offset = "0x8BBD880", VA = "0x188BBEC80")]
			internal void ORGSZTWERQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEC40", Offset = "0x8BBD840", VA = "0x188BBEC40")]
			internal bool ORBMCNCHIFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEB80", Offset = "0x8BBD780", VA = "0x188BBEB80")]
			internal void OQWFFGIJYUE(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCEE0", Offset = "0x8BBBAE0", VA = "0x188BBCEE0")]
			internal void OPAVDXLHRWB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BBFF40", Offset = "0x8BBEB40", VA = "0x188BBFF40")]
			internal bool XXHZUWGQSPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BBFF80", Offset = "0x8BBEB80", VA = "0x188BBFF80")]
			internal void XXNGSDAOCAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCA30", Offset = "0x8BBB630", VA = "0x188BBCA30")]
			internal void OOVOGQRKIKS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF9D0", Offset = "0x8BBE5D0", VA = "0x188BBF9D0")]
			internal void XWXMAISVZSU(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BBFAA0", Offset = "0x8BBE6A0", VA = "0x188BBFAA0")]
			internal void XXCSXPMTJED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public MAVSLOADHAH VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public PhysicsModelEnumFlags RSDVYXTTQEX;

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4890", Offset = "0x8BB3490", VA = "0x188BB4890")]
			internal bool PATCESWYCXF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4850", Offset = "0x8BB3450", VA = "0x188BB4850")]
			internal void PANVHMDATLW(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private static readonly IReadOnlyList<CollisionMode> XTRQMWIAAUJ;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private static readonly IReadOnlyList<CollisionLayerEnum> NMGKJWIDQAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private readonly bool JMBLGMCIEAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private readonly ConfigProperty<CollisionMode> LFGTTXHRRBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private readonly ConfigProperty<CollisionLayerEnum> RXZEBYEELYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly ConfigProperty<float> HMTTFJXXLYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Func<PhysicsModelEnumFlags, bool> GHHGQIPVQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly Action<PhysicsModelEnumFlags, bool> XCBJYYLPQFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly ConfigProperty<float>? PWXLAPIZXKD;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAB90", Offset = "0x8BB9790", VA = "0x188BBAB90")]
		private static string KYGCYRTUUSY(CollisionMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAC20", Offset = "0x8BB9820", VA = "0x188BBAC20")]
		private static string QCRDCBSHMRS(CollisionLayerEnum a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAE20", Offset = "0x8BB9A20", VA = "0x188BBAE20")]
		public MAVSLOADHAH(bool a, ConfigProperty<CollisionMode> b, ConfigProperty<CollisionLayerEnum> c, ConfigProperty<float> d, Func<PhysicsModelEnumFlags, bool> hasFlag, Action<PhysicsModelEnumFlags, bool> setFlag, [Optional] ConfigProperty<float>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA8C0", Offset = "0x8BB94C0", VA = "0x188BBA8C0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA9F0", Offset = "0x8BB95F0", VA = "0x188BBA9F0")]
		private MultiValueConfigProperty<bool> DZSWYZJYAIZ(PhysicsModelEnumFlags a)
		{
			return default(MultiValueConfigProperty<bool>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class QSNGVHNNSHW : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public QSNGVHNNSHW VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BB38C0", Offset = "0x8BB24C0", VA = "0x188BB38C0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8BB34F0", Offset = "0x8BB20F0", VA = "0x188BB34F0")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly IReadOnlyList<GrabbableMode> UUDBQFXCFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private readonly MultiValueConfigProperty<bool> IPCVEEBWRYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private readonly MultiValueConfigProperty<GrabbableMode> QQMAJWMLIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly MultiValueConfigProperty<bool> SJVJOHXTNHW;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC02A0", Offset = "0x8BBEEA0", VA = "0x188BC02A0")]
		private static string UDOYZSTRUBG(GrabbableMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B99C70", Offset = "0x8B98870", VA = "0x188B99C70")]
		public QSNGVHNNSHW(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<GrabbableMode> b, MultiValueConfigProperty<bool> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0170", Offset = "0x8BBED70", VA = "0x188BC0170", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class NGMYADFQFGM : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public NGMYADFQFGM VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public Func<bool> VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3090", Offset = "0x8BC1C90", VA = "0x188BC3090")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1FA0", Offset = "0x8BC0BA0", VA = "0x188BC1FA0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1B20", Offset = "0x8BC0720", VA = "0x188BC1B20")]
			internal bool OQBDQFGUNAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1B60", Offset = "0x8BC0760", VA = "0x188BC1B60")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly Option<bool> TMVMNPOVSCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private readonly MultiValueConfigProperty<string> CFFWKEOMCTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private readonly Func<int> PTEFFIROZHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private readonly MultiValueConfigProperty<bool> JOVZUPAOEIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private readonly MultiValueConfigProperty<bool> MRSILLTMKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private readonly DOLZHYYIZPP? ZOUGBCMAYUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private readonly EJFJMAXGDWI? PZNMNBEZUFW;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB030", Offset = "0x8BB9C30", VA = "0x188BBB030")]
		public NGMYADFQFGM(Option<bool> a, MultiValueConfigProperty<string> name, Func<int> currentSelectionCount, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, DOLZHYYIZPP? transformConfig, EJFJMAXGDWI? tagsConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAF00", Offset = "0x8BB9B00", VA = "0x188BBAF00", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class ENHUKEKXMRA : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public ENHUKEKXMRA VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public Func<int> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8CA0", Offset = "0x8BB78A0", VA = "0x188BB8CA0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8C70", Offset = "0x8BB7870", VA = "0x188BB8C70")]
			internal int OQLRKSUPFXM()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly MultiValueConfigProperty<int> ZHCXYTATFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> IQPOVCKKEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly MultiValueConfigProperty<int> IQEDXEDEBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private readonly Action<JIXYMCFDVBA.MaterialPickerData> SMOWRPLWNIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private readonly MultiValueConfigProperty<float> BIDPCZUZXGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private readonly MultiValueConfigProperty<float> SSJKYVNBJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private readonly MultiValueConfigProperty<float> SSORWCGYSWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private readonly MultiValueConfigProperty<float> SRYXEHZGQOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private readonly MultiValueConfigProperty<bool> IJRUGCULNLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private readonly Func<bool> GTVDFZYLVVB;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5530", Offset = "0x8BB4130", VA = "0x188BB5530")]
		public ENHUKEKXMRA(MultiValueConfigProperty<int> a, Action<JIXYMCFDVBA.ColorPickerData> colorButtonOnClick, MultiValueConfigProperty<int> b, Action<JIXYMCFDVBA.MaterialPickerData> materialButtonOnClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, Func<bool> isSinglePrimitiveShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5400", Offset = "0x8BB4000", VA = "0x188BB5400", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class GOYLQJEMXAG : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public GOYLQJEMXAG VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBBC90", Offset = "0x8BBA890", VA = "0x188BBBC90")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly Dictionary<int, string> KOKZZFFMJLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly MultiValueConfigProperty<bool> LRJYFIDSVJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly MultiValueConfigProperty<bool> PNETKGXMQKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private readonly MultiValueConfigProperty<int> WJXZUGCTOAJ;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB64C0", Offset = "0x8BB50C0", VA = "0x188BB64C0")]
		public GOYLQJEMXAG(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<int> c, Dictionary<int, string> tubeRingOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8BB63A0", Offset = "0x8BB4FA0", VA = "0x188BB63A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class BAVGQCNQVRH : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public BAVGQCNQVRH VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC630", Offset = "0x8BBB230", VA = "0x188BBC630")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private readonly VQUHSHZISWR ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1155AA0", Offset = "0x11546A0", VA = "0x181155AA0")]
		public BAVGQCNQVRH(int a, VQUHSHZISWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2FA0", Offset = "0x8BB1BA0", VA = "0x188BB2FA0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class VQUHSHZISWR : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public VQUHSHZISWR VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x8BB66E0", Offset = "0x8BB52E0", VA = "0x188BB66E0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8BB66C0", Offset = "0x8BB52C0", VA = "0x188BB66C0")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private readonly RecolorModes GFRYDIGTFOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private readonly ConfigProperty<int> TBUEYLOCGUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private readonly Action<JIXYMCFDVBA.ColorPickerData> IQPOVCKKEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private readonly ConfigProperty<int> XWUOMKUZEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private readonly Action<JIXYMCFDVBA.MaterialPickerData> SMOWRPLWNIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private readonly ConfigProperty<float> NVVNZTQJLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly bool TZTCMNEOYHG;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BC51A0", Offset = "0x8BC3DA0", VA = "0x188BC51A0")]
		public VQUHSHZISWR(RecolorModes a, ConfigProperty<int> b, Action<JIXYMCFDVBA.ColorPickerData> colorButtonOnClick, ConfigProperty<int> c, Action<JIXYMCFDVBA.MaterialPickerData> materialButtonOnClick, ConfigProperty<float> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4FB0", Offset = "0x8BC3BB0", VA = "0x188BC4FB0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class KUDQSQWCSLP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public KUDQSQWCSLP VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4BE0", Offset = "0x8BB37E0", VA = "0x188BB4BE0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private readonly WLRFULYAZEC? HRODDGRQMFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private readonly WNRHTJNDDXX? KPDWGONRFEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private readonly VQUHSHZISWR? KXIKLWQUIIX;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xF97AD0", Offset = "0xF966D0", VA = "0x180F97AD0")]
		public KUDQSQWCSLP(WNRHTJNDDXX? a, VQUHSHZISWR? b, WLRFULYAZEC? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9470", Offset = "0x8BB8070", VA = "0x188BB9470", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class TXULJTHTPUE : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public TXULJTHTPUE VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC690", Offset = "0x8BBB290", VA = "0x188BBC690")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private readonly int JVEFKRSFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private readonly WLRFULYAZEC ZDFBEGIBXWV;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1155AA0", Offset = "0x11546A0", VA = "0x181155AA0")]
		public TXULJTHTPUE(int a, WLRFULYAZEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3470", Offset = "0x8BC2070", VA = "0x188BC3470", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class WLRFULYAZEC : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private readonly string BSDOXQGACCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private readonly MultiValueConfigProperty<bool> VYRGOIXRQWX;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FF10", Offset = "0x8B9EB10", VA = "0x188B9FF10")]
		public WLRFULYAZEC(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5D80", Offset = "0x8BC4980", VA = "0x188BC5D80", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class EJFJMAXGDWI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public EJFJMAXGDWI VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Func<string, bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x8BC20F0", Offset = "0x8BC0CF0", VA = "0x188BC20F0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1EE0", Offset = "0x8BC0AE0", VA = "0x188BC1EE0")]
			internal bool OQLRKSUPFXM(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly ConfigProperty<IReadOnlyList<string>> LYFZHZOVGQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly ConfigProperty<IReadOnlyList<string>>? RTBNEIKDWJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly Func<bool> BCHGBRHBOHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly Func<bool>? KBDDHXHIDEF;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
		private static bool DXFOJNSNUFV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5310", Offset = "0x8BB3F10", VA = "0x188BB5310")]
		public EJFJMAXGDWI(int a, ConfigProperty<IReadOnlyList<string>> persistentTags, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeTags, [Optional] Func<bool>? b, [Optional] Func<bool>? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5200", Offset = "0x8BB3E00", VA = "0x188BB5200", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class JSCKRVLPABU : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class XZKJDTPKGJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public JSCKRVLPABU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XZKJDTPKGJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BC7220", Offset = "0x8BC5E20", VA = "0x188BC7220")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BC71F0", Offset = "0x8BC5DF0", VA = "0x188BC71F0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8BC71C0", Offset = "0x8BC5DC0", VA = "0x188BC71C0")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8BC7190", Offset = "0x8BC5D90", VA = "0x188BC7190")]
			internal void OQBDQFGUNAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class WFWDIIKMSFQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public JSCKRVLPABU VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WFWDIIKMSFQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x8BC52E0", Offset = "0x8BC3EE0", VA = "0x188BC52E0")]
			internal void UYKILRRGBTI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8BC5840", Offset = "0x8BC4440", VA = "0x188BC5840")]
			internal void UYPPIYLDLER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8BC5270", Offset = "0x8BC3E70", VA = "0x188BC5270")]
			internal bool UXZUREDLIWQ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly IReadOnlyList<GunHandleData.MMDAOZKJIDU.GunHandleScreensPose> YZUECIPHCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private readonly MultiValueConfigProperty<GunHandleData.MMDAOZKJIDU.GunHandleScreensPose> BVUNBFXMCZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private readonly MultiValueConfigProperty<int> WOLROIIUEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private readonly MultiValueConfigProperty<bool> JVPWBAZPHSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private readonly MultiValueConfigProperty<float> KYYTDCPXANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private readonly MultiValueConfigProperty<bool> KZLXJKRVJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private readonly MultiValueConfigProperty<float> ZESYQQMRMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private readonly MultiValueConfigProperty<bool> KOUADPAQZVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private readonly MultiValueConfigProperty<bool> ACLNTYNPRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private readonly MultiValueConfigProperty<float> VKJSUHGYILY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private readonly MultiValueConfigProperty<bool> DCLKYMUDRGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly MultiValueConfigProperty<bool> PUOZMMEOMZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private readonly MultiValueConfigProperty<bool> PMAGLCZWQEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private readonly MultiValueConfigProperty<bool> JMLQZEZDIYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private readonly MultiValueConfigProperty<bool> QKGASHDCLUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private readonly MultiValueConfigProperty<float> VCTEBCABWXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private readonly MultiValueConfigProperty<float> HNCVHZKEXKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly MultiValueConfigProperty<float> QWKUPHBPMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly MultiValueConfigProperty<float> VPGQREAESQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private readonly MultiValueConfigProperty<float> QUJDZPADLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private readonly MultiValueConfigProperty<float> PSKPIURRIUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private readonly MultiValueConfigProperty<bool> EBNOGGTYRZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private readonly MultiValueConfigProperty<bool> TFDYRBNYZVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly MultiValueConfigProperty<bool> UUJEDQVRWLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly MultiValueConfigProperty<string> DOTASSQINOE;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB78F0", Offset = "0x8BB64F0", VA = "0x188BB78F0")]
		private static string IGUMOOXAUSO(GunHandleData.MMDAOZKJIDU.GunHandleScreensPose a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8660", Offset = "0x8BB7260", VA = "0x188BB8660")]
		public JSCKRVLPABU(MultiValueConfigProperty<GunHandleData.MMDAOZKJIDU.GunHandleScreensPose> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, MultiValueConfigProperty<float> q, MultiValueConfigProperty<float> r, MultiValueConfigProperty<float> s, MultiValueConfigProperty<float> t, MultiValueConfigProperty<bool> u, MultiValueConfigProperty<bool> v, MultiValueConfigProperty<bool> w, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB77C0", Offset = "0x8BB63C0", VA = "0x188BB77C0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7F10", Offset = "0x8BB6B10", VA = "0x188BB7F10")]
		private void TLPFEKWEQIQ(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BB79F0", Offset = "0x8BB65F0", VA = "0x188BB79F0")]
		private void OLVASSBENCG(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8260", Offset = "0x8BB6E60", VA = "0x188BB8260")]
		private void WJPXTLANKMA(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7EA0", Offset = "0x8BB6AA0", VA = "0x188BB7EA0")]
		[CompilerGenerated]
		private bool PCHLXKKUBTX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7E30", Offset = "0x8BB6A30", VA = "0x188BB7E30")]
		[CompilerGenerated]
		private bool PCCFADQWSIO()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class HVFOBYLKANY : JJQSBRMSMRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private readonly string EVPESNBQYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private readonly MultiValueConfigProperty<string> DOTASSQINOE;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FF10", Offset = "0x8B9EB10", VA = "0x188B9FF10")]
		public HVFOBYLKANY(string a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB71B0", Offset = "0x8BB5DB0", VA = "0x188BB71B0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class JEJQMFRVENI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public JEJQMFRVENI VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public Func<bool> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2AB0", Offset = "0x8BC16B0", VA = "0x188BC2AB0")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1F30", Offset = "0x8BC0B30", VA = "0x188BC1F30")]
			internal bool OQLRKSUPFXM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private static readonly IReadOnlyDictionary<SwingHandleData.MMDAOZKJIDU.SwingHandleAnimation, string> UOYEUFKHNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly MultiValueConfigProperty<SwingHandleData.MMDAOZKJIDU.SwingHandleAnimation> UWJPRRVMBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MultiValueConfigProperty<bool> YIILIHXMPTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly MultiValueConfigProperty<bool> YNANELHYZZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private readonly MultiValueConfigProperty<float> VBYVJDPRVXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly MultiValueConfigProperty<bool> EBNOGGTYRZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly MultiValueConfigProperty<string> DOTASSQINOE;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA08A0", Offset = "0x8B9F4A0", VA = "0x188BA08A0")]
		public JEJQMFRVENI(MultiValueConfigProperty<SwingHandleData.MMDAOZKJIDU.SwingHandleAnimation> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB72E0", Offset = "0x8BB5EE0", VA = "0x188BB72E0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class SLISDTPJGVK : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public SLISDTPJGVK VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2860", Offset = "0x8BC1460", VA = "0x188BC2860")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1EB0", Offset = "0x8BC0AB0", VA = "0x188BC1EB0")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1BC0", Offset = "0x8BC07C0", VA = "0x188BC1BC0")]
			internal void OQGKNMARWMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.MMDAOZKJIDU.ThrowHandleIdlePose, string> ROXAGYPHZLT;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.MMDAOZKJIDU.ThrowHandleThrowPose, string> REYNVGNPJQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private readonly MultiValueConfigProperty<ThrowHandleData.MMDAOZKJIDU.ThrowHandleIdlePose> TEZJHQKAEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private readonly MultiValueConfigProperty<ThrowHandleData.MMDAOZKJIDU.ThrowHandleThrowPose> ZWEBVPOAGWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private readonly MultiValueConfigProperty<float> PMCWFGZTGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private readonly MultiValueConfigProperty<float> JCZJWXUXZSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private readonly MultiValueConfigProperty<string> DOTASSQINOE;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8BA71A0", Offset = "0x8BA5DA0", VA = "0x188BA71A0")]
		public SLISDTPJGVK(MultiValueConfigProperty<ThrowHandleData.MMDAOZKJIDU.ThrowHandleIdlePose> a, MultiValueConfigProperty<ThrowHandleData.MMDAOZKJIDU.ThrowHandleThrowPose> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0780", Offset = "0x8BBF380", VA = "0x188BC0780", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8BC08B0", Offset = "0x8BBF4B0", VA = "0x188BC08B0")]
		private void CSZPWIWWYGQ(JIXYMCFDVBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0B80", Offset = "0x8BBF780", VA = "0x188BC0B80")]
		private void VQIUTFISMAH(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class EOESQOYUHEU : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public EOESQOYUHEU VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC750", Offset = "0x8BBB350", VA = "0x188BBC750")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private readonly MultiValueConfigProperty<bool> PMQWCXEDBVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly MultiValueConfigProperty<string> DOTASSQINOE;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8B996E0", Offset = "0x8B982E0", VA = "0x188B996E0")]
		public EOESQOYUHEU(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB56A0", Offset = "0x8BB42A0", VA = "0x188BB56A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class KFEPZCEAVAG : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public KFEPZCEAVAG VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5E90", Offset = "0x8BB4A90", VA = "0x188BB5E90")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly MultiValueConfigProperty<bool> HJPBRMRXHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly MultiValueConfigProperty<float> NKWLBBGSMOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly System.Numerics.Vector2 WEJJBFXLRDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly MultiValueConfigProperty<bool> JMLXXPAGSOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly VQUHSHZISWR? MENVSXWBAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly WLRFULYAZEC? OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8BB0", Offset = "0x8BB77B0", VA = "0x188BB8BB0")]
		public KFEPZCEAVAG(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<bool> d, VQUHSHZISWR? colorableOptions, WLRFULYAZEC? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8A80", Offset = "0x8BB7680", VA = "0x188BB8A80", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class ECKFXNENTKF : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public ECKFXNENTKF VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x8BB9750", Offset = "0x8BB8350", VA = "0x188BB9750")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private readonly EJFJMAXGDWI TTZSKRNMNJJ;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ECKFXNENTKF(EJFJMAXGDWI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8BB50D0", Offset = "0x8BB3CD0", VA = "0x188BB50D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class CVPOBADBBOW : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public CVPOBADBBOW VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB9600", Offset = "0x8BB8200", VA = "0x188BB9600")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private readonly MultiValueConfigProperty<bool> CTYQDXIAJDR;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8B92360", Offset = "0x8B90F60", VA = "0x188B92360")]
		public CVPOBADBBOW(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8BB48D0", Offset = "0x8BB34D0", VA = "0x188BB48D0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class CVVAAIOWIEH : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public CVVAAIOWIEH VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5A80", Offset = "0x8BB4680", VA = "0x188BB5A80")]
			internal bool OMSVSEBIPLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5B20", Offset = "0x8BB4720", VA = "0x188BB5B20")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private readonly MultiValueConfigProperty<bool> UXVGXHXCPWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private readonly Func<bool> JRVUNGFNNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private readonly MultiValueConfigProperty<bool> EUHILAELXKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private readonly MultiValueConfigProperty<float> XXTPXURQBES;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4B30", Offset = "0x8BB3730", VA = "0x188BB4B30")]
		public CVVAAIOWIEH(MultiValueConfigProperty<bool> a, Func<bool> canSeeShouldRespawn, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4A00", Offset = "0x8BB3600", VA = "0x188BB4A00", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class VKVUVWBSMVI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public VKVUVWBSMVI VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6990", Offset = "0x8BB5590", VA = "0x188BB6990")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6570", Offset = "0x8BB5170", VA = "0x188BB6570")]
			internal void OQLRKSUPFXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly Dictionary<SeatData.MMDAOZKJIDU.PostureType, string> YSXWUCEQKHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly string BILRVYSTMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private readonly Option<bool> NFQKJYATWNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private readonly MultiValueConfigProperty<SeatData.MMDAOZKJIDU.PostureType> YVKTSKGLLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private readonly MultiValueConfigProperty<bool> PPCYBIRGCRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private readonly MultiValueConfigProperty<bool> FYICQFJMXFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private readonly MultiValueConfigProperty<bool> XTLMTMPAVHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private readonly MultiValueConfigProperty<bool> KUKORDPEJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private readonly MultiValueConfigProperty<bool> WSAQUSYFKPL;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8BC40A0", Offset = "0x8BC2CA0", VA = "0x188BC40A0")]
		public VKVUVWBSMVI(string configName, Option<bool> a, MultiValueConfigProperty<SeatData.MMDAOZKJIDU.PostureType> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3E80", Offset = "0x8BC2A80", VA = "0x188BC3E80", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class XVAUUGRTRDF : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public XVAUUGRTRDF VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB40F0", Offset = "0x8BB2CF0", VA = "0x188BB40F0")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly IReadOnlyDictionary<int, string> WZVLEYBASZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private readonly MultiValueConfigProperty<int> ZOBLJJUUWGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private readonly IReadOnlyDictionary<int, string> AGJRKCABJAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly MultiValueConfigProperty<float> SGVKFIBGYXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private readonly MultiValueConfigProperty<int> CJCUTBXGKHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private readonly MultiValueConfigProperty<string> JCDOHPKSYYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private readonly MultiValueConfigProperty<bool> QKXNGXZBAYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private readonly MultiValueConfigProperty<string> KWFZEZHMJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private readonly MultiValueConfigProperty<bool> DLJAUVCOQRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private readonly MultiValueConfigProperty<bool> BZUWIHCGIBR;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6580", Offset = "0x8BC5180", VA = "0x188BC6580")]
		public XVAUUGRTRDF(MultiValueConfigProperty<int> a, IReadOnlyDictionary<int, string> teamItems, MultiValueConfigProperty<float> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<string> primaryHandRespawnTag, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> secondaryHandRespawnTag, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6340", Offset = "0x8BC4F40", VA = "0x188BC6340", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class SOUVFWMUKUZ : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public SOUVFWMUKUZ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			public Action VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			public Action VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDE20", Offset = "0x8BBCA20", VA = "0x188BBDE20")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDC00", Offset = "0x8BBC800", VA = "0x188BBDC00")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD490", Offset = "0x8BBC090", VA = "0x188BBD490")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD430", Offset = "0x8BBC030", VA = "0x188BBD430")]
			internal void OQBDQFGUNAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF860", Offset = "0x8BBE460", VA = "0x188BBF860")]
			internal void ORLZXAQCBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF0A0", Offset = "0x8BBDCA0", VA = "0x188BBF0A0")]
			internal void ORGSZTWERQW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private readonly MultiValueConfigProperty<bool> FZWARSEPNTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private readonly MultiValueConfigProperty<float> SGVKFIBGYXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private readonly MultiValueConfigProperty<float> SMWREFRFZXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private readonly EJFJMAXGDWI WWDJLDCXVXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private readonly EJFJMAXGDWI XWMIEXYJELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private readonly IReadOnlyList<(Guid, string)>? UGNGAGUKVHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> CYWYATHOWGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> BEXJJRLEESJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private readonly Action<JIXYMCFDVBA.MultiTogglePickerData> MGFMSNRVTYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private readonly WLRFULYAZEC? OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC10B0", Offset = "0x8BBFCB0", VA = "0x188BC10B0")]
		public SOUVFWMUKUZ(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, IReadOnlyList<(Guid, string)>? roleItems, ConfigProperty<string[]> roleGuidsToSpawn, ConfigProperty<string[]> roleGuidsToAvoid, Action<JIXYMCFDVBA.MultiTogglePickerData> onRolePickerClick, WLRFULYAZEC? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0F80", Offset = "0x8BBFB80", VA = "0x188BC0F80", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class NNVXEGMPFUI : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public NNVXEGMPFUI VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			public Action VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public Action VNUUQCSXUEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Action VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public Action VOABNJMVDPU;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE190", Offset = "0x8BBCD90", VA = "0x188BBE190")]
			internal void OQQYHZOMPIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDB00", Offset = "0x8BBC700", VA = "0x188BBDB00")]
			internal void OQLRKSUPFXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD3D0", Offset = "0x8BBBFD0", VA = "0x188BBD3D0")]
			internal void OQBDQFGUNAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD4F0", Offset = "0x8BBC0F0", VA = "0x188BBD4F0")]
			internal void OQGKNMARWMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF1D0", Offset = "0x8BBDDD0", VA = "0x188BBF1D0")]
			internal void ORLZXAQCBCF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private readonly int YIFCMZLAKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private readonly MultiValueConfigProperty<bool> GGXLFDXYZAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private readonly MultiValueConfigProperty<float> SGVKFIBGYXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private readonly MultiValueConfigProperty<float> SMWREFRFZXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private readonly EJFJMAXGDWI WWDJLDCXVXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private readonly EJFJMAXGDWI XWMIEXYJELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly WLRFULYAZEC? OWOAMFNNOZF;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB240", Offset = "0x8BB9E40", VA = "0x188BBB240")]
		public NNVXEGMPFUI(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, WLRFULYAZEC? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB110", Offset = "0x8BB9D10", VA = "0x188BBB110", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public sealed class QYIRIBZCJHP : JJQSBRMSMRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public JIXYMCFDVBA FTBMDVJFSTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public QYIRIBZCJHP VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3D60", Offset = "0x8BB2960", VA = "0x188BB3D60")]
			internal void OQQYHZOMPIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private readonly MultiValueConfigProperty<string> GDOZZJGHACQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private readonly MultiValueConfigProperty<float> WEKTWBFYHLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private readonly MultiValueConfigProperty<bool> VFKJCPZJZMV;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8B99C70", Offset = "0x8B98870", VA = "0x188B99C70")]
		public QYIRIBZCJHP(MultiValueConfigProperty<string> WelcomeMatName, MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8BC03A0", Offset = "0x8BBEFA0", VA = "0x188BC03A0", Slot = "4")]
		public void BLCUAMXKNAL(JIXYMCFDVBA a)
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
