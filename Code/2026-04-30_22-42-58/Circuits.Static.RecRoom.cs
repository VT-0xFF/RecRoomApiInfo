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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC0DD0", Offset = "0x2BC01D0", VA = "0x182BC0DD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC04C0", Offset = "0x2BBF8C0", VA = "0x182BC04C0", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class YZOJJPJETGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2140", Offset = "0x2BD1540", VA = "0x182BD2140")]
		public static bool XYSLZOUTKET(this BSJAKYMSOCV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2250", Offset = "0x2BD1650", VA = "0x182BD2250")]
		public static bool XYSLZOUTKET(this ZMFHVAWJYMI a)
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
			private readonly OKXJRNOVLSL _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			public EVRequest(OKXJRNOVLSL staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class OSBBBKUMJIK
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<PXTZEBZCMDX>, TGAZFOYDRZK> BGDPVTKASRZ;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<PXTZEBZCMDX>>? WWIMPCWJUXN;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<PXTZEBZCMDX> OBOPKAISMGZ;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<PXTZEBZCMDX> KRVTXTJCVXA;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<PXTZEBZCMDX> OSZSTXCWAVT;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<PXTZEBZCMDX> HKZXBWRWFII;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<PXTZEBZCMDX> SBBXBHDUQAR;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<PXTZEBZCMDX> DMAEOSXMBXM;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<PXTZEBZCMDX> MPRPSYIPYYY;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<PXTZEBZCMDX> LVBXMAFNWHG;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<PXTZEBZCMDX> QUFXXIRMCOU;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<PXTZEBZCMDX> XRKAKBTVEQM;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<PXTZEBZCMDX> HATRNNQHQYS;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<PXTZEBZCMDX> NETUNIWGXIK;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<PXTZEBZCMDX> LBBVTGJJPUL;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<PXTZEBZCMDX> KQPRXPOYCMB;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<PXTZEBZCMDX> FQOMDVVGFZD;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<PXTZEBZCMDX> DEJGGGDIXKO;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<PXTZEBZCMDX> TYBMALUSISB;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<PXTZEBZCMDX> UWXKDUOPVHF;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<PXTZEBZCMDX> XBXKTRUSBCU;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<PXTZEBZCMDX> JNGRBZYFKXV;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<PXTZEBZCMDX> FXKLCJLDUKO;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<PXTZEBZCMDX> YPUYXKGDFBZ;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<PXTZEBZCMDX> HZDXPLOKXIF;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<PXTZEBZCMDX> CIHNSRGLQYW;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<PXTZEBZCMDX> LROSBHRFHHQ;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<PXTZEBZCMDX> CIKARRVXIMJ;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<PXTZEBZCMDX> GQAXANZIIZK;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<PXTZEBZCMDX> IJFVGLJBRUN;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<PXTZEBZCMDX> JXMMGYDUADT;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<PXTZEBZCMDX> OJJABJQVVLF;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<PXTZEBZCMDX> KXVWRUEQSJL;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<PXTZEBZCMDX> XPKOLSHIWOU;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<PXTZEBZCMDX> RDEESHILFFJ;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<PXTZEBZCMDX> VPVDPAMVWGN;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<PXTZEBZCMDX> RTPCFYBLHGN;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<PXTZEBZCMDX> THMLRBILMWG;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<PXTZEBZCMDX> TDSIQPQTTFR;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<PXTZEBZCMDX> KEOQPEJUGTK;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<PXTZEBZCMDX> INUPLPCESQA;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<PXTZEBZCMDX> IBYGSYCPZBG;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<PXTZEBZCMDX> WXJJPBCOZPF;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<PXTZEBZCMDX> BZLIIXVGHQX;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<PXTZEBZCMDX> HDAESPUZNCM;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<PXTZEBZCMDX> ILGLIJWWOQL;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<PXTZEBZCMDX> JXBWYLXDEOP;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<PXTZEBZCMDX> YWOAAWTKQWF;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<PXTZEBZCMDX> FORNLEVTQNG;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<PXTZEBZCMDX> EHTXBTZALNI;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<PXTZEBZCMDX> FREFAFYXNYQ;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<PXTZEBZCMDX> IZQJZZGLNDX;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<PXTZEBZCMDX> QZLAGUQCBKJ;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<PXTZEBZCMDX> PHRRYDLRMYW;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<PXTZEBZCMDX> TFDEDQZQIWB;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<PXTZEBZCMDX> YKSXZYUPWIT;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<PXTZEBZCMDX> RALNDTSPKAC;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<PXTZEBZCMDX> IAMZFHACUCQ;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<PXTZEBZCMDX> FJNJTIJCCDG;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<PXTZEBZCMDX> KSKVBNWFJDC;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<PXTZEBZCMDX> TMOCYAODERJ;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<PXTZEBZCMDX> LSPXFAOAKZY;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<PXTZEBZCMDX> APIMUKNHTDG;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<PXTZEBZCMDX> TXMTVOGLINK;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<PXTZEBZCMDX> KRKXVDGRWEH;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<PXTZEBZCMDX> CAIAVAGODLH;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<PXTZEBZCMDX> TCCBCFELCLC;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<PXTZEBZCMDX> BNONJHTGOTN;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<PXTZEBZCMDX> ZWMBITXKOIE;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<PXTZEBZCMDX> URKTLAPVISC;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<PXTZEBZCMDX> KMCBPEDBMSM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<PXTZEBZCMDX>, TGAZFOYDRZK> ITCRLTMAVOU
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0FF0", Offset = "0x2BC03F0", VA = "0x182BC0FF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0E50", Offset = "0x2BC0250", VA = "0x182BC0E50")]
			public static TGAZFOYDRZK CJFWFFGQOII(Id32<PXTZEBZCMDX> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0ED0", Offset = "0x2BC02D0", VA = "0x182BC0ED0")]
			public static bool DPZKGLCVMRL(Id32<PXTZEBZCMDX> id, [Out] TGAZFOYDRZK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1040", Offset = "0x2BC0440", VA = "0x182BC1040")]
			public static BSJAKYMSOCV SDCWNCIEUQF(Id32<PXTZEBZCMDX> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0F60", Offset = "0x2BC0360", VA = "0x182BC0F60")]
			private static Id32<PXTZEBZCMDX> GZVUEGYMGMP(TGAZFOYDRZK a, Id32<PXTZEBZCMDX> id)
			{
				return default(Id32<PXTZEBZCMDX>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC10F0", Offset = "0x2BC04F0", VA = "0x182BC10F0")]
			private static void VBIDWBGUEVZ(Id32<PXTZEBZCMDX> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class IABNZHBPDRX
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<KOCJWPCQAPD, BSJAKYMSOCV?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
				private TypeRegistryFactory([In] IdUnsafeList<KOCJWPCQAPD, BSJAKYMSOCV?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCEE30", Offset = "0x2BCE230", VA = "0x182BCEE30")]
				public static TypeRegistryFactory GYMJYDCNRDR()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BCEE90", Offset = "0x2BCE290", VA = "0x182BCEE90")]
				public (ReadOnlyIdArray<KOCJWPCQAPD, BSJAKYMSOCV>, IReadOnlyDictionary<BSJAKYMSOCV, Id32<KOCJWPCQAPD>>) ISHNKJMJOID()
				{
					return default((ReadOnlyIdArray<KOCJWPCQAPD, BSJAKYMSOCV>, IReadOnlyDictionary<BSJAKYMSOCV, Id32<KOCJWPCQAPD>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF230", Offset = "0x2BCE630", VA = "0x182BCF230")]
				public Id32<KOCJWPCQAPD> XPCEVMOILWF(int a, BSJAKYMSOCV b)
				{
					return default(Id32<KOCJWPCQAPD>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BCF1E0", Offset = "0x2BCE5E0", VA = "0x182BCF1E0")]
				public Id32<KOCJWPCQAPD> Initialize(int id, YDXBZIIWDJA type, YDXBZIIWDJA factoryType)
				{
					return default(Id32<KOCJWPCQAPD>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class IKSZCVEYPGQ
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<KOCJWPCQAPD> WWEUIVUEMHF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFC60", Offset = "0x2BBF060", VA = "0x182BBFC60")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BBF9E0", Offset = "0x2BBEDE0", VA = "0x182BBF9E0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<KOCJWPCQAPD> OHOKSCVAKRJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFC20", Offset = "0x2BBF020", VA = "0x182BBFC20")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFBE0", Offset = "0x2BBEFE0", VA = "0x182BBFBE0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<KOCJWPCQAPD> BAPGRJGYHOY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFB20", Offset = "0x2BBEF20", VA = "0x182BBFB20")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFAE0", Offset = "0x2BBEEE0", VA = "0x182BBFAE0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<KOCJWPCQAPD> LRNSTRRVQSO
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFBA0", Offset = "0x2BBEFA0", VA = "0x182BBFBA0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFA60", Offset = "0x2BBEE60", VA = "0x182BBFA60")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<KOCJWPCQAPD> XNQTODWCJPI
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BBF9A0", Offset = "0x2BBEDA0", VA = "0x182BBF9A0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFB60", Offset = "0x2BBEF60", VA = "0x182BBFB60")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<KOCJWPCQAPD> TSFOFKTRDOH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFAA0", Offset = "0x2BBEEA0", VA = "0x182BBFAA0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BBFA20", Offset = "0x2BBEE20", VA = "0x182BBFA20")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class LLUVENKAVVE : IEnumerable<BSJAKYMSOCV>, IEnumerable, IEnumerator<BSJAKYMSOCV>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private BSJAKYMSOCV BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int YTKXRPSSEMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool OAGWAOBECFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool YSFLBNEEOFS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion ORHXAHCVOQP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion TJTEMJKTLKU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool HROGWYMNYGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool JMBCPNFTYUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool YGYRMPFCYKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool LFAOZIQAWPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool ZSYDIEZVMFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool BWIDKJGNPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool SXUBNECZTFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool PZATCEPKMJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<BSJAKYMSOCV> MXGZQBRVDOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private BSJAKYMSOCV ICFWFTTNFWH;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private BSJAKYMSOCV TFKPOFCNVHA
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
				[DebuggerHidden]
				public LLUVENKAVVE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0390", Offset = "0x2BBF790", VA = "0x182BC0390", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFFA0", Offset = "0x2BBF3A0", VA = "0x182BBFFA0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFE90", Offset = "0x2BBF290", VA = "0x182BBFE90")]
				private void ALJGYZPBIVB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0420", Offset = "0x2BBF820", VA = "0x182BC0420", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFEE0", Offset = "0x2BBF2E0", VA = "0x182BBFEE0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<BSJAKYMSOCV> CUVZYYGPJGV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFEE0", Offset = "0x2BBF2E0", VA = "0x182BBFEE0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator SJAOULXGYMP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class VIIIGVTVOCI : IEnumerable<BSJAKYMSOCV>, IEnumerable, IEnumerator<BSJAKYMSOCV>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private BSJAKYMSOCV BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int YTKXRPSSEMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion ORHXAHCVOQP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion TJTEMJKTLKU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool YGYRMPFCYKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool LFAOZIQAWPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool HROGWYMNYGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool JMBCPNFTYUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool RFZXGOPDMPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool OHNKMBUZSTF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool ZSYDIEZVMFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool BWIDKJGNPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool TBNNLGBDXCW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool HOUZQOJNTAS;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private BSJAKYMSOCV TFKPOFCNVHA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
				[DebuggerHidden]
				public VIIIGVTVOCI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCFDE0", Offset = "0x2BCF1E0", VA = "0x182BCFDE0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BD1CF0", Offset = "0x2BD10F0", VA = "0x182BD1CF0", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BCFD30", Offset = "0x2BCF130", VA = "0x182BCFD30", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<BSJAKYMSOCV> CUVZYYGPJGV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BCFD30", Offset = "0x2BCF130", VA = "0x182BCFD30", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator SJAOULXGYMP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class BSWLAJKLZLZ : IEnumerable<Id32<KOCJWPCQAPD>>, IEnumerable, IEnumerator<Id32<KOCJWPCQAPD>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<KOCJWPCQAPD> BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int YTKXRPSSEMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion ORHXAHCVOQP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion TJTEMJKTLKU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool HROGWYMNYGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool JMBCPNFTYUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool YGYRMPFCYKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool LFAOZIQAWPV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool ZSYDIEZVMFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool BWIDKJGNPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool SXUBNECZTFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool PZATCEPKMJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<BSJAKYMSOCV> MXGZQBRVDOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<YDXBZIIWDJA> MXBSSUXXUCX;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<KOCJWPCQAPD> GFQKFHZGBCF
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xDE68B0", Offset = "0xDE5CB0", VA = "0x180DE68B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2BB2F10", Offset = "0x2BB2310", VA = "0x182BB2F10", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15B8830", Offset = "0x15B7C30", VA = "0x1815B8830")]
				[DebuggerHidden]
				public BSWLAJKLZLZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BB3010", Offset = "0x2BB2410", VA = "0x182BB3010", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2A10", Offset = "0x2BB1E10", VA = "0x182BB2A10", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2970", Offset = "0x2BB1D70", VA = "0x182BB2970")]
				private void ALJGYZPBIVB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BB29C0", Offset = "0x2BB1DC0", VA = "0x182BB29C0")]
				private void ALONWGIYSGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BB3160", Offset = "0x2BB2560", VA = "0x182BB3160", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2F60", Offset = "0x2BB2360", VA = "0x182BB2F60", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<KOCJWPCQAPD>> VYZEJTLNNAO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2F60", Offset = "0x2BB2360", VA = "0x182BB2F60", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator SJAOULXGYMP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log GLGEGNAUXIQ;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<KOCJWPCQAPD, BSJAKYMSOCV?> IBSUWIJMJBI;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<BSJAKYMSOCV, Id32<KOCJWPCQAPD>> ZAWHLLOFXBQ;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly ZMFHVAWJYMI SABNEZLEENV;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly ZMFHVAWJYMI OALCVHCJFSH;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<BSJAKYMSOCV> WCEXBLOSNYF;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<BSJAKYMSOCV> OARUOZNTPYU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet PMTWOPPSTPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet TAKFVZWXOFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet DVSQGOURPZR
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static BSJAKYMSOCV WWEUIVUEMHF
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8790", Offset = "0x2BB7B90", VA = "0x182BB8790")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static BSJAKYMSOCV OHOKSCVAKRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8270", Offset = "0x2BB7670", VA = "0x182BB8270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static BSJAKYMSOCV BAPGRJGYHOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6400", Offset = "0x2BB5800", VA = "0x182BB6400")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static BSJAKYMSOCV LRNSTRRVQSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7200", Offset = "0x2BB6600", VA = "0x182BB7200")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static BSJAKYMSOCV ZKRJLSXPSGY
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8870", Offset = "0x2BB7C70", VA = "0x182BB8870")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static BSJAKYMSOCV RJNCBAQGWCT
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6530", Offset = "0x2BB5930", VA = "0x182BB6530")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static BSJAKYMSOCV KHNZQIIKHEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BB4EC0", Offset = "0x2BB42C0", VA = "0x182BB4EC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static BSJAKYMSOCV XNQTODWCJPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5180", Offset = "0x2BB4580", VA = "0x182BB5180")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static YDXBZIIWDJA XZRERLBLBDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8950", Offset = "0x2BB7D50", VA = "0x182BB8950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static YDXBZIIWDJA WJHEWYLLBRP
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5450", Offset = "0x2BB4850", VA = "0x182BB5450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static YDXBZIIWDJA HXRXBWWNUNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BB86F0", Offset = "0x2BB7AF0", VA = "0x182BB86F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static YDXBZIIWDJA CVNJAZJXETC
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5BD0", Offset = "0x2BB4FD0", VA = "0x182BB5BD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static YDXBZIIWDJA CGQFOAVNFXW
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7290", Offset = "0x2BB6690", VA = "0x182BB7290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static YDXBZIIWDJA BHJZAMIMKYX
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5CF0", Offset = "0x2BB50F0", VA = "0x182BB5CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static YDXBZIIWDJA EPXACWTOVYT
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5630", Offset = "0x2BB4A30", VA = "0x182BB5630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static YDXBZIIWDJA NEPXPLJOPPR
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8B80", Offset = "0x2BB7F80", VA = "0x182BB8B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static YDXBZIIWDJA DSQVMVAAGCS
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5CA0", Offset = "0x2BB50A0", VA = "0x182BB5CA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static YDXBZIIWDJA XPGRGGKPUKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8900", Offset = "0x2BB7D00", VA = "0x182BB8900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static YDXBZIIWDJA GYSNZSXKAAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6910", Offset = "0x2BB5D10", VA = "0x182BB6910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static YDXBZIIWDJA TKNBZEAHODZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8AE0", Offset = "0x2BB7EE0", VA = "0x182BB8AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static YDXBZIIWDJA ELOSETKZVQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8220", Offset = "0x2BB7620", VA = "0x182BB8220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static YDXBZIIWDJA JQILWAIBDOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BB59A0", Offset = "0x2BB4DA0", VA = "0x182BB59A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static YDXBZIIWDJA CPOVFIUIXZA
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6FA0", Offset = "0x2BB63A0", VA = "0x182BB6FA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static YDXBZIIWDJA DGPPIBMOFZM
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5950", Offset = "0x2BB4D50", VA = "0x182BB5950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static YDXBZIIWDJA SQXFVOUOQMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7800", Offset = "0x2BB6C00", VA = "0x182BB7800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static YDXBZIIWDJA FNBCJZQSJJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BB50E0", Offset = "0x2BB44E0", VA = "0x182BB50E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static YDXBZIIWDJA QFZIXXIQCPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6CD0", Offset = "0x2BB60D0", VA = "0x182BB6CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static YDXBZIIWDJA FVMAFIRLVEH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB59F0", Offset = "0x2BB4DF0", VA = "0x182BB59F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static YDXBZIIWDJA JYZGJQWIFCS
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5860", Offset = "0x2BB4C60", VA = "0x182BB5860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static YDXBZIIWDJA FXFKSZPQLDF
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8300", Offset = "0x2BB7700", VA = "0x182BB8300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static YDXBZIIWDJA YTXIRWXRIYJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB60A0", Offset = "0x2BB54A0", VA = "0x182BB60A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static YDXBZIIWDJA QIRPFVVDWSH
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB63B0", Offset = "0x2BB57B0", VA = "0x182BB63B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static YDXBZIIWDJA VZMBKXREKWL
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7130", Offset = "0x2BB6530", VA = "0x182BB7130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static YDXBZIIWDJA HOFCWVCIRKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5B30", Offset = "0x2BB4F30", VA = "0x182BB5B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static YDXBZIIWDJA BJQNVKAMWVB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7090", Offset = "0x2BB6490", VA = "0x182BB7090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static YDXBZIIWDJA IHZVXMULSBT
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5130", Offset = "0x2BB4530", VA = "0x182BB5130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static YDXBZIIWDJA MZDXBSLIWHT
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6FF0", Offset = "0x2BB63F0", VA = "0x182BB6FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static YDXBZIIWDJA BWDTLQACKRY
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5810", Offset = "0x2BB4C10", VA = "0x182BB5810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static YDXBZIIWDJA GPPGHCCSGVG
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BB65C0", Offset = "0x2BB59C0", VA = "0x182BB65C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static YDXBZIIWDJA BIGURVPSFIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5DF0", Offset = "0x2BB51F0", VA = "0x182BB5DF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static YDXBZIIWDJA HUNQEWSJNBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BB54F0", Offset = "0x2BB48F0", VA = "0x182BB54F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static YDXBZIIWDJA WZSBVYILJYX
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5090", Offset = "0x2BB4490", VA = "0x182BB5090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static YDXBZIIWDJA BBIPYALDNOU
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5260", Offset = "0x2BB4660", VA = "0x182BB5260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static YDXBZIIWDJA JRAXINGSYRQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB64E0", Offset = "0x2BB58E0", VA = "0x182BB64E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static YDXBZIIWDJA USASVBBRHFS
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8B30", Offset = "0x2BB7F30", VA = "0x182BB8B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static YDXBZIIWDJA BVWYULPQEJF
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8820", Offset = "0x2BB7C20", VA = "0x182BB8820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static YDXBZIIWDJA EWOEIJJSNFJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB81D0", Offset = "0x2BB75D0", VA = "0x182BB81D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static YDXBZIIWDJA ERTRQWMRDCC
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB84C0", Offset = "0x2BB78C0", VA = "0x182BB84C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static YDXBZIIWDJA MOJAEVBAZEE
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8740", Offset = "0x2BB7B40", VA = "0x182BB8740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static YDXBZIIWDJA WGFPOHNYKYW
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BB54A0", Offset = "0x2BB48A0", VA = "0x182BB54A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static YDXBZIIWDJA EXIBONXGHTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5EE0", Offset = "0x2BB52E0", VA = "0x182BB5EE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static YDXBZIIWDJA DEYQOJMRJCR
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5210", Offset = "0x2BB4610", VA = "0x182BB5210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static YDXBZIIWDJA BJJLRJEBTXR
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BB86A0", Offset = "0x2BB7AA0", VA = "0x182BB86A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static YDXBZIIWDJA XBEJBYUGDOW
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BB72E0", Offset = "0x2BB66E0", VA = "0x182BB72E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static YDXBZIIWDJA SSVCZGJWRZC
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BB83A0", Offset = "0x2BB77A0", VA = "0x182BB83A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static YDXBZIIWDJA UODFHCTBNHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BB68C0", Offset = "0x2BB5CC0", VA = "0x182BB68C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static YDXBZIIWDJA FPCSVHDSRIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5680", Offset = "0x2BB4A80", VA = "0x182BB5680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static YDXBZIIWDJA UGNXRVKKPDY
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5B80", Offset = "0x2BB4F80", VA = "0x182BB5B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static YDXBZIIWDJA CUAMBJFIXNU
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5720", Offset = "0x2BB4B20", VA = "0x182BB5720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static YDXBZIIWDJA MAWOZPWYWXK
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5590", Offset = "0x2BB4990", VA = "0x182BB5590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static YDXBZIIWDJA AQMOVDEFUTB
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6F00", Offset = "0x2BB6300", VA = "0x182BB6F00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static YDXBZIIWDJA DBCXKKGTNZA
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5A90", Offset = "0x2BB4E90", VA = "0x182BB5A90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static YDXBZIIWDJA JNRESYEONFV
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6820", Offset = "0x2BB5C20", VA = "0x182BB6820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static YDXBZIIWDJA TWNWGLWPXET
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7040", Offset = "0x2BB6440", VA = "0x182BB7040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static YDXBZIIWDJA CUSTCBMAZAP
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8470", Offset = "0x2BB7870", VA = "0x182BB8470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static YDXBZIIWDJA FDWZZXQFDBT
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8420", Offset = "0x2BB7820", VA = "0x182BB8420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static YDXBZIIWDJA YYDMDGPIEQW
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BB52B0", Offset = "0x2BB46B0", VA = "0x182BB52B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static YDXBZIIWDJA WDGZYHPAWBR
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7850", Offset = "0x2BB6C50", VA = "0x182BB7850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static YDXBZIIWDJA UIRCCJWTQSA
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7DB0", Offset = "0x2BB71B0", VA = "0x182BB7DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static YDXBZIIWDJA DVUTFVPPQEQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5A40", Offset = "0x2BB4E40", VA = "0x182BB5A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static YDXBZIIWDJA NGEIPJEENRD
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6E60", Offset = "0x2BB6260", VA = "0x182BB6E60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static YDXBZIIWDJA SBAYFOIUFMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6C80", Offset = "0x2BB6080", VA = "0x182BB6C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static YDXBZIIWDJA EWYYBVUAUIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BB56D0", Offset = "0x2BB4AD0", VA = "0x182BB56D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static YDXBZIIWDJA NRPSQXJYBCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6D20", Offset = "0x2BB6120", VA = "0x182BB6D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static YDXBZIIWDJA OPHMIFDGQAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5F80", Offset = "0x2BB5380", VA = "0x182BB5F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static YDXBZIIWDJA YHJLZIRGRNH
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6EB0", Offset = "0x2BB62B0", VA = "0x182BB6EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static YDXBZIIWDJA QTXBTVDCAFS
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6870", Offset = "0x2BB5C70", VA = "0x182BB6870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static YDXBZIIWDJA MIXZSYNMWYM
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB67D0", Offset = "0x2BB5BD0", VA = "0x182BB67D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static YDXBZIIWDJA HOVUBDNGYRK
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7E00", Offset = "0x2BB7200", VA = "0x182BB7E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static YDXBZIIWDJA IGIXZQLRWMZ
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6D70", Offset = "0x2BB6170", VA = "0x182BB6D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static YDXBZIIWDJA BQUMAKRFTBC
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB85B0", Offset = "0x2BB79B0", VA = "0x182BB85B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static YDXBZIIWDJA PUWLIGXQVYA
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5770", Offset = "0x2BB4B70", VA = "0x182BB5770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static YDXBZIIWDJA RBFFNDBVXSF
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6960", Offset = "0x2BB5D60", VA = "0x182BB6960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static YDXBZIIWDJA NMSYQIIRFZR
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8650", Offset = "0x2BB7A50", VA = "0x182BB8650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static YDXBZIIWDJA DDAYWHUSAZA
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5540", Offset = "0x2BB4940", VA = "0x182BB5540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static YDXBZIIWDJA GBBMJDQQCRH
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BB89F0", Offset = "0x2BB7DF0", VA = "0x182BB89F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static YDXBZIIWDJA FYDYFXGSGSH
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BB53B0", Offset = "0x2BB47B0", VA = "0x182BB53B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static YDXBZIIWDJA WYIRXDGRKAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7D60", Offset = "0x2BB7160", VA = "0x182BB7D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static YDXBZIIWDJA YPPNQMGGIAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6780", Offset = "0x2BB5B80", VA = "0x182BB6780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static YDXBZIIWDJA MTUFFXAUIEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7940", Offset = "0x2BB6D40", VA = "0x182BB7940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static YDXBZIIWDJA QVRRFHLIMUO
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8510", Offset = "0x2BB7910", VA = "0x182BB8510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static YDXBZIIWDJA WEYQNPPCXVJ
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB4FF0", Offset = "0x2BB43F0", VA = "0x182BB4FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static YDXBZIIWDJA NSTGQTVBXET
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8350", Offset = "0x2BB7750", VA = "0x182BB8350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static YDXBZIIWDJA GQAPDBPZQPV
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7330", Offset = "0x2BB6730", VA = "0x182BB7330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static YDXBZIIWDJA NJMNDIEMYJV
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6F50", Offset = "0x2BB6350", VA = "0x182BB6F50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static YDXBZIIWDJA YPHWZWVTFUT
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6190", Offset = "0x2BB5590", VA = "0x182BB6190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static YDXBZIIWDJA DQIPLQXHIJI
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6490", Offset = "0x2BB5890", VA = "0x182BB6490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static YDXBZIIWDJA NNOJGBDJQDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6DC0", Offset = "0x2BB61C0", VA = "0x182BB6DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static YDXBZIIWDJA HAOHLSCQUMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8560", Offset = "0x2BB7960", VA = "0x182BB8560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static YDXBZIIWDJA FNXIYUOBDVT
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8A40", Offset = "0x2BB7E40", VA = "0x182BB8A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static YDXBZIIWDJA VEPPEBJOPAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BB71B0", Offset = "0x2BB65B0", VA = "0x182BB71B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static YDXBZIIWDJA JMEKJHDHZUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7710", Offset = "0x2BB6B10", VA = "0x182BB7710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static YDXBZIIWDJA YONFNNILERA
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BB57C0", Offset = "0x2BB4BC0", VA = "0x182BB57C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static YDXBZIIWDJA VDBRMTGXLUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5F30", Offset = "0x2BB5330", VA = "0x182BB5F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static YDXBZIIWDJA FXQORSABTGP
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BB4FA0", Offset = "0x2BB43A0", VA = "0x182BB4FA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static YDXBZIIWDJA DVDHEGFNBTY
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5E40", Offset = "0x2BB5240", VA = "0x182BB5E40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static YDXBZIIWDJA NWUVMMWSQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BB58B0", Offset = "0x2BB4CB0", VA = "0x182BB58B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static YDXBZIIWDJA KQEKFGAEJDN
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5400", Offset = "0x2BB4800", VA = "0x182BB5400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static YDXBZIIWDJA RGPCVXXYCTV
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5040", Offset = "0x2BB4440", VA = "0x182BB5040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static YDXBZIIWDJA RZZMSHWZOHS
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5AE0", Offset = "0x2BB4EE0", VA = "0x182BB5AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static YDXBZIIWDJA OGYCTVIRMVZ
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB4F50", Offset = "0x2BB4350", VA = "0x182BB4F50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static YDXBZIIWDJA DDSSMSTZZZD
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BB78A0", Offset = "0x2BB6CA0", VA = "0x182BB78A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static YDXBZIIWDJA KHBRXRSMNTW
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5FD0", Offset = "0x2BB53D0", VA = "0x182BB5FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static YDXBZIIWDJA BKVZITCFDKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8600", Offset = "0x2BB7A00", VA = "0x182BB8600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static YDXBZIIWDJA OSLCALZNZHG
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7760", Offset = "0x2BB6B60", VA = "0x182BB7760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static YDXBZIIWDJA QMYCDPUZQUH
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5900", Offset = "0x2BB4D00", VA = "0x182BB5900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static YDXBZIIWDJA UYSNOHRPJZX
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BB89A0", Offset = "0x2BB7DA0", VA = "0x182BB89A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static YDXBZIIWDJA PRDBXRUJZTG
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8A90", Offset = "0x2BB7E90", VA = "0x182BB8A90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static YDXBZIIWDJA HXKAELYNKHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BB77B0", Offset = "0x2BB6BB0", VA = "0x182BB77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static YDXBZIIWDJA OCGPESPGCVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5E90", Offset = "0x2BB5290", VA = "0x182BB5E90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static YDXBZIIWDJA MXRYRTNODYA
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BB55E0", Offset = "0x2BB49E0", VA = "0x182BB55E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static YDXBZIIWDJA DVCVBNNNTPM
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6680", Offset = "0x2BB5A80", VA = "0x182BB6680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static YDXBZIIWDJA IGBBOIGNXOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6140", Offset = "0x2BB5540", VA = "0x182BB6140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static YDXBZIIWDJA DMTQRIIJHHD
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6E10", Offset = "0x2BB6210", VA = "0x182BB6E10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static YDXBZIIWDJA HTQDZBIVGLR
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2BB60F0", Offset = "0x2BB54F0", VA = "0x182BB60F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static YDXBZIIWDJA ACDRGEAEIIV
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2BB70E0", Offset = "0x2BB64E0", VA = "0x182BB70E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static YDXBZIIWDJA CGTBEJCQUMG
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2BB78F0", Offset = "0x2BB6CF0", VA = "0x182BB78F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BB62C0", Offset = "0x2BB56C0", VA = "0x182BB62C0")]
			public static ZMFHVAWJYMI KBGMAVVFELG([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6210", Offset = "0x2BB5610", VA = "0x182BB6210")]
			public static ClassFactoryTypeParams JWGLMZDMIMJ(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BB61E0", Offset = "0x2BB55E0", VA = "0x182BB61E0")]
			public static ClassFactoryTypeParams JWGLMZDMIMJ([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BB83F0", Offset = "0x2BB77F0", VA = "0x182BB83F0")]
			public static ZMFHVAWJYMI VSIGLEEIJLE(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7180", Offset = "0x2BB6580", VA = "0x182BB7180")]
			public static ZMFHVAWJYMI QTNBKFWDLAD(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7C30", Offset = "0x2BB7030", VA = "0x182BB7C30")]
			public static ZMFHVAWJYMI TSFOFKTRDOH([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7660", Offset = "0x2BB6A60", VA = "0x182BB7660")]
			public static BSJAKYMSOCV SDCWNCIEUQF(Id32<KOCJWPCQAPD> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6020", Offset = "0x2BB5420", VA = "0x182BB6020")]
			public static string JGWAEJFRHJY(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7380", Offset = "0x2BB6780", VA = "0x182BB7380")]
			private static BSJAKYMSOCV SDCWNCIEUQF(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6610", Offset = "0x2BB5A10", VA = "0x182BB6610")]
			public static Id32<KOCJWPCQAPD>? LLCYOMAYFNW(BSJAKYMSOCV a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7E50", Offset = "0x2BB7250", VA = "0x182BB7E50")]
			public static CircuitTypeIdWrapper? UTHBIEWUWEL(BSJAKYMSOCV a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8BD0", Offset = "0x2BB7FD0", VA = "0x182BB8BD0")]
			static IABNZHBPDRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB66D0", Offset = "0x2BB5AD0", VA = "0x182BB66D0")]
			[IteratorStateMachine(typeof(VIIIGVTVOCI))]
			private static IEnumerable<BSJAKYMSOCV> LRXTBEDUHZX(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5300", Offset = "0x2BB4700", VA = "0x182BB5300")]
			[IteratorStateMachine(typeof(LLUVENKAVVE))]
			public static IEnumerable<BSJAKYMSOCV> BVZLMBIPPMY(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7990", Offset = "0x2BB6D90", VA = "0x182BB7990")]
			public static Variant TQCUKBHMHSZ(BSJAKYMSOCV a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BB69B0", Offset = "0x2BB5DB0", VA = "0x182BB69B0")]
			public static Variant NZNJZHITGTS(BSJAKYMSOCV a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5C20", Offset = "0x2BB5020", VA = "0x182BB5C20")]
			public static bool HLWECZYJICI(BSJAKYMSOCV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5D40", Offset = "0x2BB5140", VA = "0x182BB5D40")]
			[IteratorStateMachine(typeof(BSWLAJKLZLZ))]
			public static IEnumerable<Id32<KOCJWPCQAPD>> ICYFNVZFDSC(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QGLQSQDBDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC420", Offset = "0x2BCB820", VA = "0x182BCC420")]
		public static XCDRQSKUHKB BGVSXQNQAUM(this BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD4E0", Offset = "0x2BCC8E0", VA = "0x182BCD4E0")]
		public static BSJAKYMSOCV BHPYVATLUMF(this XCDRQSKUHKB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JOEGSLPDHWT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B7F8C0", Offset = "0x3B7ECC0", VA = "0x183B7F8C0")]
		public static Dictionary<b, c> STTCQKHPIHH<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ZDDCJTAFOQA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2310", Offset = "0x2BD1710", VA = "0x182BD2310")]
		public static FRELYPKAFVB BGVSXQNQAUM([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2410", Offset = "0x2BD1810", VA = "0x182BD2410")]
		public static Guid BHPYVATLUMF(FRELYPKAFVB a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class UFLLHYFYVMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF8F0", Offset = "0x2BCECF0", VA = "0x182BCF8F0")]
		public static CVCSGJSMCOP BGVSXQNQAUM([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF980", Offset = "0x2BCED80", VA = "0x182BCF980")]
		public static NamedType BHPYVATLUMF(this CVCSGJSMCOP a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class NNLUYJGKYPT
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F5D0", Offset = "0x3D0E9D0", VA = "0x183D0F5D0")]
		public static void NVUUDIUFLBX<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F840", Offset = "0x3D0EC40", VA = "0x183D0F840")]
		public static void NVUUDIUFLBX<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class VFBKTDPAVNS
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF9E0", Offset = "0x2BCEDE0", VA = "0x182BCF9E0")]
		public static AXWRZTCJDYL BGVSXQNQAUM([In] this Variant self, BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFBE0", Offset = "0x2BCEFE0", VA = "0x182BCFBE0")]
		public static Variant BHPYVATLUMF(this AXWRZTCJDYL a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PDYFVPTGSHQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<OLTONIMFXQW> YQIKSJKKWIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool VXLXKDCDJWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool NRBRGJOJIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool FWDDVVGIFVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool PVXUPGPQNSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool PWNPHAXIQAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool MNLOLJSLJMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool NZOORSUVXBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool HEVZWJOLNCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, BSJAKYMSOCV Type)> ZJRIYCLUHDG;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid SGYXLDBUDMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A4B0", Offset = "0x2B798B0", VA = "0x182B7A4B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<OLTONIMFXQW> FQHIAUYLJUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B7A4B0", Offset = "0x2B798B0", VA = "0x182B7A4B0")]
			get
			{
				return default(Id128<OLTONIMFXQW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, BSJAKYMSOCV Type)> QYDZWZFCILR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IVKJHYXCUHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC44F0", Offset = "0x2BC38F0", VA = "0x182BC44F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4E00", Offset = "0x2BC4200", VA = "0x182BC4E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, BSJAKYMSOCV> FIPFYXYLEAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4740", Offset = "0x2BC3B40", VA = "0x182BC4740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4910", Offset = "0x2BC3D10", VA = "0x182BC4910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CUWOXEXSYLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4D50", Offset = "0x2BC4150", VA = "0x182BC4D50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4EA0", Offset = "0x2BC42A0", VA = "0x182BC4EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> TNVZOPXZOWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4F50", Offset = "0x2BC4350", VA = "0x182BC4F50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5190", Offset = "0x2BC4590", VA = "0x182BC5190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, BSJAKYMSOCV> JIEJGHQMATJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4690", Offset = "0x2BC3A90", VA = "0x182BC4690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4B10", Offset = "0x2BC3F10", VA = "0x182BC4B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MBVHRXOCQRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BC50F0", Offset = "0x2BC44F0", VA = "0x182BC50F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BC4CB0", Offset = "0x2BC40B0", VA = "0x182BC4CB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B30850", Offset = "0x1B2FC50", VA = "0x181B30850")]
		public void JJFBHXBWFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5550", Offset = "0x2BC4950", VA = "0x182BC5550")]
		internal PDYFVPTGSHQ([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, BSJAKYMSOCV Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4A40", Offset = "0x2BC3E40", VA = "0x182BC4A40")]
		public static CircuitEventDefinitionFactoryStart GYMJYDCNRDR(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BC49C0", Offset = "0x2BC3DC0", VA = "0x182BC49C0")]
		public static CircuitEventDefinitionFactoryStart GYMJYDCNRDR(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BC43E0", Offset = "0x2BC37E0", VA = "0x182BC43E0")]
		public static PDYFVPTGSHQ AFWLAYXWKJP([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5310", Offset = "0x2BC4710", VA = "0x182BC5310")]
		public static PDYFVPTGSHQ ZRJGOXIPFUD([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF151D0", Offset = "0xF145D0", VA = "0x180F151D0")]
		public void EWCWNCAJKYV(Id128<OLTONIMFXQW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BC52B0", Offset = "0x2BC46B0", VA = "0x182BC52B0")]
		public void YOUVUKJBFIU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5000", Offset = "0x2BC4400", VA = "0x182BC5000")]
		public void OKKJCWTGYLO(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4BC0", Offset = "0x2BC3FC0", VA = "0x182BC4BC0")]
		public void INIZWSHXSCT(int a, BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC47F0", Offset = "0x2BC3BF0", VA = "0x182BC47F0")]
		public void GSAIDKBZXWF(string a, BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5240", Offset = "0x2BC4640", VA = "0x182BC5240")]
		public void XHGLJVKQIKG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4590", Offset = "0x2BC3990", VA = "0x182BC4590")]
		public PDYFVPTGSHQ Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2BB3700", Offset = "0x2BB2B00", VA = "0x182BB3700")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3460", Offset = "0x2BB2860", VA = "0x182BB3460")]
		public CircuitEventDefinitionFactoryParams GOKOHWPRKIH(string a, BSJAKYMSOCV b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB35D0", Offset = "0x2BB29D0", VA = "0x182BB35D0")]
		public PDYFVPTGSHQ ISHNKJMJOID()
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
		private readonly List<(string Name, BSJAKYMSOCV Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BB33D0", Offset = "0x2BB27D0", VA = "0x182BB33D0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, BSJAKYMSOCV Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BB31A0", Offset = "0x2BB25A0", VA = "0x182BB31A0")]
		public CircuitEventDefinitionFactoryParams GOKOHWPRKIH(string a, BSJAKYMSOCV b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BB32D0", Offset = "0x2BB26D0", VA = "0x182BB32D0")]
		public PDYFVPTGSHQ ISHNKJMJOID()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class UKQWXJJCVBZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly PDYFVPTGSHQ UJJYRLJQJFQ;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly PDYFVPTGSHQ TGEFEZVIXHX;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly PDYFVPTGSHQ UYERIWQECRK;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly PDYFVPTGSHQ RQABNUUBOJL;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly PDYFVPTGSHQ BIGTNGQBBQK;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly PDYFVPTGSHQ ZNQQYRXCPDG;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly PDYFVPTGSHQ LOMBEYHDHZZ;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly PDYFVPTGSHQ[] HASDRFULBWQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class KRVTXTJCVXA
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly PDYFVPTGSHQ BFTRUGRJKBI;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class OSZSTXCWAVT
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly PDYFVPTGSHQ EJRYEMGVXNE;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly PDYFVPTGSHQ RFHSUNRUUFJ;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class TXMTVOGLINK
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly PDYFVPTGSHQ TFTQONFFXLF;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly PDYFVPTGSHQ TPRIULKXHIC;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly PDYFVPTGSHQ[] CRRGIVQWLVA;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly PDYFVPTGSHQ QHTXAYTEZWG;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly PDYFVPTGSHQ DQZNSJCDYZZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class FORNLEVTQNG
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly PDYFVPTGSHQ AMUVFYXEUJB;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly PDYFVPTGSHQ GQTEHTRXXFI;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class SBBXBHDUQAR
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly PDYFVPTGSHQ TARVXBAOODE;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly PDYFVPTGSHQ EWNAVGGKQAZ;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class DMAEOSXMBXM
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly PDYFVPTGSHQ EJRYEMGVXNE;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly PDYFVPTGSHQ RFHSUNRUUFJ;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class MPRPSYIPYYY
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly PDYFVPTGSHQ VPFCHOCKWPT;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly PDYFVPTGSHQ GOBGQOMNWCO;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly PDYFVPTGSHQ URABDSDVRKY;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly PDYFVPTGSHQ HAHCIDFZHYO;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly PDYFVPTGSHQ PEOJVJOCCON;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly PDYFVPTGSHQ XEUETMWCDVI;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly PDYFVPTGSHQ URJLCODDTPR;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class LVBXMAFNWHG
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class QUFXXIRMCOU
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class INUPLPCESQA
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class XRKAKBTVEQM
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly PDYFVPTGSHQ AFAGNUQMKAB;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly PDYFVPTGSHQ PTVXVKJTRRA;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RALNDTSPKAC
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class HATRNNQHQYS
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class NETUNIWGXIK
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class YWOAAWTKQWF
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly PDYFVPTGSHQ ORWFZXOIHYZ;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly PDYFVPTGSHQ ALNJNMPPSJJ;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly PDYFVPTGSHQ PLNQKXFLLYM;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly PDYFVPTGSHQ SUCKIFNKTPL;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly PDYFVPTGSHQ BDJWPTYWKTJ;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly PDYFVPTGSHQ TARVXBAOODE;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly PDYFVPTGSHQ ISTGETPRMSL;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly PDYFVPTGSHQ HKUDDOMKMIE;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly PDYFVPTGSHQ WFVLUUVUMLQ;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly PDYFVPTGSHQ KWYMZKMUYPU;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly PDYFVPTGSHQ BLIDXKRVPDK;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly PDYFVPTGSHQ ORFNSLQAPSG;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly PDYFVPTGSHQ JJIVMQLDXVD;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly PDYFVPTGSHQ RUAHKPSYNEU;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly PDYFVPTGSHQ CERYAWZZLQX;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly PDYFVPTGSHQ EWUGNGBSOYH;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly PDYFVPTGSHQ IPYAORIRXOR;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly PDYFVPTGSHQ YXVSQLVPNUW;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly PDYFVPTGSHQ BIREMNWZUIL;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly PDYFVPTGSHQ RWGMRFDJYEB;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly PDYFVPTGSHQ PSROOWIBSQY;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly PDYFVPTGSHQ GCRCKJZWXPW;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly PDYFVPTGSHQ LOSXHABQNAW;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly PDYFVPTGSHQ DELEELZDEZY;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly PDYFVPTGSHQ NCUOTYUNIVE;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly PDYFVPTGSHQ SSLZAQYFOJU;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly PDYFVPTGSHQ QKGBESCOFYA;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly PDYFVPTGSHQ PTNYQYGTRKE;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly PDYFVPTGSHQ HJSXTHHLIOJ;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly PDYFVPTGSHQ POIALBHNAFP;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly PDYFVPTGSHQ FBADEWSMGBS;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly PDYFVPTGSHQ ZFNMNNFEJWE;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly PDYFVPTGSHQ CSIPLNSVWHL;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly PDYFVPTGSHQ WHSQHBXHJJL;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly PDYFVPTGSHQ NJJGEBLHOAN;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly PDYFVPTGSHQ VIQXGNJBLTH;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly PDYFVPTGSHQ JTWIILGMWSJ;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly PDYFVPTGSHQ RYIQQNBXJVZ;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly PDYFVPTGSHQ DJYAIXMEBVR;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly PDYFVPTGSHQ KIFLUXAYQVZ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly PDYFVPTGSHQ VMVECYANYPI;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly PDYFVPTGSHQ HGBOZQKICTC;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly PDYFVPTGSHQ TRTKYDINXFQ;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly PDYFVPTGSHQ JYHGUFWXCZU;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly PDYFVPTGSHQ WZIXRBNPEWC;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly PDYFVPTGSHQ APBXTEKJKCK;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly PDYFVPTGSHQ QBYOULOAQGA;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly PDYFVPTGSHQ AJKCJSDURQA;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly PDYFVPTGSHQ UVTLBAOIMGA;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly PDYFVPTGSHQ LHCCEMOJHHA;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly PDYFVPTGSHQ DSPGOUQJCYR;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly PDYFVPTGSHQ UWBPFMDZHFU;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly PDYFVPTGSHQ CHXEFUKIGDO;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly PDYFVPTGSHQ YLVEJIOORZA;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly PDYFVPTGSHQ FVJIKQZSHDA;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly PDYFVPTGSHQ INWATTFFCQS;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly PDYFVPTGSHQ BBDZHNXAZCC;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly PDYFVPTGSHQ WQOOXVKVBTI;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly PDYFVPTGSHQ DLAAFLLNEMY;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly PDYFVPTGSHQ UXUFPVTAFPG;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly PDYFVPTGSHQ LKDEQIXHCTK;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly PDYFVPTGSHQ ZTMEWMOACLI;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly PDYFVPTGSHQ GMMBCNFZSOF;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly PDYFVPTGSHQ JMJRYBDUYSS;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly PDYFVPTGSHQ FJWGJPIZBOO;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly PDYFVPTGSHQ YTIPQMVYKMZ;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly PDYFVPTGSHQ MNFDKBTCMYP;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly PDYFVPTGSHQ EEUTDGXYKOI;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly PDYFVPTGSHQ NMLGYEAFXIS;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class KQPRXPOYCMB
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class JGCJEXNATZG
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly PDYFVPTGSHQ SUHXMETCBBE;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly PDYFVPTGSHQ SGVDQTEGEBF;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly PDYFVPTGSHQ WJYTRPWCYTR;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly PDYFVPTGSHQ HATQFKDOJSI;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly PDYFVPTGSHQ IWHGQHCVDYQ;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly PDYFVPTGSHQ QROUCBBZKWW;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly PDYFVPTGSHQ NMTVQAAPEKY;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class FPVOAKRHLAN
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly PDYFVPTGSHQ ALNJNMPPSJJ;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly PDYFVPTGSHQ PLNQKXFLLYM;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly PDYFVPTGSHQ SUCKIFNKTPL;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly PDYFVPTGSHQ PQLKGIRLWYN;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly PDYFVPTGSHQ DKGZCKGAYFH;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly PDYFVPTGSHQ DZPZHWZVAEV;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly PDYFVPTGSHQ IOWLTMIREAH;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class FQOMDVVGFZD
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly PDYFVPTGSHQ FHZFPEOCSFV;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly PDYFVPTGSHQ OBRQHLNMUOT;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly PDYFVPTGSHQ YZCTFIGAXNC;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly PDYFVPTGSHQ QDLJAKACFJG;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly PDYFVPTGSHQ KLROLXIUKBC;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly PDYFVPTGSHQ ZFZIBHODCDI;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class DEJGGGDIXKO
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class TYBMALUSISB
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly PDYFVPTGSHQ HSTMCUSXYGD;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class UWXKDUOPVHF
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly PDYFVPTGSHQ ORWFZXOIHYZ;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class XBXKTRUSBCU
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class JNGRBZYFKXV
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class HDAESPUZNCM
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly PDYFVPTGSHQ YPSBSCGPRMY;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly PDYFVPTGSHQ JXMFDJKVVOO;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly PDYFVPTGSHQ WNLYOJXYNYF;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly PDYFVPTGSHQ MEDFIZDXEWZ;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class FXKLCJLDUKO
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly PDYFVPTGSHQ QQQXKMFMHBZ;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly PDYFVPTGSHQ THGVDUEHTTC;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class CIHNSRGLQYW
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class CMCKVBHUWKG
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly PDYFVPTGSHQ SUHXMETCBBE;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly PDYFVPTGSHQ SGVDQTEGEBF;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class YPUYXKGDFBZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly PDYFVPTGSHQ OOUSWORZTMI;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly PDYFVPTGSHQ HATQFKDOJSI;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly PDYFVPTGSHQ IWHGQHCVDYQ;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly PDYFVPTGSHQ QROUCBBZKWW;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly PDYFVPTGSHQ PSIGPWRSMSV;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly PDYFVPTGSHQ TVLRYMJTMYC;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly PDYFVPTGSHQ HUOKRNMKQUS;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly PDYFVPTGSHQ APJFEWATKYY;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly PDYFVPTGSHQ EZCZLEVYULX;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly PDYFVPTGSHQ ZCAQOUIFBAN;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly PDYFVPTGSHQ SUHXMETCBBE;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly PDYFVPTGSHQ SGVDQTEGEBF;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class HZDXPLOKXIF
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class ILGLIJWWOQL
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly PDYFVPTGSHQ SUHXMETCBBE;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly PDYFVPTGSHQ SGVDQTEGEBF;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly PDYFVPTGSHQ GBHHOAVMBWN;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly PDYFVPTGSHQ HYYURVQRMIJ;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly PDYFVPTGSHQ LTDAHCKIMGQ;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class LROSBHRFHHQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class TFDEDQZQIWB
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly PDYFVPTGSHQ VWVNQTKUWUW;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class CIKARRVXIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly PDYFVPTGSHQ VZCUUCBKJPF;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly PDYFVPTGSHQ QEITBYQIMIK;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly PDYFVPTGSHQ SUHXMETCBBE;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly PDYFVPTGSHQ SGVDQTEGEBF;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class GQAXANZIIZK
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class WLVASNOWQEI
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class IJFVGLJBRUN
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class JXMMGYDUADT
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class TCCBCFELCLC
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class KTPGZDHXBOI
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly PDYFVPTGSHQ AFAGNUQMKAB;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly PDYFVPTGSHQ PTVXVKJTRRA;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class KEOQPEJUGTK
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly PDYFVPTGSHQ QBDFDXPQJRB;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly PDYFVPTGSHQ YOXNKIXRLNL;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly PDYFVPTGSHQ WFXWRBZGJOT;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly PDYFVPTGSHQ FTIPWBXQTCZ;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class KXVWRUEQSJL
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly PDYFVPTGSHQ QBDFDXPQJRB;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly PDYFVPTGSHQ YOXNKIXRLNL;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly PDYFVPTGSHQ WFXWRBZGJOT;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly PDYFVPTGSHQ FTIPWBXQTCZ;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class XPKOLSHIWOU
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class QZLAGUQCBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly PDYFVPTGSHQ XOCDKULZZZQ;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly PDYFVPTGSHQ PXERYGQXHEC;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly PDYFVPTGSHQ ADGZETKVRUC;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class EWNDTJQRTRG
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly PDYFVPTGSHQ NIDLVOMBXRR;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly PDYFVPTGSHQ WHRCXTAPIFH;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly PDYFVPTGSHQ SLACEXMEZPQ;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class RDEESHILFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class PHRRYDLRMYW
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly PDYFVPTGSHQ QFSXGLQJBHI;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly PDYFVPTGSHQ KLRHDUSSMBK;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly PDYFVPTGSHQ ZEUOZSYYGHB;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly PDYFVPTGSHQ EWTDDGHQCJN;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly PDYFVPTGSHQ GQSADRAGZCS;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class VPVDPAMVWGN
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly PDYFVPTGSHQ OJOQBLCIHBY;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class RTPCFYBLHGN
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly PDYFVPTGSHQ RCOYLDNEMGT;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly PDYFVPTGSHQ BGPGLVXSQGI;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly PDYFVPTGSHQ ZKHFAPRDCVB;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class THMLRBILMWG
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class KSKVBNWFJDC
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class TMOCYAODERJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class FREFAFYXNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly PDYFVPTGSHQ XNQDNFZGNTH;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly PDYFVPTGSHQ HNQCLDSASHI;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly PDYFVPTGSHQ PGECTNMDGMA;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly PDYFVPTGSHQ TXUBTTUKESQ;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly PDYFVPTGSHQ NOKMRZMMYNZ;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly PDYFVPTGSHQ PXFSVOKIZOJ;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly PDYFVPTGSHQ MMELONQMTNU;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class KMCBPEDBMSM
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly PDYFVPTGSHQ MERMWYHCYYD;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly PDYFVPTGSHQ[] XAJMBAEMFZF;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class TGAZFOYDRZK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly BSJAKYMSOCV YKJIHGLFAWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<PDYFVPTGSHQ> QLQPZQTSIYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<PDYFVPTGSHQ> XSSAHXORAYQ;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<PDYFVPTGSHQ> CJDVAJEGUEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<PDYFVPTGSHQ> ZGCDJMXYPOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFCB0", Offset = "0x2BDF0B0", VA = "0x182BDFCB0")]
		protected TGAZFOYDRZK(BSJAKYMSOCV a, params PDYFVPTGSHQ[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class PKNKEZEZYUI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD4C0", Offset = "0x2BDC8C0", VA = "0x182BDD4C0")]
		internal PKNKEZEZYUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class HKENRXGJGIF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8090", Offset = "0x2BD7490", VA = "0x182BD8090")]
		internal HKENRXGJGIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class VAXCTHLIAHS : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BE08A0", Offset = "0x2BDFCA0", VA = "0x182BE08A0")]
		internal VAXCTHLIAHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class KKVJDSMMAZH : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA580", Offset = "0x2BD9980", VA = "0x182BDA580")]
		internal KKVJDSMMAZH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class GXFNQBZEAUO : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6EB0", Offset = "0x2BD62B0", VA = "0x182BD6EB0")]
		internal GXFNQBZEAUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class DMTYVWHGXMG : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4010", Offset = "0x2BD3410", VA = "0x182BD4010")]
		internal DMTYVWHGXMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class QIAPLJIXDKN : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD690", Offset = "0x2BDCA90", VA = "0x182BDD690")]
		internal QIAPLJIXDKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ZQWFFTFUMHG : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2F00", Offset = "0x2BE2300", VA = "0x182BE2F00")]
		internal ZQWFFTFUMHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class YWVQPASRCLY : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2990", Offset = "0x2BE1D90", VA = "0x182BE2990")]
		internal YWVQPASRCLY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class CKBIXUAGZWK : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3840", Offset = "0x2BD2C40", VA = "0x182BD3840")]
		internal CKBIXUAGZWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class USSWNLLPEDI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0540", Offset = "0x2BDF940", VA = "0x182BE0540")]
		internal USSWNLLPEDI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class TAYLTWOTLJQ : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF600", Offset = "0x2BDEA00", VA = "0x182BDF600")]
		internal TAYLTWOTLJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class HTUQJDWQIZI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD83B0", Offset = "0x2BD77B0", VA = "0x182BD83B0")]
		internal HTUQJDWQIZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class JWWZAZFEPHI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C80", Offset = "0x2BD9080", VA = "0x182BD9C80")]
		internal JWWZAZFEPHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class UJNNBSIBMCU : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BE01A0", Offset = "0x2BDF5A0", VA = "0x182BE01A0")]
		internal UJNNBSIBMCU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZAWMOYMVORO : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2B60", Offset = "0x2BE1F60", VA = "0x182BE2B60")]
		internal ZAWMOYMVORO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class WNFOKMIOWWI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1470", Offset = "0x2BE0870", VA = "0x182BE1470")]
		internal WNFOKMIOWWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class VIXLOJMIYQV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0A70", Offset = "0x2BDFE70", VA = "0x182BE0A70")]
		internal VIXLOJMIYQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class OMJJYFTRQDV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC600", Offset = "0x2BDBA00", VA = "0x182BDC600")]
		internal OMJJYFTRQDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class EZUETILUTHR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD48C0", Offset = "0x2BD3CC0", VA = "0x182BD48C0")]
		internal EZUETILUTHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class BOWPOIEPXZX : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2BF0", Offset = "0x2BD1FF0", VA = "0x182BD2BF0")]
		internal BOWPOIEPXZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class JKQHFLMEPKV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BD99D0", Offset = "0x2BD8DD0", VA = "0x182BD99D0")]
		internal JKQHFLMEPKV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class RAVMFCLPTVU : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE200", Offset = "0x2BDD600", VA = "0x182BDE200")]
		internal RAVMFCLPTVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class AZEFSQPROXR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2A20", Offset = "0x2BD1E20", VA = "0x182BD2A20")]
		internal AZEFSQPROXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class KPCPHDULDRW : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9B0", Offset = "0x2BD9DB0", VA = "0x182BDA9B0")]
		internal KPCPHDULDRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class WBDEKEJVIEP : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1240", Offset = "0x2BE0640", VA = "0x182BE1240")]
		internal WBDEKEJVIEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MBVQNBCPHDP : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBEA0", Offset = "0x2BDB2A0", VA = "0x182BDBEA0")]
		internal MBVQNBCPHDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LCQPXRTVDSD : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBAA0", Offset = "0x2BDAEA0", VA = "0x182BDBAA0")]
		internal LCQPXRTVDSD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TBHPYRJKBCS : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF7D0", Offset = "0x2BDEBD0", VA = "0x182BDF7D0")]
		internal TBHPYRJKBCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YHRLOHARVAL : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1B00", Offset = "0x2BE0F00", VA = "0x182BE1B00")]
		internal YHRLOHARVAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class VUTVTBLVPTI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0EA0", Offset = "0x2BE02A0", VA = "0x182BE0EA0")]
		internal VUTVTBLVPTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HRSXECGFUJW : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BD81E0", Offset = "0x2BD75E0", VA = "0x182BD81E0")]
		internal HRSXECGFUJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ROVMPICQIWY : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE600", Offset = "0x2BDDA00", VA = "0x182BDE600")]
		internal ROVMPICQIWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class TAHHLXHACBR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF3B0", Offset = "0x2BDE7B0", VA = "0x182BDF3B0")]
		internal TAHHLXHACBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class OYWFNDXHBUB : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC7D0", Offset = "0x2BDBBD0", VA = "0x182BDC7D0")]
		internal OYWFNDXHBUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class EVCUIXVZWEX : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BD41E0", Offset = "0x2BD35E0", VA = "0x182BD41E0")]
		internal EVCUIXVZWEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class RPHVZJVDWUA : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE7D0", Offset = "0x2BDDBD0", VA = "0x182BDE7D0")]
		internal RPHVZJVDWUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class BUXAJIKFHAF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2E40", Offset = "0x2BD2240", VA = "0x182BD2E40")]
		internal BUXAJIKFHAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class QUZLUWJXNLT : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDA30", Offset = "0x2BDCE30", VA = "0x182BDDA30")]
		internal QUZLUWJXNLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class SNHCFABRTGC : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF010", Offset = "0x2BDE410", VA = "0x182BDF010")]
		internal SNHCFABRTGC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class IMVQPUOIHKS : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8DF0", Offset = "0x2BD81F0", VA = "0x182BD8DF0")]
		internal IMVQPUOIHKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class ZAWNTDJNNDM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2D30", Offset = "0x2BE2130", VA = "0x182BE2D30")]
		internal ZAWNTDJNNDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class SHBPLNBYVXL : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEE40", Offset = "0x2BDE240", VA = "0x182BDEE40")]
		internal SHBPLNBYVXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class LFYVLGAZNSV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBC70", Offset = "0x2BDB070", VA = "0x182BDBC70")]
		internal LFYVLGAZNSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class QQXIVBMELTM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD860", Offset = "0x2BDCC60", VA = "0x182BDD860")]
		internal QQXIVBMELTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CMKJLUQTORZ : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3DE0", Offset = "0x2BD31E0", VA = "0x182BD3DE0")]
		internal CMKJLUQTORZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class XPZCXHSYLTM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1760", Offset = "0x2BE0B60", VA = "0x182BE1760")]
		internal XPZCXHSYLTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class PJFVNXRFEOF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD2F0", Offset = "0x2BDC6F0", VA = "0x182BDD2F0")]
		internal PJFVNXRFEOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class STWKBJFITON : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF1E0", Offset = "0x2BDE5E0", VA = "0x182BDF1E0")]
		internal STWKBJFITON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class URZCWMQWQOC : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0370", Offset = "0x2BDF770", VA = "0x182BE0370")]
		internal URZCWMQWQOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class OIVUZTACFEM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC430", Offset = "0x2BDB830", VA = "0x182BDC430")]
		internal OIVUZTACFEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BYFEXTLHANR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3090", Offset = "0x2BD2490", VA = "0x182BD3090")]
		internal BYFEXTLHANR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class HJXNQMVVPEM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7EC0", Offset = "0x2BD72C0", VA = "0x182BD7EC0")]
		internal HJXNQMVVPEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class AXPEQXIXRYB : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2850", Offset = "0x2BD1C50", VA = "0x182BD2850")]
		internal AXPEQXIXRYB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class YBFLOYHLRZT : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1930", Offset = "0x2BE0D30", VA = "0x182BE1930")]
		internal YBFLOYHLRZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class RFLVPTPRJYD : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE430", Offset = "0x2BDD830", VA = "0x182BDE430")]
		internal RFLVPTPRJYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class AJPJDKLEDPD : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2680", Offset = "0x2BD1A80", VA = "0x182BD2680")]
		internal AJPJDKLEDPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class LAHRAVDQSWE : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB8D0", Offset = "0x2BDACD0", VA = "0x182BDB8D0")]
		internal LAHRAVDQSWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class AGRKCBKJCZR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD24B0", Offset = "0x2BD18B0", VA = "0x182BD24B0")]
		internal AGRKCBKJCZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class VWPEGDUAILV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1070", Offset = "0x2BE0470", VA = "0x182BE1070")]
		internal VWPEGDUAILV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class NXRZRNXFCLA : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC070", Offset = "0x2BDB470", VA = "0x182BDC070")]
		internal NXRZRNXFCLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class IRLXCVVYBLB : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8FC0", Offset = "0x2BD83C0", VA = "0x182BD8FC0")]
		internal IRLXCVVYBLB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class ICCTPAAHWPE : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BD85E0", Offset = "0x2BD79E0", VA = "0x182BD85E0")]
		internal ICCTPAAHWPE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class KDUSNDQJHWF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9DC0", Offset = "0x2BD91C0", VA = "0x182BD9DC0")]
		internal KDUSNDQJHWF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class KUGIOOZJDED : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB010", Offset = "0x2BDA410", VA = "0x182BDB010")]
		internal KUGIOOZJDED()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, MAQPBFCDGIJ<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly BSJAKYMSOCV Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
		private NamedType(string name, BSJAKYMSOCV type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B10A80", Offset = "0x2B0FE80", VA = "0x182B10A80")]
		public static NamedType New(string name, BSJAKYMSOCV type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC270", Offset = "0x2BDB670", VA = "0x182BDC270")]
		public static bool VPGVCSNEDTU([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC270", Offset = "0x2BDB670", VA = "0x182BDC270", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC270", Offset = "0x2BDB670", VA = "0x182BDC270")]
		public bool NFHEFKJNFIE([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC1C0", Offset = "0x2BDB5C0", VA = "0x182BDC1C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC300", Offset = "0x2BDB700", VA = "0x182BDC300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC370", Offset = "0x2BDB770", VA = "0x182BDC370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC2C0", Offset = "0x2BDB6C0", VA = "0x182BDC2C0")]
		public string GZYHPCREKQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC3B0", Offset = "0x2BDB7B0", VA = "0x182BDC3B0")]
		public string ZHFBKANYPSC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC270", Offset = "0x2BDB670", VA = "0x182BDC270", Slot = "5")]
		private bool TVZXMHGWIWJ([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface OKXJRNOVLSL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(PXBFMCKNGBK a, bool b);
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
