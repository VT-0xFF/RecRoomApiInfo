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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x293D4C0", Offset = "0x293C6C0", VA = "0x18293D4C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x293AFC0", Offset = "0x293A1C0", VA = "0x18293AFC0", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class IDORJCCIGRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x293A470", Offset = "0x2939670", VA = "0x18293A470")]
		public static bool SDUNTVHZSQZ(this NRZUVTJIBNZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x293A580", Offset = "0x2939780", VA = "0x18293A580")]
		public static bool SDUNTVHZSQZ(this HMXDRHPONDM a)
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
			private readonly DLOXXYQFPRD _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
			public EVRequest(DLOXXYQFPRD staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class XMNUIBSACDG
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<QWBSJFGLWSL>, UGPZSCSDBVY> IICOJMJLBJD;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<QWBSJFGLWSL>>? BBMOGXVFWVX;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<QWBSJFGLWSL> VABACYANPSH;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<QWBSJFGLWSL> MSBVPIIOMMA;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<QWBSJFGLWSL> MPCIJVTRYGL;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<QWBSJFGLWSL> OBZKNZQGDCS;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<QWBSJFGLWSL> DNIDZVEQHYX;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<QWBSJFGLWSL> ISNOCIVMTTC;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<QWBSJFGLWSL> BFOVTWLHFJI;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<QWBSJFGLWSL> IVDEEBWEUWC;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<QWBSJFGLWSL> WUJAQQJBIPE;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<QWBSJFGLWSL> RNQLEMQKDNI;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<QWBSJFGLWSL> MZEVIRRVXAA;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<QWBSJFGLWSL> SDGYDEXGANC;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<QWBSJFGLWSL> QZOKJWUHGMJ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<QWBSJFGLWSL> UVQINZUEYIT;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<QWBSJFGLWSL> IMTVBEBKSED;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<QWBSJFGLWSL> VHKBDFKBZOU;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<QWBSJFGLWSL> HWMIYHCYHBV;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<QWBSJFGLWSL> YAFUSXKAEXL;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<QWBSJFGLWSL> PQHTHVULTNQ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<QWBSJFGLWSL> IMZOHVHYVZD;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<QWBSJFGLWSL> QAOYOANDHOY;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<QWBSJFGLWSL> CIPNPGHIOUJ;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<QWBSJFGLWSL> ZCXFEULWJHN;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<QWBSJFGLWSL> XQKWJHFRUFK;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<QWBSJFGLWSL> CUXRCXZXOSQ;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<QWBSJFGLWSL> QXNXJPCCKZB;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<QWBSJFGLWSL> RZNTOTJAUBA;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<QWBSJFGLWSL> HJBZEDDJFNJ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<QWBSJFGLWSL> LGWYSUAKZWH;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<QWBSJFGLWSL> LLZHEDSWVIB;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<QWBSJFGLWSL> ROCBBRIOIAH;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<QWBSJFGLWSL> AHJMREWZHXE;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<QWBSJFGLWSL> KSKXJQBVSFH;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<QWBSJFGLWSL> ILCAZGBSWRB;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<QWBSJFGLWSL> CWZGXSIBAGX;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<QWBSJFGLWSL> KDPZAMLKQQQ;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<QWBSJFGLWSL> FXFHEWHGFMJ;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<QWBSJFGLWSL> AGRLSVAPAZA;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<QWBSJFGLWSL> GIXJPQYZICG;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<QWBSJFGLWSL> LAFHLRZNBAS;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<QWBSJFGLWSL> LJFVYFOWVJT;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<QWBSJFGLWSL> WRJRLNQEUGN;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<QWBSJFGLWSL> ZRFTCSKPEZU;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<QWBSJFGLWSL> SGKACITTOFT;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<QWBSJFGLWSL> WULGETQHSIZ;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<QWBSJFGLWSL> YCKSHWSXLYH;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<QWBSJFGLWSL> IHBJEAWJVJI;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<QWBSJFGLWSL> NFERGTUGLGQ;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<QWBSJFGLWSL> YNHNTZYBAES;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<QWBSJFGLWSL> WGAVHUBUZOL;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<QWBSJFGLWSL> HEGBPWRJSFJ;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<QWBSJFGLWSL> EJNOMZKJBRS;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<QWBSJFGLWSL> QAFECCMEEBB;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<QWBSJFGLWSL> ZAHBUVOBAIZ;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<QWBSJFGLWSL> IRDCPODTUFO;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<QWBSJFGLWSL> QYSUZHWYFPI;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<QWBSJFGLWSL> TGMSPYVFGQS;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<QWBSJFGLWSL> WJVUKXGJUGK;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<QWBSJFGLWSL> IYROLUXAEYJ;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<QWBSJFGLWSL> YWFTPPQDYOA;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<QWBSJFGLWSL> VLAZXWRHNLY;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<QWBSJFGLWSL> VJVVSDCPBAC;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<QWBSJFGLWSL> PNHORXAVOIN;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<QWBSJFGLWSL> XJWEWUBCHTN;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<QWBSJFGLWSL> KWEXNZFLUJE;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<QWBSJFGLWSL> GLYGIVRGPTD;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<QWBSJFGLWSL> VNHOSFXALTU;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<QWBSJFGLWSL> ISFJKQRDICI;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<QWBSJFGLWSL> UDJEJKHQIOO;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<QWBSJFGLWSL>, UGPZSCSDBVY> TPBCTVZWARY
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x29539A0", Offset = "0x2952BA0", VA = "0x1829539A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2953580", Offset = "0x2952780", VA = "0x182953580")]
			public static UGPZSCSDBVY BYPNFFUBAMO(Id32<QWBSJFGLWSL> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2953910", Offset = "0x2952B10", VA = "0x182953910")]
			public static bool RJKDTXAQNMP(Id32<QWBSJFGLWSL> id, [Out] UGPZSCSDBVY a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2953600", Offset = "0x2952800", VA = "0x182953600")]
			public static NRZUVTJIBNZ IGMRDBACDXR(Id32<QWBSJFGLWSL> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x29536B0", Offset = "0x29528B0", VA = "0x1829536B0")]
			private static Id32<QWBSJFGLWSL> JUFURAKXVZP(UGPZSCSDBVY a, Id32<QWBSJFGLWSL> id)
			{
				return default(Id32<QWBSJFGLWSL>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2953740", Offset = "0x2952940", VA = "0x182953740")]
			private static void KBNYWFCVTQN(Id32<QWBSJFGLWSL> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class ROBUNCTRKOH
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<VUAUFXZXUVR, NRZUVTJIBNZ?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
				private TypeRegistryFactory([In] IdUnsafeList<VUAUFXZXUVR, NRZUVTJIBNZ?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2950990", Offset = "0x294FB90", VA = "0x182950990")]
				public static TypeRegistryFactory NEOQDMXJNFD()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x29509F0", Offset = "0x294FBF0", VA = "0x1829509F0")]
				public (ReadOnlyIdArray<VUAUFXZXUVR, NRZUVTJIBNZ>, IReadOnlyDictionary<NRZUVTJIBNZ, Id32<VUAUFXZXUVR>>) QIOJAOPXSKN()
				{
					return default((ReadOnlyIdArray<VUAUFXZXUVR, NRZUVTJIBNZ>, IReadOnlyDictionary<NRZUVTJIBNZ, Id32<VUAUFXZXUVR>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x29507C0", Offset = "0x294F9C0", VA = "0x1829507C0")]
				public Id32<VUAUFXZXUVR> ENJGLJDFXMD(int a, NRZUVTJIBNZ b)
				{
					return default(Id32<VUAUFXZXUVR>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2950940", Offset = "0x294FB40", VA = "0x182950940")]
				public Id32<VUAUFXZXUVR> Initialize(int id, OJOXJTZCBAY type, OJOXJTZCBAY factoryType)
				{
					return default(Id32<VUAUFXZXUVR>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class ASNHCXZEPAK
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<VUAUFXZXUVR> JOFPEVIWCJD
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2937180", Offset = "0x2936380", VA = "0x182937180")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2936FC0", Offset = "0x29361C0", VA = "0x182936FC0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<VUAUFXZXUVR> DKFMCTSBEFT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2936F40", Offset = "0x2936140", VA = "0x182936F40")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2936F80", Offset = "0x2936180", VA = "0x182936F80")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<VUAUFXZXUVR> CJIMUPECOSK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2937080", Offset = "0x2936280", VA = "0x182937080")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x29370C0", Offset = "0x29362C0", VA = "0x1829370C0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<VUAUFXZXUVR> UGYYYKWWZJS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2937100", Offset = "0x2936300", VA = "0x182937100")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2937000", Offset = "0x2936200", VA = "0x182937000")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<VUAUFXZXUVR> HZTWWMKDDTS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2936EC0", Offset = "0x29360C0", VA = "0x182936EC0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2936F00", Offset = "0x2936100", VA = "0x182936F00")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<VUAUFXZXUVR> MMBBSXKPBTP
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2937040", Offset = "0x2936240", VA = "0x182937040")]
					[CompilerGenerated]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2937140", Offset = "0x2936340", VA = "0x182937140")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class KCROCIWCTBG : IEnumerable<NRZUVTJIBNZ>, IEnumerable, IEnumerator<NRZUVTJIBNZ>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int HDIOWKWRMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private NRZUVTJIBNZ HVLGGEUBMPZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int SQEAAJZHTMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool SFAQFPCVJHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool UTMRVCRZLSW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion RNOCECDCZKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion BEHGXCCRNEW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool XHZJYFXDYUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool THGYEBDTIWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool ZCKWGAAPCXQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool YTQHJOBOZVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool THZXLTSGQJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool SGOOTHUVEIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool UYFZZLTLVEA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool UMTNWEKKYNF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<NRZUVTJIBNZ> XORIMGFAPUY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private NRZUVTJIBNZ DSNYXXEMENT;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private NRZUVTJIBNZ AAHSVVCAIJW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object CVJXXTOQWTE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
				[DebuggerHidden]
				public KCROCIWCTBG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x293A9F0", Offset = "0x2939BF0", VA = "0x18293A9F0", Slot = "7")]
				[DebuggerHidden]
				private void JZSTYLGWFSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x293AB40", Offset = "0x2939D40", VA = "0x18293AB40", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x293AF30", Offset = "0x293A130", VA = "0x18293AF30")]
				private void RKOKQQOFJWR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x293AF80", Offset = "0x293A180", VA = "0x18293AF80", Slot = "10")]
				[DebuggerHidden]
				private void ZJSIHLTIANO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x293AA80", Offset = "0x2939C80", VA = "0x18293AA80", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<NRZUVTJIBNZ> VKQSPOQSEAD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x293AA80", Offset = "0x2939C80", VA = "0x18293AA80", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KRQKAOMZCCF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class MLIIMZGGLGW : IEnumerable<NRZUVTJIBNZ>, IEnumerable, IEnumerator<NRZUVTJIBNZ>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int HDIOWKWRMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private NRZUVTJIBNZ HVLGGEUBMPZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int SQEAAJZHTMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion RNOCECDCZKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion BEHGXCCRNEW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool ZCKWGAAPCXQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool YTQHJOBOZVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool XHZJYFXDYUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool THGYEBDTIWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool XUHKOCFMUAY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool SPSTUAAKALD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool THZXLTSGQJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool SGOOTHUVEIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool ROIWQMOVTOQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool FHJLOIJCCIE;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private NRZUVTJIBNZ AAHSVVCAIJW
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object CVJXXTOQWTE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
				[DebuggerHidden]
				public MLIIMZGGLGW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
				[DebuggerHidden]
				private void JZSTYLGWFSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x293B0F0", Offset = "0x293A2F0", VA = "0x18293B0F0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x293D000", Offset = "0x293C200", VA = "0x18293D000", Slot = "10")]
				[DebuggerHidden]
				private void ZJSIHLTIANO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x293B040", Offset = "0x293A240", VA = "0x18293B040", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<NRZUVTJIBNZ> VKQSPOQSEAD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x293B040", Offset = "0x293A240", VA = "0x18293B040", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KRQKAOMZCCF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class DWESOQYBXCF : IEnumerable<Id32<VUAUFXZXUVR>>, IEnumerable, IEnumerator<Id32<VUAUFXZXUVR>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int HDIOWKWRMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<VUAUFXZXUVR> HVLGGEUBMPZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int SQEAAJZHTMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion RNOCECDCZKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion BEHGXCCRNEW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool XHZJYFXDYUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool THGYEBDTIWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool ZCKWGAAPCXQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool YTQHJOBOZVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool THZXLTSGQJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool SGOOTHUVEIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool UYFZZLTLVEA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool UMTNWEKKYNF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<NRZUVTJIBNZ> XORIMGFAPUY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<OJOXJTZCBAY> XPHDEAMSSCZ;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<VUAUFXZXUVR> IZCDFERYOWD
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xB82A80", Offset = "0xB81C80", VA = "0x180B82A80", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<VUAUFXZXUVR>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object CVJXXTOQWTE
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2939A40", Offset = "0x2938C40", VA = "0x182939A40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x135A0D0", Offset = "0x13592D0", VA = "0x18135A0D0")]
				[DebuggerHidden]
				public DWESOQYBXCF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2939A90", Offset = "0x2938C90", VA = "0x182939A90", Slot = "7")]
				[DebuggerHidden]
				private void JZSTYLGWFSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2939C90", Offset = "0x2938E90", VA = "0x182939C90", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x293A1E0", Offset = "0x29393E0", VA = "0x18293A1E0")]
				private void RKOKQQOFJWR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x293A190", Offset = "0x2939390", VA = "0x18293A190")]
				private void RJYPYWGNHOQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x293A230", Offset = "0x2939430", VA = "0x18293A230", Slot = "10")]
				[DebuggerHidden]
				private void ZJSIHLTIANO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2939BE0", Offset = "0x2938DE0", VA = "0x182939BE0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<VUAUFXZXUVR>> ZBCZMPEODYY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2939BE0", Offset = "0x2938DE0", VA = "0x182939BE0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KRQKAOMZCCF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log JXFMMOBINLM;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<VUAUFXZXUVR, NRZUVTJIBNZ?> ZTCYFOXKBKI;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<NRZUVTJIBNZ, Id32<VUAUFXZXUVR>> SPYRLXSYKFO;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly HMXDRHPONDM RFASNFQAPVT;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly HMXDRHPONDM KMCNGLDYHOJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<NRZUVTJIBNZ> UPLXAAISZTV;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<NRZUVTJIBNZ> CDTMBRKYVHE;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet XULFRQIHEDJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet JXDFHSPCZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet FFDLKWBCBTT
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xBDF4C0", Offset = "0xBDE6C0", VA = "0x180BDF4C0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static NRZUVTJIBNZ JOFPEVIWCJD
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x29490E0", Offset = "0x29482E0", VA = "0x1829490E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static NRZUVTJIBNZ DKFMCTSBEFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2946B30", Offset = "0x2945D30", VA = "0x182946B30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static NRZUVTJIBNZ CJIMUPECOSK
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x29488A0", Offset = "0x2947AA0", VA = "0x1829488A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static NRZUVTJIBNZ UGYYYKWWZJS
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2948B60", Offset = "0x2947D60", VA = "0x182948B60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static NRZUVTJIBNZ MLRHRXGDWUG
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x29492B0", Offset = "0x29484B0", VA = "0x1829492B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static NRZUVTJIBNZ CAZVSZUAAWZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2948F60", Offset = "0x2948160", VA = "0x182948F60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static NRZUVTJIBNZ HXDPVNQRMWA
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x29473C0", Offset = "0x29465C0", VA = "0x1829473C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static NRZUVTJIBNZ HZTWWMKDDTS
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2945F00", Offset = "0x2945100", VA = "0x182945F00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static OJOXJTZCBAY WLXGDGGYPFS
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2947E30", Offset = "0x2947030", VA = "0x182947E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static OJOXJTZCBAY KCYQTWFMSXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x29487B0", Offset = "0x29479B0", VA = "0x1829487B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static OJOXJTZCBAY FYLIAZRGIKM
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2949090", Offset = "0x2948290", VA = "0x182949090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static OJOXJTZCBAY KQGTWGEXKFQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2947960", Offset = "0x2946B60", VA = "0x182947960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static OJOXJTZCBAY BVEDKNRFSMS
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2948850", Offset = "0x2947A50", VA = "0x182948850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static OJOXJTZCBAY NLOHRARZMPX
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2947A00", Offset = "0x2946C00", VA = "0x182947A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static OJOXJTZCBAY POJDVGKCAKV
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2946950", Offset = "0x2945B50", VA = "0x182946950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static OJOXJTZCBAY UBHJRSRTOPL
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2949210", Offset = "0x2948410", VA = "0x182949210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static OJOXJTZCBAY VTUITUSASKI
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2947FC0", Offset = "0x29471C0", VA = "0x182947FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static OJOXJTZCBAY MGJFTOHFYWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2946E50", Offset = "0x2946050", VA = "0x182946E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static OJOXJTZCBAY VMSFZLMSDMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2945EB0", Offset = "0x29450B0", VA = "0x182945EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static OJOXJTZCBAY ZFIEXHVTGRX
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2949170", Offset = "0x2948370", VA = "0x182949170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static OJOXJTZCBAY MMHUNORWFBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2946EA0", Offset = "0x29460A0", VA = "0x182946EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static OJOXJTZCBAY ODDDTWQXOSF
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2946080", Offset = "0x2945280", VA = "0x182946080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static OJOXJTZCBAY HHODOZFLFWM
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x29483F0", Offset = "0x29475F0", VA = "0x1829483F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static OJOXJTZCBAY WZSXANVQMRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2947AA0", Offset = "0x2946CA0", VA = "0x182947AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static OJOXJTZCBAY CKYYZWYYEJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2948F10", Offset = "0x2948110", VA = "0x182948F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static OJOXJTZCBAY TQUGSCLGKKX
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2947C20", Offset = "0x2946E20", VA = "0x182947C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static OJOXJTZCBAY APWGQULHMYJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2948980", Offset = "0x2947B80", VA = "0x182948980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static OJOXJTZCBAY PDQSOPOAVPH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2946E00", Offset = "0x2946000", VA = "0x182946E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static OJOXJTZCBAY JBGENEUPCZC
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2949040", Offset = "0x2948240", VA = "0x182949040")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static OJOXJTZCBAY LKNHZGPYGEV
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x29469F0", Offset = "0x2945BF0", VA = "0x1829469F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static OJOXJTZCBAY QZGYRVZEVQH
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2946360", Offset = "0x2945560", VA = "0x182946360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static OJOXJTZCBAY CLHPIBYNRVD
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2949840", Offset = "0x2948A40", VA = "0x182949840")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static OJOXJTZCBAY DBPTZUAANIF
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2948190", Offset = "0x2947390", VA = "0x182948190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static OJOXJTZCBAY HUPVKGYSQKM
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x29493E0", Offset = "0x29485E0", VA = "0x1829493E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static OJOXJTZCBAY MXCEEGKEURP
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2949700", Offset = "0x2948900", VA = "0x182949700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static OJOXJTZCBAY AYJKDJHSYYL
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2946C10", Offset = "0x2945E10", VA = "0x182946C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static OJOXJTZCBAY AUILHUHZDSX
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2946A40", Offset = "0x2945C40", VA = "0x182946A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static OJOXJTZCBAY NFVQCTUJGNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2946A90", Offset = "0x2945C90", VA = "0x182946A90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static OJOXJTZCBAY BXXJBSANPHY
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2945D70", Offset = "0x2944F70", VA = "0x182945D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static OJOXJTZCBAY KIBQULIETVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x29489D0", Offset = "0x2947BD0", VA = "0x1829489D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static OJOXJTZCBAY CGRVSXYGPKQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2946120", Offset = "0x2945320", VA = "0x182946120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static OJOXJTZCBAY RAGBPSXUZBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2949660", Offset = "0x2948860", VA = "0x182949660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static OJOXJTZCBAY TAMITGWDBLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x29475E0", Offset = "0x29467E0", VA = "0x1829475E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static OJOXJTZCBAY EQSTRYQXVHS
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2949340", Offset = "0x2948540", VA = "0x182949340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static OJOXJTZCBAY VWSHQFQAPJU
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2946270", Offset = "0x2945470", VA = "0x182946270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static OJOXJTZCBAY JURJABYPSVT
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x29481E0", Offset = "0x29473E0", VA = "0x1829481E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static OJOXJTZCBAY AOBHQHBMESF
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x29476D0", Offset = "0x29468D0", VA = "0x1829476D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static OJOXJTZCBAY PAPGQPMFTOQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2946470", Offset = "0x2945670", VA = "0x182946470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static OJOXJTZCBAY DWZTJESEXLQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2946AE0", Offset = "0x2945CE0", VA = "0x182946AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static OJOXJTZCBAY SFHRBTSRLPK
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2945D20", Offset = "0x2944F20", VA = "0x182945D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static OJOXJTZCBAY EYHCHHPSQGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2947F70", Offset = "0x2947170", VA = "0x182947F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static OJOXJTZCBAY NQOLZXTCUCT
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2947680", Offset = "0x2946880", VA = "0x182947680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static OJOXJTZCBAY ICMTNLIWTLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2948280", Offset = "0x2947480", VA = "0x182948280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static OJOXJTZCBAY LUDFEBSCHUQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2946F40", Offset = "0x2946140", VA = "0x182946F40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static OJOXJTZCBAY WOOFAHIRKFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x29474A0", Offset = "0x29466A0", VA = "0x1829474A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static OJOXJTZCBAY AHMWTXAVOKX
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x29477C0", Offset = "0x29469C0", VA = "0x1829477C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static OJOXJTZCBAY AJHGBOGMXIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2947CC0", Offset = "0x2946EC0", VA = "0x182947CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static OJOXJTZCBAY ESWYAHUQVHS
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2949890", Offset = "0x2948A90", VA = "0x182949890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static OJOXJTZCBAY PLGBIZWRAWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2946510", Offset = "0x2945710", VA = "0x182946510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static OJOXJTZCBAY UBQTEVBLZNI
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2946DB0", Offset = "0x2945FB0", VA = "0x182946DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static OJOXJTZCBAY RBNZXTXGTRX
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x29479B0", Offset = "0x2946BB0", VA = "0x1829479B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static OJOXJTZCBAY EDLPIULKMVO
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2948320", Offset = "0x2947520", VA = "0x182948320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static OJOXJTZCBAY DELLDELVJGV
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2948730", Offset = "0x2947930", VA = "0x182948730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static OJOXJTZCBAY OMPEGAEQKLL
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2949260", Offset = "0x2948460", VA = "0x182949260")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static OJOXJTZCBAY JACLTYNCLLT
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2948B10", Offset = "0x2947D10", VA = "0x182948B10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static OJOXJTZCBAY CUJIJEWBSZR
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2946420", Offset = "0x2945620", VA = "0x182946420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static OJOXJTZCBAY SHOHTYAEEXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x29494D0", Offset = "0x29486D0", VA = "0x1829494D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static OJOXJTZCBAY IBFLJRFSRDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2947A50", Offset = "0x2946C50", VA = "0x182947A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static OJOXJTZCBAY FIBSBNKNODE
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2946F90", Offset = "0x2946190", VA = "0x182946F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static OJOXJTZCBAY OWLALQGZPGS
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2945E60", Offset = "0x2945060", VA = "0x182945E60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static OJOXJTZCBAY YECJGMCELAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2947D60", Offset = "0x2946F60", VA = "0x182947D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static OJOXJTZCBAY AOWCHVZFRYM
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2945DC0", Offset = "0x2944FC0", VA = "0x182945DC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static OJOXJTZCBAY TQHGADZXFDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2948A20", Offset = "0x2947C20", VA = "0x182948A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static OJOXJTZCBAY SOZCODLETBR
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2947F20", Offset = "0x2947120", VA = "0x182947F20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static OJOXJTZCBAY YMUSTQQVVYT
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x29474F0", Offset = "0x29466F0", VA = "0x1829474F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static OJOXJTZCBAY TVFGQCLJRMH
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x29478C0", Offset = "0x2946AC0", VA = "0x1829478C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static OJOXJTZCBAY RDKRHFNIRDU
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2947370", Offset = "0x2946570", VA = "0x182947370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static OJOXJTZCBAY UZGBXQFZSOG
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x29498E0", Offset = "0x2948AE0", VA = "0x1829498E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static OJOXJTZCBAY RJEEBPVASJU
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2947720", Offset = "0x2946920", VA = "0x182947720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static OJOXJTZCBAY SSFGUGUTAWT
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2945CD0", Offset = "0x2944ED0", VA = "0x182945CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static OJOXJTZCBAY LRDNKNRTPKO
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2949480", Offset = "0x2948680", VA = "0x182949480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static OJOXJTZCBAY UFRXWMLVMOW
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2948FF0", Offset = "0x29481F0", VA = "0x182948FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static OJOXJTZCBAY AVWSAPQQBXJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x29462C0", Offset = "0x29454C0", VA = "0x1829462C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static OJOXJTZCBAY VJLUMMRBRCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x29469A0", Offset = "0x2945BA0", VA = "0x1829469A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static OJOXJTZCBAY UFWOFYQWWGE
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2948230", Offset = "0x2947430", VA = "0x182948230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static OJOXJTZCBAY NQLNRZRKOLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2947540", Offset = "0x2946740", VA = "0x182947540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static OJOXJTZCBAY HIVOXCOAESV
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2947450", Offset = "0x2946650", VA = "0x182947450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static OJOXJTZCBAY IXRNQJQMLJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x29480F0", Offset = "0x29472F0", VA = "0x1829480F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static OJOXJTZCBAY HQWQXMNOQHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2947770", Offset = "0x2946970", VA = "0x182947770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static OJOXJTZCBAY IXTYXJJKFSP
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2946C60", Offset = "0x2945E60", VA = "0x182946C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static OJOXJTZCBAY NQCWIQKHPSY
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2945C80", Offset = "0x2944E80", VA = "0x182945C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static OJOXJTZCBAY NQBHTETXFMZ
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2946CB0", Offset = "0x2945EB0", VA = "0x182946CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static OJOXJTZCBAY CIDTUYTMMJH
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x29495C0", Offset = "0x29487C0", VA = "0x1829495C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static OJOXJTZCBAY CEXXQYEWOFL
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2949930", Offset = "0x2948B30", VA = "0x182949930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static OJOXJTZCBAY YEUXODTVJOZ
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2947ED0", Offset = "0x29470D0", VA = "0x182947ED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static OJOXJTZCBAY DZOJEHMJXTT
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2946030", Offset = "0x2945230", VA = "0x182946030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static OJOXJTZCBAY WCYZSFHZLMU
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2946310", Offset = "0x2945510", VA = "0x182946310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static OJOXJTZCBAY NKDEXBKPZUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2947C70", Offset = "0x2946E70", VA = "0x182947C70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static OJOXJTZCBAY USFPFQWKTIS
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2948140", Offset = "0x2947340", VA = "0x182948140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static OJOXJTZCBAY ATGNUUVXNOX
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x29464C0", Offset = "0x29456C0", VA = "0x1829464C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static OJOXJTZCBAY USGUOSBBIRY
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2945F90", Offset = "0x2945190", VA = "0x182945F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static OJOXJTZCBAY IUANJXNHUSH
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x29491C0", Offset = "0x29483C0", VA = "0x1829491C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static OJOXJTZCBAY WDWNPLSFFNC
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2949390", Offset = "0x2948590", VA = "0x182949390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static OJOXJTZCBAY GHOQZBHURJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x29460D0", Offset = "0x29452D0", VA = "0x1829460D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static OJOXJTZCBAY CVJOZXQWZWJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2948930", Offset = "0x2947B30", VA = "0x182948930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static OJOXJTZCBAY QERRYVLZCJW
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x29482D0", Offset = "0x29474D0", VA = "0x1829482D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static OJOXJTZCBAY PMVJTOJDNZD
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x29496B0", Offset = "0x29488B0", VA = "0x1829496B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static OJOXJTZCBAY ABBGMIHNMLH
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2947590", Offset = "0x2946790", VA = "0x182947590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static OJOXJTZCBAY FQSSBQUUJCN
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2946220", Offset = "0x2945420", VA = "0x182946220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static OJOXJTZCBAY OCGUFUKYPBI
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2949610", Offset = "0x2948810", VA = "0x182949610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static OJOXJTZCBAY SBPYQXHPZVH
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2949520", Offset = "0x2948720", VA = "0x182949520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static OJOXJTZCBAY IZGNXQWDGLV
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2948370", Offset = "0x2947570", VA = "0x182948370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static OJOXJTZCBAY ICSIDQKIEMS
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2948BF0", Offset = "0x2947DF0", VA = "0x182948BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static OJOXJTZCBAY LBECAMDUPED
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2948A70", Offset = "0x2947C70", VA = "0x182948A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static OJOXJTZCBAY JPSMARXYARE
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2948AC0", Offset = "0x2947CC0", VA = "0x182948AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static OJOXJTZCBAY OLGTKBQDHYZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2945E10", Offset = "0x2945010", VA = "0x182945E10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static OJOXJTZCBAY CXYSFNNCYXJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2949430", Offset = "0x2948630", VA = "0x182949430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static OJOXJTZCBAY EIQAZBUGFSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2946BC0", Offset = "0x2945DC0", VA = "0x182946BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static OJOXJTZCBAY DGZOLYKUJBO
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2947D10", Offset = "0x2946F10", VA = "0x182947D10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static OJOXJTZCBAY OKPPMEZXOLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2946EF0", Offset = "0x29460F0", VA = "0x182946EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static OJOXJTZCBAY OOTGJCOMGOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2948440", Offset = "0x2947640", VA = "0x182948440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static OJOXJTZCBAY JUMWQDTVTBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2947630", Offset = "0x2946830", VA = "0x182947630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static OJOXJTZCBAY KMMMANUXKQJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2948800", Offset = "0x2947A00", VA = "0x182948800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static OJOXJTZCBAY JXKJSVPJNBB
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2949570", Offset = "0x2948770", VA = "0x182949570")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static OJOXJTZCBAY AVXDKLSPUUB
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2945FE0", Offset = "0x29451E0", VA = "0x182945FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static OJOXJTZCBAY CAGXMCOOXDJ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2947910", Offset = "0x2946B10", VA = "0x182947910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static OJOXJTZCBAY ZAOZRRPVVPS
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2947E80", Offset = "0x2947080", VA = "0x182947E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2949750", Offset = "0x2948950", VA = "0x182949750")]
			public static HMXDRHPONDM YRJVNOGLMLY([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2948040", Offset = "0x2947240", VA = "0x182948040")]
			public static ClassFactoryTypeParams PNFOCAOTYRF(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2948010", Offset = "0x2947210", VA = "0x182948010")]
			public static ClassFactoryTypeParams PNFOCAOTYRF([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2948780", Offset = "0x2947980", VA = "0x182948780")]
			public static HMXDRHPONDM SOXNVVKZFAA(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x29483C0", Offset = "0x29475C0", VA = "0x1829483C0")]
			public static HMXDRHPONDM RKNYGVMCSRX(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2947AF0", Offset = "0x2946CF0", VA = "0x182947AF0")]
			public static HMXDRHPONDM MMBBSXKPBTP([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x29472C0", Offset = "0x29464C0", VA = "0x1829472C0")]
			public static NRZUVTJIBNZ IGMRDBACDXR(Id32<VUAUFXZXUVR> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2946560", Offset = "0x2945760", VA = "0x182946560")]
			public static string ETHOVWHQVHO(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2946FE0", Offset = "0x29461E0", VA = "0x182946FE0")]
			private static NRZUVTJIBNZ IGMRDBACDXR(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x29463B0", Offset = "0x29455B0", VA = "0x1829463B0")]
			public static Id32<VUAUFXZXUVR>? DQSQNMAJHYS(NRZUVTJIBNZ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x29465E0", Offset = "0x29457E0", VA = "0x1829465E0")]
			public static CircuitTypeIdWrapper? EZNGMJFSBAZ(NRZUVTJIBNZ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2949980", Offset = "0x2948B80", VA = "0x182949980")]
			static ROBUNCTRKOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2947810", Offset = "0x2946A10", VA = "0x182947810")]
			[IteratorStateMachine(typeof(MLIIMZGGLGW))]
			private static IEnumerable<NRZUVTJIBNZ> LENNPLWCQTV(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2946170", Offset = "0x2945370", VA = "0x182946170")]
			[IteratorStateMachine(typeof(KCROCIWCTBG))]
			public static IEnumerable<NRZUVTJIBNZ> DAYUCFBEAWS(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2948490", Offset = "0x2947690", VA = "0x182948490")]
			public static Variant RYAYURLWGMH(NRZUVTJIBNZ a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2948C40", Offset = "0x2947E40", VA = "0x182948C40")]
			public static Variant VHUMCODONBM(NRZUVTJIBNZ a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2947DB0", Offset = "0x2946FB0", VA = "0x182947DB0")]
			public static bool OQWCOTPKQZY(NRZUVTJIBNZ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2946D00", Offset = "0x2945F00", VA = "0x182946D00")]
			[IteratorStateMachine(typeof(DWESOQYBXCF))]
			public static IEnumerable<Id32<VUAUFXZXUVR>> GJADHYHWBBC(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class UVLGTKNEPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2951D80", Offset = "0x2950F80", VA = "0x182951D80")]
		public static ONSAKPBMGPZ JNXWDCMOQDE(this NRZUVTJIBNZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2951280", Offset = "0x2950480", VA = "0x182951280")]
		public static NRZUVTJIBNZ EEHEZYYMZRF(this ONSAKPBMGPZ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class VTQWYVVYIQF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C23C10", Offset = "0x3C22E10", VA = "0x183C23C10")]
		public static Dictionary<b, c> DIEMRHUZFAP<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HJCADFOZUXA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x293A370", Offset = "0x2939570", VA = "0x18293A370")]
		public static XRPUNPRVPGB JNXWDCMOQDE([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x293A2D0", Offset = "0x29394D0", VA = "0x18293A2D0")]
		public static Guid EEHEZYYMZRF(XRPUNPRVPGB a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class ZGAKRIBYFPU
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2956940", Offset = "0x2955B40", VA = "0x182956940")]
		public static SUQYHVZQVIN JNXWDCMOQDE([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x29568E0", Offset = "0x2955AE0", VA = "0x1829568E0")]
		public static NamedType EEHEZYYMZRF(this SUQYHVZQVIN a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BEXZEITUDBV
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3407500", Offset = "0x3406700", VA = "0x183407500")]
		public static void TQPORIAVBDR<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3407760", Offset = "0x3406960", VA = "0x183407760")]
		public static void TQPORIAVBDR<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class PJOHMMZIJPQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x293D690", Offset = "0x293C890", VA = "0x18293D690")]
		public static ZUQMZCXWLQB JNXWDCMOQDE([In] this Variant self, NRZUVTJIBNZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x293D540", Offset = "0x293C740", VA = "0x18293D540")]
		public static Variant EEHEZYYMZRF(this ZUQMZCXWLQB a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RKCZWOPFJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<XHYDMDCCRRK> PCFYNCPIPQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool UIUXHPQHBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool ICIKPEMDUZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool TEICFJYXQMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool YVDOBPNKZSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool YUYHEITNQGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool YHCCQBTYFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool IFTOUGBNIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool OWCCYCLPEMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, NRZUVTJIBNZ Type)> MVOCQFWVZWS;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid LYEFCWKIZSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x28FD4C0", Offset = "0x28FC6C0", VA = "0x1828FD4C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<XHYDMDCCRRK> SZJWOZCFYMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x28FD4C0", Offset = "0x28FC6C0", VA = "0x1828FD4C0")]
			get
			{
				return default(Id128<XHYDMDCCRRK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, NRZUVTJIBNZ Type)> GLAGHPVUWXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action UZDPQXZHSAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2945060", Offset = "0x2944260", VA = "0x182945060")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2945620", Offset = "0x2944820", VA = "0x182945620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, NRZUVTJIBNZ> ZTRAKNXWHAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2944BB0", Offset = "0x2943DB0", VA = "0x182944BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2944FB0", Offset = "0x29441B0", VA = "0x182944FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> NZLGRNEVUHU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2945250", Offset = "0x2944450", VA = "0x182945250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2944AA0", Offset = "0x2943CA0", VA = "0x182944AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> CLBZFGUHRSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x29451A0", Offset = "0x29443A0", VA = "0x1829451A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x29449F0", Offset = "0x2943BF0", VA = "0x1829449F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, NRZUVTJIBNZ> OYZAZFCGRTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x29456C0", Offset = "0x29448C0", VA = "0x1829456C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2945570", Offset = "0x2944770", VA = "0x182945570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UFJDKBKYGUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2944760", Offset = "0x2943960", VA = "0x182944760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2945100", Offset = "0x2944300", VA = "0x182945100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18DAFB0", Offset = "0x18DA1B0", VA = "0x1818DAFB0")]
		public void SWXYGRWVORD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x29457E0", Offset = "0x29449E0", VA = "0x1829457E0")]
		internal RKCZWOPFJBK([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, NRZUVTJIBNZ Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2945420", Offset = "0x2944620", VA = "0x182945420")]
		public static CircuitEventDefinitionFactoryStart NEOQDMXJNFD(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x29454F0", Offset = "0x29446F0", VA = "0x1829454F0")]
		public static CircuitEventDefinitionFactoryStart NEOQDMXJNFD(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2944EA0", Offset = "0x29440A0", VA = "0x182944EA0")]
		public static RKCZWOPFJBK IVLKRIXKVCP([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2944C60", Offset = "0x2943E60", VA = "0x182944C60")]
		public static RKCZWOPFJBK IHAKWQEBBXP([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCAA600", Offset = "0xCA9800", VA = "0x180CAA600")]
		public void XWUNKJWVFOX(Id128<XHYDMDCCRRK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2944B50", Offset = "0x2943D50", VA = "0x182944B50")]
		public void GWTUDPTJRBI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2944900", Offset = "0x2943B00", VA = "0x182944900")]
		public void ECPASNMHQXA(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2944670", Offset = "0x2943870", VA = "0x182944670")]
		public void AJYFCWVXKVT(int a, NRZUVTJIBNZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2945300", Offset = "0x2944500", VA = "0x182945300")]
		public void NAMDITYGSUT(string a, NRZUVTJIBNZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2945770", Offset = "0x2944970", VA = "0x182945770")]
		public void YSRQKRUEVAU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2944800", Offset = "0x2943A00", VA = "0x182944800")]
		public RKCZWOPFJBK Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2937F50", Offset = "0x2937150", VA = "0x182937F50")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2937DE0", Offset = "0x2936FE0", VA = "0x182937DE0")]
		public CircuitEventDefinitionFactoryParams TXILOHAEUTP(string a, NRZUVTJIBNZ b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2937CB0", Offset = "0x2936EB0", VA = "0x182937CB0")]
		public RKCZWOPFJBK QIOJAOPXSKN()
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
		private readonly List<(string Name, NRZUVTJIBNZ Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2937C20", Offset = "0x2936E20", VA = "0x182937C20")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, NRZUVTJIBNZ Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2937AF0", Offset = "0x2936CF0", VA = "0x182937AF0")]
		public CircuitEventDefinitionFactoryParams TXILOHAEUTP(string a, NRZUVTJIBNZ b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x29379F0", Offset = "0x2936BF0", VA = "0x1829379F0")]
		public RKCZWOPFJBK QIOJAOPXSKN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MQLHGSNDNOB
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly RKCZWOPFJBK OBGFPTIWJEY;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly RKCZWOPFJBK YPUSYXRTOWD;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly RKCZWOPFJBK FXQMNQPDSRQ;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly RKCZWOPFJBK EKVCWNLNXXV;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly RKCZWOPFJBK LSOUUFBPKLG;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly RKCZWOPFJBK OGYIVFICTOK;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly RKCZWOPFJBK OOPRGHSVSXD;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly RKCZWOPFJBK[] SBVSKZTOLUK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class MSBVPIIOMMA
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly RKCZWOPFJBK NHXWRHJAKQE;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class MPCIJVTRYGL
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly RKCZWOPFJBK GMEIWMMMPMQ;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly RKCZWOPFJBK KOAGCMPNSOZ;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class VJVVSDCPBAC
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly RKCZWOPFJBK NMLBFAMHJGR;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly RKCZWOPFJBK XFXLTAKVIKA;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly RKCZWOPFJBK[] FNXKYVCJZXS;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly RKCZWOPFJBK LCGGJILDSQQ;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly RKCZWOPFJBK HSJIHQMIGNX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class IHBJEAWJVJI
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly RKCZWOPFJBK VGICPWKTPUN;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly RKCZWOPFJBK GZMXZMQQVGY;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class DNIDZVEQHYX
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly RKCZWOPFJBK PSHJRZZDULW;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly RKCZWOPFJBK WFRNTJMJTTF;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class ISNOCIVMTTC
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly RKCZWOPFJBK GMEIWMMMPMQ;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly RKCZWOPFJBK KOAGCMPNSOZ;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class BFOVTWLHFJI
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly RKCZWOPFJBK URUQRPIRRZN;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly RKCZWOPFJBK YQVGECBZYLS;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly RKCZWOPFJBK UDWUFNEMRSK;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly RKCZWOPFJBK QNYJQUTALZK;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly RKCZWOPFJBK TQUDHQVCBRN;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly RKCZWOPFJBK ZIJITXRKZMQ;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly RKCZWOPFJBK AGQBACQHQZL;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class IVDEEBWEUWC
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class WUJAQQJBIPE
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class GIXJPQYZICG
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RNQLEMQKDNI
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly RKCZWOPFJBK QDTEBETHDVR;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly RKCZWOPFJBK PBLXFUFIHUI;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class IRDCPODTUFO
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class MZEVIRRVXAA
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class SDGYDEXGANC
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class YCKSHWSXLYH
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly RKCZWOPFJBK MWHYKEPRPGP;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly RKCZWOPFJBK MYAWXPZTKUZ;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly RKCZWOPFJBK DJMYLCGGKCW;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly RKCZWOPFJBK HQDUBEXYGQT;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly RKCZWOPFJBK XXYXXHOMNMF;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly RKCZWOPFJBK PSHJRZZDULW;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly RKCZWOPFJBK YJZZEAVLOUB;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly RKCZWOPFJBK FRSYZWUSWNQ;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly RKCZWOPFJBK EQVWGHLZHZO;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly RKCZWOPFJBK TIJSMBVJXJO;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly RKCZWOPFJBK IJGIRRZTXIG;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly RKCZWOPFJBK FRCRDUQFTZW;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly RKCZWOPFJBK HPCBVKIOHRB;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly RKCZWOPFJBK DAPUINYUFRA;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly RKCZWOPFJBK VYDIBJNXRLL;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly RKCZWOPFJBK DPOZDIFRPZD;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly RKCZWOPFJBK GEEMJMYTHIL;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly RKCZWOPFJBK BNKEQOEAKTO;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly RKCZWOPFJBK ZHKTFVQFKAN;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly RKCZWOPFJBK NMPBYILQUMX;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly RKCZWOPFJBK NLTDTCVMOAW;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly RKCZWOPFJBK EKGOUCQNNUK;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly RKCZWOPFJBK NQSUMZAVJHW;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly RKCZWOPFJBK DDJQUEGNCFW;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly RKCZWOPFJBK OOPMRKATKPK;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly RKCZWOPFJBK BOEJXLLCSGM;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly RKCZWOPFJBK OJGZTAANHAK;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly RKCZWOPFJBK WVYXBZFKZYK;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly RKCZWOPFJBK ZEZGOJOYOIP;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly RKCZWOPFJBK GDGSAJDTDIX;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly RKCZWOPFJBK IXJTVFVWWPQ;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly RKCZWOPFJBK RKBREFAUPNQ;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly RKCZWOPFJBK BFZJVQWQNLR;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly RKCZWOPFJBK QLBCCHMOVPZ;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly RKCZWOPFJBK YSXYBAIJMBV;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly RKCZWOPFJBK WRLNRTLBVMX;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly RKCZWOPFJBK SMUAIKONTMD;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly RKCZWOPFJBK IOVRTIMDLHP;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly RKCZWOPFJBK FZQXCKEYKMR;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly RKCZWOPFJBK XCCWIPKIFPD;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly RKCZWOPFJBK WJNRONOLFLW;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly RKCZWOPFJBK CJVGKSKUAEC;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly RKCZWOPFJBK IBDSCBKVUKU;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly RKCZWOPFJBK TQPRLSORPCY;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly RKCZWOPFJBK OWVKVKWYCOI;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly RKCZWOPFJBK ZSHJRDVJLWI;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly RKCZWOPFJBK SXXBMZRMNIO;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly RKCZWOPFJBK XXXLPLVNBQG;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly RKCZWOPFJBK XMGNWXHOYNY;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly RKCZWOPFJBK NQMVJJQGHNW;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly RKCZWOPFJBK LWKYHGWOTWT;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly RKCZWOPFJBK SATGBMWXYCQ;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly RKCZWOPFJBK LPUFJHBEYAO;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly RKCZWOPFJBK UBDKFBSGUEQ;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly RKCZWOPFJBK FSYEDJMXPNG;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly RKCZWOPFJBK PIKFYZKXAWY;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly RKCZWOPFJBK EUGLJBQOCZW;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly RKCZWOPFJBK BCVQXGOAWGQ;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly RKCZWOPFJBK RCRTRULGUQG;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly RKCZWOPFJBK TTDZEVBWMFE;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly RKCZWOPFJBK TKEVQQFZZLE;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly RKCZWOPFJBK SYRZZPDYMBW;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly RKCZWOPFJBK TLJBPKOJXHR;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly RKCZWOPFJBK ZTYLVZYDKCU;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly RKCZWOPFJBK ZNATZCVFLZC;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly RKCZWOPFJBK LAOVPNKZWKD;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly RKCZWOPFJBK ZAZAYYPSNZL;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly RKCZWOPFJBK JQFIOURYDIC;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly RKCZWOPFJBK IPYDUULIWNO;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class UVQINZUEYIT
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class CONNHDPCDRM
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly RKCZWOPFJBK ZMETOAZGUTC;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly RKCZWOPFJBK HOJZVSIXDGB;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly RKCZWOPFJBK EUSOJPOOSMB;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly RKCZWOPFJBK WOYRSZWEVJE;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly RKCZWOPFJBK ZIFFVDHUAJE;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly RKCZWOPFJBK CFTGYONXSEY;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly RKCZWOPFJBK BWCFYTWFCYW;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class WSZFOBLFHVZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly RKCZWOPFJBK MYAWXPZTKUZ;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly RKCZWOPFJBK DJMYLCGGKCW;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly RKCZWOPFJBK HQDUBEXYGQT;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly RKCZWOPFJBK AZDFVZWWBCH;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly RKCZWOPFJBK VOUXPHHGPPF;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly RKCZWOPFJBK KHBVBGHOTSP;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly RKCZWOPFJBK LDPBECJVZVD;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class IMTVBEBKSED
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly RKCZWOPFJBK PDXAKBXXVPD;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly RKCZWOPFJBK IAEEUMHFALH;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly RKCZWOPFJBK ZTOJRBUMACS;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly RKCZWOPFJBK ULSJPVOJPZE;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly RKCZWOPFJBK QELFRCKDJAC;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly RKCZWOPFJBK YMQMFGIWHEU;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class VHKBDFKBZOU
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class HWMIYHCYHBV
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly RKCZWOPFJBK PUPFXUXQFCN;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class YAFUSXKAEXL
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly RKCZWOPFJBK MWHYKEPRPGP;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class PQHTHVULTNQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class IMZOHVHYVZD
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class ZRFTCSKPEZU
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly RKCZWOPFJBK SAERKIPTDPA;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly RKCZWOPFJBK IDBYSRDDTPO;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly RKCZWOPFJBK KWVAGYWZJSP;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly RKCZWOPFJBK NFKUNZAODCX;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class QAOYOANDHOY
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly RKCZWOPFJBK PINXFZEFYVP;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly RKCZWOPFJBK ZUPOPIKPGFM;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class XQKWJHFRUFK
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class ZZNXBDCQLSQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly RKCZWOPFJBK ZMETOAZGUTC;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly RKCZWOPFJBK HOJZVSIXDGB;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class CIPNPGHIOUJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly RKCZWOPFJBK AYDEGZPSGXM;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly RKCZWOPFJBK WOYRSZWEVJE;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly RKCZWOPFJBK ZIFFVDHUAJE;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly RKCZWOPFJBK CFTGYONXSEY;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly RKCZWOPFJBK HUBHKWUCABB;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly RKCZWOPFJBK VLFDEGGRVTS;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly RKCZWOPFJBK XCTUJWNEJVG;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly RKCZWOPFJBK JGIEOONOLGG;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly RKCZWOPFJBK HHSKAAVJHYP;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly RKCZWOPFJBK LAYBTMZZWST;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly RKCZWOPFJBK ZMETOAZGUTC;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly RKCZWOPFJBK HOJZVSIXDGB;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class ZCXFEULWJHN
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class SGKACITTOFT
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly RKCZWOPFJBK ZMETOAZGUTC;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly RKCZWOPFJBK HOJZVSIXDGB;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly RKCZWOPFJBK QIMHUJNQIET;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly RKCZWOPFJBK NPLFQIEHQGH;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly RKCZWOPFJBK VKMUALTWFTM;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class CUXRCXZXOSQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class QAFECCMEEBB
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly RKCZWOPFJBK YYOBYJHPIGA;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class QXNXJPCCKZB
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly RKCZWOPFJBK JPQSKPYSHIZ;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly RKCZWOPFJBK COJBYADENAQ;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly RKCZWOPFJBK ZMETOAZGUTC;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly RKCZWOPFJBK HOJZVSIXDGB;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class RZNTOTJAUBA
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class QMXCGEFOGLY
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class HJBZEDDJFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class LGWYSUAKZWH
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class KWEXNZFLUJE
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class YVPSQCZTAEO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly RKCZWOPFJBK QDTEBETHDVR;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly RKCZWOPFJBK PBLXFUFIHUI;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class AGRLSVAPAZA
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly RKCZWOPFJBK DLOSDPMSKOB;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly RKCZWOPFJBK SMQQVQVAYHN;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly RKCZWOPFJBK OHPYLVWGUWJ;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly RKCZWOPFJBK OMRKPITGKST;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class ROCBBRIOIAH
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly RKCZWOPFJBK DLOSDPMSKOB;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly RKCZWOPFJBK SMQQVQVAYHN;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly RKCZWOPFJBK OHPYLVWGUWJ;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly RKCZWOPFJBK OMRKPITGKST;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class AHJMREWZHXE
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class HEGBPWRJSFJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly RKCZWOPFJBK NZYXBDMVJFS;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly RKCZWOPFJBK FUXUOILQXFW;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly RKCZWOPFJBK YSQKITROSIA;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class RIJBLKDWGAC
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly RKCZWOPFJBK FTAENUBUNYB;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly RKCZWOPFJBK LWRECLWICCP;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly RKCZWOPFJBK RXXJAKXEKRW;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class KSKXJQBVSFH
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class EJNOMZKJBRS
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly RKCZWOPFJBK RIYNJDJBHNS;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly RKCZWOPFJBK RLXGYPSCZPI;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly RKCZWOPFJBK HQZLRRTXUYZ;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly RKCZWOPFJBK BWMXZNWWIEJ;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly RKCZWOPFJBK IWAOMPLELCI;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class ILCAZGBSWRB
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly RKCZWOPFJBK RWLGFBPLTXK;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class CWZGXSIBAGX
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly RKCZWOPFJBK HUUSZFCZRVH;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly RKCZWOPFJBK TGKQBEOBTYC;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly RKCZWOPFJBK TAUZERTASXL;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class KDPZAMLKQQQ
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class WJVUKXGJUGK
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class IYROLUXAEYJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class YNHNTZYBAES
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly RKCZWOPFJBK QIPDEMUBWKP;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly RKCZWOPFJBK ZJCTMETNKCE;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly RKCZWOPFJBK ECVBZIDEDDI;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly RKCZWOPFJBK VOZRYGHWOTY;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly RKCZWOPFJBK NCQJKITJOGB;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly RKCZWOPFJBK FSEVTDEOELF;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly RKCZWOPFJBK MABCRCRBJUM;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class UDJEJKHQIOO
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly RKCZWOPFJBK GNPBGHXRILX;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly RKCZWOPFJBK[] WAEXHSIGTTL;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class UGPZSCSDBVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly NRZUVTJIBNZ YZNEPRARLKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<RKCZWOPFJBK> XTWFRXGWMSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<RKCZWOPFJBK> ZQUPBGQWAXQ;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<RKCZWOPFJBK> DDEGZJVLQPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<RKCZWOPFJBK> DGEEFVRLPZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2963210", Offset = "0x2962410", VA = "0x182963210")]
		protected UGPZSCSDBVY(NRZUVTJIBNZ a, params RKCZWOPFJBK[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class AFVFZEVEZMW : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x29569D0", Offset = "0x2955BD0", VA = "0x1829569D0")]
		internal AFVFZEVEZMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class LSCZYMKAEFZ : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x295E050", Offset = "0x295D250", VA = "0x18295E050")]
		internal LSCZYMKAEFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NUCVWNVVMYW : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x295EA40", Offset = "0x295DC40", VA = "0x18295EA40")]
		internal NUCVWNVVMYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class TFITDWZNDYP : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2962960", Offset = "0x2961B60", VA = "0x182962960")]
		internal TFITDWZNDYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class UYXJYBNUVRG : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x29633E0", Offset = "0x29625E0", VA = "0x1829633E0")]
		internal UYXJYBNUVRG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class PVTJNJQLRLG : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x295F4D0", Offset = "0x295E6D0", VA = "0x18295F4D0")]
		internal PVTJNJQLRLG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class XMHAQMHRROX : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2965310", Offset = "0x2964510", VA = "0x182965310")]
		internal XMHAQMHRROX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class JFRBQIUDPRM : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x295D5C0", Offset = "0x295C7C0", VA = "0x18295D5C0")]
		internal JFRBQIUDPRM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class PVWDNTVHSYE : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x295F6A0", Offset = "0x295E8A0", VA = "0x18295F6A0")]
		internal PVWDNTVHSYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class QLUENWQTGYE : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2960260", Offset = "0x295F460", VA = "0x182960260")]
		internal QLUENWQTGYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class KCGGSIFMQFO : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x295D790", Offset = "0x295C990", VA = "0x18295D790")]
		internal KCGGSIFMQFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class WKDFNXKXJFC : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2963670", Offset = "0x2962870", VA = "0x182963670")]
		internal WKDFNXKXJFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class BKJFPBLUFXC : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2957610", Offset = "0x2956810", VA = "0x182957610")]
		internal BKJFPBLUFXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class FTYYXYUMBWE : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x295AA50", Offset = "0x2959C50", VA = "0x18295AA50")]
		internal FTYYXYUMBWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class OWAAWJTNSTQ : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x295EE80", Offset = "0x295E080", VA = "0x18295EE80")]
		internal OWAAWJTNSTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class NPBDGTKKOZA : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x295E6A0", Offset = "0x295D8A0", VA = "0x18295E6A0")]
		internal NPBDGTKKOZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class PDOCKRUFSZY : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x295F2A0", Offset = "0x295E4A0", VA = "0x18295F2A0")]
		internal PDOCKRUFSZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class XBZEQJQWYIH : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2964BD0", Offset = "0x2963DD0", VA = "0x182964BD0")]
		internal XBZEQJQWYIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class HZDWKELRVUR : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x295C280", Offset = "0x295B480", VA = "0x18295C280")]
		internal HZDWKELRVUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class MZLMGNBBDWV : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x295E1A0", Offset = "0x295D3A0", VA = "0x18295E1A0")]
		internal MZLMGNBBDWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class OZYHCQJEWFV : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x295F050", Offset = "0x295E250", VA = "0x18295F050")]
		internal OZYHCQJEWFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class BZGVOYKAUZZ : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2957C00", Offset = "0x2956E00", VA = "0x182957C00")]
		internal BZGVOYKAUZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class GCNHNZHQSKY : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x295AB30", Offset = "0x2959D30", VA = "0x18295AB30")]
		internal GCNHNZHQSKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class IOSOPFYZXER : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x295D1C0", Offset = "0x295C3C0", VA = "0x18295D1C0")]
		internal IOSOPFYZXER()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class RAEGLZBCBAW : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2960BE0", Offset = "0x295FDE0", VA = "0x182960BE0")]
		internal RAEGLZBCBAW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class XKHXTXCFCGZ : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2965140", Offset = "0x2964340", VA = "0x182965140")]
		internal XKHXTXCFCGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class GGQTXEHYZCP : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x295AD00", Offset = "0x2959F00", VA = "0x18295AD00")]
		internal GGQTXEHYZCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ITARMKHGOHX : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x295D390", Offset = "0x295C590", VA = "0x18295D390")]
		internal ITARMKHGOHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class BFYUCRQJQAE : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2957440", Offset = "0x2956640", VA = "0x182957440")]
		internal BFYUCRQJQAE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class GPJUIAHYFGF : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x295B0A0", Offset = "0x295A2A0", VA = "0x18295B0A0")]
		internal GPJUIAHYFGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class YYETEXJPINS : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x29665E0", Offset = "0x29657E0", VA = "0x1829665E0")]
		internal YYETEXJPINS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class XKGFKESWQHY : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2964F70", Offset = "0x2964170", VA = "0x182964F70")]
		internal XKGFKESWQHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class QQBYAPRZKAS : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2960490", Offset = "0x295F690", VA = "0x182960490")]
		internal QQBYAPRZKAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class CZCJGCRYKFD : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2959870", Offset = "0x2958A70", VA = "0x182959870")]
		internal CZCJGCRYKFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class ZQIORLHAKVB : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2966810", Offset = "0x2965A10", VA = "0x182966810")]
		internal ZQIORLHAKVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class TRKWBKWZGSN : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2962B30", Offset = "0x2961D30", VA = "0x182962B30")]
		internal TRKWBKWZGSN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class KHCRBEOXXKK : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x295D9C0", Offset = "0x295CBC0", VA = "0x18295D9C0")]
		internal KHCRBEOXXKK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class KQRLXIAYMXR : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x295DB90", Offset = "0x295CD90", VA = "0x18295DB90")]
		internal KQRLXIAYMXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class BNGEYHCNANF : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x29577E0", Offset = "0x29569E0", VA = "0x1829577E0")]
		internal BNGEYHCNANF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class FHYLGXCWING : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x295A730", Offset = "0x2959930", VA = "0x18295A730")]
		internal FHYLGXCWING()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class NFURRCDRXMI : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x295E380", Offset = "0x295D580", VA = "0x18295E380")]
		internal NFURRCDRXMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class GULUBHDGBMI : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x295B270", Offset = "0x295A470", VA = "0x18295B270")]
		internal GULUBHDGBMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class TYDAWVWNCLN : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2962D80", Offset = "0x2961F80", VA = "0x182962D80")]
		internal TYDAWVWNCLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class IMUCFMSCWYT : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x295CF90", Offset = "0x295C190", VA = "0x18295CF90")]
		internal IMUCFMSCWYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class NQYJXVNGWWY : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x295E870", Offset = "0x295DA70", VA = "0x18295E870")]
		internal NQYJXVNGWWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class SZQPEVZLOLD : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x29625C0", Offset = "0x29617C0", VA = "0x1829625C0")]
		internal SZQPEVZLOLD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class PXEAMZHZRHO : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x295F870", Offset = "0x295EA70", VA = "0x18295F870")]
		internal PXEAMZHZRHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class YUZGHTSPQNB : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2965E70", Offset = "0x2965070", VA = "0x182965E70")]
		internal YUZGHTSPQNB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class RPYCCXKURXV : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2961CD0", Offset = "0x2960ED0", VA = "0x182961CD0")]
		internal RPYCCXKURXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class APRGIVLZIXG : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2957270", Offset = "0x2956470", VA = "0x182957270")]
		internal APRGIVLZIXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class YGWUBFZHKOO : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x29656D0", Offset = "0x29648D0", VA = "0x1829656D0")]
		internal YGWUBFZHKOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class YRXLUKRXVAR : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2965CA0", Offset = "0x2964EA0", VA = "0x182965CA0")]
		internal YRXLUKRXVAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class YYCSLLSFPNU : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2966410", Offset = "0x2965610", VA = "0x182966410")]
		internal YYCSLLSFPNU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class GOPZOVNAUAP : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x295AED0", Offset = "0x295A0D0", VA = "0x18295AED0")]
		internal GOPZOVNAUAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class EJEDCPELOPR : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2959C10", Offset = "0x2958E10", VA = "0x182959C10")]
		internal EJEDCPELOPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class XCELTDYQDQB : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2964DA0", Offset = "0x2963FA0", VA = "0x182964DA0")]
		internal XCELTDYQDQB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class QCSJIDJHOIP : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2960090", Offset = "0x295F290", VA = "0x182960090")]
		internal QCSJIDJHOIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class RHABTDSDHOW : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2961000", Offset = "0x2960200", VA = "0x182961000")]
		internal RHABTDSDHOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class BOEOCWEXUYJ : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2957A30", Offset = "0x2956C30", VA = "0x182957A30")]
		internal BOEOCWEXUYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class TBHUTULLILD : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2962790", Offset = "0x2961990", VA = "0x182962790")]
		internal TBHUTULLILD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class FJIAVXQMIBW : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x295A900", Offset = "0x2959B00", VA = "0x18295A900")]
		internal FJIAVXQMIBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class LECUPCVGZEN : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x295DEA0", Offset = "0x295D0A0", VA = "0x18295DEA0")]
		internal LECUPCVGZEN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class NIGZPBRWKGQ : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x295E550", Offset = "0x295D750", VA = "0x18295E550")]
		internal NIGZPBRWKGQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class DUNRNMSTTOL : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2959AC0", Offset = "0x2958CC0", VA = "0x182959AC0")]
		internal DUNRNMSTTOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class RGBRQKGOXJL : UGPZSCSDBVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2960DB0", Offset = "0x295FFB0", VA = "0x182960DB0")]
		internal RGBRQKGOXJL()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, YTDJCTQVIZN<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly NRZUVTJIBNZ Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
		private NamedType(string name, NRZUVTJIBNZ type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2896790", Offset = "0x2895990", VA = "0x182896790")]
		public static NamedType New(string name, NRZUVTJIBNZ type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x295ED40", Offset = "0x295DF40", VA = "0x18295ED40")]
		public static bool QEDRWBLLCYQ([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x295ED40", Offset = "0x295DF40", VA = "0x18295ED40", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x295ED40", Offset = "0x295DF40", VA = "0x18295ED40")]
		public bool VNLJEVZERES([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x295EC90", Offset = "0x295DE90", VA = "0x18295EC90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x295ED90", Offset = "0x295DF90", VA = "0x18295ED90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x295EE40", Offset = "0x295E040", VA = "0x18295EE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x295EE00", Offset = "0x295E000", VA = "0x18295EE00")]
		public string KIBXRKLAHRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x295EC10", Offset = "0x295DE10", VA = "0x18295EC10")]
		public string AEZVQEHUBPW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x295ED40", Offset = "0x295DF40", VA = "0x18295ED40", Slot = "5")]
		private bool PQLTIBFIICD([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface DLOXXYQFPRD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(USPEKNRWVPE a, bool b);
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
