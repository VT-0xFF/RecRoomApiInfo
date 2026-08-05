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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC1D90", Offset = "0x2BC0790", VA = "0x182BC1D90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC1430", Offset = "0x2BBFE30", VA = "0x182BC1430", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD3720", Offset = "0x2BD2120", VA = "0x182BD3720")]
		public static bool XYSLZOUTKET(this BSJAKYMSOCV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3830", Offset = "0x2BD2230", VA = "0x182BD3830")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BC1FB0", Offset = "0x2BC09B0", VA = "0x182BC1FB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1E10", Offset = "0x2BC0810", VA = "0x182BC1E10")]
			public static TGAZFOYDRZK CJFWFFGQOII(Id32<PXTZEBZCMDX> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1E90", Offset = "0x2BC0890", VA = "0x182BC1E90")]
			public static bool DPZKGLCVMRL(Id32<PXTZEBZCMDX> id, [Out] TGAZFOYDRZK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2000", Offset = "0x2BC0A00", VA = "0x182BC2000")]
			public static BSJAKYMSOCV SDCWNCIEUQF(Id32<PXTZEBZCMDX> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1F20", Offset = "0x2BC0920", VA = "0x182BC1F20")]
			private static Id32<PXTZEBZCMDX> GZVUEGYMGMP(TGAZFOYDRZK a, Id32<PXTZEBZCMDX> id)
			{
				return default(Id32<PXTZEBZCMDX>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC20B0", Offset = "0x2BC0AB0", VA = "0x182BC20B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x12B5C10", Offset = "0x12B4610", VA = "0x1812B5C10")]
				private TypeRegistryFactory([In] IdUnsafeList<KOCJWPCQAPD, BSJAKYMSOCV?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BD03C0", Offset = "0x2BCEDC0", VA = "0x182BD03C0")]
				public static TypeRegistryFactory GYMJYDCNRDR()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BD0420", Offset = "0x2BCEE20", VA = "0x182BD0420")]
				public (ReadOnlyIdArray<KOCJWPCQAPD, BSJAKYMSOCV>, IReadOnlyDictionary<BSJAKYMSOCV, Id32<KOCJWPCQAPD>>) ISHNKJMJOID()
				{
					return default((ReadOnlyIdArray<KOCJWPCQAPD, BSJAKYMSOCV>, IReadOnlyDictionary<BSJAKYMSOCV, Id32<KOCJWPCQAPD>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BD07E0", Offset = "0x2BCF1E0", VA = "0x182BD07E0")]
				public Id32<KOCJWPCQAPD> XPCEVMOILWF(int a, BSJAKYMSOCV b)
				{
					return default(Id32<KOCJWPCQAPD>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BD0790", Offset = "0x2BCF190", VA = "0x182BD0790")]
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
					[Cpp2IlInjected.Address(RVA = "0x2BC0BA0", Offset = "0x2BBF5A0", VA = "0x182BC0BA0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0920", Offset = "0x2BBF320", VA = "0x182BC0920")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<KOCJWPCQAPD> OHOKSCVAKRJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0B60", Offset = "0x2BBF560", VA = "0x182BC0B60")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0B20", Offset = "0x2BBF520", VA = "0x182BC0B20")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<KOCJWPCQAPD> BAPGRJGYHOY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0A60", Offset = "0x2BBF460", VA = "0x182BC0A60")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0A20", Offset = "0x2BBF420", VA = "0x182BC0A20")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<KOCJWPCQAPD> LRNSTRRVQSO
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0AE0", Offset = "0x2BBF4E0", VA = "0x182BC0AE0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BC09A0", Offset = "0x2BBF3A0", VA = "0x182BC09A0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<KOCJWPCQAPD> XNQTODWCJPI
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BC08E0", Offset = "0x2BBF2E0", VA = "0x182BC08E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0AA0", Offset = "0x2BBF4A0", VA = "0x182BC0AA0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<KOCJWPCQAPD> TSFOFKTRDOH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BC09E0", Offset = "0x2BBF3E0", VA = "0x182BC09E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KOCJWPCQAPD>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BC0960", Offset = "0x2BBF360", VA = "0x182BC0960")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
				[DebuggerHidden]
				public LLUVENKAVVE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BC12F0", Offset = "0x2BBFCF0", VA = "0x182BC12F0", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0F00", Offset = "0x2BBF900", VA = "0x182BC0F00", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0DF0", Offset = "0x2BBF7F0", VA = "0x182BC0DF0")]
				private void ALJGYZPBIVB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BC1380", Offset = "0x2BBFD80", VA = "0x182BC1380", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0E40", Offset = "0x2BBF840", VA = "0x182BC0E40", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<BSJAKYMSOCV> CUVZYYGPJGV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0E40", Offset = "0x2BBF840", VA = "0x182BC0E40", Slot = "5")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
				[DebuggerHidden]
				public VIIIGVTVOCI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BD1390", Offset = "0x2BCFD90", VA = "0x182BD1390", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BD32A0", Offset = "0x2BD1CA0", VA = "0x182BD32A0", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BD12E0", Offset = "0x2BCFCE0", VA = "0x182BD12E0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<BSJAKYMSOCV> CUVZYYGPJGV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BD12E0", Offset = "0x2BCFCE0", VA = "0x182BD12E0", Slot = "5")]
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
					[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0x2BB3390", Offset = "0x2BB1D90", VA = "0x182BB3390", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15A6EB0", Offset = "0x15A58B0", VA = "0x1815A6EB0")]
				[DebuggerHidden]
				public BSWLAJKLZLZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BB3490", Offset = "0x2BB1E90", VA = "0x182BB3490", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2E90", Offset = "0x2BB1890", VA = "0x182BB2E90", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2DF0", Offset = "0x2BB17F0", VA = "0x182BB2DF0")]
				private void ALJGYZPBIVB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BB2E40", Offset = "0x2BB1840", VA = "0x182BB2E40")]
				private void ALONWGIYSGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BB35E0", Offset = "0x2BB1FE0", VA = "0x182BB35E0", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BB33E0", Offset = "0x2BB1DE0", VA = "0x182BB33E0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<KOCJWPCQAPD>> VYZEJTLNNAO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BB33E0", Offset = "0x2BB1DE0", VA = "0x182BB33E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet TAKFVZWXOFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet DVSQGOURPZR
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD5AEB0", Offset = "0xD598B0", VA = "0x180D5AEB0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static BSJAKYMSOCV WWEUIVUEMHF
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9320", Offset = "0x2BB7D20", VA = "0x182BB9320")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static BSJAKYMSOCV OHOKSCVAKRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BB8D30", Offset = "0x2BB7730", VA = "0x182BB8D30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static BSJAKYMSOCV BAPGRJGYHOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6C20", Offset = "0x2BB5620", VA = "0x182BB6C20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static BSJAKYMSOCV LRNSTRRVQSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BB7BE0", Offset = "0x2BB65E0", VA = "0x182BB7BE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static BSJAKYMSOCV ZKRJLSXPSGY
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BB9410", Offset = "0x2BB7E10", VA = "0x182BB9410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static BSJAKYMSOCV RJNCBAQGWCT
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BB6D70", Offset = "0x2BB5770", VA = "0x182BB6D70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static BSJAKYMSOCV KHNZQIIKHEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5400", Offset = "0x2BB3E00", VA = "0x182BB5400")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static BSJAKYMSOCV XNQTODWCJPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BB5730", Offset = "0x2BB4130", VA = "0x182BB5730")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static YDXBZIIWDJA XZRERLBLBDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BB94F0", Offset = "0x2BB7EF0", VA = "0x182BB94F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5A50", Offset = "0x2BB4450", VA = "0x182BB5A50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9270", Offset = "0x2BB7C70", VA = "0x182BB9270")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6330", Offset = "0x2BB4D30", VA = "0x182BB6330")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7C70", Offset = "0x2BB6670", VA = "0x182BB7C70")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6450", Offset = "0x2BB4E50", VA = "0x182BB6450")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5C80", Offset = "0x2BB4680", VA = "0x182BB5C80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9770", Offset = "0x2BB8170", VA = "0x182BB9770")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6400", Offset = "0x2BB4E00", VA = "0x182BB6400")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB94A0", Offset = "0x2BB7EA0", VA = "0x182BB94A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB71C0", Offset = "0x2BB5BC0", VA = "0x182BB71C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB96C0", Offset = "0x2BB80C0", VA = "0x182BB96C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8CE0", Offset = "0x2BB76E0", VA = "0x182BB8CE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6090", Offset = "0x2BB4A90", VA = "0x182BB6090")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7910", Offset = "0x2BB6310", VA = "0x182BB7910")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6030", Offset = "0x2BB4A30", VA = "0x182BB6030")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8230", Offset = "0x2BB6C30", VA = "0x182BB8230")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5670", Offset = "0x2BB4070", VA = "0x182BB5670")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB75B0", Offset = "0x2BB5FB0", VA = "0x182BB75B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB60F0", Offset = "0x2BB4AF0", VA = "0x182BB60F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5F10", Offset = "0x2BB4910", VA = "0x182BB5F10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8DC0", Offset = "0x2BB77C0", VA = "0x182BB8DC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6870", Offset = "0x2BB5270", VA = "0x182BB6870")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6BC0", Offset = "0x2BB55C0", VA = "0x182BB6BC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7AF0", Offset = "0x2BB64F0", VA = "0x182BB7AF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6270", Offset = "0x2BB4C70", VA = "0x182BB6270")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7A30", Offset = "0x2BB6430", VA = "0x182BB7A30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB56D0", Offset = "0x2BB40D0", VA = "0x182BB56D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7970", Offset = "0x2BB6370", VA = "0x182BB7970")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5EB0", Offset = "0x2BB48B0", VA = "0x182BB5EB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6E00", Offset = "0x2BB5800", VA = "0x182BB6E00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6550", Offset = "0x2BB4F50", VA = "0x182BB6550")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5B00", Offset = "0x2BB4500", VA = "0x182BB5B00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5610", Offset = "0x2BB4010", VA = "0x182BB5610")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5820", Offset = "0x2BB4220", VA = "0x182BB5820")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6D10", Offset = "0x2BB5710", VA = "0x182BB6D10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9710", Offset = "0x2BB8110", VA = "0x182BB9710")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB93B0", Offset = "0x2BB7DB0", VA = "0x182BB93B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8C80", Offset = "0x2BB7680", VA = "0x182BB8C80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8FD0", Offset = "0x2BB79D0", VA = "0x182BB8FD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB92C0", Offset = "0x2BB7CC0", VA = "0x182BB92C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5AA0", Offset = "0x2BB44A0", VA = "0x182BB5AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6670", Offset = "0x2BB5070", VA = "0x182BB6670")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB57C0", Offset = "0x2BB41C0", VA = "0x182BB57C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9210", Offset = "0x2BB7C10", VA = "0x182BB9210")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7CC0", Offset = "0x2BB66C0", VA = "0x182BB7CC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8E80", Offset = "0x2BB7880", VA = "0x182BB8E80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7160", Offset = "0x2BB5B60", VA = "0x182BB7160")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5CD0", Offset = "0x2BB46D0", VA = "0x182BB5CD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB62D0", Offset = "0x2BB4CD0", VA = "0x182BB62D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5D90", Offset = "0x2BB4790", VA = "0x182BB5D90")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5BC0", Offset = "0x2BB45C0", VA = "0x182BB5BC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7850", Offset = "0x2BB6250", VA = "0x182BB7850")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB61B0", Offset = "0x2BB4BB0", VA = "0x182BB61B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB70A0", Offset = "0x2BB5AA0", VA = "0x182BB70A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB79D0", Offset = "0x2BB63D0", VA = "0x182BB79D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8F70", Offset = "0x2BB7970", VA = "0x182BB8F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8F10", Offset = "0x2BB7910", VA = "0x182BB8F10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5880", Offset = "0x2BB4280", VA = "0x182BB5880")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8290", Offset = "0x2BB6C90", VA = "0x182BB8290")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8850", Offset = "0x2BB7250", VA = "0x182BB8850")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6150", Offset = "0x2BB4B50", VA = "0x182BB6150")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7790", Offset = "0x2BB6190", VA = "0x182BB7790")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7550", Offset = "0x2BB5F50", VA = "0x182BB7550")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5D30", Offset = "0x2BB4730", VA = "0x182BB5D30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7610", Offset = "0x2BB6010", VA = "0x182BB7610")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6730", Offset = "0x2BB5130", VA = "0x182BB6730")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB77F0", Offset = "0x2BB61F0", VA = "0x182BB77F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7100", Offset = "0x2BB5B00", VA = "0x182BB7100")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7040", Offset = "0x2BB5A40", VA = "0x182BB7040")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB88B0", Offset = "0x2BB72B0", VA = "0x182BB88B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7670", Offset = "0x2BB6070", VA = "0x182BB7670")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB90F0", Offset = "0x2BB7AF0", VA = "0x182BB90F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5DF0", Offset = "0x2BB47F0", VA = "0x182BB5DF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7210", Offset = "0x2BB5C10", VA = "0x182BB7210")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB91B0", Offset = "0x2BB7BB0", VA = "0x182BB91B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5B60", Offset = "0x2BB4560", VA = "0x182BB5B60")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB95A0", Offset = "0x2BB7FA0", VA = "0x182BB95A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5990", Offset = "0x2BB4390", VA = "0x182BB5990")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB87F0", Offset = "0x2BB71F0", VA = "0x182BB87F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6FE0", Offset = "0x2BB59E0", VA = "0x182BB6FE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB83B0", Offset = "0x2BB6DB0", VA = "0x182BB83B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9030", Offset = "0x2BB7A30", VA = "0x182BB9030")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5550", Offset = "0x2BB3F50", VA = "0x182BB5550")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8E20", Offset = "0x2BB7820", VA = "0x182BB8E20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7D20", Offset = "0x2BB6720", VA = "0x182BB7D20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB78B0", Offset = "0x2BB62B0", VA = "0x182BB78B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6990", Offset = "0x2BB5390", VA = "0x182BB6990")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6CB0", Offset = "0x2BB56B0", VA = "0x182BB6CB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB76D0", Offset = "0x2BB60D0", VA = "0x182BB76D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9090", Offset = "0x2BB7A90", VA = "0x182BB9090")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9600", Offset = "0x2BB8000", VA = "0x182BB9600")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7B80", Offset = "0x2BB6580", VA = "0x182BB7B80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8110", Offset = "0x2BB6B10", VA = "0x182BB8110")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5E50", Offset = "0x2BB4850", VA = "0x182BB5E50")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB66D0", Offset = "0x2BB50D0", VA = "0x182BB66D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB54F0", Offset = "0x2BB3EF0", VA = "0x182BB54F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB65B0", Offset = "0x2BB4FB0", VA = "0x182BB65B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5F70", Offset = "0x2BB4970", VA = "0x182BB5F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB59F0", Offset = "0x2BB43F0", VA = "0x182BB59F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB55B0", Offset = "0x2BB3FB0", VA = "0x182BB55B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6210", Offset = "0x2BB4C10", VA = "0x182BB6210")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5490", Offset = "0x2BB3E90", VA = "0x182BB5490")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB82F0", Offset = "0x2BB6CF0", VA = "0x182BB82F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6790", Offset = "0x2BB5190", VA = "0x182BB6790")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9150", Offset = "0x2BB7B50", VA = "0x182BB9150")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8170", Offset = "0x2BB6B70", VA = "0x182BB8170")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5FD0", Offset = "0x2BB49D0", VA = "0x182BB5FD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9540", Offset = "0x2BB7F40", VA = "0x182BB9540")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB9660", Offset = "0x2BB8060", VA = "0x182BB9660")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB81D0", Offset = "0x2BB6BD0", VA = "0x182BB81D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6610", Offset = "0x2BB5010", VA = "0x182BB6610")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB5C20", Offset = "0x2BB4620", VA = "0x182BB5C20")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6ED0", Offset = "0x2BB58D0", VA = "0x182BB6ED0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB6930", Offset = "0x2BB5330", VA = "0x182BB6930")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7730", Offset = "0x2BB6130", VA = "0x182BB7730")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB68D0", Offset = "0x2BB52D0", VA = "0x182BB68D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB7A90", Offset = "0x2BB6490", VA = "0x182BB7A90")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BB8350", Offset = "0x2BB6D50", VA = "0x182BB8350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6AD0", Offset = "0x2BB54D0", VA = "0x182BB6AD0")]
			public static ZMFHVAWJYMI KBGMAVVFELG([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6A20", Offset = "0x2BB5420", VA = "0x182BB6A20")]
			public static ClassFactoryTypeParams JWGLMZDMIMJ(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BB69F0", Offset = "0x2BB53F0", VA = "0x182BB69F0")]
			public static ClassFactoryTypeParams JWGLMZDMIMJ([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8EE0", Offset = "0x2BB78E0", VA = "0x182BB8EE0")]
			public static ZMFHVAWJYMI VSIGLEEIJLE(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7B50", Offset = "0x2BB6550", VA = "0x182BB7B50")]
			public static ZMFHVAWJYMI QTNBKFWDLAD(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BB86C0", Offset = "0x2BB70C0", VA = "0x182BB86C0")]
			public static ZMFHVAWJYMI TSFOFKTRDOH([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8060", Offset = "0x2BB6A60", VA = "0x182BB8060")]
			public static BSJAKYMSOCV SDCWNCIEUQF(Id32<KOCJWPCQAPD> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB67F0", Offset = "0x2BB51F0", VA = "0x182BB67F0")]
			public static string JGWAEJFRHJY(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7D80", Offset = "0x2BB6780", VA = "0x182BB7D80")]
			private static BSJAKYMSOCV SDCWNCIEUQF(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6E60", Offset = "0x2BB5860", VA = "0x182BB6E60")]
			public static Id32<KOCJWPCQAPD>? LLCYOMAYFNW(BSJAKYMSOCV a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8910", Offset = "0x2BB7310", VA = "0x182BB8910")]
			public static CircuitTypeIdWrapper? UTHBIEWUWEL(BSJAKYMSOCV a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB97C0", Offset = "0x2BB81C0", VA = "0x182BB97C0")]
			static IABNZHBPDRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6F30", Offset = "0x2BB5930", VA = "0x182BB6F30")]
			[IteratorStateMachine(typeof(VIIIGVTVOCI))]
			private static IEnumerable<BSJAKYMSOCV> LRXTBEDUHZX(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BB58E0", Offset = "0x2BB42E0", VA = "0x182BB58E0")]
			[IteratorStateMachine(typeof(LLUVENKAVVE))]
			public static IEnumerable<BSJAKYMSOCV> BVZLMBIPPMY(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BB8410", Offset = "0x2BB6E10", VA = "0x182BB8410")]
			public static Variant TQCUKBHMHSZ(BSJAKYMSOCV a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7270", Offset = "0x2BB5C70", VA = "0x182BB7270")]
			public static Variant NZNJZHITGTS(BSJAKYMSOCV a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6380", Offset = "0x2BB4D80", VA = "0x182BB6380")]
			public static bool HLWECZYJICI(BSJAKYMSOCV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB64A0", Offset = "0x2BB4EA0", VA = "0x182BB64A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCD8C0", Offset = "0x2BCC2C0", VA = "0x182BCD8C0")]
		public static XCDRQSKUHKB BGVSXQNQAUM(this BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE9A0", Offset = "0x2BCD3A0", VA = "0x182BCE9A0")]
		public static BSJAKYMSOCV BHPYVATLUMF(this XCDRQSKUHKB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JOEGSLPDHWT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B8AD20", Offset = "0x3B89720", VA = "0x183B8AD20")]
		public static Dictionary<b, c> STTCQKHPIHH<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ZDDCJTAFOQA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD38F0", Offset = "0x2BD22F0", VA = "0x182BD38F0")]
		public static FRELYPKAFVB BGVSXQNQAUM([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD39F0", Offset = "0x2BD23F0", VA = "0x182BD39F0")]
		public static Guid BHPYVATLUMF(FRELYPKAFVB a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class UFLLHYFYVMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0EA0", Offset = "0x2BCF8A0", VA = "0x182BD0EA0")]
		public static CVCSGJSMCOP BGVSXQNQAUM([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0F30", Offset = "0x2BCF930", VA = "0x182BD0F30")]
		public static NamedType BHPYVATLUMF(this CVCSGJSMCOP a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class NNLUYJGKYPT
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D16AF0", Offset = "0x3D154F0", VA = "0x183D16AF0")]
		public static void NVUUDIUFLBX<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D16D50", Offset = "0x3D15750", VA = "0x183D16D50")]
		public static void NVUUDIUFLBX<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class VFBKTDPAVNS
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0F90", Offset = "0x2BCF990", VA = "0x182BD0F90")]
		public static AXWRZTCJDYL BGVSXQNQAUM([In] this Variant self, BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1190", Offset = "0x2BCFB90", VA = "0x182BD1190")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B79FD0", Offset = "0x2B789D0", VA = "0x182B79FD0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<OLTONIMFXQW> FQHIAUYLJUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B79FD0", Offset = "0x2B789D0", VA = "0x182B79FD0")]
			get
			{
				return default(Id128<OLTONIMFXQW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, BSJAKYMSOCV Type)> QYDZWZFCILR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IVKJHYXCUHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5670", Offset = "0x2BC4070", VA = "0x182BC5670")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5F80", Offset = "0x2BC4980", VA = "0x182BC5F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, BSJAKYMSOCV> FIPFYXYLEAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BC58C0", Offset = "0x2BC42C0", VA = "0x182BC58C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5A90", Offset = "0x2BC4490", VA = "0x182BC5A90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> CUWOXEXSYLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5ED0", Offset = "0x2BC48D0", VA = "0x182BC5ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BC6020", Offset = "0x2BC4A20", VA = "0x182BC6020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> TNVZOPXZOWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BC60D0", Offset = "0x2BC4AD0", VA = "0x182BC60D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BC6310", Offset = "0x2BC4D10", VA = "0x182BC6310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, BSJAKYMSOCV> JIEJGHQMATJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5810", Offset = "0x2BC4210", VA = "0x182BC5810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5C90", Offset = "0x2BC4690", VA = "0x182BC5C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MBVHRXOCQRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BC6270", Offset = "0x2BC4C70", VA = "0x182BC6270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5E30", Offset = "0x2BC4830", VA = "0x182BC5E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B235A0", Offset = "0x1B21FA0", VA = "0x181B235A0")]
		public void JJFBHXBWFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BC66D0", Offset = "0x2BC50D0", VA = "0x182BC66D0")]
		internal PDYFVPTGSHQ([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, BSJAKYMSOCV Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5BC0", Offset = "0x2BC45C0", VA = "0x182BC5BC0")]
		public static CircuitEventDefinitionFactoryStart GYMJYDCNRDR(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5B40", Offset = "0x2BC4540", VA = "0x182BC5B40")]
		public static CircuitEventDefinitionFactoryStart GYMJYDCNRDR(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5560", Offset = "0x2BC3F60", VA = "0x182BC5560")]
		public static PDYFVPTGSHQ AFWLAYXWKJP([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6490", Offset = "0x2BC4E90", VA = "0x182BC6490")]
		public static PDYFVPTGSHQ ZRJGOXIPFUD([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xEFDE70", Offset = "0xEFC870", VA = "0x180EFDE70")]
		public void EWCWNCAJKYV(Id128<OLTONIMFXQW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6430", Offset = "0x2BC4E30", VA = "0x182BC6430")]
		public void YOUVUKJBFIU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6180", Offset = "0x2BC4B80", VA = "0x182BC6180")]
		public void OKKJCWTGYLO(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5D40", Offset = "0x2BC4740", VA = "0x182BC5D40")]
		public void INIZWSHXSCT(int a, BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5970", Offset = "0x2BC4370", VA = "0x182BC5970")]
		public void GSAIDKBZXWF(string a, BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC63C0", Offset = "0x2BC4DC0", VA = "0x182BC63C0")]
		public void XHGLJVKQIKG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5710", Offset = "0x2BC4110", VA = "0x182BC5710")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB3B80", Offset = "0x2BB2580", VA = "0x182BB3B80")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB38E0", Offset = "0x2BB22E0", VA = "0x182BB38E0")]
		public CircuitEventDefinitionFactoryParams GOKOHWPRKIH(string a, BSJAKYMSOCV b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3A50", Offset = "0x2BB2450", VA = "0x182BB3A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB3850", Offset = "0x2BB2250", VA = "0x182BB3850")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, BSJAKYMSOCV Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3620", Offset = "0x2BB2020", VA = "0x182BB3620")]
		public CircuitEventDefinitionFactoryParams GOKOHWPRKIH(string a, BSJAKYMSOCV b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3750", Offset = "0x2BB2150", VA = "0x182BB3750")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<PDYFVPTGSHQ> ZGCDJMXYPOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1A40", Offset = "0x2BE0440", VA = "0x182BE1A40")]
		protected TGAZFOYDRZK(BSJAKYMSOCV a, params PDYFVPTGSHQ[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class PKNKEZEZYUI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF0D0", Offset = "0x2BDDAD0", VA = "0x182BDF0D0")]
		internal PKNKEZEZYUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class HKENRXGJGIF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9970", Offset = "0x2BD8370", VA = "0x182BD9970")]
		internal HKENRXGJGIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class VAXCTHLIAHS : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BE26C0", Offset = "0x2BE10C0", VA = "0x182BE26C0")]
		internal VAXCTHLIAHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class KKVJDSMMAZH : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBFF0", Offset = "0x2BDA9F0", VA = "0x182BDBFF0")]
		internal KKVJDSMMAZH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class GXFNQBZEAUO : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8700", Offset = "0x2BD7100", VA = "0x182BD8700")]
		internal GXFNQBZEAUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class DMTYVWHGXMG : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BD56F0", Offset = "0x2BD40F0", VA = "0x182BD56F0")]
		internal DMTYVWHGXMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class QIAPLJIXDKN : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF2B0", Offset = "0x2BDDCB0", VA = "0x182BDF2B0")]
		internal QIAPLJIXDKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ZQWFFTFUMHG : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4EA0", Offset = "0x2BE38A0", VA = "0x182BE4EA0")]
		internal ZQWFFTFUMHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class YWVQPASRCLY : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4900", Offset = "0x2BE3300", VA = "0x182BE4900")]
		internal YWVQPASRCLY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class CKBIXUAGZWK : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4ED0", Offset = "0x2BD38D0", VA = "0x182BD4ED0")]
		internal CKBIXUAGZWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class USSWNLLPEDI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2340", Offset = "0x2BE0D40", VA = "0x182BE2340")]
		internal USSWNLLPEDI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class TAYLTWOTLJQ : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1350", Offset = "0x2BDFD50", VA = "0x182BE1350")]
		internal TAYLTWOTLJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class HTUQJDWQIZI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9CB0", Offset = "0x2BD86B0", VA = "0x182BD9CB0")]
		internal HTUQJDWQIZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class JWWZAZFEPHI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB690", Offset = "0x2BDA090", VA = "0x182BDB690")]
		internal JWWZAZFEPHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class UJNNBSIBMCU : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1F80", Offset = "0x2BE0980", VA = "0x182BE1F80")]
		internal UJNNBSIBMCU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ZAWMOYMVORO : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4AE0", Offset = "0x2BE34E0", VA = "0x182BE4AE0")]
		internal ZAWMOYMVORO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class WNFOKMIOWWI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3300", Offset = "0x2BE1D00", VA = "0x182BE3300")]
		internal WNFOKMIOWWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class VIXLOJMIYQV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BE28A0", Offset = "0x2BE12A0", VA = "0x182BE28A0")]
		internal VIXLOJMIYQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class OMJJYFTRQDV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE1A0", Offset = "0x2BDCBA0", VA = "0x182BDE1A0")]
		internal OMJJYFTRQDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class EZUETILUTHR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5FF0", Offset = "0x2BD49F0", VA = "0x182BD5FF0")]
		internal EZUETILUTHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class BOWPOIEPXZX : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4210", Offset = "0x2BD2C10", VA = "0x182BD4210")]
		internal BOWPOIEPXZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class JKQHFLMEPKV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB3C0", Offset = "0x2BD9DC0", VA = "0x182BDB3C0")]
		internal JKQHFLMEPKV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class RAVMFCLPTVU : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE90", Offset = "0x2BDE890", VA = "0x182BDFE90")]
		internal RAVMFCLPTVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class AZEFSQPROXR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4030", Offset = "0x2BD2A30", VA = "0x182BD4030")]
		internal AZEFSQPROXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class KPCPHDULDRW : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC440", Offset = "0x2BDAE40", VA = "0x182BDC440")]
		internal KPCPHDULDRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class WBDEKEJVIEP : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE30B0", Offset = "0x2BE1AB0", VA = "0x182BE30B0")]
		internal WBDEKEJVIEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MBVQNBCPHDP : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDA10", Offset = "0x2BDC410", VA = "0x182BDDA10")]
		internal MBVQNBCPHDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LCQPXRTVDSD : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD5E0", Offset = "0x2BDBFE0", VA = "0x182BDD5E0")]
		internal LCQPXRTVDSD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TBHPYRJKBCS : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1530", Offset = "0x2BDFF30", VA = "0x182BE1530")]
		internal TBHPYRJKBCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class YHRLOHARVAL : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BE39F0", Offset = "0x2BE23F0", VA = "0x182BE39F0")]
		internal YHRLOHARVAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class VUTVTBLVPTI : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2CF0", Offset = "0x2BE16F0", VA = "0x182BE2CF0")]
		internal VUTVTBLVPTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class HRSXECGFUJW : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9AD0", Offset = "0x2BD84D0", VA = "0x182BD9AD0")]
		internal HRSXECGFUJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ROVMPICQIWY : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BE02C0", Offset = "0x2BDECC0", VA = "0x182BE02C0")]
		internal ROVMPICQIWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class TAHHLXHACBR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BE10F0", Offset = "0x2BDFAF0", VA = "0x182BE10F0")]
		internal TAHHLXHACBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class OYWFNDXHBUB : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE380", Offset = "0x2BDCD80", VA = "0x182BDE380")]
		internal OYWFNDXHBUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class EVCUIXVZWEX : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BD58D0", Offset = "0x2BD42D0", VA = "0x182BD58D0")]
		internal EVCUIXVZWEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class RPHVZJVDWUA : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BE04A0", Offset = "0x2BDEEA0", VA = "0x182BE04A0")]
		internal RPHVZJVDWUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class BUXAJIKFHAF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4470", Offset = "0x2BD2E70", VA = "0x182BD4470")]
		internal BUXAJIKFHAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class QUZLUWJXNLT : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF670", Offset = "0x2BDE070", VA = "0x182BDF670")]
		internal QUZLUWJXNLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class SNHCFABRTGC : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0D30", Offset = "0x2BDF730", VA = "0x182BE0D30")]
		internal SNHCFABRTGC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class IMVQPUOIHKS : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA770", Offset = "0x2BD9170", VA = "0x182BDA770")]
		internal IMVQPUOIHKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class ZAWNTDJNNDM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4CC0", Offset = "0x2BE36C0", VA = "0x182BE4CC0")]
		internal ZAWNTDJNNDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class SHBPLNBYVXL : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0B50", Offset = "0x2BDF550", VA = "0x182BE0B50")]
		internal SHBPLNBYVXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class LFYVLGAZNSV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD7C0", Offset = "0x2BDC1C0", VA = "0x182BDD7C0")]
		internal LFYVLGAZNSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class QQXIVBMELTM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF490", Offset = "0x2BDDE90", VA = "0x182BDF490")]
		internal QQXIVBMELTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CMKJLUQTORZ : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD54A0", Offset = "0x2BD3EA0", VA = "0x182BD54A0")]
		internal CMKJLUQTORZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class XPZCXHSYLTM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3630", Offset = "0x2BE2030", VA = "0x182BE3630")]
		internal XPZCXHSYLTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class PJFVNXRFEOF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEEF0", Offset = "0x2BDD8F0", VA = "0x182BDEEF0")]
		internal PJFVNXRFEOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class STWKBJFITON : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0F10", Offset = "0x2BDF910", VA = "0x182BE0F10")]
		internal STWKBJFITON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class URZCWMQWQOC : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2160", Offset = "0x2BE0B60", VA = "0x182BE2160")]
		internal URZCWMQWQOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class OIVUZTACFEM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDFC0", Offset = "0x2BDC9C0", VA = "0x182BDDFC0")]
		internal OIVUZTACFEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BYFEXTLHANR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BD46D0", Offset = "0x2BD30D0", VA = "0x182BD46D0")]
		internal BYFEXTLHANR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class HJXNQMVVPEM : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9790", Offset = "0x2BD8190", VA = "0x182BD9790")]
		internal HJXNQMVVPEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class AXPEQXIXRYB : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3E50", Offset = "0x2BD2850", VA = "0x182BD3E50")]
		internal AXPEQXIXRYB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class YBFLOYHLRZT : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3810", Offset = "0x2BE2210", VA = "0x182BE3810")]
		internal YBFLOYHLRZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class RFLVPTPRJYD : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE00E0", Offset = "0x2BDEAE0", VA = "0x182BE00E0")]
		internal RFLVPTPRJYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class AJPJDKLEDPD : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3C70", Offset = "0x2BD2670", VA = "0x182BD3C70")]
		internal AJPJDKLEDPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class LAHRAVDQSWE : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD400", Offset = "0x2BDBE00", VA = "0x182BDD400")]
		internal LAHRAVDQSWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class AGRKCBKJCZR : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3A90", Offset = "0x2BD2490", VA = "0x182BD3A90")]
		internal AGRKCBKJCZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class VWPEGDUAILV : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2ED0", Offset = "0x2BE18D0", VA = "0x182BE2ED0")]
		internal VWPEGDUAILV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class NXRZRNXFCLA : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDBF0", Offset = "0x2BDC5F0", VA = "0x182BDDBF0")]
		internal NXRZRNXFCLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class IRLXCVVYBLB : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA950", Offset = "0x2BD9350", VA = "0x182BDA950")]
		internal IRLXCVVYBLB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class ICCTPAAHWPE : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9F00", Offset = "0x2BD8900", VA = "0x182BD9F00")]
		internal ICCTPAAHWPE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class KDUSNDQJHWF : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB7E0", Offset = "0x2BDA1E0", VA = "0x182BDB7E0")]
		internal KDUSNDQJHWF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class KUGIOOZJDED : TGAZFOYDRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCAF0", Offset = "0x2BDB4F0", VA = "0x182BDCAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
		private NamedType(string name, BSJAKYMSOCV type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B10180", Offset = "0x2B0EB80", VA = "0x182B10180")]
		public static NamedType New(string name, BSJAKYMSOCV type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE00", Offset = "0x2BDC800", VA = "0x182BDDE00")]
		public static bool VPGVCSNEDTU([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE00", Offset = "0x2BDC800", VA = "0x182BDDE00", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE00", Offset = "0x2BDC800", VA = "0x182BDDE00")]
		public bool NFHEFKJNFIE([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDD50", Offset = "0x2BDC750", VA = "0x182BDDD50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE90", Offset = "0x2BDC890", VA = "0x182BDDE90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDF00", Offset = "0x2BDC900", VA = "0x182BDDF00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE50", Offset = "0x2BDC850", VA = "0x182BDDE50")]
		public string GZYHPCREKQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDF40", Offset = "0x2BDC940", VA = "0x182BDDF40")]
		public string ZHFBKANYPSC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDE00", Offset = "0x2BDC800", VA = "0x182BDDE00", Slot = "5")]
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
