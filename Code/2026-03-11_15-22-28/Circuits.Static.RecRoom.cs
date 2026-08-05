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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2958F80", Offset = "0x2957F80", VA = "0x182958F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2958970", Offset = "0x2957970", VA = "0x182958970", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class DFNZIBEIFXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2955AA0", Offset = "0x2954AA0", VA = "0x182955AA0")]
		public static bool QLGDNPOTLKY(this GAOEGFJDZSW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2955BB0", Offset = "0x2954BB0", VA = "0x182955BB0")]
		public static bool QLGDNPOTLKY(this DARDYQFOVAR a)
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
			private readonly BKAMUOKSWTC _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
			public EVRequest(BKAMUOKSWTC staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class RUBVYDOCXKT
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<LZAMKLXVNII>, PUEQIKASKRL> DBKKOWMFPCM;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<LZAMKLXVNII>>? RLBLJWWSHDW;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<LZAMKLXVNII> AIOZOILKEEG;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<LZAMKLXVNII> BURVCPNOMAT;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<LZAMKLXVNII> MTTCPWICQJY;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<LZAMKLXVNII> PNQXXZCMCJB;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<LZAMKLXVNII> SJVPNFHKNPC;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<LZAMKLXVNII> SPZLNKWOSFV;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<LZAMKLXVNII> IWBLUJMOYTB;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<LZAMKLXVNII> TVGGGTPRLRF;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<LZAMKLXVNII> LBHEWDWWBDZ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<LZAMKLXVNII> JASDDPBWMIL;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<LZAMKLXVNII> WYQRQILSQDR;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<LZAMKLXVNII> OATPDLOBKGZ;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<LZAMKLXVNII> XPEUBPKTUZK;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<LZAMKLXVNII> OOIAPNRAFHC;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<LZAMKLXVNII> HINOTBVUDMK;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<LZAMKLXVNII> XGGXCNOBCAR;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<LZAMKLXVNII> HMAXVEFAFGA;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<LZAMKLXVNII> YOZOFOFBBRI;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<LZAMKLXVNII> GVEZCDQKIUF;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<LZAMKLXVNII> UUMGVTURSRE;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<LZAMKLXVNII> PTLXXTIAWSJ;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<LZAMKLXVNII> HTEUORQETTU;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<LZAMKLXVNII> UFHWCXRQGCK;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<LZAMKLXVNII> NNKPQAXROEZ;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<LZAMKLXVNII> ZNRZJWGHZAJ;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<LZAMKLXVNII> MGKRXALVSFS;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<LZAMKLXVNII> PGZPYTMHKBR;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<LZAMKLXVNII> RCFIEKFZJBS;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<LZAMKLXVNII> MQPXCATSNNO;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<LZAMKLXVNII> BNINACYALDE;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<LZAMKLXVNII> ENAWFCYBBPO;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<LZAMKLXVNII> NDYVUUDMAAR;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<LZAMKLXVNII> OPQZDTQEWBY;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<LZAMKLXVNII> AXPXKMMMKZA;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<LZAMKLXVNII> PZVQZDJDJUI;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<LZAMKLXVNII> DDHLVJJJWSZ;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<LZAMKLXVNII> GAJBXUZSAHM;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<LZAMKLXVNII> ZZCVCXERKNR;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<LZAMKLXVNII> XUIRFNKFBJF;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<LZAMKLXVNII> GGFFCIWNHOZ;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<LZAMKLXVNII> HJJUAKFAXWO;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<LZAMKLXVNII> UNHYLJMTPPI;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<LZAMKLXVNII> XQRJXANRAEP;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<LZAMKLXVNII> VNZCAUQDCYK;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<LZAMKLXVNII> BMZBXVRMKTG;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<LZAMKLXVNII> LNPELHLCNKK;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<LZAMKLXVNII> AXGOEQRVHAT;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<LZAMKLXVNII> VXLVKUAMDTB;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<LZAMKLXVNII> WVQCXFMSPKT;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<LZAMKLXVNII> BEVSEKCBPHY;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<LZAMKLXVNII> XVKKMJDPRXI;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<LZAMKLXVNII> TRHUFUXEDXV;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<LZAMKLXVNII> ADFGYCNJTWU;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<LZAMKLXVNII> IOMISPEOEOG;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<LZAMKLXVNII> KRLWEXMGTLP;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<LZAMKLXVNII> TZSGVQNWAKB;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<LZAMKLXVNII> YQBQTYCUDEB;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<LZAMKLXVNII> SAMILNJMCBL;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<LZAMKLXVNII> VIETHUKUZPG;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<LZAMKLXVNII> FSCJTXCJZPV;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<LZAMKLXVNII> XIVIVRLSKIN;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<LZAMKLXVNII> XNLGMQEDGAX;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<LZAMKLXVNII> RPWRVCNEEBO;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<LZAMKLXVNII> YOGLOLGFIQO;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<LZAMKLXVNII> VXNDHGXJFJH;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<LZAMKLXVNII> NVBYFQFCQUK;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<LZAMKLXVNII> UEUVASFEWTR;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<LZAMKLXVNII> KYPVOGJJQDH;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<LZAMKLXVNII> OPGODEYHQBB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<LZAMKLXVNII>, PUEQIKASKRL> OIRPJIURGKX
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2960120", Offset = "0x295F120", VA = "0x182960120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x295FED0", Offset = "0x295EED0", VA = "0x18295FED0")]
			public static PUEQIKASKRL IMUKJQYDCZL(Id32<LZAMKLXVNII> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2960170", Offset = "0x295F170", VA = "0x182960170")]
			public static bool VISBWMUJOQC(Id32<LZAMKLXVNII> id, [Out] PUEQIKASKRL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2960200", Offset = "0x295F200", VA = "0x182960200")]
			public static GAOEGFJDZSW XEXWWXNIWYY(Id32<LZAMKLXVNII> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x295FE40", Offset = "0x295EE40", VA = "0x18295FE40")]
			private static Id32<LZAMKLXVNII> BPSMAKIBARY(PUEQIKASKRL a, Id32<LZAMKLXVNII> id)
			{
				return default(Id32<LZAMKLXVNII>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x295FF50", Offset = "0x295EF50", VA = "0x18295FF50")]
			private static void LPLSQPBMUOE(Id32<LZAMKLXVNII> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class YNGKUWGMNGY
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<VAFNDYWQNCG, GAOEGFJDZSW?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
				private TypeRegistryFactory([In] IdUnsafeList<VAFNDYWQNCG, GAOEGFJDZSW?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2965DE0", Offset = "0x2964DE0", VA = "0x182965DE0")]
				public static TypeRegistryFactory UGFOPWHDXKA()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x29658C0", Offset = "0x29648C0", VA = "0x1829658C0")]
				public (ReadOnlyIdArray<VAFNDYWQNCG, GAOEGFJDZSW>, IReadOnlyDictionary<GAOEGFJDZSW, Id32<VAFNDYWQNCG>>) IPCXLVWHJHS()
				{
					return default((ReadOnlyIdArray<VAFNDYWQNCG, GAOEGFJDZSW>, IReadOnlyDictionary<GAOEGFJDZSW, Id32<VAFNDYWQNCG>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2965C60", Offset = "0x2964C60", VA = "0x182965C60")]
				public Id32<VAFNDYWQNCG> PCQTWZSOQBI(int a, GAOEGFJDZSW b)
				{
					return default(Id32<VAFNDYWQNCG>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2965C10", Offset = "0x2964C10", VA = "0x182965C10")]
				public Id32<VAFNDYWQNCG> Initialize(int id, GOKBNNYXGNP type, GOKBNNYXGNP factoryType)
				{
					return default(Id32<VAFNDYWQNCG>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class MNIGJQPJDRN
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<VAFNDYWQNCG> EGRDAKTAGNK
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2958AF0", Offset = "0x2957AF0", VA = "0x182958AF0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2958A70", Offset = "0x2957A70", VA = "0x182958A70")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<VAFNDYWQNCG> HKPRBHAWBMS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2958CB0", Offset = "0x2957CB0", VA = "0x182958CB0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2958C70", Offset = "0x2957C70", VA = "0x182958C70")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<VAFNDYWQNCG> XVEMEHWUJBH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2958A30", Offset = "0x2957A30", VA = "0x182958A30")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2958AB0", Offset = "0x2957AB0", VA = "0x182958AB0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<VAFNDYWQNCG> MLQNYAVNFQR
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2958C30", Offset = "0x2957C30", VA = "0x182958C30")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2958B70", Offset = "0x2957B70", VA = "0x182958B70")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<VAFNDYWQNCG> LXKNPYANKAF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x29589F0", Offset = "0x29579F0", VA = "0x1829589F0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2958BF0", Offset = "0x2957BF0", VA = "0x182958BF0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<VAFNDYWQNCG> WIIHITUPYHW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2958B30", Offset = "0x2957B30", VA = "0x182958B30")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2958BB0", Offset = "0x2957BB0", VA = "0x182958BB0")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class SNLIIBYKNMH : IEnumerable<GAOEGFJDZSW>, IEnumerable, IEnumerator<GAOEGFJDZSW>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int NNYUMBTASKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private GAOEGFJDZSW GLROCXYMSEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int CYUNKNWTKTU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool UJTUDXAKMJS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool HCODSMAKXZX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion CCMLTJPISIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion FORGHVMMSXP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool BLOTPBJGEHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool ZIRREIEYDPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool CLHAPBHORSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool NHNZUNTBPTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool KKTHETKGPMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool FBTIMRFEKAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool MBTFKGKCVMZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool GLBBDXWQPQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<GAOEGFJDZSW> NVXWRKLJBUP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private GAOEGFJDZSW KMDFHQPXSSU;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private GAOEGFJDZSW LQAVSYEZHAV
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object OPJHDGDZAVH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
				[DebuggerHidden]
				public SNLIIBYKNMH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x29638B0", Offset = "0x29628B0", VA = "0x1829638B0", Slot = "7")]
				[DebuggerHidden]
				private void FQZHCUDIKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2963A00", Offset = "0x2962A00", VA = "0x182963A00", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2963DF0", Offset = "0x2962DF0", VA = "0x182963DF0")]
				private void QJEWXGNEXZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2963E40", Offset = "0x2962E40", VA = "0x182963E40", Slot = "10")]
				[DebuggerHidden]
				private void SEWTXRYPVUP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2963940", Offset = "0x2962940", VA = "0x182963940", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<GAOEGFJDZSW> PXTGJSVDYVI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2963940", Offset = "0x2962940", VA = "0x182963940", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HKYUJZELIWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class GIOSXPXIBHP : IEnumerable<GAOEGFJDZSW>, IEnumerable, IEnumerator<GAOEGFJDZSW>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int NNYUMBTASKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private GAOEGFJDZSW GLROCXYMSEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int CYUNKNWTKTU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion CCMLTJPISIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion FORGHVMMSXP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool CLHAPBHORSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool NHNZUNTBPTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool BLOTPBJGEHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool ZIRREIEYDPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool JPZGLFVICPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool NKLRCHFZDTC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool KKTHETKGPMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool FBTIMRFEKAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool FXGBBITDSUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool TEXUPTTIMGL;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private GAOEGFJDZSW LQAVSYEZHAV
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object OPJHDGDZAVH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
				[DebuggerHidden]
				public GIOSXPXIBHP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
				[DebuggerHidden]
				private void FQZHCUDIKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2955D20", Offset = "0x2954D20", VA = "0x182955D20", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2957C30", Offset = "0x2956C30", VA = "0x182957C30", Slot = "10")]
				[DebuggerHidden]
				private void SEWTXRYPVUP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2955C70", Offset = "0x2954C70", VA = "0x182955C70", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<GAOEGFJDZSW> PXTGJSVDYVI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2955C70", Offset = "0x2954C70", VA = "0x182955C70", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HKYUJZELIWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class YEAOXGIHYNU : IEnumerable<Id32<VAFNDYWQNCG>>, IEnumerable, IEnumerator<Id32<VAFNDYWQNCG>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int NNYUMBTASKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<VAFNDYWQNCG> GLROCXYMSEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int CYUNKNWTKTU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion CCMLTJPISIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion FORGHVMMSXP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool BLOTPBJGEHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool ZIRREIEYDPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool CLHAPBHORSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool NHNZUNTBPTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool KKTHETKGPMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool FBTIMRFEKAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool MBTFKGKCVMZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool GLBBDXWQPQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<GAOEGFJDZSW> NVXWRKLJBUP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<GOKBNNYXGNP> NWDDORFGLFY;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<VAFNDYWQNCG> NTFKMULBQCG
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<VAFNDYWQNCG>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object OPJHDGDZAVH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2966BF0", Offset = "0x2965BF0", VA = "0x182966BF0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x13438E0", Offset = "0x13428E0", VA = "0x1813438E0")]
				[DebuggerHidden]
				public YEAOXGIHYNU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2966C40", Offset = "0x2965C40", VA = "0x182966C40", Slot = "7")]
				[DebuggerHidden]
				private void FQZHCUDIKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2966D90", Offset = "0x2965D90", VA = "0x182966D90", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2967290", Offset = "0x2966290", VA = "0x182967290")]
				private void QJEWXGNEXZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x29672E0", Offset = "0x29662E0", VA = "0x1829672E0")]
				private void QJURPAUXAHT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2967330", Offset = "0x2966330", VA = "0x182967330", Slot = "10")]
				[DebuggerHidden]
				private void SEWTXRYPVUP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2966B40", Offset = "0x2965B40", VA = "0x182966B40", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<VAFNDYWQNCG>> ESYNEAVCZSZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2966B40", Offset = "0x2965B40", VA = "0x182966B40", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HKYUJZELIWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log HRODLTCIOIP;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<VAFNDYWQNCG, GAOEGFJDZSW?> ANJQSGSYDPR;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<GAOEGFJDZSW, Id32<VAFNDYWQNCG>> FNNZFTZOZAD;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly DARDYQFOVAR EYHFHMEVNVQ;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly DARDYQFOVAR QBMIMVMDKWA;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<GAOEGFJDZSW> LXMKAADLHNQ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<GAOEGFJDZSW> NFDDMTVKUEF;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet JDIMPHMUQWM
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet MNQREBFJPSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet MYZWJBPPYDS
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xBD3770", Offset = "0xBD2770", VA = "0x180BD3770")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static GAOEGFJDZSW EGRDAKTAGNK
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x29682C0", Offset = "0x29672C0", VA = "0x1829682C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static GAOEGFJDZSW HKPRBHAWBMS
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x296AAB0", Offset = "0x2969AB0", VA = "0x18296AAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static GAOEGFJDZSW XVEMEHWUJBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x29675E0", Offset = "0x29665E0", VA = "0x1829675E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static GAOEGFJDZSW MLQNYAVNFQR
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x296A570", Offset = "0x2969570", VA = "0x18296A570")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static GAOEGFJDZSW HADPKRIUSZH
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2968960", Offset = "0x2967960", VA = "0x182968960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static GAOEGFJDZSW XKVEECVSEWK
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2969BD0", Offset = "0x2968BD0", VA = "0x182969BD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static GAOEGFJDZSW TXUPDFIFVPZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2969390", Offset = "0x2968390", VA = "0x182969390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static GAOEGFJDZSW LXKNPYANKAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x29673C0", Offset = "0x29663C0", VA = "0x1829673C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static GOKBNNYXGNP FJONESYBRQX
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2969C60", Offset = "0x2968C60", VA = "0x182969C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static GOKBNNYXGNP LZMSREGLJLW
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2969020", Offset = "0x2968020", VA = "0x182969020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static GOKBNNYXGNP VTHFLWCOLJR
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2969A10", Offset = "0x2968A10", VA = "0x182969A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static GOKBNNYXGNP OIKZEFBGXGT
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x296AF80", Offset = "0x2969F80", VA = "0x18296AF80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static GOKBNNYXGNP BCPVRTDTOEH
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x29685F0", Offset = "0x29675F0", VA = "0x1829685F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static GOKBNNYXGNP QTWVMMDJGDG
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2967670", Offset = "0x2966670", VA = "0x182967670")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static GOKBNNYXGNP XAFSYMLLKTA
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x29699C0", Offset = "0x29689C0", VA = "0x1829699C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static GOKBNNYXGNP IETHXGSVQSA
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x296AEE0", Offset = "0x2969EE0", VA = "0x18296AEE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static GOKBNNYXGNP FIONGKETHLR
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x296AFD0", Offset = "0x2969FD0", VA = "0x18296AFD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static GOKBNNYXGNP HSKFOQOTARN
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2967DA0", Offset = "0x2966DA0", VA = "0x182967DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static GOKBNNYXGNP ALYGWRIJFVK
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2969D50", Offset = "0x2968D50", VA = "0x182969D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static GOKBNNYXGNP FAEKAGUWOXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x29674F0", Offset = "0x29664F0", VA = "0x1829674F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static GOKBNNYXGNP MMCCLLZHEOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2969B50", Offset = "0x2968B50", VA = "0x182969B50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static GOKBNNYXGNP NFTMICQOHXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2967DF0", Offset = "0x2966DF0", VA = "0x182967DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static GOKBNNYXGNP QBCVJEGBWIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2969510", Offset = "0x2968510", VA = "0x182969510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static GOKBNNYXGNP EWHEOMCETQB
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2968350", Offset = "0x2967350", VA = "0x182968350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static GOKBNNYXGNP NVDHXCXEWRI
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29690D0", VA = "0x18296A0D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static GOKBNNYXGNP YVFJXLKKDVU
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x29689F0", Offset = "0x29679F0", VA = "0x1829689F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static GOKBNNYXGNP WLUKQYYIBHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x296A600", Offset = "0x2969600", VA = "0x18296A600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static GOKBNNYXGNP JBFLZGWJPWG
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2969970", Offset = "0x2968970", VA = "0x182969970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static GOKBNNYXGNP DLMVLEQWZHF
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2969A60", Offset = "0x2968A60", VA = "0x182969A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static GOKBNNYXGNP MCHXBILTNOW
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2968C60", Offset = "0x2967C60", VA = "0x182968C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static GOKBNNYXGNP GMTQKICCIIE
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2967AD0", Offset = "0x2966AD0", VA = "0x182967AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static GOKBNNYXGNP VJXNKDTDJAE
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x29684B0", Offset = "0x29674B0", VA = "0x1829684B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static GOKBNNYXGNP ZOZPKGWWBXO
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x29685A0", Offset = "0x29675A0", VA = "0x1829685A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static GOKBNNYXGNP FMNQSWQQMWH
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2969DF0", Offset = "0x2968DF0", VA = "0x182969DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static GOKBNNYXGNP HSUSJEMTZFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2968910", Offset = "0x2967910", VA = "0x182968910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static GOKBNNYXGNP NQJCABEFXIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2967E40", Offset = "0x2966E40", VA = "0x182967E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static GOKBNNYXGNP XJVNXHEFFLC
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2969B00", Offset = "0x2968B00", VA = "0x182969B00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static GOKBNNYXGNP DLQJAPFNQIR
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x296AE90", Offset = "0x2969E90", VA = "0x18296AE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static GOKBNNYXGNP HTPXEDSGCCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x296A2B0", Offset = "0x29692B0", VA = "0x18296A2B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static GOKBNNYXGNP UZHGITDXVRW
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x296A650", Offset = "0x2969650", VA = "0x18296A650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static GOKBNNYXGNP SAHXRNCXTAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x29690C0", Offset = "0x29680C0", VA = "0x1829690C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static GOKBNNYXGNP MBUGPWFAXSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x296AD50", Offset = "0x2969D50", VA = "0x18296AD50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static GOKBNNYXGNP ZYPDSFUBWWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2967A80", Offset = "0x2966A80", VA = "0x182967A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static GOKBNNYXGNP HQSETYWTEZH
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2968780", Offset = "0x2967780", VA = "0x182968780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static GOKBNNYXGNP CHETYZNEILJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2969200", Offset = "0x2968200", VA = "0x182969200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static GOKBNNYXGNP FBVUQRYEDEW
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x29694C0", Offset = "0x29684C0", VA = "0x1829694C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static GOKBNNYXGNP YKITAESDUMU
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2969560", Offset = "0x2968560", VA = "0x182969560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static GOKBNNYXGNP NCREDFCOXUJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2969070", Offset = "0x2968070", VA = "0x182969070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static GOKBNNYXGNP WMPWRDGHAKR
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2968E90", Offset = "0x2967E90", VA = "0x182968E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static GOKBNNYXGNP QESGNIQPEVD
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2968550", Offset = "0x2967550", VA = "0x182968550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static GOKBNNYXGNP LULRDKIHONR
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2968690", Offset = "0x2967690", VA = "0x182968690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static GOKBNNYXGNP MAISITIBYJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2967540", Offset = "0x2966540", VA = "0x182967540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static GOKBNNYXGNP TJGSCAIQIFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x296ADA0", Offset = "0x2969DA0", VA = "0x18296ADA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static GOKBNNYXGNP VLYGQYVPEDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2967D50", Offset = "0x2966D50", VA = "0x182967D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static GOKBNNYXGNP STILSANEAAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x296A1C0", Offset = "0x29691C0", VA = "0x18296A1C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static GOKBNNYXGNP APGRMPZYLYE
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2968870", Offset = "0x2967870", VA = "0x182968870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static GOKBNNYXGNP OXQJLHPGVXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2968DF0", Offset = "0x2967DF0", VA = "0x182968DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static GOKBNNYXGNP VBCSNXDCVXX
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x29692A0", Offset = "0x29682A0", VA = "0x1829692A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static GOKBNNYXGNP OOFERZBJZVB
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2968C10", Offset = "0x2967C10", VA = "0x182968C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static GOKBNNYXGNP QWKIOBAZPUB
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x29674A0", Offset = "0x29664A0", VA = "0x1829674A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static GOKBNNYXGNP EYDWKSPEUUW
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2969FE0", Offset = "0x2968FE0", VA = "0x182969FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static GOKBNNYXGNP UJNJVNUOUSV
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2969E40", Offset = "0x2968E40", VA = "0x182969E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static GOKBNNYXGNP IGFXSUNOEMM
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x296A170", Offset = "0x2969170", VA = "0x18296A170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static GOKBNNYXGNP PQFVUVTFMCQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x29686E0", Offset = "0x29676E0", VA = "0x1829686E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static GOKBNNYXGNP RLPTAEEIUCO
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2967E90", Offset = "0x2966E90", VA = "0x182967E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static GOKBNNYXGNP ISQNSUCKFXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2968FD0", Offset = "0x2967FD0", VA = "0x182968FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static GOKBNNYXGNP HSQYBCGONBX
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x296A300", Offset = "0x2969300", VA = "0x18296A300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static GOKBNNYXGNP MRGWDSUVCCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2967590", Offset = "0x2966590", VA = "0x182967590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static GOKBNNYXGNP ELUISOZOLZV
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x29692F0", Offset = "0x29682F0", VA = "0x1829692F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static GOKBNNYXGNP CIAKKRPQLDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x296AD00", Offset = "0x2969D00", VA = "0x18296AD00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static GOKBNNYXGNP ANNSWFVXGME
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x296AF30", Offset = "0x2969F30", VA = "0x18296AF30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static GOKBNNYXGNP HADAQDFUAQB
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2969F40", Offset = "0x2968F40", VA = "0x182969F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static GOKBNNYXGNP DXZVKRYLYAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x296A120", Offset = "0x2969120", VA = "0x18296A120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static GOKBNNYXGNP KRGKFTJJJOI
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2968500", Offset = "0x2967500", VA = "0x182968500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static GOKBNNYXGNP MBSKEDUWLAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x296AB90", Offset = "0x2969B90", VA = "0x18296AB90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static GOKBNNYXGNP MSIQSWJNPHA
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2969250", Offset = "0x2968250", VA = "0x182969250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static GOKBNNYXGNP YKDRYVMDENT
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x29691B0", Offset = "0x29681B0", VA = "0x1829691B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static GOKBNNYXGNP GKLWETALFNN
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x29683A0", Offset = "0x29673A0", VA = "0x1829683A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static GOKBNNYXGNP YHBHXHMPRAX
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2967370", Offset = "0x2966370", VA = "0x182967370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static GOKBNNYXGNP UDYWTZUNBFK
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x296A260", Offset = "0x2969260", VA = "0x18296A260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static GOKBNNYXGNP BNIAHGYZSRN
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x296ADF0", Offset = "0x2969DF0", VA = "0x18296ADF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static GOKBNNYXGNP OYSRJZXOEQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2969110", Offset = "0x2968110", VA = "0x182969110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static GOKBNNYXGNP DEVKFFUQCUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2967B20", Offset = "0x2966B20", VA = "0x182967B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static GOKBNNYXGNP YEZBCQMFKEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x296ABE0", Offset = "0x2969BE0", VA = "0x18296ABE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static GOKBNNYXGNP UIXASBQCHYF
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2968CB0", Offset = "0x2967CB0", VA = "0x182968CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static GOKBNNYXGNP OZYPWNLNIIU
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2968820", Offset = "0x2967820", VA = "0x182968820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static GOKBNNYXGNP EBCIQBRZQVK
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2968460", Offset = "0x2967460", VA = "0x182968460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static GOKBNNYXGNP IQICRJHPVPZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2968F30", Offset = "0x2967F30", VA = "0x182968F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static GOKBNNYXGNP IQAZWCTZYQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x296AB40", Offset = "0x2969B40", VA = "0x18296AB40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static GOKBNNYXGNP KQLNHYFECQE
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2969160", Offset = "0x2968160", VA = "0x182969160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static GOKBNNYXGNP CMWUMTMNEFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2968A70", Offset = "0x2967A70", VA = "0x182968A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static GOKBNNYXGNP EYTXYRVOKNM
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2969AB0", Offset = "0x2968AB0", VA = "0x182969AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static GOKBNNYXGNP UKTVRKWDXKW
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2967A30", Offset = "0x2966A30", VA = "0x182967A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static GOKBNNYXGNP RBTPLTXUKQM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2968D00", Offset = "0x2967D00", VA = "0x182968D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static GOKBNNYXGNP DGWJUMFPBLG
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2968D50", Offset = "0x2967D50", VA = "0x182968D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static GOKBNNYXGNP DTUGKTKEUBE
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x296A520", Offset = "0x2969520", VA = "0x18296A520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static GOKBNNYXGNP THDTEBISFVD
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x296A350", Offset = "0x2969350", VA = "0x18296A350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static GOKBNNYXGNP GYJPUZHBIKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2967C50", Offset = "0x2966C50", VA = "0x182967C50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static GOKBNNYXGNP NCGHTTFYCUX
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2968BC0", Offset = "0x2967BC0", VA = "0x182968BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static GOKBNNYXGNP YUMGZIKGASI
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2969DA0", Offset = "0x2968DA0", VA = "0x182969DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static GOKBNNYXGNP DMIHZQCIIYX
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x296B020", Offset = "0x296A020", VA = "0x18296B020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static GOKBNNYXGNP QLAGGVKPLOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x296AE40", Offset = "0x2969E40", VA = "0x18296AE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static GOKBNNYXGNP UAIMDJEPXHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2969CB0", Offset = "0x2968CB0", VA = "0x182969CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static GOKBNNYXGNP SMTVSCOUJEL
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2968270", Offset = "0x2967270", VA = "0x182968270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static GOKBNNYXGNP BOWIIWFIBNU
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2968E40", Offset = "0x2967E40", VA = "0x182968E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static GOKBNNYXGNP OSITRCCXQUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x296A030", Offset = "0x2969030", VA = "0x18296A030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static GOKBNNYXGNP KUZUXSSMDWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x296AC30", Offset = "0x2969C30", VA = "0x18296AC30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static GOKBNNYXGNP YEWAMHIFHYS
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x29679E0", Offset = "0x29669E0", VA = "0x1829679E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static GOKBNNYXGNP YUXBULIHJNE
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x29688C0", Offset = "0x29678C0", VA = "0x1829688C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static GOKBNNYXGNP VPORKOXFSAT
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2969340", Offset = "0x2968340", VA = "0x182969340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static GOKBNNYXGNP ASPOBFPOWZU
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x296A210", Offset = "0x2969210", VA = "0x18296A210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static GOKBNNYXGNP RAQFUPKJVKC
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2968B70", Offset = "0x2967B70", VA = "0x182968B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static GOKBNNYXGNP NPGJWDRRHBR
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2968DA0", Offset = "0x2967DA0", VA = "0x182968DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static GOKBNNYXGNP VRBFMHZVOYO
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2969D00", Offset = "0x2968D00", VA = "0x182969D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static GOKBNNYXGNP JPGSWZHOVPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2969470", Offset = "0x2968470", VA = "0x182969470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static GOKBNNYXGNP WNOWFSBEGXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x29676C0", Offset = "0x29666C0", VA = "0x1829676C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static GOKBNNYXGNP ONYXMHECXHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x296A080", Offset = "0x2969080", VA = "0x18296A080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static GOKBNNYXGNP BXGKLQMCASJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2967450", Offset = "0x2966450", VA = "0x182967450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static GOKBNNYXGNP GQKBXVJQEWL
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2969F90", Offset = "0x2968F90", VA = "0x182969F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static GOKBNNYXGNP PWMUECZKUDK
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x29687D0", Offset = "0x29677D0", VA = "0x1829687D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static GOKBNNYXGNP OTRUGNTNTOD
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2968F80", Offset = "0x2967F80", VA = "0x182968F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static GOKBNNYXGNP AXWKYEWNTIR
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2969420", Offset = "0x2968420", VA = "0x182969420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static GOKBNNYXGNP OHGQJCTCFMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x296A4D0", Offset = "0x29694D0", VA = "0x18296A4D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static GOKBNNYXGNP BZLYEZVQBSW
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x29695B0", Offset = "0x29685B0", VA = "0x1829695B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static GOKBNNYXGNP QDBMMLTFXNI
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2968EE0", Offset = "0x2967EE0", VA = "0x182968EE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static GOKBNNYXGNP AVFALCYYTCU
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2968730", Offset = "0x2967730", VA = "0x182968730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static GOKBNNYXGNP QDNASDMVVQR
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2968640", Offset = "0x2967640", VA = "0x182968640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2968180", Offset = "0x2967180", VA = "0x182968180")]
			public static DARDYQFOVAR EJGENWQLRGZ([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2967B70", Offset = "0x2966B70", VA = "0x182967B70")]
			public static ClassFactoryTypeParams DJFQHNSFUMU(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2967C20", Offset = "0x2966C20", VA = "0x182967C20")]
			public static ClassFactoryTypeParams DJFQHNSFUMU([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2968A40", Offset = "0x2967A40", VA = "0x182968A40")]
			public static DARDYQFOVAR HPNLPVBKYET(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2969BA0", Offset = "0x2968BA0", VA = "0x182969BA0")]
			public static DARDYQFOVAR RJLMBPFWCZY(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x296A3A0", Offset = "0x29693A0", VA = "0x18296A3A0")]
			public static DARDYQFOVAR WIIHITUPYHW([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x296A980", Offset = "0x2969980", VA = "0x18296A980")]
			public static GAOEGFJDZSW XEXWWXNIWYY(Id32<VAFNDYWQNCG> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x296AC80", Offset = "0x2969C80", VA = "0x18296AC80")]
			public static string YJOGHMHRZUP(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x296A6A0", Offset = "0x29696A0", VA = "0x18296A6A0")]
			private static GAOEGFJDZSW XEXWWXNIWYY(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x29683F0", Offset = "0x29673F0", VA = "0x1829683F0")]
			public static Id32<VAFNDYWQNCG>? EWOFHCWPLSB(GAOEGFJDZSW a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2969600", Offset = "0x2968600", VA = "0x182969600")]
			public static CircuitTypeIdWrapper? PTEFLHHTHUE(GAOEGFJDZSW a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x296B070", Offset = "0x296A070", VA = "0x18296B070")]
			static YNGKUWGMNGY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2968AC0", Offset = "0x2967AC0", VA = "0x182968AC0")]
			[IteratorStateMachine(typeof(GIOSXPXIBHP))]
			private static IEnumerable<GAOEGFJDZSW> INNIFMPZGAM(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2967CA0", Offset = "0x2966CA0", VA = "0x182967CA0")]
			[IteratorStateMachine(typeof(SNLIIBYKNMH))]
			public static IEnumerable<GAOEGFJDZSW> DKLSDXMECLT(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2967EE0", Offset = "0x2966EE0", VA = "0x182967EE0")]
			public static Variant EILIOMPBDOS(GAOEGFJDZSW a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2967710", Offset = "0x2966710", VA = "0x182967710")]
			public static Variant CGZNOLWLFVJ(GAOEGFJDZSW a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x296AA30", Offset = "0x2969A30", VA = "0x18296AA30")]
			public static bool XISVWZXVLSF(GAOEGFJDZSW a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2969E90", Offset = "0x2968E90", VA = "0x182969E90")]
			[IteratorStateMachine(typeof(YEAOXGIHYNU))]
			public static IEnumerable<Id32<VAFNDYWQNCG>> SKZLSYJNCJJ(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class BBHOCUPGMYP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2952E80", Offset = "0x2951E80", VA = "0x182952E80")]
		public static BOJVLZOKLOO XRHSQBYDVHR(this GAOEGFJDZSW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2952370", Offset = "0x2951370", VA = "0x182952370")]
		public static GAOEGFJDZSW WLZQZCXXIAC(this BOJVLZOKLOO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class THAQRLFCOHS
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC010", Offset = "0x3AFB010", VA = "0x183AFC010")]
		public static Dictionary<b, c> VYCKHXBSMSK<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class TEPHKHXSVMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2964500", Offset = "0x2963500", VA = "0x182964500")]
		public static WEXVHTEMEBY XRHSQBYDVHR([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2964460", Offset = "0x2963460", VA = "0x182964460")]
		public static Guid WLZQZCXXIAC(WEXVHTEMEBY a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RXGCQQQVBRX
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29631A0", Offset = "0x29621A0", VA = "0x1829631A0")]
		public static FLKAPKFGYYQ XRHSQBYDVHR([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2963140", Offset = "0x2962140", VA = "0x182963140")]
		public static NamedType WLZQZCXXIAC(this FLKAPKFGYYQ a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class CDNKDUUAGAW
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x34E68D0", Offset = "0x34E58D0", VA = "0x1834E68D0")]
		public static void BVLMYMWUNUY<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x34E6B30", Offset = "0x34E5B30", VA = "0x1834E6B30")]
		public static void BVLMYMWUNUY<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class SUFDHTCLSEV
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2964260", Offset = "0x2963260", VA = "0x182964260")]
		public static HLBYZMTLXOQ XRHSQBYDVHR([In] this Variant self, GAOEGFJDZSW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2964110", Offset = "0x2963110", VA = "0x182964110")]
		public static Variant WLZQZCXXIAC(this HLBYZMTLXOQ a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class TKYBDBIEFDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<ZPAUJTIQWQZ> MLRHXBCEJQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool MOGVOWXBGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool YAKZGFIQLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool AZLZKKNHBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool MNSBUBKCZXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool MNXIRIEAJIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool RAJTWIXOSKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool TBKRICSSNZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool QGMGLEXTSJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, GAOEGFJDZSW Type)> KPZBTMPFXQR;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid TXKKVYGLDVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x29198A0", Offset = "0x29188A0", VA = "0x1829198A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<ZPAUJTIQWQZ> GFNJMLGEUKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x29198A0", Offset = "0x29188A0", VA = "0x1829198A0")]
			get
			{
				return default(Id128<ZPAUJTIQWQZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, GAOEGFJDZSW Type)> HHNUKTTFTFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action VZNAKQQDVYL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2964600", Offset = "0x2963600", VA = "0x182964600")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2965620", Offset = "0x2964620", VA = "0x182965620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, GAOEGFJDZSW> EGNABSNMUMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2965420", Offset = "0x2964420", VA = "0x182965420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2965020", Offset = "0x2964020", VA = "0x182965020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CUPSIMMJOOX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2965170", Offset = "0x2964170", VA = "0x182965170")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x29656C0", Offset = "0x29646C0", VA = "0x1829656C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> ZEXCEYQSHLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2965570", Offset = "0x2964570", VA = "0x182965570")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2965220", Offset = "0x2964220", VA = "0x182965220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, GAOEGFJDZSW> UBIUMAYHKWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x29646A0", Offset = "0x29636A0", VA = "0x1829646A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2964970", Offset = "0x2963970", VA = "0x182964970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action JJREOBOHMVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x29650D0", Offset = "0x29640D0", VA = "0x1829650D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x29654D0", Offset = "0x29644D0", VA = "0x1829654D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18F3FD0", Offset = "0x18F2FD0", VA = "0x1818F3FD0")]
		public void UBEIMJMQCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2965770", Offset = "0x2964770", VA = "0x182965770")]
		internal TKYBDBIEFDB([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, GAOEGFJDZSW Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2965350", Offset = "0x2964350", VA = "0x182965350")]
		public static CircuitEventDefinitionFactoryStart UGFOPWHDXKA(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x29652D0", Offset = "0x29642D0", VA = "0x1829652D0")]
		public static CircuitEventDefinitionFactoryStart UGFOPWHDXKA(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2964F10", Offset = "0x2963F10", VA = "0x182964F10")]
		public static TKYBDBIEFDB LSZTHHARCOA([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2964B10", Offset = "0x2963B10", VA = "0x182964B10")]
		public static TKYBDBIEFDB FAIIZNKUATI([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xC9D7E0", Offset = "0xC9C7E0", VA = "0x180C9D7E0")]
		public void CJIIMKMOZFE(Id128<ZPAUJTIQWQZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2964EB0", Offset = "0x2963EB0", VA = "0x182964EB0")]
		public void IOOYOHZUFFP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2964DC0", Offset = "0x2963DC0", VA = "0x182964DC0")]
		public void HSPASLADSIF(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2964A20", Offset = "0x2963A20", VA = "0x182964A20")]
		public void DXOHARMCSOC(int a, GAOEGFJDZSW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2964750", Offset = "0x2963750", VA = "0x182964750")]
		public void BFOBZBITALE(string a, GAOEGFJDZSW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2964D50", Offset = "0x2963D50", VA = "0x182964D50")]
		public void GIBVHVQFTMD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2964870", Offset = "0x2963870", VA = "0x182964870")]
		public TKYBDBIEFDB Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2954630", Offset = "0x2953630", VA = "0x182954630")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x29544C0", Offset = "0x29534C0", VA = "0x1829544C0")]
		public CircuitEventDefinitionFactoryParams UHRKQZTUSHW(string a, GAOEGFJDZSW b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2954390", Offset = "0x2953390", VA = "0x182954390")]
		public TKYBDBIEFDB IPCXLVWHJHS()
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
		private readonly List<(string Name, GAOEGFJDZSW Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2954300", Offset = "0x2953300", VA = "0x182954300")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, GAOEGFJDZSW Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29541D0", Offset = "0x29531D0", VA = "0x1829541D0")]
		public CircuitEventDefinitionFactoryParams UHRKQZTUSHW(string a, GAOEGFJDZSW b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x29540D0", Offset = "0x29530D0", VA = "0x1829540D0")]
		public TKYBDBIEFDB IPCXLVWHJHS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class UJXLMNYKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly TKYBDBIEFDB CJKNBHWIZGZ;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly TKYBDBIEFDB MDZGMXQGGXY;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly TKYBDBIEFDB GTJANPCQJQR;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly TKYBDBIEFDB TPQZBASUZKW;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly TKYBDBIEFDB IWRKODCKNIV;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly TKYBDBIEFDB OIKMNQUNCWR;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly TKYBDBIEFDB TDLEFIDMOLQ;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly TKYBDBIEFDB[] KDUYJWAOSTZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class BURVCPNOMAT
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly TKYBDBIEFDB XASYHMENNXH;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class MTTCPWICQJY
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly TKYBDBIEFDB TEIWJJQHANZ;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly TKYBDBIEFDB WVIFHSKSAHK;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class XNLGMQEDGAX
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly TKYBDBIEFDB KMVTJXLKNNO;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly TKYBDBIEFDB WFHFHEKCVMZ;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly TKYBDBIEFDB[] WTREXITRVYP;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly TKYBDBIEFDB GKBXARTDZFN;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly TKYBDBIEFDB XBJYHSOBHCS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class AXGOEQRVHAT
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly TKYBDBIEFDB OTQAJLFCFVE;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly TKYBDBIEFDB WPSPWLCCXYP;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class SJVPNFHKNPC
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly TKYBDBIEFDB ZCLNVRFOVRZ;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly TKYBDBIEFDB OVWQSPSISOO;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class SPZLNKWOSFV
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly TKYBDBIEFDB TEIWJJQHANZ;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly TKYBDBIEFDB WVIFHSKSAHK;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class IWBLUJMOYTB
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly TKYBDBIEFDB QBKEPIIRAHU;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly TKYBDBIEFDB VNKVTDLXOAR;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly TKYBDBIEFDB REMCDJNWWTV;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly TKYBDBIEFDB WRQAEGGJCGX;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly TKYBDBIEFDB IVUQBDDRIJG;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly TKYBDBIEFDB VFWZUUMAWWN;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly TKYBDBIEFDB RWGCNWOAWEE;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class TVGGGTPRLRF
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class LBHEWDWWBDZ
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class XUIRFNKFBJF
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class JASDDPBWMIL
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly TKYBDBIEFDB HPQPGYDMJWM;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly TKYBDBIEFDB YIICREYYPNX;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class KRLWEXMGTLP
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class WYQRQILSQDR
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class OATPDLOBKGZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class LNPELHLCNKK
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly TKYBDBIEFDB GBNJGJPUCMI;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly TKYBDBIEFDB EWNIPEHSYMY;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly TKYBDBIEFDB FMGCLXIDKNX;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly TKYBDBIEFDB KMVONIMPCIG;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly TKYBDBIEFDB HHZBXYFPKRI;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly TKYBDBIEFDB ZCLNVRFOVRZ;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly TKYBDBIEFDB GZOZZQDCPHI;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly TKYBDBIEFDB CHGMSSMOBLB;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly TKYBDBIEFDB OWDRWZZUDJL;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly TKYBDBIEFDB CODVQVIQRFR;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly TKYBDBIEFDB KXGWPORWKCF;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly TKYBDBIEFDB HTCRGVXMRYD;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly TKYBDBIEFDB UFFUQSJKJKU;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly TKYBDBIEFDB WKKNZUTEPYZ;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly TKYBDBIEFDB XVIJUEGYSPO;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly TKYBDBIEFDB HXAENFCSXYE;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly TKYBDBIEFDB OZOQKKRIRWG;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly TKYBDBIEFDB JHWLBFMBXNF;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly TKYBDBIEFDB YWTSIYUFEZY;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly TKYBDBIEFDB OWCSTPRHZMQ;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly TKYBDBIEFDB GPITOHUCEPV;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly TKYBDBIEFDB JSIVSGTAQWD;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly TKYBDBIEFDB UAGIBKJRPAT;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly TKYBDBIEFDB OGFLHIMWIIL;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly TKYBDBIEFDB XNJJQFRVHLD;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly TKYBDBIEFDB ZGQJWIZXYLL;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly TKYBDBIEFDB VCFUGVJTGSZ;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly TKYBDBIEFDB VHIJQLRESBH;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly TKYBDBIEFDB HPLHNASDZII;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly TKYBDBIEFDB GYTEZGWJKUM;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly TKYBDBIEFDB OZJLVFSGMJL;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly TKYBDBIEFDB NVPYZBZDQAJ;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly TKYBDBIEFDB COHSRDXEPQU;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly TKYBDBIEFDB PINWBOFEUHK;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly TKYBDBIEFDB CSVXOKAMPLG;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly TKYBDBIEFDB BUGGYUGPKSM;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly TKYBDBIEFDB MHNVJJARSMY;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly TKYBDBIEFDB KZYWNWTOSTQ;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly TKYBDBIEFDB GZIITDQBXUG;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly TKYBDBIEFDB ZRZGETMQBWC;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly TKYBDBIEFDB UHPKHETVSFH;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly TKYBDBIEFDB EXQWDEWARDP;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly TKYBDBIEFDB YDPUXPDNGPZ;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly TKYBDBIEFDB XTAWOMDWITL;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly TKYBDBIEFDB ZMBCBLAMOKD;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly TKYBDBIEFDB INZNFVIICJF;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly TKYBDBIEFDB SLIWCPGGIXT;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly TKYBDBIEFDB AUELUVDONDJ;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly TKYBDBIEFDB HUZOYFHYEWJ;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly TKYBDBIEFDB VWEKDVQVAAP;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly TKYBDBIEFDB BDQLOILFYBU;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly TKYBDBIEFDB KCKRBJOMNND;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly TKYBDBIEFDB GIEEZOABOIR;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly TKYBDBIEFDB VPCWUHSBFMZ;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly TKYBDBIEFDB SAUUDCCVWWT;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly TKYBDBIEFDB QUCHTWDZHDX;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly TKYBDBIEFDB VPWCUAQAUJF;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly TKYBDBIEFDB LUIUEYEBGVV;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly TKYBDBIEFDB BEHHLDZBXNT;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly TKYBDBIEFDB ZMDEKPTCJFF;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly TKYBDBIEFDB SFBYLNFEBLT;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly TKYBDBIEFDB UIAUEEPRINN;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly TKYBDBIEFDB AWRGTZKMTJE;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly TKYBDBIEFDB CSAPBBFKHEZ;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly TKYBDBIEFDB EAJUFWHFAUN;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly TKYBDBIEFDB UEKLJHHBTEQ;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly TKYBDBIEFDB PVCXMJMITKY;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly TKYBDBIEFDB HPTTFRKJVLV;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly TKYBDBIEFDB QYEPJIVJNZF;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class OOIAPNRAFHC
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class VSCUJTOCBTT
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly TKYBDBIEFDB RHNWCGUGHYL;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly TKYBDBIEFDB MFQWONLAKWY;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly TKYBDBIEFDB CZIDXCIYTUQ;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly TKYBDBIEFDB LRXEGWLSPFB;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly TKYBDBIEFDB YYQQTLYREVJ;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly TKYBDBIEFDB HQEDWOPKQXD;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly TKYBDBIEFDB CLYGXFBOQID;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class DQMBOLITPXC
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly TKYBDBIEFDB EWNIPEHSYMY;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly TKYBDBIEFDB FMGCLXIDKNX;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly TKYBDBIEFDB KMVONIMPCIG;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly TKYBDBIEFDB ZHLHBBHLQEU;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly TKYBDBIEFDB CQMJGGGTIPW;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly TKYBDBIEFDB URSEZXPHASA;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly TKYBDBIEFDB WSAQUYLYQJO;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class HINOTBVUDMK
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly TKYBDBIEFDB IWWNVNUOMGG;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly TKYBDBIEFDB AALEYYYQZLO;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly TKYBDBIEFDB XLTNPCVYYPX;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly TKYBDBIEFDB HMQZNLGMNHJ;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly TKYBDBIEFDB JRJMVKBNCDX;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly TKYBDBIEFDB IBVPSGXMSGZ;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class XGGXCNOBCAR
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class HMAXVEFAFGA
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly TKYBDBIEFDB JCZSNJFUFRE;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class YOZOFOFBBRI
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly TKYBDBIEFDB GBNJGJPUCMI;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class GVEZCDQKIUF
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class UUMGVTURSRE
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class XQRJXANRAEP
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly TKYBDBIEFDB CIBAGKHAOQR;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly TKYBDBIEFDB JAJRRERJGOX;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly TKYBDBIEFDB CCYOIPTHZLQ;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly TKYBDBIEFDB LCQVLFYELIC;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class PTLXXTIAWSJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly TKYBDBIEFDB ONZZUWHKHSK;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly TKYBDBIEFDB MCQDIAEMXVN;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class NNKPQAXROEZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class UYOKKWFRMKV
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly TKYBDBIEFDB RHNWCGUGHYL;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly TKYBDBIEFDB MFQWONLAKWY;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class HTEUORQETTU
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly TKYBDBIEFDB LOYAHXJVRYF;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly TKYBDBIEFDB LRXEGWLSPFB;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly TKYBDBIEFDB YYQQTLYREVJ;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly TKYBDBIEFDB HQEDWOPKQXD;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly TKYBDBIEFDB IPIKXZQJWMC;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly TKYBDBIEFDB KWTHRLHNJJB;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly TKYBDBIEFDB SJYGEAAAZLJ;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly TKYBDBIEFDB VXWGNYCXHPD;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly TKYBDBIEFDB JQJURDPYRQS;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly TKYBDBIEFDB BIKOCBJOECC;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly TKYBDBIEFDB RHNWCGUGHYL;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly TKYBDBIEFDB MFQWONLAKWY;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class UFHWCXRQGCK
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class VNZCAUQDCYK
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly TKYBDBIEFDB RHNWCGUGHYL;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly TKYBDBIEFDB MFQWONLAKWY;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly TKYBDBIEFDB OIKQCRQOFOM;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly TKYBDBIEFDB XHRVKWLTTYK;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly TKYBDBIEFDB ZVSPVYVFSKZ;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class ZNRZJWGHZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class ADFGYCNJTWU
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly TKYBDBIEFDB KEFXELMBBJT;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class MGKRXALVSFS
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly TKYBDBIEFDB MVFFVYTFOJO;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly TKYBDBIEFDB FXZDMKLSPNP;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly TKYBDBIEFDB RHNWCGUGHYL;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly TKYBDBIEFDB MFQWONLAKWY;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class PGZPYTMHKBR
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class DTVLHJOEJRZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class RCFIEKFZJBS
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class MQPXCATSNNO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class VXNDHGXJFJH
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class CGBVXSYQQTP
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly TKYBDBIEFDB HPQPGYDMJWM;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly TKYBDBIEFDB YIICREYYPNX;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class ZZCVCXERKNR
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly TKYBDBIEFDB URQRDGYIIAG;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly TKYBDBIEFDB SHTQNTUCLNC;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly TKYBDBIEFDB DYDDHBLXYGY;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly TKYBDBIEFDB JGBZHGMZIMK;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class ENAWFCYBBPO
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly TKYBDBIEFDB URQRDGYIIAG;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly TKYBDBIEFDB SHTQNTUCLNC;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly TKYBDBIEFDB DYDDHBLXYGY;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly TKYBDBIEFDB JGBZHGMZIMK;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class NDYVUUDMAAR
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class XVKKMJDPRXI
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly TKYBDBIEFDB VQPMYTREKHP;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly TKYBDBIEFDB LZNXEQANEIP;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly TKYBDBIEFDB ELIUOAWXJFN;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class AJWAYZHULQP
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly TKYBDBIEFDB SVBYREMPQXK;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly TKYBDBIEFDB QKPUXWEACKK;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly TKYBDBIEFDB QQOLSRNIAGL;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class OPQZDTQEWBY
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class TRHUFUXEDXV
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly TKYBDBIEFDB MMDNNHKSFNZ;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly TKYBDBIEFDB KOFJLPKSYNX;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly TKYBDBIEFDB LYERHMCXIFA;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly TKYBDBIEFDB PHWZLRUFJVA;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly TKYBDBIEFDB VHWLCTNHTXB;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class AXPXKMMMKZA
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly TKYBDBIEFDB USNABAVTDCH;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class PZVQZDJDJUI
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly TKYBDBIEFDB KYORKWLIZNI;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly TKYBDBIEFDB WRTOPKDIANJ;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly TKYBDBIEFDB VWAWYPKVRBI;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class DDHLVJJJWSZ
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class SAMILNJMCBL
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class VIETHUKUZPG
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class WVQCXFMSPKT
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly TKYBDBIEFDB YXWNTEEYDZW;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly TKYBDBIEFDB EQYMSQCLIBX;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly TKYBDBIEFDB CJXGSOYMAIH;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly TKYBDBIEFDB USKLVWMJAIH;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly TKYBDBIEFDB COJYQYDRBNO;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly TKYBDBIEFDB EVPFVUKXYHA;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly TKYBDBIEFDB SYPPQRKGPGF;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class OPGODEYHQBB
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly TKYBDBIEFDB VMQLNIXEOXI;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly TKYBDBIEFDB[] BGTDFOJJXSK;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class PUEQIKASKRL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly GAOEGFJDZSW KVNJGVHJZTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<TKYBDBIEFDB> ZMKVYWPXLJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<TKYBDBIEFDB> BZOMTVCJRZD;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<TKYBDBIEFDB> CXECQEXYIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<TKYBDBIEFDB> WTXNTSCCNLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x297BC00", Offset = "0x297AC00", VA = "0x18297BC00")]
		protected PUEQIKASKRL(GAOEGFJDZSW a, params TKYBDBIEFDB[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class QLSRYYHQXAP : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x297C820", Offset = "0x297B820", VA = "0x18297C820")]
		internal QLSRYYHQXAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class RCXMLOOCSYU : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x297CDF0", Offset = "0x297BDF0", VA = "0x18297CDF0")]
		internal RCXMLOOCSYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class RZXEQXTNKYP : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x297D2E0", Offset = "0x297C2E0", VA = "0x18297D2E0")]
		internal RZXEQXTNKYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class MWHHFUBHUEQ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2979F90", Offset = "0x2978F90", VA = "0x182979F90")]
		internal MWHHFUBHUEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class WESVTWQMNQH : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2980690", Offset = "0x297F690", VA = "0x182980690")]
		internal WESVTWQMNQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class TWYMKAVSWYH : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x297E580", Offset = "0x297D580", VA = "0x18297E580")]
		internal TWYMKAVSWYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class XUVWMCNTTIG : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2981900", Offset = "0x2980900", VA = "0x182981900")]
		internal XUVWMCNTTIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class IAEEAJCQBUH : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2978040", Offset = "0x2977040", VA = "0x182978040")]
		internal IAEEAJCQBUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class XCXBJMTGPVF : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2980E90", Offset = "0x297FE90", VA = "0x182980E90")]
		internal XCXBJMTGPVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class TQCYRBBFEDJ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x297DA60", Offset = "0x297CA60", VA = "0x18297DA60")]
		internal TQCYRBBFEDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class NIEDUXIFOGL : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x297A390", Offset = "0x2979390", VA = "0x18297A390")]
		internal NIEDUXIFOGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class NAAQOECGKXZ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x297A160", Offset = "0x2979160", VA = "0x18297A160")]
		internal NAAQOECGKXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class CSAJJIJSVDV : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2973310", Offset = "0x2972310", VA = "0x182973310")]
		internal CSAJJIJSVDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class USCHVCNRFOV : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x297EBB0", Offset = "0x297DBB0", VA = "0x18297EBB0")]
		internal USCHVCNRFOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class BHPIZUUKYMF : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2972800", Offset = "0x2971800", VA = "0x182972800")]
		internal BHPIZUUKYMF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class RXWASLZAAOH : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x297CF40", Offset = "0x297BF40", VA = "0x18297CF40")]
		internal RXWASLZAAOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class LQOPKIDURSJ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x29790A0", Offset = "0x29780A0", VA = "0x1829790A0")]
		internal LQOPKIDURSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class LKGAGNOKHZK : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2978D00", Offset = "0x2977D00", VA = "0x182978D00")]
		internal LKGAGNOKHZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class MSGEPFVEMEC : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2979DC0", Offset = "0x2978DC0", VA = "0x182979DC0")]
		internal MSGEPFVEMEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class IOBKINBJWRS : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x29783E0", Offset = "0x29773E0", VA = "0x1829783E0")]
		internal IOBKINBJWRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class NVFTZLPOSNQ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x297A790", Offset = "0x2979790", VA = "0x18297A790")]
		internal NVFTZLPOSNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class UUUYPEAJJBU : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x297ECF0", Offset = "0x297DCF0", VA = "0x18297ECF0")]
		internal UUUYPEAJJBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class YHBUUBABHOJ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2982050", Offset = "0x2981050", VA = "0x182982050")]
		internal YHBUUBABHOJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class GDAMSNLWGOS : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x29758D0", Offset = "0x29748D0", VA = "0x1829758D0")]
		internal GDAMSNLWGOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class UGZIVTXFYYN : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x297E810", Offset = "0x297D810", VA = "0x18297E810")]
		internal UGZIVTXFYYN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class BNONWOTLGJG : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x29729D0", Offset = "0x29719D0", VA = "0x1829729D0")]
		internal BNONWOTLGJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class HNYIPJWLOQW : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x29771B0", Offset = "0x29761B0", VA = "0x1829771B0")]
		internal HNYIPJWLOQW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class NTZAHWAUOKY : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x297A5C0", Offset = "0x29795C0", VA = "0x18297A5C0")]
		internal NTZAHWAUOKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class RBNSITENTWJ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x297CBC0", Offset = "0x297BBC0", VA = "0x18297CBC0")]
		internal RBNSITENTWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class MLGHBZHCJAA : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x29799C0", Offset = "0x29789C0", VA = "0x1829799C0")]
		internal MLGHBZHCJAA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class MNVKWXPXMDN : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2979B90", Offset = "0x2978B90", VA = "0x182979B90")]
		internal MNVKWXPXMDN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class NZZZRNTFBXP : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x297AD80", Offset = "0x2979D80", VA = "0x18297AD80")]
		internal NZZZRNTFBXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class UJZJEVWIJOV : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x297E9E0", Offset = "0x297D9E0", VA = "0x18297E9E0")]
		internal UJZJEVWIJOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class QKBXWCBIRZG : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x297C5D0", Offset = "0x297B5D0", VA = "0x18297C5D0")]
		internal QKBXWCBIRZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class VCZLBASVKIM : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x297F310", Offset = "0x297E310", VA = "0x18297F310")]
		internal VCZLBASVKIM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class DVORHSIHABW : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2974AA0", Offset = "0x2973AA0", VA = "0x182974AA0")]
		internal DVORHSIHABW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class RZNOKIZCUZX : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x297D110", Offset = "0x297C110", VA = "0x18297D110")]
		internal RZNOKIZCUZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class QBLIEWCEUTU : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x297C1B0", Offset = "0x297B1B0", VA = "0x18297C1B0")]
		internal QBLIEWCEUTU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class NYNYFHTTXBU : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x297A9E0", Offset = "0x29799E0", VA = "0x18297A9E0")]
		internal NYNYFHTTXBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class VTWWZKJCUNV : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2980460", Offset = "0x297F460", VA = "0x182980460")]
		internal VTWWZKJCUNV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class KBDHYPENYFR : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2978B30", Offset = "0x2977B30", VA = "0x182978B30")]
		internal KBDHYPENYFR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class JYAONWSRWZB : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2978960", Offset = "0x2977960", VA = "0x182978960")]
		internal JYAONWSRWZB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class WITIYAWIHZY : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2980860", Offset = "0x297F860", VA = "0x182980860")]
		internal WITIYAWIHZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PHQESPSQLTY : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x297B690", Offset = "0x297A690", VA = "0x18297B690")]
		internal PHQESPSQLTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class IKPWDOSLGMR : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2978210", Offset = "0x2977210", VA = "0x182978210")]
		internal IKPWDOSLGMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class TGXMICSFKSQ : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x297D570", Offset = "0x297C570", VA = "0x18297D570")]
		internal TGXMICSFKSQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class CHAYWDQJIMP : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2973140", Offset = "0x2972140", VA = "0x182973140")]
		internal CHAYWDQJIMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ITYDHUQNVNY : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x29785C0", Offset = "0x29775C0", VA = "0x1829785C0")]
		internal ITYDHUQNVNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class QUWUQVBJKNC : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x297C9F0", Offset = "0x297B9F0", VA = "0x18297C9F0")]
		internal QUWUQVBJKNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class QHAHVRQMITH : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x297C400", Offset = "0x297B400", VA = "0x18297C400")]
		internal QHAHVRQMITH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class LLQZKPOGNPX : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2978ED0", Offset = "0x2977ED0", VA = "0x182978ED0")]
		internal LLQZKPOGNPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class LROMJOUEQJO : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2979270", Offset = "0x2978270", VA = "0x182979270")]
		internal LROMJOUEQJO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class EWGCHSXHJVL : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2975360", Offset = "0x2974360", VA = "0x182975360")]
		internal EWGCHSXHJVL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class DGCPSYVILAU : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2973540", Offset = "0x2972540", VA = "0x182973540")]
		internal DGCPSYVILAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class JVUYKXZENIW : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2978790", Offset = "0x2977790", VA = "0x182978790")]
		internal JVUYKXZENIW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class HEFCYPAUCLU : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x29764A0", Offset = "0x29754A0", VA = "0x1829764A0")]
		internal HEFCYPAUCLU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class CAGLEHGMNFA : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2972BA0", Offset = "0x2971BA0", VA = "0x182972BA0")]
		internal CAGLEHGMNFA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class EYZCRMCIAVX : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2975530", Offset = "0x2974530", VA = "0x182975530")]
		internal EYZCRMCIAVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class TQCWOMMRLZC : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x297D890", Offset = "0x297C890", VA = "0x18297D890")]
		internal TQCWOMMRLZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class FXEVFTZRQXE : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2975700", Offset = "0x2974700", VA = "0x182975700")]
		internal FXEVFTZRQXE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class TIOPSRFRNKB : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x297D740", Offset = "0x297C740", VA = "0x18297D740")]
		internal TIOPSRFRNKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class GJLHJOSXLVY : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2975AA0", Offset = "0x2974AA0", VA = "0x182975AA0")]
		internal GJLHJOSXLVY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class NZFAHENQHGT : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x297AC30", Offset = "0x2979C30", VA = "0x18297AC30")]
		internal NZFAHENQHGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class OVASVFRABFO : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x297B4E0", Offset = "0x297A4E0", VA = "0x18297B4E0")]
		internal OVASVFRABFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class GTBUFYVTVSS : PUEQIKASKRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2975BF0", Offset = "0x2974BF0", VA = "0x182975BF0")]
		internal GTBUFYVTVSS()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, MMKZQVOZTVS<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly GAOEGFJDZSW Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
		private NamedType(string name, GAOEGFJDZSW type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28B08E0", Offset = "0x28AF8E0", VA = "0x1828B08E0")]
		public static NamedType New(string name, GAOEGFJDZSW type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x297B000", Offset = "0x297A000", VA = "0x18297B000")]
		public static bool JNIBMGTXNLH([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x297B000", Offset = "0x297A000", VA = "0x18297B000", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x297B000", Offset = "0x297A000", VA = "0x18297B000")]
		public bool YOXYRJFNIZD([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x297AF50", Offset = "0x2979F50", VA = "0x18297AF50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x297B050", Offset = "0x297A050", VA = "0x18297B050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x297B180", Offset = "0x297A180", VA = "0x18297B180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x297B0C0", Offset = "0x297A0C0", VA = "0x18297B0C0")]
		public string RANIRBTCNOR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x297B100", Offset = "0x297A100", VA = "0x18297B100")]
		public string THDBDGLQENP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x297B000", Offset = "0x297A000", VA = "0x18297B000", Slot = "5")]
		private bool TDYBLJTFZEA([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface BKAMUOKSWTC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, WENLUTALDTF>> TDXULBVXUUN(PQYWNUACEKJ a, bool b);
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
