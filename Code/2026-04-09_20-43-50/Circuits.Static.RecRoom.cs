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
		[Cpp2IlInjected.Address(RVA = "0x2BD8B30", Offset = "0x2BD7B30", VA = "0x182BD8B30")]
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
namespace _LogRegistration.Circuits_Static_RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8A40", Offset = "0x2BD7A40", VA = "0x182BD8A40", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDC120", Offset = "0x2BDB120", VA = "0x182BDC120")]
		public static bool YYLVHLNLCLX(this VEGTAJZNKQL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC060", Offset = "0x2BDB060", VA = "0x182BDC060")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD8BB0", Offset = "0x2BD7BB0", VA = "0x182BD8BB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8FA0", Offset = "0x2BD7FA0", VA = "0x182BD8FA0")]
			public static QQECGMVDKJQ WLHQEUBUFGK(Id32<VFFMGBNUIJR> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8F10", Offset = "0x2BD7F10", VA = "0x182BD8F10")]
			public static bool TDPGEFGDKZN(Id32<VFFMGBNUIJR> id, [Out] QQECGMVDKJQ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8C00", Offset = "0x2BD7C00", VA = "0x182BD8C00")]
			public static VEGTAJZNKQL JGGRXALQOWL(Id32<VFFMGBNUIJR> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8E80", Offset = "0x2BD7E80", VA = "0x182BD8E80")]
			private static Id32<VFFMGBNUIJR> SIFQFAPRLAF(QQECGMVDKJQ a, Id32<VFFMGBNUIJR> id)
			{
				return default(Id32<VFFMGBNUIJR>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8CB0", Offset = "0x2BD7CB0", VA = "0x182BD8CB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C50", Offset = "0x12D3C50", VA = "0x1812D4C50")]
				private TypeRegistryFactory([In] IdUnsafeList<BTONDMOTLQL, VEGTAJZNKQL?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3F80", Offset = "0x2BE2F80", VA = "0x182BE3F80")]
				public static TypeRegistryFactory SIUHUEYRRON()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3A40", Offset = "0x2BE2A40", VA = "0x182BE3A40")]
				public (ReadOnlyIdArray<BTONDMOTLQL, VEGTAJZNKQL>, IReadOnlyDictionary<VEGTAJZNKQL, Id32<BTONDMOTLQL>>) CLJSAMBXECZ()
				{
					return default((ReadOnlyIdArray<BTONDMOTLQL, VEGTAJZNKQL>, IReadOnlyDictionary<VEGTAJZNKQL, Id32<BTONDMOTLQL>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3DB0", Offset = "0x2BE2DB0", VA = "0x182BE3DB0")]
				public Id32<BTONDMOTLQL> DPQAECQDNXZ(int a, VEGTAJZNKQL b)
				{
					return default(Id32<BTONDMOTLQL>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3F30", Offset = "0x2BE2F30", VA = "0x182BE3F30")]
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
					[Cpp2IlInjected.Address(RVA = "0x2BC64E0", Offset = "0x2BC54E0", VA = "0x182BC64E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BC64A0", Offset = "0x2BC54A0", VA = "0x182BC64A0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<BTONDMOTLQL> KDORFLEVGDT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BC65A0", Offset = "0x2BC55A0", VA = "0x182BC65A0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BC6420", Offset = "0x2BC5420", VA = "0x182BC6420")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<BTONDMOTLQL> ZMYHXNSRVKK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BC63E0", Offset = "0x2BC53E0", VA = "0x182BC63E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BC6560", Offset = "0x2BC5560", VA = "0x182BC6560")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<BTONDMOTLQL> AIDXYMHVXIQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BC6660", Offset = "0x2BC5660", VA = "0x182BC6660")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BC63A0", Offset = "0x2BC53A0", VA = "0x182BC63A0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<BTONDMOTLQL> ZZCSQXARUNG
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BC65E0", Offset = "0x2BC55E0", VA = "0x182BC65E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BC6460", Offset = "0x2BC5460", VA = "0x182BC6460")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<BTONDMOTLQL> IFIPAJRQFSN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BC6520", Offset = "0x2BC5520", VA = "0x182BC6520")]
					[CompilerGenerated]
					get
					{
						return default(Id32<BTONDMOTLQL>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BC6620", Offset = "0x2BC5620", VA = "0x182BC6620")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
				[DebuggerHidden]
				public RDXXLXQDPHO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3960", Offset = "0x2BE2960", VA = "0x182BE3960", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3570", Offset = "0x2BE2570", VA = "0x182BE3570", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BE39F0", Offset = "0x2BE29F0", VA = "0x182BE39F0")]
				private void SYBUDUAVPHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3530", Offset = "0x2BE2530", VA = "0x182BE3530", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3470", Offset = "0x2BE2470", VA = "0x182BE3470", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VEGTAJZNKQL> AUTAPBQAWIH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BE3470", Offset = "0x2BE2470", VA = "0x182BE3470", Slot = "5")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
				[DebuggerHidden]
				public XDRFKWFTPSK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BE50B0", Offset = "0x2BE40B0", VA = "0x182BE50B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BE5070", Offset = "0x2BE4070", VA = "0x182BE5070", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BE4FC0", Offset = "0x2BE3FC0", VA = "0x182BE4FC0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VEGTAJZNKQL> AUTAPBQAWIH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BE4FC0", Offset = "0x2BE3FC0", VA = "0x182BE4FC0", Slot = "5")]
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
					[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF7EE0", VA = "0x180DF8EE0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x2BCCA20", Offset = "0x2BCBA20", VA = "0x182BCCA20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15D3630", Offset = "0x15D2630", VA = "0x1815D3630")]
				[DebuggerHidden]
				public IZONBDAVOGV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BCCFB0", Offset = "0x2BCBFB0", VA = "0x182BCCFB0", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BCCAB0", Offset = "0x2BCBAB0", VA = "0x182BCCAB0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD150", Offset = "0x2BCC150", VA = "0x182BCD150")]
				private void SYBUDUAVPHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD100", Offset = "0x2BCC100", VA = "0x182BCD100")]
				private void SXLZLZTDMZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BCCA70", Offset = "0x2BCBA70", VA = "0x182BCCA70", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC970", Offset = "0x2BCB970", VA = "0x182BCC970", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<BTONDMOTLQL>> BULKHCZYHKY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC970", Offset = "0x2BCB970", VA = "0x182BCC970", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet NFZOGUWIALR
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet XKPOLRYRYDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static VEGTAJZNKQL JDVUCFKZTJL
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF5D0", Offset = "0x2BCE5D0", VA = "0x182BCF5D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static VEGTAJZNKQL KDORFLEVGDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BCFFA0", Offset = "0x2BCEFA0", VA = "0x182BCFFA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static VEGTAJZNKQL ZMYHXNSRVKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD750", Offset = "0x2BCC750", VA = "0x182BCD750")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static VEGTAJZNKQL AIDXYMHVXIQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BD1220", Offset = "0x2BD0220", VA = "0x182BD1220")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static VEGTAJZNKQL QCGTEQJVGWG
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF450", Offset = "0x2BCE450", VA = "0x182BCF450")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static VEGTAJZNKQL PQZTUYSLRLX
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF4E0", Offset = "0x2BCE4E0", VA = "0x182BCF4E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static VEGTAJZNKQL AMCXUYMWOXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF2B0", Offset = "0x2BCE2B0", VA = "0x182BCF2B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static VEGTAJZNKQL ZZCSQXARUNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BD0690", Offset = "0x2BCF690", VA = "0x182BD0690")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static TNBFVZCFSMI ZXWHWWDJOZC
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF900", Offset = "0x2BCE900", VA = "0x182BCF900")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1170", Offset = "0x2BD0170", VA = "0x182BD1170")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD02A0", Offset = "0x2BCF2A0", VA = "0x182BD02A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF400", Offset = "0x2BCE400", VA = "0x182BCF400")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDF80", Offset = "0x2BCCF80", VA = "0x182BCDF80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF950", Offset = "0x2BCE950", VA = "0x182BCF950")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE9A0", Offset = "0x2BCD9A0", VA = "0x182BCE9A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE000", Offset = "0x2BCD000", VA = "0x182BCE000")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD840", Offset = "0x2BCC840", VA = "0x182BCD840")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0640", Offset = "0x2BCF640", VA = "0x182BD0640")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD890", Offset = "0x2BCC890", VA = "0x182BCD890")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD580", Offset = "0x2BCC580", VA = "0x182BCD580")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFA00", Offset = "0x2BCEA00", VA = "0x182BCFA00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD10B0", Offset = "0x2BD00B0", VA = "0x182BD10B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE5A0", Offset = "0x2BCD5A0", VA = "0x182BCE5A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD08A0", Offset = "0x2BCF8A0", VA = "0x182BD08A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD5D0", Offset = "0x2BCC5D0", VA = "0x182BCD5D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF190", Offset = "0x2BCE190", VA = "0x182BCF190")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE170", Offset = "0x2BCD170", VA = "0x182BCE170")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1490", Offset = "0x2BD0490", VA = "0x182BD1490")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCEF50", Offset = "0x2BCDF50", VA = "0x182BCEF50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0240", Offset = "0x2BCF240", VA = "0x182BD0240")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDBB0", Offset = "0x2BCCBB0", VA = "0x182BCDBB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFDC0", Offset = "0x2BCEDC0", VA = "0x182BCFDC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF0D0", Offset = "0x2BCE0D0", VA = "0x182BCF0D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD210", Offset = "0x2BCC210", VA = "0x182BCD210")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCEA50", Offset = "0x2BCDA50", VA = "0x182BCEA50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD07E0", Offset = "0x2BCF7E0", VA = "0x182BD07E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDB50", Offset = "0x2BCCB50", VA = "0x182BCDB50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF720", Offset = "0x2BCE720", VA = "0x182BCF720")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE290", Offset = "0x2BCD290", VA = "0x182BCE290")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1310", Offset = "0x2BD0310", VA = "0x182BD1310")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFEE0", Offset = "0x2BCEEE0", VA = "0x182BCFEE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF130", Offset = "0x2BCE130", VA = "0x182BCF130")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0580", Offset = "0x2BCF580", VA = "0x182BD0580")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFE80", Offset = "0x2BCEE80", VA = "0x182BCFE80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0780", Offset = "0x2BCF780", VA = "0x182BD0780")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE050", Offset = "0x2BCD050", VA = "0x182BCE050")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF340", Offset = "0x2BCE340", VA = "0x182BCF340")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE350", Offset = "0x2BCD350", VA = "0x182BCE350")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD8E0", Offset = "0x2BCC8E0", VA = "0x182BCD8E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0180", Offset = "0x2BCF180", VA = "0x182BD0180")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0FF0", Offset = "0x2BCFFF0", VA = "0x182BD0FF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0120", Offset = "0x2BCF120", VA = "0x182BD0120")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD690", Offset = "0x2BCC690", VA = "0x182BCD690")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDC10", Offset = "0x2BCCC10", VA = "0x182BCDC10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD3B0", Offset = "0x2BCC3B0", VA = "0x182BCD3B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0A40", Offset = "0x2BCFA40", VA = "0x182BD0A40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD12B0", Offset = "0x2BD02B0", VA = "0x182BD12B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD350", Offset = "0x2BCC350", VA = "0x182BCD350")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD970", Offset = "0x2BCC970", VA = "0x182BCD970")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE3B0", Offset = "0x2BCD3B0", VA = "0x182BCE3B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD470", Offset = "0x2BCC470", VA = "0x182BCD470")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD11C0", Offset = "0x2BD01C0", VA = "0x182BD11C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF570", Offset = "0x2BCE570", VA = "0x182BCF570")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD04C0", Offset = "0x2BCF4C0", VA = "0x182BD04C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFA50", Offset = "0x2BCEA50", VA = "0x182BCFA50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDD40", Offset = "0x2BCCD40", VA = "0x182BCDD40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF8A0", Offset = "0x2BCE8A0", VA = "0x182BCF8A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD05E0", Offset = "0x2BCF5E0", VA = "0x182BD05E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0B00", Offset = "0x2BCFB00", VA = "0x182BD0B00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD270", Offset = "0x2BCC270", VA = "0x182BCD270")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD01E0", Offset = "0x2BCF1E0", VA = "0x182BD01E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE230", Offset = "0x2BCD230", VA = "0x182BCE230")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDC70", Offset = "0x2BCCC70", VA = "0x182BCDC70")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE660", Offset = "0x2BCD660", VA = "0x182BCE660")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE9F0", Offset = "0x2BCD9F0", VA = "0x182BCE9F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF3A0", Offset = "0x2BCE3A0", VA = "0x182BCF3A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE600", Offset = "0x2BCD600", VA = "0x182BCE600")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF840", Offset = "0x2BCE840", VA = "0x182BCF840")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD13D0", Offset = "0x2BD03D0", VA = "0x182BD13D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF780", Offset = "0x2BCE780", VA = "0x182BCF780")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFE20", Offset = "0x2BCEE20", VA = "0x182BCFE20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE1D0", Offset = "0x2BCD1D0", VA = "0x182BCE1D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDE60", Offset = "0x2BCCE60", VA = "0x182BCDE60")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE0B0", Offset = "0x2BCD0B0", VA = "0x182BCE0B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0F90", Offset = "0x2BCFF90", VA = "0x182BD0F90")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1050", Offset = "0x2BD0050", VA = "0x182BD1050")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDEC0", Offset = "0x2BCCEC0", VA = "0x182BCDEC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1110", Offset = "0x2BD0110", VA = "0x182BD1110")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD410", Offset = "0x2BCC410", VA = "0x182BCD410")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE540", Offset = "0x2BCD540", VA = "0x182BCE540")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD630", Offset = "0x2BCC630", VA = "0x182BCD630")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0520", Offset = "0x2BCF520", VA = "0x182BD0520")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDAF0", Offset = "0x2BCCAF0", VA = "0x182BCDAF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1430", Offset = "0x2BD0430", VA = "0x182BD1430")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF660", Offset = "0x2BCE660", VA = "0x182BCF660")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF070", Offset = "0x2BCE070", VA = "0x182BCF070")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD9D0", Offset = "0x2BCC9D0", VA = "0x182BCD9D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCEFB0", Offset = "0x2BCDFB0", VA = "0x182BCEFB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0840", Offset = "0x2BCF840", VA = "0x182BD0840")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDDA0", Offset = "0x2BCCDA0", VA = "0x182BCDDA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDF20", Offset = "0x2BCCF20", VA = "0x182BCDF20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0350", Offset = "0x2BCF350", VA = "0x182BD0350")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0BC0", Offset = "0x2BCFBC0", VA = "0x182BD0BC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF010", Offset = "0x2BCE010", VA = "0x182BCF010")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF250", Offset = "0x2BCE250", VA = "0x182BCF250")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD02F0", Offset = "0x2BCF2F0", VA = "0x182BD02F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD6F0", Offset = "0x2BCC6F0", VA = "0x182BCD6F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0AA0", Offset = "0x2BCFAA0", VA = "0x182BD0AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF6C0", Offset = "0x2BCE6C0", VA = "0x182BCF6C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE2F0", Offset = "0x2BCD2F0", VA = "0x182BCE2F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1370", Offset = "0x2BD0370", VA = "0x182BD1370")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCE110", Offset = "0x2BCD110", VA = "0x182BCE110")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFF40", Offset = "0x2BCEF40", VA = "0x182BCFF40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF9A0", Offset = "0x2BCE9A0", VA = "0x182BCF9A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDA30", Offset = "0x2BCCA30", VA = "0x182BCDA30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD1570", Offset = "0x2BD0570", VA = "0x182BD1570")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDA90", Offset = "0x2BCCA90", VA = "0x182BCDA90")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0720", Offset = "0x2BCF720", VA = "0x182BD0720")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCFAB0", Offset = "0x2BCEAB0", VA = "0x182BCFAB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCEEF0", Offset = "0x2BCDEF0", VA = "0x182BCEEF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0900", Offset = "0x2BCF900", VA = "0x182BD0900")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF1F0", Offset = "0x2BCE1F0", VA = "0x182BCF1F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0460", Offset = "0x2BCF460", VA = "0x182BD0460")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCD7E0", Offset = "0x2BCC7E0", VA = "0x182BCD7E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCDE00", Offset = "0x2BCCE00", VA = "0x182BCDE00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BD0B60", Offset = "0x2BCFB60", VA = "0x182BD0B60")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BCF7E0", Offset = "0x2BCE7E0", VA = "0x182BCF7E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0030", Offset = "0x2BCF030", VA = "0x182BD0030")]
			public static ZBZPANTDQLE QPKINSDDNAG([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0990", Offset = "0x2BCF990", VA = "0x182BD0990")]
			public static ClassFactoryTypeParams URGDCGFIKFJ(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0960", Offset = "0x2BCF960", VA = "0x182BD0960")]
			public static ClassFactoryTypeParams URGDCGFIKFJ([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BCDFD0", Offset = "0x2BCCFD0", VA = "0x182BCDFD0")]
			public static ZBZPANTDQLE FSWXVAFXKOE(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD940", Offset = "0x2BCC940", VA = "0x182BCD940")]
			public static ZBZPANTDQLE CUHUJNPCWNT(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE410", Offset = "0x2BCD410", VA = "0x182BCE410")]
			public static ZBZPANTDQLE IFIPAJRQFSN([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCEB60", Offset = "0x2BCDB60", VA = "0x182BCEB60")]
			public static VEGTAJZNKQL JGGRXALQOWL(Id32<BTONDMOTLQL> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD2D0", Offset = "0x2BCC2D0", VA = "0x182BCD2D0")]
			public static string AIIPAENTZYQ(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCEC10", Offset = "0x2BCDC10", VA = "0x182BCEC10")]
			private static VEGTAJZNKQL JGGRXALQOWL(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCDCD0", Offset = "0x2BCCCD0", VA = "0x182BCDCD0")]
			public static Id32<BTONDMOTLQL>? ENSCPUANBDY(VEGTAJZNKQL a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0C20", Offset = "0x2BCFC20", VA = "0x182BD0C20")]
			public static CircuitTypeIdWrapper? WHCNZQALZXP(VEGTAJZNKQL a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD15D0", Offset = "0x2BD05D0", VA = "0x182BD15D0")]
			static KHJEOHAUXZJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BD03B0", Offset = "0x2BCF3B0", VA = "0x182BD03B0")]
			[IteratorStateMachine(typeof(XDRFKWFTPSK))]
			private static IEnumerable<VEGTAJZNKQL> RWVKBCSYTVB(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD4D0", Offset = "0x2BCC4D0", VA = "0x182BCD4D0")]
			[IteratorStateMachine(typeof(RDXXLXQDPHO))]
			public static IEnumerable<VEGTAJZNKQL> BNBGCNUAPAG(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BCFB10", Offset = "0x2BCEB10", VA = "0x182BCFB10")]
			public static Variant PRJQWROVUWH(VEGTAJZNKQL a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE6C0", Offset = "0x2BCD6C0", VA = "0x182BCE6C0")]
			public static Variant ITDXUXXDHAC(VEGTAJZNKQL a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BD14F0", Offset = "0x2BD04F0", VA = "0x182BD14F0")]
			public static bool YZSVBGZXJUK(VEGTAJZNKQL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BCEAB0", Offset = "0x2BCDAB0", VA = "0x182BCEAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC66A0", Offset = "0x2BC56A0", VA = "0x182BC66A0")]
		public static NOKOMIYTNQH GHRXOLGFAHI(this VEGTAJZNKQL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7780", Offset = "0x2BC6780", VA = "0x182BC7780")]
		public static VEGTAJZNKQL GTHJBIMUMZN(this NOKOMIYTNQH a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class COXGBVPOZCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37FF250", Offset = "0x37FE250", VA = "0x1837FF250")]
		public static Dictionary<b, c> KBDKYLGAIEX<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class YTVCBOINGZA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6FC0", Offset = "0x2BE5FC0", VA = "0x182BE6FC0")]
		public static RYGSTCASHAB GHRXOLGFAHI([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BE70C0", Offset = "0x2BE60C0", VA = "0x182BE70C0")]
		public static Guid GTHJBIMUMZN(RYGSTCASHAB a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class HYFBSXDIVMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC0E0", Offset = "0x2BCB0E0", VA = "0x182BCC0E0")]
		public static TJFYKXONFEJ GHRXOLGFAHI([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC170", Offset = "0x2BCB170", VA = "0x182BCC170")]
		public static NamedType GTHJBIMUMZN(this TJFYKXONFEJ a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class IXCSXYCNXTN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3BAFC90", Offset = "0x3BAEC90", VA = "0x183BAFC90")]
		public static void MUVYHJYTERV<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3BAFEF0", Offset = "0x3BAEEF0", VA = "0x183BAFEF0")]
		public static void MUVYHJYTERV<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class COLQZAJKJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8A10", Offset = "0x2BC7A10", VA = "0x182BC8A10")]
		public static JNFXEWUIKCF GHRXOLGFAHI([In] this Variant self, VEGTAJZNKQL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8C10", Offset = "0x2BC7C10", VA = "0x182BC8C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8DBD0", Offset = "0x2B8CBD0", VA = "0x182B8DBD0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<WKKAYCGFMFC> SFLWDPRYLST
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B8DBD0", Offset = "0x2B8CBD0", VA = "0x182B8DBD0")]
			get
			{
				return default(Id128<WKKAYCGFMFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, VEGTAJZNKQL Type)> DNONVMTPCXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ITEZEMUNZLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBD00", Offset = "0x2BCAD00", VA = "0x182BCBD00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB2E0", Offset = "0x2BCA2E0", VA = "0x182BCB2E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, VEGTAJZNKQL> AGBLGMIQBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB860", Offset = "0x2BCA860", VA = "0x182BCB860")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB660", Offset = "0x2BCA660", VA = "0x182BCB660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> DNXEYHKISMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB5B0", Offset = "0x2BCA5B0", VA = "0x182BCB5B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB500", Offset = "0x2BCA500", VA = "0x182BCB500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> MTFPSWSFHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBDA0", Offset = "0x2BCADA0", VA = "0x182BCBDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB450", Offset = "0x2BCA450", VA = "0x182BCB450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, VEGTAJZNKQL> FYVMNRXHCKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BCBE50", Offset = "0x2BCAE50", VA = "0x182BCBE50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB7B0", Offset = "0x2BCA7B0", VA = "0x182BCB7B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action NWKMBHZKVPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB910", Offset = "0x2BCA910", VA = "0x182BCB910")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB710", Offset = "0x2BCA710", VA = "0x182BCB710")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B46200", Offset = "0x1B45200", VA = "0x181B46200")]
		public void ESTAQQMWWNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBFF0", Offset = "0x2BCAFF0", VA = "0x182BCBFF0")]
		internal HMFNZMVBYOA([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, VEGTAJZNKQL Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBAA0", Offset = "0x2BCAAA0", VA = "0x182BCBAA0")]
		public static CircuitEventDefinitionFactoryStart SIUHUEYRRON(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBB70", Offset = "0x2BCAB70", VA = "0x182BCBB70")]
		public static CircuitEventDefinitionFactoryStart SIUHUEYRRON(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBBF0", Offset = "0x2BCABF0", VA = "0x182BCBBF0")]
		public static HMFNZMVBYOA UUZMWUWJJXZ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAFA0", Offset = "0x2BC9FA0", VA = "0x182BCAFA0")]
		public static HMFNZMVBYOA CXDXVWVCAHH([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF1C2B0", Offset = "0xF1B2B0", VA = "0x180F1C2B0")]
		public void CLOMTVRFQYL(Id128<WKKAYCGFMFC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB3F0", Offset = "0x2BCA3F0", VA = "0x182BCB3F0")]
		public void ESXUPNWLUIK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB9B0", Offset = "0x2BCA9B0", VA = "0x182BCB9B0")]
		public void REGOMSKIHTQ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBF00", Offset = "0x2BCAF00", VA = "0x182BCBF00")]
		public void ZQPGLPOYXBT(int a, VEGTAJZNKQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAE80", Offset = "0x2BC9E80", VA = "0x182BCAE80")]
		public void AATENAFVVRR(string a, VEGTAJZNKQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB380", Offset = "0x2BCA380", VA = "0x182BCB380")]
		public void EBKIINBTYLG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB1E0", Offset = "0x2BCA1E0", VA = "0x182BCB1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC92C0", Offset = "0x2BC82C0", VA = "0x182BC92C0")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9150", Offset = "0x2BC8150", VA = "0x182BC9150")]
		public CircuitEventDefinitionFactoryParams ZAJCCLRCUJX(string a, VEGTAJZNKQL b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9020", Offset = "0x2BC8020", VA = "0x182BC9020")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC8F90", Offset = "0x2BC7F90", VA = "0x182BC8F90")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, VEGTAJZNKQL Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8E60", Offset = "0x2BC7E60", VA = "0x182BC8E60")]
		public CircuitEventDefinitionFactoryParams ZAJCCLRCUJX(string a, VEGTAJZNKQL b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8D60", Offset = "0x2BC7D60", VA = "0x182BC8D60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<HMFNZMVBYOA> QTSUCLIBLRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BF25B0", Offset = "0x2BF15B0", VA = "0x182BF25B0")]
		protected QQECGMVDKJQ(VEGTAJZNKQL a, params HMFNZMVBYOA[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class MGTSYVZSSMW : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF4F0", Offset = "0x2BEE4F0", VA = "0x182BEF4F0")]
		internal MGTSYVZSSMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class YAWTVDDJPHN : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6DA0", Offset = "0x2BF5DA0", VA = "0x182BF6DA0")]
		internal YAWTVDDJPHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PPSPHQUAVDA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BF1350", Offset = "0x2BF0350", VA = "0x182BF1350")]
		internal PPSPHQUAVDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class NXFDIXTZEHR : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0200", Offset = "0x2BEF200", VA = "0x182BF0200")]
		internal NXFDIXTZEHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MRWGXTKVGWE : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF740", Offset = "0x2BEE740", VA = "0x182BEF740")]
		internal MRWGXTKVGWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class FJQULJTAMSI : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9DC0", Offset = "0x2BE8DC0", VA = "0x182BE9DC0")]
		internal FJQULJTAMSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class VLEKEJDEEMD : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5320", Offset = "0x2BF4320", VA = "0x182BF5320")]
		internal VLEKEJDEEMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class TQDUMWPSFCW : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4570", Offset = "0x2BF3570", VA = "0x182BF4570")]
		internal TQDUMWPSFCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class BWLBAUXPGNG : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7860", Offset = "0x2BE6860", VA = "0x182BE7860")]
		internal BWLBAUXPGNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class SKTLKWTSEMA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3020", Offset = "0x2BF2020", VA = "0x182BF3020")]
		internal SKTLKWTSEMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class EHAJAQDAJJW : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9BE0", Offset = "0x2BE8BE0", VA = "0x182BE9BE0")]
		internal EHAJAQDAJJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SLIPEZQLNGU : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3200", Offset = "0x2BF2200", VA = "0x182BF3200")]
		internal SLIPEZQLNGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class VCRGLRFFSZO : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5140", Offset = "0x2BF4140", VA = "0x182BF5140")]
		internal VCRGLRFFSZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class QCYTNSJTPVK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BF1960", Offset = "0x2BF0960", VA = "0x182BF1960")]
		internal QCYTNSJTPVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class RCMPQJFMKFI : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2B80", Offset = "0x2BF1B80", VA = "0x182BF2B80")]
		internal RCMPQJFMKFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class CGCILAZVKJE : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BE82D0", Offset = "0x2BE72D0", VA = "0x182BE82D0")]
		internal CGCILAZVKJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class WOFUQCCTSJU : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5940", Offset = "0x2BF4940", VA = "0x182BF5940")]
		internal WOFUQCCTSJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class WBCVFWDBOXF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5760", Offset = "0x2BF4760", VA = "0x182BF5760")]
		internal WBCVFWDBOXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ZEJVPMUPFXH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8070", Offset = "0x2BF7070", VA = "0x182BF8070")]
		internal ZEJVPMUPFXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class WZAMSXARXDP : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5B90", Offset = "0x2BF4B90", VA = "0x182BF5B90")]
		internal WZAMSXARXDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class VNIRYCXKZEH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5500", Offset = "0x2BF4500", VA = "0x182BF5500")]
		internal VNIRYCXKZEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class MAAJIHLKUOT : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDE50", Offset = "0x2BECE50", VA = "0x182BEDE50")]
		internal MAAJIHLKUOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class BKLBGGSMXUM : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7160", Offset = "0x2BE6160", VA = "0x182BE7160")]
		internal BKLBGGSMXUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class MUXLTTMQVDX : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF920", Offset = "0x2BEE920", VA = "0x182BEF920")]
		internal MUXLTTMQVDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class XESSZHZUKKK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF60B0", Offset = "0x2BF50B0", VA = "0x182BF60B0")]
		internal XESSZHZUKKK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class YFSGQCQAMOV : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7A80", Offset = "0x2BF6A80", VA = "0x182BF7A80")]
		internal YFSGQCQAMOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class QGFROTOVOJR : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF1A40", Offset = "0x2BF0A40", VA = "0x182BF1A40")]
		internal QGFROTOVOJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZEYTHPPYLKZ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8250", Offset = "0x2BF7250", VA = "0x182BF8250")]
		internal ZEYTHPPYLKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class NEXJGDKHRWY : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFB00", Offset = "0x2BEEB00", VA = "0x182BEFB00")]
		internal NEXJGDKHRWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class POKBDGNRABH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0BB0", Offset = "0x2BEFBB0", VA = "0x182BF0BB0")]
		internal POKBDGNRABH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CXFMIPUADOA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8DD0", Offset = "0x2BE7DD0", VA = "0x182BE8DD0")]
		internal CXFMIPUADOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HMOKUTRWSZQ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BEBD70", Offset = "0x2BEAD70", VA = "0x182BEBD70")]
		internal HMOKUTRWSZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class JEGQCVVENOO : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BECD80", Offset = "0x2BEBD80", VA = "0x182BECD80")]
		internal JEGQCVVENOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ZUVHWRVHSCF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8610", Offset = "0x2BF7610", VA = "0x182BF8610")]
		internal ZUVHWRVHSCF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class CUDPIZXZSCT : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8BF0", Offset = "0x2BE7BF0", VA = "0x182BE8BF0")]
		internal CUDPIZXZSCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class XCEKYRZXZAB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5E50", Offset = "0x2BF4E50", VA = "0x182BF5E50")]
		internal XCEKYRZXZAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class YCORIXHCAHI : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BF78A0", Offset = "0x2BF68A0", VA = "0x182BF78A0")]
		internal YCORIXHCAHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class HUSWDZZFTRF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC6E0", Offset = "0x2BEB6E0", VA = "0x182BEC6E0")]
		internal HUSWDZZFTRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class HUUVRWBUWBB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC940", Offset = "0x2BEB940", VA = "0x182BEC940")]
		internal HUUVRWBUWBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class KVIOXSBSCOA : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BED820", Offset = "0x2BEC820", VA = "0x182BED820")]
		internal KVIOXSBSCOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class RCYNKOKPOMQ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2D60", Offset = "0x2BF1D60", VA = "0x182BF2D60")]
		internal RCYNKOKPOMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class YGOGAQUXLHO : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7C60", Offset = "0x2BF6C60", VA = "0x182BF7C60")]
		internal YGOGAQUXLHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class JSYRCLDIWQH : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BED3D0", Offset = "0x2BEC3D0", VA = "0x182BED3D0")]
		internal JSYRCLDIWQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class BLAWCWGNXFB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE74A0", Offset = "0x2BE64A0", VA = "0x182BE74A0")]
		internal BLAWCWGNXFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class BVQPCJXUWTK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7680", Offset = "0x2BE6680", VA = "0x182BE7680")]
		internal BVQPCJXUWTK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class LACYOJROXDD : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDA00", Offset = "0x2BECA00", VA = "0x182BEDA00")]
		internal LACYOJROXDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class HXSENEWQJQQ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BECBA0", Offset = "0x2BEBBA0", VA = "0x182BECBA0")]
		internal HXSENEWQJQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class DGDHIVWWCBN : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9020", Offset = "0x2BE8020", VA = "0x182BE9020")]
		internal DGDHIVWWCBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class NKTLFMUDTOL : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0020", Offset = "0x2BEF020", VA = "0x182BF0020")]
		internal NKTLFMUDTOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class ORGVWENDGJG : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0960", Offset = "0x2BEF960", VA = "0x182BF0960")]
		internal ORGVWENDGJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class NIZMKTSOJAK : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFE40", Offset = "0x2BEEE40", VA = "0x182BEFE40")]
		internal NIZMKTSOJAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class CLDRYJIMSYZ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BE84B0", Offset = "0x2BE74B0", VA = "0x182BE84B0")]
		internal CLDRYJIMSYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class ZGGQKNHLRPU : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8430", Offset = "0x2BF7430", VA = "0x182BF8430")]
		internal ZGGQKNHLRPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class XJVIQHXDNVV : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6290", Offset = "0x2BF5290", VA = "0x182BF6290")]
		internal XJVIQHXDNVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class UTPNQLXXXZF : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BF49A0", Offset = "0x2BF39A0", VA = "0x182BF49A0")]
		internal UTPNQLXXXZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class TJKOVJTVAUJ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF41B0", Offset = "0x2BF31B0", VA = "0x182BF41B0")]
		internal TJKOVJTVAUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class TPCPGEPLYCP : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4390", Offset = "0x2BF3390", VA = "0x182BF4390")]
		internal TPCPGEPLYCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class TUSNRQRXMZY : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF4750", Offset = "0x2BF3750", VA = "0x182BF4750")]
		internal TUSNRQRXMZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class QTQXZTQXROV : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF2730", Offset = "0x2BF1730", VA = "0x182BF2730")]
		internal QTQXZTQXROV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class DJBZKJORMOZ : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE94C0", Offset = "0x2BE84C0", VA = "0x182BE94C0")]
		internal DJBZKJORMOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class CSTLULXRUYE : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8A90", Offset = "0x2BE7A90", VA = "0x182BE8A90")]
		internal CSTLULXRUYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class NIBGHHFGSZT : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BEFCE0", Offset = "0x2BEECE0", VA = "0x182BEFCE0")]
		internal NIBGHHFGSZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class BKMCPICDGTS : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7340", Offset = "0x2BE6340", VA = "0x182BE7340")]
		internal BKMCPICDGTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class NYZKAKLCJZR : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BF03E0", Offset = "0x2BEF3E0", VA = "0x182BF03E0")]
		internal NYZKAKLCJZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class GYXMIMKPDQB : QQECGMVDKJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BEAD00", Offset = "0x2BE9D00", VA = "0x182BEAD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
		private NamedType(string name, VEGTAJZNKQL type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B250A0", Offset = "0x2B240A0", VA = "0x182B250A0")]
		public static NamedType New(string name, VEGTAJZNKQL type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BF05C0", Offset = "0x2BEF5C0", VA = "0x182BF05C0")]
		public static bool IQJYWSDTJLC([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BF05C0", Offset = "0x2BEF5C0", VA = "0x182BF05C0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BF05C0", Offset = "0x2BEF5C0", VA = "0x182BF05C0")]
		public bool VPMCMGYWJAO([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0610", Offset = "0x2BEF610", VA = "0x182BF0610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF06D0", Offset = "0x2BEF6D0", VA = "0x182BF06D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0740", Offset = "0x2BEF740", VA = "0x182BF0740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0780", Offset = "0x2BEF780", VA = "0x182BF0780")]
		public string WUFTRVQVBLS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0540", Offset = "0x2BEF540", VA = "0x182BF0540")]
		public string CGWHVTOCMEU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BF05C0", Offset = "0x2BEF5C0", VA = "0x182BF05C0", Slot = "5")]
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
