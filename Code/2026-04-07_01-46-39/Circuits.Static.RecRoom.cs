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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBBC90", Offset = "0x2BBAC90", VA = "0x182BBBC90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBB4A0", Offset = "0x2BBA4A0", VA = "0x182BBB4A0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GVETGLPTJFS
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9A10", Offset = "0x2BB8A10", VA = "0x182BB9A10")]
		public static bool FTQGASQMGXV(this EUKWVPLYZVT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9950", Offset = "0x2BB8950", VA = "0x182BB9950")]
		public static bool FTQGASQMGXV(this JFOXBOFRTHW a)
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
			private readonly SWFQECRPDPB _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			public EVRequest(SWFQECRPDPB staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class GLVWCVIOXGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<CQXXZYNUWDH>, FYNEQQIQDOQ> LNZZSSBOYYD;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<CQXXZYNUWDH>>? MGPKWPKBNZN;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<CQXXZYNUWDH> RHUDZVDZEIF;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<CQXXZYNUWDH> ZBURRICJKVQ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<CQXXZYNUWDH> TMUHBRYEXAR;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<CQXXZYNUWDH> SQOAUCWSJHK;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<CQXXZYNUWDH> JJZJGHNPOER;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<CQXXZYNUWDH> GGCJYCGLZZI;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<CQXXZYNUWDH> UFQYYSDWOJG;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<CQXXZYNUWDH> RDCJGBYPJQY;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<CQXXZYNUWDH> XWXCOISNZXO;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<CQXXZYNUWDH> IFQVRNFPLKU;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<CQXXZYNUWDH> XNXYITZGLCC;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<CQXXZYNUWDH> KNVFKNIVECC;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<CQXXZYNUWDH> OVCMRKCDENF;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<CQXXZYNUWDH> VPRNMCQOWQB;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<CQXXZYNUWDH> VKJKZSISBAV;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<CQXXZYNUWDH> AGOZUXMOGMG;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<CQXXZYNUWDH> RZIESTSNHLL;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<CQXXZYNUWDH> RKAFEOTONQL;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<CQXXZYNUWDH> LBOFSARIBKM;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<CQXXZYNUWDH> TUKHCTRIQDF;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<CQXXZYNUWDH> HCKPHTRJPDQ;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<CQXXZYNUWDH> EFVRJPMMYLJ;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<CQXXZYNUWDH> XNGVKDDHMGF;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<CQXXZYNUWDH> IUISKMXNPFQ;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<CQXXZYNUWDH> DUOIJCBXQKW;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<CQXXZYNUWDH> RTXMFLNSHYF;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<CQXXZYNUWDH> WJHZVZALXMQ;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<CQXXZYNUWDH> KCKJZJCHVEF;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<CQXXZYNUWDH> SPBDUGZUCMZ;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<CQXXZYNUWDH> VMXLMTGCHXV;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<CQXXZYNUWDH> KQQHRUVAYBL;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<CQXXZYNUWDH> KASGGKCAOFW;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<CQXXZYNUWDH> ZLTYGZRKKDJ;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<CQXXZYNUWDH> GQWEUFXOSBP;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<CQXXZYNUWDH> QJSNGYVQGCZ;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<CQXXZYNUWDH> WMNIFMUVDZE;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<CQXXZYNUWDH> ZBZSQPJANMT;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<CQXXZYNUWDH> HNJXADENUJG;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<CQXXZYNUWDH> CYILUOBOULS;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<CQXXZYNUWDH> NJMKZGWWQKQ;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<CQXXZYNUWDH> PRBNRALGHRB;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<CQXXZYNUWDH> IQBNWKPXBXJ;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<CQXXZYNUWDH> RHXMGDCALNG;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<CQXXZYNUWDH> MOKBMAMICYT;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<CQXXZYNUWDH> HHQFIZZPXCT;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<CQXXZYNUWDH> UTWRFGSILKJ;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<CQXXZYNUWDH> TYJVKCNYYKU;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<CQXXZYNUWDH> JLCBVIDRUFE;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<CQXXZYNUWDH> KAFSYKXXSIU;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<CQXXZYNUWDH> KYQQHKDVTAF;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<CQXXZYNUWDH> CYCDOGWHYAB;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<CQXXZYNUWDH> OWMFKQNUSRE;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<CQXXZYNUWDH> TYRQRRDOULX;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<CQXXZYNUWDH> IIFSIKAKTOT;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<CQXXZYNUWDH> XCQQZPXTYOG;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<CQXXZYNUWDH> HMNLRDPMFCU;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<CQXXZYNUWDH> BGEXSTFHNFW;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<CQXXZYNUWDH> OZTTBXRNBUA;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<CQXXZYNUWDH> AMQVFMEIPNF;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<CQXXZYNUWDH> ECTGZLXIIOG;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<CQXXZYNUWDH> KBUEIORDKAA;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<CQXXZYNUWDH> RVSCHPMTGBS;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<CQXXZYNUWDH> UUQCIJLJOTJ;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<CQXXZYNUWDH> CWNKBLOSPHX;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<CQXXZYNUWDH> IOLVUAAWPWA;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<CQXXZYNUWDH> TKURGPBQYGP;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<CQXXZYNUWDH> PHFGJZPVNXS;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<CQXXZYNUWDH> EKVYOJLFVZQ;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<CQXXZYNUWDH> KKSXIBNCFAM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<CQXXZYNUWDH>, FYNEQQIQDOQ> VSBNRIBCMVK
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB44A0", Offset = "0x2BB34A0", VA = "0x182BB44A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4890", Offset = "0x2BB3890", VA = "0x182BB4890")]
			public static FYNEQQIQDOQ ZYNTXKHCLCI(Id32<CQXXZYNUWDH> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB44F0", Offset = "0x2BB34F0", VA = "0x182BB44F0")]
			public static bool LOJIDGPSDUB(Id32<CQXXZYNUWDH> id, [Out] FYNEQQIQDOQ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4610", Offset = "0x2BB3610", VA = "0x182BB4610")]
			public static EUKWVPLYZVT PFFGWXLWCAV(Id32<CQXXZYNUWDH> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4580", Offset = "0x2BB3580", VA = "0x182BB4580")]
			private static Id32<CQXXZYNUWDH> OTSRDIPIITJ(FYNEQQIQDOQ a, Id32<CQXXZYNUWDH> id)
			{
				return default(Id32<CQXXZYNUWDH>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB46C0", Offset = "0x2BB36C0", VA = "0x182BB46C0")]
			private static void RFDZBAGUQGX(Id32<CQXXZYNUWDH> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class YGHLTEEVSGB
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<SNPPUNKBJMN, EUKWVPLYZVT?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
				private TypeRegistryFactory([In] IdUnsafeList<SNPPUNKBJMN, EUKWVPLYZVT?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BC39A0", Offset = "0x2BC29A0", VA = "0x182BC39A0")]
				public static TypeRegistryFactory FACRFPUWRCL()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3BD0", Offset = "0x2BC2BD0", VA = "0x182BC3BD0")]
				public (ReadOnlyIdArray<SNPPUNKBJMN, EUKWVPLYZVT>, IReadOnlyDictionary<EUKWVPLYZVT, Id32<SNPPUNKBJMN>>) ZQHOKUWTOCH()
				{
					return default((ReadOnlyIdArray<SNPPUNKBJMN, EUKWVPLYZVT>, IReadOnlyDictionary<EUKWVPLYZVT, Id32<SNPPUNKBJMN>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3A50", Offset = "0x2BC2A50", VA = "0x182BC3A50")]
				public Id32<SNPPUNKBJMN> MCLXESOJDRX(int a, EUKWVPLYZVT b)
				{
					return default(Id32<SNPPUNKBJMN>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BC3A00", Offset = "0x2BC2A00", VA = "0x182BC3A00")]
				public Id32<SNPPUNKBJMN> Initialize(int id, QNRICJJABYK type, QNRICJJABYK factoryType)
				{
					return default(Id32<SNPPUNKBJMN>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class KAYWYUVCBCI
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<SNPPUNKBJMN> ITRFKOVHOBJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB130", Offset = "0x2BBA130", VA = "0x182BBB130")]
					[CompilerGenerated]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BBA1F0", VA = "0x182BBB1F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<SNPPUNKBJMN> WBTCCGKNBDZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB2F0", Offset = "0x2BBA2F0", VA = "0x182BBB2F0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB230", Offset = "0x2BBA230", VA = "0x182BBB230")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<SNPPUNKBJMN> KFCFBYWIXOQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB3B0", Offset = "0x2BBA3B0", VA = "0x182BBB3B0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB270", Offset = "0x2BBA270", VA = "0x182BBB270")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<SNPPUNKBJMN> KNUKSYGNVCS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB370", Offset = "0x2BBA370", VA = "0x182BBB370")]
					[CompilerGenerated]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB1B0", Offset = "0x2BBA1B0", VA = "0x182BBB1B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<SNPPUNKBJMN> VOFVUNACUCG
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB3F0", Offset = "0x2BBA3F0", VA = "0x182BBB3F0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB330", Offset = "0x2BBA330", VA = "0x182BBB330")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<SNPPUNKBJMN> BPTMWRLTCRV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB2B0", Offset = "0x2BBA2B0", VA = "0x182BBB2B0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB170", Offset = "0x2BBA170", VA = "0x182BBB170")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class NLTFPHGHKQC : IEnumerable<EUKWVPLYZVT>, IEnumerable, IEnumerator<EUKWVPLYZVT>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int KVXTPCCUFNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private EUKWVPLYZVT NNNUNWANACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int LNNEGLEATET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool GOROTCVFOBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool AYNXRNBGXUA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion TJVETQPFOCT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion SAJVPDVSRBW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool VJWDMFDQZPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool XQKSOMMHAST;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool EMVPFDHAGUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool RWJGZTCCNJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool AGMJSDAYAWI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool ILIQGDMUZAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool TAFWWSJMHRA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool XHNNXDZDWIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<EUKWVPLYZVT> PQBFSTXQTPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private EUKWVPLYZVT EZFNAFVTEWT;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private EUKWVPLYZVT PLKIHQKOBVU
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object BVCEDTADISM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
				[DebuggerHidden]
				public NLTFPHGHKQC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BBBBC0", Offset = "0x2BBABC0", VA = "0x182BBBBC0", Slot = "7")]
				[DebuggerHidden]
				private void OHWWSGWCEEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB7D0", Offset = "0x2BBA7D0", VA = "0x182BBB7D0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB780", Offset = "0x2BBA780", VA = "0x182BBB780")]
				private void LZWZIAQZAET()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BBBC50", Offset = "0x2BBAC50", VA = "0x182BBBC50", Slot = "10")]
				[DebuggerHidden]
				private void UCVOSCIFQDQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB6C0", Offset = "0x2BBA6C0", VA = "0x182BBB6C0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<EUKWVPLYZVT> BCRNWYVLJSF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB6C0", Offset = "0x2BBA6C0", VA = "0x182BBB6C0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator YIRXJWVWWXR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class GOYXUJDLEKY : IEnumerable<EUKWVPLYZVT>, IEnumerable, IEnumerator<EUKWVPLYZVT>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int KVXTPCCUFNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private EUKWVPLYZVT NNNUNWANACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int LNNEGLEATET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion TJVETQPFOCT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion SAJVPDVSRBW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool EMVPFDHAGUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool RWJGZTCCNJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool VJWDMFDQZPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool XQKSOMMHAST;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool FSMATRTNNFY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool XPZLMSSSMMD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool AGMJSDAYAWI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool ILIQGDMUZAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool IDZEWMVOVKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool PCNEHANWOEO;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private EUKWVPLYZVT PLKIHQKOBVU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object BVCEDTADISM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
				[DebuggerHidden]
				public GOYXUJDLEKY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
				[DebuggerHidden]
				private void OHWWSGWCEEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7A00", Offset = "0x2BB6A00", VA = "0x182BB7A00", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9910", Offset = "0x2BB8910", VA = "0x182BB9910", Slot = "10")]
				[DebuggerHidden]
				private void UCVOSCIFQDQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7950", Offset = "0x2BB6950", VA = "0x182BB7950", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<EUKWVPLYZVT> BCRNWYVLJSF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7950", Offset = "0x2BB6950", VA = "0x182BB7950", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator YIRXJWVWWXR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class GYKZDTEDMUL : IEnumerable<Id32<SNPPUNKBJMN>>, IEnumerable, IEnumerator<Id32<SNPPUNKBJMN>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int KVXTPCCUFNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<SNPPUNKBJMN> NNNUNWANACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int LNNEGLEATET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion TJVETQPFOCT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion SAJVPDVSRBW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool VJWDMFDQZPS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool XQKSOMMHAST;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool EMVPFDHAGUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool RWJGZTCCNJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool AGMJSDAYAWI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool ILIQGDMUZAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool TAFWWSJMHRA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool XHNNXDZDWIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<EUKWVPLYZVT> PQBFSTXQTPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<QNRICJJABYK> PPVYVNDTKED;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<SNPPUNKBJMN> QANOCKSALSF
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xE01B10", Offset = "0xE00B10", VA = "0x180E01B10", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<SNPPUNKBJMN>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object BVCEDTADISM
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2BB9BD0", Offset = "0x2BB8BD0", VA = "0x182BB9BD0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15B89F0", Offset = "0x15B79F0", VA = "0x1815B89F0")]
				[DebuggerHidden]
				public GYKZDTEDMUL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA1C0", Offset = "0x2BB91C0", VA = "0x182BBA1C0", Slot = "7")]
				[DebuggerHidden]
				private void OHWWSGWCEEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9CC0", Offset = "0x2BB8CC0", VA = "0x182BB9CC0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9C20", Offset = "0x2BB8C20", VA = "0x182BB9C20")]
				private void LZWZIAQZAET()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9C70", Offset = "0x2BB8C70", VA = "0x182BB9C70")]
				private void MACGFHKWJQC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BBA310", Offset = "0x2BB9310", VA = "0x182BBA310", Slot = "10")]
				[DebuggerHidden]
				private void UCVOSCIFQDQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9B20", Offset = "0x2BB8B20", VA = "0x182BB9B20", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<SNPPUNKBJMN>> LRSBFQKJPNM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9B20", Offset = "0x2BB8B20", VA = "0x182BB9B20", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator YIRXJWVWWXR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log NSTUKEGGGWA;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<SNPPUNKBJMN, EUKWVPLYZVT?> GVDLCXBDUIG;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<EUKWVPLYZVT, Id32<SNPPUNKBJMN>> DMNLFOQWSMW;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly JFOXBOFRTHW XVHXDBJSSHB;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly JFOXBOFRTHW ZQUTIYCMELB;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<EUKWVPLYZVT> AARAGYZBDNL;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<EUKWVPLYZVT> OWSEBXULWDS;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet SYSRZVEFJGZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet IOKFNZIWXXL
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet CUHJREHHRYL
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static EUKWVPLYZVT ITRFKOVHOBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6EE0", Offset = "0x2BC5EE0", VA = "0x182BC6EE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static EUKWVPLYZVT WBTCCGKNBDZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8670", Offset = "0x2BC7670", VA = "0x182BC8670")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static EUKWVPLYZVT KFCFBYWIXOQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9DA0", Offset = "0x2BC8DA0", VA = "0x182BC9DA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static EUKWVPLYZVT KNUKSYGNVCS
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9C00", Offset = "0x2BC8C00", VA = "0x182BC9C00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static EUKWVPLYZVT JSVOVRSWZNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BC72C0", Offset = "0x2BC62C0", VA = "0x182BC72C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static EUKWVPLYZVT DGNWOAOXBVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9EF0", Offset = "0x2BC8EF0", VA = "0x182BC9EF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static EUKWVPLYZVT QQNIDUYCKFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8E40", Offset = "0x2BC7E40", VA = "0x182BC8E40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static EUKWVPLYZVT VOFVUNACUCG
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA2A0", Offset = "0x2BC92A0", VA = "0x182BCA2A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static QNRICJJABYK XOROOKTCMUO
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9A90", Offset = "0x2BC8A90", VA = "0x182BC9A90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static QNRICJJABYK NLYGJWVLJVP
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9350", Offset = "0x2BC8350", VA = "0x182BC9350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static QNRICJJABYK KIMSGURQABI
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6A00", Offset = "0x2BC5A00", VA = "0x182BC6A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static QNRICJJABYK YGYQPDXZAII
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC78E0", Offset = "0x2BC68E0", VA = "0x182BC78E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static QNRICJJABYK YSSGRYXZOUI
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9C90", Offset = "0x2BC8C90", VA = "0x182BC9C90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static QNRICJJABYK FHTCKKBNKYH
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7030", Offset = "0x2BC6030", VA = "0x182BC7030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static QNRICJJABYK KGEDCSJIVYL
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7AB0", Offset = "0x2BC6AB0", VA = "0x182BC7AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static QNRICJJABYK VGBAQWWWRHB
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7270", Offset = "0x2BC6270", VA = "0x182BC7270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static QNRICJJABYK EDEPQNTFHSO
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6250", Offset = "0x2BC5250", VA = "0x182BC6250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static QNRICJJABYK TRKHYNDPQRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7890", Offset = "0x2BC6890", VA = "0x182BC7890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static QNRICJJABYK QDHQNFJDESJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA390", Offset = "0x2BC9390", VA = "0x182BCA390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static QNRICJJABYK CURERWGKIGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7840", Offset = "0x2BC6840", VA = "0x182BC7840")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static QNRICJJABYK RAYFILVVYKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7220", Offset = "0x2BC6220", VA = "0x182BC7220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static QNRICJJABYK FBRNPNDSSPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8F30", Offset = "0x2BC7F30", VA = "0x182BC8F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static QNRICJJABYK JXDVKFJEEBU
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6F70", Offset = "0x2BC5F70", VA = "0x182BC6F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static QNRICJJABYK PQLIYRYVTEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9460", Offset = "0x2BC8460", VA = "0x182BC9460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static QNRICJJABYK NCSEDHUEAAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BC77E0", Offset = "0x2BC67E0", VA = "0x182BC77E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static QNRICJJABYK WNULTQEKDNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA240", Offset = "0x2BC9240", VA = "0x182BCA240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static QNRICJJABYK NLPYVWXKPAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7EA0", Offset = "0x2BC6EA0", VA = "0x182BC7EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static QNRICJJABYK AXCGWZKYJHJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9050", Offset = "0x2BC8050", VA = "0x182BC9050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static QNRICJJABYK OAZLOVOPWBI
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9950", Offset = "0x2BC8950", VA = "0x182BC9950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static QNRICJJABYK CEMXDPYIMSD
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8CC0", Offset = "0x2BC7CC0", VA = "0x182BC8CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static QNRICJJABYK KAJKCFDKUAJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA330", Offset = "0x2BC9330", VA = "0x182BCA330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static QNRICJJABYK MOOVRBKYFMX
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC84F0", Offset = "0x2BC74F0", VA = "0x182BC84F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static QNRICJJABYK SIQZSHQUVAT
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6300", Offset = "0x2BC5300", VA = "0x182BC6300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static QNRICJJABYK YHRHNEBUAQS
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9830", Offset = "0x2BC8830", VA = "0x182BC9830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static QNRICJJABYK COPYPVWOXXR
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6640", Offset = "0x2BC5640", VA = "0x182BC6640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static QNRICJJABYK VJWLOMHKRCN
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8550", Offset = "0x2BC7550", VA = "0x182BC8550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static QNRICJJABYK CZYRDRIBTQF
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7990", Offset = "0x2BC6990", VA = "0x182BC7990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static QNRICJJABYK WNTSABXRAWO
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6940", Offset = "0x2BC5940", VA = "0x182BC6940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static QNRICJJABYK FHTCOMCUDRS
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7660", Offset = "0x2BC6660", VA = "0x182BC7660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static QNRICJJABYK VNEGDIRQDAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6360", Offset = "0x2BC5360", VA = "0x182BC6360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static QNRICJJABYK YHQTIJDUFHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9110", Offset = "0x2BC8110", VA = "0x182BC9110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static QNRICJJABYK KOEHDITFMIT
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8110", Offset = "0x2BC7110", VA = "0x182BC8110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static QNRICJJABYK LDYWLDMQSCY
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8F90", Offset = "0x2BC7F90", VA = "0x182BC8F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static QNRICJJABYK ZMYHQKNPGAC
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8ED0", Offset = "0x2BC7ED0", VA = "0x182BC8ED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static QNRICJJABYK NDULMFODHBS
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9580", Offset = "0x2BC8580", VA = "0x182BC9580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static QNRICJJABYK IWOOJBQPODJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC98F0", Offset = "0x2BC88F0", VA = "0x182BC98F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static QNRICJJABYK AMWUZNYHQUH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9520", Offset = "0x2BC8520", VA = "0x182BC9520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static QNRICJJABYK XBWBBMQDUDM
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6190", Offset = "0x2BC5190", VA = "0x182BC6190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static QNRICJJABYK PJFDSZXXDKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6880", Offset = "0x2BC5880", VA = "0x182BC6880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static QNRICJJABYK FXVAQMHIEZM
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9D40", Offset = "0x2BC8D40", VA = "0x182BC9D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static QNRICJJABYK EATTGMRGQOQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BC90B0", Offset = "0x2BC80B0", VA = "0x182BC90B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static QNRICJJABYK MBSRQYDSGMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BC67C0", Offset = "0x2BC57C0", VA = "0x182BC67C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static QNRICJJABYK PAIQOIOEXVF
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA180", Offset = "0x2BC9180", VA = "0x182BCA180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static QNRICJJABYK LANRNMCHKZM
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BC93A0", Offset = "0x2BC83A0", VA = "0x182BC93A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static QNRICJJABYK VKERYYTYDXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BC68E0", Offset = "0x2BC58E0", VA = "0x182BC68E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static QNRICJJABYK MQTUTEYVWXP
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BC63F0", Offset = "0x2BC53F0", VA = "0x182BC63F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static QNRICJJABYK CMHMWNOOGAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BC82F0", Offset = "0x2BC72F0", VA = "0x182BC82F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static QNRICJJABYK LHFHTXQMTZU
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7930", Offset = "0x2BC6930", VA = "0x182BC7930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static QNRICJJABYK HUEFRQPMWOW
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BC80B0", Offset = "0x2BC70B0", VA = "0x182BC80B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static QNRICJJABYK QKKTCNPUQYQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8290", Offset = "0x2BC7290", VA = "0x182BC8290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static QNRICJJABYK WTFINAYGZBR
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8700", Offset = "0x2BC7700", VA = "0x182BC8700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static QNRICJJABYK CHRWEVYTDES
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA490", Offset = "0x2BC9490", VA = "0x182BCA490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static QNRICJJABYK BQXFNOUZTBV
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC79F0", Offset = "0x2BC69F0", VA = "0x182BC79F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static QNRICJJABYK BBMBPMHFDSP
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA040", Offset = "0x2BC9040", VA = "0x182BCA040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static QNRICJJABYK UNFZCVQUWDV
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7350", Offset = "0x2BC6350", VA = "0x182BC7350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static QNRICJJABYK VMWIJUCELGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6A50", Offset = "0x2BC5A50", VA = "0x182BC6A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static QNRICJJABYK HCZISRCTFFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BC92F0", Offset = "0x2BC82F0", VA = "0x182BC92F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static QNRICJJABYK WEONCFPMTRF
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8810", Offset = "0x2BC7810", VA = "0x182BC8810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static QNRICJJABYK LXXHDTJVGKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7780", Offset = "0x2BC6780", VA = "0x182BC7780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static QNRICJJABYK ZYMHPLXEHUE
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BC61F0", Offset = "0x2BC51F0", VA = "0x182BC61F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static QNRICJJABYK UZTKNVBBPIV
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6130", Offset = "0x2BC5130", VA = "0x182BC6130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static QNRICJJABYK PFIZBBGULRI
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA120", Offset = "0x2BC9120", VA = "0x182BCA120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static QNRICJJABYK CEEFGBAYPBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9BA0", Offset = "0x2BC8BA0", VA = "0x182BC9BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static QNRICJJABYK QUKNDLTDPMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BC62A0", Offset = "0x2BC52A0", VA = "0x182BC62A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static QNRICJJABYK MMJJHXAPZVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9F80", Offset = "0x2BC8F80", VA = "0x182BC9F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static QNRICJJABYK WYLTVUBCFFP
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC95E0", Offset = "0x2BC85E0", VA = "0x182BC95E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static QNRICJJABYK QMCCVRDKTQQ
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6700", Offset = "0x2BC5700", VA = "0x182BC6700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static QNRICJJABYK PVLUJTRHJBG
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6AB0", Offset = "0x2BC5AB0", VA = "0x182BC6AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static QNRICJJABYK FYMEMLOWXOE
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9FE0", Offset = "0x2BC8FE0", VA = "0x182BC9FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static QNRICJJABYK FHPRKAUMSCN
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7720", Offset = "0x2BC6720", VA = "0x182BC7720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static QNRICJJABYK QLUGVIRISQQ
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6820", Offset = "0x2BC5820", VA = "0x182BC6820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static QNRICJJABYK OWROGSIAGLW
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6B10", Offset = "0x2BC5B10", VA = "0x182BC6B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static QNRICJJABYK NEAHPMNVTMZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6450", Offset = "0x2BC5450", VA = "0x182BC6450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static QNRICJJABYK HOECJXNFZNR
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7F00", Offset = "0x2BC6F00", VA = "0x182BC7F00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static QNRICJJABYK HNZXIJRXBIW
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6760", Offset = "0x2BC5760", VA = "0x182BC6760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static QNRICJJABYK LDKTVEZTCJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8170", Offset = "0x2BC7170", VA = "0x182BC8170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static QNRICJJABYK MSQKNDDHUNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9AE0", Offset = "0x2BC8AE0", VA = "0x182BC9AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static QNRICJJABYK GLOMKYSJCAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9290", Offset = "0x2BC8290", VA = "0x182BC9290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static QNRICJJABYK XETVHUAQRSY
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BC71C0", Offset = "0x2BC61C0", VA = "0x182BC71C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static QNRICJJABYK ZTXBGYNRRYJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BC91D0", Offset = "0x2BC81D0", VA = "0x182BC91D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static QNRICJJABYK MLNMOCEBLPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8DE0", Offset = "0x2BC7DE0", VA = "0x182BC8DE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static QNRICJJABYK OCSMBZPGBCH
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC66A0", Offset = "0x2BC56A0", VA = "0x182BC66A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static QNRICJJABYK GZKATHYCBAT
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7E40", Offset = "0x2BC6E40", VA = "0x182BC7E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static QNRICJJABYK GRFXHIKNJWT
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BCA1E0", Offset = "0x2BC91E0", VA = "0x182BCA1E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static QNRICJJABYK SKMREPFDCST
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7160", Offset = "0x2BC6160", VA = "0x182BC7160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static QNRICJJABYK ZDSBGZEEOGL
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC81D0", Offset = "0x2BC71D0", VA = "0x182BC81D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static QNRICJJABYK FTNLDQMAGEC
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8FF0", Offset = "0x2BC7FF0", VA = "0x182BC8FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static QNRICJJABYK MHBQEPPOCMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BC76C0", Offset = "0x2BC66C0", VA = "0x182BC76C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static QNRICJJABYK CIKUWRFFZQM
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8350", Offset = "0x2BC7350", VA = "0x182BC8350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static QNRICJJABYK KDPXAADBWWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BC97D0", Offset = "0x2BC87D0", VA = "0x182BC97D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static QNRICJJABYK LQDLRVHBKIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9890", Offset = "0x2BC8890", VA = "0x182BC9890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static QNRICJJABYK KLLUCVIKVSF
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BC96B0", Offset = "0x2BC86B0", VA = "0x182BC96B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static QNRICJJABYK GDBDBWZONZM
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9770", Offset = "0x2BC8770", VA = "0x182BC9770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static QNRICJJABYK SBNDMHGAQCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BC64B0", Offset = "0x2BC54B0", VA = "0x182BC64B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static QNRICJJABYK HZUTLHAOTFJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BC69A0", Offset = "0x2BC59A0", VA = "0x182BC69A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static QNRICJJABYK HHUSXMSFNRU
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9230", Offset = "0x2BC8230", VA = "0x182BC9230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static QNRICJJABYK RMYSGOBMUWX
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7A50", Offset = "0x2BC6A50", VA = "0x182BC7A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static QNRICJJABYK HHTVNUSWHSX
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9E30", Offset = "0x2BC8E30", VA = "0x182BC9E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static QNRICJJABYK UPGQIAMXJEP
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8490", Offset = "0x2BC7490", VA = "0x182BC8490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static QNRICJJABYK LDIJXFEPIPC
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7DE0", Offset = "0x2BC6DE0", VA = "0x182BC7DE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static QNRICJJABYK WSWDKKAOIAL
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC85B0", Offset = "0x2BC75B0", VA = "0x182BC85B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static QNRICJJABYK NHEZEDMGCMB
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9170", Offset = "0x2BC8170", VA = "0x182BC9170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static QNRICJJABYK RDGIEUGQHVS
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9E90", Offset = "0x2BC8E90", VA = "0x182BC9E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static QNRICJJABYK JKQMILHIUIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BC94C0", Offset = "0x2BC84C0", VA = "0x182BC94C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static QNRICJJABYK PYIOMXTAYGE
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9400", Offset = "0x2BC8400", VA = "0x182BC9400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static QNRICJJABYK NZASKEDXPPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BC88D0", Offset = "0x2BC78D0", VA = "0x182BC88D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static QNRICJJABYK IPAVNYKZAXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9CE0", Offset = "0x2BC8CE0", VA = "0x182BC9CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static QNRICJJABYK BBVMBUHCZBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BC6FD0", Offset = "0x2BC5FD0", VA = "0x182BC6FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static QNRICJJABYK TEKGTOOLHHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9710", Offset = "0x2BC8710", VA = "0x182BC9710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static QNRICJJABYK VMGWELTVRCT
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BC9B40", Offset = "0x2BC8B40", VA = "0x182BC9B40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static QNRICJJABYK QOPCPMTVWGY
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8D20", Offset = "0x2BC7D20", VA = "0x182BC8D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static QNRICJJABYK NHAHWHCNOTA
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8D80", Offset = "0x2BC7D80", VA = "0x182BC8D80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static QNRICJJABYK LHSOWLNKRAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8610", Offset = "0x2BC7610", VA = "0x182BC8610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static QNRICJJABYK XWIIEDOPNFH
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8230", Offset = "0x2BC7230", VA = "0x182BC8230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static QNRICJJABYK NAORNPHZBQL
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC99B0", Offset = "0x2BC89B0", VA = "0x182BC99B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static QNRICJJABYK YVTSGXVBQLX
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2BC7F60", Offset = "0x2BC6F60", VA = "0x182BC7F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static QNRICJJABYK WCFKDCWFCRM
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2BC8870", Offset = "0x2BC7870", VA = "0x182BC8870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7FC0", Offset = "0x2BC6FC0", VA = "0x182BC7FC0")]
			public static JFOXBOFRTHW LHDSBGKCYYU([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BC83E0", Offset = "0x2BC73E0", VA = "0x182BC83E0")]
			public static ClassFactoryTypeParams NEUKRYPKNFD(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BC83B0", Offset = "0x2BC73B0", VA = "0x182BC83B0")]
			public static ClassFactoryTypeParams NEUKRYPKNFD([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7080", Offset = "0x2BC6080", VA = "0x182BC7080")]
			public static JFOXBOFRTHW HBFQNCUOJEC(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BC63C0", Offset = "0x2BC53C0", VA = "0x182BC63C0")]
			public static JFOXBOFRTHW AQSIODMDUGL(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BC6510", Offset = "0x2BC5510", VA = "0x182BC6510")]
			public static JFOXBOFRTHW BPTMWRLTCRV([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8930", Offset = "0x2BC7930", VA = "0x182BC8930")]
			public static EUKWVPLYZVT PFFGWXLWCAV(Id32<SNPPUNKBJMN> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9A10", Offset = "0x2BC8A10", VA = "0x182BC9A10")]
			public static string WWLYIUENCVM(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC89E0", Offset = "0x2BC79E0", VA = "0x182BC89E0")]
			private static EUKWVPLYZVT PFFGWXLWCAV(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9640", Offset = "0x2BC8640", VA = "0x182BC9640")]
			public static Id32<SNPPUNKBJMN>? UBJSXFCOZNO(EUKWVPLYZVT a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC6B70", Offset = "0x2BC5B70", VA = "0x182BC6B70")]
			public static CircuitTypeIdWrapper? FFLQLCTHPUH(EUKWVPLYZVT a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA4F0", Offset = "0x2BC94F0", VA = "0x182BCA4F0")]
			static YGHLTEEVSGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA3E0", Offset = "0x2BC93E0", VA = "0x182BCA3E0")]
			[IteratorStateMachine(typeof(GOYXUJDLEKY))]
			private static IEnumerable<EUKWVPLYZVT> ZOIKBEDGWDP(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BC70B0", Offset = "0x2BC60B0", VA = "0x182BC70B0")]
			[IteratorStateMachine(typeof(NLTFPHGHKQC))]
			public static IEnumerable<EUKWVPLYZVT> HDEWLMOZSTO(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BC73B0", Offset = "0x2BC63B0", VA = "0x182BC73B0")]
			public static Variant IKJUTSHLDYN(EUKWVPLYZVT a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BC7B00", Offset = "0x2BC6B00", VA = "0x182BC7B00")]
			public static Variant KFBVDEKECQQ(EUKWVPLYZVT a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA0A0", Offset = "0x2BC90A0", VA = "0x182BCA0A0")]
			public static bool YNEGHDVIYKY(EUKWVPLYZVT a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8760", Offset = "0x2BC7760", VA = "0x182BC8760")]
			[IteratorStateMachine(typeof(GYKZDTEDMUL))]
			public static IEnumerable<Id32<SNPPUNKBJMN>> OKVCXEIGQFQ(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class GLASRGYZNBQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2850", Offset = "0x2BB1850", VA = "0x182BB2850")]
		public static PKCAITKYOTT BIDIANLANQI(this EUKWVPLYZVT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3930", Offset = "0x2BB2930", VA = "0x182BB3930")]
		public static EUKWVPLYZVT MQCSYLKHLDL(this PKCAITKYOTT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class YBRPGEEBSVZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4116A20", Offset = "0x4115A20", VA = "0x184116A20")]
		public static Dictionary<b, c> BLSKFTZPJJH<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class MWTGUQNCMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB520", Offset = "0x2BBA520", VA = "0x182BBB520")]
		public static APYKUDCGKST BIDIANLANQI([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB620", Offset = "0x2BBA620", VA = "0x182BBB620")]
		public static Guid MQCSYLKHLDL(APYKUDCGKST a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DSCEZAPZGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BB24B0", Offset = "0x2BB14B0", VA = "0x182BB24B0")]
		public static ZNTAUDTQVYH BIDIANLANQI([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2540", Offset = "0x2BB1540", VA = "0x182BB2540")]
		public static NamedType MQCSYLKHLDL(this ZNTAUDTQVYH a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class QNNCMFECOHT
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E17150", Offset = "0x3E16150", VA = "0x183E17150")]
		public static void DPEADTBFSRD<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E173B0", Offset = "0x3E163B0", VA = "0x183E173B0")]
		public static void DPEADTBFSRD<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class JANRKHHLDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA730", Offset = "0x2BB9730", VA = "0x182BBA730")]
		public static RAIQVFTYDPV BIDIANLANQI([In] this Variant self, EUKWVPLYZVT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA930", Offset = "0x2BB9930", VA = "0x182BBA930")]
		public static Variant MQCSYLKHLDL(this RAIQVFTYDPV a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class VLKXBXBDJCW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<WXKZIVPIDWK> WIPSWNPXPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool JRRDVXXCKIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool WNYVLJTHJQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool WPPMZAMXMZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool LYFAUFBULGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool LYUVLZJMNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool XRJQJJBQZHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool ZGBNONZQGRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool MQFEHMQKYER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, EUKWVPLYZVT Type)> DSLRMTCKLWA;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid OSRJHZIEHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B76A80", Offset = "0x2B75A80", VA = "0x182B76A80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<WXKZIVPIDWK> QVJUSSCXMGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B76A80", Offset = "0x2B75A80", VA = "0x182B76A80")]
			get
			{
				return default(Id128<WXKZIVPIDWK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, EUKWVPLYZVT Type)> JBPXHAAMHSX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action VLUCTODGPJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5920", Offset = "0x2BC4920", VA = "0x182BC5920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5C80", Offset = "0x2BC4C80", VA = "0x182BC5C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, EUKWVPLYZVT> GDZWDMYRSNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5BD0", Offset = "0x2BC4BD0", VA = "0x182BC5BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5B20", Offset = "0x2BC4B20", VA = "0x182BC5B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> DSTDUBBCQCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5E40", Offset = "0x2BC4E40", VA = "0x182BC5E40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5870", Offset = "0x2BC4870", VA = "0x182BC5870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> EGAJRAHVNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5A70", Offset = "0x2BC4A70", VA = "0x182BC5A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4D80", Offset = "0x2BC3D80", VA = "0x182BC4D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, EUKWVPLYZVT> WXDICQPSASL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BC59C0", Offset = "0x2BC49C0", VA = "0x182BC59C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5210", Offset = "0x2BC4210", VA = "0x182BC5210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action FPFJYFXHSID
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BC56E0", Offset = "0x2BC46E0", VA = "0x182BC56E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4F30", Offset = "0x2BC3F30", VA = "0x182BC4F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B2F660", Offset = "0x1B2E660", VA = "0x181B2F660")]
		public void HOJGJXTWRAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5EF0", Offset = "0x2BC4EF0", VA = "0x182BC5EF0")]
		internal VLKXBXBDJCW([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, EUKWVPLYZVT Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5140", Offset = "0x2BC4140", VA = "0x182BC5140")]
		public static CircuitEventDefinitionFactoryStart FACRFPUWRCL(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BC50C0", Offset = "0x2BC40C0", VA = "0x182BC50C0")]
		public static CircuitEventDefinitionFactoryStart FACRFPUWRCL(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BC52C0", Offset = "0x2BC42C0", VA = "0x182BC52C0")]
		public static VLKXBXBDJCW FWBSYIZYORH([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5430", Offset = "0x2BC4430", VA = "0x182BC5430")]
		public static VLKXBXBDJCW JNOHXCGZQVF([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF07D20", Offset = "0xF06D20", VA = "0x180F07D20")]
		public void KFCLRVKHULX(Id128<WXKZIVPIDWK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BC53D0", Offset = "0x2BC43D0", VA = "0x182BC53D0")]
		public void HWWYRBHGYNG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4FD0", Offset = "0x2BC3FD0", VA = "0x182BC4FD0")]
		public void EEHCEOUNACY(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5780", Offset = "0x2BC4780", VA = "0x182BC5780")]
		public void MAIVHREIIUH(int a, EUKWVPLYZVT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5D20", Offset = "0x2BC4D20", VA = "0x182BC5D20")]
		public void VEBNDJDEQXX(string a, EUKWVPLYZVT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5670", Offset = "0x2BC4670", VA = "0x182BC5670")]
		public void JXNZKZFSLXA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4E30", Offset = "0x2BC3E30", VA = "0x182BC4E30")]
		public VLKXBXBDJCW Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2BB0F80", Offset = "0x2BAFF80", VA = "0x182BB0F80")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0CE0", Offset = "0x2BAFCE0", VA = "0x182BB0CE0")]
		public CircuitEventDefinitionFactoryParams YRXRXWCHYXB(string a, EUKWVPLYZVT b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0E50", Offset = "0x2BAFE50", VA = "0x182BB0E50")]
		public VLKXBXBDJCW ZQHOKUWTOCH()
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
		private readonly List<(string Name, EUKWVPLYZVT Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0C50", Offset = "0x2BAFC50", VA = "0x182BB0C50")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, EUKWVPLYZVT Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0A20", Offset = "0x2BAFA20", VA = "0x182BB0A20")]
		public CircuitEventDefinitionFactoryParams YRXRXWCHYXB(string a, EUKWVPLYZVT b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0B50", Offset = "0x2BAFB50", VA = "0x182BB0B50")]
		public VLKXBXBDJCW ZQHOKUWTOCH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HXGXGXABACD
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly VLKXBXBDJCW FQGVXHWTFDU;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly VLKXBXBDJCW GWQTSSZBCUJ;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly VLKXBXBDJCW TARYTEMMFBW;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly VLKXBXBDJCW QNIXUSXEJKV;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly VLKXBXBDJCW SLBNIXRJTXU;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly VLKXBXBDJCW LBUAYTWHCOM;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly VLKXBXBDJCW RGGFWMTAELR;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly VLKXBXBDJCW[] ENYXVFTMJHW;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class ZBURRICJKVQ
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly VLKXBXBDJCW AWIPRAYLTAG;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class TMUHBRYEXAR
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly VLKXBXBDJCW ANOEZYCAKVI;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly VLKXBXBDJCW BKPGTVWWRLB;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class RVSCHPMTGBS
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly VLKXBXBDJCW QTGDEDHMHDV;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly VLKXBXBDJCW QNZBQYQUFCG;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly VLKXBXBDJCW[] PIDGYEIKLWO;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly VLKXBXBDJCW ZAAEZOPPPFY;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly VLKXBXBDJCW NXGDBTBOBOD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class TYJVKCNYYKU
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly VLKXBXBDJCW ZPKWIFUEBJF;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly VLKXBXBDJCW ESGNUVZTDJI;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class JJZJGHNPOER
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly VLKXBXBDJCW JIGWARTFXTQ;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly VLKXBXBDJCW OPUBWTYABXH;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class GGCJYCGLZZI
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly VLKXBXBDJCW ANOEZYCAKVI;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly VLKXBXBDJCW BKPGTVWWRLB;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class UFQYYSDWOJG
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly VLKXBXBDJCW YKIWMYCEBLH;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly VLKXBXBDJCW OHGSLORNFVM;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly VLKXBXBDJCW FLWCDJNPMBO;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly VLKXBXBDJCW TPDBGEVSULM;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly VLKXBXBDJCW TOZVQTCKSJH;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly VLKXBXBDJCW HDMEQKISUTQ;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly VLKXBXBDJCW GOCBFCLQHPR;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class RDCJGBYPJQY
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class XWXCOISNZXO
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class CYILUOBOULS
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class IFQVRNFPLKU
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly VLKXBXBDJCW XBMYKRTSXMN;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly VLKXBXBDJCW UMCTINJRTSG;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class XCQQZPXTYOG
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class XNXYITZGLCC
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class KNVFKNIVECC
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class UTWRFGSILKJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly VLKXBXBDJCW WBXCKPPLFGF;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly VLKXBXBDJCW PTSGKMBZTST;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly VLKXBXBDJCW GZWWJWKJZBS;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly VLKXBXBDJCW QYSBTQSGOOR;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly VLKXBXBDJCW WCRQRRVVEEX;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly VLKXBXBDJCW JIGWARTFXTQ;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly VLKXBXBDJCW OLUUTRVZBTV;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly VLKXBXBDJCW NRLQXSFPHAI;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly VLKXBXBDJCW WMZTSYQRWCC;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly VLKXBXBDJCW EGJZGWNISXU;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly VLKXBXBDJCW MDCJYNDQOTO;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly VLKXBXBDJCW CBWSYOMPFYC;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly VLKXBXBDJCW TVKTRPNXVYF;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly VLKXBXBDJCW RTBKFCYOJMM;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly VLKXBXBDJCW KPCEKRQKCFJ;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly VLKXBXBDJCW KTCOFDOTLHN;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly VLKXBXBDJCW DSKKNFGCTSJ;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly VLKXBXBDJCW IQJPTEMBCIS;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly VLKXBXBDJCW JWATBWOLKAL;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly VLKXBXBDJCW QVQIWBKUQER;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly VLKXBXBDJCW ZDIEYHINLKY;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly VLKXBXBDJCW UADUMPWYGZO;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly VLKXBXBDJCW OZZUDHUKCXU;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly VLKXBXBDJCW FVKBNHFUJCK;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly VLKXBXBDJCW YCDMSEIBVPU;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly VLKXBXBDJCW LCOPMCXSNYS;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly VLKXBXBDJCW JAMYKVYYZFG;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly VLKXBXBDJCW SBEHCGFGDLC;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly VLKXBXBDJCW GXYFJDHZBSF;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly VLKXBXBDJCW TATGTAKKGMR;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly VLKXBXBDJCW PZWHHLRBHNW;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly VLKXBXBDJCW YOZYYERFBSM;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly VLKXBXBDJCW FHOICDFCCLD;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly VLKXBXBDJCW GYMBJMMYMYJ;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly VLKXBXBDJCW NOFOIFYANGV;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly VLKXBXBDJCW VGIGIHBFWZX;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly VLKXBXBDJCW MIUFOMGPSCJ;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly VLKXBXBDJCW RLRTXXQLDDN;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly VLKXBXBDJCW VPBPPSYCMGT;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly VLKXBXBDJCW TFALNUTSNGT;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly VLKXBXBDJCW JKXVMSAZOKK;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly VLKXBXBDJCW SRGLQLIAMPK;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly VLKXBXBDJCW KEYBETVNALI;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly VLKXBXBDJCW PMDHHRXBBNI;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly VLKXBXBDJCW NSTRYLDEDAS;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly VLKXBXBDJCW MWGCNJUNDTU;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly VLKXBXBDJCW UWZHPSIEHNW;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly VLKXBXBDJCW SFMSJAJPEEM;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly VLKXBXBDJCW PNYXYRAKOHW;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly VLKXBXBDJCW GRAGWMPHHQO;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly VLKXBXBDJCW ROQEPSEPPCR;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly VLKXBXBDJCW XZYXHNOBGIS;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly VLKXBXBDJCW STKFHGPJQCQ;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly VLKXBXBDJCW TCUMRVTOPES;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly VLKXBXBDJCW MPWUKFQZFUO;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly VLKXBXBDJCW BFJCJLWBORQ;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly VLKXBXBDJCW UGUTBRGVZAW;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly VLKXBXBDJCW ZQBKOVUVRRE;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly VLKXBXBDJCW HXRHGQZTIII;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly VLKXBXBDJCW GRHQFUQNXRK;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly VLKXBXBDJCW UTJBAYQEFDO;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly VLKXBXBDJCW HXYYSDPWKZU;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly VLKXBXBDJCW ZSXOIREUUNX;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly VLKXBXBDJCW WPWJZNWJGMW;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly VLKXBXBDJCW LYGIVJMYLDE;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly VLKXBXBDJCW NCLZLFUZNKR;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly VLKXBXBDJCW REZAMHHTFUT;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly VLKXBXBDJCW CFGLQARCRXK;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly VLKXBXBDJCW XEEDYDMVCWC;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class VPRNMCQOWQB
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class ZZDMWQAENIA
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly VLKXBXBDJCW LCBOOEWOLEW;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly VLKXBXBDJCW GOLGEEDDVOP;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly VLKXBXBDJCW BTJOVLQIGVN;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly VLKXBXBDJCW ZAFLZTCUDCI;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly VLKXBXBDJCW XASNDVERCXG;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly VLKXBXBDJCW BIMXXPSNSTM;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly VLKXBXBDJCW BKPZLRFSZDK;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LLIYVLQGJUN
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly VLKXBXBDJCW PTSGKMBZTST;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly VLKXBXBDJCW GZWWJWKJZBS;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly VLKXBXBDJCW QYSBTQSGOOR;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly VLKXBXBDJCW WOECPPSJQWB;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly VLKXBXBDJCW JYMEUKHLPXH;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly VLKXBXBDJCW HFOVCLVGPZH;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly VLKXBXBDJCW JELXQPEZGPB;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class VKJKZSISBAV
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly VLKXBXBDJCW FSHPVOTOKUX;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly VLKXBXBDJCW UZTRKIGHCGL;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly VLKXBXBDJCW XYWAGEKSMYI;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly VLKXBXBDJCW UAYIJOFOHDS;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly VLKXBXBDJCW RFHEDCNVMUM;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly VLKXBXBDJCW ZOCMXIFMKVU;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class AGOZUXMOGMG
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class RZIESTSNHLL
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly VLKXBXBDJCW EFAAXZSRINV;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class RKAFEOTONQL
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly VLKXBXBDJCW WBXCKPPLFGF;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class LBOFSARIBKM
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class TUKHCTRIQDF
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class RHXMGDCALNG
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly VLKXBXBDJCW FUWUTVYVKSA;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly VLKXBXBDJCW BJAURKOEYFM;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly VLKXBXBDJCW KEHOGHAJEAJ;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly VLKXBXBDJCW SAXLBPKUOPX;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class HCKPHTRJPDQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly VLKXBXBDJCW LVKFJXJVNUT;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly VLKXBXBDJCW BYCNBWIYPWU;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class IUISKMXNPFQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class RYUZOUGOLHI
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly VLKXBXBDJCW LCBOOEWOLEW;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly VLKXBXBDJCW GOLGEEDDVOP;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class EFVRJPMMYLJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly VLKXBXBDJCW RJVMYYWUBHC;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly VLKXBXBDJCW ZAFLZTCUDCI;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly VLKXBXBDJCW XASNDVERCXG;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly VLKXBXBDJCW BIMXXPSNSTM;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly VLKXBXBDJCW ANQWGGAFSXL;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly VLKXBXBDJCW XETFBRLWCNI;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly VLKXBXBDJCW OOFSVYXBPOS;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly VLKXBXBDJCW YVOQAJNGCVW;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly VLKXBXBDJCW ZXPRMBVPJXL;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly VLKXBXBDJCW STXTJMVPXIN;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly VLKXBXBDJCW LCBOOEWOLEW;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly VLKXBXBDJCW GOLGEEDDVOP;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class XNGVKDDHMGF
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class MOKBMAMICYT
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly VLKXBXBDJCW LCBOOEWOLEW;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly VLKXBXBDJCW GOLGEEDDVOP;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly VLKXBXBDJCW HLDUIAWFUSJ;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly VLKXBXBDJCW CXZKCLXQAIZ;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly VLKXBXBDJCW AQMZLTQZWFC;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class DUOIJCBXQKW
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class TYRQRRDOULX
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly VLKXBXBDJCW HIQBUZKHGLQ;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class RTXMFLNSHYF
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly VLKXBXBDJCW BGWBBGOYTXV;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly VLKXBXBDJCW MQWHXBGHIYK;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly VLKXBXBDJCW LCBOOEWOLEW;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly VLKXBXBDJCW GOLGEEDDVOP;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class WJHZVZALXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class AICPKHNJBOA
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class KCKJZJCHVEF
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class SPBDUGZUCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class IOLVUAAWPWA
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class CBQUICRXXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly VLKXBXBDJCW XBMYKRTSXMN;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly VLKXBXBDJCW UMCTINJRTSG;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class HNJXADENUJG
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly VLKXBXBDJCW VJCTAJBAYQH;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly VLKXBXBDJCW CUFZNWHJVYN;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly VLKXBXBDJCW JRDDKUOQPUH;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly VLKXBXBDJCW ORFKBQPWAEJ;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class KQQHRUVAYBL
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly VLKXBXBDJCW VJCTAJBAYQH;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly VLKXBXBDJCW CUFZNWHJVYN;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly VLKXBXBDJCW JRDDKUOQPUH;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly VLKXBXBDJCW ORFKBQPWAEJ;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class KASGGKCAOFW
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class CYCDOGWHYAB
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly VLKXBXBDJCW RSCLACSISOK;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly VLKXBXBDJCW FZEZSUAUUTI;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly VLKXBXBDJCW HYVGRMQYXAC;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class HXSDCBMTNUY
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly VLKXBXBDJCW ZEQNOSTNIEX;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly VLKXBXBDJCW EOWYZQQLXOJ;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly VLKXBXBDJCW NJFMEOGNESW;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class ZLTYGZRKKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class OWMFKQNUSRE
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly VLKXBXBDJCW MKOBHBVHFFE;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly VLKXBXBDJCW RKDTJVAAEMU;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly VLKXBXBDJCW COMGDCTEDUT;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly VLKXBXBDJCW MVWPCJNYRXN;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly VLKXBXBDJCW IEPSBQWPHRE;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class GQWEUFXOSBP
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly VLKXBXBDJCW MJCMWRAYIIW;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class QJSNGYVQGCZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly VLKXBXBDJCW NHNITRKEFAT;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly VLKXBXBDJCW HHNYVEZIELO;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly VLKXBXBDJCW ULWKPMYTIZJ;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class WMNIFMUVDZE
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class OZTTBXRNBUA
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class AMQVFMEIPNF
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class KAFSYKXXSIU
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly VLKXBXBDJCW GWQJTQHVRXP;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly VLKXBXBDJCW MOPYKETNFBY;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly VLKXBXBDJCW RDDJVONRMYI;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly VLKXBXBDJCW UUFCHBIWLRW;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly VLKXBXBDJCW KHVAOKHLCRZ;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly VLKXBXBDJCW KTUWKQOJAEB;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly VLKXBXBDJCW HHVARNDJHYW;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class KKSXIBNCFAM
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly VLKXBXBDJCW SHJJMQONSED;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly VLKXBXBDJCW[] SNFDUGULNWD;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class FYNEQQIQDOQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly EUKWVPLYZVT GQECQKSHXOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<VLKXBXBDJCW> DIPSEVFBTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<VLKXBXBDJCW> AQKRRUYCQIA;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<VLKXBXBDJCW> GPXDIRCYHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<VLKXBXBDJCW> RXDUFPZCKYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BD54E0", Offset = "0x2BD44E0", VA = "0x182BD54E0")]
		protected FYNEQQIQDOQ(EUKWVPLYZVT a, params VLKXBXBDJCW[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class QMAHACVTING : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD6E0", Offset = "0x2BDC6E0", VA = "0x182BDD6E0")]
		internal QMAHACVTING()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class NRELOEWZPZP : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBAA0", Offset = "0x2BDAAA0", VA = "0x182BDBAA0")]
		internal NRELOEWZPZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PAEPHCDPLOA : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCF30", Offset = "0x2BDBF30", VA = "0x182BDCF30")]
		internal PAEPHCDPLOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class QXIAUYKRFWR : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD8C0", Offset = "0x2BDC8C0", VA = "0x182BDD8C0")]
		internal QXIAUYKRFWR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class MTPNZJNIKCS : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB6E0", Offset = "0x2BDA6E0", VA = "0x182BDB6E0")]
		internal MTPNZJNIKCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ICHUBWVLVIG : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BD77C0", Offset = "0x2BD67C0", VA = "0x182BD77C0")]
		internal ICHUBWVLVIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class CHDIFQRCITP : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2CB0", Offset = "0x2BD1CB0", VA = "0x182BD2CB0")]
		internal CHDIFQRCITP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class MPMPKJRQECQ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB320", Offset = "0x2BDA320", VA = "0x182BDB320")]
		internal MPMPKJRQECQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class UFXMBXTYMXI : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0650", Offset = "0x2BDF650", VA = "0x182BE0650")]
		internal UFXMBXTYMXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class CBSLNJWHXWC : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2AD0", Offset = "0x2BD1AD0", VA = "0x182BD2AD0")]
		internal CBSLNJWHXWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class CMECIUQCVWW : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2E90", Offset = "0x2BD1E90", VA = "0x182BD2E90")]
		internal CMECIUQCVWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class HZPDMMCFEHY : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD75E0", Offset = "0x2BD65E0", VA = "0x182BD75E0")]
		internal HZPDMMCFEHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class FBZLOEJNXLI : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4B80", Offset = "0x2BD3B80", VA = "0x182BD4B80")]
		internal FBZLOEJNXLI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TKUVNVRFHFM : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF960", Offset = "0x2BDE960", VA = "0x182BDF960")]
		internal TKUVNVRFHFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class BPLNZZGUHAM : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2130", Offset = "0x2BD1130", VA = "0x182BD2130")]
		internal BPLNZZGUHAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class RBKQMBIYWWM : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDAA0", Offset = "0x2BDCAA0", VA = "0x182BDDAA0")]
		internal RBKQMBIYWWM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class RJZKOYOEUEM : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE510", Offset = "0x2BDD510", VA = "0x182BDE510")]
		internal RJZKOYOEUEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class NZOLVIXFCOR : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBE60", Offset = "0x2BDAE60", VA = "0x182BDBE60")]
		internal NZOLVIXFCOR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class DONUKLUDBAH : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3630", Offset = "0x2BD2630", VA = "0x182BD3630")]
		internal DONUKLUDBAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class VJLOUOYRHGL : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1180", Offset = "0x2BE0180", VA = "0x182BE1180")]
		internal VJLOUOYRHGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class UPUHXTURKEV : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0B60", Offset = "0x2BDFB60", VA = "0x182BE0B60")]
		internal UPUHXTURKEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class YHUBXXPBKUF : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2300", Offset = "0x2BE1300", VA = "0x182BE2300")]
		internal YHUBXXPBKUF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class DOURMHSQDKS : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3810", Offset = "0x2BD2810", VA = "0x182BD3810")]
		internal DOURMHSQDKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class JNBGQWCCLZJ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD80A0", Offset = "0x2BD70A0", VA = "0x182BD80A0")]
		internal JNBGQWCCLZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class HAXNFQJWCRK : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD64B0", Offset = "0x2BD54B0", VA = "0x182BD64B0")]
		internal HAXNFQJWCRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class GZSBODCZBET : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C90", Offset = "0x2BD4C90", VA = "0x182BD5C90")]
		internal GZSBODCZBET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MHYNPZIYNGZ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAA90", Offset = "0x2BD9A90", VA = "0x182BDAA90")]
		internal MHYNPZIYNGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class KBOJXDWTIWP : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8900", Offset = "0x2BD7900", VA = "0x182BD8900")]
		internal KBOJXDWTIWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TMAEUGFSXTY : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFC20", Offset = "0x2BDEC20", VA = "0x182BDFC20")]
		internal TMAEUGFSXTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class BZGAJEXSZFZ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BD24F0", Offset = "0x2BD14F0", VA = "0x182BD24F0")]
		internal BZGAJEXSZFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class ABVROIQRIRA : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BD17E0", Offset = "0x2BD07E0", VA = "0x182BD17E0")]
		internal ABVROIQRIRA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class MTMGWQONOIA : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB500", Offset = "0x2BDA500", VA = "0x182BDB500")]
		internal MTMGWQONOIA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class RXPGIDVKBQI : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF030", Offset = "0x2BDE030", VA = "0x182BDF030")]
		internal RXPGIDVKBQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class OHBQNOUCOGX : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC2C0", Offset = "0x2BDB2C0", VA = "0x182BDC2C0")]
		internal OHBQNOUCOGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class VDPCALYQVIZ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0FA0", Offset = "0x2BDFFA0", VA = "0x182BE0FA0")]
		internal VDPCALYQVIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class JBCQHPHFBKX : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7E40", Offset = "0x2BD6E40", VA = "0x182BD7E40")]
		internal JBCQHPHFBKX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class DZUSPGEGJLO : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3C40", Offset = "0x2BD2C40", VA = "0x182BD3C40")]
		internal DZUSPGEGJLO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class YCOKRJJPFAV : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BE20A0", Offset = "0x2BE10A0", VA = "0x182BE20A0")]
		internal YCOKRJJPFAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class BBEEPGZQKLP : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1CF0", Offset = "0x2BD0CF0", VA = "0x182BD1CF0")]
		internal BBEEPGZQKLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class BXBFAYZBIFQ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2310", Offset = "0x2BD1310", VA = "0x182BD2310")]
		internal BXBFAYZBIFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class AOUXXTQCHCK : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1B10", Offset = "0x2BD0B10", VA = "0x182BD1B10")]
		internal AOUXXTQCHCK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class WBUAPIVNHSW : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1D00", Offset = "0x2BE0D00", VA = "0x182BE1D00")]
		internal WBUAPIVNHSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class IXOTEGQKKAF : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7C60", Offset = "0x2BD6C60", VA = "0x182BD7C60")]
		internal IXOTEGQKKAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class BCDQONTTYQF : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1F50", Offset = "0x2BD0F50", VA = "0x182BD1F50")]
		internal BCDQONTTYQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class FFSALZFCHVA : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4D60", Offset = "0x2BD3D60", VA = "0x182BD4D60")]
		internal FFSALZFCHVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class TRCCXWVJIAT : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFF60", Offset = "0x2BDEF60", VA = "0x182BDFF60")]
		internal TRCCXWVJIAT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class KOPDZBGCNDM : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8DC0", Offset = "0x2BD7DC0", VA = "0x182BD8DC0")]
		internal KOPDZBGCNDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class FGGNHISPOQR : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4F40", Offset = "0x2BD3F40", VA = "0x182BD4F40")]
		internal FGGNHISPOQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class DTFHGDPLYIV : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BD39F0", Offset = "0x2BD29F0", VA = "0x182BD39F0")]
		internal DTFHGDPLYIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class IFEHTYXEIKC : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BD79A0", Offset = "0x2BD69A0", VA = "0x182BD79A0")]
		internal IFEHTYXEIKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class RWEXZIIBEBO : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEE50", Offset = "0x2BDDE50", VA = "0x182BDEE50")]
		internal RWEXZIIBEBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class FNXOGTXGQWH : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5300", Offset = "0x2BD4300", VA = "0x182BD5300")]
		internal FNXOGTXGQWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class JXPAVVEZIXS : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD7280", VA = "0x182BD8280")]
		internal JXPAVVEZIXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class GYFPUYHBVIJ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5AB0", Offset = "0x2BD4AB0", VA = "0x182BD5AB0")]
		internal GYFPUYHBVIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class MVCGHYHTJIF : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB8C0", Offset = "0x2BDA8C0", VA = "0x182BDB8C0")]
		internal MVCGHYHTJIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class FKWYRKQHQEX : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5120", Offset = "0x2BD4120", VA = "0x182BD5120")]
		internal FKWYRKQHQEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class TKYTZRHJVTD : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFA40", Offset = "0x2BDEA40", VA = "0x182BDFA40")]
		internal TKYTZRHJVTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class UXPULODKQNO : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0DC0", Offset = "0x2BDFDC0", VA = "0x182BE0DC0")]
		internal UXPULODKQNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class GIUMKAVTLTR : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5660", Offset = "0x2BD4660", VA = "0x182BD5660")]
		internal GIUMKAVTLTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class UDMXDGHSLUX : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0470", Offset = "0x2BDF470", VA = "0x182BE0470")]
		internal UDMXDGHSLUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class UJLGPSPZVXU : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BE08A0", Offset = "0x2BDF8A0", VA = "0x182BE08A0")]
		internal UJLGPSPZVXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class PGZSIJCWVTJ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD110", Offset = "0x2BDC110", VA = "0x182BDD110")]
		internal PGZSIJCWVTJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class TQIRAWDXOVQ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE00", Offset = "0x2BDEE00", VA = "0x182BDFE00")]
		internal TQIRAWDXOVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class UNONSTOWORL : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0A00", Offset = "0x2BDFA00", VA = "0x182BE0A00")]
		internal UNONSTOWORL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class NWLDDLVXUHJ : FYNEQQIQDOQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBC00", Offset = "0x2BDAC00", VA = "0x182BDBC00")]
		internal NWLDDLVXUHJ()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, VZURHGBSTCB<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly EUKWVPLYZVT Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
		private NamedType(string name, EUKWVPLYZVT type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E450", Offset = "0x2B0D450", VA = "0x182B0E450")]
		public static NamedType New(string name, EUKWVPLYZVT type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC100", Offset = "0x2BDB100", VA = "0x182BDC100")]
		public static bool HCRCQFCURBY([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC100", Offset = "0x2BDB100", VA = "0x182BDC100", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC100", Offset = "0x2BDB100", VA = "0x182BDC100")]
		public bool FNYFOTOAQQI([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC040", Offset = "0x2BDB040", VA = "0x182BDC040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC150", Offset = "0x2BDB150", VA = "0x182BDC150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC200", Offset = "0x2BDB200", VA = "0x182BDC200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC1C0", Offset = "0x2BDB1C0", VA = "0x182BDC1C0")]
		public string NGBHUJPLIHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC240", Offset = "0x2BDB240", VA = "0x182BDC240")]
		public string VRMTPBPLBWS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC100", Offset = "0x2BDB100", VA = "0x182BDC100", Slot = "5")]
		private bool HYEJELLYGAF([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface SWFQECRPDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(PYPEGOPZPPS a, bool b);
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
