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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B8F40", Offset = "0x28B8340", VA = "0x1828B8F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B6E00", Offset = "0x28B6200", VA = "0x1828B6E00", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WMYKZILBBKQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28C1890", Offset = "0x28C0C90", VA = "0x1828C1890")]
		public static bool XVQADMVUCHF(this HRQTZSPCIJP a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28C19A0", Offset = "0x28C0DA0", VA = "0x1828C19A0")]
		public static bool XVQADMVUCHF(this BZJHOIRAJMU a)
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
			private readonly ZVRVTWCRUTF _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			public EVRequest(ZVRVTWCRUTF staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class ZCVVIOWPKYW
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<PDCABNTYABD>, VCZKYJPAIXS> DZHKARMMNRV;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<PDCABNTYABD>>? TXSPXABSYBJ;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<PDCABNTYABD> VREPQGQBRMJ;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<PDCABNTYABD> MAEFZJMNOJI;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<PDCABNTYABD> XAGVWDSMZCF;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<PDCABNTYABD> VQTMHNAEOSY;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<PDCABNTYABD> EAOWGIHEJWZ;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<PDCABNTYABD> PJKOROWFGPY;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<PDCABNTYABD> JNMCUFESQPC;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<PDCABNTYABD> RESPAYNYHFW;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<PDCABNTYABD> SFQUZNEBSAQ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<PDCABNTYABD> FZVKIJDGPOU;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<PDCABNTYABD> SZZVUIKCCDM;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<PDCABNTYABD> XLCPKAVHXXE;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<PDCABNTYABD> UXKKCKJYHYT;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<PDCABNTYABD> IEHAZSXXDTX;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<PDCABNTYABD> VJUCKKTZQTT;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<PDCABNTYABD> WRGVPMCGQLI;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<PDCABNTYABD> QUSJFZXPZJH;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<PDCABNTYABD> YVLPWRXJOEX;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<PDCABNTYABD> HYCTZNRRXAA;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<PDCABNTYABD> VOCZOAOCRGD;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<PDCABNTYABD> EQKZTITKFLQ;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<PDCABNTYABD> AFIRTBRFEKL;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<PDCABNTYABD> JIGHXIRRRZD;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<PDCABNTYABD> REOPLZWKHNY;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<PDCABNTYABD> JZNYBNGRSCO;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<PDCABNTYABD> KCLMWTEZCOF;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<PDCABNTYABD> IQUGAQOFUFS;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<PDCABNTYABD> ZUEKHMKIQCV;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<PDCABNTYABD> QOLRWUXGELL;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<PDCABNTYABD> RATHMTTRJED;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<PDCABNTYABD> TDFLWSLKNAR;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<PDCABNTYABD> RPVWTQKRIXC;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<PDCABNTYABD> SQCFMHAMJCX;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<PDCABNTYABD> MVOIDPMVWMJ;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<PDCABNTYABD> GDASHLYHKLH;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<PDCABNTYABD> GQBUHALBZTI;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<PDCABNTYABD> GPXUZVVIABV;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<PDCABNTYABD> ECSDQBNMSWE;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<PDCABNTYABD> TVJTEPCTEQI;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<PDCABNTYABD> MODPEQIAJRW;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<PDCABNTYABD> OBAVPYYGRFR;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<PDCABNTYABD> TJZCFKXMWKP;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<PDCABNTYABD> ONUPBPAVXQQ;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<PDCABNTYABD> KGERUKOBCLN;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<PDCABNTYABD> VZDSPJLXDMP;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<PDCABNTYABD> YLDVHTXUIUR;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<PDCABNTYABD> FBPDJEEXSKU;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<PDCABNTYABD> QKQFMCDQATA;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<PDCABNTYABD> KMIYNJZHCYE;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<PDCABNTYABD> TGPJNXWISAR;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<PDCABNTYABD> ZIBGKAZATZD;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<PDCABNTYABD> QQIDFORZLVA;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<PDCABNTYABD> LHVLBRNFJUR;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<PDCABNTYABD> FRFIWXJDKDN;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<PDCABNTYABD> DUOCODCBFTA;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<PDCABNTYABD> OSOBYGCEBPS;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<PDCABNTYABD> EQIIJSGDRXS;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<PDCABNTYABD> BARHBXPDFDK;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<PDCABNTYABD> QZHZRKQDIFJ;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<PDCABNTYABD> RQJJUIGNNUO;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<PDCABNTYABD> IYRKSOCPNTG;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<PDCABNTYABD> XBYFKXYDCPG;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<PDCABNTYABD> JEJXEDZMQLJ;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<PDCABNTYABD> ZFGTKHJKVZL;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<PDCABNTYABD> CGNUSTEVUSM;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<PDCABNTYABD> BFYYCAPZXDJ;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<PDCABNTYABD> DHTBTNNPPIQ;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<PDCABNTYABD>, VCZKYJPAIXS> XKNSPSKIFVW
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x28C24B0", Offset = "0x28C18B0", VA = "0x1828C24B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x28C2760", Offset = "0x28C1B60", VA = "0x1828C2760")]
			public static VCZKYJPAIXS PSSEAPBDXFS(Id32<PDCABNTYABD> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28C26D0", Offset = "0x28C1AD0", VA = "0x1828C26D0")]
			public static bool NZJIGPVUJIB(Id32<PDCABNTYABD> id, [Out] VCZKYJPAIXS a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x28C2870", Offset = "0x28C1C70", VA = "0x1828C2870")]
			public static HRQTZSPCIJP TGDDWEPYTPL(Id32<PDCABNTYABD> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x28C27E0", Offset = "0x28C1BE0", VA = "0x1828C27E0")]
			private static Id32<PDCABNTYABD> SHWXSEAJSCT(VCZKYJPAIXS a, Id32<PDCABNTYABD> id)
			{
				return default(Id32<PDCABNTYABD>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28C2500", Offset = "0x28C1900", VA = "0x1828C2500")]
			private static void MTZWXKMLYSX(Id32<PDCABNTYABD> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class KDFFBKZNAAF
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				private IdUnsafeList<CTXJFDCZQJP, HRQTZSPCIJP?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xFB42A0", Offset = "0xFB36A0", VA = "0x180FB42A0")]
				private TypeRegistryFactory([In] IdUnsafeList<CTXJFDCZQJP, HRQTZSPCIJP?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x28C0AC0", Offset = "0x28BFEC0", VA = "0x1828C0AC0")]
				public static TypeRegistryFactory WOHFYTHXWCP()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x28C05A0", Offset = "0x28BF9A0", VA = "0x1828C05A0")]
				public (ReadOnlyIdArray<CTXJFDCZQJP, HRQTZSPCIJP>, IReadOnlyDictionary<HRQTZSPCIJP, Id32<CTXJFDCZQJP>>) EQHRYZKONUP()
				{
					return default((ReadOnlyIdArray<CTXJFDCZQJP, HRQTZSPCIJP>, IReadOnlyDictionary<HRQTZSPCIJP, Id32<CTXJFDCZQJP>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x28C0940", Offset = "0x28BFD40", VA = "0x1828C0940")]
				public Id32<CTXJFDCZQJP> SIVGFXMEUNT(int a, HRQTZSPCIJP b)
				{
					return default(Id32<CTXJFDCZQJP>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x28C08F0", Offset = "0x28BFCF0", VA = "0x1828C08F0")]
				public Id32<CTXJFDCZQJP> Initialize(int id, OBHUVOBWFPE type, OBHUVOBWFPE factoryType)
				{
					return default(Id32<CTXJFDCZQJP>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class OTRENLETUKE
			{
				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Id32<CTXJFDCZQJP> SWFLHOOCFEH
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x28B9280", Offset = "0x28B8680", VA = "0x1828B9280")]
					[CompilerGenerated]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x28B9200", Offset = "0x28B8600", VA = "0x1828B9200")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Id32<CTXJFDCZQJP> SNLKDBWNPGD
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x28B9080", Offset = "0x28B8480", VA = "0x1828B9080")]
					[CompilerGenerated]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x28B9000", Offset = "0x28B8400", VA = "0x1828B9000")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Id32<CTXJFDCZQJP> LDCTRPSTYPK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x28B91C0", Offset = "0x28B85C0", VA = "0x1828B91C0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x28B9240", Offset = "0x28B8640", VA = "0x1828B9240")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<CTXJFDCZQJP> CUSZSWKVXGS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x28B90C0", Offset = "0x28B84C0", VA = "0x1828B90C0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x28B8FC0", Offset = "0x28B83C0", VA = "0x1828B8FC0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<CTXJFDCZQJP> FOHGIBVRFXI
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x28B9180", Offset = "0x28B8580", VA = "0x1828B9180")]
					[CompilerGenerated]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x28B9100", Offset = "0x28B8500", VA = "0x1828B9100")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<CTXJFDCZQJP> CQARVGKSMDB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x28B9140", Offset = "0x28B8540", VA = "0x1828B9140")]
					[CompilerGenerated]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x28B9040", Offset = "0x28B8440", VA = "0x1828B9040")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class JTIWPWMADUF : IEnumerable<HRQTZSPCIJP>, IEnumerable, IEnumerator<HRQTZSPCIJP>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				private int JIPOOQUWCIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				private HRQTZSPCIJP JOTWNIKQVJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int PLMFUAHXCWL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private bool GSPGQWQVIPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public bool ZSEIGPKZYVK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private RoomVersion HQXVKRRPCVV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public RoomVersion GHSJQESPASY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private bool HKQTBTQRQTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public bool CYGYZLYPRJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private bool BUYEINDWVUQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public bool QJYKGXWWEGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private bool GJWQTVACXUA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public bool UBLUCYDHYOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				private bool VLSBPESCJWG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public bool FPJSGPABMYF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				private IEnumerator<HRQTZSPCIJP> BPMZBLFMONE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private HRQTZSPCIJP JCOCHNTZFQL;

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				private HRQTZSPCIJP VMHYZLFEZIW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				private object MSIUOYXLJXG
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
				[DebuggerHidden]
				public JTIWPWMADUF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x28AAE30", Offset = "0x28AA230", VA = "0x1828AAE30", Slot = "7")]
				[DebuggerHidden]
				private void AEBWHPMOWJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x28AAFC0", Offset = "0x28AA3C0", VA = "0x1828AAFC0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x28AB3B0", Offset = "0x28AA7B0", VA = "0x1828AB3B0")]
				private void RYZDNTQONZF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x28AAF80", Offset = "0x28AA380", VA = "0x1828AAF80", Slot = "10")]
				[DebuggerHidden]
				private void MJTKPUASZVA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x28AAEC0", Offset = "0x28AA2C0", VA = "0x1828AAEC0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<HRQTZSPCIJP> BEOHKIZZFSV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x28AAEC0", Offset = "0x28AA2C0", VA = "0x1828AAEC0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator CQMSCGRISCD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class NFRDSQKKHUR : IEnumerable<HRQTZSPCIJP>, IEnumerable, IEnumerator<HRQTZSPCIJP>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				private int JIPOOQUWCIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private HRQTZSPCIJP JOTWNIKQVJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				private int PLMFUAHXCWL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private RoomVersion HQXVKRRPCVV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public RoomVersion GHSJQESPASY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private bool BUYEINDWVUQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public bool QJYKGXWWEGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private bool HKQTBTQRQTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				public bool CYGYZLYPRJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				private bool GFFLVOCKZXM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public bool RKGLQJIEZLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				private bool GJWQTVACXUA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public bool UBLUCYDHYOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private bool RDFMBCEBXRY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool WTMBCIZHENU;

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				private HRQTZSPCIJP VMHYZLFEZIW
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private object MSIUOYXLJXG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
				[DebuggerHidden]
				public NFRDSQKKHUR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
				[DebuggerHidden]
				private void AEBWHPMOWJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x28B7100", Offset = "0x28B6500", VA = "0x1828B7100", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x28B70C0", Offset = "0x28B64C0", VA = "0x1828B70C0", Slot = "10")]
				[DebuggerHidden]
				private void MJTKPUASZVA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x28B7010", Offset = "0x28B6410", VA = "0x1828B7010", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<HRQTZSPCIJP> BEOHKIZZFSV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x28B7010", Offset = "0x28B6410", VA = "0x1828B7010", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator CQMSCGRISCD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class VZZRXQNGIKJ : IEnumerable<Id32<CTXJFDCZQJP>>, IEnumerable, IEnumerator<Id32<CTXJFDCZQJP>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				private int JIPOOQUWCIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private Id32<CTXJFDCZQJP> JOTWNIKQVJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				private int PLMFUAHXCWL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private RoomVersion HQXVKRRPCVV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public RoomVersion GHSJQESPASY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private bool HKQTBTQRQTG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public bool CYGYZLYPRJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private bool BUYEINDWVUQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public bool QJYKGXWWEGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private bool GJWQTVACXUA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public bool UBLUCYDHYOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private bool VLSBPESCJWG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public bool FPJSGPABMYF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				private IEnumerator<HRQTZSPCIJP> BPMZBLFMONE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private IEnumerator<OBHUVOBWFPE> BPHSEELPFBV;

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private Id32<CTXJFDCZQJP> TASMZRUQUKB
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<CTXJFDCZQJP>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private object MSIUOYXLJXG
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x28C17A0", Offset = "0x28C0BA0", VA = "0x1828C17A0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x1293840", Offset = "0x1292C40", VA = "0x181293840")]
				[DebuggerHidden]
				public VZZRXQNGIKJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x28C1060", Offset = "0x28C0460", VA = "0x1828C1060", Slot = "7")]
				[DebuggerHidden]
				private void AEBWHPMOWJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x28C12A0", Offset = "0x28C06A0", VA = "0x1828C12A0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x28C17F0", Offset = "0x28C0BF0", VA = "0x1828C17F0")]
				private void RYZDNTQONZF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x28C1840", Offset = "0x28C0C40", VA = "0x1828C1840")]
				private void RZEKLAKLXKO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x28C1260", Offset = "0x28C0660", VA = "0x1828C1260", Slot = "10")]
				[DebuggerHidden]
				private void MJTKPUASZVA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x28C11B0", Offset = "0x28C05B0", VA = "0x1828C11B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<CTXJFDCZQJP>> DOVZURFKPHA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x28C11B0", Offset = "0x28C05B0", VA = "0x1828C11B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator CQMSCGRISCD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private static readonly Log HONKOTEDSFS;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private static ReadOnlyIdArray<CTXJFDCZQJP, HRQTZSPCIJP?> YNVMGQPMTMK;

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static IReadOnlyDictionary<HRQTZSPCIJP, Id32<CTXJFDCZQJP>> JCPAOMQECAO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly BZJHOIRAJMU QHJPCSUTFZZ;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly BZJHOIRAJMU RRJEBIDFZOX;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static readonly HashSet<HRQTZSPCIJP> WZGQSFTMZUV;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static List<HRQTZSPCIJP> ZDVEWXHPFTW;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet TWTGPMAQKHT
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet QBWRAIUZAEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet FLQTRSLTAJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xB411C0", Offset = "0xB405C0", VA = "0x180B411C0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static HRQTZSPCIJP SWFLHOOCFEH
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x28AD710", Offset = "0x28ACB10", VA = "0x1828AD710")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static HRQTZSPCIJP SNLKDBWNPGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x28ABD70", Offset = "0x28AB170", VA = "0x1828ABD70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static HRQTZSPCIJP LDCTRPSTYPK
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x28AD220", Offset = "0x28AC620", VA = "0x1828AD220")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static HRQTZSPCIJP CUSZSWKVXGS
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x28ABFE0", Offset = "0x28AB3E0", VA = "0x1828ABFE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static HRQTZSPCIJP XTSWNUBLPSU
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x28AC4D0", Offset = "0x28AB8D0", VA = "0x1828AC4D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static HRQTZSPCIJP UWFPGOALALB
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x28AD7A0", Offset = "0x28ACBA0", VA = "0x1828AD7A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static HRQTZSPCIJP YAGXFXZWVNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x28AED90", Offset = "0x28AE190", VA = "0x1828AED90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static HRQTZSPCIJP FOHGIBVRFXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x28AD0A0", Offset = "0x28AC4A0", VA = "0x1828AD0A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static OBHUVOBWFPE ALQRNDVRXCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x28ACE50", Offset = "0x28AC250", VA = "0x1828ACE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static OBHUVOBWFPE DVAVKAUZCYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28ACD60", Offset = "0x28AC160", VA = "0x1828ACD60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static OBHUVOBWFPE RPRSJOKXIGO
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x28AD580", Offset = "0x28AC980", VA = "0x1828AD580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static OBHUVOBWFPE JAVPXNBTZSA
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x28AE6A0", Offset = "0x28ADAA0", VA = "0x1828AE6A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static OBHUVOBWFPE ZWNMYQGDGMI
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x28ACEF0", Offset = "0x28AC2F0", VA = "0x1828ACEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static OBHUVOBWFPE MRSYALPNJNZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x28ABB90", Offset = "0x28AAF90", VA = "0x1828ABB90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static OBHUVOBWFPE BNLEEWDIKFV
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x28AD3F0", Offset = "0x28AC7F0", VA = "0x1828AD3F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static OBHUVOBWFPE LXWIKNREQKH
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x28AECA0", Offset = "0x28AE0A0", VA = "0x1828AECA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static OBHUVOBWFPE ALIPPHJDMZE
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x28AB4A0", Offset = "0x28AA8A0", VA = "0x1828AB4A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static OBHUVOBWFPE EMTDDRUJGEW
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x28ACEA0", Offset = "0x28AC2A0", VA = "0x1828ACEA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static OBHUVOBWFPE CEGTCZUJELP
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x28ADED0", Offset = "0x28AD2D0", VA = "0x1828ADED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static OBHUVOBWFPE FPKALJKJEYX
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x28AC5B0", Offset = "0x28AB9B0", VA = "0x1828AC5B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static OBHUVOBWFPE FQFHQQWUFTL
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x28AB980", Offset = "0x28AAD80", VA = "0x1828AB980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static OBHUVOBWFPE LOFCTUQZLQK
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x28ACC70", Offset = "0x28AC070", VA = "0x1828ACC70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static OBHUVOBWFPE THPIAHNZUVI
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x28ABC30", Offset = "0x28AB030", VA = "0x1828ABC30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static OBHUVOBWFPE KHGJOHVPPCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x28AD6C0", Offset = "0x28ACAC0", VA = "0x1828AD6C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static OBHUVOBWFPE ADJROMIMJVP
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x28AD1D0", Offset = "0x28AC5D0", VA = "0x1828AD1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static OBHUVOBWFPE GSOXHJPEJMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x28AB930", Offset = "0x28AAD30", VA = "0x1828AB930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static OBHUVOBWFPE OJQRJBRKNCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x28AE330", Offset = "0x28AD730", VA = "0x1828AE330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static OBHUVOBWFPE QMEVLXKZLAO
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x28AEB00", Offset = "0x28ADF00", VA = "0x1828AEB00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static OBHUVOBWFPE YJKJCAXGPYL
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x28AB4F0", Offset = "0x28AA8F0", VA = "0x1828AB4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static OBHUVOBWFPE KVZRXCMWYDL
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x28ADAA0", Offset = "0x28ACEA0", VA = "0x1828ADAA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static OBHUVOBWFPE OQLNXAELFXR
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x28AC430", Offset = "0x28AB830", VA = "0x1828AC430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static OBHUVOBWFPE DIYJKSSGDJR
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x28AD880", Offset = "0x28ACC80", VA = "0x1828AD880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static OBHUVOBWFPE TATDULUDYSG
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x28AC160", Offset = "0x28AB560", VA = "0x1828AC160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static OBHUVOBWFPE CTPNCJNXXZV
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x28AD3A0", Offset = "0x28AC7A0", VA = "0x1828AD3A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static OBHUVOBWFPE OOGLOCBOKVL
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x28AE560", Offset = "0x28AD960", VA = "0x1828AE560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static OBHUVOBWFPE PYVNHZWBFJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x28AC390", Offset = "0x28AB790", VA = "0x1828AC390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static OBHUVOBWFPE LTVTKLZTEOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x28AC740", Offset = "0x28ABB40", VA = "0x1828AC740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static OBHUVOBWFPE JWUDNMCIJFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x28AD130", Offset = "0x28AC530", VA = "0x1828AD130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static OBHUVOBWFPE DGOQYSKQXHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x28AD180", Offset = "0x28AC580", VA = "0x1828AD180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static OBHUVOBWFPE OLVZMKORWFQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x28AEAB0", Offset = "0x28ADEB0", VA = "0x1828AEAB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static OBHUVOBWFPE IDBZUTVKCWX
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x28AC200", Offset = "0x28AB600", VA = "0x1828AC200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static OBHUVOBWFPE TGRFHNHKLNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x28AB400", Offset = "0x28AA800", VA = "0x1828AB400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static OBHUVOBWFPE VKKSGXZLHBU
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x28ABE50", Offset = "0x28AB250", VA = "0x1828ABE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static OBHUVOBWFPE AFIOTNICINO
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x28AE510", Offset = "0x28AD910", VA = "0x1828AE510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static OBHUVOBWFPE GNTLJOBFUJF
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x28AD4E0", Offset = "0x28AC8E0", VA = "0x1828AD4E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static OBHUVOBWFPE MFKFJBLVEXZ
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x28AC790", Offset = "0x28ABB90", VA = "0x1828AC790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static OBHUVOBWFPE IEJCBHUDZDI
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x28AB760", Offset = "0x28AAB60", VA = "0x1828AB760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static OBHUVOBWFPE UUKLVRKUDKI
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x28AEC00", Offset = "0x28AE000", VA = "0x1828AEC00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static OBHUVOBWFPE JLJVHQTPLKO
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x28AE790", Offset = "0x28ADB90", VA = "0x1828AE790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static OBHUVOBWFPE JUMPSZZATTC
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x28AC600", Offset = "0x28ABA00", VA = "0x1828AC600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static OBHUVOBWFPE DXWWZUBZVBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x28AE740", Offset = "0x28ADB40", VA = "0x1828AE740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static OBHUVOBWFPE WTUNYHUYBBV
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x28AD2B0", Offset = "0x28AC6B0", VA = "0x1828AD2B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static OBHUVOBWFPE UIDETNJENAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x28AE600", Offset = "0x28ADA00", VA = "0x1828AE600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static OBHUVOBWFPE XMJAPVZXNJC
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x28AE2E0", Offset = "0x28AD6E0", VA = "0x1828AE2E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static OBHUVOBWFPE SVDWCVXKVHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x28AEF70", Offset = "0x28AE370", VA = "0x1828AEF70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static OBHUVOBWFPE LUYUGESMUPT
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x28AD350", Offset = "0x28AC750", VA = "0x1828AD350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static OBHUVOBWFPE PIOTOQQKPEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x28ABB40", Offset = "0x28AAF40", VA = "0x1828ABB40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static OBHUVOBWFPE EEOFDVWAGTU
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x28ABCD0", Offset = "0x28AB0D0", VA = "0x1828ABCD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static OBHUVOBWFPE LOWFPCZPAVW
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x28ACBD0", Offset = "0x28ABFD0", VA = "0x1828ACBD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static OBHUVOBWFPE SXGCVWAQBKH
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x28ADA00", Offset = "0x28ACE00", VA = "0x1828ADA00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static OBHUVOBWFPE QTFSCRHFZDE
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x28AEFC0", Offset = "0x28AE3C0", VA = "0x1828AEFC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static OBHUVOBWFPE TRUAFWMZZYX
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x28AC340", Offset = "0x28AB740", VA = "0x1828AC340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static OBHUVOBWFPE GOGUBYLAPQL
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x28ABF90", Offset = "0x28AB390", VA = "0x1828ABF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static OBHUVOBWFPE QXXGDAYITCL
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x28AD490", Offset = "0x28AC890", VA = "0x1828AD490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static OBHUVOBWFPE NKGYGXVUJYV
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x28AE4C0", Offset = "0x28AD8C0", VA = "0x1828AE4C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static OBHUVOBWFPE CHKTTYFDPNI
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x28ABC80", Offset = "0x28AB080", VA = "0x1828ABC80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static OBHUVOBWFPE HQWOBKHAIXF
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x28ABEF0", Offset = "0x28AB2F0", VA = "0x1828ABEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static OBHUVOBWFPE ILMJVOGJFWM
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x28AD8D0", Offset = "0x28ACCD0", VA = "0x1828AD8D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static OBHUVOBWFPE QLBNHFKXITC
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x28ABAF0", Offset = "0x28AAEF0", VA = "0x1828ABAF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static OBHUVOBWFPE VHXWSVVRQFP
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x28ADE80", Offset = "0x28AD280", VA = "0x1828ADE80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static OBHUVOBWFPE FZRKEORPJJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x28AECF0", Offset = "0x28AE0F0", VA = "0x1828AECF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static OBHUVOBWFPE VOWQXITWGZE
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x28AB7B0", Offset = "0x28AABB0", VA = "0x1828AB7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static OBHUVOBWFPE XZPWYEELOAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x28AC2F0", Offset = "0x28AB6F0", VA = "0x1828AC2F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static OBHUVOBWFPE IYQEZKVJNIV
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x28ADA50", Offset = "0x28ACE50", VA = "0x1828ADA50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static OBHUVOBWFPE FTCHFVQIQDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x28ACC20", Offset = "0x28AC020", VA = "0x1828ACC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static OBHUVOBWFPE TZYNHWPBJRW
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static OBHUVOBWFPE QDVAMLWUDZG
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x28AB540", Offset = "0x28AA940", VA = "0x1828AB540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static OBHUVOBWFPE UWZEFTMDESQ
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x28ABE00", Offset = "0x28AB200", VA = "0x1828ABE00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static OBHUVOBWFPE ZPHDCDVMCUZ
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x28ACCC0", Offset = "0x28AC0C0", VA = "0x1828ACCC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static OBHUVOBWFPE PZHRMKKFGII
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x28ACF90", Offset = "0x28AC390", VA = "0x1828ACF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static OBHUVOBWFPE WFMAOBPCWWI
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x28AC6F0", Offset = "0x28ABAF0", VA = "0x1828AC6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static OBHUVOBWFPE AFPCOOWTJMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x28AED40", Offset = "0x28AE140", VA = "0x1828AED40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static OBHUVOBWFPE WUSJFMLHQTZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x28ABAA0", Offset = "0x28AAEA0", VA = "0x1828ABAA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static OBHUVOBWFPE XOPPFDZKUIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x28AC480", Offset = "0x28AB880", VA = "0x1828AC480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static OBHUVOBWFPE LAEABYELXEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x28AE6F0", Offset = "0x28ADAF0", VA = "0x1828AE6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static OBHUVOBWFPE XJKPDRGXMGX
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x28AC6A0", Offset = "0x28ABAA0", VA = "0x1828AC6A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static OBHUVOBWFPE JECLDPOFSLC
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x28AD300", Offset = "0x28AC700", VA = "0x1828AD300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static OBHUVOBWFPE YHACDIVHBVS
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x28ABA50", Offset = "0x28AAE50", VA = "0x1828ABA50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static OBHUVOBWFPE RXUYUAPHFSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x28AE470", Offset = "0x28AD870", VA = "0x1828AE470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static OBHUVOBWFPE GMYRVJRVBQS
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x28AC2A0", Offset = "0x28AB6A0", VA = "0x1828AC2A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static OBHUVOBWFPE VCHYTHOHGNN
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x28AEC50", Offset = "0x28AE050", VA = "0x1828AEC50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static OBHUVOBWFPE GNVWSVJRZRB
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x28AEED0", Offset = "0x28AE2D0", VA = "0x1828AEED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static OBHUVOBWFPE SLJJULRFCAL
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x28ABF40", Offset = "0x28AB340", VA = "0x1828ABF40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static OBHUVOBWFPE FFWYWAAZFSX
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x28AE650", Offset = "0x28ADA50", VA = "0x1828AE650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static OBHUVOBWFPE DREUUCWUDQD
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x28AB9D0", Offset = "0x28AADD0", VA = "0x1828AB9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static OBHUVOBWFPE PEAZYOBFCGW
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x28ABEA0", Offset = "0x28AB2A0", VA = "0x1828ABEA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static OBHUVOBWFPE KFIBLXIHRDV
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x28ABBE0", Offset = "0x28AAFE0", VA = "0x1828ABBE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static OBHUVOBWFPE KGCKWMECWRW
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x28AC560", Offset = "0x28AB960", VA = "0x1828AC560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static OBHUVOBWFPE WGBNPPZSEWV
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x28ADFF0", Offset = "0x28AD3F0", VA = "0x1828ADFF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static OBHUVOBWFPE HPITAMNLYRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x28ADF20", Offset = "0x28AD320", VA = "0x1828ADF20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static OBHUVOBWFPE TXSHGGCJQQF
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x28ACD10", Offset = "0x28AC110", VA = "0x1828ACD10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static OBHUVOBWFPE EBDEPZLBEYC
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x28AE420", Offset = "0x28AD820", VA = "0x1828AE420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static OBHUVOBWFPE RWQCFONNKAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x28AD530", Offset = "0x28AC930", VA = "0x1828AD530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static OBHUVOBWFPE VDROIXNTUIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x28AC070", Offset = "0x28AB470", VA = "0x1828AC070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static OBHUVOBWFPE VZSRCKMMTPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x28AB450", Offset = "0x28AA850", VA = "0x1828AB450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static OBHUVOBWFPE IMZTNQHEAFR
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x28AC250", Offset = "0x28AB650", VA = "0x1828AC250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static OBHUVOBWFPE GQEIQVCTFXF
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x28AE3D0", Offset = "0x28AD7D0", VA = "0x1828AE3D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static OBHUVOBWFPE EBMPIMIFLRV
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x28ACDB0", Offset = "0x28AC1B0", VA = "0x1828ACDB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static OBHUVOBWFPE FQKTAZDZSYA
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x28AD050", Offset = "0x28AC450", VA = "0x1828AD050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static OBHUVOBWFPE VRELQHFXUFR
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x28AB6E0", Offset = "0x28AAAE0", VA = "0x1828AB6E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static OBHUVOBWFPE ETLFOKKPFQV
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x28AD440", Offset = "0x28AC840", VA = "0x1828AD440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static OBHUVOBWFPE UEBMSCWGOXC
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x28ACF40", Offset = "0x28AC340", VA = "0x1828ACF40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static OBHUVOBWFPE YCVFAEUSQRD
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x28AE380", Offset = "0x28AD780", VA = "0x1828AE380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static OBHUVOBWFPE YTKFKZAXAQI
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x28AB590", Offset = "0x28AA990", VA = "0x1828AB590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static OBHUVOBWFPE XUUEIQBFRDV
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x28AEF20", Offset = "0x28AE320", VA = "0x1828AEF20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static OBHUVOBWFPE LUNTJZOMBDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x28AD830", Offset = "0x28ACC30", VA = "0x1828AD830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static OBHUVOBWFPE FBCSZACUJAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x28AB690", Offset = "0x28AAA90", VA = "0x1828AB690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static OBHUVOBWFPE JEZLVLFCAPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x28AC0C0", Offset = "0x28AB4C0", VA = "0x1828AC0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static OBHUVOBWFPE NRUHOBDUUQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x28AC650", Offset = "0x28ABA50", VA = "0x1828AC650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static OBHUVOBWFPE DJHEHSXFZEQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x28AC110", Offset = "0x28AB510", VA = "0x1828AC110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static OBHUVOBWFPE HQKGPOOADNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x28AC3E0", Offset = "0x28AB7E0", VA = "0x1828AC3E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static OBHUVOBWFPE SIUZNHPABVN
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x28AC1B0", Offset = "0x28AB5B0", VA = "0x1828AC1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static OBHUVOBWFPE HJDLBXPNKTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x28ABD20", Offset = "0x28AB120", VA = "0x1828ABD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static OBHUVOBWFPE YCAWPRPIWXZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x28AE5B0", Offset = "0x28AD9B0", VA = "0x1828AE5B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28AD5D0", Offset = "0x28AC9D0", VA = "0x1828AD5D0")]
			public static BZJHOIRAJMU RUZUZUFCJTS([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x28AD920", Offset = "0x28ACD20", VA = "0x1828AD920")]
			public static ClassFactoryTypeParams SRSZQBUHYEJ(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28AD9D0", Offset = "0x28ACDD0", VA = "0x1828AD9D0")]
			public static ClassFactoryTypeParams SRSZQBUHYEJ([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28AB730", Offset = "0x28AAB30", VA = "0x1828AB730")]
			public static BZJHOIRAJMU BYSNRWAVKTQ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28ABA20", Offset = "0x28AAE20", VA = "0x1828ABA20")]
			public static BZJHOIRAJMU DCLUHTDAMPZ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28AB800", Offset = "0x28AAC00", VA = "0x1828AB800")]
			public static BZJHOIRAJMU CQARVGKSMDB([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28ADDD0", Offset = "0x28AD1D0", VA = "0x1828ADDD0")]
			public static HRQTZSPCIJP TGDDWEPYTPL(Id32<CTXJFDCZQJP> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x28AC7E0", Offset = "0x28ABBE0", VA = "0x1828AC7E0")]
			public static string KFSSLXXFMFE(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28ADAF0", Offset = "0x28ACEF0", VA = "0x1828ADAF0")]
			private static HRQTZSPCIJP TGDDWEPYTPL(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28ACFE0", Offset = "0x28AC3E0", VA = "0x1828ACFE0")]
			public static Id32<CTXJFDCZQJP>? NTPFOOALUGA(HRQTZSPCIJP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x28AC860", Offset = "0x28ABC60", VA = "0x1828AC860")]
			public static CircuitTypeIdWrapper? KKKJXARZRDZ(HRQTZSPCIJP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x28AF010", Offset = "0x28AE410", VA = "0x1828AF010")]
			static KDFFBKZNAAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x28AEE20", Offset = "0x28AE220", VA = "0x1828AEE20")]
			[IteratorStateMachine(typeof(NFRDSQKKHUR))]
			private static IEnumerable<HRQTZSPCIJP> YXPCXIIYSIN(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28AEB50", Offset = "0x28ADF50", VA = "0x1828AEB50")]
			[IteratorStateMachine(typeof(JTIWPWMADUF))]
			public static IEnumerable<HRQTZSPCIJP> XICOENMPJNO(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x28AE040", Offset = "0x28AD440", VA = "0x1828AE040")]
			public static Variant TZNICNDIGER(HRQTZSPCIJP a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28AE7E0", Offset = "0x28ADBE0", VA = "0x1828AE7E0")]
			public static Variant WWKNPYVZMAA(HRQTZSPCIJP a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x28ADF70", Offset = "0x28AD370", VA = "0x1828ADF70")]
			public static bool TTCXNPRUBYY(HRQTZSPCIJP a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x28AB5E0", Offset = "0x28AA9E0", VA = "0x1828AB5E0")]
			[IteratorStateMachine(typeof(VZZRXQNGIKJ))]
			public static IEnumerable<Id32<CTXJFDCZQJP>> BNXQSELYZOS(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZJWCXQXCPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28C5660", Offset = "0x28C4A60", VA = "0x1828C5660")]
		public static YKAOCTKZYDT CQVTSUWTJSM(this HRQTZSPCIJP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28C6720", Offset = "0x28C5B20", VA = "0x1828C6720")]
		public static HRQTZSPCIJP FLGKTDORRZX(this YKAOCTKZYDT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class EHCBDEGZQWX
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x355BD10", Offset = "0x355B110", VA = "0x18355BD10")]
		public static Dictionary<b, c> XAUUEOUCSEN<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class AISLKMPBYMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28A7C50", Offset = "0x28A7050", VA = "0x1828A7C50")]
		public static XQFTPFGXQSD CQVTSUWTJSM([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28A7D50", Offset = "0x28A7150", VA = "0x1828A7D50")]
		public static Guid FLGKTDORRZX(XQFTPFGXQSD a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RUASFIEHYZS
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28C0390", Offset = "0x28BF790", VA = "0x1828C0390")]
		public static PQMRUHFIYRB CQVTSUWTJSM([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28C0420", Offset = "0x28BF820", VA = "0x1828C0420")]
		public static NamedType FLGKTDORRZX(this PQMRUHFIYRB a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class KITJFDWDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3719100", Offset = "0x3718500", VA = "0x183719100")]
		public static void LRSIEDWGJTL<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3719360", Offset = "0x3718760", VA = "0x183719360")]
		public static void LRSIEDWGJTL<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class GWXHSXLMOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28AA2B0", Offset = "0x28A96B0", VA = "0x1828AA2B0")]
		public static JUDCWSIPKGL CQVTSUWTJSM([In] this Variant self, HRQTZSPCIJP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28AA4B0", Offset = "0x28A98B0", VA = "0x1828AA4B0")]
		public static Variant FLGKTDORRZX(this JUDCWSIPKGL a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LHIOUPADLJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Id128<ICNTJLGTLPI> DPJFNRQVAVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly bool FPPYHEDZPQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public readonly bool OQTMVXSOCRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public readonly bool YGPGKTPEEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public readonly bool VLDPBAVXILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public readonly bool VLTJSVDPKTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool QVBNBFKLZUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool DOYOVOTDPGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool WONGESJHHTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly List<(string Name, HRQTZSPCIJP Type)> LFTISOBKQYY;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[WillBeRenamedTo("LegacyId")]
		public Guid OQGVUCEGDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x286FC70", Offset = "0x286F070", VA = "0x18286FC70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Id128<ICNTJLGTLPI> LNXQLSMAWBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x286FC70", Offset = "0x286F070", VA = "0x18286FC70")]
			get
			{
				return default(Id128<ICNTJLGTLPI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IReadOnlyList<(string Name, HRQTZSPCIJP Type)> WYIVDHQOMSD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action YQKKYEACJGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x28B5DB0", Offset = "0x28B51B0", VA = "0x1828B5DB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x28B6090", Offset = "0x28B5490", VA = "0x1828B6090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, HRQTZSPCIJP> CNAAIWRNZSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x28B6750", Offset = "0x28B5B50", VA = "0x1828B6750")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x28B6600", Offset = "0x28B5A00", VA = "0x1828B6600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> FJCESKWHVUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x28B6290", Offset = "0x28B5690", VA = "0x1828B6290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x28B5BA0", Offset = "0x28B4FA0", VA = "0x1828B5BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> NWCYHCEIMEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x28B69C0", Offset = "0x28B5DC0", VA = "0x1828B69C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x28B6800", Offset = "0x28B5C00", VA = "0x1828B6800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, HRQTZSPCIJP> PPQYOKMOQUX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28B6550", Offset = "0x28B5950", VA = "0x1828B6550")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x28B6BC0", Offset = "0x28B5FC0", VA = "0x1828B6BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action PKXUNSSQNJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x28B66B0", Offset = "0x28B5AB0", VA = "0x1828B66B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x28B6C70", Offset = "0x28B6070", VA = "0x1828B6C70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1906480", Offset = "0x1905880", VA = "0x181906480")]
		public void SAVWILRJDWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28B6D10", Offset = "0x28B6110", VA = "0x1828B6D10")]
		internal LHIOUPADLJY([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, HRQTZSPCIJP Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28B6A70", Offset = "0x28B5E70", VA = "0x1828B6A70")]
		public static CircuitEventDefinitionFactoryStart WOHFYTHXWCP(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28B6B40", Offset = "0x28B5F40", VA = "0x1828B6B40")]
		public static CircuitEventDefinitionFactoryStart WOHFYTHXWCP(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28B68B0", Offset = "0x28B5CB0", VA = "0x1828B68B0")]
		public static LHIOUPADLJY VOMSWRJWHNL([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28B5E50", Offset = "0x28B5250", VA = "0x1828B5E50")]
		public static LHIOUPADLJY FRPCYOUXMTJ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
		public void HLNJWOWVZJX(Id128<ICNTJLGTLPI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28B5C50", Offset = "0x28B5050", VA = "0x1828B5C50")]
		public void BLHOQELLCEQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28B61A0", Offset = "0x28B55A0", VA = "0x1828B61A0")]
		public void JNDQHOYXRUA(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28B6340", Offset = "0x28B5740", VA = "0x1828B6340")]
		public void OBEAVKDFOBV(int a, HRQTZSPCIJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28B6430", Offset = "0x28B5830", VA = "0x1828B6430")]
		public void PATZBWZEFUB(string a, HRQTZSPCIJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28B6130", Offset = "0x28B5530", VA = "0x1828B6130")]
		public void HGRECHXFORI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28B5CB0", Offset = "0x28B50B0", VA = "0x1828B5CB0")]
		public LHIOUPADLJY Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x28A8350", Offset = "0x28A7750", VA = "0x1828A8350")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28A81E0", Offset = "0x28A75E0", VA = "0x1828A81E0")]
		public CircuitEventDefinitionFactoryParams YGPKTUPZQBN(string a, HRQTZSPCIJP b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28A80B0", Offset = "0x28A74B0", VA = "0x1828A80B0")]
		public LHIOUPADLJY EQHRYZKONUP()
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
		private readonly List<(string Name, HRQTZSPCIJP Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28A8020", Offset = "0x28A7420", VA = "0x1828A8020")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, HRQTZSPCIJP Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28A7EF0", Offset = "0x28A72F0", VA = "0x1828A7EF0")]
		public CircuitEventDefinitionFactoryParams YGPKTUPZQBN(string a, HRQTZSPCIJP b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28A7DF0", Offset = "0x28A71F0", VA = "0x1828A7DF0")]
		public LHIOUPADLJY EQHRYZKONUP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class RRMPZDSYUNN
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly LHIOUPADLJY ACXHWOJTIKS;

			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly LHIOUPADLJY OOVCJRUBHYN;

			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public static readonly LHIOUPADLJY CWEYPTVCFLC;

			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public static readonly LHIOUPADLJY YHRMKBESQGR;

			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly LHIOUPADLJY VGJDOCZOEXY;

			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly LHIOUPADLJY UVAPTVPPGMQ;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly LHIOUPADLJY DHEDXCGRDED;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			internal static readonly LHIOUPADLJY[] DWIIDMCQUBG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class MAEFZJMNOJI
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly LHIOUPADLJY EBFQSEXXEQC;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class XAGVWDSMZCF
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly LHIOUPADLJY YTUXLAEXBSS;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly LHIOUPADLJY LRDQZORDMBR;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class XBYFKXYDCPG
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly LHIOUPADLJY SXDIVVNFQTZ;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public static readonly LHIOUPADLJY GLEPTXDEYHY;

			[Cpp2IlInjected.Token(Token = "0x4000141")]
			internal static readonly LHIOUPADLJY[] TNLXSXUZDJY;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly LHIOUPADLJY ADUPCUVBXES;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly LHIOUPADLJY RVHRXZTEQZJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class FBPDJEEXSKU
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly LHIOUPADLJY IEPKVVITINZ;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public static readonly LHIOUPADLJY LWIMVMDFFKG;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class EAOWGIHEJWZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly LHIOUPADLJY NCUHYMFDFHQ;

			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public static readonly LHIOUPADLJY UMBIOWGTJZL;

			[Cpp2IlInjected.Token(Token = "0x400014A")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class PJKOROWFGPY
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly LHIOUPADLJY YTUXLAEXBSS;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public static readonly LHIOUPADLJY LRDQZORDMBR;

			[Cpp2IlInjected.Token(Token = "0x400014D")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class JNMCUFESQPC
		{
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly LHIOUPADLJY ERHSLRDFBIN;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public static readonly LHIOUPADLJY FCLQIBLAZLY;

			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly LHIOUPADLJY PAGNEMKOJSI;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly LHIOUPADLJY PQPGBVMIDEW;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public static readonly LHIOUPADLJY SUCVMQSZEUZ;

			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly LHIOUPADLJY QAIHMZTMNVI;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly LHIOUPADLJY SVAMFQDEMTF;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class RESPAYNYHFW
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class SFQUZNEBSAQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class TVJTEPCTEQI
		{
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class FZVKIJDGPOU
		{
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly LHIOUPADLJY HIAPORLLUHD;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public static readonly LHIOUPADLJY OJUTHOOKIBE;

			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class DUOCODCBFTA
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class SZZVUIKCCDM
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class XLCPKAVHXXE
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class YLDVHTXUIUR
		{
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public static readonly LHIOUPADLJY OVKUREMKBPT;

			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public static readonly LHIOUPADLJY DDJTKZPQORZ;

			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public static readonly LHIOUPADLJY LWLSESOZWQI;

			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public static readonly LHIOUPADLJY QVCRYXCWGGR;

			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly LHIOUPADLJY UVXHOAEWWDB;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public static readonly LHIOUPADLJY NCUHYMFDFHQ;

			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly LHIOUPADLJY PRNORUBETQT;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly LHIOUPADLJY EDYLXOXEYAM;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly LHIOUPADLJY ECCBCHJKXWO;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly LHIOUPADLJY GRQRJYTKTBM;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly LHIOUPADLJY FONAQXHKWNK;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly LHIOUPADLJY NGAHLJCYDYS;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly LHIOUPADLJY BTCGMMLBEKV;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly LHIOUPADLJY GSVIAZVLDGY;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly LHIOUPADLJY SWHNYXSJIPF;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly LHIOUPADLJY NNIZTJEDUTB;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly LHIOUPADLJY WPSXVTNIIZP;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly LHIOUPADLJY DTIHMPCWOUS;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly LHIOUPADLJY KHWYPSXMRPB;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly LHIOUPADLJY FUGCSZQSJAV;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly LHIOUPADLJY TXJPKKMYPFC;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly LHIOUPADLJY PFSVZKHMUUY;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly LHIOUPADLJY SCWDLKWIKKG;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly LHIOUPADLJY HYMNUTRRBCS;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly LHIOUPADLJY GMIFQAYSQHA;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly LHIOUPADLJY LPMQBSKHUSK;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly LHIOUPADLJY DYSPJKRXDAI;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly LHIOUPADLJY MJAILYUKLBG;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly LHIOUPADLJY YFYGCNMIABL;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly LHIOUPADLJY PHESNHZXCDD;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly LHIOUPADLJY WOLIAGCXOXG;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly LHIOUPADLJY GYOYDKDLUQU;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly LHIOUPADLJY KEJSZNPOMCV;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly LHIOUPADLJY GUNZSDJTVXH;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly LHIOUPADLJY VFTKUBHFGWJ;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly LHIOUPADLJY MBXMHONSOGN;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly LHIOUPADLJY SUABAUHKFDL;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly LHIOUPADLJY RJCLOXYSZJR;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly LHIOUPADLJY NCKMKBNJWQP;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly LHIOUPADLJY PDVUCJUQOZR;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly LHIOUPADLJY ADWSLHPWTAS;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly LHIOUPADLJY OBOBWPNCARW;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly LHIOUPADLJY YVQOQHXHLCG;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly LHIOUPADLJY YTENIGDKMFU;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly LHIOUPADLJY TSNANCOEULQ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly LHIOUPADLJY ALEUBTSYTHE;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly LHIOUPADLJY WXPWSAUHRNG;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly LHIOUPADLJY ZIDISGSPYDW;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly LHIOUPADLJY TKTTXHQBTGU;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly LHIOUPADLJY KMCFVIHLYDM;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly LHIOUPADLJY XBNNNCJXMLT;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly LHIOUPADLJY GMHOCRBJXBE;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly LHIOUPADLJY PDMBIBYJWVK;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly LHIOUPADLJY DELKNIYCYQW;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly LHIOUPADLJY FEMGQDNEQFQ;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly LHIOUPADLJY ZZTBSCRXDSS;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly LHIOUPADLJY KMKQRBMBHJE;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly LHIOUPADLJY ZCTONNUWXRU;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly LHIOUPADLJY SZBBVMXQWRO;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly LHIOUPADLJY VCADGIEUBSA;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly LHIOUPADLJY JOSMMTRIDHO;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly LHIOUPADLJY IMHMLQEWUVU;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly LHIOUPADLJY YPPHUITSDBD;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly LHIOUPADLJY KVIBWERGDYC;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly LHIOUPADLJY VEIQTHCFXWO;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly LHIOUPADLJY HJWCRAKYONX;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly LHIOUPADLJY BMJLSBDHOAH;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly LHIOUPADLJY ZBMHMNSWQKA;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly LHIOUPADLJY DOZZAAEYURU;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class IEHAZSXXDTX
		{
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class YIJOEKKISAM
		{
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly LHIOUPADLJY HIMDCHBGGBY;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly LHIOUPADLJY QBECGMRUOWD;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly LHIOUPADLJY EEIRBONIVVR;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public static readonly LHIOUPADLJY FPGFKKIRXIE;

			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public static readonly LHIOUPADLJY SNUJHWWCYPG;

			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly LHIOUPADLJY LDRWKLJMZXQ;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly LHIOUPADLJY AMFKCJQIOSA;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class CNKMXPJOURP
		{
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly LHIOUPADLJY DDJTKZPQORZ;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly LHIOUPADLJY LWLSESOZWQI;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly LHIOUPADLJY QVCRYXCWGGR;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly LHIOUPADLJY AQPEZOWGZHL;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public static readonly LHIOUPADLJY SUAPMKYQNBD;

			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly LHIOUPADLJY YQYIOJXQZVH;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly LHIOUPADLJY QMXUCGRJQMH;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class VJUCKKTZQTT
		{
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly LHIOUPADLJY TUTMLFEPYLB;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly LHIOUPADLJY BZPJMUWYLKH;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly LHIOUPADLJY UBVIZTVVEBG;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly LHIOUPADLJY VLDNMEAXZTC;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public static readonly LHIOUPADLJY QQDMXKWSKAU;

			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly LHIOUPADLJY IIPQRJNYWTI;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class WRGVPMCGQLI
		{
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class QUSJFZXPZJH
		{
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly LHIOUPADLJY KTCIEVJJGFN;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class YVLPWRXJOEX
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public static readonly LHIOUPADLJY OVKUREMKBPT;

			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class HYCTZNRRXAA
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class VOCZOAOCRGD
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class ONUPBPAVXQQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public static readonly LHIOUPADLJY GLXPVNAVUSI;

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly LHIOUPADLJY LPSXDFUKIAO;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public static readonly LHIOUPADLJY OYTHHZEVJDX;

			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public static readonly LHIOUPADLJY LIEFUVUSHSF;

			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class EQKZTITKFLQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly LHIOUPADLJY BNYYIGPIGEH;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly LHIOUPADLJY CRFRMDQGEXG;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class REOPLZWKHNY
		{
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class QEDZWYYYNVU
		{
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public static readonly LHIOUPADLJY HIMDCHBGGBY;

			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly LHIOUPADLJY QBECGMRUOWD;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class AFIRTBRFEKL
		{
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public static readonly LHIOUPADLJY FZGKEDUKUCY;

			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public static readonly LHIOUPADLJY FPGFKKIRXIE;

			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly LHIOUPADLJY SNUJHWWCYPG;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly LHIOUPADLJY LDRWKLJMZXQ;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public static readonly LHIOUPADLJY YXIRWXIPKSN;

			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly LHIOUPADLJY IVOXDYOEIGW;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly LHIOUPADLJY WISZKSVOZPY;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly LHIOUPADLJY DMNJQLDKGHC;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly LHIOUPADLJY CWYEAXAAQCJ;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly LHIOUPADLJY CVRTUNOTNDX;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly LHIOUPADLJY HIMDCHBGGBY;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly LHIOUPADLJY QBECGMRUOWD;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class JIGHXIRRRZD
		{
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class KGERUKOBCLN
		{
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly LHIOUPADLJY HIMDCHBGGBY;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly LHIOUPADLJY QBECGMRUOWD;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly LHIOUPADLJY EDCTDPPLTAR;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public static readonly LHIOUPADLJY AYTWAMKEZBL;

			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public static readonly LHIOUPADLJY KHIRSQTCPEQ;

			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class JZNYBNGRSCO
		{
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class LHVLBRNFJUR
		{
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly LHIOUPADLJY EOHAWKXFAZM;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class KCLMWTEZCOF
		{
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly LHIOUPADLJY AKSRAFZNXVR;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static readonly LHIOUPADLJY HYQLYLRDUHU;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public static readonly LHIOUPADLJY HIMDCHBGGBY;

			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly LHIOUPADLJY QBECGMRUOWD;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class IQUGAQOFUFS
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class EBTZBPIGTRC
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class ZUEKHMKIQCV
		{
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class QOLRWUXGELL
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class CGNUSTEVUSM
		{
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class XUAWYQGQIRO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public static readonly LHIOUPADLJY HIAPORLLUHD;

			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public static readonly LHIOUPADLJY OJUTHOOKIBE;

			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class ECSDQBNMSWE
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public static readonly LHIOUPADLJY ICYDGNTMBJJ;

			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly LHIOUPADLJY ANBCWMHSEAJ;

			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly LHIOUPADLJY VWXJTLFFKXF;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly LHIOUPADLJY VXKMCZAUDKR;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class TDFLWSLKNAR
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly LHIOUPADLJY ICYDGNTMBJJ;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly LHIOUPADLJY ANBCWMHSEAJ;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly LHIOUPADLJY VWXJTLFFKXF;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly LHIOUPADLJY VXKMCZAUDKR;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class RPVWTQKRIXC
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class ZIBGKAZATZD
		{
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly LHIOUPADLJY HJEIIQRNNAC;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly LHIOUPADLJY QGKKPTKMURM;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly LHIOUPADLJY FOKLKIVZGRE;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class FQFAXTVKAUU
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public static readonly LHIOUPADLJY SZYVAYDEILZ;

			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly LHIOUPADLJY UTMGPZANOYJ;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly LHIOUPADLJY AOUJQQAVXDA;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class SQCFMHAMJCX
		{
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class QQIDFORZLVA
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly LHIOUPADLJY PFVPGGVHTGC;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly LHIOUPADLJY JKQOMLCSZVW;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly LHIOUPADLJY PCSXMIVDZCH;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public static readonly LHIOUPADLJY NABWBRRBQLR;

			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static readonly LHIOUPADLJY CFGPALIVODU;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class MVOIDPMVWMJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly LHIOUPADLJY UQNXXIJNIRE;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class GDASHLYHKLH
		{
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly LHIOUPADLJY KMCHOXCRUDR;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly LHIOUPADLJY PWMKACLVNDC;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public static readonly LHIOUPADLJY ZOHTDCZKPTR;

			[Cpp2IlInjected.Token(Token = "0x4000216")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class GQBUHALBZTI
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class BARHBXPDFDK
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class QZHZRKQDIFJ
		{
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class KMIYNJZHCYE
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly LHIOUPADLJY ONJJCBDZKBX;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public static readonly LHIOUPADLJY FXGUORDNQJM;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static readonly LHIOUPADLJY JORYQRHCHIE;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static readonly LHIOUPADLJY DIMPVBPREFS;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly LHIOUPADLJY SGODHGKDOOX;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly LHIOUPADLJY MYJCFZGTEZP;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly LHIOUPADLJY MHUGSPQLHVU;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly LHIOUPADLJY[] DKHHOJRBOMT;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class VCZKYJPAIXS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public readonly HRQTZSPCIJP WYEFURDYYQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private readonly List<LHIOUPADLJY> GKYFNZFFURT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private readonly List<LHIOUPADLJY> HGEMMVZFJFS;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public IReadOnlyList<LHIOUPADLJY> SJZAPMKGXVK
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public IReadOnlyList<LHIOUPADLJY> LSXEBJGCNTF
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x28D4470", Offset = "0x28D3870", VA = "0x1828D4470")]
		protected VCZKYJPAIXS(HRQTZSPCIJP a, params LHIOUPADLJY[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class FGUGCSTLQAI : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x28CB490", Offset = "0x28CA890", VA = "0x1828CB490")]
		internal FGUGCSTLQAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class FPSPFSUOYOR : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x28CB830", Offset = "0x28CAC30", VA = "0x1828CB830")]
		internal FPSPFSUOYOR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class TDNVNGMVFJK : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x28D3BF0", Offset = "0x28D2FF0", VA = "0x1828D3BF0")]
		internal TDNVNGMVFJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RAPSVRJWTPH : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x28D2E90", Offset = "0x28D2290", VA = "0x1828D2E90")]
		internal RAPSVRJWTPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ZHQBZLTURJQ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x28D6AB0", Offset = "0x28D5EB0", VA = "0x1828D6AB0")]
		internal ZHQBZLTURJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class NBACEZQQCUS : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x28D0100", Offset = "0x28CF500", VA = "0x1828D0100")]
		internal NBACEZQQCUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class YZUEQVVNHTL : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x28D68E0", Offset = "0x28D5CE0", VA = "0x1828D68E0")]
		internal YZUEQVVNHTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class RXYVKDFNRII : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x28D3120", Offset = "0x28D2520", VA = "0x1828D3120")]
		internal RXYVKDFNRII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class OUNSJJDXBHM : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x28D0F50", Offset = "0x28D0350", VA = "0x1828D0F50")]
		internal OUNSJJDXBHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ULURLINPUZA : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x28D3E20", Offset = "0x28D3220", VA = "0x1828D3E20")]
		internal ULURLINPUZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class EQAZJKVAVNQ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x28CA930", Offset = "0x28C9D30", VA = "0x1828CA930")]
		internal EQAZJKVAVNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GSYIIVVBGHQ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x28CC2B0", Offset = "0x28CB6B0", VA = "0x1828CC2B0")]
		internal GSYIIVVBGHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SUXXKHMQEES : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x28D33B0", Offset = "0x28D27B0", VA = "0x1828D33B0")]
		internal SUXXKHMQEES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class UPHFIQBEZRE : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x28D3FF0", Offset = "0x28D33F0", VA = "0x1828D3FF0")]
		internal UPHFIQBEZRE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class XGOWCPIUQFW : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x28D5400", Offset = "0x28D4800", VA = "0x1828D5400")]
		internal XGOWCPIUQFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class PZWWPZTPLCI : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x28D18E0", Offset = "0x28D0CE0", VA = "0x1828D18E0")]
		internal PZWWPZTPLCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZMQNRRKHDDC : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x28D7200", Offset = "0x28D6600", VA = "0x1828D7200")]
		internal ZMQNRRKHDDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class KCWUWZCXKSZ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x28CE4E0", Offset = "0x28CD8E0", VA = "0x1828CE4E0")]
		internal KCWUWZCXKSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class UUFOQQVCLLJ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x28D40D0", Offset = "0x28D34D0", VA = "0x1828D40D0")]
		internal UUFOQQVCLLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class JHHDWUPMCJZ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x28CDAF0", Offset = "0x28CCEF0", VA = "0x1828CDAF0")]
		internal JHHDWUPMCJZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class WGVTHCJLXMB : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x28D4F20", Offset = "0x28D4320", VA = "0x1828D4F20")]
		internal WGVTHCJLXMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class EXVENZKELPL : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x28CB070", Offset = "0x28CA470", VA = "0x1828CB070")]
		internal EXVENZKELPL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class HLYAXCLFISG : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x28CCA80", Offset = "0x28CBE80", VA = "0x1828CCA80")]
		internal HLYAXCLFISG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class IHFUYWWWJVJ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x28CD6F0", Offset = "0x28CCAF0", VA = "0x1828CD6F0")]
		internal IHFUYWWWJVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class LDIPACMEKKQ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x28CF110", Offset = "0x28CE510", VA = "0x1828CF110")]
		internal LDIPACMEKKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class LSVIBCFYCZV : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x28CF590", Offset = "0x28CE990", VA = "0x1828CF590")]
		internal LSVIBCFYCZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class BZXYFZRFQGF : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8370", Offset = "0x28C7770", VA = "0x1828C8370")]
		internal BZXYFZRFQGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class EUOTCOPYBPZ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x28CAEA0", Offset = "0x28CA2A0", VA = "0x1828CAEA0")]
		internal EUOTCOPYBPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class FKACUWLZPHI : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x28CB660", Offset = "0x28CAA60", VA = "0x1828CB660")]
		internal FKACUWLZPHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class OYUTYPNIFGP : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x28D12F0", Offset = "0x28D06F0", VA = "0x1828D12F0")]
		internal OYUTYPNIFGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class MITTBIKTXLA : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x28CF930", Offset = "0x28CED30", VA = "0x1828CF930")]
		internal MITTBIKTXLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class KCTTJMWUZWA : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x28CE310", Offset = "0x28CD710", VA = "0x1828CE310")]
		internal KCTTJMWUZWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class YOQEHTHIECI : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x28D6580", Offset = "0x28D5980", VA = "0x1828D6580")]
		internal YOQEHTHIECI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class PTBZSVCSEBR : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x28D1690", Offset = "0x28D0A90", VA = "0x1828D1690")]
		internal PTBZSVCSEBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class HZYSJWCDJIB : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x28CCFD0", Offset = "0x28CC3D0", VA = "0x1828CCFD0")]
		internal HZYSJWCDJIB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class CJNCLZTDEQP : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x28C8770", Offset = "0x28C7B70", VA = "0x1828C8770")]
		internal CJNCLZTDEQP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class IGZDPOALRCA : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x28CD520", Offset = "0x28CC920", VA = "0x1828CD520")]
		internal IGZDPOALRCA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class BNJYEFOBCLT : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x28C8120", Offset = "0x28C7520", VA = "0x1828C8120")]
		internal BNJYEFOBCLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class ZTMMSLYMXJP : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x28D73D0", Offset = "0x28D67D0", VA = "0x1828D73D0")]
		internal ZTMMSLYMXJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class WXHSYUYYJXA : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x28D51D0", Offset = "0x28D45D0", VA = "0x1828D51D0")]
		internal WXHSYUYYJXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class UZKRBKOKNCC : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x28D42A0", Offset = "0x28D36A0", VA = "0x1828D42A0")]
		internal UZKRBKOKNCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class QIVNMTJCSCS : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x28D1E80", Offset = "0x28D1280", VA = "0x1828D1E80")]
		internal QIVNMTJCSCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class IJJIGRPYHBH : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x28CD8C0", Offset = "0x28CCCC0", VA = "0x1828CD8C0")]
		internal IJJIGRPYHBH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class QOKVJFWUNGN : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x28D2050", Offset = "0x28D1450", VA = "0x1828D2050")]
		internal QOKVJFWUNGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class DPDLIFLQCPQ : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x28C9EC0", Offset = "0x28C92C0", VA = "0x1828C9EC0")]
		internal DPDLIFLQCPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class NANMNIRAEYL : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x28CFF30", Offset = "0x28CF330", VA = "0x1828CFF30")]
		internal NANMNIRAEYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class DSFSMEMLEVE : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x28CA090", Offset = "0x28C9490", VA = "0x1828CA090")]
		internal DSFSMEMLEVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ZULURJKJWLT : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x28D7680", Offset = "0x28D6A80", VA = "0x1828D7680")]
		internal ZULURJKJWLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class EZOVVXWQJFX : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x28CB2C0", Offset = "0x28CA6C0", VA = "0x1828CB2C0")]
		internal EZOVVXWQJFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class CIIDUTCFTDE : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x28C85A0", Offset = "0x28C79A0", VA = "0x1828C85A0")]
		internal CIIDUTCFTDE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class CLBLMKFWRFK : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x28C89C0", Offset = "0x28C7DC0", VA = "0x1828C89C0")]
		internal CLBLMKFWRFK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class IGGWLIBIBIP : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x28CD350", Offset = "0x28CC750", VA = "0x1828CD350")]
		internal IGGWLIBIBIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BBSQMAUYIHK : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x28C7F50", Offset = "0x28C7350", VA = "0x1828C7F50")]
		internal BBSQMAUYIHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class XSMYWIULBUR : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x28D5720", Offset = "0x28D4B20", VA = "0x1828D5720")]
		internal XSMYWIULBUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class HXZWTQAOFEF : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x28CCDA0", Offset = "0x28CC1A0", VA = "0x1828CCDA0")]
		internal HXZWTQAOFEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class PLZHSYLGIVF : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x28D14C0", Offset = "0x28D08C0", VA = "0x1828D14C0")]
		internal PLZHSYLGIVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class NBXHMMJJDFH : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x28D02D0", Offset = "0x28CF6D0", VA = "0x1828D02D0")]
		internal NBXHMMJJDFH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class MCMSJWCWLAU : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x28CF760", Offset = "0x28CEB60", VA = "0x1828CF760")]
		internal MCMSJWCWLAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class OWAEWUEYDJN : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x28D1120", Offset = "0x28D0520", VA = "0x1828D1120")]
		internal OWAEWUEYDJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class MYADZTSSOKP : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x28CFD60", Offset = "0x28CF160", VA = "0x1828CFD60")]
		internal MYADZTSSOKP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class HRKVQFRDFSW : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x28CCC50", Offset = "0x28CC050", VA = "0x1828CCC50")]
		internal HRKVQFRDFSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class IDNCMDFMLAP : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x28CD1A0", Offset = "0x28CC5A0", VA = "0x1828CD1A0")]
		internal IDNCMDFMLAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class XJKUNXSJRFU : VCZKYJPAIXS
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28D55D0", Offset = "0x28D49D0", VA = "0x1828D55D0")]
		internal XJKUNXSJRFU()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public readonly struct NamedType : IEquatable<NamedType>, XLJSAODWXND<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public readonly HRQTZSPCIJP Type;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
		private NamedType(string name, HRQTZSPCIJP type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2806940", Offset = "0x2805D40", VA = "0x182806940")]
		public static NamedType New(string name, HRQTZSPCIJP type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x28D0550", Offset = "0x28CF950", VA = "0x1828D0550")]
		public static bool ZWISVWGZSLY([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x28D0550", Offset = "0x28CF950", VA = "0x1828D0550", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x28D0550", Offset = "0x28CF950", VA = "0x1828D0550")]
		public bool XFFAACZDUDS([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x28D04A0", Offset = "0x28CF8A0", VA = "0x1828D04A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x28D05A0", Offset = "0x28CF9A0", VA = "0x1828D05A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28D0610", Offset = "0x28CFA10", VA = "0x1828D0610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x28D0650", Offset = "0x28CFA50", VA = "0x1828D0650")]
		public string UJSCJMDNNAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x28D0690", Offset = "0x28CFA90", VA = "0x1828D0690")]
		public string WDLDXIBNHJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x28D0550", Offset = "0x28CF950", VA = "0x1828D0550", Slot = "5")]
		private bool UCDSUODIFUR([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public interface ZVRVTWCRUTF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, RAGLFGQXJZI>> POBPBVGIKFU(VLXCXCSSZAI a, bool b);
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
