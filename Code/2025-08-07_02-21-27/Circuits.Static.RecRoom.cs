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
using Circuits.Static.Core.CompileSystem;
using Circuits.Static.Core.GraphSystem;
using Circuits.Static.Core.RequestReduce;
using Circuits.Static.Core.TypeCheckSystem;
using Circuits.Static.Core.TypeSystem;
using Circuits.Static.Core.TypeSystem.Factory;
using Circuits.Static.Core.TypeSystem.Type;
using Circuits.Static.EV;
using Circuits.Static.EV.Def;
using Circuits.Static.EV.Error;
using Circuits.Static.EV.Factory;
using Circuits.Static.EV.Lang;
using Circuits.Static.EV.Protobuf;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.Error;
using Circuits.Static.RecRoom.GraphDefs;
using Circuits.Static.RecRoom.NodeDefs;
using Circuits.Static.RecRoom.ObjectDefs;
using Circuits.Static.RecRoom.Protobuf;
using Circuits.Static.RecRoom.Systems;
using Circuits.Static.Utilities;
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E198B0", Offset = "0x2E184B0", VA = "0x182E198B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E18750", Offset = "0x2E17350", VA = "0x182E18750", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class DVOTUUIRDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2E0E1A0", Offset = "0x2E0CDA0", VA = "0x182E0E1A0")]
		public static bool OPIYTSYQXLM(this IDLCASSILBG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2E0E0E0", Offset = "0x2E0CCE0", VA = "0x182E0E0E0")]
		public static bool OPIYTSYQXLM(this VYGAXGQUGRJ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HIEMMFGSUTF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		InternalRRStaticStateSysAccess? INFKYHURQQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class YMUZDDXNMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2E2A840", Offset = "0x2E29440", VA = "0x182E2A840")]
		internal static INFKYHURQQV INFKYHURQQV(this HIEMMFGSUTF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2E2A920", Offset = "0x2E29520", VA = "0x182E2A920")]
		internal static Result<INFKYHURQQV, DRFTFCZGGMG> ZTDHBZBIFWA(this HIEMMFGSUTF a)
		{
			return default(Result<INFKYHURQQV, DRFTFCZGGMG>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct InternalRRStaticStateSysAccess
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly INFKYHURQQV RRStaticStateSys;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public InternalRRStaticStateSysAccess(INFKYHURQQV rrStaticStateSys)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class YMIYRTTBNVK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x41E9030", Offset = "0x41E7C30", VA = "0x1841E9030")]
		public static ReducerFactory<ActionKind, FJCTCRTIJZZ, a, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, a>> NUIIQBYSRXR<a>([In] this ReducerFactory<ActionKind, FJCTCRTIJZZ, a, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, a>> reducerFactory) where a : HIEMMFGSUTF
		{
			return default(ReducerFactory<ActionKind, FJCTCRTIJZZ, a, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, a>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct Registry : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public readonly struct EVRequest
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private struct <Request>d__2 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public EVRequest <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public FJCTCRTIJZZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x2E27450", Offset = "0x2E26050", VA = "0x182E27450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x2E276E0", Offset = "0x2E262E0", VA = "0x182E276E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly GGQWPRURVBI _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			public EVRequest(GGQWPRURVBI staticNetSys)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2E0E700", Offset = "0x2E0D300", VA = "0x182E0E700")]
			[AsyncStateMachine(typeof(<Request>d__2))]
			public Task<Result<object, JGXPLWKAZER>> JYDCJYGVPCK(FJCTCRTIJZZ a, bool b = false)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct GraphRegistry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Id32<TZJZKVJCHTJ> RootGraph;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<TZJZKVJCHTJ> FunctionGraph;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2E12590", Offset = "0x2E11190", VA = "0x182E12590")]
			public static GraphRegistry New(VXFXYEKOFOJ<INFKYHURQQV> factory)
			{
				return default(GraphRegistry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct NodeRegistry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public Id32<TFITIOWUSRJ> AddNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<TFITIOWUSRJ> FunctionNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Id32<TFITIOWUSRJ> FunctionInNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Id32<TFITIOWUSRJ> FunctionOutNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Id32<TFITIOWUSRJ> IfNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Id32<TFITIOWUSRJ> PrintNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Id32<TFITIOWUSRJ> SubtractNode;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2E196A0", Offset = "0x2E182A0", VA = "0x182E196A0")]
			public static NodeRegistry New(BOEJPDUYVMV<INFKYHURQQV> factory)
			{
				return default(NodeRegistry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class FJPJXSBVFIF
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Dictionary<Id32<RPQAGIRUEZU>, ITPOVZBMHGT> EEBTEEVDKNQ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private static HashSet<Id32<RPQAGIRUEZU>>? HBRADKGKRSW;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<RPQAGIRUEZU> WPSZCAOOJFK;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<RPQAGIRUEZU> PMCNDQINMEJ;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<RPQAGIRUEZU> UXPKDGZJSNC;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<RPQAGIRUEZU> HTWWWJMAVFL;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<RPQAGIRUEZU> GUTHERGGARU;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<RPQAGIRUEZU> EYNOOWOMQMF;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<RPQAGIRUEZU> KWEOOTKOXMB;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<RPQAGIRUEZU> NXOPYGMEYQF;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<RPQAGIRUEZU> WGDZKFADDPL;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<RPQAGIRUEZU> ECFWLHEGKYV;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<RPQAGIRUEZU> MVGCYWCEIQZ;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<RPQAGIRUEZU> HVUCOQNZLAH;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<RPQAGIRUEZU> JBKCEUQPNHM;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<RPQAGIRUEZU> OGQQENJPAVU;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<RPQAGIRUEZU> XNMRTEEPDYU;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<RPQAGIRUEZU> WYWNZBKBZBB;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<RPQAGIRUEZU> TNAURUIMZWG;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<RPQAGIRUEZU> RGPWZGCWDVK;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<RPQAGIRUEZU> IFRLBNEUCWL;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<RPQAGIRUEZU> GWLOKHJYASQ;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<RPQAGIRUEZU> ERUQNAANOEL;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<RPQAGIRUEZU> BGUQXJPQFQU;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<RPQAGIRUEZU> JQVRFSHHJHK;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<RPQAGIRUEZU> XHXROJUYXCP;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<RPQAGIRUEZU> WYIZFPSBVZB;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<RPQAGIRUEZU> QKONIKTTCXI;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<RPQAGIRUEZU> HNYHDJDSUPL;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<RPQAGIRUEZU> JUXFEXSCCPI;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<RPQAGIRUEZU> JGSZTHKXTIO;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<RPQAGIRUEZU> MJDQORAOPDK;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<RPQAGIRUEZU> XNAJZGJEQZY;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<RPQAGIRUEZU> BZSQXLSOXAT;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<RPQAGIRUEZU> WIUOEOMPSAM;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<RPQAGIRUEZU> PJLMSGYNLVW;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<RPQAGIRUEZU> UXJUSCCROCG;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<RPQAGIRUEZU> BHYDMXMANKD;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<RPQAGIRUEZU> VTTOJNWEFCI;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<RPQAGIRUEZU> ZYWNPSRNFTT;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<RPQAGIRUEZU> KTFAMSRGJIB;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<RPQAGIRUEZU> YNCUAGQRGZB;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<RPQAGIRUEZU> NXNDIAFKSCU;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<RPQAGIRUEZU> DTPEAQCIRIU;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<RPQAGIRUEZU> WQSKPWIBMMR;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<RPQAGIRUEZU> LVNWIAFPIOQ;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<RPQAGIRUEZU> TTKUFQEYMYC;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<RPQAGIRUEZU> RYRXQWYAYIE;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<RPQAGIRUEZU> GCQOXZZBMOZ;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<RPQAGIRUEZU> VKNGVKKBVSF;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<RPQAGIRUEZU> VQBPBMTOASV;

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public static readonly Id32<RPQAGIRUEZU> VFSNNYYMYJK;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public static readonly Id32<RPQAGIRUEZU> GYHFXXTPEQE;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public static readonly Id32<RPQAGIRUEZU> IOJBYUAEGLT;

			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly Id32<RPQAGIRUEZU> KYCYHDJXJXQ;

			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly Id32<RPQAGIRUEZU> HZOBUOJPLCI;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Id32<RPQAGIRUEZU> KSWLPVKXFOH;

			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly Id32<RPQAGIRUEZU> ZBQFUVHZGUT;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Id32<RPQAGIRUEZU> DMJDXVCCVCD;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Id32<RPQAGIRUEZU> ZVTKPCFQFYL;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Id32<RPQAGIRUEZU> WHMQSJVMLOO;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Id32<RPQAGIRUEZU> ZJAISDFYEVP;

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly Id32<RPQAGIRUEZU> UQOJGAQOKBV;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Id32<RPQAGIRUEZU> LHTVVXOBPGZ;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Id32<RPQAGIRUEZU> FPTKCWQSAVM;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Id32<RPQAGIRUEZU> RSEXWRUXZIY;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Id32<RPQAGIRUEZU> FGVIICJHJUH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static IReadOnlyDictionary<Id32<RPQAGIRUEZU>, ITPOVZBMHGT> SATGTDRZRSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x2E0E9F0", Offset = "0x2E0D5F0", VA = "0x182E0E9F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2E0E830", Offset = "0x2E0D430", VA = "0x182E0E830")]
			public static ITPOVZBMHGT AEFXXQHSDFN(Id32<RPQAGIRUEZU> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2E0EC10", Offset = "0x2E0D810", VA = "0x182E0EC10")]
			public static bool RKPZIMBSLKI(Id32<RPQAGIRUEZU> id, [Out] ITPOVZBMHGT a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2E0E8B0", Offset = "0x2E0D4B0", VA = "0x182E0E8B0")]
			public static IDLCASSILBG CLAUNXILDIS(Id32<RPQAGIRUEZU> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2E0E960", Offset = "0x2E0D560", VA = "0x182E0E960")]
			private static Id32<RPQAGIRUEZU> ERBMWTZFFKA(ITPOVZBMHGT a, Id32<RPQAGIRUEZU> id)
			{
				return default(Id32<RPQAGIRUEZU>);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2E0EA40", Offset = "0x2E0D640", VA = "0x182E0EA40")]
			private static void OGJRKJSHUJE(Id32<RPQAGIRUEZU> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class SSDXOUEGMRM
		{
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				private IdUnsafeList<XBXCGKIEZZS, IDLCASSILBG?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
				private TypeRegistryFactory([In] IdUnsafeList<XBXCGKIEZZS, IDLCASSILBG?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x2E26EB0", Offset = "0x2E25AB0", VA = "0x182E26EB0")]
				public static TypeRegistryFactory Begin()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x2E26F10", Offset = "0x2E25B10", VA = "0x182E26F10")]
				public (ReadOnlyIdArray<XBXCGKIEZZS, IDLCASSILBG>, IReadOnlyDictionary<IDLCASSILBG, Id32<XBXCGKIEZZS>>) End()
				{
					return default((ReadOnlyIdArray<XBXCGKIEZZS, IDLCASSILBG>, IReadOnlyDictionary<IDLCASSILBG, Id32<XBXCGKIEZZS>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x2E272D0", Offset = "0x2E25ED0", VA = "0x182E272D0")]
				public Id32<XBXCGKIEZZS> UIXPYKEIWWY(int a, IDLCASSILBG b)
				{
					return default(Id32<XBXCGKIEZZS>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x2E27280", Offset = "0x2E25E80", VA = "0x182E27280")]
				public Id32<XBXCGKIEZZS> Initialize(int id, ZTFFPMGVSBN type, ZTFFPMGVSBN factoryType)
				{
					return default(Id32<XBXCGKIEZZS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000014")]
			[CompilerGenerated]
			private sealed class GQKEHVUMRHE : IEnumerable<IDLCASSILBG>, IEnumerable, IEnumerator<IDLCASSILBG>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private IDLCASSILBG DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private int RPOQDRFWNXK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool ESGTUJPGNNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool RASJGGVNCEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private RoomVersion IGPPVDSHXMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public RoomVersion JMWXGBMMRGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool DWCJQTKVWHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool LMAPZVIDWFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool GAINTVLEHCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool CREVJWFRSHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private bool EQOZOLUYXZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public bool QHKCFJWVNEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private IEnumerator<IDLCASSILBG> OKMXNYRHUZP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private IDLCASSILBG CDQAPLEAFYS;

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				private IDLCASSILBG NQIQWBPBGDR
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
				[DebuggerHidden]
				public GQKEHVUMRHE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x2E12500", Offset = "0x2E11100", VA = "0x182E12500", Slot = "7")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x2E12080", Offset = "0x2E10C80", VA = "0x182E12080", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x2E12470", Offset = "0x2E11070", VA = "0x182E12470")]
				private void QCWGZBRZQOC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x2E124C0", Offset = "0x2E110C0", VA = "0x182E124C0", Slot = "10")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2E11FD0", Offset = "0x2E10BD0", VA = "0x182E11FD0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<IDLCASSILBG> HNITARZXHFK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2E11FD0", Offset = "0x2E10BD0", VA = "0x182E11FD0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator ZFHLTDQPCLO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class YBAHGZJRSZO : IEnumerable<IDLCASSILBG>, IEnumerable, IEnumerator<IDLCASSILBG>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private IDLCASSILBG DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				private int RPOQDRFWNXK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private RoomVersion IGPPVDSHXMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public RoomVersion JMWXGBMMRGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool GAINTVLEHCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool CREVJWFRSHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool DWCJQTKVWHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool LMAPZVIDWFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool EQOZOLUYXZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool QHKCFJWVNEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool DXOFBMIGXEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool CXJDVRSWWKZ;

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				private IDLCASSILBG NQIQWBPBGDR
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
				[DebuggerHidden]
				public YBAHGZJRSZO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0x2E28AF0", Offset = "0x2E276F0", VA = "0x182E28AF0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2E2A800", Offset = "0x2E29400", VA = "0x182E2A800", Slot = "10")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x2E28A40", Offset = "0x2E27640", VA = "0x182E28A40", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<IDLCASSILBG> HNITARZXHFK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2E28A40", Offset = "0x2E27640", VA = "0x182E28A40", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator ZFHLTDQPCLO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class KMKNMRKUUCX : IEnumerable<Id32<XBXCGKIEZZS>>, IEnumerable, IEnumerator<Id32<XBXCGKIEZZS>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<XBXCGKIEZZS> DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int RPOQDRFWNXK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion IGPPVDSHXMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion JMWXGBMMRGT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool DWCJQTKVWHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool LMAPZVIDWFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool GAINTVLEHCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool CREVJWFRSHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool EQOZOLUYXZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool QHKCFJWVNEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private IEnumerator<IDLCASSILBG> OKMXNYRHUZP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				private IEnumerator<ZTFFPMGVSBN> OJXCWEJPSRO;

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				private Id32<XBXCGKIEZZS> BODJKLDGWWI
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<XBXCGKIEZZS>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0x2E162A0", Offset = "0x2E14EA0", VA = "0x182E162A0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x1659E00", Offset = "0x1658A00", VA = "0x181659E00")]
				[DebuggerHidden]
				public KMKNMRKUUCX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2E16970", Offset = "0x2E15570", VA = "0x182E16970", Slot = "7")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x2E162F0", Offset = "0x2E14EF0", VA = "0x182E162F0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2E16830", Offset = "0x2E15430", VA = "0x182E16830")]
				private void QCWGZBRZQOC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2E167E0", Offset = "0x2E153E0", VA = "0x182E167E0")]
				private void QCRABUYCHCT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2E16880", Offset = "0x2E15480", VA = "0x182E16880", Slot = "10")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2E168C0", Offset = "0x2E154C0", VA = "0x182E168C0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<XBXCGKIEZZS>> USFKVTTVYLF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2E168C0", Offset = "0x2E154C0", VA = "0x182E168C0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator ZFHLTDQPCLO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private static readonly Log DNBXSEXRPWR;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private static ReadOnlyIdArray<XBXCGKIEZZS, IDLCASSILBG?> ZQTFXJVFZON;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static IReadOnlyDictionary<IDLCASSILBG, Id32<XBXCGKIEZZS>> UNPXCPZPGJP;

			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public static readonly VYGAXGQUGRJ WCKECFQSJSY;

			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly VYGAXGQUGRJ OOIRLGKTMVE;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private static readonly HashSet<IDLCASSILBG> EQEXTXGFXDK;

			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public static List<IDLCASSILBG> BTHMTDDSPWL;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet HCGWOEBQHYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet DOSLRGCRODE
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static GetSet DYWAOZZJVQK
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static IDLCASSILBG FLCBRYZKXYC
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CA30", Offset = "0x2E1B630", VA = "0x182E1CA30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static IDLCASSILBG XFEJNGICUGE
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E860", Offset = "0x2E1D460", VA = "0x182E1E860")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static IDLCASSILBG JDXKMOZMQBR
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D2D0", Offset = "0x2E1BED0", VA = "0x182E1D2D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static IDLCASSILBG BSOXHEJHFGD
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DCE0", Offset = "0x2E1C8E0", VA = "0x182E1DCE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static IDLCASSILBG QGCOCLRDIJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DEF0", Offset = "0x2E1CAF0", VA = "0x182E1DEF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static IDLCASSILBG GQVRPZLOOAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E9B0", Offset = "0x2E1D5B0", VA = "0x182E1E9B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static IDLCASSILBG KEGULKMVQDP
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CF30", Offset = "0x2E1BB30", VA = "0x182E1CF30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static IDLCASSILBG RUOUQPKQQWD
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F770", Offset = "0x2E1E370", VA = "0x182E1F770")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static ZTFFPMGVSBN YFAANUWTLIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DB10", Offset = "0x2E1C710", VA = "0x182E1DB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static ZTFFPMGVSBN QZLIFIFLJAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C7B0", Offset = "0x2E1B3B0", VA = "0x182E1C7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static ZTFFPMGVSBN VISOQGBYXCV
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E330", Offset = "0x2E1CF30", VA = "0x182E1E330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static ZTFFPMGVSBN AHNNVZWVRBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CE20", Offset = "0x2E1BA20", VA = "0x182E1CE20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static ZTFFPMGVSBN WSTWNALKEQR
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2E1FB70", Offset = "0x2E1E770", VA = "0x182E1FB70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static ZTFFPMGVSBN BSJSYWPBIJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E550", Offset = "0x2E1D150", VA = "0x182E1E550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static ZTFFPMGVSBN PCFDHEURSXS
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E500", Offset = "0x2E1D100", VA = "0x182E1E500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static ZTFFPMGVSBN AADGSOUZHFE
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C410", Offset = "0x2E1B010", VA = "0x182E1C410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static ZTFFPMGVSBN LJLBPITYBBT
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CDD0", Offset = "0x2E1B9D0", VA = "0x182E1CDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static ZTFFPMGVSBN XLBQNHTHULD
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D220", Offset = "0x2E1BE20", VA = "0x182E1D220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static ZTFFPMGVSBN CKIOSNBEJIK
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C4C0", Offset = "0x2E1B0C0", VA = "0x182E1C4C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static ZTFFPMGVSBN TNNQIIORDCC
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D480", Offset = "0x2E1C080", VA = "0x182E1D480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static ZTFFPMGVSBN EZFEFYMUTIY
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E160", Offset = "0x2E1CD60", VA = "0x182E1E160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static ZTFFPMGVSBN TJTUDUEMRUP
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F860", Offset = "0x2E1E460", VA = "0x182E1F860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static ZTFFPMGVSBN IHUHPPJMBHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2E1FC20", Offset = "0x2E1E820", VA = "0x182E1FC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static ZTFFPMGVSBN ULEHORXJQZO
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CED0", Offset = "0x2E1BAD0", VA = "0x182E1CED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static ZTFFPMGVSBN UVOWSJBWUEY
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DAB0", Offset = "0x2E1C6B0", VA = "0x182E1DAB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static ZTFFPMGVSBN CUUBOYVGDWW
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E210", Offset = "0x2E1CE10", VA = "0x182E1E210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static ZTFFPMGVSBN BQDMMEODKWQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DE30", Offset = "0x2E1CA30", VA = "0x182E1DE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static ZTFFPMGVSBN OAGGLAMCNXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D270", Offset = "0x2E1BE70", VA = "0x182E1D270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static ZTFFPMGVSBN GKJHZEGOFKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E1B0", Offset = "0x2E1CDB0", VA = "0x182E1E1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static ZTFFPMGVSBN DCPIZSQTUGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C9D0", Offset = "0x2E1B5D0", VA = "0x182E1C9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static ZTFFPMGVSBN VVCRBAFIETI
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DFE0", Offset = "0x2E1CBE0", VA = "0x182E1DFE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static ZTFFPMGVSBN QAIGRGDYSGW
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F600", Offset = "0x2E1E200", VA = "0x182E1F600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static ZTFFPMGVSBN MTOUJGIUVHX
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F3C0", Offset = "0x2E1DFC0", VA = "0x182E1F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static ZTFFPMGVSBN WIRUKZFNREE
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C970", Offset = "0x2E1B570", VA = "0x182E1C970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static ZTFFPMGVSBN VGKBNUCFZPW
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E600", Offset = "0x2E1D200", VA = "0x182E1E600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static ZTFFPMGVSBN GGNTOONJMIK
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C690", Offset = "0x2E1B290", VA = "0x182E1C690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static ZTFFPMGVSBN HESBKEWDIIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F020", Offset = "0x2E1DC20", VA = "0x182E1F020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static ZTFFPMGVSBN VAFPBGAGRDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DC20", Offset = "0x2E1C820", VA = "0x182E1DC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static ZTFFPMGVSBN PVVJGGBAXDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DDD0", Offset = "0x2E1C9D0", VA = "0x182E1DDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static ZTFFPMGVSBN QKPZQTXCNFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E660", Offset = "0x2E1D260", VA = "0x182E1E660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static ZTFFPMGVSBN PIJFGDMBBPQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DE90", Offset = "0x2E1CA90", VA = "0x182E1DE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static ZTFFPMGVSBN OSUUWLYJAQR
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CE70", Offset = "0x2E1BA70", VA = "0x182E1CE70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static ZTFFPMGVSBN DVMVYDNNMNJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CB20", Offset = "0x2E1B720", VA = "0x182E1CB20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static ZTFFPMGVSBN XXPARQJFEBX
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D020", Offset = "0x2E1BC20", VA = "0x182E1D020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static ZTFFPMGVSBN UOJLYZGVQMQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F480", Offset = "0x2E1E080", VA = "0x182E1F480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static ZTFFPMGVSBN YKHOMMPXFHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D360", Offset = "0x2E1BF60", VA = "0x182E1D360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static ZTFFPMGVSBN CKXDGLZZEXF
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D420", Offset = "0x2E1C020", VA = "0x182E1D420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static ZTFFPMGVSBN HJRISGPXHFB
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F260", Offset = "0x2E1DE60", VA = "0x182E1F260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static ZTFFPMGVSBN QRFUYUMEJNF
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1FD80", Offset = "0x2E1E980", VA = "0x182E1FD80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static ZTFFPMGVSBN TXMDWQQBSRD
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C860", Offset = "0x2E1B460", VA = "0x182E1C860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static ZTFFPMGVSBN ELGAKHANUSO
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D9F0", Offset = "0x2E1C5F0", VA = "0x182E1D9F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static ZTFFPMGVSBN HLGXCJJZKCO
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D3C0", Offset = "0x2E1BFC0", VA = "0x182E1D3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static ZTFFPMGVSBN XPBQNYPQULT
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F800", Offset = "0x2E1E400", VA = "0x182E1F800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static ZTFFPMGVSBN WFKXYFMZDGX
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F540", Offset = "0x2E1E140", VA = "0x182E1F540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static ZTFFPMGVSBN IBYUJSZJXCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EDE0", Offset = "0x2E1D9E0", VA = "0x182E1EDE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static ZTFFPMGVSBN DSFCCNNHTIY
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E5A0", Offset = "0x2E1D1A0", VA = "0x182E1E5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static ZTFFPMGVSBN YWBDEUJINJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D160", Offset = "0x2E1BD60", VA = "0x182E1D160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static ZTFFPMGVSBN RNCWINPDBVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D590", Offset = "0x2E1C190", VA = "0x182E1D590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static ZTFFPMGVSBN FRIZMKYZSXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EF00", Offset = "0x2E1DB00", VA = "0x182E1EF00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static ZTFFPMGVSBN FKNUFNXNOEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DF80", Offset = "0x2E1CB80", VA = "0x182E1DF80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static ZTFFPMGVSBN TENMCMGJHWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E2D0", Offset = "0x2E1CED0", VA = "0x182E1E2D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static ZTFFPMGVSBN KYBCYFARINE
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CBE0", Offset = "0x2E1B7E0", VA = "0x182E1CBE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static ZTFFPMGVSBN MBKPRIPSKKS
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F8C0", Offset = "0x2E1E4C0", VA = "0x182E1F8C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static ZTFFPMGVSBN JTWJAPZWJNG
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D4D0", Offset = "0x2E1C0D0", VA = "0x182E1D4D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static ZTFFPMGVSBN SOYDXKGHSWA
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C570", Offset = "0x2E1B170", VA = "0x182E1C570")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static ZTFFPMGVSBN WHVIOJTQBVB
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E3E0", Offset = "0x2E1CFE0", VA = "0x182E1E3E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static ZTFFPMGVSBN AEAGIIDIUGI
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E6C0", Offset = "0x2E1D2C0", VA = "0x182E1E6C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static ZTFFPMGVSBN YOIBDYJPWQZ
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F360", Offset = "0x2E1DF60", VA = "0x182E1F360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static ZTFFPMGVSBN XJRBPSMOXUF
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C6F0", Offset = "0x2E1B2F0", VA = "0x182E1C6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static ZTFFPMGVSBN JSMIHZJNFGW
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C510", Offset = "0x2E1B110", VA = "0x182E1C510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static ZTFFPMGVSBN HQVHVZEKVUX
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F710", Offset = "0x2E1E310", VA = "0x182E1F710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static ZTFFPMGVSBN NXRDJLHLCLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CCA0", Offset = "0x2E1B8A0", VA = "0x182E1CCA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static ZTFFPMGVSBN TQRHCRSFFLU
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D6B0", Offset = "0x2E1C2B0", VA = "0x182E1D6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static ZTFFPMGVSBN YFQGLROBWZG
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F140", Offset = "0x2E1DD40", VA = "0x182E1F140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static ZTFFPMGVSBN GCSVGHIIAGE
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E380", Offset = "0x2E1CF80", VA = "0x182E1E380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static ZTFFPMGVSBN QSJIXAKXJJZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CD70", Offset = "0x2E1B970", VA = "0x182E1CD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static ZTFFPMGVSBN WBILAMYZQDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E270", Offset = "0x2E1CE70", VA = "0x182E1E270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static ZTFFPMGVSBN HHHFLIFHOFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2E1ED20", Offset = "0x2E1D920", VA = "0x182E1ED20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static ZTFFPMGVSBN BPCFDQPGYAG
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F200", Offset = "0x2E1DE00", VA = "0x182E1F200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static ZTFFPMGVSBN NNLXBKTBBQR
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C460", Offset = "0x2E1B060", VA = "0x182E1C460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static ZTFFPMGVSBN TAPZYSFWUBD
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DD70", Offset = "0x2E1C970", VA = "0x182E1DD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static ZTFFPMGVSBN TKZCYSBHKEY
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EE40", Offset = "0x2E1DA40", VA = "0x182E1EE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static ZTFFPMGVSBN YRPSRESJPQQ
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DB60", Offset = "0x2E1C760", VA = "0x182E1DB60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static ZTFFPMGVSBN YBVQOLTFVNB
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E8F0", Offset = "0x2E1D4F0", VA = "0x182E1E8F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static ZTFFPMGVSBN DXCRKHLIMKW
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CFC0", Offset = "0x2E1BBC0", VA = "0x182E1CFC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static ZTFFPMGVSBN PZNLBVVYITU
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F5A0", Offset = "0x2E1E1A0", VA = "0x182E1F5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static ZTFFPMGVSBN WFTJBBALMIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D990", Offset = "0x2E1C590", VA = "0x182E1D990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static ZTFFPMGVSBN UTPTGIUEQJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F4E0", Offset = "0x2E1E0E0", VA = "0x182E1F4E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static ZTFFPMGVSBN CPNOLYLCOHQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C750", Offset = "0x2E1B350", VA = "0x182E1C750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static ZTFFPMGVSBN EPBOAPMRYDR
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2E1FBC0", Offset = "0x2E1E7C0", VA = "0x182E1FBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static ZTFFPMGVSBN CABBUXWSAOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E950", Offset = "0x2E1D550", VA = "0x182E1E950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static ZTFFPMGVSBN LLZWODPBTFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CC40", Offset = "0x2E1B840", VA = "0x182E1CC40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static ZTFFPMGVSBN MFBBKEVCPRY
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F0E0", Offset = "0x2E1DCE0", VA = "0x182E1F0E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static ZTFFPMGVSBN BVKQWTFTYFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EF60", Offset = "0x2E1DB60", VA = "0x182E1EF60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static ZTFFPMGVSBN BFPXMWJMFCM
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C630", Offset = "0x2E1B230", VA = "0x182E1C630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static ZTFFPMGVSBN EUQNWKMWAQX
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F1A0", Offset = "0x2E1DDA0", VA = "0x182E1F1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static ZTFFPMGVSBN JDZNAIAZVLK
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1CAC0", Offset = "0x2E1B6C0", VA = "0x182E1CAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static ZTFFPMGVSBN LTIFWSLXSJL
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D1C0", Offset = "0x2E1BDC0", VA = "0x182E1D1C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static ZTFFPMGVSBN NTPMTYSKYNQ
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E100", Offset = "0x2E1CD00", VA = "0x182E1E100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static ZTFFPMGVSBN TXNSHFSSLBX
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E4A0", Offset = "0x2E1D0A0", VA = "0x182E1E4A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static ZTFFPMGVSBN GGCCDJIWRWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E720", Offset = "0x2E1D320", VA = "0x182E1E720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static ZTFFPMGVSBN GLDXQACTVZF
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2E1ECC0", Offset = "0x2E1D8C0", VA = "0x182E1ECC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static ZTFFPMGVSBN CLXYNILHART
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2E1ED80", Offset = "0x2E1D980", VA = "0x182E1ED80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static ZTFFPMGVSBN GCSTWTZZAEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2E1FC80", Offset = "0x2E1E880", VA = "0x182E1FC80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static ZTFFPMGVSBN DIJAPVGOQHT
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E780", Offset = "0x2E1D380", VA = "0x182E1E780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static ZTFFPMGVSBN FIIESTWFWQC
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F420", Offset = "0x2E1E020", VA = "0x182E1F420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static ZTFFPMGVSBN BRZSPYFALIQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EC60", Offset = "0x2E1D860", VA = "0x182E1EC60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static ZTFFPMGVSBN RMLCUVXWIOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D530", Offset = "0x2E1C130", VA = "0x182E1D530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static ZTFFPMGVSBN NBCBKTZOPRT
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DA50", Offset = "0x2E1C650", VA = "0x182E1DA50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static ZTFFPMGVSBN BEAAVROQJXW
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E0A0", Offset = "0x2E1CCA0", VA = "0x182E1E0A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static ZTFFPMGVSBN POCMKJEVYBC
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E040", Offset = "0x2E1CC40", VA = "0x182E1E040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static ZTFFPMGVSBN UMBGNKTCOMZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D5F0", Offset = "0x2E1C1F0", VA = "0x182E1D5F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static ZTFFPMGVSBN KQXRNLUBYXK
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EEA0", Offset = "0x2E1DAA0", VA = "0x182E1EEA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static ZTFFPMGVSBN GBXLZAAWQKT
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C5D0", Offset = "0x2E1B1D0", VA = "0x182E1C5D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static ZTFFPMGVSBN IFZIBVFYZIS
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x2E1C800", Offset = "0x2E1B400", VA = "0x182E1C800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static ZTFFPMGVSBN PDGAYQFSVJG
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x2E1E440", Offset = "0x2E1D040", VA = "0x182E1E440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static ZTFFPMGVSBN CIFMISPMZVV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DBC0", Offset = "0x2E1C7C0", VA = "0x182E1DBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static ZTFFPMGVSBN BTEWRGXZKIN
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x2E1D650", Offset = "0x2E1C250", VA = "0x182E1D650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static ZTFFPMGVSBN ADFLIJWMBIW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x2E1DC80", Offset = "0x2E1C880", VA = "0x182E1DC80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static ZTFFPMGVSBN LPXIQFSAERD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2E1F080", Offset = "0x2E1DC80", VA = "0x182E1F080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static ZTFFPMGVSBN UICOKSXRDVR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x2E1EFC0", Offset = "0x2E1DBC0", VA = "0x182E1EFC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2E1EB70", Offset = "0x2E1D770", VA = "0x182E1EB70")]
			public static VYGAXGQUGRJ RUEGSOZJBFF([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2E1D080", Offset = "0x2E1BC80", VA = "0x182E1D080")]
			public static ClassFactoryTypeParams GKZOTSQCWUC(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2E1D130", Offset = "0x2E1BD30", VA = "0x182E1D130")]
			public static ClassFactoryTypeParams GKZOTSQCWUC([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2E1CB80", Offset = "0x2E1B780", VA = "0x182E1CB80")]
			public static VYGAXGQUGRJ EFROISZXRKR(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2E1CBB0", Offset = "0x2E1B7B0", VA = "0x182E1CBB0")]
			public static VYGAXGQUGRJ EHRJLEHQFZW(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2E1EA40", Offset = "0x2E1D640", VA = "0x182E1EA40")]
			public static VYGAXGQUGRJ RTFBAXGQSIG([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2E1C8C0", Offset = "0x2E1B4C0", VA = "0x182E1C8C0")]
			public static IDLCASSILBG CLAUNXILDIS(Id32<XBXCGKIEZZS> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2E1CD00", Offset = "0x2E1B900", VA = "0x182E1CD00")]
			public static Id32<XBXCGKIEZZS>? ERBJPUKNTBN(IDLCASSILBG a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2E1FDE0", Offset = "0x2E1E9E0", VA = "0x182E1FDE0")]
			static SSDXOUEGMRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2E1FCE0", Offset = "0x2E1E8E0", VA = "0x182E1FCE0")]
			[IteratorStateMachine(typeof(YBAHGZJRSZO))]
			private static IEnumerable<IDLCASSILBG> ZAGPNPEEPEG(RoomVersion a, bool b, bool c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2E1F660", Offset = "0x2E1E260", VA = "0x182E1F660")]
			[IteratorStateMachine(typeof(GQKEHVUMRHE))]
			public static IEnumerable<IDLCASSILBG> XPMCOKYKRQH(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2E1F920", Offset = "0x2E1E520", VA = "0x182E1F920")]
			public static Variant YFTZYGUIOMY(IDLCASSILBG a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2E1D710", Offset = "0x2E1C310", VA = "0x182E1D710")]
			public static Variant JJQTDBGFATL(IDLCASSILBG a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2E1E7E0", Offset = "0x2E1D3E0", VA = "0x182E1E7E0")]
			public static bool QZZJNMTNTKD(IDLCASSILBG a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2E1F2C0", Offset = "0x2E1DEC0", VA = "0x182E1F2C0")]
			[IteratorStateMachine(typeof(KMKNMRKUUCX))]
			public static IEnumerable<Id32<XBXCGKIEZZS>> VPMGAOTZPBT(RoomVersion a, bool b, bool c, bool d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NodeRegistry Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly GraphRegistry Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly IdArray<TFITIOWUSRJ, ZHOBCASHLNG<INFKYHURQQV>> _nodeDefs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<INFKYHURQQV>> _graphDefs;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2E1C1B0", Offset = "0x2E1ADB0", VA = "0x182E1C1B0")]
		private Registry([In] NodeRegistry nodeDefRegistry, [In] GraphRegistry graphDefRegistry, IdArray<TFITIOWUSRJ, ZHOBCASHLNG<INFKYHURQQV>> nodeDefs, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<INFKYHURQQV>> graphDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2E1C040", Offset = "0x2E1AC40", VA = "0x182E1C040")]
		public static Registry New()
		{
			return default(Registry);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E1BBF0", Offset = "0x2E1A7F0", VA = "0x182E1BBF0")]
		public static void Destroy([In] Registry self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E1C030", Offset = "0x2E1AC30", VA = "0x182E1C030", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2E1BB10", Offset = "0x2E1A710", VA = "0x182E1BB10")]
		public static EVStaticStateSys<INFKYHURQQV> AJUSYSOCFCE([In] Registry self, [In] Graphs graphs, [In] EVGraphs evGraphs)
		{
			return default(EVStaticStateSys<INFKYHURQQV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E145B0", Offset = "0x2E131B0", VA = "0x182E145B0")]
		public static INFKYHURQQV VBLUVZJPMMJ([In] Registry self, [In] RRGraphs rrTree, [In] EVStaticStateSys<INFKYHURQQV> stateSys, [In] CompileSys compileSys, Id32<JQPVMRMCZNG> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class INFKYHURQQV : SDSCWGQDFYG, DCZUNSBMGOL<INFKYHURQQV>, WUFFHWSZOIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public readonly Registry RERRAOEGPYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private RRGraphs JOPMTXXVYYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private EVStaticStateSys<INFKYHURQQV> XUWIFEVDTUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private CompileSys KMSHZQMWXDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public readonly Id32<JQPVMRMCZNG> SLLPJUYSWJI;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E158C0", Offset = "0x2E144C0", VA = "0x182E158C0")]
		private INFKYHURQQV([In] Registry registry, [In] RRGraphs rrGraphs, [In] EVStaticStateSys<INFKYHURQQV> stateSys, [In] CompileSys compileSys, Id32<JQPVMRMCZNG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E145B0", Offset = "0x2E131B0", VA = "0x182E145B0")]
		public static INFKYHURQQV HVKYDMYBGAZ([In] Registry registry, [In] RRGraphs rrGraphs, [In] EVStaticStateSys<INFKYHURQQV> stateSys, [In] CompileSys compileSys, Id32<JQPVMRMCZNG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2E13A10", Offset = "0x2E12610", VA = "0x182E13A10", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A60", Offset = "0x2DF2660", VA = "0x182DF3A60", Slot = "8")]
		public EVStaticStateSys<INFKYHURQQV> XHYHTYCHCDE()
		{
			return default(EVStaticStateSys<INFKYHURQQV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A50", Offset = "0x2DF2650", VA = "0x182DF3A50")]
		public RRGraphs GDKOATBBKVK()
		{
			return default(RRGraphs);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C21080", Offset = "0x3C1FC80", VA = "0x183C21080")]
		public Id32<a> VUDVFVBFNFJ<a>(Id32<JQPVMRMCZNG> a) where a : EVGraph.LPCAELTSUGD
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C20D80", Offset = "0x3C1F980", VA = "0x183C20D80")]
		public Id32<b> IZTWWMWWCSJ<b>(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b) where b : EVNode.LPCAELTSUGD
		{
			return default(Id32<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2E12770", Offset = "0x2E11370", VA = "0x182E12770")]
		internal Graphs AJINMUHXABQ()
		{
			return default(Graphs);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2E139D0", Offset = "0x2E125D0", VA = "0x182E139D0")]
		internal EVGraphs DONDVHDEJOT()
		{
			return default(EVGraphs);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A60", Offset = "0x2DF2660", VA = "0x182DF3A60")]
		internal EVStaticStateSys<INFKYHURQQV> YVGAVDTQBOU()
		{
			return default(EVStaticStateSys<INFKYHURQQV>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A50", Offset = "0x2DF2650", VA = "0x182DF3A50")]
		internal RRGraphs FTJXTMVLKZY()
		{
			return default(RRGraphs);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E158B0", Offset = "0x2E144B0", VA = "0x182E158B0")]
		internal CompileSys ZGAZISRXMZB()
		{
			return default(CompileSys);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C20FF0", Offset = "0x3C1FBF0", VA = "0x183C20FF0")]
		public void MYOUENDXCHU<c>(Id32<JQPVMRMCZNG> a, Id32<c> b) where c : EVGraph.LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C20C90", Offset = "0x3C1F890", VA = "0x183C20C90")]
		public void FYMRPBRLFCA<d>(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, Id32<d> c) where d : EVNode.LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E14730", Offset = "0x2E13330", VA = "0x182E14730", Slot = "9")]
		public PerfScopeDelegates LVOSKEQMYKA()
		{
			return default(PerfScopeDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E15840", Offset = "0x2E14440", VA = "0x182E15840", Slot = "10")]
		public Variant ZDBDVDPMPJD(IDLCASSILBG a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2E14500", Offset = "0x2E13100", VA = "0x182E14500", Slot = "11")]
		public bool HHUCKYSJXHJ(IDLCASSILBG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E150F0", Offset = "0x2E13CF0", VA = "0x182E150F0", Slot = "4")]
		private void NADBILPTQNP(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, RootInstantiation c, Id32<GraphInstantiation.M>? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E153A0", Offset = "0x2E13FA0", VA = "0x182E153A0", Slot = "5")]
		private void REBNWWAHOMJ(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E14470", Offset = "0x2E13070", VA = "0x182E14470", Slot = "6")]
		private void GGNBITEUCET(Id32<JQPVMRMCZNG> a, RootInstantiation b, Id32<GraphInstantiation.M>? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E13070", Offset = "0x2E11C70", VA = "0x182E13070", Slot = "7")]
		private void BSLRVXJWXKL(Id32<JQPVMRMCZNG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2E15230", Offset = "0x2E13E30", VA = "0x182E15230")]
		internal Result<Id32<LWYTCPIHOQE>, NJKZNHRVAZM> PIUJLQXQDVC(Id32<JQPVMRMCZNG> a, Id32<TFITIOWUSRJ> b, [In] CircuitsVec3 localPosition, [In] CircuitsQuat localRotation, RootInstantiation c, Id32<GraphInstantiation.M>? d)
		{
			return default(Result<Id32<LWYTCPIHOQE>, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E14390", Offset = "0x2E12F90", VA = "0x182E14390")]
		internal Id32<LWYTCPIHOQE> FOVGWCWPFOE(Id32<JQPVMRMCZNG> a, Id32<TFITIOWUSRJ> b, [In] CircuitsVec3 localPosition, [In] CircuitsQuat localRotation, RootInstantiation c, Id32<GraphInstantiation.M>? d)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2E151A0", Offset = "0x2E13DA0", VA = "0x182E151A0")]
		internal Result<None, NJKZNHRVAZM> OOCFGWYQFRH(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b)
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C21120", Offset = "0x3C1FD20", VA = "0x183C21120")]
		public Result<Id32<e>, NJKZNHRVAZM> YFZHJAXYYIN<e>(Id32<JQPVMRMCZNG> a, Id32<TZJZKVJCHTJ> b) where e : EVGraph.LPCAELTSUGD
		{
			return default(Result<Id32<e>, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C20E20", Offset = "0x3C1FA20", VA = "0x183C20E20")]
		public Result<Id32<f>, NJKZNHRVAZM> MEWIEFHQLCL<f>(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, Id32<TFITIOWUSRJ> c) where f : EVNode.LPCAELTSUGD
		{
			return default(Result<Id32<f>, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2E15460", Offset = "0x2E14060", VA = "0x182E15460")]
		private Result<(Id32<RBVCLSMADFT.M>, Id32<CJRCNARJFOD.M>), NJKZNHRVAZM> TVYQXTCXNNR(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b)
		{
			return default(Result<(Id32<RBVCLSMADFT.M>, Id32<CJRCNARJFOD.M>), NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E130E0", Offset = "0x2E11CE0", VA = "0x182E130E0")]
		internal Result<(Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>), NJKZNHRVAZM> DDFNGWROLNO(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c, [In] NamedType type)
		{
			return default(Result<(Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>), NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2E127B0", Offset = "0x2E113B0", VA = "0x182E127B0")]
		internal Result<None, NJKZNHRVAZM> BEKRTQIIEEP(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c)
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2E14770", Offset = "0x2E13370", VA = "0x182E14770")]
		internal Result<(Id32<IEQQYWIVYHH>, Id32<AWZVWRTEXTC>), NJKZNHRVAZM> MNEDDWFMLXD(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c, [In] NamedType type)
		{
			return default(Result<(Id32<IEQQYWIVYHH>, Id32<AWZVWRTEXTC>), NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E13A90", Offset = "0x2E12690", VA = "0x182E13A90")]
		internal Result<None, NJKZNHRVAZM> FKXGDFMPOWM(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c)
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
}
namespace Circuits.Static.RecRoom.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct CompileSys
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public SOAField<CJRCNARJFOD.M, FunctionCompileState> FunctionCompileStates;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private CompileSys([In] SOAField<CJRCNARJFOD.M, FunctionCompileState> functionCompileStates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E0E080", Offset = "0x2E0CC80", VA = "0x182E0E080")]
		public static CompileSys New()
		{
			return default(CompileSys);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class QUBJQUDZXAS
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E19D50", Offset = "0x2E18950", VA = "0x182E19D50")]
		public static void Destroy(this CompileSys self, [In] SOAId32<CJRCNARJFOD.M> functionGraphIds)
		{
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class LAJDHSVTGLT
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E17010", Offset = "0x2E15C10", VA = "0x182E17010")]
		public static RootData HHVZPFZEWXT(INFKYHURQQV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E17160", Offset = "0x2E15D60", VA = "0x182E17160")]
		public static RootData LRGOPVDXZHX(Id32<TZJZKVJCHTJ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class RILPNJNOIRX
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E1AA10", Offset = "0x2E19610", VA = "0x182E1AA10")]
		public static AQQOEIZKMIU HHVZPFZEWXT(this IDLCASSILBG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E19EA0", Offset = "0x2E18AA0", VA = "0x182E19EA0")]
		public static IDLCASSILBG GBPRBWZJNOI(this AQQOEIZKMIU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class WUGGOTCHLTA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x41BDD00", Offset = "0x41BC900", VA = "0x1841BDD00")]
		public static Dictionary<b, c> UBJPMOQZZHC<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class MXDEITSIUEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2E19010", Offset = "0x2E17C10", VA = "0x182E19010")]
		public static SJEFRFHWVRM HHVZPFZEWXT([In] this EVGraph self, [In] GraphSys graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2E18890", Offset = "0x2E17490", VA = "0x182E18890")]
		public static EVGraph GBPRBWZJNOI(this SJEFRFHWVRM a, [In] GraphSys graph)
		{
			return default(EVGraph);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class BUUENDEYOWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2E0DD90", Offset = "0x2E0C990", VA = "0x182E0DD90")]
		public static AQSBVOHFYLN HHVZPFZEWXT([In] this EVGraphs self, [In] Graphs baseGraphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2E0DAD0", Offset = "0x2E0C6D0", VA = "0x182E0DAD0")]
		public static EVGraphs GBPRBWZJNOI(this AQSBVOHFYLN a, [In] Graphs baseGraphs)
		{
			return default(EVGraphs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class BJHVOZATGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D8F0", Offset = "0x2E0C4F0", VA = "0x182E0D8F0")]
		public static RSELGHYNOUO HHVZPFZEWXT([In] this EVInput self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D840", Offset = "0x2E0C440", VA = "0x182E0D840")]
		public static EVInput GBPRBWZJNOI(this RSELGHYNOUO a)
		{
			return default(EVInput);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class XSADJBBBGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2E289C0", Offset = "0x2E275C0", VA = "0x182E289C0")]
		public static NVKSFUFVTLM HHVZPFZEWXT([In] this EVNode self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2E28940", Offset = "0x2E27540", VA = "0x182E28940")]
		public static EVNode GBPRBWZJNOI(this NVKSFUFVTLM a)
		{
			return default(EVNode);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class VOIOKBCJMXW
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2E28790", Offset = "0x2E27390", VA = "0x182E28790")]
		public static QLPULBVSRZN HHVZPFZEWXT([In] this EVOutput self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2E28710", Offset = "0x2E27310", VA = "0x182E28710")]
		public static EVOutput GBPRBWZJNOI(this QLPULBVSRZN a)
		{
			return default(EVOutput);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class PHUPHHTDFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3E12230", Offset = "0x3E10E30", VA = "0x183E12230")]
		public static EXAXIFPGNJY HHVZPFZEWXT<a>([In] this EVStaticStateSys<a> self) where a : DCZUNSBMGOL<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2E19930", Offset = "0x2E18530", VA = "0x182E19930")]
		public static EVStaticStateSys<INFKYHURQQV> GBPRBWZJNOI(this EXAXIFPGNJY a, [In] Registry registry)
		{
			return default(EVStaticStateSys<INFKYHURQQV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class KZSQMOQJLHS
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2E16DB0", Offset = "0x2E159B0", VA = "0x182E16DB0")]
		public static SGTMLMVLTEH HHVZPFZEWXT([In] this CJRCNARJFOD.Inst self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2E16AC0", Offset = "0x2E156C0", VA = "0x182E16AC0")]
		public static CJRCNARJFOD.Inst GBPRBWZJNOI(this SGTMLMVLTEH a)
		{
			return default(CJRCNARJFOD.Inst);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class MELTWJAUQVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2E18820", Offset = "0x2E17420", VA = "0x182E18820")]
		public static ODZFLSFOPOJ HHVZPFZEWXT([In] this RBVCLSMADFT.Inst self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2E187D0", Offset = "0x2E173D0", VA = "0x182E187D0")]
		public static RBVCLSMADFT.Inst GBPRBWZJNOI(this ODZFLSFOPOJ a)
		{
			return default(RBVCLSMADFT.Inst);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class EFDYIUTZWUZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2E0E510", Offset = "0x2E0D110", VA = "0x182E0E510")]
		public static GraphsData HHVZPFZEWXT([In] this Graphs self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2E0E2B0", Offset = "0x2E0CEB0", VA = "0x182E0E2B0")]
		public static Graphs GBPRBWZJNOI(this GraphsData a)
		{
			return default(Graphs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class JRIZKPJLDUF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2E15BD0", Offset = "0x2E147D0", VA = "0x182E15BD0")]
		public static XXPINLWRNKE HHVZPFZEWXT([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2E15B30", Offset = "0x2E14730", VA = "0x182E15B30")]
		public static Guid GBPRBWZJNOI(XXPINLWRNKE a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class HUIDLMMJAZC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2E126F0", Offset = "0x2E112F0", VA = "0x182E126F0")]
		public static CMQDAWOFWED HHVZPFZEWXT([In] this InputGroups self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2E12650", Offset = "0x2E11250", VA = "0x182E12650")]
		public static InputGroups GBPRBWZJNOI(this CMQDAWOFWED a)
		{
			return default(InputGroups);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class QREEUWMUBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2E19CC0", Offset = "0x2E188C0", VA = "0x182E19CC0")]
		public static UGCJMFXJEEW HHVZPFZEWXT([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2E19C60", Offset = "0x2E18860", VA = "0x182E19C60")]
		public static NamedType GBPRBWZJNOI(this UGCJMFXJEEW a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class GMLQHGVWVOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2E11F50", Offset = "0x2E10B50", VA = "0x182E11F50")]
		public static HFFLTWHKKGA HHVZPFZEWXT([In] this OutputGroups self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2E11EB0", Offset = "0x2E10AB0", VA = "0x182E11EB0")]
		public static OutputGroups GBPRBWZJNOI(this HFFLTWHKKGA a)
		{
			return default(OutputGroups);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class QMOMDBYGZTG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B5F0", Offset = "0x3F0A1F0", VA = "0x183F0B5F0")]
		public static void KSTNMDLCPUW<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B850", Offset = "0x3F0A450", VA = "0x183F0B850")]
		public static void KSTNMDLCPUW<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class LBYOLLMSVTG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2E17B90", Offset = "0x2E16790", VA = "0x182E17B90")]
		public static IUEJNGFQVVZ HHVZPFZEWXT([In] this RRGraph self, [In] GraphSys graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2E17840", Offset = "0x2E16440", VA = "0x182E17840")]
		public static RRGraph GBPRBWZJNOI(this IUEJNGFQVVZ a, [In] GraphSys graph)
		{
			return default(RRGraph);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class LYDOQFGBGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2E18300", Offset = "0x2E16F00", VA = "0x182E18300")]
		public static PCZIFCMBPDC HHVZPFZEWXT([In] this RRGraphs self, [In] Graphs baseGraphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2E17E70", Offset = "0x2E16A70", VA = "0x182E17E70")]
		public static RRGraphs GBPRBWZJNOI(this PCZIFCMBPDC a, [In] Graphs baseGraphs)
		{
			return default(RRGraphs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class WYCNKPHOGJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2E288B0", Offset = "0x2E274B0", VA = "0x182E288B0")]
		public static FRCWFLSHAGJ HHVZPFZEWXT([In] this RRNode self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2E28800", Offset = "0x2E27400", VA = "0x182E28800")]
		public static RRNode GBPRBWZJNOI(this FRCWFLSHAGJ a)
		{
			return default(RRNode);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class KJSVNJSZZUG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2E161B0", Offset = "0x2E14DB0", VA = "0x182E161B0")]
		public static BADRBYUNRQR HHVZPFZEWXT(this INFKYHURQQV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2E15CD0", Offset = "0x2E148D0", VA = "0x182E15CD0")]
		public static INFKYHURQQV GBPRBWZJNOI(this BADRBYUNRQR a, [In] Registry registry)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class TVTNZOPOOPR
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2E26CF0", Offset = "0x2E258F0", VA = "0x182E26CF0")]
		public static ZUNCMYGRYZE HHVZPFZEWXT([In] this Variant self, IDLCASSILBG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2E26BA0", Offset = "0x2E257A0", VA = "0x182E26BA0")]
		public static Variant GBPRBWZJNOI(this ZUNCMYGRYZE a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.Payload
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct AddEdgePayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public readonly Id32<IEQQYWIVYHH> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public readonly Id32<AWZVWRTEXTC> DstId;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xF16A30", Offset = "0xF15630", VA = "0x180F16A30")]
		private AddEdgePayload(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D420", Offset = "0x2E0C020", VA = "0x182E0D420")]
		public static ReduceAction<ActionKind, AddEdgePayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, AddEdgePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3561850", Offset = "0x3560450", VA = "0x183561850")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] AddEdgePayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct AddGraphPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public readonly Id32<JQPVMRMCZNG>? ParentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly Id32<TZJZKVJCHTJ> GraphDefId;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF770", Offset = "0x2DBE370", VA = "0x182DBF770")]
		private AddGraphPayload(Id32<JQPVMRMCZNG>? parentGraphId, Id32<TZJZKVJCHTJ> graphDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D4F0", Offset = "0x2E0C0F0", VA = "0x182E0D4F0")]
		public static ReduceAction<ActionKind, AddGraphPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, AddGraphPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3561B00", Offset = "0x3560700", VA = "0x183561B00")]
		public static Result<Id32<JQPVMRMCZNG>, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] AddGraphPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<Id32<JQPVMRMCZNG>, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct AddInputToGroupPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public readonly Id32<VPKCJSHTFFF> InputDefId;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xF16A30", Offset = "0xF15630", VA = "0x180F16A30")]
		private AddInputToGroupPayload(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<VPKCJSHTFFF> inputDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D5D0", Offset = "0x2E0C1D0", VA = "0x182E0D5D0")]
		public static ReduceAction<ActionKind, AddInputToGroupPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, AddInputToGroupPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3561D90", Offset = "0x3560990", VA = "0x183561D90")]
		public static Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] AddInputToGroupPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct AddNodePayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public readonly Id32<TFITIOWUSRJ> NodeDef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public readonly CircuitsVec3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public readonly CircuitsQuat LocalRotation;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D810", Offset = "0x2E0C410", VA = "0x182E0D810")]
		private AddNodePayload(Id32<JQPVMRMCZNG> graphId, Id32<TFITIOWUSRJ> nodeDef, [In] CircuitsVec3 localSpacePosition, [In] CircuitsQuat localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D6A0", Offset = "0x2E0C2A0", VA = "0x182E0D6A0")]
		public static ReduceAction<ActionKind, AddNodePayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, AddNodePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3562030", Offset = "0x3560C30", VA = "0x183562030")]
		public static Result<Id32<LWYTCPIHOQE>, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] AddNodePayload self) where a : HIEMMFGSUTF
		{
			return default(Result<Id32<LWYTCPIHOQE>, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FunctionNodeAddInputPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly int InputIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly NamedType Type;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2E11B90", Offset = "0x2E10790", VA = "0x182E11B90")]
		private FunctionNodeAddInputPayload(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, int outputIndex, NamedType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2E11A20", Offset = "0x2E10620", VA = "0x182E11A20")]
		public static ReduceAction<ActionKind, FunctionNodeAddInputPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, FunctionNodeAddInputPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3BBADB0", Offset = "0x3BB99B0", VA = "0x183BBADB0")]
		public static Result<(Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>), NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] FunctionNodeAddInputPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<(Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>), NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct FunctionNodeAddOutputPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public readonly int OutputIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public readonly NamedType Type;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2E11B90", Offset = "0x2E10790", VA = "0x182E11B90")]
		private FunctionNodeAddOutputPayload(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, int outputIndex, NamedType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2E11BC0", Offset = "0x2E107C0", VA = "0x182E11BC0")]
		public static ReduceAction<ActionKind, FunctionNodeAddOutputPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, FunctionNodeAddOutputPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3BBAFF0", Offset = "0x3BB9BF0", VA = "0x183BBAFF0")]
		public static Result<(Id32<IEQQYWIVYHH>, Id32<AWZVWRTEXTC>), NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] FunctionNodeAddOutputPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<(Id32<IEQQYWIVYHH>, Id32<AWZVWRTEXTC>), NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct FunctionNodeRemoveInputPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public readonly int InputIndex;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xF16A30", Offset = "0xF15630", VA = "0x180F16A30")]
		private FunctionNodeRemoveInputPayload(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2E11D30", Offset = "0x2E10930", VA = "0x182E11D30")]
		public static ReduceAction<ActionKind, FunctionNodeRemoveInputPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, FunctionNodeRemoveInputPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB220", Offset = "0x3BB9E20", VA = "0x183BBB220")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] FunctionNodeRemoveInputPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct FunctionNodeRemoveOutputPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public readonly int OutputIndex;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF16A30", Offset = "0xF15630", VA = "0x180F16A30")]
		private FunctionNodeRemoveOutputPayload(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2E11DF0", Offset = "0x2E109F0", VA = "0x182E11DF0")]
		public static ReduceAction<ActionKind, FunctionNodeRemoveOutputPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, FunctionNodeRemoveOutputPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB440", Offset = "0x3BBA040", VA = "0x183BBB440")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] FunctionNodeRemoveOutputPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct InputSetDefaultValuePayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public readonly Id32<AWZVWRTEXTC> InputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public readonly Variant DefaultValue;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2E15B10", Offset = "0x2E14710", VA = "0x182E15B10")]
		private InputSetDefaultValuePayload(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId, [In] Variant defaultValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2E15A00", Offset = "0x2E14600", VA = "0x182E15A00")]
		public static ReduceAction<ActionKind, InputSetDefaultValuePayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, InputSetDefaultValuePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3C39220", Offset = "0x3C37E20", VA = "0x183C39220")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] InputSetDefaultValuePayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct RemoveEdgePayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public readonly Id32<IEQQYWIVYHH> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public readonly Id32<AWZVWRTEXTC> DstId;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xF16A30", Offset = "0xF15630", VA = "0x180F16A30")]
		private RemoveEdgePayload(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2E1C200", Offset = "0x2E1AE00", VA = "0x182E1C200")]
		public static ReduceAction<ActionKind, RemoveEdgePayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, RemoveEdgePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1640", Offset = "0x3FD0240", VA = "0x183FD1640")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] RemoveEdgePayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct RemoveGraphPayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
		private RemoveGraphPayload(Id32<JQPVMRMCZNG> graphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2E1C2D0", Offset = "0x2E1AED0", VA = "0x182E1C2D0")]
		public static ReduceAction<ActionKind, RemoveGraphPayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, RemoveGraphPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1A70", Offset = "0x3FD0670", VA = "0x183FD1A70")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] RemoveGraphPayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct RemoveNodePayload
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		private RemoveNodePayload(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2E1C350", Offset = "0x2E1AF50", VA = "0x182E1C350")]
		public static ReduceAction<ActionKind, RemoveNodePayload> UYYAKCXVFJE(FJCTCRTIJZZ a)
		{
			return default(ReduceAction<ActionKind, RemoveNodePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1E80", Offset = "0x3FD0A80", VA = "0x183FD1E80")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ<a>(a a, [In] RemoveNodePayload self) where a : HIEMMFGSUTF
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class AUKCCXTYNRH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Id128<VSIOWTDHCSD> RCREIWQDNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public readonly bool HQUOQIPBDSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public readonly bool OCAFYXZAUHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public readonly bool YKXBCXMSKBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public readonly bool RKAMUADHHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public readonly bool RJKSCFVPFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public readonly bool GSMAWREBLXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public readonly bool MYADAKAXWSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly bool CLCIAATVUPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly List<(string Name, IDLCASSILBG Type)> BBCISPINFXF;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[WillBeRenamedTo("LegacyId")]
		public Guid AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x2DCE5F0", Offset = "0x2DCD1F0", VA = "0x182DCE5F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public Id128<VSIOWTDHCSD> LQQZLPINUTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x2DCE5F0", Offset = "0x2DCD1F0", VA = "0x182DCE5F0")]
			get
			{
				return default(Id128<VSIOWTDHCSD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public IReadOnlyList<(string Name, IDLCASSILBG Type)> DLPVNQMDFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LCJUMWPNEGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2E0CF00", Offset = "0x2E0BB00", VA = "0x182E0CF00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2E0CD70", Offset = "0x2E0B970", VA = "0x182E0CD70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, IDLCASSILBG> TIVINWDSFKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C3C0", Offset = "0x2E0AFC0", VA = "0x182E0C3C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C1A0", Offset = "0x2E0ADA0", VA = "0x182E0C1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CQYSJPFFBSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2E0CFA0", Offset = "0x2E0BBA0", VA = "0x182E0CFA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C990", Offset = "0x2E0B590", VA = "0x182E0C990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> XBNLRMLCIJF
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C740", Offset = "0x2E0B340", VA = "0x182E0C740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C690", Offset = "0x2E0B290", VA = "0x182E0C690")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, IDLCASSILBG> ISUQTXVQJPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2E0C7F0", Offset = "0x2E0B3F0", VA = "0x182E0C7F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2E0CCC0", Offset = "0x2E0B8C0", VA = "0x182E0CCC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ATTAFDRQELQ
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2E0D050", Offset = "0x2E0BC50", VA = "0x182E0D050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2E0CAB0", Offset = "0x2E0B6B0", VA = "0x182E0CAB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x27D3DF0", Offset = "0x27D29F0", VA = "0x1827D3DF0")]
		public void AWWACJCBUNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D330", Offset = "0x2E0BF30", VA = "0x182E0D330")]
		internal AUKCCXTYNRH([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, IDLCASSILBG Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C250", Offset = "0x2E0AE50", VA = "0x182E0C250")]
		public static CircuitEventDefinitionFactoryStart Begin(string id, string name, bool isBeta = false, bool isDevOnly = false, bool isDeprecated = false, bool isValidInRooms1 = true, bool isValidInRooms2 = true, bool canBeLogged = true, bool isVisibleBuiltInEvent = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C340", Offset = "0x2E0AF40", VA = "0x182E0C340")]
		public static CircuitEventDefinitionFactoryStart Begin(Guid id, string name, bool isBeta = false, bool isDevOnly = false, bool isDeprecated = false, bool isValidInRooms1 = true, bool isValidInRooms2 = true, bool canBeLogged = true, bool isVisibleBuiltInEvent = false, bool isMessage = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2E0CB50", Offset = "0x2E0B750", VA = "0x182E0CB50")]
		public static AUKCCXTYNRH TWFCZDRDTTY([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D0F0", Offset = "0x2E0BCF0", VA = "0x182E0D0F0")]
		public static AUKCCXTYNRH ZWEESNXBOHS([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xF212A0", Offset = "0xF1FEA0", VA = "0x180F212A0")]
		public void VHPLGPYSDMI(Id128<VSIOWTDHCSD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2E0CC60", Offset = "0x2E0B860", VA = "0x182E0CC60")]
		public void UHWKXMAANUX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2E0CE10", Offset = "0x2E0BA10", VA = "0x182E0CE10")]
		public void VOOEZFPQQRN(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C8A0", Offset = "0x2E0B4A0", VA = "0x182E0C8A0")]
		public void JOGZCVICQKA(int a, IDLCASSILBG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C570", Offset = "0x2E0B170", VA = "0x182E0C570")]
		public void DJNMIHODFFC(string a, IDLCASSILBG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2E0CA40", Offset = "0x2E0B640", VA = "0x182E0CA40")]
		public void NJLDMNHVMLX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C470", Offset = "0x2E0B070", VA = "0x182E0C470")]
		public AUKCCXTYNRH Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public readonly struct CircuitEventDefinitionFactoryStart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D450", Offset = "0x2E2C050", VA = "0x182E2D450")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D2E0", Offset = "0x2E2BEE0", VA = "0x182E2D2E0")]
		public CircuitEventDefinitionFactoryParams NPRZJOAFCLU(string a, IDLCASSILBG b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D1B0", Offset = "0x2E2BDB0", VA = "0x182E2D1B0")]
		public AUKCCXTYNRH End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct CircuitEventDefinitionFactoryParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly Guid _id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly bool _isBeta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly bool _isDevOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly bool _isDeprecated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly bool _isValidInRooms1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly bool _isValidInRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly bool _canBeLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly bool _isVisibleBuiltInEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly bool _isMessageEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly List<(string Name, IDLCASSILBG Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D120", Offset = "0x2E2BD20", VA = "0x182E2D120")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, IDLCASSILBG Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2E2CFF0", Offset = "0x2E2BBF0", VA = "0x182E2CFF0")]
		public CircuitEventDefinitionFactoryParams NPRZJOAFCLU(string a, IDLCASSILBG b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2E2CEF0", Offset = "0x2E2BAF0", VA = "0x182E2CEF0")]
		public AUKCCXTYNRH End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class VCKVORIDXUG
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly AUKCCXTYNRH OCVATJIKNJZ;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly AUKCCXTYNRH PWSYOCVCXLC;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly AUKCCXTYNRH AAPNGEZQNIP;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly AUKCCXTYNRH UAWSCTNKVBC;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly AUKCCXTYNRH HTQIUVPSPTV;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly AUKCCXTYNRH UFRJJLOLZMD;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly AUKCCXTYNRH XWZUOJJSNZS;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			internal static readonly AUKCCXTYNRH[] MSXKJZBIXSN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class PMCNDQINMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly AUKCCXTYNRH EVQZVEBXSYL;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class UXPKDGZJSNC
		{
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly AUKCCXTYNRH SPWBKMKNHRH;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly AUKCCXTYNRH UPXMQVYCXBM;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class LHTVVXOBPGZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly AUKCCXTYNRH KMYDWNNRKIW;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly AUKCCXTYNRH RWEHDHSSCDF;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			internal static readonly AUKCCXTYNRH[] YTDBZWAHVRL;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly AUKCCXTYNRH TQOCTRGCZPD;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly AUKCCXTYNRH BSHAFKNIAXK;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class GCQOXZZBMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly AUKCCXTYNRH OWOZUPKMHCY;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly AUKCCXTYNRH DGSWJWXNCSJ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class GUTHERGGARU
		{
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly AUKCCXTYNRH CKCBNXMFZND;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly AUKCCXTYNRH IJISOEKIGTK;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class EYNOOWOMQMF
		{
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly AUKCCXTYNRH SPWBKMKNHRH;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly AUKCCXTYNRH UPXMQVYCXBM;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class KWEOOTKOXMB
		{
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly AUKCCXTYNRH TWURRYROLAI;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly AUKCCXTYNRH VQKHZNWONBZ;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly AUKCCXTYNRH RSJUKMAYZVP;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly AUKCCXTYNRH VMOGBHHDCJX;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly AUKCCXTYNRH TTIRKAZDODE;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly AUKCCXTYNRH KQUKDJDUBAD;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly AUKCCXTYNRH OLXAZPHUVES;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class NXOPYGMEYQF
		{
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class WGDZKFADDPL
		{
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class KTFAMSRGJIB
		{
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class ECFWLHEGKYV
		{
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly AUKCCXTYNRH WCBQNABJPFU;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly AUKCCXTYNRH HGRPAGJXERR;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class KSWLPVKXFOH
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class MVGCYWCEIQZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class HVUCOQNZLAH
		{
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class RYRXQWYAYIE
		{
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly AUKCCXTYNRH AEEBXPWVFIW;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly AUKCCXTYNRH DHHCKYAUPMK;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly AUKCCXTYNRH JJQYEWTDSMD;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public static readonly AUKCCXTYNRH BRYUMIAIRYY;

			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public static readonly AUKCCXTYNRH PKFUGDIUZGU;

			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly AUKCCXTYNRH CKCBNXMFZND;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly AUKCCXTYNRH PQREQCZZQGQ;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly AUKCCXTYNRH MBTNLKYVHWR;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly AUKCCXTYNRH HCGPWIWSSXB;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly AUKCCXTYNRH RSTACZWJSPL;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly AUKCCXTYNRH IOUTWSQFZVR;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly AUKCCXTYNRH EJZMQECBRVH;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public static readonly AUKCCXTYNRH ABAWNXFAPVU;

			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly AUKCCXTYNRH THVGGWVFPLB;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly AUKCCXTYNRH ZLBFMBFGMMW;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly AUKCCXTYNRH XIMHJFHVGLM;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly AUKCCXTYNRH LVJTXSVNVEQ;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly AUKCCXTYNRH PUNJMFYRWJT;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly AUKCCXTYNRH DNRIQUDDBDS;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly AUKCCXTYNRH FDQRSKRHGIK;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public static readonly AUKCCXTYNRH EOLFHGVDWPD;

			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly AUKCCXTYNRH LEESGAGFWXP;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly AUKCCXTYNRH DQGFJDUUNQJ;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly AUKCCXTYNRH ORVVDEWBSQZ;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly AUKCCXTYNRH IHJINDMYLFJ;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly AUKCCXTYNRH SBFDQIIXQXN;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly AUKCCXTYNRH BKUUODGQAXJ;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public static readonly AUKCCXTYNRH GJGPISPCGPV;

			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public static readonly AUKCCXTYNRH JQQWVRGGOAG;

			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public static readonly AUKCCXTYNRH MVNBRYNSQJU;

			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly AUKCCXTYNRH RHVFFQAHVXV;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public static readonly AUKCCXTYNRH BBRAIUWHBPZ;

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly AUKCCXTYNRH KGPVXLZXAUK;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public static readonly AUKCCXTYNRH MOLFFOFWXGK;

			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public static readonly AUKCCXTYNRH DJVMPNRHDLA;

			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public static readonly AUKCCXTYNRH AIRLQFKFIKO;

			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly AUKCCXTYNRH RYJSNRHSAJQ;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly AUKCCXTYNRH DVGPSKOQFDO;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly AUKCCXTYNRH FKQRCETTAME;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly AUKCCXTYNRH OPGJSFIIUHO;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public static readonly AUKCCXTYNRH NIGYYGYNOGX;

			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly AUKCCXTYNRH LDGPFSFRXPZ;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly AUKCCXTYNRH FHSLMGANPQF;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public static readonly AUKCCXTYNRH CFYZNGLDZTZ;

			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public static readonly AUKCCXTYNRH JUBTWOZNXCV;

			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly AUKCCXTYNRH MASTQJRBJUN;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly AUKCCXTYNRH KIQDRAVHIZF;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public static readonly AUKCCXTYNRH YEAWBNWDFWR;

			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly AUKCCXTYNRH XEBTBYSXQXF;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly AUKCCXTYNRH GJVOOGVDCFP;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly AUKCCXTYNRH KRZBHSEEHUE;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly AUKCCXTYNRH UVADYQXDTNN;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly AUKCCXTYNRH WHSCUUMBEUT;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly AUKCCXTYNRH AJEGXULIXWP;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly AUKCCXTYNRH WJNRLLREFKB;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly AUKCCXTYNRH ZXHIMFSQTHR;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly AUKCCXTYNRH YDXRKNSBYSB;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly AUKCCXTYNRH QFLWSYMOJPX;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly AUKCCXTYNRH GLSQPYQMQZN;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly AUKCCXTYNRH BYRRTYRACDT;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public static readonly AUKCCXTYNRH PGLDSOUGWHV;

			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public static readonly AUKCCXTYNRH WAXBVZQHAKF;

			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly AUKCCXTYNRH XFBWNGKJGTW;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly AUKCCXTYNRH KUVCFDGYGJV;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly AUKCCXTYNRH QRRFQUQYBCP;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly AUKCCXTYNRH ZFBSMXRXCKO;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly AUKCCXTYNRH LHAQMWZCROK;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static readonly AUKCCXTYNRH CLNXJETSHCJ;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public static readonly AUKCCXTYNRH KNYKINQFNHD;

			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class OGQQENJPAVU
		{
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class MCSKEMLTXYX
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly AUKCCXTYNRH DLFOUFJHVPT;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly AUKCCXTYNRH ZQIZKWOUEUW;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly AUKCCXTYNRH ITZVEWVZYYO;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly AUKCCXTYNRH ZAMILXGWRRD;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public static readonly AUKCCXTYNRH GPKBPRVVKFT;

			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public static readonly AUKCCXTYNRH WFDCAVDDAJF;

			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public static readonly AUKCCXTYNRH ZXCBHDJYUEF;

			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public static class GMIUAQVHYNY
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public static readonly AUKCCXTYNRH DHHCKYAUPMK;

			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly AUKCCXTYNRH JJQYEWTDSMD;

			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly AUKCCXTYNRH BRYUMIAIRYY;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly AUKCCXTYNRH RTUVGSPHUXY;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public static readonly AUKCCXTYNRH ZSCCIPDWUXE;

			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly AUKCCXTYNRH CEDHVNFVLDU;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly AUKCCXTYNRH TFDIMFUYESO;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public static class XNMRTEEPDYU
		{
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly AUKCCXTYNRH CVIEZJWPBIM;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public static readonly AUKCCXTYNRH MODAFTGEVJA;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly AUKCCXTYNRH JDFKSLVSCRZ;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly AUKCCXTYNRH GEBFTLRCWQJ;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly AUKCCXTYNRH XKVIBEMPGJN;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly AUKCCXTYNRH HTMKSUVBDJR;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class WYWNZBKBZBB
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public static class TNAURUIMZWG
		{
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly AUKCCXTYNRH OJCOTRETURO;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class RGPWZGCWDVK
		{
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public static readonly AUKCCXTYNRH AEEBXPWVFIW;

			[Cpp2IlInjected.Token(Token = "0x400020B")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public static class IFRLBNEUCWL
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public static class GWLOKHJYASQ
		{
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class WQSKPWIBMMR
		{
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public static readonly AUKCCXTYNRH SHZMIIPIWCD;

			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static readonly AUKCCXTYNRH DBCILJJGWBD;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly AUKCCXTYNRH WEATXUNOEYQ;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly AUKCCXTYNRH AMZZUPDLWOM;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public static class ERUQNAANOEL
		{
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly AUKCCXTYNRH NYSQULXUFAY;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly AUKCCXTYNRH HGIFRGLDWJD;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public static class XHXROJUYXCP
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public static class SVPYKXTPLRJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public static readonly AUKCCXTYNRH DLFOUFJHVPT;

			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly AUKCCXTYNRH ZQIZKWOUEUW;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class BGUQXJPQFQU
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly AUKCCXTYNRH WHRSBAQANML;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly AUKCCXTYNRH ZAMILXGWRRD;

			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly AUKCCXTYNRH GPKBPRVVKFT;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public static readonly AUKCCXTYNRH WFDCAVDDAJF;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static readonly AUKCCXTYNRH WRMILQGFKFS;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public static readonly AUKCCXTYNRH GXVCRWWDJGR;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static readonly AUKCCXTYNRH TTFKAUGZHNX;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly AUKCCXTYNRH AXPSFUJNEVZ;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly AUKCCXTYNRH KAALMWCHYXG;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly AUKCCXTYNRH VUKTIOLQCVK;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			public static readonly AUKCCXTYNRH DLFOUFJHVPT;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly AUKCCXTYNRH ZQIZKWOUEUW;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public static class JQVRFSHHJHK
		{
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public static class LVNWIAFPIOQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly AUKCCXTYNRH DLFOUFJHVPT;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static readonly AUKCCXTYNRH ZQIZKWOUEUW;

			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly AUKCCXTYNRH SXUNWNMVVGC;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public static readonly AUKCCXTYNRH FJQPNLASIWM;

			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public static readonly AUKCCXTYNRH RYFQMCDRQWL;

			[Cpp2IlInjected.Token(Token = "0x400022D")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class WYIZFPSBVZB
		{
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public static class KYCYHDJXJXQ
		{
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			public static readonly AUKCCXTYNRH UXXOIYBPTKH;

			[Cpp2IlInjected.Token(Token = "0x4000230")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public static class QKONIKTTCXI
		{
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			public static readonly AUKCCXTYNRH SWRWJSTUNRA;

			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public static readonly AUKCCXTYNRH KLTPKOINFAL;

			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public static readonly AUKCCXTYNRH DLFOUFJHVPT;

			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public static readonly AUKCCXTYNRH ZQIZKWOUEUW;

			[Cpp2IlInjected.Token(Token = "0x4000235")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class HNYHDJDSUPL
		{
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public static class JTYBZXVGLXT
		{
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public static class JUXFEXSCCPI
		{
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class JGSZTHKXTIO
		{
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public static class FGVIICJHJUH
		{
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public static class VGLAHKKUKGX
		{
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			public static readonly AUKCCXTYNRH WCBQNABJPFU;

			[Cpp2IlInjected.Token(Token = "0x400023C")]
			public static readonly AUKCCXTYNRH HGRPAGJXERR;

			[Cpp2IlInjected.Token(Token = "0x400023D")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class ZYWNPSRNFTT
		{
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			public static readonly AUKCCXTYNRH QZSJZAHQHNG;

			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public static readonly AUKCCXTYNRH MFIWYKMJVTI;

			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public static readonly AUKCCXTYNRH VIMWUZMIRVA;

			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public static readonly AUKCCXTYNRH WSYIWPOFFDW;

			[Cpp2IlInjected.Token(Token = "0x4000242")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public static class XNAJZGJEQZY
		{
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public static readonly AUKCCXTYNRH QZSJZAHQHNG;

			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public static readonly AUKCCXTYNRH MFIWYKMJVTI;

			[Cpp2IlInjected.Token(Token = "0x4000245")]
			public static readonly AUKCCXTYNRH VIMWUZMIRVA;

			[Cpp2IlInjected.Token(Token = "0x4000246")]
			public static readonly AUKCCXTYNRH WSYIWPOFFDW;

			[Cpp2IlInjected.Token(Token = "0x4000247")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public static class BZSQXLSOXAT
		{
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class GYHFXXTPEQE
		{
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public static readonly AUKCCXTYNRH EGPVWARINJR;

			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public static readonly AUKCCXTYNRH YAAKNVJAZXT;

			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public static readonly AUKCCXTYNRH YZHKXGVZIZL;

			[Cpp2IlInjected.Token(Token = "0x400024C")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public static class GITUFPXCDJT
		{
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public static readonly AUKCCXTYNRH EYMBQOTHUFU;

			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public static readonly AUKCCXTYNRH HZCFICOFZTO;

			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public static readonly AUKCCXTYNRH DFGYUAIUKZL;

			[Cpp2IlInjected.Token(Token = "0x4000250")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public static class WIUOEOMPSAM
		{
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class IOJBYUAEGLT
		{
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public static readonly AUKCCXTYNRH VOPHUWFAHNH;

			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public static readonly AUKCCXTYNRH XZWVPYKMVHN;

			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public static readonly AUKCCXTYNRH GQLBJYQMCKI;

			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public static readonly AUKCCXTYNRH AAGJFVEAIRW;

			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public static readonly AUKCCXTYNRH CPWRBEHAWNP;

			[Cpp2IlInjected.Token(Token = "0x4000257")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public static class PJLMSGYNLVW
		{
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public static readonly AUKCCXTYNRH KLXTZUOWBON;

			[Cpp2IlInjected.Token(Token = "0x4000259")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public static class UXJUSCCROCG
		{
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public static readonly AUKCCXTYNRH MFCXVVUEWME;

			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public static readonly AUKCCXTYNRH IIBDURPDXCF;

			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public static readonly AUKCCXTYNRH GDUMUCCPNQY;

			[Cpp2IlInjected.Token(Token = "0x400025D")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public static class BHYDMXMANKD
		{
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class ZVTKPCFQFYL
		{
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public static class WHMQSJVMLOO
		{
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public static class VQBPBMTOASV
		{
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			public static readonly AUKCCXTYNRH MIYJYAWISYO;

			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public static readonly AUKCCXTYNRH ESTYFAZLARZ;

			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public static readonly AUKCCXTYNRH ABCZJEQKNZD;

			[Cpp2IlInjected.Token(Token = "0x4000266")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public static readonly AUKCCXTYNRH OJNAXBMMVLX;

			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public static readonly AUKCCXTYNRH YOHDNWRWJIC;

			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public static readonly AUKCCXTYNRH VWFVSDRVUQI;

			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public static readonly AUKCCXTYNRH RXTYXHAUPOD;

			[Cpp2IlInjected.Token(Token = "0x400026B")]
			internal static readonly AUKCCXTYNRH[] IYASBWMBMUU;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class ITPOVZBMHGT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public readonly IDLCASSILBG CLFLLPDXJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly List<AUKCCXTYNRH> NJHOFIEJBMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private readonly List<AUKCCXTYNRH> XZPLWDLZGQH;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public IReadOnlyList<AUKCCXTYNRH> JGLGGLDIYQT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public IReadOnlyList<AUKCCXTYNRH> NCHVLIONNXA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2E34870", Offset = "0x2E33470", VA = "0x182E34870")]
		protected ITPOVZBMHGT(IDLCASSILBG a, params AUKCCXTYNRH[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class MNTEHIGCYIF : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2E38770", Offset = "0x2E37370", VA = "0x182E38770")]
		internal MNTEHIGCYIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class YGYKCAANISG : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2E48630", Offset = "0x2E47230", VA = "0x182E48630")]
		internal YGYKCAANISG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class NJTUTREMIPH : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E38E00", Offset = "0x2E37A00", VA = "0x182E38E00")]
		internal NJTUTREMIPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class CBHFIFAYYEK : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C260", Offset = "0x2E2AE60", VA = "0x182E2C260")]
		internal CBHFIFAYYEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ZGIPJBOZYRH : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2E48D70", Offset = "0x2E47970", VA = "0x182E48D70")]
		internal ZGIPJBOZYRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class XBCARKHEAFD : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2E46C80", Offset = "0x2E45880", VA = "0x182E46C80")]
		internal XBCARKHEAFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class UFQGFMUFMUU : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E44860", Offset = "0x2E43460", VA = "0x182E44860")]
		internal UFQGFMUFMUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class TGOQFBAOMCF : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E44240", Offset = "0x2E42E40", VA = "0x182E44240")]
		internal TGOQFBAOMCF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class ZUSVBCCZGFP : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E49520", Offset = "0x2E48120", VA = "0x182E49520")]
		internal ZUSVBCCZGFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class GSBZOJHROMJ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2E32030", Offset = "0x2E30C30", VA = "0x182E32030")]
		internal GSBZOJHROMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class GUPDOEITNPP : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E32210", Offset = "0x2E30E10", VA = "0x182E32210")]
		internal GUPDOEITNPP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class MSFUYMLJFWZ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E38950", Offset = "0x2E37550", VA = "0x182E38950")]
		internal MSFUYMLJFWZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class HGJUIMGEAVX : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E336C0", Offset = "0x2E322C0", VA = "0x182E336C0")]
		internal HGJUIMGEAVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class PFKFMFUFGPR : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A210", Offset = "0x2E38E10", VA = "0x182E3A210")]
		internal PFKFMFUFGPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class UOCSQJRFVKT : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E44C90", Offset = "0x2E43890", VA = "0x182E44C90")]
		internal UOCSQJRFVKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class CSQEYCKIZJP : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E2CD10", Offset = "0x2E2B910", VA = "0x182E2CD10")]
		internal CSQEYCKIZJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class SSTFVNTYJYT : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E43C70", Offset = "0x2E42870", VA = "0x182E43C70")]
		internal SSTFVNTYJYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class KVBFBESFPFM : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E35830", Offset = "0x2E34430", VA = "0x182E35830")]
		internal KVBFBESFPFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class GMDLANSKACA : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2E30A80", Offset = "0x2E2F680", VA = "0x182E30A80")]
		internal GMDLANSKACA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class DSQCRNLSTBQ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E2E950", Offset = "0x2E2D550", VA = "0x182E2E950")]
		internal DSQCRNLSTBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class IZUAKANMBHK : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2E349F0", Offset = "0x2E335F0", VA = "0x182E349F0")]
		internal IZUAKANMBHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class MVUPCDOKHFC : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2E38BA0", Offset = "0x2E377A0", VA = "0x182E38BA0")]
		internal MVUPCDOKHFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class BTPPBTKOKNZ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2E2BC50", Offset = "0x2E2A850", VA = "0x182E2BC50")]
		internal BTPPBTKOKNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class JKUKAPDHBEI : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2E35060", Offset = "0x2E33C60", VA = "0x182E35060")]
		internal JKUKAPDHBEI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class FTSDLCGUBKT : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FBE0", Offset = "0x2E2E7E0", VA = "0x182E2FBE0")]
		internal FTSDLCGUBKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class GKVLRZOSKOS : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2E308A0", Offset = "0x2E2F4A0", VA = "0x182E308A0")]
		internal GKVLRZOSKOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class CGBTMYJZRJG : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C440", Offset = "0x2E2B040", VA = "0x182E2C440")]
		internal CGBTMYJZRJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class XYWETDWGRGO : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E48270", Offset = "0x2E46E70", VA = "0x182E48270")]
		internal XYWETDWGRGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class KZOTNHLZYJR : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2E364F0", Offset = "0x2E350F0", VA = "0x182E364F0")]
		internal KZOTNHLZYJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class VNRHTHDUINQ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E45B50", Offset = "0x2E44750", VA = "0x182E45B50")]
		internal VNRHTHDUINQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class YXPJYBQTGDX : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E48790", Offset = "0x2E47390", VA = "0x182E48790")]
		internal YXPJYBQTGDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class LKCPFZCSHOX : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E37230", Offset = "0x2E35E30", VA = "0x182E37230")]
		internal LKCPFZCSHOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class TTLSQGHOGBR : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E44680", Offset = "0x2E43280", VA = "0x182E44680")]
		internal TTLSQGHOGBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class SLMDUIPEGNU : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E43990", Offset = "0x2E42590", VA = "0x182E43990")]
		internal SLMDUIPEGNU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class XQCVOLGBBDA : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E48090", Offset = "0x2E46C90", VA = "0x182E48090")]
		internal XQCVOLGBBDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class YZDHOASFJLY : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E48970", Offset = "0x2E47570", VA = "0x182E48970")]
		internal YZDHOASFJLY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class YGXCNUHAYRR : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E48450", Offset = "0x2E47050", VA = "0x182E48450")]
		internal YGXCNUHAYRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class GBKAEVCGCFW : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FFA0", Offset = "0x2E2EBA0", VA = "0x182E2FFA0")]
		internal GBKAEVCGCFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class EWWEMWHZXIA : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F670", Offset = "0x2E2E270", VA = "0x182E2F670")]
		internal EWWEMWHZXIA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class JCNWWBGABRX : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E34E10", Offset = "0x2E33A10", VA = "0x182E34E10")]
		internal JCNWWBGABRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class BZDYESPGMOB : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C010", Offset = "0x2E2AC10", VA = "0x182E2C010")]
		internal BZDYESPGMOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class QFKMBNXRHBT : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E41F50", Offset = "0x2E40B50", VA = "0x182E41F50")]
		internal QFKMBNXRHBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class QJEMHOSCSFS : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E42310", Offset = "0x2E40F10", VA = "0x182E42310")]
		internal QJEMHOSCSFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class JLOSAVZCDUM : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E35240", Offset = "0x2E33E40", VA = "0x182E35240")]
		internal JLOSAVZCDUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class QHRADOBVENN : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2E42130", Offset = "0x2E40D30", VA = "0x182E42130")]
		internal QHRADOBVENN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class BXZWQRCDIKG : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2E2BE30", Offset = "0x2E2AA30", VA = "0x182E2BE30")]
		internal BXZWQRCDIKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class NOMXJCNFHQV : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2E38FE0", Offset = "0x2E37BE0", VA = "0x182E38FE0")]
		internal NOMXJCNFHQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class AFJONXNBBEM : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2E2AAC0", Offset = "0x2E296C0", VA = "0x182E2AAC0")]
		internal AFJONXNBBEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class BDFIGTEPKMG : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2E2ACA0", Offset = "0x2E298A0", VA = "0x182E2ACA0")]
		internal BDFIGTEPKMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class EBOKJFWRCNB : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E2EC90", Offset = "0x2E2D890", VA = "0x182E2EC90")]
		internal EBOKJFWRCNB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class UIPUXKRBZLJ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E44AB0", Offset = "0x2E436B0", VA = "0x182E44AB0")]
		internal UIPUXKRBZLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class VCQJWNFSGVA : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E45580", Offset = "0x2E44180", VA = "0x182E45580")]
		internal VCQJWNFSGVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class NXTSUHHHWVJ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2E39410", Offset = "0x2E38010", VA = "0x182E39410")]
		internal NXTSUHHHWVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class JXWIJPNDHJM : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2E35570", Offset = "0x2E34170", VA = "0x182E35570")]
		internal JXWIJPNDHJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class NWCQMHXCAGM : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2E391C0", Offset = "0x2E37DC0", VA = "0x182E391C0")]
		internal NWCQMHXCAGM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class OORQDOSXAWM : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A030", Offset = "0x2E38C30", VA = "0x182E3A030")]
		internal OORQDOSXAWM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class FTVWUOBPYAI : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FDC0", Offset = "0x2E2E9C0", VA = "0x182E2FDC0")]
		internal FTVWUOBPYAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class XHFWQTTBBGP : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2E46E60", Offset = "0x2E45A60", VA = "0x182E46E60")]
		internal XHFWQTTBBGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class HUJFYIDKIEO : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2E33C10", Offset = "0x2E32810", VA = "0x182E33C10")]
		internal HUJFYIDKIEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class PPIAKZBQUVO : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AF10", Offset = "0x2E39B10", VA = "0x182E3AF10")]
		internal PPIAKZBQUVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class GHNIFIRKCZJ : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2E30270", Offset = "0x2E2EE70", VA = "0x182E30270")]
		internal GHNIFIRKCZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class DVPMDWENGTG : ITPOVZBMHGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2E2EB30", Offset = "0x2E2D730", VA = "0x182E2EB30")]
		internal DVPMDWENGTG()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.NodeDefs
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class PIUJLQXQDVC : PNPZLZISHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A410", Offset = "0x2E39010", VA = "0x182E3A410")]
		public PIUJLQXQDVC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public abstract class OOAKIEZGLZV : SKPGDRSWREE<INFKYHURQQV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2E371F0", Offset = "0x2E35DF0", VA = "0x182E371F0")]
		protected OOAKIEZGLZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public abstract class PHBKUEIPOXF : KIXVCOYSOQY<INFKYHURQQV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F260", Offset = "0x2E2DE60", VA = "0x182E2F260")]
		protected PHBKUEIPOXF([In] IO io)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A2F0", Offset = "0x2E38EF0", VA = "0x182E3A2F0", Slot = "11")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A380", Offset = "0x2E38F80", VA = "0x182E3A380", Slot = "14")]
		public override void WFVEBFVOYYM(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public abstract class EGVFOPBSQIB : PHBKUEIPOXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F260", Offset = "0x2E2DE60", VA = "0x182E2F260")]
		public EGVFOPBSQIB([In] IO io)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class MMTNSRIOJLE : OOAKIEZGLZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		public override void NASCZLCHALL(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2E383E0", Offset = "0x2E36FE0", VA = "0x182E383E0", Slot = "13")]
		public override IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2E38410", Offset = "0x2E37010", VA = "0x182E38410", Slot = "14")]
		public override void WFVEBFVOYYM(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2E38690", Offset = "0x2E37290", VA = "0x182E38690")]
		public static void ZNZBSVXCVKK(INFKYHURQQV a, [In] CJRCNARJFOD.Inst graphInst, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2E36F40", Offset = "0x2E35B40", VA = "0x182E36F40", Slot = "15")]
		public override Variant VZXTZLLFWNT(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2E371F0", Offset = "0x2E35DF0", VA = "0x182E371F0")]
		public MMTNSRIOJLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class RBVCLSMADFT : OOAKIEZGLZV
	{
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		public sealed class M : EVNode.LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public struct Inst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public readonly Id32<JQPVMRMCZNG> FunctionGraphId;

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
			private Inst(Id32<JQPVMRMCZNG> functionGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2495370", Offset = "0x2493F70", VA = "0x182495370")]
			public static Inst New(Id32<JQPVMRMCZNG> functionGraph)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2E42D10", Offset = "0x2E41910", VA = "0x182E42D10", Slot = "11")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2E42B90", Offset = "0x2E41790", VA = "0x182E42B90", Slot = "12")]
		public override void NASCZLCHALL(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2E42EA0", Offset = "0x2E41AA0", VA = "0x182E42EA0", Slot = "13")]
		public override IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2E42F40", Offset = "0x2E41B40", VA = "0x182E42F40", Slot = "14")]
		public override void WFVEBFVOYYM(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2E42AB0", Offset = "0x2E416B0", VA = "0x182E42AB0")]
		public static void ARGVTLHYZJH(INFKYHURQQV a, [In] CJRCNARJFOD.Inst graphInst, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2E433D0", Offset = "0x2E41FD0", VA = "0x182E433D0")]
		public static void ZNZBSVXCVKK(INFKYHURQQV a, [In] CJRCNARJFOD.Inst graphInst, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2E36F40", Offset = "0x2E35B40", VA = "0x182E36F40", Slot = "15")]
		public override Variant VZXTZLLFWNT(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2E371F0", Offset = "0x2E35DF0", VA = "0x182E371F0")]
		public RBVCLSMADFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class LJFHXZBVJAH : OOAKIEZGLZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		public override void NASCZLCHALL(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2E36F10", Offset = "0x2E35B10", VA = "0x182E36F10", Slot = "13")]
		public override IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2E36F80", Offset = "0x2E35B80", VA = "0x182E36F80", Slot = "14")]
		public override void WFVEBFVOYYM(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2E36E30", Offset = "0x2E35A30", VA = "0x182E36E30")]
		public static void ARGVTLHYZJH(INFKYHURQQV a, [In] CJRCNARJFOD.Inst graphInst, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2E36F40", Offset = "0x2E35B40", VA = "0x182E36F40", Slot = "15")]
		public override Variant VZXTZLLFWNT(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2E371F0", Offset = "0x2E35DF0", VA = "0x182E371F0")]
		public LJFHXZBVJAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class HSHSIOHLVKC : PHBKUEIPOXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public readonly Id32<VPKCJSHTFFF> HUIPJXCTAUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public readonly Id32<TIEJMITYOHO> TIPLFJUMQKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public readonly Id32<TIEJMITYOHO> TLSCOYGOGPJ;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2E33910", Offset = "0x2E32510", VA = "0x182E33910")]
		public HSHSIOHLVKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public abstract class PNPZLZISHIG : CMPUBHBKLVH<INFKYHURQQV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AEC0", Offset = "0x2E39AC0", VA = "0x182E3AEC0")]
		protected PNPZLZISHIG([In] IO io)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AD80", Offset = "0x2E39980", VA = "0x182E3AD80", Slot = "11")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2E3ACE0", Offset = "0x2E398E0", VA = "0x182E3ACE0", Slot = "12")]
		public override void NASCZLCHALL(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AE30", Offset = "0x2E39A30", VA = "0x182E3AE30", Slot = "14")]
		public override void WFVEBFVOYYM(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AB80", Offset = "0x2E39780", VA = "0x182E3AB80", Slot = "17")]
		public override Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM> FRCWOADHLLS(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d)
		{
			return default(Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class ZHTEERWRYWA : EGVFOPBSQIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2E48F50", Offset = "0x2E47B50", VA = "0x182E48F50")]
		public ZHTEERWRYWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct RRNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public CircuitsVec3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public CircuitsQuat LocalRotation;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2E43890", Offset = "0x2E42490", VA = "0x182E43890")]
		internal RRNode([In] CircuitsVec3 localPosition, [In] CircuitsQuat localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2E43860", Offset = "0x2E42460", VA = "0x182E43860")]
		public static RRNode New()
		{
			return default(RRNode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2E43840", Offset = "0x2E42440", VA = "0x182E43840")]
		public static RRNode HVKYDMYBGAZ([In] CircuitsVec3 localPosition, [In] CircuitsQuat localRotation)
		{
			return default(RRNode);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class ZMLGTCYZSUB : PNPZLZISHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2E491B0", Offset = "0x2E47DB0", VA = "0x182E491B0")]
		public ZMLGTCYZSUB()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class CJRCNARJFOD : ESNWBJYFWAL
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		public sealed class M : EVGraph.LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public struct Inst
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public IdUnsafeList<VPKCJSHTFFF, NamedType> Inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public IdUnsafeList<TIEJMITYOHO, NamedType> Outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			public readonly Id32<LWYTCPIHOQE> InNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			public readonly Id32<LWYTCPIHOQE> OutNodeId;

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2E34DA0", Offset = "0x2E339A0", VA = "0x182E34DA0")]
			private Inst(string name, [In] IdUnsafeList<VPKCJSHTFFF, NamedType> inputs, [In] IdUnsafeList<TIEJMITYOHO, NamedType> outputs, Id32<LWYTCPIHOQE> inNodeId, Id32<LWYTCPIHOQE> outNodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2E34CD0", Offset = "0x2E338D0", VA = "0x182E34CD0")]
			public static Inst New(Id32<LWYTCPIHOQE> inNode, Id32<LWYTCPIHOQE> outNode)
			{
				return default(Inst);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2E34C50", Offset = "0x2E33850", VA = "0x182E34C50")]
			public static Inst HVKYDMYBGAZ(string a, [In] IdUnsafeList<VPKCJSHTFFF, NamedType> inputs, [In] IdUnsafeList<TIEJMITYOHO, NamedType> outputs, Id32<LWYTCPIHOQE> b, Id32<LWYTCPIHOQE> c)
			{
				return default(Inst);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C970", Offset = "0x2E2B570", VA = "0x182E2C970", Slot = "8")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, RootInstantiation c, Id32<GraphInstantiation.M>? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2E2C620", Offset = "0x2E2B220", VA = "0x182E2C620", Slot = "9")]
		public override void NASCZLCHALL(INFKYHURQQV a, Id32<JQPVMRMCZNG> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2E2CCD0", Offset = "0x2E2B8D0", VA = "0x182E2CCD0")]
		public CJRCNARJFOD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public static class LFMOSSFLIBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2E366D0", Offset = "0x2E352D0", VA = "0x182E366D0")]
		public static void Destroy(this CJRCNARJFOD.Inst self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public abstract class ESNWBJYFWAL : AVFTLOIEBMM<INFKYHURQQV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2E2CCD0", Offset = "0x2E2B8D0", VA = "0x182E2CCD0")]
		protected ESNWBJYFWAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public readonly struct NamedType : IEquatable<NamedType>, MNLRIGBOINM<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public readonly IDLCASSILBG Type;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		private NamedType(string name, IDLCASSILBG type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2D63CF0", Offset = "0x2D628F0", VA = "0x182D63CF0")]
		public static NamedType New(string name, IDLCASSILBG type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2E395F0", Offset = "0x2E381F0", VA = "0x182E395F0")]
		public static bool EOXNKNKFOQL([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2E395F0", Offset = "0x2E381F0", VA = "0x182E395F0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2E395F0", Offset = "0x2E381F0", VA = "0x182E395F0")]
		public bool XGBYPYNVUZB([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2E39640", Offset = "0x2E38240", VA = "0x182E39640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2E39700", Offset = "0x2E38300", VA = "0x182E39700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2E39830", Offset = "0x2E38430", VA = "0x182E39830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2E397F0", Offset = "0x2E383F0", VA = "0x182E397F0")]
		public string NWOZRWBRAJR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2E39770", Offset = "0x2E38370", VA = "0x182E39770")]
		public string MQDHHVKTYYX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2E395F0", Offset = "0x2E381F0", VA = "0x182E395F0", Slot = "5")]
		private bool VEEWRWMIIHY([In] NamedType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class DNDEQCXWOPZ : ESNWBJYFWAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public override void OFMLSTORVPX(INFKYHURQQV a, Id32<JQPVMRMCZNG> b, RootInstantiation c, Id32<GraphInstantiation.M>? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public override void NASCZLCHALL(INFKYHURQQV a, Id32<JQPVMRMCZNG> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2E2CCD0", Offset = "0x2E2B8D0", VA = "0x182E2CCD0")]
		public DNDEQCXWOPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public struct RRGraph
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public SOAField<LWYTCPIHOQE, RRNode> RRNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public SOAId32<RBVCLSMADFT.M> FunctionNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public SOAField<RBVCLSMADFT.M, RBVCLSMADFT.Inst> FunctionNodes;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2E437D0", Offset = "0x2E423D0", VA = "0x182E437D0")]
		private RRGraph([In] SOAField<LWYTCPIHOQE, RRNode> rrNodes, [In] SOAId32<RBVCLSMADFT.M> functionNodeIds, [In] SOAField<RBVCLSMADFT.M, RBVCLSMADFT.Inst> functionNodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2E436E0", Offset = "0x2E422E0", VA = "0x182E436E0")]
		public static RRGraph New()
		{
			return default(RRGraph);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2E43650", Offset = "0x2E42250", VA = "0x182E43650")]
		public static RRGraph HVKYDMYBGAZ([In] SOAField<LWYTCPIHOQE, RRNode> rrNodes, [In] SOAId32<RBVCLSMADFT.M> functionNodeIds, [In] SOAField<RBVCLSMADFT.M, RBVCLSMADFT.Inst> functionNodes)
		{
			return default(RRGraph);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public static class SOFCPEGLOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2E43BF0", Offset = "0x2E427F0", VA = "0x182E43BF0")]
		public static void Destroy(this RRGraph self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public struct RRGraphs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public SOAField<JQPVMRMCZNG, RRGraph> Items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public SOAId32<CJRCNARJFOD.M> FunctionGraphIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public SOAField<CJRCNARJFOD.M, CJRCNARJFOD.Inst> FunctionGraphs;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2E437D0", Offset = "0x2E423D0", VA = "0x182E437D0")]
		private RRGraphs([In] SOAField<JQPVMRMCZNG, RRGraph> items, [In] SOAId32<CJRCNARJFOD.M> functionGraphIds, [In] SOAField<CJRCNARJFOD.M, CJRCNARJFOD.Inst> functionGraphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2E43650", Offset = "0x2E42250", VA = "0x182E43650")]
		public static RRGraphs HVKYDMYBGAZ([In] SOAField<JQPVMRMCZNG, RRGraph> items, [In] SOAId32<CJRCNARJFOD.M> functionGraphIds, [In] SOAField<CJRCNARJFOD.M, CJRCNARJFOD.Inst> functionGraphs)
		{
			return default(RRGraphs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public static class OFTFBFYYNVR
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2E398D0", Offset = "0x2E384D0", VA = "0x182E398D0")]
		public static void Destroy(this RRGraphs self, [In] Graphs graphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2E39870", Offset = "0x2E38470", VA = "0x182E39870")]
		public static void DDATGWDPZQA(this RRGraphs a, Id32<JQPVMRMCZNG> b, [In] RRGraph graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2E39D10", Offset = "0x2E38910", VA = "0x182E39D10")]
		public static void Release(this RRGraphs self, Id32<JQPVMRMCZNG> graphId, [In] Graphs graphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2E39C70", Offset = "0x2E38870", VA = "0x182E39C70")]
		public static RRGraph Get([In] this RRGraphs self, Id32<JQPVMRMCZNG> graphId)
		{
			return default(RRGraph);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2E39F70", Offset = "0x2E38B70", VA = "0x182E39F70")]
		public static RRGraph YXACYNUPMAX(this RRGraphs a, Id32<JQPVMRMCZNG> b)
		{
			return default(RRGraph);
		}
	}
}
namespace Circuits.Static.RecRoom.Factory
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class YZLWRMXNMRT : YSCSHHYAUOL<YZLWRMXNMRT, INFKYHURQQV>
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2E48D10", Offset = "0x2E47910", VA = "0x182E48D10")]
		private YZLWRMXNMRT([In] IdUnsafeList<TFITIOWUSRJ, ZHOBCASHLNG<INFKYHURQQV>> nodeDefs, [In] IdUnsafeList<TZJZKVJCHTJ, OKCLJAZOSIM<INFKYHURQQV>> graphDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2E48C50", Offset = "0x2E47850", VA = "0x182E48C50")]
		public static YZLWRMXNMRT New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2E48BD0", Offset = "0x2E477D0", VA = "0x182E48BD0")]
		public new (IdArray<TFITIOWUSRJ, ZHOBCASHLNG<INFKYHURQQV>>, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<INFKYHURQQV>>) FATJKNZTHSX()
		{
			return default((IdArray<TFITIOWUSRJ, ZHOBCASHLNG<INFKYHURQQV>>, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<INFKYHURQQV>>));
		}
	}
}
namespace Circuits.Static.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class DRFTFCZGGMG : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2E2E910", Offset = "0x2E2D510", VA = "0x182E2E910", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2E2E940", Offset = "0x2E2D540", VA = "0x182E2E940")]
		public DRFTFCZGGMG()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public interface GGQWPRURVBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(FJCTCRTIJZZ a, bool b);
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
