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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3F220", Offset = "0x2B3D820", VA = "0x182B3F220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3F1A0", Offset = "0x2B3D7A0", VA = "0x182B3F1A0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RQXLKNYJBVA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B463A0", Offset = "0x2B449A0", VA = "0x182B463A0")]
		public static bool FFWTGVWSHAR(this WPCWYXTKXZN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B462E0", Offset = "0x2B448E0", VA = "0x182B462E0")]
		public static bool FFWTGVWSHAR(this PKAKPCXWAYS a)
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
			private readonly MPBKAGBRDNH _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			public EVRequest(MPBKAGBRDNH staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class LQAVEEKLORO
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<AYDHTPPJUJR>, SIQLLRWEZBU> COEVRSNTQND;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<AYDHTPPJUJR>>? TXVVRBPBVXT;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<AYDHTPPJUJR> DXLETAJXIKX;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<AYDHTPPJUJR> BGQRKZYDMMM;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<AYDHTPPJUJR> YBCUJNFEMXV;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<AYDHTPPJUJR> ODNMARCJUJM;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<AYDHTPPJUJR> HQMKBECTBKP;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<AYDHTPPJUJR> CSOVCOAXSIA;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<AYDHTPPJUJR> EBDDXTQXQNY;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<AYDHTPPJUJR> WGOVLDBKBRU;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<AYDHTPPJUJR> LLOMPCUXKIW;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<AYDHTPPJUJR> XDDDFYIEFBE;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<AYDHTPPJUJR> DUBRVFHYFLO;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<AYDHTPPJUJR> HJPKFUSKOZO;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<AYDHTPPJUJR> NNFZKFFXRPD;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<AYDHTPPJUJR> SXOYPXUHZQL;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<AYDHTPPJUJR> BZFCNBLLOEX;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<AYDHTPPJUJR> GYDMDXFBMVO;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<AYDHTPPJUJR> JHMRTRAJSUH;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<AYDHTPPJUJR> HZJUKLUSQAV;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<AYDHTPPJUJR> YFRENRHVYFQ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<AYDHTPPJUJR> ABZLXFUNGDH;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<AYDHTPPJUJR> IRIDDBBPDAI;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<AYDHTPPJUJR> JYWQZKIGTMR;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<AYDHTPPJUJR> CHTXLHKWBUH;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<AYDHTPPJUJR> MSITVTEEDZK;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<AYDHTPPJUJR> JSXLQLWPTOQ;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<AYDHTPPJUJR> JRVFBTGXDKP;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<AYDHTPPJUJR> EQLYGBKWLSW;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<AYDHTPPJUJR> TEZPPRQMPWT;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<AYDHTPPJUJR> AMYWLLTMQNB;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<AYDHTPPJUJR> WYJUGWUXXJT;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<AYDHTPPJUJR> VXICJRIFDNF;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<AYDHTPPJUJR> NCMMRQHKXUG;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<AYDHTPPJUJR> ACCCSOMSJPD;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<AYDHTPPJUJR> NSMTYBEATET;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<AYDHTPPJUJR> FGJPHKWUFOH;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<AYDHTPPJUJR> CRJDMJKTUQM;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<AYDHTPPJUJR> HZYPBXSEPMN;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<AYDHTPPJUJR> KSCQWBKSKUW;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<AYDHTPPJUJR> LGSCKQFXJYC;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<AYDHTPPJUJR> EGFRPRVACNA;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<AYDHTPPJUJR> EIEFMZKSIFL;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<AYDHTPPJUJR> LUWETXEWNNX;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<AYDHTPPJUJR> TJIERWQHHPI;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<AYDHTPPJUJR> RKKVEGFYVMV;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<AYDHTPPJUJR> WHUSIHKPLDD;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<AYDHTPPJUJR> IFTPLIZQABV;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<AYDHTPPJUJR> UQZMGHDOKEK;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<AYDHTPPJUJR> WSTQSSXFCAU;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<AYDHTPPJUJR> VEQNTPGZZAC;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<AYDHTPPJUJR> NARRNWTNVAT;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<AYDHTPPJUJR> GCQDZETBCPB;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<AYDHTPPJUJR> ZFUFRSOQBQI;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<AYDHTPPJUJR> NBQRQWBTLKP;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<AYDHTPPJUJR> NKVSCVYEMQN;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<AYDHTPPJUJR> VYTMQJUPDLK;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<AYDHTPPJUJR> YKVUGOYRBEC;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<AYDHTPPJUJR> SKPVGIWCXVY;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<AYDHTPPJUJR> SVRQMQZQMBQ;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<AYDHTPPJUJR> PWTMRGRNPJX;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<AYDHTPPJUJR> ATEMDIFKNMM;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<AYDHTPPJUJR> JOOQOYIBJWG;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<AYDHTPPJUJR> BQXPYQXTKBY;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<AYDHTPPJUJR> EUYBNZFSAFX;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<AYDHTPPJUJR> RVOZGCZTACX;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<AYDHTPPJUJR> NGOGSDNQOZI;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<AYDHTPPJUJR> KMSCBHBOJSZ;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<AYDHTPPJUJR>, SIQLLRWEZBU> XFCLBHKKBXE
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2B3C0A0", Offset = "0x2B3A6A0", VA = "0x182B3C0A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C0F0", Offset = "0x2B3A6F0", VA = "0x182B3C0F0")]
			public static SIQLLRWEZBU DZEDFCNIZMG(Id32<AYDHTPPJUJR> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C480", Offset = "0x2B3AA80", VA = "0x182B3C480")]
			public static bool SUYZLVSGOAX(Id32<AYDHTPPJUJR> id, [Out] SIQLLRWEZBU a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C170", Offset = "0x2B3A770", VA = "0x182B3C170")]
			public static WPCWYXTKXZN EELIGOVUBVR(Id32<AYDHTPPJUJR> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C3F0", Offset = "0x2B3A9F0", VA = "0x182B3C3F0")]
			private static Id32<AYDHTPPJUJR> KQPXXDZDTRT(SIQLLRWEZBU a, Id32<AYDHTPPJUJR> id)
			{
				return default(Id32<AYDHTPPJUJR>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C220", Offset = "0x2B3A820", VA = "0x182B3C220")]
			private static void GCTWCMWOPFX(Id32<AYDHTPPJUJR> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class UVUKYEHQYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				private IdUnsafeList<FLWSVPBGFWX, WPCWYXTKXZN?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x1317F40", Offset = "0x1316540", VA = "0x181317F40")]
				private TypeRegistryFactory([In] IdUnsafeList<FLWSVPBGFWX, WPCWYXTKXZN?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x2B488C0", Offset = "0x2B46EC0", VA = "0x182B488C0")]
				public static TypeRegistryFactory MMOZYBUGEIN()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B483A0", Offset = "0x2B469A0", VA = "0x182B483A0")]
				public (ReadOnlyIdArray<FLWSVPBGFWX, WPCWYXTKXZN>, IReadOnlyDictionary<WPCWYXTKXZN, Id32<FLWSVPBGFWX>>) BESFLJVUAJT()
				{
					return default((ReadOnlyIdArray<FLWSVPBGFWX, WPCWYXTKXZN>, IReadOnlyDictionary<WPCWYXTKXZN, Id32<FLWSVPBGFWX>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B486F0", Offset = "0x2B46CF0", VA = "0x182B486F0")]
				public Id32<FLWSVPBGFWX> BKIFJSYNBCD(int a, WPCWYXTKXZN b)
				{
					return default(Id32<FLWSVPBGFWX>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x2B48870", Offset = "0x2B46E70", VA = "0x182B48870")]
				public Id32<FLWSVPBGFWX> Initialize(int id, UPALZYLPQSM type, UPALZYLPQSM factoryType)
				{
					return default(Id32<FLWSVPBGFWX>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class EIWTARQPTXY
			{
				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Id32<FLWSVPBGFWX> KAEFRYWYDYV
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AEC0", Offset = "0x2B394C0", VA = "0x182B3AEC0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AE00", Offset = "0x2B39400", VA = "0x182B3AE00")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Id32<FLWSVPBGFWX> MJADKPGVGUB
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AD80", Offset = "0x2B39380", VA = "0x182B3AD80")]
					[CompilerGenerated]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x2B3ACC0", Offset = "0x2B392C0", VA = "0x182B3ACC0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Id32<FLWSVPBGFWX> ZXELHDYAADE
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AE80", Offset = "0x2B39480", VA = "0x182B3AE80")]
					[CompilerGenerated]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AD40", Offset = "0x2B39340", VA = "0x182B3AD40")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Id32<FLWSVPBGFWX> SWHGYVXAUAM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2B3ADC0", Offset = "0x2B393C0", VA = "0x182B3ADC0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AF40", Offset = "0x2B39540", VA = "0x182B3AF40")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<FLWSVPBGFWX> KNCMWOYLBDO
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AF00", Offset = "0x2B39500", VA = "0x182B3AF00")]
					[CompilerGenerated]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AE40", Offset = "0x2B39440", VA = "0x182B3AE40")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<FLWSVPBGFWX> QZYZQASKBFH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AC80", Offset = "0x2B39280", VA = "0x182B3AC80")]
					[CompilerGenerated]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2B3AD00", Offset = "0x2B39300", VA = "0x182B3AD00")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class JACDNXLBEAW : IEnumerable<WPCWYXTKXZN>, IEnumerable, IEnumerator<WPCWYXTKXZN>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				private int AEMBTWPORMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				private WPCWYXTKXZN MVWPOXUKILF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				private int NVRLJVISCMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				private bool HTXNQUKSIBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public bool LWSNNEZSEDU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private RoomVersion FLFAHFRLSQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public RoomVersion PUXTRXSYBCW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private bool TACIXJSCRZQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public bool NFQCIUULXYR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private bool AGKLPMOHMJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public bool VJNUQYELOQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private bool OIFUFXRGZNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public bool RAPVQHMHFSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private bool KXOFCQSPRWA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public bool CSBSRIGDWLV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				private IEnumerator<WPCWYXTKXZN> TPFONUYPLCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private WPCWYXTKXZN AZCKWRYSEXL;

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				private WPCWYXTKXZN XGZRIQERISY
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				private object HLWKSVCMTHU
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
				[DebuggerHidden]
				public JACDNXLBEAW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BA10", Offset = "0x2B3A010", VA = "0x182B3BA10", Slot = "7")]
				[DebuggerHidden]
				private void CJOOGEZDZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BBB0", Offset = "0x2B3A1B0", VA = "0x182B3BBB0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BB60", Offset = "0x2B3A160", VA = "0x182B3BB60")]
				private void KPIRURCCWVL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BFA0", Offset = "0x2B3A5A0", VA = "0x182B3BFA0", Slot = "10")]
				[DebuggerHidden]
				private void VIZWRAVZEQM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BAA0", Offset = "0x2B3A0A0", VA = "0x182B3BAA0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<WPCWYXTKXZN> FIKTYKQLTLV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x2B3BAA0", Offset = "0x2B3A0A0", VA = "0x182B3BAA0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator MZPFIUHPQEF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class SEBXZXKLBVW : IEnumerable<WPCWYXTKXZN>, IEnumerable, IEnumerator<WPCWYXTKXZN>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				private int AEMBTWPORMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private WPCWYXTKXZN MVWPOXUKILF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				private int NVRLJVISCMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private RoomVersion FLFAHFRLSQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public RoomVersion PUXTRXSYBCW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private bool AGKLPMOHMJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public bool VJNUQYELOQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private bool TACIXJSCRZQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public bool NFQCIUULXYR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private bool ARIYGPPQMME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				public bool TWMIVPKCRXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				private bool OIFUFXRGZNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public bool RAPVQHMHFSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				private bool LQPZOJKYAIU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool DEPTAIMVCJG;

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				private WPCWYXTKXZN XGZRIQERISY
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				private object HLWKSVCMTHU
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
				[DebuggerHidden]
				public SEBXZXKLBVW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
				[DebuggerHidden]
				private void CJOOGEZDZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2B46560", Offset = "0x2B44B60", VA = "0x182B46560", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x2B48360", Offset = "0x2B46960", VA = "0x182B48360", Slot = "10")]
				[DebuggerHidden]
				private void VIZWRAVZEQM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2B464B0", Offset = "0x2B44AB0", VA = "0x182B464B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<WPCWYXTKXZN> FIKTYKQLTLV()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x2B464B0", Offset = "0x2B44AB0", VA = "0x182B464B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator MZPFIUHPQEF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class WUFLPSVJFLI : IEnumerable<Id32<FLWSVPBGFWX>>, IEnumerable, IEnumerator<Id32<FLWSVPBGFWX>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private int AEMBTWPORMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private Id32<FLWSVPBGFWX> MVWPOXUKILF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				private int NVRLJVISCMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private RoomVersion FLFAHFRLSQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public RoomVersion PUXTRXSYBCW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool TACIXJSCRZQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public bool NFQCIUULXYR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private bool AGKLPMOHMJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public bool VJNUQYELOQF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private bool OIFUFXRGZNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public bool RAPVQHMHFSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private bool KXOFCQSPRWA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public bool CSBSRIGDWLV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private IEnumerator<WPCWYXTKXZN> TPFONUYPLCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private IEnumerator<UPALZYLPQSM> TPVJFPGHNKB;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private Id32<FLWSVPBGFWX> HBLYBPQHZUP
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xC071B0", Offset = "0xC057B0", VA = "0x180C071B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<FLWSVPBGFWX>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object HLWKSVCMTHU
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x2B537C0", Offset = "0x2B51DC0", VA = "0x182B537C0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x15FB710", Offset = "0x15F9D10", VA = "0x1815FB710")]
				[DebuggerHidden]
				public WUFLPSVJFLI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x2B53670", Offset = "0x2B51C70", VA = "0x182B53670", Slot = "7")]
				[DebuggerHidden]
				private void CJOOGEZDZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2B53960", Offset = "0x2B51F60", VA = "0x182B53960", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2B53860", Offset = "0x2B51E60", VA = "0x182B53860")]
				private void KPIRURCCWVL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x2B53810", Offset = "0x2B51E10", VA = "0x182B53810")]
				private void KOSXCWUKUNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2B53E60", Offset = "0x2B52460", VA = "0x182B53E60", Slot = "10")]
				[DebuggerHidden]
				private void VIZWRAVZEQM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2B538B0", Offset = "0x2B51EB0", VA = "0x182B538B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<FLWSVPBGFWX>> RYIGNVCYKOM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x2B538B0", Offset = "0x2B51EB0", VA = "0x182B538B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator MZPFIUHPQEF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private static readonly Log WOAZIZZDVRE;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private static ReadOnlyIdArray<FLWSVPBGFWX, WPCWYXTKXZN?> QHEVRPFCLXK;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private static IReadOnlyDictionary<WPCWYXTKXZN, Id32<FLWSVPBGFWX>> ZMULLWDGBYA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly PKAKPCXWAYS LGEHCAIZAUF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly PKAKPCXWAYS LCVVIFBRHCV;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private static readonly HashSet<WPCWYXTKXZN> FQJYSDRIPWD;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static List<WPCWYXTKXZN> VXZCRSFLRFM;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet UCWJQOEUFLR
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet LBEOJQORIEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet ZHJOKSEEDKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD8C2E0", Offset = "0xD8A8E0", VA = "0x180D8C2E0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static WPCWYXTKXZN KAEFRYWYDYV
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BD60", Offset = "0x2B4A360", VA = "0x182B4BD60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static WPCWYXTKXZN MJADKPGVGUB
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2B49B20", Offset = "0x2B48120", VA = "0x182B49B20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static WPCWYXTKXZN ZXELHDYAADE
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B460", Offset = "0x2B49A60", VA = "0x182B4B460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static WPCWYXTKXZN SWHGYVXAUAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A3D0", Offset = "0x2B489D0", VA = "0x182B4A3D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static WPCWYXTKXZN DDNUILZQZXQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B380", Offset = "0x2B49980", VA = "0x182B4B380")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static WPCWYXTKXZN JRXKAEIVZLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C860", Offset = "0x2B4AE60", VA = "0x182B4C860")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static WPCWYXTKXZN QYUZBGSJRXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A7A0", Offset = "0x2B48DA0", VA = "0x182B4A7A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static WPCWYXTKXZN KNCMWOYLBDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C410", Offset = "0x2B4AA10", VA = "0x182B4C410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static UPALZYLPQSM DEFOXDIESEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C110", Offset = "0x2B4A710", VA = "0x182B4C110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static UPALZYLPQSM AIKWUDERNXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2B48EC0", Offset = "0x2B474C0", VA = "0x182B48EC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static UPALZYLPQSM LZKJAPDGYCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A150", Offset = "0x2B48750", VA = "0x182B4A150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static UPALZYLPQSM XALHULFYFTM
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2B49BB0", Offset = "0x2B481B0", VA = "0x182B49BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static UPALZYLPQSM WGMTIGJJCMG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C070", Offset = "0x2B4A670", VA = "0x182B4C070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static UPALZYLPQSM KUSLIVQAPNL
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AF70", Offset = "0x2B49570", VA = "0x182B4AF70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static UPALZYLPQSM CNLNRUFGCCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C020", Offset = "0x2B4A620", VA = "0x182B4C020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static UPALZYLPQSM PSUKHRJZGND
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C810", Offset = "0x2B4AE10", VA = "0x182B4C810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static UPALZYLPQSM SXWKHXYPQFO
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C370", Offset = "0x2B4A970", VA = "0x182B4C370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static UPALZYLPQSM YYXKJSBXWBS
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B100", Offset = "0x2B49700", VA = "0x182B4B100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static UPALZYLPQSM HXRSKICLOIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2B49F70", Offset = "0x2B48570", VA = "0x182B49F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static UPALZYLPQSM ZMHFRFZIOOZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BC90", Offset = "0x2B4A290", VA = "0x182B4BC90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static UPALZYLPQSM KGDRRETGVVZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2B49AD0", Offset = "0x2B480D0", VA = "0x182B49AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static UPALZYLPQSM PKFXIKGBMDK
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AF20", Offset = "0x2B49520", VA = "0x182B4AF20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static UPALZYLPQSM FEEPVQIPRCI
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C630", Offset = "0x2B4AC30", VA = "0x182B4C630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static UPALZYLPQSM TWVVAEAHJGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A100", Offset = "0x2B48700", VA = "0x182B4A100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static UPALZYLPQSM ZXIBLKVNCKD
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A060", Offset = "0x2B48660", VA = "0x182B4A060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static UPALZYLPQSM HKIMJRDJGQN
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2B494C0", Offset = "0x2B47AC0", VA = "0x182B494C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static UPALZYLPQSM CNIQXCSQIIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BFD0", Offset = "0x2B4A5D0", VA = "0x182B4BFD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static UPALZYLPQSM YOUSYCECJZS
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B150", Offset = "0x2B49750", VA = "0x182B4B150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static UPALZYLPQSM TETNRZHOCRH
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B290", Offset = "0x2B49890", VA = "0x182B4B290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static UPALZYLPQSM WSVREYLLTGX
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C160", Offset = "0x2B4A760", VA = "0x182B4C160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static UPALZYLPQSM TUXYAMVRKWB
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C3C0", Offset = "0x2B4A9C0", VA = "0x182B4C3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static UPALZYLPQSM ZLCFTLGHMHH
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C200", Offset = "0x2B4A800", VA = "0x182B4C200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static UPALZYLPQSM IIWCWNCZTYQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B330", Offset = "0x2B49930", VA = "0x182B4B330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static UPALZYLPQSM SDMZXEDIGQV
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C770", Offset = "0x2B4AD70", VA = "0x182B4C770")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static UPALZYLPQSM DVQBMKRFZSH
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2B4ADE0", Offset = "0x2B493E0", VA = "0x182B4ADE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static UPALZYLPQSM YRRRKEKZJXB
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C8F0", Offset = "0x2B4AEF0", VA = "0x182B4C8F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static UPALZYLPQSM CNWAHSEQRKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2B4ACE0", Offset = "0x2B492E0", VA = "0x182B4ACE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static UPALZYLPQSM IHJOQUFGASC
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BCE0", Offset = "0x2B4A2E0", VA = "0x182B4BCE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static UPALZYLPQSM RIHVQBDXOBR
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C720", Offset = "0x2B4AD20", VA = "0x182B4C720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static UPALZYLPQSM ZAAOAGYJKFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AC90", Offset = "0x2B49290", VA = "0x182B4AC90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static UPALZYLPQSM AOXUZWVEGWR
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2B493C0", Offset = "0x2B479C0", VA = "0x182B493C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static UPALZYLPQSM CCHHZHEWUBY
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A1A0", Offset = "0x2B487A0", VA = "0x182B4A1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static UPALZYLPQSM SECFJLJXGNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B0B0", Offset = "0x2B496B0", VA = "0x182B4B0B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static UPALZYLPQSM TNHCHGCGOLI
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C2A0", Offset = "0x2B4A8A0", VA = "0x182B4C2A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static UPALZYLPQSM FLNYBTRPLSB
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2B49320", Offset = "0x2B47920", VA = "0x182B49320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static UPALZYLPQSM BQJONRNXOGJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A380", Offset = "0x2B48980", VA = "0x182B4A380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static UPALZYLPQSM MWTLIABUVEI
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B790", Offset = "0x2B49D90", VA = "0x182B4B790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static UPALZYLPQSM YHEXXEYBPRQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2B49140", Offset = "0x2B47740", VA = "0x182B49140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static UPALZYLPQSM AYVDERMLHOY
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2B492D0", Offset = "0x2B478D0", VA = "0x182B492D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static UPALZYLPQSM UTNYJSWKCBY
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A550", Offset = "0x2B48B50", VA = "0x182B4A550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static UPALZYLPQSM CHARHIKXJPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A010", Offset = "0x2B48610", VA = "0x182B4A010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static UPALZYLPQSM FQLAYLNKICR
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B620", Offset = "0x2B49C20", VA = "0x182B4B620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static UPALZYLPQSM IFKUYZUKJVK
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2B491E0", Offset = "0x2B477E0", VA = "0x182B491E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static UPALZYLPQSM ADIIBQZTIFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A700", Offset = "0x2B48D00", VA = "0x182B4A700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static UPALZYLPQSM XPXEPYPDHZB
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C940", Offset = "0x2B4AF40", VA = "0x182B4C940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static UPALZYLPQSM TNCRFVSVPFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A5A0", Offset = "0x2B48BA0", VA = "0x182B4A5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static UPALZYLPQSM OAVCPHDKZWQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2B48FB0", Offset = "0x2B475B0", VA = "0x182B48FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static UPALZYLPQSM HJLVDWEEKBS
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C250", Offset = "0x2B4A850", VA = "0x182B4C250")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static UPALZYLPQSM VTYQXUGLBEW
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C6D0", Offset = "0x2B4ACD0", VA = "0x182B4C6D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static UPALZYLPQSM GXIKBXLJNWR
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A830", Offset = "0x2B48E30", VA = "0x182B4A830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static UPALZYLPQSM PZEKDBLKBCU
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A6B0", Offset = "0x2B48CB0", VA = "0x182B4A6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static UPALZYLPQSM SFJDMYARSJX
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2B49050", Offset = "0x2B47650", VA = "0x182B49050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static UPALZYLPQSM TMPGCVTHMMF
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C540", Offset = "0x2B4AB40", VA = "0x182B4C540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static UPALZYLPQSM EXNWSEOHAFP
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BF80", Offset = "0x2B4A580", VA = "0x182B4BF80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static UPALZYLPQSM QVOTJZVZQTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A4B0", Offset = "0x2B48AB0", VA = "0x182B4A4B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static UPALZYLPQSM WUEUKOMTTCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C4F0", Offset = "0x2B4AAF0", VA = "0x182B4C4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static UPALZYLPQSM UBMFRUYMEVP
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C990", Offset = "0x2B4AF90", VA = "0x182B4C990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static UPALZYLPQSM TBZBRZBGEPY
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2B49510", Offset = "0x2B47B10", VA = "0x182B49510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static UPALZYLPQSM IRGASLOBOOS
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AE80", Offset = "0x2B49480", VA = "0x182B4AE80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static UPALZYLPQSM JYDQNVKKAAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2B49230", Offset = "0x2B47830", VA = "0x182B49230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static UPALZYLPQSM WTUHKFQXNVG
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B740", Offset = "0x2B49D40", VA = "0x182B4B740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static UPALZYLPQSM PJHHQGVJIIU
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B1F0", Offset = "0x2B497F0", VA = "0x182B4B1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static UPALZYLPQSM UIACWLSCGFJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A2E0", Offset = "0x2B488E0", VA = "0x182B4A2E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static UPALZYLPQSM CLBGEWGAVXR
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C680", Offset = "0x2B4AC80", VA = "0x182B4C680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static UPALZYLPQSM COHOIVJCHWH
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A500", Offset = "0x2B48B00", VA = "0x182B4A500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static UPALZYLPQSM BPYJNESAPEG
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B2E0", Offset = "0x2B498E0", VA = "0x182B4B2E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static UPALZYLPQSM JIPNCNCZKIO
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B060", Offset = "0x2B49660", VA = "0x182B4B060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static UPALZYLPQSM MBPBAWQHDPY
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2B490A0", Offset = "0x2B476A0", VA = "0x182B490A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static UPALZYLPQSM ZZBKHTLCGED
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C5E0", Offset = "0x2B4ABE0", VA = "0x182B4C5E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static UPALZYLPQSM DXOKJLMDRCC
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2B490F0", Offset = "0x2B476F0", VA = "0x182B490F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static UPALZYLPQSM ZHBKAWYIIIO
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2B48F60", Offset = "0x2B47560", VA = "0x182B48F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static UPALZYLPQSM BOTKPLYIXVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2B49000", Offset = "0x2B47600", VA = "0x182B49000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static UPALZYLPQSM DNRNRGTIQQF
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C4A0", Offset = "0x2B4AAA0", VA = "0x182B4C4A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static UPALZYLPQSM BEPRRFSYHFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2B49FC0", Offset = "0x2B485C0", VA = "0x182B49FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static UPALZYLPQSM RMCROQZUGAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BC40", Offset = "0x2B4A240", VA = "0x182B4BC40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static UPALZYLPQSM YZXPWBDLNOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A460", Offset = "0x2B48A60", VA = "0x182B4A460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static UPALZYLPQSM LENJSLPVHFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A1F0", Offset = "0x2B487F0", VA = "0x182B4A1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static UPALZYLPQSM PYRLLWMRRCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A5F0", Offset = "0x2B48BF0", VA = "0x182B4A5F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static UPALZYLPQSM UHTDSERUHOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2B48F10", Offset = "0x2B47510", VA = "0x182B48F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static UPALZYLPQSM NEGZWNNQARK
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C7C0", Offset = "0x2B4ADC0", VA = "0x182B4C7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static UPALZYLPQSM KMJUTIMOBZL
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C9E0", Offset = "0x2B4AFE0", VA = "0x182B4C9E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static UPALZYLPQSM VXBJBFPPRLD
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2B495B0", Offset = "0x2B47BB0", VA = "0x182B495B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static UPALZYLPQSM OWHYMMTUHLP
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A330", Offset = "0x2B48930", VA = "0x182B4A330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static UPALZYLPQSM AVHSVVYSOEN
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4CA30", Offset = "0x2B4B030", VA = "0x182B4CA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static UPALZYLPQSM QKNCMNYVMKF
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C0C0", Offset = "0x2B4A6C0", VA = "0x182B4C0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static UPALZYLPQSM POSSQEPTQVS
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B010", Offset = "0x2B49610", VA = "0x182B4B010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static UPALZYLPQSM OOENYZKEINT
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B410", Offset = "0x2B49A10", VA = "0x182B4B410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static UPALZYLPQSM SHJQCWTQNFE
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BE40", Offset = "0x2B4A440", VA = "0x182B4BE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static UPALZYLPQSM DCLULCNEQVR
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BF30", Offset = "0x2B4A530", VA = "0x182B4BF30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static UPALZYLPQSM KDCAPMYZDZA
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2B49280", Offset = "0x2B47880", VA = "0x182B49280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static UPALZYLPQSM KWFHHRDYVDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C2F0", Offset = "0x2B4A8F0", VA = "0x182B4C2F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static UPALZYLPQSM BQAOKXSJQVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B1A0", Offset = "0x2B497A0", VA = "0x182B4B1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static UPALZYLPQSM YQSXAYSPSEY
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2B49A80", Offset = "0x2B48080", VA = "0x182B49A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static UPALZYLPQSM GRDZWQSUBER
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BE90", Offset = "0x2B4A490", VA = "0x182B4BE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static UPALZYLPQSM TOHDNBGOUNS
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C590", Offset = "0x2B4AB90", VA = "0x182B4C590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static UPALZYLPQSM KRIHUXUIAMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2B49560", Offset = "0x2B47B60", VA = "0x182B49560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static UPALZYLPQSM GFJPGWPZMRX
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AFC0", Offset = "0x2B495C0", VA = "0x182B4AFC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static UPALZYLPQSM UMHFMNMLJLH
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2B4ABF0", Offset = "0x2B491F0", VA = "0x182B4ABF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static UPALZYLPQSM LLRFSVTDJKK
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A0B0", Offset = "0x2B486B0", VA = "0x182B4A0B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static UPALZYLPQSM NKQIUECZNPH
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A240", Offset = "0x2B48840", VA = "0x182B4A240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static UPALZYLPQSM OLLBJEBVWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BEE0", Offset = "0x2B4A4E0", VA = "0x182B4BEE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static UPALZYLPQSM GNFPRMNNVQS
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2B49C80", Offset = "0x2B48280", VA = "0x182B49C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static UPALZYLPQSM RXZEAZMGKWH
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2B4C1B0", Offset = "0x2B4A7B0", VA = "0x182B4C1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static UPALZYLPQSM ZCFUJHPEACO
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2B4BDF0", Offset = "0x2B4A3F0", VA = "0x182B4BDF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static UPALZYLPQSM GXTRLWQEADD
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AE30", Offset = "0x2B49430", VA = "0x182B4AE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static UPALZYLPQSM WXPHOPKAROT
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2B49370", Offset = "0x2B47970", VA = "0x182B49370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static UPALZYLPQSM VNBQXQHHURY
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A750", Offset = "0x2B48D50", VA = "0x182B4A750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static UPALZYLPQSM TIAFXVIKQXK
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2B49190", Offset = "0x2B47790", VA = "0x182B49190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static UPALZYLPQSM UPSAARRZGWN
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AED0", Offset = "0x2B494D0", VA = "0x182B4AED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static UPALZYLPQSM EAIXHQDZLRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2B4A290", Offset = "0x2B48890", VA = "0x182B4A290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static UPALZYLPQSM GEMBPOQOUME
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B240", Offset = "0x2B49840", VA = "0x182B4B240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static UPALZYLPQSM GXFUGHRFALH
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2B4B6F0", Offset = "0x2B49CF0", VA = "0x182B4B6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static UPALZYLPQSM EXPYUXPHMGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2B4AC40", Offset = "0x2B49240", VA = "0x182B4AC40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B49990", Offset = "0x2B47F90", VA = "0x182B49990")]
			public static PKAKPCXWAYS EHOSSFEDPHQ([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BB90", Offset = "0x2B4A190", VA = "0x182B4BB90")]
			public static ClassFactoryTypeParams SHOCMOGLSJR(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BB60", Offset = "0x2B4A160", VA = "0x182B4BB60")]
			public static ClassFactoryTypeParams SHOCMOGLSJR([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BD30", Offset = "0x2B4A330", VA = "0x182B4BD30")]
			public static PKAKPCXWAYS SRADZKIQYAI(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B4C340", Offset = "0x2B4A940", VA = "0x182B4C340")]
			public static PKAKPCXWAYS WTDXSNKRICZ(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B4F0", Offset = "0x2B49AF0", VA = "0x182B4B4F0")]
			public static PKAKPCXWAYS QZYZQASKBFH([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B498E0", Offset = "0x2B47EE0", VA = "0x182B498E0")]
			public static WPCWYXTKXZN EELIGOVUBVR(Id32<FLWSVPBGFWX> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B670", Offset = "0x2B49C70", VA = "0x182B4B670")]
			public static string REWYTAJDDGU(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B49600", Offset = "0x2B47C00", VA = "0x182B49600")]
			private static WPCWYXTKXZN EELIGOVUBVR(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A640", Offset = "0x2B48C40", VA = "0x182B4A640")]
			public static Id32<FLWSVPBGFWX>? KHLINWOANRM(WPCWYXTKXZN a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A880", Offset = "0x2B48E80", VA = "0x182B4A880")]
			public static CircuitTypeIdWrapper? MDWTDGZJZHH(WPCWYXTKXZN a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CA80", Offset = "0x2B4B080", VA = "0x182B4CA80")]
			static UVUKYEHQYTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AD30", Offset = "0x2B49330", VA = "0x182B4AD30")]
			[IteratorStateMachine(typeof(SEBXZXKLBVW))]
			private static IEnumerable<WPCWYXTKXZN> MUTNHZWFNHV(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B4BAB0", Offset = "0x2B4A0B0", VA = "0x182B4BAB0")]
			[IteratorStateMachine(typeof(JACDNXLBEAW))]
			public static IEnumerable<WPCWYXTKXZN> RXPSWFRTWFY(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2B49CD0", Offset = "0x2B482D0", VA = "0x182B49CD0")]
			public static Variant FQEOHQGGELF(WPCWYXTKXZN a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4B7E0", Offset = "0x2B49DE0", VA = "0x182B4B7E0")]
			public static Variant RNTAGBGNHZQ(WPCWYXTKXZN a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2B49C00", Offset = "0x2B48200", VA = "0x182B49C00")]
			public static bool FOFFRPVGEYW(WPCWYXTKXZN a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B49410", Offset = "0x2B47A10", VA = "0x182B49410")]
			[IteratorStateMachine(typeof(WUFLPSVJFLI))]
			public static IEnumerable<Id32<FLWSVPBGFWX>> DEWRTSYOZBW(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ALQQEGVKIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B36E30", Offset = "0x2B35430", VA = "0x182B36E30")]
		public static YUCBCAVEKCP KYZOGDONURM(this WPCWYXTKXZN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B36330", Offset = "0x2B34930", VA = "0x182B36330")]
		public static WPCWYXTKXZN KMQBINKGCWL(this YUCBCAVEKCP a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AAAFHLARUPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x329F6F0", Offset = "0x329DCF0", VA = "0x18329F6F0")]
		public static Dictionary<b, c> XJODJKDSAMP<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class RANFPOAQMIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B461E0", Offset = "0x2B447E0", VA = "0x182B461E0")]
		public static UAXJCZQLHLT KYZOGDONURM([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B46140", Offset = "0x2B44740", VA = "0x182B46140")]
		public static Guid KMQBINKGCWL(UAXJCZQLHLT a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class XJZCYPQNOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B542C0", Offset = "0x2B528C0", VA = "0x182B542C0")]
		public static XJCBBRTPMUV KYZOGDONURM([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B54260", Offset = "0x2B52860", VA = "0x182B54260")]
		public static NamedType KMQBINKGCWL(this XJCBBRTPMUV a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class VZGTRXZCXDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD6D0", Offset = "0x3EBBCD0", VA = "0x183EBD6D0")]
		public static void WPRUJZLMWXB<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD930", Offset = "0x3EBBF30", VA = "0x183EBD930")]
		public static void WPRUJZLMWXB<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class HBAOIDFADBQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B0D0", Offset = "0x2B396D0", VA = "0x182B3B0D0")]
		public static QKFPIDYSUKV KYZOGDONURM([In] this Variant self, WPCWYXTKXZN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AF80", Offset = "0x2B39580", VA = "0x182B3AF80")]
		public static Variant KMQBINKGCWL(this QKFPIDYSUKV a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ZKIAPXVWZXC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Id128<DYVADBOMRIA> XDSVBXEIPLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public readonly bool YZCWNKDUODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public readonly bool WDQJRVKSXEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly bool RIKIFFAQUFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public readonly bool JRWWDYIVUUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public readonly bool JRRPGROYLIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public readonly bool JOGYINIJLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public readonly bool YXAFPHMTCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool HYUDPKLFRIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly List<(string Name, WPCWYXTKXZN Type)> BDEDQFSQZIS;

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[WillBeRenamedTo("LegacyId")]
		public Guid SNTOXKRGJFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDC00", Offset = "0x2AFC200", VA = "0x182AFDC00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Id128<DYVADBOMRIA> FLFSLJBKJHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2AFDC00", Offset = "0x2AFC200", VA = "0x182AFDC00")]
			get
			{
				return default(Id128<DYVADBOMRIA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public IReadOnlyList<(string Name, WPCWYXTKXZN Type)> RNHIBQNJEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FULFTLQKQIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B545E0", Offset = "0x2B52BE0", VA = "0x182B545E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B54A30", Offset = "0x2B53030", VA = "0x182B54A30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, WPCWYXTKXZN> QCIJKWNPZNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B54980", Offset = "0x2B52F80", VA = "0x182B54980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B55280", Offset = "0x2B53880", VA = "0x182B55280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> ACDWAGDFVRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B54680", Offset = "0x2B52C80", VA = "0x182B54680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B54BC0", Offset = "0x2B531C0", VA = "0x182B54BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> VVFYWHIELEU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B55480", Offset = "0x2B53A80", VA = "0x182B55480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B553D0", Offset = "0x2B539D0", VA = "0x182B553D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, WPCWYXTKXZN> MMAHHFTPEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B54730", Offset = "0x2B52D30", VA = "0x182B54730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B55530", Offset = "0x2B53B30", VA = "0x182B55530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action TKOPBISVQQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B55330", Offset = "0x2B53930", VA = "0x182B55330")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B548E0", Offset = "0x2B52EE0", VA = "0x182B548E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x18BDBC0", Offset = "0x18BC1C0", VA = "0x1818BDBC0")]
		public void OZLMKEHEADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B55750", Offset = "0x2B53D50", VA = "0x182B55750")]
		internal ZKIAPXVWZXC([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, WPCWYXTKXZN Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B54D60", Offset = "0x2B53360", VA = "0x182B54D60")]
		public static CircuitEventDefinitionFactoryStart MMOZYBUGEIN(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B54CE0", Offset = "0x2B532E0", VA = "0x182B54CE0")]
		public static CircuitEventDefinitionFactoryStart MMOZYBUGEIN(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B555E0", Offset = "0x2B53BE0", VA = "0x182B555E0")]
		public static ZKIAPXVWZXC ZSZDNYYKHLJ([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B55040", Offset = "0x2B53640", VA = "0x182B55040")]
		public static ZKIAPXVWZXC RFCIRIRVNXD([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xF396F0", Offset = "0xF37CF0", VA = "0x180F396F0")]
		public void ZUTZGFYLFJV(Id128<DYVADBOMRIA> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B556F0", Offset = "0x2B53CF0", VA = "0x182B556F0")]
		public void ZZEEMQFVJLA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B54F50", Offset = "0x2B53550", VA = "0x182B54F50")]
		public void RDAJDZBKYGW(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B54AD0", Offset = "0x2B530D0", VA = "0x182B54AD0")]
		public void KOPVEIIHHUV(int a, WPCWYXTKXZN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B54E30", Offset = "0x2B53430", VA = "0x182B54E30")]
		public void NOZLBFHHEFV(string a, WPCWYXTKXZN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B54C70", Offset = "0x2B53270", VA = "0x182B54C70")]
		public void LUBERCLRDFO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B547E0", Offset = "0x2B52DE0", VA = "0x182B547E0")]
		public ZKIAPXVWZXC Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2B38F50", Offset = "0x2B37550", VA = "0x182B38F50")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B38DE0", Offset = "0x2B373E0", VA = "0x182B38DE0")]
		public CircuitEventDefinitionFactoryParams JUBOIVTXKHT(string a, WPCWYXTKXZN b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B38CB0", Offset = "0x2B372B0", VA = "0x182B38CB0")]
		public ZKIAPXVWZXC BESFLJVUAJT()
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
		private readonly List<(string Name, WPCWYXTKXZN Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B38C20", Offset = "0x2B37220", VA = "0x182B38C20")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, WPCWYXTKXZN Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B38AF0", Offset = "0x2B370F0", VA = "0x182B38AF0")]
		public CircuitEventDefinitionFactoryParams JUBOIVTXKHT(string a, WPCWYXTKXZN b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B389F0", Offset = "0x2B36FF0", VA = "0x182B389F0")]
		public ZKIAPXVWZXC BESFLJVUAJT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class DRKOFZEOASZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public static readonly ZKIAPXVWZXC CVCSIBMIRKI;

			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly ZKIAPXVWZXC YGOFXEMWBXZ;

			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly ZKIAPXVWZXC NPSALYQPICK;

			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly ZKIAPXVWZXC SRXRNRVQZYH;

			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public static readonly ZKIAPXVWZXC FXPDCQHIQVO;

			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public static readonly ZKIAPXVWZXC WNVWKFHPQDQ;

			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly ZKIAPXVWZXC PIZSAXSKOZL;

			[Cpp2IlInjected.Token(Token = "0x4000136")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			internal static readonly ZKIAPXVWZXC[] NBQRHTSQDIG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class BGQRKZYDMMM
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly ZKIAPXVWZXC KKJMSRJLJNK;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class YBCUJNFEMXV
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly ZKIAPXVWZXC ZYNUMLCVRTW;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly ZKIAPXVWZXC QVWMPWUFJRD;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class BQXPYQXTKBY
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly ZKIAPXVWZXC BCDDYOROCMF;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly ZKIAPXVWZXC QQYVXGVBLRK;

			[Cpp2IlInjected.Token(Token = "0x400013F")]
			internal static readonly ZKIAPXVWZXC[] BBSOHSKXNBK;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public static readonly ZKIAPXVWZXC IGZJAMAECSI;

			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly ZKIAPXVWZXC RFBZUCJPEUF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class UQZMGHDOKEK
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly ZKIAPXVWZXC FUAVQDIBMJD;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly ZKIAPXVWZXC BPMDKZKUCME;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class HQMKBECTBKP
		{
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public static readonly ZKIAPXVWZXC XTVIWNEBWJW;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly ZKIAPXVWZXC FIWTGKJZQNB;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class CSOVCOAXSIA
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public static readonly ZKIAPXVWZXC ZYNUMLCVRTW;

			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly ZKIAPXVWZXC QVWMPWUFJRD;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class EBDDXTQXQNY
		{
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public static readonly ZKIAPXVWZXC KJASONBJFCH;

			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly ZKIAPXVWZXC QTEVVXIKLPC;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly ZKIAPXVWZXC UOPFEWSDVJA;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public static readonly ZKIAPXVWZXC XNRSOLGYSCA;

			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly ZKIAPXVWZXC QDNTDRQXNML;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly ZKIAPXVWZXC NGVCUWEHXDW;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public static readonly ZKIAPXVWZXC SMWDGCAIJPH;

			[Cpp2IlInjected.Token(Token = "0x4000153")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class WGOVLDBKBRU
		{
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class LLOMPCUXKIW
		{
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class LGSCKQFXJYC
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class XDDDFYIEFBE
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly ZKIAPXVWZXC SSMNCJWKMVR;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly ZKIAPXVWZXC NEBJHRZJVPO;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class VYTMQJUPDLK
		{
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class DUBRVFHYFLO
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class HJPKFUSKOZO
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class IFTPLIZQABV
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly ZKIAPXVWZXC XJLKEWDEICX;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public static readonly ZKIAPXVWZXC GHVSYYVXIJT;

			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public static readonly ZKIAPXVWZXC RYLNJHGFAPI;

			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public static readonly ZKIAPXVWZXC NOOKGDBZYKL;

			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public static readonly ZKIAPXVWZXC XSCPIAYLCJL;

			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public static readonly ZKIAPXVWZXC XTVIWNEBWJW;

			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly ZKIAPXVWZXC UCGEFZSJYVT;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public static readonly ZKIAPXVWZXC AVWJVVJHHNY;

			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly ZKIAPXVWZXC UTDNXNESLLO;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly ZKIAPXVWZXC NUXYFGJRJGY;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly ZKIAPXVWZXC SHOTPEXIMCK;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly ZKIAPXVWZXC INWYRFXBQCE;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly ZKIAPXVWZXC KMPEWJRJMJZ;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly ZKIAPXVWZXC RJDYPGROJEW;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly ZKIAPXVWZXC PSELUETVAJP;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly ZKIAPXVWZXC ONJXLIMNOIV;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly ZKIAPXVWZXC GKFZBLUQANJ;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly ZKIAPXVWZXC AGJXYNCKGSE;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly ZKIAPXVWZXC SRLWNJERJTX;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly ZKIAPXVWZXC WZMTFMCPFPB;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly ZKIAPXVWZXC PSEGYQHISMC;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly ZKIAPXVWZXC OJAMLUFCJHI;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ZKIAPXVWZXC SDECPEUCACY;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly ZKIAPXVWZXC XQLIPLVJUUM;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly ZKIAPXVWZXC VRSKHPNREHG;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly ZKIAPXVWZXC BZHPVJBBKTG;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly ZKIAPXVWZXC QUPYYIXZRRM;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly ZKIAPXVWZXC ZRZBGEKDNKC;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly ZKIAPXVWZXC HCKSBXMVRWT;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly ZKIAPXVWZXC NHHFWIKQDQD;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly ZKIAPXVWZXC LEGUPHSUBWS;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly ZKIAPXVWZXC MSDNESRTGBI;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly ZKIAPXVWZXC UUFDJOBABNB;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly ZKIAPXVWZXC SUZEDILIFBZ;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly ZKIAPXVWZXC WWGCNAYXGSX;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly ZKIAPXVWZXC DZHCTQUCUXR;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly ZKIAPXVWZXC XOWQKSTNSAL;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly ZKIAPXVWZXC NKDFSCCDSOB;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly ZKIAPXVWZXC TLMTBRZPZEJ;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly ZKIAPXVWZXC ZQFYSWBQTCZ;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly ZKIAPXVWZXC CSLMMZEXNWU;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly ZKIAPXVWZXC ZTFAUTNOENM;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly ZKIAPXVWZXC NUUWFMMSBWE;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly ZKIAPXVWZXC QBADBWVFBOM;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly ZKIAPXVWZXC INCGQEOLXEM;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly ZKIAPXVWZXC EWGQTMXZYTW;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly ZKIAPXVWZXC BRHTLARDQDQ;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly ZKIAPXVWZXC EIBTISKXFZQ;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly ZKIAPXVWZXC NCOIPOWXVNA;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly ZKIAPXVWZXC QCBHNGJBSUA;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly ZKIAPXVWZXC MUZZFYUHCGT;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly ZKIAPXVWZXC SHYQSPLFVJC;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly ZKIAPXVWZXC CAGGAEWUHTY;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly ZKIAPXVWZXC FAIIPDDBTOU;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly ZKIAPXVWZXC EIVUJTDWABW;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly ZKIAPXVWZXC JHHKZZGIBHW;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly ZKIAPXVWZXC MOOIFBGYBDS;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly ZKIAPXVWZXC JCXIVEVTGJO;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly ZKIAPXVWZXC OIHUYTRRQCO;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly ZKIAPXVWZXC KZAPUCJMAUC;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly ZKIAPXVWZXC LRLTYDSWRUW;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly ZKIAPXVWZXC YZFDCQULVPS;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly ZKIAPXVWZXC LBYFNMCVZSP;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly ZKIAPXVWZXC NQXVZHDNTPS;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly ZKIAPXVWZXC MDPDNVTEIZK;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly ZKIAPXVWZXC DUBIZWXJCTV;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly ZKIAPXVWZXC SZRDLBILCVL;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly ZKIAPXVWZXC DPCMATVBJTA;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly ZKIAPXVWZXC EWZKCGTIOJK;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class SXOYPXUHZQL
		{
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class CXVUWASUCDA
		{
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly ZKIAPXVWZXC UGXUQAEUDTK;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly ZKIAPXVWZXC YSWUYRHMVIR;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly ZKIAPXVWZXC PZLPOEUYOLH;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly ZKIAPXVWZXC HHOTFVSXOQG;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly ZKIAPXVWZXC UYKTWNUOKZY;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public static readonly ZKIAPXVWZXC ISTBPYHQIDG;

			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public static readonly ZKIAPXVWZXC LNPODEWBSZI;

			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class PSVKMGJPRZV
		{
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly ZKIAPXVWZXC GHVSYYVXIJT;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly ZKIAPXVWZXC RYLNJHGFAPI;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly ZKIAPXVWZXC NOOKGDBZYKL;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly ZKIAPXVWZXC NYMYVJXVUTV;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly ZKIAPXVWZXC EPMRYPBFBCD;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly ZKIAPXVWZXC BQRAPBGSLOT;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public static readonly ZKIAPXVWZXC QIMKBLJJMMV;

			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class BZFCNBLLOEX
		{
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly ZKIAPXVWZXC MOATNYDUUJP;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly ZKIAPXVWZXC KNWGCXTDIAZ;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly ZKIAPXVWZXC ADEJKEGNWQK;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly ZKIAPXVWZXC RUNRBHWDJSO;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly ZKIAPXVWZXC UASLZLKJJIW;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly ZKIAPXVWZXC OLYLPSSMBTS;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class GYDMDXFBMVO
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class JHMRTRAJSUH
		{
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly ZKIAPXVWZXC SBTFRMLCWON;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class HZJUKLUSQAV
		{
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly ZKIAPXVWZXC XJLKEWDEICX;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class YFRENRHVYFQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class ABZLXFUNGDH
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class TJIERWQHHPI
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public static readonly ZKIAPXVWZXC HBXUADFIFDU;

			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly ZKIAPXVWZXC JHGLXWDUQXG;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public static readonly ZKIAPXVWZXC RWHEQPGEYET;

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly ZKIAPXVWZXC URJFFDKPHPJ;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class IRIDDBBPDAI
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public static readonly ZKIAPXVWZXC KLHAIXZPZFX;

			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public static readonly ZKIAPXVWZXC TTJUVTLQQRI;

			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class MSITVTEEDZK
		{
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class YQQWNXVXMRS
		{
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly ZKIAPXVWZXC UGXUQAEUDTK;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly ZKIAPXVWZXC YSWUYRHMVIR;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class JYWQZKIGTMR
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly ZKIAPXVWZXC JHRALOZGYFU;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly ZKIAPXVWZXC HHOTFVSXOQG;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public static readonly ZKIAPXVWZXC UYKTWNUOKZY;

			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public static readonly ZKIAPXVWZXC ISTBPYHQIDG;

			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly ZKIAPXVWZXC LZPFXUYPFNB;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly ZKIAPXVWZXC VMGQIDKULGQ;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public static readonly ZKIAPXVWZXC NKKAZTVWWRW;

			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly ZKIAPXVWZXC LFICBUKVKJI;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly ZKIAPXVWZXC TQQDSKUZHGP;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly ZKIAPXVWZXC UEQFGBJFZIX;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly ZKIAPXVWZXC UGXUQAEUDTK;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly ZKIAPXVWZXC YSWUYRHMVIR;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class CHTXLHKWBUH
		{
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class RKKVEGFYVMV
		{
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly ZKIAPXVWZXC UGXUQAEUDTK;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly ZKIAPXVWZXC YSWUYRHMVIR;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly ZKIAPXVWZXC THDRVIKVTUT;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly ZKIAPXVWZXC LWFJPNPZQXZ;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly ZKIAPXVWZXC KOKAFNJYFTI;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class JSXLQLWPTOQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class NBQRQWBTLKP
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly ZKIAPXVWZXC AUOLPKNHOLS;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class JRVFBTGXDKP
		{
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly ZKIAPXVWZXC HBBYWZNQEUZ;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly ZKIAPXVWZXC GYTXNRNAGQA;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly ZKIAPXVWZXC UGXUQAEUDTK;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static readonly ZKIAPXVWZXC YSWUYRHMVIR;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class EQLYGBKWLSW
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class OUWEGFMKADU
		{
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class TEZPPRQMPWT
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class AMYWLLTMQNB
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class NGOGSDNQOZI
		{
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class LCYRNYUBCGO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly ZKIAPXVWZXC SSMNCJWKMVR;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public static readonly ZKIAPXVWZXC NEBJHRZJVPO;

			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class KSCQWBKSKUW
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public static readonly ZKIAPXVWZXC NRZNITNKCVP;

			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public static readonly ZKIAPXVWZXC LQNAUQFSNCH;

			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public static readonly ZKIAPXVWZXC YSWZFUHJMXD;

			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly ZKIAPXVWZXC NUXFLZLVRYX;

			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class VXICJRIFDNF
		{
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly ZKIAPXVWZXC NRZNITNKCVP;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public static readonly ZKIAPXVWZXC LQNAUQFSNCH;

			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly ZKIAPXVWZXC YSWZFUHJMXD;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly ZKIAPXVWZXC NUXFLZLVRYX;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class NCMMRQHKXUG
		{
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class GCQDZETBCPB
		{
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public static readonly ZKIAPXVWZXC AVNWRHTOJQA;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly ZKIAPXVWZXC QQLIFXSCSPS;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly ZKIAPXVWZXC RTJGSKEHYEE;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class KEBWATHZSCC
		{
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly ZKIAPXVWZXC SPYBCWHFIBH;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public static readonly ZKIAPXVWZXC KSSHYVZIUYH;

			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public static readonly ZKIAPXVWZXC SUKGIJDBEUM;

			[Cpp2IlInjected.Token(Token = "0x4000207")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class ACCCSOMSJPD
		{
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class ZFUFRSOQBQI
		{
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly ZKIAPXVWZXC IDCGFWDIUDO;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public static readonly ZKIAPXVWZXC RPBXEECIPCO;

			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly ZKIAPXVWZXC OWPXCHPGWWJ;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly ZKIAPXVWZXC JDGEKQEQAEV;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly ZKIAPXVWZXC YAVFHGDGDIA;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class NSMTYBEATET
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static readonly ZKIAPXVWZXC WRKWDRVXLNS;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class FGJPHKWUFOH
		{
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly ZKIAPXVWZXC MZRSIMVOWWN;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly ZKIAPXVWZXC EWIFWSNNUXE;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly ZKIAPXVWZXC MOOCQFOGOSR;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class CRJDMJKTUQM
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class SVRQMQZQMBQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class PWTMRGRNPJX
		{
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class VEQNTPGZZAC
		{
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly ZKIAPXVWZXC PNNFTFQSVZJ;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly ZKIAPXVWZXC DKETTIBUESA;

			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly ZKIAPXVWZXC KGYJLMHEVEK;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static readonly ZKIAPXVWZXC TCCBMWOXDTA;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public static readonly ZKIAPXVWZXC XRMUFBJOMAJ;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static readonly ZKIAPXVWZXC YWZCTDKPDUL;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly ZKIAPXVWZXC MIRUYFDFNCU;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			internal static readonly ZKIAPXVWZXC[] SGABYGXHOTL;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class SIQLLRWEZBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public readonly WPCWYXTKXZN PCJESMCWUSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private readonly List<ZKIAPXVWZXC> WVOYRZCUEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private readonly List<ZKIAPXVWZXC> UEINZSRWIIC;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IReadOnlyList<ZKIAPXVWZXC> SNSUQKJYYHA
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public IReadOnlyList<ZKIAPXVWZXC> NPXMSLITSCV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2B61AA0", Offset = "0x2B600A0", VA = "0x182B61AA0")]
		protected SIQLLRWEZBU(WPCWYXTKXZN a, params ZKIAPXVWZXC[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class RIYQOPSFLYK : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B61010", Offset = "0x2B5F610", VA = "0x182B61010")]
		internal RIYQOPSFLYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class JBFZKYQKRMD : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A930", Offset = "0x2B58F30", VA = "0x182B5A930")]
		internal JBFZKYQKRMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class AAHXLYOIIIK : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B55840", Offset = "0x2B53E40", VA = "0x182B55840")]
		internal AAHXLYOIIIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class DYURCQVOFAD : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B57AF0", Offset = "0x2B560F0", VA = "0x182B57AF0")]
		internal DYURCQVOFAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class TXZXBELKWZG : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B62940", Offset = "0x2B60F40", VA = "0x182B62940")]
		internal TXZXBELKWZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class VKGPPEWTJBO : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B63680", Offset = "0x2B61C80", VA = "0x182B63680")]
		internal VKGPPEWTJBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ZLTTAJJJXYP : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B65E40", Offset = "0x2B64440", VA = "0x182B65E40")]
		internal ZLTTAJJJXYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class IMTHDXWSSSK : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B59FE0", Offset = "0x2B585E0", VA = "0x182B59FE0")]
		internal IMTHDXWSSSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class OJMKOVQZCBW : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EC90", Offset = "0x2B5D290", VA = "0x182B5EC90")]
		internal OJMKOVQZCBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class VIFQFDBVJKQ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B634A0", Offset = "0x2B61AA0", VA = "0x182B634A0")]
		internal VIFQFDBVJKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class PCERBIGFFJG : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EED0", Offset = "0x2B5D4D0", VA = "0x182B5EED0")]
		internal PCERBIGFFJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class YJODRTLJPQA : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B64980", Offset = "0x2B62F80", VA = "0x182B64980")]
		internal YJODRTLJPQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class RLWGAZXTXZC : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B61860", Offset = "0x2B5FE60", VA = "0x182B61860")]
		internal RLWGAZXTXZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class TYRJATBQMVW : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B62B20", Offset = "0x2B61120", VA = "0x182B62B20")]
		internal TYRJATBQMVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class IPASRSSRDDY : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A1C0", Offset = "0x2B587C0", VA = "0x182B5A1C0")]
		internal IPASRSSRDDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class BTAYYLEISPI : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B560E0", Offset = "0x2B546E0", VA = "0x182B560E0")]
		internal BTAYYLEISPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class TEYMPPAWRIC : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B61CD0", Offset = "0x2B602D0", VA = "0x182B61CD0")]
		internal TEYMPPAWRIC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class VHCLVPKIDNF : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B632C0", Offset = "0x2B618C0", VA = "0x182B632C0")]
		internal VHCLVPKIDNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ZYKFPPJZUSF : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B66020", Offset = "0x2B64620", VA = "0x182B66020")]
		internal ZYKFPPJZUSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class MKVMCXMLPWJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DBE0", Offset = "0x2B5C1E0", VA = "0x182B5DBE0")]
		internal MKVMCXMLPWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class VBGVMTVGNLJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B62C60", Offset = "0x2B61260", VA = "0x182B62C60")]
		internal VBGVMTVGNLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class RACALLEYZNB : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2B60DB0", Offset = "0x2B5F3B0", VA = "0x182B60DB0")]
		internal RACALLEYZNB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class TJFSJARXZZC : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B61F10", Offset = "0x2B60510", VA = "0x182B61F10")]
		internal TJFSJARXZZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class LOPPESZPQKV : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DA00", Offset = "0x2B5C000", VA = "0x182B5DA00")]
		internal LOPPESZPQKV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class CYRAQRATTWO : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B57910", Offset = "0x2B55F10", VA = "0x182B57910")]
		internal CYRAQRATTWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ZLEHQHHQXKJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B65A80", Offset = "0x2B64080", VA = "0x182B65A80")]
		internal ZLEHQHHQXKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class CXTQWFKTYKH : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2B56E50", Offset = "0x2B55450", VA = "0x182B56E50")]
		internal CXTQWFKTYKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class PGFCAPQBXWR : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F0B0", Offset = "0x2B5D6B0", VA = "0x182B5F0B0")]
		internal PGFCAPQBXWR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class NIVUSZHHNGA : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E3F0", Offset = "0x2B5C9F0", VA = "0x182B5E3F0")]
		internal NIVUSZHHNGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class XGKUQKTEBOB : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2B64120", Offset = "0x2B62720", VA = "0x182B64120")]
		internal XGKUQKTEBOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class FNZMLSFENTO : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2B588F0", Offset = "0x2B56EF0", VA = "0x182B588F0")]
		internal FNZMLSFENTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class IDPKBBCHJBU : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2B59E00", Offset = "0x2B58400", VA = "0x182B59E00")]
		internal IDPKBBCHJBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class JJMLZHLISGS : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AED0", Offset = "0x2B594D0", VA = "0x182B5AED0")]
		internal JJMLZHLISGS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class XQCZXSYWYDT : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2B644E0", Offset = "0x2B62AE0", VA = "0x182B644E0")]
		internal XQCZXSYWYDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XLWKUUJUGLZ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B64300", Offset = "0x2B62900", VA = "0x182B64300")]
		internal XLWKUUJUGLZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class MSPOBEJNDMJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DE20", Offset = "0x2B5C420", VA = "0x182B5DE20")]
		internal MSPOBEJNDMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class BPATAZQEDIK : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2B55F00", Offset = "0x2B54500", VA = "0x182B55F00")]
		internal BPATAZQEDIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class FGFVYVAQCJJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B58250", Offset = "0x2B56850", VA = "0x182B58250")]
		internal FGFVYVAQCJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class LJJVWBEUHPJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D640", Offset = "0x2B5BC40", VA = "0x182B5D640")]
		internal LJJVWBEUHPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class NJJFUEOWRII : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E5D0", Offset = "0x2B5CBD0", VA = "0x182B5E5D0")]
		internal NJJFUEOWRII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class JHFAGYNVCCM : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AA90", Offset = "0x2B59090", VA = "0x182B5AA90")]
		internal JHFAGYNVCCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class YZTXCKNTPHW : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2B64F40", Offset = "0x2B63540", VA = "0x182B64F40")]
		internal YZTXCKNTPHW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class LJBBOKJVDYD : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D460", Offset = "0x2B5BA60", VA = "0x182B5D460")]
		internal LJBBOKJVDYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class FGCOLJHITSP : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B58070", Offset = "0x2B56670", VA = "0x182B58070")]
		internal FGCOLJHITSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PMBJBJOLUYQ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F290", Offset = "0x2B5D890", VA = "0x182B5F290")]
		internal PMBJBJOLUYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class GRMJEUZSWHX : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2B59240", Offset = "0x2B57840", VA = "0x182B59240")]
		internal GRMJEUZSWHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class IAUMSAFRNVO : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B59C20", Offset = "0x2B58220", VA = "0x182B59C20")]
		internal IAUMSAFRNVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class LFCPXKZEKBF : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D280", Offset = "0x2B5B880", VA = "0x182B5D280")]
		internal LFCPXKZEKBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class XQZXZUOYDCD : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B64740", Offset = "0x2B62D40", VA = "0x182B64740")]
		internal XQZXZUOYDCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class PMGSULMHYYQ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F470", Offset = "0x2B5DA70", VA = "0x182B5F470")]
		internal PMGSULMHYYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class VTBPJWVAYPA : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B63860", Offset = "0x2B61E60", VA = "0x182B63860")]
		internal VTBPJWVAYPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class QJVQXUCCGUJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2B60BD0", Offset = "0x2B5F1D0", VA = "0x182B60BD0")]
		internal QJVQXUCCGUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class AZRAKTVZWHY : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2B55B40", Offset = "0x2B54140", VA = "0x182B55B40")]
		internal AZRAKTVZWHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class PRJABTZAXZF : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F650", Offset = "0x2B5DC50", VA = "0x182B5F650")]
		internal PRJABTZAXZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class CTSIXCZYLHJ : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2B56C70", Offset = "0x2B55270", VA = "0x182B56C70")]
		internal CTSIXCZYLHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class ZLHYUPXOPIV : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2B65C60", Offset = "0x2B64260", VA = "0x182B65C60")]
		internal ZLHYUPXOPIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class BICHSXFIPCT : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B55D20", Offset = "0x2B54320", VA = "0x182B55D20")]
		internal BICHSXFIPCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class IXMDXYEDGWG : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A750", Offset = "0x2B58D50", VA = "0x182B5A750")]
		internal IXMDXYEDGWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class EDPWGKZPYJD : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B57CD0", Offset = "0x2B562D0", VA = "0x182B57CD0")]
		internal EDPWGKZPYJD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class FREDHHJPSQV : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B58AD0", Offset = "0x2B570D0", VA = "0x182B58AD0")]
		internal FREDHHJPSQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class EXMDITOKVEY : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2B57F10", Offset = "0x2B56510", VA = "0x182B57F10")]
		internal EXMDITOKVEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class LKFUMPYRVNP : SIQLLRWEZBU
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D8A0", Offset = "0x2B5BEA0", VA = "0x182B5D8A0")]
		internal LKFUMPYRVNP()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public readonly struct NamedType : IEquatable<NamedType>, DAMLRSAATDB<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public readonly WPCWYXTKXZN Type;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
		private NamedType(string name, WPCWYXTKXZN type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2A96360", Offset = "0x2A94960", VA = "0x182A96360")]
		public static NamedType New(string name, WPCWYXTKXZN type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EA10", Offset = "0x2B5D010", VA = "0x182B5EA10")]
		public static bool HCJGUXGANNO([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EA10", Offset = "0x2B5D010", VA = "0x182B5EA10", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EA10", Offset = "0x2B5D010", VA = "0x182B5EA10")]
		public bool WYCXDAIGFPQ([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EA60", Offset = "0x2B5D060", VA = "0x182B5EA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EB20", Offset = "0x2B5D120", VA = "0x182B5EB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EC50", Offset = "0x2B5D250", VA = "0x182B5EC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EC10", Offset = "0x2B5D210", VA = "0x182B5EC10")]
		public string TMPRINADSVS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EB90", Offset = "0x2B5D190", VA = "0x182B5EB90")]
		public string NXENMGNHQZS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EA10", Offset = "0x2B5D010", VA = "0x182B5EA10", Slot = "5")]
		private bool CUSNAVRFTLB([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public interface MPBKAGBRDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, IQRQYBTPXGA>> BSXHMYMHCVC(LOHJEAGYXDY a, bool b);
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
