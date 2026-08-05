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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB4490", Offset = "0x2BB3490", VA = "0x182BB4490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB4110", Offset = "0x2BB3110", VA = "0x182BB4110", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class LZVBYCDVABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3F40", Offset = "0x2BB2F40", VA = "0x182BB3F40")]
		public static bool JPFAQQCSJYW(this WQEPJKQGFSY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4050", Offset = "0x2BB3050", VA = "0x182BB4050")]
		public static bool JPFAQQCSJYW(this BJFMTOGABRB a)
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
			private readonly RJNEMTAVLYW _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
			public EVRequest(RJNEMTAVLYW staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class RUWYFQDGUVL
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<BHLGGWPOINQ>, WLENECQMNLF> ZIFOQYWQOJE;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<BHLGGWPOINQ>>? OWXMEYQIPHI;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<BHLGGWPOINQ> XMYJAHCPVKU;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<BHLGGWPOINQ> YYVETXBMQGB;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<BHLGGWPOINQ> TRIUFHQFJSA;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<BHLGGWPOINQ> PMPORIPQZJP;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<BHLGGWPOINQ> PHDWMWYYMJA;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<BHLGGWPOINQ> JVONYRQMRCJ;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<BHLGGWPOINQ> XLEZALLKFEN;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<BHLGGWPOINQ> XNDNAGVSYIZ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<BHLGGWPOINQ> WNWSXIHAOJH;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<BHLGGWPOINQ> KCHXCZXLRPX;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<BHLGGWPOINQ> RVDVQGGKSHX;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<BHLGGWPOINQ> QMFILSIFLML;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<BHLGGWPOINQ> WZYHUKQTKAS;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<BHLGGWPOINQ> PKPKLFOKNWS;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<BHLGGWPOINQ> KGRTHFLEIIE;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<BHLGGWPOINQ> BUSCSPFRZTZ;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<BHLGGWPOINQ> OTBWENMHKRA;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<BHLGGWPOINQ> QMFBIDACCZK;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<BHLGGWPOINQ> RSGJXLWWDOL;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<BHLGGWPOINQ> ZDJNWCUFRJC;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<BHLGGWPOINQ> BJKOISGXZMT;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<BHLGGWPOINQ> LWKDBZGYJCM;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<BHLGGWPOINQ> NWHWILLENOI;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<BHLGGWPOINQ> JLPYWPDOLGD;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<BHLGGWPOINQ> ZIAPPNHEXTZ;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<BHLGGWPOINQ> EAJNNTWWGAK;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<BHLGGWPOINQ> LYEWUGZQHUZ;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<BHLGGWPOINQ> USALMBAFQKO;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<BHLGGWPOINQ> DZXVQRAXFRI;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<BHLGGWPOINQ> INREKUADFPO;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<BHLGGWPOINQ> YDSHJMRHZLM;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<BHLGGWPOINQ> RFAKIKWRPKT;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<BHLGGWPOINQ> VOBHLNXMGNW;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<BHLGGWPOINQ> IHGTCTYHXWA;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<BHLGGWPOINQ> JNYQUAWKMUO;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<BHLGGWPOINQ> TDWHRDWWUPJ;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<BHLGGWPOINQ> YDYRWDDTMMM;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<BHLGGWPOINQ> CRBNITHASIJ;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<BHLGGWPOINQ> RPMEJCBFRPP;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<BHLGGWPOINQ> AHRYERCIKUH;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<BHLGGWPOINQ> ISHKZMINKDO;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<BHLGGWPOINQ> SOMZHDPOACY;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<BHLGGWPOINQ> MEMIWCVGZYJ;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<BHLGGWPOINQ> SHKOULKFYFW;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<BHLGGWPOINQ> JMKLSNNFUAW;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<BHLGGWPOINQ> DPUEBPKFGCE;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<BHLGGWPOINQ> HXYMVAVOGZX;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<BHLGGWPOINQ> GFFRRJSWUYB;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<BHLGGWPOINQ> DFLVKIKNNKV;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<BHLGGWPOINQ> FXCDBCBKVSQ;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<BHLGGWPOINQ> XWVYTOWGNBK;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<BHLGGWPOINQ> RRPGLYKODXL;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<BHLGGWPOINQ> RNNPSVNULKO;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<BHLGGWPOINQ> RCHKHPJYQMU;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<BHLGGWPOINQ> LPUDTKKGLVV;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<BHLGGWPOINQ> IEPJKPIRVTV;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<BHLGGWPOINQ> YCBTRHMBNDV;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<BHLGGWPOINQ> BIUQIBSGIZR;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<BHLGGWPOINQ> VOSMBCWLAKG;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<BHLGGWPOINQ> IPEUIFEYDRP;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<BHLGGWPOINQ> BWPJJXCUYEL;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<BHLGGWPOINQ> HQWEKASKZKF;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<BHLGGWPOINQ> IGTCTAGPEOG;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<BHLGGWPOINQ> SLFYDFBSXSQ;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<BHLGGWPOINQ> WQYXEAIQYAP;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<BHLGGWPOINQ> DRLRSECROWU;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<BHLGGWPOINQ> ZQAADGCQBNP;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<BHLGGWPOINQ>, WLENECQMNLF> MAWOOXGRYBT
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD0D0", Offset = "0x2BBC0D0", VA = "0x182BBD0D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD380", Offset = "0x2BBC380", VA = "0x182BBD380")]
			public static WLENECQMNLF KUWRZZTANGP(Id32<BHLGGWPOINQ> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD120", Offset = "0x2BBC120", VA = "0x182BBD120")]
			public static bool BEFEHQHLCFK(Id32<BHLGGWPOINQ> id, [Out] WLENECQMNLF a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD400", Offset = "0x2BBC400", VA = "0x182BBD400")]
			public static WQEPJKQGFSY RBXAVQLIADM(Id32<BHLGGWPOINQ> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD4B0", Offset = "0x2BBC4B0", VA = "0x182BBD4B0")]
			private static Id32<BHLGGWPOINQ> YTBQRMTMKZK(WLENECQMNLF a, Id32<BHLGGWPOINQ> id)
			{
				return default(Id32<BHLGGWPOINQ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD1B0", Offset = "0x2BBC1B0", VA = "0x182BBD1B0")]
			private static void BPIUMNYKTHI(Id32<BHLGGWPOINQ> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class YKMDACTLEVA
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				private IdUnsafeList<OEYGGGUNRJW, WQEPJKQGFSY?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x137A110", Offset = "0x1379110", VA = "0x18137A110")]
				private TypeRegistryFactory([In] IdUnsafeList<OEYGGGUNRJW, WQEPJKQGFSY?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0C50", Offset = "0x2BBFC50", VA = "0x182BC0C50")]
				public static TypeRegistryFactory PZMODGNNSPE()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0CB0", Offset = "0x2BBFCB0", VA = "0x182BC0CB0")]
				public (ReadOnlyIdArray<OEYGGGUNRJW, WQEPJKQGFSY>, IReadOnlyDictionary<WQEPJKQGFSY, Id32<OEYGGGUNRJW>>) YTBFAQLEKEG()
				{
					return default((ReadOnlyIdArray<OEYGGGUNRJW, WQEPJKQGFSY>, IReadOnlyDictionary<WQEPJKQGFSY, Id32<OEYGGGUNRJW>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0AD0", Offset = "0x2BBFAD0", VA = "0x182BC0AD0")]
				public Id32<OEYGGGUNRJW> PUQOTGBFXJS(int a, WQEPJKQGFSY b)
				{
					return default(Id32<OEYGGGUNRJW>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0A80", Offset = "0x2BBFA80", VA = "0x182BC0A80")]
				public Id32<OEYGGGUNRJW> Initialize(int id, FOFXJJFKGMD type, FOFXJJFKGMD factoryType)
				{
					return default(Id32<OEYGGGUNRJW>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class MNVSMFWJZUR
			{
				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Id32<OEYGGGUNRJW> TMAFCVMCAKW
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4450", Offset = "0x2BB3450", VA = "0x182BB4450")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4310", Offset = "0x2BB3310", VA = "0x182BB4310")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Id32<OEYGGGUNRJW> NAFTNBFOZPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x2BB41D0", Offset = "0x2BB31D0", VA = "0x182BB41D0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4250", Offset = "0x2BB3250", VA = "0x182BB4250")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Id32<OEYGGGUNRJW> HMWJLQTULAL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BB42D0", Offset = "0x2BB32D0", VA = "0x182BB42D0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BB43D0", Offset = "0x2BB33D0", VA = "0x182BB43D0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<OEYGGGUNRJW> RBYUPHDJJHF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4210", Offset = "0x2BB3210", VA = "0x182BB4210")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4290", Offset = "0x2BB3290", VA = "0x182BB4290")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<OEYGGGUNRJW> YGBMOZODUWP
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4190", Offset = "0x2BB3190", VA = "0x182BB4190")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4390", Offset = "0x2BB3390", VA = "0x182BB4390")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<OEYGGGUNRJW> YATXYPRRJLY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4350", Offset = "0x2BB3350", VA = "0x182BB4350")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BB4410", Offset = "0x2BB3410", VA = "0x182BB4410")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class ZLDIEHJWHGW : IEnumerable<WQEPJKQGFSY>, IEnumerable, IEnumerator<WQEPJKQGFSY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				private int WDQRLRKBTGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				private WQEPJKQGFSY IGHQXRUYHSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int FMHFHEECSRO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private bool UDAFUQOOFOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public bool QJDWRCDMFPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private RoomVersion BEQNOAYWAVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public RoomVersion BEWOYJQMNYT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private bool YMIRWMTOZTX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public bool PJANZTIPSUE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private bool AJWBVDXATVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public bool WALSBRXQNEQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private bool VPZKZKNRZCZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public bool KWLPEZQQTVW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				private bool CJZCJBNTPED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public bool YNMUUOBSMEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				private IEnumerator<WQEPJKQGFSY> WEJFWHVNYIV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private WQEPJKQGFSY VFWZXBCLTOC;

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				private WQEPJKQGFSY ZAZVRDGODYX
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				private object UQAIKHVHSEP
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
				[DebuggerHidden]
				public ZLDIEHJWHGW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDF30", Offset = "0x2BCCF30", VA = "0x182BCDF30", Slot = "7")]
				[DebuggerHidden]
				private void PRJHWGPKORK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDB40", Offset = "0x2BCCB40", VA = "0x182BCDB40", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDFC0", Offset = "0x2BCCFC0", VA = "0x182BCDFC0")]
				private void ZLAPFDWYPLY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDA40", Offset = "0x2BCCA40", VA = "0x182BCDA40", Slot = "10")]
				[DebuggerHidden]
				private void HJPFLPVTXYN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDA80", Offset = "0x2BCCA80", VA = "0x182BCDA80", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<WQEPJKQGFSY> HMALCIUZJLK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDA80", Offset = "0x2BCCA80", VA = "0x182BCDA80", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator JZJZEHYLQOE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class DQUUVKEVYNU : IEnumerable<WQEPJKQGFSY>, IEnumerable, IEnumerator<WQEPJKQGFSY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				private int WDQRLRKBTGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private WQEPJKQGFSY IGHQXRUYHSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				private int FMHFHEECSRO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private RoomVersion BEQNOAYWAVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public RoomVersion BEWOYJQMNYT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private bool AJWBVDXATVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public bool WALSBRXQNEQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private bool YMIRWMTOZTX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				public bool PJANZTIPSUE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				private bool GIYFCYRGYIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public bool KSQPDQOPEZU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				private bool VPZKZKNRZCZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public bool KWLPEZQQTVW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private bool OTMAHANDEYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool HUYAWMUVMEZ;

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				private WQEPJKQGFSY ZAZVRDGODYX
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private object UQAIKHVHSEP
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
				[DebuggerHidden]
				public DQUUVKEVYNU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
				[DebuggerHidden]
				private void PRJHWGPKORK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BAF360", Offset = "0x2BAE360", VA = "0x182BAF360", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x2BAF270", Offset = "0x2BAE270", VA = "0x182BAF270", Slot = "10")]
				[DebuggerHidden]
				private void HJPFLPVTXYN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x2BAF2B0", Offset = "0x2BAE2B0", VA = "0x182BAF2B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<WQEPJKQGFSY> HMALCIUZJLK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BAF2B0", Offset = "0x2BAE2B0", VA = "0x182BAF2B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator JZJZEHYLQOE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class WDDMNCTCPGC : IEnumerable<Id32<OEYGGGUNRJW>>, IEnumerable, IEnumerator<Id32<OEYGGGUNRJW>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				private int WDQRLRKBTGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private Id32<OEYGGGUNRJW> IGHQXRUYHSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				private int FMHFHEECSRO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private RoomVersion BEQNOAYWAVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public RoomVersion BEWOYJQMNYT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private bool YMIRWMTOZTX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public bool PJANZTIPSUE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private bool AJWBVDXATVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public bool WALSBRXQNEQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private bool VPZKZKNRZCZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public bool KWLPEZQQTVW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private bool CJZCJBNTPED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public bool YNMUUOBSMEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				private IEnumerator<WQEPJKQGFSY> WEJFWHVNYIV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private IEnumerator<FOFXJJFKGMD> WDTLENNVWAU;

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private Id32<OEYGGGUNRJW> IDQDNJMHOPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xC5B060", Offset = "0xC5A060", VA = "0x180C5B060", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<OEYGGGUNRJW>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private object UQAIKHVHSEP
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x2BC1CA0", Offset = "0x2BC0CA0", VA = "0x182BC1CA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x16507C0", Offset = "0x164F7C0", VA = "0x1816507C0")]
				[DebuggerHidden]
				public WDDMNCTCPGC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BC1B50", Offset = "0x2BC0B50", VA = "0x182BC1B50", Slot = "7")]
				[DebuggerHidden]
				private void PRJHWGPKORK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BC1650", Offset = "0x2BC0650", VA = "0x182BC1650", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x2BC1D40", Offset = "0x2BC0D40", VA = "0x182BC1D40")]
				private void ZLAPFDWYPLY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BC1CF0", Offset = "0x2BC0CF0", VA = "0x182BC1CF0")]
				private void ZKVIHXDBGAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BC1560", Offset = "0x2BC0560", VA = "0x182BC1560", Slot = "10")]
				[DebuggerHidden]
				private void HJPFLPVTXYN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x2BC15A0", Offset = "0x2BC05A0", VA = "0x182BC15A0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<OEYGGGUNRJW>> HSOSDJWAZYD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BC15A0", Offset = "0x2BC05A0", VA = "0x182BC15A0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator JZJZEHYLQOE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private static readonly Log BMHSVNOOAKJ;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private static ReadOnlyIdArray<OEYGGGUNRJW, WQEPJKQGFSY?> TIBHYUHJUEB;

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static IReadOnlyDictionary<WQEPJKQGFSY, Id32<OEYGGGUNRJW>> HZRYQVQMGRT;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly BJFMTOGABRB HEQSACELRKU;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly BJFMTOGABRB RBXBXUFXMNQ;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static readonly HashSet<WQEPJKQGFSY> DJXMCTOYGNW;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static List<WQEPJKQGFSY> JTGFLVOHEPB;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet EBITQPFCMEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet HSFJGDSRBTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet MWKCZBIYGBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static WQEPJKQGFSY TMAFCVMCAKW
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6630", Offset = "0x2BC5630", VA = "0x182BC6630")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static WQEPJKQGFSY NAFTNBFOZPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4120", Offset = "0x2BC3120", VA = "0x182BC4120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static WQEPJKQGFSY HMWJLQTULAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4BF0", Offset = "0x2BC3BF0", VA = "0x182BC4BF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static WQEPJKQGFSY RBYUPHDJJHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4750", Offset = "0x2BC3750", VA = "0x182BC4750")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static WQEPJKQGFSY XBSLOEMLHJZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5A80", Offset = "0x2BC4A80", VA = "0x182BC5A80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static WQEPJKQGFSY AMHJZCVIYXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4A40", Offset = "0x2BC3A40", VA = "0x182BC4A40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static WQEPJKQGFSY MSDNPNGKEUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BC36A0", Offset = "0x2BC26A0", VA = "0x182BC36A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static WQEPJKQGFSY YGBMOZODUWP
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2760", Offset = "0x2BC1760", VA = "0x182BC2760")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static FOFXJJFKGMD TBNAUIJUMMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BC48A0", Offset = "0x2BC38A0", VA = "0x182BC48A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static FOFXJJFKGMD FJXCDWCMOBI
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BC38B0", Offset = "0x2BC28B0", VA = "0x182BC38B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static FOFXJJFKGMD YDNIECJINSR
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5A30", Offset = "0x2BC4A30", VA = "0x182BC5A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static FOFXJJFKGMD XXEJCVDMUSV
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3D70", Offset = "0x2BC2D70", VA = "0x182BC3D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static FOFXJJFKGMD FSDVUUYUHAJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5F40", Offset = "0x2BC4F40", VA = "0x182BC5F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static FOFXJJFKGMD GHMEPMWPPPU
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5E30", Offset = "0x2BC4E30", VA = "0x182BC5E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static FOFXJJFKGMD PUJXGYZZQFK
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3530", Offset = "0x2BC2530", VA = "0x182BC3530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static FOFXJJFKGMD QYTKMDECZFI
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4E00", Offset = "0x2BC3E00", VA = "0x182BC4E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static FOFXJJFKGMD EOLKCRDRVER
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5420", Offset = "0x2BC4420", VA = "0x182BC5420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static FOFXJJFKGMD GWDRRIWSXEZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5680", Offset = "0x2BC4680", VA = "0x182BC5680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static FOFXJJFKGMD XGUKDARWUNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3CC0", Offset = "0x2BC2CC0", VA = "0x182BC3CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static FOFXJJFKGMD APIQWYGFLUK
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BC67D0", Offset = "0x2BC57D0", VA = "0x182BC67D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static FOFXJJFKGMD WUBWKCXYHDW
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6460", Offset = "0x2BC5460", VA = "0x182BC6460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static FOFXJJFKGMD FFNVKSADHRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5620", Offset = "0x2BC4620", VA = "0x182BC5620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static FOFXJJFKGMD FMEMHKQDNQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4840", Offset = "0x2BC3840", VA = "0x182BC4840")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static FOFXJJFKGMD REIDCTDHQNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3060", Offset = "0x2BC2060", VA = "0x182BC3060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static FOFXJJFKGMD QJODQJRPLBW
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5CB0", Offset = "0x2BC4CB0", VA = "0x182BC5CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static FOFXJJFKGMD LPLSEGLJJPY
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BC49E0", Offset = "0x2BC39E0", VA = "0x182BC49E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static FOFXJJFKGMD DMSNIMLUFTO
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4000", Offset = "0x2BC3000", VA = "0x182BC4000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static FOFXJJFKGMD ZFWLFABUFWV
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3E20", Offset = "0x2BC2E20", VA = "0x182BC3E20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static FOFXJJFKGMD RRSMMXUFEII
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC58B0", Offset = "0x2BC48B0", VA = "0x182BC58B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static FOFXJJFKGMD IZFFQCRXMDU
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2850", Offset = "0x2BC1850", VA = "0x182BC2850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static FOFXJJFKGMD JDNYUNPMIUK
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3A80", Offset = "0x2BC2A80", VA = "0x182BC3A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static FOFXJJFKGMD PMUUHOAFPGG
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3580", Offset = "0x2BC2580", VA = "0x182BC3580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static FOFXJJFKGMD FMKWUEUWKOB
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC57F0", Offset = "0x2BC47F0", VA = "0x182BC57F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static FOFXJJFKGMD TVCJVKJZPLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6880", Offset = "0x2BC5880", VA = "0x182BC6880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static FOFXJJFKGMD BYZLMAQCALW
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3850", Offset = "0x2BC2850", VA = "0x182BC3850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static FOFXJJFKGMD BNZJHRZDFHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BC35E0", Offset = "0x2BC25E0", VA = "0x182BC35E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static FOFXJJFKGMD JTQHIUTNIAT
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BC51E0", Offset = "0x2BC41E0", VA = "0x182BC51E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static FOFXJJFKGMD TYNLRNMZNZV
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BC54E0", Offset = "0x2BC44E0", VA = "0x182BC54E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static FOFXJJFKGMD VHGCTMYHQJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3FA0", Offset = "0x2BC2FA0", VA = "0x182BC3FA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static FOFXJJFKGMD MURZBBKMIFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2B20", Offset = "0x2BC1B20", VA = "0x182BC2B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static FOFXJJFKGMD CKPVFWETSLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3E80", Offset = "0x2BC2E80", VA = "0x182BC3E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static FOFXJJFKGMD IJGGQPUYLRH
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4690", Offset = "0x2BC3690", VA = "0x182BC4690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static FOFXJJFKGMD IARILCYTEEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BC66C0", Offset = "0x2BC56C0", VA = "0x182BC66C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static FOFXJJFKGMD KDZMKJUUIGB
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5970", Offset = "0x2BC4970", VA = "0x182BC5970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static FOFXJJFKGMD BTMNUIYRGAE
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2BE0", Offset = "0x2BC1BE0", VA = "0x182BC2BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static FOFXJJFKGMD SMNXPCDDBMW
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5300", Offset = "0x2BC4300", VA = "0x182BC5300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static FOFXJJFKGMD NWUBTDVGAYX
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6940", Offset = "0x2BC5940", VA = "0x182BC6940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static FOFXJJFKGMD ZIGXXMPDGNZ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6400", Offset = "0x2BC5400", VA = "0x182BC6400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static FOFXJJFKGMD NBVBPWSHVDF
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3C00", Offset = "0x2BC2C00", VA = "0x182BC3C00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static FOFXJJFKGMD SENRBXEEGPT
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4DA0", Offset = "0x2BC3DA0", VA = "0x182BC4DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static FOFXJJFKGMD XXIJOQGEFPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BC64B0", Offset = "0x2BC54B0", VA = "0x182BC64B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static FOFXJJFKGMD UYLEQUUFYTI
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3120", Offset = "0x2BC2120", VA = "0x182BC3120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static FOFXJJFKGMD EHBVDTLSFQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BC56D0", Offset = "0x2BC46D0", VA = "0x182BC56D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static FOFXJJFKGMD HIUALTIZXVV
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BC29A0", Offset = "0x2BC19A0", VA = "0x182BC29A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static FOFXJJFKGMD PUIOPBOGNOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3640", Offset = "0x2BC2640", VA = "0x182BC3640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static FOFXJJFKGMD GSVPKIMVJEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BC53C0", Offset = "0x2BC43C0", VA = "0x182BC53C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static FOFXJJFKGMD MLAQJKNAOWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3DC0", Offset = "0x2BC2DC0", VA = "0x182BC3DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static FOFXJJFKGMD FPLPTVHDAMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2B80", Offset = "0x2BC1B80", VA = "0x182BC2B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static FOFXJJFKGMD QNCGBCHFPGP
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3960", Offset = "0x2BC2960", VA = "0x182BC3960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static FOFXJJFKGMD ABQGVAZVXKY
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4C80", Offset = "0x2BC3C80", VA = "0x182BC4C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static FOFXJJFKGMD WVGIGKNZMNF
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3AE0", Offset = "0x2BC2AE0", VA = "0x182BC3AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static FOFXJJFKGMD EIHRSVDYKVY
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2CA0", Offset = "0x2BC1CA0", VA = "0x182BC2CA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static FOFXJJFKGMD WTICZJJWSJQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3470", Offset = "0x2BC2470", VA = "0x182BC3470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static FOFXJJFKGMD MTJHSYRHLWY
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC37F0", Offset = "0x2BC27F0", VA = "0x182BC37F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static FOFXJJFKGMD VDMQEPYUOPC
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6570", Offset = "0x2BC5570", VA = "0x182BC6570")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static FOFXJJFKGMD UJORZISLONZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3410", Offset = "0x2BC2410", VA = "0x182BC3410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static FOFXJJFKGMD TQWVOUGVPLW
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BC46F0", Offset = "0x2BC36F0", VA = "0x182BC46F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static FOFXJJFKGMD MIQTBDLLLKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4950", Offset = "0x2BC3950", VA = "0x182BC4950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static FOFXJJFKGMD XKXFESAEOGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6820", Offset = "0x2BC5820", VA = "0x182BC6820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static FOFXJJFKGMD QWTRNBOWOGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2700", Offset = "0x2BC1700", VA = "0x182BC2700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static FOFXJJFKGMD RBRKGHGHDMT
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3900", Offset = "0x2BC2900", VA = "0x182BC3900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static FOFXJJFKGMD EDVFAJKVPQL
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3F40", Offset = "0x2BC2F40", VA = "0x182BC3F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static FOFXJJFKGMD VOOFCWPWRTI
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BC27F0", Offset = "0x2BC17F0", VA = "0x182BC27F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static FOFXJJFKGMD FHQYHYTZLCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BC65D0", Offset = "0x2BC55D0", VA = "0x182BC65D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static FOFXJJFKGMD XJKXNOPRECI
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5240", Offset = "0x2BC4240", VA = "0x182BC5240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static FOFXJJFKGMD DOYTWRQOLIH
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5790", Offset = "0x2BC4790", VA = "0x182BC5790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static FOFXJJFKGMD GIFICVWUCNL
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3EE0", Offset = "0x2BC2EE0", VA = "0x182BC3EE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static FOFXJJFKGMD ARAIIFFKTXP
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC30C0", Offset = "0x2BC20C0", VA = "0x182BC30C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static FOFXJJFKGMD RWNQGZJTPXY
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5DD0", Offset = "0x2BC4DD0", VA = "0x182BC5DD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static FOFXJJFKGMD MFSEOHRFPJL
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC42C0", Offset = "0x2BC32C0", VA = "0x182BC42C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static FOFXJJFKGMD WSUQHDOGZXH
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4B90", Offset = "0x2BC3B90", VA = "0x182BC4B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static FOFXJJFKGMD NNVRFXHYRCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5910", Offset = "0x2BC4910", VA = "0x182BC5910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static FOFXJJFKGMD LPTZENQFXGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5730", Offset = "0x2BC4730", VA = "0x182BC5730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static FOFXJJFKGMD JYFUDMWHTXJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3C60", Offset = "0x2BC2C60", VA = "0x182BC3C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static FOFXJJFKGMD TAIWBNRJKFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5850", Offset = "0x2BC4850", VA = "0x182BC5850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static FOFXJJFKGMD UNBCTCWHHGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5B70", Offset = "0x2BC4B70", VA = "0x182BC5B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static FOFXJJFKGMD ISEYPJOKJJX
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3D10", Offset = "0x2BC2D10", VA = "0x182BC3D10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static FOFXJJFKGMD MQUOCWOQLZZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5E80", Offset = "0x2BC4E80", VA = "0x182BC5E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static FOFXJJFKGMD ZKDJCOXHCCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2A00", Offset = "0x2BC1A00", VA = "0x182BC2A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static FOFXJJFKGMD OGFFBNNYEOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5B10", Offset = "0x2BC4B10", VA = "0x182BC5B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static FOFXJJFKGMD RVPNYQUXRQU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BC41B0", Offset = "0x2BC31B0", VA = "0x182BC41B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static FOFXJJFKGMD ZFPOOENONKM
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3240", Offset = "0x2BC2240", VA = "0x182BC3240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static FOFXJJFKGMD MDLGAAUKRPY
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC52A0", Offset = "0x2BC42A0", VA = "0x182BC52A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static FOFXJJFKGMD HRYQZDZZLOO
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC59D0", Offset = "0x2BC49D0", VA = "0x182BC59D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static FOFXJJFKGMD LQVAADDFOEY
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3BA0", Offset = "0x2BC2BA0", VA = "0x182BC3BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static FOFXJJFKGMD SLFILMZWRPZ
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC34D0", Offset = "0x2BC24D0", VA = "0x182BC34D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static FOFXJJFKGMD LEKHGLMOQJG
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2AC0", Offset = "0x2BC1AC0", VA = "0x182BC2AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static FOFXJJFKGMD OQPQMTGIKNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BC39C0", Offset = "0x2BC29C0", VA = "0x182BC39C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static FOFXJJFKGMD SJNLZQGUCIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BC47E0", Offset = "0x2BC37E0", VA = "0x182BC47E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static FOFXJJFKGMD JGTPSZXCHDX
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BC32A0", Offset = "0x2BC22A0", VA = "0x182BC32A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static FOFXJJFKGMD EPWKIZSVVUM
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2A60", Offset = "0x2BC1A60", VA = "0x182BC2A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static FOFXJJFKGMD EMAPKRNLUCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5F90", Offset = "0x2BC4F90", VA = "0x182BC5F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static FOFXJJFKGMD UZWDRFZQTPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3A20", Offset = "0x2BC2A20", VA = "0x182BC3A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static FOFXJJFKGMD CSTTLDBERKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4060", Offset = "0x2BC3060", VA = "0x182BC4060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static FOFXJJFKGMD SDRSCAHZEOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4CE0", Offset = "0x2BC3CE0", VA = "0x182BC4CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static FOFXJJFKGMD KFFLJTEPQHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BC2C40", Offset = "0x2BC1C40", VA = "0x182BC2C40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static FOFXJJFKGMD RLIUQUMQMBO
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4AD0", Offset = "0x2BC3AD0", VA = "0x182BC4AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static FOFXJJFKGMD GUNRLNJUMVO
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC33B0", Offset = "0x2BC23B0", VA = "0x182BC33B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static FOFXJJFKGMD CCXJETRPDVP
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5D10", Offset = "0x2BC4D10", VA = "0x182BC5D10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static FOFXJJFKGMD DTNKHBYPMXW
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3730", Offset = "0x2BC2730", VA = "0x182BC3730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static FOFXJJFKGMD HJJFZDMKNRC
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC31E0", Offset = "0x2BC21E0", VA = "0x182BC31E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static FOFXJJFKGMD ZHOZLCFSBIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC48F0", Offset = "0x2BC38F0", VA = "0x182BC48F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static FOFXJJFKGMD BFUQLSEFCWA
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5EE0", Offset = "0x2BC4EE0", VA = "0x182BC5EE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static FOFXJJFKGMD RDDAOYHILZV
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4D40", Offset = "0x2BC3D40", VA = "0x182BC4D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static FOFXJJFKGMD MAYGEIFJNDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5D70", Offset = "0x2BC4D70", VA = "0x182BC5D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static FOFXJJFKGMD QBALIXYRDWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BC55C0", Offset = "0x2BC45C0", VA = "0x182BC55C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static FOFXJJFKGMD ISLCCXZWAIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BC68E0", Offset = "0x2BC58E0", VA = "0x182BC68E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static FOFXJJFKGMD GZAJLHLKAMZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3790", Offset = "0x2BC2790", VA = "0x182BC3790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static FOFXJJFKGMD UXUHVWDEYQG
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BC4B30", Offset = "0x2BC3B30", VA = "0x182BC4B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static FOFXJJFKGMD QJEYPCRUINX
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BC40C0", Offset = "0x2BC30C0", VA = "0x182BC40C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static FOFXJJFKGMD WNPXUFVQARR
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6510", Offset = "0x2BC5510", VA = "0x182BC6510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static FOFXJJFKGMD FGGTMBBHQKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BC5360", Offset = "0x2BC4360", VA = "0x182BC5360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static FOFXJJFKGMD NAGILCDNWGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3B40", Offset = "0x2BC2B40", VA = "0x182BC3B40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static FOFXJJFKGMD FYQAFILZSEU
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3180", Offset = "0x2BC2180", VA = "0x182BC3180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BC28B0", Offset = "0x2BC18B0", VA = "0x182BC28B0")]
			public static BJFMTOGABRB BEWQRMWIDDV([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5C00", Offset = "0x2BC4C00", VA = "0x182BC5C00")]
			public static ClassFactoryTypeParams VOXJFTVGVIC(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5BD0", Offset = "0x2BC4BD0", VA = "0x182BC5BD0")]
			public static ClassFactoryTypeParams VOXJFTVGVIC([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BC49B0", Offset = "0x2BC39B0", VA = "0x182BC49B0")]
			public static BJFMTOGABRB OKOXOJWXUNT(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BC63D0", Offset = "0x2BC53D0", VA = "0x182BC63D0")]
			public static BJFMTOGABRB YBSZCQGLXCY(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BC62A0", Offset = "0x2BC52A0", VA = "0x182BC62A0")]
			public static BJFMTOGABRB YATXYPRRJLY([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5130", Offset = "0x2BC4130", VA = "0x182BC5130")]
			public static WQEPJKQGFSY RBXAVQLIADM(Id32<OEYGGGUNRJW> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5540", Offset = "0x2BC4540", VA = "0x182BC5540")]
			public static string SXEYXASIJMV(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4E50", Offset = "0x2BC3E50", VA = "0x182BC4E50")]
			private static WQEPJKQGFSY RBXAVQLIADM(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5470", Offset = "0x2BC4470", VA = "0x182BC5470")]
			public static Id32<OEYGGGUNRJW>? SRRNQNYZRWX(WQEPJKQGFSY a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4320", Offset = "0x2BC3320", VA = "0x182BC4320")]
			public static CircuitTypeIdWrapper? LREUHZSJGYG(WQEPJKQGFSY a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC69A0", Offset = "0x2BC59A0", VA = "0x182BC69A0")]
			static YKMDACTLEVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC6720", Offset = "0x2BC5720", VA = "0x182BC6720")]
			[IteratorStateMachine(typeof(DQUUVKEVYNU))]
			private static IEnumerable<WQEPJKQGFSY> ZKDKAVPOBLM(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4210", Offset = "0x2BC3210", VA = "0x182BC4210")]
			[IteratorStateMachine(typeof(ZLDIEHJWHGW))]
			public static IEnumerable<WQEPJKQGFSY> LDFUGRVSNJZ(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5FF0", Offset = "0x2BC4FF0", VA = "0x182BC5FF0")]
			public static Variant YAPLECBOCUU(WQEPJKQGFSY a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2D00", Offset = "0x2BC1D00", VA = "0x182BC2D00")]
			public static Variant DAEWYHEYBJH(WQEPJKQGFSY a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2FE0", Offset = "0x2BC1FE0", VA = "0x182BC2FE0")]
			public static bool DIKEQBCTQKD(WQEPJKQGFSY a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3300", Offset = "0x2BC2300", VA = "0x182BC3300")]
			[IteratorStateMachine(typeof(WDDMNCTCPGC))]
			public static IEnumerable<Id32<OEYGGGUNRJW>> EEXMMFNGRLT(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class HKRMEJFBSYV
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1D10", Offset = "0x2BB0D10", VA = "0x182BB1D10")]
		public static AYRADHZSZFS LDGVYQLXUAF(this WQEPJKQGFSY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BB11A0", Offset = "0x2BB01A0", VA = "0x182BB11A0")]
		public static WQEPJKQGFSY FESOWVBASTG(this AYRADHZSZFS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MKEWYZRVYZM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D810", Offset = "0x3A9C810", VA = "0x183A9D810")]
		public static Dictionary<b, c> SJUFJMCASZO<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class JDUQJNECQBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3740", Offset = "0x2BB2740", VA = "0x182BB3740")]
		public static QGIJEKZPIMI LDGVYQLXUAF([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BB36A0", Offset = "0x2BB26A0", VA = "0x182BB36A0")]
		public static Guid FESOWVBASTG(QGIJEKZPIMI a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class IRPCGZHTOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3610", Offset = "0x2BB2610", VA = "0x182BB3610")]
		public static OSUAGEAHOVY LDGVYQLXUAF([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BB35B0", Offset = "0x2BB25B0", VA = "0x182BB35B0")]
		public static NamedType FESOWVBASTG(this OSUAGEAHOVY a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class XSKVPECHWNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F58090", Offset = "0x3F57090", VA = "0x183F58090")]
		public static void NDUJPHNBORE<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F582F0", Offset = "0x3F572F0", VA = "0x183F582F0")]
		public static void NDUJPHNBORE<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class RVMQVBKSLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC05D0", Offset = "0x2BBF5D0", VA = "0x182BC05D0")]
		public static MDESIBUOWYK LDGVYQLXUAF([In] this Variant self, WQEPJKQGFSY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0480", Offset = "0x2BBF480", VA = "0x182BC0480")]
		public static Variant FESOWVBASTG(this MDESIBUOWYK a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class OBVXGILNRMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Id128<SOTPFGRBTRF> QKMBYROWFBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly bool IJQHYFZVBYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public readonly bool ACULEKPAZVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public readonly bool FYOFLAQGYYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public readonly bool JATBTDHGKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public readonly bool JADHBIZOIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool EDGQMNGTYNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool BYHEVQYQJCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool XYCCSNFAANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly List<(string Name, WQEPJKQGFSY Type)> LTXPXTJHENZ;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[WillBeRenamedTo("LegacyId")]
		public Guid HGJTEJGBOEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B74F50", Offset = "0x2B73F50", VA = "0x182B74F50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Id128<SOTPFGRBTRF> UVWOTAUPVAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B74F50", Offset = "0x2B73F50", VA = "0x182B74F50")]
			get
			{
				return default(Id128<SOTPFGRBTRF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xACFB10", Offset = "0xACEB10", VA = "0x180ACFB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IReadOnlyList<(string Name, WQEPJKQGFSY Type)> FNMHEWBMPRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ZPBQLEGXIGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4E60", Offset = "0x2BB3E60", VA = "0x182BB4E60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2BB55E0", Offset = "0x2BB45E0", VA = "0x182BB55E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, WQEPJKQGFSY> KWDJKMYNRNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4720", Offset = "0x2BB3720", VA = "0x182BB4720")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB47D0", Offset = "0x2BB37D0", VA = "0x182BB47D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> GXOPWQQWIWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5140", Offset = "0x2BB4140", VA = "0x182BB5140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4D10", Offset = "0x2BB3D10", VA = "0x182BB4D10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> HFJFYBWRCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5530", Offset = "0x2BB4530", VA = "0x182BB5530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4880", Offset = "0x2BB3880", VA = "0x182BB4880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, WQEPJKQGFSY> PLRZXQYGZMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4C60", Offset = "0x2BB3C60", VA = "0x182BB4C60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BB52F0", Offset = "0x2BB42F0", VA = "0x182BB52F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ARNPXVQKRYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5250", Offset = "0x2BB4250", VA = "0x182BB5250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4DC0", Offset = "0x2BB3DC0", VA = "0x182BB4DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1910C80", Offset = "0x190FC80", VA = "0x181910C80")]
		public void MVKMPWERGIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5680", Offset = "0x2BB4680", VA = "0x182BB5680")]
		internal OBVXGILNRMN([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, WQEPJKQGFSY Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4F00", Offset = "0x2BB3F00", VA = "0x182BB4F00")]
		public static CircuitEventDefinitionFactoryStart PZMODGNNSPE(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4FD0", Offset = "0x2BB3FD0", VA = "0x182BB4FD0")]
		public static CircuitEventDefinitionFactoryStart PZMODGNNSPE(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4510", Offset = "0x2BB3510", VA = "0x182BB4510")]
		public static OBVXGILNRMN CPPRWHLLMDA([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4930", Offset = "0x2BB3930", VA = "0x182BB4930")]
		public static OBVXGILNRMN IPNSAUZXWQM([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xF91BA0", Offset = "0xF90BA0", VA = "0x180F91BA0")]
		public void RJERZIGUGRW(Id128<SOTPFGRBTRF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BB51F0", Offset = "0x2BB41F0", VA = "0x182BB51F0")]
		public void SGCMWYWONBR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4B70", Offset = "0x2BB3B70", VA = "0x182BB4B70")]
		public void IZWUKKJQPDR(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5050", Offset = "0x2BB4050", VA = "0x182BB5050")]
		public void QQVOEVBVKNO(int a, WQEPJKQGFSY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BB53A0", Offset = "0x2BB43A0", VA = "0x182BB53A0")]
		public void XXNPBSJREJK(string a, WQEPJKQGFSY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BB54C0", Offset = "0x2BB44C0", VA = "0x182BB54C0")]
		public void ZEQQMKKPUJX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4620", Offset = "0x2BB3620", VA = "0x182BB4620")]
		public OBVXGILNRMN Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct CircuitEventDefinitionFactoryStart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BADCD0", Offset = "0x2BACCD0", VA = "0x182BADCD0")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BADA30", Offset = "0x2BACA30", VA = "0x182BADA30")]
		public CircuitEventDefinitionFactoryParams SYAYFZKSDJY(string a, WQEPJKQGFSY b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BADBA0", Offset = "0x2BACBA0", VA = "0x182BADBA0")]
		public OBVXGILNRMN YTBFAQLEKEG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct CircuitEventDefinitionFactoryParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly List<(string Name, WQEPJKQGFSY Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD9A0", Offset = "0x2BAC9A0", VA = "0x182BAD9A0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, WQEPJKQGFSY Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD770", Offset = "0x2BAC770", VA = "0x182BAD770")]
		public CircuitEventDefinitionFactoryParams SYAYFZKSDJY(string a, WQEPJKQGFSY b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD8A0", Offset = "0x2BAC8A0", VA = "0x182BAD8A0")]
		public OBVXGILNRMN YTBFAQLEKEG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ZOOLRCNFMRU
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly OBVXGILNRMN WWBPHXCIJEH;

			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly OBVXGILNRMN UCTODSFKLMM;

			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public static readonly OBVXGILNRMN VCIVQQTHDQL;

			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public static readonly OBVXGILNRMN OHTNHVUWSQU;

			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly OBVXGILNRMN JBZRUTOZWNJ;

			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly OBVXGILNRMN GUBNGZTOYRB;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly OBVXGILNRMN ZKGBVEKLHDC;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			internal static readonly OBVXGILNRMN[] RFQEKMPTONP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class YYVETXBMQGB
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly OBVXGILNRMN WRBWJLRERIT;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class TRIUFHQFJSA
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly OBVXGILNRMN NIAPGFRSORP;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly OBVXGILNRMN WLFWTHUNOIG;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class HQWEKASKZKF
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly OBVXGILNRMN FKAQRITHXUW;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public static readonly OBVXGILNRMN LZZDWVXATNJ;

			[Cpp2IlInjected.Token(Token = "0x4000141")]
			internal static readonly OBVXGILNRMN[] LLYPEIISDJX;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly OBVXGILNRMN TKVPVAPYAZH;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly OBVXGILNRMN UHNGCDGDQCI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class HXYMVAVOGZX
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly OBVXGILNRMN MVOQHVHQFCM;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public static readonly OBVXGILNRMN XNLNMEYVOLL;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class PHDWMWYYMJA
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly OBVXGILNRMN RONPMOBTNUB;

			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public static readonly OBVXGILNRMN IZOGGNGYGSY;

			[Cpp2IlInjected.Token(Token = "0x400014A")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class JVONYRQMRCJ
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly OBVXGILNRMN NIAPGFRSORP;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public static readonly OBVXGILNRMN WLFWTHUNOIG;

			[Cpp2IlInjected.Token(Token = "0x400014D")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class XLEZALLKFEN
		{
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly OBVXGILNRMN NYRFZPJHGJO;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public static readonly OBVXGILNRMN NXISKYHHLVN;

			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly OBVXGILNRMN NYCGFRYSJGJ;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly OBVXGILNRMN PEPVTDZGZER;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public static readonly OBVXGILNRMN YHOHAAKKYTI;

			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly OBVXGILNRMN RVSGBKGSATV;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly OBVXGILNRMN QBUPKTZODFE;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class XNDNAGVSYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class WNWSXIHAOJH
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class RPMEJCBFRPP
		{
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class KCHXCZXLRPX
		{
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly OBVXGILNRMN FXKSYQXYJTE;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public static readonly OBVXGILNRMN RCXBNDSQIXR;

			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class LPUDTKKGLVV
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RVDVQGGKSHX
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class QMFILSIFLML
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class DPUEBPKFGCE
		{
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public static readonly OBVXGILNRMN APWVIEKZGXI;

			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public static readonly OBVXGILNRMN MQJQUYSYVTA;

			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public static readonly OBVXGILNRMN WRQOOCBJOJF;

			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public static readonly OBVXGILNRMN LZVMGFMDZOQ;

			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly OBVXGILNRMN XTJIZDGVJDO;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public static readonly OBVXGILNRMN RONPMOBTNUB;

			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly OBVXGILNRMN NIIRECDEFMM;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly OBVXGILNRMN CUJFLALNOCR;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly OBVXGILNRMN XCJTXGZEPSL;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly OBVXGILNRMN ENJQYRHLWIV;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly OBVXGILNRMN CHNCEDWKHDJ;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly OBVXGILNRMN ZJBTDWKMEGF;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly OBVXGILNRMN XDAENMSKJZY;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly OBVXGILNRMN XZQATYIDTNB;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly OBVXGILNRMN FDERFAXVMWG;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly OBVXGILNRMN IIYHJKREESK;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly OBVXGILNRMN WCGVERKUMDS;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly OBVXGILNRMN UWOWVKMWBSR;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly OBVXGILNRMN NORAQWXWADC;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly OBVXGILNRMN CBKSSXWXLUS;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly OBVXGILNRMN PKADPEWCMOB;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly OBVXGILNRMN ZYQUCOXWLQN;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly OBVXGILNRMN DMKASMCOJGR;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly OBVXGILNRMN KEMPLRWGADP;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly OBVXGILNRMN LILMAOKURTJ;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly OBVXGILNRMN RNHZUZIPDMT;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly OBVXGILNRMN QKVXISMGIGX;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly OBVXGILNRMN GAKIUTDNMZV;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly OBVXGILNRMN FOHAUYCCQSO;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly OBVXGILNRMN VJXLEGXLHLA;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly OBVXGILNRMN XXRJAEPRDFF;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly OBVXGILNRMN TSZVQVTDBEL;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly OBVXGILNRMN QCHORGJSUCK;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly OBVXGILNRMN ZLXIOKYXVMS;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly OBVXGILNRMN VTVXWHIBZVI;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly OBVXGILNRMN MZMORGNNNDM;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly OBVXGILNRMN RRDICGSZHNQ;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly OBVXGILNRMN MCPWALMDQPG;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly OBVXGILNRMN HAOHQFNRCTS;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly OBVXGILNRMN CIXOFFIFIJO;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly OBVXGILNRMN AOHDDMLFLZB;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly OBVXGILNRMN BCPAOHXOAJN;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly OBVXGILNRMN YOEOMRJJTRP;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly OBVXGILNRMN NYSVOVLLTRZ;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly OBVXGILNRMN CDSWFAVZJMV;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly OBVXGILNRMN WDPCJIZUNSN;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly OBVXGILNRMN ORAAQCLVMZJ;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly OBVXGILNRMN YNQDTDCOOOJ;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly OBVXGILNRMN SDFPPUQYGXJ;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly OBVXGILNRMN RCHDJLMLBAZ;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly OBVXGILNRMN LXTMJDXHWWA;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly OBVXGILNRMN YDLOXFAUWCD;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly OBVXGILNRMN TZTZWQSWCEX;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly OBVXGILNRMN TNXXMODRAIL;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly OBVXGILNRMN NFQWWVKVDFX;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly OBVXGILNRMN EWPWFACPXOH;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly OBVXGILNRMN RFICVAYHBUF;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly OBVXGILNRMN EVBCCWWXIRT;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly OBVXGILNRMN CXBWRIJFRJV;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly OBVXGILNRMN XVOUNQGHFGV;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly OBVXGILNRMN TNEJWHDZCSD;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly OBVXGILNRMN OBBQFWXHART;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly OBVXGILNRMN NLCWLQEKVNC;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly OBVXGILNRMN KTVKWBLFMBJ;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly OBVXGILNRMN TNRVMPDOCBJ;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly OBVXGILNRMN SLQLMLRWMJE;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly OBVXGILNRMN CQCBMQUZPBA;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly OBVXGILNRMN ZQNXBRSYPHD;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly OBVXGILNRMN NYYUXFZZXYF;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class PKPKLFOKNWS
		{
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EMJFSFWUBXF
		{
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly OBVXGILNRMN UQCPAPKOZSB;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly OBVXGILNRMN AKICUCZXGSO;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly OBVXGILNRMN EZWMWMUHQUS;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public static readonly OBVXGILNRMN DKHXNEKFONT;

			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public static readonly OBVXGILNRMN YKDWTFZANVL;

			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly OBVXGILNRMN IULYIXHJOVJ;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly OBVXGILNRMN UELRHOKNSIJ;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class EMQHFLTCIKK
		{
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly OBVXGILNRMN MQJQUYSYVTA;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly OBVXGILNRMN WRQOOCBJOJF;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly OBVXGILNRMN LZVMGFMDZOQ;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly OBVXGILNRMN GCDDZMDKVNM;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public static readonly OBVXGILNRMN ENMJZGRXMEW;

			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly OBVXGILNRMN BGBJPMHTYNY;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly OBVXGILNRMN VKOIFDXEWKK;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class KGRTHFLEIIE
		{
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly OBVXGILNRMN JRUTHJWSYXG;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly OBVXGILNRMN XBZRKZGYPQW;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly OBVXGILNRMN DDBFABJKIIP;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly OBVXGILNRMN ZYRIQUHVWLP;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public static readonly OBVXGILNRMN QWDZTUFRVLB;

			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly OBVXGILNRMN ODIGBZWNTHR;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class BUSCSPFRZTZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class OTBWENMHKRA
		{
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly OBVXGILNRMN UJBIXREURFG;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class QMFBIDACCZK
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public static readonly OBVXGILNRMN APWVIEKZGXI;

			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class RSGJXLWWDOL
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class ZDJNWCUFRJC
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class MEMIWCVGZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public static readonly OBVXGILNRMN UWTKGBFPMUL;

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly OBVXGILNRMN EPYTZGCUBNT;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public static readonly OBVXGILNRMN THPCPNLFJWE;

			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public static readonly OBVXGILNRMN JLCESQWATVW;

			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class BJKOISGXZMT
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly OBVXGILNRMN PUIXCVAAIAI;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly OBVXGILNRMN KTCNBEMDVIV;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class JLPYWPDOLGD
		{
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class VEFUJHMBZSL
		{
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public static readonly OBVXGILNRMN UQCPAPKOZSB;

			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly OBVXGILNRMN AKICUCZXGSO;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class LWKDBZGYJCM
		{
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public static readonly OBVXGILNRMN RFJLOTATNSD;

			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public static readonly OBVXGILNRMN DKHXNEKFONT;

			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly OBVXGILNRMN YKDWTFZANVL;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly OBVXGILNRMN IULYIXHJOVJ;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public static readonly OBVXGILNRMN JNROCGVHDQU;

			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly OBVXGILNRMN NXKBZQUVMTP;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly OBVXGILNRMN BJAMHOYEWXL;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly OBVXGILNRMN SHHPJQLRHBJ;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly OBVXGILNRMN FITXQHHITEM;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly OBVXGILNRMN IHCWNOXLAHS;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly OBVXGILNRMN UQCPAPKOZSB;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly OBVXGILNRMN AKICUCZXGSO;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class NWHWILLENOI
		{
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class SHKOULKFYFW
		{
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly OBVXGILNRMN UQCPAPKOZSB;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly OBVXGILNRMN AKICUCZXGSO;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly OBVXGILNRMN NEBDWCGLQMO;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public static readonly OBVXGILNRMN XDVUZOSSDEQ;

			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public static readonly OBVXGILNRMN FORUFZLTHFV;

			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class ZIAPPNHEXTZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class RNNPSVNULKO
		{
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly OBVXGILNRMN DUAYVKBDBMX;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class EAJNNTWWGAK
		{
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly OBVXGILNRMN NSYPYKUAHPI;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static readonly OBVXGILNRMN MLDCEYDDWUD;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public static readonly OBVXGILNRMN UQCPAPKOZSB;

			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly OBVXGILNRMN AKICUCZXGSO;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class LYEWUGZQHUZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class OLTBQXXLCXT
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class USALMBAFQKO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class DZXVQRAXFRI
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class WQYXEAIQYAP
		{
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class WSITRCPTLCP
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public static readonly OBVXGILNRMN FXKSYQXYJTE;

			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public static readonly OBVXGILNRMN RCXBNDSQIXR;

			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class CRBNITHASIJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public static readonly OBVXGILNRMN WVTSGCIZYGU;

			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly OBVXGILNRMN SBGQZMRNQXQ;

			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly OBVXGILNRMN RWBTHHFAIJY;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly OBVXGILNRMN LZFVISMIMXO;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class YDSHJMRHZLM
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly OBVXGILNRMN WVTSGCIZYGU;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly OBVXGILNRMN SBGQZMRNQXQ;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly OBVXGILNRMN RWBTHHFAIJY;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly OBVXGILNRMN LZFVISMIMXO;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class RFAKIKWRPKT
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class XWVYTOWGNBK
		{
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly OBVXGILNRMN DIKHEVZZUMT;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly OBVXGILNRMN KHXMVSJEKLD;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly OBVXGILNRMN XVZBINZCUAZ;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class ZFIZYBNKWSJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public static readonly OBVXGILNRMN YOBOBXSVNLI;

			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly OBVXGILNRMN YNPZQSGSFHK;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly OBVXGILNRMN RLATNNMDIQJ;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class VOBHLNXMGNW
		{
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class RRPGLYKODXL
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly OBVXGILNRMN PSBXRRFRZQN;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly OBVXGILNRMN OFHZQJPIDNF;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly OBVXGILNRMN CDTOFSMYAJG;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public static readonly OBVXGILNRMN SSYMFZSUSVC;

			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static readonly OBVXGILNRMN ZAYLUEHADQR;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class IHGTCTYHXWA
		{
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly OBVXGILNRMN YCNXGNXSBDP;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class JNYQUAWKMUO
		{
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly OBVXGILNRMN SMUTTGDKRRC;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly OBVXGILNRMN OIXHBEGAJYV;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public static readonly OBVXGILNRMN RIIWTNAYLZC;

			[Cpp2IlInjected.Token(Token = "0x4000216")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class TDWHRDWWUPJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class BIUQIBSGIZR
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class VOSMBCWLAKG
		{
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class DFLVKIKNNKV
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly OBVXGILNRMN UYXDRDDMRZM;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public static readonly OBVXGILNRMN TBMABUXFBCX;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static readonly OBVXGILNRMN AZAOCISTMOR;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static readonly OBVXGILNRMN TXLPUAHMZNX;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly OBVXGILNRMN LXXHHHPNNMO;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly OBVXGILNRMN JVNQUGIVRIY;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly OBVXGILNRMN NANIGECRGUX;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly OBVXGILNRMN[] TCRTFYPTVOQ;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class WLENECQMNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public readonly WQEPJKQGFSY ZAYPPSTQXJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private readonly List<OBVXGILNRMN> EYPSVKJAOUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private readonly List<OBVXGILNRMN> KLRZZXNBURB;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public IReadOnlyList<OBVXGILNRMN> CRZUCYZGVUD
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public IReadOnlyList<OBVXGILNRMN> BBCFYKZHPWO
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCCB0", Offset = "0x2BDBCB0", VA = "0x182BDCCB0")]
		protected WLENECQMNLF(WQEPJKQGFSY a, params OBVXGILNRMN[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class VOFIAGVPRSB : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC6A0", Offset = "0x2BDB6A0", VA = "0x182BDC6A0")]
		internal VOFIAGVPRSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GLONFLMDZCW : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3FC0", Offset = "0x2BD2FC0", VA = "0x182BD3FC0")]
		internal GLONFLMDZCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class BVPDRVPGSBH : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF3C0", Offset = "0x2BCE3C0", VA = "0x182BCF3C0")]
		internal BVPDRVPGSBH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class BMZASFJFBQK : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEF90", Offset = "0x2BCDF90", VA = "0x182BCEF90")]
		internal BMZASFJFBQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class CWEZRZXYBMR : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BD03D0", Offset = "0x2BCF3D0", VA = "0x182BD03D0")]
		internal CWEZRZXYBMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class NTZGVQQHCUB : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8720", Offset = "0x2BD7720", VA = "0x182BD8720")]
		internal NTZGVQQHCUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class GRLYUGBDCZO : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4120", Offset = "0x2BD3120", VA = "0x182BD4120")]
		internal GRLYUGBDCZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class BHQITEPVSIF : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE970", Offset = "0x2BCD970", VA = "0x182BCE970")]
		internal BHQITEPVSIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class IDCNWSXOTAB : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4B20", Offset = "0x2BD3B20", VA = "0x182BD4B20")]
		internal IDCNWSXOTAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class KDXTEXIQLEZ : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5810", Offset = "0x2BD4810", VA = "0x182BD5810")]
		internal KDXTEXIQLEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ACXNUYQALMZ : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE010", Offset = "0x2BCD010", VA = "0x182BCE010")]
		internal ACXNUYQALMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class DGJKFAVAVCN : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD09E0", Offset = "0x2BCF9E0", VA = "0x182BD09E0")]
		internal DGJKFAVAVCN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class FYUZQMDCPOF : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3B80", Offset = "0x2BD2B80", VA = "0x182BD3B80")]
		internal FYUZQMDCPOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class ROWTTORDJZV : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9F50", Offset = "0x2BD8F50", VA = "0x182BD9F50")]
		internal ROWTTORDJZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class IDGJTBWGRDN : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4D00", Offset = "0x2BD3D00", VA = "0x182BD4D00")]
		internal IDGJTBWGRDN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class KXCPMLSDCAR : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6500", Offset = "0x2BD5500", VA = "0x182BD6500")]
		internal KXCPMLSDCAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class DUZZFTYQQBR : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0F80", Offset = "0x2BCFF80", VA = "0x182BD0F80")]
		internal DUZZFTYQQBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ZJANBMWSNEC : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BDED30", Offset = "0x2BDDD30", VA = "0x182BDED30")]
		internal ZJANBMWSNEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class XQCHULKXACE : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD570", Offset = "0x2BDC570", VA = "0x182BDD570")]
		internal XQCHULKXACE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class FANAUWUWWNA : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3660", Offset = "0x2BD2660", VA = "0x182BD3660")]
		internal FANAUWUWWNA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class XFTAIIZFKMY : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD310", Offset = "0x2BDC310", VA = "0x182BDD310")]
		internal XFTAIIZFKMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class GDDKQSHPBVW : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3D60", Offset = "0x2BD2D60", VA = "0x182BD3D60")]
		internal GDDKQSHPBVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class XTQTPOCTYHJ : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD750", Offset = "0x2BDC750", VA = "0x182BDD750")]
		internal XTQTPOCTYHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class WKWOKZNFAFG : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCAD0", Offset = "0x2BDBAD0", VA = "0x182BDCAD0")]
		internal WKWOKZNFAFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class BUZYPPKYZHF : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF1E0", Offset = "0x2BCE1E0", VA = "0x182BCF1E0")]
		internal BUZYPPKYZHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ZKJDLWICQRA : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEF10", Offset = "0x2BDDF10", VA = "0x182BDEF10")]
		internal ZKJDLWICQRA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class SHCFDLHMYSE : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAAB0", Offset = "0x2BD9AB0", VA = "0x182BDAAB0")]
		internal SHCFDLHMYSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class JTCCDMVYRGK : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5630", Offset = "0x2BD4630", VA = "0x182BD5630")]
		internal JTCCDMVYRGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LEYXNTUHHET : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD66E0", Offset = "0x2BD56E0", VA = "0x182BD66E0")]
		internal LEYXNTUHHET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class VIMXJUPKUGC : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC270", Offset = "0x2BDB270", VA = "0x182BDC270")]
		internal VIMXJUPKUGC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class PPAFLLAWZDX : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8F40", Offset = "0x2BD7F40", VA = "0x182BD8F40")]
		internal PPAFLLAWZDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class BHBWQEDKKDF : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE790", Offset = "0x2BCD790", VA = "0x182BCE790")]
		internal BHBWQEDKKDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class FHCAPIOORFB : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3840", Offset = "0x2BD2840", VA = "0x182BD3840")]
		internal FHCAPIOORFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class SZHZQLDUDYW : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB520", Offset = "0x2BDA520", VA = "0x182BDB520")]
		internal SZHZQLDUDYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class TKARSPIYEDQ : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB9D0", Offset = "0x2BDA9D0", VA = "0x182BDB9D0")]
		internal TKARSPIYEDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class BFIZPMVRQZE : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE530", Offset = "0x2BCD530", VA = "0x182BCE530")]
		internal BFIZPMVRQZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class QUYGUWWFQGL : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9700", Offset = "0x2BD8700", VA = "0x182BD9700")]
		internal QUYGUWWFQGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class MDMBITLCHXS : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7A50", Offset = "0x2BD6A50", VA = "0x182BD7A50")]
		internal MDMBITLCHXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class PSNBEYGHCBW : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9120", Offset = "0x2BD8120", VA = "0x182BD9120")]
		internal PSNBEYGHCBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class CLAVJVYAVUN : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF780", Offset = "0x2BCE780", VA = "0x182BCF780")]
		internal CLAVJVYAVUN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class BWUZIGJDOJP : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF5A0", Offset = "0x2BCE5A0", VA = "0x182BCF5A0")]
		internal BWUZIGJDOJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class QMRBXMHWCFT : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9520", Offset = "0x2BD8520", VA = "0x182BD9520")]
		internal QMRBXMHWCFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class DHMNULQAMMA : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0BC0", Offset = "0x2BCFBC0", VA = "0x182BD0BC0")]
		internal DHMNULQAMMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class EHOMBHONLBW : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1790", Offset = "0x2BD0790", VA = "0x182BD1790")]
		internal EHOMBHONLBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class DMTQGSFCIQT : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0DA0", Offset = "0x2BCFDA0", VA = "0x182BD0DA0")]
		internal DMTQGSFCIQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class RBMAJPLMJKO : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD98E0", Offset = "0x2BD88E0", VA = "0x182BD98E0")]
		internal RBMAJPLMJKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class KLIGMCTWIQF : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6320", Offset = "0x2BD5320", VA = "0x182BD6320")]
		internal KLIGMCTWIQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class VPQECVISYVK : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC8F0", Offset = "0x2BDB8F0", VA = "0x182BDC8F0")]
		internal VPQECVISYVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class SNBXUTHARKK : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB340", Offset = "0x2BDA340", VA = "0x182BDB340")]
		internal SNBXUTHARKK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class CLOILARQXYL : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF960", Offset = "0x2BCE960", VA = "0x182BCF960")]
		internal CLOILARQXYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class AHXTNDPHVDF : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE1F0", Offset = "0x2BCD1F0", VA = "0x182BCE1F0")]
		internal AHXTNDPHVDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class NKXKLLEIYOK : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8540", Offset = "0x2BD7540", VA = "0x182BD8540")]
		internal NKXKLLEIYOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class TAROWWHWGKD : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB780", Offset = "0x2BDA780", VA = "0x182BDB780")]
		internal TAROWWHWGKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class LHCGKNFFWQG : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BD68C0", Offset = "0x2BD58C0", VA = "0x182BD68C0")]
		internal LHCGKNFFWQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class LOJUVADICBK : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6AA0", Offset = "0x2BD5AA0", VA = "0x182BD6AA0")]
		internal LOJUVADICBK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class UNSXGHWGYNS : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBC20", Offset = "0x2BDAC20", VA = "0x182BDBC20")]
		internal UNSXGHWGYNS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class HBEIMWJPXGU : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4940", Offset = "0x2BD3940", VA = "0x182BD4940")]
		internal HBEIMWJPXGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ZGQSDRWBTJV : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEAE0", Offset = "0x2BDDAE0", VA = "0x182BDEAE0")]
		internal ZGQSDRWBTJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class VJHUTBEQJXQ : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC450", Offset = "0x2BDB450", VA = "0x182BDC450")]
		internal VJHUTBEQJXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class CQOALKLXNNO : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFB40", Offset = "0x2BCEB40", VA = "0x182BCFB40")]
		internal CQOALKLXNNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class FNVTYSSLACD : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3A20", Offset = "0x2BD2A20", VA = "0x182BD3A20")]
		internal FNVTYSSLACD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class APFXFPWIEVW : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE3D0", Offset = "0x2BCD3D0", VA = "0x182BCE3D0")]
		internal APFXFPWIEVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class RFZQOVGFZGJ : WLENECQMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9B30", Offset = "0x2BD8B30", VA = "0x182BD9B30")]
		internal RFZQOVGFZGJ()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public readonly struct NamedType : IEquatable<NamedType>, CMJSCLNOINY<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public readonly WQEPJKQGFSY Type;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
		private NamedType(string name, WQEPJKQGFSY type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B610", Offset = "0x2B0A610", VA = "0x182B0B610")]
		public static NamedType New(string name, WQEPJKQGFSY type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8A30", Offset = "0x2BD7A30", VA = "0x182BD8A30")]
		public static bool RZMMTPOVALZ([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8A30", Offset = "0x2BD7A30", VA = "0x182BD8A30", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8A30", Offset = "0x2BD7A30", VA = "0x182BD8A30")]
		public bool FSWIJMLMNCH([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8970", Offset = "0x2BD7970", VA = "0x182BD8970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8A80", Offset = "0x2BD7A80", VA = "0x182BD8A80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8AF0", Offset = "0x2BD7AF0", VA = "0x182BD8AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8B30", Offset = "0x2BD7B30", VA = "0x182BD8B30")]
		public string UOSZTQKLAQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8B70", Offset = "0x2BD7B70", VA = "0x182BD8B70")]
		public string XXMJKDJAANB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8A30", Offset = "0x2BD7A30", VA = "0x182BD8A30", Slot = "5")]
		private bool LUGLXBVAIZQ([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public interface RJNEMTAVLYW
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, BGYAXKJXFCB>> CDPQVGWXFFF(AGLENQQYPWD a, bool b);
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
