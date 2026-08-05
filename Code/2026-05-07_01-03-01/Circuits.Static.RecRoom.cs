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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC3560", Offset = "0x2BC1F60", VA = "0x182BC3560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC3170", Offset = "0x2BC1B70", VA = "0x182BC3170", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KOZLCKPLUXM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2F30", Offset = "0x2BC1930", VA = "0x182BC2F30")]
		public static bool VZEJRWAIGLL(this CXXOCPTCXZR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3040", Offset = "0x2BC1A40", VA = "0x182BC3040")]
		public static bool VZEJRWAIGLL(this ILXFIROPVHU a)
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
			private readonly ISJHRHKEWBX _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
			public EVRequest(ISJHRHKEWBX staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class CMMNBUDTMCI
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<MRHQTUUWLDN>, GCPXVZKOYEW> IZLMVNFNBEN;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<MRHQTUUWLDN>>? ZAQEVNQQGNX;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<MRHQTUUWLDN> DCXUSUJVDOX;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<MRHQTUUWLDN> ZOPTTLELONO;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<MRHQTUUWLDN> KLFFUGVZWKT;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<MRHQTUUWLDN> WBLWWXOUSMK;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<MRHQTUUWLDN> GJHRNINMMKX;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<MRHQTUUWLDN> OCXLBHLNFVW;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<MRHQTUUWLDN> UKCVVPOYIKS;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<MRHQTUUWLDN> WDHSZDCISFM;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<MRHQTUUWLDN> RZDNGGURNTQ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<MRHQTUUWLDN> CLPSJDTXXZA;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<MRHQTUUWLDN> ZLUZNATYAJC;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<MRHQTUUWLDN> VEFPTGIEUBS;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<MRHQTUUWLDN> UIBMFTPYNOZ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<MRHQTUUWLDN> PJAQMHUYBKD;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<MRHQTUUWLDN> NTPKJKRDYVR;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<MRHQTUUWLDN> XPFIZNJKWCI;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<MRHQTUUWLDN> QBDACFEVLRF;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<MRHQTUUWLDN> BLJKBKMPKXT;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<MRHQTUUWLDN> YKQDCZBOUTQ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<MRHQTUUWLDN> NNPMITPBZTP;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<MRHQTUUWLDN> WVTPXYUBIKE;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<MRHQTUUWLDN> NVPGBZFVVGZ;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<MRHQTUUWLDN> CQQSGFEQGMP;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<MRHQTUUWLDN> QLHUSKDFYHO;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<MRHQTUUWLDN> OILZVKDXWRS;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<MRHQTUUWLDN> BYFFBQKASNR;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<MRHQTUUWLDN> YZNCRWHVFHQ;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<MRHQTUUWLDN> LGHHZFXXUKT;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<MRHQTUUWLDN> WCDBJVQGBJR;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<MRHQTUUWLDN> DPTKERUZHXT;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<MRHQTUUWLDN> DWWBXBMMXWX;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<MRHQTUUWLDN> TWWKXAPJOHA;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<MRHQTUUWLDN> HJRCDGGWQNP;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<MRHQTUUWLDN> PCQYCJNLYFR;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<MRHQTUUWLDN> EAAVXDHSZZV;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<MRHQTUUWLDN> QRVBOMKNRYM;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<MRHQTUUWLDN> GTYGNLKWWOZ;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<MRHQTUUWLDN> UKNDCLUAKTU;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<MRHQTUUWLDN> TBRPSAYVNBE;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<MRHQTUUWLDN> VIRZTYZYBWG;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<MRHQTUUWLDN> DLCLDTZXVDP;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<MRHQTUUWLDN> HWYGGTDKGHD;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<MRHQTUUWLDN> PTJVYFWXBYC;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<MRHQTUUWLDN> ZJKIJVNPTON;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<MRHQTUUWLDN> YPRUDNQRJFT;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<MRHQTUUWLDN> KXMPDLSKGWP;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<MRHQTUUWLDN> NNLWWZUVYLQ;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<MRHQTUUWLDN> DALPULEWLFC;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<MRHQTUUWLDN> OYMHQUWOYIK;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<MRHQTUUWLDN> HVUDZBIYVGT;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<MRHQTUUWLDN> ANVQJIGGHPR;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<MRHQTUUWLDN> DENQXDBPAQY;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<MRHQTUUWLDN> XEIRVSQLPGT;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<MRHQTUUWLDN> LGRZSLXQKEZ;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<MRHQTUUWLDN> SXUEDCCRJSA;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<MRHQTUUWLDN> ZJIQVAGZACO;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<MRHQTUUWLDN> VGMPZZMPYNQ;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<MRHQTUUWLDN> ELOKJMBKHWO;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<MRHQTUUWLDN> IRLUXDKJWRH;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<MRHQTUUWLDN> IQFGLEAVGGA;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<MRHQTUUWLDN> RVZPJYIOZQG;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<MRHQTUUWLDN> ZXKTMHTICBU;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<MRHQTUUWLDN> COHDWKTOVHL;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<MRHQTUUWLDN> OSLCUQYOWQH;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<MRHQTUUWLDN> IMQUBHGYNSG;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<MRHQTUUWLDN> MJNVOAUSTTL;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<MRHQTUUWLDN> QRPUTFQAFAS;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<MRHQTUUWLDN> UXOFEQJNISQ;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<MRHQTUUWLDN> HNNRFONSXXQ;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<MRHQTUUWLDN>, GCPXVZKOYEW> ICMNOAOOQCW
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB0420", Offset = "0x2BAEE20", VA = "0x182BB0420")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0640", Offset = "0x2BAF040", VA = "0x182BB0640")]
			public static GCPXVZKOYEW FPZCNZYHWLY(Id32<MRHQTUUWLDN> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0770", Offset = "0x2BAF170", VA = "0x182BB0770")]
			public static bool NQNYRMXHJKD(Id32<MRHQTUUWLDN> id, [Out] GCPXVZKOYEW a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB06C0", Offset = "0x2BAF0C0", VA = "0x182BB06C0")]
			public static CXXOCPTCXZR LHEFRIFLVTB(Id32<MRHQTUUWLDN> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0800", Offset = "0x2BAF200", VA = "0x182BB0800")]
			private static Id32<MRHQTUUWLDN> QCIVJGOFOSZ(GCPXVZKOYEW a, Id32<MRHQTUUWLDN> id)
			{
				return default(Id32<MRHQTUUWLDN>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0470", Offset = "0x2BAEE70", VA = "0x182BB0470")]
			private static void EMEZXJCDUQB(Id32<MRHQTUUWLDN> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class EPVLMKETIYT
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<ZJMYIFJCKHV, CXXOCPTCXZR?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x12B03C0", Offset = "0x12AEDC0", VA = "0x1812B03C0")]
				private TypeRegistryFactory([In] IdUnsafeList<ZJMYIFJCKHV, CXXOCPTCXZR?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCACC0", Offset = "0x2BC96C0", VA = "0x182BCACC0")]
				public static TypeRegistryFactory ONZPJVMVHLX()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BCAEA0", Offset = "0x2BC98A0", VA = "0x182BCAEA0")]
				public (ReadOnlyIdArray<ZJMYIFJCKHV, CXXOCPTCXZR>, IReadOnlyDictionary<CXXOCPTCXZR, Id32<ZJMYIFJCKHV>>) QUSLSCNGWNP()
				{
					return default((ReadOnlyIdArray<ZJMYIFJCKHV, CXXOCPTCXZR>, IReadOnlyDictionary<CXXOCPTCXZR, Id32<ZJMYIFJCKHV>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BCAD20", Offset = "0x2BC9720", VA = "0x182BCAD20")]
				public Id32<ZJMYIFJCKHV> QSZHNEJAYLZ(int a, CXXOCPTCXZR b)
				{
					return default(Id32<ZJMYIFJCKHV>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BCAC70", Offset = "0x2BC9670", VA = "0x182BCAC70")]
				public Id32<ZJMYIFJCKHV> Initialize(int id, LHUDJTUIYXO type, LHUDJTUIYXO factoryType)
				{
					return default(Id32<ZJMYIFJCKHV>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class MSVNWKLUGKC
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<ZJMYIFJCKHV> FRBGQEMMISJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2BC33B0", Offset = "0x2BC1DB0", VA = "0x182BC33B0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BC3270", Offset = "0x2BC1C70", VA = "0x182BC3270")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<ZJMYIFJCKHV> NBIKSSDNWGZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BC3370", Offset = "0x2BC1D70", VA = "0x182BC3370")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BC3230", Offset = "0x2BC1C30", VA = "0x182BC3230")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<ZJMYIFJCKHV> CSJNINTFVPM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BC3330", Offset = "0x2BC1D30", VA = "0x182BC3330")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BC33F0", Offset = "0x2BC1DF0", VA = "0x182BC33F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<ZJMYIFJCKHV> WPSRBSYFOTK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BC3470", Offset = "0x2BC1E70", VA = "0x182BC3470")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BC34B0", Offset = "0x2BC1EB0", VA = "0x182BC34B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<ZJMYIFJCKHV> HHTJRKYZZIA
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BC3430", Offset = "0x2BC1E30", VA = "0x182BC3430")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BC32B0", Offset = "0x2BC1CB0", VA = "0x182BC32B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<ZJMYIFJCKHV> TBSEVKJGIEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BC31F0", Offset = "0x2BC1BF0", VA = "0x182BC31F0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BC32F0", Offset = "0x2BC1CF0", VA = "0x182BC32F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class CAQDTUESIEM : IEnumerable<CXXOCPTCXZR>, IEnumerable, IEnumerator<CXXOCPTCXZR>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int KPYKIUTJAWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private CXXOCPTCXZR AGGTFEUSTML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int TCMGCAWGCHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool SQOICZSZEXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool HVMFHMLWGAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion PVQMOEHDCWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion EFXLRXBBEMS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool MFRPHRHOLTA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool STVWOLKWGGV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool PMPOZZOLDPU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool CZHTTBNSZOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool DQVQESKFSJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool ZPGHPUNWQZP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool HSSWJLCBWXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool YEJYSSDJQIX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<CXXOCPTCXZR> ONPYAFUWWYM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private CXXOCPTCXZR VKERHRBYUQN;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private CXXOCPTCXZR TGGODRQEOSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object KXFWSOWDLDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1007340", Offset = "0x1005D40", VA = "0x181007340")]
				[DebuggerHidden]
				public CAQDTUESIEM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BAFB40", Offset = "0x2BAE540", VA = "0x182BAFB40", Slot = "7")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BAFBD0", Offset = "0x2BAE5D0", VA = "0x182BAFBD0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BAFFC0", Offset = "0x2BAE9C0", VA = "0x182BAFFC0")]
				private void SMVYKFBVGYB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BB0010", Offset = "0x2BAEA10", VA = "0x182BB0010", Slot = "10")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BAFA80", Offset = "0x2BAE480", VA = "0x182BAFA80", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<CXXOCPTCXZR> HODOTXDYMHF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BAFA80", Offset = "0x2BAE480", VA = "0x182BAFA80", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator DKFMUHWUXGJ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class XLZOZXWEMPA : IEnumerable<CXXOCPTCXZR>, IEnumerable, IEnumerator<CXXOCPTCXZR>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int KPYKIUTJAWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private CXXOCPTCXZR AGGTFEUSTML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int TCMGCAWGCHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion PVQMOEHDCWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion EFXLRXBBEMS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool PMPOZZOLDPU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool CZHTTBNSZOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool MFRPHRHOLTA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool STVWOLKWGGV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool JBWCFQBBQQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool LINPYCRAVRL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool DQVQESKFSJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool ZPGHPUNWQZP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool IMJYAAWIZTW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool ZYHJXLEYCJC;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private CXXOCPTCXZR TGGODRQEOSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object KXFWSOWDLDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x1007340", Offset = "0x1005D40", VA = "0x181007340")]
				[DebuggerHidden]
				public XLZOZXWEMPA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC240", Offset = "0x2BCAC40", VA = "0x182BCC240", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BCE150", Offset = "0x2BCCB50", VA = "0x182BCE150", Slot = "10")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC190", Offset = "0x2BCAB90", VA = "0x182BCC190", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<CXXOCPTCXZR> HODOTXDYMHF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC190", Offset = "0x2BCAB90", VA = "0x182BCC190", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator DKFMUHWUXGJ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class EKYZUSWCJDD : IEnumerable<Id32<ZJMYIFJCKHV>>, IEnumerable, IEnumerator<Id32<ZJMYIFJCKHV>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int KPYKIUTJAWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<ZJMYIFJCKHV> AGGTFEUSTML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int TCMGCAWGCHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion PVQMOEHDCWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion EFXLRXBBEMS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool MFRPHRHOLTA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool STVWOLKWGGV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool PMPOZZOLDPU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool CZHTTBNSZOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool DQVQESKFSJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool ZPGHPUNWQZP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool HSSWJLCBWXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool YEJYSSDJQIX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<CXXOCPTCXZR> ONPYAFUWWYM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<LHUDJTUIYXO> OOFSSACOZGN;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<ZJMYIFJCKHV> HCSBMXHGLFB
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xDF0AD0", Offset = "0xDEF4D0", VA = "0x180DF0AD0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<ZJMYIFJCKHV>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object KXFWSOWDLDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2BB5A30", Offset = "0x2BB4430", VA = "0x182BB5A30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15A0090", Offset = "0x159EA90", VA = "0x1815A0090")]
				[DebuggerHidden]
				public EKYZUSWCJDD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BB53E0", Offset = "0x2BB3DE0", VA = "0x182BB53E0", Slot = "7")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5530", Offset = "0x2BB3F30", VA = "0x182BB5530", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5AD0", Offset = "0x2BB44D0", VA = "0x182BB5AD0")]
				private void SMVYKFBVGYB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5A80", Offset = "0x2BB4480", VA = "0x182BB5A80")]
				private void SMGDSKUDEQA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5B20", Offset = "0x2BB4520", VA = "0x182BB5B20", Slot = "10")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5330", Offset = "0x2BB3D30", VA = "0x182BB5330", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<ZJMYIFJCKHV>> ZTGGMCNMYGA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5330", Offset = "0x2BB3D30", VA = "0x182BB5330", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator DKFMUHWUXGJ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log OMWAZFACTUS;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<ZJMYIFJCKHV, CXXOCPTCXZR?> PCQKWGDOLWA;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<CXXOCPTCXZR, Id32<ZJMYIFJCKHV>> HUHECBPQNUE;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly ILXFIROPVHU RIDBMZGWSTD;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly ILXFIROPVHU FSKBLMZFPRL;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<CXXOCPTCXZR> GIXNQPRYNXF;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<CXXOCPTCXZR> LKTVGSIZWYG;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet EQSDXFEGVRZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet NSJZECUJSZJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet CGKKAKVEVWN
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD55EB0", Offset = "0xD548B0", VA = "0x180D55EB0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static CXXOCPTCXZR FRBGQEMMISJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB89C0", Offset = "0x2BB73C0", VA = "0x182BB89C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static CXXOCPTCXZR NBIKSSDNWGZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BB88D0", Offset = "0x2BB72D0", VA = "0x182BB88D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static CXXOCPTCXZR CSJNINTFVPM
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BB80D0", Offset = "0x2BB6AD0", VA = "0x182BB80D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static CXXOCPTCXZR WPSRBSYFOTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9340", Offset = "0x2BB7D40", VA = "0x182BB9340")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static CXXOCPTCXZR JAQQVCNLYLQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6440", Offset = "0x2BB4E40", VA = "0x182BB6440")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static CXXOCPTCXZR KKKKWAPUOBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BB86A0", Offset = "0x2BB70A0", VA = "0x182BB86A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static CXXOCPTCXZR VUPQYBVKCSQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5CD0", Offset = "0x2BB46D0", VA = "0x182BB5CD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static CXXOCPTCXZR HHTJRKYZZIA
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9200", Offset = "0x2BB7C00", VA = "0x182BB9200")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static LHUDJTUIYXO GJGDHOMSGGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6530", Offset = "0x2BB4F30", VA = "0x182BB6530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static LHUDJTUIYXO IOEMGNXADEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7F60", Offset = "0x2BB6960", VA = "0x182BB7F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static LHUDJTUIYXO BRHYLXEOZGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6DA0", Offset = "0x2BB57A0", VA = "0x182BB6DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static LHUDJTUIYXO XJXHDBKMRKS
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6EB0", Offset = "0x2BB58B0", VA = "0x182BB6EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static LHUDJTUIYXO TIBELJOAMXM
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB61C0", Offset = "0x2BB4BC0", VA = "0x182BB61C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static LHUDJTUIYXO JEMQWLVTOBT
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB66F0", Offset = "0x2BB50F0", VA = "0x182BB66F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static LHUDJTUIYXO QZSJBDVFLHX
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9290", Offset = "0x2BB7C90", VA = "0x182BB9290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static LHUDJTUIYXO KQAIXAPWGMZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB60B0", Offset = "0x2BB4AB0", VA = "0x182BB60B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static LHUDJTUIYXO GMITAOJUWRK
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7CD0", Offset = "0x2BB66D0", VA = "0x182BB7CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static LHUDJTUIYXO TTKBUHBBOGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BB99E0", Offset = "0x2BB83E0", VA = "0x182BB99E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static LHUDJTUIYXO NQTLILEWVPZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6580", Offset = "0x2BB4F80", VA = "0x182BB6580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static LHUDJTUIYXO PCYIPMQJKON
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BB81C0", Offset = "0x2BB6BC0", VA = "0x182BB81C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static LHUDJTUIYXO UWGPLFYTUTF
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5C80", Offset = "0x2BB4680", VA = "0x182BB5C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static LHUDJTUIYXO DCFPWYLJCYB
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6740", Offset = "0x2BB5140", VA = "0x182BB6740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static LHUDJTUIYXO FQORYDDEKEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6AD0", Offset = "0x2BB54D0", VA = "0x182BB6AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static LHUDJTUIYXO SSMDMAMVYEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7FB0", Offset = "0x2BB69B0", VA = "0x182BB7FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static LHUDJTUIYXO XWAOYOMWLSP
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8450", Offset = "0x2BB6E50", VA = "0x182BB8450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static LHUDJTUIYXO QFQXIBBUZBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8FA0", Offset = "0x2BB79A0", VA = "0x182BB8FA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static LHUDJTUIYXO CIBZWDMKUON
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8390", Offset = "0x2BB6D90", VA = "0x182BB8390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static LHUDJTUIYXO CDWXCUXICHL
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6210", Offset = "0x2BB4C10", VA = "0x182BB6210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static LHUDJTUIYXO KMSGVKIIOMU
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8210", Offset = "0x2BB6C10", VA = "0x182BB8210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static LHUDJTUIYXO CLPZDHOAXGF
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB69B0", Offset = "0x2BB53B0", VA = "0x182BB69B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static LHUDJTUIYXO KDUZODOLJQX
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8AB0", Offset = "0x2BB74B0", VA = "0x182BB8AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static LHUDJTUIYXO EEFFHTWQWOV
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB62D0", Offset = "0x2BB4CD0", VA = "0x182BB62D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static LHUDJTUIYXO OYBUAOHOAYB
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7880", Offset = "0x2BB6280", VA = "0x182BB7880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static LHUDJTUIYXO UVPOOCSVKKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9920", Offset = "0x2BB8320", VA = "0x182BB9920")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static LHUDJTUIYXO DPIKJNUNTGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8B70", Offset = "0x2BB7570", VA = "0x182BB8B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static LHUDJTUIYXO BREOOPIYIDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7F00", Offset = "0x2BB6900", VA = "0x182BB7F00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static LHUDJTUIYXO GDXXAHVUFQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7370", Offset = "0x2BB5D70", VA = "0x182BB7370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static LHUDJTUIYXO LASLGVWERKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7EA0", Offset = "0x2BB68A0", VA = "0x182BB7EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static LHUDJTUIYXO ZEECUHYRAAS
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7A00", Offset = "0x2BB6400", VA = "0x182BB7A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static LHUDJTUIYXO FLKJWSSSKTZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7250", Offset = "0x2BB5C50", VA = "0x182BB7250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static LHUDJTUIYXO NZYXFTIVCDK
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7DE0", Offset = "0x2BB67E0", VA = "0x182BB7DE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static LHUDJTUIYXO VSUAJPNTORH
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8870", Offset = "0x2BB7270", VA = "0x182BB8870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static LHUDJTUIYXO SILVOFKZWZM
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BB77C0", Offset = "0x2BB61C0", VA = "0x182BB77C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static LHUDJTUIYXO HQISMVGPBRG
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6C50", Offset = "0x2BB5650", VA = "0x182BB6C50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static LHUDJTUIYXO CQAQCFANCCO
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7190", Offset = "0x2BB5B90", VA = "0x182BB7190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static LHUDJTUIYXO WTXQPRMHZEJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB65D0", Offset = "0x2BB4FD0", VA = "0x182BB65D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static LHUDJTUIYXO IVIDEYOEIBH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5E20", Offset = "0x2BB4820", VA = "0x182BB5E20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static LHUDJTUIYXO DRXHHQIYEOM
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6100", Offset = "0x2BB4B00", VA = "0x182BB6100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static LHUDJTUIYXO LRLODGSREXE
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9980", Offset = "0x2BB8380", VA = "0x182BB9980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static LHUDJTUIYXO AKAJHLMCFHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5E80", Offset = "0x2BB4880", VA = "0x182BB5E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static LHUDJTUIYXO SLWBNPUFAVE
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9000", Offset = "0x2BB7A00", VA = "0x182BB9000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static LHUDJTUIYXO OOFVYGVRHPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6B90", Offset = "0x2BB5590", VA = "0x182BB6B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static LHUDJTUIYXO VVPDBKVNRIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6690", Offset = "0x2BB5090", VA = "0x182BB6690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static LHUDJTUIYXO UUORVNPAGCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5C20", Offset = "0x2BB4620", VA = "0x182BB5C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static LHUDJTUIYXO KCYBWJEGQWW
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6E50", Offset = "0x2BB5850", VA = "0x182BB6E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static LHUDJTUIYXO YGKNLQNJFGL
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7D20", Offset = "0x2BB6720", VA = "0x182BB7D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static LHUDJTUIYXO BQWQPGXXSTV
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5D60", Offset = "0x2BB4760", VA = "0x182BB5D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static LHUDJTUIYXO TCMQAVACDJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9430", Offset = "0x2BB7E30", VA = "0x182BB9430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static LHUDJTUIYXO OFCQPBPFKOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8270", Offset = "0x2BB6C70", VA = "0x182BB8270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static LHUDJTUIYXO EPIDFWLBGWS
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9060", Offset = "0x2BB7A60", VA = "0x182BB9060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static LHUDJTUIYXO PNGDUCROKRT
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6A70", Offset = "0x2BB5470", VA = "0x182BB6A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static LHUDJTUIYXO RQDAGYFCSZW
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8160", Offset = "0x2BB6B60", VA = "0x182BB8160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static LHUDJTUIYXO EXRDIMFILER
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8330", Offset = "0x2BB6D30", VA = "0x182BB8330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static LHUDJTUIYXO UROXEKXQYCF
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8510", Offset = "0x2BB6F10", VA = "0x182BB8510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static LHUDJTUIYXO HMEDROJFTRH
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8BD0", Offset = "0x2BB75D0", VA = "0x182BB8BD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static LHUDJTUIYXO TFENGVNJSQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7E40", Offset = "0x2BB6840", VA = "0x182BB7E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static LHUDJTUIYXO CERSJFEUBIM
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7760", Offset = "0x2BB6160", VA = "0x182BB7760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static LHUDJTUIYXO RYUQDPTOKWB
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BB83F0", Offset = "0x2BB6DF0", VA = "0x182BB83F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static LHUDJTUIYXO FGGOSBXVKZQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7BB0", Offset = "0x2BB65B0", VA = "0x182BB7BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static LHUDJTUIYXO MIIITCTUZFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BB93D0", Offset = "0x2BB7DD0", VA = "0x182BB93D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static LHUDJTUIYXO MVMCTMDMYVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6BF0", Offset = "0x2BB55F0", VA = "0x182BB6BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static LHUDJTUIYXO QJIPLIQVHUE
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7AC0", Offset = "0x2BB64C0", VA = "0x182BB7AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static LHUDJTUIYXO JDAUMMEHORW
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BB79A0", Offset = "0x2BB63A0", VA = "0x182BB79A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static LHUDJTUIYXO GYVUWDMCVKX
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7130", Offset = "0x2BB5B30", VA = "0x182BB7130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static LHUDJTUIYXO YXNKNDSKIXB
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6160", Offset = "0x2BB4B60", VA = "0x182BB6160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static LHUDJTUIYXO MPAMHGGYHTZ
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6950", Offset = "0x2BB5350", VA = "0x182BB6950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static LHUDJTUIYXO OEIIETIQZJQ
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB84B0", Offset = "0x2BB6EB0", VA = "0x182BB84B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static LHUDJTUIYXO LCCGAIMMZNE
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6050", Offset = "0x2BB4A50", VA = "0x182BB6050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static LHUDJTUIYXO DGHXDOWURFI
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5B60", Offset = "0x2BB4560", VA = "0x182BB5B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static LHUDJTUIYXO VRGJLZZUTNB
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7C10", Offset = "0x2BB6610", VA = "0x182BB7C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static LHUDJTUIYXO PXETOPHQNFY
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5DC0", Offset = "0x2BB47C0", VA = "0x182BB5DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static LHUDJTUIYXO LWLYJMVSHMO
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6CB0", Offset = "0x2BB56B0", VA = "0x182BB6CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static LHUDJTUIYXO PEWZLVIBULV
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BB82D0", Offset = "0x2BB6CD0", VA = "0x182BB82D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static LHUDJTUIYXO VVKBUOUCWLT
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BB68F0", Offset = "0x2BB52F0", VA = "0x182BB68F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static LHUDJTUIYXO QMTSCYVVDME
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9A30", Offset = "0x2BB8430", VA = "0x182BB9A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static LHUDJTUIYXO DCQQNQBCXPV
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6630", Offset = "0x2BB5030", VA = "0x182BB6630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static LHUDJTUIYXO ERKWZPTCJOR
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7D80", Offset = "0x2BB6780", VA = "0x182BB7D80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static LHUDJTUIYXO OIOXHHEVRQK
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7B50", Offset = "0x2BB6550", VA = "0x182BB7B50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static LHUDJTUIYXO GGANIPHQOGW
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6D10", Offset = "0x2BB5710", VA = "0x182BB6D10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static LHUDJTUIYXO YEWVLHYCKFV
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BB70D0", Offset = "0x2BB5AD0", VA = "0x182BB70D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static LHUDJTUIYXO WOAKFAISFYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7940", Offset = "0x2BB6340", VA = "0x182BB7940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static LHUDJTUIYXO STBCYZEUGHX
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9E00", Offset = "0x2BB8800", VA = "0x182BB9E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static LHUDJTUIYXO HJMKTRJELUF
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9D40", Offset = "0x2BB8740", VA = "0x182BB9D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static LHUDJTUIYXO MOPAVWZGNHT
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6F60", Offset = "0x2BB5960", VA = "0x182BB6F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static LHUDJTUIYXO SRATXHSWPFL
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB78E0", Offset = "0x2BB62E0", VA = "0x182BB78E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static LHUDJTUIYXO BFGJVHWNYSR
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5FF0", Offset = "0x2BB49F0", VA = "0x182BB5FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static LHUDJTUIYXO ELICPYWOQXS
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9490", Offset = "0x2BB7E90", VA = "0x182BB9490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static LHUDJTUIYXO RPCRRYJAEHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BB90C0", Offset = "0x2BB7AC0", VA = "0x182BB90C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static LHUDJTUIYXO YRXEJQGXCOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7A60", Offset = "0x2BB6460", VA = "0x182BB7A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static LHUDJTUIYXO NOLEOMMCNAD
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BB91A0", Offset = "0x2BB7BA0", VA = "0x182BB91A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static LHUDJTUIYXO UGYDNWRTAUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6A10", Offset = "0x2BB5410", VA = "0x182BB6A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static LHUDJTUIYXO EFHQEFDBIDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8010", Offset = "0x2BB6A10", VA = "0x182BB8010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static LHUDJTUIYXO UYFKECKCEXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6F00", Offset = "0x2BB5900", VA = "0x182BB6F00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static LHUDJTUIYXO DWDAORFKWRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8A50", Offset = "0x2BB7450", VA = "0x182BB8A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static LHUDJTUIYXO ZOUDGTLSFHX
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5F90", Offset = "0x2BB4990", VA = "0x182BB5F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static LHUDJTUIYXO UILMIMXUWOU
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BB92E0", Offset = "0x2BB7CE0", VA = "0x182BB92E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static LHUDJTUIYXO WFVJSNAOWSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6DF0", Offset = "0x2BB57F0", VA = "0x182BB6DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static LHUDJTUIYXO OYVUZBYSUTX
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6FC0", Offset = "0x2BB59C0", VA = "0x182BB6FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static LHUDJTUIYXO OUEMNWONCLP
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB94F0", Offset = "0x2BB7EF0", VA = "0x182BB94F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static LHUDJTUIYXO QPRSEJYZUOS
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8B10", Offset = "0x2BB7510", VA = "0x182BB8B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static LHUDJTUIYXO HWZVSNWVNZX
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7C70", Offset = "0x2BB6670", VA = "0x182BB7C70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static LHUDJTUIYXO COMGPJVNEAD
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8960", Offset = "0x2BB7360", VA = "0x182BB8960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static LHUDJTUIYXO JRRRUPARDHI
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB64D0", Offset = "0x2BB4ED0", VA = "0x182BB64D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static LHUDJTUIYXO CHOXBOFPUZN
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7820", Offset = "0x2BB6220", VA = "0x182BB7820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static LHUDJTUIYXO XCBISAGBUKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9E60", Offset = "0x2BB8860", VA = "0x182BB9E60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static LHUDJTUIYXO YNJUIYJNWAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8810", Offset = "0x2BB7210", VA = "0x182BB8810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static LHUDJTUIYXO RFJRCDBCMMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7310", Offset = "0x2BB5D10", VA = "0x182BB7310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static LHUDJTUIYXO DJAADUMVSZU
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9EC0", Offset = "0x2BB88C0", VA = "0x182BB9EC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static LHUDJTUIYXO JYCHRTUOZWE
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6330", Offset = "0x2BB4D30", VA = "0x182BB6330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static LHUDJTUIYXO WLFBUIIPUJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5BC0", Offset = "0x2BB45C0", VA = "0x182BB5BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static LHUDJTUIYXO ZXIIMFLRKLY
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6890", Offset = "0x2BB5290", VA = "0x182BB6890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static LHUDJTUIYXO MPQOMFSDUAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9DA0", Offset = "0x2BB87A0", VA = "0x182BB9DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static LHUDJTUIYXO WTAFLYBLKQR
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6270", Offset = "0x2BB4C70", VA = "0x182BB6270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static LHUDJTUIYXO YFXSVWVENUT
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6B30", Offset = "0x2BB5530", VA = "0x182BB6B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static LHUDJTUIYXO YBMTLYZWUVX
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8070", Offset = "0x2BB6A70", VA = "0x182BB8070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static LHUDJTUIYXO HEJIOSVZVIP
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB71F0", Offset = "0x2BB5BF0", VA = "0x182BB71F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static LHUDJTUIYXO PDMJBXTIIOQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB72B0", Offset = "0x2BB5CB0", VA = "0x182BB72B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BB67A0", Offset = "0x2BB51A0", VA = "0x182BB67A0")]
			public static ILXFIROPVHU FKAWAJFRRAK([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8730", Offset = "0x2BB7130", VA = "0x182BB8730")]
			public static ClassFactoryTypeParams TIXZCUGSTZZ(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BB87E0", Offset = "0x2BB71E0", VA = "0x182BB87E0")]
			public static ClassFactoryTypeParams TIXZCUGSTZZ([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7B20", Offset = "0x2BB6520", VA = "0x182BB7B20")]
			public static ILXFIROPVHU OAXCXKAMDWM(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6D70", Offset = "0x2BB5770", VA = "0x182BB6D70")]
			public static ILXFIROPVHU ICVNJTZJOZX(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8570", Offset = "0x2BB6F70", VA = "0x182BB8570")]
			public static ILXFIROPVHU TBSEVKJGIEZ([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BB76B0", Offset = "0x2BB60B0", VA = "0x182BB76B0")]
			public static CXXOCPTCXZR LHEFRIFLVTB(Id32<ZJMYIFJCKHV> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB95C0", Offset = "0x2BB7FC0", VA = "0x182BB95C0")]
			public static string YHKJFWBIDVS(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB73D0", Offset = "0x2BB5DD0", VA = "0x182BB73D0")]
			private static CXXOCPTCXZR LHEFRIFLVTB(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9550", Offset = "0x2BB7F50", VA = "0x182BB9550")]
			public static Id32<ZJMYIFJCKHV>? YCFPWWSUVMS(CXXOCPTCXZR a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8C30", Offset = "0x2BB7630", VA = "0x182BB8C30")]
			public static CircuitTypeIdWrapper? VURINLYFPEZ(CXXOCPTCXZR a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9F20", Offset = "0x2BB8920", VA = "0x182BB9F20")]
			static EPVLMKETIYT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6390", Offset = "0x2BB4D90", VA = "0x182BB6390")]
			[IteratorStateMachine(typeof(XLZOZXWEMPA))]
			private static IEnumerable<CXXOCPTCXZR> DGAUTNLNSSH(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7020", Offset = "0x2BB5A20", VA = "0x182BB7020")]
			[IteratorStateMachine(typeof(CAQDTUESIEM))]
			public static IEnumerable<CXXOCPTCXZR> JKTSSIYXTAC(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9A90", Offset = "0x2BB8490", VA = "0x182BB9A90")]
			public static Variant ZDIOJTZOYLR(CXXOCPTCXZR a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9640", Offset = "0x2BB8040", VA = "0x182BB9640")]
			public static Variant YLRQPXOJIJQ(CXXOCPTCXZR a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9120", Offset = "0x2BB7B20", VA = "0x182BB9120")]
			public static bool WKISCAXMXIO(CXXOCPTCXZR a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5EE0", Offset = "0x2BB48E0", VA = "0x182BB5EE0")]
			[IteratorStateMachine(typeof(EKYZUSWCJDD))]
			public static IEnumerable<Id32<ZJMYIFJCKHV>> ATJLEPHDKEQ(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AACIDYLUEAY
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE9A0", Offset = "0x2BAD3A0", VA = "0x182BAE9A0")]
		public static OJANIIIRTHV XQIXCNAGDPI(this CXXOCPTCXZR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BADE30", Offset = "0x2BAC830", VA = "0x182BADE30")]
		public static CXXOCPTCXZR BNRJUVCRJLB(this OJANIIIRTHV a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class CKCFOHOWASJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37E48E0", Offset = "0x37E32E0", VA = "0x1837E48E0")]
		public static Dictionary<b, c> JMJVLRDGJOT<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class TPIJVCSHUIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAB70", Offset = "0x2BC9570", VA = "0x182BCAB70")]
		public static HMMIZFFUYKF XQIXCNAGDPI([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAAD0", Offset = "0x2BC94D0", VA = "0x182BCAAD0")]
		public static Guid BNRJUVCRJLB(HMMIZFFUYKF a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class UVCCOTOIFFQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC020", Offset = "0x2BCAA20", VA = "0x182BCC020")]
		public static TJITOWYIITL XQIXCNAGDPI([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBFC0", Offset = "0x2BCA9C0", VA = "0x182BCBFC0")]
		public static NamedType BNRJUVCRJLB(this TJITOWYIITL a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class SCQNPHRYVBV
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F03500", Offset = "0x3F01F00", VA = "0x183F03500")]
		public static void DYUIEZDWFGT<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F03760", Offset = "0x3F02160", VA = "0x183F03760")]
		public static void DYUIEZDWFGT<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class GXAYMMYDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1830", Offset = "0x2BC0230", VA = "0x182BC1830")]
		public static QFPQWTGXSZL XQIXCNAGDPI([In] this Variant self, CXXOCPTCXZR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC16E0", Offset = "0x2BC00E0", VA = "0x182BC16E0")]
		public static Variant BNRJUVCRJLB(this QFPQWTGXSZL a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HCJGNOTCAWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<CRYJNXRKZYM> UVUKOKJGVHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool AEAMKOAIBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool LIMMCILJILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool PKOKCKYNFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool THNIPCZYBTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool THIBRWGASHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool UIMMNNXJTYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool RYGLGXJYGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool HLHPOAPDCFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, CXXOCPTCXZR Type)> OPUNOXMTYCG;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid LVYPECRPQWF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B74240", Offset = "0x2B72C40", VA = "0x182B74240")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<CRYJNXRKZYM> NTNUOLKTPET
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B74240", Offset = "0x2B72C40", VA = "0x182B74240")]
			get
			{
				return default(Id128<CRYJNXRKZYM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, CXXOCPTCXZR Type)> JFSKABSYKMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IPWNGKSSXXY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2360", Offset = "0x2BC0D60", VA = "0x182BC2360")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1FB0", Offset = "0x2BC09B0", VA = "0x182BC1FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, CXXOCPTCXZR> IBXJBULZTUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1A30", Offset = "0x2BC0430", VA = "0x182BC1A30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2160", Offset = "0x2BC0B60", VA = "0x182BC2160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> SVGPJKIWNJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BC28A0", Offset = "0x2BC12A0", VA = "0x182BC28A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1DB0", Offset = "0x2BC07B0", VA = "0x182BC1DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> BYSVLMBVTWU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2950", Offset = "0x2BC1350", VA = "0x182BC2950")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1AE0", Offset = "0x2BC04E0", VA = "0x182BC1AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, CXXOCPTCXZR> KTTHYJCKWYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2400", Offset = "0x2BC0E00", VA = "0x182BC2400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2AF0", Offset = "0x2BC14F0", VA = "0x182BC2AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action BZCTQSXDOCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2050", Offset = "0x2BC0A50", VA = "0x182BC2050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BC26F0", Offset = "0x2BC10F0", VA = "0x182BC26F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B1D170", Offset = "0x1B1BB70", VA = "0x181B1D170")]
		public void CRLFQHRFYSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2BA0", Offset = "0x2BC15A0", VA = "0x182BC2BA0")]
		internal HCJGNOTCAWM([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, CXXOCPTCXZR Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2210", Offset = "0x2BC0C10", VA = "0x182BC2210")]
		public static CircuitEventDefinitionFactoryStart ONZPJVMVHLX(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BC22E0", Offset = "0x2BC0CE0", VA = "0x182BC22E0")]
		public static CircuitEventDefinitionFactoryStart ONZPJVMVHLX(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2790", Offset = "0x2BC1190", VA = "0x182BC2790")]
		public static HCJGNOTCAWM VOMBMLTEKVF([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BC24B0", Offset = "0x2BC0EB0", VA = "0x182BC24B0")]
		public static HCJGNOTCAWM SEUFIGJYNHP([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xEF8910", Offset = "0xEF7310", VA = "0x180EF8910")]
		public void CLCNYFDVLSP(Id128<CRYJNXRKZYM> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1E60", Offset = "0x2BC0860", VA = "0x182BC1E60")]
		public void EFVBFFKCRQS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1EC0", Offset = "0x2BC08C0", VA = "0x182BC1EC0")]
		public void EISORQGYJUK(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2A00", Offset = "0x2BC1400", VA = "0x182BC2A00")]
		public void YQCRGNPMVAZ(int a, CXXOCPTCXZR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B90", Offset = "0x2BC0590", VA = "0x182BC1B90")]
		public void CVCYUNVEYPF(string a, CXXOCPTCXZR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC20F0", Offset = "0x2BC0AF0", VA = "0x182BC20F0")]
		public void HGPYVKMNLCY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1CB0", Offset = "0x2BC06B0", VA = "0x182BC1CB0")]
		public HCJGNOTCAWM Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2BB3E30", Offset = "0x2BB2830", VA = "0x182BB3E30")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3CC0", Offset = "0x2BB26C0", VA = "0x182BB3CC0")]
		public CircuitEventDefinitionFactoryParams UFVPZMMVMLP(string a, CXXOCPTCXZR b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3B90", Offset = "0x2BB2590", VA = "0x182BB3B90")]
		public HCJGNOTCAWM QUSLSCNGWNP()
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
		private readonly List<(string Name, CXXOCPTCXZR Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3B00", Offset = "0x2BB2500", VA = "0x182BB3B00")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, CXXOCPTCXZR Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BB39D0", Offset = "0x2BB23D0", VA = "0x182BB39D0")]
		public CircuitEventDefinitionFactoryParams UFVPZMMVMLP(string a, CXXOCPTCXZR b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BB38D0", Offset = "0x2BB22D0", VA = "0x182BB38D0")]
		public HCJGNOTCAWM QUSLSCNGWNP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class OSVTLPGBYHD
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly HCJGNOTCAWM OGTPWINDNBG;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly HCJGNOTCAWM KJDHWPWDRKX;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly HCJGNOTCAWM QJMOWANLGFQ;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly HCJGNOTCAWM QMGRMHQVAZF;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly HCJGNOTCAWM MJPARSTYDJG;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly HCJGNOTCAWM ZQWBSYHKYMC;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly HCJGNOTCAWM RHLSVYQSXYV;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly HCJGNOTCAWM[] COSYWHYQICC;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class ZOPTTLELONO
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly HCJGNOTCAWM RFTZJFVYEWI;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class KLFFUGVZWKT
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly HCJGNOTCAWM RJEXOSUMDWU;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly HCJGNOTCAWM RENSNVKHBDD;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class ZXKTMHTICBU
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly HCJGNOTCAWM PCMGDJKZWMJ;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly HCJGNOTCAWM LMEGSDSRSHO;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly HCJGNOTCAWM[] YQPPQQFFBHK;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly HCJGNOTCAWM YMGPWNAXNGA;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly HCJGNOTCAWM VZNVWXCTEIB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class NNLWWZUVYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly HCJGNOTCAWM OFRIYIVUPWJ;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly HCJGNOTCAWM UANPTDOIXIU;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class GJHRNINMMKX
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly HCJGNOTCAWM QDURZSAHVAY;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly HCJGNOTCAWM MLVFOMCSGDJ;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class OCXLBHLNFVW
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly HCJGNOTCAWM RJEXOSUMDWU;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly HCJGNOTCAWM RENSNVKHBDD;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class UKCVVPOYIKS
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly HCJGNOTCAWM ZQJVBXCDDST;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly HCJGNOTCAWM MLUIDMPKEGU;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly HCJGNOTCAWM ZFAMNDVLDNE;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly HCJGNOTCAWM AKRVTATUDIM;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly HCJGNOTCAWM ORHQMBEQAQD;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly HCJGNOTCAWM GFFBCTHVEGA;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly HCJGNOTCAWM LTSCIJGRNMR;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class WDHSZDCISFM
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RZDNGGURNTQ
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class TBRPSAYVNBE
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class CLPSJDTXXZA
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly HCJGNOTCAWM OZNYJROHKGD;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly HCJGNOTCAWM AJGBGISJTWE;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class SXUEDCCRJSA
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class ZLUZNATYAJC
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class VEFPTGIEUBS
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class KXMPDLSKGWP
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly HCJGNOTCAWM GOQMYYPBNZB;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly HCJGNOTCAWM AFTURXCNDGJ;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly HCJGNOTCAWM ILCJOBLOPHY;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly HCJGNOTCAWM PTSDWIKOIGX;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly HCJGNOTCAWM YVVRCEFTHBL;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly HCJGNOTCAWM QDURZSAHVAY;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly HCJGNOTCAWM EFYSWHHKLAV;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly HCJGNOTCAWM GSGWXDIECBA;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly HCJGNOTCAWM JALIGCYWXHS;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly HCJGNOTCAWM PHATNDVBCIE;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly HCJGNOTCAWM WWVCLNGSOAK;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly HCJGNOTCAWM LKALTPSWPVO;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly HCJGNOTCAWM EHKXAVCOMLR;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly HCJGNOTCAWM FSHBRPEKBAC;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly HCJGNOTCAWM HGRBNEQWNMB;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly HCJGNOTCAWM QSNRAZRFHRL;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly HCJGNOTCAWM TFYJEELYUAH;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly HCJGNOTCAWM IJQXAUCLKXG;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly HCJGNOTCAWM WYQULOSJDMJ;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly HCJGNOTCAWM MMCDEFBKJGH;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly HCJGNOTCAWM XGXIRTXBQQO;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly HCJGNOTCAWM BYOCCUCNLAS;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly HCJGNOTCAWM NHTYOWOUXTW;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly HCJGNOTCAWM XVBMZLIXFOI;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly HCJGNOTCAWM SRCUWWMQXZS;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly HCJGNOTCAWM IDTREBSIQXS;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly HCJGNOTCAWM EUVOQPNYHMC;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly HCJGNOTCAWM JMMIBPTKBWG;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly HCJGNOTCAWM IHGVWFQLZYD;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly HCJGNOTCAWM BAJHRKMVPWD;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly HCJGNOTCAWM HZOSEFVTHZY;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly HCJGNOTCAWM POFYRNCKPTM;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly HCJGNOTCAWM YINQKYEZYYT;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly HCJGNOTCAWM MVCOWEBQHMH;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly HCJGNOTCAWM UZUZREXLQYH;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly HCJGNOTCAWM OEGRQUXRIHF;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly HCJGNOTCAWM ULMHFSEBKPB;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly HCJGNOTCAWM PBGBWINHGBH;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly HCJGNOTCAWM KULEXPZWDPX;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly HCJGNOTCAWM YRWHJRGKSFL;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly HCJGNOTCAWM XSHOHHQLWAI;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly HCJGNOTCAWM FEXATODOWPU;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly HCJGNOTCAWM NQBBDMAWCIQ;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly HCJGNOTCAWM KQMHDIBZUOU;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly HCJGNOTCAWM WQLCILDYTQY;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly HCJGNOTCAWM YQLECVNAQGE;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly HCJGNOTCAWM CYRUFBCSLUG;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly HCJGNOTCAWM MJFERCMSNFU;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly HCJGNOTCAWM KNSHDJBIVZE;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly HCJGNOTCAWM IYDLREUHPDK;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly HCJGNOTCAWM QRTKCJUMHIH;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly HCJGNOTCAWM JBUPNIYDQCI;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly HCJGNOTCAWM WUWGYKPBKBM;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly HCJGNOTCAWM MTVRKCXSLAE;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly HCJGNOTCAWM YAMVPGTXHUI;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly HCJGNOTCAWM QFMWTDKOWWA;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly HCJGNOTCAWM GMWMXRPDTTO;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly HCJGNOTCAWM RQUYBEVXRRG;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly HCJGNOTCAWM YBGGIGSIEZE;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly HCJGNOTCAWM GTRJHHQHOPY;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly HCJGNOTCAWM IVFTCTWAAAG;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly HCJGNOTCAWM ZEZRSNJDJOQ;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly HCJGNOTCAWM PVIAAWUPJCD;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly HCJGNOTCAWM YNIBMKBTSUI;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly HCJGNOTCAWM CLXQTBHLYJW;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly HCJGNOTCAWM TNTTJNSBDRB;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly HCJGNOTCAWM YZCLJEYVUQZ;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly HCJGNOTCAWM NPNDYZNPUEG;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly HCJGNOTCAWM YWDTAJKBIEA;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class PJAQMHUYBKD
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class HZKVIEUHXUO
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly HCJGNOTCAWM BDHIYRDQICU;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly HCJGNOTCAWM VMVODZEPUKN;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly HCJGNOTCAWM HAAAYNMQDOR;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly HCJGNOTCAWM LNWFLSMELOS;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly HCJGNOTCAWM ECQATWTQKSK;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly HCJGNOTCAWM PHUFOZNAYSE;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly HCJGNOTCAWM UYFIVLHQZUS;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class JAUUCWIFOYH
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly HCJGNOTCAWM AFTURXCNDGJ;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly HCJGNOTCAWM ILCJOBLOPHY;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly HCJGNOTCAWM PTSDWIKOIGX;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly HCJGNOTCAWM HOBYEBFKXDN;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly HCJGNOTCAWM EAKICGYZQTJ;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly HCJGNOTCAWM JMVRMFHWQBN;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly HCJGNOTCAWM PKERGBLZPPP;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class NTPKJKRDYVR
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly HCJGNOTCAWM RNIYSMVCDRX;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly HCJGNOTCAWM SDNWHGWPQHX;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly HCJGNOTCAWM LYURCNEFVDE;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly HCJGNOTCAWM EGHYBQJSWLE;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly HCJGNOTCAWM PPSFKAPPSDY;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly HCJGNOTCAWM FCHLVVUHCNO;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class XPFIZNJKWCI
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class QBDACFEVLRF
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly HCJGNOTCAWM CYXZUTSHUIF;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class BLJKBKMPKXT
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly HCJGNOTCAWM GOQMYYPBNZB;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class YKQDCZBOUTQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class NNPMITPBZTP
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class PTJVYFWXBYC
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly HCJGNOTCAWM DMYKWHTIQLE;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly HCJGNOTCAWM GQIXJUZADXO;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly HCJGNOTCAWM QIMNCTPLBAL;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly HCJGNOTCAWM SFUAJGGTSMX;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class WVTPXYUBIKE
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly HCJGNOTCAWM QQFTANJYJVL;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly HCJGNOTCAWM UAWMJWYPHJY;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class QLHUSKDFYHO
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class YDFMSONROUA
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly HCJGNOTCAWM BDHIYRDQICU;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly HCJGNOTCAWM VMVODZEPUKN;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class NVPGBZFVVGZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly HCJGNOTCAWM ZMTMDEKWWGO;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly HCJGNOTCAWM LNWFLSMELOS;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly HCJGNOTCAWM ECQATWTQKSK;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly HCJGNOTCAWM PHUFOZNAYSE;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly HCJGNOTCAWM INDIIYJXWGH;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly HCJGNOTCAWM PEBVPUTCQJK;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly HCJGNOTCAWM ITLXAUNFNCE;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly HCJGNOTCAWM RNBYUMFFHZI;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly HCJGNOTCAWM PTMIHINBIWX;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly HCJGNOTCAWM CBHDPSNDSGT;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly HCJGNOTCAWM BDHIYRDQICU;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly HCJGNOTCAWM VMVODZEPUKN;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class CQQSGFEQGMP
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ZJKIJVNPTON
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly HCJGNOTCAWM BDHIYRDQICU;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly HCJGNOTCAWM VMVODZEPUKN;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly HCJGNOTCAWM RFJVWYZASRR;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly HCJGNOTCAWM MTOCZWTVICX;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly HCJGNOTCAWM DKRUADIWSBE;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class OILZVKDXWRS
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class XEIRVSQLPGT
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly HCJGNOTCAWM SJZVHGUIPKM;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class BYFFBQKASNR
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly HCJGNOTCAWM VQRYNIUVQTH;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly HCJGNOTCAWM EKSRNNMEHUY;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly HCJGNOTCAWM BDHIYRDQICU;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly HCJGNOTCAWM VMVODZEPUKN;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class YZNCRWHVFHQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class WIGMJZVOOCK
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class LGHHZFXXUKT
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class WCDBJVQGBJR
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class IMQUBHGYNSG
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class FNFIGEMBYDA
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly HCJGNOTCAWM OZNYJROHKGD;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly HCJGNOTCAWM AJGBGISJTWE;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class UKNDCLUAKTU
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly HCJGNOTCAWM RSWKKISKCOJ;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly HCJGNOTCAWM LMRXHKQXBLB;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly HCJGNOTCAWM GJMPEUNSOVT;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly HCJGNOTCAWM MWHQSZEINYT;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class DWWBXBMMXWX
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly HCJGNOTCAWM RSWKKISKCOJ;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly HCJGNOTCAWM LMRXHKQXBLB;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly HCJGNOTCAWM GJMPEUNSOVT;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly HCJGNOTCAWM MWHQSZEINYT;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class TWWKXAPJOHA
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class ANVQJIGGHPR
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly HCJGNOTCAWM TAQGRKICTSY;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly HCJGNOTCAWM WBKCQFZRDRO;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly HCJGNOTCAWM KHASCHDWPTW;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class HMSGLTYOPLI
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly HCJGNOTCAWM KWCSGCWCXWV;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly HCJGNOTCAWM MMSGQICPXUX;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly HCJGNOTCAWM NXTIKHHYTFS;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class HJRCDGGWQNP
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class DENQXDBPAQY
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly HCJGNOTCAWM DSWPMDCTEQI;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly HCJGNOTCAWM XKTEEPMMYYK;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly HCJGNOTCAWM NHRUAQRNNDP;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly HCJGNOTCAWM DSEHUGITECN;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly HCJGNOTCAWM LXLPSKFCMSM;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class PCQYCJNLYFR
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly HCJGNOTCAWM POBXWEZIPUY;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class EAAVXDHSZZV
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly HCJGNOTCAWM AIYUNPTAKND;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly HCJGNOTCAWM QAAICJIFYNU;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly HCJGNOTCAWM OJJVNYDTAYZ;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class QRVBOMKNRYM
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class ELOKJMBKHWO
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class IRLUXDKJWRH
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class OYMHQUWOYIK
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly HCJGNOTCAWM LMSOLWYQWID;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly HCJGNOTCAWM ORQMLAAXCZG;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly HCJGNOTCAWM ZFEGQNLVNOS;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly HCJGNOTCAWM HJRBPQEHVTM;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly HCJGNOTCAWM VJMCRNMUHPD;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly HCJGNOTCAWM UOURAFDTRRV;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly HCJGNOTCAWM ZWSJBIFDAKM;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class HNNRFONSXXQ
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly HCJGNOTCAWM ZZEQCKNPKBL;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly HCJGNOTCAWM[] TPTWEBAKSQF;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class GCPXVZKOYEW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly CXXOCPTCXZR YVIHJNNFDZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<HCJGNOTCAWM> QVFLDUSTFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<HCJGNOTCAWM> VSULCIUIPWW;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<HCJGNOTCAWM> GRHWWIVLXWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<HCJGNOTCAWM> BHZZLAPCPVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3510", Offset = "0x2BD1F10", VA = "0x182BD3510")]
		protected GCPXVZKOYEW(CXXOCPTCXZR a, params HCJGNOTCAWM[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class LASSKIIBLPQ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BD76A0", Offset = "0x2BD60A0", VA = "0x182BD76A0")]
		internal LASSKIIBLPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class DKYPWVCLMFJ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1880", Offset = "0x2BD0280", VA = "0x182BD1880")]
		internal DKYPWVCLMFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NVLOKFJKHHE : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8B60", Offset = "0x2BD7560", VA = "0x182BD8B60")]
		internal NVLOKFJKHHE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class CKKPZZPSJHB : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BD08E0", Offset = "0x2BCF2E0", VA = "0x182BD08E0")]
		internal CKKPZZPSJHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class JISGVDGBJLS : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD72E0", Offset = "0x2BD5CE0", VA = "0x182BD72E0")]
		internal JISGVDGBJLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class POAPZUBWYFW : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAFA0", Offset = "0x2BD99A0", VA = "0x182BDAFA0")]
		internal POAPZUBWYFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class DHLPVFNFWVV : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD16A0", Offset = "0x2BD00A0", VA = "0x182BD16A0")]
		internal DHLPVFNFWVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class OIZRHRLPWIS : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9D50", Offset = "0x2BD8750", VA = "0x182BD9D50")]
		internal OIZRHRLPWIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ENCCQLDSOFC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2D60", Offset = "0x2BD1760", VA = "0x182BD2D60")]
		internal ENCCQLDSOFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class XKJJWGPQVXC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEB00", Offset = "0x2BDD500", VA = "0x182BDEB00")]
		internal XKJJWGPQVXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class CUWHVPIPNME : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0B30", Offset = "0x2BCF530", VA = "0x182BD0B30")]
		internal CUWHVPIPNME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class PMLERETKLRC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDADC0", Offset = "0x2BD97C0", VA = "0x182BDADC0")]
		internal PMLERETKLRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class HLYJEMYLTSM : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4870", Offset = "0x2BD3270", VA = "0x182BD4870")]
		internal HLYJEMYLTSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class VGPXGJTONPC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE070", Offset = "0x2BDCA70", VA = "0x182BDE070")]
		internal VGPXGJTONPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TQHPSFKWDKG : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCF80", Offset = "0x2BDB980", VA = "0x182BDCF80")]
		internal TQHPSFKWDKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZUVAFPMPUNQ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFC80", Offset = "0x2BDE680", VA = "0x182BDFC80")]
		internal ZUVAFPMPUNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class HAEONCEFMVQ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4080", Offset = "0x2BD2A80", VA = "0x182BD4080")]
		internal HAEONCEFMVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class GHCHHJWNUYH : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3690", Offset = "0x2BD2090", VA = "0x182BD3690")]
		internal GHCHHJWNUYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class PZAGZGRCXMZ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBB60", Offset = "0x2BDA560", VA = "0x182BDBB60")]
		internal PZAGZGRCXMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class LZVMWOHWKSB : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD78F0", Offset = "0x2BD62F0", VA = "0x182BD78F0")]
		internal LZVMWOHWKSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class BMZEYHGLHSP : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFC90", Offset = "0x2BCE690", VA = "0x182BCFC90")]
		internal BMZEYHGLHSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class BOLOGKOHZBV : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFEF0", Offset = "0x2BCE8F0", VA = "0x182BCFEF0")]
		internal BOLOGKOHZBV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class OOUIKJNQRHC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA110", Offset = "0x2BD8B10", VA = "0x182BDA110")]
		internal OOUIKJNQRHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class IZCSUVXJMFL : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5B70", Offset = "0x2BD4570", VA = "0x182BD5B70")]
		internal IZCSUVXJMFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ROOJDSQFLXI : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC630", Offset = "0x2BDB030", VA = "0x182BDC630")]
		internal ROOJDSQFLXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ZJVFQKUFBUJ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFAA0", Offset = "0x2BDE4A0", VA = "0x182BDFAA0")]
		internal ZJVFQKUFBUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class DWXHGREUEJV : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD26B0", Offset = "0x2BD10B0", VA = "0x182BD26B0")]
		internal DWXHGREUEJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class YPTXLHIAAPH : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF1B0", Offset = "0x2BDDBB0", VA = "0x182BDF1B0")]
		internal YPTXLHIAAPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class WICQSDBZBCU : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE1C0", Offset = "0x2BDCBC0", VA = "0x182BDE1C0")]
		internal WICQSDBZBCU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class TVAKKPUZPZP : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD160", Offset = "0x2BDBB60", VA = "0x182BDD160")]
		internal TVAKKPUZPZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class BIOVNSVFMTO : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF910", Offset = "0x2BCE310", VA = "0x182BCF910")]
		internal BIOVNSVFMTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ONONGJXYHUC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9F30", Offset = "0x2BD8930", VA = "0x182BD9F30")]
		internal ONONGJXYHUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class RJYHQCRREZY : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC450", Offset = "0x2BDAE50", VA = "0x182BDC450")]
		internal RJYHQCRREZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ADCCTMDEDXD : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEAD0", Offset = "0x2BCD4D0", VA = "0x182BCEAD0")]
		internal ADCCTMDEDXD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class UMCXYCKTLXJ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE90", Offset = "0x2BDC890", VA = "0x182BDDE90")]
		internal UMCXYCKTLXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class ZZJVEWLUWAB : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE60", Offset = "0x2BDE860", VA = "0x182BDFE60")]
		internal ZZJVEWLUWAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class QHMHHFLUVIG : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBFB0", Offset = "0x2BDA9B0", VA = "0x182BDBFB0")]
		internal QHMHHFLUVIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class PLEBMQVYOIH : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAB60", Offset = "0x2BD9560", VA = "0x182BDAB60")]
		internal PLEBMQVYOIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class AMIBZWENPQT : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEF10", Offset = "0x2BCD910", VA = "0x182BCEF10")]
		internal AMIBZWENPQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class NDOPQUMMGNG : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7FF0", Offset = "0x2BD69F0", VA = "0x182BD7FF0")]
		internal NDOPQUMMGNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class JWQIEJDHPVG : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD74C0", Offset = "0x2BD5EC0", VA = "0x182BD74C0")]
		internal JWQIEJDHPVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class UAOWFAOGXBW : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD3B0", Offset = "0x2BDBDB0", VA = "0x182BDD3B0")]
		internal UAOWFAOGXBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class SSOXPLVJELN : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCDA0", Offset = "0x2BDB7A0", VA = "0x182BDCDA0")]
		internal SSOXPLVJELN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class RZJUYSUUXDJ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC810", Offset = "0x2BDB210", VA = "0x182BDC810")]
		internal RZJUYSUUXDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class AFQTKVIWOTO : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BCED30", Offset = "0x2BCD730", VA = "0x182BCED30")]
		internal AFQTKVIWOTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class NCLCYFCCUMR : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7E10", Offset = "0x2BD6810", VA = "0x182BD7E10")]
		internal NCLCYFCCUMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class QXSUHFEGUHC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC270", Offset = "0x2BDAC70", VA = "0x182BDC270")]
		internal QXSUHFEGUHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class DLXDRUMOJNN : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BD19E0", Offset = "0x2BD03E0", VA = "0x182BD19E0")]
		internal DLXDRUMOJNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MJBDVZJVDAD : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7AD0", Offset = "0x2BD64D0", VA = "0x182BD7AD0")]
		internal MJBDVZJVDAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class FEBAZSJUYKY : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2F40", Offset = "0x2BD1940", VA = "0x182BD2F40")]
		internal FEBAZSJUYKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class BPGAQMESNFM : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0150", Offset = "0x2BCEB50", VA = "0x182BD0150")]
		internal BPGAQMESNFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class DPMKTHRBQCZ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1BC0", Offset = "0x2BD05C0", VA = "0x182BD1BC0")]
		internal DPMKTHRBQCZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class GWZXHUWPICG : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3870", Offset = "0x2BD2270", VA = "0x182BD3870")]
		internal GWZXHUWPICG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class ASBTQPUWUWL : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF730", Offset = "0x2BCE130", VA = "0x182BCF730")]
		internal ASBTQPUWUWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class HFARFKMPDNJ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4440", Offset = "0x2BD2E40", VA = "0x182BD4440")]
		internal HFARFKMPDNJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class HJZAZWMDEMV : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4690", Offset = "0x2BD3090", VA = "0x182BD4690")]
		internal HJZAZWMDEMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SANTXMZIMZN : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCA60", Offset = "0x2BDB460", VA = "0x182BDCA60")]
		internal SANTXMZIMZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class JFBCHNNLOTQ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7100", Offset = "0x2BD5B00", VA = "0x182BD7100")]
		internal JFBCHNNLOTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ULQQHOLRDOZ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDCB0", Offset = "0x2BDC6B0", VA = "0x182BDDCB0")]
		internal ULQQHOLRDOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class HEFMSASSHIF : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4260", Offset = "0x2BD2C60", VA = "0x182BD4260")]
		internal HEFMSASSHIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class MMCKXQHAVFC : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7CB0", Offset = "0x2BD66B0", VA = "0x182BD7CB0")]
		internal MMCKXQHAVFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class SIAFQJVLISF : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCC40", Offset = "0x2BDB640", VA = "0x182BDCC40")]
		internal SIAFQJVLISF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class PUWPSSXYXSM : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBA00", Offset = "0x2BDA400", VA = "0x182BDBA00")]
		internal PUWPSSXYXSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class PDFSBYBKZHJ : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA990", Offset = "0x2BD9390", VA = "0x182BDA990")]
		internal PDFSBYBKZHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class DUYFTGQONQF : GCPXVZKOYEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1DA0", Offset = "0x2BD07A0", VA = "0x182BD1DA0")]
		internal DUYFTGQONQF()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, WTBFSIOAEWL<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly CXXOCPTCXZR Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x10DE880", Offset = "0x10DD280", VA = "0x1810DE880")]
		private NamedType(string name, CXXOCPTCXZR type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E8E0", Offset = "0x2B0D2E0", VA = "0x182B0E8E0")]
		public static NamedType New(string name, CXXOCPTCXZR type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9A70", Offset = "0x2BD8470", VA = "0x182BD9A70")]
		public static bool OTUOIXXRZSY([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9A70", Offset = "0x2BD8470", VA = "0x182BD9A70", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9A70", Offset = "0x2BD8470", VA = "0x182BD9A70")]
		public bool JWGGIVUYRNA([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9AC0", Offset = "0x2BD84C0", VA = "0x182BD9AC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9B70", Offset = "0x2BD8570", VA = "0x182BD9B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9CA0", Offset = "0x2BD86A0", VA = "0x182BD9CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C60", Offset = "0x2BD8660", VA = "0x182BD9C60")]
		public string RFQKZPIWDIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9BE0", Offset = "0x2BD85E0", VA = "0x182BD9BE0")]
		public string NGSGJVQAJDW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9A70", Offset = "0x2BD8470", VA = "0x182BD9A70", Slot = "5")]
		private bool CNNFQMUZAXB([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface ISJHRHKEWBX
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(SYXPYTMUMKS a, bool b);
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
