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
		[Cpp2IlInjected.Address(RVA = "0x2BEF530", Offset = "0x2BEDF30", VA = "0x182BEF530")]
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
namespace _LogRegistration.Circuits_Static_RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF0D0", Offset = "0x2BEDAD0", VA = "0x182BEF0D0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MCLBYUYIMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF150", Offset = "0x2BEDB50", VA = "0x182BEF150")]
		public static bool VKNMHYILMKX(this HZZYFIUKWAB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF260", Offset = "0x2BEDC60", VA = "0x182BEF260")]
		public static bool VKNMHYILMKX(this ZGFIKLGOGCU a)
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
			private readonly WNWYUXAFTQH _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			public EVRequest(WNWYUXAFTQH staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class IHTIONZTHOG
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<KTAQVOGERXD>, IDURWQFXNFK> PNAABHMSFFN;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<KTAQVOGERXD>>? PQEPYUEKWZB;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<KTAQVOGERXD> HKNYQRYDUPP;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<KTAQVOGERXD> NZIMLRHCFBU;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<KTAQVOGERXD> PVMLEKFQDGV;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<KTAQVOGERXD> YWVSEDOIFDS;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<KTAQVOGERXD> EEFUPDCBUBH;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<KTAQVOGERXD> SZCAIWRCWDI;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<KTAQVOGERXD> BFBNDCWABVC;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<KTAQVOGERXD> BGIKCSISCEU;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<KTAQVOGERXD> NAYWSHPVHIM;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<KTAQVOGERXD> RGLRJUAQAUE;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<KTAQVOGERXD> OBZULDAZYKW;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<KTAQVOGERXD> ZEPDXURYGIW;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<KTAQVOGERXD> HPUYQIFXLSX;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<KTAQVOGERXD> QLQVVUYIFWZ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<KTAQVOGERXD> DIINNIASTGR;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<KTAQVOGERXD> WZXBEETFVFY;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<KTAQVOGERXD> NJFZSFHMCFT;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<KTAQVOGERXD> LEHVLCPMPPN;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<KTAQVOGERXD> TIRRHUZECGQ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<KTAQVOGERXD> MZRBBDWLEBB;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<KTAQVOGERXD> DJJMMMFEJYO;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<KTAQVOGERXD> QVKLQZAOPJR;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<KTAQVOGERXD> RREQIGPEWLT;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<KTAQVOGERXD> KXVYIYPSJHM;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<KTAQVOGERXD> QSJAHLNLSJI;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<KTAQVOGERXD> SKRMUVCTVBL;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<KTAQVOGERXD> DYGPTPZMQGQ;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<KTAQVOGERXD> PNXLRNAPJXH;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<KTAQVOGERXD> VGNEYLSXWCF;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<KTAQVOGERXD> ABSYXOSOCHJ;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<KTAQVOGERXD> WSQCKEMEEAF;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<KTAQVOGERXD> UFFJMNUCWRO;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<KTAQVOGERXD> CMMCNXGFHFZ;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<KTAQVOGERXD> DNBHSWLIWHT;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<KTAQVOGERXD> FFQBSOKKLZP;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<KTAQVOGERXD> IIRREPAGTGK;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<KTAQVOGERXD> ABWFZFRHIKD;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<KTAQVOGERXD> XXKECEKNXDW;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<KTAQVOGERXD> ZLXUTATRVNC;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<KTAQVOGERXD> CMANQAPOOGQ;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<KTAQVOGERXD> STWIIHPYAQH;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<KTAQVOGERXD> YDZMFMJHZMH;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<KTAQVOGERXD> NOHLEQGKOSI;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<KTAQVOGERXD> IKWOEUGZXXR;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<KTAQVOGERXD> XOOSBRLFWYL;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<KTAQVOGERXD> LGVPGNQXKER;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<KTAQVOGERXD> XVFMFKYYQVG;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<KTAQVOGERXD> EFHIEGRXXSW;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<KTAQVOGERXD> KSGJJZFQKRC;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<KTAQVOGERXD> VVQBAHFQTGR;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<KTAQVOGERXD> IHFGWKXCSLT;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<KTAQVOGERXD> WWDLUXOQYQW;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<KTAQVOGERXD> UWEPORWTSSR;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<KTAQVOGERXD> MPRBRLRSQSH;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<KTAQVOGERXD> XZSWCTETITU;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<KTAQVOGERXD> CGSSACDSIQM;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<KTAQVOGERXD> MKRJUDFWFEY;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<KTAQVOGERXD> GORYCIQLHZG;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<KTAQVOGERXD> NZZJLXOWMEL;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<KTAQVOGERXD> WZBEWBNPWQC;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<KTAQVOGERXD> YWIRZVHZRJK;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<KTAQVOGERXD> BLUOIEMRZWU;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<KTAQVOGERXD> RGJLZQEDKLJ;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<KTAQVOGERXD> ZUCKWFCBBPH;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<KTAQVOGERXD> ZGOWNRLUXJS;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<KTAQVOGERXD> JVMLNQURDHR;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<KTAQVOGERXD> NHDTEPYAFZW;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<KTAQVOGERXD> ZBFONGESWBE;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<KTAQVOGERXD> KBHRYKQLGMY;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<KTAQVOGERXD>, IDURWQFXNFK> HCAHTRCOICY
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BEB670", Offset = "0x2BEA070", VA = "0x182BEB670")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB940", Offset = "0x2BEA340", VA = "0x182BEB940")]
			public static IDURWQFXNFK RHHPCRJHTGY(Id32<KTAQVOGERXD> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB5E0", Offset = "0x2BE9FE0", VA = "0x182BEB5E0")]
			public static bool BOMPJAIJZIZ(Id32<KTAQVOGERXD> id, [Out] IDURWQFXNFK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB890", Offset = "0x2BEA290", VA = "0x182BEB890")]
			public static HZZYFIUKWAB OYLEEPLCWKB(Id32<KTAQVOGERXD> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB9C0", Offset = "0x2BEA3C0", VA = "0x182BEB9C0")]
			private static Id32<KTAQVOGERXD> WSFSWRIEDET(IDURWQFXNFK a, Id32<KTAQVOGERXD> id)
			{
				return default(Id32<KTAQVOGERXD>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB6C0", Offset = "0x2BEA0C0", VA = "0x182BEB6C0")]
			private static void LKWITZYLWNR(Id32<KTAQVOGERXD> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class TIACULCJKOR
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<JCARNWHFFIV, HZZYFIUKWAB?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
				private TypeRegistryFactory([In] IdUnsafeList<JCARNWHFFIV, HZZYFIUKWAB?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2C065D0", Offset = "0x2C04FD0", VA = "0x182C065D0")]
				public static TypeRegistryFactory JPMHDBJTTOT()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2C06210", Offset = "0x2C04C10", VA = "0x182C06210")]
				public (ReadOnlyIdArray<JCARNWHFFIV, HZZYFIUKWAB>, IReadOnlyDictionary<HZZYFIUKWAB, Id32<JCARNWHFFIV>>) FHFBFMADOYL()
				{
					return default((ReadOnlyIdArray<JCARNWHFFIV, HZZYFIUKWAB>, IReadOnlyDictionary<HZZYFIUKWAB, Id32<JCARNWHFFIV>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2C06090", Offset = "0x2C04A90", VA = "0x182C06090")]
				public Id32<JCARNWHFFIV> CWZQSXROWSZ(int a, HZZYFIUKWAB b)
				{
					return default(Id32<JCARNWHFFIV>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2C06580", Offset = "0x2C04F80", VA = "0x182C06580")]
				public Id32<JCARNWHFFIV> Initialize(int id, RISVPEMNZVA type, RISVPEMNZVA factoryType)
				{
					return default(Id32<JCARNWHFFIV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class YZJWHJRZNYE
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<JCARNWHFFIV> KDDZIISXHTB
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2C06D90", Offset = "0x2C05790", VA = "0x182C06D90")]
					[CompilerGenerated]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2C06CD0", Offset = "0x2C056D0", VA = "0x182C06CD0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<JCARNWHFFIV> OSVOASADAUT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2C06D50", Offset = "0x2C05750", VA = "0x182C06D50")]
					[CompilerGenerated]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2C06C90", Offset = "0x2C05690", VA = "0x182C06C90")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<JCARNWHFFIV> FDFTGKQDCTK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2C06D10", Offset = "0x2C05710", VA = "0x182C06D10")]
					[CompilerGenerated]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2C06F10", Offset = "0x2C05910", VA = "0x182C06F10")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<JCARNWHFFIV> BRENKGXIHFU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2C06C50", Offset = "0x2C05650", VA = "0x182C06C50")]
					[CompilerGenerated]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2C06E10", Offset = "0x2C05810", VA = "0x182C06E10")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<JCARNWHFFIV> MCQXNVXGPYO
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2C06DD0", Offset = "0x2C057D0", VA = "0x182C06DD0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2C06E50", Offset = "0x2C05850", VA = "0x182C06E50")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<JCARNWHFFIV> KGXWHTEVKQP
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2C06ED0", Offset = "0x2C058D0", VA = "0x182C06ED0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2C06E90", Offset = "0x2C05890", VA = "0x182C06E90")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class IZVACLPPQSG : IEnumerable<HZZYFIUKWAB>, IEnumerable, IEnumerator<HZZYFIUKWAB>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private HZZYFIUKWAB RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int QBMVXUNSGXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool PXSUSTHLBUX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool UJBHOVMMBXK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion ATLNAAULKEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion NVWPKMMAUDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool OXPMBKMOPAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool YIPRZCSYTDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool WYFAGOMUDUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool SHZOZYGOXOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool KLANGQUPQBS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool GHMEXILDOUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool QQDNPZRGWDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool GHOAGTUZWSJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<HZZYFIUKWAB> IRFNBWFCZWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private HZZYFIUKWAB PRSDHZOAZQD;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private HZZYFIUKWAB NOOQKNLMXUW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
				[DebuggerHidden]
				public IZVACLPPQSG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BEEA90", Offset = "0x2BED490", VA = "0x182BEEA90", Slot = "7")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BEEB60", Offset = "0x2BED560", VA = "0x182BEEB60", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BEF010", Offset = "0x2BEDA10", VA = "0x182BEF010")]
				private void XNJKRYGWMCP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BEEB20", Offset = "0x2BED520", VA = "0x182BEEB20", Slot = "10")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BEEF50", Offset = "0x2BED950", VA = "0x182BEEF50", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<HZZYFIUKWAB> WXJLRZIETNH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BEEF50", Offset = "0x2BED950", VA = "0x182BEEF50", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator XDTPACFLBGX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class FHLWNMNAOUE : IEnumerable<HZZYFIUKWAB>, IEnumerable, IEnumerator<HZZYFIUKWAB>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private HZZYFIUKWAB RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int QBMVXUNSGXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion ATLNAAULKEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion NVWPKMMAUDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool WYFAGOMUDUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool SHZOZYGOXOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool OXPMBKMOPAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool YIPRZCSYTDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool RWDYHNLZVMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool DDTKXJJFIXN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool KLANGQUPQBS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool GHMEXILDOUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool TGPLATPUMHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool OLFBNCSKCIG;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private HZZYFIUKWAB NOOQKNLMXUW
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
				[DebuggerHidden]
				public FHLWNMNAOUE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BE9620", Offset = "0x2BE8020", VA = "0x182BE9620", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BE95E0", Offset = "0x2BE7FE0", VA = "0x182BE95E0", Slot = "10")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BEB530", Offset = "0x2BE9F30", VA = "0x182BEB530", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<HZZYFIUKWAB> WXJLRZIETNH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BEB530", Offset = "0x2BE9F30", VA = "0x182BEB530", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator XDTPACFLBGX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class TZMNXHJLZWT : IEnumerable<Id32<JCARNWHFFIV>>, IEnumerable, IEnumerator<Id32<JCARNWHFFIV>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<JCARNWHFFIV> RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int QBMVXUNSGXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion ATLNAAULKEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion NVWPKMMAUDW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool OXPMBKMOPAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool YIPRZCSYTDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool WYFAGOMUDUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool SHZOZYGOXOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool KLANGQUPQBS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool GHMEXILDOUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool QQDNPZRGWDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool GHOAGTUZWSJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<HZZYFIUKWAB> IRFNBWFCZWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<RISVPEMNZVA> IRAGEPLFQLF;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<JCARNWHFFIV> ZDHYXGCOURL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<JCARNWHFFIV>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2C05FA0", Offset = "0x2C049A0", VA = "0x182C05FA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
				[DebuggerHidden]
				public TZMNXHJLZWT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2C05860", Offset = "0x2C04260", VA = "0x182C05860", Slot = "7")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2C059F0", Offset = "0x2C043F0", VA = "0x182C059F0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2C05FF0", Offset = "0x2C049F0", VA = "0x182C05FF0")]
				private void XNJKRYGWMCP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2C06040", Offset = "0x2C04A40", VA = "0x182C06040")]
				private void XNORPFATVNY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2C059B0", Offset = "0x2C043B0", VA = "0x182C059B0", Slot = "10")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2C05EF0", Offset = "0x2C048F0", VA = "0x182C05EF0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<JCARNWHFFIV>> NYQAFFBIBWS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2C05EF0", Offset = "0x2C048F0", VA = "0x182C05EF0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator XDTPACFLBGX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log WVPIFBCBMJC;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<JCARNWHFFIV, HZZYFIUKWAB?> YXTMFQOKKXA;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<HZZYFIUKWAB, Id32<JCARNWHFFIV>> OXNEOAWCSEG;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly ZGFIKLGOGCU IKXBSHJDNIT;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly ZGFIKLGOGCU HFNELZFNVZZ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<HZZYFIUKWAB> AMSIJLVPXUV;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<HZZYFIUKWAB> ZXRLAFBULKQ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet QTWTGNZFBVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet DMNTSLCRDCF
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet GUKLHNBNILR
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD95C00", Offset = "0xD94600", VA = "0x180D95C00")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static HZZYFIUKWAB KDDZIISXHTB
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCDB0", Offset = "0x2BFB7B0", VA = "0x182BFCDB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static HZZYFIUKWAB OSVOASADAUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB1C0", Offset = "0x2BF9BC0", VA = "0x182BFB1C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static HZZYFIUKWAB FDFTGKQDCTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAB70", Offset = "0x2BF9570", VA = "0x182BFAB70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static HZZYFIUKWAB BRENKGXIHFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA340", Offset = "0x2BF8D40", VA = "0x182BFA340")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static HZZYFIUKWAB ODHRTFBTPJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC9A0", Offset = "0x2BFB3A0", VA = "0x182BFC9A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static HZZYFIUKWAB YERKSMIRHAD
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAC60", Offset = "0x2BF9660", VA = "0x182BFAC60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static HZZYFIUKWAB SWILVONJDQW
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE2D0", Offset = "0x2BFCCD0", VA = "0x182BFE2D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static HZZYFIUKWAB MCQXNVXGPYO
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD390", Offset = "0x2BFBD90", VA = "0x182BFD390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static RISVPEMNZVA JVHBBFQKNVA
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE3C0", Offset = "0x2BFCDC0", VA = "0x182BFE3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static RISVPEMNZVA WXXCIOMWSVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBAF0", Offset = "0x2BFA4F0", VA = "0x182BFBAF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static RISVPEMNZVA HMZSHDZAEPM
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD8C0", Offset = "0x2BFC2C0", VA = "0x182BFD8C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static RISVPEMNZVA NKMWFWQSOSU
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBC60", Offset = "0x2BFA660", VA = "0x182BFBC60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static RISVPEMNZVA CHCURJZJFTG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAF30", Offset = "0x2BF9930", VA = "0x182BFAF30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static RISVPEMNZVA THIMCXSAAFV
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDC10", Offset = "0x2BFC610", VA = "0x182BFDC10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static RISVPEMNZVA BQIZIIMMLYD
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE600", Offset = "0x2BFD000", VA = "0x182BFE600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static RISVPEMNZVA BACOZVETZBV
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA550", Offset = "0x2BF8F50", VA = "0x182BFA550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static RISVPEMNZVA OZTKJTKHSVU
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBE60", Offset = "0x2BFA860", VA = "0x182BFBE60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static RISVPEMNZVA NYOIWZVACNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE0A0", Offset = "0x2BFCAA0", VA = "0x182BFE0A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static RISVPEMNZVA JPYGHHKKXVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDC60", Offset = "0x2BFC660", VA = "0x182BFDC60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static RISVPEMNZVA GRLSVWARBFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA890", Offset = "0x2BF9290", VA = "0x182BFA890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static RISVPEMNZVA KBUHUXKLSHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE410", Offset = "0x2BFCE10", VA = "0x182BFE410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static RISVPEMNZVA KQKPWAXJNEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCFC0", Offset = "0x2BFB9C0", VA = "0x182BFCFC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static RISVPEMNZVA YOBJKWRZVTU
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBA30", Offset = "0x2BFA430", VA = "0x182BFBA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static RISVPEMNZVA IVKIATDSFAO
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAE10", Offset = "0x2BF9810", VA = "0x182BFAE10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static RISVPEMNZVA SFVIICGRENH
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDD70", Offset = "0x2BFC770", VA = "0x182BFDD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static RISVPEMNZVA DPTTRWOXHZH
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAB10", Offset = "0x2BF9510", VA = "0x182BFAB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static RISVPEMNZVA QOHKJDDRIJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDAF0", Offset = "0x2BFC4F0", VA = "0x182BFDAF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static RISVPEMNZVA GTHDQKCBNKD
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB8C0", Offset = "0x2BFA2C0", VA = "0x182BFB8C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static RISVPEMNZVA UMIUZYBPMSG
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD080", Offset = "0x2BFBA80", VA = "0x182BFD080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static RISVPEMNZVA GOYTNVKTYLR
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD910", Offset = "0x2BFC310", VA = "0x182BFD910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static RISVPEMNZVA MMNAAYOLIBH
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA830", Offset = "0x2BF9230", VA = "0x182BFA830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static RISVPEMNZVA DRYYIKBSRPZ
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCD50", Offset = "0x2BFB750", VA = "0x182BFCD50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static RISVPEMNZVA JMBCJQHPHDV
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC310", Offset = "0x2BFAD10", VA = "0x182BFC310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static RISVPEMNZVA KUWQNGBEKJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB040", Offset = "0x2BF9A40", VA = "0x182BFB040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static RISVPEMNZVA LRSNGEDODGL
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDDD0", Offset = "0x2BFC7D0", VA = "0x182BFDDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static RISVPEMNZVA KOPNOYBSCPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA7D0", Offset = "0x2BF91D0", VA = "0x182BFA7D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static RISVPEMNZVA FZVTONUGTOR
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA690", Offset = "0x2BF9090", VA = "0x182BFA690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static RISVPEMNZVA ECSALYKUSDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDD10", Offset = "0x2BFC710", VA = "0x182BFDD10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static RISVPEMNZVA DCHOVZZFIAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDE90", Offset = "0x2BFC890", VA = "0x182BFDE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static RISVPEMNZVA XUHNTBOOOWJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDBB0", Offset = "0x2BFC5B0", VA = "0x182BFDBB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static RISVPEMNZVA NFVAZYXESLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCCF0", Offset = "0x2BFB6F0", VA = "0x182BFCCF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static RISVPEMNZVA HHAVMXHGENJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB160", Offset = "0x2BF9B60", VA = "0x182BFB160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static RISVPEMNZVA KNPTIHMFOCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC3D0", Offset = "0x2BFADD0", VA = "0x182BFC3D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static RISVPEMNZVA OYSXAHLPMRQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB100", Offset = "0x2BF9B00", VA = "0x182BFB100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static RISVPEMNZVA AITEKJDQYPK
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAFE0", Offset = "0x2BF99E0", VA = "0x182BFAFE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static RISVPEMNZVA ZOVPAVVVZVJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA8E0", Offset = "0x2BF92E0", VA = "0x182BFA8E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static RISVPEMNZVA FHMYJGYSWWD
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC490", Offset = "0x2BFAE90", VA = "0x182BFC490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static RISVPEMNZVA IPDCNTCPPHY
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB550", Offset = "0x2BF9F50", VA = "0x182BFB550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static RISVPEMNZVA DMKFGPLQKWU
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE5A0", Offset = "0x2BFCFA0", VA = "0x182BFE5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static RISVPEMNZVA EPRPHPBGLAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCF00", Offset = "0x2BFB900", VA = "0x182BFCF00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static RISVPEMNZVA CXSXVNSZQQU
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC4F0", Offset = "0x2BFAEF0", VA = "0x182BFC4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static RISVPEMNZVA JWWSXQYRZAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BFACF0", Offset = "0x2BF96F0", VA = "0x182BFACF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static RISVPEMNZVA RTBUVOAHUFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC250", Offset = "0x2BFAC50", VA = "0x182BFC250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static RISVPEMNZVA ENEHHODPECK
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC370", Offset = "0x2BFAD70", VA = "0x182BFC370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static RISVPEMNZVA QRJVHAUSVAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCC30", Offset = "0x2BFB630", VA = "0x182BFCC30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static RISVPEMNZVA GIVNJUZVFXD
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB610", Offset = "0x2BFA010", VA = "0x182BFB610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static RISVPEMNZVA TPRPNWFISDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCAF0", Offset = "0x2BFB4F0", VA = "0x182BFCAF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static RISVPEMNZVA QHOYMOXOTNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDE30", Offset = "0x2BFC830", VA = "0x182BFDE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static RISVPEMNZVA EDVINZSADBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDA30", Offset = "0x2BFC430", VA = "0x182BFDA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static RISVPEMNZVA CETFOZZJGZW
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD860", Offset = "0x2BFC260", VA = "0x182BFD860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static RISVPEMNZVA CIKNGUVQVRB
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB3D0", Offset = "0x2BF9DD0", VA = "0x182BFB3D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static RISVPEMNZVA XXKXKCIKSCS
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD970", Offset = "0x2BFC370", VA = "0x182BFD970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static RISVPEMNZVA VDNYIXXNSCP
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAD50", Offset = "0x2BF9750", VA = "0x182BFAD50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static RISVPEMNZVA XMHSUZMZEUH
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB920", Offset = "0x2BFA320", VA = "0x182BFB920")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static RISVPEMNZVA LIHEREQORTZ
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE650", Offset = "0x2BFD050", VA = "0x182BFE650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static RISVPEMNZVA DHXPDZIBUYB
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB430", Offset = "0x2BF9E30", VA = "0x182BFB430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static RISVPEMNZVA TEMHGXNVASC
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAA00", Offset = "0x2BF9400", VA = "0x182BFAA00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static RISVPEMNZVA MFKFDXVLGTN
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE540", Offset = "0x2BFCF40", VA = "0x182BFE540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static RISVPEMNZVA DBHJVCAPSNC
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDF50", Offset = "0x2BFC950", VA = "0x182BFDF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static RISVPEMNZVA WMQSQLBZVCY
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA3D0", Offset = "0x2BF8DD0", VA = "0x182BFA3D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static RISVPEMNZVA KDKMNWDVMUJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDEF0", Offset = "0x2BFC8F0", VA = "0x182BFDEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static RISVPEMNZVA YKRWQFYINIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDB50", Offset = "0x2BFC550", VA = "0x182BFDB50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static RISVPEMNZVA THOHXJRTBEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE6B0", Offset = "0x2BFD0B0", VA = "0x182BFE6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static RISVPEMNZVA PUWNZRCULUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD9D0", Offset = "0x2BFC3D0", VA = "0x182BFD9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static RISVPEMNZVA NSWTDEQRKLT
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAE70", Offset = "0x2BF9870", VA = "0x182BFAE70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static RISVPEMNZVA SCVECDSRHIR
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB670", Offset = "0x2BFA070", VA = "0x182BFB670")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static RISVPEMNZVA DNLMSKOUBOM
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC430", Offset = "0x2BFAE30", VA = "0x182BFC430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static RISVPEMNZVA QAZOVGNPADW
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAED0", Offset = "0x2BF98D0", VA = "0x182BFAED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static RISVPEMNZVA GHQFBVZRESA
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCA30", Offset = "0x2BFB430", VA = "0x182BFCA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static RISVPEMNZVA RQTSIMSQLDP
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB4F0", Offset = "0x2BF9EF0", VA = "0x182BFB4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static RISVPEMNZVA CFJTXEYHTBK
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA4F0", Offset = "0x2BF8EF0", VA = "0x182BFA4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static RISVPEMNZVA HVCVFSLCIHW
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA9A0", Offset = "0x2BF93A0", VA = "0x182BFA9A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static RISVPEMNZVA UEPPJPYFOND
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB5B0", Offset = "0x2BF9FB0", VA = "0x182BFB5B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static RISVPEMNZVA OBEIXSDHORF
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD020", Offset = "0x2BFBA20", VA = "0x182BFD020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static RISVPEMNZVA TLEUQTDLQGO
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE150", Offset = "0x2BFCB50", VA = "0x182BFE150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static RISVPEMNZVA WHVBQRMHWMZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAF80", Offset = "0x2BF9980", VA = "0x182BFAF80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static RISVPEMNZVA KDQJXZISLVN
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB490", Offset = "0x2BF9E90", VA = "0x182BFB490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static RISVPEMNZVA ITXDIDSXQIY
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB310", Offset = "0x2BF9D10", VA = "0x182BFB310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static RISVPEMNZVA JEWXAJIVKLC
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDCB0", Offset = "0x2BFC6B0", VA = "0x182BFDCB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static RISVPEMNZVA TGNRBAOZLBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE210", Offset = "0x2BFCC10", VA = "0x182BFE210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static RISVPEMNZVA NVAGLWBRFGW
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA6F0", Offset = "0x2BF90F0", VA = "0x182BFA6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static RISVPEMNZVA FPNEVLSMWMP
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE1B0", Offset = "0x2BFCBB0", VA = "0x182BFE1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static RISVPEMNZVA FSWZHKOMJML
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFADB0", Offset = "0x2BF97B0", VA = "0x182BFADB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static RISVPEMNZVA YHZLBUCUCAT
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBCB0", Offset = "0x2BFA6B0", VA = "0x182BFBCB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static RISVPEMNZVA BTORKPILLPN
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBA90", Offset = "0x2BFA490", VA = "0x182BFBA90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static RISVPEMNZVA TEQDASSSQHZ
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD800", Offset = "0x2BFC200", VA = "0x182BFD800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static RISVPEMNZVA SAKJSAQVEFI
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA5A0", Offset = "0x2BF8FA0", VA = "0x182BFA5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static RISVPEMNZVA HFFEJBJIHRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCBD0", Offset = "0x2BFB5D0", VA = "0x182BFCBD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static RISVPEMNZVA YNFSWGDTEUI
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC550", Offset = "0x2BFAF50", VA = "0x182BFC550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static RISVPEMNZVA LKDCWIXYBYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBD10", Offset = "0x2BFA710", VA = "0x182BFBD10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static RISVPEMNZVA QSZAZWUYVNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC1F0", Offset = "0x2BFABF0", VA = "0x182BFC1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static RISVPEMNZVA OSOFIWONMOZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BFD420", Offset = "0x2BFBE20", VA = "0x182BFD420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static RISVPEMNZVA NWKNTFOWOLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCA90", Offset = "0x2BFB490", VA = "0x182BFCA90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static RISVPEMNZVA VMPDVZQFJLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB6D0", Offset = "0x2BFA0D0", VA = "0x182BFB6D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static RISVPEMNZVA YSZIXTAVXOX
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB370", Offset = "0x2BF9D70", VA = "0x182BFB370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static RISVPEMNZVA VKTVINMAYGO
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBDA0", Offset = "0x2BFA7A0", VA = "0x182BFBDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static RISVPEMNZVA CXEUINRFHTR
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA940", Offset = "0x2BF9340", VA = "0x182BFA940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static RISVPEMNZVA IYPOQFDCVHN
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC940", Offset = "0x2BFB340", VA = "0x182BFC940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static RISVPEMNZVA OTOVIYEAWIL
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBEB0", Offset = "0x2BFA8B0", VA = "0x182BFBEB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static RISVPEMNZVA JMXBAVRDDVK
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA600", Offset = "0x2BF9000", VA = "0x182BFA600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static RISVPEMNZVA KURVJHACWLV
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB730", Offset = "0x2BFA130", VA = "0x182BFB730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static RISVPEMNZVA RZGRNLIWHSR
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE0F0", Offset = "0x2BFCAF0", VA = "0x182BFE0F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static RISVPEMNZVA RABQZVIUUDS
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE270", Offset = "0x2BFCC70", VA = "0x182BFE270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static RISVPEMNZVA UVNEZQZWBJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCC90", Offset = "0x2BFB690", VA = "0x182BFCC90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static RISVPEMNZVA PBZGIRARBMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BFAC00", Offset = "0x2BF9600", VA = "0x182BFAC00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static RISVPEMNZVA GOAZQSUSFHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB250", Offset = "0x2BF9C50", VA = "0x182BFB250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static RISVPEMNZVA RADMOSXRRUB
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA430", Offset = "0x2BF8E30", VA = "0x182BFA430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static RISVPEMNZVA DOISXYOWFKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCE40", Offset = "0x2BFB840", VA = "0x182BFCE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static RISVPEMNZVA ASURXTZZAXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BFE360", Offset = "0x2BFCD60", VA = "0x182BFE360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static RISVPEMNZVA TLEYLQXZCAD
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB2B0", Offset = "0x2BF9CB0", VA = "0x182BFB2B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static RISVPEMNZVA EDCNWMYHEWA
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BFC2B0", Offset = "0x2BFACB0", VA = "0x182BFC2B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static RISVPEMNZVA LYKIIOJKGDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCEA0", Offset = "0x2BFB8A0", VA = "0x182BFCEA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static RISVPEMNZVA FNEEFWQDVVF
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BFDA90", Offset = "0x2BFC490", VA = "0x182BFDA90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static RISVPEMNZVA POLUAWBSGGB
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BFB0A0", Offset = "0x2BF9AA0", VA = "0x182BFB0A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static RISVPEMNZVA DXHOMULAALZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2BFBE00", Offset = "0x2BFA800", VA = "0x182BFBE00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static RISVPEMNZVA OPSNJPZUVNX
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA490", Offset = "0x2BF8E90", VA = "0x182BFA490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static RISVPEMNZVA LSDSGITMCTQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2BFCF60", Offset = "0x2BFB960", VA = "0x182BFCF60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BFDFB0", Offset = "0x2BFC9B0", VA = "0x182BFDFB0")]
			public static ZGFIKLGOGCU WQOOMKEGKIM([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BFE460", Offset = "0x2BFCE60", VA = "0x182BFE460")]
			public static ClassFactoryTypeParams YOFHDCJNYOV(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BFE510", Offset = "0x2BFCF10", VA = "0x182BFE510")]
			public static ClassFactoryTypeParams YOFHDCJNYOV([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BFBD70", Offset = "0x2BFA770", VA = "0x182BFBD70")]
			public static ZGFIKLGOGCU MXKNGNLRNGW(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BFA660", Offset = "0x2BF9060", VA = "0x182BFA660")]
			public static ZGFIKLGOGCU BAFOGRIEVRB(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BFB790", Offset = "0x2BFA190", VA = "0x182BFB790")]
			public static ZGFIKLGOGCU KGXWHTEVKQP([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BFC5B0", Offset = "0x2BFAFB0", VA = "0x182BFC5B0")]
			public static HZZYFIUKWAB OYLEEPLCWKB(Id32<JCARNWHFFIV> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BFCB50", Offset = "0x2BFB550", VA = "0x182BFCB50")]
			public static string PKHYIYFBVVQ(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BFC660", Offset = "0x2BFB060", VA = "0x182BFC660")]
			private static HZZYFIUKWAB OYLEEPLCWKB(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BFBB40", Offset = "0x2BFA540", VA = "0x182BFBB40")]
			public static Id32<JCARNWHFFIV>? LVIDSAQSCSI(HZZYFIUKWAB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BFD480", Offset = "0x2BFBE80", VA = "0x182BFD480")]
			public static CircuitTypeIdWrapper? SGWSVHICRRF(HZZYFIUKWAB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BFE710", Offset = "0x2BFD110", VA = "0x182BFE710")]
			static TIACULCJKOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BFBBB0", Offset = "0x2BFA5B0", VA = "0x182BFBBB0")]
			[IteratorStateMachine(typeof(FHLWNMNAOUE))]
			private static IEnumerable<HZZYFIUKWAB> LYYCNUPDMNL(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BFAA60", Offset = "0x2BF9460", VA = "0x182BFAA60")]
			[IteratorStateMachine(typeof(IZVACLPPQSG))]
			public static IEnumerable<HZZYFIUKWAB> DXEIZTFRPOM(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BFD0E0", Offset = "0x2BFBAE0", VA = "0x182BFD0E0")]
			public static Variant ROXPXDYCAEZ(HZZYFIUKWAB a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BFBF10", Offset = "0x2BFA910", VA = "0x182BFBF10")]
			public static Variant NJNKGRWTZIM(HZZYFIUKWAB a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BFA750", Offset = "0x2BF9150", VA = "0x182BFA750")]
			public static bool BTHFFKZXEFS(HZZYFIUKWAB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BFB980", Offset = "0x2BFA380", VA = "0x182BFB980")]
			[IteratorStateMachine(typeof(TZMNXHJLZWT))]
			public static IEnumerable<Id32<JCARNWHFFIV>> KWFTECCNKWW(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PFSZXMKIYFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0190", Offset = "0x2BEEB90", VA = "0x182BF0190")]
		public static DUIDTXDHPIF NZJDRENIZKU(this HZZYFIUKWAB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF620", Offset = "0x2BEE020", VA = "0x182BEF620")]
		public static HZZYFIUKWAB IVDFFFMFEGJ(this DUIDTXDHPIF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MGRJEPUSBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C37A20", Offset = "0x3C36420", VA = "0x183C37A20")]
		public static Dictionary<b, c> NOARGJZHHSF<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class DOSQJAEJUAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8D40", Offset = "0x2BE7740", VA = "0x182BE8D40")]
		public static UBFNGIGUBTN NZJDRENIZKU([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8CA0", Offset = "0x2BE76A0", VA = "0x182BE8CA0")]
		public static Guid IVDFFFMFEGJ(UBFNGIGUBTN a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class ERBWJSPLRXC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9550", Offset = "0x2BE7F50", VA = "0x182BE9550")]
		public static RIIPNWKDAJZ NZJDRENIZKU([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BE94F0", Offset = "0x2BE7EF0", VA = "0x182BE94F0")]
		public static NamedType IVDFFFMFEGJ(this RIIPNWKDAJZ a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class CIELGNPIHYV
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x381DA40", Offset = "0x381C440", VA = "0x18381DA40")]
		public static void YEZMFCLDVEZ<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x381DCA0", Offset = "0x381C6A0", VA = "0x18381DCA0")]
		public static void YEZMFCLDVEZ<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class RPUTMSACDXO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BF9E90", Offset = "0x2BF8890", VA = "0x182BF9E90")]
		public static MFITZWJKJNB NZJDRENIZKU([In] this Variant self, HZZYFIUKWAB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF9D40", Offset = "0x2BF8740", VA = "0x182BF9D40")]
		public static Variant IVDFFFMFEGJ(this MFITZWJKJNB a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class REXOEQAKHRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<REYKDUXIDCS> JHEVEMOUEOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool XIAKAEOOAJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool ZQJBOIODYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool MLHFKQIUDWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool KYZYSYPEGJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool KZPTKSWWIRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool RMYGBUUEWGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool ZRURNMFWNAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool GLBUAIBKHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, HZZYFIUKWAB Type)> HEBPJSOJGAY;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid JQHSIUZOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2BACD00", Offset = "0x2BAB700", VA = "0x182BACD00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<REYKDUXIDCS> WVBBLDDLGRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2BACD00", Offset = "0x2BAB700", VA = "0x182BACD00")]
			get
			{
				return default(Id128<REYKDUXIDCS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, HZZYFIUKWAB Type)> QYWTVARFQAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action TORCMEDDYHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9640", Offset = "0x2BF8040", VA = "0x182BF9640")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BF94F0", Offset = "0x2BF7EF0", VA = "0x182BF94F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, HZZYFIUKWAB> GGVCSITEMSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9280", Offset = "0x2BF7C80", VA = "0x182BF9280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BF8A40", Offset = "0x2BF7440", VA = "0x182BF8A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> KJYJDELYIIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BF87A0", Offset = "0x2BF71A0", VA = "0x182BF87A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9330", Offset = "0x2BF7D30", VA = "0x182BF9330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> KXFPADSRFNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9590", Offset = "0x2BF7F90", VA = "0x182BF9590")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BF90B0", Offset = "0x2BF7AB0", VA = "0x182BF90B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, HZZYFIUKWAB> DOINLUANSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BF8AF0", Offset = "0x2BF74F0", VA = "0x182BF8AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9000", Offset = "0x2BF7A00", VA = "0x182BF9000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ULBGVPGYJGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BF8700", Offset = "0x2BF7100", VA = "0x182BF8700")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BF97D0", Offset = "0x2BF81D0", VA = "0x182BF97D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B5B3F0", Offset = "0x1B59DF0", VA = "0x181B5B3F0")]
		public void CWYSBGYEUZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BF9870", Offset = "0x2BF8270", VA = "0x182BF9870")]
		internal REXOEQAKHRQ([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, HZZYFIUKWAB Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8C00", Offset = "0x2BF7600", VA = "0x182BF8C00")]
		public static CircuitEventDefinitionFactoryStart JPMHDBJTTOT(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8CD0", Offset = "0x2BF76D0", VA = "0x182BF8CD0")]
		public static CircuitEventDefinitionFactoryStart JPMHDBJTTOT(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BF93E0", Offset = "0x2BF7DE0", VA = "0x182BF93E0")]
		public static REXOEQAKHRQ VREYZNWIXGR([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8DC0", Offset = "0x2BF77C0", VA = "0x182BF8DC0")]
		public static REXOEQAKHRQ KVLENWEENIL([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF35AA0", Offset = "0xF344A0", VA = "0x180F35AA0")]
		public void PHBLDKVIFQZ(Id128<REYKDUXIDCS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8BA0", Offset = "0x2BF75A0", VA = "0x182BF8BA0")]
		public void EWSGAFPWJNC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BF96E0", Offset = "0x2BF80E0", VA = "0x182BF96E0")]
		public void YCSFBGNLHVO(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8950", Offset = "0x2BF7350", VA = "0x182BF8950")]
		public void DBTLCBWBDDN(int a, HZZYFIUKWAB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BF9160", Offset = "0x2BF7B60", VA = "0x182BF9160")]
		public void NNODNEDSHOV(string a, HZZYFIUKWAB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8D50", Offset = "0x2BF7750", VA = "0x182BF8D50")]
		public void KPORCVCYAYS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8850", Offset = "0x2BF7250", VA = "0x182BF8850")]
		public REXOEQAKHRQ Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2BE7770", Offset = "0x2BE6170", VA = "0x182BE7770")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE74D0", Offset = "0x2BE5ED0", VA = "0x182BE74D0")]
		public CircuitEventDefinitionFactoryParams CQXSGLNLFEL(string a, HZZYFIUKWAB b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7640", Offset = "0x2BE6040", VA = "0x182BE7640")]
		public REXOEQAKHRQ FHFBFMADOYL()
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
		private readonly List<(string Name, HZZYFIUKWAB Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7440", Offset = "0x2BE5E40", VA = "0x182BE7440")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, HZZYFIUKWAB Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7210", Offset = "0x2BE5C10", VA = "0x182BE7210")]
		public CircuitEventDefinitionFactoryParams CQXSGLNLFEL(string a, HZZYFIUKWAB b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7340", Offset = "0x2BE5D40", VA = "0x182BE7340")]
		public REXOEQAKHRQ FHFBFMADOYL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class KXKHJEHFQBN
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly REXOEQAKHRQ IPKWHFOKOBM;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly REXOEQAKHRQ HXXUGZZLKIR;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly REXOEQAKHRQ DMPMBEEKLWM;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly REXOEQAKHRQ IFICQCYCPDT;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly REXOEQAKHRQ MDTZGMSMAUG;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly REXOEQAKHRQ PBDSMEIFMTS;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly REXOEQAKHRQ GKKXZPBJOOT;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly REXOEQAKHRQ[] NUQMUBWLHSY;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class NZIMLRHCFBU
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly REXOEQAKHRQ GHVFFTHWGQS;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class PVMLEKFQDGV
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly REXOEQAKHRQ JAMFPIQHOAC;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly REXOEQAKHRQ UFUTHIPWOET;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class BLUOIEMRZWU
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly REXOEQAKHRQ LGRAGAVXYIX;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly REXOEQAKHRQ JNPHGDRWBQK;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly REXOEQAKHRQ[] SOFQYJKTMNM;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly REXOEQAKHRQ WOEHDVIHTJQ;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly REXOEQAKHRQ IAIWJZWEGIL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class XVFMFKYYQVG
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly REXOEQAKHRQ CAVYXKGDGFB;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly REXOEQAKHRQ CCDPNARSAFE;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class EEFUPDCBUBH
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly REXOEQAKHRQ SQSBBWKNUCG;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly REXOEQAKHRQ OGTCFPYEOKF;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class SZCAIWRCWDI
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly REXOEQAKHRQ JAMFPIQHOAC;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly REXOEQAKHRQ UFUTHIPWOET;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class BFBNDCWABVC
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly REXOEQAKHRQ QWCHYYYJRPX;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly REXOEQAKHRQ PFOUJKYRMFA;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly REXOEQAKHRQ ODWWZVGFUSU;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly REXOEQAKHRQ OOOBTRZJQXM;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly REXOEQAKHRQ JCJMKSHPZXH;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly REXOEQAKHRQ RAQTSUWJDPE;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly REXOEQAKHRQ DHGVVETCDJN;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class BGIKCSISCEU
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class NAYWSHPVHIM
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class ZLXUTATRVNC
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RGLRJUAQAUE
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly REXOEQAKHRQ GAPFPEGVUKF;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly REXOEQAKHRQ IYEFJSHCUEG;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class XZSWCTETITU
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class OBZULDAZYKW
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class ZEPDXURYGIW
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class LGVPGNQXKER
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly REXOEQAKHRQ WKQRWTIJGBD;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly REXOEQAKHRQ XYLUZTMKQJR;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly REXOEQAKHRQ BSJKXIGJVNK;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly REXOEQAKHRQ KGNLDTLQFBH;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly REXOEQAKHRQ UZGCBVQFRIL;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly REXOEQAKHRQ SQSBBWKNUCG;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly REXOEQAKHRQ PWFLMJGXSEX;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly REXOEQAKHRQ TXCRXPSNEVS;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly REXOEQAKHRQ MLUNMVUMOGC;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly REXOEQAKHRQ JXZNWDLJSLE;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly REXOEQAKHRQ HQWDVMDIKWQ;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly REXOEQAKHRQ ZYPPKZFFNDE;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly REXOEQAKHRQ DLGPAKNEUIB;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly REXOEQAKHRQ XFKSQBFNIOU;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly REXOEQAKHRQ TPOBNMXBWOH;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly REXOEQAKHRQ RRVAZIFOPRR;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly REXOEQAKHRQ XJYVJKRIWKN;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly REXOEQAKHRQ FLXTICNHHFM;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly REXOEQAKHRQ ALYCAKPNRMX;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly REXOEQAKHRQ YMZDKEKJGFX;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly REXOEQAKHRQ OTWLZOWKFPG;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly REXOEQAKHRQ HFFFMHPSXVS;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly REXOEQAKHRQ ERUBDDYWXYG;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly REXOEQAKHRQ HQGESGKZGUK;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly REXOEQAKHRQ FMRHKPBJXRI;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly REXOEQAKHRQ UZJTAAHHPWW;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly REXOEQAKHRQ KFDKYBDHIOY;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly REXOEQAKHRQ CYZFEJADEKA;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly REXOEQAKHRQ NLAOPZJUCMF;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly REXOEQAKHRQ MHHBTVQRGDD;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly REXOEQAKHRQ CNAVFJWICFS;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly REXOEQAKHRQ GBYHQCTPVWE;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly REXOEQAKHRQ XQAVEHHBWMB;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly REXOEQAKHRQ QONRHPJWUXD;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly REXOEQAKHRQ ZEDBGYSZSYF;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly REXOEQAKHRQ GVFETSGEYVP;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly REXOEQAKHRQ HFEQNVFCFXT;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly REXOEQAKHRQ IVGHMWRLXOP;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly REXOEQAKHRQ VEOIWCDSKGL;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly REXOEQAKHRQ QURHTOBHNNV;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly REXOEQAKHRQ PJGRSTWIXKO;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly REXOEQAKHRQ TRNNQNRDSRW;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly REXOEQAKHRQ METNCGQEUUG;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly REXOEQAKHRQ FSFAZPZSRTE;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly REXOEQAKHRQ KOMDBCIWCXA;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly REXOEQAKHRQ LAXPGLWIQLY;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly REXOEQAKHRQ QIXUKJCFADO;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly REXOEQAKHRQ ZTOVFOAIOSA;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly REXOEQAKHRQ SMSDNNVEJMI;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly REXOEQAKHRQ AMCRKGVKBWS;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly REXOEQAKHRQ FQXJXSLQJLH;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly REXOEQAKHRQ SAWHBXWSLQG;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly REXOEQAKHRQ LQCEYRMJLBO;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly REXOEQAKHRQ FIPECMRQNWW;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly REXOEQAKHRQ RAKQDLWMGHE;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly REXOEQAKHRQ DWPTMQEEXJE;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly REXOEQAKHRQ IMUNYQHQOXE;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly REXOEQAKHRQ EOAVEIKVFRU;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly REXOEQAKHRQ WDNKGQMDBCQ;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly REXOEQAKHRQ DLRQJBTNGTK;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly REXOEQAKHRQ TXBNWBCUSXS;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly REXOEQAKHRQ LWNHONQCEXQ;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly REXOEQAKHRQ ZZLYVWZHUBH;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly REXOEQAKHRQ YHXUFGCFSJU;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly REXOEQAKHRQ PLWTHZVXKQO;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly REXOEQAKHRQ ZACKVNLCUIR;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly REXOEQAKHRQ OUCBRSDOKOD;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly REXOEQAKHRQ HBDVABEUAWI;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly REXOEQAKHRQ CTLMXTRXMXA;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class QLQVVUYIFWZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class BIKHLSWVAWA
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly REXOEQAKHRQ TMSBSDYRUSO;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly REXOEQAKHRQ GWNPMQTOERN;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly REXOEQAKHRQ WLCQZPLEYVV;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly REXOEQAKHRQ LRSOORZDDIE;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly REXOEQAKHRQ RSMNRELRIPO;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly REXOEQAKHRQ KUYCAEXUOLE;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly REXOEQAKHRQ GZYEJNVEIHW;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class BVQSTPRLIWF
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly REXOEQAKHRQ XYLUZTMKQJR;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly REXOEQAKHRQ BSJKXIGJVNK;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly REXOEQAKHRQ KGNLDTLQFBH;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly REXOEQAKHRQ FXBHBNKYTZP;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly REXOEQAKHRQ NHKTMZTWRPX;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly REXOEQAKHRQ LERPGJDPQMN;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly REXOEQAKHRQ BHVLUSXFETR;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class DIINNIASTGR
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly REXOEQAKHRQ FBXTQLXDBBB;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly REXOEQAKHRQ KCVZOPOMIMP;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly REXOEQAKHRQ IGTFASFBBKY;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly REXOEQAKHRQ RTDKQITEJBO;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly REXOEQAKHRQ HIOQPRDVLXC;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly REXOEQAKHRQ AIPCHGGLCZE;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class WZXBEETFVFY
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class NJFZSFHMCFT
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly REXOEQAKHRQ BAJOJJQEGHB;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class LEHVLCPMPPN
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly REXOEQAKHRQ WKQRWTIJGBD;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class TIRRHUZECGQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class MZRBBDWLEBB
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class NOHLEQGKOSI
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly REXOEQAKHRQ QHJHURCOUHO;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly REXOEQAKHRQ HYRRMQUFWOC;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly REXOEQAKHRQ AWCRSQXMXJL;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly REXOEQAKHRQ AISRJAIZKAF;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class DJJMMMFEJYO
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly REXOEQAKHRQ RZYJHBMXSPB;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly REXOEQAKHRQ XDXLEMFXYMM;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class KXVYIYPSJHM
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class GNMFIILYURA
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly REXOEQAKHRQ TMSBSDYRUSO;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly REXOEQAKHRQ GWNPMQTOERN;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class QVKLQZAOPJR
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly REXOEQAKHRQ QWMDABYPACQ;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly REXOEQAKHRQ LRSOORZDDIE;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly REXOEQAKHRQ RSMNRELRIPO;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly REXOEQAKHRQ KUYCAEXUOLE;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly REXOEQAKHRQ JJSKYERPMYJ;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly REXOEQAKHRQ FBVTOJAOTRM;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly REXOEQAKHRQ WJTNADGJBHQ;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly REXOEQAKHRQ YRSNXXYLYHS;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly REXOEQAKHRQ LGOKKRIYXEJ;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly REXOEQAKHRQ XCZXVAFSLVT;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly REXOEQAKHRQ TMSBSDYRUSO;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly REXOEQAKHRQ GWNPMQTOERN;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class RREQIGPEWLT
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class IKWOEUGZXXR
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly REXOEQAKHRQ TMSBSDYRUSO;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly REXOEQAKHRQ GWNPMQTOERN;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly REXOEQAKHRQ ODDWUKHYUOJ;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly REXOEQAKHRQ DKFGVMAJOER;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly REXOEQAKHRQ CPNPCMUBNRO;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class QSJAHLNLSJI
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class UWEPORWTSSR
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly REXOEQAKHRQ VREDHIPTANE;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class SKRMUVCTVBL
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly REXOEQAKHRQ OZXUNFAEHXF;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly REXOEQAKHRQ TWYZKVRPKVA;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly REXOEQAKHRQ TMSBSDYRUSO;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly REXOEQAKHRQ GWNPMQTOERN;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class DYGPTPZMQGQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class KECHXRKNGGM
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class PNXLRNAPJXH
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class VGNEYLSXWCF
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class ZGOWNRLUXJS
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class VRPFQIVBLAU
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly REXOEQAKHRQ GAPFPEGVUKF;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly REXOEQAKHRQ IYEFJSHCUEG;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class XXKECEKNXDW
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly REXOEQAKHRQ CPSPYSWXWMP;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly REXOEQAKHRQ TBHORBFRSRP;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly REXOEQAKHRQ WMWYAIOYWBZ;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly REXOEQAKHRQ YPIVPTDGJEF;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class WSQCKEMEEAF
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly REXOEQAKHRQ CPSPYSWXWMP;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly REXOEQAKHRQ TBHORBFRSRP;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly REXOEQAKHRQ WMWYAIOYWBZ;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly REXOEQAKHRQ YPIVPTDGJEF;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class UFFJMNUCWRO
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class IHFGWKXCSLT
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly REXOEQAKHRQ MMENMYMHWZE;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly REXOEQAKHRQ QPOAVMTSXRQ;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly REXOEQAKHRQ IQPBHXMTWBU;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class GEAEUSBPTII
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly REXOEQAKHRQ IWVGKRISLOP;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly REXOEQAKHRQ SJIGQAGGMKF;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly REXOEQAKHRQ OVBYMSKMDIG;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class CMMCNXGFHFZ
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class WWDLUXOQYQW
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly REXOEQAKHRQ UGWVGYXYGIK;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly REXOEQAKHRQ DMKTDUSANIY;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly REXOEQAKHRQ LPOBAPGICEH;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly REXOEQAKHRQ FCYFSPJSEYX;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly REXOEQAKHRQ XZHWJYURSSO;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class DNBHSWLIWHT
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly REXOEQAKHRQ SFUQAMDKMAW;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class FFQBSOKKLZP
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly REXOEQAKHRQ QNAJDFROVEL;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly REXOEQAKHRQ DJVGQHCWMFK;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly REXOEQAKHRQ MHSMGQOVTVV;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class IIRREPAGTGK
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class GORYCIQLHZG
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class NZZJLXOWMEL
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class KSGJJZFQKRC
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly REXOEQAKHRQ CLMKDSVPNLH;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly REXOEQAKHRQ GJPGYRIZMYW;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly REXOEQAKHRQ SMNZNHLAFCI;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly REXOEQAKHRQ CQZUIELGSIU;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly REXOEQAKHRQ XIUIDRIWQNB;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly REXOEQAKHRQ EZORCRWGBOR;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly REXOEQAKHRQ EAWFVZIKQGO;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class KBHRYKQLGMY
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly REXOEQAKHRQ IABRZKQCNDJ;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly REXOEQAKHRQ[] USEWHVWKZZN;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class IDURWQFXNFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly HZZYFIUKWAB QTLGNUNSRCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<REXOEQAKHRQ> XQAYEVBKXFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<REXOEQAKHRQ> JFKCXNODSMI;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<REXOEQAKHRQ> NFEHLEVVTIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<REXOEQAKHRQ> DVHJUNHIYKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D600", Offset = "0x2C0C000", VA = "0x182C0D600")]
		protected IDURWQFXNFK(HZZYFIUKWAB a, params REXOEQAKHRQ[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class BNEWNZOBVMM : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2C080D0", Offset = "0x2C06AD0", VA = "0x182C080D0")]
		internal BNEWNZOBVMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class XHGCVKHBVWV : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2C16F40", Offset = "0x2C15940", VA = "0x182C16F40")]
		internal XHGCVKHBVWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class APFAHRJMERG : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2C07210", Offset = "0x2C05C10", VA = "0x182C07210")]
		internal APFAHRJMERG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class KZXMOXLXGLL : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FEA0", Offset = "0x2C0E8A0", VA = "0x182C0FEA0")]
		internal KZXMOXLXGLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MJOHFLROALA : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2C109A0", Offset = "0x2C0F3A0", VA = "0x182C109A0")]
		internal MJOHFLROALA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class IDQWAIBBWLE : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D420", Offset = "0x2C0BE20", VA = "0x182C0D420")]
		internal IDQWAIBBWLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class CRZRRSTCURT : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2C09E70", Offset = "0x2C08870", VA = "0x182C09E70")]
		internal CRZRRSTCURT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class HDDSRXSZHTS : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D060", Offset = "0x2C0BA60", VA = "0x182C0D060")]
		internal HDDSRXSZHTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class BKLDKFUCXKO : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2C07EF0", Offset = "0x2C068F0", VA = "0x182C07EF0")]
		internal BKLDKFUCXKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class BRBPQDVIDNE : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2C08490", Offset = "0x2C06E90", VA = "0x182C08490")]
		internal BRBPQDVIDNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class NJQDHSUCBMK : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2C11220", Offset = "0x2C0FC20", VA = "0x182C11220")]
		internal NJQDHSUCBMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class LYXWBTSDLIS : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2C10400", Offset = "0x2C0EE00", VA = "0x182C10400")]
		internal LYXWBTSDLIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class BRPANTEZZWS : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2C08670", Offset = "0x2C07070", VA = "0x182C08670")]
		internal BRPANTEZZWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class JHMNWHYOUJY : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2C0EA80", Offset = "0x2C0D480", VA = "0x182C0EA80")]
		internal JHMNWHYOUJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ZXDERJLREEY : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2C18120", Offset = "0x2C16B20", VA = "0x182C18120")]
		internal ZXDERJLREEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZJPKNJKUVUE : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2C17F40", Offset = "0x2C16940", VA = "0x182C17F40")]
		internal ZJPKNJKUVUE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class BOWAKTGPRSU : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2C082B0", Offset = "0x2C06CB0", VA = "0x182C082B0")]
		internal BOWAKTGPRSU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class YJZSRYBODEJ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2C17B90", Offset = "0x2C16590", VA = "0x182C17B90")]
		internal YJZSRYBODEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class NLHJABSXTZV : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2C11400", Offset = "0x2C0FE00", VA = "0x182C11400")]
		internal NLHJABSXTZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class BFEJLATPCKX : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2C073F0", Offset = "0x2C05DF0", VA = "0x182C073F0")]
		internal BFEJLATPCKX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class KZGLWCUCEJD : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FC40", Offset = "0x2C0E640", VA = "0x182C0FC40")]
		internal KZGLWCUCEJD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class IPWUFUUXZEJ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E820", Offset = "0x2C0D220", VA = "0x182C0E820")]
		internal IPWUFUUXZEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class UOIWEZLPEGO : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2C14CA0", Offset = "0x2C136A0", VA = "0x182C14CA0")]
		internal UOIWEZLPEGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class YFMJZHSNNUL : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2C179B0", Offset = "0x2C163B0", VA = "0x182C179B0")]
		internal YFMJZHSNNUL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ILDXPFYFIGI : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E460", Offset = "0x2C0CE60", VA = "0x182C0E460")]
		internal ILDXPFYFIGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MKFSQNZWVZJ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2C10B80", Offset = "0x2C0F580", VA = "0x182C10B80")]
		internal MKFSQNZWVZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class KSXZPCYDONH : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F9F0", Offset = "0x2C0E3F0", VA = "0x182C0F9F0")]
		internal KSXZPCYDONH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LUIABETROVR : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2C10220", Offset = "0x2C0EC20", VA = "0x182C10220")]
		internal LUIABETROVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ZZIIIDIBCGW : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2C18560", Offset = "0x2C16F60", VA = "0x182C18560")]
		internal ZZIIIDIBCGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class UIUSVHOMGYX : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2C14AC0", Offset = "0x2C134C0", VA = "0x182C14AC0")]
		internal UIUSVHOMGYX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class QXJVRFMBKBY : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2C13D30", Offset = "0x2C12730", VA = "0x182C13D30")]
		internal QXJVRFMBKBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class JLDKCDNSGYI : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2C0EB60", Offset = "0x2C0D560", VA = "0x182C0EB60")]
		internal JLDKCDNSGYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class VBVIEZOLLSU : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2C15140", Offset = "0x2C13B40", VA = "0x182C15140")]
		internal VBVIEZOLLSU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XPFPNYFORCD : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2C170A0", Offset = "0x2C15AA0", VA = "0x182C170A0")]
		internal XPFPNYFORCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class QKJGUPJBZHL : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2C12B30", Offset = "0x2C11530", VA = "0x182C12B30")]
		internal QKJGUPJBZHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class CVEFTIYGXCX : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A050", Offset = "0x2C08A50", VA = "0x182C0A050")]
		internal CVEFTIYGXCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class AKEPUQAUEZG : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2C07030", Offset = "0x2C05A30", VA = "0x182C07030")]
		internal AKEPUQAUEZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class PQIPXXNOUMJ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2C12510", Offset = "0x2C10F10", VA = "0x182C12510")]
		internal PQIPXXNOUMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ESUTPNSXBUB : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B650", Offset = "0x2C0A050", VA = "0x182C0B650")]
		internal ESUTPNSXBUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class FLBUFDGCOAC : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2C0BF00", Offset = "0x2C0A900", VA = "0x182C0BF00")]
		internal FLBUFDGCOAC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class DEYUVVYOTMW : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A2B0", Offset = "0x2C08CB0", VA = "0x182C0A2B0")]
		internal DEYUVVYOTMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class HOFWZYJKVFI : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D240", Offset = "0x2C0BC40", VA = "0x182C0D240")]
		internal HOFWZYJKVFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class WZKIEEXUBIZ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2C16C80", Offset = "0x2C15680", VA = "0x182C16C80")]
		internal WZKIEEXUBIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ODREBPBIIBD : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2C12160", Offset = "0x2C10B60", VA = "0x182C12160")]
		internal ODREBPBIIBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class MSZAEQZWXFA : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2C10D60", Offset = "0x2C0F760", VA = "0x182C10D60")]
		internal MSZAEQZWXFA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CMEJOQNPZBF : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2C09C20", Offset = "0x2C08620", VA = "0x182C09C20")]
		internal CMEJOQNPZBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class KLFGCZTTGYO : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F3E0", Offset = "0x2C0DDE0", VA = "0x182C0F3E0")]
		internal KLFGCZTTGYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MERZWOYRBLX : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2C105E0", Offset = "0x2C0EFE0", VA = "0x182C105E0")]
		internal MERZWOYRBLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MGOFAEEEDNP : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2C107C0", Offset = "0x2C0F1C0", VA = "0x182C107C0")]
		internal MGOFAEEEDNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class JOIAIOFPSGK : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2C0ED40", Offset = "0x2C0D740", VA = "0x182C0ED40")]
		internal JOIAIOFPSGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class IMTLSWTUNGA : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E640", Offset = "0x2C0D040", VA = "0x182C0E640")]
		internal IMTLSWTUNGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class QMFDRAOBCZJ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2C12D80", Offset = "0x2C11780", VA = "0x182C12D80")]
		internal QMFDRAOBCZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class EYUSWPGHSMY : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B8B0", Offset = "0x2C0A2B0", VA = "0x182C0B8B0")]
		internal EYUSWPGHSMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class QCDNLEIHTEZ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2C12770", Offset = "0x2C11170", VA = "0x182C12770")]
		internal QCDNLEIHTEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class QGYAGZUIVCZ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2C12950", Offset = "0x2C11350", VA = "0x182C12950")]
		internal QGYAGZUIVCZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class EDCUHRFZUHZ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B470", Offset = "0x2C09E70", VA = "0x182C0B470")]
		internal EDCUHRFZUHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SIKIJIRYCQF : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2C13FF0", Offset = "0x2C129F0", VA = "0x182C13FF0")]
		internal SIKIJIRYCQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class VZCDTAXIJPG : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2C15A50", Offset = "0x2C14450", VA = "0x182C15A50")]
		internal VZCDTAXIJPG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class JPKJPZVRMJB : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2C0EF20", Offset = "0x2C0D920", VA = "0x182C0EF20")]
		internal JPKJPZVRMJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class SPGOFJGXIRZ : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2C14790", Offset = "0x2C13190", VA = "0x182C14790")]
		internal SPGOFJGXIRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class VDTNTVZGQYG : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2C15320", Offset = "0x2C13D20", VA = "0x182C15320")]
		internal VDTNTVZGQYG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class ZGUEEWBSOIT : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2C17DE0", Offset = "0x2C167E0", VA = "0x182C17DE0")]
		internal ZGUEEWBSOIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class VSJPVWNMLIG : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2C158F0", Offset = "0x2C142F0", VA = "0x182C158F0")]
		internal VSJPVWNMLIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class PMGPNXFFFIR : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2C12340", Offset = "0x2C10D40", VA = "0x182C12340")]
		internal PMGPNXFFFIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class ZZCSNHBAFUL : IDURWQFXNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2C18300", Offset = "0x2C16D00", VA = "0x182C18300")]
		internal ZZCSNHBAFUL()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, SCCEHWEFPHH<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly HZZYFIUKWAB Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
		private NamedType(string name, HZZYFIUKWAB type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B43710", Offset = "0x2B42110", VA = "0x182B43710")]
		public static NamedType New(string name, HZZYFIUKWAB type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2C11FA0", Offset = "0x2C109A0", VA = "0x182C11FA0")]
		public static bool SHHUBVCQRYC([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2C11FA0", Offset = "0x2C109A0", VA = "0x182C11FA0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2C11FA0", Offset = "0x2C109A0", VA = "0x182C11FA0")]
		public bool XNDJLZYNOLK([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2C11EE0", Offset = "0x2C108E0", VA = "0x182C11EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2C11FF0", Offset = "0x2C109F0", VA = "0x182C11FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2C120E0", Offset = "0x2C10AE0", VA = "0x182C120E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2C12120", Offset = "0x2C10B20", VA = "0x182C12120")]
		public string ZOVQKDIHFBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2C12060", Offset = "0x2C10A60", VA = "0x182C12060")]
		public string QYLRGJOEKPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2C11FA0", Offset = "0x2C109A0", VA = "0x182C11FA0", Slot = "5")]
		private bool HNYAJAPIZFX([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface WNWYUXAFTQH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, LSNRXVKTUTI>> ETHZSTORPJA(PZJVNVFLVDC a, bool b);
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
