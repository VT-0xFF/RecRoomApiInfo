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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B7A270", Offset = "0x9B79270", VA = "0x189B7A270")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ObjectConfigs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class PCKQLIIUCXT : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class YPRJWODNIVX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PCKQLIIUCXT DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YPRJWODNIVX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9B8C1E0", Offset = "0x9B8B1E0", VA = "0x189B8C1E0")]
			internal bool KTFCLIPUXCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9B8C250", Offset = "0x9B8B250", VA = "0x189B8C250")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IReadOnlyList<Channel> CTPKLOIGNRK;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IReadOnlyList<Channel> MCQPSZQRMFB;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly IReadOnlyList<RolloffCurve> XGYFKWGCAXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MultiValueConfigProperty<float> CISYRUQWRJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MultiValueConfigProperty<float> ELJYLCBLGTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MultiValueConfigProperty<Channel> ZFJHHPZOBWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly bool SOJRGAZAVPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string YNUICLQURCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MultiValueConfigProperty<bool> JUHVAUAMLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MultiValueConfigProperty<float> DRUIEXWJRTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MultiValueConfigProperty<RolloffCurve> DGPAWYBARXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MultiValueConfigProperty<bool> USEMCJSKESR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly string UXQIGCSMXAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MultiValueConfigProperty<bool> LJRTCPMVCVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly string QFQBGLJWGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MultiValueConfigProperty<bool> BSFWOGLWEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly FOKZUHVDJOX? ELUVSQCZYVB;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AB40", Offset = "0x9B79B40", VA = "0x189B7AB40")]
		private static string TDQXJUOJIKL(Channel a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AD30", Offset = "0x9B79D30", VA = "0x189B7AD30")]
		private static string VJSVNHXJEFV(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AF00", Offset = "0x9B79F00", VA = "0x189B7AF00")]
		public PCKQLIIUCXT(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<Channel> c, bool d, string useSpatialAudioLabel, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<RolloffCurve> g, MultiValueConfigProperty<bool> h, string isLoopingLabel, MultiValueConfigProperty<bool> i, string interruptCurrentSoundLabel, MultiValueConfigProperty<bool> j, FOKZUHVDJOX? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ABF0", Offset = "0x9B79BF0", VA = "0x189B7ABF0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class HVDNXPAPLJS : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BFGCHHTGJIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HVDNXPAPLJS DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Func<bool> QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Func<bool> QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BFGCHHTGJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B6E470", Offset = "0x9B6D470", VA = "0x189B6E470")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B6E4D0", Offset = "0x9B6D4D0", VA = "0x189B6E4D0")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DE80", Offset = "0x9B6CE80", VA = "0x189B6DE80")]
			internal bool MMJBIFJRCXS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DF00", Offset = "0x9B6CF00", VA = "0x189B6DF00")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly IReadOnlyDictionary<Channel, string> LJHDJUBCGMN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly IReadOnlyDictionary<Channel, string> VDBWGQDNYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly bool LCEUOLBSYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly PIGFNDQWTPY GFTNUPSSWBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly MultiValueConfigProperty<bool> KTRMCTWOSZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MultiValueConfigProperty<Channel> ZFJHHPZOBWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly MultiValueConfigProperty<float> ZQVTFFVWSTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MultiValueConfigProperty<float> YZNJEQDYXOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MultiValueConfigProperty<bool> CXDHCIVMXXD;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B72900", Offset = "0x9B71900", VA = "0x189B72900")]
		public HVDNXPAPLJS(bool a, PIGFNDQWTPY recordableObjectOptions, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<Channel> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B72550", Offset = "0x9B71550", VA = "0x189B72550", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class IEWTFNBWUZO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public IEWTFNBWUZO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Func<bool> QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Func<bool> QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> QKXDRYXLJNE;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9B710F0", Offset = "0x9B700F0", VA = "0x189B710F0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9B71DD0", Offset = "0x9B70DD0", VA = "0x189B71DD0")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9B704D0", Offset = "0x9B6F4D0", VA = "0x189B704D0")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9B70580", Offset = "0x9B6F580", VA = "0x189B70580")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9B71DF0", Offset = "0x9B70DF0", VA = "0x189B71DF0")]
			internal bool MNOQRTZBHNU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9B71E10", Offset = "0x9B70E10", VA = "0x189B71E10")]
			internal bool MNTXPASYQZD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Option<string> KSACZKLZRHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MultiValueConfigProperty<bool> ZHHDXLTQIHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly IReadOnlyDictionary<int, string>? QMVHFUQEIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MultiValueConfigProperty<int> DKIAWEWLGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Option<string> CPGATGUIYCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly MultiValueConfigProperty<bool> UXWQPYBJLVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Option<string> RNYPPRHOBQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MultiValueConfigProperty<int> CISYRUQWRJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Option<string> QQEBSGCHGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly MultiValueConfigProperty<bool> BTHPHQJFDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly Func<Option<bool>> VWZBPIPMXZH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B72D20", Offset = "0x9B71D20", VA = "0x189B72D20")]
		public IEWTFNBWUZO(Option<string> is3dAudioLabel, MultiValueConfigProperty<bool> a, Option<string[]> sfxOptions, MultiValueConfigProperty<int> b, Option<string> isInterruptibleLabel, MultiValueConfigProperty<bool> c, Option<string> volumeLabel, MultiValueConfigProperty<int> d, Option<string> playForAllLabel, MultiValueConfigProperty<bool> e, Func<Option<bool>> hasControlPanel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B72BE0", Offset = "0x9B71BE0", VA = "0x189B72BE0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class YPEPBRENBSV : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class VIHYUHFKEDV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public YPEPBRENBSV DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9B852C0", Offset = "0x9B842C0", VA = "0x189B852C0")]
			internal bool TQZCINYKMAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9B85070", Offset = "0x9B84070", VA = "0x189B85070")]
			internal bool JTYRTYXDHFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9B851F0", Offset = "0x9B841F0", VA = "0x189B851F0")]
			internal void MNOQRTZBHNU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9B85250", Offset = "0x9B84250", VA = "0x189B85250")]
			internal bool MNTXPASYQZD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9B85170", Offset = "0x9B84170", VA = "0x189B85170")]
			internal bool MNECXGLGORC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9B850C0", Offset = "0x9B840C0", VA = "0x189B850C0")]
			internal bool MMJBIFJRCXS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B85150", Offset = "0x9B84150", VA = "0x189B85150")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly IReadOnlyList<PreferredHandedness> ZKLAGMKABZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly AccountRoleType VXWOIKETKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly ZKXEXUFWDRP? EBVPZDIDDTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly MultiValueConfigProperty<bool> YFJEOVQLFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Option<bool> GUALLVLCRDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Option<bool> AYXCRXHVTZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly MultiValueConfigProperty<PreferredHandedness> RIRQEMJIJTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MultiValueConfigProperty<bool> UYVIAHAFVSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly MultiValueConfigProperty<bool> UIXJLWWZOYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly MultiValueConfigProperty<bool> FROVAFYXCVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly MultiValueConfigProperty<bool> VGXAZNGSLRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly MultiValueConfigProperty<bool> WZOFCMZHHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MultiValueConfigProperty<bool> ULZUQRQIQWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly bool HPHYNMZEPGX;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B410", Offset = "0x9B8A410", VA = "0x189B8B410")]
		private static string QVSDFQIPFTE(PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8C030", Offset = "0x9B8B030", VA = "0x189B8C030")]
		public YPEPBRENBSV(AccountRoleType a, ZKXEXUFWDRP? interactionFilterOptions, MultiValueConfigProperty<bool> b, Option<bool> c, Option<bool> d, MultiValueConfigProperty<PreferredHandedness> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, bool l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B420", Offset = "0x9B8A420", VA = "0x189B8B420", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class ABBNSFSCWLY : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public ABBNSFSCWLY DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<bool> QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Action QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Func<bool> QKXDRYXLJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9B78840", Offset = "0x9B77840", VA = "0x189B78840")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9B79320", Offset = "0x9B78320", VA = "0x189B79320")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9B77DE0", Offset = "0x9B76DE0", VA = "0x189B77DE0")]
			internal void MMOIFMDOMJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B79430", Offset = "0x9B78430", VA = "0x189B79430")]
			internal void MNOQRTZBHNU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B79400", Offset = "0x9B78400", VA = "0x189B79400")]
			internal bool MNECXGLGORC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B795A0", Offset = "0x9B785A0", VA = "0x189B795A0")]
			internal bool MNTXPASYQZD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9B77D50", Offset = "0x9B76D50", VA = "0x189B77D50")]
			internal void MMJBIFJRCXS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly bool JVCDXPRBJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool VZQSUMDOZCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly YPEPBRENBSV TMVYLHGVNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly VAQIEMQRQWD? MLKOMKVFMTM;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D620", Offset = "0x9B6C620", VA = "0x189B6D620")]
		public ABBNSFSCWLY(int a, bool b, bool c, YPEPBRENBSV d, VAQIEMQRQWD? creatorRestrictedRolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D4E0", Offset = "0x9B6C4E0", VA = "0x189B6D4E0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class NGULNHVJFXB : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public NGULNHVJFXB DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9B84310", Offset = "0x9B83310", VA = "0x189B84310")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly YPEPBRENBSV TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public NGULNHVJFXB(YPEPBRENBSV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A130", Offset = "0x9B79130", VA = "0x189B7A130", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class HNLTGYSAZJH : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HNLTGYSAZJH DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B87180", Offset = "0x9B86180", VA = "0x189B87180")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B892A0", Offset = "0x9B882A0", VA = "0x189B892A0")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly ZKXEXUFWDRP? UCUOVUVTIHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly MultiValueConfigProperty<bool> GZNJOQWXPNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Option<bool> VWZBPIPMXZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly MultiValueConfigProperty<bool> KELFAQCHQDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly MultiValueConfigProperty<bool> OKVZHJSJRFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly KTZVRHZGFLQ? AQFGVEUKPNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly FOKZUHVDJOX? VWCKNNNOFNT;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B71FE0", Offset = "0x9B70FE0", VA = "0x189B71FE0")]
		public HNLTGYSAZJH(ZKXEXUFWDRP? interactionFilterConfig, MultiValueConfigProperty<bool> a, Option<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, FOKZUHVDJOX? syncedComponent, KTZVRHZGFLQ? playerEditableText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B71EA0", Offset = "0x9B70EA0", VA = "0x189B71EA0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class PGOIDKHPYYJ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PGOIDKHPYYJ DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B81BD0", Offset = "0x9B80BD0", VA = "0x189B81BD0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B82900", Offset = "0x9B81900", VA = "0x189B82900")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly ZKXEXUFWDRP? UCUOVUVTIHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly MultiValueConfigProperty<bool> RJMFPRRSFQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly MultiValueConfigProperty<bool> GZNJOQWXPNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly MultiValueConfigProperty<bool> LJNUWFGILDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Option<bool> VWZBPIPMXZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly MultiValueConfigProperty<bool> KELFAQCHQDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly MultiValueConfigProperty<bool> OKVZHJSJRFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly FOKZUHVDJOX? VWCKNNNOFNT;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B430", Offset = "0x9B7A430", VA = "0x189B7B430")]
		public PGOIDKHPYYJ(ZKXEXUFWDRP? interactionFilterConfig, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, Option<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, FOKZUHVDJOX? syncedComponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B2F0", Offset = "0x9B7A2F0", VA = "0x189B7B2F0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UMDZMEDFBGE : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public UMDZMEDFBGE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9B8DE90", Offset = "0x9B8CE90", VA = "0x189B8DE90")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MultiValueConfigProperty<bool> YPMZTSNXBFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MultiValueConfigProperty<float> ZWFOCNPNLPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly OEVDPFSZBEO? XGRFWEKBYTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly FOKZUHVDJOX? CZTQPDAQNJD;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B84B10", Offset = "0x9B83B10", VA = "0x189B84B10")]
		public UMDZMEDFBGE(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, OEVDPFSZBEO? sandboxColorableOptions, FOKZUHVDJOX? syncedComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B849D0", Offset = "0x9B839D0", VA = "0x189B849D0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class KLBLOWAUJXO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public KLBLOWAUJXO DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B8D940", Offset = "0x9B8C940", VA = "0x189B8D940")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly IReadOnlyList<CircuitsTransformBehavior> TXEQMZLAESI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly MultiValueConfigProperty<CircuitsTransformBehavior> PIDGKOFCXIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly QWBPTMJFCAD? XWEHEGOKOPV;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B74360", Offset = "0x9B73360", VA = "0x189B74360")]
		private static string ZNLKLKEBWGP(CircuitsTransformBehavior a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F870", Offset = "0x9B6E870", VA = "0x189B6F870")]
		public KLBLOWAUJXO(MultiValueConfigProperty<CircuitsTransformBehavior> a, QWBPTMJFCAD? objectBoardConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B74220", Offset = "0x9B73220", VA = "0x189B74220", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class ZFHUINBMISJ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public ZFHUINBMISJ DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B881B0", Offset = "0x9B871B0", VA = "0x189B881B0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string QHIUNKNKEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly MultiValueConfigProperty<string> GRZDVAMDVLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly MultiValueConfigProperty<bool> JXXSZHQXNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MultiValueConfigProperty<bool> SJZAAUBJMYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MultiValueConfigProperty<bool> JCBTYAAPIFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly ZKXEXUFWDRP? CKMJJNTDUKM;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E540", Offset = "0x9B8D540", VA = "0x189B8E540")]
		public ZFHUINBMISJ(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, ZKXEXUFWDRP? portalInteractionFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E400", Offset = "0x9B8D400", VA = "0x189B8E400", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class JLEBDYNZGLO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public JLEBDYNZGLO DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B70600", Offset = "0x9B6F600", VA = "0x189B70600")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string QHIUNKNKEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly MultiValueConfigProperty<string> GRZDVAMDVLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly MultiValueConfigProperty<bool> JXXSZHQXNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly MultiValueConfigProperty<float> UBCVYMVHRYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly MultiValueConfigProperty<bool> DJTNOYKFLDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly MultiValueConfigProperty<bool> GAQEGRFDQFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MultiValueConfigProperty<bool> SJZAAUBJMYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly MultiValueConfigProperty<bool> GNVLWMCCYJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly MultiValueConfigProperty<float> XBUJNDARFQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ZKXEXUFWDRP? EBVPZDIDDTC;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B73D00", Offset = "0x9B72D00", VA = "0x189B73D00")]
		public JLEBDYNZGLO(string configName, MultiValueConfigProperty<string> interactionPrompt, MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<float> g, ZKXEXUFWDRP? interactionFilterOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B73BC0", Offset = "0x9B72BC0", VA = "0x189B73BC0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class BPOQUWFMVML : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public BPOQUWFMVML DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Func<bool> QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Func<bool> QLCKPFRISYN;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B88640", Offset = "0x9B87640", VA = "0x189B88640")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B86A40", Offset = "0x9B85A40", VA = "0x189B86A40")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B892F0", Offset = "0x9B882F0", VA = "0x189B892F0")]
			internal bool MNOQRTZBHNU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Dictionary<LocomotionFilterModes, string> DZOUGBLNCTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly MultiValueConfigProperty<bool> PZKFKKYRAXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MultiValueConfigProperty<bool> XWHJGYEPEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MultiValueConfigProperty<bool> YXXGOUYJAPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MultiValueConfigProperty<bool> EGDDAMXUBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MultiValueConfigProperty<string> KQMBTEMPTEW;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EE70", Offset = "0x9B6DE70", VA = "0x189B6EE70")]
		public BPOQUWFMVML(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> roleFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EC30", Offset = "0x9B6DC30", VA = "0x189B6EC30", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class YMFZARSXINZ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public YMFZARSXINZ DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9B81630", Offset = "0x9B80630", VA = "0x189B81630")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9B82890", Offset = "0x9B81890", VA = "0x189B82890")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MultiValueConfigProperty<bool> YPMZTSNXBFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly MultiValueConfigProperty<bool> UZJPEBRQHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ZKXEXUFWDRP? HAAMKEXZMJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly MultiValueConfigProperty<bool> OPYDLIKGNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly MultiValueConfigProperty<bool> LVGYBALMOBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly MultiValueConfigProperty<bool> YXXGOUYJAPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly FOKZUHVDJOX QLKAGEESAFG;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A330", Offset = "0x9B89330", VA = "0x189B8A330")]
		public YMFZARSXINZ(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, ZKXEXUFWDRP? playerInteractionFilter, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, FOKZUHVDJOX syncComponentOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A1E0", Offset = "0x9B891E0", VA = "0x189B8A1E0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class VNCZEXXVEBX : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public VNCZEXXVEBX DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Func<bool> QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public Func<bool> QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<bool> QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9B82180", Offset = "0x9B81180", VA = "0x189B82180")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B829D0", Offset = "0x9B819D0", VA = "0x189B829D0")]
			internal bool MNOQRTZBHNU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9B829D0", Offset = "0x9B819D0", VA = "0x189B829D0")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9B80F80", Offset = "0x9B7FF80", VA = "0x189B80F80")]
			internal bool MMJBIFJRCXS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9B80FE0", Offset = "0x9B7FFE0", VA = "0x189B80FE0")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly Dictionary<TriggerVolumeV1Mode, string> BSFHGRSGWSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MultiValueConfigProperty<TriggerVolumeV1Mode> TUAJRGZUBDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly bool SCTMFCSTBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly MultiValueConfigProperty<bool> QDHLSUZANMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly MultiValueConfigProperty<bool> OKVZHJSJRFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly MultiValueConfigProperty<string> PGBRJYQACVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly MultiValueConfigProperty<string> ZYCKZCBBLHY;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9B85790", Offset = "0x9B84790", VA = "0x189B85790")]
		public VNCZEXXVEBX(MultiValueConfigProperty<int> a, bool b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> filterTag, MultiValueConfigProperty<string> filterRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B85560", Offset = "0x9B84560", VA = "0x189B85560", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SXFFNGMSUUH : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public SXFFNGMSUUH DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9B76E50", Offset = "0x9B75E50", VA = "0x189B76E50")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9B77720", Offset = "0x9B76720", VA = "0x189B77720")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly MultiValueConfigProperty<bool> OKVZHJSJRFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly WBLREBYZKRV TWAZUTNVVQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly MultiValueConfigProperty<string> CJHILMXWVXF;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B83480", Offset = "0x9B82480", VA = "0x189B83480")]
		public SXFFNGMSUUH(MultiValueConfigProperty<bool> a, WBLREBYZKRV objectTagsConfig, MultiValueConfigProperty<string> filterByRole)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B83340", Offset = "0x9B82340", VA = "0x189B83340", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class CMSJKWKXQKS : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class BFGCHHTGJIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CMSJKWKXQKS DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BFGCHHTGJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DF80", Offset = "0x9B6CF80", VA = "0x189B6DF80")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly MultiValueConfigProperty<bool> OKVZHJSJRFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly MultiValueConfigProperty<bool> QLRKGZILHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> RTQQLGTAKXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ConfigProperty<IReadOnlyList<string>> JBTRJWHSNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly ConfigProperty<IReadOnlyList<string>>? NUETKYTOWWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly MultiValueConfigProperty<bool> CQLFAICEPUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> WNLYKUWPGQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly ConfigProperty<IReadOnlyList<string>> VUQWZKBEVPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ConfigProperty<IReadOnlyList<string>>? ZGNLSBWIWHI;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F2C0", Offset = "0x9B6E2C0", VA = "0x189B6F2C0")]
		public CMSJKWKXQKS(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<InteractionFilterMode> d, ConfigProperty<IReadOnlyList<string>> persistentPlayerTags, ConfigProperty<IReadOnlyList<string>>? runtimePlayerTags, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<InteractionFilterMode> f, ConfigProperty<IReadOnlyList<string>> persistentObjectTags, ConfigProperty<IReadOnlyList<string>>? runtimeObjectTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F180", Offset = "0x9B6E180", VA = "0x189B6F180", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
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
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		public ConfigProperty(Func<T> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class TPQYXFDDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class XCEMRAPCWST<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Func<a, b> NUJQONFOSLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ConfigProperty<a> MPBIHBVJBOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Func<b, a> OWVEZHWPVVG;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XCEMRAPCWST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x510A4E0", Offset = "0x51094E0", VA = "0x18510A4E0")]
			internal b NMLDHORQJVF()
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x510AEE0", Offset = "0x5109EE0", VA = "0x18510AEE0")]
			internal void TYECXXLWSWY(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F75440", Offset = "0x3F74440", VA = "0x183F75440")]
		public static ConfigProperty<U> To<U, T>(this ConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(ConfigProperty<U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class JKDVRVMVJKA : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public JKDVRVMVJKA DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> QKXDRYXLJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Action QLCKPFRISYN;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9B80F60", Offset = "0x9B7FF60", VA = "0x189B80F60")]
			internal bool QGRWFAZLENX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9B80740", Offset = "0x9B7F740", VA = "0x189B80740")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9B7FA50", Offset = "0x9B7EA50", VA = "0x189B7FA50")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9B80EF0", Offset = "0x9B7FEF0", VA = "0x189B80EF0")]
			internal bool MNTXPASYQZD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9B7FBE0", Offset = "0x9B7EBE0", VA = "0x189B7FBE0")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9B80E90", Offset = "0x9B7FE90", VA = "0x189B80E90")]
			internal void MNOQRTZBHNU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly (int, string)[] HEBHZHIBROX;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly Dictionary<int, string> ODFDMJGTKTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly int KFSZLHNOFTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly ZKXEXUFWDRP? LBDBURNBXMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ConfigProperty<int> QXLNVTDZFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Action<VPPBMKOGBVJ.MultiTogglePickerData> ILMLKWHXUWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly MultiValueConfigProperty<bool> ABWOVPOTBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly MultiValueConfigProperty<bool> QBDDWJFKIJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly VAQIEMQRQWD? NRVXGLASUYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly Func<Option<bool>> AKQKYCMPJWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly MultiValueConfigProperty<bool> QHKXSICTFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MultiValueConfigProperty<bool> NPLZAQPISDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Func<bool> DLZCDHCRQII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly RoomKeyConfig HXCNFHWWCGA;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B73A50", Offset = "0x9B72A50", VA = "0x189B73A50")]
		public JKDVRVMVJKA(int a, ZKXEXUFWDRP? additionalCostumeConfigOptions, ConfigProperty<int> b, Action<VPPBMKOGBVJ.MultiTogglePickerData> onOutfitFilterClick, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, VAQIEMQRQWD? playerRolesToAddData, Func<Option<bool>> hasPlayerEquipped, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, Func<bool> isLegacyRoom, RoomKeyConfig roomKeyConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B733D0", Offset = "0x9B723D0", VA = "0x189B733D0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class YEGKCASPICJ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly MultiValueConfigProperty<int> EXMNWLYNAQI;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public YEGKCASPICJ(MultiValueConfigProperty<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B89930", Offset = "0x9B88930", VA = "0x189B89930", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class YOGBKBBNRTU : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class PVEMMDQTAIS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public YOGBKBBNRTU DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public ConfigProperty<int[]> EPLTIYCXHHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public Func<bool> QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public Func<bool> JSQYJTUOEVI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public Func<bool> JSWFHAOLOGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<bool> DQHOUHIHDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Func<bool> JPVFWDBZCSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Func<bool> JQAMTJVWMDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public Func<bool> DQCHXAOJUBE;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public PVEMMDQTAIS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B7DAC0", Offset = "0x9B7CAC0", VA = "0x189B7DAC0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B7E810", Offset = "0x9B7D810", VA = "0x189B7E810")]
			internal bool MNECXGLGORC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9B7E270", Offset = "0x9B7D270", VA = "0x189B7E270")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9B7CC60", Offset = "0x9B7BC60", VA = "0x189B7CC60")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B7D1A0", Offset = "0x9B7C1A0", VA = "0x189B7D1A0")]
			internal void MMOIFMDOMJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9B7EFA0", Offset = "0x9B7DFA0", VA = "0x189B7EFA0")]
			internal bool ZTDQFZWQMKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9B7EF30", Offset = "0x9B7DF30", VA = "0x189B7EF30")]
			internal bool ZSYJITCTCYY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9B7CB10", Offset = "0x9B7BB10", VA = "0x189B7CB10")]
			internal bool FVYJJLGXVPW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9B7EE70", Offset = "0x9B7DE70", VA = "0x189B7EE70")]
			internal bool ZSTCLMIVTNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9B7EDB0", Offset = "0x9B7DDB0", VA = "0x189B7EDB0")]
			internal bool ZSNVOFOYKCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9B7E880", Offset = "0x9B7D880", VA = "0x189B7E880")]
			internal void MNOQRTZBHNU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B7CBD0", Offset = "0x9B7BBD0", VA = "0x189B7CBD0")]
			internal bool FWDQGSAVFBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9B7EC10", Offset = "0x9B7DC10", VA = "0x189B7EC10")]
			internal void MNTXPASYQZD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class PVJTJKKQJUB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public bool OBPXVALNFQW;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public PVJTJKKQJUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD5F620", Offset = "0xD5E620", VA = "0x180D5F620")]
			internal bool MLDLYQUGYHQ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class PUTYRQCYHMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public int RJFRQDFLKFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public PVEMMDQTAIS FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public PUTYRQCYHMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C690", Offset = "0x9B7B690", VA = "0x189B7C690")]
			internal bool MLISVXOEHSZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C700", Offset = "0x9B7B700", VA = "0x189B7C700")]
			internal void ZRNNBXTLOXN(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9B7CA60", Offset = "0x9B7BA60", VA = "0x189B7CA60")]
			internal bool ZRYAWLHGHUF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9B7CA00", Offset = "0x9B7BA00", VA = "0x189B7CA00")]
			internal string ZRSTZENIYIW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class PUZFOWWVQXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public bool THJJJFPAIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public PUTYRQCYHMA FWJCKDVNEOU;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public PUZFOWWVQXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9B7CAB0", Offset = "0x9B7BAB0", VA = "0x189B7CAB0")]
			internal bool ZRIGEQZOFME()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly IReadOnlyList<VoiceOption> PMPOVOPZVLV;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly IReadOnlyList<VoiceOption> CGDQOUJRFQI;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly IReadOnlyList<RolloffCurve> XGYFKWGCAXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly MultiValueConfigProperty<string> PIUBSFSHQJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly int TEASPBFEPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly MultiValueConfigProperty<float> KRUCEMNMPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly MultiValueConfigProperty<VoiceOption> BDNUVDXILYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly MultiValueConfigProperty<string> DZVABUIURVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly MultiValueConfigProperty<bool> QBSQNTEYEUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly MultiValueConfigProperty<bool> JDNXAVLOZOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly string ISDKOUJRDWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly MultiValueConfigProperty<bool>? CSZZLKVXXHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly MultiValueConfigProperty<bool>[] TYSZYJZEXOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly IReadOnlyList<string> CEUZLDYVXTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly IReadOnlyList<string> LDPHONIBDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly IReadOnlyList<bool> KJQVFUSKSPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly ConfigProperty<int[]>? VEBFWCOVHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Func<IEnumerable<int>> HCYWWUWCPTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Func<int, bool> OTAMCWXFODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly Func<int, string?> GUJQHERDIRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly Func<int, string?> BVPWAVWDUVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string YNUICLQURCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly MultiValueConfigProperty<bool> JUHVAUAMLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly MultiValueConfigProperty<float> DRUIEXWJRTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly MultiValueConfigProperty<RolloffCurve> DGPAWYBARXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly MultiValueConfigProperty<bool> USEMCJSKESR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly MultiValueConfigProperty<bool>? EBMSOFXCYVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly MultiValueConfigProperty<bool> ITLVYQQRUUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly MultiValueConfigProperty<bool> ASNWULXDUFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly MultiValueConfigProperty<bool>? ZFIYORTYJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly MultiValueConfigProperty<float>? XHNXYDVNROP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly bool MYBVEROCADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly MultiValueConfigProperty<int> TLSDHWRADZY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool WZQWCQUSRJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9B8A500", Offset = "0x9B89500", VA = "0x189B8A500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool XCEJUNXLUNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9B8A440", Offset = "0x9B89440", VA = "0x189B8A440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B8AA80", Offset = "0x9B89A80", VA = "0x189B8AA80")]
		private static string VJSVNHXJEFV(RolloffCurve a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8AFE0", Offset = "0x9B89FE0", VA = "0x189B8AFE0")]
		public YOGBKBBNRTU(MultiValueConfigProperty<string> instructions, int a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<VoiceOption> c, MultiValueConfigProperty<bool>? d, MultiValueConfigProperty<string> useContext, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, string aiSettingsInfoText, MultiValueConfigProperty<bool>? g, MultiValueConfigProperty<bool>[] functionEnablements, IReadOnlyList<string> functionEnablementNames, IReadOnlyList<string> functionEnablementDescriptions, IReadOnlyList<bool> functionEnablementVisibilities, ConfigProperty<int[]>? circuitsFunctionEnablements, Func<IEnumerable<int>> getAllCircuitsFunctionIds, Func<int, bool> getCircuitsFunctionExists, Func<int, string?> getCircuitsFunctionName, Func<int, string?> getCircuitsFunctionInvalidReason, string useSpatialAudioLabel, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<RolloffCurve> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool>? n, MultiValueConfigProperty<float>? o, bool p, MultiValueConfigProperty<int> q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A550", Offset = "0x9B89550", VA = "0x189B8A550", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class SDJPIAZICKS : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public SDJPIAZICKS DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B84520", Offset = "0x9B83520", VA = "0x189B84520")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly MultiValueConfigProperty<bool> WESBSNGFFVF;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public SDJPIAZICKS(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9B82E50", Offset = "0x9B81E50", VA = "0x189B82E50", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class QIKSIWWQUPD : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public QIKSIWWQUPD DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9B84820", Offset = "0x9B83820", VA = "0x189B84820")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly MultiValueConfigProperty<bool> LJJJWENARGP;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public QIKSIWWQUPD(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F150", Offset = "0x9B7E150", VA = "0x189B7F150", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class AWAAAXUJXBD : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly string NAZSBQHGXFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly MultiValueConfigProperty<bool> UJVHUATAOTU;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DCA0", Offset = "0x9B6CCA0", VA = "0x189B6DCA0")]
		public AWAAAXUJXBD(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB80", Offset = "0x9B6CB80", VA = "0x189B6DB80", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class VYPOSWTKHSM : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public VYPOSWTKHSM DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F630", Offset = "0x9B7E630", VA = "0x189B7F630")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly MultiValueConfigProperty<bool> QAICJISLABT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly MultiValueConfigProperty<bool> CQWQAFKJWET;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FCF0", Offset = "0x9B6ECF0", VA = "0x189B6FCF0")]
		public VYPOSWTKHSM(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B89360", Offset = "0x9B88360", VA = "0x189B89360", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class YKYBZWSZPFZ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public YKYBZWSZPFZ DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public Func<bool> QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9B77F40", Offset = "0x9B76F40", VA = "0x189B77F40")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9B79210", Offset = "0x9B78210", VA = "0x189B79210")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9B77DC0", Offset = "0x9B76DC0", VA = "0x189B77DC0")]
			internal bool MMJBIFJRCXS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly ZKXEXUFWDRP EBVPZDIDDTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly Func<bool> PQCGBZOXZMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly Action SOPSZWUCMMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly bool VUXTJXRLOEB;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A160", Offset = "0x9B89160", VA = "0x189B8A160")]
		public YKYBZWSZPFZ(int a, ZKXEXUFWDRP b, Action c, Func<bool> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A020", Offset = "0x9B89020", VA = "0x189B8A020", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class YKTKUDOUKGX : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public sealed class EJPPDGDCSCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public readonly MultiValueConfigProperty<float> AWWLZIITCXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public readonly MultiValueConfigProperty<float> JMZLGCLWCCC;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FCF0", Offset = "0x9B6ECF0", VA = "0x189B6FCF0")]
			public EJPPDGDCSCG(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public sealed class AAJQXYEQQAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public readonly MultiValueConfigProperty<float> ZEOLTHJMRBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public readonly MultiValueConfigProperty<float> EIZCPUMUBCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public readonly MultiValueConfigProperty<bool> GRPILZJLAJW;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D450", Offset = "0x9B6C450", VA = "0x189B6D450")]
			public AAJQXYEQQAG(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class VNKZRHYGRMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public readonly MultiValueConfigProperty<float> SBPDCICNCEA;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
			public VNKZRHYGRMJ(MultiValueConfigProperty<float> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public YKTKUDOUKGX DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9B70E90", Offset = "0x9B6FE90", VA = "0x189B70E90")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x9B71570", Offset = "0x9B70570", VA = "0x189B71570")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9B70350", Offset = "0x9B6F350", VA = "0x189B70350")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x9B705A0", Offset = "0x9B6F5A0", VA = "0x189B705A0")]
			internal void MMOIFMDOMJB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly MultiValueConfigProperty<int> GTBXTARFIRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly MultiValueConfigProperty<int> WHHVVJVDCKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly EJPPDGDCSCG UANAUTQXYWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly AAJQXYEQQAG AGPYHFUQUPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly VNKZRHYGRMJ QYWTLLVLXLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MultiValueConfigProperty<bool> XYWCEHTWWXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly PMRKXZQEUZT LZKJBGKLLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly PMRKXZQEUZT RQYPJSZQRNH;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B89D20", Offset = "0x9B88D20", VA = "0x189B89D20")]
		public YKTKUDOUKGX(MultiValueConfigProperty<float> vehicleMass, MultiValueConfigProperty<int> boostFuelCapacity, EJPPDGDCSCG a, AAJQXYEQQAG b, VNKZRHYGRMJ c, MultiValueConfigProperty<bool> canFrontWheelsSteer, PMRKXZQEUZT d, PMRKXZQEUZT e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B89A20", Offset = "0x9B88A20", VA = "0x189B89A20", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class PMRKXZQEUZT : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MultiValueConfigProperty<bool> MPGNIUALBTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly MultiValueConfigProperty<bool> HZJRAETMWWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly MultiValueConfigProperty<float> SJTPMIEVMGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly MultiValueConfigProperty<float> EJFQTREJCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly MultiValueConfigProperty<float> KWDTVLMAJQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private readonly MultiValueConfigProperty<float> HDGQNTBMLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private readonly MultiValueConfigProperty<float> LFQXSTZSHYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly MultiValueConfigProperty<float> LFMFHFRGZRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly MultiValueConfigProperty<float> HFUYEPXQLTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly MultiValueConfigProperty<float> TRWTZOWGMYO;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C150", Offset = "0x9B7B150", VA = "0x189B7C150")]
		public PMRKXZQEUZT(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B6F0", Offset = "0x9B7A6F0", VA = "0x189B7B6F0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class NFITNOWGTKL : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public NFITNOWGTKL DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9B8D400", Offset = "0x9B8C400", VA = "0x189B8D400")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly MultiValueConfigProperty<float> PJMVEDUDEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly MultiValueConfigProperty<float> UWFYJIALIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly MultiValueConfigProperty<float> WDQPCBUYLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly MultiValueConfigProperty<float> KOQGNMPYGPX;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A080", Offset = "0x9B79080", VA = "0x189B7A080")]
		public NFITNOWGTKL(MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B79F40", Offset = "0x9B78F40", VA = "0x189B79F40", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class JOYIBCETOTQ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly MultiValueConfigProperty<bool> RFBBGUATEPI;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public JOYIBCETOTQ(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B73E90", Offset = "0x9B72E90", VA = "0x189B73E90", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class VJNKLAAQWAL : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public VJNKLAAQWAL DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B77240", Offset = "0x9B76240", VA = "0x189B77240")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B77780", Offset = "0x9B76780", VA = "0x189B77780")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly PIGFNDQWTPY GFTNUPSSWBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly JOYIBCETOTQ BAROOZFWHJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly MultiValueConfigProperty<bool> YFKYQVLOZIQ;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B854E0", Offset = "0x9B844E0", VA = "0x189B854E0")]
		public VJNKLAAQWAL(PIGFNDQWTPY a, JOYIBCETOTQ b, MultiValueConfigProperty<bool> hideProjector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B85310", Offset = "0x9B84310", VA = "0x189B85310", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class AZANVQWNRYC : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public AZANVQWNRYC DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F510", Offset = "0x9B7E510", VA = "0x189B7F510")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F900", Offset = "0x9B7E900", VA = "0x189B7F900")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly MultiValueConfigProperty<bool> LGNSKAAQBHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Option<bool> CZJZLFYGLLV;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DE30", Offset = "0x9B6CE30", VA = "0x189B6DE30")]
		public AZANVQWNRYC(Option<bool> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DD00", Offset = "0x9B6CD00", VA = "0x189B6DD00", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class XFGZKFMGJYE : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public XFGZKFMGJYE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9B772A0", Offset = "0x9B762A0", VA = "0x189B772A0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly IReadOnlyDictionary<PhysicsMode, string> AGIOSQNTJQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly MultiValueConfigProperty<PhysicsMode> GEYYHBXJBJY;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B89700", Offset = "0x9B88700", VA = "0x189B89700")]
		public XFGZKFMGJYE(int a, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B894A0", Offset = "0x9B884A0", VA = "0x189B894A0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class ARLTRZNDBRU : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public ARLTRZNDBRU DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9B84670", Offset = "0x9B83670", VA = "0x189B84670")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly MultiValueConfigProperty<bool> YFYNQGUPXLX;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public ARLTRZNDBRU(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DA00", Offset = "0x9B6CA00", VA = "0x189B6DA00", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class PIGFNDQWTPY : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly string LGKCDCSGQQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly Action IQSBJZVTSWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public readonly Func<Option<bool>> YCCBFRHSQOB;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xDF3980", Offset = "0xDF2980", VA = "0x180DF3980")]
		public PIGFNDQWTPY(string a, Action b, Func<Option<bool>> hasRecordableData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B5A0", Offset = "0x9B7A5A0", VA = "0x189B7B5A0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B540", Offset = "0x9B7A540", VA = "0x189B7B540")]
		[CompilerGenerated]
		private bool RSLPZFIGGLX()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class RoomKeyConfig : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public RoomKeyConfig DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F430", Offset = "0x9B7E430", VA = "0x189B7F430")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F8B0", Offset = "0x9B7E8B0", VA = "0x189B7F8B0")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly OXPMZPOONGK SPGXVBFZVWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly Func<InventionPermission> LGBYUAQKTAX;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		public RoomKeyConfig(OXPMZPOONGK roomKeyOptions, Func<InventionPermission> getLowestInventionPermission)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B82CD0", Offset = "0x9B81CD0", VA = "0x189B82CD0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class OXPMZPOONGK : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public OXPMZPOONGK DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9B87FC0", Offset = "0x9B86FC0", VA = "0x189B87FC0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9B88E90", Offset = "0x9B87E90", VA = "0x189B88E90")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public readonly bool BNZVUZGBZXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly string MDGUBJRJXMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Func<bool> FJZLZLIPNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly Func<bool> KTCJMMDJCSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly Action? DXAIUKIVPRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly MultiValueConfigProperty<Guid> EDVGXKMZOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly Action<VPPBMKOGBVJ.RoomKeyPickerData> ZRQXQTNOSVR;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AA40", Offset = "0x9B79A40", VA = "0x189B7AA40")]
		public OXPMZPOONGK(Option<bool> isTrialInvention, Func<bool> a, Func<bool> b, Action? onCreateKeyClick, MultiValueConfigProperty<Guid> equipLockKeyId, Action<VPPBMKOGBVJ.RoomKeyPickerData> c, [Optional] string? lockLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A930", Offset = "0x9B79930", VA = "0x189B7A930", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class VAQIEMQRQWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public readonly IReadOnlyList<(Guid, string)> HDJLDELIFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public readonly ConfigProperty<IReadOnlyCollection<Guid>> IFWWVKYBDVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public readonly Action<VPPBMKOGBVJ.MultiTogglePickerData> NOOFAFLKRKL;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9B84BB0", Offset = "0x9B83BB0", VA = "0x189B84BB0")]
		public VAQIEMQRQWD(IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<VPPBMKOGBVJ.MultiTogglePickerData> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class FMPETRXXVYV : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public FMPETRXXVYV DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9B789A0", Offset = "0x9B779A0", VA = "0x189B789A0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly MultiValueConfigProperty<int> GIGYSUTTUZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly MultiValueConfigProperty<int> OCZJJZUJGEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly MultiValueConfigProperty<int> ODPEBUCBIMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly MultiValueConfigProperty<int> ODJXENIDZBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly MultiValueConfigProperty<string> FVTDXNSZIAO;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9B70060", Offset = "0x9B6F060", VA = "0x189B70060")]
		public FMPETRXXVYV(MultiValueConfigProperty<int> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<int> d, MultiValueConfigProperty<string> stateName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FF20", Offset = "0x9B6EF20", VA = "0x189B6FF20", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class PPKLQGSRLTO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public PPKLQGSRLTO DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B86C20", Offset = "0x9B85C20", VA = "0x189B86C20")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly MultiValueConfigProperty<float> ZGIDEMSTSHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly MultiValueConfigProperty<bool> ZPQCJJNQBRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly MultiValueConfigProperty<TexturedQuadMaterialType> CWRITGRSATD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly FOKZUHVDJOX? LIAYXTDIRRC;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly IReadOnlyList<TexturedQuadMaterialType> FTVTMMLMKVP;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C5E0", Offset = "0x9B7B5E0", VA = "0x189B7C5E0")]
		public PPKLQGSRLTO(MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<TexturedQuadMaterialType> c, FOKZUHVDJOX? syncComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C300", Offset = "0x9B7B300", VA = "0x189B7C300", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class VDSWUIKCEWL : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public VDSWUIKCEWL DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9B84370", Offset = "0x9B83370", VA = "0x189B84370")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly MultiValueConfigProperty<bool> ZGFDNLVPLVP;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public VDSWUIKCEWL(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9B84C30", Offset = "0x9B83C30", VA = "0x189B84C30", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class LWVLLFOTGHT : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public LWVLLFOTGHT DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9B7FC90", Offset = "0x9B7EC90", VA = "0x189B7FC90")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static readonly IReadOnlyDictionary<TrailWidthCurveTypes, string> NHQQYLLVYRU;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly IReadOnlyDictionary<TrailGradientTypes, string> EVQZLZYIDBE;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private static readonly IReadOnlyDictionary<TrailMaterialTypes, string> IQCGFYLGUEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly MultiValueConfigProperty<bool> MDLSISSAIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly MultiValueConfigProperty<bool> OYNPEOUDMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly MultiValueConfigProperty<float> AIIZCVGFDCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly MultiValueConfigProperty<float> DTQHZWFNCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly MultiValueConfigProperty<float> AQQOIYCYFYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly MultiValueConfigProperty<float> RLNAEKDNJZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly MultiValueConfigProperty<TrailWidthCurveTypes> BOXDSNHQGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly MultiValueConfigProperty<TrailGradientTypes> YSDFGWSJUZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly MultiValueConfigProperty<TrailMaterialTypes> AIQSGBTDQUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly OEVDPFSZBEO? FIZRHZVNWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly FOKZUHVDJOX TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9B76B80", Offset = "0x9B75B80", VA = "0x189B76B80")]
		public LWVLLFOTGHT(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<TrailWidthCurveTypes> g, MultiValueConfigProperty<TrailGradientTypes> h, MultiValueConfigProperty<TrailMaterialTypes> i, OEVDPFSZBEO? colorableOptions, FOKZUHVDJOX syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B76600", Offset = "0x9B75600", VA = "0x189B76600", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class YQZNGYHDCWO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class LLBQWFUEPKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public YQZNGYHDCWO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public (Color32 x, Color32 y, Color32 z) DDLAJFXGVYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Func<bool> QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Func<bool> QKXDRYXLJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Action QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Action QKMPXLJQQQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LLBQWFUEPKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9B75460", Offset = "0x9B74460", VA = "0x189B75460")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9B756A0", Offset = "0x9B746A0", VA = "0x189B756A0")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9B76580", Offset = "0x9B75580", VA = "0x189B76580")]
			internal bool MNOQRTZBHNU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x9B74A10", Offset = "0x9B73A10", VA = "0x189B74A10")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x9B765C0", Offset = "0x9B755C0", VA = "0x189B765C0")]
			internal bool MNTXPASYQZD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9B752F0", Offset = "0x9B742F0", VA = "0x189B752F0")]
			internal void MMOIFMDOMJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9B75F50", Offset = "0x9B74F50", VA = "0x189B75F50")]
			internal void MNECXGLGORC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9B763F0", Offset = "0x9B753F0", VA = "0x189B763F0")]
			internal void MNJJUNFDYCL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly Func<bool>? EATVURRRSZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly Func<bool> IJHGBPFVPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly Func<bool> EGDMQUMODLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly MultiValueConfigProperty<float> NOIXTUQMVHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private readonly MultiValueConfigProperty<float> NODQWNWPLWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private readonly MultiValueConfigProperty<float> NNYJZHCSCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private readonly MultiValueConfigProperty<float> VHFOQJBWVAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly MultiValueConfigProperty<float> VHKVNPVUELV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly MultiValueConfigProperty<float> VHQCKWPRNXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly Func<bool> ULPPGANTTDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly Func<bool> ELFWWPWZXPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly MultiValueConfigProperty<float> GLOPLZNCZUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly MultiValueConfigProperty<float> GLTWJGHAJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly MultiValueConfigProperty<float> GLEBRLZIGXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly MultiValueConfigProperty<float> QHJIEDVTFPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly MultiValueConfigProperty<float> QHEBGXBVWEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly MultiValueConfigProperty<float> QHTVYRJNYMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Func<bool> OYKZNAMJTWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Func<bool> ZEXQFBFWEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly MultiValueConfigProperty<float> MVRPTSLBCRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly MultiValueConfigProperty<float> MVWWQZEYMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly MultiValueConfigProperty<float> MVHBZEXGJVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly MultiValueConfigProperty<float> HCWWTCSMPIO;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B8CE80", Offset = "0x9B8BE80", VA = "0x189B8CE80")]
		public YQZNGYHDCWO(Func<bool> supportsTranslation, Func<bool> isWorldPositionVisible, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, Func<bool> supportsRotation, Func<bool> isWorldRotationVisible, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<float> j, MultiValueConfigProperty<float> k, MultiValueConfigProperty<float> l, Func<bool> supportsScaling, Func<bool> supportsDeformation, MultiValueConfigProperty<float> m, MultiValueConfigProperty<float> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, [Optional] Func<bool>? isFoldoutVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B8CCD0", Offset = "0x9B8BCD0", VA = "0x189B8CCD0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class DEOHNKZSJEB : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public DEOHNKZSJEB DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9B8DB90", Offset = "0x9B8CB90", VA = "0x189B8DB90")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static readonly IReadOnlyDictionary<GrabberAttachmentMode, string> OFMSPIYVZUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly MultiValueConfigProperty<GrabberAttachmentMode> LSFSWODDKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private readonly MultiValueConfigProperty<bool> VJKKJQFJGHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private readonly FOKZUHVDJOX TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F6A0", Offset = "0x9B6E6A0", VA = "0x189B6F6A0")]
		public DEOHNKZSJEB(MultiValueConfigProperty<GrabberAttachmentMode> a, MultiValueConfigProperty<bool> b, FOKZUHVDJOX syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F450", Offset = "0x9B6E450", VA = "0x189B6F450", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class JVQBMXDQMCD : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly IEnumerable<VYGWQGCQFRP> SCWDPAFNVSH;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public JVQBMXDQMCD(IEnumerable<VYGWQGCQFRP> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9B73FD0", Offset = "0x9B72FD0", VA = "0x189B73FD0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class MAAQHFDPHEE : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public MAAQHFDPHEE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9B78560", Offset = "0x9B77560", VA = "0x189B78560")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9B790A0", Offset = "0x9B780A0", VA = "0x189B790A0")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9B77BE0", Offset = "0x9B76BE0", VA = "0x189B77BE0")]
			internal void MMJBIFJRCXS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public readonly Option<bool> NIYHTLKZMQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private readonly MultiValueConfigProperty<float> DLTGYLACCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private readonly MultiValueConfigProperty<bool> VBMAJCKMXCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private readonly MultiValueConfigProperty<bool> CHFGRIQFGVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly MultiValueConfigProperty<bool> CVCCZSATGIZ;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9B77B20", Offset = "0x9B76B20", VA = "0x189B77B20")]
		public MAAQHFDPHEE(Option<bool> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9B77900", Offset = "0x9B76900", VA = "0x189B77900", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ONWSOPLMRJR : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public ONWSOPLMRJR DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9B87560", Offset = "0x9B86560", VA = "0x189B87560")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static readonly Dictionary<int, string> XZJHMLZLMWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly MultiValueConfigProperty<int> JMNLEOJUVOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private readonly MultiValueConfigProperty<float> AHLNHDEKVSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private readonly MultiValueConfigProperty<bool> GMRVXZSXSQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly MultiValueConfigProperty<bool> WCFKDWZYOJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly MultiValueConfigProperty<bool> PAIEDCWIMQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly MultiValueConfigProperty<int> LWFGQHQGBDW;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A660", Offset = "0x9B79660", VA = "0x189B7A660")]
		public ONWSOPLMRJR(MultiValueConfigProperty<int> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A430", Offset = "0x9B79430", VA = "0x189B7A430", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class DJCEYLRMSGO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public DJCEYLRMSGO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9B81030", Offset = "0x9B80030", VA = "0x189B81030")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9B82950", Offset = "0x9B81950", VA = "0x189B82950")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly Dictionary<int, string> XZJHMLZLMWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly Action? GOCYYUDOJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly int ISTFAWIZELY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly MultiValueConfigProperty<int> JMNLEOJUVOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly MultiValueConfigProperty<float> BVAFQIXAVCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private readonly MultiValueConfigProperty<bool> LJRTCPMVCVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly MultiValueConfigProperty<bool> PAIEDCWIMQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly MultiValueConfigProperty<int> LWFGQHQGBDW;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FB00", Offset = "0x9B6EB00", VA = "0x189B6FB00")]
		public DJCEYLRMSGO(Action? openAnimationControls, int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<int> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F8D0", Offset = "0x9B6E8D0", VA = "0x189B6F8D0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class FFTEMPDVQQH : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public FFTEMPDVQQH DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9B76D40", Offset = "0x9B75D40", VA = "0x189B76D40")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x9B774C0", Offset = "0x9B764C0", VA = "0x189B774C0")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly MAAQHFDPHEE ZJFHVBWVFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly MultiValueConfigProperty<float> HZQRWHDQSTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private readonly Option<UnityEngine.Vector2> JBBGXISCLXB;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FEA0", Offset = "0x9B6EEA0", VA = "0x189B6FEA0")]
		public FFTEMPDVQQH(MAAQHFDPHEE acceleratedMovementOptions, MultiValueConfigProperty<float> a, Option<UnityEngine.Vector2> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FD60", Offset = "0x9B6ED60", VA = "0x189B6FD60", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class BXSMQFGTJWD : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public BXSMQFGTJWD DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x9B87CA0", Offset = "0x9B86CA0", VA = "0x189B87CA0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x9B88F00", Offset = "0x9B87F00", VA = "0x189B88F00")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9B867D0", Offset = "0x9B857D0", VA = "0x189B867D0")]
			internal void MMJBIFJRCXS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private readonly MAAQHFDPHEE ZJFHVBWVFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private readonly MultiValueConfigProperty<float> HZQRWHDQSTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private readonly MultiValueConfigProperty<float> IKJFSQXIBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private readonly MultiValueConfigProperty<float> HKBWNMFZGOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private readonly MultiValueConfigProperty<float> AOLRLURPRNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private readonly Option<UnityEngine.Vector2> JBBGXISCLXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private readonly Option<float> JZMVVCDAHAO;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F090", Offset = "0x9B6E090", VA = "0x189B6F090")]
		public BXSMQFGTJWD(MAAQHFDPHEE acceleratedMovementOptions, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, Option<UnityEngine.Vector2> c, MultiValueConfigProperty<float> d, Option<float> e, MultiValueConfigProperty<float> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EF50", Offset = "0x9B6DF50", VA = "0x189B6EF50", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class TEIYDBADKDB : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public TEIYDBADKDB DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9B84970", Offset = "0x9B83970", VA = "0x189B84970")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private readonly MAAQHFDPHEE ZJFHVBWVFOE;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public TEIYDBADKDB(MAAQHFDPHEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9B83910", Offset = "0x9B82910", VA = "0x189B83910", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class FQTFXEICDFN : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public FQTFXEICDFN DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9B78050", Offset = "0x9B77050", VA = "0x189B78050")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly Option<float> IYYQKIXZZFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private readonly MultiValueConfigProperty<float> DXSNNAYZOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private readonly MultiValueConfigProperty<float> MPIWJRCCNTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private readonly MultiValueConfigProperty<float> WVQLDZCCIXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private readonly MAAQHFDPHEE ZJFHVBWVFOE;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9B702A0", Offset = "0x9B6F2A0", VA = "0x189B702A0")]
		public FQTFXEICDFN(Option<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MAAQHFDPHEE acceleratedMovementOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B70140", Offset = "0x9B6F140", VA = "0x189B70140", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HPYJXXQKACI : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class ACFWOTACWWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public HPYJXXQKACI DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ACFWOTACWWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D690", Offset = "0x9B6C690", VA = "0x189B6D690")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly Dictionary<GlassPaneShapeType, string> ZPIBBFMLHKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private readonly MultiValueConfigProperty<float> GLCWOEQVGUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly Func<bool> CASQIMAUBTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly MultiValueConfigProperty<GlassPaneShapeType> BYXDVSSPQXP;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9B722F0", Offset = "0x9B712F0", VA = "0x189B722F0")]
		public HPYJXXQKACI(MultiValueConfigProperty<float> a, Func<bool> isAllConfigurableShapes, MultiValueConfigProperty<int> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9B720C0", Offset = "0x9B710C0", VA = "0x189B720C0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class PYWPXRCYJIA : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public PYWPXRCYJIA DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9B842B0", Offset = "0x9B832B0", VA = "0x189B842B0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private readonly ZKXEXUFWDRP TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public PYWPXRCYJIA(ZKXEXUFWDRP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F010", Offset = "0x9B7E010", VA = "0x189B7F010", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class DWVQRZAPFZT
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public static readonly IReadOnlyDictionary<InteractionFilterMode, string> HGQAOVHEBEC;
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class SMNPEDXEUST : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public SMNPEDXEUST DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9B8E390", Offset = "0x9B8D390", VA = "0x189B8E390")]
			internal bool TKJCBYICVLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9B8E1E0", Offset = "0x9B8D1E0", VA = "0x189B8E1E0")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9B8D200", Offset = "0x9B8C200", VA = "0x189B8D200")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9B8D340", Offset = "0x9B8C340", VA = "0x189B8D340")]
			internal void MMOIFMDOMJB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private readonly MultiValueConfigProperty<bool> AVUOMRCUGEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> AOSLQUSKENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private readonly VAQIEMQRQWD? HTKAQGRTBWB;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9B832B0", Offset = "0x9B822B0", VA = "0x189B832B0")]
		public SMNPEDXEUST(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<InteractionFilterMode> c, VAQIEMQRQWD? rolesData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B82F90", Offset = "0x9B81F90", VA = "0x189B82F90", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class MJLKQJMSEZC : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public MJLKQJMSEZC DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9B8E320", Offset = "0x9B8D320", VA = "0x189B8E320")]
			internal bool TKJCBYICVLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9B8E180", Offset = "0x9B8D180", VA = "0x189B8E180")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private readonly string NAZSBQHGXFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private readonly MultiValueConfigProperty<bool> AVUOMRCUGEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> AOSLQUSKENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private readonly WBLREBYZKRV? YAQUEPTOIRX;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B79960", Offset = "0x9B78960", VA = "0x189B79960")]
		public MJLKQJMSEZC(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<InteractionFilterMode> b, WBLREBYZKRV tagsOptions, string primaryLabel = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9B795D0", Offset = "0x9B785D0", VA = "0x189B795D0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class RZSARWDRMGB : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public RZSARWDRMGB DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9B77460", Offset = "0x9B76460", VA = "0x189B77460")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private readonly string NAZSBQHGXFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private readonly MultiValueConfigProperty<InteractionFilterMode> AOSLQUSKENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private readonly WBLREBYZKRV? YAQUEPTOIRX;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9B82C50", Offset = "0x9B81C50", VA = "0x189B82C50")]
		public RZSARWDRMGB(MultiValueConfigProperty<InteractionFilterMode> filterMode, WBLREBYZKRV a, string b = "Tags")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9B829F0", Offset = "0x9B819F0", VA = "0x189B829F0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface VPPBMKOGBVJ
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
				[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0xF429E0", Offset = "0xF419E0", VA = "0x180F429E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Action<int> ColorSetter
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool AllowCustomColors
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xD18620", Offset = "0xD17620", VA = "0x180D18620")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public bool AllowDefaultColor
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x1272380", Offset = "0x1271380", VA = "0x181272380")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x13E7A70", Offset = "0x13E6A70", VA = "0x1813E7A70")]
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
				[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public Func<int> MaterialGetter
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xF429E0", Offset = "0xF419E0", VA = "0x180F429E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public Action<int> MaterialSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Func<int> ColorGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool AllowDefaultMaterial
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0xD0FCE0", Offset = "0xD0ECE0", VA = "0x180D0FCE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3F0", Offset = "0xD0E3F0", VA = "0x180D0F3F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool ForceTransparentQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x16101C0", Offset = "0x160F1C0", VA = "0x1816101C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x160F4D0", Offset = "0x160E4D0", VA = "0x18160F4D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool CameraLit
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x1BD1F70", Offset = "0x1BD0F70", VA = "0x181BD1F70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x1E122C0", Offset = "0x1E112C0", VA = "0x181E122C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public Action<Guid> RoleSetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0xF429E0", Offset = "0xF419E0", VA = "0x180F429E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public string Title
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
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
				[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public Func<Guid> KeyGetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0xF429E0", Offset = "0xF419E0", VA = "0x180F429E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public Action<Guid> KeySetter
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
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
				[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public Func<IReadOnlyCollection<int>> GetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0xF429E0", Offset = "0xF419E0", VA = "0x180F429E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public Action<IReadOnlyCollection<int>> SetActiveIndexes
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Func<IReadOnlyList<string>> GetValueNames
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class JJTVHAIIOEC<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public IReadOnlyDictionary<a, string> BPABCFJAYHO;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JJTVHAIIOEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6767C60", Offset = "0x6766C60", VA = "0x186767C60")]
			internal string PVLDTYQINYD(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class AJVLRFQQYAF<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			public Func<a, string> EZSKHBOAJSL;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public AJVLRFQQYAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x72EAE00", Offset = "0x72E9E00", VA = "0x1872EAE00")]
			internal string PVLDTYQINYD(object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class MNNINZKDBVO<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public IReadOnlyList<(a, string)> BPABCFJAYHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Dictionary<a, int> FGOJQQMNIYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Func<a, int> QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Func<int, a> QKMPXLJQQQM;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MNNINZKDBVO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x70234A0", Offset = "0x70224A0", VA = "0x1870234A0")]
			internal IReadOnlyList<string> BXCJNQNPSNY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x7023770", Offset = "0x7022770", VA = "0x187023770")]
			internal IReadOnlyCollection<int> BXHQKXHNBZH(IReadOnlyCollection<a> values)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x7022EE0", Offset = "0x7021EE0", VA = "0x187022EE0")]
			internal int BWHHYPMAGUO(a a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x7022E00", Offset = "0x7021E00", VA = "0x187022E00")]
			internal IReadOnlyCollection<a> BVWUEBYFNXW(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x7023020", Offset = "0x7022020", VA = "0x187023020")]
			internal a BWMOVWFXQFX(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class MLTHIYPQCOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public IReadOnlyList<(int, string)> BPABCFJAYHO;

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MLTHIYPQCOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B79A00", Offset = "0x9B78A00", VA = "0x189B79A00")]
			internal IReadOnlyList<string> XTOIZNOAAQY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9B79B30", Offset = "0x9B78B30", VA = "0x189B79B30")]
			internal IReadOnlyCollection<int> XTTPWUHXKCH(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9B79D20", Offset = "0x9B78D20", VA = "0x189B79D20")]
			internal int XUTYJCDKFHA(IReadOnlyCollection<int> a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class MLYOGFJNLZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public int JNWDLXQRNSD;

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MLYOGFJNLZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9B79E00", Offset = "0x9B78E00", VA = "0x189B79E00")]
			internal bool XUJKOOPPMKI(IndexValuePair<(int, string)> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class MMDVDMDKVLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public int JNWDLXQRNSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public MLTHIYPQCOI FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MMDVDMDKVLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x9B79E10", Offset = "0x9B78E10", VA = "0x189B79E10")]
			internal void XSITPYYPWAW(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class TBMIUWRZTOR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public IReadOnlyList<(Guid, string)> BPABCFJAYHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public Dictionary<Guid, int> FGOJQQMNIYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public Func<Guid, int> QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public Func<int, Guid> QKMPXLJQQQM;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public TBMIUWRZTOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9B83510", Offset = "0x9B82510", VA = "0x189B83510")]
			internal IReadOnlyList<string> PEOWPNRMZRI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B83640", Offset = "0x9B82640", VA = "0x189B83640")]
			internal IReadOnlyCollection<int> PEUDMULKJCR(IReadOnlyCollection<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B837E0", Offset = "0x9B827E0", VA = "0x189B837E0")]
			internal int PFJYEOTCLKS(Guid a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x9B83710", Offset = "0x9B82710", VA = "0x189B83710")]
			internal IReadOnlyCollection<Guid> PEZKKBFHSOA(IReadOnlyCollection<int> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9B83840", Offset = "0x9B82840", VA = "0x189B83840")]
			internal Guid PFPFBVMZUWB(int a)
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9B85B30", Offset = "0x9B84B30", VA = "0x189B85B30", Slot = "0")]
		VPPBMKOGBVJ EMVKPFLTCII(bool a, Action b, [Optional] Action? falseAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9B85A80", Offset = "0x9B84A80", VA = "0x189B85A80", Slot = "1")]
		VPPBMKOGBVJ Add(ZKXEXUFWDRP? provider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VPPBMKOGBVJ NNNNOMOSMUN();

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VPPBMKOGBVJ LCFWTBYWICQ(string a, int b, Action c, [Optional] Func<bool>? isVisibleGetter, bool d = true, InventionPermission e = InventionPermission.EditAndSave, string f = "");

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VPPBMKOGBVJ? IPGNBJLNZAP(string primaryLabel, MultiValueConfigProperty<string> property, int a = 1000, [Optional] string? b, [Optional] Func<bool>? c, ContentType d = ContentType.Standard, [Optional] string? e);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		VPPBMKOGBVJ HHTXFVOWSDS(string a, MultiValueConfigProperty<string> property, int b = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] string? infoText);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		VPPBMKOGBVJ XTMLSGQENQM(string a, MultiValueConfigProperty<int> property, [Optional] int? b, [Optional] int? c, [Optional] string? unitLabel, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		VPPBMKOGBVJ? MSNCHYRNJQC(string primaryLabel, float a, float b, MultiValueConfigProperty<float> property, int c = 2, [Optional] string? d, [Optional] string? e, [Optional] Func<bool>? f, [Optional] string? g);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		VPPBMKOGBVJ? BLJTQIKWPER(string primaryLabel, MultiValueConfigProperty<float> property, [Optional] Func<bool>? a, [Optional] Func<bool>? b, [Optional] Color? c, [Optional] float? d, [Optional] float? e, bool f = false, [Optional] string? g, [Optional] string? h);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B85F50", Offset = "0x9B84F50", VA = "0x189B85F50", Slot = "9")]
		VPPBMKOGBVJ SQRGHOXYQTS(string primaryLabel, MultiValueConfigProperty<float> a, MultiValueConfigProperty<float> b, MultiValueConfigProperty<float> c, [Optional] (Color x, Color y, Color z)? bgColors, [Optional] Func<bool>? isVisibleGetter, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		VPPBMKOGBVJ? UZPFVLOIZHH(string primaryLabel, Func<bool> isActiveGetter, Action<bool> isActiveSetter, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e, [Optional] Func<bool>? f, [Optional] Func<string>? warningTextGetter, [Optional] Func<string>? warningTitleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "11")]
		VPPBMKOGBVJ? HOCRCXKFVCX(string primaryLabel, MultiValueConfigProperty<bool> property, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d, [Optional] Func<bool>? e);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x40DA3D0", Offset = "0x40D93D0", VA = "0x1840DA3D0", Slot = "12")]
		VPPBMKOGBVJ PGLDDUBSNUW<a>(string a, MultiValueConfigProperty<a> property, IReadOnlyDictionary<a, string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool c = true, bool d = false) where a : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x40DA710", Offset = "0x40D9710", VA = "0x1840DA710", Slot = "13")]
		VPPBMKOGBVJ PGLDDUBSNUW<b>(string a, MultiValueConfigProperty<b> property, IReadOnlyList<b> b, Func<b, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false) where b : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "14")]
		VPPBMKOGBVJ PGLDDUBSNUW(string a, MultiValueConfigProperty<object> property, IReadOnlyList<object> b, Func<object, string> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter, [Optional] string? infoTextTitle, [Optional] string? infoText, bool d = true, bool e = false);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "15")]
		VPPBMKOGBVJ? SZJJCVXSSZT(Action panelAction, [Optional] string? a, [Optional] string? b, [Optional] string? c, [Optional] Func<bool>? d);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "16")]
		VPPBMKOGBVJ XTWSBNWNQSN(string a, ConfigProperty<IReadOnlyList<string>> persistentProperty, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeProperty, [Optional] string? secondaryLabel, [Optional] Func<string, bool>? tagValidator, int b = 1000, [Optional] Func<bool>? isModifiedGetter);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "17")]
		VPPBMKOGBVJ? TFHXVRXTCET(string primaryLabel, Action? a, [Optional] Func<bool>? b, [Optional] Func<bool>? c);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "18")]
		VPPBMKOGBVJ NBGYDFXCPLU(string a, string b, Action c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? isInteractableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "19")]
		VPPBMKOGBVJ TWCFFWHFLMU(string a, ConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "20")]
		VPPBMKOGBVJ TWCFFWHFLMU(string a, MultiValueConfigProperty<int> property, Action<ColorPickerData> b, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		VPPBMKOGBVJ OSZTVHHCMEQ(string a, ConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		VPPBMKOGBVJ OSZTVHHCMEQ(string a, MultiValueConfigProperty<int> property, Func<int> b, Action<MaterialPickerData> c, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		VPPBMKOGBVJ TLTPLWPRTFA(string a, ConfigProperty<Guid> property, Action<RoomRolePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		VPPBMKOGBVJ YHBUFDDBZVT(string a, MultiValueConfigProperty<Guid> property, Action<RoomKeyPickerData> b, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		VPPBMKOGBVJ URDATKKBSJI(string a, Func<IReadOnlyList<string>> b, ConfigProperty<IReadOnlyCollection<int>> property, Action<MultiTogglePickerData> c, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x40DBE10", Offset = "0x40DAE10", VA = "0x1840DBE10", Slot = "26")]
		VPPBMKOGBVJ URDATKKBSJI<T>(string a, IReadOnlyList<(T, string)> items, ConfigProperty<IReadOnlyCollection<T>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9B85B80", Offset = "0x9B84B80", VA = "0x189B85B80", Slot = "27")]
		VPPBMKOGBVJ OXESEJZACSU(string a, IReadOnlyList<(int, string)> items, ConfigProperty<int> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9B863E0", Offset = "0x9B853E0", VA = "0x189B863E0", Slot = "28")]
		VPPBMKOGBVJ TLTPLWPRTFA(string a, IReadOnlyList<(Guid, string)> items, ConfigProperty<IReadOnlyCollection<Guid>> property, Action<MultiTogglePickerData> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "29")]
		VPPBMKOGBVJ NSHQPPWUBCJ(string a, [Optional] Func<bool>? isVisibleGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public interface ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TZSAZBPRLUM(VPPBMKOGBVJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class IJSJUMPPOHM : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public IJSJUMPPOHM DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9B87AC0", Offset = "0x9B86AC0", VA = "0x189B87AC0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly MultiValueConfigProperty<float> WTNYIPMQCHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly System.Numerics.Vector2 ZNJGQGJSDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private readonly MultiValueConfigProperty<float> MEDEZQOQRDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly System.Numerics.Vector2 YENFEGPLVRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly KQKVSIGUTIM IJMROXIBVHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly OEVDPFSZBEO? TKDJUAVYYBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly FOKZUHVDJOX ELUVSQCZYVB;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B731D0", Offset = "0x9B721D0", VA = "0x189B731D0")]
		public IJSJUMPPOHM(MultiValueConfigProperty<float> a, System.Numerics.Vector2 b, MultiValueConfigProperty<float> c, System.Numerics.Vector2 d, KQKVSIGUTIM sandboxDynamicLightOptions, OEVDPFSZBEO? sandboxColorableConfig, FOKZUHVDJOX syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B73090", Offset = "0x9B72090", VA = "0x189B73090", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class ZXBHBXBZCMO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public ZXBHBXBZCMO DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9B844C0", Offset = "0x9B834C0", VA = "0x189B844C0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly KQKVSIGUTIM TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public ZXBHBXBZCMO(KQKVSIGUTIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E620", Offset = "0x9B8D620", VA = "0x189B8E620", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class KQKVSIGUTIM : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private readonly MultiValueConfigProperty<bool> IEXMKAPABYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private readonly MultiValueConfigProperty<float> MZIXZNZPEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly System.Numerics.Vector2 RCURHNLLJUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private readonly MultiValueConfigProperty<float> JDYGDOBOWYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private readonly System.Numerics.Vector2 RRFJVLQRFVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private readonly MultiValueConfigProperty<float> JJBVSHTIXPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private readonly System.Numerics.Vector2 ALZMVPZKCWL;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B747F0", Offset = "0x9B737F0", VA = "0x189B747F0")]
		public KQKVSIGUTIM(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<float> d, System.Numerics.Vector2 e, MultiValueConfigProperty<float> f, System.Numerics.Vector2 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B74470", Offset = "0x9B73470", VA = "0x189B74470", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B74460", Offset = "0x9B73460", VA = "0x189B74460")]
		[CompilerGenerated]
		private bool TGJTAEMWODL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B74440", Offset = "0x9B73440", VA = "0x189B74440")]
		[CompilerGenerated]
		private bool TGEMCXSZESC()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class LILHXWSRHTR : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public LILHXWSRHTR DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x9B77190", Offset = "0x9B76190", VA = "0x189B77190")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private readonly KQKVSIGUTIM NWRDXOBOWHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly OEVDPFSZBEO? FIZRHZVNWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private readonly FOKZUHVDJOX TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xDF3980", Offset = "0xDF2980", VA = "0x180DF3980")]
		public LILHXWSRHTR(KQKVSIGUTIM a, OEVDPFSZBEO? colorableOptions, FOKZUHVDJOX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B748D0", Offset = "0x9B738D0", VA = "0x189B748D0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class OAFVGZJHXLR : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public OAFVGZJHXLR DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x9B847C0", Offset = "0x9B837C0", VA = "0x189B847C0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private readonly OVMATOQRXJZ TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public OAFVGZJHXLR(OVMATOQRXJZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A2F0", Offset = "0x9B792F0", VA = "0x189B7A2F0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class OVMATOQRXJZ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private readonly MultiValueConfigProperty<float> WTNYIPMQCHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private readonly System.Numerics.Vector2 ZNJGQGJSDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private readonly KQKVSIGUTIM NWRDXOBOWHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private readonly OEVDPFSZBEO? FIZRHZVNWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private readonly FOKZUHVDJOX? TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A890", Offset = "0x9B79890", VA = "0x189B7A890")]
		public OVMATOQRXJZ(MultiValueConfigProperty<float> angle, System.Numerics.Vector2 a, KQKVSIGUTIM dynamicLightOptions, OEVDPFSZBEO? b, FOKZUHVDJOX? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A760", Offset = "0x9B79760", VA = "0x189B7A760", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class JJZDNRQQEUU : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public JJZDNRQQEUU DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F490", Offset = "0x9B7E490", VA = "0x189B7F490")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private readonly OVMATOQRXJZ NWRDXOBOWHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly AWAAAXUJXBD PBNJVMIBMFI;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		public JJZDNRQQEUU(OVMATOQRXJZ a, AWAAAXUJXBD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9B73290", Offset = "0x9B72290", VA = "0x189B73290", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class DISVEYZOCMF : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public DISVEYZOCMF DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F290", Offset = "0x9B7E290", VA = "0x189B7F290")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private MultiValueConfigProperty<float> BDTQVRQOKYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private Dictionary<float, string> GYPLFQLYRMM;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F870", Offset = "0x9B6E870", VA = "0x189B6F870")]
		public DISVEYZOCMF(MultiValueConfigProperty<float> a, Dictionary<float, string> labelMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9B6F730", Offset = "0x9B6E730", VA = "0x189B6F730", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class VHPKQPGPOHL : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public sealed class OTALPHVTAGX
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public string AZGBUIWNJKT
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public bool[] GWUKDDXIBVD
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public int UUPWKKAQIEI
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float PAHPTUXCXCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xD60CF0", Offset = "0xD5FCF0", VA = "0x180D60CF0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0xD60B40", Offset = "0xD5FB40", VA = "0x180D60B40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int JQCTFOCWOYF
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0xD0CA80", Offset = "0xD0BA80", VA = "0x180D0CA80")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0xD0CAA0", Offset = "0xD0BAA0", VA = "0x180D0CAA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public OTALPHVTAGX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public sealed class MQDEOVPZSAK
		{
			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public string AZGBUIWNJKT
			{
				[Cpp2IlInjected.Token(Token = "0x6000216")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000217")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public ConfigProperty<int> LPXTJPZIKIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00")]
				[CompilerGenerated]
				get
				{
					return default(ConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x6000219")]
				[Cpp2IlInjected.Address(RVA = "0x727FFB0", Offset = "0x727EFB0", VA = "0x18727FFB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public MultiValueConfigProperty<int> NLCFJQSWBVE
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x2E2D9D0", Offset = "0x2E2C9D0", VA = "0x182E2D9D0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<int>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x9B79F00", Offset = "0x9B78F00", VA = "0x189B79F00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public MultiValueConfigProperty<float> KGAYDLOYNUK
			{
				[Cpp2IlInjected.Token(Token = "0x600021C")]
				[Cpp2IlInjected.Address(RVA = "0x2E2D9B0", Offset = "0x2E2C9B0", VA = "0x182E2D9B0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x9B79F20", Offset = "0x9B78F20", VA = "0x189B79F20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public MultiValueConfigProperty<float> QMNXSLTPZLK
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x6FB3ED0", Offset = "0x6FB2ED0", VA = "0x186FB3ED0")]
				[CompilerGenerated]
				get
				{
					return default(MultiValueConfigProperty<float>);
				}
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x6FB3FC0", Offset = "0x6FB2FC0", VA = "0x186FB3FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MQDEOVPZSAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public VHPKQPGPOHL DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int JTOWIRFOFQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9B86AB0", Offset = "0x9B85AB0", VA = "0x189B86AB0")]
			internal void MMOIFMDOMJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class VQHDFJGPGTP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			public int PMHRBJOKSGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public VQBWICMRXIG FWYXBYDFGWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public Func<OTALPHVTAGX, bool> QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public Func<int, int> QKMPXLJQQQM;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQHDFJGPGTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1DD0", Offset = "0x9BA0DD0", VA = "0x189BA1DD0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9BA2900", Offset = "0x9BA1900", VA = "0x189BA2900")]
			internal bool MNOQRTZBHNU(OTALPHVTAGX a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9BA2750", Offset = "0x9BA1750", VA = "0x189BA2750")]
			internal int MNJJUNFDYCL(int a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class VPRINOYXELO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public int JWFHZBEFYIK;

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VPRINOYXELO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0310", Offset = "0x9B9F310", VA = "0x189BA0310")]
			internal bool MLDLYQUGYHQ(OTALPHVTAGX a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> JJRPNKZXIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private readonly IReadOnlyList<MQDEOVPZSAK> BOTBUUNDZXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private readonly IReadOnlyList<OTALPHVTAGX> FJXRAJWFAUQ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x890AD00", Offset = "0x8909D00", VA = "0x18890AD00")]
		public VHPKQPGPOHL(int a, Action<VPPBMKOGBVJ.ColorPickerData> b, IReadOnlyList<MQDEOVPZSAK> c, IReadOnlyList<OTALPHVTAGX> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9B84D70", Offset = "0x9B83D70", VA = "0x189B84D70", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class TSNIRGOHIYU : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class JRFIKRCKNGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public TSNIRGOHIYU DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JRFIKRCKNGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x9B98910", Offset = "0x9B97910", VA = "0x189B98910")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x9B990D0", Offset = "0x9B980D0", VA = "0x189B990D0")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private readonly ConfigProperty<int> VSAIEXCSPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> JJRPNKZXIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private readonly MultiValueConfigProperty<float> MZIXZNZPEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private readonly MultiValueConfigProperty<float> HJRHGTCJKSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private readonly MultiValueConfigProperty<float> BJNZWSBBAZR;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9B9EAB0", Offset = "0x9B9DAB0", VA = "0x189B9EAB0")]
		public TSNIRGOHIYU(int a, ConfigProperty<int> b, Action<VPPBMKOGBVJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E970", Offset = "0x9B9D970", VA = "0x189B9E970", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class KWZZZXVHYLM : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class HYHHLZFIJXM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public KWZZZXVHYLM DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Action QLSFGZZAVGO;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public HYHHLZFIJXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9B97050", Offset = "0x9B96050", VA = "0x189B97050")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x9B96F20", Offset = "0x9B95F20", VA = "0x189B96F20")]
			internal void MLISVXOEHSZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly System.Numerics.Vector2 ADANHUOZHVS;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly System.Numerics.Vector2 EVFMPRLZOTO;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static System.Numerics.Vector2 KBWHOBDYHXF;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static System.Numerics.Vector2 OKIMXOISZSJ;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static System.Numerics.Vector2 ZVCDGOLSMDO;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static System.Numerics.Vector2 FKHSJKMHJVS;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static System.Numerics.Vector2 ZBQJJEYUXIK;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static System.Numerics.Vector2 VBYPOHORMWW;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static System.Numerics.Vector2 EWOVHELNABO;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static System.Numerics.Vector2 ZRCQWNHRUOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private readonly ConfigProperty<int> VSAIEXCSPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> JJRPNKZXIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private readonly MultiValueConfigProperty<float> GQERACEBJHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private readonly MultiValueConfigProperty<float> SOAXUQYWDAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private readonly MultiValueConfigProperty<float> JLOESQUNUOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private readonly MultiValueConfigProperty<float> QQZBLSPGCUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private readonly MultiValueConfigProperty<float> KLLBJSGMUOG;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9B999E0", Offset = "0x9B989E0", VA = "0x189B999E0")]
		public KWZZZXVHYLM(int a, ConfigProperty<int> b, Action<VPPBMKOGBVJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9B995A0", Offset = "0x9B985A0", VA = "0x189B995A0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9B99520", Offset = "0x9B98520", VA = "0x189B99520")]
		private static float JBFACQIEIFU(float a, System.Numerics.Vector2 b, System.Numerics.Vector2 c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public sealed class BRLSGXQKLZL : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public BRLSGXQKLZL DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x9B99F20", Offset = "0x9B98F20", VA = "0x189B99F20")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x9B9A710", Offset = "0x9B99710", VA = "0x189B9A710")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private readonly ConfigProperty<int> VSAIEXCSPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> JJRPNKZXIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private readonly MultiValueConfigProperty<float> ISBKYKABGQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private readonly MultiValueConfigProperty<float> QJFOKZIJPCF;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9B91D60", Offset = "0x9B90D60", VA = "0x189B91D60")]
		public BRLSGXQKLZL(int a, ConfigProperty<int> b, Action<VPPBMKOGBVJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9B91C20", Offset = "0x9B90C20", VA = "0x189B91C20", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public sealed class WJMUJCWZQCI : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public WJMUJCWZQCI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0580", Offset = "0x9B9F580", VA = "0x189BA0580")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1BA0", Offset = "0x9BA0BA0", VA = "0x189BA1BA0")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private readonly MultiValueConfigProperty<int> LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private readonly MultiValueConfigProperty<float> EUWUVWZJMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private readonly MultiValueConfigProperty<float> CKZINIIZBRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private readonly MultiValueConfigProperty<bool> YHXKNSLWGLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private readonly ConfigProperty<Guid> TBYAUBRLDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly Action<VPPBMKOGBVJ.RoomRolePickerData> YAVAVCQNAPM;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9BA3120", Offset = "0x9BA2120", VA = "0x189BA3120")]
		public WJMUJCWZQCI(int a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, ConfigProperty<Guid> f, Action<VPPBMKOGBVJ.RoomRolePickerData> onExclusiveToRoleClick)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2FE0", Offset = "0x9BA1FE0", VA = "0x189BA2FE0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class NWZOWQKIUHB : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public NWZOWQKIUHB DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x9B93E10", Offset = "0x9B92E10", VA = "0x189B93E10")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x9B94980", Offset = "0x9B93980", VA = "0x189B94980")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private readonly ConfigProperty<int> FKCINCVAZZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private readonly ConfigProperty<int> QMJWQFRBIWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private readonly ConfigProperty<int> JPWUZSTHCHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private readonly ConfigProperty<int> YRPRBKVVUOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private readonly ConfigProperty<int> KFUQRJWBKQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> JJRPNKZXIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private readonly MultiValueConfigProperty<float> GTNOWLNCTNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private readonly MultiValueConfigProperty<float> SGFYGBHFQPY;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B4F0", Offset = "0x9B9A4F0", VA = "0x189B9B4F0")]
		public NWZOWQKIUHB(int a, ConfigProperty<int> b, ConfigProperty<int> c, ConfigProperty<int> d, ConfigProperty<int> e, ConfigProperty<int> f, Action<VPPBMKOGBVJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B3B0", Offset = "0x9B9A3B0", VA = "0x189B9B3B0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class TRLBBRTLKFR : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class BBRTNTVYVYU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public TRLBBRTLKFR DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BBRTNTVYVYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9B90410", Offset = "0x9B8F410", VA = "0x189B90410")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x9B913E0", Offset = "0x9B903E0", VA = "0x189B913E0")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private readonly ConfigProperty<int> VSAIEXCSPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> JJRPNKZXIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private readonly MultiValueConfigProperty<float> CSQRLWKMZTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private readonly MultiValueConfigProperty<float> TAZJXNPYLBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private readonly MultiValueConfigProperty<float> GAYXQOQWFSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private readonly MultiValueConfigProperty<float> HVHJUVPNQLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private readonly MultiValueConfigProperty<float> MSTQHZITAYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private readonly MultiValueConfigProperty<float> UANSRKTRZIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private readonly MultiValueConfigProperty<bool> OUOCQUDBBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private readonly MultiValueConfigProperty<bool> NSGJZIJATFC;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E7C0", Offset = "0x9B9D7C0", VA = "0x189B9E7C0")]
		public TRLBBRTLKFR(int a, ConfigProperty<int> b, Action<VPPBMKOGBVJ.ColorPickerData> onColorClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<float> g, MultiValueConfigProperty<float> h, MultiValueConfigProperty<bool> i, MultiValueConfigProperty<bool> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E680", Offset = "0x9B9D680", VA = "0x189B9E680", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public readonly struct MultiValueConfigProperty<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class TALFOLXVHMJ<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public IEnumerable<b> GMLQDMLIOTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public Func<b, T> IMGRGNVSQKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public Action<b, T> NSEAOXZHOBB;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public TALFOLXVHMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD96C0", Offset = "0x7BD86C0", VA = "0x187BD96C0")]
			internal Option<T> GBFGYUHKUZQ()
			{
				return default(Option<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7BDA2F0", Offset = "0x7BD92F0", VA = "0x187BDA2F0")]
			internal void GBKNWBBIEKZ(T a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class VZUUDLSZGPU<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public T JWFHZBEFYIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public TALFOLXVHMJ<b> FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VZUUDLSZGPU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8072960", Offset = "0x8071960", VA = "0x188072960")]
			internal void GAUTEGTQCCY(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class HGOHUZHWDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public MultiValueConfigProperty<T> MPBIHBVJBOZ;

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x654AFD0", Offset = "0x6549FD0", VA = "0x18654AFD0")]
			internal Option<object> KKLHOUABKRF()
			{
				return default(Option<object>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x654A860", Offset = "0x6549860", VA = "0x18654A860")]
			internal void KKGARNGEBFW(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class WCJYXUDOXMK<b> where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public Func<b, T> IMGRGNVSQKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public T TAXNRHNMEXY;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public WCJYXUDOXMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x87632F0", Offset = "0x87622F0", VA = "0x1887632F0")]
			internal bool CPDBUQWTUGD(b a)
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
		[Cpp2IlInjected.Address(RVA = "0x3A00C40", Offset = "0x39FFC40", VA = "0x183A00C40")]
		public static MultiValueConfigProperty<T> Create<U>(IEnumerable<U> objects, Func<U, T> getter, Action<U, T> setter, Func<bool>? isModified) where U : notnull
		{
			return default(MultiValueConfigProperty<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7256B90", Offset = "0x7255B90", VA = "0x187256B90")]
		public static implicit operator MultiValueConfigProperty<object>(MultiValueConfigProperty<T> prop)
		{
			return default(MultiValueConfigProperty<object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3A01980", Offset = "0x3A00980", VA = "0x183A01980")]
		private static Option<T> IXJYSGURNKH<U>(IEnumerable<U> a, Func<U, T> b) where U : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		internal MultiValueConfigProperty(Func<Option<T>> getter, Action<T> setter, Func<bool>? isModified)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class DIQWLSMIMTN
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[CompilerGenerated]
		private sealed class SZVKWRQDFEI<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public IEnumerable<a> GMLQDMLIOTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public Func<a, bool> XJZQLTCLHVR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public Func<a, bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public SZVKWRQDFEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7A94E50", Offset = "0x7A93E50", VA = "0x187A94E50")]
			internal bool WNLYPIHEKEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x7A94FD0", Offset = "0x7A93FD0", VA = "0x187A94FD0")]
			internal bool WNRFMPBBTPP(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class XCEMRAPCWST<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public MultiValueConfigProperty<a> MPBIHBVJBOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public Func<a, b> NUJQONFOSLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public Func<b, a> OWVEZHWPVVG;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XCEMRAPCWST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x510A440", Offset = "0x5109440", VA = "0x18510A440")]
			internal Option<b> NMLDHORQJVF()
			{
				return default(Option<b>);
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x510AC60", Offset = "0x5109C60", VA = "0x18510AC60")]
			internal void TYECXXLWSWY(b a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class XJFHWFZXXQX<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public ConfigProperty<a> MPBIHBVJBOZ;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XJFHWFZXXQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x5114010", Offset = "0x5113010", VA = "0x185114010")]
			internal Option<a> KXNBWMCRCBQ()
			{
				return default(Option<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x12D5390", Offset = "0x12D4390", VA = "0x1812D5390")]
			internal void NOSGJASOEEZ(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x38E8EC0", Offset = "0x38E7EC0", VA = "0x1838E8EC0")]
		public static MultiValueConfigProperty<U> TUTIORIADIE<U, T>(this IEnumerable<T> a, Func<T, U> b, Action<T, U> c, [Optional] Func<T, bool>? isModified) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x38E97F0", Offset = "0x38E87F0", VA = "0x1838E97F0")]
		public static MultiValueConfigProperty<U> To<U, T>(this MultiValueConfigProperty<T> prop, Func<T, U> getConverter, Func<U, T> setConverter) where U : notnull where T : notnull
		{
			return default(MultiValueConfigProperty<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x38E8AC0", Offset = "0x38E7AC0", VA = "0x1838E8AC0")]
		public static MultiValueConfigProperty<a?> TUTIORIADIE<a>(this ConfigProperty<a> prop)
		{
			return default(MultiValueConfigProperty<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class DBJKGLKBGKI : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public DBJKGLKBGKI DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9BA5720", Offset = "0x9BA4720", VA = "0x189BA5720")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly IReadOnlyList<NavMeshGenerationMode> HZHAGEFUXCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private readonly MultiValueConfigProperty<NavMeshGenerationMode> BIKVMBXPYNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9B92340", Offset = "0x9B91340", VA = "0x189B92340")]
		private static string QIUZIFWBCQZ(NavMeshGenerationMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9B925C0", Offset = "0x9B915C0", VA = "0x189B925C0")]
		public DBJKGLKBGKI(MultiValueConfigProperty<NavMeshGenerationMode> a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9B923D0", Offset = "0x9B913D0", VA = "0x189B923D0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class CPFVBRYOTTN : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public CPFVBRYOTTN DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9B9FDF0", Offset = "0x9B9EDF0", VA = "0x189B9FDF0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private readonly QWBPTMJFCAD TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public CPFVBRYOTTN(QWBPTMJFCAD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9B92200", Offset = "0x9B91200", VA = "0x189B92200", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class QWBPTMJFCAD : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private readonly Action UTPBKVZHCZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private readonly Func<bool> FJGQHSAYIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private readonly Action EXBEUIJOXIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private readonly Action UWIEEYPVKMA;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x113C300", Offset = "0x113B300", VA = "0x18113C300")]
		public QWBPTMJFCAD(Action a, Func<bool> b, Action c, Action d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9B9D250", Offset = "0x9B9C250", VA = "0x189B9D250", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9B9D220", Offset = "0x9B9C220", VA = "0x189B9D220")]
		[CompilerGenerated]
		private bool DNCPCJINKSO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9B9D220", Offset = "0x9B9C220", VA = "0x189B9D220")]
		[CompilerGenerated]
		private bool DNHVZQCKUDX()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class OOAMRMXECAO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public OOAMRMXECAO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9B9D480", Offset = "0x9B9C480", VA = "0x189B9D480")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B9D9E0", Offset = "0x9B9C9E0", VA = "0x189B9D9E0")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private readonly IReadOnlyDictionary<int, string> CXFXPSWPYVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private readonly MultiValueConfigProperty<int> QMSWYGJVTFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private readonly MultiValueConfigProperty<bool> UWWEXGOCKRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private readonly MultiValueConfigProperty<bool> ECEGZXCFCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private readonly MultiValueConfigProperty<float> XZLPBETHRXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private readonly MultiValueConfigProperty<float> HTEVRNIXRFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly OEVDPFSZBEO? TKDJUAVYYBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private readonly FOKZUHVDJOX? ELUVSQCZYVB;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9B9BA40", Offset = "0x9B9AA40", VA = "0x189B9BA40")]
		public OOAMRMXECAO(IReadOnlyDictionary<int, string>? effectsDict, MultiValueConfigProperty<int> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, OEVDPFSZBEO? sandboxColorableConfig, FOKZUHVDJOX? syncedComponentConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B900", Offset = "0x9B9A900", VA = "0x189B9B900", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class UGEAECTMMAM : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public UGEAECTMMAM DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9BA53A0", Offset = "0x9BA43A0", VA = "0x189BA53A0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class YYOIKQJXOFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public string NBCJBLUHHXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ConfigProperty<string> JOHJUUXYKDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public YYTPHXDUXQN FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYOIKQJXOFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9BA4F20", Offset = "0x9BA3F20", VA = "0x189BA4F20")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x9BA4DA0", Offset = "0x9BA3DA0", VA = "0x189BA4DA0")]
			internal void MMJBIFJRCXS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly bool CVZXZRCCIDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly IReadOnlyList<ConfigProperty<string>> BAJUKBKTKGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly int ATLNTTRUBVX;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0090", Offset = "0x9B9F090", VA = "0x189BA0090")]
		public UGEAECTMMAM(int a, bool b, IReadOnlyList<ConfigProperty<string>> messages, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B9FF40", Offset = "0x9B9EF40", VA = "0x189B9FF40", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class KIUQPPXWUVK : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public KIUQPPXWUVK DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B9C790", Offset = "0x9B9B790", VA = "0x189B9C790")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly KTZVRHZGFLQ TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10A82A0", Offset = "0x10A72A0", VA = "0x1810A82A0")]
		public KIUQPPXWUVK(int a, KTZVRHZGFLQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B99200", Offset = "0x9B98200", VA = "0x189B99200", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class KTZVRHZGFLQ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public KTZVRHZGFLQ DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x9BA5930", Offset = "0x9BA4930", VA = "0x189BA5930")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9BA5AB0", Offset = "0x9BA4AB0", VA = "0x189BA5AB0")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private readonly bool CVZXZRCCIDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private readonly string NAZSBQHGXFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private readonly ConfigProperty<string> JOHJUUXYKDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private readonly int NCQKACQEELQ;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B994A0", Offset = "0x9B984A0", VA = "0x189B994A0")]
		public KTZVRHZGFLQ(bool a, string b, ConfigProperty<string> message, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B99350", Offset = "0x9B98350", VA = "0x189B99350", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class XTXYUCOVVMY : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public XTXYUCOVVMY DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public Action QKXDRYXLJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public Func<bool> QKRWUSDOABV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public Action<bool> QKMPXLJQQQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public Func<bool> JRAVFRRJHIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public Action JRGCCYLGQTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public Action QLXMEGSYERX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public Action<bool> JQQHLEDOOLW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public Action JQVOIKXLXXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public Action QLSFGZZAVGO;

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x9B92EA0", Offset = "0x9B91EA0", VA = "0x189B92EA0")]
			internal bool FOULHQQQTBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B950D0", Offset = "0x9B940D0", VA = "0x189B950D0")]
			internal bool UKMWNZMTERB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x9B92E70", Offset = "0x9B91E70", VA = "0x189B92E70")]
			internal void CZYNCTQGSRQ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x9B95F00", Offset = "0x9B94F00", VA = "0x189B95F00")]
			internal bool TNFRNNBKXRU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9B951D0", Offset = "0x9B941D0", VA = "0x189B951D0")]
			internal void MNOQRTZBHNU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9B959A0", Offset = "0x9B949A0", VA = "0x189B959A0")]
			internal void MNTXPASYQZD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x9B950D0", Offset = "0x9B940D0", VA = "0x189B950D0")]
			internal bool MNECXGLGORC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x9B95110", Offset = "0x9B94110", VA = "0x189B95110")]
			internal void MNJJUNFDYCL(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9B92EE0", Offset = "0x9B91EE0", VA = "0x189B92EE0")]
			internal void MLDLYQUGYHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x9B961C0", Offset = "0x9B951C0", VA = "0x189B961C0")]
			internal bool ZRNNBXTLOXN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9B95FD0", Offset = "0x9B94FD0", VA = "0x189B95FD0")]
			internal void ZRIGEQZOFME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x9B933C0", Offset = "0x9B923C0", VA = "0x189B933C0")]
			internal void MLISVXOEHSZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9B966A0", Offset = "0x9B956A0", VA = "0x189B966A0")]
			internal void ZRYAWLHGHUF(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x9B96200", Offset = "0x9B95200", VA = "0x189B96200")]
			internal void ZRSTZENIYIW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class JRFIKRCKNGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public XTXYUCOVVMY DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public PhysicsModelEnumFlags DJFSHYXUJGC;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JRFIKRCKNGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9B98890", Offset = "0x9B97890", VA = "0x189B98890")]
			internal bool HGWIZRBFYTG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9B988D0", Offset = "0x9B978D0", VA = "0x189B988D0")]
			internal void HHBPWXVDIEP(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly IReadOnlyList<CollisionMode> JVHFXCVSYEA;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly IReadOnlyList<CollisionLayerEnum> WQUDYDIHRYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private readonly bool XDBNIRKQXLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private readonly ConfigProperty<CollisionMode> BVEDSAMIENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly ConfigProperty<CollisionLayerEnum> OJXLOOVMUSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly ConfigProperty<float> BURZJPYKLTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly Func<PhysicsModelEnumFlags, bool> OJLYLKDCOTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private readonly Action<PhysicsModelEnumFlags, bool> HNGYJPONOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private readonly ConfigProperty<float>? MRLMEFFVRVC;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9BA48F0", Offset = "0x9BA38F0", VA = "0x189BA48F0")]
		private static string OGYUVOMGOOD(CollisionMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BA4AC0", Offset = "0x9BA3AC0", VA = "0x189BA4AC0")]
		private static string XWXCXXZUGZL(CollisionLayerEnum a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9BA4CC0", Offset = "0x9BA3CC0", VA = "0x189BA4CC0")]
		public XTXYUCOVVMY(bool a, ConfigProperty<CollisionMode> b, ConfigProperty<CollisionLayerEnum> c, ConfigProperty<float> d, Func<PhysicsModelEnumFlags, bool> hasFlag, Action<PhysicsModelEnumFlags, bool> setFlag, [Optional] ConfigProperty<float>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9BA4980", Offset = "0x9BA3980", VA = "0x189BA4980", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9BA4750", Offset = "0x9BA3750", VA = "0x189BA4750")]
		private MultiValueConfigProperty<bool> FCAERRTSUKG(PhysicsModelEnumFlags a)
		{
			return default(MultiValueConfigProperty<bool>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class DCVJFPZWJKR : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public DCVJFPZWJKR DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B9A270", Offset = "0x9B99270", VA = "0x189B9A270")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9B9A840", Offset = "0x9B99840", VA = "0x189B9A840")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private static readonly IReadOnlyList<GrabbableMode> SUAXCZZDLXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private readonly MultiValueConfigProperty<bool> YFJEOVQLFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private readonly MultiValueConfigProperty<GrabbableMode> JWOJIEBSQNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private readonly MultiValueConfigProperty<bool> ULZUQRQIQWR;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B92750", Offset = "0x9B91750", VA = "0x189B92750")]
		private static string WFOZJLCJXPF(GrabbableMode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D450", Offset = "0x9B6C450", VA = "0x189B6D450")]
		public DCVJFPZWJKR(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<GrabbableMode> b, MultiValueConfigProperty<bool> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B92610", Offset = "0x9B91610", VA = "0x189B92610", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class UUHLTYKTMUT : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public UUHLTYKTMUT DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Func<bool> QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0B20", Offset = "0x9B9FB20", VA = "0x189BA0B20")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9BA19D0", Offset = "0x9BA09D0", VA = "0x189BA19D0")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0540", Offset = "0x9B9F540", VA = "0x189BA0540")]
			internal bool MMOIFMDOMJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x9BA04E0", Offset = "0x9B9F4E0", VA = "0x189BA04E0")]
			internal void MMJBIFJRCXS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private readonly Option<bool> AYSLDETXXZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private readonly MultiValueConfigProperty<string> ACBKEEQTANZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly Func<int> AYXPIBZCVRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private readonly MultiValueConfigProperty<bool> VGXAZNGSLRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly MultiValueConfigProperty<bool> KQKCPLFSOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly YQZNGYHDCWO? IECKENHSGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly WBLREBYZKRV? YSRWADLBPPF;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0230", Offset = "0x9B9F230", VA = "0x189BA0230")]
		public UUHLTYKTMUT(Option<bool> a, MultiValueConfigProperty<string> name, Func<int> currentSelectionCount, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, YQZNGYHDCWO? transformConfig, WBLREBYZKRV? tagsConfigOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9BA00F0", Offset = "0x9B9F0F0", VA = "0x189BA00F0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class HHYRWXJKVUT : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public HHYRWXJKVUT DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Func<int> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x9B9CA40", Offset = "0x9B9BA40", VA = "0x189B9CA40")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x9B9D1F0", Offset = "0x9B9C1F0", VA = "0x189B9D1F0")]
			internal int MMYVZZRJFFT()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private readonly MultiValueConfigProperty<int> VSAIEXCSPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> ZIAOZEBZXWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private readonly MultiValueConfigProperty<int> XGHPAODSBAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private readonly Action<VPPBMKOGBVJ.MaterialPickerData> FHMJQWBJWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private readonly MultiValueConfigProperty<float> FUFLACEBJRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private readonly MultiValueConfigProperty<float> VYGHNVZJAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private readonly MultiValueConfigProperty<float> VYBAQPFLQVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private readonly MultiValueConfigProperty<float> VXVTTILOHJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly MultiValueConfigProperty<bool> DYSSEGEKXEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private readonly Func<bool> BHJKDSMSDHM;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B969F0", Offset = "0x9B959F0", VA = "0x189B969F0")]
		public HHYRWXJKVUT(MultiValueConfigProperty<int> a, Action<VPPBMKOGBVJ.ColorPickerData> colorButtonOnClick, MultiValueConfigProperty<int> b, Action<VPPBMKOGBVJ.MaterialPickerData> materialButtonOnClick, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<float> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, Func<bool> isSinglePrimitiveShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B968B0", Offset = "0x9B958B0", VA = "0x189B968B0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class BXGGHJNQQTL : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public BXGGHJNQQTL DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9BA50B0", Offset = "0x9BA40B0", VA = "0x189BA50B0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private readonly Dictionary<int, string> ZDGUJYDVNFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private readonly MultiValueConfigProperty<bool> AZDNXZWRLWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private readonly MultiValueConfigProperty<bool> NPECIITMGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private readonly MultiValueConfigProperty<int> EFWIACJERLW;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B91F50", Offset = "0x9B90F50", VA = "0x189B91F50")]
		public BXGGHJNQQTL(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<int> c, Dictionary<int, string> tubeRingOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B91E10", Offset = "0x9B90E10", VA = "0x189B91E10", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class SUQLGFJKQOQ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public SUQLGFJKQOQ DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B9C520", Offset = "0x9B9B520", VA = "0x189B9C520")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private readonly OEVDPFSZBEO TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10A82A0", Offset = "0x10A72A0", VA = "0x1810A82A0")]
		public SUQLGFJKQOQ(int a, OEVDPFSZBEO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E3F0", Offset = "0x9B9D3F0", VA = "0x189B9E3F0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class OEVDPFSZBEO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class WLUGBDBSDJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public OEVDPFSZBEO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x9BA38B0", Offset = "0x9BA28B0", VA = "0x189BA38B0")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x9BA3B60", Offset = "0x9BA2B60", VA = "0x189BA3B60")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private readonly RecolorModes PJRNBNJXQLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private readonly ConfigProperty<int> VAIEOMCALJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private readonly Action<VPPBMKOGBVJ.ColorPickerData> ZIAOZEBZXWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private readonly ConfigProperty<int> GTBWIOOOVSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private readonly Action<VPPBMKOGBVJ.MaterialPickerData> FHMJQWBJWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private readonly ConfigProperty<float> MEEMVPVWOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private readonly bool BLMMJLAGWMH;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B830", Offset = "0x9B9A830", VA = "0x189B9B830")]
		public OEVDPFSZBEO(RecolorModes a, ConfigProperty<int> b, Action<VPPBMKOGBVJ.ColorPickerData> colorButtonOnClick, ConfigProperty<int> c, Action<VPPBMKOGBVJ.MaterialPickerData> materialButtonOnClick, ConfigProperty<float> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B9B640", Offset = "0x9B9A640", VA = "0x189B9B640", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class RWDTQXKOAEO : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public RWDTQXKOAEO DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9B99B00", Offset = "0x9B98B00", VA = "0x189B99B00")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private readonly FOKZUHVDJOX? VWCKNNNOFNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private readonly KTZVRHZGFLQ? MOSWOCQCTVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private readonly OEVDPFSZBEO? XQRGRVZBFKC;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF31A20", Offset = "0xF30A20", VA = "0x180F31A20")]
		public RWDTQXKOAEO(KTZVRHZGFLQ? a, OEVDPFSZBEO? b, FOKZUHVDJOX? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B9DA90", Offset = "0x9B9CA90", VA = "0x189B9DA90", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class IHGOUUFSHMX : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public IHGOUUFSHMX DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9B9C7F0", Offset = "0x9B9B7F0", VA = "0x189B9C7F0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private readonly int LWFGQHQGBDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private readonly FOKZUHVDJOX TMVYLHGVNAC;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10A82A0", Offset = "0x10A72A0", VA = "0x1810A82A0")]
		public IHGOUUFSHMX(int a, FOKZUHVDJOX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9B98740", Offset = "0x9B97740", VA = "0x189B98740", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class FOKZUHVDJOX : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly string NAZSBQHGXFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private readonly MultiValueConfigProperty<bool> VHVZRWCDUVY;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DCA0", Offset = "0x9B6CCA0", VA = "0x189B6DCA0")]
		public FOKZUHVDJOX(string primaryLabel, MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B92C10", Offset = "0x9B91C10", VA = "0x189B92C10", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class WBLREBYZKRV : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public WBLREBYZKRV DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Func<string, bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1540", Offset = "0x9BA0540", VA = "0x189BA1540")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1D80", Offset = "0x9BA0D80", VA = "0x189BA1D80")]
			internal bool MMYVZZRJFFT(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private readonly ConfigProperty<IReadOnlyList<string>> LJXFUEUZSAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private readonly ConfigProperty<IReadOnlyList<string>>? EQVVIFPDQPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private readonly Func<bool> ROLAVSRMYOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly Func<bool>? VWUISOAQEOY;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
		private static bool WHVDXMEYNVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2EF0", Offset = "0x9BA1EF0", VA = "0x189BA2EF0")]
		public WBLREBYZKRV(int a, ConfigProperty<IReadOnlyList<string>> persistentTags, [Optional] ConfigProperty<IReadOnlyList<string>>? runtimeTags, [Optional] Func<bool>? b, [Optional] Func<bool>? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2DE0", Offset = "0x9BA1DE0", VA = "0x189BA2DE0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class AIIHXIHGOCT : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class ICJXWLDBPBZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public AIIHXIHGOCT DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ICJXWLDBPBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x9B97D50", Offset = "0x9B96D50", VA = "0x189B97D50")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9B98710", Offset = "0x9B97710", VA = "0x189B98710")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x9B97CF0", Offset = "0x9B96CF0", VA = "0x189B97CF0")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x9B97D20", Offset = "0x9B96D20", VA = "0x189B97D20")]
			internal void MMOIFMDOMJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class NSPBPFWQIHX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public AIIHXIHGOCT DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public NSPBPFWQIHX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9B9AE50", Offset = "0x9B99E50", VA = "0x189B9AE50")]
			internal void QLNSCGAPAOV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x9B9A920", Offset = "0x9B99920", VA = "0x189B9A920")]
			internal void QLILEZGRRDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9B9A8B0", Offset = "0x9B998B0", VA = "0x189B9A8B0")]
			internal bool QLDEHSMUHSD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly IReadOnlyList<GunHandleData.TCTYKJDUXLX.GunHandleScreensPose> EJMPBPRWAIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private readonly MultiValueConfigProperty<GunHandleData.TCTYKJDUXLX.GunHandleScreensPose> ODHIBQGAPAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly MultiValueConfigProperty<int> NKOIMHWVSIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly MultiValueConfigProperty<bool> XQMSYBWCFUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly MultiValueConfigProperty<float> OXIXUEQDKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly MultiValueConfigProperty<bool> JVZRMIGUTEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly MultiValueConfigProperty<float> XHYUGCZNTQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly MultiValueConfigProperty<bool> ICBKFFUPPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly MultiValueConfigProperty<bool> ECJRMTLKKOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly MultiValueConfigProperty<float> QSEEXDJVRCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private readonly MultiValueConfigProperty<bool> PHIGVVJMYPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private readonly MultiValueConfigProperty<bool> AFEAOVNAOYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private readonly MultiValueConfigProperty<bool> GUFEPLAHTMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly MultiValueConfigProperty<bool> BDBTXCIGIWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly MultiValueConfigProperty<bool> EIVPDKQQFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MultiValueConfigProperty<float> HCFAPYJSBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly MultiValueConfigProperty<float> CRKKXVIMXNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private readonly MultiValueConfigProperty<float> HHETDHYIWVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly MultiValueConfigProperty<float> CLETARJACAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly MultiValueConfigProperty<float> EMBPIZGSRZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private readonly MultiValueConfigProperty<float> FIEBSEDPAXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly MultiValueConfigProperty<bool> DPPFFTXSMSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly MultiValueConfigProperty<bool> JDSVDZYQFUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly MultiValueConfigProperty<bool> IFMITJLDVQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly MultiValueConfigProperty<string> DQTUMPCIMXX;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B8FAB0", Offset = "0x9B8EAB0", VA = "0x189B8FAB0")]
		private static string UPSLMOZKVXP(GunHandleData.TCTYKJDUXLX.GunHandleScreensPose a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9B8FFF0", Offset = "0x9B8EFF0", VA = "0x189B8FFF0")]
		public AIIHXIHGOCT(MultiValueConfigProperty<GunHandleData.TCTYKJDUXLX.GunHandleScreensPose> a, MultiValueConfigProperty<int> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<float> f, MultiValueConfigProperty<bool> g, MultiValueConfigProperty<bool> h, MultiValueConfigProperty<float> i, MultiValueConfigProperty<bool> j, MultiValueConfigProperty<bool> k, MultiValueConfigProperty<bool> l, MultiValueConfigProperty<bool> m, MultiValueConfigProperty<bool> n, MultiValueConfigProperty<float> o, MultiValueConfigProperty<float> p, MultiValueConfigProperty<float> q, MultiValueConfigProperty<float> r, MultiValueConfigProperty<float> s, MultiValueConfigProperty<float> t, MultiValueConfigProperty<bool> u, MultiValueConfigProperty<bool> v, MultiValueConfigProperty<bool> w, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B8F970", Offset = "0x9B8E970", VA = "0x189B8F970", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B8FBB0", Offset = "0x9B8EBB0", VA = "0x189B8FBB0")]
		private void YGZFUMLICGH(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9B8F4C0", Offset = "0x9B8E4C0", VA = "0x189B8F4C0")]
		private void QQEATGILCLX(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9B8F150", Offset = "0x9B8E150", VA = "0x189B8F150")]
		private void OVZHZUZWIRZ(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9B8F070", Offset = "0x9B8E070", VA = "0x189B8F070")]
		[CompilerGenerated]
		private bool MGWEZDFUVKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9B8F0E0", Offset = "0x9B8E0E0", VA = "0x189B8F0E0")]
		[CompilerGenerated]
		private bool MHBLWJZSEVN()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class QBVLCGXXBSX : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly string ZSVIBGFPVSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly MultiValueConfigProperty<string> DQTUMPCIMXX;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DCA0", Offset = "0x9B6CCA0", VA = "0x189B6DCA0")]
		public QBVLCGXXBSX(string a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9B9C400", Offset = "0x9B9B400", VA = "0x189B9C400", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class HRTYAQMKNCD : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public HRTYAQMKNCD DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Func<bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0F10", Offset = "0x9B9FF10", VA = "0x189BA0F10")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1D10", Offset = "0x9BA0D10", VA = "0x189BA1D10")]
			internal bool MMYVZZRJFFT()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly IReadOnlyDictionary<SwingHandleData.TCTYKJDUXLX.SwingHandleAnimation, string> PZJCGISWWKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly MultiValueConfigProperty<SwingHandleData.TCTYKJDUXLX.SwingHandleAnimation> GTSJATTMRLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly MultiValueConfigProperty<bool> VDPEMBQUEKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly MultiValueConfigProperty<bool> SOSSWDBMRRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly MultiValueConfigProperty<float> BNHQSIWDPES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly MultiValueConfigProperty<bool> DPPFFTXSMSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly MultiValueConfigProperty<string> DQTUMPCIMXX;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A660", Offset = "0x9B79660", VA = "0x189B7A660")]
		public HRTYAQMKNCD(MultiValueConfigProperty<SwingHandleData.TCTYKJDUXLX.SwingHandleAnimation> a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9B96B60", Offset = "0x9B95B60", VA = "0x189B96B60", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class SOAIXCMLXMB : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public SOAIXCMLXMB DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1760", Offset = "0x9BA0760", VA = "0x189BA1760")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1CE0", Offset = "0x9BA0CE0", VA = "0x189BA1CE0")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0330", Offset = "0x9B9F330", VA = "0x189BA0330")]
			internal void MMJBIFJRCXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.TCTYKJDUXLX.ThrowHandleIdlePose, string> DVSSTDSQRXS;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static readonly IReadOnlyDictionary<ThrowHandleData.TCTYKJDUXLX.ThrowHandleThrowPose, string> GIEWPFMEMTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private readonly MultiValueConfigProperty<ThrowHandleData.TCTYKJDUXLX.ThrowHandleIdlePose> ARLSFJUFKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private readonly MultiValueConfigProperty<ThrowHandleData.TCTYKJDUXLX.ThrowHandleThrowPose> VNRQFFOHDVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private readonly MultiValueConfigProperty<float> WEMFYWYCJCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private readonly MultiValueConfigProperty<float> YIQURSVCOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private readonly MultiValueConfigProperty<string> DQTUMPCIMXX;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9B70060", Offset = "0x9B6F060", VA = "0x189B70060")]
		public SOAIXCMLXMB(MultiValueConfigProperty<ThrowHandleData.TCTYKJDUXLX.ThrowHandleIdlePose> a, MultiValueConfigProperty<ThrowHandleData.TCTYKJDUXLX.ThrowHandleThrowPose> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E060", Offset = "0x9B9D060", VA = "0x189B9E060", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9B9DD80", Offset = "0x9B9CD80", VA = "0x189B9DD80")]
		private void DMNCWRIETFZ(VPPBMKOGBVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9B9DBD0", Offset = "0x9B9CBD0", VA = "0x189B9DBD0")]
		private void BMVPIHHDEVC(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class HCFOYTUEKOZ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public HCFOYTUEKOZ DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x9B9C580", Offset = "0x9B9B580", VA = "0x189B9C580")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private readonly MultiValueConfigProperty<bool> KAEEQMRKPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private readonly MultiValueConfigProperty<string> DQTUMPCIMXX;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FCF0", Offset = "0x9B6ECF0", VA = "0x189B6FCF0")]
		public HCFOYTUEKOZ(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9B96770", Offset = "0x9B95770", VA = "0x189B96770", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class FYAWLROAJQU : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public FYAWLROAJQU DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9B9FE50", Offset = "0x9B9EE50", VA = "0x189B9FE50")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly MultiValueConfigProperty<string> DQTUMPCIMXX;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public FYAWLROAJQU(MultiValueConfigProperty<string> controlLabel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9B92D30", Offset = "0x9B91D30", VA = "0x189B92D30", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class CGFUBZWNWNX : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class ACFWOTACWWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public CGFUBZWNWNX DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ACFWOTACWWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9B8E800", Offset = "0x9B8D800", VA = "0x189B8E800")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private readonly MultiValueConfigProperty<bool> YPMZTSNXBFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private readonly MultiValueConfigProperty<float> LHMPAKHADNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private readonly System.Numerics.Vector2 UDJUPTMKWKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private readonly MultiValueConfigProperty<bool> RDRGMJYWCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private readonly OEVDPFSZBEO? FIZRHZVNWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private readonly FOKZUHVDJOX? TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9B92140", Offset = "0x9B91140", VA = "0x189B92140")]
		public CGFUBZWNWNX(MultiValueConfigProperty<bool> a, MultiValueConfigProperty<float> b, System.Numerics.Vector2 c, MultiValueConfigProperty<bool> d, OEVDPFSZBEO? colorableOptions, FOKZUHVDJOX? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9B92000", Offset = "0x9B91000", VA = "0x189B92000", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class PJVAHMTBPYM : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public PJVAHMTBPYM DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9B9FD90", Offset = "0x9B9ED90", VA = "0x189B9FD90")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly WBLREBYZKRV XQVIPNTUMZU;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public PJVAHMTBPYM(WBLREBYZKRV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9B9C2C0", Offset = "0x9B9B2C0", VA = "0x189B9C2C0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class TCCMCWBUCXN : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public TCCMCWBUCXN DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x9B9FC40", Offset = "0x9B9EC40", VA = "0x189B9FC40")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly MultiValueConfigProperty<bool> XMDJPUEWGIM;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB40", Offset = "0x9B6CB40", VA = "0x189B6DB40")]
		public TCCMCWBUCXN(MultiValueConfigProperty<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9B9E540", Offset = "0x9B9D540", VA = "0x189B9E540", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class QOZZAKNLFGU : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class ACFWOTACWWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public QOZZAKNLFGU DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ACFWOTACWWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9B8E760", Offset = "0x9B8D760", VA = "0x189B8E760")]
			internal bool FACMSYKICRH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x9B8ED10", Offset = "0x9B8DD10", VA = "0x189B8ED10")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private readonly MultiValueConfigProperty<bool> FIOUIEQJTOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private readonly Func<bool> OQBTWGCDHDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private readonly MultiValueConfigProperty<bool> VOASTTDXTNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private readonly MultiValueConfigProperty<float> QNUUZPNPGKP;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9B9C990", Offset = "0x9B9B990", VA = "0x189B9C990")]
		public QOZZAKNLFGU(MultiValueConfigProperty<bool> a, Func<bool> canSeeShouldRespawn, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9B9C850", Offset = "0x9B9B850", VA = "0x189B9C850", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class VYGWQGCQFRP : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class WLUGBDBSDJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public VYGWQGCQFRP DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9BA3220", Offset = "0x9BA2220", VA = "0x189BA3220")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9BA3B80", Offset = "0x9BA2B80", VA = "0x189BA3B80")]
			internal void MMYVZZRJFFT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly Dictionary<SeatData.TCTYKJDUXLX.PostureType, string> YXHHJDWLBXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private readonly string QHIUNKNKEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private readonly Option<bool> YGQOHNRBOYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private readonly MultiValueConfigProperty<SeatData.TCTYKJDUXLX.PostureType> DFYKBOJACTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private readonly MultiValueConfigProperty<bool> NWUBIXFUSPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private readonly MultiValueConfigProperty<bool> BFZPPEUVSQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private readonly MultiValueConfigProperty<bool> UEFQXXWWLKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private readonly MultiValueConfigProperty<bool> UOZELHNDRAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly MultiValueConfigProperty<bool> GUHXGKXRQZW;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2B70", Offset = "0x9BA1B70", VA = "0x189BA2B70")]
		public VYGWQGCQFRP(string configName, Option<bool> a, MultiValueConfigProperty<SeatData.TCTYKJDUXLX.PostureType> b, MultiValueConfigProperty<bool> c, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f, MultiValueConfigProperty<bool> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2940", Offset = "0x9BA1940", VA = "0x189BA2940", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class DTWFQUNHHRE : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class BFGCHHTGJIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public DTWFQUNHHRE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BFGCHHTGJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9B91510", Offset = "0x9B90510", VA = "0x189B91510")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private static readonly IReadOnlyDictionary<int, string> SMGLUGQAQUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private readonly MultiValueConfigProperty<int> MDNHJCQPZCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private readonly IReadOnlyDictionary<int, string> UYJKTDGEJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private readonly MultiValueConfigProperty<float> WFCRHGJWNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private readonly MultiValueConfigProperty<int> XRYQHLEZIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private readonly MultiValueConfigProperty<string> IGNDLLVAJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly MultiValueConfigProperty<bool> ALFMMEVNYKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly MultiValueConfigProperty<string> SAYCDBOYBUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private readonly MultiValueConfigProperty<bool> QARYKAOLJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private readonly MultiValueConfigProperty<bool> DCZZHEDYVCY;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9B92AA0", Offset = "0x9B91AA0", VA = "0x189B92AA0")]
		public DTWFQUNHHRE(MultiValueConfigProperty<int> a, IReadOnlyDictionary<int, string> teamItems, MultiValueConfigProperty<float> b, MultiValueConfigProperty<int> c, MultiValueConfigProperty<string> primaryHandRespawnTag, MultiValueConfigProperty<bool> d, MultiValueConfigProperty<string> secondaryHandRespawnTag, MultiValueConfigProperty<bool> e, MultiValueConfigProperty<bool> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9B92850", Offset = "0x9B91850", VA = "0x189B92850", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public sealed class WZPHTYQGJSI : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public WZPHTYQGJSI DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public Action QKXDRYXLJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Action QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9B94410", Offset = "0x9B93410", VA = "0x189B94410")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x9B94E80", Offset = "0x9B93E80", VA = "0x189B94E80")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9B93700", Offset = "0x9B92700", VA = "0x189B93700")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9B938E0", Offset = "0x9B928E0", VA = "0x189B938E0")]
			internal void MMOIFMDOMJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9B95820", Offset = "0x9B94820", VA = "0x189B95820")]
			internal void MNOQRTZBHNU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9B95DD0", Offset = "0x9B94DD0", VA = "0x189B95DD0")]
			internal void MNTXPASYQZD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly MultiValueConfigProperty<bool> ZBDIUJSSJKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private readonly MultiValueConfigProperty<float> WFCRHGJWNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private readonly MultiValueConfigProperty<float> SNCPCDFXHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private readonly WBLREBYZKRV YCFNZUABJPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private readonly WBLREBYZKRV AUWQPMFYIOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private readonly IReadOnlyList<(Guid, string)>? NSANXWFUFRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> IZSJCQIREVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private readonly ConfigProperty<IReadOnlyCollection<Guid>> KGLRWRCOCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private readonly Action<VPPBMKOGBVJ.MultiTogglePickerData> JIBXDAOGVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private readonly FOKZUHVDJOX? TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9BA3E10", Offset = "0x9BA2E10", VA = "0x189BA3E10")]
		public WZPHTYQGJSI(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, IReadOnlyList<(Guid, string)>? roleItems, ConfigProperty<string[]> roleGuidsToSpawn, ConfigProperty<string[]> roleGuidsToAvoid, Action<VPPBMKOGBVJ.MultiTogglePickerData> onRolePickerClick, FOKZUHVDJOX? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9BA3CD0", Offset = "0x9BA2CD0", VA = "0x189BA3CD0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public sealed class PCHYYNXBKEZ : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public PCHYYNXBKEZ DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public Action QJROIKIBEXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public Action QKCCCXVVXTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public Action QLCKPFRISYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public Action QJWVFRBYOIL;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9B93940", Offset = "0x9B92940", VA = "0x189B93940")]
			internal void MMTPCSXLVUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9B94860", Offset = "0x9B93860", VA = "0x189B94860")]
			internal void MMYVZZRJFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9B93880", Offset = "0x9B92880", VA = "0x189B93880")]
			internal void MMOIFMDOMJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9B93760", Offset = "0x9B92760", VA = "0x189B93760")]
			internal void MMJBIFJRCXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9B95940", Offset = "0x9B94940", VA = "0x189B95940")]
			internal void MNOQRTZBHNU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private readonly int LTDDOWMCICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly MultiValueConfigProperty<bool> BFXUCBXVPRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private readonly MultiValueConfigProperty<float> WFCRHGJWNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private readonly MultiValueConfigProperty<float> SNCPCDFXHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private readonly WBLREBYZKRV YCFNZUABJPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private readonly WBLREBYZKRV AUWQPMFYIOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private readonly FOKZUHVDJOX? TSPYCZRIEEM;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x9B9BD00", Offset = "0x9B9AD00", VA = "0x189B9BD00")]
		public PCHYYNXBKEZ(int a, MultiValueConfigProperty<bool> b, MultiValueConfigProperty<float> c, MultiValueConfigProperty<float> d, ConfigProperty<string[]> tagsToSpawn, ConfigProperty<string[]> tagsToAvoid, FOKZUHVDJOX? syncedOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x9B9BBC0", Offset = "0x9B9ABC0", VA = "0x189B9BBC0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public sealed class VYOSQJSELSY : ZKXEXUFWDRP
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public VPPBMKOGBVJ HCWQRJMRPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public VYOSQJSELSY DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9B99BB0", Offset = "0x9B98BB0", VA = "0x189B99BB0")]
			internal void MMTPCSXLVUK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private readonly MultiValueConfigProperty<string> BLDQYNBGSQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly MultiValueConfigProperty<float> HDTUBDQAFER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly MultiValueConfigProperty<bool> YFWHREEYURE;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D450", Offset = "0x9B6C450", VA = "0x189B6D450")]
		public VYOSQJSELSY(MultiValueConfigProperty<string> WelcomeMatName, MultiValueConfigProperty<float> a, MultiValueConfigProperty<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2CA0", Offset = "0x9BA1CA0", VA = "0x189BA2CA0", Slot = "4")]
		public void TZSAZBPRLUM(VPPBMKOGBVJ a)
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
