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
		[Cpp2IlInjected.Address(RVA = "0x848EA20", Offset = "0x848DC20", VA = "0x18848EA20")]
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
namespace _AssemblyRegistry.RecRoom_Keepsakes_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84907C0", Offset = "0x848F9C0", VA = "0x1884907C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class IOTPYQBHEQC : IComparer<KeepsakeCategory>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class PWPEITYPPDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KeepsakeCategory PMHNVEFGBFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KeepsakeCategory PMMUSKZDKRF;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PWPEITYPPDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC14390", Offset = "0xC13590", VA = "0x180C14390")]
			internal bool CWJFOFLYNOD(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1DB12B0", Offset = "0x1DB04B0", VA = "0x181DB12B0")]
			internal bool CWDYQYSBECU(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC14390", Offset = "0xC13590", VA = "0x180C14390")]
			internal bool CWTTISZTGKV(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1DB12B0", Offset = "0x1DB04B0", VA = "0x181DB12B0")]
			internal bool CWOMLMFVWZM(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<KeepsakeCategoryThemePair> MILBJGRNCSR;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public IOTPYQBHEQC(List<KeepsakeCategoryThemePair> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x848DD30", Offset = "0x848CF30", VA = "0x18848DD30", Slot = "4")]
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
	public class CGQYRIWFTXW : KYQGRLOLWUZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class SLGUXIILIXR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public KeepsakeTheme NSKBYHHABCB;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public SLGUXIILIXR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1DF92B0", Offset = "0x1DF84B0", VA = "0x181DF92B0")]
			internal bool TTHHJGFFWGB(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class QJFRRIOUIRT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public long OSAPKIKJHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public long CCICSEQUQCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KeepsakeCategory? VXQFSBBIFQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CVZNPZSDRCM;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public QJFRRIOUIRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x848F090", Offset = "0x848E290", VA = "0x18848F090")]
			internal void EJFWPWMZIRR(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x848E1F0", Offset = "0x848D3F0", VA = "0x18848E1F0")]
			internal void EJAPSPTBZGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x848F120", Offset = "0x848E320", VA = "0x18848F120")]
			internal YUBVFZQANJB<IEnumerable<Guid>> EJQKKKAUBOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7EED460", Offset = "0x7EEC660", VA = "0x187EED460")]
			internal bool EJLDNDGWSDA(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class QJAKUBUWZGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KeepsakeRoomInstanceIdsDTO PAEKIKKPCLW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public QJFRRIOUIRT BXOYYNWATYZ;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public QJAKUBUWZGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x848EF60", Offset = "0x848E160", VA = "0x18848EF60")]
			internal YUBVFZQANJB<IEnumerable<Guid>> EKAYEXOOULB(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class QIVDWVAZPVB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KeepsakeRoomInstancesDTO NBPUVXBLBVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public QJAKUBUWZGK BWZEGTOIRQY;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public QIVDWVAZPVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x848EE40", Offset = "0x848E040", VA = "0x18848EE40")]
			internal bool EJVRHQURKZS(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class QIPWZOHCGJS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Guid NJQDWXZZAJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public QIVDWVAZPVB BXELEAIGBCH;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public QIPWZOHCGJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x848ED90", Offset = "0x848DF90", VA = "0x18848ED90")]
			internal bool EKLLZLCJNHT(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class VGASEOUBWIU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public long CCICSEQUQCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CWKBKNFYJZE;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public VGASEOUBWIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x848FEB0", Offset = "0x848F0B0", VA = "0x18848FEB0")]
			internal YUBVFZQANJB<IEnumerable<Guid>> QPUEMRKAOKY(IEnumerable<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x848D560", Offset = "0x848C760", VA = "0x18848D560")]
			internal bool QPZLJYDXXWH(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JEXGLCHBCDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long OSAPKIKJHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public long CCICSEQUQCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CVZNPZSDRCM;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JEXGLCHBCDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x848E160", Offset = "0x848D360", VA = "0x18848E160")]
			internal void JSCACAYYRAQ(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x848E1F0", Offset = "0x848D3F0", VA = "0x18848E1F0")]
			internal void JSHGZHSWALZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x848E220", Offset = "0x848D420", VA = "0x18848E220")]
			internal YUBVFZQANJB<Dictionary<Guid, KeepsakeCategory>> JSMNWOMTJXI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7EED460", Offset = "0x7EEC660", VA = "0x187EED460")]
			internal bool JSRUTVGQTIR(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JERZNVNDSRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public KeepsakeRoomInstanceIdsDTO PAEKIKKPCLW;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JERZNVNDSRS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x848DFC0", Offset = "0x848D1C0", VA = "0x18848DFC0")]
			internal YUBVFZQANJB<Dictionary<Guid, KeepsakeCategory>> JRGYMZXJFHG(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JFHUFPUVUZT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public KeepsakeRoomInstancesDTO NBPUVXBLBVA;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JFHUFPUVUZT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x848E4F0", Offset = "0x848D6F0", VA = "0x18848E4F0")]
			internal bool JRMFKGRGOSP(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x848E5D0", Offset = "0x848D7D0", VA = "0x18848E5D0")]
			internal KeyValuePair<Guid, KeepsakeCategory> JRRMHNLDYDY(Guid a)
			{
				return default(KeyValuePair<Guid, KeepsakeCategory>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JFCNIJAYLOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Guid NJQDWXZZAJY;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JFCNIJAYLOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xDEAAC0", Offset = "0xDE9CC0", VA = "0x180DEAAC0")]
			internal bool JRWTEUFBHPH(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JECEWBFLQJR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Guid NJQDWXZZAJY;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JECEWBFLQJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xDEAAC0", Offset = "0xDE9CC0", VA = "0x180DEAAC0")]
			internal bool JQLWXYVTTNW(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class ELQORJZBBVQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public long CCICSEQUQCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CWKBKNFYJZE;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ELQORJZBBVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x848D580", Offset = "0x848C780", VA = "0x18848D580")]
			internal YUBVFZQANJB<Dictionary<Guid, KeepsakeCategory>> XBDHEDJDFAN(Dictionary<Guid, KeepsakeCategory> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x848D560", Offset = "0x848C760", VA = "0x18848D560")]
			internal bool XAYAGWPFVPE(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class ELVVOQSYLGZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public KeepsakeRoomInstanceIdsDTO DGWKKMWIRYC;

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ELVVOQSYLGZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x848D770", Offset = "0x848C970", VA = "0x18848D770")]
			internal bool XASTJPVIMDV(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class YFTECVXEIMT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Dictionary<Guid, KeepsakeCategory> GFXCFELUWKU;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YFTECVXEIMT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8490020", Offset = "0x848F220", VA = "0x188490020")]
			internal KeyValuePair<KeepsakeCategory, int> PTQGEHJXTEY(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class YFNXFPDGZBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public KeepsakeCategory IROAIXCQASQ;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YFNXFPDGZBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xD40140", Offset = "0xD3F340", VA = "0x180D40140")]
			internal bool PUGAWBRPVMZ(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OLRLJPCHAGX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Dictionary<Guid, KeepsakeCategory> GFXCFELUWKU;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public OLRLJPCHAGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x848EAA0", Offset = "0x848DCA0", VA = "0x18848EAA0")]
			internal KeyValuePair<KeepsakeCategory, int> AHEPGAOURUM(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OLMEMIIJQVO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public KeepsakeCategory IROAIXCQASQ;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public OLMEMIIJQVO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD40140", Offset = "0xD3F340", VA = "0x180D40140")]
			internal bool AHUJXUWMUCN(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ZBWGQHYDFSX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public long CCICSEQUQCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Func<KeepsakeRoomDTO, bool> CVZNPZSDRCM;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZBWGQHYDFSX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x84906D0", Offset = "0x848F8D0", VA = "0x1884906D0")]
			internal bool WOEUROQWIGE(DateTime a, DateTime b, int c, TimeSpan d, TimeSpan e, int f)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8490610", Offset = "0x848F810", VA = "0x188490610")]
			internal bool JWPEMAHZGHT(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x84905F0", Offset = "0x848F7F0", VA = "0x1884905F0")]
			internal bool JWEQRMUENLB(KeepsakeRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x84905F0", Offset = "0x848F7F0", VA = "0x1884905F0")]
			internal bool JVZJUGAHDZS(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class YYHXWUAVSJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public long DZWQZJFXIFN;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YYHXWUAVSJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x10EB6D0", Offset = "0x10EA8D0", VA = "0x1810EB6D0")]
			internal bool OMKCQTDSAJV(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NYHLSREMPFV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public long CCICSEQUQCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Func<KeepsakeRoomDTO, bool> CWKBKNFYJZE;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public NYHLSREMPFV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x848E960", Offset = "0x848DB60", VA = "0x18848E960")]
			internal bool FMARZPVQMFP(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x246F070", Offset = "0x246E270", VA = "0x18246F070")]
			internal bool FLVLCJBTCUG(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AZIVZLQNVHW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public long DZWQZJFXIFN;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public AZIVZLQNVHW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x847FF40", Offset = "0x847F140", VA = "0x18847FF40")]
			internal bool AGDIUYTHCUE(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class NSJGIBRIUTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public long DZWQZJFXIFN;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public NSJGIBRIUTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x10EB6D0", Offset = "0x10EA8D0", VA = "0x1810EB6D0")]
			internal bool BWQQERELQXT(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class TFOJJLOXOSV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public KeepsakeCategory VXQFSBBIFQJ;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public TFOJJLOXOSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2018F30", Offset = "0x2018130", VA = "0x182018F30")]
			internal bool MXXXSYLWCQD(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class IABAICXQOLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Guid UTPKOYPKLLJ;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public IABAICXQOLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x848D7F0", Offset = "0x848C9F0", VA = "0x18848D7F0")]
			internal bool DTYGKBVAAOK(KeyValuePair<Guid, KeepsakeInstanceDTO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class RFQWUYCPTXX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public KeepsakeCategory VXQFSBBIFQJ;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RFQWUYCPTXX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x848F400", Offset = "0x848E600", VA = "0x18848F400")]
			internal bool RSWTIHWFZCT(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class CIXWTBTLZYS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public long RRWMZNGMSRJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public long? ZPYRPWIXSRB;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public CIXWTBTLZYS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x848D4E0", Offset = "0x848C6E0", VA = "0x18848D4E0")]
			internal bool XSAZLQLLTIE(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class PCLOEHQRTBZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IReadOnlyList<KeepsakeRoomListDTO> EEGNVJNAYTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public long DZWQZJFXIFN;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PCLOEHQRTBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x848EC70", Offset = "0x848DE70", VA = "0x18848EC70")]
			internal bool VSHZMORLYKP(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class PCGHHAWUJQQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public KeepsakeRoomDTO OKKEMJXCXZR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public PCLOEHQRTBZ BXOYYNWATYZ;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PCGHHAWUJQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x848EBF0", Offset = "0x848DDF0", VA = "0x18848EBF0")]
			internal bool VSNGJVLJHVY(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class YYBBUAIHDSI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KeepsakeCategory VXQFSBBIFQJ;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YYBBUAIHDSI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8490170", Offset = "0x848F370", VA = "0x188490170")]
			internal YUBVFZQANJB<Guid> EUNVIBIXAZH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x84902B0", Offset = "0x848F4B0", VA = "0x1884902B0")]
			internal void JJZRDHGBJXO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8490590", Offset = "0x848F790", VA = "0x188490590")]
			internal void OVOOJLUGZVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x84902E0", Offset = "0x848F4E0", VA = "0x1884902E0")]
			internal void JLFGMVVLONQ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8490560", Offset = "0x848F760", VA = "0x188490560")]
			internal void JLKNKCPIXYZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IKTPTXHVJYK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public CGQYRIWFTXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string JULBUIGYCWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int EMFVIQOUBGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int BDRKSSABWNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Guid UTPKOYPKLLJ;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public IKTPTXHVJYK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x848D850", Offset = "0x848CA50", VA = "0x18848D850")]
			internal void RDCHWRHAPFT(KeepsakeCollectInstanceResponse a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x848DBF0", Offset = "0x848CDF0", VA = "0x18848DBF0")]
			internal void TIWZVPKPTYZ(string a)
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
			public CGQYRIWFTXW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public VVQZTMKDHUV args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x848F440", Offset = "0x848E640", VA = "0x18848F440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x848F950", Offset = "0x848EB50", VA = "0x18848F950", Slot = "5")]
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
			public CGQYRIWFTXW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x848F9B0", Offset = "0x848EBB0", VA = "0x18848F9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x848FC40", Offset = "0x848EE40", VA = "0x18848FC40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DateTime DGQFPBRUSSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly XJPEGCTSSAX QKASJCZUGKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly CMNATDCDXRM CXONYCODVQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DSCOILSOONU EDXFFYRESEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DHIZDJTJLSK CVKSQOQXLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MVHDAATPYEX YGBJUYIHLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly YXFQJLMWAHA CFMWTRVLRJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly NBMWIRABPWK ZCPIZNWHJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly JXLRYILWFBT ZFWRMIZGFXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly TDQAYPPTDQO BFCWNEYYTMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HQDPZBBKFYM UIRWLKYJABT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly PBHCMGDDDFE RXIWODWRQXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly GJSUFZBCMRJ ISBCCBCCAVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly PLDDOAEQJKZ TKHTNKXQSRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly OBVQORTVBEB RPUHDUNUSEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly DHASTMKITSC YZLRLPPSQVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly BFXRBPRFCAQ<KeepsakesConfig.KeepsakesOptions> NFOLYNSOXLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly TSCPVZNNMEJ LAYLIKHTYMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Dictionary<Guid, KeepsakeInstanceDTO> JFGKVHEKDWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HashSet<Guid> AVPHFVFTSMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<long> GQZOETLWGPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<KeepsakeCategory, int> JUSNCKEDRIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly HashSet<Guid> CMXJNTZRBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IDisposable TPJCNPRTTLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Task NEJSTICUJSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private YUBVFZQANJB<Guid> NAVWLKIKKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long? OBHUYYLAHZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private KeepsakeProgressionEventInstancesDTO FSIKNGCOCSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private YUBVFZQANJB<KeepsakeProgressionEventInstancesDTO> JKZTTKIAQNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> CSKZOTOXUMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KeepsakeGlobalConfigDTO PBCZKMFGARH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HashSet<long> PKYICXVPJUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HashSet<long> CYFXRKSTXCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private List<KeepsakeRoomListDTO> EJZIYCFCVAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<KeepsakeRoomListDTO> CFIBNQJPGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private List<KeepsakeRoomListDTO> KPFIKQCSXLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<long, string> FFCBDPBVAOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Dictionary<long, string> XMOGYMVLJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<long, DateTime> BWASDGDZZNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Dictionary<long, List<KeepsakeRoomDTO>> OMDLYUCFQMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Dictionary<long, List<KeepsakeRoomDTO>> INPSYJVXPXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private Dictionary<long, long> KQSIBVXYYZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<string> YOFINSZJRTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private DateTime YMEKXUEGAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly IDisposable JTNVMXBREYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Dictionary<Guid, KeepsakeCategory> SRCVIQQMAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<KeepsakeCategory, int> KXUIUFMMLTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<KeepsakeCategoryThemePair> QSHTMNCXKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IOTPYQBHEQC PZAWJYPSKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool OXBEGLDMTMQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OMCJXZOLTPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB1BF50", Offset = "0xB1B150", VA = "0x180B1BF50", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB1C780", Offset = "0xB1B980", VA = "0x180B1C780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool XUGSZSSTYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8480560", Offset = "0x847F760", VA = "0x188480560", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JKSBMDGVVYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x847FFA0", Offset = "0x847F1A0", VA = "0x18847FFA0", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private long HISTZXNJWDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84816C0", Offset = "0x84808C0", VA = "0x1884816C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private long? PTNQXFDCNHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8489530", Offset = "0x8488730", VA = "0x188489530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool BEQAPYVFGZE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84804B0", Offset = "0x847F6B0", VA = "0x1884804B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<KeepsakeRoomListDTO> XSINGDFGBRM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB4CE40", Offset = "0xB4C040", VA = "0x180B4CE40", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<KeepsakeRoomListDTO> MTNOALXEBKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB4CC90", Offset = "0xB4BE90", VA = "0x180B4CC90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<KeepsakeRoomListDTO> UVNVMECBNIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB4D110", Offset = "0xB4C310", VA = "0x180B4D110", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<long, string> ILHZSTWRGZP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB4CE30", Offset = "0xB4C030", VA = "0x180B4CE30", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal bool LASNKQISPAY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x120BBA0", Offset = "0x120ADA0", VA = "0x18120BBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid?> DVMLOHKBEMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8480230", Offset = "0x847F430", VA = "0x188480230", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8488AB0", Offset = "0x8487CB0", VA = "0x188488AB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action SCCBSGQGXDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8488B60", Offset = "0x8487D60", VA = "0x188488B60", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8488550", Offset = "0x8487750", VA = "0x188488550", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action XMBDXYAZKMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8484CB0", Offset = "0x8483EB0", VA = "0x188484CB0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x84804C0", Offset = "0x847F6C0", VA = "0x1884804C0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x848C000", Offset = "0x848B200", VA = "0x18848C000")]
		[RecRoom.NoEngine.Common.Preserve]
		internal CGQYRIWFTXW([Inject(null)][NotNull] XJPEGCTSSAX notificationManager, [Inject(null)][NotNull] KUZZQXDXVXR roomLoader, [Inject(null)][NotNull] CMNATDCDXRM creationHelper, [Inject(null)][NotNull] DSCOILSOONU roomPersistenceManager, [Inject(null)][NotNull] DHIZDJTJLSK progressionEventsManager, [Inject(null)][NotNull] MVHDAATPYEX roomManager, [Inject(null)][NotNull] YXFQJLMWAHA storefrontManager, [Inject(null)][NotNull] NBMWIRABPWK roomSaveValidation, [Inject(null)][NotNull] JXLRYILWFBT networking, [Inject(null)][NotNull] KVGRDGYLPNU scheduledUpdateService, [Inject(null)][NotNull] TDQAYPPTDQO recNetMatchmaking, [Inject(null)][NotNull] HQDPZBBKFYM recNetKeepsakes, [Inject(null)][NotNull] PBHCMGDDDFE recNetAccounts, [Inject(null)][NotNull] GJSUFZBCMRJ recNetStorefronts, [Inject(null)][NotNull] PLDDOAEQJKZ recNetGifts, [Inject(null)][NotNull] OBVQORTVBEB timeService, [Inject(null)][NotNull] DHASTMKITSC debugLogger, [Inject(null)][NotNull] BFXRBPRFCAQ<KeepsakesConfig.KeepsakesOptions> options, [Inject(null)][NotNull] TSCPVZNNMEJ gameConfigsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84827E0", Offset = "0x84819E0", VA = "0x1884827E0", Slot = "15")]
		public bool EQPFSLARTDN(List<string> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8484570", Offset = "0x8483770", VA = "0x188484570", Slot = "16")]
		public YUBVFZQANJB<Guid> ITQAFWYKZZU(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8487CB0", Offset = "0x8486EB0", VA = "0x188487CB0", Slot = "17")]
		public AZBXLTTNREY TDLWAIYNKPX(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8481360", Offset = "0x8480560", VA = "0x188481360", Slot = "18")]
		public AZBXLTTNREY DFKLUXOMCTO(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8488C00", Offset = "0x8487E00", VA = "0x188488C00", Slot = "19")]
		public bool VYAGCBYQEJW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x848B9F0", Offset = "0x848ABF0", VA = "0x18848B9F0", Slot = "20")]
		public bool ZILFKGEFCPS(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84802E0", Offset = "0x847F4E0", VA = "0x1884802E0")]
		public KeepsakeTheme AKLKUVVOZRE(Guid a)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8485450", Offset = "0x8484650", VA = "0x188485450")]
		public bool KINFIATMQVM(KeepsakeCategory a, [Out] KeepsakeTheme b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84834D0", Offset = "0x84826D0", VA = "0x1884834D0")]
		public List<KeepsakeTheme> FSSYKJZPEMU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x848ADC0", Offset = "0x8489FC0", VA = "0x18848ADC0")]
		public int YHYGHGEWQKL(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8481720", Offset = "0x8480920", VA = "0x188481720")]
		public KeepsakeCategory DMLJELQLZRL(Guid a)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8482460", Offset = "0x8481660", VA = "0x188482460", Slot = "34")]
		public List<KeepsakeCategory> ELZQJLGLWJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84839F0", Offset = "0x8482BF0", VA = "0x1884839F0", Slot = "35")]
		public IComparer<KeepsakeCategory> FYTLEMGKWRE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8485FA0", Offset = "0x84851A0", VA = "0x188485FA0", Slot = "32")]
		public string OPBEVQCKEKB(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8485AB0", Offset = "0x8484CB0", VA = "0x188485AB0", Slot = "33")]
		public string LTBEQKFHNRD(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x848BA40", Offset = "0x848AC40", VA = "0x18848BA40", Slot = "21")]
		public bool ZQXIHXSEBVY(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8486560", Offset = "0x8485760", VA = "0x188486560", Slot = "22")]
		public void POBWSVQCWCQ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8487C60", Offset = "0x8486E60", VA = "0x188487C60", Slot = "23")]
		public void SXEEWHENFGA(KeepsakeCategory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8483A90", Offset = "0x8482C90", VA = "0x188483A90", Slot = "24")]
		public void GUJIMMAMNQQ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8484160", Offset = "0x8483360", VA = "0x188484160", Slot = "25")]
		public int HQLTVBNPWFE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84865D0", Offset = "0x84857D0", VA = "0x1884865D0", Slot = "31")]
		public YUBVFZQANJB<IEnumerable<Guid>> PYIWGZBOQPV(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8488FB0", Offset = "0x84881B0", VA = "0x188488FB0", Slot = "30")]
		public YUBVFZQANJB<IEnumerable<Guid>> WBPVQVCZNYW(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84881A0", Offset = "0x84873A0", VA = "0x1884881A0", Slot = "54")]
		public YUBVFZQANJB<Dictionary<Guid, KeepsakeCategory>> TMVJAXEWNAG(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x848B1B0", Offset = "0x848A3B0", VA = "0x18848B1B0", Slot = "55")]
		public YUBVFZQANJB<Dictionary<Guid, KeepsakeCategory>> YTIOWLPONFX(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8487F10", Offset = "0x8487110", VA = "0x188487F10", Slot = "26")]
		public YUBVFZQANJB<int> TFYGPMRIFEW(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8483DF0", Offset = "0x8482FF0", VA = "0x188483DF0", Slot = "27")]
		public YUBVFZQANJB<int> HHMIAJFYBMC(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x848ABC0", Offset = "0x8489DC0", VA = "0x18848ABC0", Slot = "28")]
		public YUBVFZQANJB<Dictionary<KeepsakeCategory, int>> XVQRLVVKTGX(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x848BF40", Offset = "0x848B140", VA = "0x18848BF40", Slot = "29")]
		public YUBVFZQANJB<Dictionary<KeepsakeCategory, int>> ZVNVZQMKYUD(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8489140", Offset = "0x8488340", VA = "0x188489140", Slot = "37")]
		public bool WGQDWCYKXKX(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84805E0", Offset = "0x847F7E0", VA = "0x1884805E0", Slot = "56")]
		public bool BKXZPAGZMHN(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8485F00", Offset = "0x8485100", VA = "0x188485F00", Slot = "38")]
		public bool OFWGDFFEVBY(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8483110", Offset = "0x8482310", VA = "0x188483110", Slot = "57")]
		public bool FCLOZSMBGMY(long a, [Out] KeepsakeRoomLockStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x848AF40", Offset = "0x848A140", VA = "0x18848AF40", Slot = "39")]
		public bool YIUXOWIZMMV(long a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8484ED0", Offset = "0x84840D0", VA = "0x188484ED0", Slot = "40")]
		public long JXTDTNSWDHV(long a, bool b = false)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8486990", Offset = "0x8485B90", VA = "0x188486990", Slot = "41")]
		public long QAJZFXPGHNP(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8480060", Offset = "0x847F260", VA = "0x188480060", Slot = "42")]
		public int AGLMRMRMMYK(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84859D0", Offset = "0x8484BD0", VA = "0x1884859D0", Slot = "43")]
		public bool KZHBDKVQZYT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8484D50", Offset = "0x8483F50", VA = "0x188484D50", Slot = "44")]
		public bool JLIPLXGGIKB(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8480640", Offset = "0x847F840", VA = "0x188480640", Slot = "45")]
		public IReadOnlyList<long> BLVMUKYIQQW(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x848A610", Offset = "0x8489810", VA = "0x18848A610", Slot = "46")]
		public int XDQZPOJZGLF(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x848B740", Offset = "0x848A940", VA = "0x18848B740", Slot = "50")]
		public long ZASGTDQXSNY(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8487720", Offset = "0x8486920", VA = "0x188487720", Slot = "51")]
		public KeepsakeCategory RMTNGYEBLPE()
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8481F60", Offset = "0x8481160", VA = "0x188481F60")]
		private void ECAVMJGHXFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8486AC0", Offset = "0x8485CC0", VA = "0x188486AC0")]
		private void RBNHOYEYVQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84891A0", Offset = "0x84883A0", VA = "0x1884891A0")]
		private int WGSNPHPZCDX(KeepsakeRoomListDTO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8481A50", Offset = "0x8480C50", VA = "0x188481A50")]
		private int DVMDYDNVNPU(DateTime a, DateTime b, TimeSpan c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x848B330", Offset = "0x848A530", VA = "0x18848B330")]
		private void YWVRLMOEOWP(IEnumerable<KeepsakeInstanceDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8485630", Offset = "0x8484830", VA = "0x188485630")]
		private void KOONNEYIKXH(IEnumerable<KeepsakeCollectionRecordDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8487BE0", Offset = "0x8486DE0", VA = "0x188487BE0")]
		private void SVHTDLSOBSU(IEnumerable<long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xC83E70", Offset = "0xC83070", VA = "0x180C83E70")]
		private void ZQDIGAHPRCI(KeepsakeGlobalConfigDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8482590", Offset = "0x8481790", VA = "0x188482590")]
		private bool ENAQFNRBBFN(KeepsakeCategory a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8483950", Offset = "0x8482B50", VA = "0x188483950")]
		private bool FWAVBGBJGED([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8486500", Offset = "0x8485700", VA = "0x188486500")]
		private bool PKFSRKFTXPU(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84885F0", Offset = "0x84877F0", VA = "0x1884885F0")]
		private IEnumerable<Guid> UDKMDSDXNHS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8483D30", Offset = "0x8482F30", VA = "0x188483D30")]
		private IEnumerable<KeepsakeInstanceDTO> GZYKBJEOYAV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8480420", Offset = "0x847F620", VA = "0x188480420")]
		private void AKTPNQKPPMQ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8487B30", Offset = "0x8486D30", VA = "0x188487B30")]
		private bool RRQKHBQRTIG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8488730", Offset = "0x8487930", VA = "0x188488730")]
		private void UILTPXGLCWU(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8481970", Offset = "0x8480B70", VA = "0x188481970")]
		private void DUJTJWHLLBB(KeepsakeCategory a, int b, Dictionary<KeepsakeCategory, int> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x848A6C0", Offset = "0x84898C0", VA = "0x18848A6C0")]
		private int XJNPJKBXJAP(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8483F40", Offset = "0x8483140", VA = "0x188483F40")]
		private void HOUOZONVRXE(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8488D60", Offset = "0x8487F60", VA = "0x188488D60")]
		private void WBPEZGSJQZW(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8481880", Offset = "0x8480A80", VA = "0x188481880")]
		private void DTMSEINLRFB(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84805B0", Offset = "0x847F7B0", VA = "0x1884805B0")]
		private void TGLSJCPRKUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8486AA0", Offset = "0x8485CA0", VA = "0x188486AA0")]
		private void QCFTTDBYFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x848BED0", Offset = "0x848B0D0", VA = "0x18848BED0")]
		private void ZSWDKQZGABR(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84805B0", Offset = "0x847F7B0", VA = "0x1884805B0")]
		private void JWIOTDJCKJQ(GiftPackageReceivedArgs a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84805B0", Offset = "0x847F7B0", VA = "0x1884805B0")]
		private void BGXSYFZCPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8480FC0", Offset = "0x84801C0", VA = "0x188480FC0")]
		private void DCIOVGZMVHM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8482A70", Offset = "0x8481C70", VA = "0x188482A70")]
		private void ERKFGYDGFSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x848BCD0", Offset = "0x848AED0", VA = "0x18848BCD0")]
		private bool ZSRQBCLICYN(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8485C30", Offset = "0x8484E30", VA = "0x188485C30")]
		private bool LVSYOXNCLNG(Guid a, [Out] KeepsakeCategoryConfigDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84888C0", Offset = "0x8487AC0", VA = "0x1884888C0")]
		private void UUHZPAFVNZW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84808B0", Offset = "0x847FAB0", VA = "0x1884808B0")]
		private bool CJQCNUCBTCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x848A910", Offset = "0x8489B10", VA = "0x18848A910")]
		private List<long> XLNORCMZRVN(IEnumerable<KeepsakeRoomDTO> a, IReadOnlyList<KeepsakeRoomListDTO> b, long c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84809C0", Offset = "0x847FBC0", VA = "0x1884809C0")]
		private bool CRFZBIOACWT(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8487100", Offset = "0x8486300", VA = "0x188487100", Slot = "47")]
		public string RBNILVISBKK(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8487320", Offset = "0x8486520", VA = "0x188487320", Slot = "49")]
		public string RDYKMOFCLVD(ProgressionEventConfigurableTextType a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8483040", Offset = "0x8482240", VA = "0x188483040", Slot = "48")]
		public string EXSLIIARROW(ProgressionEventConfigurableTextType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8489790", Offset = "0x8488990", VA = "0x188489790")]
		private void WXMMXBRKKMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x848B5B0", Offset = "0x848A7B0", VA = "0x18848B5B0")]
		private void YYGQMJRKTLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8487C40", Offset = "0x8486E40", VA = "0x188487C40")]
		private ProgressionEventConfigurableTextType SVTZFGTYQTC(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84834B0", Offset = "0x84826B0", VA = "0x1884834B0")]
		private ProgressionEventConfigurableTextType FNAURXCRMJW(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84895C0", Offset = "0x84887C0", VA = "0x1884895C0")]
		internal static string WVSJWWFCOCM(KeepsakeCollectInstanceResponse a, string b, bool c, int d, int e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8481B50", Offset = "0x8480D50", VA = "0x188481B50", Slot = "52")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8480D90", Offset = "0x847FF90", VA = "0x188480D90")]
		private IYETYTALWPI CVETOLXPAPK(HJIMNRPSBJR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8480E10", Offset = "0x8480010", VA = "0x188480E10")]
		private NJGIIXHEBVR CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8486120", Offset = "0x8485320", VA = "0x188486120")]
		private Task OnRoomLoadStarted(VVQZTMKDHUV args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84889A0", Offset = "0x8487BA0", VA = "0x1884889A0")]
		[AsyncStateMachine(typeof(<OnRunMigrations>d__182))]
		private Task UXXJOHBLOOP(VVQZTMKDHUV a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8483880", Offset = "0x8482A80", VA = "0x188483880")]
		private Task FTUMGLLACSI(VVQZTMKDHUV a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x848B080", Offset = "0x848A280", VA = "0x18848B080")]
		[AsyncStateMachine(typeof(<PeriodicLog>d__184))]
		private Task YSEPAEZWTIV(string a, TimeSpan b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD80", Offset = "0xC8EF80", VA = "0x180C8FD80")]
		[CompilerGenerated]
		private void FIPKFLXAMAH(IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8483D10", Offset = "0x8482F10", VA = "0x188483D10")]
		[CompilerGenerated]
		private void GWQRLASXCMR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8483CC0", Offset = "0x8482EC0", VA = "0x188483CC0")]
		[CompilerGenerated]
		private void GWLKNTYZTBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8485E00", Offset = "0x8485000", VA = "0x188485E00")]
		[CompilerGenerated]
		private bool MTCPBBXDKWZ(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x848A7B0", Offset = "0x84899B0", VA = "0x18848A7B0")]
		[CompilerGenerated]
		private YUBVFZQANJB<Dictionary<KeepsakeCategory, int>> XJUVZCCKLSV(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8485870", Offset = "0x8484A70", VA = "0x188485870")]
		[CompilerGenerated]
		private YUBVFZQANJB<Dictionary<KeepsakeCategory, int>> KXXEMXICRZP(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x848BA20", Offset = "0x848AC20", VA = "0x18848BA20")]
		[CompilerGenerated]
		private bool ZJNTVNKZENG(KeepsakeRoomListDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8484B40", Offset = "0x8483D40", VA = "0x188484B40")]
		[CompilerGenerated]
		private bool JIVPKWOOQLH(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8489340", Offset = "0x8488540", VA = "0x188489340")]
		[CompilerGenerated]
		private void WJYQHTIYHEY(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84894D0", Offset = "0x84886D0", VA = "0x1884894D0")]
		[CompilerGenerated]
		private void WKDXFACVQQH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8487160", Offset = "0x8486360", VA = "0x188487160")]
		[CompilerGenerated]
		private Task RCNQSKSWHMV(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KeepsakesConfig : ScriptableObject, BFXRBPRFCAQ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class PWPEITYPPDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public string BDIKHHEYUPW;

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWPEITYPPDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x848ED60", Offset = "0x848DF60", VA = "0x18848ED60")]
				internal bool XQMHXEBTXNV(KeepsakeTheme a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x848ED60", Offset = "0x848DF60", VA = "0x18848ED60")]
				internal bool XQHAZXHWOCM(KeepsakeTheme a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x848E7A0", Offset = "0x848D9A0", VA = "0x18848E7A0")]
			public bool WDMDJCEHOVR(string a, [Out] KeepsakeTheme b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions LRBPAVAYBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x848E720", Offset = "0x848D920", VA = "0x18848E720")]
		[OCFGNIRMEEE.Root.GameOnly]
		internal static void XXZSNELNZLP(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB2F4B0", Offset = "0xB2E6B0", VA = "0x180B2F4B0")]
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
