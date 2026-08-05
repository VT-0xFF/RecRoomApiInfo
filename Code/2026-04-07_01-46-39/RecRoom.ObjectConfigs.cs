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
		[Cpp2IlInjected.Address(RVA = "0x9B3B380", Offset = "0x9B3A380", VA = "0x189B3B380")]
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
namespace RecRoom.ObjectConfigs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class SYLGTNQRPCH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JGLYUPZPYOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public SYLGTNQRPCH NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public JGLYUPZPYOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9B35EE0", Offset = "0x9B34EE0", VA = "0x189B35EE0")]
			internal bool WOPENULUFQG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9B35460", Offset = "0x9B34460", VA = "0x189B35460")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IReadOnlyList<Channel> WXFHGEPHFJY;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IReadOnlyList<Channel> FTZZKRYLFIN;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly IReadOnlyList<RolloffCurve> HPNZGSKCINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MultiValueConfigProperty<float> NULBNNVOLCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MultiValueConfigProperty<float> XTYKHHBAMSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MultiValueConfigProperty<Channel> SWCCYWUBZST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly bool VSCKMZKUPMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string AOJTFEXNYVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MultiValueConfigProperty<bool> SMPLZOVUQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MultiValueConfigProperty<float> GREJEQZJDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MultiValueConfigProperty<RolloffCurve> OZOEUPZEUVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MultiValueConfigProperty<bool> ISRDAGFNBZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly string KYRJDJVKWPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MultiValueConfigProperty<bool> NYIRJLOGFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly string HNDJGBEFYHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MultiValueConfigProperty<bool> YJKLIXCBMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly RTIIRYITTNT? RYCXVOAMXZL;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B40C50", Offset = "0x9B3FC50", VA = "0x189B40C50")]
		private static string AROHKXFYCAZ(Channel a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B40D00", Offset = "0x9B3FD00", VA = "0x189B40D00")]
		private static string UJJQQNUEXYV(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B40ED0", Offset = "0x9B3FED0", VA = "0x189B40ED0")]
		public SYLGTNQRPCH(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<Channel> c, bool d, string useSpatialAudioLabel, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<RolloffCurve> g, MultiValueConfigProperty<bool> h, string isLoopingLabel, MultiValueConfigProperty<bool> i, string interruptCurrentSoundLabel, MultiValueConfigProperty<bool> j, RTIIRYITTNT? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B40B10", Offset = "0x9B3FB10", VA = "0x189B40B10", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class OBIPISNRIOS : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class TNCYCEOSYMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public OBIPISNRIOS NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Func<bool> CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Func<bool> CUDMDJHYCXI;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TNCYCEOSYMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B41880", Offset = "0x9B40880", VA = "0x189B41880")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B41DD0", Offset = "0x9B40DD0", VA = "0x189B41DD0")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9B42530", Offset = "0x9B41530", VA = "0x189B42530")]
			internal bool EMWPAOVXVEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9B425B0", Offset = "0x9B415B0", VA = "0x189B425B0")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly IReadOnlyDictionary<Channel, string> YALHYPPJTBJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly IReadOnlyDictionary<Channel, string> ZLRDTQBTWBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool XMWBJJELTLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly THQMIIWNKBC LJYYKJSQMSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MultiValueConfigProperty<bool> MTCCCVVPDXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MultiValueConfigProperty<Channel> SWCCYWUBZST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly MultiValueConfigProperty<float> NYVTDXVOZKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MultiValueConfigProperty<float> QJPBRNAKSWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MultiValueConfigProperty<bool> VQAHYCZZPNN;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B3B7B0", Offset = "0x9B3A7B0", VA = "0x189B3B7B0")]
		public OBIPISNRIOS(bool a, THQMIIWNKBC recordableObjectOptions, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<Channel> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B3B400", Offset = "0x9B3A400", VA = "0x189B3B400", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class ZNYKEINVIUK : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ZNYKEINVIUK NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Func<bool> CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Func<bool> CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> CUNZXWVSVUA;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9B331D0", Offset = "0x9B321D0", VA = "0x189B331D0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9B33EB0", Offset = "0x9B32EB0", VA = "0x189B33EB0")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9B33ED0", Offset = "0x9B32ED0", VA = "0x189B33ED0")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9B34100", Offset = "0x9B33100", VA = "0x189B34100")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9B34180", Offset = "0x9B33180", VA = "0x189B34180")]
			internal bool ENHCVCJSOAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9B341A0", Offset = "0x9B331A0", VA = "0x189B341A0")]
			internal bool ENMJSJDPXMD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Option<string> XUWNVPCYNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MultiValueConfigProperty<bool> YGRIIYHNXIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly IReadOnlyDictionary<int, string>? QFVCXYFPGNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MultiValueConfigProperty<int> RQZGEIHJFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Option<string> OTECSLGSBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly MultiValueConfigProperty<bool> BIACUDJMUVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Option<string> CCTLUPMEKRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MultiValueConfigProperty<int> NULBNNVOLCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Option<string> YGOSFWWHTBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly MultiValueConfigProperty<bool> HAHUKNSQGTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Func<Option<bool>> RSCTIVPNRGT;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B4A250", Offset = "0x9B49250", VA = "0x189B4A250")]
		public ZNYKEINVIUK(Option<string> is3dAudioLabel, MultiValueConfigProperty<bool> a, Option<string[]> sfxOptions, MultiValueConfigProperty<int> b, Option<string> isInterruptibleLabel, MultiValueConfigProperty<bool> c, Option<string> volumeLabel, MultiValueConfigProperty<int> d, Option<string> playForAllLabel, MultiValueConfigProperty<bool> e, Func<Option<bool>> hasControlPanel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4A110", Offset = "0x9B49110", VA = "0x189B4A110", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class CAXYGBNEAFZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class RNIKRFKQYEV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public CAXYGBNEAFZ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RNIKRFKQYEV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3FAC0", Offset = "0x9B3EAC0", VA = "0x189B3FAC0")]
			internal bool GWCOINHCNTE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9B3FB10", Offset = "0x9B3EB10", VA = "0x189B3FB10")]
			internal bool ZTHJDVUTWKU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F970", Offset = "0x9B3E970", VA = "0x189B3F970")]
			internal void ENHCVCJSOAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F9D0", Offset = "0x9B3E9D0", VA = "0x189B3F9D0")]
			internal bool ENMJSJDPXMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9B3FA40", Offset = "0x9B3EA40", VA = "0x189B3FA40")]
			internal bool ENRQPPXNGXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F8C0", Offset = "0x9B3E8C0", VA = "0x189B3F8C0")]
			internal bool EMWPAOVXVEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F950", Offset = "0x9B3E950", VA = "0x189B3F950")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly IReadOnlyList<PreferredHandedness> RLNJJZQFKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly AccountRoleType VVIWDIGMBUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly SRBLGUGSSZJ? WPMCWDNCOQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly MultiValueConfigProperty<bool> FKNWFGPAFTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Option<bool> BBGUUJNQTVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Option<bool> GCBGLLDYHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly MultiValueConfigProperty<PreferredHandedness> SDUWYWUMPQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MultiValueConfigProperty<bool> NDDBCUTYBCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly MultiValueConfigProperty<bool> NAALFBRBHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly MultiValueConfigProperty<bool> YLDRURIZBZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly MultiValueConfigProperty<bool> VQQJOTFNGRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly MultiValueConfigProperty<bool> YETTQIOCHOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MultiValueConfigProperty<bool> TNNYQJFJQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly bool OPWQPSGGEDH;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B2FB00", Offset = "0x9B2EB00", VA = "0x189B2FB00")]
		private static string COXMASRWDII(PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B2FBB0", Offset = "0x9B2EBB0", VA = "0x189B2FBB0")]
		public CAXYGBNEAFZ(AccountRoleType a, SRBLGUGSSZJ? interactionFilterOptions, MultiValueConfigProperty<bool> b, Option<bool> c, Option<bool> d, MultiValueConfigProperty<PreferredHandedness> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, bool l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2EF90", Offset = "0x9B2DF90", VA = "0x189B2EF90", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class GCLHEMRVGLC : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public GCLHEMRVGLC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<bool> CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Action CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Func<bool> CUNZXWVSVUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9B2DBD0", Offset = "0x9B2CBD0", VA = "0x189B2DBD0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E540", Offset = "0x9B2D540", VA = "0x189B2E540")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E990", Offset = "0x9B2D990", VA = "0x189B2E990")]
			internal void ENBVXVPVEPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B2EAF0", Offset = "0x9B2DAF0", VA = "0x189B2EAF0")]
			internal void ENHCVCJSOAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B2EC90", Offset = "0x9B2DC90", VA = "0x189B2EC90")]
			internal bool ENRQPPXNGXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B2EC60", Offset = "0x9B2DC60", VA = "0x189B2EC60")]
			internal bool ENMJSJDPXMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E7B0", Offset = "0x9B2D7B0", VA = "0x189B2E7B0")]
			internal void EMWPAOVXVEC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly bool KOKWSFBXKTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool PVJFOBPKUQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly CAXYGBNEAFZ TIYETEBTEMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly QNXLTEOYIWN? KVQZURNDBPC;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B32420", Offset = "0x9B31420", VA = "0x189B32420")]
		public GCLHEMRVGLC(int a, bool b, bool c, CAXYGBNEAFZ d, QNXLTEOYIWN? creatorRestrictedRolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B322E0", Offset = "0x9B312E0", VA = "0x189B322E0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class YFDYJBYQGXT : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public YFDYJBYQGXT NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9B384B0", Offset = "0x9B374B0", VA = "0x189B384B0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly CAXYGBNEAFZ TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public YFDYJBYQGXT(CAXYGBNEAFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B49B90", Offset = "0x9B48B90", VA = "0x189B49B90", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class UHKJKSEAYCH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public UHKJKSEAYCH NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B46630", Offset = "0x9B45630", VA = "0x189B46630")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B47BD0", Offset = "0x9B46BD0", VA = "0x189B47BD0")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly SRBLGUGSSZJ? GLNBOSLKLFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MultiValueConfigProperty<bool> SDRCLUGIMZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Option<bool> RSCTIVPNRGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly MultiValueConfigProperty<bool> QWMDCYDWCZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly MultiValueConfigProperty<bool> CYZWSJKRWTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly YIDBCODKDGY? YJCNMBDNJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RTIIRYITTNT? SNFDZQMLQBB;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B43400", Offset = "0x9B42400", VA = "0x189B43400")]
		public UHKJKSEAYCH(SRBLGUGSSZJ? interactionFilterConfig, MultiValueConfigProperty<bool> a, Option<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, RTIIRYITTNT? syncedComponent, YIDBCODKDGY? playerEditableText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B432C0", Offset = "0x9B422C0", VA = "0x189B432C0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class GEXOLAXYGLZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public GEXOLAXYGLZ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B3E060", Offset = "0x9B3D060", VA = "0x189B3E060")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F220", Offset = "0x9B3E220", VA = "0x189B3F220")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly SRBLGUGSSZJ? GLNBOSLKLFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly MultiValueConfigProperty<bool> DJAQBMRADTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly MultiValueConfigProperty<bool> SDRCLUGIMZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly MultiValueConfigProperty<bool> DVDPQFNVOXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Option<bool> RSCTIVPNRGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly MultiValueConfigProperty<bool> QWMDCYDWCZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly MultiValueConfigProperty<bool> CYZWSJKRWTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly RTIIRYITTNT? SNFDZQMLQBB;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B325D0", Offset = "0x9B315D0", VA = "0x189B325D0")]
		public GEXOLAXYGLZ(SRBLGUGSSZJ? interactionFilterConfig, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, Option<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, RTIIRYITTNT? syncedComponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B32490", Offset = "0x9B31490", VA = "0x189B32490", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class FNODHGRCZRE : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public FNODHGRCZRE NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D020", Offset = "0x9B3C020", VA = "0x189B3D020")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MultiValueConfigProperty<bool> NYYKJMMMVUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MultiValueConfigProperty<float> LOIVHESGTRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly JOZAIBGQSDW? SSSHYSDZGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly RTIIRYITTNT? DFLRIIQALTN;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B31E20", Offset = "0x9B30E20", VA = "0x189B31E20")]
		public FNODHGRCZRE(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, JOZAIBGQSDW? sandboxColorableOptions, RTIIRYITTNT? syncedComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B31CE0", Offset = "0x9B30CE0", VA = "0x189B31CE0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class FBJXUIMLZTQ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public FBJXUIMLZTQ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B3C890", Offset = "0x9B3B890", VA = "0x189B3C890")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly IReadOnlyList<CircuitsTransformBehavior> NTFJBKBUZUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly MultiValueConfigProperty<CircuitsTransformBehavior> UHHUJLIDEAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly LHQKDVPNESN? FUMZJIXOLTP;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B315C0", Offset = "0x9B305C0", VA = "0x189B315C0")]
		private static string LCACSCHFMRX(CircuitsTransformBehavior a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B31420", Offset = "0x9B30420", VA = "0x189B31420")]
		public FBJXUIMLZTQ(MultiValueConfigProperty<CircuitsTransformBehavior> a, LHQKDVPNESN? objectBoardConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B31480", Offset = "0x9B30480", VA = "0x189B31480", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class PKNSUXQOXAH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public PKNSUXQOXAH NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B45A60", Offset = "0x9B44A60", VA = "0x189B45A60")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string GOADRWHECSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly MultiValueConfigProperty<string> JDNKINLTVOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly MultiValueConfigProperty<bool> ADMBFJQIQSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MultiValueConfigProperty<bool> BAFDCVWQYYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MultiValueConfigProperty<bool> QDFNKABYERQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly SRBLGUGSSZJ? ZKILCUUPHFI;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9B3C250", Offset = "0x9B3B250", VA = "0x189B3C250")]
		public PKNSUXQOXAH(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, SRBLGUGSSZJ? portalInteractionFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9B3C110", Offset = "0x9B3B110", VA = "0x189B3C110", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class BZZMDWTYINU : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public BZZMDWTYINU NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B32940", Offset = "0x9B31940", VA = "0x189B32940")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string GOADRWHECSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly MultiValueConfigProperty<string> JDNKINLTVOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly MultiValueConfigProperty<bool> ADMBFJQIQSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly MultiValueConfigProperty<float> WHIMVCCMPVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly MultiValueConfigProperty<bool> TVJCHEUYZHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly MultiValueConfigProperty<bool> EBPWMJCRQSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MultiValueConfigProperty<bool> BAFDCVWQYYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly MultiValueConfigProperty<bool> EFRKAEENBNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly MultiValueConfigProperty<float> FQGNGCLWNHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly SRBLGUGSSZJ? WPMCWDNCOQW;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2EE00", Offset = "0x9B2DE00", VA = "0x189B2EE00")]
		public BZZMDWTYINU(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<float> g, SRBLGUGSSZJ? interactionFilterOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B2ECC0", Offset = "0x9B2DCC0", VA = "0x189B2ECC0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class NSLBIEFTTGV : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public NSLBIEFTTGV NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Func<bool> CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Func<bool> CUTGVDPQFFJ;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B46A10", Offset = "0x9B45A10", VA = "0x189B46A10")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B47E90", Offset = "0x9B46E90", VA = "0x189B47E90")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B48070", Offset = "0x9B47070", VA = "0x189B48070")]
			internal bool ENHCVCJSOAU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Dictionary<LocomotionFilterModes, string> XFZCWCZYGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly MultiValueConfigProperty<bool> TXACMDGZRVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MultiValueConfigProperty<bool> UESIQIBPSCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MultiValueConfigProperty<bool> NNEVOQCNGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MultiValueConfigProperty<bool> QKIUUPQJLFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MultiValueConfigProperty<string> ZXCCTHBVBAU;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9B396B0", Offset = "0x9B386B0", VA = "0x189B396B0")]
		public NSLBIEFTTGV(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> roleFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9B39470", Offset = "0x9B38470", VA = "0x189B39470", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class PMEFJUXWKSF : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public PMEFJUXWKSF NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9B3E610", Offset = "0x9B3D610", VA = "0x189B3E610")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F1B0", Offset = "0x9B3E1B0", VA = "0x189B3F1B0")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MultiValueConfigProperty<bool> NYYKJMMMVUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly MultiValueConfigProperty<bool> VUKWKETLVJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly SRBLGUGSSZJ? AHZMWCJUWSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly MultiValueConfigProperty<bool> PLXXHBWXURZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly MultiValueConfigProperty<bool> DOVISTOHDPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly MultiValueConfigProperty<bool> NNEVOQCNGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly RTIIRYITTNT RUWGFAQRLHM;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9B3C480", Offset = "0x9B3B480", VA = "0x189B3C480")]
		public PMEFJUXWKSF(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, SRBLGUGSSZJ? playerInteractionFilter, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, RTIIRYITTNT syncComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B3C330", Offset = "0x9B3B330", VA = "0x189B3C330", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class MKCBCZEGLPR : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public MKCBCZEGLPR NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Func<bool> CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public Func<bool> CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<bool> CUDMDJHYCXI;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D950", Offset = "0x9B3C950", VA = "0x189B3D950")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F270", Offset = "0x9B3E270", VA = "0x189B3F270")]
			internal bool ENHCVCJSOAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F270", Offset = "0x9B3E270", VA = "0x189B3F270")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F310", Offset = "0x9B3E310", VA = "0x189B3F310")]
			internal bool EMWPAOVXVEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F370", Offset = "0x9B3E370", VA = "0x189B3F370")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly Dictionary<TriggerVolumeV1Mode, string> SKDFWFCSQCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MultiValueConfigProperty<TriggerVolumeV1Mode> TGQDEOKALZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly bool CQYDMOTHTUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly MultiValueConfigProperty<bool> QIJBYZUTPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly MultiValueConfigProperty<bool> CYZWSJKRWTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly MultiValueConfigProperty<string> UDXTYGANXTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly MultiValueConfigProperty<string> RMQGFVNWMKE;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9B38D80", Offset = "0x9B37D80", VA = "0x189B38D80")]
		public MKCBCZEGLPR(MultiValueConfigProperty<int> a, bool b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> filterTag, MultiValueConfigProperty<string> filterRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B38B50", Offset = "0x9B37B50", VA = "0x189B38B50", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class FCZNFCUFXWF : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public FCZNFCUFXWF NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9B2FD60", Offset = "0x9B2ED60", VA = "0x189B2FD60")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9B304E0", Offset = "0x9B2F4E0", VA = "0x189B304E0")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly MultiValueConfigProperty<bool> CYZWSJKRWTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly GUNRAZGYEGZ GPLDUOLQGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly MultiValueConfigProperty<string> BTZKXSXFKCF;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B317E0", Offset = "0x9B307E0", VA = "0x189B317E0")]
		public FCZNFCUFXWF(MultiValueConfigProperty<bool> a, GUNRAZGYEGZ objectTagsConfig, MultiValueConfigProperty<string> filterByRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B316A0", Offset = "0x9B306A0", VA = "0x189B316A0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class UKHFLECLLEM : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class TNCYCEOSYMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public UKHFLECLLEM NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TNCYCEOSYMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B418E0", Offset = "0x9B408E0", VA = "0x189B418E0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly MultiValueConfigProperty<bool> CYZWSJKRWTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly MultiValueConfigProperty<bool> SNLYAPIQGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> TYLGOJFZQZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ConfigProperty<IReadOnlyList<string>> ILBLVJOMTLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly ConfigProperty<IReadOnlyList<string>>? XSZIDNPMSES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly MultiValueConfigProperty<bool> JZVOCYHBSEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> IWIKOFGLEVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly ConfigProperty<IReadOnlyList<string>> DRXMATKOQLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ConfigProperty<IReadOnlyList<string>>? RONZZUCTOAA;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B43620", Offset = "0x9B42620", VA = "0x189B43620")]
		public UKHFLECLLEM(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<InteractionFilterMode> d, ConfigProperty<IReadOnlyList<string>> persistentPlayerTags, ConfigProperty<IReadOnlyList<string>>? runtimePlayerTags, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<InteractionFilterMode> f, ConfigProperty<IReadOnlyList<string>> persistentObjectTags, ConfigProperty<IReadOnlyList<string>>? runtimeObjectTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9B434E0", Offset = "0x9B424E0", VA = "0x189B434E0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
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
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		public ConfigProperty(Func<T> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class SZZKEGGWXBB
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class SJBJABCBNQR<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Func<a, b> EZKNHGFIRIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ConfigProperty<a> KFDRVMSKNUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Func<b, a> JJLVUFXULGO;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SJBJABCBNQR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD100", Offset = "0x7ABC100", VA = "0x187ABD100")]
			internal b RYYJOXEWNUN()
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC6B0", Offset = "0x7ABB6B0", VA = "0x187ABC6B0")]
			internal void ABBKYQFXEVY(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8C20", Offset = "0x3EF7C20", VA = "0x183EF8C20")]
		public static ConfigProperty<U> To<U, T>(this ConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(ConfigProperty<U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class ZXOYMLJKTQG : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KXPJFHIHHEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public ZXOYMLJKTQG NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> CUNZXWVSVUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Action CUTGVDPQFFJ;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KXPJFHIHHEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9B379E0", Offset = "0x9B369E0", VA = "0x189B379E0")]
			internal bool NRFBRXHWUOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9B36F80", Offset = "0x9B35F80", VA = "0x189B36F80")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9B376D0", Offset = "0x9B366D0", VA = "0x189B376D0")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9B37970", Offset = "0x9B36970", VA = "0x189B37970")]
			internal bool ENMJSJDPXMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9B37860", Offset = "0x9B36860", VA = "0x189B37860")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9B37910", Offset = "0x9B36910", VA = "0x189B37910")]
			internal void ENHCVCJSOAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly (int, string)[] TLUZSANFGKJ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly Dictionary<int, string> AQMLDXFXVXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly int OORBOQSVACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly SRBLGUGSSZJ? UEAXMZVOUKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ConfigProperty<int> PLHBUDKTLHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Action<UTKZHCFJKWF.MultiTogglePickerData> VCZBPGPNVMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly MultiValueConfigProperty<bool> LALMQTAQKOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly MultiValueConfigProperty<bool> KSQJBNMRVEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly QNXLTEOYIWN? DZHUKINFLQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly Func<Option<bool>> IDJBUDABHLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly MultiValueConfigProperty<bool> NYROHBTLGNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MultiValueConfigProperty<bool> GFUVMEEUOSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Func<bool> PHAVUABHLZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly RoomKeyConfig EUHKYGOEHLA;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4AD80", Offset = "0x9B49D80", VA = "0x189B4AD80")]
		public ZXOYMLJKTQG(int a, SRBLGUGSSZJ? additionalCostumeConfigOptions, ConfigProperty<int> b, Action<UTKZHCFJKWF.MultiTogglePickerData> onOutfitFilterClick, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, QNXLTEOYIWN? playerRolesToAddData, Func<Option<bool>> hasPlayerEquipped, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, Func<bool> isLegacyRoom, RoomKeyConfig roomKeyConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B4A700", Offset = "0x9B49700", VA = "0x189B4A700", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class TILQFUQJJRZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly MultiValueConfigProperty<int> SMTLFAROGJU;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public TILQFUQJJRZ(MultiValueConfigProperty<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B41750", Offset = "0x9B40750", VA = "0x189B41750", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class XDKLYITKBPC : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class BHKCBBITDAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public XDKLYITKBPC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public ConfigProperty<int[]> QYQCNCSRKNV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public Func<bool> CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public Func<bool> IDFQUXMYXZS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public Func<bool> IDKXSEGWHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<bool> CDRDZQJBJTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Func<bool> ICVDAJZEFDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Func<bool> IDAJXQTBOOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public Func<bool> CDLXCJPEAII;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BHKCBBITDAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B2A2A0", Offset = "0x9B292A0", VA = "0x189B2A2A0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C380", Offset = "0x9B2B380", VA = "0x189B2C380")]
			internal bool ENRQPPXNGXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9B2AA50", Offset = "0x9B29A50", VA = "0x189B2AA50")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9B2AFF0", Offset = "0x9B29FF0", VA = "0x189B2AFF0")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B2B530", Offset = "0x9B2A530", VA = "0x189B2B530")]
			internal void ENBVXVPVEPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C5E0", Offset = "0x9B2B5E0", VA = "0x189B2C5E0")]
			internal bool VGPTFMBVJYF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C570", Offset = "0x9B2B570", VA = "0x189B2C570")]
			internal bool VGKMIFHYAMW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9B2A150", Offset = "0x9B29150", VA = "0x189B2A150")]
			internal bool CFQVACGTCDU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C4B0", Offset = "0x9B2B4B0", VA = "0x189B2C4B0")]
			internal bool VFKDVXMLFID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C3F0", Offset = "0x9B2B3F0", VA = "0x189B2C3F0")]
			internal bool VFEWYQSNVWU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9B2BE50", Offset = "0x9B2AE50", VA = "0x189B2BE50")]
			internal void ENHCVCJSOAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B2A210", Offset = "0x9B29210", VA = "0x189B2A210")]
			internal bool CFWBXJAQLPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C1E0", Offset = "0x9B2B1E0", VA = "0x189B2C1E0")]
			internal void ENMJSJDPXMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class BHPIYICQMLR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public bool FATAOAGNYSE;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BHPIYICQMLR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80")]
			internal bool EOCEKDLHZUE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class BHUPVOWNVXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public int HWIUJQPSVYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public BHKCBBITDAI LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BHUPVOWNVXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C650", Offset = "0x9B2B650", VA = "0x189B2C650")]
			internal bool EOHLHKFFJFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C770", Offset = "0x9B2B770", VA = "0x189B2C770")]
			internal void VEZQBJYQMLL(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C720", Offset = "0x9B2B720", VA = "0x189B2C720")]
			internal bool VEPCGWKVTOT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C6C0", Offset = "0x9B2B6C0", VA = "0x189B2C6C0")]
			internal string VEJVJPQYKDK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class BHZWSVQLFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public bool QWCRERVRBWT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public BHUPVOWNVXA LWUNUJXBPSG;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BHZWSVQLFIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9B2CA70", Offset = "0x9B2BA70", VA = "0x189B2CA70")]
			internal bool VEUJEDETDAC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly IReadOnlyList<VoiceOption> XFPPNFBGXDH;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly IReadOnlyList<VoiceOption> EVPAGNTDAQW;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly IReadOnlyList<RolloffCurve> HPNZGSKCINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly MultiValueConfigProperty<string> ORJYQLKOQWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly int CTAKKVTAQFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly MultiValueConfigProperty<float> EAMCZOYBHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly MultiValueConfigProperty<VoiceOption> PGCYWCFXUZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly MultiValueConfigProperty<string> IVURRDKFRNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly MultiValueConfigProperty<bool> RRNTJJPOVSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly MultiValueConfigProperty<bool> ZHOGWZIWOIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly string JDEOIEJSCYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly MultiValueConfigProperty<bool>? UTBXFNGHQZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly MultiValueConfigProperty<bool>[] BIIGNEMOVNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly IReadOnlyList<string> NDUHVKBJAJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly IReadOnlyList<string> HWJOZVYINTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly IReadOnlyList<bool> XORYRURUPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly ConfigProperty<int[]>? NKOVAZTKYFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Func<IEnumerable<int>> LPWSYRKOTPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Func<int, bool> MABFPNRBCMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly Func<int, string?> MYZRVDAVFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly Func<int, string?> LPITOXQBQGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string AOJTFEXNYVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly MultiValueConfigProperty<bool> SMPLZOVUQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly MultiValueConfigProperty<float> GREJEQZJDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly MultiValueConfigProperty<RolloffCurve> OZOEUPZEUVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly MultiValueConfigProperty<bool> ISRDAGFNBZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly MultiValueConfigProperty<bool>? BGVACJMVYIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly MultiValueConfigProperty<bool> KOKFEGTKKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly MultiValueConfigProperty<bool> KDHARIVJTJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly MultiValueConfigProperty<bool>? TKXWWKAEUKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly MultiValueConfigProperty<float>? ADGJEJXMMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly bool YEJOQRNWMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly MultiValueConfigProperty<int> QHYKBZUAEKY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool NQJKNDSBQRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9B488E0", Offset = "0x9B478E0", VA = "0x189B488E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool ITUNJRSKAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9B48820", Offset = "0x9B47820", VA = "0x189B48820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B48930", Offset = "0x9B47930", VA = "0x189B48930")]
		private static string UJJQQNUEXYV(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9B48E90", Offset = "0x9B47E90", VA = "0x189B48E90")]
		public XDKLYITKBPC(MultiValueConfigProperty<string> instructions, int a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<VoiceOption> c, MultiValueConfigProperty<bool>? d, MultiValueConfigProperty<string> useContext, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, string aiSettingsInfoText, MultiValueConfigProperty<bool>? g, MultiValueConfigProperty<bool>[] functionEnablements, IReadOnlyList<string> functionEnablementNames, IReadOnlyList<string> functionEnablementDescriptions, IReadOnlyList<bool> functionEnablementVisibilities, ConfigProperty<int[]>? circuitsFunctionEnablements, Func<IEnumerable<int>> getAllCircuitsFunctionIds, Func<int, bool> getCircuitsFunctionExists, Func<int, string?> getCircuitsFunctionName, Func<int, string?> getCircuitsFunctionInvalidReason, string useSpatialAudioLabel, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<RolloffCurve> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool>? n, MultiValueConfigProperty<float>? o, bool p, MultiValueConfigProperty<int> q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B482F0", Offset = "0x9B472F0", VA = "0x189B482F0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class QGCFDZUSPII : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public QGCFDZUSPII NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B38150", Offset = "0x9B37150", VA = "0x189B38150")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly MultiValueConfigProperty<bool> ZZZXTGYKDSJ;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public QGCFDZUSPII(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D790", Offset = "0x9B3C790", VA = "0x189B3D790", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class SNJHAYOZHWP : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public SNJHAYOZHWP NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9B382A0", Offset = "0x9B372A0", VA = "0x189B382A0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly MultiValueConfigProperty<bool> NLENULOKKXT;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public SNJHAYOZHWP(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B409D0", Offset = "0x9B3F9D0", VA = "0x189B409D0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class UAWVYEJNLDZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly string VAAONOQBYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly MultiValueConfigProperty<bool> RTYARQXOZIQ;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B43260", Offset = "0x9B42260", VA = "0x189B43260")]
		public UAWVYEJNLDZ(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B43140", Offset = "0x9B42140", VA = "0x189B43140", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class BUDTRXVHZDY : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public BUDTRXVHZDY NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B34D60", Offset = "0x9B33D60", VA = "0x189B34D60")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly MultiValueConfigProperty<bool> QVRJBGMRSWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly MultiValueConfigProperty<bool> PEWTKDPESBD;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CD50", Offset = "0x9B2BD50", VA = "0x189B2CD50")]
		public BUDTRXVHZDY(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CC10", Offset = "0x9B2BC10", VA = "0x189B2CC10", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class GQFWACWRPDX : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public GQFWACWRPDX NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public Func<bool> CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9B2D2D0", Offset = "0x9B2C2D0", VA = "0x189B2D2D0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E430", Offset = "0x9B2D430", VA = "0x189B2E430")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E790", Offset = "0x9B2D790", VA = "0x189B2E790")]
			internal bool EMWPAOVXVEC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly SRBLGUGSSZJ WPMCWDNCOQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly Func<bool> OGLTYJPGTGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly Action YZEUJVZMMUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly bool RYQOXGLJMPR;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B34940", Offset = "0x9B33940", VA = "0x189B34940")]
		public GQFWACWRPDX(int a, SRBLGUGSSZJ b, Action c, Func<bool> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B34800", Offset = "0x9B33800", VA = "0x189B34800", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class LNEBPNGMJBD : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class XBXTJYSUXKU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public readonly MultiValueConfigProperty<float> FUVQVMDDOLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public readonly MultiValueConfigProperty<float> AEKZFHHFDLK;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9B2CD50", Offset = "0x9B2BD50", VA = "0x189B2CD50")]
			public XBXTJYSUXKU(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public sealed class VXHDJHXJHQI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public readonly MultiValueConfigProperty<float> FCHEYIOQBEW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public readonly MultiValueConfigProperty<float> ORPPWIUNCPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public readonly MultiValueConfigProperty<bool> KLHDHBTGIRI;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9B448B0", Offset = "0x9B438B0", VA = "0x189B448B0")]
			public VXHDJHXJHQI(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class VJYQYATWQML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public readonly MultiValueConfigProperty<float> UQOHMPRAKYO;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
			public VJYQYATWQML(MultiValueConfigProperty<float> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public LNEBPNGMJBD NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9B326E0", Offset = "0x9B316E0", VA = "0x189B326E0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x9B33650", Offset = "0x9B32650", VA = "0x189B33650")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9B33F80", Offset = "0x9B32F80", VA = "0x189B33F80")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x9B34120", Offset = "0x9B33120", VA = "0x189B34120")]
			internal void ENBVXVPVEPL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly MultiValueConfigProperty<int> GTULMLJHMRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly MultiValueConfigProperty<int> MIKYIRYOUFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly XBXTJYSUXKU VOEFOKUESCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly VXHDJHXJHQI JAWLXVXFJYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly VJYQYATWQML RHCYEGOYCUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MultiValueConfigProperty<bool> USKUXZNNTWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly WIOHPWANRTB EIEVINRHCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly WIOHPWANRTB IMYRKRRPSCD;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B37D00", Offset = "0x9B36D00", VA = "0x189B37D00")]
		public LNEBPNGMJBD(MultiValueConfigProperty<float> vehicleMass, MultiValueConfigProperty<int> boostFuelCapacity, XBXTJYSUXKU a, VXHDJHXJHQI b, VJYQYATWQML c, MultiValueConfigProperty<bool> canFrontWheelsSteer, WIOHPWANRTB d, WIOHPWANRTB e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B37A00", Offset = "0x9B36A00", VA = "0x189B37A00", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class WIOHPWANRTB : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MultiValueConfigProperty<bool> EHNMJOXAWSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly MultiValueConfigProperty<bool> NNZZYYOHSPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly MultiValueConfigProperty<float> KFXVWOVVNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly MultiValueConfigProperty<float> GBZMETFSPMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly MultiValueConfigProperty<float> EKUPNHYILUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private readonly MultiValueConfigProperty<float> IDJYQJBQXOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private readonly MultiValueConfigProperty<float> XRFYDBJFXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly MultiValueConfigProperty<float> TMMZCAQYODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly MultiValueConfigProperty<float> JSOLOFKLPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly MultiValueConfigProperty<float> MNNBKVHCNZC;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B453A0", Offset = "0x9B443A0", VA = "0x189B453A0")]
		public WIOHPWANRTB(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B44940", Offset = "0x9B43940", VA = "0x189B44940", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class ARZLHPEJFBD : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public ARZLHPEJFBD NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9B3CAE0", Offset = "0x9B3BAE0", VA = "0x189B3CAE0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly MultiValueConfigProperty<float> ZQFFHPSVUNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly MultiValueConfigProperty<float> BUTTUHLMRVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly MultiValueConfigProperty<float> LQVEBBBGFRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly MultiValueConfigProperty<float> UTLIOBTIGYP;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A0A0", Offset = "0x9B290A0", VA = "0x189B2A0A0")]
		public ARZLHPEJFBD(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B29F60", Offset = "0x9B28F60", VA = "0x189B29F60", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class BWKXIPPYRAY : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly MultiValueConfigProperty<bool> YLKDXYTIVUQ;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public BWKXIPPYRAY(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CDC0", Offset = "0x9B2BDC0", VA = "0x189B2CDC0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class JRWXCLRWCBH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public JRWXCLRWCBH NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B303D0", Offset = "0x9B2F3D0", VA = "0x189B303D0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B30540", Offset = "0x9B2F540", VA = "0x189B30540")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly THQMIIWNKBC LJYYKJSQMSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly BWKXIPPYRAY IHHCIHACYGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly MultiValueConfigProperty<bool> AHWGZDUARFQ;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B36120", Offset = "0x9B35120", VA = "0x189B36120")]
		public JRWXCLRWCBH(THQMIIWNKBC a, BWKXIPPYRAY b, MultiValueConfigProperty<bool> hideProjector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B35F50", Offset = "0x9B34F50", VA = "0x189B35F50", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class AJUKSEZIZTC : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public AJUKSEZIZTC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B34BE0", Offset = "0x9B33BE0", VA = "0x189B34BE0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9B35030", Offset = "0x9B34030", VA = "0x189B35030")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly MultiValueConfigProperty<bool> VILYRZUCIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Option<bool> TJQKWDGTFSZ;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B29D10", Offset = "0x9B28D10", VA = "0x189B29D10")]
		public AJUKSEZIZTC(Option<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B29BE0", Offset = "0x9B28BE0", VA = "0x189B29BE0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class DKEORRSBLJQ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public DKEORRSBLJQ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9B30100", Offset = "0x9B2F100", VA = "0x189B30100")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly IReadOnlyDictionary<PhysicsMode, string> XFHRPXBOUKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly MultiValueConfigProperty<PhysicsMode> PIPKWQYRROI;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B30B80", Offset = "0x9B2FB80", VA = "0x189B30B80")]
		public DKEORRSBLJQ(int a, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B30920", Offset = "0x9B2F920", VA = "0x189B30920", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class SMCVQGPHIMU : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public SMCVQGPHIMU NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9B38000", Offset = "0x9B37000", VA = "0x189B38000")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly MultiValueConfigProperty<bool> EITUHFLSVHJ;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public SMCVQGPHIMU(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B40750", Offset = "0x9B3F750", VA = "0x189B40750", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class THQMIIWNKBC : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly string NCNYZTRDNFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly Action HGNNNYXVRNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public readonly Func<Option<bool>> BXHPIXPVCZF;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xDDB9F0", Offset = "0xDDA9F0", VA = "0x180DDB9F0")]
		public THQMIIWNKBC(string a, Action b, Func<Option<bool>> hasRecordableData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9B415A0", Offset = "0x9B405A0", VA = "0x189B415A0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B416F0", Offset = "0x9B406F0", VA = "0x189B416F0")]
		[CompilerGenerated]
		private bool YNFOWIQFBKL()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class RoomKeyConfig : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public RoomKeyConfig NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9B34D00", Offset = "0x9B33D00", VA = "0x189B34D00")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9B34FE0", Offset = "0x9B33FE0", VA = "0x189B34FE0")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly WSAUQURDKXO EQLORQFCAUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly Func<InventionPermission> YJKDMPPBFYV;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		public RoomKeyConfig(WSAUQURDKXO roomKeyOptions, Func<InventionPermission> getLowestInventionPermission)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B402A0", Offset = "0x9B3F2A0", VA = "0x189B402A0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class WSAUQURDKXO : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public WSAUQURDKXO NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9B45870", Offset = "0x9B44870", VA = "0x189B45870")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9B47B60", Offset = "0x9B46B60", VA = "0x189B47B60")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public readonly bool TGUGNPYPGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly string VWFABCBTHWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Func<bool> IVCJUBTBPVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly Func<bool> FYCIKFYRNPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly Action? LHMUAXMUHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly MultiValueConfigProperty<Guid> GGZMKFNEGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly Action<UTKZHCFJKWF.RoomKeyPickerData> HJPONYJLHER;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9B481F0", Offset = "0x9B471F0", VA = "0x189B481F0")]
		public WSAUQURDKXO(Option<bool> isTrialInvention, Func<bool> a, Func<bool> b, Action? onCreateKeyClick, MultiValueConfigProperty<Guid> equipLockKeyId, Action<UTKZHCFJKWF.RoomKeyPickerData> c, [Optional] string? lockLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9B480E0", Offset = "0x9B470E0", VA = "0x189B480E0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class QNXLTEOYIWN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public readonly IReadOnlyList<(Guid, string)> TRFLUNIXYGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public readonly ConfigProperty<IReadOnlyCollection<Guid>> MDSBKMJCRCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public readonly Action<UTKZHCFJKWF.MultiTogglePickerData> FBCOMVKIBBL;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D8D0", Offset = "0x9B3C8D0", VA = "0x189B3D8D0")]
		public QNXLTEOYIWN(IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<UTKZHCFJKWF.MultiTogglePickerData> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class FEWPSFUMJTV : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public FEWPSFUMJTV NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9B2DD30", Offset = "0x9B2CD30", VA = "0x189B2DD30")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly MultiValueConfigProperty<int> QJSZFVDITJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly MultiValueConfigProperty<int> RXEUZSYWDRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly MultiValueConfigProperty<int> RWZOCMEYUFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly MultiValueConfigProperty<int> RWUHFFLBKUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly MultiValueConfigProperty<string> SVEVRWBVRIM;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9B319B0", Offset = "0x9B309B0", VA = "0x189B319B0")]
		public FEWPSFUMJTV(MultiValueConfigProperty<int> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<int> d, MultiValueConfigProperty<string> stateName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9B31870", Offset = "0x9B30870", VA = "0x189B31870", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class BWLHUAEICOK : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public BWLHUAEICOK NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B47260", Offset = "0x9B46260", VA = "0x189B47260")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly MultiValueConfigProperty<float> RMMVPTKNWCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly MultiValueConfigProperty<bool> KZOFBQLBUBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly MultiValueConfigProperty<TexturedQuadMaterialType> TTSRGIYHKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly RTIIRYITTNT? SQWBWMBYYXA;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly IReadOnlyList<TexturedQuadMaterialType> VPUOCIMCQMH;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9B2D220", Offset = "0x9B2C220", VA = "0x189B2D220")]
		public BWLHUAEICOK(MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<TexturedQuadMaterialType> c, RTIIRYITTNT? syncComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF40", Offset = "0x9B2BF40", VA = "0x189B2CF40", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class OIDIJGQSMGN : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public OIDIJGQSMGN NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9B385D0", Offset = "0x9B375D0", VA = "0x189B385D0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly MultiValueConfigProperty<bool> BQJPLCMQEXR;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public OIDIJGQSMGN(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9B3BA90", Offset = "0x9B3AA90", VA = "0x189B3BA90", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class RZWBCTYPEAD : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class KXPJFHIHHEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public RZWBCTYPEAD NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KXPJFHIHHEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9B364D0", Offset = "0x9B354D0", VA = "0x189B364D0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static readonly IReadOnlyDictionary<TrailWidthCurveTypes, string> EOVFNKMJOMQ;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly IReadOnlyDictionary<TrailGradientTypes, string> PNANTBZVJXO;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private static readonly IReadOnlyDictionary<TrailMaterialTypes, string> XQUIPTOVQAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly MultiValueConfigProperty<bool> PJIQSUURRNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly MultiValueConfigProperty<bool> ECGKHZFYQGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly MultiValueConfigProperty<float> TQRTXNTYGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly MultiValueConfigProperty<float> PFDJOODWJMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly MultiValueConfigProperty<float> ZMKMIMNTJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly MultiValueConfigProperty<float> LQGUTOWAPWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly MultiValueConfigProperty<TrailWidthCurveTypes> JTQGNXWJEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly MultiValueConfigProperty<TrailGradientTypes> OKPDTYPPROW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly MultiValueConfigProperty<TrailMaterialTypes> ZINGTNQYJJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly JOZAIBGQSDW? MQKCLMFWLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly RTIIRYITTNT YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9B400E0", Offset = "0x9B3F0E0", VA = "0x189B400E0")]
		public RZWBCTYPEAD(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<TrailWidthCurveTypes> g, MultiValueConfigProperty<TrailGradientTypes> h, MultiValueConfigProperty<TrailMaterialTypes> i, JOZAIBGQSDW? colorableOptions, RTIIRYITTNT syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B3FB60", Offset = "0x9B3EB60", VA = "0x189B3FB60", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class DWTCAWLZWZG : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class NTLIKMEKOOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public DWTCAWLZWZG NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public (Color32 x, Color32 y, Color32 z) FZIXGYNCSLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Func<bool> CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Func<bool> CUNZXWVSVUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Action CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Action CUYNSKJNOQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public NTLIKMEKOOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9B39790", Offset = "0x9B38790", VA = "0x189B39790")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9B399D0", Offset = "0x9B389D0", VA = "0x189B399D0")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9B3ACD0", Offset = "0x9B39CD0", VA = "0x189B3ACD0")]
			internal bool ENHCVCJSOAU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x9B3A280", Offset = "0x9B39280", VA = "0x189B3A280")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x9B3AD10", Offset = "0x9B39D10", VA = "0x189B3AD10")]
			internal bool ENMJSJDPXMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9B3AB60", Offset = "0x9B39B60", VA = "0x189B3AB60")]
			internal void ENBVXVPVEPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9B3AD50", Offset = "0x9B39D50", VA = "0x189B3AD50")]
			internal void ENRQPPXNGXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9B3B1F0", Offset = "0x9B3A1F0", VA = "0x189B3B1F0")]
			internal void ENWXMWRKQIV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly Func<bool>? VREDQUOCPRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly Func<bool> SNSUSKBXZNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly Func<bool> FSMPOZKDEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly MultiValueConfigProperty<float> OVRPVZERQVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private readonly MultiValueConfigProperty<float> OVMIYSKUHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private readonly MultiValueConfigProperty<float> OWCDQMSMJSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private readonly MultiValueConfigProperty<float> KMFDCXAFCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly MultiValueConfigProperty<float> KMKKADUCLUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly MultiValueConfigProperty<float> KLUPIJMKJMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly Func<bool> PYBTBUVXHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly Func<bool> SHHCDHVOESC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly MultiValueConfigProperty<float> BKKSODCGQEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly MultiValueConfigProperty<float> BKPZLJWDZPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly MultiValueConfigProperty<float> BKVGIQQBJAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly MultiValueConfigProperty<float> VJCGHWTDTNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly MultiValueConfigProperty<float> VIWZKPZGKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly MultiValueConfigProperty<float> VIRSNJFJAQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Func<bool> MMQCCHCUAXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Func<bool> NIRRLCWGFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly MultiValueConfigProperty<float> URJBZSDLQWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly MultiValueConfigProperty<float> UROIWYXJAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly MultiValueConfigProperty<float> URTPUFRGJTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly MultiValueConfigProperty<float> UBEJVXLOWVW;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B30F60", Offset = "0x9B2FF60", VA = "0x189B30F60")]
		public DWTCAWLZWZG(Func<bool> supportsTranslation, Func<bool> isWorldPositionVisible, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, Func<bool> supportsRotation, Func<bool> isWorldRotationVisible, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j, MultiValueConfigProperty<float> k, MultiValueConfigProperty<float> l, Func<bool> supportsScaling, Func<bool> supportsDeformation, MultiValueConfigProperty<float> m, MultiValueConfigProperty<float> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, [Optional] Func<bool>? isFoldoutVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B30DB0", Offset = "0x9B2FDB0", VA = "0x189B30DB0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class TFRMPXLDUID : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public TFRMPXLDUID NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9B3C590", Offset = "0x9B3B590", VA = "0x189B3C590")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static readonly IReadOnlyDictionary<GrabberAttachmentMode, string> MSQBJJPZQZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly MultiValueConfigProperty<GrabberAttachmentMode> EJCXXRJXZNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private readonly MultiValueConfigProperty<bool> KOPEMSQAVXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private readonly RTIIRYITTNT YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9B41510", Offset = "0x9B40510", VA = "0x189B41510")]
		public TFRMPXLDUID(MultiValueConfigProperty<GrabberAttachmentMode> a, MultiValueConfigProperty<bool> b, RTIIRYITTNT syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B412C0", Offset = "0x9B402C0", VA = "0x189B412C0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class FNLWEEAFUEZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly IEnumerable<AKHMQFVEMZJ> HCYEBGYGVAN;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public FNLWEEAFUEZ(IEnumerable<AKHMQFVEMZJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9B31A90", Offset = "0x9B30A90", VA = "0x189B31A90", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class GBARUGPAPEG : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public GBARUGPAPEG NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9B2D3E0", Offset = "0x9B2C3E0", VA = "0x189B2D3E0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E620", Offset = "0x9B2D620", VA = "0x189B2E620")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E820", Offset = "0x9B2D820", VA = "0x189B2E820")]
			internal void EMWPAOVXVEC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public readonly Option<bool> OYGZRMWJEMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private readonly MultiValueConfigProperty<float> WHBPPTAYDMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private readonly MultiValueConfigProperty<bool> IZTNSEEDPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private readonly MultiValueConfigProperty<bool> DAIWLRVISCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly MultiValueConfigProperty<bool> TYLKBELWIRF;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9B32220", Offset = "0x9B31220", VA = "0x189B32220")]
		public GBARUGPAPEG(Option<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9B32000", Offset = "0x9B31000", VA = "0x189B32000", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class JWVMVJFATSN : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public JWVMVJFATSN NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9B460D0", Offset = "0x9B450D0", VA = "0x189B460D0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static readonly Dictionary<int, string> RFNCSIWJLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly MultiValueConfigProperty<int> TUMXTIENKQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private readonly MultiValueConfigProperty<float> QRSPBTBVSCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private readonly MultiValueConfigProperty<bool> KBZUQSTEWAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly MultiValueConfigProperty<bool> VRHRJLXISQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly MultiValueConfigProperty<bool> EEJBTWLKGIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly MultiValueConfigProperty<int> LKWENNREEAS;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9B363D0", Offset = "0x9B353D0", VA = "0x189B363D0")]
		public JWVMVJFATSN(MultiValueConfigProperty<int> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9B361A0", Offset = "0x9B351A0", VA = "0x189B361A0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SALKYCLMWFC : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public SALKYCLMWFC NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9B3EBB0", Offset = "0x9B3DBB0", VA = "0x189B3EBB0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F290", Offset = "0x9B3E290", VA = "0x189B3F290")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly Dictionary<int, string> RFNCSIWJLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly Action? BMMBBHBHIQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly int JEANVDQEXUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly MultiValueConfigProperty<int> TUMXTIENKQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly MultiValueConfigProperty<float> SLNOZGUSRXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private readonly MultiValueConfigProperty<bool> NYIRJLOGFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly MultiValueConfigProperty<bool> EEJBTWLKGIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly MultiValueConfigProperty<int> LKWENNREEAS;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9B40650", Offset = "0x9B3F650", VA = "0x189B40650")]
		public SALKYCLMWFC(Action? openAnimationControls, int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9B40420", Offset = "0x9B3F420", VA = "0x189B40420", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class TOOECBSLJFP : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public TOOECBSLJFP NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9B302C0", Offset = "0x9B2F2C0", VA = "0x189B302C0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x9B306C0", Offset = "0x9B2F6C0", VA = "0x189B306C0")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly GBARUGPAPEG DPZVPAPTBTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly MultiValueConfigProperty<float> FSFSXFFEWUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private readonly Option<UnityEngine.Vector2> JTQCEBZXMCB;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9B42770", Offset = "0x9B41770", VA = "0x189B42770")]
		public TOOECBSLJFP(GBARUGPAPEG acceleratedMovementOptions, MultiValueConfigProperty<float> a, Option<UnityEngine.Vector2> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9B42630", Offset = "0x9B41630", VA = "0x189B42630", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class XRPJTNOQXKJ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public XRPJTNOQXKJ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x9B45550", Offset = "0x9B44550", VA = "0x189B45550")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x9B477C0", Offset = "0x9B467C0", VA = "0x189B477C0")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9B47C20", Offset = "0x9B46C20", VA = "0x189B47C20")]
			internal void EMWPAOVXVEC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private readonly GBARUGPAPEG DPZVPAPTBTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly MultiValueConfigProperty<float> FSFSXFFEWUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private readonly MultiValueConfigProperty<float> QKQSPADRFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private readonly MultiValueConfigProperty<float> FDAHCDWAWFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private readonly MultiValueConfigProperty<float> UNFPNCUKWEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private readonly Option<UnityEngine.Vector2> JTQCEBZXMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private readonly Option<float> FXCJSACLHSY;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9B49890", Offset = "0x9B48890", VA = "0x189B49890")]
		public XRPJTNOQXKJ(GBARUGPAPEG acceleratedMovementOptions, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, Option<UnityEngine.Vector2> c, MultiValueConfigProperty<float> d, Option<float> e, MultiValueConfigProperty<float> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9B49750", Offset = "0x9B48750", VA = "0x189B49750", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class ZHQKQYQAWUN : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public ZHQKQYQAWUN NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9B38570", Offset = "0x9B37570", VA = "0x189B38570")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private readonly GBARUGPAPEG DPZVPAPTBTY;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public ZHQKQYQAWUN(GBARUGPAPEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9B49FD0", Offset = "0x9B48FD0", VA = "0x189B49FD0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class YCCFQFYTKBP : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public YCCFQFYTKBP NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9B2D6C0", Offset = "0x9B2C6C0", VA = "0x189B2D6C0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly Option<float> LPROHCSUOYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private readonly MultiValueConfigProperty<float> WUCQXEQEMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private readonly MultiValueConfigProperty<float> XKFQGTULJSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private readonly MultiValueConfigProperty<float> DNXHWFTPKKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private readonly GBARUGPAPEG DPZVPAPTBTY;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9B49AE0", Offset = "0x9B48AE0", VA = "0x189B49AE0")]
		public YCCFQFYTKBP(Option<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, GBARUGPAPEG acceleratedMovementOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B49980", Offset = "0x9B48980", VA = "0x189B49980", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class XEFRGFOTMUC : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class PEUYNJHNJIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public XEFRGFOTMUC NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PEUYNJHNJIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3BDA0", Offset = "0x9B3ADA0", VA = "0x189B3BDA0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly Dictionary<GlassPaneShapeType, string> FMVJPMUUCKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private readonly MultiValueConfigProperty<float> SMZBLTKPVGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly Func<bool> JLLXPEWWFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly MultiValueConfigProperty<GlassPaneShapeType> IKDRGMWKYLF;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9B494F0", Offset = "0x9B484F0", VA = "0x189B494F0")]
		public XEFRGFOTMUC(MultiValueConfigProperty<float> a, Func<bool> isAllConfigurableShapes, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9B492C0", Offset = "0x9B482C0", VA = "0x189B492C0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class GPOGFBWIZRA : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public GPOGFBWIZRA NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9B383F0", Offset = "0x9B373F0", VA = "0x189B383F0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private readonly SRBLGUGSSZJ TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public GPOGFBWIZRA(SRBLGUGSSZJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9B346C0", Offset = "0x9B336C0", VA = "0x189B346C0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class TVEPZLHWYLR
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public static readonly IReadOnlyDictionary<InteractionFilterMode, string> TRJJOEEDHFC;
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class UXGQBGVOCGZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public UXGQBGVOCGZ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D6B0", Offset = "0x9B3C6B0", VA = "0x189B3D6B0")]
			internal bool IYVHKVCRZPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D310", Offset = "0x9B3C310", VA = "0x189B3D310")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D4B0", Offset = "0x9B3C4B0", VA = "0x189B3D4B0")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D5F0", Offset = "0x9B3C5F0", VA = "0x189B3D5F0")]
			internal void ENBVXVPVEPL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private readonly MultiValueConfigProperty<bool> ZNPKVADMIOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> KVKORJTHJHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private readonly QNXLTEOYIWN? QCBIBNUFQUX;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9B44820", Offset = "0x9B43820", VA = "0x189B44820")]
		public UXGQBGVOCGZ(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<InteractionFilterMode> c, QNXLTEOYIWN? rolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B44500", Offset = "0x9B43500", VA = "0x189B44500", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class LYBTHWMIELA : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public LYBTHWMIELA NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D720", Offset = "0x9B3C720", VA = "0x189B3D720")]
			internal bool IYVHKVCRZPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D450", Offset = "0x9B3C450", VA = "0x189B3D450")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private readonly string VAAONOQBYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private readonly MultiValueConfigProperty<bool> ZNPKVADMIOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> KVKORJTHJHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private readonly GUNRAZGYEGZ? SLWZMVWQXDJ;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B38AB0", Offset = "0x9B37AB0", VA = "0x189B38AB0")]
		public LYBTHWMIELA(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<InteractionFilterMode> b, GUNRAZGYEGZ tagsOptions, string primaryLabel = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9B38720", Offset = "0x9B37720", VA = "0x189B38720", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class IDFZMFURNQP : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public IDFZMFURNQP NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9B300A0", Offset = "0x9B2F0A0", VA = "0x189B300A0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private readonly string VAAONOQBYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> KVKORJTHJHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private readonly GUNRAZGYEGZ? SLWZMVWQXDJ;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9B353E0", Offset = "0x9B343E0", VA = "0x189B353E0")]
		public IDFZMFURNQP(MultiValueConfigProperty<InteractionFilterMode> filterMode, GUNRAZGYEGZ a, string b = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9B35180", Offset = "0x9B34180", VA = "0x189B35180", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface UTKZHCFJKWF
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
				[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0xF2D670", Offset = "0xF2C670", VA = "0x180F2D670")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Action<int> ColorSetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool AllowCustomColors
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xCFDEE0", Offset = "0xCFCEE0", VA = "0x180CFDEE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public bool AllowDefaultColor
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x125B7E0", Offset = "0x125A7E0", VA = "0x18125B7E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x13E0DC0", Offset = "0x13DFDC0", VA = "0x1813E0DC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public Func<int> MaterialGetter
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xF2D670", Offset = "0xF2C670", VA = "0x180F2D670")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public Action<int> MaterialSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool AllowDefaultMaterial
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xCFC420", Offset = "0xCFB420", VA = "0x180CFC420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0xCFC350", Offset = "0xCFB350", VA = "0x180CFC350")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool ForceTransparentQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x15FA5D0", Offset = "0x15F95D0", VA = "0x1815FA5D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x15FA5C0", Offset = "0x15F95C0", VA = "0x1815FA5C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool CameraLit
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x1B9B7A0", Offset = "0x1B9A7A0", VA = "0x181B9B7A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x1DFAFE0", Offset = "0x1DF9FE0", VA = "0x181DFAFE0")]
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
				[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Action<Guid> RoleSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0xF2D670", Offset = "0xF2C670", VA = "0x180F2D670")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
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
				[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public Func<Guid> KeyGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0xF2D670", Offset = "0xF2C670", VA = "0x180F2D670")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public Action<Guid> KeySetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
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
				[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public Func<IReadOnlyCollection<int>> GetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0xF2D670", Offset = "0xF2C670", VA = "0x180F2D670")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public Action<IReadOnlyCollection<int>> SetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Func<IReadOnlyList<string>> GetValueNames
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class AFXEGOBVZPG<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public IReadOnlyDictionary<a, string> JPCWZGFNSVY;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public AFXEGOBVZPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x73145E0", Offset = "0x73135E0", VA = "0x1873145E0")]
			internal string PBMOTDSWTON(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class HMKFPDFQUGP<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			public Func<a, string> OKSTJYFXSWR;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HMKFPDFQUGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x6515620", Offset = "0x6514620", VA = "0x186515620")]
			internal string PBMOTDSWTON(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class NMZAKTMECDY<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public IReadOnlyList<(a, string)> JPCWZGFNSVY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Dictionary<a, int> MXKDDHBJISM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Func<a, int> CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Func<int, a> CUYNSKJNOQS;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public NMZAKTMECDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x72931D0", Offset = "0x72921D0", VA = "0x1872931D0")]
			internal IReadOnlyList<string> RKBCSHRIAFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x72936A0", Offset = "0x72926A0", VA = "0x1872936A0")]
			internal IReadOnlyCollection<int> RKGJPOLFJQT(IReadOnlyCollection<a> values)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x7292C30", Offset = "0x7291C30", VA = "0x187292C30")]
			internal int RJGBDGPSOMA(a a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x7292FF0", Offset = "0x7291FF0", VA = "0x187292FF0")]
			internal IReadOnlyCollection<a> RJQOXUDNHIS(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x7292D70", Offset = "0x7291D70", VA = "0x187292D70")]
			internal a RJLIANJPXXJ(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class RECYFJRDOZU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public IReadOnlyList<(int, string)> JPCWZGFNSVY;

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RECYFJRDOZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F4B0", Offset = "0x9B3E4B0", VA = "0x189B3F4B0")]
			internal IReadOnlyList<string> IRMRSDRHUSK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F5E0", Offset = "0x9B3E5E0", VA = "0x189B3F5E0")]
			internal IReadOnlyCollection<int> IRRYPKLFEDT(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F7D0", Offset = "0x9B3E7D0", VA = "0x189B3F7D0")]
			internal int IRXFMRFCNPC(IReadOnlyCollection<int> a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class REIFCQLAYLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public int GKUOXQORORP;

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public REIFCQLAYLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F8B0", Offset = "0x9B3E8B0", VA = "0x189B3F8B0")]
			internal bool ISHTHESXGLU(IndexValuePair<(int, string)> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class RDSKKWDIWDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public int GKUOXQORORP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public RECYFJRDOZU LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RDSKKWDIWDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x9B3F3C0", Offset = "0x9B3E3C0", VA = "0x189B3F3C0")]
			internal void ISSHBSGRZIM(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class MOFKSSWWWKT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public IReadOnlyList<(Guid, string)> JPCWZGFNSVY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public Dictionary<Guid, int> MXKDDHBJISM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public Func<Guid, int> CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public Func<int, Guid> CUYNSKJNOQS;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public MOFKSSWWWKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9B39270", Offset = "0x9B38270", VA = "0x189B39270")]
			internal IReadOnlyList<string> ILKCSSMZDJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B393A0", Offset = "0x9B383A0", VA = "0x189B393A0")]
			internal IReadOnlyCollection<int> ILPJPZGWMUX(IReadOnlyCollection<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B39070", Offset = "0x9B38070", VA = "0x189B39070")]
			internal int IKPBDRLJRQE(Guid a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x9B391A0", Offset = "0x9B381A0", VA = "0x189B391A0")]
			internal IReadOnlyCollection<Guid> IKZOYEZEKMW(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9B390D0", Offset = "0x9B380D0", VA = "0x189B390D0")]
			internal Guid IKUIAYFHBBN(int a)
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9B440C0", Offset = "0x9B430C0", VA = "0x189B440C0", Slot = "0")]
		UTKZHCFJKWF BSHBBBQMATQ(bool a, Action b, [Optional] Action? falseAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9B43B80", Offset = "0x9B42B80", VA = "0x189B43B80", Slot = "1")]
		UTKZHCFJKWF Add(SRBLGUGSSZJ? provider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UTKZHCFJKWF PMYPYWWLVJZ();

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UTKZHCFJKWF AWVKOZJQUCS(string a, int b, Action c, [Optional] Func<bool>? isVisibleGetter, bool d = true, InventionPermission e = InventionPermission.EditAndSave, string f = "");

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UTKZHCFJKWF? UQYYVNZIASJ(string primaryLabel, MultiValueConfigProperty<string> property, int a = 1000, [Optional] string? b, [Optional] Func<bool>? c, ContentType d = ContentType.Standard, [Optional] string? e);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		UTKZHCFJKWF YLKMBNNJEYG(string a, MultiValueConfigProperty<string> property, int b = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] string? infoText);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		UTKZHCFJKWF CIXARLBSAKG(string a, MultiValueConfigProperty<int> property, [Optional] int? b, [Optional] int? c, [Optional] string? unitLabel, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		UTKZHCFJKWF? LZJFSFWYGUU(string primaryLabel, float a, float b, MultiValueConfigProperty<float> property, int c = 2, [Optional] string? d, [Optional] string? e, [Optional] Func<bool>? f, [Optional] string? g);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		UTKZHCFJKWF? DXAZEWRJJAH(string primaryLabel, MultiValueConfigProperty<float> property, [Optional] Func<bool>? a, [Optional] Func<bool>? b, [Optional] Color? c, [Optional] float? d, [Optional] float? e, bool f = false, [Optional] string? g, [Optional] string? h);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B43C30", Offset = "0x9B42C30", VA = "0x189B43C30", Slot = "9")]
		UTKZHCFJKWF BDDUPIOQTJI(string primaryLabel, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, [Optional] (Color x, Color y, Color z)? bgColors, [Optional] Func<bool>? isVisibleGetter, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		UTKZHCFJKWF? KSVIVWVPVBB(string primaryLabel, Func<bool> isActiveGetter, Action<bool> isActiveSetter, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e, [Optional] Func<bool>? f, [Optional] Func<string>? warningTextGetter, [Optional] Func<string>? warningTitleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "11")]
		UTKZHCFJKWF? GASDDQKHEMN(string primaryLabel, MultiValueConfigProperty<bool> property, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4066770", Offset = "0x4065770", VA = "0x184066770", Slot = "12")]
		UTKZHCFJKWF JHYGTLPUKTK<a>(string a, MultiValueConfigProperty<a> property, IReadOnlyDictionary<a, string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool c = true, bool d = false) where a : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4066AB0", Offset = "0x4065AB0", VA = "0x184066AB0", Slot = "13")]
		UTKZHCFJKWF JHYGTLPUKTK<b>(string a, MultiValueConfigProperty<b> property, IReadOnlyList<b> b, Func<b, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false) where b : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "14")]
		UTKZHCFJKWF JHYGTLPUKTK(string a, MultiValueConfigProperty<object> property, IReadOnlyList<object> b, Func<object, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "15")]
		UTKZHCFJKWF? TTSISBSRSVZ(Action panelAction, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "16")]
		UTKZHCFJKWF PYXPCOIPKLV(string a, ConfigProperty<IReadOnlyList<string>> persistentProperty, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeProperty, [Optional] string? secondaryLabel, [Optional] Func<string, bool>? tagValidator, int b = 1000, [Optional] Func<bool>? isModifiedGetter);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "17")]
		UTKZHCFJKWF? DVZHDLNHMNP(string primaryLabel, Action? a, [Optional] Func<bool>? b, [Optional] Func<bool>? c);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "18")]
		UTKZHCFJKWF ZAHCFQGKLFK(string a, string b, Action c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "19")]
		UTKZHCFJKWF ZOMKXMDHZNU(string a, ConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "20")]
		UTKZHCFJKWF ZOMKXMDHZNU(string a, MultiValueConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		UTKZHCFJKWF BDPGYAHSCCO(string a, ConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		UTKZHCFJKWF BDPGYAHSCCO(string a, MultiValueConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		UTKZHCFJKWF JGFGRYLTDCY(string a, ConfigProperty<Guid> property, Action<RoomRolePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		UTKZHCFJKWF BQZEYEDCONB(string a, MultiValueConfigProperty<Guid> property, Action<RoomKeyPickerData> b, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		UTKZHCFJKWF CCSZXXCJFSQ(string a, Func<IReadOnlyList<string>> b, ConfigProperty<IReadOnlyCollection<int>> property, Action<MultiTogglePickerData> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4065DB0", Offset = "0x4064DB0", VA = "0x184065DB0", Slot = "26")]
		UTKZHCFJKWF CCSZXXCJFSQ<T>(string a, IReadOnlyList<(T, string)> items, ConfigProperty<IReadOnlyCollection<T>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9B437B0", Offset = "0x9B427B0", VA = "0x189B437B0", Slot = "27")]
		UTKZHCFJKWF ALZHZEPGPUO(string a, IReadOnlyList<(int, string)> items, ConfigProperty<int> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9B44110", Offset = "0x9B43110", VA = "0x189B44110", Slot = "28")]
		UTKZHCFJKWF JGFGRYLTDCY(string a, IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "29")]
		UTKZHCFJKWF SIXZDMBQWLR(string a, [Optional] Func<bool>? isVisibleGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public interface SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AEITOFVXVNU(UTKZHCFJKWF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class ANISZWVTHKE : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public ANISZWVTHKE NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9B45EF0", Offset = "0x9B44EF0", VA = "0x189B45EF0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly MultiValueConfigProperty<float> AWTHFJACSJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly System.Numerics.Vector2 MYNKREQBJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private readonly MultiValueConfigProperty<float> THVIIGITFAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly System.Numerics.Vector2 MULJXNYSZBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly GPJHDQTHTKG OVOGZCPUVLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly JOZAIBGQSDW? GQTPPZGNOJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly RTIIRYITTNT RYCXVOAMXZL;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B29EA0", Offset = "0x9B28EA0", VA = "0x189B29EA0")]
		public ANISZWVTHKE(MultiValueConfigProperty<float> a, System.Numerics.Vector2 b, MultiValueConfigProperty<float> c, System.Numerics.Vector2 d, GPJHDQTHTKG sandboxDynamicLightOptions, JOZAIBGQSDW? sandboxColorableConfig, RTIIRYITTNT syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B29D60", Offset = "0x9B28D60", VA = "0x189B29D60", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class SMMBRWQWQBW : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public SMMBRWQWQBW NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9B38450", Offset = "0x9B37450", VA = "0x189B38450")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly GPJHDQTHTKG TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public SMMBRWQWQBW(GPJHDQTHTKG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B40890", Offset = "0x9B3F890", VA = "0x189B40890", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class GPJHDQTHTKG : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private readonly MultiValueConfigProperty<bool> TFDVRUAIOQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private readonly MultiValueConfigProperty<float> JADXMWYTTNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly System.Numerics.Vector2 HWAWECZPTPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private readonly MultiValueConfigProperty<float> JDFJFZTWXOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private readonly System.Numerics.Vector2 GBJLZTIPJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private readonly MultiValueConfigProperty<float> IGLLVYWVCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private readonly System.Numerics.Vector2 PVQBZXGZLDD;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B345E0", Offset = "0x9B335E0", VA = "0x189B345E0")]
		public GPJHDQTHTKG(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<float> d, System.Numerics.Vector2 e, MultiValueConfigProperty<float> f, System.Numerics.Vector2 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B34230", Offset = "0x9B33230", VA = "0x189B34230", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B345D0", Offset = "0x9B335D0", VA = "0x189B345D0")]
		[CompilerGenerated]
		private bool HPHCPPXWTNR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B345B0", Offset = "0x9B335B0", VA = "0x189B345B0")]
		[CompilerGenerated]
		private bool HPBVSJDZKCI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class ZRHPFZRZOEV : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public ZRHPFZRZOEV NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x9B30430", Offset = "0x9B2F430", VA = "0x189B30430")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private readonly GPJHDQTHTKG DLUHUDLXWFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly JOZAIBGQSDW? MQKCLMFWLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private readonly RTIIRYITTNT YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xDDB9F0", Offset = "0xDDA9F0", VA = "0x180DDB9F0")]
		public ZRHPFZRZOEV(GPJHDQTHTKG a, JOZAIBGQSDW? colorableOptions, RTIIRYITTNT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B4A5C0", Offset = "0x9B495C0", VA = "0x189B4A5C0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class BQPSOVISFWJ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public BQPSOVISFWJ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x9B38510", Offset = "0x9B37510", VA = "0x189B38510")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private readonly OVLMHKQRSBH TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public BQPSOVISFWJ(OVLMHKQRSBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CAD0", Offset = "0x9B2BAD0", VA = "0x189B2CAD0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class OVLMHKQRSBH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private readonly MultiValueConfigProperty<float> AWTHFJACSJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private readonly System.Numerics.Vector2 MYNKREQBJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private readonly GPJHDQTHTKG DLUHUDLXWFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private readonly JOZAIBGQSDW? MQKCLMFWLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private readonly RTIIRYITTNT? YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B3BD00", Offset = "0x9B3AD00", VA = "0x189B3BD00")]
		public OVLMHKQRSBH(MultiValueConfigProperty<float> angle, System.Numerics.Vector2 a, GPJHDQTHTKG dynamicLightOptions, JOZAIBGQSDW? b, RTIIRYITTNT? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9B3BBD0", Offset = "0x9B3ABD0", VA = "0x189B3BBD0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class FODDCITPEXM : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public FODDCITPEXM NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x9B34B60", Offset = "0x9B33B60", VA = "0x189B34B60")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private readonly OVLMHKQRSBH DLUHUDLXWFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly UAWVYEJNLDZ UAAHNFHJXME;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		public FODDCITPEXM(OVLMHKQRSBH a, UAWVYEJNLDZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9B31EC0", Offset = "0x9B30EC0", VA = "0x189B31EC0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class EFSIRMOBDGL : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public EFSIRMOBDGL NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9B349C0", Offset = "0x9B339C0", VA = "0x189B349C0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private MultiValueConfigProperty<float> STKRKIYXRBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private Dictionary<float, string> XYEDUVDFIKO;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9B31420", Offset = "0x9B30420", VA = "0x189B31420")]
		public EFSIRMOBDGL(MultiValueConfigProperty<float> a, Dictionary<float, string> labelMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9B312E0", Offset = "0x9B302E0", VA = "0x189B312E0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class YXTUINPZARN : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public sealed class ECYLUROCJQR
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public string PAVMQALYVSV
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public bool[] OLSOQNVPXOD
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int RMPHEUSAXPQ
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float GIYVGXISRIR
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xD4BA50", Offset = "0xD4AA50", VA = "0x180D4BA50")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0xD4B840", Offset = "0xD4A840", VA = "0x180D4B840")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int OSRJHZIEHJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0xCFBA60", Offset = "0xCFAA60", VA = "0x180CFBA60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public ECYLUROCJQR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public sealed class TLSFRKAJROU
		{
			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public string PAVMQALYVSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public ConfigProperty<int> OCTDXXQMYUJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10")]
				[CompilerGenerated]
				get
				{
					return default(ConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x4EE37E0", Offset = "0x4EE27E0", VA = "0x184EE37E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public MultiValueConfigProperty<int> TOKRGEUQPKY
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2E18190", Offset = "0x2E17190", VA = "0x182E18190")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x9B41860", Offset = "0x9B40860", VA = "0x189B41860")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public MultiValueConfigProperty<float> CDENTUISUSA
			{
				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2E18900", Offset = "0x2E17900", VA = "0x182E18900")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x9B41840", Offset = "0x9B40840", VA = "0x189B41840")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public MultiValueConfigProperty<float> YTEVYPFLYGS
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x6FA79A0", Offset = "0x6FA69A0", VA = "0x186FA79A0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x6FA7A90", Offset = "0x6FA6A90", VA = "0x186FA7A90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TLSFRKAJROU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public YXTUINPZARN NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int CETJANBOVVP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9B47F00", Offset = "0x9B46F00", VA = "0x189B47F00")]
			internal void ENBVXVPVEPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class WJJZIHHDPRB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			public int JEHIAJMVLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public WJESLANGGFS LWPGXDDEGGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public Func<ECYLUROCJQR, bool> CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public Func<int, int> CUYNSKJNOQS;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJJZIHHDPRB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9B610B0", Offset = "0x9B600B0", VA = "0x189B610B0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9B61A30", Offset = "0x9B60A30", VA = "0x189B61A30")]
			internal bool ENHCVCJSOAU(ECYLUROCJQR a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9B61A70", Offset = "0x9B60A70", VA = "0x189B61A70")]
			internal int ENWXMWRKQIV(int a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class WJPGFOBAZCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public int CIEWFYBWAGM;

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJPGFOBAZCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9B61C20", Offset = "0x9B60C20", VA = "0x189B61C20")]
			internal bool EOCEKDLHZUE(ECYLUROCJQR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> GHUJRZHAYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private readonly IReadOnlyList<TLSFRKAJROU> IJUNNBXDOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private readonly IReadOnlyList<ECYLUROCJQR> TVCAWUGKMMK;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x88C8060", Offset = "0x88C7060", VA = "0x1888C8060")]
		public YXTUINPZARN(int a, Action<UTKZHCFJKWF.ColorPickerData> b, IReadOnlyList<TLSFRKAJROU> c, IReadOnlyList<ECYLUROCJQR> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9B49CD0", Offset = "0x9B48CD0", VA = "0x189B49CD0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class ZFCCCJXNWRE : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class LBDRYVFOUOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public ZFCCCJXNWRE NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LBDRYVFOUOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x9B56520", Offset = "0x9B55520", VA = "0x189B56520")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x9B56CE0", Offset = "0x9B55CE0", VA = "0x189B56CE0")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private readonly ConfigProperty<int> LIIEPYIPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> GHUJRZHAYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private readonly MultiValueConfigProperty<float> JADXMWYTTNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private readonly MultiValueConfigProperty<float> CTJMRMPYMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private readonly MultiValueConfigProperty<float> HXWCFKIGSJX;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9B622E0", Offset = "0x9B612E0", VA = "0x189B622E0")]
		public ZFCCCJXNWRE(int a, ConfigProperty<int> b, Action<UTKZHCFJKWF.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9B621A0", Offset = "0x9B611A0", VA = "0x189B621A0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class NKTQZUSWGXO : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class UUTSZHQDVWE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public NKTQZUSWGXO NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Action CVJBMXXIHNK;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UUTSZHQDVWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9B5E700", Offset = "0x9B5D700", VA = "0x189B5E700")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x9B5F3A0", Offset = "0x9B5E3A0", VA = "0x189B5F3A0")]
			internal void EOHLHKFFJFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly System.Numerics.Vector2 CTRIHJABQYS;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly System.Numerics.Vector2 BUTXHWGQBCW;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static System.Numerics.Vector2 MAKIYAXQCVX;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static System.Numerics.Vector2 ZXSXMKRGFLJ;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static System.Numerics.Vector2 LDZPTOEPLJQ;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static System.Numerics.Vector2 BGEKOLLYROS;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static System.Numerics.Vector2 TPJPIEOASMU;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static System.Numerics.Vector2 DWRVJKNPKHS;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static System.Numerics.Vector2 TCGKJEUMDTI;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static System.Numerics.Vector2 ZOCXAKEZMVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private readonly ConfigProperty<int> LIIEPYIPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> GHUJRZHAYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private readonly MultiValueConfigProperty<float> UVEMOQEVORK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private readonly MultiValueConfigProperty<float> PMBDRRXRQMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private readonly MultiValueConfigProperty<float> QQRBRNJJHTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private readonly MultiValueConfigProperty<float> IQALIJMMMHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private readonly MultiValueConfigProperty<float> ZLYZRXXIMKY;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9B59750", Offset = "0x9B58750", VA = "0x189B59750")]
		public NKTQZUSWGXO(int a, ConfigProperty<int> b, Action<UTKZHCFJKWF.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9B59290", Offset = "0x9B58290", VA = "0x189B59290", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9B593D0", Offset = "0x9B583D0", VA = "0x189B593D0")]
		private static float ICQWDVOGHXG(float a, System.Numerics.Vector2 b, System.Numerics.Vector2 c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public sealed class EVXDUNPZFPZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public EVXDUNPZFPZ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C4A0", Offset = "0x9B4B4A0", VA = "0x189B4C4A0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C860", Offset = "0x9B4B860", VA = "0x189B4C860")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private readonly ConfigProperty<int> LIIEPYIPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> GHUJRZHAYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private readonly MultiValueConfigProperty<float> JNSPSIIEIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private readonly MultiValueConfigProperty<float> QPFHVXZAZPZ;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9B506D0", Offset = "0x9B4F6D0", VA = "0x189B506D0")]
		public EVXDUNPZFPZ(int a, ConfigProperty<int> b, Action<UTKZHCFJKWF.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9B50590", Offset = "0x9B4F590", VA = "0x189B50590", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public sealed class AABYFPLLOXI : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public AABYFPLLOXI NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x9B600D0", Offset = "0x9B5F0D0", VA = "0x189B600D0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x9B60AE0", Offset = "0x9B5FAE0", VA = "0x189B60AE0")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private readonly MultiValueConfigProperty<int> LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private readonly MultiValueConfigProperty<float> HUBIBKWMZZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private readonly MultiValueConfigProperty<float> ISDXMXOEZIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private readonly MultiValueConfigProperty<bool> QHGPRWLUXJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private readonly ConfigProperty<Guid> HARTLDGVGSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly Action<UTKZHCFJKWF.RoomRolePickerData> BWGXVOFGLYI;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B030", Offset = "0x9B4A030", VA = "0x189B4B030")]
		public AABYFPLLOXI(int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, ConfigProperty<Guid> f, Action<UTKZHCFJKWF.RoomRolePickerData> onExclusiveToRoleClick)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9B4AEF0", Offset = "0x9B49EF0", VA = "0x189B4AEF0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class HAQOAOTRDGJ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public HAQOAOTRDGJ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x9B509D0", Offset = "0x9B4F9D0", VA = "0x189B509D0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x9B518F0", Offset = "0x9B508F0", VA = "0x189B518F0")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private readonly ConfigProperty<int> MVHYBBSYNXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private readonly ConfigProperty<int> CTZTRFZBGTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private readonly ConfigProperty<int> QMQHRBDJYQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private readonly ConfigProperty<int> ISWBMKTYWGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private readonly ConfigProperty<int> FRJDQRBTUVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> GHUJRZHAYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private readonly MultiValueConfigProperty<float> YIMFYTIZRXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private readonly MultiValueConfigProperty<float> YHYSBATUEVC;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9B54C00", Offset = "0x9B53C00", VA = "0x189B54C00")]
		public HAQOAOTRDGJ(int a, ConfigProperty<int> b, ConfigProperty<int> c, ConfigProperty<int> d, ConfigProperty<int> e, ConfigProperty<int> f, Action<UTKZHCFJKWF.ColorPickerData> onColorClick, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9B54AC0", Offset = "0x9B53AC0", VA = "0x189B54AC0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class HGAXSYUAZDH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class DHZJUJKYCLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public HGAXSYUAZDH NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public DHZJUJKYCLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9B4D830", Offset = "0x9B4C830", VA = "0x189B4D830")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E800", Offset = "0x9B4D800", VA = "0x189B4E800")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private readonly ConfigProperty<int> LIIEPYIPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> GHUJRZHAYEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private readonly MultiValueConfigProperty<float> URNJLKVGIRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private readonly MultiValueConfigProperty<float> JANKIBXWDZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private readonly MultiValueConfigProperty<float> MZXMVBHJOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private readonly MultiValueConfigProperty<float> MUHDMDRFEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private readonly MultiValueConfigProperty<float> PKMFHSGOHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private readonly MultiValueConfigProperty<float> OLOAUKDBUYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private readonly MultiValueConfigProperty<bool> YEXIIFTGXBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly MultiValueConfigProperty<bool> DOJWANDMALY;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9B54E90", Offset = "0x9B53E90", VA = "0x189B54E90")]
		public HGAXSYUAZDH(int a, ConfigProperty<int> b, Action<UTKZHCFJKWF.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9B54D50", Offset = "0x9B53D50", VA = "0x189B54D50", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public readonly struct MultiValueConfigProperty<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class UDKKDBKIJRZ<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public IEnumerable<b> ZUNWJNBBTTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public Func<b, T> MWALDAOJTUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public Action<b, T> SXVPAMYRHRT;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UDKKDBKIJRZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x7F01760", Offset = "0x7F00760", VA = "0x187F01760")]
			internal Option<T> LTUMUKHYGRW()
			{
				return default(Option<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7F021B0", Offset = "0x7F011B0", VA = "0x187F021B0")]
			internal void LTZTRRBVQDF(T a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class FESJLOEPJLC<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public T CIEWFYBWAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public UDKKDBKIJRZ<b> LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public FESJLOEPJLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x62C34B0", Offset = "0x62C24B0", VA = "0x1862C34B0")]
			internal void LUFAOXVSZOO(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class GZTFKPJKAMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public MultiValueConfigProperty<T> KFDRVMSKNUT;

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GZTFKPJKAMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x64798E0", Offset = "0x64788E0", VA = "0x1864798E0")]
			internal Option<object> XJGRHBQKJXD()
			{
				return default(Option<object>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x6479310", Offset = "0x6478310", VA = "0x186479310")]
			internal void XJBKJUWNALU(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class JIOKIFETTRK<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public Func<b, T> MWALDAOJTUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public T YBUUYNCCYNK;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public JIOKIFETTRK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x66F7730", Offset = "0x66F6730", VA = "0x1866F7730")]
			internal bool QYYPIDRVHQF(b a)
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
		[Cpp2IlInjected.Address(RVA = "0x3A05630", Offset = "0x3A04630", VA = "0x183A05630")]
		public static MultiValueConfigProperty<T> Create<U>(IEnumerable<U> objects, Func<U, T> getter, Action<U, T> setter, Func<bool>? isModified) where U : notnull
		{
			return default(MultiValueConfigProperty<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7283F70", Offset = "0x7282F70", VA = "0x187283F70")]
		public static implicit operator MultiValueConfigProperty<object>(MultiValueConfigProperty<T> prop)
		{
			return default(MultiValueConfigProperty<object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3A06370", Offset = "0x3A05370", VA = "0x183A06370")]
		private static Option<T> RAFMUXGVDJD<U>(IEnumerable<U> a, Func<U, T> b) where U : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		internal MultiValueConfigProperty(Func<Option<T>> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class HQBPRVBSBGR
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[CompilerGenerated]
		private sealed class UDPRAIEFTDI<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public IEnumerable<a> ZUNWJNBBTTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public Func<a, bool> GVWYAJILGZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public Func<a, bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UDPRAIEFTDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7F03ED0", Offset = "0x7F02ED0", VA = "0x187F03ED0")]
			internal bool GXUVMQMECSQ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x7F03F80", Offset = "0x7F02F80", VA = "0x187F03F80")]
			internal bool GYACJXGBMDZ(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class SJBJABCBNQR<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public MultiValueConfigProperty<a> KFDRVMSKNUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public Func<a, b> EZKNHGFIRIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public Func<b, a> JJLVUFXULGO;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SJBJABCBNQR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x7ABCF70", Offset = "0x7ABBF70", VA = "0x187ABCF70")]
			internal Option<b> RYYJOXEWNUN()
			{
				return default(Option<b>);
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC700", Offset = "0x7ABB700", VA = "0x187ABC700")]
			internal void ABBKYQFXEVY(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class TBSNIXJJGRH<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public ConfigProperty<a> KFDRVMSKNUT;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TBSNIXJJGRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7C47630", Offset = "0x7C46630", VA = "0x187C47630")]
			internal Option<a> DZEBPHZBPFW()
			{
				return default(Option<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x12C4470", Offset = "0x12C3470", VA = "0x1812C4470")]
			internal void RDGEQNGSRTR(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6610", Offset = "0x3AF5610", VA = "0x183AF6610")]
		public static MultiValueConfigProperty<U> POEPTYVLEUO<U, T>(this IEnumerable<T> a, Func<T, U> b, Action<T, U> c, [Optional] Func<T, bool>? isModified) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6F40", Offset = "0x3AF5F40", VA = "0x183AF6F40")]
		public static MultiValueConfigProperty<U> To<U, T>(this MultiValueConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6210", Offset = "0x3AF5210", VA = "0x183AF6210")]
		public static MultiValueConfigProperty<a?> POEPTYVLEUO<a>(this ConfigProperty<a> prop)
		{
			return default(MultiValueConfigProperty<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class LADPATNTHJU : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public LADPATNTHJU NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9B5B370", Offset = "0x9B5A370", VA = "0x189B5B370")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly IReadOnlyList<NavMeshGenerationMode> ELZSJWLAGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private readonly MultiValueConfigProperty<NavMeshGenerationMode> CKZLTWQGVXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9B563A0", Offset = "0x9B553A0", VA = "0x189B563A0")]
		private static string MIANCGOEPYX(NavMeshGenerationMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9B564D0", Offset = "0x9B554D0", VA = "0x189B564D0")]
		public LADPATNTHJU(MultiValueConfigProperty<NavMeshGenerationMode> a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9B56250", Offset = "0x9B55250", VA = "0x189B56250", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class ECALVSAEOHD : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public ECALVSAEOHD NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9B570F0", Offset = "0x9B560F0", VA = "0x189B570F0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private readonly LHQKDVPNESN TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public ECALVSAEOHD(LHQKDVPNESN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F9D0", Offset = "0x9B4E9D0", VA = "0x189B4F9D0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class LHQKDVPNESN : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private readonly Action JZNEEHAQHWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private readonly Func<bool> ANKBXRDVZXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private readonly Action TRNHVKCHNQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private readonly Action QDVSEFXRYGS;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x112D620", Offset = "0x112C620", VA = "0x18112D620")]
		public LHQKDVPNESN(Action a, Func<bool> b, Action c, Action d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9B56E90", Offset = "0x9B55E90", VA = "0x189B56E90", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9B570C0", Offset = "0x9B560C0", VA = "0x189B570C0")]
		[CompilerGenerated]
		private bool MINUJIFWTVC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9B570C0", Offset = "0x9B560C0", VA = "0x189B570C0")]
		[CompilerGenerated]
		private bool MITBGOZUDGL()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class AKBSUBKPPOY : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public AKBSUBKPPOY NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9B5BBF0", Offset = "0x9B5ABF0", VA = "0x189B5BBF0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B5C150", Offset = "0x9B5B150", VA = "0x189B5C150")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private readonly IReadOnlyDictionary<int, string> XXVWDAAHFVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private readonly MultiValueConfigProperty<int> TMVNKICZJYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private readonly MultiValueConfigProperty<bool> FLDFPLRETZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private readonly MultiValueConfigProperty<bool> UGCBNJOBGSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private readonly MultiValueConfigProperty<float> CXQDNDDKQAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private readonly MultiValueConfigProperty<float> KRKVQPJAEAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly JOZAIBGQSDW? GQTPPZGNOJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private readonly RTIIRYITTNT? RYCXVOAMXZL;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B270", Offset = "0x9B4A270", VA = "0x189B4B270")]
		public AKBSUBKPPOY(IReadOnlyDictionary<int, string>? effectsDict, MultiValueConfigProperty<int> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, JOZAIBGQSDW? sandboxColorableConfig, RTIIRYITTNT? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B130", Offset = "0x9B4A130", VA = "0x189B4B130", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class GSWTGFSUULQ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public GSWTGFSUULQ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B5B580", Offset = "0x9B5A580", VA = "0x189B5B580")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class QBPMGPXEJEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public string YSWNFPRSVUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ConfigProperty<string> GAODCGZQMGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public QBUTDWRBSPN LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBPMGPXEJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9B5AD70", Offset = "0x9B59D70", VA = "0x189B5AD70")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x9B5AF00", Offset = "0x9B59F00", VA = "0x189B5AF00")]
			internal void EMWPAOVXVEC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly bool WEMQPXRWUXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly IReadOnlyList<ConfigProperty<string>> MWZMRYQHGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly int KZTXKFELRBR;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B54530", Offset = "0x9B53530", VA = "0x189B54530")]
		public GSWTGFSUULQ(int a, bool b, IReadOnlyList<ConfigProperty<string>> messages, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B543E0", Offset = "0x9B533E0", VA = "0x189B543E0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class WKVWIYYSASK : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public WKVWIYYSASK NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B54A60", Offset = "0x9B53A60", VA = "0x189B54A60")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly YIDBCODKDGY TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10958A0", Offset = "0x10948A0", VA = "0x1810958A0")]
		public WKVWIYYSASK(int a, YIDBCODKDGY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B61C40", Offset = "0x9B60C40", VA = "0x189B61C40", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class YIDBCODKDGY : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public YIDBCODKDGY NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x9B5B900", Offset = "0x9B5A900", VA = "0x189B5B900")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B5BA80", Offset = "0x9B5AA80", VA = "0x189B5BA80")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private readonly bool WEMQPXRWUXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private readonly string VAAONOQBYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private readonly ConfigProperty<string> GAODCGZQMGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly int HJWQDZQZZRO;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B62120", Offset = "0x9B61120", VA = "0x189B62120")]
		public YIDBCODKDGY(bool a, string b, ConfigProperty<string> message, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B61FD0", Offset = "0x9B60FD0", VA = "0x189B61FD0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class DJIXADXUKSK : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public DJIXADXUKSK NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public Action CUNZXWVSVUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public Func<bool> CVDUPRDKYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public Action<bool> CUYNSKJNOQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public Func<bool> IBPNQVJUAMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Action IBUUOCDRJYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public Action CVOIKERFQYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public Action<bool> ICABLIXOTJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public Action ICFIIPRMCUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public Action CVJBMXXIHNK;

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x9B54260", Offset = "0x9B53260", VA = "0x189B54260")]
			internal bool ZXBDJKSEKCQ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B530D0", Offset = "0x9B520D0", VA = "0x189B530D0")]
			internal bool WSEXNJRZSHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x9B509A0", Offset = "0x9B4F9A0", VA = "0x189B509A0")]
			internal void EATBJTJIWSU(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x9B539F0", Offset = "0x9B529F0", VA = "0x189B539F0")]
			internal bool RBVZWMZDIKY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9B524C0", Offset = "0x9B514C0", VA = "0x189B524C0")]
			internal void ENHCVCJSOAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9B52B70", Offset = "0x9B51B70", VA = "0x189B52B70")]
			internal void ENMJSJDPXMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x9B530D0", Offset = "0x9B520D0", VA = "0x189B530D0")]
			internal bool ENRQPPXNGXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x9B53110", Offset = "0x9B52110", VA = "0x189B53110")]
			internal void ENWXMWRKQIV(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9B531D0", Offset = "0x9B521D0", VA = "0x189B531D0")]
			internal void EOCEKDLHZUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x9B54220", Offset = "0x9B53220", VA = "0x189B54220")]
			internal bool VEZQBJYQMLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9B54030", Offset = "0x9B53030", VA = "0x189B54030")]
			internal void VEUJEDETDAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B536B0", Offset = "0x9B526B0", VA = "0x189B536B0")]
			internal void EOHLHKFFJFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9B53F60", Offset = "0x9B52F60", VA = "0x189B53F60")]
			internal void VEPCGWKVTOT(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x9B53AC0", Offset = "0x9B52AC0", VA = "0x189B53AC0")]
			internal void VEJVJPQYKDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class LBDRYVFOUOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public DJIXADXUKSK NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public PhysicsModelEnumFlags MSRDGYTQDTW;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LBDRYVFOUOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9B56E10", Offset = "0x9B55E10", VA = "0x189B56E10")]
			internal bool IBYAGDNBJXA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9B56E50", Offset = "0x9B55E50", VA = "0x189B56E50")]
			internal void ICDHDKGYTIJ(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly IReadOnlyList<CollisionMode> IUNCCCJBYUS;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly IReadOnlyList<CollisionLayerEnum> VVFHCQRNKUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private readonly bool TVRQWTQQJWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private readonly ConfigProperty<CollisionMode> DFBZRNEFOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly ConfigProperty<CollisionLayerEnum> SCTDOSBTEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly ConfigProperty<float> MWAKBWZWVJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly Func<PhysicsModelEnumFlags, bool> PZINDNHXKZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly Action<PhysicsModelEnumFlags, bool> OZOXWBFIMPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly ConfigProperty<float>? TLQMKLXKCXM;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EA70", Offset = "0x9B4DA70", VA = "0x189B4EA70")]
		private static string AZXLZWVAKJT(CollisionMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9B4ECA0", Offset = "0x9B4DCA0", VA = "0x189B4ECA0")]
		private static string TMMYPNHEBCX(CollisionLayerEnum a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EEA0", Offset = "0x9B4DEA0", VA = "0x189B4EEA0")]
		public DJIXADXUKSK(bool a, ConfigProperty<CollisionMode> b, ConfigProperty<CollisionLayerEnum> c, ConfigProperty<float> d, Func<PhysicsModelEnumFlags, bool> hasFlag, Action<PhysicsModelEnumFlags, bool> setFlag, [Optional] ConfigProperty<float>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E930", Offset = "0x9B4D930", VA = "0x189B4E930", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EB00", Offset = "0x9B4DB00", VA = "0x189B4EB00")]
		private MultiValueConfigProperty<bool> OHWOAKLIDWY(PhysicsModelEnumFlags a)
		{
			return default(MultiValueConfigProperty<bool>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class XUZMTNRPPPF : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public XUZMTNRPPPF NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B4BC90", Offset = "0x9B4AC90", VA = "0x189B4BC90")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C7F0", Offset = "0x9B4B7F0", VA = "0x189B4C7F0")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private static readonly IReadOnlyList<GrabbableMode> EUGLFQEUGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private readonly MultiValueConfigProperty<bool> FKNWFGPAFTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private readonly MultiValueConfigProperty<GrabbableMode> VRGCNUOURVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private readonly MultiValueConfigProperty<bool> TNNYQJFJQED;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B61ED0", Offset = "0x9B60ED0", VA = "0x189B61ED0")]
		private static string BJBTKCFWNHT(GrabbableMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B448B0", Offset = "0x9B438B0", VA = "0x189B448B0")]
		public XUZMTNRPPPF(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<GrabbableMode> b, MultiValueConfigProperty<bool> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B61D90", Offset = "0x9B60D90", VA = "0x189B61D90", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class GBVQKGAKEYN : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public GBVQKGAKEYN NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Func<bool> CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x9B60670", Offset = "0x9B5F670", VA = "0x189B60670")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9B60C90", Offset = "0x9B5FC90", VA = "0x189B60C90")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x9B61070", Offset = "0x9B60070", VA = "0x189B61070")]
			internal bool ENBVXVPVEPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x9B61010", Offset = "0x9B60010", VA = "0x189B61010")]
			internal void EMWPAOVXVEC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private readonly Option<bool> LHVNLEKGVMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private readonly MultiValueConfigProperty<string> GAXOXHPQSZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Func<int> SXSWQNVIFZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private readonly MultiValueConfigProperty<bool> VQQJOTFNGRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly MultiValueConfigProperty<bool> DIVHMUBPJCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly DWTCAWLZWZG? WWSOGYWQBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly GUNRAZGYEGZ? MFGDOYDGBQB;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x9B508C0", Offset = "0x9B4F8C0", VA = "0x189B508C0")]
		public GBVQKGAKEYN(Option<bool> a, MultiValueConfigProperty<string> name, Func<int> currentSelectionCount, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, DWTCAWLZWZG? transformConfig, GUNRAZGYEGZ? tagsConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B50780", Offset = "0x9B4F780", VA = "0x189B50780", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class BAHCESGWDRT : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class KXPJFHIHHEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public BAHCESGWDRT NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Func<int> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KXPJFHIHHEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B55930", Offset = "0x9B54930", VA = "0x189B55930")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x9B560E0", Offset = "0x9B550E0", VA = "0x189B560E0")]
			internal int EMRIDICALST()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private readonly MultiValueConfigProperty<int> LIIEPYIPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> IEEGYYUKADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private readonly MultiValueConfigProperty<int> TTNXTZFTOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private readonly Action<UTKZHCFJKWF.MaterialPickerData> RVGVBKWAVQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private readonly MultiValueConfigProperty<float> TFIEARXXFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private readonly MultiValueConfigProperty<float> QCAKNMNWQGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private readonly MultiValueConfigProperty<float> QBVDQFTZGVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private readonly MultiValueConfigProperty<float> QCKYIABRJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly MultiValueConfigProperty<bool> TEWZPCEXCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private readonly Func<bool> UWDWSAALQJO;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B890", Offset = "0x9B4A890", VA = "0x189B4B890")]
		public BAHCESGWDRT(MultiValueConfigProperty<int> a, Action<UTKZHCFJKWF.ColorPickerData> colorButtonOnClick, MultiValueConfigProperty<int> b, Action<UTKZHCFJKWF.MaterialPickerData> materialButtonOnClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, Func<bool> isSinglePrimitiveShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B750", Offset = "0x9B4A750", VA = "0x189B4B750", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class TEHRKYYMBVF : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public TEHRKYYMBVF NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9B5B080", Offset = "0x9B5A080", VA = "0x189B5B080")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private readonly Dictionary<int, string> WYYPMSWSHQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private readonly MultiValueConfigProperty<bool> LKHIJLIEDDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private readonly MultiValueConfigProperty<bool> QYTKOFZVPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private readonly MultiValueConfigProperty<int> EYBQINODEIW;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CC80", Offset = "0x9B5BC80", VA = "0x189B5CC80")]
		public TEHRKYYMBVF(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<int> c, Dictionary<int, string> tubeRingOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CB40", Offset = "0x9B5BB40", VA = "0x189B5CB40", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class BCTACETJZRM : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public BCTACETJZRM NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B54A00", Offset = "0x9B53A00", VA = "0x189B54A00")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private readonly JOZAIBGQSDW TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10958A0", Offset = "0x10948A0", VA = "0x1810958A0")]
		public BCTACETJZRM(int a, JOZAIBGQSDW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BA00", Offset = "0x9B4AA00", VA = "0x189B4BA00", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class JOZAIBGQSDW : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class PUKJSNNOUVN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public JOZAIBGQSDW NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PUKJSNNOUVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A2C0", Offset = "0x9B592C0", VA = "0x189B5A2C0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B5AC00", Offset = "0x9B59C00", VA = "0x189B5AC00")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private readonly RecolorModes RWIAJXWOBQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly ConfigProperty<int> NXPQKGGWOZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly Action<UTKZHCFJKWF.ColorPickerData> IEEGYYUKADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly ConfigProperty<int> RBDQQPYIHLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly Action<UTKZHCFJKWF.MaterialPickerData> RVGVBKWAVQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly ConfigProperty<float> MIZJDJCXTEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private readonly bool PYEQQUIDMKZ;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B55380", Offset = "0x9B54380", VA = "0x189B55380")]
		public JOZAIBGQSDW(RecolorModes a, ConfigProperty<int> b, Action<UTKZHCFJKWF.ColorPickerData> colorButtonOnClick, ConfigProperty<int> c, Action<UTKZHCFJKWF.MaterialPickerData> materialButtonOnClick, ConfigProperty<float> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B55190", Offset = "0x9B54190", VA = "0x189B55190", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class VWIVSETYCZK : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public VWIVSETYCZK NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C990", Offset = "0x9B4B990", VA = "0x189B4C990")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private readonly RTIIRYITTNT? SNFDZQMLQBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private readonly YIDBCODKDGY? QRORJOMDCHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private readonly JOZAIBGQSDW? ACGLPGKTKNS;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF1EB10", Offset = "0xF1DB10", VA = "0x180F1EB10")]
		public VWIVSETYCZK(YIDBCODKDGY? a, JOZAIBGQSDW? b, RTIIRYITTNT? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B5F4D0", Offset = "0x9B5E4D0", VA = "0x189B5F4D0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class IQJNXHQFHSZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public IQJNXHQFHSZ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9B54790", Offset = "0x9B53790", VA = "0x189B54790")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private readonly int LKWENNREEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private readonly RTIIRYITTNT TIYETEBTEMQ;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10958A0", Offset = "0x10948A0", VA = "0x1810958A0")]
		public IQJNXHQFHSZ(int a, RTIIRYITTNT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9B55040", Offset = "0x9B54040", VA = "0x189B55040", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class RTIIRYITTNT : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly string VAAONOQBYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private readonly MultiValueConfigProperty<bool> AULYSNDTOMY;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B43260", Offset = "0x9B42260", VA = "0x189B43260")]
		public RTIIRYITTNT(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CA20", Offset = "0x9B5BA20", VA = "0x189B5CA20", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class GUNRAZGYEGZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public GUNRAZGYEGZ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Func<string, bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9B5FEB0", Offset = "0x9B5EEB0", VA = "0x189B5FEB0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9B60A60", Offset = "0x9B5FA60", VA = "0x189B60A60")]
			internal bool EMRIDICALST(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private readonly ConfigProperty<IReadOnlyList<string>> VHYVRRNQFQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private readonly ConfigProperty<IReadOnlyList<string>>? RNYOTLEUVTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private readonly Func<bool> GCHHHTYYGAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly Func<bool>? QCFWJFDADLE;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
		private static bool WIZSIBAALJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B546A0", Offset = "0x9B536A0", VA = "0x189B546A0")]
		public GUNRAZGYEGZ(int a, ConfigProperty<IReadOnlyList<string>> persistentTags, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeTags, [Optional] Func<bool>? b, [Optional] Func<bool>? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B54590", Offset = "0x9B53590", VA = "0x189B54590", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class MGQZNHDQSBT : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class DRNFTNRRHZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public MGQZNHDQSBT NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public DRNFTNRRHZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x9B4EF80", Offset = "0x9B4DF80", VA = "0x189B4EF80")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F940", Offset = "0x9B4E940", VA = "0x189B4F940")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F970", Offset = "0x9B4E970", VA = "0x189B4F970")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F9A0", Offset = "0x9B4E9A0", VA = "0x189B4F9A0")]
			internal void ENBVXVPVEPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class LXFDTAXQBQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public MGQZNHDQSBT NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LXFDTAXQBQL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9B57920", Offset = "0x9B56920", VA = "0x189B57920")]
			internal void IZSCWUTGJBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x9B573F0", Offset = "0x9B563F0", VA = "0x189B573F0")]
			internal void IZMVZNZIZQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9B57E80", Offset = "0x9B56E80", VA = "0x189B57E80")]
			internal bool JACQRIHBBYN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly IReadOnlyList<GunHandleData.SVFNYUIHGCD.GunHandleScreensPose> XWUYKZMMFXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private readonly MultiValueConfigProperty<GunHandleData.SVFNYUIHGCD.GunHandleScreensPose> YRWUVDCJXEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly MultiValueConfigProperty<int> CEVGLOEPEVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly MultiValueConfigProperty<bool> AWGYXBVWNNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly MultiValueConfigProperty<float> GHOGZVDAMTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly MultiValueConfigProperty<bool> GNQKLZZMEVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly MultiValueConfigProperty<float> ZIGYINQEKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly MultiValueConfigProperty<bool> MAUAJPWUCSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly MultiValueConfigProperty<bool> OTPVAKUETDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly MultiValueConfigProperty<float> IPNHTRJACDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private readonly MultiValueConfigProperty<bool> ZZHVASLZISG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private readonly MultiValueConfigProperty<bool> GGLPOCTKGDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private readonly MultiValueConfigProperty<bool> YINFXAJXIIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly MultiValueConfigProperty<bool> VUJDNAMISKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly MultiValueConfigProperty<bool> CPHUWJVSYCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MultiValueConfigProperty<float> XTJLVTLQNTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly MultiValueConfigProperty<float> GXQIGPOMDZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private readonly MultiValueConfigProperty<float> JUZOLQEDAXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly MultiValueConfigProperty<float> PAJRMSQRMWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly MultiValueConfigProperty<float> CTGRVTKBTXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private readonly MultiValueConfigProperty<float> SUFTUWGOQSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly MultiValueConfigProperty<bool> XKTRGSBXKPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly MultiValueConfigProperty<bool> UVFSWYZEOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly MultiValueConfigProperty<bool> SMYGMFQSZLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly MultiValueConfigProperty<string> CPGOPBXPNZF;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B58030", Offset = "0x9B57030", VA = "0x189B58030")]
		private static string CPKLEJGLWLN(GunHandleData.SVFNYUIHGCD.GunHandleScreensPose a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9B58E70", Offset = "0x9B57E70", VA = "0x189B58E70")]
		public MGQZNHDQSBT(MultiValueConfigProperty<GunHandleData.SVFNYUIHGCD.GunHandleScreensPose> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, MultiValueConfigProperty<float> q, MultiValueConfigProperty<float> r, MultiValueConfigProperty<float> s, MultiValueConfigProperty<float> t, MultiValueConfigProperty<bool> u, MultiValueConfigProperty<bool> v, MultiValueConfigProperty<bool> w, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B57EF0", Offset = "0x9B56EF0", VA = "0x189B57EF0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B58A30", Offset = "0x9B57A30", VA = "0x189B58A30")]
		private void SWSIXRVUREV(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9B58580", Offset = "0x9B57580", VA = "0x189B58580")]
		private void PTDEIMDIVJZ(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9B58210", Offset = "0x9B57210", VA = "0x189B58210")]
		private void ONLGBFHGOVH(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9B58130", Offset = "0x9B57130", VA = "0x189B58130")]
		[CompilerGenerated]
		private bool EZMSGEYVVNQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9B581A0", Offset = "0x9B571A0", VA = "0x189B581A0")]
		[CompilerGenerated]
		private bool EZRZDLSTEYZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class JXXEMXHVKKR : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly string IRSLZGQVPQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly MultiValueConfigProperty<string> CPGOPBXPNZF;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9B43260", Offset = "0x9B42260", VA = "0x189B43260")]
		public JXXEMXHVKKR(string a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9B55810", Offset = "0x9B54810", VA = "0x189B55810", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class DCKSBFYCAVH : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public DCKSBFYCAVH NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Func<bool> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x9B5F610", Offset = "0x9B5E610", VA = "0x189B5F610")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x9B60C20", Offset = "0x9B5FC20", VA = "0x189B60C20")]
			internal bool EMRIDICALST()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly IReadOnlyDictionary<SwingHandleData.SVFNYUIHGCD.SwingHandleAnimation, string> OTOHBFJIYAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly MultiValueConfigProperty<SwingHandleData.SVFNYUIHGCD.SwingHandleAnimation> LZWTDLKKANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly MultiValueConfigProperty<bool> VQCYZJDGOHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly MultiValueConfigProperty<bool> KONYIBWXCQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly MultiValueConfigProperty<float> JKOZVEDXHIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly MultiValueConfigProperty<bool> XKTRGSBXKPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly MultiValueConfigProperty<string> CPGOPBXPNZF;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9B363D0", Offset = "0x9B353D0", VA = "0x189B363D0")]
		public DCKSBFYCAVH(MultiValueConfigProperty<SwingHandleData.SVFNYUIHGCD.SwingHandleAnimation> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9B4D470", Offset = "0x9B4C470", VA = "0x189B4D470", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class QYWKOGGOAPR : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public QYWKOGGOAPR NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9B5FC40", Offset = "0x9B5EC40", VA = "0x189B5FC40")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x9B60AB0", Offset = "0x9B5FAB0", VA = "0x189B60AB0")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9B60E60", Offset = "0x9B5FE60", VA = "0x189B60E60")]
			internal void EMWPAOVXVEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.SVFNYUIHGCD.ThrowHandleIdlePose, string> ITEUUBDPWAG;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.SVFNYUIHGCD.ThrowHandleThrowPose, string> RMXFFHIMQXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private readonly MultiValueConfigProperty<ThrowHandleData.SVFNYUIHGCD.ThrowHandleIdlePose> IBXCHQNRIUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private readonly MultiValueConfigProperty<ThrowHandleData.SVFNYUIHGCD.ThrowHandleThrowPose> PPZQZCQELPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private readonly MultiValueConfigProperty<float> WFFJLDMBTHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private readonly MultiValueConfigProperty<float> KNSCAMWKRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private readonly MultiValueConfigProperty<string> CPGOPBXPNZF;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9B319B0", Offset = "0x9B309B0", VA = "0x189B319B0")]
		public QYWKOGGOAPR(MultiValueConfigProperty<ThrowHandleData.SVFNYUIHGCD.ThrowHandleIdlePose> a, MultiValueConfigProperty<ThrowHandleData.SVFNYUIHGCD.ThrowHandleThrowPose> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9B5C200", Offset = "0x9B5B200", VA = "0x189B5C200", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9B5C340", Offset = "0x9B5B340", VA = "0x189B5C340")]
		private void IFDLPKPPFMB(UTKZHCFJKWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9B5C620", Offset = "0x9B5B620", VA = "0x189B5C620")]
		private void VCJMYHAKNGC(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class GOTLSQMZVTJ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public GOTLSQMZVTJ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x9B547F0", Offset = "0x9B537F0", VA = "0x189B547F0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private readonly MultiValueConfigProperty<bool> YGMOZRBFUXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private readonly MultiValueConfigProperty<string> CPGOPBXPNZF;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CD50", Offset = "0x9B2BD50", VA = "0x189B2CD50")]
		public GOTLSQMZVTJ(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9B542A0", Offset = "0x9B532A0", VA = "0x189B542A0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class BMXXADBCIGS : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public BMXXADBCIGS NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9B571B0", Offset = "0x9B561B0", VA = "0x189B571B0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly MultiValueConfigProperty<string> CPGOPBXPNZF;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public BMXXADBCIGS(MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9B4BB50", Offset = "0x9B4AB50", VA = "0x189B4BB50", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class TTDRHBPETXZ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class PEUYNJHNJIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public TTDRHBPETXZ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PEUYNJHNJIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9B59A50", Offset = "0x9B58A50", VA = "0x189B59A50")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private readonly MultiValueConfigProperty<bool> NYYKJMMMVUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private readonly MultiValueConfigProperty<float> IWTWGKZXROS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private readonly System.Numerics.Vector2 CJMDASKDJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private readonly MultiValueConfigProperty<bool> ABIUPBZCZPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private readonly JOZAIBGQSDW? MQKCLMFWLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private readonly RTIIRYITTNT? YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9B5D580", Offset = "0x9B5C580", VA = "0x189B5D580")]
		public TTDRHBPETXZ(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<bool> d, JOZAIBGQSDW? colorableOptions, RTIIRYITTNT? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9B5D440", Offset = "0x9B5C440", VA = "0x189B5D440", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class KXYKIBYQEVQ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public KXYKIBYQEVQ NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9B57150", Offset = "0x9B56150", VA = "0x189B57150")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly GUNRAZGYEGZ ZOSWEVLDWDS;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public KXYKIBYQEVQ(GUNRAZGYEGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9B56110", Offset = "0x9B55110", VA = "0x189B56110", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class CMROJXELJSB : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public CMROJXELJSB NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x9B572A0", Offset = "0x9B562A0", VA = "0x189B572A0")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly MultiValueConfigProperty<bool> PZSPSPCDXKC;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF00", Offset = "0x9B2BF00", VA = "0x189B2CF00")]
		public CMROJXELJSB(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CA40", Offset = "0x9B4BA40", VA = "0x189B4CA40", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class CORIQRQENCS : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class PEUYNJHNJIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public CORIQRQENCS NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PEUYNJHNJIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9B599B0", Offset = "0x9B589B0", VA = "0x189B599B0")]
			internal bool ASSUBUCXDSP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x9B59F60", Offset = "0x9B58F60", VA = "0x189B59F60")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private readonly MultiValueConfigProperty<bool> GXUDYDWYEPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private readonly Func<bool> GEMGEDOGGSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private readonly MultiValueConfigProperty<bool> BSPSKGZRUEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private readonly MultiValueConfigProperty<float> QXGBIWWYORX;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CCC0", Offset = "0x9B4BCC0", VA = "0x189B4CCC0")]
		public CORIQRQENCS(MultiValueConfigProperty<bool> a, Func<bool> canSeeShouldRespawn, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CB80", Offset = "0x9B4BB80", VA = "0x189B4CB80", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class AKHMQFVEMZJ : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class PUKJSNNOUVN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AKHMQFVEMZJ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PUKJSNNOUVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9B5A570", Offset = "0x9B59570", VA = "0x189B5A570")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9B5AC20", Offset = "0x9B59C20", VA = "0x189B5AC20")]
			internal void EMRIDICALST()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly Dictionary<SeatData.SVFNYUIHGCD.PostureType, string> PFLBSSIDHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private readonly string GOADRWHECSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private readonly Option<bool> CZIGSMAARZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private readonly MultiValueConfigProperty<SeatData.SVFNYUIHGCD.PostureType> YYNVXYTTYBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private readonly MultiValueConfigProperty<bool> WCPIOKBHIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private readonly MultiValueConfigProperty<bool> IPQMAOJZAAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private readonly MultiValueConfigProperty<bool> JXAEAKBZMSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private readonly MultiValueConfigProperty<bool> XCVEACWPNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly MultiValueConfigProperty<bool> KTMVYMEOZOS;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B620", Offset = "0x9B4A620", VA = "0x189B4B620")]
		public AKHMQFVEMZJ(string configName, Option<bool> a, MultiValueConfigProperty<SeatData.SVFNYUIHGCD.PostureType> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9B4B3F0", Offset = "0x9B4A3F0", VA = "0x189B4B3F0", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class JSDQPLIJVYE : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class TNCYCEOSYMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public JSDQPLIJVYE NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TNCYCEOSYMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CD30", Offset = "0x9B5BD30", VA = "0x189B5CD30")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private static readonly IReadOnlyDictionary<int, string> GTMSADMPYEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private readonly MultiValueConfigProperty<int> ZAZNHIXAOEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private readonly IReadOnlyDictionary<int, string> YEKLYGEKEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private readonly MultiValueConfigProperty<float> RJLAOYTUOJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private readonly MultiValueConfigProperty<int> UDAKNPKCVIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private readonly MultiValueConfigProperty<string> BTWFCZJSNCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly MultiValueConfigProperty<bool> HKLQTHKBNHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly MultiValueConfigProperty<string> ROZEXLWUXBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private readonly MultiValueConfigProperty<bool> CEAOIVLPIVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private readonly MultiValueConfigProperty<bool> CJFQEWMJVDY;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9B556A0", Offset = "0x9B546A0", VA = "0x189B556A0")]
		public JSDQPLIJVYE(MultiValueConfigProperty<int> a, IReadOnlyDictionary<int, string> teamItems, MultiValueConfigProperty<float> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<string> primaryHandRespawnTag, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> secondaryHandRespawnTag, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9B55450", Offset = "0x9B54450", VA = "0x189B55450", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public sealed class EKGGEOLCNZE : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public EKGGEOLCNZE NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public Action CUNZXWVSVUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Action CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9B50FD0", Offset = "0x9B4FFD0", VA = "0x189B50FD0")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x9B51F10", Offset = "0x9B50F10", VA = "0x189B51F10")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9B52280", Offset = "0x9B51280", VA = "0x189B52280")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9B52340", Offset = "0x9B51340", VA = "0x189B52340")]
			internal void ENBVXVPVEPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9B523A0", Offset = "0x9B513A0", VA = "0x189B523A0")]
			internal void ENHCVCJSOAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9B52FA0", Offset = "0x9B51FA0", VA = "0x189B52FA0")]
			internal void ENMJSJDPXMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly MultiValueConfigProperty<bool> MKACCNMIUNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private readonly MultiValueConfigProperty<float> RJLAOYTUOJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private readonly MultiValueConfigProperty<float> JWSQDIRPFXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private readonly GUNRAZGYEGZ BEBWWUSNAMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private readonly GUNRAZGYEGZ HJMLXETYIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private readonly IReadOnlyList<(Guid, string)>? APDHCMMYTHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> KQLRXFHXYSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> RJTVUHKTLRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private readonly Action<UTKZHCFJKWF.MultiTogglePickerData> QUFIVWDXDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private readonly RTIIRYITTNT? YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9B4FC50", Offset = "0x9B4EC50", VA = "0x189B4FC50")]
		public EKGGEOLCNZE(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, IReadOnlyList<(Guid, string)>? roleItems, ConfigProperty<string[]> roleGuidsToSpawn, ConfigProperty<string[]> roleGuidsToAvoid, Action<UTKZHCFJKWF.MultiTogglePickerData> onRolePickerClick, RTIIRYITTNT? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9B4FB10", Offset = "0x9B4EB10", VA = "0x189B4FB10", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public sealed class CQLMFZLQXHV : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class GHRVSQOAOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public CQLMFZLQXHV NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Action CUDMDJHYCXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Action CTSYIVUDKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public Action CUTGVDPQFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public Action CUITAQBVMIR;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GHRVSQOAOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9B51420", Offset = "0x9B50420", VA = "0x189B51420")]
			internal void EMMBGBIDCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9B51DF0", Offset = "0x9B50DF0", VA = "0x189B51DF0")]
			internal void EMRIDICALST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9B522E0", Offset = "0x9B512E0", VA = "0x189B522E0")]
			internal void ENBVXVPVEPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9B52160", Offset = "0x9B51160", VA = "0x189B52160")]
			internal void EMWPAOVXVEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9B52B10", Offset = "0x9B51B10", VA = "0x189B52B10")]
			internal void ENHCVCJSOAU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private readonly int PFNUCCAKANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly MultiValueConfigProperty<bool> ZVKZLWDXTKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private readonly MultiValueConfigProperty<float> RJLAOYTUOJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private readonly MultiValueConfigProperty<float> JWSQDIRPFXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private readonly GUNRAZGYEGZ BEBWWUSNAMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private readonly GUNRAZGYEGZ HJMLXETYIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private readonly RTIIRYITTNT? YFNPBGXPFEG;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CEB0", Offset = "0x9B4BEB0", VA = "0x189B4CEB0")]
		public CQLMFZLQXHV(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, RTIIRYITTNT? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4CD70", Offset = "0x9B4BD70", VA = "0x189B4CD70", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class NVYVBUVDNPE : SRBLGUGSSZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class BZJWDVGUZLQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public UTKZHCFJKWF EYJAGPOOIFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public NVYVBUVDNPE NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BZJWDVGUZLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9B4C130", Offset = "0x9B4B130", VA = "0x189B4C130")]
			internal void EMMBGBIDCHK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private readonly MultiValueConfigProperty<string> NNSFFDYAZDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly MultiValueConfigProperty<float> BNLGYPUDBTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly MultiValueConfigProperty<bool> CCSHYLCCAWQ;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9B448B0", Offset = "0x9B438B0", VA = "0x189B448B0")]
		public NVYVBUVDNPE(MultiValueConfigProperty<string> WelcomeMatName, MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9B59870", Offset = "0x9B58870", VA = "0x189B59870", Slot = "4")]
		public void AEITOFVXVNU(UTKZHCFJKWF a)
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
