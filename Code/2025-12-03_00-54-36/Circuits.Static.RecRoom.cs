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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x28DDE40", Offset = "0x28DCA40", VA = "0x1828DDE40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		[Cpp2IlInjected.Address(RVA = "0x28DDDC0", Offset = "0x28DC9C0", VA = "0x1828DDDC0", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class YMWADPANFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28FA130", Offset = "0x28F8D30", VA = "0x1828FA130")]
		public static bool EHEKRTQUAWU(this JFWWKSXUUGK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28FA070", Offset = "0x28F8C70", VA = "0x1828FA070")]
		public static bool EHEKRTQUAWU(this EEBTCGHBHYR a)
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
			private readonly BOOLTIYANOI _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			public EVRequest(BOOLTIYANOI staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class XAWNXHUCUGX
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<GQVQINEVBGM>, FDXVJGFJAZL> YKBFCOXAYAE;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<GQVQINEVBGM>>? RLETGCEYQHK;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<GQVQINEVBGM> HCJDNAVDXZA;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<GQVQINEVBGM> TBBFVLARQJB;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<GQVQINEVBGM> ZAVLBILLTEG;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<GQVQINEVBGM> FRRLJVIEXGL;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<GQVQINEVBGM> WCYYHBKOAPW;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<GQVQINEVBGM> CJDZXDBCOTZ;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<GQVQINEVBGM> VPKAIZWNIKD;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<GQVQINEVBGM> XRTRPSLDDHJ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<GQVQINEVBGM> JYFXYZOLKHV;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<GQVQINEVBGM> ODYVVZFMMHF;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<GQVQINEVBGM> SMFMSEXCSST;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<GQVQINEVBGM> KLIXWFMMPAZ;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<GQVQINEVBGM> KKKWXQQYBBO;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<GQVQINEVBGM> SQHROFHPBHK;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<GQVQINEVBGM> KLSUNJPAQLA;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<GQVQINEVBGM> NSHXPCAJEER;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<GQVQINEVBGM> RJXZXXJVPNK;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<GQVQINEVBGM> XRCFSSMZLFY;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<GQVQINEVBGM> VQMNFAQOKTH;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<GQVQINEVBGM> JZPOCMEVHZQ;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<GQVQINEVBGM> TLEMQPZDUMV;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<GQVQINEVBGM> IUXBXZHNWEG;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<GQVQINEVBGM> GYEORKDMAHQ;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<GQVQINEVBGM> KHQZCIZTNDX;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<GQVQINEVBGM> ICYNGJEAWXH;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<GQVQINEVBGM> XUQORQFBEOQ;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<GQVQINEVBGM> NHTLUCAKFKT;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<GQVQINEVBGM> YYHAGSECIYY;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<GQVQINEVBGM> SSEUXBKHJCU;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<GQVQINEVBGM> ZFRMCZTCYTA;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<GQVQINEVBGM> MZMCMOEAVPW;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<GQVQINEVBGM> GIPJGAUYYLT;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<GQVQINEVBGM> KROMREIYDRU;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<GQVQINEVBGM> GFROFLNQGRA;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<GQVQINEVBGM> LEUQEOSGROM;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<GQVQINEVBGM> TVKYQAEDJUJ;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<GQVQINEVBGM> BRPWZCZYGJA;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<GQVQINEVBGM> MPUDAAJZSLF;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<GQVQINEVBGM> QFNDQVHMRAX;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<GQVQINEVBGM> NFSNAQKJLDX;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<GQVQINEVBGM> HEZGGVLZQMW;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<GQVQINEVBGM> AZFCGMZZBEO;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<GQVQINEVBGM> LJDJJEZLGDR;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<GQVQINEVBGM> EOMCRXFJSLM;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<GQVQINEVBGM> KXVOSHHIKXO;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<GQVQINEVBGM> EKFEBCJTYNY;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<GQVQINEVBGM> GYAYRLXSYCD;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<GQVQINEVBGM> JDHXHUNUJIH;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<GQVQINEVBGM> AKWIWVHXPUH;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<GQVQINEVBGM> OUVRLAALHWS;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<GQVQINEVBGM> UITKRYIRUYS;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<GQVQINEVBGM> QNTGZSSQWRF;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<GQVQINEVBGM> PKJYDLXGYYU;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<GQVQINEVBGM> FULDZLVARKK;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<GQVQINEVBGM> IDOQTRXGJOJ;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<GQVQINEVBGM> HMAVIZNXVYJ;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<GQVQINEVBGM> MOBLCQIGQJL;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<GQVQINEVBGM> VWDSIQQENFX;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<GQVQINEVBGM> KESGEUDWUTC;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<GQVQINEVBGM> XVMUSODYOLR;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<GQVQINEVBGM> AMSIUFOLNKF;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<GQVQINEVBGM> WREBMMYPDNB;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<GQVQINEVBGM> YBLKUYSXAGE;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<GQVQINEVBGM> RTGZMZGWHIK;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<GQVQINEVBGM> GGEPUHNWXMZ;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<GQVQINEVBGM> USQTPPKMCKW;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<GQVQINEVBGM> GKOMDRRXFSH;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<GQVQINEVBGM> HHLWBFRGATP;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<GQVQINEVBGM> WAAPQUCMTJN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<GQVQINEVBGM>, FDXVJGFJAZL> IFVXLUFWUHF
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x28F6EF0", Offset = "0x28F5AF0", VA = "0x1828F6EF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x28F6F40", Offset = "0x28F5B40", VA = "0x1828F6F40")]
			public static FDXVJGFJAZL ZJOAXICWYLX(Id32<GQVQINEVBGM> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28F6B50", Offset = "0x28F5750", VA = "0x1828F6B50")]
			public static bool AOSZMIVADPQ(Id32<GQVQINEVBGM> id, [Out] FDXVJGFJAZL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x28F6BE0", Offset = "0x28F57E0", VA = "0x1828F6BE0")]
			public static JFWWKSXUUGK KVPKREGPNJK(Id32<GQVQINEVBGM> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x28F6C90", Offset = "0x28F5890", VA = "0x1828F6C90")]
			private static Id32<GQVQINEVBGM> OGBNJYRINGK(FDXVJGFJAZL a, Id32<GQVQINEVBGM> id)
			{
				return default(Id32<GQVQINEVBGM>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x28F6D20", Offset = "0x28F5920", VA = "0x1828F6D20")]
			private static void YJQOBPKJYHC(Id32<GQVQINEVBGM> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class UQXGZRWETRS
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<KYBGCQJEFUS, JFWWKSXUUGK?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xFC16A0", Offset = "0xFC02A0", VA = "0x180FC16A0")]
				private TypeRegistryFactory([In] IdUnsafeList<KYBGCQJEFUS, JFWWKSXUUGK?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x28E96C0", Offset = "0x28E82C0", VA = "0x1828E96C0")]
				public static TypeRegistryFactory QMWBYPAHZIM()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x28E9720", Offset = "0x28E8320", VA = "0x1828E9720")]
				public (ReadOnlyIdArray<KYBGCQJEFUS, JFWWKSXUUGK>, IReadOnlyDictionary<JFWWKSXUUGK, Id32<KYBGCQJEFUS>>) ZXGWLXXUFYA()
				{
					return default((ReadOnlyIdArray<KYBGCQJEFUS, JFWWKSXUUGK>, IReadOnlyDictionary<JFWWKSXUUGK, Id32<KYBGCQJEFUS>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x28E94F0", Offset = "0x28E80F0", VA = "0x1828E94F0")]
				public Id32<KYBGCQJEFUS> ETZDOZEVQES(int a, JFWWKSXUUGK b)
				{
					return default(Id32<KYBGCQJEFUS>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x28E9670", Offset = "0x28E8270", VA = "0x1828E9670")]
				public Id32<KYBGCQJEFUS> Initialize(int id, TENELWVUMZX type, TENELWVUMZX factoryType)
				{
					return default(Id32<KYBGCQJEFUS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class DOZSTKECKIT
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<KYBGCQJEFUS> FCMSHXOTWKA
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x28DC7F0", Offset = "0x28DB3F0", VA = "0x1828DC7F0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x28DC7B0", Offset = "0x28DB3B0", VA = "0x1828DC7B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<KYBGCQJEFUS> ZUMOQGPEGHQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x28DC630", Offset = "0x28DB230", VA = "0x1828DC630")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x28DC870", Offset = "0x28DB470", VA = "0x1828DC870")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<KYBGCQJEFUS> FAIXJSGAMDX
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x28DC6B0", Offset = "0x28DB2B0", VA = "0x1828DC6B0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x28DC8F0", Offset = "0x28DB4F0", VA = "0x1828DC8F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<KYBGCQJEFUS> KMSUPTLOCFD
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x28DC670", Offset = "0x28DB270", VA = "0x1828DC670")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x28DC6F0", Offset = "0x28DB2F0", VA = "0x1828DC6F0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<KYBGCQJEFUS> EETCULMSLUB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x28DC830", Offset = "0x28DB430", VA = "0x1828DC830")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x28DC770", Offset = "0x28DB370", VA = "0x1828DC770")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<KYBGCQJEFUS> ETSBHJUQALW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x28DC730", Offset = "0x28DB330", VA = "0x1828DC730")]
					[CompilerGenerated]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x28DC8B0", Offset = "0x28DB4B0", VA = "0x1828DC8B0")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class CEGTAEUMQEL : IEnumerable<JFWWKSXUUGK>, IEnumerable, IEnumerator<JFWWKSXUUGK>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int VIUVMRSCWZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private JFWWKSXUUGK VWMVUJJYLQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int FTPEWITHWYC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool SGPYUKCLGPW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool YQCLKQWIBPT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion BPCUCFVOZOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion JIJKAPKAKEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool FXMDKRFGENV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool HKEGPDFQNVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool QCHBTWDFOWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool WUJBDEJZIGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool XHATGKOQZGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool QZBPQIZCOBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool GUVZQSOTFUR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool TYZVJZZPYSE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<JFWWKSXUUGK> KYBQTQIMGAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private JFWWKSXUUGK MQBTMJBVGAY;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private JFWWKSXUUGK PWKZXZMJHLH
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object JGIILLOFTSJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
				[DebuggerHidden]
				public CEGTAEUMQEL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x28DA860", Offset = "0x28D9460", VA = "0x1828DA860", Slot = "7")]
				[DebuggerHidden]
				private void YZDXQKWRCHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x28DA430", Offset = "0x28D9030", VA = "0x1828DA430", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x28DA3E0", Offset = "0x28D8FE0", VA = "0x1828DA3E0")]
				private void LSRJDRRKPDO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x28DA820", Offset = "0x28D9420", VA = "0x1828DA820", Slot = "10")]
				[DebuggerHidden]
				private void XHCIYLVFRPR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x28DA320", Offset = "0x28D8F20", VA = "0x1828DA320", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<JFWWKSXUUGK> KHYEFUFMRMW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x28DA320", Offset = "0x28D8F20", VA = "0x1828DA320", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator VDVERRYCFPI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class OXFXTLORGKF : IEnumerable<JFWWKSXUUGK>, IEnumerable, IEnumerator<JFWWKSXUUGK>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int VIUVMRSCWZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private JFWWKSXUUGK VWMVUJJYLQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int FTPEWITHWYC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion BPCUCFVOZOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion JIJKAPKAKEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool QCHBTWDFOWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool WUJBDEJZIGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool FXMDKRFGENV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool HKEGPDFQNVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool SRHEJKYPLGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool VYADILJNJVG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool XHATGKOQZGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool QZBPQIZCOBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool VSVZJLPSRPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool GGMAVOYMXSH;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private JFWWKSXUUGK PWKZXZMJHLH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object JGIILLOFTSJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
				[DebuggerHidden]
				public OXFXTLORGKF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
				[DebuggerHidden]
				private void YZDXQKWRCHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x28DE350", Offset = "0x28DCF50", VA = "0x1828DE350", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x28E0260", Offset = "0x28DEE60", VA = "0x1828E0260", Slot = "10")]
				[DebuggerHidden]
				private void XHCIYLVFRPR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x28DE2A0", Offset = "0x28DCEA0", VA = "0x1828DE2A0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<JFWWKSXUUGK> KHYEFUFMRMW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x28DE2A0", Offset = "0x28DCEA0", VA = "0x1828DE2A0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator VDVERRYCFPI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class AHWQPVLWJCW : IEnumerable<Id32<KYBGCQJEFUS>>, IEnumerable, IEnumerator<Id32<KYBGCQJEFUS>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int VIUVMRSCWZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<KYBGCQJEFUS> VWMVUJJYLQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int FTPEWITHWYC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion BPCUCFVOZOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion JIJKAPKAKEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool FXMDKRFGENV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool HKEGPDFQNVA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool QCHBTWDFOWH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool WUJBDEJZIGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool XHATGKOQZGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool QZBPQIZCOBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool GUVZQSOTFUR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool TYZVJZZPYSE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<JFWWKSXUUGK> KYBQTQIMGAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<TENELWVUMZX> KYGXQXCJPLU;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<KYBGCQJEFUS> TTCTZBTWJIO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xB0BC00", Offset = "0xB0A800", VA = "0x180B0BC00", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<KYBGCQJEFUS>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object JGIILLOFTSJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x28D9AB0", Offset = "0x28D86B0", VA = "0x1828D9AB0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x12AE9F0", Offset = "0x12AD5F0", VA = "0x1812AE9F0")]
				[DebuggerHidden]
				public AHWQPVLWJCW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x28DA0E0", Offset = "0x28D8CE0", VA = "0x1828DA0E0", Slot = "7")]
				[DebuggerHidden]
				private void YZDXQKWRCHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x28D9BA0", Offset = "0x28D87A0", VA = "0x1828D9BA0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x28D9B00", Offset = "0x28D8700", VA = "0x1828D9B00")]
				private void LSRJDRRKPDO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x28D9B50", Offset = "0x28D8750", VA = "0x1828D9B50")]
				private void LTHDVLZCRLP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x28DA0A0", Offset = "0x28D8CA0", VA = "0x1828DA0A0", Slot = "10")]
				[DebuggerHidden]
				private void XHCIYLVFRPR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x28D9A00", Offset = "0x28D8600", VA = "0x1828D9A00", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<KYBGCQJEFUS>> HQTBGNTQUDT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x28D9A00", Offset = "0x28D8600", VA = "0x1828D9A00", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator VDVERRYCFPI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log JVTVAZRWBFB;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<KYBGCQJEFUS, JFWWKSXUUGK?> BNPZCNKSMGX;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<JFWWKSXUUGK, Id32<KYBGCQJEFUS>> ALHNWOJAJZZ;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly EEBTCGHBHYR JBAFAAQKQGS;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly EEBTCGHBHYR UKNFIYSNMZK;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<JFWWKSXUUGK> FMKMPOGOZIS;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<JFWWKSXUUGK> TQEOUZODWXH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet JAVIHKAOFSA
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet MOLROUHTAHG
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet VZVHHOEMLCY
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xB3AFF0", Offset = "0xB39BF0", VA = "0x180B3AFF0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static JFWWKSXUUGK FCMSHXOTWKA
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x28ED490", Offset = "0x28EC090", VA = "0x1828ED490")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static JFWWKSXUUGK ZUMOQGPEGHQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x28EA5A0", Offset = "0x28E91A0", VA = "0x1828EA5A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static JFWWKSXUUGK FAIXJSGAMDX
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x28EBBD0", Offset = "0x28EA7D0", VA = "0x1828EBBD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static JFWWKSXUUGK KMSUPTLOCFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x28EAFF0", Offset = "0x28E9BF0", VA = "0x1828EAFF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static JFWWKSXUUGK RHXVMCLEWHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x28EB550", Offset = "0x28EA150", VA = "0x1828EB550")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static JFWWKSXUUGK CQDSIXGXKGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x28ED340", Offset = "0x28EBF40", VA = "0x1828ED340")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static JFWWKSXUUGK KMNXGOPKMUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x28EDFA0", Offset = "0x28ECBA0", VA = "0x1828EDFA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static JFWWKSXUUGK EETCULMSLUB
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x28ED880", Offset = "0x28EC480", VA = "0x1828ED880")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static TENELWVUMZX DCCMPQBFDLR
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x28EE1E0", Offset = "0x28ECDE0", VA = "0x1828EE1E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static TENELWVUMZX RPKENEOMUFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28EDCD0", Offset = "0x28EC8D0", VA = "0x1828EDCD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static TENELWVUMZX JPFVABAPPLV
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x28ECB60", Offset = "0x28EB760", VA = "0x1828ECB60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static TENELWVUMZX UXRKWFTMIZB
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x28EB500", Offset = "0x28EA100", VA = "0x1828EB500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static TENELWVUMZX OMCXMTZSALB
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x28ECD30", Offset = "0x28EB930", VA = "0x1828ECD30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static TENELWVUMZX KDFDICNQSKY
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x28EBD20", Offset = "0x28EA920", VA = "0x1828EBD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static TENELWVUMZX FYGZZCAIHKO
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x28EAD60", Offset = "0x28E9960", VA = "0x1828EAD60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static TENELWVUMZX XFIFXWSDTAI
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x28EDF50", Offset = "0x28ECB50", VA = "0x1828EDF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static TENELWVUMZX WTRSSQSDVVF
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x28ED910", Offset = "0x28EC510", VA = "0x1828ED910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static TENELWVUMZX EGBMELXIKYH
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x28EBB20", Offset = "0x28EA720", VA = "0x1828EBB20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static TENELWVUMZX ZNTIXRQOUII
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x28EB0E0", Offset = "0x28E9CE0", VA = "0x1828EB0E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static TENELWVUMZX UXPYGXGJLJS
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x28EA550", Offset = "0x28E9150", VA = "0x1828EA550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static TENELWVUMZX NWWTIEBGXOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x28EBD70", Offset = "0x28EA970", VA = "0x1828EBD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static TENELWVUMZX CBUUTMJNVNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x28ED700", Offset = "0x28EC300", VA = "0x1828ED700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static TENELWVUMZX MABFZUGFXWN
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x28EAE70", Offset = "0x28E9A70", VA = "0x1828EAE70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static TENELWVUMZX LICUKUWPQKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x28ECDE0", Offset = "0x28EB9E0", VA = "0x1828ECDE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static TENELWVUMZX DDLJWPAQVPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x28EE180", Offset = "0x28ECD80", VA = "0x1828EE180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static TENELWVUMZX MGLRXCTBIPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x28EB320", Offset = "0x28E9F20", VA = "0x1828EB320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static TENELWVUMZX HLXKXZMUUAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x28ECBB0", Offset = "0x28EB7B0", VA = "0x1828ECBB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static TENELWVUMZX SCPPHRGSXMS
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x28ECA40", Offset = "0x28EB640", VA = "0x1828ECA40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static TENELWVUMZX PNGHPHYLTTN
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x28ECFF0", Offset = "0x28EBBF0", VA = "0x1828ECFF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static TENELWVUMZX FXJPWVDSAHY
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x28EB380", Offset = "0x28E9F80", VA = "0x1828EB380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static TENELWVUMZX YSQARQYOMAU
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x28EBA00", Offset = "0x28EA600", VA = "0x1828EBA00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static TENELWVUMZX YZTQMMGZEXS
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x28ED050", Offset = "0x28EBC50", VA = "0x1828ED050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static TENELWVUMZX JUUUUPBJKBO
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x28EA6F0", Offset = "0x28E92F0", VA = "0x1828EA6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static TENELWVUMZX LJJRDBCMHGL
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x28ECC70", Offset = "0x28EB870", VA = "0x1828ECC70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static TENELWVUMZX VSTPZBMUCVY
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x28EBA60", Offset = "0x28EA660", VA = "0x1828EBA60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static TENELWVUMZX YQRALAPPSMC
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x28EB080", Offset = "0x28E9C80", VA = "0x1828EB080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static TENELWVUMZX DYYNHYSCGHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x28EB700", Offset = "0x28EA300", VA = "0x1828EB700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static TENELWVUMZX AVCNVXUFWGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x28EA690", Offset = "0x28E9290", VA = "0x1828EA690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static TENELWVUMZX GXIMVKAEKJT
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x28EBAC0", Offset = "0x28EA6C0", VA = "0x1828EBAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static TENELWVUMZX GLQWADULHAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x28EAC40", Offset = "0x28E9840", VA = "0x1828EAC40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static TENELWVUMZX TLEAJTBSMPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x28ED520", Offset = "0x28EC120", VA = "0x1828ED520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static TENELWVUMZX VIBUBCKHEPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x28EB5E0", Offset = "0x28EA1E0", VA = "0x1828EB5E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static TENELWVUMZX EQIIZMBVSTR
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x28EB880", Offset = "0x28EA480", VA = "0x1828EB880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static TENELWVUMZX VXIITYPNRUF
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x28ED7C0", Offset = "0x28EC3C0", VA = "0x1828ED7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static TENELWVUMZX TNLFFLRVCWL
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x28EAAD0", Offset = "0x28E96D0", VA = "0x1828EAAD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static TENELWVUMZX USHMOLDRPWK
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x28EE290", Offset = "0x28ECE90", VA = "0x1828EE290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static TENELWVUMZX ARCAZEMUTDK
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x28EC2D0", Offset = "0x28EAED0", VA = "0x1828EC2D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static TENELWVUMZX CHANITECJHD
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x28EC980", Offset = "0x28EB580", VA = "0x1828EC980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static TENELWVUMZX DMLIAWMDHRP
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x28EB820", Offset = "0x28EA420", VA = "0x1828EB820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static TENELWVUMZX HFZUXXUOGAV
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x28EAF90", Offset = "0x28E9B90", VA = "0x1828EAF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static TENELWVUMZX ETHYCJTAIJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x28EADB0", Offset = "0x28E99B0", VA = "0x1828EADB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static TENELWVUMZX SZAQXVEOLMY
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x28EAF30", Offset = "0x28E9B30", VA = "0x1828EAF30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static TENELWVUMZX FBMJEITHJKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x28EB760", Offset = "0x28EA360", VA = "0x1828EB760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static TENELWVUMZX UBJXMPZOATV
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x28EAE10", Offset = "0x28E9A10", VA = "0x1828EAE10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static TENELWVUMZX VWAGPHQSKMV
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x28EA630", Offset = "0x28E9230", VA = "0x1828EA630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static TENELWVUMZX ACYWHBBVOOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x28EBB70", Offset = "0x28EA770", VA = "0x1828EBB70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static TENELWVUMZX TBGVDMTZOEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x28ED110", Offset = "0x28EBD10", VA = "0x1828ED110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static TENELWVUMZX CHNZCSSOJNL
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x28ED640", Offset = "0x28EC240", VA = "0x1828ED640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static TENELWVUMZX GINHGUIPMRN
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x28EBCC0", Offset = "0x28EA8C0", VA = "0x1828EBCC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static TENELWVUMZX OEWFYLGTLMB
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x28ED170", Offset = "0x28EBD70", VA = "0x1828ED170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static TENELWVUMZX MXKGAFCPLAK
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x28EB2C0", Offset = "0x28E9EC0", VA = "0x1828EB2C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static TENELWVUMZX KLOMEXAXIMJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x28EC730", Offset = "0x28EB330", VA = "0x1828EC730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static TENELWVUMZX BYYFFHQMBTS
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x28ECB00", Offset = "0x28EB700", VA = "0x1828ECB00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static TENELWVUMZX WXQTKKTBDII
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x28E9FD0", Offset = "0x28E8BD0", VA = "0x1828E9FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static TENELWVUMZX XEGVLBWVDQO
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x28ECC10", Offset = "0x28EB810", VA = "0x1828ECC10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static TENELWVUMZX HVASEWORKZY
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x28EAD00", Offset = "0x28E9900", VA = "0x1828EAD00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static TENELWVUMZX UNLULDQSKEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x28ED0B0", Offset = "0x28EBCB0", VA = "0x1828ED0B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static TENELWVUMZX GARBUCANZJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x28EB9A0", Offset = "0x28EA5A0", VA = "0x1828EB9A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static TENELWVUMZX CRDUBVHRQML
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x28EC8C0", Offset = "0x28EB4C0", VA = "0x1828EC8C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static TENELWVUMZX DTNPOFBJFYD
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x28EB3E0", Offset = "0x28E9FE0", VA = "0x1828EB3E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static TENELWVUMZX XZYFWPVWCGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x28EE030", Offset = "0x28ECC30", VA = "0x1828EE030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static TENELWVUMZX UDPIEBAPBXP
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x28ED2E0", Offset = "0x28EBEE0", VA = "0x1828ED2E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static TENELWVUMZX FTCWCOEAYWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x28ECED0", Offset = "0x28EBAD0", VA = "0x1828ECED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static TENELWVUMZX GGKPDGSLASU
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x28EDDD0", Offset = "0x28EC9D0", VA = "0x1828EDDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static TENELWVUMZX IKFMKFXEMVQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x28EC610", Offset = "0x28EB210", VA = "0x1828EC610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static TENELWVUMZX XEYCZRFVZDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x28ED820", Offset = "0x28EC420", VA = "0x1828ED820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static TENELWVUMZX UOREWMYHINT
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x28EDE90", Offset = "0x28ECA90", VA = "0x1828EDE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static TENELWVUMZX GFJBGWLNPQH
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x28EAED0", Offset = "0x28E9AD0", VA = "0x1828EAED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static TENELWVUMZX DUGVIHOKMHN
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x28EABE0", Offset = "0x28E97E0", VA = "0x1828EABE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static TENELWVUMZX PYLCJWIXSBO
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x28EBDC0", Offset = "0x28EA9C0", VA = "0x1828EBDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static TENELWVUMZX JADBCAMEKNN
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x28EC800", Offset = "0x28EB400", VA = "0x1828EC800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static TENELWVUMZX WNZOKYZVJYD
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x28EB7C0", Offset = "0x28EA3C0", VA = "0x1828EB7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static TENELWVUMZX FVPTQIZDJSC
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x28ED430", Offset = "0x28EC030", VA = "0x1828ED430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static TENELWVUMZX UZGUXTNVQOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x28ECCD0", Offset = "0x28EB8D0", VA = "0x1828ECCD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static TENELWVUMZX CDLTPQZZWOV
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x28ED580", Offset = "0x28EC180", VA = "0x1828ED580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static TENELWVUMZX BCEFLJRUBVW
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x28EDE30", Offset = "0x28ECA30", VA = "0x1828EDE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static TENELWVUMZX NORBFCNAWJC
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x28ED960", Offset = "0x28EC560", VA = "0x1828ED960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static TENELWVUMZX IATHXZGOJTJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x28ECF90", Offset = "0x28EBB90", VA = "0x1828ECF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static TENELWVUMZX VYWBSPZFNEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x28EC210", Offset = "0x28EAE10", VA = "0x1828EC210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static TENELWVUMZX JKJRIGWVFJG
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x28EA0F0", Offset = "0x28E8CF0", VA = "0x1828EA0F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static TENELWVUMZX OUMGYNBTKVL
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x28EC9E0", Offset = "0x28EB5E0", VA = "0x1828EC9E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static TENELWVUMZX KJSLIVHLDFA
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x28EB4A0", Offset = "0x28EA0A0", VA = "0x1828EB4A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static TENELWVUMZX IVIPLXEDJQC
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x28EB440", Offset = "0x28EA040", VA = "0x1828EB440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static TENELWVUMZX LLWTRMOWDJO
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x28EC860", Offset = "0x28EB460", VA = "0x1828EC860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static TENELWVUMZX EHTPTBQPFSA
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x28EBC60", Offset = "0x28EA860", VA = "0x1828EBC60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static TENELWVUMZX DZFRCOLOOHQ
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x28ECF30", Offset = "0x28EBB30", VA = "0x1828ECF30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static TENELWVUMZX WESWYLRTYOF
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x28EB6A0", Offset = "0x28EA2A0", VA = "0x1828EB6A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static TENELWVUMZX QBLREDDGAQS
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x28EB8E0", Offset = "0x28EA4E0", VA = "0x1828EB8E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static TENELWVUMZX GACXMMFDDFR
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x28ECE40", Offset = "0x28EBA40", VA = "0x1828ECE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static TENELWVUMZX OJTVGSBUDXK
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x28ECAA0", Offset = "0x28EB6A0", VA = "0x1828ECAA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static TENELWVUMZX CYXNYVVDYWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x28EA090", Offset = "0x28E8C90", VA = "0x1828EA090")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static TENELWVUMZX GKLEVQYHIJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x28EE230", Offset = "0x28ECE30", VA = "0x1828EE230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static TENELWVUMZX NUZGEFOTYCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x28EC3F0", Offset = "0x28EAFF0", VA = "0x1828EC3F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static TENELWVUMZX OXYEWHMMJIT
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x28EA210", Offset = "0x28E8E10", VA = "0x1828EA210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static TENELWVUMZX YOZIDZGEXOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x28ED280", Offset = "0x28EBE80", VA = "0x1828ED280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static TENELWVUMZX OOFDQOIHPZF
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x28EC390", Offset = "0x28EAF90", VA = "0x1828EC390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static TENELWVUMZX FKEQRMSDVSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x28EB640", Offset = "0x28EA240", VA = "0x1828EB640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static TENELWVUMZX RDFYKTKQTQK
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x28ED6A0", Offset = "0x28EC2A0", VA = "0x1828ED6A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static TENELWVUMZX AXEHAAJWFPI
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x28ED9C0", Offset = "0x28EC5C0", VA = "0x1828ED9C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static TENELWVUMZX YREMNVZBCBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x28EACA0", Offset = "0x28E98A0", VA = "0x1828EACA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static TENELWVUMZX FBISKUPVBKG
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x28EBE20", Offset = "0x28EAA20", VA = "0x1828EBE20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static TENELWVUMZX ISOREFLVYUS
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x28EC6D0", Offset = "0x28EB2D0", VA = "0x1828EC6D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static TENELWVUMZX CYDSGVIYURF
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x28EA030", Offset = "0x28E8C30", VA = "0x1828EA030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static TENELWVUMZX TYKMEUFOFBQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x28EC920", Offset = "0x28EB520", VA = "0x1828EC920")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static TENELWVUMZX BZTIFHZMUFX
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x28EB130", Offset = "0x28E9D30", VA = "0x1828EB130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static TENELWVUMZX GJNJUUWSJMU
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x28ED5E0", Offset = "0x28EC1E0", VA = "0x1828ED5E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static TENELWVUMZX NDTNZXPUJTQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x28EC270", Offset = "0x28EAE70", VA = "0x1828EC270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static TENELWVUMZX JXRYROPAFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x28EC670", Offset = "0x28EB270", VA = "0x1828EC670")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static TENELWVUMZX XEOTUPAMDSX
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x28ED3D0", Offset = "0x28EBFD0", VA = "0x1828ED3D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static TENELWVUMZX NCNHYTTUHEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x28ECD80", Offset = "0x28EB980", VA = "0x1828ECD80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static TENELWVUMZX UTCOPSWPZYX
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x28EA1B0", Offset = "0x28E8DB0", VA = "0x1828EA1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static TENELWVUMZX HOLKAZFSCCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x28EC450", Offset = "0x28EB050", VA = "0x1828EC450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static TENELWVUMZX RUYQCYGIRJW
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x28EB940", Offset = "0x28EA540", VA = "0x1828EB940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static TENELWVUMZX SSTBXGBVDQK
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x28EC330", Offset = "0x28EAF30", VA = "0x1828EC330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static TENELWVUMZX TIDKRYWVXHE
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x28EDEF0", Offset = "0x28ECAF0", VA = "0x1828EDEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static TENELWVUMZX CUDDWSOGEYU
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x28ED760", Offset = "0x28EC360", VA = "0x1828ED760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static TENELWVUMZX ZALSGILPIWZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x28EA150", Offset = "0x28E8D50", VA = "0x1828EA150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x28EE090", Offset = "0x28ECC90", VA = "0x1828EE090")]
			public static EEBTCGHBHYR YQMCFOCYVGR([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x28EC4E0", Offset = "0x28EB0E0", VA = "0x1828EC4E0")]
			public static ClassFactoryTypeParams MBZOLVBXBPC(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28EC4B0", Offset = "0x28EB0B0", VA = "0x1828EC4B0")]
			public static ClassFactoryTypeParams MBZOLVBXBPC([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28ED1D0", Offset = "0x28EBDD0", VA = "0x1828ED1D0")]
			public static EEBTCGHBHYR RTHBHQXTKTN(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28ECEA0", Offset = "0x28EBAA0", VA = "0x1828ECEA0")]
			public static EEBTCGHBHYR QPGLDCQIGGG(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28EB190", Offset = "0x28E9D90", VA = "0x1828EB190")]
			public static EEBTCGHBHYR ETSBHJUQALW([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28EC160", Offset = "0x28EAD60", VA = "0x1828EC160")]
			public static JFWWKSXUUGK KVPKREGPNJK(Id32<KYBGCQJEFUS> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x28EC590", Offset = "0x28EB190", VA = "0x1828EC590")]
			public static string MLEEWJCOOCH(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28EBE80", Offset = "0x28EAA80", VA = "0x1828EBE80")]
			private static JFWWKSXUUGK KVPKREGPNJK(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28EC790", Offset = "0x28EB390", VA = "0x1828EC790")]
			public static Id32<KYBGCQJEFUS>? NJYQVYIOBTH(JFWWKSXUUGK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x28EA750", Offset = "0x28E9350", VA = "0x1828EA750")]
			public static CircuitTypeIdWrapper? CHTZXPQNFNS(JFWWKSXUUGK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x28EE3A0", Offset = "0x28ECFA0", VA = "0x1828EE3A0")]
			static UQXGZRWETRS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x28EAB30", Offset = "0x28E9730", VA = "0x1828EAB30")]
			[IteratorStateMachine(typeof(OXFXTLORGKF))]
			private static IEnumerable<JFWWKSXUUGK> COEKZEYKWAE(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x28EE2F0", Offset = "0x28ECEF0", VA = "0x1828EE2F0")]
			[IteratorStateMachine(typeof(CEGTAEUMQEL))]
			public static IEnumerable<JFWWKSXUUGK> ZSRCKSHYBAV(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x28EDA20", Offset = "0x28EC620", VA = "0x1828EDA20")]
			public static Variant VXZRGNROGMC(JFWWKSXUUGK a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x28EA270", Offset = "0x28E8E70", VA = "0x1828EA270")]
			public static Variant BARPHJBSRYT(JFWWKSXUUGK a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x28ED200", Offset = "0x28EBE00", VA = "0x1828ED200")]
			public static bool RZSRHUUWGNT(JFWWKSXUUGK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x28EDD20", Offset = "0x28EC920", VA = "0x1828EDD20")]
			[IteratorStateMachine(typeof(AHWQPVLWJCW))]
			public static IEnumerable<Id32<KYBGCQJEFUS>> WXXIEUMUXYX(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QBCXEYSCHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28E7470", Offset = "0x28E6070", VA = "0x1828E7470")]
		public static JTTBAVZDNEC DKWNNTIDYNZ(this JFWWKSXUUGK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28E8560", Offset = "0x28E7160", VA = "0x1828E8560")]
		public static JFWWKSXUUGK RIPHTNDVABI(this JTTBAVZDNEC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class OAUZFGZRJZK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x38A9360", Offset = "0x38A7F60", VA = "0x1838A9360")]
		public static Dictionary<b, c> UANBUALJNDE<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class TLXUHVCINFV
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28E9350", Offset = "0x28E7F50", VA = "0x1828E9350")]
		public static FRJVAZTPOGW DKWNNTIDYNZ([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28E9450", Offset = "0x28E8050", VA = "0x1828E9450")]
		public static Guid RIPHTNDVABI(FRJVAZTPOGW a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class AXEYQAQCKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x28DA230", Offset = "0x28D8E30", VA = "0x1828DA230")]
		public static LHTVIAJIHCQ DKWNNTIDYNZ([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28DA2C0", Offset = "0x28D8EC0", VA = "0x1828DA2C0")]
		public static NamedType RIPHTNDVABI(this LHTVIAJIHCQ a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class TNWKOAULTBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A82A80", Offset = "0x3A81680", VA = "0x183A82A80")]
		public static void MTVDXWFTIZS<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A82CE0", Offset = "0x3A818E0", VA = "0x183A82CE0")]
		public static void MTVDXWFTIZS<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class ZEXBWMQPUCR
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28FA4F0", Offset = "0x28F90F0", VA = "0x1828FA4F0")]
		public static CNZTBOLWPUM DKWNNTIDYNZ([In] this Variant self, JFWWKSXUUGK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28FA6F0", Offset = "0x28F92F0", VA = "0x1828FA6F0")]
		public static Variant RIPHTNDVABI(this CNZTBOLWPUM a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class JOQKICWOKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<HKZSYIQINUF> YZLSDRBRAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool NZDQFJYOVXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool TFJEQSDMOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool VAFFCIVVANY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool WTCHESDYUAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool WTHOBYXWDLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool VBHOOQOOONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool MYJEMPUNOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool SGCNDSTYFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, JFWWKSXUUGK Type)> MZTQUJRCWJT;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid HSLXDBEEAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x28A1060", Offset = "0x289FC60", VA = "0x1828A1060")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<HKZSYIQINUF> TPEFEWBTUQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x28A1060", Offset = "0x289FC60", VA = "0x1828A1060")]
			get
			{
				return default(Id128<HKZSYIQINUF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xA98370", Offset = "0xA96F70", VA = "0x180A98370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, JFWWKSXUUGK Type)> DSSAEWPFINS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action QPWDFXJEMFV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x28DD250", Offset = "0x28DBE50", VA = "0x1828DD250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x28DDB50", Offset = "0x28DC750", VA = "0x1828DDB50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, JFWWKSXUUGK> NOPLHNPEXLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x28DDAA0", Offset = "0x28DC6A0", VA = "0x1828DDAA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x28DD820", Offset = "0x28DC420", VA = "0x1828DD820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> HBNMWPCPRLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x28DD3E0", Offset = "0x28DBFE0", VA = "0x1828DD3E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28DD8D0", Offset = "0x28DC4D0", VA = "0x1828DD8D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> HAVQFHRDHYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x28DD1A0", Offset = "0x28DBDA0", VA = "0x1828DD1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x28DD580", Offset = "0x28DC180", VA = "0x1828DD580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, JFWWKSXUUGK> QECBCKMAOLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x28DCCF0", Offset = "0x28DB8F0", VA = "0x1828DCCF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x28DCDA0", Offset = "0x28DB9A0", VA = "0x1828DCDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action PSQXXYORRNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x28DD780", Offset = "0x28DC380", VA = "0x1828DD780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x28DCE50", Offset = "0x28DBA50", VA = "0x1828DCE50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x18D5220", Offset = "0x18D3E20", VA = "0x1818D5220")]
		public void OQDPBVNDYYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28DDBF0", Offset = "0x28DC7F0", VA = "0x1828DDBF0")]
		internal JOQKICWOKBB([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, JFWWKSXUUGK Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28DD630", Offset = "0x28DC230", VA = "0x1828DD630")]
		public static CircuitEventDefinitionFactoryStart QMWBYPAHZIM(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x28DD700", Offset = "0x28DC300", VA = "0x1828DD700")]
		public static CircuitEventDefinitionFactoryStart QMWBYPAHZIM(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x28DCAE0", Offset = "0x28DB6E0", VA = "0x1828DCAE0")]
		public static JOQKICWOKBB CSWZBFTKFTK([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28DCEF0", Offset = "0x28DBAF0", VA = "0x1828DCEF0")]
		public static JOQKICWOKBB FAULQUZUVDU([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xBB1000", Offset = "0xBAFC00", VA = "0x180BB1000")]
		public void UQTLMEAZORQ(Id128<HKZSYIQINUF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28DCA80", Offset = "0x28DB680", VA = "0x1828DCA80")]
		public void BXFJIJUVOTX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28DD2F0", Offset = "0x28DBEF0", VA = "0x1828DD2F0")]
		public void JEWEXCOHSCR(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28DD490", Offset = "0x28DC090", VA = "0x1828DD490")]
		public void KKLIVVZQTES(int a, JFWWKSXUUGK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28DD980", Offset = "0x28DC580", VA = "0x1828DD980")]
		public void UYLWEFEZHIW(string a, JFWWKSXUUGK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28DD130", Offset = "0x28DBD30", VA = "0x1828DD130")]
		public void FIDQQZXGIHJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28DCBF0", Offset = "0x28DB7F0", VA = "0x1828DCBF0")]
		public JOQKICWOKBB Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x28DB100", Offset = "0x28D9D00", VA = "0x1828DB100")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28DAE60", Offset = "0x28D9A60", VA = "0x1828DAE60")]
		public CircuitEventDefinitionFactoryParams XUDRGPMUOCI(string a, JFWWKSXUUGK b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28DAFD0", Offset = "0x28D9BD0", VA = "0x1828DAFD0")]
		public JOQKICWOKBB ZXGWLXXUFYA()
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
		private readonly List<(string Name, JFWWKSXUUGK Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28DADD0", Offset = "0x28D99D0", VA = "0x1828DADD0")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, JFWWKSXUUGK Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28DABA0", Offset = "0x28D97A0", VA = "0x1828DABA0")]
		public CircuitEventDefinitionFactoryParams XUDRGPMUOCI(string a, JFWWKSXUUGK b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28DACD0", Offset = "0x28D98D0", VA = "0x1828DACD0")]
		public JOQKICWOKBB ZXGWLXXUFYA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class YKPSYARYXIE
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly JOQKICWOKBB WZOETXKHFRD;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly JOQKICWOKBB BLZBWKDBVBA;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly JOQKICWOKBB CTSIQCORICJ;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly JOQKICWOKBB HPDARUPEBJQ;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly JOQKICWOKBB EZUSLDEATVL;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly JOQKICWOKBB RPTFAVWBBQB;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly JOQKICWOKBB HXWTUYNAQLY;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly JOQKICWOKBB[] LRBNYXPUUTB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class TBBFVLARQJB
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly JOQKICWOKBB MJNIXNZSVGZ;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class ZAVLBILLTEG
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly JOQKICWOKBB WLVKYPOAXQX;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly JOQKICWOKBB JNWYREQWNCI;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class WREBMMYPDNB
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly JOQKICWOKBB NMOCULEQCWA;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly JOQKICWOKBB VIHPBYWEICR;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly JOQKICWOKBB[] YSOXAWTUKCP;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly JOQKICWOKBB TJXZUGLRECP;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly JOQKICWOKBB VPEBUVSAIPU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class GYAYRLXSYCD
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly JOQKICWOKBB FSUFNQJBPLY;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly JOQKICWOKBB CWTWVZKOVOL;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class WCYYHBKOAPW
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly JOQKICWOKBB NRJLLACVJFJ;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly JOQKICWOKBB OQEVIBPOQTE;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class CJDZXDBCOTZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly JOQKICWOKBB WLVKYPOAXQX;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly JOQKICWOKBB JNWYREQWNCI;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class VPKAIZWNIKD
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly JOQKICWOKBB XPCPLHFAIPM;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly JOQKICWOKBB OCHKTSBYURH;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly JOQKICWOKBB MXARMWYVGAL;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly JOQKICWOKBB TGKPKSYOQSP;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly JOQKICWOKBB IHSUVMZLOII;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly JOQKICWOKBB SNFUPPWSSMB;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly JOQKICWOKBB MLSYWVZXJVG;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class XRTRPSLDDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class JYFXYZOLKHV
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class QFNDQVHMRAX
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class ODYVVZFMMHF
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly JOQKICWOKBB QPGHOALLRIQ;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly JOQKICWOKBB CFLJRJENPYB;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class IDOQTRXGJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class SMFMSEXCSST
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class KLIXWFMMPAZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class EKFEBCJTYNY
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly JOQKICWOKBB WQFUCYRVQTC;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly JOQKICWOKBB BOKVCQLLCGU;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly JOQKICWOKBB JBJDNVUDMAR;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly JOQKICWOKBB FPTUQXZSMSC;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly JOQKICWOKBB PHPVHEDUAGW;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly JOQKICWOKBB NRJLLACVJFJ;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly JOQKICWOKBB COBTHDXBBGS;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly JOQKICWOKBB UJSMGOKPSDV;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly JOQKICWOKBB EPBPPEERGSN;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly JOQKICWOKBB DHMZZGSUPJB;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly JOQKICWOKBB THCBFTAXKEJ;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly JOQKICWOKBB XCUHONYNVYL;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly JOQKICWOKBB BZTUQOZHINS;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly JOQKICWOKBB RUSLLLWZVHT;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly JOQKICWOKBB XAZIEQMYUUU;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly JOQKICWOKBB IYTRAXFGQPK;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly JOQKICWOKBB SZYGEQEQJQC;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly JOQKICWOKBB NPXYKXRPLNF;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly JOQKICWOKBB VWKFMUMZZIO;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly JOQKICWOKBB HTDAHCTLKDG;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly JOQKICWOKBB SXHBKGUSTDB;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly JOQKICWOKBB BBZMFHQOCPB;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly JOQKICWOKBB WPQNGJMUKPJ;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly JOQKICWOKBB BOCBRTDOBXB;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly JOQKICWOKBB GMDBQAJVMHH;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly JOQKICWOKBB XNJOAUXKOIZ;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly JOQKICWOKBB EODECVWFSVL;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly JOQKICWOKBB PPSTWWXMXWB;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly JOQKICWOKBB QLDSKZNVXLS;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly JOQKICWOKBB HNUQDEBSBTC;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly JOQKICWOKBB RVWXISUMQVD;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly JOQKICWOKBB IXDJTNIBSWV;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly JOQKICWOKBB ULJLMHVSRFK;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly JOQKICWOKBB SPVQHDKGYIQ;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly JOQKICWOKBB FPKNNEUQFZS;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly JOQKICWOKBB OSMHGRXPAUA;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly JOQKICWOKBB BSBEMTHYILC;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly JOQKICWOKBB FCUOUFFRWXQ;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly JOQKICWOKBB GHWAKVMMNAO;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly JOQKICWOKBB XDGHUUXWTFE;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly JOQKICWOKBB OFVYZFNPYIB;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly JOQKICWOKBB ECPHXLYRXSZ;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly JOQKICWOKBB ITRJHPWEBET;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly JOQKICWOKBB ZPUSPDRZFKZ;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly JOQKICWOKBB CYKTSGCYRXV;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly JOQKICWOKBB LLAQRWZPGCT;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly JOQKICWOKBB EXOAAYFCKXL;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly JOQKICWOKBB SGJDGUMTZPZ;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly JOQKICWOKBB CXDURQGWYOZ;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly JOQKICWOKBB LEXFKIJXITR;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly JOQKICWOKBB BMUCIHLVHZY;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly JOQKICWOKBB TLKOBSJRMUJ;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly JOQKICWOKBB YFRPZAQDLCZ;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly JOQKICWOKBB MQTUABYVPKV;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly JOQKICWOKBB BBJDOANHBTF;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly JOQKICWOKBB SXRCPGWLURH;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly JOQKICWOKBB RDXHXAWDOZV;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly JOQKICWOKBB FXESGSQKIEP;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly JOQKICWOKBB YOLRATJLQMJ;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly JOQKICWOKBB DDIKOQDVDCD;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly JOQKICWOKBB QKXJQNRONEZ;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly JOQKICWOKBB JONOVVLWWUH;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly JOQKICWOKBB FVCMDWYUMBA;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly JOQKICWOKBB IWRCBFYCZMB;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly JOQKICWOKBB WKRUNFAEHRH;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly JOQKICWOKBB ZTDURPKMZSU;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly JOQKICWOKBB YUNEQMHMXMU;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly JOQKICWOKBB OBRYMIYDBVB;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly JOQKICWOKBB BFQHRDHJUQD;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class SQHROFHPBHK
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class FOIKGWMJJNH
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly JOQKICWOKBB FXATCTTVKNF;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly JOQKICWOKBB UDYKMREXIQE;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly JOQKICWOKBB TTRICWTYOAM;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly JOQKICWOKBB WKNWUSJBSLR;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly JOQKICWOKBB SZTQHEVTJMP;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly JOQKICWOKBB BNALXXTBOMB;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly JOQKICWOKBB NMLWJDPIFPZ;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class KXQPYHPCJDK
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly JOQKICWOKBB BOKVCQLLCGU;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly JOQKICWOKBB JBJDNVUDMAR;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly JOQKICWOKBB FPTUQXZSMSC;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly JOQKICWOKBB XFQGMCINIJC;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly JOQKICWOKBB XRCDQKSPUME;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly JOQKICWOKBB UGBUIFUYLGE;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly JOQKICWOKBB PSVRMPZUIGM;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class KLSUNJPAQLA
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly JOQKICWOKBB GZOAPRUJDBE;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly JOQKICWOKBB EXWVLDNELWI;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly JOQKICWOKBB SOCWBRNHGNL;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly JOQKICWOKBB XUJTSCYHZVF;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly JOQKICWOKBB LDHXXLOYLEB;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly JOQKICWOKBB YGHOMWGWUJT;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class NSHXPCAJEER
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class RJXZXXJVPNK
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly JOQKICWOKBB VZVHDCPVJVU;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class XRCFSSMZLFY
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly JOQKICWOKBB WQFUCYRVQTC;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class VQMNFAQOKTH
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class JZPOCMEVHZQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class LJDJJEZLGDR
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly JOQKICWOKBB HUJVZHTHRKZ;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly JOQKICWOKBB ZLVJURKYVBV;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly JOQKICWOKBB QHWGQZFLTFU;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly JOQKICWOKBB OBNXHJROLBI;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class TLEMQPZDUMV
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly JOQKICWOKBB HAPIIBWKUBQ;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly JOQKICWOKBB OWYVBLFPRZF;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class KHQZCIZTNDX
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class JPEKDEQMPDH
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly JOQKICWOKBB FXATCTTVKNF;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly JOQKICWOKBB UDYKMREXIQE;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class IUXBXZHNWEG
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly JOQKICWOKBB OVHEXSYGGIJ;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly JOQKICWOKBB WKNWUSJBSLR;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly JOQKICWOKBB SZTQHEVTJMP;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly JOQKICWOKBB BNALXXTBOMB;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly JOQKICWOKBB URWTIBXGQRQ;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly JOQKICWOKBB WWQOJTITTPN;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly JOQKICWOKBB IXEDJPFMXEH;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly JOQKICWOKBB BPDSIGQHIEN;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly JOQKICWOKBB MNNQZRULCIG;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly JOQKICWOKBB EQPLJOIBXFQ;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly JOQKICWOKBB FXATCTTVKNF;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly JOQKICWOKBB UDYKMREXIQE;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class GYEORKDMAHQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class EOMCRXFJSLM
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly JOQKICWOKBB FXATCTTVKNF;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly JOQKICWOKBB UDYKMREXIQE;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly JOQKICWOKBB HKDFEEKYLDS;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly JOQKICWOKBB NAYMVGFNJTU;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly JOQKICWOKBB HCRYIBNIXZX;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class ICYNGJEAWXH
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class PKJYDLXGYYU
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly JOQKICWOKBB CSIZZHSXCFX;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class XUQORQFBEOQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly JOQKICWOKBB QKPEEYFYVQU;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly JOQKICWOKBB CFPWBSZUIUV;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly JOQKICWOKBB FXATCTTVKNF;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly JOQKICWOKBB UDYKMREXIQE;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class NHTLUCAKFKT
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class LHHCRYPTKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class YYHAGSECIYY
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class SSEUXBKHJCU
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class GGEPUHNWXMZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class ZGTKZUKMWDH
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly JOQKICWOKBB QPGHOALLRIQ;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly JOQKICWOKBB CFLJRJENPYB;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class MPUDAAJZSLF
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly JOQKICWOKBB XJEUKKZQCOS;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly JOQKICWOKBB EKXLYUGZAVW;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly JOQKICWOKBB EDZJTMBLUQU;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly JOQKICWOKBB WXIGSYYHUTE;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class MZMCMOEAVPW
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly JOQKICWOKBB XJEUKKZQCOS;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly JOQKICWOKBB EKXLYUGZAVW;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly JOQKICWOKBB EDZJTMBLUQU;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly JOQKICWOKBB WXIGSYYHUTE;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class GIPJGAUYYLT
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class UITKRYIRUYS
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly JOQKICWOKBB VLATSJVGXMZ;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly JOQKICWOKBB BNNNBWDIKAP;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly JOQKICWOKBB SKGBRECCQPF;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class ZDVWXSJNKKX
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly JOQKICWOKBB UDXNHVEIIVG;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly JOQKICWOKBB WXPGVCBXOCS;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly JOQKICWOKBB TSDACHWODHV;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class KROMREIYDRU
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class QNTGZSSQWRF
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly JOQKICWOKBB OKZBVGSCVKX;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly JOQKICWOKBB ZTVQCJQETXH;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly JOQKICWOKBB IQUDSWTMJFU;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly JOQKICWOKBB TRHDAUAVBWW;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly JOQKICWOKBB OYQCDBBWHUX;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class GFROFLNQGRA
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly JOQKICWOKBB HMOEKOVOHXN;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class LEUQEOSGROM
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly JOQKICWOKBB NMTBGTFGWLI;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly JOQKICWOKBB PQPAKSOXRIP;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly JOQKICWOKBB JLZUSMNVUZM;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class TVKYQAEDJUJ
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class VWDSIQQENFX
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class KESGEUDWUTC
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class AKWIWVHXPUH
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly JOQKICWOKBB AZLACJJKQHG;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly JOQKICWOKBB AESHQGNNITT;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly JOQKICWOKBB PDQKUKXBKXR;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly JOQKICWOKBB XHEQQASLZGX;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly JOQKICWOKBB RJJOCJAUARS;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly JOQKICWOKBB AUOUWOMMYXI;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly JOQKICWOKBB ZLRVUZMPMCB;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class WAAPQUCMTJN
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly JOQKICWOKBB CRFIOOYXFZA;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly JOQKICWOKBB[] CIFRYZLXCPM;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class FDXVJGFJAZL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly JFWWKSXUUGK CZPJJEEECUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<JOQKICWOKBB> EAXULALYENU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<JOQKICWOKBB> ZESWWLFNBRT;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<JOQKICWOKBB> EITZNAWFHOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<JOQKICWOKBB> TQJVHVXKDYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x28FC660", Offset = "0x28FB260", VA = "0x1828FC660")]
		protected FDXVJGFJAZL(JFWWKSXUUGK a, params JOQKICWOKBB[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NLAFDQLNAID : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2905450", Offset = "0x2904050", VA = "0x182905450")]
		internal NLAFDQLNAID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ZIZTSTUZPFG : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x290BC90", Offset = "0x290A890", VA = "0x18290BC90")]
		internal ZIZTSTUZPFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class TQULHRFFGHJ : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2908050", Offset = "0x2906C50", VA = "0x182908050")]
		internal TQULHRFFGHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class LKXCXTABEAI : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2903960", Offset = "0x2902560", VA = "0x182903960")]
		internal LKXCXTABEAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class XBXPPBNCBMP : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2909E50", Offset = "0x2908A50", VA = "0x182909E50")]
		internal XBXPPBNCBMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class CJLWLNMABTN : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x28FB5D0", Offset = "0x28FA1D0", VA = "0x1828FB5D0")]
		internal CJLWLNMABTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class NMXMRUKRYLU : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2905630", Offset = "0x2904230", VA = "0x182905630")]
		internal NMXMRUKRYLU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class LQXABFRYRVN : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2903D20", Offset = "0x2902920", VA = "0x182903D20")]
		internal LQXABFRYRVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class JNAIMBAAXFV : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x28FFF50", Offset = "0x28FEB50", VA = "0x1828FFF50")]
		internal JNAIMBAAXFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class PXDHMFMFMPR : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2905FA0", Offset = "0x2904BA0", VA = "0x182905FA0")]
		internal PXDHMFMFMPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class BIEDRAFSUKD : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x28FAE50", Offset = "0x28F9A50", VA = "0x1828FAE50")]
		internal BIEDRAFSUKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class WNWVYIDCZVR : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2909660", Offset = "0x2908260", VA = "0x182909660")]
		internal WNWVYIDCZVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class MHEALVUUVDF : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x29040E0", Offset = "0x2902CE0", VA = "0x1829040E0")]
		internal MHEALVUUVDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class USAKCHGGAFL : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x29088D0", Offset = "0x29074D0", VA = "0x1829088D0")]
		internal USAKCHGGAFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class HMFZCNCVEGJ : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x28FE4E0", Offset = "0x28FD0E0", VA = "0x1828FE4E0")]
		internal HMFZCNCVEGJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class HSZLAYVSFZV : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x28FE6C0", Offset = "0x28FD2C0", VA = "0x1828FE6C0")]
		internal HSZLAYVSFZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class XBIMSYDWGRP : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2909C70", Offset = "0x2908870", VA = "0x182909C70")]
		internal XBIMSYDWGRP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class NIZSUBSTVCQ : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2905270", Offset = "0x2903E70", VA = "0x182905270")]
		internal NIZSUBSTVCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class WCLBHSQEESW : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x29090C0", Offset = "0x2907CC0", VA = "0x1829090C0")]
		internal WCLBHSQEESW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class WWOLKMDZEKA : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2909840", Offset = "0x2908440", VA = "0x182909840")]
		internal WWOLKMDZEKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class TNOITIPLBPI : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2907B90", Offset = "0x2906790", VA = "0x182907B90")]
		internal TNOITIPLBPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class TONVBJIBOFI : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2907DF0", Offset = "0x29069F0", VA = "0x182907DF0")]
		internal TONVBJIBOFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class WHTGUXHWXZD : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2909480", Offset = "0x2908080", VA = "0x182909480")]
		internal WHTGUXHWXZD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class WDUEQJWLSDY : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x29092A0", Offset = "0x2907EA0", VA = "0x1829092A0")]
		internal WDUEQJWLSDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ZCHYEWLWKGB : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x290ADA0", Offset = "0x29099A0", VA = "0x18290ADA0")]
		internal ZCHYEWLWKGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class TLHWVHDHITK : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x29079B0", Offset = "0x29065B0", VA = "0x1829079B0")]
		internal TLHWVHDHITK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class HXCJOLHLZNY : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x28FE8A0", Offset = "0x28FD4A0", VA = "0x1828FE8A0")]
		internal HXCJOLHLZNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class ZGQHOVBBLCM : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x290B6B0", Offset = "0x290A2B0", VA = "0x18290B6B0")]
		internal ZGQHOVBBLCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class BVMAPILYEFH : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x28FB030", Offset = "0x28F9C30", VA = "0x1828FB030")]
		internal BVMAPILYEFH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class RVXNJXNNHYQ : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2906F70", Offset = "0x2905B70", VA = "0x182906F70")]
		internal RVXNJXNNHYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class WZVESAFMZWT : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2909A20", Offset = "0x2908620", VA = "0x182909A20")]
		internal WZVESAFMZWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class EWSUTMZDXHX : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x28FC2A0", Offset = "0x28FAEA0", VA = "0x1828FC2A0")]
		internal EWSUTMZDXHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class IOYCEXROOIN : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x28FEEB0", Offset = "0x28FDAB0", VA = "0x1828FEEB0")]
		internal IOYCEXROOIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class HKVSFBWUILW : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x28FE280", Offset = "0x28FCE80", VA = "0x1828FE280")]
		internal HKVSFBWUILW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class HIZDGESEGGI : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x28FE0A0", Offset = "0x28FCCA0", VA = "0x1828FE0A0")]
		internal HIZDGESEGGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class LHNNLGTXADC : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2902E70", Offset = "0x2901A70", VA = "0x182902E70")]
		internal LHNNLGTXADC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class UVRKWRDGMBX : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x29089B0", Offset = "0x29075B0", VA = "0x1829089B0")]
		internal UVRKWRDGMBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class ZEPTLCQVUJA : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x290B450", Offset = "0x290A050", VA = "0x18290B450")]
		internal ZEPTLCQVUJA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class FOUHAGPBBNU : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x28FD100", Offset = "0x28FBD00", VA = "0x1828FD100")]
		internal FOUHAGPBBNU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class PUXWHAITVTN : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2905DC0", Offset = "0x29049C0", VA = "0x182905DC0")]
		internal PUXWHAITVTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class JRVRWNRISFR : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2900530", Offset = "0x28FF130", VA = "0x182900530")]
		internal JRVRWNRISFR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class BWACRWMYTVN : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x28FB210", Offset = "0x28F9E10", VA = "0x1828FB210")]
		internal BWACRWMYTVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class MJAPLPOOBVY : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x29042C0", Offset = "0x2902EC0", VA = "0x1829042C0")]
		internal MJAPLPOOBVY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class JTHHJYNODKS : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x29008F0", Offset = "0x28FF4F0", VA = "0x1829008F0")]
		internal JTHHJYNODKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class VOEHILFSWAR : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2908B90", Offset = "0x2907790", VA = "0x182908B90")]
		internal VOEHILFSWAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class RGTYEAXZGWY : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2906B20", Offset = "0x2905720", VA = "0x182906B20")]
		internal RGTYEAXZGWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class BYBAPKPOKEP : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x28FB3F0", Offset = "0x28F9FF0", VA = "0x1828FB3F0")]
		internal BYBAPKPOKEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class FBAQRFIFMWC : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x28FC480", Offset = "0x28FB080", VA = "0x1828FC480")]
		internal FBAQRFIFMWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class XQGEOIHZKOY : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x290A210", Offset = "0x2908E10", VA = "0x18290A210")]
		internal XQGEOIHZKOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class LLTVEDVUAQV : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2903B40", Offset = "0x2902740", VA = "0x182903B40")]
		internal LLTVEDVUAQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class LUYXCYOKTJL : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2903F00", Offset = "0x2902B00", VA = "0x182903F00")]
		internal LUYXCYOKTJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class XKQKNGPGYUA : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x290A030", Offset = "0x2908C30", VA = "0x18290A030")]
		internal XKQKNGPGYUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class DNGIIOOFWVH : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x28FB7B0", Offset = "0x28FA3B0", VA = "0x1828FB7B0")]
		internal DNGIIOOFWVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class ICNWWAINEFG : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x28FEA80", Offset = "0x28FD680", VA = "0x1828FEA80")]
		internal ICNWWAINEFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class SLVFQIQMQIK : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2907320", Offset = "0x2905F20", VA = "0x182907320")]
		internal SLVFQIQMQIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class FOUZOJDLJNM : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x28FD360", Offset = "0x28FBF60", VA = "0x1828FD360")]
		internal FOUZOJDLJNM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ZCESAQHXZPU : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x290ABC0", Offset = "0x29097C0", VA = "0x18290ABC0")]
		internal ZCESAQHXZPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class AVNNKALNEMJ : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x28FAC70", Offset = "0x28F9870", VA = "0x1828FAC70")]
		internal AVNNKALNEMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ILNFBBXEBUU : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28FECD0", Offset = "0x28FD8D0", VA = "0x1828FECD0")]
		internal ILNFBBXEBUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class JSRKBBYKNJU : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2900710", Offset = "0x28FF310", VA = "0x182900710")]
		internal JSRKBBYKNJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class GZUCPQVRMER : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x28FD900", Offset = "0x28FC500", VA = "0x1828FD900")]
		internal GZUCPQVRMER()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class RWYATHJAJTM : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2907150", Offset = "0x2905D50", VA = "0x182907150")]
		internal RWYATHJAJTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class IUCSUSYSDUH : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x28FF090", Offset = "0x28FDC90", VA = "0x1828FF090")]
		internal IUCSUSYSDUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class ZNNRNJUFDMI : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x290BDF0", Offset = "0x290A9F0", VA = "0x18290BDF0")]
		internal ZNNRNJUFDMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class ELULFZSMDQG : FDXVJGFJAZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x28FB990", Offset = "0x28FA590", VA = "0x1828FB990")]
		internal ELULFZSMDQG()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, GBMNYUSYUQI<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly JFWWKSXUUGK Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
		private NamedType(string name, JFWWKSXUUGK type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2839A60", Offset = "0x2838660", VA = "0x182839A60")]
		public static NamedType New(string name, JFWWKSXUUGK type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2905880", Offset = "0x2904480", VA = "0x182905880")]
		public static bool OKWKXGGAXFT([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2905880", Offset = "0x2904480", VA = "0x182905880", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2905880", Offset = "0x2904480", VA = "0x182905880")]
		public bool BQMHWPIWXMR([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x29058D0", Offset = "0x29044D0", VA = "0x1829058D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2905990", Offset = "0x2904590", VA = "0x182905990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2905AC0", Offset = "0x29046C0", VA = "0x182905AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2905A00", Offset = "0x2904600", VA = "0x182905A00")]
		public string JSORZUQMREV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2905A40", Offset = "0x2904640", VA = "0x182905A40")]
		public string KZXYMWOPLFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2905880", Offset = "0x2904480", VA = "0x182905880", Slot = "5")]
		private bool VHQQVOAYZVO([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface BOOLTIYANOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(NOYQGYRQTEZ a, bool b);
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
