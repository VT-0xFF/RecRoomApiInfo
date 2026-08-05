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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x291BBD0", Offset = "0x291A3D0", VA = "0x18291BBD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x291BB50", Offset = "0x291A350", VA = "0x18291BB50", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KJNBTFAWGXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x291B980", Offset = "0x291A180", VA = "0x18291B980")]
		public static bool PRURGIYDMGI(this RVNMAEXWNBU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x291BA90", Offset = "0x291A290", VA = "0x18291BA90")]
		public static bool PRURGIYDMGI(this QBCOQCAPQYZ a)
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
			private readonly KIQIZMMDNIQ _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
			public EVRequest(KIQIZMMDNIQ staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class CVGOHCJGWHZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<JQPVEKPUQSM>, FSRQOCPNDRD> VIRKHEZHTCI;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<JQPVEKPUQSM>>? MBTGPSOQKQM;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<JQPVEKPUQSM> YFNNNZJJVGC;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<JQPVEKPUQSM> ZQZEPWASUOD;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<JQPVEKPUQSM> TMCRLUTQYEO;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<JQPVEKPUQSM> XANYSHYKZNB;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<JQPVEKPUQSM> TWHLSQEHKKM;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<JQPVEKPUQSM> GGYVUBWIZJN;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<JQPVEKPUQSM> YSVDORUZKRB;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<JQPVEKPUQSM> YEQWBVTAFPF;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<JQPVEKPUQSM> VYTOQMEUUFV;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<JQPVEKPUQSM> HRPMUGJSGLZ;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<JQPVEKPUQSM> PIRHHNKADKD;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<JQPVEKPUQSM> OJPIYEMOXZT;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<JQPVEKPUQSM> ZCBSOUNANEM;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<JQPVEKPUQSM> LTPAREZTXCQ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<JQPVEKPUQSM> TXDZQBKEBUW;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<JQPVEKPUQSM> WRBYLJUPQWR;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<JQPVEKPUQSM> VUUEBIGSJMQ;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<JQPVEKPUQSM> VRVRALDCIGO;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<JQPVEKPUQSM> ODEPUVRYYDL;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<JQPVEKPUQSM> GZLOBIVSAKW;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<JQPVEKPUQSM> PESJICRMCVH;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<JQPVEKPUQSM> EWXLJUEAYYC;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<JQPVEKPUQSM> SDXEUALLLFE;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<JQPVEKPUQSM> JCTOLGYAJAR;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<JQPVEKPUQSM> JNYYVKSDFNL;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<JQPVEKPUQSM> WZXTJZXAVLO;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<JQPVEKPUQSM> ZRWSTTOAXVB;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<JQPVEKPUQSM> FLYBKXTNQKI;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<JQPVEKPUQSM> OQDBMRXTFUU;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<JQPVEKPUQSM> BGVVNKZHFAG;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<JQPVEKPUQSM> XJQPBXEZLGM;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<JQPVEKPUQSM> EMCGHDFJBRP;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<JQPVEKPUQSM> TWYYBRLDKFE;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<JQPVEKPUQSM> IPUVUGIECDY;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<JQPVEKPUQSM> CWPDFQZNQCE;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<JQPVEKPUQSM> ROTVTITBEGF;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<JQPVEKPUQSM> QIDVWUCUYDI;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<JQPVEKPUQSM> NPJENXCPVNB;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<JQPVEKPUQSM> FPDPCLYXWJV;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<JQPVEKPUQSM> AWWDRSLMKPP;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<JQPVEKPUQSM> KQMOFRDRBWC;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<JQPVEKPUQSM> DDEVGUPDQKS;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<JQPVEKPUQSM> SKKOWZLQJJF;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<JQPVEKPUQSM> NQSUGSKBNWW;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<JQPVEKPUQSM> OZCROQEHCYQ;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<JQPVEKPUQSM> TXNYPYFWSCC;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<JQPVEKPUQSM> QQQYAVGORHR;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<JQPVEKPUQSM> OQFHLXROFJR;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<JQPVEKPUQSM> VXJBXVTIITJ;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<JQPVEKPUQSM> APLHSUCLZCO;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<JQPVEKPUQSM> RIRKPQQNNOW;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<JQPVEKPUQSM> GBPZNKAFPHJ;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<JQPVEKPUQSM> ODKTCDDSZHO;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<JQPVEKPUQSM> YCPAYFALESK;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<JQPVEKPUQSM> OECBKJXOHXT;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<JQPVEKPUQSM> MQVPSSBTENX;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<JQPVEKPUQSM> GCLOEBSIMOV;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<JQPVEKPUQSM> SKAUFKYWMRX;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<JQPVEKPUQSM> YGYTITCRQHW;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<JQPVEKPUQSM> JKIIEJDBCQD;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<JQPVEKPUQSM> XTAJSDAUVEN;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<JQPVEKPUQSM> KFXWORVIJDB;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<JQPVEKPUQSM> RFJRMEUIYJS;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<JQPVEKPUQSM> EBEPYWEDVUG;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<JQPVEKPUQSM> JFXHWBCALEF;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<JQPVEKPUQSM> NTIFPQKJOOC;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<JQPVEKPUQSM> RXZCSVHNGKH;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<JQPVEKPUQSM> VHNTSYXAGQZ;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<JQPVEKPUQSM> WTTBGMSHFVJ;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<JQPVEKPUQSM>, FSRQOCPNDRD> FAZWHCXABHF
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2912DD0", Offset = "0x29115D0", VA = "0x182912DD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2912D50", Offset = "0x2911550", VA = "0x182912D50")]
			public static FSRQOCPNDRD FAKSWJGZMJP(Id32<JQPVEKPUQSM> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2912E20", Offset = "0x2911620", VA = "0x182912E20")]
			public static bool GDHCNFTUURE(Id32<JQPVEKPUQSM> id, [Out] FSRQOCPNDRD a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2912CA0", Offset = "0x29114A0", VA = "0x182912CA0")]
			public static RVNMAEXWNBU ANZFCBLPJOE(Id32<JQPVEKPUQSM> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2912EB0", Offset = "0x29116B0", VA = "0x182912EB0")]
			private static Id32<JQPVEKPUQSM> JPLRKQDWIBU(FSRQOCPNDRD a, Id32<JQPVEKPUQSM> id)
			{
				return default(Id32<JQPVEKPUQSM>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2912F40", Offset = "0x2911740", VA = "0x182912F40")]
			private static void RVMMMEHNSYM(Id32<JQPVEKPUQSM> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class QZVNFHOSOEE
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<RBMJELGIMTE, RVNMAEXWNBU?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
				private TypeRegistryFactory([In] IdUnsafeList<RBMJELGIMTE, RVNMAEXWNBU?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x292F690", Offset = "0x292DE90", VA = "0x18292F690")]
				public static TypeRegistryFactory CYOPTWCDXLK()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x292F340", Offset = "0x292DB40", VA = "0x18292F340")]
				public (ReadOnlyIdArray<RBMJELGIMTE, RVNMAEXWNBU>, IReadOnlyDictionary<RVNMAEXWNBU, Id32<RBMJELGIMTE>>) AXHFTEUJRLO()
				{
					return default((ReadOnlyIdArray<RBMJELGIMTE, RVNMAEXWNBU>, IReadOnlyDictionary<RVNMAEXWNBU, Id32<RBMJELGIMTE>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x292F740", Offset = "0x292DF40", VA = "0x18292F740")]
				public Id32<RBMJELGIMTE> QQDUVPPIOYG(int a, RVNMAEXWNBU b)
				{
					return default(Id32<RBMJELGIMTE>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x292F6F0", Offset = "0x292DEF0", VA = "0x18292F6F0")]
				public Id32<RBMJELGIMTE> Initialize(int id, CIHDQNZBWGJ type, CIHDQNZBWGJ factoryType)
				{
					return default(Id32<RBMJELGIMTE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class WEHPTKSSBRB
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<RBMJELGIMTE> LOEZQQZYCEI
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x292FE60", Offset = "0x292E660", VA = "0x18292FE60")]
					[CompilerGenerated]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x292FEA0", Offset = "0x292E6A0", VA = "0x18292FEA0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<RBMJELGIMTE> FHLJFTZBPQO
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x292FFA0", Offset = "0x292E7A0", VA = "0x18292FFA0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x29300E0", Offset = "0x292E8E0", VA = "0x1829300E0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<RBMJELGIMTE> LKFZHWRCATL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x292FF60", Offset = "0x292E760", VA = "0x18292FF60")]
					[CompilerGenerated]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x292FEE0", Offset = "0x292E6E0", VA = "0x18292FEE0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<RBMJELGIMTE> KNCYBBSERSJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2930060", Offset = "0x292E860", VA = "0x182930060")]
					[CompilerGenerated]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2930120", Offset = "0x292E920", VA = "0x182930120")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<RBMJELGIMTE> ABTLKLPBVWZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x292FF20", Offset = "0x292E720", VA = "0x18292FF20")]
					[CompilerGenerated]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2930020", Offset = "0x292E820", VA = "0x182930020")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<RBMJELGIMTE> CTYWJPXHQPS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x29300A0", Offset = "0x292E8A0", VA = "0x1829300A0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x292FFE0", Offset = "0x292E7E0", VA = "0x18292FFE0")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class ERDUUBFAMWD : IEnumerable<RVNMAEXWNBU>, IEnumerable, IEnumerator<RVNMAEXWNBU>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int RXIHLDXPFTB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private RVNMAEXWNBU VMXRQLYYOUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int AWPKGSEYDWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool EFRFKHQKLSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool PVGVKVGQNCR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion CXMNFLJHZUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion PDUHJIGYDFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool BGWAFUVSYZB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool UYFPDMAZCPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool GSJPGXZSNBZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool BPTFFDVZEPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool LERHNBYKTTV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool QYGCQZWBUEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool PTHWLUJMTAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool OTCLTDYMCPW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<RVNMAEXWNBU> YLHXGKHQDKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private RVNMAEXWNBU APJEBTPNJMY;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private RVNMAEXWNBU SYOIVHEWOCJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object BXTOFOKJAZT
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
				[DebuggerHidden]
				public ERDUUBFAMWD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x29181D0", Offset = "0x29169D0", VA = "0x1829181D0", Slot = "7")]
				[DebuggerHidden]
				private void QMTXDIUIKRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2917DE0", Offset = "0x29165E0", VA = "0x182917DE0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2918260", Offset = "0x2916A60", VA = "0x182918260")]
				private void YQEVNPXUUBC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2917DA0", Offset = "0x29165A0", VA = "0x182917DA0", Slot = "10")]
				[DebuggerHidden]
				private void FKDUCXAGPJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2917CE0", Offset = "0x29164E0", VA = "0x182917CE0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<RVNMAEXWNBU> AYPOCGPIQGS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2917CE0", Offset = "0x29164E0", VA = "0x182917CE0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator LRASTPXJBWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class ISNCQAREXJX : IEnumerable<RVNMAEXWNBU>, IEnumerable, IEnumerator<RVNMAEXWNBU>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int RXIHLDXPFTB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private RVNMAEXWNBU VMXRQLYYOUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int AWPKGSEYDWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion CXMNFLJHZUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion PDUHJIGYDFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool GSJPGXZSNBZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool BPTFFDVZEPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool BGWAFUVSYZB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool UYFPDMAZCPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool DNUFWQQIUJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool JOXEIRWQYYI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool LERHNBYKTTV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool QYGCQZWBUEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool MAUUFKRZQXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool SJFYTXMWAUL;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private RVNMAEXWNBU SYOIVHEWOCJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object BXTOFOKJAZT
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
				[DebuggerHidden]
				public ISNCQAREXJX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
				[DebuggerHidden]
				private void QMTXDIUIKRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2919370", Offset = "0x2917B70", VA = "0x182919370", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2919330", Offset = "0x2917B30", VA = "0x182919330", Slot = "10")]
				[DebuggerHidden]
				private void FKDUCXAGPJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2919280", Offset = "0x2917A80", VA = "0x182919280", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<RVNMAEXWNBU> AYPOCGPIQGS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2919280", Offset = "0x2917A80", VA = "0x182919280", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator LRASTPXJBWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class EXNRDOMGRTQ : IEnumerable<Id32<RBMJELGIMTE>>, IEnumerable, IEnumerator<Id32<RBMJELGIMTE>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int RXIHLDXPFTB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<RBMJELGIMTE> VMXRQLYYOUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int AWPKGSEYDWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion CXMNFLJHZUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion PDUHJIGYDFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool BGWAFUVSYZB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool UYFPDMAZCPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool GSJPGXZSNBZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool BPTFFDVZEPY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool LERHNBYKTTV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool QYGCQZWBUEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool PTHWLUJMTAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool OTCLTDYMCPW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<RVNMAEXWNBU> YLHXGKHQDKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<CIHDQNZBWGJ> YLNEDRBNMVQ;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<RBMJELGIMTE> HVYXUJZQHEC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<RBMJELGIMTE>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object BXTOFOKJAZT
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x29188A0", Offset = "0x29170A0", VA = "0x1829188A0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x1326640", Offset = "0x1324E40", VA = "0x181326640")]
				[DebuggerHidden]
				public EXNRDOMGRTQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x29188F0", Offset = "0x29170F0", VA = "0x1829188F0", Slot = "7")]
				[DebuggerHidden]
				private void QMTXDIUIKRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x29183A0", Offset = "0x2916BA0", VA = "0x1829183A0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2918A40", Offset = "0x2917240", VA = "0x182918A40")]
				private void YQEVNPXUUBC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2918A90", Offset = "0x2917290", VA = "0x182918A90")]
				private void YQUQFKFMWJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x29182B0", Offset = "0x2916AB0", VA = "0x1829182B0", Slot = "10")]
				[DebuggerHidden]
				private void FKDUCXAGPJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x29182F0", Offset = "0x2916AF0", VA = "0x1829182F0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<RBMJELGIMTE>> JHPKYSTGGJT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x29182F0", Offset = "0x2916AF0", VA = "0x1829182F0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator LRASTPXJBWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log WKLAFLLOLVN;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<RBMJELGIMTE, RVNMAEXWNBU?> KIOXCUCJLKP;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<RVNMAEXWNBU, Id32<RBMJELGIMTE>> ZRUXYFHBOVJ;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly QBCOQCAPQYZ JYJPPVOMQYK;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly QBCOQCAPQYZ QBQFBOSWVVK;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<RVNMAEXWNBU> IFGQZIDYAMK;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<RVNMAEXWNBU> KGJECPSXKEJ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet XZAVHIROEIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet ULKLZYKJJSY
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet QXZMMHHINQI
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static RVNMAEXWNBU LOEZQQZYCEI
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2922DB0", Offset = "0x29215B0", VA = "0x182922DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static RVNMAEXWNBU FHLJFTZBPQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x29249B0", Offset = "0x29231B0", VA = "0x1829249B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static RVNMAEXWNBU LKFZHWRCATL
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2924420", Offset = "0x2922C20", VA = "0x182924420")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static RVNMAEXWNBU KNCYBBSERSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2925080", Offset = "0x2923880", VA = "0x182925080")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static RVNMAEXWNBU MJMIKWMINAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x29257C0", Offset = "0x2923FC0", VA = "0x1829257C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static RVNMAEXWNBU SKKKZXBSTZM
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x29231D0", Offset = "0x29219D0", VA = "0x1829231D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static RVNMAEXWNBU DHYIBTDGTPV
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2924BB0", Offset = "0x29233B0", VA = "0x182924BB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static RVNMAEXWNBU ABTLKLPBVWZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x29242E0", Offset = "0x2922AE0", VA = "0x1829242E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static CIHDQNZBWGJ DVHAVXSQJRR
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x29251B0", Offset = "0x29239B0", VA = "0x1829251B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static CIHDQNZBWGJ ZMUDDAYFDRO
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2923260", Offset = "0x2921A60", VA = "0x182923260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static CIHDQNZBWGJ YCPQMYREEVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x29261D0", Offset = "0x29249D0", VA = "0x1829261D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static CIHDQNZBWGJ MMCRKMFUTZJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2923A20", Offset = "0x2922220", VA = "0x182923A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static CIHDQNZBWGJ MZNUMHFJQLV
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2924150", Offset = "0x2922950", VA = "0x182924150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static CIHDQNZBWGJ YOLNTYDTRNC
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2925520", Offset = "0x2923D20", VA = "0x182925520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static CIHDQNZBWGJ NWFFOIFUGJA
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2925C10", Offset = "0x2924410", VA = "0x182925C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static CIHDQNZBWGJ KHUDOMCZQDC
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2925770", Offset = "0x2923F70", VA = "0x182925770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static CIHDQNZBWGJ OBDWLVLZXZB
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2925160", Offset = "0x2923960", VA = "0x182925160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static CIHDQNZBWGJ ZVYLRYZLFXZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2926090", Offset = "0x2924890", VA = "0x182926090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static CIHDQNZBWGJ NUREBNMISVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x29232B0", Offset = "0x2921AB0", VA = "0x1829232B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static CIHDQNZBWGJ PCZEZKEWKNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2924FE0", Offset = "0x29237E0", VA = "0x182924FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static CIHDQNZBWGJ WOMLSTYFBMG
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2923890", Offset = "0x2922090", VA = "0x182923890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static CIHDQNZBWGJ WWPACIPMCKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x29253E0", Offset = "0x2923BE0", VA = "0x1829253E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static CIHDQNZBWGJ XRTVLCBPQNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2923F20", Offset = "0x2922720", VA = "0x182923F20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static CIHDQNZBWGJ KXRGRWPFKJX
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2922CC0", Offset = "0x29214C0", VA = "0x182922CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static CIHDQNZBWGJ DOMQKRCJGXA
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2924780", Offset = "0x2922F80", VA = "0x182924780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static CIHDQNZBWGJ GXDFZAHBDKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2925110", Offset = "0x2923910", VA = "0x182925110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static CIHDQNZBWGJ HJXPPNMBRPK
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x29245F0", Offset = "0x2922DF0", VA = "0x1829245F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static CIHDQNZBWGJ IEHWGBEPXEG
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x29252F0", Offset = "0x2923AF0", VA = "0x1829252F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static CIHDQNZBWGJ RRRJNKZVSZR
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2924820", Offset = "0x2923020", VA = "0x182924820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static CIHDQNZBWGJ CHTGLWMWYES
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2922C70", Offset = "0x2921470", VA = "0x182922C70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static CIHDQNZBWGJ XGFVBZAMAZO
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2924AE0", Offset = "0x29232E0", VA = "0x182924AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static CIHDQNZBWGJ PSDVWSDZXOU
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x29255C0", Offset = "0x2923DC0", VA = "0x1829255C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static CIHDQNZBWGJ RTQZAMBYHOU
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x29266C0", Offset = "0x2924EC0", VA = "0x1829266C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static CIHDQNZBWGJ NKZHEKWBBSP
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x29246E0", Offset = "0x2922EE0", VA = "0x1829246E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static CIHDQNZBWGJ MWLNCLSMNBQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2924F40", Offset = "0x2923740", VA = "0x182924F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static CIHDQNZBWGJ FCFZRMZPCOS
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2924CE0", Offset = "0x29234E0", VA = "0x182924CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static CIHDQNZBWGJ LZXMLKILIWE
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2924F90", Offset = "0x2923790", VA = "0x182924F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static CIHDQNZBWGJ YBVBKZJYUSR
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2923C90", Offset = "0x2922490", VA = "0x182923C90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static CIHDQNZBWGJ XINJTREBUCF
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2925480", Offset = "0x2923C80", VA = "0x182925480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static CIHDQNZBWGJ EGERDORVFRS
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2925680", Offset = "0x2923E80", VA = "0x182925680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static CIHDQNZBWGJ XOTJNSZEPFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2925D50", Offset = "0x2924550", VA = "0x182925D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static CIHDQNZBWGJ KFMGVAPZMHS
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2925BC0", Offset = "0x29243C0", VA = "0x182925BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static CIHDQNZBWGJ FRPIKWVGGYD
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2926880", Offset = "0x2925080", VA = "0x182926880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static CIHDQNZBWGJ XXMATNNZCVT
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2926040", Offset = "0x2924840", VA = "0x182926040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static CIHDQNZBWGJ GMOIGHMAKHV
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x29247D0", Offset = "0x2922FD0", VA = "0x1829247D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static CIHDQNZBWGJ RXWCHQCOSYO
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2925720", Offset = "0x2923F20", VA = "0x182925720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static CIHDQNZBWGJ YCHFRNFVHVS
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2923E30", Offset = "0x2922630", VA = "0x182923E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static CIHDQNZBWGJ TXZXFYFRCYJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2924550", Offset = "0x2922D50", VA = "0x182924550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static CIHDQNZBWGJ JYZNFIHCVSB
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x29260E0", Offset = "0x29248E0", VA = "0x1829260E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static CIHDQNZBWGJ DREVMSSOBDX
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x29267E0", Offset = "0x2924FE0", VA = "0x1829267E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static CIHDQNZBWGJ BSTNYJIBBRZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2923440", Offset = "0x2921C40", VA = "0x182923440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static CIHDQNZBWGJ GKCNAHVTONG
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x29248C0", Offset = "0x29230C0", VA = "0x1829248C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static CIHDQNZBWGJ ZAWCFAWLHLW
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2924910", Offset = "0x2923110", VA = "0x182924910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static CIHDQNZBWGJ INYYWGQQNAT
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2925D00", Offset = "0x2924500", VA = "0x182925D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static CIHDQNZBWGJ LQFDHWDRKWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x29240B0", Offset = "0x29228B0", VA = "0x1829240B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static CIHDQNZBWGJ FXNSKMATQQU
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2926830", Offset = "0x2925030", VA = "0x182926830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static CIHDQNZBWGJ MBDAJUELWWC
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2924100", Offset = "0x2922900", VA = "0x182924100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static CIHDQNZBWGJ YUVJXICUXZH
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2923C40", Offset = "0x2922440", VA = "0x182923C40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static CIHDQNZBWGJ JYPACEHPYXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2925C60", Offset = "0x2924460", VA = "0x182925C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static CIHDQNZBWGJ SSMFLWCYLEF
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2924C90", Offset = "0x2923490", VA = "0x182924C90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static CIHDQNZBWGJ ZRAXMKISJCK
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2922D10", Offset = "0x2921510", VA = "0x182922D10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static CIHDQNZBWGJ LUBXXCOQUFL
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2926130", Offset = "0x2924930", VA = "0x182926130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static CIHDQNZBWGJ CSZFNFOHFAE
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2922D60", Offset = "0x2921560", VA = "0x182922D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static CIHDQNZBWGJ AUTDZPKSAJO
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2924730", Offset = "0x2922F30", VA = "0x182924730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static CIHDQNZBWGJ GRGGJOGEWDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x29239D0", Offset = "0x29221D0", VA = "0x1829239D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static CIHDQNZBWGJ LSMHPPLHTJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x29234E0", Offset = "0x2921CE0", VA = "0x1829234E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static CIHDQNZBWGJ MJRFWBXSVRT
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2925250", Offset = "0x2923A50", VA = "0x182925250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static CIHDQNZBWGJ FYAGLVDAFCW
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2925B20", Offset = "0x2924320", VA = "0x182925B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static CIHDQNZBWGJ BDNIHEAYBRR
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x29254D0", Offset = "0x2923CD0", VA = "0x1829254D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static CIHDQNZBWGJ GNSXFPYEUOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2924A40", Offset = "0x2923240", VA = "0x182924A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static CIHDQNZBWGJ DLYQOJZGLQU
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2924EA0", Offset = "0x29236A0", VA = "0x182924EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static CIHDQNZBWGJ HSXJVQQDAIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2925CB0", Offset = "0x29244B0", VA = "0x182925CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static CIHDQNZBWGJ WDQTOTPZRJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2924060", Offset = "0x2922860", VA = "0x182924060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static CIHDQNZBWGJ YWEWXMURMPW
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x29238E0", Offset = "0x29220E0", VA = "0x1829238E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static CIHDQNZBWGJ YDFQRCRAMCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2924240", Offset = "0x2922A40", VA = "0x182924240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static CIHDQNZBWGJ KQODAKJZQNM
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2925430", Offset = "0x2923C30", VA = "0x182925430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static CIHDQNZBWGJ HFQZUPZKQHT
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x29237F0", Offset = "0x2921FF0", VA = "0x1829237F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static CIHDQNZBWGJ QTWYCRUAOWL
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2923750", Offset = "0x2921F50", VA = "0x182923750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static CIHDQNZBWGJ WUFNRVSIQJN
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x29233F0", Offset = "0x2921BF0", VA = "0x1829233F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static CIHDQNZBWGJ HTHVNJYUQRC
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2925570", Offset = "0x2923D70", VA = "0x182925570")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static CIHDQNZBWGJ ZQPGORKSUKH
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2924290", Offset = "0x2922A90", VA = "0x182924290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static CIHDQNZBWGJ BUJFYJXJDUP
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2924A90", Offset = "0x2923290", VA = "0x182924A90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static CIHDQNZBWGJ FZJFWZFRKSC
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2923F70", Offset = "0x2922770", VA = "0x182923F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static CIHDQNZBWGJ ODVSZJGIUSK
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2923580", Offset = "0x2921D80", VA = "0x182923580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static CIHDQNZBWGJ FKYWHRQGZQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2925340", Offset = "0x2923B40", VA = "0x182925340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static CIHDQNZBWGJ TARPRNOUANW
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2925200", Offset = "0x2923A00", VA = "0x182925200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static CIHDQNZBWGJ BCGIGUPROKM
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2924690", Offset = "0x2922E90", VA = "0x182924690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static CIHDQNZBWGJ OFGYDAVLQWL
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x29256D0", Offset = "0x2923ED0", VA = "0x1829256D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static CIHDQNZBWGJ BYUVJDTUJLT
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x29245A0", Offset = "0x2922DA0", VA = "0x1829245A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static CIHDQNZBWGJ CIMSHRWSLBC
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x29244B0", Offset = "0x2922CB0", VA = "0x1829244B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static CIHDQNZBWGJ LHRGMTHOEON
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2923350", Offset = "0x2921B50", VA = "0x182923350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static CIHDQNZBWGJ UCISIPDALMW
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2926710", Offset = "0x2924F10", VA = "0x182926710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static CIHDQNZBWGJ LUYXLTKVZCS
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2925B70", Offset = "0x2924370", VA = "0x182925B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static CIHDQNZBWGJ FNETFWFQEOU
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2923840", Offset = "0x2922040", VA = "0x182923840")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static CIHDQNZBWGJ FJWKMJWZNKE
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2923AC0", Offset = "0x29222C0", VA = "0x182923AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static CIHDQNZBWGJ NWSYLFRYBEW
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x29241A0", Offset = "0x29229A0", VA = "0x1829241A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static CIHDQNZBWGJ XSEVOCVPVQB
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2923930", Offset = "0x2922130", VA = "0x182923930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static CIHDQNZBWGJ QPMVBDXIKEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2924960", Offset = "0x2923160", VA = "0x182924960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static CIHDQNZBWGJ JSJSQNOARTJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2923300", Offset = "0x2921B00", VA = "0x182923300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static CIHDQNZBWGJ GGQTIEXGOIQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2923FC0", Offset = "0x29227C0", VA = "0x182923FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static CIHDQNZBWGJ KURRWEZQWED
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2926670", Offset = "0x2924E70", VA = "0x182926670")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static CIHDQNZBWGJ OVMCOKINSRA
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2923A70", Offset = "0x2922270", VA = "0x182923A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static CIHDQNZBWGJ WZUYGEVSFYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2925030", Offset = "0x2923830", VA = "0x182925030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static CIHDQNZBWGJ BHBFHBVJGDV
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2923700", Offset = "0x2921F00", VA = "0x182923700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static CIHDQNZBWGJ KPTDNMYQDVY
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2923BF0", Offset = "0x29223F0", VA = "0x182923BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static CIHDQNZBWGJ FEMPKYMQSDZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2924B60", Offset = "0x2923360", VA = "0x182924B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static CIHDQNZBWGJ SKCLGGDXSLS
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2924EF0", Offset = "0x29236F0", VA = "0x182924EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static CIHDQNZBWGJ STCSWDSSISW
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2925390", Offset = "0x2923B90", VA = "0x182925390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static CIHDQNZBWGJ TSKMCFAEZMK
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2924010", Offset = "0x2922810", VA = "0x182924010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static CIHDQNZBWGJ PRBKGNJJBPV
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x29241F0", Offset = "0x29229F0", VA = "0x1829241F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static CIHDQNZBWGJ GEGOYAAYIAS
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x29252A0", Offset = "0x2923AA0", VA = "0x1829252A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static CIHDQNZBWGJ WURCGVXRCIW
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2924870", Offset = "0x2923070", VA = "0x182924870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static CIHDQNZBWGJ XGQEHLLNGGP
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2924500", Offset = "0x2922D00", VA = "0x182924500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static CIHDQNZBWGJ XMGVYFOHQMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2923980", Offset = "0x2922180", VA = "0x182923980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static CIHDQNZBWGJ YOJMMYOYGOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x29237A0", Offset = "0x2921FA0", VA = "0x1829237A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static CIHDQNZBWGJ YYWTWREBJYQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x29233A0", Offset = "0x2921BA0", VA = "0x1829233A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static CIHDQNZBWGJ LFNONDKGARU
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2923E80", Offset = "0x2922680", VA = "0x182923E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static CIHDQNZBWGJ FIBOFGHQNBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2924C40", Offset = "0x2923440", VA = "0x182924C40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static CIHDQNZBWGJ DLBKGHAYLVV
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2923CE0", Offset = "0x29224E0", VA = "0x182923CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static CIHDQNZBWGJ KCDOOHGQTBG
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2923490", Offset = "0x2921C90", VA = "0x182923490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static CIHDQNZBWGJ MITTXEUWMAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2923ED0", Offset = "0x29226D0", VA = "0x182923ED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static CIHDQNZBWGJ NKNDXSAUOTL
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2923DE0", Offset = "0x29225E0", VA = "0x182923DE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static CIHDQNZBWGJ XKQUGSDGOAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x29265A0", Offset = "0x2924DA0", VA = "0x1829265A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static CIHDQNZBWGJ FPWIAGMFUKO
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2924640", Offset = "0x2922E40", VA = "0x182924640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static CIHDQNZBWGJ PSHUFEICWGW
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2926180", Offset = "0x2924980", VA = "0x182926180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static CIHDQNZBWGJ WIGTQEBDOEI
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2923530", Offset = "0x2921D30", VA = "0x182923530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static CIHDQNZBWGJ EDYVKUXAQXD
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2924D60", Offset = "0x2923560", VA = "0x182924D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2924DB0", Offset = "0x29235B0", VA = "0x182924DB0")]
			public static QBCOQCAPQYZ PWHTKNBJDRX([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2923B40", Offset = "0x2922340", VA = "0x182923B40")]
			public static ClassFactoryTypeParams FSEGTHBUZZS(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2923B10", Offset = "0x2922310", VA = "0x182923B10")]
			public static ClassFactoryTypeParams FSEGTHBUZZS([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2924D30", Offset = "0x2923530", VA = "0x182924D30")]
			public static QBCOQCAPQYZ PDYZYHFXPBR(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2924B30", Offset = "0x2923330", VA = "0x182924B30")]
			public static QBCOQCAPQYZ NPSZYXNDHAK(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x29235D0", Offset = "0x2921DD0", VA = "0x1829235D0")]
			public static QBCOQCAPQYZ CTYWJPXHQPS([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2922E40", Offset = "0x2921640", VA = "0x182922E40")]
			public static RVNMAEXWNBU ANZFCBLPJOE(Id32<RBMJELGIMTE> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x29265F0", Offset = "0x2924DF0", VA = "0x1829265F0")]
			public static string YVFZLFQRSLJ(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2922EF0", Offset = "0x29216F0", VA = "0x182922EF0")]
			private static RVNMAEXWNBU ANZFCBLPJOE(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2925610", Offset = "0x2923E10", VA = "0x182925610")]
			public static Id32<RBMJELGIMTE>? THJRARNEKGB(RVNMAEXWNBU a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2926220", Offset = "0x2924A20", VA = "0x182926220")]
			public static CircuitTypeIdWrapper? YFWEIYCWYFC(RVNMAEXWNBU a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2926980", Offset = "0x2925180", VA = "0x182926980")]
			static QZVNFHOSOEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2923D30", Offset = "0x2922530", VA = "0x182923D30")]
			[IteratorStateMachine(typeof(ISNCQAREXJX))]
			private static IEnumerable<RVNMAEXWNBU> GUWRBTZVMTC(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x29268D0", Offset = "0x29250D0", VA = "0x1829268D0")]
			[IteratorStateMachine(typeof(ERDUUBFAMWD))]
			public static IEnumerable<RVNMAEXWNBU> ZYLBPHWHSOR(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2925DA0", Offset = "0x29245A0", VA = "0x182925DA0")]
			public static Variant WOCPNCZPRKW(RVNMAEXWNBU a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2925850", Offset = "0x2924050", VA = "0x182925850")]
			public static Variant UATPJBWNASX(RVNMAEXWNBU a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2926760", Offset = "0x2924F60", VA = "0x182926760")]
			public static bool ZLAOHCUGSLD(RVNMAEXWNBU a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2924370", Offset = "0x2922B70", VA = "0x182924370")]
			[IteratorStateMachine(typeof(EXNRDOMGRTQ))]
			public static IEnumerable<Id32<RBMJELGIMTE>> KNJDBRFTQVF(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class WLQNYDCDDYX
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2930C60", Offset = "0x292F460", VA = "0x182930C60")]
		public static QJTMBOWFASW VOPQGDPBGDJ(this RVNMAEXWNBU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2930160", Offset = "0x292E960", VA = "0x182930160")]
		public static RVNMAEXWNBU OTJRLYAVGYO(this QJTMBOWFASW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class REQLZVBFMUE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x397DDE0", Offset = "0x397C5E0", VA = "0x18397DDE0")]
		public static Dictionary<b, c> IVQBQLQWAOW<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class COWMZDRBDUL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2912BA0", Offset = "0x29113A0", VA = "0x182912BA0")]
		public static RPKNOQRBLQK VOPQGDPBGDJ([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2912B00", Offset = "0x2911300", VA = "0x182912B00")]
		public static Guid OTJRLYAVGYO(RPKNOQRBLQK a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class HYNGHZQQDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29191F0", Offset = "0x29179F0", VA = "0x1829191F0")]
		public static IDEKNTUTPWM VOPQGDPBGDJ([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2919190", Offset = "0x2917990", VA = "0x182919190")]
		public static NamedType OTJRLYAVGYO(this IDEKNTUTPWM a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class QHRQNFCBEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x396E0C0", Offset = "0x396C8C0", VA = "0x18396E0C0")]
		public static void MHMJOBBNZLG<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x396E320", Offset = "0x396CB20", VA = "0x18396E320")]
		public static void MHMJOBBNZLG<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class DYAJFIRRCAR
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2917AE0", Offset = "0x29162E0", VA = "0x182917AE0")]
		public static JURBOQXQJTS VOPQGDPBGDJ([In] this Variant self, RVNMAEXWNBU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2917990", Offset = "0x2916190", VA = "0x182917990")]
		public static Variant OTJRLYAVGYO(this JURBOQXQJTS a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RZEBZAJXRFZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<RZYXMTNPVSV> DYGSTIZTARP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool AHKVHUSEUIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool HFQKEYNULZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool UILBJYOVBZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool HTHNIPUHCUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool HTMUFWOEMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool SUCXYGIVGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool XVLFASJAYTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool TOCXTANOIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, RVNMAEXWNBU Type)> QDVGYQFGGNP;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid VXYCUIZXFBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x28D9D60", Offset = "0x28D8560", VA = "0x1828D9D60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<RZYXMTNPVSV> PUWGWMCVRNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x28D9D60", Offset = "0x28D8560", VA = "0x1828D9D60")]
			get
			{
				return default(Id128<RZYXMTNPVSV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, RVNMAEXWNBU Type)> UFWLVRCGALS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AGHFKTEFRWT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x292E580", Offset = "0x292CD80", VA = "0x18292E580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x292DFD0", Offset = "0x292C7D0", VA = "0x18292DFD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, RVNMAEXWNBU> KQHHMYAXYQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x292E780", Offset = "0x292CF80", VA = "0x18292E780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x292E290", Offset = "0x292CA90", VA = "0x18292E290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> ILKHJWUEWXR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x292DE30", Offset = "0x292C630", VA = "0x18292DE30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x292E620", Offset = "0x292CE20", VA = "0x18292E620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> VBXRKLHYNSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x292E6D0", Offset = "0x292CED0", VA = "0x18292E6D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x292DC90", Offset = "0x292C490", VA = "0x18292DC90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, RVNMAEXWNBU> SNRAXPTNLBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x292E830", Offset = "0x292D030", VA = "0x18292E830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x292DBE0", Offset = "0x292C3E0", VA = "0x18292DBE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UAXGZXPMTQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x292E1F0", Offset = "0x292C9F0", VA = "0x18292E1F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x292DAE0", Offset = "0x292C2E0", VA = "0x18292DAE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18FA450", Offset = "0x18F8C50", VA = "0x1818FA450")]
		public void RKTCSUFPHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x292E8E0", Offset = "0x292D0E0", VA = "0x18292E8E0")]
		internal RZEBZAJXRFZ([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, RVNMAEXWNBU Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x292D890", Offset = "0x292C090", VA = "0x18292D890")]
		public static CircuitEventDefinitionFactoryStart CYOPTWCDXLK(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x292D960", Offset = "0x292C160", VA = "0x18292D960")]
		public static CircuitEventDefinitionFactoryStart CYOPTWCDXLK(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x292E0E0", Offset = "0x292C8E0", VA = "0x18292E0E0")]
		public static RZEBZAJXRFZ JMMNBYSUWQY([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x292E340", Offset = "0x292CB40", VA = "0x18292E340")]
		public static RZEBZAJXRFZ PNSQOHETEES([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xC7C0C0", Offset = "0xC7A8C0", VA = "0x180C7C0C0")]
		public void FSBUKEPKZVY(Id128<RZYXMTNPVSV> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x292DB80", Offset = "0x292C380", VA = "0x18292DB80")]
		public void FNAKIYDSDYN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x292DEE0", Offset = "0x292C6E0", VA = "0x18292DEE0")]
		public void IDGFFHFRXFL(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x292DD40", Offset = "0x292C540", VA = "0x18292DD40")]
		public void HSXFWDMWTPY(int a, RVNMAEXWNBU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x292D770", Offset = "0x292BF70", VA = "0x18292D770")]
		public void BNQBYAXIXBY(string a, RVNMAEXWNBU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x292E070", Offset = "0x292C870", VA = "0x18292E070")]
		public void JDDAWBRZXSL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x292D9E0", Offset = "0x292C1E0", VA = "0x18292D9E0")]
		public RZEBZAJXRFZ Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2916500", Offset = "0x2914D00", VA = "0x182916500")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2916390", Offset = "0x2914B90", VA = "0x182916390")]
		public CircuitEventDefinitionFactoryParams GUVUQJPNHCA(string a, RVNMAEXWNBU b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2916260", Offset = "0x2914A60", VA = "0x182916260")]
		public RZEBZAJXRFZ AXHFTEUJRLO()
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
		private readonly List<(string Name, RVNMAEXWNBU Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x29161D0", Offset = "0x29149D0", VA = "0x1829161D0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, RVNMAEXWNBU Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29160A0", Offset = "0x29148A0", VA = "0x1829160A0")]
		public CircuitEventDefinitionFactoryParams GUVUQJPNHCA(string a, RVNMAEXWNBU b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2915FA0", Offset = "0x29147A0", VA = "0x182915FA0")]
		public RZEBZAJXRFZ AXHFTEUJRLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LNOCKLTKXZW
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly RZEBZAJXRFZ IMTADGZJBMJ;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly RZEBZAJXRFZ MFACQEBQSJQ;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly RZEBZAJXRFZ CQUVXWDPRBT;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly RZEBZAJXRFZ FUVJIGFVRNU;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly RZEBZAJXRFZ HZSIJMUNCSZ;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly RZEBZAJXRFZ YFMBCXPWBDH;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly RZEBZAJXRFZ NJHXYUGEOMC;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly RZEBZAJXRFZ[] GRJNBISUIRR;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class ZQZEPWASUOD
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly RZEBZAJXRFZ OHNATRJNSXX;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class TMCRLUTQYEO
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly RZEBZAJXRFZ ZKEDVOPZKNV;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly RZEBZAJXRFZ LOEJXATNRPK;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class KFXWORVIJDB
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly RZEBZAJXRFZ DJXXWFQCVRK;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly RZEBZAJXRFZ JYJTSTQFVCJ;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly RZEBZAJXRFZ[] YMPZXSOBTAL;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly RZEBZAJXRFZ UMIKATAEWAP;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly RZEBZAJXRFZ JSRWHPJIWAO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class QQQYAVGORHR
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly RZEBZAJXRFZ NIVXDODJCZU;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly RZEBZAJXRFZ HERNXSEPBGX;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class TWHLSQEHKKM
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly RZEBZAJXRFZ EJFQBQQGXDZ;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly RZEBZAJXRFZ TEWBVNBCUCK;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class GGYVUBWIZJN
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly RZEBZAJXRFZ ZKEDVOPZKNV;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly RZEBZAJXRFZ LOEJXATNRPK;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class YSVDORUZKRB
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly RZEBZAJXRFZ FTCGKUMJJGW;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly RZEBZAJXRFZ XJLPFMGHCSR;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly RZEBZAJXRFZ QNIUAQGRQXJ;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly RZEBZAJXRFZ HNZTZXSVKDJ;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly RZEBZAJXRFZ SGIKGKCYUKQ;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly RZEBZAJXRFZ KUDVVSHFTIR;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly RZEBZAJXRFZ KJOZDVSKAXK;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class YEQWBVTAFPF
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class VYTOQMEUUFV
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class FPDPCLYXWJV
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class HRPMUGJSGLZ
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly RZEBZAJXRFZ XCFNNGTXEJO;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly RZEBZAJXRFZ EZMDIXAVYSV;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class OECBKJXOHXT
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class PIRHHNKADKD
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class OJPIYEMOXZT
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class TXNYPYFWSCC
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly RZEBZAJXRFZ PDTYEAIWFAI;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly RZEBZAJXRFZ ZCNKHCTDZHK;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly RZEBZAJXRFZ OMPPLNEODQJ;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly RZEBZAJXRFZ VTFVRIFMLUW;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly RZEBZAJXRFZ SWPFBWYUWNE;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly RZEBZAJXRFZ EJFQBQQGXDZ;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly RZEBZAJXRFZ BCTTDZGMKAO;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly RZEBZAJXRFZ OFUNLSPKGCD;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly RZEBZAJXRFZ VOTQNFLHACZ;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly RZEBZAJXRFZ EYMHFQRHEDN;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly RZEBZAJXRFZ TVOBRLAGRFH;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly RZEBZAJXRFZ VVKGTWOUXMH;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly RZEBZAJXRFZ IDFWIOHPEXK;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly RZEBZAJXRFZ KMFOWPWSJCZ;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly RZEBZAJXRFZ VELSTFSVIKU;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly RZEBZAJXRFZ CPJCZCYOWDG;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly RZEBZAJXRFZ GKFJKUCOCBI;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly RZEBZAJXRFZ FCZWVUVSYLR;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly RZEBZAJXRFZ LQPUREONERU;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly RZEBZAJXRFZ YHAIKERCMOU;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly RZEBZAJXRFZ UNMXSIVAOKL;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly RZEBZAJXRFZ EHISVNQZUCP;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly RZEBZAJXRFZ CTKSAGDNOAT;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly RZEBZAJXRFZ JBLQYJBHGTZ;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly RZEBZAJXRFZ JIOHFZSUKER;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly RZEBZAJXRFZ LFGPHKHGMRD;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly RZEBZAJXRFZ WIWCIPURWYJ;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly RZEBZAJXRFZ HXBAIGQXUOB;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly RZEBZAJXRFZ NNUENKNMYTS;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly RZEBZAJXRFZ IKPUBTBXUII;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly RZEBZAJXRFZ ONJISRMPAAJ;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly RZEBZAJXRFZ VFLXLXGGQXH;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly RZEBZAJXRFZ WLUVLFHMDTS;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly RZEBZAJXRFZ UYREVXITAYE;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly RZEBZAJXRFZ KVMLZYEJJJW;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly RZEBZAJXRFZ WZMCUEIJWOI;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly RZEBZAJXRFZ JDRPLLLCDOM;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly RZEBZAJXRFZ NHQLKCZMXVU;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly RZEBZAJXRFZ PVYEAZDUDYK;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly RZEBZAJXRFZ CLQCODIMIUO;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly RZEBZAJXRFZ CFNOSBXCACZ;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly RZEBZAJXRFZ FVDMGSWHHIZ;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly RZEBZAJXRFZ DRJXZGYMROL;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly RZEBZAJXRFZ DJKNQSBQDAJ;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly RZEBZAJXRFZ KCVSSVDVHBF;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly RZEBZAJXRFZ AAYTOVHSQBZ;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly RZEBZAJXRFZ DUKHGFOOZRH;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly RZEBZAJXRFZ OQXJPKFSMPB;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly RZEBZAJXRFZ PWXUYIGDBTX;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly RZEBZAJXRFZ BNTWYJAVSBZ;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly RZEBZAJXRFZ LQVYMHVGUQC;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly RZEBZAJXRFZ WIUVNYDAFMR;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly RZEBZAJXRFZ DATNLQXOZTL;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly RZEBZAJXRFZ YILRWXYGODL;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly RZEBZAJXRFZ UMUKIMGYWTV;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly RZEBZAJXRFZ QACZSHYSJPL;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly RZEBZAJXRFZ EWGESQBVCKP;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly RZEBZAJXRFZ ZOUAAOZARXJ;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly RZEBZAJXRFZ IXSAIWSZCVD;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly RZEBZAJXRFZ MRFLVKLGCKL;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly RZEBZAJXRFZ DBNLVCUEHKB;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly RZEBZAJXRFZ GTRYAGABEJB;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly RZEBZAJXRFZ VACAJAIWZGW;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly RZEBZAJXRFZ SUMKCDEHZWR;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly RZEBZAJXRFZ NHGBIIUUVLX;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly RZEBZAJXRFZ ZSQYTXWGTXO;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly RZEBZAJXRFZ AKVODGKHPTS;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly RZEBZAJXRFZ JPCIVZKHOEL;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly RZEBZAJXRFZ EPGAMRZMRRZ;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class LTPAREZTXCQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class JRNFRKRMRXH
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly RZEBZAJXRFZ AJQIEGYVDMH;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly RZEBZAJXRFZ VSSEWKEKSCM;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly RZEBZAJXRFZ DYZYLODCMYY;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly RZEBZAJXRFZ EKYJOTQCGWX;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly RZEBZAJXRFZ SGPLXLVDATR;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly RZEBZAJXRFZ RWPAQQLLIRT;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly RZEBZAJXRFZ TRXCLJQIHAL;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class JBQEYPOCGLK
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly RZEBZAJXRFZ ZCNKHCTDZHK;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly RZEBZAJXRFZ OMPPLNEODQJ;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly RZEBZAJXRFZ VTFVRIFMLUW;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly RZEBZAJXRFZ SKCTBOYLCKU;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly RZEBZAJXRFZ FSLEHQANIMI;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly RZEBZAJXRFZ AXFLSPCFKQQ;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly RZEBZAJXRFZ UVZSCOOFDXK;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class TXDZQBKEBUW
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly RZEBZAJXRFZ GQMLEZKAZNI;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly RZEBZAJXRFZ NOBFOGSLZAA;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly RZEBZAJXRFZ PORVJPSQTKZ;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly RZEBZAJXRFZ RZSNWLZGFOX;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly RZEBZAJXRFZ IFVEYBYIQIB;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly RZEBZAJXRFZ OKBABFTAEBX;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class WRBYLJUPQWR
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class VUUEBIGSJMQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly RZEBZAJXRFZ JRBALAWIXUC;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class VRVRALDCIGO
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly RZEBZAJXRFZ PDTYEAIWFAI;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class ODEPUVRYYDL
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class GZLOBIVSAKW
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class SKKOWZLQJJF
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly RZEBZAJXRFZ TXGVWEBPJOV;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly RZEBZAJXRFZ FYLMLYEXSKL;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly RZEBZAJXRFZ EHDRZERCTEK;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly RZEBZAJXRFZ MKOJBAPMKFI;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class PESJICRMCVH
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly RZEBZAJXRFZ ELWJHYRDLCG;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly RZEBZAJXRFZ NQIXFMYIYQX;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class JCTOLGYAJAR
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class JZXDDJUVJJH
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly RZEBZAJXRFZ AJQIEGYVDMH;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly RZEBZAJXRFZ VSSEWKEKSCM;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class EWXLJUEAYYC
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly RZEBZAJXRFZ RVIPFJBRCKR;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly RZEBZAJXRFZ EKYJOTQCGWX;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly RZEBZAJXRFZ SGPLXLVDATR;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly RZEBZAJXRFZ RWPAQQLLIRT;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly RZEBZAJXRFZ DJKGDADHPGW;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly RZEBZAJXRFZ MCKBCSIPHGL;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly RZEBZAJXRFZ XGYRKFRYVGP;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly RZEBZAJXRFZ AKLRLTRQNYF;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly RZEBZAJXRFZ HVQVADSNLFU;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly RZEBZAJXRFZ DDXKOQUROGO;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly RZEBZAJXRFZ AJQIEGYVDMH;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly RZEBZAJXRFZ VSSEWKEKSCM;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class SDXEUALLLFE
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class NQSUGSKBNWW
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly RZEBZAJXRFZ AJQIEGYVDMH;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly RZEBZAJXRFZ VSSEWKEKSCM;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly RZEBZAJXRFZ AEJWZVDOVYU;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly RZEBZAJXRFZ FBNUKKJSRXY;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly RZEBZAJXRFZ VQUXBXKIYQB;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class JNYYVKSDFNL
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class ODKTCDDSZHO
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly RZEBZAJXRFZ ZQJGVDVHQWJ;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class WZXTJZXAVLO
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly RZEBZAJXRFZ OEHJULMQUZS;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly RZEBZAJXRFZ EYPFSGOAEMR;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly RZEBZAJXRFZ AJQIEGYVDMH;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly RZEBZAJXRFZ VSSEWKEKSCM;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class ZRWSTTOAXVB
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class EFTASKRIBRV
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class FLYBKXTNQKI
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class OQDBMRXTFUU
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class JFXHWBCALEF
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class KUOBNICPXBD
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly RZEBZAJXRFZ XCFNNGTXEJO;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly RZEBZAJXRFZ EZMDIXAVYSV;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class NPJENXCPVNB
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly RZEBZAJXRFZ YFGGGXHKREW;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly RZEBZAJXRFZ PKMVYSJAFQQ;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly RZEBZAJXRFZ JIXLPYCJLXG;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly RZEBZAJXRFZ ALLDAPSXIEW;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class XJQPBXEZLGM
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly RZEBZAJXRFZ YFGGGXHKREW;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly RZEBZAJXRFZ PKMVYSJAFQQ;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly RZEBZAJXRFZ JIXLPYCJLXG;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly RZEBZAJXRFZ ALLDAPSXIEW;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class EMCGHDFJBRP
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class RIRKPQQNNOW
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly RZEBZAJXRFZ KCUVUVUFRJT;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly RZEBZAJXRFZ CCTHMOSDHDZ;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly RZEBZAJXRFZ YMYFMALIBUT;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class KEKEHEKTKIP
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly RZEBZAJXRFZ RBCJSSBYOPG;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly RZEBZAJXRFZ YLUIJMSKXHY;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly RZEBZAJXRFZ FILPARGXDWT;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class TWYYBRLDKFE
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class GBPZNKAFPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly RZEBZAJXRFZ CRROGVEACAD;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly RZEBZAJXRFZ PDJWGRVAFSV;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly RZEBZAJXRFZ UIQHQAXGGAW;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly RZEBZAJXRFZ IWOZFSDEDTI;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly RZEBZAJXRFZ BWLFZRMWKWT;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class IPUVUGIECDY
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly RZEBZAJXRFZ FSGCCDBDTUP;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class CWPDFQZNQCE
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly RZEBZAJXRFZ GHJTRDMHNVE;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly RZEBZAJXRFZ ORCGJJRQEMX;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly RZEBZAJXRFZ YGLRRPXWABA;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class ROTVTITBEGF
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class SKAUFKYWMRX
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class YGYTITCRQHW
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class VXJBXVTIITJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly RZEBZAJXRFZ AGEIKSCGZIU;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly RZEBZAJXRFZ QOZQGRUTBUZ;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly RZEBZAJXRFZ TNOSBJZJOGH;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly RZEBZAJXRFZ JOGOPLNJHVV;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly RZEBZAJXRFZ SPBDHVTSYZW;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly RZEBZAJXRFZ PKPPVZEYCGW;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly RZEBZAJXRFZ PXMUMGGZMYR;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class WTTBGMSHFVJ
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly RZEBZAJXRFZ AOUTQFAYXTQ;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly RZEBZAJXRFZ[] PFHHYDRQATA;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class FSRQOCPNDRD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly RVNMAEXWNBU YBSFDHPBJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<RZEBZAJXRFZ> WAWYZUTJCNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<RZEBZAJXRFZ> GRVZIBYIHFP;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<RZEBZAJXRFZ> OZNQVZLXZYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<RZEBZAJXRFZ> UWVXAACUYMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x29357F0", Offset = "0x2933FF0", VA = "0x1829357F0")]
		protected FSRQOCPNDRD(RVNMAEXWNBU a, params RZEBZAJXRFZ[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class BLOVSBTZRVB : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2932F40", Offset = "0x2931740", VA = "0x182932F40")]
		internal BLOVSBTZRVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ONAQLWQCYNG : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x293CC30", Offset = "0x293B430", VA = "0x18293CC30")]
		internal ONAQLWQCYNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ZMHVJSQENDR : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2943640", Offset = "0x2941E40", VA = "0x182943640")]
		internal ZMHVJSQENDR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class TZHCHATCGFS : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x293FC90", Offset = "0x293E490", VA = "0x18293FC90")]
		internal TZHCHATCGFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class CBMOWEQVJXF : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2933380", Offset = "0x2931B80", VA = "0x182933380")]
		internal CBMOWEQVJXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class LQMRNFUEGGH : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x293A9D0", Offset = "0x29391D0", VA = "0x18293A9D0")]
		internal LQMRNFUEGGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class VWISJYUQWMG : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2940FE0", Offset = "0x293F7E0", VA = "0x182940FE0")]
		internal VWISJYUQWMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class UDRGBIBCOVN : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x293FE70", Offset = "0x293E670", VA = "0x18293FE70")]
		internal UDRGBIBCOVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class HFWDOEMEVNR : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x29370B0", Offset = "0x29358B0", VA = "0x1829370B0")]
		internal HFWDOEMEVNR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class TPNZXWLVIOP : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x293EF80", Offset = "0x293D780", VA = "0x18293EF80")]
		internal TPNZXWLVIOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class DJEYRWJDPKT : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x29339A0", Offset = "0x29321A0", VA = "0x1829339A0")]
		internal DJEYRWJDPKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class YVDOQSACAHN : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2943200", Offset = "0x2941A00", VA = "0x182943200")]
		internal YVDOQSACAHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class BGLOKWTUEWX : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2932D60", Offset = "0x2931560", VA = "0x182932D60")]
		internal BGLOKWTUEWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class DXIEXRCQUHD : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2934190", Offset = "0x2932990", VA = "0x182934190")]
		internal DXIEXRCQUHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class YJIEJKBGESN : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2942E40", Offset = "0x2941640", VA = "0x182942E40")]
		internal YJIEJKBGESN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class FMXQLGZWFXF : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x29351D0", Offset = "0x29339D0", VA = "0x1829351D0")]
		internal FMXQLGZWFXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class XDPUBJDUQUV : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2942420", Offset = "0x2940C20", VA = "0x182942420")]
		internal XDPUBJDUQUV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class MBRHVPATFWM : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x293AFD0", Offset = "0x29397D0", VA = "0x18293AFD0")]
		internal MBRHVPATFWM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class DRIHWQXDNYC : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2933D60", Offset = "0x2932560", VA = "0x182933D60")]
		internal DRIHWQXDNYC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class SETAEBTXNJC : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x293E310", Offset = "0x293CB10", VA = "0x18293E310")]
		internal SETAEBTXNJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class DRJUYICKYPI : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2933F40", Offset = "0x2932740", VA = "0x182933F40")]
		internal DRJUYICKYPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class KILHDJKGEPQ : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2939FD0", Offset = "0x29387D0", VA = "0x182939FD0")]
		internal KILHDJKGEPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class VIZGYWORWFD : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2940650", Offset = "0x293EE50", VA = "0x182940650")]
		internal VIZGYWORWFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class MLYXWOZPLDQ : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x293B390", Offset = "0x2939B90", VA = "0x18293B390")]
		internal MLYXWOZPLDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class NXNDEMCDAVX : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x293C4C0", Offset = "0x293ACC0", VA = "0x18293C4C0")]
		internal NXNDEMCDAVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class FYBXIWOIHDC : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2935960", Offset = "0x2934160", VA = "0x182935960")]
		internal FYBXIWOIHDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class TUGFIYKHWYK : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x293F160", Offset = "0x293D960", VA = "0x18293F160")]
		internal TUGFIYKHWYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class WISHOWWOESE : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x29417B0", Offset = "0x293FFB0", VA = "0x1829417B0")]
		internal WISHOWWOESE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TJFJJTINFUJ : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x293EDA0", Offset = "0x293D5A0", VA = "0x18293EDA0")]
		internal TJFJJTINFUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class VQHQAYKHDIU : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2940830", Offset = "0x293F030", VA = "0x182940830")]
		internal VQHQAYKHDIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class IUTHAKUDWHZ : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2937830", Offset = "0x2936030", VA = "0x182937830")]
		internal IUTHAKUDWHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class KMFCHRXKXMB : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x293A230", Offset = "0x2938A30", VA = "0x18293A230")]
		internal KMFCHRXKXMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class AGPWGPLQJRT : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2932920", Offset = "0x2931120", VA = "0x182932920")]
		internal AGPWGPLQJRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ZFGSSBPVOBG : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x29433E0", Offset = "0x2941BE0", VA = "0x1829433E0")]
		internal ZFGSSBPVOBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class WCWCBHLYVYU : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x29415D0", Offset = "0x293FDD0", VA = "0x1829415D0")]
		internal WCWCBHLYVYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class NSDVABFRHGU : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x293C260", Offset = "0x293AA60", VA = "0x18293C260")]
		internal NSDVABFRHGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class YKHJZXWKVNX : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2943020", Offset = "0x2941820", VA = "0x182943020")]
		internal YKHJZXWKVNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class FPETXYNSAZU : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2935590", Offset = "0x2933D90", VA = "0x182935590")]
		internal FPETXYNSAZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ALRWXVBIBQC : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2932B00", Offset = "0x2931300", VA = "0x182932B00")]
		internal ALRWXVBIBQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class PQQPNCIIFLR : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x293D8A0", Offset = "0x293C0A0", VA = "0x18293D8A0")]
		internal PQQPNCIIFLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class VVJLAAUSYGT : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2940E00", Offset = "0x293F600", VA = "0x182940E00")]
		internal VVJLAAUSYGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class FPBCQQNPVWH : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x29353B0", Offset = "0x2933BB0", VA = "0x1829353B0")]
		internal FPBCQQNPVWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class GTZYTLVBGAS : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2936680", Offset = "0x2934E80", VA = "0x182936680")]
		internal GTZYTLVBGAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class OPFFJRMWTLU : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x293CD90", Offset = "0x293B590", VA = "0x18293CD90")]
		internal OPFFJRMWTLU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class AFAIZLDMQUF : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2932740", Offset = "0x2930F40", VA = "0x182932740")]
		internal AFAIZLDMQUF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class GRNRZSYUBHG : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x29364A0", Offset = "0x2934CA0", VA = "0x1829364A0")]
		internal GRNRZSYUBHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class UUTYRFRMVNN : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2940470", Offset = "0x293EC70", VA = "0x182940470")]
		internal UUTYRFRMVNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class RVYADTKELDQ : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x293E070", Offset = "0x293C870", VA = "0x18293E070")]
		internal RVYADTKELDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class LMWIWKKPWOE : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x293A7F0", Offset = "0x2938FF0", VA = "0x18293A7F0")]
		internal LMWIWKKPWOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class OVNOFOSOUOF : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x293CFD0", Offset = "0x293B7D0", VA = "0x18293CFD0")]
		internal OVNOFOSOUOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class LWRTQQPWMCR : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x293AC10", Offset = "0x2939410", VA = "0x18293AC10")]
		internal LWRTQQPWMCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class MKADKWTBSRC : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x293B1B0", Offset = "0x29399B0", VA = "0x18293B1B0")]
		internal MKADKWTBSRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class OYSPISUCVAR : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x293D1B0", Offset = "0x293B9B0", VA = "0x18293D1B0")]
		internal OYSPISUCVAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class UFTDBMGMHBO : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2940050", Offset = "0x293E850", VA = "0x182940050")]
		internal UFTDBMGMHBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class LXJJDKLHNCG : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x293ADF0", Offset = "0x29395F0", VA = "0x18293ADF0")]
		internal LXJJDKLHNCG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class URDTLVHBYUG : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2940290", Offset = "0x293EA90", VA = "0x182940290")]
		internal URDTLVHBYUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class WVRZKEDQNTA : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2941C50", Offset = "0x2940450", VA = "0x182941C50")]
		internal WVRZKEDQNTA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class DPLQKSDLUAV : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2933B80", Offset = "0x2932380", VA = "0x182933B80")]
		internal DPLQKSDLUAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class IITYCARYNCE : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2937290", Offset = "0x2935A90", VA = "0x182937290")]
		internal IITYCARYNCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class GXFWZOWSIXQ : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2936860", Offset = "0x2935060", VA = "0x182936860")]
		internal GXFWZOWSIXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class IJGODVHDTVX : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2937470", Offset = "0x2935C70", VA = "0x182937470")]
		internal IJGODVHDTVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class PDKNEOGXFHI : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x293D390", Offset = "0x293BB90", VA = "0x18293D390")]
		internal PDKNEOGXFHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class EVNLEXGMGZF : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2934330", Offset = "0x2932B30", VA = "0x182934330")]
		internal EVNLEXGMGZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class XYNUMLJJWGM : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2942C80", Offset = "0x2941480", VA = "0x182942C80")]
		internal XYNUMLJJWGM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class BPXQEBXJKVE : FSRQOCPNDRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2933120", Offset = "0x2931920", VA = "0x182933120")]
		internal BPXQEBXJKVE()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, HOAFHMGXMKA<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly RVNMAEXWNBU Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
		private NamedType(string name, RVNMAEXWNBU type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2873CD0", Offset = "0x28724D0", VA = "0x182873CD0")]
		public static NamedType New(string name, RVNMAEXWNBU type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x293C760", Offset = "0x293AF60", VA = "0x18293C760")]
		public static bool SSVDESVOTBX([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x293C760", Offset = "0x293AF60", VA = "0x18293C760", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x293C760", Offset = "0x293AF60", VA = "0x18293C760")]
		public bool WWCFUGHNLCB([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x293C6A0", Offset = "0x293AEA0", VA = "0x18293C6A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x293C7B0", Offset = "0x293AFB0", VA = "0x18293C7B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x293C8E0", Offset = "0x293B0E0", VA = "0x18293C8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x293C8A0", Offset = "0x293B0A0", VA = "0x18293C8A0")]
		public string OBMPNJABOYF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x293C820", Offset = "0x293B020", VA = "0x18293C820")]
		public string MKSUCPDTKKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x293C760", Offset = "0x293AF60", VA = "0x18293C760", Slot = "5")]
		private bool LJHRNYSFEIQ([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface KIQIZMMDNIQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(UZPYRKQPSNH a, bool b);
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
