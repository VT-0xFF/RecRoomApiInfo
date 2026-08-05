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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB2FF0", Offset = "0x2BB1DF0", VA = "0x182BB2FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAE860", Offset = "0x2BAD660", VA = "0x182BAE860", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class FYQSCVWBVAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB880", Offset = "0x2BAA680", VA = "0x182BAB880")]
		public static bool ZPEMBXECBQO(this QUZNMKSIOOE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB7C0", Offset = "0x2BAA5C0", VA = "0x182BAB7C0")]
		public static bool ZPEMBXECBQO(this HKXMWIVRURF a)
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
			private readonly KVHMMDKOSSW _staticNetSys;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			public EVRequest(KVHMMDKOSSW staticNetSys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class NGTPGPVKUVD
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly Dictionary<Id32<PHWOQEQTVHI>, MRGQHRTIEKL> JRFLHXFGEMW;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static HashSet<Id32<PHWOQEQTVHI>>? FPKXKPNSMOW;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Id32<PHWOQEQTVHI> RJBIAJLIIHG;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Id32<PHWOQEQTVHI> PECWFBFPTRX;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Id32<PHWOQEQTVHI> DDQSBDTZECM;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Id32<PHWOQEQTVHI> RFGAIFFTFUR;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Id32<PHWOQEQTVHI> OKFXYLBYHPA;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Id32<PHWOQEQTVHI> DXHWYOUSVGZ;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Id32<PHWOQEQTVHI> FHMWFGURYIZ;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Id32<PHWOQEQTVHI> ERDIBDXYPFD;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Id32<PHWOQEQTVHI> KMUCTKHBQYJ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Id32<PHWOQEQTVHI> LKVWNVZVXUF;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Id32<PHWOQEQTVHI> JINXTKHEFXT;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Id32<PHWOQEQTVHI> XIDFDNBXUCT;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Id32<PHWOQEQTVHI> UJFVQMJBXVU;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Id32<PHWOQEQTVHI> UHHYOVDWNHQ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Id32<PHWOQEQTVHI> WOGWQMYJULW;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Id32<PHWOQEQTVHI> XODGIEVPVGT;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Id32<PHWOQEQTVHI> JHEDTDAJYXE;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Id32<PHWOQEQTVHI> CMVVRHLFFTK;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Id32<PHWOQEQTVHI> NAAHWXUPHKD;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Id32<PHWOQEQTVHI> SVLAJVNJRWI;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Id32<PHWOQEQTVHI> JWCUGFPFQYH;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Id32<PHWOQEQTVHI> RMAPHYLSGFS;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Id32<PHWOQEQTVHI> NZOEOPAZQHS;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Id32<PHWOQEQTVHI> CXIWPUFSTAH;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Id32<PHWOQEQTVHI> YUDTQOUDTOL;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Id32<PHWOQEQTVHI> WZGNKMQKQRQ;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Id32<PHWOQEQTVHI> VUVMHQTZYWR;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Id32<PHWOQEQTVHI> YUWZFNAAZIO;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Id32<PHWOQEQTVHI> PJGTUNRBMLA;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Id32<PHWOQEQTVHI> QQIKMNCSXAM;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Id32<PHWOQEQTVHI> WKLNLGXSBWO;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly Id32<PHWOQEQTVHI> XPEKGDHPKVR;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Id32<PHWOQEQTVHI> BXICTYALUGU;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Id32<PHWOQEQTVHI> OBHSSSHNBTO;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Id32<PHWOQEQTVHI> TLJZCEPSIDQ;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Id32<PHWOQEQTVHI> FFCZZEVURNB;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Id32<PHWOQEQTVHI> YISLECQNEEU;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Id32<PHWOQEQTVHI> ONKNUDABYBX;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Id32<PHWOQEQTVHI> RBIBQNCPFSJ;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Id32<PHWOQEQTVHI> BCJQFYWWDXN;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Id32<PHWOQEQTVHI> PXWICFQJHRG;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Id32<PHWOQEQTVHI> VPSYWACJVKE;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Id32<PHWOQEQTVHI> YFDSXBEROGJ;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public static readonly Id32<PHWOQEQTVHI> LXCMOLGNYWU;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly Id32<PHWOQEQTVHI> JUQAWKXOTCW;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public static readonly Id32<PHWOQEQTVHI> RSQOMRHCKRO;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly Id32<PHWOQEQTVHI> XKEHILBADAF;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly Id32<PHWOQEQTVHI> JYPGNRAPQAR;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly Id32<PHWOQEQTVHI> DARWLZJWRZP;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly Id32<PHWOQEQTVHI> EXVCTOYGULS;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly Id32<PHWOQEQTVHI> ELJOKYGNRFS;

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public static readonly Id32<PHWOQEQTVHI> DKCRZFWWPDL;

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly Id32<PHWOQEQTVHI> NPSYIOSQKXI;

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public static readonly Id32<PHWOQEQTVHI> MGWRRGLKNOE;

			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly Id32<PHWOQEQTVHI> XCROXDYUCVB;

			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly Id32<PHWOQEQTVHI> IAAQJMMKAYH;

			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly Id32<PHWOQEQTVHI> MYYQQSFCEFF;

			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly Id32<PHWOQEQTVHI> PXLAYGOATKD;

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly Id32<PHWOQEQTVHI> AMTFXJGZHPA;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly Id32<PHWOQEQTVHI> ZBVTQZUUTYR;

			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly Id32<PHWOQEQTVHI> CONMRISZEGH;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly Id32<PHWOQEQTVHI> ULCGZNIMDAZ;

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public static readonly Id32<PHWOQEQTVHI> HUOJKYJISDM;

			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public static readonly Id32<PHWOQEQTVHI> XKFVZBSVKSU;

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly Id32<PHWOQEQTVHI> ICRWDAXJOAH;

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly Id32<PHWOQEQTVHI> FTIRVUAJFZS;

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly Id32<PHWOQEQTVHI> EFKMHAHDCDP;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly Id32<PHWOQEQTVHI> SLPNNRPPHFZ;

			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly Id32<PHWOQEQTVHI> TYCFVKNRFKZ;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static IReadOnlyDictionary<Id32<PHWOQEQTVHI>, MRGQHRTIEKL> SODNTQDYYEF
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0x2BAEAB0", Offset = "0x2BAD8B0", VA = "0x182BAEAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BAEB00", Offset = "0x2BAD900", VA = "0x182BAEB00")]
			public static MRGQHRTIEKL MLVCLNTQCWT(Id32<PHWOQEQTVHI> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE8E0", Offset = "0x2BAD6E0", VA = "0x182BAE8E0")]
			public static bool ADDLSABBSJK(Id32<PHWOQEQTVHI> id, [Out] MRGQHRTIEKL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2BAEA00", Offset = "0x2BAD800", VA = "0x182BAEA00")]
			public static QUZNMKSIOOE DVZEVEMQJXY(Id32<PHWOQEQTVHI> id)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE970", Offset = "0x2BAD770", VA = "0x182BAE970")]
			private static Id32<PHWOQEQTVHI> CBYRPQCEVDS(MRGQHRTIEKL a, Id32<PHWOQEQTVHI> id)
			{
				return default(Id32<PHWOQEQTVHI>);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2BAEB80", Offset = "0x2BAD980", VA = "0x182BAEB80")]
			private static void MRGWPCWIMTE(Id32<PHWOQEQTVHI> id)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class UOMHQENYDVE
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private struct TypeRegistryFactory
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				private IdUnsafeList<YMZQCHJNMJC, QUZNMKSIOOE?> _registeredCircuitTypes;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
				private TypeRegistryFactory([In] IdUnsafeList<YMZQCHJNMJC, QUZNMKSIOOE?> registeredCircuitTypes)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB6A0", Offset = "0x2BBA4A0", VA = "0x182BBB6A0")]
				public static TypeRegistryFactory AZAFAXRXEYK()
				{
					return default(TypeRegistryFactory);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB8D0", Offset = "0x2BBA6D0", VA = "0x182BBB8D0")]
				public (ReadOnlyIdArray<YMZQCHJNMJC, QUZNMKSIOOE>, IReadOnlyDictionary<QUZNMKSIOOE, Id32<YMZQCHJNMJC>>) YTMSCNEQASK()
				{
					return default((ReadOnlyIdArray<YMZQCHJNMJC, QUZNMKSIOOE>, IReadOnlyDictionary<QUZNMKSIOOE, Id32<YMZQCHJNMJC>>));
				}

				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB750", Offset = "0x2BBA550", VA = "0x182BBB750")]
				public Id32<YMZQCHJNMJC> XKEIICJNTMM(int a, QUZNMKSIOOE b)
				{
					return default(Id32<YMZQCHJNMJC>);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB700", Offset = "0x2BBA500", VA = "0x182BBB700")]
				public Id32<YMZQCHJNMJC> Initialize(int id, HLUORRWSTUX type, HLUORRWSTUX factoryType)
				{
					return default(Id32<YMZQCHJNMJC>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class SFDWNHKXBUZ
			{
				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Id32<YMZQCHJNMJC> SUZZIYUSVDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB620", Offset = "0x2BBA420", VA = "0x182BBB620")]
					[CompilerGenerated]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB520", Offset = "0x2BBA320", VA = "0x182BBB520")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Id32<YMZQCHJNMJC> DHITGJJTEFK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB460", Offset = "0x2BBA260", VA = "0x182BBB460")]
					[CompilerGenerated]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB4A0", Offset = "0x2BBA2A0", VA = "0x182BBB4A0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Id32<YMZQCHJNMJC> RCTXLAFBAWL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB660", Offset = "0x2BBA460", VA = "0x182BBB660")]
					[CompilerGenerated]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB5E0", Offset = "0x2BBA3E0", VA = "0x182BBB5E0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Id32<YMZQCHJNMJC> QAPGWLOCXWX
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB4E0", Offset = "0x2BBA2E0", VA = "0x182BBB4E0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB420", Offset = "0x2BBA220", VA = "0x182BBB420")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Id32<YMZQCHJNMJC> IZHNBLYRWVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB5A0", Offset = "0x2BBA3A0", VA = "0x182BBB5A0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB560", Offset = "0x2BBA360", VA = "0x182BBB560")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Id32<YMZQCHJNMJC> MCVUOMRFQYS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB3A0", Offset = "0x2BBA1A0", VA = "0x182BBB3A0")]
					[CompilerGenerated]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x2BBB3E0", Offset = "0x2BBA1E0", VA = "0x182BBB3E0")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class IUARDPBQNWZ : IEnumerable<QUZNMKSIOOE>, IEnumerable, IEnumerator<QUZNMKSIOOE>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int AKEYILDVZEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private QUZNMKSIOOE OCEUOVLOMMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				private int AYLQLTGRUAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private bool IZPURAAQLLU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public bool GOONEPZXIJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private RoomVersion OVNAWXVZGYK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public RoomVersion PUTABWQHIKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private bool KTQQYQCVKYB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public bool DTGASDQGNZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				private bool IRQHETLNHSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public bool JFPJDHTBQZC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private bool RDXSMSDWSTL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public bool QUIBKYPVGDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				private bool LURXALFLLTV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public bool CVAMYJDGOIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private IEnumerator<QUZNMKSIOOE> ULWCKXMDKCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				private QUZNMKSIOOE UBGOOYJHKVY;

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				private QUZNMKSIOOE XSDGVSTDTRN
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				private object ELQJLQJBXAL
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
				[DebuggerHidden]
				public IUARDPBQNWZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BADF30", Offset = "0x2BACD30", VA = "0x182BADF30", Slot = "7")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BADA80", Offset = "0x2BAC880", VA = "0x182BADA80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x2BAE000", Offset = "0x2BACE00", VA = "0x182BAE000")]
				private void RHNDEQIOOEK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x2BADFC0", Offset = "0x2BACDC0", VA = "0x182BADFC0", Slot = "10")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x2BADE70", Offset = "0x2BACC70", VA = "0x182BADE70", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QUZNMKSIOOE> NAULDWJZXDK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BADE70", Offset = "0x2BACC70", VA = "0x182BADE70", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UJBMGYABLAM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class IQRIDHWZMST : IEnumerable<QUZNMKSIOOE>, IEnumerable, IEnumerator<QUZNMKSIOOE>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				private int AKEYILDVZEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				private QUZNMKSIOOE OCEUOVLOMMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				private int AYLQLTGRUAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				private RoomVersion OVNAWXVZGYK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public RoomVersion PUTABWQHIKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				private bool IRQHETLNHSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public bool JFPJDHTBQZC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private bool KTQQYQCVKYB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public bool DTGASDQGNZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private bool OKKJFPAIXIV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public bool NEHQZFZUXEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private bool RDXSMSDWSTL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public bool QUIBKYPVGDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private bool QWJIAYKAEVH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				private bool WHQXULCALTX;

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				private QUZNMKSIOOE XSDGVSTDTRN
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				private object ELQJLQJBXAL
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
				[DebuggerHidden]
				public IQRIDHWZMST(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BABA80", Offset = "0x2BAA880", VA = "0x182BABA80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x2BADA40", Offset = "0x2BAC840", VA = "0x182BADA40", Slot = "10")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x2BAD990", Offset = "0x2BAC790", VA = "0x182BAD990", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QUZNMKSIOOE> NAULDWJZXDK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x2BAD990", Offset = "0x2BAC790", VA = "0x182BAD990", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UJBMGYABLAM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class RRJIYBEYTIQ : IEnumerable<Id32<YMZQCHJNMJC>>, IEnumerable, IEnumerator<Id32<YMZQCHJNMJC>>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				private int AKEYILDVZEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private Id32<YMZQCHJNMJC> OCEUOVLOMMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private int AYLQLTGRUAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private RoomVersion OVNAWXVZGYK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public RoomVersion PUTABWQHIKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private bool KTQQYQCVKYB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public bool DTGASDQGNZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private bool IRQHETLNHSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public bool JFPJDHTBQZC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private bool RDXSMSDWSTL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public bool QUIBKYPVGDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private bool LURXALFLLTV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public bool CVAMYJDGOIW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				private IEnumerator<QUZNMKSIOOE> ULWCKXMDKCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private IEnumerator<HLUORRWSTUX> ULGHTDELHUA;

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				private Id32<YMZQCHJNMJC> ZZKNHIQGSMQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(Id32<YMZQCHJNMJC>);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				private object ELQJLQJBXAL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x2BBAB00", Offset = "0x2BB9900", VA = "0x182BBAB00", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x15A3320", Offset = "0x15A2120", VA = "0x1815A3320")]
				[DebuggerHidden]
				public RRJIYBEYTIQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB050", Offset = "0x2BB9E50", VA = "0x182BBB050", Slot = "7")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x2BBAB50", Offset = "0x2BB9950", VA = "0x182BBAB50", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB230", Offset = "0x2BBA030", VA = "0x182BBB230")]
				private void RHNDEQIOOEK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB1E0", Offset = "0x2BB9FE0", VA = "0x182BBB1E0")]
				private void RHHWHJORETB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB1A0", Offset = "0x2BB9FA0", VA = "0x182BBB1A0", Slot = "10")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB280", Offset = "0x2BBA080", VA = "0x182BBB280", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<Id32<YMZQCHJNMJC>> WRLMVJKGFUT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x2BBB280", Offset = "0x2BBA080", VA = "0x182BBB280", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UJBMGYABLAM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private static readonly Log KNJEMMUNATP;

			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private static ReadOnlyIdArray<YMZQCHJNMJC, QUZNMKSIOOE?> ZZSJQJYMLKZ;

			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private static IReadOnlyDictionary<QUZNMKSIOOE, Id32<YMZQCHJNMJC>> HXSGJYTIJPD;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly HKXMWIVRURF YRNEQKREDVO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly HKXMWIVRURF IGAKCYVDZRM;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private static readonly HashSet<QUZNMKSIOOE> TQMTUPWYVLW;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static List<QUZNMKSIOOE> ICDZYHZKCPJ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public static GetSet RQLAFBFZUPM
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public static GetSet XARAEXEVRXU
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public static GetSet ILHRHFAUNHQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0")]
				get
				{
					return default(GetSet);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public static QUZNMKSIOOE SUZZIYUSVDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC08C0", Offset = "0x2BBF6C0", VA = "0x182BC08C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public static QUZNMKSIOOE DHITGJJTEFK
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD920", Offset = "0x2BBC720", VA = "0x182BBD920")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public static QUZNMKSIOOE RCTXLAFBAWL
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0A60", Offset = "0x2BBF860", VA = "0x182BC0A60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public static QUZNMKSIOOE QAPGWLOCXWX
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDC90", Offset = "0x2BBCA90", VA = "0x182BBDC90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public static QUZNMKSIOOE NSNZQDFVDLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDA10", Offset = "0x2BBC810", VA = "0x182BBDA10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public static QUZNMKSIOOE ABECZOKNUII
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF680", Offset = "0x2BBE480", VA = "0x182BBF680")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public static QUZNMKSIOOE JOTGRXAUZFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDB00", Offset = "0x2BBC900", VA = "0x182BBDB00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public static QUZNMKSIOOE IZHNBLYRWVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF0E0", Offset = "0x2BBDEE0", VA = "0x182BBF0E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public static HLUORRWSTUX EACKTUMRYEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x2BC06A0", Offset = "0x2BBF4A0", VA = "0x182BC06A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public static HLUORRWSTUX KLXBZLXUZJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF630", Offset = "0x2BBE430", VA = "0x182BBF630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public static HLUORRWSTUX PXPONMHDWEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDF00", Offset = "0x2BBCD00", VA = "0x182BBDF00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public static HLUORRWSTUX ZZMMZKXPKYR
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0A10", Offset = "0x2BBF810", VA = "0x182BC0A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public static HLUORRWSTUX VYPYJYUMMGB
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDC40", Offset = "0x2BBCA40", VA = "0x182BBDC40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public static HLUORRWSTUX OEDEGDNZPCO
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCD80", Offset = "0x2BBBB80", VA = "0x182BBCD80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public static HLUORRWSTUX LAXSVXGFWJC
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF170", Offset = "0x2BBDF70", VA = "0x182BBF170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public static HLUORRWSTUX RMPCDQESTTM
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDB90", Offset = "0x2BBC990", VA = "0x182BBDB90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public static HLUORRWSTUX ENCSJEYIEWR
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF5E0", Offset = "0x2BBE3E0", VA = "0x182BBF5E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public static HLUORRWSTUX JVDQPCCLJAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x2BBC910", Offset = "0x2BBB710", VA = "0x182BBC910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public static HLUORRWSTUX XBPUZCJZCDU
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0240", Offset = "0x2BBF040", VA = "0x182BC0240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public static HLUORRWSTUX LILMCBBHMKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFFB0", Offset = "0x2BBEDB0", VA = "0x182BBFFB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public static HLUORRWSTUX IQVASHNUXLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEB70", Offset = "0x2BBD970", VA = "0x182BBEB70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public static HLUORRWSTUX OYIDYEYXSXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE4E0", Offset = "0x2BBD2E0", VA = "0x182BBE4E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public static HLUORRWSTUX ZHYCQVYYIHJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCAE0", Offset = "0x2BBB8E0", VA = "0x182BBCAE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public static HLUORRWSTUX UHJCAHWGVUX
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0000", Offset = "0x2BBEE00", VA = "0x182BC0000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public static HLUORRWSTUX GIWLSKQJNUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0BB0", Offset = "0x2BBF9B0", VA = "0x182BC0BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public static HLUORRWSTUX XJQMPUBQZLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFF50", Offset = "0x2BBED50", VA = "0x182BBFF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public static HLUORRWSTUX EIPHRVOXYVI
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF910", Offset = "0x2BBE710", VA = "0x182BBF910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public static HLUORRWSTUX VUSOJHOAAYI
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFA30", Offset = "0x2BBE830", VA = "0x182BBFA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public static HLUORRWSTUX LPGWYBUFZLD
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD4D0", Offset = "0x2BBC2D0", VA = "0x182BBD4D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public static HLUORRWSTUX MAWLGMKAAVG
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE350", Offset = "0x2BBD150", VA = "0x182BBE350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public static HLUORRWSTUX DTNFZWHYHKS
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF520", Offset = "0x2BBE320", VA = "0x182BBF520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public static HLUORRWSTUX QRROEUXPOFI
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0290", Offset = "0x2BBF090", VA = "0x182BC0290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public static HLUORRWSTUX YGGYJCHARBA
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x2BC03B0", Offset = "0x2BBF1B0", VA = "0x182BC03B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public static HLUORRWSTUX KVIPTFNWZON
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0950", Offset = "0x2BBF750", VA = "0x182BC0950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public static HLUORRWSTUX MKECSWATDWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF460", Offset = "0x2BBE260", VA = "0x182BBF460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public static HLUORRWSTUX ZBZULZDSMAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD410", Offset = "0x2BBC210", VA = "0x182BBD410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public static HLUORRWSTUX QGOKNMVRYKS
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEE30", Offset = "0x2BBDC30", VA = "0x182BBEE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public static HLUORRWSTUX BUIHEDSUHPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE910", Offset = "0x2BBD710", VA = "0x182BBE910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public static HLUORRWSTUX ODLLSMKRYMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0AF0", Offset = "0x2BBF8F0", VA = "0x182BC0AF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public static HLUORRWSTUX SAPKXZDQQCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0060", Offset = "0x2BBEE60", VA = "0x182BC0060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public static HLUORRWSTUX ZWRBEQGJREB
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x2BC02F0", Offset = "0x2BBF0F0", VA = "0x182BC02F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public static HLUORRWSTUX ZJLNHDIKAYG
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD3B0", Offset = "0x2BBC1B0", VA = "0x182BBD3B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public static HLUORRWSTUX TIJSUSGZJER
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x2BC06F0", Offset = "0x2BBF4F0", VA = "0x182BC06F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public static HLUORRWSTUX MRSSUYHIHDF
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF790", Offset = "0x2BBE590", VA = "0x182BBF790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public static HLUORRWSTUX VLTZAHIPKUN
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF1C0", Offset = "0x2BBDFC0", VA = "0x182BBF1C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public static HLUORRWSTUX SWAIABHPFLC
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDAA0", Offset = "0x2BBC8A0", VA = "0x182BBDAA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public static HLUORRWSTUX LPAGAXNINZU
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCA20", Offset = "0x2BBB820", VA = "0x182BBCA20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public static HLUORRWSTUX DQRYKKUKERF
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x2BBECE0", Offset = "0x2BBDAE0", VA = "0x182BBECE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public static HLUORRWSTUX JPYJNXGGYYT
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x2BBC8B0", Offset = "0x2BBB6B0", VA = "0x182BBC8B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public static HLUORRWSTUX WGIMUTNAOLR
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x2BC09B0", Offset = "0x2BBF7B0", VA = "0x182BC09B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public static HLUORRWSTUX OQTZGVAECEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF3A0", Offset = "0x2BBE1A0", VA = "0x182BBF3A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public static HLUORRWSTUX FNVBVWNQJYS
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE410", Offset = "0x2BBD210", VA = "0x182BBE410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public static HLUORRWSTUX ZWETSXJGCWC
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDD20", Offset = "0x2BBCB20", VA = "0x182BBDD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public static HLUORRWSTUX SIOYKFQMZBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF7F0", Offset = "0x2BBE5F0", VA = "0x182BBF7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public static HLUORRWSTUX XQIEAKUGPAX
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCE90", Offset = "0x2BBBC90", VA = "0x182BBCE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static HLUORRWSTUX NYLBLAJDEXE
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDDE0", Offset = "0x2BBCBE0", VA = "0x182BBDDE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public static HLUORRWSTUX ZJSJLAMNXLW
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCFB0", Offset = "0x2BBBDB0", VA = "0x182BBCFB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public static HLUORRWSTUX JUDMHSVVNFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCBA0", Offset = "0x2BBB9A0", VA = "0x182BBCBA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public static HLUORRWSTUX KIMYFQMDJBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD470", Offset = "0x2BBC270", VA = "0x182BBD470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public static HLUORRWSTUX GVLPBUXIQKD
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCB40", Offset = "0x2BBB940", VA = "0x182BBCB40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public static HLUORRWSTUX YITIJWYCOAA
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCF50", Offset = "0x2BBBD50", VA = "0x182BBCF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public static HLUORRWSTUX DZSEWCBOLFZ
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFDD0", Offset = "0x2BBEBD0", VA = "0x182BBFDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public static HLUORRWSTUX YDMZBREHALE
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEA50", Offset = "0x2BBD850", VA = "0x182BBEA50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public static HLUORRWSTUX YNZNMQOBUGG
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE540", Offset = "0x2BBD340", VA = "0x182BBE540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public static HLUORRWSTUX IZGCRCTHWLS
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCE30", Offset = "0x2BBBC30", VA = "0x182BBCE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public static HLUORRWSTUX FAZSCVXPCII
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BC00C0", Offset = "0x2BBEEC0", VA = "0x182BC00C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public static HLUORRWSTUX KKQHCLVLZNV
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD2F0", Offset = "0x2BBC0F0", VA = "0x182BBD2F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public static HLUORRWSTUX SDUOOQWKJMU
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDBE0", Offset = "0x2BBC9E0", VA = "0x182BBDBE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public static HLUORRWSTUX KDHONBYXTBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF280", Offset = "0x2BBE080", VA = "0x182BBF280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public static HLUORRWSTUX JFBGTEXMRDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCA80", Offset = "0x2BBB880", VA = "0x182BBCA80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public static HLUORRWSTUX OVUSMCQBETM
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEC20", Offset = "0x2BBDA20", VA = "0x182BBEC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public static HLUORRWSTUX WYBVZEDFMCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD350", Offset = "0x2BBC150", VA = "0x182BBD350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public static HLUORRWSTUX AAIZUTCMALZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE1B0", Offset = "0x2BBCFB0", VA = "0x182BBE1B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public static HLUORRWSTUX XNJMFLRMRIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF580", Offset = "0x2BBE380", VA = "0x182BBF580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public static HLUORRWSTUX YXLSCHJMXPS
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE3B0", Offset = "0x2BBD1B0", VA = "0x182BBE3B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public static HLUORRWSTUX FWVARJPUCFS
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC07B0", Offset = "0x2BBF5B0", VA = "0x182BC07B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public static HLUORRWSTUX EVPHFNDONGL
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0B50", Offset = "0x2BBF950", VA = "0x182BC0B50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public static HLUORRWSTUX LDSSSPTGAPH
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF400", Offset = "0x2BBE200", VA = "0x182BBF400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public static HLUORRWSTUX ANARFOPLAAB
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDFB0", Offset = "0x2BBCDB0", VA = "0x182BBDFB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public static HLUORRWSTUX VMMNXKCMYES
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF080", Offset = "0x2BBDE80", VA = "0x182BBF080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public static HLUORRWSTUX LZEJYIKRYGN
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEE90", Offset = "0x2BBDC90", VA = "0x182BBEE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public static HLUORRWSTUX BFHJESLZGCF
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF970", Offset = "0x2BBE770", VA = "0x182BBF970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public static HLUORRWSTUX JKAAVNTBOOY
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0180", Offset = "0x2BBEF80", VA = "0x182BC0180")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public static HLUORRWSTUX CHBMUOMCKNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEDA0", Offset = "0x2BBDBA0", VA = "0x182BBEDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public static HLUORRWSTUX PVXDORYRUNR
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF2E0", Offset = "0x2BBE0E0", VA = "0x182BBF2E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public static HLUORRWSTUX HGRWIJHZTMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0580", Offset = "0x2BBF380", VA = "0x182BC0580")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public static HLUORRWSTUX IZBJVGXRTFY
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCC00", Offset = "0x2BBBA00", VA = "0x182BBCC00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public static HLUORRWSTUX CKADBIRZVTT
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0120", Offset = "0x2BBEF20", VA = "0x182BC0120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public static HLUORRWSTUX LEXIFTLSOEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD8C0", Offset = "0x2BBC6C0", VA = "0x182BBD8C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public static HLUORRWSTUX LTFVSFRTFBU
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDEA0", Offset = "0x2BBCCA0", VA = "0x182BBDEA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public static HLUORRWSTUX CDWJWGSALUP
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0C10", Offset = "0x2BBFA10", VA = "0x182BC0C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public static HLUORRWSTUX WKQUHYHZTVC
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCC60", Offset = "0x2BBBA60", VA = "0x182BBCC60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public static HLUORRWSTUX ABAPICMHPGM
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0520", Offset = "0x2BBF320", VA = "0x182BC0520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public static HLUORRWSTUX EBEAPFCICPM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF340", Offset = "0x2BBE140", VA = "0x182BBF340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public static HLUORRWSTUX GPYJLTBKJQS
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFEF0", Offset = "0x2BBECF0", VA = "0x182BBFEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public static HLUORRWSTUX DQDLJRJIGPK
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0410", Offset = "0x2BBF210", VA = "0x182BC0410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			public static HLUORRWSTUX YJZYFRLPYFB
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x2BBC960", Offset = "0x2BBB760", VA = "0x182BBC960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public static HLUORRWSTUX AWORDRRWRMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEAB0", Offset = "0x2BBD8B0", VA = "0x182BBEAB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public static HLUORRWSTUX CTJHKWZGEVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x2BC01E0", Offset = "0x2BBEFE0", VA = "0x182BC01E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public static HLUORRWSTUX IFQAQHIMRJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDE40", Offset = "0x2BBCC40", VA = "0x182BBDE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public static HLUORRWSTUX CZTCCVZGQVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE210", Offset = "0x2BBD010", VA = "0x182BBE210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			public static HLUORRWSTUX QSGYWUOQRFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCD20", Offset = "0x2BBBB20", VA = "0x182BBCD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			public static HLUORRWSTUX JFCVOLMRHUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEC80", Offset = "0x2BBDA80", VA = "0x182BBEC80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			public static HLUORRWSTUX ISAJCOFYQBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEBC0", Offset = "0x2BBD9C0", VA = "0x182BBEBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public static HLUORRWSTUX SMGHGTFNIVO
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDD80", Offset = "0x2BBCB80", VA = "0x182BBDD80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public static HLUORRWSTUX ZRBQJISAJBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF9D0", Offset = "0x2BBE7D0", VA = "0x182BBF9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public static HLUORRWSTUX ESBVTFXGXPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF850", Offset = "0x2BBE650", VA = "0x182BBF850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public static HLUORRWSTUX OHTYJJDPYFG
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0750", Offset = "0x2BBF550", VA = "0x182BC0750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public static HLUORRWSTUX IUGHAEKMHJC
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2BBEB10", Offset = "0x2BBD910", VA = "0x182BBEB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public static HLUORRWSTUX UCAOQXKOTCN
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF4C0", Offset = "0x2BBE2C0", VA = "0x182BBF4C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public static HLUORRWSTUX TOAVCTFRNQQ
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBE9F0", Offset = "0x2BBD7F0", VA = "0x182BBE9F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public static HLUORRWSTUX YRDFPOOUEVW
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0640", Offset = "0x2BBF440", VA = "0x182BC0640")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public static HLUORRWSTUX TEYVAWCFTZX
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF220", Offset = "0x2BBE020", VA = "0x182BBF220")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public static HLUORRWSTUX TXCWVJQJFEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x2BC0350", Offset = "0x2BBF150", VA = "0x182BC0350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public static HLUORRWSTUX BTNFFNKHCNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x2BBDF50", Offset = "0x2BBCD50", VA = "0x182BBDF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public static HLUORRWSTUX MDGUQSALHBU
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF020", Offset = "0x2BBDE20", VA = "0x182BBF020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public static HLUORRWSTUX ZVSORVMWGHS
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFD70", Offset = "0x2BBEB70", VA = "0x182BBFD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public static HLUORRWSTUX FWZCLDMDLHN
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCEF0", Offset = "0x2BBBCF0", VA = "0x182BBCEF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public static HLUORRWSTUX EDJUBMURCHT
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x2BBF8B0", Offset = "0x2BBE6B0", VA = "0x182BBF8B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public static HLUORRWSTUX HHPBUNMCSLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFE90", Offset = "0x2BBEC90", VA = "0x182BBFE90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public static HLUORRWSTUX USLTOIMKMMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCCC0", Offset = "0x2BBBAC0", VA = "0x182BBCCC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static HLUORRWSTUX EOWFZILKQDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCDD0", Offset = "0x2BBBBD0", VA = "0x182BBCDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public static HLUORRWSTUX IGTVDFYJJAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x2BBC9C0", Offset = "0x2BBB7C0", VA = "0x182BBC9C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public static HLUORRWSTUX TGZGREDNTQA
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x2BBED40", Offset = "0x2BBDB40", VA = "0x182BBED40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public static HLUORRWSTUX XDEOWUMJCXO
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x2BC05E0", Offset = "0x2BBF3E0", VA = "0x182BC05E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public static HLUORRWSTUX INYHZOFLVQK
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2BBFE30", Offset = "0x2BBEC30", VA = "0x182BBFE30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static HLUORRWSTUX XNGPKVSFRUD
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x2BBD9B0", Offset = "0x2BBC7B0", VA = "0x182BBD9B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE0C0", Offset = "0x2BBCEC0", VA = "0x182BBE0C0")]
			public static HKXMWIVRURF GNCAOCWJVYL([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE2A0", Offset = "0x2BBD0A0", VA = "0x182BBE2A0")]
			public static ClassFactoryTypeParams HJEMBSZVWGC(string a, [Optional] string b)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE270", Offset = "0x2BBD070", VA = "0x182BBE270")]
			public static ClassFactoryTypeParams HJEMBSZVWGC([Optional][In] Guid? id, [Optional] string a)
			{
				return default(ClassFactoryTypeParams);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD2C0", Offset = "0x2BBC0C0", VA = "0x182BBD2C0")]
			public static HKXMWIVRURF CUJTTFSJOLH(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEE00", Offset = "0x2BBDC00", VA = "0x182BBEE00")]
			public static HKXMWIVRURF LPGPBLHSASU(params CircuitTypeOrString[] types)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEEF0", Offset = "0x2BBDCF0", VA = "0x182BBEEF0")]
			public static HKXMWIVRURF MCVUOMRFQYS([In] CircuitTypeOrString elementType)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD530", Offset = "0x2BBC330", VA = "0x182BBD530")]
			public static QUZNMKSIOOE DVZEVEMQJXY(Id32<YMZQCHJNMJC> circuitTypeId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF710", Offset = "0x2BBE510", VA = "0x182BBF710")]
			public static string PLZHHOYIBLX(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD5E0", Offset = "0x2BBC3E0", VA = "0x182BBD5E0")]
			private static QUZNMKSIOOE DVZEVEMQJXY(CircuitTypeIdWrapper a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE470", Offset = "0x2BBD270", VA = "0x182BBE470")]
			public static Id32<YMZQCHJNMJC>? IFJZGMMGUHB(QUZNMKSIOOE a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE5A0", Offset = "0x2BBD3A0", VA = "0x182BBE5A0")]
			public static CircuitTypeIdWrapper? JJPJVZPZSMG(QUZNMKSIOOE a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0C70", Offset = "0x2BBFA70", VA = "0x182BC0C70")]
			static UOMHQENYDVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE010", Offset = "0x2BBCE10", VA = "0x182BBE010")]
			[IteratorStateMachine(typeof(IQRIDHWZMST))]
			private static IEnumerable<QUZNMKSIOOE> GHFLDVGEKPI(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0470", Offset = "0x2BBF270", VA = "0x182BC0470")]
			[IteratorStateMachine(typeof(IUARDPBQNWZ))]
			public static IEnumerable<QUZNMKSIOOE> VULUZOZSPDV(RoomVersion a, bool b, bool c, bool d, bool e, bool f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD010", Offset = "0x2BBBE10", VA = "0x182BBD010")]
			public static Variant CSMPLENRFQQ(QUZNMKSIOOE a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BBFA90", Offset = "0x2BBE890", VA = "0x182BBFA90")]
			public static Variant RJGSUSEVXXD(QUZNMKSIOOE a)
			{
				return default(Variant);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE970", Offset = "0x2BBD770", VA = "0x182BBE970")]
			public static bool JPKEFLHQJRZ(QUZNMKSIOOE a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2BC0810", Offset = "0x2BBF610", VA = "0x182BC0810")]
			[IteratorStateMachine(typeof(RRJIYBEYTIQ))]
			public static IEnumerable<Id32<YMZQCHJNMJC>> XWZPXIXRASR(RoomVersion a, bool b, bool c, bool d, bool e)
			{
				return null;
			}
		}
	}
}
namespace Circuits.Static.RecRoom.Serde
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class DZCHSMQMGKR
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA90D0", Offset = "0x2BA7ED0", VA = "0x182BA90D0")]
		public static IXZZCOCKZCI NYKTBLQYXAJ(this QUZNMKSIOOE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA1B0", Offset = "0x2BA8FB0", VA = "0x182BAA1B0")]
		public static QUZNMKSIOOE OFNDDMJZMSY(this IXZZCOCKZCI a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JHXUUDNXPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B42660", Offset = "0x3B41460", VA = "0x183B42660")]
		public static Dictionary<b, c> XXHEECMBKQI<b, c, a>(this RepeatedField<a> a, Func<a, b> b, Func<a, c> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class FQNBFHMTZMZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB620", Offset = "0x2BAA420", VA = "0x182BAB620")]
		public static DBLSZILXZOY NYKTBLQYXAJ([In] Guid self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB720", Offset = "0x2BAA520", VA = "0x182BAB720")]
		public static Guid OFNDDMJZMSY(DBLSZILXZOY a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class HYFLUFKQXJV
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB990", Offset = "0x2BAA790", VA = "0x182BAB990")]
		public static GJKSBYJKKSG NYKTBLQYXAJ([In] this NamedType self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA20", Offset = "0x2BAA820", VA = "0x182BABA20")]
		public static NamedType OFNDDMJZMSY(this GJKSBYJKKSG a)
		{
			return default(NamedType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class XAIWXHVZBAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x410C210", Offset = "0x410B010", VA = "0x18410C210")]
		public static void LMZZNKCMKGC<a, b>(this IReadOnlyCollection<a> a, RepeatedField<b> b, Func<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x410C470", Offset = "0x410B270", VA = "0x18410C470")]
		public static void LMZZNKCMKGC<c, d>(this IReadOnlyCollection<c> a, RepeatedField<d> b, InFunc<c, d> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class LYSEAVDYGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE510", Offset = "0x2BAD310", VA = "0x182BAE510")]
		public static KCNGXKPKFEO NYKTBLQYXAJ([In] this Variant self, QUZNMKSIOOE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE710", Offset = "0x2BAD510", VA = "0x182BAE710")]
		public static Variant OFNDDMJZMSY(this KCNGXKPKFEO a)
		{
			return default(Variant);
		}
	}
}
namespace Circuits.Static.RecRoom.ObjectDefs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class NSYPRDYOSDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Id128<WDRPUXFLQCP> LOUSXGFJLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly bool DANLLUIHANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly bool ILUMHZPDFVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly bool FVPLAGOLHVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly bool NDCYOCFBQQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly bool NCNDWHXJOIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly bool IHOMUHTFSDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly bool KARYECKJKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly bool UDIZRJKEUUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<(string Name, QUZNMKSIOOE Type)> WLMMEVMXTQX;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[WillBeRenamedTo("LegacyId")]
		public Guid CRWLHSKOIBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B6D660", Offset = "0x2B6C460", VA = "0x182B6D660")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Id128<WDRPUXFLQCP> TGYERCKCHVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B6D660", Offset = "0x2B6C460", VA = "0x182B6D660")]
			get
			{
				return default(Id128<WDRPUXFLQCP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public IReadOnlyList<(string Name, QUZNMKSIOOE Type)> XBBDAYCHWNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NKWBTIJXGGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2BB25E0", Offset = "0x2BB13E0", VA = "0x182BB25E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2290", Offset = "0x2BB1090", VA = "0x182BB2290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<string, QUZNMKSIOOE> QYVBCTCPTXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2820", Offset = "0x2BB1620", VA = "0x182BB2820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2DB0", Offset = "0x2BB1BB0", VA = "0x182BB2DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<int> PPJAZOCHESZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2680", Offset = "0x2BB1480", VA = "0x182BB2680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BB21E0", Offset = "0x2BB0FE0", VA = "0x182BB21E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int, string> MOKOPNERLLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2480", Offset = "0x2BB1280", VA = "0x182BB2480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2530", Offset = "0x2BB1330", VA = "0x182BB2530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<int, QUZNMKSIOOE> VDHLGCFXHTE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2330", Offset = "0x2BB1130", VA = "0x182BB2330")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BB20D0", Offset = "0x2BB0ED0", VA = "0x182BB20D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UNKCCCOUNFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2E60", Offset = "0x2BB1C60", VA = "0x182BB2E60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BB23E0", Offset = "0x2BB11E0", VA = "0x182BB23E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F2C0", Offset = "0x1B1E0C0", VA = "0x181B1F2C0")]
		public void PPFZDMEWUES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2F00", Offset = "0x2BB1D00", VA = "0x182BB2F00")]
		internal NSYPRDYOSDD([In] Guid id, string a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, List<(string Name, QUZNMKSIOOE Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1D90", Offset = "0x2BB0B90", VA = "0x182BB1D90")]
		public static CircuitEventDefinitionFactoryStart AZAFAXRXEYK(string a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1E60", Offset = "0x2BB0C60", VA = "0x182BB1E60")]
		public static CircuitEventDefinitionFactoryStart AZAFAXRXEYK(Guid a, string b, bool c = false, bool d = false, bool e = false, bool f = true, bool g = true, bool h = true, bool i = false, bool j = false)
		{
			return default(CircuitEventDefinitionFactoryStart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2CA0", Offset = "0x2BB1AA0", VA = "0x182BB2CA0")]
		public static NSYPRDYOSDD WQDQACHUBSG([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BB29F0", Offset = "0x2BB17F0", VA = "0x182BB29F0")]
		public static NSYPRDYOSDD VHNWGUIKXQY([In] Guid id, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xEF82B0", Offset = "0xEF70B0", VA = "0x180EF82B0")]
		public void AJKVLNUESKE(Id128<WDRPUXFLQCP> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2180", Offset = "0x2BB0F80", VA = "0x182BB2180")]
		public void FASOSQUEWZV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2730", Offset = "0x2BB1530", VA = "0x182BB2730")]
		public void ONVFGIWAJGT(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1FE0", Offset = "0x2BB0DE0", VA = "0x182BB1FE0")]
		public void DODTNELPQUI(int a, QUZNMKSIOOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB28D0", Offset = "0x2BB16D0", VA = "0x182BB28D0")]
		public void SYXRILOTDYQ(string a, QUZNMKSIOOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2C30", Offset = "0x2BB1A30", VA = "0x182BB2C30")]
		public void VRQSWUXALDX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1EE0", Offset = "0x2BB0CE0", VA = "0x182BB1EE0")]
		public NSYPRDYOSDD Clone()
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
		[Cpp2IlInjected.Address(RVA = "0x2BA7640", Offset = "0x2BA6440", VA = "0x182BA7640")]
		public CircuitEventDefinitionFactoryStart([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA73A0", Offset = "0x2BA61A0", VA = "0x182BA73A0")]
		public CircuitEventDefinitionFactoryParams FFMGNSNVGXQ(string a, QUZNMKSIOOE b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7510", Offset = "0x2BA6310", VA = "0x182BA7510")]
		public NSYPRDYOSDD YTMSCNEQASK()
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
		private readonly List<(string Name, QUZNMKSIOOE Type)> _eventProperties;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7310", Offset = "0x2BA6110", VA = "0x182BA7310")]
		public CircuitEventDefinitionFactoryParams([In] Guid id, string name, bool isBeta, bool isDevOnly, bool isDeprecated, bool isValidInRooms1, bool isValidInRooms2, bool canBeLogged, bool isVisibleBuiltInEvent, bool isMessageEvent, List<(string Name, QUZNMKSIOOE Type)> eventProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BA70E0", Offset = "0x2BA5EE0", VA = "0x182BA70E0")]
		public CircuitEventDefinitionFactoryParams FFMGNSNVGXQ(string a, QUZNMKSIOOE b)
		{
			return default(CircuitEventDefinitionFactoryParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7210", Offset = "0x2BA6010", VA = "0x182BA7210")]
		public NSYPRDYOSDD YTMSCNEQASK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class XIDSTNKOPZY
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ControlPanelCircuitObject
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly NSYPRDYOSDD PVDFVJYCPLR;

			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly NSYPRDYOSDD OOKHGSFJRRS;

			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly NSYPRDYOSDD TERACHHWFDV;

			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public static readonly NSYPRDYOSDD AARNLHUXLYQ;

			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly NSYPRDYOSDD RZWWCYKOXNV;

			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public static readonly NSYPRDYOSDD TMKTKJWETLZ;

			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly NSYPRDYOSDD BVWXMHUVDTK;

			[Cpp2IlInjected.Token(Token = "0x400013D")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;

			[Cpp2IlInjected.Token(Token = "0x400013E")]
			internal static readonly NSYPRDYOSDD[] NMYHRIWIVYV;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class PECWFBFPTRX
		{
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public static readonly NSYPRDYOSDD RKBGKLNANTN;

			[Cpp2IlInjected.Token(Token = "0x4000140")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class DDQSBDTZECM
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public static readonly NSYPRDYOSDD EOVESNCKNQV;

			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly NSYPRDYOSDD GJNRKPTGLYC;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class ULCGZNIMDAZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly NSYPRDYOSDD IWUNQBYLBOS;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly NSYPRDYOSDD JUKUTAXIYXZ;

			[Cpp2IlInjected.Token(Token = "0x4000146")]
			internal static readonly NSYPRDYOSDD[] VGNDMAVWNOF;

			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public static readonly NSYPRDYOSDD QLAIVDHYLGR;

			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly NSYPRDYOSDD XCDFWPPCBKE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class XKEHILBADAF
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Costume
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public static readonly NSYPRDYOSDD DENXWQUNSNK;

			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public static readonly NSYPRDYOSDD IQZROYUGLGJ;

			[Cpp2IlInjected.Token(Token = "0x400014C")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class OKFXYLBYHPA
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public static readonly NSYPRDYOSDD ZOHMYMPZMLX;

			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public static readonly NSYPRDYOSDD GCTDFQOWZNW;

			[Cpp2IlInjected.Token(Token = "0x400014F")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class DXHWYOUSVGZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public static readonly NSYPRDYOSDD EOVESNCKNQV;

			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public static readonly NSYPRDYOSDD GJNRKPTGLYC;

			[Cpp2IlInjected.Token(Token = "0x4000152")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class FHMWFGURYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public static readonly NSYPRDYOSDD FUVVMTCCBCY;

			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public static readonly NSYPRDYOSDD WTHFAHKKUZR;

			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public static readonly NSYPRDYOSDD IFLBAFIDMKV;

			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly NSYPRDYOSDD EULLZKDSKRD;

			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public static readonly NSYPRDYOSDD VEVOCDFBKXI;

			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public static readonly NSYPRDYOSDD OZTPGDDLLIH;

			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public static readonly NSYPRDYOSDD OFIHGOBKKDU;

			[Cpp2IlInjected.Token(Token = "0x400015A")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class ERDIBDXYPFD
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class KMUCTKHBQYJ
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class RBIBQNCPFSJ
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class LKVWNVZVXUF
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public static readonly NSYPRDYOSDD TWBIVVADNQS;

			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public static readonly NSYPRDYOSDD LGXJQWPIFCH;

			[Cpp2IlInjected.Token(Token = "0x4000160")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class XCROXDYUCVB
		{
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class JINXTKHEFXT
		{
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class XIDFDNBXUCT
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class RSQOMRHCKRO
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class PistonGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public static readonly NSYPRDYOSDD GERAREWOSEW;

			[Cpp2IlInjected.Token(Token = "0x4000166")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Player
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public static readonly NSYPRDYOSDD JTIRZZNKTYO;

			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public static readonly NSYPRDYOSDD PHKBRTWLNDN;

			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public static readonly NSYPRDYOSDD NCIPVRYSBWQ;

			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public static readonly NSYPRDYOSDD KLTWLSXLYYI;

			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public static readonly NSYPRDYOSDD ZOHMYMPZMLX;

			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public static readonly NSYPRDYOSDD OEZTOPBGGXS;

			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public static readonly NSYPRDYOSDD SSJPSBTQMEF;

			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public static readonly NSYPRDYOSDD EMTTTYTRRVV;

			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public static readonly NSYPRDYOSDD WEDSPTSNJYR;

			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public static readonly NSYPRDYOSDD JOCJKRGHRLB;

			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public static readonly NSYPRDYOSDD PIGENPHJVCZ;

			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public static readonly NSYPRDYOSDD XXGJHPCNUSS;

			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public static readonly NSYPRDYOSDD DONLJCTRMAX;

			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly NSYPRDYOSDD YXSVMAYTWQC;

			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly NSYPRDYOSDD ENXMGRJBLWW;

			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public static readonly NSYPRDYOSDD VEYORTNTBUU;

			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public static readonly NSYPRDYOSDD SNBHUUSLBTH;

			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public static readonly NSYPRDYOSDD GRHOLCGGKQQ;

			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public static readonly NSYPRDYOSDD JCBIZOIIPHE;

			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public static readonly NSYPRDYOSDD RMXZXZVQRZX;

			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public static readonly NSYPRDYOSDD YHFSEABUGCV;

			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public static readonly NSYPRDYOSDD UNMRWHXKIVH;

			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public static readonly NSYPRDYOSDD IKXUIJDYXKV;

			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public static readonly NSYPRDYOSDD VSTKVSHYLTZ;

			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public static readonly NSYPRDYOSDD LIHWHSZFQMX;

			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public static readonly NSYPRDYOSDD XWDSJACHHHR;

			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public static readonly NSYPRDYOSDD TRMEZRFTFGX;

			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public static readonly NSYPRDYOSDD LGECTSBNCRQ;

			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public static readonly NSYPRDYOSDD KOHDLGFKWKO;

			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public static readonly NSYPRDYOSDD PGXDFFPXHMH;

			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public static readonly NSYPRDYOSDD CWPRQQJDOMP;

			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public static readonly NSYPRDYOSDD INGDJZURJQK;

			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public static readonly NSYPRDYOSDD OMSFZCYBDJA;

			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public static readonly NSYPRDYOSDD ZNAIYORWQJE;

			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public static readonly NSYPRDYOSDD BSSWWPHFFBY;

			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public static readonly NSYPRDYOSDD JWAMTTZVESS;

			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public static readonly NSYPRDYOSDD WWFWFBIANUA;

			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public static readonly NSYPRDYOSDD NFOJZZYLWEA;

			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static readonly NSYPRDYOSDD TWZLDKBSOZG;

			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public static readonly NSYPRDYOSDD NRYDRLSVXJZ;

			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public static readonly NSYPRDYOSDD WPCEITTHBYD;

			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public static readonly NSYPRDYOSDD YOXGNCIZBNX;

			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public static readonly NSYPRDYOSDD KBWERBAFAEP;

			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public static readonly NSYPRDYOSDD FAJUOWJEZKJ;

			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public static readonly NSYPRDYOSDD NKKZGGKAXTD;

			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public static readonly NSYPRDYOSDD DLGNVQVXYBB;

			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public static readonly NSYPRDYOSDD LGMMOYEFLCN;

			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public static readonly NSYPRDYOSDD QNTJJFBTMPB;

			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public static readonly NSYPRDYOSDD LFYQAQSKUQN;

			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public static readonly NSYPRDYOSDD HVHPCLOKQSA;

			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public static readonly NSYPRDYOSDD OAEVBXNBPJJ;

			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public static readonly NSYPRDYOSDD VSSBIVLLLED;

			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public static readonly NSYPRDYOSDD JWQTYUIPJUH;

			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public static readonly NSYPRDYOSDD ZGBLOROFOEN;

			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public static readonly NSYPRDYOSDD HDVOBQQVOUX;

			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public static readonly NSYPRDYOSDD HNSDIFNGZOR;

			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public static readonly NSYPRDYOSDD IVTARQPRYSB;

			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public static readonly NSYPRDYOSDD GRPMPYNYPYH;

			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public static readonly NSYPRDYOSDD LMRNTQEAGYN;

			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public static readonly NSYPRDYOSDD IBQMGKIFEKD;

			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public static readonly NSYPRDYOSDD SXOLTDQWYYN;

			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public static readonly NSYPRDYOSDD TOPJLPXUCBO;

			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public static readonly NSYPRDYOSDD ANMLPXZKVDB;

			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public static readonly NSYPRDYOSDD AIGQJJLRAAL;

			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public static readonly NSYPRDYOSDD TQHXWGNAHUS;

			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public static readonly NSYPRDYOSDD SGDMJOHHBJQ;

			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public static readonly NSYPRDYOSDD KXNGLTVVHJP;

			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public static readonly NSYPRDYOSDD OROAMOMWREV;

			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class UHHYOVDWNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class OYOIGYIIVXN
		{
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public static readonly NSYPRDYOSDD QHEAHMZCASN;

			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public static readonly NSYPRDYOSDD AMSZRVAOTMG;

			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public static readonly NSYPRDYOSDD MUNITVGMYQK;

			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public static readonly NSYPRDYOSDD NNNXTVFVAOJ;

			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public static readonly NSYPRDYOSDD QPSNWKUZKMB;

			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public static readonly NSYPRDYOSDD WRCRJNCYFSL;

			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public static readonly NSYPRDYOSDD YUDJFVCDDCJ;

			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class SVDDFYPNCNE
		{
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public static readonly NSYPRDYOSDD JTIRZZNKTYO;

			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public static readonly NSYPRDYOSDD PHKBRTWLNDN;

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public static readonly NSYPRDYOSDD NCIPVRYSBWQ;

			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public static readonly NSYPRDYOSDD XPOKJLHCCVQ;

			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public static readonly NSYPRDYOSDD CGLYXIKMBCW;

			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public static readonly NSYPRDYOSDD TRSGJNTPEGW;

			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public static readonly NSYPRDYOSDD OCABLZLENZQ;

			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class WOGWQMYJULW
		{
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public static readonly NSYPRDYOSDD HEXITQZEKMU;

			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public static readonly NSYPRDYOSDD PHFVRCFZXLI;

			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public static readonly NSYPRDYOSDD PIBDCGVWHSX;

			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public static readonly NSYPRDYOSDD EWVTUMAGKRT;

			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public static readonly NSYPRDYOSDD IUEBPFGFIOP;

			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public static readonly NSYPRDYOSDD ZPJWQMRWECP;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class XODGIEVPVGT
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class Replicator
		{
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class JHEDTDAJYXE
		{
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public static readonly NSYPRDYOSDD JAUFINXSATW;

			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class CMVVRHLFFTK
		{
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public static readonly NSYPRDYOSDD GERAREWOSEW;

			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class NAAHWXUPHKD
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class SVLAJVNJRWI
		{
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class YFDSXBEROGJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public static readonly NSYPRDYOSDD MMHOIXZFOZJ;

			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly NSYPRDYOSDD BKPHTUSPXMV;

			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public static readonly NSYPRDYOSDD XXWHWHYSERK;

			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public static readonly NSYPRDYOSDD MRUNAWNWXZG;

			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class JWCUGFPFQYH
		{
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public static readonly NSYPRDYOSDD ZINXVKQGCVW;

			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public static readonly NSYPRDYOSDD KSJAXBYXONH;

			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class CXIWPUFSTAH
		{
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class IYMTREZIAZZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public static readonly NSYPRDYOSDD QHEAHMZCASN;

			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public static readonly NSYPRDYOSDD AMSZRVAOTMG;

			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class RMAPHYLSGFS
		{
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public static readonly NSYPRDYOSDD OTPQYYIALTB;

			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public static readonly NSYPRDYOSDD NNNXTVFVAOJ;

			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public static readonly NSYPRDYOSDD QPSNWKUZKMB;

			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public static readonly NSYPRDYOSDD WRCRJNCYFSL;

			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public static readonly NSYPRDYOSDD SFBGBRXEAOE;

			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public static readonly NSYPRDYOSDD CJJYBJHSYOB;

			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public static readonly NSYPRDYOSDD CLDIMEUCIMZ;

			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public static readonly NSYPRDYOSDD DUVQYIZKCVF;

			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public static readonly NSYPRDYOSDD ZABXEMJXSJO;

			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public static readonly NSYPRDYOSDD BYXLOXFSKGU;

			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public static readonly NSYPRDYOSDD QHEAHMZCASN;

			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public static readonly NSYPRDYOSDD AMSZRVAOTMG;

			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class NZOEOPAZQHS
		{
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class LXCMOLGNYWU
		{
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public static readonly NSYPRDYOSDD QHEAHMZCASN;

			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public static readonly NSYPRDYOSDD AMSZRVAOTMG;

			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public static readonly NSYPRDYOSDD BSSNYOUNARU;

			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static readonly NSYPRDYOSDD WHBEIUIGCOY;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static readonly NSYPRDYOSDD DAASEYIUNLR;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class YUDTQOUDTOL
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class NPSYIOSQKXI
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static readonly NSYPRDYOSDD WBJYUAUGRWT;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class WZGNKMQKQRQ
		{
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public static readonly NSYPRDYOSDD YEWHRCMNOWW;

			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public static readonly NSYPRDYOSDD XJLELEZPEPV;

			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public static readonly NSYPRDYOSDD QHEAHMZCASN;

			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public static readonly NSYPRDYOSDD AMSZRVAOTMG;

			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class VUVMHQTZYWR
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class AOECZPGLVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class YUWZFNAAZIO
		{
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class PJGTUNRBMLA
		{
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class ICRWDAXJOAH
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class MZJRWIFHJFB
		{
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public static readonly NSYPRDYOSDD TWBIVVADNQS;

			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public static readonly NSYPRDYOSDD LGXJQWPIFCH;

			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class ONKNUDABYBX
		{
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public static readonly NSYPRDYOSDD ZPGTPVTGQCM;

			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public static readonly NSYPRDYOSDD XMQRFOAXXUK;

			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public static readonly NSYPRDYOSDD GXXWYMLXXXA;

			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public static readonly NSYPRDYOSDD UBOFZXGYBDK;

			[Cpp2IlInjected.Token(Token = "0x4000200")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class WKLNLGXSBWO
		{
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public static readonly NSYPRDYOSDD ZPGTPVTGQCM;

			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public static readonly NSYPRDYOSDD XMQRFOAXXUK;

			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public static readonly NSYPRDYOSDD GXXWYMLXXXA;

			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public static readonly NSYPRDYOSDD UBOFZXGYBDK;

			[Cpp2IlInjected.Token(Token = "0x4000205")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class XPEKGDHPKVR
		{
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public static class ELJOKYGNRFS
		{
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public static readonly NSYPRDYOSDD SHEYQNAAYJR;

			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public static readonly NSYPRDYOSDD KCLIEUGKOJP;

			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public static readonly NSYPRDYOSDD OVBGRYYSMYB;

			[Cpp2IlInjected.Token(Token = "0x400020A")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class ZRQNNJWKWTX
		{
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public static readonly NSYPRDYOSDD MYVFQDJEIDM;

			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public static readonly NSYPRDYOSDD COWKKJYOWHO;

			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public static readonly NSYPRDYOSDD LFUQBVUNRCJ;

			[Cpp2IlInjected.Token(Token = "0x400020E")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class BXICTYALUGU
		{
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class DKCRZFWWPDL
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static readonly NSYPRDYOSDD RHGAMHGPEXD;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static readonly NSYPRDYOSDD EOACFNFULTB;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static readonly NSYPRDYOSDD VTZZUHKNGXC;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static readonly NSYPRDYOSDD SHUHDBGLUBS;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static readonly NSYPRDYOSDD GRSVEQLUUFD;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class OBHSSSHNBTO
		{
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static readonly NSYPRDYOSDD JKWNSRRZYYR;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class TLJZCEPSIDQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static readonly NSYPRDYOSDD NMKEMHGFLDW;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly NSYPRDYOSDD WIBBIRQDOXL;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly NSYPRDYOSDD MNGXMPTTWOE;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class UGCStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class FFCZZEVURNB
		{
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class WelcomeMatV2SpawnPoint
		{
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class PXLAYGOATKD
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class AMTFXJGZHPA
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class DARWLZJWRZP
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static readonly NSYPRDYOSDD ZAKNPKWRINI;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static readonly NSYPRDYOSDD NNEGIUPDIJN;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static readonly NSYPRDYOSDD PQQILMRPDXT;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class GameAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static readonly NSYPRDYOSDD MSJXMEHURFP;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static readonly NSYPRDYOSDD VHHLVCHUNGK;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static readonly NSYPRDYOSDD SDCGMSATEGI;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static readonly NSYPRDYOSDD VHFJOQINHZZ;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public static class TYCFVKNRFKZ
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static readonly NSYPRDYOSDD SXZUXMRWQFC;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			internal static readonly NSYPRDYOSDD[] UTISZCHWWAI;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class MRGQHRTIEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public readonly QUZNMKSIOOE CHJVTKLRMYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly List<NSYPRDYOSDD> ULEODDMGXAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<NSYPRDYOSDD> ELBWVUKVCXV;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IReadOnlyList<NSYPRDYOSDD> XAEAVEQDFET
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<NSYPRDYOSDD> CLFUHWNTLQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE8A0", Offset = "0x2BCD6A0", VA = "0x182BCE8A0")]
		protected MRGQHRTIEKL(QUZNMKSIOOE a, params NSYPRDYOSDD[][] events)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class QOTKKLWTWDL : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1920", Offset = "0x2BD0720", VA = "0x182BD1920")]
		internal QOTKKLWTWDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class OOMJMHLFQUO : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0640", Offset = "0x2BCF440", VA = "0x182BD0640")]
		internal OOMJMHLFQUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ZOXSSTCBOLT : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8B20", Offset = "0x2BD7920", VA = "0x182BD8B20")]
		internal ZOXSSTCBOLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class JMODTOAHHWO : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCBC0", Offset = "0x2BCB9C0", VA = "0x182BCCBC0")]
		internal JMODTOAHHWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class PAYCBKBCTFH : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1480", Offset = "0x2BD0280", VA = "0x182BD1480")]
		internal PAYCBKBCTFH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class GULSTBHVUKV : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB360", Offset = "0x2BCA160", VA = "0x182BCB360")]
		internal GULSTBHVUKV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class VOJEAJPGSHS : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD59F0", Offset = "0x2BD47F0", VA = "0x182BD59F0")]
		internal VOJEAJPGSHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class AVRJJGBGDRX : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8580", Offset = "0x2BC7380", VA = "0x182BC8580")]
		internal AVRJJGBGDRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class MTLAZQLCJUZ : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEA20", Offset = "0x2BCD820", VA = "0x182BCEA20")]
		internal MTLAZQLCJUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class UNXHTIFUJEJ : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5630", Offset = "0x2BD4430", VA = "0x182BD5630")]
		internal UNXHTIFUJEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class OHUAABRAHFX : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFDB0", Offset = "0x2BCEBB0", VA = "0x182BCFDB0")]
		internal OHUAABRAHFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class KECTLDUWIYN : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD790", Offset = "0x2BCC590", VA = "0x182BCD790")]
		internal KECTLDUWIYN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class LGFKFAATRPT : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD970", Offset = "0x2BCC770", VA = "0x182BCD970")]
		internal LGFKFAATRPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class VRVCGJCTWWX : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5DB0", Offset = "0x2BD4BB0", VA = "0x182BD5DB0")]
		internal VRVCGJCTWWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ETDSDIGIFDV : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAF30", Offset = "0x2BC9D30", VA = "0x182BCAF30")]
		internal ETDSDIGIFDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class TELJRPTHNEF : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4510", Offset = "0x2BD3310", VA = "0x182BD4510")]
		internal TELJRPTHNEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class BMYAMEKRGCP : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8C80", Offset = "0x2BC7A80", VA = "0x182BC8C80")]
		internal BMYAMEKRGCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class IIINDBZODKG : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC370", Offset = "0x2BCB170", VA = "0x182BCC370")]
		internal IIINDBZODKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class UEYFCGFJZME : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5370", Offset = "0x2BD4170", VA = "0x182BD5370")]
		internal UEYFCGFJZME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class TPYTMUOCVHI : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4B60", Offset = "0x2BD3960", VA = "0x182BD4B60")]
		internal TPYTMUOCVHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ZPXJXTWBJOQ : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8D00", Offset = "0x2BD7B00", VA = "0x182BD8D00")]
		internal ZPXJXTWBJOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class LRWXVLBIUEU : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDB50", Offset = "0x2BCC950", VA = "0x182BCDB50")]
		internal LRWXVLBIUEU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class WWVCWSYFDOP : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7140", Offset = "0x2BD5F40", VA = "0x182BD7140")]
		internal WWVCWSYFDOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class HSJIGOBDJGQ : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBDE0", Offset = "0x2BCABE0", VA = "0x182BCBDE0")]
		internal HSJIGOBDJGQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class EKJLLPPZALB : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA790", Offset = "0x2BC9590", VA = "0x182BCA790")]
		internal EKJLLPPZALB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class XLOYMBXRJVE : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7B30", Offset = "0x2BD6930", VA = "0x182BD7B30")]
		internal XLOYMBXRJVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class FNPTLARBBRK : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB180", Offset = "0x2BC9F80", VA = "0x182BCB180")]
		internal FNPTLARBBRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class LSZJQTEIHPA : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDDB0", Offset = "0x2BCCBB0", VA = "0x182BCDDB0")]
		internal LSZJQTEIHPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class DXLEPALQNHN : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA270", Offset = "0x2BC9070", VA = "0x182BCA270")]
		internal DXLEPALQNHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class CNFOXWPIBVQ : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9070", Offset = "0x2BC7E70", VA = "0x182BC9070")]
		internal CNFOXWPIBVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class QMBUJYUPZSB : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1740", Offset = "0x2BD0540", VA = "0x182BD1740")]
		internal QMBUJYUPZSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class DXSEJKMFEMD : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA450", Offset = "0x2BC9250", VA = "0x182BCA450")]
		internal DXSEJKMFEMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class AONYYNQHBWX : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BC81C0", Offset = "0x2BC6FC0", VA = "0x182BC81C0")]
		internal AONYYNQHBWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class GYOWVTQTIRI : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB540", Offset = "0x2BCA340", VA = "0x182BCB540")]
		internal GYOWVTQTIRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class TWUXQXOJQOC : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4D40", Offset = "0x2BD3B40", VA = "0x182BD4D40")]
		internal TWUXQXOJQOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class RBQWQNRZATI : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1B00", Offset = "0x2BD0900", VA = "0x182BD1B00")]
		internal RBQWQNRZATI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class MYWKEMPJLML : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2BCED60", Offset = "0x2BCDB60", VA = "0x182BCED60")]
		internal MYWKEMPJLML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class MCZMVULKLJW : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE640", Offset = "0x2BCD440", VA = "0x182BCE640")]
		internal MCZMVULKLJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class VXAJQYFPETC : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5F00", Offset = "0x2BD4D00", VA = "0x182BD5F00")]
		internal VXAJQYFPETC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class XLKZQMMVIGN : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7950", Offset = "0x2BD6750", VA = "0x182BD7950")]
		internal XLKZQMMVIGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class DIOIDXDRION : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC96F0", Offset = "0x2BC84F0", VA = "0x182BC96F0")]
		internal DIOIDXDRION()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class VQCJMYYZHYB : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5BD0", Offset = "0x2BD49D0", VA = "0x182BD5BD0")]
		internal VQCJMYYZHYB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class ACOHWNQMSII : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7F00", Offset = "0x2BC6D00", VA = "0x182BC7F00")]
		internal ACOHWNQMSII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class YRHPJOULRBW : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8680", Offset = "0x2BD7480", VA = "0x182BD8680")]
		internal YRHPJOULRBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class ZUSBUOICISH : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9430", Offset = "0x2BD8230", VA = "0x182BD9430")]
		internal ZUSBUOICISH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ZCBXTVGQTTU : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8940", Offset = "0x2BD7740", VA = "0x182BD8940")]
		internal ZCBXTVGQTTU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class UADLWHAGLJX : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5190", Offset = "0x2BD3F90", VA = "0x182BD5190")]
		internal UADLWHAGLJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class JPHBIHRSIXO : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCF80", Offset = "0x2BCBD80", VA = "0x182BCCF80")]
		internal JPHBIHRSIXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class SLRMAVTKCAS : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2D10", Offset = "0x2BD1B10", VA = "0x182BD2D10")]
		internal SLRMAVTKCAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class BDGZBGUBVML : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8760", Offset = "0x2BC7560", VA = "0x182BC8760")]
		internal BDGZBGUBVML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class HVYPJLPTVMD : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBFC0", Offset = "0x2BCADC0", VA = "0x182BCBFC0")]
		internal HVYPJLPTVMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class RIFSHFTHXQK : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1D60", Offset = "0x2BD0B60", VA = "0x182BD1D60")]
		internal RIFSHFTHXQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class BEIHCTCITVZ : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8940", Offset = "0x2BC7740", VA = "0x182BC8940")]
		internal BEIHCTCITVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class OQDWZTOMPEK : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BD07A0", Offset = "0x2BCF5A0", VA = "0x182BD07A0")]
		internal OQDWZTOMPEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class NBBYLBDBDYA : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF3B0", Offset = "0x2BCE1B0", VA = "0x182BCF3B0")]
		internal NBBYLBDBDYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class APCIZEGSQKI : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC83A0", Offset = "0x2BC71A0", VA = "0x182BC83A0")]
		internal APCIZEGSQKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SXNQNUXFSQM : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4330", Offset = "0x2BD3130", VA = "0x182BD4330")]
		internal SXNQNUXFSQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class VFLKFFWFIVR : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5810", Offset = "0x2BD4610", VA = "0x182BD5810")]
		internal VFLKFFWFIVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class JMXSYVZAHPA : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCDA0", Offset = "0x2BCBBA0", VA = "0x182BCCDA0")]
		internal JMXSYVZAHPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ORRJERLHJEA : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0980", Offset = "0x2BCF780", VA = "0x182BD0980")]
		internal ORRJERLHJEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class BLVJJKBPLAT : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8B20", Offset = "0x2BC7920", VA = "0x182BC8B20")]
		internal BLVJJKBPLAT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class IBSGJOURBMM : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC1A0", Offset = "0x2BCAFA0", VA = "0x182BCC1A0")]
		internal IBSGJOURBMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class MVLSLJHGGBX : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEC00", Offset = "0x2BCDA00", VA = "0x182BCEC00")]
		internal MVLSLJHGGBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class EJZTHEMLPLM : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA630", Offset = "0x2BC9430", VA = "0x182BCA630")]
		internal EJZTHEMLPLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class JUWAQVTLVEM : MRGQHRTIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD160", Offset = "0x2BCBF60", VA = "0x182BCD160")]
		internal JUWAQVTLVEM()
		{
		}
	}
}
namespace Circuits.Static.RecRoom.GraphDefs
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public readonly struct NamedType : IEquatable<NamedType>, MJOFOHUMYGG<NamedType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public readonly QUZNMKSIOOE Type;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
		private NamedType(string name, QUZNMKSIOOE type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B03FA0", Offset = "0x2B02DA0", VA = "0x182B03FA0")]
		public static NamedType New(string name, QUZNMKSIOOE type)
		{
			return default(NamedType);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF8C0", Offset = "0x2BCE6C0", VA = "0x182BCF8C0")]
		public static bool ITVTPRNZGNV([In] NamedType lhs, [In] NamedType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF8C0", Offset = "0x2BCE6C0", VA = "0x182BCF8C0", Slot = "4")]
		public bool Equals(NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF8C0", Offset = "0x2BCE6C0", VA = "0x182BCF8C0")]
		public bool ABAKIYLIPET([In] NamedType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF910", Offset = "0x2BCE710", VA = "0x182BCF910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF9D0", Offset = "0x2BCE7D0", VA = "0x182BCF9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFB00", Offset = "0x2BCE900", VA = "0x182BCFB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFAC0", Offset = "0x2BCE8C0", VA = "0x182BCFAC0")]
		public string PHVTVCHPWIX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFA40", Offset = "0x2BCE840", VA = "0x182BCFA40")]
		public string NMXYYEXLHTJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF8C0", Offset = "0x2BCE6C0", VA = "0x182BCF8C0", Slot = "5")]
		private bool VKRHQUNJEIK([In] NamedType other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface KVHMMDKOSSW
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(JGWKKBUFZYH a, bool b);
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
