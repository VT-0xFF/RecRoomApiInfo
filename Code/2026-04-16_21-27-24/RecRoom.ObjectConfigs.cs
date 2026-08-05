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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C4170", Offset = "0x99C2F70", VA = "0x1899C4170")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ObjectConfigs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class JRMXZZYLRLM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class UUXWEKIUFRE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JRMXZZYLRLM XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UUXWEKIUFRE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99D1C00", Offset = "0x99D0A00", VA = "0x1899D1C00")]
			internal bool NEIWXIDSQYL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x99D1180", Offset = "0x99CFF80", VA = "0x1899D1180")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IReadOnlyList<Channel> IFEMOURDRJD;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IReadOnlyList<Channel> YKUWAANIVNO;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly IReadOnlyList<RolloffCurve> YOSQSNIAVMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MultiValueConfigProperty<float> BDNOLTBYOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MultiValueConfigProperty<float> TXMRCWGYDUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MultiValueConfigProperty<Channel> LUFHORIUYSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly bool DIGTGMCBIVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string GRNVLOQCULS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MultiValueConfigProperty<bool> FAISJKHYZIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MultiValueConfigProperty<float> ENSOPQFLZEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MultiValueConfigProperty<RolloffCurve> ZNUSTZBOYIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MultiValueConfigProperty<bool> KTRFGHTPAXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly string IUPJQUOHEXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MultiValueConfigProperty<bool> CIILECCTUQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly string JBVXOHRJBUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MultiValueConfigProperty<bool> EVEAXQYHUNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly CULQQUABIKW? LLQJQYRGIPW;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99BF600", Offset = "0x99BE400", VA = "0x1899BF600")]
		private static string VJRBAVNRDTC(Channel a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99BF590", Offset = "0x99BE390", VA = "0x1899BF590")]
		private static string STLFTFATQFE(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99BF810", Offset = "0x99BE610", VA = "0x1899BF810")]
		public JRMXZZYLRLM(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<Channel> c, bool d, string useSpatialAudioLabel, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<RolloffCurve> g, MultiValueConfigProperty<bool> h, string isLoopingLabel, MultiValueConfigProperty<bool> i, string interruptCurrentSoundLabel, MultiValueConfigProperty<bool> j, CULQQUABIKW? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99BF450", Offset = "0x99BE250", VA = "0x1899BF450", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class VQZZNVQMEFT : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class SFJDTQTBFER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public VQZZNVQMEFT XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Func<bool> EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Func<bool> EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SFJDTQTBFER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x99CE1A0", Offset = "0x99CCFA0", VA = "0x1899CE1A0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99CD550", Offset = "0x99CC350", VA = "0x1899CD550")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x99CD4D0", Offset = "0x99CC2D0", VA = "0x1899CD4D0")]
			internal bool JHFNVQJCMYX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99CD450", Offset = "0x99CC250", VA = "0x1899CD450")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly IReadOnlyDictionary<Channel, string> VKKLPAXZYUC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly IReadOnlyDictionary<Channel, string> IHJCBMFVOZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool RDAPGBAPMRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly TSDPGPPNNLL VNGQHLOUPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MultiValueConfigProperty<bool> ABXHLGFRGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MultiValueConfigProperty<Channel> LUFHORIUYSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly MultiValueConfigProperty<float> OAKFGUDCOZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MultiValueConfigProperty<float> PKFQVZBECJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MultiValueConfigProperty<bool> RMXWOYGVRLO;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99D2520", Offset = "0x99D1320", VA = "0x1899D2520")]
		public VQZZNVQMEFT(bool a, TSDPGPPNNLL recordableObjectOptions, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<Channel> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99D2170", Offset = "0x99D0F70", VA = "0x1899D2170", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class SUIBGRIICEX : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SUIBGRIICEX XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Func<bool> EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Func<bool> EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> EPKNAALMSWP;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99BC140", Offset = "0x99BAF40", VA = "0x1899BC140")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x99BB030", Offset = "0x99B9E30", VA = "0x1899BB030")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x99BAF80", Offset = "0x99B9D80", VA = "0x1899BAF80")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x99BAD80", Offset = "0x99B9B80", VA = "0x1899BAD80")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x99BAD60", Offset = "0x99B9B60", VA = "0x1899BAD60")]
			internal bool JGVABCVHUCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99BACD0", Offset = "0x99B9AD0", VA = "0x1899BACD0")]
			internal bool JGPTDWBKKQW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Option<string> LFVEZQZGHSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MultiValueConfigProperty<bool> ZJUMOCEZBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly IReadOnlyDictionary<int, string>? YVDXTCHIOCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MultiValueConfigProperty<int> DNKJAPDYHGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Option<string> KBQFJGZOUOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly MultiValueConfigProperty<bool> YLAEUDZEFQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Option<string> VNAXLXEPXST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MultiValueConfigProperty<int> BDNOLTBYOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Option<string> QXASIIMXNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly MultiValueConfigProperty<bool> ZMWFGAPSCMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Func<Option<bool>> VDVPKOZWYTA;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99CE340", Offset = "0x99CD140", VA = "0x1899CE340")]
		public SUIBGRIICEX(Option<string> is3dAudioLabel, MultiValueConfigProperty<bool> a, Option<string[]> sfxOptions, MultiValueConfigProperty<int> b, Option<string> isInterruptibleLabel, MultiValueConfigProperty<bool> c, Option<string> volumeLabel, MultiValueConfigProperty<int> d, Option<string> playForAllLabel, MultiValueConfigProperty<bool> e, Func<Option<bool>> hasControlPanel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99CE200", Offset = "0x99CD000", VA = "0x1899CE200", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class IDFOMATBWSA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class XCEEGWYISVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public IDFOMATBWSA XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A50", Offset = "0x99D2850", VA = "0x1899D3A50")]
			internal bool RPVHMFCIMJX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A00", Offset = "0x99D2800", VA = "0x1899D3A00")]
			internal bool PPHLKOUSMXX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x99D38F0", Offset = "0x99D26F0", VA = "0x1899D38F0")]
			internal void JGVABCVHUCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x99D3880", Offset = "0x99D2680", VA = "0x1899D3880")]
			internal bool JGPTDWBKKQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x99D3800", Offset = "0x99D2600", VA = "0x1899D3800")]
			internal bool JGKMGPHNBFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x99D3970", Offset = "0x99D2770", VA = "0x1899D3970")]
			internal bool JHFNVQJCMYX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99D3950", Offset = "0x99D2750", VA = "0x1899D3950")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly IReadOnlyList<PreferredHandedness> WVEMEYBVQVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly AccountRoleType HQUSLXOLZIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly ZSHNODKQKJY? CIZRSUWNAMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly MultiValueConfigProperty<bool> ZSRGMHRZNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Option<bool> RUUONQUQVWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Option<bool> AUVQZJTHKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly MultiValueConfigProperty<PreferredHandedness> IOGRPYQXOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MultiValueConfigProperty<bool> CCPVKDJJHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly MultiValueConfigProperty<bool> KIITJSPZCVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly MultiValueConfigProperty<bool> KVBYLGGDGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly MultiValueConfigProperty<bool> FXWUHYHVHWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly MultiValueConfigProperty<bool> MUIBGSKGFPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MultiValueConfigProperty<bool> OFQATSXAMDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly bool LRCFOCRUHSG;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99BD960", Offset = "0x99BC760", VA = "0x1899BD960")]
		private static string RUPUSUSSIUV(PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99BDA10", Offset = "0x99BC810", VA = "0x1899BDA10")]
		public IDFOMATBWSA(AccountRoleType a, ZSHNODKQKJY? interactionFilterOptions, MultiValueConfigProperty<bool> b, Option<bool> c, Option<bool> d, MultiValueConfigProperty<PreferredHandedness> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, bool l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99BCDF0", Offset = "0x99BBBF0", VA = "0x1899BCDF0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class WQGKHAKARSJ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public WQGKHAKARSJ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<bool> EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Action EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Func<bool> EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x99C5060", Offset = "0x99C3E60", VA = "0x1899C5060")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99C4D00", Offset = "0x99C3B00", VA = "0x1899C4D00")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x99C49A0", Offset = "0x99C37A0", VA = "0x1899C49A0")]
			internal void JHAGYJPFDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99C4830", Offset = "0x99C3630", VA = "0x1899C4830")]
			internal void JGVABCVHUCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x99C47D0", Offset = "0x99C35D0", VA = "0x1899C47D0")]
			internal bool JGKMGPHNBFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x99C4800", Offset = "0x99C3600", VA = "0x1899C4800")]
			internal bool JGPTDWBKKQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x99C4B00", Offset = "0x99C3900", VA = "0x1899C4B00")]
			internal void JHFNVQJCMYX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly bool BEVKZBOWZDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool CTEEOAICEYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly IDFOMATBWSA ZIGMYXOYFWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly KRNKJSZFEBQ? AGONFRJIZXZ;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99D3650", Offset = "0x99D2450", VA = "0x1899D3650")]
		public WQGKHAKARSJ(int a, bool b, bool c, IDFOMATBWSA d, KRNKJSZFEBQ? creatorRestrictedRolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99D3510", Offset = "0x99D2310", VA = "0x1899D3510", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class LIVFZTTZXIA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public LIVFZTTZXIA XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x99BA0B0", Offset = "0x99B8EB0", VA = "0x1899BA0B0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly IDFOMATBWSA ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public LIVFZTTZXIA(IDFOMATBWSA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99C1D00", Offset = "0x99C0B00", VA = "0x1899C1D00", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class JTIORCKVYJQ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public JTIORCKVYJQ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x99CAB20", Offset = "0x99C9920", VA = "0x1899CAB20")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x99C97B0", Offset = "0x99C85B0", VA = "0x1899C97B0")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly ZSHNODKQKJY? JIPVEANNCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MultiValueConfigProperty<bool> SXKZPYSHPGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Option<bool> VDVPKOZWYTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly MultiValueConfigProperty<bool> LXYFVFXVSYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly MultiValueConfigProperty<bool> RMTKZAFXTJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly PNUMWIPZHAZ? WAMRLXAGFWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly CULQQUABIKW? PWAKMGAMAFQ;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99BFD40", Offset = "0x99BEB40", VA = "0x1899BFD40")]
		public JTIORCKVYJQ(ZSHNODKQKJY? interactionFilterConfig, MultiValueConfigProperty<bool> a, Option<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, CULQQUABIKW? syncedComponent, PNUMWIPZHAZ? playerEditableText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99BFC00", Offset = "0x99BEA00", VA = "0x1899BFC00", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class RRHDJCMCGCW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public RRHDJCMCGCW XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x99D08A0", Offset = "0x99CF6A0", VA = "0x1899D08A0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x99CF520", Offset = "0x99CE320", VA = "0x1899CF520")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly ZSHNODKQKJY? JIPVEANNCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly MultiValueConfigProperty<bool> JNVHDGTMTIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly MultiValueConfigProperty<bool> SXKZPYSHPGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly MultiValueConfigProperty<bool> KJSBIPOOBUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Option<bool> VDVPKOZWYTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly MultiValueConfigProperty<bool> LXYFVFXVSYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly MultiValueConfigProperty<bool> RMTKZAFXTJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly CULQQUABIKW? PWAKMGAMAFQ;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99CCD90", Offset = "0x99CBB90", VA = "0x1899CCD90")]
		public RRHDJCMCGCW(ZSHNODKQKJY? interactionFilterConfig, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, Option<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, CULQQUABIKW? syncedComponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99CCC50", Offset = "0x99CBA50", VA = "0x1899CCC50", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class TJJPNHQVSKV : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public TJJPNHQVSKV XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x99C0C20", Offset = "0x99BFA20", VA = "0x1899C0C20")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MultiValueConfigProperty<bool> DDQXEGCKSUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MultiValueConfigProperty<float> XAZOPQICBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly PFEJMQKPUYZ? XQZTLOBFUUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly CULQQUABIKW? LRICCRRRUPO;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99CE7F0", Offset = "0x99CD5F0", VA = "0x1899CE7F0")]
		public TJJPNHQVSKV(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, PFEJMQKPUYZ? sandboxColorableOptions, CULQQUABIKW? syncedComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99CE6B0", Offset = "0x99CD4B0", VA = "0x1899CE6B0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class IRYOTFCFMXR : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IRYOTFCFMXR XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x99C1750", Offset = "0x99C0550", VA = "0x1899C1750")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly IReadOnlyList<CircuitsTransformBehavior> FLNQGNAYTKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly MultiValueConfigProperty<CircuitsTransformBehavior> BGYORVZOVCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NJVBEOZDXHM? EILTBWOXUNM;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99BE040", Offset = "0x99BCE40", VA = "0x1899BE040")]
		private static string IRVCHNUJRTM(CircuitsTransformBehavior a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99BE260", Offset = "0x99BD060", VA = "0x1899BE260")]
		public IRYOTFCFMXR(MultiValueConfigProperty<CircuitsTransformBehavior> a, NJVBEOZDXHM? objectBoardConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99BE090", Offset = "0x99BCE90", VA = "0x1899BE090", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class AUJATPLSAXU : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AUJATPLSAXU XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x99CA690", Offset = "0x99C9490", VA = "0x1899CA690")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string VYEBJQMXICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly MultiValueConfigProperty<string> VDCNASEUPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly MultiValueConfigProperty<bool> KCJLKQDTBHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MultiValueConfigProperty<bool> LVFTBKZOBAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MultiValueConfigProperty<bool> JKVOIXWYYGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly ZSHNODKQKJY? TZWUDFWNMDR;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99B36C0", Offset = "0x99B24C0", VA = "0x1899B36C0")]
		public AUJATPLSAXU(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, ZSHNODKQKJY? portalInteractionFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99B3580", Offset = "0x99B2380", VA = "0x1899B3580", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class CEYEDHPTKST : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public CEYEDHPTKST XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x99BB8B0", Offset = "0x99BA6B0", VA = "0x1899BB8B0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string VYEBJQMXICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly MultiValueConfigProperty<string> VDCNASEUPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly MultiValueConfigProperty<bool> KCJLKQDTBHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly MultiValueConfigProperty<float> USEMWRDUBVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly MultiValueConfigProperty<bool> ZWJBPDAZDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly MultiValueConfigProperty<bool> ZWSLBCRDBGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MultiValueConfigProperty<bool> LVFTBKZOBAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly MultiValueConfigProperty<bool> WDVZHVBAKVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly MultiValueConfigProperty<float> WYPPYJZPFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ZSHNODKQKJY? CIZRSUWNAMZ;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99B5E10", Offset = "0x99B4C10", VA = "0x1899B5E10")]
		public CEYEDHPTKST(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<float> g, ZSHNODKQKJY? interactionFilterOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99B5CD0", Offset = "0x99B4AD0", VA = "0x1899B5CD0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class OHSTDKGJSTU : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public OHSTDKGJSTU XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Func<bool> EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Func<bool> EPFGCTRPJLG;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x99CB220", Offset = "0x99CA020", VA = "0x1899CB220")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x99C90C0", Offset = "0x99C7EC0", VA = "0x1899C90C0")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x99C8EE0", Offset = "0x99C7CE0", VA = "0x1899C8EE0")]
			internal bool JGVABCVHUCF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Dictionary<LocomotionFilterModes, string> OTGTWGFLOWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly MultiValueConfigProperty<bool> OMRFBEQKVQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MultiValueConfigProperty<bool> XFJTXYEVOKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MultiValueConfigProperty<bool> LPVROUDCDFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MultiValueConfigProperty<bool> DBYNMTTYJVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MultiValueConfigProperty<string> ZXLMWPVFCZN;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99C4430", Offset = "0x99C3230", VA = "0x1899C4430")]
		public OHSTDKGJSTU(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> roleFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99C41F0", Offset = "0x99C2FF0", VA = "0x1899C41F0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class XVIRDZEGPBE : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public XVIRDZEGPBE XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x99CF5F0", Offset = "0x99CE3F0", VA = "0x1899CF5F0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x99CF4B0", Offset = "0x99CE2B0", VA = "0x1899CF4B0")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MultiValueConfigProperty<bool> DDQXEGCKSUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly MultiValueConfigProperty<bool> DVFOYYDGMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ZSHNODKQKJY? SXEDDJWSFWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly MultiValueConfigProperty<bool> RTMKIGKGRVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly MultiValueConfigProperty<bool> GTDROCJPDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly MultiValueConfigProperty<bool> LPVROUDCDFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CULQQUABIKW IOAYVHWKIEN;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99D3DC0", Offset = "0x99D2BC0", VA = "0x1899D3DC0")]
		public XVIRDZEGPBE(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, ZSHNODKQKJY? playerInteractionFilter, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, CULQQUABIKW syncComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99D3C70", Offset = "0x99D2A70", VA = "0x1899D3C70", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class BYKOBSKCJFM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public BYKOBSKCJFM XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Func<bool> EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public Func<bool> EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<bool> EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x99CFB90", Offset = "0x99CE990", VA = "0x1899CFB90")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x99CF3E0", Offset = "0x99CE1E0", VA = "0x1899CF3E0")]
			internal bool JGVABCVHUCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x99CF3E0", Offset = "0x99CE1E0", VA = "0x1899CF3E0")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x99CF450", Offset = "0x99CE250", VA = "0x1899CF450")]
			internal bool JHFNVQJCMYX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x99CF400", Offset = "0x99CE200", VA = "0x1899CF400")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly Dictionary<TriggerVolumeV1Mode, string> BXCNYCCXEQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MultiValueConfigProperty<TriggerVolumeV1Mode> MLOHULLTXVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly bool DDRPYHEMUKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly MultiValueConfigProperty<bool> OQVIIVNULKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly MultiValueConfigProperty<bool> RMTKZAFXTJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly MultiValueConfigProperty<string> MZLXQTQSDYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly MultiValueConfigProperty<string> YVCLDLAGGMP;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x99B58A0", Offset = "0x99B46A0", VA = "0x1899B58A0")]
		public BYKOBSKCJFM(MultiValueConfigProperty<int> a, bool b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> filterTag, MultiValueConfigProperty<string> filterRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99B5670", Offset = "0x99B4470", VA = "0x1899B5670", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class PBXCTBUMSGM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public PBXCTBUMSGM XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x99BA990", Offset = "0x99B9790", VA = "0x1899BA990")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x99BA4F0", Offset = "0x99B92F0", VA = "0x1899BA4F0")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly MultiValueConfigProperty<bool> RMTKZAFXTJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly IYYXSZTVWSI PQBHGNXVLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly MultiValueConfigProperty<string> RGBQVZCLHGO;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99C4740", Offset = "0x99C3540", VA = "0x1899C4740")]
		public PBXCTBUMSGM(MultiValueConfigProperty<bool> a, IYYXSZTVWSI objectTagsConfig, MultiValueConfigProperty<string> filterByRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99C4600", Offset = "0x99C3400", VA = "0x1899C4600", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class LJJANUUWFNL : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class SFJDTQTBFER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public LJJANUUWFNL XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SFJDTQTBFER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x99CDCB0", Offset = "0x99CCAB0", VA = "0x1899CDCB0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly MultiValueConfigProperty<bool> RMTKZAFXTJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly MultiValueConfigProperty<bool> HADUYUQVHVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> FQLECXMQAUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ConfigProperty<IReadOnlyList<string>> TBRKJRARCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly ConfigProperty<IReadOnlyList<string>>? FYIFOVBQXVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly MultiValueConfigProperty<bool> KLOCKGBGBKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> XOPCBMBCCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly ConfigProperty<IReadOnlyList<string>> AFLURZDBZZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ConfigProperty<IReadOnlyList<string>>? YQXWSKJWUZL;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99C1F80", Offset = "0x99C0D80", VA = "0x1899C1F80")]
		public LJJANUUWFNL(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<InteractionFilterMode> d, ConfigProperty<IReadOnlyList<string>> persistentPlayerTags, ConfigProperty<IReadOnlyList<string>>? runtimePlayerTags, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<InteractionFilterMode> f, ConfigProperty<IReadOnlyList<string>> persistentObjectTags, ConfigProperty<IReadOnlyList<string>>? runtimeObjectTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99C1E40", Offset = "0x99C0C40", VA = "0x1899C1E40", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
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
		[Cpp2IlInjected.Address(RVA = "0x1F2BCE0", Offset = "0x1F2AAE0", VA = "0x181F2BCE0")]
		public ConfigProperty(Func<T> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class DMUBIYAKMIA
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class ITTXRCVCEBE<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Func<a, b> VASIZTAIPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ConfigProperty<a> XEZWAQIYXMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Func<b, a> DWTJBFUWNYJ;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ITTXRCVCEBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x658FD20", Offset = "0x658EB20", VA = "0x18658FD20")]
			internal b FTNKLEHFGRG()
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x65904F0", Offset = "0x658F2F0", VA = "0x1865904F0")]
			internal void MTTPLCDXZQD(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x38D60D0", Offset = "0x38D4ED0", VA = "0x1838D60D0")]
		public static ConfigProperty<U> To<U, T>(this ConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(ConfigProperty<U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class JREDFIEAUMP : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class BVQANBPWYUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public JREDFIEAUMP XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Action EPFGCTRPJLG;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x99B5650", Offset = "0x99B4450", VA = "0x1899B5650")]
			internal bool YMPLWOISIAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x99B4450", Offset = "0x99B3250", VA = "0x1899B4450")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x99B42C0", Offset = "0x99B30C0", VA = "0x1899B42C0")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x99B4140", Offset = "0x99B2F40", VA = "0x1899B4140")]
			internal bool JGPTDWBKKQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x99B4210", Offset = "0x99B3010", VA = "0x1899B4210")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x99B41B0", Offset = "0x99B2FB0", VA = "0x1899B41B0")]
			internal void JGVABCVHUCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly (int, string)[] WGBRADMYZPG;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly Dictionary<int, string> YPNIFUTFZSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly int EPDLDQABMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly ZSHNODKQKJY? VXPRXRGUMRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ConfigProperty<int> VKVPURZNOOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Action<RNLDKFFPJOS.MultiTogglePickerData> JJQLHNMXMVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly MultiValueConfigProperty<bool> WJFZETRYLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly MultiValueConfigProperty<bool> EBLRCCDJKOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly KRNKJSZFEBQ? FANUVGSWVBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly Func<Option<bool>> CIGXQTDABDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly MultiValueConfigProperty<bool> SHGLMKPLVJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MultiValueConfigProperty<bool> DRIFIHTZOKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Func<bool> WSRDZJVQDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly RoomKeyConfig ADZIVDZDIGL;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x99BF2E0", Offset = "0x99BE0E0", VA = "0x1899BF2E0")]
		public JREDFIEAUMP(int a, ZSHNODKQKJY? additionalCostumeConfigOptions, ConfigProperty<int> b, Action<RNLDKFFPJOS.MultiTogglePickerData> onOutfitFilterClick, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, KRNKJSZFEBQ? playerRolesToAddData, Func<Option<bool>> hasPlayerEquipped, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, Func<bool> isLegacyRoom, RoomKeyConfig roomKeyConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99BEC60", Offset = "0x99BDA60", VA = "0x1899BEC60", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class EQEPKULTWXS : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly MultiValueConfigProperty<int> VEVDHRORFHB;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public EQEPKULTWXS(MultiValueConfigProperty<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99B68A0", Offset = "0x99B56A0", VA = "0x1899B68A0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class PYDNCFLGEBV : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class EZRPNFOJXLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public PYDNCFLGEBV XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public ConfigProperty<int[]> USXWKGIFHRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public Func<bool> EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public Func<bool> FOXIUDBCXZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public Func<bool> FOSBWWHFOOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<bool> MKSEGOZQVFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Func<bool> FPHWOQOXQWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Func<bool> FPCPRJVAHKY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public Func<bool> MKXLDVTOEQZ;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EZRPNFOJXLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x99B8A10", Offset = "0x99B7810", VA = "0x1899B8A10")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x99B7070", Offset = "0x99B5E70", VA = "0x1899B7070")]
			internal bool JGKMGPHNBFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x99B8470", Offset = "0x99B7270", VA = "0x1899B8470")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x99B7F30", Offset = "0x99B6D30", VA = "0x1899B7F30")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x99B7610", Offset = "0x99B6410", VA = "0x1899B7610")]
			internal void JHAGYJPFDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x99B6E10", Offset = "0x99B5C10", VA = "0x1899B6E10")]
			internal bool BUYIGBAVZZA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x99B6E80", Offset = "0x99B5C80", VA = "0x1899B6E80")]
			internal bool BVDPDHUTJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x99B9250", Offset = "0x99B8050", VA = "0x1899B9250")]
			internal bool UVXGLKVYHTL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x99B6EF0", Offset = "0x99B5CF0", VA = "0x1899B6EF0")]
			internal bool BWYZEQRVQIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x99B6FB0", Offset = "0x99B5DB0", VA = "0x1899B6FB0")]
			internal bool BXEGBXLSZTV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x99B7280", Offset = "0x99B6080", VA = "0x1899B7280")]
			internal void JGVABCVHUCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x99B91C0", Offset = "0x99B7FC0", VA = "0x1899B91C0")]
			internal bool UVRZOECAYIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x99B70E0", Offset = "0x99B5EE0", VA = "0x1899B70E0")]
			internal void JGPTDWBKKQW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class EZMIPYUMOAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public bool TIQJHEKEUPP;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EZMIPYUMOAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD3CC00", Offset = "0xD3BA00", VA = "0x180D3CC00")]
			internal bool JFZYMBTSIIV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class EZHBSSAPEOT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public int JMPYDXGGVLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public EZRPNFOJXLL DODNVPQZHNM;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EZHBSSAPEOT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x99B6DA0", Offset = "0x99B5BA0", VA = "0x1899B6DA0")]
			internal bool JFUROUZUYXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x99B6AA0", Offset = "0x99B58A0", VA = "0x1899B6AA0")]
			internal void BWOLKDEAXLU(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x99B69F0", Offset = "0x99B57F0", VA = "0x1899B69F0")]
			internal bool BWDXPPQGEPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x99B6A40", Offset = "0x99B5840", VA = "0x1899B6A40")]
			internal string BWJEMWKDOAL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class EZBUVLGRVDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public bool FWYAQWNAJPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public EZHBSSAPEOT DNYGYIXBYCD;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EZBUVLGRVDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x99B6990", Offset = "0x99B5790", VA = "0x1899B6990")]
			internal bool BWTSHJXYGXD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly IReadOnlyList<VoiceOption> UODZTMVGYOY;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly IReadOnlyList<VoiceOption> IWANNYVQIPX;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly IReadOnlyList<RolloffCurve> YOSQSNIAVMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly MultiValueConfigProperty<string> CDFKLLMZLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly int ECVKUURDBDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly MultiValueConfigProperty<float> RDHKOZJZXBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly MultiValueConfigProperty<VoiceOption> JXJHKZEFVWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly MultiValueConfigProperty<string> QEIVVNQAUPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly MultiValueConfigProperty<bool> UMUJTDFGQTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly MultiValueConfigProperty<bool> GINVTWIRSZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly string NFQTTNSQXXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly MultiValueConfigProperty<bool>? LPKULQWBBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly MultiValueConfigProperty<bool>[] BZHBJQSKPNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly IReadOnlyList<string> ABNPIWZMFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly IReadOnlyList<string> BXALTOLPIQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly IReadOnlyList<bool> JUKNTSWIJUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly ConfigProperty<int[]>? DWZTAKSJZEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Func<IEnumerable<int>> DYVEOQHHACQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Func<int, bool> SQCAHNNZKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly Func<int, string?> WUPVZUDTUFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly Func<int, string?> TFXTFSKRMBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string GRNVLOQCULS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly MultiValueConfigProperty<bool> FAISJKHYZIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly MultiValueConfigProperty<float> ENSOPQFLZEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly MultiValueConfigProperty<RolloffCurve> ZNUSTZBOYIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly MultiValueConfigProperty<bool> KTRFGHTPAXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly MultiValueConfigProperty<bool>? KTXBHBCUYPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly MultiValueConfigProperty<bool> PSMRURMYDAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly MultiValueConfigProperty<bool> CSILLHJFQAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly MultiValueConfigProperty<bool>? KFMSXMFLVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly MultiValueConfigProperty<float>? GUMGAQSFSJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly bool HHELQGNHPMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly MultiValueConfigProperty<int> VALQCCVXHZT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool PKADGPRRKLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x99C7F30", Offset = "0x99C6D30", VA = "0x1899C7F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool SEOLPNGBSFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x99C7F80", Offset = "0x99C6D80", VA = "0x1899C7F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99C8570", Offset = "0x99C7370", VA = "0x1899C8570")]
		private static string STLFTFATQFE(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x99C8AB0", Offset = "0x99C78B0", VA = "0x1899C8AB0")]
		public PYDNCFLGEBV(MultiValueConfigProperty<string> instructions, int a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<VoiceOption> c, MultiValueConfigProperty<bool>? d, MultiValueConfigProperty<string> useContext, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, string aiSettingsInfoText, MultiValueConfigProperty<bool>? g, MultiValueConfigProperty<bool>[] functionEnablements, IReadOnlyList<string> functionEnablementNames, IReadOnlyList<string> functionEnablementDescriptions, IReadOnlyList<bool> functionEnablementVisibilities, ConfigProperty<int[]>? circuitsFunctionEnablements, Func<IEnumerable<int>> getAllCircuitsFunctionIds, Func<int, bool> getCircuitsFunctionExists, Func<int, string?> getCircuitsFunctionName, Func<int, string?> getCircuitsFunctionInvalidReason, string useSpatialAudioLabel, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<RolloffCurve> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool>? n, MultiValueConfigProperty<float>? o, bool p, MultiValueConfigProperty<int> q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99C8040", Offset = "0x99C6E40", VA = "0x1899C8040", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class GHEBEJQNVKR : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public GHEBEJQNVKR XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x99B9DB0", Offset = "0x99B8BB0", VA = "0x1899B9DB0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly MultiValueConfigProperty<bool> AWPVDLMMUOI;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public GHEBEJQNVKR(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x99BC820", Offset = "0x99BB620", VA = "0x1899BC820", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class NFYLKZWAMAW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public NFYLKZWAMAW XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x99B9A50", Offset = "0x99B8850", VA = "0x1899B9A50")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly MultiValueConfigProperty<bool> ZQHHFZVQURI;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public NFYLKZWAMAW(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x99C39F0", Offset = "0x99C27F0", VA = "0x1899C39F0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class BNSEWWVYFNS : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly string PGJSTNBIOKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly MultiValueConfigProperty<bool> CGCEFQFFLJX;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x99B40E0", Offset = "0x99B2EE0", VA = "0x1899B40E0")]
		public BNSEWWVYFNS(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x99B3FC0", Offset = "0x99B2DC0", VA = "0x1899B3FC0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class MBMELHINWLB : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public MBMELHINWLB XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x99C0200", Offset = "0x99BF000", VA = "0x1899C0200")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly MultiValueConfigProperty<bool> NPPYMXJGYBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly MultiValueConfigProperty<bool> UJUYEDOPSBK;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x99C2710", Offset = "0x99C1510", VA = "0x1899C2710")]
		public MBMELHINWLB(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x99C25D0", Offset = "0x99C13D0", VA = "0x1899C25D0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class DDQLLRPNDRI : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public DDQLLRPNDRI XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public Func<bool> EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x99C60B0", Offset = "0x99C4EB0", VA = "0x1899C60B0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x99C4F50", Offset = "0x99C3D50", VA = "0x1899C4F50")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x99C4CE0", Offset = "0x99C3AE0", VA = "0x1899C4CE0")]
			internal bool JHFNVQJCMYX()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly ZSHNODKQKJY CIZRSUWNAMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly Func<bool> UQHZMXFWXYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly Action UUTJLACUCST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly bool ZSYVGLRKVMI;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x99B60E0", Offset = "0x99B4EE0", VA = "0x1899B60E0")]
		public DDQLLRPNDRI(int a, ZSHNODKQKJY b, Action c, Func<bool> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x99B5FA0", Offset = "0x99B4DA0", VA = "0x1899B5FA0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class VXSEBSYJFRK : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class OJWHUTBEGLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public readonly MultiValueConfigProperty<float> EIGYKJLXADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public readonly MultiValueConfigProperty<float> XKWIPYPPWSX;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x99C2710", Offset = "0x99C1510", VA = "0x1899C2710")]
			public OJWHUTBEGLJ(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public sealed class MZNYTOAKINP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public readonly MultiValueConfigProperty<float> RHPOSBAUGFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public readonly MultiValueConfigProperty<float> CHTTPKWMVWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public readonly MultiValueConfigProperty<bool> CDDFMRQXLNZ;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x99C3960", Offset = "0x99C2760", VA = "0x1899C3960")]
			public MZNYTOAKINP(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class OGYZMSKQTLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public readonly MultiValueConfigProperty<float> IUPSFZCHJCB;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
			public OGYZMSKQTLG(MultiValueConfigProperty<float> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public VXSEBSYJFRK XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x99BC5C0", Offset = "0x99BB3C0", VA = "0x1899BC5C0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x99BB050", Offset = "0x99B9E50", VA = "0x1899BB050")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x99BAE00", Offset = "0x99B9C00", VA = "0x1899BAE00")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x99BADA0", Offset = "0x99B9BA0", VA = "0x1899BADA0")]
			internal void JHAGYJPFDNO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly MultiValueConfigProperty<int> FGRHDQSHSUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly MultiValueConfigProperty<int> EZLIPQXOQGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly OJWHUTBEGLJ HVWVGHVOSYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly MZNYTOAKINP XZEHTZGQYQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly OGYZMSKQTLG VTOXUNWCBUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MultiValueConfigProperty<bool> ZZFFLCSSEZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly MGJRKZYPXUM PICXONSRVDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly MGJRKZYPXUM STGBKQCJCVW;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x99D2B00", Offset = "0x99D1900", VA = "0x1899D2B00")]
		public VXSEBSYJFRK(MultiValueConfigProperty<float> vehicleMass, MultiValueConfigProperty<int> boostFuelCapacity, OJWHUTBEGLJ a, MZNYTOAKINP b, OGYZMSKQTLG c, MultiValueConfigProperty<bool> canFrontWheelsSteer, MGJRKZYPXUM d, MGJRKZYPXUM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x99D2800", Offset = "0x99D1600", VA = "0x1899D2800", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class MGJRKZYPXUM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MultiValueConfigProperty<bool> PVKJZECCRRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly MultiValueConfigProperty<bool> BWXNTVBGUST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly MultiValueConfigProperty<float> PMKLMBOMPKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly MultiValueConfigProperty<float> DWOTFPJKUXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly MultiValueConfigProperty<float> ZMMJPQTABIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private readonly MultiValueConfigProperty<float> OUOYPQJPWCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private readonly MultiValueConfigProperty<float> WPFNKHDXLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly MultiValueConfigProperty<float> TQUSKVHKBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly MultiValueConfigProperty<float> BRODNDKEBSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly MultiValueConfigProperty<float> LBSGDXCHPYH;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x99C31E0", Offset = "0x99C1FE0", VA = "0x1899C31E0")]
		public MGJRKZYPXUM(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x99C2780", Offset = "0x99C1580", VA = "0x1899C2780", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class UMGAIVLSNOC : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public UMGAIVLSNOC XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x99C1210", Offset = "0x99C0010", VA = "0x1899C1210")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly MultiValueConfigProperty<float> LTWJWCCHVGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly MultiValueConfigProperty<float> XLBIWGYQLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly MultiValueConfigProperty<float> ZWICRHANCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly MultiValueConfigProperty<float> MMNPFQCITTQ;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x99D0F90", Offset = "0x99CFD90", VA = "0x1899D0F90")]
		public UMGAIVLSNOC(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x99D0E50", Offset = "0x99CFC50", VA = "0x1899D0E50", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class NMWJIXJTQDZ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly MultiValueConfigProperty<bool> ELORJSCBQQJ;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public NMWJIXJTQDZ(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x99C3B30", Offset = "0x99C2930", VA = "0x1899C3B30", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class IYYKHCVEVCW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public IYYKHCVEVCW XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x99BA930", Offset = "0x99B9730", VA = "0x1899BA930")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x99BA370", Offset = "0x99B9170", VA = "0x1899BA370")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly TSDPGPPNNLL VNGQHLOUPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly NMWJIXJTQDZ LYBWJCLPLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly MultiValueConfigProperty<bool> BHQKNATANSP;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x99BEBE0", Offset = "0x99BD9E0", VA = "0x1899BEBE0")]
		public IYYKHCVEVCW(TSDPGPPNNLL a, NMWJIXJTQDZ b, MultiValueConfigProperty<bool> hideProjector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x99BEA10", Offset = "0x99BD810", VA = "0x1899BEA10", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class PSXSXWDPHXZ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public PSXSXWDPHXZ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x99C0480", Offset = "0x99BF280", VA = "0x1899C0480")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x99C0030", Offset = "0x99BEE30", VA = "0x1899C0030")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly MultiValueConfigProperty<bool> OVMTAAOYTYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Option<bool> SIDHSPBHQFU;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x99C7EE0", Offset = "0x99C6CE0", VA = "0x1899C7EE0")]
		public PSXSXWDPHXZ(Option<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x99C7DB0", Offset = "0x99C6BB0", VA = "0x1899C7DB0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class QRFYNDZPVJB : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public QRFYNDZPVJB XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x99BA550", Offset = "0x99B9350", VA = "0x1899BA550")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly IReadOnlyDictionary<PhysicsMode, string> JZLJQRABAWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly MultiValueConfigProperty<PhysicsMode> ZZMUXDLYRLT;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x99CBCD0", Offset = "0x99CAAD0", VA = "0x1899CBCD0")]
		public QRFYNDZPVJB(int a, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x99CBA70", Offset = "0x99CA870", VA = "0x1899CBA70", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class BFSUNOSOCCN : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public BFSUNOSOCCN XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F00", Offset = "0x99B8D00", VA = "0x1899B9F00")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly MultiValueConfigProperty<bool> TWGVHWOSGDA;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public BFSUNOSOCCN(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x99B3B10", Offset = "0x99B2910", VA = "0x1899B3B10", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class TSDPGPPNNLL : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly string EHNDPLCQHYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly Action ISNOQOGDVUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public readonly Func<Option<bool>> NTHOJVNIMVY;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xDB85D0", Offset = "0xDB73D0", VA = "0x180DB85D0")]
		public TSDPGPPNNLL(string a, Action b, Func<Option<bool>> hasRecordableData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x99CE9D0", Offset = "0x99CD7D0", VA = "0x1899CE9D0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB20", Offset = "0x99CD920", VA = "0x1899CEB20")]
		[CompilerGenerated]
		private bool UAWMDWVWDJY()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class RoomKeyConfig : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public RoomKeyConfig XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x99C0740", Offset = "0x99BF540", VA = "0x1899C0740")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x99BFFE0", Offset = "0x99BEDE0", VA = "0x1899BFFE0")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly IVBENHNIIJR KJVFBRJIOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly Func<InventionPermission> OTDAPQPOELM;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		public RoomKeyConfig(IVBENHNIIJR roomKeyOptions, Func<InventionPermission> getLowestInventionPermission)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x99CD0B0", Offset = "0x99CBEB0", VA = "0x1899CD0B0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class IVBENHNIIJR : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public IVBENHNIIJR XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x99C9800", Offset = "0x99C8600", VA = "0x1899C9800")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x99C93A0", Offset = "0x99C81A0", VA = "0x1899C93A0")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public readonly bool DXUMJUGUQYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly string EIGJSLXHYFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Func<bool> IOQADXHUUKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly Func<bool> MHULHUULJUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly Action? VSDYSLXJLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly MultiValueConfigProperty<Guid> BEFGTQXXLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly Action<RNLDKFFPJOS.RoomKeyPickerData> NTWAZCQCULS;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x99BE3D0", Offset = "0x99BD1D0", VA = "0x1899BE3D0")]
		public IVBENHNIIJR(Option<bool> isTrialInvention, Func<bool> a, Func<bool> b, Action? onCreateKeyClick, MultiValueConfigProperty<Guid> equipLockKeyId, Action<RNLDKFFPJOS.RoomKeyPickerData> c, [Optional] string? lockLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x99BE2C0", Offset = "0x99BD0C0", VA = "0x1899BE2C0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class KRNKJSZFEBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public readonly IReadOnlyList<(Guid, string)> WKQILIXNGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public readonly ConfigProperty<IReadOnlyCollection<Guid>> OPNSYIBLXMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public readonly Action<RNLDKFFPJOS.MultiTogglePickerData> RWUVWKPWEQM;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x99C19A0", Offset = "0x99C07A0", VA = "0x1899C19A0")]
		public KRNKJSZFEBQ(IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<RNLDKFFPJOS.MultiTogglePickerData> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class SEUEQXHTHLA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public SEUEQXHTHLA XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x99C51C0", Offset = "0x99C3FC0", VA = "0x1899C51C0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly MultiValueConfigProperty<int> ZSYZTYVPKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly MultiValueConfigProperty<int> QPYZXYDVMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly MultiValueConfigProperty<int> QPJFGDWDJZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly MultiValueConfigProperty<int> QPOMDKQATLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly MultiValueConfigProperty<string> KMSXBRJVZGJ;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x99CD370", Offset = "0x99CC170", VA = "0x1899CD370")]
		public SEUEQXHTHLA(MultiValueConfigProperty<int> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<int> d, MultiValueConfigProperty<string> stateName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x99CD230", Offset = "0x99CC030", VA = "0x1899CD230", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class LPAPHYSWORH : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public LPAPHYSWORH XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x99C99F0", Offset = "0x99C87F0", VA = "0x1899C99F0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly MultiValueConfigProperty<float> BMXGBUGUSSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly MultiValueConfigProperty<bool> ZKIWXCLDWOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly MultiValueConfigProperty<TexturedQuadMaterialType> FCZHNZCFKBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly CULQQUABIKW? KCAVQRWSFTV;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly IReadOnlyList<TexturedQuadMaterialType> VVEANRIDFYG;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x99C2520", Offset = "0x99C1320", VA = "0x1899C2520")]
		public LPAPHYSWORH(MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<TexturedQuadMaterialType> c, CULQQUABIKW? syncComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x99C2250", Offset = "0x99C1050", VA = "0x1899C2250", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class TQNYWDPNTOA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public TQNYWDPNTOA XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x99B9C60", Offset = "0x99B8A60", VA = "0x1899B9C60")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly MultiValueConfigProperty<bool> HRVVLSKEXQQ;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public TQNYWDPNTOA(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x99CE890", Offset = "0x99CD690", VA = "0x1899CE890", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class EMISPGWAOTO : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class BVQANBPWYUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public EMISPGWAOTO XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x99B4BA0", Offset = "0x99B39A0", VA = "0x1899B4BA0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static readonly IReadOnlyDictionary<TrailWidthCurveTypes, string> CZAQWIXLXAF;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly IReadOnlyDictionary<TrailGradientTypes, string> MCVKWMSNLSP;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private static readonly IReadOnlyDictionary<TrailMaterialTypes, string> UYVFBGMIBRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly MultiValueConfigProperty<bool> OUNVSBAAUDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly MultiValueConfigProperty<bool> NTKOJUKLZPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly MultiValueConfigProperty<float> HLNEQHBKQZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly MultiValueConfigProperty<float> VVEJGIODEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly MultiValueConfigProperty<float> LRKBLOWEHLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly MultiValueConfigProperty<float> EBBNVDXCBRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly MultiValueConfigProperty<TrailWidthCurveTypes> KKHGWVAEEXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly MultiValueConfigProperty<TrailGradientTypes> PACYZVSAIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly MultiValueConfigProperty<TrailMaterialTypes> BTGQWJWLAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly PFEJMQKPUYZ? AAJYNXRQUDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CULQQUABIKW AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x99B66E0", Offset = "0x99B54E0", VA = "0x1899B66E0")]
		public EMISPGWAOTO(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<TrailWidthCurveTypes> g, MultiValueConfigProperty<TrailGradientTypes> h, MultiValueConfigProperty<TrailMaterialTypes> i, PFEJMQKPUYZ? colorableOptions, CULQQUABIKW syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x99B6160", Offset = "0x99B4F60", VA = "0x1899B6160", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class AFZMUVEFJBH : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class PIAOBGEZDVH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AFZMUVEFJBH XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public (Color32 x, Color32 y, Color32 z) JZFCJWZNIFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Func<bool> EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Func<bool> EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Action EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Action EPVAUNZHLTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PIAOBGEZDVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x99C7B70", Offset = "0x99C6970", VA = "0x1899C7B70")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x99C72C0", Offset = "0x99C60C0", VA = "0x1899C72C0")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x99C6830", Offset = "0x99C5630", VA = "0x1899C6830")]
			internal bool JGVABCVHUCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x99C69E0", Offset = "0x99C57E0", VA = "0x1899C69E0")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x99C67F0", Offset = "0x99C55F0", VA = "0x1899C67F0")]
			internal bool JGPTDWBKKQW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x99C6870", Offset = "0x99C5670", VA = "0x1899C6870")]
			internal void JHAGYJPFDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x99C6350", Offset = "0x99C5150", VA = "0x1899C6350")]
			internal void JGKMGPHNBFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x99C61C0", Offset = "0x99C4FC0", VA = "0x1899C61C0")]
			internal void JGFFJINPRUE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly Func<bool>? FWQTOIZJWTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly Func<bool> ZQHXZNNAMUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly Func<bool> OJVQDJNAALQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly MultiValueConfigProperty<float> URFFOOWAUTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private readonly MultiValueConfigProperty<float> URKMLVPYEEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private readonly MultiValueConfigProperty<float> URPTJCJVNQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private readonly MultiValueConfigProperty<float> SBFJKKALNVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly MultiValueConfigProperty<float> SBACNDGOEJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly MultiValueConfigProperty<float> SAUVPWMQUYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly Func<bool> HRPWFTGSTJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly Func<bool> HPGJSFDSYKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly MultiValueConfigProperty<float> LKYPVSDFTCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly MultiValueConfigProperty<float> LKTIYLJIJQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly MultiValueConfigProperty<float> LLJDQFRALYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly MultiValueConfigProperty<float> AFPSKJYWIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly MultiValueConfigProperty<float> AFUZHQSTRVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly MultiValueConfigProperty<float> AFFEPWLBPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Func<bool> MIGCSPIVSPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Func<bool> SZJGKPACYFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly MultiValueConfigProperty<float> VEJFXGNSSAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly MultiValueConfigProperty<float> VEDYZZTVIOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly MultiValueConfigProperty<float> VETTRUBNKWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly MultiValueConfigProperty<float> VLFORICXUZF;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x99B3200", Offset = "0x99B2000", VA = "0x1899B3200")]
		public AFZMUVEFJBH(Func<bool> supportsTranslation, Func<bool> isWorldPositionVisible, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, Func<bool> supportsRotation, Func<bool> isWorldRotationVisible, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j, MultiValueConfigProperty<float> k, MultiValueConfigProperty<float> l, Func<bool> supportsScaling, Func<bool> supportsDeformation, MultiValueConfigProperty<float> m, MultiValueConfigProperty<float> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, [Optional] Func<bool>? isFoldoutVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x99B3050", Offset = "0x99B1E50", VA = "0x1899B3050", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class KUPNHJNPABM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public KUPNHJNPABM XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x99C0F10", Offset = "0x99BFD10", VA = "0x1899C0F10")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static readonly IReadOnlyDictionary<GrabberAttachmentMode, string> SSVEBNUDRHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly MultiValueConfigProperty<GrabberAttachmentMode> EDRWSJEIANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private readonly MultiValueConfigProperty<bool> NKLISOECJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private readonly CULQQUABIKW AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x99C1C70", Offset = "0x99C0A70", VA = "0x1899C1C70")]
		public KUPNHJNPABM(MultiValueConfigProperty<GrabberAttachmentMode> a, MultiValueConfigProperty<bool> b, CULQQUABIKW syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x99C1A20", Offset = "0x99C0820", VA = "0x1899C1A20", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class IEVWBSBCDVQ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly IEnumerable<KCXADTAQTGO> SYQHUGMLPCA;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public IEVWBSBCDVQ(IEnumerable<KCXADTAQTGO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x99BDBC0", Offset = "0x99BC9C0", VA = "0x1899BDBC0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class ZSSVWLIVGJR : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public ZSSVWLIVGJR XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x99C58C0", Offset = "0x99C46C0", VA = "0x1899C58C0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x99C4DE0", Offset = "0x99C3BE0", VA = "0x1899C4DE0")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x99C4B70", Offset = "0x99C3970", VA = "0x1899C4B70")]
			internal void JHFNVQJCMYX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public readonly Option<bool> PFWIICTBQJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private readonly MultiValueConfigProperty<float> WLSBYIWREQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private readonly MultiValueConfigProperty<bool> GVYXVATLBVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private readonly MultiValueConfigProperty<bool> JXKDDIUNBEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly MultiValueConfigProperty<bool> GGGESGRMUGI;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x99D4270", Offset = "0x99D3070", VA = "0x1899D4270")]
		public ZSSVWLIVGJR(Option<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x99D4050", Offset = "0x99D2E50", VA = "0x1899D4050", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class FNFRWWXZXPA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public FNFRWWXZXPA XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x99CA130", Offset = "0x99C8F30", VA = "0x1899CA130")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static readonly Dictionary<int, string> DPAEOJQLMQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly MultiValueConfigProperty<int> QJUIALNEBNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private readonly MultiValueConfigProperty<float> WWUTWUNFLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private readonly MultiValueConfigProperty<bool> EHASFZHIMQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly MultiValueConfigProperty<bool> AXTEXCCIDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly MultiValueConfigProperty<bool> BOTWLPQVILT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly MultiValueConfigProperty<int> PYOJCWOETUJ;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x99B9540", Offset = "0x99B8340", VA = "0x1899B9540")]
		public FNFRWWXZXPA(MultiValueConfigProperty<int> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x99B9310", Offset = "0x99B8110", VA = "0x1899B9310", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class BNGSFRSVONV : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public BNGSFRSVONV XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x99D02A0", Offset = "0x99CF0A0", VA = "0x1899D02A0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x99CF570", Offset = "0x99CE370", VA = "0x1899CF570")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly Dictionary<int, string> DPAEOJQLMQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly Action? JIWGDROSPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly int ODKBUULOBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly MultiValueConfigProperty<int> QJUIALNEBNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly MultiValueConfigProperty<float> ARUGAVQOYTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private readonly MultiValueConfigProperty<bool> CIILECCTUQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly MultiValueConfigProperty<bool> BOTWLPQVILT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly MultiValueConfigProperty<int> PYOJCWOETUJ;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x99B3EC0", Offset = "0x99B2CC0", VA = "0x1899B3EC0")]
		public BNGSFRSVONV(Action? openAnimationControls, int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C90", Offset = "0x99B2A90", VA = "0x1899B3C90", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class JUSFVEQQHFG : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public JUSFVEQQHFG XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x99BA770", Offset = "0x99B9570", VA = "0x1899BA770")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x99BA110", Offset = "0x99B8F10", VA = "0x1899BA110")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly ZSSVWLIVGJR EYBDUAQRCUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly MultiValueConfigProperty<float> OZCSBVCLYLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private readonly Option<UnityEngine.Vector2> DBNUPVTWFNG;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x99BFF60", Offset = "0x99BED60", VA = "0x1899BFF60")]
		public JUSFVEQQHFG(ZSSVWLIVGJR acceleratedMovementOptions, MultiValueConfigProperty<float> a, Option<UnityEngine.Vector2> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x99BFE20", Offset = "0x99BEC20", VA = "0x1899BFE20", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class IKHSPFPFKWA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public IKHSPFPFKWA XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x99CAF00", Offset = "0x99C9D00", VA = "0x1899CAF00")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x99C9410", Offset = "0x99C8210", VA = "0x1899C9410")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x99C9130", Offset = "0x99C7F30", VA = "0x1899C9130")]
			internal void JHFNVQJCMYX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private readonly ZSSVWLIVGJR EYBDUAQRCUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly MultiValueConfigProperty<float> OZCSBVCLYLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private readonly MultiValueConfigProperty<float> GTYFMSCSHSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private readonly MultiValueConfigProperty<float> XJTZHYJPBET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private readonly MultiValueConfigProperty<float> DZGVFEVRABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private readonly Option<UnityEngine.Vector2> DBNUPVTWFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private readonly Option<float> MPAHVXVQUSX;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x99BDF50", Offset = "0x99BCD50", VA = "0x1899BDF50")]
		public IKHSPFPFKWA(ZSSVWLIVGJR acceleratedMovementOptions, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, Option<UnityEngine.Vector2> c, MultiValueConfigProperty<float> d, Option<float> e, MultiValueConfigProperty<float> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x99BDE10", Offset = "0x99BCC10", VA = "0x1899BDE10", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class BZHTWKSYDXA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public BZHTWKSYDXA XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x99B99F0", Offset = "0x99B87F0", VA = "0x1899B99F0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private readonly ZSSVWLIVGJR EYBDUAQRCUF;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public BZHTWKSYDXA(ZSSVWLIVGJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x99B5B90", Offset = "0x99B4990", VA = "0x1899B5B90", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class RVVAOQRWFDY : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public RVVAOQRWFDY XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x99C5BA0", Offset = "0x99C49A0", VA = "0x1899C5BA0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly Option<float> GWTYIMQROWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private readonly MultiValueConfigProperty<float> WHSQAFDDPNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private readonly MultiValueConfigProperty<float> TKHZBDEGOPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private readonly MultiValueConfigProperty<float> RKNSAXQULLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private readonly ZSSVWLIVGJR EYBDUAQRCUF;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x99CD000", Offset = "0x99CBE00", VA = "0x1899CD000")]
		public RVVAOQRWFDY(Option<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ZSSVWLIVGJR acceleratedMovementOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x99CCEA0", Offset = "0x99CBCA0", VA = "0x1899CCEA0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class MJNULHYTHVV : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class BEKRWCFQTJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public MJNULHYTHVV XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BEKRWCFQTJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x99B37A0", Offset = "0x99B25A0", VA = "0x1899B37A0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly Dictionary<GlassPaneShapeType, string> HTDNPJHAOFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private readonly MultiValueConfigProperty<float> VZWAEJXUOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly Func<bool> NRAEIAKVQID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly MultiValueConfigProperty<GlassPaneShapeType> PTYYWLNSFUO;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x99C35C0", Offset = "0x99C23C0", VA = "0x1899C35C0")]
		public MJNULHYTHVV(MultiValueConfigProperty<float> a, Func<bool> isAllConfigurableShapes, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x99C3390", Offset = "0x99C2190", VA = "0x1899C3390", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class MYJWFVNRAXV : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public MYJWFVNRAXV XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x99BA050", Offset = "0x99B8E50", VA = "0x1899BA050")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private readonly ZSHNODKQKJY ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public MYJWFVNRAXV(ZSHNODKQKJY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x99C3820", Offset = "0x99C2620", VA = "0x1899C3820", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class OPTELMOIJPS
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public static readonly IReadOnlyDictionary<InteractionFilterMode, string> BMJZVNKSZMZ;
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class FNTHXCHJVAW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public FNTHXCHJVAW XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x99C0810", Offset = "0x99BF610", VA = "0x1899C0810")]
			internal bool FNJUSOEYQOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x99C0A80", Offset = "0x99BF880", VA = "0x1899C0A80")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x99C0940", Offset = "0x99BF740", VA = "0x1899C0940")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x99C0880", Offset = "0x99BF680", VA = "0x1899C0880")]
			internal void JHAGYJPFDNO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private readonly MultiValueConfigProperty<bool> RZJPGYRTTGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> SSLVJJDWDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private readonly KRNKJSZFEBQ? OBDWCRZDNXA;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x99B9960", Offset = "0x99B8760", VA = "0x1899B9960")]
		public FNTHXCHJVAW(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<InteractionFilterMode> c, KRNKJSZFEBQ? rolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x99B9640", Offset = "0x99B8440", VA = "0x1899B9640", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class WEOXILCCLGF : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public WEOXILCCLGF XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x99C07A0", Offset = "0x99BF5A0", VA = "0x1899C07A0")]
			internal bool FNJUSOEYQOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x99C0BC0", Offset = "0x99BF9C0", VA = "0x1899C0BC0")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private readonly string PGJSTNBIOKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private readonly MultiValueConfigProperty<bool> RZJPGYRTTGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> SSLVJJDWDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private readonly IYYXSZTVWSI? NNDTNOICTCK;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x99D3470", Offset = "0x99D2270", VA = "0x1899D3470")]
		public WEOXILCCLGF(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<InteractionFilterMode> b, IYYXSZTVWSI tagsOptions, string primaryLabel = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x99D30E0", Offset = "0x99D1EE0", VA = "0x1899D30E0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class WAHJDTFWNLG : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public WAHJDTFWNLG XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x99BA710", Offset = "0x99B9510", VA = "0x1899BA710")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private readonly string PGJSTNBIOKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> SSLVJJDWDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private readonly IYYXSZTVWSI? NNDTNOICTCK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x99D3060", Offset = "0x99D1E60", VA = "0x1899D3060")]
		public WAHJDTFWNLG(MultiValueConfigProperty<InteractionFilterMode> filterMode, IYYXSZTVWSI a, string b = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x99D2E00", Offset = "0x99D1C00", VA = "0x1899D2E00", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface RNLDKFFPJOS
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
				[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0xF1F730", Offset = "0xF1E530", VA = "0x180F1F730")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Action<int> ColorSetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool AllowCustomColors
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF90", Offset = "0xCEED90", VA = "0x180CEFF90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public bool AllowDefaultColor
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x1251680", Offset = "0x1250480", VA = "0x181251680")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x13C87D0", Offset = "0x13C75D0", VA = "0x1813C87D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public Func<int> MaterialGetter
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xF1F730", Offset = "0xF1E530", VA = "0x180F1F730")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public Action<int> MaterialSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool AllowDefaultMaterial
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xCE7950", Offset = "0xCE6750", VA = "0x180CE7950")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0xCE8250", Offset = "0xCE7050", VA = "0x180CE8250")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool ForceTransparentQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x15E9A40", Offset = "0x15E8840", VA = "0x1815E9A40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x15E8D50", Offset = "0x15E7B50", VA = "0x1815E8D50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool CameraLit
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x1B99A70", Offset = "0x1B98870", VA = "0x181B99A70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6130", Offset = "0x1DF4F30", VA = "0x181DF6130")]
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
				[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Action<Guid> RoleSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0xF1F730", Offset = "0xF1E530", VA = "0x180F1F730")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public Func<Guid> KeyGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0xF1F730", Offset = "0xF1E530", VA = "0x180F1F730")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public Action<Guid> KeySetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public Func<IReadOnlyCollection<int>> GetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0xF1F730", Offset = "0xF1E530", VA = "0x180F1F730")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public Action<IReadOnlyCollection<int>> SetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Func<IReadOnlyList<string>> GetValueNames
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class ORIQTMWZRCZ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public IReadOnlyDictionary<a, string> RHUPLBBJJNF;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ORIQTMWZRCZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x729DF50", Offset = "0x729CD50", VA = "0x18729DF50")]
			internal string VTPLKFRSUAM(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class YJRSFDZZSJM<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			public Func<a, string> ZPCCKLVUPGK;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YJRSFDZZSJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x509ECC0", Offset = "0x509DAC0", VA = "0x18509ECC0")]
			internal string VTPLKFRSUAM(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class YGNJGVHAJNB<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public IReadOnlyList<(a, string)> RHUPLBBJJNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Dictionary<a, int> HANPCHFHCJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Func<a, int> EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Func<int, a> EPVAUNZHLTH;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YGNJGVHAJNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x509B8D0", Offset = "0x509A6D0", VA = "0x18509B8D0")]
			internal IReadOnlyList<string> QOGZMDAVSKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x509B620", Offset = "0x509A420", VA = "0x18509B620")]
			internal IReadOnlyCollection<int> QOBSOWGYIZC(IReadOnlyCollection<a> values)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x509B340", Offset = "0x509A140", VA = "0x18509B340")]
			internal int QNLXXBZGGRB(a a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x509B470", Offset = "0x509A270", VA = "0x18509B470")]
			internal IReadOnlyCollection<a> QNWLRPNAZNT(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x509B180", Offset = "0x5099F80", VA = "0x18509B180")]
			internal a QNGQZVFIXFS(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class NRXDWRITMNV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public IReadOnlyList<(int, string)> RHUPLBBJJNF;

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public NRXDWRITMNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x99C3E70", Offset = "0x99C2C70", VA = "0x1899C3E70")]
			internal IReadOnlyList<string> FDWQKALCKAR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x99C3C80", Offset = "0x99C2A80", VA = "0x1899C3C80")]
			internal IReadOnlyCollection<int> FDRJMTRFAPI(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x99C3FA0", Offset = "0x99C2DA0", VA = "0x1899C3FA0")]
			internal int FEHEENYXCXJ(IReadOnlyCollection<int> a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class NRRWZKOWDCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public int JTBPWUDBHYM;

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public NRRWZKOWDCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x99C3C70", Offset = "0x99C2A70", VA = "0x1899C3C70")]
			internal bool FERRZBMRVUB(IndexValuePair<(int, string)> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class NSHRREWOFKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public int JTBPWUDBHYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public NRXDWRITMNV DODNVPQZHNM;

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public NSHRREWOFKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x99C4080", Offset = "0x99C2E80", VA = "0x1899C4080")]
			internal void FFCFTPAMOQT(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class IYQMCZATMGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public IReadOnlyList<(Guid, string)> RHUPLBBJJNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public Dictionary<Guid, int> HANPCHFHCJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public Func<Guid, int> EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public Func<int, Guid> EPVAUNZHLTH;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public IYQMCZATMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x99BE6E0", Offset = "0x99BD4E0", VA = "0x1899BE6E0")]
			internal IReadOnlyList<string> BZSIFFBNFHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x99BE610", Offset = "0x99BD410", VA = "0x1899BE610")]
			internal IReadOnlyCollection<int> BZNBHYHPVVY(IReadOnlyCollection<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x99BE9B0", Offset = "0x99BD7B0", VA = "0x1899BE9B0")]
			internal int CANJUGDCRAR(Guid a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x99BE810", Offset = "0x99BD610", VA = "0x1899BE810")]
			internal IReadOnlyCollection<Guid> CACVZSPHYDZ(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x99BE8E0", Offset = "0x99BD6E0", VA = "0x1899BE8E0")]
			internal Guid CAICWZJFHPI(int a)
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x99CCC00", Offset = "0x99CBA00", VA = "0x1899CCC00", Slot = "0")]
		RNLDKFFPJOS MACHBPDFVSX(bool a, Action b, [Optional] Action? falseAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x99CBF00", Offset = "0x99CAD00", VA = "0x1899CBF00", Slot = "1")]
		RNLDKFFPJOS Add(ZSHNODKQKJY? provider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RNLDKFFPJOS RDQFZIYMBFI();

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RNLDKFFPJOS JAAKLNYLQAJ(string a, int b, Action c, [Optional] Func<bool>? isVisibleGetter, bool d = true, InventionPermission e = InventionPermission.EditAndSave, string f = "");

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RNLDKFFPJOS? XLDEVBXDOJO(string primaryLabel, MultiValueConfigProperty<string> property, int a = 1000, [Optional] string? b, [Optional] Func<bool>? c, ContentType d = ContentType.Standard, [Optional] string? e);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RNLDKFFPJOS TCMOUFZHKOZ(string a, MultiValueConfigProperty<string> property, int b = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] string? infoText);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RNLDKFFPJOS NDJWHOFZQAP(string a, MultiValueConfigProperty<int> property, [Optional] int? b, [Optional] int? c, [Optional] string? unitLabel, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		RNLDKFFPJOS? HMGTRPVBKZN(string primaryLabel, float a, float b, MultiValueConfigProperty<float> property, int c = 2, [Optional] string? d, [Optional] string? e, [Optional] Func<bool>? f, [Optional] string? g);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RNLDKFFPJOS? JWHCJMAZASS(string primaryLabel, MultiValueConfigProperty<float> property, [Optional] Func<bool>? a, [Optional] Func<bool>? b, [Optional] Color? c, [Optional] float? d, [Optional] float? e, bool f = false, [Optional] string? g, [Optional] string? h);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x99CC3A0", Offset = "0x99CB1A0", VA = "0x1899CC3A0", Slot = "9")]
		RNLDKFFPJOS IHDZXFXXTIN(string primaryLabel, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, [Optional] (Color x, Color y, Color z)? bgColors, [Optional] Func<bool>? isVisibleGetter, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RNLDKFFPJOS? MELWEAXSPAE(string primaryLabel, Func<bool> isActiveGetter, Action<bool> isActiveSetter, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e, [Optional] Func<bool>? f, [Optional] Func<string>? warningTextGetter, [Optional] Func<string>? warningTitleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "11")]
		RNLDKFFPJOS? WLTEERAYIVK(string primaryLabel, MultiValueConfigProperty<bool> property, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E36E20", Offset = "0x3E35C20", VA = "0x183E36E20", Slot = "12")]
		RNLDKFFPJOS POWGDBBMZRP<a>(string a, MultiValueConfigProperty<a> property, IReadOnlyDictionary<a, string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool c = true, bool d = false) where a : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3E37160", Offset = "0x3E35F60", VA = "0x183E37160", Slot = "13")]
		RNLDKFFPJOS POWGDBBMZRP<b>(string a, MultiValueConfigProperty<b> property, IReadOnlyList<b> b, Func<b, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false) where b : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "14")]
		RNLDKFFPJOS POWGDBBMZRP(string a, MultiValueConfigProperty<object> property, IReadOnlyList<object> b, Func<object, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "15")]
		RNLDKFFPJOS? FQJUTWFCEHS(Action panelAction, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "16")]
		RNLDKFFPJOS HXPRXVCQIQY(string a, ConfigProperty<IReadOnlyList<string>> persistentProperty, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeProperty, [Optional] string? secondaryLabel, [Optional] Func<string, bool>? tagValidator, int b = 1000, [Optional] Func<bool>? isModifiedGetter);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "17")]
		RNLDKFFPJOS? GCAHUMCAFZW(string primaryLabel, Action? a, [Optional] Func<bool>? b, [Optional] Func<bool>? c);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "18")]
		RNLDKFFPJOS ZGOFJQDKQBP(string a, string b, Action c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "19")]
		RNLDKFFPJOS PMTVOCZYZYZ(string a, ConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "20")]
		RNLDKFFPJOS PMTVOCZYZYZ(string a, MultiValueConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		RNLDKFFPJOS YKWXINLDLTJ(string a, ConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		RNLDKFFPJOS YKWXINLDLTJ(string a, MultiValueConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		RNLDKFFPJOS CUULVVSKLWV(string a, ConfigProperty<Guid> property, Action<RoomRolePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		RNLDKFFPJOS VIRQACEDUEY(string a, MultiValueConfigProperty<Guid> property, Action<RoomKeyPickerData> b, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RNLDKFFPJOS KNYRCXQLFGX(string a, Func<IReadOnlyList<string>> b, ConfigProperty<IReadOnlyCollection<int>> property, Action<MultiTogglePickerData> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3E36460", Offset = "0x3E35260", VA = "0x183E36460", Slot = "26")]
		RNLDKFFPJOS KNYRCXQLFGX<T>(string a, IReadOnlyList<(T, string)> items, ConfigProperty<IReadOnlyCollection<T>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x99CC830", Offset = "0x99CB630", VA = "0x1899CC830", Slot = "27")]
		RNLDKFFPJOS LJXEGWCGCSR(string a, IReadOnlyList<(int, string)> items, ConfigProperty<int> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x99CBFB0", Offset = "0x99CADB0", VA = "0x1899CBFB0", Slot = "28")]
		RNLDKFFPJOS CUULVVSKLWV(string a, IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "29")]
		RNLDKFFPJOS FVVOPGJEPUE(string a, [Optional] Func<bool>? isVisibleGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public interface ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RLQQDTULWNZ(RNLDKFFPJOS a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class VJVWBLFUHFB : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public VJVWBLFUHFB XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x99C9F50", Offset = "0x99C8D50", VA = "0x1899C9F50")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly MultiValueConfigProperty<float> MLAIWDJINPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly System.Numerics.Vector2 UQVCNCZZDQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private readonly MultiValueConfigProperty<float> QCGOMVPSIWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly System.Numerics.Vector2 ICUTEBYRIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly HYFPXTPJRUF RQHSRJRWDPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly PFEJMQKPUYZ? MRYKPDZBGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CULQQUABIKW LLQJQYRGIPW;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x99D20B0", Offset = "0x99D0EB0", VA = "0x1899D20B0")]
		public VJVWBLFUHFB(MultiValueConfigProperty<float> a, System.Numerics.Vector2 b, MultiValueConfigProperty<float> c, System.Numerics.Vector2 d, HYFPXTPJRUF sandboxDynamicLightOptions, PFEJMQKPUYZ? sandboxColorableConfig, CULQQUABIKW syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x99D1F70", Offset = "0x99D0D70", VA = "0x1899D1F70", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class ZFBLLOPPVJL : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public ZFBLLOPPVJL XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x99B9C00", Offset = "0x99B8A00", VA = "0x1899B9C00")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly HYFPXTPJRUF ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public ZFBLLOPPVJL(HYFPXTPJRUF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x99D3F10", Offset = "0x99D2D10", VA = "0x1899D3F10", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class HYFPXTPJRUF : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private readonly MultiValueConfigProperty<bool> XGRNLGRDTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private readonly MultiValueConfigProperty<float> SGYUEHCMMXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly System.Numerics.Vector2 RRQBFSGMBFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private readonly MultiValueConfigProperty<float> MMUBLVRRLZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private readonly System.Numerics.Vector2 SJIXRKXKUBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private readonly MultiValueConfigProperty<float> NKKOPVPRWNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private readonly System.Numerics.Vector2 DPIAUQKFAAC;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x99BCD10", Offset = "0x99BBB10", VA = "0x1899BCD10")]
		public HYFPXTPJRUF(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<float> d, System.Numerics.Vector2 e, MultiValueConfigProperty<float> f, System.Numerics.Vector2 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x99BC990", Offset = "0x99BB790", VA = "0x1899BC990", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x99BC960", Offset = "0x99BB760", VA = "0x1899BC960")]
		[CompilerGenerated]
		private bool ERBHKPRSIVY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x99BC970", Offset = "0x99BB770", VA = "0x1899BC970")]
		[CompilerGenerated]
		private bool ERGOHWLPSHH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class LNBELDSCUHG : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public LNBELDSCUHG XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x99BA880", Offset = "0x99B9680", VA = "0x1899BA880")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private readonly HYFPXTPJRUF BMNMQDJQPZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly PFEJMQKPUYZ? AAJYNXRQUDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private readonly CULQQUABIKW AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xDB85D0", Offset = "0xDB73D0", VA = "0x180DB85D0")]
		public LNBELDSCUHG(HYFPXTPJRUF a, PFEJMQKPUYZ? colorableOptions, CULQQUABIKW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x99C2110", Offset = "0x99C0F10", VA = "0x1899C2110", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class XBSUTIYEFCK : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public XBSUTIYEFCK XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x99B9BA0", Offset = "0x99B89A0", VA = "0x1899B9BA0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private readonly XDCHGNXIJKE ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public XBSUTIYEFCK(XDCHGNXIJKE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x99D36C0", Offset = "0x99D24C0", VA = "0x1899D36C0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class XDCHGNXIJKE : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private readonly MultiValueConfigProperty<float> MLAIWDJINPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private readonly System.Numerics.Vector2 UQVCNCZZDQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private readonly HYFPXTPJRUF BMNMQDJQPZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private readonly PFEJMQKPUYZ? AAJYNXRQUDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private readonly CULQQUABIKW? AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x99D3BD0", Offset = "0x99D29D0", VA = "0x1899D3BD0")]
		public XDCHGNXIJKE(MultiValueConfigProperty<float> angle, System.Numerics.Vector2 a, HYFPXTPJRUF dynamicLightOptions, PFEJMQKPUYZ? b, CULQQUABIKW? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x99D3AA0", Offset = "0x99D28A0", VA = "0x1899D3AA0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class IVDNKAGHYHL : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public IVDNKAGHYHL XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x99C0180", Offset = "0x99BEF80", VA = "0x1899C0180")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private readonly XDCHGNXIJKE BMNMQDJQPZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly BNSEWWVYFNS UFHGBJRZWWN;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		public IVDNKAGHYHL(XDCHGNXIJKE a, BNSEWWVYFNS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x99BE4D0", Offset = "0x99BD2D0", VA = "0x1899BE4D0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class URZRSVMYHWI : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public URZRSVMYHWI XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x99C05A0", Offset = "0x99BF3A0", VA = "0x1899C05A0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private MultiValueConfigProperty<float> YNUSLWVIHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private Dictionary<float, string> WUZVVMCAOQV;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x99BE260", Offset = "0x99BD060", VA = "0x1899BE260")]
		public URZRSVMYHWI(MultiValueConfigProperty<float> a, Dictionary<float, string> labelMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x99D1040", Offset = "0x99CFE40", VA = "0x1899D1040", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class UVXGCYSSHGQ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public sealed class BBEVJPPUPMC
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public string CTZDLOJAEUK
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public bool[] TYRAOUNKKZI
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int PQNHELFYRGN
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xD3E0B0", Offset = "0xD3CEB0", VA = "0x180D3E0B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float WMGEWRHVLPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xD3D220", Offset = "0xD3C020", VA = "0x180D3D220")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0xD3D210", Offset = "0xD3C010", VA = "0x180D3D210")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int CRWLHSKOIBS
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0xCE8C40", Offset = "0xCE7A40", VA = "0x180CE8C40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BBEVJPPUPMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public sealed class YSQWFXCKXKJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public string CTZDLOJAEUK
			{
				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public ConfigProperty<int> RSXWRZLXIIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400")]
				[CompilerGenerated]
				get
				{
					return default(ConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x5131070", Offset = "0x512FE70", VA = "0x185131070")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public MultiValueConfigProperty<int> FXJADZEOZOL
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2E10090", Offset = "0x2E0EE90", VA = "0x182E10090")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x99D3EF0", Offset = "0x99D2CF0", VA = "0x1899D3EF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public MultiValueConfigProperty<float> UPRTWCVGHDR
			{
				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2E105B0", Offset = "0x2E0F3B0", VA = "0x182E105B0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x99D3ED0", Offset = "0x99D2CD0", VA = "0x1899D3ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public MultiValueConfigProperty<float> OJSIZHWONPF
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x6EBD880", Offset = "0x6EBC680", VA = "0x186EBD880")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x6EBD960", Offset = "0x6EBC760", VA = "0x186EBD960")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YSQWFXCKXKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public UVXGCYSSHGQ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int AEFNCPMWIYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x99C8F50", Offset = "0x99C7D50", VA = "0x1899C8F50")]
			internal void JHAGYJPFDNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class QNQXZGPPPRK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			public int ALPNKJZOFUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public QNWEWNJMZCT DODNVPQZHNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public Func<BBEVJPPUPMC, bool> EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public Func<int, int> EPVAUNZHLTH;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNQXZGPPPRK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x99E21D0", Offset = "0x99E0FD0", VA = "0x1899E21D0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x99E2190", Offset = "0x99E0F90", VA = "0x1899E2190")]
			internal bool JGVABCVHUCF(BBEVJPPUPMC a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x99E1FE0", Offset = "0x99E0DE0", VA = "0x1899E1FE0")]
			internal int JGFFJINPRUE(int a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class QOGSRAXHRZL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public int AEAGFISYZNH;

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QOGSRAXHRZL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x99E45F0", Offset = "0x99E33F0", VA = "0x1899E45F0")]
			internal bool JFZYMBTSIIV(BBEVJPPUPMC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> TLOBIDSWRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private readonly IReadOnlyList<YSQWFXCKXKJ> JSQCUCZFHBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private readonly IReadOnlyList<BBEVJPPUPMC> NVBULYLXSMH;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8753AF0", Offset = "0x87528F0", VA = "0x188753AF0")]
		public UVXGCYSSHGQ(int a, Action<RNLDKFFPJOS.ColorPickerData> b, IReadOnlyList<YSQWFXCKXKJ> c, IReadOnlyList<BBEVJPPUPMC> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x99D1C70", Offset = "0x99D0A70", VA = "0x1899D1C70", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class KBMRRZUUTIN : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class SIXMNEQISOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public KBMRRZUUTIN XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SIXMNEQISOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x99E5500", Offset = "0x99E4300", VA = "0x1899E5500")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x99E53D0", Offset = "0x99E41D0", VA = "0x1899E53D0")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private readonly ConfigProperty<int> BVALNGPHNSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> TLOBIDSWRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private readonly MultiValueConfigProperty<float> SGYUEHCMMXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private readonly MultiValueConfigProperty<float> ZBVCDBAQXJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private readonly MultiValueConfigProperty<float> GRRPKKASJEA;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x99DD0B0", Offset = "0x99DBEB0", VA = "0x1899DD0B0")]
		public KBMRRZUUTIN(int a, ConfigProperty<int> b, Action<RNLDKFFPJOS.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x99DCF70", Offset = "0x99DBD70", VA = "0x1899DCF70", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class FLULZSISQSZ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class LMHYOZGZEPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public FLULZSISQSZ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Action ERVRTDQHCCT;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public LMHYOZGZEPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x99DF260", Offset = "0x99DE060", VA = "0x1899DF260")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x99DF130", Offset = "0x99DDF30", VA = "0x1899DF130")]
			internal void JFUROUZUYXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly System.Numerics.Vector2 YIQXTWUDVBN;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly System.Numerics.Vector2 HQNVJASSHAR;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static System.Numerics.Vector2 NQDMXDJVWOO;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static System.Numerics.Vector2 HCCHDYWBKSK;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static System.Numerics.Vector2 HLYQUVOYOWD;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static System.Numerics.Vector2 JCNYGHGXUVX;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static System.Numerics.Vector2 IQWZCAMJOTZ;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static System.Numerics.Vector2 KNDRTDZWVNL;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static System.Numerics.Vector2 QSWODMZGQBH;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static System.Numerics.Vector2 FWIFRWBXDPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private readonly ConfigProperty<int> BVALNGPHNSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> TLOBIDSWRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private readonly MultiValueConfigProperty<float> LLCBQDNTGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private readonly MultiValueConfigProperty<float> UTIHICIZBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private readonly MultiValueConfigProperty<float> EAUARPJZWOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private readonly MultiValueConfigProperty<float> MPWGTOETTMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private readonly MultiValueConfigProperty<float> QSDFVZCIYIX;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x99D7990", Offset = "0x99D6790", VA = "0x1899D7990")]
		public FLULZSISQSZ(int a, ConfigProperty<int> b, Action<RNLDKFFPJOS.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x99D74D0", Offset = "0x99D62D0", VA = "0x1899D74D0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x99D7610", Offset = "0x99D6410", VA = "0x1899D7610")]
		private static float UCQNZBAJEOR(float a, System.Numerics.Vector2 b, System.Numerics.Vector2 c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public sealed class JLPIGVQYICQ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public JLPIGVQYICQ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x99E16B0", Offset = "0x99E04B0", VA = "0x1899E16B0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x99E0D70", Offset = "0x99DFB70", VA = "0x1899E0D70")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private readonly ConfigProperty<int> BVALNGPHNSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> TLOBIDSWRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private readonly MultiValueConfigProperty<float> QSYLGAPWUBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private readonly MultiValueConfigProperty<float> QRWEJVDLKKE;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x99DCAB0", Offset = "0x99DB8B0", VA = "0x1899DCAB0")]
		public JLPIGVQYICQ(int a, ConfigProperty<int> b, Action<RNLDKFFPJOS.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x99DC970", Offset = "0x99DB770", VA = "0x1899DC970", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public sealed class LQJDQLYQNVJ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public LQJDQLYQNVJ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x99E39F0", Offset = "0x99E27F0", VA = "0x1899E39F0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x99E2E20", Offset = "0x99E1C20", VA = "0x1899E2E20")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private readonly MultiValueConfigProperty<int> PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private readonly MultiValueConfigProperty<float> HGAORYMPROK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private readonly MultiValueConfigProperty<float> FPTLFTPOMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private readonly MultiValueConfigProperty<bool> INNZNHFEOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private readonly ConfigProperty<Guid> TQTZFKHKZYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly Action<RNLDKFFPJOS.RoomRolePickerData> CSXACHDQANB;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x99E0690", Offset = "0x99DF490", VA = "0x1899E0690")]
		public LQJDQLYQNVJ(int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, ConfigProperty<Guid> f, Action<RNLDKFFPJOS.RoomRolePickerData> onExclusiveToRoleClick)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x99E0550", Offset = "0x99DF350", VA = "0x1899E0550", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class HREOLNZHCXC : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public HREOLNZHCXC XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x99DB440", Offset = "0x99DA240", VA = "0x1899DB440")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x99DAF40", Offset = "0x99D9D40", VA = "0x1899DAF40")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private readonly ConfigProperty<int> EQDGHITRFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private readonly ConfigProperty<int> NFQZSUEDEWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private readonly ConfigProperty<int> FDTIZEMJCJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private readonly ConfigProperty<int> AHUSWYNAHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private readonly ConfigProperty<int> QOMGPJPQLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> TLOBIDSWRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private readonly MultiValueConfigProperty<float> GVFCSIJSQUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private readonly MultiValueConfigProperty<float> BLYBWSQRVFH;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x99DC620", Offset = "0x99DB420", VA = "0x1899DC620")]
		public HREOLNZHCXC(int a, ConfigProperty<int> b, ConfigProperty<int> c, ConfigProperty<int> d, ConfigProperty<int> e, ConfigProperty<int> f, Action<RNLDKFFPJOS.ColorPickerData> onColorClick, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x99DC4E0", Offset = "0x99DB2E0", VA = "0x1899DC4E0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class SEAVCPPPRBU : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class CZCHTXMEYAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public SEAVCPPPRBU XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public CZCHTXMEYAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x99D5A80", Offset = "0x99D4880", VA = "0x1899D5A80")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x99D5950", Offset = "0x99D4750", VA = "0x1899D5950")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private readonly ConfigProperty<int> BVALNGPHNSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> TLOBIDSWRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private readonly MultiValueConfigProperty<float> RVVNUOZLALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private readonly MultiValueConfigProperty<float> YKTAWOPFQMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private readonly MultiValueConfigProperty<float> SKLWOYPXSSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private readonly MultiValueConfigProperty<float> MAUXGIVDZQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private readonly MultiValueConfigProperty<float> PTLLEGXOZYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private readonly MultiValueConfigProperty<float> TTUVRFSNUWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private readonly MultiValueConfigProperty<bool> HXXPOQQJSIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly MultiValueConfigProperty<bool> CQROWSTCFUT;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x99E4950", Offset = "0x99E3750", VA = "0x1899E4950")]
		public SEAVCPPPRBU(int a, ConfigProperty<int> b, Action<RNLDKFFPJOS.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x99E4810", Offset = "0x99E3610", VA = "0x1899E4810", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public readonly struct MultiValueConfigProperty<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class MSQXLDQVGPS<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public IEnumerable<b> NCNWWUUUSDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public Func<b, T> FEXNIZLJYQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public Action<b, T> QSLPCWOJQIC;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public MSQXLDQVGPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x6EEAB10", Offset = "0x6EE9910", VA = "0x186EEAB10")]
			internal Option<T> FJIECBLHFTR()
			{
				return default(Option<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9EF0", Offset = "0x6EE8CF0", VA = "0x186EE9EF0")]
			internal void FJCXEURJWII(T a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class VDCUMINIOMT<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public T AEAGFISYZNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public MSQXLDQVGPS<b> DODNVPQZHNM;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public VDCUMINIOMT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7E8FAE0", Offset = "0x7E8E8E0", VA = "0x187E8FAE0")]
			internal void FJSRWOZBYQJ(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class BAWJCOIJFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public MultiValueConfigProperty<T> XEZWAQIYXMQ;

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x4EAF350", Offset = "0x4EAE150", VA = "0x184EAF350")]
			internal Option<object> WVGRENCYFYQ()
			{
				return default(Option<object>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x4EAFB10", Offset = "0x4EAE910", VA = "0x184EAFB10")]
			internal void WVLYBTWVPJZ(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class HOKGFFVUDGP<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public Func<b, T> FEXNIZLJYQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public T KDBGGJVMMQN;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public HOKGFFVUDGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x6473890", Offset = "0x6472690", VA = "0x186473890")]
			internal bool OWRPFSLKVDI(b a)
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
		[Cpp2IlInjected.Address(RVA = "0x39EB3D0", Offset = "0x39EA1D0", VA = "0x1839EB3D0")]
		public static MultiValueConfigProperty<T> Create<U>(IEnumerable<U> objects, Func<U, T> getter, Action<U, T> setter, Func<bool>? isModified) where U : notnull
		{
			return default(MultiValueConfigProperty<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x71034D0", Offset = "0x71022D0", VA = "0x1871034D0")]
		public static implicit operator MultiValueConfigProperty<object>(MultiValueConfigProperty<T> prop)
		{
			return default(MultiValueConfigProperty<object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x39EC0B0", Offset = "0x39EAEB0", VA = "0x1839EC0B0")]
		private static Option<T> VKHVQYYWAZE<U>(IEnumerable<U> a, Func<U, T> b) where U : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1F2BCE0", Offset = "0x1F2AAE0", VA = "0x181F2BCE0")]
		internal MultiValueConfigProperty(Func<Option<T>> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class QNZHLKGJJMG
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[CompilerGenerated]
		private sealed class MTGSCXYNIXT<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public IEnumerable<a> NCNWWUUUSDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public Func<a, bool> AJTKRNJTTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public Func<a, bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public MTGSCXYNIXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x6EED390", Offset = "0x6EEC190", VA = "0x186EED390")]
			internal bool XYCCPZEWUFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x6EED260", Offset = "0x6EEC060", VA = "0x186EED260")]
			internal bool XXWVSSKZKTW(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class ITTXRCVCEBE<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public MultiValueConfigProperty<a> XEZWAQIYXMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public Func<a, b> VASIZTAIPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public Func<b, a> DWTJBFUWNYJ;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ITTXRCVCEBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6590280", Offset = "0x658F080", VA = "0x186590280")]
			internal Option<b> FTNKLEHFGRG()
			{
				return default(Option<b>);
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x6590540", Offset = "0x658F340", VA = "0x186590540")]
			internal void MTTPLCDXZQD(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class ZAGAZIDTYHU<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public ConfigProperty<a> XEZWAQIYXMQ;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZAGAZIDTYHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x50FA960", Offset = "0x50F9760", VA = "0x1850FA960")]
			internal Option<a> GGLBHVEJIRP()
			{
				return default(Option<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x12B3070", Offset = "0x12B1E70", VA = "0x1812B3070")]
			internal void RXCDLCKQVHA(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3E26FA0", Offset = "0x3E25DA0", VA = "0x183E26FA0")]
		public static MultiValueConfigProperty<U> ZOFIXWNLEVD<U, T>(this IEnumerable<T> a, Func<T, U> b, Action<T, U> c, [Optional] Func<T, bool>? isModified) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3E26720", Offset = "0x3E25520", VA = "0x183E26720")]
		public static MultiValueConfigProperty<U> To<U, T>(this MultiValueConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3E26BA0", Offset = "0x3E259A0", VA = "0x183E26BA0")]
		public static MultiValueConfigProperty<a?> ZOFIXWNLEVD<a>(this ConfigProperty<a> prop)
		{
			return default(MultiValueConfigProperty<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class BFQENGXTRFX : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public BFQENGXTRFX XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x99DE2E0", Offset = "0x99DD0E0", VA = "0x1899DE2E0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly IReadOnlyList<NavMeshGenerationMode> QHINUGVFYBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private readonly MultiValueConfigProperty<NavMeshGenerationMode> IZKWKBGFJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x99D4C40", Offset = "0x99D3A40", VA = "0x1899D4C40")]
		private static string CSLYEQWQMBA(NavMeshGenerationMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x99D4EC0", Offset = "0x99D3CC0", VA = "0x1899D4EC0")]
		public BFQENGXTRFX(MultiValueConfigProperty<NavMeshGenerationMode> a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x99D4CD0", Offset = "0x99D3AD0", VA = "0x1899D4CD0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class KJEFONYBFTO : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public KJEFONYBFTO XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x99D86F0", Offset = "0x99D74F0", VA = "0x1899D86F0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private readonly NJVBEOZDXHM ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public KJEFONYBFTO(NJVBEOZDXHM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x99DD810", Offset = "0x99DC610", VA = "0x1899DD810", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class NJVBEOZDXHM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private readonly Action LJGTYZJJZNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private readonly Func<bool> WMLQQQLSQJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private readonly Action NPTVCBIAILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private readonly Action UUICPOAUTVD;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1117370", Offset = "0x1116170", VA = "0x181117370")]
		public NJVBEOZDXHM(Action a, Func<bool> b, Action c, Action d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x99E08E0", Offset = "0x99DF6E0", VA = "0x1899E08E0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x99E08B0", Offset = "0x99DF6B0", VA = "0x1899E08B0")]
		[CompilerGenerated]
		private bool HZTAKKIVJEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x99E08B0", Offset = "0x99DF6B0", VA = "0x1899E08B0")]
		[CompilerGenerated]
		private bool HZNTNDOXZSW()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class JUDRBQXRXUR : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public JUDRBQXRXUR XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x99E7B30", Offset = "0x99E6930", VA = "0x1899E7B30")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x99E7A80", Offset = "0x99E6880", VA = "0x1899E7A80")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private readonly IReadOnlyDictionary<int, string> LRYQYOEVOMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private readonly MultiValueConfigProperty<int> LLILYOHYFWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private readonly MultiValueConfigProperty<bool> IPFSZBMGUMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private readonly MultiValueConfigProperty<bool> TKWQFQHTDWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private readonly MultiValueConfigProperty<float> TORJPGEPWNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private readonly MultiValueConfigProperty<float> FUGTSHCANTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly PFEJMQKPUYZ? MRYKPDZBGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private readonly CULQQUABIKW? LLQJQYRGIPW;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x99DCCA0", Offset = "0x99DBAA0", VA = "0x1899DCCA0")]
		public JUDRBQXRXUR(IReadOnlyDictionary<int, string>? effectsDict, MultiValueConfigProperty<int> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, PFEJMQKPUYZ? sandboxColorableConfig, CULQQUABIKW? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x99DCB60", Offset = "0x99DB960", VA = "0x1899DCB60", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class XSYLWIXQCDF : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public XSYLWIXQCDF XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x99DE7E0", Offset = "0x99DD5E0", VA = "0x1899DE7E0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class KRIMTFZCJAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public string KSDORHXKMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ConfigProperty<string> YDDBPDLRVYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public KRDFVZFEZPK DODNVPQZHNM;

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRIMTFZCJAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x99DEE60", Offset = "0x99DDC60", VA = "0x1899DEE60")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x99DECE0", Offset = "0x99DDAE0", VA = "0x1899DECE0")]
			internal void JHFNVQJCMYX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly bool VKTGJAIVKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly IReadOnlyList<ConfigProperty<string>> FSRHDULQEAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly int WEHFAAFJWFO;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x99EB4E0", Offset = "0x99EA2E0", VA = "0x1899EB4E0")]
		public XSYLWIXQCDF(int a, bool b, IReadOnlyList<ConfigProperty<string>> messages, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x99EB390", Offset = "0x99EA190", VA = "0x1899EB390", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class JZTZNWXXTWN : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public JZTZNWXXTWN XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x99DD7B0", Offset = "0x99DC5B0", VA = "0x1899DD7B0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly PNUMWIPZHAZ ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1087AC0", Offset = "0x10868C0", VA = "0x181087AC0")]
		public JZTZNWXXTWN(int a, PNUMWIPZHAZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE20", Offset = "0x99DBC20", VA = "0x1899DCE20", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class PNUMWIPZHAZ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public PNUMWIPZHAZ XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x99DEB60", Offset = "0x99DD960", VA = "0x1899DEB60")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x99DE170", Offset = "0x99DCF70", VA = "0x1899DE170")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private readonly bool VKTGJAIVKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private readonly string PGJSTNBIOKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private readonly ConfigProperty<string> YDDBPDLRVYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly int WMLSVAAOICN;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x99E1E10", Offset = "0x99E0C10", VA = "0x1899E1E10")]
		public PNUMWIPZHAZ(bool a, string b, ConfigProperty<string> message, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x99E1CC0", Offset = "0x99E0AC0", VA = "0x1899E1CC0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class LPQGQLHKJDN : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public LPQGQLHKJDN XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public Action EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public Func<bool> EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public Action<bool> EPVAUNZHLTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public Func<bool> FQNLYFEHVMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Action FQIFAYKKMBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public Action ERQKVWWJSRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public Action<bool> FQCYDRQNCPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public Action FPXRGKWPTEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public Action ERVRTDQHCCT;

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x99DC360", Offset = "0x99DB160", VA = "0x1899DC360")]
			internal bool NUTZARRTPEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x99D9C20", Offset = "0x99D8A20", VA = "0x1899D9C20")]
			internal bool VVBXMJOYVXM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x99D9310", Offset = "0x99D8110", VA = "0x1899D9310")]
			internal void HVWFCRIVYPJ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x99D9240", Offset = "0x99D8040", VA = "0x1899D9240")]
			internal bool FCVCNWZVBFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x99DA220", Offset = "0x99D9020", VA = "0x1899DA220")]
			internal void JGVABCVHUCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x99D9C60", Offset = "0x99D8A60", VA = "0x1899D9C60")]
			internal void JGPTDWBKKQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x99D9C20", Offset = "0x99D8A20", VA = "0x1899D9C20")]
			internal bool JGKMGPHNBFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x99D9B60", Offset = "0x99D8960", VA = "0x1899D9B60")]
			internal void JGFFJINPRUE(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x99D9680", Offset = "0x99D8480", VA = "0x1899D9680")]
			internal void JFZYMBTSIIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x99D9010", Offset = "0x99D7E10", VA = "0x1899D9010")]
			internal bool BWOLKDEAXLU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x99D9050", Offset = "0x99D7E50", VA = "0x1899D9050")]
			internal void BWTSHJXYGXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x99D9340", Offset = "0x99D8140", VA = "0x1899D9340")]
			internal void JFUROUZUYXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x99D8AA0", Offset = "0x99D78A0", VA = "0x1899D8AA0")]
			internal void BWDXPPQGEPC(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x99D8B70", Offset = "0x99D7970", VA = "0x1899D8B70")]
			internal void BWJEMWKDOAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class SIXMNEQISOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public LPQGQLHKJDN XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public PhysicsModelEnumFlags PUKINUTTNCT;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SIXMNEQISOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x99E5390", Offset = "0x99E4190", VA = "0x1899E5390")]
			internal bool AJXETPNVHLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x99E5350", Offset = "0x99E4150", VA = "0x1899E5350")]
			internal void AJRXWITXYAE(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly IReadOnlyList<CollisionMode> IDFDLWBZULH;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly IReadOnlyList<CollisionLayerEnum> DTLWVVFLSYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private readonly bool YSVRTCERLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private readonly ConfigProperty<CollisionMode> DKZWJLFBAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly ConfigProperty<CollisionLayerEnum> KWZBHVDANQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly ConfigProperty<float> ZMBLGZDTGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly Func<PhysicsModelEnumFlags, bool> LMPQYCYBSLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly Action<PhysicsModelEnumFlags, bool> AQQZHXAJBDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly ConfigProperty<float>? DZIUBGRJYJV;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x99DFFF0", Offset = "0x99DEDF0", VA = "0x1899DFFF0")]
		private static string KBQMGPWEZFS(CollisionMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x99DFF00", Offset = "0x99DED00", VA = "0x1899DFF00")]
		private static string DGUTXCIMZUM(CollisionLayerEnum a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x99E0470", Offset = "0x99DF270", VA = "0x1899E0470")]
		public LPQGQLHKJDN(bool a, ConfigProperty<CollisionMode> b, ConfigProperty<CollisionLayerEnum> c, ConfigProperty<float> d, Func<PhysicsModelEnumFlags, bool> hasFlag, Action<PhysicsModelEnumFlags, bool> setFlag, [Optional] ConfigProperty<float>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x99E0080", Offset = "0x99DEE80", VA = "0x1899E0080", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x99E01C0", Offset = "0x99DEFC0", VA = "0x1899E01C0")]
		private MultiValueConfigProperty<bool> UENWZFVJLRX(PhysicsModelEnumFlags a)
		{
			return default(MultiValueConfigProperty<bool>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class SVPXPMPWSII : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public SVPXPMPWSII XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x99E0EA0", Offset = "0x99DFCA0", VA = "0x1899E0EA0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x99E0D00", Offset = "0x99DFB00", VA = "0x1899E0D00")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private static readonly IReadOnlyList<GrabbableMode> PFZRQMAMTTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private readonly MultiValueConfigProperty<bool> ZSRGMHRZNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private readonly MultiValueConfigProperty<GrabbableMode> SGOCMFQPEEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private readonly MultiValueConfigProperty<bool> OFQATSXAMDW;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x99E5E00", Offset = "0x99E4C00", VA = "0x1899E5E00")]
		private static string YABDEIZHOKA(GrabbableMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x99C3960", Offset = "0x99C2760", VA = "0x1899C3960")]
		public SVPXPMPWSII(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<GrabbableMode> b, MultiValueConfigProperty<bool> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x99E5CC0", Offset = "0x99E4AC0", VA = "0x1899E5CC0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class WEKJAEMGUIY : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public WEKJAEMGUIY XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Func<bool> EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x99E4200", Offset = "0x99E3000", VA = "0x1899E4200")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x99E2F60", Offset = "0x99E1D60", VA = "0x1899E2F60")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x99E2B50", Offset = "0x99E1950", VA = "0x1899E2B50")]
			internal bool JHAGYJPFDNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x99E2B90", Offset = "0x99E1990", VA = "0x1899E2B90")]
			internal void JHFNVQJCMYX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private readonly Option<bool> VKXJYEKRZGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private readonly MultiValueConfigProperty<string> TRYGGLEORZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Func<int> UHNGOMULHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private readonly MultiValueConfigProperty<bool> FXWUHYHVHWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly MultiValueConfigProperty<bool> ZGIONLGFTAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly AFZMUVEFJBH? OJXHPBYLJAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly IYYXSZTVWSI? LWXYVBKWGNS;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x99EA570", Offset = "0x99E9370", VA = "0x1899EA570")]
		public WEKJAEMGUIY(Option<bool> a, MultiValueConfigProperty<string> name, Func<int> currentSelectionCount, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, AFZMUVEFJBH? transformConfig, IYYXSZTVWSI? tagsConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x99EA430", Offset = "0x99E9230", VA = "0x1899EA430", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class YRZHFLIOQYO : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class BVQANBPWYUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public YRZHFLIOQYO XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Func<int> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x99D5080", Offset = "0x99D3E80", VA = "0x1899D5080")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x99D5050", Offset = "0x99D3E50", VA = "0x1899D5050")]
			internal int JHKUSXCZWKG()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private readonly MultiValueConfigProperty<int> BVALNGPHNSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> HSIITIRVCMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private readonly MultiValueConfigProperty<int> HHMSNTNERSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private readonly Action<RNLDKFFPJOS.MaterialPickerData> YBIVSWOYYVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private readonly MultiValueConfigProperty<float> FJKBMMOXQGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private readonly MultiValueConfigProperty<float> ZLEOYTENZZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private readonly MultiValueConfigProperty<float> ZLJVVZYLJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private readonly MultiValueConfigProperty<float> ZKUBEFQTHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly MultiValueConfigProperty<bool> ZRLPSWLIXQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private readonly Func<bool> PUBUCZMHULF;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x99EB680", Offset = "0x99EA480", VA = "0x1899EB680")]
		public YRZHFLIOQYO(MultiValueConfigProperty<int> a, Action<RNLDKFFPJOS.ColorPickerData> colorButtonOnClick, MultiValueConfigProperty<int> b, Action<RNLDKFFPJOS.MaterialPickerData> materialButtonOnClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, Func<bool> isSinglePrimitiveShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x99EB540", Offset = "0x99EA340", VA = "0x1899EB540", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class UHHYCMJADJI : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public UHHYCMJADJI XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x99DE4F0", Offset = "0x99DD2F0", VA = "0x1899DE4F0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private readonly Dictionary<int, string> WLACYPXZUDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private readonly MultiValueConfigProperty<bool> FZXUEQOUGQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private readonly MultiValueConfigProperty<bool> TVVXWWCEZQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private readonly MultiValueConfigProperty<int> HTKIGQNLETH;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x99E81D0", Offset = "0x99E6FD0", VA = "0x1899E81D0")]
		public UHHYCMJADJI(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<int> c, Dictionary<int, string> tubeRingOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x99E8090", Offset = "0x99E6E90", VA = "0x1899E8090", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class PXTESXHNSFH : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public PXTESXHNSFH XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x99DD4E0", Offset = "0x99DC2E0", VA = "0x1899DD4E0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private readonly PFEJMQKPUYZ ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1087AC0", Offset = "0x10868C0", VA = "0x181087AC0")]
		public PXTESXHNSFH(int a, PFEJMQKPUYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x99E1E90", Offset = "0x99E0C90", VA = "0x1899E1E90", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class PFEJMQKPUYZ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class WYUZZVKPLDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public PFEJMQKPUYZ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public WYUZZVKPLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x99EA910", Offset = "0x99E9710", VA = "0x1899EA910")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x99EA7A0", Offset = "0x99E95A0", VA = "0x1899EA7A0")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private readonly RecolorModes WRUGGANDLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly ConfigProperty<int> CPDFVIZGUOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly Action<RNLDKFFPJOS.ColorPickerData> HSIITIRVCMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly ConfigProperty<int> ARDMNSQEBBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly Action<RNLDKFFPJOS.MaterialPickerData> YBIVSWOYYVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly ConfigProperty<float> MVPIMEKYEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private readonly bool GPSGGXGHHYU;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x99E1BF0", Offset = "0x99E09F0", VA = "0x1899E1BF0")]
		public PFEJMQKPUYZ(RecolorModes a, ConfigProperty<int> b, Action<RNLDKFFPJOS.ColorPickerData> colorButtonOnClick, ConfigProperty<int> c, Action<RNLDKFFPJOS.MaterialPickerData> materialButtonOnClick, ConfigProperty<float> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x99E1A00", Offset = "0x99E0800", VA = "0x1899E1A00", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class XGKQIDSWNBL : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public XGKQIDSWNBL XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x99D89F0", Offset = "0x99D77F0", VA = "0x1899D89F0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private readonly CULQQUABIKW? PWAKMGAMAFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private readonly PNUMWIPZHAZ? RSLPKNLWHKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private readonly PFEJMQKPUYZ? ACERHWXGBEP;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF0DF30", Offset = "0xF0CD30", VA = "0x180F0DF30")]
		public XGKQIDSWNBL(PNUMWIPZHAZ? a, PFEJMQKPUYZ? b, CULQQUABIKW? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x99EB250", Offset = "0x99EA050", VA = "0x1899EB250", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class WVJPIVJNRTS : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public WVJPIVJNRTS XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x99DD750", Offset = "0x99DC550", VA = "0x1899DD750")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private readonly int PYOJCWOETUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private readonly CULQQUABIKW ZIGMYXOYFWR;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1087AC0", Offset = "0x10868C0", VA = "0x181087AC0")]
		public WVJPIVJNRTS(int a, CULQQUABIKW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x99EA650", Offset = "0x99E9450", VA = "0x1899EA650", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class CULQQUABIKW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly string PGJSTNBIOKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private readonly MultiValueConfigProperty<bool> UPXIHJUJEMH;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x99B40E0", Offset = "0x99B2EE0", VA = "0x1899B40E0")]
		public CULQQUABIKW(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x99D5830", Offset = "0x99D4630", VA = "0x1899D5830", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class IYYXSZTVWSI : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public IYYXSZTVWSI XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Func<string, bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x99E31A0", Offset = "0x99E1FA0", VA = "0x1899E31A0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x99E2DD0", Offset = "0x99E1BD0", VA = "0x1899E2DD0")]
			internal bool JHKUSXCZWKG(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private readonly ConfigProperty<IReadOnlyList<string>> BDNFJAKKBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private readonly ConfigProperty<IReadOnlyList<string>>? ORBUGWQQSWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private readonly Func<bool> NOPEYUJWRGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly Func<bool>? CZKGQKREOHX;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
		private static bool BQAVXUHRGNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x99DC880", Offset = "0x99DB680", VA = "0x1899DC880")]
		public IYYXSZTVWSI(int a, ConfigProperty<IReadOnlyList<string>> persistentTags, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeTags, [Optional] Func<bool>? b, [Optional] Func<bool>? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x99DC770", Offset = "0x99DB570", VA = "0x1899DC770", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class WCWUDEFQOKO : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class UYMEXYGBTAU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public WCWUDEFQOKO XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UYMEXYGBTAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x99E8310", Offset = "0x99E7110", VA = "0x1899E8310")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x99E82E0", Offset = "0x99E70E0", VA = "0x1899E82E0")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x99E82B0", Offset = "0x99E70B0", VA = "0x1899E82B0")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x99E8280", Offset = "0x99E7080", VA = "0x1899E8280")]
			internal void JHAGYJPFDNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class FSAELSPRGFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public WCWUDEFQOKO XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FSAELSPRGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x99D7B20", Offset = "0x99D6920", VA = "0x1899D7B20")]
			internal void AQVGPOQBWYO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x99D8080", Offset = "0x99D6E80", VA = "0x1899D8080")]
			internal void ARANMVJZGJX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x99D7AB0", Offset = "0x99D68B0", VA = "0x1899D7AB0")]
			internal bool AQKSVBCHEBW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly IReadOnlyList<GunHandleData.SFCQHHVLTYC.GunHandleScreensPose> VKJFEFLJYIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private readonly MultiValueConfigProperty<GunHandleData.SFCQHHVLTYC.GunHandleScreensPose> DVANIAXDXNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly MultiValueConfigProperty<int> WFUMVHLVHFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly MultiValueConfigProperty<bool> UOBPGHLBZXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly MultiValueConfigProperty<float> XWLFAVVQZHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly MultiValueConfigProperty<bool> AFACCLVFFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly MultiValueConfigProperty<float> GAMTUQNNTUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly MultiValueConfigProperty<bool> ZTXMZVEIPGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly MultiValueConfigProperty<bool> PYUOJHZRRHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly MultiValueConfigProperty<float> KXYZGQXHNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private readonly MultiValueConfigProperty<bool> UQCBKZXJRQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private readonly MultiValueConfigProperty<bool> MXLXBLYPHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private readonly MultiValueConfigProperty<bool> MVMYTHBAZAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly MultiValueConfigProperty<bool> IBNLNWXDLXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly MultiValueConfigProperty<bool> EXYDJZXBSVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MultiValueConfigProperty<float> FCSHMMHOISK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly MultiValueConfigProperty<float> SDAANTRNSCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private readonly MultiValueConfigProperty<float> EQBKRJBAHBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly MultiValueConfigProperty<float> DELAMQCOYVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly MultiValueConfigProperty<float> TDPJUGPHPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private readonly MultiValueConfigProperty<float> KBFGFZWMTAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly MultiValueConfigProperty<bool> ZCENVOVJFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly MultiValueConfigProperty<bool> EXACGMGPXPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly MultiValueConfigProperty<bool> UEIAQBEZOLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly MultiValueConfigProperty<string> IWEWNKWPLHO;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x99E9540", Offset = "0x99E8340", VA = "0x1899E9540")]
		private static string KPSRXLLNVYC(GunHandleData.SFCQHHVLTYC.GunHandleScreensPose a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x99EA010", Offset = "0x99E8E10", VA = "0x1899EA010")]
		public WCWUDEFQOKO(MultiValueConfigProperty<GunHandleData.SFCQHHVLTYC.GunHandleScreensPose> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, MultiValueConfigProperty<float> q, MultiValueConfigProperty<float> r, MultiValueConfigProperty<float> s, MultiValueConfigProperty<float> t, MultiValueConfigProperty<bool> u, MultiValueConfigProperty<bool> v, MultiValueConfigProperty<bool> w, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x99E99F0", Offset = "0x99E87F0", VA = "0x1899E99F0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x99E9640", Offset = "0x99E8440", VA = "0x1899E9640")]
		private void RADGGLDUYLG(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x99E9090", Offset = "0x99E7E90", VA = "0x1899E9090")]
		private void IRVLCEAQBXY(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x99E9B30", Offset = "0x99E8930", VA = "0x1899E9B30")]
		private void TVNRAWHFHLC(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x99E9F10", Offset = "0x99E8D10", VA = "0x1899E9F10")]
		[CompilerGenerated]
		private bool XSYTITEFTWN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x99E9EA0", Offset = "0x99E8CA0", VA = "0x1899E9EA0")]
		[CompilerGenerated]
		private bool XSTMLMKIKLE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class NBGQQKEEBNQ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly string BCFEXEUOGJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly MultiValueConfigProperty<string> IWEWNKWPLHO;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x99B40E0", Offset = "0x99B2EE0", VA = "0x1899B40E0")]
		public NBGQQKEEBNQ(string a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x99E0790", Offset = "0x99DF590", VA = "0x1899E0790", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class VDULQZQMUPA : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public VDULQZQMUPA XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Func<bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x99E33C0", Offset = "0x99E21C0", VA = "0x1899E33C0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x99E3130", Offset = "0x99E1F30", VA = "0x1899E3130")]
			internal bool JHKUSXCZWKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly IReadOnlyDictionary<SwingHandleData.SFCQHHVLTYC.SwingHandleAnimation, string> FAYESCWTCAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly MultiValueConfigProperty<SwingHandleData.SFCQHHVLTYC.SwingHandleAnimation> EUUZFTIOWTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly MultiValueConfigProperty<bool> OYWFWKOZUDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly MultiValueConfigProperty<bool> CXPKOFIAZEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly MultiValueConfigProperty<float> IBVISYVSEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly MultiValueConfigProperty<bool> ZCENVOVJFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly MultiValueConfigProperty<string> IWEWNKWPLHO;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x99B9540", Offset = "0x99B8340", VA = "0x1899B9540")]
		public VDULQZQMUPA(MultiValueConfigProperty<SwingHandleData.SFCQHHVLTYC.SwingHandleAnimation> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x99E8CD0", Offset = "0x99E7AD0", VA = "0x1899E8CD0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class KQOVZOPFTYM : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public KQOVZOPFTYM XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x99E3F90", Offset = "0x99E2D90", VA = "0x1899E3F90")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x99E2DA0", Offset = "0x99E1BA0", VA = "0x1899E2DA0")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x99E2BF0", Offset = "0x99E19F0", VA = "0x1899E2BF0")]
			internal void JHFNVQJCMYX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.SFCQHHVLTYC.ThrowHandleIdlePose, string> MZZGVJFCRNL;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.SFCQHHVLTYC.ThrowHandleThrowPose, string> LKXHFCSPEWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private readonly MultiValueConfigProperty<ThrowHandleData.SFCQHHVLTYC.ThrowHandleIdlePose> TEXKFGYFLRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private readonly MultiValueConfigProperty<ThrowHandleData.SFCQHHVLTYC.ThrowHandleThrowPose> ODTBXJABUMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private readonly MultiValueConfigProperty<float> UBSJYHBMURT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private readonly MultiValueConfigProperty<float> FSCCUDNDVTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private readonly MultiValueConfigProperty<string> IWEWNKWPLHO;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x99CD370", Offset = "0x99CC170", VA = "0x1899CD370")]
		public KQOVZOPFTYM(MultiValueConfigProperty<ThrowHandleData.SFCQHHVLTYC.ThrowHandleIdlePose> a, MultiValueConfigProperty<ThrowHandleData.SFCQHHVLTYC.ThrowHandleThrowPose> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x99DDB00", Offset = "0x99DC900", VA = "0x1899DDB00", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x99DDC40", Offset = "0x99DCA40", VA = "0x1899DDC40")]
		private void RUABVWPUPBK(RNLDKFFPJOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x99DD950", Offset = "0x99DC750", VA = "0x1899DD950")]
		private void DTAYOYKCRHR(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class FTDMPZECGXW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public FTDMPZECGXW XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x99DD540", Offset = "0x99DC340", VA = "0x1899DD540")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private readonly MultiValueConfigProperty<bool> LHPKPUQEBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private readonly MultiValueConfigProperty<string> IWEWNKWPLHO;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x99C2710", Offset = "0x99C1510", VA = "0x1899C2710")]
		public FTDMPZECGXW(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x99D85B0", Offset = "0x99D73B0", VA = "0x1899D85B0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class BNXXGBEWNTJ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public BNXXGBEWNTJ XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x99D8900", Offset = "0x99D7700", VA = "0x1899D8900")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly MultiValueConfigProperty<string> IWEWNKWPLHO;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public BNXXGBEWNTJ(MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x99D4F10", Offset = "0x99D3D10", VA = "0x1899D4F10", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class QVACXLMDIGK : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class BEKRWCFQTJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public QVACXLMDIGK XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BEKRWCFQTJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x99D4690", Offset = "0x99D3490", VA = "0x1899D4690")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private readonly MultiValueConfigProperty<bool> DDQXEGCKSUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private readonly MultiValueConfigProperty<float> KZEXLGDCQYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private readonly System.Numerics.Vector2 IDWDNPIGPQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private readonly MultiValueConfigProperty<bool> FYAPZNCIPMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private readonly PFEJMQKPUYZ? AAJYNXRQUDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private readonly CULQQUABIKW? AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x99E4750", Offset = "0x99E3550", VA = "0x1899E4750")]
		public QVACXLMDIGK(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<bool> d, PFEJMQKPUYZ? colorableOptions, CULQQUABIKW? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x99E4610", Offset = "0x99E3410", VA = "0x1899E4610", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class SHAVQMTKVLX : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public SHAVQMTKVLX XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x99D8750", Offset = "0x99D7550", VA = "0x1899D8750")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly IYYXSZTVWSI PYDUJRQNPXB;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public SHAVQMTKVLX(IYYXSZTVWSI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x99E5210", Offset = "0x99E4010", VA = "0x1899E5210", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class GUEUVUWKZEW : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public GUEUVUWKZEW XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x99D87B0", Offset = "0x99D75B0", VA = "0x1899D87B0")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly MultiValueConfigProperty<bool> MXRXYRZHYJV;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C50", Offset = "0x99B2A50", VA = "0x1899B3C50")]
		public GUEUVUWKZEW(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x99DC3A0", Offset = "0x99DB1A0", VA = "0x1899DC3A0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class ONRVJJMNNPB : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class BEKRWCFQTJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public ONRVJJMNNPB XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BEKRWCFQTJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x99D4BA0", Offset = "0x99D39A0", VA = "0x1899D4BA0")]
			internal bool TILWRICDMBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x99D4330", Offset = "0x99D3130", VA = "0x1899D4330")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private readonly MultiValueConfigProperty<bool> ANDGHCSAJVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private readonly Func<bool> EKPPIVLJLUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private readonly MultiValueConfigProperty<bool> TBHUTEJEBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private readonly MultiValueConfigProperty<float> WFFDKGZNUJQ;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x99E0C50", Offset = "0x99DFA50", VA = "0x1899E0C50")]
		public ONRVJJMNNPB(MultiValueConfigProperty<bool> a, Func<bool> canSeeShouldRespawn, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x99E0B10", Offset = "0x99DF910", VA = "0x1899E0B10", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class KCXADTAQTGO : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class WYUZZVKPLDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public KCXADTAQTGO XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public WYUZZVKPLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x99EABC0", Offset = "0x99E99C0", VA = "0x1899EABC0")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x99EA7C0", Offset = "0x99E95C0", VA = "0x1899EA7C0")]
			internal void JHKUSXCZWKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly Dictionary<SeatData.SFCQHHVLTYC.PostureType, string> JREMPPJYZZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private readonly string VYEBJQMXICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private readonly Option<bool> SGRHZYACMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private readonly MultiValueConfigProperty<SeatData.SFCQHHVLTYC.PostureType> NNJCMBMKCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private readonly MultiValueConfigProperty<bool> TMTSGLFHUBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private readonly MultiValueConfigProperty<bool> HQEXSXDSVHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private readonly MultiValueConfigProperty<bool> CSTKQPXNDSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private readonly MultiValueConfigProperty<bool> BUWVIAAACWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly MultiValueConfigProperty<bool> PCCWUDKRJIZ;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x99DD3B0", Offset = "0x99DC1B0", VA = "0x1899DD3B0")]
		public KCXADTAQTGO(string configName, Option<bool> a, MultiValueConfigProperty<SeatData.SFCQHHVLTYC.PostureType> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x99DD180", Offset = "0x99DBF80", VA = "0x1899DD180", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class TIAUWFYWKGX : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class SFJDTQTBFER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public TIAUWFYWKGX XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SFJDTQTBFER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x99E4B00", Offset = "0x99E3900", VA = "0x1899E4B00")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private static readonly IReadOnlyDictionary<int, string> HKTXRWTNSSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private readonly MultiValueConfigProperty<int> OLFIJHQHLSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private readonly IReadOnlyDictionary<int, string> LDMXJGGDOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private readonly MultiValueConfigProperty<float> FBGUITVVBRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private readonly MultiValueConfigProperty<int> GYJLJPXRBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private readonly MultiValueConfigProperty<string> FWIXCHWYSBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly MultiValueConfigProperty<bool> LJXXIOZYSKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly MultiValueConfigProperty<string> YBZDQJXZVXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private readonly MultiValueConfigProperty<bool> DPVUZKHEHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private readonly MultiValueConfigProperty<bool> OFYNOCEBBFR;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x99E6150", Offset = "0x99E4F50", VA = "0x1899E6150")]
		public TIAUWFYWKGX(MultiValueConfigProperty<int> a, IReadOnlyDictionary<int, string> teamItems, MultiValueConfigProperty<float> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<string> primaryHandRespawnTag, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> secondaryHandRespawnTag, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x99E5F00", Offset = "0x99E4D00", VA = "0x1899E5F00", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public sealed class EPZHZRXEOWZ : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public EPZHZRXEOWZ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public Action EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Action EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x99DBA40", Offset = "0x99DA840", VA = "0x1899DBA40")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x99DACF0", Offset = "0x99D9AF0", VA = "0x1899DACF0")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x99DAB70", Offset = "0x99D9970", VA = "0x1899DAB70")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x99DA9F0", Offset = "0x99D97F0", VA = "0x1899DA9F0")]
			internal void JHAGYJPFDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x99DA870", Offset = "0x99D9670", VA = "0x1899DA870")]
			internal void JGVABCVHUCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x99DA090", Offset = "0x99D8E90", VA = "0x1899DA090")]
			internal void JGPTDWBKKQW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly MultiValueConfigProperty<bool> RUAQRUSHTDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private readonly MultiValueConfigProperty<float> FBGUITVVBRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private readonly MultiValueConfigProperty<float> FBIWIDZCFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private readonly IYYXSZTVWSI OGBJUPXDPRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private readonly IYYXSZTVWSI XGWTLNFTBQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private readonly IReadOnlyList<(Guid, string)>? QHYVAGJEVXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> IJJCFVWPCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> CJEJCREAPZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private readonly Action<RNLDKFFPJOS.MultiTogglePickerData> VZHLCJXEISC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private readonly CULQQUABIKW? AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x99D6B90", Offset = "0x99D5990", VA = "0x1899D6B90")]
		public EPZHZRXEOWZ(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, IReadOnlyList<(Guid, string)>? roleItems, ConfigProperty<string[]> roleGuidsToSpawn, ConfigProperty<string[]> roleGuidsToAvoid, Action<RNLDKFFPJOS.MultiTogglePickerData> onRolePickerClick, CULQQUABIKW? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x99D6A50", Offset = "0x99D5850", VA = "0x1899D6A50", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public sealed class TVLHUHAZSLS : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public TVLHUHAZSLS XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Action EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Action EQFOPBNCEPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public Action EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public Action EQKVMIGZOBI;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x99DBE90", Offset = "0x99DAC90", VA = "0x1899DBE90")]
			internal void JHQBQDWXFVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x99DABD0", Offset = "0x99D99D0", VA = "0x1899DABD0")]
			internal void JHKUSXCZWKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x99DA990", Offset = "0x99D9790", VA = "0x1899DA990")]
			internal void JHAGYJPFDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x99DAA50", Offset = "0x99D9850", VA = "0x1899DAA50")]
			internal void JHFNVQJCMYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x99DA1C0", Offset = "0x99D8FC0", VA = "0x1899DA1C0")]
			internal void JGVABCVHUCF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private readonly int NBANMDIFEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly MultiValueConfigProperty<bool> JSQLHFABESQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private readonly MultiValueConfigProperty<float> FBGUITVVBRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private readonly MultiValueConfigProperty<float> FBIWIDZCFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private readonly IYYXSZTVWSI OGBJUPXDPRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private readonly IYYXSZTVWSI XGWTLNFTBQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private readonly CULQQUABIKW? AGFVGINXOXN;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x99E6400", Offset = "0x99E5200", VA = "0x1899E6400")]
		public TVLHUHAZSLS(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, CULQQUABIKW? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x99E62C0", Offset = "0x99E50C0", VA = "0x1899E62C0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class KVTSBAVOTCF : ZSHNODKQKJY
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public RNLDKFFPJOS ZZCVYRDEILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public KVTSBAVOTCF XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x99E1340", Offset = "0x99E0140", VA = "0x1899E1340")]
			internal void JHQBQDWXFVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private readonly MultiValueConfigProperty<string> RLSRQPSTNEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly MultiValueConfigProperty<float> KTKIVNVEBAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly MultiValueConfigProperty<bool> KQMKJHHOMBD;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x99C3960", Offset = "0x99C2760", VA = "0x1899C3960")]
		public KVTSBAVOTCF(MultiValueConfigProperty<string> WelcomeMatName, MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x99DEFF0", Offset = "0x99DDDF0", VA = "0x1899DEFF0", Slot = "4")]
		public void RLQQDTULWNZ(RNLDKFFPJOS a)
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
