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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F1DE0", Offset = "0x28F05E0", VA = "0x1828F1DE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F1C40", Offset = "0x28F0440", VA = "0x1828F1C40", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28EF6F0", Offset = "0x28EDEF0", VA = "0x1828EF6F0")]
		public static bool UZWXDJLHPWE(this YUGSHIKOLKK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28EF630", Offset = "0x28EDE30", VA = "0x1828EF630")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x28F9D00", Offset = "0x28F8500", VA = "0x1828F9D00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x28F9A20", Offset = "0x28F8220", VA = "0x1828F9A20")]
			public static HWPQTBQYEPT FWFYDRDQEZP(Id32<OBQCFAINAAA> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28F9D50", Offset = "0x28F8550", VA = "0x1828F9D50")]
			public static bool QIXOAWVWETI(Id32<OBQCFAINAAA> id, [Out] HWPQTBQYEPT a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x28F9DE0", Offset = "0x28F85E0", VA = "0x1828F9DE0")]
			public static YUGSHIKOLKK VFSRXTTTPPK(Id32<OBQCFAINAAA> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x28F9AA0", Offset = "0x28F82A0", VA = "0x1828F9AA0")]
			private static Id32<OBQCFAINAAA> JIBLBJTHOBM(HWPQTBQYEPT a, Id32<OBQCFAINAAA> id)
			{
				return default(Id32<OBQCFAINAAA>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28F9B30", Offset = "0x28F8330", VA = "0x1828F9B30")]
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
				[Cpp2IlInjected.Address(RVA = "0xFED370", Offset = "0xFEBB70", VA = "0x180FED370")]
				private TypeRegistryFactory([In] IdUnsafeList<GBNADADGGBI, YUGSHIKOLKK?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x28FD500", Offset = "0x28FBD00", VA = "0x1828FD500")]
				public static TypeRegistryFactory PBVLPMCLPSM()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x28FD1B0", Offset = "0x28FB9B0", VA = "0x1828FD1B0")]
				public (ReadOnlyIdArray<GBNADADGGBI, YUGSHIKOLKK>, IReadOnlyDictionary<YUGSHIKOLKK, Id32<GBNADADGGBI>>) KYZXWOEKWKU()
				{
					return default((ReadOnlyIdArray<GBNADADGGBI, YUGSHIKOLKK>, IReadOnlyDictionary<YUGSHIKOLKK, Id32<GBNADADGGBI>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x28FD560", Offset = "0x28FBD60", VA = "0x1828FD560")]
				public Id32<GBNADADGGBI> XTLZBPGEFOG(int a, YUGSHIKOLKK b)
				{
					return default(Id32<GBNADADGGBI>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x28FD160", Offset = "0x28FB960", VA = "0x1828FD160")]
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
					[Cpp2IlInjected.Address(RVA = "0x28F26D0", Offset = "0x28F0ED0", VA = "0x1828F26D0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x28F2890", Offset = "0x28F1090", VA = "0x1828F2890")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<GBNADADGGBI> UPUFBJQQEPU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x28F2790", Offset = "0x28F0F90", VA = "0x1828F2790")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x28F2850", Offset = "0x28F1050", VA = "0x1828F2850")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<GBNADADGGBI> QYQSJDCQGXT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x28F2810", Offset = "0x28F1010", VA = "0x1828F2810")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x28F27D0", Offset = "0x28F0FD0", VA = "0x1828F27D0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<GBNADADGGBI> ZBXOIGAZEEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x28F28D0", Offset = "0x28F10D0", VA = "0x1828F28D0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x28F2710", Offset = "0x28F0F10", VA = "0x1828F2710")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<GBNADADGGBI> JQYSSFYAZVD
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x28F2910", Offset = "0x28F1110", VA = "0x1828F2910")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x28F2690", Offset = "0x28F0E90", VA = "0x1828F2690")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<GBNADADGGBI> VIVYLCBMZAE
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x28F2750", Offset = "0x28F0F50", VA = "0x1828F2750")]
					[CompilerGenerated]
					get
					{
						return default(Id32<GBNADADGGBI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x28F2950", Offset = "0x28F1150", VA = "0x1828F2950")]
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
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xD38BD0", Offset = "0xD373D0", VA = "0x180D38BD0")]
				[DebuggerHidden]
				public UFUCRUYGQHR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x28FE010", Offset = "0x28FC810", VA = "0x1828FE010", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x28FDC20", Offset = "0x28FC420", VA = "0x1828FDC20", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x28FE0A0", Offset = "0x28FC8A0", VA = "0x1828FE0A0")]
				private void SNXRWXESNLS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x28FE0F0", Offset = "0x28FC8F0", VA = "0x1828FE0F0", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x28FE130", Offset = "0x28FC930", VA = "0x1828FE130", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<YUGSHIKOLKK> XENIENHIVBI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x28FE130", Offset = "0x28FC930", VA = "0x1828FE130", Slot = "5")]
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
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xD38BD0", Offset = "0xD373D0", VA = "0x180D38BD0")]
				[DebuggerHidden]
				public DXRKOVNYCOB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x28ED630", Offset = "0x28EBE30", VA = "0x1828ED630", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x28EF540", Offset = "0x28EDD40", VA = "0x1828EF540", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x28EF580", Offset = "0x28EDD80", VA = "0x1828EF580", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<YUGSHIKOLKK> XENIENHIVBI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x28EF580", Offset = "0x28EDD80", VA = "0x1828EF580", Slot = "5")]
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
					[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB42FA0", VA = "0x180B447A0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x28F2410", Offset = "0x28F0C10", VA = "0x1828F2410", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x12C4CC0", Offset = "0x12C34C0", VA = "0x1812C4CC0")]
				[DebuggerHidden]
				public OZIUSDUPXXA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x28F2460", Offset = "0x28F0C60", VA = "0x1828F2460", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x28F1F10", Offset = "0x28F0710", VA = "0x1828F1F10", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x28F25B0", Offset = "0x28F0DB0", VA = "0x1828F25B0")]
				private void SNXRWXESNLS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x28F2600", Offset = "0x28F0E00", VA = "0x1828F2600")]
				private void SONMORMKPTT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x28F2650", Offset = "0x28F0E50", VA = "0x1828F2650", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x28F1E60", Offset = "0x28F0660", VA = "0x1828F1E60", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<GBNADADGGBI>> DAEDJCZVQIF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x28F1E60", Offset = "0x28F0660", VA = "0x1828F1E60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet BURMQQIRYAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet AZVJIXQFNYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xB6B550", Offset = "0xB69D50", VA = "0x180B6B550")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static YUGSHIKOLKK EWTYDXWTKWU
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2901630", Offset = "0x28FFE30", VA = "0x182901630")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static YUGSHIKOLKK UPUFBJQQEPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2902300", Offset = "0x2900B00", VA = "0x182902300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static YUGSHIKOLKK QYQSJDCQGXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2902CA0", Offset = "0x29014A0", VA = "0x182902CA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static YUGSHIKOLKK ZBXOIGAZEEZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2903230", Offset = "0x2901A30", VA = "0x182903230")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static YUGSHIKOLKK TCDSXKMGUBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x29009C0", Offset = "0x28FF1C0", VA = "0x1829009C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static YUGSHIKOLKK HZVZABJIUPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x29004A0", Offset = "0x28FECA0", VA = "0x1829004A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static YUGSHIKOLKK YMRJCGGWIOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2902980", Offset = "0x2901180", VA = "0x182902980")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static YUGSHIKOLKK JQYSSFYAZVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2903910", Offset = "0x2902110", VA = "0x182903910")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static ELRCMLYBSCJ ZHBJNVYJMZF
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2901C40", Offset = "0x2900440", VA = "0x182901C40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903C50", Offset = "0x2902450", VA = "0x182903C50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901320", Offset = "0x28FFB20", VA = "0x182901320")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903DE0", Offset = "0x29025E0", VA = "0x182903DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900CD0", Offset = "0x28FF4D0", VA = "0x182900CD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903D40", Offset = "0x2902540", VA = "0x182903D40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902430", Offset = "0x2900C30", VA = "0x182902430")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900920", Offset = "0x28FF120", VA = "0x182900920")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903E30", Offset = "0x2902630", VA = "0x182903E30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902BA0", Offset = "0x29013A0", VA = "0x182902BA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902260", Offset = "0x2900A60", VA = "0x182902260")]
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
				[Cpp2IlInjected.Address(RVA = "0x29037D0", Offset = "0x2901FD0", VA = "0x1829037D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901230", Offset = "0x28FFA30", VA = "0x182901230")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902890", Offset = "0x2901090", VA = "0x182902890")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903140", Offset = "0x2901940", VA = "0x182903140")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902DD0", Offset = "0x29015D0", VA = "0x182902DD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902000", Offset = "0x2900800", VA = "0x182902000")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900C80", Offset = "0x28FF480", VA = "0x182900C80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900C30", Offset = "0x28FF430", VA = "0x182900C30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902E20", Offset = "0x2901620", VA = "0x182902E20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903A20", Offset = "0x2902220", VA = "0x182903A20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901880", Offset = "0x2900080", VA = "0x182901880")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901F10", Offset = "0x2900710", VA = "0x182901F10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901710", Offset = "0x28FFF10", VA = "0x182901710")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902480", Offset = "0x2900C80", VA = "0x182902480")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900AA0", Offset = "0x28FF2A0", VA = "0x182900AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29030A0", Offset = "0x29018A0", VA = "0x1829030A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2904060", Offset = "0x2902860", VA = "0x182904060")]
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
				[Cpp2IlInjected.Address(RVA = "0x29020A0", Offset = "0x29008A0", VA = "0x1829020A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29028E0", Offset = "0x29010E0", VA = "0x1829028E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903BB0", Offset = "0x29023B0", VA = "0x182903BB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29021C0", Offset = "0x29009C0", VA = "0x1829021C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901280", Offset = "0x28FFA80", VA = "0x182901280")]
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
				[Cpp2IlInjected.Address(RVA = "0x29039D0", Offset = "0x29021D0", VA = "0x1829039D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901E20", Offset = "0x2900620", VA = "0x182901E20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903ED0", Offset = "0x29026D0", VA = "0x182903ED0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903780", Offset = "0x2901F80", VA = "0x182903780")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903B10", Offset = "0x2902310", VA = "0x182903B10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903C00", Offset = "0x2902400", VA = "0x182903C00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901CE0", Offset = "0x29004E0", VA = "0x182901CE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901BA0", Offset = "0x29003A0", VA = "0x182901BA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29014F0", Offset = "0x28FFCF0", VA = "0x1829014F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902A10", Offset = "0x2901210", VA = "0x182902A10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901D30", Offset = "0x2900530", VA = "0x182901D30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900D20", Offset = "0x28FF520", VA = "0x182900D20")]
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
				[Cpp2IlInjected.Address(RVA = "0x29030F0", Offset = "0x29018F0", VA = "0x1829030F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901B50", Offset = "0x2900350", VA = "0x182901B50")]
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
				[Cpp2IlInjected.Address(RVA = "0x29020F0", Offset = "0x29008F0", VA = "0x1829020F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903050", Offset = "0x2901850", VA = "0x182903050")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901A10", Offset = "0x2900210", VA = "0x182901A10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903A70", Offset = "0x2902270", VA = "0x182903A70")]
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
				[Cpp2IlInjected.Address(RVA = "0x29008D0", Offset = "0x28FF0D0", VA = "0x1829008D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900450", Offset = "0x28FEC50", VA = "0x182900450")]
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
				[Cpp2IlInjected.Address(RVA = "0x29017B0", Offset = "0x28FFFB0", VA = "0x1829017B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29024D0", Offset = "0x2900CD0", VA = "0x1829024D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901EC0", Offset = "0x29006C0", VA = "0x182901EC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902930", Offset = "0x2901130", VA = "0x182902930")]
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
				[Cpp2IlInjected.Address(RVA = "0x29019C0", Offset = "0x29001C0", VA = "0x1829019C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901090", Offset = "0x28FF890", VA = "0x182901090")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903820", Offset = "0x2902020", VA = "0x182903820")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901F60", Offset = "0x2900760", VA = "0x182901F60")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901BF0", Offset = "0x29003F0", VA = "0x182901BF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903FC0", Offset = "0x29027C0", VA = "0x182903FC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901590", Offset = "0x28FFD90", VA = "0x182901590")]
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
				[Cpp2IlInjected.Address(RVA = "0x29023E0", Offset = "0x2900BE0", VA = "0x1829023E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901B00", Offset = "0x2900300", VA = "0x182901B00")]
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
				[Cpp2IlInjected.Address(RVA = "0x29040B0", Offset = "0x29028B0", VA = "0x1829040B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901540", Offset = "0x28FFD40", VA = "0x182901540")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900530", Offset = "0x28FED30", VA = "0x182900530")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902F60", Offset = "0x2901760", VA = "0x182902F60")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903870", Offset = "0x2902070", VA = "0x182903870")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901040", Offset = "0x28FF840", VA = "0x182901040")]
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
				[Cpp2IlInjected.Address(RVA = "0x2904010", Offset = "0x2902810", VA = "0x182904010")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903D90", Offset = "0x2902590", VA = "0x182903D90")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902210", Offset = "0x2900A10", VA = "0x182902210")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902B20", Offset = "0x2901320", VA = "0x182902B20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903F20", Offset = "0x2902720", VA = "0x182903F20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901C90", Offset = "0x2900490", VA = "0x182901C90")]
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
				[Cpp2IlInjected.Address(RVA = "0x29015E0", Offset = "0x28FFDE0", VA = "0x1829015E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902E70", Offset = "0x2901670", VA = "0x182902E70")]
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
				[Cpp2IlInjected.Address(RVA = "0x29031E0", Offset = "0x29019E0", VA = "0x1829031E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901A60", Offset = "0x2900260", VA = "0x182901A60")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902AD0", Offset = "0x29012D0", VA = "0x182902AD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901130", Offset = "0x28FF930", VA = "0x182901130")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903190", Offset = "0x2901990", VA = "0x182903190")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902D80", Offset = "0x2901580", VA = "0x182902D80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903B60", Offset = "0x2902360", VA = "0x182903B60")]
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
				[Cpp2IlInjected.Address(RVA = "0x29018D0", Offset = "0x29000D0", VA = "0x1829018D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901E70", Offset = "0x2900670", VA = "0x182901E70")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903E80", Offset = "0x2902680", VA = "0x182903E80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903000", Offset = "0x2901800", VA = "0x182903000")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903AC0", Offset = "0x29022C0", VA = "0x182903AC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902050", Offset = "0x2900850", VA = "0x182902050")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900A50", Offset = "0x28FF250", VA = "0x182900A50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901D80", Offset = "0x2900580", VA = "0x182901D80")]
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
				[Cpp2IlInjected.Address(RVA = "0x29016C0", Offset = "0x28FFEC0", VA = "0x1829016C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29012D0", Offset = "0x28FFAD0", VA = "0x1829012D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x29022B0", Offset = "0x2900AB0", VA = "0x1829022B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902FB0", Offset = "0x29017B0", VA = "0x182902FB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903F70", Offset = "0x2902770", VA = "0x182903F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901FB0", Offset = "0x29007B0", VA = "0x182901FB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902F10", Offset = "0x2901710", VA = "0x182902F10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900400", Offset = "0x28FEC00", VA = "0x182900400")]
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
				[Cpp2IlInjected.Address(RVA = "0x29013C0", Offset = "0x28FFBC0", VA = "0x1829013C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903CA0", Offset = "0x29024A0", VA = "0x182903CA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901AB0", Offset = "0x29002B0", VA = "0x182901AB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902D30", Offset = "0x2901530", VA = "0x182902D30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901920", Offset = "0x2900120", VA = "0x182901920")]
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
				[Cpp2IlInjected.Address(RVA = "0x29038C0", Offset = "0x29020C0", VA = "0x1829038C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901760", Offset = "0x28FFF60", VA = "0x182901760")]
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
				[Cpp2IlInjected.Address(RVA = "0x29010E0", Offset = "0x28FF8E0", VA = "0x1829010E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900AF0", Offset = "0x28FF2F0", VA = "0x182900AF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902EC0", Offset = "0x29016C0", VA = "0x182902EC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2900970", Offset = "0x28FF170", VA = "0x182900970")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901370", Offset = "0x28FFB70", VA = "0x182901370")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901DD0", Offset = "0x29005D0", VA = "0x182901DD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2903CF0", Offset = "0x29024F0", VA = "0x182903CF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2902390", Offset = "0x2900B90", VA = "0x182902390")]
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
				[Cpp2IlInjected.Address(RVA = "0x2901970", Offset = "0x2900170", VA = "0x182901970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2900B40", Offset = "0x28FF340", VA = "0x182900B40")]
			public static ISRXXQTKLJD CXTQFZEYUXH([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2901440", Offset = "0x28FFC40", VA = "0x182901440")]
			public static ClassFactoryTypeParams GTZXBELFYIA(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2901410", Offset = "0x28FFC10", VA = "0x182901410")]
			public static ClassFactoryTypeParams GTZXBELFYIA([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x29039A0", Offset = "0x29021A0", VA = "0x1829039A0")]
			public static ISRXXQTKLJD WFOYPBSTWDZ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2902B70", Offset = "0x2901370", VA = "0x182902B70")]
			public static ISRXXQTKLJD RWBNBMCPVZQ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2903650", Offset = "0x2901E50", VA = "0x182903650")]
			public static ISRXXQTKLJD VIVYLCBMZAE([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x29035A0", Offset = "0x2901DA0", VA = "0x1829035A0")]
			public static YUGSHIKOLKK VFSRXTTTPPK(Id32<GBNADADGGBI> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2902140", Offset = "0x2900940", VA = "0x182902140")]
			public static string PEUJJPQZGVN(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x29032C0", Offset = "0x2901AC0", VA = "0x1829032C0")]
			private static YUGSHIKOLKK VFSRXTTTPPK(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2902A60", Offset = "0x2901260", VA = "0x182902A60")]
			public static Id32<GBNADADGGBI>? RNMAWRFAOVT(YUGSHIKOLKK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2902520", Offset = "0x2900D20", VA = "0x182902520")]
			public static CircuitTypeIdWrapper? QXBESKZHUYE(YUGSHIKOLKK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2904100", Offset = "0x2902900", VA = "0x182904100")]
			static WZVJKNGTMQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2900580", Offset = "0x28FED80", VA = "0x182900580")]
			[IteratorStateMachine(typeof(DXRKOVNYCOB))]
			private static IEnumerable<YUGSHIKOLKK> AUNCPSXCAQQ(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2901180", Offset = "0x28FF980", VA = "0x182901180")]
			[IteratorStateMachine(typeof(UFUCRUYGQHR))]
			public static IEnumerable<YUGSHIKOLKK> EOUAWJXVDJH(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2900630", Offset = "0x28FEE30", VA = "0x182900630")]
			public static Variant BHDBPYLRXCG(YUGSHIKOLKK a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2900D70", Offset = "0x28FF570", VA = "0x182900D70")]
			public static Variant DRQIHSMNTDJ(YUGSHIKOLKK a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2901800", Offset = "0x2900000", VA = "0x182901800")]
			public static bool JDXAFYWJENH(YUGSHIKOLKK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2902BF0", Offset = "0x29013F0", VA = "0x182902BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28EF800", Offset = "0x28EE000", VA = "0x1828EF800")]
		public static KOSHUHSDIVA JVPEYACKYLR(this YUGSHIKOLKK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28F08A0", Offset = "0x28EF0A0", VA = "0x1828F08A0")]
		public static YUGSHIKOLKK WDKEUGVWMDY(this KOSHUHSDIVA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FRZUHSDQXMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x36828B0", Offset = "0x36810B0", VA = "0x1836828B0")]
		public static Dictionary<b, c> KBBURYMSOAS<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class VVUBOWPYBZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28FF000", Offset = "0x28FD800", VA = "0x1828FF000")]
		public static WRNUVDVREEW JVPEYACKYLR([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28FF100", Offset = "0x28FD900", VA = "0x1828FF100")]
		public static Guid WDKEUGVWMDY(WRNUVDVREEW a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RZBTUJPUSHT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28FCD20", Offset = "0x28FB520", VA = "0x1828FCD20")]
		public static FJXZARPRGIE JVPEYACKYLR([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28FCDB0", Offset = "0x28FB5B0", VA = "0x1828FCDB0")]
		public static NamedType WDKEUGVWMDY(this FJXZARPRGIE a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class IMFMBNUMNCS
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x36F0400", Offset = "0x36EEC00", VA = "0x1836F0400")]
		public static void LGUGPDCUSLC<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x36F0660", Offset = "0x36EEE60", VA = "0x1836F0660")]
		public static void LGUGPDCUSLC<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class UVJJETBXBVL
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28FECB0", Offset = "0x28FD4B0", VA = "0x1828FECB0")]
		public static RWMGIRAZNGU JVPEYACKYLR([In] this Variant self, YUGSHIKOLKK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28FEEB0", Offset = "0x28FD6B0", VA = "0x1828FEEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28B2B60", Offset = "0x28B1360", VA = "0x1828B2B60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<NBICJQIZBLT> KJSVXBTPBNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x28B2B60", Offset = "0x28B1360", VA = "0x1828B2B60")]
			get
			{
				return default(Id128<NBICJQIZBLT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, YUGSHIKOLKK Type)> IJMHIHOMYUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LQDPTOOCVLR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x28FFEA0", Offset = "0x28FE6A0", VA = "0x1828FFEA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x28FF790", Offset = "0x28FDF90", VA = "0x1828FF790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, YUGSHIKOLKK> AHEAXBUTXMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x28FF1A0", Offset = "0x28FD9A0", VA = "0x1828FF1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x28FF8E0", Offset = "0x28FE0E0", VA = "0x1828FF8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CEZWMTGHKAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x28FF440", Offset = "0x28FDC40", VA = "0x1828FF440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28FF990", Offset = "0x28FE190", VA = "0x1828FF990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> ORFQSGOESRX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x28FFD90", Offset = "0x28FE590", VA = "0x1828FFD90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x28FFC40", Offset = "0x28FE440", VA = "0x1828FFC40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, YUGSHIKOLKK> UCNCTJJQFKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x28FFB90", Offset = "0x28FE390", VA = "0x1828FFB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x28FF830", Offset = "0x28FE030", VA = "0x1828FF830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action FORXYPNMQEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x28FFCF0", Offset = "0x28FE4F0", VA = "0x1828FFCF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x28FFF40", Offset = "0x28FE740", VA = "0x1828FFF40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18DF6E0", Offset = "0x18DDEE0", VA = "0x1818DF6E0")]
		public void FJOFYGGSWDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2900310", Offset = "0x28FEB10", VA = "0x182900310")]
		internal WBHAQSPHMBN([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, YUGSHIKOLKK Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28FFAC0", Offset = "0x28FE2C0", VA = "0x1828FFAC0")]
		public static CircuitEventDefinitionFactoryStart PBVLPMCLPSM(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x28FFA40", Offset = "0x28FE240", VA = "0x1828FFA40")]
		public static CircuitEventDefinitionFactoryStart PBVLPMCLPSM(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28FF680", Offset = "0x28FDE80", VA = "0x1828FF680")]
		public static WBHAQSPHMBN GSKKGATXPMM([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28FFFE0", Offset = "0x28FE7E0", VA = "0x1828FFFE0")]
		public static WBHAQSPHMBN YAZCMQSWONQ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xC27050", Offset = "0xC25850", VA = "0x180C27050")]
		public void DOWSCKGVXLU(Id128<NBICJQIZBLT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28FFE40", Offset = "0x28FE640", VA = "0x1828FFE40")]
		public void VDFRQTOHDIN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2900220", Offset = "0x28FEA20", VA = "0x182900220")]
		public void YMOVXLSSDXH(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28FF250", Offset = "0x28FDA50", VA = "0x1828FF250")]
		public void CQOCXERYGUS(int a, YUGSHIKOLKK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28FF4F0", Offset = "0x28FDCF0", VA = "0x1828FF4F0")]
		public void FZWQOISUBOG(string a, YUGSHIKOLKK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28FF610", Offset = "0x28FDE10", VA = "0x1828FF610")]
		public void GETABGTOUHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28FF340", Offset = "0x28FDB40", VA = "0x1828FF340")]
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
		[Cpp2IlInjected.Address(RVA = "0x28EC1A0", Offset = "0x28EA9A0", VA = "0x1828EC1A0")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28EBF00", Offset = "0x28EA700", VA = "0x1828EBF00")]
		public CircuitEventDefinitionFactoryParams DXHVPHZIFZC(string a, YUGSHIKOLKK b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28EC070", Offset = "0x28EA870", VA = "0x1828EC070")]
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
		[Cpp2IlInjected.Address(RVA = "0x28EBE70", Offset = "0x28EA670", VA = "0x1828EBE70")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, YUGSHIKOLKK Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28EBC40", Offset = "0x28EA440", VA = "0x1828EBC40")]
		public CircuitEventDefinitionFactoryParams DXHVPHZIFZC(string a, YUGSHIKOLKK b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28EBD70", Offset = "0x28EA570", VA = "0x1828EBD70")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<WBHAQSPHMBN> MRMRHFDXWEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x290FAD0", Offset = "0x290E2D0", VA = "0x18290FAD0")]
		protected HWPQTBQYEPT(YUGSHIKOLKK a, params WBHAQSPHMBN[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NGDNMQFMKOT : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2911710", Offset = "0x290FF10", VA = "0x182911710")]
		internal NGDNMQFMKOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QBMUQOPDOAA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2913170", Offset = "0x2911970", VA = "0x182913170")]
		internal QBMUQOPDOAA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class AVNZZGLIMVJ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x290BB60", Offset = "0x290A360", VA = "0x18290BB60")]
		internal AVNZZGLIMVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class VHBTYFUOUJK : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x29162E0", Offset = "0x2914AE0", VA = "0x1829162E0")]
		internal VHBTYFUOUJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class BHGMAWHJTGP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x290C120", Offset = "0x290A920", VA = "0x18290C120")]
		internal BHGMAWHJTGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class QPGVFCDGGHV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2913530", Offset = "0x2911D30", VA = "0x182913530")]
		internal QPGVFCDGGHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class WJBDQNRUUGS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2917760", Offset = "0x2915F60", VA = "0x182917760")]
		internal WJBDQNRUUGS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class FUNUTDZFFGX : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x290E580", Offset = "0x290CD80", VA = "0x18290E580")]
		internal FUNUTDZFFGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class VKBQINRAIVN : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2916A60", Offset = "0x2915260", VA = "0x182916A60")]
		internal VKBQINRAIVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class LDVRBMLGTFN : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2910D50", Offset = "0x290F550", VA = "0x182910D50")]
		internal LDVRBMLGTFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GQTHWKXGZEH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x290EEC0", Offset = "0x290D6C0", VA = "0x18290EEC0")]
		internal GQTHWKXGZEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class XAIMTNHBUWH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2917B80", Offset = "0x2916380", VA = "0x182917B80")]
		internal XAIMTNHBUWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class GQQLQBYWNGL : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x290ECE0", Offset = "0x290D4E0", VA = "0x18290ECE0")]
		internal GQQLQBYWNGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class KQWYCXKHAIJ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2910A90", Offset = "0x290F290", VA = "0x182910A90")]
		internal KQWYCXKHAIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ZVVCHKJSBOZ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x291BAF0", Offset = "0x291A2F0", VA = "0x18291BAF0")]
		internal ZVVCHKJSBOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class MJTPJEHFDLV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x29114D0", Offset = "0x290FCD0", VA = "0x1829114D0")]
		internal MJTPJEHFDLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class TKERHJXVYHH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2915550", Offset = "0x2913D50", VA = "0x182915550")]
		internal TKERHJXVYHH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class BPZIITLLLPS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x290C6C0", Offset = "0x290AEC0", VA = "0x18290C6C0")]
		internal BPZIITLLLPS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class LDXQOMJJTNQ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2910F30", Offset = "0x290F730", VA = "0x182910F30")]
		internal LDXQOMJJTNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class YNTYSNOGQLS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2919920", Offset = "0x2918120", VA = "0x182919920")]
		internal YNTYSNOGQLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class DXXYOQMFINM : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x290CF20", Offset = "0x290B720", VA = "0x18290CF20")]
		internal DXXYOQMFINM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class OOCFLOYDALI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x29120C0", Offset = "0x29108C0", VA = "0x1829120C0")]
		internal OOCFLOYDALI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class EICQMDTMIXH : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x290D7F0", Offset = "0x290BFF0", VA = "0x18290D7F0")]
		internal EICQMDTMIXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class SODMMGNOTWS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2914650", Offset = "0x2912E50", VA = "0x182914650")]
		internal SODMMGNOTWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JPCNJHKQVXP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2910490", Offset = "0x290EC90", VA = "0x182910490")]
		internal JPCNJHKQVXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class WKISAEEVYEE : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2917940", Offset = "0x2916140", VA = "0x182917940")]
		internal WKISAEEVYEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class LNQYEUBZSEK : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x29112F0", Offset = "0x290FAF0", VA = "0x1829112F0")]
		internal LNQYEUBZSEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZYRGCCRDCSM : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x291BCD0", Offset = "0x291A4D0", VA = "0x18291BCD0")]
		internal ZYRGCCRDCSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ZZPSSYGTRDL : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x291BEB0", Offset = "0x291A6B0", VA = "0x18291BEB0")]
		internal ZZPSSYGTRDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YAKRYJXVXPW : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2919740", Offset = "0x2917F40", VA = "0x182919740")]
		internal YAKRYJXVXPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class RWQZBBFESHZ : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2914410", Offset = "0x2912C10", VA = "0x182914410")]
		internal RWQZBBFESHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class PWJWQHFKAEV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2912F90", Offset = "0x2911790", VA = "0x182912F90")]
		internal PWJWQHFKAEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class KDCFIOISENX : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2910670", Offset = "0x290EE70", VA = "0x182910670")]
		internal KDCFIOISENX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XYTEGJJMJOY : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x29194E0", Offset = "0x2917CE0", VA = "0x1829194E0")]
		internal XYTEGJJMJOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class TKBCIDJEKAI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2915370", Offset = "0x2913B70", VA = "0x182915370")]
		internal TKBCIDJEKAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class IPEMQACIJNG : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x290FC40", Offset = "0x290E440", VA = "0x18290FC40")]
		internal IPEMQACIJNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class OVNDGTQUHON : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2912500", Offset = "0x2910D00", VA = "0x182912500")]
		internal OVNDGTQUHON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class YOMRRJOILKG : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2919D60", Offset = "0x2918560", VA = "0x182919D60")]
		internal YOMRRJOILKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class EWJUPXFQQPI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x290E2C0", Offset = "0x290CAC0", VA = "0x18290E2C0")]
		internal EWJUPXFQQPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class AKIZABNJYML : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x290AF50", Offset = "0x2909750", VA = "0x18290AF50")]
		internal AKIZABNJYML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class ZBFMUARBSFF : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x291A870", Offset = "0x2919070", VA = "0x18291A870")]
		internal ZBFMUARBSFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class KPHDDOAICTR : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x29108B0", Offset = "0x290F0B0", VA = "0x1829108B0")]
		internal KPHDDOAICTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class BNUAYZWQUNI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x290C4E0", Offset = "0x290ACE0", VA = "0x18290C4E0")]
		internal BNUAYZWQUNI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PCXKLZLOAVE : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x29126E0", Offset = "0x2910EE0", VA = "0x1829126E0")]
		internal PCXKLZLOAVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class REUSDDDKTVX : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2913AC0", Offset = "0x29122C0", VA = "0x182913AC0")]
		internal REUSDDDKTVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class YTSOCWXLQPK : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x291A630", Offset = "0x2918E30", VA = "0x18291A630")]
		internal YTSOCWXLQPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class HSZSEAZTWWP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x290F8F0", Offset = "0x290E0F0", VA = "0x18290F8F0")]
		internal HSZSEAZTWWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class HLQRURJMKHU : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x290F710", Offset = "0x290DF10", VA = "0x18290F710")]
		internal HLQRURJMKHU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class ATWCMYBOMVW : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x290B980", Offset = "0x290A180", VA = "0x18290B980")]
		internal ATWCMYBOMVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class UCULYQZOMSV : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x29158C0", Offset = "0x29140C0", VA = "0x1829158C0")]
		internal UCULYQZOMSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class ZTMRVOJVLMR : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x291B910", Offset = "0x291A110", VA = "0x18291B910")]
		internal ZTMRVOJVLMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BMYXBQDEBYA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x290C300", Offset = "0x290AB00", VA = "0x18290C300")]
		internal BMYXBQDEBYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class KXQWVJJDQXP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2910B70", Offset = "0x290F370", VA = "0x182910B70")]
		internal KXQWVJJDQXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class TCQBXANDXHS : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2914830", Offset = "0x2913030", VA = "0x182914830")]
		internal TCQBXANDXHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class RMBXQEURJJI : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2913CA0", Offset = "0x29124A0", VA = "0x182913CA0")]
		internal RMBXQEURJJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class OUYTPCMYGDY : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2912320", Offset = "0x2910B20", VA = "0x182912320")]
		internal OUYTPCMYGDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class NVEPTZXJXPA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2911C60", Offset = "0x2910460", VA = "0x182911C60")]
		internal NVEPTZXJXPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class VRVVINOMTMB : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2917520", Offset = "0x2915D20", VA = "0x182917520")]
		internal VRVVINOMTMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ZPGAVEDGRYA : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x291B730", Offset = "0x2919F30", VA = "0x18291B730")]
		internal ZPGAVEDGRYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class LIQHVZNONEC : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2911110", Offset = "0x290F910", VA = "0x182911110")]
		internal LIQHVZNONEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class VIRWPEBQOLP : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x29164C0", Offset = "0x2914CC0", VA = "0x1829164C0")]
		internal VIRWPEBQOLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class GOEBQISKAKO : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x290EB80", Offset = "0x290D380", VA = "0x18290EB80")]
		internal GOEBQISKAKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class VFIMKSNNHYL : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2916180", Offset = "0x2914980", VA = "0x182916180")]
		internal VFIMKSNNHYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class GIRTTZRSAZG : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x290EA20", Offset = "0x290D220", VA = "0x18290EA20")]
		internal GIRTTZRSAZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class YOLYHGNGFCW : HWPQTBQYEPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2919B00", Offset = "0x2918300", VA = "0x182919B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
		private NamedType(string name, YUGSHIKOLKK type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x284A1D0", Offset = "0x28489D0", VA = "0x18284A1D0")]
		public static NamedType New(string name, YUGSHIKOLKK type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2911F00", Offset = "0x2910700", VA = "0x182911F00")]
		public static bool FYOQTCVQVIR([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2911F00", Offset = "0x2910700", VA = "0x182911F00", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2911F00", Offset = "0x2910700", VA = "0x182911F00")]
		public bool QGNBNUHOAWV([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2911E40", Offset = "0x2910640", VA = "0x182911E40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2911F50", Offset = "0x2910750", VA = "0x182911F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2912040", Offset = "0x2910840", VA = "0x182912040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2912080", Offset = "0x2910880", VA = "0x182912080")]
		public string VLUEQOEKHUZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2911FC0", Offset = "0x29107C0", VA = "0x182911FC0")]
		public string LSQEAKIEMZL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2911F00", Offset = "0x2910700", VA = "0x182911F00", Slot = "5")]
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
