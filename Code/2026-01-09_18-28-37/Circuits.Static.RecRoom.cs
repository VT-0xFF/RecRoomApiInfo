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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x29003A0", Offset = "0x28FF7A0", VA = "0x1829003A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2900170", Offset = "0x28FF570", VA = "0x182900170", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class BATUMAKPFYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28FB5B0", Offset = "0x28FA9B0", VA = "0x1828FB5B0")]
		public static bool HWCRAJGDHPF(this QNRWKFGEPMB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28FB4F0", Offset = "0x28FA8F0", VA = "0x1828FB4F0")]
		public static bool HWCRAJGDHPF(this RMUCOODOUOA a)
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
			private readonly AEMOPZBEDBJ _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			public EVRequest(AEMOPZBEDBJ staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class SRZVZBZWVCS
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<EWERHEIKSRX>, ISPMZIZOVTK> OVDGVHKPWOT;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<EWERHEIKSRX>>? GNBIGJYZVUT;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<EWERHEIKSRX> EOKEKJSFPTH;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<EWERHEIKSRX> EFRLETEASKC;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<EWERHEIKSRX> WLVHKXPHEAZ;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<EWERHEIKSRX> ZJOLBOSTNZC;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<EWERHEIKSRX> WXWYEWSCBPD;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<EWERHEIKSRX> CKGIRSCYNQG;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<EWERHEIKSRX> ZIMZKCSCUVS;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<EWERHEIKSRX> QZYMYSGGRZS;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<EWERHEIKSRX> GAEHNLXKRMQ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<EWERHEIKSRX> VWBGNSXVPRS;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<EWERHEIKSRX> JZHAXBTRRVY;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<EWERHEIKSRX> GEJLXKSPEYK;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<EWERHEIKSRX> DCGNFZELCBR;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<EWERHEIKSRX> FBWWWJEPSHP;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<EWERHEIKSRX> JUCPDGQMOYV;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<EWERHEIKSRX> WIIMBVCSHBE;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<EWERHEIKSRX> JVPRFMGSYMB;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<EWERHEIKSRX> LTOSVSVMKWH;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<EWERHEIKSRX> XEQRBTPRCMY;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<EWERHEIKSRX> UZTEBCCDVBJ;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<EWERHEIKSRX> UODIYFFZPXE;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<EWERHEIKSRX> CIYTVWCWSZJ;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<EWERHEIKSRX> DEADEJWAQRD;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<EWERHEIKSRX> MNPWGWICFDY;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<EWERHEIKSRX> DGGZWMAGEYG;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<EWERHEIKSRX> DMLSCHGADAR;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<EWERHEIKSRX> UZGYLEKGMLS;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<EWERHEIKSRX> TQGEGWLPJSV;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<EWERHEIKSRX> WFMSWCAQWTX;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<EWERHEIKSRX> NMONARNURXB;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<EWERHEIKSRX> UXBTKREBBGJ;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<EWERHEIKSRX> QGFITZJXVPC;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<EWERHEIKSRX> RXEDTUOIUXV;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<EWERHEIKSRX> YMENSEJKUZD;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<EWERHEIKSRX> ISVUVCZYNRL;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<EWERHEIKSRX> RHEYSRHOURE;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<EWERHEIKSRX> AYVAEZPVBAX;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<EWERHEIKSRX> QJBJNFXCWBC;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<EWERHEIKSRX> MNZXTLFNWOY;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<EWERHEIKSRX> IXMVVNXVDIU;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<EWERHEIKSRX> IJTTIKUCEQL;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<EWERHEIKSRX> HKDNNHDCEXR;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<EWERHEIKSRX> EIRUMNUWYZO;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<EWERHEIKSRX> ESAVLJWKELR;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<EWERHEIKSRX> IXVSXDHXZFB;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<EWERHEIKSRX> LYQOKIXSDWN;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<EWERHEIKSRX> FNXMZWDAPGU;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<EWERHEIKSRX> JEOBKUSIIYC;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<EWERHEIKSRX> MGDIHGLPSNG;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<EWERHEIKSRX> IOZADYMNSKB;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<EWERHEIKSRX> MJPKTPMSNAZ;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<EWERHEIKSRX> CWTYPJVMMWW;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<EWERHEIKSRX> GFAJDYMESGF;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<EWERHEIKSRX> HXQKSPZZMKD;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<EWERHEIKSRX> NMKJPPBKZTE;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<EWERHEIKSRX> HKVUSWNRMIA;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<EWERHEIKSRX> LEDHVPSNHEU;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<EWERHEIKSRX> OQUYLSOAPCI;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<EWERHEIKSRX> HKWPDOTCDUD;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<EWERHEIKSRX> BIUTFBPRUNU;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<EWERHEIKSRX> BHATOHMEXZO;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<EWERHEIKSRX> IZRGZPYDNCY;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<EWERHEIKSRX> UBJSBTQXKMD;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<EWERHEIKSRX> AJWEFQNEKZL;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<EWERHEIKSRX> EMDRWRXDAFK;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<EWERHEIKSRX> JTCASVEUEFV;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<EWERHEIKSRX> DQRFQDPHOJO;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<EWERHEIKSRX> ZELYVXUMMOO;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<EWERHEIKSRX> QDGZZWQJBRO;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<EWERHEIKSRX>, ISPMZIZOVTK> MYQEEXUNZAE
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2907600", Offset = "0x2906A00", VA = "0x182907600")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2907320", Offset = "0x2906720", VA = "0x182907320")]
			public static ISPMZIZOVTK DMOOSDPOHFW(Id32<EWERHEIKSRX> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2907650", Offset = "0x2906A50", VA = "0x182907650")]
			public static bool RRHKDZLTGGF(Id32<EWERHEIKSRX> id, [Out] ISPMZIZOVTK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x29076E0", Offset = "0x2906AE0", VA = "0x1829076E0")]
			public static QNRWKFGEPMB XZIBOUKVTOZ(Id32<EWERHEIKSRX> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2907570", Offset = "0x2906970", VA = "0x182907570")]
			private static Id32<EWERHEIKSRX> MKOAUOREKWX(ISPMZIZOVTK a, Id32<EWERHEIKSRX> id)
			{
				return default(Id32<EWERHEIKSRX>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x29073A0", Offset = "0x29067A0", VA = "0x1829073A0")]
			private static void GVVOVMRIVBB(Id32<EWERHEIKSRX> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class AFLSZOTCOOV
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<UWVMSGKSREJ, QNRWKFGEPMB?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
				private TypeRegistryFactory([In] IdUnsafeList<UWVMSGKSREJ, QNRWKFGEPMB?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x290C100", Offset = "0x290B500", VA = "0x18290C100")]
				public static TypeRegistryFactory LUYAJHASGOD()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x290C2E0", Offset = "0x290B6E0", VA = "0x18290C2E0")]
				public (ReadOnlyIdArray<UWVMSGKSREJ, QNRWKFGEPMB>, IReadOnlyDictionary<QNRWKFGEPMB, Id32<UWVMSGKSREJ>>) SMCVKRDMXBZ()
				{
					return default((ReadOnlyIdArray<UWVMSGKSREJ, QNRWKFGEPMB>, IReadOnlyDictionary<QNRWKFGEPMB, Id32<UWVMSGKSREJ>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x290C160", Offset = "0x290B560", VA = "0x18290C160")]
				public Id32<UWVMSGKSREJ> OEDMZZFWHBL(int a, QNRWKFGEPMB b)
				{
					return default(Id32<UWVMSGKSREJ>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x290C0B0", Offset = "0x290B4B0", VA = "0x18290C0B0")]
				public Id32<UWVMSGKSREJ> Initialize(int id, WYQCGJGFTYO type, WYQCGJGFTYO factoryType)
				{
					return default(Id32<UWVMSGKSREJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class IBTJNUGLHPK
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<UWVMSGKSREJ> HCJKYGTINID
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x28FF770", Offset = "0x28FEB70", VA = "0x1828FF770")]
					[CompilerGenerated]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x28FF7F0", Offset = "0x28FEBF0", VA = "0x1828FF7F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<UWVMSGKSREJ> UGICZMEZNJB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x28FF6B0", Offset = "0x28FEAB0", VA = "0x1828FF6B0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x28FF6F0", Offset = "0x28FEAF0", VA = "0x1828FF6F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<UWVMSGKSREJ> TENINZOZMUM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x28FF930", Offset = "0x28FED30", VA = "0x1828FF930")]
					[CompilerGenerated]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x28FF830", Offset = "0x28FEC30", VA = "0x1828FF830")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<UWVMSGKSREJ> SSFZFZDGUOK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x28FF870", Offset = "0x28FEC70", VA = "0x1828FF870")]
					[CompilerGenerated]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x28FF8F0", Offset = "0x28FECF0", VA = "0x1828FF8F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<UWVMSGKSREJ> MRFRIXDBFFY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x28FF730", Offset = "0x28FEB30", VA = "0x1828FF730")]
					[CompilerGenerated]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x28FF8B0", Offset = "0x28FECB0", VA = "0x1828FF8B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<UWVMSGKSREJ> JYFDYCRGQVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x28FF970", Offset = "0x28FED70", VA = "0x1828FF970")]
					[CompilerGenerated]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x28FF7B0", Offset = "0x28FEBB0", VA = "0x1828FF7B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class VPALXZWNAIW : IEnumerable<QNRWKFGEPMB>, IEnumerable, IEnumerator<QNRWKFGEPMB>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private QNRWKFGEPMB FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int QYTMAKYNUQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool XEEFYGHFWBF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool FNWAKPXHCKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion UEYWPMVSLSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion JRJVJNRKFBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool USHUWZAWIJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool GDQXATRCSBZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool OJYXELKJLEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool WDDBGTRZXQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool SGZNSIOMLXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool CRIHFZXLZWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool BEOGPFASEHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool FWFHSQPURGB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<QNRWKFGEPMB> DJOJRFZZVTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private QNRWKFGEPMB RXAIZLATNKL;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private QNRWKFGEPMB VEAVFEKHLJI
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
				[DebuggerHidden]
				public VPALXZWNAIW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x290EB70", Offset = "0x290DF70", VA = "0x18290EB70", Slot = "7")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x290ED00", Offset = "0x290E100", VA = "0x18290ED00", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x290F0F0", Offset = "0x290E4F0", VA = "0x18290F0F0")]
				private void UOGOWTTYZFR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x290EC00", Offset = "0x290E000", VA = "0x18290EC00", Slot = "10")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x290EC40", Offset = "0x290E040", VA = "0x18290EC40", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QNRWKFGEPMB> UKHMWDEGSJP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x290EC40", Offset = "0x290E040", VA = "0x18290EC40", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KHITEENQWKX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class ULNEWUFVQYA : IEnumerable<QNRWKFGEPMB>, IEnumerable, IEnumerator<QNRWKFGEPMB>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private QNRWKFGEPMB FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int QYTMAKYNUQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion UEYWPMVSLSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion JRJVJNRKFBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool OJYXELKJLEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool WDDBGTRZXQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool USHUWZAWIJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool GDQXATRCSBZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool GEYVRGEKCVY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool OXHHNMFPAYX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool SGZNSIOMLXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool CRIHFZXLZWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool PLFUXDEBEJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool QRSZUOUEFVE;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private QNRWKFGEPMB VEAVFEKHLJI
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
				[DebuggerHidden]
				public ULNEWUFVQYA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x290CC60", Offset = "0x290C060", VA = "0x18290CC60", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x290CB70", Offset = "0x290BF70", VA = "0x18290CB70", Slot = "10")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x290CBB0", Offset = "0x290BFB0", VA = "0x18290CBB0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QNRWKFGEPMB> UKHMWDEGSJP()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x290CBB0", Offset = "0x290BFB0", VA = "0x18290CBB0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KHITEENQWKX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class TCSBDNFFQXR : IEnumerable<Id32<UWVMSGKSREJ>>, IEnumerable, IEnumerator<Id32<UWVMSGKSREJ>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<UWVMSGKSREJ> FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int QYTMAKYNUQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion UEYWPMVSLSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion JRJVJNRKFBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool USHUWZAWIJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool GDQXATRCSBZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool OJYXELKJLEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool WDDBGTRZXQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool SGZNSIOMLXW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool CRIHFZXLZWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool BEOGPFASEHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool FWFHSQPURGB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<QNRWKFGEPMB> DJOJRFZZVTY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<WYQCGJGFTYO> DJJCTZGCMIP;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<UWVMSGKSREJ> AIVKEVGLOFH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xB2FE10", Offset = "0xB2F210", VA = "0x180B2FE10", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<UWVMSGKSREJ>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x290B880", Offset = "0x290AC80", VA = "0x18290B880", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x12D7E00", Offset = "0x12D7200", VA = "0x1812D7E00")]
				[DebuggerHidden]
				public TCSBDNFFQXR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x290B8D0", Offset = "0x290ACD0", VA = "0x18290B8D0", Slot = "7")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x290BB10", Offset = "0x290AF10", VA = "0x18290BB10", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x290C010", Offset = "0x290B410", VA = "0x18290C010")]
				private void UOGOWTTYZFR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x290C060", Offset = "0x290B460", VA = "0x18290C060")]
				private void UOLVUANWIRA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x290BA20", Offset = "0x290AE20", VA = "0x18290BA20", Slot = "10")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x290BA60", Offset = "0x290AE60", VA = "0x18290BA60", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<UWVMSGKSREJ>> VEGRONYCNKO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x290BA60", Offset = "0x290AE60", VA = "0x18290BA60", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KHITEENQWKX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log UMMIJRFVMAQ;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<UWVMSGKSREJ, QNRWKFGEPMB?> NDOOQZAQIYC;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<QNRWKFGEPMB, Id32<UWVMSGKSREJ>> OQGEPIQRCAK;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly RMUCOODOUOA PNDFWIKOTQP;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly RMUCOODOUOA BQQKAHXTENJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<QNRWKFGEPMB> LHPHGOFWGKB;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<QNRWKFGEPMB> ITMIQFKVVPC;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet YWDTWQGJCRD
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet MDMTKTCXBKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet DBEIAKVBVPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DF50", VA = "0x180B6EB50")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static QNRWKFGEPMB HCJKYGTINID
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x28F1A10", Offset = "0x28F0E10", VA = "0x1828F1A10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static QNRWKFGEPMB UGICZMEZNJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x28F0E60", Offset = "0x28F0260", VA = "0x1828F0E60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static QNRWKFGEPMB TENINZOZMUM
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x28F3280", Offset = "0x28F2680", VA = "0x1828F3280")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static QNRWKFGEPMB SSFZFZDGUOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x28F2A80", Offset = "0x28F1E80", VA = "0x1828F2A80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static QNRWKFGEPMB JOLFMJEOBWA
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x28F2330", Offset = "0x28F1730", VA = "0x1828F2330")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static QNRWKFGEPMB KHTGDNMRQVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x28F2770", Offset = "0x28F1B70", VA = "0x1828F2770")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static QNRWKFGEPMB VHULCQLCKTA
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x28F2410", Offset = "0x28F1810", VA = "0x1828F2410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static QNRWKFGEPMB MRFRIXDBFFY
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x28F1120", Offset = "0x28F0520", VA = "0x1828F1120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static WYQCGJGFTYO LUIXQBXTMQK
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x28F1BE0", Offset = "0x28F0FE0", VA = "0x1828F1BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static WYQCGJGFTYO UWSGJTSCLEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28F31E0", Offset = "0x28F25E0", VA = "0x1828F31E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static WYQCGJGFTYO HJXFHPIYPNQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x28F33B0", Offset = "0x28F27B0", VA = "0x1828F33B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static WYQCGJGFTYO KSUGUBJDJXS
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x28F0EF0", Offset = "0x28F02F0", VA = "0x1828F0EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static WYQCGJGFTYO FFJJLKKNWYM
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x28F1AF0", Offset = "0x28F0EF0", VA = "0x1828F1AF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static WYQCGJGFTYO UTHEFWPULUP
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x28F2CF0", Offset = "0x28F20F0", VA = "0x1828F2CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static WYQCGJGFTYO SUWCPURLJIX
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x28F2C50", Offset = "0x28F2050", VA = "0x1828F2C50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static WYQCGJGFTYO PAIZHFMARJJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x28F30A0", Offset = "0x28F24A0", VA = "0x1828F30A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static WYQCGJGFTYO TTYAMYUTKTE
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x28F3810", Offset = "0x28F2C10", VA = "0x1828F3810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static WYQCGJGFTYO WCQFBPEODJU
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x28F1430", Offset = "0x28F0830", VA = "0x1828F1430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static WYQCGJGFTYO VVMDETOAVZL
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x28F0D20", Offset = "0x28F0120", VA = "0x1828F0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static WYQCGJGFTYO EJOZDHORLXZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x28F0C80", Offset = "0x28F0080", VA = "0x1828F0C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static WYQCGJGFTYO NMNFHHTXHUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x28F3860", Offset = "0x28F2C60", VA = "0x1828F3860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static WYQCGJGFTYO BRFHVNASIEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x28F2FA0", Offset = "0x28F23A0", VA = "0x1828F2FA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static WYQCGJGFTYO IYRXFFHDXHY
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x28F39C0", Offset = "0x28F2DC0", VA = "0x1828F39C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static WYQCGJGFTYO XLMFHTESEIW
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x28F1920", Offset = "0x28F0D20", VA = "0x1828F1920")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static WYQCGJGFTYO UWCDMGAEAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x28F1250", Offset = "0x28F0650", VA = "0x1828F1250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static WYQCGJGFTYO TNFUYFVXYMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x28F3140", Offset = "0x28F2540", VA = "0x1828F3140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static WYQCGJGFTYO LNMOKPDHHFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x28F1DF0", Offset = "0x28F11F0", VA = "0x1828F1DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static WYQCGJGFTYO MPGHKXKTIOL
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x28F10D0", Offset = "0x28F04D0", VA = "0x1828F10D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static WYQCGJGFTYO BZRDAKGQBQK
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x28F2F00", Offset = "0x28F2300", VA = "0x1828F2F00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static WYQCGJGFTYO OCCDRAXHWFB
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x28F1DA0", Offset = "0x28F11A0", VA = "0x1828F1DA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static WYQCGJGFTYO IGTIZKPMEWB
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x28F4660", Offset = "0x28F3A60", VA = "0x1828F4660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static WYQCGJGFTYO LJTWLTWYKSL
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x28F0A00", Offset = "0x28EFE00", VA = "0x1828F0A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static WYQCGJGFTYO STVCSDZDBJV
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x28F3400", Offset = "0x28F2800", VA = "0x1828F3400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static WYQCGJGFTYO EPHAGWGPOGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x28F19C0", Offset = "0x28F0DC0", VA = "0x1828F19C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static WYQCGJGFTYO MMLEGRRVRTF
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x28F44F0", Offset = "0x28F38F0", VA = "0x1828F44F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static WYQCGJGFTYO QMPSJEBUADL
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x28F1E40", Offset = "0x28F1240", VA = "0x1828F1E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static WYQCGJGFTYO BHFWMPTEAKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x28F2BB0", Offset = "0x28F1FB0", VA = "0x1828F2BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static WYQCGJGFTYO IBRGBDEPIXA
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x28F4360", Offset = "0x28F3760", VA = "0x1828F4360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static WYQCGJGFTYO JKXVXKXKXAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x28F23C0", Offset = "0x28F17C0", VA = "0x1828F23C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static WYQCGJGFTYO IZFCUJRHPJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x28F13E0", Offset = "0x28F07E0", VA = "0x1828F13E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static WYQCGJGFTYO DWCANHZURMC
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x28F1C60", Offset = "0x28F1060", VA = "0x1828F1C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static WYQCGJGFTYO LULYPQTOILB
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x28F0B40", Offset = "0x28EFF40", VA = "0x1828F0B40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static WYQCGJGFTYO SWYSWMVKVAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x28F2940", Offset = "0x28F1D40", VA = "0x1828F2940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static WYQCGJGFTYO YTWUOFSJZWW
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x28F0A50", Offset = "0x28EFE50", VA = "0x1828F0A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static WYQCGJGFTYO QIVVGWHISIU
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x28F1AA0", Offset = "0x28F0EA0", VA = "0x1828F1AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static WYQCGJGFTYO SIPMWYULWPN
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x28F0AF0", Offset = "0x28EFEF0", VA = "0x1828F0AF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static WYQCGJGFTYO HTQRNVCWYHV
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x28F22E0", Offset = "0x28F16E0", VA = "0x1828F22E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static WYQCGJGFTYO WCZZDZYRIDY
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x28F0DC0", Offset = "0x28F01C0", VA = "0x1828F0DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static WYQCGJGFTYO ZLNJEKMBFLK
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x28F0C30", Offset = "0x28F0030", VA = "0x1828F0C30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static WYQCGJGFTYO FYIYFVYWQKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x28F3970", Offset = "0x28F2D70", VA = "0x1828F3970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static WYQCGJGFTYO EQXMKVTYQJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x28F3F30", Offset = "0x28F3330", VA = "0x1828F3F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static WYQCGJGFTYO FFVOZWQLNLL
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x28F0BE0", Offset = "0x28EFFE0", VA = "0x1828F0BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static WYQCGJGFTYO ZJCJQSTPYJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x28F2290", Offset = "0x28F1690", VA = "0x1828F2290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static WYQCGJGFTYO PBRGVFNADGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x28F12F0", Offset = "0x28F06F0", VA = "0x1828F12F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static WYQCGJGFTYO MGJQRWLJPJW
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x28F3450", Offset = "0x28F2850", VA = "0x1828F3450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static WYQCGJGFTYO IEVJREAXXFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x28F2D90", Offset = "0x28F2190", VA = "0x1828F2D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static WYQCGJGFTYO MBFWMVXZUEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x28F1480", Offset = "0x28F0880", VA = "0x1828F1480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static WYQCGJGFTYO GCWOBHTOKFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x28F2B60", Offset = "0x28F1F60", VA = "0x1828F2B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static WYQCGJGFTYO DJYWEZDVXBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x28F43B0", Offset = "0x28F37B0", VA = "0x1828F43B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static WYQCGJGFTYO XXDHHNYTZRG
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x28F45C0", Offset = "0x28F39C0", VA = "0x1828F45C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static WYQCGJGFTYO PMZSOFHJPNN
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x28F1F30", Offset = "0x28F1330", VA = "0x1828F1F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static WYQCGJGFTYO ZHVBXHJPSQS
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x28F0FE0", Offset = "0x28F03E0", VA = "0x1828F0FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static WYQCGJGFTYO COESURITANV
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x28F2F50", Offset = "0x28F2350", VA = "0x1828F2F50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static WYQCGJGFTYO AECQKNPGURJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x28F1CB0", Offset = "0x28F10B0", VA = "0x1828F1CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static WYQCGJGFTYO FLITWBQVSMX
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x28F26D0", Offset = "0x28F1AD0", VA = "0x1828F26D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static WYQCGJGFTYO EBHGVSXISTP
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x28F2A30", Offset = "0x28F1E30", VA = "0x1828F2A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static WYQCGJGFTYO ZZHWTQQCXGS
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x28F1F80", Offset = "0x28F1380", VA = "0x1828F1F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static WYQCGJGFTYO BDCCQRIQGJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x28F3AB0", Offset = "0x28F2EB0", VA = "0x1828F3AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static WYQCGJGFTYO JFPNVJUOMVW
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x28F1080", Offset = "0x28F0480", VA = "0x1828F1080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static WYQCGJGFTYO HXODFFLSHEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x28F4610", Offset = "0x28F3A10", VA = "0x1828F4610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static WYQCGJGFTYO FUNWZZADQNT
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x28F2C00", Offset = "0x28F2000", VA = "0x1828F2C00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static WYQCGJGFTYO SXIFQENSVFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x28F1340", Offset = "0x28F0740", VA = "0x1828F1340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static WYQCGJGFTYO KFXXHXXJNXQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x28F3EE0", Offset = "0x28F32E0", VA = "0x1828F3EE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static WYQCGJGFTYO WPXKFMEHCRD
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x28F2720", Offset = "0x28F1B20", VA = "0x1828F2720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static WYQCGJGFTYO MVCBVJVEZZX
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x28F1FD0", Offset = "0x28F13D0", VA = "0x1828F1FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static WYQCGJGFTYO ZJAJZGUUHFT
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x28F4540", Offset = "0x28F3940", VA = "0x1828F4540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static WYQCGJGFTYO BYVRIRUBGJO
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x28F18D0", Offset = "0x28F0CD0", VA = "0x1828F18D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static WYQCGJGFTYO BUURDMPJUJO
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x28F30F0", Offset = "0x28F24F0", VA = "0x1828F30F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static WYQCGJGFTYO UUNWYHANVPO
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x28F2070", Offset = "0x28F1470", VA = "0x1828F2070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static WYQCGJGFTYO STLNTEYEFRP
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x28F2D40", Offset = "0x28F2140", VA = "0x1828F2D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static WYQCGJGFTYO DUYHZPDUZLK
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x28F2240", Offset = "0x28F1640", VA = "0x1828F2240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static WYQCGJGFTYO ETCPUPPEQAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x28F0D70", Offset = "0x28F0170", VA = "0x1828F0D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static WYQCGJGFTYO QQQRUJLMGYR
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x28F11B0", Offset = "0x28F05B0", VA = "0x1828F11B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static WYQCGJGFTYO KKDSCSXQPOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x28F1D00", Offset = "0x28F1100", VA = "0x1828F1D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static WYQCGJGFTYO PYWRIRUPNOW
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x28F3360", Offset = "0x28F2760", VA = "0x1828F3360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static WYQCGJGFTYO QUHJIJSSIIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x28F4450", Offset = "0x28F3850", VA = "0x1828F4450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static WYQCGJGFTYO VMECXZHKGXJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x28F1D50", Offset = "0x28F1150", VA = "0x1828F1D50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static WYQCGJGFTYO LLYRLRYIKIM
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x28F1970", Offset = "0x28F0D70", VA = "0x1828F1970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static WYQCGJGFTYO BMDJCHWQQAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x28F1E90", Offset = "0x28F1290", VA = "0x1828F1E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static WYQCGJGFTYO ITBIGFZCKLL
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x28F1EE0", Offset = "0x28F12E0", VA = "0x1828F1EE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static WYQCGJGFTYO WMJDKBUAIMC
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x28F46B0", Offset = "0x28F3AB0", VA = "0x1828F46B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static WYQCGJGFTYO YIWDBDYYONZ
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x28F0CD0", Offset = "0x28F00D0", VA = "0x1828F0CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static WYQCGJGFTYO MASZZVGWIXF
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x28F20C0", Offset = "0x28F14C0", VA = "0x1828F20C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static WYQCGJGFTYO FBNUOTOAOHJ
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x28F3A60", Offset = "0x28F2E60", VA = "0x1828F3A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static WYQCGJGFTYO KEMSOKZUDVN
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x28F1030", Offset = "0x28F0430", VA = "0x1828F1030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static WYQCGJGFTYO PXCKMJFVDGT
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x28F0E10", Offset = "0x28F0210", VA = "0x1828F0E10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static WYQCGJGFTYO HXPCQOQJKMO
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x28F1B40", Offset = "0x28F0F40", VA = "0x1828F1B40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static WYQCGJGFTYO INGNNGBAGBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x28F0B90", Offset = "0x28EFF90", VA = "0x1828F0B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static WYQCGJGFTYO AGEYVLGYOGY
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x28F4400", Offset = "0x28F3800", VA = "0x1828F4400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static WYQCGJGFTYO HYASHVIIFDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x28F0F90", Offset = "0x28F0390", VA = "0x1828F0F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static WYQCGJGFTYO DUABWUQMFME
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x28F2E60", Offset = "0x28F2260", VA = "0x1828F2E60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static WYQCGJGFTYO JNATTWTTSWV
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x28F3B50", Offset = "0x28F2F50", VA = "0x1828F3B50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static WYQCGJGFTYO VGZSYTVTMGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x28F2020", Offset = "0x28F1420", VA = "0x1828F2020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static WYQCGJGFTYO NMLMJTEVGFQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x28F1200", Offset = "0x28F0600", VA = "0x1828F1200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static WYQCGJGFTYO FSZBTSLEAVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x28F0AA0", Offset = "0x28EFEA0", VA = "0x1828F0AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static WYQCGJGFTYO RGRWDJTQGMW
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x28F3B00", Offset = "0x28F2F00", VA = "0x1828F3B00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static WYQCGJGFTYO BWESZQACNYD
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x28F2B10", Offset = "0x28F1F10", VA = "0x1828F2B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static WYQCGJGFTYO EMHKUEVXUAT
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x28F0F40", Offset = "0x28F0340", VA = "0x1828F0F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static WYQCGJGFTYO POGRKVNZSXR
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x28F3190", Offset = "0x28F2590", VA = "0x1828F3190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static WYQCGJGFTYO FBZBYNSHZKE
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x28F28F0", Offset = "0x28F1CF0", VA = "0x1828F28F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static WYQCGJGFTYO XTARAODSMYX
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x28F2990", Offset = "0x28F1D90", VA = "0x1828F2990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static WYQCGJGFTYO NAZXOZDHIJT
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x28F2CA0", Offset = "0x28F20A0", VA = "0x1828F2CA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static WYQCGJGFTYO IYZFLMRXRHK
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x28F3A10", Offset = "0x28F2E10", VA = "0x1828F3A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static WYQCGJGFTYO MHSSDLJYYIZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x28F3BA0", Offset = "0x28F2FA0", VA = "0x1828F3BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static WYQCGJGFTYO RJXCZFBGCPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x28F2EB0", Offset = "0x28F22B0", VA = "0x1828F2EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static WYQCGJGFTYO CJBJUHHRURJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x28F29E0", Offset = "0x28F1DE0", VA = "0x1828F29E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static WYQCGJGFTYO DCFJIKEYHTH
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x28F24A0", Offset = "0x28F18A0", VA = "0x1828F24A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static WYQCGJGFTYO FHUVUJASXQI
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x28F24F0", Offset = "0x28F18F0", VA = "0x1828F24F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static WYQCGJGFTYO OSWCYZQXOWG
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x28F3310", Offset = "0x28F2710", VA = "0x1828F3310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static WYQCGJGFTYO JKTRGGZBIVN
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x28F3F80", Offset = "0x28F3380", VA = "0x1828F3F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static WYQCGJGFTYO OTOJLFLWFLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x28F3230", Offset = "0x28F2630", VA = "0x1828F3230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static WYQCGJGFTYO TEIVCVMCYJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x28F1B90", Offset = "0x28F0F90", VA = "0x1828F1B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static WYQCGJGFTYO ASDHYSKSEPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x28F38B0", Offset = "0x28F2CB0", VA = "0x1828F38B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static WYQCGJGFTYO TYXGNBQENVL
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x28F3E90", Offset = "0x28F3290", VA = "0x1828F3E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static WYQCGJGFTYO LMXDNYZXBEP
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x28F1390", Offset = "0x28F0790", VA = "0x1828F1390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static WYQCGJGFTYO FCESFQLQWVP
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x28F44A0", Offset = "0x28F38A0", VA = "0x1828F44A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static WYQCGJGFTYO VSUQZYBMGRA
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x28F12A0", Offset = "0x28F06A0", VA = "0x1828F12A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28F2800", Offset = "0x28F1C00", VA = "0x1828F2800")]
			public static RMUCOODOUOA NICNQJENHCA([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x28F25F0", Offset = "0x28F19F0", VA = "0x1828F25F0")]
			public static ClassFactoryTypeParams LZRJAXBSHNH(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28F26A0", Offset = "0x28F1AA0", VA = "0x1828F26A0")]
			public static ClassFactoryTypeParams LZRJAXBSHNH([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28F1C30", Offset = "0x28F1030", VA = "0x1828F1C30")]
			public static RMUCOODOUOA HGVFUOTYWWO(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28F4590", Offset = "0x28F3990", VA = "0x1828F4590")]
			public static RMUCOODOUOA ZAKNLPJHYRB(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28F2110", Offset = "0x28F1510", VA = "0x1828F2110")]
			public static RMUCOODOUOA JYFDYCRGQVJ([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28F3FD0", Offset = "0x28F33D0", VA = "0x1828F3FD0")]
			public static QNRWKFGEPMB XZIBOUKVTOZ(Id32<UWVMSGKSREJ> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x28F17A0", Offset = "0x28F0BA0", VA = "0x1828F17A0")]
			public static string FGIOMMVIKKW(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28F4080", Offset = "0x28F3480", VA = "0x1828F4080")]
			private static QNRWKFGEPMB XZIBOUKVTOZ(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28F3900", Offset = "0x28F2D00", VA = "0x1828F3900")]
			public static Id32<UWVMSGKSREJ>? VQPTADDAYAA(QNRWKFGEPMB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x28F34A0", Offset = "0x28F28A0", VA = "0x1828F34A0")]
			public static CircuitTypeIdWrapper? UUPJBGBVCJN(QNRWKFGEPMB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x28F4700", Offset = "0x28F3B00", VA = "0x1828F4700")]
			static AFLSZOTCOOV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28F2540", Offset = "0x28F1940", VA = "0x1828F2540")]
			[IteratorStateMachine(typeof(ULNEWUFVQYA))]
			private static IEnumerable<QNRWKFGEPMB> LLKMLZUZDYN(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x28F1820", Offset = "0x28F0C20", VA = "0x1828F1820")]
			[IteratorStateMachine(typeof(VPALXZWNAIW))]
			public static IEnumerable<QNRWKFGEPMB> FGJPWUPGHQU(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x28F3BF0", Offset = "0x28F2FF0", VA = "0x1828F3BF0")]
			public static Variant XMLKNDWMOXH(QNRWKFGEPMB a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x28F14D0", Offset = "0x28F08D0", VA = "0x1828F14D0")]
			public static Variant FDYXASNWCJS(QNRWKFGEPMB a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x28F2DE0", Offset = "0x28F21E0", VA = "0x1828F2DE0")]
			public static bool QGKVIQRAKPK(QNRWKFGEPMB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x28F2FF0", Offset = "0x28F23F0", VA = "0x1828F2FF0")]
			[IteratorStateMachine(typeof(TCSBDNFFQXR))]
			public static IEnumerable<Id32<UWVMSGKSREJ>> RWXGKLWKQIO(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class CWJDPXEPOQS
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28FC600", Offset = "0x28FBA00", VA = "0x1828FC600")]
		public static FIIFYQIAFIR MFMKHXDBDDO(this QNRWKFGEPMB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28FBAF0", Offset = "0x28FAEF0", VA = "0x1828FBAF0")]
		public static QNRWKFGEPMB EXEWSDYIDQV(this FIIFYQIAFIR a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FGZCXKOWUXJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x36A8710", Offset = "0x36A7B10", VA = "0x1836A8710")]
		public static Dictionary<b, c> RIOTCTJHHBD<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class BEJABVEXJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28FB760", Offset = "0x28FAB60", VA = "0x1828FB760")]
		public static JRNUZQLPYLV MFMKHXDBDDO([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28FB6C0", Offset = "0x28FAAC0", VA = "0x1828FB6C0")]
		public static Guid EXEWSDYIDQV(JRNUZQLPYLV a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class NHPYCZCRCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29002B0", Offset = "0x28FF6B0", VA = "0x1829002B0")]
		public static VUFLQKILOKT MFMKHXDBDDO([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2900250", Offset = "0x28FF650", VA = "0x182900250")]
		public static NamedType EXEWSDYIDQV(this VUFLQKILOKT a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class SWPVESAPDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A1E9C0", Offset = "0x3A1DDC0", VA = "0x183A1E9C0")]
		public static void JGXKWGFOQON<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A1EC20", Offset = "0x3A1E020", VA = "0x183A1EC20")]
		public static void JGXKWGFOQON<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class HCTHRTCYXQI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28FF4B0", Offset = "0x28FE8B0", VA = "0x1828FF4B0")]
		public static QDYLFEOXBWD MFMKHXDBDDO([In] this Variant self, QNRWKFGEPMB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28FF360", Offset = "0x28FE760", VA = "0x1828FF360")]
		public static Variant EXEWSDYIDQV(this QDYLFEOXBWD a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class SVNYMTANVZE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<RLQPLEQLBMC> KPPJHRQIDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool JQSZFKWWXCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool IJMHLFXTFTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool BGXWVOVVYDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool PLNCVQPZGSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool PMCXNKXRJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool NCLFSEWOFPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool ICPFQSEHXBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool UXFPHEHGCRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, QNRWKFGEPMB Type)> NNXGQBTQLPK;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid KVDFRQPXLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x28B7840", Offset = "0x28B6C40", VA = "0x1828B7840")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<RLQPLEQLBMC> FYRGMTVMJXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x28B7840", Offset = "0x28B6C40", VA = "0x1828B7840")]
			get
			{
				return default(Id128<RLQPLEQLBMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, QNRWKFGEPMB Type)> DSPNLJXOZTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NSKAFGCUSOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x290A730", Offset = "0x2909B30", VA = "0x18290A730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x290B080", Offset = "0x290A480", VA = "0x18290B080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, QNRWKFGEPMB> XHOQCTWNFNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x290AEB0", Offset = "0x290A2B0", VA = "0x18290AEB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x290B510", Offset = "0x290A910", VA = "0x18290B510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> DVXEORGQISM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x290B6E0", Offset = "0x290AAE0", VA = "0x18290B6E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x290A8D0", Offset = "0x2909CD0", VA = "0x18290A8D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> OQVLIZRJLPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x290AA20", Offset = "0x2909E20", VA = "0x18290AA20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x290B460", Offset = "0x290A860", VA = "0x18290B460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, QNRWKFGEPMB> RWEQVCQPZOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x290B630", Offset = "0x290AA30", VA = "0x18290B630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x290AE00", Offset = "0x290A200", VA = "0x18290AE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action VUUBNBPWROX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x290A980", Offset = "0x2909D80", VA = "0x18290A980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x290B180", Offset = "0x290A580", VA = "0x18290B180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18E2EC0", Offset = "0x18E22C0", VA = "0x1818E2EC0")]
		public void WPUJKQVOEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x290B790", Offset = "0x290AB90", VA = "0x18290B790")]
		internal SVNYMTANVZE([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, QNRWKFGEPMB Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x290AB50", Offset = "0x2909F50", VA = "0x18290AB50")]
		public static CircuitEventDefinitionFactoryStart LUYAJHASGOD(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x290AAD0", Offset = "0x2909ED0", VA = "0x18290AAD0")]
		public static CircuitEventDefinitionFactoryStart LUYAJHASGOD(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x290A620", Offset = "0x2909A20", VA = "0x18290A620")]
		public static SVNYMTANVZE CDGEKIOVRIR([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x290B220", Offset = "0x290A620", VA = "0x18290B220")]
		public static SVNYMTANVZE VEDJODEOMBB([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xC28740", Offset = "0xC27B40", VA = "0x180C28740")]
		public void WTPVVTKZHJT(Id128<RLQPLEQLBMC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x290B120", Offset = "0x290A520", VA = "0x18290B120")]
		public void UPJLAOUMKLW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x290AC20", Offset = "0x290A020", VA = "0x18290AC20")]
		public void NHJCHKYTOWE(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x290AD10", Offset = "0x290A110", VA = "0x18290AD10")]
		public void PRTUFCBOQRZ(int a, QNRWKFGEPMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x290AF60", Offset = "0x290A360", VA = "0x18290AF60")]
		public void TSVDYFYADKR(string a, QNRWKFGEPMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x290B5C0", Offset = "0x290A9C0", VA = "0x18290B5C0")]
		public void YCWYCYRGNVA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x290A7D0", Offset = "0x2909BD0", VA = "0x18290A7D0")]
		public SVNYMTANVZE Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x28FDC20", Offset = "0x28FD020", VA = "0x1828FDC20")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28FD980", Offset = "0x28FCD80", VA = "0x1828FD980")]
		public CircuitEventDefinitionFactoryParams KMNWSIDOURZ(string a, QNRWKFGEPMB b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28FDAF0", Offset = "0x28FCEF0", VA = "0x1828FDAF0")]
		public SVNYMTANVZE SMCVKRDMXBZ()
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
		private readonly List<(string Name, QNRWKFGEPMB Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28FD8F0", Offset = "0x28FCCF0", VA = "0x1828FD8F0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, QNRWKFGEPMB Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28FD6C0", Offset = "0x28FCAC0", VA = "0x1828FD6C0")]
		public CircuitEventDefinitionFactoryParams KMNWSIDOURZ(string a, QNRWKFGEPMB b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28FD7F0", Offset = "0x28FCBF0", VA = "0x1828FD7F0")]
		public SVNYMTANVZE SMCVKRDMXBZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class BANDVFAQHZV
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly SVNYMTANVZE ZYFLOIYVXGC;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly SVNYMTANVZE JEPSSQQJMQV;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly SVNYMTANVZE BURPCBYIMPS;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly SVNYMTANVZE VPAWCYRSODL;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly SVNYMTANVZE EVPEEUBXISG;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly SVNYMTANVZE HWUSNUPBEUU;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly SVNYMTANVZE AOTJLILCJLZ;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly SVNYMTANVZE[] LLQEBOOITJW;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class EFRLETEASKC
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly SVNYMTANVZE AHUEOICCHIS;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class WLVHKXPHEAZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly SVNYMTANVZE RXGYVXXNIXI;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly SVNYMTANVZE VHXYUQNCEXJ;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class IZRGZPYDNCY
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly SVNYMTANVZE FKKEBRFKWRB;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly SVNYMTANVZE CMOLSUZVPZU;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly SVNYMTANVZE[] NPFTXPEBSKW;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly SVNYMTANVZE NFZGZMDTPMO;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly SVNYMTANVZE GFIIFAIRBVB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class FNXMZWDAPGU
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly SVNYMTANVZE TTGHBPDVTVR;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly SVNYMTANVZE XPGVEAOOQES;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class WXWYEWSCBPD
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly SVNYMTANVZE BRYWLOMMBSW;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly SVNYMTANVZE ISTDFILDZIB;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class CKGIRSCYNQG
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly SVNYMTANVZE RXGYVXXNIXI;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly SVNYMTANVZE VHXYUQNCEXJ;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class ZIMZKCSCUVS
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly SVNYMTANVZE FSFASAUIANT;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly SVNYMTANVZE JEPDMMNGKLY;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly SVNYMTANVZE KABNEVMDINC;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly SVNYMTANVZE EWJQPEEJTZA;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly SVNYMTANVZE QRFOGZLOKJT;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly SVNYMTANVZE FBIOKZUKSNI;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly SVNYMTANVZE VWALTABAQZV;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class QZYMYSGGRZS
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class GAEHNLXKRMQ
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class MNZXTLFNWOY
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class VWBGNSXVPRS
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly SVNYMTANVZE WSIZXLLBKOJ;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly SVNYMTANVZE QXHCKDJAXHI;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class NMKJPPBKZTE
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class JZHAXBTRRVY
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class GEJLXKSPEYK
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class LYQOKIXSDWN
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly SVNYMTANVZE EWHXVQMGUAB;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly SVNYMTANVZE THKSCAWWEBN;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly SVNYMTANVZE HAHIUKYDIEU;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly SVNYMTANVZE OPMLZXANODL;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly SVNYMTANVZE UPVCXVQIQLF;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly SVNYMTANVZE BRYWLOMMBSW;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly SVNYMTANVZE ZMKABZZVJRF;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly SVNYMTANVZE SKNMHOEUDDO;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly SVNYMTANVZE OTFJOOPQVTI;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly SVNYMTANVZE GVAMQPIIRFY;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly SVNYMTANVZE SLTKSTLXXGQ;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly SVNYMTANVZE ZFPEOUFACXU;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly SVNYMTANVZE NQCWCNZLIXP;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly SVNYMTANVZE HGKHABYEEGI;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly SVNYMTANVZE DGSMVYWQTVZ;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly SVNYMTANVZE OLQPPMIFWKP;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly SVNYMTANVZE XKMWMVGHWYN;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly SVNYMTANVZE VMNZYZWYVJI;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly SVNYMTANVZE LBWFEPUVZET;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly SVNYMTANVZE GHHNHGGIJAB;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly SVNYMTANVZE VXIBCUPRRZW;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly SVNYMTANVZE EHPUFISFAAU;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly SVNYMTANVZE DELAVWFFZNA;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly SVNYMTANVZE PENAVYPDBZI;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly SVNYMTANVZE BQLNHGIBGKO;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly SVNYMTANVZE UJCKSWEPKMK;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly SVNYMTANVZE KLKPSZHBLFC;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly SVNYMTANVZE BLTTDJCQMIY;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly SVNYMTANVZE FSRCVXFRDMF;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly SVNYMTANVZE MKTRPCZIUJD;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly SVNYMTANVZE MMJRPWBYEPC;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly SVNYMTANVZE KUKKNNSZUAA;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly SVNYMTANVZE BOBZJKMXLFP;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly SVNYMTANVZE LIBFQJVQBOF;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly SVNYMTANVZE CUVJBVPINRD;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly SVNYMTANVZE OMQZXHJXWNT;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly SVNYMTANVZE FNXMIBXMYPL;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly SVNYMTANVZE OYQUFOELGET;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly SVNYMTANVZE XVJVWNYWFWD;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly SVNYMTANVZE EDKUUQWPYPJ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly SVNYMTANVZE YONDFBSMNDA;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly SVNYMTANVZE FSFZVOQCWIE;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly SVNYMTANVZE FRDHRAJTVLQ;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly SVNYMTANVZE YDWBAJVUGDM;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly SVNYMTANVZE BCPZFNXLLJE;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly SVNYMTANVZE LQVQQMXNDNM;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly SVNYMTANVZE JOKPCLQJOWU;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly SVNYMTANVZE MHVZQXOUEXC;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly SVNYMTANVZE LRUHNNMJOOU;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly SVNYMTANVZE VPGYRXYDFAC;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly SVNYMTANVZE HYXCBMWZUKZ;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly SVNYMTANVZE FUFNHSAABYC;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly SVNYMTANVZE NCTRTALGEQI;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly SVNYMTANVZE RECTJELXFHI;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly SVNYMTANVZE BZONWVCBEMO;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly SVNYMTANVZE HDANPTCFCTY;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly SVNYMTANVZE ENYGJIPVNRQ;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly SVNYMTANVZE VMMEFTNMFIC;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly SVNYMTANVZE TVXLZNDILQQ;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly SVNYMTANVZE OLITMMNSJQA;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly SVNYMTANVZE FDUMIVDODUI;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly SVNYMTANVZE NFEKPETZKHM;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly SVNYMTANVZE OKEHMMESXEB;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly SVNYMTANVZE HHMIZOVDVWC;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly SVNYMTANVZE BNINOHDUESG;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly SVNYMTANVZE APIHYXEZMTP;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly SVNYMTANVZE TTOLVQLAUVB;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly SVNYMTANVZE PGGCAPVUUYY;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly SVNYMTANVZE ZGCWHCLUGCO;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class FBWWWJEPSHP
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class DHDYJIAGNXG
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly SVNYMTANVZE AEAHQYBIVDE;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly SVNYMTANVZE AGVGYYVVUWP;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly SVNYMTANVZE CYYZPFIVIAT;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly SVNYMTANVZE JTZMWDWMOXW;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly SVNYMTANVZE HUQMQFVQAOU;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly SVNYMTANVZE QRUAZLZYHES;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly SVNYMTANVZE RFIHGPYTUDK;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class ZYWSOWWFRQR
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly SVNYMTANVZE THKSCAWWEBN;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly SVNYMTANVZE HAHIUKYDIEU;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly SVNYMTANVZE OPMLZXANODL;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly SVNYMTANVZE TBKIAOFFKIZ;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly SVNYMTANVZE GSGYICAALMB;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly SVNYMTANVZE WNWDAXRHVCR;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly SVNYMTANVZE EHKMCJYIDCT;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class JUCPDGQMOYV
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly SVNYMTANVZE SCNMCAIZSYT;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly SVNYMTANVZE IXHWWIDWRUX;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly SVNYMTANVZE TZXOVSNVEYM;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly SVNYMTANVZE FAPTZFACFZS;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly SVNYMTANVZE LMWEGVWWLMU;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly SVNYMTANVZE BDNIAOFRXTA;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class WIIMBVCSHBE
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class JVPRFMGSYMB
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly SVNYMTANVZE JQZJITQECGP;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class LTOSVSVMKWH
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly SVNYMTANVZE EWHXVQMGUAB;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class XEQRBTPRCMY
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class UZTEBCCDVBJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class EIRUMNUWYZO
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly SVNYMTANVZE SSJKBDITCMA;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly SVNYMTANVZE JLDBLXVNMWG;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly SVNYMTANVZE ZGZRUBDJHBH;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly SVNYMTANVZE XHKUURJSOOV;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class UODIYFFZPXE
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly SVNYMTANVZE LHSXHKURBJF;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly SVNYMTANVZE PJMNJGHYFAU;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class MNPWGWICFDY
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class YCDBBQIDRYK
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly SVNYMTANVZE AEAHQYBIVDE;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly SVNYMTANVZE AGVGYYVVUWP;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class CIYTVWCWSZJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly SVNYMTANVZE JVSLBRRGRGA;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly SVNYMTANVZE JTZMWDWMOXW;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly SVNYMTANVZE HUQMQFVQAOU;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly SVNYMTANVZE QRUAZLZYHES;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly SVNYMTANVZE IYGHZSUDEQV;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly SVNYMTANVZE PPOPIMGSPPU;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly SVNYMTANVZE FSFNNMEOQHA;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly SVNYMTANVZE NQQNPXKELJW;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly SVNYMTANVZE ZRBVOCRTMON;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly SVNYMTANVZE ZYIKONVVTHL;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly SVNYMTANVZE AEAHQYBIVDE;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly SVNYMTANVZE AGVGYYVVUWP;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class DEADEJWAQRD
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ESAVLJWKELR
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly SVNYMTANVZE AEAHQYBIVDE;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly SVNYMTANVZE AGVGYYVVUWP;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly SVNYMTANVZE GSVETWJAVTP;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly SVNYMTANVZE GBPTPWUOMRT;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly SVNYMTANVZE BAQBRECMFRK;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class DGGZWMAGEYG
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class GFAJDYMESGF
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly SVNYMTANVZE VJQMINNPKDE;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class DMLSCHGADAR
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly SVNYMTANVZE QEGKWXLFANR;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly SVNYMTANVZE LPKPIPYPDJA;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly SVNYMTANVZE AEAHQYBIVDE;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly SVNYMTANVZE AGVGYYVVUWP;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class UZGYLEKGMLS
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class ZQPVDHAYSIM
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class TQGEGWLPJSV
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class WFMSWCAQWTX
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class EMDRWRXDAFK
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class FFPNQVJPZBG
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly SVNYMTANVZE WSIZXLLBKOJ;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly SVNYMTANVZE QXHCKDJAXHI;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class QJBJNFXCWBC
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly SVNYMTANVZE DIUVAMEZXUX;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly SVNYMTANVZE TSCWLFFSIYN;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly SVNYMTANVZE OYAXYTVFFGX;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly SVNYMTANVZE UPPOTPAMKLX;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class UXBTKREBBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly SVNYMTANVZE DIUVAMEZXUX;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly SVNYMTANVZE TSCWLFFSIYN;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly SVNYMTANVZE OYAXYTVFFGX;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly SVNYMTANVZE UPPOTPAMKLX;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class QGFITZJXVPC
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class MJPKTPMSNAZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly SVNYMTANVZE IRCSQGKKEKG;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly SVNYMTANVZE QSQQRJOPRAO;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly SVNYMTANVZE ONLFRWHRRYW;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class BKAOZUGDGZW
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly SVNYMTANVZE EJYTRBFGSSX;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly SVNYMTANVZE TCAUUBDGGRL;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly SVNYMTANVZE XZJJEBNQCXQ;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class RXEDTUOIUXV
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class CWTYPJVMMWW
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly SVNYMTANVZE TJPADKRPJWW;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly SVNYMTANVZE NHYYBWVHVSA;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly SVNYMTANVZE IDZYRRDXHUP;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly SVNYMTANVZE DYRTVRJRJBF;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly SVNYMTANVZE KWNHIEMQHZY;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class YMENSEJKUZD
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly SVNYMTANVZE ZSKAOTESIBI;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class ISVUVCZYNRL
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly SVNYMTANVZE XHDHZKUXNQP;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly SVNYMTANVZE TEJJPFNYFUU;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly SVNYMTANVZE RUJRJLIOAAH;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class RHEYSRHOURE
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class OQUYLSOAPCI
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class HKWPDOTCDUD
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class MGDIHGLPSNG
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly SVNYMTANVZE TFKYPUZQBVH;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly SVNYMTANVZE HXWKBDOSFMG;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly SVNYMTANVZE UGEVDTGNKXW;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly SVNYMTANVZE IPWRSZSQJGI;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly SVNYMTANVZE RHNLJSRMVAD;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly SVNYMTANVZE LIBEYLUPQGJ;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly SVNYMTANVZE EWXNJHYZRNI;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class QDGZZWQJBRO
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly SVNYMTANVZE OPCVUVFWLLV;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly SVNYMTANVZE[] GIVLEVMQLMD;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class ISPMZIZOVTK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly QNRWKFGEPMB GMCLRCPHVVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<SVNYMTANVZE> TZGAOLMNEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<SVNYMTANVZE> QAVCVNOWMJK;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<SVNYMTANVZE> FYJBRLVIXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<SVNYMTANVZE> ZSPUMTYIYET
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2916F20", Offset = "0x2916320", VA = "0x182916F20")]
		protected ISPMZIZOVTK(QNRWKFGEPMB a, params SVNYMTANVZE[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class YQTEAPYETAY : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x291F8B0", Offset = "0x291ECB0", VA = "0x18291F8B0")]
		internal YQTEAPYETAY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class NCGXRLZVNSJ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x291A1B0", Offset = "0x29195B0", VA = "0x18291A1B0")]
		internal NCGXRLZVNSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class UDFARIGIMGY : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x291D2E0", Offset = "0x291C6E0", VA = "0x18291D2E0")]
		internal UDFARIGIMGY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class FNTCNKVFBRP : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2915AC0", Offset = "0x2914EC0", VA = "0x182915AC0")]
		internal FNTCNKVFBRP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class WDWYMDNLCKW : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x291E9F0", Offset = "0x291DDF0", VA = "0x18291E9F0")]
		internal WDWYMDNLCKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class OGOTLBAOFMS : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x291ADF0", Offset = "0x291A1F0", VA = "0x18291ADF0")]
		internal OGOTLBAOFMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class OEIUASHSEHT : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x291AC10", Offset = "0x291A010", VA = "0x18291AC10")]
		internal OEIUASHSEHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class TRMVOKLBPLW : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x291CEA0", Offset = "0x291C2A0", VA = "0x18291CEA0")]
		internal TRMVOKLBPLW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ZPARGQRFIUS : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2920030", Offset = "0x291F430", VA = "0x182920030")]
		internal ZPARGQRFIUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class UWRYNSWPHSO : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x291DAB0", Offset = "0x291CEB0", VA = "0x18291DAB0")]
		internal UWRYNSWPHSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class JANOHWGYUGO : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x29176B0", Offset = "0x2916AB0", VA = "0x1829176B0")]
		internal JANOHWGYUGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class HMVQPLVQQCO : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x29167A0", Offset = "0x2915BA0", VA = "0x1829167A0")]
		internal HMVQPLVQQCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class IMJJOPSZZES : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2916B60", Offset = "0x2915F60", VA = "0x182916B60")]
		internal IMJJOPSZZES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class KASQSIKYAIO : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2918B60", Offset = "0x2917F60", VA = "0x182918B60")]
		internal KASQSIKYAIO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class DAEKGXNADJW : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x29130B0", Offset = "0x29124B0", VA = "0x1829130B0")]
		internal DAEKGXNADJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class XBZLRQSNBVO : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x291EED0", Offset = "0x291E2D0", VA = "0x18291EED0")]
		internal XBZLRQSNBVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class AIDANWZJIYY : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2910830", Offset = "0x290FC30", VA = "0x182910830")]
		internal AIDANWZJIYY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ZHNTVCUQHAF : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x291FA90", Offset = "0x291EE90", VA = "0x18291FA90")]
		internal ZHNTVCUQHAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class OBACYTDARZZ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x291AA30", Offset = "0x2919E30", VA = "0x18291AA30")]
		internal OBACYTDARZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class IKWOFIGLVPF : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2916980", Offset = "0x2915D80", VA = "0x182916980")]
		internal IKWOFIGLVPF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class QLDUNSHQADT : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x291C170", Offset = "0x291B570", VA = "0x18291C170")]
		internal QLDUNSHQADT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class TYEGABAEEBP : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x291D080", Offset = "0x291C480", VA = "0x18291D080")]
		internal TYEGABAEEBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class AWLUTRHAYBE : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2910DD0", Offset = "0x29101D0", VA = "0x182910DD0")]
		internal AWLUTRHAYBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class IVMRLMZPAML : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x29174D0", Offset = "0x29168D0", VA = "0x1829174D0")]
		internal IVMRLMZPAML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JCGTFCCBNIM : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2917890", Offset = "0x2916C90", VA = "0x182917890")]
		internal JCGTFCCBNIM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ZYQZGPQCIYT : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2920270", Offset = "0x291F670", VA = "0x182920270")]
		internal ZYQZGPQCIYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class CQDWAFQMTGF : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2912570", Offset = "0x2911970", VA = "0x182912570")]
		internal CQDWAFQMTGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZHTMLWGZJIL : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x291FC70", Offset = "0x291F070", VA = "0x18291FC70")]
		internal ZHTMLWGZJIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class BKBUEMAWCUW : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2911450", Offset = "0x2910850", VA = "0x182911450")]
		internal BKBUEMAWCUW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class IPQAOMPOJFN : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2916D40", Offset = "0x2916140", VA = "0x182916D40")]
		internal IPQAOMPOJFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class DGATIDQJDNY : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x29132F0", Offset = "0x29126F0", VA = "0x1829132F0")]
		internal DGATIDQJDNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class VWKTYJKHFDK : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x291E810", Offset = "0x291DC10", VA = "0x18291E810")]
		internal VWKTYJKHFDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class VLBNVOVXWQY : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x291E630", Offset = "0x291DA30", VA = "0x18291E630")]
		internal VLBNVOVXWQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class BRTFQZFKDFJ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2911630", Offset = "0x2910A30", VA = "0x182911630")]
		internal BRTFQZFKDFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class ZLTWDFVXWZP : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x291FE50", Offset = "0x291F250", VA = "0x18291FE50")]
		internal ZLTWDFVXWZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class VHVNHARFIFZ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x291E3D0", Offset = "0x291D7D0", VA = "0x18291E3D0")]
		internal VHVNHARFIFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class USRDRJEBOGA : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x291D8D0", Offset = "0x291CCD0", VA = "0x18291D8D0")]
		internal USRDRJEBOGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class POLEKSKIZIZ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x291B210", Offset = "0x291A610", VA = "0x18291B210")]
		internal POLEKSKIZIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class KBPWXCMKSIR : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2918C40", Offset = "0x2918040", VA = "0x182918C40")]
		internal KBPWXCMKSIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class JWOHOLHEUTI : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2918980", Offset = "0x2917D80", VA = "0x182918980")]
		internal JWOHOLHEUTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class JHEHLYNFVYS : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2917A70", Offset = "0x2916E70", VA = "0x182917A70")]
		internal JHEHLYNFVYS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class QTHMQZIQRSK : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x291C3C0", Offset = "0x291B7C0", VA = "0x18291C3C0")]
		internal QTHMQZIQRSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class NWXFTXHVFQV : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x291A5D0", Offset = "0x29199D0", VA = "0x18291A5D0")]
		internal NWXFTXHVFQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class RZZYHQBDBXX : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x291C840", Offset = "0x291BC40", VA = "0x18291C840")]
		internal RZZYHQBDBXX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class WRTNTXJPNPQ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x291EC90", Offset = "0x291E090", VA = "0x18291EC90")]
		internal WRTNTXJPNPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class AIYJLMXHBLN : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2910A10", Offset = "0x290FE10", VA = "0x182910A10")]
		internal AIYJLMXHBLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class DTHTVSWSGBQ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2914580", Offset = "0x2913980", VA = "0x182914580")]
		internal DTHTVSWSGBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class RIJMSQFUPMB : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x291C600", Offset = "0x291BA00", VA = "0x18291C600")]
		internal RIJMSQFUPMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class SRBKJUTQOYB : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x291CA80", Offset = "0x291BE80", VA = "0x18291CA80")]
		internal SRBKJUTQOYB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MYIGJNRFJLI : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2919DF0", Offset = "0x29191F0", VA = "0x182919DF0")]
		internal MYIGJNRFJLI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class DGIZQLYIFOU : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2913530", Offset = "0x2912930", VA = "0x182913530")]
		internal DGIZQLYIFOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class LSLSYOPNXQT : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2919080", Offset = "0x2918480", VA = "0x182919080")]
		internal LSLSYOPNXQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class PBMJWSYZXZO : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x291B030", Offset = "0x291A430", VA = "0x18291B030")]
		internal PBMJWSYZXZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class LJKHVJDIMJP : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2918EA0", Offset = "0x29182A0", VA = "0x182918EA0")]
		internal LJKHVJDIMJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class GDGKJORPXAJ : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2915CA0", Offset = "0x29150A0", VA = "0x182915CA0")]
		internal GDGKJORPXAJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class NBHOAUWGJNN : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2919FD0", Offset = "0x29193D0", VA = "0x182919FD0")]
		internal NBHOAUWGJNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class TOTVAJNSNRL : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x291CC60", Offset = "0x291C060", VA = "0x18291CC60")]
		internal TOTVAJNSNRL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class AHZUGJAURMI : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2910650", Offset = "0x290FA50", VA = "0x182910650")]
		internal AHZUGJAURMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class APBLSWHERYL : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2910BF0", Offset = "0x290FFF0", VA = "0x182910BF0")]
		internal APBLSWHERYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class JPFPIKHYTGX : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2917C50", Offset = "0x2917050", VA = "0x182917C50")]
		internal JPFPIKHYTGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class NTSLJLNBGOW : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x291A310", Offset = "0x2919710", VA = "0x18291A310")]
		internal NTSLJLNBGOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class PYYOCUKEEZN : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x291B470", Offset = "0x291A870", VA = "0x18291B470")]
		internal PYYOCUKEEZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class NUDLTNEIQMW : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x291A470", Offset = "0x2919870", VA = "0x18291A470")]
		internal NUDLTNEIQMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class YFNOHTWPFAV : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x291F4F0", Offset = "0x291E8F0", VA = "0x18291F4F0")]
		internal YFNOHTWPFAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class QAMTBQRGXDB : ISPMZIZOVTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x291B5D0", Offset = "0x291A9D0", VA = "0x18291B5D0")]
		internal QAMTBQRGXDB()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, VHVQTMURGOZ<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly QNRWKFGEPMB Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
		private NamedType(string name, QNRWKFGEPMB type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2850090", Offset = "0x284F490", VA = "0x182850090")]
		public static NamedType New(string name, QNRWKFGEPMB type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x291A8F0", Offset = "0x2919CF0", VA = "0x18291A8F0")]
		public static bool NAQFJJXEQSO([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x291A8F0", Offset = "0x2919CF0", VA = "0x18291A8F0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x291A8F0", Offset = "0x2919CF0", VA = "0x18291A8F0")]
		public bool UEETEZFSGGI([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x291A830", Offset = "0x2919C30", VA = "0x18291A830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x291A940", Offset = "0x2919D40", VA = "0x18291A940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x291A9F0", Offset = "0x2919DF0", VA = "0x18291A9F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x291A9B0", Offset = "0x2919DB0", VA = "0x18291A9B0")]
		public string LFDGJLHWEMS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x291A7B0", Offset = "0x2919BB0", VA = "0x18291A7B0")]
		public string DDPVEGKDWUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x291A8F0", Offset = "0x2919CF0", VA = "0x18291A8F0", Slot = "5")]
		private bool WEPHKAONKUJ([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface AEMOPZBEDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, ZEEUKBHYSTE>> YYSLKNAWHOS(HJODGUBVAZG a, bool b);
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
