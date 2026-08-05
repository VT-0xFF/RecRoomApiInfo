using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.TypeSystem;
using Circuits.Static.Core.TypeSystem.Factory;
using Circuits.Static.Core.TypeSystem.Type;
using Circuits.Static.EV.Lang;
using Circuits.Static.EV.Protobuf;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.GraphDefs;
using Circuits.Static.RecRoom.ObjectDefs;
using Circuits.Static.RecRoom.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf.Core;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2904590", Offset = "0x2902F90", VA = "0x182904590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.Circuits_Static_RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29043F0", Offset = "0x2902DF0", VA = "0x1829043F0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class FBHHPJAJINX
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2901EA0", Offset = "0x29008A0", VA = "0x182901EA0")]
		public static bool UZWXDJLHPWE(this YUGSHIKOLKK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2901DE0", Offset = "0x29007E0", VA = "0x182901DE0")]
		public static bool UZWXDJLHPWE(this ISRXXQTKLJD a)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct Registry
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct EVRequest
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			private readonly ZYLAWNEORYA _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			public EVRequest(ZYLAWNEORYA staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class RYQDQNWRBNR
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<OBQCFAINAAA>, HWPQTBQYEPT> UHNMMEMTUJG;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<OBQCFAINAAA>>? ATOIHTTSGDW;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<OBQCFAINAAA> XDYJXWOSOES;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<OBQCFAINAAA> PVOCIBVZSOL;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<OBQCFAINAAA> CZAWYWRKKLY;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<OBQCFAINAAA> MINJEKXAARV;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<OBQCFAINAAA> ALWPBHZZIOU;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<OBQCFAINAAA> SGZNWANIFMH;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<OBQCFAINAAA> LOWPVBYRNCT;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<OBQCFAINAAA> ZVYZQRVRSTZ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<OBQCFAINAAA> NAVCTXFCIEH;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<OBQCFAINAAA> USUSSFOIJPN;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<OBQCFAINAAA> MLDASCDNONJ;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<OBQCFAINAAA> TNMAJBGWQZH;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<OBQCFAINAAA> HQQTISOAOBO;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<OBQCFAINAAA> NKLMOROHUXC;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<OBQCFAINAAA> EPUZZRBXNMG;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<OBQCFAINAAA> VZHYLYXWPXL;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<OBQCFAINAAA> PFVODIFVPLC;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<OBQCFAINAAA> UBFHNBEKIJY;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<OBQCFAINAAA> DACASEEIDJL;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<OBQCFAINAAA> YTWRJACHQXE;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<OBQCFAINAAA> QXTNQNTERBL;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<OBQCFAINAAA> ZOYOEUDPQAC;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<OBQCFAINAAA> DDMUVBPPJEO;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<OBQCFAINAAA> DLXAVVXLZEZ;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<OBQCFAINAAA> KLIQBDCQJRD;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<OBQCFAINAAA> JDHBFGRONIE;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<OBQCFAINAAA> NUJKGREJACL;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<OBQCFAINAAA> FSHPUZWWKYU;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<OBQCFAINAAA> PEYBKZZRJTW;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<OBQCFAINAAA> QHIUFBDFOXE;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<OBQCFAINAAA> DZNXFVZGSHG;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<OBQCFAINAAA> HHWOUUXYUIN;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<OBQCFAINAAA> CYLXYRJGXBY;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<OBQCFAINAAA> QFNNMSPOTPU;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<OBQCFAINAAA> VJGJUUXPVPG;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<OBQCFAINAAA> NBMSSMDUYUZ;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<OBQCFAINAAA> ZRGOEQZREPQ;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<OBQCFAINAAA> UNVCMJHTEXJ;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<OBQCFAINAAA> MJZTOUMAEWL;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<OBQCFAINAAA> NCEHRJKXDBH;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<OBQCFAINAAA> KXKSETDOFRU;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<OBQCFAINAAA> HFEDVVCLETQ;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<OBQCFAINAAA> AKXOFROAICH;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<OBQCFAINAAA> YPENXNDDFNI;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<OBQCFAINAAA> ZMYFMJPNBBS;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<OBQCFAINAAA> SEENKFDJPBY;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<OBQCFAINAAA> RXHRPUGFMHF;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<OBQCFAINAAA> FCHSWVGDDYD;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<OBQCFAINAAA> PKWSRXAHIRN;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<OBQCFAINAAA> OENRMMGFEWS;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<OBQCFAINAAA> RNRFSOXRAKK;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<OBQCFAINAAA> TEFNPKGOLPZ;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<OBQCFAINAAA> NRIVQTTYOCU;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<OBQCFAINAAA> HKSTVAWDSIO;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<OBQCFAINAAA> IRJCGHGRGWR;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<OBQCFAINAAA> HAWJAZUITAN;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<OBQCFAINAAA> SXKYVBTBPVD;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<OBQCFAINAAA> JGIJCUVEEGN;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<OBQCFAINAAA> XGNBUQNHBXK;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<OBQCFAINAAA> UXGENWZTAWH;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<OBQCFAINAAA> XOXWVVJYKLL;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<OBQCFAINAAA> UIJALXXCZSD;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<OBQCFAINAAA> QWGETYTAEQE;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<OBQCFAINAAA> ZZRMYDGGIQS;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<OBQCFAINAAA> BQRFNXVIXDX;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<OBQCFAINAAA> EZSRPABAJGW;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<OBQCFAINAAA> CGUVLVBLDXJ;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<OBQCFAINAAA> RRHVWECBFEF;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<OBQCFAINAAA> GGAAYSQHQXR;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<OBQCFAINAAA>, HWPQTBQYEPT> JVEBXLLYIFV
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x290C3F0", Offset = "0x290ADF0", VA = "0x18290C3F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x290C110", Offset = "0x290AB10", VA = "0x18290C110")]
			public static HWPQTBQYEPT FWFYDRDQEZP(Id32<OBQCFAINAAA> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x290C440", Offset = "0x290AE40", VA = "0x18290C440")]
			public static bool QIXOAWVWETI(Id32<OBQCFAINAAA> id, [Out] HWPQTBQYEPT a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x290C4D0", Offset = "0x290AED0", VA = "0x18290C4D0")]
			public static YUGSHIKOLKK VFSRXTTTPPK(Id32<OBQCFAINAAA> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x290C190", Offset = "0x290AB90", VA = "0x18290C190")]
			private static Id32<OBQCFAINAAA> JIBLBJTHOBM(HWPQTBQYEPT a, Id32<OBQCFAINAAA> id)
			{
				return default(Id32<OBQCFAINAAA>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x290C220", Offset = "0x290AC20", VA = "0x18290C220")]
			private static void KNZWVSUMBGU(Id32<OBQCFAINAAA> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class WZVJKNGTMQE
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<GBNADADGGBI, YUGSHIKOLKK?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x1004B80", Offset = "0x1003580", VA = "0x181004B80")]
				private TypeRegistryFactory([In] IdUnsafeList<GBNADADGGBI, YUGSHIKOLKK?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x290FBF0", Offset = "0x290E5F0", VA = "0x18290FBF0")]
				public static TypeRegistryFactory PBVLPMCLPSM()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x290F8A0", Offset = "0x290E2A0", VA = "0x18290F8A0")]
				public (ReadOnlyIdArray<GBNADADGGBI, YUGSHIKOLKK>, IReadOnlyDictionary<YUGSHIKOLKK, Id32<GBNADADGGBI>>) KYZXWOEKWKU()
				{
					return default((ReadOnlyIdArray<GBNADADGGBI, YUGSHIKOLKK>, IReadOnlyDictionary<YUGSHIKOLKK, Id32<GBNADADGGBI>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x290FC50", Offset = "0x290E650", VA = "0x18290FC50")]
				public Id32<GBNADADGGBI> XTLZBPGEFOG(int a, YUGSHIKOLKK b)
				{
					return default(Id32<GBNADADGGBI>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x290F850", Offset = "0x290E250", VA = "0x18290F850")]
				public Id32<GBNADADGGBI> Initialize(int id, ELRCMLYBSCJ type, ELRCMLYBSCJ factoryType)
				{
					return default(Id32<GBNADADGGBI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class PNASYOPVPTV
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<GBNADADGGBI> EWTYDXWTKWU
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2904E80", Offset = "0x2903880", VA = "0x182904E80")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2905040", Offset = "0x2903A40", VA = "0x182905040")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<GBNADADGGBI> UPUFBJQQEPU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2904F40", Offset = "0x2903940", VA = "0x182904F40")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2905000", Offset = "0x2903A00", VA = "0x182905000")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<GBNADADGGBI> QYQSJDCQGXT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2904FC0", Offset = "0x29039C0", VA = "0x182904FC0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2904F80", Offset = "0x2903980", VA = "0x182904F80")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<GBNADADGGBI> ZBXOIGAZEEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2905080", Offset = "0x2903A80", VA = "0x182905080")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2904EC0", Offset = "0x29038C0", VA = "0x182904EC0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<GBNADADGGBI> JQYSSFYAZVD
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x29050C0", Offset = "0x2903AC0", VA = "0x1829050C0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2904E40", Offset = "0x2903840", VA = "0x182904E40")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<GBNADADGGBI> VIVYLCBMZAE
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2904F00", Offset = "0x2903900", VA = "0x182904F00")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2905100", Offset = "0x2903B00", VA = "0x182905100")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class UFUCRUYGQHR : IEnumerable<YUGSHIKOLKK>, IEnumerable, IEnumerator<YUGSHIKOLKK>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private YUGSHIKOLKK YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int XJERYWNBAAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool GJSRBAACIHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool MPYNACCDGDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion BFWVYAFIRDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion TULKRJVNZQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool YYKVXTKTEUD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool BUKRTSWLMAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool VUKLEGNVYXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool XOTFYKIARHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool ESLEBHWUKLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool JDASXJDZRLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool XXFTMPFIOZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool MZOCHCOLTWM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<YUGSHIKOLKK> RECIBZUSAYP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private YUGSHIKOLKK YEVMFEUBQHW;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private YUGSHIKOLKK HEHBRRYUOVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
				[DebuggerHidden]
				public UFUCRUYGQHR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2910700", Offset = "0x290F100", VA = "0x182910700", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2910310", Offset = "0x290ED10", VA = "0x182910310", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2910790", Offset = "0x290F190", VA = "0x182910790")]
				private void SNXRWXESNLS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x29107E0", Offset = "0x290F1E0", VA = "0x1829107E0", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2910820", Offset = "0x290F220", VA = "0x182910820", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<YUGSHIKOLKK> XENIENHIVBI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2910820", Offset = "0x290F220", VA = "0x182910820", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WFEYQSZVQHA()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class DXRKOVNYCOB : IEnumerable<YUGSHIKOLKK>, IEnumerable, IEnumerator<YUGSHIKOLKK>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private YUGSHIKOLKK YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int XJERYWNBAAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion BFWVYAFIRDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion TULKRJVNZQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool VUKLEGNVYXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool XOTFYKIARHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool YYKVXTKTEUD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool BUKRTSWLMAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool ALJVXIPKEYX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool UBVDXONVSBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool ESLEBHWUKLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool JDASXJDZRLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool URJVOGMYULJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool SZOXNIXVLWL;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private YUGSHIKOLKK HEHBRRYUOVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
				[DebuggerHidden]
				public DXRKOVNYCOB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x28FFDE0", Offset = "0x28FE7E0", VA = "0x1828FFDE0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2901CF0", Offset = "0x29006F0", VA = "0x182901CF0", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2901D30", Offset = "0x2900730", VA = "0x182901D30", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<YUGSHIKOLKK> XENIENHIVBI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2901D30", Offset = "0x2900730", VA = "0x182901D30", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WFEYQSZVQHA()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class OZIUSDUPXXA : IEnumerable<Id32<GBNADADGGBI>>, IEnumerable, IEnumerator<Id32<GBNADADGGBI>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<GBNADADGGBI> YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int XJERYWNBAAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion BFWVYAFIRDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion TULKRJVNZQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool YYKVXTKTEUD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool BUKRTSWLMAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool VUKLEGNVYXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool XOTFYKIARHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool ESLEBHWUKLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool JDASXJDZRLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool XXFTMPFIOZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool MZOCHCOLTWM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<YUGSHIKOLKK> RECIBZUSAYP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<ELRCMLYBSCJ> REHOZGOPKJY;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<GBNADADGGBI> JLAMYQXBFFA
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2904BC0", Offset = "0x29035C0", VA = "0x182904BC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x12DCEB0", Offset = "0x12DB8B0", VA = "0x1812DCEB0")]
				[DebuggerHidden]
				public OZIUSDUPXXA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2904C10", Offset = "0x2903610", VA = "0x182904C10", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x29046C0", Offset = "0x29030C0", VA = "0x1829046C0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2904D60", Offset = "0x2903760", VA = "0x182904D60")]
				private void SNXRWXESNLS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2904DB0", Offset = "0x29037B0", VA = "0x182904DB0")]
				private void SONMORMKPTT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2904E00", Offset = "0x2903800", VA = "0x182904E00", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2904610", Offset = "0x2903010", VA = "0x182904610", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<GBNADADGGBI>> DAEDJCZVQIF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2904610", Offset = "0x2903010", VA = "0x182904610", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WFEYQSZVQHA()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log RKIUKOTABJV;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<GBNADADGGBI, YUGSHIKOLKK?> TDJGAVGWJRB;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<YUGSHIKOLKK, Id32<GBNADADGGBI>> HSCVXXNXBNF;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly ISRXXQTKLJD UDQJAFOSGDM;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly ISRXXQTKLJD QWNWVMSRLWI;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<YUGSHIKOLKK> ZAFGRZBFDCS;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<YUGSHIKOLKK> VSERVMVOSLD;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet CLHIVTORFGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet BURMQQIRYAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet AZVJIXQFNYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xB82730", Offset = "0xB81130", VA = "0x180B82730")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static YUGSHIKOLKK EWTYDXWTKWU
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2913D10", Offset = "0x2912710", VA = "0x182913D10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static YUGSHIKOLKK UPUFBJQQEPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x29149E0", Offset = "0x29133E0", VA = "0x1829149E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static YUGSHIKOLKK QYQSJDCQGXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2915390", Offset = "0x2913D90", VA = "0x182915390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static YUGSHIKOLKK ZBXOIGAZEEZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2915920", Offset = "0x2914320", VA = "0x182915920")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static YUGSHIKOLKK TCDSXKMGUBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x29130A0", Offset = "0x2911AA0", VA = "0x1829130A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static YUGSHIKOLKK HZVZABJIUPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2912B80", Offset = "0x2911580", VA = "0x182912B80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static YUGSHIKOLKK YMRJCGGWIOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2915070", Offset = "0x2913A70", VA = "0x182915070")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static YUGSHIKOLKK JQYSSFYAZVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2916000", Offset = "0x2914A00", VA = "0x182916000")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static ELRCMLYBSCJ ZHBJNVYJMZF
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2914320", Offset = "0x2912D20", VA = "0x182914320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static ELRCMLYBSCJ WZXCCUVYQFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2916340", Offset = "0x2914D40", VA = "0x182916340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static ELRCMLYBSCJ WPILMUUUVFV
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2913A00", Offset = "0x2912400", VA = "0x182913A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static ELRCMLYBSCJ PYKHAAJFUXJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x29164D0", Offset = "0x2914ED0", VA = "0x1829164D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static ELRCMLYBSCJ DYGACQQMNPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x29133B0", Offset = "0x2911DB0", VA = "0x1829133B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static ELRCMLYBSCJ PGFKDUEXVPG
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2916430", Offset = "0x2914E30", VA = "0x182916430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static ELRCMLYBSCJ HCRIVUHMUSW
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2914B10", Offset = "0x2913510", VA = "0x182914B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static ELRCMLYBSCJ UIFKSTPOBRC
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2913000", Offset = "0x2911A00", VA = "0x182913000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static ELRCMLYBSCJ TMIUNQSNRHF
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2916520", Offset = "0x2914F20", VA = "0x182916520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static ELRCMLYBSCJ MTRRZOABMBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2915290", Offset = "0x2913C90", VA = "0x182915290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static ELRCMLYBSCJ LUWAFGOGUIU
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2914940", Offset = "0x2913340", VA = "0x182914940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static ELRCMLYBSCJ UWTYNANHVBG
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2915EC0", Offset = "0x29148C0", VA = "0x182915EC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static ELRCMLYBSCJ KFKVNKHVBBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2913910", Offset = "0x2912310", VA = "0x182913910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static ELRCMLYBSCJ VGPBQKEZLVM
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2914F80", Offset = "0x2913980", VA = "0x182914F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static ELRCMLYBSCJ XBACUHMWVXP
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2915830", Offset = "0x2914230", VA = "0x182915830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static ELRCMLYBSCJ KGSTRYDOCEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x29154C0", Offset = "0x2913EC0", VA = "0x1829154C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static ELRCMLYBSCJ SAJMNTNKUVM
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x29146E0", Offset = "0x29130E0", VA = "0x1829146E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static ELRCMLYBSCJ IHSEOEFWKKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2913360", Offset = "0x2911D60", VA = "0x182913360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static ELRCMLYBSCJ VTXGRUZPFKU
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2913310", Offset = "0x2911D10", VA = "0x182913310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static ELRCMLYBSCJ QLBMUBWSEAK
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2915510", Offset = "0x2913F10", VA = "0x182915510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static ELRCMLYBSCJ WQPKKMGBCDF
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2916110", Offset = "0x2914B10", VA = "0x182916110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static ELRCMLYBSCJ WUESMNESXDY
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2913F60", Offset = "0x2912960", VA = "0x182913F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static ELRCMLYBSCJ VCYQNNQPEXS
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x29145F0", Offset = "0x2912FF0", VA = "0x1829145F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static ELRCMLYBSCJ VAKCUSMUWYE
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2913DF0", Offset = "0x29127F0", VA = "0x182913DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static ELRCMLYBSCJ ZUGAFPISECQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2914B60", Offset = "0x2913560", VA = "0x182914B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static ELRCMLYBSCJ KTUIVEDTSPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2913180", Offset = "0x2911B80", VA = "0x182913180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static ELRCMLYBSCJ TWQWLNAGPXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2915790", Offset = "0x2914190", VA = "0x182915790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static ELRCMLYBSCJ FFGXWGWLFUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2916750", Offset = "0x2915150", VA = "0x182916750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static ELRCMLYBSCJ XIKKAHTJVQE
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2914780", Offset = "0x2913180", VA = "0x182914780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static ELRCMLYBSCJ ASJGMYAQQBT
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2914FD0", Offset = "0x29139D0", VA = "0x182914FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static ELRCMLYBSCJ FTDLVTIUBAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x29162A0", Offset = "0x2914CA0", VA = "0x1829162A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static ELRCMLYBSCJ BQUKCQWGEOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x29148A0", Offset = "0x29132A0", VA = "0x1829148A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static ELRCMLYBSCJ JCTQCXOEVKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2913960", Offset = "0x2912360", VA = "0x182913960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static ELRCMLYBSCJ RLJZFUBIMHS
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x29160C0", Offset = "0x2914AC0", VA = "0x1829160C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static ELRCMLYBSCJ GLOUOWBUKTN
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2914500", Offset = "0x2912F00", VA = "0x182914500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static ELRCMLYBSCJ JIAAXRTVWYN
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x29165C0", Offset = "0x2914FC0", VA = "0x1829165C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static ELRCMLYBSCJ KJXEZEFIDEX
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2915E70", Offset = "0x2914870", VA = "0x182915E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static ELRCMLYBSCJ INUSETLTHSG
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2916200", Offset = "0x2914C00", VA = "0x182916200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static ELRCMLYBSCJ WLCQWSQFRTG
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x29162F0", Offset = "0x2914CF0", VA = "0x1829162F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static ELRCMLYBSCJ ISQBAEQMXTX
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x29143C0", Offset = "0x2912DC0", VA = "0x1829143C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static ELRCMLYBSCJ TEQZPKHYGCF
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2914280", Offset = "0x2912C80", VA = "0x182914280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static ELRCMLYBSCJ AEWMZCZTGQB
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2913BD0", Offset = "0x29125D0", VA = "0x182913BD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static ELRCMLYBSCJ IKDYLZTEYMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2915100", Offset = "0x2913B00", VA = "0x182915100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static ELRCMLYBSCJ WCUHIQJTKCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2914410", Offset = "0x2912E10", VA = "0x182914410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static ELRCMLYBSCJ EHOLTIBAARW
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2913400", Offset = "0x2911E00", VA = "0x182913400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static ELRCMLYBSCJ ZAPZDUMXFZZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x29157E0", Offset = "0x29141E0", VA = "0x1829157E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static ELRCMLYBSCJ UIVSRERPSKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2914230", Offset = "0x2912C30", VA = "0x182914230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static ELRCMLYBSCJ FPMNGADHCYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x29147D0", Offset = "0x29131D0", VA = "0x1829147D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static ELRCMLYBSCJ NWJHCBAOGQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2915740", Offset = "0x2914140", VA = "0x182915740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static ELRCMLYBSCJ OBANRHAUFIR
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x29140F0", Offset = "0x2912AF0", VA = "0x1829140F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static ELRCMLYBSCJ DORAYKJFMJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2916160", Offset = "0x2914B60", VA = "0x182916160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static ELRCMLYBSCJ TDSFLKAXPFL
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2912FB0", Offset = "0x29119B0", VA = "0x182912FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static ELRCMLYBSCJ NCCUIRKBUTU
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2912B30", Offset = "0x2911530", VA = "0x182912B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static ELRCMLYBSCJ IKUYLKAWKGB
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2913E90", Offset = "0x2912890", VA = "0x182913E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static ELRCMLYBSCJ IUIVXFTLKTK
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2914BB0", Offset = "0x29135B0", VA = "0x182914BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static ELRCMLYBSCJ OISXGKDVWWE
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x29145A0", Offset = "0x2912FA0", VA = "0x1829145A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static ELRCMLYBSCJ VFUXPVRFYYG
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2915020", Offset = "0x2913A20", VA = "0x182915020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static ELRCMLYBSCJ NXBMNMBRWQW
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x29140A0", Offset = "0x2912AA0", VA = "0x1829140A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static ELRCMLYBSCJ SGFYZQUQBTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2913770", Offset = "0x2912170", VA = "0x182913770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static ELRCMLYBSCJ ADVSPGZMSKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2915F10", Offset = "0x2914910", VA = "0x182915F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static ELRCMLYBSCJ WXOTTFQSHOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2914640", Offset = "0x2913040", VA = "0x182914640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static ELRCMLYBSCJ ZMHZXEZMBPR
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x29142D0", Offset = "0x2912CD0", VA = "0x1829142D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static ELRCMLYBSCJ TMHXJTQKPGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x29166B0", Offset = "0x29150B0", VA = "0x1829166B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static ELRCMLYBSCJ ZLHVKVEXXBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2913C70", Offset = "0x2912670", VA = "0x182913C70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static ELRCMLYBSCJ VPHTHGPZKYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2914AC0", Offset = "0x29134C0", VA = "0x182914AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static ELRCMLYBSCJ JYRXIJQPTSE
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x29141E0", Offset = "0x2912BE0", VA = "0x1829141E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static ELRCMLYBSCJ WSQMMENIHRI
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x29167A0", Offset = "0x29151A0", VA = "0x1829167A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static ELRCMLYBSCJ PINPRTGAQKK
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2913C20", Offset = "0x2912620", VA = "0x182913C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static ELRCMLYBSCJ AXQMMRJIARX
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2912C10", Offset = "0x2911610", VA = "0x182912C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static ELRCMLYBSCJ UJSHMAXHITB
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2915650", Offset = "0x2914050", VA = "0x182915650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static ELRCMLYBSCJ BGNKJQLGEVN
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2915F60", Offset = "0x2914960", VA = "0x182915F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static ELRCMLYBSCJ BPKNMSYVEPW
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2913720", Offset = "0x2912120", VA = "0x182913720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static ELRCMLYBSCJ FMORWEOCDYX
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2916700", Offset = "0x2915100", VA = "0x182916700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static ELRCMLYBSCJ PXDOGAUMENB
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2916480", Offset = "0x2914E80", VA = "0x182916480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static ELRCMLYBSCJ QZIDHPQVBLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x29148F0", Offset = "0x29132F0", VA = "0x1829148F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static ELRCMLYBSCJ LXUBQEIVRIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2915210", Offset = "0x2913C10", VA = "0x182915210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static ELRCMLYBSCJ MPUIOIDFAMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2916610", Offset = "0x2915010", VA = "0x182916610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static ELRCMLYBSCJ JZYBXOUUZKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2914370", Offset = "0x2912D70", VA = "0x182914370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static ELRCMLYBSCJ UYHVFXIUXSI
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2913CC0", Offset = "0x29126C0", VA = "0x182913CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static ELRCMLYBSCJ FSRUHOCEAFV
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2915560", Offset = "0x2913F60", VA = "0x182915560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static ELRCMLYBSCJ DDOLPHWQWZL
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x29158D0", Offset = "0x29142D0", VA = "0x1829158D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static ELRCMLYBSCJ FJJSJQEIDJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2914140", Offset = "0x2912B40", VA = "0x182914140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static ELRCMLYBSCJ QWCCTVLEEAB
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x29151C0", Offset = "0x2913BC0", VA = "0x1829151C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static ELRCMLYBSCJ YLAKOIBRMSW
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2913810", Offset = "0x2912210", VA = "0x182913810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static ELRCMLYBSCJ YBPCXURXBKK
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2915880", Offset = "0x2914280", VA = "0x182915880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static ELRCMLYBSCJ DTYFLSPPJZC
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2915470", Offset = "0x2913E70", VA = "0x182915470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static ELRCMLYBSCJ APLAWBJEASI
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2916250", Offset = "0x2914C50", VA = "0x182916250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static ELRCMLYBSCJ BIMTFMEYGKO
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2913FB0", Offset = "0x29129B0", VA = "0x182913FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static ELRCMLYBSCJ EIVQJSXJEFL
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2914550", Offset = "0x2912F50", VA = "0x182914550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static ELRCMLYBSCJ WCEEZKDZVTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2916570", Offset = "0x2914F70", VA = "0x182916570")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static ELRCMLYBSCJ WQGCTXAGOET
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x29156F0", Offset = "0x29140F0", VA = "0x1829156F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static ELRCMLYBSCJ VQHQIBMHVKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x29161B0", Offset = "0x2914BB0", VA = "0x1829161B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static ELRCMLYBSCJ NLNSXPUQQBR
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2914730", Offset = "0x2913130", VA = "0x182914730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static ELRCMLYBSCJ QSMQDDAFOOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2913130", Offset = "0x2911B30", VA = "0x182913130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static ELRCMLYBSCJ KBXQXJBOITD
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2914460", Offset = "0x2912E60", VA = "0x182914460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static ELRCMLYBSCJ NKTUCONJMFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2913DA0", Offset = "0x29127A0", VA = "0x182913DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static ELRCMLYBSCJ JADHPAUJCUG
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x29139B0", Offset = "0x29123B0", VA = "0x1829139B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static ELRCMLYBSCJ AMKMCUPBXNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2914990", Offset = "0x2913390", VA = "0x182914990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static ELRCMLYBSCJ HWIMEUWGCYQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x29156A0", Offset = "0x29140A0", VA = "0x1829156A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static ELRCMLYBSCJ GSKRLQTQELE
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2916660", Offset = "0x2915060", VA = "0x182916660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static ELRCMLYBSCJ TEUJITXEVVI
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2914690", Offset = "0x2913090", VA = "0x182914690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static ELRCMLYBSCJ OTYCFEDMRPF
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2915600", Offset = "0x2914000", VA = "0x182915600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static ELRCMLYBSCJ LHXFTFPELQO
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2912AE0", Offset = "0x29114E0", VA = "0x182912AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static ELRCMLYBSCJ CRKSEXNPQZM
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2913AA0", Offset = "0x29124A0", VA = "0x182913AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static ELRCMLYBSCJ JLTFHPFFOUL
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2916390", Offset = "0x2914D90", VA = "0x182916390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static ELRCMLYBSCJ YTYWRGEKCVI
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2914190", Offset = "0x2912B90", VA = "0x182914190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static ELRCMLYBSCJ TFYONOZMYYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2915420", Offset = "0x2913E20", VA = "0x182915420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static ELRCMLYBSCJ DZDVUYCSZMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2914000", Offset = "0x2912A00", VA = "0x182914000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static ELRCMLYBSCJ ALOJWLQCADI
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2915FB0", Offset = "0x29149B0", VA = "0x182915FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static ELRCMLYBSCJ KAKZGLFKTFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2913E40", Offset = "0x2912840", VA = "0x182913E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static ELRCMLYBSCJ MQTUAIAGAMT
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x29137C0", Offset = "0x29121C0", VA = "0x1829137C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static ELRCMLYBSCJ GFYRJZQSXUQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x29131D0", Offset = "0x2911BD0", VA = "0x1829131D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static ELRCMLYBSCJ OQTHYZDVLTN
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x29155B0", Offset = "0x2913FB0", VA = "0x1829155B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static ELRCMLYBSCJ DDQMIEYMIDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2913050", Offset = "0x2911A50", VA = "0x182913050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static ELRCMLYBSCJ HPVACIRFQYA
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2913A50", Offset = "0x2912450", VA = "0x182913A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static ELRCMLYBSCJ MZCVDUBTWUK
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x29144B0", Offset = "0x2912EB0", VA = "0x1829144B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static ELRCMLYBSCJ JZWKYNIMYRI
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x29163E0", Offset = "0x2914DE0", VA = "0x1829163E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static ELRCMLYBSCJ WSWWCMYMPGQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2914A70", Offset = "0x2913470", VA = "0x182914A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static ELRCMLYBSCJ XCKCQZGVKMZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2914050", Offset = "0x2912A50", VA = "0x182914050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2913220", Offset = "0x2911C20", VA = "0x182913220")]
			public static ISRXXQTKLJD CXTQFZEYUXH([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2913B20", Offset = "0x2912520", VA = "0x182913B20")]
			public static ClassFactoryTypeParams GTZXBELFYIA(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2913AF0", Offset = "0x29124F0", VA = "0x182913AF0")]
			public static ClassFactoryTypeParams GTZXBELFYIA([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2916090", Offset = "0x2914A90", VA = "0x182916090")]
			public static ISRXXQTKLJD WFOYPBSTWDZ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2915260", Offset = "0x2913C60", VA = "0x182915260")]
			public static ISRXXQTKLJD RWBNBMCPVZQ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2915D40", Offset = "0x2914740", VA = "0x182915D40")]
			public static ISRXXQTKLJD VIVYLCBMZAE([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2915C90", Offset = "0x2914690", VA = "0x182915C90")]
			public static YUGSHIKOLKK VFSRXTTTPPK(Id32<GBNADADGGBI> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2914820", Offset = "0x2913220", VA = "0x182914820")]
			public static string PEUJJPQZGVN(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x29159B0", Offset = "0x29143B0", VA = "0x1829159B0")]
			private static YUGSHIKOLKK VFSRXTTTPPK(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2915150", Offset = "0x2913B50", VA = "0x182915150")]
			public static Id32<GBNADADGGBI>? RNMAWRFAOVT(YUGSHIKOLKK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2914C00", Offset = "0x2913600", VA = "0x182914C00")]
			public static CircuitTypeIdWrapper? QXBESKZHUYE(YUGSHIKOLKK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x29167F0", Offset = "0x29151F0", VA = "0x1829167F0")]
			static WZVJKNGTMQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2912C60", Offset = "0x2911660", VA = "0x182912C60")]
			[IteratorStateMachine(typeof(DXRKOVNYCOB))]
			private static IEnumerable<YUGSHIKOLKK> AUNCPSXCAQQ(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2913860", Offset = "0x2912260", VA = "0x182913860")]
			[IteratorStateMachine(typeof(UFUCRUYGQHR))]
			public static IEnumerable<YUGSHIKOLKK> EOUAWJXVDJH(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2912D10", Offset = "0x2911710", VA = "0x182912D10")]
			public static Variant BHDBPYLRXCG(YUGSHIKOLKK a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2913450", Offset = "0x2911E50", VA = "0x182913450")]
			public static Variant DRQIHSMNTDJ(YUGSHIKOLKK a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2913EE0", Offset = "0x29128E0", VA = "0x182913EE0")]
			public static bool JDXAFYWJENH(YUGSHIKOLKK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x29152E0", Offset = "0x2913CE0", VA = "0x1829152E0")]
			[IteratorStateMachine(typeof(OZIUSDUPXXA))]
			public static IEnumerable<Id32<GBNADADGGBI>> SLBUOPAMUKT(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IAQGKRNLFXR
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2901FB0", Offset = "0x29009B0", VA = "0x182901FB0")]
		public static KOSHUHSDIVA JVPEYACKYLR(this YUGSHIKOLKK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2903060", Offset = "0x2901A60", VA = "0x182903060")]
		public static YUGSHIKOLKK WDKEUGVWMDY(this KOSHUHSDIVA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FRZUHSDQXMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x369CB80", Offset = "0x369B580", VA = "0x18369CB80")]
		public static Dictionary<b, c> KBBURYMSOAS<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class VVUBOWPYBZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x29116E0", Offset = "0x29100E0", VA = "0x1829116E0")]
		public static WRNUVDVREEW JVPEYACKYLR([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x29117E0", Offset = "0x29101E0", VA = "0x1829117E0")]
		public static Guid WDKEUGVWMDY(WRNUVDVREEW a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RZBTUJPUSHT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x290F410", Offset = "0x290DE10", VA = "0x18290F410")]
		public static FJXZARPRGIE JVPEYACKYLR([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x290F4A0", Offset = "0x290DEA0", VA = "0x18290F4A0")]
		public static NamedType WDKEUGVWMDY(this FJXZARPRGIE a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class IMFMBNUMNCS
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x370A4F0", Offset = "0x3708EF0", VA = "0x18370A4F0")]
		public static void LGUGPDCUSLC<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x370A750", Offset = "0x3709150", VA = "0x18370A750")]
		public static void LGUGPDCUSLC<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class UVJJETBXBVL
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2911390", Offset = "0x290FD90", VA = "0x182911390")]
		public static RWMGIRAZNGU JVPEYACKYLR([In] this Variant self, YUGSHIKOLKK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2911590", Offset = "0x290FF90", VA = "0x182911590")]
		public static Variant WDKEUGVWMDY(this RWMGIRAZNGU a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class WBHAQSPHMBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<NBICJQIZBLT> PBEBWEBAWYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool FJCPALVYFSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool ZSHXNVHVTMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool XCOULOBITHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool NFERTTERHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool NFJYQZYOQMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool KHDVCVUCZHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool VVULTDTVEQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool FMHUPZPPKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, YUGSHIKOLKK Type)> TGQPEAUENEF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid CXQIBDZHUDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x28C5310", Offset = "0x28C3D10", VA = "0x1828C5310")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<NBICJQIZBLT> KJSVXBTPBNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x28C5310", Offset = "0x28C3D10", VA = "0x1828C5310")]
			get
			{
				return default(Id128<NBICJQIZBLT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, YUGSHIKOLKK Type)> IJMHIHOMYUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LQDPTOOCVLR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2912580", Offset = "0x2910F80", VA = "0x182912580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2911E70", Offset = "0x2910870", VA = "0x182911E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, YUGSHIKOLKK> AHEAXBUTXMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2911880", Offset = "0x2910280", VA = "0x182911880")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2911FC0", Offset = "0x29109C0", VA = "0x182911FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CEZWMTGHKAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2911B20", Offset = "0x2910520", VA = "0x182911B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2912070", Offset = "0x2910A70", VA = "0x182912070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> ORFQSGOESRX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2912470", Offset = "0x2910E70", VA = "0x182912470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2912320", Offset = "0x2910D20", VA = "0x182912320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, YUGSHIKOLKK> UCNCTJJQFKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2912270", Offset = "0x2910C70", VA = "0x182912270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2911F10", Offset = "0x2910910", VA = "0x182911F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action FORXYPNMQEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x29123D0", Offset = "0x2910DD0", VA = "0x1829123D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2912620", Offset = "0x2911020", VA = "0x182912620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18F7310", Offset = "0x18F5D10", VA = "0x1818F7310")]
		public void FJOFYGGSWDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x29129F0", Offset = "0x29113F0", VA = "0x1829129F0")]
		internal WBHAQSPHMBN([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, YUGSHIKOLKK Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x29121A0", Offset = "0x2910BA0", VA = "0x1829121A0")]
		public static CircuitEventDefinitionFactoryStart PBVLPMCLPSM(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2912120", Offset = "0x2910B20", VA = "0x182912120")]
		public static CircuitEventDefinitionFactoryStart PBVLPMCLPSM(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2911D60", Offset = "0x2910760", VA = "0x182911D60")]
		public static WBHAQSPHMBN GSKKGATXPMM([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x29126C0", Offset = "0x29110C0", VA = "0x1829126C0")]
		public static WBHAQSPHMBN YAZCMQSWONQ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
		public void DOWSCKGVXLU(Id128<NBICJQIZBLT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2912520", Offset = "0x2910F20", VA = "0x182912520")]
		public void VDFRQTOHDIN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2912900", Offset = "0x2911300", VA = "0x182912900")]
		public void YMOVXLSSDXH(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2911930", Offset = "0x2910330", VA = "0x182911930")]
		public void CQOCXERYGUS(int a, YUGSHIKOLKK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2911BD0", Offset = "0x29105D0", VA = "0x182911BD0")]
		public void FZWQOISUBOG(string a, YUGSHIKOLKK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2911CF0", Offset = "0x29106F0", VA = "0x182911CF0")]
		public void GETABGTOUHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2911A20", Offset = "0x2910420", VA = "0x182911A20")]
		public WBHAQSPHMBN Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct CircuitEventDefinitionFactoryStart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28FE970", Offset = "0x28FD370", VA = "0x1828FE970")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28FE6D0", Offset = "0x28FD0D0", VA = "0x1828FE6D0")]
		public CircuitEventDefinitionFactoryParams DXHVPHZIFZC(string a, YUGSHIKOLKK b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28FE840", Offset = "0x28FD240", VA = "0x1828FE840")]
		public WBHAQSPHMBN KYZXWOEKWKU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct CircuitEventDefinitionFactoryParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly List<(string Name, YUGSHIKOLKK Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28FE640", Offset = "0x28FD040", VA = "0x1828FE640")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, YUGSHIKOLKK Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28FE410", Offset = "0x28FCE10", VA = "0x1828FE410")]
		public CircuitEventDefinitionFactoryParams DXHVPHZIFZC(string a, YUGSHIKOLKK b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28FE540", Offset = "0x28FCF40", VA = "0x1828FE540")]
		public WBHAQSPHMBN KYZXWOEKWKU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JNOJMFNOQVC
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly WBHAQSPHMBN YEXOZASBOLX;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly WBHAQSPHMBN XYTRJRSJDYW;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly WBHAQSPHMBN HIPTXDWAYGF;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly WBHAQSPHMBN WTXXXHMSDLQ;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly WBHAQSPHMBN WNIBIDRNFAZ;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly WBHAQSPHMBN UFQVJIUXHUV;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly WBHAQSPHMBN HDZIGQPLUVQ;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly WBHAQSPHMBN[] VJLPPDFFUPF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class PVOCIBVZSOL
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly WBHAQSPHMBN SWIWBSEUHMR;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class CZAWYWRKKLY
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly WBHAQSPHMBN JYGCZJZRAYH;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly WBHAQSPHMBN TIKXGDRHPYQ;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class UIJALXXCZSD
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly WBHAQSPHMBN BPOQFESROLS;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly WBHAQSPHMBN CAMVPGZRLGR;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly WBHAQSPHMBN[] KXKNDXWJOJN;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly WBHAQSPHMBN UGHDJUZPUTZ;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly WBHAQSPHMBN SFQHONJSNPE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class RXHRPUGFMHF
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly WBHAQSPHMBN CEFXGRYEYOK;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly WBHAQSPHMBN QLDZLEFCUMP;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class ALWPBHZZIOU
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly WBHAQSPHMBN QRCIFSQYAZR;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly WBHAQSPHMBN NNQFHCSKQLI;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class SGZNWANIFMH
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly WBHAQSPHMBN JYGCZJZRAYH;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly WBHAQSPHMBN TIKXGDRHPYQ;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class LOWPVBYRNCT
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly WBHAQSPHMBN QCXDWTSNBCW;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly WBHAQSPHMBN LZGEOHOFUVT;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly WBHAQSPHMBN YDOPELGLGRV;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly WBHAQSPHMBN DASBHALJYLJ;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly WBHAQSPHMBN MOXTOFWAQSY;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly WBHAQSPHMBN WHCIOMZCZQJ;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly WBHAQSPHMBN BLGUILYUAVW;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class ZVYZQRVRSTZ
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class NAVCTXFCIEH
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class MJZTOUMAEWL
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class USUSSFOIJPN
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly WBHAQSPHMBN QHWKTNFRDVS;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly WBHAQSPHMBN FEFLEUOTGNX;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class IRJCGHGRGWR
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class MLDASCDNONJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class TNMAJBGWQZH
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class SEENKFDJPBY
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly WBHAQSPHMBN FHTTLXLEPLK;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly WBHAQSPHMBN IQQFILEPQVK;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly WBHAQSPHMBN BPFOQJNFPEB;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly WBHAQSPHMBN IVHTMDJJOSO;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly WBHAQSPHMBN PBMPNTPRYDQ;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly WBHAQSPHMBN QRCIFSQYAZR;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly WBHAQSPHMBN PYHYEAYWMUW;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly WBHAQSPHMBN BQVOJSSTKIH;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly WBHAQSPHMBN IESNTSNDHUB;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly WBHAQSPHMBN SSFYPLAPLVF;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly WBHAQSPHMBN XSENEWMDSSR;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly WBHAQSPHMBN IGCXNLCAOCH;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly WBHAQSPHMBN DZBKGTOHGJW;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly WBHAQSPHMBN YCEUMTUFVHH;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly WBHAQSPHMBN RUGZIQBCLEE;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly WBHAQSPHMBN ISHZASAXXUI;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly WBHAQSPHMBN ZQAKEESJTQO;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly WBHAQSPHMBN HPCAQPWAGLB;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly WBHAQSPHMBN XBPROPOVWRU;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly WBHAQSPHMBN DQPQEKIXZKY;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly WBHAQSPHMBN HRAVZTLILKP;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly WBHAQSPHMBN FGZRXVGYMKP;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly WBHAQSPHMBN OLZXJHJQFPR;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly WBHAQSPHMBN MHEHAOLDBHN;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly WBHAQSPHMBN DXENNHLOTSZ;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly WBHAQSPHMBN BPXLDDCNQRT;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly WBHAQSPHMBN SWUTUFFMVSJ;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly WBHAQSPHMBN JYLJRETNAJL;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly WBHAQSPHMBN KVVDQZYTMIA;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly WBHAQSPHMBN RNGEUKCAFDG;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly WBHAQSPHMBN YTBBEXKPHSB;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly WBHAQSPHMBN MQMDQYRDWHP;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly WBHAQSPHMBN QFCSROUTYYM;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly WBHAQSPHMBN VKKGLODHKKQ;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly WBHAQSPHMBN POXPUEPZOFC;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly WBHAQSPHMBN DBUUBGEGVOM;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly WBHAQSPHMBN LMCNDUGUDPK;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly WBHAQSPHMBN RNUZJCSEIJA;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly WBHAQSPHMBN XWHQJSEWPWW;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly WBHAQSPHMBN OUVBKRZXPQK;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly WBHAQSPHMBN TIBQUNFRNLL;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly WBHAQSPHMBN KCTRWUBQQKB;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly WBHAQSPHMBN BHVXJSIBXHZ;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly WBHAQSPHMBN HMYRWHXKEXH;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly WBHAQSPHMBN GSYPLLNSKFR;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly WBHAQSPHMBN AMOSUAJTTLZ;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly WBHAQSPHMBN HYXPIMARYNT;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly WBHAQSPHMBN RXUJSPMJVAD;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly WBHAQSPHMBN HTPWBHZEKOV;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly WBHAQSPHMBN HBCGAUZKWYD;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly WBHAQSPHMBN FCERZSHAMWO;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly WBHAQSPHMBN VPLMFMLLIWR;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly WBHAQSPHMBN DETSGRRRFCV;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly WBHAQSPHMBN UWPEVPZFAIB;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly WBHAQSPHMBN JDGIAQVUXAH;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly WBHAQSPHMBN GGWYBLAZXAJ;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly WBHAQSPHMBN KLHFZLJYGYD;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly WBHAQSPHMBN YILKPPRAXTR;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly WBHAQSPHMBN DTWQCLRMHIR;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly WBHAQSPHMBN EKPQYYGZCBV;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly WBHAQSPHMBN ULNLKXMTNFL;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly WBHAQSPHMBN OUGDEPJWGEL;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly WBHAQSPHMBN XQNTCXWKNUS;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly WBHAQSPHMBN DBWZZRWMZMV;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly WBHAQSPHMBN JPKNWLZQZCJ;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly WBHAQSPHMBN ZGSRMBPVGHS;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly WBHAQSPHMBN TBCAEIVSOIE;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly WBHAQSPHMBN RNHSZHELUGH;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly WBHAQSPHMBN AZYZPMXHOGD;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class NKLMOROHUXC
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class VRUDFAYTKER
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly WBHAQSPHMBN TODIFOCXXIX;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly WBHAQSPHMBN ONUSGAKICDK;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly WBHAQSPHMBN TAMIGLKMDDG;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly WBHAQSPHMBN GJGBUWPLTRF;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly WBHAQSPHMBN DNHTJVJTUKT;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly WBHAQSPHMBN YZFVTMVZYSR;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly WBHAQSPHMBN LATGQJMSDTF;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class XVROTLSVHHO
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly WBHAQSPHMBN IQQFILEPQVK;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly WBHAQSPHMBN BPFOQJNFPEB;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly WBHAQSPHMBN IVHTMDJJOSO;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly WBHAQSPHMBN IZLNFFZRNQE;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly WBHAQSPHMBN ZETOLNUVGMY;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly WBHAQSPHMBN REAYJZNWMQY;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly WBHAQSPHMBN GURULSUCFMQ;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EPUZZRBXNMG
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly WBHAQSPHMBN WDDQKAPEVZY;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly WBHAQSPHMBN AKQUIBGRUWA;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly WBHAQSPHMBN IOSODFHAAYB;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly WBHAQSPHMBN XHLYOQKCNMT;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly WBHAQSPHMBN XKDDIZKYWYR;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly WBHAQSPHMBN LRUDBBGIXZT;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class VZHYLYXWPXL
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class PFVODIFVPLC
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly WBHAQSPHMBN GNDVPJRVODQ;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class UBFHNBEKIJY
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly WBHAQSPHMBN FHTTLXLEPLK;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class DACASEEIDJL
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class YTWRJACHQXE
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class AKXOFROAICH
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly WBHAQSPHMBN EPRNIVXGAIF;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly WBHAQSPHMBN OANMFVJFIMH;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly WBHAQSPHMBN JGEJSJPBKZM;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly WBHAQSPHMBN MYLMYIQDYVA;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class QXTNQNTERBL
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly WBHAQSPHMBN XPZHAAHAYDI;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly WBHAQSPHMBN HIQSJQXLWSL;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class DLXAVVXLZEZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class XYJPBHRDBYZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly WBHAQSPHMBN TODIFOCXXIX;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly WBHAQSPHMBN ONUSGAKICDK;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class ZOYOEUDPQAC
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly WBHAQSPHMBN XZZZIQZTVGF;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly WBHAQSPHMBN GJGBUWPLTRF;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly WBHAQSPHMBN DNHTJVJTUKT;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly WBHAQSPHMBN YZFVTMVZYSR;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly WBHAQSPHMBN NNTXALTAUJU;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly WBHAQSPHMBN YYCKAOTOUFR;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly WBHAQSPHMBN FVUSNBVXCVV;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly WBHAQSPHMBN HVRNYYHSLYF;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly WBHAQSPHMBN UVLCWUTQOVI;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly WBHAQSPHMBN PIBGYYAZLVM;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly WBHAQSPHMBN TODIFOCXXIX;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly WBHAQSPHMBN ONUSGAKICDK;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class DDMUVBPPJEO
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class YPENXNDDFNI
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly WBHAQSPHMBN TODIFOCXXIX;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly WBHAQSPHMBN ONUSGAKICDK;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly WBHAQSPHMBN ILSRYISMOQI;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly WBHAQSPHMBN RODPHPAOGDU;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly WBHAQSPHMBN YUDFHPDORZL;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class KLIQBDCQJRD
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class NRIVQTTYOCU
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly WBHAQSPHMBN CVNLZSOPVIJ;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class JDHBFGRONIE
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly WBHAQSPHMBN NOLPHRYCDUA;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly WBHAQSPHMBN ZRFFEBSIBZD;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly WBHAQSPHMBN TODIFOCXXIX;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly WBHAQSPHMBN ONUSGAKICDK;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class NUJKGREJACL
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class FVWOCUKBZLR
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class FSHPUZWWKYU
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class PEYBKZZRJTW
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class BQRFNXVIXDX
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class BCNZCACVSPD
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly WBHAQSPHMBN QHWKTNFRDVS;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly WBHAQSPHMBN FEFLEUOTGNX;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class UNVCMJHTEXJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly WBHAQSPHMBN MQGOFXRCVAG;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly WBHAQSPHMBN SEZSTAWMMOQ;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly WBHAQSPHMBN KUOINBODCBO;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly WBHAQSPHMBN XSCIUVFRRAS;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class DZNXFVZGSHG
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly WBHAQSPHMBN MQGOFXRCVAG;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly WBHAQSPHMBN SEZSTAWMMOQ;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly WBHAQSPHMBN KUOINBODCBO;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly WBHAQSPHMBN XSCIUVFRRAS;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class HHWOUUXYUIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class RNRFSOXRAKK
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly WBHAQSPHMBN YRLPOCWQEVP;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly WBHAQSPHMBN DJVWRFHSBAP;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly WBHAQSPHMBN KGHOHFEYMKT;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class DOCVXBBCHCX
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly WBHAQSPHMBN JPCURZBNVBG;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly WBHAQSPHMBN XMZUMHAKWVI;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly WBHAQSPHMBN IAJMKQIMIWP;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class CYLXYRJGXBY
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class TEFNPKGOLPZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly WBHAQSPHMBN NZLCLDYCUNB;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly WBHAQSPHMBN CBEMZLVXIPH;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly WBHAQSPHMBN MIBCBFVIGBE;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly WBHAQSPHMBN TORTUQKCBFU;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly WBHAQSPHMBN XGVKCWEEZGP;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class QFNNMSPOTPU
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly WBHAQSPHMBN CAPNFWOYNEX;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class VJGJUUXPVPG
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly WBHAQSPHMBN WZTCOJAAMRQ;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly WBHAQSPHMBN LFADKGPCBGH;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly WBHAQSPHMBN VPFIHMPTNRM;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class NBMSSMDUYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class JGIJCUVEEGN
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class XGNBUQNHBXK
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class PKWSRXAHIRN
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly WBHAQSPHMBN EWUYFNAUSEQ;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly WBHAQSPHMBN LZYOFWOSRVP;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly WBHAQSPHMBN XNSWXJYCKHN;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly WBHAQSPHMBN ZCGRXIFUNMH;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly WBHAQSPHMBN SHLCHHTMDCY;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly WBHAQSPHMBN SJOALTLRIZA;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly WBHAQSPHMBN ICENOBKRKZX;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class GGAAYSQHQXR
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly WBHAQSPHMBN NLFTLBXAMRY;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly WBHAQSPHMBN[] CURWTPTDQAO;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class HWPQTBQYEPT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly YUGSHIKOLKK QMNDYJXRPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<WBHAQSPHMBN> SUCTHCSIZUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<WBHAQSPHMBN> LAYPZZYDVAJ;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<WBHAQSPHMBN> JPZNJPLNDBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<WBHAQSPHMBN> MRMRHFDXWEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2922060", Offset = "0x2920A60", VA = "0x182922060")]
		protected HWPQTBQYEPT(YUGSHIKOLKK a, params WBHAQSPHMBN[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NGDNMQFMKOT : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2923BF0", Offset = "0x29225F0", VA = "0x182923BF0")]
		internal NGDNMQFMKOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QBMUQOPDOAA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x29255C0", Offset = "0x2923FC0", VA = "0x1829255C0")]
		internal QBMUQOPDOAA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class AVNZZGLIMVJ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x291E220", Offset = "0x291CC20", VA = "0x18291E220")]
		internal AVNZZGLIMVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class VHBTYFUOUJK : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2928640", Offset = "0x2927040", VA = "0x182928640")]
		internal VHBTYFUOUJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class BHGMAWHJTGP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x291E7C0", Offset = "0x291D1C0", VA = "0x18291E7C0")]
		internal BHGMAWHJTGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class QPGVFCDGGHV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2925970", Offset = "0x2924370", VA = "0x182925970")]
		internal QPGVFCDGGHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class WJBDQNRUUGS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2929A60", Offset = "0x2928460", VA = "0x182929A60")]
		internal WJBDQNRUUGS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class FUNUTDZFFGX : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2920B90", Offset = "0x291F590", VA = "0x182920B90")]
		internal FUNUTDZFFGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class VKBQINRAIVN : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2928DA0", Offset = "0x29277A0", VA = "0x182928DA0")]
		internal VKBQINRAIVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class LDVRBMLGTFN : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2923280", Offset = "0x2921C80", VA = "0x182923280")]
		internal LDVRBMLGTFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GQTHWKXGZEH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2921490", Offset = "0x291FE90", VA = "0x182921490")]
		internal GQTHWKXGZEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class XAIMTNHBUWH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2929E60", Offset = "0x2928860", VA = "0x182929E60")]
		internal XAIMTNHBUWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class GQQLQBYWNGL : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x29212C0", Offset = "0x291FCC0", VA = "0x1829212C0")]
		internal GQQLQBYWNGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class KQWYCXKHAIJ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2922FD0", Offset = "0x29219D0", VA = "0x182922FD0")]
		internal KQWYCXKHAIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ZVVCHKJSBOZ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x292DCF0", Offset = "0x292C6F0", VA = "0x18292DCF0")]
		internal ZVVCHKJSBOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class MJTPJEHFDLV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x29239C0", Offset = "0x29223C0", VA = "0x1829239C0")]
		internal MJTPJEHFDLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class TKERHJXVYHH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x29278F0", Offset = "0x29262F0", VA = "0x1829278F0")]
		internal TKERHJXVYHH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class BPZIITLLLPS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x291ED30", Offset = "0x291D730", VA = "0x18291ED30")]
		internal BPZIITLLLPS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class LDXQOMJJTNQ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2923450", Offset = "0x2921E50", VA = "0x182923450")]
		internal LDXQOMJJTNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class YNTYSNOGQLS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x292BBB0", Offset = "0x292A5B0", VA = "0x18292BBB0")]
		internal YNTYSNOGQLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class DXXYOQMFINM : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x291F570", Offset = "0x291DF70", VA = "0x18291F570")]
		internal DXXYOQMFINM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class OOCFLOYDALI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2924570", Offset = "0x2922F70", VA = "0x182924570")]
		internal OOCFLOYDALI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class EICQMDTMIXH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x291FE30", Offset = "0x291E830", VA = "0x18291FE30")]
		internal EICQMDTMIXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class SODMMGNOTWS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2926A30", Offset = "0x2925430", VA = "0x182926A30")]
		internal SODMMGNOTWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JPCNJHKQVXP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2922A00", Offset = "0x2921400", VA = "0x182922A00")]
		internal JPCNJHKQVXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class WKISAEEVYEE : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2929C30", Offset = "0x2928630", VA = "0x182929C30")]
		internal WKISAEEVYEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class LNQYEUBZSEK : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x29237F0", Offset = "0x29221F0", VA = "0x1829237F0")]
		internal LNQYEUBZSEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZYRGCCRDCSM : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x292DEC0", Offset = "0x292C8C0", VA = "0x18292DEC0")]
		internal ZYRGCCRDCSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ZZPSSYGTRDL : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x292E090", Offset = "0x292CA90", VA = "0x18292E090")]
		internal ZZPSSYGTRDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YAKRYJXVXPW : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x292B9E0", Offset = "0x292A3E0", VA = "0x18292B9E0")]
		internal YAKRYJXVXPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class RWQZBBFESHZ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2926800", Offset = "0x2925200", VA = "0x182926800")]
		internal RWQZBBFESHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class PWJWQHFKAEV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x29253F0", Offset = "0x2923DF0", VA = "0x1829253F0")]
		internal PWJWQHFKAEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class KDCFIOISENX : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2922BD0", Offset = "0x29215D0", VA = "0x182922BD0")]
		internal KDCFIOISENX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XYTEGJJMJOY : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x292B790", Offset = "0x292A190", VA = "0x18292B790")]
		internal XYTEGJJMJOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class TKBCIDJEKAI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2927720", Offset = "0x2926120", VA = "0x182927720")]
		internal TKBCIDJEKAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class IPEMQACIJNG : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x29221D0", Offset = "0x2920BD0", VA = "0x1829221D0")]
		internal IPEMQACIJNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class OVNDGTQUHON : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2924990", Offset = "0x2923390", VA = "0x182924990")]
		internal OVNDGTQUHON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class YOMRRJOILKG : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x292BFE0", Offset = "0x292A9E0", VA = "0x18292BFE0")]
		internal YOMRRJOILKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class EWJUPXFQQPI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x29208E0", Offset = "0x291F2E0", VA = "0x1829208E0")]
		internal EWJUPXFQQPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class AKIZABNJYML : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x291D640", Offset = "0x291C040", VA = "0x18291D640")]
		internal AKIZABNJYML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class ZBFMUARBSFF : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x292CAC0", Offset = "0x292B4C0", VA = "0x18292CAC0")]
		internal ZBFMUARBSFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class KPHDDOAICTR : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2922E00", Offset = "0x2921800", VA = "0x182922E00")]
		internal KPHDDOAICTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class BNUAYZWQUNI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x291EB60", Offset = "0x291D560", VA = "0x18291EB60")]
		internal BNUAYZWQUNI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PCXKLZLOAVE : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2924B60", Offset = "0x2923560", VA = "0x182924B60")]
		internal PCXKLZLOAVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class REUSDDDKTVX : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2925EE0", Offset = "0x29248E0", VA = "0x182925EE0")]
		internal REUSDDDKTVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class YTSOCWXLQPK : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x292C890", Offset = "0x292B290", VA = "0x18292C890")]
		internal YTSOCWXLQPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class HSZSEAZTWWP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2921E90", Offset = "0x2920890", VA = "0x182921E90")]
		internal HSZSEAZTWWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class HLQRURJMKHU : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2921CC0", Offset = "0x29206C0", VA = "0x182921CC0")]
		internal HLQRURJMKHU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class ATWCMYBOMVW : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x291E050", Offset = "0x291CA50", VA = "0x18291E050")]
		internal ATWCMYBOMVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class UCULYQZOMSV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2927C50", Offset = "0x2926650", VA = "0x182927C50")]
		internal UCULYQZOMSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class ZTMRVOJVLMR : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x292DB20", Offset = "0x292C520", VA = "0x18292DB20")]
		internal ZTMRVOJVLMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BMYXBQDEBYA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x291E990", Offset = "0x291D390", VA = "0x18291E990")]
		internal BMYXBQDEBYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class KXQWVJJDQXP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x29230B0", Offset = "0x2921AB0", VA = "0x1829230B0")]
		internal KXQWVJJDQXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class TCQBXANDXHS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2926C00", Offset = "0x2925600", VA = "0x182926C00")]
		internal TCQBXANDXHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class RMBXQEURJJI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x29260B0", Offset = "0x2924AB0", VA = "0x1829260B0")]
		internal RMBXQEURJJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class OUYTPCMYGDY : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x29247C0", Offset = "0x29231C0", VA = "0x1829247C0")]
		internal OUYTPCMYGDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class NVEPTZXJXPA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2924130", Offset = "0x2922B30", VA = "0x182924130")]
		internal NVEPTZXJXPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class VRVVINOMTMB : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2929830", Offset = "0x2928230", VA = "0x182929830")]
		internal VRVVINOMTMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ZPGAVEDGRYA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x292D950", Offset = "0x292C350", VA = "0x18292D950")]
		internal ZPGAVEDGRYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class LIQHVZNONEC : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2923620", Offset = "0x2922020", VA = "0x182923620")]
		internal LIQHVZNONEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class VIRWPEBQOLP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2928810", Offset = "0x2927210", VA = "0x182928810")]
		internal VIRWPEBQOLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class GOEBQISKAKO : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2921170", Offset = "0x291FB70", VA = "0x182921170")]
		internal GOEBQISKAKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class VFIMKSNNHYL : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x29284F0", Offset = "0x2926EF0", VA = "0x1829284F0")]
		internal VFIMKSNNHYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class GIRTTZRSAZG : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2921020", Offset = "0x291FA20", VA = "0x182921020")]
		internal GIRTTZRSAZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class YOLYHGNGFCW : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x292BD90", Offset = "0x292A790", VA = "0x18292BD90")]
		internal YOLYHGNGFCW()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, BYEJVEWXCEM<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly YUGSHIKOLKK Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
		private NamedType(string name, YUGSHIKOLKK type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x285CA50", Offset = "0x285B450", VA = "0x18285CA50")]
		public static NamedType New(string name, YUGSHIKOLKK type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x29243B0", Offset = "0x2922DB0", VA = "0x1829243B0")]
		public static bool FYOQTCVQVIR([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x29243B0", Offset = "0x2922DB0", VA = "0x1829243B0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x29243B0", Offset = "0x2922DB0", VA = "0x1829243B0")]
		public bool QGNBNUHOAWV([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2924300", Offset = "0x2922D00", VA = "0x182924300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2924400", Offset = "0x2922E00", VA = "0x182924400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x29244F0", Offset = "0x2922EF0", VA = "0x1829244F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2924530", Offset = "0x2922F30", VA = "0x182924530")]
		public string VLUEQOEKHUZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2924470", Offset = "0x2922E70", VA = "0x182924470")]
		public string LSQEAKIEMZL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x29243B0", Offset = "0x2922DB0", VA = "0x1829243B0", Slot = "5")]
		private bool JFKGZWHIFTO([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface ZYLAWNEORYA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, AGEZPYTJJRF>> ONLJJASTUMB(LPVLEQQBKYR a, bool b);
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
