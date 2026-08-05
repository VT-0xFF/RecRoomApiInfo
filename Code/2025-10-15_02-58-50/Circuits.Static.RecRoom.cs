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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B54110", Offset = "0x2B52F10", VA = "0x182B54110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B54020", Offset = "0x2B52E20", VA = "0x182B54020", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KTVIHIVMNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B50AE0", Offset = "0x2B4F8E0", VA = "0x182B50AE0")]
		public static bool HMMUGRFFRAM(this VJBGGKQUSTY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B50BF0", Offset = "0x2B4F9F0", VA = "0x182B50BF0")]
		public static bool HMMUGRFFRAM(this SCTFVGOUTWF a)
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
			private readonly SVBMWMSSDIU _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
			public EVRequest(SVBMWMSSDIU staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class JPVANAIDVGT
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<WXCSFVUICQE>, OXJCKBMJGPP> KYZEKKNHQGY;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<WXCSFVUICQE>>? DQKPTFKCXME;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<WXCSFVUICQE> SWSRHOUFLKO;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<WXCSFVUICQE> LMOEEJBKRHB;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<WXCSFVUICQE> UGGAMDJILRE;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<WXCSFVUICQE> WFWDQOSEUBR;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<WXCSFVUICQE> YIWKQOFHXVO;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<WXCSFVUICQE> USSAMXPGOFN;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<WXCSFVUICQE> WMAKUHFIIYH;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<WXCSFVUICQE> MDFHUAVNLTZ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<WXCSFVUICQE> SLFFKHRWELF;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<WXCSFVUICQE> OBSYVOXILAH;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<WXCSFVUICQE> WCGIKYASSBV;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<WXCSFVUICQE> XJMEZMHVBWV;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<WXCSFVUICQE> GJNBZCRTUWA;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<WXCSFVUICQE> FJBQBUELTRG;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<WXCSFVUICQE> OJXVHMKGAHA;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<WXCSFVUICQE> GLMUIKSYIWN;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<WXCSFVUICQE> UUKAMCXTFBS;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<WXCSFVUICQE> ENGGAHQCLTM;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<WXCSFVUICQE> OOZUIQURFIZ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<WXCSFVUICQE> AQOBYKDCAEO;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<WXCSFVUICQE> XMEZSSHJYFD;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<WXCSFVUICQE> ZYIFXBSOJIS;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<WXCSFVUICQE> DKEYAGCMMQO;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<WXCSFVUICQE> KCPDHFXBVHX;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<WXCSFVUICQE> DSTBEAASNSV;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<WXCSFVUICQE> OBKGKBZGVRO;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<WXCSFVUICQE> WZXLVSRYMRJ;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<WXCSFVUICQE> BCWPBBDUZPW;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<WXCSFVUICQE> ZZIIMPFGCHO;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<WXCSFVUICQE> QWNQAEFEJCO;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<WXCSFVUICQE> GUYPUNVPTWI;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<WXCSFVUICQE> JJBCWWYKJEN;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<WXCSFVUICQE> KPRPGNVZHWC;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<WXCSFVUICQE> SDIWNHCQMKG;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<WXCSFVUICQE> DMJGMJPHFPC;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<WXCSFVUICQE> TJQCFJFNEEF;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<WXCSFVUICQE> RIWXSMIGVAW;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<WXCSFVUICQE> QSPMYHKGRNV;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<WXCSFVUICQE> YSEVMXSXOQD;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<WXCSFVUICQE> YMEDLNBFDQN;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<WXCSFVUICQE> BESGMBXWWKS;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<WXCSFVUICQE> KBSGEHSIZCC;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<WXCSFVUICQE> TXWEJRCSDHF;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<WXCSFVUICQE> GLZUFEFFQES;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<WXCSFVUICQE> WHDAIOEGNMI;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<WXCSFVUICQE> ONGOEBRGJHA;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<WXCSFVUICQE> WLUYTSYWVGP;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<WXCSFVUICQE> LDHODQNVPBF;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<WXCSFVUICQE> MEEBIZIZAWH;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<WXCSFVUICQE> HEKLOBQSLXY;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<WXCSFVUICQE> SIVIIPPFJFE;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<WXCSFVUICQE> XTJJNQUPGCL;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<WXCSFVUICQE> JERCLTHCFPS;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<WXCSFVUICQE> HLZRZNZEIGO;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<WXCSFVUICQE> RJMUXIWVGIR;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<WXCSFVUICQE> NDMHLXFGBQJ;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<WXCSFVUICQE> DSVHCHWSUZD;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<WXCSFVUICQE> XAVFGILWVMZ;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<WXCSFVUICQE> NVGZCNBZDWY;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<WXCSFVUICQE> WJBHNLRHXHF;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<WXCSFVUICQE> LREQFMDSYLP;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<WXCSFVUICQE> BVKKOXMMTAD;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<WXCSFVUICQE> KUHLNWPUWYI;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<WXCSFVUICQE> DJTBEEOBPUC;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<WXCSFVUICQE> CBUDKBXIKGR;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<WXCSFVUICQE> NQTQQCEWQSW;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<WXCSFVUICQE>, OXJCKBMJGPP> IYHVRGZWURZ
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4DAA0", Offset = "0x2B4C8A0", VA = "0x182B4DAA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D850", Offset = "0x2B4C650", VA = "0x182B4D850")]
			public static OXJCKBMJGPP CWIRHQZAKSB(Id32<WXCSFVUICQE> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DA10", Offset = "0x2B4C810", VA = "0x182B4DA10")]
			public static bool PLSKLLDSSZI(Id32<WXCSFVUICQE> id, [Out] OXJCKBMJGPP a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D8D0", Offset = "0x2B4C6D0", VA = "0x182B4D8D0")]
			public static VJBGGKQUSTY HQZCJBWXKYI(Id32<WXCSFVUICQE> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4D980", Offset = "0x2B4C780", VA = "0x182B4D980")]
			private static Id32<WXCSFVUICQE> IPFDCTVTWHM(OXJCKBMJGPP a, Id32<WXCSFVUICQE> id)
			{
				return default(Id32<WXCSFVUICQE>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4DAF0", Offset = "0x2B4C8F0", VA = "0x182B4DAF0")]
			private static void ZLUFAPOJWQY(Id32<WXCSFVUICQE> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class OTZUYIMUOZO
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				private IdUnsafeList<IMTHRFIEELI, VJBGGKQUSTY?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x1313220", Offset = "0x1312020", VA = "0x181313220")]
				private TypeRegistryFactory([In] IdUnsafeList<IMTHRFIEELI, VJBGGKQUSTY?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B676C0", Offset = "0x2B664C0", VA = "0x182B676C0")]
				public static TypeRegistryFactory VHMWPQEADTW()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B67350", Offset = "0x2B66150", VA = "0x182B67350")]
				public (ReadOnlyIdArray<IMTHRFIEELI, VJBGGKQUSTY>, IReadOnlyDictionary<VJBGGKQUSTY, Id32<IMTHRFIEELI>>) PKVJCOOHHUA()
				{
					return default((ReadOnlyIdArray<IMTHRFIEELI, VJBGGKQUSTY>, IReadOnlyDictionary<VJBGGKQUSTY, Id32<IMTHRFIEELI>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B67720", Offset = "0x2B66520", VA = "0x182B67720")]
				public Id32<IMTHRFIEELI> YQMLWMUDARY(int a, VJBGGKQUSTY b)
				{
					return default(Id32<IMTHRFIEELI>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B67300", Offset = "0x2B66100", VA = "0x182B67300")]
				public Id32<IMTHRFIEELI> Initialize(int id, NITOSEZCQPT type, NITOSEZCQPT factoryType)
				{
					return default(Id32<IMTHRFIEELI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class KZEXAFXLIRB
			{
				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Id32<IMTHRFIEELI> ZLZHJYHPAFS
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x2B50E30", Offset = "0x2B4FC30", VA = "0x182B50E30")]
					[CompilerGenerated]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x2B50EF0", Offset = "0x2B4FCF0", VA = "0x182B50EF0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Id32<IMTHRFIEELI> YQWQLYTYNYC
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x2B50CF0", Offset = "0x2B4FAF0", VA = "0x182B50CF0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x2B50CB0", Offset = "0x2B4FAB0", VA = "0x182B50CB0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Id32<IMTHRFIEELI> RXKYHXHFPPD
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2B50F70", Offset = "0x2B4FD70", VA = "0x182B50F70")]
					[CompilerGenerated]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2B50DF0", Offset = "0x2B4FBF0", VA = "0x182B50DF0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Id32<IMTHRFIEELI> QSUJNYYAHUB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2B50D30", Offset = "0x2B4FB30", VA = "0x182B50D30")]
					[CompilerGenerated]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2B50EB0", Offset = "0x2B4FCB0", VA = "0x182B50EB0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<IMTHRFIEELI> UANDWHXXWUF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2B50D70", Offset = "0x2B4FB70", VA = "0x182B50D70")]
					[CompilerGenerated]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2B50E70", Offset = "0x2B4FC70", VA = "0x182B50E70")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<IMTHRFIEELI> DOOWEFPUVNW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2B50DB0", Offset = "0x2B4FBB0", VA = "0x182B50DB0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2B50F30", Offset = "0x2B4FD30", VA = "0x182B50F30")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class SREHLISXREJ : IEnumerable<VJBGGKQUSTY>, IEnumerable, IEnumerator<VJBGGKQUSTY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				private int DPSIYUGFINN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private VJBGGKQUSTY KPVEVSUGXYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				private int SNADUNBHBXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				private bool TKOMBGMUIFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public bool XVTNOUMTNXD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private RoomVersion OPUVRFDXSYU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public RoomVersion FWXJSBHOAKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private bool IEKBWBYOARV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public bool ZPWQNZYZELI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private bool YTXMXQRNTCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public bool HTXDNNHJQRQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private bool TFQBTBDGGNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public bool BNWUPJSQJQO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private bool GCIRZYWOBRP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public bool ZAHCVNZODRC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				private IEnumerator<VJBGGKQUSTY> RSQQLXOAUXF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private VJBGGKQUSTY WSNAZKHQTPO;

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				private VJBGGKQUSTY XGYVWDHZBVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				private object SQVTSFKREWF
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
				[DebuggerHidden]
				public SREHLISXREJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B66AA0", Offset = "0x2B658A0", VA = "0x182B66AA0", Slot = "7")]
				[DebuggerHidden]
				private void DUPJTQKNSZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B66B70", Offset = "0x2B65970", VA = "0x182B66B70", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B66F60", Offset = "0x2B65D60", VA = "0x182B66F60")]
				private void XVTZRJOPNYU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B66B30", Offset = "0x2B65930", VA = "0x182B66B30", Slot = "10")]
				[DebuggerHidden]
				private void KJSXTMSAUIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B669E0", Offset = "0x2B657E0", VA = "0x182B669E0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VJBGGKQUSTY> CMOEGEJYXSK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B669E0", Offset = "0x2B657E0", VA = "0x182B669E0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WAAULASRGHE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class ZDNVEQXPOLB : IEnumerable<VJBGGKQUSTY>, IEnumerable, IEnumerator<VJBGGKQUSTY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				private int DPSIYUGFINN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private VJBGGKQUSTY KPVEVSUGXYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				private int SNADUNBHBXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private RoomVersion OPUVRFDXSYU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public RoomVersion FWXJSBHOAKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private bool YTXMXQRNTCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public bool HTXDNNHJQRQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private bool IEKBWBYOARV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public bool ZPWQNZYZELI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private bool ZATLGPIEAJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				public bool IIFULPSAAJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				private bool TFQBTBDGGNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public bool BNWUPJSQJQO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				private bool DRDRLHCGNPR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool PPMWACLLPVZ;

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				private VJBGGKQUSTY XGYVWDHZBVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				private object SQVTSFKREWF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
				[DebuggerHidden]
				public ZDNVEQXPOLB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
				[DebuggerHidden]
				private void DUPJTQKNSZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B694E0", Offset = "0x2B682E0", VA = "0x182B694E0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B694A0", Offset = "0x2B682A0", VA = "0x182B694A0", Slot = "10")]
				[DebuggerHidden]
				private void KJSXTMSAUIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B693F0", Offset = "0x2B681F0", VA = "0x182B693F0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VJBGGKQUSTY> CMOEGEJYXSK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B693F0", Offset = "0x2B681F0", VA = "0x182B693F0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WAAULASRGHE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class ZGSWIVINVFD : IEnumerable<Id32<IMTHRFIEELI>>, IEnumerable, IEnumerator<Id32<IMTHRFIEELI>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private int DPSIYUGFINN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private Id32<IMTHRFIEELI> KPVEVSUGXYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				private int SNADUNBHBXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private RoomVersion OPUVRFDXSYU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public RoomVersion FWXJSBHOAKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool IEKBWBYOARV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public bool ZPWQNZYZELI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private bool YTXMXQRNTCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public bool HTXDNNHJQRQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private bool TFQBTBDGGNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public bool BNWUPJSQJQO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private bool GCIRZYWOBRP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public bool ZAHCVNZODRC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private IEnumerator<VJBGGKQUSTY> RSQQLXOAUXF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private IEnumerator<NITOSEZCQPT> RSVXJEHYEIO;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private Id32<IMTHRFIEELI> AGSUIIJJZDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xC1BCE0", Offset = "0xC1AAE0", VA = "0x180C1BCE0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<IMTHRFIEELI>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object SQVTSFKREWF
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x2B6BA20", Offset = "0x2B6A820", VA = "0x182B6BA20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x15ECBD0", Offset = "0x15EB9D0", VA = "0x1815ECBD0")]
				[DebuggerHidden]
				public ZGSWIVINVFD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B6B2E0", Offset = "0x2B6A0E0", VA = "0x182B6B2E0", Slot = "7")]
				[DebuggerHidden]
				private void DUPJTQKNSZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B6B520", Offset = "0x2B6A320", VA = "0x182B6B520", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B6BA70", Offset = "0x2B6A870", VA = "0x182B6BA70")]
				private void XVTZRJOPNYU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B6BAC0", Offset = "0x2B6A8C0", VA = "0x182B6BAC0")]
				private void XWJUJDWHQGV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B6B4E0", Offset = "0x2B6A2E0", VA = "0x182B6B4E0", Slot = "10")]
				[DebuggerHidden]
				private void KJSXTMSAUIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B6B430", Offset = "0x2B6A230", VA = "0x182B6B430", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<IMTHRFIEELI>> GLBWMACXFBT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B6B430", Offset = "0x2B6A230", VA = "0x182B6B430", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WAAULASRGHE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private static readonly Log YLLVKVFSHML;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private static ReadOnlyIdArray<IMTHRFIEELI, VJBGGKQUSTY?> XOEDYWKGHWT;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private static IReadOnlyDictionary<VJBGGKQUSTY, Id32<IMTHRFIEELI>> MEVOFZLPLPF;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly SCTFVGOUTWF VWHKPJQFLAS;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly SCTFVGOUTWF DQTTXCXGPOM;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private static readonly HashSet<VJBGGKQUSTY> QQEKHFJMHHM;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static List<VJBGGKQUSTY> XNUQBZRWEPP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet LMEGUUPJPVK
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet MCUCZXVIXBG
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet IYLXXTTOWPS
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD864B0", Offset = "0xD852B0", VA = "0x180D864B0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static VJBGGKQUSTY ZLZHJYHPAFS
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2B560D0", Offset = "0x2B54ED0", VA = "0x182B560D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static VJBGGKQUSTY YQWQLYTYNYC
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2B551B0", Offset = "0x2B53FB0", VA = "0x182B551B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static VJBGGKQUSTY RXKYHXHFPPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2B57AE0", Offset = "0x2B568E0", VA = "0x182B57AE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static VJBGGKQUSTY QSUJNYYAHUB
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2B55420", Offset = "0x2B54220", VA = "0x182B55420")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static VJBGGKQUSTY WTHJIKLJHXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2B58290", Offset = "0x2B57090", VA = "0x182B58290")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static VJBGGKQUSTY UFPMKCPJBDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2B55AA0", Offset = "0x2B548A0", VA = "0x182B55AA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static VJBGGKQUSTY WHLSRYCELAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2B568E0", Offset = "0x2B556E0", VA = "0x182B568E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static VJBGGKQUSTY UANDWHXXWUF
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2B554B0", Offset = "0x2B542B0", VA = "0x182B554B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static NITOSEZCQPT FVPMZMSQKOX
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2B55720", Offset = "0x2B54520", VA = "0x182B55720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static NITOSEZCQPT ZJGTEVNILEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2B56C30", Offset = "0x2B55A30", VA = "0x182B56C30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static NITOSEZCQPT KOVYJZAYVHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2B54A20", Offset = "0x2B53820", VA = "0x182B54A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static NITOSEZCQPT BCQPMJIRHUH
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2B55830", Offset = "0x2B54630", VA = "0x182B55830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static NITOSEZCQPT YPZYWLZFSOL
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2B55F20", Offset = "0x2B54D20", VA = "0x182B55F20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static NITOSEZCQPT PQMOMKTKIWQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2B559F0", Offset = "0x2B547F0", VA = "0x182B559F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static NITOSEZCQPT RDDFFJWPIVM
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2B58380", Offset = "0x2B57180", VA = "0x182B58380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static NITOSEZCQPT SZJYYFHRFYY
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2B56710", Offset = "0x2B55510", VA = "0x182B56710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static NITOSEZCQPT IJRGPVUNWCH
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2B54710", Offset = "0x2B53510", VA = "0x182B54710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static NITOSEZCQPT ATVDSCGQWOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2B54C80", Offset = "0x2B53A80", VA = "0x182B54C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static NITOSEZCQPT ARXCRHZCXAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2B55F70", Offset = "0x2B54D70", VA = "0x182B55F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static NITOSEZCQPT CMHWTCFNVKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2B558E0", Offset = "0x2B546E0", VA = "0x182B558E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static NITOSEZCQPT VYPRATPCURE
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2B54DF0", Offset = "0x2B53BF0", VA = "0x182B54DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static NITOSEZCQPT DJCWSEELKFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2B57B70", Offset = "0x2B56970", VA = "0x182B57B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static NITOSEZCQPT ILIMZXXFOLH
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2B54650", Offset = "0x2B53450", VA = "0x182B54650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static NITOSEZCQPT AWKSHXFXNYW
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2B58230", Offset = "0x2B57030", VA = "0x182B58230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static NITOSEZCQPT KFXMXZPOJYW
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2B57F30", Offset = "0x2B56D30", VA = "0x182B57F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static NITOSEZCQPT SOVJMXFFDGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2B54D90", Offset = "0x2B53B90", VA = "0x182B54D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static NITOSEZCQPT IKGUTRKXETI
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2B55540", Offset = "0x2B54340", VA = "0x182B55540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static NITOSEZCQPT NZBUVOBVQEH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2B581D0", Offset = "0x2B56FD0", VA = "0x182B581D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static NITOSEZCQPT ZIMWQCALEKK
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2B57990", Offset = "0x2B56790", VA = "0x182B57990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static NITOSEZCQPT XJAHAJGQTZW
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2B55300", Offset = "0x2B54100", VA = "0x182B55300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static NITOSEZCQPT IDTXNHPLJKI
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2B55660", Offset = "0x2B54460", VA = "0x182B55660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static NITOSEZCQPT KCICQDFUVHG
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B56880", Offset = "0x2B55680", VA = "0x182B56880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static NITOSEZCQPT KXWVEXXZRRV
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B57500", Offset = "0x2B56300", VA = "0x182B57500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static NITOSEZCQPT AJXUUTZYFXQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2B566B0", Offset = "0x2B554B0", VA = "0x182B566B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static NITOSEZCQPT YUJCAFJXQJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2B552A0", Offset = "0x2B540A0", VA = "0x182B552A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static NITOSEZCQPT WPMFZDVPYZS
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2B546B0", Offset = "0x2B534B0", VA = "0x182B546B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static NITOSEZCQPT BVZMMHOKBMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2B57ED0", Offset = "0x2B56CD0", VA = "0x182B57ED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static NITOSEZCQPT XGMUGEAPWRT
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2B550F0", Offset = "0x2B53EF0", VA = "0x182B550F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static NITOSEZCQPT ENURXUHJHJW
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2B54D30", Offset = "0x2B53B30", VA = "0x182B54D30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static NITOSEZCQPT EYGYQMNQXBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2B56F10", Offset = "0x2B55D10", VA = "0x182B56F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static NITOSEZCQPT GAFXZCJQIQE
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2B54B60", Offset = "0x2B53960", VA = "0x182B54B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static NITOSEZCQPT XGQBUERALVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2B57BD0", Offset = "0x2B569D0", VA = "0x182B57BD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static NITOSEZCQPT VATIKSAPUKV
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2B567C0", Offset = "0x2B555C0", VA = "0x182B567C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static NITOSEZCQPT GPKTYBFTIKD
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2B565F0", Offset = "0x2B553F0", VA = "0x182B565F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static NITOSEZCQPT AFOQORCGPDI
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2B56970", Offset = "0x2B55770", VA = "0x182B56970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static NITOSEZCQPT XHEBSNZBXKE
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2B573E0", Offset = "0x2B561E0", VA = "0x182B573E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static NITOSEZCQPT TKEKMGHCLNX
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2B55150", Offset = "0x2B53F50", VA = "0x182B55150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static NITOSEZCQPT SVLSXNSSNLT
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2B56EB0", Offset = "0x2B55CB0", VA = "0x182B56EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static NITOSEZCQPT VHHDTEREXON
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2B556C0", Offset = "0x2B544C0", VA = "0x182B556C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static NITOSEZCQPT UCSULUNXDAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2B56820", Offset = "0x2B55620", VA = "0x182B56820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static NITOSEZCQPT BIZDSLMUZSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2B55600", Offset = "0x2B54400", VA = "0x182B55600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static NITOSEZCQPT FUYURZHTUAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2B57C30", Offset = "0x2B56A30", VA = "0x182B57C30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static NITOSEZCQPT HJEZYGWDKJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2B57800", Offset = "0x2B56600", VA = "0x182B57800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static NITOSEZCQPT XRBLBWZEGWZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2B56470", Offset = "0x2B55270", VA = "0x182B56470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static NITOSEZCQPT IDEICTVIQQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2B583D0", Offset = "0x2B571D0", VA = "0x182B583D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static NITOSEZCQPT EGGAYTFLLUO
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2B57DB0", Offset = "0x2B56BB0", VA = "0x182B57DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static NITOSEZCQPT HLUMZSZMKNP
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2B54F70", Offset = "0x2B53D70", VA = "0x182B54F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static NITOSEZCQPT FEMFEDWNYKL
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2B557D0", Offset = "0x2B545D0", VA = "0x182B557D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static NITOSEZCQPT PRGWVTVFVMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2B54960", Offset = "0x2B53760", VA = "0x182B54960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static NITOSEZCQPT VSQITVXTAZE
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2B55A40", Offset = "0x2B54840", VA = "0x182B55A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static NITOSEZCQPT SKXUCSEGQSN
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2B56070", Offset = "0x2B54E70", VA = "0x182B56070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static NITOSEZCQPT ICETDDUZUAE
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2B56590", Offset = "0x2B55390", VA = "0x182B56590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static NITOSEZCQPT CWFWZIIPDDS
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2B57440", Offset = "0x2B56240", VA = "0x182B57440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static NITOSEZCQPT HTHDKPDPXLY
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2B580B0", Offset = "0x2B56EB0", VA = "0x182B580B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static NITOSEZCQPT XJHKIMQVMIC
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2B57680", Offset = "0x2B56480", VA = "0x182B57680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static NITOSEZCQPT YQZBHDUPRUJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2B57740", Offset = "0x2B56540", VA = "0x182B57740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static NITOSEZCQPT VGEWKPADFKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2B54760", Offset = "0x2B53560", VA = "0x182B54760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static NITOSEZCQPT ZWBCTJGRPUH
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2B54FD0", Offset = "0x2B53DD0", VA = "0x182B54FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static NITOSEZCQPT GVJANJFUGUX
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2B54C20", Offset = "0x2B53A20", VA = "0x182B54C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static NITOSEZCQPT CPGJQIWQJIQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2B56AB0", Offset = "0x2B558B0", VA = "0x182B56AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static NITOSEZCQPT SRATLMCWLWR
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2B55B30", Offset = "0x2B54930", VA = "0x182B55B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static NITOSEZCQPT JVWEBFAWOEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2B58110", Offset = "0x2B56F10", VA = "0x182B58110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static NITOSEZCQPT NMITCUOAAYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2B56760", Offset = "0x2B55560", VA = "0x182B56760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static NITOSEZCQPT OYLBAOIFBGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2B56A50", Offset = "0x2B55850", VA = "0x182B56A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static NITOSEZCQPT INECDSGUYBY
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2B56410", Offset = "0x2B55210", VA = "0x182B56410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static NITOSEZCQPT KXJJZHQRFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2B57E70", Offset = "0x2B56C70", VA = "0x182B57E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static NITOSEZCQPT GDHHXDGSDXB
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2B549C0", Offset = "0x2B537C0", VA = "0x182B549C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static NITOSEZCQPT LWLESRJXCSH
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2B57D50", Offset = "0x2B56B50", VA = "0x182B57D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static NITOSEZCQPT FMDVDWXFZAE
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2B56DF0", Offset = "0x2B55BF0", VA = "0x182B56DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static NITOSEZCQPT GULUVHJNTET
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2B579F0", Offset = "0x2B567F0", VA = "0x182B579F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static NITOSEZCQPT DQLIHVCTUPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2B57FF0", Offset = "0x2B56DF0", VA = "0x182B57FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static NITOSEZCQPT ZPIAURAICBY
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2B56D90", Offset = "0x2B55B90", VA = "0x182B56D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static NITOSEZCQPT XAEHYIVSLWC
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2B547C0", Offset = "0x2B535C0", VA = "0x182B547C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static NITOSEZCQPT AAJUGANLSWN
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2B56650", Offset = "0x2B55450", VA = "0x182B56650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static NITOSEZCQPT BIDOIZAKSRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2B55090", Offset = "0x2B53E90", VA = "0x182B55090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static NITOSEZCQPT DCPGBZMEOIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2B57C90", Offset = "0x2B56A90", VA = "0x182B57C90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static NITOSEZCQPT PKCIUONQAYT
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2B55030", Offset = "0x2B53E30", VA = "0x182B55030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static NITOSEZCQPT OIYAGJBGGOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2B575C0", Offset = "0x2B563C0", VA = "0x182B575C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static NITOSEZCQPT DAZXBCYQLLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2B576E0", Offset = "0x2B564E0", VA = "0x182B576E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static NITOSEZCQPT BVWIDHTJTEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2B54BC0", Offset = "0x2B539C0", VA = "0x182B54BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static NITOSEZCQPT GQQDPYQDWAO
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2B564D0", Offset = "0x2B552D0", VA = "0x182B564D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static NITOSEZCQPT ACPUBFOJGBM
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2B553C0", Offset = "0x2B541C0", VA = "0x182B553C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static NITOSEZCQPT YMPNDBQHRZG
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2B56BD0", Offset = "0x2B559D0", VA = "0x182B56BD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static NITOSEZCQPT KTPJZMPFEQA
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2B54900", Offset = "0x2B53700", VA = "0x182B54900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static NITOSEZCQPT MHTQFFCFBZA
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2B58170", Offset = "0x2B56F70", VA = "0x182B58170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static NITOSEZCQPT OTEFHESHFNT
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2B56E50", Offset = "0x2B55C50", VA = "0x182B56E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static NITOSEZCQPT IKCSJHORSMC
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2B55770", Offset = "0x2B54570", VA = "0x182B55770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static NITOSEZCQPT JDYYHVRBVZZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2B574A0", Offset = "0x2B562A0", VA = "0x182B574A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static NITOSEZCQPT YOIKAPSPPSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2B54A70", Offset = "0x2B53870", VA = "0x182B54A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static NITOSEZCQPT HGPKJXJMTFR
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2B57930", Offset = "0x2B56730", VA = "0x182B57930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static NITOSEZCQPT DBAKNWTYTEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2B55990", Offset = "0x2B54790", VA = "0x182B55990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static NITOSEZCQPT JPGHUIUATGV
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2B56D30", Offset = "0x2B55B30", VA = "0x182B56D30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static NITOSEZCQPT NNXOAFUBTSX
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2B57560", Offset = "0x2B56360", VA = "0x182B57560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static NITOSEZCQPT GNCSFBYVGXM
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2B55360", Offset = "0x2B54160", VA = "0x182B55360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static NITOSEZCQPT EBXWITJSSLV
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2B58320", Offset = "0x2B57120", VA = "0x182B58320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static NITOSEZCQPT IXDJBXJMKKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2B577A0", Offset = "0x2B565A0", VA = "0x182B577A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static NITOSEZCQPT XNQDPQZWXAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2B555A0", Offset = "0x2B543A0", VA = "0x182B555A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static NITOSEZCQPT GEDRRGDHVGS
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2B55240", Offset = "0x2B54040", VA = "0x182B55240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static NITOSEZCQPT PZSORFJQQSH
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2B54AD0", Offset = "0x2B538D0", VA = "0x182B54AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static NITOSEZCQPT IFVOBHIBNWG
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2B55880", Offset = "0x2B54680", VA = "0x182B55880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static NITOSEZCQPT LVPWLZGRBHI
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2B57CF0", Offset = "0x2B56AF0", VA = "0x182B57CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static NITOSEZCQPT NCUBMZXOKTB
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2B54CD0", Offset = "0x2B53AD0", VA = "0x182B54CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static NITOSEZCQPT EXGGPXORXQC
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2B56530", Offset = "0x2B55330", VA = "0x182B56530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static NITOSEZCQPT DUAHAHNTDRT
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2B57F90", Offset = "0x2B56D90", VA = "0x182B57F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static NITOSEZCQPT LJZHMTDQKJG
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2B55930", Offset = "0x2B54730", VA = "0x182B55930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static NITOSEZCQPT YWHLXAGBWZQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2B56B70", Offset = "0x2B55970", VA = "0x182B56B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static NITOSEZCQPT CNOWFHNWMQF
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2B57A50", Offset = "0x2B56850", VA = "0x182B57A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static NITOSEZCQPT BWADTAJHMLZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2B58430", Offset = "0x2B57230", VA = "0x182B58430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static NITOSEZCQPT LHNKPXBISAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2B56B10", Offset = "0x2B55910", VA = "0x182B56B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static NITOSEZCQPT OQSKYISVMGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2B58050", Offset = "0x2B56E50", VA = "0x182B58050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static NITOSEZCQPT VXSZMLJQBXD
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2B57E10", Offset = "0x2B56C10", VA = "0x182B57E10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static NITOSEZCQPT TXVOBINETGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2B57620", Offset = "0x2B56420", VA = "0x182B57620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static NITOSEZCQPT CQCRTNUUCEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2B578D0", Offset = "0x2B566D0", VA = "0x182B578D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B56F70", Offset = "0x2B55D70", VA = "0x182B56F70")]
			public static SCTFVGOUTWF PLHJLRGHOHT([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2B54820", Offset = "0x2B53620", VA = "0x182B54820")]
			public static ClassFactoryTypeParams BRHFCCHKJLK(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B548D0", Offset = "0x2B536D0", VA = "0x182B548D0")]
			public static ClassFactoryTypeParams BRHFCCHKJLK([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B57AB0", Offset = "0x2B568B0", VA = "0x182B57AB0")]
			public static SCTFVGOUTWF TANVMIDNSLV(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B54B30", Offset = "0x2B53930", VA = "0x182B54B30")]
			public static SCTFVGOUTWF CGPUQGGCUUK(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B54E40", Offset = "0x2B53C40", VA = "0x182B54E40")]
			public static SCTFVGOUTWF DOOWEFPUVNW([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B55E70", Offset = "0x2B54C70", VA = "0x182B55E70")]
			public static VJBGGKQUSTY HQZCJBWXKYI(Id32<IMTHRFIEELI> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2B545D0", Offset = "0x2B533D0", VA = "0x182B545D0")]
			public static string AAERPNYSKVB(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B55B90", Offset = "0x2B54990", VA = "0x182B55B90")]
			private static VJBGGKQUSTY HQZCJBWXKYI(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2B57860", Offset = "0x2B56660", VA = "0x182B57860")]
			public static Id32<IMTHRFIEELI>? RKKJYLBVMAJ(VJBGGKQUSTY a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B57060", Offset = "0x2B55E60", VA = "0x182B57060")]
			public static CircuitTypeIdWrapper? PQWSEUSOCTS(VJBGGKQUSTY a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B58820", Offset = "0x2B57620", VA = "0x182B58820")]
			static OTZUYIMUOZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B55FC0", Offset = "0x2B54DC0", VA = "0x182B55FC0")]
			[IteratorStateMachine(typeof(ZDNVEQXPOLB))]
			private static IEnumerable<VJBGGKQUSTY> IFDOWADSEKQ(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B58770", Offset = "0x2B57570", VA = "0x182B58770")]
			[IteratorStateMachine(typeof(SREHLISXREJ))]
			public static IEnumerable<VJBGGKQUSTY> ZVGMNOMTQIZ(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B56160", Offset = "0x2B54F60", VA = "0x182B56160")]
			public static Variant IQIADXNYGFQ(VJBGGKQUSTY a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B58490", Offset = "0x2B57290", VA = "0x182B58490")]
			public static Variant ZSMFPHXPLWP(VJBGGKQUSTY a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B569D0", Offset = "0x2B557D0", VA = "0x182B569D0")]
			public static bool MINSXFCAORT(VJBGGKQUSTY a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B56C80", Offset = "0x2B55A80", VA = "0x182B56C80")]
			[IteratorStateMachine(typeof(ZGSWIVINVFD))]
			public static IEnumerable<Id32<IMTHRFIEELI>> NOBTABOROXF(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class LWMIVTBZKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B52F20", Offset = "0x2B51D20", VA = "0x182B52F20")]
		public static FSVVZOKDCEG HPFTFJWMZQX(this VJBGGKQUSTY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B523B0", Offset = "0x2B511B0", VA = "0x182B523B0")]
		public static VJBGGKQUSTY CLFJUUWNTXI(this FSVVZOKDCEG a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class TYHDONXKNYU
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A6D0", Offset = "0x3D394D0", VA = "0x183D3A6D0")]
		public static Dictionary<b, c> SJQLIIRAJQS<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class SOADVBBWNRF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B668E0", Offset = "0x2B656E0", VA = "0x182B668E0")]
		public static LLFGBFKSQFY HPFTFJWMZQX([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B66840", Offset = "0x2B65640", VA = "0x182B66840")]
		public static Guid CLFJUUWNTXI(LLFGBFKSQFY a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class CEHFHBDVPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BD60", Offset = "0x2B4AB60", VA = "0x182B4BD60")]
		public static UDEDABUAAPS HPFTFJWMZQX([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BD00", Offset = "0x2B4AB00", VA = "0x182B4BD00")]
		public static NamedType CLFJUUWNTXI(this UDEDABUAAPS a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class FQXLFLESHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x38D9F10", Offset = "0x38D8D10", VA = "0x1838D9F10")]
		public static void ZSJGNXBEYRC<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x38DAC60", Offset = "0x38D9A60", VA = "0x1838DAC60")]
		public static void ZSJGNXBEYRC<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class TQZMJQCFMEV
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B67100", Offset = "0x2B65F00", VA = "0x182B67100")]
		public static COZAKWJURCA HPFTFJWMZQX([In] this Variant self, VJBGGKQUSTY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B66FB0", Offset = "0x2B65DB0", VA = "0x182B66FB0")]
		public static Variant CLFJUUWNTXI(this COZAKWJURCA a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LUZESLDUHNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Id128<WEPGJVDZXXP> KHPEHWZAOSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public readonly bool LIXHOBQSXOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public readonly bool IMQDSGERKQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly bool PCIUMSWXADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public readonly bool POVHCOQUXML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public readonly bool PPANZVKSGXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public readonly bool BLUBRKDYTBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public readonly bool NSJINZNCDVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool ISMZFKVQHGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly List<(string Name, VJBGGKQUSTY Type)> QMJUOAZWSEN;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[WillBeRenamedTo("LegacyId")]
		public Guid WBRSHDLSFDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B130F0", Offset = "0x2B11EF0", VA = "0x182B130F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Id128<WEPGJVDZXXP> WXNKIGMKVOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B130F0", Offset = "0x2B11EF0", VA = "0x182B130F0")]
			get
			{
				return default(Id128<WEPGJVDZXXP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public IReadOnlyList<(string Name, VJBGGKQUSTY Type)> RMXINTGGPMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ZFIMFHVSXRZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B51AE0", Offset = "0x2B508E0", VA = "0x182B51AE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B51A40", Offset = "0x2B50840", VA = "0x182B51A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, VJBGGKQUSTY> LITWDTJYQUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B517E0", Offset = "0x2B505E0", VA = "0x182B517E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B51200", Offset = "0x2B50000", VA = "0x182B51200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> TZJHMYAJOUT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B51580", Offset = "0x2B50380", VA = "0x182B51580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B512B0", Offset = "0x2B500B0", VA = "0x182B512B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> PHFFMOJEJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B51150", Offset = "0x2B4FF50", VA = "0x182B51150")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B51890", Offset = "0x2B50690", VA = "0x182B51890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, VJBGGKQUSTY> PBNFUECPYIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B52210", Offset = "0x2B51010", VA = "0x182B52210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B52160", Offset = "0x2B50F60", VA = "0x182B52160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action YUNECIYNTIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B51740", Offset = "0x2B50540", VA = "0x182B51740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B51940", Offset = "0x2B50740", VA = "0x182B51940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x18C0B10", Offset = "0x18BF910", VA = "0x1818C0B10")]
		public void DLJZFONOXEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B522C0", Offset = "0x2B510C0", VA = "0x182B522C0")]
		internal LUZESLDUHNN([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, VJBGGKQUSTY Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B51F20", Offset = "0x2B50D20", VA = "0x182B51F20")]
		public static CircuitEventDefinitionFactoryStart VHMWPQEADTW(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B51FF0", Offset = "0x2B50DF0", VA = "0x182B51FF0")]
		public static CircuitEventDefinitionFactoryStart VHMWPQEADTW(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B51630", Offset = "0x2B50430", VA = "0x182B51630")]
		public static LUZESLDUHNN IKBSRTORCAU([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B51CE0", Offset = "0x2B50AE0", VA = "0x182B51CE0")]
		public static LUZESLDUHNN VEOXSJSLILY([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xF31A00", Offset = "0xF30800", VA = "0x180F31A00")]
		public void FMPYPAKKZJE(Id128<WEPGJVDZXXP> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B519E0", Offset = "0x2B507E0", VA = "0x182B519E0")]
		public void RJNATFMNUVD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B52070", Offset = "0x2B50E70", VA = "0x182B52070")]
		public void WXQPUDCHFEJ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B51BF0", Offset = "0x2B509F0", VA = "0x182B51BF0")]
		public void TKPGSCQUSJM(int a, VJBGGKQUSTY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B51460", Offset = "0x2B50260", VA = "0x182B51460")]
		public void DRWVVUYKHHA(string a, VJBGGKQUSTY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B51B80", Offset = "0x2B50980", VA = "0x182B51B80")]
		public void TGOKUBNIWRF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B51360", Offset = "0x2B50160", VA = "0x182B51360")]
		public LUZESLDUHNN Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct CircuitEventDefinitionFactoryStart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C350", Offset = "0x2B4B150", VA = "0x182B4C350")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C0B0", Offset = "0x2B4AEB0", VA = "0x182B4C0B0")]
		public CircuitEventDefinitionFactoryParams FWAYEDKSLOU(string a, VJBGGKQUSTY b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C220", Offset = "0x2B4B020", VA = "0x182B4C220")]
		public LUZESLDUHNN PKVJCOOHHUA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct CircuitEventDefinitionFactoryParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly List<(string Name, VJBGGKQUSTY Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C020", Offset = "0x2B4AE20", VA = "0x182B4C020")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, VJBGGKQUSTY Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BDF0", Offset = "0x2B4ABF0", VA = "0x182B4BDF0")]
		public CircuitEventDefinitionFactoryParams FWAYEDKSLOU(string a, VJBGGKQUSTY b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BF20", Offset = "0x2B4AD20", VA = "0x182B4BF20")]
		public LUZESLDUHNN PKVJCOOHHUA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TLOAYVJQGDS
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public static readonly LUZESLDUHNN MWJIMAHHHZT;

			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly LUZESLDUHNN MNBGTQENUIG;

			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly LUZESLDUHNN VXPFPYOWSSB;

			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly LUZESLDUHNN IPASMPXONNQ;

			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public static readonly LUZESLDUHNN QTBFKXBBJWJ;

			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public static readonly LUZESLDUHNN JNVKJROLAVL;

			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly LUZESLDUHNN PVDGNQOQYZU;

			[Cpp2IlInjected.Token(Token = "0x4000136")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			internal static readonly LUZESLDUHNN[] ORIMCUALCIH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class LMOEEJBKRHB
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly LUZESLDUHNN NINOLTHYKXT;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class UGGAMDJILRE
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly LUZESLDUHNN ZHCUCWFNERZ;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly LUZESLDUHNN EKYSQKCLYAA;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class BVKKOXMMTAD
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly LUZESLDUHNN CMHJJQKGSUM;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly LUZESLDUHNN QFZLEQZRQFD;

			[Cpp2IlInjected.Token(Token = "0x400013F")]
			internal static readonly LUZESLDUHNN[] YEJYEATOXZN;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public static readonly LUZESLDUHNN SGZXJMTEJTB;

			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly LUZESLDUHNN XAQBJFDTCAS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class WLUYTSYWVGP
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly LUZESLDUHNN RQDSHNNAQAS;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly LUZESLDUHNN APVHLEQTAMT;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class YIWKQOFHXVO
		{
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public static readonly LUZESLDUHNN LMKFLSNQNFZ;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly LUZESLDUHNN XFDVFWTMLGC;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class USSAMXPGOFN
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public static readonly LUZESLDUHNN ZHCUCWFNERZ;

			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly LUZESLDUHNN EKYSQKCLYAA;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class WMAKUHFIIYH
		{
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public static readonly LUZESLDUHNN QWACNHMPFRU;

			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly LUZESLDUHNN HCXQEVUOOLD;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly LUZESLDUHNN YLSIKGIBXNN;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public static readonly LUZESLDUHNN ZTVBQRXYWVB;

			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly LUZESLDUHNN KVGYSAYPMJO;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly LUZESLDUHNN HRGXKWGICRX;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public static readonly LUZESLDUHNN XPVKQXMZBIA;

			[Cpp2IlInjected.Token(Token = "0x4000153")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class MDFHUAVNLTZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class SLFFKHRWELF
		{
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class YSEVMXSXOQD
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class OBSYVOXILAH
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly LUZESLDUHNN ZZEMEKCZHWU;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly LUZESLDUHNN XPSAOKNUMMF;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RJMUXIWVGIR
		{
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class WCGIKYASSBV
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class XJMEZMHVBWV
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class ONGOEBRGJHA
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly LUZESLDUHNN UBXNVYSXZGY;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public static readonly LUZESLDUHNN UGULVRMYDUE;

			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public static readonly LUZESLDUHNN XHOYMWYQAMZ;

			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public static readonly LUZESLDUHNN FLUFQHBOAOS;

			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public static readonly LUZESLDUHNN GZJZXYKSKTE;

			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public static readonly LUZESLDUHNN LMKFLSNQNFZ;

			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly LUZESLDUHNN HCPHIXBFUFI;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public static readonly LUZESLDUHNN AJHMBMWQIAL;

			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly LUZESLDUHNN QNGTUAHDXKR;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly LUZESLDUHNN FZONUWEFSJF;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly LUZESLDUHNN NCDOBXSLYMJ;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly LUZESLDUHNN SIPFZVNBJBZ;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly LUZESLDUHNN ZRWRFCJSEWY;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly LUZESLDUHNN YJCWLGOKWGZ;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly LUZESLDUHNN AUSWUCREWGA;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly LUZESLDUHNN TGNYUIJILSI;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly LUZESLDUHNN PVKLCFYPOGC;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly LUZESLDUHNN AFHHESYNEBB;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly LUZESLDUHNN QNKMASNBOHM;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly LUZESLDUHNN YJSHBVESPBG;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly LUZESLDUHNN CJEDCQSAPST;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly LUZESLDUHNN PYWROBLGWTB;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly LUZESLDUHNN ZDRQUGHGOFV;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly LUZESLDUHNN TWPZQBBRBWL;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly LUZESLDUHNN HGYUUTAYRZP;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly LUZESLDUHNN DCDZIDIQYEB;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly LUZESLDUHNN GXCDTPKOBLT;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly LUZESLDUHNN XYIQEJYDDNL;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly LUZESLDUHNN BRPGIXNUAPW;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly LUZESLDUHNN NPHCCOVGSFC;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly LUZESLDUHNN EKMHZWLUNCV;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly LUZESLDUHNN EPOXJMTFYLD;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly LUZESLDUHNN UMRKCZCENEM;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly LUZESLDUHNN ANGPHIYWGAA;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly LUZESLDUHNN YVHIFAPXVKY;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly LUZESLDUHNN PTUMLNGWXOA;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly LUZESLDUHNN FGLISSMOQMA;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly LUZESLDUHNN YDPLKMMPVOG;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly LUZESLDUHNN KASHNGQXITE;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly LUZESLDUHNN JIVIEUUVCMC;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly LUZESLDUHNN WSFNLPNBWJH;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly LUZESLDUHNN MVFRXBJRTNT;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly LUZESLDUHNN LNDOSIUMDZB;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly LUZESLDUHNN PZJIZQDVNFD;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly LUZESLDUHNN RKMLHSRAJSP;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly LUZESLDUHNN VXYKQODJABN;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly LUZESLDUHNN NPCHPYXNSRH;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly LUZESLDUHNN HSBLIVBFACX;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly LUZESLDUHNN TFZVYWKIWYF;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly LUZESLDUHNN UFRRDETRYQX;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly LUZESLDUHNN UQSNZKHFVMK;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly LUZESLDUHNN KUZYOZWPSDT;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly LUZESLDUHNN OLLKDHDTNRT;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly LUZESLDUHNN QNLNKYCNDEJ;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly LUZESLDUHNN SPQKDUDPFVZ;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly LUZESLDUHNN ESKITTDEXMN;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly LUZESLDUHNN VJBPLUKWPVJ;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly LUZESLDUHNN CKUUDXSXNKP;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly LUZESLDUHNN EJATQVDUPWZ;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly LUZESLDUHNN PISSEVDVQJB;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly LUZESLDUHNN OXTXVZTVXIJ;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly LUZESLDUHNN CMLVIFPCOKT;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly LUZESLDUHNN DKPSUYDDFKC;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly LUZESLDUHNN CRBVUBUJZGN;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly LUZESLDUHNN WIPANZEOXER;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly LUZESLDUHNN PJUKLFMAGGQ;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly LUZESLDUHNN HZZUFWDLLIM;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly LUZESLDUHNN NTJHGFRSZYT;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly LUZESLDUHNN ISMOMBJBYUD;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class FJBQBUELTRG
		{
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class ZYFRRRKNKMF
		{
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly LUZESLDUHNN VJGBUAJHAAX;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly LUZESLDUHNN LEOJRDUSOBC;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly LUZESLDUHNN JHDRVSKAPGE;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly LUZESLDUHNN RNNPOQEFPCP;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly LUZESLDUHNN IBQVNWTCUWP;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public static readonly LUZESLDUHNN ZGUVSHNCNHH;

			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public static readonly LUZESLDUHNN ZYELVEHRCAL;

			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class EMWXJTEOGWQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly LUZESLDUHNN UGULVRMYDUE;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly LUZESLDUHNN XHOYMWYQAMZ;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly LUZESLDUHNN FLUFQHBOAOS;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly LUZESLDUHNN EHCHKEYYIJC;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly LUZESLDUHNN XTEIPUXGOSA;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly LUZESLDUHNN FHQRYXLMLSE;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public static readonly LUZESLDUHNN RVTGEMGRNAU;

			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class OJXVHMKGAHA
		{
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly LUZESLDUHNN EKDZXFCFDNU;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly LUZESLDUHNN JRTAIKKLDOI;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly LUZESLDUHNN VFETUSEXUHX;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly LUZESLDUHNN YCEGYYCVRJF;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly LUZESLDUHNN PTBWWPRPYFT;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly LUZESLDUHNN KUPEKKENFGN;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class GLMUIKSYIWN
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class UUKAMCXTFBS
		{
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly LUZESLDUHNN QRTVPONIDTQ;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class ENGGAHQCLTM
		{
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly LUZESLDUHNN UBXNVYSXZGY;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class OOZUIQURFIZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class AQOBYKDCAEO
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class TXWEJRCSDHF
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public static readonly LUZESLDUHNN UBHXDSRAOHT;

			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly LUZESLDUHNN PFCPRTCOXRF;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public static readonly LUZESLDUHNN SZSTRYAJMGO;

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly LUZESLDUHNN SVTDDDOCMBM;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class XMEZSSHJYFD
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public static readonly LUZESLDUHNN QLOUDQGUDXA;

			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public static readonly LUZESLDUHNN DGLKPXHXLFN;

			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class KCPDHFXBVHX
		{
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class VJBYEIWUPJD
		{
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly LUZESLDUHNN VJGBUAJHAAX;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly LUZESLDUHNN LEOJRDUSOBC;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class ZYIFXBSOJIS
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly LUZESLDUHNN GGWYBLKZZEV;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly LUZESLDUHNN RNNPOQEFPCP;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public static readonly LUZESLDUHNN IBQVNWTCUWP;

			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public static readonly LUZESLDUHNN ZGUVSHNCNHH;

			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly LUZESLDUHNN NRJAGXWDLPI;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly LUZESLDUHNN KOYIWFOBHPV;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public static readonly LUZESLDUHNN NKQJNLRXCYT;

			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly LUZESLDUHNN FWTHRWLNABD;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly LUZESLDUHNN MSTIRTCJNOW;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly LUZESLDUHNN OBZRQCTJUGK;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly LUZESLDUHNN VJGBUAJHAAX;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly LUZESLDUHNN LEOJRDUSOBC;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class DKEYAGCMMQO
		{
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class GLZUFEFFQES
		{
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly LUZESLDUHNN VJGBUAJHAAX;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly LUZESLDUHNN LEOJRDUSOBC;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly LUZESLDUHNN WXPYPHQFTNO;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly LUZESLDUHNN BKEOWMZXCHQ;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly LUZESLDUHNN HLDMMXHQRJH;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class DSTBEAASNSV
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class JERCLTHCFPS
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly LUZESLDUHNN FJXSBVGMKPD;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class OBKGKBZGVRO
		{
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly LUZESLDUHNN ETEMPUKUPTG;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly LUZESLDUHNN QXIQFNHITHT;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly LUZESLDUHNN VJGBUAJHAAX;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static readonly LUZESLDUHNN LEOJRDUSOBC;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class WZXLVSRYMRJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class EMHSJCYRKMX
		{
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class BCWPBBDUZPW
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class ZZIIMPFGCHO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class CBUDKBXIKGR
		{
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class FDVROLDYJQB
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly LUZESLDUHNN ZZEMEKCZHWU;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public static readonly LUZESLDUHNN XPSAOKNUMMF;

			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class QSPMYHKGRNV
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public static readonly LUZESLDUHNN YOCZFFMQGSC;

			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public static readonly LUZESLDUHNN JQGHYKNYMSE;

			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public static readonly LUZESLDUHNN MYNHWTVQYYE;

			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly LUZESLDUHNN FRPWEXYEDMO;

			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class GUYPUNVPTWI
		{
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly LUZESLDUHNN YOCZFFMQGSC;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public static readonly LUZESLDUHNN JQGHYKNYMSE;

			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly LUZESLDUHNN MYNHWTVQYYE;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly LUZESLDUHNN FRPWEXYEDMO;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class JJBCWWYKJEN
		{
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class SIVIIPPFJFE
		{
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public static readonly LUZESLDUHNN YPWRBFRDYIN;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly LUZESLDUHNN VFVAHIPROGT;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly LUZESLDUHNN ZDIIKLPWOPV;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class HTXTJEDMRAP
		{
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly LUZESLDUHNN RWDMSQHOABG;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public static readonly LUZESLDUHNN OCEQNTHKPMK;

			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public static readonly LUZESLDUHNN NWIWTQMHCJV;

			[Cpp2IlInjected.Token(Token = "0x4000207")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class KPRPGNVZHWC
		{
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class XTJJNQUPGCL
		{
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly LUZESLDUHNN OZTBPYLJEDR;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public static readonly LUZESLDUHNN HANGWJIUXQV;

			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly LUZESLDUHNN LFPGIBVBAVI;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly LUZESLDUHNN VYLFXNTKWSK;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly LUZESLDUHNN YKVFQAIJQVZ;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class SDIWNHCQMKG
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static readonly LUZESLDUHNN ATVUGNTDQTR;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class DMJGMJPHFPC
		{
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly LUZESLDUHNN KYOOUCHTCDI;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly LUZESLDUHNN XEDRJYRFXCL;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly LUZESLDUHNN VPSINOQEBNQ;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class TJQCFJFNEEF
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class XAVFGILWVMZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class NVGZCNBZDWY
		{
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class MEEBIZIZAWH
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly LUZESLDUHNN AVUNNHLGXXS;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly LUZESLDUHNN NOZSOCZJBWJ;

			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly LUZESLDUHNN ZTCBYAQVSRF;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static readonly LUZESLDUHNN CJLRAOIIHNZ;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public static readonly LUZESLDUHNN HIZVXSOXWIU;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static readonly LUZESLDUHNN QPWREHEVAUW;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly LUZESLDUHNN AOCGYVLHXYB;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			internal static readonly LUZESLDUHNN[] HGXHCIEEHMG;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class OXJCKBMJGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public readonly VJBGGKQUSTY DHRSRGKRHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private readonly List<LUZESLDUHNN> ZQTRZARNPMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private readonly List<LUZESLDUHNN> YVCDCWMMVWB;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IReadOnlyList<LUZESLDUHNN> ERNGCKMJVRL
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public IReadOnlyList<LUZESLDUHNN> MNPEUBJWASY
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2B74A70", Offset = "0x2B73870", VA = "0x182B74A70")]
		protected OXJCKBMJGPP(VJBGGKQUSTY a, params LUZESLDUHNN[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class RUCOUQDVWEL : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B75EC0", Offset = "0x2B74CC0", VA = "0x182B75EC0")]
		internal RUCOUQDVWEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class BLTDFSBZPLS : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C370", Offset = "0x2B6B170", VA = "0x182B6C370")]
		internal BLTDFSBZPLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class JNZSBFTDJBB : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B71DA0", Offset = "0x2B70BA0", VA = "0x182B71DA0")]
		internal JNZSBFTDJBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class GFYDGDUAWRW : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F060", Offset = "0x2B6DE60", VA = "0x182B6F060")]
		internal GFYDGDUAWRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class WCHXSNJIHDZ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B78BC0", Offset = "0x2B779C0", VA = "0x182B78BC0")]
		internal WCHXSNJIHDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class VWCNHKHJWAX : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B78800", Offset = "0x2B77600", VA = "0x182B78800")]
		internal VWCNHKHJWAX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class DLGWDJUGTVU : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C9F0", Offset = "0x2B6B7F0", VA = "0x182B6C9F0")]
		internal DLGWDJUGTVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class VZHDUYIMMBR : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B789E0", Offset = "0x2B777E0", VA = "0x182B789E0")]
		internal VZHDUYIMMBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class WIYHVATWUCX : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B78F80", Offset = "0x2B77D80", VA = "0x182B78F80")]
		internal WIYHVATWUCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class TMIDLLUMZYD : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FD0", Offset = "0x2B75DD0", VA = "0x182B76FD0")]
		internal TMIDLLUMZYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class LKUENOWEBKH : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B72C20", Offset = "0x2B71A20", VA = "0x182B72C20")]
		internal LKUENOWEBKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class XMSDCKCTCGT : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B799B0", Offset = "0x2B787B0", VA = "0x182B799B0")]
		internal XMSDCKCTCGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class JPYSBBJOVFJ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B71F80", Offset = "0x2B70D80", VA = "0x182B71F80")]
		internal JPYSBBJOVFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class PTBJKBTFVQZ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B75190", Offset = "0x2B73F90", VA = "0x182B75190")]
		internal PTBJKBTFVQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class RBIMMTMPWWJ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B00", Offset = "0x2B74900", VA = "0x182B75B00")]
		internal RBIMMTMPWWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class IBNHVCTLWET : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B712F0", Offset = "0x2B700F0", VA = "0x182B712F0")]
		internal IBNHVCTLWET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class OXUOKGTUWHL : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B74BF0", Offset = "0x2B739F0", VA = "0x182B74BF0")]
		internal OXUOKGTUWHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class KJLMKNTWGAQ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B72590", Offset = "0x2B71390", VA = "0x182B72590")]
		internal KJLMKNTWGAQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ZAHVCBJIIDU : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AF00", Offset = "0x2B79D00", VA = "0x182B7AF00")]
		internal ZAHVCBJIIDU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class AMDNODMDZLK : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BB10", Offset = "0x2B6A910", VA = "0x182B6BB10")]
		internal AMDNODMDZLK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class RYZVAGFACNY : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B760A0", Offset = "0x2B74EA0", VA = "0x182B760A0")]
		internal RYZVAGFACNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class OVWFIYXJPZU : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2B74810", Offset = "0x2B73610", VA = "0x182B74810")]
		internal OVWFIYXJPZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class UBCSOSHEHDX : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B77A30", Offset = "0x2B76830", VA = "0x182B77A30")]
		internal UBCSOSHEHDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class LEHYOXXJUNU : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B72A40", Offset = "0x2B71840", VA = "0x182B72A40")]
		internal LEHYOXXJUNU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class FMEEPCTNXSF : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ECA0", Offset = "0x2B6DAA0", VA = "0x182B6ECA0")]
		internal FMEEPCTNXSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class FQZLOWXZZWQ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EE80", Offset = "0x2B6DC80", VA = "0x182B6EE80")]
		internal FQZLOWXZZWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class AYCIPMBJTJQ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BD60", Offset = "0x2B6AB60", VA = "0x182B6BD60")]
		internal AYCIPMBJTJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class SDJXJXWQQIM : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2B765E0", Offset = "0x2B753E0", VA = "0x182B765E0")]
		internal SDJXJXWQQIM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LRLBMANOBQN : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2B72E00", Offset = "0x2B71C00", VA = "0x182B72E00")]
		internal LRLBMANOBQN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TIDZNQMCQUE : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2B76D80", Offset = "0x2B75B80", VA = "0x182B76D80")]
		internal TIDZNQMCQUE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YTIAUHCKFVF : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A960", Offset = "0x2B79760", VA = "0x182B7A960")]
		internal YTIAUHCKFVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class IAHIXSMTSMB : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2B71110", Offset = "0x2B6FF10", VA = "0x182B71110")]
		internal IAHIXSMTSMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HOZFKNGEQZT : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B70890", Offset = "0x2B6F690", VA = "0x182B70890")]
		internal HOZFKNGEQZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class KUAZWIBJUEM : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2B727E0", Offset = "0x2B715E0", VA = "0x182B727E0")]
		internal KUAZWIBJUEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class QWBWZNZBWRK : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B75920", Offset = "0x2B74720", VA = "0x182B75920")]
		internal QWBWZNZBWRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class YHWLCYWQRSY : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A700", Offset = "0x2B79500", VA = "0x182B7A700")]
		internal YHWLCYWQRSY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WHYAJRBXPSR : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2B78DA0", Offset = "0x2B77BA0", VA = "0x182B78DA0")]
		internal WHYAJRBXPSR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class HLXKPKVQXJE : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B70630", Offset = "0x2B6F430", VA = "0x182B70630")]
		internal HLXKPKVQXJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class CCTOIRFZYTE : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C540", Offset = "0x2B6B340", VA = "0x182B6C540")]
		internal CCTOIRFZYTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class IUUGFFHDTVJ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2B716B0", Offset = "0x2B704B0", VA = "0x182B716B0")]
		internal IUUGFFHDTVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class MBFRXENECET : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B72FE0", Offset = "0x2B71DE0", VA = "0x182B72FE0")]
		internal MBFRXENECET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class BHJAZWMCVUX : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C190", Offset = "0x2B6AF90", VA = "0x182B6C190")]
		internal BHJAZWMCVUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class CQDABFFXVBA : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C7A0", Offset = "0x2B6B5A0", VA = "0x182B6C7A0")]
		internal CQDABFFXVBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class UXGXDIAGCYS : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B78050", Offset = "0x2B76E50", VA = "0x182B78050")]
		internal UXGXDIAGCYS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class WQWKTFOXREN : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B79160", Offset = "0x2B77F60", VA = "0x182B79160")]
		internal WQWKTFOXREN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class PHMREXBKJFW : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2B74FB0", Offset = "0x2B73DB0", VA = "0x182B74FB0")]
		internal PHMREXBKJFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class HSAKTNNLADR : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B70A70", Offset = "0x2B6F870", VA = "0x182B70A70")]
		internal HSAKTNNLADR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class FJNMYEXUARE : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EAC0", Offset = "0x2B6D8C0", VA = "0x182B6EAC0")]
		internal FJNMYEXUARE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class RQSLWBYRZBG : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B75CE0", Offset = "0x2B74AE0", VA = "0x182B75CE0")]
		internal RQSLWBYRZBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class PERLDOLFADH : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B74DD0", Offset = "0x2B73BD0", VA = "0x182B74DD0")]
		internal PERLDOLFADH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class YWYOSNYYOBX : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AD20", Offset = "0x2B79B20", VA = "0x182B7AD20")]
		internal YWYOSNYYOBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class XWUCLFLPYXS : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A520", Offset = "0x2B79320", VA = "0x182B7A520")]
		internal XWUCLFLPYXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class IMJFKGIETKR : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2B714D0", Offset = "0x2B702D0", VA = "0x182B714D0")]
		internal IMJFKGIETKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class BDSLXPHWOKM : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BFB0", Offset = "0x2B6ADB0", VA = "0x182B6BFB0")]
		internal BDSLXPHWOKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class JZUIWCHLGHM : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2B72340", Offset = "0x2B71140", VA = "0x182B72340")]
		internal JZUIWCHLGHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class ZUUFJIMYKES : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B0E0", Offset = "0x2B79EE0", VA = "0x182B7B0E0")]
		internal ZUUFJIMYKES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class JNRNDZNZQEO : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B71BC0", Offset = "0x2B709C0", VA = "0x182B71BC0")]
		internal JNRNDZNZQEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class YVYIGKOSCMR : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB40", Offset = "0x2B79940", VA = "0x182B7AB40")]
		internal YVYIGKOSCMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class VIGSMATVOAY : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B78230", Offset = "0x2B77030", VA = "0x182B78230")]
		internal VIGSMATVOAY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class JTFYBARKBVE : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B72160", Offset = "0x2B70F60", VA = "0x182B72160")]
		internal JTFYBARKBVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class UFGCNQJIOMJ : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2B77C10", Offset = "0x2B76A10", VA = "0x182B77C10")]
		internal UFGCNQJIOMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class WUBEBYKWQIG : OXJCKBMJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B79340", Offset = "0x2B78140", VA = "0x182B79340")]
		internal WUBEBYKWQIG()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public readonly struct NamedType : IEquatable<NamedType>, IWKTMLXEDYU<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public readonly VJBGGKQUSTY Type;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
		private NamedType(string name, VJBGGKQUSTY type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9840", Offset = "0x2AA8640", VA = "0x182AA9840")]
		public static NamedType New(string name, VJBGGKQUSTY type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2B73710", Offset = "0x2B72510", VA = "0x182B73710")]
		public static bool TRHVNHMHPTX([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2B73710", Offset = "0x2B72510", VA = "0x182B73710", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2B73710", Offset = "0x2B72510", VA = "0x182B73710")]
		public bool JECCPMWTKQN([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B73660", Offset = "0x2B72460", VA = "0x182B73660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B73760", Offset = "0x2B72560", VA = "0x182B73760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B73810", Offset = "0x2B72610", VA = "0x182B73810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B737D0", Offset = "0x2B725D0", VA = "0x182B737D0")]
		public string OKQUMQDTVIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B73850", Offset = "0x2B72650", VA = "0x182B73850")]
		public string XGRKUDYIXDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B73710", Offset = "0x2B72510", VA = "0x182B73710", Slot = "5")]
		private bool MXGLLYIHQYU([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public interface SVBMWMSSDIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, SJKUUBAWOPB>> CMMOBWCVPLD(ELPAQFNEADX a, bool b);
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
