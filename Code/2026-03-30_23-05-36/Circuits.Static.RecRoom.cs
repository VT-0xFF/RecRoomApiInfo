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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x29767D0", Offset = "0x29755D0", VA = "0x1829767D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		[Cpp2IlInjected.Address(RVA = "0x2974310", Offset = "0x2973110", VA = "0x182974310", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class BHBRETCZGTA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x296DCB0", Offset = "0x296CAB0", VA = "0x18296DCB0")]
		public static bool XSCHKOVBECB(this BCNDQRECDEP a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x296DBF0", Offset = "0x296C9F0", VA = "0x18296DBF0")]
		public static bool XSCHKOVBECB(this IJCVYDCEUWW a)
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
			private readonly LNVUNUKFJTD _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
			public EVRequest(LNVUNUKFJTD staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class UDJJOQZSERO
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<STJODBNPQSH>, UGQRJRACSJQ> GWSQVYRFWAN;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<STJODBNPQSH>>? DKKPIFNFCOJ;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<STJODBNPQSH> YUAEVMMBLMX;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<STJODBNPQSH> OLTERWUTTFG;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<STJODBNPQSH> JUJQKKDSSML;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<STJODBNPQSH> YJCYKNLGZAK;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<STJODBNPQSH> ACDYRXPCYOD;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<STJODBNPQSH> ICTEKGFYTPO;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<STJODBNPQSH> PKOASSUBPCK;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<STJODBNPQSH> KIOGQGWNALM;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<STJODBNPQSH> ZVJNPCDMRDE;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<STJODBNPQSH> MCDFJWBMFOC;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<STJODBNPQSH> PXKYMHLCCXS;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<STJODBNPQSH> KMBRDUOXLUU;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<STJODBNPQSH> KLAFNXFSQAV;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<STJODBNPQSH> CNOJGBHKRWH;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<STJODBNPQSH> TMXUUYFVTUT;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<STJODBNPQSH> WADUUCFXQJG;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<STJODBNPQSH> TZXGGKEYCHB;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<STJODBNPQSH> NBEWMDIGIYF;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<STJODBNPQSH> QBKJWOPTHYW;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<STJODBNPQSH> ICCKNJLMCEV;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<STJODBNPQSH> HVDKBZPMCQE;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<STJODBNPQSH> PCSQRAQHVER;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<STJODBNPQSH> GINRBMAGGCH;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<STJODBNPQSH> FKRBEVGEPQE;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<STJODBNPQSH> RHBIUPGIALC;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<STJODBNPQSH> JWPOYQZBVWP;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<STJODBNPQSH> NOLUSTPLUXY;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<STJODBNPQSH> TSRWLOVHTLZ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<STJODBNPQSH> KDRLZAGMBRF;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<STJODBNPQSH> SVUEMMVDFJL;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<STJODBNPQSH> NZPTJTKZJZV;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<STJODBNPQSH> FJXAYFJQXYO;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<STJODBNPQSH> BIDQQUZFBCN;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<STJODBNPQSH> LIRCFFSMJRJ;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<STJODBNPQSH> WAWJCPKRNPF;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<STJODBNPQSH> RMEBLGPVOGI;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<STJODBNPQSH> AGKEHNVTYFX;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<STJODBNPQSH> GAORGRTJVZA;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<STJODBNPQSH> IDDENGDIHRY;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<STJODBNPQSH> MDSDPUZZAEK;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<STJODBNPQSH> DSNLBJDGZUR;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<STJODBNPQSH> GOUCUPGHONL;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<STJODBNPQSH> RBVWOUSVMGO;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<STJODBNPQSH> VUOTGKGSULT;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<STJODBNPQSH> OSAHQHJZOYV;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<STJODBNPQSH> QUNFQWUTZSP;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<STJODBNPQSH> MBJDQFEAVNU;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<STJODBNPQSH> EFUUFIMWKSI;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<STJODBNPQSH> ZMQFAUAFHAK;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<STJODBNPQSH> UQHOZDYFKUH;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<STJODBNPQSH> NJZBUQVFBPF;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<STJODBNPQSH> ZMQBYSSZBZW;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<STJODBNPQSH> JDKZHUJQQCD;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<STJODBNPQSH> XYXMOVZGXGF;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<STJODBNPQSH> WMVMQLCSAUU;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<STJODBNPQSH> FXWXTEOIJVQ;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<STJODBNPQSH> POGIUSBHEUG;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<STJODBNPQSH> MZUJIKWBKSG;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<STJODBNPQSH> FTASRXYXAUV;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<STJODBNPQSH> CLHSTAOGZKA;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<STJODBNPQSH> QBOTMYKHKLQ;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<STJODBNPQSH> HFXYUUMAYOW;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<STJODBNPQSH> MCRYUEGPWSV;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<STJODBNPQSH> MTBNCMUORXJ;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<STJODBNPQSH> TXHBJORFPGK;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<STJODBNPQSH> XRZIHFPONIN;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<STJODBNPQSH> ODYZGFVIVLI;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<STJODBNPQSH> ADSUNPOPTDO;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<STJODBNPQSH> SAWYEGPCHTM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<STJODBNPQSH>, UGQRJRACSJQ> MNCMEZNUJIK
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x298A5A0", Offset = "0x29893A0", VA = "0x18298A5A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x298A730", Offset = "0x2989530", VA = "0x18298A730")]
			public static UGQRJRACSJQ XYVRKUTVWVA(Id32<STJODBNPQSH> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x298A5F0", Offset = "0x29893F0", VA = "0x18298A5F0")]
			public static bool NQVSNUTQJNZ(Id32<STJODBNPQSH> id, [Out] UGQRJRACSJQ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x298A680", Offset = "0x2989480", VA = "0x18298A680")]
			public static BCNDQRECDEP XBXEASNTYJV(Id32<STJODBNPQSH> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x298A510", Offset = "0x2989310", VA = "0x18298A510")]
			private static Id32<STJODBNPQSH> DELFABVRANX(UGQRJRACSJQ a, Id32<STJODBNPQSH> id)
			{
				return default(Id32<STJODBNPQSH>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x298A7B0", Offset = "0x29895B0", VA = "0x18298A7B0")]
			private static void ZKUJYMKZTVP(Id32<STJODBNPQSH> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class QIGPTPPDANN
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<ERNAQOLUWGD, BCNDQRECDEP?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x1090690", Offset = "0x108F490", VA = "0x181090690")]
				private TypeRegistryFactory([In] IdUnsafeList<ERNAQOLUWGD, BCNDQRECDEP?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2989F70", Offset = "0x2988D70", VA = "0x182989F70")]
				public static TypeRegistryFactory LZSOKMSMVLL()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2989C00", Offset = "0x2988A00", VA = "0x182989C00")]
				public (ReadOnlyIdArray<ERNAQOLUWGD, BCNDQRECDEP>, IReadOnlyDictionary<BCNDQRECDEP, Id32<ERNAQOLUWGD>>) LSLJVZFFPFX()
				{
					return default((ReadOnlyIdArray<ERNAQOLUWGD, BCNDQRECDEP>, IReadOnlyDictionary<BCNDQRECDEP, Id32<ERNAQOLUWGD>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2989A30", Offset = "0x2988830", VA = "0x182989A30")]
				public Id32<ERNAQOLUWGD> ARQBZVJRVEP(int a, BCNDQRECDEP b)
				{
					return default(Id32<ERNAQOLUWGD>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2989BB0", Offset = "0x29889B0", VA = "0x182989BB0")]
				public Id32<ERNAQOLUWGD> Initialize(int id, HCGLTFOVHKA type, HCGLTFOVHKA factoryType)
				{
					return default(Id32<ERNAQOLUWGD>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class JOUEYPCPSFQ
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<ERNAQOLUWGD> UAWFRJHYSDL
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2972280", Offset = "0x2971080", VA = "0x182972280")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x29722C0", Offset = "0x29710C0", VA = "0x1829722C0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<ERNAQOLUWGD> FXOMPNGEJDX
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2972180", Offset = "0x2970F80", VA = "0x182972180")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x29720C0", Offset = "0x2970EC0", VA = "0x1829720C0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<ERNAQOLUWGD> NJSGSZKXNXQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x29721C0", Offset = "0x2970FC0", VA = "0x1829721C0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2972240", Offset = "0x2971040", VA = "0x182972240")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<ERNAQOLUWGD> UQHEDABVLSU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2972140", Offset = "0x2970F40", VA = "0x182972140")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2972300", Offset = "0x2971100", VA = "0x182972300")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<ERNAQOLUWGD> FIBSGNOSQPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2972080", Offset = "0x2970E80", VA = "0x182972080")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2972040", Offset = "0x2970E40", VA = "0x182972040")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<ERNAQOLUWGD> BAQZPLDKPJX
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2972100", Offset = "0x2970F00", VA = "0x182972100")]
					[CompilerGenerated]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2972200", Offset = "0x2971000", VA = "0x182972200")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class UFRVTXGDXJS : IEnumerable<BCNDQRECDEP>, IEnumerable, IEnumerator<BCNDQRECDEP>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private BCNDQRECDEP LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int DGBKDPSSRXL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool OKYEOSNTOKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool IEODKPFJXLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion LAZZJFOYIAV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion NPPQZKJGVNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool EBUCGIPKZGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool HNPVFPCCTNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool CUDJUTHRPGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool ADOAOLFNKND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool TFEGUEHKWHU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool NPLLVNWALXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool ZZGBAUPNTUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool RLMHGMFYGZR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<BCNDQRECDEP> NUQJCBGEMQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private BCNDQRECDEP FOKDAGAMVBT;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private BCNDQRECDEP GVODWXJLOQU
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
				[DebuggerHidden]
				public UFRVTXGDXJS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x298DEC0", Offset = "0x298CCC0", VA = "0x18298DEC0", Slot = "7")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x298DAD0", Offset = "0x298C8D0", VA = "0x18298DAD0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x298D9C0", Offset = "0x298C7C0", VA = "0x18298D9C0")]
				private void GWSJMPTZZMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x298DF50", Offset = "0x298CD50", VA = "0x18298DF50", Slot = "10")]
				[DebuggerHidden]
				private void USEBYPNATQY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x298DA10", Offset = "0x298C810", VA = "0x18298DA10", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<BCNDQRECDEP> YOVQKRRHFTN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x298DA10", Offset = "0x298C810", VA = "0x18298DA10", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HTHYFOXNRHD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class MSDLPJKBRQO : IEnumerable<BCNDQRECDEP>, IEnumerable, IEnumerator<BCNDQRECDEP>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private BCNDQRECDEP LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int DGBKDPSSRXL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion LAZZJFOYIAV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion NPPQZKJGVNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool CUDJUTHRPGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool ADOAOLFNKND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool EBUCGIPKZGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool HNPVFPCCTNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool HYPPWPZVANS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool PMOYUSLSUBT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool TFEGUEHKWHU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool NPLLVNWALXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool RRHCFBHRVKU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool HDRASXYXPHW;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private BCNDQRECDEP GVODWXJLOQU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
				[DebuggerHidden]
				public MSDLPJKBRQO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2974880", Offset = "0x2973680", VA = "0x182974880", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2976790", Offset = "0x2975590", VA = "0x182976790", Slot = "10")]
				[DebuggerHidden]
				private void USEBYPNATQY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x29747D0", Offset = "0x29735D0", VA = "0x1829747D0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<BCNDQRECDEP> YOVQKRRHFTN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x29747D0", Offset = "0x29735D0", VA = "0x1829747D0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HTHYFOXNRHD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class HUPCQZNHOWN : IEnumerable<Id32<ERNAQOLUWGD>>, IEnumerable, IEnumerator<Id32<ERNAQOLUWGD>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<ERNAQOLUWGD> LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int DGBKDPSSRXL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion LAZZJFOYIAV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion NPPQZKJGVNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool EBUCGIPKZGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool HNPVFPCCTNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool CUDJUTHRPGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool ADOAOLFNKND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool TFEGUEHKWHU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool NPLLVNWALXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool ZZGBAUPNTUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool RLMHGMFYGZR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<BCNDQRECDEP> NUQJCBGEMQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<HCGLTFOVHKA> NVGDTVNWOYJ;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<ERNAQOLUWGD> LFRKROCMPZN
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xBD3950", Offset = "0xBD2750", VA = "0x180BD3950", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<ERNAQOLUWGD>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2971CA0", Offset = "0x2970AA0", VA = "0x182971CA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x138C8D0", Offset = "0x138B6D0", VA = "0x18138C8D0")]
				[DebuggerHidden]
				public HUPCQZNHOWN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970950", VA = "0x182971B50", Slot = "7")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2971650", Offset = "0x2970450", VA = "0x182971650", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2971550", Offset = "0x2970350", VA = "0x182971550")]
				private void GWSJMPTZZMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2971500", Offset = "0x2970300", VA = "0x182971500")]
				private void GWCOUVMHXEA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2971CF0", Offset = "0x2970AF0", VA = "0x182971CF0", Slot = "10")]
				[DebuggerHidden]
				private void USEBYPNATQY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x29715A0", Offset = "0x29703A0", VA = "0x1829715A0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<ERNAQOLUWGD>> QAOZJUOZUEA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x29715A0", Offset = "0x29703A0", VA = "0x1829715A0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HTHYFOXNRHD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log VYIZTFKBMQC;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<ERNAQOLUWGD, BCNDQRECDEP?> FQQKUHWNYQE;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<BCNDQRECDEP, Id32<ERNAQOLUWGD>> UMSZTUADWYU;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly IJCVYDCEUWW ASNJCGIDUWR;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly IJCVYDCEUWW BKTBEYWRIWZ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<BCNDQRECDEP> UDXNRSGMPZF;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<BCNDQRECDEP> TIVADXRWRAW;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet OXBUPRNEHNF
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet FVJZITXBKFV
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet JTZKEVLGPVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xB4BC40", Offset = "0xB4AA40", VA = "0x180B4BC40")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static BCNDQRECDEP UAWFRJHYSDL
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2981270", Offset = "0x2980070", VA = "0x182981270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static BCNDQRECDEP FXOMPNGEJDX
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2980B10", Offset = "0x297F910", VA = "0x182980B10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static BCNDQRECDEP NJSGSZKXNXQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2980FB0", Offset = "0x297FDB0", VA = "0x182980FB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static BCNDQRECDEP UQHEDABVLSU
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2980900", Offset = "0x297F700", VA = "0x182980900")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static BCNDQRECDEP TAIRMRSECKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2981540", Offset = "0x2980340", VA = "0x182981540")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static BCNDQRECDEP EMCUZHRGBND
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x297E960", Offset = "0x297D760", VA = "0x18297E960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static BCNDQRECDEP NSWHAZYURRK
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2980D40", Offset = "0x297FB40", VA = "0x182980D40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static BCNDQRECDEP FIBSGNOSQPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x297F5E0", Offset = "0x297E3E0", VA = "0x18297F5E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static HCGLTFOVHKA ZPULEIITHXK
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x297F590", Offset = "0x297E390", VA = "0x18297F590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static HCGLTFOVHKA SDHRBYVYSUH
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x297E740", Offset = "0x297D540", VA = "0x18297E740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static HCGLTFOVHKA WWLBBBHGIAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x29810A0", Offset = "0x297FEA0", VA = "0x1829810A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static HCGLTFOVHKA GSMKATJZHXU
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2982480", Offset = "0x2981280", VA = "0x182982480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static HCGLTFOVHKA KIIGALXMCIW
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x29822D0", Offset = "0x29810D0", VA = "0x1829822D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static HCGLTFOVHKA WPYSVXPQSLD
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x297F910", Offset = "0x297E710", VA = "0x18297F910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static HCGLTFOVHKA WQKHUYPWFXL
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2981A50", Offset = "0x2980850", VA = "0x182981A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static HCGLTFOVHKA UHTHKHBSJDT
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x297E8B0", Offset = "0x297D6B0", VA = "0x18297E8B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static HCGLTFOVHKA QSLAIPQMPRS
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x297FA50", Offset = "0x297E850", VA = "0x18297FA50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static HCGLTFOVHKA MASUVJQMGJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2982280", Offset = "0x2981080", VA = "0x182982280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static HCGLTFOVHKA HACTEFMLIPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x297EB10", Offset = "0x297D910", VA = "0x18297EB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static HCGLTFOVHKA IZDMNNTBHIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x29803A0", Offset = "0x297F1A0", VA = "0x1829803A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static HCGLTFOVHKA NSJZZGTKDWH
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x297EC20", Offset = "0x297DA20", VA = "0x18297EC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static HCGLTFOVHKA GKHTTZKRXFP
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2982820", Offset = "0x2981620", VA = "0x182982820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static HCGLTFOVHKA CWHHDTUKLGY
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x297EDF0", Offset = "0x297DBF0", VA = "0x18297EDF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static HCGLTFOVHKA OBTSGAZLONG
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x297F530", Offset = "0x297E330", VA = "0x18297F530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static HCGLTFOVHKA GYFFBFYQSEL
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2981750", Offset = "0x2980550", VA = "0x182981750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static HCGLTFOVHKA EOLNAVWWGCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x297FE00", Offset = "0x297EC00", VA = "0x18297FE00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static HCGLTFOVHKA RSBQSOMGUNL
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2980E90", Offset = "0x297FC90", VA = "0x182980E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static HCGLTFOVHKA AYTKEXRFVUB
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x297F050", Offset = "0x297DE50", VA = "0x18297F050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static HCGLTFOVHKA OEECIQSGOFG
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x29808A0", Offset = "0x297F6A0", VA = "0x1829808A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static HCGLTFOVHKA YZKANDUMTTP
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x297EEB0", Offset = "0x297DCB0", VA = "0x18297EEB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static HCGLTFOVHKA PFDMOWMEKPZ
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2981690", Offset = "0x2980490", VA = "0x182981690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static HCGLTFOVHKA FMELFJYFTNX
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2981300", Offset = "0x2980100", VA = "0x182981300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static HCGLTFOVHKA PXSZQDOBJJP
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x297E790", Offset = "0x297D590", VA = "0x18297E790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static HCGLTFOVHKA ZHRYTWHFGXO
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2982760", Offset = "0x2981560", VA = "0x182982760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static HCGLTFOVHKA GKWIMQMWDCN
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2981990", Offset = "0x2980790", VA = "0x182981990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static HCGLTFOVHKA TUOAKIAZGZN
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x297EF90", Offset = "0x297DD90", VA = "0x18297EF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static HCGLTFOVHKA FCHWZSRZGVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x297EA50", Offset = "0x297D850", VA = "0x18297EA50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static HCGLTFOVHKA VHHJWOQJQSQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2980E30", Offset = "0x297FC30", VA = "0x182980E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static HCGLTFOVHKA NQQAIAKZGDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x29800A0", Offset = "0x297EEA0", VA = "0x1829800A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static HCGLTFOVHKA ZFWSVEEHLFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x297F960", Offset = "0x297E760", VA = "0x18297F960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static HCGLTFOVHKA AGURGUECCZS
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x297FF80", Offset = "0x297ED80", VA = "0x18297FF80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static HCGLTFOVHKA AFWAMIOLCIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x29819F0", Offset = "0x29807F0", VA = "0x1829819F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static HCGLTFOVHKA BHXPUGPLKLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x29810F0", Offset = "0x297FEF0", VA = "0x1829810F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static HCGLTFOVHKA HLFTGOUBTOY
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2981210", Offset = "0x2980010", VA = "0x182981210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static HCGLTFOVHKA UWHUUMKWFRQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x297E7F0", Offset = "0x297D5F0", VA = "0x18297E7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static HCGLTFOVHKA TSXGRGBDIDT
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2982640", Offset = "0x2981440", VA = "0x182982640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static HCGLTFOVHKA NFRGVQDCOHX
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x29811B0", Offset = "0x297FFB0", VA = "0x1829811B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static HCGLTFOVHKA TZKXMGNDEDO
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x29803F0", Offset = "0x297F1F0", VA = "0x1829803F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static HCGLTFOVHKA ACJOLKXBOBE
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x297FCE0", Offset = "0x297EAE0", VA = "0x18297FCE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static HCGLTFOVHKA NJKSADDHWEQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x297EE50", Offset = "0x297DC50", VA = "0x18297EE50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static HCGLTFOVHKA RYEOQAJOIEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x29817B0", Offset = "0x29805B0", VA = "0x1829817B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static HCGLTFOVHKA ZBBZHBRIJJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x297F730", Offset = "0x297E530", VA = "0x18297F730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static HCGLTFOVHKA FLXOJCOYADX
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x297EAB0", Offset = "0x297D8B0", VA = "0x18297EAB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static HCGLTFOVHKA WMUDOMDYGHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x297FE60", Offset = "0x297EC60", VA = "0x18297FE60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static HCGLTFOVHKA KKFFLSJAGJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x297F9C0", Offset = "0x297E7C0", VA = "0x18297F9C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static HCGLTFOVHKA UBGPYLUFDRB
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2980C00", Offset = "0x297FA00", VA = "0x182980C00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static HCGLTFOVHKA FEZQMTUXPCX
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x297E850", Offset = "0x297D650", VA = "0x18297E850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static HCGLTFOVHKA XNVHRNLFORG
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2981810", Offset = "0x2980610", VA = "0x182981810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static HCGLTFOVHKA VQVDTINSGNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x297E9F0", Offset = "0x297D7F0", VA = "0x18297E9F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static HCGLTFOVHKA DANVPVLLKQK
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2981E90", Offset = "0x2980C90", VA = "0x182981E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static HCGLTFOVHKA PHNFLWRGPUV
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2981DB0", Offset = "0x2980BB0", VA = "0x182981DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static HCGLTFOVHKA ARVJVIEAUBC
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x297FFE0", Offset = "0x297EDE0", VA = "0x18297FFE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static HCGLTFOVHKA KUOWQNQEPLX
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2980DD0", Offset = "0x297FBD0", VA = "0x182980DD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static HCGLTFOVHKA XFDVRPJCKRT
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x297E4F0", Offset = "0x297D2F0", VA = "0x18297E4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static HCGLTFOVHKA XMEVSUWZBOR
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x29815D0", Offset = "0x29803D0", VA = "0x1829815D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static HCGLTFOVHKA OQSMDFQPSOD
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x297E550", Offset = "0x297D350", VA = "0x18297E550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static HCGLTFOVHKA XIBEDZXUNHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2980100", Offset = "0x297EF00", VA = "0x182980100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static HCGLTFOVHKA TGDQAAMVMUB
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x297F850", Offset = "0x297E650", VA = "0x18297F850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static HCGLTFOVHKA NDOFCAZPUOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2981040", Offset = "0x297FE40", VA = "0x182981040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static HCGLTFOVHKA OHUATJZNSYO
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x297FB60", Offset = "0x297E960", VA = "0x18297FB60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static HCGLTFOVHKA NJHSWLNQTUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x29813C0", Offset = "0x29801C0", VA = "0x1829813C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static HCGLTFOVHKA JIVWSUWEDIY
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x297FB00", Offset = "0x297E900", VA = "0x18297FB00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static HCGLTFOVHKA LVLMHTCSJMQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x297F0B0", Offset = "0x297DEB0", VA = "0x18297F0B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static HCGLTFOVHKA TQECOWXFGML
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x29814E0", Offset = "0x29802E0", VA = "0x1829814E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static HCGLTFOVHKA HTDEIWOBWMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x297EBC0", Offset = "0x297D9C0", VA = "0x18297EBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static HCGLTFOVHKA VHOYVKLALXN
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x297F790", Offset = "0x297E590", VA = "0x18297F790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static HCGLTFOVHKA SIFYNNHTZRE
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x29802E0", Offset = "0x297F0E0", VA = "0x1829802E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static HCGLTFOVHKA KWEKSDBFFVA
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x29826A0", Offset = "0x29814A0", VA = "0x1829826A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static HCGLTFOVHKA WUMSETSHYHU
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x297FC80", Offset = "0x297EA80", VA = "0x18297FC80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static HCGLTFOVHKA BSAUPTUUUOH
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x297E900", Offset = "0x297D700", VA = "0x18297E900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static HCGLTFOVHKA OQRYIRIJJRM
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x297FAA0", Offset = "0x297E8A0", VA = "0x18297FAA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static HCGLTFOVHKA FAVVFRXUNBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2980F50", Offset = "0x297FD50", VA = "0x182980F50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static HCGLTFOVHKA OWLWZKKANTN
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x297F7F0", Offset = "0x297E5F0", VA = "0x18297F7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static HCGLTFOVHKA VFVVCXCVTAB
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x29827C0", Offset = "0x29815C0", VA = "0x1829827C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static HCGLTFOVHKA PZJPOXMFVAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2980EF0", Offset = "0x297FCF0", VA = "0x182980EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static HCGLTFOVHKA JMQPNSJCYTF
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2980450", Offset = "0x297F250", VA = "0x182980450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static HCGLTFOVHKA BMKTKEXANBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2981150", Offset = "0x297FF50", VA = "0x182981150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static HCGLTFOVHKA YDBZVMWJCTM
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2980990", Offset = "0x297F790", VA = "0x182980990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static HCGLTFOVHKA UBIRLTZNLXU
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x29818D0", Offset = "0x29806D0", VA = "0x1829818D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static HCGLTFOVHKA IPCMHRBIEAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2982700", Offset = "0x2981500", VA = "0x182982700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static HCGLTFOVHKA MJXHRMYERAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x297E6E0", Offset = "0x297D4E0", VA = "0x18297E6E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static HCGLTFOVHKA CHDFZYBBHZL
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x29825E0", Offset = "0x29813E0", VA = "0x1829825E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static HCGLTFOVHKA CFXCTHBAZDL
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2981D50", Offset = "0x2980B50", VA = "0x182981D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static HCGLTFOVHKA LBZLWHOVMXL
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2980BA0", Offset = "0x297F9A0", VA = "0x182980BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static HCGLTFOVHKA XNMJTQRSVGN
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x297FD40", Offset = "0x297EB40", VA = "0x18297FD40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static HCGLTFOVHKA AVODKCIJEHT
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x297FEC0", Offset = "0x297ECC0", VA = "0x18297FEC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static HCGLTFOVHKA KYZCRFUXHUA
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x297FC20", Offset = "0x297EA20", VA = "0x18297FC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static HCGLTFOVHKA LIFVYSQPIHX
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2981870", Offset = "0x2980670", VA = "0x182981870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static HCGLTFOVHKA LDINYZOQDHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2981480", Offset = "0x2980280", VA = "0x182981480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static HCGLTFOVHKA TPPHTSEQBIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2980A50", Offset = "0x297F850", VA = "0x182980A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static HCGLTFOVHKA KRLJEYVTXOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x297ED30", Offset = "0x297DB30", VA = "0x18297ED30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static HCGLTFOVHKA FSWCEPRWADR
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2982580", Offset = "0x2981380", VA = "0x182982580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static HCGLTFOVHKA EBRSENPIFGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x297FF20", Offset = "0x297ED20", VA = "0x18297FF20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static HCGLTFOVHKA HQGNDTERYCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2980280", Offset = "0x297F080", VA = "0x182980280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static HCGLTFOVHKA YBMJCNMXVDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x29801C0", Offset = "0x297EFC0", VA = "0x1829801C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static HCGLTFOVHKA QGYXIFFSCJS
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x297FDA0", Offset = "0x297EBA0", VA = "0x18297FDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static HCGLTFOVHKA TQSVXFMPHAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x29809F0", Offset = "0x297F7F0", VA = "0x1829809F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static HCGLTFOVHKA WHXTLGUKSGF
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x297F8B0", Offset = "0x297E6B0", VA = "0x18297F8B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static HCGLTFOVHKA MZQPBINCSER
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2981930", Offset = "0x2980730", VA = "0x182981930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static HCGLTFOVHKA CIVNLSDDONI
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x297FBC0", Offset = "0x297E9C0", VA = "0x18297FBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static HCGLTFOVHKA VVOIDLQPZRT
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2981630", Offset = "0x2980430", VA = "0x182981630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static HCGLTFOVHKA VEIYDJHHPZR
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2981420", Offset = "0x2980220", VA = "0x182981420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static HCGLTFOVHKA ADZBRKODZRI
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2980220", Offset = "0x297F020", VA = "0x182980220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static HCGLTFOVHKA BVAAKVWBDCT
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x297F6D0", Offset = "0x297E4D0", VA = "0x18297F6D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static HCGLTFOVHKA OBFBMONCRUG
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x297ECD0", Offset = "0x297DAD0", VA = "0x18297ECD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static HCGLTFOVHKA PIAPXXRDPHX
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2980160", Offset = "0x297EF60", VA = "0x182980160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static HCGLTFOVHKA BVVQKTEOQQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2980040", Offset = "0x297EE40", VA = "0x182980040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static HCGLTFOVHKA ZMJDMIBDQYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x29804B0", Offset = "0x297F2B0", VA = "0x1829804B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static HCGLTFOVHKA LQYOCNICXWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2980340", Offset = "0x297F140", VA = "0x182980340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static HCGLTFOVHKA XXKEIAMRGUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x297EFF0", Offset = "0x297DDF0", VA = "0x18297EFF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static HCGLTFOVHKA XBGTNYWYVEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x297EB60", Offset = "0x297D960", VA = "0x18297EB60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static HCGLTFOVHKA BGQCLFVZZEY
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2980AB0", Offset = "0x297F8B0", VA = "0x182980AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static HCGLTFOVHKA TUMEEVCBYCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x29816F0", Offset = "0x29804F0", VA = "0x1829816F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static HCGLTFOVHKA QECFRREMNCT
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x297EC70", Offset = "0x297DA70", VA = "0x18297EC70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static HCGLTFOVHKA LHQUTNKYMLH
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x297F670", Offset = "0x297E470", VA = "0x18297F670")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static HCGLTFOVHKA MFVHCJJQWOD
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x297ED90", Offset = "0x297DB90", VA = "0x18297ED90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static HCGLTFOVHKA QDTSOMOMKFO
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2981360", Offset = "0x2980160", VA = "0x182981360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2982320", Offset = "0x2981120", VA = "0x182982320")]
			public static IJCVYDCEUWW XWDBXDDMRRM([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2980C60", Offset = "0x297FA60", VA = "0x182980C60")]
			public static ClassFactoryTypeParams PJMOIPKUEHV(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2980D10", Offset = "0x297FB10", VA = "0x182980D10")]
			public static ClassFactoryTypeParams PJMOIPKUEHV([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x297E4C0", Offset = "0x297D2C0", VA = "0x18297E4C0")]
			public static IJCVYDCEUWW ACMQZFHHXSQ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x297FA20", Offset = "0x297E820", VA = "0x18297FA20")]
			public static IJCVYDCEUWW JAARKDONWFT(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x297E5B0", Offset = "0x297D3B0", VA = "0x18297E5B0")]
			public static IJCVYDCEUWW BAQZPLDKPJX([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2981EF0", Offset = "0x2980CF0", VA = "0x182981EF0")]
			public static BCNDQRECDEP XBXEASNTYJV(Id32<ERNAQOLUWGD> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x297EF10", Offset = "0x297DD10", VA = "0x18297EF10")]
			public static string FVBYXXDWWLO(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2981FA0", Offset = "0x2980DA0", VA = "0x182981FA0")]
			private static BCNDQRECDEP XBXEASNTYJV(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2982410", Offset = "0x2981210", VA = "0x182982410")]
			public static Id32<ERNAQOLUWGD>? YABKNOBVNEG(BCNDQRECDEP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x297F1C0", Offset = "0x297DFC0", VA = "0x18297F1C0")]
			public static CircuitTypeIdWrapper? GTBJTVNQUFX(BCNDQRECDEP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2982880", Offset = "0x2981680", VA = "0x182982880")]
			static QIGPTPPDANN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x29824D0", Offset = "0x29812D0", VA = "0x1829824D0")]
			[IteratorStateMachine(typeof(MSDLPJKBRQO))]
			private static IEnumerable<BCNDQRECDEP> YPKDOGWVUZF(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x29807F0", Offset = "0x297F5F0", VA = "0x1829807F0")]
			[IteratorStateMachine(typeof(UFRVTXGDXJS))]
			public static IEnumerable<BCNDQRECDEP> NWVVNRRRLKS(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2981AA0", Offset = "0x29808A0", VA = "0x182981AA0")]
			public static Variant WRKLIKPJAHV(BCNDQRECDEP a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2980510", Offset = "0x297F310", VA = "0x182980510")]
			public static Variant NRHFKAUUXQC(BCNDQRECDEP a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2981E10", Offset = "0x2980C10", VA = "0x182981E10")]
			public static bool WWDSKGYTLAS(BCNDQRECDEP a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x297F110", Offset = "0x297DF10", VA = "0x18297F110")]
			[IteratorStateMachine(typeof(HUPCQZNHOWN))]
			public static IEnumerable<Id32<ERNAQOLUWGD>> GPIRVTHDQYM(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class LNVGCWBSZQA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2973230", Offset = "0x2972030", VA = "0x182973230")]
		public static BTYOWIHCQJR ZLPVCWRAQLQ(this BCNDQRECDEP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x29726C0", Offset = "0x29714C0", VA = "0x1829726C0")]
		public static BCNDQRECDEP LNQLBTCFZPN(this BTYOWIHCQJR a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XFNFPOMXMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C98240", Offset = "0x3C97040", VA = "0x183C98240")]
		public static Dictionary<b, c> EMMYEBRHFSX<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ZYNOZXRXVEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x298E110", Offset = "0x298CF10", VA = "0x18298E110")]
		public static CDDMBSGMXBP ZLPVCWRAQLQ([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x298E070", Offset = "0x298CE70", VA = "0x18298E070")]
		public static Guid LNQLBTCFZPN(CDDMBSGMXBP a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class OKOLSXSVRHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29768B0", Offset = "0x29756B0", VA = "0x1829768B0")]
		public static IEOWGWVYWLP ZLPVCWRAQLQ([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2976850", Offset = "0x2975650", VA = "0x182976850")]
		public static NamedType LNQLBTCFZPN(this IEOWGWVYWLP a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RUCOZSTKTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2880", Offset = "0x3AB1680", VA = "0x183AB2880")]
		public static void VPPFEKBGAMH<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2AE0", Offset = "0x3AB18E0", VA = "0x183AB2AE0")]
		public static void VPPFEKBGAMH<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class CGHGCQKJKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x296DF10", Offset = "0x296CD10", VA = "0x18296DF10")]
		public static IORKXZGVOMB ZLPVCWRAQLQ([In] this Variant self, BCNDQRECDEP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x296DDC0", Offset = "0x296CBC0", VA = "0x18296DDC0")]
		public static Variant LNQLBTCFZPN(this IORKXZGVOMB a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DDIOKSFIFUQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<YMQLTXYWAVC> JRHWNCLVCAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool BBUODQGHJRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool MIKDGBXVAAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool KAVJPADKGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool MXUMYFKORLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool MXPGAYQRIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool UPIRHTKNJYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool CKYAXVLTNQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool DQBQQTNAUDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, BCNDQRECDEP Type)> FXMICNHCHSW;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid ZVXCDESMJGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2933940", Offset = "0x2932740", VA = "0x182933940")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<YMQLTXYWAVC> XPWIBGMUVRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2933940", Offset = "0x2932740", VA = "0x182933940")]
			get
			{
				return default(Id128<YMQLTXYWAVC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, BCNDQRECDEP Type)> DYJLDAEVJVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ZHUQTEMYHYC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x29704A0", Offset = "0x296F2A0", VA = "0x1829704A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2970060", Offset = "0x296EE60", VA = "0x182970060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, BCNDQRECDEP> HJUAMWFOQZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x296FB70", Offset = "0x296E970", VA = "0x18296FB70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2970690", Offset = "0x296F490", VA = "0x182970690")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CFKINZYMNWG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2970740", Offset = "0x296F540", VA = "0x182970740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x296FD40", Offset = "0x296EB40", VA = "0x18296FD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> QGBRPYXABPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2970100", Offset = "0x296EF00", VA = "0x182970100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x29708E0", Offset = "0x296F6E0", VA = "0x1829708E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, BCNDQRECDEP> JTWNDEJQHUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2970C30", Offset = "0x296FA30", VA = "0x182970C30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x29703F0", Offset = "0x296F1F0", VA = "0x1829703F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ZDYDBYRFMLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2970B90", Offset = "0x296F990", VA = "0x182970B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2970AF0", Offset = "0x296F8F0", VA = "0x182970AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18FDD60", Offset = "0x18FCB60", VA = "0x1818FDD60")]
		public void BUATVACGAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2970CE0", Offset = "0x296FAE0", VA = "0x182970CE0")]
		internal DDIOKSFIFUQ([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, BCNDQRECDEP Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2970540", Offset = "0x296F340", VA = "0x182970540")]
		public static CircuitEventDefinitionFactoryStart LZSOKMSMVLL(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2970610", Offset = "0x296F410", VA = "0x182970610")]
		public static CircuitEventDefinitionFactoryStart LZSOKMSMVLL(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x296FF50", Offset = "0x296ED50", VA = "0x18296FF50")]
		public static DDIOKSFIFUQ EQGGMROSLLZ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x29701B0", Offset = "0x296EFB0", VA = "0x1829701B0")]
		public static DDIOKSFIFUQ IAQTGHPBPWV([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCDB8C0", Offset = "0xCDA6C0", VA = "0x180CDB8C0")]
		public void SEEDJJJROUT(Id128<YMQLTXYWAVC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x296FEF0", Offset = "0x296ECF0", VA = "0x18296FEF0")]
		public void DLCQZDAUWYS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2970990", Offset = "0x296F790", VA = "0x182970990")]
		public void WSGZUGPCAGW(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x29707F0", Offset = "0x296F5F0", VA = "0x1829707F0")]
		public void VASVXMVEUWV(int a, BCNDQRECDEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x296FC20", Offset = "0x296EA20", VA = "0x18296FC20")]
		public void ASAHDAIQPRZ(string a, BCNDQRECDEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2970A80", Offset = "0x296F880", VA = "0x182970A80")]
		public void YKKOEYUYKAM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x296FDF0", Offset = "0x296EBF0", VA = "0x18296FDF0")]
		public DDIOKSFIFUQ Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x296E670", Offset = "0x296D470", VA = "0x18296E670")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x296E3D0", Offset = "0x296D1D0", VA = "0x18296E3D0")]
		public CircuitEventDefinitionFactoryParams GKEPSZQYOBH(string a, BCNDQRECDEP b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x296E540", Offset = "0x296D340", VA = "0x18296E540")]
		public DDIOKSFIFUQ LSLJVZFFPFX()
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
		private readonly List<(string Name, BCNDQRECDEP Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x296E340", Offset = "0x296D140", VA = "0x18296E340")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, BCNDQRECDEP Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x296E110", Offset = "0x296CF10", VA = "0x18296E110")]
		public CircuitEventDefinitionFactoryParams GKEPSZQYOBH(string a, BCNDQRECDEP b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x296E240", Offset = "0x296D040", VA = "0x18296E240")]
		public DDIOKSFIFUQ LSLJVZFFPFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HQYHUQHSGFD
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly DDIOKSFIFUQ FUMLDGVNBCA;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly DDIOKSFIFUQ JQCVBSYSSCX;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly DDIOKSFIFUQ WKKEGANBNKG;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly DDIOKSFIFUQ KZVRZYBSRRN;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly DDIOKSFIFUQ RZVFRENMETS;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly DDIOKSFIFUQ QMOCYRFPNPE;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly DDIOKSFIFUQ FPCWOPQHQRL;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly DDIOKSFIFUQ[] SXEEMMLBKQC;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class OLTERWUTTFG
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly DDIOKSFIFUQ FPZBFYMUGLS;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class JUJQKKDSSML
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly DDIOKSFIFUQ TGEEVCYHXJS;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly DDIOKSFIFUQ BMGVMPLOQVH;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class HFXYUUMAYOW
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly DDIOKSFIFUQ QPOIVCXWXRP;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly DDIOKSFIFUQ GXEHURHUDUE;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly DDIOKSFIFUQ[] JWJJONWDUUA;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly DDIOKSFIFUQ NZONNOUMGVK;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly DDIOKSFIFUQ HTUJZLKKKXX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class MBJDQFEAVNU
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly DDIOKSFIFUQ ELVYXXVIUOZ;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly DDIOKSFIFUQ YBTOCTSQCOQ;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class ACDYRXPCYOD
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly DDIOKSFIFUQ CHWGEWXSBPW;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly DDIOKSFIFUQ AIGGEZLPVRV;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class ICTEKGFYTPO
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly DDIOKSFIFUQ TGEEVCYHXJS;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly DDIOKSFIFUQ BMGVMPLOQVH;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class PKOASSUBPCK
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly DDIOKSFIFUQ DHWFGGOFPBJ;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly DDIOKSFIFUQ LIUARFKEWLO;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly DDIOKSFIFUQ CHTIZKGYACC;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly DDIOKSFIFUQ LSCYDZCIBTK;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly DDIOKSFIFUQ MQLIJBVHCLB;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly DDIOKSFIFUQ PLXINNEPKTK;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly DDIOKSFIFUQ TGNYSMSGYYR;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class KIOGQGWNALM
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class ZVJNPCDMRDE
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class IDDENGDIHRY
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class MCDFJWBMFOC
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly DDIOKSFIFUQ NPARWAHJCGX;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly DDIOKSFIFUQ QEOCIGJPQXC;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class WMVMQLCSAUU
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class PXKYMHLCCXS
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class KMBRDUOXLUU
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class QUNFQWUTZSP
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly DDIOKSFIFUQ SCRMPXASBKD;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly DDIOKSFIFUQ QGZWOOLBDXL;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly DDIOKSFIFUQ MDFNNMIZDVA;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly DDIOKSFIFUQ ZFXAUIRBTYT;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly DDIOKSFIFUQ JDRSSLWFSOZ;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly DDIOKSFIFUQ CHWGEWXSBPW;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly DDIOKSFIFUQ EUROKKONTRP;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly DDIOKSFIFUQ HRYWCYNTWLQ;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly DDIOKSFIFUQ DCNWVVTYVFC;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly DDIOKSFIFUQ LWXFEGYXJGY;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly DDIOKSFIFUQ IKVROUGLAVE;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly DDIOKSFIFUQ KLBVLGESYLC;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly DDIOKSFIFUQ VHJMGBCBAFB;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly DDIOKSFIFUQ KNJQKQJXFMO;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly DDIOKSFIFUQ DSOPKGJUZZT;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly DDIOKSFIFUQ HBDIPNPIZTD;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly DDIOKSFIFUQ KEBCWEPBUEL;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly DDIOKSFIFUQ URFWFHDAWHC;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly DDIOKSFIFUQ HCUJZJFSVHH;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly DDIOKSFIFUQ AGUMNZHIFHZ;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly DDIOKSFIFUQ SAKKJMZODSS;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly DDIOKSFIFUQ TOHCYXYNHXI;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly DDIOKSFIFUQ QKIUYKLIRXS;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly DDIOKSFIFUQ XXLXZHKRKHW;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly DDIOKSFIFUQ NAAWZWHUFOU;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly DDIOKSFIFUQ HEOGIMUMJJG;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly DDIOKSFIFUQ UMRWDKUGTAG;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly DDIOKSFIFUQ FJWVLWELMLM;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly DDIOKSFIFUQ UKVZMNMQSID;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly DDIOKSFIFUQ QGEMDEQCQHJ;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly DDIOKSFIFUQ JXLVOVSSJXI;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly DDIOKSFIFUQ SGORWRUYAFA;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly DDIOKSFIFUQ FZOWBHPTWKD;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly DDIOKSFIFUQ HMXOKMVYRML;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly DDIOKSFIFUQ RGTJNRRXXEP;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly DDIOKSFIFUQ WKOPCXIENPN;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly DDIOKSFIFUQ TNOFLCMOUGP;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly DDIOKSFIFUQ ZQXCBPVFBIB;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly DDIOKSFIFUQ BBKQWHDILCN;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly DDIOKSFIFUQ WWPVJRLARGZ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly DDIOKSFIFUQ CEXUNACKBXS;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly DDIOKSFIFUQ FFEXPGTNTUC;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly DDIOKSFIFUQ YMMARXJAWUE;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly DDIOKSFIFUQ LLATHNYALEA;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly DDIOKSFIFUQ SBYPBFXXUVO;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly DDIOKSFIFUQ OYDPIRAEFQI;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly DDIOKSFIFUQ ZZHMWKTOOTA;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly DDIOKSFIFUQ DCINSNPHHHM;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly DDIOKSFIFUQ SHUSCLEQUEG;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly DDIOKSFIFUQ PITFUMVFILS;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly DDIOKSFIFUQ MMZVIVTLBRJ;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly DDIOKSFIFUQ TDYNIZXWVDW;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly DDIOKSFIFUQ LPNFLHOMHTY;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly DDIOKSFIFUQ XLRCBUSWWIM;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly DDIOKSFIFUQ QWPKYWLULQU;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly DDIOKSFIFUQ HSUPLBJPWTC;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly DDIOKSFIFUQ MOLXCZDDEFK;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly DDIOKSFIFUQ ZZSRBPSRYYA;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly DDIOKSFIFUQ KEZDSNCDOWO;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly DDIOKSFIFUQ QRZWUNISRCS;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly DDIOKSFIFUQ LNTFUWGAOHE;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly DDIOKSFIFUQ BYWQXTEBUKI;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly DDIOKSFIFUQ IWXWECBJBRZ;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly DDIOKSFIFUQ AJVJVBFDFUY;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly DDIOKSFIFUQ JVZPKZWJBHC;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly DDIOKSFIFUQ GFQAAYVSTLZ;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly DDIOKSFIFUQ LNSGULCLCJD;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly DDIOKSFIFUQ BVAVXXIWIVY;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly DDIOKSFIFUQ EABOCPYWIMU;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class CNOJGBHKRWH
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class KJKTSTVDMNM
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly DDIOKSFIFUQ JHSZAQDAHOM;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly DDIOKSFIFUQ TIAIMHKSNTT;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly DDIOKSFIFUQ MRTIUMWJDHT;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly DDIOKSFIFUQ QRRSPJEIVOW;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly DDIOKSFIFUQ OCEFSCGYNAG;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly DDIOKSFIFUQ KGQRPBZZBMQ;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly DDIOKSFIFUQ ZUPYXNHYZTA;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class WZFOCTIGWDV
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly DDIOKSFIFUQ QGZWOOLBDXL;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly DDIOKSFIFUQ MDFNNMIZDVA;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly DDIOKSFIFUQ ZFXAUIRBTYT;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly DDIOKSFIFUQ MYRYDXBRNIP;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly DDIOKSFIFUQ BRPIEQQBPEH;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly DDIOKSFIFUQ ITEFLOUXEWX;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly DDIOKSFIFUQ VTOLYPPSBBX;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class TMXUUYFVTUT
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly DDIOKSFIFUQ PRYXKOZISLD;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly DDIOKSFIFUQ ITUMTRSGBZD;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly DDIOKSFIFUQ HRCIBDRDOLM;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly DDIOKSFIFUQ VZFRAISZLQK;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly DDIOKSFIFUQ LBYRNRVOITE;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly DDIOKSFIFUQ IJARDTWLCRK;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class WADUUCFXQJG
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class TZXGGKEYCHB
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly DDIOKSFIFUQ NSQDDBCMUWF;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class NBEWMDIGIYF
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly DDIOKSFIFUQ SCRMPXASBKD;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class QBKJWOPTHYW
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class ICCKNJLMCEV
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class RBVWOUSVMGO
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly DDIOKSFIFUQ VZSLGHMLEEW;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly DDIOKSFIFUQ YQGMZSWPTIY;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly DDIOKSFIFUQ WMPGDMUKSOX;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly DDIOKSFIFUQ IHNYMHNTKTF;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class HVDKBZPMCQE
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly DDIOKSFIFUQ KQOCQRZAUOZ;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly DDIOKSFIFUQ CAISBGDFESW;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class FKRBEVGEPQE
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class KBDBGOJFRXS
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly DDIOKSFIFUQ JHSZAQDAHOM;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly DDIOKSFIFUQ TIAIMHKSNTT;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class PCSQRAQHVER
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly DDIOKSFIFUQ PADOADVPRVI;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly DDIOKSFIFUQ QRRSPJEIVOW;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly DDIOKSFIFUQ OCEFSCGYNAG;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly DDIOKSFIFUQ KGQRPBZZBMQ;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly DDIOKSFIFUQ YEINMMHATNR;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly DDIOKSFIFUQ HAKUZMYMOLC;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly DDIOKSFIFUQ QEOGZGJVHIE;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly DDIOKSFIFUQ FZPJDAMSKBQ;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly DDIOKSFIFUQ MRZQEWVBQYH;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly DDIOKSFIFUQ TWXBEKEKNIP;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly DDIOKSFIFUQ JHSZAQDAHOM;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly DDIOKSFIFUQ TIAIMHKSNTT;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class GINRBMAGGCH
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class VUOTGKGSULT
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly DDIOKSFIFUQ JHSZAQDAHOM;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly DDIOKSFIFUQ TIAIMHKSNTT;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly DDIOKSFIFUQ FLTGLKEDLHV;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly DDIOKSFIFUQ YFVVFGSHSRN;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly DDIOKSFIFUQ JYVFVJUJKPE;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class RHBIUPGIALC
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class JDKZHUJQQCD
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly DDIOKSFIFUQ PYDYYBRFRUM;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class JWPOYQZBVWP
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly DDIOKSFIFUQ VCWGTVOZLMV;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly DDIOKSFIFUQ GRATMAIEUPS;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly DDIOKSFIFUQ JHSZAQDAHOM;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly DDIOKSFIFUQ TIAIMHKSNTT;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class NOLUSTPLUXY
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class EYHIWGUWBSK
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class TSRWLOVHTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class KDRLZAGMBRF
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class TXHBJORFPGK
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class YUBEWJNUMOO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly DDIOKSFIFUQ NPARWAHJCGX;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly DDIOKSFIFUQ QEOCIGJPQXC;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class GAORGRTJVZA
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly DDIOKSFIFUQ YXJLQQKBYGV;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly DDIOKSFIFUQ VVBYVQPZMPB;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly DDIOKSFIFUQ AJCFSRTPCDD;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly DDIOKSFIFUQ FQDPNINEVMH;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class NZPTJTKZJZV
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly DDIOKSFIFUQ YXJLQQKBYGV;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly DDIOKSFIFUQ VVBYVQPZMPB;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly DDIOKSFIFUQ AJCFSRTPCDD;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly DDIOKSFIFUQ FQDPNINEVMH;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class FJXAYFJQXYO
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class NJZBUQVFBPF
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly DDIOKSFIFUQ CTINIDJCNOE;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly DDIOKSFIFUQ NIDNADFPQPC;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly DDIOKSFIFUQ KUYKNSFAIPO;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class BUIAPNYHXIS
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly DDIOKSFIFUQ ZAEQSXYJEJX;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly DDIOKSFIFUQ VIMXFJSCHUD;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly DDIOKSFIFUQ GCNEZXHEQRS;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class BIDQQUZFBCN
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class ZMQBYSSZBZW
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly DDIOKSFIFUQ CLBKPVRSUBS;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly DDIOKSFIFUQ PKLEFGVRYPA;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly DDIOKSFIFUQ UMPPDVXPBEJ;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly DDIOKSFIFUQ SCFDQQHADJX;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly DDIOKSFIFUQ RDAOVLTYCGI;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class LIRCFFSMJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly DDIOKSFIFUQ NXEYWVUTCJO;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class WAWJCPKRNPF
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly DDIOKSFIFUQ JHIEYOMBGRH;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly DDIOKSFIFUQ NKPJRNUZKOG;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly DDIOKSFIFUQ JRTKFOHUSPP;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class RMEBLGPVOGI
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class MZUJIKWBKSG
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class FTASRXYXAUV
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class ZMQFAUAFHAK
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly DDIOKSFIFUQ AGBDCQDHMDR;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly DDIOKSFIFUQ UFOUGCCFIXW;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly DDIOKSFIFUQ XOVHNREMDQK;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly DDIOKSFIFUQ JYWFIGSZCGG;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly DDIOKSFIFUQ BBNEBWUNUDT;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly DDIOKSFIFUQ ESPWBRFGEKD;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly DDIOKSFIFUQ KYIPBZTQYXO;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class SAWYEGPCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly DDIOKSFIFUQ NOHERGGWBPP;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly DDIOKSFIFUQ[] AXWNTMOWDGB;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class UGQRJRACSJQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly BCNDQRECDEP KFRSGFMXOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<DDIOKSFIFUQ> HIXJGAWKTKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<DDIOKSFIFUQ> PCSNSFFYFBU;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<DDIOKSFIFUQ> PPKXMMOJRUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<DDIOKSFIFUQ> GXKSMOBLAWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x299B7C0", Offset = "0x299A5C0", VA = "0x18299B7C0")]
		protected UGQRJRACSJQ(BCNDQRECDEP a, params DDIOKSFIFUQ[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class TDBPQHXJOJU : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2999B60", Offset = "0x2998960", VA = "0x182999B60")]
		internal TDBPQHXJOJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class NDWGPZWDQDJ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x29954B0", Offset = "0x29942B0", VA = "0x1829954B0")]
		internal NDWGPZWDQDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class BSVVMBMRSBQ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x298EDC0", Offset = "0x298DBC0", VA = "0x18298EDC0")]
		internal BSVVMBMRSBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ADEGCMZGAXB : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x298E210", Offset = "0x298D010", VA = "0x18298E210")]
		internal ADEGCMZGAXB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class DMPAQDKRAGE : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x298FDB0", Offset = "0x298EBB0", VA = "0x18298FDB0")]
		internal DMPAQDKRAGE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class QCIUASQZOHO : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2997BE0", Offset = "0x29969E0", VA = "0x182997BE0")]
		internal QCIUASQZOHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ZNILJMDOKSX : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x299F620", Offset = "0x299E420", VA = "0x18299F620")]
		internal ZNILJMDOKSX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class GTTKYSBIETI : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x29912D0", Offset = "0x29900D0", VA = "0x1829912D0")]
		internal GTTKYSBIETI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class KYGVICADLXG : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x29946D0", Offset = "0x29934D0", VA = "0x1829946D0")]
		internal KYGVICADLXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class FDYQVPZNKWU : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2990440", Offset = "0x298F240", VA = "0x182990440")]
		internal FDYQVPZNKWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RGCVUDYRFJG : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2998DC0", Offset = "0x2997BC0", VA = "0x182998DC0")]
		internal RGCVUDYRFJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ALEHIWNPCXO : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x298E5D0", Offset = "0x298D3D0", VA = "0x18298E5D0")]
		internal ALEHIWNPCXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class MZFIRTNATFS : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x29950C0", Offset = "0x2993EC0", VA = "0x1829950C0")]
		internal MZFIRTNATFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class XLUHFWXWECU : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x299DE70", Offset = "0x299CC70", VA = "0x18299DE70")]
		internal XLUHFWXWECU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class LHTBASCJTMO : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x29948B0", Offset = "0x29936B0", VA = "0x1829948B0")]
		internal LHTBASCJTMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class AZFMFMPHQZE : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x298E7B0", Offset = "0x298D5B0", VA = "0x18298E7B0")]
		internal AZFMFMPHQZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class QVOTHYQIAQG : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2997FA0", Offset = "0x2996DA0", VA = "0x182997FA0")]
		internal QVOTHYQIAQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class KJEXAFVEMNR : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2993A00", Offset = "0x2992800", VA = "0x182993A00")]
		internal KJEXAFVEMNR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class IMWTYFGEARH : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2992350", Offset = "0x2991150", VA = "0x182992350")]
		internal IMWTYFGEARH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class SFOHXJZBWIZ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2999980", Offset = "0x2998780", VA = "0x182999980")]
		internal SFOHXJZBWIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class TLEURUHPXJN : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2999F20", Offset = "0x2998D20", VA = "0x182999F20")]
		internal TLEURUHPXJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class FVCECRUSFLV : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2990950", Offset = "0x298F750", VA = "0x182990950")]
		internal FVCECRUSFLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class VAFEXFEMSZG : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x299B940", Offset = "0x299A740", VA = "0x18299B940")]
		internal VAFEXFEMSZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class BSVOFOJAOPT : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x298EBE0", Offset = "0x298D9E0", VA = "0x18298EBE0")]
		internal BSVOFOJAOPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class UGGPAHRWLJY : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x299B5E0", Offset = "0x299A3E0", VA = "0x18299B5E0")]
		internal UGGPAHRWLJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class RDJJTBTHCKF : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2998A00", Offset = "0x2997800", VA = "0x182998A00")]
		internal RDJJTBTHCKF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class BUHQAYNTBZN : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x298EFA0", Offset = "0x298DDA0", VA = "0x18298EFA0")]
		internal BUHQAYNTBZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LIJBBEZLQXT : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2994A90", Offset = "0x2993890", VA = "0x182994A90")]
		internal LIJBBEZLQXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class QQLYGPZYVFS : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2997DC0", Offset = "0x2996BC0", VA = "0x182997DC0")]
		internal QQLYGPZYVFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class NMYJXXXMWER : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2995BD0", Offset = "0x29949D0", VA = "0x182995BD0")]
		internal NMYJXXXMWER()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CIODHUXJLHG : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x298F7A0", Offset = "0x298E5A0", VA = "0x18298F7A0")]
		internal CIODHUXJLHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class UESELSNILWS : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x299B390", Offset = "0x299A190", VA = "0x18299B390")]
		internal UESELSNILWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class LKBJCKUPSCS : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2994EE0", Offset = "0x2993CE0", VA = "0x182994EE0")]
		internal LKBJCKUPSCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class KDOFOTYEXDH : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2993730", Offset = "0x2992530", VA = "0x182993730")]
		internal KDOFOTYEXDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class JVSMQDDRJVB : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2992BB0", Offset = "0x29919B0", VA = "0x182992BB0")]
		internal JVSMQDDRJVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class HDRLTUGIDZP : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2991AE0", Offset = "0x29908E0", VA = "0x182991AE0")]
		internal HDRLTUGIDZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class TTPDBJWANNA : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x299AED0", Offset = "0x2999CD0", VA = "0x18299AED0")]
		internal TTPDBJWANNA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class OUKKPMUAFFF : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2996920", Offset = "0x2995720", VA = "0x182996920")]
		internal OUKKPMUAFFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class RTBGLKEBOKH : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2999440", Offset = "0x2998240", VA = "0x182999440")]
		internal RTBGLKEBOKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class RPERCQOPJQQ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2999260", Offset = "0x2998060", VA = "0x182999260")]
		internal RPERCQOPJQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class VYINBYOSMGE : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x299C3A0", Offset = "0x299B1A0", VA = "0x18299C3A0")]
		internal VYINBYOSMGE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class DOZEPHJZGUY : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x298FF90", Offset = "0x298ED90", VA = "0x18298FF90")]
		internal DOZEPHJZGUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class TDFKOIGGHHV : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2999D40", Offset = "0x2998B40", VA = "0x182999D40")]
		internal TDFKOIGGHHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class TROCPXVFRZZ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x299AC80", Offset = "0x2999A80", VA = "0x18299AC80")]
		internal TROCPXVFRZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class JIJDPMIHQAQ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x29927F0", Offset = "0x29915F0", VA = "0x1829927F0")]
		internal JIJDPMIHQAQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class VCXZTIBKNLT : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x299BB20", Offset = "0x299A920", VA = "0x18299BB20")]
		internal VCXZTIBKNLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class CNTGGASMWFC : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x298F9F0", Offset = "0x298E7F0", VA = "0x18298F9F0")]
		internal CNTGGASMWFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ZALZSMSTUXZ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x299E520", Offset = "0x299D320", VA = "0x18299E520")]
		internal ZALZSMSTUXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class RNIEAPCQGMT : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2999080", Offset = "0x2997E80", VA = "0x182999080")]
		internal RNIEAPCQGMT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class JJFFJTXXBQM : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x29929D0", Offset = "0x29917D0", VA = "0x1829929D0")]
		internal JJFFJTXXBQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class ADLPNJADLYC : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x298E3F0", Offset = "0x298D1F0", VA = "0x18298E3F0")]
		internal ADLPNJADLYC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BSHTBTUCHAN : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x298EA00", Offset = "0x298D800", VA = "0x18298EA00")]
		internal BSHTBTUCHAN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class NRHHJKAXDDM : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2995E20", Offset = "0x2994C20", VA = "0x182995E20")]
		internal NRHHJKAXDDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class FOTUTTLOZIH : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2990700", Offset = "0x298F500", VA = "0x182990700")]
		internal FOTUTTLOZIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class XSOZMIQHAIT : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x299DF50", Offset = "0x299CD50", VA = "0x18299DF50")]
		internal XSOZMIQHAIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class TMCKYGWRGAB : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x299A180", Offset = "0x2998F80", VA = "0x18299A180")]
		internal TMCKYGWRGAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class CYSDYGBPUOP : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x298FBD0", Offset = "0x298E9D0", VA = "0x18298FBD0")]
		internal CYSDYGBPUOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class KNGHLOPHYRQ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x29944F0", Offset = "0x29932F0", VA = "0x1829944F0")]
		internal KNGHLOPHYRQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class HMXQFIQWPPD : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2991D40", Offset = "0x2990B40", VA = "0x182991D40")]
		internal HMXQFIQWPPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class RFYLKKZHHYR : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2998BE0", Offset = "0x29979E0", VA = "0x182998BE0")]
		internal RFYLKKZHHYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class PMFLJPQCMCQ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x29978B0", Offset = "0x29966B0", VA = "0x1829978B0")]
		internal PMFLJPQCMCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class ZHOTXSIXJUZ : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x299E700", Offset = "0x299D500", VA = "0x18299E700")]
		internal ZHOTXSIXJUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class CEBUYGJAQHS : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x298F640", Offset = "0x298E440", VA = "0x18298F640")]
		internal CEBUYGJAQHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class PNDZFKOLWFF : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2997A10", Offset = "0x2996810", VA = "0x182997A10")]
		internal PNDZFKOLWFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class DZHYCSIZIPP : UGQRJRACSJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2990170", Offset = "0x298EF70", VA = "0x182990170")]
		internal DZHYCSIZIPP()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, RRGXPRNQSZZ<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly BCNDQRECDEP Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
		private NamedType(string name, BCNDQRECDEP type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4B0", Offset = "0x28CA2B0", VA = "0x1828CB4B0")]
		public static NamedType New(string name, BCNDQRECDEP type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x29967A0", Offset = "0x29955A0", VA = "0x1829967A0")]
		public static bool QIDDWXQJPGU([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x29967A0", Offset = "0x29955A0", VA = "0x1829967A0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x29967A0", Offset = "0x29955A0", VA = "0x1829967A0")]
		public bool ZNVGUJHBSXE([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x29966F0", Offset = "0x29954F0", VA = "0x1829966F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x29967F0", Offset = "0x29955F0", VA = "0x1829967F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2996860", Offset = "0x2995660", VA = "0x182996860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x29966B0", Offset = "0x29954B0", VA = "0x1829966B0")]
		public string EUHWKHPKKEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x29968A0", Offset = "0x29956A0", VA = "0x1829968A0")]
		public string XBCUKAPJZAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x29967A0", Offset = "0x29955A0", VA = "0x1829967A0", Slot = "5")]
		private bool GUYYFJBQBDB([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface LNVUNUKFJTD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, WWZNUEBGASM>> MDBEZPKEWEE(CLHMCDDVOKO a, bool b);
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
