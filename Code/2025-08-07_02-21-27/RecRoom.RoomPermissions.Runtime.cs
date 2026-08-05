using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logger;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using RecRoom.Utils.PrefParsers;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

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
		[Cpp2IlInjected.Address(RVA = "0x92E3A20", Offset = "0x92E2620", VA = "0x1892E3A20")]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum VotekickType
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x92EFB00", Offset = "0x92EE700", VA = "0x1892EFB00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Systems.PlayerRoles
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void OnRolePermissionUpdated<TPermission>(TPermission rolePermission);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void OnRoomRoleUpdated(WJBKOLNRRJE player);
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DEPRECATED_HostPermission
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Hosts,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Everyone
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface XDLAUONTOWQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool TVSDDUUYGCV
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool TPSYYISRWYB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool SZVYQLPSUGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool FSQEZAPAUWI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool BTABDBWEWEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool JHZQJKGGMQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IDKIAJXDUVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class ZHDFOLHHMSD
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[Flags]
		public enum DEPRECATED_RoomRoleId
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			AG_EVERYONE = 0,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			AG_CREATOR = 0x200000,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			AG_COOWNER = 0x400000,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			AG_HOST = 0x800000,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			AG_MODERATOR = 0x1000000
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Guid KZBYNEBQVIV;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid OUEZIAUOVCG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid GDEMHIAFCZX;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid URLECMOTBQV;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid HELEXLBIAQQ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid OETZDSCUKPF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly BMYHHKKSVYW<AccountRoleType, Guid> SNMJCDYOUOW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> ERSQXRUESIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x92EEE50", Offset = "0x92EDA50", VA = "0x1892EEE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x92EEED0", Offset = "0x92EDAD0", VA = "0x1892EEED0")]
		public static AccountRoleType QQHJLZDLOIM(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x92EED70", Offset = "0x92ED970", VA = "0x1892EED70")]
		public static Guid JYFSXAJGKEM(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x92EEB90", Offset = "0x92ED790", VA = "0x1892EEB90")]
		public static bool CAAAJIUHDXP(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x92EEC20", Offset = "0x92ED820", VA = "0x1892EEC20")]
		public static bool DWOBICWSQEB(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x92EEE10", Offset = "0x92EDA10", VA = "0x1892EEE10")]
		public static AccountRoleType MOPWMRMDMHU(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x92EECC0", Offset = "0x92ED8C0", VA = "0x1892EECC0")]
		public static DEPRECATED_RoomRoleId ENOHFPSVDEB(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x92EEF60", Offset = "0x92EDB60", VA = "0x1892EEF60")]
		internal static AccountRoleType XEMIUNUKGFG(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IIRLVOUAJIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		WJBKOLNRRJE PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance PWHHKTQLYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO NHSIIWPGQVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> EMPOWDMZGRH;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action JVPMYJOGGNB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType QJINNJPNOZX(WJBKOLNRRJE a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> DNXSGQTDWIM(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task ABEMRSJPVWK(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task RFJKHZDUVDQ(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<WJBKOLNRRJE> CHPJORBSGDJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class VTEJPBAGXHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x92E7E60", Offset = "0x92E6A60", VA = "0x1892E7E60")]
		public static AccountRoleType OAEVPFIANYW(this IIRLVOUAJIA a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface SPHRPFSJXOK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		UIRUQGSHHTD XXYZFNVOJLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated FXXXACHQWTZ;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<XSCHBZSIXIP> BDEHSKSMHDL(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XSCHBZSIXIP WONKCACPMIP(WJBKOLNRRJE a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KXZKTRRPWCU(WJBKOLNRRJE a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<XSCHBZSIXIP> APEQFQHJOSF(WJBKOLNRRJE a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool QGLSCYWAMVX(WJBKOLNRRJE a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		XSCHBZSIXIP KGJTXZMACTO(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AIEDDFHNIOQ<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string IKYIOGKJGRG(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool NAXDDGLRGQE(WJBKOLNRRJE a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface XDZTLURNHAX
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task BNUVKAEFVSS(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ZIWJOEOZGHT<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> LISPZLQHLCO;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? OHYSRLTHFKC;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? ABOVZDVQQLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x92E3BA0", Offset = "0x92E27A0", VA = "0x1892E3BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x92E3AA0", Offset = "0x92E26A0", VA = "0x1892E3AA0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x92E3C70", Offset = "0x92E2870", VA = "0x1892E3C70")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool LJCWDLWOKQY(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> ZAUCHTYZQMG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x61BA100", Offset = "0x61B8D00", VA = "0x1861BA100")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61B9330", Offset = "0x61B7F30", VA = "0x1861B9330", Slot = "4")]
		public override bool LJCWDLWOKQY(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61B9A90", Offset = "0x61B8690", VA = "0x1861B9A90")]
		public bool MCZOOFTAHJM(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61BA240", Offset = "0x61B8E40", VA = "0x1861BA240")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TXSWXIRWEYT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> PATUACWLKAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> OKMJMWMENGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ATYTEUQWDDK UORVQYHWYAU;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x92E6250", Offset = "0x92E4E50", VA = "0x1892E6250")]
		public TXSWXIRWEYT(ATYTEUQWDDK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x92E5D90", Offset = "0x92E4990", VA = "0x1892E5D90")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4039CE0", Offset = "0x40388E0", VA = "0x184039CE0")]
		public bool AUEWYMXBSYE<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x403A580", Offset = "0x4039180", VA = "0x18403A580")]
		public (bool, a?) YSACXGWPUBW<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x92E5CB0", Offset = "0x92E48B0", VA = "0x1892E5CB0")]
		public bool AUEWYMXBSYE(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x92E60C0", Offset = "0x92E4CC0", VA = "0x1892E60C0")]
		public (bool, object) YSACXGWPUBW(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x403A4A0", Offset = "0x40390A0", VA = "0x18403A4A0")]
		private void GICUWBUERLN<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x92E5E00", Offset = "0x92E4A00", VA = "0x1892E5E00")]
		private Permission PBYCWYCGKTX(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x92E5ED0", Offset = "0x92E4AD0", VA = "0x1892E5ED0")]
		public void YRAXJJZDEQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class JLEDPBYXFKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string AUAUPSXZBLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type JRYWIILYWHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType YHTQXIQSJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission UZZDNLMBRXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet ZOCWEETKXYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue TTAYXGWWHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission VKYOGBAPDBX;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x92E3560", Offset = "0x92E2160", VA = "0x1892E3560")]
		public JLEDPBYXFKW(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x92E3510", Offset = "0x92E2110", VA = "0x1892E3510")]
		public object MXCUPQJOOLQ(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C47A90", Offset = "0x3C46690", VA = "0x183C47A90")]
		public void GICUWBUERLN<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x92E3460", Offset = "0x92E2060", VA = "0x1892E3460")]
		public void GICUWBUERLN(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class WSRCRGFCDSZ<a> : JLEDPBYXFKW where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet XHEMAURSZLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue TGDMAQEVHFK;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x597F720", Offset = "0x597E320", VA = "0x18597F720")]
			internal string IXHFKDJBLMB(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x597F0E0", Offset = "0x597DCE0", VA = "0x18597F0E0")]
			internal object IXBYMWPECAS(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D76800", Offset = "0x6D75400", VA = "0x186D76800")]
		public WSRCRGFCDSZ(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D75DB0", Offset = "0x6D749B0", VA = "0x186D75DB0")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D765D0", Offset = "0x6D751D0", VA = "0x186D765D0")]
		private static string Serialize(SerializeValueForRecNet? serializeValueForRecNet, object? value)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal delegate string SerializeValueForRecNet(object? value);
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal delegate object DeserializeRecNetValue(string? serializedValue, [Optional] object defaultValue);
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal delegate Permission ConstructPermission();
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class ATYTEUQWDDK
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class NMLFDXCOSEK : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static NMLFDXCOSEK CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x92E3600", Offset = "0x92E2200", VA = "0x1892E3600", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x92E3750", Offset = "0x92E2350", VA = "0x1892E3750", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public NMLFDXCOSEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class AISJAEEIJMU : UMEZLOBANCV<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x92E0F40", Offset = "0x92DFB40", VA = "0x1892E0F40", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x92E0D90", Offset = "0x92DF990", VA = "0x1892E0D90", Slot = "10")]
			protected override bool IPMHCNWMEDG(string a, [Out] VotekickType b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x92E1030", Offset = "0x92DFC30", VA = "0x1892E1030")]
			public AISJAEEIJMU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly XYBEMVYMKFR MEYIYDBHJXV;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly AISJAEEIJMU JQPDOMSGSAY;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<JLEDPBYXFKW> OVAUKEADXNL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> ZJKBWVOGEWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, JLEDPBYXFKW> JWTCSCTGFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x92E2F50", Offset = "0x92E1B50", VA = "0x1892E2F50")]
		public ATYTEUQWDDK([Optional] IList<JLEDPBYXFKW>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x92E1070", Offset = "0x92DFC70", VA = "0x1892E1070")]
		public JLEDPBYXFKW IAYAQOBPUJX(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface UIRUQGSHHTD
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		XSCHBZSIXIP ARQRIKEJHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class WRELTHCGEXM : UIRUQGSHHTD
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static WRELTHCGEXM ZFUPZEYXVVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly SYBAJRQRYNQ VCUDRTXNFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<SYBAJRQRYNQ> NSDUYVKLGSZ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public XSCHBZSIXIP ARQRIKEJHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x92EEA60", Offset = "0x92ED660", VA = "0x1892EEA60")]
		public WRELTHCGEXM(SYBAJRQRYNQ a, IReadOnlyList<SYBAJRQRYNQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x92ED970", Offset = "0x92EC570", VA = "0x1892ED970")]
		private static WRELTHCGEXM QBUABVLXHYN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class QQDIRWQTXMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> NWITINAFTIY;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x92E3D70", Offset = "0x92E2970", VA = "0x1892E3D70")]
		public static bool LCVSRFYLLHM(this WJBKOLNRRJE a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x92E3E50", Offset = "0x92E2A50", VA = "0x1892E3E50")]
		public static bool MSEXUAVIBNB(this WJBKOLNRRJE a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface FCZIXWUQVXO
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> LRNAHLLVDNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType UQTRVCEJUBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface XSCHBZSIXIP : FCZIXWUQVXO, XDLAUONTOWQ, ZIWJOEOZGHT<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string QSVFCGRDCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType YAPINFWUDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) FIQNJNLBENM<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class SYBAJRQRYNQ : XSCHBZSIXIP, FCZIXWUQVXO, XDLAUONTOWQ, ZIWJOEOZGHT<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly ATYTEUQWDDK ATYTEUQWDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly TXSWXIRWEYT DOYXKLJWCYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? PGLRMVXQFYO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool FDMZJQQLLBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x92E4870", Offset = "0x92E3470", VA = "0x1892E4870", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool UIGQFPVYMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x92E4910", Offset = "0x92E3510", VA = "0x1892E4910", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool TXFKAPKNJWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x92E47D0", Offset = "0x92E33D0", VA = "0x1892E47D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool YJYBCJRGJKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x92E48C0", Offset = "0x92E34C0", VA = "0x1892E48C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool TPLEEBASQUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x92E4820", Offset = "0x92E3420", VA = "0x1892E4820", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool BDKGFOZQLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x92E42D0", Offset = "0x92E2ED0", VA = "0x1892E42D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool RIVWLYCXXEL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x92E4780", Offset = "0x92E3380", VA = "0x1892E4780", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType YAPINFWUDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB1A400", Offset = "0xB19000", VA = "0x180B1A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7A8FEA0", Offset = "0x7A8EAA0", VA = "0x187A8FEA0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string QSVFCGRDCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7A8FEA0", Offset = "0x7A8EAA0", VA = "0x187A8FEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool XPYDWBDLGUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType UQTRVCEJUBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x92E4FF0", Offset = "0x92E3BF0", VA = "0x1892E4FF0", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> LRNAHLLVDNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x92E5040", Offset = "0x92E3C40", VA = "0x1892E5040", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool YKJHMBFDSTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x92E4870", Offset = "0x92E3470", VA = "0x1892E4870", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool OKTVUVJYYFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x92E4820", Offset = "0x92E3420", VA = "0x1892E4820", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IRNWEBZMLQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x92E4910", Offset = "0x92E3510", VA = "0x1892E4910", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool VIUQZJDZSHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x92E47D0", Offset = "0x92E33D0", VA = "0x1892E47D0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool CINNVEOZGZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x92E48C0", Offset = "0x92E34C0", VA = "0x1892E48C0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool FHTOQRBJWVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x92E42D0", Offset = "0x92E2ED0", VA = "0x1892E42D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool MCBFVHFGRUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x92E4780", Offset = "0x92E3380", VA = "0x1892E4780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> LISPZLQHLCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x92E4F40", Offset = "0x92E3B40", VA = "0x1892E4F40", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x92E4320", Offset = "0x92E2F20", VA = "0x1892E4320", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7590", Offset = "0x3FF6190", VA = "0x183FF7590", Slot = "6")]
		public (bool, a?) FIQNJNLBENM<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7350", Offset = "0x3FF5F50", VA = "0x183FF7350")]
		public SYBAJRQRYNQ AQZINDVLPPI<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x92E5AF0", Offset = "0x92E46F0", VA = "0x1892E5AF0")]
		public SYBAJRQRYNQ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x92E5C40", Offset = "0x92E4840", VA = "0x1892E5C40")]
		public SYBAJRQRYNQ(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x92E5C60", Offset = "0x92E4860", VA = "0x1892E5C60")]
		public SYBAJRQRYNQ(SYBAJRQRYNQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x92E5B10", Offset = "0x92E4710", VA = "0x1892E5B10")]
		internal SYBAJRQRYNQ(AccountRoleType a, [Optional] string? b, [Optional] SYBAJRQRYNQ? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x92E4960", Offset = "0x92E3560", VA = "0x1892E4960")]
		public static RolePermissionType OYGOWPPHVOI(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x92E5A50", Offset = "0x92E4650", VA = "0x1892E5A50")]
		public void YRAXJJZDEQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x92E49E0", Offset = "0x92E35E0", VA = "0x1892E49E0")]
		internal SYBAJRQRYNQ PFRFNUDIPHE(SYBAJRQRYNQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x92E43D0", Offset = "0x92E2FD0", VA = "0x1892E43D0")]
		internal IReadOnlyCollection<RolePermission> Copy(SYBAJRQRYNQ roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x92E4D60", Offset = "0x92E3960", VA = "0x1892E4D60")]
		public bool QZAXNBEXVAP(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x92E4E40", Offset = "0x92E3A40", VA = "0x1892E4E40")]
		public (bool, string) RXIFMGZEQXY(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x92E5A00", Offset = "0x92E4600", VA = "0x1892E5A00")]
		internal void YLBXPUSIUIZ(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x92E4100", Offset = "0x92E2D00", VA = "0x1892E4100")]
		public KUYXXZGXLDN AQZYUCKCPXV(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x92E50A0", Offset = "0x92E3CA0", VA = "0x1892E50A0")]
		public void VRLNAQMFIFV(KUYXXZGXLDN a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x92E4CD0", Offset = "0x92E38D0", VA = "0x1892E4CD0")]
		[CompilerGenerated]
		private void QCAPJEZJQTL(RolePermission a, ODHWJFSBXTQ b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class WAQKFWXJJWL : XDZTLURNHAX, SPHRPFSJXOK, IDisposable, NTXDCQYHPAK
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class XOTIXDXNSGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public SYBAJRQRYNQ FFGPZLJQISJ;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XOTIXDXNSGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x92EEB60", Offset = "0x92ED760", VA = "0x1892EEB60")]
			internal bool SGVKDZYRDCL(SYBAJRQRYNQ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class RGBAJBLOFPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AccountRoleType AYCSHVMGJBT;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public RGBAJBLOFPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x226FC90", Offset = "0x226E890", VA = "0x18226FC90")]
			internal bool ERZHBELSSVF(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class FTNYYFHXZBU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public StringBuilder YRVLNPMBUTH;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public FTNYYFHXZBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x92E3280", Offset = "0x92E1E80", VA = "0x1892E3280")]
			internal void MDWPMHFUCIQ(KUYXXZGXLDN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x92E3360", Offset = "0x92E1F60", VA = "0x1892E3360")]
			internal void MEBWJNZRLTZ(KUYXXZGXLDN a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct <>c__DisplayClass37_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public PersistedRoomData roomData;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class SSHHUEBZJOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Func<KUYXXZGXLDN, ODHWJFSBXTQ> ZCHXXMVGTLN;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public SSHHUEBZJOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x92E40D0", Offset = "0x92E2CD0", VA = "0x1892E40D0")]
			internal void GXNNGDCRQVH(KUYXXZGXLDN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x92E4070", Offset = "0x92E2C70", VA = "0x1892E4070")]
			internal void GWXSOIUZONG(KUYXXZGXLDN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x92E40A0", Offset = "0x92E2CA0", VA = "0x1892E40A0")]
			internal void GXCZLPOWXYP(KUYXXZGXLDN a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class ZPXFJNLOSET<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000066")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public ZPXFJNLOSET<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x4295060", Offset = "0x4293C60", VA = "0x184295060", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public RolePermission OZOENUASYYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AccountRoleType CHOITMEFMCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public bool SUUWZQWILRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public RolePermissionType JIDTQPMXZZF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public string XRQADLKGDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public WAQKFWXJJWL VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action PXVUWAAKDTN;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public ZPXFJNLOSET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x44AEC70", Offset = "0x44AD870", VA = "0x1844AEC70")]
			[AsyncStateMachine(typeof(ZPXFJNLOSET<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void TWLECFJFVDV()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct <>c__DisplayClass50_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public IReadOnlyList<RolePermissionDTO> newPermissionOverrides;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <CoOwnerMigrateLegacyProtobufToRecNet>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public IIRLVOUAJIA rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public IReadOnlyDictionary<AccountRoleType, SYBAJRQRYNQ> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public EIFPFKWIQJB debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x92E64F0", Offset = "0x92E50F0", VA = "0x1892E64F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x92E6FF0", Offset = "0x92E5BF0", VA = "0x1892E6FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <LEGACY_DeserializeFrom>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public WAQKFWXJJWL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private bool <isOffline>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x92E7050", Offset = "0x92E5C50", VA = "0x1892E7050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x92E76C0", Offset = "0x92E62C0", VA = "0x1892E76C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly IIRLVOUAJIA FOVLYBFVSPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly WRELTHCGEXM UDGJXNDOPYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly EIFPFKWIQJB XDUOSNHXSKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, SYBAJRQRYNQ> YAZQHHJVDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		internal readonly Dictionary<AccountRoleType, SYBAJRQRYNQ> SZSOKEMIBVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal readonly Dictionary<AccountRoleType, SYBAJRQRYNQ> TEELZRPYZVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly List<SYBAJRQRYNQ> RUDFXAYBKUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool SVNMJTFDKWP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly RolePermission[] QQCPXIQZAXJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UIRUQGSHHTD XXYZFNVOJLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated FXXXACHQWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x92EAFD0", Offset = "0x92E9BD0", VA = "0x1892EAFD0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x92E8440", Offset = "0x92E7040", VA = "0x1892E8440", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x92E8A30", Offset = "0x92E7630", VA = "0x1892E8A30")]
		[IFIZWETSKCB.Room]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x92ED6F0", Offset = "0x92EC2F0", VA = "0x1892ED6F0")]
		[UnityEngine.Scripting.Preserve]
		internal WAQKFWXJJWL([Inject(null)] IIRLVOUAJIA roleDataProvider, [Inject(null)] WRELTHCGEXM roleManagerDefaults, [Inject(null)] EIFPFKWIQJB debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x92E8930", Offset = "0x92E7530", VA = "0x1892E8930", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x92EB070", Offset = "0x92E9C70", VA = "0x1892EB070")]
		private void RHNLEWTDOAN(IEnumerable<SYBAJRQRYNQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x92E8FC0", Offset = "0x92E7BC0", VA = "0x1892E8FC0", Slot = "10")]
		public bool KXZKTRRPWCU(WJBKOLNRRJE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x92E8D30", Offset = "0x92E7930", VA = "0x1892E8D30")]
		private void JVPMYJOGGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x92E8DE0", Offset = "0x92E79E0", VA = "0x1892E8DE0")]
		private void KNOHLYEFNPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x92E83C0", Offset = "0x92E6FC0", VA = "0x1892E83C0", Slot = "8")]
		public IReadOnlyList<XSCHBZSIXIP> BDEHSKSMHDL(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x92EC0E0", Offset = "0x92EACE0", VA = "0x1892EC0E0", Slot = "9")]
		public XSCHBZSIXIP WONKCACPMIP(WJBKOLNRRJE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x92E8C60", Offset = "0x92E7860", VA = "0x1892E8C60")]
		private AccountRoleType JNLZAEGYHEJ(WJBKOLNRRJE a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x92EA0C0", Offset = "0x92E8CC0", VA = "0x1892EA0C0", Slot = "12")]
		public bool QGLSCYWAMVX(WJBKOLNRRJE a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x92E8D40", Offset = "0x92E7940", VA = "0x1892E8D40", Slot = "13")]
		public XSCHBZSIXIP KGJTXZMACTO(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x92ED210", Offset = "0x92EBE10", VA = "0x1892ED210")]
		private static bool ZXNUKDMOVUN(WJIXUCQSEMS a, AccountRoleType b, [Out] KUYXXZGXLDN? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x92E9100", Offset = "0x92E7D00", VA = "0x1892E9100")]
		private static void MYMTNZIIZXL(WJIXUCQSEMS a, Action<KUYXXZGXLDN> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x92E91F0", Offset = "0x92E7DF0", VA = "0x1892E91F0")]
		private static void MYMTNZIIZXL(WJIXUCQSEMS a, Action<KUYXXZGXLDN> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x92E9090", Offset = "0x92E7C90", VA = "0x1892E9090")]
		private void LHVUSZJKJMM(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x92E84E0", Offset = "0x92E70E0", VA = "0x1892E84E0", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__34))]
		public Task BNUVKAEFVSS([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x92E8600", Offset = "0x92E7200", VA = "0x1892E8600")]
		private void BXPLURDIZUQ(WJIXUCQSEMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x92E9DA0", Offset = "0x92E89A0", VA = "0x1892E9DA0")]
		internal static string PFEOIRAIGHC(IIRLVOUAJIA a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, SYBAJRQRYNQ> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x92EA230", Offset = "0x92E8E30", VA = "0x1892EA230")]
		private static void QHEAYPFYVNU(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x92ECB60", Offset = "0x92EB760", VA = "0x1892ECB60")]
		private static void ZAJJDMEMRYZ(WJIXUCQSEMS a, IReadOnlyDictionary<AccountRoleType, SYBAJRQRYNQ> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x92EB8E0", Offset = "0x92EA4E0", VA = "0x1892EB8E0")]
		private static bool RZUTOBDVEIM(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x92EC430", Offset = "0x92EB030", VA = "0x1892EC430")]
		private static void YVZCOPKWUIR(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x41A21B0", Offset = "0x41A0DB0", VA = "0x1841A21B0", Slot = "14")]
		public bool AIEDDFHNIOQ<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x92E8BE0", Offset = "0x92E77E0", VA = "0x1892E8BE0", Slot = "15")]
		public string IKYIOGKJGRG(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x92E9480", Offset = "0x92E8080", VA = "0x1892E9480", Slot = "16")]
		public bool NAXDDGLRGQE(WJBKOLNRRJE a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x92E9570", Offset = "0x92E8170", VA = "0x1892E9570", Slot = "18")]
		public bool NAXDDGLRGQE(int a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x92E7EC0", Offset = "0x92E6AC0", VA = "0x1892E7EC0")]
		private void ACVZXLRRQBA(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x92EA0A0", Offset = "0x92E8CA0", VA = "0x1892EA0A0")]
		private bool PlayerHasRole(WJBKOLNRRJE player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x92EB9F0", Offset = "0x92EA5F0", VA = "0x1892EB9F0")]
		internal SYBAJRQRYNQ SHTFFWUZXCN(WJBKOLNRRJE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x92E83B0", Offset = "0x92E6FB0", VA = "0x1892E83B0", Slot = "11")]
		public IReadOnlyList<XSCHBZSIXIP> APEQFQHJOSF(WJBKOLNRRJE a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x92EC1F0", Offset = "0x92EADF0", VA = "0x1892EC1F0")]
		internal IReadOnlyList<SYBAJRQRYNQ> WYOMYZEQRXS(WJBKOLNRRJE a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x92E9620", Offset = "0x92E8220", VA = "0x1892E9620")]
		private void NLSYVQHBXSJ(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x92E80C0", Offset = "0x92E6CC0", VA = "0x1892E80C0")]
		private static bool ALGYFVUIGPR(SYBAJRQRYNQ a, IReadOnlyDictionary<AccountRoleType, SYBAJRQRYNQ> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x92EBD10", Offset = "0x92EA910", VA = "0x1892EBD10")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__52))]
		private static Task UJWRPHINRRV(IIRLVOUAJIA a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, SYBAJRQRYNQ> c, EIFPFKWIQJB d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x92EBE50", Offset = "0x92EAA50", VA = "0x1892EBE50")]
		[CompilerGenerated]
		internal static void VJGABMQNLLY(Func<KUYXXZGXLDN, ODHWJFSBXTQ> a, <>c__DisplayClass37_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x92ECEA0", Offset = "0x92EBAA0", VA = "0x1892ECEA0")]
		[CompilerGenerated]
		internal static bool ZQFCKNFKXGM(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass50_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface TEBDEWXLCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IMEOTDIGSPB(WJBKOLNRRJE a, WJBKOLNRRJE b, IEnumerable<WJBKOLNRRJE> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string VKMLBTDEBXO(VotekickFailReason a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public enum VotekickFailReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		InsufficientPermission,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		DisabledByRoom,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		CantKickEventOrganizer,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Broadcaster,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		GameInProgress,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		OpponentGameInProgress
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal class ZXZXMGLORSD : TEBDEWXLCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly SPHRPFSJXOK PUCJMQKWVAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly ZZTOCUXTQAF VEHCHMMMVLZ;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZXZXMGLORSD([Inject(null)] SPHRPFSJXOK roomRoleManager, [Inject(null)] ZZTOCUXTQAF gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x92EF2C0", Offset = "0x92EDEC0", VA = "0x1892EF2C0")]
		private static PlayerEvent? BUAMZDBJVXK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x92EF300", Offset = "0x92EDF00", VA = "0x1892EF300", Slot = "4")]
		public bool IMEOTDIGSPB(WJBKOLNRRJE a, WJBKOLNRRJE b, IEnumerable<WJBKOLNRRJE> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x92EFA00", Offset = "0x92EE600", VA = "0x1892EFA00", Slot = "5")]
		public string VKMLBTDEBXO(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x92EF400", Offset = "0x92EE000", VA = "0x1892EF400")]
		internal bool KURPKHUJXIC(WJBKOLNRRJE a, WJBKOLNRRJE b, IEnumerable<WJBKOLNRRJE> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
		{
			return default(bool);
		}
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
