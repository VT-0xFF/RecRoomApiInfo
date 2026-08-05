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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC2960", Offset = "0x2BC1560", VA = "0x182BC2960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC2870", Offset = "0x2BC1470", VA = "0x182BC2870", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PVSYFVSHADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5F50", Offset = "0x2BC4B50", VA = "0x182BC5F50")]
		public static bool YYLVHLNLCLX(this VEGTAJZNKQL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5E90", Offset = "0x2BC4A90", VA = "0x182BC5E90")]
		public static bool YYLVHLNLCLX(this ZBZPANTDQLE a)
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
			private readonly HATGOKICMKB _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			public EVRequest(HATGOKICMKB staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class PDXAAMNGZRS
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<VFFMGBNUIJR>, QQECGMVDKJQ> HFXKAGXBWWJ;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<VFFMGBNUIJR>>? CJDBBHHOUPX;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<VFFMGBNUIJR> JHEYGCJFVJV;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<VFFMGBNUIJR> WQGAYJOXOFS;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<VFFMGBNUIJR> DZXXTZNZYMD;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<VFFMGBNUIJR> ZKWXAULZLZI;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<VFFMGBNUIJR> CFZLUGWBGLJ;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<VFFMGBNUIJR> LQAXEGFYDJC;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<VFFMGBNUIJR> VYTOVPKCEMS;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<VFFMGBNUIJR> JOHGNMTMUXE;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<VFFMGBNUIJR> WHSMKQEYURU;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<VFFMGBNUIJR> EROODFHEWJY;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<VFFMGBNUIJR> QRUOQJCBIDC;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<VFFMGBNUIJR> AIVZBDTNALS;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<VFFMGBNUIJR> QVVBEUJDIWJ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<VFFMGBNUIJR> ZAPFXDXTOJF;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<VFFMGBNUIJR> XOLWVSDGTIL;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<VFFMGBNUIJR> HPSBHYTTDQM;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<VFFMGBNUIJR> QUHLDJIWZGX;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<VFFMGBNUIJR> OMSENQKLRAB;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<VFFMGBNUIJR> DCNVELQMHJM;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<VFFMGBNUIJR> SWVFFDCSFSF;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<VFFMGBNUIJR> HAKKZRTPJHC;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<VFFMGBNUIJR> FSXZOHXJETX;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<VFFMGBNUIJR> MNPEPKKMUNZ;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<VFFMGBNUIJR> YQWGMZKXDCQ;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<VFFMGBNUIJR> QPEATKVTDIE;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<VFFMGBNUIJR> POSQJHLBRCP;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<VFFMGBNUIJR> YXAWVQIQQWC;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<VFFMGBNUIJR> PGQTCTSMVGD;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<VFFMGBNUIJR> MANFROPITTR;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<VFFMGBNUIJR> ICXHHBZAIKV;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<VFFMGBNUIJR> HQONTETUGBB;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<VFFMGBNUIJR> DNTIDSSYBJE;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<VFFMGBNUIJR> XASQRJBNUTP;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<VFFMGBNUIJR> JUWIFZYKURV;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<VFFMGBNUIJR> JOWYBAXXBOX;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<VFFMGBNUIJR> YVCRGXALJZG;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<VFFMGBNUIJR> DECTOVFNDYF;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<VFFMGBNUIJR> SVDJVCMSUIO;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<VFFMGBNUIJR> CGVYPFBPBPE;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<VFFMGBNUIJR> UZJZDLMEPAW;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<VFFMGBNUIJR> WWNRCTDPFVX;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<VFFMGBNUIJR> TDAWWHOVDBX;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<VFFMGBNUIJR> CCCAZPUHPIG;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<VFFMGBNUIJR> TABUQHJOQLL;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<VFFMGBNUIJR> FGFCCSQEUWB;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<VFFMGBNUIJR> ITCXSXZDJUD;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<VFFMGBNUIJR> LKBEIXIMTPQ;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<VFFMGBNUIJR> SNXBIEQOQUU;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<VFFMGBNUIJR> PTFXKCPHHQS;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<VFFMGBNUIJR> MNUXCVPFZOP;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<VFFMGBNUIJR> UUDQYSEQKIH;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<VFFMGBNUIJR> YAZHFZKQSMU;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<VFFMGBNUIJR> DHSDQIPNUZN;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<VFFMGBNUIJR> OLYJLFYEPYZ;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<VFFMGBNUIJR> NGOVRCXEZKM;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<VFFMGBNUIJR> QUZWFHNNFYC;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<VFFMGBNUIJR> DBQJBNCXGJE;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<VFFMGBNUIJR> HNZPMRKPTBU;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<VFFMGBNUIJR> WWPJHQUDAMN;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<VFFMGBNUIJR> SVEGNBMNQSU;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<VFFMGBNUIJR> FJLIDXJBKAW;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<VFFMGBNUIJR> IHKNBFTKGJI;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<VFFMGBNUIJR> KBMIWOYKVHX;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<VFFMGBNUIJR> SPOLNETVMSP;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<VFFMGBNUIJR> RIAKLWSEVTA;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<VFFMGBNUIJR> TKGSWJNBITT;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<VFFMGBNUIJR> YPBXJWBRHIO;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<VFFMGBNUIJR> HLUTLLTGOGE;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<VFFMGBNUIJR> LQRSIXNHFGW;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<VFFMGBNUIJR>, QQECGMVDKJQ> CFXIPLNIDJQ
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC29E0", Offset = "0x2BC15E0", VA = "0x182BC29E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2DD0", Offset = "0x2BC19D0", VA = "0x182BC2DD0")]
			public static QQECGMVDKJQ WLHQEUBUFGK(Id32<VFFMGBNUIJR> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2D40", Offset = "0x2BC1940", VA = "0x182BC2D40")]
			public static bool TDPGEFGDKZN(Id32<VFFMGBNUIJR> id, [Out] QQECGMVDKJQ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2A30", Offset = "0x2BC1630", VA = "0x182BC2A30")]
			public static VEGTAJZNKQL JGGRXALQOWL(Id32<VFFMGBNUIJR> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2CB0", Offset = "0x2BC18B0", VA = "0x182BC2CB0")]
			private static Id32<VFFMGBNUIJR> SIFQFAPRLAF(QQECGMVDKJQ a, Id32<VFFMGBNUIJR> id)
			{
				return default(Id32<VFFMGBNUIJR>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2AE0", Offset = "0x2BC16E0", VA = "0x182BC2AE0")]
			private static void MNSPOKWSFLL(Id32<VFFMGBNUIJR> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class KHJEOHAUXZJ
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<BTONDMOTLQL, VEGTAJZNKQL?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x12B8AE0", Offset = "0x12B76E0", VA = "0x1812B8AE0")]
				private TypeRegistryFactory([In] IdUnsafeList<BTONDMOTLQL, VEGTAJZNKQL?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDDB0", Offset = "0x2BCC9B0", VA = "0x182BCDDB0")]
				public static TypeRegistryFactory SIUHUEYRRON()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD870", Offset = "0x2BCC470", VA = "0x182BCD870")]
				public (ReadOnlyIdArray<BTONDMOTLQL, VEGTAJZNKQL>, IReadOnlyDictionary<VEGTAJZNKQL, Id32<BTONDMOTLQL>>) CLJSAMBXECZ()
				{
					return default((ReadOnlyIdArray<BTONDMOTLQL, VEGTAJZNKQL>, IReadOnlyDictionary<VEGTAJZNKQL, Id32<BTONDMOTLQL>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDBE0", Offset = "0x2BCC7E0", VA = "0x182BCDBE0")]
				public Id32<BTONDMOTLQL> DPQAECQDNXZ(int a, VEGTAJZNKQL b)
				{
					return default(Id32<BTONDMOTLQL>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDD60", Offset = "0x2BCC960", VA = "0x182BCDD60")]
				public Id32<BTONDMOTLQL> Initialize(int id, TNBFVZCFSMI type, TNBFVZCFSMI factoryType)
				{
					return default(Id32<BTONDMOTLQL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class AMLXGLSOIOO
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<BTONDMOTLQL> JDVUCFKZTJL
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2BB0320", Offset = "0x2BAEF20", VA = "0x182BB0320")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BB02E0", Offset = "0x2BAEEE0", VA = "0x182BB02E0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<BTONDMOTLQL> KDORFLEVGDT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BB03E0", Offset = "0x2BAEFE0", VA = "0x182BB03E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BB0260", Offset = "0x2BAEE60", VA = "0x182BB0260")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<BTONDMOTLQL> ZMYHXNSRVKK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BB0220", Offset = "0x2BAEE20", VA = "0x182BB0220")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BB03A0", Offset = "0x2BAEFA0", VA = "0x182BB03A0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<BTONDMOTLQL> AIDXYMHVXIQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BB04A0", Offset = "0x2BAF0A0", VA = "0x182BB04A0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BB01E0", Offset = "0x2BAEDE0", VA = "0x182BB01E0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<BTONDMOTLQL> ZZCSQXARUNG
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BB0420", Offset = "0x2BAF020", VA = "0x182BB0420")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BB02A0", Offset = "0x2BAEEA0", VA = "0x182BB02A0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<BTONDMOTLQL> IFIPAJRQFSN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BB0360", Offset = "0x2BAEF60", VA = "0x182BB0360")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BB0460", Offset = "0x2BAF060", VA = "0x182BB0460")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class RDXXLXQDPHO : IEnumerable<VEGTAJZNKQL>, IEnumerable, IEnumerator<VEGTAJZNKQL>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private VEGTAJZNKQL PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int DQGTEBFWJSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool HOCHNJQTKHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool DIAHWDLTVHY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion GQZDLBWCUUV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion XUBJYUKIRGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool SHZZSLYCUFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool LASZYFZJHVH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool EWEVZGMUWVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool FNHSJITVSCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool JHBAXMVXTHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool KJULOVPKCFT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool DHLFHZMSIDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool AHBPHCLEXEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<VEGTAJZNKQL> MOIGOWZIHVC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private VEGTAJZNKQL NTJDUTBGLVL;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private VEGTAJZNKQL FZYSWFSGJDK
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
				[DebuggerHidden]
				public RDXXLXQDPHO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD790", Offset = "0x2BCC390", VA = "0x182BCD790", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD3A0", Offset = "0x2BCBFA0", VA = "0x182BCD3A0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD820", Offset = "0x2BCC420", VA = "0x182BCD820")]
				private void SYBUDUAVPHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD360", Offset = "0x2BCBF60", VA = "0x182BCD360", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD2A0", Offset = "0x2BCBEA0", VA = "0x182BCD2A0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VEGTAJZNKQL> AUTAPBQAWIH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD2A0", Offset = "0x2BCBEA0", VA = "0x182BCD2A0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator IEVKUCCAWWZ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class XDRFKWFTPSK : IEnumerable<VEGTAJZNKQL>, IEnumerable, IEnumerator<VEGTAJZNKQL>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private VEGTAJZNKQL PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int DQGTEBFWJSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion GQZDLBWCUUV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion XUBJYUKIRGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool EWEVZGMUWVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool FNHSJITVSCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool SHZZSLYCUFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool LASZYFZJHVH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool FTOYTVPJCOY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool EMBICSMOCZT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool JHBAXMVXTHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool KJULOVPKCFT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool IUEJNIKCEOQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool GYVXUILGATK;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private VEGTAJZNKQL FZYSWFSGJDK
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
				[DebuggerHidden]
				public XDRFKWFTPSK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCEEE0", Offset = "0x2BCDAE0", VA = "0x182BCEEE0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BCEEA0", Offset = "0x2BCDAA0", VA = "0x182BCEEA0", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BCEDF0", Offset = "0x2BCD9F0", VA = "0x182BCEDF0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VEGTAJZNKQL> AUTAPBQAWIH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BCEDF0", Offset = "0x2BCD9F0", VA = "0x182BCEDF0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator IEVKUCCAWWZ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class IZONBDAVOGV : IEnumerable<Id32<BTONDMOTLQL>>, IEnumerable, IEnumerator<Id32<BTONDMOTLQL>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<BTONDMOTLQL> PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int DQGTEBFWJSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion GQZDLBWCUUV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion XUBJYUKIRGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool SHZZSLYCUFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool LASZYFZJHVH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool EWEVZGMUWVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool FNHSJITVSCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool JHBAXMVXTHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool KJULOVPKCFT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool DHLFHZMSIDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool AHBPHCLEXEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<VEGTAJZNKQL> MOIGOWZIHVC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<TNBFVZCFSMI> MOYBGRHAKDD;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<BTONDMOTLQL> LUCVNSRNOBR
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC430", VA = "0x180DDD830", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2BB6860", Offset = "0x2BB5460", VA = "0x182BB6860", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15B82D0", Offset = "0x15B6ED0", VA = "0x1815B82D0")]
				[DebuggerHidden]
				public IZONBDAVOGV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6DF0", Offset = "0x2BB59F0", VA = "0x182BB6DF0", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BB68F0", Offset = "0x2BB54F0", VA = "0x182BB68F0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6F90", Offset = "0x2BB5B90", VA = "0x182BB6F90")]
				private void SYBUDUAVPHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6F40", Offset = "0x2BB5B40", VA = "0x182BB6F40")]
				private void SXLZLZTDMZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BB68B0", Offset = "0x2BB54B0", VA = "0x182BB68B0", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BB67B0", Offset = "0x2BB53B0", VA = "0x182BB67B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<BTONDMOTLQL>> BULKHCZYHKY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BB67B0", Offset = "0x2BB53B0", VA = "0x182BB67B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator IEVKUCCAWWZ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log KZEIFDHBWKO;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<BTONDMOTLQL, VEGTAJZNKQL?> HOEXAFIUHBO;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<VEGTAJZNKQL, Id32<BTONDMOTLQL>> QUVAJRPHMEM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly ZBZPANTDQLE OAPDPGIGAUV;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly ZBZPANTDQLE FPVKKHBYEOJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<VEGTAJZNKQL> QDKOETVZRLZ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<VEGTAJZNKQL> PPAFCQRDWVA;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet UOHZDLBDPZN
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet NFZOGUWIALR
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet XKPOLRYRYDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static VEGTAJZNKQL JDVUCFKZTJL
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9410", Offset = "0x2BB8010", VA = "0x182BB9410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static VEGTAJZNKQL KDORFLEVGDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9DE0", Offset = "0x2BB89E0", VA = "0x182BB9DE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static VEGTAJZNKQL ZMYHXNSRVKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7590", Offset = "0x2BB6190", VA = "0x182BB7590")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static VEGTAJZNKQL AIDXYMHVXIQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB060", Offset = "0x2BB9C60", VA = "0x182BBB060")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static VEGTAJZNKQL QCGTEQJVGWG
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9290", Offset = "0x2BB7E90", VA = "0x182BB9290")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static VEGTAJZNKQL PQZTUYSLRLX
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9320", Offset = "0x2BB7F20", VA = "0x182BB9320")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static VEGTAJZNKQL AMCXUYMWOXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BB90F0", Offset = "0x2BB7CF0", VA = "0x182BB90F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static VEGTAJZNKQL ZZCSQXARUNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA4D0", Offset = "0x2BB90D0", VA = "0x182BBA4D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static TNBFVZCFSMI ZXWHWWDJOZC
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9740", Offset = "0x2BB8340", VA = "0x182BB9740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static TNBFVZCFSMI BWZEOHOKMFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAFB0", Offset = "0x2BB9BB0", VA = "0x182BBAFB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static TNBFVZCFSMI BCFMICGUCDG
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA0E0", Offset = "0x2BB8CE0", VA = "0x182BBA0E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static TNBFVZCFSMI VDVAOISFDTE
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9240", Offset = "0x2BB7E40", VA = "0x182BB9240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static TNBFVZCFSMI CJQTOBRIMDY
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7DC0", Offset = "0x2BB69C0", VA = "0x182BB7DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static TNBFVZCFSMI FODFIXYRFIV
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9790", Offset = "0x2BB8390", VA = "0x182BB9790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static TNBFVZCFSMI TMSTVOWNBOF
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB87E0", Offset = "0x2BB73E0", VA = "0x182BB87E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static TNBFVZCFSMI AQNGVRSESTH
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7E40", Offset = "0x2BB6A40", VA = "0x182BB7E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static TNBFVZCFSMI ZYVHYFMOFCI
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7680", Offset = "0x2BB6280", VA = "0x182BB7680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static TNBFVZCFSMI XKCGXRRDSZK
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA480", Offset = "0x2BB9080", VA = "0x182BBA480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static TNBFVZCFSMI XGPHSLFGRXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BB76D0", Offset = "0x2BB62D0", VA = "0x182BB76D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static TNBFVZCFSMI WGKBXSUBXTT
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BB73C0", Offset = "0x2BB5FC0", VA = "0x182BB73C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static TNBFVZCFSMI WLJQXGMCGXZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9840", Offset = "0x2BB8440", VA = "0x182BB9840")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static TNBFVZCFSMI LHAHOMIHQGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAEF0", Offset = "0x2BB9AF0", VA = "0x182BBAEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static TNBFVZCFSMI GNTROMJRJHG
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BB83E0", Offset = "0x2BB6FE0", VA = "0x182BB83E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static TNBFVZCFSMI TPLSNPKHRHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA6E0", Offset = "0x2BB92E0", VA = "0x182BBA6E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static TNBFVZCFSMI ZLEILDDONWD
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7410", Offset = "0x2BB6010", VA = "0x182BB7410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static TNBFVZCFSMI DQKCBTYGOIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8FD0", Offset = "0x2BB7BD0", VA = "0x182BB8FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static TNBFVZCFSMI XBHEJMFNAQN
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7FB0", Offset = "0x2BB6BB0", VA = "0x182BB7FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static TNBFVZCFSMI XZQBBIMKUAN
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB2D0", Offset = "0x2BB9ED0", VA = "0x182BBB2D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static TNBFVZCFSMI UMSBPFSWKTC
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8D90", Offset = "0x2BB7990", VA = "0x182BB8D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static TNBFVZCFSMI YFPBYPRBHUF
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA080", Offset = "0x2BB8C80", VA = "0x182BBA080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static TNBFVZCFSMI WMKWYIBLLIL
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB79F0", Offset = "0x2BB65F0", VA = "0x182BB79F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static TNBFVZCFSMI NIRCELJTWNT
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9C00", Offset = "0x2BB8800", VA = "0x182BB9C00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static TNBFVZCFSMI OZHJOKAQWDH
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8F10", Offset = "0x2BB7B10", VA = "0x182BB8F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static TNBFVZCFSMI EJMGVJYHKGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7050", Offset = "0x2BB5C50", VA = "0x182BB7050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static TNBFVZCFSMI MLGZIFSKJSN
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8890", Offset = "0x2BB7490", VA = "0x182BB8890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static TNBFVZCFSMI JZAJSMUKSXB
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA620", Offset = "0x2BB9220", VA = "0x182BBA620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static TNBFVZCFSMI OJQLAZSMQED
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7990", Offset = "0x2BB6590", VA = "0x182BB7990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static TNBFVZCFSMI UISFYVSGKUE
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9560", Offset = "0x2BB8160", VA = "0x182BB9560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static TNBFVZCFSMI ARKVVITRUVU
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BB80D0", Offset = "0x2BB6CD0", VA = "0x182BB80D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static TNBFVZCFSMI LXRSJJVGENR
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB150", Offset = "0x2BB9D50", VA = "0x182BBB150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static TNBFVZCFSMI LEXVYTLZPMQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9D20", Offset = "0x2BB8920", VA = "0x182BB9D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static TNBFVZCFSMI XQKRRKTUURD
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8F70", Offset = "0x2BB7B70", VA = "0x182BB8F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static TNBFVZCFSMI YVZDGXCQBSS
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA3C0", Offset = "0x2BB8FC0", VA = "0x182BBA3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static TNBFVZCFSMI RORKAXTNPOA
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9CC0", Offset = "0x2BB88C0", VA = "0x182BB9CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static TNBFVZCFSMI DQOTWQSOJDE
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA5C0", Offset = "0x2BB91C0", VA = "0x182BBA5C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static TNBFVZCFSMI XFDSDSXMDOZ
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7E90", Offset = "0x2BB6A90", VA = "0x182BB7E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static TNBFVZCFSMI BZIGXWYRUJL
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9180", Offset = "0x2BB7D80", VA = "0x182BB9180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static TNBFVZCFSMI JNTAVKZWHUI
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8190", Offset = "0x2BB6D90", VA = "0x182BB8190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static TNBFVZCFSMI CWLLIXQRRNY
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7720", Offset = "0x2BB6320", VA = "0x182BB7720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static TNBFVZCFSMI BYDWBTCSUPK
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9FC0", Offset = "0x2BB8BC0", VA = "0x182BB9FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static TNBFVZCFSMI EQBOJSFUEEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAE30", Offset = "0x2BB9A30", VA = "0x182BBAE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static TNBFVZCFSMI ICWUTYODGQD
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9F60", Offset = "0x2BB8B60", VA = "0x182BB9F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static TNBFVZCFSMI GPHOVUYZWQN
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BB74D0", Offset = "0x2BB60D0", VA = "0x182BB74D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static TNBFVZCFSMI RODABPYHJSI
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7A50", Offset = "0x2BB6650", VA = "0x182BB7A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static TNBFVZCFSMI ODYEIPZANLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BB71F0", Offset = "0x2BB5DF0", VA = "0x182BB71F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static TNBFVZCFSMI VIWUXXDLFHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA880", Offset = "0x2BB9480", VA = "0x182BBA880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static TNBFVZCFSMI AJEMYCMNFBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB0F0", Offset = "0x2BB9CF0", VA = "0x182BBB0F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static TNBFVZCFSMI VVMREWSKPUU
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7190", Offset = "0x2BB5D90", VA = "0x182BB7190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static TNBFVZCFSMI DRIFHMTHRUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BB77B0", Offset = "0x2BB63B0", VA = "0x182BB77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static TNBFVZCFSMI WQTBEYKRLCK
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB81F0", Offset = "0x2BB6DF0", VA = "0x182BB81F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static TNBFVZCFSMI CVWOMUHRPRD
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB72B0", Offset = "0x2BB5EB0", VA = "0x182BB72B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static TNBFVZCFSMI CIGKPVDXOUM
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB000", Offset = "0x2BB9C00", VA = "0x182BBB000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static TNBFVZCFSMI VOYHCCIFTTX
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB93B0", Offset = "0x2BB7FB0", VA = "0x182BB93B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static TNBFVZCFSMI QRURRZOLJQR
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA300", Offset = "0x2BB8F00", VA = "0x182BBA300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static TNBFVZCFSMI PEQEUVLKPPP
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9890", Offset = "0x2BB8490", VA = "0x182BB9890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static TNBFVZCFSMI YVWNBQINHDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7B80", Offset = "0x2BB6780", VA = "0x182BB7B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static TNBFVZCFSMI RKOWENXUAWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BB96E0", Offset = "0x2BB82E0", VA = "0x182BB96E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static TNBFVZCFSMI FONEWFWENEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA420", Offset = "0x2BB9020", VA = "0x182BBA420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static TNBFVZCFSMI DIPOJJDTJFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA940", Offset = "0x2BB9540", VA = "0x182BBA940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static TNBFVZCFSMI SNTWEGKBZZA
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BB70B0", Offset = "0x2BB5CB0", VA = "0x182BB70B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static TNBFVZCFSMI IVOTTAEXACT
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA020", Offset = "0x2BB8C20", VA = "0x182BBA020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static TNBFVZCFSMI QTFUHHBKNNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8070", Offset = "0x2BB6C70", VA = "0x182BB8070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static TNBFVZCFSMI ENLCXJCFQEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7AB0", Offset = "0x2BB66B0", VA = "0x182BB7AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static TNBFVZCFSMI VPLJJQQOOLF
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BB84A0", Offset = "0x2BB70A0", VA = "0x182BB84A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static TNBFVZCFSMI YJUKCFMWOBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8830", Offset = "0x2BB7430", VA = "0x182BB8830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static TNBFVZCFSMI STWBGCCOGHJ
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB91E0", Offset = "0x2BB7DE0", VA = "0x182BB91E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static TNBFVZCFSMI CJUUXOGCLEO
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8440", Offset = "0x2BB7040", VA = "0x182BB8440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static TNBFVZCFSMI XUCBHKAUVQC
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9680", Offset = "0x2BB8280", VA = "0x182BB9680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static TNBFVZCFSMI DIGKOJQNRFM
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB210", Offset = "0x2BB9E10", VA = "0x182BBB210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static TNBFVZCFSMI YMPZPZETYEL
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB95C0", Offset = "0x2BB81C0", VA = "0x182BB95C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static TNBFVZCFSMI LEATWYXCKAS
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9C60", Offset = "0x2BB8860", VA = "0x182BB9C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static TNBFVZCFSMI SDJVHRWHCOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8010", Offset = "0x2BB6C10", VA = "0x182BB8010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static TNBFVZCFSMI WITIUVNCQCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7CA0", Offset = "0x2BB68A0", VA = "0x182BB7CA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static TNBFVZCFSMI LVAKDEALZGF
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7EF0", Offset = "0x2BB6AF0", VA = "0x182BB7EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static TNBFVZCFSMI HUWDVYSJQME
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BBADD0", Offset = "0x2BB99D0", VA = "0x182BBADD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static TNBFVZCFSMI AGEINPTLOZB
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAE90", Offset = "0x2BB9A90", VA = "0x182BBAE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static TNBFVZCFSMI JFICDMNVTKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7D00", Offset = "0x2BB6900", VA = "0x182BB7D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static TNBFVZCFSMI UBARYDRZGNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAF50", Offset = "0x2BB9B50", VA = "0x182BBAF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static TNBFVZCFSMI PNHVDJOGMMO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7250", Offset = "0x2BB5E50", VA = "0x182BB7250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static TNBFVZCFSMI TWADPSNKLSD
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8380", Offset = "0x2BB6F80", VA = "0x182BB8380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static TNBFVZCFSMI GDBVVBHMZKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7470", Offset = "0x2BB6070", VA = "0x182BB7470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static TNBFVZCFSMI TQTZOAVQRLP
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA360", Offset = "0x2BB8F60", VA = "0x182BBA360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static TNBFVZCFSMI JYWZHFSYGOB
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7930", Offset = "0x2BB6530", VA = "0x182BB7930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static TNBFVZCFSMI RZQWWJWBVAF
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB270", Offset = "0x2BB9E70", VA = "0x182BBB270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static TNBFVZCFSMI IIMQHGWZEYN
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB94A0", Offset = "0x2BB80A0", VA = "0x182BB94A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static TNBFVZCFSMI TKQKIWAAKNP
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8EB0", Offset = "0x2BB7AB0", VA = "0x182BB8EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static TNBFVZCFSMI QHNKDCHCATW
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7810", Offset = "0x2BB6410", VA = "0x182BB7810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static TNBFVZCFSMI HTYTFXEJOCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8DF0", Offset = "0x2BB79F0", VA = "0x182BB8DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static TNBFVZCFSMI OMAZXPYJTDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA680", Offset = "0x2BB9280", VA = "0x182BBA680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static TNBFVZCFSMI AAUUHPAOOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7BE0", Offset = "0x2BB67E0", VA = "0x182BB7BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static TNBFVZCFSMI FWFPAWHKTOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7D60", Offset = "0x2BB6960", VA = "0x182BB7D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static TNBFVZCFSMI TATMUNYHWFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA190", Offset = "0x2BB8D90", VA = "0x182BBA190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static TNBFVZCFSMI RKIGSRCOYFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAA00", Offset = "0x2BB9600", VA = "0x182BBAA00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static TNBFVZCFSMI PWOJDLOJABG
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8E50", Offset = "0x2BB7A50", VA = "0x182BB8E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static TNBFVZCFSMI VPDXCVQBWQF
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9090", Offset = "0x2BB7C90", VA = "0x182BB9090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static TNBFVZCFSMI GJSSDEHLPAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA130", Offset = "0x2BB8D30", VA = "0x182BBA130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static TNBFVZCFSMI USJAHTUAGLX
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7530", Offset = "0x2BB6130", VA = "0x182BB7530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static TNBFVZCFSMI SMBYHBZFSVP
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA8E0", Offset = "0x2BB94E0", VA = "0x182BBA8E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static TNBFVZCFSMI LYTXKUEKBNT
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9500", Offset = "0x2BB8100", VA = "0x182BB9500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static TNBFVZCFSMI JMPSQHAMZAO
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8130", Offset = "0x2BB6D30", VA = "0x182BB8130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static TNBFVZCFSMI MXQXVAPDNWZ
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB1B0", Offset = "0x2BB9DB0", VA = "0x182BBB1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static TNBFVZCFSMI BOXBMLIZMOD
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7F50", Offset = "0x2BB6B50", VA = "0x182BB7F50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static TNBFVZCFSMI OYGYIYRWAXA
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9D80", Offset = "0x2BB8980", VA = "0x182BB9D80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static TNBFVZCFSMI MYBOOLUGJWD
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BB97E0", Offset = "0x2BB83E0", VA = "0x182BB97E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static TNBFVZCFSMI PUAAMTIIZRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7870", Offset = "0x2BB6470", VA = "0x182BB7870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static TNBFVZCFSMI XTJWMPBNPGZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB3B0", Offset = "0x2BB9FB0", VA = "0x182BBB3B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static TNBFVZCFSMI NJMTXTQXNBV
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BB78D0", Offset = "0x2BB64D0", VA = "0x182BB78D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static TNBFVZCFSMI IGQGGQLLXWS
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA560", Offset = "0x2BB9160", VA = "0x182BBA560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static TNBFVZCFSMI ZGWXZREQDMU
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BB98F0", Offset = "0x2BB84F0", VA = "0x182BB98F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static TNBFVZCFSMI SHPYTERLHEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8D30", Offset = "0x2BB7930", VA = "0x182BB8D30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static TNBFVZCFSMI KDKANYSJGZI
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA740", Offset = "0x2BB9340", VA = "0x182BBA740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static TNBFVZCFSMI SCTRJBBYYVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9030", Offset = "0x2BB7C30", VA = "0x182BB9030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static TNBFVZCFSMI KLUOTJCCWGR
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA2A0", Offset = "0x2BB8EA0", VA = "0x182BBA2A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static TNBFVZCFSMI HEJZMMLIOAL
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7620", Offset = "0x2BB6220", VA = "0x182BB7620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static TNBFVZCFSMI FPLSZTDHQXP
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7C40", Offset = "0x2BB6840", VA = "0x182BB7C40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static TNBFVZCFSMI SMCKRLJDROH
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA9A0", Offset = "0x2BB95A0", VA = "0x182BBA9A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static TNBFVZCFSMI KRRSADYUZME
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9620", Offset = "0x2BB8220", VA = "0x182BB9620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9E70", Offset = "0x2BB8A70", VA = "0x182BB9E70")]
			public static ZBZPANTDQLE QPKINSDDNAG([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BBA7D0", Offset = "0x2BB93D0", VA = "0x182BBA7D0")]
			public static ClassFactoryTypeParams URGDCGFIKFJ(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BBA7A0", Offset = "0x2BB93A0", VA = "0x182BBA7A0")]
			public static ClassFactoryTypeParams URGDCGFIKFJ([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7E10", Offset = "0x2BB6A10", VA = "0x182BB7E10")]
			public static ZBZPANTDQLE FSWXVAFXKOE(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7780", Offset = "0x2BB6380", VA = "0x182BB7780")]
			public static ZBZPANTDQLE CUHUJNPCWNT(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8250", Offset = "0x2BB6E50", VA = "0x182BB8250")]
			public static ZBZPANTDQLE IFIPAJRQFSN([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BB89A0", Offset = "0x2BB75A0", VA = "0x182BB89A0")]
			public static VEGTAJZNKQL JGGRXALQOWL(Id32<BTONDMOTLQL> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7110", Offset = "0x2BB5D10", VA = "0x182BB7110")]
			public static string AIIPAENTZYQ(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8A50", Offset = "0x2BB7650", VA = "0x182BB8A50")]
			private static VEGTAJZNKQL JGGRXALQOWL(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7B10", Offset = "0x2BB6710", VA = "0x182BB7B10")]
			public static Id32<BTONDMOTLQL>? ENSCPUANBDY(VEGTAJZNKQL a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBAA60", Offset = "0x2BB9660", VA = "0x182BBAA60")]
			public static CircuitTypeIdWrapper? WHCNZQALZXP(VEGTAJZNKQL a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB410", Offset = "0x2BBA010", VA = "0x182BBB410")]
			static KHJEOHAUXZJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBA1F0", Offset = "0x2BB8DF0", VA = "0x182BBA1F0")]
			[IteratorStateMachine(typeof(XDRFKWFTPSK))]
			private static IEnumerable<VEGTAJZNKQL> RWVKBCSYTVB(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7310", Offset = "0x2BB5F10", VA = "0x182BB7310")]
			[IteratorStateMachine(typeof(RDXXLXQDPHO))]
			public static IEnumerable<VEGTAJZNKQL> BNBGCNUAPAG(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9950", Offset = "0x2BB8550", VA = "0x182BB9950")]
			public static Variant PRJQWROVUWH(VEGTAJZNKQL a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8500", Offset = "0x2BB7100", VA = "0x182BB8500")]
			public static Variant ITDXUXXDHAC(VEGTAJZNKQL a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB330", Offset = "0x2BB9F30", VA = "0x182BBB330")]
			public static bool YZSVBGZXJUK(VEGTAJZNKQL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB88F0", Offset = "0x2BB74F0", VA = "0x182BB88F0")]
			[IteratorStateMachine(typeof(IZONBDAVOGV))]
			public static IEnumerable<Id32<BTONDMOTLQL>> JCAFEHLJPYI(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AYZHVODWYMU
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BB04E0", Offset = "0x2BAF0E0", VA = "0x182BB04E0")]
		public static NOKOMIYTNQH GHRXOLGFAHI(this VEGTAJZNKQL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BB15C0", Offset = "0x2BB01C0", VA = "0x182BB15C0")]
		public static VEGTAJZNKQL GTHJBIMUMZN(this NOKOMIYTNQH a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class COXGBVPOZCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37E24A0", Offset = "0x37E10A0", VA = "0x1837E24A0")]
		public static Dictionary<b, c> KBDKYLGAIEX<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class YTVCBOINGZA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0DF0", Offset = "0x2BCF9F0", VA = "0x182BD0DF0")]
		public static RYGSTCASHAB GHRXOLGFAHI([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0EF0", Offset = "0x2BCFAF0", VA = "0x182BD0EF0")]
		public static Guid GTHJBIMUMZN(RYGSTCASHAB a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class HYFBSXDIVMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5F20", Offset = "0x2BB4B20", VA = "0x182BB5F20")]
		public static TJFYKXONFEJ GHRXOLGFAHI([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5FB0", Offset = "0x2BB4BB0", VA = "0x182BB5FB0")]
		public static NamedType GTHJBIMUMZN(this TJFYKXONFEJ a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class IXCSXYCNXTN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3B985B0", Offset = "0x3B971B0", VA = "0x183B985B0")]
		public static void MUVYHJYTERV<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3B98810", Offset = "0x3B97410", VA = "0x183B98810")]
		public static void MUVYHJYTERV<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class COLQZAJKJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2850", Offset = "0x2BB1450", VA = "0x182BB2850")]
		public static JNFXEWUIKCF GHRXOLGFAHI([In] this Variant self, VEGTAJZNKQL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2A50", Offset = "0x2BB1650", VA = "0x182BB2A50")]
		public static Variant GTHJBIMUMZN(this JNFXEWUIKCF a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HMFNZMVBYOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<WKKAYCGFMFC> PJJRKHCGOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool HGEZMPEXVSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool TAOFIUAYRKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool ZHLVERRXPGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool OQYWOKOVXZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool OQTPRDUYONR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool LCTTZDNLNCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool QINAHNDQPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool MEBCOVTYZFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, VEGTAJZNKQL Type)> MSAGJDRTGHI;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid JQCTFOCWOYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B77A30", Offset = "0x2B76630", VA = "0x182B77A30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<WKKAYCGFMFC> SFLWDPRYLST
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B77A30", Offset = "0x2B76630", VA = "0x182B77A30")]
			get
			{
				return default(Id128<WKKAYCGFMFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, VEGTAJZNKQL Type)> DNONVMTPCXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ITEZEMUNZLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5B40", Offset = "0x2BB4740", VA = "0x182BB5B40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5120", Offset = "0x2BB3D20", VA = "0x182BB5120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, VEGTAJZNKQL> AGBLGMIQBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BB56A0", Offset = "0x2BB42A0", VA = "0x182BB56A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BB54A0", Offset = "0x2BB40A0", VA = "0x182BB54A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> DNXEYHKISMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BB53F0", Offset = "0x2BB3FF0", VA = "0x182BB53F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5340", Offset = "0x2BB3F40", VA = "0x182BB5340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> MTFPSWSFHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5BE0", Offset = "0x2BB47E0", VA = "0x182BB5BE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5290", Offset = "0x2BB3E90", VA = "0x182BB5290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, VEGTAJZNKQL> FYVMNRXHCKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5C90", Offset = "0x2BB4890", VA = "0x182BB5C90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BB55F0", Offset = "0x2BB41F0", VA = "0x182BB55F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action NWKMBHZKVPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5750", Offset = "0x2BB4350", VA = "0x182BB5750")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5550", Offset = "0x2BB4150", VA = "0x182BB5550")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B2B290", Offset = "0x1B29E90", VA = "0x181B2B290")]
		public void ESTAQQMWWNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5E30", Offset = "0x2BB4A30", VA = "0x182BB5E30")]
		internal HMFNZMVBYOA([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, VEGTAJZNKQL Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BB58E0", Offset = "0x2BB44E0", VA = "0x182BB58E0")]
		public static CircuitEventDefinitionFactoryStart SIUHUEYRRON(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BB59B0", Offset = "0x2BB45B0", VA = "0x182BB59B0")]
		public static CircuitEventDefinitionFactoryStart SIUHUEYRRON(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5A30", Offset = "0x2BB4630", VA = "0x182BB5A30")]
		public static HMFNZMVBYOA UUZMWUWJJXZ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4DE0", Offset = "0x2BB39E0", VA = "0x182BB4DE0")]
		public static HMFNZMVBYOA CXDXVWVCAHH([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF00A30", Offset = "0xEFF630", VA = "0x180F00A30")]
		public void CLOMTVRFQYL(Id128<WKKAYCGFMFC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5230", Offset = "0x2BB3E30", VA = "0x182BB5230")]
		public void ESXUPNWLUIK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BB57F0", Offset = "0x2BB43F0", VA = "0x182BB57F0")]
		public void REGOMSKIHTQ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5D40", Offset = "0x2BB4940", VA = "0x182BB5D40")]
		public void ZQPGLPOYXBT(int a, VEGTAJZNKQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4CC0", Offset = "0x2BB38C0", VA = "0x182BB4CC0")]
		public void AATENAFVVRR(string a, VEGTAJZNKQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB51C0", Offset = "0x2BB3DC0", VA = "0x182BB51C0")]
		public void EBKIINBTYLG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5020", Offset = "0x2BB3C20", VA = "0x182BB5020")]
		public HMFNZMVBYOA Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2BB3100", Offset = "0x2BB1D00", VA = "0x182BB3100")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2F90", Offset = "0x2BB1B90", VA = "0x182BB2F90")]
		public CircuitEventDefinitionFactoryParams ZAJCCLRCUJX(string a, VEGTAJZNKQL b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2E60", Offset = "0x2BB1A60", VA = "0x182BB2E60")]
		public HMFNZMVBYOA CLJSAMBXECZ()
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
		private readonly List<(string Name, VEGTAJZNKQL Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2DD0", Offset = "0x2BB19D0", VA = "0x182BB2DD0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, VEGTAJZNKQL Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2CA0", Offset = "0x2BB18A0", VA = "0x182BB2CA0")]
		public CircuitEventDefinitionFactoryParams ZAJCCLRCUJX(string a, VEGTAJZNKQL b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2BA0", Offset = "0x2BB17A0", VA = "0x182BB2BA0")]
		public HMFNZMVBYOA CLJSAMBXECZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class VDHGWTZGZWV
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly HMFNZMVBYOA HGHPSLBTQZG;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly HMFNZMVBYOA KXITTKSDFXZ;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly HMFNZMVBYOA KPVZAUAKCOK;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly HMFNZMVBYOA EJKJBBZHSNB;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly HMFNZMVBYOA JDRELEGQBQU;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly HMFNZMVBYOA FGKAAXQBXJA;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly HMFNZMVBYOA QLAVOGIBJTL;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly HMFNZMVBYOA[] ARICSQHKZSC;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class WQGAYJOXOFS
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly HMFNZMVBYOA STMITLMLADK;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class DZXXTZNZYMD
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly HMFNZMVBYOA VUELNOZKPMU;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly HMFNZMVBYOA KTFKVOHAYHL;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class IHKNBFTKGJI
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly HMFNZMVBYOA CTAHXFIFYLX;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly HMFNZMVBYOA WKCMCBMMAMY;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly HMFNZMVBYOA[] KZZWRNAJOMA;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly HMFNZMVBYOA DABVGLCZRWE;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly HMFNZMVBYOA LBGXTCUDRAB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class LKBEIXIMTPQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly HMFNZMVBYOA NAHMTGLERUR;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly HMFNZMVBYOA YIXTDPUEBJO;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class CFZLUGWBGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly HMFNZMVBYOA RVHVQVXNHWI;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly HMFNZMVBYOA XDLNKUXFLLB;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class LQAXEGFYDJC
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly HMFNZMVBYOA VUELNOZKPMU;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly HMFNZMVBYOA KTFKVOHAYHL;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class VYTOVPKCEMS
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly HMFNZMVBYOA BEYRICPNSGT;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly HMFNZMVBYOA IBKYFNHILQA;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly HMFNZMVBYOA VTXYOPJDBJI;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly HMFNZMVBYOA SBWJPAQTXIA;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly HMFNZMVBYOA QUMVISBFRJB;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly HMFNZMVBYOA TGRVRBJHWQQ;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly HMFNZMVBYOA FVCKWOPRZLP;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class JOHGNMTMUXE
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class WHSMKQEYURU
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class CGVYPFBPBPE
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class EROODFHEWJY
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly HMFNZMVBYOA VNQOGGQLQEL;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly HMFNZMVBYOA KAKQSRBTOUQ;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class NGOVRCXEZKM
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class QRUOQJCBIDC
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class AIVZBDTNALS
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class ITCXSXZDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly HMFNZMVBYOA AGSKSVBSIJJ;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly HMFNZMVBYOA FXEYZTFEFWN;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly HMFNZMVBYOA QXSURNLCVKG;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly HMFNZMVBYOA FVGKQQPZYPR;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly HMFNZMVBYOA LPNUBYXGPUJ;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly HMFNZMVBYOA RVHVQVXNHWI;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly HMFNZMVBYOA IBXJJCAJKKB;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly HMFNZMVBYOA WLWHXWKWMBM;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly HMFNZMVBYOA NRYGDSBFKFO;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly HMFNZMVBYOA TJMMXOSWQKE;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly HMFNZMVBYOA LXHDRXBYGBU;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly HMFNZMVBYOA CHALRTSDWKE;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly HMFNZMVBYOA YPBHEFMFTZV;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly HMFNZMVBYOA JFUZNOAQKAC;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly HMFNZMVBYOA JIQLWDNIHQN;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly HMFNZMVBYOA APIFPVLMECJ;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly HMFNZMVBYOA BBRPOGISQHN;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly HMFNZMVBYOA RMQOHEUVKLK;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly HMFNZMVBYOA FOIXAPAJKTL;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly HMFNZMVBYOA LGBHVIIWEVJ;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly HMFNZMVBYOA BCXQDHNVWAK;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly HMFNZMVBYOA LGCIZGSFNOS;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly HMFNZMVBYOA LSETNKVYTQI;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly HMFNZMVBYOA RZTZBEJJACI;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly HMFNZMVBYOA RYNWFVVMFYY;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly HMFNZMVBYOA CIRMIZWALSM;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly HMFNZMVBYOA ASLRTOSJZFM;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly HMFNZMVBYOA MUXYZHMWJXQ;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly HMFNZMVBYOA GABOATNISKX;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly HMFNZMVBYOA PEHQRXUYICD;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly HMFNZMVBYOA ZUFROVEKFNU;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly HMFNZMVBYOA RJXYMHBWXMW;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly HMFNZMVBYOA NTFVCCPWVOP;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly HMFNZMVBYOA ODXYQJCZKFN;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly HMFNZMVBYOA QFJGIRKGCOP;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly HMFNZMVBYOA IABKTZFRTZR;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly HMFNZMVBYOA KBMSMHMYMIT;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly HMFNZMVBYOA DMKLKFJMDEB;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly HMFNZMVBYOA QVHJWZCCYTX;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly HMFNZMVBYOA ABBYEPDIQEZ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly HMFNZMVBYOA AEIZGXSLWCQ;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly HMFNZMVBYOA SOUIRRQJTQC;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly HMFNZMVBYOA HNBASMVKZVW;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly HMFNZMVBYOA YOFCCZYATEY;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly HMFNZMVBYOA FRQNUVWUVZC;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly HMFNZMVBYOA VPRLJDKLMYM;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly HMFNZMVBYOA LSNVHIQRTIK;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly HMFNZMVBYOA FZISFLEWWUO;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly HMFNZMVBYOA LWNHBJIORYC;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly HMFNZMVBYOA PENGDORRMEQ;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly HMFNZMVBYOA HSVEAQSAKBV;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly HMFNZMVBYOA GKIDKHGMBWQ;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly HMFNZMVBYOA IJSWBWVVBPI;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly HMFNZMVBYOA FLNHQFNXYEM;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly HMFNZMVBYOA QSCJAFHBUVO;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly HMFNZMVBYOA AMYWEGJZBMU;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly HMFNZMVBYOA YAOFBHPUJEA;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly HMFNZMVBYOA JQAIIMSZQUQ;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly HMFNZMVBYOA UXHHBYZCTFU;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly HMFNZMVBYOA MJJOEHPFYRA;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly HMFNZMVBYOA TOUPPBZOIXE;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly HMFNZMVBYOA TIZUPSQPCEU;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly HMFNZMVBYOA VQKVELNRLQT;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly HMFNZMVBYOA GURWPAGUUIU;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly HMFNZMVBYOA FGKNCHEREKA;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly HMFNZMVBYOA UHHWRQPMFQH;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly HMFNZMVBYOA LWZOKNOMPDL;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly HMFNZMVBYOA EZRMQAPJKIS;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly HMFNZMVBYOA RRGTQQGKUMM;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class ZAPFXDXTOJF
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class QPSIGHZRIDI
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly HMFNZMVBYOA GGGBARDRVJG;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly HMFNZMVBYOA PSUKVQHFCYN;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly HMFNZMVBYOA IYFDOUOZBYZ;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly HMFNZMVBYOA SOYZNHPMMTQ;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly HMFNZMVBYOA RPYGCKBDYQK;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly HMFNZMVBYOA GKVZHROJHVW;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly HMFNZMVBYOA ZUSGEUVTDMO;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class MBORCSYGCXF
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly HMFNZMVBYOA FXEYZTFEFWN;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly HMFNZMVBYOA QXSURNLCVKG;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly HMFNZMVBYOA FVGKQQPZYPR;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly HMFNZMVBYOA QFSUDPCBFLZ;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly HMFNZMVBYOA IYRJSQYTEML;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly HMFNZMVBYOA QJKPCJSIDFF;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly HMFNZMVBYOA RYPINPGHBUZ;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class XOLWVSDGTIL
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly HMFNZMVBYOA JZRCWQACOUB;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly HMFNZMVBYOA SHGGVFSCAER;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly HMFNZMVBYOA TRJVFLKBQPE;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly HMFNZMVBYOA NZRXSJEADZQ;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly HMFNZMVBYOA VBBAVNEUOIC;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly HMFNZMVBYOA BUAEEGFYTMI;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class HPSBHYTTDQM
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class QUHLDJIWZGX
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly HMFNZMVBYOA RNCJEBNRBWR;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class OMSENQKLRAB
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly HMFNZMVBYOA AGSKSVBSIJJ;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class DCNVELQMHJM
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class SWVFFDCSFSF
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class CCCAZPUHPIG
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly HMFNZMVBYOA FDIHHEOFZIC;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly HMFNZMVBYOA MBSDKTHAANC;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly HMFNZMVBYOA XIYJVDXJEZR;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly HMFNZMVBYOA WUMLXENKTDR;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class HAKKZRTPJHC
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly HMFNZMVBYOA FPJYRWOTFYR;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly HMFNZMVBYOA FYLFXDNEGBI;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class YQWGMZKXDCQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class HBRINZRJEVC
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly HMFNZMVBYOA GGGBARDRVJG;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly HMFNZMVBYOA PSUKVQHFCYN;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class FSXZOHXJETX
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly HMFNZMVBYOA SOTSQZGMJRQ;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly HMFNZMVBYOA SOYZNHPMMTQ;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly HMFNZMVBYOA RPYGCKBDYQK;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly HMFNZMVBYOA GKVZHROJHVW;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly HMFNZMVBYOA HXUMXEHTKQH;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly HMFNZMVBYOA RMZHILEIOXC;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly HMFNZMVBYOA VIQRINKUHPO;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly HMFNZMVBYOA WSHLKMJLTVE;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly HMFNZMVBYOA XFKWPZDEJDF;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly HMFNZMVBYOA FSBNFAWOYYL;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly HMFNZMVBYOA GGGBARDRVJG;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly HMFNZMVBYOA PSUKVQHFCYN;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class MNPEPKKMUNZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class TABUQHJOQLL
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly HMFNZMVBYOA GGGBARDRVJG;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly HMFNZMVBYOA PSUKVQHFCYN;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly HMFNZMVBYOA FKWOKKTCQST;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly HMFNZMVBYOA JAIRNCIFYIX;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly HMFNZMVBYOA HSBNWZZEGHE;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class QPEATKVTDIE
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class DHSDQIPNUZN
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly HMFNZMVBYOA JTISXVUKANW;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class POSQJHLBRCP
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly HMFNZMVBYOA ACZNUBXSBVD;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly HMFNZMVBYOA FVNTZUPRNYU;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly HMFNZMVBYOA GGGBARDRVJG;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly HMFNZMVBYOA PSUKVQHFCYN;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class YXAWVQIQQWC
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class YORDCZWSGOG
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class PGQTCTSMVGD
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class MANFROPITTR
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class RIAKLWSEVTA
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class COJYXWFADZM
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly HMFNZMVBYOA VNQOGGQLQEL;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly HMFNZMVBYOA KAKQSRBTOUQ;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class SVDJVCMSUIO
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly HMFNZMVBYOA FCZLUBGESSF;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly HMFNZMVBYOA UHIFRKWYWIP;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly HMFNZMVBYOA ZCMZTVIGNNT;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly HMFNZMVBYOA DMQFHXLEIXF;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class HQONTETUGBB
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly HMFNZMVBYOA FCZLUBGESSF;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly HMFNZMVBYOA UHIFRKWYWIP;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly HMFNZMVBYOA ZCMZTVIGNNT;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly HMFNZMVBYOA DMQFHXLEIXF;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class DNTIDSSYBJE
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class UUDQYSEQKIH
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly HMFNZMVBYOA XKDIHGVSLGE;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly HMFNZMVBYOA XUJHJHUZOUQ;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly HMFNZMVBYOA XCESZDJVVTS;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class DSPLMHEHISC
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly HMFNZMVBYOA ERAPWKHGDSB;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly HMFNZMVBYOA DKDNAHZVLFZ;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly HMFNZMVBYOA LVPCSJCMUUM;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class XASQRJBNUTP
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class YAZHFZKQSMU
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly HMFNZMVBYOA ALVJLRXDHOE;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly HMFNZMVBYOA BNOIVVRSXUS;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly HMFNZMVBYOA TKXNJUHMSWR;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly HMFNZMVBYOA OTTKDGTCADX;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly HMFNZMVBYOA CXEHYNOZZAI;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class JUWIFZYKURV
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly HMFNZMVBYOA NSGLAZYEYLS;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class JOWYBAXXBOX
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly HMFNZMVBYOA QDADMBUHGRP;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly HMFNZMVBYOA FLWJPWKPRKK;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly HMFNZMVBYOA GOSIWDSTMKZ;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class YVCRGXALJZG
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class HNZPMRKPTBU
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class WWPJHQUDAMN
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class PTFXKCPHHQS
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly HMFNZMVBYOA KWBZHPTUZET;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly HMFNZMVBYOA JZVZBTHWCTW;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly HMFNZMVBYOA CYALCMLCPGW;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly HMFNZMVBYOA PTJZQHCXHHQ;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly HMFNZMVBYOA NHMVCAWFZLH;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly HMFNZMVBYOA TWSQPWYHCUH;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly HMFNZMVBYOA GQHAREAKHOE;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class LQRSIXNHFGW
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly HMFNZMVBYOA GYFRPWQUUIR;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly HMFNZMVBYOA[] CGIREJRJVTH;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class QQECGMVDKJQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly VEGTAJZNKQL HUHAJIGLFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<HMFNZMVBYOA> PZFENFDAVLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<HMFNZMVBYOA> OCAUGBGSXGC;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<HMFNZMVBYOA> OUQTPMQZFBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<HMFNZMVBYOA> QTSUCLIBLRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC3E0", Offset = "0x2BDAFE0", VA = "0x182BDC3E0")]
		protected QQECGMVDKJQ(VEGTAJZNKQL a, params HMFNZMVBYOA[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class MGTSYVZSSMW : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9320", Offset = "0x2BD7F20", VA = "0x182BD9320")]
		internal MGTSYVZSSMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class YAWTVDDJPHN : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0BD0", Offset = "0x2BDF7D0", VA = "0x182BE0BD0")]
		internal YAWTVDDJPHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PPSPHQUAVDA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB180", Offset = "0x2BD9D80", VA = "0x182BDB180")]
		internal PPSPHQUAVDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class NXFDIXTZEHR : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA030", Offset = "0x2BD8C30", VA = "0x182BDA030")]
		internal NXFDIXTZEHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MRWGXTKVGWE : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9570", Offset = "0x2BD8170", VA = "0x182BD9570")]
		internal MRWGXTKVGWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class FJQULJTAMSI : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3BF0", Offset = "0x2BD27F0", VA = "0x182BD3BF0")]
		internal FJQULJTAMSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class VLEKEJDEEMD : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF150", Offset = "0x2BDDD50", VA = "0x182BDF150")]
		internal VLEKEJDEEMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class TQDUMWPSFCW : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE3A0", Offset = "0x2BDCFA0", VA = "0x182BDE3A0")]
		internal TQDUMWPSFCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class BWLBAUXPGNG : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1690", Offset = "0x2BD0290", VA = "0x182BD1690")]
		internal BWLBAUXPGNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class SKTLKWTSEMA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCE50", Offset = "0x2BDBA50", VA = "0x182BDCE50")]
		internal SKTLKWTSEMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class EHAJAQDAJJW : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3A10", Offset = "0x2BD2610", VA = "0x182BD3A10")]
		internal EHAJAQDAJJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SLIPEZQLNGU : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD030", Offset = "0x2BDBC30", VA = "0x182BDD030")]
		internal SLIPEZQLNGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class VCRGLRFFSZO : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEF70", Offset = "0x2BDDB70", VA = "0x182BDEF70")]
		internal VCRGLRFFSZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class QCYTNSJTPVK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB790", Offset = "0x2BDA390", VA = "0x182BDB790")]
		internal QCYTNSJTPVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class RCMPQJFMKFI : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC9B0", Offset = "0x2BDB5B0", VA = "0x182BDC9B0")]
		internal RCMPQJFMKFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class CGCILAZVKJE : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2100", Offset = "0x2BD0D00", VA = "0x182BD2100")]
		internal CGCILAZVKJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class WOFUQCCTSJU : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF770", Offset = "0x2BDE370", VA = "0x182BDF770")]
		internal WOFUQCCTSJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class WBCVFWDBOXF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF590", Offset = "0x2BDE190", VA = "0x182BDF590")]
		internal WBCVFWDBOXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ZEJVPMUPFXH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1EA0", Offset = "0x2BE0AA0", VA = "0x182BE1EA0")]
		internal ZEJVPMUPFXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class WZAMSXARXDP : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF9C0", Offset = "0x2BDE5C0", VA = "0x182BDF9C0")]
		internal WZAMSXARXDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class VNIRYCXKZEH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF330", Offset = "0x2BDDF30", VA = "0x182BDF330")]
		internal VNIRYCXKZEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class MAAJIHLKUOT : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7C80", Offset = "0x2BD6880", VA = "0x182BD7C80")]
		internal MAAJIHLKUOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class BKLBGGSMXUM : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0F90", Offset = "0x2BCFB90", VA = "0x182BD0F90")]
		internal BKLBGGSMXUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class MUXLTTMQVDX : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9750", Offset = "0x2BD8350", VA = "0x182BD9750")]
		internal MUXLTTMQVDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class XESSZHZUKKK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFEE0", Offset = "0x2BDEAE0", VA = "0x182BDFEE0")]
		internal XESSZHZUKKK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class YFSGQCQAMOV : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE18B0", Offset = "0x2BE04B0", VA = "0x182BE18B0")]
		internal YFSGQCQAMOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class QGFROTOVOJR : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB870", Offset = "0x2BDA470", VA = "0x182BDB870")]
		internal QGFROTOVOJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZEYTHPPYLKZ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2080", Offset = "0x2BE0C80", VA = "0x182BE2080")]
		internal ZEYTHPPYLKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class NEXJGDKHRWY : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9930", Offset = "0x2BD8530", VA = "0x182BD9930")]
		internal NEXJGDKHRWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class POKBDGNRABH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9E0", Offset = "0x2BD95E0", VA = "0x182BDA9E0")]
		internal POKBDGNRABH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CXFMIPUADOA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2C00", Offset = "0x2BD1800", VA = "0x182BD2C00")]
		internal CXFMIPUADOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HMOKUTRWSZQ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5BA0", Offset = "0x2BD47A0", VA = "0x182BD5BA0")]
		internal HMOKUTRWSZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class JEGQCVVENOO : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BB0", Offset = "0x2BD57B0", VA = "0x182BD6BB0")]
		internal JEGQCVVENOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ZUVHWRVHSCF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2440", Offset = "0x2BE1040", VA = "0x182BE2440")]
		internal ZUVHWRVHSCF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class CUDPIZXZSCT : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2A20", Offset = "0x2BD1620", VA = "0x182BD2A20")]
		internal CUDPIZXZSCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class XCEKYRZXZAB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFC80", Offset = "0x2BDE880", VA = "0x182BDFC80")]
		internal XCEKYRZXZAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class YCORIXHCAHI : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BE16D0", Offset = "0x2BE02D0", VA = "0x182BE16D0")]
		internal YCORIXHCAHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class HUSWDZZFTRF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6510", Offset = "0x2BD5110", VA = "0x182BD6510")]
		internal HUSWDZZFTRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class HUUVRWBUWBB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6770", Offset = "0x2BD5370", VA = "0x182BD6770")]
		internal HUUVRWBUWBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class KVIOXSBSCOA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7650", Offset = "0x2BD6250", VA = "0x182BD7650")]
		internal KVIOXSBSCOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class RCYNKOKPOMQ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCB90", Offset = "0x2BDB790", VA = "0x182BDCB90")]
		internal RCYNKOKPOMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class YGOGAQUXLHO : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1A90", Offset = "0x2BE0690", VA = "0x182BE1A90")]
		internal YGOGAQUXLHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class JSYRCLDIWQH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7200", Offset = "0x2BD5E00", VA = "0x182BD7200")]
		internal JSYRCLDIWQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class BLAWCWGNXFB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD12D0", Offset = "0x2BCFED0", VA = "0x182BD12D0")]
		internal BLAWCWGNXFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class BVQPCJXUWTK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BD14B0", Offset = "0x2BD00B0", VA = "0x182BD14B0")]
		internal BVQPCJXUWTK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class LACYOJROXDD : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7830", Offset = "0x2BD6430", VA = "0x182BD7830")]
		internal LACYOJROXDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class HXSENEWQJQQ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BD69D0", Offset = "0x2BD55D0", VA = "0x182BD69D0")]
		internal HXSENEWQJQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class DGDHIVWWCBN : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2E50", Offset = "0x2BD1A50", VA = "0x182BD2E50")]
		internal DGDHIVWWCBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class NKTLFMUDTOL : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9E50", Offset = "0x2BD8A50", VA = "0x182BD9E50")]
		internal NKTLFMUDTOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class ORGVWENDGJG : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA790", Offset = "0x2BD9390", VA = "0x182BDA790")]
		internal ORGVWENDGJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class NIZMKTSOJAK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C70", Offset = "0x2BD8870", VA = "0x182BD9C70")]
		internal NIZMKTSOJAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class CLDRYJIMSYZ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BD22E0", Offset = "0x2BD0EE0", VA = "0x182BD22E0")]
		internal CLDRYJIMSYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class ZGGQKNHLRPU : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2260", Offset = "0x2BE0E60", VA = "0x182BE2260")]
		internal ZGGQKNHLRPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class XJVIQHXDNVV : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BE00C0", Offset = "0x2BDECC0", VA = "0x182BE00C0")]
		internal XJVIQHXDNVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class UTPNQLXXXZF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE7D0", Offset = "0x2BDD3D0", VA = "0x182BDE7D0")]
		internal UTPNQLXXXZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class TJKOVJTVAUJ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDFE0", Offset = "0x2BDCBE0", VA = "0x182BDDFE0")]
		internal TJKOVJTVAUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class TPCPGEPLYCP : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE1C0", Offset = "0x2BDCDC0", VA = "0x182BDE1C0")]
		internal TPCPGEPLYCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class TUSNRQRXMZY : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE580", Offset = "0x2BDD180", VA = "0x182BDE580")]
		internal TUSNRQRXMZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class QTQXZTQXROV : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC560", Offset = "0x2BDB160", VA = "0x182BDC560")]
		internal QTQXZTQXROV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class DJBZKJORMOZ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD32F0", Offset = "0x2BD1EF0", VA = "0x182BD32F0")]
		internal DJBZKJORMOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class CSTLULXRUYE : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BD28C0", Offset = "0x2BD14C0", VA = "0x182BD28C0")]
		internal CSTLULXRUYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class NIBGHHFGSZT : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9B10", Offset = "0x2BD8710", VA = "0x182BD9B10")]
		internal NIBGHHFGSZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class BKMCPICDGTS : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1170", Offset = "0x2BCFD70", VA = "0x182BD1170")]
		internal BKMCPICDGTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class NYZKAKLCJZR : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA210", Offset = "0x2BD8E10", VA = "0x182BDA210")]
		internal NYZKAKLCJZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class GYXMIMKPDQB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4B30", Offset = "0x2BD3730", VA = "0x182BD4B30")]
		internal GYXMIMKPDQB()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, OBLVMRVNUCX<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly VEGTAJZNKQL Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
		private NamedType(string name, VEGTAJZNKQL type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EFC0", Offset = "0x2B0DBC0", VA = "0x182B0EFC0")]
		public static NamedType New(string name, VEGTAJZNKQL type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA3F0", Offset = "0x2BD8FF0", VA = "0x182BDA3F0")]
		public static bool IQJYWSDTJLC([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA3F0", Offset = "0x2BD8FF0", VA = "0x182BDA3F0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA3F0", Offset = "0x2BD8FF0", VA = "0x182BDA3F0")]
		public bool VPMCMGYWJAO([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA440", Offset = "0x2BD9040", VA = "0x182BDA440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA500", Offset = "0x2BD9100", VA = "0x182BDA500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA570", Offset = "0x2BD9170", VA = "0x182BDA570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA5B0", Offset = "0x2BD91B0", VA = "0x182BDA5B0")]
		public string WUFTRVQVBLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA370", Offset = "0x2BD8F70", VA = "0x182BDA370")]
		public string CGWHVTOCMEU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA3F0", Offset = "0x2BD8FF0", VA = "0x182BDA3F0", Slot = "5")]
		private bool CRUEXTMTJJV([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface HATGOKICMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, LYQWSZGLQZW>> VLZIGITBNZG(FXFJUDAMIWO a, bool b);
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
