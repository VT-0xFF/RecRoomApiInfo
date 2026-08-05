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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2B840", Offset = "0x2B2A640", VA = "0x182B2B840")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B21050", Offset = "0x2B1FE50", VA = "0x182B21050", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class DTRXAVCKOUF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E260", Offset = "0x2B1D060", VA = "0x182B1E260")]
		public static bool IPKCLPZNDNK(this JHOEKUEVGUO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E1A0", Offset = "0x2B1CFA0", VA = "0x182B1E1A0")]
		public static bool IPKCLPZNDNK(this MVGGWPNJIXX a)
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
			private readonly EGZVYBEHFSY _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
			public EVRequest(EGZVYBEHFSY staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class BDZZYOFVBRN
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<BBUEQYZOYHO>, YHOAIHVVABL> RPROJNPEZMY;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<BBUEQYZOYHO>>? NTRYCMCDPCI;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<BBUEQYZOYHO> JIHUOUDZXAK;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<BBUEQYZOYHO> GYTXDOCWIUL;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<BBUEQYZOYHO> EXVPVUKNTSK;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<BBUEQYZOYHO> GSWKPKTGQID;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<BBUEQYZOYHO> XQRZMQDYLQA;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<BBUEQYZOYHO> LAQWYUWVPUD;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<BBUEQYZOYHO> TLUASTMNNML;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<BBUEQYZOYHO> YEAPDUQXQPF;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<BBUEQYZOYHO> HKGELLMSZDZ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<BBUEQYZOYHO> ROMTKNQNYML;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<BBUEQYZOYHO> SQXYJABFHXV;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<BBUEQYZOYHO> YTDQITYBNPD;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<BBUEQYZOYHO> ZHEIVBBTGWA;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<BBUEQYZOYHO> ETQAZUEDMKQ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<BBUEQYZOYHO> MXLYWCJAVZQ;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<BBUEQYZOYHO> TNGZXDRASSV;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<BBUEQYZOYHO> OPOJJAKJPKY;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<BBUEQYZOYHO> YRZWOOIHIWK;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<BBUEQYZOYHO> VQSERSECPMZ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<BBUEQYZOYHO> SJDBOHJUWRM;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<BBUEQYZOYHO> UWLYASIWRUZ;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<BBUEQYZOYHO> WMCWBYIOCDI;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<BBUEQYZOYHO> PYPRTENSJOW;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<BBUEQYZOYHO> XZYZIJQJRRL;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<BBUEQYZOYHO> OMPNGHZASVL;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<BBUEQYZOYHO> AHUDVGFFNFG;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<BBUEQYZOYHO> TEAKSAKNZEX;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<BBUEQYZOYHO> XATMNNQNWCU;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<BBUEQYZOYHO> FSLRRSDOWKY;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<BBUEQYZOYHO> GKWFLQPAQKK;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<BBUEQYZOYHO> JKXGAUABQXC;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<BBUEQYZOYHO> MDHDOIUSBUF;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<BBUEQYZOYHO> PALNTTHKAHU;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<BBUEQYZOYHO> VGCQWBUHAVY;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<BBUEQYZOYHO> NYTNWRVZWVK;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<BBUEQYZOYHO> VVZSOCQIHHL;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<BBUEQYZOYHO> ABLBDDGFPLA;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<BBUEQYZOYHO> MQVXPOHLXAP;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<BBUEQYZOYHO> PZIUIRXJORR;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<BBUEQYZOYHO> RKYYZPHGRGJ;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<BBUEQYZOYHO> TBUIYZUOALI;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<BBUEQYZOYHO> HINGINDQXKS;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<BBUEQYZOYHO> ULJYRGJWAPJ;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<BBUEQYZOYHO> NWYASTUAXYO;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<BBUEQYZOYHO> AEDDNPJVSAM;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<BBUEQYZOYHO> ZKTYXCEVMSW;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<BBUEQYZOYHO> SNLRQKNGBVB;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<BBUEQYZOYHO> PUGVCSGPJBF;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<BBUEQYZOYHO> BFWQAPRKZMH;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<BBUEQYZOYHO> IRJLCNGIZZE;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<BBUEQYZOYHO> MGTJEYTDBMG;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<BBUEQYZOYHO> KIQBBIGRZTN;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<BBUEQYZOYHO> PEINLGMDZXC;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<BBUEQYZOYHO> AGJUNNTNUKG;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<BBUEQYZOYHO> NUQGLOUUDEV;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<BBUEQYZOYHO> NWNGNOTZFSF;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<BBUEQYZOYHO> FDLJQJRWZMZ;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<BBUEQYZOYHO> MTWYHOCHADX;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<BBUEQYZOYHO> HHHEWPVXTTO;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<BBUEQYZOYHO> TWMFJMDOAHR;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<BBUEQYZOYHO> WSHRGXWBCND;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<BBUEQYZOYHO> GJCVYTQXLYT;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<BBUEQYZOYHO> OVGANUKOOYQ;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<BBUEQYZOYHO> FQJLYVIKDFY;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<BBUEQYZOYHO> PJEBDJCVXKV;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<BBUEQYZOYHO> KVPQQMTBTUG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<BBUEQYZOYHO>, YHOAIHVVABL> XYVMATLYZIX
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2B19510", Offset = "0x2B18310", VA = "0x182B19510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2B197C0", Offset = "0x2B185C0", VA = "0x182B197C0")]
			public static YHOAIHVVABL QCJVHFSYDAJ(Id32<BBUEQYZOYHO> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B19840", Offset = "0x2B18640", VA = "0x182B19840")]
			public static bool RKWJXDODFYG(Id32<BBUEQYZOYHO> id, [Out] YHOAIHVVABL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B198D0", Offset = "0x2B186D0", VA = "0x182B198D0")]
			public static JHOEKUEVGUO VWBMUYWMTCQ(Id32<BBUEQYZOYHO> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B19730", Offset = "0x2B18530", VA = "0x182B19730")]
			private static Id32<BBUEQYZOYHO> PUOFOOQAOVA(YHOAIHVVABL a, Id32<BBUEQYZOYHO> id)
			{
				return default(Id32<BBUEQYZOYHO>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B19560", Offset = "0x2B18360", VA = "0x182B19560")]
			private static void HSNWPLKERGQ(Id32<BBUEQYZOYHO> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class MNTNZFUKCJG
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				private IdUnsafeList<OUFJYXOYDZY, JHOEKUEVGUO?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x12B3B90", Offset = "0x12B2990", VA = "0x1812B3B90")]
				private TypeRegistryFactory([In] IdUnsafeList<OUFJYXOYDZY, JHOEKUEVGUO?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B35C40", Offset = "0x2B34A40", VA = "0x182B35C40")]
				public static TypeRegistryFactory FXMFIGIXULC()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B35E70", Offset = "0x2B34C70", VA = "0x182B35E70")]
				public (ReadOnlyIdArray<OUFJYXOYDZY, JHOEKUEVGUO>, IReadOnlyDictionary<JHOEKUEVGUO, Id32<OUFJYXOYDZY>>) WSFNWRHTUQM()
				{
					return default((ReadOnlyIdArray<OUFJYXOYDZY, JHOEKUEVGUO>, IReadOnlyDictionary<JHOEKUEVGUO, Id32<OUFJYXOYDZY>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B35CA0", Offset = "0x2B34AA0", VA = "0x182B35CA0")]
				public Id32<OUFJYXOYDZY> IXJMZGWWQQC(int a, JHOEKUEVGUO b)
				{
					return default(Id32<OUFJYXOYDZY>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B35E20", Offset = "0x2B34C20", VA = "0x182B35E20")]
				public Id32<OUFJYXOYDZY> Initialize(int id, HWVCIXNUHHP type, HWVCIXNUHHP factoryType)
				{
					return default(Id32<OUFJYXOYDZY>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class TITHHEFJATF
			{
				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Id32<OUFJYXOYDZY> PRWQMLBCZMI
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x2B35180", Offset = "0x2B33F80", VA = "0x182B35180")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x2B35340", Offset = "0x2B34140", VA = "0x182B35340")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Id32<OUFJYXOYDZY> FZNUDDBRAPA
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x2B35300", Offset = "0x2B34100", VA = "0x182B35300")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x2B35380", Offset = "0x2B34180", VA = "0x182B35380")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Id32<OUFJYXOYDZY> MLWHBTZYXJP
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2B351C0", Offset = "0x2B33FC0", VA = "0x182B351C0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2B352C0", Offset = "0x2B340C0", VA = "0x182B352C0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Id32<OUFJYXOYDZY> PLDHUBOETIB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2B35140", Offset = "0x2B33F40", VA = "0x182B35140")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2B35200", Offset = "0x2B34000", VA = "0x182B35200")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<OUFJYXOYDZY> OBCOOAPCQZL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2B353C0", Offset = "0x2B341C0", VA = "0x182B353C0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2B35240", Offset = "0x2B34040", VA = "0x182B35240")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<OUFJYXOYDZY> WYMCQJCGTLK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2B35100", Offset = "0x2B33F00", VA = "0x182B35100")]
					[CompilerGenerated]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2B35280", Offset = "0x2B34080", VA = "0x182B35280")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class OFNLLTTMRWF : IEnumerable<JHOEKUEVGUO>, IEnumerable, IEnumerator<JHOEKUEVGUO>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private JHOEKUEVGUO QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				private int DQRPPGNAYPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				private bool AVALHWGDRMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public bool VQRIMLHSRFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private RoomVersion EEPTRFTKZXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public RoomVersion QTLDWCMBFBX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private bool HWVKTAOZJJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public bool NWUVYHMFWUO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private bool MIYWYYYQHDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public bool RXWNUSBYQXU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private bool GICGRWJUPVN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public bool VCXIRITKHQO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private bool UZRTGQMHEEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public bool SITQICMYNUU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				private IEnumerator<JHOEKUEVGUO> ZQJSAWQBUYL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private JHOEKUEVGUO RMKMKLRDNGA;

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				private JHOEKUEVGUO MQVSEACCQGN
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
				[DebuggerHidden]
				public OFNLLTTMRWF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B900", Offset = "0x2B2A700", VA = "0x182B2B900", Slot = "7")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B9E0", Offset = "0x2B2A7E0", VA = "0x182B2B9E0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B990", Offset = "0x2B2A790", VA = "0x182B2B990")]
				private void LKISUJFCFYE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B8C0", Offset = "0x2B2A6C0", VA = "0x182B2B8C0", Slot = "10")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BDD0", Offset = "0x2B2ABD0", VA = "0x182B2BDD0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<JHOEKUEVGUO> XUSMGWKGLSC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B2BDD0", Offset = "0x2B2ABD0", VA = "0x182B2BDD0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UYQUPSIMXFE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class RMCCDMMBSCD : IEnumerable<JHOEKUEVGUO>, IEnumerable, IEnumerator<JHOEKUEVGUO>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private JHOEKUEVGUO QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				private int DQRPPGNAYPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private RoomVersion EEPTRFTKZXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public RoomVersion QTLDWCMBFBX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private bool MIYWYYYQHDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public bool RXWNUSBYQXU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private bool HWVKTAOZJJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public bool NWUVYHMFWUO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private bool PDRRQVBWBBV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				public bool YOITUHABWOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				private bool GICGRWJUPVN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public bool VCXIRITKHQO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				private bool ZABMWWCJLUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool ESABIPJBWKT;

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				private JHOEKUEVGUO MQVSEACCQGN
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
				[DebuggerHidden]
				public RMCCDMMBSCD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B32DD0", Offset = "0x2B31BD0", VA = "0x182B32DD0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B32D90", Offset = "0x2B31B90", VA = "0x182B32D90", Slot = "10")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B34BD0", Offset = "0x2B339D0", VA = "0x182B34BD0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<JHOEKUEVGUO> XUSMGWKGLSC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B34BD0", Offset = "0x2B339D0", VA = "0x182B34BD0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UYQUPSIMXFE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class KFQXBAMLHLH : IEnumerable<Id32<OUFJYXOYDZY>>, IEnumerable, IEnumerator<Id32<OUFJYXOYDZY>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private Id32<OUFJYXOYDZY> QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				private int DQRPPGNAYPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private RoomVersion EEPTRFTKZXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public RoomVersion QTLDWCMBFBX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool HWVKTAOZJJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public bool NWUVYHMFWUO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private bool MIYWYYYQHDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public bool RXWNUSBYQXU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private bool GICGRWJUPVN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public bool VCXIRITKHQO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private bool UZRTGQMHEEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public bool SITQICMYNUU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private IEnumerator<JHOEKUEVGUO> ZQJSAWQBUYL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private IEnumerator<HWVCIXNUHHP> ZQOYYDJZEJU;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private Id32<OUFJYXOYDZY> XEWKDCLJPWC
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<OUFJYXOYDZY>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x2B20930", Offset = "0x2B1F730", VA = "0x182B20930", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x15A5740", Offset = "0x15A4540", VA = "0x1815A5740")]
				[DebuggerHidden]
				public KFQXBAMLHLH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B20190", Offset = "0x2B1EF90", VA = "0x182B20190", Slot = "7")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B20380", Offset = "0x2B1F180", VA = "0x182B20380", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B202E0", Offset = "0x2B1F0E0", VA = "0x182B202E0")]
				private void LKISUJFCFYE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B20330", Offset = "0x2B1F130", VA = "0x182B20330")]
				private void LKYNMDMUIGF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B20150", Offset = "0x2B1EF50", VA = "0x182B20150", Slot = "10")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B20880", Offset = "0x2B1F680", VA = "0x182B20880", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<OUFJYXOYDZY>> VZNHCOJVROJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B20880", Offset = "0x2B1F680", VA = "0x182B20880", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UYQUPSIMXFE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private static readonly Log IRJSVORGEBN;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private static ReadOnlyIdArray<OUFJYXOYDZY, JHOEKUEVGUO?> CCWVVCZSAVB;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private static IReadOnlyDictionary<JHOEKUEVGUO, Id32<OUFJYXOYDZY>> POCAYEMPOHB;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MVGGWPNJIXX WAVCNSUWRXE;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MVGGWPNJIXX HJXZNDBUMUU;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private static readonly HashSet<JHOEKUEVGUO> SRMRFCYCAKS;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static List<JHOEKUEVGUO> PDSPWRHSDUJ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet QMIRZLUMQXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet WTRJQMOHDDC
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet QGWCBBGJLWY
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static JHOEKUEVGUO PRWQMLBCZMI
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2B21B70", Offset = "0x2B20970", VA = "0x182B21B70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static JHOEKUEVGUO FZNUDDBRAPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2B23DA0", Offset = "0x2B22BA0", VA = "0x182B23DA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static JHOEKUEVGUO MLWHBTZYXJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2B21C00", Offset = "0x2B20A00", VA = "0x182B21C00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static JHOEKUEVGUO PLDHUBOETIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2B21900", Offset = "0x2B20700", VA = "0x182B21900")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static JHOEKUEVGUO DWTUKBMVKSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2B21450", Offset = "0x2B20250", VA = "0x182B21450")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static JHOEKUEVGUO CTZMNRFJHFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2B239F0", Offset = "0x2B227F0", VA = "0x182B239F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static JHOEKUEVGUO BGUUNJPXVRF
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2B226A0", Offset = "0x2B214A0", VA = "0x182B226A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static JHOEKUEVGUO OBCOOAPCQZL
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2B248F0", Offset = "0x2B236F0", VA = "0x182B248F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static HWVCIXNUHHP JGIITGWIHHR
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2B23080", Offset = "0x2B21E80", VA = "0x182B23080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static HWVCIXNUHHP OOFJZETWVKY
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2B23B20", Offset = "0x2B22920", VA = "0x182B23B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static HWVCIXNUHHP ICSKDZTCFNR
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2B230D0", Offset = "0x2B21ED0", VA = "0x182B230D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static HWVCIXNUHHP RHXTAFTYKYD
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2B22350", Offset = "0x2B21150", VA = "0x182B22350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static HWVCIXNUHHP MIOAGKSKRRB
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2B24540", Offset = "0x2B23340", VA = "0x182B24540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static HWVCIXNUHHP NQAFDQMUINS
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2B218B0", Offset = "0x2B206B0", VA = "0x182B218B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static HWVCIXNUHHP AOMFHVBRNEK
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2B22C70", Offset = "0x2B21A70", VA = "0x182B22C70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static HWVCIXNUHHP YEGFLCPKDLS
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2B23170", Offset = "0x2B21F70", VA = "0x182B23170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static HWVCIXNUHHP EENYKKXRUUT
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2B21720", Offset = "0x2B20520", VA = "0x182B21720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static HWVCIXNUHHP GPAOBAMDHKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2B223A0", Offset = "0x2B211A0", VA = "0x182B223A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static HWVCIXNUHHP CBNTHWXTADS
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2B23C10", Offset = "0x2B22A10", VA = "0x182B23C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static HWVCIXNUHHP WDSAVABEIMY
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2B237C0", Offset = "0x2B225C0", VA = "0x182B237C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static HWVCIXNUHHP JASFLEVAGEW
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2B210D0", Offset = "0x2B1FED0", VA = "0x182B210D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static HWVCIXNUHHP HCMRODPXIDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2B22510", Offset = "0x2B21310", VA = "0x182B22510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static HWVCIXNUHHP AZZNFZPNODP
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2B24BB0", Offset = "0x2B239B0", VA = "0x182B24BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static HWVCIXNUHHP BMCIKNANSNI
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2B215E0", Offset = "0x2B203E0", VA = "0x182B215E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static HWVCIXNUHHP HENJOWQVKGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2B238B0", Offset = "0x2B226B0", VA = "0x182B238B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static HWVCIXNUHHP WCSVVEWHFGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2B24B60", Offset = "0x2B23960", VA = "0x182B24B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static HWVCIXNUHHP ZXSVHAQTNES
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2B22E50", Offset = "0x2B21C50", VA = "0x182B22E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static HWVCIXNUHHP TOHALEYAWVV
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2B211F0", Offset = "0x2B1FFF0", VA = "0x182B211F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static HWVCIXNUHHP HZKOLOVEZJA
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2B22DB0", Offset = "0x2B21BB0", VA = "0x182B22DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static HWVCIXNUHHP RLOFKLKZLAQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2B22560", Offset = "0x2B21360", VA = "0x182B22560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static HWVCIXNUHHP IMQGKROMBQM
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2B22BD0", Offset = "0x2B219D0", VA = "0x182B22BD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static HWVCIXNUHHP COMJGHPNPOY
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B214E0", Offset = "0x2B202E0", VA = "0x182B214E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static HWVCIXNUHHP QSMANGSHDJF
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B23860", Offset = "0x2B22660", VA = "0x182B23860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static HWVCIXNUHHP EQYBDDDXKQC
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2B22A50", Offset = "0x2B21850", VA = "0x182B22A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static HWVCIXNUHHP IFJIOKGJGTM
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2B23680", Offset = "0x2B22480", VA = "0x182B23680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static HWVCIXNUHHP CDUOKWPOPZW
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2B23120", Offset = "0x2B21F20", VA = "0x182B23120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static HWVCIXNUHHP LFJAYRALKON
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2B23260", Offset = "0x2B22060", VA = "0x182B23260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static HWVCIXNUHHP SZOGYNTWSPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2B22AA0", Offset = "0x2B218A0", VA = "0x182B22AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static HWVCIXNUHHP IZGCFKCUKLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2B23630", Offset = "0x2B22430", VA = "0x182B23630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static HWVCIXNUHHP IITVWXOHQRZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2B21400", Offset = "0x2B20200", VA = "0x182B21400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static HWVCIXNUHHP OOVIWFRFNEY
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2B225B0", Offset = "0x2B213B0", VA = "0x182B225B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static HWVCIXNUHHP BFCOORFMOFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2B246C0", Offset = "0x2B234C0", VA = "0x182B246C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static HWVCIXNUHHP QNRDREQCTZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2B23900", Offset = "0x2B22700", VA = "0x182B23900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static HWVCIXNUHHP QUABXBNKSLR
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2B23720", Offset = "0x2B22520", VA = "0x182B23720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static HWVCIXNUHHP MMTMHARTXTY
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2B22F90", Offset = "0x2B21D90", VA = "0x182B22F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static HWVCIXNUHHP XKHUHQXSJDC
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2B248A0", Offset = "0x2B236A0", VA = "0x182B248A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static HWVCIXNUHHP ZGRVELTAFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2B23CB0", Offset = "0x2B22AB0", VA = "0x182B23CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static HWVCIXNUHHP GXHZJLDFHHD
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2B22A00", Offset = "0x2B21800", VA = "0x182B22A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static HWVCIXNUHHP TXMQLKCHLEB
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2B21D80", Offset = "0x2B20B80", VA = "0x182B21D80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static HWVCIXNUHHP IXWBPKTOYNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2B24850", Offset = "0x2B23650", VA = "0x182B24850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static HWVCIXNUHHP ARANGFLGMRS
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2B221B0", Offset = "0x2B20FB0", VA = "0x182B221B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static HWVCIXNUHHP EBBIPJHLIKY
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2B211A0", Offset = "0x2B1FFA0", VA = "0x182B211A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static HWVCIXNUHHP RRBBWCDUNKL
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2B249D0", Offset = "0x2B237D0", VA = "0x182B249D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static HWVCIXNUHHP MNKHVBXZFLL
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2B22160", Offset = "0x2B20F60", VA = "0x182B22160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static HWVCIXNUHHP SQXNTVWQCCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2B21630", Offset = "0x2B20430", VA = "0x182B21630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static HWVCIXNUHHP MJXDPPEYCHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2B22EA0", Offset = "0x2B21CA0", VA = "0x182B22EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static HWVCIXNUHHP SEETPDRLLLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2B24300", Offset = "0x2B23100", VA = "0x182B24300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static HWVCIXNUHHP RDSPQMPUFZR
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2B23B70", Offset = "0x2B22970", VA = "0x182B23B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static HWVCIXNUHHP HZEDCBSGDGV
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2B213B0", Offset = "0x2B201B0", VA = "0x182B213B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static HWVCIXNUHHP DPMGOOUMQHI
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2B22CC0", Offset = "0x2B21AC0", VA = "0x182B22CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static HWVCIXNUHHP PWQEZHGNTTH
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2B24C50", Offset = "0x2B23A50", VA = "0x182B24C50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static HWVCIXNUHHP ZOCERMOXSQU
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2B22300", Offset = "0x2B21100", VA = "0x182B22300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static HWVCIXNUHHP ZRZAMUNFZAQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2B22200", Offset = "0x2B21000", VA = "0x182B22200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static HWVCIXNUHHP FWGMRUYQFWC
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2B22E00", Offset = "0x2B21C00", VA = "0x182B22E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static HWVCIXNUHHP EHZJSUEYSXE
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2B24AC0", Offset = "0x2B238C0", VA = "0x182B24AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static HWVCIXNUHHP RPFQEYWXOFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2B21310", Offset = "0x2B20110", VA = "0x182B21310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static HWVCIXNUHHP PGLTJNEBRTY
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2B23D50", Offset = "0x2B22B50", VA = "0x182B23D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static HWVCIXNUHHP HLHCOPSFZRF
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2B22F40", Offset = "0x2B21D40", VA = "0x182B22F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static HWVCIXNUHHP ZQVNHJQLACD
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2B21A80", Offset = "0x2B20880", VA = "0x182B21A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static HWVCIXNUHHP UBTTFCUGBIY
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2B23810", Offset = "0x2B22610", VA = "0x182B23810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static HWVCIXNUHHP HCPHJWXGAYB
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2B21AD0", Offset = "0x2B208D0", VA = "0x182B21AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static HWVCIXNUHHP CAQFDVRXAQJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2B212C0", Offset = "0x2B200C0", VA = "0x182B212C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static HWVCIXNUHHP APEHZLBTPQM
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2B24800", Offset = "0x2B23600", VA = "0x182B24800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static HWVCIXNUHHP JFQDFJSBBHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2B239A0", Offset = "0x2B227A0", VA = "0x182B239A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static HWVCIXNUHHP ELQBSUYXDRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2B23F20", Offset = "0x2B22D20", VA = "0x182B23F20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static HWVCIXNUHHP MXTYXNSWSQV
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2B217C0", Offset = "0x2B205C0", VA = "0x182B217C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static HWVCIXNUHHP SLNNRMJKKCP
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2B23210", Offset = "0x2B22010", VA = "0x182B23210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static HWVCIXNUHHP VJMKRKHRLQP
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2B21810", Offset = "0x2B20610", VA = "0x182B21810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static HWVCIXNUHHP BOKTYIOHDZK
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2B21680", Offset = "0x2B20480", VA = "0x182B21680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static HWVCIXNUHHP ICUJSXJREEH
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2B21770", Offset = "0x2B20570", VA = "0x182B21770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static HWVCIXNUHHP BXMWBSNIYTB
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2B24350", Offset = "0x2B23150", VA = "0x182B24350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static HWVCIXNUHHP TRFIQHAEILU
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2B21D30", Offset = "0x2B20B30", VA = "0x182B21D30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static HWVCIXNUHHP QGRHXFXLBUO
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2B23E30", Offset = "0x2B22C30", VA = "0x182B23E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static HWVCIXNUHHP NRQHSCUOAUJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2B22440", Offset = "0x2B21240", VA = "0x182B22440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static HWVCIXNUHHP FJQDGDWTETG
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2B22D60", Offset = "0x2B21B60", VA = "0x182B22D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static HWVCIXNUHHP VWMXQJTOPMQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2B21360", Offset = "0x2B20160", VA = "0x182B21360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static HWVCIXNUHHP DANBBCABATF
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2B22C20", Offset = "0x2B21A20", VA = "0x182B22C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static HWVCIXNUHHP PQFNFRCRFTH
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2B22FE0", Offset = "0x2B21DE0", VA = "0x182B22FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static HWVCIXNUHHP PQUDQWPULZW
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2B23770", Offset = "0x2B22570", VA = "0x182B23770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static HWVCIXNUHHP EQOVKWBCLEZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2B23BC0", Offset = "0x2B229C0", VA = "0x182B23BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static HWVCIXNUHHP OVYYKNFLEZE
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2B236D0", Offset = "0x2B224D0", VA = "0x182B236D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static HWVCIXNUHHP JVHNCKSJMXA
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2B24980", Offset = "0x2B23780", VA = "0x182B24980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static HWVCIXNUHHP KROSJQECTGM
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2B23D00", Offset = "0x2B22B00", VA = "0x182B23D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static HWVCIXNUHHP NJCYLDKVPGQ
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2B23ED0", Offset = "0x2B22CD0", VA = "0x182B23ED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static HWVCIXNUHHP BTQAVYURLYK
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2B24A70", Offset = "0x2B23870", VA = "0x182B24A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static HWVCIXNUHHP GSBCSVETAPL
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2B21A30", Offset = "0x2B20830", VA = "0x182B21A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static HWVCIXNUHHP REKIHKPYVUW
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2B21CE0", Offset = "0x2B20AE0", VA = "0x182B21CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static HWVCIXNUHHP TVEHZPOHPJZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2B24710", Offset = "0x2B23510", VA = "0x182B24710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static HWVCIXNUHHP HKSXXVYGXWE
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2B21B20", Offset = "0x2B20920", VA = "0x182B21B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static HWVCIXNUHHP RASASIZGVYD
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2B23C60", Offset = "0x2B22A60", VA = "0x182B23C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static HWVCIXNUHHP VXVZNRVBOBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2B23950", Offset = "0x2B22750", VA = "0x182B23950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static HWVCIXNUHHP WRZAIJHDLJX
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2B231C0", Offset = "0x2B21FC0", VA = "0x182B231C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static HWVCIXNUHHP XARAGEHEQKD
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2B21C90", Offset = "0x2B20A90", VA = "0x182B21C90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static HWVCIXNUHHP JDBMAKYDBBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2B216D0", Offset = "0x2B204D0", VA = "0x182B216D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static HWVCIXNUHHP UNQMDCHIMWX
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2B22600", Offset = "0x2B21400", VA = "0x182B22600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static HWVCIXNUHHP JKLGKRUVUNS
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2B23A80", Offset = "0x2B22880", VA = "0x182B23A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static HWVCIXNUHHP PGURHEHLUZE
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2B24A20", Offset = "0x2B23820", VA = "0x182B24A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static HWVCIXNUHHP PWVSPIHNWNQ
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2B24B10", Offset = "0x2B23910", VA = "0x182B24B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static HWVCIXNUHHP WPLIFQGCQTV
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2B22650", Offset = "0x2B21450", VA = "0x182B22650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static HWVCIXNUHHP KWUVKULKCDA
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2B21860", Offset = "0x2B20660", VA = "0x182B21860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static HWVCIXNUHHP PVUEIGPOPCS
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2B24C00", Offset = "0x2B23A00", VA = "0x182B24C00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static HWVCIXNUHHP URXPMLMCYFN
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2B220A0", Offset = "0x2B20EA0", VA = "0x182B220A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static HWVCIXNUHHP ELNLPWHOOHA
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2B219E0", Offset = "0x2B207E0", VA = "0x182B219E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static HWVCIXNUHHP FIZSMHBORNT
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2B24760", Offset = "0x2B23560", VA = "0x182B24760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static HWVCIXNUHHP QPIQUOOOBXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2B21240", Offset = "0x2B20040", VA = "0x182B21240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static HWVCIXNUHHP MYIFMTZKKUS
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2B23030", Offset = "0x2B21E30", VA = "0x182B23030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static HWVCIXNUHHP TYXGSWITQWZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2B22EF0", Offset = "0x2B21CF0", VA = "0x182B22EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static HWVCIXNUHHP SDGNKIIJBIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2B21990", Offset = "0x2B20790", VA = "0x182B21990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static HWVCIXNUHHP TRFJEWHXOVG
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2B223F0", Offset = "0x2B211F0", VA = "0x182B223F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static HWVCIXNUHHP RDDFMGYSSCH
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2B23AD0", Offset = "0x2B228D0", VA = "0x182B23AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static HWVCIXNUHHP PKYMAMWZPBX
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2B22D10", Offset = "0x2B21B10", VA = "0x182B22D10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static HWVCIXNUHHP EHKVCACAKWQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2B247B0", Offset = "0x2B235B0", VA = "0x182B247B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static HWVCIXNUHHP AJDVOZMMOIW
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2B23E80", Offset = "0x2B22C80", VA = "0x182B23E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B243A0", Offset = "0x2B231A0", VA = "0x182B243A0")]
			public static MVGGWPNJIXX WCYDXHOAEGF([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2B22AF0", Offset = "0x2B218F0", VA = "0x182B22AF0")]
			public static ClassFactoryTypeParams MTFLNUTMRKM(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B22BA0", Offset = "0x2B219A0", VA = "0x182B22BA0")]
			public static ClassFactoryTypeParams MTFLNUTMRKM([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B21290", Offset = "0x2B20090", VA = "0x182B21290")]
			public static MVGGWPNJIXX BJBHZVXAIWP(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B22070", Offset = "0x2B20E70", VA = "0x182B22070")]
			public static MVGGWPNJIXX HPPFUMWMEDM(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B24590", Offset = "0x2B23390", VA = "0x182B24590")]
			public static MVGGWPNJIXX WYMCQJCGTLK([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F70", Offset = "0x2B22D70", VA = "0x182B23F70")]
			public static JHOEKUEVGUO VWBMUYWMTCQ(Id32<OUFJYXOYDZY> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2B22490", Offset = "0x2B21290", VA = "0x182B22490")]
			public static string KREUJFGKBIP(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B24020", Offset = "0x2B22E20", VA = "0x182B24020")]
			private static JHOEKUEVGUO VWBMUYWMTCQ(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2B220F0", Offset = "0x2B20EF0", VA = "0x182B220F0")]
			public static Id32<OUFJYXOYDZY>? ICULDMKJFJT(JHOEKUEVGUO a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B232B0", Offset = "0x2B220B0", VA = "0x182B232B0")]
			public static CircuitTypeIdWrapper? QMTFDCALIXC(JHOEKUEVGUO a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B24CA0", Offset = "0x2B23AA0", VA = "0x182B24CA0")]
			static MNTNZFUKCJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B21530", Offset = "0x2B20330", VA = "0x182B21530")]
			[IteratorStateMachine(typeof(RMCCDMMBSCD))]
			private static IEnumerable<JHOEKUEVGUO> BXRDWNRNVVO(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B22250", Offset = "0x2B21050", VA = "0x182B22250")]
			[IteratorStateMachine(typeof(OFNLLTTMRWF))]
			public static IEnumerable<JHOEKUEVGUO> IZGYFYDUINX(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B21DD0", Offset = "0x2B20BD0", VA = "0x182B21DD0")]
			public static Variant GRXHXYROYAC(JHOEKUEVGUO a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B22730", Offset = "0x2B21530", VA = "0x182B22730")]
			public static Variant MDDNHDBUPRR(JHOEKUEVGUO a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B21120", Offset = "0x2B1FF20", VA = "0x182B21120")]
			public static bool AUTXXORZTMB(JHOEKUEVGUO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B24490", Offset = "0x2B23290", VA = "0x182B24490")]
			[IteratorStateMachine(typeof(KFQXBAMLHLH))]
			public static IEnumerable<Id32<OUFJYXOYDZY>> WJQYYDDPFIH(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class VJIEOGAUDSP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B37210", Offset = "0x2B36010", VA = "0x182B37210")]
		public static AQQBPFEVNHE VVUFAYMMXPR(this JHOEKUEVGUO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B36700", Offset = "0x2B35500", VA = "0x182B36700")]
		public static JHOEKUEVGUO ICWCLXYJQOW(this AQQBPFEVNHE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JXNVYZQGGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x39B5D30", Offset = "0x39B4B30", VA = "0x1839B5D30")]
		public static Dictionary<b, c> WGSNLFXDQIW<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class CQMVLREUZEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C6B0", Offset = "0x2B1B4B0", VA = "0x182B1C6B0")]
		public static MNOXOQINDJE VVUFAYMMXPR([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C610", Offset = "0x2B1B410", VA = "0x182B1C610")]
		public static Guid ICWCLXYJQOW(MNOXOQINDJE a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class LFGTJKIXMZL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B20FC0", Offset = "0x2B1FDC0", VA = "0x182B20FC0")]
		public static DQVQARJTTEE VVUFAYMMXPR([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B20F60", Offset = "0x2B1FD60", VA = "0x182B20F60")]
		public static NamedType ICWCLXYJQOW(this DQVQARJTTEE a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GEIHLTAFOTA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x39035E0", Offset = "0x39023E0", VA = "0x1839035E0")]
		public static void EYOPCBCCNOE<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3903850", Offset = "0x3902650", VA = "0x183903850")]
		public static void EYOPCBCCNOE<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class KFQYEWTOXTT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B20AD0", Offset = "0x2B1F8D0", VA = "0x182B20AD0")]
		public static DQQXBQWUGBO VVUFAYMMXPR([In] this Variant self, JHOEKUEVGUO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B20980", Offset = "0x2B1F780", VA = "0x182B20980")]
		public static Variant ICWCLXYJQOW(this DQQXBQWUGBO a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HUBXKRXHWXN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Id128<YEXWNLUZCTT> VRXOEZOKJWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public readonly bool TRIHCBAZYKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public readonly bool HVUMVZLLWJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly bool KDDJUYXUWBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public readonly bool CWIGSETRXHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public readonly bool CWNNPLNPGSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public readonly bool GGOUCXNDSBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public readonly bool UGNFQFXBQRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool CFSBKURBKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly List<(string Name, JHOEKUEVGUO Type)> VPLVJSKJWGJ;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[WillBeRenamedTo("LegacyId")]
		public Guid QXVQSTMOTBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2AE17A0", Offset = "0x2AE05A0", VA = "0x182AE17A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Id128<YEXWNLUZCTT> FSWUQMPWYIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2AE17A0", Offset = "0x2AE05A0", VA = "0x182AE17A0")]
			get
			{
				return default(Id128<YEXWNLUZCTT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public IReadOnlyList<(string Name, JHOEKUEVGUO Type)> FKRPSHOZXKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action RIHNRRLBMLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FDC0", Offset = "0x2B1EBC0", VA = "0x182B1FDC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F790", Offset = "0x2B1E590", VA = "0x182B1F790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, JHOEKUEVGUO> HHVZNEOHZLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FC60", Offset = "0x2B1EA60", VA = "0x182B1FC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F0A0", Offset = "0x2B1DEA0", VA = "0x182B1F0A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> UKRUROBKPKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F8E0", Offset = "0x2B1E6E0", VA = "0x182B1F8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B1EEF0", Offset = "0x2B1DCF0", VA = "0x182B1EEF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> SUVBOQDUFZP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F830", Offset = "0x2B1E630", VA = "0x182B1F830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F1B0", Offset = "0x2B1DFB0", VA = "0x182B1F1B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, JHOEKUEVGUO> NRGTVSLJJKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FD10", Offset = "0x2B1EB10", VA = "0x182B1FD10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B1F6E0", Offset = "0x2B1E4E0", VA = "0x182B1F6E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action BLKNGSCIJQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FBC0", Offset = "0x2B1E9C0", VA = "0x182B1FBC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B1FAB0", Offset = "0x2B1E8B0", VA = "0x182B1FAB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x18EE9F0", Offset = "0x18ED7F0", VA = "0x1818EE9F0")]
		public void RIMKUJHPXFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B20060", Offset = "0x2B1EE60", VA = "0x182B20060")]
		internal HUBXKRXHWXN([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, JHOEKUEVGUO Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F4A0", Offset = "0x2B1E2A0", VA = "0x182B1F4A0")]
		public static CircuitEventDefinitionFactoryStart FXMFIGIXULC(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F570", Offset = "0x2B1E370", VA = "0x182B1F570")]
		public static CircuitEventDefinitionFactoryStart FXMFIGIXULC(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FF50", Offset = "0x2B1ED50", VA = "0x182B1FF50")]
		public static HUBXKRXHWXN YKBVLQHYAXW([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F260", Offset = "0x2B1E060", VA = "0x182B1F260")]
		public static HUBXKRXHWXN FTDDNQLDBEC([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
		public void HZOJXJCFCFI(Id128<YEXWNLUZCTT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F150", Offset = "0x2B1DF50", VA = "0x182B1F150")]
		public void ERFRANGLXTT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F5F0", Offset = "0x2B1E3F0", VA = "0x182B1F5F0")]
		public void ICVGTSGLEEF(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FE60", Offset = "0x2B1EC60", VA = "0x182B1FE60")]
		public void YJPFAKRERQS(int a, JHOEKUEVGUO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F990", Offset = "0x2B1E790", VA = "0x182B1F990")]
		public void PEJMMMTPNEW(string a, JHOEKUEVGUO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FB50", Offset = "0x2B1E950", VA = "0x182B1FB50")]
		public void TINHZRDVBYD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EFA0", Offset = "0x2B1DDA0", VA = "0x182B1EFA0")]
		public HUBXKRXHWXN Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2B1CD10", Offset = "0x2B1BB10", VA = "0x182B1CD10")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CA70", Offset = "0x2B1B870", VA = "0x182B1CA70")]
		public CircuitEventDefinitionFactoryParams TFMPPKRCQMM(string a, JHOEKUEVGUO b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CBE0", Offset = "0x2B1B9E0", VA = "0x182B1CBE0")]
		public HUBXKRXHWXN WSFNWRHTUQM()
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
		private readonly List<(string Name, JHOEKUEVGUO Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C9E0", Offset = "0x2B1B7E0", VA = "0x182B1C9E0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, JHOEKUEVGUO Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C7B0", Offset = "0x2B1B5B0", VA = "0x182B1C7B0")]
		public CircuitEventDefinitionFactoryParams TFMPPKRCQMM(string a, JHOEKUEVGUO b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C8E0", Offset = "0x2B1B6E0", VA = "0x182B1C8E0")]
		public HUBXKRXHWXN WSFNWRHTUQM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class QTMTWXFUXXO
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public static readonly HUBXKRXHWXN NPIUAQCAHMF;

			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly HUBXKRXHWXN QDWJRXIYHUS;

			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly HUBXKRXHWXN EBNPGSFDBBP;

			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly HUBXKRXHWXN POHNZGJCAGC;

			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public static readonly HUBXKRXHWXN ZQQDLSKOUHT;

			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public static readonly HUBXKRXHWXN WFIHLRVWZXD;

			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly HUBXKRXHWXN BDHPMASRGJM;

			[Cpp2IlInjected.Token(Token = "0x4000136")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			internal static readonly HUBXKRXHWXN[] VKRSYIFJYMP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class GYTXDOCWIUL
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly HUBXKRXHWXN CAUTJSLALSJ;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class EXVPVUKNTSK
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly HUBXKRXHWXN JQNPSWYXQBR;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly HUBXKRXHWXN YQXKJZPZYYI;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class GJCVYTQXLYT
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly HUBXKRXHWXN PQEKSFHDXEI;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly HUBXKRXHWXN LKOPUVJODMR;

			[Cpp2IlInjected.Token(Token = "0x400013F")]
			internal static readonly HUBXKRXHWXN[] RWSUALZBYJJ;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public static readonly HUBXKRXHWXN RLRURMECAQL;

			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly HUBXKRXHWXN ENKBQNVDOFI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class SNLRQKNGBVB
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly HUBXKRXHWXN EGKBLOQOLYO;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly HUBXKRXHWXN NYZTGHAXIKP;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class XQRZMQDYLQA
		{
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public static readonly HUBXKRXHWXN NWRSHRPBSTZ;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly HUBXKRXHWXN WBDVLZDZGIC;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class LAQWYUWVPUD
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public static readonly HUBXKRXHWXN JQNPSWYXQBR;

			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly HUBXKRXHWXN YQXKJZPZYYI;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class TLUASTMNNML
		{
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public static readonly HUBXKRXHWXN UQJXSVNTZBM;

			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly HUBXKRXHWXN DMEHYVUPSKN;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly HUBXKRXHWXN IVUOZJUOSML;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public static readonly HUBXKRXHWXN JFRMAIZJGZJ;

			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly HUBXKRXHWXN SROVIHSKERO;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly HUBXKRXHWXN AFAZUGDQIEJ;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public static readonly HUBXKRXHWXN XDOXHTHNFOM;

			[Cpp2IlInjected.Token(Token = "0x4000153")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class YEAPDUQXQPF
		{
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class HKGELLMSZDZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class PZIUIRXJORR
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class ROMTKNQNYML
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly HUBXKRXHWXN MAPXDGQDILG;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly HUBXKRXHWXN RNKSBXLOJSN;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class NUQGLOUUDEV
		{
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class SQXYJABFHXV
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class YTDQITYBNPD
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class ZKTYXCEVMSW
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly HUBXKRXHWXN QMHSULCMNIU;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public static readonly HUBXKRXHWXN XGYJHTSFLHG;

			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public static readonly HUBXKRXHWXN IBIWJCPHVUF;

			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public static readonly HUBXKRXHWXN APWKRSHPJCW;

			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public static readonly HUBXKRXHWXN RJGBRDZJTLQ;

			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public static readonly HUBXKRXHWXN NWRSHRPBSTZ;

			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly HUBXKRXHWXN TFNIYBKFAYC;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public static readonly HUBXKRXHWXN QTZFWDTZPWD;

			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly HUBXKRXHWXN DKMHXVOFTNL;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly HUBXKRXHWXN BUAXWZQLNCX;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly HUBXKRXHWXN HGFTFMECGKV;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly HUBXKRXHWXN KGKKVLLOOBV;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly HUBXKRXHWXN JAAEZLRWSTG;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly HUBXKRXHWXN SADNQEZTGCB;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly HUBXKRXHWXN SACSZYJYPOE;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly HUBXKRXHWXN IYSVIXDYUCM;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly HUBXKRXHWXN FAOPWNDDEMG;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly HUBXKRXHWXN TAPWXWBEIXV;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly HUBXKRXHWXN ULDNVWLBILE;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly HUBXKRXHWXN BFRBHYCSAWI;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly HUBXKRXHWXN SOEPTSRJFFN;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly HUBXKRXHWXN OJNCKJUVDET;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly HUBXKRXHWXN SDRTXCBCKRF;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly HUBXKRXHWXN LTHHOEANHTZ;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly HUBXKRXHWXN BLHFVKUSVQR;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly HUBXKRXHWXN LCPLDSCBXCZ;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly HUBXKRXHWXN POOXVPJMESZ;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly HUBXKRXHWXN XGFBGSKAQMB;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly HUBXKRXHWXN AFAAKJBKSPG;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly HUBXKRXHWXN RVXECMZFCHO;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly HUBXKRXHWXN APQEXYSWASR;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly HUBXKRXHWXN KGYKGGAFCEZ;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly HUBXKRXHWXN XNRISGOIRBC;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly HUBXKRXHWXN YNGONPWFDBS;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly HUBXKRXHWXN TVPVCPQTIRO;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly HUBXKRXHWXN SVVOHYJVZTW;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly HUBXKRXHWXN AYOBLCUYWIY;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly HUBXKRXHWXN OOPLTRFUXTM;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly HUBXKRXHWXN EABLGLCPMBQ;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly HUBXKRXHWXN JMDUMADPOZY;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly HUBXKRXHWXN XKCKJUBNEYR;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly HUBXKRXHWXN HYFOAKZDATL;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly HUBXKRXHWXN IGAGADCYFHF;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly HUBXKRXHWXN JJKBBJQRXND;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly HUBXKRXHWXN JAYMLAYAIYP;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly HUBXKRXHWXN VZULGXQPDUL;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly HUBXKRXHWXN AENKBLDBSUR;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly HUBXKRXHWXN AHINILKNDKT;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly HUBXKRXHWXN AMNFFAGBJYJ;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly HUBXKRXHWXN IYSQJLTXQTB;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly HUBXKRXHWXN QYWDHOXGZMK;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly HUBXKRXHWXN XFBQMUAQJSR;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly HUBXKRXHWXN ZHQPAOXRECF;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly HUBXKRXHWXN WJWLCZFTWUF;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly HUBXKRXHWXN XCCYDEVXMKT;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly HUBXKRXHWXN OEMQZGTABMN;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly HUBXKRXHWXN YAONHPXFWXZ;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly HUBXKRXHWXN HUDBEXHBVVJ;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly HUBXKRXHWXN MGAZHNOXTZL;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly HUBXKRXHWXN DOMGCLMGPUX;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly HUBXKRXHWXN JROJJJIPSAF;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly HUBXKRXHWXN YLHKWVXRVFJ;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly HUBXKRXHWXN GWAPFIIMMUC;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly HUBXKRXHWXN EZECHUMVRQR;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly HUBXKRXHWXN REPAGPPHFWV;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly HUBXKRXHWXN WPUSJKOFLWM;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly HUBXKRXHWXN UFANCUWZXKA;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly HUBXKRXHWXN IJSBTDNPAST;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly HUBXKRXHWXN KKHYGOXVIZZ;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class ETQAZUEDMKQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class VCJYVROYRBX
		{
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly HUBXKRXHWXN WESHILGMYKD;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly HUBXKRXHWXN DKWJFZBUYWA;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly HUBXKRXHWXN MTZYJQQUBLC;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly HUBXKRXHWXN UANSFRBJBCP;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly HUBXKRXHWXN CGZAAPGRMWP;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public static readonly HUBXKRXHWXN YSJGRHJWDVL;

			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public static readonly HUBXKRXHWXN XSQZAYSQTWL;

			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class YAARRZUWZFW
		{
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly HUBXKRXHWXN XGYJHTSFLHG;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly HUBXKRXHWXN IBIWJCPHVUF;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly HUBXKRXHWXN APWKRSHPJCW;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly HUBXKRXHWXN NZPMGXHOQIU;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly HUBXKRXHWXN ENSMCAMGEEM;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly HUBXKRXHWXN CDOVPRRKWRK;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public static readonly HUBXKRXHWXN ZJAECLONLTG;

			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class MXLYWCJAVZQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly HUBXKRXHWXN VYAMZLYBKKO;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly HUBXKRXHWXN FUIAKYYAROA;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly HUBXKRXHWXN WSJWLPSFZIR;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly HUBXKRXHWXN VLOQYCUQVXJ;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly HUBXKRXHWXN OFKGSHGPPOF;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly HUBXKRXHWXN CYOLTSXOFDL;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class TNGZXDRASSV
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class OPOJJAKJPKY
		{
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly HUBXKRXHWXN MXCGFOXKOBQ;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class YRZWOOIHIWK
		{
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly HUBXKRXHWXN QMHSULCMNIU;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class VQSERSECPMZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class SJDBOHJUWRM
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class ULJYRGJWAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public static readonly HUBXKRXHWXN QHIUWCKHGGN;

			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly HUBXKRXHWXN YIPJFXOYCLN;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public static readonly HUBXKRXHWXN KLHCUFCSNAW;

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly HUBXKRXHWXN MIBYXNLXJAS;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class UWLYASIWRUZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public static readonly HUBXKRXHWXN MKXTFBUAZXA;

			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public static readonly HUBXKRXHWXN ATINJTOIVQX;

			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class XZYZIJQJRRL
		{
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class CNSVBNBITMN
		{
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly HUBXKRXHWXN WESHILGMYKD;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly HUBXKRXHWXN DKWJFZBUYWA;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class WMCWBYIOCDI
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly HUBXKRXHWXN EBSGQWOUENP;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly HUBXKRXHWXN UANSFRBJBCP;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public static readonly HUBXKRXHWXN CGZAAPGRMWP;

			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public static readonly HUBXKRXHWXN YSJGRHJWDVL;

			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly HUBXKRXHWXN UTSPBIPLDSS;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly HUBXKRXHWXN ZDLSTXZVLDV;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public static readonly HUBXKRXHWXN YJRDDUPNZFN;

			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly HUBXKRXHWXN WPKFQECDXCV;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly HUBXKRXHWXN YBHVZQYUOVM;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly HUBXKRXHWXN BCYTNOVEWWC;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly HUBXKRXHWXN WESHILGMYKD;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly HUBXKRXHWXN DKWJFZBUYWA;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class PYPRTENSJOW
		{
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class NWYASTUAXYO
		{
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly HUBXKRXHWXN WESHILGMYKD;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly HUBXKRXHWXN DKWJFZBUYWA;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly HUBXKRXHWXN JWBSWDRQFHC;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly HUBXKRXHWXN QSTSFPRUGCS;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly HUBXKRXHWXN NJLREFXVJCN;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class OMPNGHZASVL
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class PEINLGMDZXC
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly HUBXKRXHWXN YSNAZCPALUF;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class AHUDVGFFNFG
		{
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly HUBXKRXHWXN YLZBDAFDVMU;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly HUBXKRXHWXN UXLQTMWXKMF;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly HUBXKRXHWXN WESHILGMYKD;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static readonly HUBXKRXHWXN DKWJFZBUYWA;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class TEAKSAKNZEX
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class UNTIERXESZV
		{
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class XATMNNQNWCU
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class FSLRRSDOWKY
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class PJEBDJCVXKV
		{
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class MZBIPHIYTUJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly HUBXKRXHWXN MAPXDGQDILG;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public static readonly HUBXKRXHWXN RNKSBXLOJSN;

			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class MQVXPOHLXAP
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public static readonly HUBXKRXHWXN OETHXTDZCMO;

			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public static readonly HUBXKRXHWXN NEYQKSRPLHG;

			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public static readonly HUBXKRXHWXN DGSIDGHSTLS;

			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly HUBXKRXHWXN ZEEJIBHXEBY;

			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class JKXGAUABQXC
		{
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly HUBXKRXHWXN OETHXTDZCMO;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public static readonly HUBXKRXHWXN NEYQKSRPLHG;

			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly HUBXKRXHWXN DGSIDGHSTLS;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly HUBXKRXHWXN ZEEJIBHXEBY;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class MDHDOIUSBUF
		{
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class MGTJEYTDBMG
		{
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public static readonly HUBXKRXHWXN UUUUKLYEQIN;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly HUBXKRXHWXN OBULRSWSUIH;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly HUBXKRXHWXN IWDJLETGAHV;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class TQCYCWCIAGP
		{
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly HUBXKRXHWXN UWNNLSNACRG;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public static readonly HUBXKRXHWXN CXWLVQTFAMG;

			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public static readonly HUBXKRXHWXN GOXSWCAPAZV;

			[Cpp2IlInjected.Token(Token = "0x4000207")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class PALNTTHKAHU
		{
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class KIQBBIGRZTN
		{
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly HUBXKRXHWXN FEUNYATNZRZ;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public static readonly HUBXKRXHWXN OOFNDUQPNHX;

			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly HUBXKRXHWXN EFCACFXVLFU;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly HUBXKRXHWXN JLSEBMLVVTU;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly HUBXKRXHWXN CLDTYRTKONB;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class VGCQWBUHAVY
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static readonly HUBXKRXHWXN NSSVDXRPGJF;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class NYTNWRVZWVK
		{
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly HUBXKRXHWXN NQPZYQEHOXI;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly HUBXKRXHWXN HXUEUALSTYP;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly HUBXKRXHWXN RUXMQNODOEW;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class VVZSOCQIHHL
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class MTWYHOCHADX
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class HHHEWPVXTTO
		{
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class BFWQAPRKZMH
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly HUBXKRXHWXN KWVISUXIPNO;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly HUBXKRXHWXN JLLXXVANHSR;

			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly HUBXKRXHWXN ZTPQZTTGUKD;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static readonly HUBXKRXHWXN UYXIGSTKJPV;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public static readonly HUBXKRXHWXN MKHHWRYTBEY;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static readonly HUBXKRXHWXN JRWZTFNJQPQ;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly HUBXKRXHWXN WJADXOYSNLL;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			internal static readonly HUBXKRXHWXN[] WGQYKZXWXEO;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class YHOAIHVVABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public readonly JHOEKUEVGUO DBFCXHNBFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private readonly List<HUBXKRXHWXN> XOUNNBABWFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private readonly List<HUBXKRXHWXN> RVQMOYDCTKJ;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IReadOnlyList<HUBXKRXHWXN> FEKJODKKMVX
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public IReadOnlyList<HUBXKRXHWXN> BCZJTUBRZSE
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2B48D70", Offset = "0x2B47B70", VA = "0x182B48D70")]
		protected YHOAIHVVABL(JHOEKUEVGUO a, params HUBXKRXHWXN[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class ZTZIFRMJTBN : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B49250", Offset = "0x2B48050", VA = "0x182B49250")]
		internal ZTZIFRMJTBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class WIRVRHQNQQU : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B463D0", Offset = "0x2B451D0", VA = "0x182B463D0")]
		internal WIRVRHQNQQU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class GNACSRHHJQT : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B6B0", Offset = "0x2B3A4B0", VA = "0x182B3B6B0")]
		internal GNACSRHHJQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class CLMZUOQWYTS : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A4F0", Offset = "0x2B392F0", VA = "0x182B3A4F0")]
		internal CLMZUOQWYTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class VIXULYYBTLJ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B45AB0", Offset = "0x2B448B0", VA = "0x182B45AB0")]
		internal VIXULYYBTLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class FIBLFYTUDDF : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B470", Offset = "0x2B3A270", VA = "0x182B3B470")]
		internal FIBLFYTUDDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ABNWQNQXYNA : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B38A70", Offset = "0x2B37870", VA = "0x182B38A70")]
		internal ABNWQNQXYNA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class WUVYCIFZBVV : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B473F0", Offset = "0x2B461F0", VA = "0x182B473F0")]
		internal WUVYCIFZBVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class VXDOFICPKDV : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B46010", Offset = "0x2B44E10", VA = "0x182B46010")]
		internal VXDOFICPKDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class NVFXFRCPNID : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B401E0", Offset = "0x2B3EFE0", VA = "0x182B401E0")]
		internal NVFXFRCPNID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class GRLZULCDVVZ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BA70", Offset = "0x2B3A870", VA = "0x182B3BA70")]
		internal GRLZULCDVVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class AYLLPDVUVHN : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B39960", Offset = "0x2B38760", VA = "0x182B39960")]
		internal AYLLPDVUVHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class QWZOSBWTIOT : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B41F00", Offset = "0x2B40D00", VA = "0x182B41F00")]
		internal QWZOSBWTIOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class VKWMJREVUZL : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B45E70", Offset = "0x2B44C70", VA = "0x182B45E70")]
		internal VKWMJREVUZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class RAUJXQVAZON : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B420E0", Offset = "0x2B40EE0", VA = "0x182B420E0")]
		internal RAUJXQVAZON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class DNFTNZMUFRV : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AC90", Offset = "0x2B39A90", VA = "0x182B3AC90")]
		internal DNFTNZMUFRV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class RAZUHVYSCVX : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B422C0", Offset = "0x2B410C0", VA = "0x182B422C0")]
		internal RAZUHVYSCVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class MKZVSJGFVOY : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E450", Offset = "0x2B3D250", VA = "0x182B3E450")]
		internal MKZVSJGFVOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class AXMFAXIJUVQ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B39780", Offset = "0x2B38580", VA = "0x182B39780")]
		internal AXMFAXIJUVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class BZXHDOTWSEM : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A310", Offset = "0x2B39110", VA = "0x182B3A310")]
		internal BZXHDOTWSEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TGOJWGWWFHQ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B42FA0", Offset = "0x2B41DA0", VA = "0x182B42FA0")]
		internal TGOJWGWWFHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class LDDBMZUQHZU : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DC00", Offset = "0x2B3CA00", VA = "0x182B3DC00")]
		internal LDDBMZUQHZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class PJZITZWVWON : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B41AE0", Offset = "0x2B408E0", VA = "0x182B41AE0")]
		internal PJZITZWVWON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class OYQVEMIVUDQ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B413B0", Offset = "0x2B401B0", VA = "0x182B413B0")]
		internal OYQVEMIVUDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class BEPOHJNJZHD : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B39B40", Offset = "0x2B38940", VA = "0x182B39B40")]
		internal BEPOHJNJZHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class YSSVJAIKNEE : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B49070", Offset = "0x2B47E70", VA = "0x182B49070")]
		internal YSSVJAIKNEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class HCCBVPSMZVA : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C260", Offset = "0x2B3B060", VA = "0x182B3C260")]
		internal HCCBVPSMZVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class DDNSIHRNEUE : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AAB0", Offset = "0x2B398B0", VA = "0x182B3AAB0")]
		internal DDNSIHRNEUE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class SOTEVBTFMEJ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2B42920", Offset = "0x2B41720", VA = "0x182B42920")]
		internal SOTEVBTFMEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class IKFETRXLWSQ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C860", Offset = "0x2B3B660", VA = "0x182B3C860")]
		internal IKFETRXLWSQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class TZPTNOBXKWH : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2B43AB0", Offset = "0x2B428B0", VA = "0x182B43AB0")]
		internal TZPTNOBXKWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class JODLFHJGEMZ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D0C0", Offset = "0x2B3BEC0", VA = "0x182B3D0C0")]
		internal JODLFHJGEMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HIEHOOLNMEV : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C4A0", Offset = "0x2B3B2A0", VA = "0x182B3C4A0")]
		internal HIEHOOLNMEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ULBNWMMMYLG : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2B43CF0", Offset = "0x2B42AF0", VA = "0x182B43CF0")]
		internal ULBNWMMMYLG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class NPNVRBMKOIU : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FDA0", Offset = "0x2B3EBA0", VA = "0x182B3FDA0")]
		internal NPNVRBMKOIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class ATLQICBZHGY : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B391E0", Offset = "0x2B37FE0", VA = "0x182B391E0")]
		internal ATLQICBZHGY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WSBSDTEZJNT : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2B47210", Offset = "0x2B46010", VA = "0x182B47210")]
		internal WSBSDTEZJNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class TCFHDBCUUOW : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B42CE0", Offset = "0x2B41AE0", VA = "0x182B42CE0")]
		internal TCFHDBCUUOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class NVFRDVSTGJY : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FF80", Offset = "0x2B3ED80", VA = "0x182B3FF80")]
		internal NVFRDVSTGJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class WIKLDJTWEDZ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2B461F0", Offset = "0x2B44FF0", VA = "0x182B461F0")]
		internal WIKLDJTWEDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class PJHOVAURLCT : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B41900", Offset = "0x2B40700", VA = "0x182B41900")]
		internal PJHOVAURLCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class VBGULNOLXKT : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2B44D90", Offset = "0x2B43B90", VA = "0x182B44D90")]
		internal VBGULNOLXKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class EMYXPGRVLVY : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B050", Offset = "0x2B39E50", VA = "0x182B3B050")]
		internal EMYXPGRVLVY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class TZKNZKSQHIG : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B438D0", Offset = "0x2B426D0", VA = "0x182B438D0")]
		internal TZKNZKSQHIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class AUVQRURFYGF : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B395A0", Offset = "0x2B383A0", VA = "0x182B395A0")]
		internal AUVQRURFYGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class BKJEXVUEVLC : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A130", Offset = "0x2B38F30", VA = "0x182B3A130")]
		internal BKJEXVUEVLC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class WWZZRRVPKGD : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B475D0", Offset = "0x2B463D0", VA = "0x182B475D0")]
		internal WWZZRRVPKGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class SQBVWYYYZHM : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B42B00", Offset = "0x2B41900", VA = "0x182B42B00")]
		internal SQBVWYYYZHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MTXRWTHCRLS : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ED10", Offset = "0x2B3DB10", VA = "0x182B3ED10")]
		internal MTXRWTHCRLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class PSTMTKABLRH : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B41CC0", Offset = "0x2B40AC0", VA = "0x182B41CC0")]
		internal PSTMTKABLRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class TNLMLQOWNBD : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B43250", Offset = "0x2B42050", VA = "0x182B43250")]
		internal TNLMLQOWNBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class DQWNBGAFBFK : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AE70", Offset = "0x2B39C70", VA = "0x182B3AE70")]
		internal DQWNBGAFBFK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class VJVNWEOHLZL : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2B45C90", Offset = "0x2B44A90", VA = "0x182B45C90")]
		internal VJVNWEOHLZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class GPNDLJHGWEQ : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B890", Offset = "0x2B3A690", VA = "0x182B3B890")]
		internal GPNDLJHGWEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class FBWEPZVONCC : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B290", Offset = "0x2B3A090", VA = "0x182B3B290")]
		internal FBWEPZVONCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class NONYFLCYOXM : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FBC0", Offset = "0x2B3E9C0", VA = "0x182B3FBC0")]
		internal NONYFLCYOXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class UNTWNQRQJMK : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B44800", Offset = "0x2B43600", VA = "0x182B44800")]
		internal UNTWNQRQJMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SHHYIOOWQNX : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2B426E0", Offset = "0x2B414E0", VA = "0x182B426E0")]
		internal SHHYIOOWQNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class HXOOXDJNHJC : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C680", Offset = "0x2B3B480", VA = "0x182B3C680")]
		internal HXOOXDJNHJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class RMTDWVFLWAS : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B424A0", Offset = "0x2B412A0", VA = "0x182B424A0")]
		internal RMTDWVFLWAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class YGWKGMNYHCR : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2B48C10", Offset = "0x2B47A10", VA = "0x182B48C10")]
		internal YGWKGMNYHCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class ATXPDCFAEEW : YHOAIHVVABL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B39440", Offset = "0x2B38240", VA = "0x182B39440")]
		internal ATXPDCFAEEW()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public readonly struct NamedType : IEquatable<NamedType>, GCLDOOWCVKA<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public readonly JHOEKUEVGUO Type;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
		private NamedType(string name, JHOEKUEVGUO type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A310", Offset = "0x2A79110", VA = "0x182A7A310")]
		public static NamedType New(string name, JHOEKUEVGUO type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2B40E70", Offset = "0x2B3FC70", VA = "0x182B40E70")]
		public static bool GFBRUTYEXQF([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2B40E70", Offset = "0x2B3FC70", VA = "0x182B40E70", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2B40E70", Offset = "0x2B3FC70", VA = "0x182B40E70")]
		public bool BURZPLIABAB([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B40EC0", Offset = "0x2B3FCC0", VA = "0x182B40EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B41000", Offset = "0x2B3FE00", VA = "0x182B41000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B410B0", Offset = "0x2B3FEB0", VA = "0x182B410B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B41070", Offset = "0x2B3FE70", VA = "0x182B41070")]
		public string JQSJWTBHYEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B40F80", Offset = "0x2B3FD80", VA = "0x182B40F80")]
		public string GJJQMFJXFWJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B40E70", Offset = "0x2B3FC70", VA = "0x182B40E70", Slot = "5")]
		private bool QNNOAERHSTG([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public interface EGZVYBEHFSY
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, IGWAJAWUKJF>> LPHQPRKRJUZ(TWGQWHZWPAR a, bool b);
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
