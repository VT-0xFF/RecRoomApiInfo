using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Async;
using RecRoom.Core;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logger;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Notifications;
using RecRoom.Persistence;
using RecRoom.ProgressionEvents;
using RecRoom.RoomLoad.Protobuf;
using RecRoom.RoomLoading;
using RecRoom.Storefronts;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9892720", Offset = "0x9891120", VA = "0x189892720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Keepsakes_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98A1220", Offset = "0x989FC20", VA = "0x1898A1220", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BYCNSSFBHUW : IComparer<KeepsakeCategory>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KeepsakeCategory GVIOUHLRQCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KeepsakeCategory GVNVROFOZNR;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE5F490", Offset = "0xE5DE90", VA = "0x180E5F490")]
			internal bool TRLQVLLNRHJ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x201C9E0", Offset = "0x201B3E0", VA = "0x18201C9E0")]
			internal bool TRGJYERQHWA(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE5F490", Offset = "0xE5DE90", VA = "0x180E5F490")]
			internal bool TRWEPYZIKEB(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x201C9E0", Offset = "0x201B3E0", VA = "0x18201C9E0")]
			internal bool TRQXSSFLASS(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<KeepsakeCategoryThemePair> HPQLEOHJNNP;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public BYCNSSFBHUW(List<KeepsakeCategoryThemePair> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9890A10", Offset = "0x988F410", VA = "0x189890A10", Slot = "4")]
		public int Compare(KeepsakeCategory x, KeepsakeCategory y)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public KeepsakeCategory KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KeepsakeTheme KeepsakeTheme;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Tested]
	public class QUKJVDNYKBW : JPDSEFSZZXX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class AEKTQRKTGNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public KeepsakeTheme QJNGMQTMIGF;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public AEKTQRKTGNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x205C140", Offset = "0x205AB40", VA = "0x18205C140")]
			internal bool LAOJMZJLCMN(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OUXTILDYVOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public long IHSNQJKLJIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public long SELGNTDQVBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KeepsakeCategory? ZSJOPWQMTVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> LTVJVQAKIYE;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OUXTILDYVOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9892AA0", Offset = "0x98914A0", VA = "0x189892AA0")]
			internal void TEHCQHBHOFJ(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9891D70", Offset = "0x9890770", VA = "0x189891D70")]
			internal void TEBVTAHKEUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9892B30", Offset = "0x9891530", VA = "0x189892B30")]
			internal MPVTAJGPRUT<IEnumerable<Guid>> TERQKUPCHCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x92D8610", Offset = "0x92D7010", VA = "0x1892D8610")]
			internal bool TEMJNNVEXQS(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OUSMLEKBMCW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KeepsakeRoomInstanceIdsDTO HNQNHUURPJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public OUXTILDYVOF YQELRQOBVLD;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OUSMLEKBMCW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9892970", Offset = "0x9891370", VA = "0x189892970")]
			internal MPVTAJGPRUT<IEnumerable<Guid>> TFCEFICWZYT(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OUNFNXQECRN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KeepsakeRoomInstancesDTO LOXYCCCDNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public OUSMLEKBMCW YPOQZWGJTDC;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OUNFNXQECRN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9892850", Offset = "0x9891250", VA = "0x189892850")]
			internal bool TEWXIBIZQNK(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OUHYQQWGTGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Guid ODPNSVXYARI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public OUNFNXQECRN YPTXXDAHCOL;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OUHYQQWGTGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x98927A0", Offset = "0x98911A0", VA = "0x1898927A0")]
			internal bool TFMRZVQRSVL(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class TRSTVRJGJFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public long SELGNTDQVBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> LUFXQDOFBUW;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TRSTVRJGJFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x98A05A0", Offset = "0x989EFA0", VA = "0x1898A05A0")]
			internal MPVTAJGPRUT<IEnumerable<Guid>> CSQVDBEHIJK(IEnumerable<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9890CA0", Offset = "0x988F6A0", VA = "0x189890CA0")]
			internal bool CSWCAHYERUT(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GXDWFFJYTCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long IHSNQJKLJIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public long SELGNTDQVBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> LTVJVQAKIYE;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GXDWFFJYTCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9891CE0", Offset = "0x98906E0", VA = "0x189891CE0")]
			internal void ILAZNUUFZMI(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9891D70", Offset = "0x9890770", VA = "0x189891D70")]
			internal void ILGGLBODIXR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9891DA0", Offset = "0x98907A0", VA = "0x189891DA0")]
			internal MPVTAJGPRUT<Dictionary<Guid, KeepsakeCategory>> ILLNIIIASJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x92D8610", Offset = "0x92D7010", VA = "0x1892D8610")]
			internal bool ILQUFPBYBUJ(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GWYPHYQBJQY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public KeepsakeRoomInstanceIdsDTO HNQNHUURPJO;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GWYPHYQBJQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9891B40", Offset = "0x9890540", VA = "0x189891B40")]
			internal MPVTAJGPRUT<Dictionary<Guid, KeepsakeCategory>> IKFXYTSQNSY(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GXOJZSXTLYZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public KeepsakeRoomInstancesDTO LOXYCCCDNJA;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GXOJZSXTLYZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9892070", Offset = "0x9890A70", VA = "0x189892070")]
			internal bool IKLEWAMNXEH(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9892150", Offset = "0x9890B50", VA = "0x189892150")]
			internal KeyValuePair<Guid, KeepsakeCategory> IKQLTHGLGPQ(Guid a)
			{
				return default(KeyValuePair<Guid, KeepsakeCategory>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GXJDCMDWCNQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Guid ODPNSVXYARI;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GXJDCMDWCNQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x10186E0", Offset = "0x10170E0", VA = "0x1810186E0")]
			internal bool IKVSQOAIQAZ(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GWIUQEIJHIX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Guid ODPNSVXYARI;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GWIUQEIJHIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x10186E0", Offset = "0x10170E0", VA = "0x1810186E0")]
			internal bool IMRCRWXKWZC(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CXIQIMOFOSC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public long SELGNTDQVBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> LUFXQDOFBUW;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public CXIQIMOFOSC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9890CC0", Offset = "0x988F6C0", VA = "0x189890CC0")]
			internal MPVTAJGPRUT<Dictionary<Guid, KeepsakeCategory>> ERXIZWCGYOF(Dictionary<Guid, KeepsakeCategory> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9890CA0", Offset = "0x988F6A0", VA = "0x189890CA0")]
			internal bool ERSCCPIJPCW(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CXNXFTICYDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public KeepsakeRoomInstanceIdsDTO ZDNVKLYXCOS;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public CXNXFTICYDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x9890EB0", Offset = "0x988F8B0", VA = "0x189890EB0")]
			internal bool ERMVFIOMFRN(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NKIUONNBVPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Dictionary<Guid, KeepsakeCategory> IYFRJFQDAGU;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public NKIUONNBVPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x98925D0", Offset = "0x9890FD0", VA = "0x1898925D0")]
			internal KeyValuePair<KeepsakeCategory, int> KZUQSPAHGBS(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NKDNRGTEMDS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public KeepsakeCategory LWBFMNICCOY;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public NKDNRGTEMDS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xF82D70", Offset = "0xF81770", VA = "0x180F82D70")]
			internal bool LAKLKJHZIJT(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class TEQPCZFFQHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Dictionary<Guid, KeepsakeCategory> IYFRJFQDAGU;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TEQPCZFFQHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x98A0450", Offset = "0x989EE50", VA = "0x1898A0450")]
			internal KeyValuePair<KeepsakeCategory, int> ZVDSEXLXLWQ(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class TELIFSLIGVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public KeepsakeCategory LWBFMNICCOY;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TELIFSLIGVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xF82D70", Offset = "0xF81770", VA = "0x180F82D70")]
			internal bool ZVTMWRTPOER(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DUVKJSBBVTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public long SELGNTDQVBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<KeepsakeRoomDTO, bool> LTVJVQAKIYE;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public DUVKJSBBVTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9890F30", Offset = "0x988F930", VA = "0x189890F30")]
			internal bool QBTCGXUMUWM(DateTime a, DateTime b, int c, TimeSpan d, TimeSpan e, int f)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x9891040", Offset = "0x988FA40", VA = "0x189891040")]
			internal bool SUXTXRSVHJT(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9891020", Offset = "0x988FA20", VA = "0x189891020")]
			internal bool SUNGDEFAONB(KeepsakeRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9891020", Offset = "0x988FA20", VA = "0x189891020")]
			internal bool SUHZFXLDFBS(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class UICWJVBNPND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public long UFYTSQANZML;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UICWJVBNPND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x137C8D0", Offset = "0x137B2D0", VA = "0x18137C8D0")]
			internal bool ZRAGHRNLEZV(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JNIMEIGHZRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public long SELGNTDQVBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Func<KeepsakeRoomDTO, bool> LUFXQDOFBUW;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JNIMEIGHZRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x98922A0", Offset = "0x9890CA0", VA = "0x1898922A0")]
			internal bool BJDPDAYRWMB(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x271C920", Offset = "0x271B320", VA = "0x18271C920")]
			internal bool BIYIFUEUNAS(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class WHXJUUFPPUU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public long UFYTSQANZML;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public WHXJUUFPPUU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x98A11C0", Offset = "0x989FBC0", VA = "0x1898A11C0")]
			internal bool GOSTPXISMJK(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class ZDYOVWICGGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public long UFYTSQANZML;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZDYOVWICGGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x137C8D0", Offset = "0x137B2D0", VA = "0x18137C8D0")]
			internal bool PDNYKSFACPL(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class OAUMBHQPSIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public KeepsakeCategory ZSJOPWQMTVX;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OAUMBHQPSIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x22A7330", Offset = "0x22A5D30", VA = "0x1822A7330")]
			internal bool HJGWZKRKYGX(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class EKPGRROSNWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Guid WEFSSWONJRF;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public EKPGRROSNWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9891100", Offset = "0x988FB00", VA = "0x189891100")]
			internal bool PPXGKHLUODI(KeyValuePair<Guid, KeepsakeInstanceDTO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class UXWSRUPEHQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public KeepsakeCategory ZSJOPWQMTVX;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UXWSRUPEHQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x98A1180", Offset = "0x989FB80", VA = "0x1898A1180")]
			internal bool AYDJZJKMPTB(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class FYQXGNIUIJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public long BGGGCWVPLLR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public long? GDDKCZYSQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public FYQXGNIUIJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x9891160", Offset = "0x988FB60", VA = "0x189891160")]
			internal bool MJSCFGPAQCM(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class BBVWTHDMUSL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IReadOnlyList<KeepsakeRoomListDTO> UKFURVQLQUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public long UFYTSQANZML;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public BBVWTHDMUSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9890920", Offset = "0x988F320", VA = "0x189890920")]
			internal bool QKQZAWLDZXR(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class BBQPWAJPLHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public KeepsakeRoomDTO WWTKWNGJNNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public BBVWTHDMUSL YQELRQOBVLD;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public BBQPWAJPLHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x98908A0", Offset = "0x988F2A0", VA = "0x1898908A0")]
			internal bool QKWFYDFBJJA(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class GHKGEEVKGYA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KeepsakeCategory ZSJOPWQMTVX;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GHKGEEVKGYA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9891520", Offset = "0x988FF20", VA = "0x189891520")]
			internal MPVTAJGPRUT<Guid> KAMDJINZLHX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x98911E0", Offset = "0x988FBE0", VA = "0x1898911E0")]
			internal void FLXSORPNFBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x98914C0", Offset = "0x988FEC0", VA = "0x1898914C0")]
			internal void HIWFADZKRLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9891210", Offset = "0x988FC10", VA = "0x189891210")]
			internal void FNDHYGEXJRU(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9891490", Offset = "0x988FE90", VA = "0x189891490")]
			internal void FNIOVMYUTDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class GKYOXSSRUHQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public QUKJVDNYKBW AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string BDLHUTFCBFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int LQFIEUPLDSR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int DLAXSPLAXEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Guid WEFSSWONJRF;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GKYOXSSRUHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9891660", Offset = "0x9890060", VA = "0x189891660")]
			internal void AJPKBKHIMUR(KeepsakeCollectInstanceResponse a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9891A00", Offset = "0x9890400", VA = "0x189891A00")]
			internal void KGIURPIYYUN(string a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct <OnRunMigrations>d__182 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public QUKJVDNYKBW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public QVBCTCOYKBH args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x98A0710", Offset = "0x989F110", VA = "0x1898A0710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x98A0C20", Offset = "0x989F620", VA = "0x1898A0C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <PeriodicLog>d__184 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public TimeSpan delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public QUKJVDNYKBW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x98A0C80", Offset = "0x989F680", VA = "0x1898A0C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x98A0F10", Offset = "0x989F910", VA = "0x1898A0F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DateTime EFHLWZWZGQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly XBQMFDEXCLZ XGQCKKAXSZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly JTRLKNMGREG LYEFQJXVZXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DAPINQYDKKS WZFWVCRRZOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly RCSWNUGOUJA GSEZWLRUZIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FGNKODXRVEL PZEQXPENEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly QVTYUHUQZYK RDWEYNJDNJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly EKTHEEDPLVM VYLQPVDZVNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly GIWROPIUCYR VJTLLTIAEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly QYBATIJDFLA IHWKBBWGWIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HEGRGCIDXYE WBZRTPQLLRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly HBQWRBCBWSO DICBJFXZRYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly ZTRLAKMWPAP QRUYNTUCFQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly PEQQHDUOSKN SPFURWJYYEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CXMZRRQRYVT JJZRDCEMEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LARVDFBNSQK YSBIRVQLGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly DTYUQONQODC<KeepsakesConfig.KeepsakesOptions> EFUKAIFPNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly LGHEBYOBKGV ZXMRFEXXLNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Dictionary<Guid, KeepsakeInstanceDTO> DALVETLKKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HashSet<Guid> CHVVEYRBRCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<long> UIKYLEXGJES;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<KeepsakeCategory, int> JSIICRVECTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly HashSet<Guid> TJIPFFFDCSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IDisposable YOFFZIPOFYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Task VIZMNKMZESO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private MPVTAJGPRUT<Guid> LKLKJICAGNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long? GRXWZLSYKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private KeepsakeProgressionEventInstancesDTO YCCBEACPVCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private MPVTAJGPRUT<KeepsakeProgressionEventInstancesDTO> KGSRTVHBLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> SKRQCWBVBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KeepsakeGlobalConfigDTO EZMCURXSVDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HashSet<long> WFQLWIJYPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HashSet<long> HPYOZYFYYCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private List<KeepsakeRoomListDTO> SSXRZICMTDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<KeepsakeRoomListDTO> KHOPAZPIHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private List<KeepsakeRoomListDTO> JNYGKSYYGSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<long, string> SLETUADRHZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Dictionary<long, string> EDNSKICKFVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<long, DateTime> XUCOTCFQRJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Dictionary<long, List<KeepsakeRoomDTO>> BOCVFCWWDVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Dictionary<long, List<KeepsakeRoomDTO>> OLKGNVPARGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private Dictionary<long, long> ARHBZSQACTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<string> DSNZEUTFSLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private DateTime USGYNHYOTNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly IDisposable XRGTRPTZZLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Dictionary<Guid, KeepsakeCategory> PHCHTZRLNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<KeepsakeCategory, int> FGMDEASWUQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<KeepsakeCategoryThemePair> SHGPDENUGHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private BYCNSSFBHUW PKYSEIPXXTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool CNOVZAEBDSE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GWKBQUDHZLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD2E420", Offset = "0xD2CE20", VA = "0x180D2E420", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD2EE60", Offset = "0xD2D860", VA = "0x180D2EE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool RTAYMYOZUZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x989A770", Offset = "0x9899170", VA = "0x18989A770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FOUXHGVBIEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x989CE20", Offset = "0x989B820", VA = "0x18989CE20", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private long QREMEKKVAFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x989CDA0", Offset = "0x989B7A0", VA = "0x18989CDA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private long? BMDLSKCXMMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x989E530", Offset = "0x989CF30", VA = "0x18989E530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool GBDZAFWUAEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9893A80", Offset = "0x9892480", VA = "0x189893A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<KeepsakeRoomListDTO> CWEDECHXCLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD889B0", Offset = "0xD873B0", VA = "0x180D889B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<KeepsakeRoomListDTO> QPVBETNAEAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87220", VA = "0x180D88820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<KeepsakeRoomListDTO> PWDPNTJFIJS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xD88C80", Offset = "0xD87680", VA = "0x180D88C80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<long, string> DAIDCGTTOIR
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD889A0", Offset = "0xD873A0", VA = "0x180D889A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal bool UUSOWAIBNDC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1484D50", Offset = "0x1483750", VA = "0x181484D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid?> WHQHLYYSARX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9893F20", Offset = "0x9892920", VA = "0x189893F20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x989A050", Offset = "0x9898A50", VA = "0x18989A050", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action VQRARXMYBCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x98959E0", Offset = "0x98943E0", VA = "0x1898959E0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x989EC50", Offset = "0x989D650", VA = "0x18989EC50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action TCMVANOISXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9896B90", Offset = "0x9895590", VA = "0x189896B90", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9893470", Offset = "0x9891E70", VA = "0x189893470", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x989EF70", Offset = "0x989D970", VA = "0x18989EF70")]
		[RecRoom.NoEngine.Common.Preserve]
		internal QUKJVDNYKBW([Inject(null)][NotNull] XBQMFDEXCLZ notificationManager, [Inject(null)][NotNull] PDZLTDYPPTJ roomLoader, [Inject(null)][NotNull] JTRLKNMGREG creationHelper, [Inject(null)][NotNull] DAPINQYDKKS roomPersistenceManager, [Inject(null)][NotNull] RCSWNUGOUJA progressionEventsManager, [Inject(null)][NotNull] FGNKODXRVEL roomManager, [Inject(null)][NotNull] QVTYUHUQZYK storefrontManager, [Inject(null)][NotNull] EKTHEEDPLVM roomSaveValidation, [Inject(null)][NotNull] GIWROPIUCYR networking, [Inject(null)][NotNull] ZWJDJVEAFMW scheduledUpdateService, [Inject(null)][NotNull] QYBATIJDFLA recNetMatchmaking, [Inject(null)][NotNull] HEGRGCIDXYE recNetKeepsakes, [Inject(null)][NotNull] HBQWRBCBWSO recNetAccounts, [Inject(null)][NotNull] ZTRLAKMWPAP recNetStorefronts, [Inject(null)][NotNull] PEQQHDUOSKN recNetGifts, [Inject(null)][NotNull] CXMZRRQRYVT timeService, [Inject(null)][NotNull] LARVDFBNSQK debugLogger, [Inject(null)][NotNull] DTYUQONQODC<KeepsakesConfig.KeepsakesOptions> options, [Inject(null)][NotNull] LGHEBYOBKGV gameConfigsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x989AFF0", Offset = "0x98999F0", VA = "0x18989AFF0", Slot = "15")]
		public bool PMZWRCFUCUH(List<string> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9897060", Offset = "0x9895A60", VA = "0x189897060", Slot = "16")]
		public MPVTAJGPRUT<Guid> IUGBFKEUXRE(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9896360", Offset = "0x9894D60", VA = "0x189896360", Slot = "17")]
		public NXPIPFBMDQY HFJTDYEOJMZ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98941C0", Offset = "0x9892BC0", VA = "0x1898941C0", Slot = "18")]
		public NXPIPFBMDQY DTNRBUJNMAE(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9899860", Offset = "0x9898260", VA = "0x189899860", Slot = "19")]
		public bool MRDRIYAVMJG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x989D4F0", Offset = "0x989BEF0", VA = "0x18989D4F0", Slot = "20")]
		public bool UGCHFGPSPKA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9897630", Offset = "0x9896030", VA = "0x189897630")]
		public KeepsakeTheme IYIXIGOHTEO(Guid a)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9892E10", Offset = "0x9891810", VA = "0x189892E10")]
		public bool AFIRXMGOWAO(KeepsakeCategory a, [Out] KeepsakeTheme b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x989DDB0", Offset = "0x989C7B0", VA = "0x18989DDB0")]
		public List<KeepsakeTheme> XBUMOHDXHXC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x989ED10", Offset = "0x989D710", VA = "0x18989ED10")]
		public int ZUPCQVMVEWT(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9896200", Offset = "0x9894C00", VA = "0x189896200")]
		public KeepsakeCategory GOXUBORIDXX(Guid a)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x989B280", Offset = "0x9899C80", VA = "0x18989B280", Slot = "34")]
		public List<KeepsakeCategory> PQOPGQPHLAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x989C790", Offset = "0x989B190", VA = "0x18989C790", Slot = "35")]
		public IComparer<KeepsakeCategory> RZYZUUEQIJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9898C70", Offset = "0x9897670", VA = "0x189898C70", Slot = "32")]
		public string MBDESFJAMZD(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x989CA50", Offset = "0x989B450", VA = "0x18989CA50", Slot = "33")]
		public string SPAGBLUALOJ(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x989BC80", Offset = "0x989A680", VA = "0x18989BC80", Slot = "21")]
		public bool QQIWXUCDCHQ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9895970", Offset = "0x9894370", VA = "0x189895970", Slot = "22")]
		public void FBLOUAULZRO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9893D20", Offset = "0x9892720", VA = "0x189893D20", Slot = "23")]
		public void CYHQOFLAZKI(KeepsakeCategory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9898950", Offset = "0x9897350", VA = "0x189898950", Slot = "24")]
		public void LBJYQKVKZCU(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x989D0D0", Offset = "0x989BAD0", VA = "0x18989D0D0", Slot = "25")]
		public int TYIUEHAIBJQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x989D8B0", Offset = "0x989C2B0", VA = "0x18989D8B0", Slot = "31")]
		public MPVTAJGPRUT<IEnumerable<Guid>> WCEUDQFNDUH(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98999C0", Offset = "0x98983C0", VA = "0x1898999C0", Slot = "30")]
		public MPVTAJGPRUT<IEnumerable<Guid>> NBCQRJCDFPI(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9898DF0", Offset = "0x98977F0", VA = "0x189898DF0", Slot = "54")]
		public MPVTAJGPRUT<Dictionary<Guid, KeepsakeCategory>> MERIRSZHTWS(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x989D670", Offset = "0x989C070", VA = "0x18989D670", Slot = "55")]
		public MPVTAJGPRUT<Dictionary<Guid, KeepsakeCategory>> VFDCCQYVDDD(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98956E0", Offset = "0x98940E0", VA = "0x1898956E0", Slot = "26")]
		public MPVTAJGPRUT<int> EZZNFDOPFFM(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9894060", Offset = "0x9892A60", VA = "0x189894060", Slot = "27")]
		public MPVTAJGPRUT<int> DSBRBDGDKYW(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x989E2D0", Offset = "0x989CCD0", VA = "0x18989E2D0", Slot = "28")]
		public MPVTAJGPRUT<Dictionary<KeepsakeCategory, int>> XLXEFXWAEZN(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98978D0", Offset = "0x98962D0", VA = "0x1898978D0", Slot = "29")]
		public MPVTAJGPRUT<Dictionary<KeepsakeCategory, int>> JUQSRCJWUZJ(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9895A80", Offset = "0x9894480", VA = "0x189895A80", Slot = "37")]
		public bool FOQZLFQJXPV(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x989E5C0", Offset = "0x989CFC0", VA = "0x18989E5C0", Slot = "56")]
		public bool XVRZPEGRJHB(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9895BF0", Offset = "0x98945F0", VA = "0x189895BF0", Slot = "38")]
		public bool GAUZORGSJNI(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x989B8E0", Offset = "0x989A2E0", VA = "0x18989B8E0", Slot = "57")]
		public bool QOMWBNRGRFS(long a, [Out] KeepsakeRoomLockStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x989DC70", Offset = "0x989C670", VA = "0x18989DC70", Slot = "39")]
		public bool WEWXJSNJXAJ(long a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x98991B0", Offset = "0x9897BB0", VA = "0x1898991B0", Slot = "40")]
		public long MISMNEDYQXZ(long a, bool b = false)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9895AE0", Offset = "0x98944E0", VA = "0x189895AE0", Slot = "41")]
		public long FZIMQDNOCOR(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x989C5B0", Offset = "0x989AFB0", VA = "0x18989C5B0", Slot = "42")]
		public int RWKEPEKTRHA(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9896120", Offset = "0x9894B20", VA = "0x189896120", Slot = "43")]
		public bool GKOQCXWZLSX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x989C410", Offset = "0x989AE10", VA = "0x18989C410", Slot = "44")]
		public bool RSAQJCPCWNT(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9895470", Offset = "0x9893E70", VA = "0x189895470", Slot = "45")]
		public IReadOnlyList<long> ESRKKQZWNGO(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x989A7C0", Offset = "0x98991C0", VA = "0x18989A7C0", Slot = "46")]
		public int OUQHAOGIOTV(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9899B50", Offset = "0x9898550", VA = "0x189899B50", Slot = "50")]
		public long NCFZEHISSQK(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x989C000", Offset = "0x989AA00", VA = "0x18989C000", Slot = "51")]
		public KeepsakeCategory RMLQHFDVJWO()
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x989B3C0", Offset = "0x9899DC0", VA = "0x18989B3C0")]
		private void PTAITBTQYOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9894720", Offset = "0x9893120", VA = "0x189894720")]
		private void DYEJFQNHNXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x989EAB0", Offset = "0x989D4B0", VA = "0x18989EAB0")]
		private int ZBMBPBEXSEV(KeepsakeRoomListDTO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x989E1D0", Offset = "0x989CBD0", VA = "0x18989E1D0")]
		private int XLFTAXXMEOC(DateTime a, DateTime b, TimeSpan c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9893A90", Offset = "0x9892490", VA = "0x189893A90")]
		private void CWHTNUEKOJJ(IEnumerable<KeepsakeInstanceDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9895170", Offset = "0x9893B70", VA = "0x189895170")]
		private void ELNOPBXDMDX(IEnumerable<KeepsakeCollectionRecordDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x989D7F0", Offset = "0x989C1F0", VA = "0x18989D7F0")]
		private void VMDAZADYXTK(IEnumerable<long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xD4C050", Offset = "0xD4AA50", VA = "0x180D4C050")]
		private void EJMUALONMHS(KeepsakeGlobalConfigDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9896C30", Offset = "0x9895630", VA = "0x189896C30")]
		private bool HZLMCZCARTB(KeepsakeCategory a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9894680", Offset = "0x9893080", VA = "0x189894680")]
		private bool DVUJZCMNRTJ([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x989E4D0", Offset = "0x989CED0", VA = "0x18989E4D0")]
		private bool XNEJIHQBLWG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x989D520", Offset = "0x989BF20", VA = "0x18989D520")]
		private IEnumerable<Guid> UTYRTEPDMNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9899E00", Offset = "0x9898800", VA = "0x189899E00")]
		private IEnumerable<KeepsakeInstanceDTO> NFDQYISWWHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9893FD0", Offset = "0x98929D0", VA = "0x189893FD0")]
		private void DHPSLMUJMJC(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x98953C0", Offset = "0x9893DC0", VA = "0x1898953C0")]
		private bool EOKGONONYUS(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x989E620", Offset = "0x989D020", VA = "0x18989E620")]
		private void XZDNIRATGYI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x989EE90", Offset = "0x989D890", VA = "0x18989EE90")]
		private void ZWVSMOIRFMT(KeepsakeCategory a, int b, Dictionary<KeepsakeCategory, int> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9896030", Offset = "0x9894A30", VA = "0x189896030")]
		private int GGXUJUPFLVN(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x989C830", Offset = "0x989B230", VA = "0x18989C830")]
		private void SAJCKGYXWXY(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9892FF0", Offset = "0x98919F0", VA = "0x189892FF0")]
		private void AREIIXDEBOQ(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9898B80", Offset = "0x9897580", VA = "0x189898B80")]
		private void LJMGIQPDZNJ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9893A50", Offset = "0x9892450", VA = "0x189893A50")]
		private void HTXKGWRPYBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x989C590", Offset = "0x989AF90", VA = "0x18989C590")]
		private void RSVNLUFMTIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9893400", Offset = "0x9891E00", VA = "0x189893400")]
		private void BTTCBINSKKX(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9893A50", Offset = "0x9892450", VA = "0x189893A50")]
		private void CLTDRWVJCYK(GiftPackageReceivedArgs a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9893A50", Offset = "0x9892450", VA = "0x189893A50")]
		private void FEZXKQFULXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9895C90", Offset = "0x9894690", VA = "0x189895C90")]
		private void GGIWKKGTABM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98965C0", Offset = "0x9894FC0", VA = "0x1898965C0")]
		private void HHWXZESLHTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x989E7B0", Offset = "0x989D1B0", VA = "0x18989E7B0")]
		private bool YPINJGDHKBT(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x989CBD0", Offset = "0x989B5D0", VA = "0x18989CBD0")]
		private bool SPTWHJQLJZW(Guid a, [Out] KeepsakeCategoryConfigDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x989A100", Offset = "0x9898B00", VA = "0x18989A100")]
		private void NQPMDCOTULO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9898840", Offset = "0x9897240", VA = "0x189898840")]
		private bool KUFFHSWNSEV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x989A870", Offset = "0x9899270", VA = "0x18989A870")]
		private List<long> OVRQRXGEWTN(IEnumerable<KeepsakeRoomDTO> a, IReadOnlyList<KeepsakeRoomListDTO> b, long c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9893510", Offset = "0x9891F10", VA = "0x189893510")]
		private bool BYPQMJOEHDV(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x989D850", Offset = "0x989C250", VA = "0x18989D850", Slot = "47")]
		public string VXJKEOWWWDE(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x989A370", Offset = "0x9898D70", VA = "0x18989A370", Slot = "49")]
		public string OPOSAKVQVWZ(ProgressionEventConfigurableTextType a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x989AB30", Offset = "0x9899530", VA = "0x18989AB30", Slot = "48")]
		public string OZEJBBYYGAO(ProgressionEventConfigurableTextType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9897990", Offset = "0x9896390", VA = "0x189897990")]
		private void KEIUSPFXWUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9899EC0", Offset = "0x98988C0", VA = "0x189899EC0")]
		private void NHTSEKPMSFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x989B8C0", Offset = "0x989A2C0", VA = "0x18989B8C0")]
		private ProgressionEventConfigurableTextType PYXKXVFUHKY(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x989ECF0", Offset = "0x989D6F0", VA = "0x18989ECF0")]
		private ProgressionEventConfigurableTextType ZTIVQAGIZRS(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9896E90", Offset = "0x9895890", VA = "0x189896E90")]
		internal static string IJJNRDTWEQQ(KeepsakeCollectInstanceResponse a, string b, bool c, int d, int e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9894D60", Offset = "0x9893760", VA = "0x189894D60", Slot = "52")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x989A1E0", Offset = "0x9898BE0", VA = "0x18989A1E0")]
		private BYMJGVKDRDM OECZBOPOCNG(JNIVCIZIPSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9893D70", Offset = "0x9892770", VA = "0x189893D70")]
		private WOYGRUYHDYL CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x989AC00", Offset = "0x9899600", VA = "0x18989AC00")]
		private Task OnRoomLoadStarted(QVBCTCOYKBH args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x989A260", Offset = "0x9898C60", VA = "0x18989A260")]
		[AsyncStateMachine(typeof(<OnRunMigrations>d__182))]
		private Task OMTOLNXPJDJ(QVBCTCOYKBH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x989BF20", Offset = "0x989A920", VA = "0x18989BF20")]
		private Task QWVRDQWJAMM(QVBCTCOYKBH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9899730", Offset = "0x9898130", VA = "0x189899730")]
		[AsyncStateMachine(typeof(<PeriodicLog>d__184))]
		private Task MLVUSZJNQRX(string a, TimeSpan b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD4BF70", Offset = "0xD4A970", VA = "0x180D4BF70")]
		[CompilerGenerated]
		private void CEAAJMZHZRZ(IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x989E1B0", Offset = "0x989CBB0", VA = "0x18989E1B0")]
		[CompilerGenerated]
		private void XFBBTIGZSJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x989E160", Offset = "0x989CB60", VA = "0x18989E160")]
		[CompilerGenerated]
		private void XEVUWBNCIYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x989E9B0", Offset = "0x989D3B0", VA = "0x18989E9B0")]
		[CompilerGenerated]
		private bool YZBQWLSRLIJ(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9897770", Offset = "0x9896170", VA = "0x189897770")]
		[CompilerGenerated]
		private MPVTAJGPRUT<Dictionary<KeepsakeCategory, int>> JHBHTOZWYQN(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9894520", Offset = "0x9892F20", VA = "0x189894520")]
		[CompilerGenerated]
		private MPVTAJGPRUT<Dictionary<KeepsakeCategory, int>> DUKPHIDFTCN(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x989CE00", Offset = "0x989B800", VA = "0x18989CE00")]
		[CompilerGenerated]
		private bool TAMWEZWUJBK(KeepsakeRoomListDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x98938E0", Offset = "0x98922E0", VA = "0x1898938E0")]
		[CompilerGenerated]
		private bool CEMQPCVKTZH(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x989CEE0", Offset = "0x989B8E0", VA = "0x18989CEE0")]
		[CompilerGenerated]
		private void TBYBSXFRWYU(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x989D070", Offset = "0x989BA70", VA = "0x18989D070")]
		[CompilerGenerated]
		private void TCDIQDZPGKD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9893240", Offset = "0x9891C40", VA = "0x189893240")]
		[CompilerGenerated]
		private Task BSKZRMNCWPD(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KeepsakesConfig : ScriptableObject, DTYUQONQODC<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class JOXUKJQLBDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public string ZIGUVSPYBTC;

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
				public JOXUKJQLBDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x9892360", Offset = "0x9890D60", VA = "0x189892360")]
				internal bool BPKIHMGWQKP(KeepsakeTheme a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9892360", Offset = "0x9890D60", VA = "0x189892360")]
				internal bool BPFBKFMZGZG(KeepsakeTheme a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9892410", Offset = "0x9890E10", VA = "0x189892410")]
			public bool GTODSSUDHST(string a, [Out] KeepsakeTheme b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9892390", Offset = "0x9890D90", VA = "0x189892390")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void BREYGLPBXMV(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xD6A2A0", Offset = "0xD68CA0", VA = "0x180D6A2A0")]
		public KeepsakesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AssetReference PickupPrefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float LoopingSfxVolume;
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
