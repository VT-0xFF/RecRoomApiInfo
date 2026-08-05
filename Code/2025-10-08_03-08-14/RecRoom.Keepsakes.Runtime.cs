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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85EC350", Offset = "0x85EB150", VA = "0x1885EC350")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x85ED310", Offset = "0x85EC110", VA = "0x1885ED310", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MOAIPVLRDSR : IComparer<KeepsakeCategory>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KeepsakeCategory PADUZFMKSOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KeepsakeCategory OZYOBYSNJDQ;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE8F130", Offset = "0xE8DF30", VA = "0x180E8F130")]
			internal bool ORMGTJCPQZI(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x21EDC50", Offset = "0x21ECA50", VA = "0x1821EDC50")]
			internal bool ORRNQPWNAKR(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE8F130", Offset = "0xE8DF30", VA = "0x180E8F130")]
			internal bool ORBSYVOUYCQ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x21EDC50", Offset = "0x21ECA50", VA = "0x1821EDC50")]
			internal bool ORGZWCISHNZ(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<KeepsakeCategoryThemePair> LUOASQAPCYY;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public MOAIPVLRDSR(List<KeepsakeCategoryThemePair> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85EC0C0", Offset = "0x85EAEC0", VA = "0x1885EC0C0", Slot = "4")]
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
	public class DXQPVNGWSMJ : VWCXBUJVYSO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class FVMQLBGSZPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public KeepsakeTheme ACQVRBRHLIU;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public FVMQLBGSZPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x85EBA10", Offset = "0x85EA810", VA = "0x1885EBA10")]
			internal bool XYAEGMZOEFS(KeepsakeCategoryThemePair a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BCUGIGZERCS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public long FHNFUEDEWBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public KeepsakeCategory? KVEIFRCRQFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CAVGZRMNGDV;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BCUGIGZERCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x85DC600", Offset = "0x85DB400", VA = "0x1885DC600")]
			internal void LUZPQQSHQKM(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x85DC690", Offset = "0x85DB490", VA = "0x1885DC690")]
			internal void LVEWNXMEZVV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x85DC6C0", Offset = "0x85DB4C0", VA = "0x1885DC6C0")]
			internal YLZUVDOLRNC<IEnumerable<Guid>> LVKDLEGCJHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8096470", Offset = "0x8095270", VA = "0x188096470")]
			internal bool LVPKIKZZSSN(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BCZNFNTCAOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public KeepsakeRoomInstanceIdsDTO LLEBWBVMVZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BCUGIGZERCS YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BCZNFNTCAOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x85DC9A0", Offset = "0x85DB7A0", VA = "0x1885DC9A0")]
			internal YLZUVDOLRNC<IEnumerable<Guid>> LVURFRTXCDW(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BCJSNTLJYGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public KeepsakeRoomInstancesDTO HHQXQKKAOVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public BCZNFNTCAOB YMDDPWVYDWF;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BCJSNTLJYGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x85DC430", Offset = "0x85DB230", VA = "0x1885DC430")]
			internal bool LVZYCYNULPF(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BCOZLAFHHRJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Guid YKKASJTZFKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public BCJSNTLJYGA YLXWSQCAUKW;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BCOZLAFHHRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x85DC550", Offset = "0x85DB350", VA = "0x1885DC550")]
			internal bool LWFFAFHRVAO(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class WTZKIRZMZGX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CBFUUFAHZAN;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WTZKIRZMZGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x85ED140", Offset = "0x85EBF40", VA = "0x1885ED140")]
			internal YLZUVDOLRNC<IEnumerable<Guid>> BRJYDJHGJHJ(IEnumerable<Guid> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x85EBCA0", Offset = "0x85EAAA0", VA = "0x1885EBCA0")]
			internal bool BRERGCNIZWA(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BGDKPIMXYVC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public long FHNFUEDEWBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CAVGZRMNGDV;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BGDKPIMXYVC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x85DCDA0", Offset = "0x85DBBA0", VA = "0x1885DCDA0")]
			internal void QYMIJLKRARL(KeepsakeProgressionEventInstancesDTO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x85DC690", Offset = "0x85DB490", VA = "0x1885DC690")]
			internal void QYHBMEQTRGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x85DCAD0", Offset = "0x85DB8D0", VA = "0x1885DCAD0")]
			internal YLZUVDOLRNC<Dictionary<Guid, KeepsakeCategory>> QYBUOXWWHUT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8096470", Offset = "0x8095270", VA = "0x188096470")]
			internal bool QXWNRRCYYJK(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class BGIRMPGVIGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public KeepsakeRoomInstanceIdsDTO LLEBWBVMVZX;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BGIRMPGVIGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x85DCE30", Offset = "0x85DBC30", VA = "0x1885DCE30")]
			internal YLZUVDOLRNC<Dictionary<Guid, KeepsakeCategory>> QXRGUKJBOYB(KeepsakeRoomInstancesDTO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BGNYJWASRRU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public KeepsakeRoomInstancesDTO HHQXQKKAOVD;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BGNYJWASRRU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x85DD120", Offset = "0x85DBF20", VA = "0x1885DD120")]
			internal bool QXLZXDPEFMS(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x85DCFD0", Offset = "0x85DBDD0", VA = "0x1885DCFD0")]
			internal KeyValuePair<Guid, KeepsakeCategory> QXGSZWVGWBJ(Guid a)
			{
				return default(KeyValuePair<Guid, KeepsakeCategory>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BGTFHCUQBDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Guid YKKASJTZFKZ;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BGTFHCUQBDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x102F6E0", Offset = "0x102E4E0", VA = "0x18102F6E0")]
			internal bool QXBMCQBJMQA(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BFIJAHLINBS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public Guid YKKASJTZFKZ;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BFIJAHLINBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x102F6E0", Offset = "0x102E4E0", VA = "0x18102F6E0")]
			internal bool QWWFFJHMDER(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FZPGVNEMETT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public Predicate<KeepsakeRoomInstanceIdsDTO> CBFUUFAHZAN;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public FZPGVNEMETT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x85EBAB0", Offset = "0x85EA8B0", VA = "0x1885EBAB0")]
			internal YLZUVDOLRNC<Dictionary<Guid, KeepsakeCategory>> FDLHWLCPKVC(Dictionary<Guid, KeepsakeCategory> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x85EBCA0", Offset = "0x85EAAA0", VA = "0x1885EBCA0")]
			internal bool FDQOTRWMUGL(KeepsakeRoomInstanceIdsDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FZJZYGKOVIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public KeepsakeRoomInstanceIdsDTO DFUEFVAHTBD;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public FZJZYGKOVIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x85EBA30", Offset = "0x85EA830", VA = "0x1885EBA30")]
			internal bool FDVVQYQKDRU(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class QJBCIAGAYHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Dictionary<Guid, KeepsakeCategory> ZIDJYUWIRRN;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QJBCIAGAYHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x85EC540", Offset = "0x85EB340", VA = "0x1885EC540")]
			internal KeyValuePair<KeepsakeCategory, int> VLCFITICSUF(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class QJGJFGZYHSL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public KeepsakeCategory JFSYNELQYIL;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QJGJFGZYHSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xFB16B0", Offset = "0xFB04B0", VA = "0x180FB16B0")]
			internal bool VKMKQZAKQME(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CIKEKRFAGCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Dictionary<Guid, KeepsakeCategory> ZIDJYUWIRRN;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CIKEKRFAGCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x85DD200", Offset = "0x85DC000", VA = "0x1885DD200")]
			internal KeyValuePair<KeepsakeCategory, int> APUMFXSMTVD(KeepsakeCategory a)
			{
				return default(KeyValuePair<KeepsakeCategory, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CIPLHXYXPNV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public KeepsakeCategory JFSYNELQYIL;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CIPLHXYXPNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xFB16B0", Offset = "0xFB04B0", VA = "0x180FB16B0")]
			internal bool APERODKURNC(KeepsakeCategory a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class CORMONIFQKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public Func<KeepsakeRoomDTO, bool> CAVGZRMNGDV;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CORMONIFQKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x85DD350", Offset = "0x85DC150", VA = "0x1885DD350")]
			internal bool DACCDUHEUIV(DateTime a, DateTime b, int c, TimeSpan d, TimeSpan e, int f)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x85DD460", Offset = "0x85DC260", VA = "0x1885DD460")]
			internal bool WEFFXHGISOS(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x85DD440", Offset = "0x85DC240", VA = "0x1885DD440")]
			internal bool WDUSCTSNZSA(KeepsakeRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x85DD440", Offset = "0x85DC240", VA = "0x1885DD440")]
			internal bool WDZZAAMLJDJ(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class TCUHXWABAPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public long CUOXYWGCTKI;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public TCUHXWABAPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x133C330", Offset = "0x133B130", VA = "0x18133C330")]
			internal bool LTANOSMQAQM(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class LYLWRPSHUAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Func<KeepsakeRoomDTO, bool> CBFUUFAHZAN;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LYLWRPSHUAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x85EC000", Offset = "0x85EAE00", VA = "0x1885EC000")]
			internal bool QWNILBEYWEY(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x284FB70", Offset = "0x284E970", VA = "0x18284FB70")]
			internal bool QWSPIHYWFQH(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HLMNBTNNEBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public long CUOXYWGCTKI;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public HLMNBTNNEBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x85EBCC0", Offset = "0x85EAAC0", VA = "0x1885EBCC0")]
			internal bool ZRKGYIAMJBR(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class USMCTDMSEPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public long CUOXYWGCTKI;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public USMCTDMSEPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x133C330", Offset = "0x133B130", VA = "0x18133C330")]
			internal bool FTXUULZKNDS(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class ZFLMIZRMUOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Guid JZINTTZMHJS;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZFLMIZRMUOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x85ED2B0", Offset = "0x85EC0B0", VA = "0x1885ED2B0")]
			internal bool REWIVNYTJPH(KeyValuePair<Guid, KeepsakeInstanceDTO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WLNRQXABRBS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public KeepsakeCategory KVEIFRCRQFQ;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WLNRQXABRBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x2439800", Offset = "0x2438600", VA = "0x182439800")]
			internal bool QUFAWZLZOCE(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class JKFFRUXCMJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public Guid JZINTTZMHJS;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JKFFRUXCMJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x85EBD60", Offset = "0x85EAB60", VA = "0x1885EBD60")]
			internal bool ADWFCSPFNLN(KeyValuePair<Guid, KeepsakeInstanceDTO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class JGQWYGZUYZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public KeepsakeCategory KVEIFRCRQFQ;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JGQWYGZUYZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x85EBD20", Offset = "0x85EAB20", VA = "0x1885EBD20")]
			internal bool EQINWAEIEYK(KeyValuePair<Guid, KeepsakeCategory> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class EMDUMWGEWBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public KeepsakeCategory OJOKIJWHLPQ;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EMDUMWGEWBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x2439800", Offset = "0x2438600", VA = "0x182439800")]
			internal bool TMHZZXENUTI(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class AHVXAHVRCCX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public long QVBVNJOSBOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public long? EKJVFTOSTDS;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public AHVXAHVRCCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x85DC3B0", Offset = "0x85DB1B0", VA = "0x1885DC3B0")]
			internal bool FBDRKMSIZST(KeepsakeInstanceDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class QFIEMFLIJSV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public IReadOnlyList<KeepsakeRoomListDTO> CYPRCTCOJWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public long CUOXYWGCTKI;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFIEMFLIJSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x85EC450", Offset = "0x85EB250", VA = "0x1885EC450")]
			internal bool UPKMQJEESHW(KeepsakeRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class QFCXOYRLAHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KeepsakeRoomDTO BNFDZMZDXRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public QFIEMFLIJSV YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFCXOYRLAHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x85EC3D0", Offset = "0x85EB1D0", VA = "0x1885EC3D0")]
			internal bool UQAHIDLWUPX(KeepsakeRoomListDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class EDGPHYUNMXX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public KeepsakeCategory KVEIFRCRQFQ;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EDGPHYUNMXX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x85EB460", Offset = "0x85EA260", VA = "0x1885EB460")]
			internal YLZUVDOLRNC<Guid> ISHMMFHFGJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x85EB5A0", Offset = "0x85EA3A0", VA = "0x1885EB5A0")]
			internal void XDURKHQYBSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB400", Offset = "0x85EA200", VA = "0x1885EB400")]
			internal void AIRIZGVBWNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x85EB600", Offset = "0x85EA400", VA = "0x1885EB600")]
			internal void XFAGTWGIGIF(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x85EB5D0", Offset = "0x85EA3D0", VA = "0x1885EB5D0")]
			internal void XEUZWPMKWWW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class CQVAZPKEZNR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public DXQPVNGWSMJ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public string HWJZMLSQQKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int ZGZEMFDSPQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int VUEBDRUOZLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public Guid JZINTTZMHJS;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CQVAZPKEZNR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x85DD580", Offset = "0x85DC380", VA = "0x1885DD580")]
			internal void HUYPCEUVSRM(KeepsakeCollectInstanceResponse a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x85DD520", Offset = "0x85DC320", VA = "0x1885DD520")]
			internal void FADBBZOMQFO(string a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <OnRunMigrations>d__184 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public DXQPVNGWSMJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public UREAGQBAIUQ args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x85EC690", Offset = "0x85EB490", VA = "0x1885EC690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x85ECBA0", Offset = "0x85EB9A0", VA = "0x1885ECBA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct <PeriodicLog>d__186 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public TimeSpan delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public DXQPVNGWSMJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x85ECC00", Offset = "0x85EBA00", VA = "0x1885ECC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x85ECEA0", Offset = "0x85EBCA0", VA = "0x1885ECEA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DateTime MCCNXBOEEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly JDUVREPDSHC OAFXGUPYJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly QMLVLOAMUTR HYKWCUDEQIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DZDFRWDRKJB AEMTSYAGAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DUNZSOMMSPV LEIFYIHMPDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly UDXPTWWACGU SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly NREGPJIAXTX GTKFDHCKNRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly LXJOBNOPNUL DHXKHYZFTMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CLXLYXLFVQR JLZGKAESYEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HDSFAKWKCKH FCSNFFINCEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly RRAAAEBKPOL APLBCYSCFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly SHDIMMQKFWM MVVUKKZMXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly YWRRCWZAAWC SQEVKQFPWBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly TORNMDALKHI UFAERHOJUGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly WCGLDDRMHKN VULCJDUERTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly PQWFPEVDNMD<KeepsakesConfig.KeepsakesOptions> SNLHOFQDXBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly YEADHGPVUSS FOXDZJJKEZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Dictionary<Guid, KeepsakeInstanceDTO> MVJYCPIRXQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HashSet<Guid> DQXDOBKICKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<long> VZDJMILQILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<KeepsakeCategory, int> BLVESNBCRDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly HashSet<Guid> GSQRPKYNCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IDisposable OLSQMTBVMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Task SJXBIEFQMFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private YLZUVDOLRNC<Guid> LSORUIOQZPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long? JBSSXMMLREU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private KeepsakeProgressionEventInstancesDTO WOZQYTEADXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private YLZUVDOLRNC<KeepsakeProgressionEventInstancesDTO> UWOMBBIZQPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO> KAPXAZKPQWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KeepsakeGlobalConfigDTO IDOTWUVNEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HashSet<long> FWPXHGOBNRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HashSet<long> QNOZQEAHPRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private List<KeepsakeRoomListDTO> ILTKCJAVQLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<KeepsakeRoomListDTO> EECWEYYINYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private List<KeepsakeRoomListDTO> AQIHWKMHRTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<long, string> BHBJDHHKMCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Dictionary<long, string> BFQUSTZJFYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<long, DateTime> XHCTRUHNQKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Dictionary<long, List<KeepsakeRoomDTO>> KPRNCPEUZPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Dictionary<long, List<KeepsakeRoomDTO>> IUYRTTUYPPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private Dictionary<long, long> VSVHGNDLWHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<string> BTZKMYZXGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private DateTime QDBQXMYXHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly IDisposable SKBWOXWIRAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Dictionary<Guid, KeepsakeCategory> BCOGHWGDRVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Dictionary<KeepsakeCategory, int> CXTLRKALGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<KeepsakeCategoryThemePair> EYOUUPDIHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private MOAIPVLRDSR SFRDKFHGYMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool HYOQWRBZZJJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BNIZCLTVMPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC12EC0", Offset = "0xC11CC0", VA = "0x180C12EC0", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC56AC0", Offset = "0xC558C0", VA = "0x180C56AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HGHURNIKDUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85DEAB0", Offset = "0x85DD8B0", VA = "0x1885DEAB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SWYZFZUEOLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85DE9F0", Offset = "0x85DD7F0", VA = "0x1885DE9F0", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private long CUDQBKMVXNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85E6110", Offset = "0x85E4F10", VA = "0x1885E6110")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private long? GEUPRBPIHTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x85E8210", Offset = "0x85E7010", VA = "0x1885E8210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool BGJMKXKPLIR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x85E6C30", Offset = "0x85E5A30", VA = "0x1885E6C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<KeepsakeRoomListDTO> YWWCIAGCCEN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC3D480", Offset = "0xC3C280", VA = "0x180C3D480", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<KeepsakeRoomListDTO> HFKVVSXFWIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xC3D470", Offset = "0xC3C270", VA = "0x180C3D470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<KeepsakeRoomListDTO> LSIBEZEAEBN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xC3CF20", Offset = "0xC3BD20", VA = "0x180C3CF20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<long, string> AGVNYVGQJLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xC3C160", Offset = "0xC3AF60", VA = "0x180C3C160", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal bool NPYDOAOZSNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xB91440", Offset = "0xB90240", VA = "0x180B91440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid?> UTQHTBGKEII
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85E1C00", Offset = "0x85E0A00", VA = "0x1885E1C00", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x85E1CB0", Offset = "0x85E0AB0", VA = "0x1885E1CB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action RMVPLCCPZJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85DEB00", Offset = "0x85DD900", VA = "0x1885DEB00", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85E4770", Offset = "0x85E3570", VA = "0x1885E4770", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action SWBCGSLMNXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85E4FE0", Offset = "0x85E3DE0", VA = "0x1885E4FE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x85E87E0", Offset = "0x85E75E0", VA = "0x1885E87E0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85E9FE0", Offset = "0x85E8DE0", VA = "0x1885E9FE0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal DXQPVNGWSMJ([Inject(null)][NotNull] JDUVREPDSHC notificationManager, [Inject(null)][NotNull] QEJIRNPZZVI roomLoader, [Inject(null)][NotNull] QMLVLOAMUTR creationHelper, [Inject(null)][NotNull] DZDFRWDRKJB roomPersistenceManager, [Inject(null)][NotNull] DUNZSOMMSPV progressionEventsManager, [Inject(null)][NotNull] UDXPTWWACGU roomManager, [Inject(null)][NotNull] NREGPJIAXTX storefrontManager, [Inject(null)][NotNull] LXJOBNOPNUL roomSaveValidation, [Inject(null)][NotNull] VJRNQPLOUBG networking, [Inject(null)][NotNull] CICYNVXEOJB scheduledUpdateService, [Inject(null)][NotNull] CLXLYXLFVQR recNetMatchmaking, [Inject(null)][NotNull] HDSFAKWKCKH recNetKeepsakes, [Inject(null)][NotNull] RRAAAEBKPOL recNetAccounts, [Inject(null)][NotNull] SHDIMMQKFWM recNetStorefronts, [Inject(null)][NotNull] YWRRCWZAAWC recNetGifts, [Inject(null)][NotNull] TORNMDALKHI timeService, [Inject(null)][NotNull] WCGLDDRMHKN debugLogger, [Inject(null)][NotNull] PQWFPEVDNMD<KeepsakesConfig.KeepsakesOptions> options, [Inject(null)][NotNull] YEADHGPVUSS gameConfigsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85E7F80", Offset = "0x85E6D80", VA = "0x1885E7F80", Slot = "15")]
		public bool TJZMWZFLNSE(List<string> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85E5B30", Offset = "0x85E4930", VA = "0x1885E5B30", Slot = "16")]
		public YLZUVDOLRNC<Guid> PLXXXRGOEVT(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85E9530", Offset = "0x85E8330", VA = "0x1885E9530", Slot = "17")]
		public WGVXBSAEBCD YLLELVDKQVU(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85E9C70", Offset = "0x85E8A70", VA = "0x1885E9C70", Slot = "18")]
		public WGVXBSAEBCD ZZBJGVEHCAR(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85E4E10", Offset = "0x85E3C10", VA = "0x1885E4E10", Slot = "19")]
		public bool NMCASXOFCLN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85DF9B0", Offset = "0x85DE7B0", VA = "0x1885DF9B0", Slot = "20")]
		public bool DOVVBPUGDPT(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85E7A00", Offset = "0x85E6800", VA = "0x1885E7A00")]
		public KeepsakeTheme SWNELLTBMDP(Guid a)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85DEDA0", Offset = "0x85DDBA0", VA = "0x1885DEDA0")]
		public bool CMRHIBKFYGN(KeepsakeCategory a, [Out] KeepsakeTheme b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85E0F40", Offset = "0x85DFD40", VA = "0x1885E0F40")]
		public List<KeepsakeTheme> FGQHEOWXGZD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85DFC70", Offset = "0x85DEA70", VA = "0x1885DFC70")]
		public int DSIFLBLLROS(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9B10", Offset = "0x85E8910", VA = "0x1885E9B10")]
		public KeepsakeCategory ZYZCGCGXIRG(Guid a)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9920", Offset = "0x85E8720", VA = "0x1885E9920", Slot = "34")]
		public List<KeepsakeCategory> ZEPCIPWGJSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85E73F0", Offset = "0x85E61F0", VA = "0x1885E73F0", Slot = "35")]
		public IComparer<KeepsakeCategory> SJYUMLDIZJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85E22C0", Offset = "0x85E10C0", VA = "0x1885E22C0", Slot = "32")]
		public string IGLVJKPFEPK(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85E1300", Offset = "0x85E0100", VA = "0x1885E1300", Slot = "33")]
		public string FPSJBZHCJBA(KeepsakeCategory a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85E6FC0", Offset = "0x85E5DC0", VA = "0x1885E6FC0", Slot = "21")]
		public bool SEGUBGHKKJB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85E5AC0", Offset = "0x85E48C0", VA = "0x1885E5AC0", Slot = "22")]
		public void PLKCSMMBZNV(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85E4F90", Offset = "0x85E3D90", VA = "0x1885E4F90", Slot = "23")]
		public void NPAKWDBEASP(KeepsakeCategory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85E9300", Offset = "0x85E8100", VA = "0x1885E9300", Slot = "24")]
		public void YCJNEZHISDF(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85E1540", Offset = "0x85E0340", VA = "0x1885E1540", Slot = "25")]
		public int GIYAJLKODAJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85E09B0", Offset = "0x85DF7B0", VA = "0x1885E09B0", Slot = "31")]
		public YLZUVDOLRNC<IEnumerable<Guid>> ERSEBGMUFTK(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85E6E30", Offset = "0x85E5C30", VA = "0x1885E6E30", Slot = "30")]
		public YLZUVDOLRNC<IEnumerable<Guid>> SCCJZPXVSKN(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85E2610", Offset = "0x85E1410", VA = "0x1885E2610", Slot = "54")]
		public YLZUVDOLRNC<Dictionary<Guid, KeepsakeCategory>> IYMGVGOMJVV(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85E97A0", Offset = "0x85E85A0", VA = "0x1885E97A0", Slot = "55")]
		public YLZUVDOLRNC<Dictionary<Guid, KeepsakeCategory>> ZBWJILIQCPG(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85DF9E0", Offset = "0x85DE7E0", VA = "0x1885DF9E0", Slot = "26")]
		public YLZUVDOLRNC<int> DSBQOEVJIIZ(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85E1950", Offset = "0x85E0750", VA = "0x1885E1950", Slot = "27")]
		public YLZUVDOLRNC<int> GLBZIFRYSEJ(long a, long b, KeepsakeCategory? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85E8E80", Offset = "0x85E7C80", VA = "0x1885E8E80", Slot = "28")]
		public YLZUVDOLRNC<Dictionary<KeepsakeCategory, int>> XYEEFMGZLVU(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85E4420", Offset = "0x85E3220", VA = "0x1885E4420", Slot = "29")]
		public YLZUVDOLRNC<Dictionary<KeepsakeCategory, int>> MDFFSALSCKW(long a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85E8880", Offset = "0x85E7680", VA = "0x1885E8880", Slot = "37")]
		public bool VHHUCGWEMGC(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85E5A60", Offset = "0x85E4860", VA = "0x1885E5A60", Slot = "56")]
		public bool PLIRVWMABIY(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85E14A0", Offset = "0x85E02A0", VA = "0x1885E14A0", Slot = "38")]
		public bool FWCFUUTJCTH(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85E7660", Offset = "0x85E6460", VA = "0x1885E7660", Slot = "57")]
		public bool SRSUBCUXJBN(long a, [Out] KeepsakeRoomLockStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85DFDF0", Offset = "0x85DEBF0", VA = "0x1885DFDF0", Slot = "39")]
		public bool DTJCTKVAEDI(long a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85E8940", Offset = "0x85E7740", VA = "0x1885E8940", Slot = "40")]
		public long VLICDTUISNW(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85DE780", Offset = "0x85DD580", VA = "0x1885DE780", Slot = "41")]
		public long BNMKHHNHVHS(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85E7490", Offset = "0x85E6290", VA = "0x1885E7490", Slot = "42")]
		public int SOZNTYEHSWJ(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85E1B20", Offset = "0x85E0920", VA = "0x1885E1B20", Slot = "43")]
		public bool GZQCAFLAHFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85DD920", Offset = "0x85DC720", VA = "0x1885DD920", Slot = "44")]
		public bool AGNJWKPKKDK(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85E9090", Offset = "0x85E7E90", VA = "0x1885E9090", Slot = "45")]
		public IReadOnlyList<long> XYIYRJXZNST(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85E3230", Offset = "0x85E2030", VA = "0x1885E3230", Slot = "46")]
		public int KWKZUNMFPHM(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85DF480", Offset = "0x85DE280", VA = "0x1885DF480", Slot = "50")]
		public long CTVTYTBLPQT(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85E2EE0", Offset = "0x85E1CE0", VA = "0x1885E2EE0", Slot = "51")]
		public KeepsakeCategory KUYODBMTFVB()
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85E4AE0", Offset = "0x85E38E0", VA = "0x1885E4AE0")]
		private bool NDROYAQVTFF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85E6770", Offset = "0x85E5570", VA = "0x1885E6770")]
		private void RMRGVHXNESN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85E4810", Offset = "0x85E3610", VA = "0x1885E4810")]
		private KeepsakeCategory MUTHTRBALYP()
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85E0370", Offset = "0x85DF170", VA = "0x1885E0370")]
		private void EILJFQEZEDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85E7250", Offset = "0x85E6050", VA = "0x1885E7250")]
		private int SIXSJDTWHNO(KeepsakeRoomListDTO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85DF380", Offset = "0x85DE180", VA = "0x1885DF380")]
		private int CSLZRUMGGVZ(DateTime a, DateTime b, TimeSpan c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85E44E0", Offset = "0x85E32E0", VA = "0x1885E44E0")]
		private void MGXNODXWYBY(IEnumerable<KeepsakeInstanceDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85E82A0", Offset = "0x85E70A0", VA = "0x1885E82A0")]
		private void TZOLRQTAEAE(IEnumerable<KeepsakeCollectionRecordDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85E3530", Offset = "0x85E2330", VA = "0x1885E3530")]
		private void LRBOKKFEYQR(IEnumerable<long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC79990", Offset = "0xC78790", VA = "0x180C79990")]
		private void NLPHGNGUPGH(KeepsakeGlobalConfigDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85E8590", Offset = "0x85E7390", VA = "0x1885E8590")]
		private bool VBGLFMDDRMU(KeepsakeCategory a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85E33B0", Offset = "0x85E21B0", VA = "0x1885E33B0")]
		private bool LEPRNWTBLWQ([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85DDAA0", Offset = "0x85DC8A0", VA = "0x1885DDAA0")]
		private bool AOYDZKFBZFL(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85E7C30", Offset = "0x85E6A30", VA = "0x1885E7C30")]
		private IEnumerable<Guid> TINAQWYGPHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x85E9A50", Offset = "0x85E8850", VA = "0x1885E9A50")]
		private IEnumerable<KeepsakeInstanceDTO> ZTGQLWKICUE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85E29D0", Offset = "0x85E17D0", VA = "0x1885E29D0")]
		private void JDGPHTCEUZB(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x85E84E0", Offset = "0x85E72E0", VA = "0x1885E84E0")]
		private bool UTHZRTHYLJD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x85DEC10", Offset = "0x85DDA10", VA = "0x1885DEC10")]
		private void CDSVWRKDNRL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85E51B0", Offset = "0x85E3FB0", VA = "0x1885E51B0")]
		private void OSDXAIJDFCK(KeepsakeCategory a, int b, Dictionary<KeepsakeCategory, int> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85E7B40", Offset = "0x85E6940", VA = "0x1885E7B40")]
		private int TAAIXYWMSBE(KeepsakeCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85E2B60", Offset = "0x85E1960", VA = "0x1885E2B60")]
		private void JNCNNHHVIIP(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85E7D70", Offset = "0x85E6B70", VA = "0x1885E7D70")]
		private void TJBQILDREZP(KeepsakeInstanceDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85DE3C0", Offset = "0x85DD1C0", VA = "0x1885DE3C0")]
		private void BIRWMQLLZLE(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85E0340", Offset = "0x85DF140", VA = "0x1885E0340")]
		private void VVAWUWYKUNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85E2EC0", Offset = "0x85E1CC0", VA = "0x1885E2EC0")]
		private void JVGQKAISBYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85DEBA0", Offset = "0x85DD9A0", VA = "0x1885DEBA0")]
		private void CDIPDJXSAZG(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85E0340", Offset = "0x85DF140", VA = "0x1885E0340")]
		private void MVAFLZBMOJB(GiftPackageReceivedArgs a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x85E0340", Offset = "0x85DF140", VA = "0x1885E0340")]
		private void EHRZPRGRNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85E1F20", Offset = "0x85E0D20", VA = "0x1885E1F20")]
		private void HYRVMEXXAMN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85E61E0", Offset = "0x85E4FE0", VA = "0x1885E61E0")]
		private void REDTKEPTIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85E4C10", Offset = "0x85E3A10", VA = "0x1885E4C10")]
		private bool NEOKEORCRUY(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85E0D70", Offset = "0x85DFB70", VA = "0x1885E0D70")]
		private bool FGCPRZEGAYH(Guid a, [Out] KeepsakeCategoryConfigDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85E3450", Offset = "0x85E2250", VA = "0x1885E3450")]
		private void LMRXRELSZOR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85DDC30", Offset = "0x85DCA30", VA = "0x1885DDC30")]
		private bool ASWKDBGRPOY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85E57B0", Offset = "0x85E45B0", VA = "0x1885E57B0")]
		private List<long> PLFSIFZFGVC(IEnumerable<KeepsakeRoomDTO> a, IReadOnlyList<KeepsakeRoomListDTO> b, long c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85DDE50", Offset = "0x85DCC50", VA = "0x1885DDE50")]
		private bool AUTIVXOKOXC(Guid a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85E88E0", Offset = "0x85E76E0", VA = "0x1885E88E0", Slot = "47")]
		public string VJBZYLVYPVR(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85DEF80", Offset = "0x85DDD80", VA = "0x1885DEF80", Slot = "49")]
		public string CPBOVFWNUFC(ProgressionEventConfigurableTextType a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85E32E0", Offset = "0x85E20E0", VA = "0x1885E32E0", Slot = "48")]
		public string KYAEWXSAFDF(ProgressionEventConfigurableTextType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85E3590", Offset = "0x85E2390", VA = "0x1885E3590")]
		private void LRGAZFLNUKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85E2D30", Offset = "0x85E1B30", VA = "0x1885E2D30")]
		private void JSXTWEESQNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85E5790", Offset = "0x85E4590", VA = "0x1885E5790")]
		private ProgressionEventConfigurableTextType PFPKXZVMRDT(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85E1480", Offset = "0x85E0280", VA = "0x1885E1480")]
		private ProgressionEventConfigurableTextType FRMEXMBXACF(KeepsakeRoomType a)
		{
			return default(ProgressionEventConfigurableTextType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85E2440", Offset = "0x85E1240", VA = "0x1885E2440")]
		internal static string IXZQBKWYWRJ(KeepsakeCollectInstanceResponse a, string b, bool c, int d, int e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85DFF30", Offset = "0x85DED30", VA = "0x1885DFF30", Slot = "52")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85E1AA0", Offset = "0x85E08A0", VA = "0x1885E1AA0")]
		private MMSSFGQGRLF GYSRTXVAODT(XGOJTPBZDNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85DF800", Offset = "0x85DE600", VA = "0x1885DF800")]
		private LZHTVDPEIKI CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85E53F0", Offset = "0x85E41F0", VA = "0x1885E53F0")]
		private Task OnRoomLoadStarted(UREAGQBAIUQ args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85DDD40", Offset = "0x85DCB40", VA = "0x1885DDD40")]
		[AsyncStateMachine(typeof(<OnRunMigrations>d__184))]
		private Task ATUNDOPYRZU(UREAGQBAIUQ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85DF730", Offset = "0x85DE530", VA = "0x1885DF730")]
		private Task CWYHXPTYXAV(UREAGQBAIUQ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85E5080", Offset = "0x85E3E80", VA = "0x1885E5080")]
		[AsyncStateMachine(typeof(<PeriodicLog>d__186))]
		private Task OKFXNBDZFIU(string a, TimeSpan b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85DE350", Offset = "0x85DD150", VA = "0x1885DE350")]
		[CompilerGenerated]
		private void BDBDUBJKQHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85DE370", Offset = "0x85DD170", VA = "0x1885DE370")]
		[CompilerGenerated]
		private void BDGKRIDHZTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85E2A60", Offset = "0x85E1860", VA = "0x1885E2A60")]
		[CompilerGenerated]
		private bool JMRHPGNHHHQ(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85E5290", Offset = "0x85E4090", VA = "0x1885E5290")]
		[CompilerGenerated]
		private YLZUVDOLRNC<Dictionary<KeepsakeCategory, int>> OXBYHQKMAWU(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85DE890", Offset = "0x85DD690", VA = "0x1885DE890")]
		[CompilerGenerated]
		private YLZUVDOLRNC<Dictionary<KeepsakeCategory, int>> BQHRNFDRVII(Dictionary<Guid, KeepsakeCategory> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85E4F70", Offset = "0x85E3D70", VA = "0x1885E4F70")]
		[CompilerGenerated]
		private bool NNWGAEBUGUH(KeepsakeRoomListDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB00", Offset = "0x85DC900", VA = "0x1885DDB00")]
		[CompilerGenerated]
		private bool APXBMSRVZXH(KeepsakeInstanceDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85E6CA0", Offset = "0x85E5AA0", VA = "0x1885E6CA0")]
		[CompilerGenerated]
		private void RRHGSUXTZAL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KeepsakeCategory, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85E6C40", Offset = "0x85E5A40", VA = "0x1885E6C40")]
		[CompilerGenerated]
		private void RRBZVODWPPC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85E1D60", Offset = "0x85E0B60", VA = "0x1885E1D60")]
		[CompilerGenerated]
		private Task HXCRPMEIAJY(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KeepsakesConfig : ScriptableObject, PQWFPEVDNMD<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class URZEQUFXAGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public string PFJBIFCNAOR;

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public URZEQUFXAGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x85ED110", Offset = "0x85EBF10", VA = "0x1885ED110")]
				internal bool HWNCGPQDUYS(KeepsakeTheme a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x85ED110", Offset = "0x85EBF10", VA = "0x1885ED110")]
				internal bool HWSJDWKBEKB(KeepsakeTheme a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x85EBE40", Offset = "0x85EAC40", VA = "0x1885EBE40")]
			public bool UMJLNQLZYVU(string a, [Out] KeepsakeTheme b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85EBDC0", Offset = "0x85EABC0", VA = "0x1885EBDC0")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void NHOBNFBSGEC(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public KeepsakesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AssetReference PickupPrefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
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
